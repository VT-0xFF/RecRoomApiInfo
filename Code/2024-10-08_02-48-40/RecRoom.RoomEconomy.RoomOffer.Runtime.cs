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
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7323440", Offset = "0x7322640", VA = "0x187323440", Slot = "8")]
		public override void KGHJDOOILCG(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BADDHJNPNDI : KHHDJECPKDN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KHKHLAFOMHI DLLMPBKECHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DLPLEDBONEO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PPAICHFFOEP NNLAACHIDMN();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BEDACHAHBLO : DLPLEDBONEO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x73198F0", Offset = "0x7318AF0", VA = "0x1873198F0")]
	[NPIOOMADHDK.ICBCOBDLNNE.HFJMLJLJJPC]
	internal static void GLGGBEPLOGP(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BEDACHAHBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7319960", Offset = "0x7318B60", VA = "0x187319960", Slot = "4")]
	public PPAICHFFOEP NNLAACHIDMN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HAAHLEBGOKA]
public class KHKHLAFOMHI : MJGFIHCIOCM, IDisposable, NLGCCCDMEGH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DHMCOFNLGEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<AHFMDOHLFNN, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public KHKHLAFOMHI <>4__this;

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
		public DMJNGAFMGFI roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<MBIIEKDOFBI<AHFMDOHLFNN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x731A5D0", Offset = "0x73197D0", VA = "0x18731A5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x731AAA0", Offset = "0x7319CA0", VA = "0x18731AAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct CIAFONJGIPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<AHFMDOHLFNN, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public KHKHLAFOMHI <>4__this;

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
		public DMJNGAFMGFI roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<MBIIEKDOFBI<AHFMDOHLFNN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7319A20", Offset = "0x7318C20", VA = "0x187319A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7319FA0", Offset = "0x73191A0", VA = "0x187319FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct PJMGCPBOCIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public KHKHLAFOMHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private AHFMDOHLFNN <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<LMDMKCADPNK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7322440", Offset = "0x7321640", VA = "0x187322440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7322980", Offset = "0x7321B80", VA = "0x187322980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HCONCDEDKPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<List<GKMLCCKEAII>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public KHKHLAFOMHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<MBIIEKDOFBI<List<GKMLCCKEAII>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x731B830", Offset = "0x731AA30", VA = "0x18731B830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x731BC20", Offset = "0x731AE20", VA = "0x18731BC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct NLDOEHMILLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public KHKHLAFOMHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public FGKAGKAJGLO player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7321690", Offset = "0x7320890", VA = "0x187321690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7321A30", Offset = "0x7320C30", VA = "0x187321A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct DDCDMIBKKBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public KHKHLAFOMHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AHFMDOHLFNN roomOffer;

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
		private TaskAwaiter<KJEOKHCIBGM<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x731A010", Offset = "0x7319210", VA = "0x18731A010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x731A560", Offset = "0x7319760", VA = "0x18731A560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OBHPMAEMMBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public KHKHLAFOMHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AHFMDOHLFNN roomOffer;

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
		private DAFGNGOCFNK <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private JOCCHGHMIPE <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<JOCCHGHMIPE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7321AA0", Offset = "0x7320CA0", VA = "0x187321AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x73223D0", Offset = "0x73215D0", VA = "0x1873223D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class IHAKNCFEBAH
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
			public IHAKNCFEBAH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7323060", Offset = "0x7322260", VA = "0x187323060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x73233E0", Offset = "0x73225E0", VA = "0x1873233E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public KHKHLAFOMHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public IHAKNCFEBAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x731CBA0", Offset = "0x731BDA0", VA = "0x18731CBA0")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task COLEFHPEMJE(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x731CC90", Offset = "0x731BE90", VA = "0x18731CC90")]
		internal Guid? KDEMDIHALMJ(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct FBOGCHJNIIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<JOCCHGHMIPE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KHKHLAFOMHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AHFMDOHLFNN roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private IHAKNCFEBAH <>8__1;

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
		private TaskAwaiter<JOCCHGHMIPE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x731AB10", Offset = "0x7319D10", VA = "0x18731AB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x731B7C0", Offset = "0x731A9C0", VA = "0x18731B7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IFPKLHBNINE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public KHKHLAFOMHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private Task<MBIIEKDOFBI<List<GFPABGKIPKO>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<List<AHFMDOHLFNN>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<MBIIEKDOFBI<List<GFPABGKIPKO>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x731C360", Offset = "0x731B560", VA = "0x18731C360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x731CB40", Offset = "0x731BD40", VA = "0x18731CB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct HLHNKFEIBGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public KHKHLAFOMHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x731BC90", Offset = "0x731AE90", VA = "0x18731BC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x731C300", Offset = "0x731B500", VA = "0x18731C300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct JIKJBBNEDLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public KHKHLAFOMHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public FGKAGKAJGLO player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x731CDB0", Offset = "0x731BFB0", VA = "0x18731CDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x731D320", Offset = "0x731C520", VA = "0x18731D320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan CMKMCEKADAC;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string KLJLNBHDJFE = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string IOHFFFGLBFM = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string BMPLODDFLID = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FNMPJNAJGBA CAICLBCDIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly JNIPFIMJOIL EBOEEHDOLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly HIKJAELFOHM GLAKIKFLDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly DEGDDAKEMCN HICAFNEDDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HEFMPGEOOHA EECDANMCFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly BADDHJNPNDI BIENOBLKICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly MECLKJJBJDJ PAHMCFCAIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly DNELLDLNOPE BLBAKLAIFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly IHGIJIECEBN NDAPDKEPGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NHPNODKLKOI HGMOGMHICAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly PPAICHFFOEP JFGAEMBCNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> NINCGHENDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable NEFBIMNAHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task EOEEPILOHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource HDHPMPCOLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long CLPMOONFGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool HLBKMNGGNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly AHMJJGOBPCE DHEBJIGJJKH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private JHCLJBMCAOK FIIJMNBOJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x731EE40", Offset = "0x731E040", VA = "0x18731EE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public OAACCCGABIO JNJKIELMKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x99C970", Offset = "0x99BB70", VA = "0x18099C970", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x98E630", Offset = "0x98D830", VA = "0x18098E630", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public MNNONBMLAOA<AHFMDOHLFNN> KFDBLAAHIAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x899430", Offset = "0x898630", VA = "0x180899430", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8993B0", Offset = "0x8985B0", VA = "0x1808993B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MNNONBMLAOA<Guid> HOKKIBBCKME
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x90F820", Offset = "0x90EA20", VA = "0x18090F820", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9A0E80", Offset = "0x9A0080", VA = "0x1809A0E80", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x731EFF0", Offset = "0x731E1F0", VA = "0x18731EFF0")]
	[NPIOOMADHDK.ICBCOBDLNNE.HFJMLJLJJPC]
	internal static void GLGGBEPLOGP(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7320F70", Offset = "0x7320170", VA = "0x187320F70")]
	[RecRoom.NoEngine.Common.Preserve]
	public KHKHLAFOMHI([GEFLINBOFNF(null)] FNMPJNAJGBA CAICLBCDIOF, [GEFLINBOFNF(null)] JNIPFIMJOIL EBOEEHDOLCO, [GEFLINBOFNF(null)] DFLKLMDMHDN JNPKPDKGKHI, [GEFLINBOFNF(null)] HIKJAELFOHM GLAKIKFLDIL, [GEFLINBOFNF(null)] DLPLEDBONEO GILGADEIHBJ, [GEFLINBOFNF(null)] DEGDDAKEMCN HICAFNEDDFO, [GEFLINBOFNF("ShowPurchasePromptRateLimiter")] HEFMPGEOOHA EECDANMCFBI, [GEFLINBOFNF(null)] BADDHJNPNDI BIENOBLKICH, [GEFLINBOFNF(null)] KLGPJCJJPJD ACHCGJFEJPG, [GEFLINBOFNF(null)] MECLKJJBJDJ PAHMCFCAIMF, [GEFLINBOFNF(null)] DNELLDLNOPE BLBAKLAIFEH, [GEFLINBOFNF(null)] IHGIJIECEBN NDAPDKEPGKL, [GEFLINBOFNF(null)] NHPNODKLKOI HGMOGMHICAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x731DDD0", Offset = "0x731CFD0", VA = "0x18731DDD0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7320910", Offset = "0x731FB10", VA = "0x187320910", Slot = "10")]
	[AsyncStateMachine(typeof(DHMCOFNLGEI))]
	public Task<KJEOKHCIBGM<AHFMDOHLFNN, string>> PODBKJOAMDJ(long MMNCPOOFGEF, string EPPPGDEIJCI, string KFMEELLINJF, string GGHFEPFKDAK, int PIDLLHEIKHK, DMJNGAFMGFI FOJKMHJDDCL, [Optional] Dictionary<Guid, int> NAPLPKNKMFO, [Optional] Guid? FOGKKJIOLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x731ECB0", Offset = "0x731DEB0", VA = "0x18731ECB0", Slot = "11")]
	[AsyncStateMachine(typeof(CIAFONJGIPP))]
	public Task<KJEOKHCIBGM<AHFMDOHLFNN, string>> FEOMDGCEKMO(Guid AHMGCGHGIOJ, string EPPPGDEIJCI, string KFMEELLINJF, string GGHFEPFKDAK, int PIDLLHEIKHK, DMJNGAFMGFI FOJKMHJDDCL, [Optional] Dictionary<Guid, int> NAPLPKNKMFO, [Optional] Guid? FOGKKJIOLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x731F940", Offset = "0x731EB40", VA = "0x18731F940", Slot = "12")]
	[AsyncStateMachine(typeof(PJMGCPBOCIB))]
	public Task<KJEOKHCIBGM<bool, string>> IDKLLPELOED(Guid AHMGCGHGIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x731E400", Offset = "0x731D600", VA = "0x18731E400", Slot = "13")]
	public IEnumerable<AHFMDOHLFNN> EBHPBCGHNCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x731F810", Offset = "0x731EA10", VA = "0x18731F810", Slot = "14")]
	[AsyncStateMachine(typeof(HCONCDEDKPN))]
	public Task<List<GKMLCCKEAII>> HPJCKOIJPKI(long MMNCPOOFGEF, [Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x731D910", Offset = "0x731CB10", VA = "0x18731D910", Slot = "16")]
	public bool CFOMLIFODDL(Guid AHMGCGHGIOJ, int ELMPCEMPDBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x731E580", Offset = "0x731D780", VA = "0x18731E580", Slot = "15")]
	public bool EHMCIBKBGPB(Guid AHMGCGHGIOJ, [Out] AHFMDOHLFNN FCOFEJGOIPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x731FBD0", Offset = "0x731EDD0", VA = "0x18731FBD0", Slot = "17")]
	public void JNJMHEMHMMD(FGKAGKAJGLO BNPABODKIGA, Guid AHMGCGHGIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x731DB10", Offset = "0x731CD10", VA = "0x18731DB10", Slot = "18")]
	[AsyncStateMachine(typeof(NLDOEHMILLB))]
	public Task<int> COALJDEOJHE(FGKAGKAJGLO BNPABODKIGA, Guid AHMGCGHGIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7320100", Offset = "0x731F300", VA = "0x187320100", Slot = "19")]
	public bool MKBJMFHCFEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x731F410", Offset = "0x731E610", VA = "0x18731F410", Slot = "20")]
	public bool HMPFNHELBCK(Guid BAOKNPDFEOP, [Out] List<string> OEPFNDCNFBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x731FA60", Offset = "0x731EC60", VA = "0x18731FA60", Slot = "21")]
	[AsyncStateMachine(typeof(DDCDMIBKKBG))]
	public Task<KJEOKHCIBGM<bool, string>> JBDHANBDOGP(AHFMDOHLFNN FCOFEJGOIPN, long MGGLOHHALKO, int LNKBLOMPPCK, string LOLFBGECLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x731EE90", Offset = "0x731E090", VA = "0x18731EE90")]
	[AsyncStateMachine(typeof(OBHPMAEMMBC))]
	private Task<KJEOKHCIBGM<bool, string>> GCIMCHNGFIJ(AHFMDOHLFNN FCOFEJGOIPN, long MGGLOHHALKO, long JDKFCLDPMMD, string LOLFBGECLNL, int LNKBLOMPPCK = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x731F060", Offset = "0x731E260", VA = "0x18731F060")]
	[AsyncStateMachine(typeof(FBOGCHJNIIG))]
	private Task<JOCCHGHMIPE> GNOODAICJBE(AHFMDOHLFNN FCOFEJGOIPN, int LNKBLOMPPCK, int MGGLOHHALKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7320400", Offset = "0x731F600", VA = "0x187320400")]
	private bool OFBOOEBMFGD(IEnumerable<IBMGFALLEPE> PEBHHOJDPDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x731E030", Offset = "0x731D230", VA = "0x18731E030")]
	private void EAMNGKFAMKH(AHFMDOHLFNN FCOFEJGOIPN, long JDKFCLDPMMD, int LNKBLOMPPCK, string LOLFBGECLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x731F1C0", Offset = "0x731E3C0", VA = "0x18731F1C0")]
	private string HHOANKBOENE(AHFMDOHLFNN FCOFEJGOIPN, int LNKBLOMPPCK, string LOLFBGECLNL, [Optional] DAFGNGOCFNK? KHPJAGHLNBM, [Optional] GCJBLLABFKH? IKNDKNCNCID, [Optional] string DGGACIOPMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x731EA10", Offset = "0x731DC10", VA = "0x18731EA10")]
	private DAFGNGOCFNK FEMNGNJJBEM(AHFMDOHLFNN BICONMKPLHI, int NBJAOBIIEDA, [Out] long JDKFCLDPMMD)
	{
		return default(DAFGNGOCFNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x731DC50", Offset = "0x731CE50", VA = "0x18731DC50")]
	[AsyncStateMachine(typeof(IFPKLHBNINE))]
	private Task DOEAGNDPAIH(long MMNCPOOFGEF, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x731D530", Offset = "0x731C730", VA = "0x18731D530")]
	private Task ANPFGKAGEIC(DIIPKNKAKCB KLDEANCBDEG, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x731E4B0", Offset = "0x731D6B0", VA = "0x18731E4B0")]
	[AsyncStateMachine(typeof(HLHNKFEIBGN))]
	private Task ECNNEDMGLFM(DIIPKNKAKCB KLDEANCBDEG, CancellationToken CBHNGLCNIHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x731FDB0", Offset = "0x731EFB0", VA = "0x18731FDB0")]
	private static Dictionary<Guid, int> MALHPBPAADA(MBIIEKDOFBI<List<GFPABGKIPKO>> GDBJCHLKADC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x731FBC0", Offset = "0x731EDC0", VA = "0x18731FBC0")]
	private void JIEMJGDBJNA(AHFMDOHLFNN FCOFEJGOIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7320760", Offset = "0x731F960", VA = "0x187320760")]
	private void OHGFAKBJGLE(Guid AHMGCGHGIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7320D10", Offset = "0x731FF10", VA = "0x187320D10")]
	[JHOKLKJKILG]
	internal void RpcOfferShowPurchasePrompt(Guid AHMGCGHGIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x73207D0", Offset = "0x731F9D0", VA = "0x1873207D0")]
	[AsyncStateMachine(typeof(JIKJBBNEDLH))]
	private Task<int> OMLIEIAELNN(FGKAGKAJGLO BNPABODKIGA, Guid BAOKNPDFEOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7320B20", Offset = "0x731FD20", VA = "0x187320B20")]
	[JHOKLKJKILG]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid OGPABPLIHCK, Guid AHMGCGHGIOJ, FPDCACKBLIP MOIJHDIDEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7320AA0", Offset = "0x731FCA0", VA = "0x187320AA0")]
	[JHOKLKJKILG]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid OGPABPLIHCK, int NDEFEFEFLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x731E660", Offset = "0x731D860", VA = "0x18731E660", Slot = "23")]
	public string ENNCOAEGEOL(DAFGNGOCFNK KHPJAGHLNBM, [Optional] GCJBLLABFKH? LHMAFCEOPFC, [Optional] BalanceResponseDTO LCIIMFKHMGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7320310", Offset = "0x731F510", VA = "0x187320310")]
	private static string NNFGMDHJICK(GCJBLLABFKH LHMAFCEOPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x731D390", Offset = "0x731C590", VA = "0x18731D390")]
	private AHFMDOHLFNN AMJJCDCHINF(AHFMDOHLFNN KDKOCCAENLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x731DD60", Offset = "0x731CF60", VA = "0x18731DD60")]
	private void DPCCDEGOHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x73201E0", Offset = "0x731F3E0", VA = "0x1873201E0")]
	private void NHLPJLHJODH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class PPAICHFFOEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Dictionary<Guid, AHFMDOHLFNN> MNONINFHDLB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long KAHMLHFALKO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1313520", Offset = "0x1312720", VA = "0x181313520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7322D50", Offset = "0x7321F50", VA = "0x187322D50")]
	public void NJLLEEEOCIO(long MMNCPOOFGEF, IEnumerable<AHFMDOHLFNN> EAKIIONGJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7322A40", Offset = "0x7321C40", VA = "0x187322A40")]
	public bool CGOHNHDLBNH(Guid AHMGCGHGIOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7322CF0", Offset = "0x7321EF0", VA = "0x187322CF0")]
	public bool LOGGCHCCBFB(Guid AHMGCGHGIOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7322B90", Offset = "0x7321D90", VA = "0x187322B90")]
	public bool KEMIDBJMJDJ(AHFMDOHLFNN NENGNMFOFPA, [Out] AHFMDOHLFNN MKIKPFFELIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x73229F0", Offset = "0x7321BF0", VA = "0x1873229F0")]
	public IEnumerable<AHFMDOHLFNN> ABBPKAHODND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7322AA0", Offset = "0x7321CA0", VA = "0x187322AA0")]
	public bool EHMCIBKBGPB(Guid AHMGCGHGIOJ, [Out] AHFMDOHLFNN FCOFEJGOIPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7322B10", Offset = "0x7321D10", VA = "0x187322B10")]
	private bool EMMIMDFJIMG(AHFMDOHLFNN JJOJMFAMEML, AHFMDOHLFNN KEADKBAIBFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7322FD0", Offset = "0x73221D0", VA = "0x187322FD0")]
	public PPAICHFFOEP()
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
