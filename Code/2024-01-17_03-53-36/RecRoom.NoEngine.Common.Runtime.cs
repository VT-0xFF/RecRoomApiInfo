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
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6058710", Offset = "0x6057510", VA = "0x186058710")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B9560", Offset = "0x7B8360", VA = "0x1807B9560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B95A0", Offset = "0x7B83A0", VA = "0x1807B95A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class ALGNBIBFEII : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6051130", Offset = "0x604FF30", VA = "0x186051130")]
	public ALGNBIBFEII(bool EDJBNCFIEDD, string JPMFDCHANIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HEHMOIOMMNL<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> PCFHLGONJPC(CancellationToken EHAEIHNIHFM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GEIJMFCKGPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public HEHMOIOMMNL<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public PCFHLGONJPC taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x36D2210", Offset = "0x36D1010", VA = "0x1836D2210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x36D3270", Offset = "0x36D2070", VA = "0x1836D3270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource ELAGOJJKAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? PHILAOLLOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? LAIIKEGEKDN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x373CA80", Offset = "0x373B880", VA = "0x18373CA80")]
	[AsyncStateMachine(typeof(HEHMOIOMMNL<>.GEIJMFCKGPL))]
	public Task<TResult> IGHNNKBEFMH(PCFHLGONJPC AEDEPNKDGLJ, [Optional] CancellationToken EHAEIHNIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x373CA10", Offset = "0x373B810", VA = "0x18373CA10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x373CBC0", Offset = "0x373B9C0", VA = "0x18373CBC0")]
	public HEHMOIOMMNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class AFBMLOKCFAH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> HMICHABCNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T AOJPLLHPPML;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x368C630", Offset = "0x368B430", VA = "0x18368C630")]
	public AFBMLOKCFAH([In] T MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x368BCF0", Offset = "0x368AAF0", VA = "0x18368BCF0", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x368C010", Offset = "0x368AE10", VA = "0x18368C010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x368C290", Offset = "0x368B090", VA = "0x18368C290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class FFAMGAEBEAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6055770", Offset = "0x6054570", VA = "0x186055770")]
	public static void GOMGGGOAHOM(this CancellationTokenSource ELAGOJJKAJJ, bool CJONOHHNIMA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class LIDGOKNFOGD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
	public LIDGOKNFOGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class NDCGPKMGJFC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
	public NDCGPKMGJFC(string PHIAHDCNCIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NIMJNFDGGHF
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2714FB0", Offset = "0x2713DB0", VA = "0x182714FB0")]
	public static NCFMIHMOMKM OONIODHELPL<T>()
	{
		return default(NCFMIHMOMKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2714E20", Offset = "0x2713C20", VA = "0x182714E20")]
	public static NCFMIHMOMKM GBGDNAEHPCL<T>([CallerMemberName] string AOAIBMOPKPE = "") where T : notnull
	{
		return default(NCFMIHMOMKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2715030", Offset = "0x2713E30", VA = "0x182715030")]
	public static NCFMIHMOMKM OONIODHELPL<T>(this T JFLBCAAFGDD) where T : notnull
	{
		return default(NCFMIHMOMKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2714C00", Offset = "0x2713A00", VA = "0x182714C00")]
	public static NCFMIHMOMKM ADIMABELHIP<T>(this T JFLBCAAFGDD, [CallerMemberName] string AOAIBMOPKPE = "") where T : notnull
	{
		return default(NCFMIHMOMKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2714D80", Offset = "0x2713B80", VA = "0x182714D80")]
	public static NCFMIHMOMKM GBGDNAEHPCL<T>(this T OJFDNDCDDBK, [CallerMemberName] string AOAIBMOPKPE = "") where T : notnull
	{
		return default(NCFMIHMOMKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6057EC0", Offset = "0x6056CC0", VA = "0x186057EC0")]
	public static NCFMIHMOMKM GBGDNAEHPCL(string LPCEEBGAPGF, [CallerMemberName] string AOAIBMOPKPE = "")
	{
		return default(NCFMIHMOMKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6057F40", Offset = "0x6056D40", VA = "0x186057F40")]
	public static string OKGJGOBNHJM(this object OJFDNDCDDBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate bool BDHJBGMBAMI();
[Cpp2IlInjected.Token(Token = "0x200000F")]
[LIDGOKNFOGD]
public delegate long JEIFDHIKFFF();
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MPCFMLHGKED
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static OGCILPNFMLK IEFLDHILDGK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static OGCILPNFMLK JGLAMMIPBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6057590", Offset = "0x6056390", VA = "0x186057590")]
		get
		{
			return default(OGCILPNFMLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static MFBOJDFOGLC OHKBFACGBCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6057540", Offset = "0x6056340", VA = "0x186057540")]
		get
		{
			return default(MFBOJDFOGLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static NMCIPNIJJJK IELNCDPNBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x60577F0", Offset = "0x60565F0", VA = "0x1860577F0")]
		get
		{
			return default(NMCIPNIJJJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool KBIOCJPFEML
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x60575E0", Offset = "0x60563E0", VA = "0x1860575E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6057390", Offset = "0x6056190", VA = "0x186057390")]
	public static void BFALHEHMONA([In] OGCILPNFMLK JDANJGKOILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6057650", Offset = "0x6056450", VA = "0x186057650")]
	public static void FPLGBFAGNKF(string EKPMNNKLPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6057960", Offset = "0x6056760", VA = "0x186057960")]
	public static void OMAMCCOHKIB(string EKPMNNKLPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x26A6170", Offset = "0x26A4F70", VA = "0x1826A6170")]
	public static void OMAMCCOHKIB<T>(T EOMAHDAGOPF, GMJHCAEAHHB<T> EKPMNNKLPFJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6057840", Offset = "0x6056640", VA = "0x186057840")]
	public static void OEMHCFNLOBE(Exception ANBLKCIIIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6057720", Offset = "0x6056520", VA = "0x186057720")]
	public static void GAADBJDMGPB(string AOAIBMOPKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6057A30", Offset = "0x6056830", VA = "0x186057A30")]
	public static void PPNDMFPAACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60578E0", Offset = "0x60566E0", VA = "0x1860578E0")]
	public static string OKGJGOBNHJM(object FGANJEAKCMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6057780", Offset = "0x6056580", VA = "0x186057780")]
	public static long LECMICDEGDN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6057220", Offset = "0x6056020", VA = "0x186057220")]
	public static bool ACJEBNFICMO(bool HHNPNNJCGFO, string EKPMNNKLPFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60572C0", Offset = "0x60560C0", VA = "0x1860572C0")]
	public static double AGNGJAALJDA()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct OGCILPNFMLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly MFBOJDFOGLC OHKBFACGBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly NMCIPNIJJJK IELNCDPNBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly EGINPNDHBLD DLNAPCCJIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly JEIFDHIKFFF BLLHBBPEHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly FNKPAGJJPFJ BMDKKGODEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly BDHJBGMBAMI JBCGMOADBKH;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly EGINPNDHBLD FJMIALCOJED;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly JEIFDHIKFFF PAHKPILCPBL;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly FNKPAGJJPFJ ABGKIPAAILN;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly BDHJBGMBAMI FOCGFCKHABE;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly OGCILPNFMLK CABPEDJKFDA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IJDAKCFEOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6058840", Offset = "0x6057640", VA = "0x186058840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60591E0", Offset = "0x6057FE0", VA = "0x1860591E0")]
	public OGCILPNFMLK([In] MFBOJDFOGLC BOILJCFGPJI, [In] NMCIPNIJJJK AKDBFPMJBFI, EGINPNDHBLD CGNNBGOENPO, JEIFDHIKFFF BIGHEBLMLNI, FNKPAGJJPFJ COFMAFPECIE, BDHJBGMBAMI HJJMPCKODON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6058800", Offset = "0x6057600", VA = "0x186058800")]
	private static string EJMFKLBKCEI(object FGANJEAKCMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x790850", Offset = "0x78F650", VA = "0x180790850")]
	private static long GPLMHBGGLGC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80")]
	private static string NFCHCGNNDJD(string ELALCBMPIFC, string? FJPACLEAEGP, bool GIOLONMIGFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0")]
	private static bool IGDHGJACNHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60589E0", Offset = "0x60577E0", VA = "0x1860589E0")]
	private static OGCILPNFMLK FPEKELHJNHJ()
	{
		return default(OGCILPNFMLK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NDPPHOLAJLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EEAELKMMGLB JGAOOOJCGAG();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EEAELKMMGLB : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MCMOHAOIJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FOKKNALLMGN();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NGNFFLDCBFD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JAEFGHIJMLG([In] T GDMGBCDFBAL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void NDHIGFCGILA<T>([In] T EOMAHDAGOPF);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct MBOLAIHHMHC<T> : IEquatable<MBOLAIHHMHC<T>>, NGNFFLDCBFD<MBOLAIHHMHC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T AOJPLLHPPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int IMILALJBIFL;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1D217A0", Offset = "0x1D205A0", VA = "0x181D217A0")]
	public MBOLAIHHMHC([In] T MBDKMNBCLGF, int HPLKFBKKIBG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3D3E150", Offset = "0x3D3CF50", VA = "0x183D3E150")]
	public static bool KFENMBPPCHH([In] MBOLAIHHMHC<T> PDAKJJLHJDL, [In] MBOLAIHHMHC<T> KKCNPIHMPJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3D3CE10", Offset = "0x3D3BC10", VA = "0x183D3CE10", Slot = "4")]
	public bool Equals(MBOLAIHHMHC<T> GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x35E12D0", Offset = "0x35E00D0", VA = "0x1835E12D0", Slot = "0")]
	public override bool Equals(object GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3D3DE60", Offset = "0x3D3CC60", VA = "0x183D3DE60")]
	public bool JAEFGHIJMLG([In] MBOLAIHHMHC<T> GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3D3DB80", Offset = "0x3D3C980", VA = "0x183D3DB80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3D3EAC0", Offset = "0x3D3D8C0", VA = "0x183D3EAC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3D3D1A0", Offset = "0x3D3BFA0", VA = "0x183D3D1A0")]
	public void GEEAEGHINBD([Out] T MBDKMNBCLGF, [Out] int HPLKFBKKIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3D3D6D0", Offset = "0x3D3C4D0", VA = "0x183D3D6D0")]
	public (T, int) GMMIPGOGDGJ()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D3DE10", Offset = "0x3D3CC10", VA = "0x183D3DE10", Slot = "5")]
	private bool IDLECAIEIFN([In] MBOLAIHHMHC<T> GDMGBCDFBAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class CHFPPHIHOFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x24081D0", Offset = "0x2406FD0", VA = "0x1824081D0")]
	public static MBOLAIHHMHC<T> DCPHPAHCOGO<T>([In] T MBDKMNBCLGF, int HPLKFBKKIBG) where T : notnull
	{
		return default(MBOLAIHHMHC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class GLIFPFAMBMA
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x25C4C60", Offset = "0x25C3A60", VA = "0x1825C4C60")]
	public static bool JAEFGHIJMLG<T, U>([In] T OJFDNDCDDBK, [In] U FGANJEAKCMA) where T : notnull, NGNFFLDCBFD<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate TResult LFLILBGHEGA<T, out TResult>([In] T EOMAHDAGOPF);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate TResult IAJFABMKLDM<T1, T2, out TResult>([In] T1 DIMAMNEJFEO, [In] T2 KOOFOFLIBCP);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KNMEAAFEPLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan IEHIBLMACKI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? NPOEBIFLLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HKKNIOFHBCA();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MJLJKHLICAF();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LGOAPCHIGOJ();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct MFBOJDFOGLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly LCPFDHFEIIM EPCCDLFGOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly FFDOLLLJABO GHMHNALFELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly LCPFDHFEIIM CBDOLBBJLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly FFDOLLLJABO NMCKFGPNJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly LCPFDHFEIIM PKFMLPGDFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly FFDOLLLJABO LBKDFLEEKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly AHIKAFHHPHH LFJHLPJNCPM;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly LCPFDHFEIIM LAFMIHEBLGK;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly FFDOLLLJABO LFPNJPFHKEF;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly LCPFDHFEIIM AJOLPDINHDD;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly FFDOLLLJABO KELMMKIDKOB;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly LCPFDHFEIIM EBKCHNBJBBI;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly FFDOLLLJABO KBOMJHLPECB;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly AHIKAFHHPHH LGDKFIFAJLH;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly MFBOJDFOGLC CABPEDJKFDA;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly LCPFDHFEIIM CDPJJNCMJHN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IJDAKCFEOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6056740", Offset = "0x6055540", VA = "0x186056740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x92DB80", Offset = "0x92C980", VA = "0x18092DB80")]
	public MFBOJDFOGLC(LCPFDHFEIIM IANNPMHFAMD, FFDOLLLJABO KBDENHJIHBO, LCPFDHFEIIM NFLJHOMDMNF, FFDOLLLJABO DLKEOMDEGPM, LCPFDHFEIIM JKFLIMCFCIH, FFDOLLLJABO NBNOLKDOMHI, AHIKAFHHPHH PEGEFLBDIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0")]
	private static bool DHLFCFMLKNG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840")]
	private static void CHOINNHHCCA(string EKPMNNKLPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0")]
	private static bool ONFCJLIAGIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840")]
	private static void LHKBLMFMHCN(string EKPMNNKLPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0")]
	private static bool JFBIDGIMBOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840")]
	private static void BMKGNMPJKFH(string EKPMNNKLPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840")]
	private static void JOAFPDGCPIH(Exception ANBLKCIIIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6056940", Offset = "0x6055740", VA = "0x186056940")]
	private static MFBOJDFOGLC FPEKELHJNHJ()
	{
		return default(MFBOJDFOGLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7A9270", Offset = "0x7A8070", VA = "0x1807A9270")]
	private static bool DGKCOPBAEOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6056A80", Offset = "0x6055880", VA = "0x186056A80")]
	public void FPLGBFAGNKF(object EKPMNNKLPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6056AF0", Offset = "0x60558F0", VA = "0x186056AF0")]
	public void OMAMCCOHKIB(object EKPMNNKLPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x21909B0", Offset = "0x218F7B0", VA = "0x1821909B0")]
	public void OEMHCFNLOBE(Exception ANBLKCIIIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6056B60", Offset = "0x6055960", VA = "0x186056B60")]
	public void OMAMCCOHKIB(NDCBPCNGEAI EKPMNNKLPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2682610", Offset = "0x2681410", VA = "0x182682610")]
	public void OMAMCCOHKIB<T>(T EOMAHDAGOPF, GMJHCAEAHHB<T> EKPMNNKLPFJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2682490", Offset = "0x2681290", VA = "0x182682490")]
	public void FPLGBFAGNKF<T>([In] T EOMAHDAGOPF, FGHBHPKFJHA<T> EKPMNNKLPFJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6056670", Offset = "0x6055470", VA = "0x186056670")]
	public bool ACJEBNFICMO(bool HHNPNNJCGFO, string EKPMNNKLPFJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct NCFMIHMOMKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string AOJPLLHPPML;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8C4200", Offset = "0x8C3000", VA = "0x1808C4200")]
	public NCFMIHMOMKM(string MBDKMNBCLGF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
	public static string GMMJAEFOFKB([In] NCFMIHMOMKM OJFDNDCDDBK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x13DAAA0", Offset = "0x13D98A0", VA = "0x1813DAAA0")]
	public static NCFMIHMOMKM GMMJAEFOFKB(string GDMGBCDFBAL)
	{
		return default(NCFMIHMOMKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6057D90", Offset = "0x6056B90", VA = "0x186057D90")]
	public string DCDGHNIOJEB(string CNBECJCGAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6057DE0", Offset = "0x6056BE0", VA = "0x186057DE0")]
	public string GGGBMCBCNDL(object LACKJDBODJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct BCBPFABBCDG : IEquatable<BCBPFABBCDG>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7A9270", Offset = "0x7A8070", VA = "0x1807A9270", Slot = "4")]
	public bool Equals(BCBPFABBCDG GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x60513E0", Offset = "0x60501E0", VA = "0x1860513E0", Slot = "0")]
	public override bool Equals(object GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6051430", Offset = "0x6050230", VA = "0x186051430", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6051440", Offset = "0x6050240", VA = "0x186051440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[GEKBGODLFAH("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct PPACJILLJDO<T> : IEquatable<PPACJILLJDO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T AOJPLLHPPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool ILBNFPDHAKF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool MLEPLEKLPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4054360", Offset = "0x4053160", VA = "0x184054360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4055550", Offset = "0x4054350", VA = "0x184055550")]
	public PPACJILLJDO([In] T MBDKMNBCLGF, bool CDNKACCJKIF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4054DD0", Offset = "0x4053BD0", VA = "0x184054DD0")]
	public static bool KFENMBPPCHH([In] PPACJILLJDO<T> PDAKJJLHJDL, [In] PPACJILLJDO<T> KKCNPIHMPJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3D3CE10", Offset = "0x3D3BC10", VA = "0x183D3CE10", Slot = "4")]
	public bool Equals(PPACJILLJDO<T> GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4054940", Offset = "0x4053740", VA = "0x184054940", Slot = "0")]
	public override bool Equals(object GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4054C00", Offset = "0x4053A00", VA = "0x184054C00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4055140", Offset = "0x4053F40", VA = "0x184055140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class OMBGBCLOLOG
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x275B550", Offset = "0x275A350", VA = "0x18275B550")]
	public static PPACJILLJDO<T> PCKHGKFEEMA<T>([In] T MBDKMNBCLGF) where T : notnull
	{
		return default(PPACJILLJDO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x275B3E0", Offset = "0x275A1E0", VA = "0x18275B3E0")]
	public static PPACJILLJDO<T?> IJDMMMILDED<T>()
	{
		return default(PPACJILLJDO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x275B450", Offset = "0x275A250", VA = "0x18275B450")]
	public static bool JBLBIKLOHAO<T>([In] this PPACJILLJDO<T> NCNPJBOAEPM, [Out][NotNullWhen(true)] T MBDKMNBCLGF) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct NMCIPNIJJJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr GAADBJDMGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr PPNDMFPAACP;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr GJLLAIHCDCI;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr ODEABAGKJKF;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly NMCIPNIJJJK CABPEDJKFDA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IJDAKCFEOFC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x60580B0", Offset = "0x6056EB0", VA = "0x1860580B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x862170", Offset = "0x860F70", VA = "0x180862170")]
	public NMCIPNIJJJK(IntPtr OGHHEHFCJLC, IntPtr PFBILGILLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840")]
	private static void LBDGKKJNDFP(string AOAIBMOPKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840")]
	private static void AMHJMMCMPKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6058190", Offset = "0x6056F90", VA = "0x186058190")]
	private static NMCIPNIJJJK FPEKELHJNHJ()
	{
		return default(NMCIPNIJJJK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct MCFBINNPNKC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr GJKKPAMMFOA;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8C4200", Offset = "0x8C3000", VA = "0x1808C4200")]
	private MCFBINNPNKC(IntPtr PFBILGILLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x60565F0", Offset = "0x60553F0", VA = "0x1860565F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6056500", Offset = "0x6055300", VA = "0x186056500")]
	public static MCFBINNPNKC DCPHPAHCOGO(string AOAIBMOPKPE)
	{
		return default(MCFBINNPNKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1D11440", Offset = "0x1D10240", VA = "0x181D11440")]
	public static MCFBINNPNKC DCPHPAHCOGO([In] NMCIPNIJJJK AKDBFPMJBFI, string AOAIBMOPKPE)
	{
		return default(MCFBINNPNKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1D112C0", Offset = "0x1D100C0", VA = "0x181D112C0")]
	public static MCFBINNPNKC DCPHPAHCOGO([In] NMCIPNIJJJK AKDBFPMJBFI, Func<string> AOAIBMOPKPE)
	{
		return default(MCFBINNPNKC);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class FBMCPENLDAD
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate bool DFALHMGGEPN<in TInput, TResult>(TInput PIMDNKIGEGF, [Out] TResult ADPBDOHMAGP);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private sealed class ILKJJADPJED : NDPPHOLAJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private sealed class NAFNOFPIHFA : EEAELKMMGLB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly NAFNOFPIHFA CEIKCOHBGGB;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool MCMOHAOIJHM
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x6057B50", Offset = "0x6056950", VA = "0x186057B50", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6057BB0", Offset = "0x60569B0", VA = "0x186057BB0", Slot = "6")]
			public void OnCompleted(Action NEOHCILADBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
			public void FOKKNALLMGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public NAFNOFPIHFA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly ILKJJADPJED CEIKCOHBGGB;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		private ILKJJADPJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x60559B0", Offset = "0x60547B0", VA = "0x1860559B0", Slot = "4")]
		public EEAELKMMGLB JGAOOOJCGAG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private sealed class NJKPPNPIMIP : NDPPHOLAJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private sealed class BGIEMIKKBLD : EEAELKMMGLB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly BGIEMIKKBLD CEIKCOHBGGB;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool MCMOHAOIJHM
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x6051840", Offset = "0x6050640", VA = "0x186051840", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6051860", Offset = "0x6050660", VA = "0x186051860", Slot = "6")]
			public void OnCompleted(Action NEOHCILADBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
			public void FOKKNALLMGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public BGIEMIKKBLD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly NJKPPNPIMIP CEIKCOHBGGB;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		private NJKPPNPIMIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6057FE0", Offset = "0x6056DE0", VA = "0x186057FE0", Slot = "4")]
		public EEAELKMMGLB JGAOOOJCGAG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class LMJPKMMBNMO<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public LMJPKMMBNMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3B75230", Offset = "0x3B74030", VA = "0x183B75230")]
		internal void KNJLDMFOEBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MDNPJPIMMIF<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public MDNPJPIMMIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D480E0", Offset = "0x3D46EE0", VA = "0x183D480E0")]
		internal void HKEGLKNODAK(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct NNOIGGJGOLC : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x60585B0", Offset = "0x60573B0", VA = "0x1860585B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x92F090", Offset = "0x92DE90", VA = "0x18092F090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct HODHJMNAHBJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x60558A0", Offset = "0x60546A0", VA = "0x1860558A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x92F090", Offset = "0x92DE90", VA = "0x18092F090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct CAEFECPFOAC<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x47F26F0", Offset = "0x47F14F0", VA = "0x1847F26F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x47F2860", Offset = "0x47F1660", VA = "0x1847F2860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct OEKAMBDEMND<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3EEAB00", Offset = "0x3EE9900", VA = "0x183EEAB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB370", Offset = "0x3EEA170", VA = "0x183EEB370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct BMNPICJCLKJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6051930", Offset = "0x6050730", VA = "0x186051930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6051B30", Offset = "0x6050930", VA = "0x186051B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class CDJFANGNLPB<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public CDJFANGNLPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3B75230", Offset = "0x3B74030", VA = "0x183B75230")]
		internal void KALFDKAIALM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x47F9C20", Offset = "0x47F8A20", VA = "0x1847F9C20")]
		internal void OICANIBDMFI(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct DFGGEIKFEAH<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public DFALHMGGEPN<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4F44A50", Offset = "0x4F43850", VA = "0x184F44A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4F45140", Offset = "0x4F43F40", VA = "0x184F45140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct BMOIJPHIIJM : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6051BA0", Offset = "0x60509A0", VA = "0x186051BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6052390", Offset = "0x6051190", VA = "0x186052390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct FEFABELLBGM : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x60551D0", Offset = "0x6053FD0", VA = "0x1860551D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6055710", Offset = "0x6054510", VA = "0x186055710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct MMPKJBJOENG<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3D7FC10", Offset = "0x3D7EA10", VA = "0x183D7FC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x39A7FA0", Offset = "0x39A6DA0", VA = "0x1839A7FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct IMPKAJGEENE<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x381C3F0", Offset = "0x381B1F0", VA = "0x18381C3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x36A2430", Offset = "0x36A1230", VA = "0x1836A2430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct FPPOAEAMEKI<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x362DDD0", Offset = "0x362CBD0", VA = "0x18362DDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x362E4D0", Offset = "0x362D2D0", VA = "0x18362E4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct JACDKEPKCLA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6055A80", Offset = "0x6054880", VA = "0x186055A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6055C60", Offset = "0x6054A60", VA = "0x186055C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct JFJHDENBHFJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6056130", Offset = "0x6054F30", VA = "0x186056130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x60564A0", Offset = "0x60552A0", VA = "0x1860564A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct CHPMHPONGON : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x60523F0", Offset = "0x60511F0", VA = "0x1860523F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x60526E0", Offset = "0x60514E0", VA = "0x1860526E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class OCJDEKBDAFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public OCJDEKBDAFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6058790", Offset = "0x6057590", VA = "0x186058790")]
		internal Task JCHACCEHLED(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct EPNDMMBHELG : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x60533E0", Offset = "0x60521E0", VA = "0x1860533E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6053640", Offset = "0x6052440", VA = "0x186053640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct NNEIEDFCPAP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6058370", Offset = "0x6057170", VA = "0x186058370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6058550", Offset = "0x6057350", VA = "0x186058550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct BCMFMGKOAEF : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6051470", Offset = "0x6050270", VA = "0x186051470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x60517E0", Offset = "0x60505E0", VA = "0x1860517E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct DPPAEJBHCHC : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6052740", Offset = "0x6051540", VA = "0x186052740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6052A30", Offset = "0x6051830", VA = "0x186052A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class MDJGMBOBHBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public MDJGMBOBHBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6056600", Offset = "0x6055400", VA = "0x186056600")]
		internal Task EDMIJHMGHHI(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct POGOLKPMKIN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x605A180", Offset = "0x6058F80", VA = "0x18605A180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x605A3E0", Offset = "0x60591E0", VA = "0x18605A3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct AMDAKFLCEOD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6051200", Offset = "0x6050000", VA = "0x186051200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6051380", Offset = "0x6050180", VA = "0x186051380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct JDHJEBJCNIG<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x39A8040", Offset = "0x39A6E40", VA = "0x1839A8040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x39A82A0", Offset = "0x39A70A0", VA = "0x1839A82A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct JAFFODOFJAM : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6055CC0", Offset = "0x6054AC0", VA = "0x186055CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x60560D0", Offset = "0x6054ED0", VA = "0x1860560D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? PJIAMHJNEOF;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<BCBPFABBCDG> NEFGCBIFEPA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task ICGEJNEKJGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x60542B0", Offset = "0x60530B0", VA = "0x1860542B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x25AF080", Offset = "0x25ADE80", VA = "0x1825AF080")]
	public static Task<T> PMEEMBIFNFJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x60536A0", Offset = "0x60524A0", VA = "0x1860536A0")]
	public static Task BHNBCDOPIHN(this Task LBLAAGGIDIG, CancellationToken CGFEMNMBCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x25AD550", Offset = "0x25AC350", VA = "0x1825AD550")]
	public static Task<TResult> BHNBCDOPIHN<TResult>(this Task<TResult> LBLAAGGIDIG, CancellationToken CGFEMNMBCOK) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x25ADDA0", Offset = "0x25ACBA0", VA = "0x1825ADDA0")]
	public static TaskCompletionSource<TResult> BHNBCDOPIHN<TResult>(this TaskCompletionSource<TResult> GMPCAFNHKHF, CancellationToken CGFEMNMBCOK) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6054750", Offset = "0x6053550", VA = "0x186054750")]
	[AsyncStateMachine(typeof(NNOIGGJGOLC))]
	public static void JBFHEPNEFBC(this Task LNJHGKLPHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6054200", Offset = "0x6053000", VA = "0x186054200")]
	[AsyncStateMachine(typeof(HODHJMNAHBJ))]
	public static void FNJKDODNNOF(this Task LNJHGKLPHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x25AE8F0", Offset = "0x25AD6F0", VA = "0x1825AE8F0")]
	[AsyncStateMachine(typeof(CAEFECPFOAC<>))]
	public static Task HDMAEFMNHJO<TException>(this Task LNJHGKLPHDO) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x25AEEC0", Offset = "0x25ADCC0", VA = "0x1825AEEC0")]
	[AsyncStateMachine(typeof(OEKAMBDEMND<>))]
	public static Task<T> PCGFNCDMJIB<T>(this Task<T> OJFDNDCDDBK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6055020", Offset = "0x6053E20", VA = "0x186055020")]
	[AsyncStateMachine(typeof(BMNPICJCLKJ))]
	public static Task<TaskStatus> PMDAMPMFHDB(this Task OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x25AEB80", Offset = "0x25AD980", VA = "0x1825AEB80")]
	public static (Task<T?>?, Action<T?>?) LHNDNMGGABL<T>([Optional] CancellationToken EHAEIHNIHFM)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x25AEDC0", Offset = "0x25ADBC0", VA = "0x1825AEDC0")]
	[AsyncStateMachine(typeof(DFGGEIKFEAH<, >))]
	public static Task<List<TResult>> OGDCHCGPJIP<TResult, TInput>(this Task<List<TInput>> LBLAAGGIDIG, DFALHMGGEPN<TInput, TResult> GDLIJKKFPOJ) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6054CB0", Offset = "0x6053AB0", VA = "0x186054CB0")]
	[AsyncStateMachine(typeof(BMOIJPHIIJM))]
	public static Task MHJEALCBFEO(Task LNJHGKLPHDO, CancellationToken MOIAALGAOGA, Func<CancellationToken, Task> LPIIFHIJGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6053900", Offset = "0x6052700", VA = "0x186053900")]
	[AsyncStateMachine(typeof(FEFABELLBGM))]
	public static Task CDDLEDEPMEA(Func<CancellationToken, Task> PELJLDCFJFP, TimeSpan OLPCEOCMHGC, [Optional] CancellationToken MOIAALGAOGA, [Optional] Action<OperationCanceledException>? LELHNKKDODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x25AE300", Offset = "0x25AD100", VA = "0x1825AE300")]
	[AsyncStateMachine(typeof(MMPKJBJOENG<>))]
	public static Task<T> CDDLEDEPMEA<T>(Func<CancellationToken, Task<T>> PELJLDCFJFP, TimeSpan OLPCEOCMHGC, [Optional] CancellationToken MOIAALGAOGA, [Optional] Func<OperationCanceledException, T>? LELHNKKDODD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x25AEAA0", Offset = "0x25AD8A0", VA = "0x1825AEAA0")]
	[AsyncStateMachine(typeof(IMPKAJGEENE<>))]
	public static Task<IEnumerable<Task<T>>> JDOPGMNDLKM<T>(IEnumerable<Task<T>> KGHOPJOPAHM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x25AE560", Offset = "0x25AD360", VA = "0x1825AE560")]
	[AsyncStateMachine(typeof(FPPOAEAMEKI<, , , >))]
	public static Task<(T1, T2, T3, T4)> FNBEFOLBOIH<T1, T2, T3, T4>(Task<T1> HPGCFKLILAB, Task<T2> LPPOKAKOOBI, Task<T3> LHKEGFIKIJM, Task<T4> CKGIGNJDABJ) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6053B40", Offset = "0x6052940", VA = "0x186053B40")]
	[AsyncStateMachine(typeof(JACDKEPKCLA))]
	public static Task CFLLJJCFGFG(Func<bool> HHNPNNJCGFO, [Optional] CancellationToken EHAEIHNIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6053A30", Offset = "0x6052830", VA = "0x186053A30")]
	[AsyncStateMachine(typeof(JFJHDENBHFJ))]
	public static Task CFLLJJCFGFG(Func<bool> HHNPNNJCGFO, TimeSpan LHPHKHDLCMM, [Optional] CancellationToken EHAEIHNIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6054620", Offset = "0x6053420", VA = "0x186054620")]
	[AsyncStateMachine(typeof(CHPMHPONGON))]
	public static Task IECNHFODOCI(Func<bool> HHNPNNJCGFO, TimeSpan OLPCEOCMHGC, [Optional] CancellationToken EHAEIHNIHFM, [Optional] Action<OperationCanceledException>? LELHNKKDODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x60544E0", Offset = "0x60532E0", VA = "0x1860544E0")]
	[AsyncStateMachine(typeof(EPNDMMBHELG))]
	public static Task IECNHFODOCI(Func<bool> HHNPNNJCGFO, TimeSpan OLPCEOCMHGC, TimeSpan LHPHKHDLCMM, [Optional] CancellationToken EHAEIHNIHFM, [Optional] Action<OperationCanceledException>? LELHNKKDODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6053D40", Offset = "0x6052B40", VA = "0x186053D40")]
	[AsyncStateMachine(typeof(NNEIEDFCPAP))]
	public static Task CGPDPBFJOFG(Func<bool> HHNPNNJCGFO, [Optional] CancellationToken EHAEIHNIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6053C30", Offset = "0x6052A30", VA = "0x186053C30")]
	[AsyncStateMachine(typeof(BCMFMGKOAEF))]
	public static Task CGPDPBFJOFG(Func<bool> HHNPNNJCGFO, TimeSpan LHPHKHDLCMM, [Optional] CancellationToken EHAEIHNIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6054940", Offset = "0x6053740", VA = "0x186054940")]
	[AsyncStateMachine(typeof(DPPAEJBHCHC))]
	public static Task JCEJDFBJEFE(Func<bool> HHNPNNJCGFO, TimeSpan OLPCEOCMHGC, [Optional] CancellationToken EHAEIHNIHFM, [Optional] Action<OperationCanceledException>? LELHNKKDODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6054800", Offset = "0x6053600", VA = "0x186054800")]
	[AsyncStateMachine(typeof(POGOLKPMKIN))]
	public static Task JCEJDFBJEFE(Func<bool> HHNPNNJCGFO, TimeSpan OLPCEOCMHGC, TimeSpan LHPHKHDLCMM, [Optional] CancellationToken EHAEIHNIHFM, [Optional] Action<OperationCanceledException>? LELHNKKDODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6054320", Offset = "0x6053120", VA = "0x186054320")]
	[AsyncStateMachine(typeof(AMDAKFLCEOD))]
	[Obsolete]
	public static Task GKKLGMIAFHJ(this Task LBLAAGGIDIG, Action BGJFGCKAGGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x25AE800", Offset = "0x25AD600", VA = "0x1825AE800")]
	[Obsolete]
	[AsyncStateMachine(typeof(JDHJEBJCNIG<>))]
	public static Task GKKLGMIAFHJ<T>(this Task<T> LBLAAGGIDIG, Action<T> BGJFGCKAGGL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6054F70", Offset = "0x6053D70", VA = "0x186054F70")]
	private static void PIKOOCDIPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6053E30", Offset = "0x6052C30", VA = "0x186053E30")]
	public static bool DKHJKKLJHGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6054DE0", Offset = "0x6053BE0", VA = "0x186054DE0")]
	private static void OFNLKHJJMEB(SynchronizationContext MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6054B90", Offset = "0x6053990", VA = "0x186054B90")]
	private static void LEPPFOGAGGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6054AC0", Offset = "0x60538C0", VA = "0x186054AC0")]
	public static void KDIJFGEKPOK([Optional] string? EKPMNNKLPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x60541B0", Offset = "0x6052FB0", VA = "0x1860541B0")]
	public static NDPPHOLAJLJ FBNIKKCNPPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6054A70", Offset = "0x6053870", VA = "0x186054A70")]
	public static NDPPHOLAJLJ JNACDJLHCNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6054410", Offset = "0x6053210", VA = "0x186054410")]
	[AsyncStateMachine(typeof(JAFFODOFJAM))]
	public static Task HCJPPDEBGIP(Func<Task> OLKLBJAAOHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class PKGEGEFCLOO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
	public PKGEGEFCLOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class ENJOPNDNNCF : JLHLIMBBEGG
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly JLHLIMBBEGG CEIKCOHBGGB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime HPBBJBEGMEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x60532C0", Offset = "0x60520C0", VA = "0x1860532C0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset NJAOCDPEGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6053300", Offset = "0x6052100", VA = "0x186053300", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public ENJOPNDNNCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface JLHLIMBBEGG
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime HPBBJBEGMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset NJAOCDPEGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class EIBEDPADPEE
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long BGEPJGMBOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6052EB0", Offset = "0x6051CB0", VA = "0x186052EB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long JDPPIDLFABJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6052CF0", Offset = "0x6051AF0", VA = "0x186052CF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double EHGDPPCNPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6052E60", Offset = "0x6051C60", VA = "0x186052E60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double KEPPEPAILOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6052C10", Offset = "0x6051A10", VA = "0x186052C10")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double MLCIIELLMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6052E10", Offset = "0x6051C10", VA = "0x186052E10")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double JGCKEBAPNHG
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6052FA0", Offset = "0x6051DA0", VA = "0x186052FA0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6052B80", Offset = "0x6051980", VA = "0x186052B80")]
	public static double HEKDOMKKGML(long MBKJMGNGMPF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6052C60", Offset = "0x6051A60", VA = "0x186052C60")]
	public static double HMDLHKIJMAL(long MBKJMGNGMPF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6052F00", Offset = "0x6051D00", VA = "0x186052F00")]
	public static double OJCINIMCDPE(double BAJAMGKBKCB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6052A90", Offset = "0x6051890", VA = "0x186052A90")]
	public static long BLKHBBFFHLB(long JILOLFHINNI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6052F90", Offset = "0x6051D90", VA = "0x186052F90")]
	public static long PKDLGEOCFOF(long PNKJBPNKGLP, long LOGMPJPBKGD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6052D40", Offset = "0x6051B40", VA = "0x186052D40")]
	public static double JEBNCCFBDAJ(long PNKJBPNKGLP, long LOGMPJPBKGD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6052B20", Offset = "0x6051920", VA = "0x186052B20")]
	public static double FMCHJKGEOIM(long PNKJBPNKGLP, long LOGMPJPBKGD)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class PPPEBHIAJJE : KNMEAAFEPLN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan AEHHFAKOFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer LJNGGJLINNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan OLPCEOCMHGC;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan IEHIBLMACKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x605A610", Offset = "0x6059410", VA = "0x18605A610", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? NPOEBIFLLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x78E1A0", Offset = "0x78CFA0", VA = "0x18078E1A0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x605AAD0", Offset = "0x60598D0", VA = "0x18605AAD0")]
	[Preserve]
	public PPPEBHIAJJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x605A880", Offset = "0x6059680", VA = "0x18605A880")]
	public PPPEBHIAJJE(TimeSpan OLPCEOCMHGC, [Optional] Action? IGGMABJMBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x605A580", Offset = "0x6059380", VA = "0x18605A580", Slot = "7")]
	public void HKKNIOFHBCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x605A7A0", Offset = "0x60595A0", VA = "0x18605A7A0", Slot = "8")]
	public void MJLJKHLICAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x605A770", Offset = "0x6059570", VA = "0x18605A770", Slot = "9")]
	public void LGOAPCHIGOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xB97B40", Offset = "0xB96940", VA = "0x180B97B40")]
	private void MJLPNAMAABJ(object JFLBCAAFGDD, ElapsedEventArgs APLCIGBFIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x605A440", Offset = "0x6059240", VA = "0x18605A440")]
	private static void AMBBHAFBNDM(TimeSpan ILEKBNLCFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x605A4E0", Offset = "0x60592E0", VA = "0x18605A4E0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class GEKBGODLFAH : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string HDAGEJEGJAK;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7B9560", Offset = "0x7B8360", VA = "0x1807B9560")]
	public GEKBGODLFAH(string HPIOGAHIMCG)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct PCDNIBOGHJM : IEquatable<PCDNIBOGHJM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public uint EBDNFLCANNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public int BCCEGNDMLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public float LPEFJHFAGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public ushort HOKHACIDGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort BPODECCNCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public short FHDFBGGILGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short LGHMCIDNNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public char PACOAPHNKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char LHKONIHGOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public byte EDFIBJNMJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte GAFMJABMNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte EDPEOADONHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte NBHJIOGKDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public bool EIBAEBKBBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool PFJGMEJGHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool BCGHDEEMBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool MCHHNFBBEOH;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xD816E0", Offset = "0xD804E0", VA = "0x180D816E0")]
	public static PCDNIBOGHJM BHEMLOAIBBH(uint NEMMBCJPPKJ)
	{
		return default(PCDNIBOGHJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xD816E0", Offset = "0xD804E0", VA = "0x180D816E0")]
	public static PCDNIBOGHJM DJDCJPDPBPF(int NDNEPKEJDOH)
	{
		return default(PCDNIBOGHJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6059330", Offset = "0x6058130", VA = "0x186059330")]
	public static PCDNIBOGHJM MLPKPBOHBCA(float EABFDGGGGIM)
	{
		return default(PCDNIBOGHJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6059290", Offset = "0x6058090", VA = "0x186059290")]
	public static PCDNIBOGHJM GHHPONFNFHI(byte IEEAKCCKPDJ, byte EPJIJGFDOHA, byte IKHHHHIMHGE, byte CEGALOBCBIE)
	{
		return default(PCDNIBOGHJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6059290", Offset = "0x6058090", VA = "0x186059290")]
	public static PCDNIBOGHJM DJPNGGLHABO(bool FPILEEJGMAA, bool DPEFPJOAINB, bool JEPKKJKNLLK, bool JIHAHMGDJCI)
	{
		return default(PCDNIBOGHJM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x175A3A0", Offset = "0x17591A0", VA = "0x18175A3A0")]
	public static bool KFENMBPPCHH(PCDNIBOGHJM LBKCGMCBJAD, PCDNIBOGHJM LEFACNCEBHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x80F5F0", Offset = "0x80E3F0", VA = "0x18080F5F0", Slot = "4")]
	public bool Equals(PCDNIBOGHJM GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x60592B0", Offset = "0x60580B0", VA = "0x1860592B0", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x8A9AC0", Offset = "0x8A88C0", VA = "0x1808A9AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6059340", Offset = "0x6058140", VA = "0x186059340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct PNKJNFIFFGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public ulong MBOGHAODNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public long IBILCIBAFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public double CGHLGNBCJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint KHOODELPHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint ECOJHJMNCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public int GKBANMCPPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int GNDEIFLCEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public float IEIOJGCCCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float LBKIJMLBIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public ushort HOKHACIDGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort BPODECCNCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort IJJHOABJIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort AHHHMPIPNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short FHDFBGGILGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short LGHMCIDNNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short IPNKDECEJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short KCBCCBLMALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public char PACOAPHNKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char LHKONIHGOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char FDIMDFNALLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char OPNMDHCOCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte EDFIBJNMJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte GAFMJABMNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte EDPEOADONHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte NBHJIOGKDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte DOPBBPNINEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte GIOJCCPNJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte INLMDKNJNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte CAJGDJGFGMI;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x605A130", Offset = "0x6058F30", VA = "0x18605A130")]
	public static PNKJNFIFFGN DCPHPAHCOGO(byte IEEAKCCKPDJ, byte EPJIJGFDOHA, byte IKHHHHIMHGE, byte CEGALOBCBIE, byte NOICFFCIPME, byte DCBFKDONGJC, byte ODAPHNNEKKH, byte LJFJNJNCKNN)
	{
		return default(PNKJNFIFFGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class FIIENDJMJNC
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x25B0E70", Offset = "0x25AFC70", VA = "0x1825B0E70")]
	public static IEnumerable<T> POHNCBEMIJC<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80")]
	public static T[] MEBKFFEACJA<T>(params T[] FPIIOEHMLPA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80")]
	public static IEnumerable<T> POLKCAELNHK<T>(params T[] FPIIOEHMLPA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2491650", Offset = "0x2490450", VA = "0x182491650")]
	public static HashSet<T> KKDLIFCGOMG<T>(params T[] FPIIOEHMLPA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x25B0D80", Offset = "0x25AFB80", VA = "0x1825B0D80")]
	public static KeyValuePair<TKey, TValue> MDFBJMGKCNB<TKey, TValue>([In] TKey IDGIKKEFDCG, [In] TValue MBDKMNBCLGF) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2491650", Offset = "0x2490450", VA = "0x182491650")]
	public static List<T> FLGNNLMPNKP<T>(IEnumerable<T> PNAEPBNICFF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[AttributeUsage(AttributeTargets.All)]
public sealed class GNFOODCHCCM : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly string PDOLMKCAJOM;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7B9560", Offset = "0x7B8360", VA = "0x1807B9560")]
	public GNFOODCHCCM(string IHMOGBFCKIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate object FGHBHPKFJHA<T>([In] T DJELKPGJPKM);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate object GMJHCAEAHHB<T>(T DJELKPGJPKM);
[Cpp2IlInjected.Token(Token = "0x2000054")]
[LIDGOKNFOGD]
public delegate string FNKPAGJJPFJ(string ELALCBMPIFC, string? FJPACLEAEGP, bool GIOLONMIGFC);
[Cpp2IlInjected.Token(Token = "0x2000055")]
[LIDGOKNFOGD]
public delegate void FFDOLLLJABO(string EKPMNNKLPFJ);
[Cpp2IlInjected.Token(Token = "0x2000056")]
[LIDGOKNFOGD]
public delegate void AHIKAFHHPHH(Exception ANBLKCIIIFD);
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate object NDCBPCNGEAI();
[Cpp2IlInjected.Token(Token = "0x2000058")]
[LIDGOKNFOGD]
public delegate bool LCPFDHFEIIM();
[Cpp2IlInjected.Token(Token = "0x2000059")]
[LIDGOKNFOGD]
public delegate string EGINPNDHBLD(object FGANJEAKCMA);
[Cpp2IlInjected.Token(Token = "0x200005A")]
[AttributeUsage(AttributeTargets.Enum)]
public class DMCGJODPNKE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
	public DMCGJODPNKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class KECBAMAPFNC
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private sealed class NHFKLNFOKEO<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public static readonly ISet<T> CEIKCOHBGGB;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int OBAHNCBLFMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x790850", Offset = "0x78F650", VA = "0x180790850", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x7A9270", Offset = "0x7A8070", VA = "0x1807A9270", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3DF4320", Offset = "0x3DF3120", VA = "0x183DF4320", Slot = "4")]
		public bool Add(T KMBHPJEIFIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "6")]
		public void IntersectWith(IEnumerable<T> GDMGBCDFBAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3DF4550", Offset = "0x3DF3350", VA = "0x183DF4550", Slot = "5")]
		public void UnionWith(IEnumerable<T> GDMGBCDFBAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3DF4400", Offset = "0x3DF3200", VA = "0x183DF4400", Slot = "9")]
		void ICollection<T>.Add(T KMBHPJEIFIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "11")]
		public bool Contains(T KMBHPJEIFIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "12")]
		public void CopyTo(T[] IPODKPLEDFE, int BKFPMJOKOEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
		public bool Remove(T KMBHPJEIFIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3DF4380", Offset = "0x3DF3180", VA = "0x183DF4380", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x35F0390", Offset = "0x35EF190", VA = "0x1835F0390", Slot = "15")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public NHFKLNFOKEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x81D560", Offset = "0x81C360", VA = "0x18081D560")]
	public static ISet<T> DEKEPMNDDKL<T>() where T : notnull
	{
		return null;
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
