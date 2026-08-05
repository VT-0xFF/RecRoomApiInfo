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
		[Cpp2IlInjected.Address(RVA = "0x87ED510", Offset = "0x87EBB10", VA = "0x1887ED510", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EBIGFMMOMOE : PNOMNLILGGA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	APMACCODNHK GOHGMOCDECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GLJBBABAEJH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DJILHFGKPFH NPFLFGIFMHD();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BHMJPOINMCG : GLJBBABAEJH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x87E86B0", Offset = "0x87E6CB0", VA = "0x1887E86B0")]
	[BNHIEDNKDNA.PMDFMFCJKCH.JJHNPGAJPOD]
	internal static void ODEMOKCFLLI(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BHMJPOINMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x87E85F0", Offset = "0x87E6BF0", VA = "0x1887E85F0", Slot = "4")]
	public DJILHFGKPFH NPFLFGIFMHD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HIAEMPMDAHB]
public class APMACCODNHK : LEMHDDHGOCO, IDisposable, OOFFMEIPNLA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct IINKFDFLEGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<FANMKCKHALG<BKMAHJDMJAP, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public APMACCODNHK <>4__this;

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
		public KAAJMKIPCGE roomOfferType;

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
		private TaskAwaiter<DCJEHMPEJID<BKMAHJDMJAP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x87E9C40", Offset = "0x87E8240", VA = "0x1887E9C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x87EA170", Offset = "0x87E8770", VA = "0x1887EA170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct BDNNKPANOPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<FANMKCKHALG<BKMAHJDMJAP, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public APMACCODNHK <>4__this;

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
		public KAAJMKIPCGE roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<DCJEHMPEJID<BKMAHJDMJAP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x87E7FE0", Offset = "0x87E65E0", VA = "0x1887E7FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x87E8580", Offset = "0x87E6B80", VA = "0x1887E8580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LEFACKOIMGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<FANMKCKHALG<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public APMACCODNHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private BKMAHJDMJAP <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<CPMCKEPMDCL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x87EB020", Offset = "0x87E9620", VA = "0x1887EB020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x87EB570", Offset = "0x87E9B70", VA = "0x1887EB570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OFLLMLGMICL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<List<EIIKOFCPIKO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public APMACCODNHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<DCJEHMPEJID<List<EIIKOFCPIKO>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x87EC320", Offset = "0x87EA920", VA = "0x1887EC320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x87EC720", Offset = "0x87EAD20", VA = "0x1887EC720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct AALPACBGBJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public APMACCODNHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public KNOJHPOMDED player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x87E35D0", Offset = "0x87E1BD0", VA = "0x1887E35D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x87E3970", Offset = "0x87E1F70", VA = "0x1887E3970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct FDPAKPHBPPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<FANMKCKHALG<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public APMACCODNHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public BKMAHJDMJAP roomOffer;

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
		private TaskAwaiter<FANMKCKHALG<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x87E8D90", Offset = "0x87E7390", VA = "0x1887E8D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x87E92E0", Offset = "0x87E78E0", VA = "0x1887E92E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PEBCOOFOCKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<FANMKCKHALG<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public APMACCODNHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public BKMAHJDMJAP roomOffer;

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
		private EFFKGLIBDGP <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private GHIOCBKPEID <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<GHIOCBKPEID> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x87EC790", Offset = "0x87EAD90", VA = "0x1887EC790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x87ED0C0", Offset = "0x87EB6C0", VA = "0x1887ED0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class HDFHAOMOKMP
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
			public HDFHAOMOKMP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x87ED130", Offset = "0x87EB730", VA = "0x1887ED130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x87ED4B0", Offset = "0x87EBAB0", VA = "0x1887ED4B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public APMACCODNHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public HDFHAOMOKMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x87E9A30", Offset = "0x87E8030", VA = "0x1887E9A30")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task OEBOLDIIJPB(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x87E9B20", Offset = "0x87E8120", VA = "0x1887E9B20")]
		internal Guid? OLOCCPIKPEF(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct LEFKKKHILKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<GHIOCBKPEID> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public APMACCODNHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public BKMAHJDMJAP roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private HDFHAOMOKMP <>8__1;

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
		private TaskAwaiter<GHIOCBKPEID> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x87EB5E0", Offset = "0x87E9BE0", VA = "0x1887EB5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x87EC2B0", Offset = "0x87EA8B0", VA = "0x1887EC2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct INHLPEGBCPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public APMACCODNHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<DCJEHMPEJID<List<LOCINLJJMIF>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<List<BKMAHJDMJAP>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<DCJEHMPEJID<List<LOCINLJJMIF>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x87EA1E0", Offset = "0x87E87E0", VA = "0x1887EA1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x87EA9E0", Offset = "0x87E8FE0", VA = "0x1887EA9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GFLMCIBMLJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public APMACCODNHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x87E9350", Offset = "0x87E7950", VA = "0x1887E9350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x87E99D0", Offset = "0x87E7FD0", VA = "0x1887E99D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct JDAAOHIKHPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public APMACCODNHK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public KNOJHPOMDED player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x87EAA40", Offset = "0x87E9040", VA = "0x1887EAA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x87EAFB0", Offset = "0x87E95B0", VA = "0x1887EAFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan BGFPIKCLGGD;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string OFPIOMLLKHH = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string GMHAHEHCEAG = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string CBLJDCIHPMO = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly APDMPDLKNJD JEIMHECLLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly KGLNFLBOGCL LKEODHIEGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly JELPDIKCIAE PLDGHDIDEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly JLBKHMODKCK AHHPFJAALPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly MBOPCPOPDEN PBPODKBNIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly EBIGFMMOMOE LDLCGFNCGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HEDMPJKIOJM ACIHABPADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HEBPNCEICFJ GAOKNDBMPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly KKLMHFHACEF APMJPFKJFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly IJMNBIIDPGK LDADKFPMBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly DJILHFGKPFH FAHGFNJKDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> ICPJFEKIKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable PJBEMMGJLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task CPCMIBMACMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource ABNCMBOOHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long ANDIIHMBGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool DNDJADKEJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly DIACAADJDCL PPHJJJHEFJB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private EOCBGCJHMLH EGKLIIJKNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87E3CA0", Offset = "0x87E22A0", VA = "0x1887E3CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LGEBFGGIOJB ENCIMEHFBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAB0BF0", Offset = "0xAAF1F0", VA = "0x180AB0BF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xF26510", Offset = "0xF24B10", VA = "0x180F26510", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IAJLDMLJHLB<BKMAHJDMJAP> DOKDIAAIAIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA51E60", Offset = "0xA50460", VA = "0x180A51E60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA51EE0", Offset = "0xA504E0", VA = "0x180A51EE0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IAJLDMLJHLB<Guid> BMLBDMHKNLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xE23A60", Offset = "0xE22060", VA = "0x180E23A60", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xF2B480", Offset = "0xF29A80", VA = "0x180F2B480", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x87E68C0", Offset = "0x87E4EC0", VA = "0x1887E68C0")]
	[BNHIEDNKDNA.PMDFMFCJKCH.JJHNPGAJPOD]
	internal static void ODEMOKCFLLI(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x87E78A0", Offset = "0x87E5EA0", VA = "0x1887E78A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public APMACCODNHK([GGNLMCAPMLP(null)] APDMPDLKNJD JEIMHECLLCN, [GGNLMCAPMLP(null)] KGLNFLBOGCL LKEODHIEGIG, [GGNLMCAPMLP(null)] NHGJFNPGAOK PDHGMIGEJPA, [GGNLMCAPMLP(null)] JELPDIKCIAE PLDGHDIDEGN, [GGNLMCAPMLP(null)] GLJBBABAEJH FOIBJICKBCC, [GGNLMCAPMLP(null)] JLBKHMODKCK AHHPFJAALPD, [GGNLMCAPMLP("ShowPurchasePromptRateLimiter")] MBOPCPOPDEN PBPODKBNIPE, [GGNLMCAPMLP(null)] EBIGFMMOMOE LDLCGFNCGFO, [GGNLMCAPMLP(null)] JKFGCIPHBEE GKMGJHMCGOE, [GGNLMCAPMLP(null)] HEDMPJKIOJM ACIHABPADPI, [GGNLMCAPMLP(null)] HEBPNCEICFJ GAOKNDBMPHK, [GGNLMCAPMLP(null)] KKLMHFHACEF APMJPFKJFAC, [GGNLMCAPMLP(null)] IJMNBIIDPGK LDADKFPMBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x87E4510", Offset = "0x87E2B10", VA = "0x1887E4510", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x87E61E0", Offset = "0x87E47E0", VA = "0x1887E61E0", Slot = "10")]
	[AsyncStateMachine(typeof(IINKFDFLEGI))]
	public Task<FANMKCKHALG<BKMAHJDMJAP, string>> LLILJLDIMAG(Guid? HOOANKBDJBP, long CDFGHIILPDC, string IEDAJGLJHNI, string LCNJPNDEDOK, string ODEILPPIMEL, int ADABADLFLPA, KAAJMKIPCGE ILIOHJMEADC, [Optional] Dictionary<Guid, int> GNGHGFGEADM, [Optional] Guid? AAEJFJPOPAP, bool MOJOKPGGIIO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x87E5F00", Offset = "0x87E4500", VA = "0x1887E5F00", Slot = "11")]
	[AsyncStateMachine(typeof(BDNNKPANOPJ))]
	public Task<FANMKCKHALG<BKMAHJDMJAP, string>> KKILAPGDJGI(Guid PPGDDDBFCDJ, long CDFGHIILPDC, string IEDAJGLJHNI, string LCNJPNDEDOK, string ODEILPPIMEL, int ADABADLFLPA, KAAJMKIPCGE ILIOHJMEADC, [Optional] Dictionary<Guid, int> GNGHGFGEADM, [Optional] Guid? AAEJFJPOPAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x87E5790", Offset = "0x87E3D90", VA = "0x1887E5790", Slot = "12")]
	[AsyncStateMachine(typeof(LEFACKOIMGD))]
	public Task<FANMKCKHALG<bool, string>> JGLJJIKPLCM(Guid PALCNBNANLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x87E6B80", Offset = "0x87E5180", VA = "0x1887E6B80", Slot = "13")]
	public IEnumerable<BKMAHJDMJAP> ONIJKCIDPOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x87E4790", Offset = "0x87E2D90", VA = "0x1887E4790", Slot = "14")]
	[AsyncStateMachine(typeof(OFLLMLGMICL))]
	public Task<List<EIIKOFCPIKO>> EBEHAIDEDAJ(long CDFGHIILPDC, [Optional] CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x87E4E20", Offset = "0x87E3420", VA = "0x1887E4E20", Slot = "17")]
	public bool GCOFBFHAOON(Guid PALCNBNANLC, int OLAJDDDJHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x87E6F90", Offset = "0x87E5590", VA = "0x1887E6F90", Slot = "15")]
	public bool PMMFKBMLDLL(Guid PALCNBNANLC, [Out] BKMAHJDMJAP EDCGNNNPCEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x87E58B0", Offset = "0x87E3EB0", VA = "0x1887E58B0", Slot = "16")]
	public bool KFLBODCPECJ(string IEDAJGLJHNI, [Out] BKMAHJDMJAP EDCGNNNPCEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x87E4B60", Offset = "0x87E3160", VA = "0x1887E4B60", Slot = "18")]
	public void FKCPMJMMHGK(KNOJHPOMDED OPOGJMFOAFI, Guid PALCNBNANLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x87E5650", Offset = "0x87E3C50", VA = "0x1887E5650", Slot = "19")]
	[AsyncStateMachine(typeof(AALPACBGBJN))]
	public Task<int> INPHLEOMNKD(KNOJHPOMDED OPOGJMFOAFI, Guid PALCNBNANLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x87E4D40", Offset = "0x87E3340", VA = "0x1887E4D40", Slot = "20")]
	public bool GACJMCCBJJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x87E50F0", Offset = "0x87E36F0", VA = "0x1887E50F0", Slot = "21")]
	public bool HEFDOCEHDCK(Guid JOJHBPOKKFC, [Out] List<string> CGBFMCHAOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x87E6760", Offset = "0x87E4D60", VA = "0x1887E6760", Slot = "22")]
	[AsyncStateMachine(typeof(FDPAKPHBPPI))]
	public Task<FANMKCKHALG<bool, string>> NHFJDCEEEII(BKMAHJDMJAP EDCGNNNPCEB, long HONKDHANCMN, int DGLKMMKHDMO, string BLCCOCPGKOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x87E54F0", Offset = "0x87E3AF0", VA = "0x1887E54F0")]
	[AsyncStateMachine(typeof(PEBCOOFOCKE))]
	private Task<FANMKCKHALG<bool, string>> IIMHCAFEMNH(BKMAHJDMJAP EDCGNNNPCEB, long HONKDHANCMN, long DBAGFPAEKIF, string BLCCOCPGKOD, int DGLKMMKHDMO = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x87E6A20", Offset = "0x87E5020", VA = "0x1887E6A20")]
	[AsyncStateMachine(typeof(LEFKKKHILKM))]
	private Task<GHIOCBKPEID> ONABKGLFKGF(BKMAHJDMJAP EDCGNNNPCEB, int DGLKMMKHDMO, int HONKDHANCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x87E7070", Offset = "0x87E5670", VA = "0x1887E7070")]
	private bool PPEHNFNGIDJ(IEnumerable<BELLDAECLLK> NKGGHDBJPGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x87E6390", Offset = "0x87E4990", VA = "0x1887E6390")]
	private void MOCKPGMPKLO(BKMAHJDMJAP EDCGNNNPCEB, long DBAGFPAEKIF, int DGLKMMKHDMO, string BLCCOCPGKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x87E40A0", Offset = "0x87E26A0", VA = "0x1887E40A0")]
	private string CGKLFFGMBFM(BKMAHJDMJAP EDCGNNNPCEB, int DGLKMMKHDMO, string BLCCOCPGKOD, [Optional] EFFKGLIBDGP? HPCDHGHHCOO, [Optional] OCFCHOIJOAE? DLBJJCMALMG, [Optional] string PNKPIBPIKFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x87E48C0", Offset = "0x87E2EC0", VA = "0x1887E48C0")]
	private EFFKGLIBDGP FJADIODLLAO(BKMAHJDMJAP DKIODFINHKA, int LDJMDFPALII, [Out] long DBAGFPAEKIF)
	{
		return default(EFFKGLIBDGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x87E3B90", Offset = "0x87E2190", VA = "0x1887E3B90")]
	[AsyncStateMachine(typeof(INHLPEGBCPO))]
	private Task BKNDHDHBALA(long CDFGHIILPDC, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x87E5B10", Offset = "0x87E4110", VA = "0x1887E5B10")]
	private Task KHPDGIINFPC(JBAPOOINJKO MMCAOMENGOP, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x87E5020", Offset = "0x87E3620", VA = "0x1887E5020")]
	[AsyncStateMachine(typeof(GFLMCIBMLJK))]
	private Task GDPGJNFPBGE(JBAPOOINJKO MMCAOMENGOP, CancellationToken DDDLJOAMOKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x87E6C30", Offset = "0x87E5230", VA = "0x1887E6C30")]
	private static Dictionary<Guid, int> PIMABNFEFNH(DCJEHMPEJID<List<LOCINLJJMIF>> CKNNLLBMAAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x87E3A50", Offset = "0x87E2050", VA = "0x1887E3A50")]
	private void BELBACGLJAN(BKMAHJDMJAP EDCGNNNPCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x87E4300", Offset = "0x87E2900", VA = "0x1887E4300")]
	private void DNJNLCICIAK(Guid PALCNBNANLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x87E7640", Offset = "0x87E5C40", VA = "0x1887E7640")]
	[ECMJPLLGIBK]
	internal void RpcOfferShowPurchasePrompt(Guid PALCNBNANLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x87E60A0", Offset = "0x87E46A0", VA = "0x1887E60A0")]
	[AsyncStateMachine(typeof(JDAAOHIKHPK))]
	private Task<int> KPCMJMHKIAJ(KNOJHPOMDED OPOGJMFOAFI, Guid JOJHBPOKKFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x87E7450", Offset = "0x87E5A50", VA = "0x1887E7450")]
	[ECMJPLLGIBK]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid HOFBFGLIONA, Guid PALCNBNANLC, BHNKNAFMDAL FGCEFPKBOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x87E73D0", Offset = "0x87E59D0", VA = "0x1887E73D0")]
	[ECMJPLLGIBK]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid HOFBFGLIONA, int FOAMCIPOLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x87E3CF0", Offset = "0x87E22F0", VA = "0x1887E3CF0", Slot = "24")]
	public string CDENMAMIOCI(EFFKGLIBDGP HPCDHGHHCOO, [Optional] OCFCHOIJOAE? DEOLBLHNOAD, [Optional] BalanceResponseDTO DLNKKJLHJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x87E6930", Offset = "0x87E4F30", VA = "0x1887E6930")]
	private static string OEMDKJEMBCN(OCFCHOIJOAE DEOLBLHNOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x87E4370", Offset = "0x87E2970", VA = "0x1887E4370")]
	private BKMAHJDMJAP DOMDCGBEFAB(BKMAHJDMJAP CJPGLBKEBBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x87E39E0", Offset = "0x87E1FE0", VA = "0x1887E39E0")]
	private void AEJCGMDFHLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x87E3A60", Offset = "0x87E2060", VA = "0x1887E3A60")]
	private void BKLNOJLIMJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class DJILHFGKPFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Guid, BKMAHJDMJAP> BBCMOCJMBOF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long HAHFIFLNJLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xD23850", Offset = "0xD21E50", VA = "0x180D23850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x87E88E0", Offset = "0x87E6EE0", VA = "0x1887E88E0")]
	public void JIOLDFMGEJI(long CDFGHIILPDC, IEnumerable<BKMAHJDMJAP> GDGDPAPMALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x87E8BB0", Offset = "0x87E71B0", VA = "0x1887E8BB0")]
	public bool MNGKPJLMEFM(Guid PALCNBNANLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x87E8720", Offset = "0x87E6D20", VA = "0x1887E8720")]
	public bool BAFGFGCDOJB(Guid PALCNBNANLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x87E8780", Offset = "0x87E6D80", VA = "0x1887E8780")]
	public bool BIINIBEBMNC(BKMAHJDMJAP KMANEICEHOJ, [Out] BKMAHJDMJAP GAGDDFHMMGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x87E8B60", Offset = "0x87E7160", VA = "0x1887E8B60")]
	public IEnumerable<BKMAHJDMJAP> MLNCJNNGEGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x87E8C90", Offset = "0x87E7290", VA = "0x1887E8C90")]
	public bool PMMFKBMLDLL(Guid PALCNBNANLC, [Out] BKMAHJDMJAP EDCGNNNPCEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x87E8C10", Offset = "0x87E7210", VA = "0x1887E8C10")]
	private bool NGPNJGEKNHK(BKMAHJDMJAP FHKIBFJAKOF, BKMAHJDMJAP LCIJJPPIHFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x87E8D00", Offset = "0x87E7300", VA = "0x1887E8D00")]
	public DJILHFGKPFH()
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
