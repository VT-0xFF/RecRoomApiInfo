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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x609AA10", Offset = "0x6099810", VA = "0x18609AA10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D3170", VA = "0x1807D4370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class IPDBFFEGHBO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6097130", Offset = "0x6095F30", VA = "0x186097130")]
	public IPDBFFEGHBO(bool EOGECHCGGNA, string FDBBPCJFNFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BKKJFPFOOJL<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> KDGCLBJBEJH(CancellationToken HHBHDBLGMFA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct EKMBAIONLBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public BKKJFPFOOJL<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public KDGCLBJBEJH taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x324CB00", Offset = "0x324B900", VA = "0x18324CB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x324DB60", Offset = "0x324C960", VA = "0x18324DB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource HMAJEHPOLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? AEAOKMFFMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? JGCFIKICHCL;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x46A9D80", Offset = "0x46A8B80", VA = "0x1846A9D80")]
	[AsyncStateMachine(typeof(BKKJFPFOOJL<>.EKMBAIONLBC))]
	public Task<TResult> ICNAIDNDEEF(KDGCLBJBEJH FINIMHCLPLK, [Optional] CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x46A9D10", Offset = "0x46A8B10", VA = "0x1846A9D10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x46A9EC0", Offset = "0x46A8CC0", VA = "0x1846A9EC0")]
	public BKKJFPFOOJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LKAFPADBPPE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> NBCAHNKNLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T DFPHMDCMPIO;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3BFBAE0", Offset = "0x3BFA8E0", VA = "0x183BFBAE0")]
	public LKAFPADBPPE([In] T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB2E0", Offset = "0x3BFA0E0", VA = "0x183BFB2E0", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB590", Offset = "0x3BFA390", VA = "0x183BFB590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB830", Offset = "0x3BFA630", VA = "0x183BFB830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MCGCOJBHNDO
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6098050", Offset = "0x6096E50", VA = "0x186098050")]
	public static void EMGMGDCPDHP(this CancellationTokenSource HMAJEHPOLEJ, bool GPJOFEFOGHG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class OOJDJPHHOHB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
	public OOJDJPHHOHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class CLIBOIKMCKH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
	public CLIBOIKMCKH(string PIFGKPMKDNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class OINGMODIIJL
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2854790", Offset = "0x2853590", VA = "0x182854790")]
	public static OLDEFDAMLOO DCDFGBEJELJ<T>()
	{
		return default(OLDEFDAMLOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2854A10", Offset = "0x2853810", VA = "0x182854A10")]
	public static OLDEFDAMLOO GLHPPEFPGFD<T>([CallerMemberName] string OHHBGJPCFJD = "") where T : notnull
	{
		return default(OLDEFDAMLOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2854810", Offset = "0x2853610", VA = "0x182854810")]
	public static OLDEFDAMLOO DCDFGBEJELJ<T>(this T AIFJDDMPMMF) where T : notnull
	{
		return default(OLDEFDAMLOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2854890", Offset = "0x2853690", VA = "0x182854890")]
	public static OLDEFDAMLOO GGPJBKAIHCE<T>(this T AIFJDDMPMMF, [CallerMemberName] string OHHBGJPCFJD = "") where T : notnull
	{
		return default(OLDEFDAMLOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2854AA0", Offset = "0x28538A0", VA = "0x182854AA0")]
	public static OLDEFDAMLOO GLHPPEFPGFD<T>(this T CNFBJPGPBBJ, [CallerMemberName] string OHHBGJPCFJD = "") where T : notnull
	{
		return default(OLDEFDAMLOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x609AA90", Offset = "0x6099890", VA = "0x18609AA90")]
	public static OLDEFDAMLOO GLHPPEFPGFD(string LCJEFCEKOCG, [CallerMemberName] string OHHBGJPCFJD = "")
	{
		return default(OLDEFDAMLOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x609AB10", Offset = "0x6099910", VA = "0x18609AB10")]
	public static string IFOCODMEBFD(this object CNFBJPGPBBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate bool NOFHPFGLJOK();
[Cpp2IlInjected.Token(Token = "0x200000F")]
[OOJDJPHHOHB]
public delegate long NDAJNLPDLOB();
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CFLFMFLILLJ
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static BDGGJBEIOGK LACOAJNKLAA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static BDGGJBEIOGK KDLFPKBLHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6093FF0", Offset = "0x6092DF0", VA = "0x186093FF0")]
		get
		{
			return default(BDGGJBEIOGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static AGLINAPBIGO CNLNCLOIDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6093ED0", Offset = "0x6092CD0", VA = "0x186093ED0")]
		get
		{
			return default(AGLINAPBIGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static PKIACMADEMF FGALEIIDAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6094190", Offset = "0x6092F90", VA = "0x186094190")]
		get
		{
			return default(PKIACMADEMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool JKICEDPMOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6093E60", Offset = "0x6092C60", VA = "0x186093E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6093A40", Offset = "0x6092840", VA = "0x186093A40")]
	public static void AEPHIIJMGJN([In] BDGGJBEIOGK BHOHAFEKODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6093F20", Offset = "0x6092D20", VA = "0x186093F20")]
	public static void FDPKAFHEJCK(string EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6093CF0", Offset = "0x6092AF0", VA = "0x186093CF0")]
	public static void BHDCDOHIMIM(string EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x255CA00", Offset = "0x255B800", VA = "0x18255CA00")]
	public static void BHDCDOHIMIM<T>(T MLBFGGJBJJC, IECABPPFCGO<T> EMKENBOOEOH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6093BF0", Offset = "0x60929F0", VA = "0x186093BF0")]
	public static void BDGNLCPMAPJ(Exception PIJHOBKPGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6093C90", Offset = "0x6092A90", VA = "0x186093C90")]
	public static void BFGCEGCPLFF(string OHHBGJPCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6094040", Offset = "0x6092E40", VA = "0x186094040")]
	public static void HLBPHCFNIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60940A0", Offset = "0x6092EA0", VA = "0x1860940A0")]
	public static string IFOCODMEBFD(object NHLNHJGAONN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6094120", Offset = "0x6092F20", VA = "0x186094120")]
	public static long JGGJEALKPEB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6093DC0", Offset = "0x6092BC0", VA = "0x186093DC0")]
	public static bool CCCBJDGELAA(bool CCJANDCJFAE, string EMKENBOOEOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60941E0", Offset = "0x6092FE0", VA = "0x1860941E0")]
	public static double NEJJNNBIKMB()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct BDGGJBEIOGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly AGLINAPBIGO CNLNCLOIDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly PKIACMADEMF FGALEIIDAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly DNHIAJOODIG NNKJABMKFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly NDAJNLPDLOB OLHECKDPDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly NANLANFPIEC NGCEGLLGKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly NOFHPFGLJOK LECCHKDFCIJ;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly DNHIAJOODIG HGNPGNKJMAH;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly NDAJNLPDLOB LCOBFMNEDNO;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly NANLANFPIEC HLCLOKLGHJH;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly NOFHPFGLJOK DEOLGJOMMIB;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly BDGGJBEIOGK NJBMLHJLPOH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CHDBPBGLOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x60927A0", Offset = "0x60915A0", VA = "0x1860927A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6093140", Offset = "0x6091F40", VA = "0x186093140")]
	public BDGGJBEIOGK([In] AGLINAPBIGO KIOBDENKMGE, [In] PKIACMADEMF OIDIMBJICHB, DNHIAJOODIG EHAGBEIJNBO, NDAJNLPDLOB BIOLJKGFEJI, NANLANFPIEC CDDJGMAOJEE, NOFHPFGLJOK GOBIIFFKIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6092760", Offset = "0x6091560", VA = "0x186092760")]
	private static string CCDOCOGHALH(object NHLNHJGAONN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0")]
	private static long PHEKHFIDIOD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
	private static string CLOJKDBOCIA(string BFHMEKKAMJH, string? PJNCGFPILMK, bool IBAPGNPADAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0")]
	private static bool FPGIJDJJJID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6092940", Offset = "0x6091740", VA = "0x186092940")]
	private static BDGGJBEIOGK NEOIEPLCIPF()
	{
		return default(BDGGJBEIOGK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CFGAMLCLEEE
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OBKPABHLGKO KEPGPNEAKDP();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OBKPABHLGKO : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DCMADFCNNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKJACAJEPCO();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NLAOOBBGEHG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JNFOCAILINO([In] T FPEEGIOMOFF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void NIEAMMOMANF<T>([In] T MLBFGGJBJJC);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct DNDOGFFLCFC<T> : IEquatable<DNDOGFFLCFC<T>>, NLAOOBBGEHG<DNDOGFFLCFC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T DFPHMDCMPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int CCEAOHGDFHD;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1D95540", Offset = "0x1D94340", VA = "0x181D95540")]
	public DNDOGFFLCFC([In] T NKKIECLCEML, int ENPOKNEMOMH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4F52330", Offset = "0x4F51130", VA = "0x184F52330")]
	public static bool JACCNGOPODK([In] DNDOGFFLCFC<T> DPMPIPDPNFG, [In] DNDOGFFLCFC<T> DJCBILALFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C690", Offset = "0x3F8B490", VA = "0x183F8C690", Slot = "4")]
	public bool Equals(DNDOGFFLCFC<T> FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3674DE0", Offset = "0x3673BE0", VA = "0x183674DE0", Slot = "0")]
	public override bool Equals(object FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4F525A0", Offset = "0x4F513A0", VA = "0x184F525A0")]
	public bool JNFOCAILINO([In] DNDOGFFLCFC<T> FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4F51CF0", Offset = "0x4F50AF0", VA = "0x184F51CF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4F52DF0", Offset = "0x4F51BF0", VA = "0x184F52DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4F514A0", Offset = "0x4F502A0", VA = "0x184F514A0")]
	public void FLAGJIHGEHA([Out] T NKKIECLCEML, [Out] int ENPOKNEMOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4F52630", Offset = "0x4F51430", VA = "0x184F52630")]
	public (T, int) JNHCGJNPKKM()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4F52A10", Offset = "0x4F51810", VA = "0x184F52A10", Slot = "5")]
	private bool ONPBACBEAEA([In] DNDOGFFLCFC<T> FPEEGIOMOFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class CJIBAEHIHAG
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2570C10", Offset = "0x256FA10", VA = "0x182570C10")]
	public static DNDOGFFLCFC<T> KJKFMOENPNA<T>([In] T NKKIECLCEML, int ENPOKNEMOMH) where T : notnull
	{
		return default(DNDOGFFLCFC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class EKAOLIADBCE
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x25C8770", Offset = "0x25C7570", VA = "0x1825C8770")]
	public static bool JNFOCAILINO<T, U>([In] T CNFBJPGPBBJ, [In] U NHLNHJGAONN) where T : notnull, NLAOOBBGEHG<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate TResult ALLDDHIKJMO<T, out TResult>([In] T MLBFGGJBJJC);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface GJEPPGLMPJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan JAHDIMJMDOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? LKLBAPJIAFD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KJBAIGHFNON();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LIFGOBAOMPC();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MMCMCIPEMLI();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct AGLINAPBIGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly BABCKMEPMMA FLPKDDDKHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly AHFGLPPCBDK GJADLJAFKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly BABCKMEPMMA NDNIJELGDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly AHFGLPPCBDK LGLGJNOMJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly BABCKMEPMMA ELNLNPANJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly AHFGLPPCBDK HDILPCBIPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly EOMJGPICLEI OHPKNBCCFOP;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly BABCKMEPMMA ADFMHPKEBEL;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly AHFGLPPCBDK BKCIBLICFKM;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly BABCKMEPMMA BNEDEJLNDDN;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly AHFGLPPCBDK OKDBDKDMHOB;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly BABCKMEPMMA PDECIACJLHH;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly AHFGLPPCBDK FBNKFNDIDBO;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly EOMJGPICLEI LPCOIBGDLEB;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly AGLINAPBIGO NJBMLHJLPOH;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly BABCKMEPMMA OHIHDAHKMLD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CHDBPBGLOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6091870", Offset = "0x6090670", VA = "0x186091870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x949830", Offset = "0x948630", VA = "0x180949830")]
	public AGLINAPBIGO(BABCKMEPMMA CAJGBFGEKKL, AHFGLPPCBDK GLDFKDPBNJF, BABCKMEPMMA IOODJGCODKF, AHFGLPPCBDK OGCJIFJLEGM, BABCKMEPMMA DDNAEHNLLHL, AHFGLPPCBDK KEONBACECHF, EOMJGPICLEI FDIPPOFMKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0")]
	private static bool GEDAAKIOKPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
	private static void CIOFOOMLDMD(string EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0")]
	private static bool EGLDOJMBKIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
	private static void GGNJPEPNCIJ(string EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0")]
	private static bool FCANIJFNFPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
	private static void BEHOGIHNHAP(string EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
	private static void MJEFBHNGDNM(Exception PIJHOBKPGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6091A70", Offset = "0x6090870", VA = "0x186091A70")]
	private static AGLINAPBIGO NEOIEPLCIPF()
	{
		return default(AGLINAPBIGO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C4100", Offset = "0x7C2F00", VA = "0x1807C4100")]
	private static bool BGCDPLBONPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6091800", Offset = "0x6090600", VA = "0x186091800")]
	public void FDPKAFHEJCK(object EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60915E0", Offset = "0x60903E0", VA = "0x1860915E0")]
	public void BHDCDOHIMIM(object EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x192F0A0", Offset = "0x192DEA0", VA = "0x18192F0A0")]
	public void BDGNLCPMAPJ(Exception PIJHOBKPGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6091650", Offset = "0x6090450", VA = "0x186091650")]
	public void BHDCDOHIMIM(KGOPLIDCNPE EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2CC1170", Offset = "0x2CBFF70", VA = "0x182CC1170")]
	public void BHDCDOHIMIM<T>(T MLBFGGJBJJC, IECABPPFCGO<T> EMKENBOOEOH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2CC1230", Offset = "0x2CC0030", VA = "0x182CC1230")]
	public void FDPKAFHEJCK<T>([In] T MLBFGGJBJJC, KPHIGFEHBMH<T> EMKENBOOEOH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6091730", Offset = "0x6090530", VA = "0x186091730")]
	public bool CCCBJDGELAA(bool CCJANDCJFAE, string EMKENBOOEOH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct OLDEFDAMLOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string DFPHMDCMPIO;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A60", Offset = "0x8D3860", VA = "0x1808D4A60")]
	public OLDEFDAMLOO(string NKKIECLCEML)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0")]
	public static string EADAJIFKEOK([In] OLDEFDAMLOO CNFBJPGPBBJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x13F5C10", Offset = "0x13F4A10", VA = "0x1813F5C10")]
	public static OLDEFDAMLOO EADAJIFKEOK(string FPEEGIOMOFF)
	{
		return default(OLDEFDAMLOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x609AC90", Offset = "0x6099A90", VA = "0x18609AC90")]
	public string MDFJPHFNJAL(string GONJIKGEFGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x609ABB0", Offset = "0x60999B0", VA = "0x18609ABB0")]
	public string ALEBFHLOFOG(object DLLLAJJCCDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct JEGFFGGMBEH : IEquatable<JEGFFGGMBEH>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7C4100", Offset = "0x7C2F00", VA = "0x1807C4100", Slot = "4")]
	public bool Equals(JEGFFGGMBEH FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6097440", Offset = "0x6096240", VA = "0x186097440", Slot = "0")]
	public override bool Equals(object FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6097490", Offset = "0x6096290", VA = "0x186097490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x60974A0", Offset = "0x60962A0", VA = "0x1860974A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[MFKPHBEGHNM("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct OPMELBICLMG<T> : IEquatable<OPMELBICLMG<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T DFPHMDCMPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool CCHOJJGBPNH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool BLACHCPJBPN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3F8C380", Offset = "0x3F8B180", VA = "0x183F8C380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3F8D5C0", Offset = "0x3F8C3C0", VA = "0x183F8D5C0")]
	public OPMELBICLMG([In] T NKKIECLCEML, bool CGOOEHKGIJG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3F8D120", Offset = "0x3F8BF20", VA = "0x183F8D120")]
	public static bool JACCNGOPODK([In] OPMELBICLMG<T> DPMPIPDPNFG, [In] OPMELBICLMG<T> DJCBILALFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C690", Offset = "0x3F8B490", VA = "0x183F8C690", Slot = "4")]
	public bool Equals(OPMELBICLMG<T> FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C710", Offset = "0x3F8B510", VA = "0x183F8C710", Slot = "0")]
	public override bool Equals(object FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3F8CBF0", Offset = "0x3F8B9F0", VA = "0x183F8CBF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3F8D480", Offset = "0x3F8C280", VA = "0x183F8D480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class IHLCOGMPJEL
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x273EB00", Offset = "0x273D900", VA = "0x18273EB00")]
	public static OPMELBICLMG<T> HALEADBKHLJ<T>([In] T NKKIECLCEML) where T : notnull
	{
		return default(OPMELBICLMG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x273EC20", Offset = "0x273DA20", VA = "0x18273EC20")]
	public static OPMELBICLMG<T?> PFPPIMKLDDE<T>()
	{
		return default(OPMELBICLMG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x273EA60", Offset = "0x273D860", VA = "0x18273EA60")]
	public static bool GPCGBHLBIFD<T>([In] this OPMELBICLMG<T> GAPCDFPEGGL, [Out][NotNullWhen(true)] T NKKIECLCEML) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct PKIACMADEMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr BFGCEGCPLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr HLBPHCFNIJN;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr EANFFMDCBLC;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr HHKDBJLFCML;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly PKIACMADEMF NJBMLHJLPOH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool CHDBPBGLOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x609ACE0", Offset = "0x6099AE0", VA = "0x18609ACE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x89F0F0", Offset = "0x89DEF0", VA = "0x18089F0F0")]
	public PKIACMADEMF(IntPtr BPEMIFKPGNK, IntPtr IGIBJFCFACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
	private static void DIDPJFJKCDL(string OHHBGJPCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
	private static void PKEFEAILIID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x609ADC0", Offset = "0x6099BC0", VA = "0x18609ADC0")]
	private static PKIACMADEMF NEOIEPLCIPF()
	{
		return default(PKIACMADEMF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct KPCEENAPFJF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr KGCOLJAFGKE;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A60", Offset = "0x8D3860", VA = "0x1808D4A60")]
	private KPCEENAPFJF(IntPtr IGIBJFCFACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6097960", Offset = "0x6096760", VA = "0x186097960", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6097970", Offset = "0x6096770", VA = "0x186097970")]
	public static KPCEENAPFJF KJKFMOENPNA(string OHHBGJPCFJD)
	{
		return default(KPCEENAPFJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D85680", Offset = "0x1D84480", VA = "0x181D85680")]
	public static KPCEENAPFJF KJKFMOENPNA([In] PKIACMADEMF OIDIMBJICHB, string OHHBGJPCFJD)
	{
		return default(KPCEENAPFJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1D85140", Offset = "0x1D83F40", VA = "0x181D85140")]
	public static KPCEENAPFJF KJKFMOENPNA([In] PKIACMADEMF OIDIMBJICHB, Func<string> OHHBGJPCFJD)
	{
		return default(KPCEENAPFJF);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class NLDCHMKJNIG
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate bool HIDHBMEILGM<in TInput, TResult>(TInput ECKJJAACLOE, [Out] TResult BGCCPJGDEGH);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private sealed class ABJKJCKBHNG : CFGAMLCLEEE
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private sealed class JBJNOCIELHB : OBKPABHLGKO, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly JBJNOCIELHB AHFNEPHAKHC;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool DCMADFCNNKO
			{
				[Cpp2IlInjected.Token(Token = "0x60000AF")]
				[Cpp2IlInjected.Address(RVA = "0x6097200", Offset = "0x6096000", VA = "0x186097200", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6097260", Offset = "0x6096060", VA = "0x186097260", Slot = "6")]
			public void OnCompleted(Action COMGHKCJHEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
			public void IKJACAJEPCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public JBJNOCIELHB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly ABJKJCKBHNG AHFNEPHAKHC;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		private ABJKJCKBHNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6091510", Offset = "0x6090310", VA = "0x186091510", Slot = "4")]
		public OBKPABHLGKO KEPGPNEAKDP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private sealed class CJFELONACDH : CFGAMLCLEEE
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private sealed class LMHBMBGLCJD : OBKPABHLGKO, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly LMHBMBGLCJD AHFNEPHAKHC;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool DCMADFCNNKO
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x6097CA0", Offset = "0x6096AA0", VA = "0x186097CA0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6097CC0", Offset = "0x6096AC0", VA = "0x186097CC0", Slot = "6")]
			public void OnCompleted(Action COMGHKCJHEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
			public void IKJACAJEPCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public LMHBMBGLCJD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly CJFELONACDH AHFNEPHAKHC;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		private CJFELONACDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6094370", Offset = "0x6093170", VA = "0x186094370", Slot = "4")]
		public OBKPABHLGKO KEPGPNEAKDP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class IIIEDDLDPOM<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public IIIEDDLDPOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x369FA00", Offset = "0x369E800", VA = "0x18369FA00")]
		internal void KBDNAMPJLNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class IFIPICMDLND<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public IFIPICMDLND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x35E5D00", Offset = "0x35E4B00", VA = "0x1835E5D00")]
		internal void GEDKGCEMBEM(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct BBOKHCHLDMG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6092600", Offset = "0x6091400", VA = "0x186092600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x920680", Offset = "0x91F480", VA = "0x180920680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct IKHOFCAGCEG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6096CD0", Offset = "0x6095AD0", VA = "0x186096CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x920680", Offset = "0x91F480", VA = "0x180920680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct IJCDBAEJKOO<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x385B380", Offset = "0x385A180", VA = "0x18385B380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x385B4F0", Offset = "0x385A2F0", VA = "0x18385B4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct AHNILKHLFCO<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x367B3C0", Offset = "0x367A1C0", VA = "0x18367B3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x367BC30", Offset = "0x367AA30", VA = "0x18367BC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct NGIHPPILFEE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6098BF0", Offset = "0x60979F0", VA = "0x186098BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6098DF0", Offset = "0x6097BF0", VA = "0x186098DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class GFMOJPNCAMB<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public GFMOJPNCAMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x369FA00", Offset = "0x369E800", VA = "0x18369FA00")]
		internal void LLEEOBCOAMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x369F9A0", Offset = "0x369E7A0", VA = "0x18369F9A0")]
		internal void EFHAAJCJCCP(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct BNCNCPKEDAD<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public HIDHBMEILGM<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x46BD250", Offset = "0x46BC050", VA = "0x1846BD250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x46BD940", Offset = "0x46BC740", VA = "0x1846BD940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct BOFPKOMCHNO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x60931F0", Offset = "0x6091FF0", VA = "0x1860931F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x60939E0", Offset = "0x60927E0", VA = "0x1860939E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct IKEKLHOOPOE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6096730", Offset = "0x6095530", VA = "0x186096730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6096C70", Offset = "0x6095A70", VA = "0x186096C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct KOKIEJELOCP<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3B16B90", Offset = "0x3B15990", VA = "0x183B16B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x35CAFA0", Offset = "0x35C9DA0", VA = "0x1835CAFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct LEDEIHICEAE<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3BDD3C0", Offset = "0x3BDC1C0", VA = "0x183BDD3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x324AA50", Offset = "0x3249850", VA = "0x18324AA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct KJENGBFOHPI<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3ACC090", Offset = "0x3ACAE90", VA = "0x183ACC090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3ACC790", Offset = "0x3ACB590", VA = "0x183ACC790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct LJIBAJAKJGL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6097A60", Offset = "0x6096860", VA = "0x186097A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6097C40", Offset = "0x6096A40", VA = "0x186097C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct GCLBJOGFABG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6094440", Offset = "0x6093240", VA = "0x186094440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x60947B0", Offset = "0x60935B0", VA = "0x1860947B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct IOPEPELFMIP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6096DE0", Offset = "0x6095BE0", VA = "0x186096DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x60970D0", Offset = "0x6095ED0", VA = "0x1860970D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class KAOAICEGPBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public KAOAICEGPBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x60978A0", Offset = "0x60966A0", VA = "0x1860978A0")]
		internal Task KOFNMKJLNLF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct IECMBEPHMMC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x60962E0", Offset = "0x60950E0", VA = "0x1860962E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6096540", Offset = "0x6095340", VA = "0x186096540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct NDGBKIHGKIJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6098180", Offset = "0x6096F80", VA = "0x186098180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6098360", Offset = "0x6097160", VA = "0x186098360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct JJFOIIKIOBB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x60974D0", Offset = "0x60962D0", VA = "0x1860974D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6097840", Offset = "0x6096640", VA = "0x186097840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct GJBCDLJCOFF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6094F10", Offset = "0x6093D10", VA = "0x186094F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6095200", Offset = "0x6094000", VA = "0x186095200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class IHEIJAEHLEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public IHEIJAEHLEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x60965A0", Offset = "0x60953A0", VA = "0x1860965A0")]
		internal Task MCLMDIDAHEK(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct MCBEDHDIJAF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6097D90", Offset = "0x6096B90", VA = "0x186097D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6097FF0", Offset = "0x6096DF0", VA = "0x186097FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct IAHEEGDEDAM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6096100", Offset = "0x6094F00", VA = "0x186096100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6096280", Offset = "0x6095080", VA = "0x186096280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct GNMLLFDPBAJ<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x36D1190", Offset = "0x36CFF90", VA = "0x1836D1190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x36D13F0", Offset = "0x36D01F0", VA = "0x1836D13F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct AJMGKMEENKP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6092190", Offset = "0x6090F90", VA = "0x186092190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x60925A0", Offset = "0x60913A0", VA = "0x1860925A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? BBKHOGBNPAI;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<JEGFFGGMBEH> ILJLDGJOMOM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task LGABDKKNCCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x609A8E0", Offset = "0x60996E0", VA = "0x18609A8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2834650", Offset = "0x2833450", VA = "0x182834650")]
	public static Task<T> MAGEFMHCJBO<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6099C60", Offset = "0x6098A60", VA = "0x186099C60")]
	public static Task HHOBEEPNPNB(this Task IMKKNGNMOEA, CancellationToken NBGOKNOECBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2833510", Offset = "0x2832310", VA = "0x182833510")]
	public static Task<TResult> HHOBEEPNPNB<TResult>(this Task<TResult> IMKKNGNMOEA, CancellationToken NBGOKNOECBH) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2833D60", Offset = "0x2832B60", VA = "0x182833D60")]
	public static TaskCompletionSource<TResult> HHOBEEPNPNB<TResult>(this TaskCompletionSource<TResult> NEJMAEGMNEO, CancellationToken NBGOKNOECBH) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6099F70", Offset = "0x6098D70", VA = "0x186099F70")]
	[AsyncStateMachine(typeof(BBOKHCHLDMG))]
	public static void KPJDMBBADDJ(this Task GBMCNPIMCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6099EC0", Offset = "0x6098CC0", VA = "0x186099EC0")]
	[AsyncStateMachine(typeof(IKHOFCAGCEG))]
	public static void JGDMBLDMDJH(this Task GBMCNPIMCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2834580", Offset = "0x2833380", VA = "0x182834580")]
	[AsyncStateMachine(typeof(IJCDBAEJKOO<>))]
	public static Task JJLKEONFGFL<TException>(this Task GBMCNPIMCLE) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x28342C0", Offset = "0x28330C0", VA = "0x1828342C0")]
	[AsyncStateMachine(typeof(AHNILKHLFCO<>))]
	public static Task<T> HIIGPEIDONK<T>(this Task<T> CNFBJPGPBBJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x609A390", Offset = "0x6099190", VA = "0x18609A390")]
	[AsyncStateMachine(typeof(NGIHPPILFEE))]
	public static Task<TaskStatus> MPCCHBENPKO(this Task CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x28347A0", Offset = "0x28335A0", VA = "0x1828347A0")]
	public static (Task<T?>?, Action<T?>?) MHPNEBIIGKI<T>([Optional] CancellationToken HHBHDBLGMFA)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2834480", Offset = "0x2833280", VA = "0x182834480")]
	[AsyncStateMachine(typeof(BNCNCPKEDAD<, >))]
	public static Task<List<TResult>> JIGPDMLICPF<TResult, TInput>(this Task<List<TInput>> IMKKNGNMOEA, HIDHBMEILGM<TInput, TResult> OFCFHCMFPJI) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x609A020", Offset = "0x6098E20", VA = "0x18609A020")]
	[AsyncStateMachine(typeof(BOFPKOMCHNO))]
	public static Task LEMFFBJKIKF(Task GBMCNPIMCLE, CancellationToken JPLHPFGGALJ, Func<CancellationToken, Task> HOKPHDOGOID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6098E60", Offset = "0x6097C60", VA = "0x186098E60")]
	[AsyncStateMachine(typeof(IKEKLHOOPOE))]
	public static Task BLPCELHBPPO(Func<CancellationToken, Task> MICMNEHFBMA, TimeSpan GAODDMEEHFK, [Optional] CancellationToken JPLHPFGGALJ, [Optional] Action<OperationCanceledException>? HNFKBNIAOEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x28313B0", Offset = "0x28301B0", VA = "0x1828313B0")]
	[AsyncStateMachine(typeof(KOKIEJELOCP<>))]
	public static Task<T> BLPCELHBPPO<T>(Func<CancellationToken, Task<T>> MICMNEHFBMA, TimeSpan GAODDMEEHFK, [Optional] CancellationToken JPLHPFGGALJ, [Optional] Func<OperationCanceledException, T>? HNFKBNIAOEJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x28312D0", Offset = "0x28300D0", VA = "0x1828312D0")]
	[AsyncStateMachine(typeof(LEDEIHICEAE<>))]
	public static Task<IEnumerable<Task<T>>> AJOONGFDABC<T>(IEnumerable<Task<T>> GHLPDLIMHNL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x28349E0", Offset = "0x28337E0", VA = "0x1828349E0")]
	[AsyncStateMachine(typeof(KJENGBFOHPI<, , , >))]
	public static Task<(T1, T2, T3, T4)> MMDMOIFJBHN<T1, T2, T3, T4>(Task<T1> PLMCDFCGDNG, Task<T2> FKOJNJINMNA, Task<T3> OIBLAIAMHHB, Task<T4> HILOOLFCINF) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x60995F0", Offset = "0x60983F0", VA = "0x1860995F0")]
	[AsyncStateMachine(typeof(LJIBAJAKJGL))]
	public static Task EFDPAAFCNCD(Func<bool> CCJANDCJFAE, [Optional] CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x60996E0", Offset = "0x60984E0", VA = "0x1860996E0")]
	[AsyncStateMachine(typeof(GCLBJOGFABG))]
	public static Task EFDPAAFCNCD(Func<bool> CCJANDCJFAE, TimeSpan DACIDGHPKHI, [Optional] CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x60994C0", Offset = "0x60982C0", VA = "0x1860994C0")]
	[AsyncStateMachine(typeof(IOPEPELFMIP))]
	public static Task ECJMKILKDCN(Func<bool> CCJANDCJFAE, TimeSpan GAODDMEEHFK, [Optional] CancellationToken HHBHDBLGMFA, [Optional] Action<OperationCanceledException>? HNFKBNIAOEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6099380", Offset = "0x6098180", VA = "0x186099380")]
	[AsyncStateMachine(typeof(IECMBEPHMMC))]
	public static Task ECJMKILKDCN(Func<bool> CCJANDCJFAE, TimeSpan GAODDMEEHFK, TimeSpan DACIDGHPKHI, [Optional] CancellationToken HHBHDBLGMFA, [Optional] Action<OperationCanceledException>? HNFKBNIAOEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6098F90", Offset = "0x6097D90", VA = "0x186098F90")]
	[AsyncStateMachine(typeof(NDGBKIHGKIJ))]
	public static Task CJLBMOGOIHK(Func<bool> CCJANDCJFAE, [Optional] CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6099080", Offset = "0x6097E80", VA = "0x186099080")]
	[AsyncStateMachine(typeof(JJFOIIKIOBB))]
	public static Task CJLBMOGOIHK(Func<bool> CCJANDCJFAE, TimeSpan DACIDGHPKHI, [Optional] CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x609A670", Offset = "0x6099470", VA = "0x18609A670")]
	[AsyncStateMachine(typeof(GJBCDLJCOFF))]
	public static Task PAECOAHEKNP(Func<bool> CCJANDCJFAE, TimeSpan GAODDMEEHFK, [Optional] CancellationToken HHBHDBLGMFA, [Optional] Action<OperationCanceledException>? HNFKBNIAOEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x609A7A0", Offset = "0x60995A0", VA = "0x18609A7A0")]
	[AsyncStateMachine(typeof(MCBEDHDIJAF))]
	public static Task PAECOAHEKNP(Func<bool> CCJANDCJFAE, TimeSpan GAODDMEEHFK, TimeSpan DACIDGHPKHI, [Optional] CancellationToken HHBHDBLGMFA, [Optional] Action<OperationCanceledException>? HNFKBNIAOEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x60997F0", Offset = "0x60985F0", VA = "0x1860997F0")]
	[Obsolete]
	[AsyncStateMachine(typeof(IAHEEGDEDAM))]
	public static Task FICGMDMIJAG(this Task IMKKNGNMOEA, Action DJKPENGPBCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2831610", Offset = "0x2830410", VA = "0x182831610")]
	[Obsolete]
	[AsyncStateMachine(typeof(GNMLLFDPBAJ<>))]
	public static Task FICGMDMIJAG<T>(this Task<T> IMKKNGNMOEA, Action<T> DJKPENGPBCO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x609A150", Offset = "0x6098F50", VA = "0x18609A150")]
	private static void LNHPEHDGCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x60998E0", Offset = "0x60986E0", VA = "0x1860998E0")]
	public static bool GGBFNMMEJBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x609A200", Offset = "0x6099000", VA = "0x18609A200")]
	private static void MAIBJMMDBEB(SynchronizationContext NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6099260", Offset = "0x6098060", VA = "0x186099260")]
	private static void DNMPEEDJNAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x609A480", Offset = "0x6099280", VA = "0x18609A480")]
	public static void NMCLNDJEBJH([Optional] string? EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x609A5F0", Offset = "0x60993F0", VA = "0x18609A5F0")]
	public static void ONJAIFBNDGE([Optional] string? EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x609A5A0", Offset = "0x60993A0", VA = "0x18609A5A0")]
	public static CFGAMLCLEEE OGKNDCJAELK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x609A550", Offset = "0x6099350", VA = "0x18609A550")]
	public static CFGAMLCLEEE OFOCKLANGDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6099190", Offset = "0x6097F90", VA = "0x186099190")]
	[AsyncStateMachine(typeof(AJMGKMEENKP))]
	public static Task DKKOFMJDBOB(Func<Task> ANOLKHFMNBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class AILBKAMKKLP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
	public AILBKAMKKLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class IJOHKMNNPDM : GJLLBINFGLA
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly GJLLBINFGLA AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime PALJHMBLLDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6096610", Offset = "0x6095410", VA = "0x186096610", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset JCMNHKMAPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6096650", Offset = "0x6095450", VA = "0x186096650", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public IJOHKMNNPDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface GJLLBINFGLA
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime PALJHMBLLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset JCMNHKMAPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class NFFHEOAFJCF
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long IKHKJKACHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x60988D0", Offset = "0x60976D0", VA = "0x1860988D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long OILEGAHHGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6098490", Offset = "0x6097290", VA = "0x186098490")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double HEOIMCBEFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6098570", Offset = "0x6097370", VA = "0x186098570")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double LGMCDPILOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x60986A0", Offset = "0x60974A0", VA = "0x1860986A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double NNPNBHHLIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6098650", Offset = "0x6097450", VA = "0x186098650")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double COFJACAHCIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6098880", Offset = "0x6097680", VA = "0x186098880")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x60984E0", Offset = "0x60972E0", VA = "0x1860984E0")]
	public static double DGGMDLOLPOI(long BLEONGKIPOM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x60985C0", Offset = "0x60973C0", VA = "0x1860985C0")]
	public static double FEMONCFOLIG(long BLEONGKIPOM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x60987F0", Offset = "0x60975F0", VA = "0x1860987F0")]
	public static double MMIFAPJJCIG(double EPKKDDHNNOK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6098760", Offset = "0x6097560", VA = "0x186098760")]
	public static long LJGDNBADLIF(long JDMCAOCKBDE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6098750", Offset = "0x6097550", VA = "0x186098750")]
	public static long KKIPNNGPAIF(long LOPBNNHBMIM, long DCGGLNMBPMB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x60983C0", Offset = "0x60971C0", VA = "0x1860983C0")]
	public static double AEJCNJEBEED(long LOPBNNHBMIM, long DCGGLNMBPMB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x60986F0", Offset = "0x60974F0", VA = "0x1860986F0")]
	public static double KGAILGGOIJL(long LOPBNNHBMIM, long DCGGLNMBPMB)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class GDAJLJLIKDA : GJEPPGLMPJH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan EEFLHMEPPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer JNIKEBIHBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan GAODDMEEHFK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan JAHDIMJMDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6094810", Offset = "0x6093610", VA = "0x186094810", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? LKLBAPJIAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6094C50", Offset = "0x6093A50", VA = "0x186094C50")]
	[Preserve]
	public GDAJLJLIKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6094CC0", Offset = "0x6093AC0", VA = "0x186094CC0")]
	public GDAJLJLIKDA(TimeSpan GAODDMEEHFK, [Optional] Action? NIBPDENPNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6094A10", Offset = "0x6093810", VA = "0x186094A10", Slot = "7")]
	public void KJBAIGHFNON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6094AA0", Offset = "0x60938A0", VA = "0x186094AA0", Slot = "8")]
	public void LIFGOBAOMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6094BB0", Offset = "0x60939B0", VA = "0x186094BB0", Slot = "9")]
	public void MMCMCIPEMLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xBB1A90", Offset = "0xBB0890", VA = "0x180BB1A90")]
	private void EGPNBAADGBJ(object AIFJDDMPMMF, ElapsedEventArgs IBAEDIGDGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6094B10", Offset = "0x6093910", VA = "0x186094B10")]
	private static void LPKMODOCLNP(TimeSpan MGCBOGCGBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6094970", Offset = "0x6093770", VA = "0x186094970", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class MFKPHBEGHNM : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string ILHPKCMLCJK;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
	public MFKPHBEGHNM(string JFBABPIJMOE)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct HHJNEFOBLKN : IEquatable<HHJNEFOBLKN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public uint DNFKFKIPJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public int JHNINEMCBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public float FJHAIPGHBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public ushort PIMFDCGDLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort EBEFFIOBPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public short HGNIKJCFNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short ODHCPNIAJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public char AJIPOKIKBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char EPCHFNEABKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public byte KLKLOEJKMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte OOGKONBAGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte CICBBGKKOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte HACPBDKAHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public bool DKCNOJNBNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool AMBGPLIBJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool JLMAMCKCILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool EAAAGMPNIKF;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xC163E0", Offset = "0xC151E0", VA = "0x180C163E0")]
	public static HHJNEFOBLKN HPCODMMHABJ(uint LCMIAOFPAKG)
	{
		return default(HHJNEFOBLKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xC163E0", Offset = "0xC151E0", VA = "0x180C163E0")]
	public static HHJNEFOBLKN EMAONFCGPOL(int PELHPFDKBCB)
	{
		return default(HHJNEFOBLKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6095260", Offset = "0x6094060", VA = "0x186095260")]
	public static HHJNEFOBLKN ACCEEKHNEDB(float KLNKHIAFBAP)
	{
		return default(HHJNEFOBLKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6095270", Offset = "0x6094070", VA = "0x186095270")]
	public static HHJNEFOBLKN FIBJEHFEPNG(byte OJOIDNAEDOF, byte JBHKGNFEFKN, byte EPKEHEJMJMD, byte DBMAJNGIGPL)
	{
		return default(HHJNEFOBLKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6095270", Offset = "0x6094070", VA = "0x186095270")]
	public static HHJNEFOBLKN ANLJLJGGOHL(bool DNJOGLCCIJK, bool JFBLJDNBLFM, bool KHHKOLCNOMC, bool CCCPBJGEDHG)
	{
		return default(HHJNEFOBLKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6095270", Offset = "0x6094070", VA = "0x186095270")]
	public static HHJNEFOBLKN LALLKEDANCB(byte FJBMOLFPNMD, byte GNMPJLEAJFC, byte JABOGHDHHPE, byte EPPGJMBMINO)
	{
		return default(HHJNEFOBLKN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1788D20", Offset = "0x1787B20", VA = "0x181788D20")]
	public static bool JACCNGOPODK(HHJNEFOBLKN EHBONBMIDMA, HHJNEFOBLKN MKAKMHGMJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x81DD00", Offset = "0x81CB00", VA = "0x18081DD00", Slot = "4")]
	public bool Equals(HHJNEFOBLKN FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6095290", Offset = "0x6094090", VA = "0x186095290", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x8B28F0", Offset = "0x8B16F0", VA = "0x1808B28F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6095310", Offset = "0x6094110", VA = "0x186095310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct KLHMCCNHDHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public ulong BFCCFLALCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public long JLAGAJJNOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public double CNALKBGDCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint KMECDOKHLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint GOLHFKLGOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public int GKMNEKOLMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int EINNCIPEFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public float HICHPAOKCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float GPJGEEDNEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public ushort PIMFDCGDLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort EBEFFIOBPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort ADALNKBEMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort DKGCMKDDBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short HGNIKJCFNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short ODHCPNIAJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short DBAIFPHFHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short OPLAACEGFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public char AJIPOKIKBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char EPCHFNEABKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char AKDCCMGKGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char MNHOOOEBLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte KLKLOEJKMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte OOGKONBAGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte CICBBGKKOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte HACPBDKAHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte IOKLDIBKNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte HDMAGJDPFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte ONJOIHBOINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte LCFJKFJHMGC;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6097910", Offset = "0x6096710", VA = "0x186097910")]
	public static KLHMCCNHDHC KJKFMOENPNA(byte OJOIDNAEDOF, byte JBHKGNFEFKN, byte EPKEHEJMJMD, byte DBMAJNGIGPL, byte DFJMIJPDGDK, byte PBHDBAJGOHK, byte BMIFAAJBHIE, byte NCHFGFGEOIB)
	{
		return default(KLHMCCNHDHC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class FMFGFOKHBJL<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly T INLNPCAEICP;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x35DC430", Offset = "0x35DB230", VA = "0x1835DC430")]
	public FMFGFOKHBJL(T MCHCLFCGFNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class OHNIDKPGJOE
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x28543B0", Offset = "0x28531B0", VA = "0x1828543B0")]
	public static FMFGFOKHBJL<T> KJKFMOENPNA<T>(T MCHCLFCGFNH) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class GEKNFPIDBDP
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x26F36A0", Offset = "0x26F24A0", VA = "0x1826F36A0")]
	public static IEnumerable<T> DKDBLELHCKC<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
	public static T[] LJBGBLIKNKK<T>(params T[] DCJBOPNKINB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
	public static IEnumerable<T> PMBPCNOOMGG<T>(params T[] DCJBOPNKINB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x259ACE0", Offset = "0x2599AE0", VA = "0x18259ACE0")]
	public static HashSet<T> PKLKFCBCACK<T>(params T[] DCJBOPNKINB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x26F35B0", Offset = "0x26F23B0", VA = "0x1826F35B0")]
	public static KeyValuePair<TKey, TValue> APEEEKDKPMI<TKey, TValue>([In] TKey JCMGBFKGKLO, [In] TValue NKKIECLCEML) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x259ACE0", Offset = "0x2599AE0", VA = "0x18259ACE0")]
	public static List<T> PMFLKLPNCGK<T>(IEnumerable<T> CHPHEMNFCNL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[AttributeUsage(AttributeTargets.All)]
public sealed class HLOIEFEINOD : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public readonly string KIDNHLGAFHC;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
	public HLOIEFEINOD(string IDPPHHMPMLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate object KPHIGFEHBMH<T>([In] T BBFBHKMAMKC);
[Cpp2IlInjected.Token(Token = "0x2000054")]
public delegate object IECABPPFCGO<T>(T BBFBHKMAMKC);
[Cpp2IlInjected.Token(Token = "0x2000055")]
[OOJDJPHHOHB]
public delegate string NANLANFPIEC(string BFHMEKKAMJH, string? PJNCGFPILMK, bool IBAPGNPADAD);
[Cpp2IlInjected.Token(Token = "0x2000056")]
[OOJDJPHHOHB]
public delegate void AHFGLPPCBDK(string EMKENBOOEOH);
[Cpp2IlInjected.Token(Token = "0x2000057")]
[OOJDJPHHOHB]
public delegate void EOMJGPICLEI(Exception PIJHOBKPGID);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object KGOPLIDCNPE();
[Cpp2IlInjected.Token(Token = "0x2000059")]
[OOJDJPHHOHB]
public delegate bool BABCKMEPMMA();
[Cpp2IlInjected.Token(Token = "0x200005A")]
[OOJDJPHHOHB]
public delegate string DNHIAJOODIG(object NHLNHJGAONN);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.Enum)]
public class FFDLAADPNMG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
	public FFDLAADPNMG()
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
