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
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F845B0", Offset = "0x6F835B0", VA = "0x186F845B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0550", Offset = "0x8DF550", VA = "0x1808E0550")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E0590", Offset = "0x8DF590", VA = "0x1808E0590")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CKCHGNHLFGB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F7D7D0", Offset = "0x6F7C7D0", VA = "0x186F7D7D0")]
	public static string ICHIBGMGCOL(this Encoding OMJEAOPLEPO, [In] ReadOnlySequence<byte> HPKNAAFAALO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2D6AB10", Offset = "0x2D69B10", VA = "0x182D6AB10")]
	private static void CFFAGHGKBHM<T>(this ReadOnlySequence<T> EGGPEJFCICF, [Out] ReadOnlySpan<T> CJPNIPDMCBJ, [Out] SequencePosition OKACLIDCEGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class OENFDFJFBHO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F84630", Offset = "0x6F83630", VA = "0x186F84630")]
	public OENFDFJFBHO(bool HHPCKHHNKEM, string KBDJELGMCPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JKGELIDMNMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LCKPFDPPKPP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LJEBGFHLJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAEAPHDOCFK(string MLAECOMLIEC, double BJDKOHEGDOK, [Optional] string? NCBDDCNHKCK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class AOBJKAELGKA<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate Task<TResult> DMHNMEBOEFF(CancellationToken CLIKNEKJHEI);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct NBFGLAGIGMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AOBJKAELGKA<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public DMHNMEBOEFF taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x49BF730", Offset = "0x49BE730", VA = "0x1849BF730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x49C0870", Offset = "0x49BF870", VA = "0x1849C0870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource OCGANIIFAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? EMBNBAKCOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? DPKMDFOKILB;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x43E4B20", Offset = "0x43E3B20", VA = "0x1843E4B20")]
	[AsyncStateMachine(typeof(AOBJKAELGKA<>.NBFGLAGIGMP))]
	public Task<TResult> EKEEJFGKENB(DMHNMEBOEFF DOJDBNDPKDG, [Optional] CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x43E4AB0", Offset = "0x43E3AB0", VA = "0x1843E4AB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x43E4C70", Offset = "0x43E3C70", VA = "0x1843E4C70")]
	public AOBJKAELGKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class HOHBLJHJAGC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> MBDIPFIAKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T DMNEEJMINJG;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4211650", Offset = "0x4210650", VA = "0x184211650")]
	public HOHBLJHJAGC([In] T BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4210680", Offset = "0x420F680", VA = "0x184210680", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4210DE0", Offset = "0x420FDE0", VA = "0x184210DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4211120", Offset = "0x4210120", VA = "0x184211120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class AMNACJBOMAB
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2D6B850", Offset = "0x2D6A850", VA = "0x182D6B850")]
	public static HOHBLJHJAGC<T> EJLELCHFLID<T>([In] T BJDKOHEGDOK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KCFJNPHNFHI
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F82880", Offset = "0x6F81880", VA = "0x186F82880")]
	public static void LBMEHGEHAHJ(this CancellationTokenSource OCGANIIFAKG, bool KIJEMJJKDHE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class LFNOHIAAPPN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
	public LFNOHIAAPPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class AMAEILDHAGM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
	public AMAEILDHAGM(string OMACOIHPJHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OLMHKGOMJAL
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x314BA60", Offset = "0x314AA60", VA = "0x18314BA60")]
	public static FGCMJDDBINM GAIIGOJJABD<T>()
	{
		return default(FGCMJDDBINM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x314BCB0", Offset = "0x314ACB0", VA = "0x18314BCB0")]
	public static FGCMJDDBINM GEDIHMELHFM<T>([CallerMemberName] string DMCFPOLFNCF = "") where T : notnull
	{
		return default(FGCMJDDBINM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x314BAE0", Offset = "0x314AAE0", VA = "0x18314BAE0")]
	public static FGCMJDDBINM GAIIGOJJABD<T>(this T BEELICCCBAC) where T : notnull
	{
		return default(FGCMJDDBINM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x314BE00", Offset = "0x314AE00", VA = "0x18314BE00")]
	public static FGCMJDDBINM GMEHDBDJKPK<T>(this T BEELICCCBAC, [CallerMemberName] string DMCFPOLFNCF = "") where T : notnull
	{
		return default(FGCMJDDBINM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x314BD50", Offset = "0x314AD50", VA = "0x18314BD50")]
	public static FGCMJDDBINM GEDIHMELHFM<T>(this T GFJPFDOHONG, [CallerMemberName] string DMCFPOLFNCF = "") where T : notnull
	{
		return default(FGCMJDDBINM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F84980", Offset = "0x6F83980", VA = "0x186F84980")]
	public static FGCMJDDBINM GEDIHMELHFM(string JEJLBMIIBEJ, [CallerMemberName] string DMCFPOLFNCF = "")
	{
		return default(FGCMJDDBINM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F84A00", Offset = "0x6F83A00", VA = "0x186F84A00")]
	public static string JODLAOCMMIF(this object GFJPFDOHONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool DCNJAEPNMNC();
[Cpp2IlInjected.Token(Token = "0x2000014")]
[LFNOHIAAPPN]
public delegate long DOCJGFGMCEP();
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class JLNCFAKKBIG
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static EBAGAJIIFIH CCNAGGAAOOA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static EBAGAJIIFIH NIGCLPJCBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F82150", Offset = "0x6F81150", VA = "0x186F82150")]
		get
		{
			return default(EBAGAJIIFIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static BDLCOGNBOKL MHLLIGMMMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F821A0", Offset = "0x6F811A0", VA = "0x186F821A0")]
		get
		{
			return default(BDLCOGNBOKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static COKBDJJJNNK AIOGMIBAFOE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6F822C0", Offset = "0x6F812C0", VA = "0x186F822C0")]
		get
		{
			return default(COKBDJJJNNK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool FIPHBNAJGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6F82010", Offset = "0x6F81010", VA = "0x186F82010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F82620", Offset = "0x6F81620", VA = "0x186F82620")]
	public static void PGDDMKCPEBC([In] EBAGAJIIFIH EKKMMKFOEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6F82080", Offset = "0x6F81080", VA = "0x186F82080")]
	public static void CDMGIBILAAG(string ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F821F0", Offset = "0x6F811F0", VA = "0x186F821F0")]
	public static void EPFFODEJOHA(string ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3006170", Offset = "0x3005170", VA = "0x183006170")]
	public static void EPFFODEJOHA<T>(T FPMIIFOGKII, FBNMAKEJBBA<T> ABHPFCOODAJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F82580", Offset = "0x6F81580", VA = "0x186F82580")]
	public static void NKBFOPNCLDG(Exception BKFPPGLJAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F82380", Offset = "0x6F81380", VA = "0x186F82380")]
	public static void JCNJCBNBKND(string DMCFPOLFNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F82510", Offset = "0x6F81510", VA = "0x186F82510")]
	public static void NFMLKGDIPMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F82400", Offset = "0x6F81400", VA = "0x186F82400")]
	public static string JODLAOCMMIF(object IFPBFCLBBDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F82310", Offset = "0x6F81310", VA = "0x186F82310")]
	public static long HPFENMFKHOE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F82470", Offset = "0x6F81470", VA = "0x186F82470")]
	public static bool LLPJPACAGCA(bool PAHLJNPBBFN, string ABHPFCOODAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6F81F40", Offset = "0x6F80F40", VA = "0x186F81F40")]
	public static double BACBCIIAJOI()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct EBAGAJIIFIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly BDLCOGNBOKL MHLLIGMMMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly COKBDJJJNNK AIOGMIBAFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly GHMGODINDBH JHBKGOJJFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly DOCJGFGMCEP KBPCHONKABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly OFPOMANFHFB CMNOELDBEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly DCNJAEPNMNC NMLCEHLJGEK;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly GHMGODINDBH LHEOLHDDIHN;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly DOCJGFGMCEP HJJDOHOMBCJ;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly OFPOMANFHFB NNMIHJFBCBJ;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly DCNJAEPNMNC HKOHICGBMIA;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly EBAGAJIIFIH BOAMOHHEBKK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DCLLIFLPMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F480", Offset = "0x6F7E480", VA = "0x186F7F480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FE10", Offset = "0x6F7EE10", VA = "0x186F7FE10")]
	public EBAGAJIIFIH([In] BDLCOGNBOKL FMKKIKHHJNF, [In] COKBDJJJNNK FGCMJFKEIKH, GHMGODINDBH EGLBKCHEJBA, DOCJGFGMCEP CGJPPFEEBBC, OFPOMANFHFB FHKNIFLNDPF, DCNJAEPNMNC OGHMIMIFOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F610", Offset = "0x6F7E610", VA = "0x186F7F610")]
	private static string DJMICFDGBMH(object IFPBFCLBBDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0")]
	private static long GEDIBNGKGIP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
	private static string FEKAJHNPJCP(string DIENLBCMIGK, string? NHMAPAIFDPB, bool FIJMKMIBEPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40")]
	private static bool HHDMMLLILPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F650", Offset = "0x6F7E650", VA = "0x186F7F650")]
	private static EBAGAJIIFIH DNEHCAGBCKD()
	{
		return default(EBAGAJIIFIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NDGGCMODOCL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OOEAIIBIBGM ALMCJCFOGEI();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OOEAIIBIBGM : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool HICNMIFIMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DIDAPJDBCDC();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface PLNBPIMMAIH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OCBJJFACBHD([In] T DFABCHNPEEM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void IIOHCHNJLKH<T>([In] T FPMIIFOGKII);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct DEKIHPBEIOD<T> : IEquatable<DEKIHPBEIOD<T>>, PLNBPIMMAIH<DEKIHPBEIOD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T DMNEEJMINJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int HOLNAIGPNGB;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x231B2B0", Offset = "0x231A2B0", VA = "0x18231B2B0")]
	public DEKIHPBEIOD([In] T BJDKOHEGDOK, int KHAIDMGPIED)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5D75BC0", Offset = "0x5D74BC0", VA = "0x185D75BC0")]
	public static bool LJMKDDBNEAO([In] DEKIHPBEIOD<T> GGEOEEJGPGH, [In] DEKIHPBEIOD<T> OLIPOMNIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5347110", Offset = "0x5346110", VA = "0x185347110", Slot = "4")]
	public bool Equals(DEKIHPBEIOD<T> DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3C6AC20", Offset = "0x3C69C20", VA = "0x183C6AC20", Slot = "0")]
	public override bool Equals(object DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5D76150", Offset = "0x5D75150", VA = "0x185D76150")]
	public bool OCBJJFACBHD([In] DEKIHPBEIOD<T> DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5D75500", Offset = "0x5D74500", VA = "0x185D75500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5D76520", Offset = "0x5D75520", VA = "0x185D76520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5D74D90", Offset = "0x5D73D90", VA = "0x185D74D90")]
	public void GIFBHPBPLDG([Out] T BJDKOHEGDOK, [Out] int KHAIDMGPIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5D75770", Offset = "0x5D74770", VA = "0x185D75770")]
	public (T, int) IFNFNNMKCGN()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5D74BA0", Offset = "0x5D73BA0", VA = "0x185D74BA0", Slot = "5")]
	private bool FMGBMJHKJDN([In] DEKIHPBEIOD<T> DFABCHNPEEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class IKDPINMMMOH
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2FB0940", Offset = "0x2FAF940", VA = "0x182FB0940")]
	public static DEKIHPBEIOD<T> EJLELCHFLID<T>([In] T BJDKOHEGDOK, int KHAIDMGPIED) where T : notnull
	{
		return default(DEKIHPBEIOD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class HBGEKABJNNC
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2F8A080", Offset = "0x2F89080", VA = "0x182F8A080")]
	public static bool OCBJJFACBHD<T, U>([In] T GFJPFDOHONG, [In] U IFPBFCLBBDP) where T : notnull, PLNBPIMMAIH<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult PMPJPEFEKGM<T, out TResult>([In] T FPMIIFOGKII);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface LCLGPNHKENP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	TimeSpan OCBBKGHLDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Action? HBLILMACNNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DMGNCFFGIOF();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HMLGAEAHBLA();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DLOEAOFKNPE();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct BDLCOGNBOKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly FGGNBLLCONI DGLCDMMGIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly AEJEAPENEOI JGMFHGGGGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly FGGNBLLCONI AEIIEJPMDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly AEJEAPENEOI BEMENDJKFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly FGGNBLLCONI AOEMFBPNLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly AEJEAPENEOI ACOILFAFHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly BJAHEALLALN KDCABJBODOA;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly FGGNBLLCONI FLNCFLOBGIG;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly AEJEAPENEOI EGHKCGMMKDK;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly FGGNBLLCONI JKOOFJFNBDN;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly AEJEAPENEOI HBBGNONGDME;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly FGGNBLLCONI GHKNCGGIMFG;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly AEJEAPENEOI IBNPPFBHJFL;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly BJAHEALLALN GECKEPMALBG;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly BDLCOGNBOKL BOAMOHHEBKK;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly FGGNBLLCONI MLLNDJEKCJN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool DCLLIFLPMLP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BFC0", Offset = "0x6F7AFC0", VA = "0x186F7BFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x9D6DB0", Offset = "0x9D5DB0", VA = "0x1809D6DB0")]
	public BDLCOGNBOKL(FGGNBLLCONI LGINMLIGHKI, AEJEAPENEOI AOHHDKMDNCI, FGGNBLLCONI LGPJJLGGMAA, AEJEAPENEOI MHHKABHBFMN, FGGNBLLCONI DPEOPLAHHBC, AEJEAPENEOI IJFAEMPGPDH, BJAHEALLALN LEJFHIHIEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40")]
	private static bool OCINBOILAKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	private static void JKMNFHMKGPI(string ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40")]
	private static bool GBNEAADMFFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	private static void CNLCADDIGNO(string ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40")]
	private static bool MGMEPIAPLAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	private static void KBIIJBOBHFJ(string ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	private static void JBFNANDCNFL(Exception BKFPPGLJAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C210", Offset = "0x6F7B210", VA = "0x186F7C210")]
	private static BDLCOGNBOKL DNEHCAGBCKD()
	{
		return default(BDLCOGNBOKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0")]
	private static bool BDAHBMPPDIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C1A0", Offset = "0x6F7B1A0", VA = "0x186F7C1A0")]
	public void CDMGIBILAAG(object ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C350", Offset = "0x6F7B350", VA = "0x186F7C350")]
	public void EPFFODEJOHA(object ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9D3420", Offset = "0x9D2420", VA = "0x1809D3420")]
	public void NKBFOPNCLDG(Exception BKFPPGLJAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C3C0", Offset = "0x6F7B3C0", VA = "0x186F7C3C0")]
	public void EPFFODEJOHA(IAAOPEAIMCH ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6A90", Offset = "0x2CF5A90", VA = "0x182CF6A90")]
	public void EPFFODEJOHA<T>(T FPMIIFOGKII, FBNMAKEJBBA<T> ABHPFCOODAJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6680", Offset = "0x2CF5680", VA = "0x182CF6680")]
	public void CDMGIBILAAG<T>([In] T FPMIIFOGKII, GBBCHECOLNH<T> ABHPFCOODAJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6820", Offset = "0x2CF5820", VA = "0x182CF6820")]
	public void EPFFODEJOHA<T>([In] T FPMIIFOGKII, GBBCHECOLNH<T> ABHPFCOODAJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C4A0", Offset = "0x6F7B4A0", VA = "0x186F7C4A0")]
	public bool LLPJPACAGCA(bool PAHLJNPBBFN, string ABHPFCOODAJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct FGCMJDDBINM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string DMNEEJMINJG;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
	public FGCMJDDBINM(string BJDKOHEGDOK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960")]
	public static string ILBKFABDDDI([In] FGCMJDDBINM GFJPFDOHONG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xD4EBE0", Offset = "0xD4DBE0", VA = "0x180D4EBE0")]
	public static FGCMJDDBINM ILBKFABDDDI(string DFABCHNPEEM)
	{
		return default(FGCMJDDBINM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6F80260", Offset = "0x6F7F260", VA = "0x186F80260")]
	public string HKMDHCEDFNK(string BJCHJIOGDBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6F802B0", Offset = "0x6F7F2B0", VA = "0x186F802B0")]
	public string OJCJLMJNNCG(object EGHDBCPGONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct MKHCENILMPB : IEquatable<MKHCENILMPB>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "4")]
	public bool Equals(MKHCENILMPB DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6F83E50", Offset = "0x6F82E50", VA = "0x186F83E50", Slot = "0")]
	public override bool Equals(object DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6F83EA0", Offset = "0x6F82EA0", VA = "0x186F83EA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6F83EB0", Offset = "0x6F82EB0", VA = "0x186F83EB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[GKFAPCOLABH("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct BHNGMIADPIG<T> : IEquatable<BHNGMIADPIG<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T DMNEEJMINJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool HGFMGNPGDPI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EKHBIDKOKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5347640", Offset = "0x5346640", VA = "0x185347640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5348A40", Offset = "0x5347A40", VA = "0x185348A40")]
	public BHNGMIADPIG([In] T BJDKOHEGDOK, bool HJIHHDKKOIG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5347C60", Offset = "0x5346C60", VA = "0x185347C60")]
	public static bool LJMKDDBNEAO([In] BHNGMIADPIG<T> GGEOEEJGPGH, [In] BHNGMIADPIG<T> OLIPOMNIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5347110", Offset = "0x5346110", VA = "0x185347110", Slot = "4")]
	public bool Equals(BHNGMIADPIG<T> DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x53474A0", Offset = "0x53464A0", VA = "0x1853474A0", Slot = "0")]
	public override bool Equals(object DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5347B40", Offset = "0x5346B40", VA = "0x185347B40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x53486A0", Offset = "0x53476A0", VA = "0x1853486A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class LBMEMPKBIMA
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3049330", Offset = "0x3048330", VA = "0x183049330")]
	public static BHNGMIADPIG<T> GHNFPAHJALD<T>([In] T BJDKOHEGDOK) where T : notnull
	{
		return default(BHNGMIADPIG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x30494C0", Offset = "0x30484C0", VA = "0x1830494C0")]
	public static BHNGMIADPIG<T?> LBMLOGEEGGJ<T>()
	{
		return default(BHNGMIADPIG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3049600", Offset = "0x3048600", VA = "0x183049600")]
	public static bool MLLPKKMKDCG<T>([In] this BHNGMIADPIG<T> GPIGIKHGBFJ, [Out][NotNullWhen(true)] T BJDKOHEGDOK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3049270", Offset = "0x3048270", VA = "0x183049270")]
	public static T? GCLDKFEGJKA<T>([In] this BHNGMIADPIG<T> GPIGIKHGBFJ, T? MJBMFFMBOMO)
	{
		return (T?)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct COKBDJJJNNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr JCNJCBNBKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr NFMLKGDIPMO;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr LKNLHJFKJCN;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr PFAKHLKEDHK;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly COKBDJJJNNK BOAMOHHEBKK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool DCLLIFLPMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E000", Offset = "0x6F7D000", VA = "0x186F7E000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xE8C760", Offset = "0xE8B760", VA = "0x180E8C760")]
	public COKBDJJJNNK(IntPtr BHLKOLCMBAA, IntPtr JNIPHAEJDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	private static void OPDDEJDLJGP(string DMCFPOLFNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	private static void BOPLMDKONDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E0D0", Offset = "0x6F7D0D0", VA = "0x186F7E0D0")]
	private static COKBDJJJNNK DNEHCAGBCKD()
	{
		return default(COKBDJJJNNK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct AJFJJOLALNP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr IKPPEIIGCOL;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
	private AJFJJOLALNP(IntPtr JNIPHAEJDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6F79BB0", Offset = "0x6F78BB0", VA = "0x186F79BB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6F79BD0", Offset = "0x6F78BD0", VA = "0x186F79BD0")]
	public static AJFJJOLALNP EJLELCHFLID(string DMCFPOLFNCF)
	{
		return default(AJFJJOLALNP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x22F8510", Offset = "0x22F7510", VA = "0x1822F8510")]
	public static AJFJJOLALNP EJLELCHFLID([In] COKBDJJJNNK FGCMJFKEIKH, string DMCFPOLFNCF)
	{
		return default(AJFJJOLALNP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x22F84A0", Offset = "0x22F74A0", VA = "0x1822F84A0")]
	public static AJFJJOLALNP EJLELCHFLID([In] COKBDJJJNNK FGCMJFKEIKH, Func<string> DMCFPOLFNCF)
	{
		return default(AJFJJOLALNP);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class ANMGDAEKGNK
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate bool HEGFMAFMIOP<in TInput, TResult>(TInput EDAMLOGMMEK, [Out] TResult POCKBMKNJHC);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class BCGNMCKGLKB : NDGGCMODOCL
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class FMGNBIPFBLD : OOEAIIBIBGM, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly FMGNBIPFBLD LONLOOPDCMJ;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool HICNMIFIMDM
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x6F80390", Offset = "0x6F7F390", VA = "0x186F80390", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6F803F0", Offset = "0x6F7F3F0", VA = "0x186F803F0", Slot = "6")]
			public void OnCompleted(Action JGDPHJOPKDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
			public void DIDAPJDBCDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public FMGNBIPFBLD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly BCGNMCKGLKB LONLOOPDCMJ;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		private BCGNMCKGLKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BF00", Offset = "0x6F7AF00", VA = "0x186F7BF00", Slot = "4")]
		public OOEAIIBIBGM ALMCJCFOGEI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private sealed class IGPDOKHAEFO : NDGGCMODOCL
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private sealed class GCCHEJPKIKC : OOEAIIBIBGM, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly GCCHEJPKIKC LONLOOPDCMJ;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool HICNMIFIMDM
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x6F805B0", Offset = "0x6F7F5B0", VA = "0x186F805B0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x6F805D0", Offset = "0x6F7F5D0", VA = "0x186F805D0", Slot = "6")]
			public void OnCompleted(Action JGDPHJOPKDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
			public void DIDAPJDBCDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public GCCHEJPKIKC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly IGPDOKHAEFO LONLOOPDCMJ;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		private IGPDOKHAEFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F80E80", Offset = "0x6F7FE80", VA = "0x186F80E80", Slot = "4")]
		public OOEAIIBIBGM ALMCJCFOGEI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JJOIHMLBCFJ<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public JJOIHMLBCFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4595CE0", Offset = "0x4594CE0", VA = "0x184595CE0")]
		internal void PFHLFOGOGLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class FGHJCKJGCCP<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public FGHJCKJGCCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3FFABD0", Offset = "0x3FF9BD0", VA = "0x183FFABD0")]
		internal void OCAIAPMJBCA(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct INAOODNMDHD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F81DE0", Offset = "0x6F80DE0", VA = "0x186F81DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct BHJDDBEAENM : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CD60", Offset = "0x6F7BD60", VA = "0x186F7CD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct JGMEHHJCGFG<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x458D6D0", Offset = "0x458C6D0", VA = "0x18458D6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x458D840", Offset = "0x458C840", VA = "0x18458D840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct JDBFCEFDHAK<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x45720C0", Offset = "0x45710C0", VA = "0x1845720C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4572510", Offset = "0x4571510", VA = "0x184572510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct CKDDFDOPKDN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DD90", Offset = "0x6F7CD90", VA = "0x186F7DD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6F7DF90", Offset = "0x6F7CF90", VA = "0x186F7DF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class LKODDKMDFAI<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public LKODDKMDFAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4595CE0", Offset = "0x4594CE0", VA = "0x184595CE0")]
		internal void CDIODHIAJNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x475D470", Offset = "0x475C470", VA = "0x18475D470")]
		internal void LMPBKIDJKJH(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct KKCEECDFAPE<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public HEGFMAFMIOP<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x469BA70", Offset = "0x469AA70", VA = "0x18469BA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x469C1D0", Offset = "0x469B1D0", VA = "0x18469C1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct PCPPHMKKBLG : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6F84BB0", Offset = "0x6F83BB0", VA = "0x186F84BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6F853A0", Offset = "0x6F843A0", VA = "0x186F853A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct CIMIJOJJFIF : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CE70", Offset = "0x6F7BE70", VA = "0x186F7CE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D3B0", Offset = "0x6F7C3B0", VA = "0x186F7D3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct NPGJEGHMLMN<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4A02BB0", Offset = "0x4A01BB0", VA = "0x184A02BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3C58370", Offset = "0x3C57370", VA = "0x183C58370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class ONGKMKGPEFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public TaskCompletionSource<MKHCENILMPB> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public ONGKMKGPEFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6F84AA0", Offset = "0x6F83AA0", VA = "0x186F84AA0")]
		internal void DANKJLIFBIA(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct ACKADPPJGAI<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x408B690", Offset = "0x408A690", VA = "0x18408B690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x39463F0", Offset = "0x39453F0", VA = "0x1839463F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct BGLCMCAFABD<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5344680", Offset = "0x5343680", VA = "0x185344680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5344DC0", Offset = "0x5343DC0", VA = "0x185344DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct BHAMKKDFDOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CB20", Offset = "0x6F7BB20", VA = "0x186F7CB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CD00", Offset = "0x6F7BD00", VA = "0x186F7CD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct CJHFBACPIFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D410", Offset = "0x6F7C410", VA = "0x186F7D410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D770", Offset = "0x6F7C770", VA = "0x186F7D770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct EBIKHAFIDHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6F7FEC0", Offset = "0x6F7EEC0", VA = "0x186F7FEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6F801B0", Offset = "0x6F7F1B0", VA = "0x186F801B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class MDGHCBKFJJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public MDGHCBKFJJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F83B20", Offset = "0x6F82B20", VA = "0x186F83B20")]
		internal Task NCKMMPDHCPP(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct MEHMNEFMKJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6F83B90", Offset = "0x6F82B90", VA = "0x186F83B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F83DF0", Offset = "0x6F82DF0", VA = "0x186F83DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct DKCMHMEJCKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F240", Offset = "0x6F7E240", VA = "0x186F7F240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F420", Offset = "0x6F7E420", VA = "0x186F7F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct NIAOHMCGIAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6F841F0", Offset = "0x6F831F0", VA = "0x186F841F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6F84550", Offset = "0x6F83550", VA = "0x186F84550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct GEDMHDCDLLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6F80690", Offset = "0x6F7F690", VA = "0x186F80690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6F80980", Offset = "0x6F7F980", VA = "0x186F80980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class OKLPLNPNICD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public OKLPLNPNICD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6F84910", Offset = "0x6F83910", VA = "0x186F84910")]
		internal Task HHCHHOJGNCL(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct HOJMIJEJCJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6F80BC0", Offset = "0x6F7FBC0", VA = "0x186F80BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6F80E20", Offset = "0x6F7FE20", VA = "0x186F80E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct GNFFMHDPNLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6F809E0", Offset = "0x6F7F9E0", VA = "0x186F809E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6F80B60", Offset = "0x6F7FB60", VA = "0x186F80B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct MDFKPKAHOMC<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4934F70", Offset = "0x4933F70", VA = "0x184934F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x49351F0", Offset = "0x49341F0", VA = "0x1849351F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct KKFBIDFGCIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6F828B0", Offset = "0x6F818B0", VA = "0x186F828B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6F82BE0", Offset = "0x6F81BE0", VA = "0x186F82BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? AGCJLBIAHFB;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<MKHCENILMPB> OLFDILILJJM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static Task FFMMMFMNPAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A9F0", Offset = "0x6F799F0", VA = "0x186F7A9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BD40", Offset = "0x6F7AD40", VA = "0x186F7BD40")]
	public static bool OEJNIEABAGP(this Task KDFIPCHFLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3676280", Offset = "0x3675280", VA = "0x183676280")]
	public static Task<T> GMNNBDAOJFP<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B2A0", Offset = "0x6F7A2A0", VA = "0x186F7B2A0")]
	public static Task MFLPPNJKAAK(this Task KDFIPCHFLGF, CancellationToken NANMDIJGGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3678C70", Offset = "0x3677C70", VA = "0x183678C70")]
	public static Task<TResult> MFLPPNJKAAK<TResult>(this Task<TResult> KDFIPCHFLGF, CancellationToken NANMDIJGGLP) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3679BE0", Offset = "0x3678BE0", VA = "0x183679BE0")]
	public static TaskCompletionSource<TResult> MFLPPNJKAAK<TResult>(this TaskCompletionSource<TResult> MEEPBDOOLIJ, CancellationToken NANMDIJGGLP) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6F7ABE0", Offset = "0x6F79BE0", VA = "0x186F7ABE0")]
	public static IDisposable? JCEHJPENGOE(CancellationToken BIAICCOHEKH, CancellationToken OPEDIPAPIHI, [Out] CancellationToken HPMPEHADPJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A740", Offset = "0x6F79740", VA = "0x186F7A740")]
	[AsyncStateMachine(typeof(INAOODNMDHD))]
	public static void HDNGKGOOPIK(this Task JJJGJKKAJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AA60", Offset = "0x6F79A60", VA = "0x186F7AA60")]
	[AsyncStateMachine(typeof(BHJDDBEAENM))]
	public static void IAIJMGLIJMO(this Task JJJGJKKAJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3676400", Offset = "0x3675400", VA = "0x183676400")]
	[AsyncStateMachine(typeof(JGMEHHJCGFG<>))]
	public static Task LAIAMJONDAC<TException>(this Task JJJGJKKAJDC) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x367A660", Offset = "0x3679660", VA = "0x18367A660")]
	[AsyncStateMachine(typeof(JDBFCEFDHAK<>))]
	public static Task<T> NBLMIKIEEOJ<T>(this Task<T> GFJPFDOHONG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B4F0", Offset = "0x6F7A4F0", VA = "0x186F7B4F0")]
	[AsyncStateMachine(typeof(CKDDFDOPKDN))]
	public static Task<TaskStatus> MHKKACNPMFP(this Task GFJPFDOHONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3675EF0", Offset = "0x3674EF0", VA = "0x183675EF0")]
	public static (Task<T?>?, Action<T?>?) CDHOHNAPNCM<T>([Optional] CancellationToken CLIKNEKJHEI)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3676170", Offset = "0x3675170", VA = "0x183676170")]
	[AsyncStateMachine(typeof(KKCEECDFAPE<, >))]
	public static Task<List<TResult>> CINPNAJGEJI<TResult, TInput>(this Task<List<TInput>> KDFIPCHFLGF, HEGFMAFMIOP<TInput, TResult> NCPMGJDOJLD) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A230", Offset = "0x6F79230", VA = "0x186F7A230")]
	[AsyncStateMachine(typeof(PCPPHMKKBLG))]
	public static Task FABMMCGGPOO(Task JJJGJKKAJDC, CancellationToken OJBNPAMIAFA, Func<CancellationToken, Task> MCIJPHEHGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6F79ED0", Offset = "0x6F78ED0", VA = "0x186F79ED0")]
	[AsyncStateMachine(typeof(CIMIJOJJFIF))]
	public static Task BOPLLOCADBA(Func<CancellationToken, Task> FONDONNFFHP, TimeSpan AMBGDNGJBFG, [Optional] CancellationToken OJBNPAMIAFA, [Optional] Action<OperationCanceledException>? MLGOGNOJICK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3675C50", Offset = "0x3674C50", VA = "0x183675C50")]
	[AsyncStateMachine(typeof(NPGJEGHMLMN<>))]
	public static Task<T> BOPLLOCADBA<T>(Func<CancellationToken, Task<T>> FONDONNFFHP, TimeSpan AMBGDNGJBFG, [Optional] CancellationToken OJBNPAMIAFA, [Optional] Func<OperationCanceledException, T>? MLGOGNOJICK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B720", Offset = "0x6F7A720", VA = "0x186F7B720")]
	public static Task NECCIDDLKDE(params Task[] BFGMDCJDMOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B770", Offset = "0x6F7A770", VA = "0x186F7B770")]
	public static Task NECCIDDLKDE(IEnumerable<Task> BFGMDCJDMOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x36765C0", Offset = "0x36755C0", VA = "0x1836765C0")]
	[AsyncStateMachine(typeof(ACKADPPJGAI<>))]
	public static Task<IEnumerable<Task<T>>> LLDNEKFPPFM<T>(IEnumerable<Task<T>> BFGMDCJDMOG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3675990", Offset = "0x3674990", VA = "0x183675990")]
	[AsyncStateMachine(typeof(BGLCMCAFABD<, , , >))]
	public static Task<(T1, T2, T3, T4)> BMPPGCCHPCI<T1, T2, T3, T4>(Task<T1> HAIFBFALNEG, Task<T2> IDJIBLCCOEC, Task<T3> JPCJNIKNLDG, Task<T4> PBFLJMPMMAA) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A7F0", Offset = "0x6F797F0", VA = "0x186F7A7F0")]
	[AsyncStateMachine(typeof(BHAMKKDFDOF))]
	public static Task HHPDOLGBLJC(Func<bool> PAHLJNPBBFN, [Optional] CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A8E0", Offset = "0x6F798E0", VA = "0x186F7A8E0")]
	[AsyncStateMachine(typeof(CJHFBACPIFC))]
	public static Task HHPDOLGBLJC(Func<bool> PAHLJNPBBFN, TimeSpan FBMPBKCOOJE, [Optional] CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B170", Offset = "0x6F7A170", VA = "0x186F7B170")]
	[AsyncStateMachine(typeof(EBIKHAFIDHA))]
	public static Task KFEOANCEBKD(Func<bool> PAHLJNPBBFN, TimeSpan AMBGDNGJBFG, [Optional] CancellationToken CLIKNEKJHEI, [Optional] Action<OperationCanceledException>? MLGOGNOJICK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B030", Offset = "0x6F7A030", VA = "0x186F7B030")]
	[AsyncStateMachine(typeof(MEHMNEFMKJJ))]
	public static Task KFEOANCEBKD(Func<bool> PAHLJNPBBFN, TimeSpan AMBGDNGJBFG, TimeSpan FBMPBKCOOJE, [Optional] CancellationToken CLIKNEKJHEI, [Optional] Action<OperationCanceledException>? MLGOGNOJICK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F79DE0", Offset = "0x6F78DE0", VA = "0x186F79DE0")]
	[AsyncStateMachine(typeof(DKCMHMEJCKM))]
	public static Task BNOIONIIGPA(Func<bool> PAHLJNPBBFN, [Optional] CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F79CD0", Offset = "0x6F78CD0", VA = "0x186F79CD0")]
	[AsyncStateMachine(typeof(NIAOHMCGIAD))]
	public static Task BNOIONIIGPA(Func<bool> PAHLJNPBBFN, TimeSpan FBMPBKCOOJE, [Optional] CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AD70", Offset = "0x6F79D70", VA = "0x186F7AD70")]
	[AsyncStateMachine(typeof(GEDMHDCDLLB))]
	public static Task JDOMMCMBELD(Func<bool> PAHLJNPBBFN, TimeSpan AMBGDNGJBFG, [Optional] CancellationToken CLIKNEKJHEI, [Optional] Action<OperationCanceledException>? MLGOGNOJICK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AEA0", Offset = "0x6F79EA0", VA = "0x186F7AEA0")]
	[AsyncStateMachine(typeof(HOJMIJEJCJC))]
	public static Task JDOMMCMBELD(Func<bool> PAHLJNPBBFN, TimeSpan AMBGDNGJBFG, TimeSpan FBMPBKCOOJE, [Optional] CancellationToken CLIKNEKJHEI, [Optional] Action<OperationCanceledException>? MLGOGNOJICK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B5E0", Offset = "0x6F7A5E0", VA = "0x186F7B5E0")]
	[AsyncStateMachine(typeof(GNFFMHDPNLC))]
	[Obsolete]
	public static Task MLNHOOMJFFA(this Task KDFIPCHFLGF, Action OENFFFKLKGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x367A570", Offset = "0x3679570", VA = "0x18367A570")]
	[Obsolete]
	[AsyncStateMachine(typeof(MDFKPKAHOMC<>))]
	public static Task MLNHOOMJFFA<T>(this Task<T> KDFIPCHFLGF, Action<T> OENFFFKLKGK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A000", Offset = "0x6F79000", VA = "0x186F7A000")]
	private static void CNJJMHPFGIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A3E0", Offset = "0x6F793E0", VA = "0x186F7A3E0")]
	public static bool HAFLOEJCDAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A0B0", Offset = "0x6F790B0", VA = "0x186F7A0B0")]
	private static void ENEPJLCMEPC(SynchronizationContext BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BC30", Offset = "0x6F7AC30", VA = "0x186F7BC30")]
	private static void ODPIGCCLLBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AB10", Offset = "0x6F79B10", VA = "0x186F7AB10")]
	public static void IPABCKMNCLO([Optional] string? ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A360", Offset = "0x6F79360", VA = "0x186F7A360")]
	public static void GGONCDLFPKL([Optional] string? ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B6D0", Offset = "0x6F7A6D0", VA = "0x186F7B6D0")]
	public static NDGGCMODOCL MOPELMPDNOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F7AFE0", Offset = "0x6F79FE0", VA = "0x186F7AFE0")]
	public static NDGGCMODOCL KBHKIPOCJMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BD70", Offset = "0x6F7AD70", VA = "0x186F7BD70")]
	[AsyncStateMachine(typeof(KKFBIDFGCIK))]
	public static Task PDHFJOLGCOH(Func<Task> LILCNNNEFGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class PGJOKJDJLNC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
	public PGJOKJDJLNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class OJPFLJJMMME : AFMLPIBKEFM
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static readonly AFMLPIBKEFM LONLOOPDCMJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTime BECLJBENDLM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6F84860", Offset = "0x6F83860", VA = "0x186F84860", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DateTimeOffset GIFKIOCNHMM
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6F84800", Offset = "0x6F83800", VA = "0x186F84800", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public OJPFLJJMMME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface AFMLPIBKEFM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTime BECLJBENDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DateTimeOffset GIFKIOCNHMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class LOCDJKABFOO
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long MGGKIGHMEIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6F83830", Offset = "0x6F82830", VA = "0x186F83830")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static long MILEJGGMHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6F83550", Offset = "0x6F82550", VA = "0x186F83550")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double AFOIABEDPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6F83750", Offset = "0x6F82750", VA = "0x186F83750")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double HBHDAFGAFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6F835A0", Offset = "0x6F825A0", VA = "0x186F835A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double LOPOMCONJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6F834F0", Offset = "0x6F824F0", VA = "0x186F834F0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static double FMJBGILJBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6F83440", Offset = "0x6F82440", VA = "0x186F83440")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6F835F0", Offset = "0x6F825F0", VA = "0x186F835F0")]
	public static double IJBOMDOPNJB(long DENKCNNHHEN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6F83320", Offset = "0x6F82320", VA = "0x186F83320")]
	public static double BPCBBMGBNNG(long DENKCNNHHEN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6F833B0", Offset = "0x6F823B0", VA = "0x186F833B0")]
	public static double CHADPBKCHCF(double HKNPFBNNHCF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6F837A0", Offset = "0x6F827A0", VA = "0x186F837A0")]
	public static long KNFOGDBPALL(long OPFDDHFIGGD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6F83540", Offset = "0x6F82540", VA = "0x186F83540")]
	public static long GFMIMNJHLMH(long LIFEACDKAPL, long NGAJMFKBBGL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6F83680", Offset = "0x6F82680", VA = "0x186F83680")]
	public static double INBABPLJFKO(long LIFEACDKAPL, long NGAJMFKBBGL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6F83490", Offset = "0x6F82490", VA = "0x186F83490")]
	public static double ELNBMBGLIDA(long LIFEACDKAPL, long NGAJMFKBBGL)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class LMPKKJPILJN : LCLGPNHKENP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static readonly TimeSpan NNGDGLFGFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly System.Timers.Timer FCPMHEOCJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private TimeSpan AMBGDNGJBFG;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public TimeSpan OCBBKGHLDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6F82C40", Offset = "0x6F81C40", VA = "0x186F82C40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Action? HBLILMACNNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BD0", Offset = "0x8B8BD0", VA = "0x1808B9BD0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6F832C0", Offset = "0x6F822C0", VA = "0x186F832C0")]
	[Preserve]
	public LMPKKJPILJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6F83070", Offset = "0x6F82070", VA = "0x186F83070")]
	public LMPKKJPILJN(TimeSpan AMBGDNGJBFG, [Optional] Action? IKKKKPPFBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6F82DD0", Offset = "0x6F81DD0", VA = "0x186F82DD0", Slot = "7")]
	public void DMGNCFFGIOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6F82F00", Offset = "0x6F81F00", VA = "0x186F82F00", Slot = "8")]
	public void HMLGAEAHBLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6F82DA0", Offset = "0x6F81DA0", VA = "0x186F82DA0", Slot = "9")]
	public void DLOEAOFKNPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xCFE210", Offset = "0xCFD210", VA = "0x180CFE210")]
	private void GDODCEKOPFC(object BEELICCCBAC, ElapsedEventArgs FDPADHEIFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6F82F70", Offset = "0x6F81F70", VA = "0x186F82F70")]
	private static void JKAOBNLFHKK(TimeSpan EIDFGINPKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6F82E60", Offset = "0x6F81E60", VA = "0x186F82E60", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class GKFAPCOLABH : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string? BECHEKENDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly string ICEJKNPCJKF;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0xAFB3E0", Offset = "0xAFA3E0", VA = "0x180AFB3E0")]
	public GKFAPCOLABH(string GOFABEAKLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x44BD8D0", Offset = "0x44BC8D0", VA = "0x1844BD8D0")]
	public GKFAPCOLABH(string DDOEMKPCPHL, string GOFABEAKLNJ)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct ILLJMNHEIKJ : IEquatable<ILLJMNHEIKJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint MPGMGBONLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public int NPMDKOCKGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public float INFKONIBAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public ushort AMKPPOGDAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public ushort KKFPBOOIEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public short DIIONOGHDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public short GCHDBPFAFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public char GKLJDDJDOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public char ACFIBAOGEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte PHGMEJKIHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public byte OBEGJJKPOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public byte DBOKHAPFJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public byte AKFDOGPCIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool LHNEAOBDOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool HPBAFBDDGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public bool DGKBLLMCLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public bool HGONCLICFIG;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x183EE30", Offset = "0x183DE30", VA = "0x18183EE30")]
	public static ILLJMNHEIKJ ABJKIBJGPOI(uint HACJOJPOIEF)
	{
		return default(ILLJMNHEIKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x183EE30", Offset = "0x183DE30", VA = "0x18183EE30")]
	public static ILLJMNHEIKJ PMOFDBMLCGL(int KONKMOIEIGO)
	{
		return default(ILLJMNHEIKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6F80FE0", Offset = "0x6F7FFE0", VA = "0x186F80FE0")]
	public static ILLJMNHEIKJ HMNFBGKPABE(float BMKPBJAPDIM)
	{
		return default(ILLJMNHEIKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6F80F40", Offset = "0x6F7FF40", VA = "0x186F80F40")]
	public static ILLJMNHEIKJ FJAKCKFADGD(byte GBGDBGKNAFG, byte MLKFFEICJCJ, byte LGCMOFOINJN, byte JPJPMJFGHPL)
	{
		return default(ILLJMNHEIKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6F80F40", Offset = "0x6F7FF40", VA = "0x186F80F40")]
	public static ILLJMNHEIKJ PGLCPLGBJOE(bool KHKKGIFDHBJ, bool FAFDBOGPEBD, bool OAINGEANADF, bool JKFDHLGAJIG)
	{
		return default(ILLJMNHEIKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6F80F40", Offset = "0x6F7FF40", VA = "0x186F80F40")]
	public static ILLJMNHEIKJ ECKKGONEPHK(byte KCHEANPMILN, byte ONFNPGHOJCI, byte OJGCBGFOEMA, byte AIHGIIDLFMC)
	{
		return default(ILLJMNHEIKJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x210D430", Offset = "0x210C430", VA = "0x18210D430")]
	public static bool LJMKDDBNEAO(ILLJMNHEIKJ LOPBCKBMJBH, ILLJMNHEIKJ BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0xDEA120", Offset = "0xDE9120", VA = "0x180DEA120", Slot = "4")]
	public bool Equals(ILLJMNHEIKJ DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6F80F60", Offset = "0x6F7FF60", VA = "0x186F80F60", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0xE92570", Offset = "0xE91570", VA = "0x180E92570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6F80FF0", Offset = "0x6F7FFF0", VA = "0x186F80FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct FBBJPBEIIME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public ulong NLECHEENIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public long HCIILGGFMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public double FJJLNHEEBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint JNCAGCMCPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint LAHABPCGCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public int AAEJMNCNAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int ALJMLCOHMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float IEEMONBHEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float PKBNNPCDBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort AMKPPOGDAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public ushort KKFPBOOIEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public ushort GOBNNPNGDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public ushort OOFJLBBBKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short DIIONOGHDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public short GCHDBPFAFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public short DMNDDMAJCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public short MHKMADCMIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char GKLJDDJDOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public char ACFIBAOGEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public char JILKCIMDLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public char DMANPLAKCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte PHGMEJKIHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte OBEGJJKPOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte DBOKHAPFJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte AKFDOGPCIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte FCGJGIOCKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte MAECHEGDMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public byte JFPJDCJNGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public byte BGGCOEBGFPF;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
	public static FBBJPBEIIME EJLELCHFLID(long OKOBDJGAANE)
	{
		return default(FBBJPBEIIME);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6F80210", Offset = "0x6F7F210", VA = "0x186F80210")]
	public static FBBJPBEIIME EJLELCHFLID(byte GBGDBGKNAFG, byte MLKFFEICJCJ, byte LGCMOFOINJN, byte JPJPMJFGHPL, byte GMCEMKPHBJL, byte EEDPHMOCJJL, byte KBEPHCEIFGA, byte MFGAALKMGCG)
	{
		return default(FBBJPBEIIME);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct MPIEIPNFLNK : IEquatable<MPIEIPNFLNK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public byte HCNLJIDEMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool LLFNIEFEIPM;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x28DA360", Offset = "0x28D9360", VA = "0x1828DA360")]
	public static MPIEIPNFLNK FJAKCKFADGD(byte FMIDNBNJBHE)
	{
		return default(MPIEIPNFLNK);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x28DA360", Offset = "0x28D9360", VA = "0x1828DA360")]
	public static MPIEIPNFLNK PGLCPLGBJOE(bool FAAGJJIGMJJ)
	{
		return default(MPIEIPNFLNK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6F83F80", Offset = "0x6F82F80", VA = "0x186F83F80")]
	public static bool LJMKDDBNEAO(MPIEIPNFLNK LOPBCKBMJBH, MPIEIPNFLNK BMJGCJANGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x60EE770", Offset = "0x60ED770", VA = "0x1860EE770", Slot = "4")]
	public bool Equals(MPIEIPNFLNK DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6F83EE0", Offset = "0x6F82EE0", VA = "0x186F83EE0", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6F83F70", Offset = "0x6F82F70", VA = "0x186F83F70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6F83F90", Offset = "0x6F82F90", VA = "0x186F83F90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class DKADCKEOBDC<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public readonly T PMEMBLALIAM;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9690", Offset = "0x5DB8690", VA = "0x185DB9690")]
	public DKADCKEOBDC(T LGNINFLDBPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class NFHOIHEFDKA
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x311ED90", Offset = "0x311DD90", VA = "0x18311ED90")]
	public static IEnumerable<T> PJDKIIGBOPG<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
	public static T[] CFJKEOENJLJ<T>(params T[] ONNOKHFIGBI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
	public static IEnumerable<T> FOJBDDBMINL<T>(params T[] ONNOKHFIGBI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2D6B850", Offset = "0x2D6A850", VA = "0x182D6B850")]
	public static HashSet<T> LGHFGJKIKBO<T>(params T[] ONNOKHFIGBI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x311ECA0", Offset = "0x311DCA0", VA = "0x18311ECA0")]
	public static KeyValuePair<TKey, TValue> IAKJIJNKCND<TKey, TValue>([In] TKey MLAECOMLIEC, [In] TValue BJDKOHEGDOK) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2D6B850", Offset = "0x2D6A850", VA = "0x182D6B850")]
	public static List<T> FLJGNPGDHGM<T>(IEnumerable<T> LCHNOCELOBI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[AttributeUsage(AttributeTargets.All)]
public sealed class JBAHBGCJJND : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public readonly string FCHAIDEHPGP;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8E0550", Offset = "0x8DF550", VA = "0x1808E0550")]
	public JBAHBGCJJND(string FAEAEBGGAII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate object GBBCHECOLNH<T>([In] T NABJMDALPIF);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate object FBNMAKEJBBA<T>(T NABJMDALPIF);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[LFNOHIAAPPN]
public delegate string OFPOMANFHFB(string DIENLBCMIGK, string? NHMAPAIFDPB, bool FIJMKMIBEPA);
[Cpp2IlInjected.Token(Token = "0x200005C")]
[LFNOHIAAPPN]
public delegate void AEJEAPENEOI(string ABHPFCOODAJ);
[Cpp2IlInjected.Token(Token = "0x200005D")]
[LFNOHIAAPPN]
public delegate void BJAHEALLALN(Exception BKFPPGLJAII);
[Cpp2IlInjected.Token(Token = "0x200005E")]
public delegate object IAAOPEAIMCH();
[Cpp2IlInjected.Token(Token = "0x200005F")]
[LFNOHIAAPPN]
public delegate bool FGGNBLLCONI();
[Cpp2IlInjected.Token(Token = "0x2000060")]
[LFNOHIAAPPN]
public delegate string GHMGODINDBH(object IFPBFCLBBDP);
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.Enum)]
public class EELJOGCFLMJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
	public EELJOGCFLMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class DGPMIJPMOKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct CPLIMBJNDJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E2A0", Offset = "0x6F7D2A0", VA = "0x186F7E2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6F7EB80", Offset = "0x6F7DB80", VA = "0x186F7EB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly TimerCallback AAFALJONEMD;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly Action<object?> FPPCHKPAKND;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6F7EBF0", Offset = "0x6F7DBF0", VA = "0x186F7EBF0")]
	public static Task<bool> BBDFDCCLIFP(int GBCHJGGBMCM, [Optional] CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7EF80", Offset = "0x6F7DF80", VA = "0x186F7EF80")]
	[AsyncStateMachine(typeof(CPLIMBJNDJG))]
	private static Task<bool> KFLBMAOHLKC(int GBCHJGGBMCM, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F0B0", Offset = "0x6F7E0B0", VA = "0x186F7F0B0")]
	private static void NNECKLAKAMK(object? LNHGKEAKACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6F7EEF0", Offset = "0x6F7DEF0", VA = "0x186F7EEF0")]
	private static void BLFAEAGAIIH(object? LNHGKEAKACI)
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
