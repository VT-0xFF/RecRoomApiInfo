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
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RoomEconomy_RoomOffer_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85F7460", Offset = "0x85F6060", VA = "0x1885F7460", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JDGBAFPFOAM : GJIKNNHIOKP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	COIIFNBMMCH LMHONFKPFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GHCLAJLOALF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KGJLEIJAOFN OGMMPFFJFOO();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OFNDMOLCDKL : GHCLAJLOALF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x85F5DA0", Offset = "0x85F49A0", VA = "0x1885F5DA0")]
	[IGNGJLOKDFM.CHOHDINDLHJ.JBEAKNHCNNG]
	internal static void OMKCNNEBHOD(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public OFNDMOLCDKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x85F5CE0", Offset = "0x85F48E0", VA = "0x1885F5CE0", Slot = "4")]
	public KGJLEIJAOFN OGMMPFFJFOO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BOOMHEJPJEF]
public class COIIFNBMMCH : EKGICIFMDLI, IDisposable, KMNPOEKIMFF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct NMGJGPHCMAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<JNGEBHOKLOH, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public COIIFNBMMCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Guid? originId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public LFOAGFFIEOL roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<FGHPMEFECDA<JNGEBHOKLOH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85F5740", Offset = "0x85F4340", VA = "0x1885F5740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85F5C70", Offset = "0x85F4870", VA = "0x1885F5C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct CJBNLGILONN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<JNGEBHOKLOH, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public COIIFNBMMCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Guid roomOfferOriginId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public LFOAGFFIEOL roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<FGHPMEFECDA<JNGEBHOKLOH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85ED5D0", Offset = "0x85EC1D0", VA = "0x1885ED5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85EDB70", Offset = "0x85EC770", VA = "0x1885EDB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NCGINNNEMPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public COIIFNBMMCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private JNGEBHOKLOH <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<GMNOLBMCLHL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85F5170", Offset = "0x85F3D70", VA = "0x1885F5170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85F56D0", Offset = "0x85F42D0", VA = "0x1885F56D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct EJMBJHIHHPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<List<BKFMDIKHFIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public COIIFNBMMCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<FGHPMEFECDA<List<BKFMDIKHFIM>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85F2EA0", Offset = "0x85F1AA0", VA = "0x1885F2EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85F3290", Offset = "0x85F1E90", VA = "0x1885F3290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct KDHAMEBANAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public COIIFNBMMCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public BJCCECIKIFB player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85F3E90", Offset = "0x85F2A90", VA = "0x1885F3E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85F4230", Offset = "0x85F2E30", VA = "0x1885F4230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct JBDNKANCDDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public COIIFNBMMCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public JNGEBHOKLOH roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string purchaseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter<MDDPJNIIBBI<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85F38D0", Offset = "0x85F24D0", VA = "0x1885F38D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85F3E20", Offset = "0x85F2A20", VA = "0x1885F3E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PGEMPHDELIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public COIIFNBMMCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public JNGEBHOKLOH roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public string purchaseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public long initialBalance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private KMHBMABJPNN <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private HKGIJOCJJBD <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<HKGIJOCJJBD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85F5E10", Offset = "0x85F4A10", VA = "0x1885F5E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85F6740", Offset = "0x85F5340", VA = "0x1885F6740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PLKGEKKGKCG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private struct <<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public PLKGEKKGKCG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x85F7090", Offset = "0x85F5C90", VA = "0x1885F7090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x85F7400", Offset = "0x85F6000", VA = "0x1885F7400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public COIIFNBMMCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public PLKGEKKGKCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85F6E80", Offset = "0x85F5A80", VA = "0x1885F6E80")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task GAIIOPNNIEG(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85F6F70", Offset = "0x85F5B70", VA = "0x1885F6F70")]
		internal Guid? KNPFPDJKGGN(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CMGKBJHELBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<HKGIJOCJJBD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public COIIFNBMMCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public JNGEBHOKLOH roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private PLKGEKKGKCG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Dictionary<Guid, Guid?> <concurrencyCodeByItemIdMap>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private Guid <itemId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter<HKGIJOCJJBD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x85EDBE0", Offset = "0x85EC7E0", VA = "0x1885EDBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x85EE8A0", Offset = "0x85ED4A0", VA = "0x1885EE8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct LLHGKEJAHEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public COIIFNBMMCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<FGHPMEFECDA<List<NBCOKIJCLMK>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<List<JNGEBHOKLOH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<FGHPMEFECDA<List<NBCOKIJCLMK>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85F4920", Offset = "0x85F3520", VA = "0x1885F4920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x85F5110", Offset = "0x85F3D10", VA = "0x1885F5110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct PIPHKKCHJEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public COIIFNBMMCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x85F67B0", Offset = "0x85F53B0", VA = "0x1885F67B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x85F6E20", Offset = "0x85F5A20", VA = "0x1885F6E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct IIEMKDHKGEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public COIIFNBMMCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public BJCCECIKIFB player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85F3300", Offset = "0x85F1F00", VA = "0x1885F3300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85F3860", Offset = "0x85F2460", VA = "0x1885F3860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan JENEMOGDMPF;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string ECLJDOHBGIJ = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string NEDOIEEDKON = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string CGJEBJHELBP = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LDJIPBEACFC GACMKGJOHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly KAHDDFIODAM ACNBOJPOFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly BHBKAOHPBKK AHGAKCIMJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly AHEAEJOKBNI BKHLAMDGECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly KAFBJENNCBI EOBJJGMDOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly JDGBAFPFOAM AHJNHAOBMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HJDNCHGOBMO ECPFHMDENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly IPDJKJLBCFN BLNCGNFIJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly ODAJJOAKOPA DHLCDOJOEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly MFHMPBFKGLM ADPMIMAAEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly KGJLEIJAOFN LDLCEJCCJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> LFJIPKMMMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable IHCKHMHDJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task MHPNBGIHLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource DCCGCJKFCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long MOLLHDAJNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool HPDIEOLMMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly AOPFHIJAPGH HCHFJJKJKAB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private GJAPKLOLFLN JMDMDFHNKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85EFF90", Offset = "0x85EEB90", VA = "0x1885EFF90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HBAAEHCBNNO EJHJMCBBIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA839C0", Offset = "0xA825C0", VA = "0x180A839C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA9A0B0", Offset = "0xA98CB0", VA = "0x180A9A0B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public PJAJEBBNNBK<JNGEBHOKLOH> PIKIIFIDGLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA2A4A0", Offset = "0xA290A0", VA = "0x180A2A4A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA2A4D0", Offset = "0xA290D0", VA = "0x180A2A4D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public PJAJEBBNNBK<Guid> DLMMGGCGNCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA9A080", Offset = "0xA98C80", VA = "0x180A9A080", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA9A030", Offset = "0xA98C30", VA = "0x180A9A030", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x85F20F0", Offset = "0x85F0CF0", VA = "0x1885F20F0")]
	[IGNGJLOKDFM.CHOHDINDLHJ.JBEAKNHCNNG]
	internal static void OMKCNNEBHOD(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x85F2780", Offset = "0x85F1380", VA = "0x1885F2780")]
	[RecRoom.NoEngine.Common.Preserve]
	public COIIFNBMMCH([GFNPNOLPMKK(null)] LDJIPBEACFC GACMKGJOHLC, [GFNPNOLPMKK(null)] KAHDDFIODAM ACNBOJPOFGO, [GFNPNOLPMKK(null)] PPDHIJNIFFF IKNMBFJPHDE, [GFNPNOLPMKK(null)] BHBKAOHPBKK AHGAKCIMJPD, [GFNPNOLPMKK(null)] GHCLAJLOALF KPIDMAMHHFG, [GFNPNOLPMKK(null)] AHEAEJOKBNI BKHLAMDGECL, [GFNPNOLPMKK("ShowPurchasePromptRateLimiter")] KAFBJENNCBI EOBJJGMDOKB, [GFNPNOLPMKK(null)] JDGBAFPFOAM AHJNHAOBMPO, [GFNPNOLPMKK(null)] KDFCOCHKBIK DAGGFFCOOJP, [GFNPNOLPMKK(null)] HJDNCHGOBMO ECPFHMDENEE, [GFNPNOLPMKK(null)] IPDJKJLBCFN BLNCGNFIJFE, [GFNPNOLPMKK(null)] ODAJJOAKOPA DHLCDOJOEAI, [GFNPNOLPMKK(null)] MFHMPBFKGLM ADPMIMAAEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x85EF2E0", Offset = "0x85EDEE0", VA = "0x1885EF2E0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x85F1430", Offset = "0x85F0030", VA = "0x1885F1430", Slot = "10")]
	[AsyncStateMachine(typeof(NMGJGPHCMAO))]
	public Task<MDDPJNIIBBI<JNGEBHOKLOH, string>> NAHKNLLNDKJ(Guid? LFJGGIIPHOD, long JKJNCHGDMGL, string LAOCJKNALFF, string NFKNKHBBLBH, string PJOILBBKCNO, int DHMNKCHADGA, LFOAGFFIEOL CAIPJDNANON, [Optional] Dictionary<Guid, int> MJFALOELMDJ, [Optional] Guid? IEJABAJAKFG, bool EICPJEALOFL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x85EFB30", Offset = "0x85EE730", VA = "0x1885EFB30", Slot = "11")]
	[AsyncStateMachine(typeof(CJBNLGILONN))]
	public Task<MDDPJNIIBBI<JNGEBHOKLOH, string>> EPBMHODNJJJ(Guid CMMOANJGJDI, long JKJNCHGDMGL, string LAOCJKNALFF, string NFKNKHBBLBH, string PJOILBBKCNO, int DHMNKCHADGA, LFOAGFFIEOL CAIPJDNANON, [Optional] Dictionary<Guid, int> MJFALOELMDJ, [Optional] Guid? IEJABAJAKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x85F15E0", Offset = "0x85F01E0", VA = "0x1885F15E0", Slot = "12")]
	[AsyncStateMachine(typeof(NCGINNNEMPL))]
	public Task<MDDPJNIIBBI<bool, string>> NCLEMJEIBJP(Guid MLCFFELIEFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x85F1DE0", Offset = "0x85F09E0", VA = "0x1885F1DE0", Slot = "13")]
	public IEnumerable<JNGEBHOKLOH> OCHABKGCNGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x85F1FC0", Offset = "0x85F0BC0", VA = "0x1885F1FC0", Slot = "14")]
	[AsyncStateMachine(typeof(EJMBJHIHHPF))]
	public Task<List<BKFMDIKHFIM>> OIMGJLIDHGP(long JKJNCHGDMGL, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x85F0E80", Offset = "0x85EFA80", VA = "0x1885F0E80", Slot = "17")]
	public bool LAONGIHOELE(Guid MLCFFELIEFF, int NHGKGLMOPAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x85F1700", Offset = "0x85F0300", VA = "0x1885F1700", Slot = "15")]
	public bool NFIGKFBEGIL(Guid MLCFFELIEFF, [Out] JNGEBHOKLOH LACCNICKJEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x85EEA50", Offset = "0x85ED650", VA = "0x1885EEA50", Slot = "16")]
	public bool BCMFJPEKPOO(string LAOCJKNALFF, [Out] JNGEBHOKLOH LACCNICKJEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x85F1250", Offset = "0x85EFE50", VA = "0x1885F1250", Slot = "18")]
	public void MEAJMEABGCI(BJCCECIKIFB NEOGODNGJJE, Guid MLCFFELIEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x85EE910", Offset = "0x85ED510", VA = "0x1885EE910", Slot = "19")]
	[AsyncStateMachine(typeof(KDHAMEBANAM))]
	public Task<int> ANNFMNIPIIP(BJCCECIKIFB NEOGODNGJJE, Guid MLCFFELIEFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x85F21D0", Offset = "0x85F0DD0", VA = "0x1885F21D0", Slot = "20")]
	public bool PIDHGCIAGIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x85F07E0", Offset = "0x85EF3E0", VA = "0x1885F07E0", Slot = "21")]
	public bool KBDEHCEJPMH(Guid BMFFGEKEBGJ, [Out] List<string> CAOLNCKIBIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x85EFE30", Offset = "0x85EEA30", VA = "0x1885EFE30", Slot = "22")]
	[AsyncStateMachine(typeof(JBDNKANCDDO))]
	public Task<MDDPJNIIBBI<bool, string>> GDNMILGHCCE(JNGEBHOKLOH LACCNICKJEP, long FKFFAOOEBPM, int KCCIFDBLGOI, string EJJACJNELOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x85EFCD0", Offset = "0x85EE8D0", VA = "0x1885EFCD0")]
	[AsyncStateMachine(typeof(PGEMPHDELIC))]
	private Task<MDDPJNIIBBI<bool, string>> GADJLIBODLM(JNGEBHOKLOH LACCNICKJEP, long FKFFAOOEBPM, long BMBBODHEPLI, string EJJACJNELOC, int KCCIFDBLGOI = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x85F10F0", Offset = "0x85EFCF0", VA = "0x1885F10F0")]
	[AsyncStateMachine(typeof(CMGKBJHELBK))]
	private Task<HKGIJOCJJBD> MBOIDKEHKMG(JNGEBHOKLOH LACCNICKJEP, int KCCIFDBLGOI, int FKFFAOOEBPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x85F03B0", Offset = "0x85EEFB0", VA = "0x1885F03B0")]
	private bool JOKOOPKDCAI(IEnumerable<PDDGPOPHPGK> FNJJINJOLOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x85EFFE0", Offset = "0x85EEBE0", VA = "0x1885EFFE0")]
	private void IKEPKBPMDMI(JNGEBHOKLOH LACCNICKJEP, long BMBBODHEPLI, int KCCIFDBLGOI, string EJJACJNELOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x85F17E0", Offset = "0x85F03E0", VA = "0x1885F17E0")]
	private string NPLOBNJKMGJ(JNGEBHOKLOH LACCNICKJEP, int KCCIFDBLGOI, string EJJACJNELOC, [Optional] KMHBMABJPNN? DBJBIPJCIKA, [Optional] PNKPJIPFBOI? DJFBGEJEGFM, [Optional] string GDIKLEEKPHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x85F0BE0", Offset = "0x85EF7E0", VA = "0x1885F0BE0")]
	private KMHBMABJPNN KIPGIALKIEE(JNGEBHOKLOH ILHNCMNOOMH, int AMFMGLNKLFJ, [Out] long BMBBODHEPLI)
	{
		return default(KMHBMABJPNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x85EF1D0", Offset = "0x85EDDD0", VA = "0x1885EF1D0")]
	[AsyncStateMachine(typeof(LLHGKEJAHEJ))]
	private Task DKFNHCDFANB(long JKJNCHGDMGL, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x85EECB0", Offset = "0x85ED8B0", VA = "0x1885EECB0")]
	private Task BGCIMHLNLAD(KGGEOPPOKLC FABPHEFJGGN, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x85F0700", Offset = "0x85EF300", VA = "0x1885F0700")]
	[AsyncStateMachine(typeof(PIPHKKCHJEA))]
	private Task JPHEEANCNEN(KGGEOPPOKLC FABPHEFJGGN, CancellationToken ILPOOHPAJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x85EF6E0", Offset = "0x85EE2E0", VA = "0x1885EF6E0")]
	private static Dictionary<Guid, int> ECIFIGIKFME(FGHPMEFECDA<List<NBCOKIJCLMK>> CLJFDFPCJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x85F07D0", Offset = "0x85EF3D0", VA = "0x1885F07D0")]
	private void KANIKGJIFHP(JNGEBHOKLOH LACCNICKJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x85F2160", Offset = "0x85F0D60", VA = "0x1885F2160")]
	private void PDDNFDPMGGN(Guid MLCFFELIEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85F2520", Offset = "0x85F1120", VA = "0x1885F2520")]
	[CHIJNBOPIHK]
	internal void RpcOfferShowPurchasePrompt(Guid MLCFFELIEFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x85EF090", Offset = "0x85EDC90", VA = "0x1885EF090")]
	[AsyncStateMachine(typeof(IIEMKDHKGEO))]
	private Task<int> CDLCDMDEHCI(BJCCECIKIFB NEOGODNGJJE, Guid BMFFGEKEBGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x85F2330", Offset = "0x85F0F30", VA = "0x1885F2330")]
	[CHIJNBOPIHK]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid DIPCJMNHKDB, Guid MLCFFELIEFF, ALHJKKHMHIP JGFKHBPEKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x85F22B0", Offset = "0x85F0EB0", VA = "0x1885F22B0")]
	[CHIJNBOPIHK]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid DIPCJMNHKDB, int DPOOEAFKIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x85F1A30", Offset = "0x85F0630", VA = "0x1885F1A30", Slot = "24")]
	public string OBBCBJPJCLF(KMHBMABJPNN DBJBIPJCIKA, [Optional] PNKPJIPFBOI? AIDFDGPIOGC, [Optional] BalanceResponseDTO LAJHNJOLLBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x85EFA40", Offset = "0x85EE640", VA = "0x1885EFA40")]
	private static string EOJPLDLIPPN(PNKPJIPFBOI AIDFDGPIOGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x85EF540", Offset = "0x85EE140", VA = "0x1885EF540")]
	private JNGEBHOKLOH EAKBLOPKOJN(JNGEBHOKLOH FAFKNMGMBCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x85F1080", Offset = "0x85EFC80", VA = "0x1885F1080")]
	private void LMNELMMKDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x85F1E90", Offset = "0x85F0A90", VA = "0x1885F1E90")]
	private void OIKAOAKOCBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class KGJLEIJAOFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Guid, JNGEBHOKLOH> AFHEFLCAFIP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long PAKBEKGHOMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xCFB360", Offset = "0xCF9F60", VA = "0x180CFB360")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x85F44A0", Offset = "0x85F30A0", VA = "0x1885F44A0")]
	public void NPNNKAIMHMM(long JKJNCHGDMGL, IEnumerable<JNGEBHOKLOH> JCFALPCPLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x85F43D0", Offset = "0x85F2FD0", VA = "0x1885F43D0")]
	public bool KHIBAONJNFC(Guid MLCFFELIEFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x85F4370", Offset = "0x85F2F70", VA = "0x1885F4370")]
	public bool HMCNGGMNMHK(Guid MLCFFELIEFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x85F4730", Offset = "0x85F3330", VA = "0x1885F4730")]
	public bool PGLILEBBMPM(JNGEBHOKLOH OOHDMGFABBP, [Out] JNGEBHOKLOH KPBIMNABKCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x85F42A0", Offset = "0x85F2EA0", VA = "0x1885F42A0")]
	public IEnumerable<JNGEBHOKLOH> AHKDJPMALIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x85F4430", Offset = "0x85F3030", VA = "0x1885F4430")]
	public bool NFIGKFBEGIL(Guid MLCFFELIEFF, [Out] JNGEBHOKLOH LACCNICKJEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x85F42F0", Offset = "0x85F2EF0", VA = "0x1885F42F0")]
	private bool CFGPMCICACD(JNGEBHOKLOH LFLPFMMDGLM, JNGEBHOKLOH FHLOHBNEJIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x85F4890", Offset = "0x85F3490", VA = "0x1885F4890")]
	public KGJLEIJAOFN()
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
