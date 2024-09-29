using Supermarket.Bussines;
using Supermarket.Model;
using Supermarket.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket.View
{
    public partial class PayModeForm : Form
    {
        private readonly PayModeDAO payModeDAO;
        private bool EditMode;
        private bool isNew;
        internal PayModeForm(ref PayModeDAO payModeDAO)
        {
            InitializeComponent();
            this.payModeDAO = payModeDAO;
            LoadPayModeList();
            EditMode = false;
            isNew = false;
        }
        private void LoadPayModeList()
        {
            DgPayMode.Rows.Clear();
            foreach (KeyValuePair<int, PayMode> payModeKV in this.payModeDAO.GetPayModeList())
            {
                DgPayMode.Rows.Add(payModeKV.Value.Id, payModeKV.Value.Name);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgPayMode_Click(object sender, EventArgs e)
        {
            TxtId.Text = DgPayMode.CurrentRow.Cells[0].Value.ToString();
            TxtName.Text = DgPayMode.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (EditMode == false)
            {
                EditMode = true;
                isNew = true;
            }
            else
            {
                if (SavePayMode() == false)
                {
                    return;
                };
                isNew = false;
                EditMode = false;
            }
            TxtId.Text = "";
            TxtName.Text = "";
            ActivateControls(EditMode);
        }
        private void ActivateControls(bool state)
        {
            if (EditMode == true)
            {
                BtnNew.Text = "Save";
                BtnNew.Image = Resources.save;
                BtnEdit.Text = "Cancel";
                BtnEdit.Image = Resources.save;
            }
            else
            {
                BtnNew.Text = "New";
                BtnNew.Image = Resources._new;
                BtnEdit.Text = "Edit";
                BtnEdit.Image = Resources.edit;
            }
            TxtName.Enabled = state;
            DgPayMode.Enabled = !state;

            BtnDelete.Enabled = !state;
            BtnClose.Enabled = !state;
            TxtName.Focus();
        }
        private bool SavePayMode()
        {
            if (!IsNameFilled())
            {
                return false;
            }
            if (isNew == true)
            {
                PayMode payMode = new(null, TxtName.Text);
                if (payModeDAO.AddPayMode(payMode) == false)
                {
                    MessageBox.Show("Error to save", "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return false;
                }
                MessageBox.Show("Pay mode save successful", "Alert", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                LoadPayModeList();
            }
            else
            {
                int id = Int32.Parse(TxtId.Text);
                PayMode payMode = payModeDAO.GetPayMode(id);
                if (payMode != null)
                {
                    if (!IsNameFilled())
                    {
                        return false;
                    }
                    payMode.Name = TxtName.Text;
                    payModeDAO.UpdatePayMode(id, payMode);
                    LoadPayModeList();
                    return true;
                }
                return false;
            }
            return true;
        }
        private bool IsNameFilled()
        {
            if ((TxtName.Text).Trim().Length == 0)
            {
                MessageBox.Show("The Pay mode name is required", "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                TxtName.Focus();
                return false;
            }
            return true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (EditMode == true)
            {
                EditMode = false;
            }
            else
            {
                if (TxtName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Select one register of the list", "Alert",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                };
                EditMode = true;
                isNew = false;

            }
            ActivateControls(EditMode);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtId.Text.Trim().Length == 0) {
                MessageBox.Show("Select a pay mode to delete", "Alert",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            int id = Int32.Parse(TxtId.Text);

            if (payModeDAO.GetPayMode(id) != null) 
            {
                payModeDAO.RemovePayMode(id); 
                MessageBox.Show("Pay mode deleted successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPayModeList(); 
            }
            else
            {
                MessageBox.Show("Error deleting pay mode", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TxtId.Text = "";
            TxtName.Text = "";
        }
    }
}



