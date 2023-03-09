# 📣 clip2watermark 剪贴板加水印logo工具
# 🔎 原理
> win10 shift+win+s截屏后,利用nconvert.exe读取剪贴板截屏图片,添加指定水印,再送回到剪贴板
# 🌈 使用场景
制作各种计算机技术教程,需要一边截屏一边写博客或文档,又渴望加入自己水印logo的大神们
# 🈯 使用方法 
1. 截屏到剪贴板
2. 运行clip2watermark.bat
3. 粘贴 (粘贴后的即为加好水印logo的图片)
# 🛠 命令批处理
```batch
nconvert.exe -clipboard  -overwrite -o clipboard -out png -wmflag bottom-right -wmopacity 80 -wmfile fyj888-logo.png
img2clip.exe clipboard.png
```
# ⌨️ 一行源码(程序虽然简单,但能给你带来方便)
```c#
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
			if (args.Length != 0) {
				Image img = Image.FromFile(args[0]);
				Clipboard.SetImage(img);
			}
		}
	}
}
```
# 🎙️ demo
![演示图片](demo.png)