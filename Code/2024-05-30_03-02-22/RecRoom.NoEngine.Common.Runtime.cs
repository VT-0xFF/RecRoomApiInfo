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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64B3650", Offset = "0x64B2850", VA = "0x1864B3650")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A00", Offset = "0x7F2C00", VA = "0x1807F3A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3A40", Offset = "0x7F2C40", VA = "0x1807F3A40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class JJNJKPHBOLO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64B0A20", Offset = "0x64AFC20", VA = "0x1864B0A20")]
	public JJNJKPHBOLO(bool ANPMPJJMOLG, string BBJPEFKCNKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KKHEELEAFOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EDAEFKCMIML<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate Task<TResult> CBKHOOPBIMO(CancellationToken GILHKFNDIJP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BJPMMJIIPPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public EDAEFKCMIML<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CBKHOOPBIMO taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x4AF7800", Offset = "0x4AF6A00", VA = "0x184AF7800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4AF87E0", Offset = "0x4AF79E0", VA = "0x184AF87E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource IDLLPIFDGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? ILJABIKHBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? CGDFHEGPLPA;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x356F8A0", Offset = "0x356EAA0", VA = "0x18356F8A0")]
	[AsyncStateMachine(typeof(EDAEFKCMIML<>.BJPMMJIIPPG))]
	public Task<TResult> DOCLAEEONLP(CBKHOOPBIMO FAEPNMAJEMN, [Optional] CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x356F9D0", Offset = "0x356EBD0", VA = "0x18356F9D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x356FA40", Offset = "0x356EC40", VA = "0x18356FA40")]
	public EDAEFKCMIML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class OFNMMODMNNJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> GJNKKHFBNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T OGADOHBOMGE;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3904490", Offset = "0x3903690", VA = "0x183904490")]
	public OFNMMODMNNJ([In] T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x428F770", Offset = "0x428E970", VA = "0x18428F770", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x428FF20", Offset = "0x428F120", VA = "0x18428FF20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4290240", Offset = "0x428F440", VA = "0x184290240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class EGNENHCPDPN
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2803900", Offset = "0x2802B00", VA = "0x182803900")]
	public static OFNMMODMNNJ<T> EPPBEPCPNMI<T>([In] T HLCKBKFCMPI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JACGEPCJGGM
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64B0620", Offset = "0x64AF820", VA = "0x1864B0620")]
	public static void IBDHBLHLCIE(this CancellationTokenSource IDLLPIFDGKP, bool LHHCEIMFIOA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class OOEIHKNKJFE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
	public OOEIHKNKJFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class CNGJDMJIKCE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
	public CNGJDMJIKCE(string DAHFKPDEPBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HEFGKGFFGOA
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x29B2830", Offset = "0x29B1A30", VA = "0x1829B2830")]
	public static HPHLOEDBIDD FECKNEHOFGG<T>()
	{
		return default(HPHLOEDBIDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x29B2A80", Offset = "0x29B1C80", VA = "0x1829B2A80")]
	public static HPHLOEDBIDD MAIFENKPLIC<T>([CallerMemberName] string IIADHBOODBK = "") where T : notnull
	{
		return default(HPHLOEDBIDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x29B27B0", Offset = "0x29B19B0", VA = "0x1829B27B0")]
	public static HPHLOEDBIDD FECKNEHOFGG<T>(this T AOLAKAPHPCK) where T : notnull
	{
		return default(HPHLOEDBIDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x29B2660", Offset = "0x29B1860", VA = "0x1829B2660")]
	public static HPHLOEDBIDD DOCPKHNNHBP<T>(this T AOLAKAPHPCK, [CallerMemberName] string IIADHBOODBK = "") where T : notnull
	{
		return default(HPHLOEDBIDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x29B29E0", Offset = "0x29B1BE0", VA = "0x1829B29E0")]
	public static HPHLOEDBIDD MAIFENKPLIC<T>(this T CJKIBFNGPNM, [CallerMemberName] string IIADHBOODBK = "") where T : notnull
	{
		return default(HPHLOEDBIDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x64B00B0", Offset = "0x64AF2B0", VA = "0x1864B00B0")]
	public static HPHLOEDBIDD MAIFENKPLIC(string DNJEDGJOCKN, [CallerMemberName] string IIADHBOODBK = "")
	{
		return default(HPHLOEDBIDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x64B0010", Offset = "0x64AF210", VA = "0x1864B0010")]
	public static string EMGHEGCKALN(this object CJKIBFNGPNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate bool OEEJAPPEFDO();
[Cpp2IlInjected.Token(Token = "0x2000011")]
[OOEIHKNKJFE]
public delegate long OKKIIJLFLNA();
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DCHEEGGBCFH
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static KKALJAOPDMB BPGMIGKCGEN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static KKALJAOPDMB NBJDJBNEFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x64AC4A0", Offset = "0x64AB6A0", VA = "0x1864AC4A0")]
		get
		{
			return default(KKALJAOPDMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static EHMBFJJMDKE MIOALOJJBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x64AC5C0", Offset = "0x64AB7C0", VA = "0x1864AC5C0")]
		get
		{
			return default(EHMBFJJMDKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static IIMJPLNPPCP NJILHLAEDPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x64ABEE0", Offset = "0x64AB0E0", VA = "0x1864ABEE0")]
		get
		{
			return default(IIMJPLNPPCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool OCOCGAJECNM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x64AC030", Offset = "0x64AB230", VA = "0x1864AC030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x64AC120", Offset = "0x64AB320", VA = "0x1864AC120")]
	public static void ILOGNIIGILB([In] KKALJAOPDMB AEILLONAENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x64AC4F0", Offset = "0x64AB6F0", VA = "0x1864AC4F0")]
	public static void NMLCBHAJNOK(string PPGBBBOBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x64AC2D0", Offset = "0x64AB4D0", VA = "0x1864AC2D0")]
	public static void KAAOHBFMKKP(string PPGBBBOBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27FDB60", Offset = "0x27FCD60", VA = "0x1827FDB60")]
	public static void KAAOHBFMKKP<T>(T HBOMCAJBOPM, DKPGOFGJIFB<T> PPGBBBOBJLN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x64AC3A0", Offset = "0x64AB5A0", VA = "0x1864AC3A0")]
	public static void KIAJAIFKOML(Exception ILHGKPBGFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x64AC440", Offset = "0x64AB640", VA = "0x1864AC440")]
	public static void NCMNFDDJFOP(string IIADHBOODBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x64ABFD0", Offset = "0x64AB1D0", VA = "0x1864ABFD0")]
	public static void DJOIOFJGPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x64AC0A0", Offset = "0x64AB2A0", VA = "0x1864AC0A0")]
	public static string EMGHEGCKALN(object CDJAKLIPEBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x64ABE70", Offset = "0x64AB070", VA = "0x1864ABE70")]
	public static long BEHJPFNOLLB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x64ABF30", Offset = "0x64AB130", VA = "0x1864ABF30")]
	public static bool CMKPBMNAKOL(bool GNKJEJLMAJG, string PPGBBBOBJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x64ABDA0", Offset = "0x64AAFA0", VA = "0x1864ABDA0")]
	public static double AOGDFEKHHBE()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct KKALJAOPDMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly EHMBFJJMDKE MIOALOJJBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly IIMJPLNPPCP NJILHLAEDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly CIHDFFHNCFE HKKIFDPCBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly OKKIIJLFLNA IJOFHHNMFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly GEHEDAOPIKH PMNDBMENAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly OEEJAPPEFDO INMNJGGABOP;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly CIHDFFHNCFE OJAGPAEDBGN;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly OKKIIJLFLNA ECAHCPBPJKA;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly GEHEDAOPIKH LKDAAJMELJD;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly OEEJAPPEFDO JGAPGEJECCE;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly KKALJAOPDMB NECMJGIIDLF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KPPCPAJJDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x64B0B00", Offset = "0x64AFD00", VA = "0x1864B0B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x64B14E0", Offset = "0x64B06E0", VA = "0x1864B14E0")]
	public KKALJAOPDMB([In] EHMBFJJMDKE IFMOKFOFFNL, [In] IIMJPLNPPCP HJEKGCHKACG, CIHDFFHNCFE FBNHPECGFII, OKKIIJLFLNA JHMAIHFCCLN, GEHEDAOPIKH KAHHFAKMDOH, OEEJAPPEFDO MOLBLIMGOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x64B0CA0", Offset = "0x64AFEA0", VA = "0x1864B0CA0")]
	private static string GCMKOJIFODK(object CDJAKLIPEBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00")]
	private static long PLHOGDBMNJB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
	private static string MKNHEGOGKCH(string DIDBPNGGKDB, string? NAFMIFDABCH, bool HLDMABFFBBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360")]
	private static bool PNMLKPJMGOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x64B0CE0", Offset = "0x64AFEE0", VA = "0x1864B0CE0")]
	private static KKALJAOPDMB PLKHIDPNAJL()
	{
		return default(KKALJAOPDMB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface GJFGJFFAJHB
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LLOMPFOAFNB JGCOKBEJCBN();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LLOMPFOAFNB : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OIFHOEMAKHM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHGANOLMKHB();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FDLFGGGKCNP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LHLHOFPOIDH([In] T JPLJHFMPDFD);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public delegate void MHFHBDOOOMK<T>([In] T HBOMCAJBOPM);
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct KDHBFMLLMGH<T> : IEquatable<KDHBFMLLMGH<T>>, FDLFGGGKCNP<KDHBFMLLMGH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T OGADOHBOMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int DMDPAHAMEGP;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1ED8CA0", Offset = "0x1ED7EA0", VA = "0x181ED8CA0")]
	public KDHBFMLLMGH([In] T HLCKBKFCMPI, int PMNHOLIPOMJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3E4A850", Offset = "0x3E49A50", VA = "0x183E4A850")]
	public static bool LOAKJDDAMKI([In] KDHBFMLLMGH<T> ABPADDODFDF, [In] KDHBFMLLMGH<T> DLCDCNECDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3E49840", Offset = "0x3E48A40", VA = "0x183E49840", Slot = "4")]
	public bool Equals(KDHBFMLLMGH<T> JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3906260", Offset = "0x3905460", VA = "0x183906260", Slot = "0")]
	public override bool Equals(object JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3E4A7D0", Offset = "0x3E499D0", VA = "0x183E4A7D0")]
	public bool LHLHOFPOIDH([In] KDHBFMLLMGH<T> JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3E4A3E0", Offset = "0x3E495E0", VA = "0x183E4A3E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3E4B2B0", Offset = "0x3E4A4B0", VA = "0x183E4B2B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3E49940", Offset = "0x3E48B40", VA = "0x183E49940")]
	public void FPCLJKLMLOD([Out] T HLCKBKFCMPI, [Out] int PMNHOLIPOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3E4A0A0", Offset = "0x3E492A0", VA = "0x183E4A0A0")]
	public (T, int) GDJHIOFFNPD()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3E4AE10", Offset = "0x3E4A010", VA = "0x183E4AE10", Slot = "5")]
	private bool MOMPIDJHGAN([In] KDHBFMLLMGH<T> JPLJHFMPDFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HCEHEDJGPAL
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x29AD4B0", Offset = "0x29AC6B0", VA = "0x1829AD4B0")]
	public static KDHBFMLLMGH<T> EPPBEPCPNMI<T>([In] T HLCKBKFCMPI, int PMNHOLIPOMJ) where T : notnull
	{
		return default(KDHBFMLLMGH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class FNNFAJDDGED
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x29657A0", Offset = "0x29649A0", VA = "0x1829657A0")]
	public static bool LHLHOFPOIDH<T, U>([In] T CJKIBFNGPNM, [In] U CDJAKLIPEBF) where T : notnull, FDLFGGGKCNP<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public delegate TResult HDHHBPNMKGE<T, out TResult>([In] T HBOMCAJBOPM);
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface EJFEBNDNCJI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan PDCNELLCLMD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? ONBNADPAEPO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HHGMBCMBJBG();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKIJJACHHBA();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ELDEMCCAJPF();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct EHMBFJJMDKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly NDLOMGDMELK CLBKACMLMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly KDHCCNLKADL HAGOOCEIGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly NDLOMGDMELK LJJKEAMBAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly KDHCCNLKADL DOMEIOGIMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly NDLOMGDMELK LCCGMAFOBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly KDHCCNLKADL PPMCKOLGIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly MNHGLAAKBCF IEHNBALJFIH;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly NDLOMGDMELK MDIEAIPJNNJ;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly KDHCCNLKADL LAJIKHBDEIA;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly NDLOMGDMELK HLMDPOEFFBP;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly KDHCCNLKADL LJGJLIICPEG;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly NDLOMGDMELK MMLJEHHDPPF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly KDHCCNLKADL JAOGBLNPOPB;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly MNHGLAAKBCF LLPHECOPFGB;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly EHMBFJJMDKE NECMJGIIDLF;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly NDLOMGDMELK ILDGNPABKJC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KPPCPAJJDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x64AC7F0", Offset = "0x64AB9F0", VA = "0x1864AC7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA6C940", Offset = "0xA6BB40", VA = "0x180A6C940")]
	public EHMBFJJMDKE(NDLOMGDMELK LHDELOAHGBN, KDHCCNLKADL AGDNNPKLNEE, NDLOMGDMELK OGAANGGHAPN, KDHCCNLKADL NOEJMALIDMG, NDLOMGDMELK IFEFOKHPANN, KDHCCNLKADL EJKCGPMMPFJ, MNHGLAAKBCF AHPMHDJNFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360")]
	private static bool EMFCEGPMLOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
	private static void BJFBEFMJCDA(string PPGBBBOBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360")]
	private static bool LIDDAAPEJNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
	private static void GMIBNNDJKDO(string PPGBBBOBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360")]
	private static bool MLCOLCDHNLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
	private static void LLKFCIOLACL(string PPGBBBOBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
	private static void AMJLLFLPPJO(Exception ILHGKPBGFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x64ACC80", Offset = "0x64ABE80", VA = "0x1864ACC80")]
	private static EHMBFJJMDKE PLKHIDPNAJL()
	{
		return default(EHMBFJJMDKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0")]
	private static bool NGAHKEEEBJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x64ACC10", Offset = "0x64ABE10", VA = "0x1864ACC10")]
	public void NMLCBHAJNOK(object PPGBBBOBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x64ACAC0", Offset = "0x64ABCC0", VA = "0x1864ACAC0")]
	public void KAAOHBFMKKP(object PPGBBBOBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1B14D40", Offset = "0x1B13F40", VA = "0x181B14D40")]
	public void KIAJAIFKOML(Exception ILHGKPBGFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x64ACB30", Offset = "0x64ABD30", VA = "0x1864ACB30")]
	public void KAAOHBFMKKP(HBELFEIMDKB PPGBBBOBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2824C20", Offset = "0x2823E20", VA = "0x182824C20")]
	public void KAAOHBFMKKP<T>(T HBOMCAJBOPM, DKPGOFGJIFB<T> PPGBBBOBJLN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2824CE0", Offset = "0x2823EE0", VA = "0x182824CE0")]
	public void NMLCBHAJNOK<T>([In] T HBOMCAJBOPM, JONJBHNHDNK<T> PPGBBBOBJLN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x64AC9F0", Offset = "0x64ABBF0", VA = "0x1864AC9F0")]
	public bool CMKPBMNAKOL(bool GNKJEJLMAJG, string PPGBBBOBJLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct HPHLOEDBIDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string OGADOHBOMGE;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x877820", Offset = "0x876A20", VA = "0x180877820")]
	public HPHLOEDBIDD(string HLCKBKFCMPI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
	public static string LOFAPGLBJHK([In] HPHLOEDBIDD CJKIBFNGPNM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8D4580", Offset = "0x8D3780", VA = "0x1808D4580")]
	public static HPHLOEDBIDD LOFAPGLBJHK(string JPLJHFMPDFD)
	{
		return default(HPHLOEDBIDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x64B0230", Offset = "0x64AF430", VA = "0x1864B0230")]
	public string HLLCKIOILEJ(string JFPGFMAHEJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x64B0280", Offset = "0x64AF480", VA = "0x1864B0280")]
	public string IHGBBIJHBHP(object AJHNIBIOLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct PJGNGDCIDLA : IEquatable<PJGNGDCIDLA>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "4")]
	public bool Equals(PJGNGDCIDLA JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x64B45F0", Offset = "0x64B37F0", VA = "0x1864B45F0", Slot = "0")]
	public override bool Equals(object JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x64B4640", Offset = "0x64B3840", VA = "0x1864B4640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x64B4650", Offset = "0x64B3850", VA = "0x1864B4650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[LCJOOIGDAHJ("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct CPCJPGBNMLP<T> : IEquatable<CPCJPGBNMLP<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T OGADOHBOMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool JMLJCCCOJCE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool FIOPPEIDLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x515F1A0", Offset = "0x515E3A0", VA = "0x18515F1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x515F840", Offset = "0x515EA40", VA = "0x18515F840")]
	public CPCJPGBNMLP([In] T HLCKBKFCMPI, bool CJCALDHOAFM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x515F1B0", Offset = "0x515E3B0", VA = "0x18515F1B0")]
	public static bool LOAKJDDAMKI([In] CPCJPGBNMLP<T> ABPADDODFDF, [In] CPCJPGBNMLP<T> DLCDCNECDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3E49840", Offset = "0x3E48A40", VA = "0x183E49840", Slot = "4")]
	public bool Equals(CPCJPGBNMLP<T> JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x515E8E0", Offset = "0x515DAE0", VA = "0x18515E8E0", Slot = "0")]
	public override bool Equals(object JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x515EE90", Offset = "0x515E090", VA = "0x18515EE90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x515F670", Offset = "0x515E870", VA = "0x18515F670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class GPGNBDKHONP
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x29AB7D0", Offset = "0x29AA9D0", VA = "0x1829AB7D0")]
	public static CPCJPGBNMLP<T> NDJMKNHDFOM<T>([In] T HLCKBKFCMPI) where T : notnull
	{
		return default(CPCJPGBNMLP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x29AB640", Offset = "0x29AA840", VA = "0x1829AB640")]
	public static CPCJPGBNMLP<T?> DGGCANDACIF<T>()
	{
		return default(CPCJPGBNMLP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x29AB740", Offset = "0x29AA940", VA = "0x1829AB740")]
	public static bool KFFAIHHNJAO<T>([In] this CPCJPGBNMLP<T> EOAHLKLKFEB, [Out][NotNullWhen(true)] T HLCKBKFCMPI) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct IIMJPLNPPCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr NCMNFDDJFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr DJOIOFJGPDE;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr FCHJHJGEGID;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr NNGJFCNIFAM;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IIMJPLNPPCP NECMJGIIDLF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KPPCPAJJDMP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x64B0360", Offset = "0x64AF560", VA = "0x1864B0360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9FB690", Offset = "0x9FA890", VA = "0x1809FB690")]
	public IIMJPLNPPCP(IntPtr HFFMHLMLOFK, IntPtr BMMBHFLAEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
	private static void IJFALKOOECF(string IIADHBOODBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
	private static void AJHOEDHJAJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x64B0440", Offset = "0x64AF640", VA = "0x1864B0440")]
	private static IIMJPLNPPCP PLKHIDPNAJL()
	{
		return default(IIMJPLNPPCP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct HMCJFEKPDMJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr CCCKLOPEGKA;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x877820", Offset = "0x876A20", VA = "0x180877820")]
	private HMCJFEKPDMJ(IntPtr BMMBHFLAEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x64B0130", Offset = "0x64AF330", VA = "0x1864B0130", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x64B0140", Offset = "0x64AF340", VA = "0x1864B0140")]
	public static HMCJFEKPDMJ EPPBEPCPNMI(string IIADHBOODBK)
	{
		return default(HMCJFEKPDMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA7A0", Offset = "0x1EB99A0", VA = "0x181EBA7A0")]
	public static HMCJFEKPDMJ EPPBEPCPNMI([In] IIMJPLNPPCP HJEKGCHKACG, string IIADHBOODBK)
	{
		return default(HMCJFEKPDMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1EBABC0", Offset = "0x1EB9DC0", VA = "0x181EBABC0")]
	public static HMCJFEKPDMJ EPPBEPCPNMI([In] IIMJPLNPPCP HJEKGCHKACG, Func<string> IIADHBOODBK)
	{
		return default(HMCJFEKPDMJ);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class FKKGIHDILFK
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate bool BAAFMDIAMMF<in TInput, TResult>(TInput NBFGFAAMIMJ, [Out] TResult JBENFHJBMMN);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private sealed class BDNDDEKHJKG : GJFGJFFAJHB
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private sealed class NDKLOHAHFIL : LLOMPFOAFNB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly NDKLOHAHFIL LNFBMICMFIL;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool OIFHOEMAKHM
			{
				[Cpp2IlInjected.Token(Token = "0x60000B2")]
				[Cpp2IlInjected.Address(RVA = "0x64B22E0", Offset = "0x64B14E0", VA = "0x1864B22E0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x64B2340", Offset = "0x64B1540", VA = "0x1864B2340", Slot = "6")]
			public void OnCompleted(Action HPPNEDMIMOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
			public void HHGANOLMKHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public NDKLOHAHFIL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly BDNDDEKHJKG LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		private BDNDDEKHJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x64AAEC0", Offset = "0x64AA0C0", VA = "0x1864AAEC0", Slot = "4")]
		public LLOMPFOAFNB JGCOKBEJCBN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class CHKECFOHIIM : GJFGJFFAJHB
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class FMLCPBHPICH : LLOMPFOAFNB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly FMLCPBHPICH LNFBMICMFIL;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool OIFHOEMAKHM
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x64AF6A0", Offset = "0x64AE8A0", VA = "0x1864AF6A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x64AF6C0", Offset = "0x64AE8C0", VA = "0x1864AF6C0", Slot = "6")]
			public void OnCompleted(Action HPPNEDMIMOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
			public void HHGANOLMKHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public FMLCPBHPICH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly CHKECFOHIIM LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		private CHKECFOHIIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x64ABA60", Offset = "0x64AAC60", VA = "0x1864ABA60", Slot = "4")]
		public LLOMPFOAFNB JGCOKBEJCBN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class JGJPJMNFEIG<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public JGJPJMNFEIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D4F140", Offset = "0x3D4E340", VA = "0x183D4F140")]
		internal void EJMHEGEFDPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class DCNKCLMKFHA<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public DCNKCLMKFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3A583D0", Offset = "0x3A575D0", VA = "0x183A583D0")]
		internal void INADNGMPNKD(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct KPPGGMLNBMK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x64B1E30", Offset = "0x64B1030", VA = "0x1864B1E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x939BD0", Offset = "0x938DD0", VA = "0x180939BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct BPFOJNMCACI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x64AB250", Offset = "0x64AA450", VA = "0x1864AB250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x939BD0", Offset = "0x938DD0", VA = "0x180939BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct NAHFGFMGGON<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x418CCF0", Offset = "0x418BEF0", VA = "0x18418CCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x418CE60", Offset = "0x418C060", VA = "0x18418CE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct FHCJCJMNKDI<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3909DC0", Offset = "0x3908FC0", VA = "0x183909DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x390A1E0", Offset = "0x39093E0", VA = "0x18390A1E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct CJLANIOALOL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x64ABB30", Offset = "0x64AAD30", VA = "0x1864ABB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x64ABD30", Offset = "0x64AAF30", VA = "0x1864ABD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class APMCEJCACIC<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public APMCEJCACIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3D4F140", Offset = "0x3D4E340", VA = "0x183D4F140")]
		internal void KOMFFFJJNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3D893E0", Offset = "0x3D885E0", VA = "0x183D893E0")]
		internal void BNDHKDPMLFB(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct BFFBFDNLBHN<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public BAAFMDIAMMF<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4A53920", Offset = "0x4A52B20", VA = "0x184A53920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x4A53FD0", Offset = "0x4A531D0", VA = "0x184A53FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct KOFLNJLEMPC : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x64B15E0", Offset = "0x64B07E0", VA = "0x1864B15E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x64B1DD0", Offset = "0x64B0FD0", VA = "0x1864B1DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct PMKHGBMBNHB : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x64B4680", Offset = "0x64B3880", VA = "0x1864B4680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x64B4BC0", Offset = "0x64B3DC0", VA = "0x1864B4BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct BLIFBCOLLDH<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x4AFC6B0", Offset = "0x4AFB8B0", VA = "0x184AFC6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x35991E0", Offset = "0x35983E0", VA = "0x1835991E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct LIMILMBPGGJ<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3F570B0", Offset = "0x3F562B0", VA = "0x183F570B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3349930", Offset = "0x3348B30", VA = "0x183349930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct MBLOJPCEODJ<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x412C860", Offset = "0x412BA60", VA = "0x18412C860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x412D4F0", Offset = "0x412C6F0", VA = "0x18412D4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct FHEEHBPJDFD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x64AD740", Offset = "0x64AC940", VA = "0x1864AD740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x64AD920", Offset = "0x64ACB20", VA = "0x1864AD920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct NNIECBCPPKH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x64B3280", Offset = "0x64B2480", VA = "0x1864B3280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x64B35F0", Offset = "0x64B27F0", VA = "0x1864B35F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct NJIOOLNACOC : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x64B2F30", Offset = "0x64B2130", VA = "0x1864B2F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x64B3220", Offset = "0x64B2420", VA = "0x1864B3220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class FDLBCGICJLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public FDLBCGICJLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x64AD6D0", Offset = "0x64AC8D0", VA = "0x1864AD6D0")]
		internal Task GPENJGPPIIL(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct BLCJFOAGOEF : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x64AAF90", Offset = "0x64AA190", VA = "0x1864AAF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x64AB1F0", Offset = "0x64AA3F0", VA = "0x1864AB1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct AKMMPGMHBCE : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x64AAC80", Offset = "0x64A9E80", VA = "0x1864AAC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x64AAE60", Offset = "0x64AA060", VA = "0x1864AAE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct JCJKAKFFIPN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x64B0650", Offset = "0x64AF850", VA = "0x1864B0650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x64B09C0", Offset = "0x64AFBC0", VA = "0x1864B09C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct LFCKIHFAFHO : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x64B1F90", Offset = "0x64B1190", VA = "0x1864B1F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x64B2280", Offset = "0x64B1480", VA = "0x1864B2280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class EIDFDLPCGEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public EIDFDLPCGEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x64AD3A0", Offset = "0x64AC5A0", VA = "0x1864AD3A0")]
		internal Task LDCIGMODKHD(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct EOJDEKMEDOC : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x64AD410", Offset = "0x64AC610", VA = "0x1864AD410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x64AD670", Offset = "0x64AC870", VA = "0x1864AD670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct NJGJHNEJJJJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x64B2D50", Offset = "0x64B1F50", VA = "0x1864B2D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x64B2ED0", Offset = "0x64B20D0", VA = "0x1864B2ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct FJEAPHBCGLN<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x390CA50", Offset = "0x390BC50", VA = "0x18390CA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x390CCA0", Offset = "0x390BEA0", VA = "0x18390CCA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct FNFGOGCADHO : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x64AF790", Offset = "0x64AE990", VA = "0x1864AF790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x64AFB90", Offset = "0x64AED90", VA = "0x1864AFB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? PNLGHCCMBMB;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<PJGNGDCIDLA> MFFMNBPPJIN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task AGIIFOIBLFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x64ADD20", Offset = "0x64ACF20", VA = "0x1864ADD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x64AE170", Offset = "0x64AD370", VA = "0x1864AE170")]
	public static bool GCIOJMNJCFK(this Task IKEBALIIPCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x295BE30", Offset = "0x295B030", VA = "0x18295BE30")]
	public static Task<T> IKDJLGCFLIO<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x64AF0C0", Offset = "0x64AE2C0", VA = "0x1864AF0C0")]
	public static Task OCEIFEMHEJI(this Task IKEBALIIPCC, CancellationToken CEFPPEHCFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x295DDF0", Offset = "0x295CFF0", VA = "0x18295DDF0")]
	public static Task<TResult> OCEIFEMHEJI<TResult>(this Task<TResult> IKEBALIIPCC, CancellationToken CEFPPEHCFCF) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x295EBA0", Offset = "0x295DDA0", VA = "0x18295EBA0")]
	public static TaskCompletionSource<TResult> OCEIFEMHEJI<TResult>(this TaskCompletionSource<TResult> GALFCEPCPEK, CancellationToken CEFPPEHCFCF) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x64AE850", Offset = "0x64ADA50", VA = "0x1864AE850")]
	public static IDisposable? JKAKHLONLOG(CancellationToken HHPFOMAHEBE, CancellationToken LJGANADLBFD, [Out] CancellationToken CEBEHPHILNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x64AF320", Offset = "0x64AE520", VA = "0x1864AF320")]
	[AsyncStateMachine(typeof(KPPGGMLNBMK))]
	public static void OMAGHLMDFHK(this Task GIHFGGLMPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x64AF010", Offset = "0x64AE210", VA = "0x1864AF010")]
	[AsyncStateMachine(typeof(BPFOJNMCACI))]
	public static void NMFINOFFMCD(this Task GIHFGGLMPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x295B770", Offset = "0x295A970", VA = "0x18295B770")]
	[AsyncStateMachine(typeof(NAHFGFMGGON<>))]
	public static Task ABPKCMFOLDP<TException>(this Task GIHFGGLMPDC) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x295C380", Offset = "0x295B580", VA = "0x18295C380")]
	[AsyncStateMachine(typeof(FHCJCJMNKDI<>))]
	public static Task<T> MAHLEAGOCIN<T>(this Task<T> CJKIBFNGPNM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x64AEE00", Offset = "0x64AE000", VA = "0x1864AEE00")]
	[AsyncStateMachine(typeof(CJLANIOALOL))]
	public static Task<TaskStatus> LLPFDLKKDLL(this Task CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x295BF80", Offset = "0x295B180", VA = "0x18295BF80")]
	public static (Task<T?>?, Action<T?>?) LHIEIFOLGCM<T>([Optional] CancellationToken GILHKFNDIJP)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x295F3B0", Offset = "0x295E5B0", VA = "0x18295F3B0")]
	[AsyncStateMachine(typeof(BFFBFDNLBHN<, >))]
	public static Task<List<TResult>> PEABALFMHHC<TResult, TInput>(this Task<List<TInput>> IKEBALIIPCC, BAAFMDIAMMF<TInput, TResult> AOCMECEIDLH) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x64ADE40", Offset = "0x64AD040", VA = "0x1864ADE40")]
	[AsyncStateMachine(typeof(KOFLNJLEMPC))]
	public static Task CJDEHPCKCLP(Task GIHFGGLMPDC, CancellationToken ALBNLCCGHGB, Func<CancellationToken, Task> PPDLFLIBONF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x64AD980", Offset = "0x64ACB80", VA = "0x1864AD980")]
	[AsyncStateMachine(typeof(PMKHGBMBNHB))]
	public static Task BDFMAGEMLMB(Func<CancellationToken, Task> DJECOIAHBHI, TimeSpan HEEKNLGJGIH, [Optional] CancellationToken ALBNLCCGHGB, [Optional] Action<OperationCanceledException>? AMMHMKIBFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x295BAE0", Offset = "0x295ACE0", VA = "0x18295BAE0")]
	[AsyncStateMachine(typeof(BLIFBCOLLDH<>))]
	public static Task<T> BDFMAGEMLMB<T>(Func<CancellationToken, Task<T>> DJECOIAHBHI, TimeSpan HEEKNLGJGIH, [Optional] CancellationToken ALBNLCCGHGB, [Optional] Func<OperationCanceledException, T>? AMMHMKIBFKH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x295C2A0", Offset = "0x295B4A0", VA = "0x18295C2A0")]
	[AsyncStateMachine(typeof(LIMILMBPGGJ<>))]
	public static Task<IEnumerable<Task<T>>> LMLHAMDFNFD<T>(IEnumerable<Task<T>> JDLIGBAEHPN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x295B840", Offset = "0x295AA40", VA = "0x18295B840")]
	[AsyncStateMachine(typeof(MBLOJPCEODJ<, , , >))]
	public static Task<(T1, T2, T3, T4)> AIPNIGLDNGN<T1, T2, T3, T4>(Task<T1> JKKLECIKJKL, Task<T2> HOMEOBLLEEI, Task<T3> GAIDIICPNLH, Task<T4> JJLPKMIEAGL) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x64AE080", Offset = "0x64AD280", VA = "0x1864AE080")]
	[AsyncStateMachine(typeof(FHEEHBPJDFD))]
	public static Task EABBGIGCOPK(Func<bool> GNKJEJLMAJG, [Optional] CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x64ADF70", Offset = "0x64AD170", VA = "0x1864ADF70")]
	[AsyncStateMachine(typeof(NNIECBCPPKH))]
	public static Task EABBGIGCOPK(Func<bool> GNKJEJLMAJG, TimeSpan EEBJKKLHLDI, [Optional] CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x64AE990", Offset = "0x64ADB90", VA = "0x1864AE990")]
	[AsyncStateMachine(typeof(NJIOOLNACOC))]
	public static Task KCDNEMCLCGN(Func<bool> GNKJEJLMAJG, TimeSpan HEEKNLGJGIH, [Optional] CancellationToken GILHKFNDIJP, [Optional] Action<OperationCanceledException>? AMMHMKIBFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x64AEAC0", Offset = "0x64ADCC0", VA = "0x1864AEAC0")]
	[AsyncStateMachine(typeof(BLCJFOAGOEF))]
	public static Task KCDNEMCLCGN(Func<bool> GNKJEJLMAJG, TimeSpan HEEKNLGJGIH, TimeSpan EEBJKKLHLDI, [Optional] CancellationToken GILHKFNDIJP, [Optional] Action<OperationCanceledException>? AMMHMKIBFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x64AEC00", Offset = "0x64ADE00", VA = "0x1864AEC00")]
	[AsyncStateMachine(typeof(AKMMPGMHBCE))]
	public static Task KMAFHDPMJHC(Func<bool> GNKJEJLMAJG, [Optional] CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x64AECF0", Offset = "0x64ADEF0", VA = "0x1864AECF0")]
	[AsyncStateMachine(typeof(JCJKAKFFIPN))]
	public static Task KMAFHDPMJHC(Func<bool> GNKJEJLMAJG, TimeSpan EEBJKKLHLDI, [Optional] CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x64ADBF0", Offset = "0x64ACDF0", VA = "0x1864ADBF0")]
	[AsyncStateMachine(typeof(LFCKIHFAFHO))]
	public static Task BHAONLDFGOM(Func<bool> GNKJEJLMAJG, TimeSpan HEEKNLGJGIH, [Optional] CancellationToken GILHKFNDIJP, [Optional] Action<OperationCanceledException>? AMMHMKIBFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x64ADAB0", Offset = "0x64ACCB0", VA = "0x1864ADAB0")]
	[AsyncStateMachine(typeof(EOJDEKMEDOC))]
	public static Task BHAONLDFGOM(Func<bool> GNKJEJLMAJG, TimeSpan HEEKNLGJGIH, TimeSpan EEBJKKLHLDI, [Optional] CancellationToken GILHKFNDIJP, [Optional] Action<OperationCanceledException>? AMMHMKIBFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x64AE3E0", Offset = "0x64AD5E0", VA = "0x1864AE3E0")]
	[Obsolete]
	[AsyncStateMachine(typeof(NJGJHNEJJJJ))]
	public static Task IBKFMGKKNHB(this Task IKEBALIIPCC, Action LDLGJLCKADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x295BD40", Offset = "0x295AF40", VA = "0x18295BD40")]
	[Obsolete]
	[AsyncStateMachine(typeof(FJEAPHBCGLN<>))]
	public static Task IBKFMGKKNHB<T>(this Task<T> IKEBALIIPCC, Action<T> LDLGJLCKADP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x64ADD90", Offset = "0x64ACF90", VA = "0x1864ADD90")]
	private static void CCCCIOMPNNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x64AE4D0", Offset = "0x64AD6D0", VA = "0x1864AE4D0")]
	public static bool JCEAHFJCAMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x64AF3D0", Offset = "0x64AE5D0", VA = "0x1864AF3D0")]
	private static void PAAMNCMDDML(SynchronizationContext HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x64AE1A0", Offset = "0x64AD3A0", VA = "0x1864AE1A0")]
	private static void GEENOOCKPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x64AEEF0", Offset = "0x64AE0F0", VA = "0x1864AEEF0")]
	public static void MEOKLOIGEPE([Optional] string? PPGBBBOBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x64AF560", Offset = "0x64AE760", VA = "0x1864AF560")]
	public static void PMNFGNMDGJE([Optional] string? PPGBBBOBJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x64AEFC0", Offset = "0x64AE1C0", VA = "0x1864AEFC0")]
	public static GJFGJFFAJHB MPBDFMDICDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x64AE2C0", Offset = "0x64AD4C0", VA = "0x1864AE2C0")]
	public static GJFGJFFAJHB GHOIINDGEBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x64AE310", Offset = "0x64AD510", VA = "0x1864AE310")]
	[AsyncStateMachine(typeof(FNFGOGCADHO))]
	public static Task GLPCCHIHDBI(Func<Task> IKBJCBBBOIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class DLFNECBFFJA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
	public DLFNECBFFJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class DPKGAFMCPBK : MFOACBCAKEM
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly MFOACBCAKEM LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime AIPECIHHABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x64AC730", Offset = "0x64AB930", VA = "0x1864AC730", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset JPECDIKMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x64AC6D0", Offset = "0x64AB8D0", VA = "0x1864AC6D0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public DPKGAFMCPBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface MFOACBCAKEM
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime AIPECIHHABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset JPECDIKMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class NIIEMDCPAKC
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long IEMGHCFGCMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x64B27B0", Offset = "0x64B19B0", VA = "0x1864B27B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long LBMEOHGLGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x64B2750", Offset = "0x64B1950", VA = "0x1864B2750")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double KJOLEMBDPKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x64B2700", Offset = "0x64B1900", VA = "0x1864B2700")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double DKMEDMPBDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x64B2570", Offset = "0x64B1770", VA = "0x1864B2570")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double LFPIKGAPFIO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x64B2520", Offset = "0x64B1720", VA = "0x1864B2520")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double GINJOAKDALM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x64B2620", Offset = "0x64B1820", VA = "0x1864B2620")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x64B2890", Offset = "0x64B1A90", VA = "0x1864B2890")]
	public static double LJEEGFEGIFF(long KNIBADPPNBD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x64B29F0", Offset = "0x64B1BF0", VA = "0x1864B29F0")]
	public static double PPEKHKKOJKC(long KNIBADPPNBD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x64B2670", Offset = "0x64B1870", VA = "0x1864B2670")]
	public static double DMCOBCCGGIA(double CGPLAINCCIF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x64B2800", Offset = "0x64B1A00", VA = "0x1864B2800")]
	public static long IICOMLBECNE(long CNDFBLFAGOA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x64B27A0", Offset = "0x64B19A0", VA = "0x1864B27A0")]
	public static long IFOJBAHFJBH(long AFAHAAJJFHL, long DAAEOMHGJCC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x64B2920", Offset = "0x64B1B20", VA = "0x1864B2920")]
	public static double LLHLMILCGLF(long AFAHAAJJFHL, long DAAEOMHGJCC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x64B25C0", Offset = "0x64B17C0", VA = "0x1864B25C0")]
	public static double CJBBBGNOLMM(long AFAHAAJJFHL, long DAAEOMHGJCC)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public sealed class CBHKHEFHHKJ : EJFEBNDNCJI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan POMBNECIINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer MPHIGPEIAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan HEEKNLGJGIH;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan PDCNELLCLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x64AB400", Offset = "0x64AA600", VA = "0x1864AB400", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? ONBNADPAEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4D0", Offset = "0x7CA6D0", VA = "0x1807CB4D0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x64AB7A0", Offset = "0x64AA9A0", VA = "0x1864AB7A0")]
	[Preserve]
	public CBHKHEFHHKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x64AB810", Offset = "0x64AAA10", VA = "0x1864AB810")]
	public CBHKHEFHHKJ(TimeSpan HEEKNLGJGIH, [Optional] Action? CAFNFBBFCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x64AB6A0", Offset = "0x64AA8A0", VA = "0x1864AB6A0", Slot = "7")]
	public void HHGMBCMBJBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x64AB560", Offset = "0x64AA760", VA = "0x1864AB560", Slot = "8")]
	public void EKIJJACHHBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x64AB5D0", Offset = "0x64AA7D0", VA = "0x1864AB5D0", Slot = "9")]
	public void ELDEMCCAJPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x87B7C0", Offset = "0x87A9C0", VA = "0x18087B7C0")]
	private void HCIPDELCGJN(object AOLAKAPHPCK, ElapsedEventArgs DANGGGFIOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x64AB600", Offset = "0x64AA800", VA = "0x1864AB600")]
	private static void FAAFEBNBODP(TimeSpan DBDODIHFHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x64AB360", Offset = "0x64AA560", VA = "0x1864AB360", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class LCJOOIGDAHJ : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string? DFNPLFFBNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly string AGHMAHMGHEH;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5F8FF90", Offset = "0x5F8F190", VA = "0x185F8FF90")]
	public LCJOOIGDAHJ(string FLJELGJMIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3D8B270", Offset = "0x3D8A470", VA = "0x183D8B270")]
	public LCJOOIGDAHJ(string KKPDFEBGEBN, string FLJELGJMIKN)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct PIHPPAPLCME : IEquatable<PIHPPAPLCME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public uint JPDOELCCLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public int GMHJDBNGECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public float EHECBFPNFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort IGOIPGAFGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public ushort DFHHDMELHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short BEJBCIKCEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public short FMDLHFNJCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char CMJPBNBFNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public char IMNEPADFBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte NOCFBCNFKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte ILMODJPDNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte PGHJHMCECPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte LDHMOHHCEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool IKCFLGNNHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool KFIKCCKMGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool HNDPFCDHBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool ADOHAJCPHPF;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xD96860", Offset = "0xD95A60", VA = "0x180D96860")]
	public static PIHPPAPLCME DLOPKEBEIEB(uint GEAGBKCKPIB)
	{
		return default(PIHPPAPLCME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xD96860", Offset = "0xD95A60", VA = "0x180D96860")]
	public static PIHPPAPLCME FLILMCHOJKH(int DNOJBJANAKA)
	{
		return default(PIHPPAPLCME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x64B3780", Offset = "0x64B2980", VA = "0x1864B3780")]
	public static PIHPPAPLCME HFPFBMAAMKM(float MKFINKLKEGJ)
	{
		return default(PIHPPAPLCME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x64B36D0", Offset = "0x64B28D0", VA = "0x1864B36D0")]
	public static PIHPPAPLCME EOGBMKNIEFG(byte NHBDANAOEGI, byte FEEAKOGANME, byte BOONOJLEMBI, byte EJKGGKDOFJE)
	{
		return default(PIHPPAPLCME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x64B36D0", Offset = "0x64B28D0", VA = "0x1864B36D0")]
	public static PIHPPAPLCME LICPGJGBNNP(bool GJMILBJLNLJ, bool PPNALKLAFPN, bool OMCCADMBJBA, bool EBEJLOJKOJG)
	{
		return default(PIHPPAPLCME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x64B36D0", Offset = "0x64B28D0", VA = "0x1864B36D0")]
	public static PIHPPAPLCME JFMJMLKPDEA(byte IHFDOKIHDHM, byte HFCHBAOKKHB, byte KOIFDGDJAFJ, byte LHCOEKCBGAO)
	{
		return default(PIHPPAPLCME);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x1994A80", Offset = "0x1993C80", VA = "0x181994A80")]
	public static bool LOAKJDDAMKI(PIHPPAPLCME GFINPEICFEL, PIHPPAPLCME ENBAOKALGHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x92A880", Offset = "0x929A80", VA = "0x18092A880", Slot = "4")]
	public bool Equals(PIHPPAPLCME JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x64B36F0", Offset = "0x64B28F0", VA = "0x1864B36F0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x9F9250", Offset = "0x9F8450", VA = "0x1809F9250", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x64B3790", Offset = "0x64B2990", VA = "0x1864B3790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct KLDDHJCGBLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public ulong MHPPGOELGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public long DGBMMMHGKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public double JHIDBKIOHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint KJGLPAFOMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint IFCBKMHGACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int EOIKMKPABAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public int OKFIJHNHMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float CJAKHLINGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public float ONBNFFOOBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort IGOIPGAFGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort DFHHDMELHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort DDKJPJHJAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort NCBJGCNOHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short BEJBCIKCEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short FMDLHFNJCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short POHPMJHMDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short NNNNOJLHLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char CMJPBNBFNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char IMNEPADFBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char DGDFNDGGKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char BBJEBOOMHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte NOCFBCNFKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte ILMODJPDNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte PGHJHMCECPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte LDHMOHHCEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte FFJMACGKCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte NLAOABDDCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte JNLAPBCAPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte AOLNABIOOCG;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x64B1590", Offset = "0x64B0790", VA = "0x1864B1590")]
	public static KLDDHJCGBLH EPPBEPCPNMI(byte NHBDANAOEGI, byte FEEAKOGANME, byte BOONOJLEMBI, byte EJKGGKDOFJE, byte FABDIIFENIN, byte GAKHPNKKBLK, byte BMOJLMLBIIB, byte EEEMIHADFME)
	{
		return default(KLDDHJCGBLH);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct GAIBMMPEAGO : IEquatable<GAIBMMPEAGO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte EODNOBBLDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool HKEAPCHBFKO;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x243CF40", Offset = "0x243C140", VA = "0x18243CF40")]
	public static GAIBMMPEAGO EOGBMKNIEFG(byte MPIHHLILJKK)
	{
		return default(GAIBMMPEAGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x243CF40", Offset = "0x243C140", VA = "0x18243CF40")]
	public static GAIBMMPEAGO LICPGJGBNNP(bool JEMHPGDKEFG)
	{
		return default(GAIBMMPEAGO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x64AFC90", Offset = "0x64AEE90", VA = "0x1864AFC90")]
	public static bool LOAKJDDAMKI(GAIBMMPEAGO GFINPEICFEL, GAIBMMPEAGO ENBAOKALGHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x56B6390", Offset = "0x56B5590", VA = "0x1856B6390", Slot = "4")]
	public bool Equals(GAIBMMPEAGO JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x64AFBF0", Offset = "0x64AEDF0", VA = "0x1864AFBF0", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x64AFC80", Offset = "0x64AEE80", VA = "0x1864AFC80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x64AFCA0", Offset = "0x64AEEA0", VA = "0x1864AFCA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class NMKABHMNPNP<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public readonly T NAFEJKFNKOJ;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x41CD2E0", Offset = "0x41CC4E0", VA = "0x1841CD2E0")]
	public NMKABHMNPNP(T ELIAOLODBJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class HJPOPJKBIFO
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x29BF240", Offset = "0x29BE440", VA = "0x1829BF240")]
	public static IEnumerable<T> AGNLMOEBHNJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
	public static T[] NFALHOFBGCH<T>(params T[] LOODPLMHLKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
	public static IEnumerable<T> JDONNAAPLFC<T>(params T[] LOODPLMHLKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2803900", Offset = "0x2802B00", VA = "0x182803900")]
	public static HashSet<T> MAPDJEELAJO<T>(params T[] LOODPLMHLKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x29BF260", Offset = "0x29BE460", VA = "0x1829BF260")]
	public static KeyValuePair<TKey, TValue> MIEFAHLBKNC<TKey, TValue>([In] TKey MNOIAMGNLNL, [In] TValue HLCKBKFCMPI) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2803900", Offset = "0x2802B00", VA = "0x182803900")]
	public static List<T> LPADEHKNMEA<T>(IEnumerable<T> GECPOPGBBAH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[AttributeUsage(AttributeTargets.All)]
public sealed class FAMALPLAALP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public readonly string CEHKDGBPBBM;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7F3A00", Offset = "0x7F2C00", VA = "0x1807F3A00")]
	public FAMALPLAALP(string GIDMHIMFIHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public delegate object JONJBHNHDNK<T>([In] T NEAMBEFDODM);
[Cpp2IlInjected.Token(Token = "0x2000056")]
public delegate object DKPGOFGJIFB<T>(T NEAMBEFDODM);
[Cpp2IlInjected.Token(Token = "0x2000057")]
[OOEIHKNKJFE]
public delegate string GEHEDAOPIKH(string DIDBPNGGKDB, string? NAFMIFDABCH, bool HLDMABFFBBA);
[Cpp2IlInjected.Token(Token = "0x2000058")]
[OOEIHKNKJFE]
public delegate void KDHCCNLKADL(string PPGBBBOBJLN);
[Cpp2IlInjected.Token(Token = "0x2000059")]
[OOEIHKNKJFE]
public delegate void MNHGLAAKBCF(Exception ILHGKPBGFDB);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate object HBELFEIMDKB();
[Cpp2IlInjected.Token(Token = "0x200005B")]
[OOEIHKNKJFE]
public delegate bool NDLOMGDMELK();
[Cpp2IlInjected.Token(Token = "0x200005C")]
[OOEIHKNKJFE]
public delegate string CIHDFFHNCFE(object CDJAKLIPEBF);
[Cpp2IlInjected.Token(Token = "0x200005D")]
[AttributeUsage(AttributeTargets.Enum)]
public class PNJAKICGMBF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
	public PNJAKICGMBF()
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
