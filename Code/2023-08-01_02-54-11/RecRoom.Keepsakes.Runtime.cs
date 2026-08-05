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
	public class KeepsakesConfig : ScriptableObject, NKBJKHPKCNO<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000004")]
			[CompilerGenerated]
			private sealed class PHIDPAHFEJE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
				public PHIDPAHFEJE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x5783D50", Offset = "0x5782D50", VA = "0x185783D50")]
				internal bool IIAADKNNLNA(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(RVA = "0x5783D50", Offset = "0x5782D50", VA = "0x185783D50")]
				internal bool BGIFJJNGNMF(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x934550", Offset = "0x933550", VA = "0x180934550")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] EMLGEBCPPNH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x57749E0", Offset = "0x57739E0", VA = "0x1857749E0")]
			public bool DDOEEICCKJC(string AAJHDBIOLHD, out KeepsakeTheme DDBLCJALPNP)
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5774960", Offset = "0x5773960", VA = "0x185774960")]
		[OHDKPIIHCBL(BGEACDHIFOF.GameOnly)]
		private static void FHIGGLJNFIH(ECDJHHJLGGB LADPAJPBFMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9A4ED0", Offset = "0x9A3ED0", VA = "0x1809A4ED0")]
		public KeepsakesConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IPLGHILNAEP : IComparer<POHMPBPHJDB>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class JFKKDIAGLKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public POHMPBPHJDB x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public POHMPBPHJDB y;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JFKKDIAGLKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB5F8D0", Offset = "0xB5E8D0", VA = "0x180B5F8D0")]
		internal bool EDBFLMHAKGK(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF2F7A0", Offset = "0xF2E7A0", VA = "0x180F2F7A0")]
		internal bool IGPHEBJKBBF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB5F8D0", Offset = "0xB5E8D0", VA = "0x180B5F8D0")]
		internal bool DELOCPOIIGH(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xF2F7A0", Offset = "0xF2E7A0", VA = "0x180F2F7A0")]
		internal bool JEDMFIGOEMN(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KeepsakeCategoryThemePair> DPAOHMLHKBJ;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x934550", Offset = "0x933550", VA = "0x180934550")]
	public IPLGHILNAEP(List<KeepsakeCategoryThemePair> OKGPGKBBOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x57743D0", Offset = "0x57733D0", VA = "0x1857743D0", Slot = "4")]
	public int Compare(POHMPBPHJDB LMFGBCIIJHA, POHMPBPHJDB FPHLKKGCLDG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum GNMCKAHPDIA
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
		public POHMPBPHJDB KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[LGDEAGBOMDC]
public class NKMCEOCCACG : OOJGBAODHBI, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct ENMNAJGFPJE
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public const string IGAEBOHPIED = "Keepsake placement still in progress. Please wait a moment before placing another keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public const string GIEMAKFMPMB = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public const string MDHMPFOAACG = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string IHMEOGDKBMI = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public const string HIDOCOKLFLP = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const string HACMFHMBDNM = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public const string FJFKFHGGCGN = "You have to collect other keepsakes before you can collect this one.";

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public const string NPBKIFPKFOK = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public const string HAHPNEOLMIL = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public const string AJGNPHENHDF = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public const string MNNDJFJEIJE = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public const string CNIPBNAIGOA = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public const string BMDDEIEKALP = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class AIEPDNJEAOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NKMCEOCCACG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public POHMPBPHJDB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public AIEPDNJEAOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5772970", Offset = "0x5771970", VA = "0x185772970")]
		internal LJAJHHFEMAM<Guid> JOGPOIJJPEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5772AB0", Offset = "0x5771AB0", VA = "0x185772AB0")]
		internal void JOOOFPFNJLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5772910", Offset = "0x5771910", VA = "0x185772910")]
		internal void GJCOCJFIOKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5772480", Offset = "0x5771480", VA = "0x185772480")]
		internal void EGKINCHNFIJ(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x57728E0", Offset = "0x57718E0", VA = "0x1857728E0")]
		internal void GHLEACHMMJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class FAJIMHFMNKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public NKMCEOCCACG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FAJIMHFMNKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5773420", Offset = "0x5772420", VA = "0x185773420")]
		internal void KPKDMCFKALD(PBEOBNCPDBI response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x57733C0", Offset = "0x57723C0", VA = "0x1857733C0")]
		internal void BBPCPJAKGBN(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class EMBDMLIJACK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public EMBDMLIJACK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5773390", Offset = "0x5772390", VA = "0x185773390")]
		internal bool AIOGNIANBLL(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class IDKMJAPLJFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NKMCEOCCACG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public POHMPBPHJDB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public IDKMJAPLJFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x57742B0", Offset = "0x57732B0", VA = "0x1857742B0")]
		internal bool IPCLLAFBLPO(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class FOJDCFFANIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NKMCEOCCACG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public POHMPBPHJDB? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FOJDCFFANIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x57739A0", Offset = "0x57729A0", VA = "0x1857739A0")]
		internal void BMFHLGPCDNG(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x57732E0", Offset = "0x57722E0", VA = "0x1857732E0")]
		internal void PFDNGIJAGOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5773A20", Offset = "0x5772A20", VA = "0x185773A20")]
		internal LJAJHHFEMAM<IEnumerable<Guid>> EHJBABNLKNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3969650", Offset = "0x3968650", VA = "0x183969650")]
		internal bool AOMOBMGMLEJ(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class DPANEKFMBFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public FOJDCFFANIN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public DPANEKFMBFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5772E50", Offset = "0x5771E50", VA = "0x185772E50")]
		internal LJAJHHFEMAM<IEnumerable<Guid>> AKMOBLGPMDB(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class PCADFCGLBDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public DPANEKFMBFD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public PCADFCGLBDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5783B20", Offset = "0x5782B20", VA = "0x185783B20")]
		internal bool IGFHFJNKDMF(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class PCAHPOGCINL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public PCADFCGLBDG CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public PCAHPOGCINL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5783C50", Offset = "0x5782C50", VA = "0x185783C50")]
		internal bool NJJLLGMIMMJ(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class NGDMJAIPLDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public NKMCEOCCACG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NGDMJAIPLDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x57752C0", Offset = "0x57742C0", VA = "0x1857752C0")]
		internal LJAJHHFEMAM<IEnumerable<Guid>> JCIPEFPJLJA(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5773D30", Offset = "0x5772D30", VA = "0x185773D30")]
		internal bool JPPJONOFBDF(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class EGOFOKGLJEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NKMCEOCCACG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public EGOFOKGLJEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5773310", Offset = "0x5772310", VA = "0x185773310")]
		internal void LDAFFCIPFLJ(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x57732E0", Offset = "0x57722E0", VA = "0x1857732E0")]
		internal void IFBDACIIBOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5772FE0", Offset = "0x5771FE0", VA = "0x185772FE0")]
		internal LJAJHHFEMAM<Dictionary<Guid, POHMPBPHJDB>> AGHMMOPALLM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3969650", Offset = "0x3968650", VA = "0x183969650")]
		internal bool JEJNFGBEFNJ(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class FHFOGANLIIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public FHFOGANLIIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x57737D0", Offset = "0x57727D0", VA = "0x1857737D0")]
		internal LJAJHHFEMAM<Dictionary<Guid, POHMPBPHJDB>> ALFKGDCJJKC(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class CAIMINGLIEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CAIMINGLIEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5772CF0", Offset = "0x5771CF0", VA = "0x185772CF0")]
		internal bool MDNLHIJHNEC(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5772B70", Offset = "0x5771B70", VA = "0x185772B70")]
		internal KeyValuePair<Guid, POHMPBPHJDB> KEPCLOBIEJO(Guid instanceId)
		{
			return default(KeyValuePair<Guid, POHMPBPHJDB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GOGODNAFNHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GOGODNAFNHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5773F70", Offset = "0x5772F70", VA = "0x185773F70")]
		internal bool HNCINCHHBFM(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class OJGAJGLACIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OJGAJGLACIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5783920", Offset = "0x5782920", VA = "0x185783920")]
		internal bool ECJPHNGLENC(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class GFPDDJMHDBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public NKMCEOCCACG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GFPDDJMHDBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5773D50", Offset = "0x5772D50", VA = "0x185773D50")]
		internal LJAJHHFEMAM<Dictionary<Guid, POHMPBPHJDB>> GPLGEHGDPPP(Dictionary<Guid, POHMPBPHJDB> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5773D30", Offset = "0x5772D30", VA = "0x185773D30")]
		internal bool ALGKIEPKOJD(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class MDBPMFBGAMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MDBPMFBGAMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5775240", Offset = "0x5774240", VA = "0x185775240")]
		internal bool PAHPHGMLJAK(KeyValuePair<Guid, POHMPBPHJDB> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LIIKBKGKBIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Dictionary<Guid, POHMPBPHJDB> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LIIKBKGKBIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5774BB0", Offset = "0x5773BB0", VA = "0x185774BB0")]
		internal KeyValuePair<POHMPBPHJDB, int> KMNAGPLNKHL(POHMPBPHJDB category)
		{
			return default(KeyValuePair<POHMPBPHJDB, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class GNCODNDMIAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public POHMPBPHJDB category;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GNCODNDMIAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xEB9A80", Offset = "0xEB8A80", VA = "0x180EB9A80")]
		internal bool DOBNMLIJNBH(POHMPBPHJDB instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class OJPDEGJPPDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Dictionary<Guid, POHMPBPHJDB> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OJPDEGJPPDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x57839C0", Offset = "0x57829C0", VA = "0x1857839C0")]
		internal KeyValuePair<POHMPBPHJDB, int> MKAHCPKMMBF(POHMPBPHJDB category)
		{
			return default(KeyValuePair<POHMPBPHJDB, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class EBGJPBKHFKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public POHMPBPHJDB category;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public EBGJPBKHFKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xEB9A80", Offset = "0xEB8A80", VA = "0x180EB9A80")]
		internal bool FJPKBHMBNBC(POHMPBPHJDB instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class IALEDIKPJIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public NKMCEOCCACG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public IALEDIKPJIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5774100", Offset = "0x5773100", VA = "0x185774100")]
		internal bool HKPHNDIHOKI(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x57741E0", Offset = "0x57731E0", VA = "0x1857741E0")]
		internal bool NPJNAMMFNME(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x57740E0", Offset = "0x57730E0", VA = "0x1857740E0")]
		internal bool BMCENNEBBGB(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x57740E0", Offset = "0x57730E0", VA = "0x1857740E0")]
		internal bool INIDKPPHGJM(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JPDKFAHBJHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JPDKFAHBJHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xB672E0", Offset = "0xB662E0", VA = "0x180B672E0")]
		internal bool OEDHDLAALHK(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HIFGFJBMABE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public HIFGFJBMABE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5774010", Offset = "0x5773010", VA = "0x185774010")]
		internal bool LAAHGALCOFB(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xBBB7F0", Offset = "0xBBA7F0", VA = "0x180BBB7F0")]
		internal bool KBBICNANIDA(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CKJMIKACOGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CKJMIKACOGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5772DE0", Offset = "0x5771DE0", VA = "0x185772DE0")]
		internal bool MJJMLGHHGOB(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class EDOGJMENKOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public EDOGJMENKOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xB672E0", Offset = "0xB662E0", VA = "0x180B672E0")]
		internal bool EODCJCMKPPD(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class NMLNOAFDJIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NMLNOAFDJIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5783810", Offset = "0x5782810", VA = "0x185783810")]
		internal bool CEBAKECBFEL(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class NAOPIMIOIPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public POHMPBPHJDB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NAOPIMIOIPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xBC3810", Offset = "0xBC2810", VA = "0x180BC3810")]
		internal bool FCIJCGMOCPL(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class AFGBOKHKFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public AFGBOKHKFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x57723F0", Offset = "0x57713F0", VA = "0x1857723F0")]
		internal bool FAPJCOEFOIC(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class DPPKIFPMIAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public POHMPBPHJDB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public DPPKIFPMIAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5772FA0", Offset = "0x5771FA0", VA = "0x185772FA0")]
		internal bool IALEMNMBNBE(KeyValuePair<Guid, POHMPBPHJDB> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class LLEKHLIOKLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public POHMPBPHJDB newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LLEKHLIOKLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xBC3810", Offset = "0xBC2810", VA = "0x180BC3810")]
		internal bool JGGECIDBBPK(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class AMIEKLJOAPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public AMIEKLJOAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5772AE0", Offset = "0x5771AE0", VA = "0x185772AE0")]
		internal bool PDKFGGGKBMI(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class KNECLIJFNKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public KNECLIJFNKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5774870", Offset = "0x5773870", VA = "0x185774870")]
		internal bool GACDFGIHLFJ(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class OABGLCCJFFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public KNECLIJFNKM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OABGLCCJFFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x57838A0", Offset = "0x57828A0", VA = "0x1857838A0")]
		internal bool KFLPLKDEEBF(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class MADLPHIBCAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public MLICCGFKPBG args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public NKMCEOCCACG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public MADLPHIBCAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5774D10", Offset = "0x5773D10", VA = "0x185774D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class JFHIDOJDNEB : IAsyncStateMachine
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
		public NKMCEOCCACG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JFHIDOJDNEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5774680", Offset = "0x5773680", VA = "0x185774680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int JCCKEOABJJC = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DateTime BFMCJHGGHNO;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const int BACOMOINLHG = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const long GGNMKAEIING = -1L;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const char FIGHJMDGOHH = '|';

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly HICACCOGAAL NEDKPHDBKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly NJPKMOAJGIE ICEEKCLCBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly BADFMFHOJIE EKIHNFHMJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly BEABCMKMHMA HLEBEJPODFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly DJAJPIOICAP PODNILAEFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly BDNFPNBINLM ADAFBKCDFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly FKNLNKENNLO LBONNBDKDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly BMIHHOPKAOM JDANGEIJBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly EBNPJNBFEBI HGLDGHAMHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly NDMOBPFAACJ JHICGMDOOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HLKAHEBIFHP FODNOMMFIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly MHGIOFJHBHA PCMHILNGMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly LLAOOFOFDMK DHFAJABLOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly CNCDBNINDOF JAHMDJFNBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly IJBPODBAIMC IHDCNLLNNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly NKBJKHPKCNO<KeepsakesConfig.KeepsakesOptions> AJCLOJJJGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly APHOMGELIDO LNFFFIBLNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> LOELDBEFHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<Guid> FAPCNECGDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<long> FIIBFDCJGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Dictionary<POHMPBPHJDB, int> MLBGNJEKJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly HashSet<Guid> PDAHMNEOPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly IDisposable OCLJHLBNABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private Task BHJDPKDPCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private LJAJHHFEMAM<Guid> AHLACABFHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private long? HCOEHGBCEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private KeepsakeProgressionEventInstancesDTO EONDGHIHHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private LJAJHHFEMAM<KeepsakeProgressionEventInstancesDTO> EKLCNDJBCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private IReadOnlyDictionary<POHMPBPHJDB, KeepsakeCategoryConfigDTO> EAMODKHGFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private KeepsakeGlobalConfigDTO BNGKPDMCDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private HashSet<long> KAEFCGKDAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private HashSet<long> PMIFAPODDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<KeepsakeRoomListDTO> NKAJACOOBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private List<KeepsakeRoomListDTO> JIKILPLNOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private List<KeepsakeRoomListDTO> IFFILMNPJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<long, string> GPBKAGPPIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<long, string> FHOEBILKHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<long, DateTime> HJOLBPBPJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<long, List<KeepsakeRoomDTO>> FACPPHGKCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Dictionary<long, List<KeepsakeRoomDTO>> MNCACGOLHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Dictionary<long, long> FFHGHBBLKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<string> AEONABKFBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private DateTime BENDPDAIBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly IDisposable ICBEDHBDKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Guid, POHMPBPHJDB> FGPCOPOMDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<POHMPBPHJDB, int> FLPNAPFGLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private List<KeepsakeCategoryThemePair> OKGPGKBBOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private IPLGHILNAEP CJBPIEKKADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool JGMPBCCMNKD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KJEDDJIIMLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1031E00", Offset = "0x1030E00", VA = "0x181031E00", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x960870", Offset = "0x95F870", VA = "0x180960870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NEHNNPLNMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5777F40", Offset = "0x5776F40", VA = "0x185777F40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool JJDJOJEIFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5776F70", Offset = "0x5775F70", VA = "0x185776F70", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long HFNKOLBAKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x57787E0", Offset = "0x57777E0", VA = "0x1857787E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long? AOLBFPDIEAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5778170", Offset = "0x5777170", VA = "0x185778170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool CBIEKLKDJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x577D2D0", Offset = "0x577C2D0", VA = "0x18577D2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> KDABHCFBEKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x105ACF0", Offset = "0x1059CF0", VA = "0x18105ACF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> AMHHLOHLNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA44E60", Offset = "0xA43E60", VA = "0x180A44E60", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<KeepsakeRoomListDTO> GIJLGLBECHD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA44EA0", Offset = "0xA43EA0", VA = "0x180A44EA0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> FADOLNCGCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xC6EC70", Offset = "0xC6DC70", VA = "0x180C6EC70", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyDictionary<long, string> BKFAGCLPCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xEAF020", Offset = "0xEAE020", VA = "0x180EAF020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal bool PGAEOHJCPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x105AD00", Offset = "0x1059D00", VA = "0x18105AD00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x577AD20", Offset = "0x5779D20", VA = "0x18577AD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> NNBLCBOIHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x577AC20", Offset = "0x5779C20", VA = "0x18577AC20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x577A040", Offset = "0x5779040", VA = "0x18577A040", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GJNOIIPHFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5780360", Offset = "0x577F360", VA = "0x185780360", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5780400", Offset = "0x577F400", VA = "0x185780400", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action CIDBDMBDJKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x577EB80", Offset = "0x577DB80", VA = "0x18577EB80", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x577E3D0", Offset = "0x577D3D0", VA = "0x18577E3D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x57824F0", Offset = "0x57814F0", VA = "0x1857824F0")]
	[Preserve]
	internal NKMCEOCCACG([NotNull][KMDNJCFAMOJ(null)] HICACCOGAAL NEDKPHDBKHN, [NotNull][KMDNJCFAMOJ(null)] FPKBGJONHAP CKDMJGJCOOB, [NotNull][KMDNJCFAMOJ(null)] NJPKMOAJGIE ICEEKCLCBGN, [NotNull][KMDNJCFAMOJ(null)] BADFMFHOJIE EKIHNFHMJGK, [NotNull][KMDNJCFAMOJ(null)] BEABCMKMHMA HLEBEJPODFN, [NotNull][KMDNJCFAMOJ(null)] DJAJPIOICAP PODNILAEFJM, [NotNull][KMDNJCFAMOJ(null)] BDNFPNBINLM ADAFBKCDFLC, [NotNull][KMDNJCFAMOJ(null)] FKNLNKENNLO LBONNBDKDDA, [NotNull][KMDNJCFAMOJ(null)] BMIHHOPKAOM JDANGEIJBKM, [NotNull][KMDNJCFAMOJ(null)] DIOJCDHECGP JKNHMDHGNIM, [NotNull][KMDNJCFAMOJ(null)] EBNPJNBFEBI HGLDGHAMHKB, [NotNull][KMDNJCFAMOJ(null)] NDMOBPFAACJ JHICGMDOOON, [NotNull][KMDNJCFAMOJ(null)] HLKAHEBIFHP FODNOMMFIDG, [NotNull][KMDNJCFAMOJ(null)] MHGIOFJHBHA PCMHILNGMEG, [NotNull][KMDNJCFAMOJ(null)] LLAOOFOFDMK DHFAJABLOBM, [NotNull][KMDNJCFAMOJ(null)] CNCDBNINDOF JAHMDJFNBFH, [NotNull][KMDNJCFAMOJ(null)] IJBPODBAIMC IHDCNLLNNBC, [NotNull][KMDNJCFAMOJ(null)] NKBJKHPKCNO<KeepsakesConfig.KeepsakesOptions> AJCLOJJJGCM, [NotNull][KMDNJCFAMOJ(null)] APHOMGELIDO LNFFFIBLNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5781590", Offset = "0x5780590", VA = "0x185781590", Slot = "15")]
	public bool OMHIDKHCLEC(List<string> LJJGJAPNBPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x57818A0", Offset = "0x57808A0", VA = "0x1857818A0", Slot = "16")]
	public LJAJHHFEMAM<Guid> OOAJCMGDKEG(POHMPBPHJDB FBBPJENJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5775740", Offset = "0x5774740", VA = "0x185775740", Slot = "17")]
	public FHJJKILLDME ADKJNBNFJNJ(Guid DOFNMNEMDFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x577FDB0", Offset = "0x577EDB0", VA = "0x18577FDB0", Slot = "18")]
	public FHJJKILLDME MMDBKAIABDD(Guid DOFNMNEMDFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x577CC10", Offset = "0x577BC10", VA = "0x18577CC10", Slot = "19")]
	public bool IDADCJFDEIK(Guid DOFNMNEMDFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x57788B0", Offset = "0x57778B0", VA = "0x1857788B0", Slot = "20")]
	public bool DGLDDJEFPLN(Guid DOFNMNEMDFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x57813D0", Offset = "0x57803D0", VA = "0x1857813D0")]
	public KeepsakeTheme OCEGDNOKCAD(Guid DOFNMNEMDFH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5778610", Offset = "0x5777610", VA = "0x185778610")]
	public bool DBPEDGPMGLD(POHMPBPHJDB FBBPJENJIDG, out KeepsakeTheme DDBLCJALPNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x577B700", Offset = "0x577A700", VA = "0x18577B700")]
	public List<KeepsakeTheme> GLLPLBHKNHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5781F30", Offset = "0x5780F30", VA = "0x185781F30")]
	public int PDAAODCIOFO(POHMPBPHJDB FBBPJENJIDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x577AAB0", Offset = "0x5779AB0", VA = "0x18577AAB0")]
	public POHMPBPHJDB FMNENGAIFPG(Guid DOFNMNEMDFH)
	{
		return default(POHMPBPHJDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5779EF0", Offset = "0x5778EF0", VA = "0x185779EF0", Slot = "34")]
	public List<POHMPBPHJDB> EJEJHALLBJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x577EDD0", Offset = "0x577DDD0", VA = "0x18577EDD0", Slot = "35")]
	public IComparer<POHMPBPHJDB> LJOCHBCDOLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5775430", Offset = "0x5774430", VA = "0x185775430", Slot = "32")]
	public string ABOPCHANFNK(POHMPBPHJDB FBBPJENJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x577EA10", Offset = "0x577DA10", VA = "0x18577EA10", Slot = "33")]
	public string KNGMILPCOCI(POHMPBPHJDB FBBPJENJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x577D9E0", Offset = "0x577C9E0", VA = "0x18577D9E0", Slot = "21")]
	public bool JFAADIJDGKO(Guid DOFNMNEMDFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x577BC70", Offset = "0x577AC70", VA = "0x18577BC70", Slot = "22")]
	public void HGNCENCCMFK(Guid DOFNMNEMDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5776A90", Offset = "0x5775A90", VA = "0x185776A90", Slot = "23")]
	public void BCLHABOGNCJ(POHMPBPHJDB FBBPJENJIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x57766F0", Offset = "0x57756F0", VA = "0x1857766F0", Slot = "24")]
	public void APEFJFGGBFF(Guid DOFNMNEMDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x577C7B0", Offset = "0x577B7B0", VA = "0x18577C7B0", Slot = "25")]
	public int ICNMNPLFGPN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x577C440", Offset = "0x577B440", VA = "0x18577C440", Slot = "54")]
	public int ICNMNPLFGPN(POHMPBPHJDB FBBPJENJIDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x577EE70", Offset = "0x577DE70", VA = "0x18577EE70", Slot = "31")]
	public LJAJHHFEMAM<IEnumerable<Guid>> LKBECGAGHGN(long IIKHCGCAMCH, long KJGGLMIPDJB, POHMPBPHJDB? FBBPJENJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5776AD0", Offset = "0x5775AD0", VA = "0x185776AD0", Slot = "30")]
	public LJAJHHFEMAM<IEnumerable<Guid>> BIFJGHCCILH(long IIKHCGCAMCH, long KJGGLMIPDJB, POHMPBPHJDB? FBBPJENJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x577CD60", Offset = "0x577BD60", VA = "0x18577CD60", Slot = "55")]
	public LJAJHHFEMAM<Dictionary<Guid, POHMPBPHJDB>> IEDDIJGFIID(long IIKHCGCAMCH, long KJGGLMIPDJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x577F720", Offset = "0x577E720", VA = "0x18577F720", Slot = "56")]
	public LJAJHHFEMAM<Dictionary<Guid, POHMPBPHJDB>> MDNDBGFKDCJ(long IIKHCGCAMCH, long KJGGLMIPDJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x577B090", Offset = "0x577A090", VA = "0x18577B090", Slot = "26")]
	public LJAJHHFEMAM<int> GJCHDKAKGIN(long IIKHCGCAMCH, long KJGGLMIPDJB, POHMPBPHJDB? FBBPJENJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5779290", Offset = "0x5778290", VA = "0x185779290", Slot = "27")]
	public LJAJHHFEMAM<int> DOPEHPHKPJL(long IIKHCGCAMCH, long KJGGLMIPDJB, POHMPBPHJDB? FBBPJENJIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x57804A0", Offset = "0x577F4A0", VA = "0x1857804A0", Slot = "28")]
	public LJAJHHFEMAM<Dictionary<POHMPBPHJDB, int>> NGKEHGEDONE(long IIKHCGCAMCH, long KJGGLMIPDJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x577D2F0", Offset = "0x577C2F0", VA = "0x18577D2F0", Slot = "29")]
	public LJAJHHFEMAM<Dictionary<POHMPBPHJDB, int>> IKMEFKCNAAA(long IIKHCGCAMCH, long KJGGLMIPDJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x577E6F0", Offset = "0x577D6F0", VA = "0x18577E6F0", Slot = "37")]
	public bool KDHADAGIAHF(long IIKHCGCAMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x577E9B0", Offset = "0x577D9B0", VA = "0x18577E9B0", Slot = "57")]
	public bool KMCLEACCPOC(long IIKHCGCAMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5782450", Offset = "0x5781450", VA = "0x185782450", Slot = "38")]
	public bool POGKMJCNHNM(long IIKHCGCAMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5776040", Offset = "0x5775040", VA = "0x185776040", Slot = "58")]
	public bool ALEJIJJBKHE(long IIKHCGCAMCH, out JEPIOKIFFOO FGEKFJONIMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5776940", Offset = "0x5775940", VA = "0x185776940", Slot = "39")]
	public bool BAKBNFFEGIF(long MFHMCMMDLBN, out DateTime IJPJMPMOEDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x577D3C0", Offset = "0x577C3C0", VA = "0x18577D3C0", Slot = "40")]
	public long IMGDKGHPMAP(long MFHMCMMDLBN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x57759C0", Offset = "0x57749C0", VA = "0x1857759C0", Slot = "59")]
	public IEnumerable<int> AFIGGGFOPNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x577A810", Offset = "0x5779810", VA = "0x18577A810", Slot = "41")]
	public long FDJDFKJAJFN(long IIKHCGCAMCH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5780730", Offset = "0x577F730", VA = "0x185780730", Slot = "42")]
	public int NNNMCJCBLMO(long MFHMCMMDLBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x577DD80", Offset = "0x577CD80", VA = "0x18577DD80", Slot = "43")]
	public bool JGGDJKMLMAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5780930", Offset = "0x577F930", VA = "0x185780930", Slot = "44")]
	public bool NOMINBGEDGJ(long MFHMCMMDLBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x577E470", Offset = "0x577D470", VA = "0x18577E470", Slot = "45")]
	public IEnumerable<long> KBKDGOLEHIO(long MFHMCMMDLBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x577C370", Offset = "0x577B370", VA = "0x18577C370", Slot = "46")]
	public int HMPIIOOENCD(long MFHMCMMDLBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5782120", Offset = "0x5781120", VA = "0x185782120", Slot = "50")]
	public long PGDLFCLINOD(long PBLIFEIEJBN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x577B350", Offset = "0x577A350", VA = "0x18577B350", Slot = "51")]
	public POHMPBPHJDB GJDFPPOKAIG()
	{
		return default(POHMPBPHJDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x577D7F0", Offset = "0x577C7F0", VA = "0x18577D7F0")]
	private bool INGGBAEPKPD(Guid DOFNMNEMDFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5780EF0", Offset = "0x577FEF0", VA = "0x185780EF0")]
	private void OBCNHEKBENA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5780BF0", Offset = "0x577FBF0", VA = "0x185780BF0")]
	private POHMPBPHJDB NPIOPFHAPMJ()
	{
		return default(POHMPBPHJDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x577BDC0", Offset = "0x577ADC0", VA = "0x18577BDC0")]
	private void HKCKIJBLEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x577A210", Offset = "0x5779210", VA = "0x18577A210")]
	private int EPDPHPIHJNE(KeepsakeRoomListDTO EBEKDKKMPCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5779E20", Offset = "0x5778E20", VA = "0x185779E20")]
	private int EJEBFINAHNA(DateTime BCGHDHOMFFB, DateTime AKILCMGPAON, TimeSpan NENPOCACHFM, int BLHGBKLKDAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5776D60", Offset = "0x5775D60", VA = "0x185776D60")]
	private void BKODGJHDKBC(IEnumerable<KeepsakeInstanceDTO> LOELDBEFHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5776400", Offset = "0x5775400", VA = "0x185776400")]
	private void ALFBINKCJFH(IEnumerable<KeepsakeCollectionRecordDTO> HOMFGNHIGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5777EC0", Offset = "0x5776EC0", VA = "0x185777EC0")]
	private void CDIFNOMDJBA(IEnumerable<long> BLJNCPACBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xF12540", Offset = "0xF11540", VA = "0x180F12540")]
	private void AFDHGHHGKAC(KeepsakeGlobalConfigDTO BNGKPDMCDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5775C10", Offset = "0x5774C10", VA = "0x185775C10")]
	private bool AHNNLMKHMBC(POHMPBPHJDB FBBPJENJIDG, out Guid NNLBEKJCFPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x577F3C0", Offset = "0x577E3C0", VA = "0x18577F3C0")]
	private bool LMJHKFIJKLA(out Guid NNLBEKJCFPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x577F630", Offset = "0x577E630", VA = "0x18577F630")]
	private bool MAAKEILFCBM(Guid DOFNMNEMDFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x577F260", Offset = "0x577E260", VA = "0x18577F260")]
	private IEnumerable<Guid> LLENKOBFJBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x577EC80", Offset = "0x577DC80", VA = "0x18577EC80")]
	private IEnumerable<KeepsakeInstanceDTO> LGHHFAFJJCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5782090", Offset = "0x5781090", VA = "0x185782090")]
	private void PFMPEJHMBBP(Guid DOFNMNEMDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x577D930", Offset = "0x577C930", VA = "0x18577D930")]
	private bool JBBECLHDHHG(Guid DOFNMNEMDFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x577F490", Offset = "0x577E490", VA = "0x18577F490")]
	private void LPLKBCFFIOK(Guid DOFNMNEMDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x577E750", Offset = "0x577D750", VA = "0x18577E750")]
	private void KJJPNKODLAP(POHMPBPHJDB JBBLOIOPEFN, int AINJHDKHJKE, ref Dictionary<POHMPBPHJDB, int> PAOAHECCEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x577DC80", Offset = "0x577CC80", VA = "0x18577DC80")]
	private int JGDLIKCOBFM(POHMPBPHJDB FBBPJENJIDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x577AD90", Offset = "0x5779D90", VA = "0x18577AD90")]
	private void GDFBJFKHDNE(KeepsakeInstanceDTO HHMEHOFBEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5779030", Offset = "0x5778030", VA = "0x185779030")]
	private void DMJONFODFFB(KeepsakeInstanceDTO HHMEHOFBEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x57788E0", Offset = "0x57778E0", VA = "0x1857788E0")]
	private void DKCPNFICLFJ(Guid DOFNMNEMDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5781ED0", Offset = "0x5780ED0", VA = "0x185781ED0")]
	private void PCAHGEGLFHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x577C420", Offset = "0x577B420", VA = "0x18577C420")]
	private void HPBLOOBCDOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x577ED50", Offset = "0x577DD50", VA = "0x18577ED50")]
	private void LIDKCDIPCKE(OPAPHGBBLJD IKJNAMJACKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5779230", Offset = "0x5778230", VA = "0x185779230")]
	private void DOAMKGBLNLM(IEHBPPOIPFM.IEIGOBGFLKI DCGPCJKHCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x577ACC0", Offset = "0x5779CC0", VA = "0x18577ACC0")]
	private void FOPFAHBECJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5778C60", Offset = "0x5777C60", VA = "0x185778C60")]
	private void DMHPDMMIHAN(float GLJEBNBIGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x577DE70", Offset = "0x577CE70", VA = "0x18577DE70")]
	private void JIMMMBAHAIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x577F690", Offset = "0x577E690", VA = "0x18577F690")]
	private bool MCJJFKNNDBD(Guid DOFNMNEMDFH, out string GFEAODFFIFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x577BA50", Offset = "0x577AA50", VA = "0x18577BA50")]
	private bool GOHNOGNMJAF(Guid DOFNMNEMDFH, out KeepsakeCategoryConfigDTO JBBLOIOPEFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x577BCE0", Offset = "0x577ACE0", VA = "0x18577BCE0")]
	private void HHMEGKHFMOB(string MHFKHBKFLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x57784F0", Offset = "0x57774F0", VA = "0x1857784F0")]
	private bool DBGIODEHPBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5778210", Offset = "0x5777210", VA = "0x185778210")]
	private IEnumerable<long> CPBELIDMEHL(IEnumerable<KeepsakeRoomDTO> AMGLMIDOLHK, IEnumerable<KeepsakeRoomListDTO> IKIKDGNCJHO, long MFHMCMMDLBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5779860", Offset = "0x5778860", VA = "0x185779860")]
	private bool EDAELHIBLIO(Guid DOFNMNEMDFH, out string NAFECGLLOCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x577EC20", Offset = "0x577DC20", VA = "0x18577EC20", Slot = "47")]
	public string LFHMNLAFMBH(OGFEJAPOCAM APFLKDKNNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x577A3C0", Offset = "0x57793C0", VA = "0x18577A3C0", Slot = "49")]
	public string FCNPOOMPCJA(OGFEJAPOCAM APFLKDKNNNH, long IIKHCGCAMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5777040", Offset = "0x5776040", VA = "0x185777040", Slot = "48")]
	public string CAKAJOHAMLB(OGFEJAPOCAM APFLKDKNNNH, int EOFJIEAFENB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5777160", Offset = "0x5776160", VA = "0x185777160")]
	private void CBLCCKHBIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x577AF50", Offset = "0x5779F50", VA = "0x18577AF50")]
	private void GEKHBLDPEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5776640", Offset = "0x5775640", VA = "0x185776640")]
	private OGFEJAPOCAM ALJDMFGJGID(AFDFCMIBJMN MBBPMLCKBFF)
	{
		return default(OGFEJAPOCAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5777F20", Offset = "0x5776F20", VA = "0x185777F20")]
	private OGFEJAPOCAM CEDAHCGEKKK(AFDFCMIBJMN MBBPMLCKBFF)
	{
		return default(OGFEJAPOCAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5777F90", Offset = "0x5776F90", VA = "0x185777F90")]
	internal static string CJOLAAHDGLO(PBEOBNCPDBI PJECBKCBEGG, string OJNLJCBDAHB, bool BIAJFPCDMML, int JNDLPEBENPM, int CKPMPMBBDKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5779400", Offset = "0x5778400", VA = "0x185779400", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5776660", Offset = "0x5775660", VA = "0x185776660")]
	private IPDKHLDPLEM ANNFBABKGKA(JMNGDDABPMO COCJDPONKKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x57755A0", Offset = "0x57745A0", VA = "0x1857755A0")]
	private PBCKDOBPMHO ACBKEJCKDHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x577F8B0", Offset = "0x577E8B0", VA = "0x18577F8B0")]
	private Task MHDOOMFLPLO(MLICCGFKPBG JMLOLLOGKEE, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x577FC40", Offset = "0x577EC40", VA = "0x18577FC40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MADLPHIBCAD))]
	private Task MIODBFEDGJC(MLICCGFKPBG JMLOLLOGKEE, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x577E650", Offset = "0x577D650", VA = "0x18577E650")]
	private Task KBNAMPMMMFH(MLICCGFKPBG JMLOLLOGKEE, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x577D140", Offset = "0x577C140", VA = "0x18577D140")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JFHIDOJDNEB))]
	private Task IGGAMHDNOKE(string FANKIHBOOPE, TimeSpan JPIGDLPCNHJ, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4249130", Offset = "0x4248130", VA = "0x184249130")]
	[CompilerGenerated]
	private void OAFPFKKAJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x577BC20", Offset = "0x577AC20", VA = "0x18577BC20")]
	[CompilerGenerated]
	private void HFOACDGOJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5776C70", Offset = "0x5775C70", VA = "0x185776C70")]
	[CompilerGenerated]
	private bool BJLDEBJNIIF(KeepsakeInstanceDTO LMFGBCIIJHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x577E830", Offset = "0x577D830", VA = "0x18577E830")]
	[CompilerGenerated]
	private LJAJHHFEMAM<Dictionary<POHMPBPHJDB, int>> KKCLFLAFDNK(Dictionary<Guid, POHMPBPHJDB> BOHMHGONFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5775EC0", Offset = "0x5774EC0", VA = "0x185775EC0")]
	[CompilerGenerated]
	private LJAJHHFEMAM<Dictionary<POHMPBPHJDB, int>> AJINLEBNDML(Dictionary<Guid, POHMPBPHJDB> BOHMHGONFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5781570", Offset = "0x5780570", VA = "0x185781570")]
	[CompilerGenerated]
	private bool OJJJMNOHCLJ(KeepsakeRoomListDTO LMFGBCIIJHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x577A0E0", Offset = "0x57790E0", VA = "0x18577A0E0")]
	[CompilerGenerated]
	private bool EPDJIBCGKAF(KeepsakeInstanceDTO LMFGBCIIJHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x577A930", Offset = "0x5779930", VA = "0x18577A930")]
	[CompilerGenerated]
	private void FIHBPNJBHFL(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<POHMPBPHJDB, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> AHAIBOJDPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x57806D0", Offset = "0x577F6D0", VA = "0x1857806D0")]
	[CompilerGenerated]
	private void NNIHHDCEBDP(string NAFECGLLOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5780130", Offset = "0x577F130", VA = "0x185780130")]
	[CompilerGenerated]
	private Task MNCBGONPPCE(CancellationToken CLJALPHDLCD)
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
public class FDBBNKLFMFL
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FDBBNKLFMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x12847F0", Offset = "0x12837F0", VA = "0x1812847F0")]
	public static string PBLDHIKHPMH(byte[] IHGCJCCJPMA, byte[] NBKBACBBOJK)
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
