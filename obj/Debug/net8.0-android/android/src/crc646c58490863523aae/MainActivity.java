package crc646c58490863523aae;


public class MainActivity
	extends crc6488302ad6e9e4df1a.MauiAppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("VetPet.MainActivity, VetPet", MainActivity.class, __md_methods);
	}


	public MainActivity ()
	{
		super ();
		if (getClass () == MainActivity.class) {
			mono.android.TypeManager.Activate ("VetPet.MainActivity, VetPet", "", this, new java.lang.Object[] {  });
		}
	}


	public MainActivity (int p0)
	{
		super (p0);
		if (getClass () == MainActivity.class) {
			mono.android.TypeManager.Activate ("VetPet.MainActivity, VetPet", "System.Int32, System.Private.CoreLib", this, new java.lang.Object[] { p0 });
		}
	}

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
