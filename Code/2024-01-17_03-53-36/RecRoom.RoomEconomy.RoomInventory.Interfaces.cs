using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.RoomEconomy.RoomInventory;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FOKKOEHOCOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly DFCCHBHBBHL IKDDLOFKIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long OBAHNCBLFMM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HJFDENLHKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x65A2FE0", Offset = "0x65A1DE0", VA = "0x1865A2FE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x65A2FF0", Offset = "0x65A1DF0", VA = "0x1865A2FF0")]
	public FOKKOEHOCOC(DFCCHBHBBHL ADPBDOHMAGP, long KGLOPMIHJGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MIIHMEPPAHF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	HiddenWhenNone,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Hidden,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	AlwaysVisibleOnceOwned,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	AlwaysVisible
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JHJMFBDHALE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	AHOMABILGKI EMPFCALIHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	JBCIPMEOJLB<OFHBMPGINID> OMCPGPPLFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	JBCIPMEOJLB<Guid> OIJFIFNMLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IBLNPGMIBPH<MGBJNIEFILA, int> AGHELFPIDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	AHOMABILGKI MIADMLGNNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<CGKJAMMICEF<OFHBMPGINID, string>> MNKMMLLCAMP(long NJOOPBBHHDG, string AOAIBMOPKPE, string HPIOGAHIMCG, string DNLDPIMJDFG, RoomInventoryItemProperties PBCLPGDIOCN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<CGKJAMMICEF<OFHBMPGINID, string>> GFMMGAINCCB(Guid LDPGDDFLPIE, [Optional] string AOAIBMOPKPE, [Optional] string HPIOGAHIMCG, [Optional] string DNLDPIMJDFG, [Optional] RoomInventoryItemProperties PBCLPGDIOCN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<CGKJAMMICEF<bool, string>> JMIIOFIHHGK(Guid LDPGDDFLPIE);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IReadOnlyList<OFHBMPGINID> KOBJIOGMDAP();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IReadOnlyList<OFHBMPGINID> FIPIMIMIOCA();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool GJELOGNCPBI(Guid LDPGDDFLPIE, [Out] OFHBMPGINID AHNAILAEBIP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool JKHKNCABAFA(string DCFDELCICAK, [Out] OFHBMPGINID AHNAILAEBIP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool FAFOKCBKDBN(Guid LDPGDDFLPIE, [Out] MGBJNIEFILA AENFKGKDGNE);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<int> HEKDOPPHPLF(DBPLNALEGHH HDDJHFKECEL, Guid LDPGDDFLPIE);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<FOKKOEHOCOC> CDGCFPDNPCF(DBPLNALEGHH HDDJHFKECEL, Guid LDPGDDFLPIE, int KGANJEKILMM);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	string BBDHHFDGPPB(DFCCHBHBBHL ADPBDOHMAGP);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool EGEOJAOGPKH();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IPGNKGHMLOI : JHJMFBDHALE
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IJGDBJJGAMB(IEnumerable<IBNPLPNMLIB> MKJGKLCBNLD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MGBJNIEFILA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid NPNHAPFOOEM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x65A3410", Offset = "0x65A2210", VA = "0x1865A3410")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HJFDENLHKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x65A3610", Offset = "0x65A2410", VA = "0x1865A3610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long MBLIAHHCNDN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x78E270", Offset = "0x78D070", VA = "0x18078E270")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x78E190", Offset = "0x78CF90", VA = "0x18078E190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long KNPKHGHIGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x78DFA0", Offset = "0x78CDA0", VA = "0x18078DFA0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7951A0", Offset = "0x793FA0", VA = "0x1807951A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Guid? GKEAJGDIHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x797B00", Offset = "0x796900", VA = "0x180797B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x797AD0", Offset = "0x7968D0", VA = "0x180797AD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool EFPCADMBCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x81DF40", Offset = "0x81CD40", VA = "0x18081DF40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x19BC940", Offset = "0x19BB740", VA = "0x1819BC940")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x65A3690", Offset = "0x65A2490", VA = "0x1865A3690")]
	public MGBJNIEFILA(IBNPLPNMLIB PACMPAFGMEN, bool DALDAHDAFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1CEA830", Offset = "0x1CE9630", VA = "0x181CEA830")]
	public MGBJNIEFILA(Guid LDPGDDFLPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x65A3420", Offset = "0x65A2220", VA = "0x1865A3420")]
	internal bool KBHDIJCCCPP(IBNPLPNMLIB PACMPAFGMEN, long EBNEICCIFMJ, Action<MGBJNIEFILA, int> OOINNJKIFPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x65A3630", Offset = "0x65A2430", VA = "0x1865A3630")]
	internal void MICAFBFBMAB(long NFLOGAFPJOI, Action<MGBJNIEFILA, int> OOINNJKIFPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OFHBMPGINID : IEquatable<OFHBMPGINID>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int POEMCDHNPII = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int KIKLGAFHNHB = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int CLMDJOIIAMN = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int JGBCKKCIIND = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid NPNHAPFOOEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xB5EDE0", Offset = "0xB5DBE0", VA = "0x180B5EDE0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1BB96D0", Offset = "0x1BB84D0", VA = "0x181BB96D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long JLPKEBAAFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xE35A10", Offset = "0xE34810", VA = "0x180E35A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string BAAGNNPAEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x78E2A0", Offset = "0x78D0A0", VA = "0x18078E2A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x795720", Offset = "0x794520", VA = "0x180795720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string HDAGEJEGJAK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x78E270", Offset = "0x78D070", VA = "0x18078E270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7944B0", Offset = "0x7932B0", VA = "0x1807944B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string GEBCBHOLJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x78DFA0", Offset = "0x78CDA0", VA = "0x18078DFA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x78E1D0", Offset = "0x78CFD0", VA = "0x18078E1D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DateTime BIJKBHDBBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x78E1F0", Offset = "0x78CFF0", VA = "0x18078E1F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1980E70", Offset = "0x197FC70", VA = "0x181980E70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DateTime LCNMAAPDKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x78E0D0", Offset = "0x78CED0", VA = "0x18078E0D0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x199D2D0", Offset = "0x199C0D0", VA = "0x18199D2D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public RoomInventoryItemProperties FIHONKOGBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x78D1A0", Offset = "0x78BFA0", VA = "0x18078D1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x78D1C0", Offset = "0x78BFC0", VA = "0x18078D1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x65A3B80", Offset = "0x65A2980", VA = "0x1865A3B80")]
	public OFHBMPGINID(LCDIMFBCDOM PACMPAFGMEN, [Optional] RoomInventoryItemProperties PBCLPGDIOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x65A3920", Offset = "0x65A2720", VA = "0x1865A3920", Slot = "4")]
	public bool Equals(OFHBMPGINID GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x65A3740", Offset = "0x65A2540", VA = "0x1865A3740", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x65A3AA0", Offset = "0x65A28A0", VA = "0x1865A3AA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LNDGPDAHONH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private MGBJNIEFILA AENFKGKDGNE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public OFHBMPGINID BKEDNFIJNOH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x78E1A0", Offset = "0x78CFA0", VA = "0x18078E1A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public MGBJNIEFILA AOPFJGIDPOL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x65A3030", Offset = "0x65A1E30", VA = "0x1865A3030")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x78DFC0", Offset = "0x78CDC0", VA = "0x18078DFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x65A30C0", Offset = "0x65A1EC0", VA = "0x1865A30C0")]
	public LNDGPDAHONH(OFHBMPGINID AHNAILAEBIP, [Optional] MGBJNIEFILA AENFKGKDGNE)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RoomInventoryItemProperties : IEquatable<RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const int CURRENT_VERSION = 1;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x65A3DE0", Offset = "0x65A2BE0", VA = "0x1865A3DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x78D180", Offset = "0x78BF80", VA = "0x18078D180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x797AF0", Offset = "0x7968F0", VA = "0x180797AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x909D70", Offset = "0x908B70", VA = "0x180909D70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x909D80", Offset = "0x908B80", VA = "0x180909D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public MIIHMEPPAHF Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7944A0", Offset = "0x7932A0", VA = "0x1807944A0")]
			[CompilerGenerated]
			get
			{
				return default(MIIHMEPPAHF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x794470", Offset = "0x793270", VA = "0x180794470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x65A3CA0", Offset = "0x65A2AA0", VA = "0x1865A3CA0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x65A3CE0", Offset = "0x65A2AE0", VA = "0x1865A3CE0")]
		public static RoomInventoryItemProperties OOCHANHCIPJ(RoomInventoryItemProperties PBCLPGDIOCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1A20980", Offset = "0x1A1F780", VA = "0x181A20980")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class AOOCOFAHDNG
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x65A2F80", Offset = "0x65A1D80", VA = "0x1865A2F80")]
	public static int FLOOCDPKMMP(long KIFKFEJEPBF)
	{
		return default(int);
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
