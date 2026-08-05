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
		[Cpp2IlInjected.Address(RVA = "0x76F9210", Offset = "0x76F8610", VA = "0x1876F9210", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IFDKLFIMJPM : OFONGCEKHGA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HALCMDIMGGP KMJFIFDKOAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GMDENGAFKJH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	COFJGBKIOKK PFNMAOEEDDI();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JNPPGBAJCKJ : GMDENGAFKJH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x76F8740", Offset = "0x76F7B40", VA = "0x1876F8740")]
	[AGCFNMIICNN.HNNLCOLGEGD.DNCHPFJACPB]
	internal static void MHHLPLPPGCP(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	[RecRoom.NoEngine.Common.Preserve]
	public JNPPGBAJCKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x76F87B0", Offset = "0x76F7BB0", VA = "0x1876F87B0", Slot = "4")]
	public COFJGBKIOKK PFNMAOEEDDI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GFHMGJFENGN]
public class HALCMDIMGGP : HDGFPOCENLP, IDisposable, CIFGLLCEMBC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct GCCPNFCIIPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<PLLKDGGCDAN, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public HALCMDIMGGP <>4__this;

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
		public HOODJKFNCBH roomOfferType;

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
		private TaskAwaiter<FJLFOPJGIAP<PLLKDGGCDAN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x76F27B0", Offset = "0x76F1BB0", VA = "0x1876F27B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x76F2CE0", Offset = "0x76F20E0", VA = "0x1876F2CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct BNBLCNCHFPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<PLLKDGGCDAN, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public HALCMDIMGGP <>4__this;

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
		public HOODJKFNCBH roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<FJLFOPJGIAP<PLLKDGGCDAN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x76F0A10", Offset = "0x76EFE10", VA = "0x1876F0A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x76F0FB0", Offset = "0x76F03B0", VA = "0x1876F0FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct HPONENIFNOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public HALCMDIMGGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private PLLKDGGCDAN <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<KPAJNJCMOIH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x76F7760", Offset = "0x76F6B60", VA = "0x1876F7760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x76F7CB0", Offset = "0x76F70B0", VA = "0x1876F7CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct JBBJACBAGMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<List<AOMOJGJNDOC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HALCMDIMGGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<FJLFOPJGIAP<List<AOMOJGJNDOC>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x76F82E0", Offset = "0x76F76E0", VA = "0x1876F82E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x76F86D0", Offset = "0x76F7AD0", VA = "0x1876F86D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct GGLOMLEEMEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public HALCMDIMGGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public GHBEGPNJJCK player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x76F2D50", Offset = "0x76F2150", VA = "0x1876F2D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x76F30F0", Offset = "0x76F24F0", VA = "0x1876F30F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct IKBOIDPBMBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public HALCMDIMGGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public PLLKDGGCDAN roomOffer;

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
		private TaskAwaiter<ABNAGONECLM<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x76F7D20", Offset = "0x76F7120", VA = "0x1876F7D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x76F8270", Offset = "0x76F7670", VA = "0x1876F8270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct APLBJMABFIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public HALCMDIMGGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PLLKDGGCDAN roomOffer;

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
		private ADOJHODDFIC <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private IDNDIAJABGE <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<IDNDIAJABGE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x76F0070", Offset = "0x76EF470", VA = "0x1876F0070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x76F09A0", Offset = "0x76EFDA0", VA = "0x1876F09A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EPHBLOCHGIL
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
			public EPHBLOCHGIL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x76F8E40", Offset = "0x76F8240", VA = "0x1876F8E40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x76F91B0", Offset = "0x76F85B0", VA = "0x1876F91B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public HALCMDIMGGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public EPHBLOCHGIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x76F26C0", Offset = "0x76F1AC0", VA = "0x1876F26C0")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task OIKHBHEPDJM(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x76F25A0", Offset = "0x76F19A0", VA = "0x1876F25A0")]
		internal Guid? HJBOGNGDDCA(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct ACGPODFAFGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<IDNDIAJABGE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public HALCMDIMGGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public PLLKDGGCDAN roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private EPHBLOCHGIL <>8__1;

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
		private TaskAwaiter<IDNDIAJABGE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x76EF340", Offset = "0x76EE740", VA = "0x1876EF340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x76F0000", Offset = "0x76EF400", VA = "0x1876F0000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct DNABNLJNAOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public HALCMDIMGGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<FJLFOPJGIAP<List<JODNKLMGLGO>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<List<PLLKDGGCDAN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<FJLFOPJGIAP<List<JODNKLMGLGO>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x76F1680", Offset = "0x76F0A80", VA = "0x1876F1680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x76F1E70", Offset = "0x76F1270", VA = "0x1876F1E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct EEDJMNAELJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public HALCMDIMGGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x76F1ED0", Offset = "0x76F12D0", VA = "0x1876F1ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x76F2540", Offset = "0x76F1940", VA = "0x1876F2540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct NEDAABOBOCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public HALCMDIMGGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public GHBEGPNJJCK player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x76F8870", Offset = "0x76F7C70", VA = "0x1876F8870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x76F8DD0", Offset = "0x76F81D0", VA = "0x1876F8DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan JPBEFDDGCLB;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string JHICLNEMKOD = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string JOFHPGMIJDG = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string IDPGGNPOLJF = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PBKDPFHAIBL CEKLCHPLJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly ALDODBGDBHA HCMIHOCCGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly NEKMDFKADJO AFLJLBFNLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly PBMDMFNAGKG NPHJHEOIMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly JNBOKINFKNI JFKPGBDBHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly IFDKLFIMJPM OOJOBMNBGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HBDMFKFDCBH IHMGMGMEKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CMFIDCACFLM CDNLEMBHCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly GNGEHECHLMB LMPCMNDFEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FNJEDMNNIPN JOEJCKPBHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly COFJGBKIOKK HPAIHCGNHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> MJIMKPMNFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable FMMJKKEKLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task EAHGMLGHKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource JNECABBGMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long JDKDOFFGFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool IOFECLNHDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly BBBIJJGGBBI HLAPIEMLLMA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private FBCPCEBCOIO DCDKAPDNEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76F67E0", Offset = "0x76F5BE0", VA = "0x1876F67E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MIPKPFFHABJ EAHPPIIILIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA8C290", Offset = "0xA8B690", VA = "0x180A8C290", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA8BFE0", Offset = "0xA8B3E0", VA = "0x180A8BFE0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FABEAAEBPBG<PLLKDGGCDAN> PPHAOLEAAON
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8CDCD0", Offset = "0x8CD0D0", VA = "0x1808CDCD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8CDD20", Offset = "0x8CD120", VA = "0x1808CDD20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FABEAAEBPBG<Guid> EKFGOBIEDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99A220", Offset = "0x999620", VA = "0x18099A220", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA9C280", Offset = "0xA9B680", VA = "0x180A9C280", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x76F65D0", Offset = "0x76F59D0", VA = "0x1876F65D0")]
	[AGCFNMIICNN.HNNLCOLGEGD.DNCHPFJACPB]
	internal static void MHHLPLPPGCP(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x76F7040", Offset = "0x76F6440", VA = "0x1876F7040")]
	[RecRoom.NoEngine.Common.Preserve]
	public HALCMDIMGGP([CNGCCDLPGOD(null)] PBKDPFHAIBL CEKLCHPLJOM, [CNGCCDLPGOD(null)] ALDODBGDBHA HCMIHOCCGPG, [CNGCCDLPGOD(null)] CBKPLBJIJFB JNPEEDEABBA, [CNGCCDLPGOD(null)] NEKMDFKADJO AFLJLBFNLCH, [CNGCCDLPGOD(null)] GMDENGAFKJH IPIGKBMGNPJ, [CNGCCDLPGOD(null)] PBMDMFNAGKG NPHJHEOIMPF, [CNGCCDLPGOD("ShowPurchasePromptRateLimiter")] JNBOKINFKNI JFKPGBDBHHJ, [CNGCCDLPGOD(null)] IFDKLFIMJPM OOJOBMNBGID, [CNGCCDLPGOD(null)] IHDJIOFBCPO CAMECLHDDAA, [CNGCCDLPGOD(null)] HBDMFKFDCBH IHMGMGMEKPB, [CNGCCDLPGOD(null)] CMFIDCACFLM CDNLEMBHCAK, [CNGCCDLPGOD(null)] GNGEHECHLMB LMPCMNDFEEC, [CNGCCDLPGOD(null)] FNJEDMNNIPN JOEJCKPBHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x76F3B30", Offset = "0x76F2F30", VA = "0x1876F3B30", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x76F4740", Offset = "0x76F3B40", VA = "0x1876F4740", Slot = "10")]
	[AsyncStateMachine(typeof(GCCPNFCIIPI))]
	public Task<ABNAGONECLM<PLLKDGGCDAN, string>> GIDOHELCGKJ(Guid? PAHOMILLPCN, long GGLEGKBAGLC, string LJAGHAHCFHJ, string JADMIFIBKFL, string MDMALADOMKA, int EBPGMCFICMG, HOODJKFNCBH LNIBBDFLJON, [Optional] Dictionary<Guid, int> PKILGKLOBDJ, [Optional] Guid? BMMIGBEADNP, bool APGBDPBGKHO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x76F4480", Offset = "0x76F3880", VA = "0x1876F4480", Slot = "11")]
	[AsyncStateMachine(typeof(BNBLCNCHFPN))]
	public Task<ABNAGONECLM<PLLKDGGCDAN, string>> FJPFPLLIDMM(Guid JABHIEHJFDE, long GGLEGKBAGLC, string LJAGHAHCFHJ, string JADMIFIBKFL, string MDMALADOMKA, int EBPGMCFICMG, HOODJKFNCBH LNIBBDFLJON, [Optional] Dictionary<Guid, int> PKILGKLOBDJ, [Optional] Guid? BMMIGBEADNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x76F4620", Offset = "0x76F3A20", VA = "0x1876F4620", Slot = "12")]
	[AsyncStateMachine(typeof(HPONENIFNOH))]
	public Task<ABNAGONECLM<bool, string>> GEBBJHBHMAK(Guid JOKIMANLBOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x76F5180", Offset = "0x76F4580", VA = "0x1876F5180", Slot = "13")]
	public IEnumerable<PLLKDGGCDAN> HPPIPOGNBKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x76F3A00", Offset = "0x76F2E00", VA = "0x1876F3A00", Slot = "14")]
	[AsyncStateMachine(typeof(JBBJACBAGMJ))]
	public Task<List<AOMOJGJNDOC>> DJFAKFAJNGC(long GGLEGKBAGLC, [Optional] CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x76F3D90", Offset = "0x76F3190", VA = "0x1876F3D90", Slot = "17")]
	public bool EKBFCOCCOJK(Guid JOKIMANLBOL, int NNOGGEFLJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x76F6270", Offset = "0x76F5670", VA = "0x1876F6270", Slot = "15")]
	public bool KNIAJILCPKB(Guid JOKIMANLBOL, [Out] PLLKDGGCDAN PPEDHDFACMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x76F5B60", Offset = "0x76F4F60", VA = "0x1876F5B60", Slot = "16")]
	public bool JHNKEHFGEFE(string LJAGHAHCFHJ, [Out] PLLKDGGCDAN PPEDHDFACMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x76F6830", Offset = "0x76F5C30", VA = "0x1876F6830", Slot = "18")]
	public void NMPKPLNFOEN(GHBEGPNJJCK FFBDHANOEPC, Guid JOKIMANLBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x76F6350", Offset = "0x76F5750", VA = "0x1876F6350", Slot = "19")]
	[AsyncStateMachine(typeof(GGLOMLEEMEH))]
	public Task<int> LIPPAJFDDMD(GHBEGPNJJCK FFBDHANOEPC, Guid JOKIMANLBOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x76F5230", Offset = "0x76F4630", VA = "0x1876F5230", Slot = "20")]
	public bool IDPCBHFCJKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x76F3F90", Offset = "0x76F3390", VA = "0x1876F3F90", Slot = "21")]
	public bool FADDMKPGILD(Guid CLNCJNGIHEA, [Out] List<string> LBOLCMPFACI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x76F4B40", Offset = "0x76F3F40", VA = "0x1876F4B40", Slot = "22")]
	[AsyncStateMachine(typeof(IKBOIDPBMBE))]
	public Task<ABNAGONECLM<bool, string>> HHCFNNFJAAJ(PLLKDGGCDAN PPEDHDFACMP, long BEDFFHENCMB, int LCEJFEIPOIC, string EAPNJPFPNBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x76F3830", Offset = "0x76F2C30", VA = "0x1876F3830")]
	[AsyncStateMachine(typeof(APLBJMABFIK))]
	private Task<ABNAGONECLM<bool, string>> CODGKNEPPJO(PLLKDGGCDAN PPEDHDFACMP, long BEDFFHENCMB, long FOBPNIBLBEO, string EAPNJPFPNBD, int LCEJFEIPOIC = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x76F6A10", Offset = "0x76F5E10", VA = "0x1876F6A10")]
	[AsyncStateMachine(typeof(ACGPODFAFGI))]
	private Task<IDNDIAJABGE> PPBDGPCNCLH(PLLKDGGCDAN PPEDHDFACMP, int LCEJFEIPOIC, int BEDFFHENCMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x76F3240", Offset = "0x76F2640", VA = "0x1876F3240")]
	private bool BHPOBKKFLDF(IEnumerable<OCDOLEGADBM> EAFKDADNMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x76F5DC0", Offset = "0x76F51C0", VA = "0x1876F5DC0")]
	private void JNLLDBAGFAK(PLLKDGGCDAN PPEDHDFACMP, long FOBPNIBLBEO, int LCEJFEIPOIC, string EAPNJPFPNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x76F48F0", Offset = "0x76F3CF0", VA = "0x1876F48F0")]
	private string HEHGNKLMCII(PLLKDGGCDAN PPEDHDFACMP, int LCEJFEIPOIC, string EAPNJPFPNBD, [Optional] ADOJHODDFIC? CEDDFJCBLGM, [Optional] OIFIMNAPKPK? EHDBHCKDAOH, [Optional] string JCJKIACFNID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x76F3590", Offset = "0x76F2990", VA = "0x1876F3590")]
	private ADOJHODDFIC BKCHAGOAHGF(PLLKDGGCDAN FCFHIDBCICC, int HPOAMNNABEK, [Out] long FOBPNIBLBEO)
	{
		return default(ADOJHODDFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x76F5310", Offset = "0x76F4710", VA = "0x1876F5310")]
	[AsyncStateMachine(typeof(DNABNLJNAOG))]
	private Task IELCGAEAAIJ(long GGLEGKBAGLC, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x76F5780", Offset = "0x76F4B80", VA = "0x1876F5780")]
	private Task JFEMPFKBKBA(MCGHEPNDHCL DCNLGGHAIIP, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x76F3170", Offset = "0x76F2570", VA = "0x1876F3170")]
	[AsyncStateMachine(typeof(EEDJMNAELJB))]
	private Task BHAFEJPDMHP(MCGHEPNDHCL DCNLGGHAIIP, CancellationToken MIGBMCOAKEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x76F5420", Offset = "0x76F4820", VA = "0x1876F5420")]
	private static Dictionary<Guid, int> JDPIBHOLIKC(FJLFOPJGIAP<List<JODNKLMGLGO>> AKLAEINNNAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x76F3160", Offset = "0x76F2560", VA = "0x1876F3160")]
	private void AHEMFJKKAIF(PLLKDGGCDAN PPEDHDFACMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x76F3990", Offset = "0x76F2D90", VA = "0x1876F3990")]
	private void DHFHJLOMPDF(Guid JOKIMANLBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x76F6DE0", Offset = "0x76F61E0", VA = "0x1876F6DE0")]
	[PIOPMLBOJAJ]
	internal void RpcOfferShowPurchasePrompt(Guid JOKIMANLBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x76F6490", Offset = "0x76F5890", VA = "0x1876F6490")]
	[AsyncStateMachine(typeof(NEDAABOBOCJ))]
	private Task<int> LPJEHDMFHMH(GHBEGPNJJCK FFBDHANOEPC, Guid CLNCJNGIHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x76F6BF0", Offset = "0x76F5FF0", VA = "0x1876F6BF0")]
	[PIOPMLBOJAJ]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid NDFJMJHNPGE, Guid JOKIMANLBOL, FLIPFBDBKMC APBNMEDOGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x76F6B70", Offset = "0x76F5F70", VA = "0x1876F6B70")]
	[PIOPMLBOJAJ]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid NDFJMJHNPGE, int ABPDJOGPHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x76F4CA0", Offset = "0x76F40A0", VA = "0x1876F4CA0", Slot = "24")]
	public string HMFJCACBBEL(ADOJHODDFIC CEDDFJCBLGM, [Optional] OIFIMNAPKPK? EAENIHEKFGO, [Optional] BalanceResponseDTO ENICNCIPKFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x76F4390", Offset = "0x76F3790", VA = "0x1876F4390")]
	private static string FHGAJEHIHDP(OIFIMNAPKPK EAENIHEKFGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x76F6640", Offset = "0x76F5A40", VA = "0x1876F6640")]
	private PLLKDGGCDAN NCHMGCCOFJI(PLLKDGGCDAN MDKFFIGPKHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x76F6200", Offset = "0x76F5600", VA = "0x1876F6200")]
	private void KCGILCAAMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x76F5050", Offset = "0x76F4450", VA = "0x1876F5050")]
	private void HNBLNICJOBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class COFJGBKIOKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Guid, PLLKDGGCDAN> JDENFLNKFLO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long JHIEDJKCDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x13F9DC0", Offset = "0x13F91C0", VA = "0x1813F9DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x76F1080", Offset = "0x76F0480", VA = "0x1876F1080")]
	public void FEDFAJNFFMH(long GGLEGKBAGLC, IEnumerable<PLLKDGGCDAN> KOAJLKFJLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x76F1510", Offset = "0x76F0910", VA = "0x1876F1510")]
	public bool MOHMGDJANCH(Guid JOKIMANLBOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x76F1020", Offset = "0x76F0420", VA = "0x1876F1020")]
	public bool BDKJEBALGLD(Guid JOKIMANLBOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x76F12F0", Offset = "0x76F06F0", VA = "0x1876F12F0")]
	public bool HFIPGFCAOAF(PLLKDGGCDAN AKHLLBHAFEM, [Out] PLLKDGGCDAN PMMPPDEOAFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x76F1450", Offset = "0x76F0850", VA = "0x1876F1450")]
	public IEnumerable<PLLKDGGCDAN> KFGOJNNBEME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x76F14A0", Offset = "0x76F08A0", VA = "0x1876F14A0")]
	public bool KNIAJILCPKB(Guid JOKIMANLBOL, [Out] PLLKDGGCDAN PPEDHDFACMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x76F1570", Offset = "0x76F0970", VA = "0x1876F1570")]
	private bool PNFFAFGMAIM(PLLKDGGCDAN CNBOFDKAIKM, PLLKDGGCDAN NFLJFBPCDLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x76F15F0", Offset = "0x76F09F0", VA = "0x1876F15F0")]
	public COFJGBKIOKK()
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
