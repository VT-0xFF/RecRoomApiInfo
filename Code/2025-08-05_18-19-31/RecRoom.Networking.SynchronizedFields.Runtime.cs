using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Foundation;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PEHBHGFGIAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FMMJEAAGOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LBDFKNJJGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NELIJLIGAOD CLICIJGIMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int FCBEEEEIBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool JGDCPNPGELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool FACDMLFOFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NLKHJCAKALM;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BDNILPIFNNN();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ABGLFDFKFHO(object MONGIMOHLAO, bool AKNIBKDEPIM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EHJDIFKMABL();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OMFNFPECOGL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string BPKEMDDKCGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool DDIMPJACJJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FCJBILIPOKM<T> : OMFNFPECOGL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T OAMFIPLIEAF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJMINPDIBNN(T LEOKHPGPGKC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class GIKMJDNAABN<T> : FCJBILIPOKM<T>, OMFNFPECOGL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PPKADLMLNJM<T> PPGAMEAILOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly PPKADLMLNJM<T> DGLLHPLPLNI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string BPKEMDDKCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xF30870", Offset = "0xF2FC70", VA = "0x180F30870", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool AABOHIFFANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x49CCD40", Offset = "0x49CC140", VA = "0x1849CCD40", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T NOOGMHBOMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4F586C0", Offset = "0x4F57AC0", VA = "0x184F586C0", Slot = "11")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4F57C30", Offset = "0x4F57030", VA = "0x184F57C30", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T OAMFIPLIEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4F578A0", Offset = "0x4F56CA0", VA = "0x184F578A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4F58800", Offset = "0x4F57C00", VA = "0x184F58800", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4F578A0", Offset = "0x4F56CA0", VA = "0x184F578A0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4F58990", Offset = "0x4F57D90", VA = "0x184F58990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool DDIMPJACJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x49CC870", Offset = "0x49CBC70", VA = "0x1849CC870", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x49CE570", Offset = "0x49CD970", VA = "0x1849CE570", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool IEAAMLFFHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4F58F90", Offset = "0x4F58390", VA = "0x184F58F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4F57F90", Offset = "0x4F57390", VA = "0x184F57F90", Slot = "10")]
	public void CNFJEHEIBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4F59F90", Offset = "0x4F59390", VA = "0x184F59F90")]
	public GIKMJDNAABN([In] JDHJJDKCDMA NGIAGNLBILI, T BMFNABDHOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4F58F10", Offset = "0x4F58310", VA = "0x184F58F10")]
	private void NKFFDLGFFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4F58AF0", Offset = "0x4F57EF0", VA = "0x184F58AF0", Slot = "5")]
	public void NJMINPDIBNN(T LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4F58A20", Offset = "0x4F57E20", VA = "0x184F58A20")]
	public void NJMINPDIBNN(T LEOKHPGPGKC, bool BJGFLELCBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x49CCC20", Offset = "0x49CC020", VA = "0x1849CCC20", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class EEJLLCABFKN<T1, T2> : FCJBILIPOKM<(T1, T2)>, OMFNFPECOGL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly JOGBBJNJLBP<T1, T2> PPGAMEAILOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JOGBBJNJLBP<T1, T2> DGLLHPLPLNI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string BPKEMDDKCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xF30870", Offset = "0xF2FC70", VA = "0x180F30870", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool AABOHIFFANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x49CCE30", Offset = "0x49CC230", VA = "0x1849CCE30", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool HGAMBECEMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x49CC980", Offset = "0x49CBD80", VA = "0x1849CC980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool DIBAKFLLDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x49CC540", Offset = "0x49CB940", VA = "0x1849CC540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public (T1, T2) NOOGMHBOMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x49CD130", Offset = "0x49CC530", VA = "0x1849CD130", Slot = "11")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x49CBF50", Offset = "0x49CB350", VA = "0x1849CBF50", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public (T1, T2) OAMFIPLIEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x49CBAB0", Offset = "0x49CAEB0", VA = "0x1849CBAB0", Slot = "4")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x49CD5E0", Offset = "0x49CC9E0", VA = "0x1849CD5E0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public (T1, T2) JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x49CD030", Offset = "0x49CC430", VA = "0x1849CD030")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x49CD700", Offset = "0x49CCB00", VA = "0x1849CD700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T1 EDGKHGKNCDA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x49CDCE0", Offset = "0x49CD0E0", VA = "0x1849CDCE0")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x49CD7B0", Offset = "0x49CCBB0", VA = "0x1849CD7B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T1 PEABLAFJPEN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x49CD4D0", Offset = "0x49CC8D0", VA = "0x1849CD4D0")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T1 FOFFGDDKIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x49CD4D0", Offset = "0x49CC8D0", VA = "0x1849CD4D0")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x49CD510", Offset = "0x49CC910", VA = "0x1849CD510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T2 CLMKGMIIPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x49CE210", Offset = "0x49CD610", VA = "0x1849CE210")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x49CDA30", Offset = "0x49CCE30", VA = "0x1849CDA30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T2 MNMLLMCBGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x49CB800", Offset = "0x49CAC00", VA = "0x1849CB800")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public T2 ODKJANLCFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x49CB800", Offset = "0x49CAC00", VA = "0x1849CB800")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x49CC8D0", Offset = "0x49CBCD0", VA = "0x1849CC8D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool DDIMPJACJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x49CC870", Offset = "0x49CBC70", VA = "0x1849CC870", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x49CE570", Offset = "0x49CD970", VA = "0x1849CE570", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x49CC3A0", Offset = "0x49CB7A0", VA = "0x1849CC3A0", Slot = "10")]
	public void CNFJEHEIBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x49CEBC0", Offset = "0x49CDFC0", VA = "0x1849CEBC0")]
	public EEJLLCABFKN([In] JDHJJDKCDMA NGIAGNLBILI, T1 PIAGMBPNLDO, T2 MFECLOMLNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x49CDFD0", Offset = "0x49CD3D0", VA = "0x1849CDFD0")]
	private void NKFFDLGFFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x49CE3E0", Offset = "0x49CD7E0", VA = "0x1849CE3E0")]
	public void OPMLKOHNBMK(T1 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x49CDD80", Offset = "0x49CD180", VA = "0x1849CDD80")]
	public void NJMINPDIBNN(T1 HPPIJLLDJHK, T2 GDOMCIICLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x49CB910", Offset = "0x49CAD10", VA = "0x1849CB910", Slot = "5")]
	private void AHLPDMDFBEN((T1, T2) EMOJJIEJAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x49CCC20", Offset = "0x49CC020", VA = "0x1849CCC20", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class OBBFDEEHKFF<T1, T2, T3> : FCJBILIPOKM<(T1, T2, T3)>, OMFNFPECOGL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EGMMBAAKIBM<T1, T2, T3> PPGAMEAILOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly EGMMBAAKIBM<T1, T2, T3> DGLLHPLPLNI;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string BPKEMDDKCGD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xF30870", Offset = "0xF2FC70", VA = "0x180F30870", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool AABOHIFFANK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4F58460", Offset = "0x4F57860", VA = "0x184F58460", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool HGAMBECEMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x49CC980", Offset = "0x49CBD80", VA = "0x1849CC980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool DIBAKFLLDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x49CC630", Offset = "0x49CBA30", VA = "0x1849CC630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool HFKHFAPEDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x594D220", Offset = "0x594C620", VA = "0x18594D220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public (T1, T2, T3) NOOGMHBOMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x594CE20", Offset = "0x594C220", VA = "0x18594CE20", Slot = "11")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x594C6B0", Offset = "0x594BAB0", VA = "0x18594C6B0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public (T1, T2, T3) OAMFIPLIEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x594C3A0", Offset = "0x594B7A0", VA = "0x18594C3A0", Slot = "4")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x594D740", Offset = "0x594CB40", VA = "0x18594D740", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T1 EDGKHGKNCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x594DAA0", Offset = "0x594CEA0", VA = "0x18594DAA0")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x594D8D0", Offset = "0x594CCD0", VA = "0x18594D8D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T1 PEABLAFJPEN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x594D620", Offset = "0x594CA20", VA = "0x18594D620")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T1 FOFFGDDKIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x594D620", Offset = "0x594CA20", VA = "0x18594D620")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x594D6A0", Offset = "0x594CAA0", VA = "0x18594D6A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T2 CLMKGMIIPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x594DE40", Offset = "0x594D240", VA = "0x18594DE40")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x594D960", Offset = "0x594CD60", VA = "0x18594D960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T2 MNMLLMCBGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x594C060", Offset = "0x594B460", VA = "0x18594C060")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T2 ODKJANLCFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x594C060", Offset = "0x594B460", VA = "0x18594C060")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x594C990", Offset = "0x594BD90", VA = "0x18594C990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public T3 LCPPPDLBDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x594C0A0", Offset = "0x594B4A0", VA = "0x18594C0A0")]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x594C210", Offset = "0x594B610", VA = "0x18594C210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public T3 DCKBHHLMMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x594CDE0", Offset = "0x594C1E0", VA = "0x18594CDE0")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public T3 JKALNCEGCKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x594CDE0", Offset = "0x594C1E0", VA = "0x18594CDE0")]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x594D680", Offset = "0x594CA80", VA = "0x18594D680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DDIMPJACJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x49CC870", Offset = "0x49CBC70", VA = "0x1849CC870", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x594C920", Offset = "0x594BD20", VA = "0x18594C920", Slot = "10")]
	public void CNFJEHEIBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x594E560", Offset = "0x594D960", VA = "0x18594E560")]
	public OBBFDEEHKFF([In] JDHJJDKCDMA NGIAGNLBILI, T1 PIAGMBPNLDO, T2 MFECLOMLNAF, T3 OLOJDJJJKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x594DC60", Offset = "0x594D060", VA = "0x18594DC60")]
	private void NKFFDLGFFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x594E040", Offset = "0x594D440", VA = "0x18594E040")]
	public void OPMLKOHNBMK(T1 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x594CAB0", Offset = "0x594BEB0", VA = "0x18594CAB0")]
	public void FNMIDCLONNO(T2 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x594D380", Offset = "0x594C780", VA = "0x18594D380")]
	public void INHKADFGLCJ(T3 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x594DAE0", Offset = "0x594CEE0", VA = "0x18594DAE0")]
	public void NJMINPDIBNN(T1 HPPIJLLDJHK, T2 GDOMCIICLNP, T3 JOHGPBBIJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x594CD50", Offset = "0x594C150", VA = "0x18594CD50", Slot = "5")]
	private void GFBMBDHGGBI((T1, T2, T3) EMOJJIEJAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x49CCC20", Offset = "0x49CC020", VA = "0x1849CCC20", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class GBOJDAEGKBP<T1, T2, T3, T4> : FCJBILIPOKM<(T1, T2, T3, T4)>, OMFNFPECOGL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly MLFKFCJFNAG<T1, T2, T3, T4> PPGAMEAILOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MLFKFCJFNAG<T1, T2, T3, T4> DGLLHPLPLNI;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string BPKEMDDKCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xF30870", Offset = "0xF2FC70", VA = "0x180F30870", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public (T1, T2, T3, T4) OAMFIPLIEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4F3F7D0", Offset = "0x4F3EBD0", VA = "0x184F3F7D0", Slot = "4")]
		get
		{
			return default((T1, T2, T3, T4));
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4F3F950", Offset = "0x4F3ED50", VA = "0x184F3F950", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public T2 MNMLLMCBGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4F3F9F0", Offset = "0x4F3EDF0", VA = "0x184F3F9F0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T3 DCKBHHLMMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4F3F910", Offset = "0x4F3ED10", VA = "0x184F3F910")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public T4 LAIKHMCACJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4E5F190", Offset = "0x4E5E590", VA = "0x184E5F190")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool DDIMPJACJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x49CC870", Offset = "0x49CBC70", VA = "0x1849CC870", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x49CE570", Offset = "0x49CD970", VA = "0x1849CE570", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4F3FFA0", Offset = "0x4F3F3A0", VA = "0x184F3FFA0")]
	public GBOJDAEGKBP([In] JDHJJDKCDMA NGIAGNLBILI, T1 PIAGMBPNLDO, T2 MFECLOMLNAF, T3 OLOJDJJJKMK, T4 BFGFLHIDHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4F3FAD0", Offset = "0x4F3EED0", VA = "0x184F3FAD0")]
	private void NKFFDLGFFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4F3FE10", Offset = "0x4F3F210", VA = "0x184F3FE10")]
	public void OPMLKOHNBMK(T1 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4F3FA30", Offset = "0x4F3EE30", VA = "0x184F3FA30")]
	public void NJMINPDIBNN(T1 HPPIJLLDJHK, T2 GDOMCIICLNP, T3 JOHGPBBIJFC, T4 PFHEAPILKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4F3FF60", Offset = "0x4F3F360", VA = "0x184F3FF60", Slot = "5")]
	private void PLFKLHHHOOH((T1, T2, T3, T4) EMOJJIEJAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x49CCC20", Offset = "0x49CC020", VA = "0x1849CCC20", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CNOOIMKMLNO
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x83FC6B0", Offset = "0x83FBAB0", VA = "0x1883FC6B0")]
	public static string CIKAKICFHAM(this JDHJJDKCDMA NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xAC93A0", Offset = "0xAC87A0", VA = "0x180AC93A0")]
	public static LDIOPPLNFOK NKMEPDOHEBO(this JDHJJDKCDMA NGIAGNLBILI)
	{
		return default(LDIOPPLNFOK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PPKADLMLNJM<T> : IHEBJLKKKCI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5B38540", Offset = "0x5B37940", VA = "0x185B38540")]
	public PPKADLMLNJM([In] JDHJJDKCDMA NGIAGNLBILI, T ABINAMGBLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5B371E0", Offset = "0x5B365E0", VA = "0x185B371E0")]
	public PPKADLMLNJM(LEAENBOEFMM HFJHENFIDEF, NELIJLIGAOD NICGPJDLKCM, string PEENICAIFOP, T ABINAMGBLJP, LDIOPPLNFOK EJMHLNHKOAJ, [Optional] Action BFDLNHAHOHH, [Optional] JECLPACKCAE NEPELGPJGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5B37C00", Offset = "0x5B37000", VA = "0x185B37C00")]
	public PPKADLMLNJM(LEAENBOEFMM HFJHENFIDEF, string PEENICAIFOP, T ABINAMGBLJP, LDIOPPLNFOK EJMHLNHKOAJ, [Optional] Action BFDLNHAHOHH, [Optional] JECLPACKCAE NEPELGPJGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5B382A0", Offset = "0x5B376A0", VA = "0x185B382A0")]
	public PPKADLMLNJM(LEAENBOEFMM HFJHENFIDEF, string PEENICAIFOP, T ABINAMGBLJP, LDIOPPLNFOK EJMHLNHKOAJ, bool FELGAGEDALA, [Optional] Action BFDLNHAHOHH, [Optional] JECLPACKCAE NEPELGPJGPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JOGBBJNJLBP<T1, T2> : HAIPCHDHEJB<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x537A1E0", Offset = "0x53795E0", VA = "0x18537A1E0")]
	public JOGBBJNJLBP([In] JDHJJDKCDMA NGIAGNLBILI, T1 FBDBMALPJKJ, T2 EJNKDHAINJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x537D430", Offset = "0x537C830", VA = "0x18537D430")]
	public JOGBBJNJLBP(LEAENBOEFMM HFJHENFIDEF, NELIJLIGAOD NICGPJDLKCM, string PEENICAIFOP, T1 FBDBMALPJKJ, T2 EJNKDHAINJE, LDIOPPLNFOK EJMHLNHKOAJ, [Optional] Action BFDLNHAHOHH, [Optional] JECLPACKCAE NEPELGPJGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x537BE60", Offset = "0x537B260", VA = "0x18537BE60")]
	public JOGBBJNJLBP(LEAENBOEFMM HFJHENFIDEF, string PEENICAIFOP, T1 FBDBMALPJKJ, T2 EJNKDHAINJE, LDIOPPLNFOK EJMHLNHKOAJ, [Optional] Action BFDLNHAHOHH, [Optional] JECLPACKCAE NEPELGPJGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x537A200", Offset = "0x5379600", VA = "0x18537A200")]
	public JOGBBJNJLBP(LEAENBOEFMM HFJHENFIDEF, string PEENICAIFOP, T1 FBDBMALPJKJ, T2 EJNKDHAINJE, LDIOPPLNFOK EJMHLNHKOAJ, bool FELGAGEDALA, [Optional] Action BFDLNHAHOHH, [Optional] JECLPACKCAE NEPELGPJGPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class EGMMBAAKIBM<T1, T2, T3> : GEBJFIBDEOB<T1, T2, T3>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x49D1600", Offset = "0x49D0A00", VA = "0x1849D1600")]
	public EGMMBAAKIBM([In] JDHJJDKCDMA NGIAGNLBILI, T1 FBDBMALPJKJ, T2 EJNKDHAINJE, T3 LKJMPPEEOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x49D1FA0", Offset = "0x49D13A0", VA = "0x1849D1FA0")]
	public EGMMBAAKIBM(LEAENBOEFMM HFJHENFIDEF, string PEENICAIFOP, T1 FBDBMALPJKJ, T2 EJNKDHAINJE, T3 LKJMPPEEOBO, LDIOPPLNFOK EJMHLNHKOAJ, [Optional] Action BFDLNHAHOHH, [Optional] JECLPACKCAE NEPELGPJGPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MLFKFCJFNAG<T1, T2, T3, T4> : POHGJGLFCBE<T1, T2, T3, T4>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x578F4D0", Offset = "0x578E8D0", VA = "0x18578F4D0")]
	public MLFKFCJFNAG([In] JDHJJDKCDMA NGIAGNLBILI, T1 FBDBMALPJKJ, T2 EJNKDHAINJE, T3 LKJMPPEEOBO, T4 EJOGEGAFHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x578F540", Offset = "0x578E940", VA = "0x18578F540")]
	public MLFKFCJFNAG(LEAENBOEFMM HFJHENFIDEF, NELIJLIGAOD NICGPJDLKCM, string PEENICAIFOP, T1 FBDBMALPJKJ, T2 EJNKDHAINJE, T3 LKJMPPEEOBO, T4 EJOGEGAFHOO, LDIOPPLNFOK EJMHLNHKOAJ, [Optional] Action BFDLNHAHOHH, [Optional] JECLPACKCAE NEPELGPJGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x57903D0", Offset = "0x578F7D0", VA = "0x1857903D0")]
	public MLFKFCJFNAG(LEAENBOEFMM HFJHENFIDEF, string PEENICAIFOP, T1 FBDBMALPJKJ, T2 EJNKDHAINJE, T3 LKJMPPEEOBO, T4 EJOGEGAFHOO, LDIOPPLNFOK EJMHLNHKOAJ, [Optional] Action BFDLNHAHOHH, [Optional] JECLPACKCAE NEPELGPJGPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BPOCJFEOHCJ<T1, T2, T3, T4, T5> : NOJEOJOCFBG<T1, T2, T3, T4, T5>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x69B66E0", Offset = "0x69B5AE0", VA = "0x1869B66E0")]
	public BPOCJFEOHCJ(LEAENBOEFMM HFJHENFIDEF, NELIJLIGAOD NICGPJDLKCM, string PEENICAIFOP, T1 FBDBMALPJKJ, T2 EJNKDHAINJE, T3 LKJMPPEEOBO, T4 EJOGEGAFHOO, T5 IPOHGNIOKHL, LDIOPPLNFOK EJMHLNHKOAJ, [Optional] Action BFDLNHAHOHH, [Optional] JECLPACKCAE NEPELGPJGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x69B6D60", Offset = "0x69B6160", VA = "0x1869B6D60")]
	public BPOCJFEOHCJ(LEAENBOEFMM HFJHENFIDEF, string PEENICAIFOP, T1 FBDBMALPJKJ, T2 EJNKDHAINJE, T3 LKJMPPEEOBO, T4 EJOGEGAFHOO, T5 IPOHGNIOKHL, LDIOPPLNFOK EJMHLNHKOAJ, [Optional] Action BFDLNHAHOHH, [Optional] JECLPACKCAE NEPELGPJGPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class AJBINFKHFJK<T> : IHEBJLKKKCI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x52B77B0", Offset = "0x52B6BB0", VA = "0x1852B77B0")]
	public AJBINFKHFJK(NELIJLIGAOD NICGPJDLKCM, string PEENICAIFOP, T ABINAMGBLJP, [Optional] Action BFDLNHAHOHH, [Optional] JECLPACKCAE NEPELGPJGPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EDGBMANILME<T1, T2> : HAIPCHDHEJB<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x49B6EF0", Offset = "0x49B62F0", VA = "0x1849B6EF0")]
	public EDGBMANILME(NELIJLIGAOD NICGPJDLKCM, string PEENICAIFOP, T1 KLMOEDLINGP, T2 KAKDFLPLKFH, [Optional] Action BFDLNHAHOHH, [Optional] JECLPACKCAE NEPELGPJGPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DIOFEELCFBG
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PPKADLMLNJM<T1> LMLHPJMBPOG<T1>(string PEENICAIFOP, T1 KLMOEDLINGP, LDIOPPLNFOK EJMHLNHKOAJ, [Optional] Action BFDLNHAHOHH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NOINIKKIJHG : DIOFEELCFBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly JECLPACKCAE NEPELGPJGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LEAENBOEFMM HFJHENFIDEF;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xA7A690", Offset = "0xA79A90", VA = "0x180A7A690")]
	public NOINIKKIJHG(JECLPACKCAE NEPELGPJGPL, LEAENBOEFMM LJHHEDBGIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3E62BA0", Offset = "0x3E61FA0", VA = "0x183E62BA0", Slot = "4")]
	public PPKADLMLNJM<T1> LMLHPJMBPOG<T1>(string PEENICAIFOP, T1 KLMOEDLINGP, LDIOPPLNFOK EJMHLNHKOAJ, [Optional] Action BFDLNHAHOHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GKPIBMLINMG : LEAENBOEFMM
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ViewId PPIHJGPLKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LEAENBOEFMM
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool GAJKCHMENCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool NIMEKEBDGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string PKIHKDOIJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool CNDENEEKMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RegisterDestroyHandler(GDMDNPBCKBN IGJIAOCAHMB);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UnregisterDestroyHandler(GDMDNPBCKBN IGJIAOCAHMB);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ANCKEEPHBHO
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x83FC660", Offset = "0x83FBA60", VA = "0x1883FC660")]
	public static bool JNMFLCIOBNJ(this LEAENBOEFMM HFJHENFIDEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JECLPACKCAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	NELIJLIGAOD EAEIDFPEPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool IEAAMLFFHLG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool IONLIPOCNKD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PJOFCLDPLJB();

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object GEFFCPFEFKC(string PEENICAIFOP);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	object CPHJMEFPPFA(NELIJLIGAOD KHKEJCOHPIB, string PEENICAIFOP);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OHGJJFBHDCN(string PEENICAIFOP, object LEOKHPGPGKC);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AJBEPLDGGCG(NELIJLIGAOD KHKEJCOHPIB, string PEENICAIFOP, object LEOKHPGPGKC);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HMLKCCGMFLG<T>(string PEENICAIFOP, T CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GPKGENPEEFH([CanBeNull] NELIJLIGAOD KHKEJCOHPIB, string PEENICAIFOP, PALFFNBPPLC LHIMAPPHKGK);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PPMBAFBGLCP([CanBeNull] NELIJLIGAOD KHKEJCOHPIB, string PEENICAIFOP, PALFFNBPPLC LHIMAPPHKGK);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "11")]
	T EBCGPCINELB<T>(object CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "12")]
	object AJKHJCNMOPC<T>(T ABINAMGBLJP);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EIDNGOKEOCE();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LIHLPMFBKBK();

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IFIMAFOCHJN(string KOJGIHKIGBD);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JDHJJDKCDMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NELIJLIGAOD NICGPJDLKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public LEAENBOEFMM HFJHENFIDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public string PEENICAIFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public LDIOPPLNFOK EJMHLNHKOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool FELGAGEDALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action BFDLNHAHOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public JECLPACKCAE NEPELGPJGPL;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x83FC8D0", Offset = "0x83FBCD0", VA = "0x1883FC8D0")]
	public JDHJJDKCDMA(JDHJJDKCDMA LHDOHAKINKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x83FC740", Offset = "0x83FBB40", VA = "0x1883FC740")]
	public JDHJJDKCDMA(LEAENBOEFMM HFJHENFIDEF, string PEENICAIFOP, LDIOPPLNFOK EJMHLNHKOAJ, [Optional] Action BFDLNHAHOHH, [Optional] JECLPACKCAE NEPELGPJGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x83FC6F0", Offset = "0x83FBAF0", VA = "0x1883FC6F0")]
	public static JDHJJDKCDMA HBEHBGIAPLO(LEAENBOEFMM HFJHENFIDEF, string PEENICAIFOP, LDIOPPLNFOK EJMHLNHKOAJ, [Optional] Action BFDLNHAHOHH, [Optional] JECLPACKCAE NEPELGPJGPL)
	{
		return default(JDHJJDKCDMA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class GEBJPMIHADM
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3CB0D80", Offset = "0x3CB0180", VA = "0x183CB0D80")]
	public static PPKADLMLNJM<T> OMOBAMLBMAA<T>(this JDHJJDKCDMA NGIAGNLBILI, T ABINAMGBLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3CB0BB0", Offset = "0x3CAFFB0", VA = "0x183CB0BB0")]
	public static JOGBBJNJLBP<T1, T2> OMOBAMLBMAA<T1, T2>(this JDHJJDKCDMA NGIAGNLBILI, T1 HKJCANONMLC, T2 HNGDKMILDMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3CB0C50", Offset = "0x3CB0050", VA = "0x183CB0C50")]
	public static EGMMBAAKIBM<T1, T2, T3> OMOBAMLBMAA<T1, T2, T3>(this JDHJJDKCDMA NGIAGNLBILI, T1 HKJCANONMLC, T2 HNGDKMILDMB, T3 OJMPOINNKJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3CB0FC0", Offset = "0x3CB03C0", VA = "0x183CB0FC0")]
	public static MLFKFCJFNAG<T1, T2, T3, T4> OMOBAMLBMAA<T1, T2, T3, T4>(this JDHJJDKCDMA NGIAGNLBILI, T1 HKJCANONMLC, T2 HNGDKMILDMB, T3 OJMPOINNKJA, T4 AAOMDKEBMGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3CB0D00", Offset = "0x3CB0100", VA = "0x183CB0D00")]
	public static GIKMJDNAABN<T> JMEOBBOEJMP<T>(this JDHJJDKCDMA NGIAGNLBILI, T ABINAMGBLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3CB0BB0", Offset = "0x3CAFFB0", VA = "0x183CB0BB0")]
	public static EEJLLCABFKN<T1, T2> JMEOBBOEJMP<T1, T2>(this JDHJJDKCDMA NGIAGNLBILI, T1 HKJCANONMLC, T2 HNGDKMILDMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3CB0C50", Offset = "0x3CB0050", VA = "0x183CB0C50")]
	public static OBBFDEEHKFF<T1, T2, T3> JMEOBBOEJMP<T1, T2, T3>(this JDHJJDKCDMA NGIAGNLBILI, T1 HKJCANONMLC, T2 HNGDKMILDMB, T3 OJMPOINNKJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3CB0FC0", Offset = "0x3CB03C0", VA = "0x183CB0FC0")]
	public static GBOJDAEGKBP<T1, T2, T3, T4> JMEOBBOEJMP<T1, T2, T3, T4>(this JDHJJDKCDMA NGIAGNLBILI, T1 HKJCANONMLC, T2 HNGDKMILDMB, T3 OJMPOINNKJA, T4 AAOMDKEBMGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class PALFFNBPPLC : GDMDNPBCKBN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[Flags]
	private enum LHKONACGGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Disposed = 1,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		LastSetLocally = 2,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Synchronizing = 4,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		ModifiedOffline = 8,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 4
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static Stack<JECLPACKCAE> PILCEMHMMDO;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static bool EJALLDPFHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly NELIJLIGAOD NICGPJDLKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly LEAENBOEFMM HFJHENFIDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected readonly string PEENICAIFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected readonly LDIOPPLNFOK EJMHLNHKOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly Action BFDLNHAHOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected JECLPACKCAE HPDNLGOLFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private LHKONACGGJF DPALHGCDOLB;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static JECLPACKCAE BHMABLFCDKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x83FDAA0", Offset = "0x83FCEA0", VA = "0x1883FDAA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool JFPGBCOOOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x83FD640", Offset = "0x83FCA40", VA = "0x1883FD640")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x83FD110", Offset = "0x83FC510", VA = "0x1883FD110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private bool CLNMEEOMABD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x83FCF40", Offset = "0x83FC340", VA = "0x1883FCF40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x83FD370", Offset = "0x83FC770", VA = "0x1883FD370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private bool MPLEKCEMHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x83FD250", Offset = "0x83FC650", VA = "0x1883FD250")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x83FC950", Offset = "0x83FBD50", VA = "0x1883FC950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool DDIMPJACJJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x83FCD40", Offset = "0x83FC140", VA = "0x1883FCD40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x83FDEB0", Offset = "0x83FD2B0", VA = "0x1883FDEB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected virtual object GAMAAOLDGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA70430", Offset = "0xA6F830", VA = "0x180A70430", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool NKMBPFGFHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x83FD8A0", Offset = "0x83FCCA0", VA = "0x1883FD8A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int DLMHPFHELDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xE6F700", Offset = "0xE6EB00", VA = "0x180E6F700")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xFB5540", Offset = "0xFB4940", VA = "0x180FB5540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string BPKEMDDKCGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool IEAAMLFFHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x83FDA50", Offset = "0x83FCE50", VA = "0x1883FDA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x83FC970", Offset = "0x83FBD70", VA = "0x1883FC970")]
	public static void ADKGDIJNHCB(JECLPACKCAE MFKMIGEHAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool ABHPKAIIEBB();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x83FE020", Offset = "0x83FD420", VA = "0x1883FE020")]
	protected PALFFNBPPLC(NELIJLIGAOD NICGPJDLKCM, LEAENBOEFMM HFJHENFIDEF, string PEENICAIFOP, LDIOPPLNFOK EJMHLNHKOAJ, Action BFDLNHAHOHH, JECLPACKCAE NEPELGPJGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x83FD0B0", Offset = "0x83FC4B0", VA = "0x1883FD0B0", Slot = "1")]
	~PALFFNBPPLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x83FCD50", Offset = "0x83FC150", VA = "0x1883FCD50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x83FD9B0", Offset = "0x83FCDB0", VA = "0x1883FD9B0")]
	private void MOEHHPCKGNB(bool BPIOOACEAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x83FCA10", Offset = "0x83FBE10", VA = "0x1883FCA10")]
	private object ALJHPFKNNCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x83FDC50", Offset = "0x83FD050", VA = "0x1883FDC50")]
	protected void PJOFCLDPLJB(bool FELGAGEDALA, object BMFNABDHOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x83FD8F0", Offset = "0x83FCCF0", VA = "0x1883FD8F0")]
	protected void LFFCNKDPJLH(object LEOKHPGPGKC, bool NAMBMCNBHGN = true, bool GPOBOHNHDCJ = false, bool BJGFLELCBKF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x83FD390", Offset = "0x83FC790", VA = "0x1883FD390")]
	protected void JCJKEJELJGN(object LEOKHPGPGKC, bool PKDKLNPPLEA, bool NAMBMCNBHGN, bool GPOBOHNHDCJ = false, bool BJGFLELCBKF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x83FD930", Offset = "0x83FCD30", VA = "0x1883FD930")]
	internal void MDMMCDOMCJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x83FD5E0", Offset = "0x83FC9E0", VA = "0x1883FD5E0")]
	private void JFCBNBFMPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x83FD310", Offset = "0x83FC710", VA = "0x1883FD310")]
	private void IICLMLNKEIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x83FCED0", Offset = "0x83FC2D0", VA = "0x1883FCED0", Slot = "4")]
	private void EMNIFNBDKBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x83FD240", Offset = "0x83FC640", VA = "0x1883FD240", Slot = "5")]
	private void GNNECFLLIPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x83FDB10", Offset = "0x83FCF10", VA = "0x1883FDB10")]
	public bool PGPJMBMFODB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x83FCB80", Offset = "0x83FBF80", VA = "0x1883FCB80")]
	public bool BLMAKDDJADB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x83FD750", Offset = "0x83FCB50", VA = "0x1883FD750")]
	private bool KOEPMDHCOJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x83FD260", Offset = "0x83FC660", VA = "0x1883FD260")]
	internal void IHJIGIAJOBJ(object LEOKHPGPGKC, int OBCLHDMACJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x83FD130", Offset = "0x83FC530", VA = "0x1883FD130")]
	private void GMEGKAHPBCE(object LEOKHPGPGKC, bool GPOBOHNHDCJ, bool BJGFLELCBKF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x83FCEC0", Offset = "0x83FC2C0", VA = "0x1883FCEC0")]
	private bool EGFJOGPEMHD(LHKONACGGJF HMHEELDKLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x83FD730", Offset = "0x83FCB30", VA = "0x1883FD730")]
	private void KNPECEADHDI(LHKONACGGJF HMHEELDKLNE, bool CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x83FDE10", Offset = "0x83FD210", VA = "0x1883FDE10")]
	public static string PJOIBDHHFCK(NELIJLIGAOD NICGPJDLKCM, string PEENICAIFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x83FD650", Offset = "0x83FCA50", VA = "0x1883FD650")]
	public static string KNBCNJPFMLL(LEAENBOEFMM HFJHENFIDEF, string PEENICAIFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x83FCF50", Offset = "0x83FC350", VA = "0x1883FCF50")]
	public static bool FEPCPFHNPEN(object HCFCOMCPJPA, object JOCIBENNGKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class PNIAONNMPCP : JECLPACKCAE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly Dictionary<object, object> AFOBPHFGGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly List<string> PKKEEIDHCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly Dictionary<object, object> MEJBBIIDOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<string> DMGEIOKDKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool EGNOAKFAPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	protected readonly Dictionary<string, object> BHGIJOHPLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	protected readonly Dictionary<NELIJLIGAOD, Dictionary<string, object>> DDABJAMNICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<string> OMANJMDHLMO;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public abstract Dictionary<object, object> MJPENOKEBFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public abstract int NDPCPKIELJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public abstract NELIJLIGAOD EAEIDFPEPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public abstract bool IEAAMLFFHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public abstract bool IONLIPOCNKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual bool OIAOGDGOOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool EGBEIIKGJLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA9C690", Offset = "0xA9BA90", VA = "0x180A9C690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3FB0", Offset = "0x3ED33B0", VA = "0x183ED3FB0", Slot = "12")]
	public void HMLKCCGMFLG<T>(string PEENICAIFOP, T CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x83FE4E0", Offset = "0x83FD8E0", VA = "0x1883FE4E0", Slot = "11")]
	public void AJBEPLDGGCG(NELIJLIGAOD NICGPJDLKCM, string PEENICAIFOP, object CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x83FE810", Offset = "0x83FDC10", VA = "0x1883FE810", Slot = "9")]
	public object CPHJMEFPPFA(NELIJLIGAOD NICGPJDLKCM, string PEENICAIFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x84003A0", Offset = "0x83FF7A0", VA = "0x1884003A0", Slot = "10")]
	public void OHGJJFBHDCN(string PEENICAIFOP, object CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x83FF6F0", Offset = "0x83FEAF0", VA = "0x1883FF6F0", Slot = "8")]
	public object GEFFCPFEFKC(string PEENICAIFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x83FFA20", Offset = "0x83FEE20", VA = "0x1883FFA20", Slot = "13")]
	public void GPKGENPEEFH(NELIJLIGAOD KHKEJCOHPIB, string PEENICAIFOP, PALFFNBPPLC LHIMAPPHKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x8400620", Offset = "0x83FFA20", VA = "0x188400620", Slot = "14")]
	public void PPMBAFBGLCP(NELIJLIGAOD KHKEJCOHPIB, string PEENICAIFOP, PALFFNBPPLC LHIMAPPHKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x84004C0", Offset = "0x83FF8C0", VA = "0x1884004C0")]
	private void OPDNKHJKHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x83FEAC0", Offset = "0x83FDEC0", VA = "0x1883FEAC0")]
	private void EECNKBNMEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x83FE900", Offset = "0x83FDD00", VA = "0x1883FE900")]
	private void DHABGFBOFND(NELIJLIGAOD NICGPJDLKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x83FF5C0", Offset = "0x83FE9C0", VA = "0x1883FF5C0")]
	protected void GBIGDEMAOKH(NELIJLIGAOD PBHGJPECGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x84002B0", Offset = "0x83FF6B0", VA = "0x1884002B0")]
	protected void MJJMDLEJJEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x83FFDC0", Offset = "0x83FF1C0", VA = "0x1883FFDC0")]
	protected void LHJADABILIF(IDictionary<object, object> MGDAMNLOJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8400510", Offset = "0x83FF910", VA = "0x188400510")]
	protected void PHPMEBGNLEB(NELIJLIGAOD JKLJPPBAIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x83FE240", Offset = "0x83FD640", VA = "0x1883FE240")]
	protected void ACPGOMMGDPK(NELIJLIGAOD NICGPJDLKCM, IDictionary<object, object> MGDAMNLOJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x83FEC10", Offset = "0x83FE010", VA = "0x1883FEC10")]
	private void ELCKADIMIHE(IDictionary<object, object> MGDAMNLOJHB, Dictionary<string, object> IMGHCJDIPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x83FE2D0", Offset = "0x83FD6D0", VA = "0x1883FE2D0")]
	private static void AHOHFOKCCBA(object HJOEDIKKJDI, object NBOAFDFPIEI, int OBCLHDMACJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x83FF090", Offset = "0x83FE490", VA = "0x1883FF090")]
	private static void FAOINBABCDJ(Dictionary<string, object> IMGHCJDIPCL, string PEENICAIFOP, PALFFNBPPLC LHIMAPPHKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x83FE630", Offset = "0x83FDA30", VA = "0x1883FE630")]
	private static void CMDDKJJBNEC(Dictionary<string, object> IMGHCJDIPCL, string PEENICAIFOP, PALFFNBPPLC LHIMAPPHKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x83FEB10", Offset = "0x83FDF10", VA = "0x1883FEB10", Slot = "17")]
	public void EIDNGOKEOCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	protected abstract void BDJHIILNNMJ(Dictionary<object, object> AFOBPHFGGAO);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x83FFDD0", Offset = "0x83FF1D0", VA = "0x1883FFDD0", Slot = "18")]
	public void LIHLPMFBKBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "28")]
	protected abstract void KCLJMFBMLPE(Dictionary<object, object> MEJBBIIDOFB);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x83FF390", Offset = "0x83FE790", VA = "0x1883FF390")]
	private void FLKGHFKAKBA(Dictionary<object, object> GKDBCNBKNAA, List<string> GOKPKCIEGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x83FF790", Offset = "0x83FEB90", VA = "0x1883FF790")]
	private void GGHBFIJJLNL(IDictionary<object, object> MGDAMNLOJHB, [Out] int OBCLHDMACJL, [Out] string[] PGOMFBJPMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x83FFEB0", Offset = "0x83FF2B0", VA = "0x1883FFEB0")]
	public void LIOFAOLECLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x83FF2C0", Offset = "0x83FE6C0", VA = "0x1883FF2C0")]
	public void FDFDAGJKJIC(NELIJLIGAOD NICGPJDLKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x83FFF40", Offset = "0x83FF340", VA = "0x1883FFF40")]
	public void LLIFJMFFEPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "29")]
	protected abstract HashSet<int> GELNBKGJINH(bool INNCILNEKFP, bool BOBPPCGJFLP);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x83FFB30", Offset = "0x83FEF30", VA = "0x1883FFB30", Slot = "19")]
	public void IFIMAFOCHJN(string KOJGIHKIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x8400580", Offset = "0x83FF980", VA = "0x188400580")]
	protected string PJOIBDHHFCK(NELIJLIGAOD NICGPJDLKCM, string PEENICAIFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract object AJKHJCNMOPC<T>(T CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract T EBCGPCINELB<T>(object CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "32")]
	public virtual void PJOFCLDPLJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x83FE960", Offset = "0x83FDD60", VA = "0x1883FE960", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "33")]
	protected virtual void DOFHJAGNGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x84008D0", Offset = "0x83FFCD0", VA = "0x1884008D0")]
	protected PNIAONNMPCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class IHEBJLKKKCI<T1> : PALFFNBPPLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T1 KLMOEDLINGP;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	protected virtual T1 PKNOMEFHNKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x13F8360", Offset = "0x13F7760", VA = "0x1813F8360", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x50D7530", Offset = "0x50D6930", VA = "0x1850D7530", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	protected override object GAMAAOLDGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4F452E0", Offset = "0x4F446E0", VA = "0x184F452E0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x50DA2D0", Offset = "0x50D96D0", VA = "0x1850DA2D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x50D6DB0", Offset = "0x50D61B0", VA = "0x1850D6DB0", Slot = "9")]
	protected override bool ABHPKAIIEBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x50DB0C0", Offset = "0x50DA4C0", VA = "0x1850DB0C0")]
	protected IHEBJLKKKCI([In] JDHJJDKCDMA NGIAGNLBILI, T1 KLMOEDLINGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x50DBD70", Offset = "0x50DB170", VA = "0x1850DBD70")]
	protected IHEBJLKKKCI(NELIJLIGAOD NICGPJDLKCM, LEAENBOEFMM HFJHENFIDEF, string PEENICAIFOP, T1 KLMOEDLINGP, LDIOPPLNFOK EJMHLNHKOAJ, bool FELGAGEDALA, Action BFDLNHAHOHH, JECLPACKCAE NEPELGPJGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x50D7350", Offset = "0x50D6750", VA = "0x1850D7350")]
	public T1 DIJAEKOIPED()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x50D77C0", Offset = "0x50D6BC0", VA = "0x1850D77C0")]
	public void LFFCNKDPJLH(T1 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x50D83C0", Offset = "0x50D77C0", VA = "0x1850D83C0")]
	public void LFFCNKDPJLH(T1 LEOKHPGPGKC, bool NAMBMCNBHGN, bool GPOBOHNHDCJ = false, bool BJGFLELCBKF = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class HAIPCHDHEJB<T1, T2> : PALFFNBPPLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private T1 KLMOEDLINGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T2 KAKDFLPLKFH;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	protected virtual T1 PKNOMEFHNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x103CE40", Offset = "0x103C240", VA = "0x18103CE40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x124D430", Offset = "0x124C830", VA = "0x18124D430", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	protected virtual T2 DKMCFLHIDDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x10340B0", Offset = "0x10334B0", VA = "0x1810340B0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x103CD40", Offset = "0x103C140", VA = "0x18103CD40", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public T2 MJJFKPNMNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4F45280", Offset = "0x4F44680", VA = "0x184F45280")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	protected override object GAMAAOLDGEM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4F452E0", Offset = "0x4F446E0", VA = "0x184F452E0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4FA2EA0", Offset = "0x4FA22A0", VA = "0x184FA2EA0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4F9C780", Offset = "0x4F9BB80", VA = "0x184F9C780", Slot = "9")]
	protected override bool ABHPKAIIEBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4FA5A00", Offset = "0x4FA4E00", VA = "0x184FA5A00")]
	protected HAIPCHDHEJB([In] JDHJJDKCDMA NGIAGNLBILI, T1 KLMOEDLINGP, T2 KAKDFLPLKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6050", Offset = "0x4FA5450", VA = "0x184FA6050")]
	protected HAIPCHDHEJB(NELIJLIGAOD NICGPJDLKCM, LEAENBOEFMM HFJHENFIDEF, string PEENICAIFOP, T1 KLMOEDLINGP, T2 KAKDFLPLKFH, LDIOPPLNFOK EJMHLNHKOAJ, bool FELGAGEDALA, Action BFDLNHAHOHH, JECLPACKCAE NEPELGPJGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4F45EE0", Offset = "0x4F452E0", VA = "0x184F45EE0")]
	public T1 JBGLDJBHKOP()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x4F9DC00", Offset = "0x4F9D000", VA = "0x184F9DC00")]
	public void EJAADECJOBG(T1 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x4F45280", Offset = "0x4F44680", VA = "0x184F45280")]
	public T2 LJDHIKNOICI()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D980", Offset = "0x4F9CD80", VA = "0x184F9D980")]
	public void CNHOFHIPMOF(T2 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4F9FAE0", Offset = "0x4F9EEE0", VA = "0x184F9FAE0")]
	public void LFFCNKDPJLH(T1 HPPIJLLDJHK, T2 GDOMCIICLNP, bool NAMBMCNBHGN = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class GEBJFIBDEOB<T1, T2, T3> : PALFFNBPPLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private T1 KLMOEDLINGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T2 KAKDFLPLKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private T3 LLGLBHPKDGP;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	protected virtual T1 PKNOMEFHNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA70190", Offset = "0xA6F590", VA = "0x180A70190", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA70380", Offset = "0xA6F780", VA = "0x180A70380", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	protected virtual T2 DKMCFLHIDDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1072D30", Offset = "0x1072130", VA = "0x181072D30", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1073D10", Offset = "0x1073110", VA = "0x181073D10", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	protected virtual T3 GGPHLCNJDOA
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA896A0", Offset = "0xA88AA0", VA = "0x180A896A0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xDD8C20", Offset = "0xDD8020", VA = "0x180DD8C20", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T1 CDPKDHLAKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4F45EE0", Offset = "0x4F452E0", VA = "0x184F45EE0")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T2 MJJFKPNMNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4F45280", Offset = "0x4F44680", VA = "0x184F45280")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T3 HGKOANGOKKO
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4F45F80", Offset = "0x4F45380", VA = "0x184F45F80")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected override object GAMAAOLDGEM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4F452E0", Offset = "0x4F446E0", VA = "0x184F452E0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4F493F0", Offset = "0x4F487F0", VA = "0x184F493F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4F44B50", Offset = "0x4F43F50", VA = "0x184F44B50", Slot = "9")]
	protected override bool ABHPKAIIEBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4F4ABF0", Offset = "0x4F49FF0", VA = "0x184F4ABF0")]
	protected GEBJFIBDEOB([In] JDHJJDKCDMA NGIAGNLBILI, T1 KLMOEDLINGP, T2 KAKDFLPLKFH, T3 LLGLBHPKDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4F4A460", Offset = "0x4F49860", VA = "0x184F4A460")]
	protected GEBJFIBDEOB(NELIJLIGAOD NICGPJDLKCM, LEAENBOEFMM HFJHENFIDEF, string PEENICAIFOP, T1 KLMOEDLINGP, T2 KAKDFLPLKFH, T3 LLGLBHPKDGP, LDIOPPLNFOK EJMHLNHKOAJ, bool FELGAGEDALA, Action BFDLNHAHOHH, JECLPACKCAE NEPELGPJGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4F45EE0", Offset = "0x4F452E0", VA = "0x184F45EE0")]
	public T1 JBGLDJBHKOP()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4F45C50", Offset = "0x4F45050", VA = "0x184F45C50")]
	public void EJAADECJOBG(T1 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4F45280", Offset = "0x4F44680", VA = "0x184F45280")]
	public T2 LJDHIKNOICI()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4F45780", Offset = "0x4F44B80", VA = "0x184F45780")]
	public void CNHOFHIPMOF(T2 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4F45F80", Offset = "0x4F45380", VA = "0x184F45F80")]
	public T3 JIPCFECOBBE()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4F46160", Offset = "0x4F45560", VA = "0x184F46160")]
	public void KJPLJPFEFBJ(T3 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4F47D30", Offset = "0x4F47130", VA = "0x184F47D30")]
	public void LFFCNKDPJLH(T1 HPPIJLLDJHK, T2 GDOMCIICLNP, T3 JOHGPBBIJFC, bool NAMBMCNBHGN = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class POHGJGLFCBE<T1, T2, T3, T4> : PALFFNBPPLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T1 KLMOEDLINGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private T2 KAKDFLPLKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private T3 LLGLBHPKDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private T4 JABFFILGHHH;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	protected virtual T1 PKNOMEFHNKG
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xEF7400", Offset = "0xEF6800", VA = "0x180EF7400", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x58451A0", Offset = "0x58445A0", VA = "0x1858451A0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	protected virtual T2 DKMCFLHIDDB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1F12310", Offset = "0x1F11710", VA = "0x181F12310", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x58478B0", Offset = "0x5846CB0", VA = "0x1858478B0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	protected virtual T3 GGPHLCNJDOA
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5B2B3E0", Offset = "0x5B2A7E0", VA = "0x185B2B3E0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5B2AB80", Offset = "0x5B29F80", VA = "0x185B2AB80", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	protected virtual T4 MIBIEOGKMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1653ED0", Offset = "0x16532D0", VA = "0x181653ED0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x15C24C0", Offset = "0x15C18C0", VA = "0x1815C24C0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public T2 MJJFKPNMNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x4F452A0", Offset = "0x4F446A0", VA = "0x184F452A0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T3 HGKOANGOKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4F45FE0", Offset = "0x4F453E0", VA = "0x184F45FE0")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T4 NMNEKHKNHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x206BF70", Offset = "0x206B370", VA = "0x18206BF70")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	protected override object GAMAAOLDGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x4F452E0", Offset = "0x4F446E0", VA = "0x184F452E0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5B2F110", Offset = "0x5B2E510", VA = "0x185B2F110", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5B290C0", Offset = "0x5B284C0", VA = "0x185B290C0", Slot = "9")]
	protected override bool ABHPKAIIEBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5B303E0", Offset = "0x5B2F7E0", VA = "0x185B303E0")]
	protected POHGJGLFCBE([In] JDHJJDKCDMA NGIAGNLBILI, T1 KLMOEDLINGP, T2 KAKDFLPLKFH, T3 LLGLBHPKDGP, T4 JABFFILGHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5B31AE0", Offset = "0x5B30EE0", VA = "0x185B31AE0")]
	protected POHGJGLFCBE(NELIJLIGAOD NICGPJDLKCM, LEAENBOEFMM HFJHENFIDEF, string PEENICAIFOP, T1 KLMOEDLINGP, T2 KAKDFLPLKFH, T3 LLGLBHPKDGP, T4 JABFFILGHHH, LDIOPPLNFOK EJMHLNHKOAJ, bool FELGAGEDALA, Action BFDLNHAHOHH, JECLPACKCAE NEPELGPJGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x4F45EE0", Offset = "0x4F452E0", VA = "0x184F45EE0")]
	public T1 JBGLDJBHKOP()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5B2AF50", Offset = "0x5B2A350", VA = "0x185B2AF50")]
	public void EJAADECJOBG(T1 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x4F452A0", Offset = "0x4F446A0", VA = "0x184F452A0")]
	public T2 LJDHIKNOICI()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5B2A980", Offset = "0x5B29D80", VA = "0x185B2A980")]
	public void CNHOFHIPMOF(T2 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4F45FE0", Offset = "0x4F453E0", VA = "0x184F45FE0")]
	public T3 JIPCFECOBBE()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5B2BB40", Offset = "0x5B2AF40", VA = "0x185B2BB40")]
	public void KJPLJPFEFBJ(T3 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x206BF70", Offset = "0x206B370", VA = "0x18206BF70")]
	public T4 DMLEILFIKIA()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5B28600", Offset = "0x5B27A00", VA = "0x185B28600")]
	public void ABBIGJECCPO(T4 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5B2D5D0", Offset = "0x5B2C9D0", VA = "0x185B2D5D0")]
	public void LFFCNKDPJLH(T1 HPPIJLLDJHK, T2 GDOMCIICLNP, T3 JOHGPBBIJFC, T4 PFHEAPILKAA, bool NAMBMCNBHGN = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class NOJEOJOCFBG<T1, T2, T3, T4, T5> : PALFFNBPPLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private T1 KLMOEDLINGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T2 KAKDFLPLKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private T3 LLGLBHPKDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private T4 JABFFILGHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private T5 DHJDCOOAGEG;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	protected virtual T1 PKNOMEFHNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xAD90F0", Offset = "0xAD84F0", VA = "0x180AD90F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xAD90E0", Offset = "0xAD84E0", VA = "0x180AD90E0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	protected virtual T2 DKMCFLHIDDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x15825A0", Offset = "0x15819A0", VA = "0x1815825A0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x1581640", Offset = "0x1580A40", VA = "0x181581640", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	protected virtual T3 GGPHLCNJDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA896A0", Offset = "0xA88AA0", VA = "0x180A896A0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xDD8C20", Offset = "0xDD8020", VA = "0x180DD8C20", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	protected virtual T4 MIBIEOGKMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xAA53B0", Offset = "0xAA47B0", VA = "0x180AA53B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xAA5410", Offset = "0xAA4810", VA = "0x180AA5410", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	protected virtual T5 OEFCANKPOOH
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x17A6140", Offset = "0x17A5540", VA = "0x1817A6140", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return (T5)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x17A6CF0", Offset = "0x17A60F0", VA = "0x1817A6CF0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	protected override object GAMAAOLDGEM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4F452E0", Offset = "0x4F446E0", VA = "0x184F452E0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x58478D0", Offset = "0x5846CD0", VA = "0x1858478D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5843FF0", Offset = "0x58433F0", VA = "0x185843FF0", Slot = "9")]
	protected override bool ABHPKAIIEBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5848300", Offset = "0x5847700", VA = "0x185848300")]
	protected NOJEOJOCFBG(NELIJLIGAOD NICGPJDLKCM, LEAENBOEFMM HFJHENFIDEF, string PEENICAIFOP, T1 KLMOEDLINGP, T2 KAKDFLPLKFH, T3 LLGLBHPKDGP, T4 JABFFILGHHH, T5 DHJDCOOAGEG, LDIOPPLNFOK EJMHLNHKOAJ, bool FELGAGEDALA, Action BFDLNHAHOHH, JECLPACKCAE NEPELGPJGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x4F45EE0", Offset = "0x4F452E0", VA = "0x184F45EE0")]
	public T1 JBGLDJBHKOP()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5844FD0", Offset = "0x58443D0", VA = "0x185844FD0")]
	public void EJAADECJOBG(T1 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x4F45280", Offset = "0x4F44680", VA = "0x184F45280")]
	public T2 LJDHIKNOICI()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5844BF0", Offset = "0x5843FF0", VA = "0x185844BF0")]
	public void CNHOFHIPMOF(T2 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4F45F80", Offset = "0x4F45380", VA = "0x184F45F80")]
	public T3 JIPCFECOBBE()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x58459E0", Offset = "0x5844DE0", VA = "0x1858459E0")]
	public void KJPLJPFEFBJ(T3 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x206BF70", Offset = "0x206B370", VA = "0x18206BF70")]
	public T4 DMLEILFIKIA()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x58435B0", Offset = "0x58429B0", VA = "0x1858435B0")]
	public void ABBIGJECCPO(T4 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5844830", Offset = "0x5843C30", VA = "0x185844830")]
	public T5 CJLMDGJOECK()
	{
		return (T5)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x58453A0", Offset = "0x58447A0", VA = "0x1858453A0")]
	public void JLKJPFIELFA(T5 LEOKHPGPGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x58465C0", Offset = "0x58459C0", VA = "0x1858465C0")]
	public void LFFCNKDPJLH(T1 HPPIJLLDJHK, T2 GDOMCIICLNP, T3 JOHGPBBIJFC, T4 PFHEAPILKAA, T5 MLKOLAJGGJG)
	{
	}
}
namespace Cpp2IlInjected;

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
