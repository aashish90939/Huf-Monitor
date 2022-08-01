using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace ReadFromserial3
{
    public partial class Form1 : Form
    {

        public event EventHandler<ForwardDataReceivedEventHandler> ForwardDataReceived;

        private void onDataReceived(ForwardDataReceivedEventHandler e)
        {
            if (ForwardDataReceived != null)
            {
                ForwardDataReceived(this, e);
            }
        }
        public class ForwardDataReceivedEventHandler : EventArgs
        {
            public List<List<byte>> m_myEventArgumentdata { get; set; }
        }

        public static Form1 instance;
        public TextBox tb1;

        #region defined global variable

        string sendWith;
        string dataIn; //global varaible data string type
        //string s1mwr;

        // initialized for later...to separate data

        StreamWriter objStreamWriter;
        string pathfile = @"C:\Users\aachary\source\repos\ReadFromserial3\ReadFromserial3\_My source File\SerialData.txt";
        bool state_AppendText = true;

        #endregion
        public Form1()
        {
            InitializeComponent();
            instance = this;
            tb1 = tboxConfig;
        }
        private void SerialDataReceivedEventHandler(object sender, ForwardDataReceivedEventHandler e)
        {

        }
        public void Form1_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            CBoxCOMPORT.Items.AddRange(ports);

            btnOPEN.Enabled = true;
            btnCLOSE.Enabled = false;
            serialPort1.DtrEnable = false;
            chBoxDTREnable.Checked = false;
            chBoxRTSEnable.Checked = false;
            serialPort1.RtsEnable = false;
            btnCLOSE.Enabled = false;
            btnStop.Enabled = false;
            sendWith = "write";
            btnShowdataWith.Text = "Add to Old Data";
            toolStripComboBox3.Text = "Hex";
            CBoxBAUDRATE.Text = Properties.Settings.Default.BaudRate.ToString();
            CBoxCOMPORT.Text = Properties.Settings.Default.ComPort;
            CBoxBAUDRATE.Text = Properties.Settings.Default.BaudRate;
            CBoxDATABITS.Text = Properties.Settings.Default.DataBits;
            CBoxPARITYBITS.Text = Properties.Settings.Default.ParityBits;
            CBoxSTOPBITS.Text = Properties.Settings.Default.StopBits;
            //gboxlogo.Visible = false;
        }
        private void btnRefreshComport_Click(object sender, EventArgs e)
        {
            CBoxCOMPORT.Items.Clear();
            String[] ports = SerialPort.GetPortNames();
            CBoxCOMPORT.Items.AddRange(ports);
        }


        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = CBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(CBoxBAUDRATE.Text);
                serialPort1.DataBits = Convert.ToInt32(CBoxDATABITS.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CBoxSTOPBITS.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), CBoxPARITYBITS.Text);

                serialPort1.Open();
                tboxConfig.Text = CBoxCOMPORT.Text + "-" + CBoxBAUDRATE.Text + "-" + CBoxDATABITS.Text + "-" + CBoxSTOPBITS.Text + "-"
                                  + CBoxPARITYBITS.Text;
                progressBar1.Value = 100;
                btnStop.Enabled = true;
                btnCLOSE.Enabled = true;
                btnOPEN.Enabled = false;
                btnStart.Enabled = false;
                labelCOMportstatus.Text = "ON";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCLOSE.Enabled = false;
                btnOPEN.Enabled = true;
                btnStop.Enabled = false;
                btnStart.Enabled = true;


                labelCOMportstatus.Text = "OFF";
            }
        }

        public void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                btnStart.Enabled = true;
                btnOPEN.Enabled = true;
                labelCOMportstatus.Text = "OFF";

            }
        }


        #region handshake rts dtr
        private void chBoxDTREnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxDTREnable.Checked)
            {
                serialPort1.DtrEnable = true;
                //MessageBox.Show(""DTR Enable" ,MessageBoxButtons.OK,MessageBoxIcon.Warning);......need to fix
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void chBoxRTSEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxRTSEnable.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else
            {
                serialPort1.RtsEnable = false;
            }
        }
        #endregion




        #region readdatafrom serialport
        List<List<byte>> packages = new List<List<byte>>();

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var dataIn = serialPort1.BytesToRead;

            var rest = dataIn % 9;
            byte[] dataBuffer = new byte[dataIn - rest];      // for dataformat new added list dekhi

            serialPort1.Read(dataBuffer, 0, dataIn - rest);

            packages = new List<List<byte>>();
            for (int i = 0; i < dataBuffer.Count() - rest; i += 9)
            {
                var firstList = dataBuffer.ToList().GetRange(i, 9);

                packages.Add((firstList));
            }
            if (packages.Count > 0)
            {
                var eventData = new ForwardDataReceivedEventHandler();
                eventData.m_myEventArgumentdata = packages;

                //eventData.m_myEventArgumentdata = ;
                onDataReceived(eventData);


            }

            this.Invoke(new EventHandler(showData));
            //this methode show the data serial into textbox , cant be shown directly to the textbox
        }

        public void showData(object sender, EventArgs e)
        {
            int pktcount = 0;
            pktcount += packages.Count * 9;
            lbDataInLength.Text = String.Format("{0:00}", pktcount);  //in that format
            foreach (var lst in packages)
            {
                var dataIn = string.Join("", lst.Select(n => n.ToString("X2"))) + '\n';


                if (btnShowdataWith.Text == "Always Update")
                {
                    tBoxDataIN.Text = dataIn;
                }
                else if (btnShowdataWith.Text == "Add to Old Data")
                {
                    tBoxDataIN.AppendText(dataIn);

                }

            }
            #endregion
            //new data save
            try
            {
                objStreamWriter = new StreamWriter(pathfile, state_AppendText);
                objStreamWriter.Write(dataIn);
                objStreamWriter.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }


        private void btnClearDataInReceiver_Click(object sender, EventArgs e)
        {
            if (tBoxDataIN.Text != "")
            {
                tBoxDataIN.Text = "";
            }
        }
        private void btnDemo_Click(object sender, EventArgs e)
        {
            graphSetup gs = new graphSetup();
            gs.ShowDialog();

            Form2 F = new Form2(this);
            F.ShowDialog();
            //Form2 F = new Form2(this);
            //F.ShowDialog();
            //graphSetup gs = new graphSetup();
            //gs.ShowDialog();

        }


        private void toolStripComboBox_appendOrOverwrite_DropDownClosed(object sender, EventArgs e)
        {
            if (toolStripComboBox_appendOrOverwrite.Text == "Append Text")
            {
                state_AppendText = true;
            }
            else
            {
                state_AppendText = false;
            }
        }

        #region open and save file text

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    List<List<byte>> package = new List<List<byte>>();                    //strlist.Add(strfilename);
                    package.Add(File.ReadAllBytes(strfilename).ToList());

                    string filetext = File.ReadAllText(strfilename);
                    //dont need to show message in message box
                    tBoxDataIN.Text = filetext;
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(tBoxDataIN.Text);
                    MessageBox.Show("saved @ " + saveFileDialog1.FileName);
                }
            }
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            this.Close();

        }
        #region unwanted label
        private void ta_Click(object sender, EventArgs e)
        {

        }
        private void endLineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataFormatToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }



        #endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            //    if (gboxComsetup.Visible == false)
            //    {
            //        gboxComsetup.Visible = true;
            //    }
            //    else
            //        gboxComsetup.Visible = false;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //gboxlogo.Visible = false;
            //button1.Text = "Hide settings";
            //if (button1.Text == "Hide settings")
            //{
            //    gboxlogo.Visible = true;
            //}
        }

        private void CBoxCOMPORT_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CBoxBAUDRATE_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BaudRate = CBoxBAUDRATE.Text;
            Properties.Settings.Default.Save();
        }

        private void CBoxDATABITS_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DataBits = CBoxDATABITS.Text;
            Properties.Settings.Default.Save();
        }

        private void CBoxSTOPBITS_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.StopBits = CBoxSTOPBITS.Text;
            Properties.Settings.Default.Save();
        }

        private void CBoxPARITYBITS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBoxPARITYBITS_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ParityBits = CBoxPARITYBITS.Text;
            Properties.Settings.Default.Save();
        }

        private void CBoxCOMPORT_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ComPort = CBoxCOMPORT.Text;
            Properties.Settings.Default.Save();
        }
    }
}
