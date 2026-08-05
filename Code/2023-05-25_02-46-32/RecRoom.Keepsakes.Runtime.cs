using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecNet;
using RecRoom.Keepsakes;
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class KeepsakesConfig : ScriptableObject, global::BGELEMHCFAJ<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000004")]
			[CompilerGenerated]
			private sealed class ENDOKGBEGNI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
				public ENDOKGBEGNI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x108FDE0", Offset = "0x108E5E0", VA = "0x18108FDE0")]
				internal bool BJFPAIFHKGB(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(RVA = "0x108FDE0", Offset = "0x108E5E0", VA = "0x18108FDE0")]
				internal bool AGGEDHPFAMH(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8ACD20", Offset = "0x8AB520", VA = "0x1808ACD20")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] IEHJALMPHML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x1090F40", Offset = "0x108F740", VA = "0x181090F40")]
			public bool DCCKKNFHFMD(string NHBCDDMCAAN, out KeepsakeTheme BLAHOBJOPMJ)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public KeepsakesOptions Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1090EC0", Offset = "0x108F6C0", VA = "0x181090EC0")]
		[BBAPFPLPODF(EDNJEIFHIMJ.GameOnly)]
		private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xBBBD50", Offset = "0xBBA550", VA = "0x180BBBD50")]
		public KeepsakesConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EFFLCMOBEOM : IComparer<LNCLLEGDNJK>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class NCEKFLIMOAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public LNCLLEGDNJK x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public LNCLLEGDNJK y;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public NCEKFLIMOAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1091690", Offset = "0x108FE90", VA = "0x181091690")]
		internal bool EPPFLGGGHAA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x10916A0", Offset = "0x108FEA0", VA = "0x1810916A0")]
		internal bool INJENOPMMGD(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1091690", Offset = "0x108FE90", VA = "0x181091690")]
		internal bool EPCANDAGJMO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x10916A0", Offset = "0x108FEA0", VA = "0x1810916A0")]
		internal bool HNPHBPCPIBO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KeepsakeCategoryThemePair> HLPCGDBBOGF;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8ACD20", Offset = "0x8AB520", VA = "0x1808ACD20")]
	public EFFLCMOBEOM(List<KeepsakeCategoryThemePair> MDNKPJKEFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x108FB30", Offset = "0x108E330", VA = "0x18108FB30", Slot = "4")]
	public int Compare(LNCLLEGDNJK OLGJDFCIILF, LNCLLEGDNJK IKFJLOPMKHK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum JNEANKODDBB
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Faulted
}
namespace RecRoom.Keepsakes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct KeepsakeCategoryThemePair
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public LNCLLEGDNJK KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[JIAMBIICBFF]
public class PNGJHMGJAKF : DBLEGAFLABD, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct GJMBBCJOGLD
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public const string JGJACEOOAJI = "Keepsake placement still in progress. Please wait a moment before placing another keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public const string IGOPEHFHHOL = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public const string MMIDDJBJOJJ = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string JIAMHPOJGDB = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public const string DPECEICFFPO = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const string MBHBKGKBOII = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public const string GBHCENOOEMO = "You have to collect other keepsakes before you can collect this one.";

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public const string BCLIMIOAJMH = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public const string MJJJCOJEOHJ = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public const string JHOBEFFGEFJ = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public const string BOFCHMJPBGF = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public const string GKEPFLGOBHG = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public const string DCLAJKIMANJ = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HGEKHFMFNDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public PNGJHMGJAKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public LNCLLEGDNJK keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public HGEKHFMFNDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x10903E0", Offset = "0x108EBE0", VA = "0x1810903E0")]
		internal global::NBFPPJGKGOH<Guid> DGEGIBCEPMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1090530", Offset = "0x108ED30", VA = "0x181090530")]
		internal void IHGCFONNJHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x10909D0", Offset = "0x108F1D0", VA = "0x1810909D0")]
		internal void MKNMPFBOMAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1090560", Offset = "0x108ED60", VA = "0x181090560")]
		internal void LLCMPFMLNJN(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x10903B0", Offset = "0x108EBB0", VA = "0x1810903B0")]
		internal void CBNAGCNLLCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class ACAACCLKDHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public PNGJHMGJAKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int collectedKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int collectableKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ACAACCLKDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x108E170", Offset = "0x108C970", VA = "0x18108E170")]
		internal void OCFIKMPMGGD(CNANCDDECEI response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x108E110", Offset = "0x108C910", VA = "0x18108E110")]
		internal void AHGCODDKANG(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class ADAELEDLKHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ADAELEDLKHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x108E520", Offset = "0x108CD20", VA = "0x18108E520")]
		internal bool CLOHJKCOEJJ(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class ALPLEDGEJOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public PNGJHMGJAKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public LNCLLEGDNJK keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ALPLEDGEJOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x108E9D0", Offset = "0x108D1D0", VA = "0x18108E9D0")]
		internal bool PBFLMFJDAGB(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class ALEAIGDHPHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public PNGJHMGJAKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public LNCLLEGDNJK? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ALEAIGDHPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x108E600", Offset = "0x108CE00", VA = "0x18108E600")]
		internal void ICFHLEGPJNJ(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x108E690", Offset = "0x108CE90", VA = "0x18108E690")]
		internal void LGAEPNODPPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x108E6C0", Offset = "0x108CEC0", VA = "0x18108E6C0")]
		internal global::NBFPPJGKGOH<IEnumerable<Guid>> NGDJENNJGGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x108E5E0", Offset = "0x108CDE0", VA = "0x18108E5E0")]
		internal bool HNAPNGCGCBC(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class FCNNABCDNFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public ALEAIGDHPHI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FCNNABCDNFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x108FE10", Offset = "0x108E610", VA = "0x18108FE10")]
		internal global::NBFPPJGKGOH<IEnumerable<Guid>> MJKGPHFMJEM(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class LAJMJEFKDFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public FCNNABCDNFC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public LAJMJEFKDFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1091110", Offset = "0x108F910", VA = "0x181091110")]
		internal bool FPEAKPPCLOC(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class DEJKLPDIDLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public LAJMJEFKDFK CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DEJKLPDIDLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x108F860", Offset = "0x108E060", VA = "0x18108F860")]
		internal bool IOLBHFJFBJC(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class GLMFMEKEIDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public PNGJHMGJAKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public GLMFMEKEIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1090240", Offset = "0x108EA40", VA = "0x181090240")]
		internal global::NBFPPJGKGOH<IEnumerable<Guid>> PNNCMLMMNDD(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x108ED10", Offset = "0x108D510", VA = "0x18108ED10")]
		internal bool OGNFIMMOHIK(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class CKEGELEGDDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public PNGJHMGJAKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CKEGELEGDDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x108F2C0", Offset = "0x108DAC0", VA = "0x18108F2C0")]
		internal void BLODLPLGAJB(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x108E690", Offset = "0x108CE90", VA = "0x18108E690")]
		internal void CDKGEPBMBAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x108F350", Offset = "0x108DB50", VA = "0x18108F350")]
		internal global::NBFPPJGKGOH<Dictionary<Guid, LNCLLEGDNJK>> DCHPFNGAFKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x108E5E0", Offset = "0x108CDE0", VA = "0x18108E5E0")]
		internal bool PDBIOAPMEBF(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class CMCCEOPJKAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CMCCEOPJKAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x108F690", Offset = "0x108DE90", VA = "0x18108F690")]
		internal global::NBFPPJGKGOH<Dictionary<Guid, LNCLLEGDNJK>> HKBBAHAPHIE(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HJHIBMDLFOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public HJHIBMDLFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x1090A30", Offset = "0x108F230", VA = "0x181090A30")]
		internal bool EMLABCJLOGF(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1090B20", Offset = "0x108F320", VA = "0x181090B20")]
		internal KeyValuePair<Guid, LNCLLEGDNJK> MJLHGMIBNKM(Guid instanceId)
		{
			return default(KeyValuePair<Guid, LNCLLEGDNJK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class MELMFIOPEIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MELMFIOPEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x10913E0", Offset = "0x108FBE0", VA = "0x1810913E0")]
		internal bool HFJIFJJJMCK(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class HMKPCMDAIMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public HMKPCMDAIMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1090CA0", Offset = "0x108F4A0", VA = "0x181090CA0")]
		internal bool GFFBFKNIDAI(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class AMNPEKBGALC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public PNGJHMGJAKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public AMNPEKBGALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x108EAF0", Offset = "0x108D2F0", VA = "0x18108EAF0")]
		internal global::NBFPPJGKGOH<Dictionary<Guid, LNCLLEGDNJK>> EMGECKIJFHA(Dictionary<Guid, LNCLLEGDNJK> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x108ED10", Offset = "0x108D510", VA = "0x18108ED10")]
		internal bool MIAOGOIJLCG(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class OILFCKPJKCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public OILFCKPJKCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1091730", Offset = "0x108FF30", VA = "0x181091730")]
		internal bool HDHDMFFKCNI(KeyValuePair<Guid, LNCLLEGDNJK> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LBEBCILLNMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Dictionary<Guid, LNCLLEGDNJK> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public LBEBCILLNMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x1091240", Offset = "0x108FA40", VA = "0x181091240")]
		internal KeyValuePair<LNCLLEGDNJK, int> LEEKNNGDICB(LNCLLEGDNJK category)
		{
			return default(KeyValuePair<LNCLLEGDNJK, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CKHLCJPGPKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public LNCLLEGDNJK category;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CKHLCJPGPKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x108F660", Offset = "0x108DE60", VA = "0x18108F660")]
		internal bool KEEHNEEGBEF(LNCLLEGDNJK instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MKCOGJIHKAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Dictionary<Guid, LNCLLEGDNJK> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MKCOGJIHKAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1091480", Offset = "0x108FC80", VA = "0x181091480")]
		internal KeyValuePair<LNCLLEGDNJK, int> GNOAPFJEKII(LNCLLEGDNJK category)
		{
			return default(KeyValuePair<LNCLLEGDNJK, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class NEAKIHAJPCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public LNCLLEGDNJK category;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public NEAKIHAJPCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x108F660", Offset = "0x108DE60", VA = "0x18108F660")]
		internal bool FLKNAJCDKCA(LNCLLEGDNJK instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DNFEPOACAHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public PNGJHMGJAKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DNFEPOACAHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x108F960", Offset = "0x108E160", VA = "0x18108F960")]
		internal bool AHAENHDAHGC(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x108FA60", Offset = "0x108E260", VA = "0x18108FA60")]
		internal bool MJDHLCGHNPF(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x108FA40", Offset = "0x108E240", VA = "0x18108FA40")]
		internal bool MHOCAFMOLCL(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x108FA40", Offset = "0x108E240", VA = "0x18108FA40")]
		internal bool OPCFBNBFCON(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HOHKJIDADEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public HOHKJIDADEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x108F230", Offset = "0x108DA30", VA = "0x18108F230")]
		internal bool NCFPMDINNAD(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GGMPMGBKOKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public GGMPMGBKOKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1090150", Offset = "0x108E950", VA = "0x181090150")]
		internal bool BOGFKJKANDL(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1090220", Offset = "0x108EA20", VA = "0x181090220")]
		internal bool KOHKAGBHGJF(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CBLFLGBKMMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CBLFLGBKMMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x108F250", Offset = "0x108DA50", VA = "0x18108F250")]
		internal bool NFMFFBLMEHP(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BCJBKDAPDCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public BCJBKDAPDCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x108F230", Offset = "0x108DA30", VA = "0x18108F230")]
		internal bool AHKIFLIGPHN(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class KGLAFLBNKFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KGLAFLBNKFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1090D40", Offset = "0x108F540", VA = "0x181090D40")]
		internal bool LOJLGAOEPKH(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class CKONFFDNHDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public LNCLLEGDNJK keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public CKONFFDNHDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x108F670", Offset = "0x108DE70", VA = "0x18108F670")]
		internal bool FJKNAKOADEI(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class AHJNOIHLONO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public AHJNOIHLONO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x108E550", Offset = "0x108CD50", VA = "0x18108E550")]
		internal bool KFMAKDPKHMJ(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class MAHPJDOMIGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public LNCLLEGDNJK keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MAHPJDOMIGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x10913A0", Offset = "0x108FBA0", VA = "0x1810913A0")]
		internal bool EANIOJFDNFD(KeyValuePair<Guid, LNCLLEGDNJK> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class NINDAGLFJMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public LNCLLEGDNJK newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public NINDAGLFJMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x108F670", Offset = "0x108DE70", VA = "0x18108F670")]
		internal bool GEOGFHFIJLF(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MLKIMEEOMBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MLKIMEEOMBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x10915E0", Offset = "0x108FDE0", VA = "0x1810915E0")]
		internal bool NPGGHKOHIJL(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class KIKNEBDLAEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public KIKNEBDLAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1090DD0", Offset = "0x108F5D0", VA = "0x181090DD0")]
		internal bool IALBHGOIMNK(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class NNECFPHPMHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public KIKNEBDLAEL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public NNECFPHPMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x10916B0", Offset = "0x108FEB0", VA = "0x1810916B0")]
		internal bool CBPDHHLPFLF(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class ANCEBLIHLHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public MOMCOKAPMLC args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public PNGJHMGJAKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private Exception <e>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<KeepsakeInstanceDTO> <validKeepsakeInstances>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ANCEBLIHLHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x108ED30", Offset = "0x108D530", VA = "0x18108ED30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class FPEMIOAKOFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public PNGJHMGJAKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FPEMIOAKOFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x108FF60", Offset = "0x108E760", VA = "0x18108FF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int BMNBAIBAGCL = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DateTime CGGFPBOFMDE;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const int BOEHNLCGHCI = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const long OMJPGOBCBKI = -1L;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const char ANGHKJMMDCO = '|';

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly GGJKMMLNPGJ KICNJKGBMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly AHEENIKOBAF LLBBJGGHGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly JCOIHNPPJEE GGIEDNABMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CHJNJGLKOPB AJEDEBJNKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly NCFBJHOACDL FNIFBLHBOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly CKKILPBAGPK POLHKBGMOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BEIIGIJBNMM EAABFFOLONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly EPJFONLPCOB EKLPJDMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly DIFPALDBNIJ AGBDEBJEHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HOIMKPJHOHJ IKMKIDAPNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly OIFFEDBLNGN BEBCGFFLELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly DOECGNFCFML MHNJDFMHIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly KKIEGADMDPM ABJCBINJGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly DPBGHGFKPMM MOHCHEAHNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly GBEHEHLFCID GBLFMIICBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly global::BGELEMHCFAJ<KeepsakesConfig.KeepsakesOptions> GEAIFDNFEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly LALKFIOPJMN HNFNHEGHMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> OLGKFMPNNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<Guid> KOJBOAJKGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<long> BFAGHFDFGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Dictionary<LNCLLEGDNJK, int> ONBLBDIAECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly HashSet<Guid> DFFIHMNJHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly IDisposable NOHFHLNNBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private Task MJGGLLAFNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private global::NBFPPJGKGOH<Guid> NABEPCDNJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private long? LBONFLLFFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private KeepsakeProgressionEventInstancesDTO BIBLJGPHLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private global::NBFPPJGKGOH<KeepsakeProgressionEventInstancesDTO> DFGHAFNEJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private IReadOnlyDictionary<LNCLLEGDNJK, KeepsakeCategoryConfigDTO> HOCGFFGPIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private KeepsakeGlobalConfigDTO ADKOINCHDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private HashSet<long> LLMKABNANGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private HashSet<long> MGIAOCKKFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<KeepsakeRoomListDTO> GMJDNIGLDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private List<KeepsakeRoomListDTO> HMJLBEGEKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private List<KeepsakeRoomListDTO> KHLMOHEMPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<long, string> JMDBIMNFMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<long, string> HGCBOPGHIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<long, DateTime> LEFGCJHKFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<long, List<KeepsakeRoomDTO>> OINGMHIPBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Dictionary<long, List<KeepsakeRoomDTO>> IPEAFOMNAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Dictionary<long, long> EKIOAFJNIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<string> EBLJLIPLNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private DateTime JGKKEEJFLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly IDisposable PNKLBCPAHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Guid, LNCLLEGDNJK> AIEOCLDBCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<LNCLLEGDNJK, int> OIDKFLCMCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private List<KeepsakeCategoryThemePair> MDNKPJKEFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private EFFLCMOBEOM GKOFPHGDGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool IDPOOIIMKCI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FOPOPCEJOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE60", Offset = "0x8AA660", VA = "0x1808ABE60", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xDA40B0", Offset = "0xDA28B0", VA = "0x180DA40B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JPBNLLDFMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x10958E0", Offset = "0x10940E0", VA = "0x1810958E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LGHBAMFLBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x109B690", Offset = "0x1099E90", VA = "0x18109B690", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long IFMEAPHPBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1099710", Offset = "0x1097F10", VA = "0x181099710")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long? GDGIJFMMBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1097F40", Offset = "0x1096740", VA = "0x181097F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool NIBPGDFMBIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1094390", Offset = "0x1092B90", VA = "0x181094390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> DLOHJCKKFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xE71B00", Offset = "0xE70300", VA = "0x180E71B00", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> ONGIINNNBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xE71B10", Offset = "0xE70310", VA = "0x180E71B10", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<KeepsakeRoomListDTO> PJPFDGEPKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xE71AD0", Offset = "0xE702D0", VA = "0x180E71AD0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> MDJIAEEJCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x109E330", Offset = "0x109CB30", VA = "0x18109E330", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyDictionary<long, string> BOPCKGMELAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x10984F0", Offset = "0x1096CF0", VA = "0x1810984F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal bool BPDDFKDLGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1093720", Offset = "0x1091F20", VA = "0x181093720")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x10943B0", Offset = "0x1092BB0", VA = "0x1810943B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> DHLAHCFINBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x109E8A0", Offset = "0x109D0A0", VA = "0x18109E8A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1097220", Offset = "0x1095A20", VA = "0x181097220", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PLJHOKBCCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1093730", Offset = "0x1091F30", VA = "0x181093730", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x109A1C0", Offset = "0x10989C0", VA = "0x18109A1C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action IJBEEFCONMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x10970E0", Offset = "0x10958E0", VA = "0x1810970E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x109ADB0", Offset = "0x10995B0", VA = "0x18109ADB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x109E940", Offset = "0x109D140", VA = "0x18109E940")]
	[Preserve]
	internal PNGJHMGJAKF([NotNull][ACEKLAKDMBL(null)] GGJKMMLNPGJ KICNJKGBMEG, [NotNull][ACEKLAKDMBL(null)] BBJHDNJAMLE FBNJAEDAHDH, [NotNull][ACEKLAKDMBL(null)] AHEENIKOBAF LLBBJGGHGON, [NotNull][ACEKLAKDMBL(null)] JCOIHNPPJEE GGIEDNABMJH, [NotNull][ACEKLAKDMBL(null)] CHJNJGLKOPB AJEDEBJNKFM, [NotNull][ACEKLAKDMBL(null)] NCFBJHOACDL FNIFBLHBOOE, [NotNull][ACEKLAKDMBL(null)] CKKILPBAGPK POLHKBGMOIM, [NotNull][ACEKLAKDMBL(null)] BEIIGIJBNMM EAABFFOLONM, [NotNull][ACEKLAKDMBL(null)] EPJFONLPCOB EKLPJDMGHDM, [NotNull][ACEKLAKDMBL(null)] HHJOLBIOKOH OGBFPPIDPHE, [NotNull][ACEKLAKDMBL(null)] DIFPALDBNIJ AGBDEBJEHGE, [NotNull][ACEKLAKDMBL(null)] HOIMKPJHOHJ IKMKIDAPNHI, [NotNull][ACEKLAKDMBL(null)] OIFFEDBLNGN BEBCGFFLELO, [NotNull][ACEKLAKDMBL(null)] DOECGNFCFML MHNJDFMHIBE, [NotNull][ACEKLAKDMBL(null)] KKIEGADMDPM ABJCBINJGCF, [NotNull][ACEKLAKDMBL(null)] DPBGHGFKPMM MOHCHEAHNMD, [NotNull][ACEKLAKDMBL(null)] GBEHEHLFCID GBLFMIICBDJ, [NotNull][ACEKLAKDMBL(null)] global::BGELEMHCFAJ<KeepsakesConfig.KeepsakesOptions> GEAIFDNFEOL, [NotNull][ACEKLAKDMBL(null)] LALKFIOPJMN HNFNHEGHMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x109B7F0", Offset = "0x1099FF0", VA = "0x18109B7F0", Slot = "15")]
	public bool LEEAOBELJPB(List<string> DOOOIMMJJJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1095A50", Offset = "0x1094250", VA = "0x181095A50", Slot = "16")]
	public global::NBFPPJGKGOH<Guid> DLECKKNFDNC(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1097B40", Offset = "0x1096340", VA = "0x181097B40", Slot = "17")]
	public EILHPPDHBHH GACFCBKBMLE(Guid NCDLOEBMMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1098500", Offset = "0x1096D00", VA = "0x181098500", Slot = "18")]
	public EILHPPDHBHH GKFDGGAKIJN(Guid NCDLOEBMMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1099DD0", Offset = "0x10985D0", VA = "0x181099DD0", Slot = "19")]
	public bool IHNACDMNHBO(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x109DC20", Offset = "0x109C420", VA = "0x18109DC20", Slot = "20")]
	public bool OKNLFICGAAJ(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1093580", Offset = "0x1091D80", VA = "0x181093580")]
	public KeepsakeTheme BODBGIPAHKB(Guid NCDLOEBMMGD)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1091EC0", Offset = "0x10906C0", VA = "0x181091EC0")]
	public bool AFPPIGBMBJL(LNCLLEGDNJK PIKCKAKDFFC, out KeepsakeTheme BLAHOBJOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x109C470", Offset = "0x109AC70", VA = "0x18109C470")]
	public List<KeepsakeTheme> MKNMCBILCPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x109E580", Offset = "0x109CD80", VA = "0x18109E580")]
	public int PHKAPKIHHOH(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x10917B0", Offset = "0x108FFB0", VA = "0x1810917B0")]
	public LNCLLEGDNJK ADCCAMCIFKI(Guid NCDLOEBMMGD)
	{
		return default(LNCLLEGDNJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1096E40", Offset = "0x1095640", VA = "0x181096E40", Slot = "34")]
	public List<LNCLLEGDNJK> EMOGDPLJOOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x109E1C0", Offset = "0x109C9C0", VA = "0x18109E1C0", Slot = "35")]
	public IComparer<LNCLLEGDNJK> PCAKCLMKPIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1099210", Offset = "0x1097A10", VA = "0x181099210", Slot = "32")]
	public string HKLLNLDFMIL(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x109AC40", Offset = "0x1099440", VA = "0x18109AC40", Slot = "33")]
	public string KIPOFHGHGLO(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1099F20", Offset = "0x1098720", VA = "0x181099F20", Slot = "21")]
	public bool IJJIJGKFIAM(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1098BF0", Offset = "0x10973F0", VA = "0x181098BF0", Slot = "22")]
	public void HFNPEKAKFJB(Guid NCDLOEBMMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x109A8A0", Offset = "0x10990A0", VA = "0x18109A8A0", Slot = "23")]
	public void JOGMDMAJIAI(LNCLLEGDNJK PIKCKAKDFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1095180", Offset = "0x1093980", VA = "0x181095180", Slot = "24")]
	public void DCAHMBOCKPF(Guid NCDLOEBMMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x109B1C0", Offset = "0x10999C0", VA = "0x18109B1C0", Slot = "25")]
	public int KMKIOHKONCF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x109AE50", Offset = "0x1099650", VA = "0x18109AE50", Slot = "54")]
	public int KMKIOHKONCF(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1091AB0", Offset = "0x10902B0", VA = "0x181091AB0", Slot = "31")]
	public global::NBFPPJGKGOH<IEnumerable<Guid>> AFJEGDJGBGL(long HAMIEGOKEJC, long JEBGGHOLKHJ, LNCLLEGDNJK? PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x109D200", Offset = "0x109BA00", VA = "0x18109D200", Slot = "30")]
	public global::NBFPPJGKGOH<IEnumerable<Guid>> NHMNMGCCMAL(long HAMIEGOKEJC, long JEBGGHOLKHJ, LNCLLEGDNJK? PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x10954D0", Offset = "0x1093CD0", VA = "0x1810954D0", Slot = "55")]
	public global::NBFPPJGKGOH<Dictionary<Guid, LNCLLEGDNJK>> DFJKMAACPEH(long HAMIEGOKEJC, long JEBGGHOLKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1091920", Offset = "0x1090120", VA = "0x181091920", Slot = "56")]
	public global::NBFPPJGKGOH<Dictionary<Guid, LNCLLEGDNJK>> ADLNEKLFANK(long HAMIEGOKEJC, long JEBGGHOLKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x109C020", Offset = "0x109A820", VA = "0x18109C020", Slot = "26")]
	public global::NBFPPJGKGOH<int> LKLGDPDJJBP(long HAMIEGOKEJC, long JEBGGHOLKHJ, LNCLLEGDNJK? PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x109D7F0", Offset = "0x109BFF0", VA = "0x18109D7F0", Slot = "27")]
	public global::NBFPPJGKGOH<int> ODKKCKLKDMP(long HAMIEGOKEJC, long JEBGGHOLKHJ, LNCLLEGDNJK? PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x109CFE0", Offset = "0x109B7E0", VA = "0x18109CFE0", Slot = "28")]
	public global::NBFPPJGKGOH<Dictionary<LNCLLEGDNJK, int>> NFPPPLBCDGB(long HAMIEGOKEJC, long JEBGGHOLKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1098420", Offset = "0x1096C20", VA = "0x181098420", Slot = "29")]
	public global::NBFPPJGKGOH<Dictionary<LNCLLEGDNJK, int>> GICMJGFPMKE(long HAMIEGOKEJC, long JEBGGHOLKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1099380", Offset = "0x1097B80", VA = "0x181099380", Slot = "37")]
	public bool HMLMELBHIAK(long HAMIEGOKEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1098890", Offset = "0x1097090", VA = "0x181098890", Slot = "57")]
	public bool GOIJIJGMLGN(long HAMIEGOKEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1097180", Offset = "0x1095980", VA = "0x181097180", Slot = "38")]
	public bool EPFJFFOEGBE(long HAMIEGOKEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1096090", Offset = "0x1094890", VA = "0x181096090", Slot = "58")]
	public bool DMGJGJCOAGC(long HAMIEGOKEJC, out ILBJKOKJFAE HHICIBAIJGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1096F90", Offset = "0x1095790", VA = "0x181096F90", Slot = "39")]
	public bool EPDEJPKEOLG(long IICNEKLODJO, out DateTime APGLPJPNNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x10928D0", Offset = "0x10910D0", VA = "0x1810928D0", Slot = "40")]
	public long BGNAFFIAPPJ(long IICNEKLODJO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x109A5A0", Offset = "0x1098DA0", VA = "0x18109A5A0", Slot = "59")]
	public IEnumerable<int> JJICPKGOCLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1095930", Offset = "0x1094130", VA = "0x181095930", Slot = "41")]
	public long DJEAJBELGFG(long HAMIEGOKEJC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1099BB0", Offset = "0x10983B0", VA = "0x181099BB0", Slot = "42")]
	public int IHFBCDDDFBJ(long IICNEKLODJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x109CB90", Offset = "0x109B390", VA = "0x18109CB90", Slot = "43")]
	public bool NDHFIHBFJGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x109D960", Offset = "0x109C160", VA = "0x18109D960", Slot = "44")]
	public bool OEFGMKGGNDO(long IICNEKLODJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1099530", Offset = "0x1097D30", VA = "0x181099530", Slot = "45")]
	public IEnumerable<long> IEAMGJOFINO(long IICNEKLODJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1095420", Offset = "0x1093C20", VA = "0x181095420", Slot = "46")]
	public int DFDOPLMBKAA(long IICNEKLODJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x109D450", Offset = "0x109BC50", VA = "0x18109D450", Slot = "50")]
	public long NOGDJKELNAE(long JBHAABPKJOI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x10997F0", Offset = "0x1097FF0", VA = "0x1810997F0", Slot = "51")]
	public LNCLLEGDNJK IGODJLINLGJ()
	{
		return default(LNCLLEGDNJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x109A2B0", Offset = "0x1098AB0", VA = "0x18109A2B0")]
	private bool INHPGCCICJH(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x109BAF0", Offset = "0x109A2F0", VA = "0x18109BAF0")]
	private void LFOPFDBGCIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x10988F0", Offset = "0x10970F0", VA = "0x1810988F0")]
	private LNCLLEGDNJK HENBIKLOLNO()
	{
		return default(LNCLLEGDNJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1098C60", Offset = "0x1097460", VA = "0x181098C60")]
	private void HHADFKJHOCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x109E6F0", Offset = "0x109CEF0", VA = "0x18109E6F0")]
	private int PIPDHLGEBAA(KeepsakeRoomListDTO GKPNIMLNKIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x10924D0", Offset = "0x1090CD0", VA = "0x1810924D0")]
	private int BAGFMIEBCLA(DateTime EMIGJDPDFNN, DateTime NFCDPKIMBCO, TimeSpan CICJHNFLLOD, int BELKPPEAGGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x10972C0", Offset = "0x1095AC0", VA = "0x1810972C0")]
	private void FDDECLKILFI(IEnumerable<KeepsakeInstanceDTO> OLGKFMPNNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x109E340", Offset = "0x109CB40", VA = "0x18109E340")]
	private void PEIAIOBLEIP(IEnumerable<KeepsakeCollectionRecordDTO> LBOOKCBNNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x109D790", Offset = "0x109BF90", VA = "0x18109D790")]
	private void OCIDGGMOKCM(IEnumerable<long> KDPKJCGIHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xEE0BC0", Offset = "0xEDF3C0", VA = "0x180EE0BC0")]
	private void ILHMHMNDIND(KeepsakeGlobalConfigDTO ADKOINCHDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1092D00", Offset = "0x1091500", VA = "0x181092D00")]
	private bool BIFPBLCDHIF(LNCLLEGDNJK PIKCKAKDFFC, out Guid IKDEFKDHIJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x109A4D0", Offset = "0x1098CD0", VA = "0x18109A4D0")]
	private bool JFOMOKAGNEB(out Guid IKDEFKDHIJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x10953C0", Offset = "0x1093BC0", VA = "0x1810953C0")]
	private bool DDIPFKOKHEM(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x109AAE0", Offset = "0x10992E0", VA = "0x18109AAE0")]
	private IEnumerable<Guid> KHHJHKOENIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x109E260", Offset = "0x109CA60", VA = "0x18109E260")]
	private IEnumerable<KeepsakeInstanceDTO> PCEFOPANNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x109D3A0", Offset = "0x109BBA0", VA = "0x18109D3A0")]
	private void NIPCFIFMNFK(Guid NCDLOEBMMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x109A7F0", Offset = "0x1098FF0", VA = "0x18109A7F0")]
	private bool JNLEEEIGJPJ(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1092330", Offset = "0x1090B30", VA = "0x181092330")]
	private void BABCFMGBDCP(Guid NCDLOEBMMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x109A3F0", Offset = "0x1098BF0", VA = "0x18109A3F0")]
	private void JCJHLLAKALL(LNCLLEGDNJK KBBEMPODLCC, int BIGOLAIOAAK, ref Dictionary<LNCLLEGDNJK, int> KMHNOICCHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1097860", Offset = "0x1096060", VA = "0x181097860")]
	private int FFEIGFMMELN(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1092090", Offset = "0x1090890", VA = "0x181092090")]
	private void AOACBKAOCGJ(KeepsakeInstanceDTO CBLCNAAIFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x10926D0", Offset = "0x1090ED0", VA = "0x1810926D0")]
	private void BBBDAOPDHLO(KeepsakeInstanceDTO CBLCNAAIFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1093950", Offset = "0x1092150", VA = "0x181093950")]
	private void CDMOGJDEICJ(Guid NCDLOEBMMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x109A8E0", Offset = "0x10990E0", VA = "0x18109A8E0")]
	private void JPOHNNKLKPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1096E20", Offset = "0x1095620", VA = "0x181096E20")]
	private void ELDHMPAIKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x109B610", Offset = "0x1099E10", VA = "0x18109B610")]
	private void KNLGJLHCCCL(NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1097DC0", Offset = "0x10965C0", VA = "0x181097DC0")]
	private void GAHCFDIKECI(IJAGCJNCGHF.MPAJCLEDGGP HHNPCHNMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x109C410", Offset = "0x109AC10", VA = "0x18109C410")]
	private void MBJGIHKPPFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1093FD0", Offset = "0x10927D0", VA = "0x181093FD0")]
	private void CLCFLMIFOKL(float FHLBOAAPMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x109DC50", Offset = "0x109C450", VA = "0x18109DC50")]
	private void OOALMNGLJLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x109B760", Offset = "0x1099F60", VA = "0x18109B760")]
	private bool LBFBBMELJMH(Guid NCDLOEBMMGD, out string NCKJIKDEPMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x109CE10", Offset = "0x109B610", VA = "0x18109CE10")]
	private bool NEDKKMEKGCA(Guid NCDLOEBMMGD, out KeepsakeCategoryConfigDTO KBBEMPODLCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1092250", Offset = "0x1090A50", VA = "0x181092250")]
	private void AOHDHBMGNOD(string IFIAJHGJOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x109C7C0", Offset = "0x109AFC0", VA = "0x18109C7C0")]
	private bool MMGNPMFPGEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1093CF0", Offset = "0x10924F0", VA = "0x181093CF0")]
	private IEnumerable<long> CEALGFGDJFH(IEnumerable<KeepsakeRoomDTO> MJDKANALFLO, IEnumerable<KeepsakeRoomListDTO> OFJDHFDBKHJ, long IICNEKLODJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1092FB0", Offset = "0x10917B0", VA = "0x181092FB0")]
	private bool BMKLNNLAILC(Guid NCDLOEBMMGD, out string FKPBDLDGFCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x10994D0", Offset = "0x1097CD0", VA = "0x1810994D0", Slot = "47")]
	public string ICEDGCPIHLL(ILGOKCMADDD KBKLBPALFEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1097FE0", Offset = "0x10967E0", VA = "0x181097FE0", Slot = "49")]
	public string GGBCDMOLNDM(ILGOKCMADDD KBKLBPALFEG, long HAMIEGOKEJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1097E20", Offset = "0x1096620", VA = "0x181097E20", Slot = "48")]
	public string GBGDGCEFKLC(ILGOKCMADDD KBKLBPALFEG, int DFIKHPGOHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1094420", Offset = "0x1092C20", VA = "0x181094420")]
	private void CMKKAGODMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x109C2D0", Offset = "0x109AAD0", VA = "0x18109C2D0")]
	private void LLCLFKMMHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1099DB0", Offset = "0x10985B0", VA = "0x181099DB0")]
	private ILGOKCMADDD IHHEPCJEKDD(HEOEDEOKAAF KNGNHJMHMIM)
	{
		return default(ILGOKCMADDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x109C000", Offset = "0x109A800", VA = "0x18109C000")]
	private ILGOKCMADDD LJGBOJBDGPH(HEOEDEOKAAF KNGNHJMHMIM)
	{
		return default(ILGOKCMADDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1096950", Offset = "0x1095150", VA = "0x181096950")]
	internal static string EBHHELFNGLO(CNANCDDECEI CMAOBCBOEFF, string DKNEADKLOMJ, bool FNIILLDDLIG, int NIOCGPNCCAN, int DJBGECLLKEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1096450", Offset = "0x1094C50", VA = "0x181096450", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x109C8E0", Offset = "0x109B0E0", VA = "0x18109C8E0")]
	private IDIFMABCDLA MNBINNHKLCC(IGGCDPKBFGF OHCIFECEBBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x109A940", Offset = "0x1099140", VA = "0x18109A940")]
	private HGGHGJBADJJ KBPDOFPJDID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x10974D0", Offset = "0x1095CD0", VA = "0x1810974D0")]
	private Task FENEEDNHDLO(MOMCOKAPMLC PFFFGKKOEPM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1096CB0", Offset = "0x10954B0", VA = "0x181096CB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ANCEBLIHLHM))]
	private Task EGJCBGFMEJJ(MOMCOKAPMLC PFFFGKKOEPM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x10968B0", Offset = "0x10950B0", VA = "0x1810968B0")]
	private Task EAMBHGJDAKD(MOMCOKAPMLC PFFFGKKOEPM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x109CC80", Offset = "0x109B480", VA = "0x18109CC80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FPEMIOAKOFJ))]
	private Task NDMIABDIAEH(string DKIECHCHJFL, TimeSpan LMHECMGJIDD, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xBBC210", Offset = "0xBBAA10", VA = "0x180BBC210")]
	[CompilerGenerated]
	private void KCHHLMBDHHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x109A260", Offset = "0x1098A60", VA = "0x18109A260")]
	[CompilerGenerated]
	private void IMIGNJOGJBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x10993E0", Offset = "0x1097BE0", VA = "0x1810993E0")]
	[CompilerGenerated]
	private bool IAPIKCBDFKC(KeepsakeInstanceDTO OLGJDFCIILF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1096B30", Offset = "0x1095330", VA = "0x181096B30")]
	[CompilerGenerated]
	private global::NBFPPJGKGOH<Dictionary<LNCLLEGDNJK, int>> EEODHJANAAG(Dictionary<Guid, LNCLLEGDNJK> BPMLMDIEHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x10979C0", Offset = "0x10961C0", VA = "0x1810979C0")]
	[CompilerGenerated]
	private global::NBFPPJGKGOH<Dictionary<LNCLLEGDNJK, int>> FPCLOIFENPI(Dictionary<Guid, LNCLLEGDNJK> BPMLMDIEHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x109D430", Offset = "0x109BC30", VA = "0x18109D430")]
	[CompilerGenerated]
	private bool NLGEOGLJHPP(KeepsakeRoomListDTO OLGJDFCIILF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x10925A0", Offset = "0x1090DA0", VA = "0x1810925A0")]
	[CompilerGenerated]
	private bool BAMIHFGFBAA(KeepsakeInstanceDTO OLGJDFCIILF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x10937D0", Offset = "0x1091FD0", VA = "0x1810937D0")]
	[CompilerGenerated]
	private void CAKBLMHCHGI(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<LNCLLEGDNJK, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> JCCJEHKCPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1097960", Offset = "0x1096160", VA = "0x181097960")]
	[CompilerGenerated]
	private void FGHNGOLDDEL(string FKPBDLDGFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x109C960", Offset = "0x109B160", VA = "0x18109C960")]
	[CompilerGenerated]
	private Task MPPFMAFPCBB(CancellationToken LFNNGMJEMJM)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct KeepsakeTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string ThemeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int ThemeOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[Header("Pickup")]
		public string PickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public GameObject PickupPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AudioClip PickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public float PickupSfxVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[Header("Colors")]
		public bool UseCustomColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Color BeamColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Color BaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[Header("Looping Sound")]
		public AudioClip LoopingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public float LoopingSfxVolume;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0xBC23C0", Offset = "0xBC0BC0", VA = "0x180BC23C0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
