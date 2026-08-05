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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D38D00", Offset = "0x6D37900", VA = "0x186D38D00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B3450", Offset = "0x8B2050", VA = "0x1808B3450")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MKBDALMKOJG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D376A0", Offset = "0x6D362A0", VA = "0x186D376A0")]
	public static string HGNDIIOKDHA(this Encoding NFGIFMHDKPP, [In] ReadOnlySequence<byte> NDKFLGEBABO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC2A0", Offset = "0x2EFAEA0", VA = "0x182EFC2A0")]
	private static void ICMIKELAPKH<T>(this ReadOnlySequence<T> IIKKIIMGLPE, [Out] ReadOnlySpan<T> DPPANKFKNCH, [Out] SequencePosition AMNGEABADMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class NKALGEHLIBB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D38B00", Offset = "0x6D37700", VA = "0x186D38B00")]
	public NKALGEHLIBB(bool HPBFMMBOGGP, string DKFFMMCECHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JOLNKAPDNGJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HKFNBJGGDII
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DEKBEFACGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JAJFMBOECCO(string NONKDEOLPHL, double CABLCDOIFFL, [Optional] string? DNCNEFCMHDF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NPMLBEPBDNM<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate Task<TResult> NCPBCGPOBCA(CancellationToken CKKFHABGBNL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct FNLMPAHHHHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public NPMLBEPBDNM<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public NCPBCGPOBCA taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x3E1EEE0", Offset = "0x3E1DAE0", VA = "0x183E1EEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3E1FFA0", Offset = "0x3E1EBA0", VA = "0x183E1FFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource IMJPMIKGHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? EKECEMPHHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? PEMLBLGPDCA;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x46B3C70", Offset = "0x46B2870", VA = "0x1846B3C70")]
	[AsyncStateMachine(typeof(NPMLBEPBDNM<>.FNLMPAHHHHE))]
	public Task<TResult> PANJANOPJKG(NCPBCGPOBCA ANNJLNGBBLE, [Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x46B3C00", Offset = "0x46B2800", VA = "0x1846B3C00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x46B3DB0", Offset = "0x46B29B0", VA = "0x1846B3DB0")]
	public NPMLBEPBDNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class GNNMGABJKGA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> GFNKFPJPIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T PPPKGAOABBC;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3EF69B0", Offset = "0x3EF55B0", VA = "0x183EF69B0")]
	public GNNMGABJKGA([In] T CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5E10", Offset = "0x3EF4A10", VA = "0x183EF5E10", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3EF61C0", Offset = "0x3EF4DC0", VA = "0x183EF61C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3EF65C0", Offset = "0x3EF51C0", VA = "0x183EF65C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class OPAMHLAAAMM
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5CD0", Offset = "0x2BF48D0", VA = "0x182BF5CD0")]
	public static GNNMGABJKGA<T> LMDPPDEOAIA<T>([In] T CABLCDOIFFL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HHBLBIEOGNG
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6D35810", Offset = "0x6D34410", VA = "0x186D35810")]
	public static void NENGLOKDDNL(this CancellationTokenSource IMJPMIKGHND, bool FJGGKBKNIKD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class IOIHOMBANDE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
	public IOIHOMBANDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class PLDOCHCINLH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
	public PLDOCHCINLH(string AGIKPPKJDGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class EIFGKGIEODC
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2C5FD80", Offset = "0x2C5E980", VA = "0x182C5FD80")]
	public static NPOBKLDDPED LCJIPJNOMLI<T>()
	{
		return default(NPOBKLDDPED);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2C5FFD0", Offset = "0x2C5EBD0", VA = "0x182C5FFD0")]
	public static NPOBKLDDPED NMNGKCIONME<T>([CallerMemberName] string GMBAACDNNFI = "") where T : notnull
	{
		return default(NPOBKLDDPED);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2C5FE00", Offset = "0x2C5EA00", VA = "0x182C5FE00")]
	public static NPOBKLDDPED LCJIPJNOMLI<T>(this T AEBBBFCJHJO) where T : notnull
	{
		return default(NPOBKLDDPED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2C5FC30", Offset = "0x2C5E830", VA = "0x182C5FC30")]
	public static NPOBKLDDPED EHDANPKHEBD<T>(this T AEBBBFCJHJO, [CallerMemberName] string GMBAACDNNFI = "") where T : notnull
	{
		return default(NPOBKLDDPED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2C60070", Offset = "0x2C5EC70", VA = "0x182C60070")]
	public static NPOBKLDDPED NMNGKCIONME<T>(this T GMNCELIMKIF, [CallerMemberName] string GMBAACDNNFI = "") where T : notnull
	{
		return default(NPOBKLDDPED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D33070", Offset = "0x6D31C70", VA = "0x186D33070")]
	public static NPOBKLDDPED NMNGKCIONME(string DCHJCLBGOFE, [CallerMemberName] string GMBAACDNNFI = "")
	{
		return default(NPOBKLDDPED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D32FD0", Offset = "0x6D31BD0", VA = "0x186D32FD0")]
	public static string KJPJKBKBGNI(this object GMNCELIMKIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool CHMMGLPFCPO();
[Cpp2IlInjected.Token(Token = "0x2000014")]
[IOIHOMBANDE]
public delegate long KOGOPILFCOK();
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DMNCELLCDFP
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static FGOBEFDFIJD HILEKGBPANJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static FGOBEFDFIJD PMDPPPEMEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6D32B30", Offset = "0x6D31730", VA = "0x186D32B30")]
		get
		{
			return default(FGOBEFDFIJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static BAABCOCOIPM CPNDFECIMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6D32920", Offset = "0x6D31520", VA = "0x186D32920")]
		get
		{
			return default(BAABCOCOIPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static ADCHGFKLEKP MOMKNKBAENF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6D32830", Offset = "0x6D31430", VA = "0x186D32830")]
		get
		{
			return default(ADCHGFKLEKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool AMONJAGBELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6D32EA0", Offset = "0x6D31AA0", VA = "0x186D32EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D32690", Offset = "0x6D31290", VA = "0x186D32690")]
	public static void AJBJOPPFPLF([In] FGOBEFDFIJD MCLIHDHHNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D329E0", Offset = "0x6D315E0", VA = "0x186D329E0")]
	public static void GHFFBIFPAGE(string LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D32D60", Offset = "0x6D31960", VA = "0x186D32D60")]
	public static void NILLNCBIFOE(string LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2C3FBC0", Offset = "0x2C3E7C0", VA = "0x182C3FBC0")]
	public static void NILLNCBIFOE<T>(T DHPKKMMKOFE, HCKFNLPBEAD<T> LFKIGNHCOID) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D32BF0", Offset = "0x6D317F0", VA = "0x186D32BF0")]
	public static void MHECLAALKFO(Exception JFFKMOFPCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D32AB0", Offset = "0x6D316B0", VA = "0x186D32AB0")]
	public static void IOJDEDDOJID(string GMBAACDNNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D32970", Offset = "0x6D31570", VA = "0x186D32970")]
	public static void FJGMLHCHBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D32B80", Offset = "0x6D31780", VA = "0x186D32B80")]
	public static string KJPJKBKBGNI(object PLAMADMDGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D32E30", Offset = "0x6D31A30", VA = "0x186D32E30")]
	public static long NKLLEABIDOB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D32880", Offset = "0x6D31480", VA = "0x186D32880")]
	public static bool DLMKNFFJFFB(bool BCHKLPKACKC, string LFKIGNHCOID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D32C90", Offset = "0x6D31890", VA = "0x186D32C90")]
	public static double NBENCCDGNBK()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct FGOBEFDFIJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly BAABCOCOIPM CPNDFECIMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly ADCHGFKLEKP MOMKNKBAENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly MIFBHJBJBIM AAFANMOEGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly KOGOPILFCOK PLNAHKDDHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly OOEILPMEECN DMBAFHCOBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly CHMMGLPFCPO HMAPHDKAGIC;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly MIFBHJBJBIM BNEMAKAGOCD;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly KOGOPILFCOK DDOMNPGJCFO;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly OOEILPMEECN LBJLCPBADHH;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly CHMMGLPFCPO KFOENNOHJMA;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly FGOBEFDFIJD EHFCNKAFHAH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PEBIHPCGOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D334A0", Offset = "0x6D320A0", VA = "0x186D334A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D33D30", Offset = "0x6D32930", VA = "0x186D33D30")]
	public FGOBEFDFIJD([In] BAABCOCOIPM FDPEGEHAKDN, [In] ADCHGFKLEKP HHLOABKBNPP, MIFBHJBJBIM OMBOFJCBJPJ, KOGOPILFCOK JIFHCLCMHMA, OOEILPMEECN NMIHEIAFBEA, CHMMGLPFCPO EHMKLHMDKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D33630", Offset = "0x6D32230", VA = "0x186D33630")]
	private static string MFKIFEJHJEP(object PLAMADMDGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150")]
	private static long CGHGPLKADNO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
	private static string CHCNHJBGFBE(string BPDMBIHGLAC, string? KFNONDACKPN, bool GLLEBGHKAEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0")]
	private static bool OAGIJEHDPPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D333A0", Offset = "0x6D31FA0", VA = "0x186D333A0")]
	private static FGOBEFDFIJD GEFOJFDIMON()
	{
		return default(FGOBEFDFIJD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OPPKLDEOLFB
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FBKGDPFGKDP LJHPJOJDEAF();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FBKGDPFGKDP : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool EFKKAIKOJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJHCAJFPOCC();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FGAMBIEKLBP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MBPCLHPIHCI([In] T FDOEIPBMJJM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void BPPDOFFICIL<T>([In] T DHPKKMMKOFE);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct DBMFAPFKPCK<T> : IEquatable<DBMFAPFKPCK<T>>, FGAMBIEKLBP<DBMFAPFKPCK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T PPPKGAOABBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int NAJFJJKNBLJ;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2185A80", Offset = "0x2184680", VA = "0x182185A80")]
	public DBMFAPFKPCK([In] T CABLCDOIFFL, int MFJLAMOCOBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5AB9DF0", Offset = "0x5AB89F0", VA = "0x185AB9DF0")]
	public static bool PCHFOHOKDFG([In] DBMFAPFKPCK<T> KFIDOCPNAED, [In] DBMFAPFKPCK<T> AMMLBECACOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3EDA710", Offset = "0x3ED9310", VA = "0x183EDA710", Slot = "4")]
	public bool Equals(DBMFAPFKPCK<T> FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x405F0F0", Offset = "0x405DCF0", VA = "0x18405F0F0", Slot = "0")]
	public override bool Equals(object FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5AB9C50", Offset = "0x5AB8850", VA = "0x185AB9C50")]
	public bool MBPCLHPIHCI([In] DBMFAPFKPCK<T> FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5AB9050", Offset = "0x5AB7C50", VA = "0x185AB9050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5ABA7D0", Offset = "0x5AB93D0", VA = "0x185ABA7D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5AB9690", Offset = "0x5AB8290", VA = "0x185AB9690")]
	public void KHJFAIMOGKG([Out] T CABLCDOIFFL, [Out] int MFJLAMOCOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5AB8D10", Offset = "0x5AB7910", VA = "0x185AB8D10")]
	public (T, int) FDPJHJJMMKA()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5AB8BE0", Offset = "0x5AB77E0", VA = "0x185AB8BE0", Slot = "5")]
	private bool APACHEGJFFB([In] DBMFAPFKPCK<T> FDOEIPBMJJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HNOPIEJKHHB
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2E34180", Offset = "0x2E32D80", VA = "0x182E34180")]
	public static DBMFAPFKPCK<T> LMDPPDEOAIA<T>([In] T CABLCDOIFFL, int MFJLAMOCOBC) where T : notnull
	{
		return default(DBMFAPFKPCK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class PIHJGLHMLCA
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2FD8800", Offset = "0x2FD7400", VA = "0x182FD8800")]
	public static bool MBPCLHPIHCI<T, U>([In] T GMNCELIMKIF, [In] U PLAMADMDGIO) where T : notnull, FGAMBIEKLBP<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult NDKGCEEOAFN<T, out TResult>([In] T DHPKKMMKOFE);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface AAMPKOACAGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	TimeSpan EDGFIANPHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Action? GGPDELKGMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LMFNDHIOLEF();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOKOFGJNFNH();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DLKAMPAODFP();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct BAABCOCOIPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly KCALHKGPKGJ EMKHGCILNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly AMAKAAHAIDC OJIBHCEPLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly KCALHKGPKGJ CLFLOAOHEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly AMAKAAHAIDC FNMODBMCEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly KCALHKGPKGJ LCJHBNNDGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly AMAKAAHAIDC JKAFMIIEBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly AKKGFEMBHPO BFPKLLIDAKO;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly KCALHKGPKGJ JBKMFKBPBIO;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly AMAKAAHAIDC DINDOKGBBEE;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly KCALHKGPKGJ GNCFKGGGEHO;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly AMAKAAHAIDC BNLKAOGMPDK;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly KCALHKGPKGJ KBNHNNLGKKE;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly AMAKAAHAIDC BHAHKPAAKCO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly AKKGFEMBHPO PGMNLBFCIOG;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly BAABCOCOIPM EHFCNKAFHAH;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly KCALHKGPKGJ AEMDLIEIOGI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool PEBIHPCGOKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D30EC0", Offset = "0x6D2FAC0", VA = "0x186D30EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xCF3340", Offset = "0xCF1F40", VA = "0x180CF3340")]
	public BAABCOCOIPM(KCALHKGPKGJ CAEEDALPDGI, AMAKAAHAIDC LCIMKKFHENN, KCALHKGPKGJ JDCPEFKKPEL, AMAKAAHAIDC JHFIPNIAMDF, KCALHKGPKGJ DAJIDFEJAJJ, AMAKAAHAIDC JJLEMEPMNBD, AKKGFEMBHPO OPIODBOGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0")]
	private static bool JKMDFIBBNCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
	private static void ALGHNAOAIHP(string LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0")]
	private static bool OCJFFHENFBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
	private static void APFFFCBMEHG(string LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0")]
	private static bool LDLDJOONEKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
	private static void AAMPHMIMAJC(string LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
	private static void IOMBJAPELBC(Exception JFFKMOFPCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6D30D10", Offset = "0x6D2F910", VA = "0x186D30D10")]
	private static BAABCOCOIPM GEFOJFDIMON()
	{
		return default(BAABCOCOIPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350")]
	private static bool LJEFMOEHGGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D30E50", Offset = "0x6D2FA50", VA = "0x186D30E50")]
	public void GHFFBIFPAGE(object LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D310A0", Offset = "0x6D2FCA0", VA = "0x186D310A0")]
	public void NILLNCBIFOE(object LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1F0B2B0", Offset = "0x1F09EB0", VA = "0x181F0B2B0")]
	public void MHECLAALKFO(Exception JFFKMOFPCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6D31110", Offset = "0x6D2FD10", VA = "0x186D31110")]
	public void NILLNCBIFOE(NBHAOGGNBIE LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2B88BE0", Offset = "0x2B877E0", VA = "0x182B88BE0")]
	public void NILLNCBIFOE<T>(T DHPKKMMKOFE, HCKFNLPBEAD<T> LFKIGNHCOID) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2B887D0", Offset = "0x2B873D0", VA = "0x182B887D0")]
	public void GHFFBIFPAGE<T>([In] T DHPKKMMKOFE, FIBEAMECHNA<T> LFKIGNHCOID) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2B88970", Offset = "0x2B87570", VA = "0x182B88970")]
	public void NILLNCBIFOE<T>([In] T DHPKKMMKOFE, FIBEAMECHNA<T> LFKIGNHCOID) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D30C40", Offset = "0x6D2F840", VA = "0x186D30C40")]
	public bool DLMKNFFJFFB(bool BCHKLPKACKC, string LFKIGNHCOID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct NPOBKLDDPED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string PPPKGAOABBC;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xAE4B40", Offset = "0xAE3740", VA = "0x180AE4B40")]
	public NPOBKLDDPED(string CABLCDOIFFL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
	public static string FGDKAMMLLCN([In] NPOBKLDDPED GMNCELIMKIF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xB491A0", Offset = "0xB47DA0", VA = "0x180B491A0")]
	public static NPOBKLDDPED FGDKAMMLLCN(string FDOEIPBMJJM)
	{
		return default(NPOBKLDDPED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6D38BD0", Offset = "0x6D377D0", VA = "0x186D38BD0")]
	public string DPHPDJAKHIM(string CODBLMOIHKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6D38C20", Offset = "0x6D37820", VA = "0x186D38C20")]
	public string ENFHCIGHDIJ(object EPJPIFHEGPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[AttributeUsage(AttributeTargets.Method)]
public class DBLGKMOLBBA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
	public DBLGKMOLBBA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct FKMCALNFICP : IEquatable<FKMCALNFICP>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "4")]
	public bool Equals(FKMCALNFICP FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6D34750", Offset = "0x6D33350", VA = "0x186D34750", Slot = "0")]
	public override bool Equals(object FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D347A0", Offset = "0x6D333A0", VA = "0x186D347A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D347B0", Offset = "0x6D333B0", VA = "0x186D347B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[CEKOJAIAJNA("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct GENIMIBGNOF<T> : IEquatable<GENIMIBGNOF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T PPPKGAOABBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool GMLCGNLBJHC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IAHHCOADPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB420", Offset = "0x3EDA020", VA = "0x183EDB420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3EDC1C0", Offset = "0x3EDADC0", VA = "0x183EDC1C0")]
	public GENIMIBGNOF([In] T CABLCDOIFFL, bool HEMAEIOIBJB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB7C0", Offset = "0x3EDA3C0", VA = "0x183EDB7C0")]
	public static bool PCHFOHOKDFG([In] GENIMIBGNOF<T> KFIDOCPNAED, [In] GENIMIBGNOF<T> AMMLBECACOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3EDA710", Offset = "0x3ED9310", VA = "0x183EDA710", Slot = "4")]
	public bool Equals(GENIMIBGNOF<T> FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3EDA1A0", Offset = "0x3ED8DA0", VA = "0x183EDA1A0", Slot = "0")]
	public override bool Equals(object FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB120", Offset = "0x3ED9D20", VA = "0x183EDB120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3EDBC70", Offset = "0x3EDA870", VA = "0x183EDBC70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class GBGIMCMIPFM
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2DF8B30", Offset = "0x2DF7730", VA = "0x182DF8B30")]
	public static GENIMIBGNOF<T> ONDNHOGIFBD<T>([In] T CABLCDOIFFL) where T : notnull
	{
		return default(GENIMIBGNOF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2DF88D0", Offset = "0x2DF74D0", VA = "0x182DF88D0")]
	public static GENIMIBGNOF<T?> IPOMCHGDALI<T>()
	{
		return default(GENIMIBGNOF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2DF89D0", Offset = "0x2DF75D0", VA = "0x182DF89D0")]
	public static bool KCDAPNEJFHJ<T>([In] this GENIMIBGNOF<T> HGFFKFLIFBF, [Out][NotNullWhen(true)] T CABLCDOIFFL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2DF8950", Offset = "0x2DF7550", VA = "0x182DF8950")]
	public static T? JJICDEKLOPO<T>([In] this GENIMIBGNOF<T> HGFFKFLIFBF, T? IEDAFAANJNE)
	{
		return (T?)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct ADCHGFKLEKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr IOJDEDDOJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr FJGMLHCHBOC;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr MKCGKNNLPGK;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr AOCLAAEMMNO;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly ADCHGFKLEKP EHFCNKAFHAH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool PEBIHPCGOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6D2E440", Offset = "0x6D2D040", VA = "0x186D2E440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xC7E130", Offset = "0xC7CD30", VA = "0x180C7E130")]
	public ADCHGFKLEKP(IntPtr NPNFOKPHPDK, IntPtr DNNAOHMKJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
	private static void HPNPOHOHFME(string GMBAACDNNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
	private static void LHNNFCCLFBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6D2E3B0", Offset = "0x6D2CFB0", VA = "0x186D2E3B0")]
	private static ADCHGFKLEKP GEFOJFDIMON()
	{
		return default(ADCHGFKLEKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct FHDJGCMOCCC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr FGMMCCBBAHB;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xAE4B40", Offset = "0xAE3740", VA = "0x180AE4B40")]
	private FHDJGCMOCCC(IntPtr DNNAOHMKJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6D33DE0", Offset = "0x6D329E0", VA = "0x186D33DE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6D33E00", Offset = "0x6D32A00", VA = "0x186D33E00")]
	public static FHDJGCMOCCC LMDPPDEOAIA(string GMBAACDNNFI)
	{
		return default(FHDJGCMOCCC);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2162690", Offset = "0x2161290", VA = "0x182162690")]
	public static FHDJGCMOCCC LMDPPDEOAIA([In] ADCHGFKLEKP HHLOABKBNPP, string GMBAACDNNFI)
	{
		return default(FHDJGCMOCCC);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2162620", Offset = "0x2161220", VA = "0x182162620")]
	public static FHDJGCMOCCC LMDPPDEOAIA([In] ADCHGFKLEKP HHLOABKBNPP, Func<string> GMBAACDNNFI)
	{
		return default(FHDJGCMOCCC);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class AOCAPNDKNGI
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public delegate bool EKBIHNFGHLG<in TInput, TResult>(TInput GKMKPBACAOC, [Out] TResult CMNKPAFMHMO);

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private sealed class GIKGHJDLKBH : OPPKLDEOLFB
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class PLIFCAJPIPG : FBKGDPFGKDP, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly PLIFCAJPIPG AAGIFLNDKEI;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool EFKKAIKOJCE
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x6D39240", Offset = "0x6D37E40", VA = "0x186D39240", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6D392A0", Offset = "0x6D37EA0", VA = "0x186D392A0", Slot = "6")]
			public void OnCompleted(Action LAIPJAPKOAE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
			public void CJHCAJFPOCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public PLIFCAJPIPG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly GIKGHJDLKBH AAGIFLNDKEI;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		private GIKGHJDLKBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6D35640", Offset = "0x6D34240", VA = "0x186D35640", Slot = "4")]
		public FBKGDPFGKDP LJHPJOJDEAF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private sealed class FELLHKEHJOB : OPPKLDEOLFB
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private sealed class EMFIDABOGBA : FBKGDPFGKDP, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly EMFIDABOGBA AAGIFLNDKEI;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool EFKKAIKOJCE
			{
				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x6D330F0", Offset = "0x6D31CF0", VA = "0x186D330F0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6D33110", Offset = "0x6D31D10", VA = "0x186D33110", Slot = "6")]
			public void OnCompleted(Action LAIPJAPKOAE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
			public void CJHCAJFPOCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public EMFIDABOGBA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly FELLHKEHJOB AAGIFLNDKEI;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		private FELLHKEHJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6D332E0", Offset = "0x6D31EE0", VA = "0x186D332E0", Slot = "4")]
		public FBKGDPFGKDP LJHPJOJDEAF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class KAJOHHMOGOE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public KAJOHHMOGOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x405F040", Offset = "0x405DC40", VA = "0x18405F040")]
		internal void PDBPFFMBDFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class GMIFDIJDOKI<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public GMIFDIJDOKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3EF16F0", Offset = "0x3EF02F0", VA = "0x183EF16F0")]
		internal void LJAGFCNJGDL(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct ABNFILKFKNJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6D2E250", Offset = "0x6D2CE50", VA = "0x186D2E250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct FBCCMAOGMDM : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6D331D0", Offset = "0x6D31DD0", VA = "0x186D331D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct PCCBLHMMADO<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x487DD60", Offset = "0x487C960", VA = "0x18487DD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x487DED0", Offset = "0x487CAD0", VA = "0x18487DED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct PJHKGCDKGPL<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x488ECE0", Offset = "0x488D8E0", VA = "0x18488ECE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x488F530", Offset = "0x488E130", VA = "0x18488F530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct CIACAJFBNEE : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6D321D0", Offset = "0x6D30DD0", VA = "0x186D321D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D323D0", Offset = "0x6D30FD0", VA = "0x186D323D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class APBBCJCJPPA<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public APBBCJCJPPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x405F040", Offset = "0x405DC40", VA = "0x18405F040")]
		internal void HJAAIIOMGML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x405EFC0", Offset = "0x405DBC0", VA = "0x18405EFC0")]
		internal void CGMIEIOJDOG(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct DMDNCGJLEOD<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public EKBIHNFGHLG<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5B0A810", Offset = "0x5B09410", VA = "0x185B0A810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5B0AF20", Offset = "0x5B09B20", VA = "0x185B0AF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct FHNCKPDFJEK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6D33F00", Offset = "0x6D32B00", VA = "0x186D33F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6D346F0", Offset = "0x6D332F0", VA = "0x186D346F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct LCFLDCBBEJD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6D36DD0", Offset = "0x6D359D0", VA = "0x186D36DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6D37310", Offset = "0x6D35F10", VA = "0x186D37310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct HMMFDMBACAD<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3F597A0", Offset = "0x3F583A0", VA = "0x183F597A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3F420C0", Offset = "0x3F40CC0", VA = "0x183F420C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class ICOIAELMMNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public TaskCompletionSource<FKMCALNFICP> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public ICOIAELMMNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6D35BE0", Offset = "0x6D347E0", VA = "0x186D35BE0")]
		internal void AAIHPABCNNE(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct DDGPEPABDOD<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5AC1600", Offset = "0x5AC0200", VA = "0x185AC1600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3789DA0", Offset = "0x37889A0", VA = "0x183789DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct OHMNNLBOLJN<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x47A8B30", Offset = "0x47A7730", VA = "0x1847A8B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x47A9820", Offset = "0x47A8420", VA = "0x1847A9820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct GIJAACJBFNL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6D35140", Offset = "0x6D33D40", VA = "0x186D35140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6D35320", Offset = "0x6D33F20", VA = "0x186D35320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct OKLFEFIFMEG : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6D38D80", Offset = "0x6D37980", VA = "0x186D38D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6D390E0", Offset = "0x6D37CE0", VA = "0x186D390E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct HOPOJBCOBCD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6D35890", Offset = "0x6D34490", VA = "0x186D35890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6D35B80", Offset = "0x6D34780", VA = "0x186D35B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class DKMEPCEGBNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public DKMEPCEGBNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6D32440", Offset = "0x6D31040", VA = "0x186D32440")]
		internal Task HJKJICGANGA(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct GIKFKDIAJMC : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6D35380", Offset = "0x6D33F80", VA = "0x186D35380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6D355E0", Offset = "0x6D341E0", VA = "0x186D355E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct KEJPNNMLJIJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6D36880", Offset = "0x6D35480", VA = "0x186D36880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6D36A60", Offset = "0x6D35660", VA = "0x186D36A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct ALGHNGOOHEM : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6D2E650", Offset = "0x6D2D250", VA = "0x186D2E650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6D2E9B0", Offset = "0x6D2D5B0", VA = "0x186D2E9B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct BNEOCOFBION : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6D317A0", Offset = "0x6D303A0", VA = "0x186D317A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6D31A90", Offset = "0x6D30690", VA = "0x186D31A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class MIIFCIFIJOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public MIIFCIFIJOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6D37630", Offset = "0x6D36230", VA = "0x186D37630")]
		internal Task HPAHKDOJCIC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct LMAHAMIJNCI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6D37370", Offset = "0x6D35F70", VA = "0x186D37370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6D375D0", Offset = "0x6D361D0", VA = "0x186D375D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct DMKFHCHFCJO : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6D324B0", Offset = "0x6D310B0", VA = "0x186D324B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6D32630", Offset = "0x6D31230", VA = "0x186D32630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct FFLCAMEEOOJ<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE260", Offset = "0x3DFCE60", VA = "0x183DFE260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE4C0", Offset = "0x3DFD0C0", VA = "0x183DFE4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct JBFAIBFOCOD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6D35CF0", Offset = "0x6D348F0", VA = "0x186D35CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6D36020", Offset = "0x6D34C20", VA = "0x186D36020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? BGNMFFNLOFJ;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<FKMCALNFICP> IKDLCNMDLFN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static Task CMDPKLKKIAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6D30880", Offset = "0x6D2F480", VA = "0x186D30880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6D2EF50", Offset = "0x6D2DB50", VA = "0x186D2EF50")]
	public static bool DHHCOBMFNCC(this Task NEEKHCPCAAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x34C6FD0", Offset = "0x34C5BD0", VA = "0x1834C6FD0")]
	public static Task<T> DLFKNKBBALE<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6D2F6E0", Offset = "0x6D2E2E0", VA = "0x186D2F6E0")]
	public static Task INMBONLDEID(this Task NEEKHCPCAAC, CancellationToken DGGGDIFONNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x34C93A0", Offset = "0x34C7FA0", VA = "0x1834C93A0")]
	public static Task<TResult> INMBONLDEID<TResult>(this Task<TResult> NEEKHCPCAAC, CancellationToken DGGGDIFONNG) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x34CA950", Offset = "0x34C9550", VA = "0x1834CA950")]
	public static TaskCompletionSource<TResult> INMBONLDEID<TResult>(this TaskCompletionSource<TResult> IJDPKOGCIHP, CancellationToken DGGGDIFONNG) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6D2F350", Offset = "0x6D2DF50", VA = "0x186D2F350")]
	public static IDisposable? HOFJFDBFGDE(CancellationToken EKFAKACDBDN, CancellationToken AGLPLEBDMIK, [Out] CancellationToken BFDNMJEGIJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6D2F2A0", Offset = "0x6D2DEA0", VA = "0x186D2F2A0")]
	[AsyncStateMachine(typeof(ABNFILKFKNJ))]
	public static void HIFHJBGKPHK(this Task APOGBJPOAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6D2F1F0", Offset = "0x6D2DDF0", VA = "0x186D2F1F0")]
	[AsyncStateMachine(typeof(FBCCMAOGMDM))]
	public static void FNLEMLOKOGN(this Task APOGBJPOAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x34CB2E0", Offset = "0x34C9EE0", VA = "0x1834CB2E0")]
	[AsyncStateMachine(typeof(PCCBLHMMADO<>))]
	public static Task LKHACNPGEKD<TException>(this Task APOGBJPOAAH) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x34C7240", Offset = "0x34C5E40", VA = "0x1834C7240")]
	[AsyncStateMachine(typeof(PJHKGCDKGPL<>))]
	public static Task<T> HEFGBLPLKDE<T>(this Task<T> GMNCELIMKIF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6D2FF00", Offset = "0x6D2EB00", VA = "0x186D2FF00")]
	[AsyncStateMachine(typeof(CIACAJFBNEE))]
	public static Task<TaskStatus> KIBNBADNMNK(this Task GMNCELIMKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x34CB650", Offset = "0x34CA250", VA = "0x1834CB650")]
	public static (Task<T?>?, Action<T?>?) PFAGNDOJFNK<T>([Optional] CancellationToken CKKFHABGBNL)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x34C6EC0", Offset = "0x34C5AC0", VA = "0x1834C6EC0")]
	[AsyncStateMachine(typeof(DMDNCGJLEOD<, >))]
	public static Task<List<TResult>> CPNBJBAEJOJ<TResult, TInput>(this Task<List<TInput>> NEEKHCPCAAC, EKBIHNFGHLG<TInput, TResult> OLBONGAJHLI) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6D30A50", Offset = "0x6D2F650", VA = "0x186D30A50")]
	[AsyncStateMachine(typeof(FHNCKPDFJEK))]
	public static Task PLCCLNFDCGO(Task APOGBJPOAAH, CancellationToken CHGGPNKGCJF, Func<CancellationToken, Task> PLHABEJKFDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6D30700", Offset = "0x6D2F300", VA = "0x186D30700")]
	[AsyncStateMachine(typeof(LCFLDCBBEJD))]
	public static Task NBLCLIMHOPF(Func<CancellationToken, Task> CEBHPIPFBIL, TimeSpan KNDDOANJCCI, [Optional] CancellationToken CHGGPNKGCJF, [Optional] Action<OperationCanceledException>? KMMKDBHEIFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x34CB3B0", Offset = "0x34C9FB0", VA = "0x1834CB3B0")]
	[AsyncStateMachine(typeof(HMMFDMBACAD<>))]
	public static Task<T> NBLCLIMHOPF<T>(Func<CancellationToken, Task<T>> CEBHPIPFBIL, TimeSpan KNDDOANJCCI, [Optional] CancellationToken CHGGPNKGCJF, [Optional] Func<OperationCanceledException, T>? KMMKDBHEIFJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6D304B0", Offset = "0x6D2F0B0", VA = "0x186D304B0")]
	public static Task LJFAJKMLPFK(params Task[] EGLOFDJIGON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D2FFF0", Offset = "0x6D2EBF0", VA = "0x186D2FFF0")]
	public static Task LJFAJKMLPFK(IEnumerable<Task> EGLOFDJIGON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x34CB9C0", Offset = "0x34CA5C0", VA = "0x1834CB9C0")]
	[AsyncStateMachine(typeof(DDGPEPABDOD<>))]
	public static Task<IEnumerable<Task<T>>> PKMBIGNCIKB<T>(IEnumerable<Task<T>> EGLOFDJIGON) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x34C6C00", Offset = "0x34C5800", VA = "0x1834C6C00")]
	[AsyncStateMachine(typeof(OHMNNLBOLJN<, , , >))]
	public static Task<(T1, T2, T3, T4)> AGPMIPMBFNK<T1, T2, T3, T4>(Task<T1> LPOIMDOCHBE, Task<T2> JGHBIBKEAMF, Task<T3> FPPDBJBNOJJ, Task<T4> EEJIKPHMBOK) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D2F5F0", Offset = "0x6D2E1F0", VA = "0x186D2F5F0")]
	[AsyncStateMachine(typeof(GIJAACJBFNL))]
	public static Task IFFPFCPOPNF(Func<bool> BCHKLPKACKC, [Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6D2F4E0", Offset = "0x6D2E0E0", VA = "0x186D2F4E0")]
	[AsyncStateMachine(typeof(OKLFEFIFMEG))]
	public static Task IFFPFCPOPNF(Func<bool> BCHKLPKACKC, TimeSpan MHMADKKBALM, [Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D2EE20", Offset = "0x6D2DA20", VA = "0x186D2EE20")]
	[AsyncStateMachine(typeof(HOPOJBCOBCD))]
	public static Task BIPCPDBDPOP(Func<bool> BCHKLPKACKC, TimeSpan KNDDOANJCCI, [Optional] CancellationToken CKKFHABGBNL, [Optional] Action<OperationCanceledException>? KMMKDBHEIFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6D2ECE0", Offset = "0x6D2D8E0", VA = "0x186D2ECE0")]
	[AsyncStateMachine(typeof(GIKFKDIAJMC))]
	public static Task BIPCPDBDPOP(Func<bool> BCHKLPKACKC, TimeSpan KNDDOANJCCI, TimeSpan MHMADKKBALM, [Optional] CancellationToken CKKFHABGBNL, [Optional] Action<OperationCanceledException>? KMMKDBHEIFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D30500", Offset = "0x6D2F100", VA = "0x186D30500")]
	[AsyncStateMachine(typeof(KEJPNNMLJIJ))]
	public static Task MIHNINDGPML(Func<bool> BCHKLPKACKC, [Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6D305F0", Offset = "0x6D2F1F0", VA = "0x186D305F0")]
	[AsyncStateMachine(typeof(ALGHNGOOHEM))]
	public static Task MIHNINDGPML(Func<bool> BCHKLPKACKC, TimeSpan MHMADKKBALM, [Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6D2F930", Offset = "0x6D2E530", VA = "0x186D2F930")]
	[AsyncStateMachine(typeof(BNEOCOFBION))]
	public static Task IOCFPAILOBJ(Func<bool> BCHKLPKACKC, TimeSpan KNDDOANJCCI, [Optional] CancellationToken CKKFHABGBNL, [Optional] Action<OperationCanceledException>? KMMKDBHEIFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D2FA60", Offset = "0x6D2E660", VA = "0x186D2FA60")]
	[AsyncStateMachine(typeof(LMAHAMIJNCI))]
	public static Task IOCFPAILOBJ(Func<bool> BCHKLPKACKC, TimeSpan KNDDOANJCCI, TimeSpan MHMADKKBALM, [Optional] CancellationToken CKKFHABGBNL, [Optional] Action<OperationCanceledException>? KMMKDBHEIFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D2F100", Offset = "0x6D2DD00", VA = "0x186D2F100")]
	[Obsolete]
	[AsyncStateMachine(typeof(DMKFHCHFCJO))]
	public static Task FEECFNMPMAG(this Task NEEKHCPCAAC, Action GJGNOOBCACD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x34C7150", Offset = "0x34C5D50", VA = "0x1834C7150")]
	[AsyncStateMachine(typeof(FFLCAMEEOOJ<>))]
	[Obsolete]
	public static Task FEECFNMPMAG<T>(this Task<T> NEEKHCPCAAC, Action<T> GJGNOOBCACD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D2F050", Offset = "0x6D2DC50", VA = "0x186D2F050")]
	private static void EKEOEAMDBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6D2FBA0", Offset = "0x6D2E7A0", VA = "0x186D2FBA0")]
	public static bool JFOBHKDJMEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6D2EA10", Offset = "0x6D2D610", VA = "0x186D2EA10")]
	private static void ADFPNHCFAEG(SynchronizationContext CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D308F0", Offset = "0x6D2F4F0", VA = "0x186D308F0")]
	private static void OPDOKOMLHGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D2EF80", Offset = "0x6D2DB80", VA = "0x186D2EF80")]
	public static void EADEGGMJDPD([Optional] string? LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D2EC60", Offset = "0x6D2D860", VA = "0x186D2EC60")]
	public static void AOKPOFDOLJM([Optional] string? LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6D30830", Offset = "0x6D2F430", VA = "0x186D30830")]
	public static OPPKLDEOLFB NFCHKLBDODH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6D30A00", Offset = "0x6D2F600", VA = "0x186D30A00")]
	public static OPPKLDEOLFB PELCDJGLJMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6D2EB90", Offset = "0x6D2D790", VA = "0x186D2EB90")]
	[AsyncStateMachine(typeof(JBFAIBFOCOD))]
	public static Task ANMDKICCMIK(Func<Task> AKLCLFEHBGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class CGPAMFEMIJK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
	public CGPAMFEMIJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class HGINNBENOCI : DBKKEODFJKB
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static readonly DBKKEODFJKB AAGIFLNDKEI;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTime DOMOCKBBHLE
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6D35760", Offset = "0x6D34360", VA = "0x186D35760", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DateTimeOffset LKLHDJDFKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6D35700", Offset = "0x6D34300", VA = "0x186D35700", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public HGINNBENOCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface DBKKEODFJKB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTime DOMOCKBBHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DateTimeOffset LKLHDJDFKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class JJPNCEHMLPN
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long APEOLNNHHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6D36460", Offset = "0x6D35060", VA = "0x186D36460")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static long FAIJLBFDHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6D36110", Offset = "0x6D34D10", VA = "0x186D36110")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double JHCMJOBCNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6D362D0", Offset = "0x6D34ED0", VA = "0x186D362D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double LDFENAAJOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6D36590", Offset = "0x6D35190", VA = "0x186D36590")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double LNIJNOCCEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6D36280", Offset = "0x6D34E80", VA = "0x186D36280")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static double MLJPALLMHLL
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6D364B0", Offset = "0x6D350B0", VA = "0x186D364B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6D361F0", Offset = "0x6D34DF0", VA = "0x186D361F0")]
	public static double FBCJOEBDBPH(long OPJNKJKHEOJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6D36160", Offset = "0x6D34D60", VA = "0x186D36160")]
	public static double EJMDMAGDANC(long OPJNKJKHEOJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6D36500", Offset = "0x6D35100", VA = "0x186D36500")]
	public static double NLEPNDLNEKB(double NMLOIDHPKIA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6D36080", Offset = "0x6D34C80", VA = "0x186D36080")]
	public static long CEPKMJAAIKB(long KEFCDGNOKGL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6D36320", Offset = "0x6D34F20", VA = "0x186D36320")]
	public static long IKGOBKCEOJA(long CIDKLJDCEEE, long OCCKKKPMBOA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6D36390", Offset = "0x6D34F90", VA = "0x186D36390")]
	public static double LOCBPPMJNOE(long CIDKLJDCEEE, long OCCKKKPMBOA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6D36330", Offset = "0x6D34F30", VA = "0x186D36330")]
	public static double LJNPIOBLIIH(long CIDKLJDCEEE, long OCCKKKPMBOA)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class CALEIFFBCBP : AAMPKOACAGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static readonly TimeSpan GLEMEJPPCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly System.Timers.Timer MDMPBKGCCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private TimeSpan KNDDOANJCCI;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public TimeSpan EDGFIANPHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6D31C50", Offset = "0x6D30850", VA = "0x186D31C50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Action? GGPDELKGMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6D31F20", Offset = "0x6D30B20", VA = "0x186D31F20")]
	[Preserve]
	public CALEIFFBCBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6D31F80", Offset = "0x6D30B80", VA = "0x186D31F80")]
	public CALEIFFBCBP(TimeSpan KNDDOANJCCI, [Optional] Action? IMLIIKGNNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6D31DB0", Offset = "0x6D309B0", VA = "0x186D31DB0", Slot = "7")]
	public void LMFNDHIOLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6D31E40", Offset = "0x6D30A40", VA = "0x186D31E40", Slot = "8")]
	public void NOKOFGJNFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6D31B80", Offset = "0x6D30780", VA = "0x186D31B80", Slot = "9")]
	public void DLKAMPAODFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xAF6340", Offset = "0xAF4F40", VA = "0x180AF6340")]
	private void EKMPFAGKJFA(object AEBBBFCJHJO, ElapsedEventArgs IDLKICLNMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6D31AF0", Offset = "0x6D306F0", VA = "0x186D31AF0")]
	private static void DDOIJBBDCFK(TimeSpan IJCDBFNLAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6D31BB0", Offset = "0x6D307B0", VA = "0x186D31BB0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class CEKOJAIAJNA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string? IMIEFDBBNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly string KBIMOODPBAP;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6781640", Offset = "0x6780240", VA = "0x186781640")]
	public CEKOJAIAJNA(string FAAMMCFGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3EF16A0", Offset = "0x3EF02A0", VA = "0x183EF16A0")]
	public CEKOJAIAJNA(string GPACIGDFIMA, string FAAMMCFGOAB)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct NHEPEOIIHBM : IEquatable<NHEPEOIIHBM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint DLLINMEJEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public int MIGJNNFBDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public float CIMHJBINABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public ushort PAKHKKGKDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public ushort HNCICFIADMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public short HHKCHMPNIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public short KAMHJNMLKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public char HNPCFGPDIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public char HIJBOCAJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte CJFOBCKOHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public byte NAKDHGMHPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public byte IPKEEAIOPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public byte NFBMFJPKLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool NPKIEIPCGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool HMLHMNOBEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public bool FEGMAOPNGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public bool LPHDPNPMCNB;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1552660", Offset = "0x1551260", VA = "0x181552660")]
	public static NHEPEOIIHBM GJOEAGKJJBO(uint GPNOOAKKNHM)
	{
		return default(NHEPEOIIHBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1552660", Offset = "0x1551260", VA = "0x181552660")]
	public static NHEPEOIIHBM BGPGEPKAEIB(int HLMEDAOGNBG)
	{
		return default(NHEPEOIIHBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6D37C60", Offset = "0x6D36860", VA = "0x186D37C60")]
	public static NHEPEOIIHBM EGJIGNLJAHC(float KEFPMKALJOK)
	{
		return default(NHEPEOIIHBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6D37CF0", Offset = "0x6D368F0", VA = "0x186D37CF0")]
	public static NHEPEOIIHBM PINAGEEHNHG(byte BAJFKJFDGCB, byte NHPCHIFIKBL, byte JPOFCEHIOCA, byte CCKDCDANCPE)
	{
		return default(NHEPEOIIHBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6D37CF0", Offset = "0x6D368F0", VA = "0x186D37CF0")]
	public static NHEPEOIIHBM OAOIPCLPHKP(bool MIDIADMPDEM, bool PECCINFKAAE, bool DLFEMDCMBFN, bool NLEMJKNGDLA)
	{
		return default(NHEPEOIIHBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6D37CF0", Offset = "0x6D368F0", VA = "0x186D37CF0")]
	public static NHEPEOIIHBM OGKMHNOEEGG(byte INNDIKLGGCM, byte PIECCPLFDDI, byte AFDDGLJDFAJ, byte MOIHBEBKCGB)
	{
		return default(NHEPEOIIHBM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x182BE30", Offset = "0x182AA30", VA = "0x18182BE30")]
	public static bool PCHFOHOKDFG(NHEPEOIIHBM CKONCFGMELN, NHEPEOIIHBM GAAMPOEMOPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x182BE10", Offset = "0x182AA10", VA = "0x18182BE10", Slot = "4")]
	public bool Equals(NHEPEOIIHBM FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6D37C70", Offset = "0x6D36870", VA = "0x186D37C70", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0xC64330", Offset = "0xC62F30", VA = "0x180C64330", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6D37D10", Offset = "0x6D36910", VA = "0x186D37D10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct HOENFHFLIEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public ulong KEODJJMHCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public long JMJAFDKLDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public double BGFIKHBHACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint CDDCMJAGLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint IMCIPAFCEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public int IHPJMOKIOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int MGLGFBAMHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float PHGGHDBDJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float EGHOLBNCINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort PAKHKKGKDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public ushort HNCICFIADMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public ushort LPGMBMKMDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public ushort LGJJJGFFKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short HHKCHMPNIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public short KAMHJNMLKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public short KNHDMBLOMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public short BJBILOMNBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char HNPCFGPDIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public char HIJBOCAJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public char IFNBOCGFNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public char FDFJHPMNKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte CJFOBCKOHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte NAKDHGMHPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte IPKEEAIOPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte NFBMFJPKLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte NHBAACEALLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte NCNAGJPGHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public byte PDBKENLLFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public byte IKCEMEMKBML;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
	public static HOENFHFLIEE LMDPPDEOAIA(long AIMCIPGLCCC)
	{
		return default(HOENFHFLIEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6D35840", Offset = "0x6D34440", VA = "0x186D35840")]
	public static HOENFHFLIEE LMDPPDEOAIA(byte BAJFKJFDGCB, byte NHPCHIFIKBL, byte JPOFCEHIOCA, byte CCKDCDANCPE, byte DHNOEDAEGJB, byte GDNMGDNEKBD, byte FCFPKMNBIEP, byte GDHIBJLPJPE)
	{
		return default(HOENFHFLIEE);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct KKNLHKEGMDL : IEquatable<KKNLHKEGMDL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public byte NKLLIBGHMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool MKNMINPIAAG;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x275E9C0", Offset = "0x275D5C0", VA = "0x18275E9C0")]
	public static KKNLHKEGMDL PINAGEEHNHG(byte OHCOJDFHCHK)
	{
		return default(KKNLHKEGMDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x275E9C0", Offset = "0x275D5C0", VA = "0x18275E9C0")]
	public static KKNLHKEGMDL OAOIPCLPHKP(bool EONJNGIIJFD)
	{
		return default(KKNLHKEGMDL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6D36B60", Offset = "0x6D35760", VA = "0x186D36B60")]
	public static bool PCHFOHOKDFG(KKNLHKEGMDL CKONCFGMELN, KKNLHKEGMDL GAAMPOEMOPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5E48540", Offset = "0x5E47140", VA = "0x185E48540", Slot = "4")]
	public bool Equals(KKNLHKEGMDL FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6D36AC0", Offset = "0x6D356C0", VA = "0x186D36AC0", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6D36B50", Offset = "0x6D35750", VA = "0x186D36B50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6D36B70", Offset = "0x6D35770", VA = "0x186D36B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class JIDAELBBKDO<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public readonly T AKPMLDMKKIJ;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x41EF520", Offset = "0x41EE120", VA = "0x1841EF520")]
	public JIDAELBBKDO(T BLOHBLBCHOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class MBIOKGOKAAK
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2ED02E0", Offset = "0x2ECEEE0", VA = "0x182ED02E0")]
	public static IEnumerable<T> BHONIHBFOND<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
	public static T[] ADPCJLCNNLG<T>(params T[] FJIIFMLFIMM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
	public static IEnumerable<T> BPCCOGKIKHC<T>(params T[] FJIIFMLFIMM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5CD0", Offset = "0x2BF48D0", VA = "0x182BF5CD0")]
	public static HashSet<T> DAHNEAKKJFE<T>(params T[] FJIIFMLFIMM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2EF2270", Offset = "0x2EF0E70", VA = "0x182EF2270")]
	public static KeyValuePair<TKey, TValue> EIHMLBLPBEO<TKey, TValue>([In] TKey NONKDEOLPHL, [In] TValue CABLCDOIFFL) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5CD0", Offset = "0x2BF48D0", VA = "0x182BF5CD0")]
	public static List<T> NDDNCHHFIDP<T>(IEnumerable<T> AIOEIPPJKAA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AttributeUsage(AttributeTargets.All)]
public sealed class KLKAKBOPMJG : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public readonly string AIKDDMMMANH;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
	public KLKAKBOPMJG(string IMHEBCOFMGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate object FIBEAMECHNA<T>([In] T JIAHCJFCHOA);
[Cpp2IlInjected.Token(Token = "0x200005B")]
public delegate object HCKFNLPBEAD<T>(T JIAHCJFCHOA);
[Cpp2IlInjected.Token(Token = "0x200005C")]
[IOIHOMBANDE]
public delegate string OOEILPMEECN(string BPDMBIHGLAC, string? KFNONDACKPN, bool GLLEBGHKAEH);
[Cpp2IlInjected.Token(Token = "0x200005D")]
[IOIHOMBANDE]
public delegate void AMAKAAHAIDC(string LFKIGNHCOID);
[Cpp2IlInjected.Token(Token = "0x200005E")]
[IOIHOMBANDE]
public delegate void AKKGFEMBHPO(Exception JFFKMOFPCBJ);
[Cpp2IlInjected.Token(Token = "0x200005F")]
public delegate object NBHAOGGNBIE();
[Cpp2IlInjected.Token(Token = "0x2000060")]
[IOIHOMBANDE]
public delegate bool KCALHKGPKGJ();
[Cpp2IlInjected.Token(Token = "0x2000061")]
[IOIHOMBANDE]
public delegate string MIFBHJBJBIM(object PLAMADMDGIO);
[Cpp2IlInjected.Token(Token = "0x2000062")]
[AttributeUsage(AttributeTargets.Enum)]
public class FNLAKGCDHKL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
	public FNLAKGCDHKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class PPIIOCFABFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct GHJOMKMCDIL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6D347E0", Offset = "0x6D333E0", VA = "0x186D347E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6D350D0", Offset = "0x6D33CD0", VA = "0x186D350D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly TimerCallback EGBFMPMLODD;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly Action<object?> EADBPLEPCIL;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6D396B0", Offset = "0x6D382B0", VA = "0x186D396B0")]
	public static Task<bool> MKFAGNEDHMN(int PGCNIGKJEOG, [Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6D39460", Offset = "0x6D38060", VA = "0x186D39460")]
	[AsyncStateMachine(typeof(GHJOMKMCDIL))]
	private static Task<bool> CHCKEIJHPFE(int PGCNIGKJEOG, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6D39620", Offset = "0x6D38220", VA = "0x186D39620")]
	private static void JCFFACJLPML(object? GFCPLDIMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6D39590", Offset = "0x6D38190", VA = "0x186D39590")]
	private static void EPHJHNCPOCH(object? GFCPLDIMNPM)
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
