using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class AIBGHMFLDJD : FBMNABJKMMD, BLKKNKJIPKI, PKPMIGECBKB<Entity>, IJNFIHACIMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public abstract Type EMLIJIGFNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract JKAOACKGDOB OHGMICICEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract AGCKMMLDJMF MAPOJMLOMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x7644F0", VA = "0x1807650F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NALINPCHJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7EF630", Offset = "0x7EEA30", VA = "0x1807EF630", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7EF600", Offset = "0x7EEA00", VA = "0x1807EF600", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event EIDGEBHMFOI<Entity> ILMIDAPKLBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDA10", Offset = "0x5DBCE10", VA = "0x185DBDA10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5DBDAC0", Offset = "0x5DBCEC0", VA = "0x185DBDAC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract bool NDBJGAPFHCF(Entity AHNNJNFIHFM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void KJBHHOOLCCM(Entity AHNNJNFIHFM, PAAILIGMCIN LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool FAJCEJLMNJF(Entity AHNNJNFIHFM, JGFJHAANPIB GJFJLOBMJBE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void CJBPDOLDKJH(AJBOGAKBDLF DMDOHKOAEAA, [Optional] object CNKGFJIJGPA);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool PCONDBHNLLG(Entity PFDAOEPJLFE, Entity KECAMMIJJDM);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void OMELHDOHHCI(EntityManager OKNGAOGEIDO);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x29E9370", Offset = "0x29E8770", VA = "0x1829E9370")]
	protected void DJCKDCOPLHE<T>(Entity AHNNJNFIHFM, [In] T MKKHNLNBPNM, [In] T GJFJLOBMJBE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	protected AIBGHMFLDJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[DefaultMember("Item")]
public class MKIKBAICGGB<T> : AIBGHMFLDJD, DPOCAELPMFA<T>, JIMDNDNBHNB<Entity, T>, PKPMIGECBKB<Entity>, IJNFIHACIMM, IDisposable, BLKKNKJIPKI, AGCKMMLDJMF where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate bool CLEFNKLKOHL(Entity AHNNJNFIHFM, [In] T GJFJLOBMJBE);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate void BBECECLONEC(Entity AHNNJNFIHFM, [In] T MKKHNLNBPNM, [In] T GJFJLOBMJBE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JKAOACKGDOB IHFKPAFFFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FieldInfo POFALPMCJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly int CEOOILAHGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int POBHOBNPPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int JGDHMDLNCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private CLEFNKLKOHL NDIAGMCAGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private BBECECLONEC ONNHIAGJECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BBECECLONEC LMPNOCEMBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World KMPNHHILNIL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Type EMLIJIGFNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3B76B10", Offset = "0x3B75F10", VA = "0x183B76B10", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override JKAOACKGDOB OHGMICICEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x767740", Offset = "0x766B40", VA = "0x180767740", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override AGCKMMLDJMF MAPOJMLOMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private FieldInfo LHHABCMPEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750", Slot = "30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private int OLCHMIOPMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7815C0", Offset = "0x7809C0", VA = "0x1807815C0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private int KOLNOPKFAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7731C0", Offset = "0x7725C0", VA = "0x1807731C0", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private EntityManager PHDBLFJLAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3B78B20", Offset = "0x3B77F20", VA = "0x183B78B20")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3B791D0", Offset = "0x3B785D0", VA = "0x183B791D0")]
	public MKIKBAICGGB(string DKFEAPHKBMP, JKAOACKGDOB IHFKPAFFFLO, FieldInfo POFALPMCJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3B78700", Offset = "0x3B77B00", VA = "0x183B78700", Slot = "28")]
	public override void OMELHDOHHCI(EntityManager OKNGAOGEIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3B76C90", Offset = "0x3B76090", VA = "0x183B76C90")]
	public MKIKBAICGGB<T> IOOOLHBDICA(CLEFNKLKOHL NDIAGMCAGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3B76CB0", Offset = "0x3B760B0", VA = "0x183B76CB0")]
	public MKIKBAICGGB<T> JEAFKABBFJA(BBECECLONEC ONNHIAGJECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3B785C0", Offset = "0x3B779C0", VA = "0x183B785C0")]
	public MKIKBAICGGB<T> OAKJGEDNDPC(BBECECLONEC LMPNOCEMBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3B77250", Offset = "0x3B76650", VA = "0x183B77250", Slot = "29")]
	public T KJBHHOOLCCM(Entity AHNNJNFIHFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3B75D00", Offset = "0x3B75100", VA = "0x183B75D00")]
	public bool FAJCEJLMNJF(Entity AHNNJNFIHFM, [In] T GJFJLOBMJBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B76710", Offset = "0x3B75B10", VA = "0x183B76710")]
	public bool GDABKDCFPBP(Entity AHNNJNFIHFM, [In] T GJFJLOBMJBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3B77F90", Offset = "0x3B77390", VA = "0x183B77F90", Slot = "22")]
	public override bool NDBJGAPFHCF(Entity AHNNJNFIHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3B77320", Offset = "0x3B76720", VA = "0x183B77320", Slot = "23")]
	public override void KJBHHOOLCCM(Entity AHNNJNFIHFM, PAAILIGMCIN LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3B73D50", Offset = "0x3B73150", VA = "0x183B73D50", Slot = "24")]
	public override bool FAJCEJLMNJF(Entity AHNNJNFIHFM, JGFJHAANPIB GJFJLOBMJBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3B735C0", Offset = "0x3B729C0", VA = "0x183B735C0", Slot = "25")]
	public override void CJBPDOLDKJH(AJBOGAKBDLF DMDOHKOAEAA, [Optional] object CNKGFJIJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3B78D40", Offset = "0x3B78140", VA = "0x183B78D40", Slot = "26")]
	public override bool PCONDBHNLLG(Entity PFDAOEPJLFE, Entity KECAMMIJJDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "27")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3B73560", Offset = "0x3B72960", VA = "0x183B73560")]
	private bool CEGAHNPOGGI(T MKKHNLNBPNM, T GJFJLOBMJBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BLKKNKJIPKI : PKPMIGECBKB<Entity>, IJNFIHACIMM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DPOCAELPMFA<T> : JIMDNDNBHNB<Entity, T>, PKPMIGECBKB<Entity>, IJNFIHACIMM, IDisposable, BLKKNKJIPKI where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface FBMNABJKMMD : BLKKNKJIPKI, PKPMIGECBKB<Entity>, IJNFIHACIMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int NALINPCHJCK
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DNPCABOEOEL
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x222ACA0", Offset = "0x222A0A0", VA = "0x18222ACA0")]
	public static T BDHJGONCABL<T>(this DPOCAELPMFA<T> OIBKEMMFJDM, Entity AHNNJNFIHFM, [Optional] T HBPJMDHPOKO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x222AE20", Offset = "0x222A220", VA = "0x18222AE20")]
	public static T BJNGDJMJIMK<T>(this PKPMIGECBKB<Entity> OIBKEMMFJDM, Entity AHNNJNFIHFM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x222AF40", Offset = "0x222A340", VA = "0x18222AF40")]
	public static bool PKEJFAOGFIE<T>(this PKPMIGECBKB<Entity> OIBKEMMFJDM, Entity AHNNJNFIHFM, [In] T GJFJLOBMJBE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void EIDGEBHMFOI<TKey>(TKey IBBNLILJNEB, [In] JGFJHAANPIB MKKHNLNBPNM, [In] JGFJHAANPIB GJFJLOBMJBE);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class KKNHAMJNIBI
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x242F660", Offset = "0x242EA60", VA = "0x18242F660")]
	public static void DFPIJIPLDKJ<TKey, T>(this EIDGEBHMFOI<TKey> MDNGPGHLBBO, TKey IBBNLILJNEB, T MKKHNLNBPNM, T GJFJLOBMJBE) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AJBOGAKBDLF
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JIOPANEDDHL<TKey, T>(JIMDNDNBHNB<TKey, T> OIBKEMMFJDM, [Optional] object CNKGFJIJGPA) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PGMBKPAIDGI
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AGCKMMLDJMF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo BJPLKEACDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int MICBGPINKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int NLNGCCHEOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IJNFIHACIMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string PDBKHDHIBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type EMLIJIGFNNE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	AGCKMMLDJMF MAPOJMLOMNA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JKAOACKGDOB OHGMICICEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int NALINPCHJCK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CJBPDOLDKJH(AJBOGAKBDLF DMDOHKOAEAA, [Optional] object CNKGFJIJGPA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PKPMIGECBKB<TKey> : IJNFIHACIMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event EIDGEBHMFOI<TKey> ILMIDAPKLBK;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NDBJGAPFHCF(TKey IHHOPACLNAK);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KJBHHOOLCCM(TKey IHHOPACLNAK, PAAILIGMCIN LPCGJALKADL);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FAJCEJLMNJF(TKey IHHOPACLNAK, JGFJHAANPIB GJFJLOBMJBE);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PCONDBHNLLG(TKey PFDAOEPJLFE, TKey KECAMMIJJDM);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public interface JIMDNDNBHNB<TKey, T> : PKPMIGECBKB<TKey>, IJNFIHACIMM, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T KJBHHOOLCCM(TKey IHHOPACLNAK);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HAKDMDMHGJD
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x23CD950", Offset = "0x23CCD50", VA = "0x1823CD950")]
	public static bool ICFEPCNMLOH<TKey, T>(this PKPMIGECBKB<TKey> OIBKEMMFJDM, TKey IHHOPACLNAK, [Out] T LPCGJALKADL) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x23CDB10", Offset = "0x23CCF10", VA = "0x1823CDB10")]
	public static T KJBHHOOLCCM<T, TKey>(this PKPMIGECBKB<TKey> OIBKEMMFJDM, TKey IHHOPACLNAK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x23CCF20", Offset = "0x23CC320", VA = "0x1823CCF20")]
	public static bool FAJCEJLMNJF<TKey, T>(this PKPMIGECBKB<TKey> OIBKEMMFJDM, TKey IHHOPACLNAK, T GJFJLOBMJBE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface IFBEICKPEHL : IEnumerable<BLKKNKJIPKI>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JKAOACKGDOB
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int BFNEGBLKOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int CEIKBDOPEHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type KOBCKDPBIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	BLKKNKJIPKI[] GLIHDJHBKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	(uint, uint) LNDPEHBIDBK(Entity AHNNJNFIHFM);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NJGKIPDANBB(Entity AHNNJNFIHFM, (uint order, uint change) KAHINILDCOI);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class NOODCLKDFOP : IFBEICKPEHL, IEnumerable<BLKKNKJIPKI>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<BLKKNKJIPKI> FOHONDFIMJH;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int ENJCEKMGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE070", Offset = "0x5DBD470", VA = "0x185DBE070", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BLKKNKJIPKI ICGOOEBDNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE010", Offset = "0x5DBD410", VA = "0x185DBE010", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE130", Offset = "0x5DBD530", VA = "0x185DBE130")]
	public NOODCLKDFOP(IEnumerable<JKAOACKGDOB> EIFHNCOHGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5DBDB70", Offset = "0x5DBCF70", VA = "0x185DBDB70")]
	private List<BLKKNKJIPKI> AFAPPLNCJBE(IEnumerable<JKAOACKGDOB> EIFHNCOHGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE0B0", Offset = "0x5DBD4B0", VA = "0x185DBE0B0", Slot = "4")]
	public IEnumerator<BLKKNKJIPKI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE0B0", Offset = "0x5DBD4B0", VA = "0x185DBE0B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct AMAMFBGBCKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type GHMPLAHPDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string DKFEAPHKBMP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7CF750", Offset = "0x7CEB50", VA = "0x1807CF750")]
	public AMAMFBGBCKA(Type GHMPLAHPDJK, string DKFEAPHKBMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct EMNGLKONKEK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type GHMPLAHPDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string DKFEAPHKBMP;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7CF750", Offset = "0x7CEB50", VA = "0x1807CF750")]
	public EMNGLKONKEK(Type GHMPLAHPDJK, string DKFEAPHKBMP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x303B520", Offset = "0x303A920", VA = "0x18303B520")]
	public static AMAMFBGBCKA IHACFLAEAOK(EMNGLKONKEK<T> AGIINHOJANJ)
	{
		return default(AMAMFBGBCKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum CFHKHPJDOPL
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	CreateObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DestroyObject = -3,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	BeginTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	EndTransaction = -5,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	External = -6
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FCJMKIHNMJN
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public FCJMKIHNMJN()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
