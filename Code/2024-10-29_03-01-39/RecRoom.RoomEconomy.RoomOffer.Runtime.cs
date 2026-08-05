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
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RoomEconomy_RoomOffer_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7566C20", Offset = "0x7565C20", VA = "0x187566C20", Slot = "8")]
		public override void NCHGKCJDJHF(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EBKBDGLLOKF : MPOLOACJDDM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DOHPFLHFMDM IDHEODIJNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EKOKCHHJJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CBKOJECCDHN CILIPHACGFI();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DLJCCJKOOMF : EKOKCHHJJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x755E7F0", Offset = "0x755D7F0", VA = "0x18755E7F0")]
	[AEDCCIMPEFD.AFLCBBLFINA.JIBIFIAGKAD]
	internal static void EKNFAAPFPJB(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	[RecRoom.NoEngine.Common.Preserve]
	public DLJCCJKOOMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x755E730", Offset = "0x755D730", VA = "0x18755E730", Slot = "4")]
	public CBKOJECCDHN CILIPHACGFI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PGJOKJDJLNC]
public class DOHPFLHFMDM : EEABEHJEBBA, IDisposable, AJHHGMIDDIH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct OIKKLBLDAOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<PCNFDJAAGAF, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public DOHPFLHFMDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AJFLGMKJHEO roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<CMICHMEJHIH<PCNFDJAAGAF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x75653B0", Offset = "0x75643B0", VA = "0x1875653B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7565870", Offset = "0x7564870", VA = "0x187565870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct BLCHEONFFGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<PCNFDJAAGAF, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public DOHPFLHFMDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AJFLGMKJHEO roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<CMICHMEJHIH<PCNFDJAAGAF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x755D6B0", Offset = "0x755C6B0", VA = "0x18755D6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x755DC30", Offset = "0x755CC30", VA = "0x18755DC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct GGEBCFFJOBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public DOHPFLHFMDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private PCNFDJAAGAF <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<IHLLMMNEMJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7562B60", Offset = "0x7561B60", VA = "0x187562B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x75630A0", Offset = "0x75620A0", VA = "0x1875630A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HPFLDILJFOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<List<NDHLOENNMLL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public DOHPFLHFMDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<CMICHMEJHIH<List<NDHLOENNMLL>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x75639F0", Offset = "0x75629F0", VA = "0x1875639F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7563DE0", Offset = "0x7562DE0", VA = "0x187563DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct DHAAHEFNCCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public DOHPFLHFMDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NKLIIMCFHAI player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x755E320", Offset = "0x755D320", VA = "0x18755E320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x755E6C0", Offset = "0x755D6C0", VA = "0x18755E6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct AHKPKIMHFHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public DOHPFLHFMDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public PCNFDJAAGAF roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string purchaseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter<OBFFLKDLIBJ<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x755D0F0", Offset = "0x755C0F0", VA = "0x18755D0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x755D640", Offset = "0x755C640", VA = "0x18755D640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PBKLMMMDDKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public DOHPFLHFMDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public PCNFDJAAGAF roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string purchaseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public long initialBalance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private EDBHCNJLIEM <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private KFPJODOFPKK <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<KFPJODOFPKK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x75658E0", Offset = "0x75648E0", VA = "0x1875658E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7566210", Offset = "0x7565210", VA = "0x187566210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class HNHIKLNHFIP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private struct <<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public HNHIKLNHFIP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7566850", Offset = "0x7565850", VA = "0x187566850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7566BC0", Offset = "0x7565BC0", VA = "0x187566BC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public DOHPFLHFMDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public HNHIKLNHFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7563900", Offset = "0x7562900", VA = "0x187563900")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task FOGPHNDBEOH(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x75637E0", Offset = "0x75627E0", VA = "0x1875637E0")]
		internal Guid? CBJPFCHDAPK(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct NKKIKMMKEIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<KFPJODOFPKK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public DOHPFLHFMDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public PCNFDJAAGAF roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private HNHIKLNHFIP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private Dictionary<Guid, Guid?> <concurrencyCodeByItemIdMap>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private Guid <itemId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private TaskAwaiter<KFPJODOFPKK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x75646A0", Offset = "0x75636A0", VA = "0x1875646A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7565340", Offset = "0x7564340", VA = "0x187565340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IGFPFLCNHFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public DOHPFLHFMDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private Task<CMICHMEJHIH<List<MNCJAGCEBPJ>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<List<PCNFDJAAGAF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<CMICHMEJHIH<List<MNCJAGCEBPJ>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7563E50", Offset = "0x7562E50", VA = "0x187563E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7564640", Offset = "0x7563640", VA = "0x187564640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GLFEOEIJILJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public DOHPFLHFMDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7563110", Offset = "0x7562110", VA = "0x187563110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7563780", Offset = "0x7562780", VA = "0x187563780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct PMJNEOAAJJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public DOHPFLHFMDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public NKLIIMCFHAI player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7566280", Offset = "0x7565280", VA = "0x187566280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x75667E0", Offset = "0x75657E0", VA = "0x1875667E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan MPLALMMONKC;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string CABGANFAMBI = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string FEFOLIPAPCF = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string OLOCHHFDICJ = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CHBMHFMDIHP PMPHOCLIMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly BDOMLLOLHMM PLMKMEKOJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly OGFAMDGCAPP AGLBEOFLHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly NIFDEMPMOFN AKBOKMCLEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly JDAEJJGAGNP NHOEEIAMMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly EBKBDGLLOKF EGFBMOOGGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly FAEFOBGMPKD LAFNKOLGHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly NJIOLBCILIB JLFBBFPNOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly INDMEDOKNGA PPLGDEOIOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly AKDCHDJNKMF JNPIAHINEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly CBKOJECCDHN HFHLOEIIIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> CNHIFJBNLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable BPMOJEJFEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task LLBICBIGLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource AMHOCNAGJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long NEBHJHGPFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool PPKGDGFGJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly OJGPLADLHDJ BEJBMPONDAB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private DEKCJJDGNGC EAGPCNMBACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x755FFB0", Offset = "0x755EFB0", VA = "0x18755FFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GDBINPMHEFP HJNDOOMEILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAC53E0", Offset = "0xAC43E0", VA = "0x180AC53E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAC0B90", Offset = "0xABFB90", VA = "0x180AC0B90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JFMBBHOLPOC<PCNFDJAAGAF> FGECKLLDANA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAB0", Offset = "0x8BDAB0", VA = "0x1808BEAB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA70", Offset = "0x8BDA70", VA = "0x1808BEA70", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JFMBBHOLPOC<Guid> NEPBDLIOBKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x9517A0", VA = "0x1809527A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BB0", Offset = "0xAC6BB0", VA = "0x180AC7BB0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x755FB40", Offset = "0x755EB40", VA = "0x18755FB40")]
	[AEDCCIMPEFD.AFLCBBLFINA.JIBIFIAGKAD]
	internal static void EKNFAAPFPJB(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7562440", Offset = "0x7561440", VA = "0x187562440")]
	[RecRoom.NoEngine.Common.Preserve]
	public DOHPFLHFMDM([GAHPILLNNBL(null)] CHBMHFMDIHP PMPHOCLIMKF, [GAHPILLNNBL(null)] BDOMLLOLHMM PLMKMEKOJBG, [GAHPILLNNBL(null)] PPCKAPHHIOA BOAMFOJBBEB, [GAHPILLNNBL(null)] OGFAMDGCAPP AGLBEOFLHDK, [GAHPILLNNBL(null)] EKOKCHHJJOG HIOOHCEAMOO, [GAHPILLNNBL(null)] NIFDEMPMOFN AKBOKMCLEOL, [GAHPILLNNBL("ShowPurchasePromptRateLimiter")] JDAEJJGAGNP NHOEEIAMMIE, [GAHPILLNNBL(null)] EBKBDGLLOKF EGFBMOOGGLH, [GAHPILLNNBL(null)] AAILICFLKKA GPKNCEPEJNE, [GAHPILLNNBL(null)] FAEFOBGMPKD LAFNKOLGHIB, [GAHPILLNNBL(null)] NJIOLBCILIB JLFBBFPNOMO, [GAHPILLNNBL(null)] INDMEDOKNGA PPLGDEOIOJK, [GAHPILLNNBL(null)] AKDCHDJNKMF JNPIAHINEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x755F500", Offset = "0x755E500", VA = "0x18755F500", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7561440", Offset = "0x7560440", VA = "0x187561440", Slot = "10")]
	[AsyncStateMachine(typeof(OIKKLBLDAOO))]
	public Task<OBFFLKDLIBJ<PCNFDJAAGAF, string>> JLHALMPFJNN(long AHNLEKFKAGC, string DMCFPOLFNCF, string GOFABEAKLNJ, string DMHMDBCKLAA, int IPNOJPCEMBO, AJFLGMKJHEO KGFINMACJOF, [Optional] Dictionary<Guid, int> MBPJJEOOHCN, [Optional] Guid? JBKIILKIKEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7561820", Offset = "0x7560820", VA = "0x187561820", Slot = "11")]
	[AsyncStateMachine(typeof(BLCHEONFFGN))]
	public Task<OBFFLKDLIBJ<PCNFDJAAGAF, string>> LONIIJMEJKL(Guid CNJHAFOOELJ, string DMCFPOLFNCF, string GOFABEAKLNJ, string DMHMDBCKLAA, int IPNOJPCEMBO, AJFLGMKJHEO KGFINMACJOF, [Optional] Dictionary<Guid, int> MBPJJEOOHCN, [Optional] Guid? JBKIILKIKEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x75615D0", Offset = "0x75605D0", VA = "0x1875615D0", Slot = "12")]
	[AsyncStateMachine(typeof(GGEBCFFJOBL))]
	public Task<OBFFLKDLIBJ<bool, string>> LGOONFJCAFF(Guid CNJHAFOOELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x75619B0", Offset = "0x75609B0", VA = "0x1875619B0", Slot = "13")]
	public IEnumerable<PCNFDJAAGAF> MGOOOIGIMFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7560960", Offset = "0x755F960", VA = "0x187560960", Slot = "14")]
	[AsyncStateMachine(typeof(HPFLDILJFOF))]
	public Task<List<NDHLOENNMLL>> IECKMIGGHNB(long AHNLEKFKAGC, [Optional] CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x755EA30", Offset = "0x755DA30", VA = "0x18755EA30", Slot = "16")]
	public bool ALOLAEDGEJH(Guid CNJHAFOOELJ, int HDMLPJLGPDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x755E950", Offset = "0x755D950", VA = "0x18755E950", Slot = "15")]
	public bool AFNLLMCBNDF(Guid CNJHAFOOELJ, [Out] PCNFDJAAGAF HBGDDMMBKCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7561AD0", Offset = "0x7560AD0", VA = "0x187561AD0", Slot = "17")]
	public void NELDGMNIHCA(NKLIIMCFHAI LCIKCDFLABF, Guid CNJHAFOOELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x755F010", Offset = "0x755E010", VA = "0x18755F010", Slot = "18")]
	[AsyncStateMachine(typeof(DHAAHEFNCCF))]
	public Task<int> CAAJEGGHKOK(NKLIIMCFHAI LCIKCDFLABF, Guid CNJHAFOOELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x755EC30", Offset = "0x755DC30", VA = "0x18755EC30", Slot = "19")]
	public bool ANODKKPFKLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x755FBB0", Offset = "0x755EBB0", VA = "0x18755FBB0", Slot = "20")]
	public bool FBFIECHHAGF(Guid FNLGGFGJAIO, [Out] List<string> IDGLLBACNMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x75611D0", Offset = "0x75601D0", VA = "0x1875611D0", Slot = "21")]
	[AsyncStateMachine(typeof(AHKPKIMHFHP))]
	public Task<OBFFLKDLIBJ<bool, string>> JBPGBOPMOGM(PCNFDJAAGAF HBGDDMMBKCA, long GHGIDBJIDLK, int HDGMOPCDECK, string GCFPIDHJCAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7560420", Offset = "0x755F420", VA = "0x187560420")]
	[AsyncStateMachine(typeof(PBKLMMMDDKA))]
	private Task<OBFFLKDLIBJ<bool, string>> GHIAFKGKBGK(PCNFDJAAGAF HBGDDMMBKCA, long GHGIDBJIDLK, long NGCGGGPLLMG, string GCFPIDHJCAF, int HDGMOPCDECK = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x755EEB0", Offset = "0x755DEB0", VA = "0x18755EEB0")]
	[AsyncStateMachine(typeof(NKKIKMMKEIL))]
	private Task<KFPJODOFPKK> BHPEDFLLHHN(PCNFDJAAGAF HBGDDMMBKCA, int HDGMOPCDECK, int GHGIDBJIDLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7560000", Offset = "0x755F000", VA = "0x187560000")]
	private bool FLKFOJHMCIH(IEnumerable<GDEGMIABJEE> KPGMGBGCJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x755F770", Offset = "0x755E770", VA = "0x18755F770")]
	private void EFBAKGLFDKE(PCNFDJAAGAF HBGDDMMBKCA, long NGCGGGPLLMG, int HDGMOPCDECK, string GCFPIDHJCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7561CB0", Offset = "0x7560CB0", VA = "0x187561CB0")]
	private string OGKABENHCNN(PCNFDJAAGAF HBGDDMMBKCA, int HDGMOPCDECK, string GCFPIDHJCAF, [Optional] EDBHCNJLIEM? POCKBMKNJHC, [Optional] MLJAFLEEOIM? PKLLKKNCAMO, [Optional] string KMMEAKGOIMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x75606C0", Offset = "0x755F6C0", VA = "0x1875606C0")]
	private EDBHCNJLIEM IAOJMBALOLI(PCNFDJAAGAF PLCMENEICLP, int HCICJHPHOPG, [Out] long NGCGGGPLLMG)
	{
		return default(EDBHCNJLIEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7561330", Offset = "0x7560330", VA = "0x187561330")]
	[AsyncStateMachine(typeof(IGFPFLCNHFF))]
	private Task JFEMANFENCH(long AHNLEKFKAGC, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7560A90", Offset = "0x755FA90", VA = "0x187560A90")]
	private Task IKKOBMKJDMF(GAAHBJLKBPP NABJMDALPIF, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7560350", Offset = "0x755F350", VA = "0x187560350")]
	[AsyncStateMachine(typeof(GLFEOEIJILJ))]
	private Task FOPCOGLINHD(GAAHBJLKBPP NABJMDALPIF, CancellationToken LJOGCILEFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7560E70", Offset = "0x755FE70", VA = "0x187560E70")]
	private static Dictionary<Guid, int> IPALEKDDNFL(CMICHMEJHIH<List<MNCJAGCEBPJ>> KCECPEPIPCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x755F760", Offset = "0x755E760", VA = "0x18755F760")]
	private void EAHCBLKKAID(PCNFDJAAGAF HBGDDMMBKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7561F00", Offset = "0x7560F00", VA = "0x187561F00")]
	private void PDLBKHHDPKF(Guid CNJHAFOOELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x75621E0", Offset = "0x75611E0", VA = "0x1875621E0")]
	[PIADPFFLIIF]
	internal void RpcOfferShowPurchasePrompt(Guid CNJHAFOOELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7560580", Offset = "0x755F580", VA = "0x187560580")]
	[AsyncStateMachine(typeof(PMJNEOAAJJA))]
	private Task<int> GMELKIDKBPL(NKLIIMCFHAI LCIKCDFLABF, Guid FNLGGFGJAIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7561FF0", Offset = "0x7560FF0", VA = "0x187561FF0")]
	[PIADPFFLIIF]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid HIKJHHIHDMH, Guid CNJHAFOOELJ, IMAKEELLGDP GDCFNEAPALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7561F70", Offset = "0x7560F70", VA = "0x187561F70")]
	[PIADPFFLIIF]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid HIKJHHIHDMH, int DCEOMHJEBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x755F150", Offset = "0x755E150", VA = "0x18755F150", Slot = "23")]
	public string DJKPAIDAMCO(EDBHCNJLIEM POCKBMKNJHC, [Optional] MLJAFLEEOIM? MPFPAAFBGEO, [Optional] BalanceResponseDTO LPCBJDINBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x755E860", Offset = "0x755D860", VA = "0x18755E860")]
	private static string AFCAHOEPHCN(MLJAFLEEOIM MPFPAAFBGEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x755ED10", Offset = "0x755DD10", VA = "0x18755ED10")]
	private PCNFDJAAGAF BDGENEEKHCB(PCNFDJAAGAF MGHFBKBFPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7561A60", Offset = "0x7560A60", VA = "0x187561A60")]
	private void NBFHJEPOGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x75616F0", Offset = "0x75606F0", VA = "0x1875616F0")]
	private void LJIANDAFMAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class CBKOJECCDHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Dictionary<Guid, PCNFDJAAGAF> NBMFIGMFHDG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long GMMHODNCMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x142F560", Offset = "0x142E560", VA = "0x18142F560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x755DEA0", Offset = "0x755CEA0", VA = "0x18755DEA0")]
	public void PENKMPHDHDL(long AHNLEKFKAGC, IEnumerable<PCNFDJAAGAF> CIBOMOLBCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x755DE40", Offset = "0x755CE40", VA = "0x18755DE40")]
	public bool OAEHANMOFFN(Guid CNJHAFOOELJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x755DD10", Offset = "0x755CD10", VA = "0x18755DD10")]
	public bool CAKBCGBONLK(Guid CNJHAFOOELJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x755E130", Offset = "0x755D130", VA = "0x18755E130")]
	public bool PFADLEONFKD(PCNFDJAAGAF GJAOJCPFKMC, [Out] PCNFDJAAGAF OGPFIIGLIOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x755DD70", Offset = "0x755CD70", VA = "0x18755DD70")]
	public IEnumerable<PCNFDJAAGAF> CMNAMPELMIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x755DCA0", Offset = "0x755CCA0", VA = "0x18755DCA0")]
	public bool AFNLLMCBNDF(Guid CNJHAFOOELJ, [Out] PCNFDJAAGAF HBGDDMMBKCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x755DDC0", Offset = "0x755CDC0", VA = "0x18755DDC0")]
	private bool JCAJIAJDDIE(PCNFDJAAGAF GKLNJFJLDOL, PCNFDJAAGAF FDEBKFIBHLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x755E290", Offset = "0x755D290", VA = "0x18755E290")]
	public CBKOJECCDHN()
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
