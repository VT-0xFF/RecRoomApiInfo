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
		[Cpp2IlInjected.Address(RVA = "0x7323210", Offset = "0x7321E10", VA = "0x187323210", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LPIHEGGNBAI : GFBEMDKFOLP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DJHGMMMDEBA FKALAKOELKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DMCGOOIHJBN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JICBMHLPONA IAHCEMKIPJI();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GGKLEOAPJJC : DMCGOOIHJBN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x731ED80", Offset = "0x731D980", VA = "0x18731ED80")]
	[BOLBLOCFHKO.MMCPHMPAJDJ.PLMBBLHFMHB]
	internal static void PKCPHNKIBBJ(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GGKLEOAPJJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x731ECC0", Offset = "0x731D8C0", VA = "0x18731ECC0", Slot = "4")]
	public JICBMHLPONA IAHCEMKIPJI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CGPAMFEMIJK]
public class DJHGMMMDEBA : MBGOLNCIHIN, IDisposable, BEGBLAKACLK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct OCMPDECLCAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<DMHOMPGIOPJ, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public DJHGMMMDEBA <>4__this;

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
		public POJADMGAPEC roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<PEFBPCJCANN<DMHOMPGIOPJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7321EF0", Offset = "0x7320AF0", VA = "0x187321EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x73223C0", Offset = "0x7320FC0", VA = "0x1873223C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct EPHOLIKMDHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<DMHOMPGIOPJ, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public DJHGMMMDEBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public Guid roomOfferOriginId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public POJADMGAPEC roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<PEFBPCJCANN<DMHOMPGIOPJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x731E6B0", Offset = "0x731D2B0", VA = "0x18731E6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x731EC50", Offset = "0x731D850", VA = "0x18731EC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BLPPCIHPDJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public DJHGMMMDEBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private DMHOMPGIOPJ <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter<LHJKNJFEIAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7319940", Offset = "0x7318540", VA = "0x187319940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7319EA0", Offset = "0x7318AA0", VA = "0x187319EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct KCNGCBENJEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder<List<CLJFMAKLFGN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public DJHGMMMDEBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<PEFBPCJCANN<List<CLJFMAKLFGN>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7321A80", Offset = "0x7320680", VA = "0x187321A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7321E80", Offset = "0x7320A80", VA = "0x187321E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct OKLCABHAFJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public DJHGMMMDEBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public JNNGHBDDOHB player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7322430", Offset = "0x7321030", VA = "0x187322430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x73227D0", Offset = "0x73213D0", VA = "0x1873227D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct BHCJEIKLPDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public DJHGMMMDEBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public DMHOMPGIOPJ roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public string purchaseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<OAMIPODNNBO<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7319380", Offset = "0x7317F80", VA = "0x187319380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x73198D0", Offset = "0x73184D0", VA = "0x1873198D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JODADCGINGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<OAMIPODNNBO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public DJHGMMMDEBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public DMHOMPGIOPJ roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public string purchaseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public long initialBalance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private FPEHGNBDDAL <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private DPLDKLFOLPJ <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<DPLDKLFOLPJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x73210E0", Offset = "0x731FCE0", VA = "0x1873210E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7321A10", Offset = "0x7320610", VA = "0x187321A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class DPJMIAEMDEC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private struct <<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public DPJMIAEMDEC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7322E30", Offset = "0x7321A30", VA = "0x187322E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x73231B0", Offset = "0x7321DB0", VA = "0x1873231B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public DJHGMMMDEBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public DPJMIAEMDEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x731E5C0", Offset = "0x731D1C0", VA = "0x18731E5C0")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task LLHIMBHPJJM(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x731E4A0", Offset = "0x731D0A0", VA = "0x18731E4A0")]
		internal Guid? DDBNMLOHOIN(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct JNEPKCNPKHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<DPLDKLFOLPJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public DJHGMMMDEBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public DMHOMPGIOPJ roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private DPJMIAEMDEC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private Dictionary<Guid, Guid?> <concurrencyCodeByItemIdMap>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private Guid <itemId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<DPLDKLFOLPJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7320390", Offset = "0x731EF90", VA = "0x187320390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7321070", Offset = "0x731FC70", VA = "0x187321070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JABLNJCPIOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public DJHGMMMDEBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private Task<PEFBPCJCANN<List<OLIJKJDNOAD>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<List<DMHOMPGIOPJ>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter<PEFBPCJCANN<List<OLIJKJDNOAD>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x731F4C0", Offset = "0x731E0C0", VA = "0x18731F4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x731FCB0", Offset = "0x731E8B0", VA = "0x18731FCB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct HOCIBGHLACM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public DJHGMMMDEBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x731EDF0", Offset = "0x731D9F0", VA = "0x18731EDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x731F460", Offset = "0x731E060", VA = "0x18731F460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct PBANNKJIAOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public DJHGMMMDEBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public JNNGHBDDOHB player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7322840", Offset = "0x7321440", VA = "0x187322840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7322DC0", Offset = "0x73219C0", VA = "0x187322DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan KHFIHBACMHD;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string BJGFOCHCKPB = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string AOFMMOKFBBN = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string CGDLNDHGJJP = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IKKAHJJJDCG MCJBLJKJOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DFNBAPCAPEA CFKMNEABMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly IOKOPGFNFBN FNCJFJENOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly OAJBCHCNOFD CEDBELBCGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly FNGKILJBOOA FPPFHHOODOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LPIHEGGNBAI OFFFPKALBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly OKNODDEMBNA CPKOIOKIGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly PDCAHALDPFC MKLMPFHGOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly EMIKLMNHPKL AGGOAHHCNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly ILCELNBOEME JBLNJDLFMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly JICBMHLPONA FALCFKFBLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> HPGKIPLAOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable HONCELPGNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task NAIMFBMHOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource KCHNGCKJDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long EJKGHHDFKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool HINLMPLCGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly PBOEONFNOEJ EGKPLPLIOLB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private DCPNNFJECLK MFFENPCBDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x731D460", Offset = "0x731C060", VA = "0x18731D460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DBHLBOFDKDO APGINJEDNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x94DF30", Offset = "0x94CB30", VA = "0x18094DF30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDD0", Offset = "0xD0E9D0", VA = "0x180D0FDD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CBECGFLMOCG<DMHOMPGIOPJ> ECPLBOCNAAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8963B0", Offset = "0x894FB0", VA = "0x1808963B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x896370", Offset = "0x894F70", VA = "0x180896370", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CBECGFLMOCG<Guid> HEEKNNOAPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA4D290", Offset = "0xA4BE90", VA = "0x180A4D290", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xBE9840", Offset = "0xBE8440", VA = "0x180BE9840", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x731D820", Offset = "0x731C420", VA = "0x18731D820")]
	[BOLBLOCFHKO.MMCPHMPAJDJ.PLMBBLHFMHB]
	internal static void PKCPHNKIBBJ(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x731DD80", Offset = "0x731C980", VA = "0x18731DD80")]
	[RecRoom.NoEngine.Common.Preserve]
	public DJHGMMMDEBA([JGAMIMHCGFI(null)] IKKAHJJJDCG MCJBLJKJOCH, [JGAMIMHCGFI(null)] DFNBAPCAPEA CFKMNEABMKL, [JGAMIMHCGFI(null)] POEFAGDFHGA OKHLKCKKIOH, [JGAMIMHCGFI(null)] IOKOPGFNFBN FNCJFJENOAM, [JGAMIMHCGFI(null)] DMCGOOIHJBN NMPGJBAMOIB, [JGAMIMHCGFI(null)] OAJBCHCNOFD CEDBELBCGGO, [JGAMIMHCGFI("ShowPurchasePromptRateLimiter")] FNGKILJBOOA FPPFHHOODOM, [JGAMIMHCGFI(null)] LPIHEGGNBAI OFFFPKALBLD, [JGAMIMHCGFI(null)] AAMDFIOALIP FHEHEKFBGJK, [JGAMIMHCGFI(null)] OKNODDEMBNA CPKOIOKIGEH, [JGAMIMHCGFI(null)] PDCAHALDPFC MKLMPFHGOGH, [JGAMIMHCGFI(null)] EMIKLMNHPKL AGGOAHHCNOO, [JGAMIMHCGFI(null)] ILCELNBOEME JBLNJDLFMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x731AF20", Offset = "0x7319B20", VA = "0x18731AF20", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x731AD90", Offset = "0x7319990", VA = "0x18731AD90", Slot = "10")]
	[AsyncStateMachine(typeof(OCMPDECLCAO))]
	public Task<OAMIPODNNBO<DMHOMPGIOPJ, string>> DNHPFBDLJIA(long GLOFJPFEAOO, string GMBAACDNNFI, string FAAMMCFGOAB, string NMALPFABKBF, int DKOPHAJPMLH, POJADMGAPEC ODKOKKBELFK, [Optional] Dictionary<Guid, int> LAOODCFCOFN, [Optional] Guid? PHOFMFODAMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x731D590", Offset = "0x731C190", VA = "0x18731D590", Slot = "11")]
	[AsyncStateMachine(typeof(EPHOLIKMDHF))]
	public Task<OAMIPODNNBO<DMHOMPGIOPJ, string>> OLBFPDPOANB(Guid NBFKLOLEODF, long GLOFJPFEAOO, string GMBAACDNNFI, string FAAMMCFGOAB, string NMALPFABKBF, int DKOPHAJPMLH, POJADMGAPEC ODKOKKBELFK, [Optional] Dictionary<Guid, int> LAOODCFCOFN, [Optional] Guid? PHOFMFODAMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x731A3D0", Offset = "0x7318FD0", VA = "0x18731A3D0", Slot = "12")]
	[AsyncStateMachine(typeof(BLPPCIHPDJL))]
	public Task<OAMIPODNNBO<bool, string>> BPIOCECBNPJ(Guid KAKDGOHNIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x731D3B0", Offset = "0x731BFB0", VA = "0x18731D3B0", Slot = "13")]
	public IEnumerable<DMHOMPGIOPJ> NDOCPJIKJEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x731D0A0", Offset = "0x731BCA0", VA = "0x18731D0A0", Slot = "14")]
	[AsyncStateMachine(typeof(KCNGCBENJEK))]
	public Task<List<CLJFMAKLFGN>> MNNMKFLGFPK(long GLOFJPFEAOO, [Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x731B640", Offset = "0x731A240", VA = "0x18731B640", Slot = "17")]
	public bool ENHLJIBIDEB(Guid KAKDGOHNIOK, int GAGAOHMMCLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x731B180", Offset = "0x7319D80", VA = "0x18731B180", Slot = "15")]
	public bool EGALPLGALGO(Guid KAKDGOHNIOK, [Out] DMHOMPGIOPJ DLEKODPPHKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x731C910", Offset = "0x731B510", VA = "0x18731C910", Slot = "16")]
	public bool MEEOGOJDGJE(string GMBAACDNNFI, [Out] DMHOMPGIOPJ DLEKODPPHKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x731D1D0", Offset = "0x731BDD0", VA = "0x18731D1D0", Slot = "18")]
	public void NCFPMCJALNA(JNNGHBDDOHB PMNDEDNNDFE, Guid KAKDGOHNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x731C190", Offset = "0x731AD90", VA = "0x18731C190", Slot = "19")]
	[AsyncStateMachine(typeof(OKLCABHAFJC))]
	public Task<int> JMIMMHFEKBI(JNNGHBDDOHB PMNDEDNNDFE, Guid KAKDGOHNIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x731D4B0", Offset = "0x731C0B0", VA = "0x18731D4B0", Slot = "20")]
	public bool OINJDAHCCJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x731A850", Offset = "0x7319450", VA = "0x18731A850", Slot = "21")]
	public bool DFGFKPKKAHH(Guid PDIOMJEIHHB, [Out] List<string> MGKNFBNNCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x731CF40", Offset = "0x731BB40", VA = "0x18731CF40", Slot = "22")]
	[AsyncStateMachine(typeof(BHCJEIKLPDP))]
	public Task<OAMIPODNNBO<bool, string>> MNHIIBAIALO(DMHOMPGIOPJ DLEKODPPHKM, long AJBADANCAAH, int IFODNKOJDJK, string DAJBGEMDIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x731A270", Offset = "0x7318E70", VA = "0x18731A270")]
	[AsyncStateMachine(typeof(JODADCGINGM))]
	private Task<OAMIPODNNBO<bool, string>> BDCFKINGFFK(DMHOMPGIOPJ DLEKODPPHKM, long AJBADANCAAH, long ODGAOOPJGNN, string DAJBGEMDIGD, int IFODNKOJDJK = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x731BC80", Offset = "0x731A880", VA = "0x18731BC80")]
	[AsyncStateMachine(typeof(JNEPKCNPKHD))]
	private Task<DPLDKLFOLPJ> GOCBJGMCPEK(DMHOMPGIOPJ DLEKODPPHKM, int IFODNKOJDJK, int AJBADANCAAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x731A4F0", Offset = "0x73190F0", VA = "0x18731A4F0")]
	private bool CIACBLBGABB(IEnumerable<CKGNJLBGENM> JODLGECKBCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x731B8B0", Offset = "0x731A4B0", VA = "0x18731B8B0")]
	private void FJBJEKHPKMC(DMHOMPGIOPJ DLEKODPPHKM, long ODGAOOPJGNN, int IFODNKOJDJK, string DAJBGEMDIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x731C410", Offset = "0x731B010", VA = "0x18731C410")]
	private string KIEOGKCGEIM(DMHOMPGIOPJ DLEKODPPHKM, int IFODNKOJDJK, string DAJBGEMDIGD, [Optional] FPEHGNBDDAL? CMNKPAFMHMO, [Optional] JBGKINFIKFJ? IBICPJKHBPL, [Optional] string OIHPLAMNMLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x731CCA0", Offset = "0x731B8A0", VA = "0x18731CCA0")]
	private FPEHGNBDDAL MMAFLDBDJDM(DMHOMPGIOPJ DCBEJOBDFBF, int JDLGKABEFLC, [Out] long ODGAOOPJGNN)
	{
		return default(FPEHGNBDDAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x731C800", Offset = "0x731B400", VA = "0x18731C800")]
	[AsyncStateMachine(typeof(JABLNJCPIOJ))]
	private Task LNOHCKOHIPG(long GLOFJPFEAOO, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x731B260", Offset = "0x7319E60", VA = "0x18731B260")]
	private Task ELPBMGJFLJL(BEHJNDNGPEO JIAHCJFCHOA, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x731ACC0", Offset = "0x73198C0", VA = "0x18731ACC0")]
	[AsyncStateMachine(typeof(HOCIBGHLACM))]
	private Task DLPEAPIILLK(BEHJNDNGPEO JIAHCJFCHOA, CancellationToken DACONLPKGDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7319F10", Offset = "0x7318B10", VA = "0x187319F10")]
	private static Dictionary<Guid, int> BBGNBAFNNED(PEFBPCJCANN<List<OLIJKJDNOAD>> OBOODDJFNKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x731D890", Offset = "0x731C490", VA = "0x18731D890")]
	private void PKMKPFCFEHJ(DMHOMPGIOPJ DLEKODPPHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x731B840", Offset = "0x731A440", VA = "0x18731B840")]
	private void FCKALFBFGLF(Guid KAKDGOHNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x731DB10", Offset = "0x731C710", VA = "0x18731DB10")]
	[HHCFGMEDGPD]
	internal void RpcOfferShowPurchasePrompt(Guid KAKDGOHNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x731C2D0", Offset = "0x731AED0", VA = "0x18731C2D0")]
	[AsyncStateMachine(typeof(PBANNKJIAOD))]
	private Task<int> KCJGNICAJME(JNNGHBDDOHB PMNDEDNNDFE, Guid PDIOMJEIHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x731D920", Offset = "0x731C520", VA = "0x18731D920")]
	[HHCFGMEDGPD]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid AECBMPLKMNA, Guid KAKDGOHNIOK, JPMKPDAKHJD ODPJPJLEOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x731D8A0", Offset = "0x731C4A0", VA = "0x18731D8A0")]
	[HHCFGMEDGPD]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid AECBMPLKMNA, int KNHHBEFLJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x731BDE0", Offset = "0x731A9E0", VA = "0x18731BDE0", Slot = "24")]
	public string HCKPBMHCNMK(FPEHGNBDDAL CMNKPAFMHMO, [Optional] JBGKINFIKFJ? JMHNHPNLJDI, [Optional] BalanceResponseDTO BBMMAOKNMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x731D730", Offset = "0x731C330", VA = "0x18731D730")]
	private static string PGJMFMPMACN(JBGKINFIKFJ JMHNHPNLJDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x731C660", Offset = "0x731B260", VA = "0x18731C660")]
	private DMHOMPGIOPJ KIGEMOHDNGI(DMHOMPGIOPJ IFGHOPNHDJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x731AC50", Offset = "0x7319850", VA = "0x18731AC50")]
	private void DIBBPACCPKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x731CB70", Offset = "0x731B770", VA = "0x18731CB70")]
	private void MJNFANJMFDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class JICBMHLPONA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly Dictionary<Guid, DMHOMPGIOPJ> FAJPBGGJLEJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long IGGPMOFIGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x121C1D0", Offset = "0x121ADD0", VA = "0x18121C1D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x731FD70", Offset = "0x731E970", VA = "0x18731FD70")]
	public void ECCALNHNLIB(long GLOFJPFEAOO, IEnumerable<DMHOMPGIOPJ> MBOJMEEKDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7320070", Offset = "0x731EC70", VA = "0x187320070")]
	public bool EOBEIPPMNDK(Guid KAKDGOHNIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x731FD10", Offset = "0x731E910", VA = "0x18731FD10")]
	public bool CEFMELNJEMA(Guid KAKDGOHNIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7320120", Offset = "0x731ED20", VA = "0x187320120")]
	public bool FICILLLMFJD(DMHOMPGIOPJ BNOLNICPPLA, [Out] DMHOMPGIOPJ HEECFJBCPDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x73200D0", Offset = "0x731ECD0", VA = "0x1873200D0")]
	public IEnumerable<DMHOMPGIOPJ> FDOLBNFGKGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7320000", Offset = "0x731EC00", VA = "0x187320000")]
	public bool EGALPLGALGO(Guid KAKDGOHNIOK, [Out] DMHOMPGIOPJ DLEKODPPHKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7320280", Offset = "0x731EE80", VA = "0x187320280")]
	private bool MCJEOGGGPNG(DMHOMPGIOPJ NJDPFLEAPBF, DMHOMPGIOPJ DHDEAMIFJGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7320300", Offset = "0x731EF00", VA = "0x187320300")]
	public JICBMHLPONA()
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
