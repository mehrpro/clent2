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
            int i = 1;
            while (cunter < 20){
                rtxt.AppendText("case " + i + ": " + "digitalWrite(" + cunter + ", 1); break;//Red" + Environment.NewLine); i++;
                rtxt.AppendText("case " + i + ": " + "digitalWrite(" + cunter + ", 0); break;//NoRed" + Environment.NewLine); cunter++;i++;
            }
            cunter = 22;
            i = 37;
            while (cunter < 70)
            {
                rtxt.AppendText("case " + i + ": " + "digitalWrite(" + cunter + ", 1); break;//Red" + Environment.NewLine); i++;
                rtxt.AppendText("case " + i + ": " + "digitalWrite(" + cunter + ", 0); break;//NoRed" + Environment.NewLine); cunter++; i++;
          
            }
            cunter = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String wc = txtWireClient.Text;
            int t = txtWireClient.TextLength;
            if (t  < 1)
            {
                MessageBox.Show("برد مقصد را وارد کنید!!!!");
                
                return;

            }
            String w = txt.Text;
            rtxt.AppendText("client.println(" + "\""+ "<a href="+"\\"+ "\""+"/"+w+"1"+"\\"+"\""+"\\"+"\""+">"+w+ "-Repair</a>\");client.println(" + "\"" + "<a href=" + "\\" + "\"" + "/" + w + "4" + "\\" + "\"" + "\\" + "\""+">" + w + "-Normal</a>\");"+Environment.NewLine);
            // if (readString.indexOf("3201") > 0) { Wire.beginTransmission(1); Wire.write(75); Wire.endTransmission(); }
            wtxt.AppendText("if (readString.indexOf(\"" + w + "1\") > 0) { Wire.beginTransmission(" + wc + "); Wire.write(" + cunter_wc + "); Wire.endTransmission(); }  ");cunter_wc++;
            wtxt.AppendText("if (readString.indexOf(\"" + w + "4\") > 0) { Wire.beginTransmission(" + wc + "); Wire.write(" + cunter_wc + "); Wire.endTransmission(); }" + Environment.NewLine); cunter_wc++;

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
    }
}
