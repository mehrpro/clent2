using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clent2
{
    public partial class Form1 : Form
    {
        
        private int cunter = 2;

        private int cunter_wc = 1;
        public Form1()
        {
            InitializeComponent();
                               
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            rtxt.Clear();
            rtxt.AppendText(
                "#include <Wire.h>\r\nvoid setup()\r\n{\r\n  for (int a1 = 2; a1 < 20;) pinMode(a1++, OUTPUT);\r\n  for (int b1 = 22; b1 < 70;) pinMode(b1++, OUTPUT);\r\n  Serial.begin(9600);\r\n " + $" Wire.begin({txtWireClient.Text.Trim()});\r\n  " + "Wire.onReceive(receiveEvent);\r\n}\r\nvoid receiveEvent(int howmany) {\r\n  while (Wire.available() > 0) {\r\n    char c = Wire.read();\r\n    switch (c) {\r\n");
        
            cunter = 2;
            int i = 1;
            while (cunter < 20)
            {

                rtxt.AppendText("//////////////////////////////////////////////////////////////////" + Environment.NewLine);
                rtxt.AppendText("case " + i +":"+ Environment.NewLine);
                rtxt.AppendText("digitalWrite(" + cunter + ", 0);" + Environment.NewLine);
                rtxt.AppendText("digitalWrite(" + (cunter + 1) + ", 1); //Green" + Environment.NewLine);
                rtxt.AppendText("break;" + Environment.NewLine);
                i++;

                rtxt.AppendText("case " + i + ":" + Environment.NewLine);
                rtxt.AppendText("digitalWrite(" + cunter + ", 1);//Red" + Environment.NewLine);
                rtxt.AppendText("digitalWrite(" + (cunter + 1) + ", 0);" + Environment.NewLine);
                rtxt.AppendText("break;" + Environment.NewLine);
                i++;
                cunter += 2;
            }
            cunter = 22;
            i = 25;
            while (cunter < 70)
            {
                rtxt.AppendText("//////////////////////////////////////////////////////////////////" + Environment.NewLine);
                rtxt.AppendText("case " + i + ":" + Environment.NewLine);
                rtxt.AppendText("digitalWrite(" + cunter + ", 0);" + Environment.NewLine);
                rtxt.AppendText("digitalWrite(" + (cunter + 1) + ", 1); //Green" + Environment.NewLine);
                rtxt.AppendText("break;" + Environment.NewLine);
                i++;

                rtxt.AppendText("case " + i + ":" + Environment.NewLine);
                rtxt.AppendText("digitalWrite(" + cunter + ", 1);//Red" + Environment.NewLine);
                rtxt.AppendText("digitalWrite(" + (cunter + 1) + ", 0);" + Environment.NewLine);
                rtxt.AppendText("break;" + Environment.NewLine);
                i++;
                cunter += 2;
            }
            rtxt.AppendText("     }\r\n  }\r\n}\r\n\r\nvoid loop () {}\r\n");
        }

        private void app()
        {
            var a = Convert.ToInt32(txt_WireClient.Text);
            ++a;
            txt_WireClient.Text = a.ToString();
            cunter_wc = 1;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            var wc = txtWireClient.Text;
            int t = txtWireClient.TextLength;
            if (t  < 1)
            {
                MessageBox.Show("برد مقصد را وارد کنید!!!!");
                
                return;

            }
            var w = txt.Text;
            if (checkBoxQC.CheckState == CheckState.Checked)
            {
                //QC
                rtxt.AppendText("client.println(" + "\"" + "<a href=" + "\\" + "\"" + "/" + w + "2" + "\\" + "\"" + "\\" + "\"" + ">" + w + "-Quality</a>\");\r\nclient.println(" + "\"" + "<a href=" + "\\" + "\"" + "/" + w + "4" + "\\" + "\"" + "\\" + "\"" + ">" + w + "-Normal</a>\");" + Environment.NewLine);
                // if (readString.indexOf("3201") > 0) { Wire.beginTransmission(1); Wire.write(75); Wire.endTransmission(); }
                wtxt.AppendText("if (readString.indexOf(\"" + w + "2\") > 0) { Wire.beginTransmission(" + wc + "); Wire.write(" + cunter_wc + "); Wire.endTransmission(); }  " + Environment.NewLine); cunter_wc++;
                wtxt.AppendText("if (readString.indexOf(\"" + w + "4\") > 0) { Wire.beginTransmission(" + wc + "); Wire.write(" + cunter_wc + "); Wire.endTransmission(); }" + Environment.NewLine); cunter_wc++;

            }
            else
            {
                rtxt.AppendText("client.println(" + "\"" + "<a href=" + "\\" + "\"" + "/" + w + "1" + "\\" + "\"" + "\\" + "\"" + ">" + w + "-Repair</a>\");\r\nclient.println(" + "\"" + "<a href=" + "\\" + "\"" + "/" + w + "4" + "\\" + "\"" + "\\" + "\"" + ">" + w + "-Normal</a>\");" + Environment.NewLine);
                // if (readString.indexOf("3201") > 0) { Wire.beginTransmission(1); Wire.write(75); Wire.endTransmission(); }
                wtxt.AppendText("if (readString.indexOf(\"" + w + "1\") > 0) { Wire.beginTransmission(" + wc + "); Wire.write(" + cunter_wc + "); Wire.endTransmission(); }  " + Environment.NewLine); cunter_wc++;
                wtxt.AppendText("if (readString.indexOf(\"" + w + "4\") > 0) { Wire.beginTransmission(" + wc + "); Wire.write(" + cunter_wc + "); Wire.endTransmission(); }" + Environment.NewLine); cunter_wc++;

            }

        }


        private void txt_TextChanged(object sender, EventArgs e)
        {
            int x = txt.TextLength;
            if (x == 3) 
            {
                button1_Click(sender, e);
                txt.Clear();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rtxt.Clear();
            wtxt.Clear();
            rth_WebCommand.Clear();
            rth_IfEvent.Clear();
            txtWireClient.Clear();
            txt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtxt.SelectAll();
            rtxt.Copy();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wtxt.SelectAll();
            wtxt.Copy();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)   //بخش فرمان کلاینت ها 3 وضعیتی   
        {
            cunter = 2;
            int i = 1;
            while (cunter < 20)
            {

                rth_WebCommand.AppendText("//////////////////////////////////////////////////////////////////" + Environment.NewLine);
                rth_WebCommand.AppendText("case " + i + "://Red Status " + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + cunter + ", 1);//Red" + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + (cunter + 1) + ", 0); //Green" + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + (cunter + 2) + ", 0); break;//Blue" + Environment.NewLine);i++;

                rth_WebCommand.AppendText("case " + i + "://Yelow Status " + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + cunter + ", 1);//Red" + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + (cunter + 1) + ", 1);//Green" + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + (cunter + 2) + ", 0); break;//Blue" + Environment.NewLine); i++;

                rth_WebCommand.AppendText("case " + i + "://Blue Status " + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + cunter + ", 0);//Red" + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + (cunter + 1) + ", 0);//Green" + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + (cunter + 2) + ", 1); break;//Blue" + Environment.NewLine); i++;

                rth_WebCommand.AppendText("case " + i + "://Green Status " + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + cunter + ", 0);//Red" + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + (cunter + 1) + ", 1);//Green" + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + (cunter + 2) + ", 0); break;//Blue" + Environment.NewLine); i++;cunter = cunter + 3;
            }
            cunter = 22;
            i = 25;
            while (cunter < 70)
            {
                rth_WebCommand.AppendText("//////////////////////////////////////////////////////////////////" + Environment.NewLine);
                rth_WebCommand.AppendText("case " + i + "://Red Status " + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + cunter + ", 1);//Red" + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + (cunter + 1) + ", 0); //Green" + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + (cunter + 2) + ", 0); break;//Blue" + Environment.NewLine); i++;

                rth_WebCommand.AppendText("case " + i + "://Yelow Status " + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + cunter + ", 1);//Red" + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + (cunter + 1) + ", 1);//Green" + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + (cunter + 2) + ", 0); break;//Blue" + Environment.NewLine); i++;

                rth_WebCommand.AppendText("case " + i + "://Blue Status " + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + cunter + ", 0);//Red" + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + (cunter + 1) + ", 0);//Green" + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + (cunter + 2) + ", 1); break;//Blue" + Environment.NewLine); i++;

                rth_WebCommand.AppendText("case " + i + "://Green Status " + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + cunter + ", 0);//Red" + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + (cunter + 1) + ", 1);//Green" + Environment.NewLine);
                rth_WebCommand.AppendText("digitalWrite(" + (cunter + 2) + ", 0); break;//Blue" + Environment.NewLine); i++; cunter = cunter + 3;
            }

        }

        private void btn_webServer_copy_Click(object sender, EventArgs e)  // کپی کردن  ها
        {
            rth_WebCommand.SelectAll();
            rth_WebCommand.Copy();
                
        }
        private void WebCommand4 (object sender,EventArgs e)
        {
            if (cunter_wc > 88)
            {
                app();
            }
            String wc = txt_WireClient.Text;
            int t = txt_WireClient.TextLength;
            if (t < 1)
            {
                MessageBox.Show("برد مقصد را وارد کنید!!!!");

                return;

            }
            String w = txt_ST_Number.Text;
            rth_WebCommand.AppendText("client.println(" + "\"" + "<a href=" + "\\" + "\"" + "/" + w + "1" + "\\" + "\"" + "\\" + "\"" + ">" + w + "-Repair</a>\");" + Environment.NewLine);
            rth_WebCommand.AppendText("client.println(" + "\"" + "<a href=" + "\\" + "\"" + "/" + w + "2" + "\\" + "\"" + "\\" + "\"" + ">" + w + "-Quality</a>\");" + Environment.NewLine);
            rth_WebCommand.AppendText("client.println(" + "\"" + "<a href=" + "\\" + "\"" + "/" + w + "3" + "\\" + "\"" + "\\" + "\"" + ">" + w + "-Safety</a>\");" + Environment.NewLine);
            rth_WebCommand.AppendText("client.println(" + "\"" + "<a href=" + "\\" + "\"" + "/" + w + "4" + "\\" + "\"" + "\\" + "\"" + ">" + w + "-Normal</a>\");" + Environment.NewLine); 
                
            // if (readString.indexOf("3201") > 0) { Wire.beginTransmission(1); Wire.write(75); Wire.endTransmission(); }
            rth_IfEvent.AppendText("if (readString.indexOf(\"" + w + "1\") > 0) { Wire.beginTransmission(" + wc + "); Wire.write(" + cunter_wc + "); Wire.endTransmission(); }" + Environment.NewLine); cunter_wc++;
            rth_IfEvent.AppendText("if (readString.indexOf(\"" + w + "2\") > 0) { Wire.beginTransmission(" + wc + "); Wire.write(" + cunter_wc + "); Wire.endTransmission(); }" + Environment.NewLine); cunter_wc++;
            rth_IfEvent.AppendText("if (readString.indexOf(\"" + w + "3\") > 0) { Wire.beginTransmission(" + wc + "); Wire.write(" + cunter_wc + "); Wire.endTransmission(); }" + Environment.NewLine); cunter_wc++;
            rth_IfEvent.AppendText("if (readString.indexOf(\"" + w + "4\") > 0) { Wire.beginTransmission(" + wc + "); Wire.write(" + cunter_wc + "); Wire.endTransmission(); }" + Environment.NewLine); cunter_wc++;

        }

        private void txt_WireClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ST_Number_TextChanged(object sender, EventArgs e)
        {
            int x = txt_ST_Number.TextLength;
            if (x == 3)
            {
                WebCommand4(sender, e);
                txt_ST_Number.Clear();

            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            rtxt.Clear();
            rtxt.AppendText(
                "#include <Wire.h>\r\nvoid setup()\r\n{\r\n  for (int a1 = 2; a1 < 20;) pinMode(a1++, OUTPUT);\r\n  for (int b1 = 22; b1 < 70;) pinMode(b1++, OUTPUT);\r\n  Serial.begin(9600);\r\n " + $" Wire.begin({txtWireClient.Text.Trim()});\r\n  " + "Wire.onReceive(receiveEvent);\r\n}\r\nvoid receiveEvent(int howmany) {\r\n  while (Wire.available() > 0) {\r\n    char c = Wire.read();\r\n    switch (c) {\r\n");

            cunter = 2;
            int i = 1;
            while (cunter < 20)
            {

                rtxt.AppendText("//////////////////////////////////////////////////////////////////" + Environment.NewLine);
                rtxt.AppendText("case " + i + ":" + Environment.NewLine);
                rtxt.AppendText("digitalWrite(" + cunter + ", 0);" + Environment.NewLine);
                rtxt.AppendText("digitalWrite(" + (cunter + 1) + ", 1); //Green" + Environment.NewLine);
                rtxt.AppendText("break;" + Environment.NewLine);
                i++;

                rtxt.AppendText("case " + i + ":" + Environment.NewLine);
                rtxt.AppendText("digitalWrite(" + cunter + ", 1);//Yelow" + Environment.NewLine);
                rtxt.AppendText("digitalWrite(" + (cunter + 1) + ", 1);" + Environment.NewLine);
                rtxt.AppendText("break;" + Environment.NewLine);
                i++;
                cunter += 2;
            }
            cunter = 22;
            i = 25;
            while (cunter < 70)
            {
                rtxt.AppendText("//////////////////////////////////////////////////////////////////" + Environment.NewLine);
                rtxt.AppendText("case " + i + ":" + Environment.NewLine);
                rtxt.AppendText("digitalWrite(" + cunter + ", 0);" + Environment.NewLine);
                rtxt.AppendText("digitalWrite(" + (cunter + 1) + ", 1); //Green" + Environment.NewLine);
                rtxt.AppendText("break;" + Environment.NewLine);
                i++;

                rtxt.AppendText("case " + i + ":" + Environment.NewLine);
                rtxt.AppendText("digitalWrite(" + cunter + ", 1);//Yelow" + Environment.NewLine);
                rtxt.AppendText("digitalWrite(" + (cunter + 1) + ", 1);" + Environment.NewLine);
                rtxt.AppendText("break;" + Environment.NewLine);
                i++;
                cunter += 2;
            }
            rtxt.AppendText("     }\r\n  }\r\n}\r\n\r\nvoid loop () {}\r\n");
        }
    }
}
