/*
 * Created by SharpDevelop.
 * User: duynhat
 * Date: 1/6/2019
 * Time: 3:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace bai7
{
	/// <summary>
	/// Description of clsSinhvien.
	/// </summary>
	public class clsSinhvien
	{
		string iten,iquequan,inamsinh;
		int ituoi;
		public string ten
		{
			get
			{
				return iten;
			}
			set
			{
				iten = value;
			}
		}
		public string quequan
		{
			get
			{
				return iquequan;
			}
			set
			{
				iquequan = value;
			}
		}
		public string namsinh
		{
			get
			{
				return inamsinh;
			}
			set
			{
				inamsinh = value;
			}
		}
		public int tuoi
		{
			get
			{
				return ituoi = DateTime.Now.Year - int.Parse(inamsinh);
			}
		}
		public clsSinhvien()
		{
		}
	}
}
