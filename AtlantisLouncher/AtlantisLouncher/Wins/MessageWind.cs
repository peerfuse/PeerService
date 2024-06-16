using System;
namespace AtlantisLouncher.Wins
{
    public partial class MessageWind : Gtk.Window
    {
        string message;
        public MessageWind() :
                base(Gtk.WindowType.Toplevel)
        {
            SetDefaultSize(200, 100);
            SetPosition(Gtk.WindowPosition.Center);
            this.Build();
        }

        public void Message(string v)
        {
            label1.Text = v;
        }
    }
}
