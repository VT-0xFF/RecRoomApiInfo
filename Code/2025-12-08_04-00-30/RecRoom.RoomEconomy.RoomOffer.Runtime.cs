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
		[Cpp2IlInjected.Address(RVA = "0x8A3C720", Offset = "0x8A3AF20", VA = "0x188A3C720", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2735A30", Offset = "0x2734230", VA = "0x182735A30")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.RoomEconomy.RoomOffer
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface EWNFWRGAJLY : XINISBPPTIQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		ZEXWIEMUQVX ZEXWIEMUQVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface OIVECDLTOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		KGABCXRVRNJ QKEGZDYQINV();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class MKRKQEOHJNA : OIVECDLTOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8A322D0", Offset = "0x8A30AD0", VA = "0x188A322D0")]
		[UKOBXVXKPZF.Session.GameOnly]
		internal static void SWMNZJEUWLS(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		[RecRoom.NoEngine.Common.Preserve]
		public MKRKQEOHJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A32220", Offset = "0x8A30A20", VA = "0x188A32220", Slot = "4")]
		public KGABCXRVRNJ QKEGZDYQINV()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Tested]
	public class ZEXWIEMUQVX : LXDRTSOOGJC, IDisposable, KNRCWYSSSBZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class SGHCKLXMBND
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
				public SGHCKLXMBND <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Guid itemId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x8A36C50", Offset = "0x8A35450", VA = "0x188A36C50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x8A36FC0", Offset = "0x8A357C0", VA = "0x188A36FC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public ZEXWIEMUQVX VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int CPJTZCTPFWM;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public SGHCKLXMBND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8A32460", Offset = "0x8A30C60", VA = "0x188A32460")]
			[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
			internal Task RVWSDXHJTCS(Guid a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8A32340", Offset = "0x8A30B40", VA = "0x188A32340")]
			internal Guid? EIIYDPWYDRF(Guid a)
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
			public ZEXWIEMUQVX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public RHIZVYSCBOY player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public Guid roomOfferId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8A32550", Offset = "0x8A30D50", VA = "0x188A32550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8A32930", Offset = "0x8A31130", VA = "0x188A32930", Slot = "5")]
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
			public ZEXWIEMUQVX <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8A329A0", Offset = "0x8A311A0", VA = "0x188A329A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8A32F90", Offset = "0x8A31790", VA = "0x188A32F90", Slot = "5")]
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
			public ZEXWIEMUQVX <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8A33000", Offset = "0x8A31800", VA = "0x188A33000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8A335A0", Offset = "0x8A31DA0", VA = "0x188A335A0", Slot = "5")]
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
			public ZEXWIEMUQVX <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8A33610", Offset = "0x8A31E10", VA = "0x188A33610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8A33DF0", Offset = "0x8A325F0", VA = "0x188A33DF0", Slot = "5")]
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
			public ZEXWIEMUQVX <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8A33E50", Offset = "0x8A32650", VA = "0x188A33E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8A34280", Offset = "0x8A32A80", VA = "0x188A34280", Slot = "5")]
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
			public ZEXWIEMUQVX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private TaskAwaiter<Task> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8A342F0", Offset = "0x8A32AF0", VA = "0x188A342F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8A34960", Offset = "0x8A33160", VA = "0x188A34960", Slot = "5")]
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
			public ZEXWIEMUQVX <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8A35360", Offset = "0x8A33B60", VA = "0x188A35360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8A35900", Offset = "0x8A34100", VA = "0x188A35900", Slot = "5")]
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
			public ZEXWIEMUQVX <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8A349C0", Offset = "0x8A331C0", VA = "0x188A349C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8A352F0", Offset = "0x8A33AF0", VA = "0x188A352F0", Slot = "5")]
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
			public ZEXWIEMUQVX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public RHIZVYSCBOY player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8A35970", Offset = "0x8A34170", VA = "0x188A35970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8A35EC0", Offset = "0x8A346C0", VA = "0x188A35EC0", Slot = "5")]
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
			public ZEXWIEMUQVX <>4__this;

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
			private SGHCKLXMBND <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x8A35F30", Offset = "0x8A34730", VA = "0x188A35F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8A36BE0", Offset = "0x8A353E0", VA = "0x188A36BE0", Slot = "5")]
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
			public ZEXWIEMUQVX <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8A37020", Offset = "0x8A35820", VA = "0x188A37020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8A376A0", Offset = "0x8A35EA0", VA = "0x188A376A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly TimeSpan OLZREAUHIHR;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string LIDQKZEZCKT = "econ_room_offer_gate";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const string RJOMDUUJRYR = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string IRJPCEFVMOA = "CV2_Purchase_Prompt_Chip";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly LMKHJMNXYQC FFDEHPAYKOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly AXMQLGQBSBH NERWDZTOFKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly KAWLYJYMFUG ZQDVNRIFAEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly XXWNNZHXIHL WYETQWNOSDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly OEVXLFINOMM PEBZRYAEEZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly EWNFWRGAJLY WNTNXQSUSPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly EZEWCMMPXOE EMVJUYYRCBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly PCRMPPJHYZZ VVADFBEYAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TSHTTNEGFUE XBOQTVQIDVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly LQJJUOWYIRI BYMDEFTNGKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly KGABCXRVRNJ IFXLRHNYRCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Dictionary<Guid, int> JCBRTRLZECT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IDisposable UGVSNSLRWGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Task RXFJUSUHZAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CancellationTokenSource IDFXZRPDDQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private long AGZKMGDYPCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool VACBKMVGOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly HXSONKMYTQG RYAHDEWKAFA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private FTVZVRKLTVG HALNHMPUGJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8A38560", Offset = "0x8A36D60", VA = "0x188A38560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MWKYWAOJZRV RMLAJLIMFXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xBB29C0", Offset = "0xBB11C0", VA = "0x180BB29C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xBB1AB0", Offset = "0xBB02B0", VA = "0x180BB1AB0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IXZHGEZUADS<RecNet.RoomOffer> GBDCLZOIZWK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAA9D50", Offset = "0xAA8550", VA = "0x180AA9D50", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAA9D10", Offset = "0xAA8510", VA = "0x180AA9D10", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IXZHGEZUADS<Guid> YUCCBXIBZHZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xC37940", Offset = "0xC36140", VA = "0x180C37940", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD10010", Offset = "0xD0E810", VA = "0x180D10010", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IXZHGEZUADS<Guid> HVCPZHPNSTW
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xC11710", Offset = "0xC0FF10", VA = "0x180C11710", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x144B510", Offset = "0x1449D10", VA = "0x18144B510", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8A3ADD0", Offset = "0x8A395D0", VA = "0x188A3ADD0")]
		[UKOBXVXKPZF.Session.GameOnly]
		internal static void SWMNZJEUWLS(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C010", Offset = "0x8A3A810", VA = "0x188A3C010")]
		[RecRoom.NoEngine.Common.Preserve]
		public ZEXWIEMUQVX([Inject(null)] LMKHJMNXYQC recNetRoomOffer, [Inject(null)] AXMQLGQBSBH matchmakingProvider, [Inject(null)] MXHAAQVHJOK roomLoader, [Inject(null)] KAWLYJYMFUG taskDelay, [Inject(null)] OIVECDLTOEN cacheFactory, [Inject(null)] XXWNNZHXIHL statsig, [Inject("ShowPurchasePromptRateLimiter")] OEVXLFINOMM purchasePromptRateLimiter, [Inject(null)] EWNFWRGAJLY rpcForwarder, [Inject(null)] DRYMHQJXVYT recNetPhotonAccess, [Inject(null)] EZEWCMMPXOE callbacks, [Inject(null)] PCRMPPJHYZZ roomInventoryManagerInternal, [Inject(null)] TSHTTNEGFUE recNetStorefronts, [Inject(null)] LQJJUOWYIRI analyticsHelper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8A38140", Offset = "0x8A36940", VA = "0x188A38140", Slot = "30")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8A390D0", Offset = "0x8A378D0", VA = "0x188A390D0", Slot = "12")]
		[AsyncStateMachine(typeof(<CreateRoomOffer>d__43))]
		public Task<Result<RecNet.RoomOffer, string>> MCDRBRZLRGK(Guid? a, long b, string c, string d, string e, int f, bool g, int h, int i, RoomOfferType j, UgcPurchasableItemVisibility k, [Optional] Dictionary<Guid, int> l, [Optional] Guid? m, bool n = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BCA0", Offset = "0x8A3A4A0", VA = "0x188A3BCA0", Slot = "13")]
		[AsyncStateMachine(typeof(<UpdateRoomOffer>d__44))]
		public Task<Result<RecNet.RoomOffer, string>> XXDMXLKRZCR(Guid a, long b, string c, string d, string e, int f, bool g, int h, int i, RoomOfferType j, UgcPurchasableItemVisibility k, [Optional] Dictionary<Guid, int> l, [Optional] Guid? m)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8A38730", Offset = "0x8A36F30", VA = "0x188A38730", Slot = "14")]
		[AsyncStateMachine(typeof(<DeleteRoomOffer>d__45))]
		public Task<Result<bool, string>> GYKZQHZOINV(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8A37710", Offset = "0x8A35F10", VA = "0x188A37710", Slot = "15")]
		public IEnumerable<RecNet.RoomOffer> AJVUIUVXQRI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BE70", Offset = "0x8A3A670", VA = "0x188A3BE70", Slot = "16")]
		[AsyncStateMachine(typeof(<GetRecentPurchasedRoomOffersForRoom>d__47))]
		public Task<List<RoomOfferLastPurchaseDTO>> ZUKAISUAUFT(long a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8A38850", Offset = "0x8A37050", VA = "0x188A38850", Slot = "19")]
		public bool KBTOKTWFJVC(Guid a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8A38B50", Offset = "0x8A37350", VA = "0x188A38B50", Slot = "17")]
		public bool KGSPJZFSTTV(Guid a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8A39A20", Offset = "0x8A38220", VA = "0x188A39A20", Slot = "18")]
		public bool OPBROVUZZSJ(string a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8A3AE40", Offset = "0x8A39640", VA = "0x188A3AE40", Slot = "20")]
		public void TPVUHDMQPAH(RHIZVYSCBOY a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8A38CF0", Offset = "0x8A374F0", VA = "0x188A38CF0", Slot = "21")]
		[AsyncStateMachine(typeof(<CV2GetPlayerRoomOfferPurchaseCount>d__52))]
		public Task<int> LIKYXGTOVWC(RHIZVYSCBOY a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BA30", Offset = "0x8A3A230", VA = "0x188A3BA30", Slot = "22")]
		public bool XQJVPDCSRMJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A3B190", Offset = "0x8A39990", VA = "0x188A3B190", Slot = "23")]
		public bool VCJLPEGGSTG(Guid a, [Out] List<string> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8A385B0", Offset = "0x8A36DB0", VA = "0x188A385B0", Slot = "24")]
		[AsyncStateMachine(typeof(<PurchaseRoomOffer>d__55))]
		public Task<Result<bool, string>> ERMRTPJNSDN(RecNet.RoomOffer a, long b, int c, string d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8A3B8D0", Offset = "0x8A3A0D0", VA = "0x188A3B8D0")]
		[AsyncStateMachine(typeof(<PurchaseRoomOfferInternal>d__56))]
		private Task<Result<bool, string>> VKJHBQGXPYG(RecNet.RoomOffer a, long b, long c, string d, int e = 1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8A38400", Offset = "0x8A36C00", VA = "0x188A38400")]
		[AsyncStateMachine(typeof(<SendRecNetRoomOfferPurchaseRequest>d__57))]
		private Task<RoomOfferPurchaseResponseDTO> EIOXSLFFWMF(RecNet.RoomOffer a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8A3B580", Offset = "0x8A39D80", VA = "0x188A3B580")]
		private bool VDGIWVEXOZV(IEnumerable<PlayerRoomInventoryItemDTO> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A310", Offset = "0x8A38B10", VA = "0x188A3A310")]
		private void RQQRBHWTFQA(RecNet.RoomOffer a, long b, int c, string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8A396A0", Offset = "0x8A37EA0", VA = "0x188A396A0")]
		private string NCLDQLYOJUD(RecNet.RoomOffer a, int b, string c, [Optional] RoomOfferPurchaseOperationResult? d, [Optional] UpdateResponseTypes? e, [Optional] string f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A050", Offset = "0x8A38850", VA = "0x188A3A050")]
		private RoomOfferPurchaseOperationResult PIXZKPDVMYL(RecNet.RoomOffer a, int b, [Out] long c)
		{
			return default(RoomOfferPurchaseOperationResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8A38720", Offset = "0x8A36F20", VA = "0x188A38720", Slot = "29")]
		public void GBVZQASWJJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8A37940", Offset = "0x8A36140", VA = "0x188A37940")]
		private void BOEAMTIWGLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8A3B000", Offset = "0x8A39800", VA = "0x188A3B000", Slot = "25")]
		public bool UYATYMXJBBU(Guid a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8A377B0", Offset = "0x8A35FB0", VA = "0x188A377B0", Slot = "27")]
		public bool ATKFNSHUZGV(Guid a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BB10", Offset = "0x8A3A310", VA = "0x188A3BB10", Slot = "26")]
		public bool XSDIGDPGXGK(Guid a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8A38E30", Offset = "0x8A37630", VA = "0x188A38E30", Slot = "28")]
		public SetPriceOverrideResult LZNUZICTKDQ(Guid a, int? b)
		{
			return default(SetPriceOverrideResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8A38A40", Offset = "0x8A37240", VA = "0x188A38A40")]
		[AsyncStateMachine(typeof(<DownloadRoomOffers>d__68))]
		private Task KFMYHCBRGDR(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8A39C70", Offset = "0x8A38470", VA = "0x188A39C70")]
		private Task OnRoomLoadStarted(KQLCQATBHLS args, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8A38C20", Offset = "0x8A37420", VA = "0x188A38C20")]
		[AsyncStateMachine(typeof(<OnRoomLoadComplete>d__70))]
		private Task KRMYNGFIOJE(KQLCQATBHLS a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8A37DE0", Offset = "0x8A365E0", VA = "0x188A37DE0")]
		private static Dictionary<Guid, int> DMENQPKJHJG(RecNetResult<List<RoomOfferPurchaseCountDTO>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8A38710", Offset = "0x8A36F10", VA = "0x188A38710")]
		private void EVFWZJUALPO(RecNet.RoomOffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8A38390", Offset = "0x8A36B90", VA = "0x188A38390")]
		private void EFTILMWBBST(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8A3AAA0", Offset = "0x8A392A0", VA = "0x188A3AAA0")]
		[RPCMethod]
		internal void RpcOfferShowPurchasePrompt(Guid roomOfferId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8A3AC90", Offset = "0x8A39490", VA = "0x188A3AC90")]
		[AsyncStateMachine(typeof(<SendGetPlayerRoomOfferPurchaseCountRequest>d__75))]
		private Task<int> SDYIEUSYFVI(RHIZVYSCBOY a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A8D0", Offset = "0x8A390D0", VA = "0x188A3A8D0")]
		[RPCMethod]
		internal void RpcGetPlayerRoomOfferPurchaseCount(Guid operationId, Guid roomOfferId, RPCInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A850", Offset = "0x8A39050", VA = "0x188A3A850")]
		[RPCMethod]
		internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid operationId, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8A392B0", Offset = "0x8A37AB0", VA = "0x188A392B0", Slot = "31")]
		public string MMAUBUIAWXP(RoomOfferPurchaseOperationResult a, [Optional] UpdateResponseTypes? b, [Optional] BalanceResponseDTO c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A760", Offset = "0x8A38F60", VA = "0x188A3A760")]
		private static string RWEDPARUEBA(UpdateResponseTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8A37C40", Offset = "0x8A36440", VA = "0x188A37C40")]
		private RecNet.RoomOffer COOLJFKUQXL(RecNet.RoomOffer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8A37BD0", Offset = "0x8A363D0", VA = "0x188A37BD0")]
		private void CGRCISDZNSB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8A398F0", Offset = "0x8A380F0", VA = "0x188A398F0")]
		private void NWJYLAQIUBC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[DefaultMember("Item")]
	public class KGABCXRVRNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Dictionary<Guid, RecNet.RoomOffer> VFPYZGXPKLZ;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private long NYUETJDFKIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xB447B0", Offset = "0xB42FB0", VA = "0x180B447B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8A31D00", Offset = "0x8A30500", VA = "0x188A31D00")]
		public void NewRoom(long roomId, IEnumerable<RecNet.RoomOffer> roomOffers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8A31C30", Offset = "0x8A30430", VA = "0x188A31C30")]
		public bool HUFYAOWUJVG(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8A320F0", Offset = "0x8A308F0", VA = "0x188A320F0")]
		public bool Remove(Guid roomOfferId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8A31F90", Offset = "0x8A30790", VA = "0x188A31F90")]
		public bool RUCWWBVBXLQ(RecNet.RoomOffer a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8A32150", Offset = "0x8A30950", VA = "0x188A32150")]
		public IEnumerable<RecNet.RoomOffer> TNYWZUMXEAY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8A31C90", Offset = "0x8A30490", VA = "0x188A31C90")]
		public bool KGSPJZFSTTV(Guid a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8A31BB0", Offset = "0x8A303B0", VA = "0x188A31BB0")]
		private bool BDKKGEFTWUW(RecNet.RoomOffer a, RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8A321A0", Offset = "0x8A309A0", VA = "0x188A321A0")]
		public KGABCXRVRNJ()
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
