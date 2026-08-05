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
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NEGLKCKEBLM : DKKHPKDENKB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HKNNCJPEJMA ONAHMIBLBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GLMAPKPNEEL
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IAKFLNEKJCF OGLNGECIFPO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MNGABIFBICO : GLMAPKPNEEL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67064F0", Offset = "0x67050F0", VA = "0x1867064F0")]
	[JDFNDIEGGDI(EEILJHHLCPL.Session, COFBNFOEGIB.GameOnly)]
	private static void KPHMLLKABCG(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	[Preserve]
	public MNGABIFBICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6706560", Offset = "0x6705160", VA = "0x186706560", Slot = "4")]
	public IAKFLNEKJCF OGLNGECIFPO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[JHPFJEFPNKG]
public class HKNNCJPEJMA : EDMPMBKPJHE, IDisposable, EALFCNIBKIJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct LJJDFCPEIPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<LKGOILFFEBB, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public HKNNCJPEJMA <>4__this;

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
		public MHDBFFOCNGK roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<GHELAPIBBMC<LKGOILFFEBB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6706010", Offset = "0x6704C10", VA = "0x186706010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6706480", Offset = "0x6705080", VA = "0x186706480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BFNADNGLMFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<LKGOILFFEBB, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public HKNNCJPEJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public MHDBFFOCNGK roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<GHELAPIBBMC<LKGOILFFEBB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x66FECB0", Offset = "0x66FD8B0", VA = "0x1866FECB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x66FF1F0", Offset = "0x66FDDF0", VA = "0x1866FF1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct DHCFLKKPKCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public HKNNCJPEJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private LKGOILFFEBB <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<KIPOCMPGPMP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x66FFCC0", Offset = "0x66FE8C0", VA = "0x1866FFCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6700210", Offset = "0x66FEE10", VA = "0x186700210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct CMMAILIAFEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<List<EKPGGOHKDHB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public HKNNCJPEJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<GHELAPIBBMC<List<EKPGGOHKDHB>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x66FF260", Offset = "0x66FDE60", VA = "0x1866FF260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x66FF660", Offset = "0x66FE260", VA = "0x1866FF660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GFCEIKBHBBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HKNNCJPEJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public IFDGJPHDBFK player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6700280", Offset = "0x66FEE80", VA = "0x186700280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6700620", Offset = "0x66FF220", VA = "0x186700620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct IABDFNAPFPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public HKNNCJPEJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public LKGOILFFEBB roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public string purchaseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<DGKNLHNBBJB<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x67053C0", Offset = "0x6703FC0", VA = "0x1867053C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6705930", Offset = "0x6704530", VA = "0x186705930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct HKLDACFBJCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public HKNNCJPEJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public LKGOILFFEBB roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string purchaseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public long initialBalance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private IOOLIKHMAOC <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private LDNFOPCOJMD <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<LDNFOPCOJMD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6700690", Offset = "0x66FF290", VA = "0x186700690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6700EB0", Offset = "0x66FFAB0", VA = "0x186700EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OGPFICAGFGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public HKNNCJPEJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Task<GHELAPIBBMC<List<PEABFAHILBH>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter<List<LKGOILFFEBB>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private TaskAwaiter<GHELAPIBBMC<List<PEABFAHILBH>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6706CF0", Offset = "0x67058F0", VA = "0x186706CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x67074E0", Offset = "0x67060E0", VA = "0x1867074E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct NFGDFILCMBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public HKNNCJPEJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6706620", Offset = "0x6705220", VA = "0x186706620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6706C90", Offset = "0x6705890", VA = "0x186706C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct CPNEAIDOMPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public HKNNCJPEJMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public IFDGJPHDBFK player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x66FF6D0", Offset = "0x66FE2D0", VA = "0x1866FF6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x66FFC50", Offset = "0x66FE850", VA = "0x1866FFC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan DAGHLKJBFGB;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string DBECINPPPCI = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string GMGJJPENBJM = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string MBFBJELKJFC = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FHKFEDIPAGI ADNEBIJFGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DBEMOFGFIPK CIDMCJLPCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly LFEGMOABMDL DNILIKBCNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly HIGGBJHAIJL DNELCKKIPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly BNBKGEJEFMF OEPNNGEBDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly NEGLKCKEBLM DDKBOLGAJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HJCIGOHCPFD FOHLLAJCPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly NKIFLONDKBD CDFKJKIPLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly IBJLMJDJLJM IANCGCNMMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CAAKFJJOJHB JOGENKLDHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly IAKFLNEKJCF DAOLHMKAPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> GPNIECJIEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable KJPOMMNALBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task NFHNOCIBLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource MEJOBBJGFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long OFMOPHLOPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool KLIIIEHJHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly OMEMMPNMNNL DMNKEIGJPHJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private BGLPCCLHJAL FOAMKAAAMBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6701BE0", Offset = "0x67007E0", VA = "0x186701BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GPEAFMNAGCL IDIKPCNNCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x878330", Offset = "0x876F30", VA = "0x180878330", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x878450", Offset = "0x877050", VA = "0x180878450", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CGCFLAHJDPK<LKGOILFFEBB> IMHAAHCFKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8E0", Offset = "0x7BA4E0", VA = "0x1807BB8E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8C0", Offset = "0x7BA4C0", VA = "0x1807BB8C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CGCFLAHJDPK<Guid> APKILGLHFHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA16DC0", Offset = "0xA159C0", VA = "0x180A16DC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA1ED40", Offset = "0xA1D940", VA = "0x180A1ED40", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6703510", Offset = "0x6702110", VA = "0x186703510")]
	[JDFNDIEGGDI(EEILJHHLCPL.Session, COFBNFOEGIB.GameOnly)]
	private static void KPHMLLKABCG(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6704C50", Offset = "0x6703850", VA = "0x186704C50")]
	[Preserve]
	public HKNNCJPEJMA([NNEMKPMNJAE(null)] FHKFEDIPAGI ADNEBIJFGHD, [NNEMKPMNJAE(null)] DBEMOFGFIPK CIDMCJLPCLO, [NNEMKPMNJAE(null)] CHJAIGJNPHN JHLBOCEOGLD, [NNEMKPMNJAE(null)] LFEGMOABMDL DNILIKBCNIB, [NNEMKPMNJAE(null)] GLMAPKPNEEL JGLKNOOGEGJ, [NNEMKPMNJAE(null)] HIGGBJHAIJL DNELCKKIPNN, [NNEMKPMNJAE("ShowPurchasePromptRateLimiter")] BNBKGEJEFMF OEPNNGEBDBL, [NNEMKPMNJAE(null)] NEGLKCKEBLM DDKBOLGAJHM, [NNEMKPMNJAE(null)] PAEFHCOOMHL GICPNBIAPPB, [NNEMKPMNJAE(null)] HJCIGOHCPFD FOHLLAJCPJF, [NNEMKPMNJAE(null)] NKIFLONDKBD CDFKJKIPLPC, [NNEMKPMNJAE(null)] IBJLMJDJLJM IANCGCNMMKB, [NNEMKPMNJAE(null)] CAAKFJJOJHB JOGENKLDHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6701C30", Offset = "0x6700830", VA = "0x186701C30", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6703B90", Offset = "0x6702790", VA = "0x186703B90", Slot = "10")]
	[AsyncStateMachine(typeof(LJJDFCPEIPG))]
	public Task<DGKNLHNBBJB<LKGOILFFEBB, string>> MLMCINOFEOJ(long MGDJPIEDFNB, string MPGNMPAPHDB, string PCPJCEHFFMB, string KJBKODHFLNP, int IJKNDBNACBK, MHDBFFOCNGK FBLGOIJAEFA, [Optional] Dictionary<Guid, int> GLEHDGMDHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6702040", Offset = "0x6700C40", VA = "0x186702040", Slot = "11")]
	[AsyncStateMachine(typeof(BFNADNGLMFN))]
	public Task<DGKNLHNBBJB<LKGOILFFEBB, string>> FJBMDOEALJN(Guid MLBLDMAAJPA, string MPGNMPAPHDB, string PCPJCEHFFMB, string KJBKODHFLNP, int IJKNDBNACBK, MHDBFFOCNGK FBLGOIJAEFA, [Optional] Dictionary<Guid, int> GLEHDGMDHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6701980", Offset = "0x6700580", VA = "0x186701980", Slot = "12")]
	[AsyncStateMachine(typeof(DHCFLKKPKCJ))]
	public Task<DGKNLHNBBJB<bool, string>> DCAEDKFJFOD(Guid MLBLDMAAJPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6701EB0", Offset = "0x6700AB0", VA = "0x186701EB0", Slot = "13")]
	public IEnumerable<LKGOILFFEBB> EDHDILHDJHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6704640", Offset = "0x6703240", VA = "0x186704640", Slot = "14")]
	[AsyncStateMachine(typeof(CMMAILIAFEC))]
	public Task<List<EKPGGOHKDHB>> PLEDPFCLCOP(long MGDJPIEDFNB, [Optional] CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x67040E0", Offset = "0x6702CE0", VA = "0x1867040E0", Slot = "16")]
	public bool OCLGBFLHGBG(Guid MLBLDMAAJPA, int JFOFLKOAMNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6701F60", Offset = "0x6700B60", VA = "0x186701F60", Slot = "15")]
	public bool FHPAONNONDH(Guid MLBLDMAAJPA, [Out] LKGOILFFEBB IMGGOAJMGDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6703110", Offset = "0x6701D10", VA = "0x186703110", Slot = "17")]
	public void KLKGLEGFFOI(IFDGJPHDBFK POHDOBOBLAI, Guid MLBLDMAAJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6701AA0", Offset = "0x67006A0", VA = "0x186701AA0", Slot = "18")]
	[AsyncStateMachine(typeof(GFCEIKBHBBN))]
	public Task<int> DGOPFPJMEFH(IFDGJPHDBFK POHDOBOBLAI, Guid MLBLDMAAJPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6703030", Offset = "0x6701C30", VA = "0x186703030", Slot = "19")]
	public bool KCPNIILNGOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6701080", Offset = "0x66FFC80", VA = "0x186701080", Slot = "20")]
	public bool ANNMNOPIJON(Guid LBPEJEEOFCO, [Out] List<string> BGELJBJCFEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6701450", Offset = "0x6700050", VA = "0x186701450", Slot = "21")]
	[AsyncStateMachine(typeof(IABDFNAPFPD))]
	public Task<DGKNLHNBBJB<bool, string>> BLENLDFDADJ(LKGOILFFEBB IMGGOAJMGDJ, long NJCMLIEENFM, int AIMJKOABHLL, string NHFFLDDFDCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6700F20", Offset = "0x66FFB20", VA = "0x186700F20")]
	[AsyncStateMachine(typeof(HKLDACFBJCG))]
	private Task<DGKNLHNBBJB<bool, string>> ANLFHAECDOA(LKGOILFFEBB IMGGOAJMGDJ, long NJCMLIEENFM, long FDPKJLPEALK, string NHFFLDDFDCN, int AIMJKOABHLL = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6702B10", Offset = "0x6701710", VA = "0x186702B10")]
	private Task<LDNFOPCOJMD> JIJJPLJAMBA(LKGOILFFEBB IMGGOAJMGDJ, int AIMJKOABHLL, int NJCMLIEENFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x67042E0", Offset = "0x6702EE0", VA = "0x1867042E0")]
	private bool OJBNDMIMLJC(IEnumerable<HNONNCDBCEI> BJLFGBIOBFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6702620", Offset = "0x6701220", VA = "0x186702620")]
	private void IDKPFBLOCMC(LKGOILFFEBB IMGGOAJMGDJ, long FDPKJLPEALK, int AIMJKOABHLL, string NHFFLDDFDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x67028C0", Offset = "0x67014C0", VA = "0x1867028C0")]
	private string JIDFJBMJFNG(LKGOILFFEBB IMGGOAJMGDJ, int AIMJKOABHLL, string NHFFLDDFDCN, [Optional] IOOLIKHMAOC? MGHLKGJFBCD, [Optional] BMMBMEHHFEC? IGDFGPKNEDI, [Optional] string IGPGLHNEHGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67039E0", Offset = "0x67025E0", VA = "0x1867039E0")]
	private bool LLLPJFKPDFL(LKGOILFFEBB HCLKEEGLHOB, int AIMJKOABHLL, [Out] long? FDPKJLPEALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6702370", Offset = "0x6700F70", VA = "0x186702370")]
	[AsyncStateMachine(typeof(OGPFICAGFGH))]
	private Task HEHAOIAPDNK(long MGDJPIEDFNB, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6703D20", Offset = "0x6702920", VA = "0x186703D20")]
	private Task NIPIAFFBFBI(GPMIMHCABEE PELDJLKMCIK, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6703910", Offset = "0x6702510", VA = "0x186703910")]
	[AsyncStateMachine(typeof(NFGDFILCMBD))]
	private Task LLALGGCLENG(GPMIMHCABEE PELDJLKMCIK, CancellationToken IDEGIHPKOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x67015B0", Offset = "0x67001B0", VA = "0x1867015B0")]
	private static Dictionary<Guid, int> BNCMGEHHDKC(GHELAPIBBMC<List<PEABFAHILBH>> MEJEOKFNMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6703D10", Offset = "0x6702910", VA = "0x186703D10")]
	private void NHHIPODCJIG(LKGOILFFEBB IMGGOAJMGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x67021C0", Offset = "0x6700DC0", VA = "0x1867021C0")]
	private void GABEJKJONLK(Guid MLBLDMAAJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x67049E0", Offset = "0x67035E0", VA = "0x1867049E0")]
	[IKDEMDNLGHO]
	internal void RpcOfferShowPurchasePrompt(Guid MLBLDMAAJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6702230", Offset = "0x6700E30", VA = "0x186702230")]
	[AsyncStateMachine(typeof(CPNEAIDOMPP))]
	private Task<int> GHEIFDHCNHD(IFDGJPHDBFK POHDOBOBLAI, Guid LBPEJEEOFCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67047F0", Offset = "0x67033F0", VA = "0x1867047F0")]
	[IKDEMDNLGHO]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid BJNGDHCNCJP, Guid MLBLDMAAJPA, CLADCFJJPMM KIGGBMJEDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6704770", Offset = "0x6703370", VA = "0x186704770")]
	[IKDEMDNLGHO]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid BJNGDHCNCJP, int MAJIECOCCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6703580", Offset = "0x6702180", VA = "0x186703580", Slot = "23")]
	public string LGLLGELOGIP(IOOLIKHMAOC MGHLKGJFBCD, [Optional] BMMBMEHHFEC? HLLELAEEINE, [Optional] BalanceResponseDTO KAGHPLPDDBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67032F0", Offset = "0x6701EF0", VA = "0x1867032F0")]
	private static string KMINKHOPKMB(BMMBMEHHFEC HLLELAEEINE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6702480", Offset = "0x6701080", VA = "0x186702480")]
	private LKGOILFFEBB HOJIGPEPOMA(LKGOILFFEBB LFFIKHNAODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6701910", Offset = "0x6700510", VA = "0x186701910")]
	private void CIEEMLGPHDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x67033E0", Offset = "0x6701FE0", VA = "0x1867033E0")]
	private void KOHDNPKNMEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DefaultMember("Item")]
public class IAKFLNEKJCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly Dictionary<Guid, LKGOILFFEBB> MKCCPGLPKFD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long NBHCAKIGHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xEA4170", Offset = "0xEA2D70", VA = "0x180EA4170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6705A80", Offset = "0x6704680", VA = "0x186705A80")]
	public void FGONMMGHFKD(long MGDJPIEDFNB, IEnumerable<LKGOILFFEBB> MEMOIBLEEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6705D80", Offset = "0x6704980", VA = "0x186705D80")]
	public bool GAJMKIBHCMA(Guid MLBLDMAAJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6705A20", Offset = "0x6704620", VA = "0x186705A20")]
	public bool DMBJGENFJDP(Guid MLBLDMAAJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6705E30", Offset = "0x6704A30", VA = "0x186705E30")]
	public bool PKIOMGDGLGG(LKGOILFFEBB HBFPKFIJHNF, [Out] LKGOILFFEBB HNOMJECHHGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6705DE0", Offset = "0x67049E0", VA = "0x186705DE0")]
	public IEnumerable<LKGOILFFEBB> HGIICABLPEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6705D10", Offset = "0x6704910", VA = "0x186705D10")]
	public bool FHPAONNONDH(Guid MLBLDMAAJPA, [Out] LKGOILFFEBB IMGGOAJMGDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x67059A0", Offset = "0x67045A0", VA = "0x1867059A0")]
	private bool ABIPJGJJCNK(LKGOILFFEBB OHHNBBKEKIA, LKGOILFFEBB LFCFKALFKOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6705F80", Offset = "0x6704B80", VA = "0x186705F80")]
	public IAKFLNEKJCF()
	{
	}
}
namespace Cpp2IlInjected;

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
