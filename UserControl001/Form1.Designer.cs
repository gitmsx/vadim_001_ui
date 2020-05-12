namespace UserControl001
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
            this.vad_Label1 = new UserControl001.Vad_Label();
            this.SuspendLayout();
            // 
            // vad_Label1
            // 
            this.vad_Label1.Location = new System.Drawing.Point(356, 69);
            this.vad_Label1.Name = "vad_Label1";
            this.vad_Label1.Size = new System.Drawing.Size(100, 30);
            this.vad_Label1.TabIndex = 0;
            this.vad_Label1.Text = "vad_Label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vad_Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Vad_Label vad_Label1;
    }
}

