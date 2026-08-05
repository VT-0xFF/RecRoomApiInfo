using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF610", Offset = "0x5FEEA10", VA = "0x185FEF610")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C8560", Offset = "0x7C7960", VA = "0x1807C8560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C85A0", Offset = "0x7C79A0", VA = "0x1807C85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class BLINICFGBPC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8460", Offset = "0x5FE7860", VA = "0x185FE8460")]
	public BLINICFGBPC(bool ILFHKHBOAGC, string JFANFPLPAEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MBGGCCPHPOB<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> PKNJAIAOLPN(CancellationToken HNLFPBLPOKJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct FDOBOKCCCLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public MBGGCCPHPOB<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public PKNJAIAOLPN taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3577410", Offset = "0x3576810", VA = "0x183577410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3578470", Offset = "0x3577870", VA = "0x183578470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource MFNNECHIHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? ACPDJDAMPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? IELJINJMEIA;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D2EA10", Offset = "0x3D2DE10", VA = "0x183D2EA10")]
	[AsyncStateMachine(typeof(MBGGCCPHPOB<>.FDOBOKCCCLD))]
	public Task<TResult> MJOLKNKBOPN(PKNJAIAOLPN IEBCOABNEMM, [Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D2E9A0", Offset = "0x3D2DDA0", VA = "0x183D2E9A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D2EB50", Offset = "0x3D2DF50", VA = "0x183D2EB50")]
	public MBGGCCPHPOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LHEJMGKFLDK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> PNPMBDCAIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T NAJOFLHMBPO;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x31D5730", Offset = "0x31D4B30", VA = "0x1831D5730")]
	public LHEJMGKFLDK([In] T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3B564B0", Offset = "0x3B558B0", VA = "0x183B564B0", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3B56630", Offset = "0x3B55A30", VA = "0x183B56630", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3B568A0", Offset = "0x3B55CA0", VA = "0x183B568A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JOJKBELIDGE
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5FECF30", Offset = "0x5FEC330", VA = "0x185FECF30")]
	public static void KAHBNDEFGNE(this CancellationTokenSource MFNNECHIHMJ, bool BLANLPPLHIK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class MJHMIJGAHPE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
	public MJHMIJGAHPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class FANKNDILCGJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
	public FANKNDILCGJ(string COEFJMLBJJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JCKCECLLMGN
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x268D4C0", Offset = "0x268C8C0", VA = "0x18268D4C0")]
	public static IPKBLOGLFHG FEALKIGFCCP<T>()
	{
		return default(IPKBLOGLFHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x268D6C0", Offset = "0x268CAC0", VA = "0x18268D6C0")]
	public static IPKBLOGLFHG JPHFIACIOHM<T>([CallerMemberName] string OMHHPMIDNAN = "") where T : notnull
	{
		return default(IPKBLOGLFHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x268D440", Offset = "0x268C840", VA = "0x18268D440")]
	public static IPKBLOGLFHG FEALKIGFCCP<T>(this T JHEMNDMHNOB) where T : notnull
	{
		return default(IPKBLOGLFHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x268D540", Offset = "0x268C940", VA = "0x18268D540")]
	public static IPKBLOGLFHG GDOELCOJAEI<T>(this T JHEMNDMHNOB, [CallerMemberName] string OMHHPMIDNAN = "") where T : notnull
	{
		return default(IPKBLOGLFHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x268D750", Offset = "0x268CB50", VA = "0x18268D750")]
	public static IPKBLOGLFHG JPHFIACIOHM<T>(this T NHHBAHIFHJK, [CallerMemberName] string OMHHPMIDNAN = "") where T : notnull
	{
		return default(IPKBLOGLFHG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC490", Offset = "0x5FEB890", VA = "0x185FEC490")]
	public static IPKBLOGLFHG JPHFIACIOHM(string ANDKLKNHFBB, [CallerMemberName] string OMHHPMIDNAN = "")
	{
		return default(IPKBLOGLFHG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC3F0", Offset = "0x5FEB7F0", VA = "0x185FEC3F0")]
	public static string DLJMBHOMMMH(this object NHHBAHIFHJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate bool FKNMAJPGJEA();
[Cpp2IlInjected.Token(Token = "0x200000F")]
[MJHMIJGAHPE]
public delegate long DIGEIEHIMCO();
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JMPNGONEIBG
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static KGKONKIIIJC FELOEAPDDII;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static KGKONKIIIJC AEOJFPGKDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5FECE20", Offset = "0x5FEC220", VA = "0x185FECE20")]
		get
		{
			return default(KGKONKIIIJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static CMLABEFMCPO IEFLNIGHNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5FECC60", Offset = "0x5FEC060", VA = "0x185FECC60")]
		get
		{
			return default(CMLABEFMCPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static HKDNMAIEHEC OHCKBFLDDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5FEC920", Offset = "0x5FEBD20", VA = "0x185FEC920")]
		get
		{
			return default(HKDNMAIEHEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool MPDHOGHFDPL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5FECBF0", Offset = "0x5FEBFF0", VA = "0x185FECBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5FECA40", Offset = "0x5FEBE40", VA = "0x185FECA40")]
	public static void FDDBMCDHILM([In] KGKONKIIIJC GAFKMGGPMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC660", Offset = "0x5FEBA60", VA = "0x185FEC660")]
	public static void BDAJDFAFKKC(string DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC970", Offset = "0x5FEBD70", VA = "0x185FEC970")]
	public static void EIOKCLMHEHA(string DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x26A4EE0", Offset = "0x26A42E0", VA = "0x1826A4EE0")]
	public static void EIOKCLMHEHA<T>(T OEJAGOPNKOK, LHGDOIAANHF<T> DCKDMGKGDFN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5FECD10", Offset = "0x5FEC110", VA = "0x185FECD10")]
	public static void LOHEEKGGMHP(Exception MEIELCKPCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC600", Offset = "0x5FEBA00", VA = "0x185FEC600")]
	public static void ANFFIBOKGAE(string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5FECCB0", Offset = "0x5FEC0B0", VA = "0x185FECCB0")]
	public static void KOKEENPPDDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC800", Offset = "0x5FEBC00", VA = "0x185FEC800")]
	public static string DLJMBHOMMMH(object MBCPMMHPENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5FECDB0", Offset = "0x5FEC1B0", VA = "0x185FECDB0")]
	public static long MKGEBBOHCAI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC880", Offset = "0x5FEBC80", VA = "0x185FEC880")]
	public static bool DMMNDDMJJHD(bool BMPNDHLKPNC, string DCKDMGKGDFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC730", Offset = "0x5FEBB30", VA = "0x185FEC730")]
	public static double CLHAGIKHMPH()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct KGKONKIIIJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly CMLABEFMCPO IEFLNIGHNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly HKDNMAIEHEC OHCKBFLDDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly BOLFBJGMBHP CCDCMBCBAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly DIGEIEHIMCO ELIGLPIKMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly LHHFILEJBPD LPPLJMEAAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly FKNMAJPGJEA LELMAKCKFJA;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly BOLFBJGMBHP FKNGEOALHHC;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly DIGEIEHIMCO MLILFCADJFH;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly LHHFILEJBPD GNCNLNODPDP;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly FKNMAJPGJEA MACEFNJMKCC;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly KGKONKIIIJC FEAMHHDKACA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool INMLDJBGPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5FED1A0", Offset = "0x5FEC5A0", VA = "0x185FED1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5FEDB80", Offset = "0x5FECF80", VA = "0x185FEDB80")]
	public KGKONKIIIJC([In] CMLABEFMCPO NMBDIAJJMFO, [In] HKDNMAIEHEC KINLJDFKFNB, BOLFBJGMBHP NADHFEAICFB, DIGEIEHIMCO EFJHFONAPDH, LHHFILEJBPD BCLGBAPCHNA, FKNMAJPGJEA BJGFFICEOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5FED340", Offset = "0x5FEC740", VA = "0x185FED340")]
	private static string KKBFOMHJPBD(object MBCPMMHPENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x79E380", Offset = "0x79D780", VA = "0x18079E380")]
	private static long GIHHFHGAPFA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86D430", Offset = "0x86C830", VA = "0x18086D430")]
	private static string DGFJBGIDOJA(string ADLBCEDEBAN, string? FIJABPAFDME, bool IMKMAJEEFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0")]
	private static bool IHPKFPLJGCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5FED380", Offset = "0x5FEC780", VA = "0x185FED380")]
	private static KGKONKIIIJC OBPDDHFCBGJ()
	{
		return default(KGKONKIIIJC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FGNEIPLABBD
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AGKMCOIMIGO LPPDDHLPDIP();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AGKMCOIMIGO : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MEINDBODKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIJKCFDBHNP();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FONIOECJOBC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLPLMDDOIJN([In] T AAMIMDAKFMC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void GLCAGNBJKNL<T>([In] T OEJAGOPNKOK);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct DNLMNGBCBFK<T> : IEquatable<DNLMNGBCBFK<T>>, FONIOECJOBC<DNLMNGBCBFK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T NAJOFLHMBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int MEJJBNBBHJJ;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1D6A4F0", Offset = "0x1D698F0", VA = "0x181D6A4F0")]
	public DNLMNGBCBFK([In] T FDFHGIHHGHO, int OJANCMLFDOJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4EB76D0", Offset = "0x4EB6AD0", VA = "0x184EB76D0")]
	public static bool FFFIMEBHMPG([In] DNLMNGBCBFK<T> JIKBDKDLPCA, [In] DNLMNGBCBFK<T> DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x37B5200", Offset = "0x37B4600", VA = "0x1837B5200", Slot = "4")]
	public bool Equals(DNLMNGBCBFK<T> AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x47862D0", Offset = "0x47856D0", VA = "0x1847862D0", Slot = "0")]
	public override bool Equals(object AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4EB8760", Offset = "0x4EB7B60", VA = "0x184EB8760")]
	public bool MLPLMDDOIJN([In] DNLMNGBCBFK<T> AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4EB7E70", Offset = "0x4EB7270", VA = "0x184EB7E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4EB8A60", Offset = "0x4EB7E60", VA = "0x184EB8A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4EB82D0", Offset = "0x4EB76D0", VA = "0x184EB82D0")]
	public void LIIEGHCBNII([Out] T FDFHGIHHGHO, [Out] int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4EB7270", Offset = "0x4EB6670", VA = "0x184EB7270")]
	public (T, int) CDONDHEJHGP()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4EB8040", Offset = "0x4EB7440", VA = "0x184EB8040", Slot = "5")]
	private bool JCDFDLFFJAB([In] DNLMNGBCBFK<T> AAMIMDAKFMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class INFOBIFIPFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x267DD10", Offset = "0x267D110", VA = "0x18267DD10")]
	public static DNLMNGBCBFK<T> JKJFENIAMEL<T>([In] T FDFHGIHHGHO, int OJANCMLFDOJ) where T : notnull
	{
		return default(DNLMNGBCBFK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NLOGGCPCIAL
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x276DB30", Offset = "0x276CF30", VA = "0x18276DB30")]
	public static bool MLPLMDDOIJN<T, U>([In] T NHHBAHIFHJK, [In] U MBCPMMHPENP) where T : notnull, FONIOECJOBC<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate TResult AMKINIAEIGB<T, out TResult>([In] T OEJAGOPNKOK);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface PKJFBHNKINM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan KBMNCHLELKG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? GCOBBDBDIEC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KDHLPBFNFLJ();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JIJNGCOKGOD();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CICOGPEPCAK();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct CMLABEFMCPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly NNINFIFGOFM LHDHKCCDKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly BKGGEBDLKEK NEPILBAKAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly NNINFIFGOFM JICEBBGGAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly BKGGEBDLKEK HPDJCMKDPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly NNINFIFGOFM CEMIMBEOEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly BKGGEBDLKEK BMFCFAHNJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly BIJBIMOIBLG BLKHDDFALOF;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly NNINFIFGOFM KLJKHFMAAJL;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly BKGGEBDLKEK JJIDBOAFDDH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly NNINFIFGOFM KJPHBEHIBHM;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly BKGGEBDLKEK GHNALBCOLOP;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly NNINFIFGOFM OOIABPGOGAO;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly BKGGEBDLKEK BIDAMONBJDC;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly BIJBIMOIBLG AAALBLGAIEN;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly CMLABEFMCPO FEAMHHDKACA;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly NNINFIFGOFM AGNHNKDGLAO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool INMLDJBGPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5FE85A0", Offset = "0x5FE79A0", VA = "0x185FE85A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x93AE90", Offset = "0x93A290", VA = "0x18093AE90")]
	public CMLABEFMCPO(NNINFIFGOFM KMEINGIMGCH, BKGGEBDLKEK NCBDONIHOMG, NNINFIFGOFM GCDGEBCCNDN, BKGGEBDLKEK FPGPPOGKELH, NNINFIFGOFM IGEAMPMFFKJ, BKGGEBDLKEK BBGLNJNAPDL, BIJBIMOIBLG FJJMDJABJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0")]
	private static bool HBPIHGELNOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370")]
	private static void ILAAIGHOMGI(string DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0")]
	private static bool BACKGCGLOLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370")]
	private static void LNBFGPKLOMA(string DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0")]
	private static bool JMEOAIHAFNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370")]
	private static void GAMJJBAOPMK(string DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370")]
	private static void LHCMEBMKCFN(Exception MEIELCKPCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5FE89C0", Offset = "0x5FE7DC0", VA = "0x185FE89C0")]
	private static CMLABEFMCPO OBPDDHFCBGJ()
	{
		return default(CMLABEFMCPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7B8240", Offset = "0x7B7640", VA = "0x1807B8240")]
	private static bool NIGOMKPNKFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8530", Offset = "0x5FE7930", VA = "0x185FE8530")]
	public void BDAJDFAFKKC(object DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8950", Offset = "0x5FE7D50", VA = "0x185FE8950")]
	public void EIOKCLMHEHA(object DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x18EECA0", Offset = "0x18EE0A0", VA = "0x1818EECA0")]
	public void LOHEEKGGMHP(Exception MEIELCKPCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5FE8870", Offset = "0x5FE7C70", VA = "0x185FE8870")]
	public void EIOKCLMHEHA(KOBHHIGCAPD DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2492280", Offset = "0x2491680", VA = "0x182492280")]
	public void EIOKCLMHEHA<T>(T OEJAGOPNKOK, LHGDOIAANHF<T> DCKDMGKGDFN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2492100", Offset = "0x2491500", VA = "0x182492100")]
	public void BDAJDFAFKKC<T>([In] T OEJAGOPNKOK, CIOAAOPKPLJ<T> DCKDMGKGDFN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5FE87A0", Offset = "0x5FE7BA0", VA = "0x185FE87A0")]
	public bool DMMNDDMJJHD(bool BMPNDHLKPNC, string DCKDMGKGDFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct IPKBLOGLFHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string NAJOFLHMBPO;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF70", Offset = "0x8BB370", VA = "0x1808BBF70")]
	public IPKBLOGLFHG(string FDFHGIHHGHO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x80A7E0", Offset = "0x809BE0", VA = "0x18080A7E0")]
	public static string CPALPDKLBCM([In] IPKBLOGLFHG NHHBAHIFHJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x13ED020", Offset = "0x13EC420", VA = "0x1813ED020")]
	public static IPKBLOGLFHG CPALPDKLBCM(string AAMIMDAKFMC)
	{
		return default(IPKBLOGLFHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC2C0", Offset = "0x5FEB6C0", VA = "0x185FEC2C0")]
	public string ABBBNPNOEFO(string MKFPNMJBPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC310", Offset = "0x5FEB710", VA = "0x185FEC310")]
	public string AFIELBNIKGN(object NFCAPOLGADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x80A7E0", Offset = "0x809BE0", VA = "0x18080A7E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct PJHBHBBODGG : IEquatable<PJHBHBBODGG>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7B8240", Offset = "0x7B7640", VA = "0x1807B8240", Slot = "4")]
	public bool Equals(PJHBHBBODGG AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0C10", Offset = "0x5FF0010", VA = "0x185FF0C10", Slot = "0")]
	public override bool Equals(object AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0C60", Offset = "0x5FF0060", VA = "0x185FF0C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0C70", Offset = "0x5FF0070", VA = "0x185FF0C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[AOICGJECGOP("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct IKGCKHLMHFG<T> : IEquatable<IKGCKHLMHFG<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T NAJOFLHMBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool LHJHFKJIGJJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool EFMFEEPBFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x37B5D30", Offset = "0x37B5130", VA = "0x1837B5D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x37B64A0", Offset = "0x37B58A0", VA = "0x1837B64A0")]
	public IKGCKHLMHFG([In] T FDFHGIHHGHO, bool APPGEFJHLBP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x37B59C0", Offset = "0x37B4DC0", VA = "0x1837B59C0")]
	public static bool FFFIMEBHMPG([In] IKGCKHLMHFG<T> JIKBDKDLPCA, [In] IKGCKHLMHFG<T> DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x37B5200", Offset = "0x37B4600", VA = "0x1837B5200", Slot = "4")]
	public bool Equals(IKGCKHLMHFG<T> AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x37B5580", Offset = "0x37B4980", VA = "0x1837B5580", Slot = "0")]
	public override bool Equals(object AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x37B5D40", Offset = "0x37B5140", VA = "0x1837B5D40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x37B6240", Offset = "0x37B5640", VA = "0x1837B6240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class OIENENDAFLI
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2786D40", Offset = "0x2786140", VA = "0x182786D40")]
	public static IKGCKHLMHFG<T> OFOPCELCJBK<T>([In] T FDFHGIHHGHO) where T : notnull
	{
		return default(IKGCKHLMHFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2786C00", Offset = "0x2786000", VA = "0x182786C00")]
	public static IKGCKHLMHFG<T?> NHJOJBOJMOO<T>()
	{
		return default(IKGCKHLMHFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2786B90", Offset = "0x2785F90", VA = "0x182786B90")]
	public static bool GGEALMNHJMO<T>([In] this IKGCKHLMHFG<T> IGDCJEJDAIL, [Out][NotNullWhen(true)] T FDFHGIHHGHO) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct HKDNMAIEHEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr ANFFIBOKGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr KOKEENPPDDH;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr JMPPPGAFEOK;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr KADMMCFPECA;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly HKDNMAIEHEC FEAMHHDKACA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool INMLDJBGPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5FEB840", Offset = "0x5FEAC40", VA = "0x185FEB840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8833F0", Offset = "0x8827F0", VA = "0x1808833F0")]
	public HKDNMAIEHEC(IntPtr CKPABDJAGLL, IntPtr DJIGBHODBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370")]
	private static void JFKMPKPOIDB(string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370")]
	private static void AEOKDBMIOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB920", Offset = "0x5FEAD20", VA = "0x185FEB920")]
	private static HKDNMAIEHEC OBPDDHFCBGJ()
	{
		return default(HKDNMAIEHEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct JMKMIPLIPIG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr MMPDDCIIAOC;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF70", Offset = "0x8BB370", VA = "0x1808BBF70")]
	private JMKMIPLIPIG(IntPtr DJIGBHODBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1D4D970", Offset = "0x1D4CD70", VA = "0x181D4D970", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC510", Offset = "0x5FEB910", VA = "0x185FEC510")]
	public static JMKMIPLIPIG JKJFENIAMEL(string OMHHPMIDNAN)
	{
		return default(JMKMIPLIPIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D52FD0", Offset = "0x1D523D0", VA = "0x181D52FD0")]
	public static JMKMIPLIPIG JKJFENIAMEL([In] HKDNMAIEHEC KINLJDFKFNB, string OMHHPMIDNAN)
	{
		return default(JMKMIPLIPIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1D52DE0", Offset = "0x1D521E0", VA = "0x181D52DE0")]
	public static JMKMIPLIPIG JKJFENIAMEL([In] HKDNMAIEHEC KINLJDFKFNB, Func<string> OMHHPMIDNAN)
	{
		return default(JMKMIPLIPIG);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class EBLLCKANLKO
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate bool FGNNLGCJHMK<in TInput, TResult>(TInput KODNHMICLEA, [Out] TResult MNKBHKEBOPJ);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private sealed class NNIDFKINCMK : FGNEIPLABBD
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private sealed class KEDNGIOFBAE : AGKMCOIMIGO, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly KEDNGIOFBAE MEGHANKAOBP;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool MEINDBODKAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000AF")]
				[Cpp2IlInjected.Address(RVA = "0x5FECF60", Offset = "0x5FEC360", VA = "0x185FECF60", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x5FECFC0", Offset = "0x5FEC3C0", VA = "0x185FECFC0", Slot = "6")]
			public void OnCompleted(Action AOPCEFBGAGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
			public void HIJKCFDBHNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public KEDNGIOFBAE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly NNIDFKINCMK MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		private NNIDFKINCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF4D0", Offset = "0x5FEE8D0", VA = "0x185FEF4D0", Slot = "4")]
		public AGKMCOIMIGO LPPDDHLPDIP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private sealed class INLEFPKHDFP : FGNEIPLABBD
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private sealed class IEPFBIBAONO : AGKMCOIMIGO, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly IEPFBIBAONO MEGHANKAOBP;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool MEINDBODKAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x5FEBB00", Offset = "0x5FEAF00", VA = "0x185FEBB00", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x5FEBB20", Offset = "0x5FEAF20", VA = "0x185FEBB20", Slot = "6")]
			public void OnCompleted(Action AOPCEFBGAGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
			public void HIJKCFDBHNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
			public IEPFBIBAONO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly INLEFPKHDFP MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		private INLEFPKHDFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5FEC1A0", Offset = "0x5FEB5A0", VA = "0x185FEC1A0", Slot = "4")]
		public AGKMCOIMIGO LPPDDHLPDIP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class CNKCKLLGIEL<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public CNKCKLLGIEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x356E830", Offset = "0x356DC30", VA = "0x18356E830")]
		internal void LJDAPOAEMBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class HCACABKAHNC<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public HCACABKAHNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x36CAC10", Offset = "0x36CA010", VA = "0x1836CAC10")]
		internal void JHDKHNJHMKI(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct ACMODPFHHGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5FE7460", Offset = "0x5FE6860", VA = "0x185FE7460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x90BA80", Offset = "0x90AE80", VA = "0x18090BA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct HHOJNLFFGHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5FEB730", Offset = "0x5FEAB30", VA = "0x185FEB730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x90BA80", Offset = "0x90AE80", VA = "0x18090BA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct FEHNKCHKPJO<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3578A10", Offset = "0x3577E10", VA = "0x183578A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3578B80", Offset = "0x3577F80", VA = "0x183578B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct OIMLGOKKEFL<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3EF4CB0", Offset = "0x3EF40B0", VA = "0x183EF4CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3EF5520", Offset = "0x3EF4920", VA = "0x183EF5520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct GFDNDDAIJEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5FEB170", Offset = "0x5FEA570", VA = "0x185FEB170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5FEB370", Offset = "0x5FEA770", VA = "0x185FEB370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class FACDBMLNKEL<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public FACDBMLNKEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x356E830", Offset = "0x356DC30", VA = "0x18356E830")]
		internal void FFNJHHKFHDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x356E870", Offset = "0x356DC70", VA = "0x18356E870")]
		internal void JDPICHMIMNM(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct PDCABAFANBA<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public FGNNLGCJHMK<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3F97020", Offset = "0x3F96420", VA = "0x183F97020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3F97710", Offset = "0x3F96B10", VA = "0x183F97710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct OGGGEBFBACB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5FF0180", Offset = "0x5FEF580", VA = "0x185FF0180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5FF0970", Offset = "0x5FEFD70", VA = "0x185FF0970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct NJBLCMCJBME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5FEEB60", Offset = "0x5FEDF60", VA = "0x185FEEB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF0A0", Offset = "0x5FEE4A0", VA = "0x185FEF0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct GHNMPALAGHL<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x36937A0", Offset = "0x3692BA0", VA = "0x1836937A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3683A80", Offset = "0x3682E80", VA = "0x183683A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct BKAFNALBEKD<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4615080", Offset = "0x4614480", VA = "0x184615080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x31E12D0", Offset = "0x31E06D0", VA = "0x1831E12D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct MPBNGBCPPHH<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3D9CA90", Offset = "0x3D9BE90", VA = "0x183D9CA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D760", Offset = "0x3D9CB60", VA = "0x183D9D760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct PLBBDBNDAMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5FF0CA0", Offset = "0x5FF00A0", VA = "0x185FF0CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5FF0E80", Offset = "0x5FF0280", VA = "0x185FF0E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct IKIFKGMBNJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5FEBDD0", Offset = "0x5FEB1D0", VA = "0x185FEBDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5FEC140", Offset = "0x5FEB540", VA = "0x185FEC140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct GPOENDFKHMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5FEB3E0", Offset = "0x5FEA7E0", VA = "0x185FEB3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5FEB6D0", Offset = "0x5FEAAD0", VA = "0x185FEB6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class EGPDMJCEGOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public EGPDMJCEGOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5FEADB0", Offset = "0x5FEA1B0", VA = "0x185FEADB0")]
		internal Task DPCGCCMNGJN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct OFPJKHBCJNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5FEFEC0", Offset = "0x5FEF2C0", VA = "0x185FEFEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5FF0120", Offset = "0x5FEF520", VA = "0x185FF0120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct PIGFHIAEBCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5FF09D0", Offset = "0x5FEFDD0", VA = "0x185FF09D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5FF0BB0", Offset = "0x5FEFFB0", VA = "0x185FF0BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct NMAJNDBCEKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF100", Offset = "0x5FEE500", VA = "0x185FEF100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF470", Offset = "0x5FEE870", VA = "0x185FEF470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct FPKHDLHJNCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5FEAE20", Offset = "0x5FEA220", VA = "0x185FEAE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5FEB110", Offset = "0x5FEA510", VA = "0x185FEB110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class NPNPACEKAHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public NPNPACEKAHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF5A0", Offset = "0x5FEE9A0", VA = "0x185FEF5A0")]
		internal Task CIHPEDABBKJ(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct LCBDIBBBIED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5FEDC30", Offset = "0x5FED030", VA = "0x185FEDC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5FEDE90", Offset = "0x5FED290", VA = "0x185FEDE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct IJIAKFEMBOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5FEBBF0", Offset = "0x5FEAFF0", VA = "0x185FEBBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5FEBD70", Offset = "0x5FEB170", VA = "0x185FEBD70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct KJGLBPJMGHH<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3A7B6F0", Offset = "0x3A7AAF0", VA = "0x183A7B6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3A7B950", Offset = "0x3A7AD50", VA = "0x183A7B950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct MAFNCLPANBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5FEE6F0", Offset = "0x5FEDAF0", VA = "0x185FEE6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5FEEB00", Offset = "0x5FEDF00", VA = "0x185FEEB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? MGAONJNCMME;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<PJHBHBBODGG> MFGKAEADNMH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task IIAAOODJKCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5FE9200", Offset = "0x5FE8600", VA = "0x185FE9200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2502010", Offset = "0x2501410", VA = "0x182502010")]
	public static Task<T> FCHGMBDAMFK<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA920", Offset = "0x5FE9D20", VA = "0x185FEA920")]
	public static Task NLJDIJIELBG(this Task CKAKCFLCDJK, CancellationToken FACMOGNGACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2504000", Offset = "0x2503400", VA = "0x182504000")]
	public static Task<TResult> NLJDIJIELBG<TResult>(this Task<TResult> CKAKCFLCDJK, CancellationToken FACMOGNGACN) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2504DB0", Offset = "0x25041B0", VA = "0x182504DB0")]
	public static TaskCompletionSource<TResult> NLJDIJIELBG<TResult>(this TaskCompletionSource<TResult> NMFGNBBCHDA, CancellationToken FACMOGNGACN) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9740", Offset = "0x5FE8B40", VA = "0x185FE9740")]
	[AsyncStateMachine(typeof(ACMODPFHHGN))]
	public static void GJFKKLNKLCN(this Task FENMDPNPDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5FE97F0", Offset = "0x5FE8BF0", VA = "0x185FE97F0")]
	[AsyncStateMachine(typeof(HHOJNLFFGHF))]
	public static void GMBPOPPPHCJ(this Task FENMDPNPDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2501F40", Offset = "0x2501340", VA = "0x182501F40")]
	[AsyncStateMachine(typeof(FEHNKCHKPJO<>))]
	public static Task DPALIBJFAPG<TException>(this Task FENMDPNPDJP) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x25055B0", Offset = "0x25049B0", VA = "0x1825055B0")]
	[AsyncStateMachine(typeof(OIMLGOKKEFL<>))]
	public static Task<T> PFDJBBJEGBO<T>(this Task<T> NHHBAHIFHJK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA170", Offset = "0x5FE9570", VA = "0x185FEA170")]
	[AsyncStateMachine(typeof(GFDNDDAIJEL))]
	public static Task<TaskStatus> LMPEDDKDHEG(this Task NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2502510", Offset = "0x2501910", VA = "0x182502510")]
	public static (Task<T?>?, Action<T?>?) KEABGOAEAPJ<T>([Optional] CancellationToken HNLFPBLPOKJ)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2502320", Offset = "0x2501720", VA = "0x182502320")]
	[AsyncStateMachine(typeof(PDCABAFANBA<, >))]
	public static Task<List<TResult>> FPBNMJOGGKG<TResult, TInput>(this Task<List<TInput>> CKAKCFLCDJK, FGNNLGCJHMK<TInput, TResult> MJFDIAPGOBM) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9EB0", Offset = "0x5FE92B0", VA = "0x185FE9EB0")]
	[AsyncStateMachine(typeof(OGGGEBFBACB))]
	public static Task KILFDDGAKCD(Task FENMDPNPDJP, CancellationToken LBFDCKKMBFP, Func<CancellationToken, Task> IOFHLOAFDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9270", Offset = "0x5FE8670", VA = "0x185FE9270")]
	[AsyncStateMachine(typeof(NJBLCMCJBME))]
	public static Task ANBEBJKNHHJ(Func<CancellationToken, Task> KONGNKHADNA, TimeSpan ILFNCCAINDB, [Optional] CancellationToken LBFDCKKMBFP, [Optional] Action<OperationCanceledException>? LJKGPBKLDNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2501CE0", Offset = "0x25010E0", VA = "0x182501CE0")]
	[AsyncStateMachine(typeof(GHNMPALAGHL<>))]
	public static Task<T> ANBEBJKNHHJ<T>(Func<CancellationToken, Task<T>> KONGNKHADNA, TimeSpan ILFNCCAINDB, [Optional] CancellationToken LBFDCKKMBFP, [Optional] Func<OperationCanceledException, T>? LJKGPBKLDNF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2502240", Offset = "0x2501640", VA = "0x182502240")]
	[AsyncStateMachine(typeof(BKAFNALBEKD<>))]
	public static Task<IEnumerable<Task<T>>> FOKJOHPCLCL<T>(IEnumerable<Task<T>> LABOJMJCKDH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2505310", Offset = "0x2504710", VA = "0x182505310")]
	[AsyncStateMachine(typeof(MPBNGBCPPHH<, , , >))]
	public static Task<(T1, T2, T3, T4)> PBHMEDIEHDK<T1, T2, T3, T4>(Task<T1> ODHAPJFHIOC, Task<T2> GGJINFGGAHA, Task<T3> EHEIMLKMJAC, Task<T4> BFHFIJALGGD) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9D70", Offset = "0x5FE9170", VA = "0x185FE9D70")]
	[AsyncStateMachine(typeof(PLBBDBNDAMG))]
	public static Task JGFBLGBKKBE(Func<bool> BMPNDHLKPNC, [Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9C60", Offset = "0x5FE9060", VA = "0x185FE9C60")]
	[AsyncStateMachine(typeof(IKIFKGMBNJI))]
	public static Task JGFBLGBKKBE(Func<bool> BMPNDHLKPNC, TimeSpan FOGPEFKIJLL, [Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5FE94D0", Offset = "0x5FE88D0", VA = "0x185FE94D0")]
	[AsyncStateMachine(typeof(GPOENDFKHMI))]
	public static Task GEIEFCDEJNN(Func<bool> BMPNDHLKPNC, TimeSpan ILFNCCAINDB, [Optional] CancellationToken HNLFPBLPOKJ, [Optional] Action<OperationCanceledException>? LJKGPBKLDNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9600", Offset = "0x5FE8A00", VA = "0x185FE9600")]
	[AsyncStateMachine(typeof(OFPJKHBCJNN))]
	public static Task GEIEFCDEJNN(Func<bool> BMPNDHLKPNC, TimeSpan ILFNCCAINDB, TimeSpan FOGPEFKIJLL, [Optional] CancellationToken HNLFPBLPOKJ, [Optional] Action<OperationCanceledException>? LJKGPBKLDNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5FE99B0", Offset = "0x5FE8DB0", VA = "0x185FE99B0")]
	[AsyncStateMachine(typeof(PIGFHIAEBCK))]
	public static Task GMPHONBNBNJ(Func<bool> BMPNDHLKPNC, [Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5FE98A0", Offset = "0x5FE8CA0", VA = "0x185FE98A0")]
	[AsyncStateMachine(typeof(NMAJNDBCEKB))]
	public static Task GMPHONBNBNJ(Func<bool> BMPNDHLKPNC, TimeSpan FOGPEFKIJLL, [Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA470", Offset = "0x5FE9870", VA = "0x185FEA470")]
	[AsyncStateMachine(typeof(FPKHDLHJNCC))]
	public static Task MMIPNGFPJJA(Func<bool> BMPNDHLKPNC, TimeSpan ILFNCCAINDB, [Optional] CancellationToken HNLFPBLPOKJ, [Optional] Action<OperationCanceledException>? LJKGPBKLDNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA330", Offset = "0x5FE9730", VA = "0x185FEA330")]
	[AsyncStateMachine(typeof(LCBDIBBBIED))]
	public static Task MMIPNGFPJJA(Func<bool> BMPNDHLKPNC, TimeSpan ILFNCCAINDB, TimeSpan FOGPEFKIJLL, [Optional] CancellationToken HNLFPBLPOKJ, [Optional] Action<OperationCanceledException>? LJKGPBKLDNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9AA0", Offset = "0x5FE8EA0", VA = "0x185FE9AA0")]
	[Obsolete]
	[AsyncStateMachine(typeof(IJIAKFEMBOM))]
	public static Task GNGCBJNGEAO(this Task CKAKCFLCDJK, Action EGCDJJLCCKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2502420", Offset = "0x2501820", VA = "0x182502420")]
	[Obsolete]
	[AsyncStateMachine(typeof(KJGLBPJMGHH<>))]
	public static Task GNGCBJNGEAO<T>(this Task<T> CKAKCFLCDJK, Action<T> EGCDJJLCCKJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE93A0", Offset = "0x5FE87A0", VA = "0x185FE93A0")]
	private static void DJJPHIMNHKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA5A0", Offset = "0x5FE99A0", VA = "0x185FEA5A0")]
	public static bool NKBMJIKLBMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9FE0", Offset = "0x5FE93E0", VA = "0x185FE9FE0")]
	private static void KJHCJDNIDPL(SynchronizationContext FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5FEAB80", Offset = "0x5FE9F80", VA = "0x185FEAB80")]
	private static void PBAGEBLOCBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9B90", Offset = "0x5FE8F90", VA = "0x185FE9B90")]
	public static void GPPNEGBDLEC([Optional] string? DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9450", Offset = "0x5FE8850", VA = "0x185FE9450")]
	public static void EMAAHIABNEM([Optional] string? DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9E60", Offset = "0x5FE9260", VA = "0x185FE9E60")]
	public static FGNEIPLABBD KBHPCPPBEPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5FEACA0", Offset = "0x5FEA0A0", VA = "0x185FEACA0")]
	public static FGNEIPLABBD PHHIJILJOFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5FEA260", Offset = "0x5FE9660", VA = "0x185FEA260")]
	[AsyncStateMachine(typeof(MAFNCLPANBN))]
	public static Task MEFPALMEIJL(Func<Task> BINBFFLGBGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class NIFGLBMGAEB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
	public NIFGLBMGAEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class COKINHCODMK : POIPBNPALLD
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly POIPBNPALLD MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime NMFNKMGEDPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5FE9140", Offset = "0x5FE8540", VA = "0x185FE9140", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset EJOMKDAEMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5FE90E0", Offset = "0x5FE84E0", VA = "0x185FE90E0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public COKINHCODMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface POIPBNPALLD
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime NMFNKMGEDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset EJOMKDAEMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class OEKCAHIEOBN
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long HLBBKFBPKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF9E0", Offset = "0x5FEEDE0", VA = "0x185FEF9E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long GIGJPBAMBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF6A0", Offset = "0x5FEEAA0", VA = "0x185FEF6A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double LHAIOACJOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF780", Offset = "0x5FEEB80", VA = "0x185FEF780")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double GJLKJJCNAJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF8B0", Offset = "0x5FEECB0", VA = "0x185FEF8B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double BFPFKJOEACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF860", Offset = "0x5FEEC60", VA = "0x185FEF860")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double DAFBNMAEODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5FEF990", Offset = "0x5FEED90", VA = "0x185FEF990")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5FEF900", Offset = "0x5FEED00", VA = "0x185FEF900")]
	public static double JLOJDABEHCC(long NMOPCHHBGNC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5FEF7D0", Offset = "0x5FEEBD0", VA = "0x185FEF7D0")]
	public static double HBPFCPMECHI(long NMOPCHHBGNC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5FEF6F0", Offset = "0x5FEEAF0", VA = "0x185FEF6F0")]
	public static double EMFJEOLAGAF(double HNIGHFEEIPN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFA30", Offset = "0x5FEEE30", VA = "0x185FEFA30")]
	public static long NNGBNAACNMM(long EDBFKNKJGAL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5FEF690", Offset = "0x5FEEA90", VA = "0x185FEF690")]
	public static long AAGAIHNJMGH(long FALFFHCDFBF, long LLJGEGPBOMO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFB20", Offset = "0x5FEEF20", VA = "0x185FEFB20")]
	public static double PNHJMCIOFAN(long FALFFHCDFBF, long LLJGEGPBOMO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFAC0", Offset = "0x5FEEEC0", VA = "0x185FEFAC0")]
	public static double PAFJINIBGLI(long FALFFHCDFBF, long LLJGEGPBOMO)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class LMPBEEAJPNN : PKJFBHNKINM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan BMNHKMFEAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer CBPCKBLKEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan ILFNCCAINDB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan KBMNCHLELKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5FEE0C0", Offset = "0x5FED4C0", VA = "0x185FEE0C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? GCOBBDBDIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x79F440", Offset = "0x79E840", VA = "0x18079F440", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE430", Offset = "0x5FED830", VA = "0x185FEE430")]
	[Preserve]
	public LMPBEEAJPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE4A0", Offset = "0x5FED8A0", VA = "0x185FEE4A0")]
	public LMPBEEAJPNN(TimeSpan ILFNCCAINDB, [Optional] Action? NIIFOMAHAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE290", Offset = "0x5FED690", VA = "0x185FEE290", Slot = "7")]
	public void KDHLPBFNFLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE220", Offset = "0x5FED620", VA = "0x185FEE220", Slot = "8")]
	public void JIJNGCOKGOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5FEDFF0", Offset = "0x5FED3F0", VA = "0x185FEDFF0", Slot = "9")]
	public void CICOGPEPCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xB8EA80", Offset = "0xB8DE80", VA = "0x180B8EA80")]
	private void FHBCAIGOCNO(object JHEMNDMHNOB, ElapsedEventArgs MAAMODELLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE320", Offset = "0x5FED720", VA = "0x185FEE320")]
	private static void NGEKKHLPBAN(TimeSpan FCEJOKOOAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE020", Offset = "0x5FED420", VA = "0x185FEE020", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class AOICGJECGOP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string HINAJBIGBMK;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7C8560", Offset = "0x7C7960", VA = "0x1807C8560")]
	public AOICGJECGOP(string NDBGGHMJKHH)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct BKILFBCIGKN : IEquatable<BKILFBCIGKN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public uint JKABPKCJCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public int KADPKCIACKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public float KBNHKEDJHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public ushort MBPKCLIIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort MGIBKHFCOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public short ONJFPAGJIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short MIGKHHCMGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public char OLLMODHECMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char LDJAIOGHGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public byte POIBDKECHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte LCJLBONPAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte BGKJOJHKFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte PMCAKOKOCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public bool ALDPFMIEDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool HCEGFHJPBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool FPCOKHIOPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool LMNOFCLBAKL;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xBFD7D0", Offset = "0xBFCBD0", VA = "0x180BFD7D0")]
	public static BKILFBCIGKN MCFCOFKHMEJ(uint EOPOMJIPPAH)
	{
		return default(BKILFBCIGKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xBFD7D0", Offset = "0xBFCBD0", VA = "0x180BFD7D0")]
	public static BKILFBCIGKN KAOPBGBBIGL(int HELELFNPBBH)
	{
		return default(BKILFBCIGKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7660", Offset = "0x5FE6A60", VA = "0x185FE7660")]
	public static BKILFBCIGKN MJIOJHPNOJG(float IEJEAHHFJBM)
	{
		return default(BKILFBCIGKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7640", Offset = "0x5FE6A40", VA = "0x185FE7640")]
	public static BKILFBCIGKN OGAFFJBNCHH(byte AFLGCBKDHFA, byte HGBLOJIPCOA, byte LJHFJBDHKMG, byte GMKGHKMOMDF)
	{
		return default(BKILFBCIGKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7640", Offset = "0x5FE6A40", VA = "0x185FE7640")]
	public static BKILFBCIGKN FEBFKEGDCNI(bool NMHCBMMBMDD, bool KEDFAHLAOPN, bool IFGLFNGHACN, bool EMFLMAFPBGK)
	{
		return default(BKILFBCIGKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7640", Offset = "0x5FE6A40", VA = "0x185FE7640")]
	public static BKILFBCIGKN HCIJDLNDLDE(byte NHPMMJCBNLC, byte PIKNNCHHHMK, byte MFAMOGBGPFA, byte ILMCEPAMEBN)
	{
		return default(BKILFBCIGKN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x175BFD0", Offset = "0x175B3D0", VA = "0x18175BFD0")]
	public static bool FFFIMEBHMPG(BKILFBCIGKN CGDDINAJAOB, BKILFBCIGKN GIFBDNCPDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x817B90", Offset = "0x816F90", VA = "0x180817B90", Slot = "4")]
	public bool Equals(BKILFBCIGKN AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5FE75C0", Offset = "0x5FE69C0", VA = "0x185FE75C0", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x89A350", Offset = "0x899750", VA = "0x18089A350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5FE7670", Offset = "0x5FE6A70", VA = "0x185FE7670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct INPPDCLIBGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public ulong CGPGPNABAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public long AJNHHPKNFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public double GDIDKANIIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint IJLFGOHGOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint FGPJBMCMJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public int DMBPKBHMKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int JNGLENCFEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public float PKFMPCNJHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float NBNDDCCDIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public ushort MBPKCLIIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort MGIBKHFCOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort DBMLJKPKLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort JAAFECDIAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short ONJFPAGJIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short MIGKHHCMGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short CPEMMKLGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short CKHLOHONHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public char OLLMODHECMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char LDJAIOGHGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char BEGJANBKNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char PJCKHMDHABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte POIBDKECHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte LCJLBONPAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte BGKJOJHKFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte PMCAKOKOCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte LMPOKGAEIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte NHPLDCLKEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte OJCPAOOCAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte DKKMPPNDPCE;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC270", Offset = "0x5FEB670", VA = "0x185FEC270")]
	public static INPPDCLIBGL JKJFENIAMEL(byte AFLGCBKDHFA, byte HGBLOJIPCOA, byte LJHFJBDHKMG, byte GMKGHKMOMDF, byte PABMPBGGPEL, byte IFDBIBDNBFA, byte KEOCBFAAMOL, byte OAICNICNJFK)
	{
		return default(INPPDCLIBGL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class JONCGAFOOOF<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly T DFHHMGGIIGL;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E0F0", Offset = "0x3A0D4F0", VA = "0x183A0E0F0")]
	public JONCGAFOOOF(T DLFKFHOEIBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class OPKPCEIPMGP
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x279A160", Offset = "0x2799560", VA = "0x18279A160")]
	public static JONCGAFOOOF<T> JKJFENIAMEL<T>(T DLFKFHOEIBJ) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class LFPDBDOEDDM
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x26EEDF0", Offset = "0x26EE1F0", VA = "0x1826EEDF0")]
	public static IEnumerable<T> KMDCOMPOBPM<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x86D430", Offset = "0x86C830", VA = "0x18086D430")]
	public static T[] ECBLCAIHLGF<T>(params T[] NPEAPCBLKIJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x86D430", Offset = "0x86C830", VA = "0x18086D430")]
	public static IEnumerable<T> CCBDBJMGCDD<T>(params T[] NPEAPCBLKIJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x26D9450", Offset = "0x26D8850", VA = "0x1826D9450")]
	public static HashSet<T> DHCBOPEALEL<T>(params T[] NPEAPCBLKIJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x26EED00", Offset = "0x26EE100", VA = "0x1826EED00")]
	public static KeyValuePair<TKey, TValue> GOKLIPDJJMJ<TKey, TValue>([In] TKey KCGLPAPOILB, [In] TValue FDFHGIHHGHO) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x26D9450", Offset = "0x26D8850", VA = "0x1826D9450")]
	public static List<T> CKIPEPNJEJF<T>(IEnumerable<T> NBBGPGGFMPG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[AttributeUsage(AttributeTargets.All)]
public sealed class NIGHNNDPAGO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public readonly string FKPJCPDIIMB;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7C8560", Offset = "0x7C7960", VA = "0x1807C8560")]
	public NIGHNNDPAGO(string AKPLHCDECML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate object CIOAAOPKPLJ<T>([In] T AHLEFKCGEBC);
[Cpp2IlInjected.Token(Token = "0x2000054")]
public delegate object LHGDOIAANHF<T>(T AHLEFKCGEBC);
[Cpp2IlInjected.Token(Token = "0x2000055")]
[MJHMIJGAHPE]
public delegate string LHHFILEJBPD(string ADLBCEDEBAN, string? FIJABPAFDME, bool IMKMAJEEFPA);
[Cpp2IlInjected.Token(Token = "0x2000056")]
[MJHMIJGAHPE]
public delegate void BKGGEBDLKEK(string DCKDMGKGDFN);
[Cpp2IlInjected.Token(Token = "0x2000057")]
[MJHMIJGAHPE]
public delegate void BIJBIMOIBLG(Exception MEIELCKPCNE);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object KOBHHIGCAPD();
[Cpp2IlInjected.Token(Token = "0x2000059")]
[MJHMIJGAHPE]
public delegate bool NNINFIFGOFM();
[Cpp2IlInjected.Token(Token = "0x200005A")]
[MJHMIJGAHPE]
public delegate string BOLFBJGMBHP(object MBCPMMHPENP);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.Enum)]
public class CIIPALEPLMC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
	public CIIPALEPLMC()
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
