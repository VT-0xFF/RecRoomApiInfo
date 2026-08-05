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
using RecRoom.DataLayer;
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
		[Cpp2IlInjected.Address(RVA = "0x89D1EF0", Offset = "0x89D0AF0", VA = "0x1889D1EF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2721D10", Offset = "0x2720910", VA = "0x182721D10")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.RoomEconomy.RoomOffer
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface MHZWTNLFZGW : XFNXDNERJDW
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		KIWMJTDGNUJ KIWMJTDGNUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface RTACUIJQJPX
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LOGXKFLTKAT KBIDVWEBGLN();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class PQEVWFEWYEK : RTACUIJQJPX
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x89CCC90", Offset = "0x89CB890", VA = "0x1889CCC90")]
		[YLZSHGPPZTN.Session.GameOnly]
		internal static void UYMINUXTTWE(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		[RecRoom.NoEngine.Common.Preserve]
		public PQEVWFEWYEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89CCBE0", Offset = "0x89CB7E0", VA = "0x1889CCBE0", Slot = "4")]
		public LOGXKFLTKAT KBIDVWEBGLN()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Tested]
	public class KIWMJTDGNUJ : EFOZZZFRFFK, IDisposable, HMUXYZFPCBN
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class IHUCMGNOJXL
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
				public IHUCMGNOJXL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Guid itemId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x89D1430", Offset = "0x89D0030", VA = "0x1889D1430", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x89D17A0", Offset = "0x89D03A0", VA = "0x1889D17A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public KIWMJTDGNUJ BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int SMKDPFZZIKM;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public IHUCMGNOJXL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x89C7460", Offset = "0x89C6060", VA = "0x1889C7460")]
			[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
			internal Task LYVOZDYZCSC(Guid a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x89C7340", Offset = "0x89C5F40", VA = "0x1889C7340")]
			internal Guid? EGUUKISGKKD(Guid a)
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
			public KIWMJTDGNUJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public HNNNRVHBOIU player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public Guid roomOfferId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x89CCD00", Offset = "0x89CB900", VA = "0x1889CCD00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x89CD0E0", Offset = "0x89CBCE0", VA = "0x1889CD0E0", Slot = "5")]
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
			public KIWMJTDGNUJ <>4__this;

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

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public UgcPurchasableItemVisibility visibility;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public Dictionary<Guid, int> roomInventoryItemMappings;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public Guid? priceUnitId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public bool allowRename;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private TaskAwaiter<RecNetResult<RecNet.RoomOffer>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x89CD150", Offset = "0x89CBD50", VA = "0x1889CD150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x89CD740", Offset = "0x89CC340", VA = "0x1889CD740", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public AsyncTaskMethodBuilder<Result<bool, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public KIWMJTDGNUJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public Guid roomOfferId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private RecNet.RoomOffer <existingRoomOffer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private TaskAwaiter<RecNetResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x89CD7B0", Offset = "0x89CC3B0", VA = "0x1889CD7B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x89CDD50", Offset = "0x89CC950", VA = "0x1889CDD50", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public KIWMJTDGNUJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private Task<RecNetResult<List<RoomOfferPurchaseCountDTO>>> <purchaseCountsTask>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private TaskAwaiter<List<RecNet.RoomOffer>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private TaskAwaiter<RecNetResult<List<RoomOfferPurchaseCountDTO>>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x89CDDC0", Offset = "0x89CC9C0", VA = "0x1889CDDC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x89CE5B0", Offset = "0x89CD1B0", VA = "0x1889CE5B0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public AsyncTaskMethodBuilder<List<RoomOfferLastPurchaseDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public KIWMJTDGNUJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private TaskAwaiter<RecNetResult<List<RoomOfferLastPurchaseDTO>>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x89CE610", Offset = "0x89CD210", VA = "0x1889CE610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x89CEA40", Offset = "0x89CD640", VA = "0x1889CEA40", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public KIWMJTDGNUJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private TaskAwaiter<Task> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x89CEAB0", Offset = "0x89CD6B0", VA = "0x1889CEAB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x89CF130", Offset = "0x89CDD30", VA = "0x1889CF130", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public AsyncTaskMethodBuilder<Result<bool, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public KIWMJTDGNUJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public RecNet.RoomOffer roomOffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public string purchaseSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public long requestedPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private TaskAwaiter<Result<bool, string>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x89CFB30", Offset = "0x89CE730", VA = "0x1889CFB30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x89D00D0", Offset = "0x89CECD0", VA = "0x1889D00D0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public AsyncTaskMethodBuilder<Result<bool, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public KIWMJTDGNUJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public RecNet.RoomOffer roomOffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public string purchaseSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public long requestedPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public long initialBalance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private RoomOfferPurchaseOperationResult <operationResult>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int <attemptNumber>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private RoomOfferPurchaseResponseDTO <response>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private TaskAwaiter<RoomOfferPurchaseResponseDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x89CF190", Offset = "0x89CDD90", VA = "0x1889CF190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x89CFAC0", Offset = "0x89CE6C0", VA = "0x1889CFAC0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public KIWMJTDGNUJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public HNNNRVHBOIU player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x89D0140", Offset = "0x89CED40", VA = "0x1889D0140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x89D06A0", Offset = "0x89CF2A0", VA = "0x1889D06A0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<RoomOfferPurchaseResponseDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public KIWMJTDGNUJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public int requestedPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public RecNet.RoomOffer roomOffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private IHUCMGNOJXL <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private Dictionary<Guid, Guid?> <concurrencyCodeByItemIdMap>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private Guid <itemId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private TaskAwaiter<RoomOfferPurchaseResponseDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x89D0710", Offset = "0x89CF310", VA = "0x1889D0710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x89D13C0", Offset = "0x89CFFC0", VA = "0x1889D13C0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public AsyncTaskMethodBuilder<Result<RecNet.RoomOffer, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public KIWMJTDGNUJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public Guid roomOfferOriginId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public string description;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public string imageName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public int price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public bool hasDynamicPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public int minimumDynamicPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public int maximumDynamicPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public RoomOfferType roomOfferType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public UgcPurchasableItemVisibility visibility;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public Dictionary<Guid, int> roomInventoryItemMappings;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public Guid? priceUnitId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private TaskAwaiter<RecNetResult<RecNet.RoomOffer>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x89D1800", Offset = "0x89D0400", VA = "0x1889D1800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x89D1E80", Offset = "0x89D0A80", VA = "0x1889D1E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly TimeSpan POCFPDNYARZ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string XWJRZMJRSNB = "econ_room_offer_gate";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const string TSNTXXGSFXP = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string MCOTXCQVZEE = "CV2_Purchase_Prompt_Chip";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly STNAMJIHYEG YQDHZHKKMHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly BDMGSZMPFGF AYXQUJPHWDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly EOKASDKKJCO DTVZRDBRLWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly UWTFUWBHDBX JLEQEFITJOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly RBOASLEGMSU SDVOKDLSVKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly MHZWTNLFZGW MLUCFCKDWPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JQMITVAHJVS TIDVWLUQWFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly PZHYKQGMTPF SLGUODELBXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly NNICTGOUKKQ UXTKKYRXSET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly HXFXHNYTPOW ECOIXTNYGAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly LOGXKFLTKAT MUMQPHAICCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Dictionary<Guid, int> VZVJXWOKAVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IDisposable LXRYVTZFTNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Task UGZYJNLVWML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CancellationTokenSource MQVDZEFZNMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private long BJQVGLMANSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool AHBYTLQTEJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly VYVSKDDARWG XZRHMVFSAPQ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private NSJDIDNUXGY GEADMQNZKZV
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x89C86D0", Offset = "0x89C72D0", VA = "0x1889C86D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ANFWHCNXABV LCEMTUDNLWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB82670", Offset = "0xB81270", VA = "0x180B82670", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xB81D90", Offset = "0xB80990", VA = "0x180B81D90", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NWSEZICLNSM<RecNet.RoomOffer> VBDEJCEZRMK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA96C10", Offset = "0xA95810", VA = "0x180A96C10", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA96EF0", Offset = "0xA95AF0", VA = "0x180A96EF0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public NWSEZICLNSM<Guid> NKLERDRIXAT
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xC33090", Offset = "0xC31C90", VA = "0x180C33090", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xCE42B0", Offset = "0xCE2EB0", VA = "0x180CE42B0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public NWSEZICLNSM<Guid> SRISELQDHKY
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xBE1070", Offset = "0xBDFC70", VA = "0x180BE1070", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x1210980", Offset = "0x120F580", VA = "0x181210980", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x89CACA0", Offset = "0x89C98A0", VA = "0x1889CACA0")]
		[YLZSHGPPZTN.Session.GameOnly]
		internal static void UYMINUXTTWE(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x89CBE40", Offset = "0x89CAA40", VA = "0x1889CBE40")]
		[RecRoom.NoEngine.Common.Preserve]
		public KIWMJTDGNUJ([Inject(null)] STNAMJIHYEG recNetRoomOffer, [Inject(null)] BDMGSZMPFGF matchmakingProvider, [Inject(null)] CYXTJYBRNXU roomLoader, [Inject(null)] EOKASDKKJCO taskDelay, [Inject(null)] RTACUIJQJPX cacheFactory, [Inject(null)] UWTFUWBHDBX statsig, [Inject("ShowPurchasePromptRateLimiter")] RBOASLEGMSU purchasePromptRateLimiter, [Inject(null)] MHZWTNLFZGW rpcForwarder, [Inject(null)] PHJVFDIWVAP recNetPhotonAccess, [Inject(null)] JQMITVAHJVS callbacks, [Inject(null)] PZHYKQGMTPF roomInventoryManagerInternal, [Inject(null)] NNICTGOUKKQ recNetStorefronts, [Inject(null)] HXFXHNYTPOW analyticsHelper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x89C7E50", Offset = "0x89C6A50", VA = "0x1889C7E50", Slot = "30")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x89C8F50", Offset = "0x89C7B50", VA = "0x1889C8F50", Slot = "12")]
		[AsyncStateMachine(typeof(<CreateRoomOffer>d__43))]
		public Task<Result<RecNet.RoomOffer, string>> NELHNZPYAGS(Guid? a, long b, string c, string d, string e, int f, bool g, int h, int i, RoomOfferType j, UgcPurchasableItemVisibility k, [Optional] Dictionary<Guid, int> l, [Optional] Guid? m, bool n = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x89CAD10", Offset = "0x89C9910", VA = "0x1889CAD10", Slot = "13")]
		[AsyncStateMachine(typeof(<UpdateRoomOffer>d__44))]
		public Task<Result<RecNet.RoomOffer, string>> VCPDQXLQEGZ(Guid a, long b, string c, string d, string e, int f, bool g, int h, int i, RoomOfferType j, UgcPurchasableItemVisibility k, [Optional] Dictionary<Guid, int> l, [Optional] Guid? m)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x89CAA50", Offset = "0x89C9650", VA = "0x1889CAA50", Slot = "14")]
		[AsyncStateMachine(typeof(<DeleteRoomOffer>d__45))]
		public Task<Result<bool, string>> TALPHKZCQVJ(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x89C8720", Offset = "0x89C7320", VA = "0x1889C8720", Slot = "15")]
		public IEnumerable<RecNet.RoomOffer> IXYKMEDZXEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x89CAB70", Offset = "0x89C9770", VA = "0x1889CAB70", Slot = "16")]
		[AsyncStateMachine(typeof(<GetRecentPurchasedRoomOffersForRoom>d__47))]
		public Task<List<RoomOfferLastPurchaseDTO>> TSJFXDDRAQJ(long a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x89C8BD0", Offset = "0x89C77D0", VA = "0x1889C8BD0", Slot = "19")]
		public bool MLREAIUBCQM(Guid a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x89C8330", Offset = "0x89C6F30", VA = "0x1889C8330", Slot = "17")]
		public bool GCRZOFBEGQD(Guid a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x89CA710", Offset = "0x89C9310", VA = "0x1889CA710", Slot = "18")]
		public bool SWZOPCEMCSZ(string a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x89C87C0", Offset = "0x89C73C0", VA = "0x1889C87C0", Slot = "20")]
		public void JDQJLXSRXSX(HNNNRVHBOIU a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x89C7C00", Offset = "0x89C6800", VA = "0x1889C7C00", Slot = "21")]
		[AsyncStateMachine(typeof(<CV2GetPlayerRoomOfferPurchaseCount>d__52))]
		public Task<int> CUPXJXZOBRQ(HNNNRVHBOIU a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x89C8990", Offset = "0x89C7590", VA = "0x1889C8990", Slot = "22")]
		public bool KYYFXRRKVND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x89C9B60", Offset = "0x89C8760", VA = "0x1889C9B60", Slot = "23")]
		public bool PYAWMPVSDQM(Guid a, [Out] List<string> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x89C8A70", Offset = "0x89C7670", VA = "0x1889C8A70", Slot = "24")]
		[AsyncStateMachine(typeof(<PurchaseRoomOffer>d__55))]
		public Task<Result<bool, string>> LYIMOZYGRAL(RecNet.RoomOffer a, long b, int c, string d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x89CB580", Offset = "0x89CA180", VA = "0x1889CB580")]
		[AsyncStateMachine(typeof(<PurchaseRoomOfferInternal>d__56))]
		private Task<Result<bool, string>> XGBQXHKUADI(RecNet.RoomOffer a, long b, long c, string d, int e = 1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x89CBC70", Offset = "0x89CA870", VA = "0x1889CBC70")]
		[AsyncStateMachine(typeof(<SendRecNetRoomOfferPurchaseRequest>d__57))]
		private Task<RoomOfferPurchaseResponseDTO> ZXOBRAVRIZP(RecNet.RoomOffer a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x89C7550", Offset = "0x89C6150", VA = "0x1889C7550")]
		private bool BFVXYIFWQHF(IEnumerable<PlayerRoomInventoryItemDTO> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x89CAEE0", Offset = "0x89C9AE0", VA = "0x1889CAEE0")]
		private void WNIXAVOXKEA(RecNet.RoomOffer a, long b, int c, string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x89C80D0", Offset = "0x89C6CD0", VA = "0x1889C80D0")]
		private string FCZQKYVYUBZ(RecNet.RoomOffer a, int b, string c, [Optional] RoomOfferPurchaseOperationResult? d, [Optional] UpdateResponseTypes? e, [Optional] string f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x89CB2C0", Offset = "0x89C9EC0", VA = "0x1889CB2C0")]
		private RoomOfferPurchaseOperationResult WTLSGEKSDYL(RecNet.RoomOffer a, int b, [Out] long c)
		{
			return default(RoomOfferPurchaseOperationResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x89C80C0", Offset = "0x89C6CC0", VA = "0x1889C80C0", Slot = "29")]
		public void ETDFIRMRJZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x89C9130", Offset = "0x89C7D30", VA = "0x1889C9130")]
		private void OOQWIAMLVKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x89C8DC0", Offset = "0x89C79C0", VA = "0x1889C8DC0", Slot = "25")]
		public bool NBNAUAYSMTI(Guid a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x89C8540", Offset = "0x89C7140", VA = "0x1889C8540", Slot = "27")]
		public bool GSHWOLVVQZP(Guid a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x89C99D0", Offset = "0x89C85D0", VA = "0x1889C99D0", Slot = "26")]
		public bool PXJJLYJYTKG(Guid a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x89CA020", Offset = "0x89C8C20", VA = "0x1889CA020", Slot = "28")]
		public SetPriceOverrideResult RTLDUBSLGMC(Guid a, int? b)
		{
			return default(SetPriceOverrideResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x89C7D40", Offset = "0x89C6940", VA = "0x1889C7D40")]
		[AsyncStateMachine(typeof(<DownloadRoomOffers>d__68))]
		private Task DDFYCVICETV(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x89C9500", Offset = "0x89C8100", VA = "0x1889C9500")]
		private Task OnRoomLoadStarted(HQPJHIWQEWM args, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x89C9F50", Offset = "0x89C8B50", VA = "0x1889C9F50")]
		[AsyncStateMachine(typeof(<OnRoomLoadComplete>d__70))]
		private Task QLPSNCDDCVI(HQPJHIWQEWM a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x89C78A0", Offset = "0x89C64A0", VA = "0x1889C78A0")]
		private static Dictionary<Guid, int> CUABXLUKNLG(RecNetResult<List<RoomOfferPurchaseCountDTO>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x89C8530", Offset = "0x89C7130", VA = "0x1889C8530")]
		private void GRFEDCCHEJC(RecNet.RoomOffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x89C9960", Offset = "0x89C8560", VA = "0x1889C9960")]
		private void PNQIQKTJMZV(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x89CA520", Offset = "0x89C9120", VA = "0x1889CA520")]
		[RPCMethod]
		internal void RpcOfferShowPurchasePrompt(Guid roomOfferId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x89C93C0", Offset = "0x89C7FC0", VA = "0x1889C93C0")]
		[AsyncStateMachine(typeof(<SendGetPlayerRoomOfferPurchaseCountRequest>d__75))]
		private Task<int> OOWZIJHUKCO(HNNNRVHBOIU a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x89CA340", Offset = "0x89C8F40", VA = "0x1889CA340")]
		[RPCMethod]
		internal void RpcGetPlayerRoomOfferPurchaseCount(Guid operationId, Guid roomOfferId, RPCInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x89CA2C0", Offset = "0x89C8EC0", VA = "0x1889CA2C0")]
		[RPCMethod]
		internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid operationId, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x89CB6E0", Offset = "0x89CA2E0", VA = "0x1889CB6E0", Slot = "31")]
		public string YAUKFRUYGWV(RoomOfferPurchaseOperationResult a, [Optional] UpdateResponseTypes? b, [Optional] BalanceResponseDTO c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x89CA960", Offset = "0x89C9560", VA = "0x1889CA960")]
		private static string SXLNHHTZMIW(UpdateResponseTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x89CBAD0", Offset = "0x89CA6D0", VA = "0x1889CBAD0")]
		private RecNet.RoomOffer YOUTNFTRLEJ(RecNet.RoomOffer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x89C98F0", Offset = "0x89C84F0", VA = "0x1889C98F0")]
		private void PAOPWTOVOBT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x89C8400", Offset = "0x89C7000", VA = "0x1889C8400")]
		private void GHOHZZAEHAU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[DefaultMember("Item")]
	public class LOGXKFLTKAT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Dictionary<Guid, RecNet.RoomOffer> UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private long DMMXAHIJOPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xB0BBF0", Offset = "0xB0A7F0", VA = "0x180B0BBF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x89CC650", Offset = "0x89CB250", VA = "0x1889CC650")]
		public void NewRoom(long roomId, IEnumerable<RecNet.RoomOffer> roomOffers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x89CC8F0", Offset = "0x89CB4F0", VA = "0x1889CC8F0")]
		public bool PBVEYUSDCOM(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x89CCAB0", Offset = "0x89CB6B0", VA = "0x1889CCAB0")]
		public bool Remove(Guid roomOfferId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x89CC950", Offset = "0x89CB550", VA = "0x1889CC950")]
		public bool PPEFCMNTGTY(RecNet.RoomOffer a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x89CCB10", Offset = "0x89CB710", VA = "0x1889CCB10")]
		public IEnumerable<RecNet.RoomOffer> ZTZFIJQACVK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x89CC560", Offset = "0x89CB160", VA = "0x1889CC560")]
		public bool GCRZOFBEGQD(Guid a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x89CC5D0", Offset = "0x89CB1D0", VA = "0x1889CC5D0")]
		private bool HRLALUHTDFM(RecNet.RoomOffer a, RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x89CCB60", Offset = "0x89CB760", VA = "0x1889CCB60")]
		public LOGXKFLTKAT()
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
