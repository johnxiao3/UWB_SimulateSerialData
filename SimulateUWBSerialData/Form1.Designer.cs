namespace SimulateUWBSerialData
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboSerialPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBaudRate = new System.Windows.Forms.ComboBox();
            this.comboDataBits = new System.Windows.Forms.ComboBox();
            this.comboParity = new System.Windows.Forms.ComboBox();
            this.comboStopBits = new System.Windows.Forms.ComboBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSimu1 = new System.Windows.Forms.Button();
            this.timerSim1 = new System.Windows.Forms.Timer(this.components);
            this.timerSim11 = new System.Windows.Forms.Timer(this.components);
            this.btSimu22 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboSerialPorts
            // 
            this.comboSerialPorts.FormattingEnabled = true;
            this.comboSerialPorts.Location = new System.Drawing.Point(131, 19);
            this.comboSerialPorts.Name = "comboSerialPorts";
            this.comboSerialPorts.Size = new System.Drawing.Size(101, 21);
            this.comboSerialPorts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Parity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stop Bits";
            // 
            // comboBaudRate
            // 
            this.comboBaudRate.FormattingEnabled = true;
            this.comboBaudRate.Location = new System.Drawing.Point(131, 65);
            this.comboBaudRate.Name = "comboBaudRate";
            this.comboBaudRate.Size = new System.Drawing.Size(101, 21);
            this.comboBaudRate.TabIndex = 6;
            this.comboBaudRate.Text = "9600";
            // 
            // comboDataBits
            // 
            this.comboDataBits.FormattingEnabled = true;
            this.comboDataBits.Location = new System.Drawing.Point(131, 112);
            this.comboDataBits.Name = "comboDataBits";
            this.comboDataBits.Size = new System.Drawing.Size(101, 21);
            this.comboDataBits.TabIndex = 7;
            this.comboDataBits.Text = "8";
            // 
            // comboParity
            // 
            this.comboParity.FormattingEnabled = true;
            this.comboParity.Location = new System.Drawing.Point(131, 152);
            this.comboParity.Name = "comboParity";
            this.comboParity.Size = new System.Drawing.Size(101, 21);
            this.comboParity.TabIndex = 8;
            this.comboParity.Text = "None";
            // 
            // comboStopBits
            // 
            this.comboStopBits.FormattingEnabled = true;
            this.comboStopBits.Location = new System.Drawing.Point(131, 202);
            this.comboStopBits.Name = "comboStopBits";
            this.comboStopBits.Size = new System.Drawing.Size(101, 21);
            this.comboStopBits.TabIndex = 9;
            this.comboStopBits.Text = "1";
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(67, 263);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(125, 29);
            this.btOpen.TabIndex = 10;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSimu1
            // 
            this.btSimu1.Location = new System.Drawing.Point(302, 20);
            this.btSimu1.Name = "btSimu1";
            this.btSimu1.Size = new System.Drawing.Size(110, 42);
            this.btSimu1.TabIndex = 11;
            this.btSimu1.Text = "SendSimulateData1";
            this.btSimu1.UseVisualStyleBackColor = true;
            this.btSimu1.Click += new System.EventHandler(this.btSimu1_Click);
            // 
            // timerSim1
            // 
            this.timerSim1.Interval = 2000;
            this.timerSim1.Tick += new System.EventHandler(this.timerSim1_Tick);
            // 
            // timerSim11
            // 
            this.timerSim11.Interval = 2000;
            this.timerSim11.Tick += new System.EventHandler(this.timerSim11_Tick);
            // 
            // btSimu22
            // 
            this.btSimu22.Location = new System.Drawing.Point(302, 91);
            this.btSimu22.Name = "btSimu22";
            this.btSimu22.Size = new System.Drawing.Size(110, 42);
            this.btSimu22.TabIndex = 12;
            this.btSimu22.Text = "SendSimulateData2";
            this.btSimu22.UseVisualStyleBackColor = true;
            this.btSimu22.Click += new System.EventHandler(this.btSimu22_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 367);
            this.Controls.Add(this.btSimu22);
            this.Controls.Add(this.btSimu1);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.comboStopBits);
            this.Controls.Add(this.comboParity);
            this.Controls.Add(this.comboDataBits);
            this.Controls.Add(this.comboBaudRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSerialPorts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSerialPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBaudRate;
        private System.Windows.Forms.ComboBox comboDataBits;
        private System.Windows.Forms.ComboBox comboParity;
        private System.Windows.Forms.ComboBox comboStopBits;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSimu1;
        private System.Windows.Forms.Timer timerSim1;
        private System.Windows.Forms.Timer timerSim11;
        private System.Windows.Forms.Button btSimu22;
    }
}

