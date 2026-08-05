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
		[Cpp2IlInjected.Address(RVA = "0x85ACF20", Offset = "0x85ABD20", VA = "0x1885ACF20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GFCPMCHFHGO : IPGBBICMCKM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AIGDCPGLNAM FLOONKPCOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LPNLGKIGLDA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DILPABICAJK IDKIMIMJNIE();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IAJDKPAAJJE : LPNLGKIGLDA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x85AAC80", Offset = "0x85A9A80", VA = "0x1885AAC80")]
	[ENKLKENGHAE.GHBFDECCGMJ.HGNDHHKALNH]
	internal static void BAEPNPABNEB(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IAJDKPAAJJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x85AACF0", Offset = "0x85A9AF0", VA = "0x1885AACF0", Slot = "4")]
	public DILPABICAJK IDKIMIMJNIE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DOEGHAPPEHM]
public class AIGDCPGLNAM : JMPLLGNNMPN, IDisposable, MCNHCPEHJEJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct IMBLHLHHBJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<PKCPMDDLLPP, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AIGDCPGLNAM <>4__this;

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
		public PLJLLNMIBDO roomOfferType;

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
		private TaskAwaiter<HADGKGMEIJF<PKCPMDDLLPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85AADB0", Offset = "0x85A9BB0", VA = "0x1885AADB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85AB2E0", Offset = "0x85AA0E0", VA = "0x1885AB2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct NJHLHAGPIIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<PKCPMDDLLPP, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AIGDCPGLNAM <>4__this;

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
		public PLJLLNMIBDO roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<HADGKGMEIJF<PKCPMDDLLPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85AC320", Offset = "0x85AB120", VA = "0x1885AC320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85AC8C0", Offset = "0x85AB6C0", VA = "0x1885AC8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct JEBAKHCAKDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AIGDCPGLNAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private PKCPMDDLLPP <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<ONAJOACHAJH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85AB350", Offset = "0x85AA150", VA = "0x1885AB350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85AB8B0", Offset = "0x85AA6B0", VA = "0x1885AB8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CENBCNGAOFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<List<PAIDHJNCPFF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AIGDCPGLNAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<HADGKGMEIJF<List<PAIDHJNCPFF>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85A75A0", Offset = "0x85A63A0", VA = "0x1885A75A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85A79A0", Offset = "0x85A67A0", VA = "0x1885A79A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct KJKANDLOKIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AIGDCPGLNAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AHNIMKBJLEJ player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85ABF10", Offset = "0x85AAD10", VA = "0x1885ABF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85AC2B0", Offset = "0x85AB0B0", VA = "0x1885AC2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct HAPHAMOHFEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AIGDCPGLNAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public PKCPMDDLLPP roomOffer;

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
		private TaskAwaiter<JKEBLLKKBOM<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85AA6C0", Offset = "0x85A94C0", VA = "0x1885AA6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85AAC10", Offset = "0x85A9A10", VA = "0x1885AAC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EHNFBEGCILG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AIGDCPGLNAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PKCPMDDLLPP roomOffer;

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
		private IHKKHFBENBM <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private IOABAGGBBCO <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<IOABAGGBBCO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85A8090", Offset = "0x85A6E90", VA = "0x1885A8090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85A89C0", Offset = "0x85A77C0", VA = "0x1885A89C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PNIMHMCKODO
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
			public PNIMHMCKODO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x85ACB40", Offset = "0x85AB940", VA = "0x1885ACB40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x85ACEC0", Offset = "0x85ABCC0", VA = "0x1885ACEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public AIGDCPGLNAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public PNIMHMCKODO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85ACA50", Offset = "0x85AB850", VA = "0x1885ACA50")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task NLBDEGPIMML(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85AC930", Offset = "0x85AB730", VA = "0x1885AC930")]
		internal Guid? NIHODMDPJEJ(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GAIOIKELDPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<IOABAGGBBCO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AIGDCPGLNAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public PKCPMDDLLPP roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private PNIMHMCKODO <>8__1;

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
		private TaskAwaiter<IOABAGGBBCO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x85A9970", Offset = "0x85A8770", VA = "0x1885A9970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x85AA650", Offset = "0x85A9450", VA = "0x1885AA650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct FLBJHALCHCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AIGDCPGLNAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<HADGKGMEIJF<List<AHBLEFDBOLO>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<List<PKCPMDDLLPP>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<HADGKGMEIJF<List<AHBLEFDBOLO>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85A9110", Offset = "0x85A7F10", VA = "0x1885A9110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x85A9910", Offset = "0x85A8710", VA = "0x1885A9910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FDAPOHIGGKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AIGDCPGLNAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x85A8A30", Offset = "0x85A7830", VA = "0x1885A8A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x85A90B0", Offset = "0x85A7EB0", VA = "0x1885A90B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct KGKHMCACIOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AIGDCPGLNAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public AHNIMKBJLEJ player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85AB920", Offset = "0x85AA720", VA = "0x1885AB920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85ABEA0", Offset = "0x85AACA0", VA = "0x1885ABEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan HKHDELGHMDH;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string FAJLFGBAGME = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string KCEFCGMPDMN = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string AJJEDIKKFJN = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CGCNPJINBDG ELNPNBDMPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly ONFJPPIHNJO HCEJNPOEFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly AHHEJMOLFFP IGKNFEPILID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MEHFIDNJION MOANACPPHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly KOOJGNHMNBC FKLMNHDJJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GFCPMCHFHGO DGMELIHEKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly PCIJKDEDJMB LKIBPKBGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly MLBFKJKNKNH IIBMNPHJKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly IFHHEDEDIFI AJBANNJOIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly ADELEBJGBKL MDIFEFFKFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly DILPABICAJK FKAMAHKPCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> DEMJDDFDBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable FIHGJIGJHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task FJKAAJPJHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource BLEFEJPFADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long MKHMNKODPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool EKADHKFOHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly LNMADGNMNID IMFANINLKGI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private BEDAPPGPKDN EDMNNKNAJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85A58B0", Offset = "0x85A46B0", VA = "0x1885A58B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LLEAAEBCCKF PJBDDCMFNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xCFC430", Offset = "0xCFB230", VA = "0x180CFC430", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE8AF40", Offset = "0xE89D40", VA = "0x180E8AF40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IMAAKJGDPMH<PKCPMDDLLPP> HDCPAPNNDAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA0BC20", Offset = "0xA0AA20", VA = "0x180A0BC20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA0BC50", Offset = "0xA0AA50", VA = "0x180A0BC50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IMAAKJGDPMH<Guid> KOKLFFAMHMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD8BC60", Offset = "0xD8AA60", VA = "0x180D8BC60", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xE8DAA0", Offset = "0xE8C8A0", VA = "0x180E8DAA0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x85A2F90", Offset = "0x85A1D90", VA = "0x1885A2F90")]
	[ENKLKENGHAE.GHBFDECCGMJ.HGNDHHKALNH]
	internal static void BAEPNPABNEB(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x85A6E60", Offset = "0x85A5C60", VA = "0x1885A6E60")]
	[RecRoom.NoEngine.Common.Preserve]
	public AIGDCPGLNAM([LCNEJNNIOGA(null)] CGCNPJINBDG ELNPNBDMPCC, [LCNEJNNIOGA(null)] ONFJPPIHNJO HCEJNPOEFBG, [LCNEJNNIOGA(null)] DMPDKJKKDKL JAAILIKGFON, [LCNEJNNIOGA(null)] AHHEJMOLFFP IGKNFEPILID, [LCNEJNNIOGA(null)] LPNLGKIGLDA PMBGDNLNMPP, [LCNEJNNIOGA(null)] MEHFIDNJION MOANACPPHLN, [LCNEJNNIOGA("ShowPurchasePromptRateLimiter")] KOOJGNHMNBC FKLMNHDJJAI, [LCNEJNNIOGA(null)] GFCPMCHFHGO DGMELIHEKAD, [LCNEJNNIOGA(null)] BLCMGFNDLHA LDDEDLMKPMN, [LCNEJNNIOGA(null)] PCIJKDEDJMB LKIBPKBGCOO, [LCNEJNNIOGA(null)] MLBFKJKNKNH IIBMNPHJKHB, [LCNEJNNIOGA(null)] IFHHEDEDIFI AJBANNJOIDD, [LCNEJNNIOGA(null)] ADELEBJGBKL MDIFEFFKFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x85A3800", Offset = "0x85A2600", VA = "0x1885A3800", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x85A4A40", Offset = "0x85A3840", VA = "0x1885A4A40", Slot = "10")]
	[AsyncStateMachine(typeof(IMBLHLHHBJJ))]
	public Task<JKEBLLKKBOM<PKCPMDDLLPP, string>> JCJCLMILIBK(Guid? AGGEDCBPBDE, long CEACGIDOODJ, string IHGFMOMOADA, string CDDMBEEGKND, string DBCDJMCMAJM, int NNBINNDLPGM, PLJLLNMIBDO BGGLOFIJEIA, [Optional] Dictionary<Guid, int> NODKJNGMOOA, [Optional] Guid? DLKBONGECHE, bool KCOAHFLFPNO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x85A4170", Offset = "0x85A2F70", VA = "0x1885A4170", Slot = "11")]
	[AsyncStateMachine(typeof(NJHLHAGPIIP))]
	public Task<JKEBLLKKBOM<PKCPMDDLLPP, string>> FIPOEHKACMO(Guid LDIMDMPDINA, long CEACGIDOODJ, string IHGFMOMOADA, string CDDMBEEGKND, string DBCDJMCMAJM, int NNBINNDLPGM, PLJLLNMIBDO BGGLOFIJEIA, [Optional] Dictionary<Guid, int> NODKJNGMOOA, [Optional] Guid? DLKBONGECHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x85A4450", Offset = "0x85A3250", VA = "0x1885A4450", Slot = "12")]
	[AsyncStateMachine(typeof(JEBAKHCAKDL))]
	public Task<JKEBLLKKBOM<bool, string>> GLFMFOGFOKL(Guid JOPDHEGNJPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x85A3E90", Offset = "0x85A2C90", VA = "0x1885A3E90", Slot = "13")]
	public IEnumerable<PKCPMDDLLPP> ENHBKKCKCLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x85A5780", Offset = "0x85A4580", VA = "0x1885A5780", Slot = "14")]
	[AsyncStateMachine(typeof(CENBCNGAOFB))]
	public Task<List<PAIDHJNCPFF>> MOLBJAPCIMM(long CEACGIDOODJ, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x85A3000", Offset = "0x85A1E00", VA = "0x1885A3000", Slot = "17")]
	public bool BDJLMCBOJFO(Guid JOPDHEGNJPF, int HMMPDLDHHMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x85A4BF0", Offset = "0x85A39F0", VA = "0x1885A4BF0", Slot = "15")]
	public bool JEDPFIPGPMI(Guid JOPDHEGNJPF, [Out] PKCPMDDLLPP GBLFMKKHMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x85A3340", Offset = "0x85A2140", VA = "0x1885A3340", Slot = "16")]
	public bool CPGBKOOBOND(string IHGFMOMOADA, [Out] PKCPMDDLLPP GBLFMKKHMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x85A62E0", Offset = "0x85A50E0", VA = "0x1885A62E0", Slot = "18")]
	public void PMCDNBOEMPN(AHNIMKBJLEJ ENPELEHFGFF, Guid JOPDHEGNJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x85A4310", Offset = "0x85A3110", VA = "0x1885A4310", Slot = "19")]
	[AsyncStateMachine(typeof(KJKANDLOKIO))]
	public Task<int> FNEJCPPJDAH(AHNIMKBJLEJ ENPELEHFGFF, Guid JOPDHEGNJPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x85A4960", Offset = "0x85A3760", VA = "0x1885A4960", Slot = "20")]
	public bool GPCOFMKGLJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x85A3A90", Offset = "0x85A2890", VA = "0x1885A3A90", Slot = "21")]
	public bool ELAAIOABOAK(Guid PPGGGPECKLI, [Out] List<string> LDFPIOMEFDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x85A5270", Offset = "0x85A4070", VA = "0x1885A5270", Slot = "22")]
	[AsyncStateMachine(typeof(HAPHAMOHFEO))]
	public Task<JKEBLLKKBOM<bool, string>> MDKCOHGKCLJ(PKCPMDDLLPP GBLFMKKHMFO, long LNEMGKKPNAE, int CGKKBLKIKKA, string GEDKABEJPIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x85A3F40", Offset = "0x85A2D40", VA = "0x1885A3F40")]
	[AsyncStateMachine(typeof(EHNFBEGCILG))]
	private Task<JKEBLLKKBOM<bool, string>> FCNDOOJMOJE(PKCPMDDLLPP GBLFMKKHMFO, long LNEMGKKPNAE, long BNMMPNPNBBI, string GEDKABEJPIB, int CGKKBLKIKKA = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x85A4E70", Offset = "0x85A3C70", VA = "0x1885A4E70")]
	[AsyncStateMachine(typeof(GAIOIKELDPC))]
	private Task<IOABAGGBBCO> LHFKAHANGMB(PKCPMDDLLPP GBLFMKKHMFO, int CGKKBLKIKKA, int LNEMGKKPNAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x85A5CD0", Offset = "0x85A4AD0", VA = "0x1885A5CD0")]
	private bool NKJFPAIJLLK(IEnumerable<GLNKJILIANA> LDOPKKGHONL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x85A64C0", Offset = "0x85A52C0", VA = "0x1885A64C0")]
	private void PMCOBGOEEJN(PKCPMDDLLPP GBLFMKKHMFO, long BNMMPNPNBBI, int CGKKBLKIKKA, string GEDKABEJPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x85A35A0", Offset = "0x85A23A0", VA = "0x1885A35A0")]
	private string DKPOPADEDNA(PKCPMDDLLPP GBLFMKKHMFO, int CGKKBLKIKKA, string GEDKABEJPIB, [Optional] IHKKHFBENBM? BPINCJLADGC, [Optional] MBILGBFPJKP? NJBLGMHAOEL, [Optional] string FFFKPDADHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x85A4FD0", Offset = "0x85A3DD0", VA = "0x1885A4FD0")]
	private IHKKHFBENBM LPCPEINEGKL(PKCPMDDLLPP ACKNBHMNCOL, int AGCHCGNMPAM, [Out] long BNMMPNPNBBI)
	{
		return default(IHKKHFBENBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x85A60A0", Offset = "0x85A4EA0", VA = "0x1885A60A0")]
	[AsyncStateMachine(typeof(FLBJHALCHCJ))]
	private Task OIMKBMCEIAP(long CEACGIDOODJ, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x85A4570", Offset = "0x85A3370", VA = "0x1885A4570")]
	private Task GMHBDKAOBAC(PCKGILPFDIA AOGFOJGFMAN, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x85A40A0", Offset = "0x85A2EA0", VA = "0x1885A40A0")]
	[AsyncStateMachine(typeof(FDAPOHIGGKK))]
	private Task FFDNKBEMKEO(PCKGILPFDIA AOGFOJGFMAN, CancellationToken GCPHEPCJGLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x85A5900", Offset = "0x85A4700", VA = "0x1885A5900")]
	private static Dictionary<Guid, int> NCILBOMAOFP(HADGKGMEIJF<List<AHBLEFDBOLO>> MPNOJCDCBCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x85A3A80", Offset = "0x85A2880", VA = "0x1885A3A80")]
	private void EFNDHPKAAFB(PKCPMDDLLPP GBLFMKKHMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x85A6030", Offset = "0x85A4E30", VA = "0x1885A6030")]
	private void NOLEJODGNOF(Guid JOPDHEGNJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85A6BF0", Offset = "0x85A59F0", VA = "0x1885A6BF0")]
	[AONLGKBOHJA]
	internal void RpcOfferShowPurchasePrompt(Guid JOPDHEGNJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x85A3200", Offset = "0x85A2000", VA = "0x1885A3200")]
	[AsyncStateMachine(typeof(KGKHMCACIOE))]
	private Task<int> CHDNJPNIAJP(AHNIMKBJLEJ ENPELEHFGFF, Guid PPGGGPECKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x85A6A00", Offset = "0x85A5800", VA = "0x1885A6A00")]
	[AONLGKBOHJA]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid LGNCELEMLNH, Guid JOPDHEGNJPF, BGIPHKOMDPN DOKMLDLFBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x85A6980", Offset = "0x85A5780", VA = "0x1885A6980")]
	[AONLGKBOHJA]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid LGNCELEMLNH, int ALFGNAHPKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x85A53D0", Offset = "0x85A41D0", VA = "0x1885A53D0", Slot = "24")]
	public string MDOKGCGNHIG(IHKKHFBENBM BPINCJLADGC, [Optional] MBILGBFPJKP? PMPCNCOMLDN, [Optional] BalanceResponseDTO BFFACGPGONI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x85A6890", Offset = "0x85A5690", VA = "0x1885A6890")]
	private static string POCNOIBJFKF(MBILGBFPJKP PMPCNCOMLDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x85A4CD0", Offset = "0x85A3AD0", VA = "0x1885A4CD0")]
	private PKCPMDDLLPP LEEPCJEFCGB(PKCPMDDLLPP PDLCIFEIIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x85A5C60", Offset = "0x85A4A60", VA = "0x1885A5C60")]
	private void NKIFGNKLIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x85A61B0", Offset = "0x85A4FB0", VA = "0x1885A61B0")]
	private void PDJDBGMEJCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class DILPABICAJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Guid, PKCPMDDLLPP> EHNDDIAIEKC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long FBNGFADIKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xC82C40", Offset = "0xC81A40", VA = "0x180C82C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x85A7AF0", Offset = "0x85A68F0", VA = "0x1885A7AF0")]
	public void CMDAKLIPNLC(long CEACGIDOODJ, IEnumerable<PKCPMDDLLPP> CPIHABHNFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x85A7A10", Offset = "0x85A6810", VA = "0x1885A7A10")]
	public bool AFFEGPEPGCA(Guid JOPDHEGNJPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x85A7D80", Offset = "0x85A6B80", VA = "0x1885A7D80")]
	public bool FKCGDELNEED(Guid JOPDHEGNJPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x85A7E50", Offset = "0x85A6C50", VA = "0x1885A7E50")]
	public bool KFGPCKCIMHB(PKCPMDDLLPP CMEFMFLALJI, [Out] PKCPMDDLLPP JPPLNFBDJLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x85A7FB0", Offset = "0x85A6DB0", VA = "0x1885A7FB0")]
	public IEnumerable<PKCPMDDLLPP> OJPIGLAONFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x85A7DE0", Offset = "0x85A6BE0", VA = "0x1885A7DE0")]
	public bool JEDPFIPGPMI(Guid JOPDHEGNJPF, [Out] PKCPMDDLLPP GBLFMKKHMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x85A7A70", Offset = "0x85A6870", VA = "0x1885A7A70")]
	private bool CJBCALKKBIO(PKCPMDDLLPP OHCLPCBAJPD, PKCPMDDLLPP JPPNJDBELKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x85A8000", Offset = "0x85A6E00", VA = "0x1885A8000")]
	public DILPABICAJK()
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
