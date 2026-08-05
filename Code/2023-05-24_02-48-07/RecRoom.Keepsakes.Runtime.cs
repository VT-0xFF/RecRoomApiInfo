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
				[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
				public ENDOKGBEGNI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x5916E50", Offset = "0x5915A50", VA = "0x185916E50")]
				internal bool BJFPAIFHKGB(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(RVA = "0x5916E50", Offset = "0x5915A50", VA = "0x185916E50")]
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
			[Cpp2IlInjected.Address(RVA = "0x836EE0", Offset = "0x835AE0", VA = "0x180836EE0")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] IEHJALMPHML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x5917F90", Offset = "0x5916B90", VA = "0x185917F90")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5917F10", Offset = "0x5916B10", VA = "0x185917F10")]
		[BBAPFPLPODF(EDNJEIFHIMJ.GameOnly)]
		private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x12EAAC0", Offset = "0x12E96C0", VA = "0x1812EAAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NCEKFLIMOAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x15D07E0", Offset = "0x15CF3E0", VA = "0x1815D07E0")]
		internal bool EPPFLGGGHAA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1647950", Offset = "0x1646550", VA = "0x181647950")]
		internal bool INJENOPMMGD(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x15D07E0", Offset = "0x15CF3E0", VA = "0x1815D07E0")]
		internal bool EPCANDAGJMO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1647950", Offset = "0x1646550", VA = "0x181647950")]
		internal bool HNPHBPCPIBO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KeepsakeCategoryThemePair> HLPCGDBBOGF;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x836EE0", Offset = "0x835AE0", VA = "0x180836EE0")]
	public EFFLCMOBEOM(List<KeepsakeCategoryThemePair> MDNKPJKEFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5916BA0", Offset = "0x59157A0", VA = "0x185916BA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public HGEKHFMFNDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5917430", Offset = "0x5916030", VA = "0x185917430")]
		internal global::NBFPPJGKGOH<Guid> DGEGIBCEPMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5917580", Offset = "0x5916180", VA = "0x185917580")]
		internal void IHGCFONNJHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5917A20", Offset = "0x5916620", VA = "0x185917A20")]
		internal void MKNMPFBOMAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x59175B0", Offset = "0x59161B0", VA = "0x1859175B0")]
		internal void LLCMPFMLNJN(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5917400", Offset = "0x5916000", VA = "0x185917400")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ACAACCLKDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5915250", Offset = "0x5913E50", VA = "0x185915250")]
		internal void OCFIKMPMGGD(CNANCDDECEI response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x59151F0", Offset = "0x5913DF0", VA = "0x1859151F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ADAELEDLKHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5915600", Offset = "0x5914200", VA = "0x185915600")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ALPLEDGEJOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5915AB0", Offset = "0x59146B0", VA = "0x185915AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ALEAIGDHPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x59156E0", Offset = "0x59142E0", VA = "0x1859156E0")]
		internal void ICFHLEGPJNJ(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5915770", Offset = "0x5914370", VA = "0x185915770")]
		internal void LGAEPNODPPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x59157A0", Offset = "0x59143A0", VA = "0x1859157A0")]
		internal global::NBFPPJGKGOH<IEnumerable<Guid>> NGDJENNJGGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x59156C0", Offset = "0x59142C0", VA = "0x1859156C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public FCNNABCDNFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5916E80", Offset = "0x5915A80", VA = "0x185916E80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public LAJMJEFKDFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5918160", Offset = "0x5916D60", VA = "0x185918160")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DEJKLPDIDLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x59168D0", Offset = "0x59154D0", VA = "0x1859168D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public GLMFMEKEIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5917290", Offset = "0x5915E90", VA = "0x185917290")]
		internal global::NBFPPJGKGOH<IEnumerable<Guid>> PNNCMLMMNDD(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3FA66B0", Offset = "0x3FA52B0", VA = "0x183FA66B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public CKEGELEGDDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5916360", Offset = "0x5914F60", VA = "0x185916360")]
		internal void BLODLPLGAJB(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5915770", Offset = "0x5914370", VA = "0x185915770")]
		internal void CDKGEPBMBAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x59163F0", Offset = "0x5914FF0", VA = "0x1859163F0")]
		internal global::NBFPPJGKGOH<Dictionary<Guid, LNCLLEGDNJK>> DCHPFNGAFKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x59156C0", Offset = "0x59142C0", VA = "0x1859156C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public CMCCEOPJKAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5916700", Offset = "0x5915300", VA = "0x185916700")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public HJHIBMDLFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5917A80", Offset = "0x5916680", VA = "0x185917A80")]
		internal bool EMLABCJLOGF(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5917B70", Offset = "0x5916770", VA = "0x185917B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MELMFIOPEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5918430", Offset = "0x5917030", VA = "0x185918430")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public HMKPCMDAIMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5917CF0", Offset = "0x59168F0", VA = "0x185917CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public AMNPEKBGALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5915BD0", Offset = "0x59147D0", VA = "0x185915BD0")]
		internal global::NBFPPJGKGOH<Dictionary<Guid, LNCLLEGDNJK>> EMGECKIJFHA(Dictionary<Guid, LNCLLEGDNJK> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3FA66B0", Offset = "0x3FA52B0", VA = "0x183FA66B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public OILFCKPJKCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5918760", Offset = "0x5917360", VA = "0x185918760")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public LBEBCILLNMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5918290", Offset = "0x5916E90", VA = "0x185918290")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public CKHLCJPGPKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x209D580", Offset = "0x209C180", VA = "0x18209D580")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MKCOGJIHKAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x59184D0", Offset = "0x59170D0", VA = "0x1859184D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NEAKIHAJPCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x209D580", Offset = "0x209C180", VA = "0x18209D580")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public DNFEPOACAHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x59169D0", Offset = "0x59155D0", VA = "0x1859169D0")]
		internal bool AHAENHDAHGC(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5916AD0", Offset = "0x59156D0", VA = "0x185916AD0")]
		internal bool MJDHLCGHNPF(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5916AB0", Offset = "0x59156B0", VA = "0x185916AB0")]
		internal bool MHOCAFMOLCL(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5916AB0", Offset = "0x59156B0", VA = "0x185916AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public HOHKJIDADEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1267E30", Offset = "0x1266A30", VA = "0x181267E30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public GGMPMGBKOKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x59171C0", Offset = "0x5915DC0", VA = "0x1859171C0")]
		internal bool BOGFKJKANDL(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x188EBE0", Offset = "0x188D7E0", VA = "0x18188EBE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public CBLFLGBKMMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x59162F0", Offset = "0x5914EF0", VA = "0x1859162F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public BCJBKDAPDCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1267E30", Offset = "0x1266A30", VA = "0x181267E30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KGLAFLBNKFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5917D90", Offset = "0x5916990", VA = "0x185917D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public CKONFFDNHDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x18FEFE0", Offset = "0x18FDBE0", VA = "0x1818FEFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public AHJNOIHLONO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5915630", Offset = "0x5914230", VA = "0x185915630")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MAHPJDOMIGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x59183F0", Offset = "0x5916FF0", VA = "0x1859183F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NINDAGLFJMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x18FEFE0", Offset = "0x18FDBE0", VA = "0x1818FEFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public MLKIMEEOMBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5918630", Offset = "0x5917230", VA = "0x185918630")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public KIKNEBDLAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5917E20", Offset = "0x5916A20", VA = "0x185917E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NNECFPHPMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x59186E0", Offset = "0x59172E0", VA = "0x1859186E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public ANCEBLIHLHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5915DF0", Offset = "0x59149F0", VA = "0x185915DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public FPEMIOAKOFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5916FD0", Offset = "0x5915BD0", VA = "0x185916FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x836010", Offset = "0x834C10", VA = "0x180836010", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xCAC080", Offset = "0xCAAC80", VA = "0x180CAC080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JPBNLLDFMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x591C900", Offset = "0x591B500", VA = "0x18591C900", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LGHBAMFLBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x59226A0", Offset = "0x59212A0", VA = "0x1859226A0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long IFMEAPHPBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5920720", Offset = "0x591F320", VA = "0x185920720")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long? GDGIJFMMBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x591EF60", Offset = "0x591DB60", VA = "0x18591EF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool NIBPGDFMBIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x591B3B0", Offset = "0x5919FB0", VA = "0x18591B3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> DLOHJCKKFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xD79B80", Offset = "0xD78780", VA = "0x180D79B80", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> ONGIINNNBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xD79B90", Offset = "0xD78790", VA = "0x180D79B90", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<KeepsakeRoomListDTO> PJPFDGEPKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xD79B50", Offset = "0xD78750", VA = "0x180D79B50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> MDJIAEEJCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1281030", Offset = "0x127FC30", VA = "0x181281030", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyDictionary<long, string> BOPCKGMELAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1022DA0", Offset = "0x10219A0", VA = "0x181022DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal bool BPDDFKDLGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1ACB380", Offset = "0x1AC9F80", VA = "0x181ACB380")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x591B3D0", Offset = "0x5919FD0", VA = "0x18591B3D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> DHLAHCFINBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x59258A0", Offset = "0x59244A0", VA = "0x1859258A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x591E240", Offset = "0x591CE40", VA = "0x18591E240", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PLJHOKBCCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x591A750", Offset = "0x5919350", VA = "0x18591A750", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x59211D0", Offset = "0x591FDD0", VA = "0x1859211D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action IJBEEFCONMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x591E100", Offset = "0x591CD00", VA = "0x18591E100", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5921DC0", Offset = "0x59209C0", VA = "0x185921DC0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5925940", Offset = "0x5924540", VA = "0x185925940")]
	[Preserve]
	internal PNGJHMGJAKF([NotNull][ACEKLAKDMBL(null)] GGJKMMLNPGJ KICNJKGBMEG, [NotNull][ACEKLAKDMBL(null)] BBJHDNJAMLE FBNJAEDAHDH, [NotNull][ACEKLAKDMBL(null)] AHEENIKOBAF LLBBJGGHGON, [NotNull][ACEKLAKDMBL(null)] JCOIHNPPJEE GGIEDNABMJH, [NotNull][ACEKLAKDMBL(null)] CHJNJGLKOPB AJEDEBJNKFM, [NotNull][ACEKLAKDMBL(null)] NCFBJHOACDL FNIFBLHBOOE, [NotNull][ACEKLAKDMBL(null)] CKKILPBAGPK POLHKBGMOIM, [NotNull][ACEKLAKDMBL(null)] BEIIGIJBNMM EAABFFOLONM, [NotNull][ACEKLAKDMBL(null)] EPJFONLPCOB EKLPJDMGHDM, [NotNull][ACEKLAKDMBL(null)] HHJOLBIOKOH OGBFPPIDPHE, [NotNull][ACEKLAKDMBL(null)] DIFPALDBNIJ AGBDEBJEHGE, [NotNull][ACEKLAKDMBL(null)] HOIMKPJHOHJ IKMKIDAPNHI, [NotNull][ACEKLAKDMBL(null)] OIFFEDBLNGN BEBCGFFLELO, [NotNull][ACEKLAKDMBL(null)] DOECGNFCFML MHNJDFMHIBE, [NotNull][ACEKLAKDMBL(null)] KKIEGADMDPM ABJCBINJGCF, [NotNull][ACEKLAKDMBL(null)] DPBGHGFKPMM MOHCHEAHNMD, [NotNull][ACEKLAKDMBL(null)] GBEHEHLFCID GBLFMIICBDJ, [NotNull][ACEKLAKDMBL(null)] global::BGELEMHCFAJ<KeepsakesConfig.KeepsakesOptions> GEAIFDNFEOL, [NotNull][ACEKLAKDMBL(null)] LALKFIOPJMN HNFNHEGHMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5922800", Offset = "0x5921400", VA = "0x185922800", Slot = "15")]
	public bool LEEAOBELJPB(List<string> DOOOIMMJJJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x591CA70", Offset = "0x591B670", VA = "0x18591CA70", Slot = "16")]
	public global::NBFPPJGKGOH<Guid> DLECKKNFDNC(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x591EB60", Offset = "0x591D760", VA = "0x18591EB60", Slot = "17")]
	public EILHPPDHBHH GACFCBKBMLE(Guid NCDLOEBMMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x591F510", Offset = "0x591E110", VA = "0x18591F510", Slot = "18")]
	public EILHPPDHBHH GKFDGGAKIJN(Guid NCDLOEBMMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5920DE0", Offset = "0x591F9E0", VA = "0x185920DE0", Slot = "19")]
	public bool IHNACDMNHBO(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5924C30", Offset = "0x5923830", VA = "0x185924C30", Slot = "20")]
	public bool OKNLFICGAAJ(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x591A5B0", Offset = "0x59191B0", VA = "0x18591A5B0")]
	public KeepsakeTheme BODBGIPAHKB(Guid NCDLOEBMMGD)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5918EF0", Offset = "0x5917AF0", VA = "0x185918EF0")]
	public bool AFPPIGBMBJL(LNCLLEGDNJK PIKCKAKDFFC, out KeepsakeTheme BLAHOBJOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5923480", Offset = "0x5922080", VA = "0x185923480")]
	public List<KeepsakeTheme> MKNMCBILCPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5925580", Offset = "0x5924180", VA = "0x185925580")]
	public int PHKAPKIHHOH(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x59187E0", Offset = "0x59173E0", VA = "0x1859187E0")]
	public LNCLLEGDNJK ADCCAMCIFKI(Guid NCDLOEBMMGD)
	{
		return default(LNCLLEGDNJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x591DE60", Offset = "0x591CA60", VA = "0x18591DE60", Slot = "34")]
	public List<LNCLLEGDNJK> EMOGDPLJOOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x59251D0", Offset = "0x5923DD0", VA = "0x1859251D0", Slot = "35")]
	public IComparer<LNCLLEGDNJK> PCAKCLMKPIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5920220", Offset = "0x591EE20", VA = "0x185920220", Slot = "32")]
	public string HKLLNLDFMIL(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5921C50", Offset = "0x5920850", VA = "0x185921C50", Slot = "33")]
	public string KIPOFHGHGLO(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5920F30", Offset = "0x591FB30", VA = "0x185920F30", Slot = "21")]
	public bool IJJIJGKFIAM(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x591FC00", Offset = "0x591E800", VA = "0x18591FC00", Slot = "22")]
	public void HFNPEKAKFJB(Guid NCDLOEBMMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x59218B0", Offset = "0x59204B0", VA = "0x1859218B0", Slot = "23")]
	public void JOGMDMAJIAI(LNCLLEGDNJK PIKCKAKDFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x591C1A0", Offset = "0x591ADA0", VA = "0x18591C1A0", Slot = "24")]
	public void DCAHMBOCKPF(Guid NCDLOEBMMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x59221D0", Offset = "0x5920DD0", VA = "0x1859221D0", Slot = "25")]
	public int KMKIOHKONCF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5921E60", Offset = "0x5920A60", VA = "0x185921E60", Slot = "54")]
	public int KMKIOHKONCF(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5918AE0", Offset = "0x59176E0", VA = "0x185918AE0", Slot = "31")]
	public global::NBFPPJGKGOH<IEnumerable<Guid>> AFJEGDJGBGL(long HAMIEGOKEJC, long JEBGGHOLKHJ, LNCLLEGDNJK? PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5924210", Offset = "0x5922E10", VA = "0x185924210", Slot = "30")]
	public global::NBFPPJGKGOH<IEnumerable<Guid>> NHMNMGCCMAL(long HAMIEGOKEJC, long JEBGGHOLKHJ, LNCLLEGDNJK? PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x591C4F0", Offset = "0x591B0F0", VA = "0x18591C4F0", Slot = "55")]
	public global::NBFPPJGKGOH<Dictionary<Guid, LNCLLEGDNJK>> DFJKMAACPEH(long HAMIEGOKEJC, long JEBGGHOLKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5918950", Offset = "0x5917550", VA = "0x185918950", Slot = "56")]
	public global::NBFPPJGKGOH<Dictionary<Guid, LNCLLEGDNJK>> ADLNEKLFANK(long HAMIEGOKEJC, long JEBGGHOLKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5923030", Offset = "0x5921C30", VA = "0x185923030", Slot = "26")]
	public global::NBFPPJGKGOH<int> LKLGDPDJJBP(long HAMIEGOKEJC, long JEBGGHOLKHJ, LNCLLEGDNJK? PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5924800", Offset = "0x5923400", VA = "0x185924800", Slot = "27")]
	public global::NBFPPJGKGOH<int> ODKKCKLKDMP(long HAMIEGOKEJC, long JEBGGHOLKHJ, LNCLLEGDNJK? PIKCKAKDFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5923FF0", Offset = "0x5922BF0", VA = "0x185923FF0", Slot = "28")]
	public global::NBFPPJGKGOH<Dictionary<LNCLLEGDNJK, int>> NFPPPLBCDGB(long HAMIEGOKEJC, long JEBGGHOLKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x591F440", Offset = "0x591E040", VA = "0x18591F440", Slot = "29")]
	public global::NBFPPJGKGOH<Dictionary<LNCLLEGDNJK, int>> GICMJGFPMKE(long HAMIEGOKEJC, long JEBGGHOLKHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5920390", Offset = "0x591EF90", VA = "0x185920390", Slot = "37")]
	public bool HMLMELBHIAK(long HAMIEGOKEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x591F8A0", Offset = "0x591E4A0", VA = "0x18591F8A0", Slot = "57")]
	public bool GOIJIJGMLGN(long HAMIEGOKEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x591E1A0", Offset = "0x591CDA0", VA = "0x18591E1A0", Slot = "38")]
	public bool EPFJFFOEGBE(long HAMIEGOKEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x591D0B0", Offset = "0x591BCB0", VA = "0x18591D0B0", Slot = "58")]
	public bool DMGJGJCOAGC(long HAMIEGOKEJC, out ILBJKOKJFAE HHICIBAIJGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x591DFB0", Offset = "0x591CBB0", VA = "0x18591DFB0", Slot = "39")]
	public bool EPDEJPKEOLG(long IICNEKLODJO, out DateTime APGLPJPNNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5919900", Offset = "0x5918500", VA = "0x185919900", Slot = "40")]
	public long BGNAFFIAPPJ(long IICNEKLODJO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x59215B0", Offset = "0x59201B0", VA = "0x1859215B0", Slot = "59")]
	public IEnumerable<int> JJICPKGOCLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x591C950", Offset = "0x591B550", VA = "0x18591C950", Slot = "41")]
	public long DJEAJBELGFG(long HAMIEGOKEJC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5920BC0", Offset = "0x591F7C0", VA = "0x185920BC0", Slot = "42")]
	public int IHFBCDDDFBJ(long IICNEKLODJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5923BA0", Offset = "0x59227A0", VA = "0x185923BA0", Slot = "43")]
	public bool NDHFIHBFJGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5924970", Offset = "0x5923570", VA = "0x185924970", Slot = "44")]
	public bool OEFGMKGGNDO(long IICNEKLODJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5920540", Offset = "0x591F140", VA = "0x185920540", Slot = "45")]
	public IEnumerable<long> IEAMGJOFINO(long IICNEKLODJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x591C440", Offset = "0x591B040", VA = "0x18591C440", Slot = "46")]
	public int DFDOPLMBKAA(long IICNEKLODJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5924460", Offset = "0x5923060", VA = "0x185924460", Slot = "50")]
	public long NOGDJKELNAE(long JBHAABPKJOI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5920800", Offset = "0x591F400", VA = "0x185920800", Slot = "51")]
	public LNCLLEGDNJK IGODJLINLGJ()
	{
		return default(LNCLLEGDNJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x59212C0", Offset = "0x591FEC0", VA = "0x1859212C0")]
	private bool INHPGCCICJH(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5922B00", Offset = "0x5921700", VA = "0x185922B00")]
	private void LFOPFDBGCIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x591F900", Offset = "0x591E500", VA = "0x18591F900")]
	private LNCLLEGDNJK HENBIKLOLNO()
	{
		return default(LNCLLEGDNJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x591FC70", Offset = "0x591E870", VA = "0x18591FC70")]
	private void HHADFKJHOCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x59256F0", Offset = "0x59242F0", VA = "0x1859256F0")]
	private int PIPDHLGEBAA(KeepsakeRoomListDTO GKPNIMLNKIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5919500", Offset = "0x5918100", VA = "0x185919500")]
	private int BAGFMIEBCLA(DateTime EMIGJDPDFNN, DateTime NFCDPKIMBCO, TimeSpan CICJHNFLLOD, int BELKPPEAGGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x591E2E0", Offset = "0x591CEE0", VA = "0x18591E2E0")]
	private void FDDECLKILFI(IEnumerable<KeepsakeInstanceDTO> OLGKFMPNNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5925340", Offset = "0x5923F40", VA = "0x185925340")]
	private void PEIAIOBLEIP(IEnumerable<KeepsakeCollectionRecordDTO> LBOOKCBNNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x59247A0", Offset = "0x59233A0", VA = "0x1859247A0")]
	private void OCIDGGMOKCM(IEnumerable<long> KDPKJCGIHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xDE8D30", Offset = "0xDE7930", VA = "0x180DE8D30")]
	private void ILHMHMNDIND(KeepsakeGlobalConfigDTO ADKOINCHDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5919D30", Offset = "0x5918930", VA = "0x185919D30")]
	private bool BIFPBLCDHIF(LNCLLEGDNJK PIKCKAKDFFC, out Guid IKDEFKDHIJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x59214E0", Offset = "0x59200E0", VA = "0x1859214E0")]
	private bool JFOMOKAGNEB(out Guid IKDEFKDHIJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x591C3E0", Offset = "0x591AFE0", VA = "0x18591C3E0")]
	private bool DDIPFKOKHEM(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5921AF0", Offset = "0x59206F0", VA = "0x185921AF0")]
	private IEnumerable<Guid> KHHJHKOENIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5925270", Offset = "0x5923E70", VA = "0x185925270")]
	private IEnumerable<KeepsakeInstanceDTO> PCEFOPANNFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x59243B0", Offset = "0x5922FB0", VA = "0x1859243B0")]
	private void NIPCFIFMNFK(Guid NCDLOEBMMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5921800", Offset = "0x5920400", VA = "0x185921800")]
	private bool JNLEEEIGJPJ(Guid NCDLOEBMMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5919360", Offset = "0x5917F60", VA = "0x185919360")]
	private void BABCFMGBDCP(Guid NCDLOEBMMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5921400", Offset = "0x5920000", VA = "0x185921400")]
	private void JCJHLLAKALL(LNCLLEGDNJK KBBEMPODLCC, int BIGOLAIOAAK, ref Dictionary<LNCLLEGDNJK, int> KMHNOICCHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x591E880", Offset = "0x591D480", VA = "0x18591E880")]
	private int FFEIGFMMELN(LNCLLEGDNJK PIKCKAKDFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x59190C0", Offset = "0x5917CC0", VA = "0x1859190C0")]
	private void AOACBKAOCGJ(KeepsakeInstanceDTO CBLCNAAIFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5919700", Offset = "0x5918300", VA = "0x185919700")]
	private void BBBDAOPDHLO(KeepsakeInstanceDTO CBLCNAAIFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x591A970", Offset = "0x5919570", VA = "0x18591A970")]
	private void CDMOGJDEICJ(Guid NCDLOEBMMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x59218F0", Offset = "0x59204F0", VA = "0x1859218F0")]
	private void JPOHNNKLKPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x591DE40", Offset = "0x591CA40", VA = "0x18591DE40")]
	private void ELDHMPAIKAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5922620", Offset = "0x5921220", VA = "0x185922620")]
	private void KNLGJLHCCCL(NKHBPCPCMLJ LDHNIIPGDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x591EDE0", Offset = "0x591D9E0", VA = "0x18591EDE0")]
	private void GAHCFDIKECI(IJAGCJNCGHF.MPAJCLEDGGP HHNPCHNMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5923420", Offset = "0x5922020", VA = "0x185923420")]
	private void MBJGIHKPPFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x591AFF0", Offset = "0x5919BF0", VA = "0x18591AFF0")]
	private void CLCFLMIFOKL(float FHLBOAAPMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5924C60", Offset = "0x5923860", VA = "0x185924C60")]
	private void OOALMNGLJLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5922770", Offset = "0x5921370", VA = "0x185922770")]
	private bool LBFBBMELJMH(Guid NCDLOEBMMGD, out string NCKJIKDEPMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5923E20", Offset = "0x5922A20", VA = "0x185923E20")]
	private bool NEDKKMEKGCA(Guid NCDLOEBMMGD, out KeepsakeCategoryConfigDTO KBBEMPODLCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5919280", Offset = "0x5917E80", VA = "0x185919280")]
	private void AOHDHBMGNOD(string IFIAJHGJOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x59237D0", Offset = "0x59223D0", VA = "0x1859237D0")]
	private bool MMGNPMFPGEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x591AD10", Offset = "0x5919910", VA = "0x18591AD10")]
	private IEnumerable<long> CEALGFGDJFH(IEnumerable<KeepsakeRoomDTO> MJDKANALFLO, IEnumerable<KeepsakeRoomListDTO> OFJDHFDBKHJ, long IICNEKLODJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5919FE0", Offset = "0x5918BE0", VA = "0x185919FE0")]
	private bool BMKLNNLAILC(Guid NCDLOEBMMGD, out string FKPBDLDGFCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x59204E0", Offset = "0x591F0E0", VA = "0x1859204E0", Slot = "47")]
	public string ICEDGCPIHLL(ILGOKCMADDD KBKLBPALFEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x591F000", Offset = "0x591DC00", VA = "0x18591F000", Slot = "49")]
	public string GGBCDMOLNDM(ILGOKCMADDD KBKLBPALFEG, long HAMIEGOKEJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x591EE40", Offset = "0x591DA40", VA = "0x18591EE40", Slot = "48")]
	public string GBGDGCEFKLC(ILGOKCMADDD KBKLBPALFEG, int DFIKHPGOHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x591B440", Offset = "0x591A040", VA = "0x18591B440")]
	private void CMKKAGODMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x59232E0", Offset = "0x5921EE0", VA = "0x1859232E0")]
	private void LLCLFKMMHAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5920DC0", Offset = "0x591F9C0", VA = "0x185920DC0")]
	private ILGOKCMADDD IHHEPCJEKDD(HEOEDEOKAAF KNGNHJMHMIM)
	{
		return default(ILGOKCMADDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5923010", Offset = "0x5921C10", VA = "0x185923010")]
	private ILGOKCMADDD LJGBOJBDGPH(HEOEDEOKAAF KNGNHJMHMIM)
	{
		return default(ILGOKCMADDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x591D970", Offset = "0x591C570", VA = "0x18591D970")]
	internal static string EBHHELFNGLO(CNANCDDECEI CMAOBCBOEFF, string DKNEADKLOMJ, bool FNIILLDDLIG, int NIOCGPNCCAN, int DJBGECLLKEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x591D470", Offset = "0x591C070", VA = "0x18591D470", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x59238F0", Offset = "0x59224F0", VA = "0x1859238F0")]
	private IDIFMABCDLA MNBINNHKLCC(IGGCDPKBFGF OHCIFECEBBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5921950", Offset = "0x5920550", VA = "0x185921950")]
	private HGGHGJBADJJ KBPDOFPJDID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x591E4F0", Offset = "0x591D0F0", VA = "0x18591E4F0")]
	private Task FENEEDNHDLO(MOMCOKAPMLC PFFFGKKOEPM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x591DCD0", Offset = "0x591C8D0", VA = "0x18591DCD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ANCEBLIHLHM))]
	private Task EGJCBGFMEJJ(MOMCOKAPMLC PFFFGKKOEPM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x591D8D0", Offset = "0x591C4D0", VA = "0x18591D8D0")]
	private Task EAMBHGJDAKD(MOMCOKAPMLC PFFFGKKOEPM, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5923C90", Offset = "0x5922890", VA = "0x185923C90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FPEMIOAKOFJ))]
	private Task NDMIABDIAEH(string DKIECHCHJFL, TimeSpan LMHECMGJIDD, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4882B20", Offset = "0x4881720", VA = "0x184882B20")]
	[CompilerGenerated]
	private void KCHHLMBDHHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5921270", Offset = "0x591FE70", VA = "0x185921270")]
	[CompilerGenerated]
	private void IMIGNJOGJBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x59203F0", Offset = "0x591EFF0", VA = "0x1859203F0")]
	[CompilerGenerated]
	private bool IAPIKCBDFKC(KeepsakeInstanceDTO OLGJDFCIILF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x591DB50", Offset = "0x591C750", VA = "0x18591DB50")]
	[CompilerGenerated]
	private global::NBFPPJGKGOH<Dictionary<LNCLLEGDNJK, int>> EEODHJANAAG(Dictionary<Guid, LNCLLEGDNJK> BPMLMDIEHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x591E9E0", Offset = "0x591D5E0", VA = "0x18591E9E0")]
	[CompilerGenerated]
	private global::NBFPPJGKGOH<Dictionary<LNCLLEGDNJK, int>> FPCLOIFENPI(Dictionary<Guid, LNCLLEGDNJK> BPMLMDIEHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5924440", Offset = "0x5923040", VA = "0x185924440")]
	[CompilerGenerated]
	private bool NLGEOGLJHPP(KeepsakeRoomListDTO OLGJDFCIILF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x59195D0", Offset = "0x59181D0", VA = "0x1859195D0")]
	[CompilerGenerated]
	private bool BAMIHFGFBAA(KeepsakeInstanceDTO OLGJDFCIILF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x591A7F0", Offset = "0x59193F0", VA = "0x18591A7F0")]
	[CompilerGenerated]
	private void CAKBLMHCHGI(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<LNCLLEGDNJK, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> JCCJEHKCPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x591E980", Offset = "0x591D580", VA = "0x18591E980")]
	[CompilerGenerated]
	private void FGHNGOLDDEL(string FKPBDLDGFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5923970", Offset = "0x5922570", VA = "0x185923970")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAC60", Offset = "0x1DD9860", VA = "0x181DDAC60")]
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
