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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public EOGJIDLMAGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5ECB750", Offset = "0x5ECAB50", VA = "0x185ECB750")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PAKELNFHDKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC6B0", Offset = "0x5ECBAB0", VA = "0x185ECC6B0")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC740", Offset = "0x5ECBB40", VA = "0x185ECC740")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC770", Offset = "0x5ECBB70", VA = "0x185ECC770")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC960", Offset = "0x5ECBD60", VA = "0x185ECC960")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC960", Offset = "0x5ECBD60", VA = "0x185ECC960")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public BFGCNICLAGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC09C0", Offset = "0x5EBFDC0", VA = "0x185EC09C0")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0A90", Offset = "0x5EBFE90", VA = "0x185EC0A90")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0A90", Offset = "0x5EBFE90", VA = "0x185EC0A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ANPOEJEHJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x18895B0", Offset = "0x18889B0", VA = "0x1818895B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public MGNEKOMPCGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC510", Offset = "0x5ECB910", VA = "0x185ECC510")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1F65370", Offset = "0x1F64770", VA = "0x181F65370")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PMJNOLFEJGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC980", Offset = "0x5ECBD80", VA = "0x185ECC980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public LNMHODIBDKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x18895B0", Offset = "0x18889B0", VA = "0x1818895B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public BHJKBANFMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0B90", Offset = "0x5EBFF90", VA = "0x185EC0B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public MKECGMMAPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC5E0", Offset = "0x5ECB9E0", VA = "0x185ECC5E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public HDEHBHNNDMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECBB90", Offset = "0x5ECAF90", VA = "0x185ECBB90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public DBLNLLGIGHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0C30", Offset = "0x5EC0030", VA = "0x185EC0C30")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ECC080", Offset = "0x5ECB480", VA = "0x185ECC080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ECBC80", Offset = "0x5ECB080", VA = "0x185ECBC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x77F530", Offset = "0x77E930", VA = "0x18077F530", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9C88F0", Offset = "0x9C7CF0", VA = "0x1809C88F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool EGLBKMGDFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1300", Offset = "0x5EC0700", VA = "0x185EC1300", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GDAFANPMINN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6B70", Offset = "0x5EC5F70", VA = "0x185EC6B70", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long OJHGAJKHJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8F40", Offset = "0x5EC8340", VA = "0x185EC8F40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? AFPIGPHCMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5540", Offset = "0x5EC4940", VA = "0x185EC5540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool KNBABKKCAMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1EC0", Offset = "0x5EC12C0", VA = "0x185EC1EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> GBPKPLAKKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9D4C50", Offset = "0x9D4050", VA = "0x1809D4C50", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> GKOCKAHAIBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x72FA90", Offset = "0x72EE90", VA = "0x18072FA90", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> OIIHMOFNDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x72FAA0", Offset = "0x72EEA0", VA = "0x18072FAA0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> PCLIHPJCAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9D4C70", Offset = "0x9D4070", VA = "0x1809D4C70", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> PPDDIIPNLAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xEB2960", Offset = "0xEB1D60", VA = "0x180EB2960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal bool KBBFBNBEJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x912A40", Offset = "0x911E40", VA = "0x180912A40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8820", Offset = "0x5EC7C20", VA = "0x185EC8820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> IEJGKALIMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5EC58A0", Offset = "0x5EC4CA0", VA = "0x185EC58A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5EC73A0", Offset = "0x5EC67A0", VA = "0x185EC73A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BIHEEMDECDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6170", Offset = "0x5EC5570", VA = "0x185EC6170", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7270", Offset = "0x5EC6670", VA = "0x185EC7270", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action BFEFCHNLFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5EC39F0", Offset = "0x5EC2DF0", VA = "0x185EC39F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5E50", Offset = "0x5EC5250", VA = "0x185EC5E50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA560", Offset = "0x5EC9960", VA = "0x185ECA560")]
	[Preserve]
	internal ELGFFADEKGO([NotNull][CNHALHMHHIC(null)] JNEBLLOBHEL OHGLBLOPJNL, [NotNull][CNHALHMHHIC(null)] KHOACGMFOCG DJBOGCINOPP, [NotNull][CNHALHMHHIC(null)] CJKLDADOIFM GEAANOAHCPD, [NotNull][CNHALHMHHIC(null)] OKAIHDNNLHF FIGOFILOBPN, [NotNull][CNHALHMHHIC(null)] NGNNBOKLLHC OFFJDAFLINM, [NotNull][CNHALHMHHIC(null)] LLIEKCMACKC IMJGFHGLEPI, [NotNull][CNHALHMHHIC(null)] EPODBGNLFGN JJMBMPNIOMA, [NotNull][CNHALHMHHIC(null)] HKINNJHLDGA DIMCABPKIIN, [NotNull][CNHALHMHHIC(null)] OCLKGMDKHAF LHLIGPNBLOF, [NotNull][CNHALHMHHIC(null)] OOCLJFKKLDL LIDAABLKMCN, [NotNull][CNHALHMHHIC(null)] LEFMLHEECOG HEBJNOGGBIB, [NotNull][CNHALHMHHIC(null)] HDNKOFKKJFE JKOMDCPPLOM, [NotNull][CNHALHMHHIC(null)] IDOCMGPBHJP IIJPIJLEIEM, [NotNull][CNHALHMHHIC(null)] IEPBEGCNKDH FOKHNGJAKGA, [NotNull][CNHALHMHHIC(null)] GAPILMDKBBG CGKGENIIHCM, [NotNull][CNHALHMHHIC(null)] PPICGAEDHPE JOGKAGECKFN, [NotNull][CNHALHMHHIC(null)] NILNDPCCLIB NGHHHHIOIFN, [NotNull][CNHALHMHHIC(null)] global::DMKCIPNABEJ<KeepsakesConfig.KeepsakesOptions> OCHMMOCEMAN, [NotNull][CNHALHMHHIC(null)] PEDGOFLLMDJ CANJKFBLJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8A90", Offset = "0x5EC7E90", VA = "0x185EC8A90", Slot = "15")]
	public bool MNHJAMOBOIA(List<string> HAOCMOLHEBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8420", Offset = "0x5EC7820", VA = "0x185EC8420", Slot = "16")]
	public global::HCPIAAEIKCB<Guid> MEJDPBENOBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5EC3A90", Offset = "0x5EC2E90", VA = "0x185EC3A90", Slot = "42")]
	public PMOAFBNPLHC EFGDBMFLGBH(Guid EODPCOEOPHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5EC27B0", Offset = "0x5EC1BB0", VA = "0x185EC27B0", Slot = "17")]
	public PMOAFBNPLHC DKNOGKMFCDH(Guid EODPCOEOPHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7440", Offset = "0x5EC6840", VA = "0x185EC7440", Slot = "18")]
	public bool LALPKFKIOKC(Guid EODPCOEOPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6210", Offset = "0x5EC5610", VA = "0x185EC6210", Slot = "19")]
	public bool IIJEPBILAFA(Guid EODPCOEOPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9E40", Offset = "0x5EC9240", VA = "0x185EC9E40")]
	public KeepsakeTheme PHEMICIODIA(Guid EODPCOEOPHD)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9F60", Offset = "0x5EC9360", VA = "0x185EC9F60")]
	public KeepsakeTheme PHEMICIODIA(GICFHEKEBDK PCDEBJJJKHG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5B30", Offset = "0x5EC4F30", VA = "0x185EC5B30", Slot = "20")]
	public bool HHJFGNKBDKI(Guid EODPCOEOPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7330", Offset = "0x5EC6730", VA = "0x185EC7330", Slot = "21")]
	public void KKDPBEMEDPI(Guid EODPCOEOPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7310", Offset = "0x5EC6710", VA = "0x185EC7310", Slot = "22")]
	public void KKCOHLLMMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5EC60B0", Offset = "0x5EC54B0", VA = "0x185EC60B0", Slot = "23")]
	public void IFAJDNMIGHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5EC55D0", Offset = "0x5EC49D0", VA = "0x185EC55D0", Slot = "24")]
	public int GIFFPEIEBGK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6680", Offset = "0x5EC5A80", VA = "0x185EC6680", Slot = "25")]
	public global::HCPIAAEIKCB<int> JGMEGFJGFMC(long LLDIIOOAFHI, long MKCAINKBBKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7030", Offset = "0x5EC6430", VA = "0x185EC7030", Slot = "27")]
	public bool JOGDJFIKJKP(long LLDIIOOAFHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9020", Offset = "0x5EC8420", VA = "0x185EC9020", Slot = "43")]
	public bool NLFDLPDBJEK(long LLDIIOOAFHI, out EMIEMJILPLJ DMLLIGPEHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7120", Offset = "0x5EC6520", VA = "0x185EC7120", Slot = "28")]
	public bool KEAIKIKLFPG(long GFGCHMDCMNC, out DateTime PHFLIJJGFCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5EC40D0", Offset = "0x5EC34D0", VA = "0x185EC40D0", Slot = "29")]
	public long FDHLNHEJADN(long GFGCHMDCMNC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6C30", Offset = "0x5EC6030", VA = "0x185EC6C30", Slot = "44")]
	public IEnumerable<int> JKMAHPNFLEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8220", Offset = "0x5EC7620", VA = "0x185EC8220", Slot = "30")]
	public long MDDFODHCAMJ(long LLDIIOOAFHI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8890", Offset = "0x5EC7C90", VA = "0x185EC8890", Slot = "31")]
	public int MNEHOBKLPAB(long GFGCHMDCMNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5D60", Offset = "0x5EC5160", VA = "0x185EC5D60", Slot = "32")]
	public bool HMBBOAMEDEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC3730", Offset = "0x5EC2B30", VA = "0x185EC3730", Slot = "33")]
	public bool EABGGABNADJ(long GFGCHMDCMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC95F0", Offset = "0x5EC89F0", VA = "0x185EC95F0", Slot = "34")]
	public IEnumerable<long> OFPLBFCMCIE(long GFGCHMDCMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC94E0", Offset = "0x5EC88E0", VA = "0x185EC94E0", Slot = "35")]
	public int ODJJGFNNPHB(long GFGCHMDCMNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7EE0", Offset = "0x5EC72E0", VA = "0x185EC7EE0", Slot = "39")]
	public long LOEPCLAIIFG(long MBAEGKKIOOB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2E10", Offset = "0x5EC2210", VA = "0x185EC2E10")]
	private void DNLMGNBPLEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6E80", Offset = "0x5EC6280", VA = "0x185EC6E80")]
	private int JNKNILHCEDN(KeepsakeRoomListDTO ICHMFEODCMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9410", Offset = "0x5EC8810", VA = "0x185EC9410")]
	private int OCNMPJOELHN(DateTime HNAMLIALDKC, DateTime EBIHDAEDEHA, TimeSpan CNGBKHCPDEA, int JPDEJPJIBGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2B60", Offset = "0x5EC1F60", VA = "0x185EC2B60")]
	private void DLKEBIGFHGC(IEnumerable<KeepsakeInstanceDTO> GOJLLNCIDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1ED0", Offset = "0x5EC12D0", VA = "0x185EC1ED0")]
	private void CLAKJOGEHAM(IEnumerable<KeepsakeCollectionRecordDTO> KOKNIPHCBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9DE0", Offset = "0x5EC91E0", VA = "0x185EC9DE0")]
	private void PHCNFGEBPPE(IEnumerable<long> ACMMLGEGOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1A30", Offset = "0x5EC0E30", VA = "0x185EC1A30")]
	private void CBPMHCJBOIB(IEnumerable<KeepsakeCategoryConfigDTO> IJNGHIHLMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7300D0", Offset = "0x72F4D0", VA = "0x1807300D0")]
	private void BEMIFHCALOP(KeepsakeGlobalConfigDTO AAFIKLOIBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7580", Offset = "0x5EC6980", VA = "0x185EC7580")]
	private bool LDEMJKJEDAJ(out Guid GKAFHEAJBLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5EF0", Offset = "0x5EC52F0", VA = "0x185EC5EF0")]
	private void IBIJPOCKBNA(KeepsakeInstanceDTO HLMIEPLONKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1BD0", Offset = "0x5EC0FD0", VA = "0x185EC1BD0")]
	private void CCNKNPHFBEE(KeepsakeInstanceDTO HLMIEPLONKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC3FF0", Offset = "0x5EC33F0", VA = "0x185EC3FF0")]
	private void EONJCADOJLL(Guid EODPCOEOPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9590", Offset = "0x5EC8990", VA = "0x185EC9590")]
	private void OFMPCEMIEJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC12E0", Offset = "0x5EC06E0", VA = "0x185EC12E0")]
	private void AAKFLGHIEII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7D20", Offset = "0x5EC7120", VA = "0x185EC7D20")]
	private void LJEADCFELFL(NBNKBIKAIGB MLBPLLDNPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2030", Offset = "0x5EC1430", VA = "0x185EC2030")]
	private void CPCFBJNBOPF(OLPBMPMEKMJ.MLGENNHGKBK ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2D90", Offset = "0x5EC2190", VA = "0x185EC2D90")]
	private void DMKCJJGPLKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA120", Offset = "0x5EC9520", VA = "0x185ECA120")]
	private void PKAECEFMFLD(float EICNILJFEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2220", Offset = "0x5EC1620", VA = "0x185EC2220")]
	private void DDBOOEKKHKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5940", Offset = "0x5EC4D40", VA = "0x185EC5940")]
	private bool HBAJHFNBJGG(Guid EODPCOEOPHD, out string GJBLNDBOLCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1740", Offset = "0x5EC0B40", VA = "0x185EC1740")]
	private bool ALIJNJJGFMJ(Guid EODPCOEOPHD, out KeepsakeCategoryConfigDTO CDNKACDFLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8340", Offset = "0x5EC7740", VA = "0x185EC8340")]
	private void MEGLJPCKAHM(string KKNAIGLCEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5EC97D0", Offset = "0x5EC8BD0", VA = "0x185EC97D0")]
	private bool OGMJLLLNMMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5EC3D10", Offset = "0x5EC3110", VA = "0x185EC3D10")]
	private IEnumerable<long> EOMLOCGJPIH(IEnumerable<KeepsakeRoomDTO> FMEJMBCBIHG, IEnumerable<KeepsakeRoomListDTO> KAGJOIMEGAE, long GFGCHMDCMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5EC4530", Offset = "0x5EC3930", VA = "0x185EC4530")]
	private bool FPHDOOEDIAA(Guid EODPCOEOPHD, out string GNLLAOFLEDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9B20", Offset = "0x5EC8F20", VA = "0x185EC9B20", Slot = "36")]
	public string OJMIDKBGHFL(PJMJOJJLGFP JOGAAFNJKKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6240", Offset = "0x5EC5640", VA = "0x185EC6240", Slot = "38")]
	public string IOAKIIPMEHH(PJMJOJJLGFP JOGAAFNJKKB, long LLDIIOOAFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC78C0", Offset = "0x5EC6CC0", VA = "0x185EC78C0", Slot = "37")]
	public string LDKKDGKBHMH(PJMJOJJLGFP JOGAAFNJKKB, int HJLFOLCEGMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC4920", Offset = "0x5EC3D20", VA = "0x185EC4920")]
	private void FPHOILMCCPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1910", Offset = "0x5EC0D10", VA = "0x185EC1910")]
	private void BKIAIPHBPJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8800", Offset = "0x5EC7C00", VA = "0x185EC8800")]
	private PJMJOJJLGFP MKOFHCKBGJL(KLGFCHFKADL GNCFPEAHLML)
	{
		return default(PJMJOJJLGFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2790", Offset = "0x5EC1B90", VA = "0x185EC2790")]
	private PJMJOJJLGFP DHKPOMPOGCP(KLGFCHFKADL GNCFPEAHLML)
	{
		return default(PJMJOJJLGFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2090", Offset = "0x5EC1490", VA = "0x185EC2090")]
	internal static string DCAOMECBGAI(IGFMOHILJJP NKEJJOCECGI, string KDHAPGDCNGN, bool IGANIAELGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5EC32D0", Offset = "0x5EC26D0", VA = "0x185EC32D0", Slot = "40")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA4E0", Offset = "0x5EC98E0", VA = "0x185ECA4E0")]
	private BCGEGHGDJPI PLFBDACPIPA(KPNOOPGJEKD JGGGPAKOBFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8DA0", Offset = "0x5EC81A0", VA = "0x185EC8DA0")]
	private BOEEIMMOILK NBEOOMOPLBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5EC79E0", Offset = "0x5EC6DE0", VA = "0x185EC79E0")]
	private Task LICOKCNPNDP(HBMEPODFBHF FKNKEJLLBEP, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5EC86B0", Offset = "0x5EC7AB0", VA = "0x185EC86B0")]
	[AsyncStateMachine(typeof(LLICMDNCHMM))]
	private Task MIDBFLPBKJA(HBMEPODFBHF FKNKEJLLBEP, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7090", Offset = "0x5EC6490", VA = "0x185EC7090")]
	private Task KCGLGHDKOFG(HBMEPODFBHF FKNKEJLLBEP, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7D90", Offset = "0x5EC7190", VA = "0x185EC7D90")]
	[AsyncStateMachine(typeof(JCECFPMMHFL))]
	private Task LMMCCPKIBKD(string DENPJAMCNLD, TimeSpan KPGIHDAHHDK, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6B50", Offset = "0x5EC5F50", VA = "0x185EC6B50")]
	[CompilerGenerated]
	private void JHCOPCAMNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5EC98E0", Offset = "0x5EC8CE0", VA = "0x185EC98E0")]
	[CompilerGenerated]
	private void OIHMHJFFCNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1350", Offset = "0x5EC0750", VA = "0x185EC1350")]
	[CompilerGenerated]
	private void ALALIIPGCNC(string GNLLAOFLEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6B50", Offset = "0x5EC5F50", VA = "0x185EC6B50")]
	[CompilerGenerated]
	private void LMKENEBMLHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC44E0", Offset = "0x5EC38E0", VA = "0x185EC44E0")]
	[CompilerGenerated]
	private void FDKHIPEKIKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1DD0", Offset = "0x5EC11D0", VA = "0x185EC1DD0")]
	[CompilerGenerated]
	private bool CFNAMLELJMF(KeepsakeInstanceDTO BIAIPPDLOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2DF0", Offset = "0x5EC21F0", VA = "0x185EC2DF0")]
	[CompilerGenerated]
	private bool DMPPCBMGFNO(KeepsakeRoomListDTO BIAIPPDLOMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9B80", Offset = "0x5EC8F80", VA = "0x185EC9B80")]
	[CompilerGenerated]
	private void PGLFEECFMGF(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> CKPHEBNBPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5EC5840", Offset = "0x5EC4C40", VA = "0x185EC5840")]
	[CompilerGenerated]
	private void GNLIMCAEJEO(string GNLLAOFLEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9930", Offset = "0x5EC8D30", VA = "0x185EC9930")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
				public MLJLOKPDFDJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x5ECC680", Offset = "0x5ECBA80", VA = "0x185ECC680")]
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
			[Cpp2IlInjected.Address(RVA = "0x7803F0", Offset = "0x77F7F0", VA = "0x1807803F0")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] OAEPEGGFEDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x5ECBF40", Offset = "0x5ECB340", VA = "0x185ECBF40")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5ECBEC0", Offset = "0x5ECB2C0", VA = "0x185ECBEC0")]
		[ELNMOMKNGKB(LBAHANGFDMJ.None)]
		private static void DPKBCOEJEKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7681E0", Offset = "0x7675E0", VA = "0x1807681E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0CB0", Offset = "0x5EC00B0", VA = "0x185EC0CB0")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0DC0", Offset = "0x5EC01C0", VA = "0x185EC0DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
