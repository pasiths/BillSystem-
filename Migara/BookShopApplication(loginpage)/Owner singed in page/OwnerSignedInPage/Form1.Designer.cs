
namespace OwnerSignedInPage
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.owUserAccountImage = new System.Windows.Forms.PictureBox();
            this.owSignOutImage = new System.Windows.Forms.PictureBox();
            this.owUserAccountlbl = new System.Windows.Forms.Label();
            this.owSignOutlbl = new System.Windows.Forms.Label();
            this.billManager = new System.Windows.Forms.Button();
            this.billDashboard = new System.Windows.Forms.Button();
            this.store = new System.Windows.Forms.Button();
            this.cashierDashboard = new System.Windows.Forms.Button();
            this.addMember = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.owUserAccountImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.owSignOutImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(156, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROYAL BOOK SHOP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // owUserAccountImage
            // 
            this.owUserAccountImage.Image = ((System.Drawing.Image)(resources.GetObject("owUserAccountImage.Image")));
            this.owUserAccountImage.Location = new System.Drawing.Point(12, 66);
            this.owUserAccountImage.Name = "owUserAccountImage";
            this.owUserAccountImage.Size = new System.Drawing.Size(25, 22);
            this.owUserAccountImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.owUserAccountImage.TabIndex = 1;
            this.owUserAccountImage.TabStop = false;
            // 
            // owSignOutImage
            // 
            this.owSignOutImage.Image = ((System.Drawing.Image)(resources.GetObject("owSignOutImage.Image")));
            this.owSignOutImage.Location = new System.Drawing.Point(485, 61);
            this.owSignOutImage.Name = "owSignOutImage";
            this.owSignOutImage.Size = new System.Drawing.Size(35, 32);
            this.owSignOutImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.owSignOutImage.TabIndex = 1;
            this.owSignOutImage.TabStop = false;
            // 
            // owUserAccountlbl
            // 
            this.owUserAccountlbl.AutoSize = true;
            this.owUserAccountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owUserAccountlbl.Location = new System.Drawing.Point(43, 69);
            this.owUserAccountlbl.Name = "owUserAccountlbl";
            this.owUserAccountlbl.Size = new System.Drawing.Size(63, 16);
            this.owUserAccountlbl.TabIndex = 2;
            this.owUserAccountlbl.Text = "Account";
            // 
            // owSignOutlbl
            // 
            this.owSignOutlbl.AutoSize = true;
            this.owSignOutlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owSignOutlbl.Location = new System.Drawing.Point(413, 69);
            this.owSignOutlbl.Name = "owSignOutlbl";
            this.owSignOutlbl.Size = new System.Drawing.Size(66, 16);
            this.owSignOutlbl.TabIndex = 2;
            this.owSignOutlbl.Text = "Sign Out";
            // 
            // billManager
            // 
            this.billManager.BackColor = System.Drawing.SystemColors.Highlight;
            this.billManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billManager.ForeColor = System.Drawing.SystemColors.ControlText;
            this.billManager.Location = new System.Drawing.Point(167, 128);
            this.billManager.Name = "billManager";
            this.billManager.Size = new System.Drawing.Size(208, 33);
            this.billManager.TabIndex = 3;
            this.billManager.Text = "Bill Manager";
            this.billManager.UseVisualStyleBackColor = false;
            // 
            // billDashboard
            // 
            this.billDashboard.BackColor = System.Drawing.SystemColors.Highlight;
            this.billDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billDashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.billDashboard.Location = new System.Drawing.Point(167, 177);
            this.billDashboard.Name = "billDashboard";
            this.billDashboard.Size = new System.Drawing.Size(208, 33);
            this.billDashboard.TabIndex = 3;
            this.billDashboard.Text = "Bill Dashboard";
            this.billDashboard.UseVisualStyleBackColor = false;
            // 
            // store
            // 
            this.store.BackColor = System.Drawing.SystemColors.Highlight;
            this.store.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.store.ForeColor = System.Drawing.SystemColors.ControlText;
            this.store.Location = new System.Drawing.Point(167, 225);
            this.store.Name = "store";
            this.store.Size = new System.Drawing.Size(208, 33);
            this.store.TabIndex = 3;
            this.store.Text = "Store";
            this.store.UseVisualStyleBackColor = false;
            // 
            // cashierDashboard
            // 
            this.cashierDashboard.BackColor = System.Drawing.SystemColors.Highlight;
            this.cashierDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierDashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cashierDashboard.Location = new System.Drawing.Point(167, 274);
            this.cashierDashboard.Name = "cashierDashboard";
            this.cashierDashboard.Size = new System.Drawing.Size(208, 33);
            this.cashierDashboard.TabIndex = 3;
            this.cashierDashboard.Text = "Cashier Dashboard";
            this.cashierDashboard.UseVisualStyleBackColor = false;
            this.cashierDashboard.Click += new System.EventHandler(this.button4_Click);
            // 
            // addMember
            // 
            this.addMember.BackColor = System.Drawing.SystemColors.Highlight;
            this.addMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMember.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addMember.Location = new System.Drawing.Point(167, 323);
            this.addMember.Name = "addMember";
            this.addMember.Size = new System.Drawing.Size(208, 33);
            this.addMember.TabIndex = 3;
            this.addMember.Text = "Add Member";
            this.addMember.UseVisualStyleBackColor = false;
            // 
            // cancel
            // 
            this.cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancel.Location = new System.Drawing.Point(416, 392);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(82, 30);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addMember);
            this.Controls.Add(this.cashierDashboard);
            this.Controls.Add(this.store);
            this.Controls.Add(this.billDashboard);
            this.Controls.Add(this.billManager);
            this.Controls.Add(this.owSignOutlbl);
            this.Controls.Add(this.owUserAccountlbl);
            this.Controls.Add(this.owSignOutImage);
            this.Controls.Add(this.owUserAccountImage);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "Form1";
            this.Text = "Owner Signed In";
            ((System.ComponentModel.ISupportInitialize)(this.owUserAccountImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.owSignOutImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox owUserAccountImage;
        private System.Windows.Forms.PictureBox owSignOutImage;
        private System.Windows.Forms.Label owUserAccountlbl;
        private System.Windows.Forms.Label owSignOutlbl;
        private System.Windows.Forms.Button billManager;
        private System.Windows.Forms.Button billDashboard;
        private System.Windows.Forms.Button store;
        private System.Windows.Forms.Button cashierDashboard;
        private System.Windows.Forms.Button addMember;
        private System.Windows.Forms.Button cancel;
    }
}

