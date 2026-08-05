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
public class EJOPEEDHNIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly NPIFKMKOOBP CGGLICFNDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long MDLNLAAIONI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EDPBJEJMPCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x65A15C0", Offset = "0x659FFC0", VA = "0x1865A15C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x65A15D0", Offset = "0x659FFD0", VA = "0x1865A15D0")]
	public EJOPEEDHNIH(NPIFKMKOOBP JHJJOGFODKA, long MPNHPMPEEBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum ODFOGLHHOKD
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
public interface BMKHOMHIBMI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	BCNLEBGHOIF JGEBBDPANME
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	BFONFBJGKIG<FAGNGOBDGKJ> PKCHAEFBCDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	BFONFBJGKIG<Guid> GNOAKJCFOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	AJPBOEJFMGB<CGMKIIDJKBN, int> BAMDEAFNCID
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	BCNLEBGHOIF HOBJKMAGGEF
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
	Task<GAFDMEJHKLE<FAGNGOBDGKJ, string>> EPHIAADHGCC(long FKNNHALPBIJ, string CDHDOGOGPME, string EMLIHFKOFEC, string NMDHFOJFGDH, RoomInventoryItemProperties DEOBABCCOJC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<GAFDMEJHKLE<FAGNGOBDGKJ, string>> HLLANBMHHKN(Guid FHDNHNMOONJ, [Optional] string CDHDOGOGPME, [Optional] string EMLIHFKOFEC, [Optional] string NMDHFOJFGDH, [Optional] RoomInventoryItemProperties DEOBABCCOJC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<GAFDMEJHKLE<bool, string>> BDGMLNKANBM(Guid FHDNHNMOONJ);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IReadOnlyList<FAGNGOBDGKJ> LBEDENDJCEK();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IReadOnlyList<FAGNGOBDGKJ> GGALLFMFKOC();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool FBHGJOEDHCN(Guid FHDNHNMOONJ, [Out] FAGNGOBDGKJ IELKPLKKGDF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool GFLGFDFINED(string JGPGDPKDCIL, [Out] FAGNGOBDGKJ IELKPLKKGDF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool EIDGIBPMEKG(Guid FHDNHNMOONJ, [Out] CGMKIIDJKBN LHKCCNGILBG);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<int> CDHIANIPNPB(ALIAPFOBNEL GPBJMOIHKHJ, Guid FHDNHNMOONJ);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<EJOPEEDHNIH> DKPIDCKNAHJ(ALIAPFOBNEL GPBJMOIHKHJ, Guid FHDNHNMOONJ, int MIOOHAFKDAG);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	string NEFDIHCMBFH(NPIFKMKOOBP JHJJOGFODKA);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool GINCIDJBDID();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PKLAEFNKNLK : BMKHOMHIBMI
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOMDDLONBDL(IEnumerable<IEODGBKGDCF> OMCEKNDFBJD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CGMKIIDJKBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid JCCIIJHONMF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x65A1500", Offset = "0x659FF00", VA = "0x1865A1500")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EDPBJEJMPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x65A1480", Offset = "0x659FE80", VA = "0x1865A1480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long OACNGABPODH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x799110", Offset = "0x797B10", VA = "0x180799110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long CBBFABNNIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x793B30", Offset = "0x792530", VA = "0x180793B30")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x793B10", Offset = "0x792510", VA = "0x180793B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Guid? HIPGPMHDDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7965F0", Offset = "0x794FF0", VA = "0x1807965F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x796610", Offset = "0x795010", VA = "0x180796610")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool FEJGLKHPDPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x822840", Offset = "0x821240", VA = "0x180822840")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x19C8570", Offset = "0x19C6F70", VA = "0x1819C8570")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x65A1510", Offset = "0x659FF10", VA = "0x1865A1510")]
	public CGMKIIDJKBN(IEODGBKGDCF HEOFMIBMIKF, bool HFGFDBPILOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1CEA680", Offset = "0x1CE9080", VA = "0x181CEA680")]
	public CGMKIIDJKBN(Guid FHDNHNMOONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x65A1290", Offset = "0x659FC90", VA = "0x1865A1290")]
	internal bool ADFCFFECPNL(IEODGBKGDCF HEOFMIBMIKF, long OFDOPGLCLBL, Action<CGMKIIDJKBN, int> IJJMOKNEAJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x65A14A0", Offset = "0x659FEA0", VA = "0x1865A14A0")]
	internal void EJHAIGBMMHO(long BBECEGNMAFK, Action<CGMKIIDJKBN, int> IJJMOKNEAJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FAGNGOBDGKJ : IEquatable<FAGNGOBDGKJ>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int GPELANLPCFF = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int JKGNNNMMGKB = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int JCEAOJANDAK = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int AMGHKBGLNLE = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid JCCIIJHONMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xB51900", Offset = "0xB50300", VA = "0x180B51900")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1BCA120", Offset = "0x1BC8B20", VA = "0x181BCA120")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long IFMPGLDOIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xE36AB0", Offset = "0xE354B0", VA = "0x180E36AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string JHMJHFOLNND
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x793910", Offset = "0x792310", VA = "0x180793910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x793D30", Offset = "0x792730", VA = "0x180793D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string DEMOCGJNFGH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x79A7B0", Offset = "0x7991B0", VA = "0x18079A7B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string HCCONPMFDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x793B30", Offset = "0x792530", VA = "0x180793B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x799100", Offset = "0x797B00", VA = "0x180799100")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DateTime OOPHGPPBHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x793D40", Offset = "0x792740", VA = "0x180793D40")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x197CE10", Offset = "0x197B810", VA = "0x18197CE10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DateTime FAEIIGEAHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7976F0", Offset = "0x7960F0", VA = "0x1807976F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x19A3100", Offset = "0x19A1B00", VA = "0x1819A3100")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public RoomInventoryItemProperties CEDHPFPINDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x78FC90", Offset = "0x78E690", VA = "0x18078FC90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x78FCA0", Offset = "0x78E6A0", VA = "0x18078FCA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x65A1A50", Offset = "0x65A0450", VA = "0x1865A1A50")]
	public FAGNGOBDGKJ(IEOEFDACFOK HEOFMIBMIKF, [Optional] RoomInventoryItemProperties DEOBABCCOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x65A1610", Offset = "0x65A0010", VA = "0x1865A1610", Slot = "4")]
	public bool Equals(FAGNGOBDGKJ CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x65A1790", Offset = "0x65A0190", VA = "0x1865A1790", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x65A1970", Offset = "0x65A0370", VA = "0x1865A1970", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NLAABEDMCMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private CGMKIIDJKBN LHKCCNGILBG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public FAGNGOBDGKJ OEECHCBKBMM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x790420", Offset = "0x78EE20", VA = "0x180790420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public CGMKIIDJKBN KNBBJDGBILF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x65A1BD0", Offset = "0x65A05D0", VA = "0x1865A1BD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x790C90", Offset = "0x78F690", VA = "0x180790C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x65A1C60", Offset = "0x65A0660", VA = "0x1865A1C60")]
	public NLAABEDMCMP(FAGNGOBDGKJ IELKPLKKGDF, [Optional] CGMKIIDJKBN LHKCCNGILBG)
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
			[Cpp2IlInjected.Address(RVA = "0x65A20F0", Offset = "0x65A0AF0", VA = "0x1865A20F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x78E180", Offset = "0x78CB80", VA = "0x18078E180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7965B0", Offset = "0x794FB0", VA = "0x1807965B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x90C000", Offset = "0x90AA00", VA = "0x18090C000")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x90BFF0", Offset = "0x90A9F0", VA = "0x18090BFF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ODFOGLHHOKD Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7977F0", Offset = "0x7961F0", VA = "0x1807977F0")]
			[CompilerGenerated]
			get
			{
				return default(ODFOGLHHOKD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x79A7C0", Offset = "0x7991C0", VA = "0x18079A7C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x65A2030", Offset = "0x65A0A30", VA = "0x1865A2030", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x65A1FB0", Offset = "0x65A09B0", VA = "0x1865A1FB0")]
		public static RoomInventoryItemProperties EGBGIHNMJKJ(RoomInventoryItemProperties DEOBABCCOJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1A248A0", Offset = "0x1A232A0", VA = "0x181A248A0")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class GPJNLGLEAEP
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x65A1B70", Offset = "0x65A0570", VA = "0x1865A1B70")]
	public static int MBOBFLGJODF(long PGGNNGJLAEL)
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
