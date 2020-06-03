namespace WindowsFormsApplication1
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
            this.display = new System.Windows.Forms.PictureBox();
            this.btn_reflect_zox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Edit1 = new System.Windows.Forms.TextBox();
            this.Edit2 = new System.Windows.Forms.TextBox();
            this.btn_reflect_yoz = new System.Windows.Forms.Button();
            this.btn_reflect_xoy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(12, 12);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(368, 408);
            this.display.TabIndex = 1;
            this.display.TabStop = false;
            // 
            // btn_reflect_zox
            // 
            this.btn_reflect_zox.Location = new System.Drawing.Point(386, 49);
            this.btn_reflect_zox.Name = "btn_reflect_zox";
            this.btn_reflect_zox.Size = new System.Drawing.Size(125, 23);
            this.btn_reflect_zox.TabIndex = 14;
            this.btn_reflect_zox.Text = "XOZ";
            this.btn_reflect_zox.UseVisualStyleBackColor = true;
            this.btn_reflect_zox.Click += new System.EventHandler(this.btn_reflect_zox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Повороты";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(408, 192);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Minimum = -180;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(89, 45);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.btn_reflect_zox_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(408, 275);
            this.trackBar2.Maximum = 180;
            this.trackBar2.Minimum = -180;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(89, 45);
            this.trackBar2.TabIndex = 17;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            this.trackBar2.ValueChanged += new System.EventHandler(this.btn_reflect_zox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "-360";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "-360";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "360";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "360";
            // 
            // Edit1
            // 
            this.Edit1.Location = new System.Drawing.Point(434, 249);
            this.Edit1.Name = "Edit1";
            this.Edit1.Size = new System.Drawing.Size(34, 20);
            this.Edit1.TabIndex = 22;
            // 
            // Edit2
            // 
            this.Edit2.Location = new System.Drawing.Point(434, 153);
            this.Edit2.Name = "Edit2";
            this.Edit2.Size = new System.Drawing.Size(34, 20);
            this.Edit2.TabIndex = 23;
            // 
            // btn_reflect_yoz
            // 
            this.btn_reflect_yoz.Location = new System.Drawing.Point(387, 79);
            this.btn_reflect_yoz.Name = "btn_reflect_yoz";
            this.btn_reflect_yoz.Size = new System.Drawing.Size(124, 23);
            this.btn_reflect_yoz.TabIndex = 24;
            this.btn_reflect_yoz.Text = "YOZ";
            this.btn_reflect_yoz.UseVisualStyleBackColor = true;
            this.btn_reflect_yoz.Click += new System.EventHandler(this.btn_reflect_yoz_Click);
            // 
            // btn_reflect_xoy
            // 
            this.btn_reflect_xoy.Location = new System.Drawing.Point(387, 109);
            this.btn_reflect_xoy.Name = "btn_reflect_xoy";
            this.btn_reflect_xoy.Size = new System.Drawing.Size(124, 23);
            this.btn_reflect_xoy.TabIndex = 25;
            this.btn_reflect_xoy.Text = "XOY";
            this.btn_reflect_xoy.UseVisualStyleBackColor = true;
            this.btn_reflect_xoy.Click += new System.EventHandler(this.btn_reflect_xoy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Отражения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 432);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_reflect_xoy);
            this.Controls.Add(this.btn_reflect_yoz);
            this.Controls.Add(this.Edit2);
            this.Controls.Add(this.Edit1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reflect_zox);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox display;
        private System.Windows.Forms.Button btn_reflect_zox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Edit1;
        private System.Windows.Forms.TextBox Edit2;
        private System.Windows.Forms.Button btn_reflect_yoz;
        private System.Windows.Forms.Button btn_reflect_xoy;
        private System.Windows.Forms.Label label6;
    }
}

