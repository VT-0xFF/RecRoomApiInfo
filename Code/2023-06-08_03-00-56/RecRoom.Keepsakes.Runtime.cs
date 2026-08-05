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
	public class KeepsakesConfig : ScriptableObject, NFHBFEFILIO<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000004")]
			[CompilerGenerated]
			private sealed class OCHDKPFMAEI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
				public OCHDKPFMAEI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x12F9040", Offset = "0x12F7E40", VA = "0x1812F9040")]
				internal bool HCKIDDENNEA(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(RVA = "0x12F9040", Offset = "0x12F7E40", VA = "0x1812F9040")]
				internal bool KBJJHHGGHCP(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] POKJGEKPENF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x12F8B00", Offset = "0x12F7900", VA = "0x1812F8B00")]
			public bool EIHIGJEKPAN(string DOFHEOOBLPL, out KeepsakeTheme BIDFNLOPMJE)
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
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x12F8A80", Offset = "0x12F7880", VA = "0x1812F8A80")]
		[GIEEOCCBBIJ(PFHGMCKNAFN.GameOnly)]
		private static void BALEBCFJGHH(OBEPLHILJNL PIOBINFNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD69BC0", Offset = "0xD689C0", VA = "0x180D69BC0")]
		public KeepsakesConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GNABBAKMIKE : IComparer<CJCGELBDEFP>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class FKJMFACKHIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public CJCGELBDEFP x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public CJCGELBDEFP y;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public FKJMFACKHIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x12F6B90", Offset = "0x12F5990", VA = "0x1812F6B90")]
		internal bool CLNKPHLPABH(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x12F6B80", Offset = "0x12F5980", VA = "0x1812F6B80")]
		internal bool LDLEDPEFJHJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x12F6B90", Offset = "0x12F5990", VA = "0x1812F6B90")]
		internal bool HNPAPMOOGIH(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x12F6B80", Offset = "0x12F5980", VA = "0x1812F6B80")]
		internal bool BIFGIEOKGJG(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KeepsakeCategoryThemePair> JIAAPCAHEEC;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8FF650", Offset = "0x8FE450", VA = "0x1808FF650")]
	public GNABBAKMIKE(List<KeepsakeCategoryThemePair> CKLBHEDJDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x12F6DF0", Offset = "0x12F5BF0", VA = "0x1812F6DF0", Slot = "4")]
	public int Compare(CJCGELBDEFP ELAKNHNBHMF, CJCGELBDEFP MNMNIIAFFPP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum LFENODJAIHF
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
		public CJCGELBDEFP KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[MMBMKHHBAJO]
public class OIJKLHOBEJM : BKMMAEGBDIF, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct OIJDCPOENAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public const string HDBOJLNJMNM = "Keepsake placement still in progress. Please wait a moment before placing another keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public const string GHAOAJEBFAA = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public const string DBFKDHOFEJO = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string DPLMNOEJMKJ = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public const string OBPAMNCLBIB = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const string KDJKEAMJEPC = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public const string OHAAMPFMFNE = "You have to collect other keepsakes before you can collect this one.";

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public const string GBCNMPAHCGL = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public const string CJDILGEKHCC = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public const string FLECHIAIMNN = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public const string OHMOCEPBFFN = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public const string NDFCGEHCMGP = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public const string CLDFCNAPFEE = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BCAIIAMLEJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public OIJKLHOBEJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CJCGELBDEFP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public BCAIIAMLEJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x12F63B0", Offset = "0x12F51B0", VA = "0x1812F63B0")]
		internal AHPDIJDJLKD<Guid> KHCNFIIOLPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x12F5E80", Offset = "0x12F4C80", VA = "0x1812F5E80")]
		internal void EABCFLALLJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x12F5EB0", Offset = "0x12F4CB0", VA = "0x1812F5EB0")]
		internal void FAODGJHCKOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x12F5F40", Offset = "0x12F4D40", VA = "0x1812F5F40")]
		internal void KEIKBAAFKFF(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x12F5F10", Offset = "0x12F4D10", VA = "0x1812F5F10")]
		internal void JDELOMBBFJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class IGHNFCLCJDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public OIJKLHOBEJM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public IGHNFCLCJDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x12F7AA0", Offset = "0x12F68A0", VA = "0x1812F7AA0")]
		internal void PCDDJHCIELP(OOHKKKKHNCP response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x12F7A40", Offset = "0x12F6840", VA = "0x1812F7A40")]
		internal void FABIMMKDMNE(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class LOIBNIMJIKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LOIBNIMJIKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x12F8D50", Offset = "0x12F7B50", VA = "0x1812F8D50")]
		internal bool FNKIFDOPGMC(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class DHOHJEOCKJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public OIJKLHOBEJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public CJCGELBDEFP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DHOHJEOCKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x12F69F0", Offset = "0x12F57F0", VA = "0x1812F69F0")]
		internal bool KMILIMNPIEH(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class PBNGBAOMMOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public OIJKLHOBEJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CJCGELBDEFP? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public PBNGBAOMMOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1307810", Offset = "0x1306610", VA = "0x181307810")]
		internal void NABFIHFAANH(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x12F89C0", Offset = "0x12F77C0", VA = "0x1812F89C0")]
		internal void PABMKKEJPPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1307500", Offset = "0x1306300", VA = "0x181307500")]
		internal AHPDIJDJLKD<IEnumerable<Guid>> FDMEIDNEIEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x12F89A0", Offset = "0x12F77A0", VA = "0x1812F89A0")]
		internal bool CPEDLGGGLMN(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class CILBONHGIKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public PBNGBAOMMOJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CILBONHGIKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x12F6540", Offset = "0x12F5340", VA = "0x1812F6540")]
		internal AHPDIJDJLKD<IEnumerable<Guid>> JPMFLHBAACL(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class COEBKOBIMBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CILBONHGIKL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public COEBKOBIMBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x12F6730", Offset = "0x12F5530", VA = "0x1812F6730")]
		internal bool MAKNANMHIFF(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class PPLHCCBFANG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public COEBKOBIMBG CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public PPLHCCBFANG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x13078A0", Offset = "0x13066A0", VA = "0x1813078A0")]
		internal bool KNMAKNHGNJD(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DGGEJAPLKAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public OIJKLHOBEJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DGGEJAPLKAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x12F6880", Offset = "0x12F5680", VA = "0x1812F6880")]
		internal AHPDIJDJLKD<IEnumerable<Guid>> NDIGIBABDHI(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x12F6860", Offset = "0x12F5660", VA = "0x1812F6860")]
		internal bool KKJDFJLMAHH(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class JKODCHAIAIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public OIJKLHOBEJM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JKODCHAIAIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x12F89F0", Offset = "0x12F77F0", VA = "0x1812F89F0")]
		internal void MGFFJDONCGJ(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x12F89C0", Offset = "0x12F77C0", VA = "0x1812F89C0")]
		internal void EAKMGJOOMKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x12F8690", Offset = "0x12F7490", VA = "0x1812F8690")]
		internal AHPDIJDJLKD<Dictionary<Guid, CJCGELBDEFP>> APMNEEHICEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x12F89A0", Offset = "0x12F77A0", VA = "0x1812F89A0")]
		internal bool BNBPPOIFFIP(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class HJHHDBOHMJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HJHHDBOHMJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x12F7510", Offset = "0x12F6310", VA = "0x1812F7510")]
		internal AHPDIJDJLKD<Dictionary<Guid, CJCGELBDEFP>> FIJMDFJIKPJ(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class IFHFJGBJJGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public IFHFJGBJJGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x12F77D0", Offset = "0x12F65D0", VA = "0x1812F77D0")]
		internal bool FFOIBCMKBGK(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x12F78C0", Offset = "0x12F66C0", VA = "0x1812F78C0")]
		internal KeyValuePair<Guid, CJCGELBDEFP> HNFJKDGKCEJ(Guid instanceId)
		{
			return default(KeyValuePair<Guid, CJCGELBDEFP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class CMDCPODKLME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CMDCPODKLME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x12F6690", Offset = "0x12F5490", VA = "0x1812F6690")]
		internal bool PPMLOMIIPBF(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class INLJOEHHMFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public INLJOEHHMFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x12F7FB0", Offset = "0x12F6DB0", VA = "0x1812F7FB0")]
		internal bool APHJEMLABCF(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class HAIKOGDHLIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public OIJKLHOBEJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HAIKOGDHLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x12F70A0", Offset = "0x12F5EA0", VA = "0x1812F70A0")]
		internal AHPDIJDJLKD<Dictionary<Guid, CJCGELBDEFP>> JPKOOPKDFIM(Dictionary<Guid, CJCGELBDEFP> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x12F6860", Offset = "0x12F5660", VA = "0x1812F6860")]
		internal bool IBOMIPBCDLM(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class LJKNALECAJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LJKNALECAJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x12F8CD0", Offset = "0x12F7AD0", VA = "0x1812F8CD0")]
		internal bool ADNJJMHGDAB(KeyValuePair<Guid, CJCGELBDEFP> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class HIEJADPOLOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Dictionary<Guid, CJCGELBDEFP> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HIEJADPOLOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x12F73B0", Offset = "0x12F61B0", VA = "0x1812F73B0")]
		internal KeyValuePair<CJCGELBDEFP, int> PMEGLLMEFML(CJCGELBDEFP category)
		{
			return default(KeyValuePair<CJCGELBDEFP, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class APDHAMJHBGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CJCGELBDEFP category;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public APDHAMJHBGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x12F5E70", Offset = "0x12F4C70", VA = "0x1812F5E70")]
		internal bool CBPGODJHLCE(CJCGELBDEFP instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class INJIHDDJLDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Dictionary<Guid, CJCGELBDEFP> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public INJIHDDJLDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x12F7E50", Offset = "0x12F6C50", VA = "0x1812F7E50")]
		internal KeyValuePair<CJCGELBDEFP, int> OHNINEEDBNC(CJCGELBDEFP category)
		{
			return default(KeyValuePair<CJCGELBDEFP, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class INOGKFOIMMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CJCGELBDEFP category;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public INOGKFOIMMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x12F5E70", Offset = "0x12F4C70", VA = "0x1812F5E70")]
		internal bool KAPEFNOKGJP(CJCGELBDEFP instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GJIOJFCPIHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public OIJKLHOBEJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GJIOJFCPIHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x12F6C40", Offset = "0x12F5A40", VA = "0x1812F6C40")]
		internal bool HOFAEKLHBKP(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x12F6D20", Offset = "0x12F5B20", VA = "0x1812F6D20")]
		internal bool OJGNHJNKDIM(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x12F6C20", Offset = "0x12F5A20", VA = "0x1812F6C20")]
		internal bool KGPDOGILPOH(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x12F6C20", Offset = "0x12F5A20", VA = "0x1812F6C20")]
		internal bool GCCPFBKKOLI(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class CHBGJDGOMLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CHBGJDGOMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x12F6520", Offset = "0x12F5320", VA = "0x1812F6520")]
		internal bool GDFOAAJDMFJ(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class IEEOFJNIFMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public IEEOFJNIFMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x12F76E0", Offset = "0x12F64E0", VA = "0x1812F76E0")]
		internal bool GPBGHNMKLGN(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x12F77B0", Offset = "0x12F65B0", VA = "0x1812F77B0")]
		internal bool NMPOAABAKPG(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class FBIMPIGABOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public FBIMPIGABOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x12F6B10", Offset = "0x12F5910", VA = "0x1812F6B10")]
		internal bool HJIMAHGJILO(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JPPCIGLOKEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JPPCIGLOKEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x12F6520", Offset = "0x12F5320", VA = "0x1812F6520")]
		internal bool KMIBEIPPJOF(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JFEOKBOEMBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JFEOKBOEMBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x12F8600", Offset = "0x12F7400", VA = "0x1812F8600")]
		internal bool HCEGAFHBAMF(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class CCIEJNPJGPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public CJCGELBDEFP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CCIEJNPJGPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x12F6500", Offset = "0x12F5300", VA = "0x1812F6500")]
		internal bool DCCINIBCFDN(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class MKPFFCDNCHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MKPFFCDNCHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x12F8DC0", Offset = "0x12F7BC0", VA = "0x1812F8DC0")]
		internal bool CPMDGMIDFDB(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class MHKHCENGHOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CJCGELBDEFP keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public MHKHCENGHOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x12F8D80", Offset = "0x12F7B80", VA = "0x1812F8D80")]
		internal bool DNFPHECCKAI(KeyValuePair<Guid, CJCGELBDEFP> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class KANKGMDFHHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public CJCGELBDEFP newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KANKGMDFHHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x12F6500", Offset = "0x12F5300", VA = "0x1812F6500")]
		internal bool MLIAOELABDM(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class JEKGGAAEGOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JEKGGAAEGOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x12F8050", Offset = "0x12F6E50", VA = "0x1812F8050")]
		internal bool MNFNGAMNAIJ(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class HGDHAJPDKAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HGDHAJPDKAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x12F72C0", Offset = "0x12F60C0", VA = "0x1812F72C0")]
		internal bool NMGBOOMHDHC(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class GBOFHOGJION
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public HGDHAJPDKAO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public GBOFHOGJION()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x12F6BA0", Offset = "0x12F59A0", VA = "0x1812F6BA0")]
		internal bool ABFIPPGFPLC(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class JENGKKBGCJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public OKKEILOPOEG args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public OIJKLHOBEJM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JENGKKBGCJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x12F8100", Offset = "0x12F6F00", VA = "0x1812F8100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class NOEOCNJNGDJ : IAsyncStateMachine
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
		public OIJKLHOBEJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public NOEOCNJNGDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x12F8E50", Offset = "0x12F7C50", VA = "0x1812F8E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int GOIECDEFDJC = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DateTime JGJALBOABEM;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const int DPNNEJNALJL = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const long KIHJCBLCKOD = -1L;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const char DMFNECJNCOI = '|';

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly IOLABGNOCIN MJOIMDPJJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly EBPFOOOKOAG NOMPLMEHFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly JPDJLNKDNGK LDOPGFLHAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly NBELCMMLAHL LOGHHIKILOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CCHNDCIGIIL DNDDHODHCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly BMFGEEFCKKA MBKLOKDCGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly IJAHMOELLLB OLLIKMKBGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly LLFJEBKJAMM EAGOFGJABJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly FFJDIOBGOFJ MEOJCFIENCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly GGLCMCOBGJD AABMIFBKDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly KLDDIFEANKM EIPENGCAADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IKGLHJKBBML MHJJEMKPPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly BACFCLPDNBC EIGKIJCOEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly PCDENCJPNEO PNNLDAFFGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly CHFEFMDBOKH BFICOPHANKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly NFHBFEFILIO<KeepsakesConfig.KeepsakesOptions> PJMJNHMCCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly CMCCNLDPEHJ JJDFOBHIKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> ECPNGLJIPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<Guid> PDJPMCGJIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<long> AJKJNGKEAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Dictionary<CJCGELBDEFP, int> FJFBANMNGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly HashSet<Guid> NLEAGANJHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly IDisposable ADOMGBFFJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private Task JIGANBFFFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private AHPDIJDJLKD<Guid> BBCKNADINOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private long? PGDGOHCAPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private KeepsakeProgressionEventInstancesDTO GKAFMELEAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private AHPDIJDJLKD<KeepsakeProgressionEventInstancesDTO> DJOJMGMDKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private IReadOnlyDictionary<CJCGELBDEFP, KeepsakeCategoryConfigDTO> JNOBAFMHKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private KeepsakeGlobalConfigDTO LFNOCDNPAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private HashSet<long> LPCEDKCIMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private HashSet<long> KJOOKGAICBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<KeepsakeRoomListDTO> IADNGFPNILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private List<KeepsakeRoomListDTO> MKKLMKLBHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private List<KeepsakeRoomListDTO> NNAOBDPMPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<long, string> HCCPJBFHJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<long, string> LJMKOJKNLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<long, DateTime> IBILAPCMNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<long, List<KeepsakeRoomDTO>> KIEIEKGFHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Dictionary<long, List<KeepsakeRoomDTO>> BBGGMEEHMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Dictionary<long, long> EGBJIHFEOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<string> OLCEOLOMDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private DateTime OEDPKBIMMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly IDisposable EICMEGOLKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Guid, CJCGELBDEFP> MCGABKFAEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<CJCGELBDEFP, int> OFLKLMPEHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private List<KeepsakeCategoryThemePair> CKLBHEDJDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private GNABBAKMIKE AGINBJPNGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool PCEOAAJNPMG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OBKLLLJKEBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x91A1F0", Offset = "0x918FF0", VA = "0x18091A1F0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x90DA70", Offset = "0x90C870", VA = "0x18090DA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HEPNNDOEKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1302F60", Offset = "0x1301D60", VA = "0x181302F60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool IPLOADPOOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x12FACE0", Offset = "0x12F9AE0", VA = "0x1812FACE0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long OIAIKIMMKNB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x12FFB20", Offset = "0x12FE920", VA = "0x1812FFB20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long? GGEPPJFLABM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x12FE6E0", Offset = "0x12FD4E0", VA = "0x1812FE6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool INFMBHBPGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1302320", Offset = "0x1301120", VA = "0x181302320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> AGCKOOLACPK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xCF4DC0", Offset = "0xCF3BC0", VA = "0x180CF4DC0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> ONDKDKCBNML
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x10972E0", Offset = "0x10960E0", VA = "0x1810972E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<KeepsakeRoomListDTO> LOCNJLHJLKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x10972B0", Offset = "0x10960B0", VA = "0x1810972B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> CKJJEOCABDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xCF4D10", Offset = "0xCF3B10", VA = "0x180CF4D10", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyDictionary<long, string> CDFGCADEKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1301250", Offset = "0x1300050", VA = "0x181301250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal bool GCGNBDIMFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x12FEB90", Offset = "0x12FD990", VA = "0x1812FEB90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x13007C0", Offset = "0x12FF5C0", VA = "0x1813007C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> GMFEFPEMOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x12FB7B0", Offset = "0x12FA5B0", VA = "0x1812FB7B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x12FF370", Offset = "0x12FE170", VA = "0x1812FF370", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JLCFBBOEMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x12F9A40", Offset = "0x12F8840", VA = "0x1812F9A40", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1302700", Offset = "0x1301500", VA = "0x181302700", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action HCLPGFAMDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x12FEBA0", Offset = "0x12FD9A0", VA = "0x1812FEBA0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1301D50", Offset = "0x1300B50", VA = "0x181301D50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x13061F0", Offset = "0x1304FF0", VA = "0x1813061F0")]
	[Preserve]
	internal OIJKLHOBEJM([NotNull][DNPFPOCMFCA(null)] IOLABGNOCIN MJOIMDPJJKD, [NotNull][DNPFPOCMFCA(null)] GNALIAMEBBF JCDJEAMBPLM, [NotNull][DNPFPOCMFCA(null)] EBPFOOOKOAG NOMPLMEHFAL, [NotNull][DNPFPOCMFCA(null)] JPDJLNKDNGK LDOPGFLHAMO, [NotNull][DNPFPOCMFCA(null)] NBELCMMLAHL LOGHHIKILOG, [NotNull][DNPFPOCMFCA(null)] CCHNDCIGIIL DNDDHODHCMO, [NotNull][DNPFPOCMFCA(null)] BMFGEEFCKKA MBKLOKDCGAD, [NotNull][DNPFPOCMFCA(null)] IJAHMOELLLB OLLIKMKBGNJ, [NotNull][DNPFPOCMFCA(null)] LLFJEBKJAMM EAGOFGJABJP, [NotNull][DNPFPOCMFCA(null)] MCNHJJJGDMM PNNHAFMKEMH, [NotNull][DNPFPOCMFCA(null)] FFJDIOBGOFJ MEOJCFIENCI, [NotNull][DNPFPOCMFCA(null)] GGLCMCOBGJD AABMIFBKDIK, [NotNull][DNPFPOCMFCA(null)] KLDDIFEANKM EIPENGCAADB, [NotNull][DNPFPOCMFCA(null)] IKGLHJKBBML MHJJEMKPPLM, [NotNull][DNPFPOCMFCA(null)] BACFCLPDNBC EIGKIJCOEPB, [NotNull][DNPFPOCMFCA(null)] PCDENCJPNEO PNNLDAFFGIA, [NotNull][DNPFPOCMFCA(null)] CHFEFMDBOKH BFICOPHANKP, [NotNull][DNPFPOCMFCA(null)] NFHBFEFILIO<KeepsakesConfig.KeepsakesOptions> PJMJNHMCCBP, [NotNull][DNPFPOCMFCA(null)] CMCCNLDPEHJ JJDFOBHIKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1304FA0", Offset = "0x1303DA0", VA = "0x181304FA0", Slot = "15")]
	public bool OPFAKBMMNBA(List<string> IELJKPKIOKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x12F9070", Offset = "0x12F7E70", VA = "0x1812F9070", Slot = "16")]
	public AHPDIJDJLKD<Guid> AAKCCEMLKMA(CJCGELBDEFP OBLILFIPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x12FB330", Offset = "0x12FA130", VA = "0x1812FB330", Slot = "17")]
	public NONMCJIBNII DBLCNAOAJGE(Guid JAGFBLADBKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1304AA0", Offset = "0x13038A0", VA = "0x181304AA0", Slot = "18")]
	public NONMCJIBNII OJLKFGDOCBE(Guid JAGFBLADBKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1302100", Offset = "0x1300F00", VA = "0x181302100", Slot = "19")]
	public bool MBLELPOAPCF(Guid JAGFBLADBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x12FD6B0", Offset = "0x12FC4B0", VA = "0x1812FD6B0", Slot = "20")]
	public bool FILONPOJLLI(Guid JAGFBLADBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x12FA320", Offset = "0x12F9120", VA = "0x1812FA320")]
	public KeepsakeTheme AOBCKBKOJCM(Guid JAGFBLADBKH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1300F60", Offset = "0x12FFD60", VA = "0x181300F60")]
	public bool JFPMMIBCHHJ(CJCGELBDEFP OBLILFIPCML, out KeepsakeTheme BIDFNLOPMJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1300300", Offset = "0x12FF100", VA = "0x181300300")]
	public List<KeepsakeTheme> IONCGEAODPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x12FC010", Offset = "0x12FAE10", VA = "0x1812FC010")]
	public int ECHMHLNGOJH(CJCGELBDEFP OBLILFIPCML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1304E30", Offset = "0x1303C30", VA = "0x181304E30")]
	public CJCGELBDEFP OKJIFNLNNDF(Guid JAGFBLADBKH)
	{
		return default(CJCGELBDEFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x12FA520", Offset = "0x12F9320", VA = "0x1812FA520", Slot = "34")]
	public List<CJCGELBDEFP> BEAHJIEFHLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x12FCFE0", Offset = "0x12FBDE0", VA = "0x1812FCFE0", Slot = "35")]
	public IComparer<CJCGELBDEFP> EOJJLFNKMFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1300650", Offset = "0x12FF450", VA = "0x181300650", Slot = "32")]
	public string IPLOBMNMNMH(CJCGELBDEFP OBLILFIPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1302FB0", Offset = "0x1301DB0", VA = "0x181302FB0", Slot = "33")]
	public string NFEDDAEJFKD(CJCGELBDEFP OBLILFIPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x12FDA70", Offset = "0x12FC870", VA = "0x1812FDA70", Slot = "21")]
	public bool GIBPMGLDEMC(Guid JAGFBLADBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1305C10", Offset = "0x1304A10", VA = "0x181305C10", Slot = "22")]
	public void PLMBMAONKIK(Guid JAGFBLADBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1304A60", Offset = "0x1303860", VA = "0x181304A60", Slot = "23")]
	public void OJLJKGBJGBK(CJCGELBDEFP OBLILFIPCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x12FD6E0", Offset = "0x12FC4E0", VA = "0x1812FD6E0", Slot = "24")]
	public void FMCKLFJHFHF(Guid JAGFBLADBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x12FDD10", Offset = "0x12FCB10", VA = "0x1812FDD10", Slot = "25")]
	public int GIIDEMKNLAC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x12FE160", Offset = "0x12FCF60", VA = "0x1812FE160", Slot = "54")]
	public int GIIDEMKNLAC(CJCGELBDEFP OBLILFIPCML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1302B50", Offset = "0x1301950", VA = "0x181302B50", Slot = "31")]
	public AHPDIJDJLKD<IEnumerable<Guid>> MMCGBMLAGKI(long OFOPNAOLFGC, long JDCHPBMGIIG, CJCGELBDEFP? OBLILFIPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x12FA9F0", Offset = "0x12F97F0", VA = "0x1812FA9F0", Slot = "30")]
	public AHPDIJDJLKD<IEnumerable<Guid>> BMEKEJLJIKG(long OFOPNAOLFGC, long JDCHPBMGIIG, CJCGELBDEFP? OBLILFIPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x12FE780", Offset = "0x12FD580", VA = "0x1812FE780", Slot = "55")]
	public AHPDIJDJLKD<Dictionary<Guid, CJCGELBDEFP>> GNAFLGHONLG(long OFOPNAOLFGC, long JDCHPBMGIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x12FF990", Offset = "0x12FE790", VA = "0x1812FF990", Slot = "56")]
	public AHPDIJDJLKD<Dictionary<Guid, CJCGELBDEFP>> HPAMOKOHHGL(long OFOPNAOLFGC, long JDCHPBMGIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x12FC440", Offset = "0x12FB240", VA = "0x1812FC440", Slot = "26")]
	public AHPDIJDJLKD<int> EEJPEJMAIEF(long OFOPNAOLFGC, long JDCHPBMGIIG, CJCGELBDEFP? OBLILFIPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1301940", Offset = "0x1300740", VA = "0x181301940", Slot = "27")]
	public AHPDIJDJLKD<int> KLJEPFPFEMA(long OFOPNAOLFGC, long JDCHPBMGIIG, CJCGELBDEFP? OBLILFIPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1301580", Offset = "0x1300380", VA = "0x181301580", Slot = "28")]
	public AHPDIJDJLKD<Dictionary<CJCGELBDEFP, int>> KDJABEMGAFP(long OFOPNAOLFGC, long JDCHPBMGIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1305AA0", Offset = "0x13048A0", VA = "0x181305AA0", Slot = "29")]
	public AHPDIJDJLKD<Dictionary<CJCGELBDEFP, int>> PINAMAEDMEF(long OFOPNAOLFGC, long JDCHPBMGIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1305A40", Offset = "0x1304840", VA = "0x181305A40", Slot = "37")]
	public bool PICKJKFAMLI(long OFOPNAOLFGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x12FD630", Offset = "0x12FC430", VA = "0x1812FD630", Slot = "57")]
	public bool FGBGFMHLFHJ(long OFOPNAOLFGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1305640", Offset = "0x1304440", VA = "0x181305640", Slot = "38")]
	public bool PBAILHIEBIL(long OFOPNAOLFGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1302340", Offset = "0x1301140", VA = "0x181302340", Slot = "58")]
	public bool MFFOPPHBAFI(long OFOPNAOLFGC, out GHNECKNGNHJ FGPKJICNMIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x12FAB90", Offset = "0x12F9990", VA = "0x1812FAB90", Slot = "39")]
	public bool BNDOFJAFGON(long NEEOIHGDHIB, out DateTime MDANIGDFGJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1300830", Offset = "0x12FF630", VA = "0x181300830", Slot = "40")]
	public long JCCJNFOLOHM(long NEEOIHGDHIB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x12F9CB0", Offset = "0x12F8AB0", VA = "0x1812F9CB0", Slot = "59")]
	public IEnumerable<int> AIEPHMHCKJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1301AB0", Offset = "0x13008B0", VA = "0x181301AB0", Slot = "41")]
	public long KLKCBBJCCMI(long OFOPNAOLFGC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1300100", Offset = "0x12FEF00", VA = "0x181300100", Slot = "42")]
	public int IIJKDKNNCMP(long NEEOIHGDHIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x12FCEF0", Offset = "0x12FBCF0", VA = "0x1812FCEF0", Slot = "43")]
	public bool ENDFPGGHHPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x12FC180", Offset = "0x12FAF80", VA = "0x1812FC180", Slot = "44")]
	public bool EDHNPHGIHLC(long NEEOIHGDHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x12FB020", Offset = "0x12F9E20", VA = "0x1812FB020", Slot = "45")]
	public IEnumerable<long> CJGHAKKGBDN(long NEEOIHGDHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x13014D0", Offset = "0x13002D0", VA = "0x1813014D0", Slot = "46")]
	public int KAMDHMLKNHC(long NEEOIHGDHIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x12FF410", Offset = "0x12FE210", VA = "0x1812FF410", Slot = "50")]
	public long HLKADHPLLCL(long FLGJMMJDABB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x12F9F00", Offset = "0x12F8D00", VA = "0x1812F9F00", Slot = "51")]
	public CJCGELBDEFP AIMLAMNKNBN()
	{
		return default(CJCGELBDEFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x13017A0", Offset = "0x13005A0", VA = "0x1813017A0")]
	private bool KFLGFNBPBFD(Guid JAGFBLADBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1304280", Offset = "0x1303080", VA = "0x181304280")]
	private void OAKEIMEDPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x12FFE00", Offset = "0x12FEC00", VA = "0x1812FFE00")]
	private CJCGELBDEFP ICCNGAOGCHD()
	{
		return default(CJCGELBDEFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x12FD080", Offset = "0x12FBE80", VA = "0x1812FD080")]
	private void FBPDJANMBOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x12FA670", Offset = "0x12F9470", VA = "0x1812FA670")]
	private int BEBAENKJCAM(KeepsakeRoomListDTO JHEHIGAOPBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1300E90", Offset = "0x12FFC90", VA = "0x181300E90")]
	private int JFOKNIHNFIB(DateTime CMOFEBHBAMG, DateTime DCLMLIHDGFK, TimeSpan NKNMIPCOKHN, int NNDGKIAGDHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x12FE4D0", Offset = "0x12FD2D0", VA = "0x1812FE4D0")]
	private void GJJFMKJPHMM(IEnumerable<KeepsakeInstanceDTO> ECPNGLJIPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x12FF750", Offset = "0x12FE550", VA = "0x1812FF750")]
	private void HNNBPAHBMEO(IEnumerable<KeepsakeCollectionRecordDTO> FFANNENCACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x13018E0", Offset = "0x13006E0", VA = "0x1813018E0")]
	private void KKEFNMFFBPF(IEnumerable<long> ECCEIKJHBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xD5F1E0", Offset = "0xD5DFE0", VA = "0x180D5F1E0")]
	private void IPILHOMAONN(KeepsakeGlobalConfigDTO LFNOCDNPAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1303120", Offset = "0x1301F20", VA = "0x181303120")]
	private bool NJKIJFAGFLK(CJCGELBDEFP OBLILFIPCML, out Guid OMMBELKNIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1302250", Offset = "0x1301050", VA = "0x181302250")]
	private bool MCNPMNGPCPH(out Guid OMMBELKNIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x12FB750", Offset = "0x12FA550", VA = "0x1812FB750")]
	private bool DGDAPJAGMOH(Guid JAGFBLADBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x12FF210", Offset = "0x12FE010", VA = "0x1812FF210")]
	private IEnumerable<Guid> HFLBGMAFBOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x13041B0", Offset = "0x1302FB0", VA = "0x1813041B0")]
	private IEnumerable<KeepsakeInstanceDTO> NPMLCGEPEPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x12FADB0", Offset = "0x12F9BB0", VA = "0x1812FADB0")]
	private void CFLGPKPPCFF(Guid JAGFBLADBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1302980", Offset = "0x1301780", VA = "0x181302980")]
	private bool MHLAPKAADMN(Guid JAGFBLADBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x12FB5B0", Offset = "0x12FA3B0", VA = "0x1812FB5B0")]
	private void DDIHLKGEMCA(Guid JAGFBLADBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1301C70", Offset = "0x1300A70", VA = "0x181301C70")]
	private void LHGCECONNFC(CJCGELBDEFP KCFMNBKCILK, int MANOOPCDMIJ, ref Dictionary<CJCGELBDEFP, int> HNDJBILNECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x13012F0", Offset = "0x13000F0", VA = "0x1813012F0")]
	private int JNJFFEMFMBP(CJCGELBDEFP OBLILFIPCML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x12FB850", Offset = "0x12FA650", VA = "0x1812FB850")]
	private void DPAKKNCDADC(KeepsakeInstanceDTO CFKBLEKNDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x12FFC00", Offset = "0x12FEA00", VA = "0x1812FFC00")]
	private void HPOAACGGHDE(KeepsakeInstanceDTO CFKBLEKNDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x13052A0", Offset = "0x13040A0", VA = "0x1813052A0")]
	private void PANFCDHJKME(Guid JAGFBLADBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x12FA2C0", Offset = "0x12F90C0", VA = "0x1812FA2C0")]
	private void AKAMOCLICHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x13033D0", Offset = "0x13021D0", VA = "0x1813033D0")]
	private void NKEMMBJGPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x13059C0", Offset = "0x13047C0", VA = "0x1813059C0")]
	private void PGGLMCDJOBG(ENIOHGBDODO FKGDOPBKHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x12FDA10", Offset = "0x12FC810", VA = "0x1812FDA10")]
	private void GDPNMCGHJMJ(NCCODIALNCH.NKGEFJGLELA GNOEFMFMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x12FA4C0", Offset = "0x12F92C0", VA = "0x1812FA4C0")]
	private void AOMIFGICION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x12FCB30", Offset = "0x12FB930", VA = "0x1812FCB30")]
	private void ELJIPPINNKM(float FMGBPELCHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1305C80", Offset = "0x1304A80", VA = "0x181305C80")]
	private void PMICIFIAMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1301260", Offset = "0x1300060", VA = "0x181301260")]
	private bool JKIAEINEPJC(Guid JAGFBLADBKH, out string PGLBLNLBDEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x12F9AE0", Offset = "0x12F88E0", VA = "0x1812F9AE0")]
	private bool AIDOGHHPOLD(Guid JAGFBLADBKH, out KeepsakeCategoryConfigDTO KCFMNBKCILK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x13013F0", Offset = "0x13001F0", VA = "0x1813013F0")]
	private void JOEPKCDNLFJ(string JHFMDOLHJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1302A30", Offset = "0x1301830", VA = "0x181302A30")]
	private bool MKCCHCHAIFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x13056E0", Offset = "0x13044E0", VA = "0x1813056E0")]
	private IEnumerable<long> PFLHKAAFEOP(IEnumerable<KeepsakeRoomDTO> HJJFBFCDNOB, IEnumerable<KeepsakeRoomListDTO> JJKCHOKIAJE, long NEEOIHGDHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x12FEC40", Offset = "0x12FDA40", VA = "0x1812FEC40")]
	private bool HCLPGHKNDKE(Guid JAGFBLADBKH, out string JKCLFNEEMGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x13033F0", Offset = "0x13021F0", VA = "0x1813033F0", Slot = "47")]
	public string NMPKKPKHBBO(MCDHIHMDLLH INLCGDKIMGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x12FC6F0", Offset = "0x12FB4F0", VA = "0x1812FC6F0", Slot = "49")]
	public string ELJDCOEDNEG(MCDHIHMDLLH INLCGDKIMGB, long OFOPNAOLFGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1301130", Offset = "0x12FFF30", VA = "0x181301130", Slot = "48")]
	public string JHKMAEICGDD(MCDHIHMDLLH INLCGDKIMGB, int ONKBGFIFFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1303450", Offset = "0x1302250", VA = "0x181303450")]
	private void NNMCGMDAENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1304790", Offset = "0x1303590", VA = "0x181304790")]
	private void OHBOOCEONME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x13020E0", Offset = "0x1300EE0", VA = "0x1813020E0")]
	private MCDHIHMDLLH MBKFBIFLMBH(JLADDOMLIBB CGADOBJDIEP)
	{
		return default(MCDHIHMDLLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1301C50", Offset = "0x1300A50", VA = "0x181301C50")]
	private MCDHIHMDLLH LBMDPLCBPGA(JLADDOMLIBB CGADOBJDIEP)
	{
		return default(MCDHIHMDLLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x13027A0", Offset = "0x13015A0", VA = "0x1813027A0")]
	internal static string MGNHJBEBPFG(OOHKKKKHNCP DFNLCPKLPMM, string BLGCJGCGKOJ, bool PDDLAHOBOKK, int JHKIJAONCLJ, int HLPOHGMDDMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x12FBBB0", Offset = "0x12FA9B0", VA = "0x1812FBBB0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1301BD0", Offset = "0x13009D0", VA = "0x181301BD0")]
	private JJDGKHCDMCD KNMPNGFOJHM(PMEFCBBKLLD BBJILAAMFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x12FBA10", Offset = "0x12FA810", VA = "0x1812FBA10")]
	private FFBOJCOGMOC DPECLOHKIEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x12F96B0", Offset = "0x12F84B0", VA = "0x1812F96B0")]
	private Task AFPIMDEABDH(OKKEILOPOEG DCPGFNKOIOA, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1301F70", Offset = "0x1300D70", VA = "0x181301F70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JENGKKBGCJI))]
	private Task LNOHNELDDPL(OKKEILOPOEG DCPGFNKOIOA, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1305B70", Offset = "0x1304970", VA = "0x181305B70")]
	private Task PLENCHAFCNH(OKKEILOPOEG DCPGFNKOIOA, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x13048D0", Offset = "0x13036D0", VA = "0x1813048D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NOEOCNJNGDJ))]
	private Task OIOMDGAOFKK(string CAJMIGKHKEC, TimeSpan OLBKJCFJDCA, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xD6A050", Offset = "0xD68E50", VA = "0x180D6A050")]
	[CompilerGenerated]
	private void OEKCCJHFLAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x12FA9A0", Offset = "0x12F97A0", VA = "0x1812FA9A0")]
	[CompilerGenerated]
	private void BMBKFMOBPKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x12FD920", Offset = "0x12FC720", VA = "0x1812FD920")]
	[CompilerGenerated]
	private bool GDIJHAOODLG(KeepsakeInstanceDTO ELAKNHNBHMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x12FA820", Offset = "0x12F9620", VA = "0x1812FA820")]
	[CompilerGenerated]
	private AHPDIJDJLKD<Dictionary<CJCGELBDEFP, int>> BFNMGADOGPK(Dictionary<Guid, CJCGELBDEFP> FIPPJGJOADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1301DF0", Offset = "0x1300BF0", VA = "0x181301DF0")]
	[CompilerGenerated]
	private AHPDIJDJLKD<Dictionary<CJCGELBDEFP, int>> LNOEPHCKAHJ(Dictionary<Guid, CJCGELBDEFP> FIPPJGJOADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x12FD690", Offset = "0x12FC490", VA = "0x1812FD690")]
	[CompilerGenerated]
	private bool FGNKABPJGAK(KeepsakeRoomListDTO ELAKNHNBHMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x12FB200", Offset = "0x12FA000", VA = "0x1812FB200")]
	[CompilerGenerated]
	private bool CJJCLKEAPJI(KeepsakeInstanceDTO ELAKNHNBHMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x12FAEA0", Offset = "0x12F9CA0", VA = "0x1812FAEA0")]
	[CompilerGenerated]
	private void CJEAAHFGBMK(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<CJCGELBDEFP, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> PFPGBBDLCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x12FAE40", Offset = "0x12F9C40", VA = "0x1812FAE40")]
	[CompilerGenerated]
	private void CFMOPCINDIP(string JKCLFNEEMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1300C60", Offset = "0x12FFA60", VA = "0x181300C60")]
	[CompilerGenerated]
	private Task JCFPGADJCIJ(CancellationToken ACGNOKIICNG)
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
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9150", VA = "0x1808AA350")]
	public static string GPDLHKANJHK(byte[] OEIGPAJDAPF, byte[] EKAHBFHGOCF)
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
