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
		[Cpp2IlInjected.Address(RVA = "0x8CDA770", Offset = "0x8CD8D70", VA = "0x188CDA770", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2960290", Offset = "0x295E890", VA = "0x182960290")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BPOINFNEGCE : KNGDHPIKOPB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IGIIFNBAGJJ KGEPLNMJHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GDNFKFILPGE
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBGBNAEFBAM DBNFGLJCLPP();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KDHFHNKJBJB : GDNFKFILPGE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8CD8C40", Offset = "0x8CD7240", VA = "0x188CD8C40")]
	[LAFCEDCMNGK.LDGLOLCMPLF.AALIAIEKGHF]
	internal static void AAICCAKCFCJ(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KDHFHNKJBJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8CD8CB0", Offset = "0x8CD72B0", VA = "0x188CD8CB0", Slot = "4")]
	public DBGBNAEFBAM DBNFGLJCLPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[KALHGBCMMAN]
public class IGIIFNBAGJJ : LNFNJDOJPKA, IDisposable, CFFOJIANONK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BDOBBJOMPFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<PKAAAAMEMEI<OIBEPGAIAEK, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public IGIIFNBAGJJ <>4__this;

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
		public PNEONIGCEOA roomOfferType;

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
		private TaskAwaiter<JPPKKBJBENK<OIBEPGAIAEK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8CD0F10", Offset = "0x8CCF510", VA = "0x188CD0F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8CD1440", Offset = "0x8CCFA40", VA = "0x188CD1440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct OPCFNBMJIIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<PKAAAAMEMEI<OIBEPGAIAEK, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public IGIIFNBAGJJ <>4__this;

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
		public PNEONIGCEOA roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<JPPKKBJBENK<OIBEPGAIAEK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9D80", Offset = "0x8CD8380", VA = "0x188CD9D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8CDA320", Offset = "0x8CD8920", VA = "0x188CDA320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LBCLKGADFOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<PKAAAAMEMEI<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public IGIIFNBAGJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private OIBEPGAIAEK <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<HEFFBECLBFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8CD8D70", Offset = "0x8CD7370", VA = "0x188CD8D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8CD92C0", Offset = "0x8CD78C0", VA = "0x188CD92C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OEJNEGODKMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<List<DMDIJFCNNDF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public IGIIFNBAGJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<JPPKKBJBENK<List<DMDIJFCNNDF>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9910", Offset = "0x8CD7F10", VA = "0x188CD9910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9D10", Offset = "0x8CD8310", VA = "0x188CD9D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct FJBOEDHCCGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public IGIIFNBAGJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NGPBJJLAELK player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8CD2860", Offset = "0x8CD0E60", VA = "0x188CD2860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8CD2C00", Offset = "0x8CD1200", VA = "0x188CD2C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct IALOEFMAFBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<PKAAAAMEMEI<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public IGIIFNBAGJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public OIBEPGAIAEK roomOffer;

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
		private TaskAwaiter<PKAAAAMEMEI<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3820", Offset = "0x8CD1E20", VA = "0x188CD3820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8CD3D70", Offset = "0x8CD2370", VA = "0x188CD3D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GHGJLPJLDEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<PKAAAAMEMEI<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public IGIIFNBAGJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public OIBEPGAIAEK roomOffer;

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
		private JEALKKALOOI <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private ODLEBGBKKPI <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<ODLEBGBKKPI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8CD2E80", Offset = "0x8CD1480", VA = "0x188CD2E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8CD37B0", Offset = "0x8CD1DB0", VA = "0x188CD37B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GHDPJEKAFII
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
			public GHDPJEKAFII <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8CDA390", Offset = "0x8CD8990", VA = "0x188CDA390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8CDA710", Offset = "0x8CD8D10", VA = "0x188CDA710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public IGIIFNBAGJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GHDPJEKAFII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8CD2D90", Offset = "0x8CD1390", VA = "0x188CD2D90")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task ONEADJENHAN(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8CD2C70", Offset = "0x8CD1270", VA = "0x188CD2C70")]
		internal Guid? JNHCLCDANOJ(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BKKKBPMCMKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<ODLEBGBKKPI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public IGIIFNBAGJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public OIBEPGAIAEK roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private GHDPJEKAFII <>8__1;

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
		private TaskAwaiter<ODLEBGBKKPI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8CD14B0", Offset = "0x8CCFAB0", VA = "0x188CD14B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8CD2180", Offset = "0x8CD0780", VA = "0x188CD2180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JIJFPFOHOJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public IGIIFNBAGJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<JPPKKBJBENK<List<KDOAMAFAKGG>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<List<OIBEPGAIAEK>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<JPPKKBJBENK<List<KDOAMAFAKGG>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8CD83E0", Offset = "0x8CD69E0", VA = "0x188CD83E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8CD8BE0", Offset = "0x8CD71E0", VA = "0x188CD8BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct AMFIBOPJCJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public IGIIFNBAGJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8CD0820", Offset = "0x8CCEE20", VA = "0x188CD0820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8CD0EB0", Offset = "0x8CCF4B0", VA = "0x188CD0EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct MEIPNEDOIGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public IGIIFNBAGJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public NGPBJJLAELK player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9330", Offset = "0x8CD7930", VA = "0x188CD9330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8CD98A0", Offset = "0x8CD7EA0", VA = "0x188CD98A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan NJIFPMDGKHN;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string BHGPBBKJFGH = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string IEKFJCBCGDN = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string CFHBMCLJLKO = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EFGIPPOJNJL BHFAENAEECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly JKBCGLENMDN CNMCCCKOPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly LLHIAIMDFNE JAMGLFFELKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly BDAGHMMFHLO ANHHCBNKCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly LCIELCNAEBE JFHNMDMLLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly BPOINFNEGCE OJBHHCHOBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly PGOAAPNCJHH KEBEIAGOJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly BPDOKAIBAEB IFNNBKGCHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly AHFAHDPONGL DNGKJLPAODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly OFKBELIHJJE JFEGGCBBLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly DBGBNAEFBAM CPFJPOIKECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> FIDHELBKOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable NNBOKKNDJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task CCGGLMLJBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource LIFNNNFOJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long CJCEEDDCMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool OPDBEINFGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly NLFGHGDLKKN GNEFMHLEDJP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private GKPILLDFPFO JMAJHFFOBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8CD67C0", Offset = "0x8CD4DC0", VA = "0x188CD67C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HBPNKKOKOOA GCEBJJICMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB65DA0", Offset = "0xB643A0", VA = "0x180B65DA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB65E50", Offset = "0xB64450", VA = "0x180B65E50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GJIKMKGBNOL<OIBEPGAIAEK> JCGCNNMBKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA9F180", Offset = "0xA9D780", VA = "0x180A9F180", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA9F110", Offset = "0xA9D710", VA = "0x180A9F110", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GJIKMKGBNOL<Guid> BLHDJBDEFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB66230", Offset = "0xB64830", VA = "0x180B66230", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB66210", Offset = "0xB64810", VA = "0x180B66210", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8CD3DE0", Offset = "0x8CD23E0", VA = "0x188CD3DE0")]
	[LAFCEDCMNGK.LDGLOLCMPLF.AALIAIEKGHF]
	internal static void AAICCAKCFCJ(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8CD7CA0", Offset = "0x8CD62A0", VA = "0x188CD7CA0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IGIIFNBAGJJ([OEKMEJFDAAI(null)] EFGIPPOJNJL BHFAENAEECM, [OEKMEJFDAAI(null)] JKBCGLENMDN CNMCCCKOPKA, [OEKMEJFDAAI(null)] KMNENFMKNHB OPOFAOLMBIH, [OEKMEJFDAAI(null)] LLHIAIMDFNE JAMGLFFELKA, [OEKMEJFDAAI(null)] GDNFKFILPGE BKGOJGJEDKA, [OEKMEJFDAAI(null)] BDAGHMMFHLO ANHHCBNKCPG, [OEKMEJFDAAI("ShowPurchasePromptRateLimiter")] LCIELCNAEBE JFHNMDMLLEA, [OEKMEJFDAAI(null)] BPOINFNEGCE OJBHHCHOBHF, [OEKMEJFDAAI(null)] DFDHDICEODK HHKNIPLAADF, [OEKMEJFDAAI(null)] PGOAAPNCJHH KEBEIAGOJJF, [OEKMEJFDAAI(null)] BPDOKAIBAEB IFNNBKGCHPJ, [OEKMEJFDAAI(null)] AHFAHDPONGL DNGKJLPAODJ, [OEKMEJFDAAI(null)] OFKBELIHJJE JFEGGCBBLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8CD4D60", Offset = "0x8CD3360", VA = "0x188CD4D60", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8CD6270", Offset = "0x8CD4870", VA = "0x188CD6270", Slot = "10")]
	[AsyncStateMachine(typeof(BDOBBJOMPFI))]
	public Task<PKAAAAMEMEI<OIBEPGAIAEK, string>> JIEOCFAAFFL(Guid? GFKCOHLNPGF, long PANGCFBNCCJ, string DJFMCHMDHGK, string OINDFPIKPLL, string IFCAGKLINAN, int NCCILLFFLEP, PNEONIGCEOA MMAOMOIFICI, [Optional] Dictionary<Guid, int> GOPCCCHKNPA, [Optional] Guid? PFEOIFBFCBF, bool LKBFHKBPJDF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8CD60D0", Offset = "0x8CD46D0", VA = "0x188CD60D0", Slot = "11")]
	[AsyncStateMachine(typeof(OPCFNBMJIIO))]
	public Task<PKAAAAMEMEI<OIBEPGAIAEK, string>> JBLHEJLLNPC(Guid IHPOFPCDFAB, long PANGCFBNCCJ, string DJFMCHMDHGK, string OINDFPIKPLL, string IFCAGKLINAN, int NCCILLFFLEP, PNEONIGCEOA MMAOMOIFICI, [Optional] Dictionary<Guid, int> GOPCCCHKNPA, [Optional] Guid? PFEOIFBFCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8CD7550", Offset = "0x8CD5B50", VA = "0x188CD7550", Slot = "12")]
	[AsyncStateMachine(typeof(LBCLKGADFOP))]
	public Task<PKAAAAMEMEI<bool, string>> PCODDOBJICP(Guid GALGPMNHKBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8CD47A0", Offset = "0x8CD2DA0", VA = "0x188CD47A0", Slot = "13")]
	public IEnumerable<OIBEPGAIAEK> DCJFMPFNGMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8CD5510", Offset = "0x8CD3B10", VA = "0x188CD5510", Slot = "14")]
	[AsyncStateMachine(typeof(OEJNEGODKMI))]
	public Task<List<DMDIJFCNNDF>> ENIDGNCAOJF(long PANGCFBNCCJ, [Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8CD6420", Offset = "0x8CD4A20", VA = "0x188CD6420", Slot = "17")]
	public bool JKAIJHMMEKO(Guid GALGPMNHKBA, int ACGKICNNLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8CD6E80", Offset = "0x8CD5480", VA = "0x188CD6E80", Slot = "15")]
	public bool MFHAEHKJNEA(Guid GALGPMNHKBA, [Out] OIBEPGAIAEK BAJOCKKOHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8CD5240", Offset = "0x8CD3840", VA = "0x188CD5240", Slot = "16")]
	public bool EJEGLNAPKDB(string DJFMCHMDHGK, [Out] OIBEPGAIAEK BAJOCKKOHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8CD5AF0", Offset = "0x8CD40F0", VA = "0x188CD5AF0", Slot = "18")]
	public void HPLKGEOANBN(NGPBJJLAELK LIOICDJHFAF, Guid GALGPMNHKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8CD59B0", Offset = "0x8CD3FB0", VA = "0x188CD59B0", Slot = "19")]
	[AsyncStateMachine(typeof(FJBOEDHCCGI))]
	public Task<int> HDAPDJMFEHO(NGPBJJLAELK LIOICDJHFAF, Guid GALGPMNHKBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8CD6F60", Offset = "0x8CD5560", VA = "0x188CD6F60", Slot = "20")]
	public bool MKMEIPIDLLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8CD5CD0", Offset = "0x8CD42D0", VA = "0x188CD5CD0", Slot = "21")]
	public bool IGMEGCPCLBE(Guid GMHMECEEJFO, [Out] List<string> LAMNELEEBCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8CD4850", Offset = "0x8CD2E50", VA = "0x188CD4850", Slot = "22")]
	[AsyncStateMachine(typeof(IALOEFMAFBK))]
	public Task<PKAAAAMEMEI<bool, string>> DJKOILNPFHG(OIBEPGAIAEK BAJOCKKOHKL, long AAAJLJAAJIM, int DKCPHNPHHEP, string MPACIGPIGOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8CD7670", Offset = "0x8CD5C70", VA = "0x188CD7670")]
	[AsyncStateMachine(typeof(GHGJLPJLDEB))]
	private Task<PKAAAAMEMEI<bool, string>> PKPIBDFKLCB(OIBEPGAIAEK BAJOCKKOHKL, long AAAJLJAAJIM, long DMGOEHBHBMD, string MPACIGPIGOI, int DKCPHNPHHEP = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8CD5850", Offset = "0x8CD3E50", VA = "0x188CD5850")]
	[AsyncStateMachine(typeof(BKKKBPMCMKJ))]
	private Task<ODLEBGBKKPI> GJIMOJPOBPA(OIBEPGAIAEK BAJOCKKOHKL, int DKCPHNPHHEP, int AAAJLJAAJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8CD6810", Offset = "0x8CD4E10", VA = "0x188CD6810")]
	private bool KOFBBKGMCBM(IEnumerable<POJIMGKOIHD> FDJIKGJBPBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8CD41B0", Offset = "0x8CD27B0", VA = "0x188CD41B0")]
	private void CHNOGBKLNEA(OIBEPGAIAEK BAJOCKKOHKL, long DMGOEHBHBMD, int DKCPHNPHHEP, string MPACIGPIGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8CD4FE0", Offset = "0x8CD35E0", VA = "0x188CD4FE0")]
	private string EENICIJBEEO(OIBEPGAIAEK BAJOCKKOHKL, int DKCPHNPHHEP, string MPACIGPIGOI, [Optional] JEALKKALOOI? CENCPMGPALN, [Optional] HJJLKPHCDEI? AHDPJEBGEJL, [Optional] string MBJPNEBKBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8CD6BE0", Offset = "0x8CD51E0", VA = "0x188CD6BE0")]
	private JEALKKALOOI LPHPIEKKCJK(OIBEPGAIAEK JJFJGABOLMI, int FLKFIAAKNLK, [Out] long DMGOEHBHBMD)
	{
		return default(JEALKKALOOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8CD7440", Offset = "0x8CD5A40", VA = "0x188CD7440")]
	[AsyncStateMachine(typeof(JIJFPFOHOJG))]
	private Task ONIEJNLEKFJ(long PANGCFBNCCJ, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8CD7050", Offset = "0x8CD5650", VA = "0x188CD7050")]
	private Task MPOMOBLEBBH(IJFCDEBIONC KGIPMLMDBBA, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8CD5780", Offset = "0x8CD3D80", VA = "0x188CD5780")]
	[AsyncStateMachine(typeof(AMFIBOPJCJL))]
	private Task GIGFBPMMLLJ(IJFCDEBIONC KGIPMLMDBBA, CancellationToken IACNBGJHPIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8CD3E50", Offset = "0x8CD2450", VA = "0x188CD3E50")]
	private static Dictionary<Guid, int> BBMJFNBMNJA(JPPKKBJBENK<List<KDOAMAFAKGG>> MLJPNJINCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8CD7040", Offset = "0x8CD5640", VA = "0x188CD7040")]
	private void MMNACLHCBOI(OIBEPGAIAEK BAJOCKKOHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8CD6B70", Offset = "0x8CD5170", VA = "0x188CD6B70")]
	private void LEIECKLCNGA(Guid GALGPMNHKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8CD7A40", Offset = "0x8CD6040", VA = "0x188CD7A40")]
	[DNODEMNIJIG]
	internal void RpcOfferShowPurchasePrompt(Guid GALGPMNHKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8CD5640", Offset = "0x8CD3C40", VA = "0x188CD5640")]
	[AsyncStateMachine(typeof(MEIPNEDOIGF))]
	private Task<int> GGGODMBEICB(NGPBJJLAELK LIOICDJHFAF, Guid GMHMECEEJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8CD7850", Offset = "0x8CD5E50", VA = "0x188CD7850")]
	[DNODEMNIJIG]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid HEHCIJKCGOH, Guid GALGPMNHKBA, HGNFDBOJKMF AFDLHEFMFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8CD77D0", Offset = "0x8CD5DD0", VA = "0x188CD77D0")]
	[DNODEMNIJIG]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid HEHCIJKCGOH, int FEEKNNBMJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8CD49B0", Offset = "0x8CD2FB0", VA = "0x188CD49B0", Slot = "24")]
	public string DLDDDBHAMDP(JEALKKALOOI CENCPMGPALN, [Optional] HJJLKPHCDEI? NGPLEKFFEDM, [Optional] BalanceResponseDTO BEIKDBBLFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8CD4580", Offset = "0x8CD2B80", VA = "0x188CD4580")]
	private static string CNKKLLKDJLC(HJJLKPHCDEI NGPLEKFFEDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8CD6620", Offset = "0x8CD4C20", VA = "0x188CD6620")]
	private OIBEPGAIAEK KHLNAOPGDJB(OIBEPGAIAEK PLNJBGDGHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8CD54A0", Offset = "0x8CD3AA0", VA = "0x188CD54A0")]
	private void ENGPLEMNNNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8CD4670", Offset = "0x8CD2C70", VA = "0x188CD4670")]
	private void CPNHICEFMBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class DBGBNAEFBAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Guid, OIBEPGAIAEK> GMBMBGKOJIH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long CLONBIJNLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xDF1050", Offset = "0xDEF650", VA = "0x180DF1050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8CD2460", Offset = "0x8CD0A60", VA = "0x188CD2460")]
	public void IBEJBIDOMAJ(long PANGCFBNCCJ, IEnumerable<OIBEPGAIAEK> PKBCCKFMOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8CD21F0", Offset = "0x8CD07F0", VA = "0x188CD21F0")]
	public bool BDPEFOCNKCO(Guid GALGPMNHKBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8CD2400", Offset = "0x8CD0A00", VA = "0x188CD2400")]
	public bool HCDNAOEAAEJ(Guid GALGPMNHKBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8CD22A0", Offset = "0x8CD08A0", VA = "0x188CD22A0")]
	public bool EOBPBBNLAAA(OIBEPGAIAEK OCGOFLBPOME, [Out] OIBEPGAIAEK MANKCKCACIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8CD2250", Offset = "0x8CD0850", VA = "0x188CD2250")]
	public IEnumerable<OIBEPGAIAEK> CMEOBPJANGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8CD2760", Offset = "0x8CD0D60", VA = "0x188CD2760")]
	public bool MFHAEHKJNEA(Guid GALGPMNHKBA, [Out] OIBEPGAIAEK BAJOCKKOHKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8CD26E0", Offset = "0x8CD0CE0", VA = "0x188CD26E0")]
	private bool INEEGCHECPM(OIBEPGAIAEK BDPHCAGFJCP, OIBEPGAIAEK GDHICCHEJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8CD27D0", Offset = "0x8CD0DD0", VA = "0x188CD27D0")]
	public DBGBNAEFBAM()
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
