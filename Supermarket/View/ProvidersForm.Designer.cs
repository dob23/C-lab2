namespace Supermarket.View
{
    partial class ProvidersForm
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
            DgProviders = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Entrega = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            lblId = new Label();
            txtId = new TextBox();
            lblNom_Compañia = new Label();
            txtNom_Comp = new TextBox();
            lblFre_Entrega = new Label();
            txtFrec_Entrega = new TextBox();
            lblTel_contacto = new Label();
            txtTel_Contacto = new TextBox();
            btnNew = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)DgProviders).BeginInit();
            SuspendLayout();
            // 
            // DgProviders
            // 
            DgProviders.AllowUserToDeleteRows = false;
            DgProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProviders.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Entrega, Telefono });
            DgProviders.Location = new Point(58, 236);
            DgProviders.Name = "DgProviders";
            DgProviders.ReadOnly = true;
            DgProviders.Size = new Size(446, 191);
            DgProviders.TabIndex = 0;
            DgProviders.Click += DgProviders_Click;
            // 
            // ID
            // 
            ID.HeaderText = "Id";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.False;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Compañia";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Resizable = DataGridViewTriState.False;
            // 
            // Entrega
            // 
            Entrega.HeaderText = "Fre_Entrega";
            Entrega.Name = "Entrega";
            Entrega.ReadOnly = true;
            Entrega.Resizable = DataGridViewTriState.False;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono Contacto";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Resizable = DataGridViewTriState.False;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(75, 47);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 1;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(149, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(188, 23);
            txtId.TabIndex = 2;
            // 
            // lblNom_Compañia
            // 
            lblNom_Compañia.AutoSize = true;
            lblNom_Compañia.Location = new Point(58, 84);
            lblNom_Compañia.Name = "lblNom_Compañia";
            lblNom_Compañia.Size = new Size(62, 30);
            lblNom_Compañia.TabIndex = 3;
            lblNom_Compañia.Text = "Nombre \r\nCompañia";
            lblNom_Compañia.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtNom_Comp
            // 
            txtNom_Comp.Location = new Point(149, 91);
            txtNom_Comp.Name = "txtNom_Comp";
            txtNom_Comp.Size = new Size(188, 23);
            txtNom_Comp.TabIndex = 4;
            // 
            // lblFre_Entrega
            // 
            lblFre_Entrega.AutoSize = true;
            lblFre_Entrega.Location = new Point(56, 132);
            lblFre_Entrega.Name = "lblFre_Entrega";
            lblFre_Entrega.Size = new Size(64, 30);
            lblFre_Entrega.TabIndex = 5;
            lblFre_Entrega.Text = "Frecuencia\r\n Entrega";
            // 
            // txtFrec_Entrega
            // 
            txtFrec_Entrega.Location = new Point(149, 144);
            txtFrec_Entrega.Name = "txtFrec_Entrega";
            txtFrec_Entrega.Size = new Size(188, 23);
            txtFrec_Entrega.TabIndex = 6;
            // 
            // lblTel_contacto
            // 
            lblTel_contacto.AutoSize = true;
            lblTel_contacto.Location = new Point(56, 190);
            lblTel_contacto.Name = "lblTel_contacto";
            lblTel_contacto.Size = new Size(56, 30);
            lblTel_contacto.TabIndex = 7;
            lblTel_contacto.Text = "Telefono \r\nContacto";
            // 
            // txtTel_Contacto
            // 
            txtTel_Contacto.Location = new Point(149, 197);
            txtTel_Contacto.Name = "txtTel_Contacto";
            txtTel_Contacto.Size = new Size(188, 23);
            txtTel_Contacto.TabIndex = 8;
            // 
            // btnNew
            // 
            btnNew.Image = Properties.Resources._new;
            btnNew.Location = new Point(643, 21);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(70, 66);
            btnNew.TabIndex = 9;
            btnNew.Text = "&New";
            btnNew.TextImageRelation = TextImageRelation.TextAboveImage;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Location = new Point(643, 121);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(70, 66);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "&Edit";
            btnEdit.TextImageRelation = TextImageRelation.TextAboveImage;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(643, 223);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 66);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "&Delete";
            btnDelete.TextImageRelation = TextImageRelation.TextAboveImage;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.cerrar;
            btnClose.Location = new Point(643, 331);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(70, 66);
            btnClose.TabIndex = 12;
            btnClose.Text = "&Close";
            btnClose.TextImageRelation = TextImageRelation.TextAboveImage;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ProvidersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(txtTel_Contacto);
            Controls.Add(lblTel_contacto);
            Controls.Add(txtFrec_Entrega);
            Controls.Add(lblFre_Entrega);
            Controls.Add(txtNom_Comp);
            Controls.Add(lblNom_Compañia);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(DgProviders);
            Name = "ProvidersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProvidersForm";
            ((System.ComponentModel.ISupportInitialize)DgProviders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgProviders;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Entrega;
        private DataGridViewTextBoxColumn Telefono;
        private Label lblId;
        private TextBox txtId;
        private Label lblNom_Compañia;
        private TextBox txtNom_Comp;
        private Label lblFre_Entrega;
        private TextBox txtFrec_Entrega;
        private Label lblTel_contacto;
        private TextBox txtTel_Contacto;
        private Button btnNew;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClose;
    }
}