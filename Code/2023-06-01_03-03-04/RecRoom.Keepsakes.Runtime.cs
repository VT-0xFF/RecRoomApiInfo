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
	public class KeepsakesConfig : ScriptableObject, BGELEMHCFAJ<KeepsakesConfig.KeepsakesOptions>
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
				[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
				public ENDOKGBEGNI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x5872AA0", Offset = "0x58716A0", VA = "0x185872AA0")]
				internal bool BJFPAIFHKGB(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(RVA = "0x5872AA0", Offset = "0x58716A0", VA = "0x185872AA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] IEHJALMPHML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x5873BE0", Offset = "0x58727E0", VA = "0x185873BE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5873B60", Offset = "0x5872760", VA = "0x185873B60")]
		[BBAPFPLPODF(EDNJEIFHIMJ.GameOnly)]
		private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x10C7230", Offset = "0x10C5E30", VA = "0x1810C7230")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public NCEKFLIMOAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1369F90", Offset = "0x1368B90", VA = "0x181369F90")]
		internal bool EPPFLGGGHAA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x13E1830", Offset = "0x13E0430", VA = "0x1813E1830")]
		internal bool INJENOPMMGD(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1369F90", Offset = "0x1368B90", VA = "0x181369F90")]
		internal bool EPCANDAGJMO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x13E1830", Offset = "0x13E0430", VA = "0x1813E1830")]
		internal bool HNPHBPCPIBO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KeepsakeCategoryThemePair> HLPCGDBBOGF;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x85C810", Offset = "0x85B410", VA = "0x18085C810")]
	public EFFLCMOBEOM(List<KeepsakeCategoryThemePair> MDNKPJKEFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x58727F0", Offset = "0x58713F0", VA = "0x1858727F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public HGEKHFMFNDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5873080", Offset = "0x5871C80", VA = "0x185873080")]
		internal NBFPPJGKGOH<Guid> DGEGIBCEPMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x58731D0", Offset = "0x5871DD0", VA = "0x1858731D0")]
		internal void IHGCFONNJHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5873670", Offset = "0x5872270", VA = "0x185873670")]
		internal void MKNMPFBOMAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5873200", Offset = "0x5871E00", VA = "0x185873200")]
		internal void LLCMPFMLNJN(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5873050", Offset = "0x5871C50", VA = "0x185873050")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ACAACCLKDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5870EA0", Offset = "0x586FAA0", VA = "0x185870EA0")]
		internal void OCFIKMPMGGD(CNANCDDECEI response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5870E40", Offset = "0x586FA40", VA = "0x185870E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ADAELEDLKHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5871250", Offset = "0x586FE50", VA = "0x185871250")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ALPLEDGEJOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5871700", Offset = "0x5870300", VA = "0x185871700")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ALEAIGDHPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5871330", Offset = "0x586FF30", VA = "0x185871330")]
		internal void ICFHLEGPJNJ(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x58713C0", Offset = "0x586FFC0", VA = "0x1858713C0")]
		internal void LGAEPNODPPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x58713F0", Offset = "0x586FFF0", VA = "0x1858713F0")]
		internal NBFPPJGKGOH<IEnumerable<Guid>> NGDJENNJGGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5871310", Offset = "0x586FF10", VA = "0x185871310")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public FCNNABCDNFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5872AD0", Offset = "0x58716D0", VA = "0x185872AD0")]
		internal NBFPPJGKGOH<IEnumerable<Guid>> MJKGPHFMJEM(KeepsakeRoomInstancesDTO roomInstancesDTO)
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public LAJMJEFKDFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5873DB0", Offset = "0x58729B0", VA = "0x185873DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DEJKLPDIDLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5872520", Offset = "0x5871120", VA = "0x185872520")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public GLMFMEKEIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5872EE0", Offset = "0x5871AE0", VA = "0x185872EE0")]
		internal NBFPPJGKGOH<IEnumerable<Guid>> PNNCMLMMNDD(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3CC47F0", Offset = "0x3CC33F0", VA = "0x183CC47F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public CKEGELEGDDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5871FB0", Offset = "0x5870BB0", VA = "0x185871FB0")]
		internal void BLODLPLGAJB(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x58713C0", Offset = "0x586FFC0", VA = "0x1858713C0")]
		internal void CDKGEPBMBAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5872040", Offset = "0x5870C40", VA = "0x185872040")]
		internal NBFPPJGKGOH<Dictionary<Guid, LNCLLEGDNJK>> DCHPFNGAFKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5871310", Offset = "0x586FF10", VA = "0x185871310")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public CMCCEOPJKAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5872350", Offset = "0x5870F50", VA = "0x185872350")]
		internal NBFPPJGKGOH<Dictionary<Guid, LNCLLEGDNJK>> HKBBAHAPHIE(KeepsakeRoomInstancesDTO roomInstancesDTO)
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public HJHIBMDLFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x58736D0", Offset = "0x58722D0", VA = "0x1858736D0")]
		internal bool EMLABCJLOGF(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x58737C0", Offset = "0x58723C0", VA = "0x1858737C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MELMFIOPEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5874080", Offset = "0x5872C80", VA = "0x185874080")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public HMKPCMDAIMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5873940", Offset = "0x5872540", VA = "0x185873940")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public AMNPEKBGALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5871820", Offset = "0x5870420", VA = "0x185871820")]
		internal NBFPPJGKGOH<Dictionary<Guid, LNCLLEGDNJK>> EMGECKIJFHA(Dictionary<Guid, LNCLLEGDNJK> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3CC47F0", Offset = "0x3CC33F0", VA = "0x183CC47F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public OILFCKPJKCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x58743B0", Offset = "0x5872FB0", VA = "0x1858743B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public LBEBCILLNMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5873EE0", Offset = "0x5872AE0", VA = "0x185873EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public CKHLCJPGPKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1E7F650", Offset = "0x1E7E250", VA = "0x181E7F650")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MKCOGJIHKAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5874120", Offset = "0x5872D20", VA = "0x185874120")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public NEAKIHAJPCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1E7F650", Offset = "0x1E7E250", VA = "0x181E7F650")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DNFEPOACAHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5872620", Offset = "0x5871220", VA = "0x185872620")]
		internal bool AHAENHDAHGC(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5872720", Offset = "0x5871320", VA = "0x185872720")]
		internal bool MJDHLCGHNPF(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5872700", Offset = "0x5871300", VA = "0x185872700")]
		internal bool MHOCAFMOLCL(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5872700", Offset = "0x5871300", VA = "0x185872700")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public HOHKJIDADEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x10546F0", Offset = "0x10532F0", VA = "0x1810546F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public GGMPMGBKOKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5872E10", Offset = "0x5871A10", VA = "0x185872E10")]
		internal bool BOGFKJKANDL(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x169B820", Offset = "0x169A420", VA = "0x18169B820")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public CBLFLGBKMMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5871F40", Offset = "0x5870B40", VA = "0x185871F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public BCJBKDAPDCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x10546F0", Offset = "0x10532F0", VA = "0x1810546F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KGLAFLBNKFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x58739E0", Offset = "0x58725E0", VA = "0x1858739E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public CKONFFDNHDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x16916B0", Offset = "0x16902B0", VA = "0x1816916B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public AHJNOIHLONO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5871280", Offset = "0x586FE80", VA = "0x185871280")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MAHPJDOMIGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5874040", Offset = "0x5872C40", VA = "0x185874040")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public NINDAGLFJMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x16916B0", Offset = "0x16902B0", VA = "0x1816916B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public MLKIMEEOMBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5874280", Offset = "0x5872E80", VA = "0x185874280")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public KIKNEBDLAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5873A70", Offset = "0x5872670", VA = "0x185873A70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public NNECFPHPMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5874330", Offset = "0x5872F30", VA = "0x185874330")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ANCEBLIHLHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5871A40", Offset = "0x5870640", VA = "0x185871A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public FPEMIOAKOFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5872C20", Offset = "0x5871820", VA = "0x185872C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
	private readonly BGELEMHCFAJ<KeepsakesConfig.KeepsakesOptions> GEAIFDNFEOL;

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
	private NBFPPJGKGOH<Guid> NABEPCDNJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private long? LBONFLLFFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private KeepsakeProgressionEventInstancesDTO BIBLJGPHLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private NBFPPJGKGOH<KeepsakeProgressionEventInstancesDTO> DFGHAFNEJNI;

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
		[Cpp2IlInjected.Address(RVA = "0xC214A0", Offset = "0xC200A0", VA = "0x180C214A0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC21520", Offset = "0xC20120", VA = "0x180C21520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JPBNLLDFMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5878550", Offset = "0x5877150", VA = "0x185878550", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LGHBAMFLBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x587E2F0", Offset = "0x587CEF0", VA = "0x18587E2F0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long IFMEAPHPBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x587C370", Offset = "0x587AF70", VA = "0x18587C370")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long? GDGIJFMMBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x587ABB0", Offset = "0x58797B0", VA = "0x18587ABB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool NIBPGDFMBIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5877000", Offset = "0x5875C00", VA = "0x185877000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> DLOHJCKKFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1838B10", Offset = "0x1837710", VA = "0x181838B10", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> ONGIINNNBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1642200", Offset = "0x1640E00", VA = "0x181642200", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<KeepsakeRoomListDTO> PJPFDGEPKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x14C2210", Offset = "0x14C0E10", VA = "0x1814C2210", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> MDJIAEEJCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x106D950", Offset = "0x106C550", VA = "0x18106D950", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyDictionary<long, string> BOPCKGMELAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xF00460", Offset = "0xEFF060", VA = "0x180F00460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal bool BPDDFKDLGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x18C5520", Offset = "0x18C4120", VA = "0x1818C5520")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5877020", Offset = "0x5875C20", VA = "0x185877020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> DHLAHCFINBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x58814F0", Offset = "0x58800F0", VA = "0x1858814F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5879E90", Offset = "0x5878A90", VA = "0x185879E90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PLJHOKBCCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x58763A0", Offset = "0x5874FA0", VA = "0x1858763A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x587CE20", Offset = "0x587BA20", VA = "0x18587CE20", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action IJBEEFCONMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5879D50", Offset = "0x5878950", VA = "0x185879D50", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x587DA10", Offset = "0x587C610", VA = "0x18587DA10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5881590", Offset = "0x5880190", VA = "0x185881590")]
	[Preserve]
	internal PNGJHMGJAKF([NotNull][ACEKLAKDMBL(null)] GGJKMMLNPGJ KICNJKGBMEG, [NotNull][ACEKLAKDMBL(null)] BBJHDNJAMLE FBNJAEDAHDH, [NotNull][ACEKLAKDMBL(null)] AHEENIKOBAF LLBBJGGHGON, [NotNull][ACEKLAKDMBL(null)] JCOIHNPPJEE GGIEDNABMJH, [NotNull][ACEKLAKDMBL(null)] CHJNJGLKOPB AJEDEBJNKFM, [NotNull][ACEKLAKDMBL(null)] NCFBJHOACDL FNIFBLHBOOE, [NotNull][ACEKLAKDMBL(null)] CKKILPBAGPK POLHKBGMOIM, [NotNull][ACEKLAKDMBL(null)] BEIIGIJBNMM EAABFFOLONM, [NotNull][ACEKLAKDMBL(null)] EPJFONLPCOB EKLPJDMGHDM, [NotNull][ACEKLAKDMBL(null)] HHJOLBIOKOH OGBFPPIDPHE, [NotNull][ACEKLAKDMBL(null)] DIFPALDBNIJ AGBDEBJEHGE, [NotNull][ACEKLAKDMBL(null)] HOIMKPJHOHJ IKMKIDAPNHI, [NotNull][ACEKLAKDMBL(null)] OIFFEDBLNGN BEBCGFFLELO, [NotNull][ACEKLAKDMBL(null)] DOECGNFCFML MHNJDFMHIBE, [NotNull][ACEKLAKDMBL(null)] KKIEGADMDPM ABJCBINJGCF, [NotNull][ACEKLAKDMBL(null)] DPBGHGFKPMM MOHCHEAHNMD, [NotNull][ACEKLAKDMBL(null)] GBEHEHLFCID GBLFMIICBDJ, [NotNull][ACEKLAKDMBL(null)] BGELEMHCFAJ<KeepsakesConfig.KeepsakesOptions> GEAIFDNFEOL, [NotNull][ACEKLAKDMBL(null)] LALKFIOPJMN HNFNHEGHMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x587E450", Offset = "0x587D050", VA = "0x18587E450", Slot = "15")]
	public bool LEEAOBELJPB(List<string> DOOOIMMJJJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x58786C0", Offset = "0x58772C0", VA = "0x1858786C0", Slot = "16")]
	public NBFPPJGKGOH<Guid> DLECKKNFDNC(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x587A7B0", Offset = "0x58793B0", VA = "0x18587A7B0", Slot = "17")]
	public EILHPPDHBHH GACFCBKBMLE(Guid NCDLOEBMMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x587B160", Offset = "0x5879D60", VA = "0x18587B160", Slot = "18")]
	public EILHPPDHBHH GKFDGGAKIJN(Guid NCDLOEBMMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x587CA30", Offset = "0x587B630", VA = "0x18587CA30", Slot = "19")]
	public bool IHNACDMNHBO(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5880880", Offset = "0x587F480", VA = "0x185880880", Slot = "20")]
	public bool OKNLFICGAAJ(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5876200", Offset = "0x5874E00", VA = "0x185876200")]
	public KeepsakeTheme BODBGIPAHKB(Guid NCDLOEBMMGD)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5874B40", Offset = "0x5873740", VA = "0x185874B40")]
	public bool AFPPIGBMBJL(LNCLLEGDNJK PIKCKAKDFFC, out KeepsakeTheme BLAHOBJOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x587F0D0", Offset = "0x587DCD0", VA = "0x18587F0D0")]
	public List<KeepsakeTheme> MKNMCBILCPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x58811D0", Offset = "0x587FDD0", VA = "0x1858811D0")]
	public int PHKAPKIHHOH(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5874430", Offset = "0x5873030", VA = "0x185874430")]
	public LNCLLEGDNJK ADCCAMCIFKI(Guid NCDLOEBMMGD)
	{
		return default(LNCLLEGDNJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5879AB0", Offset = "0x58786B0", VA = "0x185879AB0", Slot = "34")]
	public List<LNCLLEGDNJK> EMOGDPLJOOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5880E20", Offset = "0x587FA20", VA = "0x185880E20", Slot = "35")]
	public IComparer<LNCLLEGDNJK> PCAKCLMKPIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x587BE70", Offset = "0x587AA70", VA = "0x18587BE70", Slot = "32")]
	public string HKLLNLDFMIL(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x587D8A0", Offset = "0x587C4A0", VA = "0x18587D8A0", Slot = "33")]
	public string KIPOFHGHGLO(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x587CB80", Offset = "0x587B780", VA = "0x18587CB80", Slot = "21")]
	public bool IJJIJGKFIAM(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x587B850", Offset = "0x587A450", VA = "0x18587B850", Slot = "22")]
	public void HFNPEKAKFJB(Guid NCDLOEBMMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x587D500", Offset = "0x587C100", VA = "0x18587D500", Slot = "23")]
	public void JOGMDMAJIAI(LNCLLEGDNJK PIKCKAKDFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5877DF0", Offset = "0x58769F0", VA = "0x185877DF0", Slot = "24")]
	public void DCAHMBOCKPF(Guid NCDLOEBMMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x587DE20", Offset = "0x587CA20", VA = "0x18587DE20", Slot = "25")]
	public int KMKIOHKONCF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x587DAB0", Offset = "0x587C6B0", VA = "0x18587DAB0", Slot = "54")]
	public int KMKIOHKONCF(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5874730", Offset = "0x5873330", VA = "0x185874730", Slot = "31")]
	public NBFPPJGKGOH<IEnumerable<Guid>> AFJEGDJGBGL(long HAMIEGOKEJC, long JEBGGHOLKHJ, LNCLLEGDNJK? PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x587FE60", Offset = "0x587EA60", VA = "0x18587FE60", Slot = "30")]
	public NBFPPJGKGOH<IEnumerable<Guid>> NHMNMGCCMAL(long HAMIEGOKEJC, long JEBGGHOLKHJ, LNCLLEGDNJK? PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5878140", Offset = "0x5876D40", VA = "0x185878140", Slot = "55")]
	public NBFPPJGKGOH<Dictionary<Guid, LNCLLEGDNJK>> DFJKMAACPEH(long HAMIEGOKEJC, long JEBGGHOLKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x58745A0", Offset = "0x58731A0", VA = "0x1858745A0", Slot = "56")]
	public NBFPPJGKGOH<Dictionary<Guid, LNCLLEGDNJK>> ADLNEKLFANK(long HAMIEGOKEJC, long JEBGGHOLKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x587EC80", Offset = "0x587D880", VA = "0x18587EC80", Slot = "26")]
	public NBFPPJGKGOH<int> LKLGDPDJJBP(long HAMIEGOKEJC, long JEBGGHOLKHJ, LNCLLEGDNJK? PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5880450", Offset = "0x587F050", VA = "0x185880450", Slot = "27")]
	public NBFPPJGKGOH<int> ODKKCKLKDMP(long HAMIEGOKEJC, long JEBGGHOLKHJ, LNCLLEGDNJK? PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x587FC40", Offset = "0x587E840", VA = "0x18587FC40", Slot = "28")]
	public NBFPPJGKGOH<Dictionary<LNCLLEGDNJK, int>> NFPPPLBCDGB(long HAMIEGOKEJC, long JEBGGHOLKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x587B090", Offset = "0x5879C90", VA = "0x18587B090", Slot = "29")]
	public NBFPPJGKGOH<Dictionary<LNCLLEGDNJK, int>> GICMJGFPMKE(long HAMIEGOKEJC, long JEBGGHOLKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x587BFE0", Offset = "0x587ABE0", VA = "0x18587BFE0", Slot = "37")]
	public bool HMLMELBHIAK(long HAMIEGOKEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x587B4F0", Offset = "0x587A0F0", VA = "0x18587B4F0", Slot = "57")]
	public bool GOIJIJGMLGN(long HAMIEGOKEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5879DF0", Offset = "0x58789F0", VA = "0x185879DF0", Slot = "38")]
	public bool EPFJFFOEGBE(long HAMIEGOKEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5878D00", Offset = "0x5877900", VA = "0x185878D00", Slot = "58")]
	public bool DMGJGJCOAGC(long HAMIEGOKEJC, out ILBJKOKJFAE HHICIBAIJGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5879C00", Offset = "0x5878800", VA = "0x185879C00", Slot = "39")]
	public bool EPDEJPKEOLG(long IICNEKLODJO, out DateTime APGLPJPNNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5875550", Offset = "0x5874150", VA = "0x185875550", Slot = "40")]
	public long BGNAFFIAPPJ(long IICNEKLODJO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x587D200", Offset = "0x587BE00", VA = "0x18587D200", Slot = "59")]
	public IEnumerable<int> JJICPKGOCLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x58785A0", Offset = "0x58771A0", VA = "0x1858785A0", Slot = "41")]
	public long DJEAJBELGFG(long HAMIEGOKEJC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x587C810", Offset = "0x587B410", VA = "0x18587C810", Slot = "42")]
	public int IHFBCDDDFBJ(long IICNEKLODJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x587F7F0", Offset = "0x587E3F0", VA = "0x18587F7F0", Slot = "43")]
	public bool NDHFIHBFJGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x58805C0", Offset = "0x587F1C0", VA = "0x1858805C0", Slot = "44")]
	public bool OEFGMKGGNDO(long IICNEKLODJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x587C190", Offset = "0x587AD90", VA = "0x18587C190", Slot = "45")]
	public IEnumerable<long> IEAMGJOFINO(long IICNEKLODJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5878090", Offset = "0x5876C90", VA = "0x185878090", Slot = "46")]
	public int DFDOPLMBKAA(long IICNEKLODJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x58800B0", Offset = "0x587ECB0", VA = "0x1858800B0", Slot = "50")]
	public long NOGDJKELNAE(long JBHAABPKJOI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x587C450", Offset = "0x587B050", VA = "0x18587C450", Slot = "51")]
	public LNCLLEGDNJK IGODJLINLGJ()
	{
		return default(LNCLLEGDNJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x587CF10", Offset = "0x587BB10", VA = "0x18587CF10")]
	private bool INHPGCCICJH(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x587E750", Offset = "0x587D350", VA = "0x18587E750")]
	private void LFOPFDBGCIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x587B550", Offset = "0x587A150", VA = "0x18587B550")]
	private LNCLLEGDNJK HENBIKLOLNO()
	{
		return default(LNCLLEGDNJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x587B8C0", Offset = "0x587A4C0", VA = "0x18587B8C0")]
	private void HHADFKJHOCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5881340", Offset = "0x587FF40", VA = "0x185881340")]
	private int PIPDHLGEBAA(KeepsakeRoomListDTO GKPNIMLNKIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5875150", Offset = "0x5873D50", VA = "0x185875150")]
	private int BAGFMIEBCLA(DateTime EMIGJDPDFNN, DateTime NFCDPKIMBCO, TimeSpan CICJHNFLLOD, int BELKPPEAGGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5879F30", Offset = "0x5878B30", VA = "0x185879F30")]
	private void FDDECLKILFI(IEnumerable<KeepsakeInstanceDTO> OLGKFMPNNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5880F90", Offset = "0x587FB90", VA = "0x185880F90")]
	private void PEIAIOBLEIP(IEnumerable<KeepsakeCollectionRecordDTO> LBOOKCBNNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x58803F0", Offset = "0x587EFF0", VA = "0x1858803F0")]
	private void OCIDGGMOKCM(IEnumerable<long> KDPKJCGIHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x14BB540", Offset = "0x14BA140", VA = "0x1814BB540")]
	private void ILHMHMNDIND(KeepsakeGlobalConfigDTO ADKOINCHDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5875980", Offset = "0x5874580", VA = "0x185875980")]
	private bool BIFPBLCDHIF(LNCLLEGDNJK PIKCKAKDFFC, out Guid IKDEFKDHIJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x587D130", Offset = "0x587BD30", VA = "0x18587D130")]
	private bool JFOMOKAGNEB(out Guid IKDEFKDHIJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5878030", Offset = "0x5876C30", VA = "0x185878030")]
	private bool DDIPFKOKHEM(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x587D740", Offset = "0x587C340", VA = "0x18587D740")]
	private IEnumerable<Guid> KHHJHKOENIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5880EC0", Offset = "0x587FAC0", VA = "0x185880EC0")]
	private IEnumerable<KeepsakeInstanceDTO> PCEFOPANNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5880000", Offset = "0x587EC00", VA = "0x185880000")]
	private void NIPCFIFMNFK(Guid NCDLOEBMMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x587D450", Offset = "0x587C050", VA = "0x18587D450")]
	private bool JNLEEEIGJPJ(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5874FB0", Offset = "0x5873BB0", VA = "0x185874FB0")]
	private void BABCFMGBDCP(Guid NCDLOEBMMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x587D050", Offset = "0x587BC50", VA = "0x18587D050")]
	private void JCJHLLAKALL(LNCLLEGDNJK KBBEMPODLCC, int BIGOLAIOAAK, ref Dictionary<LNCLLEGDNJK, int> KMHNOICCHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x587A4D0", Offset = "0x58790D0", VA = "0x18587A4D0")]
	private int FFEIGFMMELN(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5874D10", Offset = "0x5873910", VA = "0x185874D10")]
	private void AOACBKAOCGJ(KeepsakeInstanceDTO CBLCNAAIFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5875350", Offset = "0x5873F50", VA = "0x185875350")]
	private void BBBDAOPDHLO(KeepsakeInstanceDTO CBLCNAAIFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x58765C0", Offset = "0x58751C0", VA = "0x1858765C0")]
	private void CDMOGJDEICJ(Guid NCDLOEBMMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x587D540", Offset = "0x587C140", VA = "0x18587D540")]
	private void JPOHNNKLKPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5879A90", Offset = "0x5878690", VA = "0x185879A90")]
	private void ELDHMPAIKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x587E270", Offset = "0x587CE70", VA = "0x18587E270")]
	private void KNLGJLHCCCL(NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x587AA30", Offset = "0x5879630", VA = "0x18587AA30")]
	private void GAHCFDIKECI(IJAGCJNCGHF.MPAJCLEDGGP HHNPCHNMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x587F070", Offset = "0x587DC70", VA = "0x18587F070")]
	private void MBJGIHKPPFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5876C40", Offset = "0x5875840", VA = "0x185876C40")]
	private void CLCFLMIFOKL(float FHLBOAAPMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x58808B0", Offset = "0x587F4B0", VA = "0x1858808B0")]
	private void OOALMNGLJLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x587E3C0", Offset = "0x587CFC0", VA = "0x18587E3C0")]
	private bool LBFBBMELJMH(Guid NCDLOEBMMGD, out string NCKJIKDEPMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x587FA70", Offset = "0x587E670", VA = "0x18587FA70")]
	private bool NEDKKMEKGCA(Guid NCDLOEBMMGD, out KeepsakeCategoryConfigDTO KBBEMPODLCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5874ED0", Offset = "0x5873AD0", VA = "0x185874ED0")]
	private void AOHDHBMGNOD(string IFIAJHGJOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x587F420", Offset = "0x587E020", VA = "0x18587F420")]
	private bool MMGNPMFPGEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5876960", Offset = "0x5875560", VA = "0x185876960")]
	private IEnumerable<long> CEALGFGDJFH(IEnumerable<KeepsakeRoomDTO> MJDKANALFLO, IEnumerable<KeepsakeRoomListDTO> OFJDHFDBKHJ, long IICNEKLODJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5875C30", Offset = "0x5874830", VA = "0x185875C30")]
	private bool BMKLNNLAILC(Guid NCDLOEBMMGD, out string FKPBDLDGFCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x587C130", Offset = "0x587AD30", VA = "0x18587C130", Slot = "47")]
	public string ICEDGCPIHLL(ILGOKCMADDD KBKLBPALFEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x587AC50", Offset = "0x5879850", VA = "0x18587AC50", Slot = "49")]
	public string GGBCDMOLNDM(ILGOKCMADDD KBKLBPALFEG, long HAMIEGOKEJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x587AA90", Offset = "0x5879690", VA = "0x18587AA90", Slot = "48")]
	public string GBGDGCEFKLC(ILGOKCMADDD KBKLBPALFEG, int DFIKHPGOHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5877090", Offset = "0x5875C90", VA = "0x185877090")]
	private void CMKKAGODMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x587EF30", Offset = "0x587DB30", VA = "0x18587EF30")]
	private void LLCLFKMMHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x587CA10", Offset = "0x587B610", VA = "0x18587CA10")]
	private ILGOKCMADDD IHHEPCJEKDD(HEOEDEOKAAF KNGNHJMHMIM)
	{
		return default(ILGOKCMADDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x587EC60", Offset = "0x587D860", VA = "0x18587EC60")]
	private ILGOKCMADDD LJGBOJBDGPH(HEOEDEOKAAF KNGNHJMHMIM)
	{
		return default(ILGOKCMADDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x58795C0", Offset = "0x58781C0", VA = "0x1858795C0")]
	internal static string EBHHELFNGLO(CNANCDDECEI CMAOBCBOEFF, string DKNEADKLOMJ, bool FNIILLDDLIG, int NIOCGPNCCAN, int DJBGECLLKEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x58790C0", Offset = "0x5877CC0", VA = "0x1858790C0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x587F540", Offset = "0x587E140", VA = "0x18587F540")]
	private IDIFMABCDLA MNBINNHKLCC(IGGCDPKBFGF OHCIFECEBBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x587D5A0", Offset = "0x587C1A0", VA = "0x18587D5A0")]
	private HGGHGJBADJJ KBPDOFPJDID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x587A140", Offset = "0x5878D40", VA = "0x18587A140")]
	private Task FENEEDNHDLO(MOMCOKAPMLC PFFFGKKOEPM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5879920", Offset = "0x5878520", VA = "0x185879920")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ANCEBLIHLHM))]
	private Task EGJCBGFMEJJ(MOMCOKAPMLC PFFFGKKOEPM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5879520", Offset = "0x5878120", VA = "0x185879520")]
	private Task EAMBHGJDAKD(MOMCOKAPMLC PFFFGKKOEPM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x587F8E0", Offset = "0x587E4E0", VA = "0x18587F8E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FPEMIOAKOFJ))]
	private Task NDMIABDIAEH(string DKIECHCHJFL, TimeSpan LMHECMGJIDD, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x460FB80", Offset = "0x460E780", VA = "0x18460FB80")]
	[CompilerGenerated]
	private void KCHHLMBDHHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x587CEC0", Offset = "0x587BAC0", VA = "0x18587CEC0")]
	[CompilerGenerated]
	private void IMIGNJOGJBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x587C040", Offset = "0x587AC40", VA = "0x18587C040")]
	[CompilerGenerated]
	private bool IAPIKCBDFKC(KeepsakeInstanceDTO OLGJDFCIILF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x58797A0", Offset = "0x58783A0", VA = "0x1858797A0")]
	[CompilerGenerated]
	private NBFPPJGKGOH<Dictionary<LNCLLEGDNJK, int>> EEODHJANAAG(Dictionary<Guid, LNCLLEGDNJK> BPMLMDIEHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x587A630", Offset = "0x5879230", VA = "0x18587A630")]
	[CompilerGenerated]
	private NBFPPJGKGOH<Dictionary<LNCLLEGDNJK, int>> FPCLOIFENPI(Dictionary<Guid, LNCLLEGDNJK> BPMLMDIEHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5880090", Offset = "0x587EC90", VA = "0x185880090")]
	[CompilerGenerated]
	private bool NLGEOGLJHPP(KeepsakeRoomListDTO OLGJDFCIILF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5875220", Offset = "0x5873E20", VA = "0x185875220")]
	[CompilerGenerated]
	private bool BAMIHFGFBAA(KeepsakeInstanceDTO OLGJDFCIILF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5876440", Offset = "0x5875040", VA = "0x185876440")]
	[CompilerGenerated]
	private void CAKBLMHCHGI(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<LNCLLEGDNJK, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> JCCJEHKCPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x587A5D0", Offset = "0x58791D0", VA = "0x18587A5D0")]
	[CompilerGenerated]
	private void FGHNGOLDDEL(string FKPBDLDGFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x587F5C0", Offset = "0x587E1C0", VA = "0x18587F5C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1901CE0", Offset = "0x19008E0", VA = "0x181901CE0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
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
