using System;
namespace AtlantisLouncher
{
    public partial class RegisterWindow : Gtk.Window
    {
        public RegisterWindow() :base(Gtk.WindowType.Toplevel)
        {
            SetDefaultSize(200, 150);
            Build();
        }
    }
}
