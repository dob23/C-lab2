namespace Supermarket
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainMenu = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            MasterMenuItem = new ToolStripMenuItem();
            ProductsMenuItem = new ToolStripMenuItem();
            ProvidersMenuItem = new ToolStripMenuItem();
            CategoriesMenuItem = new ToolStripMenuItem();
            PayModeMenuItem = new ToolStripMenuItem();
            TransactionsMenuItem = new ToolStripMenuItem();
            SellMenuItem = new ToolStripMenuItem();
            PurchaseMenuItem = new ToolStripMenuItem();
            HelpMenuItem = new ToolStripMenuItem();
            AboutMenuItem = new ToolStripMenuItem();
            MainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.Items.AddRange(new ToolStripItem[] { FileMenuItem, MasterMenuItem, TransactionsMenuItem, HelpMenuItem });
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(800, 24);
            MainMenu.TabIndex = 1;
            MainMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExitMenuItem });
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(37, 20);
            FileMenuItem.Text = "File";
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(93, 22);
            ExitMenuItem.Text = "Exit";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // MasterMenuItem
            // 
            MasterMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ProductsMenuItem, ProvidersMenuItem, CategoriesMenuItem, PayModeMenuItem });
            MasterMenuItem.Name = "MasterMenuItem";
            MasterMenuItem.Size = new Size(55, 20);
            MasterMenuItem.Text = "Master";
            // 
            // ProductsMenuItem
            // 
            ProductsMenuItem.Name = "ProductsMenuItem";
            ProductsMenuItem.Size = new Size(180, 22);
            ProductsMenuItem.Text = "Products";
            // 
            // ProvidersMenuItem
            // 
            ProvidersMenuItem.Name = "ProvidersMenuItem";
            ProvidersMenuItem.Size = new Size(180, 22);
            ProvidersMenuItem.Text = "Providers";
            // 
            // CategoriesMenuItem
            // 
            CategoriesMenuItem.Name = "CategoriesMenuItem";
            CategoriesMenuItem.Size = new Size(180, 22);
            CategoriesMenuItem.Text = "Categories";
            // 
            // PayModeMenuItem
            // 
            PayModeMenuItem.Name = "PayModeMenuItem";
            PayModeMenuItem.Size = new Size(180, 22);
            PayModeMenuItem.Text = "Pay Mode";
            PayModeMenuItem.Click += PayModeMenuItem_Click;
            // 
            // TransactionsMenuItem
            // 
            TransactionsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SellMenuItem, PurchaseMenuItem });
            TransactionsMenuItem.Name = "TransactionsMenuItem";
            TransactionsMenuItem.Size = new Size(84, 20);
            TransactionsMenuItem.Text = "Transactions";
            // 
            // SellMenuItem
            // 
            SellMenuItem.Name = "SellMenuItem";
            SellMenuItem.Size = new Size(180, 22);
            SellMenuItem.Text = "Sell";
            // 
            // PurchaseMenuItem
            // 
            PurchaseMenuItem.Name = "PurchaseMenuItem";
            PurchaseMenuItem.Size = new Size(180, 22);
            PurchaseMenuItem.Text = "Purchase";
            // 
            // HelpMenuItem
            // 
            HelpMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutMenuItem });
            HelpMenuItem.Name = "HelpMenuItem";
            HelpMenuItem.Size = new Size(44, 20);
            HelpMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            AboutMenuItem.Name = "AboutMenuItem";
            AboutMenuItem.Size = new Size(107, 22);
            AboutMenuItem.Text = "About";
            AboutMenuItem.Click += AboutMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainMenu);
            IsMdiContainer = true;
            MainMenuStrip = MainMenu;
            Name = "MainForm";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void AboutMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Supermarket V 0.1", "About us");
        }

        #endregion

        private MenuStrip MainMenu;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem MasterMenuItem;
        private ToolStripMenuItem ProductsMenuItem;
        private ToolStripMenuItem ProvidersMenuItem;
        private ToolStripMenuItem CategoriesMenuItem;
        private ToolStripMenuItem PayModeMenuItem;
        private ToolStripMenuItem TransactionsMenuItem;
        private ToolStripMenuItem SellMenuItem;
        private ToolStripMenuItem PurchaseMenuItem;
        private ToolStripMenuItem HelpMenuItem;
        private ToolStripMenuItem AboutMenuItem;
        private ToolStripMenuItem ExitMenuItem;
    }
}
