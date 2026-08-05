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
public abstract class BMEHGOCELLP : FLDLOGFHEMK, JAPFLFMMLAJ, ANKBAFKPECB<Entity>, FDDOPIPPAOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public abstract Type HHINMKNAKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract NPIECMPEGKH EHCLIDINJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract NBNGLPEEKLA PFAEHLPMBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string FJPKIFMMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x760C60", Offset = "0x75FA60", VA = "0x180760C60")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NBKBAIOJEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x806B40", Offset = "0x805940", VA = "0x180806B40", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x806B50", Offset = "0x805950", VA = "0x180806B50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event PFNNBOJEDBM<Entity> MMLHNLNPEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5D6E980", Offset = "0x5D6D780", VA = "0x185D6E980", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D6E8D0", Offset = "0x5D6D6D0", VA = "0x185D6E8D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract bool MDCAPFCGBJE(Entity HHHGBIJCKBC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void HAMDPAFEPLN(Entity HHHGBIJCKBC, FHNHJBJNGAK POACLGOFKAJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool MFACMGCFCOL(Entity HHHGBIJCKBC, EBLDEHNKIAL OEMJACOGEGN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void FHMOENGGDFN(FPDFFDEKJBE OEBLNDDIIDP, [Optional] object DDMHMHFODEB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool DPPGELLEEGP(Entity HPMEJLCHJFA, Entity ECAFGEFAJGI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void HCKCHEHGBKI(EntityManager GMDAKDJOHKE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x218E060", Offset = "0x218CE60", VA = "0x18218E060")]
	protected void IJKLCKMIMLG<T>(Entity HHHGBIJCKBC, [In] T NKIGLDDAMAM, [In] T OEMJACOGEGN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	protected BMEHGOCELLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[DefaultMember("Item")]
public class KPOPJMLJIEE<T> : BMEHGOCELLP, KBDECHKGODD<T>, KFKPFKCNHBF<Entity, T>, ANKBAFKPECB<Entity>, FDDOPIPPAOG, IDisposable, JAPFLFMMLAJ, NBNGLPEEKLA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate bool DKMPPCPEDPO(Entity HHHGBIJCKBC, [In] T OEMJACOGEGN);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate void ELIKLEMODGM(Entity HHHGBIJCKBC, [In] T NKIGLDDAMAM, [In] T OEMJACOGEGN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NPIECMPEGKH IGCDHDJEOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FieldInfo DJBJFENHKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly int NGICFBMMBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int NNACFOFLCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int GINFBCJKIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private DKMPPCPEDPO JLCBLDHLCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private ELIKLEMODGM LNLHNAAHAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private ELIKLEMODGM FEIBJKMHEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World JDDIMGOGDBE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Type HHINMKNAKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x38D2C50", Offset = "0x38D1A50", VA = "0x1838D2C50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override NPIECMPEGKH EHCLIDINJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override NBNGLPEEKLA PFAEHLPMBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private FieldInfo MFBCJABHHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870", Slot = "30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private int BIABPHHPPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x77CCA0", Offset = "0x77BAA0", VA = "0x18077CCA0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private int NAMLPIOPPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x76E110", Offset = "0x76CF10", VA = "0x18076E110", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private EntityManager LHLNHKNJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x38D2BD0", Offset = "0x38D19D0", VA = "0x1838D2BD0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x38D48B0", Offset = "0x38D36B0", VA = "0x1838D48B0")]
	public KPOPJMLJIEE(string MEBBBIMBIJO, NPIECMPEGKH IGCDHDJEOJJ, FieldInfo DJBJFENHKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x38D34A0", Offset = "0x38D22A0", VA = "0x1838D34A0", Slot = "28")]
	public override void HCKCHEHGBKI(EntityManager GMDAKDJOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x38D2F50", Offset = "0x38D1D50", VA = "0x1838D2F50")]
	public KPOPJMLJIEE<T> FDJINEFDMFK(DKMPPCPEDPO JLCBLDHLCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x38D3580", Offset = "0x38D2380", VA = "0x1838D3580")]
	public KPOPJMLJIEE<T> LGFKFNDOJAL(ELIKLEMODGM LNLHNAAHAIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x38D3560", Offset = "0x38D2360", VA = "0x1838D3560")]
	public KPOPJMLJIEE<T> HFAIHIPHNGO(ELIKLEMODGM FEIBJKMHEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x38D2FA0", Offset = "0x38D1DA0", VA = "0x1838D2FA0", Slot = "29")]
	public T HAMDPAFEPLN(Entity HHHGBIJCKBC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x38D42D0", Offset = "0x38D30D0", VA = "0x1838D42D0")]
	public bool MFACMGCFCOL(Entity HHHGBIJCKBC, [In] T OEMJACOGEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x38D2B90", Offset = "0x38D1990", VA = "0x1838D2B90")]
	public bool ALPLGKGOACO(Entity HHHGBIJCKBC, [In] T OEMJACOGEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x38D3810", Offset = "0x38D2610", VA = "0x1838D3810", Slot = "22")]
	public override bool MDCAPFCGBJE(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x38D3280", Offset = "0x38D2080", VA = "0x1838D3280", Slot = "23")]
	public override void HAMDPAFEPLN(Entity HHHGBIJCKBC, FHNHJBJNGAK POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x38D4640", Offset = "0x38D3440", VA = "0x1838D4640", Slot = "24")]
	public override bool MFACMGCFCOL(Entity HHHGBIJCKBC, EBLDEHNKIAL OEMJACOGEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x38D2F70", Offset = "0x38D1D70", VA = "0x1838D2F70", Slot = "25")]
	public override void FHMOENGGDFN(FPDFFDEKJBE OEBLNDDIIDP, [Optional] object DDMHMHFODEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x38D2D70", Offset = "0x38D1B70", VA = "0x1838D2D70", Slot = "26")]
	public override bool DPPGELLEEGP(Entity HPMEJLCHJFA, Entity ECAFGEFAJGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "27")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x38D35A0", Offset = "0x38D23A0", VA = "0x1838D35A0")]
	private bool LHMKAMGHECE(T NKIGLDDAMAM, T OEMJACOGEGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JAPFLFMMLAJ : ANKBAFKPECB<Entity>, FDDOPIPPAOG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KBDECHKGODD<T> : KFKPFKCNHBF<Entity, T>, ANKBAFKPECB<Entity>, FDDOPIPPAOG, IDisposable, JAPFLFMMLAJ where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface FLDLOGFHEMK : JAPFLFMMLAJ, ANKBAFKPECB<Entity>, FDDOPIPPAOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int NBKBAIOJEOA
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
public static class CFENGGAJOAF
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x21E7850", Offset = "0x21E6650", VA = "0x1821E7850")]
	public static T LBHDAFKGGKK<T>(this KBDECHKGODD<T> GHOAJKHDDHN, Entity HHHGBIJCKBC, [Optional] T PPFOBEPKLDB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x21E7C10", Offset = "0x21E6A10", VA = "0x1821E7C10")]
	public static T ODPMJGFGKKE<T>(this ANKBAFKPECB<Entity> GHOAJKHDDHN, Entity HHHGBIJCKBC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x21E7A30", Offset = "0x21E6830", VA = "0x1821E7A30")]
	public static bool MIJIMIONLJI<T>(this ANKBAFKPECB<Entity> GHOAJKHDDHN, Entity HHHGBIJCKBC, [In] T OEMJACOGEGN) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void PFNNBOJEDBM<TKey>(TKey DGPHOMINFCK, [In] EBLDEHNKIAL NKIGLDDAMAM, [In] EBLDEHNKIAL OEMJACOGEGN);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class OGFENNMCFHC
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2501CE0", Offset = "0x2500AE0", VA = "0x182501CE0")]
	public static void FKGDFLCAOJM<TKey, T>(this PFNNBOJEDBM<TKey> AIKAAJDIFDJ, TKey DGPHOMINFCK, T NKIGLDDAMAM, T OEMJACOGEGN) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FPDFFDEKJBE
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CFEDMPPIKFO<TKey, T>(KFKPFKCNHBF<TKey, T> GHOAJKHDDHN, [Optional] object DDMHMHFODEB) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DHFOBDOPNKK
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NBNGLPEEKLA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo BKOLLDLEPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int IKKFEAHBANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int MGLJLKOIJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FDDOPIPPAOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string FJPKIFMMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type HHINMKNAKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	NBNGLPEEKLA PFAEHLPMBNG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	NPIECMPEGKH EHCLIDINJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int NBKBAIOJEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FHMOENGGDFN(FPDFFDEKJBE OEBLNDDIIDP, [Optional] object DDMHMHFODEB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ANKBAFKPECB<TKey> : FDDOPIPPAOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event PFNNBOJEDBM<TKey> MMLHNLNPEIH;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MDCAPFCGBJE(TKey GMOPMNAPKBE);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HAMDPAFEPLN(TKey GMOPMNAPKBE, FHNHJBJNGAK POACLGOFKAJ);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MFACMGCFCOL(TKey GMOPMNAPKBE, EBLDEHNKIAL OEMJACOGEGN);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DPPGELLEEGP(TKey HPMEJLCHJFA, TKey ECAFGEFAJGI);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public interface KFKPFKCNHBF<TKey, T> : ANKBAFKPECB<TKey>, FDDOPIPPAOG, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T HAMDPAFEPLN(TKey GMOPMNAPKBE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LHMOEBHFIKL
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x24573C0", Offset = "0x24561C0", VA = "0x1824573C0")]
	public static bool HBHBLNKJFLH<TKey, T>(this ANKBAFKPECB<TKey> GHOAJKHDDHN, TKey GMOPMNAPKBE, [Out] T POACLGOFKAJ) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2456740", Offset = "0x2455540", VA = "0x182456740")]
	public static T HAMDPAFEPLN<T, TKey>(this ANKBAFKPECB<TKey> GHOAJKHDDHN, TKey GMOPMNAPKBE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2457580", Offset = "0x2456380", VA = "0x182457580")]
	public static bool MFACMGCFCOL<TKey, T>(this ANKBAFKPECB<TKey> GHOAJKHDDHN, TKey GMOPMNAPKBE, T OEMJACOGEGN) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface NJFHDFEHOGF : IEnumerable<JAPFLFMMLAJ>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NPIECMPEGKH
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int HHPDFAMOEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int OIBIDIPIPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type KPHEHAOIFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	JAPFLFMMLAJ[] LLIHFMLNDEG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	(uint, uint) AECMIHCCDAK(Entity HHHGBIJCKBC);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CJIHFPEMOHB(Entity HHHGBIJCKBC, (uint order, uint change) FBJEHMGCPKI);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class LPIMHMEFHIL : NJFHDFEHOGF, IEnumerable<JAPFLFMMLAJ>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<JAPFLFMMLAJ> MNJHJANBGPI;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5D6EFB0", Offset = "0x5D6DDB0", VA = "0x185D6EFB0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public JAPFLFMMLAJ CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5D6EA30", Offset = "0x5D6D830", VA = "0x185D6EA30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5D6EFF0", Offset = "0x5D6DDF0", VA = "0x185D6EFF0")]
	public LPIMHMEFHIL(IEnumerable<NPIECMPEGKH> JJJGIFOLCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5D6EB10", Offset = "0x5D6D910", VA = "0x185D6EB10")]
	private List<JAPFLFMMLAJ> HHMJEHGMCGI(IEnumerable<NPIECMPEGKH> JJJGIFOLCFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5D6EA90", Offset = "0x5D6D890", VA = "0x185D6EA90", Slot = "4")]
	public IEnumerator<JAPFLFMMLAJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5D6EA90", Offset = "0x5D6D890", VA = "0x185D6EA90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BKOKDGLHFLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type KAHCFCDLONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string MEBBBIMBIJO;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7E8680", Offset = "0x7E7480", VA = "0x1807E8680")]
	public BKOKDGLHFLO(Type KAHCFCDLONP, string MEBBBIMBIJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HPFFBCFNPLK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type KAHCFCDLONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string MEBBBIMBIJO;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7E8680", Offset = "0x7E7480", VA = "0x1807E8680")]
	public HPFFBCFNPLK(Type KAHCFCDLONP, string MEBBBIMBIJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x35EE2A0", Offset = "0x35ED0A0", VA = "0x1835EE2A0")]
	public static BKOKDGLHFLO IAIHCEAPEMK(HPFFBCFNPLK<T> CONHAFAMJMM)
	{
		return default(BKOKDGLHFLO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum PEEOBDGHOJI
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
public class LCOCJIOOHJG
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public LCOCJIOOHJG()
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
