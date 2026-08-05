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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6C661E0", Offset = "0x6C64BE0", VA = "0x186C661E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5A0", Offset = "0x8ACFA0", VA = "0x1808AE5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE5E0", Offset = "0x8ACFE0", VA = "0x1808AE5E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MLAECEAOOMF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C656D0", Offset = "0x6C640D0", VA = "0x186C656D0")]
	public static string DIDEJAGADEK(this Encoding DNBHMMFBLMI, [In] ReadOnlySequence<byte> MGCOGNAKONH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2E786B0", Offset = "0x2E770B0", VA = "0x182E786B0")]
	private static void NHIOOFHDPFM<T>(this ReadOnlySequence<T> FAGFDNBJNIF, [Out] ReadOnlySpan<T> NLJCKDLDEED, [Out] SequencePosition MFBGMKJONKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class FFGBAHOAFJL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C61F20", Offset = "0x6C60920", VA = "0x186C61F20")]
	public FFGBAHOAFJL(bool NOJBPHFAALN, string LMLENMMABKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NCNGNFLNKDJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DEBMMJGBJDG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IMGNOLIODMB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHHEFKFMJIJ(string COMNIKKFEEB, double IPHMAHBENGI, [Optional] string? BABDEMFLFGD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GICAJEHFKPK<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate Task<TResult> KHMCKKJDIDN(CancellationToken LOIOCMLGMKH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct HPBHALKMCLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public GICAJEHFKPK<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public KHMCKKJDIDN taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x3FE2770", Offset = "0x3FE1170", VA = "0x183FE2770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3FE3830", Offset = "0x3FE2230", VA = "0x183FE3830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource OJIENHCHFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? OIMICBCHPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? FHANFMFLBND;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3EDA370", Offset = "0x3ED8D70", VA = "0x183EDA370")]
	[AsyncStateMachine(typeof(GICAJEHFKPK<>.HPBHALKMCLO))]
	public Task<TResult> EKCIIEEFKFG(KHMCKKJDIDN PJGAOBPHIJN, [Optional] CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3EDA300", Offset = "0x3ED8D00", VA = "0x183EDA300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3EDA4B0", Offset = "0x3ED8EB0", VA = "0x183EDA4B0")]
	public GICAJEHFKPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class GGGJKFECCNF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> NANNDMILDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T ADJCIFCGLHC;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2940", Offset = "0x3ED1340", VA = "0x183ED2940")]
	public GGGJKFECCNF([In] T IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3ED19E0", Offset = "0x3ED03E0", VA = "0x183ED19E0", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3ED21F0", Offset = "0x3ED0BF0", VA = "0x183ED21F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2430", Offset = "0x3ED0E30", VA = "0x183ED2430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class OIHHPFJPLNP
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0970", Offset = "0x2BCF370", VA = "0x182BD0970")]
	public static GGGJKFECCNF<T> OOAFHJGKFEK<T>([In] T IPHMAHBENGI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IHCIMDKKBHE
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C63C00", Offset = "0x6C62600", VA = "0x186C63C00")]
	public static void IPJDCJMDHEP(this CancellationTokenSource OJIENHCHFHH, bool FOPCFCMDBMB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class LHNCMCFHJIK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
	public LHNCMCFHJIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class OKKPIGINHED : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
	public OKKPIGINHED(string GECAIPKBFBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DPDKFKLOLDI
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2BADD00", Offset = "0x2BAC700", VA = "0x182BADD00")]
	public static ONOAOHKIBFG EHHHKHAOAJC<T>()
	{
		return default(ONOAOHKIBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2BADF50", Offset = "0x2BAC950", VA = "0x182BADF50")]
	public static ONOAOHKIBFG HNIPPHBLEOD<T>([CallerMemberName] string DDDMPLCOGIM = "") where T : notnull
	{
		return default(ONOAOHKIBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2BADD80", Offset = "0x2BAC780", VA = "0x182BADD80")]
	public static ONOAOHKIBFG EHHHKHAOAJC<T>(this T DICHKFJDHIG) where T : notnull
	{
		return default(ONOAOHKIBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2BADBB0", Offset = "0x2BAC5B0", VA = "0x182BADBB0")]
	public static ONOAOHKIBFG ANHJFMECFBJ<T>(this T DICHKFJDHIG, [CallerMemberName] string DDDMPLCOGIM = "") where T : notnull
	{
		return default(ONOAOHKIBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2BADFF0", Offset = "0x2BAC9F0", VA = "0x182BADFF0")]
	public static ONOAOHKIBFG HNIPPHBLEOD<T>(this T NKCEKILMAAM, [CallerMemberName] string DDDMPLCOGIM = "") where T : notnull
	{
		return default(ONOAOHKIBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C611E0", Offset = "0x6C5FBE0", VA = "0x186C611E0")]
	public static ONOAOHKIBFG HNIPPHBLEOD(string PAMKELFHDGK, [CallerMemberName] string DDDMPLCOGIM = "")
	{
		return default(ONOAOHKIBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C61140", Offset = "0x6C5FB40", VA = "0x186C61140")]
	public static string EOHEBCEGIKG(this object NKCEKILMAAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool CPJDEOFJKFB();
[Cpp2IlInjected.Token(Token = "0x2000014")]
[LHNCMCFHJIK]
public delegate long NPNLAEAPGCJ();
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DDJOKGPFMDE
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static HGAGMNEAAOD MMHJNIFLKNP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static HGAGMNEAAOD BFGDAEEKOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C5E1D0", Offset = "0x6C5CBD0", VA = "0x186C5E1D0")]
		get
		{
			return default(HGAGMNEAAOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static BFIAAFJLAAA FDOLHFAALJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C5EA00", Offset = "0x6C5D400", VA = "0x186C5EA00")]
		get
		{
			return default(BFIAAFJLAAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static PHAMLIOLJCC MDKEFEDJICB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C5E930", Offset = "0x6C5D330", VA = "0x186C5E930")]
		get
		{
			return default(PHAMLIOLJCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool PNDCNKLCLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6C5E4E0", Offset = "0x6C5CEE0", VA = "0x186C5E4E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E790", Offset = "0x6C5D190", VA = "0x186C5E790")]
	public static void MDCJINFGKEH([In] HGAGMNEAAOD DEIJKOHCDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E6C0", Offset = "0x6C5D0C0", VA = "0x186C5E6C0")]
	public static void LHPAJEFICIG(string BBDGOIMNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E220", Offset = "0x6C5CC20", VA = "0x186C5E220")]
	public static void EFALNILAKLE(string BBDGOIMNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2B8CD60", Offset = "0x2B8B760", VA = "0x182B8CD60")]
	public static void EFALNILAKLE<T>(T OKHFPGFAECB, NJPGJODCAPA<T> BBDGOIMNDJI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E620", Offset = "0x6C5D020", VA = "0x186C5E620")]
	public static void KNIODBNLABE(Exception JCOJOLLOCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E980", Offset = "0x6C5D380", VA = "0x186C5E980")]
	public static void PIDMAPOKMOD(string DDDMPLCOGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E470", Offset = "0x6C5CE70", VA = "0x186C5E470")]
	public static void JKBAOFOIJNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E2F0", Offset = "0x6C5CCF0", VA = "0x186C5E2F0")]
	public static string EOHEBCEGIKG(object FHFDEAHMMBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E400", Offset = "0x6C5CE00", VA = "0x186C5E400")]
	public static long JEAACCPPNOK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E360", Offset = "0x6C5CD60", VA = "0x186C5E360")]
	public static bool FKCBLLHCBJP(bool FLLLJDPKPMB, string BBDGOIMNDJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E550", Offset = "0x6C5CF50", VA = "0x186C5E550")]
	public static double JLOIFNCDPGG()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct HGAGMNEAAOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly BFIAAFJLAAA FDOLHFAALJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly PHAMLIOLJCC MDKEFEDJICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly JLKGEALBBLP HEOPOIIHJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly NPNLAEAPGCJ JLJBOMOBHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly ICMPOIKKJCA HKAMPCJPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly CPJDEOFJKFB DDAPONEAOBC;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly JLKGEALBBLP ECOGIGGOFHL;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly NPNLAEAPGCJ BABENCHLMJB;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly ICMPOIKKJCA BCBOGOIAGNI;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly CPJDEOFJKFB ADNBALKMGON;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly HGAGMNEAAOD CKLKOBNMKJP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool EMCJBNDMBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6C62B00", Offset = "0x6C61500", VA = "0x186C62B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C63450", Offset = "0x6C61E50", VA = "0x186C63450")]
	public HGAGMNEAAOD([In] BFIAAFJLAAA OFFDJOGFFLJ, [In] PHAMLIOLJCC DFACKABLGEL, JLKGEALBBLP OEHBLDJGIPA, NPNLAEAPGCJ EDNHMBFFMEM, ICMPOIKKJCA HGHAKPNMJPK, CPJDEOFJKFB ANCGHOMLPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C62AC0", Offset = "0x6C614C0", VA = "0x186C62AC0")]
	private static string CGEMKENENGC(object FHFDEAHMMBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x883240", Offset = "0x881C40", VA = "0x180883240")]
	private static long IBEJAFEFCDF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670")]
	private static string ECPNGCACOFK(string OOCPPLNIOAJ, string? PFOPPCFDLPJ, bool MNMJGJLNNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0")]
	private static bool OPEMODJFJPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C62C90", Offset = "0x6C61690", VA = "0x186C62C90")]
	private static HGAGMNEAAOD NJBGFCCIDPD()
	{
		return default(HGAGMNEAAOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FJAMIMOJDEL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PKECDLGKLKP CCPNIIDMBMI();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PKECDLGKLKP : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool JNBOLGGGPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBCJEGKBFPA();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DFOHKGGFAED<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FNAPBPPPEKA([In] T CGCLEIBHLHF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void APHHBCODMAL<T>([In] T OKHFPGFAECB);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct PMFCIACEFOO<T> : IEquatable<PMFCIACEFOO<T>>, DFOHKGGFAED<PMFCIACEFOO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T ADJCIFCGLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int BDIPFIAMOOH;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2164F90", Offset = "0x2163990", VA = "0x182164F90")]
	public PMFCIACEFOO([In] T IPHMAHBENGI, int ENMILGHAHOM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x49BEC80", Offset = "0x49BD680", VA = "0x1849BEC80")]
	public static bool JGJOKBKMGBC([In] PMFCIACEFOO<T> OMCEEKENOBB, [In] PMFCIACEFOO<T> MOBHGIAPGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x49BDFF0", Offset = "0x49BC9F0", VA = "0x1849BDFF0", Slot = "4")]
	public bool Equals(PMFCIACEFOO<T> CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4489EC0", Offset = "0x44888C0", VA = "0x184489EC0", Slot = "0")]
	public override bool Equals(object CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x49BE110", Offset = "0x49BCB10", VA = "0x1849BE110")]
	public bool FNAPBPPPEKA([In] PMFCIACEFOO<T> CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x49BE910", Offset = "0x49BD310", VA = "0x1849BE910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x49BF6A0", Offset = "0x49BE0A0", VA = "0x1849BF6A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x49BE1A0", Offset = "0x49BCBA0", VA = "0x1849BE1A0")]
	public void GJGCCCKLLFN([Out] T IPHMAHBENGI, [Out] int ENMILGHAHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x49BDC40", Offset = "0x49BC640", VA = "0x1849BDC40")]
	public (T, int) DKOFJDBLENN()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x49BF2D0", Offset = "0x49BDCD0", VA = "0x1849BF2D0", Slot = "5")]
	private bool NMNOJEOJMPM([In] PMFCIACEFOO<T> CGCLEIBHLHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LHCJHGEOOPD
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2E1C330", Offset = "0x2E1AD30", VA = "0x182E1C330")]
	public static PMFCIACEFOO<T> OOAFHJGKFEK<T>([In] T IPHMAHBENGI, int ENMILGHAHOM) where T : notnull
	{
		return default(PMFCIACEFOO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class BKPIPDKPKLM
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3830", Offset = "0x2AF2230", VA = "0x182AF3830")]
	public static bool FNAPBPPPEKA<T, U>([In] T NKCEKILMAAM, [In] U FHFDEAHMMBI) where T : notnull, DFOHKGGFAED<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult DEKGDJINLLG<T, out TResult>([In] T OKHFPGFAECB);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KNNKIAFDEON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	TimeSpan LJCDGOOBDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Action? LMOKEKMAPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MIKAPCLAFCB();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FLPCLHEHCLK();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MFPKDJMJBIO();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct BFIAAFJLAAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly CHKHGPJKHGH HHOHODELAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly DMBPEBGKOAJ PEMPNMMMKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly CHKHGPJKHGH IFMHOLCMCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly DMBPEBGKOAJ AJDAEJOBMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly CHKHGPJKHGH MJJFINGNBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly DMBPEBGKOAJ GBDKECOODPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly CCECNNOLGKK LAHPELPDMNK;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly CHKHGPJKHGH LGFDCHHPICB;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly DMBPEBGKOAJ JGANNKOHHLH;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly CHKHGPJKHGH HFOEMMIMDFF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly DMBPEBGKOAJ EFIBIKNIHBD;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly CHKHGPJKHGH JOAOIFDLEME;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly DMBPEBGKOAJ NGPIFEMHGAN;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly CCECNNOLGKK OMIMAHCKENM;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly BFIAAFJLAAA CKLKOBNMKJP;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly CHKHGPJKHGH GEHHGMEBAHO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool EMCJBNDMBFI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C5C890", Offset = "0x6C5B290", VA = "0x186C5C890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xD89700", Offset = "0xD88100", VA = "0x180D89700")]
	public BFIAAFJLAAA(CHKHGPJKHGH AJJHMEACABK, DMBPEBGKOAJ LACKCMPLMDC, CHKHGPJKHGH NNJMADEOLOL, DMBPEBGKOAJ JCEPNBDMOKM, CHKHGPJKHGH MFFPEALMHHM, DMBPEBGKOAJ DFEBABFMKDF, CCECNNOLGKK GMGOGFELFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0")]
	private static bool AKOHEJJFJKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void PJJFPANGOMG(string BBDGOIMNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0")]
	private static bool LBPGJBEMCMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void AEOHNCDNPMP(string BBDGOIMNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0")]
	private static bool CBAEHPGFAAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void FMBJHAPJJIE(string BBDGOIMNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void KPJAHMBCHCE(Exception JCOJOLLOCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6C5CAE0", Offset = "0x6C5B4E0", VA = "0x186C5CAE0")]
	private static BFIAAFJLAAA NJBGFCCIDPD()
	{
		return default(BFIAAFJLAAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000")]
	private static bool LAGKOGHEEEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6C5CA70", Offset = "0x6C5B470", VA = "0x186C5CA70")]
	public void LHPAJEFICIG(object BBDGOIMNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6C5C750", Offset = "0x6C5B150", VA = "0x186C5C750")]
	public void EFALNILAKLE(object BBDGOIMNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1F77150", Offset = "0x1F75B50", VA = "0x181F77150")]
	public void KNIODBNLABE(Exception JCOJOLLOCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6C5C670", Offset = "0x6C5B070", VA = "0x186C5C670")]
	public void EFALNILAKLE(OAKECHMKIBH BBDGOIMNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE190", Offset = "0x2AECB90", VA = "0x182AEE190")]
	public void EFALNILAKLE<T>(T OKHFPGFAECB, NJPGJODCAPA<T> BBDGOIMNDJI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE330", Offset = "0x2AECD30", VA = "0x182AEE330")]
	public void LHPAJEFICIG<T>([In] T OKHFPGFAECB, BLKLKKHGEJI<T> BBDGOIMNDJI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDFF0", Offset = "0x2AEC9F0", VA = "0x182AEDFF0")]
	public void EFALNILAKLE<T>([In] T OKHFPGFAECB, BLKLKKHGEJI<T> BBDGOIMNDJI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C5C7C0", Offset = "0x6C5B1C0", VA = "0x186C5C7C0")]
	public bool FKCBLLHCBJP(bool FLLLJDPKPMB, string BBDGOIMNDJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct ONOAOHKIBFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string ADJCIFCGLHC;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
	public ONOAOHKIBFG(string IPHMAHBENGI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
	public static string DBMBPMAANBF([In] ONOAOHKIBFG NKCEKILMAAM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xBB9300", Offset = "0xBB7D00", VA = "0x180BB9300")]
	public static ONOAOHKIBFG DBMBPMAANBF(string CGCLEIBHLHF)
	{
		return default(ONOAOHKIBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C66F90", Offset = "0x6C65990", VA = "0x186C66F90")]
	public string IHBEDFNBLPK(string FLBMGAIEBLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C66FE0", Offset = "0x6C659E0", VA = "0x186C66FE0")]
	public string IIHMBKGDDDG(object MEBOLNMFNIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct AJBBHDJGBPP : IEquatable<AJBBHDJGBPP>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "4")]
	public bool Equals(AJBBHDJGBPP CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C5C220", Offset = "0x6C5AC20", VA = "0x186C5C220", Slot = "0")]
	public override bool Equals(object CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C5C270", Offset = "0x6C5AC70", VA = "0x186C5C270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6C5C280", Offset = "0x6C5AC80", VA = "0x186C5C280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[EMMEDCCEFKJ("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct CPOGLEEFNCN<T> : IEquatable<CPOGLEEFNCN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T ADJCIFCGLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool NNLOBEDHHDP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool APAMPFJOBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x57AB450", Offset = "0x57A9E50", VA = "0x1857AB450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x57ABBC0", Offset = "0x57AA5C0", VA = "0x1857ABBC0")]
	public CPOGLEEFNCN([In] T IPHMAHBENGI, bool HLPJKLDGCHM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x57AB1A0", Offset = "0x57A9BA0", VA = "0x1857AB1A0")]
	public static bool JGJOKBKMGBC([In] CPOGLEEFNCN<T> OMCEEKENOBB, [In] CPOGLEEFNCN<T> MOBHGIAPGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x49BDFF0", Offset = "0x49BC9F0", VA = "0x1849BDFF0", Slot = "4")]
	public bool Equals(CPOGLEEFNCN<T> CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x57AA520", Offset = "0x57A8F20", VA = "0x1857AA520", Slot = "0")]
	public override bool Equals(object CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x57AAC30", Offset = "0x57A9630", VA = "0x1857AAC30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x57AB900", Offset = "0x57AA300", VA = "0x1857AB900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class CPMJBOMCHCN
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2B60740", Offset = "0x2B5F140", VA = "0x182B60740")]
	public static CPOGLEEFNCN<T> CAFGOKKKECE<T>([In] T IPHMAHBENGI) where T : notnull
	{
		return default(CPOGLEEFNCN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2B605A0", Offset = "0x2B5EFA0", VA = "0x182B605A0")]
	public static CPOGLEEFNCN<T?> AEPJBFFHJEN<T>()
	{
		return default(CPOGLEEFNCN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2B607A0", Offset = "0x2B5F1A0", VA = "0x182B607A0")]
	public static bool PPNALPBHAAA<T>([In] this CPOGLEEFNCN<T> PLKFEMJEALE, [Out][NotNullWhen(true)] T IPHMAHBENGI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2B605E0", Offset = "0x2B5EFE0", VA = "0x182B605E0")]
	public static T? BOPLDALDMMK<T>([In] this CPOGLEEFNCN<T> PLKFEMJEALE, T? FABNMHPKJIP)
	{
		return (T?)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct PHAMLIOLJCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr PIDMAPOKMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr JKBAOFOIJNP;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr APKHMCDJHGM;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr NFDOHPIAMOI;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly PHAMLIOLJCC CKLKOBNMKJP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool EMCJBNDMBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6C67180", Offset = "0x6C65B80", VA = "0x186C67180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xCEC2C0", Offset = "0xCEACC0", VA = "0x180CEC2C0")]
	public PHAMLIOLJCC(IntPtr AKFOKHNNANA, IntPtr PFJCCGGMHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void KMLIJMPPLHH(string DDDMPLCOGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void NKMNCCBOIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6C67250", Offset = "0x6C65C50", VA = "0x186C67250")]
	private static PHAMLIOLJCC NJBGFCCIDPD()
	{
		return default(PHAMLIOLJCC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct KCJIEMAIJMN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr LNFGEKPDAAH;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
	private KCJIEMAIJMN(IntPtr PFJCCGGMHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6C64250", Offset = "0x6C62C50", VA = "0x186C64250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6C64270", Offset = "0x6C62C70", VA = "0x186C64270")]
	public static KCJIEMAIJMN OOAFHJGKFEK(string DDDMPLCOGIM)
	{
		return default(KCJIEMAIJMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x213C500", Offset = "0x213AF00", VA = "0x18213C500")]
	public static KCJIEMAIJMN OOAFHJGKFEK([In] PHAMLIOLJCC DFACKABLGEL, string DDDMPLCOGIM)
	{
		return default(KCJIEMAIJMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x213CA30", Offset = "0x213B430", VA = "0x18213CA30")]
	public static KCJIEMAIJMN OOAFHJGKFEK([In] PHAMLIOLJCC DFACKABLGEL, Func<string> DDDMPLCOGIM)
	{
		return default(KCJIEMAIJMN);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class DGENNMDGAPK
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate bool PFPKGGJMCGM<in TInput, TResult>(TInput AHBBCFFJCCJ, [Out] TResult NLAECIHBKHE);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class OPNCBBNACJK : FJAMIMOJDEL
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class LCHHBGBOHJC : PKECDLGKLKP, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly LCHHBGBOHJC GHBFIIGNNDE;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool JNBOLGGGPMK
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x6C647D0", Offset = "0x6C631D0", VA = "0x186C647D0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6C64680", Offset = "0x6C63080", VA = "0x186C64680", Slot = "6")]
			public void OnCompleted(Action LHLGPOKEGFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			public void PBCJEGKBFPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public LCHHBGBOHJC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly OPNCBBNACJK GHBFIIGNNDE;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		private OPNCBBNACJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6C670C0", Offset = "0x6C65AC0", VA = "0x186C670C0", Slot = "4")]
		public PKECDLGKLKP CCPNIIDMBMI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private sealed class GGCPKMAMIMG : FJAMIMOJDEL
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private sealed class PICFDHNMPOO : PKECDLGKLKP, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly PICFDHNMPOO GHBFIIGNNDE;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool JNBOLGGGPMK
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x6C67470", Offset = "0x6C65E70", VA = "0x186C67470", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6C67420", Offset = "0x6C65E20", VA = "0x186C67420", Slot = "6")]
			public void OnCompleted(Action LHLGPOKEGFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			public void PBCJEGKBFPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public PICFDHNMPOO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly GGCPKMAMIMG GHBFIIGNNDE;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		private GGCPKMAMIMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6C62490", Offset = "0x6C60E90", VA = "0x186C62490", Slot = "4")]
		public PKECDLGKLKP CCPNIIDMBMI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class CPDBGJLMNPE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public CPDBGJLMNPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4906920", Offset = "0x4905320", VA = "0x184906920")]
		internal void DAGEKNENHDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class MLNEDBCKKFC<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public MLNEDBCKKFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3EE3BA0", Offset = "0x3EE25A0", VA = "0x183EE3BA0")]
		internal void DAMOBNIHPPB(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct BNOOPEMAFOP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D1D0", Offset = "0x6C5BBD0", VA = "0x186C5D1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct HFCFFCIKCGM : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6C629B0", Offset = "0x6C613B0", VA = "0x186C629B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct EMJGPFCFDAB<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3A482C0", Offset = "0x3A46CC0", VA = "0x183A482C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3A48430", Offset = "0x3A46E30", VA = "0x183A48430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct NDPDJDAGMCD<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4794BA0", Offset = "0x47935A0", VA = "0x184794BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x47953F0", Offset = "0x4793DF0", VA = "0x1847953F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct MEGAIIFPFMC : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6C648A0", Offset = "0x6C632A0", VA = "0x186C648A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6C64AA0", Offset = "0x6C634A0", VA = "0x186C64AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class OJKPPLCCJCJ<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public OJKPPLCCJCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4906920", Offset = "0x4905320", VA = "0x184906920")]
		internal void BGBPINHDEJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4906980", Offset = "0x4905380", VA = "0x184906980")]
		internal void LPGNIKFDKCL(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct LDAHPIIJKKF<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public PFPKGGJMCGM<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x44796F0", Offset = "0x44780F0", VA = "0x1844796F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4479E00", Offset = "0x4478800", VA = "0x184479E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct EMHPJIHNFEN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6C616C0", Offset = "0x6C600C0", VA = "0x186C616C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6C61EC0", Offset = "0x6C608C0", VA = "0x186C61EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct IJDPPKBPPHG : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6C63C30", Offset = "0x6C62630", VA = "0x186C63C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6C64180", Offset = "0x6C62B80", VA = "0x186C64180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct MPKHBAPOGBC<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4745960", Offset = "0x4744360", VA = "0x184745960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3FC5860", Offset = "0x3FC4260", VA = "0x183FC5860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct HGLHOAKLJFE<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D8D0", Offset = "0x3F5C2D0", VA = "0x183F5D8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3751550", Offset = "0x374FF50", VA = "0x183751550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct BJMKANFAPAH<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x50EE440", Offset = "0x50ECE40", VA = "0x1850EE440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x50EEB50", Offset = "0x50ED550", VA = "0x1850EEB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct HHMGEFFHIAK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6C63500", Offset = "0x6C61F00", VA = "0x186C63500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6C636E0", Offset = "0x6C620E0", VA = "0x186C636E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct MHFEKLKKAKK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6C65310", Offset = "0x6C63D10", VA = "0x186C65310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6C65670", Offset = "0x6C64070", VA = "0x186C65670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct HCJOEBCNLAJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6C62660", Offset = "0x6C61060", VA = "0x186C62660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6C62950", Offset = "0x6C61350", VA = "0x186C62950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class IHCHLAOMHNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public IHCHLAOMHNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6C63B90", Offset = "0x6C62590", VA = "0x186C63B90")]
		internal Task BIMBLBPNNHK(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct NFAAPDJFMLC : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6C65F20", Offset = "0x6C64920", VA = "0x186C65F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6C66180", Offset = "0x6C64B80", VA = "0x186C66180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct NEGDIOMGHGJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6C65CE0", Offset = "0x6C646E0", VA = "0x186C65CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6C65EC0", Offset = "0x6C648C0", VA = "0x186C65EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct ANKKIIOLCHG : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6C5C2B0", Offset = "0x6C5ACB0", VA = "0x186C5C2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6C5C610", Offset = "0x6C5B010", VA = "0x186C5C610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct HKCCKHELDBI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6C63740", Offset = "0x6C62140", VA = "0x186C63740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6C63A30", Offset = "0x6C62430", VA = "0x186C63A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class JLONGNNIHGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public JLONGNNIHGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6C641E0", Offset = "0x6C62BE0", VA = "0x186C641E0")]
		internal Task AMMIOKPGCOP(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct GDAFNKJJKCH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6C61FF0", Offset = "0x6C609F0", VA = "0x186C61FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6C62250", Offset = "0x6C60C50", VA = "0x186C62250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct GDDHADFLMDK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6C622B0", Offset = "0x6C60CB0", VA = "0x186C622B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6C62430", Offset = "0x6C60E30", VA = "0x186C62430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct APGKDPODCGA<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x41A5E60", Offset = "0x41A4860", VA = "0x1841A5E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x41A60C0", Offset = "0x41A4AC0", VA = "0x1841A60C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct EHALMAHECFK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6C61260", Offset = "0x6C5FC60", VA = "0x186C61260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6C61660", Offset = "0x6C60060", VA = "0x186C61660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? KGMOAMBCIIB;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<AJBBHDJGBPP> ICBBEIEHBKE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static Task NMIDPFIOJFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6C5EFF0", Offset = "0x6C5D9F0", VA = "0x186C5EFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6C5FF60", Offset = "0x6C5E960", VA = "0x186C5FF60")]
	public static bool JKOHGHLEGGD(this Task DJIALEEMCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E590", Offset = "0x2B8CF90", VA = "0x182B8E590")]
	public static Task<T> BDPPABMMFOE<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F650", Offset = "0x6C5E050", VA = "0x186C5F650")]
	public static Task GCOIIGAHIHL(this Task DJIALEEMCOO, CancellationToken OEELDHBFFAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2B90CB0", Offset = "0x2B8F6B0", VA = "0x182B90CB0")]
	public static Task<TResult> GCOIIGAHIHL<TResult>(this Task<TResult> DJIALEEMCOO, CancellationToken OEELDHBFFAF) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2B91F50", Offset = "0x2B90950", VA = "0x182B91F50")]
	public static TaskCompletionSource<TResult> GCOIIGAHIHL<TResult>(this TaskCompletionSource<TResult> FEMNMDPKHGE, CancellationToken OEELDHBFFAF) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F940", Offset = "0x6C5E340", VA = "0x186C5F940")]
	public static IDisposable? HPPPMAHEDMF(CancellationToken MHONBPICPNO, CancellationToken OACBIKMMKLI, [Out] CancellationToken FAPEIDHBIIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F3A0", Offset = "0x6C5DDA0", VA = "0x186C5F3A0")]
	[AsyncStateMachine(typeof(BNOOPEMAFOP))]
	public static void ELOFLLGLPPG(this Task NNEFLDDEJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6C5EF40", Offset = "0x6C5D940", VA = "0x186C5EF40")]
	[AsyncStateMachine(typeof(HFCFFCIKCGM))]
	public static void CFIDKLCGMGK(this Task NNEFLDDEJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E4C0", Offset = "0x2B8CEC0", VA = "0x182B8E4C0")]
	[AsyncStateMachine(typeof(EMJGPFCFDAB<>))]
	public static Task ABCAIFIEODB<TException>(this Task NNEFLDDEJJK) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E710", Offset = "0x2B8D110", VA = "0x182B8E710")]
	[AsyncStateMachine(typeof(NDPDJDAGMCD<>))]
	public static Task<T> DLNLMPPLFMC<T>(this Task<T> NKCEKILMAAM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6C60480", Offset = "0x6C5EE80", VA = "0x186C60480")]
	[AsyncStateMachine(typeof(MEGAIIFPFMC))]
	public static Task<TaskStatus> OKLBHHOGGPN(this Task NKCEKILMAAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2B8EAD0", Offset = "0x2B8D4D0", VA = "0x182B8EAD0")]
	public static (Task<T?>?, Action<T?>?) EEAGJOLMLHH<T>([Optional] CancellationToken LOIOCMLGMKH)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2B929D0", Offset = "0x2B913D0", VA = "0x182B929D0")]
	[AsyncStateMachine(typeof(LDAHPIIJKKF<, >))]
	public static Task<List<TResult>> KBAOOMNDMGA<TResult, TInput>(this Task<List<TInput>> DJIALEEMCOO, PFPKGGJMCGM<TInput, TResult> LHMDELGJAOG) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6C60190", Offset = "0x6C5EB90", VA = "0x186C60190")]
	[AsyncStateMachine(typeof(EMHPJIHNFEN))]
	public static Task MIEPJGMNEHF(Task NNEFLDDEJJK, CancellationToken BENMLFLNPKG, Func<CancellationToken, Task> NLMJMIHHHLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6C60570", Offset = "0x6C5EF70", VA = "0x186C60570")]
	[AsyncStateMachine(typeof(IJDPPKBPPHG))]
	public static Task OMKEDFNDLPG(Func<CancellationToken, Task> PELOHCJGJCF, TimeSpan BHOCMEPADDF, [Optional] CancellationToken BENMLFLNPKG, [Optional] Action<OperationCanceledException>? AILOJEECPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2B92DA0", Offset = "0x2B917A0", VA = "0x182B92DA0")]
	[AsyncStateMachine(typeof(MPKHBAPOGBC<>))]
	public static Task<T> OMKEDFNDLPG<T>(Func<CancellationToken, Task<T>> PELOHCJGJCF, TimeSpan BHOCMEPADDF, [Optional] CancellationToken BENMLFLNPKG, [Optional] Func<OperationCanceledException, T>? AILOJEECPAM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E9E0", Offset = "0x2B8D3E0", VA = "0x182B8E9E0")]
	[AsyncStateMachine(typeof(HGLHOAKLJFE<>))]
	public static Task<IEnumerable<Task<T>>> ECFJCKHAICH<T>(IEnumerable<Task<T>> AOFEDKKADCN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B92AE0", Offset = "0x2B914E0", VA = "0x182B92AE0")]
	[AsyncStateMachine(typeof(BJMKANFAPAH<, , , >))]
	public static Task<(T1, T2, T3, T4)> NCPMGEDDIBF<T1, T2, T3, T4>(Task<T1> CCALJEFGIHE, Task<T2> BNJEJJAIDIM, Task<T3> LICHPNOBPCB, Task<T4> FDLHAHMGCDH) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C5FF90", Offset = "0x6C5E990", VA = "0x186C5FF90")]
	[AsyncStateMachine(typeof(HHMGEFFHIAK))]
	public static Task JMJEDGAPJOJ(Func<bool> FLLLJDPKPMB, [Optional] CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6C60080", Offset = "0x6C5EA80", VA = "0x186C60080")]
	[AsyncStateMachine(typeof(MHFEKLKKAKK))]
	public static Task JMJEDGAPJOJ(Func<bool> FLLLJDPKPMB, TimeSpan EGNMLKOENPB, [Optional] CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6C5FB70", Offset = "0x6C5E570", VA = "0x186C5FB70")]
	[AsyncStateMachine(typeof(HCJOEBCNLAJ))]
	public static Task JEMHJFOCMBC(Func<bool> FLLLJDPKPMB, TimeSpan BHOCMEPADDF, [Optional] CancellationToken LOIOCMLGMKH, [Optional] Action<OperationCanceledException>? AILOJEECPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6C5FCA0", Offset = "0x6C5E6A0", VA = "0x186C5FCA0")]
	[AsyncStateMachine(typeof(NFAAPDJFMLC))]
	public static Task JEMHJFOCMBC(Func<bool> FLLLJDPKPMB, TimeSpan BHOCMEPADDF, TimeSpan EGNMLKOENPB, [Optional] CancellationToken LOIOCMLGMKH, [Optional] Action<OperationCanceledException>? AILOJEECPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F560", Offset = "0x6C5DF60", VA = "0x186C5F560")]
	[AsyncStateMachine(typeof(NEGDIOMGHGJ))]
	public static Task FNIOIBDLIOK(Func<bool> FLLLJDPKPMB, [Optional] CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F450", Offset = "0x6C5DE50", VA = "0x186C5F450")]
	[AsyncStateMachine(typeof(ANKKIIOLCHG))]
	public static Task FNIOIBDLIOK(Func<bool> FLLLJDPKPMB, TimeSpan EGNMLKOENPB, [Optional] CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F270", Offset = "0x6C5DC70", VA = "0x186C5F270")]
	[AsyncStateMachine(typeof(HKCCKHELDBI))]
	public static Task EDPDIHILCJN(Func<bool> FLLLJDPKPMB, TimeSpan BHOCMEPADDF, [Optional] CancellationToken LOIOCMLGMKH, [Optional] Action<OperationCanceledException>? AILOJEECPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F130", Offset = "0x6C5DB30", VA = "0x186C5F130")]
	[AsyncStateMachine(typeof(GDAFNKJJKCH))]
	public static Task EDPDIHILCJN(Func<bool> FLLLJDPKPMB, TimeSpan BHOCMEPADDF, TimeSpan EGNMLKOENPB, [Optional] CancellationToken LOIOCMLGMKH, [Optional] Action<OperationCanceledException>? AILOJEECPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6C5FA80", Offset = "0x6C5E480", VA = "0x186C5FA80")]
	[Obsolete]
	[AsyncStateMachine(typeof(GDDHADFLMDK))]
	public static Task IHJCLLCPDCD(this Task DJIALEEMCOO, Action KOFJMBOPAMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2B928E0", Offset = "0x2B912E0", VA = "0x182B928E0")]
	[AsyncStateMachine(typeof(APGKDPODCGA<>))]
	[Obsolete]
	public static Task IHJCLLCPDCD<T>(this Task<T> DJIALEEMCOO, Action<T> KOFJMBOPAMO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6C603D0", Offset = "0x6C5EDD0", VA = "0x186C603D0")]
	private static void NGAOOKFIKJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C5EBE0", Offset = "0x6C5D5E0", VA = "0x186C5EBE0")]
	public static bool CCKBCLAOPCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C5FDE0", Offset = "0x6C5E7E0", VA = "0x186C5FDE0")]
	private static void JJMAKELGPOO(SynchronizationContext IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C602C0", Offset = "0x6C5ECC0", VA = "0x186C602C0")]
	private static void NDHHOHFHFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F060", Offset = "0x6C5DA60", VA = "0x186C5F060")]
	public static void CLCLJEDGHOM([Optional] string? BBDGOIMNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6C606A0", Offset = "0x6C5F0A0", VA = "0x186C606A0")]
	public static void PHMNBNGBLPI([Optional] string? BBDGOIMNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F8A0", Offset = "0x6C5E2A0", VA = "0x186C5F8A0")]
	public static FJAMIMOJDEL HENIFLOJGEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F8F0", Offset = "0x6C5E2F0", VA = "0x186C5F8F0")]
	public static FJAMIMOJDEL HNHAIGIGNPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6C5EB10", Offset = "0x6C5D510", VA = "0x186C5EB10")]
	[AsyncStateMachine(typeof(EHALMAHECFK))]
	public static Task BCNJCIABLLP(Func<Task> EDFBCBDPOLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class DEKINLCKNLM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
	public DEKINLCKNLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class GLJCDKBPHLG : DHHDDNBKGKJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly DHHDDNBKGKJ GHBFIIGNNDE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTime OFCPPDMEEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6C625B0", Offset = "0x6C60FB0", VA = "0x186C625B0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DateTimeOffset PFOGIMGJHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6C62550", Offset = "0x6C60F50", VA = "0x186C62550", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public GLJCDKBPHLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface DHHDDNBKGKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTime OFCPPDMEEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DateTimeOffset PFOGIMGJHPH
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class MEJABICJLPD
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long PBJBMNLPKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6C65020", Offset = "0x6C63A20", VA = "0x186C65020")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static long MALOBABGLCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6C64BA0", Offset = "0x6C635A0", VA = "0x186C64BA0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double HFOBHJJNLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6C64EB0", Offset = "0x6C638B0", VA = "0x186C64EB0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double BHNGFECELGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6C64CA0", Offset = "0x6C636A0", VA = "0x186C64CA0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double JOFNOLGCPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6C64CF0", Offset = "0x6C636F0", VA = "0x186C64CF0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static double FIMOPDAEGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6C64BF0", Offset = "0x6C635F0", VA = "0x186C64BF0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6C64F00", Offset = "0x6C63900", VA = "0x186C64F00")]
	public static double NNCKOFAOGAO(long MNDILLAFJKI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6C64D40", Offset = "0x6C63740", VA = "0x186C64D40")]
	public static double MJOPNMHEBEH(long MNDILLAFJKI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6C64F90", Offset = "0x6C63990", VA = "0x186C64F90")]
	public static double ONFNGIMBKEA(double LOCOKKOAIGD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6C64B10", Offset = "0x6C63510", VA = "0x186C64B10")]
	public static long AAPAOMLAMDK(long PEDHHHMMIGP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6C64EA0", Offset = "0x6C638A0", VA = "0x186C64EA0")]
	public static long NFACHNGPBBI(long LKNPGNPGJGG, long PADPOIGGIOH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6C64DD0", Offset = "0x6C637D0", VA = "0x186C64DD0")]
	public static double MKHGALDBGIG(long LKNPGNPGJGG, long PADPOIGGIOH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6C64C40", Offset = "0x6C63640", VA = "0x186C64C40")]
	public static double HJGHPPPDKJF(long LKNPGNPGJGG, long PADPOIGGIOH)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class OMEAIOOBGJA : KNNKIAFDEON, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static readonly TimeSpan JFAJOFOMOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly System.Timers.Timer MBHLFFACPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private TimeSpan BHOCMEPADDF;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public TimeSpan LJCDGOOBDPG
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6C668B0", Offset = "0x6C652B0", VA = "0x186C668B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Action? LMOKEKMAPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8855F0", Offset = "0x883FF0", VA = "0x1808855F0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6C66F30", Offset = "0x6C65930", VA = "0x186C66F30")]
	[Preserve]
	public OMEAIOOBGJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6C66CE0", Offset = "0x6C656E0", VA = "0x186C66CE0")]
	public OMEAIOOBGJA(TimeSpan BHOCMEPADDF, [Optional] Action? GJHONCLMMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6C66BE0", Offset = "0x6C655E0", VA = "0x186C66BE0", Slot = "7")]
	public void MIKAPCLAFCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6C66AB0", Offset = "0x6C654B0", VA = "0x186C66AB0", Slot = "8")]
	public void FLPCLHEHCLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C66BB0", Offset = "0x6C655B0", VA = "0x186C66BB0", Slot = "9")]
	public void MFPKDJMJBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xB59500", Offset = "0xB57F00", VA = "0x180B59500")]
	private void PFPHAHGMDNI(object DICHKFJDHIG, ElapsedEventArgs IHNHJMOKJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C66B20", Offset = "0x6C65520", VA = "0x186C66B20")]
	private static void HCKMJNCFHFL(TimeSpan BOFALOLJJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6C66A10", Offset = "0x6C65410", VA = "0x186C66A10", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class EMMEDCCEFKJ : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly string? GONPCACAEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly string KLFNGIJMKGI;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x979710", Offset = "0x978110", VA = "0x180979710")]
	public EMMEDCCEFKJ(string MAAJPCIONKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x41A93E0", Offset = "0x41A7DE0", VA = "0x1841A93E0")]
	public EMMEDCCEFKJ(string EEIDNNLIIHD, string MAAJPCIONKG)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct CPPMLHJKLEH : IEquatable<CPPMLHJKLEH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public uint IEMLKECFLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int HDOJGJMEEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float JJODLHEDANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public ushort NKAEMNCIAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public ushort PJHBGABNIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public short OKICEPANPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public short KEOIDNNEPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public char EGHEJMMOJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public char IAOJHLIOOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte JJCAOIMKHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte MBOIKCBDIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public byte KJEDNFGBAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte MHJAAMCPILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool FIHAHKPGOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool EMDHCOCPGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public bool LDLJCMPLMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool DBHCOOKIFFO;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1605D90", Offset = "0x1604790", VA = "0x181605D90")]
	public static CPPMLHJKLEH HBINEDKBIEM(uint BPCEIJNDIJM)
	{
		return default(CPPMLHJKLEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x1605D90", Offset = "0x1604790", VA = "0x181605D90")]
	public static CPPMLHJKLEH NMEEMMIEBHE(int BPKFGOPAJGB)
	{
		return default(CPPMLHJKLEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D330", Offset = "0x6C5BD30", VA = "0x186C5D330")]
	public static CPPMLHJKLEH AHAPAEMMKLM(float NMIBGNBDDNG)
	{
		return default(CPPMLHJKLEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D3C0", Offset = "0x6C5BDC0", VA = "0x186C5D3C0")]
	public static CPPMLHJKLEH IANHDLEHLPO(byte IKLANBIIFJI, byte BPOLMBBBMBK, byte JNEEEEIFGLG, byte EJGNHKAAPBP)
	{
		return default(CPPMLHJKLEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D3C0", Offset = "0x6C5BDC0", VA = "0x186C5D3C0")]
	public static CPPMLHJKLEH OMNNKHMEIGA(bool EBJADFHMBKM, bool ODKINKMFPKJ, bool DPMNHHLLHCD, bool JEPNELHBFID)
	{
		return default(CPPMLHJKLEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D3C0", Offset = "0x6C5BDC0", VA = "0x186C5D3C0")]
	public static CPPMLHJKLEH HPIGFONNJEI(byte JCLNOEDGIJH, byte NNGAEHIGLDA, byte OKGIBDLINGM, byte FNIGIFENDAH)
	{
		return default(CPPMLHJKLEH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1DF2590", Offset = "0x1DF0F90", VA = "0x181DF2590")]
	public static bool JGJOKBKMGBC(CPPMLHJKLEH MFLKJAHENBP, CPPMLHJKLEH PLHCHKLJLJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xC41910", Offset = "0xC40310", VA = "0x180C41910", Slot = "4")]
	public bool Equals(CPPMLHJKLEH CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D340", Offset = "0x6C5BD40", VA = "0x186C5D340", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0xCF7900", Offset = "0xCF6300", VA = "0x180CF7900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D3E0", Offset = "0x6C5BDE0", VA = "0x186C5D3E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct NBKPBIGPLNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public ulong FLENJPFKAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public long AMFHNAPCEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public double LBINICECDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint JGKOOHMGFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint AGCKGCMPCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public int EDCFGHFBLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int LMEJMPOIFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float IDGMCPHNLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float ICHHNMLKEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort NKAEMNCIAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort PJHBGABNIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public ushort NBOFCHFNIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort HHDMNDPNEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short OKICEPANPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short KEOIDNNEPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public short DPLPMGIKBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short KKPKENJKNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char EGHEJMMOJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char IAOJHLIOOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public char CMEDHMNOFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char PBNADMJAHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte JJCAOIMKHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte MBOIKCBDIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte KJEDNFGBAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte MHJAAMCPILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte NMHBNEICMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte GCOBELNGDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte AJDLMIIPOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte HBJBOBLLCGM;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670")]
	public static NBKPBIGPLNA OOAFHJGKFEK(long ENBGNPCDABF)
	{
		return default(NBKPBIGPLNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6C65C90", Offset = "0x6C64690", VA = "0x186C65C90")]
	public static NBKPBIGPLNA OOAFHJGKFEK(byte IKLANBIIFJI, byte BPOLMBBBMBK, byte JNEEEEIFGLG, byte EJGNHKAAPBP, byte LOMKNAANHBI, byte HFGPOPHIMMC, byte LMIICLHLPMG, byte IOKGGEMMMAM)
	{
		return default(NBKPBIGPLNA);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct KOGLHKNPDAJ : IEquatable<KOGLHKNPDAJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte LEGGJCJAKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool IECHBOLKCLA;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x271A9A0", Offset = "0x27193A0", VA = "0x18271A9A0")]
	public static KOGLHKNPDAJ IANHDLEHLPO(byte LMAHMIDJIMK)
	{
		return default(KOGLHKNPDAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x271A9A0", Offset = "0x27193A0", VA = "0x18271A9A0")]
	public static KOGLHKNPDAJ OMNNKHMEIGA(bool FLPKEAALNHG)
	{
		return default(KOGLHKNPDAJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6C64410", Offset = "0x6C62E10", VA = "0x186C64410")]
	public static bool JGJOKBKMGBC(KOGLHKNPDAJ MFLKJAHENBP, KOGLHKNPDAJ PLHCHKLJLJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7230", Offset = "0x5DF5C30", VA = "0x185DF7230", Slot = "4")]
	public bool Equals(KOGLHKNPDAJ CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6C64370", Offset = "0x6C62D70", VA = "0x186C64370", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6C64400", Offset = "0x6C62E00", VA = "0x186C64400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6C64420", Offset = "0x6C62E20", VA = "0x186C64420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class DDJBNBKBGDA<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public readonly T KGDCLDAHMJN;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5A7AC90", Offset = "0x5A79690", VA = "0x185A7AC90")]
	public DDJBNBKBGDA(T JDLKOHFKCOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class FPEFABCLBOE
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2D5C9E0", Offset = "0x2D5B3E0", VA = "0x182D5C9E0")]
	public static IEnumerable<T> LGOHKIGCKIK<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670")]
	public static T[] NGLIEPFOIIK<T>(params T[] APEPJKNDCLO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670")]
	public static IEnumerable<T> KAABCEBOMOD<T>(params T[] APEPJKNDCLO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0970", Offset = "0x2BCF370", VA = "0x182BD0970")]
	public static HashSet<T> PMPBHDDPAMF<T>(params T[] APEPJKNDCLO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2D5C8F0", Offset = "0x2D5B2F0", VA = "0x182D5C8F0")]
	public static KeyValuePair<TKey, TValue> ACGOCPDADAK<TKey, TValue>([In] TKey COMNIKKFEEB, [In] TValue IPHMAHBENGI) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0970", Offset = "0x2BCF370", VA = "0x182BD0970")]
	public static List<T> KKNEIBHPHOA<T>(IEnumerable<T> CCIELLHDDHE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[AttributeUsage(AttributeTargets.All)]
public sealed class PHGLEGCCOGA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public readonly string PHDOKHJAIJI;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x8AE5A0", Offset = "0x8ACFA0", VA = "0x1808AE5A0")]
	public PHGLEGCCOGA(string HPOPBHJPBJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object BLKLKKHGEJI<T>([In] T BBLLNFBCDFH);
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate object NJPGJODCAPA<T>(T BBLLNFBCDFH);
[Cpp2IlInjected.Token(Token = "0x200005A")]
[LHNCMCFHJIK]
public delegate string ICMPOIKKJCA(string OOCPPLNIOAJ, string? PFOPPCFDLPJ, bool MNMJGJLNNPJ);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[LHNCMCFHJIK]
public delegate void DMBPEBGKOAJ(string BBDGOIMNDJI);
[Cpp2IlInjected.Token(Token = "0x200005C")]
[LHNCMCFHJIK]
public delegate void CCECNNOLGKK(Exception JCOJOLLOCIG);
[Cpp2IlInjected.Token(Token = "0x200005D")]
public delegate object OAKECHMKIBH();
[Cpp2IlInjected.Token(Token = "0x200005E")]
[LHNCMCFHJIK]
public delegate bool CHKHGPJKHGH();
[Cpp2IlInjected.Token(Token = "0x200005F")]
[LHNCMCFHJIK]
public delegate string JLKGEALBBLP(object FHFDEAHMMBI);
[Cpp2IlInjected.Token(Token = "0x2000060")]
[AttributeUsage(AttributeTargets.Enum)]
public class COCPEDNMDPN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
	public COCPEDNMDPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class OFHMJBEEEPD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct DHIAFKAGODL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6C607E0", Offset = "0x6C5F1E0", VA = "0x186C607E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6C610D0", Offset = "0x6C5FAD0", VA = "0x186C610D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly TimerCallback DINLCHNBKFP;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Action<object?> IMABLKHPHLE;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6C664B0", Offset = "0x6C64EB0", VA = "0x186C664B0")]
	public static Task<bool> LLEEECHGCDO(int CHPINFCCJBK, [Optional] CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6C662F0", Offset = "0x6C64CF0", VA = "0x186C662F0")]
	[AsyncStateMachine(typeof(DHIAFKAGODL))]
	private static Task<bool> JLNDGOGPFDF(int CHPINFCCJBK, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6C66260", Offset = "0x6C64C60", VA = "0x186C66260")]
	private static void BFPLNDHCCBL(object? PFFGBBPKGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6C66420", Offset = "0x6C64E20", VA = "0x186C66420")]
	private static void LDOBHDBEIJA(object? PFFGBBPKGJN)
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
