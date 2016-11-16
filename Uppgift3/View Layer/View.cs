// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved. // Use of this code is subject to the terms of our license. // A copy of the current license can be obtained at any time by e-mailing // licensing@syncfusion.com. Any infringement will be prosecuted under // applicable laws. #endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Uppgift3.Data_Layer;
using Uppgift3.Model_Layer;
using System.Data.Entity;
using System.Linq;

namespace Uppgift3
{
    public partial class View : Syncfusion.Windows.Forms.MetroForm, IView
    {
        private Model m;
        public View()
        {
            InitializeComponent();
            dataGridView.Columns.Add("", "");
            m = new Model(this);
            m.GetNameData();
        }

        #region Properties
        public string setTxtContactName
        {
            get { return txtContactName.Text; }
            set { txtContactName.Text = value; }
        }

        public string setTxtPhoneWork
        {
            get { return txtMobilePhone.Text; }
            set { txtMobilePhone.Text = value; }
        }
        public string setTxtPhoneHome
        {
            get { return txtHomePhone.Text; }
            set { txtHomePhone.Text = value; }
        }
        public string setTxtMobilePhone
        {
            get { return txtWorkPhone.Text; }
            set { txtWorkPhone.Text = value; }
        }

        public string setTxtHomeAddress
        {
            get { return txtHomeAddress.Text; }
            set { txtHomeAddress.Text = value; }
        }
        public string setTxtWorkAddress
        {
            get { return txtWorkAddress.Text; }
            set { txtWorkAddress.Text = value; }
        }

        public string setTxtOtherAddress
        {
            get { return txtOtherAddress.Text; }
            set { txtOtherAddress.Text = value; }
        }

        public void DataSource(string value)
        {

            dataGridView.Rows.Add(value);
        }

        public void GetContactNames(List<string> DataSourceList)
        {
            dataGridView.Rows.Clear();

            foreach (var item in DataSourceList.ToString())
            {
                dataGridView.Rows.Add(item);
            }
        }

        #endregion

        public bool EditMode { get; set; }


        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                m.GetContactInfo(dataGridView.CurrentCell.Value.ToString());

            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }
        }
        private void btnEditContact_Click(object sender, EventArgs e)
        {
            EditMode = true;
            btnBeginEdit.Visible = false;
            btnCompleteOperation.Visible = true;
            btnCompleteOperation.BringToFront();
            btnCancelOperation.Visible = true;
            SetTextBoxEnabled(false, Color.WhiteSmoke);
        }
        public void SetTextBoxEnabled(bool _boolValue, Color _color)
        {
            txtContactName.ReadOnly = _boolValue;

            txtMobilePhone.ReadOnly = _boolValue;
            txtWorkPhone.ReadOnly = _boolValue;
            txtHomePhone.ReadOnly = _boolValue;

            txtHomeAddress.ReadOnly = _boolValue;
            txtWorkAddress.ReadOnly = _boolValue;
            txtOtherAddress.ReadOnly = _boolValue;

            txtContactName.BackColor = _color;

            txtHomeAddress.BackColor = _color;
            txtOtherAddress.BackColor = _color;
            txtWorkAddress.BackColor = _color;

            txtWorkPhone.BackColor = _color;
            txtMobilePhone.BackColor = _color;
            txtHomePhone.BackColor = _color;

        }
        private void btnCompleteOperation_Click(object sender, EventArgs e)
        {
            if (txtContactName.Text != "")
            {
                btnCancelOperation.Visible = false;
                btnCompleteOperation.Visible = false;
                btnBeginEdit.Visible = true;

                SetTextBoxEnabled(true, Color.FromArgb(41, 143, 204));

                if (EditMode == true)
                {
                    m.EditContact(txtContactName.Text);
                }
                else if (EditMode == false)
                {
                    m.AddContact(txtContactName.Text, txtMobilePhone.Text, txtWorkPhone.Text, txtHomePhone.Text, txtHomeAddress.Text, txtWorkAddress.Text, txtOtherAddress.Text);
                }
                m.GetDataCollection();
            }
        }
        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            btnCancelOperation.Visible = false;
            btnCompleteOperation.Visible = false;
            btnBeginEdit.Visible = true;

            SetTextBoxEnabled(true, Color.FromArgb(41, 143, 204));
            //m.GetContactInfo(dataGridView.CurrentCell.Value.ToString());
            m.GetDataCollection();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            //txtContactName.Visible = true;
            //txtContactName.BringToFront();
            btnBeginEdit.Visible = false;

            EditMode = false;

            btnCompleteOperation.Visible = true;
            btnCompleteOperation.BringToFront();
            btnCancelOperation.Visible = true;

            SetTextBoxEnabled(false, Color.WhiteSmoke);

            txtOtherAddress.Text = null;
            txtWorkAddress.Text = null;
            txtHomeAddress.Text = null;
            txtWorkPhone.Text = null;
            txtMobilePhone.Text = null;
            txtHomePhone.Text = null;

            m.GetDataCollection();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}