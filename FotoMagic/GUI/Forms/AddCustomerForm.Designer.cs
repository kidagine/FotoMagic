namespace FotoMagic
{
    partial class AddCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerForm));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rctBlueLast = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rctBlueFirst = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCustomerFirstName = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.txbCustomerLastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rctBlueLast,
            this.rctBlueFirst,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(630, 418);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // rctBlueLast
            // 
            this.rctBlueLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(243)))));
            this.rctBlueLast.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rctBlueLast.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(243)))));
            this.rctBlueLast.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(243)))));
            this.rctBlueLast.Location = new System.Drawing.Point(139, 189);
            this.rctBlueLast.Name = "rctBlueLast";
            this.rctBlueLast.Size = new System.Drawing.Size(4, 17);
            // 
            // rctBlueFirst
            // 
            this.rctBlueFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(243)))));
            this.rctBlueFirst.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rctBlueFirst.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(243)))));
            this.rctBlueFirst.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(243)))));
            this.rctBlueFirst.Location = new System.Drawing.Point(138, 93);
            this.rctBlueFirst.Name = "rctBlueFirst";
            this.rctBlueFirst.Size = new System.Drawing.Size(4, 17);
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 21;
            this.lineShape2.X2 = 598;
            this.lineShape2.Y1 = 394;
            this.lineShape2.Y2 = 394;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 26;
            this.lineShape1.X2 = 603;
            this.lineShape1.Y1 = 59;
            this.lineShape1.Y2 = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calamity", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Customer";
            // 
            // txbCustomerFirstName
            // 
            this.txbCustomerFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCustomerFirstName.Font = new System.Drawing.Font("Calamity", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCustomerFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.txbCustomerFirstName.Location = new System.Drawing.Point(136, 121);
            this.txbCustomerFirstName.Multiline = true;
            this.txbCustomerFirstName.Name = "txbCustomerFirstName";
            this.txbCustomerFirstName.Size = new System.Drawing.Size(384, 45);
            this.txbCustomerFirstName.TabIndex = 3;
            this.txbCustomerFirstName.TabStop = false;
            this.txbCustomerFirstName.Text = "Enter the customer\'s first name";
            this.txbCustomerFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbCustomerFirstName.Enter += new System.EventHandler(this.TxbCustomerFirstName_Enter);
            this.txbCustomerFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxbCustomerFirstName_KeyDown);
            this.txbCustomerFirstName.Leave += new System.EventHandler(this.TxbCustomerFirstName_Leave);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Calamity", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btnConfirm.Location = new System.Drawing.Point(217, 300);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(197, 46);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Calamity", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCustomerName.Location = new System.Drawing.Point(147, 91);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(90, 20);
            this.lblCustomerName.TabIndex = 5;
            this.lblCustomerName.Text = "First Name";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calamity", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(155)))), ((int)(((byte)(243)))));
            this.btnExit.Location = new System.Drawing.Point(252, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit instead?";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Font = new System.Drawing.Font("Calamity", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCustomerLastName.Location = new System.Drawing.Point(147, 187);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(89, 20);
            this.lblCustomerLastName.TabIndex = 7;
            this.lblCustomerLastName.Text = "Last Name";
            // 
            // txbCustomerLastName
            // 
            this.txbCustomerLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCustomerLastName.Font = new System.Drawing.Font("Calamity", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCustomerLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.txbCustomerLastName.Location = new System.Drawing.Point(138, 219);
            this.txbCustomerLastName.Multiline = true;
            this.txbCustomerLastName.Name = "txbCustomerLastName";
            this.txbCustomerLastName.Size = new System.Drawing.Size(384, 45);
            this.txbCustomerLastName.TabIndex = 8;
            this.txbCustomerLastName.TabStop = false;
            this.txbCustomerLastName.Text = "Enter the customer\'s last name";
            this.txbCustomerLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbCustomerLastName.Enter += new System.EventHandler(this.TxbCustomerLastName_Enter);
            this.txbCustomerLastName.Leave += new System.EventHandler(this.TxbCustomerLastName_Leave);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(630, 418);
            this.Controls.Add(this.txbCustomerLastName);
            this.Controls.Add(this.lblCustomerLastName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txbCustomerFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Calamity", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FotoMagic";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCustomerFirstName;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblCustomerName;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rctBlueFirst;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCustomerLastName;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rctBlueLast;
        private System.Windows.Forms.TextBox txbCustomerLastName;
    }
}