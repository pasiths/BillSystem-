
namespace CashierSignedInPage
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
            this.billManager = new System.Windows.Forms.Button();
            this.billDashboard = new System.Windows.Forms.Button();
            this.storeDashboard = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.caAccountSignedInImg = new System.Windows.Forms.PictureBox();
            this.caAccountSignOutImg = new System.Windows.Forms.PictureBox();
            this.caAccountSignedInLbl = new System.Windows.Forms.Label();
            this.caAccountSignOutLbl = new System.Windows.Forms.Label();
            this.store = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.caAccountSignedInImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caAccountSignOutImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(147, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROYAL BOOK SHOP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // billManager
            // 
            this.billManager.BackColor = System.Drawing.SystemColors.Highlight;
            this.billManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billManager.Location = new System.Drawing.Point(130, 136);
            this.billManager.Name = "billManager";
            this.billManager.Size = new System.Drawing.Size(211, 33);
            this.billManager.TabIndex = 1;
            this.billManager.Text = "Bill Manager";
            this.billManager.UseVisualStyleBackColor = false;
            // 
            // billDashboard
            // 
            this.billDashboard.BackColor = System.Drawing.SystemColors.Highlight;
            this.billDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billDashboard.Location = new System.Drawing.Point(130, 197);
            this.billDashboard.Name = "billDashboard";
            this.billDashboard.Size = new System.Drawing.Size(211, 33);
            this.billDashboard.TabIndex = 1;
            this.billDashboard.Text = "Bill Dashboard";
            this.billDashboard.UseVisualStyleBackColor = false;
            // 
            // storeDashboard
            // 
            this.storeDashboard.BackColor = System.Drawing.SystemColors.Highlight;
            this.storeDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeDashboard.Location = new System.Drawing.Point(130, 256);
            this.storeDashboard.Name = "storeDashboard";
            this.storeDashboard.Size = new System.Drawing.Size(211, 33);
            this.storeDashboard.TabIndex = 1;
            this.storeDashboard.Text = "Store Dashboard";
            this.storeDashboard.UseVisualStyleBackColor = false;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(359, 393);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // caAccountSignedInImg
            // 
            this.caAccountSignedInImg.Image = ((System.Drawing.Image)(resources.GetObject("caAccountSignedInImg.Image")));
            this.caAccountSignedInImg.Location = new System.Drawing.Point(12, 73);
            this.caAccountSignedInImg.Name = "caAccountSignedInImg";
            this.caAccountSignedInImg.Size = new System.Drawing.Size(26, 25);
            this.caAccountSignedInImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.caAccountSignedInImg.TabIndex = 3;
            this.caAccountSignedInImg.TabStop = false;
            // 
            // caAccountSignOutImg
            // 
            this.caAccountSignOutImg.Image = ((System.Drawing.Image)(resources.GetObject("caAccountSignOutImg.Image")));
            this.caAccountSignOutImg.Location = new System.Drawing.Point(427, 73);
            this.caAccountSignOutImg.Name = "caAccountSignOutImg";
            this.caAccountSignOutImg.Size = new System.Drawing.Size(26, 25);
            this.caAccountSignOutImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.caAccountSignOutImg.TabIndex = 3;
            this.caAccountSignOutImg.TabStop = false;
            // 
            // caAccountSignedInLbl
            // 
            this.caAccountSignedInLbl.AutoSize = true;
            this.caAccountSignedInLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caAccountSignedInLbl.Location = new System.Drawing.Point(45, 79);
            this.caAccountSignedInLbl.Name = "caAccountSignedInLbl";
            this.caAccountSignedInLbl.Size = new System.Drawing.Size(63, 16);
            this.caAccountSignedInLbl.TabIndex = 4;
            this.caAccountSignedInLbl.Text = "Account";
            // 
            // caAccountSignOutLbl
            // 
            this.caAccountSignOutLbl.AutoSize = true;
            this.caAccountSignOutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caAccountSignOutLbl.Location = new System.Drawing.Point(356, 79);
            this.caAccountSignOutLbl.Name = "caAccountSignOutLbl";
            this.caAccountSignOutLbl.Size = new System.Drawing.Size(66, 16);
            this.caAccountSignOutLbl.TabIndex = 4;
            this.caAccountSignOutLbl.Text = "Sign Out";
            // 
            // store
            // 
            this.store.BackColor = System.Drawing.SystemColors.Highlight;
            this.store.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.store.Location = new System.Drawing.Point(130, 314);
            this.store.Name = "store";
            this.store.Size = new System.Drawing.Size(211, 33);
            this.store.TabIndex = 1;
            this.store.Text = "Store";
            this.store.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.caAccountSignOutLbl);
            this.Controls.Add(this.caAccountSignedInLbl);
            this.Controls.Add(this.caAccountSignOutImg);
            this.Controls.Add(this.caAccountSignedInImg);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.store);
            this.Controls.Add(this.storeDashboard);
            this.Controls.Add(this.billDashboard);
            this.Controls.Add(this.billManager);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cashier Signed In";
            ((System.ComponentModel.ISupportInitialize)(this.caAccountSignedInImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caAccountSignOutImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button billManager;
        private System.Windows.Forms.Button billDashboard;
        private System.Windows.Forms.Button storeDashboard;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.PictureBox caAccountSignedInImg;
        private System.Windows.Forms.PictureBox caAccountSignOutImg;
        private System.Windows.Forms.Label caAccountSignedInLbl;
        private System.Windows.Forms.Label caAccountSignOutLbl;
        private System.Windows.Forms.Button store;
    }
}

