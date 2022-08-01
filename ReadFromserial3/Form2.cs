using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static ReadFromserial3.Form1;
using static ReadFromserial3.graphSetup;
using ZedGraph;
using System.IO;


namespace ReadFromserial3
{
 
    public partial class Form2 :Form 
    {
        GraphPane myPaneKick = new GraphPane();
        PointPairList listpointMypane = new PointPairList();
        PointPairList listpointMypane2 = new PointPairList();
        PointPairList listpointMypane3 = new PointPairList();
        PointPairList listpointMypane4 = new PointPairList();
        PointPairList listpointMypane5 = new PointPairList();
        PointPairList listpointMypane6 = new PointPairList();
       
        LineItem mycurveMypane;
        LineItem mycurveMypane2;
        LineItem mycurveMypane3;
        LineItem mycurveMypane4;
        LineItem mycurveMypane5;
        LineItem mycurveMypane6;
        
        double glass = 0;
        String sensor_2;
        //Graphics g;


        // public delegate void SerialDataReceivedEventHandler(object se nder, ForwardDataReceivedEventHandler e);
        Form1 form1;
        graphSetup graphSetup;
        public static Form2 instance;
        public int TickStart , mode = 1;
        //public double time = 0; 

        public Form2(Form1 form1Arg)
        {
            form1= form1Arg;
            //graphSetup = graphsetupArg;
            this.InitializeComponent();
            instance = this;

            }
       
        private void graphicControl()
        {
            myPaneKick = zedGraphControl1.GraphPane;
            myPaneKick.Title.Text = "KickSensor Data";
            myPaneKick.XAxis.Title.Text = "Time lapse";
            myPaneKick.YAxis.Title.Text = "Value";
            zedGraphControl1.GraphPane.Legend.IsVisible = true;
            myPaneKick.Legend.IsVisible = true;
            myPaneKick.YAxis.Scale.Min = 0;
            myPaneKick.YAxis.Scale.Max = 2000;
            //myPaneKick.YAxis.ResetAutoScale(myPaneKick, g);  new edit 
            //myPaneKick.AddYAxis(sensor_2); new edit 20.07
            myPaneKick.XAxis.Scale.Min = 0;   //xaxis recent edits
            myPaneKick.XAxis.Scale.Max = 30;
            myPaneKick.XAxis.Scale.MinorStep = 1;
            myPaneKick.XAxis.Scale.MajorStep = 5;



            mycurveMypane = myPaneKick.AddCurve(Properties.Settings.Default.ch1Label, listpointMypane, System.Drawing.Color.MediumPurple, SymbolType.None);
            mycurveMypane.Line.Width = 2;
            mycurveMypane2 = myPaneKick.AddCurve(Properties.Settings.Default.ch2Label, listpointMypane2, System.Drawing.Color.Red, SymbolType.None);
            mycurveMypane2.Line.Width = 2;
            mycurveMypane3 = myPaneKick.AddCurve(Properties.Settings.Default.ch3Label, listpointMypane3, System.Drawing.Color.Orange, SymbolType.None);
            mycurveMypane3.Line.Width = 2;
            mycurveMypane4 = myPaneKick.AddCurve(Properties.Settings.Default.ch4Label, listpointMypane4, System.Drawing.Color.Green, SymbolType.None);
            mycurveMypane4.Line.Width = 2;

            myPaneKick.AxisChange();
            //save the beginning time for reference
            TickStart = Environment.TickCount;

        }

        public void myDataReceivedFromForm1(object sender, ForwardDataReceivedEventHandler e)
        {
            
            
            var packet = e.m_myEventArgumentdata.ToArray();
          foreach(var lst in packet)
            {
                //glass += 0.1;
                double time = (Environment.TickCount - TickStart) / 1000.0;
                #region channelSwitch
                if (channel1.Checked == true)
                {
                    //listpointMypane.Add(new PointPair(glass, Convert.ToDouble(lst[0])));
                    double r;
                    try
                    {
                        if (Properties.Settings.Default.Ch1Byte1 != 901)
                        {
                            if (Properties.Settings.Default.Ch1Byte1 != 901 &&
                                Properties.Settings.Default.Ch1Byte2 == 901)
                            {
                                r = lst[Properties.Settings.Default.Ch1Byte1];
                                listpointMypane.Add(new PointPair(time, r));
                            }
                            else if (Properties.Settings.Default.Ch1Byte1 != 901 &&
                                Properties.Settings.Default.Ch1Byte2 != 901)
                            {
                                r = lst[Properties.Settings.Default.Ch1Byte1] << 8 |
                                    lst[Properties.Settings.Default.Ch1Byte2];
                                listpointMypane.Add(new PointPair(time, r));
                            }
                            else if (Properties.Settings.Default.Ch1Byte1 != 901 &&
                                Properties.Settings.Default.Ch1Byte2 != 901 &&
                                Properties.Settings.Default.Ch1Byte3 != 901
                                )
                            {
                                r = lst[Properties.Settings.Default.Ch1Byte1] << 16 |
                                    lst[Properties.Settings.Default.Ch1Byte2] << 8 |
                                    lst[Properties.Settings.Default.Ch1Byte3];
                                listpointMypane.Add(new PointPair(time, r)); 
                            }
                            else if (Properties.Settings.Default.Ch1Byte1 != 901 &&
                                Properties.Settings.Default.Ch1Byte2 != 901 &&
                                Properties.Settings.Default.Ch1Byte3 != 901 &&
                                Properties.Settings.Default.Ch1Byte4 != 901
                                )
                            {
                                r = lst[Properties.Settings.Default.Ch1Byte1] << 24 |
                                    lst[Properties.Settings.Default.Ch1Byte2] << 16 |
                                    lst[Properties.Settings.Default.Ch1Byte3] << 8 |
                                    lst[Properties.Settings.Default.Ch1Byte4];
                                listpointMypane.Add(new PointPair(time, r));
                            }
                            
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                        
                   
                    
                }
                if (channel2.Checked == true)
                {
                    double r;
                    try
                    {
                        if (Properties.Settings.Default.Ch2Byte1 != 901)
                        {
                            if (Properties.Settings.Default.Ch2Byte1 != 901 &&
                                Properties.Settings.Default.Ch2Byte2 == 901)
                            {
                                r = lst[Properties.Settings.Default.Ch2Byte1];
                                listpointMypane2.Add(new PointPair(time, r));
                            }
                            else if (Properties.Settings.Default.Ch2Byte1 != 901 &&
                                Properties.Settings.Default.Ch2Byte2 != 901)
                            {
                                r = lst[Properties.Settings.Default.Ch2Byte1] << 8 |
                                    lst[Properties.Settings.Default.Ch2Byte2];
                                listpointMypane2.Add(new PointPair(time, r));
                            }
                            else if (Properties.Settings.Default.Ch2Byte1 != 901 &&
                                Properties.Settings.Default.Ch2Byte2 != 901 &&
                                Properties.Settings.Default.Ch2Byte3 != 901
                                )
                            {
                                r = lst[Properties.Settings.Default.Ch2Byte1] << 16 |
                                    lst[Properties.Settings.Default.Ch2Byte2] << 8 |
                                    lst[Properties.Settings.Default.Ch2Byte3];
                                listpointMypane2.Add(new PointPair(time, r));
                            }
                            else if (Properties.Settings.Default.Ch2Byte1 != 901 &&
                                Properties.Settings.Default.Ch2Byte2 != 901 &&
                                Properties.Settings.Default.Ch2Byte3 != 901 &&
                                Properties.Settings.Default.Ch2Byte4 != 901
                                )
                            {
                                r = lst[Properties.Settings.Default.Ch2Byte1] << 24 |
                                    lst[Properties.Settings.Default.Ch2Byte2] << 16 |
                                    lst[Properties.Settings.Default.Ch2Byte3] << 8 |
                                    lst[Properties.Settings.Default.Ch2Byte4];
                                listpointMypane2.Add(new PointPair(time, r));
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                if (channel3.Checked == true)
                {
                    listpointMypane3.Add(new PointPair(time, Convert.ToDouble(lst[2])));
                }
                if (channel4.Checked==true)
                {
                    listpointMypane4.Add(new PointPair(time, Convert.ToDouble(lst[3])));
                }

                #endregion
                
                //myPaneKick.XAxis.Scale.Max=glass;

                if (time > myPaneKick.XAxis.Scale.Max - myPaneKick.XAxis.Scale.MajorStep)
                {
                    myPaneKick.XAxis.Scale.Max = time + myPaneKick.XAxis.Scale.MajorStep;
                    myPaneKick.XAxis.Scale.Min = myPaneKick.XAxis.Scale.Max-30.0;
                }
                myPaneKick.AxisChange();
                
                zedGraphControl1.Invalidate();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            form1.ForwardDataReceived += myDataReceivedFromForm1;
            Control.CheckForIllegalCrossThreadCalls = false;
            graphicControl();
            channel2.Checked = false;
            channel1.Checked = true;
            tboxconfiguration.Text = form1.tb1.Text;

            channel1.Text = Properties.Settings.Default.ch1Label;
            channel2.Text = Properties.Settings.Default.ch2Label;
            channel3.Text = Properties.Settings.Default.ch3Label;
            channel4.Text = Properties.Settings.Default.ch4Label;
            channel5.Text = Properties.Settings.Default.ch5Label;
            channel6.Text = Properties.Settings.Default.ch6Label;



        }

       

      
        private void btnStartmonitor_Click_1(object sender, EventArgs e)
        {
            form1.Form1_Load(sender, e);
            form1.openToolStripMenuItem_Click(this.form1,EventArgs.Empty);
        }

        private void btnStopmonitor_Click_1(object sender, EventArgs e)
        {
            form1.closeToolStripMenuItem_Click(sender, e);
        }
        private void btnExitmenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Channel_Enter(object sender, EventArgs e)
        {

        }
        #region offlinePlott

        private void btnOpenlog_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    openFileDialog1.Title = "choose log file";
                    List<List<byte>> package = new List<List<byte>>();
                    //strlist.Add(strfilename);
                    package.Add(File.ReadAllBytes(strfilename).ToList());
                    tboxlogdatafile.Text = "";
                    //string filetext = File.ReadAllText(strfilename);
                    //dont need to show message in message box
                    //tBoxDataIN.Text = filetext;
                    if (chboxOffline.Checked == true)
                    {
                        foreach (var lst in package)
                        {
                            glass += 0.1;


                            if (channel1.Checked == true)
                            {
                                listpointMypane.Add(new PointPair(glass, Convert.ToDouble(lst[0])));
                            }
                            if (channel2.Checked == true)
                            {
                                listpointMypane2.Add(new PointPair(glass, Convert.ToDouble(lst[1])));
                            }
                            if (channel3.Checked == true)
                            {
                                listpointMypane3.Add(new PointPair(glass, Convert.ToDouble(lst[2])));
                            }
                            if (channel4.Checked == true)
                            {
                                listpointMypane4.Add(new PointPair(glass, Convert.ToDouble(lst[3])));
                            }


                            myPaneKick.XAxis.Scale.Max = glass;
                            myPaneKick.AxisChange();
                            zedGraphControl1.Refresh();
                        }
                    }

                }
            }
            #endregion

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void graphSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            graphSetup gs = new graphSetup();
            gs.ShowDialog();

        }
             
    }
    }

