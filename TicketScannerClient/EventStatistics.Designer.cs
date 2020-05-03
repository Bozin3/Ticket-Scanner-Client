namespace TicketScannerClient
{
    partial class EventStatistics
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
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblTotalTickets = new System.Windows.Forms.Label();
            this.lblActivatedTickets = new System.Windows.Forms.Label();
            this.lblInActiveTickets = new System.Windows.Forms.Label();
            this.ticketInfoGroup = new System.Windows.Forms.GroupBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbSearchActiveTcs = new System.Windows.Forms.TextBox();
            this.tbSearchInActiveTcs = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listActivatedTickets = new System.Windows.Forms.ListView();
            this.columnBarcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnActivatedAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listInActivatedTickets = new System.Windows.Forms.ListView();
            this.colBarcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketInfoGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEventDate.Location = new System.Drawing.Point(50, 88);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(223, 24);
            this.lblEventDate.TabIndex = 0;
            this.lblEventDate.Text = "Event date: 2019-03-09";
            // 
            // lblTotalTickets
            // 
            this.lblTotalTickets.AutoSize = true;
            this.lblTotalTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalTickets.Location = new System.Drawing.Point(18, 41);
            this.lblTotalTickets.Name = "lblTotalTickets";
            this.lblTotalTickets.Size = new System.Drawing.Size(171, 24);
            this.lblTotalTickets.TabIndex = 0;
            this.lblTotalTickets.Text = "Total tickets : 940";
            // 
            // lblActivatedTickets
            // 
            this.lblActivatedTickets.AutoSize = true;
            this.lblActivatedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActivatedTickets.Location = new System.Drawing.Point(18, 88);
            this.lblActivatedTickets.Name = "lblActivatedTickets";
            this.lblActivatedTickets.Size = new System.Drawing.Size(210, 24);
            this.lblActivatedTickets.TabIndex = 0;
            this.lblActivatedTickets.Text = "Activated tickets : 260";
            // 
            // lblInActiveTickets
            // 
            this.lblInActiveTickets.AutoSize = true;
            this.lblInActiveTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInActiveTickets.Location = new System.Drawing.Point(18, 134);
            this.lblInActiveTickets.Name = "lblInActiveTickets";
            this.lblInActiveTickets.Size = new System.Drawing.Size(227, 24);
            this.lblInActiveTickets.TabIndex = 0;
            this.lblInActiveTickets.Text = "InActivated tickets : 680";
            // 
            // ticketInfoGroup
            // 
            this.ticketInfoGroup.Controls.Add(this.lblInActiveTickets);
            this.ticketInfoGroup.Controls.Add(this.lblTotalTickets);
            this.ticketInfoGroup.Controls.Add(this.lblActivatedTickets);
            this.ticketInfoGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketInfoGroup.Location = new System.Drawing.Point(30, 38);
            this.ticketInfoGroup.Name = "ticketInfoGroup";
            this.ticketInfoGroup.Size = new System.Drawing.Size(288, 177);
            this.ticketInfoGroup.TabIndex = 1;
            this.ticketInfoGroup.TabStop = false;
            this.ticketInfoGroup.Text = "Ticket statistics :";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEventName.Location = new System.Drawing.Point(49, 40);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(377, 25);
            this.lblEventName.TabIndex = 3;
            this.lblEventName.Text = "Black Coffee - WIN MUSIC FREEDOM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(48, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Activated tickets :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Location = new System.Drawing.Point(17, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 20);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(552, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Not Activated tickets :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.panel2.Location = new System.Drawing.Point(521, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 20);
            this.panel2.TabIndex = 5;
            // 
            // tbSearchActiveTcs
            // 
            this.tbSearchActiveTcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchActiveTcs.Location = new System.Drawing.Point(155, 265);
            this.tbSearchActiveTcs.MaxLength = 20;
            this.tbSearchActiveTcs.Name = "tbSearchActiveTcs";
            this.tbSearchActiveTcs.Size = new System.Drawing.Size(189, 22);
            this.tbSearchActiveTcs.TabIndex = 6;
            this.tbSearchActiveTcs.TextChanged += new System.EventHandler(this.tbSearchActiveTcs_TextChanged);
            // 
            // tbSearchInActiveTcs
            // 
            this.tbSearchInActiveTcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchInActiveTcs.Location = new System.Drawing.Point(584, 265);
            this.tbSearchInActiveTcs.MaxLength = 20;
            this.tbSearchInActiveTcs.Name = "tbSearchInActiveTcs";
            this.tbSearchInActiveTcs.Size = new System.Drawing.Size(189, 22);
            this.tbSearchInActiveTcs.TabIndex = 6;
            this.tbSearchInActiveTcs.TextChanged += new System.EventHandler(this.tbSearchInActiveTcs_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEventName);
            this.groupBox1.Controls.Add(this.lblEventDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(324, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 177);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 29);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // listActivatedTickets
            // 
            this.listActivatedTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBarcode,
            this.columnActivatedAt});
            this.listActivatedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listActivatedTickets.FullRowSelect = true;
            this.listActivatedTickets.GridLines = true;
            this.listActivatedTickets.Location = new System.Drawing.Point(15, 294);
            this.listActivatedTickets.Name = "listActivatedTickets";
            this.listActivatedTickets.Size = new System.Drawing.Size(353, 323);
            this.listActivatedTickets.TabIndex = 11;
            this.listActivatedTickets.UseCompatibleStateImageBehavior = false;
            this.listActivatedTickets.View = System.Windows.Forms.View.Details;
            // 
            // columnBarcode
            // 
            this.columnBarcode.Text = "Barcode";
            this.columnBarcode.Width = 150;
            // 
            // columnActivatedAt
            // 
            this.columnActivatedAt.Text = "Activated At";
            this.columnActivatedAt.Width = 200;
            // 
            // listInActivatedTickets
            // 
            this.listInActivatedTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBarcode});
            this.listInActivatedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listInActivatedTickets.FullRowSelect = true;
            this.listInActivatedTickets.GridLines = true;
            this.listInActivatedTickets.Location = new System.Drawing.Point(439, 294);
            this.listInActivatedTickets.Name = "listInActivatedTickets";
            this.listInActivatedTickets.Size = new System.Drawing.Size(353, 323);
            this.listInActivatedTickets.TabIndex = 11;
            this.listInActivatedTickets.UseCompatibleStateImageBehavior = false;
            this.listInActivatedTickets.View = System.Windows.Forms.View.Details;
            // 
            // colBarcode
            // 
            this.colBarcode.Text = "Barcode";
            this.colBarcode.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter ticket\'s barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(436, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter ticket\'s barcode";
            // 
            // EventStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(804, 629);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listInActivatedTickets);
            this.Controls.Add(this.listActivatedTickets);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbSearchInActiveTcs);
            this.Controls.Add(this.tbSearchActiveTcs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ticketInfoGroup);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EventStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventStatistics_FormClosing);
            this.Load += new System.EventHandler(this.EventStatistics_Load);
            this.ticketInfoGroup.ResumeLayout(false);
            this.ticketInfoGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblTotalTickets;
        private System.Windows.Forms.Label lblActivatedTickets;
        private System.Windows.Forms.Label lblInActiveTickets;
        private System.Windows.Forms.GroupBox ticketInfoGroup;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbSearchActiveTcs;
        private System.Windows.Forms.TextBox tbSearchInActiveTcs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ListView listActivatedTickets;
        private System.Windows.Forms.ColumnHeader columnBarcode;
        private System.Windows.Forms.ListView listInActivatedTickets;
        private System.Windows.Forms.ColumnHeader colBarcode;
        private System.Windows.Forms.ColumnHeader columnActivatedAt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}