using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QaracopDS_App.Forms
{
    public partial class Login : Form
    {
        #region Parameters
        public int Id { get; set; }
        #endregion

        #region Class Definitions

        #endregion

        #region Methods
        public void PersonelKayit()
        {
            DialogResult dr = MessageBox.Show("Kayıt Yapmak İstiyor Musunuz ?", "Yeni Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                XElement XDoc = XElement.Load(@"Personal.xml");
                bool sor = XDoc.Elements("Personal").Any();
                if (sor == true)
                {
                    IdGetir();
                }
                else
                {
                    Id = 1;
                }
                XDoc.Add(new XElement("Personal",
                    new XElement("PersonalId",Convert.ToString(Id)),
                    new XElement("PersonalName", TextUserName.Text),
                    new XElement("PersonalSurname", TextPassword.Text),
                    new XElement("PersonalEmail", TextEmail.Text),
                    new XElement("PersonalUserName", TextLoginName.Text),
                    new XElement("PersonalPassword", TextLoginPassword.Text),
                    new XElement("PersonalStatus","1")));                
                XDoc.Save(@"Personal.xml");
                Temizle();
                MessageBox.Show("Kayıt Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void IdGetir()
        {
            XElement xElement = XElement.Load(@"Personal.xml");

            var emps = xElement.Descendants("Personal").Reverse().Take(1);

            foreach (var emp in emps)
            {
                Id = Convert.ToInt32(emp.Element("PersonalId").Value);
                Id++;
            }
        }
        public void Temizle()
        {
            TextUserName.Clear();
            TextPassword.Clear();
            TextEmail.Clear();
            TextLoginName.Clear();
            TextLoginPassword.Clear();
        }
        public static bool PersonelGiris(string user, string password)
        {
            XDocument doc = XDocument.Load(@"Personal.xml");
            return doc.Descendants("Personal").Where(x => x.Element("PersonalUserName").Value == user && x.Element("PersonalPassword").Value == password).Any();
        }
        #endregion
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            BtnSignUp.IdleFillColor = Color.Transparent;
            BtnSignIn.IdleFillColor = Color.DarkViolet;
            BtnSignIn.IdleForecolor = Color.White;
            BtnSignUp.IdleForecolor = Color.Black;

            this.Size = new Size(600, 400);
            PicCar.Size = new Size(395, 400);
            BtnLogin.Location = new Point(35, 335);

            TextUserName.TextPlaceholder = "User Name";
            TextPassword.TextPlaceholder = "Password";
            BtnLogin.ButtonText = "SIGN IN";

            TextEmail.Visible = false;
            TextLoginName.Visible = false;
            TextLoginPassword.Visible = false;
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            BtnSignUp.IdleFillColor = Color.Transparent;
            BtnSignIn.IdleFillColor = Color.DarkViolet;
            BtnSignIn.IdleForecolor = Color.White;
            BtnSignUp.IdleForecolor = Color.Black;

            this.Size = new Size(600, 400);
            PicCar.Size = new Size(395, 400);
            BtnLogin.Location = new Point(35, 335);

            TextUserName.TextPlaceholder = "User Name";
            TextPassword.TextPlaceholder = "Password";
            BtnLogin.ButtonText = "SIGN IN";

            TextEmail.Visible = false;
            TextLoginName.Visible = false;
            TextLoginPassword.Visible = false;


        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            BtnSignUp.IdleFillColor = Color.DarkViolet;
            BtnSignIn.IdleFillColor = Color.Transparent;
            BtnSignIn.IdleForecolor = Color.Black;
            BtnSignUp.IdleForecolor = Color.White;

            this.Size = new Size(600, 570);
            PicCar.Size = new Size(395, 570);
            BtnLogin.Location = new Point(35, 495);


            TextUserName.TextPlaceholder = "Name";
            TextPassword.TextPlaceholder = "Surname";
            BtnLogin.ButtonText = "CREATE ACCOUNT";

            TextEmail.Visible = true;
            TextLoginName.Visible = true;
            TextLoginPassword.Visible = true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(BtnLogin.ButtonText=="CREATE ACCOUNT")
            {
                PersonelKayit();
            }
            else
            {
                bool gonder = PersonelGiris(TextUserName.Text, TextPassword.Text);
                if (gonder == true)
                {
                    MessageBox.Show("Giriş Başarılı");
                }
                else
                {
                    MessageBox.Show("Giriş Hatalı");
                }
            }
        }
    }
}
