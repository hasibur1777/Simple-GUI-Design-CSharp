namespace FirstGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.pictureBoxBarcode = new System.Windows.Forms.PictureBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTableRow2 = new System.Windows.Forms.Label();
            this.labelTableRow1 = new System.Windows.Forms.Label();
            this.labelFooter = new System.Windows.Forms.Label();
            this.pictureBoxWaltonLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaltonLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.Window;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(257, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(3);
            this.labelTitle.Size = new System.Drawing.Size(266, 56);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Walton Hi-Tech Industries PLC\r\nChandra, Kaliakoir, Gazipur";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.labelBarcode);
            this.groupBox1.Controls.Add(this.pictureBoxBarcode);
            this.groupBox1.Controls.Add(this.labelDate);
            this.groupBox1.Controls.Add(this.labelTableRow2);
            this.groupBox1.Controls.Add(this.labelTableRow1);
            this.groupBox1.Controls.Add(this.labelFooter);
            this.groupBox1.Controls.Add(this.pictureBoxWaltonLogo);
            this.groupBox1.Controls.Add(this.labelTitle);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 404);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBarcode.Location = new System.Drawing.Point(558, 285);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(165, 25);
            this.labelBarcode.TabIndex = 8;
            this.labelBarcode.Text = "PB0722000000279";
            // 
            // pictureBoxBarcode
            // 
            this.pictureBoxBarcode.Location = new System.Drawing.Point(573, 153);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(139, 112);
            this.pictureBoxBarcode.TabIndex = 7;
            this.pictureBoxBarcode.TabStop = false;
            this.pictureBoxBarcode.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(573, 118);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(141, 23);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Date: 2022-08-11";
            // 
            // labelTableRow2
            // 
            this.labelTableRow2.AutoSize = true;
            this.labelTableRow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTableRow2.Location = new System.Drawing.Point(243, 216);
            this.labelTableRow2.MinimumSize = new System.Drawing.Size(280, 0);
            this.labelTableRow2.Name = "labelTableRow2";
            this.labelTableRow2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.labelTableRow2.Size = new System.Drawing.Size(280, 63);
            this.labelTableRow2.TabIndex = 5;
            this.labelTableRow2.Text = "Blended Polyol-N";
            this.labelTableRow2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTableRow2.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelTableRow1
            // 
            this.labelTableRow1.AutoSize = true;
            this.labelTableRow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTableRow1.Location = new System.Drawing.Point(243, 153);
            this.labelTableRow1.MinimumSize = new System.Drawing.Size(280, 0);
            this.labelTableRow1.Name = "labelTableRow1";
            this.labelTableRow1.Padding = new System.Windows.Forms.Padding(15);
            this.labelTableRow1.Size = new System.Drawing.Size(280, 63);
            this.labelTableRow1.TabIndex = 4;
            this.labelTableRow1.Text = "R-11(A)";
            this.labelTableRow1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTableRow1.Click += new System.EventHandler(this.labelTableRow1_Click);
            // 
            // labelFooter
            // 
            this.labelFooter.AutoSize = true;
            this.labelFooter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFooter.Location = new System.Drawing.Point(18, 358);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(372, 20);
            this.labelFooter.TabIndex = 3;
            this.labelFooter.Text = "D.SL: 466664 Made By: Polyol Blending Production Unit";
            this.labelFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFooter.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBoxWaltonLogo
            // 
            this.pictureBoxWaltonLogo.Location = new System.Drawing.Point(27, 37);
            this.pictureBoxWaltonLogo.Name = "pictureBoxWaltonLogo";
            this.pictureBoxWaltonLogo.Size = new System.Drawing.Size(181, 117);
            this.pictureBoxWaltonLogo.TabIndex = 2;
            this.pictureBoxWaltonLogo.TabStop = false;
            this.pictureBoxWaltonLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaltonLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label labelTitle;
        private GroupBox groupBox1;
        private PictureBox pictureBoxWaltonLogo;
        private Label labelFooter;
        private Label labelTableRow2;
        private Label labelTableRow1;
        private PictureBox pictureBoxBarcode;
        private Label labelDate;
        private Label labelBarcode;
    }
}