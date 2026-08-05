using System;
using System.Collections;
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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5CF91E0", Offset = "0x5CF85E0", VA = "0x185CF91E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x787CA0", Offset = "0x7870A0", VA = "0x180787CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x787CE0", Offset = "0x7870E0", VA = "0x180787CE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class BCIFHGDGKAM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6510", Offset = "0x5CF5910", VA = "0x185CF6510")]
	public BCIFHGDGKAM(bool LCMIDMDFBJP, string MHFEHNAAMCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BKPADPDMFJG<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> GAANNAGEMFL(CancellationToken ELGJALILGJE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct JDLIHMDNOCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public BKPADPDMFJG<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public GAANNAGEMFL taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x38357B0", Offset = "0x3834BB0", VA = "0x1838357B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x38367F0", Offset = "0x3835BF0", VA = "0x1838367F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource HGNKABNPMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? EPIGHANEHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? BHKLCGEDAOH;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x484E020", Offset = "0x484D420", VA = "0x18484E020")]
	[AsyncStateMachine(typeof(BKPADPDMFJG<>.JDLIHMDNOCL))]
	public Task<TResult> EBHDNDEDEFD(GAANNAGEMFL GNIMCKFIMFK, [Optional] CancellationToken ELGJALILGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x484DFB0", Offset = "0x484D3B0", VA = "0x18484DFB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x484E160", Offset = "0x484D560", VA = "0x18484E160")]
	public BKPADPDMFJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class EBMKJKLKNGO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> AOAEOOBFFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T DFNAILAPHHN;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x30325D0", Offset = "0x30319D0", VA = "0x1830325D0")]
	public EBMKJKLKNGO([In] T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3031DB0", Offset = "0x30311B0", VA = "0x183031DB0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3032020", Offset = "0x3031420", VA = "0x183032020", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3032320", Offset = "0x3031720", VA = "0x183032320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class ABFFLGHLDOP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
	public ABFFLGHLDOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class CKNHLHGFDOE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
	public CKNHLHGFDOE(string KOJMBPPHJEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Parameter)]
public class NPKHOHDIHCD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
	public NPKHOHDIHCD(string KOJMBPPHJEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class KPHJDLBAPGP
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x24439D0", Offset = "0x2442DD0", VA = "0x1824439D0")]
	public static IFJBIMNJFBM CLMMIDLEHOL<T>()
	{
		return default(IFJBIMNJFBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x24437A0", Offset = "0x2442BA0", VA = "0x1824437A0")]
	public static IFJBIMNJFBM AGFIMKHEPFL<T>([CallerMemberName] string LFAIHEECJFK = "") where T : notnull
	{
		return default(IFJBIMNJFBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2443A50", Offset = "0x2442E50", VA = "0x182443A50")]
	public static IFJBIMNJFBM CLMMIDLEHOL<T>(this T IAIELCEKOPH) where T : notnull
	{
		return default(IFJBIMNJFBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2443AD0", Offset = "0x2442ED0", VA = "0x182443AD0")]
	public static IFJBIMNJFBM ICOJAMLNNGM<T>(this T IAIELCEKOPH, [CallerMemberName] string LFAIHEECJFK = "") where T : notnull
	{
		return default(IFJBIMNJFBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2443830", Offset = "0x2442C30", VA = "0x182443830")]
	public static IFJBIMNJFBM AGFIMKHEPFL<T>(this T LDMHFMNLDHG, [CallerMemberName] string LFAIHEECJFK = "") where T : notnull
	{
		return default(IFJBIMNJFBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CF87C0", Offset = "0x5CF7BC0", VA = "0x185CF87C0")]
	public static IFJBIMNJFBM AGFIMKHEPFL(string INNCMJDOHJJ, [CallerMemberName] string LFAIHEECJFK = "")
	{
		return default(IFJBIMNJFBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8840", Offset = "0x5CF7C40", VA = "0x185CF8840")]
	public static string GOGAGPNNGEL(this object LDMHFMNLDHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ABFFLGHLDOP]
public delegate long KHNGIFAJIMO();
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PGLMBGAFLPN
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static NOMONBCFOIH OKNHMFMPFPC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static NOMONBCFOIH JBCFGBOLDNK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9B10", Offset = "0x5CF8F10", VA = "0x185CF9B10")]
		get
		{
			return default(NOMONBCFOIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static GOAJHHEFIJP PDFMHJLIOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9D50", Offset = "0x5CF9150", VA = "0x185CF9D50")]
		get
		{
			return default(GOAJHHEFIJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static OHCNHGOOJKE ALAOJHFKILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5CF98A0", Offset = "0x5CF8CA0", VA = "0x185CF98A0")]
		get
		{
			return default(OHCNHGOOJKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9BD0", Offset = "0x5CF8FD0", VA = "0x185CF9BD0")]
	public static void MGKCNMHEJLG([In] NOMONBCFOIH NMHCOOBHMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9DA0", Offset = "0x5CF91A0", VA = "0x185CF9DA0")]
	public static void PECDFFDPILO(string NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5CF98F0", Offset = "0x5CF8CF0", VA = "0x185CF98F0")]
	public static void ENFDFEEIPGI(string NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2509C90", Offset = "0x2509090", VA = "0x182509C90")]
	public static void ENFDFEEIPGI<T>(T GCCIFMALMDL, NADNPIEAKMJ<T> NJKPBIBMIJE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9800", Offset = "0x5CF8C00", VA = "0x185CF9800")]
	public static void BEPDGOPOJJC(Exception APLJIBADEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CF99C0", Offset = "0x5CF8DC0", VA = "0x185CF99C0")]
	public static string GOGAGPNNGEL(object BAFDGKKJJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9B60", Offset = "0x5CF8F60", VA = "0x185CF9B60")]
	public static long LJKEJOPFMKL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9760", Offset = "0x5CF8B60", VA = "0x185CF9760")]
	public static bool AADMFFMDAHK(bool JBOCKCGBGFG, string NJKPBIBMIJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9A40", Offset = "0x5CF8E40", VA = "0x185CF9A40")]
	public static double JGHFICACNCA()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct NOMONBCFOIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly GOAJHHEFIJP PDFMHJLIOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly OHCNHGOOJKE ALAOJHFKILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly GEBMCGHPECP FGCMBEPFKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly KHNGIFAJIMO LLNHJBILEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly DGGKLPBLGLN HLBPNAMCMFO;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly GEBMCGHPECP HIAOADOFBOH;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly KHNGIFAJIMO OABDMLDIHMJ;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly DGGKLPBLGLN DODLBFMGNFL;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly NOMONBCFOIH OAIDPCAHLCF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool DDHCPHLKOFL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5CF89E0", Offset = "0x5CF7DE0", VA = "0x185CF89E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9140", Offset = "0x5CF8540", VA = "0x185CF9140")]
	public NOMONBCFOIH([In] GOAJHHEFIJP KADIBPOEHDD, [In] OHCNHGOOJKE JLLNCAJAGEN, GEBMCGHPECP KNKODHNJCAH, KHNGIFAJIMO KIFFHKKNMIH, DGGKLPBLGLN KJIBHJLBHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8B40", Offset = "0x5CF7F40", VA = "0x185CF8B40")]
	private static string OGBEFKDBFNM(object BAFDGKKJJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0")]
	private static long ODICBPCLFDE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0")]
	private static string BLCGFCOBHFD(string JPCPLJECFKH, string? FNMHNJPNNBG, bool HDCFPHKCEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5CF88E0", Offset = "0x5CF7CE0", VA = "0x185CF88E0")]
	private static NOMONBCFOIH EGOLIEKAEEO()
	{
		return default(NOMONBCFOIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EGCLJEBFBCM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AAEBAKABHLH([In] T LJIBJAOOGGF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void MDONLDLDNCE<T>([In] T GCCIFMALMDL);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct OAGJGNBCDPH<T> : IEquatable<OAGJGNBCDPH<T>>, EGCLJEBFBCM<OAGJGNBCDPH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly T DFNAILAPHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly int CBNNNKAIBOB;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1C709B0", Offset = "0x1C6FDB0", VA = "0x181C709B0")]
	public OAGJGNBCDPH([In] T EOHMJBFGDPD, int APOENOPNHBG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5720", Offset = "0x3CD4B20", VA = "0x183CD5720")]
	public static bool MEMFAJGIIAO([In] OAGJGNBCDPH<T> GFPOLPOKADD, [In] OAGJGNBCDPH<T> PBBDJDKAOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x347EE80", Offset = "0x347E280", VA = "0x18347EE80", Slot = "4")]
	public bool Equals(OAGJGNBCDPH<T> LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x38DF060", Offset = "0x38DE460", VA = "0x1838DF060", Slot = "0")]
	public override bool Equals(object LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4270", Offset = "0x3CD3670", VA = "0x183CD4270")]
	public bool AAEBAKABHLH([In] OAGJGNBCDPH<T> LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4A30", Offset = "0x3CD3E30", VA = "0x183CD4A30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3CD5B10", Offset = "0x3CD4F10", VA = "0x183CD5B10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4C00", Offset = "0x3CD4000", VA = "0x183CD4C00")]
	public void LHHELOIEGGD([Out] T EOHMJBFGDPD, [Out] int APOENOPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4480", Offset = "0x3CD3880", VA = "0x183CD4480")]
	public (T, int) DDKPKJICCAG()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4760", Offset = "0x3CD3B60", VA = "0x183CD4760", Slot = "5")]
	private bool GFAAIMINJKD([In] OAGJGNBCDPH<T> LJIBJAOOGGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ENMJCPLDCID
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x225E0D0", Offset = "0x225D4D0", VA = "0x18225E0D0")]
	public static OAGJGNBCDPH<T> LJCGEPFBFCG<T>([In] T EOHMJBFGDPD, int APOENOPNHBG) where T : notnull
	{
		return default(OAGJGNBCDPH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class PKNOCDBIHNL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x250D860", Offset = "0x250CC60", VA = "0x18250D860")]
	public static bool AAEBAKABHLH<T, U>([In] T LDMHFMNLDHG, [In] U BAFDGKKJJJD) where T : notnull, EGCLJEBFBCM<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public delegate TResult HADOODFJFDO<T, out TResult>([In] T GCCIFMALMDL);
[Cpp2IlInjected.Token(Token = "0x2000017")]
public delegate TResult OJBLLGJNCDN<T1, T2, out TResult>([In] T1 PHGJHCPHPND, [In] T2 MMALIOMFPPO);
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FOEGIMMGMHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	TimeSpan OPOIABNDENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Action? BCKINIOCCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DOIBKMNMIJN();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CICABNBFMBG();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PGBHPLOICIP();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct GOAJHHEFIJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly KMBONCCPALC CFFJKOIHAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly MHNCHJDPFBD MPHIILHFLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly KMBONCCPALC HCOBINEIGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly MHNCHJDPFBD EPOINIADJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly KMBONCCPALC CINBNGPBIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly MHNCHJDPFBD DFKLCKGNBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IFLJHOOCABE MFEIKPDJKCK;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly KMBONCCPALC ONKGBPFCNOB;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly MHNCHJDPFBD OOONOJKHPGE;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly KMBONCCPALC INKDKMCNMFB;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly MHNCHJDPFBD OIAICGKIJBB;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly KMBONCCPALC MEOCDJJCANN;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly MHNCHJDPFBD DDBKBLPDBAC;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly IFLJHOOCABE MJLFCKBOBLH;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly GOAJHHEFIJP OAIDPCAHLCF;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly KMBONCCPALC HOKFACFFOPF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DDHCPHLKOFL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5CF6A00", Offset = "0x5CF5E00", VA = "0x185CF6A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8686A0", Offset = "0x867AA0", VA = "0x1808686A0")]
	public GOAJHHEFIJP(KMBONCCPALC PFNNOOJKBJJ, MHNCHJDPFBD DMAPBLIMECO, KMBONCCPALC LGKDMEOKKHA, MHNCHJDPFBD MLHDOKMDGBF, KMBONCCPALC HILMDCPOIGB, MHNCHJDPFBD NPDAOPJNNNA, IFLJHOOCABE DOKEOFJNMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300")]
	private static bool EHEJBBEBKEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void ICJMKPHKJLF(string NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300")]
	private static bool ODAHOBEHPDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void EIAGMGIKDCC(string NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300")]
	private static bool DEHJDJJFAOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void EHGCJCDKEIF(string NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void FJGICLDKKKD(Exception APLJIBADEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6770", Offset = "0x5CF5B70", VA = "0x185CF6770")]
	private static GOAJHHEFIJP EGOLIEKAEEO()
	{
		return default(GOAJHHEFIJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7785F0", Offset = "0x7779F0", VA = "0x1807785F0")]
	private static bool LCPDNPGPGIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6C00", Offset = "0x5CF6000", VA = "0x185CF6C00")]
	public void PECDFFDPILO(object NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CF68B0", Offset = "0x5CF5CB0", VA = "0x185CF68B0")]
	public void ENFDFEEIPGI(object NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2043840", Offset = "0x2042C40", VA = "0x182043840")]
	public void BEPDGOPOJJC(Exception APLJIBADEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6920", Offset = "0x5CF5D20", VA = "0x185CF6920")]
	public void ENFDFEEIPGI(HMONIIHALAP NJKPBIBMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x23A1230", Offset = "0x23A0630", VA = "0x1823A1230")]
	public void ENFDFEEIPGI<T>(T GCCIFMALMDL, NADNPIEAKMJ<T> NJKPBIBMIJE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x23A12F0", Offset = "0x23A06F0", VA = "0x1823A12F0")]
	public void PECDFFDPILO<T>([In] T GCCIFMALMDL, JGPOBBANMHM<T> NJKPBIBMIJE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF66A0", Offset = "0x5CF5AA0", VA = "0x185CF66A0")]
	public bool AADMFFMDAHK(bool JBOCKCGBGFG, string NJKPBIBMIJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct IFJBIMNJFBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string DFNAILAPHHN;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7E8520", Offset = "0x7E7920", VA = "0x1807E8520")]
	public IFJBIMNJFBM(string EOHMJBFGDPD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
	public static string BNPEICKPPJA([In] IFJBIMNJFBM LDMHFMNLDHG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x12D9C20", Offset = "0x12D9020", VA = "0x1812D9C20")]
	public static IFJBIMNJFBM BNPEICKPPJA(string LJIBJAOOGGF)
	{
		return default(IFJBIMNJFBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7250", Offset = "0x5CF6650", VA = "0x185CF7250")]
	public string DEMNFLBCGHP(string HICAJHADMAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5CF72A0", Offset = "0x5CF66A0", VA = "0x185CF72A0")]
	public string MPNGNPKKJFP(object DDBHCMCIDIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct OGKMPBOGKAG : IEquatable<OGKMPBOGKAG>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7785F0", Offset = "0x7779F0", VA = "0x1807785F0", Slot = "4")]
	public bool Equals(OGKMPBOGKAG LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9260", Offset = "0x5CF8660", VA = "0x185CF9260", Slot = "0")]
	public override bool Equals(object LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CF92B0", Offset = "0x5CF86B0", VA = "0x185CF92B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CF92C0", Offset = "0x5CF86C0", VA = "0x185CF92C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[KBLMAJIKABI("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct GBADDJOKMAC<T> : IEquatable<GBADDJOKMAC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly T DFNAILAPHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool NMIJCOGHDAB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EJFGALEIPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x347F4F0", Offset = "0x347E8F0", VA = "0x18347F4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x347FC50", Offset = "0x347F050", VA = "0x18347FC50")]
	public GBADDJOKMAC([In] T EOHMJBFGDPD, bool GPJHFLDAIFB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x347F500", Offset = "0x347E900", VA = "0x18347F500")]
	public static bool MEMFAJGIIAO([In] GBADDJOKMAC<T> GFPOLPOKADD, [In] GBADDJOKMAC<T> PBBDJDKAOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x347EE80", Offset = "0x347E280", VA = "0x18347EE80", Slot = "4")]
	public bool Equals(GBADDJOKMAC<T> LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x347ED10", Offset = "0x347E110", VA = "0x18347ED10", Slot = "0")]
	public override bool Equals(object LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x347F450", Offset = "0x347E850", VA = "0x18347F450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x347FB10", Offset = "0x347EF10", VA = "0x18347FB10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class CIEPGGKINEM
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x220C5E0", Offset = "0x220B9E0", VA = "0x18220C5E0")]
	public static GBADDJOKMAC<T> GFILCPAIGKA<T>([In] T EOHMJBFGDPD) where T : notnull
	{
		return default(GBADDJOKMAC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x220C780", Offset = "0x220BB80", VA = "0x18220C780")]
	public static GBADDJOKMAC<T?> PHMOMPDMEAE<T>()
	{
		return default(GBADDJOKMAC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x220C640", Offset = "0x220BA40", VA = "0x18220C640")]
	public static bool IMCKHLIJLFE<T>([In] this GBADDJOKMAC<T> DEAMEMILELD, [Out][NotNullWhen(true)] T EOHMJBFGDPD) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct OHCNHGOOJKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly OBEPPFEPLGI EHEBFOOBGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly FJMBJBDPMLB EHIJHNNALGJ;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly OBEPPFEPLGI CJDBGJNBMGP;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly FJMBJBDPMLB JFKHJOEIJDD;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly OHCNHGOOJKE OAIDPCAHLCF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DDHCPHLKOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9380", Offset = "0x5CF8780", VA = "0x185CF9380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7EFC80", Offset = "0x7EF080", VA = "0x1807EFC80")]
	public OHCNHGOOJKE(OBEPPFEPLGI AJHMBGKLMOF, FJMBJBDPMLB BHEKOLHINFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void NHACIPJJGGM(string LFAIHEECJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void KCIMODHMAMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5CF92F0", Offset = "0x5CF86F0", VA = "0x185CF92F0")]
	private static OHCNHGOOJKE EGOLIEKAEEO()
	{
		return default(OHCNHGOOJKE);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class KGJJNBJPOFN
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate bool DLNEBACJPKP<in TInput, TResult>(TInput CEPHEIEJHPL, [Out] TResult KNLODAPAGGH);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class AILGJMNEBAG<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public AILGJMNEBAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x34A8DD0", Offset = "0x34A81D0", VA = "0x1834A8DD0")]
		internal void DBFDKEIDDDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class AJLCACJHNFG<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public AJLCACJHNFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x34A6920", Offset = "0x34A5D20", VA = "0x1834A6920")]
		internal void ECNAKMLIGPB(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct LKBPAFKGJCK<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public DLNEBACJPKP<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3980720", Offset = "0x397FB20", VA = "0x183980720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3980E10", Offset = "0x3980210", VA = "0x183980E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct IILJKHMGOKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Task selfInternal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5CF7380", Offset = "0x5CF6780", VA = "0x185CF7380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5CF7580", Offset = "0x5CF6980", VA = "0x185CF7580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8490", Offset = "0x5CF7890", VA = "0x185CF8490")]
	public static Task<TaskStatus> NLAOEKAEOEN(this Task LDMHFMNLDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x242A2D0", Offset = "0x24296D0", VA = "0x18242A2D0")]
	public static Task<T> BDPMOHJMDFD<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8580", Offset = "0x5CF7980", VA = "0x185CF8580")]
	public static Task OKEKKPNLEHA(this Task FODAKAIIBEG, CancellationToken KJAGMGIFCEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x242B960", Offset = "0x242AD60", VA = "0x18242B960")]
	public static Task<TResult> OKEKKPNLEHA<TResult>(this Task<TResult> FODAKAIIBEG, CancellationToken KJAGMGIFCEM) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x242C5B0", Offset = "0x242B9B0", VA = "0x18242C5B0")]
	public static TaskCompletionSource<TResult> OKEKKPNLEHA<TResult>(this TaskCompletionSource<TResult> OAONCJDELIC, CancellationToken KJAGMGIFCEM) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x242A420", Offset = "0x2429820", VA = "0x18242A420")]
	[AsyncStateMachine(typeof(LKBPAFKGJCK<, >))]
	public static Task<List<TResult>> NKLPEBJOJOL<TResult, TInput>(this Task<List<TInput>> FODAKAIIBEG, DLNEBACJPKP<TInput, TResult> OJLFNEFALOD) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8490", Offset = "0x5CF7890", VA = "0x185CF8490")]
	[AsyncStateMachine(typeof(IILJKHMGOKF))]
	[CompilerGenerated]
	internal static Task<TaskStatus> NNHCJDHMHGO(Task IIONIGAEEEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class LJJODHMGIKF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
	public LJJODHMGIKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class BHEBMDANBFC : KKPBNOLHOOA
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly KKPBNOLHOOA PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DateTime GIHEDHDIJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5CF65E0", Offset = "0x5CF59E0", VA = "0x185CF65E0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public BHEBMDANBFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KKPBNOLHOOA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime GIHEDHDIJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class BBALLJJLLFH
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long LHAGFGOPFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5CF5F10", Offset = "0x5CF5310", VA = "0x185CF5F10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static long DCGJFFKBNJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5CF61F0", Offset = "0x5CF55F0", VA = "0x185CF61F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static double MGIPHBNOPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5CF5E10", Offset = "0x5CF5210", VA = "0x185CF5E10")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static double OJKNHOEHBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5CF61A0", Offset = "0x5CF55A0", VA = "0x185CF61A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static double IDFFGIENGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5CF6030", Offset = "0x5CF5430", VA = "0x185CF6030")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static double AOOCHNPINJE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5CF5EC0", Offset = "0x5CF52C0", VA = "0x185CF5EC0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5CE0", Offset = "0x5CF50E0", VA = "0x185CF5CE0")]
	public static double CDAPAJBLPNG(long NADBDJGAJOK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6110", Offset = "0x5CF5510", VA = "0x185CF6110")]
	public static double OBEJJNMJILH(long NADBDJGAJOK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5D70", Offset = "0x5CF5170", VA = "0x185CF5D70")]
	public static double CIOIOJKJBEN(double PJDALLDGKNJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6080", Offset = "0x5CF5480", VA = "0x185CF6080")]
	public static long KLHONIEBNCJ(long DBEHEFMCFDE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5E00", Offset = "0x5CF5200", VA = "0x185CF5E00")]
	public static long DALHPEEOKMM(long DDIMHBBMPHF, long AAGCIBHEEIF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5F60", Offset = "0x5CF5360", VA = "0x185CF5F60")]
	public static double GMKGBPDOBOM(long DDIMHBBMPHF, long AAGCIBHEEIF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5E60", Offset = "0x5CF5260", VA = "0x185CF5E60")]
	public static double EIMJIKPDBJC(long DDIMHBBMPHF, long AAGCIBHEEIF)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class PJELKAPGBLM : FOEGIMMGMHK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly TimeSpan NAHDLGIHGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly System.Timers.Timer GJEJDECMIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private TimeSpan LBOMALIMPNP;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TimeSpan OPOIABNDENA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5CFA160", Offset = "0x5CF9560", VA = "0x185CFA160", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Action? BCKINIOCCHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x75C7A0", Offset = "0x75BBA0", VA = "0x18075C7A0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA5B0", Offset = "0x5CF99B0", VA = "0x185CFA5B0")]
	[Preserve]
	public PJELKAPGBLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA360", Offset = "0x5CF9760", VA = "0x185CFA360")]
	public PJELKAPGBLM(TimeSpan LBOMALIMPNP, [Optional] Action? CKCPABAMHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA030", Offset = "0x5CF9430", VA = "0x185CFA030", Slot = "7")]
	public void DOIBKMNMIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9F20", Offset = "0x5CF9320", VA = "0x185CF9F20", Slot = "8")]
	public void CICABNBFMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA2C0", Offset = "0x5CF96C0", VA = "0x185CFA2C0", Slot = "9")]
	public void PGBHPLOICIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xAD6560", Offset = "0xAD5960", VA = "0x180AD6560")]
	private void IIKIHOAJGDN(object IAIELCEKOPH, ElapsedEventArgs AOHPPDHEMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9F90", Offset = "0x5CF9390", VA = "0x185CF9F90")]
	private static void CKGNAEKJEII(TimeSpan FHEAEFLMJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA0C0", Offset = "0x5CF94C0", VA = "0x185CFA0C0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class KBLMAJIKABI : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly string JDEAINDAOAC;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x787CA0", Offset = "0x7870A0", VA = "0x180787CA0")]
	public KBLMAJIKABI(string MCLCCINENBE)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct JOPGHOBADAK : IEquatable<JOPGHOBADAK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint JKBGGBKIBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public int ILKPPCCANFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float FHDHFNODHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public ushort KDMBEKOEICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public ushort OMGJIDEJGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public short GHODGDJNFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public short MAHHELOMJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public char LOFCHMMBNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public char KOEIAFPPOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public byte PCHBJAJBKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public byte CHICNOCGEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public byte PMIAELFJDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public byte IBAKJFHFKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool BBJDKGDOOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool OJCFIGPGEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool EGABFGOJANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public bool CGLHFCMEIIJ;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xBC9740", Offset = "0xBC8B40", VA = "0x180BC9740")]
	public static JOPGHOBADAK IHDFIKFGEOO(uint BNDMANCGPJC)
	{
		return default(JOPGHOBADAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xBC9740", Offset = "0xBC8B40", VA = "0x180BC9740")]
	public static JOPGHOBADAK EIAHEMJMDNI(int PJBNIFIFABF)
	{
		return default(JOPGHOBADAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7670", Offset = "0x5CF6A70", VA = "0x185CF7670")]
	public static JOPGHOBADAK GFCLEHDEHBP(float JJABCJJCHJL)
	{
		return default(JOPGHOBADAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7680", Offset = "0x5CF6A80", VA = "0x185CF7680")]
	public static JOPGHOBADAK IPNNFEHAMFG(byte HLBFDAJEBMP, byte LMCPKPIAIIP, byte HLFEKNHKAKP, byte BCLBJCFHKKP)
	{
		return default(JOPGHOBADAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7680", Offset = "0x5CF6A80", VA = "0x185CF7680")]
	public static JOPGHOBADAK JAKAHKDLIJD(bool HGDAHFFMHDC, bool JABIOOCEMAA, bool ABBMGOGBNAJ, bool PPHNACOKIJL)
	{
		return default(JOPGHOBADAK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1642C40", Offset = "0x1642040", VA = "0x181642C40")]
	public static bool MEMFAJGIIAO(JOPGHOBADAK IBOMHLKOLJB, JOPGHOBADAK FFDHLLBEMJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1642C20", Offset = "0x1642020", VA = "0x181642C20", Slot = "4")]
	public bool Equals(JOPGHOBADAK LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5CF75F0", Offset = "0x5CF69F0", VA = "0x185CF75F0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E8640", Offset = "0x7E7A40", VA = "0x1807E8640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5CF76A0", Offset = "0x5CF6AA0", VA = "0x185CF76A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct PMCMDOKEMID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public ulong MMEKNMJGNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public long DHONKNMJGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public double CBDPOLCEEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public uint CCFOFLJEAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public uint NLNCKONEPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int KMLJFBKBAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int AMGMIJLOKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float OJAAHMNIALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public float BIMCEJGEFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public ushort KDMBEKOEICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public ushort OMGJIDEJGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public ushort MCOKIBFBEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public ushort EBJOECIEHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public short GHODGDJNFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public short MAHHELOMJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public short FKAKHHAHACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public short IDGFPKLMKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public char LOFCHMMBNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public char KOEIAFPPOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public char MCLOJBIFCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public char LDJKDCNMIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public byte PCHBJAJBKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public byte CHICNOCGEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte PMIAELFJDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public byte IBAKJFHFKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public byte ONAGLJFKMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public byte GMAOPJBJAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte DABPEIFKJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public byte ANJDDDAEIHO;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA620", Offset = "0x5CF9A20", VA = "0x185CFA620")]
	public static PMCMDOKEMID LJCGEPFBFCG(byte HLBFDAJEBMP, byte LMCPKPIAIIP, byte HLFEKNHKAKP, byte BCLBJCFHKKP, byte LADGDMANHLN, byte BKENCKIEDMF, byte PIEAAJKECAP, byte CPGJLGGILDB)
	{
		return default(PMCMDOKEMID);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class IOEOFEDKODE
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x23DA1F0", Offset = "0x23D95F0", VA = "0x1823DA1F0")]
	public static IEnumerable<T> MNLNBHCMECF<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0")]
	public static T[] JKIGBEGLAEK<T>(params T[] PDJKNCLAJJB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0")]
	public static IEnumerable<T> IEAPDFLDKGF<T>(params T[] PDJKNCLAJJB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2259B90", Offset = "0x2258F90", VA = "0x182259B90")]
	public static HashSet<T> AFJDGFPKIAE<T>(params T[] PDJKNCLAJJB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x23DA210", Offset = "0x23D9610", VA = "0x1823DA210")]
	public static KeyValuePair<TKey, TValue> PFKCJIPHIJG<TKey, TValue>([In] TKey DGCJCBHPPBD, [In] TValue EOHMJBFGDPD) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2259B90", Offset = "0x2258F90", VA = "0x182259B90")]
	public static List<T> BLLKEMLPBPG<T>(IEnumerable<T> PBOJKPKPEEN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[AttributeUsage(AttributeTargets.All)]
public sealed class FDKBFKNGCNE : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly string PLBDLFMBHAK;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x787CA0", Offset = "0x7870A0", VA = "0x180787CA0")]
	public FDKBFKNGCNE(string MMKIEIGFJGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class LHJFPLKIMMN
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class JKCICAOACJG<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly ISet<T> PFONNHJIIHO;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int EJNDKIEMIHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7785F0", Offset = "0x7779F0", VA = "0x1807785F0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x384BCF0", Offset = "0x384B0F0", VA = "0x18384BCF0", Slot = "4")]
		public bool Add(T JJEIFGHOKOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "6")]
		public void IntersectWith(IEnumerable<T> LJIBJAOOGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x384BF80", Offset = "0x384B380", VA = "0x18384BF80", Slot = "5")]
		public void UnionWith(IEnumerable<T> LJIBJAOOGGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x384BE90", Offset = "0x384B290", VA = "0x18384BE90", Slot = "9")]
		void ICollection<T>.Add(T JJEIFGHOKOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "11")]
		public bool Contains(T JJEIFGHOKOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "12")]
		public void CopyTo(T[] FFAHMFOPGLA, int FJCKEJMMOON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
		public bool Remove(T JJEIFGHOKOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x384BDB0", Offset = "0x384B1B0", VA = "0x18384BDB0", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x33FF980", Offset = "0x33FED80", VA = "0x1833FF980", Slot = "15")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public JKCICAOACJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7C8520", Offset = "0x7C7920", VA = "0x1807C8520")]
	public static ISet<T> NACFJELICIC<T>() where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ABFFLGHLDOP]
public delegate void OBEPPFEPLGI(string LFAIHEECJFK);
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ABFFLGHLDOP]
public delegate void FJMBJBDPMLB();
[Cpp2IlInjected.Token(Token = "0x2000036")]
public delegate object JGPOBBANMHM<T>([In] T CAAIHKBHIAA);
[Cpp2IlInjected.Token(Token = "0x2000037")]
public delegate object NADNPIEAKMJ<T>(T CAAIHKBHIAA);
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ABFFLGHLDOP]
public delegate string DGGKLPBLGLN(string JPCPLJECFKH, string? FNMHNJPNNBG, bool HDCFPHKCEME);
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ABFFLGHLDOP]
public delegate void MHNCHJDPFBD(string NJKPBIBMIJE);
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ABFFLGHLDOP]
public delegate void IFLJHOOCABE(Exception APLJIBADEAL);
[Cpp2IlInjected.Token(Token = "0x200003B")]
public delegate object HMONIIHALAP();
[Cpp2IlInjected.Token(Token = "0x200003C")]
[ABFFLGHLDOP]
public delegate bool KMBONCCPALC();
[Cpp2IlInjected.Token(Token = "0x200003D")]
[ABFFLGHLDOP]
public delegate string GEBMCGHPECP(object BAFDGKKJJJD);
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
