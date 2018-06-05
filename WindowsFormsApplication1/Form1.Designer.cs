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
            this.cbbkichthuoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbbkichthuoc
            // 
            this.cbbkichthuoc.FormattingEnabled = true;
            this.cbbkichthuoc.Items.AddRange(new object[] {
            "3 x 3",
            "4 x 4",
            "5 x 5",
            "6 x 6",
            "7 x 7",
            "8 x 8"});
            this.cbbkichthuoc.Location = new System.Drawing.Point(82, 12);
            this.cbbkichthuoc.Name = "cbbkichthuoc";
            this.cbbkichthuoc.Size = new System.Drawing.Size(106, 28);
            this.cbbkichthuoc.TabIndex = 0;
            this.cbbkichthuoc.SelectedIndexChanged += new System.EventHandler(this.cbbkichthuoc_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(343, 411);
            this.Controls.Add(this.cbbkichthuoc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbkichthuoc;
    }
}

