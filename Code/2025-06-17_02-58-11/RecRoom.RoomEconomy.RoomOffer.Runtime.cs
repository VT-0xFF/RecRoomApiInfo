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
		[Cpp2IlInjected.Address(RVA = "0x8574120", Offset = "0x8572B20", VA = "0x188574120", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CEBCFIDOIKI : NLMJAOEOIFN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EAGGHHGPAHE GMLDLNNFKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ANPMBDOHBDL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CHFAHLKHNLP PENBJNNJGAH();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class APJHNGLGAMK : ANPMBDOHBDL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x856AF10", Offset = "0x8569910", VA = "0x18856AF10")]
	[CGLGNCLDKHN.DMOOKONHNLA.CCDNIDCBBNI]
	internal static void NBDHNJGHJEB(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public APJHNGLGAMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x856AF80", Offset = "0x8569980", VA = "0x18856AF80", Slot = "4")]
	public CHFAHLKHNLP PENBJNNJGAH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NHPBPJDIEFG]
public class EAGGHHGPAHE : CHPDJMKJBEO, IDisposable, GFGJDKEOOAN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct JHNDICNCBOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<KAFLOHEKGBO<JHOPIHFFCBF, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public EAGGHHGPAHE <>4__this;

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
		public EDBKPBIOJKN roomOfferType;

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
		private TaskAwaiter<BBLLLANGIKP<JHOPIHFFCBF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85729F0", Offset = "0x85713F0", VA = "0x1885729F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8572F20", Offset = "0x8571920", VA = "0x188572F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct DDMHOMAFLID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<KAFLOHEKGBO<JHOPIHFFCBF, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public EAGGHHGPAHE <>4__this;

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
		public EDBKPBIOJKN roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<BBLLLANGIKP<JHOPIHFFCBF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x856BE80", Offset = "0x856A880", VA = "0x18856BE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x856C420", Offset = "0x856AE20", VA = "0x18856C420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct EIOMFDLEAAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<KAFLOHEKGBO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public EAGGHHGPAHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private JHOPIHFFCBF <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<PDJIKHEPAMC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8570A30", Offset = "0x856F430", VA = "0x188570A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8570F80", Offset = "0x856F980", VA = "0x188570F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct IHKPNPNFDMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<List<HCFNPOEHDFA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public EAGGHHGPAHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<BBLLLANGIKP<List<HCFNPOEHDFA>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8572580", Offset = "0x8570F80", VA = "0x188572580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8572980", Offset = "0x8571380", VA = "0x188572980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct LJFAKMNPOGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public EAGGHHGPAHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public GBDECDHLMJN player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8573930", Offset = "0x8572330", VA = "0x188573930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8573CD0", Offset = "0x85726D0", VA = "0x188573CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct BHKMEILJBKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<KAFLOHEKGBO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public EAGGHHGPAHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public JHOPIHFFCBF roomOffer;

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
		private TaskAwaiter<KAFLOHEKGBO<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x856B040", Offset = "0x8569A40", VA = "0x18856B040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x856B590", Offset = "0x8569F90", VA = "0x18856B590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JJMEFBHMHDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<KAFLOHEKGBO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public EAGGHHGPAHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public JHOPIHFFCBF roomOffer;

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
		private JNFLMCENDMB <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private GHAFIFLELAF <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<GHAFIFLELAF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8572F90", Offset = "0x8571990", VA = "0x188572F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85738C0", Offset = "0x85722C0", VA = "0x1885738C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class BNMBGHPDMEP
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
			public BNMBGHPDMEP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8573D40", Offset = "0x8572740", VA = "0x188573D40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x85740C0", Offset = "0x8572AC0", VA = "0x1885740C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public EAGGHHGPAHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BNMBGHPDMEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x856B720", Offset = "0x856A120", VA = "0x18856B720")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task MKGFHKKBCFD(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x856B600", Offset = "0x856A000", VA = "0x18856B600")]
		internal Guid? KDICLOHPPCB(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HELHDEHONBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<GHAFIFLELAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public EAGGHHGPAHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public JHOPIHFFCBF roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private BNMBGHPDMEP <>8__1;

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
		private TaskAwaiter<GHAFIFLELAF> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8570FF0", Offset = "0x856F9F0", VA = "0x188570FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8571CC0", Offset = "0x85706C0", VA = "0x188571CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IDCKCALNKBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public EAGGHHGPAHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<BBLLLANGIKP<List<OIDHGBBGJEL>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<List<JHOPIHFFCBF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<BBLLLANGIKP<List<OIDHGBBGJEL>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8571D30", Offset = "0x8570730", VA = "0x188571D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8572520", Offset = "0x8570F20", VA = "0x188572520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct AODGGPCCPMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public EAGGHHGPAHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x856A260", Offset = "0x8568C60", VA = "0x18856A260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x856A8D0", Offset = "0x85692D0", VA = "0x18856A8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct AOEOEJAOOFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public EAGGHHGPAHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public GBDECDHLMJN player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x856A930", Offset = "0x8569330", VA = "0x18856A930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x856AEA0", Offset = "0x85698A0", VA = "0x18856AEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan CGAKNPKJOPG;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string KPDJNGGFBNJ = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string PJFFKLDLPAB = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string MBGFHPLMNOB = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MAFIDHOLINM KACGNBFOAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly HFFIGAJJBDA EMKDIFAFLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly MJMPJPKPIBP NICMBEDLCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly NDICJCLBPMH DGDCHCJJMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CKMOJMBJJND NAMEOOBLAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CEBCFIDOIKI FAPJELLIMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly NHFDEFKHIKO FLJMNPJIKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly GBOGIJHPIPG AKJIMCCHOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly KFPAFNJKJID JMMBHCFJMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly IECMHFBIMFA FADPPBNPFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly CHFAHLKHNLP EELBBNFIBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> NMONALECPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable GICKINDGBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task ANJGBKFICNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource LIGLJBEHCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long FKPCFHPJBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool KJMPONALMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly NIIHCNNBCPP LEPOGMELPCB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private JBKJHLPCIFD HHNKNLGOCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x856E150", Offset = "0x856CB50", VA = "0x18856E150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public CNBOOGKDGFE DIKNPMNMGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA6E630", Offset = "0xA6D030", VA = "0x180A6E630", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA87000", Offset = "0xA85A00", VA = "0x180A87000", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NBHKBEPCJOC<JHOPIHFFCBF> ADAOADBGCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3B0", Offset = "0xA0BDB0", VA = "0x180A0D3B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3C0", Offset = "0xA0BDC0", VA = "0x180A0D3C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NBHKBEPCJOC<Guid> KNCJNMNKOMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA86FF0", Offset = "0xA859F0", VA = "0x180A86FF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA871F0", Offset = "0xA85BF0", VA = "0x180A871F0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x856F480", Offset = "0x856DE80", VA = "0x18856F480")]
	[CGLGNCLDKHN.DMOOKONHNLA.CCDNIDCBBNI]
	internal static void NBDHNJGHJEB(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8570310", Offset = "0x856ED10", VA = "0x188570310")]
	[RecRoom.NoEngine.Common.Preserve]
	public EAGGHHGPAHE([CNHMBDDCGKB(null)] MAFIDHOLINM KACGNBFOAKE, [CNHMBDDCGKB(null)] HFFIGAJJBDA EMKDIFAFLKB, [CNHMBDDCGKB(null)] HEBBNJMIOCB OCGGFKMLMND, [CNHMBDDCGKB(null)] MJMPJPKPIBP NICMBEDLCJJ, [CNHMBDDCGKB(null)] ANPMBDOHBDL GIAEHCJBOEI, [CNHMBDDCGKB(null)] NDICJCLBPMH DGDCHCJJMID, [CNHMBDDCGKB("ShowPurchasePromptRateLimiter")] CKMOJMBJJND NAMEOOBLAJF, [CNHMBDDCGKB(null)] CEBCFIDOIKI FAPJELLIMID, [CNHMBDDCGKB(null)] LMOAADIJJAJ HKFFPKLNIMJ, [CNHMBDDCGKB(null)] NHFDEFKHIKO FLJMNPJIKOM, [CNHMBDDCGKB(null)] GBOGIJHPIPG AKJIMCCHOEF, [CNHMBDDCGKB(null)] KFPAFNJKJID JMMBHCFJMCL, [CNHMBDDCGKB(null)] IECMHFBIMFA FADPPBNPFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x856D1D0", Offset = "0x856BBD0", VA = "0x18856D1D0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x856C5C0", Offset = "0x856AFC0", VA = "0x18856C5C0", Slot = "10")]
	[AsyncStateMachine(typeof(JHNDICNCBOJ))]
	public Task<KAFLOHEKGBO<JHOPIHFFCBF, string>> BPFEIKMDHCI(Guid? FEMLBAPAKMP, long FHOIPEIAACP, string GBCFHNGPBLM, string NLIGMLKPGCH, string NFDALJNLFPM, int DPLKFDPKGLG, EDBKPBIOJKN LLCCMMCLGOM, [Optional] Dictionary<Guid, int> BEPBGDGKHNJ, [Optional] Guid? NMJHECJEADC, bool KGHBCGKMNJL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x856F760", Offset = "0x856E160", VA = "0x18856F760", Slot = "11")]
	[AsyncStateMachine(typeof(DDMHOMAFLID))]
	public Task<KAFLOHEKGBO<JHOPIHFFCBF, string>> NFKDDNECHFM(Guid CAKNPLJJCDO, long FHOIPEIAACP, string GBCFHNGPBLM, string NLIGMLKPGCH, string NFDALJNLFPM, int DPLKFDPKGLG, EDBKPBIOJKN LLCCMMCLGOM, [Optional] Dictionary<Guid, int> BEPBGDGKHNJ, [Optional] Guid? NMJHECJEADC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x856D600", Offset = "0x856C000", VA = "0x18856D600", Slot = "12")]
	[AsyncStateMachine(typeof(EIOMFDLEAAF))]
	public Task<KAFLOHEKGBO<bool, string>> FMFEDAOECGE(Guid BLEFGDKGHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x856E0A0", Offset = "0x856CAA0", VA = "0x18856E0A0", Slot = "13")]
	public IEnumerable<JHOPIHFFCBF> KDGNPMIMEOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x856C490", Offset = "0x856AE90", VA = "0x18856C490", Slot = "14")]
	[AsyncStateMachine(typeof(IHKPNPNFDMJ))]
	public Task<List<HCFNPOEHDFA>> ACHFJNHAJEI(long FHOIPEIAACP, [Optional] CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x856F560", Offset = "0x856DF60", VA = "0x18856F560", Slot = "17")]
	public bool NEACDAIHMNI(Guid BLEFGDKGHED, int ALPNCJFLNHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x856DC30", Offset = "0x856C630", VA = "0x18856DC30", Slot = "15")]
	public bool HMEGPMGOMOF(Guid BLEFGDKGHED, [Out] JHOPIHFFCBF ODMAJCCOOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x856DD10", Offset = "0x856C710", VA = "0x18856DD10", Slot = "16")]
	public bool ILLIMCDHDEK(string GBCFHNGPBLM, [Out] JHOPIHFFCBF ODMAJCCOOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x856C770", Offset = "0x856B170", VA = "0x18856C770", Slot = "18")]
	public void CACJOMOJKAE(GBDECDHLMJN KPIDJKLDGJJ, Guid BLEFGDKGHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x856D090", Offset = "0x856BA90", VA = "0x18856D090", Slot = "19")]
	[AsyncStateMachine(typeof(LJFAKMNPOGF))]
	public Task<int> DJGLOFNFFBK(GBDECDHLMJN KPIDJKLDGJJ, Guid BLEFGDKGHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x856CE50", Offset = "0x856B850", VA = "0x18856CE50", Slot = "20")]
	public bool CJJFIKECBPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x856ED10", Offset = "0x856D710", VA = "0x18856ED10", Slot = "21")]
	public bool MABOPCILGBK(Guid FMNCMOMIDBI, [Out] List<string> JMIJNMGPOPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x856CF30", Offset = "0x856B930", VA = "0x18856CF30", Slot = "22")]
	[AsyncStateMachine(typeof(BHKMEILJBKD))]
	public Task<KAFLOHEKGBO<bool, string>> DIAOCINAMHK(JHOPIHFFCBF ODMAJCCOOBO, long KHIJBJOADGF, int IHEMAOAJCIP, string ENPFKABEICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x856D430", Offset = "0x856BE30", VA = "0x18856D430")]
	[AsyncStateMachine(typeof(JJMEFBHMHDH))]
	private Task<KAFLOHEKGBO<bool, string>> FHALKMFAKJK(JHOPIHFFCBF ODMAJCCOOBO, long KHIJBJOADGF, long NGJPAPPEECP, string ENPFKABEICC, int IHEMAOAJCIP = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x856FCE0", Offset = "0x856E6E0", VA = "0x18856FCE0")]
	[AsyncStateMachine(typeof(HELHDEHONBC))]
	private Task<GHAFIFLELAF> NINOJPEFOFE(JHOPIHFFCBF ODMAJCCOOBO, int IHEMAOAJCIP, int KHIJBJOADGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x856CAF0", Offset = "0x856B4F0", VA = "0x18856CAF0")]
	private bool CDNICHFOGGC(IEnumerable<BFHCJMCKMFD> BMLDCGPCGLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x856D860", Offset = "0x856C260", VA = "0x18856D860")]
	private void GFBJNKBCGMP(JHOPIHFFCBF ODMAJCCOOBO, long NGJPAPPEECP, int IHEMAOAJCIP, string ENPFKABEICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x856E5F0", Offset = "0x856CFF0", VA = "0x18856E5F0")]
	private string KGCCJDCPLFB(JHOPIHFFCBF ODMAJCCOOBO, int IHEMAOAJCIP, string ENPFKABEICC, [Optional] JNFLMCENDMB? MGJNMKLFKCJ, [Optional] IJEPKJKKOIJ? BMKEHIIMKCL, [Optional] string GNNOPOKONBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x856F1E0", Offset = "0x856DBE0", VA = "0x18856F1E0")]
	private JNFLMCENDMB MJAEAOGKOIM(JHOPIHFFCBF ENMBMIHFNNH, int EDIBHGBGEOD, [Out] long NGJPAPPEECP)
	{
		return default(JNFLMCENDMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x856E840", Offset = "0x856D240", VA = "0x18856E840")]
	[AsyncStateMachine(typeof(IDCKCALNKBL))]
	private Task KJHBKFOJFGE(long FHOIPEIAACP, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x856F900", Offset = "0x856E300", VA = "0x18856F900")]
	private Task NIKAOKANDDE(JFCHLDJHBKP MPEOAHOICFG, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x856F110", Offset = "0x856DB10", VA = "0x18856F110")]
	[AsyncStateMachine(typeof(AODGGPCCPMP))]
	private Task MIKLEMABHFJ(JFCHLDJHBKP MPEOAHOICFG, CancellationToken NKNEGDHGKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x856E1A0", Offset = "0x856CBA0", VA = "0x18856E1A0")]
	private static Dictionary<Guid, int> KFGOEILBEMN(BBLLLANGIKP<List<OIDHGBBGJEL>> MNBLLKCNPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x856E950", Offset = "0x856D350", VA = "0x18856E950")]
	private void KNFJFLHGBBN(JHOPIHFFCBF ODMAJCCOOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x856F4F0", Offset = "0x856DEF0", VA = "0x18856F4F0")]
	private void NCPFBJLHIGJ(Guid BLEFGDKGHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85700B0", Offset = "0x856EAB0", VA = "0x1885700B0")]
	[PHDGLGOMNMM]
	internal void RpcOfferShowPurchasePrompt(Guid BLEFGDKGHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x856D720", Offset = "0x856C120", VA = "0x18856D720")]
	[AsyncStateMachine(typeof(AOEOEJAOOFI))]
	private Task<int> FNMAGNHLCOC(GBDECDHLMJN KPIDJKLDGJJ, Guid FMNCMOMIDBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x856FEC0", Offset = "0x856E8C0", VA = "0x18856FEC0")]
	[PHDGLGOMNMM]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid CFNOFGNKICA, Guid BLEFGDKGHED, LFDJLIAPKMA HPNFFCPPBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x856FE40", Offset = "0x856E840", VA = "0x18856FE40")]
	[PHDGLGOMNMM]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid CFNOFGNKICA, int IMCIONKBBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x856E960", Offset = "0x856D360", VA = "0x18856E960", Slot = "24")]
	public string LAOLKPFPFBG(JNFLMCENDMB MGJNMKLFKCJ, [Optional] IJEPKJKKOIJ? IAPPBCFNDKG, [Optional] BalanceResponseDTO MDMOJJLJJMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x856E500", Offset = "0x856CF00", VA = "0x18856E500")]
	private static string KFJNMHFCMPO(IJEPKJKKOIJ IAPPBCFNDKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x856C950", Offset = "0x856B350", VA = "0x18856C950")]
	private JHOPIHFFCBF CAGIMGIHBKA(JHOPIHFFCBF FMAPHBKBLLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x856D590", Offset = "0x856BF90", VA = "0x18856D590")]
	private void FKCFPOFCCNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x856DF70", Offset = "0x856C970", VA = "0x18856DF70")]
	private void JNOJAHPHLKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class CHFAHLKHNLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Guid, JHOPIHFFCBF> DIAPHCLLMBP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long LNPPHIAKEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xCF8030", Offset = "0xCF6A30", VA = "0x180CF8030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x856B8D0", Offset = "0x856A2D0", VA = "0x18856B8D0")]
	public void DKDIBJBIJMB(long FHOIPEIAACP, IEnumerable<JHOPIHFFCBF> OADPEEKPKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x856B810", Offset = "0x856A210", VA = "0x18856B810")]
	public bool AGPOMHELHMM(Guid BLEFGDKGHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x856B870", Offset = "0x856A270", VA = "0x18856B870")]
	public bool DAAFLACHELB(Guid BLEFGDKGHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x856BC90", Offset = "0x856A690", VA = "0x18856BC90")]
	public bool NGGCEDOLKPI(JHOPIHFFCBF DBPBLNPPPOJ, [Out] JHOPIHFFCBF FBDBAFOCIBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x856BBC0", Offset = "0x856A5C0", VA = "0x18856BBC0")]
	public IEnumerable<JHOPIHFFCBF> INLGALFAKEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x856BB50", Offset = "0x856A550", VA = "0x18856BB50")]
	public bool HMEGPMGOMOF(Guid BLEFGDKGHED, [Out] JHOPIHFFCBF ODMAJCCOOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x856BC10", Offset = "0x856A610", VA = "0x18856BC10")]
	private bool JGCJFODODGH(JHOPIHFFCBF OIEALMJHDLB, JHOPIHFFCBF BDLDJILLEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x856BDF0", Offset = "0x856A7F0", VA = "0x18856BDF0")]
	public CHFAHLKHNLP()
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
