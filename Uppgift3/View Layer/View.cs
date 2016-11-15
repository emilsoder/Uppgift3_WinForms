// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved. // Use of this code is subject to the terms of our license. // A copy of the current license can be obtained at any time by e-mailing // licensing@syncfusion.com. Any infringement will be prosecuted under // applicable laws. #endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Uppgift3.Data_Layer;
using Uppgift3.Model_Layer;
namespace Uppgift3
{
    public partial class View : Syncfusion.Windows.Forms.MetroForm, IView
    {
        private Model m;

        public string setTxtPhoneWork
        { get { return txtMobilePhone.Text; } set { txtMobilePhone.Text = value; } }
        public string setTxtPhoneHome { get { return txtHomePhone.Text; } set { txtHomePhone.Text = value; } }
        public string setTxtMobilePhone { get { return txtWorkPhone.Text; } set { txtWorkPhone.Text = value; } }
        public string setLblTitleName { get { return lblContactName.Text; } set { lblContactName.Text = value; } }
        public string setTxtHomeAddress { get { return txtHomeAddress.Text; } set { txtHomeAddress.Text = value; } }
        public string setTxtWorkAddress { get { return txtWorkAddress.Text; } set { txtWorkAddress.Text = value; } }
        public string setTxtOtherAddress { get { return txtOtherAddress.Text; } set { txtOtherAddress.Text = value; } }
        public View()
        {
            InitializeComponent();
            dataGridView.Columns.Add("", "");
            m = new Model(this);
            m.GetNameData();
        }
        public void DataSource(string value)
        {
            dataGridView.Rows.Add(value);
        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            m.GetContactInfo(dataGridView.CurrentCell.Value.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btnFinishEdit.Visible = true;
            btnFinishEdit.BringToFront();
            btnCancelEdit.Visible = true;
            SetTextBoxEnabled(false, Color.WhiteSmoke);
        }
        public void SetTextBoxEnabled(bool trueFalse, Color color)
        {
            txtOtherAddress.ReadOnly = trueFalse;
            txtWorkAddress.ReadOnly = trueFalse;
            txtHomeAddress.ReadOnly = trueFalse;
            txtWorkPhone.ReadOnly = trueFalse;
            txtMobilePhone.ReadOnly = trueFalse;
            txtHomePhone.ReadOnly = trueFalse;
            
            txtOtherAddress.BackColor = color;
            txtWorkAddress.BackColor = color;
            txtHomeAddress.BackColor = color;
            txtWorkPhone.BackColor = color;
            txtMobilePhone.BackColor = color;
            txtHomePhone.BackColor = color;
        }
        private void btnFinishEdit_Click(object sender, EventArgs e)
        {
            lblContactName.Visible = true;

            txtName.Visible = false;

            btnCancelEdit.Visible = false; btnFinishEdit.Visible = false;
            SetTextBoxEnabled(true, Color.FromArgb(41, 143, 204));
            m.EditContact(lblContactName.Text);
        }
        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            lblContactName.Visible = true;

            txtName.Visible = false;

            btnCancelEdit.Visible = false; btnFinishEdit.Visible = false;
            SetTextBoxEnabled(true, Color.FromArgb(41, 143, 204));
            m.GetContactInfo(dataGridView.CurrentCell.Value.ToString());
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            lblContactName.Visible = false;
            txtName.Visible = true;
            txtName.BringToFront();

            btnFinishEdit.Visible = true;
            btnFinishEdit.BringToFront();
            btnCancelEdit.Visible = true;

            SetTextBoxEnabled(false, Color.WhiteSmoke);

            txtOtherAddress.Text = null;
            txtWorkAddress.Text = null;
            txtHomeAddress.Text = null;
            txtWorkPhone.Text = null;
            txtMobilePhone.Text = null;
            txtHomePhone.Text = null;



        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}