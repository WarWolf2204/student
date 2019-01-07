/*
 * Created by SharpDevelop.
 * User: duynhat
 * Date: 1/6/2019
 * Time: 2:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace bai7
{
	partial class MainForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ten = new System.Windows.Forms.TextBox();
			this.nam = new System.Windows.Forms.TextBox();
			this.que = new System.Windows.Forms.TextBox();
			this.hienthi = new System.Windows.Forms.DataGrid();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.khoa = new System.Windows.Forms.TextBox();
			this.lop = new System.Windows.Forms.TextBox();
			this.hocky = new System.Windows.Forms.TextBox();
			this.nhap = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.timnam = new System.Windows.Forms.TextBox();
			this.timkiem = new System.Windows.Forms.Button();
			this.timque = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.hienthi)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Yellow;
			this.label2.Location = new System.Drawing.Point(12, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "land";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Yellow;
			this.label3.Location = new System.Drawing.Point(12, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "year";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ten
			// 
			this.ten.Location = new System.Drawing.Point(63, 9);
			this.ten.Multiline = true;
			this.ten.Name = "ten";
			this.ten.Size = new System.Drawing.Size(127, 23);
			this.ten.TabIndex = 3;
			// 
			// nam
			// 
			this.nam.Location = new System.Drawing.Point(63, 51);
			this.nam.Multiline = true;
			this.nam.Name = "nam";
			this.nam.Size = new System.Drawing.Size(127, 23);
			this.nam.TabIndex = 4;
			// 
			// que
			// 
			this.que.Location = new System.Drawing.Point(63, 91);
			this.que.Multiline = true;
			this.que.Name = "que";
			this.que.Size = new System.Drawing.Size(127, 23);
			this.que.TabIndex = 5;
			// 
			// hienthi
			// 
			this.hienthi.DataMember = "";
			this.hienthi.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.hienthi.Location = new System.Drawing.Point(12, 170);
			this.hienthi.Name = "hienthi";
			this.hienthi.Size = new System.Drawing.Size(435, 119);
			this.hienthi.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Yellow;
			this.label4.Location = new System.Drawing.Point(280, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "semester";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Yellow;
			this.label5.Location = new System.Drawing.Point(280, 49);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "course";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Yellow;
			this.label6.Location = new System.Drawing.Point(280, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "class";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// khoa
			// 
			this.khoa.Location = new System.Drawing.Point(331, 49);
			this.khoa.Multiline = true;
			this.khoa.Name = "khoa";
			this.khoa.Size = new System.Drawing.Size(127, 23);
			this.khoa.TabIndex = 10;
			// 
			// lop
			// 
			this.lop.Location = new System.Drawing.Point(331, 9);
			this.lop.Multiline = true;
			this.lop.Name = "lop";
			this.lop.Size = new System.Drawing.Size(127, 23);
			this.lop.TabIndex = 11;
			// 
			// hocky
			// 
			this.hocky.Location = new System.Drawing.Point(341, 93);
			this.hocky.Multiline = true;
			this.hocky.Name = "hocky";
			this.hocky.Size = new System.Drawing.Size(117, 23);
			this.hocky.TabIndex = 12;
			// 
			// nhap
			// 
			this.nhap.Location = new System.Drawing.Point(49, 141);
			this.nhap.Name = "nhap";
			this.nhap.Size = new System.Drawing.Size(75, 23);
			this.nhap.TabIndex = 13;
			this.nhap.Text = "add";
			this.nhap.UseVisualStyleBackColor = true;
			this.nhap.Click += new System.EventHandler(this.NhapClick);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Yellow;
			this.label7.Location = new System.Drawing.Point(611, 51);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = "find";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timnam
			// 
			this.timnam.Location = new System.Drawing.Point(581, 91);
			this.timnam.Multiline = true;
			this.timnam.Name = "timnam";
			this.timnam.Size = new System.Drawing.Size(127, 23);
			this.timnam.TabIndex = 15;
			// 
			// timkiem
			// 
			this.timkiem.Location = new System.Drawing.Point(600, 170);
			this.timkiem.Name = "timkiem";
			this.timkiem.Size = new System.Drawing.Size(75, 23);
			this.timkiem.TabIndex = 16;
			this.timkiem.Text = "find";
			this.timkiem.UseVisualStyleBackColor = true;
			this.timkiem.Click += new System.EventHandler(this.TimkiemClick);
			// 
			// timque
			// 
			this.timque.Location = new System.Drawing.Point(581, 129);
			this.timque.Multiline = true;
			this.timque.Name = "timque";
			this.timque.Size = new System.Drawing.Size(127, 23);
			this.timque.TabIndex = 17;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Yellow;
			this.label8.Location = new System.Drawing.Point(530, 93);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 23);
			this.label8.TabIndex = 18;
			this.label8.Text = "year";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Yellow;
			this.label9.Location = new System.Drawing.Point(530, 129);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(45, 23);
			this.label9.TabIndex = 19;
			this.label9.Text = "land";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lime;
			this.ClientSize = new System.Drawing.Size(746, 301);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.timque);
			this.Controls.Add(this.timkiem);
			this.Controls.Add(this.timnam);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.nhap);
			this.Controls.Add(this.hocky);
			this.Controls.Add(this.lop);
			this.Controls.Add(this.khoa);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.hienthi);
			this.Controls.Add(this.que);
			this.Controls.Add(this.nam);
			this.Controls.Add(this.ten);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "bai7";
			((System.ComponentModel.ISupportInitialize)(this.hienthi)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox timque;
		private System.Windows.Forms.Button timkiem;
		private System.Windows.Forms.TextBox timnam;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button nhap;
		private System.Windows.Forms.TextBox hocky;
		private System.Windows.Forms.TextBox lop;
		private System.Windows.Forms.TextBox khoa;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGrid hienthi;
		private System.Windows.Forms.TextBox que;
		private System.Windows.Forms.TextBox nam;
		private System.Windows.Forms.TextBox ten;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
