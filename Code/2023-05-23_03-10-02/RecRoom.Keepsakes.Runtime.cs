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
	public class KeepsakesConfig : ScriptableObject, global::CJPLJALONJA<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000004")]
			[CompilerGenerated]
			private sealed class NKFIOMMPLCP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
				public NKFIOMMPLCP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x10D1510", Offset = "0x10D0910", VA = "0x1810D1510")]
				internal bool GMOKGMKAGLG(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(RVA = "0x10D1510", Offset = "0x10D0910", VA = "0x1810D1510")]
				internal bool MDEAIONNPOI(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x855900", Offset = "0x854D00", VA = "0x180855900")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] IEPPJCCGMIL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x10D0D20", Offset = "0x10D0120", VA = "0x1810D0D20")]
			public bool OLAHFIJJCOE(string DJFFIAHDEHP, out KeepsakeTheme HBMMBHKLLNK)
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
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x10D0CA0", Offset = "0x10D00A0", VA = "0x1810D0CA0")]
		[HECCOHDEPAK(JCKMLGOOEHJ.GameOnly)]
		private static void PKIDGDOGENM(HECDEIOAEPJ BFLCNPAPJDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xBBA390", Offset = "0xBB9790", VA = "0x180BBA390")]
		public KeepsakesConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BHHBDHNGCIJ : IComparer<CCLDPBPGLEA>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class EJIKCHEPLCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public CCLDPBPGLEA x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public CCLDPBPGLEA y;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public EJIKCHEPLCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x10CFE60", Offset = "0x10CF260", VA = "0x1810CFE60")]
		internal bool MAMKLLGDAML(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x10CFE50", Offset = "0x10CF250", VA = "0x1810CFE50")]
		internal bool NBLKFGDCDIH(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x10CFE60", Offset = "0x10CF260", VA = "0x1810CFE60")]
		internal bool IJDNPMKCCAO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x10CFE50", Offset = "0x10CF250", VA = "0x1810CFE50")]
		internal bool GPBAGFBIMJJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KeepsakeCategoryThemePair> EJGEENMAPJH;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x855900", Offset = "0x854D00", VA = "0x180855900")]
	public BHHBDHNGCIJ(List<KeepsakeCategoryThemePair> PPECNDCELDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x10CE730", Offset = "0x10CDB30", VA = "0x1810CE730", Slot = "4")]
	public int Compare(CCLDPBPGLEA MIKJHKLKLDH, CCLDPBPGLEA EJBKGAHMBFP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum PINIKFPNLBJ
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
		public CCLDPBPGLEA KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[HNGHGBCLJCP]
public class OGNINFCNOJJ : KMDGAKGFJAF, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct ILAOFBBFPJN
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public const string NJMPDFMLHHL = "Keepsake placement still in progress. Please wait a moment before placing another keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public const string IDMCOPGJGPC = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public const string DPKMCKPLDOJ = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string EKNEIDJLFPJ = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public const string ADDBBLAAKGO = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const string JKILKBCGONH = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public const string KINKHLLFIJE = "You have to collect other keepsakes before you can collect this one.";

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public const string EHFKBIMHMCP = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public const string MPNLMBFKJCJ = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public const string GKAFNOOOPCG = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public const string KFGJPHKPAOE = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public const string DMMHGBEDIKE = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public const string IOKPLBAMNEB = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DFIKDLGONNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public OGNINFCNOJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CCLDPBPGLEA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DFIKDLGONNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x10CF660", Offset = "0x10CEA60", VA = "0x1810CF660")]
		internal global::CBFHNKNAJIN<Guid> FELEFACBLDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x10CF810", Offset = "0x10CEC10", VA = "0x1810CF810")]
		internal void JBPCBOPMNJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x10CF7B0", Offset = "0x10CEBB0", VA = "0x1810CF7B0")]
		internal void GNDNDBKPBDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x10CF840", Offset = "0x10CEC40", VA = "0x1810CF840")]
		internal void LIJPODBFMIM(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x10CFCB0", Offset = "0x10CF0B0", VA = "0x1810CFCB0")]
		internal void PFNDDMBPMCA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class HPNCMADBJOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public OGNINFCNOJJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HPNCMADBJOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x10D0260", Offset = "0x10CF660", VA = "0x1810D0260")]
		internal void AANCFHHIIPP(GDFAIJBLDEC response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x10D0610", Offset = "0x10CFA10", VA = "0x1810D0610")]
		internal void IKODFCOFICC(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class OLJHAHHGHJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public OLJHAHHGHJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x10DFA20", Offset = "0x10DEE20", VA = "0x1810DFA20")]
		internal bool EOFBJIFBMHK(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class PJFANLMEHBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public OGNINFCNOJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public CCLDPBPGLEA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public PJFANLMEHBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x10DFFC0", Offset = "0x10DF3C0", VA = "0x1810DFFC0")]
		internal bool BAACAHHANLI(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class DEOIKOPMHHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public OGNINFCNOJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CCLDPBPGLEA? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DEOIKOPMHHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x10CF290", Offset = "0x10CE690", VA = "0x1810CF290")]
		internal void HDAMOMKCHBO(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x10CF630", Offset = "0x10CEA30", VA = "0x1810CF630")]
		internal void PGEIHOFHOJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x10CF320", Offset = "0x10CE720", VA = "0x1810CF320")]
		internal global::CBFHNKNAJIN<IEnumerable<Guid>> IBPKPPLDEBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x10CF270", Offset = "0x10CE670", VA = "0x1810CF270")]
		internal bool FFFCGDMOHGF(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class MIFGIJCFDAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public DEOIKOPMHHD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MIFGIJCFDAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x10D12B0", Offset = "0x10D06B0", VA = "0x1810D12B0")]
		internal global::CBFHNKNAJIN<IEnumerable<Guid>> PHACDEPNLHC(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class BLGJAJDMPHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public MIFGIJCFDAC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public BLGJAJDMPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x10CF0B0", Offset = "0x10CE4B0", VA = "0x1810CF0B0")]
		internal bool ECJNIBAJEBD(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class KMJLALDFHCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public BLGJAJDMPHJ CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public KMJLALDFHCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x10D0B00", Offset = "0x10CFF00", VA = "0x1810D0B00")]
		internal bool DFHIGFAAOLP(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class ACLGALIMHJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public OGNINFCNOJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public ACLGALIMHJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x10CE5A0", Offset = "0x10CD9A0", VA = "0x1810CE5A0")]
		internal global::CBFHNKNAJIN<IEnumerable<Guid>> LBKBFHJFNLP(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x10CE710", Offset = "0x10CDB10", VA = "0x1810CE710")]
		internal bool NDEFGPGAMEK(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class OPFAOMCLMAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public OGNINFCNOJJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public OPFAOMCLMAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x10DFC20", Offset = "0x10DF020", VA = "0x1810DFC20")]
		internal void LJJMKINILGD(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x10CF630", Offset = "0x10CEA30", VA = "0x1810CF630")]
		internal void OBPCGHABKCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x10DFCB0", Offset = "0x10DF0B0", VA = "0x1810DFCB0")]
		internal global::CBFHNKNAJIN<Dictionary<Guid, CCLDPBPGLEA>> MIFMFMNJANC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x10CF270", Offset = "0x10CE670", VA = "0x1810CF270")]
		internal bool DAHKFIAKLEN(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class BJANFOHOCHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public BJANFOHOCHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x10CEEE0", Offset = "0x10CE2E0", VA = "0x1810CEEE0")]
		internal global::CBFHNKNAJIN<Dictionary<Guid, CCLDPBPGLEA>> INEFKCFCGCP(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class JCBOFPDKINJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public JCBOFPDKINJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x10D08A0", Offset = "0x10CFCA0", VA = "0x1810D08A0")]
		internal bool LPKFOPMGDPF(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x10D0720", Offset = "0x10CFB20", VA = "0x1810D0720")]
		internal KeyValuePair<Guid, CCLDPBPGLEA> JLKEMEFFLEO(Guid instanceId)
		{
			return default(KeyValuePair<Guid, CCLDPBPGLEA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class KPEOENPENPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public KPEOENPENPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x10D0C00", Offset = "0x10D0000", VA = "0x1810D0C00")]
		internal bool MBBCNGIAFNJ(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class GHOIIJONJML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GHOIIJONJML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x10D0140", Offset = "0x10CF540", VA = "0x1810D0140")]
		internal bool HLEOIANNBHF(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class FEIFPODDIGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public OGNINFCNOJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public FEIFPODDIGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x10CFE70", Offset = "0x10CF270", VA = "0x1810CFE70")]
		internal global::CBFHNKNAJIN<Dictionary<Guid, CCLDPBPGLEA>> HMODILEJLIK(Dictionary<Guid, CCLDPBPGLEA> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x10CE710", Offset = "0x10CDB10", VA = "0x1810CE710")]
		internal bool JNLJGJNCJHK(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class DJBKJBCGMIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public DJBKJBCGMIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x10CFCE0", Offset = "0x10CF0E0", VA = "0x1810CFCE0")]
		internal bool ANPMOLKFINO(KeyValuePair<Guid, CCLDPBPGLEA> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class MEJKHBODHKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Dictionary<Guid, CCLDPBPGLEA> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public MEJKHBODHKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x10D1150", Offset = "0x10D0550", VA = "0x1810D1150")]
		internal KeyValuePair<CCLDPBPGLEA, int> PHLDLPPALHL(CCLDPBPGLEA category)
		{
			return default(KeyValuePair<CCLDPBPGLEA, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class ONJLIOFCCDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CCLDPBPGLEA category;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public ONJLIOFCCDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x10D0AF0", Offset = "0x10CFEF0", VA = "0x1810D0AF0")]
		internal bool DIJGOGIJLNG(CCLDPBPGLEA instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KCOLMBPMDNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Dictionary<Guid, CCLDPBPGLEA> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public KCOLMBPMDNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x10D0990", Offset = "0x10CFD90", VA = "0x1810D0990")]
		internal KeyValuePair<CCLDPBPGLEA, int> PFOCIOGHPBO(CCLDPBPGLEA category)
		{
			return default(KeyValuePair<CCLDPBPGLEA, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class KGOECBJDJBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CCLDPBPGLEA category;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public KGOECBJDJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x10D0AF0", Offset = "0x10CFEF0", VA = "0x1810D0AF0")]
		internal bool AMDIIGPNJAD(CCLDPBPGLEA instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class OMLBEBHCEAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public OGNINFCNOJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public OMLBEBHCEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x10DFB20", Offset = "0x10DEF20", VA = "0x1810DFB20")]
		internal bool EOOPHCLBEKH(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x10DFA50", Offset = "0x10DEE50", VA = "0x1810DFA50")]
		internal bool BIKDOIBAPDM(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x10DFC00", Offset = "0x10DF000", VA = "0x1810DFC00")]
		internal bool HIADHEECIFO(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x10DFC00", Offset = "0x10DF000", VA = "0x1810DFC00")]
		internal bool GOBJIDMHDGH(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JPBFLOMMDMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public JPBFLOMMDMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x10D0120", Offset = "0x10CF520", VA = "0x1810D0120")]
		internal bool IHDEPILFAIE(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class NGDKFLCNNKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NGDKFLCNNKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x10D1440", Offset = "0x10D0840", VA = "0x1810D1440")]
		internal bool FOEKNADKFBE(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x10D1420", Offset = "0x10D0820", VA = "0x1810D1420")]
		internal bool ECLBCNNLJDK(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class LCAPNLMEHPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LCAPNLMEHPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x10D0EF0", Offset = "0x10D02F0", VA = "0x1810D0EF0")]
		internal bool FDPFHKOLIGM(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class FMPGFHLGAMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public FMPGFHLGAMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x10D0120", Offset = "0x10CF520", VA = "0x1810D0120")]
		internal bool BEGHIJKPEBA(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class FGIOBEFBFEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public FGIOBEFBFEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x10D0090", Offset = "0x10CF490", VA = "0x1810D0090")]
		internal bool CNMJJPIBCOJ(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class NFBMLKFKIOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public CCLDPBPGLEA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NFBMLKFKIOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x10D1400", Offset = "0x10D0800", VA = "0x1810D1400")]
		internal bool LHKGFPKJHOB(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class CAEGJCDKANE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public CAEGJCDKANE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x10CF1E0", Offset = "0x10CE5E0", VA = "0x1810CF1E0")]
		internal bool HFIKBBKJFEF(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class OJIBPKOFDDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CCLDPBPGLEA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public OJIBPKOFDDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x10DF9E0", Offset = "0x10DEDE0", VA = "0x1810DF9E0")]
		internal bool BHONCDKGKCN(KeyValuePair<Guid, CCLDPBPGLEA> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class NPFAIMBHBCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public CCLDPBPGLEA newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public NPFAIMBHBCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x10D1400", Offset = "0x10D0800", VA = "0x1810D1400")]
		internal bool KDCDJJLMEMD(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class IANMAANDJCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public IANMAANDJCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x10D0670", Offset = "0x10CFA70", VA = "0x1810D0670")]
		internal bool OFPAHHGKGFP(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class ECAEPLCMPNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public ECAEPLCMPNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x10CFD60", Offset = "0x10CF160", VA = "0x1810CFD60")]
		internal bool GJBAKFMOGII(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class HHEBEJCGIPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public ECAEPLCMPNK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HHEBEJCGIPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x10D01E0", Offset = "0x10CF5E0", VA = "0x1810D01E0")]
		internal bool DCIDCBIOGGK(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class BHOAMACEHOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public HCHGNNMIDGG args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public OGNINFCNOJJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public BHOAMACEHOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x10CE9E0", Offset = "0x10CDDE0", VA = "0x1810CE9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class LPFBGOIGCEJ : IAsyncStateMachine
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
		public OGNINFCNOJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LPFBGOIGCEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x10D0F60", Offset = "0x10D0360", VA = "0x1810D0F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int JIPEOOEHKMI = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DateTime ALOLNMNGOGL;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const int FLJIFOIMHBK = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const long JDHDKICKEHG = -1L;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const char KIECHPONCBB = '|';

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly CFIAEODMMMD DDJFKOPADHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly GBBDMCGBAPN AKGCGMHLOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly NIDBKFFPGIB NHDBKJHJLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly HEMFJNHLCNC FLBGBECLCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IAKKFCPHIJL AKBHIFPBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly FCEIFMFKNJC OBKENHHGBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly KFDMEOCJEEI CJBGGFBOKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly JFJEPCBAEFB CIHBPNDAILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly NAJCBGPKIDP PNLCNJCKIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly BPAPFMBECEG GOKKFJNOIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly JFEBKDEBIPP NGPKHGAIPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly NJHHEBIFFGG GIHFBNHLOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly CIFBLJHFDLD EIDGCGAKOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly GLKLAGDGBPN IPKGHIHIAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly IAFJNKBOOFK OPKGOHKKPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly global::CJPLJALONJA<KeepsakesConfig.KeepsakesOptions> HIHLCMINDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly FAPBONLDLGM DEGDNNLEMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> FHKJJDBEEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<Guid> NIMHOBDEIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<long> KFHKMLJKOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Dictionary<CCLDPBPGLEA, int> PDCBJOJGOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly HashSet<Guid> OFHFKNLAHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly IDisposable IHJGPIMAOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private Task DMOCKFNPCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private global::CBFHNKNAJIN<Guid> JAOKKGHFAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private long? BKBDJMPOGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private KeepsakeProgressionEventInstancesDTO CEGBKDJIFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private global::CBFHNKNAJIN<KeepsakeProgressionEventInstancesDTO> FIOGKAKNHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private IReadOnlyDictionary<CCLDPBPGLEA, KeepsakeCategoryConfigDTO> MAJNLOJECHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private KeepsakeGlobalConfigDTO APJJHEEODCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private HashSet<long> HEIGACBDNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private HashSet<long> KIICKFJCPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<KeepsakeRoomListDTO> MGMFADFBPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private List<KeepsakeRoomListDTO> EEMDBPLKJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private List<KeepsakeRoomListDTO> MBHKIMFIMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<long, string> OLPIMCMOCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<long, string> KBDLKBCMDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<long, DateTime> IIIMBNEFLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<long, List<KeepsakeRoomDTO>> EGJGCAHALEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Dictionary<long, List<KeepsakeRoomDTO>> OIACNNHLHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Dictionary<long, long> FNDEFMPEBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<string> JCGJKBMPPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private DateTime KLAADIGBOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly IDisposable EJBEKMKBHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Guid, CCLDPBPGLEA> MIBFFBKFLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<CCLDPBPGLEA, int> OMJPHDHEELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private List<KeepsakeCategoryThemePair> PPECNDCELDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private BHHBDHNGCIJ CNGPDNMHEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool DINLJHHDOGO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CDAJDJFOCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x854A40", Offset = "0x853E40", VA = "0x180854A40", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x877EF0", Offset = "0x8772F0", VA = "0x180877EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HPDLHDMPFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x10DBD90", Offset = "0x10DB190", VA = "0x1810DBD90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool JEBDFKKHNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x10DBDE0", Offset = "0x10DB1E0", VA = "0x1810DBDE0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long DDAAFJEFJNL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x10D34A0", Offset = "0x10D28A0", VA = "0x1810D34A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long? HDPKNJFEMNP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x10D7DE0", Offset = "0x10D71E0", VA = "0x1810D7DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool JOKGGGKELGC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x10D9CC0", Offset = "0x10D90C0", VA = "0x1810D9CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> LKCIIDHMKKF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xEB2690", Offset = "0xEB1A90", VA = "0x180EB2690", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> JOPMNKHMDOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xEB26A0", Offset = "0xEB1AA0", VA = "0x180EB26A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<KeepsakeRoomListDTO> MDDIGLOHBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xEB2660", Offset = "0xEB1A60", VA = "0x180EB2660", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> CPHNNLADAOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x10D3110", Offset = "0x10D2510", VA = "0x1810D3110", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyDictionary<long, string> OJCJFLGGEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x10D3290", Offset = "0x10D2690", VA = "0x1810D3290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal bool LPCIEIOPIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x10DBC90", Offset = "0x10DB090", VA = "0x1810DBC90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x10DBCA0", Offset = "0x10DB0A0", VA = "0x1810DBCA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> NMIBBBPDPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x10DB310", Offset = "0x10DA710", VA = "0x1810DB310", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x10D71C0", Offset = "0x10D65C0", VA = "0x1810D71C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action INLHHGCHLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x10D9160", Offset = "0x10D8560", VA = "0x1810D9160", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x10D9490", Offset = "0x10D8890", VA = "0x1810D9490", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JKHEHDAOILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x10DC650", Offset = "0x10DBA50", VA = "0x1810DC650", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x10D15A0", Offset = "0x10D09A0", VA = "0x1810D15A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x10DE6D0", Offset = "0x10DDAD0", VA = "0x1810DE6D0")]
	[Preserve]
	internal OGNINFCNOJJ([NotNull][KFMNGACPMHN(null)] CFIAEODMMMD DDJFKOPADHE, [NotNull][KFMNGACPMHN(null)] OGHAMKLKMJE KCJAMJFOIBA, [NotNull][KFMNGACPMHN(null)] GBBDMCGBAPN AKGCGMHLOFM, [NotNull][KFMNGACPMHN(null)] NIDBKFFPGIB NHDBKJHJLPE, [NotNull][KFMNGACPMHN(null)] HEMFJNHLCNC FLBGBECLCFA, [NotNull][KFMNGACPMHN(null)] IAKKFCPHIJL AKBHIFPBKGF, [NotNull][KFMNGACPMHN(null)] FCEIFMFKNJC OBKENHHGBGP, [NotNull][KFMNGACPMHN(null)] KFDMEOCJEEI CJBGGFBOKCG, [NotNull][KFMNGACPMHN(null)] JFJEPCBAEFB CIHBPNDAILF, [NotNull][KFMNGACPMHN(null)] JFNDEPLPNAM HMOKLEOEGON, [NotNull][KFMNGACPMHN(null)] NAJCBGPKIDP PNLCNJCKIAI, [NotNull][KFMNGACPMHN(null)] BPAPFMBECEG GOKKFJNOIIF, [NotNull][KFMNGACPMHN(null)] JFEBKDEBIPP NGPKHGAIPPA, [NotNull][KFMNGACPMHN(null)] NJHHEBIFFGG GIHFBNHLOHH, [NotNull][KFMNGACPMHN(null)] CIFBLJHFDLD EIDGCGAKOHJ, [NotNull][KFMNGACPMHN(null)] GLKLAGDGBPN IPKGHIHIAIH, [NotNull][KFMNGACPMHN(null)] IAFJNKBOOFK OPKGOHKKPDI, [NotNull][KFMNGACPMHN(null)] global::CJPLJALONJA<KeepsakesConfig.KeepsakesOptions> HIHLCMINDAB, [NotNull][KFMNGACPMHN(null)] FAPBONLDLGM DEGDNNLEMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x10DAB30", Offset = "0x10D9F30", VA = "0x1810DAB30", Slot = "15")]
	public bool MJMDBLMHBJL(List<string> DJJEHKONEHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x10D4B00", Offset = "0x10D3F00", VA = "0x1810D4B00", Slot = "16")]
	public global::CBFHNKNAJIN<Guid> EOLALOCIOFA(CCLDPBPGLEA EIJDJFDKAHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x10D4150", Offset = "0x10D3550", VA = "0x1810D4150", Slot = "17")]
	public FKADHPEOOEO EDCLCCINBFE(Guid NLEOMGLIGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x10D2B60", Offset = "0x10D1F60", VA = "0x1810D2B60", Slot = "18")]
	public FKADHPEOOEO CDIACKDFAND(Guid NLEOMGLIGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x10DA7D0", Offset = "0x10D9BD0", VA = "0x1810DA7D0", Slot = "19")]
	public bool MDKMKHJAJLA(Guid NLEOMGLIGJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x10DE070", Offset = "0x10DD470", VA = "0x1810DE070", Slot = "20")]
	public bool PJHBFFDPJLB(Guid NLEOMGLIGJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x10DC6F0", Offset = "0x10DBAF0", VA = "0x1810DC6F0")]
	public KeepsakeTheme OOBHNNBFNME(Guid NLEOMGLIGJK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x10D20A0", Offset = "0x10D14A0", VA = "0x1810D20A0")]
	public bool BHFMGGCOEOA(CCLDPBPGLEA EIJDJFDKAHK, out KeepsakeTheme HBMMBHKLLNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x10D6E70", Offset = "0x10D6270", VA = "0x1810D6E70")]
	public List<KeepsakeTheme> HPCGGMDIOPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x10D9200", Offset = "0x10D8600", VA = "0x1810D9200")]
	public int KEFPFIACKDB(CCLDPBPGLEA EIJDJFDKAHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x10D5230", Offset = "0x10D4630", VA = "0x1810D5230")]
	public CCLDPBPGLEA FFJOELKNMHA(Guid NLEOMGLIGJK)
	{
		return default(CCLDPBPGLEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x10D7FB0", Offset = "0x10D73B0", VA = "0x1810D7FB0", Slot = "34")]
	public List<CCLDPBPGLEA> JLGFKKINGHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x10D9590", Offset = "0x10D8990", VA = "0x1810D9590", Slot = "35")]
	public IComparer<CCLDPBPGLEA> KIMDKABFMPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x10D29F0", Offset = "0x10D1DF0", VA = "0x1810D29F0", Slot = "32")]
	public string CCFBMCIGLAI(CCLDPBPGLEA EIJDJFDKAHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x10D1F30", Offset = "0x10D1330", VA = "0x1810D1F30", Slot = "33")]
	public string BFCAAMKBBOI(CCLDPBPGLEA EIJDJFDKAHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x10DA3F0", Offset = "0x10D97F0", VA = "0x1810DA3F0", Slot = "21")]
	public bool MBBFDLHCJNB(Guid NLEOMGLIGJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x10D3C20", Offset = "0x10D3020", VA = "0x1810D3C20", Slot = "22")]
	public void DOKELNCFDPA(Guid NLEOMGLIGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x10D8100", Offset = "0x10D7500", VA = "0x1810D8100", Slot = "23")]
	public void JLILDBJDFNP(CCLDPBPGLEA EIJDJFDKAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x10D2270", Offset = "0x10D1670", VA = "0x1810D2270", Slot = "24")]
	public void BIGFJOMDGMC(Guid NLEOMGLIGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x10DCC00", Offset = "0x10DC000", VA = "0x1810DCC00", Slot = "25")]
	public int OPENFGOHFAB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x10DC890", Offset = "0x10DBC90", VA = "0x1810DC890", Slot = "54")]
	public int OPENFGOHFAB(CCLDPBPGLEA EIJDJFDKAHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x10D5580", Offset = "0x10D4980", VA = "0x1810D5580", Slot = "31")]
	public global::CBFHNKNAJIN<IEnumerable<Guid>> FKLIBHAKDFL(long MEFEJANAPKD, long NOAKJPLALPD, CCLDPBPGLEA? EIJDJFDKAHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x10D1B30", Offset = "0x10D0F30", VA = "0x1810D1B30", Slot = "30")]
	public global::CBFHNKNAJIN<IEnumerable<Guid>> ALGLMJMLBIB(long MEFEJANAPKD, long NOAKJPLALPD, CCLDPBPGLEA? EIJDJFDKAHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x10D25E0", Offset = "0x10D19E0", VA = "0x1810D25E0", Slot = "55")]
	public global::CBFHNKNAJIN<Dictionary<Guid, CCLDPBPGLEA>> BPFGJDGHNPD(long MEFEJANAPKD, long NOAKJPLALPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x10D4950", Offset = "0x10D3D50", VA = "0x1810D4950", Slot = "56")]
	public global::CBFHNKNAJIN<Dictionary<Guid, CCLDPBPGLEA>> EJDMAFMDFCJ(long MEFEJANAPKD, long NOAKJPLALPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x10DB3B0", Offset = "0x10DA7B0", VA = "0x1810DB3B0", Slot = "26")]
	public global::CBFHNKNAJIN<int> NBFEMLFOCGB(long MEFEJANAPKD, long NOAKJPLALPD, CCLDPBPGLEA? EIJDJFDKAHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x10D3120", Offset = "0x10D2520", VA = "0x1810D3120", Slot = "27")]
	public global::CBFHNKNAJIN<int> CJGPKIHFPJP(long MEFEJANAPKD, long NOAKJPLALPD, CCLDPBPGLEA? EIJDJFDKAHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x10D2EF0", Offset = "0x10D22F0", VA = "0x1810D2EF0", Slot = "28")]
	public global::CBFHNKNAJIN<Dictionary<CCLDPBPGLEA, int>> CHKOGGKDOEK(long MEFEJANAPKD, long NOAKJPLALPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x10DD670", Offset = "0x10DCA70", VA = "0x1810DD670", Slot = "29")]
	public global::CBFHNKNAJIN<Dictionary<CCLDPBPGLEA, int>> PHDCJFJIBMN(long MEFEJANAPKD, long NOAKJPLALPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x10D9690", Offset = "0x10D8A90", VA = "0x1810D9690", Slot = "37")]
	public bool LAGAMMKFHPM(long MEFEJANAPKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x10D7E80", Offset = "0x10D7280", VA = "0x1810D7E80", Slot = "57")]
	public bool JFDFHMNJFHI(long MEFEJANAPKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x10D1A90", Offset = "0x10D0E90", VA = "0x1810D1A90", Slot = "38")]
	public bool ALDMGGMFLKD(long MEFEJANAPKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x10DAF50", Offset = "0x10DA350", VA = "0x1810DAF50", Slot = "58")]
	public bool MNLNMIAKDAE(long MEFEJANAPKD, out EABOONIFPHF PHDCMHLMFDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x10DBA20", Offset = "0x10DAE20", VA = "0x1810DBA20", Slot = "39")]
	public bool NIGIHPNCHAA(long BBKGLINHPNM, out DateTime HKGIMIJBPKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x10D79B0", Offset = "0x10D6DB0", VA = "0x1810D79B0", Slot = "40")]
	public long JEHMKBFLLEI(long BBKGLINHPNM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x10D6B50", Offset = "0x10D5F50", VA = "0x1810D6B50", Slot = "59")]
	public IEnumerable<int> HIOIAPEBONN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x10DBB70", Offset = "0x10DAF70", VA = "0x1810DBB70", Slot = "41")]
	public long NILNNBEPANM(long MEFEJANAPKD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x10D39C0", Offset = "0x10D2DC0", VA = "0x1810D39C0", Slot = "42")]
	public int DJLLBBFACMP(long BBKGLINHPNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x10D5140", Offset = "0x10D4540", VA = "0x1810D5140", Slot = "43")]
	public bool FAIKCHOPPLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x10D8140", Offset = "0x10D7540", VA = "0x1810D8140", Slot = "44")]
	public bool JPBFJHNPPEM(long BBKGLINHPNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x10D18B0", Offset = "0x10D0CB0", VA = "0x1810D18B0", Slot = "45")]
	public IEnumerable<long> AJFJDKJFGDJ(long BBKGLINHPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x10D7EE0", Offset = "0x10D72E0", VA = "0x1810D7EE0", Slot = "46")]
	public int JFFNFFEGPKC(long BBKGLINHPNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x10D4460", Offset = "0x10D3860", VA = "0x1810D4460", Slot = "50")]
	public long EICPEEPDDMC(long CAIPJDCBIME)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x10DD740", Offset = "0x10DCB40", VA = "0x1810DD740", Slot = "51")]
	public CCLDPBPGLEA PIMABPBMAJN()
	{
		return default(CCLDPBPGLEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x10DA130", Offset = "0x10D9530", VA = "0x1810DA130")]
	private bool LKPLCHAMPLJ(Guid NLEOMGLIGJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x10D5D20", Offset = "0x10D5120", VA = "0x1810D5D20")]
	private void GNDDDOEAAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x10D76B0", Offset = "0x10D6AB0", VA = "0x1810D76B0")]
	private CCLDPBPGLEA IOBNDNNJACG()
	{
		return default(CCLDPBPGLEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x10DE120", Offset = "0x10DD520", VA = "0x1810DE120")]
	private void PPIEOCHGGBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x10D47A0", Offset = "0x10D3BA0", VA = "0x1810D47A0")]
	private int EJBFFJIFGCH(KeepsakeRoomListDTO PFJGEPJCEEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x10D5C50", Offset = "0x10D5050", VA = "0x1810D5C50")]
	private int GLPHMDHEMCD(DateTime GLGANDCIEJE, DateTime JKKCHDLKIKG, TimeSpan LMLPGBDJJGC, int JEFCIIIGJLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x10D5990", Offset = "0x10D4D90", VA = "0x1810D5990")]
	private void GAKJLGPIMIM(IEnumerable<KeepsakeInstanceDTO> FHKJJDBEEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x10D1CF0", Offset = "0x10D10F0", VA = "0x1810D1CF0")]
	private void BAHEMOMBGML(IEnumerable<KeepsakeCollectionRecordDTO> KDEDFOBFLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x10D1540", Offset = "0x10D0940", VA = "0x1810D1540")]
	private void AAFKFPEBIKI(IEnumerable<long> MBHPMOKJMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xF9F2C0", Offset = "0xF9E6C0", VA = "0x180F9F2C0")]
	private void KGMCFAGMGJD(KeepsakeGlobalConfigDTO APJJHEEODCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x10DBEB0", Offset = "0x10DB2B0", VA = "0x1810DBEB0")]
	private bool OIDHPEIHIEP(CCLDPBPGLEA EIJDJFDKAHK, out Guid LBOHKNDCPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x10D6DA0", Offset = "0x10D61A0", VA = "0x1810D6DA0")]
	private bool HKOBIJBNLKL(out Guid LBOHKNDCPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x10D7420", Offset = "0x10D6820", VA = "0x1810D7420")]
	private bool IGBMAPFFBNE(Guid NLEOMGLIGJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x10DC4F0", Offset = "0x10DB8F0", VA = "0x1810DC4F0")]
	private IEnumerable<Guid> OKBIHPJALAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x10D6900", Offset = "0x10D5D00", VA = "0x1810D6900")]
	private IEnumerable<KeepsakeInstanceDTO> HHIABMKGAHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x10D43D0", Offset = "0x10D37D0", VA = "0x1810D43D0")]
	private void EHAKLCPOFBB(Guid NLEOMGLIGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x10D5BA0", Offset = "0x10D4FA0", VA = "0x1810D5BA0")]
	private bool GEDLPGIHCMG(Guid NLEOMGLIGJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x10DD3F0", Offset = "0x10DC7F0", VA = "0x1810DD3F0")]
	private void PDBFELDFJNE(Guid NLEOMGLIGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x10DD590", Offset = "0x10DC990", VA = "0x1810DD590")]
	private void PEJBHPLOONI(CCLDPBPGLEA POHNNKFMKBE, int HDENPDLCCBG, ref Dictionary<CCLDPBPGLEA, int> EHJIAHAJBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x10D5480", Offset = "0x10D4880", VA = "0x1810D5480")]
	private int FJFLKBNPCHG(CCLDPBPGLEA EIJDJFDKAHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x10D7260", Offset = "0x10D6660", VA = "0x1810D7260")]
	private void IFKBCBAHDFF(KeepsakeInstanceDTO EKLOJEBGBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x10D32A0", Offset = "0x10D26A0", VA = "0x1810D32A0")]
	private void CKCFGLOHINA(KeepsakeInstanceDTO EKLOJEBGBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x10DD050", Offset = "0x10DC450", VA = "0x1810DD050")]
	private void OPLIHNCGKFK(Guid NLEOMGLIGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x10DA920", Offset = "0x10D9D20", VA = "0x1810DA920")]
	private void MEKPGDDKLOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x10D7F90", Offset = "0x10D7390", VA = "0x1810D7F90")]
	private void JKKKFHFFFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x10DBD10", Offset = "0x10DB110", VA = "0x1810DBD10")]
	private void NMMFKOIOFAF(MDHAHLKJNIM INEHDALDLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x10D9530", Offset = "0x10D8930", VA = "0x1810D9530")]
	private void KGELNKAIKMN(IBEIJJOEPAD.GGDOEAGNGCP GHHNOPFOGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x10D3BC0", Offset = "0x10D2FC0", VA = "0x1810D3BC0")]
	private void DJMCLFHMPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x10DB660", Offset = "0x10DAA60", VA = "0x1810DB660")]
	private void NBHHLGGGNNB(float DDDAGANMIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x10DDB00", Offset = "0x10DCF00", VA = "0x1810DDB00")]
	private void PJAIHONDHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x10D24B0", Offset = "0x10D18B0", VA = "0x1810D24B0")]
	private bool BLOMDOGNINB(Guid NLEOMGLIGJK, out string JFAJCMCOBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x10D6280", Offset = "0x10D5680", VA = "0x1810D6280")]
	private bool HAAOBDHJHII(Guid NLEOMGLIGJK, out KeepsakeCategoryConfigDTO POHNNKFMKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x10D53A0", Offset = "0x10D47A0", VA = "0x1810D53A0")]
	private void FFNLOAEGAPK(string BMGMLFBAOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x10D9370", Offset = "0x10D8770", VA = "0x1810D9370")]
	private bool KFFEJFCELGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x10D9CE0", Offset = "0x10D90E0", VA = "0x1810D9CE0")]
	private IEnumerable<long> LGGOHLKJCLN(IEnumerable<KeepsakeRoomDTO> CPKDOMMDBAB, IEnumerable<KeepsakeRoomListDTO> JDLNHMEGMEJ, long BBKGLINHPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x10D96F0", Offset = "0x10D8AF0", VA = "0x1810D96F0")]
	private bool LBGIBGGDEIO(Guid NLEOMGLIGJK, out string OAAMGJCNLFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x10D40F0", Offset = "0x10D34F0", VA = "0x1810D40F0", Slot = "47")]
	public string EANBIFPKFNJ(GCOMPMIMPAJ CAFKDKOGOOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x10D3580", Offset = "0x10D2980", VA = "0x1810D3580", Slot = "49")]
	public string CPLJCMKNAOO(GCOMPMIMPAJ CAFKDKOGOOK, long MEFEJANAPKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x10DAE30", Offset = "0x10DA230", VA = "0x1810DAE30", Slot = "48")]
	public string MLFMCOHODIP(GCOMPMIMPAJ CAFKDKOGOOK, int CIPLHMJOGGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x10D8400", Offset = "0x10D7800", VA = "0x1810D8400")]
	private void JPHAPLFNODD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x10DA690", Offset = "0x10D9A90", VA = "0x1810DA690")]
	private void MBHFPOHJFHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x10D1CD0", Offset = "0x10D10D0", VA = "0x1810D1CD0")]
	private GCOMPMIMPAJ ANJFEILMNNO(IKBJAHBNGHB OCDIKFNMMKC)
	{
		return default(GCOMPMIMPAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x10D4AE0", Offset = "0x10D3EE0", VA = "0x1810D4AE0")]
	private GCOMPMIMPAJ EOEPIPBFEJA(IKBJAHBNGHB OCDIKFNMMKC)
	{
		return default(GCOMPMIMPAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x10D6720", Offset = "0x10D5B20", VA = "0x1810D6720")]
	internal static string HDLLODBGJKF(GDFAIJBLDEC NEIIHEMMEBO, string EGHPLLAICLA, bool MPHDOAONEJJ, int KHNIBCMABPN, int PHACNHNPCFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x10D3C90", Offset = "0x10D3090", VA = "0x1810D3C90", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x10DE0A0", Offset = "0x10DD4A0", VA = "0x1810DE0A0")]
	private EPLJDMDCBOP PPAMKDNMDEK(CFAHFELOIOE FNLHGFHLMMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x10D6450", Offset = "0x10D5850", VA = "0x1810D6450")]
	private AJDFOOJHGDE HBCCGIOCCFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x10DC160", Offset = "0x10DB560", VA = "0x1810DC160")]
	private Task OJCOPADKCAH(HCHGNNMIDGG KBOOOAILJFG, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x10D9FC0", Offset = "0x10D93C0", VA = "0x1810D9FC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BHOAMACEHOL))]
	private Task LGHIOFKKHPG(HCHGNNMIDGG KBOOOAILJFG, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x10D2540", Offset = "0x10D1940", VA = "0x1810D2540")]
	private Task BNEDGJJPPIL(HCHGNNMIDGG KBOOOAILJFG, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x10DA980", Offset = "0x10D9D80", VA = "0x1810DA980")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LPFBGOIGCEJ))]
	private Task MFMEMGCNGPI(string HGJOENLBDNH, TimeSpan LLDKIBAGBLA, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xBBA840", Offset = "0xBB9C40", VA = "0x180BBA840")]
	[CompilerGenerated]
	private void JDBFKKKCIGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x10D6230", Offset = "0x10D5630", VA = "0x1810D6230")]
	[CompilerGenerated]
	private void GNHCOJKEFMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x10D17C0", Offset = "0x10D0BC0", VA = "0x1810D17C0")]
	[CompilerGenerated]
	private bool AIMPBOHKHKC(KeepsakeInstanceDTO MIKJHKLKLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x10DA270", Offset = "0x10D9670", VA = "0x1810DA270")]
	[CompilerGenerated]
	private global::CBFHNKNAJIN<Dictionary<CCLDPBPGLEA, int>> LNFLDCMNFPC(Dictionary<Guid, CCLDPBPGLEA> IMLELAAMFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x10D1640", Offset = "0x10D0A40", VA = "0x1810D1640")]
	[CompilerGenerated]
	private global::CBFHNKNAJIN<Dictionary<CCLDPBPGLEA, int>> ADMFCKLNACB(Dictionary<Guid, CCLDPBPGLEA> IMLELAAMFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x10DAB10", Offset = "0x10D9F10", VA = "0x1810DAB10")]
	[CompilerGenerated]
	private bool MIAGOFDJMCG(KeepsakeRoomListDTO MIKJHKLKLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x10D65F0", Offset = "0x10D59F0", VA = "0x1810D65F0")]
	[CompilerGenerated]
	private bool HCEGOEEIKKJ(KeepsakeInstanceDTO MIKJHKLKLDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x10D69D0", Offset = "0x10D5DD0", VA = "0x1810D69D0")]
	[CompilerGenerated]
	private void HIMHJHEAJDF(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<CCLDPBPGLEA, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> LCDBEKCPOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x10D9630", Offset = "0x10D8A30", VA = "0x1810D9630")]
	[CompilerGenerated]
	private void KNMLMPMFBJE(string OAAMGJCNLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x10D7480", Offset = "0x10D6880", VA = "0x1810D7480")]
	[CompilerGenerated]
	private Task INCCJMBDGDN(CancellationToken HDPGEAJKOJN)
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
public class AOIEPJGNBNP
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AOIEPJGNBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BB0", Offset = "0x8C5FB0", VA = "0x1808C6BB0")]
	public static string NLHKAJNPDJN(byte[] AMGPPENALAL, byte[] DKDGFKIJFBC)
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
