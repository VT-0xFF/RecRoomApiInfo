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
public interface OANDENPOHEL : NDPCJMCHCCH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ABJCEGJPMLM GGIIOJEBPCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EABCLLPGENL
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FOLADHMKLIE PDELOOKDLEH();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FNEADPHLBBI : EABCLLPGENL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6592150", Offset = "0x6590F50", VA = "0x186592150")]
	[NAAAALLPNIA(KMIEHGCCHON.Session, PBKIGNPNCFO.GameOnly)]
	private static void PMDBOALDHOL(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	[Preserve]
	public FNEADPHLBBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6592090", Offset = "0x6590E90", VA = "0x186592090", Slot = "4")]
	public FOLADHMKLIE PDELOOKDLEH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AILBKAMKKLP]
public class ABJCEGJPMLM : GMFGPOPEPDB, IDisposable, HDDHAKCFELD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct IKDHJBNGBKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<FMBMDIHMAAF, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public ABJCEGJPMLM <>4__this;

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
		public NDEHPGKNCCL roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<BCAGGENGADC<FMBMDIHMAAF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6592DE0", Offset = "0x6591BE0", VA = "0x186592DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6593250", Offset = "0x6592050", VA = "0x186593250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct FNMANGMGDCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<FMBMDIHMAAF, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ABJCEGJPMLM <>4__this;

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
		public NDEHPGKNCCL roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<BCAGGENGADC<FMBMDIHMAAF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x65921C0", Offset = "0x6590FC0", VA = "0x1865921C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6592700", Offset = "0x6591500", VA = "0x186592700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct JJMNKGKMOBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public ABJCEGJPMLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private FMBMDIHMAAF <existingRoomOffer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<LALALCEBIGO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x65932C0", Offset = "0x65920C0", VA = "0x1865932C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6593810", Offset = "0x6592610", VA = "0x186593810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct ELCOLAPLPOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<List<EHPGOHLABIK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public ABJCEGJPMLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<BCAGGENGADC<List<EHPGOHLABIK>>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6591550", Offset = "0x6590350", VA = "0x186591550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6591950", Offset = "0x6590750", VA = "0x186591950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct AABPNFJDODN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public ABJCEGJPMLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public MNFCKJNKANA player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x658B5E0", Offset = "0x658A3E0", VA = "0x18658B5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x658B980", Offset = "0x658A780", VA = "0x18658B980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct CLMEDNPGOHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public ABJCEGJPMLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public FMBMDIHMAAF roomOffer;

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
		private TaskAwaiter<FBEPHKHKLJE<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x65906E0", Offset = "0x658F4E0", VA = "0x1865906E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6590C50", Offset = "0x658FA50", VA = "0x186590C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct DJENFJOMNNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public ABJCEGJPMLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public FMBMDIHMAAF roomOffer;

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
		private LEPCHIDIOBB <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private KDKJMIKONND <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<KDKJMIKONND> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6590CC0", Offset = "0x658FAC0", VA = "0x186590CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x65914E0", Offset = "0x65902E0", VA = "0x1865914E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BOJLFLFLIFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public ABJCEGJPMLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Task<BCAGGENGADC<List<BPICEMMPALJ>>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter<List<FMBMDIHMAAF>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private TaskAwaiter<BCAGGENGADC<List<BPICEMMPALJ>>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x658FE90", Offset = "0x658EC90", VA = "0x18658FE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6590680", Offset = "0x658F480", VA = "0x186590680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct ELPNIANPNLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public ABJCEGJPMLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x65919C0", Offset = "0x65907C0", VA = "0x1865919C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6592030", Offset = "0x6590E30", VA = "0x186592030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct OCEPCFLGICN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public ABJCEGJPMLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public MNFCKJNKANA player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Guid roomInventoryItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private TaskAwaiter<int> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6593880", Offset = "0x6592680", VA = "0x186593880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6593E00", Offset = "0x6592C00", VA = "0x186593E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan CNCHAGMGBPH;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string ACMCNOLKOBN = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string JGNCBGOHDPO = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string MLNAPPBICDG = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CLBDBPDALKH NMCPHEKENHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly BAOGECDAMOO BLJFPJNGPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly BKDAEJIBJAK NBKILBHMBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LPDDOMPGFNK DFHPPDBAGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly BKAHBINOIGO HCOMNDDIDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly OANDENPOHEL MFJFKBENBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly LHAEONLPLMB ADOCEOOMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HLJGGPKNINM GHGMFNEEBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly LHHBLICAGCJ JEEEDOBAMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly OGIDGGHNIHC DDOAIEIAION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly FOLADHMKLIE CALGEFPOPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Dictionary<Guid, int> NMFGAAOJPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IDisposable GOGMMPPJHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private Task LBGBNKLFCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private CancellationTokenSource MNBLLDDCJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long DHJMAMDIJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool FCGEEBKFDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly BLABNGBIGFB NJNNGMPFEKL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private EGNIENKHAKB KGMDPOBKKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x658E050", Offset = "0x658CE50", VA = "0x18658E050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BHHPLLLFBGO HJENGAIFGHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8716B0", Offset = "0x8704B0", VA = "0x1808716B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x871C10", Offset = "0x870A10", VA = "0x180871C10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EOPEMIILONN<FMBMDIHMAAF> GNFJIHNINMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7AF610", Offset = "0x7AE410", VA = "0x1807AF610", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7AF680", Offset = "0x7AE480", VA = "0x1807AF680", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EOPEMIILONN<Guid> CDPNNMIJMNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9A6070", Offset = "0x9A4E70", VA = "0x1809A6070", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9B2690", Offset = "0x9B1490", VA = "0x1809B2690", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x658F1D0", Offset = "0x658DFD0", VA = "0x18658F1D0")]
	[NAAAALLPNIA(KMIEHGCCHON.Session, PBKIGNPNCFO.GameOnly)]
	private static void PMDBOALDHOL(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x658F720", Offset = "0x658E520", VA = "0x18658F720")]
	[Preserve]
	public ABJCEGJPMLM([LICAMFFCLCL(null)] CLBDBPDALKH NMCPHEKENHB, [LICAMFFCLCL(null)] BAOGECDAMOO BLJFPJNGPLG, [LICAMFFCLCL(null)] CGDMBOAPDIA LMIOPABPBEI, [LICAMFFCLCL(null)] BKDAEJIBJAK NBKILBHMBFG, [LICAMFFCLCL(null)] EABCLLPGENL OCEHABDOMFN, [LICAMFFCLCL(null)] LPDDOMPGFNK DFHPPDBAGOB, [LICAMFFCLCL("ShowPurchasePromptRateLimiter")] BKAHBINOIGO HCOMNDDIDCD, [LICAMFFCLCL(null)] OANDENPOHEL MFJFKBENBJO, [LICAMFFCLCL(null)] OGGLGNECAHK CMEIPDHENEC, [LICAMFFCLCL(null)] LHAEONLPLMB ADOCEOOMFBH, [LICAMFFCLCL(null)] HLJGGPKNINM GHGMFNEEBFL, [LICAMFFCLCL(null)] LHHBLICAGCJ JEEEDOBAMJJ, [LICAMFFCLCL(null)] OGIDGGHNIHC DDOAIEIAION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x658C680", Offset = "0x658B480", VA = "0x18658C680", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x658C900", Offset = "0x658B700", VA = "0x18658C900", Slot = "10")]
	[AsyncStateMachine(typeof(IKDHJBNGBKC))]
	public Task<FBEPHKHKLJE<FMBMDIHMAAF, string>> EBLAHEEEINI(long CGIDLDOBHII, string OHHBGJPCFJD, string JFBABPIJMOE, string DCHICAAFAFA, int LAPJPEBECIF, NDEHPGKNCCL KCNNINELJEC, [Optional] Dictionary<Guid, int> KJIIKMGPIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x658EE50", Offset = "0x658DC50", VA = "0x18658EE50", Slot = "11")]
	[AsyncStateMachine(typeof(FNMANGMGDCJ))]
	public Task<FBEPHKHKLJE<FMBMDIHMAAF, string>> NALKMEBPNGJ(Guid JFDFPLHONPD, string OHHBGJPCFJD, string JFBABPIJMOE, string DCHICAAFAFA, int LAPJPEBECIF, NDEHPGKNCCL KCNNINELJEC, [Optional] Dictionary<Guid, int> KJIIKMGPIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x658C1D0", Offset = "0x658AFD0", VA = "0x18658C1D0", Slot = "12")]
	[AsyncStateMachine(typeof(JJMNKGKMOBP))]
	public Task<FBEPHKHKLJE<bool, string>> CMCICMKFDJO(Guid JFDFPLHONPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x658E0A0", Offset = "0x658CEA0", VA = "0x18658E0A0", Slot = "13")]
	public IEnumerable<FMBMDIHMAAF> JGAJAIHDCFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x658E4A0", Offset = "0x658D2A0", VA = "0x18658E4A0", Slot = "14")]
	[AsyncStateMachine(typeof(ELCOLAPLPOH))]
	public Task<List<EHPGOHLABIK>> LLOGNNNBPHG(long CGIDLDOBHII, [Optional] CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x658EFD0", Offset = "0x658DDD0", VA = "0x18658EFD0", Slot = "16")]
	public bool OGCOPPBEKNO(Guid JFDFPLHONPD, int HFNAHOHJPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x658CB60", Offset = "0x658B960", VA = "0x18658CB60", Slot = "15")]
	public bool EJJHFAGBGCH(Guid JFDFPLHONPD, [Out] FMBMDIHMAAF MABALBDICBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x658E160", Offset = "0x658CF60", VA = "0x18658E160", Slot = "17")]
	public void KENJGJBIBFG(MNFCKJNKANA ACNHNLBOPON, Guid JFDFPLHONPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x658C090", Offset = "0x658AE90", VA = "0x18658C090", Slot = "18")]
	[AsyncStateMachine(typeof(AABPNFJDODN))]
	public Task<int> BHACPOIGMJO(MNFCKJNKANA ACNHNLBOPON, Guid JFDFPLHONPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x658CA80", Offset = "0x658B880", VA = "0x18658CA80", Slot = "19")]
	public bool EEAMMDAGBAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x658DBB0", Offset = "0x658C9B0", VA = "0x18658DBB0", Slot = "20")]
	public bool IEENHMILABL(Guid HPIMOBDLJLG, [Out] List<string> ENPNJIMAPCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x658BB30", Offset = "0x658A930", VA = "0x18658BB30", Slot = "21")]
	[AsyncStateMachine(typeof(CLMEDNPGOHD))]
	public Task<FBEPHKHKLJE<bool, string>> AEHKHINBMLA(FMBMDIHMAAF MABALBDICBH, long KGGPLAMMPJC, int LBCEMAMCEGO, string FCIEOFLLLDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x658E5D0", Offset = "0x658D3D0", VA = "0x18658E5D0")]
	[AsyncStateMachine(typeof(DJENFJOMNNK))]
	private Task<FBEPHKHKLJE<bool, string>> MLGFIMHJKHG(FMBMDIHMAAF MABALBDICBH, long KGGPLAMMPJC, long OKAOHPGOHIB, string FCIEOFLLLDL, int LBCEMAMCEGO = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x658CC40", Offset = "0x658BA40", VA = "0x18658CC40")]
	private Task<KDKJMIKONND> GAFBHFNMOEE(FMBMDIHMAAF MABALBDICBH, int LBCEMAMCEGO, int KGGPLAMMPJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x658EAF0", Offset = "0x658D8F0", VA = "0x18658EAF0")]
	private bool MMINPKELHDB(IEnumerable<PAIGFBGCFNP> OPKCFFKGCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x658D270", Offset = "0x658C070", VA = "0x18658D270")]
	private void GLFNMDNODIO(FMBMDIHMAAF MABALBDICBH, long OKAOHPGOHIB, int LBCEMAMCEGO, string FCIEOFLLLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x658BC90", Offset = "0x658AA90", VA = "0x18658BC90")]
	private string AMCEDCHCNFB(FMBMDIHMAAF MABALBDICBH, int LBCEMAMCEGO, string FCIEOFLLLDL, [Optional] LEPCHIDIOBB? BGCCPJGDEGH, [Optional] KIIHPEPFMKD? NNNMLEMNMHM, [Optional] string HOLIHMMGEDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x658BEE0", Offset = "0x658ACE0", VA = "0x18658BEE0")]
	private bool AOMLGDGPNNA(FMBMDIHMAAF FCLFNELGMDG, int LBCEMAMCEGO, [Out] long? OKAOHPGOHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x658D160", Offset = "0x658BF60", VA = "0x18658D160")]
	[AsyncStateMachine(typeof(BOJLFLFLIFB))]
	private Task GHEKMGEHJHE(long CGIDLDOBHII, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x658E730", Offset = "0x658D530", VA = "0x18658E730")]
	private Task MLJCBPKMAND(LMCJHJIAIGC BBFBHKMAMKC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x658DF80", Offset = "0x658CD80", VA = "0x18658DF80")]
	[AsyncStateMachine(typeof(ELPNIANPNLO))]
	private Task IMCFPICLNCL(LMCJHJIAIGC BBFBHKMAMKC, CancellationToken KEIBMFPLBLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x658D850", Offset = "0x658C650", VA = "0x18658D850")]
	private static Dictionary<Guid, int> IANJLFGIJJL(BCAGGENGADC<List<BPICEMMPALJ>> KHPDPDEJNJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x658E150", Offset = "0x658CF50", VA = "0x18658E150")]
	private void JMENKGGKJPD(FMBMDIHMAAF MABALBDICBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x658E430", Offset = "0x658D230", VA = "0x18658E430")]
	private void LINMNNGDKPG(Guid JFDFPLHONPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x658F4B0", Offset = "0x658E2B0", VA = "0x18658F4B0")]
	[MKMMCNOMLCG]
	internal void RpcOfferShowPurchasePrompt(Guid JFDFPLHONPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x658B9F0", Offset = "0x658A7F0", VA = "0x18658B9F0")]
	[AsyncStateMachine(typeof(OCEPCFLGICN))]
	private Task<int> ABIOFIFMCKC(MNFCKJNKANA ACNHNLBOPON, Guid HPIMOBDLJLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x658F2C0", Offset = "0x658E0C0", VA = "0x18658F2C0")]
	[MKMMCNOMLCG]
	internal void RpcGetPlayerRoomOfferPurchaseCount(Guid MBCGHBNLJEN, Guid JFDFPLHONPD, DPDKFPKEKBM LINKNNNEGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x658F240", Offset = "0x658E040", VA = "0x18658F240")]
	[MKMMCNOMLCG]
	internal void RpcGetPlayerRoomOfferPurchaseCountResponse(Guid MBCGHBNLJEN, int BPFMGMBDOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x658C2F0", Offset = "0x658B0F0", VA = "0x18658C2F0", Slot = "23")]
	public string DFNOGALDBJB(LEPCHIDIOBB BGCCPJGDEGH, [Optional] KIIHPEPFMKD? JGMPMOJEHCP, [Optional] BalanceResponseDTO ILAHEBHAALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x658E340", Offset = "0x658D140", VA = "0x18658E340")]
	private static string LBOMNGNOEOL(KIIHPEPFMKD JGMPMOJEHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x658D510", Offset = "0x658C310", VA = "0x18658D510")]
	private FMBMDIHMAAF HAEOKJIHMPM(FMBMDIHMAAF MCIJEAMJACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x658D6B0", Offset = "0x658C4B0", VA = "0x18658D6B0")]
	private void HIMKOLIDFML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x658D720", Offset = "0x658C520", VA = "0x18658D720")]
	private void IAMLIMDGLLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DefaultMember("Item")]
public class FOLADHMKLIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly Dictionary<Guid, FMBMDIHMAAF> FNFFBGBDPIP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long HLEBPLLIAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xE3B780", Offset = "0xE3A580", VA = "0x180E3B780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6592770", Offset = "0x6591570", VA = "0x186592770")]
	public void AAPHEENLIGC(long CGIDLDOBHII, IEnumerable<FMBMDIHMAAF> DIMOEFOHEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6592A00", Offset = "0x6591800", VA = "0x186592A00")]
	public bool ACFDLLLNMIH(Guid JFDFPLHONPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6592B50", Offset = "0x6591950", VA = "0x186592B50")]
	public bool JJGPDDBMEBN(Guid JFDFPLHONPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6592C00", Offset = "0x6591A00", VA = "0x186592C00")]
	public bool PPGJJLDMOJH(FMBMDIHMAAF FGMDBCDLKDC, [Out] FMBMDIHMAAF DANECDGJLOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6592BB0", Offset = "0x65919B0", VA = "0x186592BB0")]
	public IEnumerable<FMBMDIHMAAF> KCEOPPDFGEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6592A60", Offset = "0x6591860", VA = "0x186592A60")]
	public bool EJJHFAGBGCH(Guid JFDFPLHONPD, [Out] FMBMDIHMAAF MABALBDICBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6592AD0", Offset = "0x65918D0", VA = "0x186592AD0")]
	private bool IJPJHAEOCOE(FMBMDIHMAAF OAIFDBCCKDL, FMBMDIHMAAF EMAOLNIJLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6592D50", Offset = "0x6591B50", VA = "0x186592D50")]
	public FOLADHMKLIE()
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
