using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;
using RecRoom.Analytics.AccessInterfaces;
using RecRoom.Analytics.Statsig;
using RecRoom.Core;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.Networking.DataTypes;
using RecRoom.Networking.RPC;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.Persistence;
using RecRoom.RoomEconomy.Core;
using RecRoom.RoomEconomy.RoomInventory;
using UJect;
using UJect.Injection;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RoomEconomy_RoomOffer_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8D90530", Offset = "0x8D8F330", VA = "0x188D90530", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2963E60", Offset = "0x2962C60", VA = "0x182963E60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.RoomEconomy.RoomOffer
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface HSZTMGXYEGC : XHZHYFQVHRC
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		FSJCOTRUCEV FSJCOTRUCEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface ECZCVWILANX
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		QNYQBPXDJMP VTDMTUCMCQT();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class FHZGCHHBBFU : ECZCVWILANX
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8D85A60", Offset = "0x8D84860", VA = "0x188D85A60")]
		[FDNTPBIGLET.Session.GameOnly]
		internal static void XWYNCRUHYPG(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		[RecRoom.NoEngine.Common.Preserve]
		public FHZGCHHBBFU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8D859B0", Offset = "0x8D847B0", VA = "0x188D859B0", Slot = "4")]
		public QNYQBPXDJMP VTDMTUCMCQT()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Tested]
	public class FSJCOTRUCEV : VAQYPMCUKAA, IDisposable, IINKLCBDCVV
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class HCJDRWQZSYV
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			private struct <<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public HCJDRWQZSYV <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Guid itemId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x8D8FA70", Offset = "0x8D8E870", VA = "0x188D8FA70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x8D8FDF0", Offset = "0x8D8EBF0", VA = "0x188D8FDF0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public FSJCOTRUCEV WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int JIDHWSFFURW;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public HCJDRWQZSYV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8D8ABB0", Offset = "0x8D899B0", VA = "0x188D8ABB0")]
			[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
			internal Task YIQZHOIPNXU(Guid a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8D8AA90", Offset = "0x8D89890", VA = "0x188D8AA90")]
			internal Guid? JUYWHRAGGKD(Guid a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct <CV2GetPlayerRoomOfferPurchaseCount>d__52 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public FSJCOTRUCEV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public XGOJTPBZDNO player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public Guid roomOfferId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8D8B320", Offset = "0x8D8A120", VA = "0x188D8B320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8D8B700", Offset = "0x8D8A500", VA = "0x188D8B700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct <CreateRoomOffer>d__43 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AsyncTaskMethodBuilder<Result<RecNet.RoomOffer, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public FSJCOTRUCEV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Guid? originId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public string description;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public string imageName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public int price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public bool hasDynamicPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int minimumDynamicPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public int maximumDynamicPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public RoomOfferType roomOfferType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public Dictionary<Guid, int> roomInventoryItemMappings;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public Guid? priceUnitId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public bool allowRename;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private TaskAwaiter<RecNetResult<RecNet.RoomOffer>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8D8B770", Offset = "0x8D8A570", VA = "0x188D8B770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8D8BD50", Offset = "0x8D8AB50", VA = "0x188D8BD50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct <DeleteRoomOffer>d__45 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public AsyncTaskMethodBuilder<Result<bool, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public FSJCOTRUCEV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Guid roomOfferId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private RecNet.RoomOffer <existingRoomOffer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private TaskAwaiter<RecNetResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8D8BDC0", Offset = "0x8D8ABC0", VA = "0x188D8BDC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8D8C370", Offset = "0x8D8B170", VA = "0x188D8C370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct <DownloadRoomOffers>d__68 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public FSJCOTRUCEV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private Task<RecNetResult<List<RoomOfferPurchaseCountDTO>>> <purchaseCountsTask>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private TaskAwaiter<List<RecNet.RoomOffer>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private TaskAwaiter<RecNetResult<List<RoomOfferPurchaseCountDTO>>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8D8C3E0", Offset = "0x8D8B1E0", VA = "0x188D8C3E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8D8CBD0", Offset = "0x8D8B9D0", VA = "0x188D8CBD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct <GetRecentPurchasedRoomOffersForRoom>d__47 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AsyncTaskMethodBuilder<List<RoomOfferLastPurchaseDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public FSJCOTRUCEV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private TaskAwaiter<RecNetResult<List<RoomOfferLastPurchaseDTO>>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8D8CC30", Offset = "0x8D8BA30", VA = "0x188D8CC30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8D8D060", Offset = "0x8D8BE60", VA = "0x188D8D060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct <OnRoomLoadComplete>d__70 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public FSJCOTRUCEV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private TaskAwaiter<Task> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8D8D0D0", Offset = "0x8D8BED0", VA = "0x188D8D0D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8D8D750", Offset = "0x8D8C550", VA = "0x188D8D750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct <PurchaseRoomOffer>d__55 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public AsyncTaskMethodBuilder<Result<bool, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public FSJCOTRUCEV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public RecNet.RoomOffer roomOffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public string purchaseSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public long requestedPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private TaskAwaiter<Result<bool, string>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8D8E150", Offset = "0x8D8CF50", VA = "0x188D8E150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8D8E6F0", Offset = "0x8D8D4F0", VA = "0x188D8E6F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <PurchaseRoomOfferInternal>d__56 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public AsyncTaskMethodBuilder<Result<bool, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public FSJCOTRUCEV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public RecNet.RoomOffer roomOffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public string purchaseSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public long requestedPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public long initialBalance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private RoomOfferPurchaseOperationResult <operationResult>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <attemptNumber>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private RoomOfferPurchaseResponseDTO <response>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private TaskAwaiter<RoomOfferPurchaseResponseDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8D8D7B0", Offset = "0x8D8C5B0", VA = "0x188D8D7B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8D8E0E0", Offset = "0x8D8CEE0", VA = "0x188D8E0E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct <SendGetPlayerRoomOfferPurchaseCountRequest>d__75 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public FSJCOTRUCEV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public XGOJTPBZDNO player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8D8E760", Offset = "0x8D8D560", VA = "0x188D8E760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8D8ECD0", Offset = "0x8D8DAD0", VA = "0x188D8ECD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct <SendRecNetRoomOfferPurchaseRequest>d__57 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AsyncTaskMethodBuilder<RoomOfferPurchaseResponseDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public FSJCOTRUCEV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int requestedPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public RecNet.RoomOffer roomOffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private HCJDRWQZSYV <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private Dictionary<Guid, Guid?> <concurrencyCodeByItemIdMap>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private Guid <itemId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private TaskAwaiter<RoomOfferPurchaseResponseDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8D8ED40", Offset = "0x8D8DB40", VA = "0x188D8ED40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8D8FA00", Offset = "0x8D8E800", VA = "0x188D8FA00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct <UpdateRoomOffer>d__44 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public AsyncTaskMethodBuilder<Result<RecNet.RoomOffer, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public FSJCOTRUCEV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public Guid roomOfferOriginId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string description;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public string imageName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public int price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public bool hasDynamicPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public int minimumDynamicPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public int maximumDynamicPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public RoomOfferType roomOfferType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public Dictionary<Guid, int> roomInventoryItemMappings;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public Guid? priceUnitId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private TaskAwaiter<RecNetResult<RecNet.RoomOffer>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8D8FE50", Offset = "0x8D8EC50", VA = "0x188D8FE50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8D904C0", Offset = "0x8D8F2C0", VA = "0x188D904C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly TimeSpan DOAGILWCBXJ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string VUYHMFHQPCD = "econ_room_offer_gate";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const string SEZJNLTLNNL = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string CPZZJSKWFMM = "CV2_Purchase_Prompt_Chip";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly HTRUPSOSJBI JNNYRHZZHLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly CLXLYXLFVQR CSBNIHTFWYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly XINMZNYOFOW VYUBVUYZWBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly DINTWZBUUTH MFUQMRTEKYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly DYLDWGCQIJO QWYULKOAENS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly HSZTMGXYEGC ASLNEMFTTKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly CHIZFLIIKOM FFRQMGYVOAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly JMRJJROJZTN ARPSKUHLYVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly SHDIMMQKFWM MVVUKKZMXEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly KGDITIUSTQK TFNECJLJALX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly QNYQBPXDJMP BAWHCYWURDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Dictionary<Guid, int> UCTMPQOEUSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IDisposable LHEBHBRZMRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Task XABXBLUNDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CancellationTokenSource UCMCPUWNBLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private long KWSJBZQUMSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool IYRJDGYKKCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly RZPBUPKQWXY XIKKEHHIOUW;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private EVAOIQLBAMA MYUHDYVMGBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8D88870", Offset = "0x8D87670", VA = "0x188D88870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DQHMEXLDKHB CNVCBWDSTUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB882D0", Offset = "0xB870D0", VA = "0x180B882D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xB88330", Offset = "0xB87130", VA = "0x180B88330", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public OZAYXQWBYWY<RecNet.RoomOffer> VMOTTEMVQOK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAC7160", Offset = "0xAC5F60", VA = "0x180AC7160", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAC7450", Offset = "0xAC6250", VA = "0x180AC7450", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public OZAYXQWBYWY<Guid> YOOTRNYEOEP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB88130", Offset = "0xB86F30", VA = "0x180B88130", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xB880C0", Offset = "0xB86EC0", VA = "0x180B880C0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public OZAYXQWBYWY<Guid> JHFDOVKPLEU
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xEF42F0", Offset = "0xEF30F0", VA = "0x180EF42F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x151C850", Offset = "0x151B650", VA = "0x18151C850", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8D89B20", Offset = "0x8D88920", VA = "0x188D89B20")]
		[FDNTPBIGLET.Session.GameOnly]
		internal static void XWYNCRUHYPG(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8D8A380", Offset = "0x8D89180", VA = "0x188D8A380")]
		[RecRoom.NoEngine.Common.Preserve]
		public FSJCOTRUCEV([Inject(null)] HTRUPSOSJBI recNetRoomOffer, [Inject(null)] CLXLYXLFVQR matchmakingProvider, [Inject(null)] QEJIRNPZZVI roomLoader, [Inject(null)] XINMZNYOFOW taskDelay, [Inject(null)] ECZCVWILANX cacheFactory, [Inject(null)] DINTWZBUUTH statsig, [Inject("ShowPurchasePromptRateLimiter")] DYLDWGCQIJO purchasePromptRateLimiter, [Inject(null)] HSZTMGXYEGC rpcForwarder, [Inject(null)] WLYXSTLUZDB recNetPhotonAccess, [Inject(null)] CHIZFLIIKOM callbacks, [Inject(null)] JMRJJROJZTN roomInventoryManagerInternal, [Inject(null)] SHDIMMQKFWM recNetStorefronts, [Inject(null)] KGDITIUSTQK analyticsHelper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8D86510", Offset = "0x8D85310", VA = "0x188D86510", Slot = "30")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8D87590", Offset = "0x8D86390", VA = "0x188D87590", Slot = "12")]
		[AsyncStateMachine(typeof(<CreateRoomOffer>d__43))]
		public Task<Result<RecNet.RoomOffer, string>> KCLEGIEQUZU(Guid? a, long b, string c, string d, string e, int f, bool g, int h, int i, RoomOfferType j, [Optional] Dictionary<Guid, int> k, [Optional] Guid? l, bool m = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8D89490", Offset = "0x8D88290", VA = "0x188D89490", Slot = "13")]
		[AsyncStateMachine(typeof(<UpdateRoomOffer>d__44))]
		public Task<Result<RecNet.RoomOffer, string>> VAWVYPNWQWJ(Guid a, long b, string c, string d, string e, int f, bool g, int h, int i, RoomOfferType j, [Optional] Dictionary<Guid, int> k, [Optional] Guid? l)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8D898A0", Offset = "0x8D886A0", VA = "0x188D898A0", Slot = "14")]
		[AsyncStateMachine(typeof(<DeleteRoomOffer>d__45))]
		public Task<Result<bool, string>> VJHZLJRSKLV(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8D893F0", Offset = "0x8D881F0", VA = "0x188D893F0", Slot = "15")]
		public IEnumerable<RecNet.RoomOffer> UPIZNFINVKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8D85C40", Offset = "0x8D84A40", VA = "0x188D85C40", Slot = "16")]
		[AsyncStateMachine(typeof(<GetRecentPurchasedRoomOffersForRoom>d__47))]
		public Task<List<RoomOfferLastPurchaseDTO>> BZHEDPNHIIZ(long a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8D89200", Offset = "0x8D88000", VA = "0x188D89200", Slot = "19")]
		public bool UBIZTBUFSOQ(Guid a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8D85F10", Offset = "0x8D84D10", VA = "0x188D85F10", Slot = "17")]
		public bool CFWDJKSGDZV(Guid a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8D89650", Offset = "0x8D88450", VA = "0x188D89650", Slot = "18")]
		public bool VFGAYIRNNQZ(string a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8D89FE0", Offset = "0x8D88DE0", VA = "0x188D89FE0", Slot = "20")]
		public void ZJGOBPHZTHF(XGOJTPBZDNO a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8D88100", Offset = "0x8D86F00", VA = "0x188D88100", Slot = "21")]
		[AsyncStateMachine(typeof(<CV2GetPlayerRoomOfferPurchaseCount>d__52))]
		public Task<int> ONZZZNVAVYK(XGOJTPBZDNO a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8D86430", Offset = "0x8D85230", VA = "0x188D86430", Slot = "22")]
		public bool DKYIFGQSHWR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8D87D10", Offset = "0x8D86B10", VA = "0x188D87D10", Slot = "23")]
		public bool OLDMXCVPUMY(Guid a, [Out] List<string> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8D899C0", Offset = "0x8D887C0", VA = "0x188D899C0", Slot = "24")]
		[AsyncStateMachine(typeof(<PurchaseRoomOffer>d__55))]
		public Task<Result<bool, string>> WTTHCDWTEXR(RecNet.RoomOffer a, long b, int c, string d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8D85AE0", Offset = "0x8D848E0", VA = "0x188D85AE0")]
		[AsyncStateMachine(typeof(<PurchaseRoomOfferInternal>d__56))]
		private Task<Result<bool, string>> BWHFRIJKCMG(RecNet.RoomOffer a, long b, long c, string d, int e = 1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8D8A1B0", Offset = "0x8D88FB0", VA = "0x188D8A1B0")]
		[AsyncStateMachine(typeof(<SendRecNetRoomOfferPurchaseRequest>d__57))]
		private Task<RoomOfferPurchaseResponseDTO> ZTIIVRQGFTP(RecNet.RoomOffer a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8D87230", Offset = "0x8D86030", VA = "0x188D87230")]
		private bool JPFDSRSEEDN(IEnumerable<PlayerRoomInventoryItemDTO> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8D86760", Offset = "0x8D85560", VA = "0x188D86760")]
		private void EBCMEVDMHLO(RecNet.RoomOffer a, long b, int c, string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8D88620", Offset = "0x8D87420", VA = "0x188D88620")]
		private string PMLPEXJUQID(RecNet.RoomOffer a, int b, string c, [Optional] RoomOfferPurchaseOperationResult? d, [Optional] UpdateResponseTypes? e, [Optional] string f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8D85FE0", Offset = "0x8D84DE0", VA = "0x188D85FE0")]
		private RoomOfferPurchaseOperationResult CUROHKIPGZN(RecNet.RoomOffer a, int b, [Out] long c)
		{
			return default(RoomOfferPurchaseOperationResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8D87D00", Offset = "0x8D86B00", VA = "0x188D87D00", Slot = "29")]
		public void NMPWRHNJWGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8D86CD0", Offset = "0x8D85AD0", VA = "0x188D86CD0")]
		private void HXEHMUHIMSS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8D86F60", Offset = "0x8D85D60", VA = "0x188D86F60", Slot = "25")]
		public bool IDXKQVWEEEO(Guid a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8D862A0", Offset = "0x8D850A0", VA = "0x188D862A0", Slot = "27")]
		public bool DCRTQUUJYON(Guid a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8D86B40", Offset = "0x8D85940", VA = "0x188D86B40", Slot = "26")]
		public bool FIDTLOUJHGW(Guid a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8D89C00", Offset = "0x8D88A00", VA = "0x188D89C00", Slot = "28")]
		public SetPriceOverrideResult XYNPYBTTEXM(Guid a, int? b)
		{
			return default(SetPriceOverrideResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8D87760", Offset = "0x8D86560", VA = "0x188D87760")]
		[AsyncStateMachine(typeof(<DownloadRoomOffers>d__68))]
		private Task KTXASWSOHRN(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8D88240", Offset = "0x8D87040", VA = "0x188D88240")]
		private Task OnRoomLoadStarted(UREAGQBAIUQ args, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8D87160", Offset = "0x8D85F60", VA = "0x188D87160")]
		[AsyncStateMachine(typeof(<OnRoomLoadComplete>d__70))]
		private Task JOYBPGZFQQS(UREAGQBAIUQ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8D87870", Offset = "0x8D86670", VA = "0x188D87870")]
		private static Dictionary<Guid, int> LXVMSFPFJGA(RecNetResult<List<RoomOfferPurchaseCountDTO>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8D85AD0", Offset = "0x8D848D0", VA = "0x188D85AD0")]
		private void BVIQDFOLDIQ(RecNet.RoomOffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8D870F0", Offset = "0x8D85EF0", VA = "0x188D870F0")]
		private void INYUOSCJXGX(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8D88B20", Offset = "0x8D87920", VA = "0x188D88B20")]
		[RPCMethod]
		internal void RpcOfferShowPurchasePrompt(Guid roomOfferId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8D89EA0", Offset = "0x8D88CA0", VA = "0x188D89EA0")]
		[AsyncStateMachine(typeof(<SendGetPlayerRoomOfferPurchaseCountRequest>d__75))]
		private Task<int> YIDMSCMNVGS(XGOJTPBZDNO a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8D88940", Offset = "0x8D87740", VA = "0x188D88940")]
		[RPCMethod]
		internal void RpcGetPlayerRoomOfferPurchaseCount(Guid operationId, Guid roomOfferId, RPCInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8D888C0", Offset = "0x8D876C0", VA = "0x188D888C0")]
		[RPCMethod]
		internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid operationId, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8D88D20", Offset = "0x8D87B20", VA = "0x188D88D20", Slot = "31")]
		public string SKKUNBMBCPD(RoomOfferPurchaseOperationResult a, [Optional] UpdateResponseTypes? b, [Optional] BalanceResponseDTO c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8D89110", Offset = "0x8D87F10", VA = "0x188D89110")]
		private static string TFKBMLSHMVU(UpdateResponseTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8D85D70", Offset = "0x8D84B70", VA = "0x188D85D70")]
		private RecNet.RoomOffer CESOFURPQCJ(RecNet.RoomOffer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8D89B90", Offset = "0x8D88990", VA = "0x188D89B90")]
		private void XXKUNODCIMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8D87BD0", Offset = "0x8D869D0", VA = "0x188D87BD0")]
		private void LYBUXYXUTGI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[DefaultMember("Item")]
	public class QNYQBPXDJMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly Dictionary<Guid, RecNet.RoomOffer> KDHDECVAGRJ;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private long VOQDDKMAYSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xE27A80", Offset = "0xE26880", VA = "0x180E27A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8D8ADF0", Offset = "0x8D89BF0", VA = "0x188D8ADF0")]
		public void NewRoom(long roomId, IEnumerable<RecNet.RoomOffer> roomOffers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8D8AD90", Offset = "0x8D89B90", VA = "0x188D8AD90")]
		public bool NAAVDHLGRQE(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B090", Offset = "0x8D89E90", VA = "0x188D8B090")]
		public bool Remove(Guid roomOfferId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B140", Offset = "0x8D89F40", VA = "0x188D8B140")]
		public bool ZPZWMLMOGRU(RecNet.RoomOffer a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B0F0", Offset = "0x8D89EF0", VA = "0x188D8B0F0")]
		public IEnumerable<RecNet.RoomOffer> YGUUDHLVLWE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8D8ACA0", Offset = "0x8D89AA0", VA = "0x188D8ACA0")]
		public bool CFWDJKSGDZV(Guid a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8D8AD10", Offset = "0x8D89B10", VA = "0x188D8AD10")]
		private bool JXVRSOMDTUG(RecNet.RoomOffer a, RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B2A0", Offset = "0x8D8A0A0", VA = "0x188D8B2A0")]
		public QNYQBPXDJMP()
		{
		}
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
