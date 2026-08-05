using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class OCJMFNHNMBF<TContainer, TField> : ENGMFFHEMEF<TField> where TContainer : struct, IBufferElementData where TField : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x38530C0", Offset = "0x3851AC0", VA = "0x1838530C0")]
	public OCJMFNHNMBF(string CCMEKJGADHN, PJGKANHGJJO BDGKMFGNNGD, FieldInfo BADFPIAGDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x45F8BC0", Offset = "0x45F75C0", VA = "0x1845F8BC0", Slot = "25")]
	public override bool BJDAAADFLKD(Entity INJBCGOEBHC, HHDNMKIADAH JHNCHHHEDDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class GMBDFPBIEGA<T> : ENGMFFHEMEF<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x38530C0", Offset = "0x3851AC0", VA = "0x1838530C0")]
	public GMBDFPBIEGA(string CCMEKJGADHN, PJGKANHGJJO BDGKMFGNNGD, FieldInfo BADFPIAGDIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public abstract class ENGMFFHEMEF<T> : POMHCEHLPHB, GLEBLCGIIHH<T>, PNHKMJJBEPJ<Entity, T>, FEBPCDAKPKJ<Entity>, KGAIHEGCMCF, IDisposable, OCLDNFFAGFE, KKALDBEKJGJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate bool PIICEBAMJEN(Entity INJBCGOEBHC, [In] T JHNCHHHEDDG);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void EIBOEPMACFL(Entity INJBCGOEBHC, [In] T CIJLPDDPPNH, [In] T JHNCHHHEDDG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PJGKANHGJJO BDGKMFGNNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly FieldInfo BADFPIAGDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected readonly int NCLOOEMMHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	protected readonly int LJEHDHLGGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int BKEGNEKBPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private PIICEBAMJEN LNGEIILJDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private EIBOEPMACFL IJAADIPEBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private EIBOEPMACFL LEHOMIGGDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private World LHKJIBFFKNG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type PNFBJLDEHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3876E50", Offset = "0x3875850", VA = "0x183876E50", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override PJGKANHGJJO HJANGGPDIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84EC50", Offset = "0x84D650", VA = "0x18084EC50", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override KKALDBEKJGJ JAJGBNBFOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo LEBJANOCEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int KANGDENMNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86AB90", Offset = "0x869590", VA = "0x18086AB90", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int FLNIEDILDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85C460", Offset = "0x85AE60", VA = "0x18085C460", Slot = "34")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager DJLCCPNJBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3876890", Offset = "0x3875290", VA = "0x183876890")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3877CB0", Offset = "0x38766B0", VA = "0x183877CB0")]
	internal ENGMFFHEMEF(string CCMEKJGADHN, PJGKANHGJJO BDGKMFGNNGD, FieldInfo BADFPIAGDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3875430", Offset = "0x3873E30", VA = "0x183875430", Slot = "29")]
	public override void CCPNKNOIBEC(EntityManager NFHPCHOLBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3876F80", Offset = "0x3875980", VA = "0x183876F80")]
	public ENGMFFHEMEF<T> IFHNPGIMNBE(PIICEBAMJEN LNGEIILJDCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x386F1E0", Offset = "0x386DBE0", VA = "0x18386F1E0")]
	public ENGMFFHEMEF<T> AMCJEAHGLHG(EIBOEPMACFL IJAADIPEBLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3876F10", Offset = "0x3875910", VA = "0x183876F10")]
	public ENGMFFHEMEF<T> GNAJPFGAEOI(EIBOEPMACFL LEHOMIGGDIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x386F5A0", Offset = "0x386DFA0", VA = "0x18386F5A0", Slot = "31")]
	public T AMGKFNFCLFC(Entity INJBCGOEBHC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3874A40", Offset = "0x3873440", VA = "0x183874A40")]
	public bool BJDAAADFLKD(Entity INJBCGOEBHC, [In] T JHNCHHHEDDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3876F30", Offset = "0x3875930", VA = "0x183876F30")]
	public bool HODBGLMNBHE(Entity INJBCGOEBHC, [In] T JHNCHHHEDDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3875EE0", Offset = "0x38748E0", VA = "0x183875EE0", Slot = "23")]
	public override bool DBBOGLGLBCM(Entity INJBCGOEBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x386F4A0", Offset = "0x386DEA0", VA = "0x18386F4A0", Slot = "24")]
	public override void AMGKFNFCLFC(Entity INJBCGOEBHC, GCPLBGGDBJP DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x38731A0", Offset = "0x3871BA0", VA = "0x1838731A0", Slot = "25")]
	public override bool BJDAAADFLKD(Entity INJBCGOEBHC, HHDNMKIADAH JHNCHHHEDDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3870750", Offset = "0x386F150", VA = "0x183870750", Slot = "26")]
	public override void AMJOKABJFMM(MEFHNEKLOMI PJHIIMOCAJF, [Optional] object NIDJKNBFFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x38778C0", Offset = "0x38762C0", VA = "0x1838778C0", Slot = "27")]
	public override bool KHMOMCMPNHI(Entity JEDBDINPIII, Entity PPJABDMHAEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "28")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3876660", Offset = "0x3875060", VA = "0x183876660", Slot = "30")]
	public override string DBFCKNEJGCG([In] HHDNMKIADAH ACKPLIGKNCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3876FA0", Offset = "0x38759A0", VA = "0x183876FA0")]
	private bool KGOKJGAEDPI(T CIJLPDDPPNH, T JHNCHHHEDDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class POMHCEHLPHB : DHOKDDJKILA, OCLDNFFAGFE, FEBPCDAKPKJ<Entity>, KGAIHEGCMCF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract Type PNFBJLDEHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract PJGKANHGJJO HJANGGPDIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public abstract KKALDBEKJGJ JAJGBNBFOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string JGFOABOCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84EC00", Offset = "0x84D600", VA = "0x18084EC00")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MKKMBLFCCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3B0", Offset = "0x8B8DB0", VA = "0x1808BA3B0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8BA990", Offset = "0x8B9390", VA = "0x1808BA990", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event MFAAOBNCNIO<Entity> NGJPKCFKOHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x68D43D0", Offset = "0x68D2DD0", VA = "0x1868D43D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68D4320", Offset = "0x68D2D20", VA = "0x1868D4320", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract bool DBBOGLGLBCM(Entity INJBCGOEBHC);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract void AMGKFNFCLFC(Entity INJBCGOEBHC, GCPLBGGDBJP DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract bool BJDAAADFLKD(Entity INJBCGOEBHC, HHDNMKIADAH JHNCHHHEDDG);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void AMJOKABJFMM(MEFHNEKLOMI PJHIIMOCAJF, [Optional] object NIDJKNBFFJH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract bool KHMOMCMPNHI(Entity JEDBDINPIII, Entity PPJABDMHAEE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void CCPNKNOIBEC(EntityManager NFHPCHOLBII);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8850", Offset = "0x2CF7250", VA = "0x182CF8850")]
	protected void GOJMGHCOCAN<T>(Entity INJBCGOEBHC, [In] T CIJLPDDPPNH, [In] T JHNCHHHEDDG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract string DBFCKNEJGCG([In] HHDNMKIADAH ACKPLIGKNCJ);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	protected POMHCEHLPHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OCLDNFFAGFE : FEBPCDAKPKJ<Entity>, KGAIHEGCMCF, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GLEBLCGIIHH<T> : PNHKMJJBEPJ<Entity, T>, FEBPCDAKPKJ<Entity>, KGAIHEGCMCF, IDisposable, OCLDNFFAGFE where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface DHOKDDJKILA : OCLDNFFAGFE, FEBPCDAKPKJ<Entity>, KGAIHEGCMCF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int MKKMBLFCCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EIMIMECCPDH
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x29B3460", Offset = "0x29B1E60", VA = "0x1829B3460")]
	public static T HHOCJKJBOAE<T>(this GLEBLCGIIHH<T> DDHAIBOKNCF, Entity INJBCGOEBHC, [Optional] T JIEGAHKKHCA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x29B3850", Offset = "0x29B2250", VA = "0x1829B3850")]
	public static T OGMPHPCIBNO<T>(this FEBPCDAKPKJ<Entity> DDHAIBOKNCF, Entity INJBCGOEBHC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x29B36C0", Offset = "0x29B20C0", VA = "0x1829B36C0")]
	public static bool JGAEDOBGECC<T>(this FEBPCDAKPKJ<Entity> DDHAIBOKNCF, Entity INJBCGOEBHC, [In] T JHNCHHHEDDG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x29B3620", Offset = "0x29B2020", VA = "0x1829B3620")]
	public static bool JGAEDOBGECC<T>(this FEBPCDAKPKJ<Entity> DDHAIBOKNCF, Entity INJBCGOEBHC, NativeArray<T> JHNCHHHEDDG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void MFAAOBNCNIO<TKey>(TKey GKHPLGCJCPF, [In] HHDNMKIADAH CIJLPDDPPNH, [In] HHDNMKIADAH JHNCHHHEDDG);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PPHIABDDIEM
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2CF92B0", Offset = "0x2CF7CB0", VA = "0x182CF92B0")]
	public static void EDIAJIJOMBB<TKey, T>(this MFAAOBNCNIO<TKey> MGAAFIBOMHF, TKey GKHPLGCJCPF, T CIJLPDDPPNH, T JHNCHHHEDDG) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MEFHNEKLOMI
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJBNILJGJCG<TKey, T>(PNHKMJJBEPJ<TKey, T> DDHAIBOKNCF, [Optional] object NIDJKNBFFJH) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IAGMBKIBPHP
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KKALDBEKJGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo HKOCEMINEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int DMLMLBJLCEP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int DLJBGHKKEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KGAIHEGCMCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string JGFOABOCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type PNFBJLDEHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	KKALDBEKJGJ JAJGBNBFOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	PJGKANHGJJO HJANGGPDIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int MKKMBLFCCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AMJOKABJFMM(MEFHNEKLOMI PJHIIMOCAJF, [Optional] object NIDJKNBFFJH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FEBPCDAKPKJ<TKey> : KGAIHEGCMCF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event MFAAOBNCNIO<TKey> NGJPKCFKOHN;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DBBOGLGLBCM(TKey LDDEKIBHION);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AMGKFNFCLFC(TKey LDDEKIBHION, GCPLBGGDBJP DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BJDAAADFLKD(TKey LDDEKIBHION, HHDNMKIADAH JHNCHHHEDDG);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KHMOMCMPNHI(TKey JEDBDINPIII, TKey PPJABDMHAEE);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string DBFCKNEJGCG([In] HHDNMKIADAH DBOBEHLEAAE);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface PNHKMJJBEPJ<TKey, T> : FEBPCDAKPKJ<TKey>, KGAIHEGCMCF, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T AMGKFNFCLFC(TKey LDDEKIBHION);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class NLHMODLGGCA
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2C81BD0", Offset = "0x2C805D0", VA = "0x182C81BD0")]
	public static bool GBFLHMLGFGE<TKey, T>(this FEBPCDAKPKJ<TKey> DDHAIBOKNCF, TKey LDDEKIBHION, [Out] T DBOBEHLEAAE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2C808B0", Offset = "0x2C7F2B0", VA = "0x182C808B0")]
	public static T AMGKFNFCLFC<T, TKey>(this FEBPCDAKPKJ<TKey> DDHAIBOKNCF, TKey LDDEKIBHION) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2C81380", Offset = "0x2C7FD80", VA = "0x182C81380")]
	public static bool BJDAAADFLKD<TKey, T>(this FEBPCDAKPKJ<TKey> DDHAIBOKNCF, TKey LDDEKIBHION, T JHNCHHHEDDG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2C814B0", Offset = "0x2C7FEB0", VA = "0x182C814B0")]
	public static bool BJDAAADFLKD<TKey, T>(this FEBPCDAKPKJ<TKey> DDHAIBOKNCF, TKey LDDEKIBHION, NativeArray<T> JHNCHHHEDDG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public interface AILGCLLILJP : IEnumerable<OCLDNFFAGFE>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PJGKANHGJJO
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int AKCDACPLHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int HCFEBPAOKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type GGGODIOMJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	OCLDNFFAGFE[] OKAOJGDIKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool JMOPGEMLDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	(uint, uint) NLGNMECLJIG(Entity INJBCGOEBHC);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PPEIDECLMGL(Entity INJBCGOEBHC, (uint order, uint change) OKMBFDMPMHM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class EADOELILBNB : AILGCLLILJP, IEnumerable<OCLDNFFAGFE>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<OCLDNFFAGFE> PMNCLGACONO;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int BGDNEMFMALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x68D3D30", Offset = "0x68D2730", VA = "0x1868D3D30", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public OCLDNFFAGFE PBAJKHBLIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68D3D70", Offset = "0x68D2770", VA = "0x1868D3D70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x68D42E0", Offset = "0x68D2CE0", VA = "0x1868D42E0")]
	public EADOELILBNB(IEnumerable<PJGKANHGJJO> FOBBHENKKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x68D3DD0", Offset = "0x68D27D0", VA = "0x1868D3DD0")]
	private List<OCLDNFFAGFE> GEMEPOILJJA(IEnumerable<PJGKANHGJJO> FOBBHENKKEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x68D4260", Offset = "0x68D2C60", VA = "0x1868D4260", Slot = "4")]
	public IEnumerator<OCLDNFFAGFE> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68D4260", Offset = "0x68D2C60", VA = "0x1868D4260", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GPFGGCIPDEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type FEOPNPJBIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string CCMEKJGADHN;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xAA6F80", Offset = "0xAA5980", VA = "0x180AA6F80")]
	public GPFGGCIPDEK(Type FEOPNPJBIPI, string CCMEKJGADHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct AIDENNNABKN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type FEOPNPJBIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string CCMEKJGADHN;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xAA6F80", Offset = "0xAA5980", VA = "0x180AA6F80")]
	public AIDENNNABKN(Type FEOPNPJBIPI, string CCMEKJGADHN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6730", Offset = "0x3CE5130", VA = "0x183CE6730")]
	public static GPFGGCIPDEK EAJIBILEJNC(AIDENNNABKN<T> DJFBMOCHJDO)
	{
		return default(GPFGGCIPDEK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum FEBOHBEINAF
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
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GGKFJPNBAIC
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public GGKFJPNBAIC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
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
