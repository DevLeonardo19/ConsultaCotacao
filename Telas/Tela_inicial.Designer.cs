﻿namespace Cotação
{
    partial class Tela_inicial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dolarToolStripMenuItem,
            this.conversãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(427, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dolarToolStripMenuItem
            // 
            this.dolarToolStripMenuItem.Name = "dolarToolStripMenuItem";
            this.dolarToolStripMenuItem.Size = new System.Drawing.Size(75, 34);
            this.dolarToolStripMenuItem.Text = "Dolar";
            this.dolarToolStripMenuItem.Click += new System.EventHandler(this.dolarToolStripMenuItem_Click);
            // 
            // conversãoToolStripMenuItem
            // 
            this.conversãoToolStripMenuItem.Name = "conversãoToolStripMenuItem";
            this.conversãoToolStripMenuItem.Size = new System.Drawing.Size(122, 34);
            this.conversãoToolStripMenuItem.Text = "Conversão";
            this.conversãoToolStripMenuItem.Click += new System.EventHandler(this.conversãoToolStripMenuItem_Click);
            // 
            // Tela_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 231);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tela_inicial";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversãoToolStripMenuItem;
    }
}

