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
public class AJAAGNJONEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly MCLJJCPFAPD DPPDJIKGIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long CADPCMFLDGP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GIMJDNGMJPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63C03E0", Offset = "0x63BEBE0", VA = "0x1863C03E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63C03F0", Offset = "0x63BEBF0", VA = "0x1863C03F0")]
	public AJAAGNJONEM(MCLJJCPFAPD MLABNLLFODC, long PPKDCOOCBKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GCHAGFCDJLG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	LJECGABKDKN FEBIKPGPJNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	LBEDKEAJHCP<CMOKHCGMAFA> KCACMDHMIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	LBEDKEAJHCP<Guid> PENOLDHFNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KEHAGKJIEAC<DKMFHHIAGEF, int> BHOGFKBGHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LJECGABKDKN ECECIJJMJKM
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
	Task<LBFOJMHFNLD<CMOKHCGMAFA, string>> AHFJIGGIMCF(long AKDANPAICOC, string PMDCAPIFBIP, string MMOFPMCDOKA, string KMHKMMMDMNC, RoomInventoryItemProperties MJBJHGOBNAE);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<LBFOJMHFNLD<CMOKHCGMAFA, string>> LBOMIKICCLH(Guid ECJOFIKMMDJ, [Optional] string PMDCAPIFBIP, [Optional] string MMOFPMCDOKA, [Optional] string KMHKMMMDMNC, [Optional] RoomInventoryItemProperties MJBJHGOBNAE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<LBFOJMHFNLD<bool, string>> BLGKBHEDBJJ(Guid ECJOFIKMMDJ);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IReadOnlyList<CMOKHCGMAFA> IBIFBJHOMGA();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IReadOnlyList<CMOKHCGMAFA> BKBPAPHKCGJ();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool CMFNCKEHFEC(Guid ECJOFIKMMDJ, [Out] CMOKHCGMAFA KJFBIBIIMEF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool AGMIANHEALO(Guid ECJOFIKMMDJ, [Out] DKMFHHIAGEF MBLHLDEBPCD);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<int> AINHPPOBIHK(PDJKNJCPPID DDADADFKCOE, Guid ECJOFIKMMDJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<AJAAGNJONEM> OEFPIKMBMED(PDJKNJCPPID DDADADFKCOE, Guid ECJOFIKMMDJ, int AAEHEHHJFMP);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	string HBLKBBLACED(MCLJJCPFAPD MLABNLLFODC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool IBPIDHKAAAM();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void Dispose();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IOGFFOKCNPK : GCHAGFCDJLG
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCKGBCAGJNK(IEnumerable<CBJOJIEDCJM> BKAKJPLIKPL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DKMFHHIAGEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly Guid CGKGKCIEBKJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x63C0A10", Offset = "0x63BF210", VA = "0x1863C0A10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int GIMJDNGMJPB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x63C0990", Offset = "0x63BF190", VA = "0x1863C0990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long JLJIIJIBOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x773B40", Offset = "0x772340", VA = "0x180773B40")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x77D7C0", Offset = "0x77BFC0", VA = "0x18077D7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long PBIFJGKALCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x778B40", Offset = "0x777340", VA = "0x180778B40")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x778B10", Offset = "0x777310", VA = "0x180778B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Guid? GKGGOCLCFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x77C530", Offset = "0x77AD30", VA = "0x18077C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x77C560", Offset = "0x77AD60", VA = "0x18077C560")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool ENGLPFKPPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8132D0", Offset = "0x811AD0", VA = "0x1808132D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x196C030", Offset = "0x196A830", VA = "0x18196C030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x63C0C10", Offset = "0x63BF410", VA = "0x1863C0C10")]
	public DKMFHHIAGEF(CBJOJIEDCJM LOIBPBJGMEA, bool CKBGFKBEFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1CA43B0", Offset = "0x1CA2BB0", VA = "0x181CA43B0")]
	public DKMFHHIAGEF(Guid ECJOFIKMMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x63C0A20", Offset = "0x63BF220", VA = "0x1863C0A20")]
	internal bool OMANMGAMPNF(CBJOJIEDCJM LOIBPBJGMEA, long AJIBHAKNCJG, Action<DKMFHHIAGEF, int> EONOILKAILA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x63C09B0", Offset = "0x63BF1B0", VA = "0x1863C09B0")]
	internal void IJDEFIEINKL(long KLBCFENGHBA, Action<DKMFHHIAGEF, int> EONOILKAILA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CMOKHCGMAFA : IEquatable<CMOKHCGMAFA>
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public const int JKIKHFJIBKP = 3;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int CDNCFJKDBHD = 25;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const int PMHBHOIMFEH = 180;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public const int GFPPNKOALPH = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid CGKGKCIEBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xB2AA00", Offset = "0xB29200", VA = "0x180B2AA00")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1B7B790", Offset = "0x1B79F90", VA = "0x181B7B790")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long BIGMFDGONPD
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xDFAB60", Offset = "0xDF9360", VA = "0x180DFAB60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string JOBPEPKBADK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7790D0", Offset = "0x7778D0", VA = "0x1807790D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x778B30", Offset = "0x777330", VA = "0x180778B30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string GHLGOPCAHEN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x773B40", Offset = "0x772340", VA = "0x180773B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x773B70", Offset = "0x772370", VA = "0x180773B70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string BOLCNNPHBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x778B40", Offset = "0x777340", VA = "0x180778B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x77D860", Offset = "0x77C060", VA = "0x18077D860")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DateTime HBDFLKNEOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x778B20", Offset = "0x777320", VA = "0x180778B20")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x193B340", Offset = "0x1939B40", VA = "0x18193B340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DateTime FPBNLNCEGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7771E0", Offset = "0x7759E0", VA = "0x1807771E0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1950A50", Offset = "0x194F250", VA = "0x181950A50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public RoomInventoryItemProperties DEEPPFGKDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x772C80", Offset = "0x771480", VA = "0x180772C80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x772CA0", Offset = "0x7714A0", VA = "0x180772CA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x63C0870", Offset = "0x63BF070", VA = "0x1863C0870")]
	public CMOKHCGMAFA(EIEMCAIMBAE LOIBPBJGMEA, [Optional] RoomInventoryItemProperties MJBJHGOBNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x63C0610", Offset = "0x63BEE10", VA = "0x1863C0610", Slot = "4")]
	public bool Equals(CMOKHCGMAFA FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x63C0430", Offset = "0x63BEC30", VA = "0x1863C0430", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x63C0790", Offset = "0x63BEF90", VA = "0x1863C0790", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HJMLNOCABBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private DKMFHHIAGEF MBLHLDEBPCD;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public CMOKHCGMAFA IHEJKCNPCPN
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x773B20", Offset = "0x772320", VA = "0x180773B20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DKMFHHIAGEF FFOEIJJJLJA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x63C0D20", Offset = "0x63BF520", VA = "0x1863C0D20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x774F80", Offset = "0x773780", VA = "0x180774F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x63C0DB0", Offset = "0x63BF5B0", VA = "0x1863C0DB0")]
	public HJMLNOCABBE(CMOKHCGMAFA KJFBIBIIMEF, [Optional] DKMFHHIAGEF MBLHLDEBPCD)
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
			[Cpp2IlInjected.Address(RVA = "0x63C1230", Offset = "0x63BFA30", VA = "0x1863C1230")]
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
			[Cpp2IlInjected.Address(RVA = "0x771180", Offset = "0x76F980", VA = "0x180771180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x77C550", Offset = "0x77AD50", VA = "0x18077C550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8D3110", Offset = "0x8D1910", VA = "0x1808D3110")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8D3100", Offset = "0x8D1900", VA = "0x1808D3100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x63C1100", Offset = "0x63BF900", VA = "0x1863C1100", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x63C1130", Offset = "0x63BF930", VA = "0x1863C1130")]
		public static RoomInventoryItemProperties FGFKDLCBIDH(RoomInventoryItemProperties MJBJHGOBNAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x19D9C60", Offset = "0x19D8460", VA = "0x1819D9C60")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class FKNAOGGFOHA
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x63C0CC0", Offset = "0x63BF4C0", VA = "0x1863C0CC0")]
	public static int AOAONGLPLFH(long LHLDABINMFD)
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
