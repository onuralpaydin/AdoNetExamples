﻿namespace AdoNetExamples
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
            this.btnBaglan = new System.Windows.Forms.Button();
            this.btnBaglantiKes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(12, 51);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(343, 74);
            this.btnBaglan.TabIndex = 0;
            this.btnBaglan.Text = "BAĞLAN";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // btnBaglantiKes
            // 
            this.btnBaglantiKes.Location = new System.Drawing.Point(12, 184);
            this.btnBaglantiKes.Name = "btnBaglantiKes";
            this.btnBaglantiKes.Size = new System.Drawing.Size(343, 73);
            this.btnBaglantiKes.TabIndex = 1;
            this.btnBaglantiKes.Text = "BAĞLANTIYI KES";
            this.btnBaglantiKes.UseVisualStyleBackColor = true;
            this.btnBaglantiKes.Click += new System.EventHandler(this.btnBaglantiKes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 305);
            this.Controls.Add(this.btnBaglantiKes);
            this.Controls.Add(this.btnBaglan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Button btnBaglantiKes;
    }
}

