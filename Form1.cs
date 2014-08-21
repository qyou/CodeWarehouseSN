using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeWarehoseCrack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object versionObj = this.cb_version.SelectedItem;
            if (versionObj == null)
            {
                MessageBox.Show("Please choose the version of Code Warehouse!");
            }
            else
            {
                string version = versionObj.ToString();
                long seed;
                switch (version)
                {
                    case "2.9":
                        seed = 0x23e7023bL;
                        break;
                    default:
                        seed = 0x23e7023bL;
                        break;

                }
                KeyGen gen = new KeyGen(seed);
                string strRegCode = gen.GenerateNextKey();
                if (gen.ValidateKey(strRegCode))
                {
                    this.tb_regCode.Text = strRegCode;
                }
                else
                {
                    MessageBox.Show("Invalidate registration code!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
