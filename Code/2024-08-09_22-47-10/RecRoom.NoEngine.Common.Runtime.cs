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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		[Cpp2IlInjected.Address(RVA = "0x69C9090", Offset = "0x69C8490", VA = "0x1869C9090")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8765E0", Offset = "0x8759E0", VA = "0x1808765E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x876620", Offset = "0x875A20", VA = "0x180876620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EAMGHJHIADG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69C0700", Offset = "0x69BFB00", VA = "0x1869C0700")]
	public static string JLIHLDGHIPJ(this Encoding GGGCOKAOGGL, [In] ReadOnlySequence<byte> PLMCKIPFEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x29B3020", Offset = "0x29B2420", VA = "0x1829B3020")]
	private static void BLMAHEIGFMK<T>(this ReadOnlySequence<T> KJLAIINFKNM, [Out] ReadOnlySpan<T> MEHFKBHENNL, [Out] SequencePosition CHCMOMPHENK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class GCLNGKKJIDP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x69C2390", Offset = "0x69C1790", VA = "0x1869C2390")]
	public GCLNGKKJIDP(bool IDCCGHEGOKG, string GJCKOGJLDPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LFPJLCPCBPD
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CKFCNOCHBJC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GHGKOKMJFPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLGHODHGBJO(string PEDCMDADFIN, double OBEEJPGJPFD, [Optional] string? NHOFLPINKHO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NEBLAGKJEJE<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate Task<TResult> JPBOOOLLJNK(CancellationToken GNJJGEHBGKC);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct FODNPELLJIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public NEBLAGKJEJE<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public JPBOOOLLJNK taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x3C39530", Offset = "0x3C38930", VA = "0x183C39530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A600", Offset = "0x3C39A00", VA = "0x183C3A600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource CJDNALLBGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? BEHIBKDGEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? ACCGHFCJOKI;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x44EB7F0", Offset = "0x44EABF0", VA = "0x1844EB7F0")]
	[AsyncStateMachine(typeof(NEBLAGKJEJE<>.FODNPELLJIL))]
	public Task<TResult> JDDNOIEMJKO(JPBOOOLLJNK DPLNJEMEHNL, [Optional] CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x44EB780", Offset = "0x44EAB80", VA = "0x1844EB780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x44EB930", Offset = "0x44EAD30", VA = "0x1844EB930")]
	public NEBLAGKJEJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class AFOAPLODGHM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> DDNHOBPPELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T KHLHBLNGCMJ;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3D64C30", Offset = "0x3D64030", VA = "0x183D64C30")]
	public AFOAPLODGHM([In] T OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D63EC0", Offset = "0x3D632C0", VA = "0x183D63EC0", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D64510", Offset = "0x3D63910", VA = "0x183D64510", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3D646D0", Offset = "0x3D63AD0", VA = "0x183D646D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class FMBPJBMODPL
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x299BA00", Offset = "0x299AE00", VA = "0x18299BA00")]
	public static AFOAPLODGHM<T> DDEJLDFANAB<T>([In] T OBEEJPGJPFD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ANNPMNIODIM
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69BF4E0", Offset = "0x69BE8E0", VA = "0x1869BF4E0")]
	public static void ABKGCDLFFII(this CancellationTokenSource CJDNALLBGNA, bool HLKHENFABAO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class DFLHACDHMLN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
	public DFLHACDHMLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class MPLLCOLDBMG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
	public MPLLCOLDBMG(string EPOMOPFEHFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class AFINMBMMHLN
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3217570", Offset = "0x3216970", VA = "0x183217570")]
	public static FHDCIKFFLBO PLALDIKGBBI<T>()
	{
		return default(FHDCIKFFLBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x32172D0", Offset = "0x32166D0", VA = "0x1832172D0")]
	public static FHDCIKFFLBO GPGMPNKPAJP<T>([CallerMemberName] string FIKHOKLHCII = "") where T : notnull
	{
		return default(FHDCIKFFLBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32175F0", Offset = "0x32169F0", VA = "0x1832175F0")]
	public static FHDCIKFFLBO PLALDIKGBBI<T>(this T MHKDAHGGECP) where T : notnull
	{
		return default(FHDCIKFFLBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3217420", Offset = "0x3216820", VA = "0x183217420")]
	public static FHDCIKFFLBO KPGKJOGLKCK<T>(this T MHKDAHGGECP, [CallerMemberName] string FIKHOKLHCII = "") where T : notnull
	{
		return default(FHDCIKFFLBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3217370", Offset = "0x3216770", VA = "0x183217370")]
	public static FHDCIKFFLBO GPGMPNKPAJP<T>(this T ABPJKOBADEP, [CallerMemberName] string FIKHOKLHCII = "") where T : notnull
	{
		return default(FHDCIKFFLBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69BF460", Offset = "0x69BE860", VA = "0x1869BF460")]
	public static FHDCIKFFLBO GPGMPNKPAJP(string JALBNAFBHHA, [CallerMemberName] string FIKHOKLHCII = "")
	{
		return default(FHDCIKFFLBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69BF3C0", Offset = "0x69BE7C0", VA = "0x1869BF3C0")]
	public static string AFLBOONACPO(this object ABPJKOBADEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool JMIHNFGNPBM();
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DFLHACDHMLN]
public delegate long EFDLCFDPHEF();
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GJPFMBCFMBM
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static IIIBMJOAEEM BFFPMMMOJKD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IIIBMJOAEEM BIFHDGKEEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69C2A00", Offset = "0x69C1E00", VA = "0x1869C2A00")]
		get
		{
			return default(IIIBMJOAEEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static ELEGJCKPBKB JJKMDBCDLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x69C25B0", Offset = "0x69C19B0", VA = "0x1869C25B0")]
		get
		{
			return default(ELEGJCKPBKB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static DKMLFKGIFDL FKNPNHJMLHC
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x69C2AF0", Offset = "0x69C1EF0", VA = "0x1869C2AF0")]
		get
		{
			return default(DKMLFKGIFDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool HFELLBJDJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69C2C90", Offset = "0x69C2090", VA = "0x1869C2C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69C2670", Offset = "0x69C1A70", VA = "0x1869C2670")]
	public static void EPHCODLOFMD([In] IIIBMJOAEEM PDPJBKKEFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x69C2BC0", Offset = "0x69C1FC0", VA = "0x1869C2BC0")]
	public static void NEKMHMJECLN(string PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x69C2890", Offset = "0x69C1C90", VA = "0x1869C2890")]
	public static void FPLONKHBNMC(string PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A1E0", Offset = "0x2B695E0", VA = "0x182B6A1E0")]
	public static void FPLONKHBNMC<T>(T PEGMNLKCILJ, HNIMKKGCMAI<T> PBDOHNMILPN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69C2960", Offset = "0x69C1D60", VA = "0x1869C2960")]
	public static void HCCFHGNLNMP(Exception PIBFNCHIFEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69C2B40", Offset = "0x69C1F40", VA = "0x1869C2B40")]
	public static void NCDOGLGOCJF(string FIKHOKLHCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69C2600", Offset = "0x69C1A00", VA = "0x1869C2600")]
	public static void CLGMODAGLBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x69C2530", Offset = "0x69C1930", VA = "0x1869C2530")]
	public static string AFLBOONACPO(object LALIGKIKEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69C2820", Offset = "0x69C1C20", VA = "0x1869C2820")]
	public static long FKIPMBJPKGK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x69C2A50", Offset = "0x69C1E50", VA = "0x1869C2A50")]
	public static bool JALEIJHGANA(bool GGBDOLNKFKN, string PBDOHNMILPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x69C2D00", Offset = "0x69C2100", VA = "0x1869C2D00")]
	public static double PCOCLDIIDGM()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct IIIBMJOAEEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly ELEGJCKPBKB JJKMDBCDLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly DKMLFKGIFDL FKNPNHJMLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly HHKLLHLLBEA PEBFGKPLEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly EFDLCFDPHEF ODCNPJDHHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly OHNJONJLGOD PPOICLADMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly JMIHNFGNPBM HGHMJONENKP;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly HHKLLHLLBEA KLJBFBDCNBA;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly EFDLCFDPHEF AIGABOGMPLK;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly OHNJONJLGOD ACJNAJJPHJG;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly JMIHNFGNPBM ODDKLPBJAAF;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly IIIBMJOAEEM ADMHPKLFINC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool OODFNLHIOMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x69C37A0", Offset = "0x69C2BA0", VA = "0x1869C37A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x69C4070", Offset = "0x69C3470", VA = "0x1869C4070")]
	public IIIBMJOAEEM([In] ELEGJCKPBKB DLBPMAOIOOF, [In] DKMLFKGIFDL NNMCDONDNGK, HHKLLHLLBEA MCAFIJENKGM, EFDLCFDPHEF INIDEKBNLPE, OHNJONJLGOD KKLGLFBPJHD, JMIHNFGNPBM NAOOMJHGHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x69C3940", Offset = "0x69C2D40", VA = "0x1869C3940")]
	private static string PLMEOFHJLGK(object LALIGKIKEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230")]
	private static long LPPIDGIHDME()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
	private static string IFFCNPCGLPF(string AIAOKDOODNM, string? DFBFDLCGJNG, bool LLDFIIAJFMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960")]
	private static bool GPMJPICAEPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69C3690", Offset = "0x69C2A90", VA = "0x1869C3690")]
	private static IIIBMJOAEEM EEOLELGLAFP()
	{
		return default(IIIBMJOAEEM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LALAIOBAHLA
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EGGMFGIJAOI JLFFMNMNBFI();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EGGMFGIJAOI : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool LJPAGGCGBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADIKPILFDPL();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LIGCMNKHPCN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJHKLDLMEAH([In] T IEDCHGMDIML);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void MOEPBJBGJFF<T>([In] T PEGMNLKCILJ);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct PMHEHAIGJJO<T> : IEquatable<PMHEHAIGJJO<T>>, LIGCMNKHPCN<PMHEHAIGJJO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T KHLHBLNGCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int KCOEJCJFNCN;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x200D8D0", Offset = "0x200CCD0", VA = "0x18200D8D0")]
	public PMHEHAIGJJO([In] T OBEEJPGJPFD, int AGAGKNBDCIG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x47F3060", Offset = "0x47F2460", VA = "0x1847F3060")]
	public static bool JAICCEKEELH([In] PMHEHAIGJJO<T> JNFNBKNOBNN, [In] PMHEHAIGJJO<T> CNFAHLDDGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x47F2750", Offset = "0x47F1B50", VA = "0x1847F2750", Slot = "4")]
	public bool Equals(PMHEHAIGJJO<T> IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3CE9DF0", Offset = "0x3CE91F0", VA = "0x183CE9DF0", Slot = "0")]
	public override bool Equals(object IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x47F26C0", Offset = "0x47F1AC0", VA = "0x1847F26C0")]
	public bool EJHKLDLMEAH([In] PMHEHAIGJJO<T> IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x47F2870", Offset = "0x47F1C70", VA = "0x1847F2870", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x47F3FA0", Offset = "0x47F33A0", VA = "0x1847F3FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x47F3490", Offset = "0x47F2890", VA = "0x1847F3490")]
	public void JJDJPLPGAPJ([Out] T OBEEJPGJPFD, [Out] int AGAGKNBDCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x47F39A0", Offset = "0x47F2DA0", VA = "0x1847F39A0")]
	public (T, int) PIILHOGBPJF()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x47F2670", Offset = "0x47F1A70", VA = "0x1847F2670", Slot = "5")]
	private bool EFAIPLDFKDC([In] PMHEHAIGJJO<T> IEDCHGMDIML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class OAEKIHHBNEG
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2D0A770", Offset = "0x2D09B70", VA = "0x182D0A770")]
	public static PMHEHAIGJJO<T> DDEJLDFANAB<T>([In] T OBEEJPGJPFD, int AGAGKNBDCIG) where T : notnull
	{
		return default(PMHEHAIGJJO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class EPAINPMHIDF
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x29EFED0", Offset = "0x29EF2D0", VA = "0x1829EFED0")]
	public static bool EJHKLDLMEAH<T, U>([In] T ABPJKOBADEP, [In] U LALIGKIKEBM) where T : notnull, LIGCMNKHPCN<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult ODNBNGIPIDG<T, out TResult>([In] T PEGMNLKCILJ);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface IIHCOOHJEHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	TimeSpan MLDJLADJEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Action? KMFONLNNOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OBMMDJGNFBM();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GBBLDECAFIG();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PJFGNNEKLMG();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct ELEGJCKPBKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly GDLLCFIGFOF PGPIAFIHGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly POOMCPMLMGG FJILHABIPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly GDLLCFIGFOF PNPGAGAPNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly POOMCPMLMGG GIJHFAJOBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly GDLLCFIGFOF CJMPHJGMPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly POOMCPMLMGG COBJBAJBOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly AOLOPILKJEI FLGEOMHLHAG;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly GDLLCFIGFOF HEGFHALDACN;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly POOMCPMLMGG PHOGPIBJLOI;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly GDLLCFIGFOF GILDCALPCDB;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly POOMCPMLMGG MODMGMBNDAL;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly GDLLCFIGFOF AKPOJAMGNEJ;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly POOMCPMLMGG LJDPBKBJELH;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly AOLOPILKJEI DDOHJBLLMAH;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly ELEGJCKPBKB ADMHPKLFINC;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly GDLLCFIGFOF HNBHJEPPABI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool OODFNLHIOMP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x69C10A0", Offset = "0x69C04A0", VA = "0x1869C10A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xC193C0", Offset = "0xC187C0", VA = "0x180C193C0")]
	public ELEGJCKPBKB(GDLLCFIGFOF MFANLGFGFNG, POOMCPMLMGG IAPFDHJHIGE, GDLLCFIGFOF OKELGLLBBJL, POOMCPMLMGG JFCALCKGGLD, GDLLCFIGFOF NPIMELCKANG, POOMCPMLMGG LLILFOGLKBF, AOLOPILKJEI BLMHGMJKJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960")]
	private static bool KEMNJICAOKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	private static void CGGNAFPLKPK(string PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960")]
	private static bool CNFABBADCEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	private static void PHMNHDELOEJ(string PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960")]
	private static bool JIJNNNHAKEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	private static void HLAONPMEFFB(string PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	private static void IBPBBIMGMCP(Exception PIBFNCHIFEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x69C0D40", Offset = "0x69C0140", VA = "0x1869C0D40")]
	private static ELEGJCKPBKB EEOLELGLAFP()
	{
		return default(ELEGJCKPBKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0")]
	private static bool PAOLHHLFENG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x69C12A0", Offset = "0x69C06A0", VA = "0x1869C12A0")]
	public void NEKMHMJECLN(object PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x69C0E80", Offset = "0x69C0280", VA = "0x1869C0E80")]
	public void FPLONKHBNMC(object PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1CEB4E0", Offset = "0x1CEA8E0", VA = "0x181CEB4E0")]
	public void HCCFHGNLNMP(Exception PIBFNCHIFEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x69C0EF0", Offset = "0x69C02F0", VA = "0x1869C0EF0")]
	public void FPLONKHBNMC(EGKJJMDAGFL PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x29E8F20", Offset = "0x29E8320", VA = "0x1829E8F20")]
	public void FPLONKHBNMC<T>(T PEGMNLKCILJ, HNIMKKGCMAI<T> PBDOHNMILPN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x29E8FF0", Offset = "0x29E83F0", VA = "0x1829E8FF0")]
	public void NEKMHMJECLN<T>([In] T PEGMNLKCILJ, GMJBPHCNOBB<T> PBDOHNMILPN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x29E8CB0", Offset = "0x29E80B0", VA = "0x1829E8CB0")]
	public void FPLONKHBNMC<T>([In] T PEGMNLKCILJ, GMJBPHCNOBB<T> PBDOHNMILPN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x69C0FD0", Offset = "0x69C03D0", VA = "0x1869C0FD0")]
	public bool JALEIJHGANA(bool GGBDOLNKFKN, string PBDOHNMILPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct FHDCIKFFLBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string KHLHBLNGCMJ;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x9FCD70", Offset = "0x9FC170", VA = "0x1809FCD70")]
	public FHDCIKFFLBO(string OBEEJPGJPFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0")]
	public static string JHFAHDJBNPM([In] FHDCIKFFLBO ABPJKOBADEP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xA44C30", Offset = "0xA44030", VA = "0x180A44C30")]
	public static FHDCIKFFLBO JHFAHDJBNPM(string IEDCHGMDIML)
	{
		return default(FHDCIKFFLBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69C1DA0", Offset = "0x69C11A0", VA = "0x1869C1DA0")]
	public string OFPHNNEFFKJ(string PBKDJDKCHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x69C1CC0", Offset = "0x69C10C0", VA = "0x1869C1CC0")]
	public string BADDHCKIKOD(object FAEELMJGFKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct AEFODLADDHH : IEquatable<AEFODLADDHH>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "4")]
	public bool Equals(AEFODLADDHH IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69BF330", Offset = "0x69BE730", VA = "0x1869BF330", Slot = "0")]
	public override bool Equals(object IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69BF380", Offset = "0x69BE780", VA = "0x1869BF380", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69BF390", Offset = "0x69BE790", VA = "0x1869BF390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[KGODJLMABGP("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct DMABLNOGLNN<T> : IEquatable<DMABLNOGLNN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T KHLHBLNGCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool LKKDKOOHMII;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DFELKJADCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x57A4480", Offset = "0x57A3880", VA = "0x1857A4480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x57A55C0", Offset = "0x57A49C0", VA = "0x1857A55C0")]
	public DMABLNOGLNN([In] T OBEEJPGJPFD, bool HMFPANHAJGF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x57A4FC0", Offset = "0x57A43C0", VA = "0x1857A4FC0")]
	public static bool JAICCEKEELH([In] DMABLNOGLNN<T> JNFNBKNOBNN, [In] DMABLNOGLNN<T> CNFAHLDDGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x47F2750", Offset = "0x47F1B50", VA = "0x1847F2750", Slot = "4")]
	public bool Equals(DMABLNOGLNN<T> IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x57A4760", Offset = "0x57A3B60", VA = "0x1857A4760", Slot = "0")]
	public override bool Equals(object IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x57A4DB0", Offset = "0x57A41B0", VA = "0x1857A4DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x57A5510", Offset = "0x57A4910", VA = "0x1857A5510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class IPJMAGBINCH
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE340", Offset = "0x2BBD740", VA = "0x182BBE340")]
	public static DMABLNOGLNN<T> IGAOFAOAIHO<T>([In] T OBEEJPGJPFD) where T : notnull
	{
		return default(DMABLNOGLNN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE200", Offset = "0x2BBD600", VA = "0x182BBE200")]
	public static DMABLNOGLNN<T?> BFKFGOIBBIA<T>()
	{
		return default(DMABLNOGLNN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE440", Offset = "0x2BBD840", VA = "0x182BBE440")]
	public static bool LGLMEIAOFNJ<T>([In] this DMABLNOGLNN<T> APFBNIOODNB, [Out][NotNullWhen(true)] T OBEEJPGJPFD) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct DKMLFKGIFDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr NCDOGLGOCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr CLGMODAGLBM;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr BKKDDGIDEJC;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr OPLILDJCACI;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly DKMLFKGIFDL ADMHPKLFINC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool OODFNLHIOMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x69BFD40", Offset = "0x69BF140", VA = "0x1869BFD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xB83E50", Offset = "0xB83250", VA = "0x180B83E50")]
	public DKMLFKGIFDL(IntPtr LLHGPGIKNOO, IntPtr NMGJIKLKEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	private static void ELEKBMJHMMF(string FIKHOKLHCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	private static void HBAMNNFHLPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x69BFCB0", Offset = "0x69BF0B0", VA = "0x1869BFCB0")]
	private static DKMLFKGIFDL EEOLELGLAFP()
	{
		return default(DKMLFKGIFDL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct HBNKDLCJDAP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr JKDBCCKEHEG;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9FCD70", Offset = "0x9FC170", VA = "0x1809FCD70")]
	private HBNKDLCJDAP(IntPtr NMGJIKLKEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x69C32A0", Offset = "0x69C26A0", VA = "0x1869C32A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x69C31A0", Offset = "0x69C25A0", VA = "0x1869C31A0")]
	public static HBNKDLCJDAP DDEJLDFANAB(string FIKHOKLHCII)
	{
		return default(HBNKDLCJDAP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1FECD40", Offset = "0x1FEC140", VA = "0x181FECD40")]
	public static HBNKDLCJDAP DDEJLDFANAB([In] DKMLFKGIFDL NNMCDONDNGK, string FIKHOKLHCII)
	{
		return default(HBNKDLCJDAP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1FECDC0", Offset = "0x1FEC1C0", VA = "0x181FECDC0")]
	public static HBNKDLCJDAP DDEJLDFANAB([In] DKMLFKGIFDL NNMCDONDNGK, Func<string> FIKHOKLHCII)
	{
		return default(HBNKDLCJDAP);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class NPBFHKBAPBH
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate bool FKDKJOIJNLE<in TInput, TResult>(TInput BCPLMINPIEH, [Out] TResult LLANANCGECL);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class HBKAGPMGLFE : LALAIOBAHLA
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class IONCAANBECD : EGGMFGIJAOI, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly IONCAANBECD CLHFPJDPLGI;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool LJPAGGCGBCP
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x69C4300", Offset = "0x69C3700", VA = "0x1869C4300", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x69C4360", Offset = "0x69C3760", VA = "0x1869C4360", Slot = "6")]
			public void OnCompleted(Action PCGPMGPOCEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
			public void ADIKPILFDPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public IONCAANBECD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly HBKAGPMGLFE CLHFPJDPLGI;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		private HBKAGPMGLFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x69C30D0", Offset = "0x69C24D0", VA = "0x1869C30D0", Slot = "4")]
		public EGGMFGIJAOI JLFFMNMNBFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private sealed class GFFGIOEOMLO : LALAIOBAHLA
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private sealed class PHPGAFGCKNK : EGGMFGIJAOI, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly PHPGAFGCKNK CLHFPJDPLGI;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool LJPAGGCGBCP
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x69CA740", Offset = "0x69C9B40", VA = "0x1869CA740", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x69CA760", Offset = "0x69C9B60", VA = "0x1869CA760", Slot = "6")]
			public void OnCompleted(Action PCGPMGPOCEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
			public void ADIKPILFDPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public PHPGAFGCKNK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly GFFGIOEOMLO CLHFPJDPLGI;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		private GFFGIOEOMLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x69C2460", Offset = "0x69C1860", VA = "0x1869C2460", Slot = "4")]
		public EGGMFGIJAOI JLFFMNMNBFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class GLMCFMMEILJ<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public GLMCFMMEILJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3D214F0", Offset = "0x3D208F0", VA = "0x183D214F0")]
		internal void MAKOAGEKDFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class LCEBGAPONHE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public LCEBGAPONHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x422A630", Offset = "0x4229A30", VA = "0x18422A630")]
		internal void AADFHBKFFIK(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct HHECDJJKAKI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69C32C0", Offset = "0x69C26C0", VA = "0x1869C32C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct NMCHAAHINFJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69C7260", Offset = "0x69C6660", VA = "0x1869C7260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct NGJJCBLPHJF<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x44F33C0", Offset = "0x44F27C0", VA = "0x1844F33C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x44F3530", Offset = "0x44F2930", VA = "0x1844F3530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct JFPMHEHEOAI<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4034A30", Offset = "0x4033E30", VA = "0x184034A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4035280", Offset = "0x4034680", VA = "0x184035280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct HLLBMIHHELN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69C3420", Offset = "0x69C2820", VA = "0x1869C3420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x69C3620", Offset = "0x69C2A20", VA = "0x1869C3620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class DENKILFLLAA<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public DENKILFLLAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3D214F0", Offset = "0x3D208F0", VA = "0x183D214F0")]
		internal void EFHFHLIINAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x57899B0", Offset = "0x5788DB0", VA = "0x1857899B0")]
		internal void FALEPLEOILM(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct FPMJHEGOJJA<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public FKDKJOIJNLE<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D5B0", Offset = "0x3C3C9B0", VA = "0x183C3D5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3C3DCE0", Offset = "0x3C3D0E0", VA = "0x183C3DCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct PCKKAMJAAPO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69C9EA0", Offset = "0x69C92A0", VA = "0x1869C9EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x69CA690", Offset = "0x69C9A90", VA = "0x1869CA690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct FPBJMHEKMDB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69C1DF0", Offset = "0x69C11F0", VA = "0x1869C1DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x69C2330", Offset = "0x69C1730", VA = "0x1869C2330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct NCDCGLGLOHP<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x44E6F40", Offset = "0x44E6340", VA = "0x1844E6F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3E740D0", Offset = "0x3E734D0", VA = "0x183E740D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct ADFDLCIOLKP<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3CC1970", Offset = "0x3CC0D70", VA = "0x183CC1970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x35A5410", Offset = "0x35A4810", VA = "0x1835A5410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct BAHAJEPPMHL<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4E7D8B0", Offset = "0x4E7CCB0", VA = "0x184E7D8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4E7DFC0", Offset = "0x4E7D3C0", VA = "0x184E7DFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct GOMNODBPIHH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69C2E90", Offset = "0x69C2290", VA = "0x1869C2E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x69C3070", Offset = "0x69C2470", VA = "0x1869C3070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct LHFAJGCEIME : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69C5F60", Offset = "0x69C5360", VA = "0x1869C5F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x69C62D0", Offset = "0x69C56D0", VA = "0x1869C62D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct OBOMDLLEJML : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69C9110", Offset = "0x69C8510", VA = "0x1869C9110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x69C9400", Offset = "0x69C8800", VA = "0x1869C9400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class EGFPIOKHPGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public EGFPIOKHPGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x69C0CD0", Offset = "0x69C00D0", VA = "0x1869C0CD0")]
		internal Task GHKHHIABDJK(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct NGCEFDGEAGF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69C6FA0", Offset = "0x69C63A0", VA = "0x1869C6FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x69C7200", Offset = "0x69C6600", VA = "0x1869C7200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct OMNBGHBAKKF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69C9560", Offset = "0x69C8960", VA = "0x1869C9560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x69C9740", Offset = "0x69C8B40", VA = "0x1869C9740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct FAJINHMINJJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69C18F0", Offset = "0x69C0CF0", VA = "0x1869C18F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x69C1C60", Offset = "0x69C1060", VA = "0x1869C1C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct IPGNMBNFLAD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69C4540", Offset = "0x69C3940", VA = "0x1869C4540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x69C4830", Offset = "0x69C3C30", VA = "0x1869C4830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class CKLOKGBJNFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public CKLOKGBJNFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x69BFC40", Offset = "0x69BF040", VA = "0x1869BFC40")]
		internal Task NADBIAEBGOL(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct CCAEHOKBLMH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69BF510", Offset = "0x69BE910", VA = "0x1869BF510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x69BF770", Offset = "0x69BEB70", VA = "0x1869BF770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct ILMHBKOKBHE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69C4120", Offset = "0x69C3520", VA = "0x1869C4120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x69C42A0", Offset = "0x69C36A0", VA = "0x1869C42A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct MDMIFEDBFLP<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4431E90", Offset = "0x4431290", VA = "0x184431E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x44320F0", Offset = "0x44314F0", VA = "0x1844320F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct CIBFCHAMKDN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69BF7D0", Offset = "0x69BEBD0", VA = "0x1869BF7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x69BFBE0", Offset = "0x69BEFE0", VA = "0x1869BFBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? HKFEOCJFHLP;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<AEFODLADDHH> BCFFAAADHBD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static Task LBHFLOODBND
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x69C8CA0", Offset = "0x69C80A0", VA = "0x1869C8CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x69C7370", Offset = "0x69C6770", VA = "0x1869C7370")]
	public static bool AIBGJKAHOHA(this Task LKENJOBMDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2CF26E0", Offset = "0x2CF1AE0", VA = "0x182CF26E0")]
	public static Task<T> JFICLAOEOGK<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x69C73A0", Offset = "0x69C67A0", VA = "0x1869C73A0")]
	public static Task BBFALPEKIGD(this Task LKENJOBMDDP, CancellationToken IAIFDAAIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2CF0890", Offset = "0x2CEFC90", VA = "0x182CF0890")]
	public static Task<TResult> BBFALPEKIGD<TResult>(this Task<TResult> LKENJOBMDDP, CancellationToken IAIFDAAIBBN) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2CF1800", Offset = "0x2CF0C00", VA = "0x182CF1800")]
	public static TaskCompletionSource<TResult> BBFALPEKIGD<TResult>(this TaskCompletionSource<TResult> JNFGPOOOADO, CancellationToken IAIFDAAIBBN) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x69C8850", Offset = "0x69C7C50", VA = "0x1869C8850")]
	public static IDisposable? MMLDJBJCLNJ(CancellationToken DHGMMOKNALK, CancellationToken EJNNPENPLBA, [Out] CancellationToken INLLOANMHAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x69C7AF0", Offset = "0x69C6EF0", VA = "0x1869C7AF0")]
	[AsyncStateMachine(typeof(HHECDJJKAKI))]
	public static void EOHANCKFLGD(this Task JILAKCNFFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x69C8B20", Offset = "0x69C7F20", VA = "0x1869C8B20")]
	[AsyncStateMachine(typeof(NMCHAAHINFJ))]
	public static void NLBHANKNPLJ(this Task JILAKCNFFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2190", Offset = "0x2CF1590", VA = "0x182CF2190")]
	[AsyncStateMachine(typeof(NGJJCBLPHJF<>))]
	public static Task DGOFFLLJEBD<TException>(this Task JILAKCNFFBM) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2260", Offset = "0x2CF1660", VA = "0x182CF2260")]
	[AsyncStateMachine(typeof(JFPMHEHEOAI<>))]
	public static Task<T> EAIGHILEMNO<T>(this Task<T> ABPJKOBADEP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x69C7A00", Offset = "0x69C6E00", VA = "0x1869C7A00")]
	[AsyncStateMachine(typeof(HLLBMIHHELN))]
	public static Task<TaskStatus> EKFFDGODDNM(this Task ABPJKOBADEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2F00", Offset = "0x2CF2300", VA = "0x182CF2F00")]
	public static (Task<T?>?, Action<T?>?) OCFEJIGAPFL<T>([Optional] CancellationToken GNJJGEHBGKC)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2C10", Offset = "0x2CF2010", VA = "0x182CF2C10")]
	[AsyncStateMachine(typeof(FPMJHEGOJJA<, >))]
	public static Task<List<TResult>> MONKGNGEGEN<TResult, TInput>(this Task<List<TInput>> LKENJOBMDDP, FKDKJOIJNLE<TInput, TResult> FBBLEABNOAH) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x69C8490", Offset = "0x69C7890", VA = "0x1869C8490")]
	[AsyncStateMachine(typeof(PCKKAMJAAPO))]
	public static Task JHNHPBIKMBP(Task JILAKCNFFBM, CancellationToken MJEEPFGMOAH, Func<CancellationToken, Task> BLKBANICCBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x69C7F30", Offset = "0x69C7330", VA = "0x1869C7F30")]
	[AsyncStateMachine(typeof(FPBJMHEKMDB))]
	public static Task GJJLIEDAELM(Func<CancellationToken, Task> DILODBFFABL, TimeSpan HOBGOAIPHPO, [Optional] CancellationToken MJEEPFGMOAH, [Optional] Action<OperationCanceledException>? DFKINPMNNML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2440", Offset = "0x2CF1840", VA = "0x182CF2440")]
	[AsyncStateMachine(typeof(NCDCGLGLOHP<>))]
	public static Task<T> GJJLIEDAELM<T>(Func<CancellationToken, Task<T>> DILODBFFABL, TimeSpan HOBGOAIPHPO, [Optional] CancellationToken MJEEPFGMOAH, [Optional] Func<OperationCanceledException, T>? DFKINPMNNML) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2E10", Offset = "0x2CF2210", VA = "0x182CF2E10")]
	[AsyncStateMachine(typeof(ADFDLCIOLKP<>))]
	public static Task<IEnumerable<Task<T>>> OBGJKHKDKJD<T>(IEnumerable<Task<T>> HBKDGABFJJD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2860", Offset = "0x2CF1C60", VA = "0x182CF2860")]
	[AsyncStateMachine(typeof(BAHAJEPPMHL<, , , >))]
	public static Task<(T1, T2, T3, T4)> KPEJEKOBGPK<T1, T2, T3, T4>(Task<T1> PMFEEDDAJGC, Task<T2> GDFFBBHIAJH, Task<T3> NOHOLEFLIKE, Task<T4> JBKGMPKMOLI) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x69C7910", Offset = "0x69C6D10", VA = "0x1869C7910")]
	[AsyncStateMachine(typeof(GOMNODBPIHH))]
	public static Task BHNMNMIDIBA(Func<bool> GGBDOLNKFKN, [Optional] CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x69C7800", Offset = "0x69C6C00", VA = "0x1869C7800")]
	[AsyncStateMachine(typeof(LHFAJGCEIME))]
	public static Task BHNMNMIDIBA(Func<bool> GGBDOLNKFKN, TimeSpan FJEFOABIHMI, [Optional] CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x69C8D10", Offset = "0x69C8110", VA = "0x1869C8D10")]
	[AsyncStateMachine(typeof(OBOMDLLEJML))]
	public static Task OMDCINCJLLF(Func<bool> GGBDOLNKFKN, TimeSpan HOBGOAIPHPO, [Optional] CancellationToken GNJJGEHBGKC, [Optional] Action<OperationCanceledException>? DFKINPMNNML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x69C8E40", Offset = "0x69C8240", VA = "0x1869C8E40")]
	[AsyncStateMachine(typeof(NGCEFDGEAGF))]
	public static Task OMDCINCJLLF(Func<bool> GGBDOLNKFKN, TimeSpan HOBGOAIPHPO, TimeSpan FJEFOABIHMI, [Optional] CancellationToken GNJJGEHBGKC, [Optional] Action<OperationCanceledException>? DFKINPMNNML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x69C7710", Offset = "0x69C6B10", VA = "0x1869C7710")]
	[AsyncStateMachine(typeof(OMNBGHBAKKF))]
	public static Task BDLKJLMOABK(Func<bool> GGBDOLNKFKN, [Optional] CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x69C7600", Offset = "0x69C6A00", VA = "0x1869C7600")]
	[AsyncStateMachine(typeof(FAJINHMINJJ))]
	public static Task BDLKJLMOABK(Func<bool> GGBDOLNKFKN, TimeSpan FJEFOABIHMI, [Optional] CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x69C7CE0", Offset = "0x69C70E0", VA = "0x1869C7CE0")]
	[AsyncStateMachine(typeof(IPGNMBNFLAD))]
	public static Task FAFKCGJHDJH(Func<bool> GGBDOLNKFKN, TimeSpan HOBGOAIPHPO, [Optional] CancellationToken GNJJGEHBGKC, [Optional] Action<OperationCanceledException>? DFKINPMNNML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x69C7BA0", Offset = "0x69C6FA0", VA = "0x1869C7BA0")]
	[AsyncStateMachine(typeof(CCAEHOKBLMH))]
	public static Task FAFKCGJHDJH(Func<bool> GGBDOLNKFKN, TimeSpan HOBGOAIPHPO, TimeSpan FJEFOABIHMI, [Optional] CancellationToken GNJJGEHBGKC, [Optional] Action<OperationCanceledException>? DFKINPMNNML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x69C8690", Offset = "0x69C7A90", VA = "0x1869C8690")]
	[Obsolete]
	[AsyncStateMachine(typeof(ILMHBKOKBHE))]
	public static Task LEFGFEBACMI(this Task LKENJOBMDDP, Action AJBANCJKONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2B20", Offset = "0x2CF1F20", VA = "0x182CF2B20")]
	[AsyncStateMachine(typeof(MDMIFEDBFLP<>))]
	[Obsolete]
	public static Task LEFGFEBACMI<T>(this Task<T> LKENJOBMDDP, Action<T> AJBANCJKONG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x69C83E0", Offset = "0x69C77E0", VA = "0x1869C83E0")]
	private static void JAHDMJCJDJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x69C8060", Offset = "0x69C7460", VA = "0x1869C8060")]
	public static bool IDDMKFJIAOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x69C8990", Offset = "0x69C7D90", VA = "0x1869C8990")]
	private static void NBBAPIINDOL(SynchronizationContext OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x69C7E10", Offset = "0x69C7210", VA = "0x1869C7E10")]
	private static void FEKHAGBKEKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x69C85C0", Offset = "0x69C79C0", VA = "0x1869C85C0")]
	public static void JMIPFELHFIL([Optional] string? PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x69C8BD0", Offset = "0x69C7FD0", VA = "0x1869C8BD0")]
	public static void NNNHAFCGKFM([Optional] string? PBDOHNMILPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x69C8F80", Offset = "0x69C8380", VA = "0x1869C8F80")]
	public static LALAIOBAHLA OOJKEGBHFGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x69C8C50", Offset = "0x69C8050", VA = "0x1869C8C50")]
	public static LALAIOBAHLA NOOEGLKOKIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x69C8780", Offset = "0x69C7B80", VA = "0x1869C8780")]
	[AsyncStateMachine(typeof(CIBFCHAMKDN))]
	public static Task MKEFJIEBFGN(Func<Task> IAJCFKFGJIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class NIMGPLGMLPL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
	public NIMGPLGMLPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class DMPAEADEGJF : MGCCPOFMDKP
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly MGCCPOFMDKP CLHFPJDPLGI;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTime NFIDLBJJKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x69BFFD0", Offset = "0x69BF3D0", VA = "0x1869BFFD0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DateTimeOffset DHKECJKMLJN
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x69BFF70", Offset = "0x69BF370", VA = "0x1869BFF70", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public DMPAEADEGJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface MGCCPOFMDKP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTime NFIDLBJJKIN
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DateTimeOffset DHKECJKMLJN
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class JJPMPMEMBCG
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long CGPBJLDKONB
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x69C4B40", Offset = "0x69C3F40", VA = "0x1869C4B40")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static long CKEMGOOMHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x69C4AF0", Offset = "0x69C3EF0", VA = "0x1869C4AF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double ANHNNLOIEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x69C4A10", Offset = "0x69C3E10", VA = "0x1869C4A10")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double IENBOPICOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x69C49C0", Offset = "0x69C3DC0", VA = "0x1869C49C0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double BNLHGMKHPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x69C4890", Offset = "0x69C3C90", VA = "0x1869C4890")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static double FFFFMNDGJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x69C48E0", Offset = "0x69C3CE0", VA = "0x1869C48E0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x69C4D00", Offset = "0x69C4100", VA = "0x1869C4D00")]
	public static double NENAAIDIHJL(long OPFLKKENMFD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x69C4A60", Offset = "0x69C3E60", VA = "0x1869C4A60")]
	public static double HKMAOBNCJKF(long OPFLKKENMFD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x69C4BA0", Offset = "0x69C3FA0", VA = "0x1869C4BA0")]
	public static double LKCPLKJFKON(double KKCNFMMHFNA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x69C4930", Offset = "0x69C3D30", VA = "0x1869C4930")]
	public static long EJIPDADALIG(long NEHLEIDGFCE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x69C4B90", Offset = "0x69C3F90", VA = "0x1869C4B90")]
	public static long LJELOAFIJPP(long JGEBMEONMMG, long GGJGALDFFIM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x69C4C30", Offset = "0x69C4030", VA = "0x1869C4C30")]
	public static double LPINDMEONAE(long JGEBMEONMMG, long GGJGALDFFIM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x69C4D90", Offset = "0x69C4190", VA = "0x1869C4D90")]
	public static double OPKNCNCJKJI(long JGEBMEONMMG, long GGJGALDFFIM)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class PAAPLEKDBPA : IIHCOOHJEHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static readonly TimeSpan IMKONHGOAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly System.Timers.Timer JAHFGCAKLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private TimeSpan HOBGOAIPHPO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public TimeSpan MLDJLADJEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x69C99E0", Offset = "0x69C8DE0", VA = "0x1869C99E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Action? KMFONLNNOCM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x69C9BE0", Offset = "0x69C8FE0", VA = "0x1869C9BE0")]
	[Preserve]
	public PAAPLEKDBPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x69C9C50", Offset = "0x69C9050", VA = "0x1869C9C50")]
	public PAAPLEKDBPA(TimeSpan HOBGOAIPHPO, [Optional] Action? JNEIJKIIHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x69C9950", Offset = "0x69C8D50", VA = "0x1869C9950", Slot = "7")]
	public void OBMMDJGNFBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x69C98E0", Offset = "0x69C8CE0", VA = "0x1869C98E0", Slot = "8")]
	public void GBBLDECAFIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x69C9B40", Offset = "0x69C8F40", VA = "0x1869C9B40", Slot = "9")]
	public void PJFGNNEKLMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x9EDB00", Offset = "0x9ECF00", VA = "0x1809EDB00")]
	private void BALILONCEOJ(object MHKDAHGGECP, ElapsedEventArgs NADHHBBGIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x69C97A0", Offset = "0x69C8BA0", VA = "0x1869C97A0")]
	private static void BAGAGEEJFKB(TimeSpan AGIJKFLOBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x69C9840", Offset = "0x69C8C40", VA = "0x1869C9840", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class KGODJLMABGP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly string? EFOGMLLEJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly string DBAPPAIBLDM;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x1E26C10", Offset = "0x1E26010", VA = "0x181E26C10")]
	public KGODJLMABGP(string ANGPLEOPDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x37EA370", Offset = "0x37E9770", VA = "0x1837EA370")]
	public KGODJLMABGP(string OCJFKFBFMFI, string ANGPLEOPDHC)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct KOIDIICODKL : IEquatable<KOIDIICODKL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public uint HFDLPNENLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int KHENIMKFDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float JBBDFHHEILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public ushort HOACGFHJDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public ushort GHJLPPOFGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public short KBFMIDKAJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public short ENNDBAGJNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public char HKNELKENBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public char PGJLJKBPBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte GOOJKDDJCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte LCHLENBFGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public byte FDOAFOKJAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte MPMGHNCLABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool NODJDKNGGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool IEDJMFCGLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public bool LFJEGECNFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool AFEPIOHJHPC;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xE66540", Offset = "0xE65940", VA = "0x180E66540")]
	public static KOIDIICODKL DPOMOCDMBPL(uint OKFOLOFGECO)
	{
		return default(KOIDIICODKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0xE66540", Offset = "0xE65940", VA = "0x180E66540")]
	public static KOIDIICODKL DBELFNDMEAB(int GFPGLMLKMCI)
	{
		return default(KOIDIICODKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x69C5160", Offset = "0x69C4560", VA = "0x1869C5160")]
	public static KOIDIICODKL NODEHCLAIHM(float MHALBOMCNDG)
	{
		return default(KOIDIICODKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x69C5140", Offset = "0x69C4540", VA = "0x1869C5140")]
	public static KOIDIICODKL LCELMKDGNMO(byte HKACKPIIOPF, byte HHFBMBDBHKA, byte GMHBINDNHKK, byte PCJKFGDOHAF)
	{
		return default(KOIDIICODKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x69C5140", Offset = "0x69C4540", VA = "0x1869C5140")]
	public static KOIDIICODKL INANAECABPM(bool HMGPLGNPJKN, bool AEFFCCGJDBC, bool FGIOIIKFJIH, bool FDEJHJLBHDD)
	{
		return default(KOIDIICODKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x69C5140", Offset = "0x69C4540", VA = "0x1869C5140")]
	public static KOIDIICODKL ODIKHKJAJLH(byte CIPKGGBKDCM, byte OFCADBKBJAD, byte GBJEOHOOFBO, byte FJFDNJKOBBM)
	{
		return default(KOIDIICODKL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1B75460", Offset = "0x1B74860", VA = "0x181B75460")]
	public static bool JAICCEKEELH(KOIDIICODKL LJHBAHCCIGM, KOIDIICODKL EFOLFMFJLOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0xAE6B50", Offset = "0xAE5F50", VA = "0x180AE6B50", Slot = "4")]
	public bool Equals(KOIDIICODKL IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x69C50C0", Offset = "0x69C44C0", VA = "0x1869C50C0", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xB7F990", Offset = "0xB7ED90", VA = "0x180B7F990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x69C5170", Offset = "0x69C4570", VA = "0x1869C5170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct PDIIGKOHMKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public ulong LKAKBBIDNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public long PMFLCCHALGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public double NAIFCLBEBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint KGPOJOEIJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint MFOMFOCBLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public int ODMEOLGBMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int PKBDFNAJMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float GOIANAMBKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float GFGKKPPANJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort HOACGFHJDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort GHJLPPOFGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public ushort NBJINCIGJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort FKJLCOFHNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short KBFMIDKAJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short ENNDBAGJNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public short CKKEFEFCCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short DKMLFBGICJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char HKNELKENBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char PGJLJKBPBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public char DGMIOLLOLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char LFHNOCHLPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte GOOJKDDJCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte LCHLENBFGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte FDOAFOKJAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte MPMGHNCLABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte GNOKHAGNLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte BILGEOIHCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte IAJCENEPJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte BPGFLNKNNME;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x69CA6F0", Offset = "0x69C9AF0", VA = "0x1869CA6F0")]
	public static PDIIGKOHMKE DDEJLDFANAB(byte HKACKPIIOPF, byte HHFBMBDBHKA, byte GMHBINDNHKK, byte PCJKFGDOHAF, byte LPANOMMFGBC, byte MCCEAAGOFFJ, byte PDCBLDPMNPD, byte MNEJGPKJONK)
	{
		return default(PDIIGKOHMKE);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct MKMBLIOLPPM : IEquatable<MKMBLIOLPPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte PJOIIEKEMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool AOABLCPOJIA;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x25AF850", Offset = "0x25AEC50", VA = "0x1825AF850")]
	public static MKMBLIOLPPM LCELMKDGNMO(byte NDFKNGAIELI)
	{
		return default(MKMBLIOLPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x25AF850", Offset = "0x25AEC50", VA = "0x1825AF850")]
	public static MKMBLIOLPPM INANAECABPM(bool KIPOKLHKAFO)
	{
		return default(MKMBLIOLPPM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x69C63D0", Offset = "0x69C57D0", VA = "0x1869C63D0")]
	public static bool JAICCEKEELH(MKMBLIOLPPM LJHBAHCCIGM, MKMBLIOLPPM EFOLFMFJLOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5B53320", Offset = "0x5B52720", VA = "0x185B53320", Slot = "4")]
	public bool Equals(MKMBLIOLPPM IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x69C6330", Offset = "0x69C5730", VA = "0x1869C6330", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x69C63C0", Offset = "0x69C57C0", VA = "0x1869C63C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x69C63E0", Offset = "0x69C57E0", VA = "0x1869C63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class NEGENFGAPGE<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public readonly T LOPOAOGELNH;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x44EC0D0", Offset = "0x44EB4D0", VA = "0x1844EC0D0")]
	public NEGENFGAPGE(T DHLDMMKADKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class DOAAOAFHGIO
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x299BA90", Offset = "0x299AE90", VA = "0x18299BA90")]
	public static IEnumerable<T> LMFBOHIONHO<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
	public static T[] EDHKHOLAJHA<T>(params T[] IHIKMJHGKDJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
	public static IEnumerable<T> JIHJHGHEHCB<T>(params T[] IHIKMJHGKDJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x299BA00", Offset = "0x299AE00", VA = "0x18299BA00")]
	public static HashSet<T> EFHOICKGCMD<T>(params T[] IHIKMJHGKDJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x299BAC0", Offset = "0x299AEC0", VA = "0x18299BAC0")]
	public static KeyValuePair<TKey, TValue> MHLGCDMEJLJ<TKey, TValue>([In] TKey PEDCMDADFIN, [In] TValue OBEEJPGJPFD) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x299BA00", Offset = "0x299AE00", VA = "0x18299BA00")]
	public static List<T> KOJKOBKOCJL<T>(IEnumerable<T> MDKDACOPOHC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[AttributeUsage(AttributeTargets.All)]
public sealed class NDLGMFPEHCH : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public readonly string MGCOOFFOEAF;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x8765E0", Offset = "0x8759E0", VA = "0x1808765E0")]
	public NDLGMFPEHCH(string KFGKPLPCACH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object GMJBPHCNOBB<T>([In] T JEKDODJMDHN);
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate object HNIMKKGCMAI<T>(T JEKDODJMDHN);
[Cpp2IlInjected.Token(Token = "0x200005A")]
[DFLHACDHMLN]
public delegate string OHNJONJLGOD(string AIAOKDOODNM, string? DFBFDLCGJNG, bool LLDFIIAJFMK);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[DFLHACDHMLN]
public delegate void POOMCPMLMGG(string PBDOHNMILPN);
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DFLHACDHMLN]
public delegate void AOLOPILKJEI(Exception PIBFNCHIFEN);
[Cpp2IlInjected.Token(Token = "0x200005D")]
public delegate object EGKJJMDAGFL();
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DFLHACDHMLN]
public delegate bool GDLLCFIGFOF();
[Cpp2IlInjected.Token(Token = "0x200005F")]
[DFLHACDHMLN]
public delegate string HHKLLHLLBEA(object LALIGKIKEBM);
[Cpp2IlInjected.Token(Token = "0x2000060")]
[AttributeUsage(AttributeTargets.Enum)]
public class ILNJKLHILIK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
	public ILNJKLHILIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class DOIAIBJDACG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct NGBJDOHCDBC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x69C6640", Offset = "0x69C5A40", VA = "0x1869C6640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x69C6F30", Offset = "0x69C6330", VA = "0x1869C6F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly TimerCallback LBGMDJEJPKA;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Action<object?> HILJAIKHJAF;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x69C0120", Offset = "0x69BF520", VA = "0x1869C0120")]
	public static Task<bool> GBKGEFACFHG(int JJHKDCAPEBM, [Optional] CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x69C04C0", Offset = "0x69BF8C0", VA = "0x1869C04C0")]
	[AsyncStateMachine(typeof(NGBJDOHCDBC))]
	private static Task<bool> MCPMMHJNEIA(int JJHKDCAPEBM, CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x69C0430", Offset = "0x69BF830", VA = "0x1869C0430")]
	private static void LMFBOPAOMCG(object? AHEJMLCHHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x69C0090", Offset = "0x69BF490", VA = "0x1869C0090")]
	private static void AMNNECNHEGD(object? AHEJMLCHHMA)
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
