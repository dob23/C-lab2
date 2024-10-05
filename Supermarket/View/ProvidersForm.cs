using Supermarket.Bussines;
using Supermarket.Model;
using Supermarket.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Supermarket.View
{
    public partial class ProvidersForm : Form
    {
        private readonly ProvidersDAO providersDAO;
        private bool EditMode;
        private bool IsNew;

        internal ProvidersForm(ref ProvidersDAO providersDAO)
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("D:\\Archivos VSCM\\Supermarket\\Supermarket\\Resources\\Supermarket.png");
            this.providersDAO = providersDAO;
            LoadProvidersList();
            EditMode = false;
            IsNew = false;
            ActivateControls(false);
        }

        private void LoadProvidersList()
        {
            DgProviders.Rows.Clear();
            foreach (KeyValuePair<int, Providers> ProvidersKV in this.providersDAO.GetProviders())
            {
                DgProviders.Rows.Add(
                    ProvidersKV.Value.IdProvider,
                    ProvidersKV.Value.NombreCompañia,
                    ProvidersKV.Value.FrecuenciaEntrega,
                    ProvidersKV.Value.TelefonoContacto
                );
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                EditMode = true;
                IsNew = true;
                ClearFields();
            }
            else
            {
                if (SaveProviders())
                {
                    EditMode = false;
                    ActivateControls(false);
                }
            }

            ActivateControls(EditMode);
        }

        private void ActivateControls(bool state)
        {
            txtId.Enabled = false;
            txtNom_Comp.Enabled = state;
            txtFrec_Entrega.Enabled = state;
            txtTel_Contacto.Enabled = state;

            DgProviders.Enabled = !state;
            btnDelete.Enabled = !state;
            btnClose.Enabled = !state;

            if (EditMode)
            {
                btnNew.Text = "Save";
                btnNew.Image = Resources.save;
                btnEdit.Text = "Cancel";
                btnEdit.Image = Resources.edit;
            }
            else
            {
                btnNew.Text = "New";
                btnNew.Image = Resources._new;
                btnEdit.Text = "Edit";
                btnEdit.Image = Resources.edit;
            }

            if (state) txtNom_Comp.Focus();
        }

        private bool SaveProviders()
        {
            if (string.IsNullOrWhiteSpace(txtNom_Comp.Text))
            {
                MessageBox.Show("Please enter a valid company name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (IsNew)
            {
                if (!float.TryParse(txtTel_Contacto.Text, out float telefonoContacto))
                {
                    MessageBox.Show("Please enter a valid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Providers provider = new Providers(null, txtNom_Comp.Text, txtFrec_Entrega.Text, telefonoContacto);

                if (!providersDAO.AddProvider(provider))
                {
                    MessageBox.Show("Error saving the provider.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                MessageBox.Show("Provider saved successfully.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProvidersList();
                return true;
            }
            else
            {
                int id = Int32.Parse(txtId.Text);
                Providers provider = providersDAO.GetProvider(id);

                if (provider != null)
                {
                    if (!float.TryParse(txtTel_Contacto.Text, out float telefonoContacto))
                    {
                        MessageBox.Show("Please enter a valid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    provider.NombreCompañia = txtNom_Comp.Text;
                    provider.FrecuenciaEntrega = txtFrec_Entrega.Text;
                    provider.TelefonoContacto = telefonoContacto;

                    providersDAO.UpdateProviders(id, provider);
                    LoadProvidersList();
                    return true;
                }

                MessageBox.Show("Provider not found.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                EditMode = false;
                ClearFields();
                ActivateControls(false);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Select a provider to edit", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                EditMode = true;
                IsNew = false;
                ActivateControls(true);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Select a provider to delete", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int id = Int32.Parse(txtId.Text);

            if (providersDAO.GetProvider(id) != null)
            {
                providersDAO.RemoveProvider(id);
                MessageBox.Show("Provider deleted successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProvidersList();
            }
            else
            {
                MessageBox.Show("Error deleting provider", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearFields();
        }

        private void DgProviders_Click(object sender, EventArgs e)
        {
            if (DgProviders.CurrentRow != null)
            {
                txtId.Text = DgProviders.CurrentRow.Cells[0].Value.ToString();
                txtNom_Comp.Text = DgProviders.CurrentRow.Cells[1].Value.ToString();
                txtFrec_Entrega.Text = DgProviders.CurrentRow.Cells[2].Value.ToString();
                txtTel_Contacto.Text = DgProviders.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtId.Text = "";
            txtNom_Comp.Text = "";
            txtFrec_Entrega.Text = "";
            txtTel_Contacto.Text = "";
        }
    }
}
