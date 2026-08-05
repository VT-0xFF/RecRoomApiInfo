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
		[Cpp2IlInjected.Address(RVA = "0x8BE9210", Offset = "0x8BE8010", VA = "0x188BE9210", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FDJPLAMNGCO : LMIHLDGOBGN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GNPEFALKFIM KKPLDNEHAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ALDFBMFOMML
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OINLBGMHNIO KJKPHNDKGGE();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HHCFAIMLJOB : ALDFBMFOMML
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8BE6900", Offset = "0x8BE5700", VA = "0x188BE6900")]
	[NKOKDPHOKEP.EPFIDDHPHJC.MBGBOEIIBBL]
	internal static void DBCFEKMBJDE(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	[RecRoom.NoEngine.Common.Preserve]
	public HHCFAIMLJOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8BE6970", Offset = "0x8BE5770", VA = "0x188BE6970", Slot = "4")]
	public OINLBGMHNIO KJKPHNDKGGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CMNOLHHFBOP]
public class GNPEFALKFIM : EELLIEFDBBK, IDisposable, PCOBGDPJCFP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct KGOEACOLKJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<KJFALBFOFBC, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public GNPEFALKFIM <>4__this;

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
		public MNMKIIAAPGL roomOfferType;

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
		private TaskAwaiter<NMBCNJBJCJP<KJFALBFOFBC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8BE7C00", Offset = "0x8BE6A00", VA = "0x188BE7C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8BE8130", Offset = "0x8BE6F30", VA = "0x188BE8130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct LCEGBAAJDKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<KJFALBFOFBC, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public GNPEFALKFIM <>4__this;

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
		public MNMKIIAAPGL roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<NMBCNJBJCJP<KJFALBFOFBC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8BE81A0", Offset = "0x8BE6FA0", VA = "0x188BE81A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8BE8740", Offset = "0x8BE7540", VA = "0x188BE8740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BLODKGKEMLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public GNPEFALKFIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private KJFALBFOFBC <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<KNPLFMAGNCA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8BDFB50", Offset = "0x8BDE950", VA = "0x188BDFB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8BE00B0", Offset = "0x8BDEEB0", VA = "0x188BE00B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CAAOMNHGBLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<List<FPEIDHIENDF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public GNPEFALKFIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<NMBCNJBJCJP<List<FPEIDHIENDF>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8BE0120", Offset = "0x8BDEF20", VA = "0x188BE0120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8BE0520", Offset = "0x8BDF320", VA = "0x188BE0520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct IONLGJGGIIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public GNPEFALKFIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AFLCFHLHEHB player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8BE77F0", Offset = "0x8BE65F0", VA = "0x188BE77F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8BE7B90", Offset = "0x8BE6990", VA = "0x188BE7B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct IGJHHEFIPLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public GNPEFALKFIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public KJFALBFOFBC roomOffer;

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
		private TaskAwaiter<GECIHKBMECG<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE7020", Offset = "0x8BE5E20", VA = "0x188BE7020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8BE7570", Offset = "0x8BE6370", VA = "0x188BE7570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GNMEBMDGEJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public GNPEFALKFIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public KJFALBFOFBC roomOffer;

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
		private GJACPBFIJDC <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private KPEHGONECBE <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<KPEHGONECBE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8BE0C60", Offset = "0x8BDFA60", VA = "0x188BE0C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8BE1590", Offset = "0x8BE0390", VA = "0x188BE1590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class IOFJJIPNDLI
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
			public IOFJJIPNDLI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8BE8E30", Offset = "0x8BE7C30", VA = "0x188BE8E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8BE91B0", Offset = "0x8BE7FB0", VA = "0x188BE91B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public GNPEFALKFIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public IOFJJIPNDLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8BE75E0", Offset = "0x8BE63E0", VA = "0x188BE75E0")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task LAAFAMHCIAL(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8BE76D0", Offset = "0x8BE64D0", VA = "0x188BE76D0")]
		internal Guid? MDLACFDNNGD(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GOFEOCHLAPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<KPEHGONECBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public GNPEFALKFIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public KJFALBFOFBC roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private IOFJJIPNDLI <>8__1;

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
		private TaskAwaiter<KPEHGONECBE> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5BB0", Offset = "0x8BE49B0", VA = "0x188BE5BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8BE6890", Offset = "0x8BE5690", VA = "0x188BE6890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct AHBNOAAALBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public GNPEFALKFIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<NMBCNJBJCJP<List<FCJGBKEEDPO>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<List<KJFALBFOFBC>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<NMBCNJBJCJP<List<FCJGBKEEDPO>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8BDF300", Offset = "0x8BDE100", VA = "0x188BDF300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8BDFAF0", Offset = "0x8BDE8F0", VA = "0x188BDFAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FLEPIDNFJPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public GNPEFALKFIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8BE0590", Offset = "0x8BDF390", VA = "0x188BE0590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8BE0C00", Offset = "0x8BDFA00", VA = "0x188BE0C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct IEPHDNBABDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GNPEFALKFIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public AFLCFHLHEHB player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8BE6A30", Offset = "0x8BE5830", VA = "0x188BE6A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE6FB0", Offset = "0x8BE5DB0", VA = "0x188BE6FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan OMIKGNKLHHC;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string DMDDJPDBBDH = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string GHDANECHLPB = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string MHHJKMNCIEB = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IOACKABALCD AGJDKHDNEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly ALDABFJJHPA PEMLCPKPDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly KCDOBEOKNFA JBGDKEJCOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly HCNPPOOIDEE PCFBHCOALKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly OKBAHHLOHBD FOEJGBNOPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly FDJPLAMNGCO GKAMOCFNHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DHFKBBHLBNI OLPMMDDOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly KCDGNBKAIKC KAAKFPIIIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly KIBCJDIOIPA HHJGKIGNEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JKNHGMAKBCG NBMKMDBDJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly OINLBGMHNIO LCLFIOEIKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> OMDOBIEBJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable JPKGBGIAJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task LGILJAAFNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource PGNLLMJGBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long FNPPOPDJLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool JAABGCKHGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly LJPHCNLDGIM KLAHBKJOFNF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private OAHJJJLMEEF AGDANODEHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8BE2820", Offset = "0x8BE1620", VA = "0x188BE2820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MKAEDPHCCBC PBEIPCEAAHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB631C0", Offset = "0xB61FC0", VA = "0x180B631C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB635F0", Offset = "0xB623F0", VA = "0x180B635F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GBCEOPMAPJH<KJFALBFOFBC> COOKANBGMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAA3060", Offset = "0xAA1E60", VA = "0x180AA3060", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA1F20", VA = "0x180AA3120", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GBCEOPMAPJH<Guid> IEPCKPFGAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB631D0", Offset = "0xB61FD0", VA = "0x180B631D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB633B0", Offset = "0xB621B0", VA = "0x180B633B0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8BE2660", Offset = "0x8BE1460", VA = "0x188BE2660")]
	[NKOKDPHOKEP.EPFIDDHPHJC.MBGBOEIIBBL]
	internal static void DBCFEKMBJDE(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8BE5490", Offset = "0x8BE4290", VA = "0x188BE5490")]
	[RecRoom.NoEngine.Common.Preserve]
	public GNPEFALKFIM([POMNKOCGGBN(null)] IOACKABALCD AGJDKHDNEJM, [POMNKOCGGBN(null)] ALDABFJJHPA PEMLCPKPDLB, [POMNKOCGGBN(null)] NFGFJOGJHBJ IMHHOFCJJBO, [POMNKOCGGBN(null)] KCDOBEOKNFA JBGDKEJCOFK, [POMNKOCGGBN(null)] ALDFBMFOMML PNJCOJLLHGH, [POMNKOCGGBN(null)] HCNPPOOIDEE PCFBHCOALKL, [POMNKOCGGBN("ShowPurchasePromptRateLimiter")] OKBAHHLOHBD FOEJGBNOPAB, [POMNKOCGGBN(null)] FDJPLAMNGCO GKAMOCFNHCI, [POMNKOCGGBN(null)] IJPADAEDIMJ KLOFCILPHMC, [POMNKOCGGBN(null)] DHFKBBHLBNI OLPMMDDOCOO, [POMNKOCGGBN(null)] KCDGNBKAIKC KAAKFPIIIMP, [POMNKOCGGBN(null)] KIBCJDIOIPA HHJGKIGNEEF, [POMNKOCGGBN(null)] JKNHGMAKBCG NBMKMDBDJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8BE2FB0", Offset = "0x8BE1DB0", VA = "0x188BE2FB0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8BE24B0", Offset = "0x8BE12B0", VA = "0x188BE24B0", Slot = "10")]
	[AsyncStateMachine(typeof(KGOEACOLKJG))]
	public Task<GECIHKBMECG<KJFALBFOFBC, string>> CMEONHOKOMF(Guid? LHMBOGGFNPO, long MDNJLMOPJKG, string PFLDDMDPCBI, string CDEPGINEGKG, string ECFOLMEBCEO, int CEKHJIDJMLP, MNMKIIAAPGL DCKGHDHCKEH, [Optional] Dictionary<Guid, int> GNKMEBHDFDO, [Optional] Guid? DAFPKFMJMHM, bool GLOBDHAMDBI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8BE1A90", Offset = "0x8BE0890", VA = "0x188BE1A90", Slot = "11")]
	[AsyncStateMachine(typeof(LCEGBAAJDKK))]
	public Task<GECIHKBMECG<KJFALBFOFBC, string>> AKPMFACHIBL(Guid GJIFBNOCMLB, long MDNJLMOPJKG, string PFLDDMDPCBI, string CDEPGINEGKG, string ECFOLMEBCEO, int CEKHJIDJMLP, MNMKIIAAPGL DCKGHDHCKEH, [Optional] Dictionary<Guid, int> GNKMEBHDFDO, [Optional] Guid? DAFPKFMJMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4530", Offset = "0x8BE3330", VA = "0x188BE4530", Slot = "12")]
	[AsyncStateMachine(typeof(BLODKGKEMLO))]
	public Task<GECIHKBMECG<bool, string>> JPKECNEJMGM(Guid NDGAKOGJINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4650", Offset = "0x8BE3450", VA = "0x188BE4650", Slot = "13")]
	public IEnumerable<KJFALBFOFBC> KFACGEIKKBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8BE1960", Offset = "0x8BE0760", VA = "0x188BE1960", Slot = "14")]
	[AsyncStateMachine(typeof(CAAOMNHGBLE))]
	public Task<List<FPEIDHIENDF>> AHPICCELPCB(long MDNJLMOPJKG, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8BE1760", Offset = "0x8BE0560", VA = "0x188BE1760", Slot = "17")]
	public bool AFCIBHGPKIB(Guid NDGAKOGJINE, int CKLGEGKFMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8BE2740", Offset = "0x8BE1540", VA = "0x188BE2740", Slot = "15")]
	public bool DIMEEPFGHED(Guid NDGAKOGJINE, [Out] KJFALBFOFBC GDAIHJFICLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8BE3780", Offset = "0x8BE2580", VA = "0x188BE3780", Slot = "16")]
	public bool EOPADDPLKJH(string PFLDDMDPCBI, [Out] KJFALBFOFBC GDAIHJFICLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8BE3210", Offset = "0x8BE2010", VA = "0x188BE3210", Slot = "18")]
	public void EIHIONAAGOJ(AFLCFHLHEHB GLMBLPAKFLM, Guid NDGAKOGJINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8BE3AC0", Offset = "0x8BE28C0", VA = "0x188BE3AC0", Slot = "19")]
	[AsyncStateMachine(typeof(IONLGJGGIIK))]
	public Task<int> IEBEBGAFOPC(AFLCFHLHEHB GLMBLPAKFLM, Guid NDGAKOGJINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8BE39E0", Offset = "0x8BE27E0", VA = "0x188BE39E0", Slot = "20")]
	public bool GILGGMPNKGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4130", Offset = "0x8BE2F30", VA = "0x188BE4130", Slot = "21")]
	public bool JMNDAHNOIBM(Guid ENEOEDNPCBA, [Out] List<string> LCMMAHMNNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8BE3FD0", Offset = "0x8BE2DD0", VA = "0x188BE3FD0", Slot = "22")]
	[AsyncStateMachine(typeof(IGJHHEFIPLN))]
	public Task<GECIHKBMECG<bool, string>> JGINAJCLAGM(KJFALBFOFBC GDAIHJFICLN, long FHHAGIABJGI, int EBABNKEEAMD, string AHKPOJAALAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8BE1600", Offset = "0x8BE0400", VA = "0x188BE1600")]
	[AsyncStateMachine(typeof(GNMEBMDGEJH))]
	private Task<GECIHKBMECG<bool, string>> ABDELLFALNI(KJFALBFOFBC GDAIHJFICLN, long FHHAGIABJGI, long FILDMNEGHCH, string AHKPOJAALAJ, int EBABNKEEAMD = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8BE1FE0", Offset = "0x8BE0DE0", VA = "0x188BE1FE0")]
	[AsyncStateMachine(typeof(GOFEOCHLAPM))]
	private Task<KPEHGONECBE> BCBOIHLFNDL(KJFALBFOFBC GDAIHJFICLN, int EBABNKEEAMD, int FHHAGIABJGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8BE2C50", Offset = "0x8BE1A50", VA = "0x188BE2C50")]
	private bool DPKBCJOKGOH(IEnumerable<COAABHJIMMF> BHLCFIOIDKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8BE3C00", Offset = "0x8BE2A00", VA = "0x188BE3C00")]
	private void JBNNDFOIJGP(KJFALBFOFBC GDAIHJFICLN, long FILDMNEGHCH, int EBABNKEEAMD, string AHKPOJAALAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8BE3530", Offset = "0x8BE2330", VA = "0x188BE3530")]
	private string EOHNEOHLLDA(KJFALBFOFBC GDAIHJFICLN, int EBABNKEEAMD, string AHKPOJAALAJ, [Optional] GJACPBFIJDC? MOBFLOHJOKJ, [Optional] IJNABNOAHHD? ANEGPHPEOAD, [Optional] string CMGPAGPPOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8BE2210", Offset = "0x8BE1010", VA = "0x188BE2210")]
	private GJACPBFIJDC CFOGMELPHFG(KJFALBFOFBC IBGPMKKINBG, int GEGAFPGHMBK, [Out] long FILDMNEGHCH)
	{
		return default(GJACPBFIJDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4870", Offset = "0x8BE3670", VA = "0x188BE4870")]
	[AsyncStateMachine(typeof(AHBNOAAALBD))]
	private Task OKEJKFGFIPI(long MDNJLMOPJKG, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8BE2870", Offset = "0x8BE1670", VA = "0x188BE2870")]
	private Task DKHOENOPGGE(CHNMCCPJHLL NPIEBNDMCBK, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8BE2140", Offset = "0x8BE0F40", VA = "0x188BE2140")]
	[AsyncStateMachine(typeof(FLEPIDNFJPJ))]
	private Task BFJNLPHEFGD(CHNMCCPJHLL NPIEBNDMCBK, CancellationToken OLHLFCKNILO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4AB0", Offset = "0x8BE38B0", VA = "0x188BE4AB0")]
	private static Dictionary<Guid, int> PBGOOMHDHGD(NMBCNJBJCJP<List<FCJGBKEEDPO>> LFAMHHHHADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4700", Offset = "0x8BE3500", VA = "0x188BE4700")]
	private void LMFDGHBMMMA(KJFALBFOFBC GDAIHJFICLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8BE26D0", Offset = "0x8BE14D0", VA = "0x188BE26D0")]
	private void DGFNKAJNHJO(Guid NDGAKOGJINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8BE5220", Offset = "0x8BE4020", VA = "0x188BE5220")]
	[HMNKOIHOGHH]
	internal void RpcOfferShowPurchasePrompt(Guid NDGAKOGJINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8BE33F0", Offset = "0x8BE21F0", VA = "0x188BE33F0")]
	[AsyncStateMachine(typeof(IEPHDNBABDF))]
	private Task<int> EKAELAEMNDA(AFLCFHLHEHB GLMBLPAKFLM, Guid ENEOEDNPCBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8BE5030", Offset = "0x8BE3E30", VA = "0x188BE5030")]
	[HMNKOIHOGHH]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid ECLLBKCDLFA, Guid NDGAKOGJINE, PDCFLIPGAOH NLCAIENELJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4FB0", Offset = "0x8BE3DB0", VA = "0x188BE4FB0")]
	[HMNKOIHOGHH]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid ECLLBKCDLFA, int FFKCBONKOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8BE1C30", Offset = "0x8BE0A30", VA = "0x188BE1C30", Slot = "24")]
	public string ALMCNGNLFFB(GJACPBFIJDC MOBFLOHJOKJ, [Optional] IJNABNOAHHD? FBPKPKJJEGN, [Optional] BalanceResponseDTO DMGNKKLMFHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4710", Offset = "0x8BE3510", VA = "0x188BE4710")]
	private static string MPHCFJBGBJB(IJNABNOAHHD FBPKPKJJEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4E10", Offset = "0x8BE3C10", VA = "0x188BE4E10")]
	private KJFALBFOFBC PKCIGGMDDCM(KJFALBFOFBC LMJDFLKIALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4800", Offset = "0x8BE3600", VA = "0x188BE4800")]
	private void NKIKGNPBLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8BE4980", Offset = "0x8BE3780", VA = "0x188BE4980")]
	private void OLMPLEOANLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class OINLBGMHNIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Guid, KJFALBFOFBC> FAJIBAIPGCN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long PCLKEPGGEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xE04750", Offset = "0xE03550", VA = "0x180E04750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8BE8820", Offset = "0x8BE7620", VA = "0x188BE8820")]
	public void GLIIHCMJEBC(long MDNJLMOPJKG, IEnumerable<KJFALBFOFBC> HIJLELAFENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8BE8C60", Offset = "0x8BE7A60", VA = "0x188BE8C60")]
	public bool LFLGDEPOFFI(Guid NDGAKOGJINE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8BE8CC0", Offset = "0x8BE7AC0", VA = "0x188BE8CC0")]
	public bool MDNHCHGJFLC(Guid NDGAKOGJINE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8BE8AB0", Offset = "0x8BE78B0", VA = "0x188BE8AB0")]
	public bool IFKEJOEMJKM(KJFALBFOFBC NJMIBEOKHPM, [Out] KJFALBFOFBC KHGIAPFNPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8BE8C10", Offset = "0x8BE7A10", VA = "0x188BE8C10")]
	public IEnumerable<KJFALBFOFBC> JJNLKMLOBAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8BE87B0", Offset = "0x8BE75B0", VA = "0x188BE87B0")]
	public bool DIMEEPFGHED(Guid NDGAKOGJINE, [Out] KJFALBFOFBC GDAIHJFICLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8BE8D20", Offset = "0x8BE7B20", VA = "0x188BE8D20")]
	private bool MNNJJKJCKIN(KJFALBFOFBC GNOMIJMEGAG, KJFALBFOFBC FIBPLJJCBHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8BE8DA0", Offset = "0x8BE7BA0", VA = "0x188BE8DA0")]
	public OINLBGMHNIO()
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
