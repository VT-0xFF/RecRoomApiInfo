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
public class FPJCFMOFEDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly PPAGBCHEHMP BOEMLEMFLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long BMGCAELLGLF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NLBBDJHCELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x639A740", Offset = "0x6399540", VA = "0x18639A740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x639A750", Offset = "0x6399550", VA = "0x18639A750")]
	public FPJCFMOFEDL(PPAGBCHEHMP OKONIBAEEBP, long PDNIMDHODLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ICIJMFGBHFA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	INNFNKFCEKE IMHFEGICPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	BJPKLEOBMLD<MGCBPCGAGDM> NCOCGGBPLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	BJPKLEOBMLD<Guid> BPLBJBMIEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EEDIFKNBKON<ANMGOHDDFHD, int> JBGFBGKODIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	INNFNKFCEKE DIMGABCDIJG
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
	Task<EFFPFBGFCJB<MGCBPCGAGDM, string>> KGPFKBAPOLF(long GCFELHFPIGG, string NDLLBBKGIJD, string HBNFGFDAEMN, string JJGDEEOHCJI, RoomInventoryItemProperties GLPHNLMJMNF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<EFFPFBGFCJB<MGCBPCGAGDM, string>> DGDKADGCBND(Guid EFLGAAKBPNM, [Optional] string NDLLBBKGIJD, [Optional] string HBNFGFDAEMN, [Optional] string JJGDEEOHCJI, [Optional] RoomInventoryItemProperties GLPHNLMJMNF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<EFFPFBGFCJB<bool, string>> KNIAHIGDBBL(Guid EFLGAAKBPNM);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IReadOnlyList<MGCBPCGAGDM> ADHPJOGPMLL();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IReadOnlyList<MGCBPCGAGDM> CCFNOEFADCG();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool KGPOELIEKKP(Guid EFLGAAKBPNM, [Out] MGCBPCGAGDM PGLLDFKDNLN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool NAEBGHHOBPL(Guid EFLGAAKBPNM, [Out] ANMGOHDDFHD IOCHDPKANIF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<int> EMEMFIOLLOP(IPAKCCOJEDA CDPDNIBBMJC, Guid EFLGAAKBPNM);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<FPJCFMOFEDL> LFNMCOKMBNE(IPAKCCOJEDA CDPDNIBBMJC, Guid EFLGAAKBPNM, int BIKONKGEBKA);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	string MHDJPOMJJOA(PPAGBCHEHMP OKONIBAEEBP);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool BIPJIDKOECI();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class ANMGOHDDFHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid DHGPOPDFFCJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x639A410", Offset = "0x6399210", VA = "0x18639A410")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NLBBDJHCELM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x639A420", Offset = "0x6399220", VA = "0x18639A420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long IHKLIJHNOJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x772C00", Offset = "0x771A00", VA = "0x180772C00")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x772C30", Offset = "0x771A30", VA = "0x180772C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long JHCJDLKEAMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7729F0", Offset = "0x7717F0", VA = "0x1807729F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7797E0", Offset = "0x7785E0", VA = "0x1807797E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Guid? HCIKLKDONHF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x775E60", Offset = "0x774C60", VA = "0x180775E60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x775E20", Offset = "0x774C20", VA = "0x180775E20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool HFNIICKKHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7E1F10", Offset = "0x7E0D10", VA = "0x1807E1F10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x192B460", Offset = "0x192A260", VA = "0x18192B460")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x639A690", Offset = "0x6399490", VA = "0x18639A690")]
	public ANMGOHDDFHD(EHMCEMNBBGM EFAINFPKKCG, bool JIPJGFLFLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1C90D80", Offset = "0x1C8FB80", VA = "0x181C90D80")]
	public ANMGOHDDFHD(Guid EFLGAAKBPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x639A440", Offset = "0x6399240", VA = "0x18639A440")]
	internal bool KHHFOFCHJNL(EHMCEMNBBGM EFAINFPKKCG, long HEJKCIBKMNH, Action<ANMGOHDDFHD, int> CIBMEPFNBPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x639A630", Offset = "0x6399430", VA = "0x18639A630")]
	internal void NAIADLPCBJG(long KGGFKPELLGB, Action<ANMGOHDDFHD, int> CIBMEPFNBPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MGCBPCGAGDM : IEquatable<MGCBPCGAGDM>
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public const int HGEOEENMINF = 3;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int HEEMBCKNBIJ = 25;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const int PJLFACHHMAC = 180;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public const int AJEOMICEPIC = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid DHGPOPDFFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAFA210", Offset = "0xAF9010", VA = "0x180AFA210")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1B3E8C0", Offset = "0x1B3D6C0", VA = "0x181B3E8C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long BAGGFIANPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x775E10", Offset = "0x774C10", VA = "0x180775E10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xDC2630", Offset = "0xDC1430", VA = "0x180DC2630")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string NKCKPGIEOEO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x772C10", Offset = "0x771A10", VA = "0x180772C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x779B70", Offset = "0x778970", VA = "0x180779B70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string JPMHFKJJBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x772C00", Offset = "0x771A00", VA = "0x180772C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x777020", Offset = "0x775E20", VA = "0x180777020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string OAKEDJIMHDA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7729F0", Offset = "0x7717F0", VA = "0x1807729F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7729C0", Offset = "0x7717C0", VA = "0x1807729C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DateTime MLLCNDFLNNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x779D70", Offset = "0x778B70", VA = "0x180779D70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x18F1040", Offset = "0x18EFE40", VA = "0x1818F1040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DateTime CFDPFLGHCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7729D0", Offset = "0x7717D0", VA = "0x1807729D0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1909BB0", Offset = "0x19089B0", VA = "0x181909BB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public RoomInventoryItemProperties HOCNMENCMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x76FF50", Offset = "0x76ED50", VA = "0x18076FF50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x76FF40", Offset = "0x76ED40", VA = "0x18076FF40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x639AC30", Offset = "0x6399A30", VA = "0x18639AC30")]
	public MGCBPCGAGDM(PJPAAOMBAJC EFAINFPKKCG, [Optional] RoomInventoryItemProperties GLPHNLMJMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x639A7F0", Offset = "0x63995F0", VA = "0x18639A7F0", Slot = "4")]
	public bool Equals(MGCBPCGAGDM LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x639A970", Offset = "0x6399770", VA = "0x18639A970", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x639AB50", Offset = "0x6399950", VA = "0x18639AB50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MMMEHOBMFHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private ANMGOHDDFHD IOCHDPKANIF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MGCBPCGAGDM PLLJPNCAFBK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x770F00", Offset = "0x76FD00", VA = "0x180770F00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ANMGOHDDFHD GFABAKOKJDA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x639AD50", Offset = "0x6399B50", VA = "0x18639AD50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x770C70", Offset = "0x76FA70", VA = "0x180770C70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x639ADE0", Offset = "0x6399BE0", VA = "0x18639ADE0")]
	public MMMEHOBMFHA(MGCBPCGAGDM PGLLDFKDNLN, [Optional] ANMGOHDDFHD IOCHDPKANIF)
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
			[Cpp2IlInjected.Address(RVA = "0x639B260", Offset = "0x639A060", VA = "0x18639B260")]
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
			[Cpp2IlInjected.Address(RVA = "0x76E180", Offset = "0x76CF80", VA = "0x18076E180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x775E30", Offset = "0x774C30", VA = "0x180775E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x897370", Offset = "0x896170", VA = "0x180897370")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x896160", VA = "0x180897360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x639B130", Offset = "0x6399F30", VA = "0x18639B130", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x639B160", Offset = "0x6399F60", VA = "0x18639B160")]
		public static RoomInventoryItemProperties FOIBINFCENC(RoomInventoryItemProperties GLPHNLMJMNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1993F50", Offset = "0x1992D50", VA = "0x181993F50")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal static class HOLJGMIFHDF
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x639A790", Offset = "0x6399590", VA = "0x18639A790")]
	public static int PDKFGCANMHG(long JGOCNJGMCOP)
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
