using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace CryptCP_automatizator
{
    /// <summary>
    /// Класс выбора сертификата.
    /// </summary>
    public partial class Cert_selector : Form
    {
        private string[] favoriteCerts;
        private List<string> certs = new List<string>();
        private string selectedCert = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cert_selector"/> class.
        /// </summary>
        /// <param name="form_text">Отображаемый заголовок формы.</param>
        /// <param name="favorite_Certs">Список избранных сертификатов.</param>
        public Cert_selector(string form_text, string[] favorite_Certs)
        {
            InitializeComponent();
            this.favoriteCerts = favorite_Certs;
            this.Text = form_text;
            listBox2.Items.AddRange(favorite_Certs);
        }

        /*protected Cert_selector(string[] favorite_Certs)
        {
            InitializeComponent();
            this.Favorite_Certs = favorite_Certs;
            listBox2.Items.AddRange(favorite_Certs);
        }*/

        /// <summary>
        /// Gets список выбранных сертификатов.
        /// </summary>
        /// <returns>Список выбранных сертификатов.</returns>
        internal string Get_Selected_Cert()
        {
            return selectedCert;
        }

        /// <summary>
        /// Возвращает список избранных сертификатов.
        /// </summary>
        /// <returns>Список избранных сертификатов.</returns>
        internal string[] Get_Favorite_Certs()
        {
            return favoriteCerts;
        }

        private void Cert_selector_Load(object sender, EventArgs e)
        {
            var store = new X509Store("MY", StoreLocation.CurrentUser);

            store.Open(OpenFlags.ReadOnly);

            var certificates = store.Certificates;
            foreach (var certificate in certificates)
            {
                _ = certificate.FriendlyName;
                certs.Add(certificate.SubjectName.Name);
            }

            listBox1.DataSource = certs;
            store.Close();
            textBox1.Focus();
            textBox1.Select();
            this.ActiveControl = textBox1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                listBox1.DataSource = certs.Where(c => c.ToLower().Contains(textBox1.Text.ToLower())).ToList();
            }
            else
            {
                listBox1.DataSource = certs;
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string xname = listBox1.SelectedItem.ToString().Split(',')[0];
                xname = xname.Substring(3, xname.Length - 3);
                xname = xname.Trim('"');
                xname = xname.Replace("\"", "\"\""); // экранируем кавычки для тупого cmd
                selectedCert = xname;
                label4.Text = xname;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            favoriteCerts = listBox2.Items.OfType<string>().ToArray();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                favoriteCerts = listBox2.Items.OfType<string>().ToArray();
                listBox2.Focus();
                if (listBox2.Items.Count != 0)
                {
                    listBox2.SelectedIndex = 0;
                }
            }
        }

        private void Cert_selector_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                favoriteCerts = listBox2.Items.OfType<string>().ToArray();
            }
            else
            {
                DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                selectedCert = listBox2.SelectedItem.ToString();
                label4.Text = selectedCert;
            }
        }

        private void ListBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        { // https://github.com/sergiomarotco/CryptCP-automatizator/issues/4
            if (listBox2.SelectedItems.Count > 0)
            {
                selectedCert = listBox2.SelectedItem.ToString();
                label4.Text = selectedCert;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string xname = listBox1.SelectedItem.ToString().Split(',')[0];
                xname = xname.Substring(3, xname.Length - 3);
                xname = xname.Trim('"');
                xname = xname.Replace("\"", "\"\""); // экранируем кавычки для тупого cmd
                selectedCert = xname;
                label4.Text = xname;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
