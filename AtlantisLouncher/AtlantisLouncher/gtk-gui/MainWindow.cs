
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.ProgressBar progressbar3;

	private global::Gtk.Button button1;

	private global::Gtk.Label label1;

	private global::Gtk.Label label2;

	private global::Gtk.Label label3;

	private global::Gtk.Label label4;

	private global::Gtk.Entry entry3;

	private global::Gtk.Entry entry2;

	private global::Gtk.Button button2;

	private global::Gtk.Button button3;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Launcher");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Resizable = false;
		this.DefaultWidth = 900;
		this.DefaultHeight = 400;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.progressbar3 = new global::Gtk.ProgressBar();
		this.progressbar3.WidthRequest = 900;
		this.progressbar3.Name = "progressbar3";
		this.fixed1.Add(this.progressbar3);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.progressbar3]));
		w1.Y = 390;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("Play");
		this.fixed1.Add(this.button1);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
		w2.X = 400;
		w2.Y = 350;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("version 0.01b");
		this.fixed1.Add(this.label1);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label1]));
		w3.X = 804;
		w3.Y = 365;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Download New Version");
		this.fixed1.Add(this.label2);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label2]));
		w4.X = 6;
		w4.Y = 364;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("E-mail :");
		this.fixed1.Add(this.label3);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label3]));
		w5.X = 12;
		w5.Y = 11;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Password :");
		this.fixed1.Add(this.label4);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label4]));
		w6.X = 12;
		w6.Y = 79;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry3 = new global::Gtk.Entry();
		this.entry3.CanFocus = true;
		this.entry3.Name = "entry3";
		this.entry3.IsEditable = true;
		this.entry3.InvisibleChar = '•';
		this.fixed1.Add(this.entry3);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry3]));
		w7.X = 6;
		w7.Y = 102;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry2 = new global::Gtk.Entry();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.Visibility = false;
		this.entry2.InvisibleChar = '•';
		this.fixed1.Add(this.entry2);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry2]));
		w8.X = 8;
		w8.Y = 38;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button2 = new global::Gtk.Button();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString("Login");
		this.fixed1.Add(this.button2);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button2]));
		w9.X = 6;
		w9.Y = 146;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button3 = new global::Gtk.Button();
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString("Register");
		this.fixed1.Add(this.button3);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button3]));
		w10.X = 88;
		w10.Y = 144;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button2.Clicked += new global::System.EventHandler(this.OnClik);
		this.button2.Entered += new global::System.EventHandler(this.OnClikReleased);
		this.button3.Clicked += new global::System.EventHandler(this.OnRegister);
		this.button3.Entered += new global::System.EventHandler(this.OnRegisterReleased);
	}
}
