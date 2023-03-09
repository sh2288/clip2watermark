# clip2watermark
> win10 shift+win+s截屏后,利用nconvert.exe读取剪贴板截屏图片,添加指定水印,再送回到剪贴板

```batch
nconvert.exe -clipboard  -overwrite -o clipboard -out png -wmflag bottom-right -wmopacity 80 -wmfile fyj888-logo.png
img2clip.exe clipboard.png
```
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
# demo
![演示图片](demo.png)