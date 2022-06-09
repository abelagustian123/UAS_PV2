/*
 * Created by SharpDevelop.
 * User: Abel Agustian
 * Date: 09/06/2022
 * Time: 10:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Portal_LTMPT
{
	partial class Database
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.rataTps = new System.Windows.Forms.TextBox();
			this.kim = new System.Windows.Forms.TextBox();
			this.rataTka = new System.Windows.Forms.TextBox();
			this.bio = new System.Windows.Forms.TextBox();
			this.pk = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label19 = new System.Windows.Forms.Label();
			this.pbm = new System.Windows.Forms.TextBox();
			this.ppu = new System.Windows.Forms.TextBox();
			this.pu = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.fis = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.mat = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Insertbtn = new System.Windows.Forms.Button();
			this.Updatebtn = new System.Windows.Forms.Button();
			this.Deletebtn = new System.Windows.Forms.Button();
			this.hitungNilai = new System.Windows.Forms.Button();
			this.skorUtbk = new System.Windows.Forms.Label();
			this.nilaiUtbk = new System.Windows.Forms.TextBox();
			this.pil1 = new System.Windows.Forms.TextBox();
			this.tanggal_lahir = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.nama_peserta = new System.Windows.Forms.TextBox();
			this.nomor_peserta = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.universitas2 = new System.Windows.Forms.TextBox();
			this.universitas1 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.Label();
			this.pil2 = new System.Windows.Forms.TextBox();
			this.nisn = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(-1, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1203, 65);
			this.label1.TabIndex = 34;
			this.label1.Text = "Daftar Pilihan dan Nilai Peserta UTBK";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rataTps
			// 
			this.rataTps.Location = new System.Drawing.Point(125, 183);
			this.rataTps.Multiline = true;
			this.rataTps.Name = "rataTps";
			this.rataTps.Size = new System.Drawing.Size(88, 22);
			this.rataTps.TabIndex = 25;
			// 
			// kim
			// 
			this.kim.Cursor = System.Windows.Forms.Cursors.Hand;
			this.kim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kim.Location = new System.Drawing.Point(125, 143);
			this.kim.Multiline = true;
			this.kim.Name = "kim";
			this.kim.Size = new System.Drawing.Size(88, 22);
			this.kim.TabIndex = 18;
			// 
			// rataTka
			// 
			this.rataTka.Location = new System.Drawing.Point(125, 184);
			this.rataTka.Multiline = true;
			this.rataTka.Name = "rataTka";
			this.rataTka.Size = new System.Drawing.Size(88, 22);
			this.rataTka.TabIndex = 19;
			// 
			// bio
			// 
			this.bio.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bio.Location = new System.Drawing.Point(125, 105);
			this.bio.Multiline = true;
			this.bio.Name = "bio";
			this.bio.Size = new System.Drawing.Size(88, 22);
			this.bio.TabIndex = 17;
			// 
			// pk
			// 
			this.pk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pk.Location = new System.Drawing.Point(125, 69);
			this.pk.Multiline = true;
			this.pk.Name = "pk";
			this.pk.Size = new System.Drawing.Size(88, 22);
			this.pk.TabIndex = 22;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rataTps);
			this.groupBox2.Controls.Add(this.pk);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.pbm);
			this.groupBox2.Controls.Add(this.ppu);
			this.groupBox2.Controls.Add(this.pu);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(755, 185);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(240, 221);
			this.groupBox2.TabIndex = 52;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "TPS";
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(17, 183);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(102, 23);
			this.label19.TabIndex = 27;
			this.label19.Text = "Rata-Rata";
			// 
			// pbm
			// 
			this.pbm.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pbm.Location = new System.Drawing.Point(125, 105);
			this.pbm.Multiline = true;
			this.pbm.Name = "pbm";
			this.pbm.Size = new System.Drawing.Size(88, 22);
			this.pbm.TabIndex = 23;
			// 
			// ppu
			// 
			this.ppu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ppu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ppu.Location = new System.Drawing.Point(125, 142);
			this.ppu.Multiline = true;
			this.ppu.Name = "ppu";
			this.ppu.Size = new System.Drawing.Size(88, 22);
			this.ppu.TabIndex = 24;
			// 
			// pu
			// 
			this.pu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pu.Location = new System.Drawing.Point(125, 33);
			this.pu.Multiline = true;
			this.pu.Name = "pu";
			this.pu.Size = new System.Drawing.Size(88, 22);
			this.pu.TabIndex = 21;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(17, 105);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(102, 23);
			this.label12.TabIndex = 22;
			this.label12.Text = "PBM";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(17, 142);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(102, 23);
			this.label13.TabIndex = 21;
			this.label13.Text = "PPU";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(17, 69);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(102, 23);
			this.label14.TabIndex = 20;
			this.label14.Text = "PK";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(17, 32);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(102, 23);
			this.label15.TabIndex = 19;
			this.label15.Text = "PU";
			// 
			// fis
			// 
			this.fis.Cursor = System.Windows.Forms.Cursors.Hand;
			this.fis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fis.Location = new System.Drawing.Point(125, 70);
			this.fis.Multiline = true;
			this.fis.Name = "fis";
			this.fis.Size = new System.Drawing.Size(88, 22);
			this.fis.TabIndex = 16;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox1.Controls.Add(this.kim);
			this.groupBox1.Controls.Add(this.rataTka);
			this.groupBox1.Controls.Add(this.bio);
			this.groupBox1.Controls.Add(this.fis);
			this.groupBox1.Controls.Add(this.mat);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(498, 185);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(240, 221);
			this.groupBox1.TabIndex = 48;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "TKA";
			// 
			// mat
			// 
			this.mat.Cursor = System.Windows.Forms.Cursors.Hand;
			this.mat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mat.Location = new System.Drawing.Point(125, 33);
			this.mat.Multiline = true;
			this.mat.Name = "mat";
			this.mat.Size = new System.Drawing.Size(88, 22);
			this.mat.TabIndex = 15;
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(17, 184);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(102, 23);
			this.label17.TabIndex = 26;
			this.label17.Text = "Rata-Rata";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(17, 105);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(102, 23);
			this.label11.TabIndex = 22;
			this.label11.Text = "Biologi";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(17, 142);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(102, 23);
			this.label10.TabIndex = 21;
			this.label10.Text = "Kimia";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(17, 69);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(102, 23);
			this.label9.TabIndex = 20;
			this.label9.Text = "Fisika";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(17, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(102, 23);
			this.label8.TabIndex = 19;
			this.label8.Text = "Matematika";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.Insertbtn);
			this.panel1.Controls.Add(this.Updatebtn);
			this.panel1.Controls.Add(this.Deletebtn);
			this.panel1.Location = new System.Drawing.Point(1047, 201);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(108, 200);
			this.panel1.TabIndex = 57;
			// 
			// Insertbtn
			// 
			this.Insertbtn.BackColor = System.Drawing.Color.Blue;
			this.Insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Insertbtn.ForeColor = System.Drawing.Color.White;
			this.Insertbtn.Location = new System.Drawing.Point(7, 4);
			this.Insertbtn.Name = "Insertbtn";
			this.Insertbtn.Size = new System.Drawing.Size(91, 58);
			this.Insertbtn.TabIndex = 28;
			this.Insertbtn.Text = "Insert";
			this.Insertbtn.UseVisualStyleBackColor = false;
			this.Insertbtn.Click += new System.EventHandler(this.InsertbtnClick);
			// 
			// Updatebtn
			// 
			this.Updatebtn.BackColor = System.Drawing.Color.Lime;
			this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Updatebtn.ForeColor = System.Drawing.Color.White;
			this.Updatebtn.Location = new System.Drawing.Point(7, 70);
			this.Updatebtn.Name = "Updatebtn";
			this.Updatebtn.Size = new System.Drawing.Size(91, 58);
			this.Updatebtn.TabIndex = 29;
			this.Updatebtn.Text = "Update";
			this.Updatebtn.UseVisualStyleBackColor = false;
			this.Updatebtn.Click += new System.EventHandler(this.UpdatebtnClick);
			// 
			// Deletebtn
			// 
			this.Deletebtn.BackColor = System.Drawing.Color.Red;
			this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Deletebtn.ForeColor = System.Drawing.Color.White;
			this.Deletebtn.Location = new System.Drawing.Point(7, 134);
			this.Deletebtn.Name = "Deletebtn";
			this.Deletebtn.Size = new System.Drawing.Size(91, 58);
			this.Deletebtn.TabIndex = 30;
			this.Deletebtn.Text = "Delete";
			this.Deletebtn.UseVisualStyleBackColor = false;
			this.Deletebtn.Click += new System.EventHandler(this.DeletebtnClick);
			// 
			// hitungNilai
			// 
			this.hitungNilai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.hitungNilai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hitungNilai.Location = new System.Drawing.Point(838, 424);
			this.hitungNilai.Name = "hitungNilai";
			this.hitungNilai.Size = new System.Drawing.Size(105, 58);
			this.hitungNilai.TabIndex = 55;
			this.hitungNilai.Text = "Hitung Skor";
			this.hitungNilai.UseVisualStyleBackColor = false;
			this.hitungNilai.Click += new System.EventHandler(this.HitungNilaiClick);
			// 
			// skorUtbk
			// 
			this.skorUtbk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.skorUtbk.Location = new System.Drawing.Point(493, 439);
			this.skorUtbk.Name = "skorUtbk";
			this.skorUtbk.Size = new System.Drawing.Size(130, 32);
			this.skorUtbk.TabIndex = 53;
			this.skorUtbk.Text = "Skor UTBK";
			// 
			// nilaiUtbk
			// 
			this.nilaiUtbk.Location = new System.Drawing.Point(629, 439);
			this.nilaiUtbk.Multiline = true;
			this.nilaiUtbk.Name = "nilaiUtbk";
			this.nilaiUtbk.Size = new System.Drawing.Size(156, 28);
			this.nilaiUtbk.TabIndex = 54;
			// 
			// pil1
			// 
			this.pil1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pil1.Location = new System.Drawing.Point(227, 385);
			this.pil1.Name = "pil1";
			this.pil1.Size = new System.Drawing.Size(226, 22);
			this.pil1.TabIndex = 45;
			// 
			// tanggal_lahir
			// 
			this.tanggal_lahir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tanggal_lahir.Location = new System.Drawing.Point(227, 251);
			this.tanggal_lahir.Name = "tanggal_lahir";
			this.tanggal_lahir.Size = new System.Drawing.Size(226, 22);
			this.tanggal_lahir.TabIndex = 42;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(55, 549);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1100, 250);
			this.dataGridView1.TabIndex = 56;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// nama_peserta
			// 
			this.nama_peserta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.nama_peserta.Location = new System.Drawing.Point(227, 205);
			this.nama_peserta.Name = "nama_peserta";
			this.nama_peserta.Size = new System.Drawing.Size(226, 22);
			this.nama_peserta.TabIndex = 41;
			// 
			// nomor_peserta
			// 
			this.nomor_peserta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.nomor_peserta.Location = new System.Drawing.Point(227, 160);
			this.nomor_peserta.Name = "nomor_peserta";
			this.nomor_peserta.Size = new System.Drawing.Size(226, 22);
			this.nomor_peserta.TabIndex = 40;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(55, 383);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(154, 23);
			this.label6.TabIndex = 39;
			this.label6.Text = "Pilihan 1";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(55, 296);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(154, 23);
			this.label5.TabIndex = 38;
			this.label5.Text = "NISN";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(55, 250);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(154, 23);
			this.label4.TabIndex = 37;
			this.label4.Text = "Tanggal Lahir";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(55, 204);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 23);
			this.label3.TabIndex = 36;
			this.label3.Text = "Nama Peserta";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(55, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 23);
			this.label2.TabIndex = 35;
			this.label2.Text = "Nomor Peserta";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(335, 83);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(518, 31);
			this.textBox1.TabIndex = 58;
			this.textBox1.Text = "Keyword : [Nomor Peserta] [Nama Peserta]";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// universitas2
			// 
			this.universitas2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.universitas2.Location = new System.Drawing.Point(227, 449);
			this.universitas2.Name = "universitas2";
			this.universitas2.Size = new System.Drawing.Size(226, 22);
			this.universitas2.TabIndex = 46;
			// 
			// universitas1
			// 
			this.universitas1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.universitas1.Location = new System.Drawing.Point(227, 348);
			this.universitas1.Name = "universitas1";
			this.universitas1.Size = new System.Drawing.Size(226, 22);
			this.universitas1.TabIndex = 44;
			// 
			// textBox7
			// 
			this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox7.ForeColor = System.Drawing.Color.Blue;
			this.textBox7.Location = new System.Drawing.Point(55, 447);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(154, 23);
			this.textBox7.TabIndex = 51;
			this.textBox7.Text = "Universitas";
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox6.ForeColor = System.Drawing.Color.Blue;
			this.textBox6.Location = new System.Drawing.Point(55, 348);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(154, 23);
			this.textBox6.TabIndex = 50;
			this.textBox6.Text = "Universitas";
			// 
			// pil2
			// 
			this.pil2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pil2.Location = new System.Drawing.Point(227, 486);
			this.pil2.Name = "pil2";
			this.pil2.Size = new System.Drawing.Size(226, 22);
			this.pil2.TabIndex = 47;
			// 
			// nisn
			// 
			this.nisn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.nisn.Location = new System.Drawing.Point(227, 298);
			this.nisn.Name = "nisn";
			this.nisn.Size = new System.Drawing.Size(226, 22);
			this.nisn.TabIndex = 43;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Blue;
			this.label7.Location = new System.Drawing.Point(55, 486);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(154, 23);
			this.label7.TabIndex = 49;
			this.label7.Text = "Pilihan 2";
			// 
			// Database
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1201, 815);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.hitungNilai);
			this.Controls.Add(this.skorUtbk);
			this.Controls.Add(this.nilaiUtbk);
			this.Controls.Add(this.pil1);
			this.Controls.Add(this.tanggal_lahir);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.nama_peserta);
			this.Controls.Add(this.nomor_peserta);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.universitas2);
			this.Controls.Add(this.universitas1);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.pil2);
			this.Controls.Add(this.nisn);
			this.Controls.Add(this.label7);
			this.Name = "Database";
			this.Text = "Database";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox nisn;
		private System.Windows.Forms.TextBox pil2;
		private System.Windows.Forms.Label textBox6;
		private System.Windows.Forms.Label textBox7;
		private System.Windows.Forms.TextBox universitas1;
		private System.Windows.Forms.TextBox universitas2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox nomor_peserta;
		private System.Windows.Forms.TextBox nama_peserta;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox tanggal_lahir;
		private System.Windows.Forms.TextBox pil1;
		private System.Windows.Forms.TextBox nilaiUtbk;
		private System.Windows.Forms.Label skorUtbk;
		private System.Windows.Forms.Button hitungNilai;
		private System.Windows.Forms.Button Deletebtn;
		private System.Windows.Forms.Button Updatebtn;
		private System.Windows.Forms.Button Insertbtn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox mat;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox fis;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox pu;
		private System.Windows.Forms.TextBox ppu;
		private System.Windows.Forms.TextBox pbm;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox pk;
		private System.Windows.Forms.TextBox bio;
		private System.Windows.Forms.TextBox rataTka;
		private System.Windows.Forms.TextBox kim;
		private System.Windows.Forms.TextBox rataTps;
		private System.Windows.Forms.Label label1;
	}
}
