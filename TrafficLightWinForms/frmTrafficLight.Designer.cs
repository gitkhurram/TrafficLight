namespace TrafficLightWinForms
{
    partial class frmTrafficLight
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
            this.imgTrafficLight = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGreenMaxDuration = new System.Windows.Forms.TextBox();
            this.txtGreenMinDuration = new System.Windows.Forms.TextBox();
            this.txtYellowMaxDuration = new System.Windows.Forms.TextBox();
            this.txtYellowMinDuration = new System.Windows.Forms.TextBox();
            this.txtRedMaxDuration = new System.Windows.Forms.TextBox();
            this.txtRedMinDuration = new System.Windows.Forms.TextBox();
            this.btnHasten = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStopWork = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRedDuration = new System.Windows.Forms.Label();
            this.lblYellowDuration = new System.Windows.Forms.Label();
            this.lblGreenDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgTrafficLight)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgTrafficLight
            // 
            this.imgTrafficLight.Location = new System.Drawing.Point(12, 12);
            this.imgTrafficLight.Name = "imgTrafficLight";
            this.imgTrafficLight.Size = new System.Drawing.Size(100, 254);
            this.imgTrafficLight.TabIndex = 0;
            this.imgTrafficLight.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblGreenDuration);
            this.panel1.Controls.Add(this.lblYellowDuration);
            this.panel1.Controls.Add(this.lblRedDuration);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtGreenMaxDuration);
            this.panel1.Controls.Add(this.txtGreenMinDuration);
            this.panel1.Controls.Add(this.txtYellowMaxDuration);
            this.panel1.Controls.Add(this.txtYellowMinDuration);
            this.panel1.Controls.Add(this.txtRedMaxDuration);
            this.panel1.Controls.Add(this.txtRedMinDuration);
            this.panel1.Controls.Add(this.btnHasten);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(129, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 254);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Max Duration (Sec)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Min Duration (Sec)";
            // 
            // txtGreenMaxDuration
            // 
            this.txtGreenMaxDuration.Location = new System.Drawing.Point(159, 122);
            this.txtGreenMaxDuration.Name = "txtGreenMaxDuration";
            this.txtGreenMaxDuration.Size = new System.Drawing.Size(81, 20);
            this.txtGreenMaxDuration.TabIndex = 9;
            this.txtGreenMaxDuration.Text = "360";
            this.txtGreenMaxDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGreenMaxDuration.TextChanged += new System.EventHandler(this.txtGreenMaxDuration_TextChanged);
            // 
            // txtGreenMinDuration
            // 
            this.txtGreenMinDuration.Location = new System.Drawing.Point(53, 122);
            this.txtGreenMinDuration.Name = "txtGreenMinDuration";
            this.txtGreenMinDuration.Size = new System.Drawing.Size(81, 20);
            this.txtGreenMinDuration.TabIndex = 8;
            this.txtGreenMinDuration.Text = "120";
            this.txtGreenMinDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGreenMinDuration.TextChanged += new System.EventHandler(this.txtGreenMinDuration_TextChanged);
            // 
            // txtYellowMaxDuration
            // 
            this.txtYellowMaxDuration.Location = new System.Drawing.Point(159, 79);
            this.txtYellowMaxDuration.Name = "txtYellowMaxDuration";
            this.txtYellowMaxDuration.Size = new System.Drawing.Size(81, 20);
            this.txtYellowMaxDuration.TabIndex = 7;
            this.txtYellowMaxDuration.Text = "5";
            this.txtYellowMaxDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtYellowMaxDuration.TextChanged += new System.EventHandler(this.txtYellowMaxDuration_TextChanged);
            // 
            // txtYellowMinDuration
            // 
            this.txtYellowMinDuration.Location = new System.Drawing.Point(53, 79);
            this.txtYellowMinDuration.Name = "txtYellowMinDuration";
            this.txtYellowMinDuration.Size = new System.Drawing.Size(81, 20);
            this.txtYellowMinDuration.TabIndex = 6;
            this.txtYellowMinDuration.Text = "5";
            this.txtYellowMinDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtYellowMinDuration.TextChanged += new System.EventHandler(this.txtYellowMinDuration_TextChanged);
            // 
            // txtRedMaxDuration
            // 
            this.txtRedMaxDuration.Location = new System.Drawing.Point(159, 43);
            this.txtRedMaxDuration.Name = "txtRedMaxDuration";
            this.txtRedMaxDuration.Size = new System.Drawing.Size(81, 20);
            this.txtRedMaxDuration.TabIndex = 5;
            this.txtRedMaxDuration.Text = "120";
            this.txtRedMaxDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRedMaxDuration.TextChanged += new System.EventHandler(this.txtRedMaxDuration_TextChanged);
            // 
            // txtRedMinDuration
            // 
            this.txtRedMinDuration.Location = new System.Drawing.Point(53, 43);
            this.txtRedMinDuration.Name = "txtRedMinDuration";
            this.txtRedMinDuration.Size = new System.Drawing.Size(81, 20);
            this.txtRedMinDuration.TabIndex = 4;
            this.txtRedMinDuration.Text = "120";
            this.txtRedMinDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRedMinDuration.TextChanged += new System.EventHandler(this.txtRedMinDuration_TextChanged);
            // 
            // btnHasten
            // 
            this.btnHasten.Location = new System.Drawing.Point(19, 197);
            this.btnHasten.Name = "btnHasten";
            this.btnHasten.Size = new System.Drawing.Size(267, 39);
            this.btnHasten.TabIndex = 3;
            this.btnHasten.Text = "Hasten";
            this.btnHasten.UseVisualStyleBackColor = true;
            this.btnHasten.Click += new System.EventHandler(this.btnHasten_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Green:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yellow:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red:";
            // 
            // btnStopWork
            // 
            this.btnStopWork.Location = new System.Drawing.Point(182, 273);
            this.btnStopWork.Name = "btnStopWork";
            this.btnStopWork.Size = new System.Drawing.Size(75, 23);
            this.btnStopWork.TabIndex = 2;
            this.btnStopWork.Text = "Stop Work";
            this.btnStopWork.UseVisualStyleBackColor = true;
            this.btnStopWork.Click += new System.EventHandler(this.btnStopWork_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(263, 273);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Work";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblRedDuration
            // 
            this.lblRedDuration.AutoSize = true;
            this.lblRedDuration.Location = new System.Drawing.Point(247, 43);
            this.lblRedDuration.Name = "lblRedDuration";
            this.lblRedDuration.Size = new System.Drawing.Size(0, 13);
            this.lblRedDuration.TabIndex = 12;
            // 
            // lblYellowDuration
            // 
            this.lblYellowDuration.AutoSize = true;
            this.lblYellowDuration.Location = new System.Drawing.Point(247, 85);
            this.lblYellowDuration.Name = "lblYellowDuration";
            this.lblYellowDuration.Size = new System.Drawing.Size(0, 13);
            this.lblYellowDuration.TabIndex = 13;
            // 
            // lblGreenDuration
            // 
            this.lblGreenDuration.AutoSize = true;
            this.lblGreenDuration.Location = new System.Drawing.Point(247, 122);
            this.lblGreenDuration.Name = "lblGreenDuration";
            this.lblGreenDuration.Size = new System.Drawing.Size(0, 13);
            this.lblGreenDuration.TabIndex = 14;
            // 
            // frmTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 308);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStopWork);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imgTrafficLight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTrafficLight";
            this.Text = "Traffic Light Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.imgTrafficLight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgTrafficLight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHasten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGreenMaxDuration;
        private System.Windows.Forms.TextBox txtGreenMinDuration;
        private System.Windows.Forms.TextBox txtYellowMaxDuration;
        private System.Windows.Forms.TextBox txtYellowMinDuration;
        private System.Windows.Forms.TextBox txtRedMaxDuration;
        private System.Windows.Forms.TextBox txtRedMinDuration;
        private System.Windows.Forms.Button btnStopWork;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblGreenDuration;
        private System.Windows.Forms.Label lblYellowDuration;
        private System.Windows.Forms.Label lblRedDuration;
    }
}

