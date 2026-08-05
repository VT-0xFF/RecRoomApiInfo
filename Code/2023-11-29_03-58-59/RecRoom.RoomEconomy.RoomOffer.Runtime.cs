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
	[Cpp2IlInjected.Address(RVA = "0x63CE370", Offset = "0x63CD770", VA = "0x1863CE370")]
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
	[Cpp2IlInjected.Address(RVA = "0x63CE2B0", Offset = "0x63CD6B0", VA = "0x1863CE2B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x63D4040", Offset = "0x63D3440", VA = "0x1863D4040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x63D4430", Offset = "0x63D3830", VA = "0x1863D4430", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x63D3B10", Offset = "0x63D2F10", VA = "0x1863D3B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x63D3FD0", Offset = "0x63D33D0", VA = "0x1863D3FD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x63D35D0", Offset = "0x63D29D0", VA = "0x1863D35D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x63D3AA0", Offset = "0x63D2EA0", VA = "0x1863D3AA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x63CDD50", Offset = "0x63CD150", VA = "0x1863CDD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x63CE240", Offset = "0x63CD640", VA = "0x1863CE240", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x63CD390", Offset = "0x63CC790", VA = "0x1863CD390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x63CDCE0", Offset = "0x63CD0E0", VA = "0x1863CDCE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x63D2710", Offset = "0x63D1B10", VA = "0x1863D2710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x63D2F00", Offset = "0x63D2300", VA = "0x1863D2F00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x63CE3E0", Offset = "0x63CD7E0", VA = "0x1863CE3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x63CEA50", Offset = "0x63CDE50", VA = "0x1863CEA50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x63D08D0", Offset = "0x63CFCD0", VA = "0x1863D08D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FCJKIAIKOOM OOKFPOJKEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6F0", Offset = "0x8ADAF0", VA = "0x1808AE6F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7D0", Offset = "0x8ADBD0", VA = "0x1808AE7D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x837000", Offset = "0x836400", VA = "0x180837000", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8372D0", Offset = "0x8366D0", VA = "0x1808372D0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x63D18A0", Offset = "0x63D0CA0", VA = "0x1863D18A0")]
	[JMGGEKJCAGA(IHKKALDEJFL.Session, PLCOHLLKCIG.GameOnly)]
	private static void OODFKLIGDLO(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x63D2000", Offset = "0x63D1400", VA = "0x1863D2000")]
	[Preserve]
	public IEKJIDEOGJB([MJHHGJKKIMK(null)] PJBCCNFBKBA DAKMNLGMOMJ, [MJHHGJKKIMK(null)] IPBBIMJHKCP AEELHKOLNIH, [MJHHGJKKIMK(null)] PLDIHAPGPLP GAIMPJOCBOP, [MJHHGJKKIMK(null)] HANGJDNBIMN AJOOMFMLLIF, [MJHHGJKKIMK(null)] IGAHLFFNNPK HKMOFABKBNG, [MJHHGJKKIMK(null)] EKLGCGNBGGK PJKJNIBPDPK, [MJHHGJKKIMK("ShowPurchasePromptRateLimiter")] LGGNEBBFDDB PNGEGADMFLM, [MJHHGJKKIMK(null)] OALDNFNGAID PFGOFFOBICP, [MJHHGJKKIMK(null)] LCMMPKNJDKL MNLFLOOOFMA, [MJHHGJKKIMK(null)] EHJEJFKCPMJ MLBNHGFJLJL, [MJHHGJKKIMK(null)] NDBFAEFJBBJ OHNIOGKJPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x63CFAE0", Offset = "0x63CEEE0", VA = "0x1863CFAE0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x63D0040", Offset = "0x63CF440", VA = "0x1863D0040", Slot = "10")]
	[AsyncStateMachine(typeof(PMCIDOPPAGL))]
	public Task<EFPDAHOJLMO<DJFMEFFIHGP, string>> FHGEOAEHCOD(long IIAJMJMGGCI, string MDFAJJKMBAI, string DACNCMKHPFB, string GLPHFKBONKA, int GAKOKHMGJPD, BNLOLIMMMEE EADCHHLNLGM, [Optional] Dictionary<Guid, int> KKKDOEKEGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x63CEAB0", Offset = "0x63CDEB0", VA = "0x1863CEAB0", Slot = "11")]
	[AsyncStateMachine(typeof(PIOLNJPEBIA))]
	public Task<EFPDAHOJLMO<DJFMEFFIHGP, string>> BCAKNGMEDKP(Guid DILJIDHGEAH, string MDFAJJKMBAI, string DACNCMKHPFB, string GLPHFKBONKA, int GAKOKHMGJPD, BNLOLIMMMEE EADCHHLNLGM, [Optional] Dictionary<Guid, int> KKKDOEKEGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x63D0920", Offset = "0x63CFD20", VA = "0x1863D0920", Slot = "12")]
	[AsyncStateMachine(typeof(MKLLFMCJBGE))]
	public Task<EFPDAHOJLMO<bool, string>> JDANLJFFGLJ(Guid DILJIDHGEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x63D1A90", Offset = "0x63D0E90", VA = "0x1863D1A90", Slot = "13")]
	public IEnumerable<DJFMEFFIHGP> PCKJBJCPJJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x63D0A30", Offset = "0x63CFE30", VA = "0x1863D0A30", Slot = "15")]
	public bool JDKDAHPGELL(Guid DILJIDHGEAH, int DOBADPOACCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x63D0E90", Offset = "0x63D0290", VA = "0x1863D0E90", Slot = "14")]
	public bool LLDAKEHPICA(Guid DILJIDHGEAH, [Out] DJFMEFFIHGP IBAOMNPOIPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x63D0520", Offset = "0x63CF920", VA = "0x1863D0520", Slot = "16")]
	public void HBCEPEDEAAP(MCGPJKMOCMD IFMBCNELBJG, Guid DILJIDHGEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x63D1660", Offset = "0x63D0A60", VA = "0x1863D1660", Slot = "17")]
	public bool OAEEKENBMFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63CF500", Offset = "0x63CE900", VA = "0x1863CF500", Slot = "18")]
	public bool CNFKBMABNIL(Guid DFIBPBBEFMB, [Out] List<string> FDGFCPCBNCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x63D1920", Offset = "0x63D0D20", VA = "0x1863D1920", Slot = "19")]
	[AsyncStateMachine(typeof(CMEDKLIJNEM))]
	public Task<EFPDAHOJLMO<bool, string>> PBKCKCNICDA(DJFMEFFIHGP IBAOMNPOIPO, long NDCEOGIJFLF, int BDILOJCLFKJ, string LAJJCALFFMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x63D1740", Offset = "0x63D0B40", VA = "0x1863D1740")]
	[AsyncStateMachine(typeof(CHCGFMJLBBG))]
	private Task<EFPDAHOJLMO<bool, string>> OGEOELMBAPA(DJFMEFFIHGP IBAOMNPOIPO, long NDCEOGIJFLF, long? AHMGILAHIFK, string LAJJCALFFMH, int BDILOJCLFKJ = 1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63CEFE0", Offset = "0x63CE3E0", VA = "0x1863CEFE0")]
	private Task<NJOAIHAIOOI> CMLPBKAMAJE(DJFMEFFIHGP IBAOMNPOIPO, int BDILOJCLFKJ, int NDCEOGIJFLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x63D0F70", Offset = "0x63D0370", VA = "0x1863D0F70")]
	private bool MPJMEMAPCBH(IEnumerable<PIHBOOPCEPM> LLANOKJEKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x63D0C30", Offset = "0x63D0030", VA = "0x1863D0C30")]
	private void KPOEBFAJDPH(DJFMEFFIHGP IBAOMNPOIPO, long? AHMGILAHIFK, int BDILOJCLFKJ, string LAJJCALFFMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x63D0700", Offset = "0x63CFB00", VA = "0x1863D0700")]
	private string IDFKAEKEFCB(DJFMEFFIHGP IBAOMNPOIPO, int BDILOJCLFKJ, string LAJJCALFFMH, [Optional] IKNHOFMBOHO? KHFCBCPBAFG, [Optional] EMCBOGFFDFF? FCOHCIKBKJK, [Optional] string OHCIHJOIJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x63CFD60", Offset = "0x63CF160", VA = "0x1863CFD60")]
	private bool EHINCNEKIJP(DJFMEFFIHGP IKOPPODPKJO, int BDILOJCLFKJ, [Out] long? AHMGILAHIFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x63D1C80", Offset = "0x63D1080", VA = "0x1863D1C80")]
	[AsyncStateMachine(typeof(IJBAPAPIIMF))]
	private Task PPMHCMGCKBL(long IIAJMJMGGCI, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x63CEC30", Offset = "0x63CE030", VA = "0x1863CEC30")]
	private Task CFCCPJOLOMP(MNNAOFENHED IFILEFKNBLN, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x63D1B40", Offset = "0x63D0F40", VA = "0x1863D1B40")]
	[AsyncStateMachine(typeof(FFKNKMBBPPL))]
	private Task PHBKKGLKCGN(MNNAOFENHED IFILEFKNBLN, CancellationToken PMNAJDAAMLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x63D01C0", Offset = "0x63CF5C0", VA = "0x1863D01C0")]
	private static Dictionary<Guid, int> FNMLIOECPIP(AECHKDDMNMJ<List<LLNGNDNKEON>> DBLNNMKKMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x63D1910", Offset = "0x63D0D10", VA = "0x1863D1910")]
	private void OPFKMJEJNEI(DJFMEFFIHGP IBAOMNPOIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x63CFA70", Offset = "0x63CEE70", VA = "0x1863CFA70")]
	private void DBMDIGJHGCM(Guid DILJIDHGEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x63D1D90", Offset = "0x63D1190", VA = "0x1863D1D90")]
	[PPGFHOMLHFC]
	internal void RpcOfferShowPurchasePrompt(Guid DILJIDHGEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x63D12D0", Offset = "0x63D06D0", VA = "0x1863D12D0", Slot = "21")]
	public string NEJBDFFFLOL(IKNHOFMBOHO KHFCBCPBAFG, [Optional] EMCBOGFFDFF? AAAGPBALKPJ, [Optional] BalanceResponseDTO NNFPHDDIDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x63D0DA0", Offset = "0x63D01A0", VA = "0x1863D0DA0")]
	private static string LDDPLKKDIJH(EMCBOGFFDFF AAAGPBALKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x63CF8D0", Offset = "0x63CECD0", VA = "0x1863CF8D0")]
	private DJFMEFFIHGP DAFIAAPLLBA(DJFMEFFIHGP HEHNJPPHPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x63D1C10", Offset = "0x63D1010", VA = "0x1863D1C10")]
	private void PLGDCMHBEMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x63CFF10", Offset = "0x63CF310", VA = "0x1863CFF10")]
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
		[Cpp2IlInjected.Address(RVA = "0xDC4940", Offset = "0xDC3D40", VA = "0x180DC4940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x63D31E0", Offset = "0x63D25E0", VA = "0x1863D31E0")]
	public void GPMDPFKMODO(long IIAJMJMGGCI, IEnumerable<DJFMEFFIHGP> PDJAOGILACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x63D2FB0", Offset = "0x63D23B0", VA = "0x1863D2FB0")]
	public bool CCIEHPEGPAH(Guid DILJIDHGEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x63D3470", Offset = "0x63D2870", VA = "0x1863D3470")]
	public bool HBMDGHADMGB(Guid DILJIDHGEAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x63D3090", Offset = "0x63D2490", VA = "0x1863D3090")]
	public bool FPAHGACEIPB(DJFMEFFIHGP LACNPDECGBI, [Out] DJFMEFFIHGP PPFANONBFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x63D2F60", Offset = "0x63D2360", VA = "0x1863D2F60")]
	public IEnumerable<DJFMEFFIHGP> BAJMJHHBOGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x63D34D0", Offset = "0x63D28D0", VA = "0x1863D34D0")]
	public bool LLDAKEHPICA(Guid DILJIDHGEAH, [Out] DJFMEFFIHGP IBAOMNPOIPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x63D3010", Offset = "0x63D2410", VA = "0x1863D3010")]
	private bool DMIIBOEACII(DJFMEFFIHGP HHMFGBLJOPM, DJFMEFFIHGP CEEBCGLJBHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x63D3540", Offset = "0x63D2940", VA = "0x1863D3540")]
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
