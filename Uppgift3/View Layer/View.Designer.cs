#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Uppgift3
{
    partial class View
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOtherAddress = new System.Windows.Forms.TextBox();
            this.txtWorkAddress = new System.Windows.Forms.TextBox();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWorkPhone = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.btnFinishEdit = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnBeginEdit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.dataGridView);
            this.pnlLeft.Controls.Add(this.pnlTop);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(160, 347);
            this.pnlLeft.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.Location = new System.Drawing.Point(0, 79);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(160, 268);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.Controls.Add(this.button2);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(160, 79);
            this.pnlTop.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(5, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(148, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "S�k";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kontakter";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnBeginEdit);
            this.panel1.Controls.Add(this.btnFinishEdit);
            this.panel1.Controls.Add(this.btnCancelEdit);
            this.panel1.Controls.Add(this.txtOtherAddress);
            this.panel1.Controls.Add(this.txtWorkAddress);
            this.panel1.Controls.Add(this.txtHomeAddress);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtWorkPhone);
            this.panel1.Controls.Add(this.txtHomePhone);
            this.panel1.Controls.Add(this.txtMobilePhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblContactName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(160, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(267, 347);
            this.panel1.TabIndex = 1;
            // 
            // txtOtherAddress
            // 
            this.txtOtherAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(204)))));
            this.txtOtherAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOtherAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtOtherAddress.Location = new System.Drawing.Point(17, 315);
            this.txtOtherAddress.Name = "txtOtherAddress";
            this.txtOtherAddress.ReadOnly = true;
            this.txtOtherAddress.Size = new System.Drawing.Size(194, 20);
            this.txtOtherAddress.TabIndex = 13;
            this.txtOtherAddress.Text = "...";
            // 
            // txtWorkAddress
            // 
            this.txtWorkAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(204)))));
            this.txtWorkAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWorkAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtWorkAddress.Location = new System.Drawing.Point(17, 269);
            this.txtWorkAddress.Name = "txtWorkAddress";
            this.txtWorkAddress.ReadOnly = true;
            this.txtWorkAddress.Size = new System.Drawing.Size(194, 20);
            this.txtWorkAddress.TabIndex = 12;
            this.txtWorkAddress.Text = "...";
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(204)))));
            this.txtHomeAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHomeAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHomeAddress.Location = new System.Drawing.Point(17, 224);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.ReadOnly = true;
            this.txtHomeAddress.Size = new System.Drawing.Size(194, 20);
            this.txtHomeAddress.TabIndex = 11;
            this.txtHomeAddress.Text = "...";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(204)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address, Annat";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(204)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address, Arbete";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(204)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Address, Hem";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(204)))));
            this.txtWorkPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWorkPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtWorkPhone.Location = new System.Drawing.Point(17, 161);
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.ReadOnly = true;
            this.txtWorkPhone.Size = new System.Drawing.Size(194, 20);
            this.txtWorkPhone.TabIndex = 7;
            this.txtWorkPhone.Text = "...";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(204)))));
            this.txtHomePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHomePhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHomePhone.Location = new System.Drawing.Point(17, 115);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.ReadOnly = true;
            this.txtHomePhone.Size = new System.Drawing.Size(194, 20);
            this.txtHomePhone.TabIndex = 6;
            this.txtHomePhone.Text = "...";
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(204)))));
            this.txtMobilePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMobilePhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMobilePhone.Location = new System.Drawing.Point(17, 70);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.ReadOnly = true;
            this.txtMobilePhone.Size = new System.Drawing.Size(196, 20);
            this.txtMobilePhone.TabIndex = 5;
            this.txtMobilePhone.Text = "...";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(204)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mobiltelefon, Arbete";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(204)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefon, Hem";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mobiltelefon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContactName
            // 
            this.lblContactName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(204)))));
            this.lblContactName.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblContactName.ForeColor = System.Drawing.Color.White;
            this.lblContactName.Location = new System.Drawing.Point(0, 0);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(183, 35);
            this.lblContactName.TabIndex = 1;
            this.lblContactName.Text = "Namn";
            this.lblContactName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFinishEdit
            // 
            this.btnFinishEdit.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnFinishEdit.FlatAppearance.BorderSize = 0;
            this.btnFinishEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnFinishEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFinishEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishEdit.Image = global::Uppgift3.Properties.Resources.Untitled1;
            this.btnFinishEdit.Location = new System.Drawing.Point(227, 5);
            this.btnFinishEdit.Name = "btnFinishEdit";
            this.btnFinishEdit.Size = new System.Drawing.Size(36, 31);
            this.btnFinishEdit.TabIndex = 15;
            this.btnFinishEdit.UseVisualStyleBackColor = true;
            this.btnFinishEdit.Visible = false;
            this.btnFinishEdit.Click += new System.EventHandler(this.btnFinishEdit_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnCancelEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCancelEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Image = global::Uppgift3.Properties.Resources.Cancel;
            this.btnCancelEdit.Location = new System.Drawing.Point(189, 5);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(36, 31);
            this.btnCancelEdit.TabIndex = 15;
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Visible = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnBeginEdit
            // 
            this.btnBeginEdit.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnBeginEdit.FlatAppearance.BorderSize = 0;
            this.btnBeginEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBeginEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBeginEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeginEdit.Image = global::Uppgift3.Properties.Resources.Contact_Edit_WF2;
            this.btnBeginEdit.Location = new System.Drawing.Point(227, 5);
            this.btnBeginEdit.Name = "btnBeginEdit";
            this.btnBeginEdit.Size = new System.Drawing.Size(36, 31);
            this.btnBeginEdit.TabIndex = 14;
            this.btnBeginEdit.UseVisualStyleBackColor = true;
            this.btnBeginEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Uppgift3.Properties.Resources.Expand_03_WF;
            this.button2.Location = new System.Drawing.Point(123, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 33);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderColor = System.Drawing.Color.White;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionButtonColor = System.Drawing.Color.Black;
            this.CaptionButtonHoverColor = System.Drawing.Color.Gray;
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(427, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLeft);
            this.DropShadow = true;
            this.Name = "MainView";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.Text = "Kontaktbok";
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.TextBox txtWorkPhone;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOtherAddress;
        private System.Windows.Forms.TextBox txtWorkAddress;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBeginEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnFinishEdit;
    }
}