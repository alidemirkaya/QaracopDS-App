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
    public partial class Starter : Form
    {
        #region Parameters

        int x = 0;

        #endregion

        #region Form Events

        public Starter()
        {
            InitializeComponent();
        }

        private void Starter_Load(object sender, EventArgs e)
        {
            x = 0;

            TimerSet.Start();
        }

        private void TimerSet_Tick(object sender, EventArgs e)
        {
            if (x < 20)
            {
                x++;
            }

            else
            {
                TimerSet.Stop();

                this.Close();
            }
        }

        #endregion
    }
}
