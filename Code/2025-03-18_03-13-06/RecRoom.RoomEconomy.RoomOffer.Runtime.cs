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
		[Cpp2IlInjected.Address(RVA = "0x7D7FB10", Offset = "0x7D7ED10", VA = "0x187D7FB10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IMPJOEGLJNL : JPCPEAHADNM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PIBAGIPFGJB BHGPBENDAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LBCOJAKJNKF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IOHOCLFFFDE HEKNCBPMMIO();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GDDOHBHDHDH : LBCOJAKJNKF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D77AE0", Offset = "0x7D76CE0", VA = "0x187D77AE0")]
	[LDKBBAENJDF.GEEMEPAJEEA.KFNNKBLDKPF]
	internal static void LMOFFJNLCLN(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GDDOHBHDHDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D77A20", Offset = "0x7D76C20", VA = "0x187D77A20", Slot = "4")]
	public IOHOCLFFFDE HEKNCBPMMIO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[ALDPDJHMICB]
public class PIBAGIPFGJB : JFFCJHGPEPH, IDisposable, KLEKMEOGHLP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DDOFILKDPJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<PEDBOIOCCNE, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public PIBAGIPFGJB <>4__this;

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
		public FHLPBMOLKBA roomOfferType;

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
		private TaskAwaiter<DCJKBLPCMAD<PEDBOIOCCNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7D76AA0", Offset = "0x7D75CA0", VA = "0x187D76AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7D76FD0", Offset = "0x7D761D0", VA = "0x187D76FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GFGODJEIJLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<PEDBOIOCCNE, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public PIBAGIPFGJB <>4__this;

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
		public FHLPBMOLKBA roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<DCJKBLPCMAD<PEDBOIOCCNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7D77B50", Offset = "0x7D76D50", VA = "0x187D77B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7D780F0", Offset = "0x7D772F0", VA = "0x187D780F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct CJFJHPOJOPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public PIBAGIPFGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private PEDBOIOCCNE <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<NLLCECEDBKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7D75C80", Offset = "0x7D74E80", VA = "0x187D75C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7D761E0", Offset = "0x7D753E0", VA = "0x187D761E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OGLLCFNKPBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<List<FOILOLPNGJN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public PIBAGIPFGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<DCJKBLPCMAD<List<FOILOLPNGJN>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7D79CE0", Offset = "0x7D78EE0", VA = "0x187D79CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A0D0", Offset = "0x7D792D0", VA = "0x187D7A0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct DOMPGDKEOLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public PIBAGIPFGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public GJGNFGDHFCI player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7D77040", Offset = "0x7D76240", VA = "0x187D77040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7D773E0", Offset = "0x7D765E0", VA = "0x187D773E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct NLMHMDGNCAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public PIBAGIPFGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public PEDBOIOCCNE roomOffer;

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
		private TaskAwaiter<CPEANPEHCAG<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7D79720", Offset = "0x7D78920", VA = "0x187D79720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7D79C70", Offset = "0x7D78E70", VA = "0x187D79C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PLBCEMEINFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<CPEANPEHCAG<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public PIBAGIPFGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PEDBOIOCCNE roomOffer;

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
		private GJBPALAGGCC <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private OGCAJJAHJAO <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<OGCAJJAHJAO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7D7EDA0", Offset = "0x7D7DFA0", VA = "0x187D7EDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7D7F6D0", Offset = "0x7D7E8D0", VA = "0x187D7F6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KDEDGNCJGGC
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
			public KDEDGNCJGGC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7D7F740", Offset = "0x7D7E940", VA = "0x187D7F740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7D7FAB0", Offset = "0x7D7ECB0", VA = "0x187D7FAB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public PIBAGIPFGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public KDEDGNCJGGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7D79630", Offset = "0x7D78830", VA = "0x187D79630")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task GKKKMCANPKD(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7D79510", Offset = "0x7D78710", VA = "0x187D79510")]
		internal Guid? DOOKODAONFB(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct JMCLCPDKKKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<OGCAJJAHJAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public PIBAGIPFGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public PEDBOIOCCNE roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private KDEDGNCJGGC <>8__1;

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
		private TaskAwaiter<OGCAJJAHJAO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7D787E0", Offset = "0x7D779E0", VA = "0x187D787E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7D794A0", Offset = "0x7D786A0", VA = "0x187D794A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct CMHNCNIKBCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public PIBAGIPFGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<DCJKBLPCMAD<List<BADCJPKEPGN>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<List<PEDBOIOCCNE>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<DCJKBLPCMAD<List<BADCJPKEPGN>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7D76250", Offset = "0x7D75450", VA = "0x187D76250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7D76A40", Offset = "0x7D75C40", VA = "0x187D76A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct PGIJOOCCFAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public PIBAGIPFGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A140", Offset = "0x7D79340", VA = "0x187D7A140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A7B0", Offset = "0x7D799B0", VA = "0x187D7A7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct DPCMIJFFEFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public PIBAGIPFGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public GJGNFGDHFCI player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7D77450", Offset = "0x7D76650", VA = "0x187D77450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7D779B0", Offset = "0x7D76BB0", VA = "0x187D779B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan PMNIBAEKHIN;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string DHLKAOAHDNI = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string IIEEPPBECLF = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string OFFHMAKPOGG = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly KLMALFMCPOL CDACPNGLHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly HGMGKEGCNHK LBHHCEDLJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly PKLBFIOCMNH JPEFMFKFLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly FHHIANONFNH MDKMPMLAPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CCCHMDLMIBJ IDAKOGMDIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly IMPJOEGLJNL CCJJOKJILJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly OEKKFABNMEO EKJOCLHFECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly DJFFIBKFIAC KIMIMGJOCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly FIDLPHPBEKK GJEICPBEFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly APDBIEPKPGD PHHBHBAMAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly IOHOCLFFFDE DFAGEGJCDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> ALJOFLCDMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable EJHKEGHPACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task FIBPBPBEIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource DFCNHFGDEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long KLAJALBCCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool JPJEOEDAIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly CEHEJJIJOPP EICBJNGPDIF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private IDAGPNDMNBG PDNEGDCPCMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D7AD40", Offset = "0x7D79F40", VA = "0x187D7AD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MIOEGIOIKAG DGAIHOLFJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBDB360", Offset = "0xBDA560", VA = "0x180BDB360", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD5E830", Offset = "0xD5DA30", VA = "0x180D5E830", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CHAOMIGHCFG<PEDBOIOCCNE> CDAPPHKKBIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x969760", Offset = "0x968960", VA = "0x180969760", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x969740", Offset = "0x968940", VA = "0x180969740", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CHAOMIGHCFG<Guid> CIAMJMGNFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12C30", VA = "0x180B13A30", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD33230", Offset = "0xD32430", VA = "0x180D33230", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7D7D4D0", Offset = "0x7D7C6D0", VA = "0x187D7D4D0")]
	[LDKBBAENJDF.GEEMEPAJEEA.KFNNKBLDKPF]
	internal static void LMOFFJNLCLN(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7D7E680", Offset = "0x7D7D880", VA = "0x187D7E680")]
	[RecRoom.NoEngine.Common.Preserve]
	public PIBAGIPFGJB([KMMHIEIDBEA(null)] KLMALFMCPOL CDACPNGLHJN, [KMMHIEIDBEA(null)] HGMGKEGCNHK LBHHCEDLJJH, [KMMHIEIDBEA(null)] LKJLIEKKDMF NCPDCFOBKPB, [KMMHIEIDBEA(null)] PKLBFIOCMNH JPEFMFKFLJI, [KMMHIEIDBEA(null)] LBCOJAKJNKF FOCJGMKEIGJ, [KMMHIEIDBEA(null)] FHHIANONFNH MDKMPMLAPBK, [KMMHIEIDBEA("ShowPurchasePromptRateLimiter")] CCCHMDLMIBJ IDAKOGMDIGE, [KMMHIEIDBEA(null)] IMPJOEGLJNL CCJJOKJILJL, [KMMHIEIDBEA(null)] OCEHBNKGHFP KGJAANFHCHL, [KMMHIEIDBEA(null)] OEKKFABNMEO EKJOCLHFECK, [KMMHIEIDBEA(null)] DJFFIBKFIAC KIMIMGJOCDL, [KMMHIEIDBEA(null)] FIDLPHPBEKK GJEICPBEFIC, [KMMHIEIDBEA(null)] APDBIEPKPGD PHHBHBAMAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B460", Offset = "0x7D7A660", VA = "0x187D7B460", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7D7D320", Offset = "0x7D7C520", VA = "0x187D7D320", Slot = "10")]
	[AsyncStateMachine(typeof(DDOFILKDPJA))]
	public Task<CPEANPEHCAG<PEDBOIOCCNE, string>> LJEHLGBLLMD(Guid? ALKMFINCAJJ, long KCAAOMDKNIH, string MBDFMCIDAOB, string BIGHOOCGPMA, string FIBIFGBPBHH, int MBMCPNMENHC, FHLPBMOLKBA JEALJPMCBFI, [Optional] Dictionary<Guid, int> PIMDGPLGJLE, [Optional] Guid? BGALPFLKLAA, bool ENEHGEPAJMD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7D7CBD0", Offset = "0x7D7BDD0", VA = "0x187D7CBD0", Slot = "11")]
	[AsyncStateMachine(typeof(GFGODJEIJLE))]
	public Task<CPEANPEHCAG<PEDBOIOCCNE, string>> IKFANBDJPJC(Guid LJOJFOEGCJL, long KCAAOMDKNIH, string MBDFMCIDAOB, string BIGHOOCGPMA, string FIBIFGBPBHH, int MBMCPNMENHC, FHLPBMOLKBA JEALJPMCBFI, [Optional] Dictionary<Guid, int> PIMDGPLGJLE, [Optional] Guid? BGALPFLKLAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7D7D200", Offset = "0x7D7C400", VA = "0x187D7D200", Slot = "12")]
	[AsyncStateMachine(typeof(CJFJHPOJOPC))]
	public Task<CPEANPEHCAG<bool, string>> LGCBNPPNDKK(Guid DHCJPNPBMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C660", Offset = "0x7D7B860", VA = "0x187D7C660", Slot = "13")]
	public IEnumerable<PEDBOIOCCNE> HNCOLJJDGHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7D7BED0", Offset = "0x7D7B0D0", VA = "0x187D7BED0", Slot = "14")]
	[AsyncStateMachine(typeof(OGLLCFNKPBA))]
	public Task<List<FOILOLPNGJN>> FMEKBBANJNI(long KCAAOMDKNIH, [Optional] CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7D7D000", Offset = "0x7D7C200", VA = "0x187D7D000", Slot = "17")]
	public bool KOIIODEEEPA(Guid DHCJPNPBMDG, int APOIHCCCCJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D7DC50", Offset = "0x7D7CE50", VA = "0x187D7DC50", Slot = "15")]
	public bool OCGDIMBJAIE(Guid DHCJPNPBMDG, [Out] PEDBOIOCCNE MCEIBKKMBOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C400", Offset = "0x7D7B600", VA = "0x187D7C400", Slot = "16")]
	public bool HGLBOJMHNLI(string MBDFMCIDAOB, [Out] PEDBOIOCCNE MCEIBKKMBOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7D7AEF0", Offset = "0x7D7A0F0", VA = "0x187D7AEF0", Slot = "18")]
	public void BCDNKODJEOH(GJGNFGDHFCI NCAFEKBCKBL, Guid DHCJPNPBMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C000", Offset = "0x7D7B200", VA = "0x187D7C000", Slot = "19")]
	[AsyncStateMachine(typeof(DOMPGDKEOLH))]
	public Task<int> HAAHFAJHBLJ(GJGNFGDHFCI NCAFEKBCKBL, Guid DHCJPNPBMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D7D680", Offset = "0x7D7C880", VA = "0x187D7D680", Slot = "20")]
	public bool MEGGPNJNPEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D7DD40", Offset = "0x7D7CF40", VA = "0x187D7DD40", Slot = "21")]
	public bool OJGALCBBKIK(Guid LJEMMPEPGIK, [Out] List<string> MJOBJMMNPHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D7AD90", Offset = "0x7D79F90", VA = "0x187D7AD90", Slot = "22")]
	[AsyncStateMachine(typeof(NLMHMDGNCAB))]
	public Task<CPEANPEHCAG<bool, string>> AKOOEACHBOL(PEDBOIOCCNE MCEIBKKMBOK, long POBIMLMMJMA, int NFLFPJLJGMO, string MOPMKDIPAPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A810", Offset = "0x7D79A10", VA = "0x187D7A810")]
	[AsyncStateMachine(typeof(PLBCEMEINFE))]
	private Task<CPEANPEHCAG<bool, string>> AABNPCPMHLL(PEDBOIOCCNE MCEIBKKMBOK, long POBIMLMMJMA, long FKHJPJLIFMN, string MOPMKDIPAPA, int NFLFPJLJGMO = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D7CEA0", Offset = "0x7D7C0A0", VA = "0x187D7CEA0")]
	[AsyncStateMachine(typeof(JMCLCPDKKKK))]
	private Task<OGCAJJAHJAO> KODHFKGKDMP(PEDBOIOCCNE MCEIBKKMBOK, int NFLFPJLJGMO, int POBIMLMMJMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7D7D900", Offset = "0x7D7CB00", VA = "0x187D7D900")]
	private bool OAMDEDPELCG(IEnumerable<NJLEKCADGPD> FECEEACPOJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A970", Offset = "0x7D79B70", VA = "0x187D7A970")]
	private void AGCBLAELGGC(PEDBOIOCCNE MCEIBKKMBOK, long FKHJPJLIFMN, int NFLFPJLJGMO, string MOPMKDIPAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C1B0", Offset = "0x7D7B3B0", VA = "0x187D7C1B0")]
	private string HFEONBCGCBP(PEDBOIOCCNE MCEIBKKMBOK, int NFLFPJLJGMO, string MOPMKDIPAPA, [Optional] GJBPALAGGCC? CMLOHOMLNDL, [Optional] BKKNAFNGJBF? MFLHDHJFJEO, [Optional] string CEIIHDLINDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B0D0", Offset = "0x7D7A2D0", VA = "0x187D7B0D0")]
	private GJBPALAGGCC BEPCDJKJKOA(PEDBOIOCCNE JDNMOJNOCNN, int NOFMABCONOD, [Out] long FKHJPJLIFMN)
	{
		return default(GJBPALAGGCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7D7CAC0", Offset = "0x7D7BCC0", VA = "0x187D7CAC0")]
	[AsyncStateMachine(typeof(CMHNCNIKBCD))]
	private Task IEFHBLAJHHE(long KCAAOMDKNIH, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B6C0", Offset = "0x7D7A8C0", VA = "0x187D7B6C0")]
	private Task ECNHMICKPHD(JCDLFPMDPEJ MEDGLPBHGFL, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7D7BE00", Offset = "0x7D7B000", VA = "0x187D7BE00")]
	[AsyncStateMachine(typeof(PGIJOOCCFAJ))]
	private Task FDBIAFMGPGL(JCDLFPMDPEJ MEDGLPBHGFL, CancellationToken BCMEGDDNKDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7D7BAA0", Offset = "0x7D7ACA0", VA = "0x187D7BAA0")]
	private static Dictionary<Guid, int> EMFLNFFHMPF(DCJKBLPCMAD<List<BADCJPKEPGN>> IFILJNJAFKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D7DD30", Offset = "0x7D7CF30", VA = "0x187D7DD30")]
	private void OFMFGMIHEKF(PEDBOIOCCNE MCEIBKKMBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C140", Offset = "0x7D7B340", VA = "0x187D7C140")]
	private void HEPDKINAJEA(Guid DHCJPNPBMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7D7E420", Offset = "0x7D7D620", VA = "0x187D7E420")]
	[FFNFKFIEFNL]
	internal void RpcOfferShowPurchasePrompt(Guid DHCJPNPBMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7D7D540", Offset = "0x7D7C740", VA = "0x187D7D540")]
	[AsyncStateMachine(typeof(DPCMIJFFEFM))]
	private Task<int> LOHMJAJCHNN(GJGNFGDHFCI NCAFEKBCKBL, Guid LJEMMPEPGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7D7E230", Offset = "0x7D7D430", VA = "0x187D7E230")]
	[FFNFKFIEFNL]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid LDHEJEOPGBF, Guid DHCJPNPBMDG, PAIBCENKFDF LEOELMHJFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D7E1B0", Offset = "0x7D7D3B0", VA = "0x187D7E1B0")]
	[FFNFKFIEFNL]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid LDHEJEOPGBF, int IPBKHOJKHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C710", Offset = "0x7D7B910", VA = "0x187D7C710", Slot = "24")]
	public string IDONPMNEFAI(GJBPALAGGCC CMLOHOMLNDL, [Optional] BKKNAFNGJBF? GKKJNGMBJHC, [Optional] BalanceResponseDTO FFNIDNHAKHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B370", Offset = "0x7D7A570", VA = "0x187D7B370")]
	private static string CCDOLBMIJGK(BKKNAFNGJBF GKKJNGMBJHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D7D760", Offset = "0x7D7C960", VA = "0x187D7D760")]
	private PEDBOIOCCNE NCIPBCMMMKN(PEDBOIOCCNE KJKILMDPFOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7D7E140", Offset = "0x7D7D340", VA = "0x187D7E140")]
	private void PBKBJCFPGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7D7CD70", Offset = "0x7D7BF70", VA = "0x187D7CD70")]
	private void KHMJBPDMAHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class IOHOCLFFFDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Guid, PEDBOIOCCNE> HLFGGMAKDBH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long CBKFHOJDEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xB62B50", Offset = "0xB61D50", VA = "0x180B62B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7D78160", Offset = "0x7D77360", VA = "0x187D78160")]
	public void EAEBMKLJJFN(long KCAAOMDKNIH, IEnumerable<PEDBOIOCCNE> EKBICOPGCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7D78620", Offset = "0x7D77820", VA = "0x187D78620")]
	public bool NOAFIIHAFPH(Guid DHCJPNPBMDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7D786F0", Offset = "0x7D778F0", VA = "0x187D786F0")]
	public bool OGPGHNCGHLC(Guid DHCJPNPBMDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7D784C0", Offset = "0x7D776C0", VA = "0x187D784C0")]
	public bool MHMENKPHLJL(PEDBOIOCCNE JOGDIBIJDDL, [Out] PEDBOIOCCNE ACPICJNMFCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7D783F0", Offset = "0x7D775F0", VA = "0x187D783F0")]
	public IEnumerable<PEDBOIOCCNE> KEBHOKBGCCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7D78680", Offset = "0x7D77880", VA = "0x187D78680")]
	public bool OCGDIMBJAIE(Guid DHCJPNPBMDG, [Out] PEDBOIOCCNE MCEIBKKMBOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7D78440", Offset = "0x7D77640", VA = "0x187D78440")]
	private bool KHPEDPEHOLA(PEDBOIOCCNE JIPFKIHJIDL, PEDBOIOCCNE FCENMCHKABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7D78750", Offset = "0x7D77950", VA = "0x187D78750")]
	public IOHOCLFFFDE()
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
