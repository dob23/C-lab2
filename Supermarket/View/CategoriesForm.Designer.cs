namespace Supermarket.View
{
    partial class CategoriesForm
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
            DgCategories = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            lblId = new Label();
            lblName = new Label();
            lblDescripcion = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            btnNew = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)DgCategories).BeginInit();
            SuspendLayout();
            // 
            // DgCategories
            // 
            DgCategories.AllowUserToDeleteRows = false;
            DgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategories.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Descripcion });
            DgCategories.Location = new Point(12, 255);
            DgCategories.Name = "DgCategories";
            DgCategories.ReadOnly = true;
            DgCategories.Size = new Size(608, 171);
            DgCategories.TabIndex = 0;
            DgCategories.Click += DgCategories_Click_1;
            // 
            // ID
            // 
            ID.HeaderText = "Id";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.False;
            ID.Width = 25;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Resizable = DataGridViewTriState.False;
            Nombre.Width = 150;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Resizable = DataGridViewTriState.False;
            Descripcion.Width = 390;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(79, 51);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 1;
            lblId.Text = "Id";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(79, 108);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(79, 167);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(67, 15);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Description";
            // 
            // txtId
            // 
            txtId.Location = new Point(165, 48);
            txtId.Name = "txtId";
            txtId.Size = new Size(165, 23);
            txtId.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(165, 108);
            txtName.Name = "txtName";
            txtName.Size = new Size(165, 23);
            txtName.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(165, 159);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(165, 23);
            txtDescription.TabIndex = 6;
            // 
            // btnNew
            // 
            btnNew.Image = Properties.Resources._new;
            btnNew.Location = new Point(638, 48);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(78, 68);
            btnNew.TabIndex = 7;
            btnNew.Text = "&New";
            btnNew.TextImageRelation = TextImageRelation.TextAboveImage;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Location = new Point(638, 140);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(78, 68);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "&Edit";
            btnEdit.TextImageRelation = TextImageRelation.TextAboveImage;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(638, 243);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 68);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "&Delete";
            btnDelete.TextImageRelation = TextImageRelation.TextAboveImage;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.cerrar;
            btnClose.Location = new Point(638, 348);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(78, 68);
            btnClose.TabIndex = 10;
            btnClose.Text = "&Close";
            btnClose.TextImageRelation = TextImageRelation.TextAboveImage;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblDescripcion);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(DgCategories);
            Name = "CategoriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoriesForm";
            ((System.ComponentModel.ISupportInitialize)DgCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgCategories;
        private Label lblId;
        private Label lblName;
        private Label lblDescripcion;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtDescription;
        private Button btnNew;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClose;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
    }
}