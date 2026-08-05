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
		[Cpp2IlInjected.Address(RVA = "0x89607E0", Offset = "0x895F3E0", VA = "0x1889607E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FDLPDEPPIOH : KJJDDKJPFHA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MPCBLCJDMIO HNLJOGAJBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PJDAPEEBKDD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KCHGDPDFGHN HIKHJIOIPDF();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AIFPBKEHCGD : PJDAPEEBKDD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x89569A0", Offset = "0x89555A0", VA = "0x1889569A0")]
	[HHMPGEJNNFC.LMFNECDEKKH.PMAKKEDIOOO]
	internal static void KGIELNFJPKP(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	[RecRoom.NoEngine.Common.Preserve]
	public AIFPBKEHCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x89568E0", Offset = "0x89554E0", VA = "0x1889568E0", Slot = "4")]
	public KCHGDPDFGHN HIKHJIOIPDF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GOLNKMGDHKC]
public class MPCBLCJDMIO : EAFBPJEPLHA, IDisposable, LPNKHPBOEKG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DBGAHEMDJLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<NBDJOKHDIFE, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MPCBLCJDMIO <>4__this;

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
		public NKNOGCAMIHC roomOfferType;

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
		private TaskAwaiter<FPFJIDNHIOL<NBDJOKHDIFE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8957D10", Offset = "0x8956910", VA = "0x188957D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8958240", Offset = "0x8956E40", VA = "0x188958240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct IOAOGPENHJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<NBDJOKHDIFE, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public MPCBLCJDMIO <>4__this;

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
		public NKNOGCAMIHC roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<FPFJIDNHIOL<NBDJOKHDIFE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8959D60", Offset = "0x8958960", VA = "0x188959D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x895A300", Offset = "0x8958F00", VA = "0x18895A300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct MIEALFLNGEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public MPCBLCJDMIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private NBDJOKHDIFE <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<LHNADKNCFMA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x895B010", Offset = "0x8959C10", VA = "0x18895B010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x895B570", Offset = "0x895A170", VA = "0x18895B570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HHICPAKHNBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<List<DEJLDDKHGPI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public MPCBLCJDMIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<FPFJIDNHIOL<List<DEJLDDKHGPI>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x89598F0", Offset = "0x89584F0", VA = "0x1889598F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8959CF0", Offset = "0x89588F0", VA = "0x188959CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct LNPLAHPGBNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public MPCBLCJDMIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public PLCCGHEKGIM player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x895A9F0", Offset = "0x89595F0", VA = "0x18895A9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x895AD90", Offset = "0x8959990", VA = "0x18895AD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct GKHENOGMEIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public MPCBLCJDMIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public NBDJOKHDIFE roomOffer;

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
		private TaskAwaiter<IADHIMOENNN<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8959330", Offset = "0x8957F30", VA = "0x188959330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8959880", Offset = "0x8958480", VA = "0x188959880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DOHLOELADDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public MPCBLCJDMIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NBDJOKHDIFE roomOffer;

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
		private PJELLIDODDK <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private MCJLBFDJMOO <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<MCJLBFDJMOO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x89582B0", Offset = "0x8956EB0", VA = "0x1889582B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8958BE0", Offset = "0x89577E0", VA = "0x188958BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MCBBLBGCPKP
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
			public MCBBLBGCPKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8960410", Offset = "0x895F010", VA = "0x188960410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8960780", Offset = "0x895F380", VA = "0x188960780", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public MPCBLCJDMIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public MCBBLBGCPKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x895AE00", Offset = "0x8959A00", VA = "0x18895AE00")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task KPNDJAPGEDJ(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x895AEF0", Offset = "0x8959AF0", VA = "0x18895AEF0")]
		internal Guid? MHPBBLMHLHB(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CBIPDMDJCCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<MCJLBFDJMOO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public MPCBLCJDMIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NBDJOKHDIFE roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private MCBBLBGCPKP <>8__1;

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
		private TaskAwaiter<MCJLBFDJMOO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8956FE0", Offset = "0x8955BE0", VA = "0x188956FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8957CA0", Offset = "0x89568A0", VA = "0x188957CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct NKLPJFDJIDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public MPCBLCJDMIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<FPFJIDNHIOL<List<BJIPKBDAMJO>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<List<NBDJOKHDIFE>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<FPFJIDNHIOL<List<BJIPKBDAMJO>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x895FBC0", Offset = "0x895E7C0", VA = "0x18895FBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x89603B0", Offset = "0x895EFB0", VA = "0x1889603B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GBIPIDNOAIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public MPCBLCJDMIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8958C50", Offset = "0x8957850", VA = "0x188958C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x89592D0", Offset = "0x8957ED0", VA = "0x1889592D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ANHAOMGCDDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public MPCBLCJDMIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public PLCCGHEKGIM player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8956A10", Offset = "0x8955610", VA = "0x188956A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8956F70", Offset = "0x8955B70", VA = "0x188956F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan FBBJIHFGJCL;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string LHHOOEFBOJA = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string EBLBJKGGPMH = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string OAIFFCJEBPN = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DHGMNMHFIHH OCDFFDBLLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DKCBALPBFPJ KCJJOBEKAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly HNMFEIOHHML MIHACEDCKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly PEHHKHACOAC MBMIIEAOJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly OEFEAFJLNPF DMIEDNFCDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly FDLPDEPPIOH EFOBBDPFICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly MNKKKDLGHHB FFBAIGJFNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly JNBBEJADKIF IMBMMDAHFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly MDHEJJOELKA FBMJJMABGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DLJGFIJIADD IIIFHIOCMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly KCHGDPDFGHN OEEONGFJBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> LMCLJPJEONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable KAMMPJEEFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task LFOKEHAFJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource INIEMHHNIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long KGJMFJBGNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool BNHFKKOIPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly HBIOCJJJMKB LPANHLPGFKK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private CHCMEDNOJAJ AAFHGAGLEFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x895EAD0", Offset = "0x895D6D0", VA = "0x18895EAD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LKKDMOCNJPN CBKCENBCKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAC0610", Offset = "0xABF210", VA = "0x180AC0610", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB0C9D0", Offset = "0xB0B5D0", VA = "0x180B0C9D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GFJLLHFJBHN<NBDJOKHDIFE> JMAIMANLGIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA65BC0", Offset = "0xA647C0", VA = "0x180A65BC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA65C30", Offset = "0xA64830", VA = "0x180A65C30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GFJLLHFJBHN<Guid> EANNNNOJKHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB0CA10", Offset = "0xB0B610", VA = "0x180B0CA10", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB0CA60", Offset = "0xB0B660", VA = "0x180B0CA60", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x895E9F0", Offset = "0x895D5F0", VA = "0x18895E9F0")]
	[HHMPGEJNNFC.LMFNECDEKKH.PMAKKEDIOOO]
	internal static void KGIELNFJPKP(LGPCNHIHIDJ EHEGCBFMKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x895F490", Offset = "0x895E090", VA = "0x18895F490")]
	[RecRoom.NoEngine.Common.Preserve]
	public MPCBLCJDMIO([HAKCNCGPHPD(null)] DHGMNMHFIHH OCDFFDBLLLL, [HAKCNCGPHPD(null)] DKCBALPBFPJ KCJJOBEKAGG, [HAKCNCGPHPD(null)] CGIGLIONEGJ GIPGNPNHAHB, [HAKCNCGPHPD(null)] HNMFEIOHHML MIHACEDCKKO, [HAKCNCGPHPD(null)] PJDAPEEBKDD JFHMAOJHJCH, [HAKCNCGPHPD(null)] PEHHKHACOAC MBMIIEAOJOA, [HAKCNCGPHPD("ShowPurchasePromptRateLimiter")] OEFEAFJLNPF DMIEDNFCDKB, [HAKCNCGPHPD(null)] FDLPDEPPIOH EFOBBDPFICA, [HAKCNCGPHPD(null)] OPHEJEMNBEK IKKDFNNDANH, [HAKCNCGPHPD(null)] MNKKKDLGHHB FFBAIGJFNPP, [HAKCNCGPHPD(null)] JNBBEJADKIF IMBMMDAHFMK, [HAKCNCGPHPD(null)] MDHEJJOELKA FBMJJMABGKK, [HAKCNCGPHPD(null)] DLJGFIJIADD IIIFHIOCMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x895C730", Offset = "0x895B330", VA = "0x18895C730", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x895DE40", Offset = "0x895CA40", VA = "0x18895DE40", Slot = "10")]
	[AsyncStateMachine(typeof(DBGAHEMDJLO))]
	public Task<IADHIMOENNN<NBDJOKHDIFE, string>> IMOIBPHFMMC(Guid? EKMNPJDLCJD, long MJILNJAJHOI, string BKILENEPEEB, string JKEAHMPNEHK, string HIGFGBDCIBL, int JHELJMBCIFN, NKNOGCAMIHC NLIJFPJFDMG, [Optional] Dictionary<Guid, int> LHLDAIICOMN, [Optional] Guid? HJECEGIOMGP, bool DIEONCAMKNG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x895E5F0", Offset = "0x895D1F0", VA = "0x18895E5F0", Slot = "11")]
	[AsyncStateMachine(typeof(IOAOGPENHJB))]
	public Task<IADHIMOENNN<NBDJOKHDIFE, string>> JKBELKJKEJI(Guid CKIKBDDFFBL, long MJILNJAJHOI, string BKILENEPEEB, string JKEAHMPNEHK, string HIGFGBDCIBL, int JHELJMBCIFN, NKNOGCAMIHC NLIJFPJFDMG, [Optional] Dictionary<Guid, int> LHLDAIICOMN, [Optional] Guid? HJECEGIOMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x895B5E0", Offset = "0x895A1E0", VA = "0x18895B5E0", Slot = "12")]
	[AsyncStateMachine(typeof(MIEALFLNGEE))]
	public Task<IADHIMOENNN<bool, string>> AFEFPHJJLPN(Guid LIAKAJBGNHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x895EF10", Offset = "0x895DB10", VA = "0x18895EF10", Slot = "13")]
	public IEnumerable<NBDJOKHDIFE> OHJBEEHEMOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x895C160", Offset = "0x895AD60", VA = "0x18895C160", Slot = "14")]
	[AsyncStateMachine(typeof(HHICPAKHNBG))]
	public Task<List<DEJLDDKHGPI>> CNLNLOJDECE(long MJILNJAJHOI, [Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x895E3F0", Offset = "0x895CFF0", VA = "0x18895E3F0", Slot = "17")]
	public bool JCIDGDBFEDF(Guid LIAKAJBGNHD, int EGAELDLDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x895D510", Offset = "0x895C110", VA = "0x18895D510", Slot = "15")]
	public bool GFPPNJMEDLI(Guid LIAKAJBGNHD, [Out] NBDJOKHDIFE JBJBBDEHMEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x895E790", Offset = "0x895D390", VA = "0x18895E790", Slot = "16")]
	public bool JNLIIEKDKBL(string BKILENEPEEB, [Out] NBDJOKHDIFE JBJBBDEHMEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x895D5F0", Offset = "0x895C1F0", VA = "0x18895D5F0", Slot = "18")]
	public void GHNPDOJPNEM(PLCCGHEKGIM FANAFCDPEEP, Guid LIAKAJBGNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x895C020", Offset = "0x895AC20", VA = "0x18895C020", Slot = "19")]
	[AsyncStateMachine(typeof(LNPLAHPGBNL))]
	public Task<int> CMIOBCIAJGG(PLCCGHEKGIM FANAFCDPEEP, Guid LIAKAJBGNHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x895D7D0", Offset = "0x895C3D0", VA = "0x18895D7D0", Slot = "20")]
	public bool GLJNKECLOED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x895DFF0", Offset = "0x895CBF0", VA = "0x18895DFF0", Slot = "21")]
	public bool INGAEJGACKD(Guid DCJGAKOBLDI, [Out] List<string> DNOEPEKJMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x895D980", Offset = "0x895C580", VA = "0x18895D980", Slot = "22")]
	[AsyncStateMachine(typeof(GKHENOGMEIJ))]
	public Task<IADHIMOENNN<bool, string>> HKMOHKGHPAA(NBDJOKHDIFE JBJBBDEHMEE, long PDOGFJKABAO, int KHGDCKMEAJM, string HCPGLGPEAHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x895BEC0", Offset = "0x895AAC0", VA = "0x18895BEC0")]
	[AsyncStateMachine(typeof(DOHLOELADDI))]
	private Task<IADHIMOENNN<bool, string>> BIOHAKILOMB(NBDJOKHDIFE JBJBBDEHMEE, long PDOGFJKABAO, long CCKJCJELNGL, string HCPGLGPEAHM, int KHGDCKMEAJM = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x895BD60", Offset = "0x895A960", VA = "0x18895BD60")]
	[AsyncStateMachine(typeof(CBIPDMDJCCH))]
	private Task<MCJLBFDJMOO> BIDDIKHOEME(NBDJOKHDIFE JBJBBDEHMEE, int KHGDCKMEAJM, int PDOGFJKABAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x895B9A0", Offset = "0x895A5A0", VA = "0x18895B9A0")]
	private bool BABKMNMNDCB(IEnumerable<OMBKJEIDKBE> ADDHOACHFNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x895D140", Offset = "0x895BD40", VA = "0x18895D140")]
	private void GBEFLKBGLME(NBDJOKHDIFE JBJBBDEHMEE, long CCKJCJELNGL, int KHGDCKMEAJM, string HCPGLGPEAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x895CC90", Offset = "0x895B890", VA = "0x18895CC90")]
	private string EPCFGPLNNPA(NBDJOKHDIFE JBJBBDEHMEE, int KHGDCKMEAJM, string HCPGLGPEAHM, [Optional] PJELLIDODDK? ABEFNIJCBBN, [Optional] AEKCHBEELBD? LIFFHICJEPC, [Optional] string MNOJKHHPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x895B700", Offset = "0x895A300", VA = "0x18895B700")]
	private PJELLIDODDK AIJMOKCGLAI(NBDJOKHDIFE LNIPHPJGFPJ, int LCANFCIKNFD, [Out] long CCKJCJELNGL)
	{
		return default(PJELLIDODDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x895CF00", Offset = "0x895BB00", VA = "0x18895CF00")]
	[AsyncStateMachine(typeof(NKLPJFDJIDG))]
	private Task FJHCGCHJMOA(long MJILNJAJHOI, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x895EB20", Offset = "0x895D720", VA = "0x18895EB20")]
	private Task NLBBCMPGNBN(KMDFPIFPLDI AHEPAEIEJIO, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x895D8B0", Offset = "0x895C4B0", VA = "0x18895D8B0")]
	[AsyncStateMachine(typeof(GBIPIDNOAIL))]
	private Task HIGCJDHLBHO(KMDFPIFPLDI AHEPAEIEJIO, CancellationToken NCLFLKBAEJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x895DAE0", Offset = "0x895C6E0", VA = "0x18895DAE0")]
	private static Dictionary<Guid, int> IFLLOOOGJCL(FPFJIDNHIOL<List<BJIPKBDAMJO>> PDPLENJIEND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x895CEF0", Offset = "0x895BAF0", VA = "0x18895CEF0")]
	private void FHBBJHJPJAA(NBDJOKHDIFE JBJBBDEHMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x895BCF0", Offset = "0x895A8F0", VA = "0x18895BCF0")]
	private void BAJADHAIECM(Guid LIAKAJBGNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x895F230", Offset = "0x895DE30", VA = "0x18895F230")]
	[LGDDHCFHIFD]
	internal void RpcOfferShowPurchasePrompt(Guid LIAKAJBGNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x895CB50", Offset = "0x895B750", VA = "0x18895CB50")]
	[AsyncStateMachine(typeof(ANHAOMGCDDB))]
	private Task<int> EJOMJMPJDGC(PLCCGHEKGIM FANAFCDPEEP, Guid DCJGAKOBLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x895F040", Offset = "0x895DC40", VA = "0x18895F040")]
	[LGDDHCFHIFD]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid JKLGJDFLIGN, Guid LIAKAJBGNHD, OJPNDDCHNHP ACLFBNHJPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x895EFC0", Offset = "0x895DBC0", VA = "0x18895EFC0")]
	[LGDDHCFHIFD]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid JKLGJDFLIGN, int NKGPOLKDIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x895C380", Offset = "0x895AF80", VA = "0x18895C380", Slot = "24")]
	public string DPCDMDOAJHD(PJELLIDODDK ABEFNIJCBBN, [Optional] AEKCHBEELBD? DACBMNPHAIA, [Optional] BalanceResponseDTO EIGNCEFLFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x895C290", Offset = "0x895AE90", VA = "0x18895C290")]
	private static string DGPAMBHHOPM(AEKCHBEELBD DACBMNPHAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x895C9B0", Offset = "0x895B5B0", VA = "0x18895C9B0")]
	private NBDJOKHDIFE EGADAEMHAJH(NBDJOKHDIFE IGHCOOABBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x895EA60", Offset = "0x895D660", VA = "0x18895EA60")]
	private void KMKCAKAGPCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x895D010", Offset = "0x895BC10", VA = "0x18895D010")]
	private void FOGDFDGIBMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class KCHGDPDFGHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Guid, NBDJOKHDIFE> HGDHKCAADKN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long LJEFHIMJIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xD73220", Offset = "0xD71E20", VA = "0x180D73220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x895A6D0", Offset = "0x89592D0", VA = "0x18895A6D0")]
	public void PKJBHLHOEAP(long MJILNJAJHOI, IEnumerable<NBDJOKHDIFE> CHNECGPKPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x895A490", Offset = "0x8959090", VA = "0x18895A490")]
	public bool KGBJLAHJGAE(Guid LIAKAJBGNHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x895A3C0", Offset = "0x8958FC0", VA = "0x18895A3C0")]
	public bool ENKPLOICKCM(Guid LIAKAJBGNHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x895A570", Offset = "0x8959170", VA = "0x18895A570")]
	public bool NNNILBDIPJB(NBDJOKHDIFE EJAMONGIOGO, [Out] NBDJOKHDIFE LJECHCFKKPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x895A370", Offset = "0x8958F70", VA = "0x18895A370")]
	public IEnumerable<NBDJOKHDIFE> EDBKILCIFGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x895A420", Offset = "0x8959020", VA = "0x18895A420")]
	public bool GFPPNJMEDLI(Guid LIAKAJBGNHD, [Out] NBDJOKHDIFE JBJBBDEHMEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x895A4F0", Offset = "0x89590F0", VA = "0x18895A4F0")]
	private bool KNLDDBHOKPI(NBDJOKHDIFE CBMDPCIEEMO, NBDJOKHDIFE GFFLPNHOMHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x895A960", Offset = "0x8959560", VA = "0x18895A960")]
	public KCHGDPDFGHN()
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
