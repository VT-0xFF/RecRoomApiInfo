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
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7495860", Offset = "0x7494C60", VA = "0x187495860", Slot = "8")]
		public override void JFOOIIGPHCJ(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AEFBLFLNFLI : LMNEDKJKJGM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BFBALDJBIOB CINKFOCCAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DBNNAJPECKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OEIHGNMLCLD FJIFIPNCOCP();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PFNFMBBMGBK : DBNNAJPECKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7495410", Offset = "0x7494810", VA = "0x187495410")]
	[OAJAKDHKADM.AEINFAPCLKL.DIAOGFPHJAA]
	internal static void JEDBBFPEMOC(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public PFNFMBBMGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7495350", Offset = "0x7494750", VA = "0x187495350", Slot = "4")]
	public OEIHGNMLCLD FJIFIPNCOCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[JEGDMIPNMMJ]
public class BFBALDJBIOB : IBKEHKEFCHI, IDisposable, LMEGLDECLAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BIDPIGPMFIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<LPJPIDNNHJB, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public BFBALDJBIOB <>4__this;

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
		public CCKIJEALPFA roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<GKFMEIJABLL<LPJPIDNNHJB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x748FFF0", Offset = "0x748F3F0", VA = "0x18748FFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x74904C0", Offset = "0x748F8C0", VA = "0x1874904C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct CFLNNBKOAKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<LPJPIDNNHJB, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public BFBALDJBIOB <>4__this;

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
		public CCKIJEALPFA roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<GKFMEIJABLL<LPJPIDNNHJB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7490530", Offset = "0x748F930", VA = "0x187490530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7490AB0", Offset = "0x748FEB0", VA = "0x187490AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct OAOLKOFDLNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public BFBALDJBIOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private LPJPIDNNHJB <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<KDAPCKACLPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7493F40", Offset = "0x7493340", VA = "0x187493F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7494480", Offset = "0x7493880", VA = "0x187494480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GFHAKDPOPEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<List<KMNKJEHLBAA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public BFBALDJBIOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<GKFMEIJABLL<List<KMNKJEHLBAA>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7491B90", Offset = "0x7490F90", VA = "0x187491B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7491F90", Offset = "0x7491390", VA = "0x187491F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct MLJEEPMFEAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public BFBALDJBIOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public JDJLHJHOJPN player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7493B30", Offset = "0x7492F30", VA = "0x187493B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7493ED0", Offset = "0x74932D0", VA = "0x187493ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct HJMMHMOFPCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public BFBALDJBIOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public LPJPIDNNHJB roomOffer;

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
		private TaskAwaiter<LMFFMMPMNDB<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7492000", Offset = "0x7491400", VA = "0x187492000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7492550", Offset = "0x7491950", VA = "0x187492550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FNGMFIONEAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public BFBALDJBIOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public LPJPIDNNHJB roomOffer;

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
		private GLPHJBNGACD <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private IFALGHEJGMK <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<IFALGHEJGMK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x74911F0", Offset = "0x74905F0", VA = "0x1874911F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7491B20", Offset = "0x7490F20", VA = "0x187491B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class OBBAIHCINFD
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
			public OBBAIHCINFD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7495480", Offset = "0x7494880", VA = "0x187495480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7495800", Offset = "0x7494C00", VA = "0x187495800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public BFBALDJBIOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public OBBAIHCINFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x74944F0", Offset = "0x74938F0", VA = "0x1874944F0")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task ACHIHEIBAKB(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x74945E0", Offset = "0x74939E0", VA = "0x1874945E0")]
		internal Guid? IDGEIHPMJOD(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct LNCPPCNGLAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<IFALGHEJGMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public BFBALDJBIOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public LPJPIDNNHJB roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private OBBAIHCINFD <>8__1;

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
		private TaskAwaiter<IFALGHEJGMK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7492E10", Offset = "0x7492210", VA = "0x187492E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7493AC0", Offset = "0x7492EC0", VA = "0x187493AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JKBINAKLCKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public BFBALDJBIOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private Task<GKFMEIJABLL<List<CFOKPMGPIEO>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<List<LPJPIDNNHJB>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<GKFMEIJABLL<List<CFOKPMGPIEO>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x74925C0", Offset = "0x74919C0", VA = "0x1874925C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7492DB0", Offset = "0x74921B0", VA = "0x187492DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FEJBNMIAMGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public BFBALDJBIOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7490B20", Offset = "0x748FF20", VA = "0x187490B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7491190", Offset = "0x7490590", VA = "0x187491190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct OIFPICCOFLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public BFBALDJBIOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public JDJLHJHOJPN player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7494D70", Offset = "0x7494170", VA = "0x187494D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x74952E0", Offset = "0x74946E0", VA = "0x1874952E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan HIPIAGIJKJK;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string MBOAKBBPAIJ = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string IKGHNIEMCGF = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string AALHPCNNHCN = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HAPDDFOIPMK JBJNHHOMCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly CDOIIJHIKJB PHBCAIBOONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly LHCEGCIHNFJ LHFIAJCMKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly GCDLIECIJNL LKEOMLAGJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly AMJGCABCMKH HAPNBEDGPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly AEFBLFLNFLI BCAJJGKGKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly NFLKMDJAPKM BLDEOEOIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly BLKCNFAPLAO LOLJAKNNDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly OHMOLNDPOPP KJNMNCAEFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly EMIKPOFNKEE NONJFGLABPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly OEIHGNMLCLD PPMDCMLEJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> JPBEDPAOEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable DAGBHHPHAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task CMNMHLFEGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource EELFJIPOIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long EFABIEDDALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool INBIMOFIBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly FIBPNBALLDA IGCIBFJOHDH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private OCHLGIKPKCK PGDECBOFFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x748F130", Offset = "0x748E530", VA = "0x18748F130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LDNMACGBDLI IHNGPJJKMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9B5880", Offset = "0x9B4C80", VA = "0x1809B5880", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B0D00", Offset = "0x9B0100", VA = "0x1809B0D00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public PJFDJKKNHLD<LPJPIDNNHJB> LNEGAOPFBNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8B2320", Offset = "0x8B1720", VA = "0x1808B2320", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8B2360", Offset = "0x8B1760", VA = "0x1808B2360", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public PJFDJKKNHLD<Guid> NNDCHJCMPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9258E0", Offset = "0x924CE0", VA = "0x1809258E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9B5420", Offset = "0x9B4820", VA = "0x1809B5420", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x748E4E0", Offset = "0x748D8E0", VA = "0x18748E4E0")]
	[OAJAKDHKADM.AEINFAPCLKL.DIAOGFPHJAA]
	internal static void JEDBBFPEMOC(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x748F8D0", Offset = "0x748ECD0", VA = "0x18748F8D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BFBALDJBIOB([CCLHMIDBCEM(null)] HAPDDFOIPMK JBJNHHOMCJE, [CCLHMIDBCEM(null)] CDOIIJHIKJB PHBCAIBOONK, [CCLHMIDBCEM(null)] AACPFFJDDDA FBIKKAJLDAK, [CCLHMIDBCEM(null)] LHCEGCIHNFJ LHFIAJCMKMI, [CCLHMIDBCEM(null)] DBNNAJPECKJ AEKHBCHGIKC, [CCLHMIDBCEM(null)] GCDLIECIJNL LKEOMLAGJMG, [CCLHMIDBCEM("ShowPurchasePromptRateLimiter")] AMJGCABCMKH HAPNBEDGPPL, [CCLHMIDBCEM(null)] AEFBLFLNFLI BCAJJGKGKBB, [CCLHMIDBCEM(null)] IEIPOIIILBP MCKEFIPBLFK, [CCLHMIDBCEM(null)] NFLKMDJAPKM BLDEOEOIGBD, [CCLHMIDBCEM(null)] BLKCNFAPLAO LOLJAKNNDKE, [CCLHMIDBCEM(null)] OHMOLNDPOPP KJNMNCAEFCB, [CCLHMIDBCEM(null)] EMIKPOFNKEE NONJFGLABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x748CDC0", Offset = "0x748C1C0", VA = "0x18748CDC0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x748E550", Offset = "0x748D950", VA = "0x18748E550", Slot = "10")]
	[AsyncStateMachine(typeof(BIDPIGPMFIL))]
	public Task<LMFFMMPMNDB<LPJPIDNNHJB, string>> LEAOCPPKMIM(long FJBFONPAOAD, string DDDHPCNFCEK, string BCAMDINMAHA, string DBALDCNBIMF, int GIMEHEPKKIE, CCKIJEALPFA GOLCDNNNGCF, [Optional] Dictionary<Guid, int> MIODJLDGGFB, [Optional] Guid? ILJCELOKLEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x748D7F0", Offset = "0x748CBF0", VA = "0x18748D7F0", Slot = "11")]
	[AsyncStateMachine(typeof(CFLNNBKOAKK))]
	public Task<LMFFMMPMNDB<LPJPIDNNHJB, string>> GLGHCOEIDOI(Guid PCDMEBECPGE, string DDDHPCNFCEK, string BCAMDINMAHA, string DBALDCNBIMF, int GIMEHEPKKIE, CCKIJEALPFA GOLCDNNNGCF, [Optional] Dictionary<Guid, int> MIODJLDGGFB, [Optional] Guid? ILJCELOKLEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x748E130", Offset = "0x748D530", VA = "0x18748E130", Slot = "12")]
	[AsyncStateMachine(typeof(OAOLKOFDLNB))]
	public Task<LMFFMMPMNDB<bool, string>> HJPHDINKHAL(Guid PCDMEBECPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x748C860", Offset = "0x748BC60", VA = "0x18748C860", Slot = "13")]
	public IEnumerable<LPJPIDNNHJB> CKNIDGHPLJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x748E970", Offset = "0x748DD70", VA = "0x18748E970", Slot = "14")]
	[AsyncStateMachine(typeof(GFHAKDPOPEO))]
	public Task<List<KMNKJEHLBAA>> MMIMHBIPBEI(long FJBFONPAOAD, [Optional] CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x748F200", Offset = "0x748E600", VA = "0x18748F200", Slot = "16")]
	public bool PPOKDNGJICM(Guid PCDMEBECPGE, int CPHJNCJLNCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x748D3D0", Offset = "0x748C7D0", VA = "0x18748D3D0", Slot = "15")]
	public bool FKOHMKBAKEJ(Guid PCDMEBECPGE, [Out] LPJPIDNNHJB BEENNNIJNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x748D4B0", Offset = "0x748C8B0", VA = "0x18748D4B0", Slot = "17")]
	public void FNHCGPOPDHN(JDJLHJHOJPN PEIJBHPINLD, Guid PCDMEBECPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x748DFF0", Offset = "0x748D3F0", VA = "0x18748DFF0", Slot = "18")]
	[AsyncStateMachine(typeof(MLJEEPMFEAC))]
	public Task<int> GNKGBCKAGNG(JDJLHJHOJPN PEIJBHPINLD, Guid PCDMEBECPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x748EAA0", Offset = "0x748DEA0", VA = "0x18748EAA0", Slot = "19")]
	public bool NCGPALEBJNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x748C290", Offset = "0x748B690", VA = "0x18748C290", Slot = "20")]
	public bool AOJDENGEOBM(Guid DIDFLDPPBOO, [Out] List<string> LGAFMEOGFEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x748C690", Offset = "0x748BA90", VA = "0x18748C690", Slot = "21")]
	[AsyncStateMachine(typeof(HJMMHMOFPCG))]
	public Task<LMFFMMPMNDB<bool, string>> CAGBHJELIML(LPJPIDNNHJB BEENNNIJNFD, long ECGCPDICMDG, int HBPMKNLKLPD, string AHOOEEOGGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x748D690", Offset = "0x748CA90", VA = "0x18748D690")]
	[AsyncStateMachine(typeof(FNGMFIONEAE))]
	private Task<LMFFMMPMNDB<bool, string>> GAGAIMEHFKE(LPJPIDNNHJB BEENNNIJNFD, long ECGCPDICMDG, long DDDNLCDIBPP, string AHOOEEOGGAJ, int HBPMKNLKLPD = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x748E250", Offset = "0x748D650", VA = "0x18748E250")]
	[AsyncStateMachine(typeof(LNCPPCNGLAD))]
	private Task<IFALGHEJGMK> IDEDPPAIHFE(LPJPIDNNHJB BEENNNIJNFD, int HBPMKNLKLPD, int ECGCPDICMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x748BCE0", Offset = "0x748B0E0", VA = "0x18748BCE0")]
	private bool ADJDJEAFKNM(IEnumerable<GIMOEJECHGD> HEOHHFPHKHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x748D980", Offset = "0x748CD80", VA = "0x18748D980")]
	private void GLOIHGGHNFN(LPJPIDNNHJB BEENNNIJNFD, long DDDNLCDIBPP, int HBPMKNLKLPD, string AHOOEEOGGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x748C040", Offset = "0x748B440", VA = "0x18748C040")]
	private string ANMDPNMKMLN(LPJPIDNNHJB BEENNNIJNFD, int HBPMKNLKLPD, string AHOOEEOGGAJ, [Optional] GLPHJBNGACD? IPNDOKDOGDG, [Optional] FDFDLNPBFGC? FOJIANJMEFD, [Optional] string BCLMEBDGMFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x748DD50", Offset = "0x748D150", VA = "0x18748DD50")]
	private GLPHJBNGACD GMIMNOADJGK(LPJPIDNNHJB KPJNPMPFGDL, int BJHCBBEMIDM, [Out] long DDDNLCDIBPP)
	{
		return default(GLPHJBNGACD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x748F020", Offset = "0x748E420", VA = "0x18748F020")]
	[AsyncStateMachine(typeof(JKBINAKLCKH))]
	private Task OFCHOALJICA(long FJBFONPAOAD, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x748C910", Offset = "0x748BD10", VA = "0x18748C910")]
	private Task DCNGPNHNDCO(LMMLJLDDCAM CJLBFJEOAOD, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x748CCF0", Offset = "0x748C0F0", VA = "0x18748CCF0")]
	[AsyncStateMachine(typeof(FEJBNMIAMGM))]
	private Task DLEEAOJHOAF(LMMLJLDDCAM CJLBFJEOAOD, CancellationToken GFIAMKNOHCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x748ECC0", Offset = "0x748E0C0", VA = "0x18748ECC0")]
	private static Dictionary<Guid, int> NPMLIAMDBPE(GKFMEIJABLL<List<CFOKPMGPIEO>> DHECMAHNPJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x748F180", Offset = "0x748E580", VA = "0x18748F180")]
	private void PDLKCFMDBBG(LPJPIDNNHJB BEENNNIJNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x748F190", Offset = "0x748E590", VA = "0x18748F190")]
	private void PEIIJFEOILA(Guid PCDMEBECPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x748F670", Offset = "0x748EA70", VA = "0x18748F670")]
	[POEDOHOIOKH]
	internal void RpcOfferShowPurchasePrompt(Guid PCDMEBECPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x748EB80", Offset = "0x748DF80", VA = "0x18748EB80")]
	[AsyncStateMachine(typeof(OIFPICCOFLK))]
	private Task<int> NNEEKKPEJPP(JDJLHJHOJPN PEIJBHPINLD, Guid DIDFLDPPBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x748F480", Offset = "0x748E880", VA = "0x18748F480")]
	[POEDOHOIOKH]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid NEMMHGGPCGF, Guid PCDMEBECPGE, CBNOCKCJJNP KLONIJLMOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x748F400", Offset = "0x748E800", VA = "0x18748F400")]
	[POEDOHOIOKH]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid NEMMHGGPCGF, int HMELIAGANNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x748D020", Offset = "0x748C420", VA = "0x18748D020", Slot = "23")]
	public string FIIOHAAOHKH(GLPHJBNGACD IPNDOKDOGDG, [Optional] FDFDLNPBFGC? MOMEOGHKODC, [Optional] BalanceResponseDTO NOIDIMBOGFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x748E6E0", Offset = "0x748DAE0", VA = "0x18748E6E0")]
	private static string LMEMNMCGFHP(FDFDLNPBFGC MOMEOGHKODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x748E7D0", Offset = "0x748DBD0", VA = "0x18748E7D0")]
	private LPJPIDNNHJB MJCBHNPGDNM(LPJPIDNNHJB CJHDDFPEFOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x748C7F0", Offset = "0x748BBF0", VA = "0x18748C7F0")]
	private void CGPGPMEPPCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x748E3B0", Offset = "0x748D7B0", VA = "0x18748E3B0")]
	private void IMMONENPPEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class OEIHGNMLCLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Dictionary<Guid, LPJPIDNNHJB> OJLLLCEEJNF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long LMAPJLOLJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x13315A0", Offset = "0x13309A0", VA = "0x1813315A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x74949B0", Offset = "0x7493DB0", VA = "0x1874949B0")]
	public void FKPLOCFMGHI(long FJBFONPAOAD, IEnumerable<LPJPIDNNHJB> EGDLKBEFKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7494C30", Offset = "0x7494030", VA = "0x187494C30")]
	public bool IAIHPKLBHPK(Guid PCDMEBECPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7494780", Offset = "0x7493B80", VA = "0x187494780")]
	public bool BJFEGIDGDBE(Guid PCDMEBECPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x74947E0", Offset = "0x7493BE0", VA = "0x1874947E0")]
	public bool DJMJIJLJEFO(LPJPIDNNHJB EHLLKDIJIII, [Out] LPJPIDNNHJB BGGAOHBALJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7494C90", Offset = "0x7494090", VA = "0x187494C90")]
	public IEnumerable<LPJPIDNNHJB> NJCDJOCNGGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7494940", Offset = "0x7493D40", VA = "0x187494940")]
	public bool FKOHMKBAKEJ(Guid PCDMEBECPGE, [Out] LPJPIDNNHJB BEENNNIJNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7494700", Offset = "0x7493B00", VA = "0x187494700")]
	private bool BHCLIDCPBND(LPJPIDNNHJB JFKJABAPEAB, LPJPIDNNHJB CNIECMCKMEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7494CE0", Offset = "0x74940E0", VA = "0x187494CE0")]
	public OEIHGNMLCLD()
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
