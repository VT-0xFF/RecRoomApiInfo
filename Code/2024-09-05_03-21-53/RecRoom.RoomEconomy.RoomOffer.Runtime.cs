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
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x724F510", Offset = "0x724DF10", VA = "0x18724F510", Slot = "8")]
		public override void KLIFGJHDPHO(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AHFAJEGEDCN : ACOKNLGOCBL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PPENHCKGMDD HDJHOPDFIIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FNJFCJMPOHM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FLHOOCHDKEK GNHODJGCEAK();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BAPCFMDCEIE : FNJFCJMPOHM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72463A0", Offset = "0x7244DA0", VA = "0x1872463A0")]
	[POCMGODEOKB.MGMEIEHFBKI.CGAMGCLHOIE]
	internal static void FIDEIEBMMOH(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	[RecRoom.NoEngine.Common.Preserve]
	public BAPCFMDCEIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7246410", Offset = "0x7244E10", VA = "0x187246410", Slot = "4")]
	public FLHOOCHDKEK GNHODJGCEAK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PLAFBFJHEAK]
public class PPENHCKGMDD : FCGIKKJDMDG, IDisposable, PFDBGFMNONE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DDGAFEKBPPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<KJIGBDEBKIL, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public PPENHCKGMDD <>4__this;

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
		public DHAHLPPPOJK roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<ICJDJHPJHPN<KJIGBDEBKIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7247CE0", Offset = "0x72466E0", VA = "0x187247CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x72481A0", Offset = "0x7246BA0", VA = "0x1872481A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct PECCFLEBMKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<KJIGBDEBKIL, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public PPENHCKGMDD <>4__this;

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
		public DHAHLPPPOJK roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<ICJDJHPJHPN<KJIGBDEBKIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x724A860", Offset = "0x7249260", VA = "0x18724A860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x724ADE0", Offset = "0x72497E0", VA = "0x18724ADE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BCDIPNLHKGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public PPENHCKGMDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private KJIGBDEBKIL <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<EDEDDHHEIOM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x72464D0", Offset = "0x7244ED0", VA = "0x1872464D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7246A10", Offset = "0x7245410", VA = "0x187246A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct MDMKBDDJKMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<List<GAIDPLPLHDE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PPENHCKGMDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<ICJDJHPJHPN<List<GAIDPLPLHDE>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7249BC0", Offset = "0x72485C0", VA = "0x187249BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7249FB0", Offset = "0x72489B0", VA = "0x187249FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct IGLKCMGEJPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public PPENHCKGMDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public PHNOICNFFCM player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7248AA0", Offset = "0x72474A0", VA = "0x187248AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7248E40", Offset = "0x7247840", VA = "0x187248E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct CPGIGLHPFDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public PPENHCKGMDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public KJIGBDEBKIL roomOffer;

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
		private TaskAwaiter<MOKFKOEPKDB<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7247720", Offset = "0x7246120", VA = "0x187247720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7247C70", Offset = "0x7246670", VA = "0x187247C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct ALHJJNALHNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public PPENHCKGMDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public KJIGBDEBKIL roomOffer;

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
		private GOFAFEFNMCA <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private OCABDOEDIOA <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<OCABDOEDIOA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7245A00", Offset = "0x7244400", VA = "0x187245A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7246330", Offset = "0x7244D30", VA = "0x187246330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class HCCLFKMDBIO
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
			public HCCLFKMDBIO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x724F140", Offset = "0x724DB40", VA = "0x18724F140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x724F4B0", Offset = "0x724DEB0", VA = "0x18724F4B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public PPENHCKGMDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public HCCLFKMDBIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7248890", Offset = "0x7247290", VA = "0x187248890")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task BIJGMDMHJNK(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7248980", Offset = "0x7247380", VA = "0x187248980")]
		internal Guid? LLHKCILMEJJ(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct LIHGIODCFCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<OCABDOEDIOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public PPENHCKGMDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public KJIGBDEBKIL roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private HCCLFKMDBIO <>8__1;

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
		private TaskAwaiter<OCABDOEDIOA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7248EB0", Offset = "0x72478B0", VA = "0x187248EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7249B50", Offset = "0x7248550", VA = "0x187249B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct OJAAIOIHNMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public PPENHCKGMDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private Task<ICJDJHPJHPN<List<EFCKAGIAENA>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<List<KJIGBDEBKIL>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<ICJDJHPJHPN<List<EFCKAGIAENA>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x724A020", Offset = "0x7248A20", VA = "0x18724A020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x724A800", Offset = "0x7249200", VA = "0x18724A800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CKNDCAMMLOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public PPENHCKGMDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7247050", Offset = "0x7245A50", VA = "0x187247050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x72476C0", Offset = "0x72460C0", VA = "0x1872476C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct CIDAABMBOCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public PPENHCKGMDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public PHNOICNFFCM player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7246A80", Offset = "0x7245480", VA = "0x187246A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7246FE0", Offset = "0x72459E0", VA = "0x187246FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan HCCEMJHFODM;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string EJHAAHBIGGK = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string CGPBHEMGDFA = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string KBAACPHMFOG = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DNKPHNNCFAJ OOKMBFNFADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly CCDHFNCAMJB AENPJCEGMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CNOJNJOOBAH OPLBNAMMKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MADEEJNOHNA JDGBNOGOAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CNCGMILALCP OGJDGIDDGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly AHFAJEGEDCN NKKEHHEAPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly KNNKDHBNPOP NAAJCHKOOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly ELIOOJIKEPB OEPFMAEIGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HBJMPCMPBBN AJLGMMOBLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LEOKDMFNADP PFNPNFEKNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly FLHOOCHDKEK CGDFMJGHDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> AMJFBFGHENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable JKOAPLPCPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task ACPGJPADKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource BDFPBGBFIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long NNEMLKOOFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool JJAPMBJBFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly JPFBHJCPAKC KDIPLPFKNKL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private MBKGCCFPPGP AHBCFAJHPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x724C600", Offset = "0x724B000", VA = "0x18724C600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public PLAJPLAPENK MPDGCEECEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x93A510", Offset = "0x938F10", VA = "0x18093A510", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB7A020", Offset = "0xB78A20", VA = "0x180B7A020", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public HLIGJNPKABP<KJIGBDEBKIL> BHFGFIOOFDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x888340", Offset = "0x886D40", VA = "0x180888340", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8882D0", Offset = "0x886CD0", VA = "0x1808882D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HLIGJNPKABP<Guid> NIFKNJHBPIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA38CD0", Offset = "0xA376D0", VA = "0x180A38CD0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD17B50", Offset = "0xD16550", VA = "0x180D17B50", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x724BE10", Offset = "0x724A810", VA = "0x18724BE10")]
	[POCMGODEOKB.MGMEIEHFBKI.CGAMGCLHOIE]
	internal static void FIDEIEBMMOH(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x724EA20", Offset = "0x724D420", VA = "0x18724EA20")]
	[RecRoom.NoEngine.Common.Preserve]
	public PPENHCKGMDD([CNNDHKODGDP(null)] DNKPHNNCFAJ OOKMBFNFADA, [CNNDHKODGDP(null)] CCDHFNCAMJB AENPJCEGMOB, [CNNDHKODGDP(null)] ONKPALEHEPK DDIIFEKPIGK, [CNNDHKODGDP(null)] CNOJNJOOBAH OPLBNAMMKKJ, [CNNDHKODGDP(null)] FNJFCJMPOHM CGKLABDIMFB, [CNNDHKODGDP(null)] MADEEJNOHNA JDGBNOGOAHL, [CNNDHKODGDP("ShowPurchasePromptRateLimiter")] CNCGMILALCP OGJDGIDDGAC, [CNNDHKODGDP(null)] AHFAJEGEDCN NKKEHHEAPGP, [CNNDHKODGDP(null)] COACLAJFNPB HMMDEHHACDI, [CNNDHKODGDP(null)] KNNKDHBNPOP NAAJCHKOOEC, [CNNDHKODGDP(null)] ELIOOJIKEPB OEPFMAEIGFA, [CNNDHKODGDP(null)] HBJMPCMPBBN AJLGMMOBLLK, [CNNDHKODGDP(null)] LEOKDMFNADP PFNPNFEKNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x724B9D0", Offset = "0x724A3D0", VA = "0x18724B9D0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x724E0B0", Offset = "0x724CAB0", VA = "0x18724E0B0", Slot = "10")]
	[AsyncStateMachine(typeof(DDGAFEKBPPK))]
	public Task<MOKFKOEPKDB<KJIGBDEBKIL, string>> ODENJKKIICP(long NDAIANNJONA, string HBOONHFLONJ, string OMGOMGJLFOM, string IKMFBPHDKGN, int HIHNNNPIFNC, DHAHLPPPOJK KKNBFLNGNOL, [Optional] Dictionary<Guid, int> BGFPPNPEHJG, [Optional] Guid? AOCHONPOHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x724E3C0", Offset = "0x724CDC0", VA = "0x18724E3C0", Slot = "11")]
	[AsyncStateMachine(typeof(PECCFLEBMKK))]
	public Task<MOKFKOEPKDB<KJIGBDEBKIL, string>> PKLLOAGHBNL(Guid GFCPMOEENKD, string HBOONHFLONJ, string OMGOMGJLFOM, string IKMFBPHDKGN, int HIHNNNPIFNC, DHAHLPPPOJK KKNBFLNGNOL, [Optional] Dictionary<Guid, int> BGFPPNPEHJG, [Optional] Guid? AOCHONPOHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x724AE50", Offset = "0x7249850", VA = "0x18724AE50", Slot = "12")]
	[AsyncStateMachine(typeof(BCDIPNLHKGA))]
	public Task<MOKFKOEPKDB<bool, string>> AMFNIEHHFGP(Guid GFCPMOEENKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x724B8B0", Offset = "0x724A2B0", VA = "0x18724B8B0", Slot = "13")]
	public IEnumerable<KJIGBDEBKIL> CNFOBGHKBNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x724CF50", Offset = "0x724B950", VA = "0x18724CF50", Slot = "14")]
	[AsyncStateMachine(typeof(MDMKBDDJKMJ))]
	public Task<List<GAIDPLPLHDE>> IHBCBLPFJCO(long NDAIANNJONA, [Optional] CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x724BE80", Offset = "0x724A880", VA = "0x18724BE80", Slot = "16")]
	public bool FJIBKECKGON(Guid GFCPMOEENKD, int IACFFGNLCML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x724D6B0", Offset = "0x724C0B0", VA = "0x18724D6B0", Slot = "15")]
	public bool JPBCKFKIJJN(Guid GFCPMOEENKD, [Out] KJIGBDEBKIL AFBDEBCPPFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x724BC30", Offset = "0x724A630", VA = "0x18724BC30", Slot = "17")]
	public void ELGDONMHGAP(PHNOICNFFCM JGEPDBLHLJG, Guid GFCPMOEENKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x724CA20", Offset = "0x724B420", VA = "0x18724CA20", Slot = "18")]
	[AsyncStateMachine(typeof(IGLKCMGEJPG))]
	public Task<int> HHMIMDOLOMM(PHNOICNFFCM JGEPDBLHLJG, Guid GFCPMOEENKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x724D790", Offset = "0x724C190", VA = "0x18724D790", Slot = "19")]
	public bool KBODFKMBHPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x724B350", Offset = "0x7249D50", VA = "0x18724B350", Slot = "20")]
	public bool CBGNMMCGKGH(Guid BHNHNCPMKGA, [Out] List<string> ICKBPEBDOID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x724B750", Offset = "0x724A150", VA = "0x18724B750", Slot = "21")]
	[AsyncStateMachine(typeof(CPGIGLHPFDD))]
	public Task<MOKFKOEPKDB<bool, string>> CGJNPAJIBLF(KJIGBDEBKIL AFBDEBCPPFK, long OJMBOGPGAEO, int CBMKMKAFNOB, string EDOGLICBGNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x724CDF0", Offset = "0x724B7F0", VA = "0x18724CDF0")]
	[AsyncStateMachine(typeof(ALHJJNALHNM))]
	private Task<MOKFKOEPKDB<bool, string>> ICHGIODKGKE(KJIGBDEBKIL AFBDEBCPPFK, long OJMBOGPGAEO, long FHEGDKEFKGG, string EDOGLICBGNJ, int CBMKMKAFNOB = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x724CC90", Offset = "0x724B690", VA = "0x18724CC90")]
	[AsyncStateMachine(typeof(LIHGIODCFCG))]
	private Task<OCABDOEDIOA> HMGAHAIGLPE(KJIGBDEBKIL AFBDEBCPPFK, int CBMKMKAFNOB, int OJMBOGPGAEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x724C2B0", Offset = "0x724ACB0", VA = "0x18724C2B0")]
	private bool GMDHFHALLFC(IEnumerable<DJBAHHONJLH> GOEJIOFDIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x724C650", Offset = "0x724B050", VA = "0x18724C650")]
	private void HBDEGMNEBEO(KJIGBDEBKIL AFBDEBCPPFK, long FHEGDKEFKGG, int CBMKMKAFNOB, string EDOGLICBGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x724D870", Offset = "0x724C270", VA = "0x18724D870")]
	private string MFHPFMCCKAB(KJIGBDEBKIL AFBDEBCPPFK, int CBMKMKAFNOB, string EDOGLICBGNJ, [Optional] GOFAFEFNMCA? DFEFBOIIPKP, [Optional] KHHNEIDBOAG? GBGIOOBCOLN, [Optional] string EHIPNBLEOIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x724DE10", Offset = "0x724C810", VA = "0x18724DE10")]
	private GOFAFEFNMCA NAJBDHIAAAL(KJIGBDEBKIL DGHLOGKANPA, int AMKBGBNDNLF, [Out] long FHEGDKEFKGG)
	{
		return default(GOFAFEFNMCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x724E2B0", Offset = "0x724CCB0", VA = "0x18724E2B0")]
	[AsyncStateMachine(typeof(OJAAIOIHNMC))]
	private Task OGJEFPGHFGJ(long NDAIANNJONA, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x724AF70", Offset = "0x7249970", VA = "0x18724AF70")]
	private Task BFNCMGJAGIN(NIKPNOMJFLH EBIJIHILGPC, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x724D5E0", Offset = "0x724BFE0", VA = "0x18724D5E0")]
	[AsyncStateMachine(typeof(CKNDCAMMLOL))]
	private Task JOLFCPKMMEN(NIKPNOMJFLH EBIJIHILGPC, CancellationToken BEDPKOLFHKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x724DAC0", Offset = "0x724C4C0", VA = "0x18724DAC0")]
	private static Dictionary<Guid, int> MICKDLJJJOH(ICJDJHPJHPN<List<EFCKAGIAENA>> MEMLGFOIPPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x724D430", Offset = "0x724BE30", VA = "0x18724D430")]
	private void JDHJKLIKOGF(KJIGBDEBKIL AFBDEBCPPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x724B960", Offset = "0x724A360", VA = "0x18724B960")]
	private void DGACFJGENON(Guid GFCPMOEENKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x724E7C0", Offset = "0x724D1C0", VA = "0x18724E7C0")]
	[LGLPLGIJKOL]
	internal void RpcOfferShowPurchasePrompt(Guid GFCPMOEENKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x724C170", Offset = "0x724AB70", VA = "0x18724C170")]
	[AsyncStateMachine(typeof(CIDAABMBOCH))]
	private Task<int> GKPJOBJMHDM(PHNOICNFFCM JGEPDBLHLJG, Guid BHNHNCPMKGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x724E5D0", Offset = "0x724CFD0", VA = "0x18724E5D0")]
	[LGLPLGIJKOL]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid LDAHMGICCPK, Guid GFCPMOEENKD, BFENIDNIHBM NKKPFKFLMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x724E550", Offset = "0x724CF50", VA = "0x18724E550")]
	[LGLPLGIJKOL]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid LDAHMGICCPK, int KFBJHPBJLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x724D080", Offset = "0x724BA80", VA = "0x18724D080", Slot = "23")]
	public string INNMPKCEIOF(GOFAFEFNMCA DFEFBOIIPKP, [Optional] KHHNEIDBOAG? DPKLMOEANBH, [Optional] BalanceResponseDTO FOPDPBLGPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x724C080", Offset = "0x724AA80", VA = "0x18724C080")]
	private static string FOMAHIIGJKE(KHHNEIDBOAG DPKLMOEANBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x724D440", Offset = "0x724BE40", VA = "0x18724D440")]
	private KJIGBDEBKIL JKCABACOINF(KJIGBDEBKIL PFNNBBHAICB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x724E240", Offset = "0x724CC40", VA = "0x18724E240")]
	private void ODGEGBFCBEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x724CB60", Offset = "0x724B560", VA = "0x18724CB60")]
	private void HMEGDDJLFED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class FLHOOCHDKEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Dictionary<Guid, KJIGBDEBKIL> INKPCFGBNLA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long GOHJNFCMHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x11DFE70", Offset = "0x11DE870", VA = "0x1811DFE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7248570", Offset = "0x7246F70", VA = "0x187248570")]
	public void OMAHMCPKAON(long NDAIANNJONA, IEnumerable<KJIGBDEBKIL> OAKOJNHCDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7248490", Offset = "0x7246E90", VA = "0x187248490")]
	public bool NAMNMGCIKCB(Guid GFCPMOEENKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7248430", Offset = "0x7246E30", VA = "0x187248430")]
	public bool MIOFMOMIMDC(Guid GFCPMOEENKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7248260", Offset = "0x7246C60", VA = "0x187248260")]
	public bool GFAFGOAIGBJ(KJIGBDEBKIL NMDIIDOMJLA, [Out] KJIGBDEBKIL INBGGBDOICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7248210", Offset = "0x7246C10", VA = "0x187248210")]
	public IEnumerable<KJIGBDEBKIL> AHCOJNBAIOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x72483C0", Offset = "0x7246DC0", VA = "0x1872483C0")]
	public bool JPBCKFKIJJN(Guid GFCPMOEENKD, [Out] KJIGBDEBKIL AFBDEBCPPFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x72484F0", Offset = "0x7246EF0", VA = "0x1872484F0")]
	private bool NIKDPMJDJAB(KJIGBDEBKIL ANAJBMGGMGD, KJIGBDEBKIL HIJNJLDCFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7248800", Offset = "0x7247200", VA = "0x187248800")]
	public FLHOOCHDKEK()
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
