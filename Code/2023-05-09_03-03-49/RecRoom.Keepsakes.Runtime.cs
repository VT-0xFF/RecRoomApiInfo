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
using Mono.Math;
using RecNet;
using RecRoom.Keepsakes;
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DCLOJDAGGKB : IComparer<CJFKFPHLBGA>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class DPNLMHMCPNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public CJFKFPHLBGA x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public CJFKFPHLBGA y;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public DPNLMHMCPNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x182E440", Offset = "0x182CE40", VA = "0x18182E440")]
		internal bool <Compare>b__0(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x182E450", Offset = "0x182CE50", VA = "0x18182E450")]
		internal bool <Compare>b__1(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x182E440", Offset = "0x182CE40", VA = "0x18182E440")]
		internal bool <Compare>b__2(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x182E450", Offset = "0x182CE50", VA = "0x18182E450")]
		internal bool <Compare>b__3(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> PHMHFFEDFKI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC0", Offset = "0x82C8C0", VA = "0x18082DEC0")]
	public DCLOJDAGGKB(List<KeepsakeCategoryThemePair> DCLHHCGDGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x182E120", Offset = "0x182CB20", VA = "0x18182E120", Slot = "4")]
	public int Compare(CJFKFPHLBGA KCAHJOFJKBP, CJFKFPHLBGA NBBBAMBDAJJ)
	{
		return default(int);
	}
}
namespace RecRoom.Keepsakes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct KeepsakeCategoryThemePair
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public CJFKFPHLBGA KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum MCOAFOHFLJD
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OIOHPIGADGP]
public class HMMEKBMCGAA : FCFLAHCLCOE, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct HMJNCPDJADG
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public const string AJINDGLEMCE = "Keepsake placement still in progress. Please wait a moment before placing another keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public const string FDIMCKACKNE = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public const string PLIIAPAIADI = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public const string LJAFCCOEIKE = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public const string DNBKAHDHPCC = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public const string DFBLNFIAIBN = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string PBNOAJILKMH = "You have to collect other keepsakes before you can collect this one.";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public const string NEKPHDPAEAH = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const string FAHIEEBJLPO = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public const string PPNKMJFFMLE = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public const string BNAOCNNJLGL = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public const string BIEPIJEHKEF = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public const string AOFFNMCOJOP = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class GLBNIGHALKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public HMMEKBMCGAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CJFKFPHLBGA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public GLBNIGHALKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x182F5A0", Offset = "0x182DFA0", VA = "0x18182F5A0")]
		internal void <CreateKeepsakeInstanceData>b__4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x182F100", Offset = "0x182DB00", VA = "0x18182F100")]
		internal void <CreateKeepsakeInstanceData>b__2(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x182F570", Offset = "0x182DF70", VA = "0x18182F570")]
		internal void <CreateKeepsakeInstanceData>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class GEIPBOHMKIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public HMMEKBMCGAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int collectedKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int collectableKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public GEIPBOHMKIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x182ECF0", Offset = "0x182D6F0", VA = "0x18182ECF0")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class ENHDNNOMOML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ENHDNNOMOML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x182E580", Offset = "0x182CF80", VA = "0x18182E580")]
		internal bool <GetKeepsakeCategory>b__0(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class INEPMCDOAAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public HMMEKBMCGAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CJFKFPHLBGA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public INEPMCDOAAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x183E3D0", Offset = "0x183CDD0", VA = "0x18183E3D0")]
		internal bool <GetRemainingKeepsakeViewQuantityForCurrentRoom>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class HMFAONKDOGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public HMMEKBMCGAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CJFKFPHLBGA? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public HMFAONKDOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x182F8D0", Offset = "0x182E2D0", VA = "0x18182F8D0")]
		internal void <GetAllKeepsakeInstanceIdsForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x182D2F0", Offset = "0x182BCF0", VA = "0x18182D2F0")]
		internal void <GetAllKeepsakeInstanceIdsForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x182F960", Offset = "0x182E360", VA = "0x18182F960")]
		internal global::DJAOLOOILHN<IEnumerable<Guid>> <GetAllKeepsakeInstanceIdsForRoom>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x182D630", Offset = "0x182C030", VA = "0x18182D630")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class HDNFALNCNOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public HMFAONKDOGG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public HDNFALNCNOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x182F780", Offset = "0x182E180", VA = "0x18182F780")]
		internal global::DJAOLOOILHN<IEnumerable<Guid>> <GetAllKeepsakeInstanceIdsForRoom>b__4(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class POELCGMAMFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public HDNFALNCNOK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public POELCGMAMFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x183F0F0", Offset = "0x183DAF0", VA = "0x18183F0F0")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__5(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class JKGPKGEKPPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public POELCGMAMFO CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public JKGPKGEKPPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x183E500", Offset = "0x183CF00", VA = "0x18183E500")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__6(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class GBJOMKOJAOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public HMMEKBMCGAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public GBJOMKOJAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x182E6D0", Offset = "0x182D0D0", VA = "0x18182E6D0")]
		internal global::DJAOLOOILHN<IEnumerable<Guid>> <GetUncollectedKeepsakeInstanceIdsForRoom>b__0(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x182E870", Offset = "0x182D270", VA = "0x18182E870")]
		internal bool <GetUncollectedKeepsakeInstanceIdsForRoom>b__1(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class AAMFPBPHHGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public HMMEKBMCGAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public AAMFPBPHHGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x182D260", Offset = "0x182BC60", VA = "0x18182D260")]
		internal void <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x182D2F0", Offset = "0x182BCF0", VA = "0x18182D2F0")]
		internal void <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x182D320", Offset = "0x182BD20", VA = "0x18182D320")]
		internal global::DJAOLOOILHN<Dictionary<Guid, CJFKFPHLBGA>> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x182D630", Offset = "0x182C030", VA = "0x18182D630")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class IAHIJNLNFHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public IAHIJNLNFHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x183E160", Offset = "0x183CB60", VA = "0x18183E160")]
		internal global::DJAOLOOILHN<Dictionary<Guid, CJFKFPHLBGA>> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__4(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class BGBLMOEDCDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public BGBLMOEDCDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x182D8C0", Offset = "0x182C2C0", VA = "0x18182D8C0")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__5(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x182D9B0", Offset = "0x182C3B0", VA = "0x18182D9B0")]
		internal KeyValuePair<Guid, CJFKFPHLBGA> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__6(Guid instanceId)
		{
			return default(KeyValuePair<Guid, CJFKFPHLBGA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class IMJDBJMBHOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public IMJDBJMBHOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x183E330", Offset = "0x183CD30", VA = "0x18183E330")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__7(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class GALFPAIGNPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public GALFPAIGNPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x182E630", Offset = "0x182D030", VA = "0x18182E630")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__8(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class GEBPHABDBFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public HMMEKBMCGAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public GEBPHABDBFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x182E890", Offset = "0x182D290", VA = "0x18182E890")]
		internal global::DJAOLOOILHN<Dictionary<Guid, CJFKFPHLBGA>> <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__0(Dictionary<Guid, CJFKFPHLBGA> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x182E870", Offset = "0x182D270", VA = "0x18182E870")]
		internal bool <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__1(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class FFHGALHDEOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public FFHGALHDEOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x182E5B0", Offset = "0x182CFB0", VA = "0x18182E5B0")]
		internal bool <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__2(KeyValuePair<Guid, CJFKFPHLBGA> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class MMMCPOJHKHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Dictionary<Guid, CJFKFPHLBGA> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public MMMCPOJHKHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x183E950", Offset = "0x183D350", VA = "0x18183E950")]
		internal KeyValuePair<CJFKFPHLBGA, int> <GetUncollectedKeepsakeCountPerCategoryForRoom>b__1(CJFKFPHLBGA category)
		{
			return default(KeyValuePair<CJFKFPHLBGA, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MOFFCGBHACF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CJFKFPHLBGA category;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public MOFFCGBHACF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x183EAB0", Offset = "0x183D4B0", VA = "0x18183EAB0")]
		internal bool <GetUncollectedKeepsakeCountPerCategoryForRoom>b__2(CJFKFPHLBGA instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class ALNKDIHDMBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Dictionary<Guid, CJFKFPHLBGA> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ALNKDIHDMBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x182D670", Offset = "0x182C070", VA = "0x18182D670")]
		internal KeyValuePair<CJFKFPHLBGA, int> <GetTotalKeepsakeCountPerCategoryForRoom>b__1(CJFKFPHLBGA category)
		{
			return default(KeyValuePair<CJFKFPHLBGA, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class NEIIMKAABEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CJFKFPHLBGA category;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public NEIIMKAABEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x183EAB0", Offset = "0x183D4B0", VA = "0x18183EAB0")]
		internal bool <GetTotalKeepsakeCountPerCategoryForRoom>b__2(CJFKFPHLBGA instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class HPACLKPJJLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public HMMEKBMCGAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public HPACLKPJJLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x183DF90", Offset = "0x183C990", VA = "0x18183DF90")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x183E060", Offset = "0x183CA60", VA = "0x18183E060")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x183E060", Offset = "0x183CA60", VA = "0x18183E060")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class BJOPMNHPBGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public BJOPMNHPBGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x182DBE0", Offset = "0x182C5E0", VA = "0x18182DBE0")]
		internal bool <GetHighlightKeepsakeRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class EALIKBDCIJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public EALIKBDCIJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x182E460", Offset = "0x182CE60", VA = "0x18182E460")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x182E530", Offset = "0x182CF30", VA = "0x18182E530")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__1(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KPLCLIDNMIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public KPLCLIDNMIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x183E5F0", Offset = "0x183CFF0", VA = "0x18183E5F0")]
		internal bool <GetKeepsakeRoomListUpsellItemPurchasableGiftDropId>b__0(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HMLEFDLCIKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public HMLEFDLCIKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x182DBE0", Offset = "0x182C5E0", VA = "0x18182DBE0")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class BGMHMNKCBBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public BGMHMNKCBBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x182DB50", Offset = "0x182C550", VA = "0x18182DB50")]
		internal bool <IsKeepsakeInCurrentKeepsakeCategory>b__0(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class ALFJBDFGGEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public CJFKFPHLBGA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ALFJBDFGGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x182D650", Offset = "0x182C050", VA = "0x18182D650")]
		internal bool <TryGetNextOrphanedKeepsakeInstanceFromCategory>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class CBHGMFJDKPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public CBHGMFJDKPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x182DC00", Offset = "0x182C600", VA = "0x18182DC00")]
		internal bool <IncrementCollectedKeepsakeCount>b__0(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class BGLKHMJANNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CJFKFPHLBGA keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public BGLKHMJANNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x182DB10", Offset = "0x182C510", VA = "0x18182DB10")]
		internal bool <GetTotalCollectableKeepsakeCountForCategory>b__0(KeyValuePair<Guid, CJFKFPHLBGA> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class EDBMMHFANLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public CJFKFPHLBGA newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public EDBMMHFANLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x182D650", Offset = "0x182C050", VA = "0x18182D650")]
		internal bool <OnKeepsakeCollected>b__0(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class MGIACIBIFOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public MGIACIBIFOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x183E8B0", Offset = "0x183D2B0", VA = "0x18183E8B0")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class BALEPPPEPLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public BALEPPPEPLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x182D7D0", Offset = "0x182C1D0", VA = "0x18182D7D0")]
		internal bool <GetKeepsakeRoomIdsInList>b__0(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class DECCOAOFDFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public BALEPPPEPLI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public DECCOAOFDFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x182E3C0", Offset = "0x182CDC0", VA = "0x18182E3C0")]
		internal bool <GetKeepsakeRoomIdsInList>b__3(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct CCBJGJLGPGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public HMMEKBMCGAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public DMJOALMBJOK args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x182DC90", Offset = "0x182C690", VA = "0x18182DC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9396C0", Offset = "0x9380C0", VA = "0x1809396C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct GEGHHINJLPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public HMMEKBMCGAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x182EAB0", Offset = "0x182D4B0", VA = "0x18182EAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9396C0", Offset = "0x9380C0", VA = "0x1809396C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int JOELEBFNGNN = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DateTime NDEAFDHIHMH;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int GBFBGDIAAEO = 3;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const long MPGIGAGEJFD = -1L;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const char BGEFDAMKMGC = '|';

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly JFBKGLEAMMJ HNBHCHEJEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly LNEIJGHHPOL LNAGCMNFNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly LKFMHMJNPEG KJFPFNBFBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly NKKLFHJBGKK JBIGHIAGDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly CLNJFDNAGCO FPCNNHGICMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly IKEMHFALOAH AEILLIBHJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly NKOMLCDDHJJ AHKGDIJPOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly OCLEBINCMDF NNIBJADPKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly OCKDMPNIOAH OPEIDBOJCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly OGBFGFDNFLG BBJJGHBEMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly MFLBDNDDICK MBBPLDEADGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly AKMCBAIADAB HIMCJLNBFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly JGNCHMNFEEB AJKKFODAOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly ABKECFEDDCF APNACMJJDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly PLABCCAFOIB KOJCJPGMKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly global::LHLKKOLPFIN<KeepsakesConfig.KeepsakesOptions> GFLJMAGGCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly CIHIKLANABD DIGJFFNDGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> FPECBOALBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly HashSet<Guid> PNMMGLDJHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly HashSet<long> PMEMOGGMFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private Dictionary<CJFKFPHLBGA, int> LLBCGAKJHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<Guid> FANFKDPAHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IDisposable JHCLKFOAFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Task OICCDHPGGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private global::DJAOLOOILHN<Guid> HKBDCNMMDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private long? LAJBPLIPCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private KeepsakeProgressionEventInstancesDTO FEAFBBNGGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private global::DJAOLOOILHN<KeepsakeProgressionEventInstancesDTO> BEHECKLJIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private IReadOnlyDictionary<CJFKFPHLBGA, KeepsakeCategoryConfigDTO> JAHOHAGNCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private KeepsakeGlobalConfigDTO JODHFMNAGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private HashSet<long> AKMFJOEOKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private HashSet<long> AAHGLENPJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<KeepsakeRoomListDTO> BDAICHBFJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private List<KeepsakeRoomListDTO> HBBHPFEHOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private List<KeepsakeRoomListDTO> HPIBMCEAJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Dictionary<long, string> IGJKOKHNEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<long, string> ACKICEEBLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<long, DateTime> KLDFLOLDMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<long, List<KeepsakeRoomDTO>> KDCPKEGJBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<long, List<KeepsakeRoomDTO>> DGOHKNIBICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<long, long> FIHMIGCNFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<string> MMBGHOPCDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private DateTime NBFBDOKDJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly IDisposable LGKAJMGCHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Dictionary<Guid, CJFKFPHLBGA> EEKABDDHONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Dictionary<CJFKFPHLBGA, int> PGKLFCIMCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private List<KeepsakeCategoryThemePair> DCLHHCGDGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private DCLOJDAGGKB NCLOFAEEPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private bool AFPCEIIOKHB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool HCLEEJLBCKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83BF80", Offset = "0x83A980", VA = "0x18083BF80", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83BFA0", Offset = "0x83A9A0", VA = "0x18083BFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CDIDFMOBMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1835910", Offset = "0x1834310", VA = "0x181835910", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HBHPCHNIMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1834430", Offset = "0x1832E30", VA = "0x181834430", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long GFACCBFNJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1836FE0", Offset = "0x18359E0", VA = "0x181836FE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? KMGFDDIBMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1838410", Offset = "0x1836E10", VA = "0x181838410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool PKCKCJNMIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x183C090", Offset = "0x183AA90", VA = "0x18183C090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> DLMKLIHNCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7DABE0", Offset = "0x7D95E0", VA = "0x1807DABE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> PHFCJBOFJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7D5720", Offset = "0x7D4120", VA = "0x1807D5720", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> GIGNBKDCBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A00", Offset = "0x7D6400", VA = "0x1807D7A00", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> DBDDPPKMMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D66E0", Offset = "0x7D50E0", VA = "0x1807D66E0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> EDCBMDPLOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7DABC0", Offset = "0x7D95C0", VA = "0x1807DABC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal bool LOPIDFOPACC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C10", Offset = "0x8B6610", VA = "0x1808B7C10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x183BC40", Offset = "0x183A640", VA = "0x18183BC40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> CPLPIMOPJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1839410", Offset = "0x1837E10", VA = "0x181839410", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1839170", Offset = "0x1837B70", VA = "0x181839170", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NCEDAFIKCEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x18399D0", Offset = "0x18383D0", VA = "0x1818399D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x18363C0", Offset = "0x1834DC0", VA = "0x1818363C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action DFNLMJDIGNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x183C640", Offset = "0x183B040", VA = "0x18183C640", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1839BA0", Offset = "0x18385A0", VA = "0x181839BA0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x183CCB0", Offset = "0x183B6B0", VA = "0x18183CCB0")]
	[Preserve]
	internal HMMEKBMCGAA([NotNull][PDHOKDIGCJO(null)] JFBKGLEAMMJ HNBHCHEJEKI, [NotNull][PDHOKDIGCJO(null)] HHHJBFHIDKM APCGCCMPHJO, [NotNull][PDHOKDIGCJO(null)] LNEIJGHHPOL LNAGCMNFNMH, [NotNull][PDHOKDIGCJO(null)] LKFMHMJNPEG KJFPFNBFBJK, [NotNull][PDHOKDIGCJO(null)] NKKLFHJBGKK JBIGHIAGDPE, [NotNull][PDHOKDIGCJO(null)] CLNJFDNAGCO FPCNNHGICMP, [NotNull][PDHOKDIGCJO(null)] IKEMHFALOAH AEILLIBHJJK, [NotNull][PDHOKDIGCJO(null)] NKOMLCDDHJJ AHKGDIJPOHM, [NotNull][PDHOKDIGCJO(null)] OCLEBINCMDF NNIBJADPKIG, [NotNull][PDHOKDIGCJO(null)] PIJBAEGMOCF EKBAJJPGNNO, [NotNull][PDHOKDIGCJO(null)] OCKDMPNIOAH OPEIDBOJCEA, [NotNull][PDHOKDIGCJO(null)] OGBFGFDNFLG BBJJGHBEMGC, [NotNull][PDHOKDIGCJO(null)] MFLBDNDDICK MBBPLDEADGM, [NotNull][PDHOKDIGCJO(null)] AKMCBAIADAB HIMCJLNBFJF, [NotNull][PDHOKDIGCJO(null)] JGNCHMNFEEB AJKKFODAOCD, [NotNull][PDHOKDIGCJO(null)] ABKECFEDDCF APNACMJJDKJ, [NotNull][PDHOKDIGCJO(null)] PLABCCAFOIB KOJCJPGMKLH, [NotNull][PDHOKDIGCJO(null)] global::LHLKKOLPFIN<KeepsakesConfig.KeepsakesOptions> GFLJMAGGCPJ, [NotNull][PDHOKDIGCJO(null)] CIHIKLANABD DIGJFFNDGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1838100", Offset = "0x1836B00", VA = "0x181838100", Slot = "15")]
	public bool KCKGELKPHOC(List<string> GINAAIAHMHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1838AD0", Offset = "0x18374D0", VA = "0x181838AD0", Slot = "16")]
	public global::DJAOLOOILHN<Guid> LCBNMOGANIG(CJFKFPHLBGA KLPICBBCBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x18378A0", Offset = "0x18362A0", VA = "0x1818378A0", Slot = "17")]
	public OFEHPCFKLFI JFKPECMAABI(Guid EBLAFADKOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1836C50", Offset = "0x1835650", VA = "0x181836C50", Slot = "18")]
	public OFEHPCFKLFI IDJMDOLEPFI(Guid EBLAFADKOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1834570", Offset = "0x1832F70", VA = "0x181834570", Slot = "19")]
	public bool EMBFMEBJKLN(Guid EBLAFADKOLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1831AA0", Offset = "0x18304A0", VA = "0x181831AA0", Slot = "20")]
	public bool BLHPDKADPON(Guid EBLAFADKOLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x183AAF0", Offset = "0x18394F0", VA = "0x18183AAF0")]
	public KeepsakeTheme MNOLGMFDJCI(Guid EBLAFADKOLC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x18303F0", Offset = "0x182EDF0", VA = "0x1818303F0")]
	public bool AGNLKKKAHJE(CJFKFPHLBGA KLPICBBCBEB, out KeepsakeTheme MOPDABOHAON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x182FE40", Offset = "0x182E840", VA = "0x18182FE40")]
	public List<KeepsakeTheme> AEBPABNAIPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1833490", Offset = "0x1831E90", VA = "0x181833490")]
	public int EFFIFDAKCOF(CJFKFPHLBGA KLPICBBCBEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1832220", Offset = "0x1830C20", VA = "0x181832220")]
	public CJFKFPHLBGA DBGHLDMLACJ(Guid EBLAFADKOLC)
	{
		return default(CJFKFPHLBGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1835BA0", Offset = "0x18345A0", VA = "0x181835BA0", Slot = "34")]
	public List<CJFKFPHLBGA> HAJAGDPIFHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x183AEE0", Offset = "0x18398E0", VA = "0x18183AEE0", Slot = "35")]
	public IComparer<CJFKFPHLBGA> NAKDAPICIKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x183AF80", Offset = "0x1839980", VA = "0x18183AF80", Slot = "32")]
	public string NEBNDDGBJJH(CJFKFPHLBGA KLPICBBCBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x183BA00", Offset = "0x183A400", VA = "0x18183BA00", Slot = "33")]
	public string NKBOOBDHKDC(CJFKFPHLBGA KLPICBBCBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1839730", Offset = "0x1838130", VA = "0x181839730", Slot = "21")]
	public bool LOKHBGHMGLK(Guid EBLAFADKOLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x183BBD0", Offset = "0x183A5D0", VA = "0x18183BBD0", Slot = "22")]
	public void OGNPBJLKGBO(Guid EBLAFADKOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x183BFC0", Offset = "0x183A9C0", VA = "0x18183BFC0", Slot = "23")]
	public void OKMEHDMDIDE(CJFKFPHLBGA KLPICBBCBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1836460", Offset = "0x1834E60", VA = "0x181836460", Slot = "24")]
	public void HEINMDPNEPP(Guid EBLAFADKOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1831450", Offset = "0x182FE50", VA = "0x181831450", Slot = "25")]
	public int BJGFPJKIPIK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x18310E0", Offset = "0x182FAE0", VA = "0x1818310E0", Slot = "54")]
	public int BJGFPJKIPIK(CJFKFPHLBGA KLPICBBCBEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x18305C0", Offset = "0x182EFC0", VA = "0x1818305C0", Slot = "31")]
	public global::DJAOLOOILHN<IEnumerable<Guid>> AHJAHDBEBEN(long GPCCPBNNCAG, long AKANJBGBLEM, CJFKFPHLBGA? KLPICBBCBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1832BD0", Offset = "0x18315D0", VA = "0x181832BD0", Slot = "30")]
	public global::DJAOLOOILHN<IEnumerable<Guid>> DODMMGAIBPO(long GPCCPBNNCAG, long AKANJBGBLEM, CJFKFPHLBGA? KLPICBBCBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1838580", Offset = "0x1836F80", VA = "0x181838580", Slot = "55")]
	public global::DJAOLOOILHN<Dictionary<Guid, CJFKFPHLBGA>> KJNPFMDFGKN(long GPCCPBNNCAG, long AKANJBGBLEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x183BCB0", Offset = "0x183A6B0", VA = "0x18183BCB0", Slot = "56")]
	public global::DJAOLOOILHN<Dictionary<Guid, CJFKFPHLBGA>> OIMBOBEJLFH(long GPCCPBNNCAG, long AKANJBGBLEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x183C0A0", Offset = "0x183AAA0", VA = "0x18183C0A0", Slot = "26")]
	public global::DJAOLOOILHN<int> PDBPFHIAKCB(long GPCCPBNNCAG, long AKANJBGBLEM, CJFKFPHLBGA? KLPICBBCBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1834BA0", Offset = "0x18335A0", VA = "0x181834BA0", Slot = "27")]
	public global::DJAOLOOILHN<int> FBNPOGBNMGG(long GPCCPBNNCAG, long AKANJBGBLEM, CJFKFPHLBGA? KLPICBBCBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1832510", Offset = "0x1830F10", VA = "0x181832510", Slot = "28")]
	public global::DJAOLOOILHN<Dictionary<CJFKFPHLBGA, int>> DFJGHFJAAOO(long GPCCPBNNCAG, long AKANJBGBLEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x183BEF0", Offset = "0x183A8F0", VA = "0x18183BEF0", Slot = "29")]
	public global::DJAOLOOILHN<Dictionary<CJFKFPHLBGA, int>> OKKMLBENOMF(long GPCCPBNNCAG, long AKANJBGBLEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x18321C0", Offset = "0x1830BC0", VA = "0x1818321C0", Slot = "37")]
	public bool CEOMIDMDAFA(long GPCCPBNNCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x183BB70", Offset = "0x183A570", VA = "0x18183BB70", Slot = "57")]
	public bool OBHIFINFHDC(long GPCCPBNNCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1832830", Offset = "0x1831230", VA = "0x181832830", Slot = "38")]
	public bool DJBKGFFMCEN(long GPCCPBNNCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x18350F0", Offset = "0x1833AF0", VA = "0x1818350F0", Slot = "58")]
	public bool GLHJEDCHJBJ(long GPCCPBNNCAG, out LFJHBAPJOEC NOJLKBLDGBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1833230", Offset = "0x1831C30", VA = "0x181833230", Slot = "39")]
	public bool EDCBNOKOIBB(long LDCIADOLPPD, out DateTime BFJOAGEGGAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x183A2B0", Offset = "0x1838CB0", VA = "0x18183A2B0", Slot = "40")]
	public long MIOECLOBJLK(long LDCIADOLPPD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1837B20", Offset = "0x1836520", VA = "0x181837B20", Slot = "59")]
	public IEnumerable<int> JNOJNOFNHBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x18323F0", Offset = "0x1830DF0", VA = "0x1818323F0", Slot = "41")]
	public long DDNKDOKDJFH(long GPCCPBNNCAG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1839210", Offset = "0x1837C10", VA = "0x181839210", Slot = "42")]
	public int LFKDDBOKLDL(long LDCIADOLPPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x18328D0", Offset = "0x18312D0", VA = "0x1818328D0", Slot = "43")]
	public bool DJEHACENFEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1830E20", Offset = "0x182F820", VA = "0x181830E20", Slot = "44")]
	public bool BJALOLJAPBP(long LDCIADOLPPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1839550", Offset = "0x1837F50", VA = "0x181839550", Slot = "45")]
	public IEnumerable<long> LJPDPEMLCNE(long LDCIADOLPPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1830340", Offset = "0x182ED40", VA = "0x181830340", Slot = "46")]
	public int AGIGKBDALNB(long LDCIADOLPPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x183A740", Offset = "0x1839140", VA = "0x18183A740", Slot = "50")]
	public long MNAADBJAJHH(long NPNNGINBAPF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x183C8A0", Offset = "0x183B2A0", VA = "0x18183C8A0", Slot = "51")]
	public CJFKFPHLBGA PMMDMHJFPCI()
	{
		return default(CJFKFPHLBGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x18348E0", Offset = "0x18332E0", VA = "0x1818348E0")]
	private bool EPDIAICPMED(Guid EBLAFADKOLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1831D20", Offset = "0x1830720", VA = "0x181831D20")]
	private void CBLPKDFAFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1837320", Offset = "0x1835D20", VA = "0x181837320")]
	private CJFKFPHLBGA IPKMLDPPNFM()
	{
		return default(CJFKFPHLBGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x18366A0", Offset = "0x18350A0", VA = "0x1818366A0")]
	private void HGIJHMKEDLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1830190", Offset = "0x182EB90", VA = "0x181830190")]
	private int AEMOEGDPHIG(KeepsakeRoomListDTO IFDAEJNKLIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x18309D0", Offset = "0x182F3D0", VA = "0x1818309D0")]
	private int ANACHNBLGGH(DateTime NKOELNLAFFI, DateTime OGMKCAAEMNK, TimeSpan NLOKODEKPMH, int JDNPANAHGOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x18329C0", Offset = "0x18313C0", VA = "0x1818329C0")]
	private void DLNLAIENNAM(IEnumerable<KeepsakeInstanceDTO> FPECBOALBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1835960", Offset = "0x1834360", VA = "0x181835960")]
	private void HAHOJLJOFNN(IEnumerable<KeepsakeCollectionRecordDTO> LBPFFLAOBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x183CC50", Offset = "0x183B650", VA = "0x18183CC50")]
	private void PNBKLIDNJLM(IEnumerable<long> NKFHONFBFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7D79C0", Offset = "0x7D63C0", VA = "0x1807D79C0")]
	private void JHCIHINLJAK(KeepsakeGlobalConfigDTO JODHFMNAGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x183AC30", Offset = "0x1839630", VA = "0x18183AC30")]
	private bool MOBHAHIPEJD(CJFKFPHLBGA KLPICBBCBEB, out Guid HLGKAPCFDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1839A70", Offset = "0x1838470", VA = "0x181839A70")]
	private bool MCLMGPBDAJJ(out Guid HLGKAPCFDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x183A6E0", Offset = "0x18390E0", VA = "0x18183A6E0")]
	private bool MLJBAINILNL(Guid EBLAFADKOLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1830AC0", Offset = "0x182F4C0", VA = "0x181830AC0")]
	private IEnumerable<Guid> BGFJFILKAIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1831AD0", Offset = "0x18304D0", VA = "0x181831AD0")]
	private IEnumerable<KeepsakeInstanceDTO> BPPKOGJGFAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x183C000", Offset = "0x183AA00", VA = "0x18183C000")]
	private void OPDAJLFDFCP(Guid EBLAFADKOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1836310", Offset = "0x1834D10", VA = "0x181836310")]
	private bool HDJJAMFMMOF(Guid EBLAFADKOLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x183C4A0", Offset = "0x183AEA0", VA = "0x18183C4A0")]
	private void PHLAGDAPHMD(Guid EBLAFADKOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x18384A0", Offset = "0x1836EA0", VA = "0x1818384A0")]
	private void KEODIMHDCPH(CJFKFPHLBGA DNDFMPOMIEK, int AGJEEONGEBC, ref Dictionary<CJFKFPHLBGA, int> DOPLDHNKHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1832730", Offset = "0x1831130", VA = "0x181832730")]
	private int DGCMEIMMAAJ(CJFKFPHLBGA KLPICBBCBEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x183C6E0", Offset = "0x183B0E0", VA = "0x18183C6E0")]
	private void PKKIKGCDHLF(KeepsakeInstanceDTO MEFBKKIADIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x18318A0", Offset = "0x18302A0", VA = "0x1818318A0")]
	private void BKGDONBLKBA(KeepsakeInstanceDTO MEFBKKIADIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x183B660", Offset = "0x183A060", VA = "0x18183B660")]
	private void NIMGLGAJIMM(Guid EBLAFADKOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1839B40", Offset = "0x1838540", VA = "0x181839B40")]
	private void MGELIMADFJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1838990", Offset = "0x1837390", VA = "0x181838990")]
	private void KLEBGPNDOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x183AA80", Offset = "0x1839480", VA = "0x18183AA80")]
	private void MNDMCCCJFBO(LEJGFBCAMJJ BEBIDLJFJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x18331D0", Offset = "0x1831BD0", VA = "0x1818331D0")]
	private void ECGFNMEDKFE(BGJKKAEOCBC.KEIOBECDENJ OMHIFHKMIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1832390", Offset = "0x1830D90", VA = "0x181832390")]
	private void DBNCOGNEPOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1834D10", Offset = "0x1833710", VA = "0x181834D10")]
	private void FHHHOCMELPJ(float FHECCMICMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x183B0F0", Offset = "0x1839AF0", VA = "0x18183B0F0")]
	private void NHOKFBOMNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1830C20", Offset = "0x182F620", VA = "0x181830C20")]
	private bool BIACMIPHOAA(Guid EBLAFADKOLC, out string DLMKABHBNBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x182FC70", Offset = "0x182E670", VA = "0x18182FC70")]
	private bool ADKKIBCLCCG(Guid EBLAFADKOLC, out KeepsakeCategoryConfigDTO DNDFMPOMIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1834350", Offset = "0x1832D50", VA = "0x181834350")]
	private void EJHPADBKEMF(string MHOCGHKABIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1833380", Offset = "0x1831D80", VA = "0x181833380")]
	private bool EDPNPOCMFLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x18354B0", Offset = "0x1833EB0", VA = "0x1818354B0")]
	private IEnumerable<long> GMBHAFOJPGM(IEnumerable<KeepsakeRoomDTO> BGNAOHEPANC, IEnumerable<KeepsakeRoomListDTO> KILIBPDILJB, long LDCIADOLPPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1839C40", Offset = "0x1838640", VA = "0x181839C40")]
	private bool MHLBIEBOHBE(Guid EBLAFADKOLC, out string MCCDEFDHGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1839110", Offset = "0x1837B10", VA = "0x181839110", Slot = "47")]
	public string LDEIIEBJDDF(ADPLFNDBLHL IHEHFHENADJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1835ED0", Offset = "0x18348D0", VA = "0x181835ED0", Slot = "49")]
	public string HCHCGDGJIBG(ADPLFNDBLHL IHEHFHENADJ, long GPCCPBNNCAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x18389B0", Offset = "0x18373B0", VA = "0x1818389B0", Slot = "48")]
	public string KLPPPKPBEOB(ADPLFNDBLHL IHEHFHENADJ, int MNGHBLPEACJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1833600", Offset = "0x1832000", VA = "0x181833600")]
	private void EIAILOFBJME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x183A170", Offset = "0x1838B70", VA = "0x18183A170")]
	private void MHLOHMLAGID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1830AA0", Offset = "0x182F4A0", VA = "0x181830AA0")]
	private ADPLFNDBLHL BGFFOLEMNAE(FAHLKNHLFCG GNAGDNHJFAA)
	{
		return default(ADPLFNDBLHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x18348C0", Offset = "0x18332C0", VA = "0x1818348C0")]
	private ADPLFNDBLHL EOEEGFEGKIK(FAHLKNHLFCG GNAGDNHJFAA)
	{
		return default(ADPLFNDBLHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1835CF0", Offset = "0x18346F0", VA = "0x181835CF0")]
	internal static string HCABKHHLKBD(BODCKPAHBMD KFEAFPNMCHI, string MIKDEODLPBH, bool JHHMPPGLPPD, int PHDFLJPIMAN, int BKKFAHJOOGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1832D70", Offset = "0x1831770", VA = "0x181832D70", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x18344F0", Offset = "0x1832EF0", VA = "0x1818344F0")]
	private HMLPBJPAEKI EKDMPGLMKPE(DLMMMHADHKF IHHJGEMMEIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1837610", Offset = "0x1836010", VA = "0x181837610")]
	private HKNOJOICLHO JAINIEAJCHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1837D70", Offset = "0x1836770", VA = "0x181837D70")]
	private Task JPDIFNLFCDD(DMJOALMBJOK LIKLGHJBPPH, CancellationToken FAPLHFKLMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x183C350", Offset = "0x183AD50", VA = "0x18183C350")]
	[AsyncStateMachine(typeof(CCBJGJLGPGI))]
	private Task PHBKJKLKLAI(DMJOALMBJOK LIKLGHJBPPH, CancellationToken FAPLHFKLMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x18394B0", Offset = "0x1837EB0", VA = "0x1818394B0")]
	private Task LJIAJGPPOJD(DMJOALMBJOK LIKLGHJBPPH, CancellationToken FAPLHFKLMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x18371D0", Offset = "0x1835BD0", VA = "0x1818371D0")]
	[AsyncStateMachine(typeof(GEGHHINJLPH))]
	private Task IJBAHGKBIPJ(string MDEEJIBNIAD, TimeSpan HBOJNLEBJCL, CancellationToken FAPLHFKLMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x18350D0", Offset = "0x1833AD0", VA = "0x1818350D0")]
	[CompilerGenerated]
	private void FLEIPOLILKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x183BE40", Offset = "0x183A840", VA = "0x18183BE40")]
	[CompilerGenerated]
	private void OJGBAPMJDEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x18377B0", Offset = "0x18361B0", VA = "0x1818377B0")]
	[CompilerGenerated]
	private bool JEFOLNMMFAA(KeepsakeInstanceDTO KCAHJOFJKBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1831BA0", Offset = "0x18305A0", VA = "0x181831BA0")]
	[CompilerGenerated]
	private global::DJAOLOOILHN<Dictionary<CJFKFPHLBGA, int>> CBGNGCAHODI(Dictionary<Guid, CJFKFPHLBGA> LJADAHPHKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1834A20", Offset = "0x1833420", VA = "0x181834A20")]
	[CompilerGenerated]
	private global::DJAOLOOILHN<Dictionary<CJFKFPHLBGA, int>> FBEBAMNPPLO(Dictionary<Guid, CJFKFPHLBGA> LJADAHPHKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x18348A0", Offset = "0x18332A0", VA = "0x1818348A0")]
	[CompilerGenerated]
	private bool ENHAFHKPMNI(KeepsakeRoomListDTO KCAHJOFJKBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x18370C0", Offset = "0x1835AC0", VA = "0x1818370C0")]
	[CompilerGenerated]
	private bool IHCOKIFHAFF(KeepsakeInstanceDTO KCAHJOFJKBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1835790", Offset = "0x1834190", VA = "0x181835790")]
	[CompilerGenerated]
	private void GOBFJGKDMFN(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<CJFKFPHLBGA, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> BOCHKEAMMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x183BE90", Offset = "0x183A890", VA = "0x18183BE90")]
	[CompilerGenerated]
	private void OJMFCIADPKO(string MCCDEFDHGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x18346B0", Offset = "0x18330B0", VA = "0x1818346B0")]
	[CompilerGenerated]
	private Task ENFLDJOKEDB(CancellationToken EMIMAEEAFDC)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct KeepsakeTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string ThemeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int ThemeOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[Header("Pickup")]
		public string PickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public GameObject PickupPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AudioClip PickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public float PickupSfxVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[Header("Colors")]
		public bool UseCustomColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Color BeamColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Color BaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[Header("Looping Sound")]
		public AudioClip LoopingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public float LoopingSfxVolume;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KeepsakesConfig : ScriptableObject, global::LHLKKOLPFIN<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002F")]
			[CompilerGenerated]
			private sealed class EBBKAHHIAHK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
				public EBBKAHHIAHK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x182E550", Offset = "0x182CF50", VA = "0x18182E550")]
				internal bool <TryGetKeepsakeTheme>b__0(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x182E550", Offset = "0x182CF50", VA = "0x18182E550")]
				internal bool <TryGetKeepsakeTheme>b__1(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x82DEC0", Offset = "0x82C8C0", VA = "0x18082DEC0")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] EFGMEJIACGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x183E6E0", Offset = "0x183D0E0", VA = "0x18183E6E0")]
			public bool HPIAMCANJNH(string JGADLJIJDED, out KeepsakeTheme MOPDABOHAON)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public KeepsakesOptions Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x183E660", Offset = "0x183D060", VA = "0x18183E660")]
		[MBJLKJLIAAH(JDACKNHLALI.None)]
		private static void GPOFCIGNOAI(DPALDOJEBJE GCADPHBJBBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x961520", Offset = "0x95FF20", VA = "0x180961520")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class NNIFMOPFNIE
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static byte[] FNNHBCFPBIC;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static int IPKGAJADJFC;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static int DIJMLDGECMG;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static BigInteger DGOGINAIMEE;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NNIFMOPFNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x183EAC0", Offset = "0x183D4C0", VA = "0x18183EAC0")]
	private static string DAIOEIOFDHG(byte[] LPDJCHOFJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x183EBD0", Offset = "0x183D5D0", VA = "0x18183EBD0")]
	public static string LIOEFPBPBEO(byte[] AHIMNOMEIMA, bool ADOOPHPHCDD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
