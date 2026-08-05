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
		[Cpp2IlInjected.Address(RVA = "0x7FA0160", Offset = "0x7F9F560", VA = "0x187FA0160", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HJPIMEIKGKB : HBMHKKECLHH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FEPCHJDGNJG BACGJJGDICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BPMPGNLBFMP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DEMNGAMFCIN GPICCPGCCDK();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EDFDPEOCNKN : BPMPGNLBFMP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F99600", Offset = "0x7F98A00", VA = "0x187F99600")]
	[BOBPNFIGGBE.FIPHDKCKMAJ.LALHFPBIBCF]
	internal static void HEACPKLJJEL(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	[RecRoom.NoEngine.Common.Preserve]
	public EDFDPEOCNKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F99540", Offset = "0x7F98940", VA = "0x187F99540", Slot = "4")]
	public DEMNGAMFCIN GPICCPGCCDK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NGHELBGCMPC]
public class FEPCHJDGNJG : DMKEGEIIKCL, IDisposable, MABBDEHLNIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BJFCJJKELCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<BNJAEDHDGMG, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FEPCHJDGNJG <>4__this;

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
		public NFMFGEJBIJF roomOfferType;

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
		private TaskAwaiter<HHLHBEHEDKE<BNJAEDHDGMG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7F96F90", Offset = "0x7F96390", VA = "0x187F96F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7F974C0", Offset = "0x7F968C0", VA = "0x187F974C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GGAGMMJBPGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<BNJAEDHDGMG, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public FEPCHJDGNJG <>4__this;

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
		public NFMFGEJBIJF roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<HHLHBEHEDKE<BNJAEDHDGMG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F9E5C0", Offset = "0x7F9D9C0", VA = "0x187F9E5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F9EB60", Offset = "0x7F9DF60", VA = "0x187F9EB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NCPIJACHMJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public FEPCHJDGNJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private BNJAEDHDGMG <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<JHDDEHBOPMH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F9F1F0", Offset = "0x7F9E5F0", VA = "0x187F9F1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F9F750", Offset = "0x7F9EB50", VA = "0x187F9F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct DDMLEEGCEEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<List<AKCPDPHODCH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public FEPCHJDGNJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<HHLHBEHEDKE<List<AKCPDPHODCH>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7F97B20", Offset = "0x7F96F20", VA = "0x187F97B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7F97F20", Offset = "0x7F97320", VA = "0x187F97F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct MGINGDHOHBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public FEPCHJDGNJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public FEIKLGLBIHI player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F9EBD0", Offset = "0x7F9DFD0", VA = "0x187F9EBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7F9EF70", Offset = "0x7F9E370", VA = "0x187F9EF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct OLJPHMLHFHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public FEPCHJDGNJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public BNJAEDHDGMG roomOffer;

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
		private TaskAwaiter<AEAAIINGJNL<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7F9F7C0", Offset = "0x7F9EBC0", VA = "0x187F9F7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7F9FD10", Offset = "0x7F9F110", VA = "0x187F9FD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EEDKHGIOEIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public FEPCHJDGNJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public BNJAEDHDGMG roomOffer;

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
		private EHPJKLHAAOH <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private BDNDOIOPFDD <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<BDNDOIOPFDD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F99670", Offset = "0x7F98A70", VA = "0x187F99670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7F99FA0", Offset = "0x7F993A0", VA = "0x187F99FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MJKOJGMABFI
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
			public MJKOJGMABFI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7F9FD80", Offset = "0x7F9F180", VA = "0x187F9FD80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7FA0100", Offset = "0x7F9F500", VA = "0x187FA0100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public FEPCHJDGNJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public MJKOJGMABFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7F9F100", Offset = "0x7F9E500", VA = "0x187F9F100")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task KMJDMCEEKKB(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7F9EFE0", Offset = "0x7F9E3E0", VA = "0x187F9EFE0")]
		internal Guid? IDECDMOILEC(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct AHDFBAJNOLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<BDNDOIOPFDD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public FEPCHJDGNJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public BNJAEDHDGMG roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private MJKOJGMABFI <>8__1;

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
		private TaskAwaiter<BDNDOIOPFDD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7F96240", Offset = "0x7F95640", VA = "0x187F96240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F96F20", Offset = "0x7F96320", VA = "0x187F96F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct DKFCDAJFEFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public FEPCHJDGNJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<HHLHBEHEDKE<List<IMNBMKDODHA>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<List<BNJAEDHDGMG>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<HHLHBEHEDKE<List<IMNBMKDODHA>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7F98CF0", Offset = "0x7F980F0", VA = "0x187F98CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7F994E0", Offset = "0x7F988E0", VA = "0x187F994E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct DGOCCHLCNHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public FEPCHJDGNJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7F98610", Offset = "0x7F97A10", VA = "0x187F98610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7F98C90", Offset = "0x7F98090", VA = "0x187F98C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct COHLBFJFIFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public FEPCHJDGNJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public FEIKLGLBIHI player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7F97530", Offset = "0x7F96930", VA = "0x187F97530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7F97AB0", Offset = "0x7F96EB0", VA = "0x187F97AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan DEICDCMDPDP;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string LNMKAOLMELG = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string ILFCJHAKDKA = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string EGDFEMIJLPE = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly KJMAEHMNHNB OMHEGCECDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly LOJECIKAFKG CDDIGBAACFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly BCHJLKPLLNL KELGJGNBONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly HNAFBHEKIKK JHNCNOHACNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly MJHGAABFBGH BHDPDBMBPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HJPIMEIKGKB KGDNBAABJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly ICAINIHMPHM MFCHJJKNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HNPNNPCNMCC GGMMMNPFACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly ABHODGNCBEB PCEIOHFAAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BGFKOEMHHCL DMIKFAKPHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly DEMNGAMFCIN PIOJMAMNEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> KDNMIGLIBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable LLOKKPKJAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task KMNJFJOPLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource EIPPIEPHNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long GKBJJJOJNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool MIGDMPFDAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly FIAJIKDECGI EONHJNFGKBK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private ENKIKIBAPOM POBHAPJDNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A700", Offset = "0x7F99B00", VA = "0x187F9A700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public OLDENIALAEA IIKJHPGGIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC2B3E0", Offset = "0xC2A7E0", VA = "0x180C2B3E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD940F0", Offset = "0xD934F0", VA = "0x180D940F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public OHMOKFGANBG<BNJAEDHDGMG> MOKEDDICKKH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x999C90", Offset = "0x999090", VA = "0x180999C90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x999C50", Offset = "0x999050", VA = "0x180999C50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public OHMOKFGANBG<Guid> HAGNGOBMLCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB7A750", Offset = "0xB79B50", VA = "0x180B7A750", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xDA8080", Offset = "0xDA7480", VA = "0x180DA8080", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C210", Offset = "0x7F9B610", VA = "0x187F9C210")]
	[BOBPNFIGGBE.FIPHDKCKMAJ.LALHFPBIBCF]
	internal static void HEACPKLJJEL(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DEA0", Offset = "0x7F9D2A0", VA = "0x187F9DEA0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FEPCHJDGNJG([GKAMHFFOHNI(null)] KJMAEHMNHNB OMHEGCECDAF, [GKAMHFFOHNI(null)] LOJECIKAFKG CDDIGBAACFF, [GKAMHFFOHNI(null)] AHFKEHIEJLO CDJLLPGBCKE, [GKAMHFFOHNI(null)] BCHJLKPLLNL KELGJGNBONF, [GKAMHFFOHNI(null)] BPMPGNLBFMP FHMMKFELBLB, [GKAMHFFOHNI(null)] HNAFBHEKIKK JHNCNOHACNN, [GKAMHFFOHNI("ShowPurchasePromptRateLimiter")] MJHGAABFBGH BHDPDBMBPII, [GKAMHFFOHNI(null)] HJPIMEIKGKB KGDNBAABJGB, [GKAMHFFOHNI(null)] AJHIHCOEHDB IPFGNJGMMIH, [GKAMHFFOHNI(null)] ICAINIHMPHM MFCHJJKNFDE, [GKAMHFFOHNI(null)] HNPNNPCNMCC GGMMMNPFACI, [GKAMHFFOHNI(null)] ABHODGNCBEB PCEIOHFAAEF, [GKAMHFFOHNI(null)] BGFKOEMHHCL DMIKFAKPHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B090", Offset = "0x7F9A490", VA = "0x187F9B090", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F9CCF0", Offset = "0x7F9C0F0", VA = "0x187F9CCF0", Slot = "10")]
	[AsyncStateMachine(typeof(BJFCJJKELCC))]
	public Task<AEAAIINGJNL<BNJAEDHDGMG, string>> KEKBHAOFEKP(Guid? LDHNGFEPBJC, long CCHPCHDJHAI, string MPGDCPPMNJN, string DPHOGONECCJ, string CFKIPPLHIHC, int IKDBPFDACOF, NFMFGEJBIJF OLHOABBCLEA, [Optional] Dictionary<Guid, int> LEGOLJKBMDL, [Optional] Guid? CPAFEDFFAGD, bool FAKIJHHAIHP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D700", Offset = "0x7F9CB00", VA = "0x187F9D700", Slot = "11")]
	[AsyncStateMachine(typeof(GGAGMMJBPGI))]
	public Task<AEAAIINGJNL<BNJAEDHDGMG, string>> OKMKEKGOOBD(Guid OMJEKIOAGDG, long CCHPCHDJHAI, string MPGDCPPMNJN, string DPHOGONECCJ, string CFKIPPLHIHC, int IKDBPFDACOF, NFMFGEJBIJF OLHOABBCLEA, [Optional] Dictionary<Guid, int> LEGOLJKBMDL, [Optional] Guid? CPAFEDFFAGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D4D0", Offset = "0x7F9C8D0", VA = "0x187F9D4D0", Slot = "12")]
	[AsyncStateMachine(typeof(NCPIJACHMJJ))]
	public Task<AEAAIINGJNL<bool, string>> NNCDJMOHAKB(Guid BGNLPPHDNDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D8A0", Offset = "0x7F9CCA0", VA = "0x187F9D8A0", Slot = "13")]
	public IEnumerable<BNJAEDHDGMG> PDEGLEDFFHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B2F0", Offset = "0x7F9A6F0", VA = "0x187F9B2F0", Slot = "14")]
	[AsyncStateMachine(typeof(DDMLEEGCEEG))]
	public Task<List<AKCPDPHODCH>> EAPCKJNNHPP(long CCHPCHDJHAI, [Optional] CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BC10", Offset = "0x7F9B010", VA = "0x187F9BC10", Slot = "17")]
	public bool FDBMDBMLALG(Guid BGNLPPHDNDF, int KNALIIJNLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D3F0", Offset = "0x7F9C7F0", VA = "0x187F9D3F0", Slot = "15")]
	public bool LOGJLEIJIGP(Guid BGNLPPHDNDF, [Out] BNJAEDHDGMG PLJNBAMNMLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F9CA90", Offset = "0x7F9BE90", VA = "0x187F9CA90", Slot = "16")]
	public bool KCGLGIHOGKH(string MPGDCPPMNJN, [Out] BNJAEDHDGMG PLJNBAMNMLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A750", Offset = "0x7F99B50", VA = "0x187F9A750", Slot = "18")]
	public void DBCLCPLMICA(FEIKLGLBIHI CALAFNPECBD, Guid BGNLPPHDNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BE10", Offset = "0x7F9B210", VA = "0x187F9BE10", Slot = "19")]
	[AsyncStateMachine(typeof(MGINGDHOHBN))]
	public Task<int> FDPAANDADHK(FEIKLGLBIHI CALAFNPECBD, Guid BGNLPPHDNDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B420", Offset = "0x7F9A820", VA = "0x187F9B420", Slot = "20")]
	public bool EMFKPNNNOHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7F9CFE0", Offset = "0x7F9C3E0", VA = "0x187F9CFE0", Slot = "21")]
	public bool LDECNDCPGFJ(Guid LCKBPFGKBFE, [Out] List<string> NHDMPALIJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C0B0", Offset = "0x7F9B4B0", VA = "0x187F9C0B0", Slot = "22")]
	[AsyncStateMachine(typeof(OLJPHMLHFHL))]
	public Task<AEAAIINGJNL<bool, string>> GJKNJIKGNGH(BNJAEDHDGMG PLJNBAMNMLF, long LEJKIBGJJLI, int OMDEPJMGLPG, string FBLHPNAKOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7F9BF50", Offset = "0x7F9B350", VA = "0x187F9BF50")]
	[AsyncStateMachine(typeof(EEDKHGIOEIP))]
	private Task<AEAAIINGJNL<bool, string>> FEKEBLIEPFK(BNJAEDHDGMG PLJNBAMNMLF, long LEJKIBGJJLI, long GIHJBOMHFAD, string FBLHPNAKOND, int OMDEPJMGLPG = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7F9AC90", Offset = "0x7F9A090", VA = "0x187F9AC90")]
	[AsyncStateMachine(typeof(AHDFBAJNOLE))]
	private Task<BDNDOIOPFDD> DGEODGHCJDG(BNJAEDHDGMG PLJNBAMNMLF, int OMDEPJMGLPG, int LEJKIBGJJLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A930", Offset = "0x7F99D30", VA = "0x187F9A930")]
	private bool DFBEOFNIPJG(IEnumerable<KINDJFIHIDL> IDMPNEKDPIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A330", Offset = "0x7F99730", VA = "0x187F9A330")]
	private void BPKDFJLMLPP(BNJAEDHDGMG PLJNBAMNMLF, long GIHJBOMHFAD, int OMDEPJMGLPG, string FBLHPNAKOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A010", Offset = "0x7F99410", VA = "0x187F9A010")]
	private string AGMOKGIJLIC(BNJAEDHDGMG PLJNBAMNMLF, int OMDEPJMGLPG, string FBLHPNAKOND, [Optional] EHPJKLHAAOH? KGODHHBLJOE, [Optional] IDMACLPDHFH? FJGALKFOKGE, [Optional] string EGFBKHNHGMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F9ADF0", Offset = "0x7F9A1F0", VA = "0x187F9ADF0")]
	private EHPJKLHAAOH DHEJCAPHCIO(BNJAEDHDGMG DMICKBMDEAK, int GDNFMMEGOHM, [Out] long GIHJBOMHFAD)
	{
		return default(EHPJKLHAAOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D5F0", Offset = "0x7F9C9F0", VA = "0x187F9D5F0")]
	[AsyncStateMachine(typeof(DKFCDAJFEFG))]
	private Task OGLCDDOPDBB(long CCHPCHDJHAI, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C490", Offset = "0x7F9B890", VA = "0x187F9C490")]
	private Task IODOBFGMOKM(CFLKKNKAIAK JOIGLCNPHIH, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7F9A260", Offset = "0x7F99660", VA = "0x187F9A260")]
	[AsyncStateMachine(typeof(DGOCCHLCNHK))]
	private Task BBOKCKEOCFM(CFLKKNKAIAK JOIGLCNPHIH, CancellationToken BGFGLAFLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B500", Offset = "0x7F9A900", VA = "0x187F9B500")]
	private static Dictionary<Guid, int> EOEIKDNONDK(HHLHBEHEDKE<List<IMNBMKDODHA>> PABKCMOBFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D3E0", Offset = "0x7F9C7E0", VA = "0x187F9D3E0")]
	private void LIHPAPPNMKK(BNJAEDHDGMG PLJNBAMNMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C280", Offset = "0x7F9B680", VA = "0x187F9C280")]
	private void IHKMNJKBECP(Guid BGNLPPHDNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DC30", Offset = "0x7F9D030", VA = "0x187F9DC30")]
	[KBGKKNFCDLD]
	internal void RpcOfferShowPurchasePrompt(Guid BGNLPPHDNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F9CEA0", Offset = "0x7F9C2A0", VA = "0x187F9CEA0")]
	[AsyncStateMachine(typeof(COHLBFJFIFA))]
	private Task<int> KLOGENHEFCK(FEIKLGLBIHI CALAFNPECBD, Guid LCKBPFGKBFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F9DA40", Offset = "0x7F9CE40", VA = "0x187F9DA40")]
	[KBGKKNFCDLD]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid NPMNDEDHHIJ, Guid BGNLPPHDNDF, IFGEDDNPJKP FPBOMPOFMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D9C0", Offset = "0x7F9CDC0", VA = "0x187F9D9C0")]
	[KBGKKNFCDLD]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid NPMNDEDHHIJ, int PPLOBPJCNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B860", Offset = "0x7F9AC60", VA = "0x187F9B860", Slot = "24")]
	public string FBCMBGEDLAB(EHPJKLHAAOH KGODHHBLJOE, [Optional] IDMACLPDHFH? POCKGIJEFJF, [Optional] BalanceResponseDTO EDDAIDAMOGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C9A0", Offset = "0x7F9BDA0", VA = "0x187F9C9A0")]
	private static string JGHEDCLFCDH(IDMACLPDHFH POCKGIJEFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C2F0", Offset = "0x7F9B6F0", VA = "0x187F9C2F0")]
	private BNJAEDHDGMG IJGPIJKHKFB(BNJAEDHDGMG MGPIFOHIEDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7F9D950", Offset = "0x7F9CD50", VA = "0x187F9D950")]
	private void PPNLNGDNDDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7F9C870", Offset = "0x7F9BC70", VA = "0x187F9C870")]
	private void JEIHAFBIHEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class DEMNGAMFCIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Guid, BNJAEDHDGMG> LPEBEIIGFNF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long BKLLPDKHGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xBBDA20", Offset = "0xBBCE20", VA = "0x180BBDA20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F98280", Offset = "0x7F97680", VA = "0x187F98280")]
	public void LNCJCCFIMMK(long CCHPCHDJHAI, IEnumerable<BNJAEDHDGMG> PFPPIJNKIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F98150", Offset = "0x7F97550", VA = "0x187F98150")]
	public bool FFFEHFEGIBA(Guid BGNLPPHDNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7F980F0", Offset = "0x7F974F0", VA = "0x187F980F0")]
	public bool FBDLIPAFCGJ(Guid BGNLPPHDNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7F97F90", Offset = "0x7F97390", VA = "0x187F97F90")]
	public bool EHCLIDMOIKM(BNJAEDHDGMG NNLCKCELIHF, [Out] BNJAEDHDGMG GENEGJKPPDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7F98230", Offset = "0x7F97630", VA = "0x187F98230")]
	public IEnumerable<BNJAEDHDGMG> IJKJCNAJAEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F98510", Offset = "0x7F97910", VA = "0x187F98510")]
	public bool LOGJLEIJIGP(Guid BGNLPPHDNDF, [Out] BNJAEDHDGMG PLJNBAMNMLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7F981B0", Offset = "0x7F975B0", VA = "0x187F981B0")]
	private bool HAFLKLEFDKM(BNJAEDHDGMG CENPJDFMJJI, BNJAEDHDGMG PKLNGDOJLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7F98580", Offset = "0x7F97980", VA = "0x187F98580")]
	public DEMNGAMFCIN()
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
