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
public enum HALMKIPPHNG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Running,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Completed,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Faulted
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[HLNBGOANCJP]
public class LJCMENGLHMJ : DAFDICOBIOD, IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct PINHOGNLCCP
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string HCBFFPMKJKN = "The keepsake feature is disabled.";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public const string GIMFANMICKB = "This account is not authorized to place keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public const string MNMNIOAKNDA = "Must be at least a room co-owner to modify keepsakes.";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public const string MNAIIFIBMNE = "Invalid keepsake.";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string KHAPBCMEJMM = "Keepsake is already collected.";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string GCALLFGJIFK = "The keepsake is not in your current room.";

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public const string LHKOLJMCFAG = "Cannot add or remove keepsakes while limited time event is active.";

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public const string GFHBNKKEBCO = "Cannot collect keepsake after limited time event has ended.";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string DLMAFNJICKH = "This room does not have keepsake permissions.";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string GEFBPLOJBON = "This room has not unlocked yet.";

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public const string IDCMMIILMMA = "This room is locked until its unlock item is purchased.";
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class EIPLHPPAHHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public LJCMENGLHMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public EIPLHPPAHHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5F97DF0", Offset = "0x5F971F0", VA = "0x185F97DF0")]
		internal void <CollectKeepsakeInstance>b__1(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class LGBOFFFBMFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public LJCMENGLHMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__4;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public LGBOFFFBMFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5F989F0", Offset = "0x5F97DF0", VA = "0x185F989F0")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__0(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5F98A80", Offset = "0x5F97E80", VA = "0x185F98A80")]
		internal void <GetUncollectedKeepsakeCountForRoom>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5F98AB0", Offset = "0x5F97EB0", VA = "0x185F98AB0")]
		internal int <GetUncollectedKeepsakeCountForRoom>b__2()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5F98CA0", Offset = "0x5F980A0", VA = "0x185F98CA0")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__3(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5F98CA0", Offset = "0x5F980A0", VA = "0x185F98CA0")]
		internal bool <GetUncollectedKeepsakeCountForRoom>b__4(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class OINEDJJHBBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public LJCMENGLHMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public OINEDJJHBBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5FA3330", Offset = "0x5FA2730", VA = "0x185FA3330")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__1(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5FA3400", Offset = "0x5FA2800", VA = "0x185FA3400")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__3(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5FA3400", Offset = "0x5FA2800", VA = "0x185FA3400")]
		internal bool <TryGetKeepsakeRoomLockStatus>b__2(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class LMLDDCGNNLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public LMLDDCGNNLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1C004F0", Offset = "0x1BFF8F0", VA = "0x181C004F0")]
		internal bool <GetHighlightKeepsakeRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class KMIAAKHBPKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public KMIAAKHBPKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5F98760", Offset = "0x5F97B60", VA = "0x185F98760")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__0(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1EE65E0", Offset = "0x1EE59E0", VA = "0x181EE65E0")]
		internal bool <GetKeepsakeRoomListIdFromRoomId>b__1(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HJDJGKBNGAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public HJDJGKBNGAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5F98260", Offset = "0x5F97660", VA = "0x185F98260")]
		internal bool <GetKeepsakeRoomListUpsellItemPurchasableGiftDropId>b__0(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LIMEHNAEHAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public LIMEHNAEHAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1C004F0", Offset = "0x1BFF8F0", VA = "0x181C004F0")]
		internal bool <IsKeepsakeRoomListUpsellItemOwned>b__0(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class DIOCAOCBCFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public DIOCAOCBCFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5F97D50", Offset = "0x5F97150", VA = "0x185F97D50")]
		internal bool <TryGetNextOrphanedKeepsakeInstance>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class BHKKBCCBJCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public BHKKBCCBJCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5F97C30", Offset = "0x5F97030", VA = "0x185F97C30")]
		internal bool <RemoveOrphanedKeepsakeData>b__0(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class AKELONMNJEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public AKELONMNJEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5F97B40", Offset = "0x5F96F40", VA = "0x185F97B40")]
		internal bool <GetKeepsakeRoomIdsInList>b__0(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class CODPKJKMJNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AKELONMNJEI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public CODPKJKMJNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5F97CD0", Offset = "0x5F970D0", VA = "0x185F97CD0")]
		internal bool <GetKeepsakeRoomIdsInList>b__3(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JIHCEONLOIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public LJCMENGLHMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public OCLGLHHAFAO args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5F982D0", Offset = "0x5F976D0", VA = "0x185F982D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct OKKCLOANEHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public LJCMENGLHMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5FA3500", Offset = "0x5FA2900", VA = "0x185FA3500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const int FFGNKAPDJFP = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime MLBNOBEPONI;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const int DBACEAFCGNB = 3;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private const long POEIICPCEAH = -1L;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const char CHFPGMKNIDD = '|';

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly INMBPJGOGKI ILMANADIPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly BBINBNACILC CLOGCCDBDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly OFNICCBFNJA NOAMKILDIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly JJFHHDDFFDJ BDBJECANGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly GALFFEGNLPK GAMGMMDKBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CFBEJDJJEIH LOMHAGEEGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly JFCDMGDONIF AACJAEEEEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly NKKMLDCLAFH CMHEIEGMDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly GEMNBJFHFCE FGMKNCCGMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly KBLCBGJMPNE HMEKHDLDNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly POHCHLMHMEN HHOALDGCBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly JBLMLKNNEIN ODECOPLBELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly NCBGKAIJBEJ NGGHKEEHOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly LMJCEJIBICN LECPFPHPAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BKDBAAFNNFG ONHMGPFCGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly global::MCFNBCNAAKK<KeepsakesConfig.KeepsakesOptions> OILJOHNDOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly OMJDHGKECKG HFOCOPJAHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> EJKOKIAOFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> ELBOFNONFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<long> PGGCLMHPNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int JMMFLEANIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashSet<Guid> HFPGNEIPMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly IDisposable OHNHBCMLBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Task JABPJDGHJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private long? ABCNLMOCNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private KeepsakeProgressionEventInstancesDTO IKNNMNIGPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private global::HPHDJAFFHCN<KeepsakeProgressionEventInstancesDTO> LONECCAHIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<BNJAPKFAEJH, KeepsakeCategoryConfigDTO> GACEGMIKMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private KeepsakeGlobalConfigDTO LAPFICHJOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private HashSet<long> FBPPOCKGJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private HashSet<long> LKEEEODAEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> FKCEPCELAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<KeepsakeRoomListDTO> HGHOCNDIPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private List<KeepsakeRoomListDTO> NHCLCFJOPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, string> EFKLONJDGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, string> JNICHECHIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, DateTime> IBCKPBDBJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, List<KeepsakeRoomDTO>> NDJPLIGIDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Dictionary<long, List<KeepsakeRoomDTO>> APGHGANGOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Dictionary<long, long> CFDINCMFMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly List<string> KOGAPHCFMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private DateTime MLIPHHBDIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IDisposable ENCAIGAEFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private bool GENNCHCGMAP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool ONKHKICMGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76D160", Offset = "0x76C560", VA = "0x18076D160", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76D180", Offset = "0x76C580", VA = "0x18076D180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BFOKIGDNKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F9CE60", Offset = "0x5F9C260", VA = "0x185F9CE60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AHBLJFNNBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5F99780", Offset = "0x5F98B80", VA = "0x185F99780", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long EPENCBOBPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F993C0", Offset = "0x5F987C0", VA = "0x185F993C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? MLLPGDJFFHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9BA70", Offset = "0x5F9AE70", VA = "0x185F9BA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool IKHMBKAPMOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F9EB90", Offset = "0x5F9DF90", VA = "0x185F9EB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> OCHGMLAGFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F8040", Offset = "0x7F7440", VA = "0x1807F8040", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> CAGIGCLPBAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F8050", Offset = "0x7F7450", VA = "0x1807F8050", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> FAPILKNKDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB8CEB0", Offset = "0xB8C2B0", VA = "0x180B8CEB0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> CJDJBJLFNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xFC1850", Offset = "0xFC0C50", VA = "0x180FC1850", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> ECGNGJPMKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7EE4B0", Offset = "0x7ED8B0", VA = "0x1807EE4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal bool GOKCNOLPNJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA49EE0", Offset = "0xA492E0", VA = "0x180A49EE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F020", Offset = "0x5F9E420", VA = "0x185F9F020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> FIILLHOOKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B5F0", Offset = "0x5F9A9F0", VA = "0x185F9B5F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5F9EF80", Offset = "0x5F9E380", VA = "0x185F9EF80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DINDJJLAHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5F9A450", Offset = "0x5F99850", VA = "0x185F9A450", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5F9A850", Offset = "0x5F99C50", VA = "0x185F9A850", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action HPLBHBLBJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5F9EAF0", Offset = "0x5F9DEF0", VA = "0x185F9EAF0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F9B0", Offset = "0x5F9EDB0", VA = "0x185F9F9B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2110", Offset = "0x5FA1510", VA = "0x185FA2110")]
	[Preserve]
	internal LJCMENGLHMJ([NotNull][ANGFGGDOPHE(null)] INMBPJGOGKI ILMANADIPMI, [NotNull][ANGFGGDOPHE(null)] CKCPHHCAOEA CPNOLKPJLOC, [NotNull][ANGFGGDOPHE(null)] BBINBNACILC CLOGCCDBDEB, [NotNull][ANGFGGDOPHE(null)] OFNICCBFNJA NOAMKILDIDE, [NotNull][ANGFGGDOPHE(null)] JJFHHDDFFDJ BDBJECANGFH, [NotNull][ANGFGGDOPHE(null)] GALFFEGNLPK GAMGMMDKBIL, [NotNull][ANGFGGDOPHE(null)] CFBEJDJJEIH LOMHAGEEGEP, [NotNull][ANGFGGDOPHE(null)] JFCDMGDONIF AACJAEEEEFG, [NotNull][ANGFGGDOPHE(null)] NKKMLDCLAFH CMHEIEGMDHP, [NotNull][ANGFGGDOPHE(null)] APKFJPMDNPN FPHHKIEDMBN, [NotNull][ANGFGGDOPHE(null)] GEMNBJFHFCE FGMKNCCGMOD, [NotNull][ANGFGGDOPHE(null)] KBLCBGJMPNE HMEKHDLDNHL, [NotNull][ANGFGGDOPHE(null)] POHCHLMHMEN HHOALDGCBNF, [NotNull][ANGFGGDOPHE(null)] JBLMLKNNEIN ODECOPLBELG, [NotNull][ANGFGGDOPHE(null)] NCBGKAIJBEJ NGGHKEEHOGL, [NotNull][ANGFGGDOPHE(null)] LMJCEJIBICN LECPFPHPAAL, [NotNull][ANGFGGDOPHE(null)] BKDBAAFNNFG ONHMGPFCGLD, [NotNull][ANGFGGDOPHE(null)] global::MCFNBCNAAKK<KeepsakesConfig.KeepsakesOptions> OILJOHNDOJO, [NotNull][ANGFGGDOPHE(null)] OMJDHGKECKG HFOCOPJAHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5F990B0", Offset = "0x5F984B0", VA = "0x185F990B0", Slot = "15")]
	public bool BBLHHCFJKMI(List<string> FLLMEMOOGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C8F0", Offset = "0x5F9BCF0", VA = "0x185F9C8F0", Slot = "16")]
	public global::HPHDJAFFHCN<Guid> HIINGHGGCHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5F9F4B0", Offset = "0x5F9E8B0", VA = "0x185F9F4B0", Slot = "43")]
	public NDNJBANLHJC MMAEHILHEBM(Guid BHFEEHHPAJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1820", Offset = "0x5FA0C20", VA = "0x185FA1820", Slot = "17")]
	public NDNJBANLHJC PBLNJOKCKGM(Guid BHFEEHHPAJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D760", Offset = "0x5F9CB60", VA = "0x185F9D760", Slot = "18")]
	public bool JMPKHLDDGDK(Guid BHFEEHHPAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5F9BB00", Offset = "0x5F9AF00", VA = "0x185F9BB00", Slot = "19")]
	public bool FEKGDAFDDFO(Guid BHFEEHHPAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA08E0", Offset = "0x5F9FCE0", VA = "0x185FA08E0")]
	public KeepsakeTheme OELHPDKHDGD(Guid BHFEEHHPAJE)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0720", Offset = "0x5F9FB20", VA = "0x185FA0720")]
	public KeepsakeTheme OELHPDKHDGD(BNJAPKFAEJH CLFONPMJGJG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A150", Offset = "0x5F99550", VA = "0x185F9A150", Slot = "20")]
	public bool BONNNCDPCJD(Guid BHFEEHHPAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B580", Offset = "0x5F9A980", VA = "0x185F9B580", Slot = "21")]
	public void EMJMAHBNOED(Guid BHFEEHHPAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A4F0", Offset = "0x5F998F0", VA = "0x185F9A4F0", Slot = "22")]
	public void CNOBKBHHOEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E8F0", Offset = "0x5F9DCF0", VA = "0x185F9E8F0", Slot = "23")]
	public void KNJHOKLBMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5F9FFB0", Offset = "0x5F9F3B0", VA = "0x185F9FFB0", Slot = "24")]
	public int NPBCMBAHLHA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0A00", Offset = "0x5F9FE00", VA = "0x185FA0A00", Slot = "25")]
	public global::HPHDJAFFHCN<int> OFEMMAHEJOB(long COLNHBBPCAP, long ACDKGHBFBOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5F9F090", Offset = "0x5F9E490", VA = "0x185F9F090", Slot = "27")]
	public bool MEPMNOGAKJG(long COLNHBBPCAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5F99840", Offset = "0x5F98C40", VA = "0x185F99840", Slot = "44")]
	public bool BINJKJDHIDD(long COLNHBBPCAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5F995F0", Offset = "0x5F989F0", VA = "0x185F995F0", Slot = "28")]
	public bool BFNKLJAKHLE(long COLNHBBPCAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C4D0", Offset = "0x5F9B8D0", VA = "0x185F9C4D0", Slot = "45")]
	public bool HCLCHHBADEN(long COLNHBBPCAP, out FDAPCHNHOOO IPIKOKHDOAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5F994A0", Offset = "0x5F988A0", VA = "0x185F994A0", Slot = "29")]
	public bool BDNCEHABCMK(long OIHCANFENHO, out DateTime FMNGFAEHINP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5F9BED0", Offset = "0x5F9B2D0", VA = "0x185F9BED0", Slot = "30")]
	public long GEABMIJGHKJ(long OIHCANFENHO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E620", Offset = "0x5F9DA20", VA = "0x185F9E620", Slot = "46")]
	public IEnumerable<int> KBHEHMCOIHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1F00", Offset = "0x5FA1300", VA = "0x185FA1F00", Slot = "31")]
	public long PKLMHMCEJOG(long COLNHBBPCAP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5F9EBA0", Offset = "0x5F9DFA0", VA = "0x185F9EBA0", Slot = "32")]
	public int LOBNEEJPAGI(long OIHCANFENHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5F99690", Offset = "0x5F98A90", VA = "0x185F99690", Slot = "33")]
	public bool BGANIMJPLEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5F9BB30", Offset = "0x5F9AF30", VA = "0x185F9BB30", Slot = "34")]
	public bool FGJMGBKJDMF(long OIHCANFENHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5F9EDA0", Offset = "0x5F9E1A0", VA = "0x185F9EDA0", Slot = "35")]
	public IEnumerable<long> LOFABGCNAJC(long OIHCANFENHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F9F900", Offset = "0x5F9ED00", VA = "0x185F9F900", Slot = "36")]
	public int NFADDDCKFFP(long OIHCANFENHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5F98D20", Offset = "0x5F98120", VA = "0x185F98D20", Slot = "40")]
	public long AKNCKMEFDPA(long KHKBMOHOJMC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5F99A30", Offset = "0x5F98E30", VA = "0x185F99A30")]
	private void BNBFHAGKOLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1440", Offset = "0x5FA0840", VA = "0x185FA1440")]
	private int OIENGOCCHJF(KeepsakeRoomListDTO HJEKNNHNOBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A380", Offset = "0x5F99780", VA = "0x185F9A380")]
	private int CKELMEJBPJO(DateTime DGOOLIKEHOL, DateTime GBLEHOPIKBC, TimeSpan FPKKGPHEKLF, int BHAHNJHFGID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AA50", Offset = "0x5F99E50", VA = "0x185F9AA50")]
	private void DBPDGGICCEC(IEnumerable<KeepsakeInstanceDTO> EJKOKIAOFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A8F0", Offset = "0x5F99CF0", VA = "0x185F9A8F0")]
	private void DBAKINFMIIH(IEnumerable<KeepsakeCollectionRecordDTO> AOPBCDAOJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D8A0", Offset = "0x5F9CCA0", VA = "0x185F9D8A0")]
	private void JPBELFJNNFM(IEnumerable<long> DIMLPBNGEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5FA15F0", Offset = "0x5FA09F0", VA = "0x185FA15F0")]
	private void OOLJMHDINBA(IEnumerable<KeepsakeCategoryConfigDTO> MIHBJPNBFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7F8680", Offset = "0x7F7A80", VA = "0x1807F8680")]
	private void EEHANBLAHBP(KeepsakeGlobalConfigDTO LAPFICHJOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA03E0", Offset = "0x5F9F7E0", VA = "0x185FA03E0")]
	private bool ODCLFGBOAAE(out Guid EEOHJMHOAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1BD0", Offset = "0x5FA0FD0", VA = "0x185FA1BD0")]
	private void PCHGDGGALAD(KeepsakeInstanceDTO AOKHHBFCPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B380", Offset = "0x5F9A780", VA = "0x185F9B380")]
	private void EIBAEFMBBGI(KeepsakeInstanceDTO AOKHHBFCPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5F9BDF0", Offset = "0x5F9B1F0", VA = "0x185F9BDF0")]
	private void FLKHHFCLGOJ(Guid BHFEEHHPAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D2A0", Offset = "0x5F9C6A0", VA = "0x185F9D2A0")]
	private void IJIPDKHFIOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B300", Offset = "0x5F9A700", VA = "0x185F9B300")]
	private void EHBEIKBNKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D300", Offset = "0x5F9C700", VA = "0x185F9D300")]
	private void IJMIPJCMDNM(FKHOLCDLGLO MILONKEOIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C890", Offset = "0x5F9BC90", VA = "0x185F9C890")]
	private void HEHHNKINBME(HBCEBMPNHGK.EGPJKMPEAIM JGHFLANLLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5F98CC0", Offset = "0x5F980C0", VA = "0x185F98CC0")]
	private void ABBPCCLNCMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5F9F0F0", Offset = "0x5F9E4F0", VA = "0x185F9F0F0")]
	private void MHPJPEHNKJN(float MMBKMBLEMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0ED0", Offset = "0x5FA02D0", VA = "0x185FA0ED0")]
	private void OHMBALNLIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B770", Offset = "0x5F9AB70", VA = "0x185F9B770")]
	private bool EOCAPONABNA(Guid BHFEEHHPAJE, out string BPACABCKNDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B130", Offset = "0x5F9A530", VA = "0x185F9B130")]
	private bool EEPHJDAIFMF(Guid BHFEEHHPAJE, out KeepsakeCategoryConfigDTO JKLBNDDMLCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B690", Offset = "0x5F9AA90", VA = "0x185F9B690")]
	private void EOALJKJDFPE(string DANLCMMDOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B960", Offset = "0x5F9AD60", VA = "0x185F9B960")]
	private bool EOGELDFENMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5F9CB80", Offset = "0x5F9BF80", VA = "0x185F9CB80")]
	private IEnumerable<long> HOINBCNGMKF(IEnumerable<KeepsakeRoomDTO> AHIOGIAFMJN, IEnumerable<KeepsakeRoomListDTO> INBIKNIKMAJ, long OIHCANFENHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D370", Offset = "0x5F9C770", VA = "0x185F9D370")]
	private bool IMFNDIAAJPN(Guid BHFEEHHPAJE, out string MCGMECECHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B320", Offset = "0x5F9A720", VA = "0x185F9B320", Slot = "37")]
	public string EHLLIKEMBAI(CDBKGJEDHBH LEKAHJOBFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5F9FA50", Offset = "0x5F9EE50", VA = "0x185F9FA50", Slot = "39")]
	public string NIBCKDBGBPO(CDBKGJEDHBH LEKAHJOBFGK, long COLNHBBPCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5F9FE90", Offset = "0x5F9F290", VA = "0x185F9FE90", Slot = "38")]
	public string NKCAINKMICM(CDBKGJEDHBH LEKAHJOBFGK, int PNMEJFHPCMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5F9D900", Offset = "0x5F9CD00", VA = "0x185F9D900")]
	private void JPPKJOMLLDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E9B0", Offset = "0x5F9DDB0", VA = "0x185F9E9B0")]
	private void KPOCMONJHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E8D0", Offset = "0x5F9DCD0", VA = "0x185F9E8D0")]
	private CDBKGJEDHBH KLFDHLLGEBE(KJGFEDNPDHB LAIJLOIAION)
	{
		return default(CDBKGJEDHBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1EE0", Offset = "0x5FA12E0", VA = "0x185FA1EE0")]
	private CDBKGJEDHBH PFBAJFMJANI(KJGFEDNPDHB LAIJLOIAION)
	{
		return default(CDBKGJEDHBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5F998A0", Offset = "0x5F98CA0", VA = "0x185F998A0")]
	internal static string BLJCALEBOCD(DOAGBCKJOCC EDJCBOJCAGB, string OEMDMGMOEBI, bool AHNOCCMCPAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5F9ACD0", Offset = "0x5F9A0D0", VA = "0x185F9ACD0", Slot = "41")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5F9F730", Offset = "0x5F9EB30", VA = "0x185F9F730")]
	private EKKOLLPPNIM NBEIIHMLIGI(JEHHKLECEGB HNDMBPEHNEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0220", Offset = "0x5F9F620", VA = "0x185FA0220")]
	private JLIBGKFOCHA OCDBJMNBIDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A510", Offset = "0x5F99910", VA = "0x185F9A510")]
	private Task DAAKBOLCEPL(OCLGLHHAFAO DMNIOKOCJFF, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1D90", Offset = "0x5FA1190", VA = "0x185FA1D90")]
	[AsyncStateMachine(typeof(JIHCEONLOIE))]
	private Task PEIJDGFGJJE(OCLGLHHAFAO DMNIOKOCJFF, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1790", Offset = "0x5FA0B90", VA = "0x185FA1790")]
	private Task OPHBHOBNADA(OCLGLHHAFAO DMNIOKOCJFF, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5F9F7B0", Offset = "0x5F9EBB0", VA = "0x185F9F7B0")]
	[AsyncStateMachine(typeof(OKKCLOANEHF))]
	private Task NBIKHDIGKOJ(string CIBBLLOHCGM, TimeSpan LLDFAMOBDGB, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1C2A060", Offset = "0x1C29460", VA = "0x181C2A060")]
	[CompilerGenerated]
	private void KCLEOFHMGND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AC80", Offset = "0x5F9A080", VA = "0x185F9AC80")]
	[CompilerGenerated]
	private void DEOJIGAFLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5F9CEB0", Offset = "0x5F9C2B0", VA = "0x185F9CEB0")]
	[CompilerGenerated]
	private void IBIHHEMMKLO(string MCGMECECHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1C2A060", Offset = "0x1C29460", VA = "0x181C2A060")]
	[CompilerGenerated]
	private void ELKEAGBFBID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5F99060", Offset = "0x5F98460", VA = "0x185F99060")]
	[CompilerGenerated]
	private void AMCDLOADDNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2020", Offset = "0x5FA1420", VA = "0x185FA2020")]
	[CompilerGenerated]
	private bool PLGBIJOGIIH(KeepsakeInstanceDTO IMDGNLLHHDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5FA03C0", Offset = "0x5F9F7C0", VA = "0x185FA03C0")]
	[CompilerGenerated]
	private bool OCNALJMJPIH(KeepsakeRoomListDTO IMDGNLLHHDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5F99EF0", Offset = "0x5F992F0", VA = "0x185F99EF0")]
	[CompilerGenerated]
	private void BOGKDBNNKFM(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyList<KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> NPMGLIPJHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5F9E870", Offset = "0x5F9DC70", VA = "0x185F9E870")]
	[CompilerGenerated]
	private void KKJBFBFPOBN(string MCGMECECHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C2E0", Offset = "0x5F9B6E0", VA = "0x185F9C2E0")]
	[CompilerGenerated]
	private Task GHIMCIMIMJJ(CancellationToken OAFLPBGBNAC)
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
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public string ThemeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Header("Pickup")]
		public string PickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public GameObject PickupPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AudioClip PickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float PickupSfxVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Header("Colors")]
		public bool UseCustomColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Color BeamColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Color BaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[Header("Looping Sound")]
		public AudioClip LoopingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public float LoopingSfxVolume;
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class KeepsakesConfig : ScriptableObject, global::MCFNBCNAAKK<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class GFJMNAMNOGJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000084")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
				public GFJMNAMNOGJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x5F98230", Offset = "0x5F97630", VA = "0x185F98230")]
				internal bool <GetKeepsakeTheme>b__0(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x75F090", Offset = "0x75E490", VA = "0x18075F090")]
			public KeepsakesOptions([Optional] KeepsakeTheme[] MDCLJFLINHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x5F988B0", Offset = "0x5F97CB0", VA = "0x185F988B0")]
			public KeepsakeTheme OELHPDKHDGD(string OGPFJLMNHLK)
			{
				return default(KeepsakeTheme);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public KeepsakesOptions Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5F98830", Offset = "0x5F97C30", VA = "0x185F98830")]
		[KPHLIICFIPJ(OEKFJILJDLM.None)]
		private static void IBABMEFBFLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x830720", Offset = "0x82FB20", VA = "0x180830720")]
		public KeepsakesConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ABFMAPAPCGL
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static byte[] CFDBFPKMJCL;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static int NBKCFIGJMGE;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int BKBNJMLFPCH;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static BigInteger IHOABMABNGK;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ABFMAPAPCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5F97860", Offset = "0x5F96C60", VA = "0x185F97860")]
	private static string OGMGDCCGOFL(byte[] CFEKEMJOJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5F97510", Offset = "0x5F96910", VA = "0x185F97510")]
	public static string DFBBLGFDDMJ(byte[] GJDBLJLIDDI, bool JLJMGNGGBON)
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

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
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
