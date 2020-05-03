namespace TicketScannerClient
{
    partial class TicketScannerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketScannerForm));
            this.colorPanel = new System.Windows.Forms.Panel();
            this.lblActivatedAt = new System.Windows.Forms.Label();
            this.lblValid = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.optionsMenu = new System.Windows.Forms.MenuStrip();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseAnEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgBarcode = new System.Windows.Forms.PictureBox();
            this.tbBarcodeInput = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.colorPanel.SuspendLayout();
            this.optionsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.LightGray;
            this.colorPanel.Controls.Add(this.lblActivatedAt);
            this.colorPanel.Controls.Add(this.lblValid);
            this.colorPanel.Controls.Add(this.lblBarcode);
            this.colorPanel.Location = new System.Drawing.Point(3, 270);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(798, 327);
            this.colorPanel.TabIndex = 0;
            // 
            // lblActivatedAt
            // 
            this.lblActivatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActivatedAt.Location = new System.Drawing.Point(139, 235);
            this.lblActivatedAt.Name = "lblActivatedAt";
            this.lblActivatedAt.Size = new System.Drawing.Size(546, 39);
            this.lblActivatedAt.TabIndex = 2;
            this.lblActivatedAt.Text = "Activated at : 2019-03-09 23:24:00";
            this.lblActivatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValid
            // 
            this.lblValid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValid.Location = new System.Drawing.Point(325, 166);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(168, 55);
            this.lblValid.TabIndex = 1;
            this.lblValid.Text = "VALID";
            this.lblValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBarcode
            // 
            this.lblBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBarcode.Location = new System.Drawing.Point(85, 58);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(639, 108);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "43553005353";
            this.lblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEventName.Location = new System.Drawing.Point(12, 50);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(149, 29);
            this.lblEventName.TabIndex = 1;
            this.lblEventName.Text = "Event name";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEventDate.Location = new System.Drawing.Point(12, 94);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(122, 25);
            this.lblEventDate.TabIndex = 1;
            this.lblEventDate.Text = "2019-03-09";
            // 
            // optionsMenu
            // 
            this.optionsMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.optionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsMenu.Location = new System.Drawing.Point(0, 0);
            this.optionsMenu.Name = "optionsMenu";
            this.optionsMenu.Size = new System.Drawing.Size(797, 29);
            this.optionsMenu.TabIndex = 2;
            this.optionsMenu.Text = "Options";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseAnEventToolStripMenuItem});
            this.eventsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.eventsToolStripMenuItem.Text = "Events";
            // 
            // chooseAnEventToolStripMenuItem
            // 
            this.chooseAnEventToolStripMenuItem.Name = "chooseAnEventToolStripMenuItem";
            this.chooseAnEventToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.chooseAnEventToolStripMenuItem.Text = "Choose an event";
            this.chooseAnEventToolStripMenuItem.Click += new System.EventHandler(this.chooseAnEventToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // imgBarcode
            // 
            this.imgBarcode.Image = ((System.Drawing.Image)(resources.GetObject("imgBarcode.Image")));
            this.imgBarcode.Location = new System.Drawing.Point(222, 136);
            this.imgBarcode.Name = "imgBarcode";
            this.imgBarcode.Size = new System.Drawing.Size(389, 81);
            this.imgBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgBarcode.TabIndex = 3;
            this.imgBarcode.TabStop = false;
            // 
            // tbBarcodeInput
            // 
            this.tbBarcodeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBarcodeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBarcodeInput.Location = new System.Drawing.Point(275, 223);
            this.tbBarcodeInput.MaxLength = 16;
            this.tbBarcodeInput.Name = "tbBarcodeInput";
            this.tbBarcodeInput.Size = new System.Drawing.Size(267, 29);
            this.tbBarcodeInput.TabIndex = 4;
            this.tbBarcodeInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBarcodeInput_KeyPress);
            // 
            // lblClient
            // 
            this.lblClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClient.Location = new System.Drawing.Point(705, 50);
            this.lblClient.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(93, 20);
            this.lblClient.TabIndex = 5;
            this.lblClient.Text = "Client name";
            this.lblClient.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TicketScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(797, 628);
            this.ControlBox = false;
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.tbBarcodeInput);
            this.Controls.Add(this.imgBarcode);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.optionsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.optionsMenu;
            this.Name = "TicketScannerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Scanner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TicketScannerForm_Load);
            this.colorPanel.ResumeLayout(false);
            this.optionsMenu.ResumeLayout(false);
            this.optionsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblActivatedAt;
        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.MenuStrip optionsMenu;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgBarcode;
        private System.Windows.Forms.ToolStripMenuItem chooseAnEventToolStripMenuItem;
        private System.Windows.Forms.TextBox tbBarcodeInput;
        private System.Windows.Forms.Label lblClient;
    }
}