﻿
namespace QuanLySV
{
    partial class Form2
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
            this.gbTTSV = new System.Windows.Forms.GroupBox();
            this.cbbLopSH = new System.Windows.Forms.ComboBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTTSV.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTTSV
            // 
            this.gbTTSV.Controls.Add(this.cbbLopSH);
            this.gbTTSV.Controls.Add(this.Cancel);
            this.gbTTSV.Controls.Add(this.btnOK);
            this.gbTTSV.Controls.Add(this.gbGender);
            this.gbTTSV.Controls.Add(this.dtBirth);
            this.gbTTSV.Controls.Add(this.txtName);
            this.gbTTSV.Controls.Add(this.txtMSSV);
            this.gbTTSV.Controls.Add(this.label3);
            this.gbTTSV.Controls.Add(this.label2);
            this.gbTTSV.Controls.Add(this.label1);
            this.gbTTSV.Location = new System.Drawing.Point(14, 35);
            this.gbTTSV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbTTSV.Name = "gbTTSV";
            this.gbTTSV.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbTTSV.Size = new System.Drawing.Size(554, 335);
            this.gbTTSV.TabIndex = 0;
            this.gbTTSV.TabStop = false;
            this.gbTTSV.Text = "Thong tin SV";
            // 
            // cbbLopSH
            // 
            this.cbbLopSH.FormattingEnabled = true;
            this.cbbLopSH.Location = new System.Drawing.Point(110, 214);
            this.cbbLopSH.Name = "cbbLopSH";
            this.cbbLopSH.Size = new System.Drawing.Size(116, 28);
            this.cbbLopSH.TabIndex = 10;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(286, 274);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(87, 35);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(110, 274);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 35);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rdFemale);
            this.gbGender.Controls.Add(this.rdMale);
            this.gbGender.Location = new System.Drawing.Point(286, 134);
            this.gbGender.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbGender.Name = "gbGender";
            this.gbGender.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gbGender.Size = new System.Drawing.Size(223, 100);
            this.gbGender.TabIndex = 7;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(124, 61);
            this.rdFemale.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(70, 24);
            this.rdFemale.TabIndex = 1;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(7, 61);
            this.rdMale.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(55, 24);
            this.rdMale.TabIndex = 0;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // dtBirth
            // 
            this.dtBirth.Location = new System.Drawing.Point(286, 52);
            this.dtBirth.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(215, 25);
            this.dtBirth.TabIndex = 6;
            this.dtBirth.Value = new System.DateTime(2021, 4, 2, 15, 21, 46, 0);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 134);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 25);
            this.txtName.TabIndex = 4;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(110, 52);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(116, 25);
            this.txtMSSV.TabIndex = 3;
            this.txtMSSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMSSV_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "LopSH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 378);
            this.Controls.Add(this.gbTTSV);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbTTSV.ResumeLayout(false);
            this.gbTTSV.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTTSV;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLopSH;
    }
}