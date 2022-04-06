namespace clent2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.rtxt = new System.Windows.Forms.RichTextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wtxt = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWireClient = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rth_IfEvent = new System.Windows.Forms.RichTextBox();
            this.btn_ifEvent_copy = new System.Windows.Forms.Button();
            this.btn_webServer_copy = new System.Windows.Forms.Button();
            this.rth_WebCommand = new System.Windows.Forms.RichTextBox();
            this.txt_ST_Number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_WireClient = new System.Windows.Forms.TextBox();
            this.btnClient4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(8, 6);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Client_Net";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // rtxt
            // 
            this.rtxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt.Location = new System.Drawing.Point(8, 35);
            this.rtxt.Name = "rtxt";
            this.rtxt.Size = new System.Drawing.Size(1028, 180);
            this.rtxt.TabIndex = 1;
            this.rtxt.Text = "";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(169, 8);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 0;
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(815, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ClearAll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "St.Number";
            // 
            // wtxt
            // 
            this.wtxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wtxt.Location = new System.Drawing.Point(8, 250);
            this.wtxt.Name = "wtxt";
            this.wtxt.Size = new System.Drawing.Size(1028, 229);
            this.wtxt.TabIndex = 4;
            this.wtxt.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "WireClient";
            // 
            // txtWireClient
            // 
            this.txtWireClient.Location = new System.Drawing.Point(350, 9);
            this.txtWireClient.Name = "txtWireClient";
            this.txtWireClient.Size = new System.Drawing.Size(27, 20);
            this.txtWireClient.TabIndex = 6;
            this.txtWireClient.Text = "1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(871, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "WebComm_Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(881, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "If_Event_Copy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(884, 517);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(993, 511);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Beige;
            this.tabPage1.Controls.Add(this.btn1);
            this.tabPage1.Controls.Add(this.txt);
            this.tabPage1.Controls.Add(this.wtxt);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rtxt);
            this.tabPage1.Controls.Add(this.txtWireClient);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(985, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "2Step";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Bisque;
            this.tabPage2.Controls.Add(this.rth_IfEvent);
            this.tabPage2.Controls.Add(this.btn_ifEvent_copy);
            this.tabPage2.Controls.Add(this.btn_webServer_copy);
            this.tabPage2.Controls.Add(this.rth_WebCommand);
            this.tabPage2.Controls.Add(this.txt_ST_Number);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_WireClient);
            this.tabPage2.Controls.Add(this.btnClient4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "4step";
            // 
            // rth_IfEvent
            // 
            this.rth_IfEvent.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rth_IfEvent.Location = new System.Drawing.Point(7, 249);
            this.rth_IfEvent.Name = "rth_IfEvent";
            this.rth_IfEvent.Size = new System.Drawing.Size(922, 229);
            this.rth_IfEvent.TabIndex = 12;
            this.rth_IfEvent.Text = "";
            // 
            // btn_ifEvent_copy
            // 
            this.btn_ifEvent_copy.Location = new System.Drawing.Point(829, 220);
            this.btn_ifEvent_copy.Name = "btn_ifEvent_copy";
            this.btn_ifEvent_copy.Size = new System.Drawing.Size(100, 23);
            this.btn_ifEvent_copy.TabIndex = 14;
            this.btn_ifEvent_copy.Text = "If_Event_Copy";
            this.btn_ifEvent_copy.UseVisualStyleBackColor = true;
            // 
            // btn_webServer_copy
            // 
            this.btn_webServer_copy.Location = new System.Drawing.Point(821, 6);
            this.btn_webServer_copy.Name = "btn_webServer_copy";
            this.btn_webServer_copy.Size = new System.Drawing.Size(108, 23);
            this.btn_webServer_copy.TabIndex = 13;
            this.btn_webServer_copy.Text = "WebComm_Copy";
            this.btn_webServer_copy.UseVisualStyleBackColor = true;
            this.btn_webServer_copy.Click += new System.EventHandler(this.btn_webServer_copy_Click);
            // 
            // rth_WebCommand
            // 
            this.rth_WebCommand.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rth_WebCommand.Location = new System.Drawing.Point(7, 34);
            this.rth_WebCommand.Name = "rth_WebCommand";
            this.rth_WebCommand.Size = new System.Drawing.Size(922, 180);
            this.rth_WebCommand.TabIndex = 11;
            this.rth_WebCommand.Text = "";
            // 
            // txt_ST_Number
            // 
            this.txt_ST_Number.Location = new System.Drawing.Point(160, 9);
            this.txt_ST_Number.Name = "txt_ST_Number";
            this.txt_ST_Number.Size = new System.Drawing.Size(100, 20);
            this.txt_ST_Number.TabIndex = 7;
            this.txt_ST_Number.TextChanged += new System.EventHandler(this.txt_ST_Number_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "St.Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "WireClient";
            // 
            // txt_WireClient
            // 
            this.txt_WireClient.Location = new System.Drawing.Point(341, 10);
            this.txt_WireClient.Name = "txt_WireClient";
            this.txt_WireClient.Size = new System.Drawing.Size(27, 20);
            this.txt_WireClient.TabIndex = 10;
            this.txt_WireClient.Text = "1";
            this.txt_WireClient.TextChanged += new System.EventHandler(this.txt_WireClient_TextChanged);
            // 
            // btnClient4
            // 
            this.btnClient4.Location = new System.Drawing.Point(6, 6);
            this.btnClient4.Name = "btnClient4";
            this.btnClient4.Size = new System.Drawing.Size(75, 23);
            this.btnClient4.TabIndex = 1;
            this.btnClient4.Text = "Client";
            this.btnClient4.UseVisualStyleBackColor = true;
            this.btnClient4.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 548);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code_2Step";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.RichTextBox rtxt;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox wtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWireClient;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnClient4;
        private System.Windows.Forms.TextBox txt_ST_Number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_WireClient;
        private System.Windows.Forms.RichTextBox rth_IfEvent;
        private System.Windows.Forms.Button btn_ifEvent_copy;
        private System.Windows.Forms.Button btn_webServer_copy;
        private System.Windows.Forms.RichTextBox rth_WebCommand;
    }
}

