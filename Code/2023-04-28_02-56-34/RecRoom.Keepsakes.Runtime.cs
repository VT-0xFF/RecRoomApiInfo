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
public class NNIJEDCMDIJ : IComparer<MOMDKDLAOIH>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class BHFDDBLFCBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MOMDKDLAOIH x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public MOMDKDLAOIH y;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public BHFDDBLFCBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1185070", Offset = "0x1183A70", VA = "0x181185070")]
		internal bool <Compare>b__0(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x10BE710", Offset = "0x10BD110", VA = "0x1810BE710")]
		internal bool <Compare>b__1(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1185070", Offset = "0x1183A70", VA = "0x181185070")]
		internal bool <Compare>b__2(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x10BE710", Offset = "0x10BD110", VA = "0x1810BE710")]
		internal bool <Compare>b__3(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> KFHMKHNABKC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
	public NNIJEDCMDIJ(List<KeepsakeCategoryThemePair> BHBHAHMDENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x57778E0", Offset = "0x57762E0", VA = "0x1857778E0", Slot = "4")]
	public int Compare(MOMDKDLAOIH GKBCEINHOJB, MOMDKDLAOIH LAMHEDHCIJG)
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
		public MOMDKDLAOIH KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum PPJKLFKDEKD
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OPDDIGNOJMD]
public class OHGKCIDFEGK : OGDBACLOCBP, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct CIKMCJDNMCB
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public const string CAIAAMPFBNO = "Keepsake placement still in progress. Please wait a moment before placing another keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public const string JCOLNEEHMGK = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public const string BNNNJKNFBNJ = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public const string EMFEJDGINHJ = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public const string EJLKMPDAACB = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public const string GDMONFCACKC = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string HMIMNJKCIJE = "You have to collect other keepsakes before you can collect this one.";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public const string FCEGNPAIIAG = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const string FOCDGNFIPFB = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public const string KDEPJFNLIHA = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public const string ALABIACIEBI = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public const string IPAECCPDKLK = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public const string EBJOCDIPKFC = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class PPIEIMOEGPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public OHGKCIDFEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public MOMDKDLAOIH keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public PPIEIMOEGPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5786820", Offset = "0x5785220", VA = "0x185786820")]
		internal void <CreateKeepsakeInstanceData>b__4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5786380", Offset = "0x5784D80", VA = "0x185786380")]
		internal void <CreateKeepsakeInstanceData>b__2(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x57867F0", Offset = "0x57851F0", VA = "0x1857867F0")]
		internal void <CreateKeepsakeInstanceData>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class AOCFFDNADHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public OHGKCIDFEGK <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public AOCFFDNADHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5774DA0", Offset = "0x57737A0", VA = "0x185774DA0")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class HAIIHGHEJBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public HAIIHGHEJBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5776420", Offset = "0x5774E20", VA = "0x185776420")]
		internal bool <GetKeepsakeCategory>b__0(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class FIKLDKADLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public OHGKCIDFEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public MOMDKDLAOIH keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public FIKLDKADLPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5776000", Offset = "0x5774A00", VA = "0x185776000")]
		internal bool <GetRemainingKeepsakeViewQuantityForCurrentRoom>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class EKPHGKJCDGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public OHGKCIDFEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public MOMDKDLAOIH? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public EKPHGKJCDGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5775820", Offset = "0x5774220", VA = "0x185775820")]
		internal void <GetAllKeepsakeInstanceIdsForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5775280", Offset = "0x5773C80", VA = "0x185775280")]
		internal void <GetAllKeepsakeInstanceIdsForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x57758B0", Offset = "0x57742B0", VA = "0x1857758B0")]
		internal global::ODHJGGEEIEO<IEnumerable<Guid>> <GetAllKeepsakeInstanceIdsForRoom>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x57755C0", Offset = "0x5773FC0", VA = "0x1857755C0")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class JBKGNLFNKGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public EKPHGKJCDGP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public JBKGNLFNKGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5776AE0", Offset = "0x57754E0", VA = "0x185776AE0")]
		internal global::ODHJGGEEIEO<IEnumerable<Guid>> <GetAllKeepsakeInstanceIdsForRoom>b__4(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class DOEKBPIADOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public JBKGNLFNKGP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public DOEKBPIADOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5775670", Offset = "0x5774070", VA = "0x185775670")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__5(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class JEGDDCHKNMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public DOEKBPIADOP CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public JEGDDCHKNMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5776C30", Offset = "0x5775630", VA = "0x185776C30")]
		internal bool <GetAllKeepsakeInstanceIdsForRoom>b__6(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class OAIBOLCNMJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public OHGKCIDFEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public OAIBOLCNMJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5777B80", Offset = "0x5776580", VA = "0x185777B80")]
		internal global::ODHJGGEEIEO<IEnumerable<Guid>> <GetUncollectedKeepsakeInstanceIdsForRoom>b__0(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2450090", Offset = "0x244EA90", VA = "0x182450090")]
		internal bool <GetUncollectedKeepsakeInstanceIdsForRoom>b__1(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class CEGEAJGDDBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public OHGKCIDFEGK <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public CEGEAJGDDBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x57751F0", Offset = "0x5773BF0", VA = "0x1857751F0")]
		internal void <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5775280", Offset = "0x5773C80", VA = "0x185775280")]
		internal void <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x57752B0", Offset = "0x5773CB0", VA = "0x1857752B0")]
		internal global::ODHJGGEEIEO<Dictionary<Guid, MOMDKDLAOIH>> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x57755C0", Offset = "0x5773FC0", VA = "0x1857755C0")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class GDDAKCNILGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public GDDAKCNILGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x57761D0", Offset = "0x5774BD0", VA = "0x1857761D0")]
		internal global::ODHJGGEEIEO<Dictionary<Guid, MOMDKDLAOIH>> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__4(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class FBPHLLOGEFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public FBPHLLOGEFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5775DB0", Offset = "0x57747B0", VA = "0x185775DB0")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__5(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5775EA0", Offset = "0x57748A0", VA = "0x185775EA0")]
		internal KeyValuePair<Guid, MOMDKDLAOIH> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__6(Guid instanceId)
		{
			return default(KeyValuePair<Guid, MOMDKDLAOIH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class FPMAAJJPKPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public FPMAAJJPKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5776130", Offset = "0x5774B30", VA = "0x185776130")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__7(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IJCLNLMPPGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public IJCLNLMPPGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5776A40", Offset = "0x5775440", VA = "0x185776A40")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__8(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class IFDMGPKDAKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public OHGKCIDFEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public IFDMGPKDAKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x57767B0", Offset = "0x57751B0", VA = "0x1857767B0")]
		internal global::ODHJGGEEIEO<Dictionary<Guid, MOMDKDLAOIH>> <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__0(Dictionary<Guid, MOMDKDLAOIH> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2450090", Offset = "0x244EA90", VA = "0x182450090")]
		internal bool <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__1(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GHDBKLCMNFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public GHDBKLCMNFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x57763A0", Offset = "0x5774DA0", VA = "0x1857763A0")]
		internal bool <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__2(KeyValuePair<Guid, MOMDKDLAOIH> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class AIOMPEOLCKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Dictionary<Guid, MOMDKDLAOIH> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public AIOMPEOLCKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5774C40", Offset = "0x5773640", VA = "0x185774C40")]
		internal KeyValuePair<MOMDKDLAOIH, int> <GetUncollectedKeepsakeCountPerCategoryForRoom>b__1(MOMDKDLAOIH category)
		{
			return default(KeyValuePair<MOMDKDLAOIH, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class PFPDABIBAAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public MOMDKDLAOIH category;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public PFPDABIBAAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x17C9BB0", Offset = "0x17C85B0", VA = "0x1817C9BB0")]
		internal bool <GetUncollectedKeepsakeCountPerCategoryForRoom>b__2(MOMDKDLAOIH instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class FBOGAMMAKNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Dictionary<Guid, MOMDKDLAOIH> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public FBOGAMMAKNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5775C50", Offset = "0x5774650", VA = "0x185775C50")]
		internal KeyValuePair<MOMDKDLAOIH, int> <GetTotalKeepsakeCountPerCategoryForRoom>b__1(MOMDKDLAOIH category)
		{
			return default(KeyValuePair<MOMDKDLAOIH, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class ONFLDHLNGAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public MOMDKDLAOIH category;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public ONFLDHLNGAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x17C9BB0", Offset = "0x17C85B0", VA = "0x1817C9BB0")]
		internal bool <GetTotalKeepsakeCountPerCategoryForRoom>b__2(MOMDKDLAOIH instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NJEPIPCNABE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public OHGKCIDFEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public NJEPIPCNABE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5777640", Offset = "0x5776040", VA = "0x185777640")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5777710", Offset = "0x5776110", VA = "0x185777710")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5777710", Offset = "0x5776110", VA = "0x185777710")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HGPKDGNJJNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public HGPKDGNJJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1094E70", Offset = "0x1093870", VA = "0x181094E70")]
		internal bool <GetHighlightKeepsakeRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class NKFDCPOIKHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public NKFDCPOIKHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5777810", Offset = "0x5776210", VA = "0x185777810")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x1201E90", Offset = "0x1200890", VA = "0x181201E90")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__1(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class IFIAJLFJNJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public IFIAJLFJNJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x57769D0", Offset = "0x57753D0", VA = "0x1857769D0")]
		internal bool <GetKeepsakeRoomListUpsellItemPurchasableGiftDropId>b__0(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HPBDLNHAEDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public HPBDLNHAEDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1094E70", Offset = "0x1093870", VA = "0x181094E70")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class EMJMLGFHCFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public EMJMLGFHCFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5775BC0", Offset = "0x57745C0", VA = "0x185775BC0")]
		internal bool <IsKeepsakeInCurrentKeepsakeCategory>b__0(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class OFFMPCLLNJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public MOMDKDLAOIH keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public OFFMPCLLNJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1369BC0", Offset = "0x13685C0", VA = "0x181369BC0")]
		internal bool <TryGetNextOrphanedKeepsakeInstanceFromCategory>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DJONPDEHHFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public DJONPDEHHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x57755E0", Offset = "0x5773FE0", VA = "0x1857755E0")]
		internal bool <IncrementCollectedKeepsakeCount>b__0(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class BABDCHODMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public MOMDKDLAOIH keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public BABDCHODMHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x57751B0", Offset = "0x5773BB0", VA = "0x1857751B0")]
		internal bool <GetTotalCollectableKeepsakeCountForCategory>b__0(KeyValuePair<Guid, MOMDKDLAOIH> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class FHAFCHGLOFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public MOMDKDLAOIH newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public FHAFCHGLOFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1369BC0", Offset = "0x13685C0", VA = "0x181369BC0")]
		internal bool <OnKeepsakeCollected>b__0(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class MLOAGLFDDNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public MLOAGLFDDNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x57775A0", Offset = "0x5775FA0", VA = "0x1857775A0")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class HBALHJGCONF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public HBALHJGCONF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5776450", Offset = "0x5774E50", VA = "0x185776450")]
		internal bool <GetKeepsakeRoomIdsInList>b__0(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class EAHKLAKEHPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public HBALHJGCONF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public EAHKLAKEHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x57757A0", Offset = "0x57741A0", VA = "0x1857757A0")]
		internal bool <GetKeepsakeRoomIdsInList>b__3(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct OFCNHLMDJPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public OHGKCIDFEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public JILMCFPJPGB args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5777D20", Offset = "0x5776720", VA = "0x185777D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct IBAOHKHEOBC : IAsyncStateMachine
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
		public OHGKCIDFEGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5776570", Offset = "0x5774F70", VA = "0x185776570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int IHCDNJIPNCN = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DateTime HPBHMMGFALL;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int FGCCNDBJCAI = 3;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const long PBACBKDIDIE = -1L;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const char OLNAAHBNOML = '|';

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CFLJMDJKFAG KLHMFOJGBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly EEFPCCHHFAP FGKMICHLOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly NHCEBFDFEHN GIDKGIJFGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly CHNNJBMKJLD FKCIDMLJLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly EOALMFOCEOE FDPHPHDPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly CGCKBDOECOE PBECOPCBNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly NJBDFOIOPMG DIJGJGFMIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly OGCACIFJDCP KEHCECCODAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly KHOAOKBAEKD LNOBLPCNDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly NJHAAAJKAHC PFJOCILLFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly CACPPPCKNFM IKABJBDBFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly PMONMFEABJI FOICHCFHEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly GIJBKJCAKDE IKEGEABAKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly DHMENGHKMJI BMDOHFOEMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly NHOBFCMCDOK HNGDIECMCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly global::GBPBAFKAGPD<KeepsakesConfig.KeepsakesOptions> MIBGOGGBLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly LGIHGHKPCKA FBJGDFFOGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> LDMIPNCIOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly HashSet<Guid> AEOIPMNDJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly HashSet<long> KDJCEOAHNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private Dictionary<MOMDKDLAOIH, int> AADNOMENEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<Guid> OPDHBBEJFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IDisposable INFPCFIOLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Task MCBABACAFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private global::ODHJGGEEIEO<Guid> PHPFMKFBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private long? DANGIDKPHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private KeepsakeProgressionEventInstancesDTO IPCKNBGALHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private global::ODHJGGEEIEO<KeepsakeProgressionEventInstancesDTO> ODKGEKJADHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private IReadOnlyDictionary<MOMDKDLAOIH, KeepsakeCategoryConfigDTO> ANCGPGHJDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private KeepsakeGlobalConfigDTO FOGIOFGJMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private HashSet<long> NJCHFHKEIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private HashSet<long> MJMDPAMPHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<KeepsakeRoomListDTO> FJIFLGEKIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private List<KeepsakeRoomListDTO> HJGOGLNOLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private List<KeepsakeRoomListDTO> LFKPCKOCFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Dictionary<long, string> AMNEAECMHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<long, string> AGCBNMKPBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<long, DateTime> BDDNPFFCPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Dictionary<long, List<KeepsakeRoomDTO>> GOJHALKFKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<long, List<KeepsakeRoomDTO>> NIFJACBJOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<long, long> JPKJEPBHGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly List<string> GFAPOEKNKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private DateTime BDEIGIAFGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly IDisposable PBEKAAPKNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Dictionary<Guid, MOMDKDLAOIH> CJGBMEEODDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Dictionary<MOMDKDLAOIH, int> GOGFADHEKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private List<KeepsakeCategoryThemePair> BHBHAHMDENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private NNIJEDCMDIJ EBIFBAHOANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private bool OCODGFFGFPP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool CANMDIEMALG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB90", Offset = "0xA4C590", VA = "0x180A4DB90", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA4DC10", Offset = "0xA4C610", VA = "0x180A4DC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool EFNKKOKJGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5779CB0", Offset = "0x57786B0", VA = "0x185779CB0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HFLHGIKCJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x577B7A0", Offset = "0x577A1A0", VA = "0x18577B7A0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long IHAKHJAFDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5781B00", Offset = "0x5780500", VA = "0x185781B00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? LKLPNMOLEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5782E70", Offset = "0x5781870", VA = "0x185782E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool DHHAJBANBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x577C360", Offset = "0x577AD60", VA = "0x18577C360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> JPBLCPONCBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xF5AE00", Offset = "0xF59800", VA = "0x180F5AE00", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> KMJHBDPDPCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xF5ADF0", Offset = "0xF597F0", VA = "0x180F5ADF0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> HFLFIBOECPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xF5A6C0", Offset = "0xF590C0", VA = "0x180F5A6C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> DKJGGHEIFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xD7CD80", Offset = "0xD7B780", VA = "0x180D7CD80", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> ENEIONOFAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xCA2700", Offset = "0xCA1100", VA = "0x180CA2700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal bool FHAAOBHLLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xFEA7E0", Offset = "0xFE91E0", VA = "0x180FEA7E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x577E640", Offset = "0x577D040", VA = "0x18577E640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> LLDDLGDHLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5784910", Offset = "0x5783310", VA = "0x185784910", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x577E820", Offset = "0x577D220", VA = "0x18577E820", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GKAKNGEKEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x577F850", Offset = "0x577E250", VA = "0x18577F850", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x577CA00", Offset = "0x577B400", VA = "0x18577CA00", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action DNICBHEMMPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x577CDE0", Offset = "0x577B7E0", VA = "0x18577CDE0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5783080", Offset = "0x5781A80", VA = "0x185783080", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x57850E0", Offset = "0x5783AE0", VA = "0x1857850E0")]
	[Preserve]
	internal OHGKCIDFEGK([NotNull][LIKONNNLKGK(null)] CFLJMDJKFAG KLHMFOJGBGN, [NotNull][LIKONNNLKGK(null)] AEJHBGAHGKH DPBFKHPKMAC, [NotNull][LIKONNNLKGK(null)] EEFPCCHHFAP FGKMICHLOIM, [NotNull][LIKONNNLKGK(null)] NHCEBFDFEHN GIDKGIJFGMP, [NotNull][LIKONNNLKGK(null)] CHNNJBMKJLD FKCIDMLJLGP, [NotNull][LIKONNNLKGK(null)] EOALMFOCEOE FDPHPHDPLEL, [NotNull][LIKONNNLKGK(null)] CGCKBDOECOE PBECOPCBNCK, [NotNull][LIKONNNLKGK(null)] NJBDFOIOPMG DIJGJGFMIIJ, [NotNull][LIKONNNLKGK(null)] OGCACIFJDCP KEHCECCODAM, [NotNull][LIKONNNLKGK(null)] EOFMOAKCMLI PEFJLCHAIEA, [NotNull][LIKONNNLKGK(null)] KHOAOKBAEKD LNOBLPCNDLI, [NotNull][LIKONNNLKGK(null)] NJHAAAJKAHC PFJOCILLFIL, [NotNull][LIKONNNLKGK(null)] CACPPPCKNFM IKABJBDBFKA, [NotNull][LIKONNNLKGK(null)] PMONMFEABJI FOICHCFHEIN, [NotNull][LIKONNNLKGK(null)] GIJBKJCAKDE IKEGEABAKFC, [NotNull][LIKONNNLKGK(null)] DHMENGHKMJI BMDOHFOEMDB, [NotNull][LIKONNNLKGK(null)] NHOBFCMCDOK HNGDIECMCEL, [NotNull][LIKONNNLKGK(null)] global::GBPBAFKAGPD<KeepsakesConfig.KeepsakesOptions> MIBGOGGBLGL, [NotNull][LIKONNNLKGK(null)] LGIHGHKPCKA FBJGDFFOGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x577B860", Offset = "0x577A260", VA = "0x18577B860", Slot = "15")]
	public bool DPCOCPMLKIC(List<string> JLKHFCCECIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5783120", Offset = "0x5781B20", VA = "0x185783120", Slot = "16")]
	public global::ODHJGGEEIEO<Guid> NJHENBLMNFB(MOMDKDLAOIH CGNJALEGFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x577DD70", Offset = "0x577C770", VA = "0x18577DD70", Slot = "17")]
	public JKAHJLGEFLE GCECEENMEEA(Guid KOAIMKDICGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x57849B0", Offset = "0x57833B0", VA = "0x1857849B0", Slot = "18")]
	public JKAHJLGEFLE PBHOACFHAGM(Guid KOAIMKDICGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5784DF0", Offset = "0x57837F0", VA = "0x185784DF0", Slot = "19")]
	public bool PGEDPICMJAH(Guid KOAIMKDICGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x57801F0", Offset = "0x577EBF0", VA = "0x1857801F0", Slot = "20")]
	public bool KHCGENJBEHG(Guid KOAIMKDICGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x577F280", Offset = "0x577DC80", VA = "0x18577F280")]
	public KeepsakeTheme JCEICMNFGFG(Guid KOAIMKDICGM)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x57783B0", Offset = "0x5776DB0", VA = "0x1857783B0")]
	public bool AFJNDDLMINK(MOMDKDLAOIH CGNJALEGFFJ, out KeepsakeTheme DCIAMLJDNKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5779960", Offset = "0x5778360", VA = "0x185779960")]
	public List<KeepsakeTheme> CBIOEEBHBBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x577E0C0", Offset = "0x577CAC0", VA = "0x18577E0C0")]
	public int GGNJDHBJCHF(MOMDKDLAOIH CGNJALEGFFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5780A80", Offset = "0x577F480", VA = "0x185780A80")]
	public MOMDKDLAOIH LDGMCEDNEPE(Guid KOAIMKDICGM)
	{
		return default(MOMDKDLAOIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5780220", Offset = "0x577EC20", VA = "0x185780220", Slot = "34")]
	public List<MOMDKDLAOIH> KHCMHKDHILB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x577B4E0", Offset = "0x5779EE0", VA = "0x18577B4E0", Slot = "35")]
	public IComparer<MOMDKDLAOIH> DHCHPCJNMAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5780710", Offset = "0x577F110", VA = "0x185780710", Slot = "32")]
	public string LACHJCEEFNG(MOMDKDLAOIH CGNJALEGFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x577F6E0", Offset = "0x577E0E0", VA = "0x18577F6E0", Slot = "33")]
	public string JFAEEDFPKIG(MOMDKDLAOIH CGNJALEGFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x577EC70", Offset = "0x577D670", VA = "0x18577EC70", Slot = "21")]
	public bool HLKGFKGPKNC(Guid KOAIMKDICGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5781090", Offset = "0x577FA90", VA = "0x185781090", Slot = "22")]
	public void LLPHGFGDLFF(Guid KOAIMKDICGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x577B760", Offset = "0x577A160", VA = "0x18577B760", Slot = "23")]
	public void DNLLJKIAGFG(MOMDKDLAOIH CGNJALEGFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x577F8F0", Offset = "0x577E2F0", VA = "0x18577F8F0", Slot = "24")]
	public void JINICEGAGJM(Guid KOAIMKDICGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5779200", Offset = "0x5777C00", VA = "0x185779200", Slot = "25")]
	public int CAJHGOOPPNJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5779650", Offset = "0x5778050", VA = "0x185779650", Slot = "54")]
	public int CAJHGOOPPNJ(MOMDKDLAOIH CGNJALEGFFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x577E230", Offset = "0x577CC30", VA = "0x18577E230", Slot = "31")]
	public global::ODHJGGEEIEO<IEnumerable<Guid>> GKGMLKPFMFL(long LCIEPBGBKGO, long NIGCMMACIIM, MOMDKDLAOIH? CGNJALEGFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5778580", Offset = "0x5776F80", VA = "0x185778580", Slot = "30")]
	public global::ODHJGGEEIEO<IEnumerable<Guid>> AFJPAFAJBFB(long LCIEPBGBKGO, long NIGCMMACIIM, MOMDKDLAOIH? CGNJALEGFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5783860", Offset = "0x5782260", VA = "0x185783860", Slot = "55")]
	public global::ODHJGGEEIEO<Dictionary<Guid, MOMDKDLAOIH>> NNALJOKBNEF(long LCIEPBGBKGO, long NIGCMMACIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x577F000", Offset = "0x577DA00", VA = "0x18577F000", Slot = "56")]
	public global::ODHJGGEEIEO<Dictionary<Guid, MOMDKDLAOIH>> IIHFBECPMIG(long LCIEPBGBKGO, long NIGCMMACIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x577C440", Offset = "0x577AE40", VA = "0x18577C440", Slot = "26")]
	public global::ODHJGGEEIEO<int> ELCLCLEDCMH(long LCIEPBGBKGO, long NIGCMMACIIM, MOMDKDLAOIH? CGNJALEGFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5781240", Offset = "0x577FC40", VA = "0x185781240", Slot = "27")]
	public global::ODHJGGEEIEO<int> LNCCFHMLHBG(long LCIEPBGBKGO, long NIGCMMACIIM, MOMDKDLAOIH? CGNJALEGFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x577A720", Offset = "0x5779120", VA = "0x18577A720", Slot = "28")]
	public global::ODHJGGEEIEO<Dictionary<MOMDKDLAOIH, int>> CNKJNJEAMON(long LCIEPBGBKGO, long NIGCMMACIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x577EF30", Offset = "0x577D930", VA = "0x18577EF30", Slot = "29")]
	public global::ODHJGGEEIEO<Dictionary<MOMDKDLAOIH, int>> ICIMDLFDNIO(long LCIEPBGBKGO, long NIGCMMACIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x577C3E0", Offset = "0x577ADE0", VA = "0x18577C3E0", Slot = "37")]
	public bool EIOBHKLONMN(long LCIEPBGBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5778B90", Offset = "0x5777590", VA = "0x185778B90", Slot = "57")]
	public bool BGFIKGCNIFA(long LCIEPBGBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x577E780", Offset = "0x577D180", VA = "0x18577E780", Slot = "38")]
	public bool GPPCOADBEHG(long LCIEPBGBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x57813B0", Offset = "0x577FDB0", VA = "0x1857813B0", Slot = "58")]
	public bool LNMNPJOPOLI(long LCIEPBGBKGO, out NAJOBOOFDDP ABBGOCIEHLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5778890", Offset = "0x5777290", VA = "0x185778890", Slot = "39")]
	public bool BAAIGJNFKCM(long ABBGCDLIHON, out DateTime APNEFLHJLGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5783FB0", Offset = "0x57829B0", VA = "0x185783FB0", Slot = "40")]
	public long OFNMFBEAAJM(long ABBGCDLIHON)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x577E8C0", Offset = "0x577D2C0", VA = "0x18577E8C0", Slot = "59")]
	public IEnumerable<int> HHPOMCGDNDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x57789E0", Offset = "0x57773E0", VA = "0x1857789E0", Slot = "41")]
	public long BDJANPGJEAP(long LCIEPBGBKGO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x577C050", Offset = "0x577AA50", VA = "0x18577C050", Slot = "42")]
	public int EDNNGGPJOKN(long ABBGCDLIHON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5778210", Offset = "0x5776C10", VA = "0x185778210", Slot = "43")]
	public bool ABPOIBJHJDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x577AD00", Offset = "0x5779700", VA = "0x18577AD00", Slot = "44")]
	public bool DDIEGCAAHBD(long ABBGCDLIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x577AFC0", Offset = "0x57799C0", VA = "0x18577AFC0", Slot = "45")]
	public IEnumerable<long> DENEDCJAFJL(long ABBGCDLIHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5778300", Offset = "0x5776D00", VA = "0x185778300", Slot = "46")]
	public int ACJOHHANCAK(long ABBGCDLIHON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x577B1A0", Offset = "0x5779BA0", VA = "0x18577B1A0", Slot = "50")]
	public long DFCHHBGOGFK(long GJPNGGPJFMN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x577FC50", Offset = "0x577E650", VA = "0x18577FC50", Slot = "51")]
	public MOMDKDLAOIH JPJKHLOKOME()
	{
		return default(MOMDKDLAOIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x577AB50", Offset = "0x5779550", VA = "0x18577AB50")]
	private bool DBALFMJLPMM(Guid KOAIMKDICGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5781BE0", Offset = "0x57805E0", VA = "0x185781BE0")]
	private void MKIGOBEMGPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5779D00", Offset = "0x5778700", VA = "0x185779D00")]
	private MOMDKDLAOIH CFKEMKCGAIE()
	{
		return default(MOMDKDLAOIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5778BF0", Offset = "0x57775F0", VA = "0x185778BF0")]
	private void BOBDDLKEKNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5784F30", Offset = "0x5783930", VA = "0x185784F30")]
	private int PKNJOBLCEPM(KeepsakeRoomListDTO BFGKHHJCCFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x577C6F0", Offset = "0x577B0F0", VA = "0x18577C6F0")]
	private int FIDNECBKJMD(DateTime DELGHHAAOHE, DateTime MAAHGEEGOGI, TimeSpan EDPLBPDHEDD, int DDPJOAMBEHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5784700", Offset = "0x5783100", VA = "0x185784700")]
	private void OHDMFLDKKBL(IEnumerable<KeepsakeInstanceDTO> LDMIPNCIOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x577C7C0", Offset = "0x577B1C0", VA = "0x18577C7C0")]
	private void FIIMPDIIDGO(IEnumerable<KeepsakeCollectionRecordDTO> GDEHLCJIEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5778830", Offset = "0x5777230", VA = "0x185778830")]
	private void AJJFLGCENAK(IEnumerable<long> KDMDKKMOKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x121D230", Offset = "0x121BC30", VA = "0x18121D230")]
	private void GPIPOKBPEPA(KeepsakeGlobalConfigDTO FOGIOFGJMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x577D530", Offset = "0x577BF30", VA = "0x18577D530")]
	private bool FPAMGOAPBNF(MOMDKDLAOIH CGNJALEGFFJ, out Guid DJEPEMIFDJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x577E6B0", Offset = "0x577D0B0", VA = "0x18577E6B0")]
	private bool GOBFFOIBBNN(out Guid DJEPEMIFDJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x57781B0", Offset = "0x5776BB0", VA = "0x1857781B0")]
	private bool AAMBKGNLJCL(Guid KOAIMKDICGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x577EB10", Offset = "0x577D510", VA = "0x18577EB10")]
	private IEnumerable<Guid> HJMOIPCBNGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x577DFF0", Offset = "0x577C9F0", VA = "0x18577DFF0")]
	private IEnumerable<KeepsakeInstanceDTO> GEJMEDLEOGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5778B00", Offset = "0x5777500", VA = "0x185778B00")]
	private void BEBLFDCLJBM(Guid KOAIMKDICGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5784D40", Offset = "0x5783740", VA = "0x185784D40")]
	private bool PDEJMCLGAKF(Guid KOAIMKDICGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5783C70", Offset = "0x5782670", VA = "0x185783C70")]
	private void OCDDECCOLCI(Guid KOAIMKDICGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5780BF0", Offset = "0x577F5F0", VA = "0x185780BF0")]
	private void LHHEFOJMODA(MOMDKDLAOIH LNILHBHEFKG, int JMFLGKFHENF, ref Dictionary<MOMDKDLAOIH, int> OCHANCPPMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5779FF0", Offset = "0x57789F0", VA = "0x185779FF0")]
	private int CJAAOIDELHN(MOMDKDLAOIH CGNJALEGFFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x57843C0", Offset = "0x5782DC0", VA = "0x1857843C0")]
	private void OGBJOOHKOEC(KeepsakeInstanceDTO BFDMFLGHIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x577FF90", Offset = "0x577E990", VA = "0x18577FF90")]
	private void KFCCFODHIEE(KeepsakeInstanceDTO BFDMFLGHIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5780370", Offset = "0x577ED70", VA = "0x185780370")]
	private void KLAKKAGCMKB(Guid KOAIMKDICGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x577CAA0", Offset = "0x577B4A0", VA = "0x18577CAA0")]
	private void FKNGPNBCFIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5783840", Offset = "0x5782240", VA = "0x185783840")]
	private void NKDBPGLEOOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x577AC90", Offset = "0x5779690", VA = "0x18577AC90")]
	private void DCMFPNFMIJK(CGNOGDJLAKB CBNFPKLEHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x577A6C0", Offset = "0x57790C0", VA = "0x18577A6C0")]
	private void CLAEDLNKDIN(NNBNEMEGDEH.DLAOICCEMPP NBNOMDAKOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x577A0F0", Offset = "0x5778AF0", VA = "0x18577A0F0")]
	private void CJJKNEHNMBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5780CD0", Offset = "0x577F6D0", VA = "0x185780CD0")]
	private void LHNFOMAIPDF(float DCOHNOOEJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x577A150", Offset = "0x5778B50", VA = "0x18577A150")]
	private void CJOJONBFHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5780880", Offset = "0x577F280", VA = "0x185780880")]
	private bool LAGLNAGKLBL(Guid KOAIMKDICGM, out string NMDHHPGPDBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x577F510", Offset = "0x577DF10", VA = "0x18577F510")]
	private bool JEPLNKMEIMF(Guid KOAIMKDICGM, out KeepsakeCategoryConfigDTO LNILHBHEFKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5783760", Offset = "0x5782160", VA = "0x185783760")]
	private void NJMFKLCDCOI(string JNIGPBNMPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5778720", Offset = "0x5777120", VA = "0x185778720")]
	private bool AIFBMCOGFJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x577CB00", Offset = "0x577B500", VA = "0x18577CB00")]
	private IEnumerable<long> FKPJNMIAKJG(IEnumerable<KeepsakeRoomDTO> LOJPEKKENAN, IEnumerable<KeepsakeRoomListDTO> GDFCFMDEEPB, long ABBGCDLIHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x577D000", Offset = "0x577BA00", VA = "0x18577D000")]
	private bool FMFMAAKHCBF(Guid KOAIMKDICGM, out string NOGDNAGMMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x57791A0", Offset = "0x5777BA0", VA = "0x1857791A0", Slot = "47")]
	public string BOCJPKENMBB(MFLMFFAKBNC AODEEKCJIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x577D7E0", Offset = "0x577C1E0", VA = "0x18577D7E0", Slot = "49")]
	public string FPEICFCHMAL(MFLMFFAKBNC AODEEKCJIPE, long LCIEPBGBKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x577FB30", Offset = "0x577E530", VA = "0x18577FB30", Slot = "48")]
	public string JMFFNEJDHOL(MFLMFFAKBNC AODEEKCJIPE, int CFNMLHJAHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5782080", Offset = "0x5780A80", VA = "0x185782080")]
	private void MLLHEEJCEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5781100", Offset = "0x577FB00", VA = "0x185781100")]
	private void LNBEFILLBIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x577EF10", Offset = "0x577D910", VA = "0x18577EF10")]
	private MFLMFFAKBNC HNJAJOAMGJG(KJEONFEMIIC GMPHMODLCFE)
	{
		return default(MFLMFFAKBNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x577AB30", Offset = "0x5779530", VA = "0x18577AB30")]
	private MFLMFFAKBNC DBAGPFLONPJ(KJEONFEMIIC GMPHMODLCFE)
	{
		return default(MFLMFFAKBNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x577B580", Offset = "0x5779F80", VA = "0x18577B580")]
	internal static string DIFPPOFEJCB(PIILILHPLDO CJDHNLFDLFB, string NCEHBFIBDMI, bool PMNILCJBMID, int DBFCCFLALIB, int NOKCDEJOCHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x577BB70", Offset = "0x577A570", VA = "0x18577BB70", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x577BFD0", Offset = "0x577A9D0", VA = "0x18577BFD0")]
	private IOCLDNFCAPD ECCFDMODFEO(IEIHKFAAJEG OAEMDLGMGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5783E10", Offset = "0x5782810", VA = "0x185783E10")]
	private ABDMBHHIJNK ODHNOMACDND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5781770", Offset = "0x5780170", VA = "0x185781770")]
	private Task MABHKDGPMBI(JILMCFPJPGB FKFCAPAEHKO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x577DC20", Offset = "0x577C620", VA = "0x18577DC20")]
	[AsyncStateMachine(typeof(OFCNHLMDJPO))]
	private Task GAGIDOKNIGN(JILMCFPJPGB FKFCAPAEHKO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5782DD0", Offset = "0x57817D0", VA = "0x185782DD0")]
	private Task MMKGHFNGGEN(JILMCFPJPGB FKFCAPAEHKO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x577F3C0", Offset = "0x577DDC0", VA = "0x18577F3C0")]
	[AsyncStateMachine(typeof(IBAOHKHEOBC))]
	private Task JDLCACGEEKK(string BALNMHDNCIN, TimeSpan OMNNAMIEKJH, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x47E07F0", Offset = "0x47DF1F0", VA = "0x1847E07F0")]
	[CompilerGenerated]
	private void FGDOMOEMNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x577C390", Offset = "0x577AD90", VA = "0x18577C390")]
	[CompilerGenerated]
	private void EHPNKCNPANJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x577F190", Offset = "0x577DB90", VA = "0x18577F190")]
	[CompilerGenerated]
	private bool ILKJCFAJCLL(KeepsakeInstanceDTO GKBCEINHOJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5784580", Offset = "0x5782F80", VA = "0x185784580")]
	[CompilerGenerated]
	private global::ODHJGGEEIEO<Dictionary<MOMDKDLAOIH, int>> OGJLEAKKNNH(Dictionary<Guid, MOMDKDLAOIH> BIMHIPDMHHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5782F00", Offset = "0x5781900", VA = "0x185782F00")]
	[CompilerGenerated]
	private global::ODHJGGEEIEO<Dictionary<MOMDKDLAOIH, int>> NEEEPPFFDHI(Dictionary<Guid, MOMDKDLAOIH> BIMHIPDMHHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x577C370", Offset = "0x577AD70", VA = "0x18577C370")]
	[CompilerGenerated]
	private bool EHAGABDLNOA(KeepsakeRoomListDTO GKBCEINHOJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x577C250", Offset = "0x577AC50", VA = "0x18577C250")]
	[CompilerGenerated]
	private bool EELDPCMCJOE(KeepsakeInstanceDTO GKBCEINHOJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x577CE80", Offset = "0x577B880", VA = "0x18577CE80")]
	[CompilerGenerated]
	private void FMEGFIGGKEG(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<MOMDKDLAOIH, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> NGACGIDBMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5780190", Offset = "0x577EB90", VA = "0x185780190")]
	[CompilerGenerated]
	private void KGDMNOEECMH(string NOGDNAGMMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x577A940", Offset = "0x5779340", VA = "0x18577A940")]
	[CompilerGenerated]
	private Task CPPOBOGNGHO(CancellationToken BEJILHJOPJA)
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
	public class KeepsakesConfig : ScriptableObject, global::GBPBAFKAGPD<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002F")]
			[CompilerGenerated]
			private sealed class HNMFJCFGCBJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
				public HNMFJCFGCBJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x5776540", Offset = "0x5774F40", VA = "0x185776540")]
				internal bool <TryGetKeepsakeTheme>b__0(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x5776540", Offset = "0x5774F40", VA = "0x185776540")]
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
			[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] EDDJEJJDKHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x57773D0", Offset = "0x5775DD0", VA = "0x1857773D0")]
			public bool MPBGDNEEJDK(string KIFEIBMFAAI, out KeepsakeTheme DCIAMLJDNKG)
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5777350", Offset = "0x5775D50", VA = "0x185777350")]
		[JDDIJBKLPJE(GHILFLKBMBN.None)]
		private static void JCIGPGHKKDF(AOONKACGDKK ONILLNPEPMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xDC40C0", Offset = "0xDC2AC0", VA = "0x180DC40C0")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5777070", Offset = "0x5775A70", VA = "0x185777070")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5776D20", Offset = "0x5775720", VA = "0x185776D20")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
