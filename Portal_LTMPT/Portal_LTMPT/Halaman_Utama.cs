/*
 * Created by SharpDevelop.
 * User: Windows 10
 * Date: 07/06/2022
 * Time: 20:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Portal_LTMPT
{
	/// <summary>
	/// Description of Halaman_Utama.
	/// </summary>
	public partial class Halaman_Utama : Form
	{
		public Halaman_Utama()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void NEWToolStripMenuItemClick(object sender, EventArgs e)
		{
			Beranda frmChild = new Beranda();
			frmChild.MdiParent = this;
			frmChild.Show();
		}
		
		void CascadingToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}
		
		void VertikalToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}
		
		void HorizontalToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}
		
		
		
		void Halaman_UtamaLoad(object sender, EventArgs e)
		{
			
		}
		
		void ExitToolStripMenuItem1Click(object sender, EventArgs e)
		{
			
		}
		
		void DatabaseToolStripMenuItemClick(object sender, EventArgs e)
		{
			Database frmChild = new Database();
			frmChild.MdiParent = this;
			frmChild.Show();
			frmChild.Text += "Database #";
		}
		
		void LoginToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
	}
}
