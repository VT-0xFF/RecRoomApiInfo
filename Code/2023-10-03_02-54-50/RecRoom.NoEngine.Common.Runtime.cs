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
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D1AF60", Offset = "0x5D19760", VA = "0x185D1AF60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C320", Offset = "0x78AB20", VA = "0x18078C320")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78C360", Offset = "0x78AB60", VA = "0x18078C360")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class BGCDHOANLMP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D16E80", Offset = "0x5D15680", VA = "0x185D16E80")]
	public BGCDHOANLMP(bool LOENPNFDJFK, string JCHNOENDBHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JBOLDMLCCHK<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> GKCLENHEEDA(CancellationToken NCEIDHNHODH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct CPIGILDFOCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public JBOLDMLCCHK<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public GKCLENHEEDA taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x4B01420", Offset = "0x4AFFC20", VA = "0x184B01420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4B02460", Offset = "0x4B00C60", VA = "0x184B02460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource OOKDIBNEDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? MLOJKIIAGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? LBEPBADONMB;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3832230", Offset = "0x3830A30", VA = "0x183832230")]
	[AsyncStateMachine(typeof(JBOLDMLCCHK<>.CPIGILDFOCH))]
	public Task<TResult> KIILMJBJFLL(GKCLENHEEDA PKCHKALCBOI, [Optional] CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x38321C0", Offset = "0x38309C0", VA = "0x1838321C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3832370", Offset = "0x3830B70", VA = "0x183832370")]
	public JBOLDMLCCHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class CJKAGFNJDIG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> MHHNFEKLGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T GNAEIIEFOAF;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3DA7220", Offset = "0x3DA5A20", VA = "0x183DA7220")]
	public CJKAGFNJDIG([In] T IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A58260", Offset = "0x4A56A60", VA = "0x184A58260", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4A587F0", Offset = "0x4A56FF0", VA = "0x184A587F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4A58910", Offset = "0x4A57110", VA = "0x184A58910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class NIGCOHNCHEO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
	public NIGCOHNCHEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class CNPEGLLENCJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
	public CNPEGLLENCJ(string MKENGALIIIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DFHCNADGHKN
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2229890", Offset = "0x2228090", VA = "0x182229890")]
	public static ECHCHECCMNK ICCIODLKNDI<T>()
	{
		return default(ECHCHECCMNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2229AE0", Offset = "0x22282E0", VA = "0x182229AE0")]
	public static ECHCHECCMNK PBNJAEPBDMD<T>([CallerMemberName] string BOBHOMKFHJB = "") where T : notnull
	{
		return default(ECHCHECCMNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2229810", Offset = "0x2228010", VA = "0x182229810")]
	public static ECHCHECCMNK ICCIODLKNDI<T>(this T JJPCCHMLAMH) where T : notnull
	{
		return default(ECHCHECCMNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x22296C0", Offset = "0x2227EC0", VA = "0x1822296C0")]
	public static ECHCHECCMNK EIPPCILHAJK<T>(this T JJPCCHMLAMH, [CallerMemberName] string BOBHOMKFHJB = "") where T : notnull
	{
		return default(ECHCHECCMNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2229A40", Offset = "0x2228240", VA = "0x182229A40")]
	public static ECHCHECCMNK PBNJAEPBDMD<T>(this T CLEGCKJMIEA, [CallerMemberName] string BOBHOMKFHJB = "") where T : notnull
	{
		return default(ECHCHECCMNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D16FF0", Offset = "0x5D157F0", VA = "0x185D16FF0")]
	public static ECHCHECCMNK PBNJAEPBDMD(string DJDMJOKDACC, [CallerMemberName] string BOBHOMKFHJB = "")
	{
		return default(ECHCHECCMNK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D16F50", Offset = "0x5D15750", VA = "0x185D16F50")]
	public static string INHJLHHPHJJ(this object CLEGCKJMIEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[NIGCOHNCHEO]
public delegate long FELJOJDOFIG();
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FAJDKKNBMPI
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static HOPPEBHACBL KOAIFOMBCDL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static HOPPEBHACBL GIEKGPJPNAI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D184C0", Offset = "0x5D16CC0", VA = "0x185D184C0")]
		get
		{
			return default(HOPPEBHACBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static MHLICHMDAOB KCEDIOBNHNF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5D18040", Offset = "0x5D16840", VA = "0x185D18040")]
		get
		{
			return default(MHLICHMDAOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static HHIIIPLPDNO DAGAMPEHJEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5D181E0", Offset = "0x5D169E0", VA = "0x185D181E0")]
		get
		{
			return default(HHIIIPLPDNO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D182D0", Offset = "0x5D16AD0", VA = "0x185D182D0")]
	public static void LFEBMAEHDDB([In] HOPPEBHACBL NHCBLLOJNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D185B0", Offset = "0x5D16DB0", VA = "0x185D185B0")]
	public static void OPCGADAFALC(string LACIBLEADOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D18680", Offset = "0x5D16E80", VA = "0x185D18680")]
	public static void PPNGJCPFMDM(string LACIBLEADOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x235D150", Offset = "0x235B950", VA = "0x18235D150")]
	public static void PPNGJCPFMDM<T>(T EIMPEEDPEPM, PGPFGHNAJDJ<T> LACIBLEADOC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D18230", Offset = "0x5D16A30", VA = "0x185D18230")]
	public static void KKHHGMHFEEG(Exception DCJGKNPOAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D18090", Offset = "0x5D16890", VA = "0x185D18090")]
	public static string INHJLHHPHJJ(object ELOCHLKHPBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D18450", Offset = "0x5D16C50", VA = "0x185D18450")]
	public static long NDBPHFGGBDN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D18510", Offset = "0x5D16D10", VA = "0x185D18510")]
	public static bool OIGNJMMKNHM(bool DMIHLCIKLML, string LACIBLEADOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D18110", Offset = "0x5D16910", VA = "0x185D18110")]
	public static double JPBJNMMAFHG()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct HOPPEBHACBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly MHLICHMDAOB KCEDIOBNHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly HHIIIPLPDNO DAGAMPEHJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly PLMNHELCOHN NPCACHDFOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly FELJOJDOFIG HFNGMNBFFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly LHIMFJFPHCK HGJAOLCNMFI;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly PLMNHELCOHN MDKKAKIFINH;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly FELJOJDOFIG CIGPLBCIFBF;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly LHIMFJFPHCK FBMLBAMDGMD;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly HOPPEBHACBL FNKJEGINCPG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LGKDCANGALE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5D18DC0", Offset = "0x5D175C0", VA = "0x185D18DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D19520", Offset = "0x5D17D20", VA = "0x185D19520")]
	public HOPPEBHACBL([In] MHLICHMDAOB HOIPMHEFCHM, [In] HHIIIPLPDNO AIHEAGNJNNN, PLMNHELCOHN FJKKDMPNPFC, FELJOJDOFIG NNBHPBPIOCN, LHIMFJFPHCK CJINBJHPLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D18F20", Offset = "0x5D17720", VA = "0x185D18F20")]
	private static string IOEIFDMCJJC(object ELOCHLKHPBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x761FD0", Offset = "0x7607D0", VA = "0x180761FD0")]
	private static long JPHFFCNINJK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0")]
	private static string NNKHHLLCIPC(string HMGMLNHCJJK, string? CGLHBJFJMPA, bool BEGDADJBFPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5D18CC0", Offset = "0x5D174C0", VA = "0x185D18CC0")]
	private static HOPPEBHACBL COCLCHKLKNN()
	{
		return default(HOPPEBHACBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LKPADMBBDIC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNNKBIKNDJH([In] T GHNNCJBDHKF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void BMLEOHLIOJD<T>([In] T EIMPEEDPEPM);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct IKFJEEOEEHF<T> : IEquatable<IKFJEEOEEHF<T>>, LKPADMBBDIC<IKFJEEOEEHF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly T GNAEIIEFOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly int DIEGBKIOLGK;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1C437F0", Offset = "0x1C41FF0", VA = "0x181C437F0")]
	public IKFJEEOEEHF([In] T IFKKLLBODIE, int ADMJKDLHPCI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3667320", Offset = "0x3665B20", VA = "0x183667320")]
	public static bool PEFPHNLEPOM([In] IKFJEEOEEHF<T> MANEBEMOKEE, [In] IKFJEEOEEHF<T> HOCFNIKGEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x36662D0", Offset = "0x3664AD0", VA = "0x1836662D0", Slot = "4")]
	public bool Equals(IKFJEEOEEHF<T> GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3658A90", Offset = "0x3657290", VA = "0x183658A90", Slot = "0")]
	public override bool Equals(object GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3666240", Offset = "0x3664A40", VA = "0x183666240")]
	public bool BNNKBIKNDJH([In] IKFJEEOEEHF<T> GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3666790", Offset = "0x3664F90", VA = "0x183666790", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3667A30", Offset = "0x3666230", VA = "0x183667A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3666A90", Offset = "0x3665290", VA = "0x183666A90")]
	public void IDOGKACACAK([Out] T IFKKLLBODIE, [Out] int ADMJKDLHPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3667060", Offset = "0x3665860", VA = "0x183667060")]
	public (T, int) NENBDCLAFOO()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3666820", Offset = "0x3665020", VA = "0x183666820", Slot = "5")]
	private bool HMLFDEBJGLF([In] IKFJEEOEEHF<T> GHNNCJBDHKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IBAGCLOPION
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x23EE720", Offset = "0x23ECF20", VA = "0x1823EE720")]
	public static IKFJEEOEEHF<T> MJLGMKKAMEE<T>([In] T IFKKLLBODIE, int ADMJKDLHPCI) where T : notnull
	{
		return default(IKFJEEOEEHF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BFFBPANKOLD
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x218E650", Offset = "0x218CE50", VA = "0x18218E650")]
	public static bool BNNKBIKNDJH<T, U>([In] T CLEGCKJMIEA, [In] U ELOCHLKHPBP) where T : notnull, LKPADMBBDIC<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate TResult AIDDIEFFMPL<T, out TResult>([In] T EIMPEEDPEPM);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public delegate TResult EPDNMLDMKDJ<T1, T2, out TResult>([In] T1 EEBAFGMJPPG, [In] T2 ILKNPMMLDNO);
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HANJIPAILKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	TimeSpan PGCCKGFKFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Action? IFANGGGNGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KCFNLKKNBID();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BBELDIIBFLE();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IJIJBPICEAF();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct MHLICHMDAOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly NEDONMNFEHG PGEAAOAGJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly BNPKKLHECHF PLPFJBMCOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly NEDONMNFEHG PCLGJONLKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly BNPKKLHECHF OMGKIIIONOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly NEDONMNFEHG BBJDAJOFKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly BNPKKLHECHF JKCEDIMIFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly OBLAGJOGKDD NCGDNNCDCJJ;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly NEDONMNFEHG CKBLJDIOODL;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly BNPKKLHECHF EBPEAHAHHNJ;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly NEDONMNFEHG JMHNNCFEAMA;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly BNPKKLHECHF NBPOMEAGPLI;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly NEDONMNFEHG HLKNNNIJFPF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly BNPKKLHECHF HNIPFJEPHNH;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly OBLAGJOGKDD HIDECDMBOBA;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly MHLICHMDAOB FNKJEGINCPG;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly NEDONMNFEHG CBOCIHEILJM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool LGKDCANGALE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A070", Offset = "0x5D18870", VA = "0x185D1A070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x86C930", Offset = "0x86B130", VA = "0x18086C930")]
	public MHLICHMDAOB(NEDONMNFEHG HDIGNONKNFH, BNPKKLHECHF MLBNOOJPOFB, NEDONMNFEHG GDCAGJKKFNE, BNPKKLHECHF BBABJNMIIBH, NEDONMNFEHG KHPHNLFMKGG, BNPKKLHECHF JLNCFDBANIH, OBLAGJOGKDD DJPNPPKLCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0")]
	private static bool KJKONDHLCNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void PKBEBPHOFBB(string LACIBLEADOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0")]
	private static bool BEGLLIMAHKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void IMPLNONHDHJ(string LACIBLEADOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0")]
	private static bool LMJIDFGPJME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void OCNBLDFKBKF(string LACIBLEADOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void EDGJPAEHDEA(Exception DCJGKNPOAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5D19F30", Offset = "0x5D18730", VA = "0x185D19F30")]
	private static MHLICHMDAOB COCLCHKLKNN()
	{
		return default(MHLICHMDAOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x77C260", Offset = "0x77AA60", VA = "0x18077C260")]
	private static bool MNKKEEFLDNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A340", Offset = "0x5D18B40", VA = "0x185D1A340")]
	public void OPCGADAFALC(object LACIBLEADOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A490", Offset = "0x5D18C90", VA = "0x185D1A490")]
	public void PPNGJCPFMDM(object LACIBLEADOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FF55D0", Offset = "0x1FF3DD0", VA = "0x181FF55D0")]
	public void KKHHGMHFEEG(Exception DCJGKNPOAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A3B0", Offset = "0x5D18BB0", VA = "0x185D1A3B0")]
	public void PPNGJCPFMDM(BHOFGOJFGBF LACIBLEADOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x246F470", Offset = "0x246DC70", VA = "0x18246F470")]
	public void PPNGJCPFMDM<T>(T EIMPEEDPEPM, PGPFGHNAJDJ<T> LACIBLEADOC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x246F230", Offset = "0x246DA30", VA = "0x18246F230")]
	public void OPCGADAFALC<T>([In] T EIMPEEDPEPM, NIECBGOMCIN<T> LACIBLEADOC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A270", Offset = "0x5D18A70", VA = "0x185D1A270")]
	public bool OIGNJMMKNHM(bool DMIHLCIKLML, string LACIBLEADOC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct ECHCHECCMNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string GNAEIIEFOAF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8C0", Offset = "0x7EC0C0", VA = "0x1807ED8C0")]
	public ECHCHECCMNK(string IFKKLLBODIE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
	public static string DAOGIJOJDNF([In] ECHCHECCMNK CLEGCKJMIEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x12BAA80", Offset = "0x12B9280", VA = "0x1812BAA80")]
	public static ECHCHECCMNK DAOGIJOJDNF(string GHNNCJBDHKF)
	{
		return default(ECHCHECCMNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5D17070", Offset = "0x5D15870", VA = "0x185D17070")]
	public string AMJMHPHHDBO(string PCMCMJMNHLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D170C0", Offset = "0x5D158C0", VA = "0x185D170C0")]
	public string JBFNMKDPIDJ(object AACKMGILGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct NLDGBPLBGDN : IEquatable<NLDGBPLBGDN>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x77C260", Offset = "0x77AA60", VA = "0x18077C260", Slot = "4")]
	public bool Equals(NLDGBPLBGDN GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AE10", Offset = "0x5D19610", VA = "0x185D1AE10", Slot = "0")]
	public override bool Equals(object GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AE60", Offset = "0x5D19660", VA = "0x185D1AE60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AE70", Offset = "0x5D19670", VA = "0x185D1AE70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[FHLNHECHJJE("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct OCIMHDHLOGG<T> : IEquatable<OCIMHDHLOGG<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly T GNAEIIEFOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool ALPDIAENPGG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PDFADFDKJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3D79BB0", Offset = "0x3D783B0", VA = "0x183D79BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3D7A2D0", Offset = "0x3D78AD0", VA = "0x183D7A2D0")]
	public OCIMHDHLOGG([In] T IFKKLLBODIE, bool LJMOEOANGMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3D79BC0", Offset = "0x3D783C0", VA = "0x183D79BC0")]
	public static bool PEFPHNLEPOM([In] OCIMHDHLOGG<T> MANEBEMOKEE, [In] OCIMHDHLOGG<T> HOCFNIKGEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x36662D0", Offset = "0x3664AD0", VA = "0x1836662D0", Slot = "4")]
	public bool Equals(OCIMHDHLOGG<T> GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3D79450", Offset = "0x3D77C50", VA = "0x183D79450", Slot = "0")]
	public override bool Equals(object GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3D79920", Offset = "0x3D78120", VA = "0x183D79920", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3D7A1D0", Offset = "0x3D789D0", VA = "0x183D7A1D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class DHINMLGNGIP
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x222A6E0", Offset = "0x2228EE0", VA = "0x18222A6E0")]
	public static OCIMHDHLOGG<T> PLLOKDCLAMA<T>([In] T IFKKLLBODIE) where T : notnull
	{
		return default(OCIMHDHLOGG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x222A5B0", Offset = "0x2228DB0", VA = "0x18222A5B0")]
	public static OCIMHDHLOGG<T?> JOEDKEBHBAN<T>()
	{
		return default(OCIMHDHLOGG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x222A4F0", Offset = "0x2228CF0", VA = "0x18222A4F0")]
	public static bool BJOBMKBGGGC<T>([In] this OCIMHDHLOGG<T> CDPFPOOMHFD, [Out][NotNullWhen(true)] T IFKKLLBODIE) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct HHIIIPLPDNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly GGKEMEMBEDP ECDDDIOOOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly DNPANAFFBJM LAPIMILBNAC;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly GGKEMEMBEDP ELBMFNPHJJK;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly DNPANAFFBJM CIAPLOLGGIG;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly HHIIIPLPDNO FNKJEGINCPG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LGKDCANGALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5D188E0", Offset = "0x5D170E0", VA = "0x185D188E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7F41F0", Offset = "0x7F29F0", VA = "0x1807F41F0")]
	public HHIIIPLPDNO(GGKEMEMBEDP CHEOFIELMAN, DNPANAFFBJM DHAGFDCJAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void PINEPCIKGKK(string BOBHOMKFHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void CALJOICMEKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D18850", Offset = "0x5D17050", VA = "0x185D18850")]
	private static HHIIIPLPDNO COCLCHKLKNN()
	{
		return default(HHIIIPLPDNO);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class MKPICIFBFKG
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate bool CBJLGPPIPKH<in TInput, TResult>(TInput EJAHENBAJFL, [Out] TResult PGNGICAKGGE);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class EEMBIGMLBGK<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public EEMBIGMLBGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2FF3B10", Offset = "0x2FF2310", VA = "0x182FF3B10")]
		internal void FJKGEEMEOCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class FCLIEIIMICG<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public FCLIEIIMICG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x33746D0", Offset = "0x3372ED0", VA = "0x1833746D0")]
		internal void ADCDCBBJHPO(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct ALGONEFGMHG<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public CBJLGPPIPKH<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x36C1D30", Offset = "0x36C0530", VA = "0x1836C1D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x36C2420", Offset = "0x36C0C20", VA = "0x1836C2420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct MHLBMPNFKKN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5D19CC0", Offset = "0x5D184C0", VA = "0x185D19CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5D19EC0", Offset = "0x5D186C0", VA = "0x185D19EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AAE0", Offset = "0x5D192E0", VA = "0x185D1AAE0")]
	public static Task<TaskStatus> KGOCIBKIOKK(this Task CLEGCKJMIEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x24720E0", Offset = "0x24708E0", VA = "0x1824720E0")]
	public static Task<T> BHCNNDKJPIO<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5D1ABD0", Offset = "0x5D193D0", VA = "0x185D1ABD0")]
	public static Task NGKNLOCEBCE(this Task DGINPAIAOMP, CancellationToken PIPCHJCEPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2473BD0", Offset = "0x24723D0", VA = "0x182473BD0")]
	public static Task<TResult> NGKNLOCEBCE<TResult>(this Task<TResult> DGINPAIAOMP, CancellationToken PIPCHJCEPPJ) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x24743C0", Offset = "0x2472BC0", VA = "0x1824743C0")]
	public static TaskCompletionSource<TResult> NGKNLOCEBCE<TResult>(this TaskCompletionSource<TResult> NAACIMLIADP, CancellationToken PIPCHJCEPPJ) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2472230", Offset = "0x2470A30", VA = "0x182472230")]
	[AsyncStateMachine(typeof(ALGONEFGMHG<, >))]
	public static Task<List<TResult>> DBFCKCKIFGD<TResult, TInput>(this Task<List<TInput>> DGINPAIAOMP, CBJLGPPIPKH<TInput, TResult> KMPCIJDEELO) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AAE0", Offset = "0x5D192E0", VA = "0x185D1AAE0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(MHLBMPNFKKN))]
	internal static Task<TaskStatus> GEEDEDKHODH(Task POAGBHOPGOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class BGCFDHAOKNC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
	public BGCFDHAOKNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class NOMNFEPAPNJ : GBGJCDHBKNF
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly GBGJCDHBKNF LNAOMADBHGP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DateTime AKMDBAJHEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5D1AEA0", Offset = "0x5D196A0", VA = "0x185D1AEA0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public NOMNFEPAPNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface GBGJCDHBKNF
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime AKMDBAJHEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class PBFGPOABBMA
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long CFEOECMIJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5D1AFE0", Offset = "0x5D197E0", VA = "0x185D1AFE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static long BHPFNEDCIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B210", Offset = "0x5D19A10", VA = "0x185D1B210")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static double PPBCCIMDGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B260", Offset = "0x5D19A60", VA = "0x185D1B260")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static double HMDONNOOOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B1B0", Offset = "0x5D199B0", VA = "0x185D1B1B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static double NMNAKNMPECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B3D0", Offset = "0x5D19BD0", VA = "0x185D1B3D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static double KGCGDLDBKCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B380", Offset = "0x5D19B80", VA = "0x185D1B380")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B030", Offset = "0x5D19830", VA = "0x185D1B030")]
	public static double BOPDDJEHDHA(long DJNGPNEAGCN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B0C0", Offset = "0x5D198C0", VA = "0x185D1B0C0")]
	public static double CLFNDGGPDPA(long DJNGPNEAGCN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B420", Offset = "0x5D19C20", VA = "0x185D1B420")]
	public static double LNNJPKNILDJ(double PJAPADDDFBL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B4B0", Offset = "0x5D19CB0", VA = "0x185D1B4B0")]
	public static long OEJIKMDOFLJ(long CDJDJMPLMGP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B200", Offset = "0x5D19A00", VA = "0x185D1B200")]
	public static long DGJOGNBICBO(long EABHOKJHBIP, long MKACCIFJDLB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B2B0", Offset = "0x5D19AB0", VA = "0x185D1B2B0")]
	public static double GKKPMIHPCNA(long EABHOKJHBIP, long MKACCIFJDLB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B150", Offset = "0x5D19950", VA = "0x185D1B150")]
	public static double COGJHJGDAJB(long EABHOKJHBIP, long MKACCIFJDLB)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class KONNDLMKHJH : HANJIPAILKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly TimeSpan KOIFKAAIMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly System.Timers.Timer HCIPJNOFOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private TimeSpan EMAKFGFOEMJ;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TimeSpan PGCCKGFKFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5D19790", Offset = "0x5D17F90", VA = "0x185D19790", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Action? IFANGGGNGBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x762B90", Offset = "0x761390", VA = "0x180762B90", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5D19A00", Offset = "0x5D18200", VA = "0x185D19A00")]
	[Preserve]
	public KONNDLMKHJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5D19A70", Offset = "0x5D18270", VA = "0x185D19A70")]
	public KONNDLMKHJH(TimeSpan EMAKFGFOEMJ, [Optional] Action? BLEKJCBBNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D19700", Offset = "0x5D17F00", VA = "0x185D19700", Slot = "7")]
	public void KCFNLKKNBID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D195C0", Offset = "0x5D17DC0", VA = "0x185D195C0", Slot = "8")]
	public void BBELDIIBFLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D196D0", Offset = "0x5D17ED0", VA = "0x185D196D0", Slot = "9")]
	public void IJIJBPICEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0xAAFC30", Offset = "0xAAE430", VA = "0x180AAFC30")]
	private void GFPMKPLHADA(object JJPCCHMLAMH, ElapsedEventArgs PDEFKDCKNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D198F0", Offset = "0x5D180F0", VA = "0x185D198F0")]
	private static void OCDJKAMPJMA(TimeSpan PNPKIINFFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5D19630", Offset = "0x5D17E30", VA = "0x185D19630", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class FHLNHECHJJE : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly string IMIGBIJAOIP;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x78C320", Offset = "0x78AB20", VA = "0x18078C320")]
	public FHLNHECHJJE(string CLCHEEBIFED)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct EFANINLHLFM : IEquatable<EFANINLHLFM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint FGNMLHLGEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public int PGBJAEJPBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float BECDGEDGCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public ushort MJKAMJDOPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public ushort DOPNCEMOJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public short OECKBHFCGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public short PANGGICFBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public char IPCOJHBFBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public char COCPOJLGBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public byte OJHNKPAGLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public byte OIDIIGJKJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public byte OKKFMAGCCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public byte DLLMFODCLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool GLHNDNMAMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool AGLPJEOBLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool GENHPCIDKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public bool IDHHHALMIAN;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0xBCE930", Offset = "0xBCD130", VA = "0x180BCE930")]
	public static EFANINLHLFM KAJMHJINGDI(uint LIGLCBIHOCM)
	{
		return default(EFANINLHLFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xBCE930", Offset = "0xBCD130", VA = "0x180BCE930")]
	public static EFANINLHLFM ENFEHKLICLN(int POGNOKPAIMP)
	{
		return default(EFANINLHLFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D17220", Offset = "0x5D15A20", VA = "0x185D17220")]
	public static EFANINLHLFM FHAJOIMOKGO(float LHGIBPIINPD)
	{
		return default(EFANINLHLFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D17230", Offset = "0x5D15A30", VA = "0x185D17230")]
	public static EFANINLHLFM IHBDFJBKMAI(byte JCMOIFDEJMG, byte EPKCIOPIPLD, byte IEGDGGFDGNM, byte JOLNBIFKJLP)
	{
		return default(EFANINLHLFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D17230", Offset = "0x5D15A30", VA = "0x185D17230")]
	public static EFANINLHLFM KFABMEBDPFK(bool JDPDJFIMFLB, bool ANMICDDAJNK, bool IAAKPBGHHKG, bool CIPCHGPFIJA)
	{
		return default(EFANINLHLFM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x160F1D0", Offset = "0x160D9D0", VA = "0x18160F1D0")]
	public static bool PEFPHNLEPOM(EFANINLHLFM LCFOIJICGNF, EFANINLHLFM CEDMGMKLGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x160F1B0", Offset = "0x160D9B0", VA = "0x18160F1B0", Slot = "4")]
	public bool Equals(EFANINLHLFM GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D171A0", Offset = "0x5D159A0", VA = "0x185D171A0", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF20", Offset = "0x7EB720", VA = "0x1807ECF20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D17250", Offset = "0x5D15A50", VA = "0x185D17250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct FHELHHODNGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public ulong OMBKJCKKGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public long JEBAKPGAIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public double JEDEAOOIFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public uint EHKKKOENNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public uint NKKNBJDBKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int IEOPOCOKIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int GNFHOCJLGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float CJEICDECCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public float OPAJHBMPGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public ushort MJKAMJDOPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public ushort DOPNCEMOJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public ushort LKDHDNEAHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public ushort PGFKPPHDHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public short OECKBHFCGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public short PANGGICFBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public short GHGHHFEBCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public short FFEDLDFDIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public char IPCOJHBFBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public char COCPOJLGBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public char CHLOHMBEGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public char NPDMPLMGODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public byte OJHNKPAGLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public byte OIDIIGJKJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte OKKFMAGCCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public byte DLLMFODCLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public byte CIJJKNJLCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public byte FHBOPKPCEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte MOCDDHBNGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public byte MONFJNECAPE;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D18800", Offset = "0x5D17000", VA = "0x185D18800")]
	public static FHELHHODNGD MJLGMKKAMEE(byte JCMOIFDEJMG, byte EPKCIOPIPLD, byte IEGDGGFDGNM, byte JOLNBIFKJLP, byte DMJEBBMMNDN, byte MBCBMOEKGJA, byte GJGKLKIKDPM, byte DPOBOHDLLCO)
	{
		return default(FHELHHODNGD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class MKIGKNGBMJC
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x24218E0", Offset = "0x24200E0", VA = "0x1824218E0")]
	public static IEnumerable<T> JEAEBEJHHDK<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0")]
	public static T[] NOLPNLELGOK<T>(params T[] KOPAMOIEKNO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0")]
	public static IEnumerable<T> MBILLMOFNLH<T>(params T[] KOPAMOIEKNO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2424270", Offset = "0x2422A70", VA = "0x182424270")]
	public static HashSet<T> BJIEKFOMJDJ<T>(params T[] KOPAMOIEKNO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2471110", Offset = "0x246F910", VA = "0x182471110")]
	public static KeyValuePair<TKey, TValue> KNBJOJJPNDN<TKey, TValue>([In] TKey EBICOEDOGKC, [In] TValue IFKKLLBODIE) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2424270", Offset = "0x2422A70", VA = "0x182424270")]
	public static List<T> HHCBJMDOCIP<T>(IEnumerable<T> GBFGDEFHEJO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[AttributeUsage(AttributeTargets.All)]
public sealed class PBJOLKIGDBE : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly string EDFBCIBBJFJ;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x78C320", Offset = "0x78AB20", VA = "0x18078C320")]
	public PBJOLKIGDBE(string DNJMIEEELNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class JPNMHEACBLO
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class KAKMOGJENEC<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly ISet<T> LNAOMADBHGP;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int EAAIJEAHMOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x761FD0", Offset = "0x7607D0", VA = "0x180761FD0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x77C260", Offset = "0x77AA60", VA = "0x18077C260", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x388A180", Offset = "0x3888980", VA = "0x18388A180", Slot = "4")]
		public bool Add(T AKPEBFBEHGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "6")]
		public void IntersectWith(IEnumerable<T> GHNNCJBDHKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x388A380", Offset = "0x3888B80", VA = "0x18388A380", Slot = "5")]
		public void UnionWith(IEnumerable<T> GHNNCJBDHKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x388A2C0", Offset = "0x3888AC0", VA = "0x18388A2C0", Slot = "9")]
		void ICollection<T>.Add(T AKPEBFBEHGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "11")]
		public bool Contains(T AKPEBFBEHGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "12")]
		public void CopyTo(T[] JMHHCKCLFBI, int HPIBLFHGGKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
		public bool Remove(T AKPEBFBEHGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x388A240", Offset = "0x3888A40", VA = "0x18388A240", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x33D7B70", Offset = "0x33D6370", VA = "0x1833D7B70", Slot = "15")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public KAKMOGJENEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0xA07F40", Offset = "0xA06740", VA = "0x180A07F40")]
	public static ISet<T> MCBPGOAGLEO<T>() where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NIGCOHNCHEO]
public delegate void GGKEMEMBEDP(string BOBHOMKFHJB);
[Cpp2IlInjected.Token(Token = "0x2000034")]
[NIGCOHNCHEO]
public delegate void DNPANAFFBJM();
[Cpp2IlInjected.Token(Token = "0x2000035")]
public delegate object NIECBGOMCIN<T>([In] T DDNMEJONMEK);
[Cpp2IlInjected.Token(Token = "0x2000036")]
public delegate object PGPFGHNAJDJ<T>(T DDNMEJONMEK);
[Cpp2IlInjected.Token(Token = "0x2000037")]
[NIGCOHNCHEO]
public delegate string LHIMFJFPHCK(string HMGMLNHCJJK, string? CGLHBJFJMPA, bool BEGDADJBFPI);
[Cpp2IlInjected.Token(Token = "0x2000038")]
[NIGCOHNCHEO]
public delegate void BNPKKLHECHF(string LACIBLEADOC);
[Cpp2IlInjected.Token(Token = "0x2000039")]
[NIGCOHNCHEO]
public delegate void OBLAGJOGKDD(Exception DCJGKNPOAGA);
[Cpp2IlInjected.Token(Token = "0x200003A")]
public delegate object BHOFGOJFGBF();
[Cpp2IlInjected.Token(Token = "0x200003B")]
[NIGCOHNCHEO]
public delegate bool NEDONMNFEHG();
[Cpp2IlInjected.Token(Token = "0x200003C")]
[NIGCOHNCHEO]
public delegate string PLMNHELCOHN(object ELOCHLKHPBP);
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
