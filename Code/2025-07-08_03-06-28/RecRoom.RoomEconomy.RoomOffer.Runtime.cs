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
		[Cpp2IlInjected.Address(RVA = "0x89050C0", Offset = "0x8903EC0", VA = "0x1889050C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MLOPLPDBCAG : IGKGPHBDJFA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FKINNLLMHAO AOOKLLDILON
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NDGLJGGDCDP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DMGNACGIACF NCPCEEEPFHP();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LEACKJCIHGM : NDGLJGGDCDP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8902360", Offset = "0x8901160", VA = "0x188902360")]
	[ONLJNMLDJBD.JLHCPMFEMHB.IONMKBJJIGG]
	internal static void DKGNAIFEGAN(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LEACKJCIHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x89023D0", Offset = "0x89011D0", VA = "0x1889023D0", Slot = "4")]
	public DMGNACGIACF NCPCEEEPFHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HCBEFNLCJPF]
public class FKINNLLMHAO : LOODLNBNCDM, IDisposable, GHGFLPEAIKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct AFMBDHBCDMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<CKPFCFEHEPP<KKJEHLMOIKE, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FKINNLLMHAO <>4__this;

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
		public OEEPDKFOCOM roomOfferType;

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
		private TaskAwaiter<LMDCEECEFJF<KKJEHLMOIKE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88FB170", Offset = "0x88F9F70", VA = "0x1888FB170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x88FB6A0", Offset = "0x88FA4A0", VA = "0x1888FB6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct NJJLLEBFPBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<CKPFCFEHEPP<KKJEHLMOIKE, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public FKINNLLMHAO <>4__this;

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
		public OEEPDKFOCOM roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid? priceUnitId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<LMDCEECEFJF<KKJEHLMOIKE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8904260", Offset = "0x8903060", VA = "0x188904260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8904800", Offset = "0x8903600", VA = "0x188904800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct ANKKLPPKENN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<CKPFCFEHEPP<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public FKINNLLMHAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private KKJEHLMOIKE <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<FAOJBHJNHHE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88FB710", Offset = "0x88FA510", VA = "0x1888FB710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88FBC60", Offset = "0x88FAA60", VA = "0x1888FBC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PFFEAPMEFHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<List<JHNJIMFEMPO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public FKINNLLMHAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<LMDCEECEFJF<List<JHNJIMFEMPO>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8904870", Offset = "0x8903670", VA = "0x188904870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8904C70", Offset = "0x8903A70", VA = "0x188904C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct KMJGMIGPHPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public FKINNLLMHAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CDKFIILELLC player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8901F50", Offset = "0x8900D50", VA = "0x188901F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x89022F0", Offset = "0x89010F0", VA = "0x1889022F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct JGOEBPCDOCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<CKPFCFEHEPP<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public FKINNLLMHAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public KKJEHLMOIKE roomOffer;

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
		private TaskAwaiter<CKPFCFEHEPP<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8900F20", Offset = "0x88FFD20", VA = "0x188900F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8901470", Offset = "0x8900270", VA = "0x188901470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NGNFKPAMJKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder<CKPFCFEHEPP<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public FKINNLLMHAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public KKJEHLMOIKE roomOffer;

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
		private MDHEOKEFALB <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private MPBHLJIMEPP <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<MPBHLJIMEPP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x89038C0", Offset = "0x89026C0", VA = "0x1889038C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x89041F0", Offset = "0x8902FF0", VA = "0x1889041F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KEGHNDFPOOK
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
			public KEGHNDFPOOK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Guid itemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8904CE0", Offset = "0x8903AE0", VA = "0x188904CE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8905060", Offset = "0x8903E60", VA = "0x188905060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public FKINNLLMHAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int expectedTotalPrice;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KEGHNDFPOOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x89014E0", Offset = "0x89002E0", VA = "0x1889014E0")]
		[AsyncStateMachine(typeof(<<SendRecNetRoomOfferPurchaseRequest>g__FlushPendingInventoryItemUpdatesIfNeeded|0>d))]
		internal Task HFJBJBJNMJI(Guid itemId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x89015D0", Offset = "0x89003D0", VA = "0x1889015D0")]
		internal Guid? OOHIEKBNOLN(Guid itemId)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MMHPGOFKPOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<MPBHLJIMEPP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public FKINNLLMHAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public KKJEHLMOIKE roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private KEGHNDFPOOK <>8__1;

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
		private TaskAwaiter<MPBHLJIMEPP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8902B80", Offset = "0x8901980", VA = "0x188902B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8903850", Offset = "0x8902650", VA = "0x188903850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct KIFOHDDAOBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public FKINNLLMHAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Task<LMDCEECEFJF<List<GBKCDMKPICO>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<List<KKJEHLMOIKE>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskAwaiter<LMDCEECEFJF<List<GBKCDMKPICO>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x89016F0", Offset = "0x89004F0", VA = "0x1889016F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8901EF0", Offset = "0x8900CF0", VA = "0x188901EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct LOGPPPKAHAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public FKINNLLMHAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8902490", Offset = "0x8901290", VA = "0x188902490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8902B20", Offset = "0x8901920", VA = "0x188902B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ELMDFEOEKHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public FKINNLLMHAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public CDKFIILELLC player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x88FC340", Offset = "0x88FB140", VA = "0x1888FC340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x88FC8B0", Offset = "0x88FB6B0", VA = "0x1888FC8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan OCEKOEHJFID;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string MCCBDLAGLHM = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string LPBCLBNJBLI = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string IKBBMNNGDJC = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly KCKGOBPBIBH FNAGOKIHDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly NBAMFCCPNAH OENCDGFOLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly PCFDOHACCDJ HEGIOABGJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly HGFOMCHGKEH NJOCDKGDILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly MDLFBMPACAJ ADADIAOKIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MLOPLPDBCAG CBFMPBKGLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DIODGBCIGOF JBNGHMBPLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly FJJICPEIJHK EPLMFHMODDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly OLNPKPHMNNE ENGNGPMGAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CALDANMDCAE PGLPLMOMPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly DMGNACGIACF FFMEEKHGIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> IFADIKFIMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable HNPLBLKPINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task JCPKEEPJCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource AILOOMCPAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long KDODDLAPOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool HDGGIMAAJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly FNEKDCANECH GEAMKIHBMPB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private AJFMFCCDCEG ADDEGPDDIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88FE940", Offset = "0x88FD740", VA = "0x1888FE940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EPBKGABEMJJ IMDILCCGINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xABC2D0", Offset = "0xABB0D0", VA = "0x180ABC2D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB0E290", Offset = "0xB0D090", VA = "0x180B0E290", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IKLFNFDBNDM<KKJEHLMOIKE> MMDJPGLPEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA65C30", Offset = "0xA64A30", VA = "0x180A65C30", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA65C10", Offset = "0xA64A10", VA = "0x180A65C10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IKLFNFDBNDM<Guid> MJBJGMMAPDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB0E4E0", Offset = "0xB0D2E0", VA = "0x180B0E4E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB0E440", Offset = "0xB0D240", VA = "0x180B0E440", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x88FCFC0", Offset = "0x88FBDC0", VA = "0x1888FCFC0")]
	[ONLJNMLDJBD.JLHCPMFEMHB.IONMKBJJIGG]
	internal static void DKGNAIFEGAN(LOAHJOOKLEP CHDHLAGMCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x89007E0", Offset = "0x88FF5E0", VA = "0x1889007E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FKINNLLMHAO([OLOAAHJODHH(null)] KCKGOBPBIBH FNAGOKIHDHP, [OLOAAHJODHH(null)] NBAMFCCPNAH OENCDGFOLMF, [OLOAAHJODHH(null)] KGFJDPAACPB ADMEJHLBGMD, [OLOAAHJODHH(null)] PCFDOHACCDJ HEGIOABGJAG, [OLOAAHJODHH(null)] NDGLJGGDCDP PAOCMMCMANP, [OLOAAHJODHH(null)] HGFOMCHGKEH NJOCDKGDILE, [OLOAAHJODHH("ShowPurchasePromptRateLimiter")] MDLFBMPACAJ ADADIAOKIMG, [OLOAAHJODHH(null)] MLOPLPDBCAG CBFMPBKGLFF, [OLOAAHJODHH(null)] DOLGGPJDNFA NCDGJKJAOOF, [OLOAAHJODHH(null)] DIODGBCIGOF JBNGHMBPLHF, [OLOAAHJODHH(null)] FJJICPEIJHK EPLMFHMODDP, [OLOAAHJODHH(null)] OLNPKPHMNNE ENGNGPMGAHN, [OLOAAHJODHH(null)] CALDANMDCAE PGLPLMOMPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x88FD1F0", Offset = "0x88FBFF0", VA = "0x1888FD1F0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x88FD850", Offset = "0x88FC650", VA = "0x1888FD850", Slot = "10")]
	[AsyncStateMachine(typeof(AFMBDHBCDMO))]
	public Task<CKPFCFEHEPP<KKJEHLMOIKE, string>> FMCJFELLFMN(Guid? DDHBDLPKMNF, long NCGHDDJNJOM, string GGDFKFACHGG, string BKPMFKNMLEK, string GKJABGINPJG, int DBNAILDCGHC, OEEPDKFOCOM MNIDJFBJMOE, [Optional] Dictionary<Guid, int> FIEPDHLJDJE, [Optional] Guid? LNLLLFHMPCG, bool LHAPAKMCLNN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8900170", Offset = "0x88FEF70", VA = "0x188900170", Slot = "11")]
	[AsyncStateMachine(typeof(NJJLLEBFPBD))]
	public Task<CKPFCFEHEPP<KKJEHLMOIKE, string>> OLJNKOPPIFK(Guid PDEKHMHMNBD, long NCGHDDJNJOM, string GGDFKFACHGG, string BKPMFKNMLEK, string GKJABGINPJG, int DBNAILDCGHC, OEEPDKFOCOM MNIDJFBJMOE, [Optional] Dictionary<Guid, int> FIEPDHLJDJE, [Optional] Guid? LNLLLFHMPCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x88FE6F0", Offset = "0x88FD4F0", VA = "0x1888FE6F0", Slot = "12")]
	[AsyncStateMachine(typeof(ANKKLPPKENN))]
	public Task<CKPFCFEHEPP<bool, string>> HNNLBNIJKDN(Guid DKOCPAOBKNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x88FDF00", Offset = "0x88FCD00", VA = "0x1888FDF00", Slot = "13")]
	public IEnumerable<KKJEHLMOIKE> GFJGEGCAKJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x88FE810", Offset = "0x88FD610", VA = "0x1888FE810", Slot = "14")]
	[AsyncStateMachine(typeof(PFFEAPMEFHB))]
	public Task<List<JHNJIMFEMPO>> IKADGMNHNGI(long NCGHDDJNJOM, [Optional] CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x88FECA0", Offset = "0x88FDAA0", VA = "0x1888FECA0", Slot = "17")]
	public bool KKPHKOLBOKE(Guid DKOCPAOBKNG, int PCDFDDCPELL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x88FCB80", Offset = "0x88FB980", VA = "0x1888FCB80", Slot = "15")]
	public bool CDIFCCCPJPN(Guid DKOCPAOBKNG, [Out] KKJEHLMOIKE LIJBMNPPLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x88FE090", Offset = "0x88FCE90", VA = "0x1888FE090", Slot = "16")]
	public bool GGPPIGNLHPK(string GGDFKFACHGG, [Out] KKJEHLMOIKE LIJBMNPPLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x88FF070", Offset = "0x88FDE70", VA = "0x1888FF070", Slot = "18")]
	public void LGKGDFNHHGC(CDKFIILELLC IFADLDJHCLA, Guid DKOCPAOBKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x88FEAF0", Offset = "0x88FD8F0", VA = "0x1888FEAF0", Slot = "19")]
	[AsyncStateMachine(typeof(KMJGMIGPHPH))]
	public Task<int> KGMJDCHOEHC(CDKFIILELLC IFADLDJHCLA, Guid DKOCPAOBKNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x88FDFB0", Offset = "0x88FCDB0", VA = "0x1888FDFB0", Slot = "20")]
	public bool GFPBBBGGMMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x88FF250", Offset = "0x88FE050", VA = "0x1888FF250", Slot = "21")]
	public bool MALOOBKKIKE(Guid AAIJMNJDPLL, [Out] List<string> LLIOLFBFHDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x88FF760", Offset = "0x88FE560", VA = "0x1888FF760", Slot = "22")]
	[AsyncStateMachine(typeof(JGOEBPCDOCH))]
	public Task<CKPFCFEHEPP<bool, string>> NEEJKLHHFIA(KKJEHLMOIKE LIJBMNPPLHF, long BFEFNAJNOEK, int MFCGKLNJBDB, string HDJENCMKHDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x88FE990", Offset = "0x88FD790", VA = "0x1888FE990")]
	[AsyncStateMachine(typeof(NGNFKPAMJKJ))]
	private Task<CKPFCFEHEPP<bool, string>> KGJHGIBNEDE(KKJEHLMOIKE LIJBMNPPLHF, long BFEFNAJNOEK, long BENIEGAJHCB, string HDJENCMKHDE, int MFCGKLNJBDB = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x88FEEA0", Offset = "0x88FDCA0", VA = "0x1888FEEA0")]
	[AsyncStateMachine(typeof(MMHPGOFKPOD))]
	private Task<MPBHLJIMEPP> KLDJKKNNJBD(KKJEHLMOIKE LIJBMNPPLHF, int MFCGKLNJBDB, int BFEFNAJNOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x88FCC60", Offset = "0x88FBA60", VA = "0x1888FCC60")]
	private bool CFBODKIPIAC(IEnumerable<GHICLFGLALC> NGJHFCCPCJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x88FDB30", Offset = "0x88FC930", VA = "0x1888FDB30")]
	private void GCPOENMHKJL(KKJEHLMOIKE LIJBMNPPLHF, long BENIEGAJHCB, int MFCGKLNJBDB, string HDJENCMKHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x88FC920", Offset = "0x88FB720", VA = "0x1888FC920")]
	private string APNFKOELGFC(KKJEHLMOIKE LIJBMNPPLHF, int MFCGKLNJBDB, string HDJENCMKHDE, [Optional] MDHEOKEFALB? OHLBIIOAJDL, [Optional] MEELCAECJGM? FBEAOLLCEJL, [Optional] string OCPENGPCCKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x88FD5B0", Offset = "0x88FC3B0", VA = "0x1888FD5B0")]
	private MDHEOKEFALB FJDONOMPDKI(KKJEHLMOIKE HEMOMIDKLBJ, int IOJAMADNKBA, [Out] long BENIEGAJHCB)
	{
		return default(MDHEOKEFALB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x88FF650", Offset = "0x88FE450", VA = "0x1888FF650")]
	[AsyncStateMachine(typeof(KIFOHDDAOBH))]
	private Task NCNLAFPOGDK(long NCGHDDJNJOM, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x88FE300", Offset = "0x88FD100", VA = "0x1888FE300")]
	private Task HELBADCGLLN(EIPHABKKBFG ENDEOBGIMGA, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x88FD030", Offset = "0x88FBE30", VA = "0x1888FD030")]
	[AsyncStateMachine(typeof(LOGPPPKAHAA))]
	private Task DMPGAKEPJKD(EIPHABKKBFG ENDEOBGIMGA, CancellationToken EEOFMBNOONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x88FFE10", Offset = "0x88FEC10", VA = "0x1888FFE10")]
	private static Dictionary<Guid, int> OLBHGFJPPJA(LMDCEECEFJF<List<GBKCDMKPICO>> LMPEIPJGKBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x88FE2F0", Offset = "0x88FD0F0", VA = "0x1888FE2F0")]
	private void HEAAEPJNLFB(KKJEHLMOIKE LIJBMNPPLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x88FF000", Offset = "0x88FDE00", VA = "0x1888FF000")]
	private void KNHNBNOHCJB(Guid DKOCPAOBKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8900580", Offset = "0x88FF380", VA = "0x188900580")]
	[OGGONGCJDAC]
	internal void RpcOfferShowPurchasePrompt(Guid DKOCPAOBKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x88FD470", Offset = "0x88FC270", VA = "0x1888FD470")]
	[AsyncStateMachine(typeof(ELMDFEOEKHG))]
	private Task<int> EHIGMAJJBJP(CDKFIILELLC IFADLDJHCLA, Guid AAIJMNJDPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8900390", Offset = "0x88FF190", VA = "0x188900390")]
	[OGGONGCJDAC]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid ALEMANCBDEO, Guid DKOCPAOBKNG, HEBLDOMJFJP MDHOEKKPKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8900310", Offset = "0x88FF110", VA = "0x188900310")]
	[OGGONGCJDAC]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid ALEMANCBDEO, int LJEIHABMGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x88FFA60", Offset = "0x88FE860", VA = "0x1888FFA60", Slot = "24")]
	public string OCKCOCINDPK(MDHEOKEFALB OHLBIIOAJDL, [Optional] MEELCAECJGM? HMOCMENOHCN, [Optional] BalanceResponseDTO NDHNPMNKEBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x88FD100", Offset = "0x88FBF00", VA = "0x1888FD100")]
	private static string DPDIKOKIKJA(MEELCAECJGM HMOCMENOHCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x88FF8C0", Offset = "0x88FE6C0", VA = "0x1888FF8C0")]
	private KKJEHLMOIKE NHPPKHFIDEH(KKJEHLMOIKE DCLMMNDJBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x88FEC30", Offset = "0x88FDA30", VA = "0x1888FEC30")]
	private void KJLBHEMPPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x88FDA00", Offset = "0x88FC800", VA = "0x1888FDA00")]
	private void FNFINHKNBIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class DMGNACGIACF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Guid, KKJEHLMOIKE> HGDOOOHHPKA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long NBAAIIHONBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xD70690", Offset = "0xD6F490", VA = "0x180D70690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x88FC030", Offset = "0x88FAE30", VA = "0x1888FC030")]
	public void PNDGFDJFFPI(long NCGHDDJNJOM, IEnumerable<KKJEHLMOIKE> KCANPMFECNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x88FBDF0", Offset = "0x88FABF0", VA = "0x1888FBDF0")]
	public bool EMCIBABBHGK(Guid DKOCPAOBKNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x88FBD90", Offset = "0x88FAB90", VA = "0x1888FBD90")]
	public bool EBNLHEFHMEO(Guid DKOCPAOBKNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x88FBE50", Offset = "0x88FAC50", VA = "0x1888FBE50")]
	public bool FPIHAOBKINF(KKJEHLMOIKE ACEJNKHMBPL, [Out] KKJEHLMOIKE KNADGEIJAFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x88FBCD0", Offset = "0x88FAAD0", VA = "0x1888FBCD0")]
	public IEnumerable<KKJEHLMOIKE> ANPHBILOPCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x88FBD20", Offset = "0x88FAB20", VA = "0x1888FBD20")]
	public bool CDIFCCCPJPN(Guid DKOCPAOBKNG, [Out] KKJEHLMOIKE LIJBMNPPLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x88FBFB0", Offset = "0x88FADB0", VA = "0x1888FBFB0")]
	private bool GMGKIAPILEK(KKJEHLMOIKE LNNEKAADPNI, KKJEHLMOIKE IDCDCAHIEEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x88FC2B0", Offset = "0x88FB0B0", VA = "0x1888FC2B0")]
	public DMGNACGIACF()
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
