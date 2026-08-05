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
		[Cpp2IlInjected.Address(RVA = "0x8D77430", Offset = "0x8D75E30", VA = "0x188D77430", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BGPJFGEANCL : JLBJFLKPBHM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FONJKLJHOPC BAGJHOFJLLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GPPGMHLLECM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GJGBMLAEPBJ BJLENNMGLCM();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FNHCNDMGHKE : GPPGMHLLECM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8D6E390", Offset = "0x8D6CD90", VA = "0x188D6E390")]
	[DMKNBLIJJON.FLOPHDCKCCN.LAPOKDABJFJ]
	internal static void BHAGPFKLBNG(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	[RecRoom.NoEngine.Common.Preserve]
	public FNHCNDMGHKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8D6E400", Offset = "0x8D6CE00", VA = "0x188D6E400", Slot = "4")]
	public GJGBMLAEPBJ BJLENNMGLCM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LDDMKMABCFO]
public class FONJKLJHOPC : IMKFLKGIOMF, IDisposable, GLOPBJKODMI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct KCNKEBGNIBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<FEENKEDBOAD<CDBNKOPIMAJ, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public FONJKLJHOPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid? originId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool hasDynamicPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int minimumDynamicPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int maximumDynamicPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public GJFJKNIHJKL roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public bool allowRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<KADCEGKBANA<CDBNKOPIMAJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8D74CE0", Offset = "0x8D736E0", VA = "0x188D74CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8D75260", Offset = "0x8D73C60", VA = "0x188D75260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct EOBFAPBEHGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<FEENKEDBOAD<CDBNKOPIMAJ, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public FONJKLJHOPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Guid roomOfferOriginId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public bool hasDynamicPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int minimumDynamicPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int maximumDynamicPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public GJFJKNIHJKL roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<KADCEGKBANA<CDBNKOPIMAJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6DD00", Offset = "0x8D6C700", VA = "0x188D6DD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E320", Offset = "0x8D6CD20", VA = "0x188D6E320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct MLBKCAFDACM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<FEENKEDBOAD<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public FONJKLJHOPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private CDBNKOPIMAJ <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<ENEHDIDOEFG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8D75890", Offset = "0x8D74290", VA = "0x188D75890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8D75DE0", Offset = "0x8D747E0", VA = "0x188D75DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct DPJOEFLKBNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<List<MAHNKPHFAAP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public FONJKLJHOPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<KADCEGKBANA<List<MAHNKPHFAAP>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8D6D890", Offset = "0x8D6C290", VA = "0x188D6D890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8D6DC90", Offset = "0x8D6C690", VA = "0x188D6DC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct GAGOJFHNBPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public FONJKLJHOPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public FNAEIBBBBBE player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8D73C80", Offset = "0x8D72680", VA = "0x188D73C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8D74020", Offset = "0x8D72A20", VA = "0x188D74020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct LKIAPMCPPIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<FEENKEDBOAD<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public FONJKLJHOPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CDBNKOPIMAJ roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string purchaseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<FEENKEDBOAD<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8D752D0", Offset = "0x8D73CD0", VA = "0x188D752D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8D75820", Offset = "0x8D74220", VA = "0x188D75820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PNMFJPDNBKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<FEENKEDBOAD<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public FONJKLJHOPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public CDBNKOPIMAJ roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public string purchaseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long initialBalance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private IPBGLCGMMCD <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private HGNCPMJBHEM <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<HGNCPMJBHEM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8D766B0", Offset = "0x8D750B0", VA = "0x188D766B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8D76FE0", Offset = "0x8D759E0", VA = "0x188D76FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class AELBNIDHDKJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private struct <<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public AELBNIDHDKJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8D77050", Offset = "0x8D75A50", VA = "0x188D77050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8D773D0", Offset = "0x8D75DD0", VA = "0x188D773D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public FONJKLJHOPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AELBNIDHDKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C940", Offset = "0x8D6B340", VA = "0x188D6C940")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task FCNCMCFMJOF(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8D6CA30", Offset = "0x8D6B430", VA = "0x188D6CA30")]
		internal Guid? LJJKFGJJCOD(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CLHFNMNBING : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<HGNCPMJBHEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public FONJKLJHOPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CDBNKOPIMAJ roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private AELBNIDHDKJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private Dictionary<Guid, Guid?> <concurrencyCodeByItemIdMap>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private Guid <itemId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<HGNCPMJBHEM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8D6CB50", Offset = "0x8D6B550", VA = "0x188D6CB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8D6D820", Offset = "0x8D6C220", VA = "0x188D6D820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct NBOGFGENCKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public FONJKLJHOPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private Task<KADCEGKBANA<List<MBOCOAHGGGA>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<List<CDBNKOPIMAJ>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<KADCEGKBANA<List<MBOCOAHGGGA>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8D75E50", Offset = "0x8D74850", VA = "0x188D75E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8D76650", Offset = "0x8D75050", VA = "0x188D76650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FPOMFIHJFDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public FONJKLJHOPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8D735A0", Offset = "0x8D71FA0", VA = "0x188D735A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8D73C20", Offset = "0x8D72620", VA = "0x188D73C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct HOKOCPJAJFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public FONJKLJHOPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public FNAEIBBBBBE player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8D74700", Offset = "0x8D73100", VA = "0x188D74700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8D74C70", Offset = "0x8D73670", VA = "0x188D74C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan BAIICKNAOGB;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string PHKMNAICKIP = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string JLNFBPOOHKC = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string MAPBBPKIMAB = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly ONCDPENGOJI NPOPGEKEGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly LEDGLCJMNLL BPPIMJDKDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly MGOFFHGFIHD OPDBKFPCKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly CMANBFFCBML FGKLNKPJLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly IKBKCKIHPFM JGLHBMPKBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly BGPJFGEANCL CNFNOIIHLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly FMBBAPCDBOB ADCMGLPBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly POENMEJJLEF KKALBEDLECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly DHAIBAFNOKJ BMGAFLHELHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly MEDFICBLIIJ CKAEEDAGMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly GJGBMLAEPBJ HPEAACBONJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> PAEFPLCJPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable HOOHHABLJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task MLAACDGMAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource GBKODMKEPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long FCEEOPNODHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool JPNPFIIDGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly LGNCEIJAFPJ AJHGLMOIMEN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private LPDALFKAMFK GIBCNHFDFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8D70B50", Offset = "0x8D6F550", VA = "0x188D70B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EBDGCEEEFPM OBKHLJCOGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB79620", Offset = "0xB78020", VA = "0x180B79620", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB795D0", Offset = "0xB77FD0", VA = "0x180B795D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public AHDLCNFLGGK<CDBNKOPIMAJ> EBLKNJJLCHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAB9520", Offset = "0xAB7F20", VA = "0x180AB9520", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAB9490", Offset = "0xAB7E90", VA = "0x180AB9490", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AHDLCNFLGGK<Guid> MMMPMPGCHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB793D0", Offset = "0xB77DD0", VA = "0x180B793D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB795F0", Offset = "0xB77FF0", VA = "0x180B795F0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AHDLCNFLGGK<Guid> OKJLCLPMINC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xEE2960", Offset = "0xEE1360", VA = "0x180EE2960", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xEE2970", Offset = "0xEE1370", VA = "0x180EE2970", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8D6E8B0", Offset = "0x8D6D2B0", VA = "0x188D6E8B0")]
	[DMKNBLIJJON.FLOPHDCKCCN.LAPOKDABJFJ]
	internal static void BHAGPFKLBNG(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8D72E20", Offset = "0x8D71820", VA = "0x188D72E20")]
	[RecRoom.NoEngine.Common.Preserve]
	public FONJKLJHOPC([BMCONCJPCIA(null)] ONCDPENGOJI NPOPGEKEGKF, [BMCONCJPCIA(null)] LEDGLCJMNLL BPPIMJDKDDC, [BMCONCJPCIA(null)] FABKHPHGOJG CCLILLPKLPO, [BMCONCJPCIA(null)] MGOFFHGFIHD OPDBKFPCKJO, [BMCONCJPCIA(null)] GPPGMHLLECM LMECGOKKHDA, [BMCONCJPCIA(null)] CMANBFFCBML FGKLNKPJLFC, [BMCONCJPCIA("ShowPurchasePromptRateLimiter")] IKBKCKIHPFM JGLHBMPKBMA, [BMCONCJPCIA(null)] BGPJFGEANCL CNFNOIIHLFN, [BMCONCJPCIA(null)] GHDPPJPLFBA LCGMCNPGOKP, [BMCONCJPCIA(null)] FMBBAPCDBOB ADCMGLPBECA, [BMCONCJPCIA(null)] POENMEJJLEF KKALBEDLECP, [BMCONCJPCIA(null)] DHAIBAFNOKJ BMGAFLHELHL, [BMCONCJPCIA(null)] MEDFICBLIIJ CKAEEDAGMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8D6F4A0", Offset = "0x8D6DEA0", VA = "0x188D6F4A0", Slot = "30")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8D6EF40", Offset = "0x8D6D940", VA = "0x188D6EF40", Slot = "12")]
	[AsyncStateMachine(typeof(KCNKEBGNIBP))]
	public Task<FEENKEDBOAD<CDBNKOPIMAJ, string>> CPENGBKAGIC(Guid? GBFHHPHEKAE, long GDCAPMONNDM, string IELIBBNCJAC, string GDFPOPIGPDJ, string CGPNBEBFGEL, int MANOLGLEOMD, bool GPLGMENJLMF, int ONBCFPIHPKM, int DMDOCHBPEJE, GJFJKNIHJKL MOCCACNMFLN, [Optional] Dictionary<Guid, int> CPDLMNLAHHJ, [Optional] Guid? HGDFBLJLHAD, bool DFEBCDBMDKF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8D6E920", Offset = "0x8D6D320", VA = "0x188D6E920", Slot = "13")]
	[AsyncStateMachine(typeof(EOBFAPBEHGD))]
	public Task<FEENKEDBOAD<CDBNKOPIMAJ, string>> BNPJMEGDMEG(Guid BCFMKAGABNE, long GDCAPMONNDM, string IELIBBNCJAC, string GDFPOPIGPDJ, string CGPNBEBFGEL, int MANOLGLEOMD, bool GPLGMENJLMF, int ONBCFPIHPKM, int DMDOCHBPEJE, GJFJKNIHJKL MOCCACNMFLN, [Optional] Dictionary<Guid, int> CPDLMNLAHHJ, [Optional] Guid? HGDFBLJLHAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8D724D0", Offset = "0x8D70ED0", VA = "0x188D724D0", Slot = "14")]
	[AsyncStateMachine(typeof(MLBKCAFDACM))]
	public Task<FEENKEDBOAD<bool, string>> OKIAGDHJEFO(Guid PPLHMDMKIHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8D6FF30", Offset = "0x8D6E930", VA = "0x188D6FF30", Slot = "15")]
	public IEnumerable<CDBNKOPIMAJ> FDEGBGICDNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8D6F370", Offset = "0x8D6DD70", VA = "0x188D6F370", Slot = "16")]
	[AsyncStateMachine(typeof(DPJOEFLKBNN))]
	public Task<List<MAHNKPHFAAP>> DJEBGBGNJAP(long GDCAPMONNDM, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8D6FD30", Offset = "0x8D6E730", VA = "0x188D6FD30", Slot = "19")]
	public bool EKIAJEIMOCF(Guid PPLHMDMKIHC, int MJIDHKLFBIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8D71740", Offset = "0x8D70140", VA = "0x188D71740", Slot = "17")]
	public bool MMGGPLLCNOO(Guid PPLHMDMKIHC, [Out] CDBNKOPIMAJ DPAJDHBLJBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8D6F110", Offset = "0x8D6DB10", VA = "0x188D6F110", Slot = "18")]
	public bool DDHKPEBLKAP(string IELIBBNCJAC, [Out] CDBNKOPIMAJ DPAJDHBLJBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8D70970", Offset = "0x8D6F370", VA = "0x188D70970", Slot = "20")]
	public void JACJBEFFNOB(FNAEIBBBBBE BLHNDOLLIDD, Guid PPLHMDMKIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8D71300", Offset = "0x8D6FD00", VA = "0x188D71300", Slot = "21")]
	[AsyncStateMachine(typeof(GAGOJFHNBPJ))]
	public Task<int> LJFONBOFJIF(FNAEIBBBBBE BLHNDOLLIDD, Guid PPLHMDMKIHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8D6FB20", Offset = "0x8D6E520", VA = "0x188D6FB20", Slot = "22")]
	public bool EIFKNLAOOPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8D6F720", Offset = "0x8D6E120", VA = "0x188D6F720", Slot = "23")]
	public bool ECOECMBDIJG(Guid NELOONOBALM, [Out] List<string> DLBLJMJFPPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8D71440", Offset = "0x8D6FE40", VA = "0x188D71440", Slot = "24")]
	[AsyncStateMachine(typeof(LKIAPMCPPIA))]
	public Task<FEENKEDBOAD<bool, string>> LMDADAEDBJH(CDBNKOPIMAJ DPAJDHBLJBN, long MCIFNPFIHOD, int BKCEIDHPFJM, string NGBMLFMMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8D71960", Offset = "0x8D70360", VA = "0x188D71960")]
	[AsyncStateMachine(typeof(PNMFJPDNBKN))]
	private Task<FEENKEDBOAD<bool, string>> NDELKENCCCF(CDBNKOPIMAJ DPAJDHBLJBN, long MCIFNPFIHOD, long NOIKEDFKHON, string NGBMLFMMFEE, int BKCEIDHPFJM = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8D70810", Offset = "0x8D6F210", VA = "0x188D70810")]
	[AsyncStateMachine(typeof(CLHFNMNBING))]
	private Task<HGNCPMJBHEM> INPGMNOGHMC(CDBNKOPIMAJ DPAJDHBLJBN, int BKCEIDHPFJM, int MCIFNPFIHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8D725F0", Offset = "0x8D70FF0", VA = "0x188D725F0")]
	private bool PNPKIHLGBIC(IEnumerable<LGEEKDLHLIB> DKAFKNBIKNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8D6EAF0", Offset = "0x8D6D4F0", VA = "0x188D6EAF0")]
	private void CNOCBHLBHFF(CDBNKOPIMAJ DPAJDHBLJBN, long NOIKEDFKHON, int BKCEIDHPFJM, string NGBMLFMMFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8D70CB0", Offset = "0x8D6F6B0", VA = "0x188D70CB0")]
	private string KCEADKDKDHO(CDBNKOPIMAJ DPAJDHBLJBN, int BKCEIDHPFJM, string NGBMLFMMFEE, [Optional] IPBGLCGMMCD? GGIKEMCHAAA, [Optional] LACADHPJJMN? IGCMIJPOLBC, [Optional] string PEDNLFPNKEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8D71AC0", Offset = "0x8D704C0", VA = "0x188D71AC0")]
	private IPBGLCGMMCD NKLHPPEDBNG(CDBNKOPIMAJ PPPPADFLOHK, int OIOKPEJKKLF, [Out] long NOIKEDFKHON)
	{
		return default(IPBGLCGMMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8D702E0", Offset = "0x8D6ECE0", VA = "0x188D702E0", Slot = "29")]
	public void GCHJFGKGAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8D70050", Offset = "0x8D6EA50", VA = "0x188D70050")]
	private void FPIPINEHDOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8D703E0", Offset = "0x8D6EDE0", VA = "0x188D703E0", Slot = "25")]
	public bool HHIGOCAGNOE(Guid PPLHMDMKIHC, string GPMAKNBMGLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8D6E4C0", Offset = "0x8D6CEC0", VA = "0x188D6E4C0", Slot = "27")]
	public bool ABKPBEHFMOC(Guid PPLHMDMKIHC, string MIKNNHMHLPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8D6E720", Offset = "0x8D6D120", VA = "0x188D6E720", Slot = "26")]
	public bool BDHCCADBMFD(Guid PPLHMDMKIHC, string DEONJFAOAPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8D70570", Offset = "0x8D6EF70", VA = "0x188D70570", Slot = "28")]
	public LJLCPPMEHMJ IHBMCJFLDJI(Guid PPLHMDMKIHC, int? MLKHMOGGDIB)
	{
		return default(LJLCPPMEHMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8D70BA0", Offset = "0x8D6F5A0", VA = "0x188D70BA0")]
	[AsyncStateMachine(typeof(NBOGFGENCKH))]
	private Task KAFKHPDBOLI(long GDCAPMONNDM, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8D720E0", Offset = "0x8D70AE0", VA = "0x188D720E0")]
	private Task OHABKPNNDCE(CMFAJILFAHI ALHCDLPBNNA, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8D6E650", Offset = "0x8D6D050", VA = "0x188D6E650")]
	[AsyncStateMachine(typeof(FPOMFIHJFDC))]
	private Task ALIIDHEAFBB(CMFAJILFAHI ALHCDLPBNNA, CancellationToken LHAJAHOJHGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8D71D80", Offset = "0x8D70780", VA = "0x188D71D80")]
	private static Dictionary<Guid, int> OCHLIBHKPAC(KADCEGKBANA<List<MBOCOAHGGGA>> NCJOMFFFDDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8D6EAE0", Offset = "0x8D6D4E0", VA = "0x188D6EAE0")]
	private void CKGMFILNDHC(CDBNKOPIMAJ DPAJDHBLJBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8D6EED0", Offset = "0x8D6D8D0", VA = "0x188D6EED0")]
	private void COGFFIMBEPN(Guid PPLHMDMKIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8D72BC0", Offset = "0x8D715C0", VA = "0x188D72BC0")]
	[OANEHPBACDO]
	internal void RpcOfferShowPurchasePrompt(Guid PPLHMDMKIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8D71820", Offset = "0x8D70220", VA = "0x188D71820")]
	[AsyncStateMachine(typeof(HOKOCPJAJFH))]
	private Task<int> NBOHNECEDGG(FNAEIBBBBBE BLHNDOLLIDD, Guid NELOONOBALM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8D729D0", Offset = "0x8D713D0", VA = "0x188D729D0")]
	[OANEHPBACDO]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid CHBBGPKOFFN, Guid PPLHMDMKIHC, MEEBGCNEDOD IMPJJOAFALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8D72950", Offset = "0x8D71350", VA = "0x188D72950")]
	[OANEHPBACDO]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid CHBBGPKOFFN, int MHMCOJIKNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8D70F10", Offset = "0x8D6F910", VA = "0x188D70F10", Slot = "31")]
	public string KGKLNIDMHCP(IPBGLCGMMCD GGIKEMCHAAA, [Optional] LACADHPJJMN? INLHHAEPACL, [Optional] BalanceResponseDTO LLAABOELCAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8D702F0", Offset = "0x8D6ECF0", VA = "0x188D702F0")]
	private static string GFBDMINFKCH(LACADHPJJMN INLHHAEPACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8D715A0", Offset = "0x8D6FFA0", VA = "0x188D715A0")]
	private CDBNKOPIMAJ MHJFHBBCAPA(CDBNKOPIMAJ EPINDPEHHCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8D6FFE0", Offset = "0x8D6E9E0", VA = "0x188D6FFE0")]
	private void FLAOPEPOOJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8D6FC00", Offset = "0x8D6E600", VA = "0x188D6FC00")]
	private void EIHGGHGHBDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class GJGBMLAEPBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Dictionary<Guid, CDBNKOPIMAJ> DMBGDIBKIKH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private long JELONAFLPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xE18C10", Offset = "0xE17610", VA = "0x180E18C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8D74090", Offset = "0x8D72A90", VA = "0x188D74090")]
	public void FLAEJOMCJLF(long GDCAPMONNDM, IEnumerable<CDBNKOPIMAJ> NEBMHOKAONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8D74610", Offset = "0x8D73010", VA = "0x188D74610")]
	public bool OOCOMCCBBOJ(Guid PPLHMDMKIHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8D744F0", Offset = "0x8D72EF0", VA = "0x188D744F0")]
	public bool MCKODPOBNPM(Guid PPLHMDMKIHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8D74310", Offset = "0x8D72D10", VA = "0x188D74310")]
	public bool JLBOHKEAKHP(CDBNKOPIMAJ BHEJJHLOLBM, [Out] CDBNKOPIMAJ FMOHJGJKLBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8D745C0", Offset = "0x8D72FC0", VA = "0x188D745C0")]
	public IEnumerable<CDBNKOPIMAJ> NKNIBODKEBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8D74550", Offset = "0x8D72F50", VA = "0x188D74550")]
	public bool MMGGPLLCNOO(Guid PPLHMDMKIHC, [Out] CDBNKOPIMAJ DPAJDHBLJBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8D74470", Offset = "0x8D72E70", VA = "0x188D74470")]
	private bool LIIJBNFHLAN(CDBNKOPIMAJ FCPDBBAAIEF, CDBNKOPIMAJ MEMEJBJJBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8D74670", Offset = "0x8D73070", VA = "0x188D74670")]
	public GJGBMLAEPBJ()
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
