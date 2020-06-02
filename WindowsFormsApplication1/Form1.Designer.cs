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
            this.btn_reflect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
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
            // btn_reflect
            // 
            this.btn_reflect.Location = new System.Drawing.Point(386, 12);
            this.btn_reflect.Name = "btn_reflect";
            this.btn_reflect.Size = new System.Drawing.Size(125, 23);
            this.btn_reflect.TabIndex = 14;
            this.btn_reflect.Text = "Reflect";
            this.btn_reflect.UseVisualStyleBackColor = true;
            this.btn_reflect.Click += new System.EventHandler(this.btn_reflect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 432);
            this.Controls.Add(this.btn_reflect);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox display;
        private System.Windows.Forms.Button btn_reflect;
    }
}

