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
public enum MFHMLDIDMDM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[COEMNPLIPJN]
public class PBJMNAOGBKM : ODKPCJMCDFP, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct NPCMNKAEJAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string DOEMEHEKOAC = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string PDLDHFMMJBG = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string DGJJDJOPFIF = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string EPDHCGEMDHO = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public const string EANIDBDNHFD = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string OCENDDHKCEJ = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string LOHOCKBGPEN = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public const string AOHNDHHECIG = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public const string ODNNGKCAIFH = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string HKDCLJBPFFI = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string CKNHLKNKKJG = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class LMHPJHNOCEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public PBJMNAOGBKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public LMHPJHNOCEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E9E0", Offset = "0x5E3D3E0", VA = "0x185E3E9E0")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class CJBOBGMCGOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public PBJMNAOGBKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public CJBOBGMCGOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D5A0", Offset = "0x5E3BFA0", VA = "0x185E3D5A0")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D630", Offset = "0x5E3C030", VA = "0x185E3D630")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D660", Offset = "0x5E3C060", VA = "0x185E3D660")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D850", Offset = "0x5E3C250", VA = "0x185E3D850")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D850", Offset = "0x5E3C250", VA = "0x185E3D850")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__4(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BIJPAFDJGEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public PBJMNAOGBKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public BIJPAFDJGEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D3D0", Offset = "0x5E3BDD0", VA = "0x185E3D3D0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D4A0", Offset = "0x5E3BEA0", VA = "0x185E3D4A0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D4A0", Offset = "0x5E3BEA0", VA = "0x185E3D4A0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class NJDFCOFBDGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public NJDFCOFBDGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x10FACE0", Offset = "0x10F96E0", VA = "0x1810FACE0")]
		internal bool <GetHighlightKeepsakeRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class ACDELHNKEDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ACDELHNKEDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D260", Offset = "0x5E3BC60", VA = "0x185E3D260")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x131A5F0", Offset = "0x1318FF0", VA = "0x18131A5F0")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__1(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class LHPNFOIKAGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public LHPNFOIKAGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E970", Offset = "0x5E3D370", VA = "0x185E3E970")]
		internal bool <GetKeepsakeRoomListUpsellItemPurchasableGiftDropId>b__0(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class BBFMHPGHHEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public BBFMHPGHHEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x10FACE0", Offset = "0x10F96E0", VA = "0x1810FACE0")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class AJAPBMADPLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public AJAPBMADPLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D330", Offset = "0x5E3BD30", VA = "0x185E3D330")]
		internal bool <TryGetNextOrphanedKeepsakeInstance>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EPGLOLJJFDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public EPGLOLJJFDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D8F0", Offset = "0x5E3C2F0", VA = "0x185E3D8F0")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class JOGLICKFJAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public JOGLICKFJAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E090", Offset = "0x5E3CA90", VA = "0x185E3E090")]
		internal bool <GetKeepsakeRoomIdsInList>b__0(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class DCLLOIEALBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public JOGLICKFJAM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public DCLLOIEALBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D870", Offset = "0x5E3C270", VA = "0x185E3D870")]
		internal bool <GetKeepsakeRoomIdsInList>b__3(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct HOJLILEKDPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public PBJMNAOGBKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public FDMJKHLGKCI args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DC00", Offset = "0x5E3C600", VA = "0x185E3DC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct HFBAEGMOIHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public PBJMNAOGBKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D9C0", Offset = "0x5E3C3C0", VA = "0x185E3D9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const int GCPADHFNKAL = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime FGGOBILEFFE;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const int NCJGOMPOJIP = 3;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private const long CMLKLGNNDKH = -1L;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const char HNDBIOIAFHC = '|';

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BCEJEKKFIKE IEKADMBNEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly MKLBOMCBLIM HAGCJLIHFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly MCKMILNBOFF EKJNIGCJFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly KFEGFNDEFCK PFMPHFCDMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly OBIAGMHMIFG BPCKLHHCJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly BPCIJKPKDIK MIFCHNOACGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly LBNBLMOGAPL JJCLJDAGLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly ONLFOKFFMFG LNMHPEDOLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly JBILAOEAFJM NMGCJMONNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly LJGPNFMJBGC FIFFMGKJGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly BAGKCKOOHBA HBALDFAMNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CFFMKOPHPIE IDEKKAOLILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CLLLOGMEENJ IGGPKGPNHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly BCBGJMJKHDL BNNFECLLHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly ONFMLJNJKGK AJPNPHJCCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly global::AKLIDJJNIMC<KeepsakesConfig.KeepsakesOptions> KNNPANGLJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly ALJDLEMICMK MLDKGMPFOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> KGELBDNBNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> HLJPBCPGPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<long> HLJPLELDEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int FJLPADACFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashSet<Guid> GDKKIABLEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly IDisposable CCDGEOLBANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Task PKBDDPGIFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private long? KPCEBAKKENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private KeepsakeProgressionEventInstancesDTO KDBAEOEONOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private global::OHPLDOPGNGG<KeepsakeProgressionEventInstancesDTO> JBEJEJNAOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<JMBDBCEJBDG, KeepsakeCategoryConfigDTO> GJGPJMKFFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private KeepsakeGlobalConfigDTO CJJGPCJMOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private HashSet<long> KEFLKKEIGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> BAEGGACENHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> JLADPJPEDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<KeepsakeRoomListDTO> HILGIMAHKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> MKJECMEAMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, string> MIOPNGCCMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, DateTime> EIFFNFAKCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> IFGMPEAGEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, List<KeepsakeRoomDTO>> BCEHIIDDJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Dictionary<long, long> GPLOBBBIPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly List<string> DGPEDBJCNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private DateTime GFEGBOKEHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly IDisposable IIHLJMKGMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private bool NBDFNNPKJEK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MPALGLOKMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6C1030", Offset = "0x6BFA30", VA = "0x1806C1030", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA2B870", Offset = "0xA2A270", VA = "0x180A2B870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OGMAGGGMAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E44430", Offset = "0x5E42E30", VA = "0x185E44430", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PFFGEHLGJKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E40180", Offset = "0x5E3EB80", VA = "0x185E40180", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long PJONBLNGPEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D90", Offset = "0x5E40790", VA = "0x185E41D90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? ACMEBFHIAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E48010", Offset = "0x5E46A10", VA = "0x185E48010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool COOCBLNFEEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E44F90", Offset = "0x5E43990", VA = "0x185E44F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> PMKPKONAEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x105FF90", Offset = "0x105E990", VA = "0x18105FF90", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> MJLALCNJFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xCB6250", Offset = "0xCB4C50", VA = "0x180CB6250", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> KFDFAPMELNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x900EF0", Offset = "0x8FF8F0", VA = "0x180900EF0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> NDJAKHJLFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x900F00", Offset = "0x8FF900", VA = "0x180900F00", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> AIELMCFFAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x900EB0", Offset = "0x8FF8B0", VA = "0x180900EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal bool AEKNGENJNHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xF532D0", Offset = "0xF51CD0", VA = "0x180F532D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E45BB0", Offset = "0x5E445B0", VA = "0x185E45BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> MHBDMNIGMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5E452F0", Offset = "0x5E43CF0", VA = "0x185E452F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E42D80", Offset = "0x5E41780", VA = "0x185E42D80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action ALKLDPCFPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E3EF20", Offset = "0x5E3D920", VA = "0x185E3EF20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5E42B40", Offset = "0x5E41540", VA = "0x185E42B40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action MMJGIJOJALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5E3EE20", Offset = "0x5E3D820", VA = "0x185E3EE20", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E42C90", Offset = "0x5E41690", VA = "0x185E42C90", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E480A0", Offset = "0x5E46AA0", VA = "0x185E480A0")]
	[Preserve]
	internal PBJMNAOGBKM([NotNull][HGGCKJALFAG(null)] BCEJEKKFIKE IEKADMBNEFG, [NotNull][HGGCKJALFAG(null)] CBLDPOHKEHA FOFHLLPJCMD, [NotNull][HGGCKJALFAG(null)] MKLBOMCBLIM HAGCJLIHFBL, [NotNull][HGGCKJALFAG(null)] MCKMILNBOFF EKJNIGCJFON, [NotNull][HGGCKJALFAG(null)] KFEGFNDEFCK PFMPHFCDMGP, [NotNull][HGGCKJALFAG(null)] OBIAGMHMIFG BPCKLHHCJGL, [NotNull][HGGCKJALFAG(null)] BPCIJKPKDIK MIFCHNOACGK, [NotNull][HGGCKJALFAG(null)] LBNBLMOGAPL JJCLJDAGLPF, [NotNull][HGGCKJALFAG(null)] ONLFOKFFMFG LNMHPEDOLKI, [NotNull][HGGCKJALFAG(null)] IIFNDEHHOAH BOFEDHMKJHD, [NotNull][HGGCKJALFAG(null)] JBILAOEAFJM NMGCJMONNEI, [NotNull][HGGCKJALFAG(null)] LJGPNFMJBGC FIFFMGKJGLL, [NotNull][HGGCKJALFAG(null)] BAGKCKOOHBA HBALDFAMNJM, [NotNull][HGGCKJALFAG(null)] CFFMKOPHPIE IDEKKAOLILI, [NotNull][HGGCKJALFAG(null)] CLLLOGMEENJ IGGPKGPNHKF, [NotNull][HGGCKJALFAG(null)] BCBGJMJKHDL BNNFECLLHDL, [NotNull][HGGCKJALFAG(null)] ONFMLJNJKGK AJPNPHJCCAA, [NotNull][HGGCKJALFAG(null)] global::AKLIDJJNIMC<KeepsakesConfig.KeepsakesOptions> KNNPANGLJLF, [NotNull][HGGCKJALFAG(null)] ALJDLEMICMK MLDKGMPFOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E46FB0", Offset = "0x5E459B0", VA = "0x185E46FB0", Slot = "15")]
	public bool OFPCIANFLNN(List<string> FPDBMBKDMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E40B70", Offset = "0x5E3F570", VA = "0x185E40B70", Slot = "16")]
	public global::OHPLDOPGNGG<Guid> DFGEOEGIJNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E474C0", Offset = "0x5E45EC0", VA = "0x185E474C0", Slot = "42")]
	public GPMDAFELAJF OIMMJMOKPLE(Guid JFGACONIIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F9C0", Offset = "0x5E3E3C0", VA = "0x185E3F9C0", Slot = "17")]
	public GPMDAFELAJF CANNBLOJEIJ(Guid JFGACONIIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E47740", Offset = "0x5E46140", VA = "0x185E47740", Slot = "18")]
	public bool ONNFOBILPEF(Guid JFGACONIIHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E43750", Offset = "0x5E42150", VA = "0x185E43750", Slot = "19")]
	public bool JBDEFCFOPHL(Guid JFGACONIIHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E45660", Offset = "0x5E44060", VA = "0x185E45660")]
	public KeepsakeTheme NCBMOLBPIHB(Guid JFGACONIIHD)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E45780", Offset = "0x5E44180", VA = "0x185E45780")]
	public KeepsakeTheme NCBMOLBPIHB(JMBDBCEJBDG PJAPDBPFHAL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E479A0", Offset = "0x5E463A0", VA = "0x185E479A0", Slot = "20")]
	public bool PAEBAELBBDB(Guid JFGACONIIHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E45390", Offset = "0x5E43D90", VA = "0x185E45390", Slot = "21")]
	public void MNLGPICFFEG(Guid JFGACONIIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E42A90", Offset = "0x5E41490", VA = "0x185E42A90", Slot = "22")]
	public void GFHKFMOBHBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E44FC0", Offset = "0x5E439C0", VA = "0x185E44FC0", Slot = "23")]
	public void LPJCFAFKCEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E45940", Offset = "0x5E44340", VA = "0x185E45940", Slot = "24")]
	public int NFHABNOGFCA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E406A0", Offset = "0x5E3F0A0", VA = "0x185E406A0", Slot = "25")]
	public global::OHPLDOPGNGG<int> DABGOHOJAGI(long ANAJKMBCHFB, long PHLFJKJOMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E43520", Offset = "0x5E41F20", VA = "0x185E43520", Slot = "27")]
	public bool IGKGOEBINLJ(long ANAJKMBCHFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E46BC0", Offset = "0x5E455C0", VA = "0x185E46BC0", Slot = "43")]
	public bool OFGDNBKGECJ(long ANAJKMBCHFB, out HGGIACOGIHC NNOIIBKHGON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E44E40", Offset = "0x5E43840", VA = "0x185E44E40", Slot = "28")]
	public bool LDEEIAODKJI(long OKMLGDLHGFI, out DateTime HGJCCLLJDAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F020", Offset = "0x5E3DA20", VA = "0x185E3F020", Slot = "29")]
	public long BCAHPLHLJNJ(long OKMLGDLHGFI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E416A0", Offset = "0x5E400A0", VA = "0x185E416A0", Slot = "44")]
	public IEnumerable<int> EHAOMILHKGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E47880", Offset = "0x5E46280", VA = "0x185E47880", Slot = "30")]
	public long OOBCFFLCDPL(long ANAJKMBCHFB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E44230", Offset = "0x5E42C30", VA = "0x185E44230", Slot = "31")]
	public int JKKAKIAILIF(long OKMLGDLHGFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E45200", Offset = "0x5E43C00", VA = "0x185E45200", Slot = "32")]
	public bool MKKEAPLJOJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E403E0", Offset = "0x5E3EDE0", VA = "0x185E403E0", Slot = "33")]
	public bool DAAKEGJBIDI(long OKMLGDLHGFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FF40", Offset = "0x5E3E940", VA = "0x185E3FF40", Slot = "34")]
	public IEnumerable<long> CIECPDKKIFG(long OKMLGDLHGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E42BE0", Offset = "0x5E415E0", VA = "0x185E42BE0", Slot = "35")]
	public int HCGBPIPPCBN(long OKMLGDLHGFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E40E00", Offset = "0x5E3F800", VA = "0x185E40E00", Slot = "39")]
	public long DHDIJMDHHHO(long FIOCONBANAA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E43AD0", Offset = "0x5E424D0", VA = "0x185E43AD0")]
	private void JJJBOLDEMOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FD70", Offset = "0x5E3E770", VA = "0x185E3FD70")]
	private int CCFAAPCAMAI(KeepsakeRoomListDTO CIDAFHAFGBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E44480", Offset = "0x5E42E80", VA = "0x185E44480")]
	private int KDGCFLIKEAN(DateTime LFHDFPJMFED, DateTime HHBNGHJMDLG, TimeSpan AAGCJJILOMK, int OADPEMMEBDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E44550", Offset = "0x5E42F50", VA = "0x185E44550")]
	private void KEKGAIIFEKO(IEnumerable<KeepsakeInstanceDTO> KGELBDNBNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5E46070", Offset = "0x5E44A70", VA = "0x185E46070")]
	private void NLJIDCKKMLA(IEnumerable<KeepsakeCollectionRecordDTO> PGAFOPLFIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E451A0", Offset = "0x5E43BA0", VA = "0x185E451A0")]
	private void MHDLCAFCIHA(IEnumerable<long> BGOMONMIHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5E40240", Offset = "0x5E3EC40", VA = "0x185E40240")]
	private void CMGKODLNEAA(IEnumerable<KeepsakeCategoryConfigDTO> FEACCCIJAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xF43A50", Offset = "0xF42450", VA = "0x180F43A50")]
	private void BAPFIGFDEDM(KeepsakeGlobalConfigDTO CJJGPCJMOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5E45C20", Offset = "0x5E44620", VA = "0x185E45C20")]
	private bool NKBJGOAECAO(out Guid FNJEBGJJJPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5E46470", Offset = "0x5E44E70", VA = "0x185E46470")]
	private void NPICALIIACG(KeepsakeInstanceDTO AADHDEKOEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E472C0", Offset = "0x5E45CC0", VA = "0x185E472C0")]
	private void OHFFPHCHFIG(KeepsakeInstanceDTO AADHDEKOEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E46370", Offset = "0x5E44D70", VA = "0x185E46370")]
	private void NMPANCICEGF(Guid JFGACONIIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EFC0", Offset = "0x5E3D9C0", VA = "0x185E3EFC0")]
	private void BAAEOMLGLNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E44FA0", Offset = "0x5E439A0", VA = "0x185E44FA0")]
	private void LNGAJHENEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5E43A60", Offset = "0x5E42460", VA = "0x185E43A60")]
	private void JFOJJCKOGND(BHPLPOAJICO OENKJBHANFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E41640", Offset = "0x5E40040", VA = "0x185E41640")]
	private void EAKEOLAFKOD(HBMFBGBNLOA.JKGBNOEOLHN LAFPICAOEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5E41CE0", Offset = "0x5E406E0", VA = "0x185E41CE0")]
	private void EJAEEJBJCCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5E43160", Offset = "0x5E41B60", VA = "0x185E43160")]
	private void IGIICKNCCFO(float OEOLHIABJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5E46650", Offset = "0x5E45050", VA = "0x185E46650")]
	private void OFBAJOKPKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F7D0", Offset = "0x5E3E1D0", VA = "0x185E3F7D0")]
	private bool BNOOMOCEIAF(Guid JFGACONIIHD, out string ENKGFFGFMPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5E43580", Offset = "0x5E41F80", VA = "0x185E43580")]
	private bool IOHHOOAOEFJ(Guid JFGACONIIHD, out KeepsakeCategoryConfigDTO HFGOCHGBNIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5E44970", Offset = "0x5E43370", VA = "0x185E44970")]
	private void KOBMDCBLNKE(string LNIAFAFIFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5E45F60", Offset = "0x5E44960", VA = "0x185E45F60")]
	private bool NLAFJJNNAHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5E43780", Offset = "0x5E42180", VA = "0x185E43780")]
	private IEnumerable<long> JEFEOPCMCKC(IEnumerable<KeepsakeRoomDTO> MDALCPLGBAC, IEnumerable<KeepsakeRoomListDTO> JGEKKPEHBMB, long OKMLGDLHGFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E44A50", Offset = "0x5E43450", VA = "0x185E44A50")]
	private bool KOLEKACPBAF(Guid JFGACONIIHD, out string IMHLNJJFNDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5E40120", Offset = "0x5E3EB20", VA = "0x185E40120", Slot = "36")]
	public string CKLIECAAHKL(FHDJGBABMHM BGFBMDHHLJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5E47BD0", Offset = "0x5E465D0", VA = "0x185E47BD0", Slot = "38")]
	public string PAEKFPDPJJC(FHDJGBABMHM BGFBMDHHLJO, long ANAJKMBCHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E45080", Offset = "0x5E43A80", VA = "0x185E45080", Slot = "37")]
	public string MFOFFGHAIMH(FHDJGBABMHM BGFBMDHHLJO, int GCEILKANEHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E41E70", Offset = "0x5E40870", VA = "0x185E41E70")]
	private void GDOIDJECEHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F520", Offset = "0x5E3DF20", VA = "0x185E3F520")]
	private void BDADAPCIPFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E46630", Offset = "0x5E45030", VA = "0x185E46630")]
	private FHDJGBABMHM OEHFCOMBPFA(FIJLGDENDPM KMHDIJMGJND)
	{
		return default(FHDJGBABMHM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E46450", Offset = "0x5E44E50", VA = "0x185E46450")]
	private FHDJGBABMHM NOCLEPEFKNI(FIJLGDENDPM KMHDIJMGJND)
	{
		return default(FHDJGBABMHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F640", Offset = "0x5E3E040", VA = "0x185E3F640")]
	internal static string BFNCHDPDPJN(HKCIFCEBMMP JKAGLPLDAPA, string NAFAHDGIBML, bool ODALHNMMCNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5E411E0", Offset = "0x5E3FBE0", VA = "0x185E411E0", Slot = "40")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5E41140", Offset = "0x5E3FB40", VA = "0x185E41140")]
	private MPFEOFKMCLF DINHDIILCHH(BNMLLFBMDOA AMEKGOPDGPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5E461D0", Offset = "0x5E44BD0", VA = "0x185E461D0")]
	private NAIAMOPHAKF NMGOBKOLCAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5E42E20", Offset = "0x5E41820", VA = "0x185E42E20")]
	private Task IDJMELLOJIE(FDMJKHLGKCI KGNEMFGHDAD, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5E440E0", Offset = "0x5E42AE0", VA = "0x185E440E0")]
	[AsyncStateMachine(typeof(HOJLILEKDPO))]
	private Task JKFDHFMDHJF(FDMJKHLGKCI KGNEMFGHDAD, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5E42AB0", Offset = "0x5E414B0", VA = "0x185E42AB0")]
	private Task GIEPDDFBBIL(FDMJKHLGKCI KGNEMFGHDAD, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5E43F90", Offset = "0x5E42990", VA = "0x185E43F90")]
	[AsyncStateMachine(typeof(HFBAEGMOIHI))]
	private Task JJMHBOGPBFG(string EJEIJOMMNGK, TimeSpan GHNBICMEHFJ, CancellationToken KAKEKEHNCME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5E411C0", Offset = "0x5E3FBC0", VA = "0x185E411C0")]
	[CompilerGenerated]
	private void NJDJKMPMPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5E42D30", Offset = "0x5E41730", VA = "0x185E42D30")]
	[CompilerGenerated]
	private void HOMFGAEAEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E418F0", Offset = "0x5E402F0", VA = "0x185E418F0")]
	[CompilerGenerated]
	private void EHPBAGOLANL(string IMHLNJJFNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E411C0", Offset = "0x5E3FBC0", VA = "0x185E411C0")]
	[CompilerGenerated]
	private void DIPHGBCDOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E41D40", Offset = "0x5E40740", VA = "0x185E41D40")]
	[CompilerGenerated]
	private void FIBNAKCONCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F430", Offset = "0x5E3DE30", VA = "0x185E3F430")]
	[CompilerGenerated]
	private bool BCBOJHOJHOO(KeepsakeInstanceDTO MEALLDFELFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FF20", Offset = "0x5E3E920", VA = "0x185E3FF20")]
	[CompilerGenerated]
	private bool CIBDCMKNGOK(KeepsakeRoomListDTO MEALLDFELFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5E45400", Offset = "0x5E43E00", VA = "0x185E45400")]
	[CompilerGenerated]
	private void MPOPMGHBKKC(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> BPDJKLHLAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EEC0", Offset = "0x5E3D8C0", VA = "0x185E3EEC0")]
	[CompilerGenerated]
	private void AIDIIKIAOAJ(string IMHLNJJFNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5E44780", Offset = "0x5E43180", VA = "0x185E44780")]
	[CompilerGenerated]
	private Task KJMGGIMHOAD(CancellationToken MFOGHGEPJIG)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct KeepsakeTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public string ThemeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Header("Pickup")]
		public string PickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public GameObject PickupPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AudioClip PickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float PickupSfxVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Header("Colors")]
		public bool UseCustomColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Color BeamColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Color BaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Header("Looping Sound")]
		public AudioClip LoopingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public float LoopingSfxVolume;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class KeepsakesConfig : ScriptableObject, global::AKLIDJJNIMC<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class GDBPFEPAEPM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
				public GDBPFEPAEPM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x5E3D990", Offset = "0x5E3C390", VA = "0x185E3D990")]
				internal bool <GetKeepsakeTheme>b__0(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6C1F40", Offset = "0x6C0940", VA = "0x1806C1F40")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] BANECEPHCBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x5E3E830", Offset = "0x5E3D230", VA = "0x185E3E830")]
			public KeepsakeTheme NCBMOLBPIHB(string FHDKANDNFKC)
			{
				return default(KeepsakeTheme);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public KeepsakesOptions Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E7B0", Offset = "0x5E3D1B0", VA = "0x185E3E7B0")]
		[CJJNALDLMHL(HFKENCJEONK.None)]
		private static void AMHBNEJDOHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xE1BFB0", Offset = "0xE1A9B0", VA = "0x180E1BFB0")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class KEBPIDDMFLP
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static byte[] PACJNBAODEE;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static int CIPMBADAHHP;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static int EAOHPIEEBJK;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static BigInteger CAFOPFCNDHG;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KEBPIDDMFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E4D0", Offset = "0x5E3CED0", VA = "0x185E3E4D0")]
	private static string PBGMOKJNJDM(byte[] DLAMIJMLOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E180", Offset = "0x5E3CB80", VA = "0x185E3E180")]
	public static string NPAMJBENNGG(byte[] FMIGDHLBIKP, bool BLHGHBBBDBI)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
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
