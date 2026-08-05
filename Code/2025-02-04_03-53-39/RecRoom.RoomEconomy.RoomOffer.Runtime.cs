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
		[Cpp2IlInjected.Address(RVA = "0x79AD110", Offset = "0x79ABF10", VA = "0x1879AD110", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AFCJCAHCGGI : AGEKHDOHDFB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JFNCCIAJKOB JPONLDOOJEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JELEALDIFPB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EGOHOBOCHBD GDDIHPNCIMH();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JGMNHGIHHLB : JELEALDIFPB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x79ABAE0", Offset = "0x79AA8E0", VA = "0x1879ABAE0")]
	[FOLINPJCBJN.MNGLEKFJHCC.CIIMNDHGCHC]
	internal static void LHLKGADJEGF(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	[RecRoom.NoEngine.Common.Preserve]
	public JGMNHGIHHLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x79ABA20", Offset = "0x79AA820", VA = "0x1879ABA20", Slot = "4")]
	public EGOHOBOCHBD GDDIHPNCIMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HLDENJBKDHO]
public class JFNCCIAJKOB : BFGOMFFHGIE, IDisposable, DMFHILBFNGP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct IJEFCMNPGEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<NCNNJGKIGFO, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public JFNCCIAJKOB <>4__this;

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
		public GBGDGHLALKL roomOfferType;

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
		private TaskAwaiter<HLMIMAIIOKH<NCNNJGKIGFO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x79A6870", Offset = "0x79A5670", VA = "0x1879A6870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x79A6DA0", Offset = "0x79A5BA0", VA = "0x1879A6DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct CEOKMLKFELL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<NCNNJGKIGFO, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public JFNCCIAJKOB <>4__this;

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
		public GBGDGHLALKL roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<HLMIMAIIOKH<NCNNJGKIGFO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x79A4080", Offset = "0x79A2E80", VA = "0x1879A4080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x79A4620", Offset = "0x79A3420", VA = "0x1879A4620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct IOMEMAACNOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public JFNCCIAJKOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private NCNNJGKIGFO <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IMPIHAMKLJE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x79A6E10", Offset = "0x79A5C10", VA = "0x1879A6E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x79A7360", Offset = "0x79A6160", VA = "0x1879A7360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct FNBFFPEGGJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<List<FHDJCPLBNMH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public JFNCCIAJKOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<HLMIMAIIOKH<List<FHDJCPLBNMH>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x79A56D0", Offset = "0x79A44D0", VA = "0x1879A56D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x79A5AD0", Offset = "0x79A48D0", VA = "0x1879A5AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct FMHFGFABNNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public JFNCCIAJKOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NJGJGBGCLGP player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x79A52C0", Offset = "0x79A40C0", VA = "0x1879A52C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x79A5660", Offset = "0x79A4460", VA = "0x1879A5660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct EOLKHCPIOAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public JFNCCIAJKOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public NCNNJGKIGFO roomOffer;

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
		private TaskAwaiter<PGOLMGNGGBM<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x79A4D00", Offset = "0x79A3B00", VA = "0x1879A4D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x79A5250", Offset = "0x79A4050", VA = "0x1879A5250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OIKGBICKEBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public JFNCCIAJKOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NCNNJGKIGFO roomOffer;

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
		private FCPJILANPGC <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private LOFFKICKPKH <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<LOFFKICKPKH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x79ABB50", Offset = "0x79AA950", VA = "0x1879ABB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x79AC480", Offset = "0x79AB280", VA = "0x1879AC480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class APKELHGNOJG
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
			public APKELHGNOJG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x79ACD40", Offset = "0x79ABB40", VA = "0x1879ACD40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x79AD0B0", Offset = "0x79ABEB0", VA = "0x1879AD0B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public JFNCCIAJKOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public APKELHGNOJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x79A31C0", Offset = "0x79A1FC0", VA = "0x1879A31C0")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task MNAFNIDALAM(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x79A32B0", Offset = "0x79A20B0", VA = "0x1879A32B0")]
		internal Guid? NOJENGBBNCN(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct IDOHAGKIMOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<LOFFKICKPKH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public JFNCCIAJKOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NCNNJGKIGFO roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private APKELHGNOJG <>8__1;

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
		private TaskAwaiter<LOFFKICKPKH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x79A5B40", Offset = "0x79A4940", VA = "0x1879A5B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x79A6800", Offset = "0x79A5600", VA = "0x1879A6800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct POJMJKMOCJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public JFNCCIAJKOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<HLMIMAIIOKH<List<HJDJHCIGLIN>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<List<NCNNJGKIGFO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<HLMIMAIIOKH<List<HJDJHCIGLIN>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x79AC4F0", Offset = "0x79AB2F0", VA = "0x1879AC4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x79ACCE0", Offset = "0x79ABAE0", VA = "0x1879ACCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct BJLAHFCMNJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public JFNCCIAJKOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x79A39A0", Offset = "0x79A27A0", VA = "0x1879A39A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x79A4020", Offset = "0x79A2E20", VA = "0x1879A4020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct BBOCBCPAJPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public JFNCCIAJKOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public NJGJGBGCLGP player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x79A33D0", Offset = "0x79A21D0", VA = "0x1879A33D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x79A3930", Offset = "0x79A2730", VA = "0x1879A3930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan COCKMAOOFOE;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string GOEPIAMODJN = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string ALKLONNPEHG = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string AKBLDKEFLCH = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly JLHODCNNIAH FFINDCOHPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DDODMENECGH ONNJMGBGFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly AGGOAABOFIO HOEGACLAPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly JGLLKCGMCOF HMFEFPHLCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly OAPMCPIPKPI APAOHDBLMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly AFCJCAHCGGI MPFFCOLIDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly BKOPHEPBKBF BPGIOHMMDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly GEHLCDKNENC OBBJECBDOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly LCPFGGJNGLH JKEMDBPOPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly APGKKIHKPFK NGOGICJFNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly EGOHOBOCHBD LPKMHJGOHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> IPKEEAPOEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable PANDONIEPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task IJFKKOAADIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource DOCFPIMHJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long OPHPEHCJOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool BBDDFKFCEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly EGJEAOKEOGD DBIHKMNCFFD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private GJOGLFJCBDD ABDJAHPACFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x79A8B50", Offset = "0x79A7950", VA = "0x1879A8B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GAMKKEJCIBM CPOJAEMOKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB9BD70", Offset = "0xB9AB70", VA = "0x180B9BD70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCFF660", Offset = "0xCFE460", VA = "0x180CFF660", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public OJCBODLGMBO<NCNNJGKIGFO> KIOLLDHBHDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x904730", Offset = "0x903530", VA = "0x180904730", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x904790", Offset = "0x903590", VA = "0x180904790", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public OJCBODLGMBO<Guid> NJNKLKAMKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAD87F0", Offset = "0xAD75F0", VA = "0x180AD87F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD01130", Offset = "0xCFFF30", VA = "0x180D01130", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x79AA710", Offset = "0x79A9510", VA = "0x1879AA710")]
	[FOLINPJCBJN.MNGLEKFJHCC.CIIMNDHGCHC]
	internal static void LHLKGADJEGF(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x79AB2F0", Offset = "0x79AA0F0", VA = "0x1879AB2F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public JFNCCIAJKOB([MHFJPMCEEAM(null)] JLHODCNNIAH FFINDCOHPOD, [MHFJPMCEEAM(null)] DDODMENECGH ONNJMGBGFKL, [MHFJPMCEEAM(null)] DDJGAGKAGGH JFNPNLNAOPB, [MHFJPMCEEAM(null)] AGGOAABOFIO HOEGACLAPEC, [MHFJPMCEEAM(null)] JELEALDIFPB HBACMNDMMBN, [MHFJPMCEEAM(null)] JGLLKCGMCOF HMFEFPHLCJH, [MHFJPMCEEAM("ShowPurchasePromptRateLimiter")] OAPMCPIPKPI APAOHDBLMDI, [MHFJPMCEEAM(null)] AFCJCAHCGGI MPFFCOLIDFL, [MHFJPMCEEAM(null)] GIBKNDJJJFP MEFFEOHINOK, [MHFJPMCEEAM(null)] BKOPHEPBKBF BPGIOHMMDAI, [MHFJPMCEEAM(null)] GEHLCDKNENC OBBJECBDOCC, [MHFJPMCEEAM(null)] LCPFGGJNGLH JKEMDBPOPLF, [MHFJPMCEEAM(null)] APGKKIHKPFK NGOGICJFNDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x79A7FB0", Offset = "0x79A6DB0", VA = "0x1879A7FB0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x79A7C50", Offset = "0x79A6A50", VA = "0x1879A7C50", Slot = "10")]
	[AsyncStateMachine(typeof(IJEFCMNPGEN))]
	public Task<PGOLMGNGGBM<NCNNJGKIGFO, string>> CHHGBIKJCPL(Guid? KJMDOHBCHEN, long OGMIFIGJENM, string PPKJBGAOBJL, string CHJIHJFAIKD, string GIEEKCOLJBD, int INMHKFHHOKC, GBGDGHLALKL OAFEDJJKPBC, [Optional] Dictionary<Guid, int> KKGAADPPKKI, [Optional] Guid? HMJGDCPHIPL, bool PDIBOCPFIGK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x79A9F40", Offset = "0x79A8D40", VA = "0x1879A9F40", Slot = "11")]
	[AsyncStateMachine(typeof(CEOKMLKFELL))]
	public Task<PGOLMGNGGBM<NCNNJGKIGFO, string>> KANBCIPPFPK(Guid DAEBBPJPDOE, long OGMIFIGJENM, string PPKJBGAOBJL, string CHJIHJFAIKD, string GIEEKCOLJBD, int INMHKFHHOKC, GBGDGHLALKL OAFEDJJKPBC, [Optional] Dictionary<Guid, int> KKGAADPPKKI, [Optional] Guid? HMJGDCPHIPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x79AA5F0", Offset = "0x79A93F0", VA = "0x1879AA5F0", Slot = "12")]
	[AsyncStateMachine(typeof(IOMEMAACNOL))]
	public Task<PGOLMGNGGBM<bool, string>> KGAOAOLGLAA(Guid DPHKDFKCDMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x79A95A0", Offset = "0x79A83A0", VA = "0x1879A95A0", Slot = "13")]
	public IEnumerable<NCNNJGKIGFO> HNAIJKPECMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x79A77C0", Offset = "0x79A65C0", VA = "0x1879A77C0", Slot = "14")]
	[AsyncStateMachine(typeof(FNBFFPEGGJM))]
	public Task<List<FHDJCPLBNMH>> ANGLKJKBLNP(long OGMIFIGJENM, [Optional] CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x79A78F0", Offset = "0x79A66F0", VA = "0x1879A78F0", Slot = "17")]
	public bool BLOPKBGDLCH(Guid DPHKDFKCDMP, int ANBEDKIOFIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x79A8230", Offset = "0x79A7030", VA = "0x1879A8230", Slot = "15")]
	public bool EAFLMIOIHPC(Guid DPHKDFKCDMP, [Out] NCNNJGKIGFO LIAFPNJBDPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x79AA870", Offset = "0x79A9670", VA = "0x1879AA870", Slot = "16")]
	public bool NCOFKEBMPHL(string PPKJBGAOBJL, [Out] NCNNJGKIGFO LIAFPNJBDPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x79A8610", Offset = "0x79A7410", VA = "0x1879A8610", Slot = "18")]
	public void FMFEAJINDJA(NJGJGBGCLGP CJJBIEHOBCD, Guid DPHKDFKCDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x79A9E00", Offset = "0x79A8C00", VA = "0x1879A9E00", Slot = "19")]
	[AsyncStateMachine(typeof(FMHFGFABNNK))]
	public Task<int> JNDCCGPBION(NJGJGBGCLGP CJJBIEHOBCD, Guid DPHKDFKCDMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x79A7E00", Offset = "0x79A6C00", VA = "0x1879A7E00", Slot = "20")]
	public bool DDLLNBDMNMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x79A9A00", Offset = "0x79A8800", VA = "0x1879A9A00", Slot = "21")]
	public bool JKKLLIJMPAL(Guid AGOPGKECKOH, [Out] List<string> IDEJPCMKABG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x79AA490", Offset = "0x79A9290", VA = "0x1879AA490", Slot = "22")]
	[AsyncStateMachine(typeof(EOLKHCPIOAA))]
	public Task<PGOLMGNGGBM<bool, string>> KDIBLJPHCFE(NCNNJGKIGFO LIAFPNJBDPE, long HCBCBIHDBPM, int FDHKHEAGCEI, string CLGOCBIBDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x79A84B0", Offset = "0x79A72B0", VA = "0x1879A84B0")]
	[AsyncStateMachine(typeof(OIKGBICKEBE))]
	private Task<PGOLMGNGGBM<bool, string>> FCABEKBKGHI(NCNNJGKIGFO LIAFPNJBDPE, long HCBCBIHDBPM, long ABKPCGDMNGL, string CLGOCBIBDPA, int FDHKHEAGCEI = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x79A7AF0", Offset = "0x79A68F0", VA = "0x1879A7AF0")]
	[AsyncStateMachine(typeof(IDOHAGKIMOB))]
	private Task<LOFFKICKPKH> BMJIIFMMGED(NCNNJGKIGFO LIAFPNJBDPE, int FDHKHEAGCEI, int HCBCBIHDBPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x79A8FE0", Offset = "0x79A7DE0", VA = "0x1879A8FE0")]
	private bool GNOFADPDKHL(IEnumerable<IILPFKKLKEL> MPAAHEJOBNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x79A8BA0", Offset = "0x79A79A0", VA = "0x1879A8BA0")]
	private void GHNKGMDFPCN(NCNNJGKIGFO LIAFPNJBDPE, long ABKPCGDMNGL, int FDHKHEAGCEI, string CLGOCBIBDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x79AABC0", Offset = "0x79A99C0", VA = "0x1879AABC0")]
	private string PGBLNBIKJGP(NCNNJGKIGFO LIAFPNJBDPE, int FDHKHEAGCEI, string CLGOCBIBDPA, [Optional] FCPJILANPGC? LDEANEOLAOA, [Optional] HPFPACJKFPB? PKOHNDPAGFL, [Optional] string IABIMKLGJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x79A9760", Offset = "0x79A8560", VA = "0x1879A9760")]
	private FCPJILANPGC IKBCDIJPDNL(NCNNJGKIGFO BDMGMBNEEEP, int JOADMOBBIPG, [Out] long ABKPCGDMNGL)
	{
		return default(FCPJILANPGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x79A9650", Offset = "0x79A8450", VA = "0x1879A9650")]
	[AsyncStateMachine(typeof(POJMJKMOCJE))]
	private Task IDAECDNDBHG(long OGMIFIGJENM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x79A73D0", Offset = "0x79A61D0", VA = "0x1879A73D0")]
	private Task AMLIKBCJCPM(HGCCILDLOLL EHEEIKICBAM, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x79A7EE0", Offset = "0x79A6CE0", VA = "0x1879A7EE0")]
	[AsyncStateMachine(typeof(BJLAHFCMNJP))]
	private Task DOJLFKCBEIF(HGCCILDLOLL EHEEIKICBAM, CancellationToken KOLAOIJDLJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x79A87F0", Offset = "0x79A75F0", VA = "0x1879A87F0")]
	private static Dictionary<Guid, int> FMFJKALAPHH(HLMIMAIIOKH<List<HJDJHCIGLIN>> LEMOMNCMFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x79AAAD0", Offset = "0x79A98D0", VA = "0x1879AAAD0")]
	private void NHBNCPOHJKP(NCNNJGKIGFO LIAFPNJBDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x79AAAE0", Offset = "0x79A98E0", VA = "0x1879AAAE0")]
	private void ODOAMGNBGAC(Guid DPHKDFKCDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x79AB090", Offset = "0x79A9E90", VA = "0x1879AB090")]
	[OODIPABJIOB]
	internal void RpcOfferShowPurchasePrompt(Guid DPHKDFKCDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x79A9460", Offset = "0x79A8260", VA = "0x1879A9460")]
	[AsyncStateMachine(typeof(BBOCBCPAJPP))]
	private Task<int> HBACBKHEDJO(NJGJGBGCLGP CJJBIEHOBCD, Guid AGOPGKECKOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x79AAEA0", Offset = "0x79A9CA0", VA = "0x1879AAEA0")]
	[OODIPABJIOB]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid KCDDPKBGHIL, Guid DPHKDFKCDMP, HBGNIDMLMKM AMHAHGPNKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x79AAE20", Offset = "0x79A9C20", VA = "0x1879AAE20")]
	[OODIPABJIOB]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid KCDDPKBGHIL, int BMGBDLLODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x79AA0E0", Offset = "0x79A8EE0", VA = "0x1879AA0E0", Slot = "24")]
	public string KBJDJPOEKLB(FCPJILANPGC LDEANEOLAOA, [Optional] HPFPACJKFPB? ECEKNPBJKAN, [Optional] BalanceResponseDTO EMLOGBOJBGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x79AA780", Offset = "0x79A9580", VA = "0x1879AA780")]
	private static string NCMAOLKAPCL(HPFPACJKFPB ECEKNPBJKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x79A8310", Offset = "0x79A7110", VA = "0x1879A8310")]
	private NCNNJGKIGFO EEKEEBJLLPE(NCNNJGKIGFO NOJDAKJOPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x79AAB50", Offset = "0x79A9950", VA = "0x1879AAB50")]
	private void OECEJMBGMGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x79A9330", Offset = "0x79A8130", VA = "0x1879A9330")]
	private void GPKLMAOENOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class EGOHOBOCHBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Guid, NCNNJGKIGFO> IEEJJABBJCG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long IPJEADBLJAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xB4CAC0", Offset = "0xB4B8C0", VA = "0x180B4CAC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x79A49F0", Offset = "0x79A37F0", VA = "0x1879A49F0")]
	public void PNCEIJMOMIM(long OGMIFIGJENM, IEnumerable<NCNNJGKIGFO> OFLFICCEKPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x79A4990", Offset = "0x79A3790", VA = "0x1879A4990")]
	public bool NFNHMGMNFPD(Guid DPHKDFKCDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x79A47D0", Offset = "0x79A35D0", VA = "0x1879A47D0")]
	public bool IEINLEAGPOE(Guid DPHKDFKCDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x79A4830", Offset = "0x79A3630", VA = "0x1879A4830")]
	public bool JAOKHMPABKM(NCNNJGKIGFO KNMLOIPCLLI, [Out] NCNNJGKIGFO ENPDIPANLIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x79A4700", Offset = "0x79A3500", VA = "0x1879A4700")]
	public IEnumerable<NCNNJGKIGFO> HHOLNNHECLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x79A4690", Offset = "0x79A3490", VA = "0x1879A4690")]
	public bool EAFLMIOIHPC(Guid DPHKDFKCDMP, [Out] NCNNJGKIGFO LIAFPNJBDPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x79A4750", Offset = "0x79A3550", VA = "0x1879A4750")]
	private bool HONNBLOCGIH(NCNNJGKIGFO PIOEIDCNELN, NCNNJGKIGFO IAEEGOAMIAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x79A4C70", Offset = "0x79A3A70", VA = "0x1879A4C70")]
	public EGOHOBOCHBD()
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
