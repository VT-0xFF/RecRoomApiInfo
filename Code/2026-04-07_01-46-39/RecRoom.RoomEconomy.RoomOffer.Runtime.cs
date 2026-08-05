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
		[Cpp2IlInjected.Address(RVA = "0xA1CFD00", Offset = "0xA1CED00", VA = "0x18A1CFD00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29F86A0", Offset = "0x29F76A0", VA = "0x1829F86A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.RoomEconomy.RoomOffer
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface IUHOLVWBYYL : ZKLDWDWSQNJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		RKSXRDGZEWA RKSXRDGZEWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface WXBEDPAECQQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LZQWCQXOQRO TJMRVOYESKQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class TRRJRYZSSJD : WXBEDPAECQQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA1CA6F0", Offset = "0xA1C96F0", VA = "0x18A1CA6F0")]
		[GQJUYEPYYUG.Session.GameOnly]
		internal static void EHOWKEZCPLX(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		[RecRoom.NoEngine.Common.Preserve]
		public TRRJRYZSSJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA1CA760", Offset = "0xA1C9760", VA = "0x18A1CA760", Slot = "4")]
		public LZQWCQXOQRO TJMRVOYESKQ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Tested]
	public class RKSXRDGZEWA : EDQRADAQUIT, IDisposable, RZFGOWBBJPW
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class EQQCRUAHVDM
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
				public EQQCRUAHVDM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Guid itemId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0xA1CF220", Offset = "0xA1CE220", VA = "0x18A1CF220", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xA1CF590", Offset = "0xA1CE590", VA = "0x18A1CF590", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public RKSXRDGZEWA NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int JKZTFPQWRXH;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public EQQCRUAHVDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA1C4E70", Offset = "0xA1C3E70", VA = "0x18A1C4E70")]
			[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
			internal Task TNARAVIRPDL(Guid a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA1C4D50", Offset = "0xA1C3D50", VA = "0x18A1C4D50")]
			internal Guid? MJGSXHUTBKG(Guid a)
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
			public RKSXRDGZEWA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public QCTMRFTYWMB player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public Guid roomOfferId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA1CA810", Offset = "0xA1C9810", VA = "0x18A1CA810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA1CABF0", Offset = "0xA1C9BF0", VA = "0x18A1CABF0", Slot = "5")]
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
			public RKSXRDGZEWA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA1CAC60", Offset = "0xA1C9C60", VA = "0x18A1CAC60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA1CB270", Offset = "0xA1CA270", VA = "0x18A1CB270", Slot = "5")]
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
			public RKSXRDGZEWA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA1CB2E0", Offset = "0xA1CA2E0", VA = "0x18A1CB2E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA1CB880", Offset = "0xA1CA880", VA = "0x18A1CB880", Slot = "5")]
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
			public RKSXRDGZEWA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA1CB8F0", Offset = "0xA1CA8F0", VA = "0x18A1CB8F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA1CC0E0", Offset = "0xA1CB0E0", VA = "0x18A1CC0E0", Slot = "5")]
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
			public RKSXRDGZEWA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA1CC140", Offset = "0xA1CB140", VA = "0x18A1CC140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA1CC570", Offset = "0xA1CB570", VA = "0x18A1CC570", Slot = "5")]
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
			public RKSXRDGZEWA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private TaskAwaiter<Task> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA1CC5E0", Offset = "0xA1CB5E0", VA = "0x18A1CC5E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA1CCC60", Offset = "0xA1CBC60", VA = "0x18A1CCC60", Slot = "5")]
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
			public RKSXRDGZEWA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA1CD690", Offset = "0xA1CC690", VA = "0x18A1CD690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA1CDC40", Offset = "0xA1CCC40", VA = "0x18A1CDC40", Slot = "5")]
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
			public RKSXRDGZEWA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA1CCCC0", Offset = "0xA1CBCC0", VA = "0x18A1CCCC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA1CD620", Offset = "0xA1CC620", VA = "0x18A1CD620", Slot = "5")]
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
			public RKSXRDGZEWA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public QCTMRFTYWMB player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA1CDCB0", Offset = "0xA1CCCB0", VA = "0x18A1CDCB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA1CE200", Offset = "0xA1CD200", VA = "0x18A1CE200", Slot = "5")]
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
			public RKSXRDGZEWA <>4__this;

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
			private EQQCRUAHVDM <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0xA1CE270", Offset = "0xA1CD270", VA = "0x18A1CE270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA1CF1B0", Offset = "0xA1CE1B0", VA = "0x18A1CF1B0", Slot = "5")]
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
			public RKSXRDGZEWA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA1CF5F0", Offset = "0xA1CE5F0", VA = "0x18A1CF5F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA1CFC90", Offset = "0xA1CEC90", VA = "0x18A1CFC90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly TimeSpan EPGJSNOXSMY;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string XTZKGMLJWFE = "econ_room_offer_gate";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const string DYZKAPZADTM = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const string UWAZMHRVZHT = "CV2_Purchase_Prompt_Chip";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly NOUSQCSZISH JAGHIDNUYVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly STEUCIBCRZK VUWLEUUXTWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly SXWWBJWZSHF EXGRCBOKHJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly GAVJPVRYXKY BCDURSNLUVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly PYBDESHQTTL VDMTZWYGFVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly IUHOLVWBYYL FRFBIPWFXWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly WPCVWGYQGAV EHXZKUBIMDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly CWHQSKKDGRO KWDPTBXKTTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly RKLVCAFFFVL QCJHRJHHBYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly SPGBRXEHYHR SHPEOTMZUQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly LZQWCQXOQRO WDECMCRJPVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Dictionary<Guid, int> LJHKNWAWEZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IDisposable ARASBBIEAHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Task OXKHRGDKQEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CancellationTokenSource KCXOMTRAVBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private long YYOVJNZOAFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool UKKZBUKEAXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly DEUGYCCIQAL LJANRHRPYSP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private ZROXHVUBFSN RXHBXTTHTJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8770", Offset = "0xA1C7770", VA = "0x18A1C8770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public FYRDCSIKYKI KUTBEPLKFVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xDD3B70", Offset = "0xDD2B70", VA = "0x180DD3B70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xE94400", Offset = "0xE93400", VA = "0x180E94400", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public BQFVKUSIMFN<RecNet.RoomOffer> MOFIFZXAKND
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCFA5A0", Offset = "0xCF95A0", VA = "0x180CFA5A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xCFA580", Offset = "0xCF9580", VA = "0x180CFA580", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public BQFVKUSIMFN<Guid> ETPODAAOKWO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xEA8080", Offset = "0xEA7080", VA = "0x180EA8080", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1014F90", Offset = "0x1013F90", VA = "0x181014F90", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public BQFVKUSIMFN<Guid> TDOYEAMSYXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xEEE140", Offset = "0xEED140", VA = "0x180EEE140", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x1727AB0", Offset = "0x1726AB0", VA = "0x181727AB0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6220", Offset = "0xA1C5220", VA = "0x18A1C6220")]
		[GQJUYEPYYUG.Session.GameOnly]
		internal static void EHOWKEZCPLX(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9FD0", Offset = "0xA1C8FD0", VA = "0x18A1C9FD0")]
		[RecRoom.NoEngine.Common.Preserve]
		public RKSXRDGZEWA([Inject(null)] NOUSQCSZISH recNetRoomOffer, [Inject(null)] STEUCIBCRZK matchmakingProvider, [Inject(null)] CEHSECFOKXH roomLoader, [Inject(null)] SXWWBJWZSHF taskDelay, [Inject(null)] WXBEDPAECQQ cacheFactory, [Inject(null)] GAVJPVRYXKY statsig, [Inject("ShowPurchasePromptRateLimiter")] PYBDESHQTTL purchasePromptRateLimiter, [Inject(null)] IUHOLVWBYYL rpcForwarder, [Inject(null)] YHYUCUBONBO recNetPhotonAccess, [Inject(null)] WPCVWGYQGAV callbacks, [Inject(null)] CWHQSKKDGRO roomInventoryManagerInternal, [Inject(null)] RKLVCAFFFVL recNetStorefronts, [Inject(null)] SPGBRXEHYHR analyticsHelper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5FB0", Offset = "0xA1C4FB0", VA = "0x18A1C5FB0", Slot = "30")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA1C7690", Offset = "0xA1C6690", VA = "0x18A1C7690", Slot = "12")]
		[AsyncStateMachine(typeof(<CreateRoomOffer>d__43))]
		public Task<Result<RecNet.RoomOffer, string>> LGXOGXJPRMV(Guid? a, long b, string c, string d, string e, int f, bool g, int h, int i, RoomOfferType j, bool k, UgcPurchasableItemVisibility l, [Optional] Dictionary<Guid, int> m, [Optional] Guid? n, bool o = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9860", Offset = "0xA1C8860", VA = "0x18A1C9860", Slot = "13")]
		[AsyncStateMachine(typeof(<UpdateRoomOffer>d__44))]
		public Task<Result<RecNet.RoomOffer, string>> WNWGFWGXPVA(Guid a, long b, string c, string d, string e, int f, bool g, int h, int i, RoomOfferType j, bool k, UgcPurchasableItemVisibility l, [Optional] Dictionary<Guid, int> m, [Optional] Guid? n)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA1C8960", Offset = "0xA1C7960", VA = "0x18A1C8960", Slot = "14")]
		[AsyncStateMachine(typeof(<DeleteRoomOffer>d__45))]
		public Task<Result<bool, string>> QZHBWDAHKJW(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5760", Offset = "0xA1C4760", VA = "0x18A1C5760", Slot = "15")]
		public IEnumerable<RecNet.RoomOffer> ALKCIEVSGEZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA1C63D0", Offset = "0xA1C53D0", VA = "0x18A1C63D0", Slot = "16")]
		[AsyncStateMachine(typeof(<GetRecentPurchasedRoomOffersForRoom>d__47))]
		public Task<List<RoomOfferLastPurchaseDTO>> EYRATJYOYOK(long a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5A30", Offset = "0xA1C4A30", VA = "0x18A1C5A30", Slot = "19")]
		public bool BTMRQSJUVTF(Guid a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5EE0", Offset = "0xA1C4EE0", VA = "0x18A1C5EE0", Slot = "17")]
		public bool CZOIGUUYRHW(Guid a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9610", Offset = "0xA1C8610", VA = "0x18A1C9610", Slot = "18")]
		public bool VSOKZYHAEYG(string a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA1C7EB0", Offset = "0xA1C6EB0", VA = "0x18A1C7EB0", Slot = "20")]
		public void OEQYBLHCPIW(QCTMRFTYWMB a, Guid b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6290", Offset = "0xA1C5290", VA = "0x18A1C6290", Slot = "21")]
		[AsyncStateMachine(typeof(<CV2GetPlayerRoomOfferPurchaseCount>d__52))]
		public Task<int> EWXOKESARWP(QCTMRFTYWMB a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C67F0", Offset = "0xA1C57F0", VA = "0x18A1C67F0", Slot = "22")]
		public bool HSVZMUBJDWA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9220", Offset = "0xA1C8220", VA = "0x18A1C9220", Slot = "23")]
		public bool UCEQMDCACEH(Guid a, [Out] List<string> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5800", Offset = "0xA1C4800", VA = "0x18A1C5800", Slot = "24")]
		[AsyncStateMachine(typeof(<PurchaseRoomOffer>d__55))]
		public Task<Result<bool, string>> AXYPADOYYOQ(RecNet.RoomOffer a, long b, int c, string d, [Optional] int? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6690", Offset = "0xA1C5690", VA = "0x18A1C6690")]
		[AsyncStateMachine(typeof(<PurchaseRoomOfferInternal>d__56))]
		private Task<Result<bool, string>> GJKCJJKUIQF(RecNet.RoomOffer a, long b, long c, string d, int e = 1, [Optional] int? f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9BC0", Offset = "0xA1C8BC0", VA = "0x18A1C9BC0")]
		[AsyncStateMachine(typeof(<SendRecNetRoomOfferPurchaseRequest>d__57))]
		private Task<RoomOfferPurchaseResponseDTO> YOGAVYRIFBK(RecNet.RoomOffer a, int b, int c, int? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA1C7B60", Offset = "0xA1C6B60", VA = "0x18A1C7B60")]
		private bool ODQKPYNNJBU(IEnumerable<PlayerRoomInventoryItemDTO> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6FB0", Offset = "0xA1C5FB0", VA = "0x18A1C6FB0")]
		private void KCVVNYNHHGF(RecNet.RoomOffer a, long b, int c, string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA1C78F0", Offset = "0xA1C68F0", VA = "0x18A1C78F0")]
		private string MMPUQEBLZMW(RecNet.RoomOffer a, int b, string c, [Optional] RoomOfferPurchaseOperationResult? d, [Optional] UpdateResponseTypes? e, [Optional] string f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5C20", Offset = "0xA1C4C20", VA = "0x18A1C5C20")]
		private RoomOfferPurchaseOperationResult BTVGIEYIKPK(RecNet.RoomOffer a, int b, [Out] long c)
		{
			return default(RoomOfferPurchaseOperationResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA1C7870", Offset = "0xA1C6870", VA = "0x18A1C7870", Slot = "29")]
		public void LRQANVMBSHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA1C7400", Offset = "0xA1C6400", VA = "0x18A1C7400")]
		private void KGLPXGDOCUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA1C55D0", Offset = "0xA1C45D0", VA = "0x18A1C55D0", Slot = "25")]
		public bool AFJJHILSDPV(Guid a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6500", Offset = "0xA1C5500", VA = "0x18A1C6500", Slot = "27")]
		public bool GBFOAPMJGHC(Guid a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9A30", Offset = "0xA1C8A30", VA = "0x18A1C9A30", Slot = "26")]
		public bool WYZJCPXMOAF(Guid a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA1C8070", Offset = "0xA1C7070", VA = "0x18A1C8070", Slot = "28")]
		public SetPriceOverrideResult OJSXMMLVJBB(Guid a, int? b)
		{
			return default(SetPriceOverrideResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9E50", Offset = "0xA1C8E50", VA = "0x18A1C9E50")]
		[AsyncStateMachine(typeof(<DownloadRoomOffers>d__68))]
		private Task ZOENHXTCOVY(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C8380", Offset = "0xA1C7380", VA = "0x18A1C8380")]
		private Task OnRoomLoadStarted(UYHWVRBKXVF args, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5960", Offset = "0xA1C4960", VA = "0x18A1C5960")]
		[AsyncStateMachine(typeof(<OnRoomLoadComplete>d__70))]
		private Task BSHKKXRXWSP(UYHWVRBKXVF a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA1C8A80", Offset = "0xA1C7A80", VA = "0x18A1C8A80")]
		private static Dictionary<Guid, int> RWSPCXWFSYR(RecNetResult<List<RoomOfferPurchaseCountDTO>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA1C7B50", Offset = "0xA1C6B50", VA = "0x18A1C7B50")]
		private void NQYMDTGDQAZ(RecNet.RoomOffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA1C8310", Offset = "0xA1C7310", VA = "0x18A1C8310")]
		private void OSPVDIAXPPQ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9030", Offset = "0xA1C8030", VA = "0x18A1C9030")]
		[RPCMethod]
		internal void RpcOfferShowPurchasePrompt(Guid roomOfferId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA1C9D10", Offset = "0xA1C8D10", VA = "0x18A1C9D10")]
		[AsyncStateMachine(typeof(<SendGetPlayerRoomOfferPurchaseCountRequest>d__75))]
		private Task<int> YWGWHXANEMT(QCTMRFTYWMB a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA1C8E60", Offset = "0xA1C7E60", VA = "0x18A1C8E60")]
		[RPCMethod]
		internal void RpcGetPlayerRoomOfferPurchaseCount(Guid operationId, Guid roomOfferId, RPCInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA1C8DE0", Offset = "0xA1C7DE0", VA = "0x18A1C8DE0")]
		[RPCMethod]
		internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid operationId, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6AF0", Offset = "0xA1C5AF0", VA = "0x18A1C6AF0", Slot = "31")]
		public string JYNFIVSMRFQ(RoomOfferPurchaseOperationResult a, [Optional] UpdateResponseTypes? b, [Optional] BalanceResponseDTO c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6A00", Offset = "0xA1C5A00", VA = "0x18A1C6A00")]
		private static string JTGJVKNRZQP(UpdateResponseTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA1C87C0", Offset = "0xA1C77C0", VA = "0x18A1C87C0")]
		private RecNet.RoomOffer QLXNFINXVQY(RecNet.RoomOffer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA1C7880", Offset = "0xA1C6880", VA = "0x18A1C7880")]
		private void MDISSTYMKFQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA1C68D0", Offset = "0xA1C58D0", VA = "0x18A1C68D0")]
		private void JJRMCLQHKAP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[DefaultMember("Item")]
	public class LZQWCQXOQRO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly Dictionary<Guid, RecNet.RoomOffer> NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private long MFLRLLFNHBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xE01B00", Offset = "0xE00B00", VA = "0x180E01B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5180", Offset = "0xA1C4180", VA = "0x18A1C5180")]
		public void NewRoom(long roomId, IEnumerable<RecNet.RoomOffer> roomOffers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5470", Offset = "0xA1C4470", VA = "0x18A1C5470")]
		public bool SKBHLNZGHYL(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5410", Offset = "0xA1C4410", VA = "0x18A1C5410")]
		public bool Remove(Guid roomOfferId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5020", Offset = "0xA1C4020", VA = "0x18A1C5020")]
		public bool NXLZYETBYPZ(RecNet.RoomOffer a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4FD0", Offset = "0xA1C3FD0", VA = "0x18A1C4FD0")]
		public IEnumerable<RecNet.RoomOffer> MRRPDHTNOTT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4F60", Offset = "0xA1C3F60", VA = "0x18A1C4F60")]
		public bool CZOIGUUYRHW(Guid a, [Out] RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C54D0", Offset = "0xA1C44D0", VA = "0x18A1C54D0")]
		private bool XZNPMVYEFOZ(RecNet.RoomOffer a, RecNet.RoomOffer b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5550", Offset = "0xA1C4550", VA = "0x18A1C5550")]
		public LZQWCQXOQRO()
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
