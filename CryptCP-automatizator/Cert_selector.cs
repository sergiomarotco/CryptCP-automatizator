using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace CryptCP_automatizator
{
    public partial class Cert_selector : Form
    {
        public Cert_selector(string[] Favorite_Certs)
        {
            InitializeComponent();
            this.Favorite_Certs = Favorite_Certs;
            listBox2.Items.AddRange(Favorite_Certs);
        }
        public Cert_selector(string form_text, string[] Favorite_Certs)
        {
            InitializeComponent();
            this.Favorite_Certs = Favorite_Certs;
            this.Text = form_text;
            listBox2.Items.AddRange(Favorite_Certs);
        }
        string Selected_Cert = "";
        public List<string> Certs = new List<string>();

        private void Cert_selector_Load(object sender, EventArgs e)
        {
            var store = new X509Store("MY", StoreLocation.CurrentUser);

            store.Open(OpenFlags.ReadOnly);

            var certificates = store.Certificates;
            foreach (var certificate in certificates)
            {
                string friendlyName = certificate.FriendlyName;
                string xname = certificate.SubjectName.Name; //obsolete
                //xname = xname.Substring(3, xname.Length-3);
                Certs.Add(xname);
            }
            listBox1.DataSource = Certs;
            store.Close();
            button1.Focus();
        }

        internal string Get_Selected_Cert()
        {
            return Selected_Cert;
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
                listBox1.DataSource = Certs.Where(c => c.ToLower().Contains(textBox1.Text.ToLower())).ToList();
            else
                listBox1.DataSource = Certs;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string xname = listBox1.SelectedItem.ToString().Split(',')[0];
                xname = xname.Substring(3, xname.Length - 3);
                xname = xname.Trim('"');
                xname = xname.Replace("\"", "\"\"");//экранируем кавычки для тупого cmd
                Selected_Cert = xname;
                label4.Text = xname;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            Favorite_Certs = listBox2.Items.OfType<string>().ToArray();
        }
        string[] Favorite_Certs;
        internal string[] Get_Favorite_Certs()
        {
            return Favorite_Certs;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                Favorite_Certs = listBox2.Items.OfType<string>().ToArray();
                listBox2.Focus();
                if (listBox2.Items.Count != 0)
                    listBox2.SelectedIndex = 0;
            }
        }

        private void Cert_selector_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Favorite_Certs = listBox2.Items.OfType<string>().ToArray();
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
                Selected_Cert = listBox2.SelectedItem.ToString();
                label4.Text = Selected_Cert;
            }
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {//https://github.com/sergiomarotco/CryptCP-automatizator/issues/4
            if (listBox2.SelectedItems.Count > 0)
            {
                Selected_Cert = listBox2.SelectedItem.ToString();
                label4.Text = Selected_Cert;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string xname = listBox1.SelectedItem.ToString().Split(',')[0];
                xname = xname.Substring(3, xname.Length - 3);
                xname = xname.Trim('"');
                xname = xname.Replace("\"", "\"\"");//экранируем кавычки для тупого cmd
                Selected_Cert = xname;
                label4.Text = xname;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
