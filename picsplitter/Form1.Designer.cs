namespace picsplitter
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
            this.pborig = new System.Windows.Forms.PictureBox();
            this.cbtype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pborig)).BeginInit();
            this.SuspendLayout();
            // 
            // pborig
            // 
            this.pborig.Location = new System.Drawing.Point(50, 50);
            this.pborig.Name = "pborig";
            this.pborig.Size = new System.Drawing.Size(100, 50);
            this.pborig.TabIndex = 0;
            this.pborig.TabStop = false;
            // 
            // cbtype
            // 
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Items.AddRange(new object[] {
            "Pick a size",
            "4x4",
            "5x5",
            "6x6",
            "7x7"});
            this.cbtype.Location = new System.Drawing.Point(36, 12);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(121, 24);
            this.cbtype.TabIndex = 1;
            this.cbtype.Text = "Pick a size";
            this.cbtype.SelectedIndexChanged += new System.EventHandler(this.cbtype_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1850, 818);
            this.Controls.Add(this.cbtype);
            this.Controls.Add(this.pborig);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pborig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pborig;
        private System.Windows.Forms.ComboBox cbtype;
    }
}

