using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AWFW
{
    internal class Core
    {

        internal static class UnsafeNativeMethods
        {
            [DllImport("user32.dll")]
            internal static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
            [DllImport("user32.dll", SetLastError = true)]
            internal static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        }
        internal void windowopen()
        {
            var path = @"C:\Users\coro5\source\repos\TestWindow\TestWindow\bin\Debug\net8.0-windows\TestWindow.exe";
            Process p = Process.Start(path);
            if (p.MainWindowHandle == IntPtr.Zero)
            {
                Console.WriteLine("hwnd is zero");
            }

        }
        internal void tunetemae(IntPtr hWnd)
        {
            IntPtr WinHandle = UnsafeNativeMethods.FindWindow(null, "Program Manager");
            if (WinHandle != null && hWnd != null)
            {
                UnsafeNativeMethods.SetParent(hWnd, WinHandle);
            }
        }
        internal void import()
        {

        }
        internal void get()
        {

        }
        internal void delete()
        {

        }
        internal void transwindow()
        {

        }
        internal void change()
        {

        }
        internal void processkill()
        {

        }
        internal void movewindow(int x, int y, IntPtr hwnd)
        {

        }
        internal void itiandookisasyutoku(IntPtr hwnd)
        {

        }
    }
}