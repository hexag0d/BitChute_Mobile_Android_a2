package md5496f332fa44951e501dc9bc08193a006;


public class SubsClickListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler:Android.Views.View/IOnClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("com.xamarin.example.BitChute.Activities.SubsClickListener, BitChute", SubsClickListener.class, __md_methods);
	}


	public SubsClickListener ()
	{
		super ();
		if (getClass () == SubsClickListener.class)
			mono.android.TypeManager.Activate ("com.xamarin.example.BitChute.Activities.SubsClickListener, BitChute", "", this, new java.lang.Object[] {  });
	}

	public SubsClickListener (android.widget.TabHost p0)
	{
		super ();
		if (getClass () == SubsClickListener.class)
			mono.android.TypeManager.Activate ("com.xamarin.example.BitChute.Activities.SubsClickListener, BitChute", "Android.Widget.TabHost, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}