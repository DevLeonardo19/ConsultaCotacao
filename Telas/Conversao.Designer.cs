namespace Cotação.Telas
{
    partial class Conversao
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
            this.cboDaMoeda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboParaMoeda = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDeMoeda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEquivaleA = new System.Windows.Forms.TextBox();
            this.txtParaMoeda = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboDaMoeda
            // 
            this.cboDaMoeda.AutoCompleteCustomSource.AddRange(new string[] {
            "EUR",
            "USD",
            "BRL"});
            this.cboDaMoeda.FormattingEnabled = true;
            this.cboDaMoeda.Location = new System.Drawing.Point(38, 12);
            this.cboDaMoeda.Name = "cboDaMoeda";
            this.cboDaMoeda.Size = new System.Drawing.Size(162, 21);
            this.cboDaMoeda.TabIndex = 0;
            this.cboDaMoeda.SelectedIndexChanged += new System.EventHandler(this.cboDaMoeda_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "De";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Para";
            // 
            // cboParaMoeda
            // 
            this.cboParaMoeda.FormattingEnabled = true;
            this.cboParaMoeda.Location = new System.Drawing.Point(304, 12);
            this.cboParaMoeda.Name = "cboParaMoeda";
            this.cboParaMoeda.Size = new System.Drawing.Size(162, 21);
            this.cboParaMoeda.TabIndex = 2;
            this.cboParaMoeda.SelectedIndexChanged += new System.EventHandler(this.cboParaMoeda_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(86, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "1";
            // 
            // txtDeMoeda
            // 
            this.txtDeMoeda.Enabled = false;
            this.txtDeMoeda.Location = new System.Drawing.Point(134, 57);
            this.txtDeMoeda.Name = "txtDeMoeda";
            this.txtDeMoeda.Size = new System.Drawing.Size(75, 20);
            this.txtDeMoeda.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Equivale";
            // 
            // txtEquivaleA
            // 
            this.txtEquivaleA.Enabled = false;
            this.txtEquivaleA.Location = new System.Drawing.Point(272, 57);
            this.txtEquivaleA.Name = "txtEquivaleA";
            this.txtEquivaleA.Size = new System.Drawing.Size(66, 20);
            this.txtEquivaleA.TabIndex = 7;
            // 
            // txtParaMoeda
            // 
            this.txtParaMoeda.Enabled = false;
            this.txtParaMoeda.Location = new System.Drawing.Point(344, 57);
            this.txtParaMoeda.Name = "txtParaMoeda";
            this.txtParaMoeda.Size = new System.Drawing.Size(63, 20);
            this.txtParaMoeda.TabIndex = 8;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(218, 109);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 9;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // Conversao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 198);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtParaMoeda);
            this.Controls.Add(this.txtEquivaleA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDeMoeda);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboParaMoeda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDaMoeda);
            this.Name = "Conversao";
            this.Text = "Conversao";
            this.Load += new System.EventHandler(this.Conversao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDaMoeda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboParaMoeda;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDeMoeda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEquivaleA;
        private System.Windows.Forms.TextBox txtParaMoeda;
        private System.Windows.Forms.Button btnConverter;
    }
}