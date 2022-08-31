
namespace FinalProject
{
    partial class MemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookListToolStripMenuItem,
            this.memberListToolStripMenuItem,
            this.bookReportsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(886, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookListToolStripMenuItem
            // 
            this.bookListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookListToolStripMenuItem.Image")));
            this.bookListToolStripMenuItem.Name = "bookListToolStripMenuItem";
            this.bookListToolStripMenuItem.Size = new System.Drawing.Size(91, 28);
            this.bookListToolStripMenuItem.Text = "Book List";
            this.bookListToolStripMenuItem.Click += new System.EventHandler(this.bookListToolStripMenuItem_Click);
            // 
            // memberListToolStripMenuItem
            // 
            this.memberListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("memberListToolStripMenuItem.Image")));
            this.memberListToolStripMenuItem.Name = "memberListToolStripMenuItem";
            this.memberListToolStripMenuItem.Size = new System.Drawing.Size(109, 28);
            this.memberListToolStripMenuItem.Text = "Member List";
            this.memberListToolStripMenuItem.Click += new System.EventHandler(this.memberListToolStripMenuItem_Click);
            // 
            // bookReportsToolStripMenuItem
            // 
            this.bookReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReportsToolStripMenuItem,
            this.viewReportsToolStripMenuItem});
            this.bookReportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookReportsToolStripMenuItem.Image")));
            this.bookReportsToolStripMenuItem.Name = "bookReportsToolStripMenuItem";
            this.bookReportsToolStripMenuItem.Size = new System.Drawing.Size(113, 28);
            this.bookReportsToolStripMenuItem.Text = "Book Reports";
            // 
            // addReportsToolStripMenuItem
            // 
            this.addReportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addReportsToolStripMenuItem.Image")));
            this.addReportsToolStripMenuItem.Name = "addReportsToolStripMenuItem";
            this.addReportsToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.addReportsToolStripMenuItem.Text = "Add Reports";
            this.addReportsToolStripMenuItem.Click += new System.EventHandler(this.addReportsToolStripMenuItem_Click);
            // 
            // viewReportsToolStripMenuItem
            // 
            this.viewReportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewReportsToolStripMenuItem.Image")));
            this.viewReportsToolStripMenuItem.Name = "viewReportsToolStripMenuItem";
            this.viewReportsToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.viewReportsToolStripMenuItem.Text = "View Reports";
            this.viewReportsToolStripMenuItem.Click += new System.EventHandler(this.viewReportsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(61, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(886, 385);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MemberForm";
            this.Text = "MemberForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}