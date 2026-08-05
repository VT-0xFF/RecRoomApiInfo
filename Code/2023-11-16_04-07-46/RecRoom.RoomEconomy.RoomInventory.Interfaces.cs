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
public class FGKKKEGHICN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly PKKIMENHNGG GPGFJEGPJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long PLKFCNLILAN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int LDGAMAKKAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63A1320", Offset = "0x63A0320", VA = "0x1863A1320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63A1330", Offset = "0x63A0330", VA = "0x1863A1330")]
	public FGKKKEGHICN(PKKIMENHNGG BBMBCGDLBEE, long AGLAJIDEGHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ONOOHLJEPML
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	DNHICBJBOMM ENJKBBKPDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	JEHDIEPKPPJ<JPHHPNFKNLF> BGIHOEDPOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	JEHDIEPKPPJ<Guid> CGOLMOAEMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	ALEHNDJPFCG<ABCOBHKFKOG, int> GKMNGIDPAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	DNHICBJBOMM BKGBJAFCENC
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
	Task<CJDJPCEAKND<JPHHPNFKNLF, string>> KLKCPMAPAII(long KAOIBEOBDCN, string JNMEJDHMADI, string BEOAJBBECNO, string GBFFJBCAJEE, RoomInventoryItemProperties CDJFMFMBDBN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<CJDJPCEAKND<JPHHPNFKNLF, string>> OIFOCGEGJJF(Guid MLKBMJHEECD, [Optional] string JNMEJDHMADI, [Optional] string BEOAJBBECNO, [Optional] string GBFFJBCAJEE, [Optional] RoomInventoryItemProperties CDJFMFMBDBN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<CJDJPCEAKND<bool, string>> OCNFICADLHM(Guid MLKBMJHEECD);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IReadOnlyList<JPHHPNFKNLF> PJIJHPAEMHB();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IReadOnlyList<JPHHPNFKNLF> MLPIFHIMBAD();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool IHHBMJLBILI(Guid MLKBMJHEECD, [Out] JPHHPNFKNLF MLGPKIPPFPH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool FLACKGFIKIN(Guid MLKBMJHEECD, [Out] ABCOBHKFKOG BOJCAHJGJNI);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<int> LENLNOLPEBG(HANCNHADEOE ADFODKEMPJP, Guid MLKBMJHEECD);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<FGKKKEGHICN> NCIDBFDHGLE(HANCNHADEOE ADFODKEMPJP, Guid MLKBMJHEECD, int EONCDFNJNJB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	string LGGCIDBBGDH(PKKIMENHNGG BBMBCGDLBEE);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool LKBJBGOMIIO();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class ABCOBHKFKOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid NGLMNDAJPFG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x63A1200", Offset = "0x63A0200", VA = "0x1863A1200")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int LDGAMAKKAJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x63A1180", Offset = "0x63A0180", VA = "0x1863A1180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long DAIGIJEFPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x76F1D0", Offset = "0x76E1D0", VA = "0x18076F1D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x774F40", Offset = "0x773F40", VA = "0x180774F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long IJEOCECHELC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x774F60", Offset = "0x773F60", VA = "0x180774F60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x779FF0", Offset = "0x778FF0", VA = "0x180779FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Guid? BKDBPHNIBEI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x77AFD0", Offset = "0x779FD0", VA = "0x18077AFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x77B010", Offset = "0x77A010", VA = "0x18077B010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool HABFLLAEHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7E3AA0", Offset = "0x7E2AA0", VA = "0x1807E3AA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x193EB30", Offset = "0x193DB30", VA = "0x18193EB30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x63A1210", Offset = "0x63A0210", VA = "0x1863A1210")]
	public ABCOBHKFKOG(AJPEIDKCPJG EAMGFMPJEGG, bool PPGBIGKECIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1C91B30", Offset = "0x1C90B30", VA = "0x181C91B30")]
	public ABCOBHKFKOG(Guid MLKBMJHEECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x63A0F90", Offset = "0x639FF90", VA = "0x1863A0F90")]
	internal bool HOEJNKLEAPP(AJPEIDKCPJG EAMGFMPJEGG, long MGIMBBKENJB, Action<ABCOBHKFKOG, int> CHBKDMHNHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x63A11A0", Offset = "0x63A01A0", VA = "0x1863A11A0")]
	internal void OFAFMJBAAAO(long BMNGBPPHACH, Action<ABCOBHKFKOG, int> CHBKDMHNHPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JPHHPNFKNLF : IEquatable<JPHHPNFKNLF>
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public const int FONLCEGOOFH = 3;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int NDIOPPCHHBH = 25;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const int OLJFGKNFNFL = 180;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public const int OKNEIJJEHNO = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid NGLMNDAJPFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAF06A0", Offset = "0xAEF6A0", VA = "0x180AF06A0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1B3D060", Offset = "0x1B3C060", VA = "0x181B3D060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long AFIMLDIFEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xDC27D0", Offset = "0xDC17D0", VA = "0x180DC27D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string GMOLFEBHJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x76F1C0", Offset = "0x76E1C0", VA = "0x18076F1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x76F190", Offset = "0x76E190", VA = "0x18076F190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string HEKCOHALFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x76F1D0", Offset = "0x76E1D0", VA = "0x18076F1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x76F220", Offset = "0x76E220", VA = "0x18076F220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string MNOPODINEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x774F60", Offset = "0x773F60", VA = "0x180774F60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x774F80", Offset = "0x773F80", VA = "0x180774F80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DateTime EAIONAPHOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x779C40", Offset = "0x778C40", VA = "0x180779C40")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x18F5D60", Offset = "0x18F4D60", VA = "0x1818F5D60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DateTime FAFHGMBBOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x774F20", Offset = "0x773F20", VA = "0x180774F20")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1912D30", Offset = "0x1911D30", VA = "0x181912D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public RoomInventoryItemProperties CBOKFHKIDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7738C0", Offset = "0x7728C0", VA = "0x1807738C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7738F0", Offset = "0x7728F0", VA = "0x1807738F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x63A17B0", Offset = "0x63A07B0", VA = "0x1863A17B0")]
	public JPHHPNFKNLF(DCMKDEPMOJP EAMGFMPJEGG, [Optional] RoomInventoryItemProperties CDJFMFMBDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x63A1550", Offset = "0x63A0550", VA = "0x1863A1550", Slot = "4")]
	public bool Equals(JPHHPNFKNLF EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x63A1370", Offset = "0x63A0370", VA = "0x1863A1370", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x63A16D0", Offset = "0x63A06D0", VA = "0x1863A16D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MPAKKJJBFGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private ABCOBHKFKOG BOJCAHJGJNI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public JPHHPNFKNLF NAGCHKAHACH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x76F1B0", Offset = "0x76E1B0", VA = "0x18076F1B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ABCOBHKFKOG LJJAKAOBMAI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x63A18D0", Offset = "0x63A08D0", VA = "0x1863A18D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x76F1A0", Offset = "0x76E1A0", VA = "0x18076F1A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x63A1960", Offset = "0x63A0960", VA = "0x1863A1960")]
	public MPAKKJJBFGP(JPHHPNFKNLF MLGPKIPPFPH, [Optional] ABCOBHKFKOG BOJCAHJGJNI)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class RoomInventoryItemProperties : IEquatable<RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private const int CURRENT_VERSION = 1;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x63A1DE0", Offset = "0x63A0DE0", VA = "0x1863A1DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x76F180", Offset = "0x76E180", VA = "0x18076F180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x77AFF0", Offset = "0x779FF0", VA = "0x18077AFF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8AABC0", Offset = "0x8A9BC0", VA = "0x1808AABC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8AABD0", Offset = "0x8A9BD0", VA = "0x1808AABD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x63A1CB0", Offset = "0x63A0CB0", VA = "0x1863A1CB0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties EJEDDDCGMMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x63A1CE0", Offset = "0x63A0CE0", VA = "0x1863A1CE0")]
		public static RoomInventoryItemProperties FFPOMLNLONK(RoomInventoryItemProperties CDJFMFMBDBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1993700", Offset = "0x1992700", VA = "0x181993700")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal static class CAPAHMLFLDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x63A12C0", Offset = "0x63A02C0", VA = "0x1863A12C0")]
	public static int KLCECJKJBMA(long CDOOMMABEBM)
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
