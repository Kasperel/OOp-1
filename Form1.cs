using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace OOp_1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }
        string receivedConfig = "0;1;2;3;4";
        string[] instrumentConfigs = { };
        string instrumetConfigs2;

        List<MeasurementPoint> AllMeasurementPoints = new List<MeasurementPoint>();
        List<MeasurementPointscaled> AllMeasurementPointsscaled = new List<MeasurementPointscaled>();
        string leggsammen()
        {
            return string.Format("{0};{1};{2};{3};{4}", textBoxTagname.Text, textBoxLRV.Text
                                            , textBoxURV.Text, textBoxAL.Text, textBoxAH.Text);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Ports = SerialPort.GetPortNames();
            BoxCOMPORT.Items.AddRange(Ports);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = BoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(BoxBitrate.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
                PB2.Value = 100;
                PB3.Value = 100;


            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {
                if (progressBar1.Value == 100)

                    MessageBox.Show("Connection succsessful");


            }
        }


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                PB2.Value = 0;
                PB3.Value = 0;

            }
        }



        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BoxDataOut.Text != "")
            {
                BoxDataOut.Text = "";
            }
        }


        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (BoxdataInn.Text != "")
            {
                BoxdataInn.Text = "";
            }
        }



        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Kasper Darabi", "Creator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void buttonShowForm_Click(object sender, EventArgs e)
        {
            FormExtra extraForm = new FormExtra();
            extraForm.Show();


        }
        void aboutWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            var fileName = string.Empty;

            openFileDialog1.InitialDirectory = "c:\\";

            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                fileName = openFileDialog1.FileName;
                MessageBox.Show(fileName);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) ;
        }



        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            textBoxTextFile.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string line in File.ReadLines(openFileDialog1.FileName))
                {
                    textBoxTextFile.AppendText(line);
                }
            }



        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string fileName = "";
            string[] textFileContent = { "Hello", "World" };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                fileName = saveFileDialog1.FileName;
                File.WriteAllLines(fileName, textFileContent);

                MessageBox.Show(fileName);
            }
        }

        private void timerChartAdd_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)

            {  if (buttraw.Checked)
                    serialPort1.WriteLine("readraw");
               if (buttscaled.Checked)
                    serialPort1.WriteLine("readscaled");




                timerSerialReceive.Enabled = true;
                timerChartAdd.Enabled = false;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerChartAdd.Enabled = true;
        }

        private void timerSerialReceive_Tick(object sender, EventArgs e)
        {
            if (serialPort1.BytesToRead > 0)
            {
                if (buttraw.Checked)
                {
                    MeasurementPoint measuredPoint;
                    string availableData = "";
                    availableData += serialPort1.ReadExisting().ToString();

                    textBoxTextFile.AppendText(availableData + "\r\n");
                    measuredPoint = new MeasurementPoint(DateTime.Now.ToLongTimeString(), int.Parse(availableData));


                    if (measuredPoint != null)
                    {
                        AllMeasurementPoints.Add(measuredPoint);
                    }


                    chart1.Series[0].Points.AddXY(measuredPoint.time, measuredPoint.raw);



                    timerChartAdd.Enabled = true;
                    timerSerialReceive.Enabled = false;
                }
                if (buttscaled.Checked)
                {
                    MeasurementPointscaled measuredPoint;
                    string availableData = "";
                    availableData += serialPort1.ReadExisting().ToString();

                    textBoxTextFile.AppendText(availableData + "\r\n");
                    measuredPoint = new MeasurementPointscaled(DateTime.Now.ToLongTimeString(), string.Format(availableData));


                    if (measuredPoint != null)
                    {
                        AllMeasurementPointsscaled.Add(measuredPoint);
                    }


                    chart1.Series[1].Points.AddXY(measuredPoint.time, measuredPoint.scaled);



                    timerChartAdd.Enabled = true;
                    timerSerialReceive.Enabled = false;
                }
                
            }
        }


        public class MeasurementPoint
        {
            
            public String time { get; set; }
            public int raw { get; set; }


    
            public MeasurementPoint(String time, int raw)
            {

                this.time = time;
                this.raw = raw;

            }

            public override string ToString()
            {
                return time + ";" + raw; 

            }
        }
        public class MeasurementPointscaled
        {

            public String time { get; set; }

            public string scaled { get; set; }


            public MeasurementPointscaled(String time, string scaled)
            {


                this.time = time;
                this.scaled = scaled;
            }

            public override string ToString()
            {

                return time + ";" + scaled;
            }
        }

        public class Instrument
        {

            private int measurement;
            private float MeasurementPointscaled;

            public Instrument(int measurement)
            {
                this.measurement = measurement;
            }
            public Instrument(float MeasurementPointscaled)
            {
                this.MeasurementPointscaled = MeasurementPointscaled;
            }

            public Instrument(string tagname, string unit, double lrv, double urv)
            {
                this.tagname = tagname;
                this.unit = unit;
                this.lrv = lrv;
                this.urv = urv;
            }


            public string tagname
            {
                get { return tagname; }
                set { tagname = value; }
            }
            public string unit { get; set; }
            public double lrv { get; set; }
            public double urv { get; set; }

            //Method declaration
            

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            instrumentConfigs = receivedConfig.Split(';');
            TextBox[] textboxes = { textBoxTagname,
                                    textBoxLRV,
                                    textBoxURV,
                                    textBoxAL,
                                    textBoxAH,
            };
            textboxes[0].Text = instrumentConfigs[0];
            //textBoxTagname.Text = instrumentConfigs[0];
            textBoxLRV.Text = instrumentConfigs[1];
            textBoxURV.Text = instrumentConfigs[2];
            textBoxAL.Text = instrumentConfigs[3];
            textBoxAH.Text = instrumentConfigs[4];



        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < instrumentConfigs.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (textBoxTagname.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxTagname.Focus();
                        }
                        break;
                    case 1:
                        if (textBoxLRV.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxLRV.Focus();
                        }
                        break;

                    case 2:
                        if (textBoxURV.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxURV.Focus();
                        }
                        break;
                    case 3:
                        if (textBoxAL.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxAL.Focus();
                        }
                        break;
                    case 4:
                        if (textBoxAH.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxAH.Focus();
                        }
                        break;

                    default:
                        instrumentConfigs[i] = textBoxTagname.Text;
                        instrumentConfigs[i] = textBoxLRV.Text;
                        instrumentConfigs[i] = textBoxURV.Text;
                        instrumentConfigs[i] = textBoxAL.Text;
                        instrumentConfigs[i] = textBoxAH.Text;
                        break;
                }




            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            instrumentConfigs = new string[5];
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialogConfig.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(saveFileDialogConfig.FileName, string.Join(";", instrumentConfigs));
            }
        }

        private void buttonSendSerial_Click(object sender, EventArgs e)
        {
            string writeString;
            string passwordString = "Passord123";

            writeString = "writeconf>" + passwordString + ">" + string.Join(";", instrumentConfigs);


        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWritePoints = new StreamWriter(saveFileDialog2.FileName))

                    foreach (MeasurementPoint point in AllMeasurementPoints)
                    {
                        streamWritePoints.WriteLine(point.ToString());
                    }

            }
        }




       

        private void buttonRead_Click_1(object sender, EventArgs e)
        {

            serialPort1.Write("readconf");
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
            receivedConfig = serialPort1.ReadExisting();
            instrumentConfigs = receivedConfig.Split(';');
            TextBox[] textboxes = { textBoxTagname,
                                    textBoxLRV,
                                    textBoxURV,
                                    textBoxAL,
                                    textBoxAH,
            };
            textBoxTagname.Text = instrumentConfigs[0];
            textBoxLRV.Text = instrumentConfigs[1];
            textBoxURV.Text = instrumentConfigs[2];
            textBoxAL.Text = instrumentConfigs[3];
            textBoxAH.Text = instrumentConfigs[4];
            if (serialPort1.IsOpen)
                receivedConfig = serialPort1.ReadExisting();
        }



        private void buttonSave_Click_1(object sender, EventArgs e)
        {

            if (saveFileDialogConfig.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(saveFileDialogConfig.FileName, string.Join(";", textBoxTagname.Text,textBoxLRV.Text, textBoxURV.Text
                    , textBoxAL.Text, textBoxAH.Text));
            }
        }

        private void buttonOpenFile_Click_1(object sender, EventArgs e)
        {
            
            var filename = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                
                openFileDialog.FileName = "";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    receivedConfig = File.ReadAllText(openFileDialog.FileName);
                    instrumentConfigs = receivedConfig.Split(';');
                    TextBox[] textboxes = { textBoxTagname,
                                    textBoxLRV,
                                    textBoxURV,
                                    textBoxAL,
                                    textBoxAH,
            };
                    textBoxTagname.Text = instrumentConfigs[0];
                    textBoxLRV.Text = instrumentConfigs[1];
                    textBoxURV.Text = instrumentConfigs[2];
                    textBoxAL.Text = instrumentConfigs[3];
                    textBoxAH.Text = instrumentConfigs[4];

                }
            }


        }




        private void buttonReadFile_Click_1(object sender, EventArgs e)
        {
            textBoxTextFile.Clear();


            string fileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string line in File.ReadLines(openFileDialog1.FileName))
                {
                    textBoxTextFile.AppendText(line);
                }
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = true;
            try
            {
                serialPort1.PortName = BoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(BoxBitrate.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
                PB2.Value = 100;
                PB3.Value = 100;


            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {
                if (progressBar1.Value == 100) 
                
                MessageBox.Show("Connection succsessful");
               

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = false;
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                PB2.Value = 0;
                PB3.Value = 0;


            }
        }



        private void buttsend_Click(object sender, EventArgs e)
        {

            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(BoxDataOut.Text);
                    BoxdataInn.Clear();
                }


            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }



        }

        private void buttReceive_Click(object sender, EventArgs e)
        {


            if (serialPort1.IsOpen)
            {
                BoxdataInn.Text = serialPort1.ReadExisting();
            }


        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < instrumentConfigs.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (textBoxTagname.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxTagname.Focus();
                        }
                        break;
                    case 1:
                        if (textBoxLRV.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxLRV.Focus();
                        }
                        break;

                    case 2:
                        if (textBoxURV.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxURV.Focus();
                        }
                        break;
                    case 3:
                        if (textBoxAL.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxAL.Focus();
                        }
                        break;
                    case 4:
                        if (textBoxAH.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxAH.Focus();
                        }
                        break;

                    default:
                        instrumentConfigs[i] = textBoxTagname.Text;
                        instrumentConfigs[i] = textBoxLRV.Text;
                        instrumentConfigs[i] = textBoxURV.Text;
                        instrumentConfigs[i] = textBoxAL.Text;
                        instrumentConfigs[i] = textBoxAH.Text;
                        break;
                }




            }
        }

        private void buttonwrite3_Click_1(object sender, EventArgs e)
        {
            instrumetConfigs2 = leggsammen();

            if (textBoxTagname.Text == "")
            {
                MessageBox.Show("ERROR , please fill in all the boxes");
                textBoxTagname.Focus();
            }


            else if (textBoxLRV.Text == "")
            {
                MessageBox.Show("ERROR , please fill in all the boxes");
                textBoxLRV.Focus();
            }

            else if (textBoxURV.Text == "")
            {
                MessageBox.Show("ERROR , please fill in all the boxes");
                textBoxURV.Focus();
            }

            else if (textBoxAL.Text == "")
            {
                MessageBox.Show("ERROR , please fill in all the boxes");
                textBoxAL.Focus();
            }


            else if (textBoxAH.Text == "")
            {
                MessageBox.Show("ERROR , please fill in all the boxes");
                textBoxAH.Focus();
            }
            else


            {

                if (serialPort1.IsOpen)

                {
                    try
                    {
                        serialPort1.Write("writeconf>" + textBoxpass99.Text + ">" + instrumetConfigs2);
                        int milliseconds = 2000;
                        Thread.Sleep(milliseconds);
                        string receivedConfirmation = serialPort1.ReadExisting();
                        int writeSuccess = int.Parse(receivedConfirmation);
                        if (writeSuccess == 1)
                        {
                            MessageBox.Show("Configuration written succesfully.");
                        }
                        else
                        {
                            MessageBox.Show("Configuration write error.");
                        }

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Configuration write error.");
                    }



                }
            }
        }

        private void buttreadstatus_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)

            {
                buttStopCHA.PerformClick();
                

                try
                {
                    serialPort1.Write("readstatus");
                    int milliseconds = 2000;
                    Thread.Sleep(milliseconds);
                    textBoxreadstatus.Text = serialPort1.ReadExisting();
                    int writeSuccess = int.Parse(textBoxreadstatus.Text);
                    if (writeSuccess == 0)
                    {
                        MessageBox.Show(" Everythis is OK");
                    }
                    else
                    {
                       // MessageBox.Show("Configuration write error.");
                    }
                    if (writeSuccess == 1)
                    {
                        MessageBox.Show("Fail");
                    }
                    else
                    {
                       // MessageBox.Show("Configuration write error.");
                    }
                    if (writeSuccess == 2)
                    {
                        MessageBox.Show("AlarmLow");
                    }
                    else
                    {
                       // MessageBox.Show("Configuration write error.");
                    }
                    if (writeSuccess == 3)
                    {
                        MessageBox.Show("AlarmHigh");
                    }
                    else
                    {
                       // MessageBox.Show("Configuration write error.");
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("Configuration write error.");
                }
                finally 
                {
                    buttstartCHA.PerformClick();
                }
            }

        }

        private void buttreadraw_Click(object sender, EventArgs e)
        {
            serialPort1.Write("readraw");
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
            textBoxreadraw.Text = serialPort1.ReadExisting();
            
            

        }



        private void buttreadscale_Click(object sender, EventArgs e)
        {
            serialPort1.Write("readscaled");
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
            textBoxreadscale.Text = serialPort1.ReadExisting();
        }



        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttraw_CheckedChanged(object sender, EventArgs e)
        {
            if (buttraw.Checked)
            timerChartAdd.Enabled = true;
        }

        private void buttscaled_CheckedChanged(object sender, EventArgs e)
        {
            if (buttscaled.Checked)
                timerChartAdd.Enabled = true;
        }



        private void buttstartCHA_Click(object sender, EventArgs e)
        {
            timerChartAdd.Enabled = true;
            timerSerialReceive.Enabled = false;
        }

        private void buttStopCHA_Click(object sender, EventArgs e)
        {

            timerChartAdd.Enabled = false;
            timerSerialReceive.Enabled = false;
            Thread.Sleep(1000);
            string lastReading = serialPort1.ReadExisting();
            
        }


    }
}
    
    


    
       
        
 


        