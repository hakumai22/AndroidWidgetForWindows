namespace AWFW
{
    internal class Widget
    {
        internal IntPtr? hWnd { get; set; }
        public Widget()
        {
            hWnd = IntPtr.Zero;
        }
    }
}