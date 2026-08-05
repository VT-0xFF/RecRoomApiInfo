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
		[Cpp2IlInjected.Address(RVA = "0x8D7D7D0", Offset = "0x8D7BDD0", VA = "0x188D7D7D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GKACLKCOAHG : LCGIJPNGIOA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OEIGLODCGLO FFHGJMFKAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OPMNLENPNOM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KEBPGGJDEAP CMEBHENKDGH();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JKBAGENOMHD : OPMNLENPNOM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8D76F60", Offset = "0x8D75560", VA = "0x188D76F60")]
	[EGNICHGEFDG.FKEMGOBKAHC.CJJMBHGCOLI]
	internal static void KHFEDOGILIL(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	[RecRoom.NoEngine.Common.Preserve]
	public JKBAGENOMHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8D76EA0", Offset = "0x8D754A0", VA = "0x188D76EA0", Slot = "4")]
	public KEBPGGJDEAP CMEBHENKDGH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OEHADFBFMEG]
public class OEIGLODCGLO : OECNKMGODKA, IDisposable, CGBFDMEMEEL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct CALCBFHDCGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<CKPAOGHIJHA<EHNKJKPGKMF, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public OEIGLODCGLO <>4__this;

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
		public KCPDOEHJJAH roomOfferType;

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
		private TaskAwaiter<IPLCGLKKMAF<EHNKJKPGKMF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8D74830", Offset = "0x8D72E30", VA = "0x188D74830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8D74DC0", Offset = "0x8D733C0", VA = "0x188D74DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct INDBMHHIPFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<CKPAOGHIJHA<EHNKJKPGKMF, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public OEIGLODCGLO <>4__this;

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
		public KCPDOEHJJAH roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IPLCGLKKMAF<EHNKJKPGKMF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8D75FA0", Offset = "0x8D745A0", VA = "0x188D75FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8D765D0", Offset = "0x8D74BD0", VA = "0x188D765D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct MLNHPCALCMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<CKPAOGHIJHA<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public OEIGLODCGLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private EHNKJKPGKMF <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<IAIGMINPBFN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8D77650", Offset = "0x8D75C50", VA = "0x188D77650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8D77BB0", Offset = "0x8D761B0", VA = "0x188D77BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct BBADNNJCCJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<List<MHAPAMBJFEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public OEIGLODCGLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<IPLCGLKKMAF<List<MHAPAMBJFEH>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8D73FB0", Offset = "0x8D725B0", VA = "0x188D73FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8D743B0", Offset = "0x8D729B0", VA = "0x188D743B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct BKLGAJAPEBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public OEIGLODCGLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public MEINMPIOLGA player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8D74420", Offset = "0x8D72A20", VA = "0x188D74420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8D747C0", Offset = "0x8D72DC0", VA = "0x188D747C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct IMEOBMEKAPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<CKPAOGHIJHA<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public OEIGLODCGLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public EHNKJKPGKMF roomOffer;

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
		private TaskAwaiter<CKPAOGHIJHA<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8D759E0", Offset = "0x8D73FE0", VA = "0x188D759E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8D75F30", Offset = "0x8D74530", VA = "0x188D75F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FFJMHEDPHCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<CKPAOGHIJHA<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public OEIGLODCGLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public EHNKJKPGKMF roomOffer;

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
		private CFGNMBFPEFJ <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private BGJMIKEJGNJ <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<BGJMIKEJGNJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8D74E30", Offset = "0x8D73430", VA = "0x188D74E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8D75760", Offset = "0x8D73D60", VA = "0x188D75760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class ILGLOAHFEFD
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
			public ILGLOAHFEFD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8D7D3F0", Offset = "0x8D7B9F0", VA = "0x188D7D3F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8D7D770", Offset = "0x8D7BD70", VA = "0x188D7D770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public OEIGLODCGLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public ILGLOAHFEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8D758F0", Offset = "0x8D73EF0", VA = "0x188D758F0")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task KJEJOMDGOPN(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8D757D0", Offset = "0x8D73DD0", VA = "0x188D757D0")]
		internal Guid? BKAPJDNGJJK(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct ADPIPNINLPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<BGJMIKEJGNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public OEIGLODCGLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public EHNKJKPGKMF roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private ILGLOAHFEFD <>8__1;

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
		private TaskAwaiter<BGJMIKEJGNJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8D72C70", Offset = "0x8D71270", VA = "0x188D72C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8D73950", Offset = "0x8D71F50", VA = "0x188D73950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JDDCOMEEBAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public OEIGLODCGLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private Task<IPLCGLKKMAF<List<NACFCFFAAML>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<List<EHNKJKPGKMF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<IPLCGLKKMAF<List<NACFCFFAAML>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8D76640", Offset = "0x8D74C40", VA = "0x188D76640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8D76E40", Offset = "0x8D75440", VA = "0x188D76E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct OPAOMHBKPOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public OEIGLODCGLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8D7CD10", Offset = "0x8D7B310", VA = "0x188D7CD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8D7D390", Offset = "0x8D7B990", VA = "0x188D7D390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct BAFDMIMLOCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public OEIGLODCGLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public MEINMPIOLGA player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8D739C0", Offset = "0x8D71FC0", VA = "0x188D739C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8D73F40", Offset = "0x8D72540", VA = "0x188D73F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan PNPIEBLJKEF;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string BJILFJEAAIM = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string BAANKNJEIJE = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string NOOAJALNJFB = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HLFADKEBOGO MEEIGGPNEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly KFAJOGFMPAC BBDBIGBKGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly DNLMIGCBEIM LIKEKMCHKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly FDLKGNCJCMC IPEKJJONPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HPKDALEFJIK LIKPPOLMIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GKACLKCOAHG PPKBBLCGGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly NEIECICGJMO OHPHIKCFIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly KOMDDJGIAPB CFEBEOMACJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly BJJNKFMECOO JIMPPFMECIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FEEADJOHIDG KFKNCMLMILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly KEBPGGJDEAP KDJDADJDEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> NEHABOAPLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable CCHMGIAMEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task GHDMCGCBNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource EBJIOALLEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long HKFBIINFMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool AJNGKKLNKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly ABMKCEAPLOF KNKJJDKFGGO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private NKNGDLOHPMN AKCNGNFLEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8D78460", Offset = "0x8D76A60", VA = "0x188D78460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HLLOFHFLNHG LFIDALBPFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB78DA0", Offset = "0xB773A0", VA = "0x180B78DA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB78B30", Offset = "0xB77130", VA = "0x180B78B30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public PKBDHHCMFJK<EHNKJKPGKMF> NGJOOCNNBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAAEE90", Offset = "0xAAD490", VA = "0x180AAEE90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAAEF10", Offset = "0xAAD510", VA = "0x180AAEF10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public PKBDHHCMFJK<Guid> PAFKDLAJJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB78BB0", Offset = "0xB771B0", VA = "0x180B78BB0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB78B50", Offset = "0xB77150", VA = "0x180B78B50", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PKBDHHCMFJK<Guid> NEIEONPCDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xEDC690", Offset = "0xEDAC90", VA = "0x180EDC690", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xEDC6A0", Offset = "0xEDACA0", VA = "0x180EDC6A0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8D7AA80", Offset = "0x8D79080", VA = "0x188D7AA80")]
	[EGNICHGEFDG.FKEMGOBKAHC.CJJMBHGCOLI]
	internal static void KHFEDOGILIL(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8D7C590", Offset = "0x8D7AB90", VA = "0x188D7C590")]
	[RecRoom.NoEngine.Common.Preserve]
	public OEIGLODCGLO([EDHLHMEHMKO(null)] HLFADKEBOGO MEEIGGPNEIO, [EDHLHMEHMKO(null)] KFAJOGFMPAC BBDBIGBKGGK, [EDHLHMEHMKO(null)] BIDKKAOMJIC FGNBHLKJJPP, [EDHLHMEHMKO(null)] DNLMIGCBEIM LIKEKMCHKOI, [EDHLHMEHMKO(null)] OPMNLENPNOM BOHCNOEAPBA, [EDHLHMEHMKO(null)] FDLKGNCJCMC IPEKJJONPLO, [EDHLHMEHMKO("ShowPurchasePromptRateLimiter")] HPKDALEFJIK LIKPPOLMIIC, [EDHLHMEHMKO(null)] GKACLKCOAHG PPKBBLCGGEO, [EDHLHMEHMKO(null)] BLNFFCEJHPB PJMBMOIINPD, [EDHLHMEHMKO(null)] NEIECICGJMO OHPHIKCFIBF, [EDHLHMEHMKO(null)] KOMDDJGIAPB CFEBEOMACJA, [EDHLHMEHMKO(null)] BJJNKFMECOO JIMPPFMECIA, [EDHLHMEHMKO(null)] FEEADJOHIDG KFKNCMLMILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8D79570", Offset = "0x8D77B70", VA = "0x188D79570", Slot = "30")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8D78760", Offset = "0x8D76D60", VA = "0x188D78760", Slot = "12")]
	[AsyncStateMachine(typeof(CALCBFHDCGO))]
	public Task<CKPAOGHIJHA<EHNKJKPGKMF, string>> CGBODNLAOBF(Guid? BKJKAJIMPMA, long DDLHEHAKJGF, string NDIENANOGEK, string NGPLKKDGJMB, string IPHPNMCAICN, int JFFGCJGENMG, bool DOMCHMDFMDE, int DAIEFINMBNF, int BEBENJLKADN, KCPDOEHJJAH BBDNPELNOLF, [Optional] Dictionary<Guid, int> JPPECOPBPAK, [Optional] Guid? NEBCLFGEKDK, bool ECHMDIKFKLC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8D797F0", Offset = "0x8D77DF0", VA = "0x188D797F0", Slot = "13")]
	[AsyncStateMachine(typeof(INDBMHHIPFD))]
	public Task<CKPAOGHIJHA<EHNKJKPGKMF, string>> EAMLAPHHJNI(Guid GCPKGIPCPLO, long DDLHEHAKJGF, string NDIENANOGEK, string NGPLKKDGJMB, string IPHPNMCAICN, int JFFGCJGENMG, bool DOMCHMDFMDE, int DAIEFINMBNF, int BEBENJLKADN, KCPDOEHJJAH BBDNPELNOLF, [Optional] Dictionary<Guid, int> JPPECOPBPAK, [Optional] Guid? NEBCLFGEKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8D784B0", Offset = "0x8D76AB0", VA = "0x188D784B0", Slot = "14")]
	[AsyncStateMachine(typeof(MLNHPCALCMC))]
	public Task<CKPAOGHIJHA<bool, string>> BGLHAMCFKBD(Guid BIHHICHBGFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8D7B4E0", Offset = "0x8D79AE0", VA = "0x188D7B4E0", Slot = "15")]
	public IEnumerable<EHNKJKPGKMF> NPCCMPKPEIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8D78AD0", Offset = "0x8D770D0", VA = "0x188D78AD0", Slot = "16")]
	[AsyncStateMachine(typeof(BBADNNJCCJG))]
	public Task<List<MHAPAMBJFEH>> CKMEHFDFJIN(long DDLHEHAKJGF, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8D7BAD0", Offset = "0x8D7A0D0", VA = "0x188D7BAD0", Slot = "19")]
	public bool PNBGMDDNCAJ(Guid BIHHICHBGFP, int KCFNBDJBEAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8D799C0", Offset = "0x8D77FC0", VA = "0x188D799C0", Slot = "17")]
	public bool GFNIFFDKBEC(Guid BIHHICHBGFP, [Out] EHNKJKPGKMF KOFIDNJKFNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8D79310", Offset = "0x8D77910", VA = "0x188D79310", Slot = "18")]
	public bool DFHEJLKLNDN(string NDIENANOGEK, [Out] EHNKJKPGKMF KOFIDNJKFNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8D78C00", Offset = "0x8D77200", VA = "0x188D78C00", Slot = "20")]
	public void DAEHEMACPPE(MEINMPIOLGA AGIMJJDFEAF, Guid BIHHICHBGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8D7B990", Offset = "0x8D79F90", VA = "0x188D7B990", Slot = "21")]
	[AsyncStateMachine(typeof(BKLGAJAPEBG))]
	public Task<int> PDKODGFKFAL(MEINMPIOLGA AGIMJJDFEAF, Guid BIHHICHBGFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8D7AAF0", Offset = "0x8D790F0", VA = "0x188D7AAF0", Slot = "22")]
	public bool KKODDEKNLOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8D78DE0", Offset = "0x8D773E0", VA = "0x188D78DE0", Slot = "23")]
	public bool DBBJAKLJGOB(Guid JJPCOICIDAP, [Out] List<string> BNNJNNBHMLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A920", Offset = "0x8D78F20", VA = "0x188D7A920", Slot = "24")]
	[AsyncStateMachine(typeof(IMEOBMEKAPA))]
	public Task<CKPAOGHIJHA<bool, string>> KEPJHNMCNLI(EHNKJKPGKMF KOFIDNJKFNO, long DBHNNELDOAB, int CJHNGJDMKKM, string ONMCMJBCMNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A150", Offset = "0x8D78750", VA = "0x188D7A150")]
	[AsyncStateMachine(typeof(FFJMHEDPHCE))]
	private Task<CKPAOGHIJHA<bool, string>> HLGEMBCCPED(EHNKJKPGKMF KOFIDNJKFNO, long DBHNNELDOAB, long OFEPOCFLJHI, string ONMCMJBCMNB, int CJHNGJDMKKM = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8D7B830", Offset = "0x8D79E30", VA = "0x188D7B830")]
	[AsyncStateMachine(typeof(ADPIPNINLPF))]
	private Task<BGJMIKEJGNJ> OODNHJILKEI(EHNKJKPGKMF KOFIDNJKFNO, int CJHNGJDMKKM, int DBHNNELDOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8D7B0B0", Offset = "0x8D796B0", VA = "0x188D7B0B0")]
	private bool NNHFOIMICAD(IEnumerable<FCCCHAHAFNG> HDBMFHADOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8D7BCD0", Offset = "0x8D7A2D0", VA = "0x188D7BCD0")]
	private void PPJPOGNPLDN(EHNKJKPGKMF KOFIDNJKFNO, long OFEPOCFLJHI, int CJHNGJDMKKM, string ONMCMJBCMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8D7ACC0", Offset = "0x8D792C0", VA = "0x188D7ACC0")]
	private string MPEBBLFBCKC(EHNKJKPGKMF KOFIDNJKFNO, int CJHNGJDMKKM, string ONMCMJBCMNB, [Optional] CFGNMBFPEFJ? FAKHJBCPGHO, [Optional] DOAPPABLJPK? ABBDLMLCHOO, [Optional] string LMFHLGGKNHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8D79AA0", Offset = "0x8D780A0", VA = "0x188D79AA0")]
	private CFGNMBFPEFJ GIONGCBICIM(EHNKJKPGKMF JDMPBFDGKLN, int OEPCLIMIOPI, [Out] long OFEPOCFLJHI)
	{
		return default(CFGNMBFPEFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A910", Offset = "0x8D78F10", VA = "0x188D7A910", Slot = "29")]
	public void KAFJOHNBCIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A680", Offset = "0x8D78C80", VA = "0x188D7A680")]
	private void JGGAEHPKLGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8D7B590", Offset = "0x8D79B90", VA = "0x188D7B590", Slot = "25")]
	public bool OACOKEICOOM(Guid BIHHICHBGFP, string KPNILIPIDBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8D785D0", Offset = "0x8D76BD0", VA = "0x188D785D0", Slot = "27")]
	public bool BMCOLILGAIM(Guid BIHHICHBGFP, string PCDAGBLEBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8D7AF20", Offset = "0x8D79520", VA = "0x188D7AF20", Slot = "26")]
	public bool NMNJPGHBPFF(Guid BIHHICHBGFP, string LJMPIEHFMNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8D77C20", Offset = "0x8D76220", VA = "0x188D77C20", Slot = "28")]
	public CBCGLEHFFPG ABECOHFFPGP(Guid BIHHICHBGFP, int? HPAGAJBOBCF)
	{
		return default(CBCGLEHFFPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8D7B720", Offset = "0x8D79D20", VA = "0x188D7B720")]
	[AsyncStateMachine(typeof(JDDCOMEEBAL))]
	private Task OIKJCCBJJAG(long DDLHEHAKJGF, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8D77F30", Offset = "0x8D76530", VA = "0x188D77F30")]
	private Task AEFCMLFKPKO(GNGDPEPAGOH PNGANGECEEL, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8D7B410", Offset = "0x8D79A10", VA = "0x188D7B410")]
	[AsyncStateMachine(typeof(OPAOMHBKPOH))]
	private Task NNILIOMGDDL(GNGDPEPAGOH PNGANGECEEL, CancellationToken HIBFLBKIPDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A320", Offset = "0x8D78920", VA = "0x188D7A320")]
	private static Dictionary<Guid, int> IFJKBPIKNCH(IPLCGLKKMAF<List<NACFCFFAAML>> BODGANFFEMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8D799B0", Offset = "0x8D77FB0", VA = "0x188D799B0")]
	private void GDGGOFNNDJK(EHNKJKPGKMF KOFIDNJKFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8D77EC0", Offset = "0x8D764C0", VA = "0x188D77EC0")]
	private void ADBJAPEKIOM(Guid BIHHICHBGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8D7C320", Offset = "0x8D7A920", VA = "0x188D7C320")]
	[FPDADGGBBPP]
	internal void RpcOfferShowPurchasePrompt(Guid BIHHICHBGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8D78320", Offset = "0x8D76920", VA = "0x188D78320")]
	[AsyncStateMachine(typeof(BAFDMIMLOCO))]
	private Task<int> ALMAJLCBJAL(MEINMPIOLGA AGIMJJDFEAF, Guid JJPCOICIDAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8D7C130", Offset = "0x8D7A730", VA = "0x188D7C130")]
	[FPDADGGBBPP]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid KBIKPAMBBCL, Guid BIHHICHBGFP, KFPLHECPDME PCLIBIJEFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8D7C0B0", Offset = "0x8D7A6B0", VA = "0x188D7C0B0")]
	[FPDADGGBBPP]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid KBIKPAMBBCL, int LMJBLNOIBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8D79D60", Offset = "0x8D78360", VA = "0x188D79D60", Slot = "31")]
	public string GNMJJFGPIEF(CFGNMBFPEFJ FAKHJBCPGHO, [Optional] DOAPPABLJPK? BNOIGLABGMP, [Optional] BalanceResponseDTO DLCPCOMDKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8D7ABD0", Offset = "0x8D791D0", VA = "0x188D7ABD0")]
	private static string LNNCCMAIKGD(DOAPPABLJPK BNOIGLABGMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8D78930", Offset = "0x8D76F30", VA = "0x188D78930")]
	private EHNKJKPGKMF CGFABGGCJLB(EHNKJKPGKMF FJBNDOOPLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A2B0", Offset = "0x8D788B0", VA = "0x188D7A2B0")]
	private void HNMOLIADBBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8D791E0", Offset = "0x8D777E0", VA = "0x188D791E0")]
	private void DCLLKKPDCID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class KEBPGGJDEAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Dictionary<Guid, EHNKJKPGKMF> CFAIGLCJBOA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private long DLJLNOEPAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xE15260", Offset = "0xE13860", VA = "0x180E15260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8D77030", Offset = "0x8D75630", VA = "0x188D77030")]
	public void FLAIMHDCCGN(long DDLHEHAKJGF, IEnumerable<EHNKJKPGKMF> PFIKKDNDPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8D773B0", Offset = "0x8D759B0", VA = "0x188D773B0")]
	public bool KFDEOEKEILD(Guid BIHHICHBGFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8D76FD0", Offset = "0x8D755D0", VA = "0x188D76FD0")]
	public bool CBELOMAGFLH(Guid BIHHICHBGFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8D77410", Offset = "0x8D75A10", VA = "0x188D77410")]
	public bool LKAPOLFJNBN(EHNKJKPGKMF EDLFGDNBDEL, [Out] EHNKJKPGKMF KGAANAMLNMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8D77570", Offset = "0x8D75B70", VA = "0x188D77570")]
	public IEnumerable<EHNKJKPGKMF> MBBGNFHNKDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8D772C0", Offset = "0x8D758C0", VA = "0x188D772C0")]
	public bool GFNIFFDKBEC(Guid BIHHICHBGFP, [Out] EHNKJKPGKMF KOFIDNJKFNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8D77330", Offset = "0x8D75930", VA = "0x188D77330")]
	private bool HNANCGAJBEH(EHNKJKPGKMF JCAFAFAHHEP, EHNKJKPGKMF NOHACJENFBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8D775C0", Offset = "0x8D75BC0", VA = "0x188D775C0")]
	public KEBPGGJDEAP()
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
