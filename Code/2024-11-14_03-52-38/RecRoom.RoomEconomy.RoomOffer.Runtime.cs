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
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x741C5A0", Offset = "0x741B9A0", VA = "0x18741C5A0", Slot = "8")]
		public override void LFFFLDDGBMJ(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NBAKHIFMEME : OMKEKBEKFAP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EJIBMBKNDGP IDCFHFMDDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MOECFCAIAHF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OPGDEENGHJF KAFIFAAFKLO();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JDCJMPHNMEP : MOECFCAIAHF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x741A770", Offset = "0x7419B70", VA = "0x18741A770")]
	[GOEIKLHOLGG.IBEFHGHGJKH.OGEIPBLEMDG]
	internal static void DJNFEGBLBOB(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	[RecRoom.NoEngine.Common.Preserve]
	public JDCJMPHNMEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x741A7E0", Offset = "0x7419BE0", VA = "0x18741A7E0", Slot = "4")]
	public OPGDEENGHJF KAFIFAAFKLO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MMCIGIHMOCH]
public class EJIBMBKNDGP : BEJBPFLHLPP, IDisposable, BFBJJPLHAMA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct JCPEDMCKHIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<GFMLPMHGMOD, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public EJIBMBKNDGP <>4__this;

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
		public DDHAPBEFBAO roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<IGEHGGACLCG<GFMLPMHGMOD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x741A230", Offset = "0x7419630", VA = "0x18741A230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x741A700", Offset = "0x7419B00", VA = "0x18741A700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GEOHIAKFODA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<GFMLPMHGMOD, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public EJIBMBKNDGP <>4__this;

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
		public DDHAPBEFBAO roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<IGEHGGACLCG<GFMLPMHGMOD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x74193E0", Offset = "0x74187E0", VA = "0x1874193E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7419960", Offset = "0x7418D60", VA = "0x187419960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct OLMGOKJOAHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public EJIBMBKNDGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private GFMLPMHGMOD <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<LLJDCDJIOJL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x741B190", Offset = "0x741A590", VA = "0x18741B190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x741B6D0", Offset = "0x741AAD0", VA = "0x18741B6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CIABCHAHMDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<List<FLOLPIIJNCK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public EJIBMBKNDGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<IGEHGGACLCG<List<FLOLPIIJNCK>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7412F80", Offset = "0x7412380", VA = "0x187412F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7413380", Offset = "0x7412780", VA = "0x187413380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct PONOMDPOKLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public EJIBMBKNDGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public EDHEFFCJEMG player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x741BDB0", Offset = "0x741B1B0", VA = "0x18741BDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x741C150", Offset = "0x741B550", VA = "0x18741C150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct DKLFOHJOECD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public EJIBMBKNDGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public GFMLPMHGMOD roomOffer;

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
		private TaskAwaiter<BMFECDODLAB<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7413D90", Offset = "0x7413190", VA = "0x187413D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x74142E0", Offset = "0x74136E0", VA = "0x1874142E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CNMLIPINLJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EJIBMBKNDGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public GFMLPMHGMOD roomOffer;

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
		private ICHDKNKFAMC <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private BKDPCGEAENG <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<BKDPCGEAENG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x74133F0", Offset = "0x74127F0", VA = "0x1874133F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7413D20", Offset = "0x7413120", VA = "0x187413D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MFKLOBOJIOE
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
			public MFKLOBOJIOE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x741C1C0", Offset = "0x741B5C0", VA = "0x18741C1C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x741C540", Offset = "0x741B940", VA = "0x18741C540", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public EJIBMBKNDGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public MFKLOBOJIOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x741B0A0", Offset = "0x741A4A0", VA = "0x18741B0A0")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task DMFIADPKHBB(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x741AF80", Offset = "0x741A380", VA = "0x18741AF80")]
		internal Guid? ADNLPHPBJOL(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GAJPLPIDIOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<BKDPCGEAENG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public EJIBMBKNDGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public GFMLPMHGMOD roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private MFKLOBOJIOE <>8__1;

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
		private TaskAwaiter<BKDPCGEAENG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x74186C0", Offset = "0x7417AC0", VA = "0x1874186C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7419370", Offset = "0x7418770", VA = "0x187419370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct HPGFKHGGBMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public EJIBMBKNDGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private Task<IGEHGGACLCG<List<CAOLEHIAHCA>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<List<GFMLPMHGMOD>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<IGEHGGACLCG<List<CAOLEHIAHCA>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x74199D0", Offset = "0x7418DD0", VA = "0x1874199D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x741A1D0", Offset = "0x74195D0", VA = "0x18741A1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct KNEJDBDLOBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public EJIBMBKNDGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x741A8A0", Offset = "0x7419CA0", VA = "0x18741A8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x741AF20", Offset = "0x741A320", VA = "0x18741AF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ANKNMJIIHIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public EJIBMBKNDGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public EDHEFFCJEMG player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x74129A0", Offset = "0x7411DA0", VA = "0x1874129A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7412F10", Offset = "0x7412310", VA = "0x187412F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan IPINBJJOOGM;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string HOCOHKJKJIF = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string EGJDCHPJPGE = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string BLHIBKJLJLK = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly BCMDOGKDJME ONKJJBGPMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly LJMNIDLMNPF AIMLBFLAPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CDGHNLHMECN PFPGPFBOMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly KOFDFCJMCJL JDHBFLHENJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly MMIPPAMOBEK LMJGCFBJOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly NBAKHIFMEME NGOPDBMHCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JLOEMLCBNBI OJNJHJENDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly BIOPNKKBCBM HHDLPCGGDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly INODJPNBOCN HIONPBCBEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FIKBJGAFEKF DEKNLFILPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly OPGDEENGHJF LGDOBOAHKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> HHKLJPIAFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable GHIOHJOCJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task OAAFFDAMEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource DMMDGHAACEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long DCLBAOGJPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool AAFPLDAFGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly MBBKNNEPKDN FMDBANFNBKG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private LOFBJIOIIIO EPHBFJFDCGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74165B0", Offset = "0x74159B0", VA = "0x1874165B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BDDIJCFMLKF NBEJEFBNMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9F1750", Offset = "0x9F0B50", VA = "0x1809F1750", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9EFFD0", Offset = "0x9EF3D0", VA = "0x1809EFFD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EJELNBCCPAC<GFMLPMHGMOD> JLLJMOPPCKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x89A360", Offset = "0x899760", VA = "0x18089A360", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x89A420", Offset = "0x899820", VA = "0x18089A420", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EJELNBCCPAC<Guid> JJOMFHIELGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9711F0", Offset = "0x9705F0", VA = "0x1809711F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA03B90", Offset = "0xA02F90", VA = "0x180A03B90", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7414FA0", Offset = "0x74143A0", VA = "0x187414FA0")]
	[GOEIKLHOLGG.IBEFHGHGJKH.OGEIPBLEMDG]
	internal static void DJNFEGBLBOB(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7417F80", Offset = "0x7417380", VA = "0x187417F80")]
	[RecRoom.NoEngine.Common.Preserve]
	public EJIBMBKNDGP([NDMEANGLJKD(null)] BCMDOGKDJME ONKJJBGPMCL, [NDMEANGLJKD(null)] LJMNIDLMNPF AIMLBFLAPAN, [NDMEANGLJKD(null)] NOCIHHILPOB NJDKELKJIBP, [NDMEANGLJKD(null)] CDGHNLHMECN PFPGPFBOMNB, [NDMEANGLJKD(null)] MOECFCAIAHF ANJNFAIPFBE, [NDMEANGLJKD(null)] KOFDFCJMCJL JDHBFLHENJD, [NDMEANGLJKD("ShowPurchasePromptRateLimiter")] MMIPPAMOBEK LMJGCFBJOFP, [NDMEANGLJKD(null)] NBAKHIFMEME NGOPDBMHCBM, [NDMEANGLJKD(null)] AALPGBGGJBI ONKAKNKLNME, [NDMEANGLJKD(null)] JLOEMLCBNBI OJNJHJENDCA, [NDMEANGLJKD(null)] BIOPNKKBCBM HHDLPCGGDMI, [NDMEANGLJKD(null)] INODJPNBOCN HIONPBCBEAH, [NDMEANGLJKD(null)] FIKBJGAFEKF DEKNLFILPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x74150F0", Offset = "0x74144F0", VA = "0x1874150F0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7417550", Offset = "0x7416950", VA = "0x187417550", Slot = "10")]
	[AsyncStateMachine(typeof(JCPEDMCKHIF))]
	public Task<BMFECDODLAB<GFMLPMHGMOD, string>> OMBBLOJENLK(long HLKBDGNJMKK, string ACDGEPBIBHJ, string ICNGJIJIACL, string ELKICCMMGCC, int BEALEBFKKGM, DDHAPBEFBAO HAMFHNCGNMB, [Optional] Dictionary<Guid, int> MLIEOEEPLNJ, [Optional] Guid? DBNOEFICJHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7416C10", Offset = "0x7416010", VA = "0x187416C10", Slot = "11")]
	[AsyncStateMachine(typeof(GEOHIAKFODA))]
	public Task<BMFECDODLAB<GFMLPMHGMOD, string>> LIOBAPDLKBE(Guid FBDBCPIOFCJ, string ACDGEPBIBHJ, string ICNGJIJIACL, string ELKICCMMGCC, int BEALEBFKKGM, DDHAPBEFBAO HAMFHNCGNMB, [Optional] Dictionary<Guid, int> MLIEOEEPLNJ, [Optional] Guid? DBNOEFICJHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7417840", Offset = "0x7416C40", VA = "0x187417840", Slot = "12")]
	[AsyncStateMachine(typeof(OLMGOKJOAHF))]
	public Task<BMFECDODLAB<bool, string>> PKFACCMBFFP(Guid FBDBCPIOFCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7416730", Offset = "0x7415B30", VA = "0x187416730", Slot = "13")]
	public IEnumerable<GFMLPMHGMOD> KHGPBFNLGNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7416600", Offset = "0x7415A00", VA = "0x187416600", Slot = "14")]
	[AsyncStateMachine(typeof(CIABCHAHMDP))]
	public Task<List<FLOLPIIJNCK>> KCFDNCKOCCA(long HLKBDGNJMKK, [Optional] CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7416110", Offset = "0x7415510", VA = "0x187416110", Slot = "16")]
	public bool JJIBEKCFIFP(Guid FBDBCPIOFCJ, int EHMDAGDELIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7415370", Offset = "0x7414770", VA = "0x187415370", Slot = "15")]
	public bool EAGBAGCCILN(Guid FBDBCPIOFCJ, [Out] GFMLPMHGMOD OCCLOMHLGEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7415F30", Offset = "0x7415330", VA = "0x187415F30", Slot = "17")]
	public void JJEAABCLFIB(EDHEFFCJEMG FFANAAGKHEI, Guid FBDBCPIOFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7417970", Offset = "0x7416D70", VA = "0x187417970", Slot = "18")]
	[AsyncStateMachine(typeof(PONOMDPOKLB))]
	public Task<int> PPGCILMPPFI(EDHEFFCJEMG FFANAAGKHEI, Guid FBDBCPIOFCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7416B30", Offset = "0x7415F30", VA = "0x187416B30", Slot = "19")]
	public bool LCCMKCPIAOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x74157B0", Offset = "0x7414BB0", VA = "0x1874157B0", Slot = "20")]
	public bool EOPDMMHAOOE(Guid CDIPHMLEOFL, [Out] List<string> JMKHEJOMKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7416DA0", Offset = "0x74161A0", VA = "0x187416DA0", Slot = "21")]
	[AsyncStateMachine(typeof(DKLFOHJOECD))]
	public Task<BMFECDODLAB<bool, string>> NINOOPALMJO(GFMLPMHGMOD OCCLOMHLGEB, long OJLAICFDIKB, int LBJJAOIKGCM, string AGGBMGNIPJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x74176E0", Offset = "0x7416AE0", VA = "0x1874176E0")]
	[AsyncStateMachine(typeof(CNMLIPINLJF))]
	private Task<BMFECDODLAB<bool, string>> PJHMIKPJNFJ(GFMLPMHGMOD OCCLOMHLGEB, long OJLAICFDIKB, long EEPJGCLBEAH, string AGGBMGNIPJI, int LBJJAOIKGCM = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7416310", Offset = "0x7415710", VA = "0x187416310")]
	[AsyncStateMachine(typeof(GAJPLPIDIOC))]
	private Task<BKDPCGEAENG> JONCMPEAINE(GFMLPMHGMOD OCCLOMHLGEB, int LBJJAOIKGCM, int OJLAICFDIKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7415450", Offset = "0x7414850", VA = "0x187415450")]
	private bool EGMHNKHMACE(IEnumerable<GCNFFCCFGMM> AELJHFIFAEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7414BD0", Offset = "0x7413FD0", VA = "0x187414BD0")]
	private void CKMJCDJGCHB(GFMLPMHGMOD OCCLOMHLGEB, long EEPJGCLBEAH, int LBJJAOIKGCM, string AGGBMGNIPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x74167E0", Offset = "0x7415BE0", VA = "0x1874167E0")]
	private string KLLEDJCEAPJ(GFMLPMHGMOD OCCLOMHLGEB, int LBJJAOIKGCM, string AGGBMGNIPJI, [Optional] ICHDKNKFAMC? HCMJFDLGOJF, [Optional] FLKFAAKFCLL? EICIKILGFGG, [Optional] string KMDHHEEKDLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x74172B0", Offset = "0x74166B0", VA = "0x1874172B0")]
	private ICHDKNKFAMC OEGIOFHBMFD(GFMLPMHGMOD JMAIKBDLGGK, int KEIICKMDGBH, [Out] long EEPJGCLBEAH)
	{
		return default(ICHDKNKFAMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7415BB0", Offset = "0x7414FB0", VA = "0x187415BB0")]
	[AsyncStateMachine(typeof(HPGFKHGGBMH))]
	private Task FBHDGDMOAPJ(long HLKBDGNJMKK, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7414350", Offset = "0x7413750", VA = "0x187414350")]
	private Task AJDJEDEGOGN(GPHLDHMLGGJ KCHFAPGLICB, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7415E60", Offset = "0x7415260", VA = "0x187415E60")]
	[AsyncStateMachine(typeof(KNEJDBDLOBC))]
	private Task JBGKFENCFDD(GPHLDHMLGGJ KCHFAPGLICB, CancellationToken BKIOLHNFANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7414740", Offset = "0x7413B40", VA = "0x187414740")]
	private static Dictionary<Guid, int> CAPKBIMAEKD(IGEHGGACLCG<List<CAOLEHIAHCA>> FIFMAHFHCGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7417960", Offset = "0x7416D60", VA = "0x187417960")]
	private void PNKLPFPHGAC(GFMLPMHGMOD OCCLOMHLGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7415080", Offset = "0x7414480", VA = "0x187415080")]
	private void DOENEPFBGFP(Guid FBDBCPIOFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7417D20", Offset = "0x7417120", VA = "0x187417D20")]
	[BGNHMBMBOCL]
	internal void RpcOfferShowPurchasePrompt(Guid FBDBCPIOFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7416470", Offset = "0x7415870", VA = "0x187416470")]
	[AsyncStateMachine(typeof(ANKNMJIIHIA))]
	private Task<int> JPHNFGCMFFL(EDHEFFCJEMG FFANAAGKHEI, Guid CDIPHMLEOFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7417B30", Offset = "0x7416F30", VA = "0x187417B30")]
	[BGNHMBMBOCL]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid LBOKKGIBGKL, Guid FBDBCPIOFCJ, HNGGJDJMLJB EALDCBFDHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7417AB0", Offset = "0x7416EB0", VA = "0x187417AB0")]
	[BGNHMBMBOCL]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid LBOKKGIBGKL, int GMOPHNCDIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7416F00", Offset = "0x7416300", VA = "0x187416F00", Slot = "23")]
	public string OAPFGJDPKOD(ICHDKNKFAMC HCMJFDLGOJF, [Optional] FLKFAAKFCLL? CHNHNCGPPBO, [Optional] BalanceResponseDTO EABIPJBDHBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7416A40", Offset = "0x7415E40", VA = "0x187416A40")]
	private static string LAOMKCBLLAC(FLKFAAKFCLL CHNHNCGPPBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7415CC0", Offset = "0x74150C0", VA = "0x187415CC0")]
	private GFMLPMHGMOD GGBDEEJBKBK(GFMLPMHGMOD CEBKJDELDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7415010", Offset = "0x7414410", VA = "0x187415010")]
	private void DNOKGDHAPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7414AA0", Offset = "0x7413EA0", VA = "0x187414AA0")]
	private void CEKOHOLNGJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class OPGDEENGHJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Dictionary<Guid, GFMLPMHGMOD> CLENOLHAPKH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long KANBOFIDLBB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x13800E0", Offset = "0x137F4E0", VA = "0x1813800E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x741BA20", Offset = "0x741AE20", VA = "0x18741BA20")]
	public void MCBEFILMHNL(long HLKBDGNJMKK, IEnumerable<GFMLPMHGMOD> FAINBEOHNBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x741B860", Offset = "0x741AC60", VA = "0x18741B860")]
	public bool HFDKHLLBGGB(Guid FBDBCPIOFCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x741B740", Offset = "0x741AB40", VA = "0x18741B740")]
	public bool BIJNEFLCHFA(Guid FBDBCPIOFCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x741B8C0", Offset = "0x741ACC0", VA = "0x18741B8C0")]
	public bool KNNDCCNIKDH(GFMLPMHGMOD DMKIHHPCAOD, [Out] GFMLPMHGMOD NBOFAJJAEAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x741B7A0", Offset = "0x741ABA0", VA = "0x18741B7A0")]
	public IEnumerable<GFMLPMHGMOD> CIKEALGBAOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x741B7F0", Offset = "0x741ABF0", VA = "0x18741B7F0")]
	public bool EAGBAGCCILN(Guid FBDBCPIOFCJ, [Out] GFMLPMHGMOD OCCLOMHLGEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x741BCA0", Offset = "0x741B0A0", VA = "0x18741BCA0")]
	private bool OMMDDDLNGLO(GFMLPMHGMOD DCGCMNFFOJI, GFMLPMHGMOD OODGNCKBIED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x741BD20", Offset = "0x741B120", VA = "0x18741BD20")]
	public OPGDEENGHJF()
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
