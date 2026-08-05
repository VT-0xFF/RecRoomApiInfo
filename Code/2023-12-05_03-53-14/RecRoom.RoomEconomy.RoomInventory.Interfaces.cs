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
public class JGIKHKEHOPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly BIIHBAGPKAD DGBIOOCKDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long AEFHJLMLIJL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BPGHEFKCIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63C2130", Offset = "0x63C1530", VA = "0x1863C2130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63C2140", Offset = "0x63C1540", VA = "0x1863C2140")]
	public JGIKHKEHOPL(BIIHBAGPKAD KHFCBCPBAFG, long APAKJDHFMCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OKJODBIKKPC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	FCJKIAIKOOM JOJLFBFFJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	CFBCANLCDFG<GKJHCGFPIFA> GGJNEDOHJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	CFBCANLCDFG<Guid> PPFOMBJJNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HHJEIKBAAJF<MFNNMIAIDEA, int> GKLFFOHAAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	FCJKIAIKOOM MHLBBJDKHBG
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
	Task<EFPDAHOJLMO<GKJHCGFPIFA, string>> PCCMHHJLEEO(long IIAJMJMGGCI, string MDFAJJKMBAI, string DACNCMKHPFB, string GLPHFKBONKA, RoomInventoryItemProperties ELDLHEJCIMN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<EFPDAHOJLMO<GKJHCGFPIFA, string>> GIJPABDGHIC(Guid DFIBPBBEFMB, [Optional] string MDFAJJKMBAI, [Optional] string DACNCMKHPFB, [Optional] string GLPHFKBONKA, [Optional] RoomInventoryItemProperties ELDLHEJCIMN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<EFPDAHOJLMO<bool, string>> HCEKAALCPLG(Guid DFIBPBBEFMB);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IReadOnlyList<GKJHCGFPIFA> IDLCCOAMEEC();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IReadOnlyList<GKJHCGFPIFA> CBLBDPEDIKM();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool AJJCOMKDBGB(Guid DFIBPBBEFMB, [Out] GKJHCGFPIFA PDFDPKIIMJO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool CHBMOJNHMLB(Guid DFIBPBBEFMB, [Out] MFNNMIAIDEA AOELHFMFODD);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<int> PFOHMEJECLI(MCGPJKMOCMD IFMBCNELBJG, Guid DFIBPBBEFMB);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<JGIKHKEHOPL> NNOCNOMPNAB(MCGPJKMOCMD IFMBCNELBJG, Guid DFIBPBBEFMB, int BDILOJCLFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	string JJECPFLIDLD(BIIHBAGPKAD KHFCBCPBAFG);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool OAEEKENBMFG();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EHJEJFKCPMJ : OKJODBIKKPC
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJJIIMLEBCG(IEnumerable<PIHBOOPCEPM> LLANOKJEKLP);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MFNNMIAIDEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid OEDAJDPCPGN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x63C2180", Offset = "0x63C1580", VA = "0x1863C2180")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int BPGHEFKCIOB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x63C21F0", Offset = "0x63C15F0", VA = "0x1863C21F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long HKBMJHGFEID
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x773830", Offset = "0x772C30", VA = "0x180773830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long JOKNNNBFPDO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x773AA0", Offset = "0x772EA0", VA = "0x180773AA0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7756B0", Offset = "0x774AB0", VA = "0x1807756B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Guid? FDDFOJJOOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x77EAA0", Offset = "0x77DEA0", VA = "0x18077EAA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x77EA80", Offset = "0x77DE80", VA = "0x18077EA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool POENNECAMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8192A0", Offset = "0x8186A0", VA = "0x1808192A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x196AC10", Offset = "0x196A010", VA = "0x18196AC10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x63C2400", Offset = "0x63C1800", VA = "0x1863C2400")]
	public MFNNMIAIDEA(PIHBOOPCEPM HEHNJPPHPPK, bool GILKGMPNOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1CA33B0", Offset = "0x1CA27B0", VA = "0x181CA33B0")]
	public MFNNMIAIDEA(Guid DFIBPBBEFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x63C2210", Offset = "0x63C1610", VA = "0x1863C2210")]
	internal bool LFKJJNEOHNN(PIHBOOPCEPM HEHNJPPHPPK, long PEKCJODLEDG, Action<MFNNMIAIDEA, int> NIIDBGIIJDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x63C2190", Offset = "0x63C1590", VA = "0x1863C2190")]
	internal void IFEDIBDFFOI(long OFNJFLKPKGN, Action<MFNNMIAIDEA, int> NIIDBGIIJDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GKJHCGFPIFA : IEquatable<GKJHCGFPIFA>
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public const int FMGEDPMKIAG = 3;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int OICBHGJNGJC = 25;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const int HDBLBOLCEBA = 180;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public const int HEHMHIKBBBL = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid OEDAJDPCPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xB18F40", Offset = "0xB18340", VA = "0x180B18F40")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1B6F580", Offset = "0x1B6E980", VA = "0x181B6F580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long PHFFEMHIMBO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xDF9B60", Offset = "0xDF8F60", VA = "0x180DF9B60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string MFBMONNEDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x773860", Offset = "0x772C60", VA = "0x180773860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x775A50", Offset = "0x774E50", VA = "0x180775A50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string DHHAABGOONI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x77A180", Offset = "0x779580", VA = "0x18077A180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string KKIADBCIHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x773AA0", Offset = "0x772EA0", VA = "0x180773AA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x773890", Offset = "0x772C90", VA = "0x180773890")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DateTime PCIGNLGHAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x775860", Offset = "0x774C60", VA = "0x180775860")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1928BA0", Offset = "0x1927FA0", VA = "0x181928BA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DateTime MNAMFMJEHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x770B10", Offset = "0x76FF10", VA = "0x180770B10")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1951C20", Offset = "0x1951020", VA = "0x181951C20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public RoomInventoryItemProperties PJJPDIKMALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x778420", Offset = "0x777820", VA = "0x180778420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x778410", Offset = "0x777810", VA = "0x180778410")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x63C1C30", Offset = "0x63C1030", VA = "0x1863C1C30")]
	public GKJHCGFPIFA(GELOHPEDFJO HEHNJPPHPPK, [Optional] RoomInventoryItemProperties ELDLHEJCIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x63C19D0", Offset = "0x63C0DD0", VA = "0x1863C19D0", Slot = "4")]
	public bool Equals(GKJHCGFPIFA LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x63C17F0", Offset = "0x63C0BF0", VA = "0x1863C17F0", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x63C1B50", Offset = "0x63C0F50", VA = "0x1863C1B50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HEHLHHNPGNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private MFNNMIAIDEA AOELHFMFODD;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GKJHCGFPIFA KPLNBACAKNM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x773880", Offset = "0x772C80", VA = "0x180773880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public MFNNMIAIDEA BMFHKGAKCJE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x63C1D50", Offset = "0x63C1150", VA = "0x1863C1D50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x773840", Offset = "0x772C40", VA = "0x180773840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x63C1DE0", Offset = "0x63C11E0", VA = "0x1863C1DE0")]
	public HEHLHHNPGNN(GKJHCGFPIFA PDFDPKIIMJO, [Optional] MFNNMIAIDEA AOELHFMFODD)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class RoomInventoryItemProperties : IEquatable<RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private const int CURRENT_VERSION = 1;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x63C25E0", Offset = "0x63C19E0", VA = "0x1863C25E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x77EAC0", Offset = "0x77DEC0", VA = "0x18077EAC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8D0AD0", Offset = "0x8CFED0", VA = "0x1808D0AD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8D0AE0", Offset = "0x8CFEE0", VA = "0x1808D0AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x63C2530", Offset = "0x63C1930", VA = "0x1863C2530", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x63C24B0", Offset = "0x63C18B0", VA = "0x1863C24B0")]
		public static RoomInventoryItemProperties AIMPIJCKBBE(RoomInventoryItemProperties ELDLHEJCIMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x19D63E0", Offset = "0x19D57E0", VA = "0x1819D63E0")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class CBMLCNNOEBE
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x63C1790", Offset = "0x63C0B90", VA = "0x1863C1790")]
	public static int LMEKBCPMFNA(long LJGBMIIMMGB)
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
