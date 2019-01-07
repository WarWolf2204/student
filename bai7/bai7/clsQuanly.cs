/*
 * Created by SharpDevelop.
 * User: duynhat
 * Date: 1/6/2019
 * Time: 3:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace bai7
{
	/// <summary>
	/// Description of clsQuanly.
	/// </summary>
	public class clsQuanly : clsSinhvien
	{
		string ilop;
		int ikhoa,ikyhoc;
		public string lop
		{
			get
			{
				return ilop;
			}
			set
			{
				ilop = value;
			}
		}
		public int khoa
		{
			get
			{
				return ikhoa;
			}
			set
			{
				ikhoa = value;
			}
		}
		public int kyhoc
		{
			get
			{
				return ikyhoc;
			}
			set
			{
				ikyhoc  = value;
			}
		}
		public clsQuanly()
		{
		}
	}
}
