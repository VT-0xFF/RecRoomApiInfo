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
public enum DMONHIFJPCH
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[PLPLLHJOFBE]
public class ELGFFADEKGO : AOCHACKAKMO, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct KGPMOPLKOAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string IAJODOMMAEH = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string KDHNPGLJCLD = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string LANPNMFNDFJ = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string LKBELMLKOLC = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public const string MKEJNKJAEBJ = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string BCIABLDFBNC = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string CCGALGDENGB = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public const string GEDPJNKAGGP = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public const string FAMGDODJLNK = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string MKFHKBKNGCP = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string HBINHNAAOGF = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class EOGJIDLMAGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public ELGFFADEKGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public EOGJIDLMAGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D710", Offset = "0x5E3C910", VA = "0x185E3D710")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class PAKELNFHDKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public ELGFFADEKGO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public PAKELNFHDKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E670", Offset = "0x5E3D870", VA = "0x185E3E670")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E700", Offset = "0x5E3D900", VA = "0x185E3E700")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E730", Offset = "0x5E3D930", VA = "0x185E3E730")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E920", Offset = "0x5E3DB20", VA = "0x185E3E920")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E920", Offset = "0x5E3DB20", VA = "0x185E3E920")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__4(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BFGCNICLAGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public ELGFFADEKGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public BFGCNICLAGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5E32980", Offset = "0x5E31B80", VA = "0x185E32980")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5E32A50", Offset = "0x5E31C50", VA = "0x185E32A50")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E32A50", Offset = "0x5E31C50", VA = "0x185E32A50")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class ANPOEJEHJMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public ANPOEJEHJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x109FA10", Offset = "0x109EC10", VA = "0x18109FA10")]
		internal bool <GetHighlightKeepsakeRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class MGNEKOMPCGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public MGNEKOMPCGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E4D0", Offset = "0x5E3D6D0", VA = "0x185E3E4D0")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x133C980", Offset = "0x133BB80", VA = "0x18133C980")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__1(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class PMJNOLFEJGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public PMJNOLFEJGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E940", Offset = "0x5E3DB40", VA = "0x185E3E940")]
		internal bool <GetKeepsakeRoomListUpsellItemPurchasableGiftDropId>b__0(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LNMHODIBDKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public LNMHODIBDKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x109FA10", Offset = "0x109EC10", VA = "0x18109FA10")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BHJKBANFMBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public BHJKBANFMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5E32B50", Offset = "0x5E31D50", VA = "0x185E32B50")]
		internal bool <TryGetNextOrphanedKeepsakeInstance>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MKECGMMAPLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public MKECGMMAPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E5A0", Offset = "0x5E3D7A0", VA = "0x185E3E5A0")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class HDEHBHNNDMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public HDEHBHNNDMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DB50", Offset = "0x5E3CD50", VA = "0x185E3DB50")]
		internal bool <GetKeepsakeRoomIdsInList>b__0(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class DBLNLLGIGHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public HDEHBHNNDMD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public DBLNLLGIGHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5E32BF0", Offset = "0x5E31DF0", VA = "0x185E32BF0")]
		internal bool <GetKeepsakeRoomIdsInList>b__3(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct LLICMDNCHMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public ELGFFADEKGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public HBMEPODFBHF args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E040", Offset = "0x5E3D240", VA = "0x185E3E040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6CF320", Offset = "0x6CE520", VA = "0x1806CF320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct JCECFPMMHFL : IAsyncStateMachine
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
		public ELGFFADEKGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DC40", Offset = "0x5E3CE40", VA = "0x185E3DC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6CF320", Offset = "0x6CE520", VA = "0x1806CF320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const int LEJBFDDANIO = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime CACEOHJECEO;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const int JGJCEGKKLEH = 3;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private const long DJCIFEMDADN = -1L;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const char GMCJIFBJMJK = '|';

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JNEBLLOBHEL OHGLBLOPJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly CJKLDADOIFM GEAANOAHCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly OKAIHDNNLHF FIGOFILOBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly NGNNBOKLLHC OFFJDAFLINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LLIEKCMACKC IMJGFHGLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly EPODBGNLFGN JJMBMPNIOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly HKINNJHLDGA DIMCABPKIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly OCLKGMDKHAF LHLIGPNBLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly LEFMLHEECOG HEBJNOGGBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HDNKOFKKJFE JKOMDCPPLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly IDOCMGPBHJP IIJPIJLEIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEPBEGCNKDH FOKHNGJAKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly GAPILMDKBBG CGKGENIIHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly PPICGAEDHPE JOGKAGECKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly NILNDPCCLIB NGHHHHIOIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly global::DMKCIPNABEJ<KeepsakesConfig.KeepsakesOptions> OCHMMOCEMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly PEDGOFLLMDJ CANJKFBLJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> GOJLLNCIDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> OCOBBBLKAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<long> AEEMGLLOKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int MELLICACGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashSet<Guid> LBOIOHFMADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly IDisposable NGNKHNPIIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Task JOKKJMICLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private long? KALANIJCEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private KeepsakeProgressionEventInstancesDTO GIDLDDFALGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private global::HCPIAAEIKCB<KeepsakeProgressionEventInstancesDTO> BFKOHBJBACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<GICFHEKEBDK, KeepsakeCategoryConfigDTO> KFGGHFIILJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private KeepsakeGlobalConfigDTO AAFIKLOIBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private HashSet<long> ALGKONMGNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> GIIEOPGNEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> GIKEGKELOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<KeepsakeRoomListDTO> CPBIIBEAJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> FDHEDOFGLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, string> IBBIBOBEGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, DateTime> FNPNLEBBGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> LOOEEPHNIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, List<KeepsakeRoomDTO>> IMILDCIOJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Dictionary<long, long> KADHOCLIHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly List<string> DAGLLFPDGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private DateTime NOIHPFGANOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly IDisposable IMPILNKDPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private bool CEPOLIOIJIJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool ELNMLMCCNGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6C7030", Offset = "0x6C6230", VA = "0x1806C7030", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA318D0", Offset = "0xA30AD0", VA = "0x180A318D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool EGLBKMGDFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E332C0", Offset = "0x5E324C0", VA = "0x185E332C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GDAFANPMINN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E38B30", Offset = "0x5E37D30", VA = "0x185E38B30", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long OJHGAJKHJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E3AF00", Offset = "0x5E3A100", VA = "0x185E3AF00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? AFPIGPHCMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E37500", Offset = "0x5E36700", VA = "0x185E37500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool KNBABKKCAMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E33E80", Offset = "0x5E33080", VA = "0x185E33E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> GBPKPLAKKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1005B00", Offset = "0x1004D00", VA = "0x181005B00", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> GKOCKAHAIBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xCBC2B0", Offset = "0xCBB4B0", VA = "0x180CBC2B0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> OIIHMOFNDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x906F50", Offset = "0x906150", VA = "0x180906F50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> PCLIHPJCAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x906F60", Offset = "0x906160", VA = "0x180906F60", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> PPDDIIPNLAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x906F10", Offset = "0x906110", VA = "0x180906F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal bool KBBFBNBEJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1313B20", Offset = "0x1312D20", VA = "0x181313B20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A7E0", Offset = "0x5E399E0", VA = "0x185E3A7E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> IEJGKALIMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5E37860", Offset = "0x5E36A60", VA = "0x185E37860", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E39360", Offset = "0x5E38560", VA = "0x185E39360", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BIHEEMDECDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E38130", Offset = "0x5E37330", VA = "0x185E38130", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5E39230", Offset = "0x5E38430", VA = "0x185E39230", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action BFEFCHNLFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5E359B0", Offset = "0x5E34BB0", VA = "0x185E359B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E37E10", Offset = "0x5E37010", VA = "0x185E37E10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C520", Offset = "0x5E3B720", VA = "0x185E3C520")]
	[Preserve]
	internal ELGFFADEKGO([NotNull][CNHALHMHHIC(null)] JNEBLLOBHEL OHGLBLOPJNL, [NotNull][CNHALHMHHIC(null)] KHOACGMFOCG DJBOGCINOPP, [NotNull][CNHALHMHHIC(null)] CJKLDADOIFM GEAANOAHCPD, [NotNull][CNHALHMHHIC(null)] OKAIHDNNLHF FIGOFILOBPN, [NotNull][CNHALHMHHIC(null)] NGNNBOKLLHC OFFJDAFLINM, [NotNull][CNHALHMHHIC(null)] LLIEKCMACKC IMJGFHGLEPI, [NotNull][CNHALHMHHIC(null)] EPODBGNLFGN JJMBMPNIOMA, [NotNull][CNHALHMHHIC(null)] HKINNJHLDGA DIMCABPKIIN, [NotNull][CNHALHMHHIC(null)] OCLKGMDKHAF LHLIGPNBLOF, [NotNull][CNHALHMHHIC(null)] OOCLJFKKLDL LIDAABLKMCN, [NotNull][CNHALHMHHIC(null)] LEFMLHEECOG HEBJNOGGBIB, [NotNull][CNHALHMHHIC(null)] HDNKOFKKJFE JKOMDCPPLOM, [NotNull][CNHALHMHHIC(null)] IDOCMGPBHJP IIJPIJLEIEM, [NotNull][CNHALHMHHIC(null)] IEPBEGCNKDH FOKHNGJAKGA, [NotNull][CNHALHMHHIC(null)] GAPILMDKBBG CGKGENIIHCM, [NotNull][CNHALHMHHIC(null)] PPICGAEDHPE JOGKAGECKFN, [NotNull][CNHALHMHHIC(null)] NILNDPCCLIB NGHHHHIOIFN, [NotNull][CNHALHMHHIC(null)] global::DMKCIPNABEJ<KeepsakesConfig.KeepsakesOptions> OCHMMOCEMAN, [NotNull][CNHALHMHHIC(null)] PEDGOFLLMDJ CANJKFBLJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AA50", Offset = "0x5E39C50", VA = "0x185E3AA50", Slot = "15")]
	public bool MNHJAMOBOIA(List<string> HAOCMOLHEBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A3E0", Offset = "0x5E395E0", VA = "0x185E3A3E0", Slot = "16")]
	public global::HCPIAAEIKCB<Guid> MEJDPBENOBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E35A50", Offset = "0x5E34C50", VA = "0x185E35A50", Slot = "42")]
	public PMOAFBNPLHC EFGDBMFLGBH(Guid EODPCOEOPHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E34770", Offset = "0x5E33970", VA = "0x185E34770", Slot = "17")]
	public PMOAFBNPLHC DKNOGKMFCDH(Guid EODPCOEOPHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E39400", Offset = "0x5E38600", VA = "0x185E39400", Slot = "18")]
	public bool LALPKFKIOKC(Guid EODPCOEOPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E381D0", Offset = "0x5E373D0", VA = "0x185E381D0", Slot = "19")]
	public bool IIJEPBILAFA(Guid EODPCOEOPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BE00", Offset = "0x5E3B000", VA = "0x185E3BE00")]
	public KeepsakeTheme PHEMICIODIA(Guid EODPCOEOPHD)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BF20", Offset = "0x5E3B120", VA = "0x185E3BF20")]
	public KeepsakeTheme PHEMICIODIA(GICFHEKEBDK PCDEBJJJKHG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E37AF0", Offset = "0x5E36CF0", VA = "0x185E37AF0", Slot = "20")]
	public bool HHJFGNKBDKI(Guid EODPCOEOPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E392F0", Offset = "0x5E384F0", VA = "0x185E392F0", Slot = "21")]
	public void KKDPBEMEDPI(Guid EODPCOEOPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E392D0", Offset = "0x5E384D0", VA = "0x185E392D0", Slot = "22")]
	public void KKCOHLLMMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E38070", Offset = "0x5E37270", VA = "0x185E38070", Slot = "23")]
	public void IFAJDNMIGHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E37590", Offset = "0x5E36790", VA = "0x185E37590", Slot = "24")]
	public int GIFFPEIEBGK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E38640", Offset = "0x5E37840", VA = "0x185E38640", Slot = "25")]
	public global::HCPIAAEIKCB<int> JGMEGFJGFMC(long LLDIIOOAFHI, long MKCAINKBBKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E38FF0", Offset = "0x5E381F0", VA = "0x185E38FF0", Slot = "27")]
	public bool JOGDJFIKJKP(long LLDIIOOAFHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AFE0", Offset = "0x5E3A1E0", VA = "0x185E3AFE0", Slot = "43")]
	public bool NLFDLPDBJEK(long LLDIIOOAFHI, out EMIEMJILPLJ DMLLIGPEHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E390E0", Offset = "0x5E382E0", VA = "0x185E390E0", Slot = "28")]
	public bool KEAIKIKLFPG(long GFGCHMDCMNC, out DateTime PHFLIJJGFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E36090", Offset = "0x5E35290", VA = "0x185E36090", Slot = "29")]
	public long FDHLNHEJADN(long GFGCHMDCMNC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E38BF0", Offset = "0x5E37DF0", VA = "0x185E38BF0", Slot = "44")]
	public IEnumerable<int> JKMAHPNFLEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A1E0", Offset = "0x5E393E0", VA = "0x185E3A1E0", Slot = "30")]
	public long MDDFODHCAMJ(long LLDIIOOAFHI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A850", Offset = "0x5E39A50", VA = "0x185E3A850", Slot = "31")]
	public int MNEHOBKLPAB(long GFGCHMDCMNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E37D20", Offset = "0x5E36F20", VA = "0x185E37D20", Slot = "32")]
	public bool HMBBOAMEDEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E356F0", Offset = "0x5E348F0", VA = "0x185E356F0", Slot = "33")]
	public bool EABGGABNADJ(long GFGCHMDCMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B5B0", Offset = "0x5E3A7B0", VA = "0x185E3B5B0", Slot = "34")]
	public IEnumerable<long> OFPLBFCMCIE(long GFGCHMDCMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B4A0", Offset = "0x5E3A6A0", VA = "0x185E3B4A0", Slot = "35")]
	public int ODJJGFNNPHB(long GFGCHMDCMNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E39EA0", Offset = "0x5E390A0", VA = "0x185E39EA0", Slot = "39")]
	public long LOEPCLAIIFG(long MBAEGKKIOOB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E34DD0", Offset = "0x5E33FD0", VA = "0x185E34DD0")]
	private void DNLMGNBPLEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E38E40", Offset = "0x5E38040", VA = "0x185E38E40")]
	private int JNKNILHCEDN(KeepsakeRoomListDTO ICHMFEODCMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B3D0", Offset = "0x5E3A5D0", VA = "0x185E3B3D0")]
	private int OCNMPJOELHN(DateTime HNAMLIALDKC, DateTime EBIHDAEDEHA, TimeSpan CNGBKHCPDEA, int JPDEJPJIBGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E34B20", Offset = "0x5E33D20", VA = "0x185E34B20")]
	private void DLKEBIGFHGC(IEnumerable<KeepsakeInstanceDTO> GOJLLNCIDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5E33E90", Offset = "0x5E33090", VA = "0x185E33E90")]
	private void CLAKJOGEHAM(IEnumerable<KeepsakeCollectionRecordDTO> KOKNIPHCBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BDA0", Offset = "0x5E3AFA0", VA = "0x185E3BDA0")]
	private void PHCNFGEBPPE(IEnumerable<long> ACMMLGEGOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5E339F0", Offset = "0x5E32BF0", VA = "0x185E339F0")]
	private void CBPMHCJBOIB(IEnumerable<KeepsakeCategoryConfigDTO> IJNGHIHLMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1255CC0", Offset = "0x1254EC0", VA = "0x181255CC0")]
	private void BEMIFHCALOP(KeepsakeGlobalConfigDTO AAFIKLOIBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5E39540", Offset = "0x5E38740", VA = "0x185E39540")]
	private bool LDEMJKJEDAJ(out Guid GKAFHEAJBLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5E37EB0", Offset = "0x5E370B0", VA = "0x185E37EB0")]
	private void IBIJPOCKBNA(KeepsakeInstanceDTO HLMIEPLONKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E33B90", Offset = "0x5E32D90", VA = "0x185E33B90")]
	private void CCNKNPHFBEE(KeepsakeInstanceDTO HLMIEPLONKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E35FB0", Offset = "0x5E351B0", VA = "0x185E35FB0")]
	private void EONJCADOJLL(Guid EODPCOEOPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B550", Offset = "0x5E3A750", VA = "0x185E3B550")]
	private void OFMPCEMIEJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E332A0", Offset = "0x5E324A0", VA = "0x185E332A0")]
	private void AAKFLGHIEII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5E39CE0", Offset = "0x5E38EE0", VA = "0x185E39CE0")]
	private void LJEADCFELFL(NBNKBIKAIGB MLBPLLDNPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E33FF0", Offset = "0x5E331F0", VA = "0x185E33FF0")]
	private void CPCFBJNBOPF(OLPBMPMEKMJ.MLGENNHGKBK ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5E34D50", Offset = "0x5E33F50", VA = "0x185E34D50")]
	private void DMKCJJGPLKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C0E0", Offset = "0x5E3B2E0", VA = "0x185E3C0E0")]
	private void PKAECEFMFLD(float EICNILJFEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5E341E0", Offset = "0x5E333E0", VA = "0x185E341E0")]
	private void DDBOOEKKHKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5E37900", Offset = "0x5E36B00", VA = "0x185E37900")]
	private bool HBAJHFNBJGG(Guid EODPCOEOPHD, out string GJBLNDBOLCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5E33700", Offset = "0x5E32900", VA = "0x185E33700")]
	private bool ALIJNJJGFMJ(Guid EODPCOEOPHD, out KeepsakeCategoryConfigDTO CDNKACDFLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A300", Offset = "0x5E39500", VA = "0x185E3A300")]
	private void MEGLJPCKAHM(string KKNAIGLCEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B790", Offset = "0x5E3A990", VA = "0x185E3B790")]
	private bool OGMJLLLNMMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5E35CD0", Offset = "0x5E34ED0", VA = "0x185E35CD0")]
	private IEnumerable<long> EOMLOCGJPIH(IEnumerable<KeepsakeRoomDTO> FMEJMBCBIHG, IEnumerable<KeepsakeRoomListDTO> KAGJOIMEGAE, long GFGCHMDCMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E364F0", Offset = "0x5E356F0", VA = "0x185E364F0")]
	private bool FPHDOOEDIAA(Guid EODPCOEOPHD, out string GNLLAOFLEDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BAE0", Offset = "0x5E3ACE0", VA = "0x185E3BAE0", Slot = "36")]
	public string OJMIDKBGHFL(PJMJOJJLGFP JOGAAFNJKKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5E38200", Offset = "0x5E37400", VA = "0x185E38200", Slot = "38")]
	public string IOAKIIPMEHH(PJMJOJJLGFP JOGAAFNJKKB, long LLDIIOOAFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E39880", Offset = "0x5E38A80", VA = "0x185E39880", Slot = "37")]
	public string LDKKDGKBHMH(PJMJOJJLGFP JOGAAFNJKKB, int HJLFOLCEGMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E368E0", Offset = "0x5E35AE0", VA = "0x185E368E0")]
	private void FPHOILMCCPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5E338D0", Offset = "0x5E32AD0", VA = "0x185E338D0")]
	private void BKIAIPHBPJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A7C0", Offset = "0x5E399C0", VA = "0x185E3A7C0")]
	private PJMJOJJLGFP MKOFHCKBGJL(KLGFCHFKADL GNCFPEAHLML)
	{
		return default(PJMJOJJLGFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E34750", Offset = "0x5E33950", VA = "0x185E34750")]
	private PJMJOJJLGFP DHKPOMPOGCP(KLGFCHFKADL GNCFPEAHLML)
	{
		return default(PJMJOJJLGFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E34050", Offset = "0x5E33250", VA = "0x185E34050")]
	internal static string DCAOMECBGAI(IGFMOHILJJP NKEJJOCECGI, string KDHAPGDCNGN, bool IGANIAELGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5E35290", Offset = "0x5E34490", VA = "0x185E35290", Slot = "40")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C4A0", Offset = "0x5E3B6A0", VA = "0x185E3C4A0")]
	private BCGEGHGDJPI PLFBDACPIPA(KPNOOPGJEKD JGGGPAKOBFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AD60", Offset = "0x5E39F60", VA = "0x185E3AD60")]
	private BOEEIMMOILK NBEOOMOPLBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5E399A0", Offset = "0x5E38BA0", VA = "0x185E399A0")]
	private Task LICOKCNPNDP(HBMEPODFBHF FKNKEJLLBEP, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A670", Offset = "0x5E39870", VA = "0x185E3A670")]
	[AsyncStateMachine(typeof(LLICMDNCHMM))]
	private Task MIDBFLPBKJA(HBMEPODFBHF FKNKEJLLBEP, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5E39050", Offset = "0x5E38250", VA = "0x185E39050")]
	private Task KCGLGHDKOFG(HBMEPODFBHF FKNKEJLLBEP, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5E39D50", Offset = "0x5E38F50", VA = "0x185E39D50")]
	[AsyncStateMachine(typeof(JCECFPMMHFL))]
	private Task LMMCCPKIBKD(string DENPJAMCNLD, TimeSpan KPGIHDAHHDK, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5E38B10", Offset = "0x5E37D10", VA = "0x185E38B10")]
	[CompilerGenerated]
	private void JHCOPCAMNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B8A0", Offset = "0x5E3AAA0", VA = "0x185E3B8A0")]
	[CompilerGenerated]
	private void OIHMHJFFCNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E33310", Offset = "0x5E32510", VA = "0x185E33310")]
	[CompilerGenerated]
	private void ALALIIPGCNC(string GNLLAOFLEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E38B10", Offset = "0x5E37D10", VA = "0x185E38B10")]
	[CompilerGenerated]
	private void LMKENEBMLHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E364A0", Offset = "0x5E356A0", VA = "0x185E364A0")]
	[CompilerGenerated]
	private void FDKHIPEKIKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E33D90", Offset = "0x5E32F90", VA = "0x185E33D90")]
	[CompilerGenerated]
	private bool CFNAMLELJMF(KeepsakeInstanceDTO BIAIPPDLOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5E34DB0", Offset = "0x5E33FB0", VA = "0x185E34DB0")]
	[CompilerGenerated]
	private bool DMPPCBMGFNO(KeepsakeRoomListDTO BIAIPPDLOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BB40", Offset = "0x5E3AD40", VA = "0x185E3BB40")]
	[CompilerGenerated]
	private void PGLFEECFMGF(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> CKPHEBNBPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5E37800", Offset = "0x5E36A00", VA = "0x185E37800")]
	[CompilerGenerated]
	private void GNLIMCAEJEO(string GNLLAOFLEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B8F0", Offset = "0x5E3AAF0", VA = "0x185E3B8F0")]
	[CompilerGenerated]
	private Task OJIHLMIFPBF(CancellationToken BPCEAHNJDEF)
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
	[CreateAssetMenu]
	public class KeepsakesConfig : ScriptableObject, global::DMKCIPNABEJ<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class MLJLOKPDFDJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
				public MLJLOKPDFDJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x5E3E640", Offset = "0x5E3D840", VA = "0x185E3E640")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C7F40", Offset = "0x6C7140", VA = "0x1806C7F40")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] OAEPEGGFEDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x5E3DF00", Offset = "0x5E3D100", VA = "0x185E3DF00")]
			public KeepsakeTheme PHEMICIODIA(string OBAGJCOFCHI)
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
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DE80", Offset = "0x5E3D080", VA = "0x185E3DE80")]
		[ELNMOMKNGKB(LBAHANGFDMJ.None)]
		private static void DPKBCOEJEKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xE21BA0", Offset = "0xE20DA0", VA = "0x180E21BA0")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5E32C70", Offset = "0x5E31E70", VA = "0x185E32C70")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E32D80", Offset = "0x5E31F80", VA = "0x185E32D80")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
