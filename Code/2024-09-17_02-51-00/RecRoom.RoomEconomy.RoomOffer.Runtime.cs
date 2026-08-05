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
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72F6DC0", Offset = "0x72F57C0", VA = "0x1872F6DC0", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GJPNNPHHDDH : LBOBGMJHEBP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OKOBCCFBOFJ LEFJGGCFPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MGMPGLMNOJA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JKPGMHHEBJH BNGLPLMENDI();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OJMMBELKPLC : MGMPGLMNOJA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72F25A0", Offset = "0x72F0FA0", VA = "0x1872F25A0")]
	[DJINMBCHLNM.PJKIGKAPDIK.PCJJKFLDJEL]
	internal static void ABFKOJMEBJE(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public OJMMBELKPLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x72F2610", Offset = "0x72F1010", VA = "0x1872F2610", Slot = "4")]
	public JKPGMHHEBJH BNGLPLMENDI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NHFFCNPJGMC]
public class OKOBCCFBOFJ : FNBPAPFOCON, IDisposable, DHIFILCIGLA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct MPPGIPBKDNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<MBADDKCFDLI, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public OKOBCCFBOFJ <>4__this;

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
		public LMBFNEAFENH roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<KEPLMFJKOOC<MBADDKCFDLI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x72F14B0", Offset = "0x72EFEB0", VA = "0x1872F14B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x72F1980", Offset = "0x72F0380", VA = "0x1872F1980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GAHKPDNHKPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<MBADDKCFDLI, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public OKOBCCFBOFJ <>4__this;

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
		public LMBFNEAFENH roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<KEPLMFJKOOC<MBADDKCFDLI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x72ED7E0", Offset = "0x72EC1E0", VA = "0x1872ED7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x72EDD60", Offset = "0x72EC760", VA = "0x1872EDD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BCFAPILBHOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public OKOBCCFBOFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private MBADDKCFDLI <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<DHPAFPJDDLL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x72ED220", Offset = "0x72EBC20", VA = "0x1872ED220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x72ED770", Offset = "0x72EC170", VA = "0x1872ED770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct LMAPAJGKFHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<List<KGCBJGFLFIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public OKOBCCFBOFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<KEPLMFJKOOC<List<KGCBJGFLFIL>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x72F1050", Offset = "0x72EFA50", VA = "0x1872F1050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x72F1440", Offset = "0x72EFE40", VA = "0x1872F1440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct HFOOIJMFAKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public OKOBCCFBOFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public PDPPFLAPOCL player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x72EE4A0", Offset = "0x72ECEA0", VA = "0x1872EE4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x72EE840", Offset = "0x72ED240", VA = "0x1872EE840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct IEIOCKMNKLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public OKOBCCFBOFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public MBADDKCFDLI roomOffer;

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
		private TaskAwaiter<BCLNLKLFCPB<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x72EEEA0", Offset = "0x72ED8A0", VA = "0x1872EEEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x72EF3F0", Offset = "0x72EDDF0", VA = "0x1872EF3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OCLOOMGLKFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<BCLNLKLFCPB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public OKOBCCFBOFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public MBADDKCFDLI roomOffer;

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
		private HENIPELCONO <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private JOEKPMCLLML <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<JOEKPMCLLML> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x72F19F0", Offset = "0x72F03F0", VA = "0x1872F19F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x72F2320", Offset = "0x72F0D20", VA = "0x1872F2320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class ODPFMIFMANP
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
			public ODPFMIFMANP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x72F69E0", Offset = "0x72F53E0", VA = "0x1872F69E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x72F6D60", Offset = "0x72F5760", VA = "0x1872F6D60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public OKOBCCFBOFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public ODPFMIFMANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x72F2390", Offset = "0x72F0D90", VA = "0x1872F2390")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task ANFGJEFBDPF(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x72F2480", Offset = "0x72F0E80", VA = "0x1872F2480")]
		internal Guid? DPLENLKGNAN(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct LHHKMJPDCBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<JOEKPMCLLML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public OKOBCCFBOFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public MBADDKCFDLI roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private ODPFMIFMANP <>8__1;

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
		private TaskAwaiter<JOEKPMCLLML> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x72F0320", Offset = "0x72EED20", VA = "0x1872F0320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x72F0FE0", Offset = "0x72EF9E0", VA = "0x1872F0FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JHFCPDGGEEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public OKOBCCFBOFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private Task<KEPLMFJKOOC<List<EMBJNNFEPJI>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<List<MBADDKCFDLI>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<KEPLMFJKOOC<List<EMBJNNFEPJI>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x72EF460", Offset = "0x72EDE60", VA = "0x1872EF460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x72EFC40", Offset = "0x72EE640", VA = "0x1872EFC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GEMLOMNDJPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public OKOBCCFBOFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x72EDDD0", Offset = "0x72EC7D0", VA = "0x1872EDDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x72EE440", Offset = "0x72ECE40", VA = "0x1872EE440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct HJCFMEDIFEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public OKOBCCFBOFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public PDPPFLAPOCL player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x72EE8B0", Offset = "0x72ED2B0", VA = "0x1872EE8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x72EEE30", Offset = "0x72ED830", VA = "0x1872EEE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan KJAGCDALNNL;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string JHOEMKOLGFA = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string JDGPHKCGANI = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string LGBGABPPHNF = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly KAIJFPEIPOE EGABGKAGLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly EJMHILFALFD EADMNLDABPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CJEGNMKBHPN JMHNCEGLNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly CDCHCDMFJJO KKMFJEOBINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HELBBFLMJNL CFFPMGDBFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GJPNNPHHDDH LAOMBFINDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CFHKKLBDKPB GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly FOBOFHJKJON IHFLOANLFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly GEPAOFHMKFD EAKEKLLDBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BDCICANMNGP JFNPAFENPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly JKPGMHHEBJH HBHDKHKJDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> OKOCGKPAJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable DFJOAFKKCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task OOMNNCFAJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource KBGFMKKLOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long ILGJIHLMFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool HFIMBOHAJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly HNJEJMNGEBK LEKMFBHDDDJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private OGDLJMIHDLN NBABLNMIKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72F3400", Offset = "0x72F1E00", VA = "0x1872F3400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GHNLMGKLHKE OGFEAGNOFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x949AA0", Offset = "0x9484A0", VA = "0x180949AA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x923D60", Offset = "0x922760", VA = "0x180923D60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public KHECJJJIFBB<MBADDKCFDLI> JKHIHMDMKLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x897DE0", Offset = "0x8967E0", VA = "0x180897DE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x897DC0", Offset = "0x8967C0", VA = "0x180897DC0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public KHECJJJIFBB<Guid> PPKGHDFBAIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x924730", Offset = "0x923130", VA = "0x180924730", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x924210", Offset = "0x922C10", VA = "0x180924210", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x72F26D0", Offset = "0x72F10D0", VA = "0x1872F26D0")]
	[DJINMBCHLNM.PJKIGKAPDIK.PCJJKFLDJEL]
	internal static void ABFKOJMEBJE(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x72F62C0", Offset = "0x72F4CC0", VA = "0x1872F62C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public OKOBCCFBOFJ([OLJNBPOCBCJ(null)] KAIJFPEIPOE EGABGKAGLCB, [OLJNBPOCBCJ(null)] EJMHILFALFD EADMNLDABPK, [OLJNBPOCBCJ(null)] LFGBFBPJNCH JAFFEKBAIOJ, [OLJNBPOCBCJ(null)] CJEGNMKBHPN JMHNCEGLNMN, [OLJNBPOCBCJ(null)] MGMPGLMNOJA JJAJCICOHEI, [OLJNBPOCBCJ(null)] CDCHCDMFJJO KKMFJEOBINB, [OLJNBPOCBCJ("ShowPurchasePromptRateLimiter")] HELBBFLMJNL CFFPMGDBFMM, [OLJNBPOCBCJ(null)] GJPNNPHHDDH LAOMBFINDHK, [OLJNBPOCBCJ(null)] ABCENOCDHAO IEGEAMBPEMD, [OLJNBPOCBCJ(null)] CFHKKLBDKPB GDGJPCNEJIO, [OLJNBPOCBCJ(null)] FOBOFHJKJON IHFLOANLFFM, [OLJNBPOCBCJ(null)] GEPAOFHMKFD EAKEKLLDBEC, [OLJNBPOCBCJ(null)] BDCICANMNGP JFNPAFENPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x72F3A00", Offset = "0x72F2400", VA = "0x1872F3A00", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x72F5A50", Offset = "0x72F4450", VA = "0x1872F5A50", Slot = "10")]
	[AsyncStateMachine(typeof(MPPGIPBKDNM))]
	public Task<BCLNLKLFCPB<MBADDKCFDLI, string>> OFOGDCMPIAL(long FNKMOIJJLLC, string KJPHMNNIMDP, string PADNFDKMCHE, string CPGBJNDENLC, int MOBOCAMNDBJ, LMBFNEAFENH HMDAEPELHPE, [Optional] Dictionary<Guid, int> NLPOJJPLDHK, [Optional] Guid? GCCFGEODKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x72F3C60", Offset = "0x72F2660", VA = "0x1872F3C60", Slot = "11")]
	[AsyncStateMachine(typeof(GAHKPDNHKPL))]
	public Task<BCLNLKLFCPB<MBADDKCFDLI, string>> FEPGPKPECJF(Guid MNLAOAAAPCD, string KJPHMNNIMDP, string PADNFDKMCHE, string CPGBJNDENLC, int MOBOCAMNDBJ, LMBFNEAFENH HMDAEPELHPE, [Optional] Dictionary<Guid, int> NLPOJJPLDHK, [Optional] Guid? GCCFGEODKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x72F5BE0", Offset = "0x72F45E0", VA = "0x1872F5BE0", Slot = "12")]
	[AsyncStateMachine(typeof(BCFAPILBHOI))]
	public Task<BCLNLKLFCPB<bool, string>> PEEBPBOFCKO(Guid MNLAOAAAPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x72F4040", Offset = "0x72F2A40", VA = "0x1872F4040", Slot = "13")]
	public IEnumerable<MBADDKCFDLI> FHAKHFJMOHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x72F2F00", Offset = "0x72F1900", VA = "0x1872F2F00", Slot = "14")]
	[AsyncStateMachine(typeof(LMAPAJGKFHG))]
	public Task<List<KGCBJGFLFIL>> BHLKNGPJLPL(long FNKMOIJJLLC, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x72F4C30", Offset = "0x72F3630", VA = "0x1872F4C30", Slot = "16")]
	public bool KLCBJHDNLFL(Guid MNLAOAAAPCD, int OCCJFNMCPPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x72F5D00", Offset = "0x72F4700", VA = "0x1872F5D00", Slot = "15")]
	public bool POHPGOOACHB(Guid MNLAOAAAPCD, [Out] MBADDKCFDLI PACBBFMGBPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72F3820", Offset = "0x72F2220", VA = "0x1872F3820", Slot = "17")]
	public void COLPPBBPEKD(PDPPFLAPOCL JDDNDMPDAKN, Guid MNLAOAAAPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x72F5910", Offset = "0x72F4310", VA = "0x1872F5910", Slot = "18")]
	[AsyncStateMachine(typeof(HFOOIJMFAKN))]
	public Task<int> NMIOPDPODMB(PDPPFLAPOCL JDDNDMPDAKN, Guid MNLAOAAAPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x72F3540", Offset = "0x72F1F40", VA = "0x1872F3540", Slot = "19")]
	public bool CIGPNPHDHFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x72F2AF0", Offset = "0x72F14F0", VA = "0x1872F2AF0", Slot = "20")]
	public bool AKHJOJLPKIK(Guid LILBGFPIHAH, [Out] List<string> EMDFAIFONJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x72F40F0", Offset = "0x72F2AF0", VA = "0x1872F40F0", Slot = "21")]
	[AsyncStateMachine(typeof(IEIOCKMNKLK))]
	public Task<BCLNLKLFCPB<bool, string>> FIHFECPIPEL(MBADDKCFDLI PACBBFMGBPL, long MPJBCCCKHNN, int OGKJJPEBIOK, string BOHJMMJDHCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x72F4AD0", Offset = "0x72F34D0", VA = "0x1872F4AD0")]
	[AsyncStateMachine(typeof(OCLOOMGLKFL))]
	private Task<BCLNLKLFCPB<bool, string>> KCPBHDJGLKB(MBADDKCFDLI PACBBFMGBPL, long MPJBCCCKHNN, long AFJAOLLGGIJ, string BOHJMMJDHCK, int OGKJJPEBIOK = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x72F43F0", Offset = "0x72F2DF0", VA = "0x1872F43F0")]
	[AsyncStateMachine(typeof(LHHKMJPDCBK))]
	private Task<JOEKPMCLLML> GINEAMNEKPI(MBADDKCFDLI PACBBFMGBPL, int OGKJJPEBIOK, int MPJBCCCKHNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x72F30A0", Offset = "0x72F1AA0", VA = "0x1872F30A0")]
	private bool BJDMMMECDFE(IEnumerable<IDEJICKEDMO> NIENBLPJDJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x72F4690", Offset = "0x72F3090", VA = "0x1872F4690")]
	private void HDMPCKLCHPJ(MBADDKCFDLI PACBBFMGBPL, long AFJAOLLGGIJ, int OGKJJPEBIOK, string BOHJMMJDHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72F3DF0", Offset = "0x72F27F0", VA = "0x1872F3DF0")]
	private string FGIKHAGLFNL(MBADDKCFDLI PACBBFMGBPL, int OGKJJPEBIOK, string BOHJMMJDHCK, [Optional] HENIPELCONO? POBDLJBBBCI, [Optional] EOLPBFPGAPB? EHINMHEJJAA, [Optional] string OFFPFBECJOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x72F2850", Offset = "0x72F1250", VA = "0x1872F2850")]
	private HENIPELCONO AJAFOPOIGEH(MBADDKCFDLI LBICHFMAFLJ, int PFFNHMBNIOI, [Out] long AFJAOLLGGIJ)
	{
		return default(HENIPELCONO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x72F2740", Offset = "0x72F1140", VA = "0x1872F2740")]
	[AsyncStateMachine(typeof(JHFCPDGGEEM))]
	private Task AHEBFKENGKG(long FNKMOIJJLLC, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x72F4E30", Offset = "0x72F3830", VA = "0x1872F4E30")]
	private Task KLELPKFLDFJ(ANLFOIKADDC AAAOIGBEBAB, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x72F3750", Offset = "0x72F2150", VA = "0x1872F3750")]
	[AsyncStateMachine(typeof(GEMLOMNDJPF))]
	private Task CMBFKKCPKNF(ANLFOIKADDC AAAOIGBEBAB, CancellationToken LNCHLOFJINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72F5210", Offset = "0x72F3C10", VA = "0x1872F5210")]
	private static Dictionary<Guid, int> LHBKKIAMKOH(KEPLMFJKOOC<List<EMBJNNFEPJI>> JHCFGPAJKOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x72F2EF0", Offset = "0x72F18F0", VA = "0x1872F2EF0")]
	private void BBIGJIBJBJL(MBADDKCFDLI PACBBFMGBPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x72F3030", Offset = "0x72F1A30", VA = "0x1872F3030")]
	private void BIDJNJONJCF(Guid MNLAOAAAPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x72F6050", Offset = "0x72F4A50", VA = "0x1872F6050")]
	[MEEBNJDNHKC]
	internal void RpcOfferShowPurchasePrompt(Guid MNLAOAAAPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x72F4550", Offset = "0x72F2F50", VA = "0x1872F4550")]
	[AsyncStateMachine(typeof(HJCFMEDIFEN))]
	private Task<int> GNIKJNHOIEG(PDPPFLAPOCL JDDNDMPDAKN, Guid LILBGFPIHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x72F5E60", Offset = "0x72F4860", VA = "0x1872F5E60")]
	[MEEBNJDNHKC]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid FAOKHBLGHEO, Guid MNLAOAAAPCD, HLGLPAHDPHI ONLDJBALHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x72F5DE0", Offset = "0x72F47E0", VA = "0x1872F5DE0")]
	[MEEBNJDNHKC]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid FAOKHBLGHEO, int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x72F5560", Offset = "0x72F3F60", VA = "0x1872F5560", Slot = "23")]
	public string NCPCPHKLLJC(HENIPELCONO POBDLJBBBCI, [Optional] EOLPBFPGAPB? CACBBCPKKID, [Optional] BalanceResponseDTO LPLLMMDDLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x72F3450", Offset = "0x72F1E50", VA = "0x1872F3450")]
	private static string CCCGBEPCJFK(EOLPBFPGAPB CACBBCPKKID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x72F4250", Offset = "0x72F2C50", VA = "0x1872F4250")]
	private MBADDKCFDLI FPEBPOLCMLI(MBADDKCFDLI LPCLPANOJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x72F4A60", Offset = "0x72F3460", VA = "0x1872F4A60")]
	private void JHEOOOKEGKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x72F3620", Offset = "0x72F2020", VA = "0x1872F3620")]
	private void CLEGLLBPLFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class JKPGMHHEBJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Dictionary<Guid, MBADDKCFDLI> DNNINLMOCPD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long OMKGAKAMIPA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1290270", Offset = "0x128EC70", VA = "0x181290270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x72EFEE0", Offset = "0x72EE8E0", VA = "0x1872EFEE0")]
	public void INOEHFICEHA(long FNKMOIJJLLC, IEnumerable<MBADDKCFDLI> HMOLPKJLBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x72EFE80", Offset = "0x72EE880", VA = "0x1872EFE80")]
	public bool ENJBGOMILBO(Guid MNLAOAAAPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x72F0170", Offset = "0x72EEB70", VA = "0x1872F0170")]
	public bool MBEEDABKNGP(Guid MNLAOAAAPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x72EFCA0", Offset = "0x72EE6A0", VA = "0x1872EFCA0")]
	public bool BDJCDAMJFFL(MBADDKCFDLI HJGIGMKFNIG, [Out] MBADDKCFDLI DPICIOODCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x72F01D0", Offset = "0x72EEBD0", VA = "0x1872F01D0")]
	public IEnumerable<MBADDKCFDLI> OHHAGABMMPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x72F0220", Offset = "0x72EEC20", VA = "0x1872F0220")]
	public bool POHPGOOACHB(Guid MNLAOAAAPCD, [Out] MBADDKCFDLI PACBBFMGBPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x72EFE00", Offset = "0x72EE800", VA = "0x1872EFE00")]
	private bool BNFGGPFOJOF(MBADDKCFDLI MMECFHEAHOI, MBADDKCFDLI EFPBPDDONKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x72F0290", Offset = "0x72EEC90", VA = "0x1872F0290")]
	public JKPGMHHEBJH()
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
