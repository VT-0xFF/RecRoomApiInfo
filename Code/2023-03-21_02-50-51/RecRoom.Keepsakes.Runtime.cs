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
public class FBAGOKPOCJE : IComparer<HMECHOKOCBB>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class AMMGLILHIEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public HMECHOKOCBB x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public HMECHOKOCBB y;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public AMMGLILHIEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x120CAE0", Offset = "0x120B2E0", VA = "0x18120CAE0")]
		internal bool <Compare>b__0(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xF40D80", Offset = "0xF3F580", VA = "0x180F40D80")]
		internal bool <Compare>b__1(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x120CAE0", Offset = "0x120B2E0", VA = "0x18120CAE0")]
		internal bool <Compare>b__2(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xF40D80", Offset = "0xF3F580", VA = "0x180F40D80")]
		internal bool <Compare>b__3(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> NAJAIBDBGHP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F40", Offset = "0x6D4740", VA = "0x1806D5F40")]
	public FBAGOKPOCJE(List<KeepsakeCategoryThemePair> AOHGDLMJPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5530A20", Offset = "0x552F220", VA = "0x185530A20", Slot = "4")]
	public int Compare(HMECHOKOCBB NGMFABJMIHP, HMECHOKOCBB OMDBFFDAOFA)
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
		public HMECHOKOCBB KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum AMNMHFHICFE
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[JKEBBOLEEMC]
public class PDFJLLECNBE : HNDFNMJHEPM, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct EHGELGOGMPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string CLNCGIKPJGG = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public const string MEMLODOLDLE = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public const string EBKMMANCFDE = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public const string OFMKLKADDLP = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public const string LCMHJKNFECM = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public const string OCEPPFHIGHM = "You have to collect other keepsakes before you can collect this one.";

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public const string OJDJBFNJPOP = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string CFKDDNDAOBM = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public const string LBICJLABLBE = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const string NLEMCDFAENN = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public const string PCIPFJMOBNL = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public const string DNNMFDHKAPF = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class HHCNCECFDBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public PDFJLLECNBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public HMECHOKOCBB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public HHCNCECFDBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5531590", Offset = "0x552FD90", VA = "0x185531590")]
		internal void <CreateKeepsakeInstanceData>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x55312A0", Offset = "0x552FAA0", VA = "0x1855312A0")]
		internal void <CreateKeepsakeInstanceData>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HJIBPCBHHKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public PDFJLLECNBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public HJIBPCBHHKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5531620", Offset = "0x552FE20", VA = "0x185531620")]
		internal void <DeleteKeepsakeInstanceData>b__0()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5531800", Offset = "0x5530000", VA = "0x185531800")]
		internal void <DeleteKeepsakeInstanceData>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class LKIPMJFEAFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PDFJLLECNBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int collectedKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int uncollectedKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public LKIPMJFEAFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5531F10", Offset = "0x5530710", VA = "0x185531F10")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CJGHJOIFEAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public CJGHJOIFEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x55301F0", Offset = "0x552E9F0", VA = "0x1855301F0")]
		internal bool <GetKeepsakeCategory>b__0(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class PFAIBKGCFFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public PDFJLLECNBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public HMECHOKOCBB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public PFAIBKGCFFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x55408D0", Offset = "0x553F0D0", VA = "0x1855408D0")]
		internal bool <GetRemainingKeepsakeViewQuantityForCurrentRoom>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EKAKKJKLJMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public PDFJLLECNBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public HMECHOKOCBB? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public EKAKKJKLJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5530590", Offset = "0x552ED90", VA = "0x185530590")]
		internal void <GetAllKeepsakeInstanceIdsForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5530620", Offset = "0x552EE20", VA = "0x185530620")]
		internal void <GetAllKeepsakeInstanceIdsForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5530650", Offset = "0x552EE50", VA = "0x185530650")]
		internal global::FGLDKEJLAKB<IEnumerable<Guid>> <GetAllKeepsakeInstanceIdsForRoom>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5530960", Offset = "0x552F160", VA = "0x185530960")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GAOBDJJLFGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public EKAKKJKLJMN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public GAOBDJJLFGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5530CC0", Offset = "0x552F4C0", VA = "0x185530CC0")]
		internal global::FGLDKEJLAKB<IEnumerable<Guid>> <GetAllKeepsakeInstanceIdsForRoom>b__4(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class IGLLDNMDHIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public GAOBDJJLFGI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public IGLLDNMDHIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5531860", Offset = "0x5530060", VA = "0x185531860")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__5(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class BNGAHPGKOKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public IGLLDNMDHIA CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public BNGAHPGKOKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x552FD00", Offset = "0x552E500", VA = "0x18552FD00")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__6(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class CEDIEJEDDNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public PDFJLLECNBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public CEDIEJEDDNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x552FFC0", Offset = "0x552E7C0", VA = "0x18552FFC0")]
		internal global::FGLDKEJLAKB<IEnumerable<Guid>> <GetUncollectedKeepsakeInstanceIdsForRoom>b__0(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E221B0", Offset = "0x3E209B0", VA = "0x183E221B0")]
		internal bool <GetUncollectedKeepsakeInstanceIdsForRoom>b__1(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class MMNMDBFCGGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public PDFJLLECNBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public MMNMDBFCGGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5532520", Offset = "0x5530D20", VA = "0x185532520")]
		internal void <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5530620", Offset = "0x552EE20", VA = "0x185530620")]
		internal void <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x55325B0", Offset = "0x5530DB0", VA = "0x1855325B0")]
		internal global::FGLDKEJLAKB<Dictionary<Guid, HMECHOKOCBB>> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5530960", Offset = "0x552F160", VA = "0x185530960")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class CDJIPMDFEKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public CDJIPMDFEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x552FDF0", Offset = "0x552E5F0", VA = "0x18552FDF0")]
		internal global::FGLDKEJLAKB<Dictionary<Guid, HMECHOKOCBB>> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__4(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class PKJLKHIBEOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public PKJLKHIBEOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5540A00", Offset = "0x553F200", VA = "0x185540A00")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__5(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5540AF0", Offset = "0x553F2F0", VA = "0x185540AF0")]
		internal KeyValuePair<Guid, HMECHOKOCBB> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__6(Guid instanceId)
		{
			return default(KeyValuePair<Guid, HMECHOKOCBB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class EPHFMMPLCNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public EPHFMMPLCNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5530980", Offset = "0x552F180", VA = "0x185530980")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__7(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class DONHLHDFODN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public DONHLHDFODN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5530220", Offset = "0x552EA20", VA = "0x185530220")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__8(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class BEFBFCBBAHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public PDFJLLECNBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public BEFBFCBBAHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x552FAE0", Offset = "0x552E2E0", VA = "0x18552FAE0")]
		internal global::FGLDKEJLAKB<Dictionary<Guid, HMECHOKOCBB>> <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__0(Dictionary<Guid, HMECHOKOCBB> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3E221B0", Offset = "0x3E209B0", VA = "0x183E221B0")]
		internal bool <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__1(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class JMKGDOJOPOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public JMKGDOJOPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5531A10", Offset = "0x5530210", VA = "0x185531A10")]
		internal bool <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__2(KeyValuePair<Guid, HMECHOKOCBB> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class NPBBCONBFCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Dictionary<Guid, HMECHOKOCBB> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public NPBBCONBFCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x55328C0", Offset = "0x55310C0", VA = "0x1855328C0")]
		internal KeyValuePair<HMECHOKOCBB, int> <GetUncollectedKeepsakeCountPerCategoryForRoom>b__1(HMECHOKOCBB category)
		{
			return default(KeyValuePair<HMECHOKOCBB, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class MJLNFBBGBDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public HMECHOKOCBB category;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public MJLNFBBGBDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1B1DA60", Offset = "0x1B1C260", VA = "0x181B1DA60")]
		internal bool <GetUncollectedKeepsakeCountPerCategoryForRoom>b__2(HMECHOKOCBB instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class MBLBLILCFPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Dictionary<Guid, HMECHOKOCBB> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public MBLBLILCFPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5532320", Offset = "0x5530B20", VA = "0x185532320")]
		internal KeyValuePair<HMECHOKOCBB, int> <GetTotalKeepsakeCountPerCategoryForRoom>b__1(HMECHOKOCBB category)
		{
			return default(KeyValuePair<HMECHOKOCBB, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class EDMLODHLGLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public HMECHOKOCBB category;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public EDMLODHLGLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1B1DA60", Offset = "0x1B1C260", VA = "0x181B1DA60")]
		internal bool <GetTotalKeepsakeCountPerCategoryForRoom>b__2(HMECHOKOCBB instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class OMMFKNGBNNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public PDFJLLECNBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public OMMFKNGBNNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5532A20", Offset = "0x5531220", VA = "0x185532A20")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5532AF0", Offset = "0x55312F0", VA = "0x185532AF0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5532AF0", Offset = "0x55312F0", VA = "0x185532AF0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class HABONMNCBLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public HABONMNCBLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xF45500", Offset = "0xF43D00", VA = "0x180F45500")]
		internal bool <GetHighlightKeepsakeRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class LCFKDCIAOCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public LCFKDCIAOCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5531DD0", Offset = "0x55305D0", VA = "0x185531DD0")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x1447660", Offset = "0x1445E60", VA = "0x181447660")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__1(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LHGDCJDEECJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public LHGDCJDEECJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5531EA0", Offset = "0x55306A0", VA = "0x185531EA0")]
		internal bool <GetKeepsakeRoomListUpsellItemPurchasableGiftDropId>b__0(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class PAMHBCGDADC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public PAMHBCGDADC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xF45500", Offset = "0xF43D00", VA = "0x180F45500")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class EGJJCGLFGDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public EGJJCGLFGDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x55302C0", Offset = "0x552EAC0", VA = "0x1855302C0")]
		internal bool <IsKeepsakeInCurrentKeepsakeCategory>b__0(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class AFIHGJBEFCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public AFIHGJBEFCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x552FA40", Offset = "0x552E240", VA = "0x18552FA40")]
		internal bool <TryGetNextOrphanedKeepsakeInstance>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class CEDKEALCFDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public CEDKEALCFDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5530160", Offset = "0x552E960", VA = "0x185530160")]
		internal bool <IncrementCollectedKeepsakeCount>b__0(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class IDJNBGMKDGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public HMECHOKOCBB newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public IDJNBGMKDGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x13BE3D0", Offset = "0x13BCBD0", VA = "0x1813BE3D0")]
		internal bool <OnKeepsakeCollected>b__0(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class MBOKPGBFPDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public MBOKPGBFPDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5532480", Offset = "0x5530C80", VA = "0x185532480")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class KKBHINFIPPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public KKBHINFIPPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5531A90", Offset = "0x5530290", VA = "0x185531A90")]
		internal bool <GetKeepsakeRoomIdsInList>b__0(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class JIFJHBMAIJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public KKBHINFIPPI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public JIFJHBMAIJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5531990", Offset = "0x5530190", VA = "0x185531990")]
		internal bool <GetKeepsakeRoomIdsInList>b__3(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct HBIBGBJEKHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public PDFJLLECNBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public LNCJNEHCLGE args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5530E10", Offset = "0x552F610", VA = "0x185530E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6DD320", Offset = "0x6DBB20", VA = "0x1806DD320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct EIBKDGKLDAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public PDFJLLECNBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5530350", Offset = "0x552EB50", VA = "0x185530350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6DD320", Offset = "0x6DBB20", VA = "0x1806DD320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int BNDOAFJOGME = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DateTime CKDFBNBNEIF;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int FINDCLOPFJD = 3;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const long DOHNFLCLBJE = -1L;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const char BAMJMODPIJI = '|';

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly GBMHCJICALM DLLIHMOLLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly PHMPGJPCEDF ODHEAOMLHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly FLMDALDIMOK JBOPHEONPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly EEOBFBBKMOJ OMOBIIDEMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly BMDJCKFDFNK PPDKANNMDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly INJHHPOOMKB BMCHMDOOEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IKAPBHIPIGI AJKJGDPJDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IHNBKMAGABN AKIKINCCOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly JGKAOGLAAHN ODACFNMJONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly APPMNNLCBKD JCBIJHLIPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly BAOBFGEFPGE BMIHHMANFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly AGOLALPNOBE NKPHFJOANAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly DKAHMDAKGPH DPKFNIFGLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CJHMHMDOJHJ LMENJFALMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly KCGMHNBBENK APKCPEOPEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly global::PGNLJPMPPLN<KeepsakesConfig.KeepsakesOptions> LBOENCNHHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly BDKABIKNKDN NELEHDKKLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> AEGDEEFKFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly HashSet<Guid> PPAPMMOMGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly HashSet<long> KGLIEMGDLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private Dictionary<HMECHOKOCBB, int> KGNDDLOBNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<Guid> MGLKOKCLOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IDisposable EPFDOANGKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Task LHCEHOEBLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private long? LCJBEPNNFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private KeepsakeProgressionEventInstancesDTO AKOAKBCDCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private global::FGLDKEJLAKB<KeepsakeProgressionEventInstancesDTO> ABLGIALPFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private IReadOnlyDictionary<HMECHOKOCBB, KeepsakeCategoryConfigDTO> OACDEAPBOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private KeepsakeGlobalConfigDTO PLOBEPELMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private HashSet<long> EMFPHIEOEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private HashSet<long> LPGBBNLJILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private List<KeepsakeRoomListDTO> ECEEMHJHBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<KeepsakeRoomListDTO> MDAGIENIBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private List<KeepsakeRoomListDTO> HLLOMPKMDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Dictionary<long, string> DKFIKDBEIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Dictionary<long, string> OBDFNLPGCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<long, DateTime> KKMOAPAIPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<long, List<KeepsakeRoomDTO>> NCINNNMPGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<long, List<KeepsakeRoomDTO>> DGMECHDFIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<long, long> CBABGMPPGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly List<string> LCCILPKEMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private DateTime CILIMBGOMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly IDisposable CMPDCGHAKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Dictionary<HMECHOKOCBB, int> KFOJIBHGILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Dictionary<HMECHOKOCBB, int> LNPLICFAHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private List<KeepsakeCategoryThemePair> AOHGDLMJPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private FBAGOKPOCJE BBNNKBFPLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool FHMDOJDJPBD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NGGJJHKNFNM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D5030", Offset = "0x6D3830", VA = "0x1806D5030", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA3F830", Offset = "0xA3E030", VA = "0x180A3F830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool IANJKBKFIKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x553A720", Offset = "0x5538F20", VA = "0x18553A720", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AEOGLIJGCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x55349D0", Offset = "0x55331D0", VA = "0x1855349D0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long NMBGKLNECGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5537FC0", Offset = "0x55367C0", VA = "0x185537FC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? GPOFNDDIAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x553BFE0", Offset = "0x553A7E0", VA = "0x18553BFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool KFALIKLDONC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x55356C0", Offset = "0x5533EC0", VA = "0x1855356C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> MACLHCGBMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCCA210", Offset = "0xCC8A10", VA = "0x180CCA210", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> FAFOCICHNIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x914EB0", Offset = "0x9136B0", VA = "0x180914EB0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> BNPIDIMAGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x914EC0", Offset = "0x9136C0", VA = "0x180914EC0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> JOPKNGOCOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x914E70", Offset = "0x913670", VA = "0x180914E70", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> IBDCNNMHPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xDCBF40", Offset = "0xDCA740", VA = "0x180DCBF40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal bool DFMCKMEMNGK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xF85B80", Offset = "0xF84380", VA = "0x180F85B80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5536F10", Offset = "0x5535710", VA = "0x185536F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> DIFIIEOIJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x553EBF0", Offset = "0x553D3F0", VA = "0x18553EBF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x55362C0", Offset = "0x5534AC0", VA = "0x1855362C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action CDLBAGKNBFC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x55344D0", Offset = "0x5532CD0", VA = "0x1855344D0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x55357F0", Offset = "0x5533FF0", VA = "0x1855357F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action IOADBMCPIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5535440", Offset = "0x5533C40", VA = "0x185535440", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5534BE0", Offset = "0x55333E0", VA = "0x185534BE0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x553F020", Offset = "0x553D820", VA = "0x18553F020")]
	[Preserve]
	internal PDFJLLECNBE([NotNull][LJAGOLJKNEF(null)] GBMHCJICALM DLLIHMOLLON, [NotNull][LJAGOLJKNEF(null)] MIOCAJIMDLG LAIOMLNCNCB, [NotNull][LJAGOLJKNEF(null)] PHMPGJPCEDF ODHEAOMLHAN, [NotNull][LJAGOLJKNEF(null)] FLMDALDIMOK JBOPHEONPFB, [NotNull][LJAGOLJKNEF(null)] EEOBFBBKMOJ OMOBIIDEMGJ, [NotNull][LJAGOLJKNEF(null)] BMDJCKFDFNK PPDKANNMDPN, [NotNull][LJAGOLJKNEF(null)] INJHHPOOMKB BMCHMDOOEBB, [NotNull][LJAGOLJKNEF(null)] IKAPBHIPIGI AJKJGDPJDEJ, [NotNull][LJAGOLJKNEF(null)] IHNBKMAGABN AKIKINCCOGC, [NotNull][LJAGOLJKNEF(null)] PDPMJBEPPLA HCHGDCFMHPP, [NotNull][LJAGOLJKNEF(null)] JGKAOGLAAHN ODACFNMJONN, [NotNull][LJAGOLJKNEF(null)] APPMNNLCBKD JCBIJHLIPCE, [NotNull][LJAGOLJKNEF(null)] BAOBFGEFPGE BMIHHMANFIP, [NotNull][LJAGOLJKNEF(null)] AGOLALPNOBE NKPHFJOANAG, [NotNull][LJAGOLJKNEF(null)] DKAHMDAKGPH DPKFNIFGLAH, [NotNull][LJAGOLJKNEF(null)] CJHMHMDOJHJ LMENJFALMEE, [NotNull][LJAGOLJKNEF(null)] KCGMHNBBENK APKCPEOPEFC, [NotNull][LJAGOLJKNEF(null)] global::PGNLJPMPPLN<KeepsakesConfig.KeepsakesOptions> LBOENCNHHLB, [NotNull][LJAGOLJKNEF(null)] BDKABIKNKDN NELEHDKKLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5536BA0", Offset = "0x55353A0", VA = "0x185536BA0", Slot = "15")]
	public bool EPGPJOCFEBP(List<string> MBNOOIOPJGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x553E6E0", Offset = "0x553CEE0", VA = "0x18553E6E0", Slot = "16")]
	public global::FGLDKEJLAKB<Guid> PEONCOIEIAH(HMECHOKOCBB CFMKHCBGOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5539090", Offset = "0x5537890", VA = "0x185539090", Slot = "17")]
	public LDGADANDBIO IGKABNGJHAN(Guid ELLBCGLMDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5535DA0", Offset = "0x55345A0", VA = "0x185535DA0", Slot = "18")]
	public LDGADANDBIO DNJPCBHCINM(Guid ELLBCGLMDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x55377A0", Offset = "0x5535FA0", VA = "0x1855377A0", Slot = "19")]
	public bool GFFNIHBOFMH(Guid ELLBCGLMDAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x553E1C0", Offset = "0x553C9C0", VA = "0x18553E1C0", Slot = "20")]
	public bool OMDMLLALPIC(Guid ELLBCGLMDAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x553AAD0", Offset = "0x55392D0", VA = "0x18553AAD0")]
	public KeepsakeTheme LBJFDPJKOAO(Guid ELLBCGLMDAA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x55375D0", Offset = "0x5535DD0", VA = "0x1855375D0")]
	public bool GAOCHEBACCM(HMECHOKOCBB CFMKHCBGOII, out KeepsakeTheme PPJNMGODDDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x553B150", Offset = "0x5539950", VA = "0x18553B150")]
	public List<KeepsakeTheme> MAHIAECLMGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5537A30", Offset = "0x5536230", VA = "0x185537A30")]
	public int GFPJJGHMOOP(HMECHOKOCBB CFMKHCBGOII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x55380A0", Offset = "0x55368A0", VA = "0x1855380A0")]
	public HMECHOKOCBB GLLMMLIANGK(Guid ELLBCGLMDAA)
	{
		return default(HMECHOKOCBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5539450", Offset = "0x5537C50", VA = "0x185539450", Slot = "34")]
	public List<HMECHOKOCBB> IJBLHPIAONL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x553AD60", Offset = "0x5539560", VA = "0x18553AD60", Slot = "35")]
	public IComparer<HMECHOKOCBB> LHMNAGKLBOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x553A1E0", Offset = "0x55389E0", VA = "0x18553A1E0", Slot = "32")]
	public string KBFEHPPOHLN(HMECHOKOCBB CFMKHCBGOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5534360", Offset = "0x5532B60", VA = "0x185534360", Slot = "33")]
	public string AHKIHODOKMD(HMECHOKOCBB CFMKHCBGOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x55395A0", Offset = "0x5537DA0", VA = "0x1855395A0", Slot = "21")]
	public bool INFNHEJDMPJ(Guid ELLBCGLMDAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x55359E0", Offset = "0x55341E0", VA = "0x1855359E0", Slot = "22")]
	public void DGPBCPNFOPH(Guid ELLBCGLMDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x553DF30", Offset = "0x553C730", VA = "0x18553DF30", Slot = "23")]
	public void OFAHCEBJBHL(HMECHOKOCBB CFMKHCBGOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5539AF0", Offset = "0x55382F0", VA = "0x185539AF0", Slot = "24")]
	public void JACNIFCAIOF(HMECHOKOCBB CFMKHCBGOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x553BA10", Offset = "0x553A210", VA = "0x18553BA10", Slot = "25")]
	public int MHPPJIMOAAH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x553B700", Offset = "0x5539F00", VA = "0x18553B700", Slot = "54")]
	public int MHPPJIMOAAH(HMECHOKOCBB CFMKHCBGOII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5533B40", Offset = "0x5532340", VA = "0x185533B40", Slot = "31")]
	public global::FGLDKEJLAKB<IEnumerable<Guid>> AFLIGPHGEHG(long JJIOFAMOIJP, long FMDBOIEDJKN, HMECHOKOCBB? CFMKHCBGOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x553AEC0", Offset = "0x55396C0", VA = "0x18553AEC0", Slot = "30")]
	public global::FGLDKEJLAKB<IEnumerable<Guid>> LMGJLDLNIGB(long JJIOFAMOIJP, long FMDBOIEDJKN, HMECHOKOCBB? CFMKHCBGOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5533730", Offset = "0x5531F30", VA = "0x185533730", Slot = "55")]
	public global::FGLDKEJLAKB<Dictionary<Guid, HMECHOKOCBB>> AEPFGPBANBP(long JJIOFAMOIJP, long FMDBOIEDJKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5536130", Offset = "0x5534930", VA = "0x185536130", Slot = "56")]
	public global::FGLDKEJLAKB<Dictionary<Guid, HMECHOKOCBB>> DPJKGDOFICD(long JJIOFAMOIJP, long FMDBOIEDJKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5533480", Offset = "0x5531C80", VA = "0x185533480", Slot = "26")]
	public global::FGLDKEJLAKB<int> AEMHJHAJGIB(long JJIOFAMOIJP, long FMDBOIEDJKN, HMECHOKOCBB? CFMKHCBGOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x553E570", Offset = "0x553CD70", VA = "0x18553E570", Slot = "27")]
	public global::FGLDKEJLAKB<int> PBBCPLKPKON(long JJIOFAMOIJP, long FMDBOIEDJKN, HMECHOKOCBB? CFMKHCBGOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5534C80", Offset = "0x5533480", VA = "0x185534C80", Slot = "28")]
	public global::FGLDKEJLAKB<Dictionary<HMECHOKOCBB, int>> BHPKAHGNDPM(long JJIOFAMOIJP, long FMDBOIEDJKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x55350C0", Offset = "0x55338C0", VA = "0x1855350C0", Slot = "29")]
	public global::FGLDKEJLAKB<Dictionary<HMECHOKOCBB, int>> BMALBEOLFGP(long JJIOFAMOIJP, long FMDBOIEDJKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5534A90", Offset = "0x5533290", VA = "0x185534A90", Slot = "37")]
	public bool BFGFHDJHBNJ(long JJIOFAMOIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x553AE00", Offset = "0x5539600", VA = "0x18553AE00", Slot = "57")]
	public bool LLFPMJEEJOJ(long JJIOFAMOIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x553C530", Offset = "0x553AD30", VA = "0x18553C530", Slot = "38")]
	public bool NGCLJGALCLB(long JJIOFAMOIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5536F80", Offset = "0x5535780", VA = "0x185536F80", Slot = "58")]
	public bool FJCOMIGCOHC(long JJIOFAMOIJP, out IANLKALKMNP CDJCEGMHKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x553ECF0", Offset = "0x553D4F0", VA = "0x18553ECF0", Slot = "39")]
	public bool PMMEFCNIMFH(long DIODFILIBGB, out DateTime NIANNJMFNND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5533F50", Offset = "0x5532750", VA = "0x185533F50", Slot = "40")]
	public long AGOIFMBBOCB(long DIODFILIBGB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x553DF70", Offset = "0x553C770", VA = "0x18553DF70", Slot = "59")]
	public IEnumerable<int> OHNKFFAHACM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x55356D0", Offset = "0x5533ED0", VA = "0x1855356D0", Slot = "41")]
	public long DDGKPENKLAD(long JJIOFAMOIJP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5532DC0", Offset = "0x55315C0", VA = "0x185532DC0", Slot = "42")]
	public int ABKNOJPGEDP(long DIODFILIBGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5534AF0", Offset = "0x55332F0", VA = "0x185534AF0", Slot = "43")]
	public bool BFOPOLFHNDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x55397D0", Offset = "0x5537FD0", VA = "0x1855397D0", Slot = "44")]
	public bool IOIOGKPEEFB(long DIODFILIBGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x55367C0", Offset = "0x5534FC0", VA = "0x1855367C0", Slot = "45")]
	public IEnumerable<long> ECMJKIILJJJ(long DIODFILIBGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5537520", Offset = "0x5535D20", VA = "0x185537520", Slot = "46")]
	public int FNCCDHBPCHD(long DIODFILIBGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5538D30", Offset = "0x5537530", VA = "0x185538D30", Slot = "50")]
	public long ICOCCFDBJFL(long BJMOPHGICNJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5535A50", Offset = "0x5534250", VA = "0x185535A50", Slot = "51")]
	public HMECHOKOCBB DIFNIEPPCLA()
	{
		return default(HMECHOKOCBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5537340", Offset = "0x5535B40", VA = "0x185537340")]
	private bool FLJNIEGJANO(Guid ELLBCGLMDAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x553C090", Offset = "0x553A890", VA = "0x18553C090")]
	private void NGBGDFDKKNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x553A770", Offset = "0x5538F70", VA = "0x18553A770")]
	private HMECHOKOCBB KNHPGDPFGEP()
	{
		return default(HMECHOKOCBB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5532FC0", Offset = "0x55317C0", VA = "0x185532FC0")]
	private void AELLFLCOANG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5535510", Offset = "0x5533D10", VA = "0x185535510")]
	private int CIIAAMLEKBF(KeepsakeRoomListDTO KBDBDNHDNHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x553EE40", Offset = "0x553D640", VA = "0x18553EE40")]
	private int POGGJLENHKG(DateTime LNEIJEIFEMC, DateTime EIJBLIBMIJD, TimeSpan FJIDMPCDMAA, int DBJEMMCIGNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5538B40", Offset = "0x5537340", VA = "0x185538B40")]
	private void HPIGGOJPCDO(IEnumerable<KeepsakeInstanceDTO> AEGDEEFKFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5535190", Offset = "0x5533990", VA = "0x185535190")]
	private void BNBBGNOKHBG(IEnumerable<KeepsakeCollectionRecordDTO> NFFKGFONJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5536EB0", Offset = "0x55356B0", VA = "0x185536EB0")]
	private void FFKCIGOCFDC(IEnumerable<long> JKBDBDLMPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1572B40", Offset = "0x1571340", VA = "0x181572B40")]
	private void DCPPOEGLHFK(KeepsakeGlobalConfigDTO PLOBEPELMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5539EA0", Offset = "0x55386A0", VA = "0x185539EA0")]
	private bool JKFBDHFCCDM(out Guid HHHFLJFEMEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x55354E0", Offset = "0x5533CE0", VA = "0x1855354E0")]
	private void CHHJEJJHGHL(HMECHOKOCBB HPHDEPJJNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x553AAA0", Offset = "0x55392A0", VA = "0x18553AAA0")]
	private void LBDHKOOOAGB(HMECHOKOCBB HPHDEPJJNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x553AC10", Offset = "0x5539410", VA = "0x18553AC10")]
	private void LDCOJCKGGPF(Guid ELLBCGLMDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5539370", Offset = "0x5537B70", VA = "0x185539370")]
	private void IIAMGABHCAK(HMECHOKOCBB HPHDEPJJNMO, int GAPLKCGCKNL, ref Dictionary<HMECHOKOCBB, int> HPPEGLBNMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x55369A0", Offset = "0x55351A0", VA = "0x1855369A0")]
	private void EMGNNBEFGKJ(KeepsakeInstanceDTO FNNNOGPPBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x553C5D0", Offset = "0x553ADD0", VA = "0x18553C5D0")]
	private void NIANJEDMAGD(KeepsakeInstanceDTO FNNNOGPPBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5537BC0", Offset = "0x55363C0", VA = "0x185537BC0")]
	private void GHPKOMFPCFJ(Guid ELLBCGLMDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x553AE60", Offset = "0x5539660", VA = "0x18553AE60")]
	private void LLPJJCKLPDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5534570", Offset = "0x5532D70", VA = "0x185534570")]
	private void ALFKEBAPHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x55353D0", Offset = "0x5533BD0", VA = "0x1855353D0")]
	private void BNNCJJMDNIE(AJFJBNPAMOK IOCGGABOKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x553B4A0", Offset = "0x5539CA0", VA = "0x18553B4A0")]
	private void MGAGIHONFBK(FFFIMAGLKEG.NONIIIIFKFG BFHAMCLNCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5537F60", Offset = "0x5536760", VA = "0x185537F60")]
	private void GIDOJHJJGAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5538780", Offset = "0x5536F80", VA = "0x185538780")]
	private void GLNMFNDNAHH(float BNCMGABBKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5538210", Offset = "0x5536A10", VA = "0x185538210")]
	private void GLMKNIGJJOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x553B500", Offset = "0x5539D00", VA = "0x18553B500")]
	private bool MGKGEJHKOPF(Guid ELLBCGLMDAA, out string FHEDEHMILDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x553EA20", Offset = "0x553D220", VA = "0x18553EA20")]
	private bool PFEMBLDAPOC(Guid ELLBCGLMDAA, out KeepsakeCategoryConfigDTO HPHDEPJJNMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5534FE0", Offset = "0x55337E0", VA = "0x185534FE0")]
	private void BKIGKDNJMAK(string ENBCBHDDENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x553EF10", Offset = "0x553D710", VA = "0x18553EF10")]
	private bool POHIIACPOFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x553CD80", Offset = "0x553B580", VA = "0x18553CD80")]
	private IEnumerable<long> NPMCHCKLMHE(IEnumerable<KeepsakeRoomDTO> MPECLAOKPBO, IEnumerable<KeepsakeRoomListDTO> MCJPNGDJECK, long DIODFILIBGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x553C850", Offset = "0x553B050", VA = "0x18553C850")]
	private bool NNHHFKNLPMG(Guid ELLBCGLMDAA, out string EMPPPODHBFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x553EC90", Offset = "0x553D490", VA = "0x18553EC90", Slot = "47")]
	public string PMINJHPIJGA(KPCIDNKFIEC MCMJGGNOMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5534590", Offset = "0x5532D90", VA = "0x185534590", Slot = "49")]
	public string ANIJCGPHLLN(KPCIDNKFIEC MCMJGGNOMAG, long JJIOFAMOIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5539D80", Offset = "0x5538580", VA = "0x185539D80", Slot = "48")]
	public string JFOFKIICAKP(KPCIDNKFIEC MCMJGGNOMAG, int DMAJLEDLCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x553D060", Offset = "0x553B860", VA = "0x18553D060")]
	private void ODDKAMBKDEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5534EA0", Offset = "0x55336A0", VA = "0x185534EA0")]
	private void BIILNCDBLFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5539070", Offset = "0x5537870", VA = "0x185539070")]
	private KPCIDNKFIEC IDHOLKFGDJG(CPIFAEPGAPE CGOAGAJGMCN)
	{
		return default(KPCIDNKFIEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5537BA0", Offset = "0x55363A0", VA = "0x185537BA0")]
	private KPCIDNKFIEC GHCFMDCGBKL(CPIFAEPGAPE CGOAGAJGMCN)
	{
		return default(KPCIDNKFIEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x553A350", Offset = "0x5538B50", VA = "0x18553A350")]
	internal static string KGBMKGFMLHD(DHNBKMHDANK BLGDPKCKBKG, string HLMPKJNCPFH, bool AEJCHLGNCFE, int BOFCNPGDHEM, int OPLJNEBLMNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5536360", Offset = "0x5534B60", VA = "0x185536360", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x553C7D0", Offset = "0x553AFD0", VA = "0x18553C7D0")]
	private BPMCEAKEINK NMADJNIPHHG(CPHBKIKDFMP EGNAGKFKNPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5532C20", Offset = "0x5531420", VA = "0x185532C20")]
	private EHLIKLJEGFI ABICFHAJCMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x553E1F0", Offset = "0x553C9F0", VA = "0x18553E1F0")]
	private Task PAHDKJBACDB(LNCJNEHCLGE OBPCMKOMOOP, CancellationToken DIEJHKIAFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5535890", Offset = "0x5534090", VA = "0x185535890")]
	[AsyncStateMachine(typeof(HBIBGBJEKHC))]
	private Task DGOELMGNECB(LNCJNEHCLGE OBPCMKOMOOP, CancellationToken DIEJHKIAFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5537480", Offset = "0x5535C80", VA = "0x185537480")]
	private Task FMNABBHHKGF(LNCJNEHCLGE OBPCMKOMOOP, CancellationToken DIEJHKIAFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x55378E0", Offset = "0x55360E0", VA = "0x1855378E0")]
	[AsyncStateMachine(typeof(EIBKDGKLDAA))]
	private Task GFIEHOAPJPF(string EPAIMCEIMPA, TimeSpan MMIEPKMDOFB, CancellationToken DIEJHKIAFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x553B060", Offset = "0x5539860", VA = "0x18553B060")]
	[CompilerGenerated]
	private bool LNCHMCOAGEA(KeepsakeInstanceDTO NGMFABJMIHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x553DDB0", Offset = "0x553C5B0", VA = "0x18553DDB0")]
	[CompilerGenerated]
	private global::FGLDKEJLAKB<Dictionary<HMECHOKOCBB, int>> OENCHAJMMOO(Dictionary<Guid, HMECHOKOCBB> NIKJOEMMIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x553BE60", Offset = "0x553A660", VA = "0x18553BE60")]
	[CompilerGenerated]
	private global::FGLDKEJLAKB<Dictionary<HMECHOKOCBB, int>> MMIGBBODONP(Dictionary<Guid, HMECHOKOCBB> NIKJOEMMIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x553C070", Offset = "0x553A870", VA = "0x18553C070")]
	[CompilerGenerated]
	private bool MPMNGCPMMPO(KeepsakeRoomListDTO NGMFABJMIHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5539C60", Offset = "0x5538460", VA = "0x185539C60")]
	[CompilerGenerated]
	private void JCHHMKIKBFB(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<HMECHOKOCBB, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> LELFOBIJDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5539A90", Offset = "0x5538290", VA = "0x185539A90")]
	[CompilerGenerated]
	private void IOMGKHGLKCO(string EMPPPODHBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x553A530", Offset = "0x5538D30", VA = "0x18553A530")]
	[CompilerGenerated]
	private Task KMBJPCOPCOL(CancellationToken BCLJHLFFILM)
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
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public string ThemeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int ThemeOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Header("Pickup")]
		public string PickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public GameObject PickupPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AudioClip PickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public float PickupSfxVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[Header("Colors")]
		public bool UseCustomColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Color BeamColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Color BaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[Header("Looping Sound")]
		public AudioClip LoopingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public float LoopingSfxVolume;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class KeepsakesConfig : ScriptableObject, global::PGNLJPMPPLN<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002F")]
			[CompilerGenerated]
			private sealed class OOMHLNJPFIJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
				public OOMHLNJPFIJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F1")]
				[Cpp2IlInjected.Address(RVA = "0x5532BF0", Offset = "0x55313F0", VA = "0x185532BF0")]
				internal bool <TryGetKeepsakeTheme>b__0(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x5532BF0", Offset = "0x55313F0", VA = "0x185532BF0")]
				internal bool <TryGetKeepsakeTheme>b__1(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6D5F40", Offset = "0x6D4740", VA = "0x1806D5F40")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] IAOLKLILELC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x5531C00", Offset = "0x5530400", VA = "0x185531C00")]
			public bool EMHDEKCMEDE(string GJGBNMGJOOA, out KeepsakeTheme PPJNMGODDDO)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public KeepsakesOptions Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5531B80", Offset = "0x5530380", VA = "0x185531B80")]
		[HAHBDBPNEOA(MDCFJLLNHDJ.None)]
		private static void OCOAIBMMGNP(BENLBCJOMLF NDEFPJDAEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xE21530", Offset = "0xE1FD30", VA = "0x180E21530")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class PDJLMBMEBDL
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static byte[] MEBJOHCMOJE;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static int JLNKJPMHNDA;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static int JMCMMIDKHCA;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static BigInteger PCHDNPNKOJB;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public PDJLMBMEBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x55405F0", Offset = "0x553EDF0", VA = "0x1855405F0")]
	private static string FEOGEGMPIMJ(byte[] JBKIIGINOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x55402A0", Offset = "0x553EAA0", VA = "0x1855402A0")]
	public static string CIDKAEMCDOH(byte[] EBBNNMNMLOE, bool IGCCOAIPDPG)
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

		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
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
