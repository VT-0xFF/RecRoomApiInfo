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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public BHFDDBLFCBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xEF6330", Offset = "0xEF5730", VA = "0x180EF6330")]
		internal bool <Compare>b__0(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xF05730", Offset = "0xF04B30", VA = "0x180F05730")]
		internal bool <Compare>b__1(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xEF6330", Offset = "0xEF5730", VA = "0x180EF6330")]
		internal bool <Compare>b__2(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xF05730", Offset = "0xF04B30", VA = "0x180F05730")]
		internal bool <Compare>b__3(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> KFHMKHNABKC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x756370", Offset = "0x755770", VA = "0x180756370")]
	public NNIJEDCMDIJ(List<KeepsakeCategoryThemePair> BHBHAHMDENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x57466D0", Offset = "0x5745AD0", VA = "0x1857466D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public PPIEIMOEGPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5755740", Offset = "0x5754B40", VA = "0x185755740")]
		internal void <CreateKeepsakeInstanceData>b__4()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x57552A0", Offset = "0x57546A0", VA = "0x1857552A0")]
		internal void <CreateKeepsakeInstanceData>b__2(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5755710", Offset = "0x5754B10", VA = "0x185755710")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public AOCFFDNADHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5743B90", Offset = "0x5742F90", VA = "0x185743B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public HAIIHGHEJBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5745210", Offset = "0x5744610", VA = "0x185745210")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public FIKLDKADLPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5744DF0", Offset = "0x57441F0", VA = "0x185744DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public EKPHGKJCDGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5744610", Offset = "0x5743A10", VA = "0x185744610")]
		internal void <GetAllKeepsakeInstanceIdsForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5744070", Offset = "0x5743470", VA = "0x185744070")]
		internal void <GetAllKeepsakeInstanceIdsForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x57446A0", Offset = "0x5743AA0", VA = "0x1857446A0")]
		internal global::ODHJGGEEIEO<IEnumerable<Guid>> <GetAllKeepsakeInstanceIdsForRoom>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x57443B0", Offset = "0x57437B0", VA = "0x1857443B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public JBKGNLFNKGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x57458D0", Offset = "0x5744CD0", VA = "0x1857458D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public DOEKBPIADOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5744460", Offset = "0x5743860", VA = "0x185744460")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public JEGDDCHKNMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5745A20", Offset = "0x5744E20", VA = "0x185745A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public OAIBOLCNMJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5746970", Offset = "0x5745D70", VA = "0x185746970")]
		internal global::ODHJGGEEIEO<IEnumerable<Guid>> <GetUncollectedKeepsakeInstanceIdsForRoom>b__0(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x22F4140", Offset = "0x22F3540", VA = "0x1822F4140")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public CEGEAJGDDBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5743FE0", Offset = "0x57433E0", VA = "0x185743FE0")]
		internal void <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5744070", Offset = "0x5743470", VA = "0x185744070")]
		internal void <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x57440A0", Offset = "0x57434A0", VA = "0x1857440A0")]
		internal global::ODHJGGEEIEO<Dictionary<Guid, MOMDKDLAOIH>> <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x57443B0", Offset = "0x57437B0", VA = "0x1857443B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public GDDAKCNILGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5744FC0", Offset = "0x57443C0", VA = "0x185744FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public FBPHLLOGEFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5744BA0", Offset = "0x5743FA0", VA = "0x185744BA0")]
		internal bool <GetAllKeepsakeInstanceIdsAndCategoriesForRoom>b__5(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5744C90", Offset = "0x5744090", VA = "0x185744C90")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public FPMAAJJPKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5744F20", Offset = "0x5744320", VA = "0x185744F20")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public IJCLNLMPPGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5745830", Offset = "0x5744C30", VA = "0x185745830")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public IFDMGPKDAKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x57455A0", Offset = "0x57449A0", VA = "0x1857455A0")]
		internal global::ODHJGGEEIEO<Dictionary<Guid, MOMDKDLAOIH>> <GetUncollectedKeepsakeInstanceIdsAndCategoriesForRoom>b__0(Dictionary<Guid, MOMDKDLAOIH> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x22F4140", Offset = "0x22F3540", VA = "0x1822F4140")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public GHDBKLCMNFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5745190", Offset = "0x5744590", VA = "0x185745190")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public AIOMPEOLCKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5743A30", Offset = "0x5742E30", VA = "0x185743A30")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public PFPDABIBAAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x144EB70", Offset = "0x144DF70", VA = "0x18144EB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public FBOGAMMAKNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5744A40", Offset = "0x5743E40", VA = "0x185744A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ONFLDHLNGAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x144EB70", Offset = "0x144DF70", VA = "0x18144EB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public NJEPIPCNABE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5746430", Offset = "0x5745830", VA = "0x185746430")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5746500", Offset = "0x5745900", VA = "0x185746500")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5746500", Offset = "0x5745900", VA = "0x185746500")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public HGPKDGNJJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1032E50", Offset = "0x1032250", VA = "0x181032E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public NKFDCPOIKHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5746600", Offset = "0x5745A00", VA = "0x185746600")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x1114DA0", Offset = "0x11141A0", VA = "0x181114DA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public IFIAJLFJNJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x57457C0", Offset = "0x5744BC0", VA = "0x1857457C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public HPBDLNHAEDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1032E50", Offset = "0x1032250", VA = "0x181032E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public EMJMLGFHCFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x57449B0", Offset = "0x5743DB0", VA = "0x1857449B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public OFFMPCLLNJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1290450", Offset = "0x128F850", VA = "0x181290450")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public DJONPDEHHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x57443D0", Offset = "0x57437D0", VA = "0x1857443D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public BABDCHODMHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5743FA0", Offset = "0x57433A0", VA = "0x185743FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public FHAFCHGLOFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1290450", Offset = "0x128F850", VA = "0x181290450")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public MLOAGLFDDNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5746390", Offset = "0x5745790", VA = "0x185746390")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public HBALHJGCONF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5745240", Offset = "0x5744640", VA = "0x185745240")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public EAHKLAKEHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5744590", Offset = "0x5743990", VA = "0x185744590")]
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
		[Cpp2IlInjected.Address(RVA = "0x5746B10", Offset = "0x5745F10", VA = "0x185746B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5745360", Offset = "0x5744760", VA = "0x185745360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A6950", Offset = "0x9A5D50", VA = "0x1809A6950", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xCCB670", Offset = "0xCCAA70", VA = "0x180CCB670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool EFNKKOKJGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5748B00", Offset = "0x5747F00", VA = "0x185748B00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HFLHGIKCJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x574A5F0", Offset = "0x57499F0", VA = "0x18574A5F0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long IHAKHJAFDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x57509C0", Offset = "0x574FDC0", VA = "0x1857509C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? LKLPNMOLEJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5751D30", Offset = "0x5751130", VA = "0x185751D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool DHHAJBANBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x574B1B0", Offset = "0x574A5B0", VA = "0x18574B1B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> JPBLCPONCBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xEBD500", Offset = "0xEBC900", VA = "0x180EBD500", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> KMJHBDPDPCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xEBBD50", Offset = "0xEBB150", VA = "0x180EBBD50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> HFLFIBOECPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xCD8720", Offset = "0xCD7B20", VA = "0x180CD8720", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> DKJGGHEIFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xEBD470", Offset = "0xEBC870", VA = "0x180EBD470", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> ENEIONOFAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xEBD460", Offset = "0xEBC860", VA = "0x180EBD460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal bool FHAAOBHLLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x10165F0", Offset = "0x10159F0", VA = "0x1810165F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x574D490", Offset = "0x574C890", VA = "0x18574D490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> LLDDLGDHLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x57537F0", Offset = "0x5752BF0", VA = "0x1857537F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x574D670", Offset = "0x574CA70", VA = "0x18574D670", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GKAKNGEKEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x574E6A0", Offset = "0x574DAA0", VA = "0x18574E6A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x574B850", Offset = "0x574AC50", VA = "0x18574B850", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action DNICBHEMMPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x574BC30", Offset = "0x574B030", VA = "0x18574BC30", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5751F40", Offset = "0x5751340", VA = "0x185751F40", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5753FC0", Offset = "0x57533C0", VA = "0x185753FC0")]
	[Preserve]
	internal OHGKCIDFEGK([NotNull][LIKONNNLKGK(null)] CFLJMDJKFAG KLHMFOJGBGN, [NotNull][LIKONNNLKGK(null)] AEJHBGAHGKH DPBFKHPKMAC, [NotNull][LIKONNNLKGK(null)] EEFPCCHHFAP FGKMICHLOIM, [NotNull][LIKONNNLKGK(null)] NHCEBFDFEHN GIDKGIJFGMP, [NotNull][LIKONNNLKGK(null)] CHNNJBMKJLD FKCIDMLJLGP, [NotNull][LIKONNNLKGK(null)] EOALMFOCEOE FDPHPHDPLEL, [NotNull][LIKONNNLKGK(null)] CGCKBDOECOE PBECOPCBNCK, [NotNull][LIKONNNLKGK(null)] NJBDFOIOPMG DIJGJGFMIIJ, [NotNull][LIKONNNLKGK(null)] OGCACIFJDCP KEHCECCODAM, [NotNull][LIKONNNLKGK(null)] EOFMOAKCMLI PEFJLCHAIEA, [NotNull][LIKONNNLKGK(null)] KHOAOKBAEKD LNOBLPCNDLI, [NotNull][LIKONNNLKGK(null)] NJHAAAJKAHC PFJOCILLFIL, [NotNull][LIKONNNLKGK(null)] CACPPPCKNFM IKABJBDBFKA, [NotNull][LIKONNNLKGK(null)] PMONMFEABJI FOICHCFHEIN, [NotNull][LIKONNNLKGK(null)] GIJBKJCAKDE IKEGEABAKFC, [NotNull][LIKONNNLKGK(null)] DHMENGHKMJI BMDOHFOEMDB, [NotNull][LIKONNNLKGK(null)] NHOBFCMCDOK HNGDIECMCEL, [NotNull][LIKONNNLKGK(null)] global::GBPBAFKAGPD<KeepsakesConfig.KeepsakesOptions> MIBGOGGBLGL, [NotNull][LIKONNNLKGK(null)] LGIHGHKPCKA FBJGDFFOGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x574A6B0", Offset = "0x5749AB0", VA = "0x18574A6B0", Slot = "15")]
	public bool DPCOCPMLKIC(List<string> JLKHFCCECIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5751FE0", Offset = "0x57513E0", VA = "0x185751FE0", Slot = "16")]
	public global::ODHJGGEEIEO<Guid> NJHENBLMNFB(MOMDKDLAOIH CGNJALEGFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x574CBC0", Offset = "0x574BFC0", VA = "0x18574CBC0", Slot = "17")]
	public JKAHJLGEFLE GCECEENMEEA(Guid KOAIMKDICGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5753890", Offset = "0x5752C90", VA = "0x185753890", Slot = "18")]
	public JKAHJLGEFLE PBHOACFHAGM(Guid KOAIMKDICGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5753CD0", Offset = "0x57530D0", VA = "0x185753CD0", Slot = "19")]
	public bool PGEDPICMJAH(Guid KOAIMKDICGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x574F0B0", Offset = "0x574E4B0", VA = "0x18574F0B0", Slot = "20")]
	public bool KHCGENJBEHG(Guid KOAIMKDICGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x574E0D0", Offset = "0x574D4D0", VA = "0x18574E0D0")]
	public KeepsakeTheme JCEICMNFGFG(Guid KOAIMKDICGM)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x57471A0", Offset = "0x57465A0", VA = "0x1857471A0")]
	public bool AFJNDDLMINK(MOMDKDLAOIH CGNJALEGFFJ, out KeepsakeTheme DCIAMLJDNKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x57487B0", Offset = "0x5747BB0", VA = "0x1857487B0")]
	public List<KeepsakeTheme> CBIOEEBHBBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x574CF10", Offset = "0x574C310", VA = "0x18574CF10")]
	public int GGNJDHBJCHF(MOMDKDLAOIH CGNJALEGFFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x574F940", Offset = "0x574ED40", VA = "0x18574F940")]
	public MOMDKDLAOIH LDGMCEDNEPE(Guid KOAIMKDICGM)
	{
		return default(MOMDKDLAOIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x574F0E0", Offset = "0x574E4E0", VA = "0x18574F0E0", Slot = "34")]
	public List<MOMDKDLAOIH> KHCMHKDHILB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x574A330", Offset = "0x5749730", VA = "0x18574A330", Slot = "35")]
	public IComparer<MOMDKDLAOIH> DHCHPCJNMAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x574F5D0", Offset = "0x574E9D0", VA = "0x18574F5D0", Slot = "32")]
	public string LACHJCEEFNG(MOMDKDLAOIH CGNJALEGFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x574E530", Offset = "0x574D930", VA = "0x18574E530", Slot = "33")]
	public string JFAEEDFPKIG(MOMDKDLAOIH CGNJALEGFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x574DAC0", Offset = "0x574CEC0", VA = "0x18574DAC0", Slot = "21")]
	public bool HLKGFKGPKNC(Guid KOAIMKDICGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x574FF50", Offset = "0x574F350", VA = "0x18574FF50", Slot = "22")]
	public void LLPHGFGDLFF(Guid KOAIMKDICGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x574A5B0", Offset = "0x57499B0", VA = "0x18574A5B0", Slot = "23")]
	public void DNLLJKIAGFG(MOMDKDLAOIH CGNJALEGFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x574E740", Offset = "0x574DB40", VA = "0x18574E740", Slot = "24")]
	public void JINICEGAGJM(Guid KOAIMKDICGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5747FF0", Offset = "0x57473F0", VA = "0x185747FF0", Slot = "25")]
	public int CAJHGOOPPNJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5748440", Offset = "0x5747840", VA = "0x185748440", Slot = "54")]
	public int CAJHGOOPPNJ(MOMDKDLAOIH CGNJALEGFFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x574D080", Offset = "0x574C480", VA = "0x18574D080", Slot = "31")]
	public global::ODHJGGEEIEO<IEnumerable<Guid>> GKGMLKPFMFL(long LCIEPBGBKGO, long NIGCMMACIIM, MOMDKDLAOIH? CGNJALEGFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5747370", Offset = "0x5746770", VA = "0x185747370", Slot = "30")]
	public global::ODHJGGEEIEO<IEnumerable<Guid>> AFJPAFAJBFB(long LCIEPBGBKGO, long NIGCMMACIIM, MOMDKDLAOIH? CGNJALEGFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5752720", Offset = "0x5751B20", VA = "0x185752720", Slot = "55")]
	public global::ODHJGGEEIEO<Dictionary<Guid, MOMDKDLAOIH>> NNALJOKBNEF(long LCIEPBGBKGO, long NIGCMMACIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x574DE50", Offset = "0x574D250", VA = "0x18574DE50", Slot = "56")]
	public global::ODHJGGEEIEO<Dictionary<Guid, MOMDKDLAOIH>> IIHFBECPMIG(long LCIEPBGBKGO, long NIGCMMACIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x574B290", Offset = "0x574A690", VA = "0x18574B290", Slot = "26")]
	public global::ODHJGGEEIEO<int> ELCLCLEDCMH(long LCIEPBGBKGO, long NIGCMMACIIM, MOMDKDLAOIH? CGNJALEGFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5750100", Offset = "0x574F500", VA = "0x185750100", Slot = "27")]
	public global::ODHJGGEEIEO<int> LNCCFHMLHBG(long LCIEPBGBKGO, long NIGCMMACIIM, MOMDKDLAOIH? CGNJALEGFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5749570", Offset = "0x5748970", VA = "0x185749570", Slot = "28")]
	public global::ODHJGGEEIEO<Dictionary<MOMDKDLAOIH, int>> CNKJNJEAMON(long LCIEPBGBKGO, long NIGCMMACIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x574DD80", Offset = "0x574D180", VA = "0x18574DD80", Slot = "29")]
	public global::ODHJGGEEIEO<Dictionary<MOMDKDLAOIH, int>> ICIMDLFDNIO(long LCIEPBGBKGO, long NIGCMMACIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x574B230", Offset = "0x574A630", VA = "0x18574B230", Slot = "37")]
	public bool EIOBHKLONMN(long LCIEPBGBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5747980", Offset = "0x5746D80", VA = "0x185747980", Slot = "57")]
	public bool BGFIKGCNIFA(long LCIEPBGBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x574D5D0", Offset = "0x574C9D0", VA = "0x18574D5D0", Slot = "38")]
	public bool GPPCOADBEHG(long LCIEPBGBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5750270", Offset = "0x574F670", VA = "0x185750270", Slot = "58")]
	public bool LNMNPJOPOLI(long LCIEPBGBKGO, out NAJOBOOFDDP ABBGOCIEHLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5747680", Offset = "0x5746A80", VA = "0x185747680", Slot = "39")]
	public bool BAAIGJNFKCM(long ABBGCDLIHON, out DateTime APNEFLHJLGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5752E70", Offset = "0x5752270", VA = "0x185752E70", Slot = "40")]
	public long OFNMFBEAAJM(long ABBGCDLIHON)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x574D710", Offset = "0x574CB10", VA = "0x18574D710", Slot = "59")]
	public IEnumerable<int> HHPOMCGDNDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x57477D0", Offset = "0x5746BD0", VA = "0x1857477D0", Slot = "41")]
	public long BDJANPGJEAP(long LCIEPBGBKGO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x574AEA0", Offset = "0x574A2A0", VA = "0x18574AEA0", Slot = "42")]
	public int EDNNGGPJOKN(long ABBGCDLIHON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5747000", Offset = "0x5746400", VA = "0x185747000", Slot = "43")]
	public bool ABPOIBJHJDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5749B50", Offset = "0x5748F50", VA = "0x185749B50", Slot = "44")]
	public bool DDIEGCAAHBD(long ABBGCDLIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5749E10", Offset = "0x5749210", VA = "0x185749E10", Slot = "45")]
	public IEnumerable<long> DENEDCJAFJL(long ABBGCDLIHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x57470F0", Offset = "0x57464F0", VA = "0x1857470F0", Slot = "46")]
	public int ACJOHHANCAK(long ABBGCDLIHON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5749FF0", Offset = "0x57493F0", VA = "0x185749FF0", Slot = "50")]
	public long DFCHHBGOGFK(long GJPNGGPJFMN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x574EAA0", Offset = "0x574DEA0", VA = "0x18574EAA0", Slot = "51")]
	public MOMDKDLAOIH JPJKHLOKOME()
	{
		return default(MOMDKDLAOIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x57499A0", Offset = "0x5748DA0", VA = "0x1857499A0")]
	private bool DBALFMJLPMM(Guid KOAIMKDICGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5750AA0", Offset = "0x574FEA0", VA = "0x185750AA0")]
	private void MKIGOBEMGPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5748B50", Offset = "0x5747F50", VA = "0x185748B50")]
	private MOMDKDLAOIH CFKEMKCGAIE()
	{
		return default(MOMDKDLAOIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x57479E0", Offset = "0x5746DE0", VA = "0x1857479E0")]
	private void BOBDDLKEKNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5753E10", Offset = "0x5753210", VA = "0x185753E10")]
	private int PKNJOBLCEPM(KeepsakeRoomListDTO BFGKHHJCCFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x574B540", Offset = "0x574A940", VA = "0x18574B540")]
	private int FIDNECBKJMD(DateTime DELGHHAAOHE, DateTime MAAHGEEGOGI, TimeSpan EDPLBPDHEDD, int DDPJOAMBEHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x57535E0", Offset = "0x57529E0", VA = "0x1857535E0")]
	private void OHDMFLDKKBL(IEnumerable<KeepsakeInstanceDTO> LDMIPNCIOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x574B610", Offset = "0x574AA10", VA = "0x18574B610")]
	private void FIIMPDIIDGO(IEnumerable<KeepsakeCollectionRecordDTO> GDEHLCJIEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5747620", Offset = "0x5746A20", VA = "0x185747620")]
	private void AJJFLGCENAK(IEnumerable<long> KDMDKKMOKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1066CE0", Offset = "0x10660E0", VA = "0x181066CE0")]
	private void GPIPOKBPEPA(KeepsakeGlobalConfigDTO FOGIOFGJMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x574C380", Offset = "0x574B780", VA = "0x18574C380")]
	private bool FPAMGOAPBNF(MOMDKDLAOIH CGNJALEGFFJ, out Guid DJEPEMIFDJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x574D500", Offset = "0x574C900", VA = "0x18574D500")]
	private bool GOBFFOIBBNN(out Guid DJEPEMIFDJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5746FA0", Offset = "0x57463A0", VA = "0x185746FA0")]
	private bool AAMBKGNLJCL(Guid KOAIMKDICGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x574D960", Offset = "0x574CD60", VA = "0x18574D960")]
	private IEnumerable<Guid> HJMOIPCBNGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x574CE40", Offset = "0x574C240", VA = "0x18574CE40")]
	private IEnumerable<KeepsakeInstanceDTO> GEJMEDLEOGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x57478F0", Offset = "0x5746CF0", VA = "0x1857478F0")]
	private void BEBLFDCLJBM(Guid KOAIMKDICGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5753C20", Offset = "0x5753020", VA = "0x185753C20")]
	private bool PDEJMCLGAKF(Guid KOAIMKDICGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5752B30", Offset = "0x5751F30", VA = "0x185752B30")]
	private void OCDDECCOLCI(Guid KOAIMKDICGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x574FAB0", Offset = "0x574EEB0", VA = "0x18574FAB0")]
	private void LHHEFOJMODA(MOMDKDLAOIH LNILHBHEFKG, int JMFLGKFHENF, ref Dictionary<MOMDKDLAOIH, int> OCHANCPPMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5748E40", Offset = "0x5748240", VA = "0x185748E40")]
	private int CJAAOIDELHN(MOMDKDLAOIH CGNJALEGFFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x57532A0", Offset = "0x57526A0", VA = "0x1857532A0")]
	private void OGBJOOHKOEC(KeepsakeInstanceDTO BFDMFLGHIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x574EE50", Offset = "0x574E250", VA = "0x18574EE50")]
	private void KFCCFODHIEE(KeepsakeInstanceDTO BFDMFLGHIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x574F230", Offset = "0x574E630", VA = "0x18574F230")]
	private void KLAKKAGCMKB(Guid KOAIMKDICGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x574B8F0", Offset = "0x574ACF0", VA = "0x18574B8F0")]
	private void FKNGPNBCFIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5752700", Offset = "0x5751B00", VA = "0x185752700")]
	private void NKDBPGLEOOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5749AE0", Offset = "0x5748EE0", VA = "0x185749AE0")]
	private void DCMFPNFMIJK(CGNOGDJLAKB CBNFPKLEHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5749510", Offset = "0x5748910", VA = "0x185749510")]
	private void CLAEDLNKDIN(NNBNEMEGDEH.DLAOICCEMPP NBNOMDAKOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5748F40", Offset = "0x5748340", VA = "0x185748F40")]
	private void CJJKNEHNMBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x574FB90", Offset = "0x574EF90", VA = "0x18574FB90")]
	private void LHNFOMAIPDF(float DCOHNOOEJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5748FA0", Offset = "0x57483A0", VA = "0x185748FA0")]
	private void CJOJONBFHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x574F740", Offset = "0x574EB40", VA = "0x18574F740")]
	private bool LAGLNAGKLBL(Guid KOAIMKDICGM, out string NMDHHPGPDBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x574E360", Offset = "0x574D760", VA = "0x18574E360")]
	private bool JEPLNKMEIMF(Guid KOAIMKDICGM, out KeepsakeCategoryConfigDTO LNILHBHEFKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5752620", Offset = "0x5751A20", VA = "0x185752620")]
	private void NJMFKLCDCOI(string JNIGPBNMPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5747510", Offset = "0x5746910", VA = "0x185747510")]
	private bool AIFBMCOGFJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x574B950", Offset = "0x574AD50", VA = "0x18574B950")]
	private IEnumerable<long> FKPJNMIAKJG(IEnumerable<KeepsakeRoomDTO> LOJPEKKENAN, IEnumerable<KeepsakeRoomListDTO> GDFCFMDEEPB, long ABBGCDLIHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x574BE50", Offset = "0x574B250", VA = "0x18574BE50")]
	private bool FMFMAAKHCBF(Guid KOAIMKDICGM, out string NOGDNAGMMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5747F90", Offset = "0x5747390", VA = "0x185747F90", Slot = "47")]
	public string BOCJPKENMBB(MFLMFFAKBNC AODEEKCJIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x574C630", Offset = "0x574BA30", VA = "0x18574C630", Slot = "49")]
	public string FPEICFCHMAL(MFLMFFAKBNC AODEEKCJIPE, long LCIEPBGBKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x574E980", Offset = "0x574DD80", VA = "0x18574E980", Slot = "48")]
	public string JMFFNEJDHOL(MFLMFFAKBNC AODEEKCJIPE, int CFNMLHJAHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5750F40", Offset = "0x5750340", VA = "0x185750F40")]
	private void MLLHEEJCEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x574FFC0", Offset = "0x574F3C0", VA = "0x18574FFC0")]
	private void LNBEFILLBIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x574DD60", Offset = "0x574D160", VA = "0x18574DD60")]
	private MFLMFFAKBNC HNJAJOAMGJG(KJEONFEMIIC GMPHMODLCFE)
	{
		return default(MFLMFFAKBNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5749980", Offset = "0x5748D80", VA = "0x185749980")]
	private MFLMFFAKBNC DBAGPFLONPJ(KJEONFEMIIC GMPHMODLCFE)
	{
		return default(MFLMFFAKBNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x574A3D0", Offset = "0x57497D0", VA = "0x18574A3D0")]
	internal static string DIFPPOFEJCB(PIILILHPLDO CJDHNLFDLFB, string NCEHBFIBDMI, bool PMNILCJBMID, int DBFCCFLALIB, int NOKCDEJOCHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x574A9C0", Offset = "0x5749DC0", VA = "0x18574A9C0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x574AE20", Offset = "0x574A220", VA = "0x18574AE20")]
	private IOCLDNFCAPD ECCFDMODFEO(IEIHKFAAJEG OAEMDLGMGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5752CD0", Offset = "0x57520D0", VA = "0x185752CD0")]
	private ABDMBHHIJNK ODHNOMACDND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5750630", Offset = "0x574FA30", VA = "0x185750630")]
	private Task MABHKDGPMBI(JILMCFPJPGB FKFCAPAEHKO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x574CA70", Offset = "0x574BE70", VA = "0x18574CA70")]
	[AsyncStateMachine(typeof(OFCNHLMDJPO))]
	private Task GAGIDOKNIGN(JILMCFPJPGB FKFCAPAEHKO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5751C90", Offset = "0x5751090", VA = "0x185751C90")]
	private Task MMKGHFNGGEN(JILMCFPJPGB FKFCAPAEHKO, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x574E210", Offset = "0x574D610", VA = "0x18574E210")]
	[AsyncStateMachine(typeof(IBAOHKHEOBC))]
	private Task JDLCACGEEKK(string BALNMHDNCIN, TimeSpan OMNNAMIEKJH, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x46ACB00", Offset = "0x46ABF00", VA = "0x1846ACB00")]
	[CompilerGenerated]
	private void FGDOMOEMNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x574B1E0", Offset = "0x574A5E0", VA = "0x18574B1E0")]
	[CompilerGenerated]
	private void EHPNKCNPANJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x574DFE0", Offset = "0x574D3E0", VA = "0x18574DFE0")]
	[CompilerGenerated]
	private bool ILKJCFAJCLL(KeepsakeInstanceDTO GKBCEINHOJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5753460", Offset = "0x5752860", VA = "0x185753460")]
	[CompilerGenerated]
	private global::ODHJGGEEIEO<Dictionary<MOMDKDLAOIH, int>> OGJLEAKKNNH(Dictionary<Guid, MOMDKDLAOIH> BIMHIPDMHHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5751DC0", Offset = "0x57511C0", VA = "0x185751DC0")]
	[CompilerGenerated]
	private global::ODHJGGEEIEO<Dictionary<MOMDKDLAOIH, int>> NEEEPPFFDHI(Dictionary<Guid, MOMDKDLAOIH> BIMHIPDMHHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x574B1C0", Offset = "0x574A5C0", VA = "0x18574B1C0")]
	[CompilerGenerated]
	private bool EHAGABDLNOA(KeepsakeRoomListDTO GKBCEINHOJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x574B0A0", Offset = "0x574A4A0", VA = "0x18574B0A0")]
	[CompilerGenerated]
	private bool EELDPCMCJOE(KeepsakeInstanceDTO GKBCEINHOJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x574BCD0", Offset = "0x574B0D0", VA = "0x18574BCD0")]
	[CompilerGenerated]
	private void FMEGFIGGKEG(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<MOMDKDLAOIH, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> NGACGIDBMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x574F050", Offset = "0x574E450", VA = "0x18574F050")]
	[CompilerGenerated]
	private void KGDMNOEECMH(string NOGDNAGMMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5749790", Offset = "0x5748B90", VA = "0x185749790")]
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
				[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
				public HNMFJCFGCBJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x5745330", Offset = "0x5744730", VA = "0x185745330")]
				internal bool <TryGetKeepsakeTheme>b__0(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x5745330", Offset = "0x5744730", VA = "0x185745330")]
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
			[Cpp2IlInjected.Address(RVA = "0x756370", Offset = "0x755770", VA = "0x180756370")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] EDDJEJJDKHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x57461C0", Offset = "0x57455C0", VA = "0x1857461C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5746140", Offset = "0x5745540", VA = "0x185746140")]
		[JDDIJBKLPJE(GHILFLKBMBN.None)]
		private static void JCIGPGHKKDF(AOONKACGDKK ONILLNPEPMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xC5D680", Offset = "0xC5CA80", VA = "0x180C5D680")]
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
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5745E60", Offset = "0x5745260", VA = "0x185745E60")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5745B10", Offset = "0x5744F10", VA = "0x185745B10")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
