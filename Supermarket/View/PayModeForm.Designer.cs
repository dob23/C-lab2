namespace Supermarket.View
{
    partial class PayModeForm
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
            TxtId = new TextBox();
            TxtName = new TextBox();
            DgPayMode = new DataGridView();
            IdPaymode = new DataGridViewTextBoxColumn();
            NamePayMode = new DataGridViewTextBoxColumn();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            ID = new Label();
            Name = new Label();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            SuspendLayout();
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(170, 106);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(219, 23);
            TxtId.TabIndex = 0;
            TxtId.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtName
            // 
            TxtName.Enabled = false;
            TxtName.Location = new Point(170, 155);
            TxtName.Name = "TxtName";
            TxtName.PlaceholderText = "Pay mode name";
            TxtName.Size = new Size(219, 23);
            TxtName.TabIndex = 1;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Columns.AddRange(new DataGridViewColumn[] { IdPaymode, NamePayMode });
            DgPayMode.Location = new Point(104, 225);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.Size = new Size(443, 200);
            DgPayMode.TabIndex = 2;
            DgPayMode.Click += DgPayMode_Click;
            // 
            // IdPaymode
            // 
            IdPaymode.HeaderText = "Id";
            IdPaymode.Name = "IdPaymode";
            IdPaymode.ReadOnly = true;
            IdPaymode.Resizable = DataGridViewTriState.False;
            // 
            // NamePayMode
            // 
            NamePayMode.HeaderText = "Name";
            NamePayMode.Name = "NamePayMode";
            NamePayMode.ReadOnly = true;
            NamePayMode.Resizable = DataGridViewTriState.False;
            NamePayMode.Width = 300;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.ImageAlign = ContentAlignment.TopCenter;
            BtnNew.Location = new Point(642, 32);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(87, 78);
            BtnNew.TabIndex = 3;
            BtnNew.Text = "&New";
            BtnNew.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.ImageAlign = ContentAlignment.TopCenter;
            BtnEdit.Location = new Point(642, 126);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(87, 78);
            BtnEdit.TabIndex = 4;
            BtnEdit.Text = "&Edit";
            BtnEdit.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.ImageAlign = ContentAlignment.TopCenter;
            BtnDelete.Location = new Point(642, 225);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(87, 79);
            BtnDelete.TabIndex = 5;
            BtnDelete.Text = "&Delete";
            BtnDelete.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.ImageAlign = ContentAlignment.TopCenter;
            BtnClose.Location = new Point(642, 323);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(87, 79);
            BtnClose.TabIndex = 6;
            BtnClose.Text = "&Close";
            BtnClose.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(104, 109);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 7;
            ID.Text = "ID";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(104, 158);
            Name.Name = "Name";
            Name.Size = new Size(39, 15);
            Name.TabIndex = 8;
            Name.Text = "Name";
            // 
            // PayModeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(Name);
            Controls.Add(ID);
            Controls.Add(BtnClose);
            Controls.Add(BtnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(BtnNew);
            Controls.Add(DgPayMode);
            Controls.Add(TxtName);
            Controls.Add(TxtId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pay Mode Management";
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtId;
        private TextBox TxtName;
        private DataGridView DgPayMode;
        private DataGridViewTextBoxColumn IdPaymode;
        private DataGridViewTextBoxColumn NamePayMode;
        private Button BtnNew;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnClose;
        private Label ID;
        private Label Name;
    }
}