using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadFromserial3
{
    public partial class graphSetup : Form
    {
        public static graphSetup instance;
        public int num = 0;
        public graphSetup()
        {
            InitializeComponent();
            instance = this;
           
        }
        #region settings write and saved
        #region sof eof channel labels
        private void tboxSOF_TextChanged(object sender, EventArgs e)
        {
            // Read settings
            //textBoxFoo.Text = Properties.Settings.Default.Foo;

            // Write settings
            Properties.Settings.Default.SOF = tboxSOF.Text;

            // Save settings
            Properties.Settings.Default.Save();
        }

        private void ch1lablel_TextChanged(object sender, EventArgs e)
        {
            // Write settings
            Properties.Settings.Default.ch1Label = ch1lablel.Text;

            // Save settings
            Properties.Settings.Default.Save();
        }
        private void ch2lablel_TextChanged(object sender, EventArgs e)
        {
            // Write settings
            Properties.Settings.Default.ch2Label = ch2lablel.Text;

            // Save settings
            Properties.Settings.Default.Save();
        }

        private void ch3lablel_TextChanged(object sender, EventArgs e)
        {
            // Write settings
            Properties.Settings.Default.ch3Label = ch3lablel.Text;

            // Save settings
            Properties.Settings.Default.Save();
        }

        private void ch4lablel_TextChanged(object sender, EventArgs e)
        {
            // Write settings
            Properties.Settings.Default.ch4Label = ch4lablel.Text;

            // Save settings
            Properties.Settings.Default.Save();
        }

        private void ch5lablel_TextChanged(object sender, EventArgs e)
        {
            // Write settings
            Properties.Settings.Default.ch5Label = ch5lablel.Text;

            // Save settings
            Properties.Settings.Default.Save();
        }

        private void ch6lablel_TextChanged(object sender, EventArgs e)
        {
            // Write settings
            Properties.Settings.Default.ch6Label = ch6lablel.Text;

            // Save settings
            Properties.Settings.Default.Save();
        }
        #endregion
        #region channel 1 
        private void Ch1Byte1_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(Ch1Byte1.Text, out num))
            {
                Properties.Settings.Default.Ch1Byte1 = num;
                Properties.Settings.Default.Save();
            }
            else
            {
                Ch1Byte1.Text = "";
                Properties.Settings.Default.Ch1Byte1 = 901;
            }
               
            

            // Write settings
            //Properties.Settings.Default.Ch1Byte1 = Convert.ToInt32(Ch1Byte1.Text);

        }

        private void Ch1Byte2_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(Ch1Byte2.Text, out num))
            {
                Properties.Settings.Default.Ch1Byte2 = num;
                Properties.Settings.Default.Save();
            }
            else
            {
                Ch1Byte2.Text = "";
                Properties.Settings.Default.Ch1Byte2 = 901;
            }

        }

        private void Ch1Byte3_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(Ch1Byte3.Text, out num))
            {
                Properties.Settings.Default.Ch1Byte3 = num;
                Properties.Settings.Default.Save();
            }
            else
            {
                Ch1Byte3.Text = "";
                Properties.Settings.Default.Ch1Byte3 = 901;
                Properties.Settings.Default.Save();
            }

        }

        private void Ch1Byte4_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(Ch1Byte4.Text, out num))
            {
                Properties.Settings.Default.Ch1Byte4 = num;
                Properties.Settings.Default.Save();
            }
            else
            {
                Ch1Byte4.Text = "";
                Properties.Settings.Default.Ch1Byte4 = 901;
            }
        }
        private void btnch1save_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region channel 2
        private void Ch2Byte1_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(Ch2Byte1.Text, out num))
            {
                Properties.Settings.Default.Ch2Byte1 = num;
                Properties.Settings.Default.Save();
            }
            else
            {
                Ch2Byte1.Text = "";
                Properties.Settings.Default.Ch2Byte1 = 901;
            }
        }

        private void Ch2Byte2_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(Ch2Byte2.Text, out num))
            {
                Properties.Settings.Default.Ch2Byte2 = num;
                Properties.Settings.Default.Save();
            }
            else
            {
                Ch2Byte2.Text = "";
                Properties.Settings.Default.Ch2Byte2 = 901;
            }
        }

        private void Ch2Byte3_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(Ch2Byte3.Text, out num))
            {
                Properties.Settings.Default.Ch2Byte3 = num;
                Properties.Settings.Default.Save();
            }
            else
            {
                Ch2Byte3.Text = "";
                Properties.Settings.Default.Ch2Byte3 = 901;
            }
        }

        private void Ch2Byte4_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(Ch2Byte4.Text, out num))
            {
                Properties.Settings.Default.Ch2Byte4 = num;
                Properties.Settings.Default.Save();
            }
            else
            {
                Ch2Byte4.Text = "";
                Properties.Settings.Default.Ch2Byte4 = 901;
            }
        }
        #endregion

        #endregion





        public string lbl1;
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region ch1
            this.Close();

            
            #endregion

            
        }

       
       
        private void btnReset_Click(object sender, EventArgs e)
        {
            tboxDataLength.Clear();tboxEOF.Clear();tboxSOF.Clear();
            ch1lablel.Clear();ch2lablel.Clear();ch3lablel.Clear();
            ch4lablel.Clear(); ch5lablel.Clear(); ch6lablel.Clear();
            Ch1Byte1.Clear();Ch1Byte2.Clear();Ch1Byte3.Clear();Ch1Byte4.Clear();
            Ch2Byte1.Clear(); Ch2Byte2.Clear(); Ch2Byte3.Clear(); Ch2Byte4.Clear();
            Ch3Byte1.Clear(); Ch3Byte2.Clear(); Ch3Byte3.Clear(); Ch3Byte4.Clear();
            Ch4Byte1.Clear(); Ch4Byte2.Clear(); Ch4Byte3.Clear(); Ch4Byte4.Clear();
            Ch5Byte1.Clear(); Ch5Byte2.Clear(); Ch5Byte3.Clear(); Ch5Byte4.Clear();
            Ch6Byte1.Clear(); Ch6Byte2.Clear(); Ch6Byte3.Clear(); Ch6Byte4.Clear();
            lbl1= ch1lablel.Text;
        }

        private void graphSetup_Load(object sender, EventArgs e)
        {
            //btnSave.Enabled = false;
            Ch1Byte1.Text = Convert.ToString(Properties.Settings.Default.Ch1Byte1);
            Ch1Byte2.Text = Convert.ToString(Properties.Settings.Default.Ch1Byte2);
            Ch1Byte3.Text = Convert.ToString(Properties.Settings.Default.Ch1Byte3);
            Ch1Byte4.Text = Convert.ToString(Properties.Settings.Default.Ch1Byte4);
            Ch2Byte1.Text = Convert.ToString(Properties.Settings.Default.Ch2Byte2);
            Ch2Byte2.Text = Convert.ToString(Properties.Settings.Default.Ch2Byte2);
            Ch2Byte3.Text = Convert.ToString(Properties.Settings.Default.Ch2Byte3);
            Ch2Byte4.Text = Convert.ToString(Properties.Settings.Default.Ch2Byte4);
            Ch3Byte1.Text = Convert.ToString(Properties.Settings.Default.Ch3Byte1);
            Ch3Byte2.Text = Convert.ToString(Properties.Settings.Default.Ch3Byte2);
            Ch3Byte3.Text = Convert.ToString(Properties.Settings.Default.Ch3Byte3);
            Ch3Byte4.Text = Convert.ToString(Properties.Settings.Default.Ch3Byte4);
            Ch4Byte1.Text = Convert.ToString(Properties.Settings.Default.Ch4Byte2);
            Ch4Byte2.Text = Convert.ToString(Properties.Settings.Default.Ch4Byte2);
            Ch4Byte3.Text = Convert.ToString(Properties.Settings.Default.Ch4Byte3);
            Ch4Byte4.Text = Convert.ToString(Properties.Settings.Default.Ch4Byte4);
            Ch5Byte1.Text = Properties.Settings.Default.Ch5Byte1;
            Ch5Byte2.Text = Properties.Settings.Default.Ch5Byte2;
            Ch5Byte3.Text = Properties.Settings.Default.Ch5Byte3;
            Ch5Byte4.Text = Properties.Settings.Default.Ch5Byte4;
            Ch6Byte1.Text = Properties.Settings.Default.Ch6Byte2;
            Ch6Byte2.Text = Properties.Settings.Default.Ch6Byte2;
            Ch6Byte3.Text = Properties.Settings.Default.Ch6Byte3;
            Ch6Byte4.Text = Properties.Settings.Default.Ch6Byte4;



            ch1lablel.Text = Properties.Settings.Default.ch1Label;
            ch2lablel.Text = Properties.Settings.Default.ch2Label;
            ch3lablel.Text = Properties.Settings.Default.ch3Label;
            ch4lablel.Text = Properties.Settings.Default.ch4Label;
            ch5lablel.Text = Properties.Settings.Default.ch5Label;
            ch6lablel.Text = Properties.Settings.Default.ch6Label;

        }

        
    }
}
