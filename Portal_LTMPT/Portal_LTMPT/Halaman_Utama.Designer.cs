/*
 * Created by SharpDevelop.
 * User: Windows 10
 * Date: 07/06/2022
 * Time: 20:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Portal_LTMPT
{
	partial class Halaman_Utama
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem arrangeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cascadingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vertikalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Halaman_Utama));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.arrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cascadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vertikalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fILEToolStripMenuItem,
									this.arrangeToolStripMenuItem,
									this.loginToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1245, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fILEToolStripMenuItem
			// 
			this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.nEWToolStripMenuItem,
									this.exitToolStripMenuItem});
			this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
			this.fILEToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
			this.fILEToolStripMenuItem.Text = "FILE";
			// 
			// nEWToolStripMenuItem
			// 
			this.nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
			this.nEWToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + N";
			this.nEWToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.nEWToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
			this.nEWToolStripMenuItem.Text = "Beranda";
			this.nEWToolStripMenuItem.Click += new System.EventHandler(this.NEWToolStripMenuItemClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt + F4";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// arrangeToolStripMenuItem
			// 
			this.arrangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cascadingToolStripMenuItem,
									this.vertikalToolStripMenuItem,
									this.horizontalToolStripMenuItem});
			this.arrangeToolStripMenuItem.Name = "arrangeToolStripMenuItem";
			this.arrangeToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
			this.arrangeToolStripMenuItem.Text = "Arrange";
			// 
			// cascadingToolStripMenuItem
			// 
			this.cascadingToolStripMenuItem.Name = "cascadingToolStripMenuItem";
			this.cascadingToolStripMenuItem.ShortcutKeyDisplayString = "Alt + F1";
			this.cascadingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
			this.cascadingToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
			this.cascadingToolStripMenuItem.Text = "Cascading";
			this.cascadingToolStripMenuItem.Click += new System.EventHandler(this.CascadingToolStripMenuItemClick);
			// 
			// vertikalToolStripMenuItem
			// 
			this.vertikalToolStripMenuItem.Name = "vertikalToolStripMenuItem";
			this.vertikalToolStripMenuItem.ShortcutKeyDisplayString = "Alt + F2";
			this.vertikalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
			this.vertikalToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
			this.vertikalToolStripMenuItem.Text = "Vertikal";
			this.vertikalToolStripMenuItem.Click += new System.EventHandler(this.VertikalToolStripMenuItemClick);
			// 
			// horizontalToolStripMenuItem
			// 
			this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
			this.horizontalToolStripMenuItem.ShortcutKeyDisplayString = "Alt + F3";
			this.horizontalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
			this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
			this.horizontalToolStripMenuItem.Text = "Horizontal";
			this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.HorizontalToolStripMenuItemClick);
			// 
			// loginToolStripMenuItem
			// 
			this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.databaseToolStripMenuItem});
			this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
			this.loginToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
			this.loginToolStripMenuItem.Text = "LOGIN";
			this.loginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItemClick);
			// 
			// databaseToolStripMenuItem
			// 
			this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
			this.databaseToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
			this.databaseToolStripMenuItem.Text = "Database";
			this.databaseToolStripMenuItem.Click += new System.EventHandler(this.DatabaseToolStripMenuItemClick);
			// 
			// Halaman_Utama
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1245, 814);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Halaman_Utama";
			this.Text = "Halaman Utama";
			this.Load += new System.EventHandler(this.Halaman_UtamaLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
	}
}
