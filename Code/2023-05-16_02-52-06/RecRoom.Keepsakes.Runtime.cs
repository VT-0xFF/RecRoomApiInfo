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
public class KDPBOILNMBG : IComparer<JHAAPFBDNOG>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class DAMKGBCJBJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public JHAAPFBDNOG x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public JHAAPFBDNOG y;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public DAMKGBCJBJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1204510", Offset = "0x1203310", VA = "0x181204510")]
		internal bool <Compare>b__0(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x135A0A0", Offset = "0x1358EA0", VA = "0x18135A0A0")]
		internal bool <Compare>b__1(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1204510", Offset = "0x1203310", VA = "0x181204510")]
		internal bool <Compare>b__2(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x135A0A0", Offset = "0x1358EA0", VA = "0x18135A0A0")]
		internal bool <Compare>b__3(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> LCKDMLPDPBO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x740F40", Offset = "0x73FD40", VA = "0x180740F40")]
	public KDPBOILNMBG(List<KeepsakeCategoryThemePair> JIJOFJDFJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x57D5BF0", Offset = "0x57D49F0", VA = "0x1857D5BF0", Slot = "4")]
	public int Compare(JHAAPFBDNOG NHKCICGBPMI, JHAAPFBDNOG PEKPPEFFGIG)
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
		public JHAAPFBDNOG KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum GAJANLNEPKD
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BCNMPBBOPDG]
public class NMONBEMMKBD : JFFHBKMMKFJ, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct NEAHGBJNGOA
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public const string BECNHCILEPH = "Keepsake placement still in progress. Please wait a moment before placing another keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public const string HPGCGDCENJP = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public const string OPPEHCFOHLD = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public const string CLCKLFNIGBH = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public const string HMEMEJKOMNN = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public const string EEIPDMLPLHH = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string NDDHNJGOAKH = "You have to collect other keepsakes before you can collect this one.";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public const string BGNFMOOKLOE = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const string OIFKIEOAMKN = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public const string BBLAJODONEL = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public const string FOENIOCFFAL = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public const string JLJGKLBBBJO = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public const string HMOMFAAINAM = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class HDMAFIHKNOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public NMONBEMMKBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public JHAAPFBDNOG keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public HDMAFIHKNOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x57D4D40", Offset = "0x57D3B40", VA = "0x1857D4D40")]
		internal void <CreateKeepsakeInstanceData>b__4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x57D48A0", Offset = "0x57D36A0", VA = "0x1857D48A0")]
		internal void <CreateKeepsakeInstanceData>b__2(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x57D4D10", Offset = "0x57D3B10", VA = "0x1857D4D10")]
		internal void <CreateKeepsakeInstanceData>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class KBNFBGJKJEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NMONBEMMKBD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public KBNFBGJKJEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x57D57E0", Offset = "0x57D45E0", VA = "0x1857D57E0")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class POBFBCOKGGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public POBFBCOKGGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x57E5500", Offset = "0x57E4300", VA = "0x1857E5500")]
		internal bool <GetKeepsakeCategory>b__0(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class AGIAOBCJOOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NMONBEMMKBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public JHAAPFBDNOG keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public AGIAOBCJOOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x57D36E0", Offset = "0x57D24E0", VA = "0x1857D36E0")]
		internal bool <GetRemainingKeepsakeViewQuantityForCurrentRoom>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class EADLLHDMMPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NMONBEMMKBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public JHAAPFBDNOG? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public EADLLHDMMPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x57D4240", Offset = "0x57D3040", VA = "0x1857D4240")]
		internal void <GetAllKeepsakeInstanceIdsForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x57D42D0", Offset = "0x57D30D0", VA = "0x1857D42D0")]
		internal void <GetAllKeepsakeInstanceIdsForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x57D4300", Offset = "0x57D3100", VA = "0x1857D4300")]
		internal global::OOLBMJPBBIG<IEnumerable<Guid>> <GetAllKeepsakeInstanceIdsForRoom>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x57D4610", Offset = "0x57D3410", VA = "0x1857D4610")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class IDMLJIBFIDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EADLLHDMMPL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public IDMLJIBFIDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x57D4F20", Offset = "0x57D3D20", VA = "0x1857D4F20")]
		internal global::OOLBMJPBBIG<IEnumerable<Guid>> <GetAllKeepsakeInstanceIdsForRoom>b__4(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class CGFNFMJFLMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IDMLJIBFIDC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public CGFNFMJFLMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x57D3EC0", Offset = "0x57D2CC0", VA = "0x1857D3EC0")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__5(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class POABNANMEPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CGFNFMJFLMF CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public POABNANMEPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x57E5410", Offset = "0x57E4210", VA = "0x1857E5410")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__6(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class NMCKCCNOKFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public NMONBEMMKBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public NMCKCCNOKFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x57D65F0", Offset = "0x57D53F0", VA = "0x1857D65F0")]
		internal global::OOLBMJPBBIG<IEnumerable<Guid>> <GetUncollectedKeepsakeInstanceIdsForRoom>b__0(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3BA31A0", Offset = "0x3BA1FA0", VA = "0x183BA31A0")]
		internal bool <GetUncollectedKeepsakeInstanceIdsForRoom>b__1(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class MANDLEOEPAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public NMONBEMMKBD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public MANDLEOEPAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x57D61B0", Offset = "0x57D4FB0", VA = "0x1857D61B0")]
		internal void <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x57D42D0", Offset = "0x57D30D0", VA = "0x1857D42D0")]
		internal void <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x57D6240", Offset = "0x57D5040", VA = "0x1857D6240")]
		internal global::OOLBMJPBBIG<Dictionary<Guid, JHAAPFBDNOG>> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x57D4610", Offset = "0x57D3410", VA = "0x1857D4610")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class OEHBCGBNBPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public OEHBCGBNBPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x57E4BF0", Offset = "0x57E39F0", VA = "0x1857E4BF0")]
		internal global::OOLBMJPBBIG<Dictionary<Guid, JHAAPFBDNOG>> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__4(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PNFKEPIEGCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public PNFKEPIEGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x57E51C0", Offset = "0x57E3FC0", VA = "0x1857E51C0")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__5(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x57E52B0", Offset = "0x57E40B0", VA = "0x1857E52B0")]
		internal KeyValuePair<Guid, JHAAPFBDNOG> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__6(Guid instanceId)
		{
			return default(KeyValuePair<Guid, JHAAPFBDNOG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class GJDHGBPKMAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public GJDHGBPKMAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x57D4800", Offset = "0x57D3600", VA = "0x1857D4800")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__7(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class MBGBNJJPDPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public MBGBNJJPDPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x57D6550", Offset = "0x57D5350", VA = "0x1857D6550")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__8(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BNDGPABDDDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public NMONBEMMKBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public BNDGPABDDDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x57D3810", Offset = "0x57D2610", VA = "0x1857D3810")]
		internal global::OOLBMJPBBIG<Dictionary<Guid, JHAAPFBDNOG>> <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__0(Dictionary<Guid, JHAAPFBDNOG> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3BA31A0", Offset = "0x3BA1FA0", VA = "0x183BA31A0")]
		internal bool <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__1(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class COHAGCGAGJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public COHAGCGAGJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x57D4060", Offset = "0x57D2E60", VA = "0x1857D4060")]
		internal bool <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__2(KeyValuePair<Guid, JHAAPFBDNOG> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DFOFFGNDKLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Dictionary<Guid, JHAAPFBDNOG> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public DFOFFGNDKLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x57D40E0", Offset = "0x57D2EE0", VA = "0x1857D40E0")]
		internal KeyValuePair<JHAAPFBDNOG, int> <GetUncollectedKeepsakeCountPerCategoryForRoom>b__1(JHAAPFBDNOG category)
		{
			return default(KeyValuePair<JHAAPFBDNOG, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class ECCCKNEJMOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public JHAAPFBDNOG category;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ECCCKNEJMOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x13BC280", Offset = "0x13BB080", VA = "0x1813BC280")]
		internal bool <GetUncollectedKeepsakeCountPerCategoryForRoom>b__2(JHAAPFBDNOG instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class OANPGODCDHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Dictionary<Guid, JHAAPFBDNOG> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public OANPGODCDHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x57E4A90", Offset = "0x57E3890", VA = "0x1857E4A90")]
		internal KeyValuePair<JHAAPFBDNOG, int> <GetTotalKeepsakeCountPerCategoryForRoom>b__1(JHAAPFBDNOG category)
		{
			return default(KeyValuePair<JHAAPFBDNOG, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class NLIDBOBCBGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public JHAAPFBDNOG category;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public NLIDBOBCBGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x13BC280", Offset = "0x13BB080", VA = "0x1813BC280")]
		internal bool <GetTotalKeepsakeCountPerCategoryForRoom>b__2(JHAAPFBDNOG instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class FFFOACBDCHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public NMONBEMMKBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public FFFOACBDCHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x57D4630", Offset = "0x57D3430", VA = "0x1857D4630")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x57D4700", Offset = "0x57D3500", VA = "0x1857D4700")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x57D4700", Offset = "0x57D3500", VA = "0x1857D4700")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class BJADANGNMIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public BJADANGNMIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1208A40", Offset = "0x1207840", VA = "0x181208A40")]
		internal bool <GetHighlightKeepsakeRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class OONKPDEJOKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public OONKPDEJOKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x57E50F0", Offset = "0x57E3EF0", VA = "0x1857E50F0")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x1382170", Offset = "0x1380F70", VA = "0x181382170")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__1(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class CICIFKGAKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public CICIFKGAKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x57D3FF0", Offset = "0x57D2DF0", VA = "0x1857D3FF0")]
		internal bool <GetKeepsakeRoomListUpsellItemPurchasableGiftDropId>b__0(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LECDBOPGEEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public LECDBOPGEEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1208A40", Offset = "0x1207840", VA = "0x181208A40")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JABLNOFHAAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public JABLNOFHAAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x57D50F0", Offset = "0x57D3EF0", VA = "0x1857D50F0")]
		internal bool <IsKeepsakeInCurrentKeepsakeCategory>b__0(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class HFJMLOOFBOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public JHAAPFBDNOG keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public HFJMLOOFBOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x138F6A0", Offset = "0x138E4A0", VA = "0x18138F6A0")]
		internal bool <TryGetNextOrphanedKeepsakeInstanceFromCategory>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class LCBGLCFPPIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public LCBGLCFPPIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x57D60E0", Offset = "0x57D4EE0", VA = "0x1857D60E0")]
		internal bool <IncrementCollectedKeepsakeCount>b__0(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class LNPJEIKBFLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public JHAAPFBDNOG keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public LNPJEIKBFLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x57D6170", Offset = "0x57D4F70", VA = "0x1857D6170")]
		internal bool <GetTotalCollectableKeepsakeCountForCategory>b__0(KeyValuePair<Guid, JHAAPFBDNOG> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class FHJBNDAHODC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public JHAAPFBDNOG newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public FHJBNDAHODC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x138F6A0", Offset = "0x138E4A0", VA = "0x18138F6A0")]
		internal bool <OnKeepsakeCollected>b__0(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class PPALIJOPIJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public PPALIJOPIJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x57E5530", Offset = "0x57E4330", VA = "0x1857E5530")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class OKLFKFNBDCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public OKLFKFNBDCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x57E4DC0", Offset = "0x57E3BC0", VA = "0x1857E4DC0")]
		internal bool <GetKeepsakeRoomIdsInList>b__0(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class IMFLBLJFNNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public OKLFKFNBDCP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public IMFLBLJFNNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x57D5070", Offset = "0x57D3E70", VA = "0x1857D5070")]
		internal bool <GetKeepsakeRoomIdsInList>b__3(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct BODFACOPCMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public NMONBEMMKBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public PBFKGFFPEEN args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x57D3A30", Offset = "0x57D2830", VA = "0x1857D3A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct OOEGOKEHKKP : IAsyncStateMachine
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
		public NMONBEMMKBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x57E4EB0", Offset = "0x57E3CB0", VA = "0x1857E4EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int HCCPKIIEKOK = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DateTime ICKPMAMAEPC;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int LMKMBBIKPGN = 3;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const long EHFHIALAJIM = -1L;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const char PIEFLADLHAE = '|';

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly EAGCBMIDCGM BNJONADDECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly FCNJOPLPDNI DBAPNDJNCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly FHIBKDDEDAN AFDCAOJMLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly FNOGEDLAEHL CFNGMHHMLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly DCKNHNPPIEN PMENMHOEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly NKCPGHAAAMH GGNMDDMNLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly HMCJICJEDFG BKBLGOGKJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly ADEJCHDMBNK PAOJHNGKONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly PHJBDNAHKIG HEGJMMGAIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly ABJKBFDIFGL MMHFALGJKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly MMLGECELHFH NPJLIOBBAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly EIGLFKFKFFK NBIENHGNEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly PHMHDMGEJBD LCAMODMHMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly LNLEIKMLLPJ KJGEPMINMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly CAEMJJLHFME FMNFHIFKELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly global::CKDEBHLDJOO<KeepsakesConfig.KeepsakesOptions> IFLCOEMLDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly DAPKKAODDPK ECEJLOGBDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> NPOEEDAPCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly HashSet<Guid> ODMPIPJBACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly HashSet<long> PHIEIKOFBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private Dictionary<JHAAPFBDNOG, int> OGGNJMJGHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<Guid> JMFIAMJLIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IDisposable IMLPPBMGEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Task DFACKNDILIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private global::OOLBMJPBBIG<Guid> OPPIOACFOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private long? BNHMIMBFMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private KeepsakeProgressionEventInstancesDTO KMLAPHPLOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private global::OOLBMJPBBIG<KeepsakeProgressionEventInstancesDTO> CBDDABAFAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private IReadOnlyDictionary<JHAAPFBDNOG, KeepsakeCategoryConfigDTO> FCHMEEFKALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private KeepsakeGlobalConfigDTO NDGEOKHNCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private HashSet<long> BLJJJJACJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private HashSet<long> MPKHFOODEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<KeepsakeRoomListDTO> ODAEAKMBHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private List<KeepsakeRoomListDTO> BKGBJDCOHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private List<KeepsakeRoomListDTO> ACGLNAJMMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Dictionary<long, string> BJCDLMGGNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<long, string> GMNJKEAGDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<long, DateTime> PCIJDGLLDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<long, List<KeepsakeRoomDTO>> BOHNOGNIKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<long, List<KeepsakeRoomDTO>> NIEGIKIPFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<long, long> CCAKOEBLPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<string> JAPOFMEHHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private DateTime ENCIEAHIDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly IDisposable AONNEJPKCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Dictionary<Guid, JHAAPFBDNOG> JINDPCAFODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Dictionary<JHAAPFBDNOG, int> DFPGGEFKEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private List<KeepsakeCategoryThemePair> JIJOFJDFJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private KDPBOILNMBG AAPJDECKCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private bool ECCFKDNNDPK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool OIFPLGPILEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x740030", Offset = "0x73EE30", VA = "0x180740030", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA94EC0", Offset = "0xA93CC0", VA = "0x180A94EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BACPBEMFOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x57D7050", Offset = "0x57D5E50", VA = "0x1857D7050", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MHMOKEALFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x57D6920", Offset = "0x57D5720", VA = "0x1857D6920", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long BELGEIDHCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x57E23D0", Offset = "0x57E11D0", VA = "0x1857E23D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? OLBEHJLFEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x57DEC20", Offset = "0x57DDA20", VA = "0x1857DEC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool MDDMLIKGLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x57E09E0", Offset = "0x57DF7E0", VA = "0x1857E09E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> ICACOOGKKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xB4FD20", Offset = "0xB4EB20", VA = "0x180B4FD20", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> PKCMHKGDALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xB4FD30", Offset = "0xB4EB30", VA = "0x180B4FD30", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> LKNNNAMAFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB4FCE0", Offset = "0xB4EAE0", VA = "0x180B4FCE0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> EMKOCNNPPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xE3D4A0", Offset = "0xE3C2A0", VA = "0x180E3D4A0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> OJKHBKBIHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xD3A4D0", Offset = "0xD392D0", VA = "0x180D3A4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal bool DCGBJJAIHEI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x15A8A70", Offset = "0x15A7870", VA = "0x1815A8A70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x57E1CA0", Offset = "0x57E0AA0", VA = "0x1857E1CA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> IEJHCBJNOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x57E2870", Offset = "0x57E1670", VA = "0x1857E2870", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x57DFFF0", Offset = "0x57DEDF0", VA = "0x1857DFFF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action AEDCJAOOCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x57DFBC0", Offset = "0x57DE9C0", VA = "0x1857DFBC0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x57D9B40", Offset = "0x57D8940", VA = "0x1857D9B40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action AACODNKIBHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x57D6FB0", Offset = "0x57D5DB0", VA = "0x1857D6FB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x57DC110", Offset = "0x57DAF10", VA = "0x1857DC110", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x57E37B0", Offset = "0x57E25B0", VA = "0x1857E37B0")]
	[Preserve]
	internal NMONBEMMKBD([NotNull][HDMGOABMPFL(null)] EAGCBMIDCGM BNJONADDECK, [NotNull][HDMGOABMPFL(null)] MLCGPPCAKHJ NKIACAODLIB, [NotNull][HDMGOABMPFL(null)] FCNJOPLPDNI DBAPNDJNCKN, [NotNull][HDMGOABMPFL(null)] FHIBKDDEDAN AFDCAOJMLOE, [NotNull][HDMGOABMPFL(null)] FNOGEDLAEHL CFNGMHHMLCM, [NotNull][HDMGOABMPFL(null)] DCKNHNPPIEN PMENMHOEOKK, [NotNull][HDMGOABMPFL(null)] NKCPGHAAAMH GGNMDDMNLAH, [NotNull][HDMGOABMPFL(null)] HMCJICJEDFG BKBLGOGKJCJ, [NotNull][HDMGOABMPFL(null)] ADEJCHDMBNK PAOJHNGKONI, [NotNull][HDMGOABMPFL(null)] CLHIBMKHEGC GMNHLAKFBPJ, [NotNull][HDMGOABMPFL(null)] PHJBDNAHKIG HEGJMMGAIOD, [NotNull][HDMGOABMPFL(null)] ABJKBFDIFGL MMHFALGJKEB, [NotNull][HDMGOABMPFL(null)] MMLGECELHFH NPJLIOBBAGC, [NotNull][HDMGOABMPFL(null)] EIGLFKFKFFK NBIENHGNEAL, [NotNull][HDMGOABMPFL(null)] PHMHDMGEJBD LCAMODMHMDG, [NotNull][HDMGOABMPFL(null)] LNLEIKMLLPJ KJGEPMINMNI, [NotNull][HDMGOABMPFL(null)] CAEMJJLHFME FMNFHIFKELP, [NotNull][HDMGOABMPFL(null)] global::CKDEBHLDJOO<KeepsakesConfig.KeepsakesOptions> IFLCOEMLDOM, [NotNull][HDMGOABMPFL(null)] DAPKKAODDPK ECEJLOGBDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x57E20C0", Offset = "0x57E0EC0", VA = "0x1857E20C0", Slot = "15")]
	public bool MOIKAMEBPFG(List<string> OALEMGOCFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x57E00E0", Offset = "0x57DEEE0", VA = "0x1857E00E0", Slot = "16")]
	public global::OOLBMJPBBIG<Guid> KKELJNHHDEA(JHAAPFBDNOG LFNDIBOEPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x57DA590", Offset = "0x57D9390", VA = "0x1857DA590", Slot = "17")]
	public PONAFBMJJFC EOEPMPKCGLD(Guid PGDCMKGLNJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x57DA200", Offset = "0x57D9000", VA = "0x1857DA200", Slot = "18")]
	public PONAFBMJJFC EIHFJDNHADD(Guid PGDCMKGLNJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x57D9BE0", Offset = "0x57D89E0", VA = "0x1857D9BE0", Slot = "19")]
	public bool ECFLCEHKMLE(Guid PGDCMKGLNJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x57E1B00", Offset = "0x57E0900", VA = "0x1857E1B00", Slot = "20")]
	public bool MAAJHHOEKOM(Guid PGDCMKGLNJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x57E2C30", Offset = "0x57E1A30", VA = "0x1857E2C30")]
	public KeepsakeTheme NOGKMJDJBCL(Guid PGDCMKGLNJL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x57DB000", Offset = "0x57D9E00", VA = "0x1857DB000")]
	public bool FFIBHLCMMMC(JHAAPFBDNOG LFNDIBOEPAC, out KeepsakeTheme LLJCBENAFBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x57D9330", Offset = "0x57D8130", VA = "0x1857D9330")]
	public List<KeepsakeTheme> DMCCOHILAIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x57DEA50", Offset = "0x57DD850", VA = "0x1857DEA50")]
	public int ICBBMGAKBJJ(JHAAPFBDNOG LFNDIBOEPAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x57DBFA0", Offset = "0x57DADA0", VA = "0x1857DBFA0")]
	public JHAAPFBDNOG FNNEAOGIOHH(Guid PGDCMKGLNJL)
	{
		return default(JHAAPFBDNOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x57DF1B0", Offset = "0x57DDFB0", VA = "0x1857DF1B0", Slot = "34")]
	public List<JHAAPFBDNOG> JBPPJGCGEDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x57D72C0", Offset = "0x57D60C0", VA = "0x1857D72C0", Slot = "35")]
	public IComparer<JHAAPFBDNOG> BIEPALPIEJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x57D7150", Offset = "0x57D5F50", VA = "0x1857D7150", Slot = "32")]
	public string BHPOCPGLJMC(JHAAPFBDNOG LFNDIBOEPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x57D8AC0", Offset = "0x57D78C0", VA = "0x1857D8AC0", Slot = "33")]
	public string DIKMBNEJAIF(JHAAPFBDNOG LFNDIBOEPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x57D7FC0", Offset = "0x57D6DC0", VA = "0x1857D7FC0", Slot = "21")]
	public bool CJEKBCIIEEE(Guid PGDCMKGLNJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x57E2780", Offset = "0x57E1580", VA = "0x1857E2780", Slot = "22")]
	public void NDKEBALBHLA(Guid PGDCMKGLNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x57E35C0", Offset = "0x57E23C0", VA = "0x1857E35C0", Slot = "23")]
	public void PKEKNDNEOAE(JHAAPFBDNOG LFNDIBOEPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x57E2F20", Offset = "0x57E1D20", VA = "0x1857E2F20", Slot = "24")]
	public void OKDNBOJIGBE(Guid PGDCMKGLNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x57E09F0", Offset = "0x57DF7F0", VA = "0x1857E09F0", Slot = "25")]
	public int KODOCMHGMDJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x57E0E40", Offset = "0x57DFC40", VA = "0x1857E0E40", Slot = "54")]
	public int KODOCMHGMDJ(JHAAPFBDNOG LFNDIBOEPAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x57D9D20", Offset = "0x57D8B20", VA = "0x1857D9D20", Slot = "31")]
	public global::OOLBMJPBBIG<IEnumerable<Guid>> EEEIOOKHPLF(long GJDNMGJBIPD, long IHEMHLGHIIK, JHAAPFBDNOG? LFNDIBOEPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x57E0720", Offset = "0x57DF520", VA = "0x1857E0720", Slot = "30")]
	public global::OOLBMJPBBIG<IEnumerable<Guid>> KLMEJFKFEAF(long GJDNMGJBIPD, long IHEMHLGHIIK, JHAAPFBDNOG? LFNDIBOEPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x57DC210", Offset = "0x57DB010", VA = "0x1857DC210", Slot = "55")]
	public global::OOLBMJPBBIG<Dictionary<Guid, JHAAPFBDNOG>> GDOFNLIODIE(long GJDNMGJBIPD, long IHEMHLGHIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x57D6790", Offset = "0x57D5590", VA = "0x1857D6790", Slot = "56")]
	public global::OOLBMJPBBIG<Dictionary<Guid, JHAAPFBDNOG>> ABDPHCDMFHO(long GJDNMGJBIPD, long IHEMHLGHIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x57DB1D0", Offset = "0x57D9FD0", VA = "0x1857DB1D0", Slot = "26")]
	public global::OOLBMJPBBIG<int> FGHOKOMBJMF(long GJDNMGJBIPD, long IHEMHLGHIIK, JHAAPFBDNOG? LFNDIBOEPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x57E1D10", Offset = "0x57E0B10", VA = "0x1857E1D10", Slot = "27")]
	public global::OOLBMJPBBIG<int> MFFJJHOOJPD(long GJDNMGJBIPD, long IHEMHLGHIIK, JHAAPFBDNOG? LFNDIBOEPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x57E1EA0", Offset = "0x57E0CA0", VA = "0x1857E1EA0", Slot = "28")]
	public global::OOLBMJPBBIG<Dictionary<JHAAPFBDNOG, int>> MNHBGJGHLOM(long GJDNMGJBIPD, long IHEMHLGHIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x57D8970", Offset = "0x57D7770", VA = "0x1857D8970", Slot = "29")]
	public global::OOLBMJPBBIG<Dictionary<JHAAPFBDNOG, int>> DFOOMCFAOKB(long GJDNMGJBIPD, long IHEMHLGHIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x57DEBC0", Offset = "0x57DD9C0", VA = "0x1857DEBC0", Slot = "37")]
	public bool IDDDNGOPIEC(long GJDNMGJBIPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x57E3750", Offset = "0x57E2550", VA = "0x1857E3750", Slot = "57")]
	public bool PNFIPIIBMOK(long GJDNMGJBIPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x57E3160", Offset = "0x57E1F60", VA = "0x1857E3160", Slot = "38")]
	public bool PGJJIADAFNI(long GJDNMGJBIPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x57DB480", Offset = "0x57DA280", VA = "0x1857DB480", Slot = "58")]
	public bool FICDKOHKIFC(long GJDNMGJBIPD, out AAOOHAPONFN IOGOELKIPNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x57E3600", Offset = "0x57E2400", VA = "0x1857E3600", Slot = "39")]
	public bool PKPLAGIPOAC(long EEDCFAKJGAB, out DateTime HMDEFDDFNJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x57DCE60", Offset = "0x57DBC60", VA = "0x1857DCE60", Slot = "40")]
	public long GPHKCJMFDJN(long EEDCFAKJGAB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x57D6D00", Offset = "0x57D5B00", VA = "0x1857D6D00", Slot = "59")]
	public IEnumerable<int> APKPFJHNCCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x57E08C0", Offset = "0x57DF6C0", VA = "0x1857E08C0", Slot = "41")]
	public long KLNLNFMGOIB(long GJDNMGJBIPD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x57DF8D0", Offset = "0x57DE6D0", VA = "0x1857DF8D0", Slot = "42")]
	public int JLGFDNCMDPN(long EEDCFAKJGAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x57E2690", Offset = "0x57E1490", VA = "0x1857E2690", Slot = "43")]
	public bool NDHLBDNKDLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x57DB840", Offset = "0x57DA640", VA = "0x1857DB840", Slot = "44")]
	public bool FJOFDIOPJGF(long EEDCFAKJGAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x57D8400", Offset = "0x57D7200", VA = "0x1857D8400", Slot = "45")]
	public IEnumerable<long> DCNKDJEJLLH(long EEDCFAKJGAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x57D70A0", Offset = "0x57D5EA0", VA = "0x1857D70A0", Slot = "46")]
	public int BFNBBPBKBIG(long EEDCFAKJGAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x57D79B0", Offset = "0x57D67B0", VA = "0x1857D79B0", Slot = "50")]
	public long BNKAGOHCPAE(long KHANNPILMEJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x57DAC50", Offset = "0x57D9A50", VA = "0x1857DAC50", Slot = "51")]
	public JHAAPFBDNOG FCEMBGNJJEO()
	{
		return default(JHAAPFBDNOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x57D6BC0", Offset = "0x57D59C0", VA = "0x1857D6BC0")]
	private bool AEPBCGELNIK(Guid PGDCMKGLNJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x57DBB00", Offset = "0x57DA900", VA = "0x1857DBB00")]
	private void FNJKEMANDNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x57E1810", Offset = "0x57E0610", VA = "0x1857E1810")]
	private JHAAPFBDNOG LMIJAOMHLDD()
	{
		return default(JHAAPFBDNOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x57D8C30", Offset = "0x57D7A30", VA = "0x1857D8C30")]
	private void DKKGPJDMBAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x57DF000", Offset = "0x57DDE00", VA = "0x1857DF000")]
	private int IPLIBKGNOLD(KeepsakeRoomListDTO EBDNCJPCFJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x57DA130", Offset = "0x57D8F30", VA = "0x1857DA130")]
	private int EFOJILLBKKJ(DateTime GFBPLBKIDJB, DateTime FKENPIEFGIK, TimeSpan KNKLFFFIFEB, int BIPCGBBCODH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x57DF6C0", Offset = "0x57DE4C0", VA = "0x1857DF6C0")]
	private void JKOFDNGIDAH(IEnumerable<KeepsakeInstanceDTO> NPOEEDAPCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x57DF300", Offset = "0x57DE100", VA = "0x1857DF300")]
	private void JEDLBEAACEN(IEnumerable<KeepsakeCollectionRecordDTO> AMDLNABALCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x57D9680", Offset = "0x57D8480", VA = "0x1857D9680")]
	private void DOALNMBIOKA(IEnumerable<long> HMBCNDLPLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1763910", Offset = "0x1762710", VA = "0x181763910")]
	private void PHKPBGCGIAM(KeepsakeGlobalConfigDTO NDGEOKHNCOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x57E13C0", Offset = "0x57E01C0", VA = "0x1857E13C0")]
	private bool LIJPKEJFGAO(JHAAPFBDNOG LFNDIBOEPAC, out Guid GONEGOKEAAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x57DD630", Offset = "0x57DC430", VA = "0x1857DD630")]
	private bool HAKFBBCDHLF(out Guid GONEGOKEAAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x57DC1B0", Offset = "0x57DAFB0", VA = "0x1857DC1B0")]
	private bool GABCMIIFHKD(Guid PGDCMKGLNJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x57DECB0", Offset = "0x57DDAB0", VA = "0x1857DECB0")]
	private IEnumerable<Guid> ILAOPCENGIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x57D7EF0", Offset = "0x57D6CF0", VA = "0x1857D7EF0")]
	private IEnumerable<KeepsakeInstanceDTO> CIHJHCFIFLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x57DCCD0", Offset = "0x57DBAD0", VA = "0x1857DCCD0")]
	private void GLFNENMDGLL(Guid PGDCMKGLNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x57E2E70", Offset = "0x57E1C70", VA = "0x1857E2E70")]
	private bool OINOHJFMMCN(Guid PGDCMKGLNJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x57D8260", Offset = "0x57D7060", VA = "0x1857D8260")]
	private void CPBHLDHMJPE(Guid PGDCMKGLNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x57DEF20", Offset = "0x57DDD20", VA = "0x1857DEF20")]
	private void IOMDOKDEKHJ(JHAAPFBDNOG MAHJICNDKND, int IAJFCILFPNL, ref Dictionary<JHAAPFBDNOG, int> CMACDGBFJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x57DCD60", Offset = "0x57DBB60", VA = "0x1857DCD60")]
	private int GONHIDDABNG(JHAAPFBDNOG LFNDIBOEPAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x57E24B0", Offset = "0x57E12B0", VA = "0x1857E24B0")]
	private void MOPOFDLPNBE(KeepsakeInstanceDTO NKEGHIODCNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x57D7CF0", Offset = "0x57D6AF0", VA = "0x1857D7CF0")]
	private void CHIJMPPAAFB(KeepsakeInstanceDTO NKEGHIODCNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x57DD290", Offset = "0x57DC090", VA = "0x1857DD290")]
	private void HABHEHDEMFM(Guid PGDCMKGLNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x57D85E0", Offset = "0x57D73E0", VA = "0x1857D85E0")]
	private void DDMOAEEOGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x57E2670", Offset = "0x57E1470", VA = "0x1857E2670")]
	private void NBABBDOHAAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x57D8640", Offset = "0x57D7440", VA = "0x1857D8640")]
	private void DDOLLHPHKID(MCEKIAOMMJF LIBNHJGGHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x57D6F50", Offset = "0x57D5D50", VA = "0x1857D6F50")]
	private void BCHGOEJFEFJ(IMJOKBMHMJL.FCHAPEPCEHA OJGAEOFIMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x57E2D70", Offset = "0x57E1B70", VA = "0x1857E2D70")]
	private void OGKIBHNGJHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x57E3200", Offset = "0x57E2000", VA = "0x1857E3200")]
	private void PGMPMCOANAE(float OHABENNKGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x57D7440", Offset = "0x57D6240", VA = "0x1857D7440")]
	private void BLJBFFFIJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x57DD700", Offset = "0x57DC500", VA = "0x1857DD700")]
	private bool HBBADJLAMEC(Guid PGDCMKGLNJL, out string HEFMEDJJMDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x57E2910", Offset = "0x57E1710", VA = "0x1857E2910")]
	private bool NMDPCJGLHOP(Guid PGDCMKGLNJL, out KeepsakeCategoryConfigDTO MAHJICNDKND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x57D7360", Offset = "0x57D6160", VA = "0x1857D7360")]
	private void BKNJKPNENDI(string FNGOIPCGDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x57DEE10", Offset = "0x57DDC10", VA = "0x1857DEE10")]
	private bool IMGHLPFLAGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x57DD900", Offset = "0x57DC700", VA = "0x1857DD900")]
	private IEnumerable<long> HBLOIJNJAAO(IEnumerable<KeepsakeRoomDTO> KCMLNJHJKDP, IEnumerable<KeepsakeRoomListDTO> LLOFPFEACJL, long EEDCFAKJGAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x57DC7A0", Offset = "0x57DB5A0", VA = "0x1857DC7A0")]
	private bool GKKNHBGNHJM(Guid PGDCMKGLNJL, out string DOIPIGHENCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x57E1B30", Offset = "0x57E0930", VA = "0x1857E1B30", Slot = "47")]
	public string MAKCOEKKDNA(DDGBENLIFAA NJPFEJKAJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x57DA810", Offset = "0x57D9610", VA = "0x1857DA810", Slot = "49")]
	public string FAPEDFBGOII(DDGBENLIFAA NJPFEJKAJPI, long GJDNMGJBIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x57DDBE0", Offset = "0x57DC9E0", VA = "0x1857DDBE0", Slot = "48")]
	public string HIICOIOHDEF(DDGBENLIFAA NJPFEJKAJPI, int GPIHLDMPDBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x57DDD00", Offset = "0x57DCB00", VA = "0x1857DDD00")]
	private void HLBCFLGBDOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x57D86B0", Offset = "0x57D74B0", VA = "0x1857D86B0")]
	private void DFGKFLKLJJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x57E13A0", Offset = "0x57E01A0", VA = "0x1857E13A0")]
	private DDGBENLIFAA LHINNCBAJAI(KMLAJEKFFBE JLCADFMMOAD)
	{
		return default(DDGBENLIFAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x57E1E80", Offset = "0x57E0C80", VA = "0x1857E1E80")]
	private DDGBENLIFAA MIHBMFOOFCK(KMLAJEKFFBE JLCADFMMOAD)
	{
		return default(DDGBENLIFAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x57D69E0", Offset = "0x57D57E0", VA = "0x1857D69E0")]
	internal static string AEEJMHDADFP(ILMBEKKHLKE FBLMHHGAGOK, string LAIDKEOFKGM, bool DJFECFPPKDK, int JBIFOBLMECP, int PMICJPFNJKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x57D96E0", Offset = "0x57D84E0", VA = "0x1857D96E0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x57D8A40", Offset = "0x57D7840", VA = "0x1857D8A40")]
	private CMMKJOOIFOH DGEAGLGLGMK(ECDFOCMBGHG AMHALGEOEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x57E1670", Offset = "0x57E0470", VA = "0x1857E1670")]
	private IONJGNDKGMO LKJHMHGHEMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x57DFC60", Offset = "0x57DEA60", VA = "0x1857DFC60")]
	private Task KGCGMMMAHAJ(PBFKGFFPEEN CFGJGLPAHFD, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x57D91E0", Offset = "0x57D7FE0", VA = "0x1857D91E0")]
	[AsyncStateMachine(typeof(BODFACOPCMJ))]
	private Task DLHFMAEIAHB(PBFKGFFPEEN CFGJGLPAHFD, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x57E2DD0", Offset = "0x57E1BD0", VA = "0x1857E2DD0")]
	private Task OIDCFIJBIKP(PBFKGFFPEEN CFGJGLPAHFD, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x57E2AE0", Offset = "0x57E18E0", VA = "0x1857E2AE0")]
	[AsyncStateMachine(typeof(OOEGOKEHKKP))]
	private Task NMEPMILDLAH(string GPAOLHFLBHD, TimeSpan COLELLDDDBO, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x482E3C0", Offset = "0x482D1C0", VA = "0x18482E3C0")]
	[CompilerGenerated]
	private void PMLGALGOOOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x57E0090", Offset = "0x57DEE90", VA = "0x1857E0090")]
	[CompilerGenerated]
	private void KHJALAGIPAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x57DFAD0", Offset = "0x57DE8D0", VA = "0x1857DFAD0")]
	[CompilerGenerated]
	private bool KAONLMIALKF(KeepsakeInstanceDTO NHKCICGBPMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x57DC620", Offset = "0x57DB420", VA = "0x1857DC620")]
	[CompilerGenerated]
	private global::OOLBMJPBBIG<Dictionary<JHAAPFBDNOG, int>> GGDKHMPJACE(Dictionary<Guid, JHAAPFBDNOG> NLNGHABOGKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x57D87F0", Offset = "0x57D75F0", VA = "0x1857D87F0")]
	[CompilerGenerated]
	private global::OOLBMJPBBIG<Dictionary<JHAAPFBDNOG, int>> DFJKKJEOJBE(Dictionary<Guid, JHAAPFBDNOG> NLNGHABOGKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x57E27F0", Offset = "0x57E15F0", VA = "0x1857E27F0")]
	[CompilerGenerated]
	private bool NFDCEJHBIJG(KeepsakeRoomListDTO NHKCICGBPMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x57E1B90", Offset = "0x57E0990", VA = "0x1857E1B90")]
	[CompilerGenerated]
	private bool MCOKBEPOJNL(KeepsakeInstanceDTO NHKCICGBPMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x57DF540", Offset = "0x57DE340", VA = "0x1857DF540")]
	[CompilerGenerated]
	private void JHJDJBEOMJF(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<JHAAPFBDNOG, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> KAJIIHFNHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x57E2810", Offset = "0x57E1610", VA = "0x1857E2810")]
	[CompilerGenerated]
	private void NFDJPOJFOKC(string DOIPIGHENCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x57E11B0", Offset = "0x57DFFB0", VA = "0x1857E11B0")]
	[CompilerGenerated]
	private Task LDKNOJAOKFJ(CancellationToken OGKCDPMAHMI)
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
	public class KeepsakesConfig : ScriptableObject, global::CKDEBHLDJOO<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002F")]
			[CompilerGenerated]
			private sealed class JJDBDAGCCLM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
				public JJDBDAGCCLM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x57D5180", Offset = "0x57D3F80", VA = "0x1857D5180")]
				internal bool <TryGetKeepsakeTheme>b__0(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x57D5180", Offset = "0x57D3F80", VA = "0x1857D5180")]
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
			[Cpp2IlInjected.Address(RVA = "0x740F40", Offset = "0x73FD40", VA = "0x180740F40")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] KDPCAIMPPJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x57D5F10", Offset = "0x57D4D10", VA = "0x1857D5F10")]
			public bool HEPBBJIENIB(string DOALNJCLMJO, out KeepsakeTheme LLJCBENAFBK)
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
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x57D5E90", Offset = "0x57D4C90", VA = "0x1857D5E90")]
		[CFDOMFEMHNO(ANAFFCEINAM.GameOnly)]
		private static void PEBFIEIHMDK(GMLHNNIDAIC IPJNDIBMKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xE8B1B0", Offset = "0xE89FB0", VA = "0x180E8B1B0")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class KBGNMEAALAF
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static byte[] JDPEKMLOAPL;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static int KHIOPMNKDNJ;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static int FJCGIOGMELC;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static BigInteger BOMEHIKGKLG;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KBGNMEAALAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x57D5500", Offset = "0x57D4300", VA = "0x1857D5500")]
	private static string PKFOMDHOGCM(byte[] EJKHFJILHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x57D51B0", Offset = "0x57D3FB0", VA = "0x1857D51B0")]
	public static string GMEGIIKFFNC(byte[] EMGPHLLIACG, bool PHHFDNEANIF)
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
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
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
