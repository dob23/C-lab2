
namespace Supermarket.View
{
    partial class ProductsForm
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
            lblName = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            lblId = new Label();
            txtId = new TextBox();
            DgProducts = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Existencias = new DataGridViewTextBoxColumn();
            btnNew = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)DgProducts).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(61, 115);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(64, 151);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(61, 196);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 2;
            lblStock.Text = "Stock";
            // 
            // txtName
            // 
            txtName.Location = new Point(127, 107);
            txtName.Name = "txtName";
            txtName.Size = new Size(196, 23);
            txtName.TabIndex = 3;
            txtName.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(127, 148);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(196, 23);
            txtPrice.TabIndex = 4;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(127, 193);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(196, 23);
            txtStock.TabIndex = 5;
            txtStock.TextAlign = HorizontalAlignment.Right;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(64, 75);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 6;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(127, 67);
            txtId.Name = "txtId";
            txtId.Size = new Size(196, 23);
            txtId.TabIndex = 7;
            txtId.TextAlign = HorizontalAlignment.Right;
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Precio, Existencias });
            DgProducts.Location = new Point(61, 234);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.Size = new Size(445, 216);
            DgProducts.TabIndex = 8;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Existencias
            // 
            Existencias.HeaderText = "Existencias";
            Existencias.Name = "Existencias";
            Existencias.ReadOnly = true;
            // 
            // btnNew
            // 
            btnNew.Image = Properties.Resources._new;
            btnNew.Location = new Point(643, 47);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 71);
            btnNew.TabIndex = 9;
            btnNew.Text = "&New";
            btnNew.TextImageRelation = TextImageRelation.TextAboveImage;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Location = new Point(643, 148);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 71);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "&Edit";
            btnEdit.TextImageRelation = TextImageRelation.TextAboveImage;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(643, 250);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 71);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "&Delete";
            btnDelete.TextImageRelation = TextImageRelation.TextAboveImage;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.cerrar;
            btnClose.Location = new Point(643, 357);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 71);
            btnClose.TabIndex = 12;
            btnClose.Text = "&Close";
            btnClose.TextImageRelation = TextImageRelation.TextAboveImage;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(DgProducts);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label lblName;
        private Label lblPrice;
        private Label lblStock;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Label lblId;
        private TextBox txtId;
        private DataGridView DgProducts;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Existencias;
        private Button btnNew;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClose;
    }
}