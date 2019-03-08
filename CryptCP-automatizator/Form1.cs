using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CryptCP_automatizator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://ru.icons8.com");//открыть рекламную ссылку
        }

        private void Panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData("FileName") is Array data1)
            {
                if ((data1.Length == 1) && (data1.GetValue(0) is String))
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
                if ((data1.Length == 1) && (data1.GetValue(0) is String))
                {
                    file_to_unsign.Text = ((string[])data1)[0];
                    button9.Visible = true;
                }
            }
        }

        private void Panel3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData("FileName") is Array data1)
            {
                if ((data1.Length == 1) && (data1.GetValue(0) is String))
                {
                    file_to_encrypt.Text = ((string[])data1)[0];
                    button10.Visible = true;
                }
            }
        }
        private void Panel4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData("FileName") is Array data1)
            {
                if ((data1.Length == 1) && (data1.GetValue(0) is String))
                {
                    file_to_sign.Text = ((string[])data1)[0];
                    button11.Visible = true;
                }
            }
        }
        string[] Favorite_Certs;
        int parameters_count = 0;
        private void Start()
        {
            if (File.Exists("Parameters.txt"))
            {
                string[] parameters = File.ReadAllLines("Parameters.txt");
                parameters_count = parameters.Length;
                for (int i = 0; i < parameters.Length; i++)
                {
                    string[] parameter = parameters[i].Split('\t');
                    switch (parameter[0])
                    {
                        case "Work_folder":
                            Work_folder.Text = parameter[1];
                            break;
                        case "My_Cert": //    Заполняем поле "Выбранный шаблон документы"
                            My_Cert.Text = parameter[1];
                            break;
                        case "FileName_Decrypted": //  Заполняем поле "Выбранный шаблон замены"
                            FileName_Decrypted.Text = parameter[1];
                            break;
                        case "FileName_Encrypted": //  Заполняем поле "Выбранный шаблон замены"
                            FileName_Encrypted.Text = parameter[1];
                            break;
                        case "FileName_Signed": //  Заполняем поле "Выбранный шаблон замены"
                            FileName_Signed.Text = parameter[1];
                            break;
                        case "FileName_UnSigned": //  Заполняем поле "Выбранный шаблон замены"
                            FileName_UnSigned.Text = parameter[1];
                            break;
                        case "CryptCP_folder": //  Заполняем поле "Выбранный шаблон замены"
                            CryptCP_folder.Text = parameter[1];
                            break;
                        case "Favorite_Certs": //   Заполняем список избранных сертификатов
                            Favorite_Certs = parameter[1].Split('|');
                            break;
                        default: break;
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            startInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                UseShellExecute = false,
                FileName = "cmd.exe",
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Start();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            folderDlg.SelectedPath = Environment.CurrentDirectory;

            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                Work_folder.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
            Save_Parameters();
        }
        Cert_selector CS;
        private void Button6_Click(object sender, EventArgs e)
        {
            My_Cert.Text = Select_Cert("Выберите свой сертификат");
            Save_Parameters();
        }
        private void Save_Parameters()
        {
            try
            {
                string[] content = new string[parameters_count];
                content[0] = "Work_folder\t" + Work_folder.Text;
                content[1] = "My_Cert\t" + My_Cert.Text;
                content[2] = "FileName_Decrypted\t" + FileName_Decrypted.Text;
                content[3] = "FileName_Encrypted\t" + FileName_Encrypted.Text;
                content[4] = "FileName_Signed\t" + FileName_Signed.Text;
                content[5] = "FileName_UnSigned\t" + FileName_UnSigned.Text;
                content[6] = "CryptCP_folder\t" + CryptCP_folder.Text;
                content[7] = "Favorite_Certs\t" + String.Join("|", Favorite_Certs);
                File.WriteAllLines(Environment.CurrentDirectory + "\\Parameters.txt", content);
            }
            catch { }
        }

        private void Panel1_DragDrop(object sender, DragEventArgs e)
        {

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

        private void Button4_Click(object sender, EventArgs e)
        {
            if (file_to_sign.Text.Equals(""))
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog//выбор файла для подписания
                {
                    InitialDirectory = Work_folder.Text,
                    Title = "Выберите файл для подписания"
                };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file_to_sign.Text = openFileDialog1.FileName;
                }
            }
            string command = "/K " + @CryptCP_folder.Text + " -sign -dn \"" + @My_Cert.Text + "\" -uMy \"" + file_to_sign.Text + "\" \"" + @Work_folder.Text + @"\" + @FileName_Signed.Text+ "\"";
            startInfo.Arguments = command;
            Process.Start(startInfo);
            File.AppendAllText("EventLog.txt", command + Environment.NewLine);
            file_to_sign.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (file_to_encrypt.Text.Equals(""))
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog//Выбор файла для зашифрования
                {
                    InitialDirectory = Work_folder.Text,
                    Title = "Выберите файл для зашифрования"
                };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file_to_encrypt.Text = openFileDialog1.FileName;
                }
            }
            string command = @"/K " + @CryptCP_folder.Text + " -encr -dn \"" + @Select_Cert("Выберите получателя для зашифрования") + "\" -uMy \"" + file_to_encrypt.Text + "\" \"" + @Work_folder.Text + @"\" + @FileName_Encrypted.Text+ "\"";
            startInfo.Arguments = command;
            File.AppendAllText("EventLog.txt", command + Environment.NewLine);
            Process.Start(startInfo);
        }
        private ProcessStartInfo startInfo = new ProcessStartInfo();
        private void Button2_Click(object sender, EventArgs e)
        {
            if (file_to_unsign.Text.Equals(""))
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog//Выбор файла для проверки подписи
                {
                    InitialDirectory = Work_folder.Text,
                    Title = "Выберите файл для проверки подписи"
                };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file_to_unsign.Text = openFileDialog1.FileName;
                }
            }
            string command = @"/K " + @CryptCP_folder.Text + " -verify -dn \"" + @Select_Cert("Выберите подписавшего") + "\" -uMy \"" + file_to_unsign.Text + "\" \"" + @Work_folder.Text + @"\" + FileName_UnSigned.Text+ "\"";
            File.AppendAllText("EventLog.txt", command + Environment.NewLine);
            startInfo.Arguments = command;
            Process.Start(startInfo);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (file_to_decrypt.Text.Equals(""))
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog//выбор файла для расшифрования
                {
                    InitialDirectory = Work_folder.Text,
                    Title = "Выберите файл для расшифрования"
                };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file_to_decrypt.Text = openFileDialog1.FileName;
                }
            }
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                UseShellExecute = false,
                FileName = "cmd.exe",
                WindowStyle = ProcessWindowStyle.Hidden
            };
            string command = @"/K " + @CryptCP_folder.Text + " -decr -dn \"" + @My_Cert.Text + "\" -uMy \"" + file_to_decrypt.Text + "\" \"" + @Work_folder.Text + @"\" + FileName_Decrypted.Text+ "\"";
            startInfo.Arguments = command;
            File.AppendAllText("EventLog.txt", command + Environment.NewLine);
            Process.Start(startInfo);
        }
        /// <summary>
        /// Открывает окно выбора сертификата
        /// </summary>
        /// <param name="title">Выберите свой сертификат</param>
        /// <returns></returns>
        private string Select_Cert(string title)
        {
            string Selected_cert = "";
            CS = new Cert_selector(title,Favorite_Certs);
            CS.ShowDialog();
            if (CS.DialogResult == DialogResult.OK)
            {
                Selected_cert = CS.Get_Selected_Cert();
                Favorite_Certs = CS.Get_Favorite_Certs();
                Save_Parameters();
            }
            CS.Dispose();
            return Selected_cert;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            file_to_decrypt.Text = ""; button8.Visible = false;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            file_to_unsign.Text = ""; button9.Visible = false;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            file_to_encrypt.Text = ""; button10.Visible = false;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            file_to_sign.Text = ""; button11.Visible = false;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/sergiomarotco/CryptCP-automatizator");
        }
    }
}
