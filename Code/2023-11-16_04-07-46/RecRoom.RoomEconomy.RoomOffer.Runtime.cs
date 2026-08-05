using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PPEGLGFGGFD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ELFGEOBBGOD BIFKALDNPMM();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LBJHHEFNPDH : PPEGLGFGGFD
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x63AEBC0", Offset = "0x63ADBC0", VA = "0x1863AEBC0")]
	[PKDJMILODMH(OPHHJIDIAGK.Session, OMIAJJHDDGO.GameOnly)]
	private static void DFABGLAHNPD(EIABFOFJCDK KMOLABGHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	[Preserve]
	public LBJHHEFNPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x63AEB00", Offset = "0x63ADB00", VA = "0x1863AEB00", Slot = "4")]
	public ELFGEOBBGOD BIFKALDNPMM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NGJHEGAFALJ : IBGMJADFFKM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct FLKLAKJGHGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<CJDJPCEAKND<GHBHEBNODNK, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public NGJHEGAFALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public KBNOFAKDMEK roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<OHGFOEHGKOI<GHBHEBNODNK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x63AD9F0", Offset = "0x63AC9F0", VA = "0x1863AD9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x63ADDE0", Offset = "0x63ACDE0", VA = "0x1863ADDE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct BBGGMAPBHGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<CJDJPCEAKND<GHBHEBNODNK, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public NGJHEGAFALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public KBNOFAKDMEK roomOfferType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Dictionary<Guid, int> roomInventoryItemMappings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<OHGFOEHGKOI<GHBHEBNODNK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x63AC840", Offset = "0x63AB840", VA = "0x1863AC840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x63ACD00", Offset = "0x63ABD00", VA = "0x1863ACD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct CLJKLFMDDBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<CJDJPCEAKND<bool, string>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public NGJHEGAFALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public Guid roomOfferId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<FIDDDCEKIMO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x63ACD70", Offset = "0x63ABD70", VA = "0x1863ACD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x63AD240", Offset = "0x63AC240", VA = "0x1863AD240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct IAAEHLKIOLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public NGJHEGAFALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<List<GHBHEBNODNK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x63AE520", Offset = "0x63AD520", VA = "0x1863AE520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x63AEAA0", Offset = "0x63ADAA0", VA = "0x1863AEAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct GLOCILFMOCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public NGJHEGAFALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<Task> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x63ADE50", Offset = "0x63ACE50", VA = "0x1863ADE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x63AE4C0", Offset = "0x63AD4C0", VA = "0x1863AE4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly TimeSpan GCILMIOLADK;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string HGMNACDGEHO = "econ_room_offer_gate";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly GHJPGMGFJOM MPLHEDNHJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly AIDLDNNCJGB JBGLADDMNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly KAECFHBLNDP LGGCFFGCGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly LOHIMAIEHBA KFCIAAEHNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly ELFGEOBBGOD HDMIJJFPHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly IDisposable HKCCBIBPFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task PHODHIPHFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource NDEMAKPPOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private long NHCONKKDNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool BKIGCJKEOGE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DNHICBJBOMM LGKABHEIACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x773900", Offset = "0x772900", VA = "0x180773900", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7738D0", Offset = "0x7728D0", VA = "0x1807738D0", Slot = "16")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JEHDIEPKPPJ<GHBHEBNODNK> DKCOIDFJKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x7728A0", VA = "0x1807738A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x7728B0", VA = "0x1807738B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JEHDIEPKPPJ<Guid> BCAHBMAKJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7793B0", Offset = "0x7783B0", VA = "0x1807793B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7793C0", Offset = "0x7783C0", VA = "0x1807793C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x63AF080", Offset = "0x63AE080", VA = "0x1863AF080")]
	[PKDJMILODMH(OPHHJIDIAGK.Session, OMIAJJHDDGO.GameOnly)]
	private static void DFABGLAHNPD(EIABFOFJCDK KMOLABGHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x63B02E0", Offset = "0x63AF2E0", VA = "0x1863B02E0")]
	[Preserve]
	public NGJHEGAFALJ([KHIPNIHHNOH(null)] GHJPGMGFJOM MPLHEDNHJND, [KHIPNIHHNOH(null)] AIDLDNNCJGB JBGLADDMNJH, [KHIPNIHHNOH(null)] ADLKEDDOLEI LGECLPEJCKC, [KHIPNIHHNOH(null)] KAECFHBLNDP LGGCFFGCGME, [KHIPNIHHNOH(null)] PPEGLGFGGFD FJBMJKGFNPE, [KHIPNIHHNOH(null)] LOHIMAIEHBA KFCIAAEHNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x63AF200", Offset = "0x63AE200", VA = "0x1863AF200", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x63AEC30", Offset = "0x63ADC30", VA = "0x1863AEC30", Slot = "8")]
	[AsyncStateMachine(typeof(FLKLAKJGHGL))]
	public Task<CJDJPCEAKND<GHBHEBNODNK, string>> AKJOGLLBGBF(long KAOIBEOBDCN, string JNMEJDHMADI, string BEOAJBBECNO, string GBFFJBCAJEE, int LMGNEIDMDPO, KBNOFAKDMEK GAJFOOPMICH, [Optional] Dictionary<Guid, int> LEIMNOEMAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x63AF9E0", Offset = "0x63AE9E0", VA = "0x1863AF9E0", Slot = "9")]
	[AsyncStateMachine(typeof(BBGGMAPBHGL))]
	public Task<CJDJPCEAKND<GHBHEBNODNK, string>> FOJEPOLLFFM(Guid PHPJEFMLELP, string JNMEJDHMADI, string BEOAJBBECNO, string GBFFJBCAJEE, int LMGNEIDMDPO, KBNOFAKDMEK GAJFOOPMICH, [Optional] Dictionary<Guid, int> LEIMNOEMAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x63AFFB0", Offset = "0x63AEFB0", VA = "0x1863AFFB0", Slot = "10")]
	[AsyncStateMachine(typeof(CLJKLFMDDBL))]
	public Task<CJDJPCEAKND<bool, string>> JPOGOHLHNLL(Guid PHPJEFMLELP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x63AF930", Offset = "0x63AE930", VA = "0x1863AF930", Slot = "11")]
	public IEnumerable<GHBHEBNODNK> FIJHJGGBPAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x63AF450", Offset = "0x63AE450", VA = "0x1863AF450", Slot = "12")]
	public bool ELNMBFCNFIH(Guid PHPJEFMLELP, [Out] GHBHEBNODNK OLGHBOEBBCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x63B00C0", Offset = "0x63AF0C0", VA = "0x1863B00C0", Slot = "17")]
	public bool LKBJBGOMIIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x63AFBE0", Offset = "0x63AEBE0", VA = "0x1863AFBE0", Slot = "13")]
	public bool JCLFJCADDMJ(Guid MLKBMJHEECD, [Out] List<string> AJLALAILFFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x63AF0F0", Offset = "0x63AE0F0", VA = "0x1863AF0F0")]
	[AsyncStateMachine(typeof(IAAEHLKIOLI))]
	private Task DJDEBJPDHHN(long KAOIBEOBDCN, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x63AF590", Offset = "0x63AE590", VA = "0x1863AF590")]
	private Task FIJANDDMECC(LLGCMGAEGBM IEECDEJOFJP, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x63B01A0", Offset = "0x63AF1A0", VA = "0x1863B01A0")]
	[AsyncStateMachine(typeof(GLOCILFMOCI))]
	private Task NCDBACBECOG(LLGCMGAEGBM IEECDEJOFJP, CancellationToken KAKGIKEALLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63AFB60", Offset = "0x63AEB60", VA = "0x1863AFB60")]
	private void GCEFKEDPFHI(GHBHEBNODNK OLGHBOEBBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x63AF520", Offset = "0x63AE520", VA = "0x1863AF520")]
	private void FCOBMALCDOO(Guid PHPJEFMLELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x63AEDB0", Offset = "0x63ADDB0", VA = "0x1863AEDB0")]
	private GHBHEBNODNK BJLDDPGHHNO(GHBHEBNODNK EAMGFMPJEGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63AFB70", Offset = "0x63AEB70", VA = "0x1863AFB70")]
	private void GFFPLONJFHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x63AEF50", Offset = "0x63ADF50", VA = "0x1863AEF50")]
	private void CPMGBFFOOIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class ELFGEOBBGOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<Guid, GHBHEBNODNK> LCMBPFCEKII;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public long AFIMLDIFEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xD8D280", Offset = "0xD8C280", VA = "0x180D8D280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GHBHEBNODNK KHIKFGEKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x63AD560", Offset = "0x63AC560", VA = "0x1863AD560")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x63AD4F0", Offset = "0x63AC4F0", VA = "0x1863AD4F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x63AD620", Offset = "0x63AC620", VA = "0x1863AD620")]
	public void LCEKOJAFLKD(long KAOIBEOBDCN, IEnumerable<GHBHEBNODNK> JDEMPBLKALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x63AD5C0", Offset = "0x63AC5C0", VA = "0x1863AD5C0")]
	public bool IMOKKBJCLDH(Guid PHPJEFMLELP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x63AD8B0", Offset = "0x63AC8B0", VA = "0x1863AD8B0")]
	public bool MOJJDBCCFOB(Guid PHPJEFMLELP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x63AD330", Offset = "0x63AC330", VA = "0x1863AD330")]
	public bool DOLKNIIEKOF(GHBHEBNODNK BPEGPICDAAP, [Out] GHBHEBNODNK DLODMOECIKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x63AD910", Offset = "0x63AC910", VA = "0x1863AD910")]
	public IEnumerable<GHBHEBNODNK> NJOGBOEKGEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x63AD480", Offset = "0x63AC480", VA = "0x1863AD480")]
	public bool ELNMBFCNFIH(Guid PHPJEFMLELP, [Out] GHBHEBNODNK OLGHBOEBBCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x63AD2B0", Offset = "0x63AC2B0", VA = "0x1863AD2B0")]
	private bool DHJLGAFNFKN(GHBHEBNODNK KMHOGAFNGBN, GHBHEBNODNK MJAIFLKJMLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x63AD960", Offset = "0x63AC960", VA = "0x1863AD960")]
	public ELFGEOBBGOD()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OHHMJHHAJKD
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public OHHMJHHAJKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x55E0FB0", Offset = "0x55DFFB0", VA = "0x1855E0FB0")]
	public static string JOPIJCKBKMG(byte[] JJHEHDKNEPF, byte[] JAFPDGGIPFD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
