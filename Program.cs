/*
 * 由SharpDevelop创建。
 * 用户： sh2288
 * 日期: 2022/11/9
 * 时间: 16:47
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;
namespace png2clip2
{
	class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			if (args.Length != 0) 
			{
				Image img = Image.FromFile(args[0]);
				Clipboard.SetImage(img);
			}
		
		}
	}
}