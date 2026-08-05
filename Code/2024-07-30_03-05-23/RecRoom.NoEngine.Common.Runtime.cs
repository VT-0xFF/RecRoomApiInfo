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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
		[Cpp2IlInjected.Address(RVA = "0x6AD9410", Offset = "0x6AD7A10", VA = "0x186AD9410")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8917F0", Offset = "0x88FDF0", VA = "0x1808917F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x891830", Offset = "0x88FE30", VA = "0x180891830")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FMLBPMBKLLN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6AD2C50", Offset = "0x6AD1250", VA = "0x186AD2C50")]
	public static string EHMBEGDNCMM(this Encoding PFOOAHFBMBH, [In] ReadOnlySequence<byte> LKFNEINGOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B87AE0", Offset = "0x2B860E0", VA = "0x182B87AE0")]
	private static void FMJCAENNMOA<T>(this ReadOnlySequence<T> EEJFHEAAALJ, [Out] ReadOnlySpan<T> MDEEEJLBHFC, [Out] SequencePosition DOBMFCDBEKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class INKDNNLNAGK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6430", Offset = "0x6AD4A30", VA = "0x186AD6430")]
	public INKDNNLNAGK(bool BOOEACKNINO, string JODLKKKBNGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HJCCEJKFDLP
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CPAOJDOBFBG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BONJBCHFDAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKJGFNBCFAM(string IBBDLGCDELM, double DMNGPNKHPKF, [Optional] string? CMIEPNKLNOL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HNODDLDBOEC<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate Task<TResult> JPHKNIGAACM(CancellationToken FIMAIPEFOAM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct AHAKEPAFOGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public HNODDLDBOEC<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public JPHKNIGAACM taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x3CC5290", Offset = "0x3CC3890", VA = "0x183CC5290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3CC63D0", Offset = "0x3CC49D0", VA = "0x183CC63D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource OGOBIEKOEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? IOBMIIMBNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? ECAOFCLCDNO;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4140", Offset = "0x3DB2740", VA = "0x183DB4140")]
	[AsyncStateMachine(typeof(HNODDLDBOEC<>.AHAKEPAFOGH))]
	public Task<TResult> KCDNDHKLOKD(JPHKNIGAACM CIBDBPOBOGH, [Optional] CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3DB40D0", Offset = "0x3DB26D0", VA = "0x183DB40D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4290", Offset = "0x3DB2890", VA = "0x183DB4290")]
	public HNODDLDBOEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class GMDLEOCDPMJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> KCHFOCDLBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T FJLALGMPANI;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3D38420", Offset = "0x3D36A20", VA = "0x183D38420")]
	public GMDLEOCDPMJ([In] T DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D37810", Offset = "0x3D35E10", VA = "0x183D37810", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D37D90", Offset = "0x3D36390", VA = "0x183D37D90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3D38170", Offset = "0x3D36770", VA = "0x183D38170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class IGDAKNGMECG
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4740", Offset = "0x2BA2D40", VA = "0x182BA4740")]
	public static GMDLEOCDPMJ<T> ENFOKLPNHAF<T>([In] T DMNGPNKHPKF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FNEBNJMBKEG
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3220", Offset = "0x6AD1820", VA = "0x186AD3220")]
	public static void HGEJNGKPBPP(this CancellationTokenSource OGOBIEKOEBM, bool EIODLPAGKGI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class NNPEEIDJADD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
	public NNPEEIDJADD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class FBDLONGKOCP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
	public FBDLONGKOCP(string LLMMKBLKAOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class AKKMCKBMINM
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x32508E0", Offset = "0x324EEE0", VA = "0x1832508E0")]
	public static AJNKEGDABAJ NDLMIJGGMCA<T>()
	{
		return default(AJNKEGDABAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3250740", Offset = "0x324ED40", VA = "0x183250740")]
	public static AJNKEGDABAJ JHAKIFNCONI<T>([CallerMemberName] string GJEDHMJMNJA = "") where T : notnull
	{
		return default(AJNKEGDABAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3250960", Offset = "0x324EF60", VA = "0x183250960")]
	public static AJNKEGDABAJ NDLMIJGGMCA<T>(this T INKFLMKONLP) where T : notnull
	{
		return default(AJNKEGDABAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x32504F0", Offset = "0x324EAF0", VA = "0x1832504F0")]
	public static AJNKEGDABAJ HBKPIANKMMB<T>(this T INKFLMKONLP, [CallerMemberName] string GJEDHMJMNJA = "") where T : notnull
	{
		return default(AJNKEGDABAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3250690", Offset = "0x324EC90", VA = "0x183250690")]
	public static AJNKEGDABAJ JHAKIFNCONI<T>(this T HLIDMKMINHN, [CallerMemberName] string GJEDHMJMNJA = "") where T : notnull
	{
		return default(AJNKEGDABAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFAB0", Offset = "0x6ACE0B0", VA = "0x186ACFAB0")]
	public static AJNKEGDABAJ JHAKIFNCONI(string MDJFBHEKPLO, [CallerMemberName] string GJEDHMJMNJA = "")
	{
		return default(AJNKEGDABAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFB30", Offset = "0x6ACE130", VA = "0x186ACFB30")]
	public static string LGNOAPMCPAE(this object HLIDMKMINHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool KGBMHDNIDHG();
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NNPEEIDJADD]
public delegate long FNFMPHNNLPH();
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LAHHLOKPEPO
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static AAOGOMMNHDK DHAFLNKBBKM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static AAOGOMMNHDK HIBLEPFPOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6AD83A0", Offset = "0x6AD69A0", VA = "0x186AD83A0")]
		get
		{
			return default(AAOGOMMNHDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DPEKPLFEBPK ENFJABODILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6AD82B0", Offset = "0x6AD68B0", VA = "0x186AD82B0")]
		get
		{
			return default(DPEKPLFEBPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static HBJJGGBGKJD IDHLOIKAOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8260", Offset = "0x6AD6860", VA = "0x186AD8260")]
		get
		{
			return default(HBJJGGBGKJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool BGFBPKKCCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6AD84F0", Offset = "0x6AD6AF0", VA = "0x186AD84F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7EA0", Offset = "0x6AD64A0", VA = "0x186AD7EA0")]
	public static void CJBOAEBEDBI([In] AAOGOMMNHDK ODOPLOKIPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8050", Offset = "0x6AD6650", VA = "0x186AD8050")]
	public static void EPOKKHIFOPJ(string ELIMFPDKMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8560", Offset = "0x6AD6B60", VA = "0x186AD8560")]
	public static void OJDCNMADBEJ(string ELIMFPDKMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2C3C8F0", Offset = "0x2C3AEF0", VA = "0x182C3C8F0")]
	public static void OJDCNMADBEJ<T>(T CIFNGMCMOJD, GMCLIPPEICA<T> ELIMFPDKMPD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8630", Offset = "0x6AD6C30", VA = "0x186AD8630")]
	public static void POIKPBNGBLA(Exception LPFKIAHEHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8470", Offset = "0x6AD6A70", VA = "0x186AD8470")]
	public static void MFDDMMKLJLJ(string GJEDHMJMNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8120", Offset = "0x6AD6720", VA = "0x186AD8120")]
	public static void FCJCMIKNOAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6AD83F0", Offset = "0x6AD69F0", VA = "0x186AD83F0")]
	public static string LGNOAPMCPAE(object NJKKPOFFNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6AD7E30", Offset = "0x6AD6430", VA = "0x186AD7E30")]
	public static long BLKEJNNHOLP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8300", Offset = "0x6AD6900", VA = "0x186AD8300")]
	public static bool JFPGGCKLBAG(bool ECAAAOIMMGP, string ELIMFPDKMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8190", Offset = "0x6AD6790", VA = "0x186AD8190")]
	public static double GHOFABKMFKI()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct AAOGOMMNHDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly DPEKPLFEBPK ENFJABODILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly HBJJGGBGKJD IDHLOIKAOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly JNJHIIICEGB GODJCMAHKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly FNFMPHNNLPH IAACPHOCMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly HDDFIPNDIDK IPJGAALGOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly KGBMHDNIDHG JLFIFMEHBIM;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly JNJHIIICEGB LALNECOELIL;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly FNFMPHNNLPH JPMIDJJAAOP;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly HDDFIPNDIDK LAKAJJALDPK;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly KGBMHDNIDHG KLFPEILANLE;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly AAOGOMMNHDK CHPFPNHMMDE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool HIFFGJEKBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6ACEA30", Offset = "0x6ACD030", VA = "0x186ACEA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF410", Offset = "0x6ACDA10", VA = "0x186ACF410")]
	public AAOGOMMNHDK([In] DPEKPLFEBPK NFKKKJPFFFP, [In] HBJJGGBGKJD LJBBFKIFDNA, JNJHIIICEGB GPEFAGLJHCD, FNFMPHNNLPH HMMGBMPIEKD, HDDFIPNDIDK JDEBKIOLNHH, KGBMHDNIDHG GLELIKAGMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACEBD0", Offset = "0x6ACD1D0", VA = "0x186ACEBD0")]
	private static string GHIGEMDKMBH(object NJKKPOFFNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0")]
	private static long EGDMMKLDLOF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
	private static string FELCNMNAKLP(string KFOCKGMHIBO, string? PBJFNDLHABE, bool GICEPLKGONK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060")]
	private static bool APBNLCJDKKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6ACEC10", Offset = "0x6ACD210", VA = "0x186ACEC10")]
	private static AAOGOMMNHDK OEAJCJPAINP()
	{
		return default(AAOGOMMNHDK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DICLCLHAEJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NGCELENGPJI NKGJLAIFHHM();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NGCELENGPJI : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool ODICFMPPFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPNIAOKIMLP();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LAHDMDPGLOK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CBEHGBLKKJL([In] T BHFGHGMPKOJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void KMINJNGDOMI<T>([In] T CIFNGMCMOJD);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct DFBDAEGMHFC<T> : IEquatable<DFBDAEGMHFC<T>>, LAHDMDPGLOK<DFBDAEGMHFC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T FJLALGMPANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int MIMJDCDEIKK;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x201FB00", Offset = "0x201E100", VA = "0x18201FB00")]
	public DFBDAEGMHFC([In] T DMNGPNKHPKF, int PDMMEDBMFPP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x58BEF60", Offset = "0x58BD560", VA = "0x1858BEF60")]
	public static bool FFOLOHFBIHN([In] DFBDAEGMHFC<T> CLMMPLJCADB, [In] DFBDAEGMHFC<T> NIGNLACGOIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x44AF460", Offset = "0x44ADA60", VA = "0x1844AF460", Slot = "4")]
	public bool Equals(DFBDAEGMHFC<T> BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C840", Offset = "0x3E7AE40", VA = "0x183E7C840", Slot = "0")]
	public override bool Equals(object BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x58BEC60", Offset = "0x58BD260", VA = "0x1858BEC60")]
	public bool CBEHGBLKKJL([In] DFBDAEGMHFC<T> BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x58BFC70", Offset = "0x58BE270", VA = "0x1858BFC70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x58C00F0", Offset = "0x58BE6F0", VA = "0x1858C00F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x58BF3F0", Offset = "0x58BD9F0", VA = "0x1858BF3F0")]
	public void FPPGGEMJOOL([Out] T DMNGPNKHPKF, [Out] int PDMMEDBMFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x58BE940", Offset = "0x58BCF40", VA = "0x1858BE940")]
	public (T, int) BCKEGPOFPAI()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x58BFF10", Offset = "0x58BE510", VA = "0x1858BFF10", Slot = "5")]
	private bool MIOBPAKOPOA([In] DFBDAEGMHFC<T> BHFGHGMPKOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LMLDFHPICDD
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2C59700", Offset = "0x2C57D00", VA = "0x182C59700")]
	public static DFBDAEGMHFC<T> ENFOKLPNHAF<T>([In] T DMNGPNKHPKF, int PDMMEDBMFPP) where T : notnull
	{
		return default(DFBDAEGMHFC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class DEJGAKCDNND
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x29E7450", Offset = "0x29E5A50", VA = "0x1829E7450")]
	public static bool CBEHGBLKKJL<T, U>([In] T HLIDMKMINHN, [In] U NJKKPOFFNNJ) where T : notnull, LAHDMDPGLOK<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult DCAFOLJMGGN<T, out TResult>([In] T CIFNGMCMOJD);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface GBJDIBDNBPK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	TimeSpan OIJCBHHHDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Action? JLDIJAIMOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PNPOMLBEDFL();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHGEIOFNKPC();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LDDBOACCGAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct DPEKPLFEBPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly NHEPNIHOMAD FFEDMPNBMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly KPIEADNBIAN AFLCNACPGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly NHEPNIHOMAD EABGBACFNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly KPIEADNBIAN EAKGAJDKGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly NHEPNIHOMAD KPKCADOFBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly KPIEADNBIAN CKFCDFKIHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly ELADHIACJON DNKKCCNGINM;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly NHEPNIHOMAD MMLMILEHNKK;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly KPIEADNBIAN IFKBMIIKKMH;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly NHEPNIHOMAD HJDIOKNCJCD;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly KPIEADNBIAN LMDBOBOKAGH;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly NHEPNIHOMAD IHBNMBPFLKP;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly KPIEADNBIAN OPHOFFNKPFB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly ELADHIACJON PJMMENODMLH;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly DPEKPLFEBPK CHPFPNHMMDE;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly NHEPNIHOMAD FIHDCIJLCEJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool HIFFGJEKBHK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1780", Offset = "0x6ACFD80", VA = "0x186AD1780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xB65D50", Offset = "0xB64350", VA = "0x180B65D50")]
	public DPEKPLFEBPK(NHEPNIHOMAD GFFFJPEPOFI, KPIEADNBIAN ILOBDCBAJBF, NHEPNIHOMAD PKLMAMGNEBF, KPIEADNBIAN PEEMAHIBOHA, NHEPNIHOMAD FKDADBIFDNA, KPIEADNBIAN JKMAEKPIFDH, ELADHIACJON MAKMELGCCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060")]
	private static bool JNMEIBJBLLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	private static void FMCEFGIGNHI(string ELIMFPDKMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060")]
	private static bool HDMFFDKAPOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	private static void KAGAMDGIDKO(string ELIMFPDKMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060")]
	private static bool IFDFKNBIPPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	private static void PLIMMIMOLFI(string ELIMFPDKMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	private static void LEKADIJFGOE(Exception LPFKIAHEHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1AC0", Offset = "0x6AD00C0", VA = "0x186AD1AC0")]
	private static DPEKPLFEBPK OEAJCJPAINP()
	{
		return default(DPEKPLFEBPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710")]
	private static bool NBDEIOCLKEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1980", Offset = "0x6ACFF80", VA = "0x186AD1980")]
	public void EPOKKHIFOPJ(object ELIMFPDKMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1CE0", Offset = "0x6AD02E0", VA = "0x186AD1CE0")]
	public void OJDCNMADBEJ(object ELIMFPDKMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1C40250", Offset = "0x1C3E850", VA = "0x181C40250")]
	public void POIKPBNGBLA(Exception LPFKIAHEHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1C00", Offset = "0x6AD0200", VA = "0x186AD1C00")]
	public void OJDCNMADBEJ(AJGOJEJALOO ELIMFPDKMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x29F2040", Offset = "0x29F0640", VA = "0x1829F2040")]
	public void OJDCNMADBEJ<T>(T CIFNGMCMOJD, GMCLIPPEICA<T> ELIMFPDKMPD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x29F1D00", Offset = "0x29F0300", VA = "0x1829F1D00")]
	public void EPOKKHIFOPJ<T>([In] T CIFNGMCMOJD, GAMOHBEACEM<T> ELIMFPDKMPD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x29F1EA0", Offset = "0x29F04A0", VA = "0x1829F1EA0")]
	public void OJDCNMADBEJ<T>([In] T CIFNGMCMOJD, GAMOHBEACEM<T> ELIMFPDKMPD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD19F0", Offset = "0x6ACFFF0", VA = "0x186AD19F0")]
	public bool JFPGGCKLBAG(bool ECAAAOIMMGP, string ELIMFPDKMPD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct AJNKEGDABAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string FJLALGMPANI;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x958AF0", Offset = "0x9570F0", VA = "0x180958AF0")]
	public AJNKEGDABAJ(string DMNGPNKHPKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
	public static string HDKGBCFDEBL([In] AJNKEGDABAJ HLIDMKMINHN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x9B5B10", Offset = "0x9B4110", VA = "0x1809B5B10")]
	public static AJNKEGDABAJ HDKGBCFDEBL(string BHFGHGMPKOJ)
	{
		return default(AJNKEGDABAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF980", Offset = "0x6ACDF80", VA = "0x186ACF980")]
	public string KCIOCCDNMKF(string NDEKMIKNIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF9D0", Offset = "0x6ACDFD0", VA = "0x186ACF9D0")]
	public string NEMKHHCMNEL(object NEBEKAIMCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct COKMANPFJNC : IEquatable<COKMANPFJNC>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "4")]
	public bool Equals(COKMANPFJNC BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFFA0", Offset = "0x6ACE5A0", VA = "0x186ACFFA0", Slot = "0")]
	public override bool Equals(object BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6ACFFF0", Offset = "0x6ACE5F0", VA = "0x186ACFFF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0000", Offset = "0x6ACE600", VA = "0x186AD0000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DFMFJMBJIGJ("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct MADCGGOAHGO<T> : IEquatable<MADCGGOAHGO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T FJLALGMPANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool GMEFPDNCGLJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool AMNDNLGFLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x44AF450", Offset = "0x44ADA50", VA = "0x1844AF450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x44B0700", Offset = "0x44AED00", VA = "0x1844B0700")]
	public MADCGGOAHGO([In] T DMNGPNKHPKF, bool MMJAMPDOBEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x44AFE20", Offset = "0x44AE420", VA = "0x1844AFE20")]
	public static bool FFOLOHFBIHN([In] MADCGGOAHGO<T> CLMMPLJCADB, [In] MADCGGOAHGO<T> NIGNLACGOIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x44AF460", Offset = "0x44ADA60", VA = "0x1844AF460", Slot = "4")]
	public bool Equals(MADCGGOAHGO<T> BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x44AFAA0", Offset = "0x44AE0A0", VA = "0x1844AFAA0", Slot = "0")]
	public override bool Equals(object BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x44B0070", Offset = "0x44AE670", VA = "0x1844B0070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x44B03B0", Offset = "0x44AE9B0", VA = "0x1844B03B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class LBIHGLHPIOE
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2C3CD40", Offset = "0x2C3B340", VA = "0x182C3CD40")]
	public static MADCGGOAHGO<T> OGMDFHMIJJH<T>([In] T DMNGPNKHPKF) where T : notnull
	{
		return default(MADCGGOAHGO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2C3CC00", Offset = "0x2C3B200", VA = "0x182C3CC00")]
	public static MADCGGOAHGO<T?> MEAKIPEBJEP<T>()
	{
		return default(MADCGGOAHGO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2C3CB90", Offset = "0x2C3B190", VA = "0x182C3CB90")]
	public static bool GJNNKDNEIFB<T>([In] this MADCGGOAHGO<T> KFDBDDGKFFJ, [Out][NotNullWhen(true)] T DMNGPNKHPKF) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct HBJJGGBGKJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr MFDDMMKLJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr FCJCMIKNOAA;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr LAJOMEKBAHO;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr GJFKCIJINFD;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly HBJJGGBGKJD CHPFPNHMMDE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool HIFFGJEKBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6AD37F0", Offset = "0x6AD1DF0", VA = "0x186AD37F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xAED250", Offset = "0xAEB850", VA = "0x180AED250")]
	public HBJJGGBGKJD(IntPtr KLDBNGMDIAF, IntPtr GAIMGANMEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	private static void NLJLMMICECF(string GJEDHMJMNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	private static void GPHPJIDBAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6AD38D0", Offset = "0x6AD1ED0", VA = "0x186AD38D0")]
	private static HBJJGGBGKJD OEAJCJPAINP()
	{
		return default(HBJJGGBGKJD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct OPACEPFOBGK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr GGAALNGFLIF;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x958AF0", Offset = "0x9570F0", VA = "0x180958AF0")]
	private OPACEPFOBGK(IntPtr GAIMGANMEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6AD95B0", Offset = "0x6AD7BB0", VA = "0x186AD95B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD95D0", Offset = "0x6AD7BD0", VA = "0x186AD95D0")]
	public static OPACEPFOBGK ENFOKLPNHAF(string GJEDHMJMNJA)
	{
		return default(OPACEPFOBGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1FF64F0", Offset = "0x1FF4AF0", VA = "0x181FF64F0")]
	public static OPACEPFOBGK ENFOKLPNHAF([In] HBJJGGBGKJD LJBBFKIFDNA, string GJEDHMJMNJA)
	{
		return default(OPACEPFOBGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1FF6170", Offset = "0x1FF4770", VA = "0x181FF6170")]
	public static OPACEPFOBGK ENFOKLPNHAF([In] HBJJGGBGKJD LJBBFKIFDNA, Func<string> GJEDHMJMNJA)
	{
		return default(OPACEPFOBGK);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class IKGEPEALMEN
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate bool JAHNHPLALEM<in TInput, TResult>(TInput BNBKMKBLLLG, [Out] TResult IAFCFGOKEAK);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class MAIPMDOJGFA : DICLCLHAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class ENMDJJLNLIC : NGCELENGPJI, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly ENMDJJLNLIC CFNNMJAMDBB;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool ODICFMPPFHN
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x6AD26C0", Offset = "0x6AD0CC0", VA = "0x186AD26C0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6AD2720", Offset = "0x6AD0D20", VA = "0x186AD2720", Slot = "6")]
			public void OnCompleted(Action BICHGGDOAOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
			public void KPNIAOKIMLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public ENMDJJLNLIC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly MAIPMDOJGFA CFNNMJAMDBB;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		private MAIPMDOJGFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8790", Offset = "0x6AD6D90", VA = "0x186AD8790", Slot = "4")]
		public NGCELENGPJI NKGJLAIFHHM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private sealed class ECBGHFJDMND : DICLCLHAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private sealed class JKNEPBIEKND : NGCELENGPJI, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly JKNEPBIEKND CFNNMJAMDBB;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool ODICFMPPFHN
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x6AD71C0", Offset = "0x6AD57C0", VA = "0x186AD71C0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6AD71E0", Offset = "0x6AD57E0", VA = "0x186AD71E0", Slot = "6")]
			public void OnCompleted(Action BICHGGDOAOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
			public void KPNIAOKIMLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public JKNEPBIEKND()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly ECBGHFJDMND CFNNMJAMDBB;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		private ECBGHFJDMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2330", Offset = "0x6AD0930", VA = "0x186AD2330", Slot = "4")]
		public NGCELENGPJI NKGJLAIFHHM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class IFLOJHEPIMA<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public IFLOJHEPIMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3E68C20", Offset = "0x3E67220", VA = "0x183E68C20")]
		internal void GOCGAMOIJBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class DADPIKDKNPA<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public DADPIKDKNPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x54972C0", Offset = "0x54958C0", VA = "0x1854972C0")]
		internal void LELOCLJJFBG(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct HNGEDEGFAHE : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3BB0", Offset = "0x6AD21B0", VA = "0x186AD3BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct FDLIEGMDKGI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2900", Offset = "0x6AD0F00", VA = "0x186AD2900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct EMNKKPKNJOK<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x388A790", Offset = "0x3888D90", VA = "0x18388A790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x388A900", Offset = "0x3888F00", VA = "0x18388A900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct ACHHPGFPKDH<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3CAC6D0", Offset = "0x3CAACD0", VA = "0x183CAC6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3CACB20", Offset = "0x3CAB120", VA = "0x183CACB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct MNMODGLBKGE : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8860", Offset = "0x6AD6E60", VA = "0x186AD8860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8A60", Offset = "0x6AD7060", VA = "0x186AD8A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class IFNMFMICOKD<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public IFNMFMICOKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3E68C20", Offset = "0x3E67220", VA = "0x183E68C20")]
		internal void FLJFIJEJPMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3E68C90", Offset = "0x3E67290", VA = "0x183E68C90")]
		internal void MLOLKBAEDMI(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct NHBHADLAMIC<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public JAHNHPLALEM<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x45CAB60", Offset = "0x45C9160", VA = "0x1845CAB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x45CB2D0", Offset = "0x45C98D0", VA = "0x1845CB2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct KNFOBANLIAB : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6AD75E0", Offset = "0x6AD5BE0", VA = "0x186AD75E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7DD0", Offset = "0x6AD63D0", VA = "0x186AD7DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct GJKCDGLGBID : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3250", Offset = "0x6AD1850", VA = "0x186AD3250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6AD3790", Offset = "0x6AD1D90", VA = "0x186AD3790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct FBKAPBLAEHM<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3BFCFD0", Offset = "0x3BFB5D0", VA = "0x183BFCFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDF20", Offset = "0x3BFC520", VA = "0x183BFDF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct MHDLELPALBC<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x44CAAF0", Offset = "0x44C90F0", VA = "0x1844CAAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x35C1790", Offset = "0x35BFD90", VA = "0x1835C1790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct MDOCLBAJHKK<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x44C0020", Offset = "0x44BE620", VA = "0x1844C0020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x44C0770", Offset = "0x44BED70", VA = "0x1844C0770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct FIAJIALPIMF : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2A10", Offset = "0x6AD1010", VA = "0x186AD2A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2BF0", Offset = "0x6AD11F0", VA = "0x186AD2BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct PJKBBFHLFNB : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9C00", Offset = "0x6AD8200", VA = "0x186AD9C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9F70", Offset = "0x6AD8570", VA = "0x186AD9F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct PCBCFFBKMOJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6AD98B0", Offset = "0x6AD7EB0", VA = "0x186AD98B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9BA0", Offset = "0x6AD81A0", VA = "0x186AD9BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class KJDGFICGFJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public KJDGFICGFJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7570", Offset = "0x6AD5B70", VA = "0x186AD7570")]
		internal Task GHBJMNOBPLL(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct EGFDEOGHKAI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2400", Offset = "0x6AD0A00", VA = "0x186AD2400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6AD2660", Offset = "0x6AD0C60", VA = "0x186AD2660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct MPEFCLHNCON : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8AD0", Offset = "0x6AD70D0", VA = "0x186AD8AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8CB0", Offset = "0x6AD72B0", VA = "0x186AD8CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct CDFGMKMMCBP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6ACFBD0", Offset = "0x6ACE1D0", VA = "0x186ACFBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6ACFF40", Offset = "0x6ACE540", VA = "0x186ACFF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct IPDOOGCBMKN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6510", Offset = "0x6AD4B10", VA = "0x186AD6510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6800", Offset = "0x6AD4E00", VA = "0x186AD6800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class IAMNMMNJJBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public IAMNMMNJJBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6AD4030", Offset = "0x6AD2630", VA = "0x186AD4030")]
		internal Task DBDCDNFBHFE(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct JLGGLFJMAKF : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6AD72B0", Offset = "0x6AD58B0", VA = "0x186AD72B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7510", Offset = "0x6AD5B10", VA = "0x186AD7510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct OPGCECHPKCK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6AD96D0", Offset = "0x6AD7CD0", VA = "0x186AD96D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9850", Offset = "0x6AD7E50", VA = "0x186AD9850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct EDOJNOGDBPD<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x385B100", Offset = "0x3859700", VA = "0x18385B100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x385B380", Offset = "0x3859980", VA = "0x18385B380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct AJECBFNHCEL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6ACF4C0", Offset = "0x6ACDAC0", VA = "0x186ACF4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6ACF8D0", Offset = "0x6ACDED0", VA = "0x186ACF8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? NCHGOPBLIJK;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<COKMANPFJNC> JDOKGPDIONI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static Task CCPCNJGGAKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6AD5F50", Offset = "0x6AD4550", VA = "0x186AD5F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5570", Offset = "0x6AD3B70", VA = "0x186AD5570")]
	public static bool EGAJOGDLLIM(this Task NAFOIMCAMMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2BDBE60", Offset = "0x2BDA460", VA = "0x182BDBE60")]
	public static Task<T> NMBHDAHJMHH<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6AD55A0", Offset = "0x6AD3BA0", VA = "0x186AD55A0")]
	public static Task FDKFIDCMADD(this Task NAFOIMCAMMG, CancellationToken NJLOKHEKBBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9D00", Offset = "0x2BD8300", VA = "0x182BD9D00")]
	public static Task<TResult> FDKFIDCMADD<TResult>(this Task<TResult> NAFOIMCAMMG, CancellationToken NJLOKHEKBBE) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAC90", Offset = "0x2BD9290", VA = "0x182BDAC90")]
	public static TaskCompletionSource<TResult> FDKFIDCMADD<TResult>(this TaskCompletionSource<TResult> MAJHLODNNLP, CancellationToken NJLOKHEKBBE) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5FC0", Offset = "0x6AD45C0", VA = "0x186AD5FC0")]
	public static IDisposable? OODBIHDOLPN(CancellationToken KCOEKHCDAFF, CancellationToken LOODMIONJPM, [Out] CancellationToken HOKPPJNPCEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5800", Offset = "0x6AD3E00", VA = "0x186AD5800")]
	[AsyncStateMachine(typeof(HNGEDEGFAHE))]
	public static void FECHEEMJNHB(this Task FCNFHCDDANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6AD54C0", Offset = "0x6AD3AC0", VA = "0x186AD54C0")]
	[AsyncStateMachine(typeof(FDLIEGMDKGI))]
	public static void EBPAHAOBGLL(this Task FCNFHCDDANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2BDBBB0", Offset = "0x2BDA1B0", VA = "0x182BDBBB0")]
	[AsyncStateMachine(typeof(EMNKKPKNJOK<>))]
	public static Task IJLFCBFGJFL<TException>(this Task FCNFHCDDANP) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB620", Offset = "0x2BD9C20", VA = "0x182BDB620")]
	[AsyncStateMachine(typeof(ACHHPGFPKDH<>))]
	public static Task<T> GGBDHACOKMG<T>(this Task<T> HLIDMKMINHN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4CB0", Offset = "0x6AD32B0", VA = "0x186AD4CB0")]
	[AsyncStateMachine(typeof(MNMODGLBKGE))]
	public static Task<TaskStatus> BGIFBCJIAHL(this Task HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2BDBFE0", Offset = "0x2BDA5E0", VA = "0x182BDBFE0")]
	public static (Task<T?>?, Action<T?>?) PKFCMANBALJ<T>([Optional] CancellationToken FIMAIPEFOAM)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB800", Offset = "0x2BD9E00", VA = "0x182BDB800")]
	[AsyncStateMachine(typeof(NHBHADLAMIC<, >))]
	public static Task<List<TResult>> GNCJLCGDMHJ<TResult, TInput>(this Task<List<TInput>> NAFOIMCAMMG, JAHNHPLALEM<TInput, TResult> BNJLIAMADFB) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4DA0", Offset = "0x6AD33A0", VA = "0x186AD4DA0")]
	[AsyncStateMachine(typeof(KNFOBANLIAB))]
	public static Task BJNPDPIFBDI(Task FCNFHCDDANP, CancellationToken BGOKJICAAAH, Func<CancellationToken, Task> AKINCOGLEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5980", Offset = "0x6AD3F80", VA = "0x186AD5980")]
	[AsyncStateMachine(typeof(GJKCDGLGBID))]
	public static Task HENODJLPAJL(Func<CancellationToken, Task> JLMOGOMDJNI, TimeSpan KKDJEDBPJMM, [Optional] CancellationToken BGOKJICAAAH, [Optional] Action<OperationCanceledException>? FNCKIIFEJMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB910", Offset = "0x2BD9F10", VA = "0x182BDB910")]
	[AsyncStateMachine(typeof(FBKAPBLAEHM<>))]
	public static Task<T> HENODJLPAJL<T>(Func<CancellationToken, Task<T>> JLMOGOMDJNI, TimeSpan KKDJEDBPJMM, [Optional] CancellationToken BGOKJICAAAH, [Optional] Func<OperationCanceledException, T>? FNCKIIFEJMC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2BDBD70", Offset = "0x2BDA370", VA = "0x182BDBD70")]
	[AsyncStateMachine(typeof(MHDLELPALBC<>))]
	public static Task<IEnumerable<Task<T>>> LOJKBJNGPML<T>(IEnumerable<Task<T>> PIBJDKJDAAP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2BD7E10", Offset = "0x2BD6410", VA = "0x182BD7E10")]
	[AsyncStateMachine(typeof(MDOCLBAJHKK<, , , >))]
	public static Task<(T1, T2, T3, T4)> BDBHEECCADA<T1, T2, T3, T4>(Task<T1> FIJJILBJKKK, Task<T2> PNPPEJEJGND, Task<T3> CNMEPKHPNJO, Task<T4> OFGLBHPLCFF) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4BC0", Offset = "0x6AD31C0", VA = "0x186AD4BC0")]
	[AsyncStateMachine(typeof(FIAJIALPIMF))]
	public static Task BELGCPCCAPF(Func<bool> ECAAAOIMMGP, [Optional] CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4AB0", Offset = "0x6AD30B0", VA = "0x186AD4AB0")]
	[AsyncStateMachine(typeof(PJKBBFHLFNB))]
	public static Task BELGCPCCAPF(Func<bool> ECAAAOIMMGP, TimeSpan DDPOFLCGNEH, [Optional] CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6240", Offset = "0x6AD4840", VA = "0x186AD6240")]
	[AsyncStateMachine(typeof(PCBCFFBKMOJ))]
	public static Task PGOKLICBAFP(Func<bool> ECAAAOIMMGP, TimeSpan KKDJEDBPJMM, [Optional] CancellationToken FIMAIPEFOAM, [Optional] Action<OperationCanceledException>? FNCKIIFEJMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6AD6100", Offset = "0x6AD4700", VA = "0x186AD6100")]
	[AsyncStateMachine(typeof(EGFDEOGHKAI))]
	public static Task PGOKLICBAFP(Func<bool> ECAAAOIMMGP, TimeSpan KKDJEDBPJMM, TimeSpan DDPOFLCGNEH, [Optional] CancellationToken FIMAIPEFOAM, [Optional] Action<OperationCanceledException>? FNCKIIFEJMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6AD48B0", Offset = "0x6AD2EB0", VA = "0x186AD48B0")]
	[AsyncStateMachine(typeof(MPEFCLHNCON))]
	public static Task BDHIBNFJKHL(Func<bool> ECAAAOIMMGP, [Optional] CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6AD49A0", Offset = "0x6AD2FA0", VA = "0x186AD49A0")]
	[AsyncStateMachine(typeof(CDFGMKMMCBP))]
	public static Task BDHIBNFJKHL(Func<bool> ECAAAOIMMGP, TimeSpan DDPOFLCGNEH, [Optional] CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5010", Offset = "0x6AD3610", VA = "0x186AD5010")]
	[AsyncStateMachine(typeof(IPDOOGCBMKN))]
	public static Task BLOIGBKMDKG(Func<bool> ECAAAOIMMGP, TimeSpan KKDJEDBPJMM, [Optional] CancellationToken FIMAIPEFOAM, [Optional] Action<OperationCanceledException>? FNCKIIFEJMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4ED0", Offset = "0x6AD34D0", VA = "0x186AD4ED0")]
	[AsyncStateMachine(typeof(JLGGLFJMAKF))]
	public static Task BLOIGBKMDKG(Func<bool> ECAAAOIMMGP, TimeSpan KKDJEDBPJMM, TimeSpan DDPOFLCGNEH, [Optional] CancellationToken FIMAIPEFOAM, [Optional] Action<OperationCanceledException>? FNCKIIFEJMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6AD47C0", Offset = "0x6AD2DC0", VA = "0x186AD47C0")]
	[Obsolete]
	[AsyncStateMachine(typeof(OPGCECHPKCK))]
	public static Task AFMEEGMIMEG(this Task NAFOIMCAMMG, Action IMIGBCAMCPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2BD7D20", Offset = "0x2BD6320", VA = "0x182BD7D20")]
	[AsyncStateMachine(typeof(EDOJNOGDBPD<>))]
	[Obsolete]
	public static Task AFMEEGMIMEG<T>(this Task<T> NAFOIMCAMMG, Action<T> IMIGBCAMCPB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4710", Offset = "0x6AD2D10", VA = "0x186AD4710")]
	private static void ABADHGGLEMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5140", Offset = "0x6AD3740", VA = "0x186AD5140")]
	public static bool DKDCPHBJLNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5CA0", Offset = "0x6AD42A0", VA = "0x186AD5CA0")]
	private static void MHIAGFIKGNF(SynchronizationContext DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5E30", Offset = "0x6AD4430", VA = "0x186AD5E30")]
	private static void NJGHCAFCIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6AD58B0", Offset = "0x6AD3EB0", VA = "0x186AD58B0")]
	public static void HCAFHOCAOBD([Optional] string? ELIMFPDKMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5AB0", Offset = "0x6AD40B0", VA = "0x186AD5AB0")]
	public static void IAPDNOGBAID([Optional] string? ELIMFPDKMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5C50", Offset = "0x6AD4250", VA = "0x186AD5C50")]
	public static DICLCLHAEJJ LMKHPBDKPLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5C00", Offset = "0x6AD4200", VA = "0x186AD5C00")]
	public static DICLCLHAEJJ LBAEDLNIJNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6AD5B30", Offset = "0x6AD4130", VA = "0x186AD5B30")]
	[AsyncStateMachine(typeof(AJECBFNHCEL))]
	public static Task IPIFPMKFFOH(Func<Task> ILHEMCJEFIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class OBKEFOLKLJN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
	public OBKEFOLKLJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class OMBGBMBCGEN : AIHEAHBFNLA
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly AIHEAHBFNLA CFNNMJAMDBB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTime JFFIJHCCADB
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6AD9490", Offset = "0x6AD7A90", VA = "0x186AD9490", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DateTimeOffset FEBGHMIMHNL
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6AD94D0", Offset = "0x6AD7AD0", VA = "0x186AD94D0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public OMBGBMBCGEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface AIHEAHBFNLA
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTime JFFIJHCCADB
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DateTimeOffset FEBGHMIMHNL
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DLIONIHBCFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long KKKOFOMIPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1210", Offset = "0x6ACF810", VA = "0x186AD1210")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static long CHNLOLDEPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6AD13D0", Offset = "0x6ACF9D0", VA = "0x186AD13D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double FLFOJAPPFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0F50", Offset = "0x6ACF550", VA = "0x186AD0F50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double KNANHJHJIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1330", Offset = "0x6ACF930", VA = "0x186AD1330")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double KHBOCHALNFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0FA0", Offset = "0x6ACF5A0", VA = "0x186AD0FA0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static double BGNENONDFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1380", Offset = "0x6ACF980", VA = "0x186AD1380")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1110", Offset = "0x6ACF710", VA = "0x186AD1110")]
	public static double GJCLCNHJBFM(long JKAECHJJKNH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1420", Offset = "0x6ACFA20", VA = "0x186AD1420")]
	public static double OPNCBOHNLOJ(long JKAECHJJKNH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1080", Offset = "0x6ACF680", VA = "0x186AD1080")]
	public static double GILLIALHOBN(double IOAFNJDHKOH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0FF0", Offset = "0x6ACF5F0", VA = "0x186AD0FF0")]
	public static long DAGNMHPMMMI(long HAGKGIBCOBL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1200", Offset = "0x6ACF800", VA = "0x186AD1200")]
	public static long HMOIOCNCKHC(long EOOBJDDDKBO, long KCHJFNHNHDL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD1260", Offset = "0x6ACF860", VA = "0x186AD1260")]
	public static double KCNCONFBCIP(long EOOBJDDDKBO, long KCHJFNHNHDL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD11A0", Offset = "0x6ACF7A0", VA = "0x186AD11A0")]
	public static double GJGMOJCECDF(long EOOBJDDDKBO, long KCHJFNHNHDL)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class NKIKEACPCAG : GBJDIBDNBPK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static readonly TimeSpan GCNJPGCGIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly System.Timers.Timer LAEFIIJCIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private TimeSpan KKDJEDBPJMM;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public TimeSpan OIJCBHHHDHF
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8E50", Offset = "0x6AD7450", VA = "0x186AD8E50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Action? JLDIJAIMOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x868250", Offset = "0x866850", VA = "0x180868250", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6AD93A0", Offset = "0x6AD79A0", VA = "0x186AD93A0")]
	[Preserve]
	public NKIKEACPCAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9150", Offset = "0x6AD7750", VA = "0x186AD9150")]
	public NKIKEACPCAG(TimeSpan KKDJEDBPJMM, [Optional] Action? KJBACLFBFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6AD9050", Offset = "0x6AD7650", VA = "0x186AD9050", Slot = "7")]
	public void PNPOMLBEDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8FE0", Offset = "0x6AD75E0", VA = "0x186AD8FE0", Slot = "8")]
	public void OHGEIOFNKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8FB0", Offset = "0x6AD75B0", VA = "0x186AD8FB0", Slot = "9")]
	public void LDDBOACCGAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x962640", Offset = "0x960C40", VA = "0x180962640")]
	private void ACPKBCMHPGF(object INKFLMKONLP, ElapsedEventArgs NGLCDAEGEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8DB0", Offset = "0x6AD73B0", VA = "0x186AD8DB0")]
	private static void GFNGDCMCMID(TimeSpan AMMKBBOMOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8D10", Offset = "0x6AD7310", VA = "0x186AD8D10", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class DFMFJMBJIGJ : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly string? EJLKJGGGHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly string DHPDLCKPBBP;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x1D67910", Offset = "0x1D65F10", VA = "0x181D67910")]
	public DFMFJMBJIGJ(string GJGIHJIAHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3CB12E0", Offset = "0x3CAF8E0", VA = "0x183CB12E0")]
	public DFMFJMBJIGJ(string CMJCNJNCICI, string GJGIHJIAHKC)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct DLDLNHCGMKC : IEquatable<DLDLNHCGMKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public uint NKGLPLHEDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int KGDOGHACOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float MAFOFKDLBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public ushort GCAPOPAEPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public ushort KFOBLHACPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public short MJKAMAHINEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public short APAIEHAPKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public char FIPGHGEOMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public char BGALAIPBPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte JIDNBGLKPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte AHCKEKCODJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public byte NJBIFMDAEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte LNJIMDIKDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool HNGJKBHNNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool CIFDNBGGLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public bool EJKIILIPILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool KKDHECJKHGP;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xE29C50", Offset = "0xE28250", VA = "0x180E29C50")]
	public static DLDLNHCGMKC IPINIKMGFIJ(uint BFBBFOCOJGL)
	{
		return default(DLDLNHCGMKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0xE29C50", Offset = "0xE28250", VA = "0x180E29C50")]
	public static DLDLNHCGMKC MDIKBNGEJND(int APJPIEIELEM)
	{
		return default(DLDLNHCGMKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD00E0", Offset = "0x6ACE6E0", VA = "0x186AD00E0")]
	public static DLDLNHCGMKC JFHIONLADOE(float AHKGKFJPKPB)
	{
		return default(DLDLNHCGMKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0030", Offset = "0x6ACE630", VA = "0x186AD0030")]
	public static DLDLNHCGMKC GIKONEOLNEK(byte GHDOBKGLOFH, byte PNKNJPDIJGG, byte KOGOMKEFCAB, byte BNJGIMFFCOL)
	{
		return default(DLDLNHCGMKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0030", Offset = "0x6ACE630", VA = "0x186AD0030")]
	public static DLDLNHCGMKC DHFPHBMBHDF(bool JBFEODKOKAK, bool HIFBLHPDJBA, bool GDEFAELHLJJ, bool LEOAMMFADOA)
	{
		return default(DLDLNHCGMKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0030", Offset = "0x6ACE630", VA = "0x186AD0030")]
	public static DLDLNHCGMKC PFKDILMONAP(byte HDBDNFFJMIH, byte JCPPKEMMDLP, byte JAGGANPJPCM, byte OHFHKAPABBG)
	{
		return default(DLDLNHCGMKC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1AD3120", Offset = "0x1AD1720", VA = "0x181AD3120")]
	public static bool FFOLOHFBIHN(DLDLNHCGMKC OIMGCNDKIAD, DLDLNHCGMKC LMBIFCGLAFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0xA44B60", Offset = "0xA43160", VA = "0x180A44B60", Slot = "4")]
	public bool Equals(DLDLNHCGMKC BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6AD0050", Offset = "0x6ACE650", VA = "0x186AD0050", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xAED3A0", Offset = "0xAEB9A0", VA = "0x180AED3A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6AD00F0", Offset = "0x6ACE6F0", VA = "0x186AD00F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct AJILKJFGEJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public ulong IEDJFHMDIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public long MIGPIMKFHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public double JGLIOELGMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint AGJKIGGKFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint GFNNPDOCFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public int PDOOICDCJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int HJIHBHFJAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float DJGJBFLHBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float AEMINNOCCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort GCAPOPAEPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort KFOBLHACPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public ushort OCJDMDPBKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort EEEMDOELHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short MJKAMAHINEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short APAIEHAPKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public short DCDCMKOPBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short FAMCODLLNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char FIPGHGEOMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char BGALAIPBPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public char NOALBLDAOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char MPCEMLIDEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte JIDNBGLKPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte AHCKEKCODJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte NJBIFMDAEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte LNJIMDIKDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte CGIINKFFBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte PCEKPBIDONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte MJIAJNLHGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte KOGFEHFLCKP;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6ACF930", Offset = "0x6ACDF30", VA = "0x186ACF930")]
	public static AJILKJFGEJK ENFOKLPNHAF(byte GHDOBKGLOFH, byte PNKNJPDIJGG, byte KOGOMKEFCAB, byte BNJGIMFFCOL, byte KAOCGINEGKA, byte JANAEEOGGEI, byte DMKODHJDLIM, byte NGKLAOIPADB)
	{
		return default(AJILKJFGEJK);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct HNNAJJEIOJM : IEquatable<HNNAJJEIOJM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte KBCHCKPPOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool OJCDICNNGPF;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x25C2E10", Offset = "0x25C1410", VA = "0x1825C2E10")]
	public static HNNAJJEIOJM GIKONEOLNEK(byte FMHNFIAFDPE)
	{
		return default(HNNAJJEIOJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x25C2E10", Offset = "0x25C1410", VA = "0x1825C2E10")]
	public static HNNAJJEIOJM DHFPHBMBHDF(bool PKDNAJDAIFN)
	{
		return default(HNNAJJEIOJM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3DA0", Offset = "0x6AD23A0", VA = "0x186AD3DA0")]
	public static bool FFOLOHFBIHN(HNNAJJEIOJM OIMGCNDKIAD, HNNAJJEIOJM LMBIFCGLAFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5C64200", Offset = "0x5C62800", VA = "0x185C64200", Slot = "4")]
	public bool Equals(HNNAJJEIOJM BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3D10", Offset = "0x6AD2310", VA = "0x186AD3D10", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3DB0", Offset = "0x6AD23B0", VA = "0x186AD3DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD3DC0", Offset = "0x6AD23C0", VA = "0x186AD3DC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class JFHOELAOGFC<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public readonly T FMGDHIOGPNC;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4085F60", Offset = "0x4084560", VA = "0x184085F60")]
	public JFHOELAOGFC(T MBKOIFKCONE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class HGENPAAFHKF
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2BA48C0", Offset = "0x2BA2EC0", VA = "0x182BA48C0")]
	public static IEnumerable<T> NCMDLBOGIAM<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
	public static T[] ILEFJHFCION<T>(params T[] GNKDJADDIOD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
	public static IEnumerable<T> KJKDHOAAPHF<T>(params T[] GNKDJADDIOD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4740", Offset = "0x2BA2D40", VA = "0x182BA4740")]
	public static HashSet<T> OGIPCMPNPJL<T>(params T[] GNKDJADDIOD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2BA47D0", Offset = "0x2BA2DD0", VA = "0x182BA47D0")]
	public static KeyValuePair<TKey, TValue> FGCDFDICIMG<TKey, TValue>([In] TKey IBBDLGCDELM, [In] TValue DMNGPNKHPKF) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4740", Offset = "0x2BA2D40", VA = "0x182BA4740")]
	public static List<T> AGNGMMJMCEF<T>(IEnumerable<T> DOCJELGKFHE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[AttributeUsage(AttributeTargets.All)]
public sealed class FNPBPKLPLIC : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public readonly string JGENIBHHAMM;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x8917F0", Offset = "0x88FDF0", VA = "0x1808917F0")]
	public FNPBPKLPLIC(string AKJLINGBOGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object GAMOHBEACEM<T>([In] T CNKOAIGMGCF);
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate object GMCLIPPEICA<T>(T CNKOAIGMGCF);
[Cpp2IlInjected.Token(Token = "0x200005A")]
[NNPEEIDJADD]
public delegate string HDDFIPNDIDK(string KFOCKGMHIBO, string? PBJFNDLHABE, bool GICEPLKGONK);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[NNPEEIDJADD]
public delegate void KPIEADNBIAN(string ELIMFPDKMPD);
[Cpp2IlInjected.Token(Token = "0x200005C")]
[NNPEEIDJADD]
public delegate void ELADHIACJON(Exception LPFKIAHEHEL);
[Cpp2IlInjected.Token(Token = "0x200005D")]
public delegate object AJGOJEJALOO();
[Cpp2IlInjected.Token(Token = "0x200005E")]
[NNPEEIDJADD]
public delegate bool NHEPNIHOMAD();
[Cpp2IlInjected.Token(Token = "0x200005F")]
[NNPEEIDJADD]
public delegate string JNJHIIICEGB(object NJKKPOFFNNJ);
[Cpp2IlInjected.Token(Token = "0x2000060")]
[AttributeUsage(AttributeTargets.Enum)]
public class EEOKKIGMNMK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
	public EEOKKIGMNMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class IHKCOPBJLKL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct JFGCEFBMDME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6AD6860", Offset = "0x6AD4E60", VA = "0x186AD6860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6AD7150", Offset = "0x6AD5750", VA = "0x186AD7150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly TimerCallback OHFPCHNEGLF;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Action<object?> DOLOHBKDDAM;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6AD42F0", Offset = "0x6AD28F0", VA = "0x186AD42F0")]
	public static Task<bool> LFGCCHGDJEM(int IKNEPDHOLEK, [Optional] CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6AD41C0", Offset = "0x6AD27C0", VA = "0x186AD41C0")]
	[AsyncStateMachine(typeof(JFGCEFBMDME))]
	private static Task<bool> JOMCAJDNCEL(int IKNEPDHOLEK, CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD40A0", Offset = "0x6AD26A0", VA = "0x186AD40A0")]
	private static void DFGONLODFHD(object? NEIJPCGNELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6AD4130", Offset = "0x6AD2730", VA = "0x186AD4130")]
	private static void JOBLMNFGEEK(object? NEIJPCGNELF)
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
