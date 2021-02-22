using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace OOp_1
{
    public partial class Form1 : Form
    {
        string textFileContent;
        private string passwordString;
        string writeString;
        string dataOUT;
        string sendWith;
        string DataIn;
        StreamWriter objStreamWriter;
        string pathFile = @"C:\Users\kaspe\OneDrive\Skrivebord\My sourses\SerialData.";

        public Form1()
        {
            InitializeComponent();

        }
        string receivedConfig = "0;1;2;3;4";
        string[] instrumentConfigs = { };
        string instrumetConfigs2;
        double chartXValue = 0.0;
        double chartYValue = 0.0;
        List<MeasurementPoint> AllMeasurementPoints = new List<MeasurementPoint>();
        string leggsammen()
        {
            return string.Format("{0};{1};{2};{3};{4}", textBoxTagname.Text, textBoxLRV.Text
                                            , textBoxURV.Text, textBoxAL.Text, textBoxAH.Text);
        }

        /*string Password = "Kasper";
        */
        private object saveFileDialog1CSV;
        private IEnumerable<MeasurementPoint> allMeasuredPoints;
        private object saveFileDialogCSV;

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Ports = SerialPort.GetPortNames();
            BoxCOMPORT.Items.AddRange(Ports);





            sendWith = "Both";


        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = BoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(BoxBitrate.Text);

                serialPort1.Open();
                progressBar1.Value = 100;


            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;


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

        private void buttonMessageBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show() Method variabels:
            string message = "Specific message about some operation. Cancel this operation?";
            string caption = "Continue with operation?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result;


            result = MessageBox.Show(this, message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                // Closes the parent form.
                MessageBox.Show("Yahoo!");
            }
        }

        private void buttonAddXY_Click(object sender, EventArgs e)
        {
            /*
            FileStream fileWrite = new FileStream(@"C:\tmp\test.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            var textToWrite = "Xvalue;Yvalue\r\n10.0;10.0\r\n11.0;11.0\r\n";
            byte[] writeArray = Encoding.UTF8.GetBytes(textToWrite);
            fileWrite.Write(writeArray, 0, textToWrite.Length);
            fileWrite.Close();
            
            string[] lines = { "Xvalue; Yvalue", "10.0; 10.0", "11.0; 11.0" };
            StreamWriter outputFile = new StreamWriter(@"C:\tmp\Test.txt");
            foreach (string line in lines)
            {
                outputFile.WriteLine(line);
            }
            outputFile.Close();
            

            string[] lines = { "Xvalue; Yvalue", "11.0; 11.0", "12.0; 12.0" };
            File.WriteAllLines(@"C:\tmp\Test.txt", lines);
           



            FileStream readTestTextFile = new FileStream(@"C:\tmp\Test.txt", FileMode.Open, FileAccess.Read, FileShare.Read);

            */
            chart1.Series[0].Points.AddXY(Convert.ToDouble(textBoxX.Text),
                                          Convert.ToDouble(textBoxY.Text));
            textBoxX.Text = textBoxY.Text = "";
        }


        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            textBoxTextFile.Clear();
            /*
            var inputFile = new StreamReader(@"C:\tmp\Test.txt");

            // Read the stream as a string, and write the string to textbox.
            textBoxTextFile.Text = inputFile.ReadToEnd();
            inputFile.Close();
            */
            //string fileName = "";
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
                //Get the path of specified file
                fileName = saveFileDialog1.FileName;
                File.WriteAllLines(fileName, textFileContent);

                MessageBox.Show(fileName);
            }
        }

        private void timerChartAdd_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readanalog");
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
                string availableData = "";
                availableData += serialPort1.ReadExisting().ToString();
                string[] analogReadings = availableData.Split(';');
                textBoxTextFile.AppendText(availableData);
                if (analogReadings.Length == 4)
                {
                    listBoxVa.Items.Add(analogReadings[0]);
                    chart1.Series[0].Points.AddXY(Convert.ToDouble(listBoxVa.Items.Count - 1),
                                                   Convert.ToDouble(listBoxVa.Items[listBoxVa.Items.Count - 1]));
                    listBoxVb.Items.Add(analogReadings[1]);
                    chart1.Series[1].Points.AddXY(Convert.ToDouble(listBoxVb.Items.Count - 1),
                               Convert.ToDouble(listBoxVb.Items[listBoxVb.Items.Count - 1]));
                    listBoxVab.Items.Add(analogReadings[2]);
                    chart1.Series[2].Points.AddXY(Convert.ToDouble(listBoxVab.Items.Count - 1),
                                                  Convert.ToDouble(listBoxVab.Items[listBoxVa.Items.Count - 1]));
                }

                timerChartAdd.Enabled = true;
                timerSerialReceive.Enabled = false;
            }
        }


        public class MeasurementPoint
        {
            //The objects variables
            //{get; set;} makes it possible to both change the variable(set) and read the variable(get)
            //It is possible to remove either get and set or both to make the object more rigid.
            public String time { get; set; }
            public int va { get; set; }
            public int vb { get; set; }
            public int vab { get; set; }
            //The constructor of the object Needs to be called when you want to create a new object of this type
            public MeasurementPoint(String time, int va, int vb, int vab)
            {
                //"this" referes to the objects variable. 
                //It is needed because the variables sent to the constructor and the objects variables are named the same. 
                this.time = time;
                this.va = va;
                this.vb = vb;
                this.vab = vab;
            }
            //overrides the base object ToString(). makes it possible to decide what is printed when ToString is called.
            public override string ToString()
            {
                return time + ";" + va + ";" + vb + ";" + vab;
            }
        }

        public class Instrument
        {
            //class body

            //Field declaration
            private int measurement;

            //A constructor
            public Instrument(int measurement)
            {
                this.measurement = measurement;
            }
            //Another constructor
            public Instrument(string tagname, string unit, double lrv, double urv)
            {
                this.tagname = tagname;
                this.unit = unit;
                this.lrv = lrv;
                this.urv = urv;
            }

            //Properties Definitions
            public string tagname
            {
                get { return tagname; }
                set { tagname = value; }
            }
            public string unit { get; set; }
            public double lrv { get; set; }
            public double urv { get; set; }

            //Method declaration
            public double Scaled()
            {
                return measurement / 10.0;
            }

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

                    foreach (MeasurementPoint point in allMeasuredPoints)
                    {
                        streamWritePoints.WriteLine(point.ToString());
                    }

            }
        }


        private void buttonStart_Click_1(object sender, EventArgs e)
        {
            timerChartAdd.Enabled = true;
        }


        private void buttonAddXY_Click_1(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY(Convert.ToDouble(textBoxX.Text),
                                         Convert.ToDouble(textBoxY.Text));
            textBoxX.Text = textBoxY.Text = "";
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

                File.WriteAllText(saveFileDialogConfig.FileName, string.Join(";", receivedConfig));
            }
        }

        private void buttonOpenFile_Click_1(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }




        private void textBoxInput1_TextChanged_1(object sender, EventArgs e)
        {

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


            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


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
                try
                {
                    serialPort1.Write("readstatus");
                    int milliseconds = 2000;
                    Thread.Sleep(milliseconds);
                    textBoxreadstatus.Text = serialPort1.ReadExisting();
                    int writeSuccess = int.Parse(textBoxreadstatus.Text);
                    if (writeSuccess == 0)
                    {
                        MessageBox.Show("OK");
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
                        MessageBox.Show("AlarmL");
                    }
                    else
                    {
                       // MessageBox.Show("Configuration write error.");
                    }
                    if (writeSuccess == 3)
                    {
                        MessageBox.Show("AlarmH");
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
            }

        }

        private void buttreadraw_Click(object sender, EventArgs e)
        {
            serialPort1.Write("readraw");
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
            textBoxreadraw.Text = serialPort1.ReadExisting();
            
            

        }

        private void textBoxreadraw_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxreadscale_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttreadscale_Click(object sender, EventArgs e)
        {
            serialPort1.Write("readscaled");
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
            textBoxreadscale.Text = serialPort1.ReadExisting();
        }

        private void COM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BoxDataOut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
    


    
       
        
 


        