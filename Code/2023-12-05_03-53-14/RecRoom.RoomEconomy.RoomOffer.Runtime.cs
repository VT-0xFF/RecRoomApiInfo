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
public interface OALDNFNGAID : PILEMJPPKHL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEKJIDEOGJB HHHKHKJHLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IGAHLFFNNPK
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JJOCIMNOBJD IEHDIHLFOIF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DLHEODMNNAH : IGAHLFFNNPK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x63CE290", Offset = "0x63CD690", VA = "0x1863CE290")]
	[JMGGEKJCAGA(IHKKALDEJFL.Session, PLCOHLLKCIG.GameOnly)]
	private static void OODFKLIGDLO(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	[Preserve]
	public DLHEODMNNAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x63CE1D0", Offset = "0x63CD5D0", VA = "0x1863CE1D0", Slot = "4")]
	public JJOCIMNOBJD IEHDIHLFOIF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[GOIFFELMODE]
public class IEKJIDEOGJB : EAEMKEIACHA, IDisposable, GCJKMJNAIEI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct PMCIDOPPAGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<EFPDAHOJLMO<DJFMEFFIHGP, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public IEKJIDEOGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public BNLOLIMMMEE roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<AECHKDDMNMJ<DJFMEFFIHGP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x63D3F60", Offset = "0x63D3360", VA = "0x1863D3F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x63D4350", Offset = "0x63D3750", VA = "0x1863D4350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct PIOLNJPEBIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<EFPDAHOJLMO<DJFMEFFIHGP, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public IEKJIDEOGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public BNLOLIMMMEE roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<AECHKDDMNMJ<DJFMEFFIHGP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x63D3A30", Offset = "0x63D2E30", VA = "0x1863D3A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x63D3EF0", Offset = "0x63D32F0", VA = "0x1863D3EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct MKLLFMCJBGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<EFPDAHOJLMO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IEKJIDEOGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<NAGAPHMDJML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x63D34F0", Offset = "0x63D28F0", VA = "0x1863D34F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x63D39C0", Offset = "0x63D2DC0", VA = "0x1863D39C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct CMEDKLIJNEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<EFPDAHOJLMO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public IEKJIDEOGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public DJFMEFFIHGP roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public string purchaseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<EFPDAHOJLMO<bool, string>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x63CDC70", Offset = "0x63CD070", VA = "0x1863CDC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x63CE160", Offset = "0x63CD560", VA = "0x1863CE160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CHCGFMJLBBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<EFPDAHOJLMO<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int quantity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IEKJIDEOGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public DJFMEFFIHGP roomOffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public string purchaseSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public long requestedPrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public long? initialBalance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private IKNHOFMBOHO <operationResult>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <attemptNumber>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private NJOAIHAIOOI <response>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<NJOAIHAIOOI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x63CD2B0", Offset = "0x63CC6B0", VA = "0x1863CD2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x63CDC00", Offset = "0x63CD000", VA = "0x1863CDC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct IJBAPAPIIMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IEKJIDEOGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private Task<HHNJOGPFCKN<LLNGNDNKEON>> <purchaseCountsTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter<List<DJFMEFFIHGP>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<HHNJOGPFCKN<LLNGNDNKEON>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x63D2630", Offset = "0x63D1A30", VA = "0x1863D2630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x63D2E20", Offset = "0x63D2220", VA = "0x1863D2E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct FFKNKMBBPPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public IEKJIDEOGJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x63CE300", Offset = "0x63CD700", VA = "0x1863CE300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x63CE970", Offset = "0x63CDD70", VA = "0x1863CE970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan HNPKNBDGFLD;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string BCJDFBGDAIG = "econ_room_offer_gate";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string DFAFALJFNPO = "Unknown error occured. If this persists, please contact us at recroom.zendesk.com";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string KFLAJEMJBEB = "CV2_Purchase_Prompt_Chip";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PJBCCNFBKBA DAKMNLGMOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly IPBBIMJHKCP AEELHKOLNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly HANGJDNBIMN AJOOMFMLLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly EKLGCGNBGGK PJKJNIBPDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly LGGNEBBFDDB PNGEGADMFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly OALDNFNGAID PFGOFFOBICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly LCMMPKNJDKL MNLFLOOOFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly EHJEJFKCPMJ MLBNHGFJLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly NDBFAEFJBBJ OHNIOGKJPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JJOCIMNOBJD EIDBEPJDCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Guid, int> FKFENGJPKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly IDisposable PDDFDLICIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Task KEPKFNJFMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private CancellationTokenSource MLLLBLMGKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long NAKPCDBONEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool DEPIKGHNAID;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private BICPFNAHBME NNNMBDMOGFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x63D07F0", Offset = "0x63CFBF0", VA = "0x1863D07F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FCJKIAIKOOM OOKFPOJKEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8AE730", Offset = "0x8ADB30", VA = "0x1808AE730", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8AE810", Offset = "0x8ADC10", VA = "0x1808AE810", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CFBCANLCDFG<DJFMEFFIHGP> GDPBCFPNMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x770C10", Offset = "0x770010", VA = "0x180770C10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x770BA0", Offset = "0x76FFA0", VA = "0x180770BA0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CFBCANLCDFG<Guid> MFNCHGGAHAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x837040", Offset = "0x836440", VA = "0x180837040", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x837310", Offset = "0x836710", VA = "0x180837310", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x63D17C0", Offset = "0x63D0BC0", VA = "0x1863D17C0")]
	[JMGGEKJCAGA(IHKKALDEJFL.Session, PLCOHLLKCIG.GameOnly)]
	private static void OODFKLIGDLO(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x63D1F20", Offset = "0x63D1320", VA = "0x1863D1F20")]
	[Preserve]
	public IEKJIDEOGJB([MJHHGJKKIMK(null)] PJBCCNFBKBA DAKMNLGMOMJ, [MJHHGJKKIMK(null)] IPBBIMJHKCP AEELHKOLNIH, [MJHHGJKKIMK(null)] PLDIHAPGPLP GAIMPJOCBOP, [MJHHGJKKIMK(null)] HANGJDNBIMN AJOOMFMLLIF, [MJHHGJKKIMK(null)] IGAHLFFNNPK HKMOFABKBNG, [MJHHGJKKIMK(null)] EKLGCGNBGGK PJKJNIBPDPK, [MJHHGJKKIMK("ShowPurchasePromptRateLimiter")] LGGNEBBFDDB PNGEGADMFLM, [MJHHGJKKIMK(null)] OALDNFNGAID PFGOFFOBICP, [MJHHGJKKIMK(null)] LCMMPKNJDKL MNLFLOOOFMA, [MJHHGJKKIMK(null)] EHJEJFKCPMJ MLBNHGFJLJL, [MJHHGJKKIMK(null)] NDBFAEFJBBJ OHNIOGKJPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x63CFA00", Offset = "0x63CEE00", VA = "0x1863CFA00", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x63CFF60", Offset = "0x63CF360", VA = "0x1863CFF60", Slot = "10")]
	[AsyncStateMachine(typeof(PMCIDOPPAGL))]
	public Task<EFPDAHOJLMO<DJFMEFFIHGP, string>> FHGEOAEHCOD(long IIAJMJMGGCI, string MDFAJJKMBAI, string DACNCMKHPFB, string GLPHFKBONKA, int GAKOKHMGJPD, BNLOLIMMMEE EADCHHLNLGM, [Optional] Dictionary<Guid, int> KKKDOEKEGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x63CE9D0", Offset = "0x63CDDD0", VA = "0x1863CE9D0", Slot = "11")]
	[AsyncStateMachine(typeof(PIOLNJPEBIA))]
	public Task<EFPDAHOJLMO<DJFMEFFIHGP, string>> BCAKNGMEDKP(Guid DILJIDHGEAH, string MDFAJJKMBAI, string DACNCMKHPFB, string GLPHFKBONKA, int GAKOKHMGJPD, BNLOLIMMMEE EADCHHLNLGM, [Optional] Dictionary<Guid, int> KKKDOEKEGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x63D0840", Offset = "0x63CFC40", VA = "0x1863D0840", Slot = "12")]
	[AsyncStateMachine(typeof(MKLLFMCJBGE))]
	public Task<EFPDAHOJLMO<bool, string>> JDANLJFFGLJ(Guid DILJIDHGEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x63D19B0", Offset = "0x63D0DB0", VA = "0x1863D19B0", Slot = "13")]
	public IEnumerable<DJFMEFFIHGP> PCKJBJCPJJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x63D0950", Offset = "0x63CFD50", VA = "0x1863D0950", Slot = "15")]
	public bool JDKDAHPGELL(Guid DILJIDHGEAH, int DOBADPOACCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x63D0DB0", Offset = "0x63D01B0", VA = "0x1863D0DB0", Slot = "14")]
	public bool LLDAKEHPICA(Guid DILJIDHGEAH, [Out] DJFMEFFIHGP IBAOMNPOIPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x63D0440", Offset = "0x63CF840", VA = "0x1863D0440", Slot = "16")]
	public void HBCEPEDEAAP(MCGPJKMOCMD IFMBCNELBJG, Guid DILJIDHGEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x63D1580", Offset = "0x63D0980", VA = "0x1863D1580", Slot = "17")]
	public bool OAEEKENBMFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63CF420", Offset = "0x63CE820", VA = "0x1863CF420", Slot = "18")]
	public bool CNFKBMABNIL(Guid DFIBPBBEFMB, [Out] List<string> FDGFCPCBNCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x63D1840", Offset = "0x63D0C40", VA = "0x1863D1840", Slot = "19")]
	[AsyncStateMachine(typeof(CMEDKLIJNEM))]
	public Task<EFPDAHOJLMO<bool, string>> PBKCKCNICDA(DJFMEFFIHGP IBAOMNPOIPO, long NDCEOGIJFLF, int BDILOJCLFKJ, string LAJJCALFFMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x63D1660", Offset = "0x63D0A60", VA = "0x1863D1660")]
	[AsyncStateMachine(typeof(CHCGFMJLBBG))]
	private Task<EFPDAHOJLMO<bool, string>> OGEOELMBAPA(DJFMEFFIHGP IBAOMNPOIPO, long NDCEOGIJFLF, long? AHMGILAHIFK, string LAJJCALFFMH, int BDILOJCLFKJ = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63CEF00", Offset = "0x63CE300", VA = "0x1863CEF00")]
	private Task<NJOAIHAIOOI> CMLPBKAMAJE(DJFMEFFIHGP IBAOMNPOIPO, int BDILOJCLFKJ, int NDCEOGIJFLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x63D0E90", Offset = "0x63D0290", VA = "0x1863D0E90")]
	private bool MPJMEMAPCBH(IEnumerable<PIHBOOPCEPM> LLANOKJEKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x63D0B50", Offset = "0x63CFF50", VA = "0x1863D0B50")]
	private void KPOEBFAJDPH(DJFMEFFIHGP IBAOMNPOIPO, long? AHMGILAHIFK, int BDILOJCLFKJ, string LAJJCALFFMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x63D0620", Offset = "0x63CFA20", VA = "0x1863D0620")]
	private string IDFKAEKEFCB(DJFMEFFIHGP IBAOMNPOIPO, int BDILOJCLFKJ, string LAJJCALFFMH, [Optional] IKNHOFMBOHO? KHFCBCPBAFG, [Optional] EMCBOGFFDFF? FCOHCIKBKJK, [Optional] string OHCIHJOIJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x63CFC80", Offset = "0x63CF080", VA = "0x1863CFC80")]
	private bool EHINCNEKIJP(DJFMEFFIHGP IKOPPODPKJO, int BDILOJCLFKJ, [Out] long? AHMGILAHIFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x63D1BA0", Offset = "0x63D0FA0", VA = "0x1863D1BA0")]
	[AsyncStateMachine(typeof(IJBAPAPIIMF))]
	private Task PPMHCMGCKBL(long IIAJMJMGGCI, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x63CEB50", Offset = "0x63CDF50", VA = "0x1863CEB50")]
	private Task CFCCPJOLOMP(MNNAOFENHED IFILEFKNBLN, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x63D1A60", Offset = "0x63D0E60", VA = "0x1863D1A60")]
	[AsyncStateMachine(typeof(FFKNKMBBPPL))]
	private Task PHBKKGLKCGN(MNNAOFENHED IFILEFKNBLN, CancellationToken PMNAJDAAMLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x63D00E0", Offset = "0x63CF4E0", VA = "0x1863D00E0")]
	private static Dictionary<Guid, int> FNMLIOECPIP(AECHKDDMNMJ<List<LLNGNDNKEON>> DBLNNMKKMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x63D1830", Offset = "0x63D0C30", VA = "0x1863D1830")]
	private void OPFKMJEJNEI(DJFMEFFIHGP IBAOMNPOIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x63CF990", Offset = "0x63CED90", VA = "0x1863CF990")]
	private void DBMDIGJHGCM(Guid DILJIDHGEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x63D1CB0", Offset = "0x63D10B0", VA = "0x1863D1CB0")]
	[PPGFHOMLHFC]
	internal void RpcOfferShowPurchasePrompt(Guid DILJIDHGEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x63D11F0", Offset = "0x63D05F0", VA = "0x1863D11F0", Slot = "21")]
	public string NEJBDFFFLOL(IKNHOFMBOHO KHFCBCPBAFG, [Optional] EMCBOGFFDFF? AAAGPBALKPJ, [Optional] BalanceResponseDTO NNFPHDDIDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x63D0CC0", Offset = "0x63D00C0", VA = "0x1863D0CC0")]
	private static string LDDPLKKDIJH(EMCBOGFFDFF AAAGPBALKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x63CF7F0", Offset = "0x63CEBF0", VA = "0x1863CF7F0")]
	private DJFMEFFIHGP DAFIAAPLLBA(DJFMEFFIHGP HEHNJPPHPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x63D1B30", Offset = "0x63D0F30", VA = "0x1863D1B30")]
	private void PLGDCMHBEMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x63CFE30", Offset = "0x63CF230", VA = "0x1863CFE30")]
	private void FCKBAKHDNBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DefaultMember("Item")]
public class JJOCIMNOBJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Dictionary<Guid, DJFMEFFIHGP> MNODIPHKNIL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long PHFFEMHIMBO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xDC49F0", Offset = "0xDC3DF0", VA = "0x180DC49F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x63D3100", Offset = "0x63D2500", VA = "0x1863D3100")]
	public void GPMDPFKMODO(long IIAJMJMGGCI, IEnumerable<DJFMEFFIHGP> PDJAOGILACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x63D2ED0", Offset = "0x63D22D0", VA = "0x1863D2ED0")]
	public bool CCIEHPEGPAH(Guid DILJIDHGEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x63D3390", Offset = "0x63D2790", VA = "0x1863D3390")]
	public bool HBMDGHADMGB(Guid DILJIDHGEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x63D2FB0", Offset = "0x63D23B0", VA = "0x1863D2FB0")]
	public bool FPAHGACEIPB(DJFMEFFIHGP LACNPDECGBI, [Out] DJFMEFFIHGP PPFANONBFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x63D2E80", Offset = "0x63D2280", VA = "0x1863D2E80")]
	public IEnumerable<DJFMEFFIHGP> BAJMJHHBOGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x63D33F0", Offset = "0x63D27F0", VA = "0x1863D33F0")]
	public bool LLDAKEHPICA(Guid DILJIDHGEAH, [Out] DJFMEFFIHGP IBAOMNPOIPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x63D2F30", Offset = "0x63D2330", VA = "0x1863D2F30")]
	private bool DMIIBOEACII(DJFMEFFIHGP HHMFGBLJOPM, DJFMEFFIHGP CEEBCGLJBHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x63D3460", Offset = "0x63D2860", VA = "0x1863D3460")]
	public JJOCIMNOBJD()
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
