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
		[Cpp2IlInjected.Address(RVA = "0x9FA32D0", Offset = "0x9FA26D0", VA = "0x189FA32D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29FCDD0", Offset = "0x29FC1D0", VA = "0x1829FCDD0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.RoomEconomy.RoomOffer
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface RIGNTTABGED : XVLFLEJZBFF
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		DEMTUQTYPAQ DEMTUQTYPAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface MCEFNHDGEUI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		QPODBLLWODK QNVSRXIBQME();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class QMAZJECCLIR : MCEFNHDGEUI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9F9D480", Offset = "0x9F9C880", VA = "0x189F9D480")]
		[BQDQKYYGTTM.Session.GameOnly]
		internal static void TRWAHLHDOMR(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		[RecRoom.NoEngine.Common.Preserve]
		public QMAZJECCLIR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9F9D3D0", Offset = "0x9F9C7D0", VA = "0x189F9D3D0", Slot = "4")]
		public QPODBLLWODK QNVSRXIBQME()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Tested]
	public class DEMTUQTYPAQ : ZERXZELWBJN, IDisposable, KLKDAWMSZIM
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class QVSPQFCPAZM
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
				public QVSPQFCPAZM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Guid itemId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x9FA27E0", Offset = "0x9FA1BE0", VA = "0x189FA27E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x9FA2B60", Offset = "0x9FA1F60", VA = "0x189FA2B60", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public DEMTUQTYPAQ IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int LNPFQXJHARX;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public QVSPQFCPAZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9F9DB70", Offset = "0x9F9CF70", VA = "0x189F9DB70")]
			[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
			internal Task HRTCFJBEIYV(Guid a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9F9DC60", Offset = "0x9F9D060", VA = "0x189F9DC60")]
			internal Guid? UKJOVHCNLES(Guid a)
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
			public DEMTUQTYPAQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public PPTCRKDFMWF player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public Guid roomOfferId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9F9DD80", Offset = "0x9F9D180", VA = "0x189F9DD80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E160", Offset = "0x9F9D560", VA = "0x189F9E160", Slot = "5")]
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
			public DEMTUQTYPAQ <>4__this;

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

			[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public bool isGiftable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public UgcPurchasableItemVisibility visibility;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public Dictionary<Guid, int> roomInventoryItemMappings;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public Guid? priceUnitId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public bool allowRename;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private TaskAwaiter<RecNetResult<RecNet.RoomOffer>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E1D0", Offset = "0x9F9D5D0", VA = "0x189F9E1D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E7E0", Offset = "0x9F9DBE0", VA = "0x189F9E7E0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public AsyncTaskMethodBuilder<Result<bool, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public DEMTUQTYPAQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public Guid roomOfferId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private RecNet.RoomOffer <existingRoomOffer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TaskAwaiter<RecNetResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9F9E850", Offset = "0x9F9DC50", VA = "0x189F9E850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9F9EE00", Offset = "0x9F9E200", VA = "0x189F9EE00", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public DEMTUQTYPAQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private Task<RecNetResult<List<RoomOfferPurchaseCountDTO>>> <purchaseCountsTask>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private TaskAwaiter<List<RecNet.RoomOffer>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private TaskAwaiter<RecNetResult<List<RoomOfferPurchaseCountDTO>>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9F9EE70", Offset = "0x9F9E270", VA = "0x189F9EE70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F660", Offset = "0x9F9EA60", VA = "0x189F9F660", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public AsyncTaskMethodBuilder<List<RoomOfferLastPurchaseDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public DEMTUQTYPAQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private TaskAwaiter<RecNetResult<List<RoomOfferLastPurchaseDTO>>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F6C0", Offset = "0x9F9EAC0", VA = "0x189F9F6C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9F9FAF0", Offset = "0x9F9EEF0", VA = "0x189F9FAF0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public DEMTUQTYPAQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private TaskAwaiter<Task> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9F9FB60", Offset = "0x9F9EF60", VA = "0x189F9FB60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9FA01D0", Offset = "0x9F9F5D0", VA = "0x189FA01D0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AsyncTaskMethodBuilder<Result<bool, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public DEMTUQTYPAQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public RecNet.RoomOffer roomOffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public string purchaseSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public long requestedPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public int? giftRecipientAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private TaskAwaiter<Result<bool, string>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9FA0C20", Offset = "0x9FA0020", VA = "0x189FA0C20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9FA11D0", Offset = "0x9FA05D0", VA = "0x189FA11D0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public AsyncTaskMethodBuilder<Result<bool, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public DEMTUQTYPAQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public RecNet.RoomOffer roomOffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public string purchaseSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public long requestedPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int? giftRecipientAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public long initialBalance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private RoomOfferPurchaseOperationResult <operationResult>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int <attemptNumber>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private RoomOfferPurchaseResponseDTO <response>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<RoomOfferPurchaseResponseDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9FA0230", Offset = "0x9F9F630", VA = "0x189FA0230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9FA0BB0", Offset = "0x9F9FFB0", VA = "0x189FA0BB0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public DEMTUQTYPAQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public PPTCRKDFMWF player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9FA1240", Offset = "0x9FA0640", VA = "0x189FA1240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9FA17B0", Offset = "0x9FA0BB0", VA = "0x189FA17B0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AsyncTaskMethodBuilder<RoomOfferPurchaseResponseDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public DEMTUQTYPAQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public int requestedPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int? giftRecipientAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public RecNet.RoomOffer roomOffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private QVSPQFCPAZM <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private Dictionary<Guid, Guid?> <concurrencyCodeByItemIdMap>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter<Dictionary<Guid, Guid?>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private Guid <itemId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private TaskAwaiter<RoomOfferPurchaseResponseDTO> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x9FA1820", Offset = "0x9FA0C20", VA = "0x189FA1820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9FA2770", Offset = "0x9FA1B70", VA = "0x189FA2770", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public AsyncTaskMethodBuilder<Result<RecNet.RoomOffer, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public DEMTUQTYPAQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public Guid roomOfferOriginId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public string description;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public string imageName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public bool hasDynamicPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int minimumDynamicPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public int maximumDynamicPrice;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public RoomOfferType roomOfferType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public bool isGiftable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public UgcPurchasableItemVisibility visibility;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Dictionary<Guid, int> roomInventoryItemMappings;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public Guid? priceUnitId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<RecNetResult<RecNet.RoomOffer>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9FA2BC0", Offset = "0x9FA1FC0", VA = "0x189FA2BC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9FA3260", Offset = "0x9FA2660", VA = "0x189FA3260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly TimeSpan BLRDVFVQYPS;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string RJAVXWJXLUS = "econ_room_offer_gate";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const string GOILDLDKZDM = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string MRSCSNGSNGN = "CV2_Purchase_Prompt_Chip";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly IAAEALKAPOD JFFFWBEGTVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly ULAEJZXLBAU WGHXNUEINPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly UVYWSTNVAYL URNSKNBFJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly UQTOQTEIEZW TTSPYWPUEVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly QHISMEANRUZ TFMOACDZPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly RIGNTTABGED HSOGIUBMZPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly VJXGJQYQFXL YTLVACUUSYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly MDCSZVCSXJK WWPGHQGSCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly NSJZDFUANRD PZZHCQMVHWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly FYJFQEAZFMD UJOESKXVMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly QPODBLLWODK BIREVUIGCTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Dictionary<Guid, int> SDJCOEUFYNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IDisposable MERPCVFHMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Task XNVEERNDSBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CancellationTokenSource SMRUSQLHOXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private long IVMKUCNYNQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool ZIWJLCMIQDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly ZXGBBDHWCCH SRXYLKIYPKD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private KWYMWVGLXGV QGIMGYUPDZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9F9CA00", Offset = "0x9F9BE00", VA = "0x189F9CA00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public PZVGSBFXRHS VHVMARSGMQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xDCCCD0", Offset = "0xDCC0D0", VA = "0x180DCCCD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xE82D80", Offset = "0xE82180", VA = "0x180E82D80", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public PCNXPJVUXFJ<RecNet.RoomOffer> SVJEOKPQIRL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCFF1A0", Offset = "0xCFE5A0", VA = "0x180CFF1A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xCFF160", Offset = "0xCFE560", VA = "0x180CFF160", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public PCNXPJVUXFJ<Guid> OQDSOFATAXM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xE97090", Offset = "0xE96490", VA = "0x180E97090", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x100CF70", Offset = "0x100C370", VA = "0x18100CF70", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public PCNXPJVUXFJ<Guid> GYVMPHVDIXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xEFF700", Offset = "0xEFEB00", VA = "0x180EFF700", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x172A830", Offset = "0x1729C30", VA = "0x18172A830", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F9BC50", Offset = "0x9F9B050", VA = "0x189F9BC50")]
		[BQDQKYYGTTM.Session.GameOnly]
		internal static void TRWAHLHDOMR(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9F9CCC0", Offset = "0x9F9C0C0", VA = "0x189F9CCC0")]
		[RecRoom.NoEngine.Common.Preserve]
		public DEMTUQTYPAQ([Inject(null)] IAAEALKAPOD recNetRoomOffer, [Inject(null)] ULAEJZXLBAU matchmakingProvider, [Inject(null)] XWWIGJNVTJP roomLoader, [Inject(null)] UVYWSTNVAYL taskDelay, [Inject(null)] MCEFNHDGEUI cacheFactory, [Inject(null)] UQTOQTEIEZW statsig, [Inject("ShowPurchasePromptRateLimiter")] QHISMEANRUZ purchasePromptRateLimiter, [Inject(null)] RIGNTTABGED rpcForwarder, [Inject(null)] YSFHTSKTXTS recNetPhotonAccess, [Inject(null)] VJXGJQYQFXL callbacks, [Inject(null)] MDCSZVCSXJK roomInventoryManagerInternal, [Inject(null)] NSJZDFUANRD recNetStorefronts, [Inject(null)] FYJFQEAZFMD analyticsHelper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9F99120", Offset = "0x9F98520", VA = "0x189F99120", Slot = "30")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9F99770", Offset = "0x9F98B70", VA = "0x189F99770", Slot = "12")]
		[AsyncStateMachine(typeof(<CreateRoomOffer>d__43))]
		public Task<Result<RecNet.RoomOffer, string>> GHVBLMPPLMF(Guid? a, long b, string c, string d, string e, int f, bool g, int h, int i, RoomOfferType j, bool k, UgcPurchasableItemVisibility l, [Optional] Dictionary<Guid, int> m, [Optional] Guid? n, bool o = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A180", Offset = "0x9F99580", VA = "0x189F9A180", Slot = "13")]
		[AsyncStateMachine(typeof(<UpdateRoomOffer>d__44))]
		public Task<Result<RecNet.RoomOffer, string>> MONLDWRNMXQ(Guid a, long b, string c, string d, string e, int f, bool g, int h, int i, RoomOfferType j, bool k, UgcPurchasableItemVisibility l, [Optional] Dictionary<Guid, int> m, [Optional] Guid? n)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9F99D30", Offset = "0x9F99130", VA = "0x189F99D30", Slot = "14")]
		[AsyncStateMachine(typeof(<DeleteRoomOffer>d__45))]
		public Task<Result<bool, string>> JBMTYMQNDIE(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A0E0", Offset = "0x9F994E0", VA = "0x189F9A0E0", Slot = "15")]
		public IEnumerable<RecNet.RoomOffer> LAZLKZBEYPL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9F9AE90", Offset = "0x9F9A290", VA = "0x189F9AE90", Slot = "16")]
		[AsyncStateMachine(typeof(<GetRecentPurchasedRoomOffersForRoom>d__47))]
		public Task<List<RoomOfferLastPurchaseDTO>> PVBYLXYUDYC(long a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9F98920", Offset = "0x9F97D20", VA = "0x189F98920", Slot = "19")]
		public bool CDFBJOQMZRR(Guid a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9BCC0", Offset = "0x9F9B0C0", VA = "0x189F9BCC0", Slot = "17")]
		public bool TVARAOZXIZG(Guid a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9F98330", Offset = "0x9F97730", VA = "0x189F98330", Slot = "18")]
		public bool AOUZKWQQFDM(string a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9F9AFC0", Offset = "0x9F9A3C0", VA = "0x189F9AFC0", Slot = "20")]
		public void QEHSDKSLHBM(PPTCRKDFMWF a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9F9BD90", Offset = "0x9F9B190", VA = "0x189F9BD90", Slot = "21")]
		[AsyncStateMachine(typeof(<CV2GetPlayerRoomOfferPurchaseCount>d__52))]
		public Task<int> XABHULJOXAL(PPTCRKDFMWF a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9B480", Offset = "0x9F9A880", VA = "0x189F9B480", Slot = "22")]
		public bool RLHSJTGMZQU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9BED0", Offset = "0x9F9B2D0", VA = "0x189F9BED0", Slot = "23")]
		public bool XLOYGSDTKMX(Guid a, [Out] List<string> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9F99370", Offset = "0x9F98770", VA = "0x189F99370", Slot = "24")]
		[AsyncStateMachine(typeof(<PurchaseRoomOffer>d__55))]
		public Task<Result<bool, string>> FDLOWYCIGUE(RecNet.RoomOffer a, long b, int c, string d, [Optional] int? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9F99F80", Offset = "0x9F99380", VA = "0x189F99F80")]
		[AsyncStateMachine(typeof(<PurchaseRoomOfferInternal>d__56))]
		private Task<Result<bool, string>> KFTTGKMNQFD(RecNet.RoomOffer a, long b, long c, string d, int e = 1, [Optional] int? f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9F98FD0", Offset = "0x9F983D0", VA = "0x189F98FD0")]
		[AsyncStateMachine(typeof(<SendRecNetRoomOfferPurchaseRequest>d__57))]
		private Task<RoomOfferPurchaseResponseDTO> CUSIOVZDBJK(RecNet.RoomOffer a, int b, int c, int? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9F9C6A0", Offset = "0x9F9BAA0", VA = "0x189F9C6A0")]
		private bool YHJVNFJGXNU(IEnumerable<PlayerRoomInventoryItemDTO> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9F9C2C0", Offset = "0x9F9B6C0", VA = "0x189F9C2C0")]
		private void XRUGCFITNOF(RecNet.RoomOffer a, long b, int c, string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9F986D0", Offset = "0x9F97AD0", VA = "0x189F986D0")]
		private string CALCJQKSAQS(RecNet.RoomOffer a, int b, string c, [Optional] RoomOfferPurchaseOperationResult? d, [Optional] UpdateResponseTypes? e, [Optional] string f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9F99A70", Offset = "0x9F98E70", VA = "0x189F99A70")]
		private RoomOfferPurchaseOperationResult HXUSBJIPFVS(RecNet.RoomOffer a, int b, [Out] long c)
		{
			return default(RoomOfferPurchaseOperationResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9F99950", Offset = "0x9F98D50", VA = "0x189F99950", Slot = "29")]
		public void HUYGNGXWKVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9F9B9C0", Offset = "0x9F9ADC0", VA = "0x189F9B9C0")]
		private void STLKKNYPTAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A5C0", Offset = "0x9F999C0", VA = "0x189F9A5C0", Slot = "25")]
		public bool OGIRIUNZXWP(Guid a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9B2F0", Offset = "0x9F9A6F0", VA = "0x189F9B2F0", Slot = "27")]
		public bool RJPSVIDPPCY(Guid a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9CAC0", Offset = "0x9F9BEC0", VA = "0x189F9CAC0", Slot = "26")]
		public bool ZXNEXVESCKZ(Guid a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9F994D0", Offset = "0x9F988D0", VA = "0x189F994D0", Slot = "28")]
		public SetPriceOverrideResult FJPVVMRLLAL(Guid a, int? b)
		{
			return default(SetPriceOverrideResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9F99960", Offset = "0x9F98D60", VA = "0x189F99960")]
		[AsyncStateMachine(typeof(<DownloadRoomOffers>d__68))]
		private Task HVKLUQELUBY(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9AAB0", Offset = "0x9F99EB0", VA = "0x189F9AAB0")]
		private Task OnRoomLoadStarted(WFUNSZQCFFF args, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A4F0", Offset = "0x9F998F0", VA = "0x189F9A4F0")]
		[AsyncStateMachine(typeof(<OnRoomLoadComplete>d__70))]
		private Task NTVVZUIHSMT(WFUNSZQCFFF a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A750", Offset = "0x9F99B50", VA = "0x189F9A750")]
		private static Dictionary<Guid, int> OXGJITHANCB(RecNetResult<List<RoomOfferPurchaseCountDTO>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9F986C0", Offset = "0x9F97AC0", VA = "0x189F986C0")]
		private void BRSELQNSHKZ(RecNet.RoomOffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9F9CA50", Offset = "0x9F9BE50", VA = "0x189F9CA50")]
		private void YUVBIGFMZOS(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9F9B7C0", Offset = "0x9F9ABC0", VA = "0x189F9B7C0")]
		[RPCMethod]
		internal void RpcOfferShowPurchasePrompt(Guid roomOfferId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9F98580", Offset = "0x9F97980", VA = "0x189F98580")]
		[AsyncStateMachine(typeof(<SendGetPlayerRoomOfferPurchaseCountRequest>d__75))]
		private Task<int> ATBKAPSVLHB(PPTCRKDFMWF a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9F9B5E0", Offset = "0x9F9A9E0", VA = "0x189F9B5E0")]
		[RPCMethod]
		internal void RpcGetPlayerRoomOfferPurchaseCount(Guid operationId, Guid roomOfferId, RPCInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9F9B560", Offset = "0x9F9A960", VA = "0x189F9B560")]
		[RPCMethod]
		internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid operationId, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9F98B10", Offset = "0x9F97F10", VA = "0x189F98B10", Slot = "31")]
		public string CTPQUSLPHVY(RoomOfferPurchaseOperationResult a, [Optional] UpdateResponseTypes? b, [Optional] BalanceResponseDTO c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9F9B200", Offset = "0x9F9A600", VA = "0x189F9B200")]
		private static string RFHAPCRRLCL(UpdateResponseTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A350", Offset = "0x9F99750", VA = "0x189F9A350")]
		private RecNet.RoomOffer NTVQLOGPSFK(RecNet.RoomOffer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9B190", Offset = "0x9F9A590", VA = "0x189F9B190")]
		private void RCAFCNCTWKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9F99E50", Offset = "0x9F99250", VA = "0x189F99E50")]
		private void KFIKXMGPMPZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[DefaultMember("Item")]
	public class QPODBLLWODK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly Dictionary<Guid, RecNet.RoomOffer> UZBSBIUHKZK;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private long EEWTHBXTEDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xDE68A0", Offset = "0xDE5CA0", VA = "0x180DE68A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9F9D780", Offset = "0x9F9CB80", VA = "0x189F9D780")]
		public void NewRoom(long roomId, IEnumerable<RecNet.RoomOffer> roomOffers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9D4F0", Offset = "0x9F9C8F0", VA = "0x189F9D4F0")]
		public bool AYQIPDZLPXF(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9DA20", Offset = "0x9F9CE20", VA = "0x189F9DA20")]
		public bool Remove(Guid roomOfferId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9F9D5D0", Offset = "0x9F9C9D0", VA = "0x189F9D5D0")]
		public bool HUBLZQTRUCD(RecNet.RoomOffer a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9F9D730", Offset = "0x9F9CB30", VA = "0x189F9D730")]
		public IEnumerable<RecNet.RoomOffer> NCFAOWEUAON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9DA80", Offset = "0x9F9CE80", VA = "0x189F9DA80")]
		public bool TVARAOZXIZG(Guid a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9D550", Offset = "0x9F9C950", VA = "0x189F9D550")]
		private bool DNJQCQPXVGZ(RecNet.RoomOffer a, RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9F9DAF0", Offset = "0x9F9CEF0", VA = "0x189F9DAF0")]
		public QPODBLLWODK()
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
