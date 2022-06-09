/*
 * Created by SharpDevelop.
 * User: Windows 10
 * Date: 07/06/2022
 * Time: 20:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Portal_LTMPT
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ProgressBar1Click(object sender, EventArgs e)
		{
			if (progressBar1.Value == 100){
				timer1.Enabled = false;
				Halaman_Utama formhome = new Halaman_Utama();
				formhome.Show();
				Hide();
			}
			else {
				progressBar1.Value += 10;
			}
		}
	}
}
