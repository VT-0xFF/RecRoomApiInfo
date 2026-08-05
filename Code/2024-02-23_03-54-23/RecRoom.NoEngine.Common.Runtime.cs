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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6069050", Offset = "0x6067A50", VA = "0x186069050")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D2560", Offset = "0x7D0F60", VA = "0x1807D2560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D25A0", Offset = "0x7D0FA0", VA = "0x1807D25A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6061E90", Offset = "0x6060890", VA = "0x186061E90")]
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
		[Cpp2IlInjected.Address(RVA = "0x35A24B0", Offset = "0x35A0EB0", VA = "0x1835A24B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x35A3510", Offset = "0x35A1F10", VA = "0x1835A3510", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D74BB0", Offset = "0x3D735B0", VA = "0x183D74BB0")]
	[AsyncStateMachine(typeof(MBGGCCPHPOB<>.FDOBOKCCCLD))]
	public Task<TResult> MJOLKNKBOPN(PKNJAIAOLPN IEBCOABNEMM, [Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D74B40", Offset = "0x3D73540", VA = "0x183D74B40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D74CF0", Offset = "0x3D736F0", VA = "0x183D74CF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3204F90", Offset = "0x3203990", VA = "0x183204F90")]
	public LHEJMGKFLDK([In] T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3B86160", Offset = "0x3B84B60", VA = "0x183B86160", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3B862E0", Offset = "0x3B84CE0", VA = "0x183B862E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3B86550", Offset = "0x3B84F50", VA = "0x183B86550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JOJKBELIDGE
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6066970", Offset = "0x6065370", VA = "0x186066970")]
	public static void KAHBNDEFGNE(this CancellationTokenSource MFNNECHIHMJ, bool BLANLPPLHIK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class MJHMIJGAHPE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
	public MJHMIJGAHPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class FANKNDILCGJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
	public FANKNDILCGJ(string COEFJMLBJJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JCKCECLLMGN
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x26E1DC0", Offset = "0x26E07C0", VA = "0x1826E1DC0")]
	public static IPKBLOGLFHG FEALKIGFCCP<T>()
	{
		return default(IPKBLOGLFHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x26E1FC0", Offset = "0x26E09C0", VA = "0x1826E1FC0")]
	public static IPKBLOGLFHG JPHFIACIOHM<T>([CallerMemberName] string OMHHPMIDNAN = "") where T : notnull
	{
		return default(IPKBLOGLFHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x26E1D40", Offset = "0x26E0740", VA = "0x1826E1D40")]
	public static IPKBLOGLFHG FEALKIGFCCP<T>(this T JHEMNDMHNOB) where T : notnull
	{
		return default(IPKBLOGLFHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x26E1E40", Offset = "0x26E0840", VA = "0x1826E1E40")]
	public static IPKBLOGLFHG GDOELCOJAEI<T>(this T JHEMNDMHNOB, [CallerMemberName] string OMHHPMIDNAN = "") where T : notnull
	{
		return default(IPKBLOGLFHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x26E2050", Offset = "0x26E0A50", VA = "0x1826E2050")]
	public static IPKBLOGLFHG JPHFIACIOHM<T>(this T NHHBAHIFHJK, [CallerMemberName] string OMHHPMIDNAN = "") where T : notnull
	{
		return default(IPKBLOGLFHG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6065EC0", Offset = "0x60648C0", VA = "0x186065EC0")]
	public static IPKBLOGLFHG JPHFIACIOHM(string ANDKLKNHFBB, [CallerMemberName] string OMHHPMIDNAN = "")
	{
		return default(IPKBLOGLFHG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6065E20", Offset = "0x6064820", VA = "0x186065E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6066860", Offset = "0x6065260", VA = "0x186066860")]
		get
		{
			return default(KGKONKIIIJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static CMLABEFMCPO IEFLNIGHNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x60666A0", Offset = "0x60650A0", VA = "0x1860666A0")]
		get
		{
			return default(CMLABEFMCPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static HKDNMAIEHEC OHCKBFLDDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6066360", Offset = "0x6064D60", VA = "0x186066360")]
		get
		{
			return default(HKDNMAIEHEC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool MPDHOGHFDPL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6066630", Offset = "0x6065030", VA = "0x186066630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6066480", Offset = "0x6064E80", VA = "0x186066480")]
	public static void FDDBMCDHILM([In] KGKONKIIIJC GAFKMGGPMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60660A0", Offset = "0x6064AA0", VA = "0x1860660A0")]
	public static void BDAJDFAFKKC(string DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60663B0", Offset = "0x6064DB0", VA = "0x1860663B0")]
	public static void EIOKCLMHEHA(string DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x270BC30", Offset = "0x270A630", VA = "0x18270BC30")]
	public static void EIOKCLMHEHA<T>(T OEJAGOPNKOK, LHGDOIAANHF<T> DCKDMGKGDFN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6066750", Offset = "0x6065150", VA = "0x186066750")]
	public static void LOHEEKGGMHP(Exception MEIELCKPCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6066040", Offset = "0x6064A40", VA = "0x186066040")]
	public static void ANFFIBOKGAE(string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60666F0", Offset = "0x60650F0", VA = "0x1860666F0")]
	public static void KOKEENPPDDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6066240", Offset = "0x6064C40", VA = "0x186066240")]
	public static string DLJMBHOMMMH(object MBCPMMHPENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60667F0", Offset = "0x60651F0", VA = "0x1860667F0")]
	public static long MKGEBBOHCAI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60662C0", Offset = "0x6064CC0", VA = "0x1860662C0")]
	public static bool DMMNDDMJJHD(bool BMPNDHLKPNC, string DCKDMGKGDFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6066170", Offset = "0x6064B70", VA = "0x186066170")]
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
		[Cpp2IlInjected.Address(RVA = "0x6066BE0", Offset = "0x60655E0", VA = "0x186066BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60675C0", Offset = "0x6065FC0", VA = "0x1860675C0")]
	public KGKONKIIIJC([In] CMLABEFMCPO NMBDIAJJMFO, [In] HKDNMAIEHEC KINLJDFKFNB, BOLFBJGMBHP NADHFEAICFB, DIGEIEHIMCO EFJHFONAPDH, LHHFILEJBPD BCLGBAPCHNA, FKNMAJPGJEA BJGFFICEOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6066D80", Offset = "0x6065780", VA = "0x186066D80")]
	private static string KKBFOMHJPBD(object MBCPMMHPENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7A8380", Offset = "0x7A6D80", VA = "0x1807A8380")]
	private static long GIHHFHGAPFA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x877270", Offset = "0x875C70", VA = "0x180877270")]
	private static string DGFJBGIDOJA(string ADLBCEDEBAN, string? FIJABPAFDME, bool IMKMAJEEFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0")]
	private static bool IHPKFPLJGCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6066DC0", Offset = "0x60657C0", VA = "0x186066DC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D85CA0", Offset = "0x1D846A0", VA = "0x181D85CA0")]
	public DNLMNGBCBFK([In] T FDFHGIHHGHO, int OJANCMLFDOJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4F21780", Offset = "0x4F20180", VA = "0x184F21780")]
	public static bool FFFIMEBHMPG([In] DNLMNGBCBFK<T> JIKBDKDLPCA, [In] DNLMNGBCBFK<T> DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x37EE530", Offset = "0x37ECF30", VA = "0x1837EE530", Slot = "4")]
	public bool Equals(DNLMNGBCBFK<T> AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x484F310", Offset = "0x484DD10", VA = "0x18484F310", Slot = "0")]
	public override bool Equals(object AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4F22810", Offset = "0x4F21210", VA = "0x184F22810")]
	public bool MLPLMDDOIJN([In] DNLMNGBCBFK<T> AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4F21F20", Offset = "0x4F20920", VA = "0x184F21F20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4F22B10", Offset = "0x4F21510", VA = "0x184F22B10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4F22380", Offset = "0x4F20D80", VA = "0x184F22380")]
	public void LIIEGHCBNII([Out] T FDFHGIHHGHO, [Out] int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4F21320", Offset = "0x4F1FD20", VA = "0x184F21320")]
	public (T, int) CDONDHEJHGP()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4F220F0", Offset = "0x4F20AF0", VA = "0x184F220F0", Slot = "5")]
	private bool JCDFDLFFJAB([In] DNLMNGBCBFK<T> AAMIMDAKFMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class INFOBIFIPFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x26D2610", Offset = "0x26D1010", VA = "0x1826D2610")]
	public static DNLMNGBCBFK<T> JKJFENIAMEL<T>([In] T FDFHGIHHGHO, int OJANCMLFDOJ) where T : notnull
	{
		return default(DNLMNGBCBFK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NLOGGCPCIAL
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x27C3C40", Offset = "0x27C2640", VA = "0x1827C3C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6061FD0", Offset = "0x60609D0", VA = "0x186061FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x946550", Offset = "0x944F50", VA = "0x180946550")]
	public CMLABEFMCPO(NNINFIFGOFM KMEINGIMGCH, BKGGEBDLKEK NCBDONIHOMG, NNINFIFGOFM GCDGEBCCNDN, BKGGEBDLKEK FPGPPOGKELH, NNINFIFGOFM IGEAMPMFFKJ, BKGGEBDLKEK BBGLNJNAPDL, BIJBIMOIBLG FJJMDJABJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0")]
	private static bool HBPIHGELNOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370")]
	private static void ILAAIGHOMGI(string DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0")]
	private static bool BACKGCGLOLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370")]
	private static void LNBFGPKLOMA(string DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0")]
	private static bool JMEOAIHAFNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370")]
	private static void GAMJJBAOPMK(string DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370")]
	private static void LHCMEBMKCFN(Exception MEIELCKPCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60623F0", Offset = "0x6060DF0", VA = "0x1860623F0")]
	private static CMLABEFMCPO OBPDDHFCBGJ()
	{
		return default(CMLABEFMCPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C2240", Offset = "0x7C0C40", VA = "0x1807C2240")]
	private static bool NIGOMKPNKFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6061F60", Offset = "0x6060960", VA = "0x186061F60")]
	public void BDAJDFAFKKC(object DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6062380", Offset = "0x6060D80", VA = "0x186062380")]
	public void EIOKCLMHEHA(object DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1906F40", Offset = "0x1905940", VA = "0x181906F40")]
	public void LOHEEKGGMHP(Exception MEIELCKPCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x60622A0", Offset = "0x6060CA0", VA = "0x1860622A0")]
	public void EIOKCLMHEHA(KOBHHIGCAPD DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x250A2D0", Offset = "0x2508CD0", VA = "0x18250A2D0")]
	public void EIOKCLMHEHA<T>(T OEJAGOPNKOK, LHGDOIAANHF<T> DCKDMGKGDFN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x250A150", Offset = "0x2508B50", VA = "0x18250A150")]
	public void BDAJDFAFKKC<T>([In] T OEJAGOPNKOK, CIOAAOPKPLJ<T> DCKDMGKGDFN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x60621D0", Offset = "0x6060BD0", VA = "0x1860621D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8C6B40", Offset = "0x8C5540", VA = "0x1808C6B40")]
	public IPKBLOGLFHG(string FDFHGIHHGHO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x814590", Offset = "0x812F90", VA = "0x180814590")]
	public static string CPALPDKLBCM([In] IPKBLOGLFHG NHHBAHIFHJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1401FB0", Offset = "0x14009B0", VA = "0x181401FB0")]
	public static IPKBLOGLFHG CPALPDKLBCM(string AAMIMDAKFMC)
	{
		return default(IPKBLOGLFHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6065CF0", Offset = "0x60646F0", VA = "0x186065CF0")]
	public string ABBBNPNOEFO(string MKFPNMJBPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6065D40", Offset = "0x6064740", VA = "0x186065D40")]
	public string AFIELBNIKGN(object NFCAPOLGADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x814590", Offset = "0x812F90", VA = "0x180814590", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C2240", Offset = "0x7C0C40", VA = "0x1807C2240", Slot = "4")]
	public bool Equals(PJHBHBBODGG AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x606A650", Offset = "0x6069050", VA = "0x18606A650", Slot = "0")]
	public override bool Equals(object AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x606A6A0", Offset = "0x60690A0", VA = "0x18606A6A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x606A6B0", Offset = "0x60690B0", VA = "0x18606A6B0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x37EF060", Offset = "0x37EDA60", VA = "0x1837EF060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x37EF7D0", Offset = "0x37EE1D0", VA = "0x1837EF7D0")]
	public IKGCKHLMHFG([In] T FDFHGIHHGHO, bool APPGEFJHLBP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x37EECF0", Offset = "0x37ED6F0", VA = "0x1837EECF0")]
	public static bool FFFIMEBHMPG([In] IKGCKHLMHFG<T> JIKBDKDLPCA, [In] IKGCKHLMHFG<T> DOFNKPFHEKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x37EE530", Offset = "0x37ECF30", VA = "0x1837EE530", Slot = "4")]
	public bool Equals(IKGCKHLMHFG<T> AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x37EE8B0", Offset = "0x37ED2B0", VA = "0x1837EE8B0", Slot = "0")]
	public override bool Equals(object AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x37EF070", Offset = "0x37EDA70", VA = "0x1837EF070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x37EF570", Offset = "0x37EDF70", VA = "0x1837EF570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class OIENENDAFLI
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x27DCD40", Offset = "0x27DB740", VA = "0x1827DCD40")]
	public static IKGCKHLMHFG<T> OFOPCELCJBK<T>([In] T FDFHGIHHGHO) where T : notnull
	{
		return default(IKGCKHLMHFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x27DCC00", Offset = "0x27DB600", VA = "0x1827DCC00")]
	public static IKGCKHLMHFG<T?> NHJOJBOJMOO<T>()
	{
		return default(IKGCKHLMHFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x27DCB90", Offset = "0x27DB590", VA = "0x1827DCB90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6065270", Offset = "0x6063C70", VA = "0x186065270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x88E8A0", Offset = "0x88D2A0", VA = "0x18088E8A0")]
	public HKDNMAIEHEC(IntPtr CKPABDJAGLL, IntPtr DJIGBHODBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370")]
	private static void JFKMPKPOIDB(string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370")]
	private static void AEOKDBMIOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6065350", Offset = "0x6063D50", VA = "0x186065350")]
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
	[Cpp2IlInjected.Address(RVA = "0x8C6B40", Offset = "0x8C5540", VA = "0x1808C6B40")]
	private JMKMIPLIPIG(IntPtr DJIGBHODBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6065F40", Offset = "0x6064940", VA = "0x186065F40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6065F50", Offset = "0x6064950", VA = "0x186065F50")]
	public static JMKMIPLIPIG JKJFENIAMEL(string OMHHPMIDNAN)
	{
		return default(JMKMIPLIPIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D6DBD0", Offset = "0x1D6C5D0", VA = "0x181D6DBD0")]
	public static JMKMIPLIPIG JKJFENIAMEL([In] HKDNMAIEHEC KINLJDFKFNB, string OMHHPMIDNAN)
	{
		return default(JMKMIPLIPIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1D6D9E0", Offset = "0x1D6C3E0", VA = "0x181D6D9E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
				[Cpp2IlInjected.Address(RVA = "0x60669A0", Offset = "0x60653A0", VA = "0x1860669A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6066A00", Offset = "0x6065400", VA = "0x186066A00", Slot = "6")]
			public void OnCompleted(Action AOPCEFBGAGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
			public void HIJKCFDBHNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public KEDNGIOFBAE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly NNIDFKINCMK MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		private NNIDFKINCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6068F10", Offset = "0x6067910", VA = "0x186068F10", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6065530", Offset = "0x6063F30", VA = "0x186065530", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6065550", Offset = "0x6063F50", VA = "0x186065550", Slot = "6")]
			public void OnCompleted(Action AOPCEFBGAGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
			public void HIJKCFDBHNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public IEPFBIBAONO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly INLEFPKHDFP MEGHANKAOBP;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		private INLEFPKHDFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6065BD0", Offset = "0x60645D0", VA = "0x186065BD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public CNKCKLLGIEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x35999D0", Offset = "0x35983D0", VA = "0x1835999D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public HCACABKAHNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x36E8F00", Offset = "0x36E7900", VA = "0x1836E8F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6060E90", Offset = "0x605F890", VA = "0x186060E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x917090", Offset = "0x915A90", VA = "0x180917090", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6065160", Offset = "0x6063B60", VA = "0x186065160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x917090", Offset = "0x915A90", VA = "0x180917090", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x35A3AB0", Offset = "0x35A24B0", VA = "0x1835A3AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x35A3C20", Offset = "0x35A2620", VA = "0x1835A3C20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F29B50", Offset = "0x3F28550", VA = "0x183F29B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A3C0", Offset = "0x3F28DC0", VA = "0x183F2A3C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6064BA0", Offset = "0x60635A0", VA = "0x186064BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6064DA0", Offset = "0x60637A0", VA = "0x186064DA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public FACDBMLNKEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x35999D0", Offset = "0x35983D0", VA = "0x1835999D0")]
		internal void FFNJHHKFHDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3599A10", Offset = "0x3598410", VA = "0x183599A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FCDFF0", Offset = "0x3FCC9F0", VA = "0x183FCDFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3FCE6E0", Offset = "0x3FCD0E0", VA = "0x183FCE6E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6069BC0", Offset = "0x60685C0", VA = "0x186069BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x606A3B0", Offset = "0x6068DB0", VA = "0x18606A3B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x60685A0", Offset = "0x6066FA0", VA = "0x1860685A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6068AE0", Offset = "0x60674E0", VA = "0x186068AE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x36B16F0", Offset = "0x36B00F0", VA = "0x1836B16F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x36A1CA0", Offset = "0x36A06A0", VA = "0x1836A1CA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4661EA0", Offset = "0x46608A0", VA = "0x184661EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3210B30", Offset = "0x320F530", VA = "0x183210B30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DD2EC0", Offset = "0x3DD18C0", VA = "0x183DD2EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3B90", Offset = "0x3DD2590", VA = "0x183DD3B90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x606A6E0", Offset = "0x60690E0", VA = "0x18606A6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x606A8C0", Offset = "0x60692C0", VA = "0x18606A8C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6065800", Offset = "0x6064200", VA = "0x186065800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6065B70", Offset = "0x6064570", VA = "0x186065B70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6064E10", Offset = "0x6063810", VA = "0x186064E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6065100", Offset = "0x6063B00", VA = "0x186065100", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public EGPDMJCEGOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x60647E0", Offset = "0x60631E0", VA = "0x1860647E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6069900", Offset = "0x6068300", VA = "0x186069900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6069B60", Offset = "0x6068560", VA = "0x186069B60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x606A410", Offset = "0x6068E10", VA = "0x18606A410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x606A5F0", Offset = "0x6068FF0", VA = "0x18606A5F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6068B40", Offset = "0x6067540", VA = "0x186068B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6068EB0", Offset = "0x60678B0", VA = "0x186068EB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6064850", Offset = "0x6063250", VA = "0x186064850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6064B40", Offset = "0x6063540", VA = "0x186064B40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public NPNPACEKAHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6068FE0", Offset = "0x60679E0", VA = "0x186068FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6067670", Offset = "0x6066070", VA = "0x186067670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x60678D0", Offset = "0x60662D0", VA = "0x1860678D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6065620", Offset = "0x6064020", VA = "0x186065620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x60657A0", Offset = "0x60641A0", VA = "0x1860657A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3AA6B60", Offset = "0x3AA5560", VA = "0x183AA6B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3AA6DC0", Offset = "0x3AA57C0", VA = "0x183AA6DC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6068130", Offset = "0x6066B30", VA = "0x186068130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6068540", Offset = "0x6066F40", VA = "0x186068540", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6062C30", Offset = "0x6061630", VA = "0x186062C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x25541B0", Offset = "0x2552BB0", VA = "0x1825541B0")]
	public static Task<T> FCHGMBDAMFK<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6064350", Offset = "0x6062D50", VA = "0x186064350")]
	public static Task NLJDIJIELBG(this Task CKAKCFLCDJK, CancellationToken FACMOGNGACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x25561A0", Offset = "0x2554BA0", VA = "0x1825561A0")]
	public static Task<TResult> NLJDIJIELBG<TResult>(this Task<TResult> CKAKCFLCDJK, CancellationToken FACMOGNGACN) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2556F50", Offset = "0x2555950", VA = "0x182556F50")]
	public static TaskCompletionSource<TResult> NLJDIJIELBG<TResult>(this TaskCompletionSource<TResult> NMFGNBBCHDA, CancellationToken FACMOGNGACN) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6063170", Offset = "0x6061B70", VA = "0x186063170")]
	[AsyncStateMachine(typeof(ACMODPFHHGN))]
	public static void GJFKKLNKLCN(this Task FENMDPNPDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6063220", Offset = "0x6061C20", VA = "0x186063220")]
	[AsyncStateMachine(typeof(HHOJNLFFGHF))]
	public static void GMBPOPPPHCJ(this Task FENMDPNPDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x25540E0", Offset = "0x2552AE0", VA = "0x1825540E0")]
	[AsyncStateMachine(typeof(FEHNKCHKPJO<>))]
	public static Task DPALIBJFAPG<TException>(this Task FENMDPNPDJP) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2557750", Offset = "0x2556150", VA = "0x182557750")]
	[AsyncStateMachine(typeof(OIMLGOKKEFL<>))]
	public static Task<T> PFDJBBJEGBO<T>(this Task<T> NHHBAHIFHJK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6063BA0", Offset = "0x60625A0", VA = "0x186063BA0")]
	[AsyncStateMachine(typeof(GFDNDDAIJEL))]
	public static Task<TaskStatus> LMPEDDKDHEG(this Task NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x25546B0", Offset = "0x25530B0", VA = "0x1825546B0")]
	public static (Task<T?>?, Action<T?>?) KEABGOAEAPJ<T>([Optional] CancellationToken HNLFPBLPOKJ)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x25544C0", Offset = "0x2552EC0", VA = "0x1825544C0")]
	[AsyncStateMachine(typeof(PDCABAFANBA<, >))]
	public static Task<List<TResult>> FPBNMJOGGKG<TResult, TInput>(this Task<List<TInput>> CKAKCFLCDJK, FGNNLGCJHMK<TInput, TResult> MJFDIAPGOBM) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x60638E0", Offset = "0x60622E0", VA = "0x1860638E0")]
	[AsyncStateMachine(typeof(OGGGEBFBACB))]
	public static Task KILFDDGAKCD(Task FENMDPNPDJP, CancellationToken LBFDCKKMBFP, Func<CancellationToken, Task> IOFHLOAFDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6062CA0", Offset = "0x60616A0", VA = "0x186062CA0")]
	[AsyncStateMachine(typeof(NJBLCMCJBME))]
	public static Task ANBEBJKNHHJ(Func<CancellationToken, Task> KONGNKHADNA, TimeSpan ILFNCCAINDB, [Optional] CancellationToken LBFDCKKMBFP, [Optional] Action<OperationCanceledException>? LJKGPBKLDNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2553E80", Offset = "0x2552880", VA = "0x182553E80")]
	[AsyncStateMachine(typeof(GHNMPALAGHL<>))]
	public static Task<T> ANBEBJKNHHJ<T>(Func<CancellationToken, Task<T>> KONGNKHADNA, TimeSpan ILFNCCAINDB, [Optional] CancellationToken LBFDCKKMBFP, [Optional] Func<OperationCanceledException, T>? LJKGPBKLDNF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x25543E0", Offset = "0x2552DE0", VA = "0x1825543E0")]
	[AsyncStateMachine(typeof(BKAFNALBEKD<>))]
	public static Task<IEnumerable<Task<T>>> FOKJOHPCLCL<T>(IEnumerable<Task<T>> LABOJMJCKDH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x25574B0", Offset = "0x2555EB0", VA = "0x1825574B0")]
	[AsyncStateMachine(typeof(MPBNGBCPPHH<, , , >))]
	public static Task<(T1, T2, T3, T4)> PBHMEDIEHDK<T1, T2, T3, T4>(Task<T1> ODHAPJFHIOC, Task<T2> GGJINFGGAHA, Task<T3> EHEIMLKMJAC, Task<T4> BFHFIJALGGD) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x60637A0", Offset = "0x60621A0", VA = "0x1860637A0")]
	[AsyncStateMachine(typeof(PLBBDBNDAMG))]
	public static Task JGFBLGBKKBE(Func<bool> BMPNDHLKPNC, [Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6063690", Offset = "0x6062090", VA = "0x186063690")]
	[AsyncStateMachine(typeof(IKIFKGMBNJI))]
	public static Task JGFBLGBKKBE(Func<bool> BMPNDHLKPNC, TimeSpan FOGPEFKIJLL, [Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6062F00", Offset = "0x6061900", VA = "0x186062F00")]
	[AsyncStateMachine(typeof(GPOENDFKHMI))]
	public static Task GEIEFCDEJNN(Func<bool> BMPNDHLKPNC, TimeSpan ILFNCCAINDB, [Optional] CancellationToken HNLFPBLPOKJ, [Optional] Action<OperationCanceledException>? LJKGPBKLDNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6063030", Offset = "0x6061A30", VA = "0x186063030")]
	[AsyncStateMachine(typeof(OFPJKHBCJNN))]
	public static Task GEIEFCDEJNN(Func<bool> BMPNDHLKPNC, TimeSpan ILFNCCAINDB, TimeSpan FOGPEFKIJLL, [Optional] CancellationToken HNLFPBLPOKJ, [Optional] Action<OperationCanceledException>? LJKGPBKLDNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x60633E0", Offset = "0x6061DE0", VA = "0x1860633E0")]
	[AsyncStateMachine(typeof(PIGFHIAEBCK))]
	public static Task GMPHONBNBNJ(Func<bool> BMPNDHLKPNC, [Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x60632D0", Offset = "0x6061CD0", VA = "0x1860632D0")]
	[AsyncStateMachine(typeof(NMAJNDBCEKB))]
	public static Task GMPHONBNBNJ(Func<bool> BMPNDHLKPNC, TimeSpan FOGPEFKIJLL, [Optional] CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6063EA0", Offset = "0x60628A0", VA = "0x186063EA0")]
	[AsyncStateMachine(typeof(FPKHDLHJNCC))]
	public static Task MMIPNGFPJJA(Func<bool> BMPNDHLKPNC, TimeSpan ILFNCCAINDB, [Optional] CancellationToken HNLFPBLPOKJ, [Optional] Action<OperationCanceledException>? LJKGPBKLDNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6063D60", Offset = "0x6062760", VA = "0x186063D60")]
	[AsyncStateMachine(typeof(LCBDIBBBIED))]
	public static Task MMIPNGFPJJA(Func<bool> BMPNDHLKPNC, TimeSpan ILFNCCAINDB, TimeSpan FOGPEFKIJLL, [Optional] CancellationToken HNLFPBLPOKJ, [Optional] Action<OperationCanceledException>? LJKGPBKLDNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x60634D0", Offset = "0x6061ED0", VA = "0x1860634D0")]
	[Obsolete]
	[AsyncStateMachine(typeof(IJIAKFEMBOM))]
	public static Task GNGCBJNGEAO(this Task CKAKCFLCDJK, Action EGCDJJLCCKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x25545C0", Offset = "0x2552FC0", VA = "0x1825545C0")]
	[Obsolete]
	[AsyncStateMachine(typeof(KJGLBPJMGHH<>))]
	public static Task GNGCBJNGEAO<T>(this Task<T> CKAKCFLCDJK, Action<T> EGCDJJLCCKJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6062DD0", Offset = "0x60617D0", VA = "0x186062DD0")]
	private static void DJJPHIMNHKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6063FD0", Offset = "0x60629D0", VA = "0x186063FD0")]
	public static bool NKBMJIKLBMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6063A10", Offset = "0x6062410", VA = "0x186063A10")]
	private static void KJHCJDNIDPL(SynchronizationContext FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x60645B0", Offset = "0x6062FB0", VA = "0x1860645B0")]
	private static void PBAGEBLOCBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x60635C0", Offset = "0x6061FC0", VA = "0x1860635C0")]
	public static void GPPNEGBDLEC([Optional] string? DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6062E80", Offset = "0x6061880", VA = "0x186062E80")]
	public static void EMAAHIABNEM([Optional] string? DCKDMGKGDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6063890", Offset = "0x6062290", VA = "0x186063890")]
	public static FGNEIPLABBD KBHPCPPBEPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x60646D0", Offset = "0x60630D0", VA = "0x1860646D0")]
	public static FGNEIPLABBD PHHIJILJOFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6063C90", Offset = "0x6062690", VA = "0x186063C90")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6062B70", Offset = "0x6061570", VA = "0x186062B70", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset EJOMKDAEMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6062B10", Offset = "0x6061510", VA = "0x186062B10", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
		[Cpp2IlInjected.Address(RVA = "0x6069420", Offset = "0x6067E20", VA = "0x186069420")]
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
		[Cpp2IlInjected.Address(RVA = "0x60690E0", Offset = "0x6067AE0", VA = "0x1860690E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x60691C0", Offset = "0x6067BC0", VA = "0x1860691C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x60692F0", Offset = "0x6067CF0", VA = "0x1860692F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x60692A0", Offset = "0x6067CA0", VA = "0x1860692A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x60693D0", Offset = "0x6067DD0", VA = "0x1860693D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6069340", Offset = "0x6067D40", VA = "0x186069340")]
	public static double JLOJDABEHCC(long NMOPCHHBGNC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6069210", Offset = "0x6067C10", VA = "0x186069210")]
	public static double HBPFCPMECHI(long NMOPCHHBGNC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6069130", Offset = "0x6067B30", VA = "0x186069130")]
	public static double EMFJEOLAGAF(double HNIGHFEEIPN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6069470", Offset = "0x6067E70", VA = "0x186069470")]
	public static long NNGBNAACNMM(long EDBFKNKJGAL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x60690D0", Offset = "0x6067AD0", VA = "0x1860690D0")]
	public static long AAGAIHNJMGH(long FALFFHCDFBF, long LLJGEGPBOMO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6069560", Offset = "0x6067F60", VA = "0x186069560")]
	public static double PNHJMCIOFAN(long FALFFHCDFBF, long LLJGEGPBOMO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6069500", Offset = "0x6067F00", VA = "0x186069500")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6067B00", Offset = "0x6066500", VA = "0x186067B00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? GCOBBDBDIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7A9440", Offset = "0x7A7E40", VA = "0x1807A9440", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6067E70", Offset = "0x6066870", VA = "0x186067E70")]
	[Preserve]
	public LMPBEEAJPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6067EE0", Offset = "0x60668E0", VA = "0x186067EE0")]
	public LMPBEEAJPNN(TimeSpan ILFNCCAINDB, [Optional] Action? NIIFOMAHAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6067CD0", Offset = "0x60666D0", VA = "0x186067CD0", Slot = "7")]
	public void KDHLPBFNFLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6067C60", Offset = "0x6066660", VA = "0x186067C60", Slot = "8")]
	public void JIJNGCOKGOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6067A30", Offset = "0x6066430", VA = "0x186067A30", Slot = "9")]
	public void CICOGPEPCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xB9A8F0", Offset = "0xB992F0", VA = "0x180B9A8F0")]
	private void FHBCAIGOCNO(object JHEMNDMHNOB, ElapsedEventArgs MAAMODELLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6067D60", Offset = "0x6066760", VA = "0x186067D60")]
	private static void NGEKKHLPBAN(TimeSpan FCEJOKOOAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6067A60", Offset = "0x6066460", VA = "0x186067A60", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D2560", Offset = "0x7D0F60", VA = "0x1807D2560")]
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
	[Cpp2IlInjected.Address(RVA = "0xC0AF30", Offset = "0xC09930", VA = "0x180C0AF30")]
	public static BKILFBCIGKN MCFCOFKHMEJ(uint EOPOMJIPPAH)
	{
		return default(BKILFBCIGKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xC0AF30", Offset = "0xC09930", VA = "0x180C0AF30")]
	public static BKILFBCIGKN KAOPBGBBIGL(int HELELFNPBBH)
	{
		return default(BKILFBCIGKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6061090", Offset = "0x605FA90", VA = "0x186061090")]
	public static BKILFBCIGKN MJIOJHPNOJG(float IEJEAHHFJBM)
	{
		return default(BKILFBCIGKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6061070", Offset = "0x605FA70", VA = "0x186061070")]
	public static BKILFBCIGKN OGAFFJBNCHH(byte AFLGCBKDHFA, byte HGBLOJIPCOA, byte LJHFJBDHKMG, byte GMKGHKMOMDF)
	{
		return default(BKILFBCIGKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6061070", Offset = "0x605FA70", VA = "0x186061070")]
	public static BKILFBCIGKN FEBFKEGDCNI(bool NMHCBMMBMDD, bool KEDFAHLAOPN, bool IFGLFNGHACN, bool EMFLMAFPBGK)
	{
		return default(BKILFBCIGKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6061070", Offset = "0x605FA70", VA = "0x186061070")]
	public static BKILFBCIGKN HCIJDLNDLDE(byte NHPMMJCBNLC, byte PIKNNCHHHMK, byte MFAMOGBGPFA, byte ILMCEPAMEBN)
	{
		return default(BKILFBCIGKN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x17722A0", Offset = "0x1770CA0", VA = "0x1817722A0")]
	public static bool FFFIMEBHMPG(BKILFBCIGKN CGDDINAJAOB, BKILFBCIGKN GIFBDNCPDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x821940", Offset = "0x820340", VA = "0x180821940", Slot = "4")]
	public bool Equals(BKILFBCIGKN AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6060FF0", Offset = "0x605F9F0", VA = "0x186060FF0", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x8A5710", Offset = "0x8A4110", VA = "0x1808A5710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x60610A0", Offset = "0x605FAA0", VA = "0x1860610A0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x6065CA0", Offset = "0x60646A0", VA = "0x186065CA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A38E90", Offset = "0x3A37890", VA = "0x183A38E90")]
	public JONCGAFOOOF(T DLFKFHOEIBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class OPKPCEIPMGP
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x27F0190", Offset = "0x27EEB90", VA = "0x1827F0190")]
	public static JONCGAFOOOF<T> JKJFENIAMEL<T>(T DLFKFHOEIBJ) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class LFPDBDOEDDM
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2745B20", Offset = "0x2744520", VA = "0x182745B20")]
	public static IEnumerable<T> KMDCOMPOBPM<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x877270", Offset = "0x875C70", VA = "0x180877270")]
	public static T[] ECBLCAIHLGF<T>(params T[] NPEAPCBLKIJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x877270", Offset = "0x875C70", VA = "0x180877270")]
	public static IEnumerable<T> CCBDBJMGCDD<T>(params T[] NPEAPCBLKIJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2730430", Offset = "0x272EE30", VA = "0x182730430")]
	public static HashSet<T> DHCBOPEALEL<T>(params T[] NPEAPCBLKIJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2745A30", Offset = "0x2744430", VA = "0x182745A30")]
	public static KeyValuePair<TKey, TValue> GOKLIPDJJMJ<TKey, TValue>([In] TKey KCGLPAPOILB, [In] TValue FDFHGIHHGHO) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2730430", Offset = "0x272EE30", VA = "0x182730430")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D2560", Offset = "0x7D0F60", VA = "0x1807D2560")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
