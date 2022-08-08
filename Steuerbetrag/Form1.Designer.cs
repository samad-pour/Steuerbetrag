namespace Steuerbetrag
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_steuerbetrag = new System.Windows.Forms.Label();
            this.btn_berechnen = new System.Windows.Forms.Button();
            this.txt_gehalt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gehalt";
            // 
            // lbl_steuerbetrag
            // 
            this.lbl_steuerbetrag.AutoSize = true;
            this.lbl_steuerbetrag.Location = new System.Drawing.Point(157, 30);
            this.lbl_steuerbetrag.Name = "lbl_steuerbetrag";
            this.lbl_steuerbetrag.Size = new System.Drawing.Size(86, 15);
            this.lbl_steuerbetrag.TabIndex = 1;
            this.lbl_steuerbetrag.Text = "Steuerbetrag: 0";
            // 
            // btn_berechnen
            // 
            this.btn_berechnen.Location = new System.Drawing.Point(12, 68);
            this.btn_berechnen.Name = "btn_berechnen";
            this.btn_berechnen.Size = new System.Drawing.Size(100, 23);
            this.btn_berechnen.TabIndex = 2;
            this.btn_berechnen.Text = "Berechnen";
            this.btn_berechnen.UseVisualStyleBackColor = true;
            this.btn_berechnen.Click += new System.EventHandler(this.btn_berechnen_Click);
            // 
            // txt_gehalt
            // 
            this.txt_gehalt.Location = new System.Drawing.Point(12, 27);
            this.txt_gehalt.Name = "txt_gehalt";
            this.txt_gehalt.Size = new System.Drawing.Size(100, 23);
            this.txt_gehalt.TabIndex = 3;
            this.txt_gehalt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gehalt_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 142);
            this.Controls.Add(this.txt_gehalt);
            this.Controls.Add(this.btn_berechnen);
            this.Controls.Add(this.lbl_steuerbetrag);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbl_steuerbetrag;
        private Button btn_berechnen;
        private TextBox txt_gehalt;
    }
}