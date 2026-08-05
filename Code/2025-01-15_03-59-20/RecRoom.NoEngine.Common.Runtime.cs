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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x70F3960", Offset = "0x70F2D60", VA = "0x1870F3960")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FPMOBJGKGKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x70EEA10", Offset = "0x70EDE10", VA = "0x1870EEA10")]
	public static string PHALFBDHBII(this Encoding NFEIAFEIOHL, [In] ReadOnlySequence<byte> MDABPMPEKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3060240", Offset = "0x305F640", VA = "0x183060240")]
	private static void CDLEHPICGEK<T>(this ReadOnlySequence<T> BPLPEMOPIIJ, [Out] ReadOnlySpan<T> CLHHLCIDCJH, [Out] SequencePosition GBMGFIEPMIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class OPFEPCNGILN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x70F5430", Offset = "0x70F4830", VA = "0x1870F5430")]
	public OPFEPCNGILN(bool BNCJNLIAPGP, string IMNCLADPLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x70F53E0", Offset = "0x70F47E0", VA = "0x1870F53E0")]
	public OPFEPCNGILN(bool BNCJNLIAPGP, params string[] PPGLIKMJPDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GJFLFIDJMDN
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JNLOHCJKHCL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KJHIOLPIMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MOCCGCHLCPL(string LDCKBFKFIKC, double HCPAOILCJCB, [Optional] string? EKMHMCFHPGH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NKDEKINBHLN<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate Task<TResult> IKCINNCGMLK(CancellationToken FHGIOBPPFHG);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct CPIGJOLECIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public NKDEKINBHLN<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public IKCINNCGMLK taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x59FA9D0", Offset = "0x59F9DD0", VA = "0x1859FA9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x59FBB10", Offset = "0x59FAF10", VA = "0x1859FBB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource BPPNMIHDBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? IKNILMLIHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? EJEJHJPCFIG;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A925E0", Offset = "0x4A919E0", VA = "0x184A925E0")]
	[AsyncStateMachine(typeof(NKDEKINBHLN<>.CPIGJOLECIL))]
	public Task<TResult> KLLHAHJMJCN(IKCINNCGMLK ILPNKLCDJDN, [Optional] CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4A92570", Offset = "0x4A91970", VA = "0x184A92570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4A92730", Offset = "0x4A91B30", VA = "0x184A92730")]
	public NKDEKINBHLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class FOKKAKEOIDN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> FCDEPKONDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T GFHLLJBPNAP;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x40B2D20", Offset = "0x40B2120", VA = "0x1840B2D20")]
	public FOKKAKEOIDN([In] T HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x40B2300", Offset = "0x40B1700", VA = "0x1840B2300", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x40B2590", Offset = "0x40B1990", VA = "0x1840B2590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x40B26D0", Offset = "0x40B1AD0", VA = "0x1840B26D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class FOPIKLKHADK
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2E46CD0", Offset = "0x2E460D0", VA = "0x182E46CD0")]
	public static FOKKAKEOIDN<T> ODOFIFAGLAJ<T>([In] T HCPAOILCJCB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IOGPBGCNMPM
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x70F2C20", Offset = "0x70F2020", VA = "0x1870F2C20")]
	public static void HJGDBIIHDKO(this CancellationTokenSource BPPNMIHDBGI, bool MJIFDCIBIDL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class MBDEKLEEGGH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
	public MBDEKLEEGGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class MIBJBKKFACK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
	public MIBJBKKFACK(string KEEHDINMPFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ANBNNDIDMFD
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x372FC40", Offset = "0x372F040", VA = "0x18372FC40")]
	public static CLBGFGBAHIH ENJBOABGDAD<T>()
	{
		return default(CLBGFGBAHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x372FE60", Offset = "0x372F260", VA = "0x18372FE60")]
	public static CLBGFGBAHIH MMFCBGGHFOJ<T>([CallerMemberName] string LJAGHAHCFHJ = "") where T : notnull
	{
		return default(CLBGFGBAHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x372FBC0", Offset = "0x372EFC0", VA = "0x18372FBC0")]
	public static CLBGFGBAHIH ENJBOABGDAD<T>(this T PGHMIFOEHOF) where T : notnull
	{
		return default(CLBGFGBAHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x372FCC0", Offset = "0x372F0C0", VA = "0x18372FCC0")]
	public static CLBGFGBAHIH KPLJMCBHLJG<T>(this T PGHMIFOEHOF, [CallerMemberName] string LJAGHAHCFHJ = "") where T : notnull
	{
		return default(CLBGFGBAHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x372FF00", Offset = "0x372F300", VA = "0x18372FF00")]
	public static CLBGFGBAHIH MMFCBGGHFOJ<T>(this T MPLBPEBNKFP, [CallerMemberName] string LJAGHAHCFHJ = "") where T : notnull
	{
		return default(CLBGFGBAHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x70EB8E0", Offset = "0x70EACE0", VA = "0x1870EB8E0")]
	public static CLBGFGBAHIH MMFCBGGHFOJ(string FEMHEBFGNEJ, [CallerMemberName] string LJAGHAHCFHJ = "")
	{
		return default(CLBGFGBAHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x70EB840", Offset = "0x70EAC40", VA = "0x1870EB840")]
	public static string FNECLHCKGAD(this object MPLBPEBNKFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool MKPPJHIJDKI();
[Cpp2IlInjected.Token(Token = "0x2000014")]
[MBDEKLEEGGH]
public delegate long OGGCOMJEPCH();
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class HPCNDAKALDI
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static GJHGAHNDMBC CPGLDIBGCAE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static GJHGAHNDMBC KCKDBAGOHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x70F28F0", Offset = "0x70F1CF0", VA = "0x1870F28F0")]
		get
		{
			return default(GJHGAHNDMBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DOCLOKBDNIJ KIADOPOIIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x70F2180", Offset = "0x70F1580", VA = "0x1870F2180")]
		get
		{
			return default(DOCLOKBDNIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static EDNLCJNDGLG KDLHGONGIPI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x70F2940", Offset = "0x70F1D40", VA = "0x1870F2940")]
		get
		{
			return default(EDNLCJNDGLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool CDEHFDDGPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x70F2990", Offset = "0x70F1D90", VA = "0x1870F2990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x70F2270", Offset = "0x70F1670", VA = "0x1870F2270")]
	public static void CJJGNCNBLFA([In] GJHGAHNDMBC KFLMPKMDBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x70F2820", Offset = "0x70F1C20", VA = "0x1870F2820")]
	public static void LDCMEBNGNBB(string LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x70F2580", Offset = "0x70F1980", VA = "0x1870F2580")]
	public static void FLFHHGHPOFJ(string LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x30835F0", Offset = "0x30829F0", VA = "0x1830835F0")]
	public static void FLFHHGHPOFJ<T>(T FJIKACGIPBH, DPLOEHLEJKC<T> LNICHECHJFC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x70F21D0", Offset = "0x70F15D0", VA = "0x1870F21D0")]
	public static void AOPIFNDGGEI(Exception DIPLOOHMPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x70F27A0", Offset = "0x70F1BA0", VA = "0x1870F27A0")]
	public static void KBLEOOBEDIP(string LJAGHAHCFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x70F2730", Offset = "0x70F1B30", VA = "0x1870F2730")]
	public static void IFHIAFAJOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x70F2650", Offset = "0x70F1A50", VA = "0x1870F2650")]
	public static string FNECLHCKGAD(object NCHBKHMIMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x70F26C0", Offset = "0x70F1AC0", VA = "0x1870F26C0")]
	public static long HGIFFKCPJIH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x70F2410", Offset = "0x70F1810", VA = "0x1870F2410")]
	public static bool COOJCHCEECM(bool CBJBNBNFEJE, string LNICHECHJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x70F24B0", Offset = "0x70F18B0", VA = "0x1870F24B0")]
	public static double DCDAFOEKBGH()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct GJHGAHNDMBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly DOCLOKBDNIJ KIADOPOIIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly EDNLCJNDGLG KDLHGONGIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly JJFPDAJLGKB MLHPKDAIPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly OGGCOMJEPCH HFLHBLONMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly OKDGPICBICK AMIEIIJFOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly MKPPJHIJDKI PJKLHHOJGME;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly JJFPDAJLGKB HOHHIKGPIMM;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly OGGCOMJEPCH NKOGGBMAKGB;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly OKDGPICBICK IGPMKBGMEAD;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly MKPPJHIJDKI FIMDJCKEDNH;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly GJHGAHNDMBC MGEHKGIFIKI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PJCKOFPFAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x70EF0E0", Offset = "0x70EE4E0", VA = "0x1870EF0E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x70EFA70", Offset = "0x70EEE70", VA = "0x1870EFA70")]
	public GJHGAHNDMBC([In] DOCLOKBDNIJ JGHBLFGBJKF, [In] EDNLCJNDGLG PLOPDJBCCGM, JJFPDAJLGKB LLKBLJGEPJE, OGGCOMJEPCH KMDAPACFCAG, OKDGPICBICK NACIDDLPCMO, MKPPJHIJDKI AADFIEBDLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x70EF370", Offset = "0x70EE770", VA = "0x1870EF370")]
	private static string NLIAFNEPBNC(object NCHBKHMIMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90")]
	private static long AJDKFOBOHAA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	private static string EDEJPDMFDPJ(string KKGBCJPEHGE, string? ILIFBFJMIFP, bool AFLJHAJKGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0")]
	private static bool KEIHMFNIPNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x70EF270", Offset = "0x70EE670", VA = "0x1870EF270")]
	private static GJHGAHNDMBC ELAODOEGILL()
	{
		return default(GJHGAHNDMBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EEOBPBMOFND
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EMFBNBFDMAH PFIDLIKIIJL();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EMFBNBFDMAH : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool FAEOCLAAIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EIHPDKCBJJM();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GHOFIKLHDEE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DOEIDFIFKJC([In] T BMKPAKCEMFK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void AJKJIANGJJM<T>([In] T FJIKACGIPBH);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct FBFIHOALPJC<T> : IEquatable<FBFIHOALPJC<T>>, GHOFIKLHDEE<FBFIHOALPJC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T GFHLLJBPNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int MCCLHKLCIBG;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4051040", Offset = "0x4050440", VA = "0x184051040")]
	public FBFIHOALPJC([In] T HCPAOILCJCB, int IIACLAMOIEE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x404F450", Offset = "0x404E850", VA = "0x18404F450")]
	public static bool FANHDJJNLED([In] FBFIHOALPJC<T> KLFFMNNBENE, [In] FBFIHOALPJC<T> EHNIKEHCICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x404ED10", Offset = "0x404E110", VA = "0x18404ED10", Slot = "4")]
	public bool Equals(FBFIHOALPJC<T> BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x404EE30", Offset = "0x404E230", VA = "0x18404EE30", Slot = "0")]
	public override bool Equals(object BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x404EC70", Offset = "0x404E070", VA = "0x18404EC70")]
	public bool DOEIDFIFKJC([In] FBFIHOALPJC<T> BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x404F8D0", Offset = "0x404ECD0", VA = "0x18404F8D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x40507E0", Offset = "0x404FBE0", VA = "0x1840507E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x404FF90", Offset = "0x404F390", VA = "0x18404FF90")]
	public void MIAIEJBCOBI([Out] T HCPAOILCJCB, [Out] int IIACLAMOIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x404FD90", Offset = "0x404F190", VA = "0x18404FD90")]
	public (T, int) LKINCLJCNMP()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x404F520", Offset = "0x404E920", VA = "0x18404F520", Slot = "5")]
	private bool FPKBJPMHCFG([In] FBFIHOALPJC<T> BMKPAKCEMFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class IOLBHLBJDMD
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x30B72A0", Offset = "0x30B66A0", VA = "0x1830B72A0")]
	public static FBFIHOALPJC<T> ODOFIFAGLAJ<T>([In] T HCPAOILCJCB, int IIACLAMOIEE) where T : notnull
	{
		return default(FBFIHOALPJC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class NFCMPODOHAN
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x31D69E0", Offset = "0x31D5DE0", VA = "0x1831D69E0")]
	public static bool DOEIDFIFKJC<T, U>([In] T MPLBPEBNKFP, [In] U NCHBKHMIMGJ) where T : notnull, GHOFIKLHDEE<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult JCNLODCBEPP<T, out TResult>([In] T FJIKACGIPBH);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DEKAGOKFJCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	TimeSpan AMFDPCMIEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Action? OPLIKPHOGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INEAJMHODFF();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void APOAKLPEEIC();

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CICEJJBDDFM();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct DOCLOKBDNIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly GIMGBHLBAND DCHHEBLLPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly MOALKKCHCOJ NGFBJFGDEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly GIMGBHLBAND PGCPEONKNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly MOALKKCHCOJ CKDPIFDONND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly GIMGBHLBAND BLFBLBBLADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly MOALKKCHCOJ NMFDCAPHFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly OPMDIOKOAKB HBFNOHEKKHN;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly GIMGBHLBAND NLOALOJNCBN;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly MOALKKCHCOJ FNJGDFLHKCN;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly GIMGBHLBAND DFHPENAPHBM;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly MOALKKCHCOJ GIOKCACMMIB;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly GIMGBHLBAND FBIHNBJLFID;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly MOALKKCHCOJ JODMGMHPHEC;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly OPMDIOKOAKB PEBEAHHKNNC;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly DOCLOKBDNIJ MGEHKGIFIKI;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly GIMGBHLBAND GAAAANAAAAH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool PJCKOFPFAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x70ECAB0", Offset = "0x70EBEB0", VA = "0x1870ECAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x9AE600", Offset = "0x9ADA00", VA = "0x1809AE600")]
	public DOCLOKBDNIJ(GIMGBHLBAND JOKEHKHFFIP, MOALKKCHCOJ JGJELLAPJOD, GIMGBHLBAND NCOPNKIKMCP, MOALKKCHCOJ CCIJDIAOAJP, GIMGBHLBAND IELKDKBOKGD, MOALKKCHCOJ OGIPJHGAOGA, OPMDIOKOAKB EGCCCMIPPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0")]
	private static bool GBPNAJNEPAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
	private static void KCJIJGKFGEB(string LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0")]
	private static bool EDAIAMAEPAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
	private static void BDNANMLCAAH(string LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0")]
	private static bool FPHDLBICFKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
	private static void DNEJAGDFDAF(string LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
	private static void FJFFJNONBMG(Exception DIPLOOHMPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x70ECD60", Offset = "0x70EC160", VA = "0x1870ECD60")]
	private static DOCLOKBDNIJ ELAODOEGILL()
	{
		return default(DOCLOKBDNIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40")]
	private static bool LAMLCHDLPEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x70ECFF0", Offset = "0x70EC3F0", VA = "0x1870ECFF0")]
	public void LDCMEBNGNBB(object LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x70ECF80", Offset = "0x70EC380", VA = "0x1870ECF80")]
	public void FLFHHGHPOFJ(object LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9A0BA0", Offset = "0x99FFA0", VA = "0x1809A0BA0")]
	public void AOPIFNDGGEI(Exception DIPLOOHMPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x70ECEA0", Offset = "0x70EC2A0", VA = "0x1870ECEA0")]
	public void FLFHHGHPOFJ(AGCOAIANNFC LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2E9CF30", Offset = "0x2E9C330", VA = "0x182E9CF30")]
	public void FLFHHGHPOFJ<T>(T FJIKACGIPBH, DPLOEHLEJKC<T> LNICHECHJFC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2E9D000", Offset = "0x2E9C400", VA = "0x182E9D000")]
	public void LDCMEBNGNBB<T>([In] T FJIKACGIPBH, NFCMDKCIAAK<T> LNICHECHJFC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2E9CCC0", Offset = "0x2E9C0C0", VA = "0x182E9CCC0")]
	public void FLFHHGHPOFJ<T>([In] T FJIKACGIPBH, NFCMDKCIAAK<T> LNICHECHJFC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x70ECC90", Offset = "0x70EC090", VA = "0x1870ECC90")]
	public bool COOJCHCEECM(bool CBJBNBNFEJE, string LNICHECHJFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct CLBGFGBAHIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string GFHLLJBPNAP;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x96A9A0", Offset = "0x969DA0", VA = "0x18096A9A0")]
	public CLBGFGBAHIH(string HCPAOILCJCB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
	public static string IDKOEJANABA([In] CLBGFGBAHIH MPLBPEBNKFP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xD569C0", Offset = "0xD55DC0", VA = "0x180D569C0")]
	public static CLBGFGBAHIH IDKOEJANABA(string BMKPAKCEMFK)
	{
		return default(CLBGFGBAHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x70EC380", Offset = "0x70EB780", VA = "0x1870EC380")]
	public string ELDNMJGFBJL(string ECMILGICELM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x70EC2A0", Offset = "0x70EB6A0", VA = "0x1870EC2A0")]
	public string EHAHKIHDNPE(object CLFFJPDPGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[AttributeUsage(AttributeTargets.Method)]
public class FOBDFEPIDIE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
	public FOBDFEPIDIE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct ALHKDJHEAFJ : IEquatable<ALHKDJHEAFJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "4")]
	public bool Equals(ALHKDJHEAFJ BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x70EB7B0", Offset = "0x70EABB0", VA = "0x1870EB7B0", Slot = "0")]
	public override bool Equals(object BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x70EB800", Offset = "0x70EAC00", VA = "0x1870EB800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x70EB810", Offset = "0x70EAC10", VA = "0x1870EB810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[FAOCFIAPHCP("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct GPPELIJDOJB<T> : IEquatable<GPPELIJDOJB<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T GFHLLJBPNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool KMEAONEJKHH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool AJIJLDMHFOF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x41BE9D0", Offset = "0x41BDDD0", VA = "0x1841BE9D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x41BFFE0", Offset = "0x41BF3E0", VA = "0x1841BFFE0")]
	public GPPELIJDOJB([In] T HCPAOILCJCB, bool KGLJPFGJGOB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x41BF4F0", Offset = "0x41BE8F0", VA = "0x1841BF4F0")]
	public static bool FANHDJJNLED([In] GPPELIJDOJB<T> KLFFMNNBENE, [In] GPPELIJDOJB<T> EHNIKEHCICN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x41BE9E0", Offset = "0x41BDDE0", VA = "0x1841BE9E0", Slot = "4")]
	public bool Equals(GPPELIJDOJB<T> BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x41BF030", Offset = "0x41BE430", VA = "0x1841BF030", Slot = "0")]
	public override bool Equals(object? BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x41BF9C0", Offset = "0x41BEDC0", VA = "0x1841BF9C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x41BFBA0", Offset = "0x41BEFA0", VA = "0x1841BFBA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class BGNCAJCHGAB
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2DD4670", Offset = "0x2DD3A70", VA = "0x182DD4670")]
	public static GPPELIJDOJB<T> DEOMACBNCDC<T>([In] T HCPAOILCJCB) where T : notnull
	{
		return default(GPPELIJDOJB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2DD44C0", Offset = "0x2DD38C0", VA = "0x182DD44C0")]
	public static GPPELIJDOJB<T?> BNHKOFBLHOO<T>()
	{
		return default(GPPELIJDOJB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2DD4790", Offset = "0x2DD3B90", VA = "0x182DD4790")]
	public static bool INMDFDFMJIB<T>([In] this GPPELIJDOJB<T> KLIHFNDNBPJ, [Out][NotNullWhen(true)] T HCPAOILCJCB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2DD4720", Offset = "0x2DD3B20", VA = "0x182DD4720")]
	public static bool INMDFDFMJIB<T>([In] this GPPELIJDOJB<T> KLIHFNDNBPJ, [Out][NotNullWhen(true)] T HCPAOILCJCB, [Out] GPPELIJDOJB<T> PPPBAKGOBCN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2DD46D0", Offset = "0x2DD3AD0", VA = "0x182DD46D0")]
	public static T? IFOPBMAINBH<T>([In] this GPPELIJDOJB<T> KLIHFNDNBPJ, T? EKFBHIJFHMA)
	{
		return (T?)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class KIHAPHFGKCI
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3113230", Offset = "0x3112630", VA = "0x183113230")]
	public static T GLBCDDBDCMI<T>([In] this GPPELIJDOJB<T> KLIHFNDNBPJ) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct EDNLCJNDGLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr KBLEOOBEDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr IFHIAFAJOMA;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr BEDPFGKJADE;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr ABNPKFPGPLH;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly EDNLCJNDGLG MGEHKGIFIKI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool PJCKOFPFAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x70ED610", Offset = "0x70ECA10", VA = "0x1870ED610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xE8EEE0", Offset = "0xE8E2E0", VA = "0x180E8EEE0")]
	public EDNLCJNDGLG(IntPtr NIPHHPEOIKE, IntPtr MBAEIPOGJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
	private static void HBCMNHBFHLK(string LJAGHAHCFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
	private static void LNHGHLFMJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x70ED6E0", Offset = "0x70ECAE0", VA = "0x1870ED6E0")]
	private static EDNLCJNDGLG ELAODOEGILL()
	{
		return default(EDNLCJNDGLG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly ref struct AJHIKLIMPBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr EGAKPIELJOI;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
	private AJHIKLIMPBI(IntPtr MBAEIPOGJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x70EB6B0", Offset = "0x70EAAB0", VA = "0x1870EB6B0")]
	public void GMPAFBLCGBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x70EB6D0", Offset = "0x70EAAD0", VA = "0x1870EB6D0")]
	public static AJHIKLIMPBI ODOFIFAGLAJ(string LJAGHAHCFHJ)
	{
		return default(AJHIKLIMPBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x232A790", Offset = "0x2329B90", VA = "0x18232A790")]
	public static AJHIKLIMPBI ODOFIFAGLAJ([In] EDNLCJNDGLG PLOPDJBCCGM, string LJAGHAHCFHJ)
	{
		return default(AJHIKLIMPBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x232A3E0", Offset = "0x23297E0", VA = "0x18232A3E0")]
	public static AJHIKLIMPBI ODOFIFAGLAJ([In] EDNLCJNDGLG PLOPDJBCCGM, Func<string> LJAGHAHCFHJ)
	{
		return default(AJHIKLIMPBI);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class HJMGNDINOCH
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate bool EGEHIOCHMCN<in TInput, TResult>(TInput AOOGNGKJLKL, [Out] TResult CEDDFJCBLGM);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private sealed class AJENJEKLKIJ : EEOBPBMOFND
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private sealed class PINFJDAJFHN : EMFBNBFDMAH, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly PINFJDAJFHN ELEBKANKHDF;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool FAEOCLAAIMH
			{
				[Cpp2IlInjected.Token(Token = "0x60000C1")]
				[Cpp2IlInjected.Address(RVA = "0x70F5B60", Offset = "0x70F4F60", VA = "0x1870F5B60", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x70F5BC0", Offset = "0x70F4FC0", VA = "0x1870F5BC0", Slot = "6")]
			public void OnCompleted(Action NEJOBNCNOON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
			public void EIHPDKCBJJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public PINFJDAJFHN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly AJENJEKLKIJ ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		private AJENJEKLKIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x70EB5F0", Offset = "0x70EA9F0", VA = "0x1870EB5F0", Slot = "4")]
		public EMFBNBFDMAH PFIDLIKIIJL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private sealed class PAMCJAFCJCK : EEOBPBMOFND
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class AOOLEONBGLJ : EMFBNBFDMAH, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly AOOLEONBGLJ ELEBKANKHDF;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool FAEOCLAAIMH
			{
				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x70EB960", Offset = "0x70EAD60", VA = "0x1870EB960", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x70EB980", Offset = "0x70EAD80", VA = "0x1870EB980", Slot = "6")]
			public void OnCompleted(Action NEJOBNCNOON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
			public void EIHPDKCBJJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public AOOLEONBGLJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly PAMCJAFCJCK ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		private PAMCJAFCJCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x70F5500", Offset = "0x70F4900", VA = "0x1870F5500", Slot = "4")]
		public EMFBNBFDMAH PFIDLIKIIJL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class IOAHKGFDPHJ<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public IOAHKGFDPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4059970", Offset = "0x4058D70", VA = "0x184059970")]
		internal void LEAOLEELFOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class MOBMHEGKNOI<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public MOBMHEGKNOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4255BE0", Offset = "0x4254FE0", VA = "0x184255BE0")]
		internal void GOJDLMHEOCB(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct INMLHBCMKGK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x70F2AC0", Offset = "0x70F1EC0", VA = "0x1870F2AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct BOOPCLGJDDL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x70EC120", Offset = "0x70EB520", VA = "0x1870EC120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct NFALCCFAMKH<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x4A6E080", Offset = "0x4A6D480", VA = "0x184A6E080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4A6E1F0", Offset = "0x4A6D5F0", VA = "0x184A6E1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct LMJFAKILBCI<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x47E3B40", Offset = "0x47E2F40", VA = "0x1847E3B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x47E3F90", Offset = "0x47E3390", VA = "0x1847E3F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct NNGOIHLPMKF : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x70F36F0", Offset = "0x70F2AF0", VA = "0x1870F36F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x70F38F0", Offset = "0x70F2CF0", VA = "0x1870F38F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class FDPNPGNOBGE<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public FDPNPGNOBGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4059970", Offset = "0x4058D70", VA = "0x184059970")]
		internal void HEJAPPIGCGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x40598F0", Offset = "0x4058CF0", VA = "0x1840598F0")]
		internal void EANODBFIADK(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct OHLKDIHDFIE<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public EGEHIOCHMCN<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4B82C90", Offset = "0x4B82090", VA = "0x184B82C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4B833F0", Offset = "0x4B827F0", VA = "0x184B833F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct OKMMBEDDNIK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x70F4B90", Offset = "0x70F3F90", VA = "0x1870F4B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x70F5380", Offset = "0x70F4780", VA = "0x1870F5380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct PHHMEAICJCK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x70F55C0", Offset = "0x70F49C0", VA = "0x1870F55C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x70F5B00", Offset = "0x70F4F00", VA = "0x1870F5B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct HFJCOEKKFEC<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4244FE0", Offset = "0x42443E0", VA = "0x184244FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x42447D0", Offset = "0x4243BD0", VA = "0x1842447D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class ODBIBNCGBAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public TaskCompletionSource<ALHKDJHEAFJ> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public ODBIBNCGBAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x70F4330", Offset = "0x70F3730", VA = "0x1870F4330")]
		internal void JEBKBOHCFAH(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct LCOAOPPMBLG<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x47BD2C0", Offset = "0x47BC6C0", VA = "0x1847BD2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x39B37C0", Offset = "0x39B2BC0", VA = "0x1839B37C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct KOLDELFLOJB<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4736830", Offset = "0x4735C30", VA = "0x184736830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4736F70", Offset = "0x4736370", VA = "0x184736F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct LLOGKGCOGFM : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x70F2F60", Offset = "0x70F2360", VA = "0x1870F2F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x70F3140", Offset = "0x70F2540", VA = "0x1870F3140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct HAMJHOPJAFJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x70EFB20", Offset = "0x70EEF20", VA = "0x1870EFB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x70EFE80", Offset = "0x70EF280", VA = "0x1870EFE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct DNJBMPMCIKP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x70EC760", Offset = "0x70EBB60", VA = "0x1870EC760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x70ECA50", Offset = "0x70EBE50", VA = "0x1870ECA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class HBLLHNPPOBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public HBLLHNPPOBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x70EFEE0", Offset = "0x70EF2E0", VA = "0x1870EFEE0")]
		internal Task GLMKCADEHID(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct KNAEIIENBLO : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x70F2CA0", Offset = "0x70F20A0", VA = "0x1870F2CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x70F2F00", Offset = "0x70F2300", VA = "0x1870F2F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct NDFJINJFJDB : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x70F34B0", Offset = "0x70F28B0", VA = "0x1870F34B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x70F3690", Offset = "0x70F2A90", VA = "0x1870F3690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct AFONEEPKMAE : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x70EB230", Offset = "0x70EA630", VA = "0x1870EB230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x70EB590", Offset = "0x70EA990", VA = "0x1870EB590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct AFAJBADBAGO : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x70EA6E0", Offset = "0x70E9AE0", VA = "0x1870EA6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x70EA9D0", Offset = "0x70E9DD0", VA = "0x1870EA9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class CHDPODFBDDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public CHDPODFBDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x70EC230", Offset = "0x70EB630", VA = "0x1870EC230")]
		internal Task CADKEBJEIEF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct EPDFOJAKOPL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x70ED8B0", Offset = "0x70ECCB0", VA = "0x1870ED8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x70EDB10", Offset = "0x70ECF10", VA = "0x1870EDB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct ABNMAMAJFGL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x70EA500", Offset = "0x70E9900", VA = "0x1870EA500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x70EA680", Offset = "0x70E9A80", VA = "0x1870EA680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct IKNPNGBMEKM<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4355220", Offset = "0x4354620", VA = "0x184355220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x43554A0", Offset = "0x43548A0", VA = "0x1843554A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct DMPMMIFDCMP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x70EC3D0", Offset = "0x70EB7D0", VA = "0x1870EC3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x70EC700", Offset = "0x70EBB00", VA = "0x1870EC700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? PJHMPJIIPAJ;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<ALHKDJHEAFJ> EILMHMJCGBE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static Task KEINDMNPPNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x70F0A90", Offset = "0x70EFE90", VA = "0x1870F0A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x70F0900", Offset = "0x70EFD00", VA = "0x1870F0900")]
	public static bool EPGKONCHIPC(this Task LCFJPCOMAFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3081050", Offset = "0x3080450", VA = "0x183081050")]
	public static Task<T> OGFIJFMGBGP<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x70F0C20", Offset = "0x70F0020", VA = "0x1870F0C20")]
	public static Task LAPCBBJFLOB(this Task LCFJPCOMAFL, CancellationToken CMNJCPJBHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x307ED40", Offset = "0x307E140", VA = "0x18307ED40")]
	public static Task<TResult> LAPCBBJFLOB<TResult>(this Task<TResult> LCFJPCOMAFL, CancellationToken CMNJCPJBHGE) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x30805D0", Offset = "0x307F9D0", VA = "0x1830805D0")]
	public static TaskCompletionSource<TResult> LAPCBBJFLOB<TResult>(this TaskCompletionSource<TResult> NOJOJIMAJMM, CancellationToken CMNJCPJBHGE) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x70F1F30", Offset = "0x70F1330", VA = "0x1870F1F30")]
	public static IDisposable? PGOAEKIGEHL(CancellationToken BPPPNCJBMKP, CancellationToken ELFMBAKPPOK, [Out] CancellationToken OHNLLLININP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x70F0930", Offset = "0x70EFD30", VA = "0x1870F0930")]
	[AsyncStateMachine(typeof(INMLHBCMKGK))]
	public static void FEBJEPLDEDK(this Task OPGNNMINDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x70F09E0", Offset = "0x70EFDE0", VA = "0x1870F09E0")]
	[AsyncStateMachine(typeof(BOOPCLGJDDL))]
	public static void HENPACKHFEG(this Task OPGNNMINDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x307C8C0", Offset = "0x307BCC0", VA = "0x18307C8C0")]
	[AsyncStateMachine(typeof(NFALCCFAMKH<>))]
	public static Task EJDDAKFJACK<TException>(this Task OPGNNMINDKO) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x307CB70", Offset = "0x307BF70", VA = "0x18307CB70")]
	[AsyncStateMachine(typeof(LMJFAKILBCI<>))]
	public static Task<T> HABBJOBKFCE<T>(this Task<T> MPLBPEBNKFP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x70F1E40", Offset = "0x70F1240", VA = "0x1870F1E40")]
	[AsyncStateMachine(typeof(NNGOIHLPMKF))]
	public static Task<TaskStatus> PBKDCHAPNBB(this Task MPLBPEBNKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x30811D0", Offset = "0x30805D0", VA = "0x1830811D0")]
	public static (Task<T?>?, Action<T?>?) PMKINBELDMH<T>([Optional] CancellationToken FHGIOBPPFHG)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x307D010", Offset = "0x307C410", VA = "0x18307D010")]
	[AsyncStateMachine(typeof(OHLKDIHDFIE<, >))]
	public static Task<List<TResult>> KLGPNMKKGMD<TResult, TInput>(this Task<List<TInput>> LCFJPCOMAFL, EGEHIOCHMCN<TInput, TResult> EEOHGPDINED) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x70F0080", Offset = "0x70EF480", VA = "0x1870F0080")]
	[AsyncStateMachine(typeof(OKMMBEDDNIK))]
	public static Task AENOOLJMBAO(Task OPGNNMINDKO, CancellationToken FGKKJOBPJBP, Func<CancellationToken, Task> CIDCPCOMGCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x70EFF50", Offset = "0x70EF350", VA = "0x1870EFF50")]
	[AsyncStateMachine(typeof(PHHMEAICJCK))]
	public static Task ABNFLCKJCML(Func<CancellationToken, Task> HCMKHHLLJEJ, TimeSpan NIFKBJPBAKP, [Optional] CancellationToken FGKKJOBPJBP, [Optional] Action<OperationCanceledException>? HHDHEKJHJEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x307C640", Offset = "0x307BA40", VA = "0x18307C640")]
	[AsyncStateMachine(typeof(HFJCOEKKFEC<>))]
	public static Task<T> ABNFLCKJCML<T>(Func<CancellationToken, Task<T>> HCMKHHLLJEJ, TimeSpan NIFKBJPBAKP, [Optional] CancellationToken FGKKJOBPJBP, [Optional] Func<OperationCanceledException, T>? HHDHEKJHJEF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x70F1930", Offset = "0x70F0D30", VA = "0x1870F1930")]
	public static Task OIFDEKLGFKG(params Task[] OBHPHDJFIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x70F1980", Offset = "0x70F0D80", VA = "0x1870F1980")]
	public static Task OIFDEKLGFKG(IEnumerable<Task> OBHPHDJFIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x307CA80", Offset = "0x307BE80", VA = "0x18307CA80")]
	[AsyncStateMachine(typeof(LCOAOPPMBLG<>))]
	public static Task<IEnumerable<Task<T>>> GHBABBHFDHE<T>(IEnumerable<Task<T>> OBHPHDJFIPE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x307CD50", Offset = "0x307C150", VA = "0x18307CD50")]
	[AsyncStateMachine(typeof(KOLDELFLOJB<, , , >))]
	public static Task<(T1, T2, T3, T4)> IDPNDDEJHND<T1, T2, T3, T4>(Task<T1> BKBAJABMMOL, Task<T2> MDILMBKCOHM, Task<T3> CMHDFLLECGM, Task<T4> HFGLHBDOJIF) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x70F0F80", Offset = "0x70F0380", VA = "0x1870F0F80")]
	[AsyncStateMachine(typeof(LLOGKGCOGFM))]
	public static Task LMEJKDKLPKB(Func<bool> CBJBNBNFEJE, [Optional] CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x70F0E70", Offset = "0x70F0270", VA = "0x1870F0E70")]
	[AsyncStateMachine(typeof(HAMJHOPJAFJ))]
	public static Task LMEJKDKLPKB(Func<bool> CBJBNBNFEJE, TimeSpan EEODHEOBNCG, [Optional] CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x70F0650", Offset = "0x70EFA50", VA = "0x1870F0650")]
	[AsyncStateMachine(typeof(DNJBMPMCIKP))]
	public static Task DMPLPGKLIDP(Func<bool> CBJBNBNFEJE, TimeSpan NIFKBJPBAKP, [Optional] CancellationToken FHGIOBPPFHG, [Optional] Action<OperationCanceledException>? HHDHEKJHJEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x70F0510", Offset = "0x70EF910", VA = "0x1870F0510")]
	[AsyncStateMachine(typeof(KNAEIIENBLO))]
	public static Task DMPLPGKLIDP(Func<bool> CBJBNBNFEJE, TimeSpan NIFKBJPBAKP, TimeSpan EEODHEOBNCG, [Optional] CancellationToken FHGIOBPPFHG, [Optional] Action<OperationCanceledException>? HHDHEKJHJEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x70F1640", Offset = "0x70F0A40", VA = "0x1870F1640")]
	[AsyncStateMachine(typeof(NDFJINJFJDB))]
	public static Task NAKJBLHMELI(Func<bool> CBJBNBNFEJE, [Optional] CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x70F1530", Offset = "0x70F0930", VA = "0x1870F1530")]
	[AsyncStateMachine(typeof(AFONEEPKMAE))]
	public static Task NAKJBLHMELI(Func<bool> CBJBNBNFEJE, TimeSpan EEODHEOBNCG, [Optional] CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x70F1240", Offset = "0x70F0640", VA = "0x1870F1240")]
	[AsyncStateMachine(typeof(AFAJBADBAGO))]
	public static Task MKCOFHOCGML(Func<bool> CBJBNBNFEJE, TimeSpan NIFKBJPBAKP, [Optional] CancellationToken FHGIOBPPFHG, [Optional] Action<OperationCanceledException>? HHDHEKJHJEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x70F1370", Offset = "0x70F0770", VA = "0x1870F1370")]
	[AsyncStateMachine(typeof(EPDFOJAKOPL))]
	public static Task MKCOFHOCGML(Func<bool> CBJBNBNFEJE, TimeSpan NIFKBJPBAKP, TimeSpan EEODHEOBNCG, [Optional] CancellationToken FHGIOBPPFHG, [Optional] Action<OperationCanceledException>? HHDHEKJHJEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x70F1840", Offset = "0x70F0C40", VA = "0x1870F1840")]
	[Obsolete]
	[AsyncStateMachine(typeof(ABNMAMAJFGL))]
	public static Task NLOJALCKPEH(this Task LCFJPCOMAFL, Action EEJBDEOBFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3080F60", Offset = "0x3080360", VA = "0x183080F60")]
	[AsyncStateMachine(typeof(IKNPNGBMEKM<>))]
	[Obsolete]
	public static Task NLOJALCKPEH<T>(this Task<T> LCFJPCOMAFL, Action<T> EEJBDEOBFED) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x70F0780", Offset = "0x70EFB80", VA = "0x1870F0780")]
	private static void EEHCBCAGGCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x70F01B0", Offset = "0x70EF5B0", VA = "0x1870F01B0")]
	public static bool CFECDNEGJPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x70F1070", Offset = "0x70F0470", VA = "0x1870F1070")]
	private static void MHOCABJFKLN(SynchronizationContext HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x70F1730", Offset = "0x70F0B30", VA = "0x1870F1730")]
	private static void NHIPOAHDDKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x70F0B00", Offset = "0x70EFF00", VA = "0x1870F0B00")]
	public static void KCBEHNNGGJK([Optional] string? LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x70F14B0", Offset = "0x70F08B0", VA = "0x1870F14B0")]
	public static void MPAKPGEJBCI([Optional] string? LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x70F0BD0", Offset = "0x70EFFD0", VA = "0x1870F0BD0")]
	public static EEOBPBMOFND KIJOBBHKLEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x70F11F0", Offset = "0x70F05F0", VA = "0x1870F11F0")]
	public static EEOBPBMOFND MIDMANLIILB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x70F0830", Offset = "0x70EFC30", VA = "0x1870F0830")]
	[AsyncStateMachine(typeof(DMPMMIFDCMP))]
	public static Task EMNAMLAFCIO(Func<Task> BDEDHGPGIGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class GFHMGJFENGN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
	public GFHMGJFENGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class GFANLFBEDGL : EHICLJOCAMK
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static readonly EHICLJOCAMK ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTime HPILNPCEAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x70EF030", Offset = "0x70EE430", VA = "0x1870EF030", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DateTimeOffset CJEGAHLAHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x70EEFD0", Offset = "0x70EE3D0", VA = "0x1870EEFD0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public GFANLFBEDGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface EHICLJOCAMK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTime HPILNPCEAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DateTimeOffset CJEGAHLAHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class AFKMMIMEKHM
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long DFDDLCDNAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x70EAC10", Offset = "0x70EA010", VA = "0x1870EAC10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static long HCIJHBEIGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x70EAEF0", Offset = "0x70EA2F0", VA = "0x1870EAEF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double DNEJOFELLGH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x70EAF40", Offset = "0x70EA340", VA = "0x1870EAF40")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double EPGPOKJHICJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x70EAE10", Offset = "0x70EA210", VA = "0x1870EAE10")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double OAOCECJCMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x70EAAC0", Offset = "0x70E9EC0", VA = "0x1870EAAC0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static double BIODFABEECK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x70EAC60", Offset = "0x70EA060", VA = "0x1870EAC60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x70EAA30", Offset = "0x70E9E30", VA = "0x1870EAA30")]
	public static double CMAHGPOJPLB(long FCPGIDDFEIM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x70EAD80", Offset = "0x70EA180", VA = "0x1870EAD80")]
	public static double NHAHHEJFEEM(long FCPGIDDFEIM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x70EAB80", Offset = "0x70E9F80", VA = "0x1870EAB80")]
	public static double EOHHPNKNGHE(double OCEDDOENDFM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x70EAE60", Offset = "0x70EA260", VA = "0x1870EAE60")]
	public static long OJPLKFEFPMM(long CHFBMMDLDCL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x70EAB10", Offset = "0x70E9F10", VA = "0x1870EAB10")]
	public static long DANDOAIKEML(long IHFEDPOOFCJ, long PANCODEEMAL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x70EACB0", Offset = "0x70EA0B0", VA = "0x1870EACB0")]
	public static double KLPBIJBDCJN(long IHFEDPOOFCJ, long PANCODEEMAL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x70EAB20", Offset = "0x70E9F20", VA = "0x1870EAB20")]
	public static double DIBPCABGHHP(long IHFEDPOOFCJ, long PANCODEEMAL)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class BLMDMMAGHCH : DEKAGOKFJCB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static readonly TimeSpan COMBBKDNKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly System.Timers.Timer HIKLLEDALJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private TimeSpan NIFKBJPBAKP;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public TimeSpan AMFDPCMIEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x70EBAB0", Offset = "0x70EAEB0", VA = "0x1870EBAB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Action? OPLIKPHOGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x70EC0C0", Offset = "0x70EB4C0", VA = "0x1870EC0C0")]
	[Preserve]
	public BLMDMMAGHCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x70EBE70", Offset = "0x70EB270", VA = "0x1870EBE70")]
	public BLMDMMAGHCH(TimeSpan NIFKBJPBAKP, [Optional] Action? BHNHCODAEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x70EBCE0", Offset = "0x70EB0E0", VA = "0x1870EBCE0", Slot = "7")]
	public void INEAJMHODFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x70EBA40", Offset = "0x70EAE40", VA = "0x1870EBA40", Slot = "8")]
	public void APOAKLPEEIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x70EBC10", Offset = "0x70EB010", VA = "0x1870EBC10", Slot = "9")]
	public void CICEJJBDDFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0xCE8380", Offset = "0xCE7780", VA = "0x180CE8380")]
	private void LGLGLJGEJBC(object PGHMIFOEHOF, ElapsedEventArgs GAHBHPFKPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x70EBD70", Offset = "0x70EB170", VA = "0x1870EBD70")]
	private static void JGJOMDNHNLF(TimeSpan GNFDJFEGEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x70EBC40", Offset = "0x70EB040", VA = "0x1870EBC40", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class FAOCFIAPHCP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string? GCKCKCIIKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly string PGKBPOBAJDI;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D300", Offset = "0x6B1C700", VA = "0x186B1D300")]
	public FAOCFIAPHCP(string JADMIFIBKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3BD0", Offset = "0x3CE2FD0", VA = "0x183CE3BD0")]
	public FAOCFIAPHCP(string ODCOLEGLGGM, string JADMIFIBKFL)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct FNGOKDJHLLJ : IEquatable<FNGOKDJHLLJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint JDHMDHNDIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public int OPDBFCKMDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public float NAFFCCBDEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public ushort MKHIAIIJPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public ushort JJJNJMJAEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public short FIGABLDELAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public short MMBDHMBAJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public char OPBMNIIJGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public char NFOLMMKFCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte HLGDIPAKOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public byte NBCLAKMMDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public byte DPCJDKJLOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public byte OCIIJOKIFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool IJLJMEBEPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool KGKLEFOGAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public bool CFBPLOMOOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public bool AIIIKFPKLJB;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x1829780", Offset = "0x1828B80", VA = "0x181829780")]
	public static FNGOKDJHLLJ EANEEGKEAAD(uint BNPJOEFFEDG)
	{
		return default(FNGOKDJHLLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x1829780", Offset = "0x1828B80", VA = "0x181829780")]
	public static FNGOKDJHLLJ LIOMGJHCBJC(int MJGLDAFACMF)
	{
		return default(FNGOKDJHLLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x70EDB90", Offset = "0x70ECF90", VA = "0x1870EDB90")]
	public static FNGOKDJHLLJ DMAKBLJFMJK(float DNLBEEDJMGE)
	{
		return default(FNGOKDJHLLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x70EDB70", Offset = "0x70ECF70", VA = "0x1870EDB70")]
	public static FNGOKDJHLLJ HODMEGDIFKL(byte EKPBMANIGEL, byte EJJPPADHNCI, byte PJDHNDIECJK, byte OKHDGGHNAKM)
	{
		return default(FNGOKDJHLLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x70EDB70", Offset = "0x70ECF70", VA = "0x1870EDB70")]
	public static FNGOKDJHLLJ BHPBFMJNLHF(bool ANLOFLCKBDP, bool CGPBPBGMKFK, bool DAPPNAMJPKP, bool MMPNCGMCMLM)
	{
		return default(FNGOKDJHLLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x70EDB70", Offset = "0x70ECF70", VA = "0x1870EDB70")]
	public static FNGOKDJHLLJ KODHKHKHOOP(byte FHCFCGKHCJN, byte NIGLPENFKIH, byte MEFBBKMGJFB, byte PEKHKPELHMM)
	{
		return default(FNGOKDJHLLJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1B28BA0", Offset = "0x1B27FA0", VA = "0x181B28BA0")]
	public static bool FANHDJJNLED(FNGOKDJHLLJ FGFJFGGJOII, FNGOKDJHLLJ CABLGFIBABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x1B28B80", Offset = "0x1B27F80", VA = "0x181B28B80", Slot = "4")]
	public bool Equals(FNGOKDJHLLJ BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x70EDBA0", Offset = "0x70ECFA0", VA = "0x1870EDBA0", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0xE73A30", Offset = "0xE72E30", VA = "0x180E73A30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x70EDC20", Offset = "0x70ED020", VA = "0x1870EDC20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct KBKKMCKOGJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public ulong HPGHJLKLGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public long HCEKADMDEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public double AGDODJMOGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint DIKICOFJOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint HAGKJLIEOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public int DDGPMNIINNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int EOFIBHOKNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float MIKAICPPDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float IIPNPHCDMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort MKHIAIIJPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public ushort JJJNJMJAEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public ushort OAJMHPIAGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public ushort FJLCLLHNMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short FIGABLDELAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public short MMBDHMBAJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public short BCHBLDHHDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public short ENLNJMGDPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char OPBMNIIJGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public char NFOLMMKFCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public char IIKANDGFJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public char EFLHCLFOCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte HLGDIPAKOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte NBCLAKMMDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte DPCJDKJLOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte OCIIJOKIFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte OKAOBJGGBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte MBLFENALMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public byte MDPKNAFPION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public byte JFJANIHKFLO;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static KBKKMCKOGJD ODOFIFAGLAJ(long NDGOOCDDKIO)
	{
		return default(KBKKMCKOGJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x70F2C50", Offset = "0x70F2050", VA = "0x1870F2C50")]
	public static KBKKMCKOGJD ODOFIFAGLAJ(byte EKPBMANIGEL, byte EJJPPADHNCI, byte PJDHNDIECJK, byte OKHDGGHNAKM, byte EGNPDJFBDLL, byte BPPLFJKLDKJ, byte NEGINNANMHC, byte BOFAGAKMFLD)
	{
		return default(KBKKMCKOGJD);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct LPDLBHNHBEI : IEquatable<LPDLBHNHBEI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public byte MDANCBLPLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool FAFLDFMLALG;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x295BA20", Offset = "0x295AE20", VA = "0x18295BA20")]
	public static LPDLBHNHBEI HODMEGDIFKL(byte NEILAEGPICG)
	{
		return default(LPDLBHNHBEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x295BA20", Offset = "0x295AE20", VA = "0x18295BA20")]
	public static LPDLBHNHBEI BHPBFMJNLHF(bool KLJFGKNIFCE)
	{
		return default(LPDLBHNHBEI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x70F3230", Offset = "0x70F2630", VA = "0x1870F3230")]
	public static bool FANHDJJNLED(LPDLBHNHBEI FGFJFGGJOII, LPDLBHNHBEI CABLGFIBABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x61E0650", Offset = "0x61DFA50", VA = "0x1861E0650", Slot = "4")]
	public bool Equals(LPDLBHNHBEI BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x70F31A0", Offset = "0x70F25A0", VA = "0x1870F31A0", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x70F3240", Offset = "0x70F2640", VA = "0x1870F3240", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x70F3250", Offset = "0x70F2650", VA = "0x1870F3250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class EANPFGHHHKB<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public readonly T BMEIJOHJODL;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3C7B560", Offset = "0x3C7A960", VA = "0x183C7B560")]
	public EANPFGHHHKB(T LGPABHNOPCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class MBMGCCFEANN
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x312E730", Offset = "0x312DB30", VA = "0x18312E730")]
	public static IEnumerable<T> HFGCCKCHNPE<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static T[] DDLMCLOIPOG<T>(params T[] LEHLEJNKEOG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static IEnumerable<T> MCAOCCABEIG<T>(params T[] LEHLEJNKEOG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2E46CD0", Offset = "0x2E460D0", VA = "0x182E46CD0")]
	public static HashSet<T> PJEMEGOCMPD<T>(params T[] LEHLEJNKEOG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x312E640", Offset = "0x312DA40", VA = "0x18312E640")]
	public static KeyValuePair<TKey, TValue> EAEBMFABANL<TKey, TValue>([In] TKey LDCKBFKFIKC, [In] TValue HCPAOILCJCB) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2E46CD0", Offset = "0x2E460D0", VA = "0x182E46CD0")]
	public static List<T> IEPAECCCGGI<T>(IEnumerable<T> KNHLIMDEMDB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[AttributeUsage(AttributeTargets.All)]
public sealed class ILFPHCBGMJI : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public readonly string DIJBGJOLJHH;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
	public ILFPHCBGMJI(string NHJAKHBPCNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public delegate object NFCMDKCIAAK<T>([In] T DCNLGGHAIIP);
[Cpp2IlInjected.Token(Token = "0x200005C")]
public delegate object DPLOEHLEJKC<T>(T DCNLGGHAIIP);
[Cpp2IlInjected.Token(Token = "0x200005D")]
[MBDEKLEEGGH]
public delegate string OKDGPICBICK(string KKGBCJPEHGE, string? ILIFBFJMIFP, bool AFLJHAJKGID);
[Cpp2IlInjected.Token(Token = "0x200005E")]
[MBDEKLEEGGH]
public delegate void MOALKKCHCOJ(string LNICHECHJFC);
[Cpp2IlInjected.Token(Token = "0x200005F")]
[MBDEKLEEGGH]
public delegate void OPMDIOKOAKB(Exception DIPLOOHMPFH);
[Cpp2IlInjected.Token(Token = "0x2000060")]
public delegate object AGCOAIANNFC();
[Cpp2IlInjected.Token(Token = "0x2000061")]
[MBDEKLEEGGH]
public delegate bool GIMGBHLBAND();
[Cpp2IlInjected.Token(Token = "0x2000062")]
[MBDEKLEEGGH]
public delegate string JJFPDAJLGKB(object NCHBKHMIMGJ);
[Cpp2IlInjected.Token(Token = "0x2000063")]
[AttributeUsage(AttributeTargets.Enum)]
public class IFPDDBGJBJF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
	public IFPDDBGJBJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class OGIACBNCIIN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct OAMFBOABEAL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x70F39E0", Offset = "0x70F2DE0", VA = "0x1870F39E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x70F42C0", Offset = "0x70F36C0", VA = "0x1870F42C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly TimerCallback EDLJLOGBKGN;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly Action<object?> GKONKCPMIKC;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x70F4600", Offset = "0x70F3A00", VA = "0x1870F4600")]
	public static Task<bool> NAOPKIMFKIK(int LCJKMCGBLNI, [Optional] CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x70F4440", Offset = "0x70F3840", VA = "0x1870F4440")]
	[AsyncStateMachine(typeof(OAMFBOABEAL))]
	private static Task<bool> BBJKLFKGBCF(int LCJKMCGBLNI, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x70F4900", Offset = "0x70F3D00", VA = "0x1870F4900")]
	private static void NECINEMODLJ(object? MPLALBADMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x70F4570", Offset = "0x70F3970", VA = "0x1870F4570")]
	private static void EOEELHIBDOM(object? MPLALBADMNL)
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
