using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QaracopDS_App.Forms
{
    public partial class Login : Form
    {
        #region Parameters

        #endregion

        #region Class Definitions

        #endregion

        #region Methods

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
    }
}
