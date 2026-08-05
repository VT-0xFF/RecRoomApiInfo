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
public sealed class LGLEGGPHOJF<TContainer, TField> : AAGDGMACBON<TField> where TContainer : struct, IBufferElementData where TField : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x42ECB50", Offset = "0x42EB550", VA = "0x1842ECB50")]
	public LGLEGGPHOJF(string DDDMPLCOGIM, PLLLIFEAPFO LKDGGBDDBJM, FieldInfo BGOCDBNPFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x448C500", Offset = "0x448AF00", VA = "0x18448C500", Slot = "26")]
	public override bool ODIPBPJKHHK(Entity AFNIOPPCKNG, LJBEBGPAIAD HELFJHKDFKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x448C2A0", Offset = "0x448ACA0", VA = "0x18448C2A0", Slot = "32")]
	public override JFFFCDBCMIK LPGDFBGHDCG(EntityManager HKBPDABAGBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class NGALIDMCNNE<T> : AAGDGMACBON<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x42ECB50", Offset = "0x42EB550", VA = "0x1842ECB50")]
	public NGALIDMCNNE(string DDDMPLCOGIM, PLLLIFEAPFO LKDGGBDDBJM, FieldInfo BGOCDBNPFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x47A4000", Offset = "0x47A2A00", VA = "0x1847A4000", Slot = "32")]
	public override JFFFCDBCMIK LPGDFBGHDCG(EntityManager HKBPDABAGBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public abstract class AAGDGMACBON<T> : ACBDGFKGODC, CHCJAGKHKAI<T>, GBFJLHKCFEF<Entity, T>, OBCALFIHPEE<Entity>, ABECDDJBCHC, IDisposable, JFFFCDBCMIK, NIEENGPADOA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate bool FJBOHLHMJKC(Entity AFNIOPPCKNG, [In] T HELFJHKDFKA);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void MHMIDFNMDCJ(Entity AFNIOPPCKNG, [In] T OFGFIAGNBIM, [In] T HELFJHKDFKA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PLLLIFEAPFO LKDGGBDDBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	protected readonly FieldInfo BGOCDBNPFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly int DFOHIMDHCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int EDCGGCHLNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int ECFPAOHDFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private FJBOHLHMJKC FLKFAJLPIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private MHMIDFNMDCJ OODMONFMJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private MHMIDFNMDCJ PFIHJNNAKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private World OBOIAEHHCBI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type GPKIFFDGPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3E54250", Offset = "0x3E52C50", VA = "0x183E54250", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override PLLLIFEAPFO BDKFKIGCKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override NIEENGPADOA KDGEKKBLABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo HCBCCIIIJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int JFDPFAGKPFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A2150", Offset = "0x8A0B50", VA = "0x1808A2150", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int DPGLDOLAPKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x893070", Offset = "0x891A70", VA = "0x180893070", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager NIPEMELLCKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3E555F0", Offset = "0x3E53FF0", VA = "0x183E555F0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3E574C0", Offset = "0x3E55EC0", VA = "0x183E574C0")]
	internal AAGDGMACBON(string DDDMPLCOGIM, PLLLIFEAPFO LKDGGBDDBJM, FieldInfo BGOCDBNPFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3E553C0", Offset = "0x3E53DC0", VA = "0x183E553C0", Slot = "30")]
	public override void HINDDHMAHAN(EntityManager JONCEOFPEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3E55AA0", Offset = "0x3E544A0", VA = "0x183E55AA0")]
	public AAGDGMACBON<T> NNLLAEOENCC(FJBOHLHMJKC FLKFAJLPIJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3E55A80", Offset = "0x3E54480", VA = "0x183E55A80")]
	public AAGDGMACBON<T> MOEHFDOFIGI(MHMIDFNMDCJ OODMONFMJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3E543D0", Offset = "0x3E52DD0", VA = "0x183E543D0")]
	public AAGDGMACBON<T> EJMLOKFHDIN(MHMIDFNMDCJ PFIHJNNAKNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3E54EF0", Offset = "0x3E538F0", VA = "0x183E54EF0", Slot = "33")]
	public T GJMIFHLLDMF(Entity AFNIOPPCKNG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3E55AC0", Offset = "0x3E544C0", VA = "0x183E55AC0")]
	public bool ODIPBPJKHHK(Entity AFNIOPPCKNG, [In] T HELFJHKDFKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3E555A0", Offset = "0x3E53FA0", VA = "0x183E555A0")]
	public bool HOCCHAOAPEB(Entity AFNIOPPCKNG, [In] T HELFJHKDFKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3E54940", Offset = "0x3E53340", VA = "0x183E54940", Slot = "24")]
	public override bool GHBEHEKGDOG(Entity AFNIOPPCKNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3E54E60", Offset = "0x3E53860", VA = "0x183E54E60", Slot = "25")]
	public override void GJMIFHLLDMF(Entity AFNIOPPCKNG, LHLKFGKGHKF IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3E56B30", Offset = "0x3E55530", VA = "0x183E56B30", Slot = "26")]
	public override bool ODIPBPJKHHK(Entity AFNIOPPCKNG, LJBEBGPAIAD HELFJHKDFKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3E54160", Offset = "0x3E52B60", VA = "0x183E54160", Slot = "27")]
	public override void BELONPHAHIG(NEPGEFNACME BAKFLKNIOJD, [Optional] object MPOBGCPIOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3E55760", Offset = "0x3E54160", VA = "0x183E55760", Slot = "28")]
	public override bool LGMKCBFJFDH(Entity NMMHFBINDGD, Entity EEBGELKKKEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "29")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3E54620", Offset = "0x3E53020", VA = "0x183E54620", Slot = "31")]
	public override string FHHIGHCJEDB([In] LJBEBGPAIAD OIIGHCOBIGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3E540F0", Offset = "0x3E52AF0", VA = "0x183E540F0")]
	private bool ADHKKHFADKK(T OFGFIAGNBIM, T HELFJHKDFKA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class ACBDGFKGODC : JKGAMEKFHLH, JFFFCDBCMIK, OBCALFIHPEE<Entity>, ABECDDJBCHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract Type GPKIFFDGPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract PLLLIFEAPFO BDKFKIGCKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public abstract NIEENGPADOA KDGEKKBLABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string FMJDNGHFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x886A70", Offset = "0x885470", VA = "0x180886A70")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int BNLHGGILBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x92EC80", Offset = "0x92D680", VA = "0x18092EC80", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9BE080", Offset = "0x9BCA80", VA = "0x1809BE080", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event GGBIIPNAKOM<Entity> HKHHOHCMFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6BA13D0", Offset = "0x6B9FDD0", VA = "0x186BA13D0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6BA1320", Offset = "0x6B9FD20", VA = "0x186BA1320", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool GHBEHEKGDOG(Entity AFNIOPPCKNG);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void GJMIFHLLDMF(Entity AFNIOPPCKNG, LHLKFGKGHKF IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool ODIPBPJKHHK(Entity AFNIOPPCKNG, LJBEBGPAIAD HELFJHKDFKA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void BELONPHAHIG(NEPGEFNACME BAKFLKNIOJD, [Optional] object MPOBGCPIOEI);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract bool LGMKCBFJFDH(Entity NMMHFBINDGD, Entity EEBGELKKKEJ);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract void HINDDHMAHAN(EntityManager JONCEOFPEBL);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x34213F0", Offset = "0x341FDF0", VA = "0x1834213F0")]
	protected void CGAGGOLKPHG<T>(Entity AFNIOPPCKNG, [In] T OFGFIAGNBIM, [In] T HELFJHKDFKA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract string FHHIGHCJEDB([In] LJBEBGPAIAD OIIGHCOBIGN);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "32")]
	public abstract JFFFCDBCMIK LPGDFBGHDCG(EntityManager HKBPDABAGBP);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	protected ACBDGFKGODC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JFFFCDBCMIK : OBCALFIHPEE<Entity>, ABECDDJBCHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JFFFCDBCMIK LPGDFBGHDCG(EntityManager HKBPDABAGBP);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CHCJAGKHKAI<T> : GBFJLHKCFEF<Entity, T>, OBCALFIHPEE<Entity>, ABECDDJBCHC, IDisposable, JFFFCDBCMIK where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface JKGAMEKFHLH : JFFFCDBCMIK, OBCALFIHPEE<Entity>, ABECDDJBCHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int BNLHGGILBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class OLNFHJFPDOO
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2F035E0", Offset = "0x2F01FE0", VA = "0x182F035E0")]
	public static T NPKHNJICONK<T>(this CHCJAGKHKAI<T> GDCGGGDDADM, Entity AFNIOPPCKNG, [Optional] T FABNMHPKJIP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2F034D0", Offset = "0x2F01ED0", VA = "0x182F034D0")]
	public static T LNFDLNBFLOL<T>(this OBCALFIHPEE<Entity> GDCGGGDDADM, Entity AFNIOPPCKNG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2F03340", Offset = "0x2F01D40", VA = "0x182F03340")]
	public static bool BANKOIMGLDC<T>(this OBCALFIHPEE<Entity> GDCGGGDDADM, Entity AFNIOPPCKNG, [In] T HELFJHKDFKA) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2F032D0", Offset = "0x2F01CD0", VA = "0x182F032D0")]
	public static bool BANKOIMGLDC<T>(this OBCALFIHPEE<Entity> GDCGGGDDADM, Entity AFNIOPPCKNG, NativeArray<T> HELFJHKDFKA) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void GGBIIPNAKOM<TKey>(TKey FHFDEAHMMBI, [In] LJBEBGPAIAD OFGFIAGNBIM, [In] LJBEBGPAIAD HELFJHKDFKA);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GHFBJJFJMHP
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2D68870", Offset = "0x2D67270", VA = "0x182D68870")]
	public static void CPLCIOOIDJC<TKey, T>(this GGBIIPNAKOM<TKey> GNOOEAHLONB, TKey FHFDEAHMMBI, T OFGFIAGNBIM, T HELFJHKDFKA) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NEPGEFNACME
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMAGBPACBLM<TKey, T>(GBFJLHKCFEF<TKey, T> GDCGGGDDADM, [Optional] object MPOBGCPIOEI) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LCEEHNKHFMN
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NIEENGPADOA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo KJKOELOAMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int DLIHEBHOHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int BKOAINILKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ABECDDJBCHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string FMJDNGHFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type GPKIFFDGPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	NIEENGPADOA KDGEKKBLABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	PLLLIFEAPFO BDKFKIGCKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int BNLHGGILBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BELONPHAHIG(NEPGEFNACME BAKFLKNIOJD, [Optional] object MPOBGCPIOEI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OBCALFIHPEE<TKey> : ABECDDJBCHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event GGBIIPNAKOM<TKey> HKHHOHCMFMI;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GHBEHEKGDOG(TKey COMNIKKFEEB);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GJMIFHLLDMF(TKey COMNIKKFEEB, LHLKFGKGHKF IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ODIPBPJKHHK(TKey COMNIKKFEEB, LJBEBGPAIAD HELFJHKDFKA);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LGMKCBFJFDH(TKey NMMHFBINDGD, TKey EEBGELKKKEJ);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string FHHIGHCJEDB([In] LJBEBGPAIAD IPHMAHBENGI);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface GBFJLHKCFEF<TKey, T> : OBCALFIHPEE<TKey>, ABECDDJBCHC, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T GJMIFHLLDMF(TKey COMNIKKFEEB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BCBOFCMGKDL
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2ACC280", Offset = "0x2ACAC80", VA = "0x182ACC280")]
	public static bool OIOKEJAEGIB<TKey, T>(this OBCALFIHPEE<TKey> GDCGGGDDADM, TKey COMNIKKFEEB, [Out] T IPHMAHBENGI) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB190", Offset = "0x2AC9B90", VA = "0x182ACB190")]
	public static T GJMIFHLLDMF<T, TKey>(this OBCALFIHPEE<TKey> GDCGGGDDADM, TKey COMNIKKFEEB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2ACBDC0", Offset = "0x2ACA7C0", VA = "0x182ACBDC0")]
	public static bool ODIPBPJKHHK<TKey, T>(this OBCALFIHPEE<TKey> GDCGGGDDADM, TKey COMNIKKFEEB, T HELFJHKDFKA) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2ACBA20", Offset = "0x2ACA420", VA = "0x182ACBA20")]
	public static bool ODIPBPJKHHK<TKey, T>(this OBCALFIHPEE<TKey> GDCGGGDDADM, TKey COMNIKKFEEB, NativeArray<T> HELFJHKDFKA) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public interface GBFENHMLIKL : IEnumerable<JFFFCDBCMIK>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PLLLIFEAPFO
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int JLLAHKELLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int JHHPLOGNEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type CFJAJFEFGAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	JFFFCDBCMIK[] CGDMGMALMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool NOCAJPFPOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	(uint, uint) GPPEDLBLNNN(Entity AFNIOPPCKNG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class JKDEPBHPLFK : GBFENHMLIKL, IEnumerable<JFFFCDBCMIK>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<JFFFCDBCMIK> OIBEMBCGOHH;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6BA1910", Offset = "0x6BA0310", VA = "0x186BA1910", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public JFFFCDBCMIK BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6BA19D0", Offset = "0x6BA03D0", VA = "0x186BA19D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6BA1A30", Offset = "0x6BA0430", VA = "0x186BA1A30")]
	public JKDEPBHPLFK(IEnumerable<PLLLIFEAPFO> LLNKLDBEDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6BA1480", Offset = "0x6B9FE80", VA = "0x186BA1480")]
	private List<JFFFCDBCMIK> BGFFLPHIIDB(IEnumerable<PLLLIFEAPFO> LLNKLDBEDJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6BA1950", Offset = "0x6BA0350", VA = "0x186BA1950", Slot = "4")]
	public IEnumerator<JFFFCDBCMIK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6BA1950", Offset = "0x6BA0350", VA = "0x186BA1950", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct FBOFDHIKKKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type KEILPJFOAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string DDDMPLCOGIM;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xCEC2C0", Offset = "0xCEACC0", VA = "0x180CEC2C0")]
	public FBOFDHIKKKJ(Type KEILPJFOAON, string DDDMPLCOGIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct KAOPOCIMJOB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type KEILPJFOAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string DDDMPLCOGIM;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xCEC2C0", Offset = "0xCEACC0", VA = "0x180CEC2C0")]
	public KAOPOCIMJOB(Type KEILPJFOAON, string DDDMPLCOGIM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x43CAE90", Offset = "0x43C9890", VA = "0x1843CAE90")]
	public static FBOFDHIKKKJ DECMLIFLLEJ(KAOPOCIMJOB<T> HILDPDFMLFP)
	{
		return default(FBOFDHIKKKJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum NGPMCHELJFD
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
public class MDNKJAHJAPB
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public MDNKJAHJAPB()
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
