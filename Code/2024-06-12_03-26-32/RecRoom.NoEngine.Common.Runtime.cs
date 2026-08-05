using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69A0300", Offset = "0x699EF00", VA = "0x1869A0300")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IDGDEMNJAAI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x699B120", Offset = "0x6999D20", VA = "0x18699B120")]
	public static string HCBFGBKOCGD(this Encoding ENDIIGLFMNM, [In] ReadOnlySequence<byte> HNGDLLNOPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B38490", Offset = "0x2B37090", VA = "0x182B38490")]
	private static void ADFEPLLIKBH<T>(this ReadOnlySequence<T> DKDOBLCBHIB, [Out] ReadOnlySpan<T> MMPEJEIMMID, [Out] SequencePosition HCOPCPFHNHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class GACNDNIPDBC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x699A2C0", Offset = "0x6998EC0", VA = "0x18699A2C0")]
	public GACNDNIPDBC(bool HKMNFHJIBMP, string CIKBDIENODJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BEFLJMHFLAG
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PCNBCGBCDDK<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate Task<TResult> FEAEHIANLNF(CancellationToken MPLCHGMFENA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct GKIMKDPLOCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public PCNBCGBCDDK<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public FEAEHIANLNF taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3CB87E0", Offset = "0x3CB73E0", VA = "0x183CB87E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3CB98B0", Offset = "0x3CB84B0", VA = "0x183CB98B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource BMBBMOBAEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? OHJDBKFDOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? GLIJFILGBNN;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x46F24B0", Offset = "0x46F10B0", VA = "0x1846F24B0")]
	[AsyncStateMachine(typeof(PCNBCGBCDDK<>.GKIMKDPLOCO))]
	public Task<TResult> PEMMJNKKNGH(FEAEHIANLNF KMFDHDAECEB, [Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x46F2440", Offset = "0x46F1040", VA = "0x1846F2440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x46F25F0", Offset = "0x46F11F0", VA = "0x1846F25F0")]
	public PCNBCGBCDDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class DPPBOAJDNEH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> CKEOGDEFNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T EPAONLOANJK;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x43F1D50", Offset = "0x43F0950", VA = "0x1843F1D50")]
	public DPPBOAJDNEH([In] T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x57FBBB0", Offset = "0x57FA7B0", VA = "0x1857FBBB0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x57FC420", Offset = "0x57FB020", VA = "0x1857FC420", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x57FC510", Offset = "0x57FB110", VA = "0x1857FC510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class DBAPJAPFDDC
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x292BA60", Offset = "0x292A660", VA = "0x18292BA60")]
	public static DPPBOAJDNEH<T> PPOPBMPFEOP<T>([In] T GLMEMJNJKAN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GAKONDDBKKD
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x699A3A0", Offset = "0x6998FA0", VA = "0x18699A3A0")]
	public static void ALEPLHBNPHH(this CancellationTokenSource BMBBMOBAEFA, bool PHHOECAJACO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class AEPJOCDMCFE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
	public AEPJOCDMCFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class DAGNLHKDNMD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
	public DAGNLHKDNMD(string IHFMBNJFBID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BBACKAPJJNA
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x287F390", Offset = "0x287DF90", VA = "0x18287F390")]
	public static NNGHJDCGFMF PNHMOAIIIKM<T>()
	{
		return default(NNGHJDCGFMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x287F070", Offset = "0x287DC70", VA = "0x18287F070")]
	public static NNGHJDCGFMF COHCJGKDELC<T>([CallerMemberName] string GFLNGGKHEOH = "") where T : notnull
	{
		return default(NNGHJDCGFMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x287F310", Offset = "0x287DF10", VA = "0x18287F310")]
	public static NNGHJDCGFMF PNHMOAIIIKM<T>(this T KGECOLOELOJ) where T : notnull
	{
		return default(NNGHJDCGFMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x287F1C0", Offset = "0x287DDC0", VA = "0x18287F1C0")]
	public static NNGHJDCGFMF DCNINDONADN<T>(this T KGECOLOELOJ, [CallerMemberName] string GFLNGGKHEOH = "") where T : notnull
	{
		return default(NNGHJDCGFMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x287F110", Offset = "0x287DD10", VA = "0x18287F110")]
	public static NNGHJDCGFMF COHCJGKDELC<T>(this T HNFMOHFACKF, [CallerMemberName] string GFLNGGKHEOH = "") where T : notnull
	{
		return default(NNGHJDCGFMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6998A30", Offset = "0x6997630", VA = "0x186998A30")]
	public static NNGHJDCGFMF COHCJGKDELC(string DHPNILMBNKE, [CallerMemberName] string GFLNGGKHEOH = "")
	{
		return default(NNGHJDCGFMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6998AB0", Offset = "0x69976B0", VA = "0x186998AB0")]
	public static string PEFCEIFKMDM(this object HNFMOHFACKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate bool OCDBFKFKDJJ();
[Cpp2IlInjected.Token(Token = "0x2000013")]
[AEPJOCDMCFE]
public delegate long NEMKBDBCMPF();
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class OEPPANAKAKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static ADDEJLHGDMC NEBJPHCFNHP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static ADDEJLHGDMC OKHFKLNLPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x69A05B0", Offset = "0x699F1B0", VA = "0x1869A05B0")]
		get
		{
			return default(ADDEJLHGDMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static ABBAOPDFBBD DHOEFMLBFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69A0510", Offset = "0x699F110", VA = "0x1869A0510")]
		get
		{
			return default(ABBAOPDFBBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static ANAEOCDPBDB MDBBIBOOLMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69A0560", Offset = "0x699F160", VA = "0x1869A0560")]
		get
		{
			return default(ANAEOCDPBDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool HFPOMHIHCGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x69A0600", Offset = "0x699F200", VA = "0x1869A0600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69A0920", Offset = "0x699F520", VA = "0x1869A0920")]
	public static void OFOMPOOKKCN([In] ADDEJLHGDMC OLOEHKIMACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69A0740", Offset = "0x699F340", VA = "0x1869A0740")]
	public static void LCOFNOOCLJC(string JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69A0AD0", Offset = "0x699F6D0", VA = "0x1869A0AD0")]
	public static void OOAGCEDPLHB(string JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7580", Offset = "0x2CD6180", VA = "0x182CD7580")]
	public static void OOAGCEDPLHB<T>(T KDGMEPEFEJC, GOCOGDOFHFI<T> JIMAFLGJGFB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x69A0470", Offset = "0x699F070", VA = "0x1869A0470")]
	public static void DPJEFLLPANG(Exception JNLFEIJKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x69A0380", Offset = "0x699EF80", VA = "0x1869A0380")]
	public static void CDNMJDEIBAL(string GFLNGGKHEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69A0400", Offset = "0x699F000", VA = "0x1869A0400")]
	public static void DNIPBEMPPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69A0BA0", Offset = "0x699F7A0", VA = "0x1869A0BA0")]
	public static string PEFCEIFKMDM(object HAHECKLGOJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69A0810", Offset = "0x699F410", VA = "0x1869A0810")]
	public static long MGHNHONDMJA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x69A0880", Offset = "0x699F480", VA = "0x1869A0880")]
	public static bool OANKPECCLIF(bool OINKDIMBFCD, string JIMAFLGJGFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69A0670", Offset = "0x699F270", VA = "0x1869A0670")]
	public static double KHBMONIOFAP()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct ADDEJLHGDMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly ABBAOPDFBBD DHOEFMLBFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly ANAEOCDPBDB MDBBIBOOLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly HBLJCKGLAAN JLNLJJEFJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly NEMKBDBCMPF POHHLEMNNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly NJHHIGJGCIN HENEPJMHBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly OCDBFKFKDJJ OMKNHHAAOGG;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly HBLJCKGLAAN PELNIIBEFDA;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly NEMKBDBCMPF FIGDNLNNLOA;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly NJHHIGJGCIN FODONMMOIIC;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly OCDBFKFKDJJ GAHIMGPFIBI;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly ADDEJLHGDMC BBCAMDNMADI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IHNECOIEJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6997920", Offset = "0x6996520", VA = "0x186997920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6998300", Offset = "0x6996F00", VA = "0x186998300")]
	public ADDEJLHGDMC([In] ABBAOPDFBBD HGNPKHLFDEK, [In] ANAEOCDPBDB MANOCAKPFNK, HBLJCKGLAAN OHHMFCBODPJ, NEMKBDBCMPF MCOIMJHDACC, NJHHIGJGCIN FIPFLINCAGL, OCDBFKFKDJJ BPPCOKCCOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6997BD0", Offset = "0x69967D0", VA = "0x186997BD0")]
	private static string NGCOEKMOHHA(object HAHECKLGOJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0")]
	private static long OMLCHJCNLAO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
	private static string IDDECOOJJJN(string OGFFIPCKAML, string? HLLDCJMGAKE, bool HMKPDBCIGNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10")]
	private static bool CHDFHKGBPLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6997AC0", Offset = "0x69966C0", VA = "0x186997AC0")]
	private static ADDEJLHGDMC MIMHDHHJLAE()
	{
		return default(ADDEJLHGDMC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DEKNPHKEEJC
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HFIDHKABPBB EADJJONFAJP();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HFIDHKABPBB : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BGOANOOCCPN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBBIGJGAGKO();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface AAKCPPDLFNK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JDBLILIAMFK([In] T OCNJFCPHJLD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate void DHFBGFGDOHJ<T>([In] T KDGMEPEFEJC);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct NPMFAEACIPK<T> : IEquatable<NPMFAEACIPK<T>>, AAKCPPDLFNK<NPMFAEACIPK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T EPAONLOANJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int HDEPOMLIBHF;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6C00", Offset = "0x1FA5800", VA = "0x181FA6C00")]
	public NPMFAEACIPK([In] T GLMEMJNJKAN, int OPDMGNJCACB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x44A4D30", Offset = "0x44A3930", VA = "0x1844A4D30")]
	public static bool NBAHCGFACIA([In] NPMFAEACIPK<T> HOGIDEMINCM, [In] NPMFAEACIPK<T> FKJHDCOBNND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3E37F30", Offset = "0x3E36B30", VA = "0x183E37F30", Slot = "4")]
	public bool Equals(NPMFAEACIPK<T> OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3C706A0", Offset = "0x3C6F2A0", VA = "0x183C706A0", Slot = "0")]
	public override bool Equals(object OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x44A49D0", Offset = "0x44A35D0", VA = "0x1844A49D0")]
	public bool JDBLILIAMFK([In] NPMFAEACIPK<T> OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x44A4840", Offset = "0x44A3440", VA = "0x1844A4840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x44A5240", Offset = "0x44A3E40", VA = "0x1844A5240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x44A3BB0", Offset = "0x44A27B0", VA = "0x1844A3BB0")]
	public void ALCMIDHBGAI([Out] T GLMEMJNJKAN, [Out] int OPDMGNJCACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x44A4260", Offset = "0x44A2E60", VA = "0x1844A4260")]
	public (T, int) DIPACOKBEHG()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x44A44B0", Offset = "0x44A30B0", VA = "0x1844A44B0", Slot = "5")]
	private bool DNHCCAKBJBF([In] NPMFAEACIPK<T> OCNJFCPHJLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class HLHALEIFADA
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2B1FDA0", Offset = "0x2B1E9A0", VA = "0x182B1FDA0")]
	public static NPMFAEACIPK<T> PPOPBMPFEOP<T>([In] T GLMEMJNJKAN, int OPDMGNJCACB) where T : notnull
	{
		return default(NPMFAEACIPK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HJDPPIPOBOM
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2B1AEA0", Offset = "0x2B19AA0", VA = "0x182B1AEA0")]
	public static bool JDBLILIAMFK<T, U>([In] T HNFMOHFACKF, [In] U HAHECKLGOJC) where T : notnull, AAKCPPDLFNK<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public delegate TResult AOGFEAHIOKI<T, out TResult>([In] T KDGMEPEFEJC);
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GMOMKBDOINE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan JKEHGDMDFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? DJHPACEKNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NBMNJOJAEEO();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HAGCANPLAGD();

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PMLHLALIMBP();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct ABBAOPDFBBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly LFHONOKAJKL EDDPEHDBNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly PLAIJMLGMPB PDMHFGBOANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly LFHONOKAJKL IBOHFPNNCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly PLAIJMLGMPB LHBCNBLCHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly LFHONOKAJKL MFEADIPJNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly PLAIJMLGMPB HKLOFHFEEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly CBBCFGHGDJO ELGFGHNGGOD;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly LFHONOKAJKL MCINMBKLIAE;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly PLAIJMLGMPB MKCJEPPPKBD;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly LFHONOKAJKL HBDHJIABDCO;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly PLAIJMLGMPB BMBMGCPJIAI;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly LFHONOKAJKL FHNNAKGOHPN;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly PLAIJMLGMPB HOIOPFFFFLN;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly CBBCFGHGDJO CHFLLEEPODA;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly ABBAOPDFBBD BBCAMDNMADI;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly LFHONOKAJKL EHFECGEELIH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IHNECOIEJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6996D70", Offset = "0x6995970", VA = "0x186996D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xB142F0", Offset = "0xB12EF0", VA = "0x180B142F0")]
	public ABBAOPDFBBD(LFHONOKAJKL EEAHAODMBDC, PLAIJMLGMPB AEOGJJPMIKK, LFHONOKAJKL HNNHOGGHGIE, PLAIJMLGMPB CMBLBOFBLAP, LFHONOKAJKL FOCIIHCGMCE, PLAIJMLGMPB KGGOEMLBPAD, CBBCFGHGDJO BJKOOBMKDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10")]
	private static bool DBGLFMMPOEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	private static void MJPCLCDMCHH(string JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10")]
	private static bool KOOGGCFHBGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	private static void MGCMPGKIHFH(string JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10")]
	private static bool BLBGPPMDKDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	private static void KCPCIKFANJM(string JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	private static void HGDLJODCDNI(Exception JNLFEIJKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6996FE0", Offset = "0x6995BE0", VA = "0x186996FE0")]
	private static ABBAOPDFBBD MIMHDHHJLAE()
	{
		return default(ABBAOPDFBBD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420")]
	private static bool BBKCCLDDCCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6996F70", Offset = "0x6995B70", VA = "0x186996F70")]
	public void LCOFNOOCLJC(object JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x69972D0", Offset = "0x6995ED0", VA = "0x1869972D0")]
	public void OOAGCEDPLHB(object JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1BCAC60", Offset = "0x1BC9860", VA = "0x181BCAC60")]
	public void DPJEFLLPANG(Exception JNLFEIJKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x69971F0", Offset = "0x6995DF0", VA = "0x1869971F0")]
	public void OOAGCEDPLHB(DKLADOMLNBB JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x31D5FD0", Offset = "0x31D4BD0", VA = "0x1831D5FD0")]
	public void OOAGCEDPLHB<T>(T KDGMEPEFEJC, GOCOGDOFHFI<T> JIMAFLGJGFB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x31D5D60", Offset = "0x31D4960", VA = "0x1831D5D60")]
	public void LCOFNOOCLJC<T>([In] T KDGMEPEFEJC, GLANJHDJGLI<T> JIMAFLGJGFB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x31D5F00", Offset = "0x31D4B00", VA = "0x1831D5F00")]
	public void OOAGCEDPLHB<T>([In] T KDGMEPEFEJC, GLANJHDJGLI<T> JIMAFLGJGFB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6997120", Offset = "0x6995D20", VA = "0x186997120")]
	public bool OANKPECCLIF(bool OINKDIMBFCD, string JIMAFLGJGFB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct NNGHJDCGFMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string EPAONLOANJK;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9295C0", Offset = "0x9281C0", VA = "0x1809295C0")]
	public NNGHJDCGFMF(string GLMEMJNJKAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
	public static string NBHHLKKAPBL([In] NNGHJDCGFMF HNFMOHFACKF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x96B4D0", Offset = "0x96A0D0", VA = "0x18096B4D0")]
	public static NNGHJDCGFMF NBHHLKKAPBL(string OCNJFCPHJLD)
	{
		return default(NNGHJDCGFMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69A01D0", Offset = "0x699EDD0", VA = "0x1869A01D0")]
	public string KBDCAEBFKIN(string AOENKIEOODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x69A0220", Offset = "0x699EE20", VA = "0x1869A0220")]
	public string MENLJCPDGPA(object MEIOPBDHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct LOGIJBPEHJN : IEquatable<LOGIJBPEHJN>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "4")]
	public bool Equals(LOGIJBPEHJN OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x699F9B0", Offset = "0x699E5B0", VA = "0x18699F9B0", Slot = "0")]
	public override bool Equals(object OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x699FA00", Offset = "0x699E600", VA = "0x18699FA00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x699FA10", Offset = "0x699E610", VA = "0x18699FA10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DKPEDCBOHDB("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct IJOGPJMNLNP<T> : IEquatable<IJOGPJMNLNP<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T EPAONLOANJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool FEAFHBPIMIG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool ICLDBCELCLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3E38720", Offset = "0x3E37320", VA = "0x183E38720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3E39150", Offset = "0x3E37D50", VA = "0x183E39150")]
	public IJOGPJMNLNP([In] T GLMEMJNJKAN, bool HAPDGOPAKLN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3E38A40", Offset = "0x3E37640", VA = "0x183E38A40")]
	public static bool NBAHCGFACIA([In] IJOGPJMNLNP<T> HOGIDEMINCM, [In] IJOGPJMNLNP<T> FKJHDCOBNND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3E37F30", Offset = "0x3E36B30", VA = "0x183E37F30", Slot = "4")]
	public bool Equals(IJOGPJMNLNP<T> OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3E38410", Offset = "0x3E37010", VA = "0x183E38410", Slot = "0")]
	public override bool Equals(object OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3E38860", Offset = "0x3E37460", VA = "0x183E38860", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3E38E40", Offset = "0x3E37A40", VA = "0x183E38E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class CFMPKHBMBOP
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x28E72E0", Offset = "0x28E5EE0", VA = "0x1828E72E0")]
	public static IJOGPJMNLNP<T> KGOGPGIILCH<T>([In] T GLMEMJNJKAN) where T : notnull
	{
		return default(IJOGPJMNLNP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x28E71B0", Offset = "0x28E5DB0", VA = "0x1828E71B0")]
	public static IJOGPJMNLNP<T?> JJCPLMPECOK<T>()
	{
		return default(IJOGPJMNLNP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x28E73A0", Offset = "0x28E5FA0", VA = "0x1828E73A0")]
	public static bool OPNMFEDOFMK<T>([In] this IJOGPJMNLNP<T> NCNOCBJEIAC, [Out][NotNullWhen(true)] T GLMEMJNJKAN) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct ANAEOCDPBDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr CDNMJDEIBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr DNIPBEMPPBK;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr DFCHJFMBOBF;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr DAODJEBOAKO;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly ANAEOCDPBDB BBCAMDNMADI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IHNECOIEJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6998700", Offset = "0x6997300", VA = "0x186998700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xA93C90", Offset = "0xA92890", VA = "0x180A93C90")]
	public ANAEOCDPBDB(IntPtr AKBCNJKLAJC, IntPtr GHAMEPNIACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	private static void NIMPPGFABNO(string GFLNGGKHEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	private static void HEELPDBMCEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x69987E0", Offset = "0x69973E0", VA = "0x1869987E0")]
	private static ANAEOCDPBDB MIMHDHHJLAE()
	{
		return default(ANAEOCDPBDB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct JOHHMIDNDIB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr INEFJICDCNN;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9295C0", Offset = "0x9281C0", VA = "0x1809295C0")]
	private JOHHMIDNDIB(IntPtr GHAMEPNIACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x699CE90", Offset = "0x699BA90", VA = "0x18699CE90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x699CEB0", Offset = "0x699BAB0", VA = "0x18699CEB0")]
	public static JOHHMIDNDIB PPOPBMPFEOP(string GFLNGGKHEOH)
	{
		return default(JOHHMIDNDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1F8F200", Offset = "0x1F8DE00", VA = "0x181F8F200")]
	public static JOHHMIDNDIB PPOPBMPFEOP([In] ANAEOCDPBDB MANOCAKPFNK, string GFLNGGKHEOH)
	{
		return default(JOHHMIDNDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1F8F2D0", Offset = "0x1F8DED0", VA = "0x181F8F2D0")]
	public static JOHHMIDNDIB PPOPBMPFEOP([In] ANAEOCDPBDB MANOCAKPFNK, Func<string> GFLNGGKHEOH)
	{
		return default(JOHHMIDNDIB);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class LKNCJBAJMAB
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate bool OBKEEPIJNHF<in TInput, TResult>(TInput HJNPKADFMMO, [Out] TResult JFBAIGMLPKE);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private sealed class JEFPELDNJFL : DEKNPHKEEJC
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private sealed class GNKPFLEELAM : HFIDHKABPBB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly GNKPFLEELAM GGKBGANLBLD;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool BGOANOOCCPN
			{
				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x699AC20", Offset = "0x6999820", VA = "0x18699AC20", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x699AC80", Offset = "0x6999880", VA = "0x18699AC80", Slot = "6")]
			public void OnCompleted(Action MAMLMCINILJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
			public void KBBIGJGAGKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public GNKPFLEELAM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly JEFPELDNJFL GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		private JEFPELDNJFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x699C680", Offset = "0x699B280", VA = "0x18699C680", Slot = "4")]
		public HFIDHKABPBB EADJJONFAJP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private sealed class PKMOCBCEHFH : DEKNPHKEEJC
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private sealed class NKMHINGENEO : HFIDHKABPBB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly NKMHINGENEO GGKBGANLBLD;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool BGOANOOCCPN
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x69A00E0", Offset = "0x699ECE0", VA = "0x1869A00E0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x69A0100", Offset = "0x699ED00", VA = "0x1869A0100", Slot = "6")]
			public void OnCompleted(Action MAMLMCINILJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
			public void KBBIGJGAGKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public NKMHINGENEO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly PKMOCBCEHFH GGKBGANLBLD;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		private PKMOCBCEHFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x69A1260", Offset = "0x699FE60", VA = "0x1869A1260", Slot = "4")]
		public HFIDHKABPBB EADJJONFAJP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class ICDAOKBFIEP<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public ICDAOKBFIEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x37AC240", Offset = "0x37AAE40", VA = "0x1837AC240")]
		internal void BAMFAGLKGON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class LIIIEPNPFFL<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LIIIEPNPFFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4203800", Offset = "0x4202400", VA = "0x184203800")]
		internal void CGAHIGIFLOH(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct CPBHEFNOBAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6999000", Offset = "0x6997C00", VA = "0x186999000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9DD860", Offset = "0x9DC460", VA = "0x1809DD860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct LHLFLBOPMAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x699D350", Offset = "0x699BF50", VA = "0x18699D350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9DD860", Offset = "0x9DC460", VA = "0x1809DD860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct APJJKMPOIHI<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3DF2F50", Offset = "0x3DF1B50", VA = "0x183DF2F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3DF30C0", Offset = "0x3DF1CC0", VA = "0x183DF30C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct IJMGCFIOFMB<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3E37A70", Offset = "0x3E36670", VA = "0x183E37A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3E37EA0", Offset = "0x3E36AA0", VA = "0x183E37EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct CMKACIBMGEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6998D90", Offset = "0x6997990", VA = "0x186998D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6998F90", Offset = "0x6997B90", VA = "0x186998F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class EBIAJONGEFH<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public EBIAJONGEFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x37AC240", Offset = "0x37AAE40", VA = "0x1837AC240")]
		internal void NCIHDLFFLLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x37AC2A0", Offset = "0x37AAEA0", VA = "0x1837AC2A0")]
		internal void NPGALKHFBHE(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct FPHDMGMEIKM<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public OBKEEPIJNHF<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3BDEE50", Offset = "0x3BDDA50", VA = "0x183BDEE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3BDF580", Offset = "0x3BDE180", VA = "0x183BDF580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct GKDBOHFIKLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x699A3D0", Offset = "0x6998FD0", VA = "0x18699A3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x699ABC0", Offset = "0x69997C0", VA = "0x18699ABC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct MLDNPKPFDKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x699FA40", Offset = "0x699E640", VA = "0x18699FA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x699FF80", Offset = "0x699EB80", VA = "0x18699FF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct FKGCMCGPCED<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3BAA330", Offset = "0x3BA8F30", VA = "0x183BAA330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x37A8730", Offset = "0x37A7330", VA = "0x1837A8730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct BPMGICEAEOB<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4E8DEA0", Offset = "0x4E8CAA0", VA = "0x184E8DEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x353E2A0", Offset = "0x353CEA0", VA = "0x18353E2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct EJHJHIFCGBI<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x37FC9E0", Offset = "0x37FB5E0", VA = "0x1837FC9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x37FD100", Offset = "0x37FBD00", VA = "0x1837FD100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct JNEMCNKJEBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x699CC50", Offset = "0x699B850", VA = "0x18699CC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x699CE30", Offset = "0x699BA30", VA = "0x18699CE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct FGFBDEMDMNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6999EF0", Offset = "0x6998AF0", VA = "0x186999EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x699A260", Offset = "0x6998E60", VA = "0x18699A260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct AEBEJJKHKPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x69983B0", Offset = "0x6996FB0", VA = "0x1869983B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x69986A0", Offset = "0x69972A0", VA = "0x1869986A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class ANMAFMDHKMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public ANMAFMDHKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x69989C0", Offset = "0x69975C0", VA = "0x1869989C0")]
		internal Task GHJANBPCHLH(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct HOACMIBDPEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x699AE60", Offset = "0x6999A60", VA = "0x18699AE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x699B0C0", Offset = "0x6999CC0", VA = "0x18699B0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct CECHHGEEKFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6998B50", Offset = "0x6997750", VA = "0x186998B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6998D30", Offset = "0x6997930", VA = "0x186998D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct DICDPONAEEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6999860", Offset = "0x6998460", VA = "0x186999860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6999BD0", Offset = "0x69987D0", VA = "0x186999BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct KOOEDEMJEMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x699CFB0", Offset = "0x699BBB0", VA = "0x18699CFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x699D2A0", Offset = "0x699BEA0", VA = "0x18699D2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class IDPOJGGLDMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public IDPOJGGLDMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x699B6F0", Offset = "0x699A2F0", VA = "0x18699B6F0")]
		internal Task FOJKLFDKLEE(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct EOBFNMPPEFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6999C30", Offset = "0x6998830", VA = "0x186999C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6999E90", Offset = "0x6998A90", VA = "0x186999E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct JLKEKNCHPMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x699CA70", Offset = "0x699B670", VA = "0x18699CA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x699CBF0", Offset = "0x699B7F0", VA = "0x18699CBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct LNMHBLIHKLF<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4225940", Offset = "0x4224540", VA = "0x184225940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4225BA0", Offset = "0x42247A0", VA = "0x184225BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct OMOKOCBPCCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x69A0E00", Offset = "0x699FA00", VA = "0x1869A0E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x69A1200", Offset = "0x699FE00", VA = "0x1869A1200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? CGPANLAPJBM;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<LOGIJBPEHJN> BCNNLECMDGA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task EIHNICBGGPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x699F1D0", Offset = "0x699DDD0", VA = "0x18699F1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x699DFF0", Offset = "0x699CBF0", VA = "0x18699DFF0")]
	public static bool CAPJAHGOBAP(this Task HPIAAAJAFJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2C01A00", Offset = "0x2C00600", VA = "0x182C01A00")]
	public static Task<T> MAGGCKEGIMP<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x699E1B0", Offset = "0x699CDB0", VA = "0x18699E1B0")]
	public static Task DHGGLNNOCEG(this Task HPIAAAJAFJD, CancellationToken FGIAGALCIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2BFF870", Offset = "0x2BFE470", VA = "0x182BFF870")]
	public static Task<TResult> DHGGLNNOCEG<TResult>(this Task<TResult> HPIAAAJAFJD, CancellationToken FGIAGALCIAP) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2C004D0", Offset = "0x2BFF0D0", VA = "0x182C004D0")]
	public static TaskCompletionSource<TResult> DHGGLNNOCEG<TResult>(this TaskCompletionSource<TResult> CNBGHAGBAKF, CancellationToken FGIAGALCIAP) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x699E020", Offset = "0x699CC20", VA = "0x18699E020")]
	public static IDisposable? CGFBEGJKBID(CancellationToken CIHLPFLEEGF, CancellationToken FPIILJNBMGM, [Out] CancellationToken IOJNIOGEGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x699F120", Offset = "0x699DD20", VA = "0x18699F120")]
	[AsyncStateMachine(typeof(CPBHEFNOBAK))]
	public static void LAJNEMBOJNP(this Task NEAJEANMBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x699DF40", Offset = "0x699CB40", VA = "0x18699DF40")]
	[AsyncStateMachine(typeof(LHLFLBOPMAJ))]
	public static void CAAMEDEILLN(this Task NEAJEANMBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2C01930", Offset = "0x2C00530", VA = "0x182C01930")]
	[AsyncStateMachine(typeof(APJJKMPOIHI<>))]
	public static Task LEBLACPNACP<TException>(this Task NEAJEANMBOG) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2C01B80", Offset = "0x2C00780", VA = "0x182C01B80")]
	[AsyncStateMachine(typeof(IJMGCFIOFMB<>))]
	public static Task<T> MMPGIHMHAOK<T>(this Task<T> HNFMOHFACKF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x699EEB0", Offset = "0x699DAB0", VA = "0x18699EEB0")]
	[AsyncStateMachine(typeof(CMKACIBMGEJ))]
	public static Task<TaskStatus> HOEKAKPBKPB(this Task HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2C01100", Offset = "0x2BFFD00", VA = "0x182C01100")]
	public static (Task<T?>?, Action<T?>?) FFCMMPAIGPH<T>([Optional] CancellationToken MPLCHGMFENA)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2C01380", Offset = "0x2BFFF80", VA = "0x182C01380")]
	[AsyncStateMachine(typeof(FPHDMGMEIKM<, >))]
	public static Task<List<TResult>> FPOGKDLGBPI<TResult, TInput>(this Task<List<TInput>> HPIAAAJAFJD, OBKEEPIJNHF<TInput, TResult> DMFEMBAMIPJ) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x699E800", Offset = "0x699D400", VA = "0x18699E800")]
	[AsyncStateMachine(typeof(GKDBOHFIKLF))]
	public static Task GHKEEAEHJBO(Task NEAJEANMBOG, CancellationToken DDPMOBGAIPN, Func<CancellationToken, Task> HIEDCPJBAMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x699E410", Offset = "0x699D010", VA = "0x18699E410")]
	[AsyncStateMachine(typeof(MLDNPKPFDKI))]
	public static Task EPHPMELPLOG(Func<CancellationToken, Task> PLHMBOBMHLD, TimeSpan CJGJFNIPHNO, [Optional] CancellationToken DDPMOBGAIPN, [Optional] Action<OperationCanceledException>? HOPHJLFHIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2C00E60", Offset = "0x2BFFA60", VA = "0x182C00E60")]
	[AsyncStateMachine(typeof(FKGCMCGPCED<>))]
	public static Task<T> EPHPMELPLOG<T>(Func<CancellationToken, Task<T>> PLHMBOBMHLD, TimeSpan CJGJFNIPHNO, [Optional] CancellationToken DDPMOBGAIPN, [Optional] Func<OperationCanceledException, T>? HOPHJLFHIDN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2C01580", Offset = "0x2C00180", VA = "0x182C01580")]
	[AsyncStateMachine(typeof(BPMGICEAEOB<>))]
	public static Task<IEnumerable<Task<T>>> ICNMGFHKGHB<T>(IEnumerable<Task<T>> FPGLMGHBFKE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2C01670", Offset = "0x2C00270", VA = "0x182C01670")]
	[AsyncStateMachine(typeof(EJHJHIFCGBI<, , , >))]
	public static Task<(T1, T2, T3, T4)> KGGJGECLFID<T1, T2, T3, T4>(Task<T1> GDLBELEEHLP, Task<T2> NGAEFHFOPCG, Task<T3> NFFNBDLLAKL, Task<T4> FKECDJMAGNL) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x699F670", Offset = "0x699E270", VA = "0x18699F670")]
	[AsyncStateMachine(typeof(JNEMCNKJEBP))]
	public static Task NHOBODOBAGM(Func<bool> OINKDIMBFCD, [Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x699F760", Offset = "0x699E360", VA = "0x18699F760")]
	[AsyncStateMachine(typeof(FGFBDEMDMNN))]
	public static Task NHOBODOBAGM(Func<bool> OINKDIMBFCD, TimeSpan BPJAHBFMEFF, [Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x699F450", Offset = "0x699E050", VA = "0x18699F450")]
	[AsyncStateMachine(typeof(AEBEJJKHKPA))]
	public static Task MOKGDKPLPFL(Func<bool> OINKDIMBFCD, TimeSpan CJGJFNIPHNO, [Optional] CancellationToken MPLCHGMFENA, [Optional] Action<OperationCanceledException>? HOPHJLFHIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x699F310", Offset = "0x699DF10", VA = "0x18699F310")]
	[AsyncStateMachine(typeof(HOACMIBDPEN))]
	public static Task MOKGDKPLPFL(Func<bool> OINKDIMBFCD, TimeSpan CJGJFNIPHNO, TimeSpan BPJAHBFMEFF, [Optional] CancellationToken MPLCHGMFENA, [Optional] Action<OperationCanceledException>? HOPHJLFHIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x699E930", Offset = "0x699D530", VA = "0x18699E930")]
	[AsyncStateMachine(typeof(CECHHGEEKFE))]
	public static Task HFNPKOJINDK(Func<bool> OINKDIMBFCD, [Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x699EA20", Offset = "0x699D620", VA = "0x18699EA20")]
	[AsyncStateMachine(typeof(DICDPONAEEC))]
	public static Task HFNPKOJINDK(Func<bool> OINKDIMBFCD, TimeSpan BPJAHBFMEFF, [Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x699E540", Offset = "0x699D140", VA = "0x18699E540")]
	[AsyncStateMachine(typeof(KOOEDEMJEMG))]
	public static Task FNJGEBOLKOM(Func<bool> OINKDIMBFCD, TimeSpan CJGJFNIPHNO, [Optional] CancellationToken MPLCHGMFENA, [Optional] Action<OperationCanceledException>? HOPHJLFHIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x699E670", Offset = "0x699D270", VA = "0x18699E670")]
	[AsyncStateMachine(typeof(EOBFNMPPEFM))]
	public static Task FNJGEBOLKOM(Func<bool> OINKDIMBFCD, TimeSpan CJGJFNIPHNO, TimeSpan BPJAHBFMEFF, [Optional] CancellationToken MPLCHGMFENA, [Optional] Action<OperationCanceledException>? HOPHJLFHIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x699F580", Offset = "0x699E180", VA = "0x18699F580")]
	[AsyncStateMachine(typeof(JLKEKNCHPMB))]
	[Obsolete]
	public static Task NEDMNJNPJJC(this Task HPIAAAJAFJD, Action KNEHNIHKBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C01D60", Offset = "0x2C00960", VA = "0x182C01D60")]
	[AsyncStateMachine(typeof(LNMHBLIHKLF<>))]
	[Obsolete]
	public static Task NEDMNJNPJJC<T>(this Task<T> HPIAAAJAFJD, Action<T> KNEHNIHKBOB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x699F070", Offset = "0x699DC70", VA = "0x18699F070")]
	private static void IPAKEFOKBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x699EB30", Offset = "0x699D730", VA = "0x18699EB30")]
	public static bool HLGDGMBJBEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x699DDB0", Offset = "0x699C9B0", VA = "0x18699DDB0")]
	private static void BIKENDPLGGN(SynchronizationContext GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x699DC90", Offset = "0x699C890", VA = "0x18699DC90")]
	private static void AHIOPLEBPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x699F240", Offset = "0x699DE40", VA = "0x18699F240")]
	public static void MLCGMEJOOMN([Optional] string? JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x699F870", Offset = "0x699E470", VA = "0x18699F870")]
	public static void OAAMLDPNKPP([Optional] string? JIMAFLGJGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x699E7B0", Offset = "0x699D3B0", VA = "0x18699E7B0")]
	public static DEKNPHKEEJC GAFJIEGINIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x699E160", Offset = "0x699CD60", VA = "0x18699E160")]
	public static DEKNPHKEEJC DCPGOCMBBHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x699EFA0", Offset = "0x699DBA0", VA = "0x18699EFA0")]
	[AsyncStateMachine(typeof(OMOKOCBPCCO))]
	public static Task IJBPBECGHEO(Func<Task> DFEAGIPALPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class KPAMBFFNOBG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
	public KPAMBFFNOBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class OFMNNHJPEGP : KGCFEMNHHJL
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly KGCFEMNHHJL GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime MJMAPBIMCHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x69A0CE0", Offset = "0x699F8E0", VA = "0x1869A0CE0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset OBKFFFCPCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x69A0D20", Offset = "0x699F920", VA = "0x1869A0D20", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public OFMNNHJPEGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface KGCFEMNHHJL
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime MJMAPBIMCHI
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset OBKFFFCPCCG
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class LJFKGNIFBBM
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long BLCFHAPKBBN
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x699D550", Offset = "0x699C150", VA = "0x18699D550")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long CCPOLBIGHFF
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x699D4F0", Offset = "0x699C0F0", VA = "0x18699D4F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double DJLACJAGGOE
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x699D920", Offset = "0x699C520", VA = "0x18699D920")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double JIDFDODCLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x699D710", Offset = "0x699C310", VA = "0x18699D710")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double BABPFACCBCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x699D970", Offset = "0x699C570", VA = "0x18699D970")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double MLJDFDJBFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x699D630", Offset = "0x699C230", VA = "0x18699D630")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x699D680", Offset = "0x699C280", VA = "0x18699D680")]
	public static double GHBKFEFMPOL(long LNHFHKJDMFE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x699D460", Offset = "0x699C060", VA = "0x18699D460")]
	public static double AGLDKDIGOEN(long LNHFHKJDMFE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x699D5A0", Offset = "0x699C1A0", VA = "0x18699D5A0")]
	public static double DMGLKAJAKHC(double BGBBFMBMDMM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x699D760", Offset = "0x699C360", VA = "0x18699D760")]
	public static long JEFJDILEFNI(long EACMJFLDLDP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x699D540", Offset = "0x699C140", VA = "0x18699D540")]
	public static long AMKMHFNMJFH(long PAJPOMEAPCJ, long CMAPKGBAENF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x699D7F0", Offset = "0x699C3F0", VA = "0x18699D7F0")]
	public static double MLOCHFAMFEK(long PAJPOMEAPCJ, long CMAPKGBAENF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x699D8C0", Offset = "0x699C4C0", VA = "0x18699D8C0")]
	public static double NCHGJEBJEOE(long PAJPOMEAPCJ, long CMAPKGBAENF)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class DEPIJBGOFAC : GMOMKBDOINE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static readonly TimeSpan PEMHEIFKBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly System.Timers.Timer JKELFCJBEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private TimeSpan CJGJFNIPHNO;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan JKEHGDMDFBA
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6999310", Offset = "0x6997F10", VA = "0x186999310", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? DJHPACEKNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x69997F0", Offset = "0x69983F0", VA = "0x1869997F0")]
	[Preserve]
	public DEPIJBGOFAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x69995A0", Offset = "0x69981A0", VA = "0x1869995A0")]
	public DEPIJBGOFAC(TimeSpan CJGJFNIPHNO, [Optional] Action? LLJOELBEOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6999470", Offset = "0x6998070", VA = "0x186999470", Slot = "7")]
	public void NBMNJOJAEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6999200", Offset = "0x6997E00", VA = "0x186999200", Slot = "8")]
	public void HAGCANPLAGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6999500", Offset = "0x6998100", VA = "0x186999500", Slot = "9")]
	public void PMLHLALIMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x9168D0", Offset = "0x9154D0", VA = "0x1809168D0")]
	private void NJDHADJKCDL(object KGECOLOELOJ, ElapsedEventArgs ODDCLDKCADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6999270", Offset = "0x6997E70", VA = "0x186999270")]
	private static void IDDELFBHBJB(TimeSpan DEMHCMLPNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6999160", Offset = "0x6997D60", VA = "0x186999160", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class DKPEDCBOHDB : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly string? KICMNPDJCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly string LDEKDOMMOAG;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x64543B0", Offset = "0x6452FB0", VA = "0x1864543B0")]
	public DKPEDCBOHDB(string HDGEDEGBPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3E1CD30", Offset = "0x3E1B930", VA = "0x183E1CD30")]
	public DKPEDCBOHDB(string HGIJFHOADFN, string HDGEDEGBPPD)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct IOAFEKLHBKI : IEquatable<IOAFEKLHBKI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public uint GGJHEIGEBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int EFGPHGALFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float CBMFNFGNJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public ushort FMDLGILKKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public ushort CMIHMFFNJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public short AFHDFBKFJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public short OBMKPHMHBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public char KMHMJPMIGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public char FOMEKMCHGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte KACGBAKHJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte MHNOOBOGHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public byte GMGJNLCJDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte LEOIFELOFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool NDBMAFJOFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool PIJCMIOGCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public bool MDGBAIGJLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool BKBONOKLBMI;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0xDFE9C0", Offset = "0xDFD5C0", VA = "0x180DFE9C0")]
	public static IOAFEKLHBKI BJBAKMCGENG(uint GKOPMAPPNJP)
	{
		return default(IOAFEKLHBKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xDFE9C0", Offset = "0xDFD5C0", VA = "0x180DFE9C0")]
	public static IOAFEKLHBKI BPODCNNGJOP(int HMNPNGMIENE)
	{
		return default(IOAFEKLHBKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x699B810", Offset = "0x699A410", VA = "0x18699B810")]
	public static IOAFEKLHBKI MKHFGCEMDHO(float CMAALLDEEAM)
	{
		return default(IOAFEKLHBKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x699B760", Offset = "0x699A360", VA = "0x18699B760")]
	public static IOAFEKLHBKI NKLHPBDKKGJ(byte FNGOFKMGBCD, byte OICPLFFAGNC, byte MGNCGLJGKDJ, byte HDDKECLNHAG)
	{
		return default(IOAFEKLHBKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x699B760", Offset = "0x699A360", VA = "0x18699B760")]
	public static IOAFEKLHBKI DHMKPFLJPBL(bool AEGOGNFNJCM, bool ODKILOOHBMC, bool KBDGKAOLHOF, bool JDJAMPELPHB)
	{
		return default(IOAFEKLHBKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x699B760", Offset = "0x699A360", VA = "0x18699B760")]
	public static IOAFEKLHBKI CHHAJJHIOBC(byte OGAGOCKDCAH, byte ENAEKKFIPIG, byte GEIILFGLAHF, byte GPBHFJJLPEJ)
	{
		return default(IOAFEKLHBKI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C930", Offset = "0x1A4B530", VA = "0x181A4C930")]
	public static bool NBAHCGFACIA(IOAFEKLHBKI HLHDFJDLHFM, IOAFEKLHBKI GIHDHONABPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x9D6EA0", Offset = "0x9D5AA0", VA = "0x1809D6EA0", Slot = "4")]
	public bool Equals(IOAFEKLHBKI OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x699B780", Offset = "0x699A380", VA = "0x18699B780", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0xA94CA0", Offset = "0xA938A0", VA = "0x180A94CA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x699B820", Offset = "0x699A420", VA = "0x18699B820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct LHDIPHLPCFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public ulong ENGIIDJDHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public long OGMKEOCAMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public double HHDIMEDIFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint DHHGGPJMFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint OOOCBKHOKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public int GFDDMAKNIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int EBOBEMHLLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float EKJPLEODPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float DKNEAIFLLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort FMDLGILKKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort CMIHMFFNJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public ushort JDFHBFFCKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort AFJCEAJBNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short AFHDFBKFJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short OBMKPHMHBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public short HAILFFKPCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short DDBJJKPEENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char KMHMJPMIGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char FOMEKMCHGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public char KABKMICKNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char EGAENGFJNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte KACGBAKHJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte MHNOOBOGHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte GMGJNLCJDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte LEOIFELOFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte PCBAGKALBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte CCHNNMKBNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte KKGNCMEGFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte PLHGCPCMIJA;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x699D300", Offset = "0x699BF00", VA = "0x18699D300")]
	public static LHDIPHLPCFA PPOPBMPFEOP(byte FNGOFKMGBCD, byte OICPLFFAGNC, byte MGNCGLJGKDJ, byte HDDKECLNHAG, byte BOBGABJNAAN, byte PODEFGMDHEP, byte LABPHDBPDBK, byte AOEBDFNMLKG)
	{
		return default(LHDIPHLPCFA);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct JGHAODHKOJL : IEquatable<JGHAODHKOJL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte MAAKCAAHJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool DIPHLCJKMGC;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x25414C0", Offset = "0x25400C0", VA = "0x1825414C0")]
	public static JGHAODHKOJL NKLHPBDKKGJ(byte IDKNMIIDBCD)
	{
		return default(JGHAODHKOJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x25414C0", Offset = "0x25400C0", VA = "0x1825414C0")]
	public static JGHAODHKOJL DHMKPFLJPBL(bool OFBAANLNPEB)
	{
		return default(JGHAODHKOJL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x699C7F0", Offset = "0x699B3F0", VA = "0x18699C7F0")]
	public static bool NBAHCGFACIA(JGHAODHKOJL HLHDFJDLHFM, JGHAODHKOJL GIHDHONABPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D6E0", Offset = "0x5B7C2E0", VA = "0x185B7D6E0", Slot = "4")]
	public bool Equals(JGHAODHKOJL OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x699C750", Offset = "0x699B350", VA = "0x18699C750", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x699C7E0", Offset = "0x699B3E0", VA = "0x18699C7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x699C800", Offset = "0x699B400", VA = "0x18699C800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class KAPLHIAPIJN<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public readonly T BCDIMELKHHD;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x412A0E0", Offset = "0x4128CE0", VA = "0x18412A0E0")]
	public KAPLHIAPIJN(T EHCOFADIAPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class LDGAMHEKLEG
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2B94400", Offset = "0x2B93000", VA = "0x182B94400")]
	public static IEnumerable<T> JBMMKMJFBBB<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
	public static T[] MEDGKDMIKEI<T>(params T[] NFHGAEDEEIH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600")]
	public static IEnumerable<T> FEMOKMMMPPP<T>(params T[] NFHGAEDEEIH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x292BA60", Offset = "0x292A660", VA = "0x18292BA60")]
	public static HashSet<T> NGHINOAAHLL<T>(params T[] NFHGAEDEEIH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2BEDFD0", Offset = "0x2BECBD0", VA = "0x182BEDFD0")]
	public static KeyValuePair<TKey, TValue> NMJLDBMDHGN<TKey, TValue>([In] TKey DPHIOKCFMFC, [In] TValue GLMEMJNJKAN) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x292BA60", Offset = "0x292A660", VA = "0x18292BA60")]
	public static List<T> MKHFGJLMIFN<T>(IEnumerable<T> PLHBCCDAKBC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[AttributeUsage(AttributeTargets.All)]
public sealed class FLLIIGCGAJP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public readonly string FCHPMNODEAC;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
	public FLLIIGCGAJP(string PJFHHDPNDJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate object GLANJHDJGLI<T>([In] T LLJCEPGKLEC);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object GOCOGDOFHFI<T>(T LLJCEPGKLEC);
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AEPJOCDMCFE]
public delegate string NJHHIGJGCIN(string OGFFIPCKAML, string? HLLDCJMGAKE, bool HMKPDBCIGNA);
[Cpp2IlInjected.Token(Token = "0x200005A")]
[AEPJOCDMCFE]
public delegate void PLAIJMLGMPB(string JIMAFLGJGFB);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AEPJOCDMCFE]
public delegate void CBBCFGHGDJO(Exception JNLFEIJKPEF);
[Cpp2IlInjected.Token(Token = "0x200005C")]
public delegate object DKLADOMLNBB();
[Cpp2IlInjected.Token(Token = "0x200005D")]
[AEPJOCDMCFE]
public delegate bool LFHONOKAJKL();
[Cpp2IlInjected.Token(Token = "0x200005E")]
[AEPJOCDMCFE]
public delegate string HBLJCKGLAAN(object HAHECKLGOJC);
[Cpp2IlInjected.Token(Token = "0x200005F")]
[AttributeUsage(AttributeTargets.Enum)]
public class JJHCABHABFO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
	public JJHCABHABFO()
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
