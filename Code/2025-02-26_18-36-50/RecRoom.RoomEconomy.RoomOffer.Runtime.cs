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
		[Cpp2IlInjected.Address(RVA = "0x7BE8FA0", Offset = "0x7BE83A0", VA = "0x187BE8FA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OEDBMDLMBGK : ODDELBGIKND
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OLCCLMAPPMJ KGICBMOFFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LFPDHDMKNHH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GLEPLGCPCBB OOIGEFPFHJO();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KFKEBPJMNLB : LFPDHDMKNHH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3820", Offset = "0x7BE2C20", VA = "0x187BE3820")]
	[HLOHOCOKELO.CMBCHPAFDOL.DIAIOJMELDA]
	internal static void APJICGAGHJP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KFKEBPJMNLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3890", Offset = "0x7BE2C90", VA = "0x187BE3890", Slot = "4")]
	public GLEPLGCPCBB OOIGEFPFHJO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GAFKBMEFLIK]
public class OLCCLMAPPMJ : FKAEIDJNCEP, IDisposable, MDLPCNOGCPG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct EFPLDGBEPKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<DODDCJEJIJO, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public OLCCLMAPPMJ <>4__this;

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
		public IMKINNKMHEJ roomOfferType;

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
		private TaskAwaiter<KPFEEGNDCMA<DODDCJEJIJO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BE0FD0", Offset = "0x7BE03D0", VA = "0x187BE0FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1500", Offset = "0x7BE0900", VA = "0x187BE1500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct CFPPGBBDKIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<DODDCJEJIJO, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public OLCCLMAPPMJ <>4__this;

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
		public IMKINNKMHEJ roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<KPFEEGNDCMA<DODDCJEJIJO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF880", Offset = "0x7BDEC80", VA = "0x187BDF880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFE20", Offset = "0x7BDF220", VA = "0x187BDFE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct AIPGGGJDFFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public OLCCLMAPPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private DODDCJEJIJO <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<NMFBNOKMHMI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF0A0", Offset = "0x7BDE4A0", VA = "0x187BDF0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF600", Offset = "0x7BDEA00", VA = "0x187BDF600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HNBFCFBIEOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<List<NFBHKEMNDMD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public OLCCLMAPPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<KPFEEGNDCMA<List<NFBHKEMNDMD>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2A10", Offset = "0x7BE1E10", VA = "0x187BE2A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2E10", Offset = "0x7BE2210", VA = "0x187BE2E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct CIBJCIKFIFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public OLCCLMAPPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public OPHKANJGPPK player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFE90", Offset = "0x7BDF290", VA = "0x187BDFE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7BE0230", Offset = "0x7BDF630", VA = "0x187BE0230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct OGNCNBKPBKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public OLCCLMAPPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public DODDCJEJIJO roomOffer;

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
		private TaskAwaiter<JOFBNNGKBOO<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7BE3950", Offset = "0x7BE2D50", VA = "0x187BE3950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7BE3EA0", Offset = "0x7BE32A0", VA = "0x187BE3EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct IMLDBPPCIIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<JOFBNNGKBOO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public OLCCLMAPPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public DODDCJEJIJO roomOffer;

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
		private BPDJMAOHOKM <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private JEDMKKPEOHA <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<JEDMKKPEOHA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2E80", Offset = "0x7BE2280", VA = "0x187BE2E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7BE37B0", Offset = "0x7BE2BB0", VA = "0x187BE37B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class ALFHLGGJLFH
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
			public ALFHLGGJLFH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7BE8BD0", Offset = "0x7BE7FD0", VA = "0x187BE8BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7BE8F40", Offset = "0x7BE8340", VA = "0x187BE8F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public OLCCLMAPPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public ALFHLGGJLFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF670", Offset = "0x7BDEA70", VA = "0x187BDF670")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task CHMBPABGABB(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF760", Offset = "0x7BDEB60", VA = "0x187BDF760")]
		internal Guid? LBIBBAKGBNN(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct DAEJJFAAKBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<JEDMKKPEOHA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public OLCCLMAPPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public DODDCJEJIJO roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private ALFHLGGJLFH <>8__1;

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
		private TaskAwaiter<JEDMKKPEOHA> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7BE02A0", Offset = "0x7BDF6A0", VA = "0x187BE02A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7BE0F60", Offset = "0x7BE0360", VA = "0x187BE0F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct ENFOHDEDGDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public OLCCLMAPPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<KPFEEGNDCMA<List<PAIOOIPKOMF>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<List<DODDCJEJIJO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<KPFEEGNDCMA<List<PAIOOIPKOMF>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1570", Offset = "0x7BE0970", VA = "0x187BE1570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1D60", Offset = "0x7BE1160", VA = "0x187BE1D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct PKGMPMLAIMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public OLCCLMAPPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7BE84F0", Offset = "0x7BE78F0", VA = "0x187BE84F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7BE8B70", Offset = "0x7BE7F70", VA = "0x187BE8B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct EOAMKCOMBAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public OLCCLMAPPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public OPHKANJGPPK player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1DC0", Offset = "0x7BE11C0", VA = "0x187BE1DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2320", Offset = "0x7BE1720", VA = "0x187BE2320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan GFDAKCPANDK;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string GDHJKBECIPF = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string OFHIKIGAJIA = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string CKLPCLHICMH = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NOADOIFMNAP KPEDACAFAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly MLOAEAIKDOJ DPHPELFNJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CJMPOIBABDA EPLBJILLFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly CHDNBFGGGBI DIKLELHCODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly BKFMNGCFFLF CJMHIILJAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly OEDBMDLMBGK PONMJLLJPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GDEKDCGGALI MOKEOOADLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HELJKBNOMFB MOHMFJKJHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly KLHECNJFMMO AOMNFIDCDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly AKPEKCLMGOC JJFLHFANALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly GLEPLGCPCBB LJFDNGABGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> KENCGICNILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable JIDFKEHHBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task KPCFKHCMOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource HPHDDNCNMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long EAKMAMNMCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool NLNPPHMOFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly BKCMCEPPHLB GFNOIIJOLMK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private FEIBBEGPEJJ BFJDNIICDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BE7210", Offset = "0x7BE6610", VA = "0x187BE7210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FKDOIPNGGAF GCIMKCJGCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB83C50", Offset = "0xB83050", VA = "0x180B83C50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCDF050", Offset = "0xCDE450", VA = "0x180CDF050", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JKOOBLENGDB<DODDCJEJIJO> HDLOICPPHNO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x94E950", Offset = "0x94DD50", VA = "0x18094E950", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x94E910", Offset = "0x94DD10", VA = "0x18094E910", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JKOOBLENGDB<Guid> MCDLFIBODIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAB50D0", Offset = "0xAB44D0", VA = "0x180AB50D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xCF2C30", Offset = "0xCF2030", VA = "0x180CF2C30", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3F10", Offset = "0x7BE3310", VA = "0x187BE3F10")]
	[HLOHOCOKELO.CMBCHPAFDOL.DIAIOJMELDA]
	internal static void APJICGAGHJP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7DC0", Offset = "0x7BE71C0", VA = "0x187BE7DC0")]
	[RecRoom.NoEngine.Common.Preserve]
	public OLCCLMAPPMJ([IBJCGEMJMJL(null)] NOADOIFMNAP KPEDACAFAJP, [IBJCGEMJMJL(null)] MLOAEAIKDOJ DPHPELFNJFC, [IBJCGEMJMJL(null)] DMBDJAPHJEC LINBCANIEFD, [IBJCGEMJMJL(null)] CJMPOIBABDA EPLBJILLFJM, [IBJCGEMJMJL(null)] LFPDHDMKNHH AGHNCJHJAKP, [IBJCGEMJMJL(null)] CHDNBFGGGBI DIKLELHCODJ, [IBJCGEMJMJL("ShowPurchasePromptRateLimiter")] BKFMNGCFFLF CJMHIILJAOE, [IBJCGEMJMJL(null)] OEDBMDLMBGK PONMJLLJPNE, [IBJCGEMJMJL(null)] IHHNFNMOFKD KONMDIJEPAF, [IBJCGEMJMJL(null)] GDEKDCGGALI MOKEOOADLAP, [IBJCGEMJMJL(null)] HELJKBNOMFB MOHMFJKJHIL, [IBJCGEMJMJL(null)] KLHECNJFMMO AOMNFIDCDEK, [IBJCGEMJMJL(null)] AKPEKCLMGOC JJFLHFANALH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7BE4860", Offset = "0x7BE3C60", VA = "0x187BE4860", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6B80", Offset = "0x7BE5F80", VA = "0x187BE6B80", Slot = "10")]
	[AsyncStateMachine(typeof(EFPLDGBEPKK))]
	public Task<JOFBNNGKBOO<DODDCJEJIJO, string>> NDDNHHDHAHH(Guid? AHJIJCMJHIE, long FFFLOIOFAMB, string OMOOEGOLALI, string GPFCOHGCDPH, string BDFBPKBBNAC, int NFIEGBLLAIP, IMKINNKMHEJ BDANMKJLEOI, [Optional] Dictionary<Guid, int> AGEIKGMLELD, [Optional] Guid? ENOIHCNANOD, bool KMKFGPIGKFG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6680", Offset = "0x7BE5A80", VA = "0x187BE6680", Slot = "11")]
	[AsyncStateMachine(typeof(CFPPGBBDKIJ))]
	public Task<JOFBNNGKBOO<DODDCJEJIJO, string>> MIFMONEGFBA(Guid NGHBPAMJBBA, long FFFLOIOFAMB, string OMOOEGOLALI, string GPFCOHGCDPH, string BDFBPKBBNAC, int NFIEGBLLAIP, IMKINNKMHEJ BDANMKJLEOI, [Optional] Dictionary<Guid, int> AGEIKGMLELD, [Optional] Guid? ENOIHCNANOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5420", Offset = "0x7BE4820", VA = "0x187BE5420", Slot = "12")]
	[AsyncStateMachine(typeof(AIPGGGJDFFN))]
	public Task<JOFBNNGKBOO<bool, string>> IHGDKGBJKBG(Guid PJGBKLENCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5D10", Offset = "0x7BE5110", VA = "0x187BE5D10", Slot = "13")]
	public IEnumerable<DODDCJEJIJO> KPBLAMNNGJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7BE52F0", Offset = "0x7BE46F0", VA = "0x187BE52F0", Slot = "14")]
	[AsyncStateMachine(typeof(HNBFCFBIEOH))]
	public Task<List<NFBHKEMNDMD>> IAGNOICMEAC(long FFFLOIOFAMB, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7BE4D70", Offset = "0x7BE4170", VA = "0x187BE4D70", Slot = "17")]
	public bool HIFECMDHHFI(Guid PJGBKLENCGC, int PKPMOAGKBFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7120", Offset = "0x7BE6520", VA = "0x187BE7120", Slot = "15")]
	public bool NIGIGPOCIAD(Guid PJGBKLENCGC, [Out] DODDCJEJIJO LBGNNMKOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3F80", Offset = "0x7BE3380", VA = "0x187BE3F80", Slot = "16")]
	public bool BHLELDLKMEP(string OMOOEGOLALI, [Out] DODDCJEJIJO LBGNNMKOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5110", Offset = "0x7BE4510", VA = "0x187BE5110", Slot = "18")]
	public void HOPAALKJKEH(OPHKANJGPPK OEIBHCOIKMG, Guid PJGBKLENCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7BE57D0", Offset = "0x7BE4BD0", VA = "0x187BE57D0", Slot = "19")]
	[AsyncStateMachine(typeof(CIBJCIKFIFG))]
	public Task<int> JKGEDPGBOLG(OPHKANJGPPK OEIBHCOIKMG, Guid PJGBKLENCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7BE56F0", Offset = "0x7BE4AF0", VA = "0x187BE56F0", Slot = "20")]
	public bool JCJMJFJHJBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5ED0", Offset = "0x7BE52D0", VA = "0x187BE5ED0", Slot = "21")]
	public bool LLILDPOEDLI(Guid NHMBBGCGEGI, [Out] List<string> EAIAEKFLKNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7BE4C10", Offset = "0x7BE4010", VA = "0x187BE4C10", Slot = "22")]
	[AsyncStateMachine(typeof(OGNCNBKPBKJ))]
	public Task<JOFBNNGKBOO<bool, string>> FNANIIFMGDC(DODDCJEJIJO LBGNNMKOLFI, long ODPGPODGLMG, int IAKJCHAJGGI, string MBBMFJLOHJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5BB0", Offset = "0x7BE4FB0", VA = "0x187BE5BB0")]
	[AsyncStateMachine(typeof(IMLDBPPCIIF))]
	private Task<JOFBNNGKBOO<bool, string>> KONDIFBMGKF(DODDCJEJIJO LBGNNMKOLFI, long ODPGPODGLMG, long EKHGBODBJDL, string MBBMFJLOHJL, int IAKJCHAJGGI = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7720", Offset = "0x7BE6B20", VA = "0x187BE7720")]
	[AsyncStateMachine(typeof(DAEJJFAAKBM))]
	private Task<JEDMKKPEOHA> PCPJFIKJJFM(DODDCJEJIJO LBGNNMKOLFI, int IAKJCHAJGGI, int ODPGPODGLMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7BE4440", Offset = "0x7BE3840", VA = "0x187BE4440")]
	private bool CLEKPENGCLN(IEnumerable<GJLNEEJFHPJ> GALGLJKDDKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7350", Offset = "0x7BE6750", VA = "0x187BE7350")]
	private void OAOGGJBFFMA(DODDCJEJIJO LBGNNMKOLFI, long EKHGBODBJDL, int IAKJCHAJGGI, string MBBMFJLOHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7BE41E0", Offset = "0x7BE35E0", VA = "0x187BE41E0")]
	private string BJMJNNBLAIM(DODDCJEJIJO LBGNNMKOLFI, int IAKJCHAJGGI, string MBBMFJLOHJL, [Optional] BPDJMAOHOKM? BIEIOPPGBOB, [Optional] PCIIKHIKNGP? OOEEBDOFDCP, [Optional] string PAPHMNICBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5910", Offset = "0x7BE4D10", VA = "0x187BE5910")]
	private BPDJMAOHOKM KAKKAABBAOL(DODDCJEJIJO JMGPDDHJEMO, int AAPJOEMEFHO, [Out] long EKHGBODBJDL)
	{
		return default(BPDJMAOHOKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5DC0", Offset = "0x7BE51C0", VA = "0x187BE5DC0")]
	[AsyncStateMachine(typeof(ENFOHDEDGDM))]
	private Task LDIAPNPDAKG(long FFFLOIOFAMB, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6D30", Offset = "0x7BE6130", VA = "0x187BE6D30")]
	private Task NHOHFFGDLIA(BPPINHJEEIJ JIEBKPCGKFF, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BE4790", Offset = "0x7BE3B90", VA = "0x187BE4790")]
	[AsyncStateMachine(typeof(PKGMPMLAIMF))]
	private Task DDONGCKGGEF(BPPINHJEEIJ JIEBKPCGKFF, CancellationToken CJCEGMIOLKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6820", Offset = "0x7BE5C20", VA = "0x187BE6820")]
	private static Dictionary<Guid, int> MKHMMHBPNLP(KPFEEGNDCMA<List<PAIOOIPKOMF>> BDDOAGDCPGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7200", Offset = "0x7BE6600", VA = "0x187BE7200")]
	private void NLJPHMIJFGN(DODDCJEJIJO LBGNNMKOLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5540", Offset = "0x7BE4940", VA = "0x187BE5540")]
	private void IJPKLHMOIIJ(Guid PJGBKLENCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7B60", Offset = "0x7BE6F60", VA = "0x187BE7B60")]
	[NMPKCFGNPNG]
	internal void RpcOfferShowPurchasePrompt(Guid PJGBKLENCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7BE55B0", Offset = "0x7BE49B0", VA = "0x187BE55B0")]
	[AsyncStateMachine(typeof(EOAMKCOMBAC))]
	private Task<int> IKGAHFAJNGA(OPHKANJGPPK OEIBHCOIKMG, Guid NHMBBGCGEGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7970", Offset = "0x7BE6D70", VA = "0x187BE7970")]
	[NMPKCFGNPNG]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid EHMIFANHMPO, Guid PJGBKLENCGC, AGBOLFFNJKA MKJPICMBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7BE78F0", Offset = "0x7BE6CF0", VA = "0x187BE78F0")]
	[NMPKCFGNPNG]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid EHMIFANHMPO, int BBEJNKBNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7BE62D0", Offset = "0x7BE56D0", VA = "0x187BE62D0", Slot = "24")]
	public string MAIGKNOBEFK(BPDJMAOHOKM BIEIOPPGBOB, [Optional] PCIIKHIKNGP? OAHNNHFLFHB, [Optional] BalanceResponseDTO GFCLHPOECFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7260", Offset = "0x7BE6660", VA = "0x187BE7260")]
	private static string OAFFGMLFDMO(PCIIKHIKNGP OAHNNHFLFHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7BE4F70", Offset = "0x7BE4370", VA = "0x187BE4F70")]
	private DODDCJEJIJO HKLDJCLFEIB(DODDCJEJIJO ALHHFJAOPJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7880", Offset = "0x7BE6C80", VA = "0x187BE7880")]
	private void PKHDLIKLAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7BE4AE0", Offset = "0x7BE3EE0", VA = "0x187BE4AE0")]
	private void EBAMKFFPAJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class GLEPLGCPCBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Guid, DODDCJEJIJO> HIDLDGNDFHN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long MBHFNFGPIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xAEB120", Offset = "0xAEA520", VA = "0x180AEB120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7BE24F0", Offset = "0x7BE18F0", VA = "0x187BE24F0")]
	public void DMHMECMJAEH(long FFFLOIOFAMB, IEnumerable<DODDCJEJIJO> HABKFPHIOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7BE27D0", Offset = "0x7BE1BD0", VA = "0x187BE27D0")]
	public bool LIHAHIPDFNG(Guid PJGBKLENCGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7BE28A0", Offset = "0x7BE1CA0", VA = "0x187BE28A0")]
	public bool OCDDHDAHAOD(Guid PJGBKLENCGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2390", Offset = "0x7BE1790", VA = "0x187BE2390")]
	public bool CLNGCDDGMPM(DODDCJEJIJO IDPPPPAIEPE, [Out] DODDCJEJIJO INKNGICMEMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2780", Offset = "0x7BE1B80", VA = "0x187BE2780")]
	public IEnumerable<DODDCJEJIJO> EFDIJOEBDHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2830", Offset = "0x7BE1C30", VA = "0x187BE2830")]
	public bool NIGIGPOCIAD(Guid PJGBKLENCGC, [Out] DODDCJEJIJO LBGNNMKOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2900", Offset = "0x7BE1D00", VA = "0x187BE2900")]
	private bool OKCPKOODDKM(DODDCJEJIJO IOCKBOOECEL, DODDCJEJIJO FOAKCJPCPOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2980", Offset = "0x7BE1D80", VA = "0x187BE2980")]
	public GLEPLGCPCBB()
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
