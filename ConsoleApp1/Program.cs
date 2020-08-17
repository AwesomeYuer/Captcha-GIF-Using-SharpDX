namespace TestConsoleApplication
{
    using SharpDX;
    using SharpDX.Win32;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Text;
    using D2D = SharpDX.Direct2D1;
    using DWrite = SharpDX.DirectWrite;
    using WIC = SharpDX.WIC;
    using Microshaoft;
    class Program
    {
        static void Main()
        {
            byte[] gif = CaptchaGifSharpDxHelper.SaveD2DBitmap(200, 100, "难得糊涂222");
            File.WriteAllBytes(@"\test.gif", gif);
            //Util.Image(gif).Dump();
        }

        

    }


    
    
}
