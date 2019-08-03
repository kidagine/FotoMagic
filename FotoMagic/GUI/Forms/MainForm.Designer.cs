namespace FotoMagic
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lstCustomers = new System.Windows.Forms.ListView();
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOwedMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Name = "label1";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAddCustomer, "btnAddCustomer");
            this.btnAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // shapeContainer1
            // 
            resources.ApplyResources(this.shapeContainer1, "shapeContainer1");
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            resources.ApplyResources(this.lineShape3, "lineShape3");
            this.lineShape3.Name = "lineShape3";
            // 
            // lineShape2
            // 
            resources.ApplyResources(this.lineShape2, "lineShape2");
            this.lineShape2.Name = "lineShape2";
            // 
            // lineShape1
            // 
            resources.ApplyResources(this.lineShape1, "lineShape1");
            this.lineShape1.Name = "lineShape1";
            // 
            // lstCustomers
            // 
            resources.ApplyResources(this.lstCustomers, "lstCustomers");
            this.lstCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lstCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFirstName,
            this.colLastName,
            this.colOwedMoney});
            this.lstCustomers.FullRowSelect = true;
            this.lstCustomers.GridLines = true;
            this.lstCustomers.HideSelection = false;
            this.lstCustomers.MultiSelect = false;
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.UseCompatibleStateImageBehavior = false;
            this.lstCustomers.View = System.Windows.Forms.View.Details;
            // 
            // colFirstName
            // 
            resources.ApplyResources(this.colFirstName, "colFirstName");
            // 
            // colLastName
            // 
            resources.ApplyResources(this.colLastName, "colLastName");
            // 
            // colOwedMoney
            // 
            resources.ApplyResources(this.colOwedMoney, "colOwedMoney");
            // 
            // txbSearch
            // 
            resources.ApplyResources(this.txbSearch, "txbSearch");
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.TextChanged += new System.EventHandler(this.TxbSearch_TextChanged);
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnRemoveCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemoveCustomer.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnRemoveCustomer, "btnRemoveCustomer");
            this.btnRemoveCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.UseVisualStyleBackColor = false;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.BtnRemoveCustomer_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.btnRemoveCustomer);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCustomer;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.ListView lstCustomers;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colOwedMoney;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnRemoveCustomer;
    }
}