package md5156d7e7d27d646419aa6e56ad1355ef9;


public class CustomTabbedPage
	extends md58432a647068b097f9637064b8985a5e0.TabbedPageRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLayout:(ZIIII)V:GetOnLayout_ZIIIIHandler\n" +
			"";
		mono.android.Runtime.register ("TuxiTickets.Droid.Controls.CustomTabbedPage, TuxiTickets.Android", CustomTabbedPage.class, __md_methods);
	}


	public CustomTabbedPage (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CustomTabbedPage.class)
			mono.android.TypeManager.Activate ("TuxiTickets.Droid.Controls.CustomTabbedPage, TuxiTickets.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CustomTabbedPage (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CustomTabbedPage.class)
			mono.android.TypeManager.Activate ("TuxiTickets.Droid.Controls.CustomTabbedPage, TuxiTickets.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CustomTabbedPage (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CustomTabbedPage.class)
			mono.android.TypeManager.Activate ("TuxiTickets.Droid.Controls.CustomTabbedPage, TuxiTickets.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void onLayout (boolean p0, int p1, int p2, int p3, int p4)
	{
		n_onLayout (p0, p1, p2, p3, p4);
	}

	private native void n_onLayout (boolean p0, int p1, int p2, int p3, int p4);

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