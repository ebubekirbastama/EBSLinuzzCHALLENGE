
namespace EBSLinuzzCHALLENGE
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eBSTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mesajAtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numaralarıOkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 1081);
            this.panel1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eBSTimeToolStripMenuItem,
            this.toolStripSeparator1,
            this.mesajAtToolStripMenuItem,
            this.numaralarıOkuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 76);
            // 
            // eBSTimeToolStripMenuItem
            // 
            this.eBSTimeToolStripMenuItem.Enabled = false;
            this.eBSTimeToolStripMenuItem.Name = "eBSTimeToolStripMenuItem";
            this.eBSTimeToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.eBSTimeToolStripMenuItem.Text = "EBS Time";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // mesajAtToolStripMenuItem
            // 
            this.mesajAtToolStripMenuItem.Name = "mesajAtToolStripMenuItem";
            this.mesajAtToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.mesajAtToolStripMenuItem.Text = "Mesaj At";
            this.mesajAtToolStripMenuItem.Click += new System.EventHandler(this.mesajAtToolStripMenuItem_Click);
            // 
            // numaralarıOkuToolStripMenuItem
            // 
            this.numaralarıOkuToolStripMenuItem.Name = "numaralarıOkuToolStripMenuItem";
            this.numaralarıOkuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.numaralarıOkuToolStripMenuItem.Text = "Numaraları Oku";
            this.numaralarıOkuToolStripMenuItem.Click += new System.EventHandler(this.numaralarıOkuToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1469, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 1057);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 1084);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eBSTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mesajAtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numaralarıOkuToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}

