using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CryptCP_automatizator
{
    /// <summary>
    /// Основной класс.
    /// </summary>
    public partial class Form1 : Form
    {
        private string[] favoriteCerts;
        private int parametersCount = 0;
        private Cert_selector certSelector;
        private ProcessStartInfo startInfo = new ProcessStartInfo();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://ru.icons8.com"); // открыть рекламную ссылку
        }

        private void Panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData("FileName") is Array data1)
            {
                if ((data1.Length == 1) && (data1.GetValue(0) is string))
                {
                    file_to_decrypt.Text = ((string[])data1)[0];
                    button8.Visible = true;
                }
            }
        }

        private void Panel2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData("FileName") is Array data1)
            {
                if ((data1.Length == 1) && (data1.GetValue(0) is string))
                {
                    file_to_unsign.Text = ((string[])data1)[0];
                    button8.Visible = true;
                }
            }
        }

        private void Panel3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData("FileName") is Array data1)
            {
                if ((data1.Length == 1) && (data1.GetValue(0) is string))
                {
                    file_to_encrypt.Text = ((string[])data1)[0];
                    button8.Visible = true;
                }
            }
        }

        private void Panel4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData("FileName") is Array data1)
            {
                if ((data1.Length == 1) && (data1.GetValue(0) is string))
                {
                    file_to_sign.Text = ((string[])data1)[0];
                    button8.Visible = true;
                }
            }
        }

        private void Load_Parameters()
        {
            string[] parameters = File.ReadAllLines("Parameters.txt");
            parametersCount = parameters.Length;
            for (int i = 0; i < parameters.Length; i++)
            {
                string[] parameter = parameters[i].Split('\t');
                switch (parameter[0])
                {
                    case "Work_folder":
                        Work_folder.Text = parameter[1];
                        break;
                    case "My_Cert": // Заполняем поле "Выбранный шаблон документы"
                        My_Cert.Text = parameter[1];
                        break;
                    case "CryptCP_folder": // Заполняем поле "Выбранный шаблон замены"
                        CryptCP_folder.Text = parameter[1];
                        break;
                    case "Favorite_Certs": // Заполняем список избранных сертификатов
                        favoriteCerts = parameter[1].Split('|');
                        break;
                    default: break;
                }
            }
        }

        private void Start()
        {
            if (File.Exists("Parameters.txt"))
            {
                Load_Parameters();
            }
            else
            {
                Generate_Parameters();
            }
        }

        private void Generate_Parameters()
        {
            string[] text = new string[]
            {
                    "Work_folder\t" + @Environment.CurrentDirectory,
                    "My_Cert\t" + "CN=Выберите_ваш_CN",
                    "FileName_Decrypted\tDecrypted",
                    "FileName_Encrypted\tEncrypted",
                    "FileName_Signed\tSigned",
                    "FileName_UnSigned\tUnSigned",
                    "CryptCP_folder\t" + @Environment.CurrentDirectory,
                    "Favorite_Certs\t" + @"CN=Введите_ваш_CN|CN=Введите_ваш_CN_2|CN=Введите_ваш_CN_3",
            };
            File.WriteAllLines(Environment.CurrentDirectory + "\\Parameters.txt", text);
            Load_Parameters(); // https://github.com/sergiomarotco/CryptCP-automatizator/issues/3
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                UseShellExecute = false,
                FileName = "cmd.exe",
                WindowStyle = ProcessWindowStyle.Hidden,
            };
            Start();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                SelectedPath = Environment.CurrentDirectory,
            };

            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                Work_folder.Text = folderDlg.SelectedPath;
                _ = folderDlg.RootFolder;
            }

            Save_Parameters();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            My_Cert.Text = Select_Cert("Выберите свой сертификат");
            Save_Parameters();
        }

        private void Save_Parameters()
        {
            if (File.Exists(Environment.CurrentDirectory + "\\Parameters.txt"))
            {
                try
                {
                    string[] content = new string[parametersCount];
                    content[0] = "Work_folder\t" + Work_folder.Text;
                    content[1] = "My_Cert\t" + My_Cert.Text;
                    content[6] = "CryptCP_folder\t" + CryptCP_folder.Text;
                    content[7] = "Favorite_Certs\t" + string.Join("|", favoriteCerts);
                    File.WriteAllLines(Environment.CurrentDirectory + "\\Parameters.txt", content);
                }
                catch
                {
                }
            }
            else
            {
                Generate_Parameters();
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Исполняемые файлы(*.exe)|*.exe" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CryptCP_folder.Text = openFileDialog1.FileName;
                Save_Parameters();
            }
        }

        private void Button4_Sign(object sender, EventArgs e)
        {
            if (file_to_sign.Text.Equals(string.Empty))
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog // выбор файла для подписания
                {
                    InitialDirectory = Work_folder.Text,
                    Title = "Выберите файл для подписания",
                };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file_to_sign.Text = openFileDialog1.FileName;
                    button8.Visible = true;
                }
            }

            if (!My_Cert.Text.Equals("CN=InputYourCN"))
            {
                if (!string.IsNullOrEmpty(My_Cert.Text))
                {
                    if (File.Exists(file_to_sign.Text))
                    {
                        FileInfo info = new FileInfo(file_to_sign.Text);
                        string filename = info.Name.Split('.')[0];
                        string filetype = info.Extension;

                        string command = "/K " + @CryptCP_folder.Text + " -sign -dn \"" + @My_Cert.Text + "\" -uMy \"" + @file_to_sign.Text + "\" \"" + @Work_folder.Text + @"\" + filename + "_" + "Signed" + filetype + "\"";
                        startInfo.Arguments = command;
                        Process.Start(startInfo);
                        File.AppendAllText("EventLog.txt", command + Environment.NewLine);
                        file_to_encrypt.Text = @Work_folder.Text + @"\" + filename + "_" + "Signed" + filetype;
                    }
                    else
                    {
                        MessageBox.Show("Не удается открыть выбранный файл");
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали Сертифика КПЭП (поле не заполнено)");
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали Сертифика КПЭП (поле содержит CN по умолчанию)");
            }
        }

        private void Button3_Encrypt(object sender, EventArgs e)
        {
            if (file_to_encrypt.Text.Equals(string.Empty))
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog // Выбор файла для зашифрования
                {
                    InitialDirectory = Work_folder.Text,
                    Title = "Выберите файл для зашифрования",
                };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file_to_encrypt.Text = openFileDialog1.FileName;
                    button8.Visible = true;
                }
            }

            if (File.Exists(file_to_encrypt.Text))
            {
                FileInfo info = new FileInfo(file_to_encrypt.Text);
                string filename = info.Name.Split('.')[0];
                string filetype = info.Extension;

                string command = @"/K " + @CryptCP_folder.Text + " -encr -dn \"" + @Select_Cert("Выберите получателя для зашифрования") + "\" -uMy \"" + @file_to_encrypt.Text + "\" \"" + @Work_folder.Text + @"\" + filename + "_" + "Encrypted" + filetype + "\"";
                startInfo.Arguments = @command;
                File.AppendAllText("EventLog.txt", command + Environment.NewLine);
                Process.Start(startInfo);
                file_to_sign.Text = @Work_folder.Text + @"\" + filename + "_" + "Encrypted" + filetype;
                button8.Visible = true;
            }
        }

        private void Button2_Verify(object sender, EventArgs e)
        {
            if (file_to_unsign.Text.Equals(string.Empty))
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog // Выбор файла для проверки подписи
                {
                    InitialDirectory = Work_folder.Text,
                    Title = "Выберите файл для проверки подписи",
                };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file_to_unsign.Text = openFileDialog1.FileName;
                    button8.Visible = true;
                }
            }

            if (File.Exists(file_to_unsign.Text))
            {
                FileInfo info = new FileInfo(file_to_unsign.Text);
                string filename = info.Name.Split('.')[0];
                string filetype = info.Extension;

                string command = @"/K " + @CryptCP_folder.Text + " -verify -dn \"" + @Select_Cert("Выберите подписавшего") + "\" -uMy \"" + @file_to_unsign.Text + "\" \"" + @Work_folder.Text + @"\" + filename + "_" + "UnSigned" + filetype + "\"";
                File.AppendAllText("EventLog.txt", command + Environment.NewLine);
                startInfo.Arguments = command;
                Process.Start(startInfo);
                file_to_decrypt.Text = @Work_folder.Text + @"\" + filename + "_" + "UnSigned.Text" + filetype;
                button8.Visible = true;
            }
        }

        private void Button1_Decrypt(object sender, EventArgs e)
        {
            if (file_to_decrypt.Text.Equals(string.Empty))
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog // выбор файла для расшифрования
                {
                    InitialDirectory = Work_folder.Text,
                    Title = "Выберите файл для расшифрования",
                };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                { // файл выбран - да
                    file_to_decrypt.Text = openFileDialog1.FileName;
                    button8.Visible = true;
                }
            }

            if (!My_Cert.Text.Equals("CN=InputYourCN"))
            {
                if (!string.IsNullOrEmpty(My_Cert.Text))
                {
                    if (File.Exists(file_to_decrypt.Text))
                    {
                        FileInfo info = new FileInfo(file_to_decrypt.Text);
                        string filename = info.Name.Split('.')[0];
                        string filetype = info.Extension;

                        string command = @"/K " + @CryptCP_folder.Text + " -decr -dn \"" + @My_Cert.Text + "\" -uMy \"" + @file_to_decrypt.Text + "\" \"" + @Work_folder.Text + @"\" + filename + "_" + "Decrypted" + filetype + "\"";
                        startInfo.Arguments = command;
                        File.AppendAllText("EventLog.txt", command + Environment.NewLine);
                        Process.Start(startInfo);
                        file_to_unsign.Text = @Work_folder.Text + @"\" + filename + "_" + "Decrypted" + filetype;

                        button8.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Не удается открыть выбранный файл");
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали Сертифика КПЭП (поле не заполнено)");
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали Сертифика КПЭП (поле содержит CN по умолчанию)");
            }
        }

        /// <summary>
        /// Открывает окно выбора сертификата.
        /// </summary>
        /// <param name="title">Выберите свой сертификат.</param>
        /// <returns>Наименование выбранного сертификата.</returns>
        private string Select_Cert(string title)
        {
            string selected_cert = string.Empty;
            certSelector = new Cert_selector(title, favoriteCerts);
            certSelector.ShowDialog();
            if (certSelector.DialogResult == DialogResult.OK)
            {
                selected_cert = certSelector.Get_Selected_Cert();
                favoriteCerts = certSelector.Get_Favorite_Certs();
                Save_Parameters();
            }

            certSelector.Dispose();
            return selected_cert;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            file_to_decrypt.Text = string.Empty;
            file_to_unsign.Text = string.Empty;
            file_to_encrypt.Text = string.Empty;
            file_to_sign.Text = string.Empty;
            button8.Visible = false;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/sergiomarotco/CryptCP-automatizator");
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", Work_folder.Text);
        }

        private void FileName_Decrypted_TextChanged(object sender, EventArgs e)
        {
            Save_Parameters();
        }

        private void FileName_UnSigned_TextChanged(object sender, EventArgs e)
        {
            Save_Parameters();
        }

        private void FileName_Encrypted_TextChanged(object sender, EventArgs e)
        {
            Save_Parameters();
        }

        private void FileName_Signed_TextChanged(object sender, EventArgs e)
        {
            Save_Parameters();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_decrypt.Text))
            {
                try
                {
                    Process.Start("explorer.exe", @"/select, " + file_to_decrypt.Text);
                }
                catch
                {
                }
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_unsign.Text))
            {
                try
                {
                    Process.Start("explorer.exe", @"/select, " + file_to_unsign.Text);
                }
                catch
                {
                }
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_encrypt.Text))
            {
                try
                {
                    Process.Start("explorer.exe", @"/select, " + file_to_encrypt.Text);
                }
                catch
                {
                }
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_sign.Text))
            {
                try
                {
                    Process.Start("explorer.exe", @"/select, " + file_to_sign.Text);
                }
                catch
                {
                }
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_unsign.Text))
            {
                try
                {
                    Process.Start("explorer.exe", @"/select, " + file_to_unsign.Text);
                }
                catch
                {
                }
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_decrypt.Text))
            {
                try
                {
                    Process.Start("explorer.exe", @"/select, " + file_to_decrypt.Text);
                }
                catch
                {
                }
            }
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_sign.Text))
            {
                try
                {
                    Process.Start("explorer.exe", @"/select, " + file_to_sign.Text);
                }
                catch
                {
                }
            }
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_encrypt.Text))
            {
                try
                {
                    Process.Start("explorer.exe", @"/select, " + file_to_encrypt.Text);
                }
                catch
                {
                }
            }
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            if (File.Exists(CryptCP_folder.Text))
            {
                try
                {
                    Process.Start("explorer.exe", @"/select, " + CryptCP_folder.Text);
                }
                catch
                {
                }
            }
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_unsign.Text))
            {
                System.Collections.Specialized.StringCollection replacementList = new System.Collections.Specialized.StringCollection
                {
                    file_to_unsign.Text,
                };
                Clipboard.SetFileDropList(replacementList);
            }
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_decrypt.Text))
            {
                System.Collections.Specialized.StringCollection replacementList = new System.Collections.Specialized.StringCollection
                {
                    file_to_decrypt.Text,
                };
                Clipboard.SetFileDropList(replacementList);
            }
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_sign.Text))
            {
                System.Collections.Specialized.StringCollection replacementList = new System.Collections.Specialized.StringCollection
                {
                    file_to_sign.Text,
                };
                Clipboard.SetFileDropList(replacementList);
            }
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_encrypt.Text))
            {
                System.Collections.Specialized.StringCollection replacementList = new System.Collections.Specialized.StringCollection
                {
                    file_to_encrypt.Text,
                };
                Clipboard.SetFileDropList(replacementList);
            }
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_unsign.Text))
            {
                File.Delete(file_to_unsign.Text);
            }
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_decrypt.Text))
            {
                File.Delete(file_to_decrypt.Text);
            }
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_sign.Text))
            {
                File.Delete(file_to_sign.Text);
            }
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_encrypt.Text))
            {
                File.Delete(file_to_sign.Text);
            }
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_unsign.Text))
            {
                File.Delete(file_to_unsign.Text);
            }
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_encrypt.Text))
            {
                File.Delete(file_to_encrypt.Text);
            }
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_sign.Text))
            {
                File.Delete(file_to_sign.Text);
            }
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_to_decrypt.Text))
            {
                File.Delete(file_to_decrypt.Text);
            }
        }

        private void Work_folder_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(Work_folder.Text))
            {
                Work_folder.Text = Work_folder.Text;
                Save_Parameters();
            }
        }

        private void Button34_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }
    }
}
