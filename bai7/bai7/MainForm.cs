/*
 * Created by SharpDevelop.
 * User: duynhat
 * Date: 1/6/2019
 * Time: 2:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
namespace bai7
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		clsQuanly quanly = new clsQuanly();
		List<clsQuanly> dssinhvien = new List<clsQuanly>();
		BindingList<clsQuanly> bindinglist;
		BindingSource source;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			bindinglist = new BindingList<clsQuanly>(dssinhvien);
			source = new BindingSource(bindinglist,null);
			hienthi.DataSource = source;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void cleardata()
		{
			ten.Text = "";
			nam.Text = "";
			que.Text = "";
			lop.Text = "";
			khoa.Text = "";
			hocky.Text = "";
			timnam.Text = "";
		}
		void NhapClick(object sender, EventArgs e)
		{
			if(ten.Text ==""|| nam.Text=="" || que.Text=="" || khoa.Text=="" || lop.Text=="" || hocky.Text=="" || ten.Text.Length >20 || nam.Text.Length !=4 || khoa.Text.Length >2 || hocky.Text.Length > 4)
			{
				cleardata();
			}
			else
			{
			quanly.ten = ten.Text;
			quanly.namsinh = nam.Text;
			quanly.quequan = que.Text;
			quanly.lop = lop.Text;
			quanly.khoa = int.Parse(khoa.Text);
			quanly.kyhoc = int.Parse(hocky.Text);
			source.Add(quanly);
			quanly = new clsQuanly();
			hienthi.Refresh();
			cleardata();
			}
		}
		
		void TimkiemClick(object sender, EventArgs e)
		{
			foreach(var element in dssinhvien)
			{
				if(element.namsinh == timnam.Text && element.quequan == timque.Text)
				{
					MessageBox.Show("(0)"+ten.Text);
					MessageBox.Show(timque.Text);
				}
				else
				{
					cleardata();
				}
			}
		}
	}
}
