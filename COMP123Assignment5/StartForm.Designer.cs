namespace COMP123Assignment5
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.NewOrder = new System.Windows.Forms.Button();
            this.SavedOrder = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Order = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NewOrder
            // 
            this.NewOrder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewOrder.Location = new System.Drawing.Point(259, 270);
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(271, 54);
            this.NewOrder.TabIndex = 0;
            this.NewOrder.Text = "Start a New Order";
            this.NewOrder.UseVisualStyleBackColor = false;
            // 
            // SavedOrder
            // 
            this.SavedOrder.BackColor = System.Drawing.SystemColors.GrayText;
            this.SavedOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavedOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SavedOrder.Location = new System.Drawing.Point(259, 330);
            this.SavedOrder.Name = "SavedOrder";
            this.SavedOrder.Size = new System.Drawing.Size(271, 55);
            this.SavedOrder.TabIndex = 1;
            this.SavedOrder.Text = "Open a Saved Order";
            this.SavedOrder.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.GrayText;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(332, 391);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(112, 47);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(239, 68);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 196);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // Order
            // 
            this.Order.AutoSize = true;
            this.Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Order.Location = new System.Drawing.Point(234, 29);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(285, 25);
            this.Order.TabIndex = 4;
            this.Order.Text = "Order Your Computer Today";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Order);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SavedOrder);
            this.Controls.Add(this.NewOrder);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewOrder;
        private System.Windows.Forms.Button SavedOrder;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label Order;
    }
}

