using System;
using Gtk;
using AtlantisLouncher;

public partial class MainWindow : Window
{
    bool onclik, onregister;
    RegisterWindow registerWindow;
    public MainWindow() : base(WindowType.Toplevel)
    {
        Build();
        button2.Clicked += OnClik;
        button2.Released += OnClikReleased;
        button3.Clicked += OnRegister;
        button3.Released += OnRegisterReleased;
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnClik(object sender, EventArgs e)
    {
        if (!onclik)
        {
            Console.WriteLine(nameof(OnClik));
            onclik = true;
        }
    }

    protected void OnRegister(object sender, EventArgs e)
    {
        if (!onregister)
        {
            Console.WriteLine(nameof(OnRegister));
            registerWindow = new RegisterWindow();
            registerWindow.Show();
            onregister = true;
        }
    }

    protected void OnClikReleased(object sender, EventArgs e)
    {
        onclik = false;
    }

    protected void OnRegisterReleased(object sender, EventArgs e)
    {
        onregister = false;
    }
}
