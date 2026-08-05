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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6999F60", Offset = "0x6998960", VA = "0x186999F60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x877600", Offset = "0x876000", VA = "0x180877600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HIJAAECEMKN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6991F70", Offset = "0x6990970", VA = "0x186991F70")]
	public static string CIIFJGJOKBG(this Encoding CIEOGEBIMOC, [In] ReadOnlySequence<byte> KKELJOOMKNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B3E820", Offset = "0x2B3D220", VA = "0x182B3E820")]
	private static void OGOONFPLHMH<T>(this ReadOnlySequence<T> EEKOBDBJGKD, [Out] ReadOnlySpan<T> PDMCPOPCELJ, [Out] SequencePosition OFDLMEADNHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class AIONDLNGFIN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6990310", Offset = "0x698ED10", VA = "0x186990310")]
	public AIONDLNGFIN(bool EEBLEJJLKOE, string NKMIIFNFAPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BHNPCJDFPAP
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class EPJDMPNKGPG<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate Task<TResult> ILMHDNENGNI(CancellationToken AOLOJHLCMLE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct BIAGHPEJJDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public EPJDMPNKGPG<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public ILMHDNENGNI taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4E1A6F0", Offset = "0x4E190F0", VA = "0x184E1A6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4E1B7C0", Offset = "0x4E1A1C0", VA = "0x184E1B7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource NBIMBFBEBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? ELEBMCDGNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? OHHIFNOMHNF;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x387EEC0", Offset = "0x387D8C0", VA = "0x18387EEC0")]
	[AsyncStateMachine(typeof(EPJDMPNKGPG<>.BIAGHPEJJDP))]
	public Task<TResult> EJKJIIMAGKK(ILMHDNENGNI LEJJCLAGFFG, [Optional] CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x387EE50", Offset = "0x387D850", VA = "0x18387EE50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x387F000", Offset = "0x387DA00", VA = "0x18387F000")]
	public EPJDMPNKGPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class MFJELDNENHB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> GJHPIOKBAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T NHLIMKDHAIB;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C330", Offset = "0x3E9AD30", VA = "0x183E9C330")]
	public MFJELDNENHB([In] T DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x446F850", Offset = "0x446E250", VA = "0x18446F850", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x446FCA0", Offset = "0x446E6A0", VA = "0x18446FCA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x446FE50", Offset = "0x446E850", VA = "0x18446FE50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class JLGPAINBMOB
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2960650", Offset = "0x295F050", VA = "0x182960650")]
	public static MFJELDNENHB<T> KHKANEAPNIK<T>([In] T DBOBEHLEAAE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class OAIOENCKHLG
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6999FE0", Offset = "0x69989E0", VA = "0x186999FE0")]
	public static void GABJEDAICIE(this CancellationTokenSource NBIMBFBEBLN, bool PGNIJDMGEOH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class HBFFGICEBGA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
	public HBFFGICEBGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class HDAIPMIDGLC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
	public HDAIPMIDGLC(string LINEPMAPICF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GIOHFHGBPID
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2B29B20", Offset = "0x2B28520", VA = "0x182B29B20")]
	public static EFNLFAIIHGJ OFKJIGKIFMB<T>()
	{
		return default(EFNLFAIIHGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2B29850", Offset = "0x2B28250", VA = "0x182B29850")]
	public static EFNLFAIIHGJ OACFMADGCFH<T>([CallerMemberName] string CCMEKJGADHN = "") where T : notnull
	{
		return default(EFNLFAIIHGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2B29AA0", Offset = "0x2B284A0", VA = "0x182B29AA0")]
	public static EFNLFAIIHGJ OFKJIGKIFMB<T>(this T MAJFEBAGNLL) where T : notnull
	{
		return default(EFNLFAIIHGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2B296B0", Offset = "0x2B280B0", VA = "0x182B296B0")]
	public static EFNLFAIIHGJ ECNGHEKIFIG<T>(this T MAJFEBAGNLL, [CallerMemberName] string CCMEKJGADHN = "") where T : notnull
	{
		return default(EFNLFAIIHGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2B298F0", Offset = "0x2B282F0", VA = "0x182B298F0")]
	public static EFNLFAIIHGJ OACFMADGCFH<T>(this T BBCPNLGGBMJ, [CallerMemberName] string CCMEKJGADHN = "") where T : notnull
	{
		return default(EFNLFAIIHGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6991A00", Offset = "0x6990400", VA = "0x186991A00")]
	public static EFNLFAIIHGJ OACFMADGCFH(string CBNBAKKLFHM, [CallerMemberName] string CCMEKJGADHN = "")
	{
		return default(EFNLFAIIHGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6991960", Offset = "0x6990360", VA = "0x186991960")]
	public static string HFJDCNPLIMO(this object BBCPNLGGBMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate bool IMBGPGGEHPO();
[Cpp2IlInjected.Token(Token = "0x2000013")]
[HBFFGICEBGA]
public delegate long GCBIPDABCHJ();
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KKIPJPAADCC
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static ELCKJDGKPFK IKAPDKFCOLO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static ELCKJDGKPFK JKKEAMPPEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6996440", Offset = "0x6994E40", VA = "0x186996440")]
		get
		{
			return default(ELCKJDGKPFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IDGPEECGKMK FFNGNHHIOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6995CC0", Offset = "0x69946C0", VA = "0x186995CC0")]
		get
		{
			return default(IDGPEECGKMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static IBIDHJBCHDH LJBFCHAKBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6995D90", Offset = "0x6994790", VA = "0x186995D90")]
		get
		{
			return default(IBIDHJBCHDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool DMEJICCDGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6996040", Offset = "0x6994A40", VA = "0x186996040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6996290", Offset = "0x6994C90", VA = "0x186996290")]
	public static void MGNJHNLLDPO([In] ELCKJDGKPFK FGPIGMCDGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69961C0", Offset = "0x6994BC0", VA = "0x1869961C0")]
	public static void MDBGGDKNGAC(string BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6995BF0", Offset = "0x69945F0", VA = "0x186995BF0")]
	public static void ABOPGEFHDIG(string BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB0D0", Offset = "0x2BB9AD0", VA = "0x182BBB0D0")]
	public static void ABOPGEFHDIG<T>(T PCNJMLOHDMH, CFCKPOMNILG<T> BDCMABOIIFF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6995FA0", Offset = "0x69949A0", VA = "0x186995FA0")]
	public static void JFKOLPDEIBF(Exception JKHACPOPJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6995D10", Offset = "0x6994710", VA = "0x186995D10")]
	public static void EAADIHNODDF(string CCMEKJGADHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69960B0", Offset = "0x6994AB0", VA = "0x1869960B0")]
	public static void KPNONIMPFJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6995F20", Offset = "0x6994920", VA = "0x186995F20")]
	public static string HFJDCNPLIMO(object GKHPLGCJCPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6995EB0", Offset = "0x69948B0", VA = "0x186995EB0")]
	public static long HAKMLMKECDB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6996120", Offset = "0x6994B20", VA = "0x186996120")]
	public static bool LANNDPAIHGO(bool EMAGLACAJHK, string BDCMABOIIFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6995DE0", Offset = "0x69947E0", VA = "0x186995DE0")]
	public static double GFMCMIEGFNK()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct ELCKJDGKPFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly IDGPEECGKMK FFNGNHHIOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly IBIDHJBCHDH LJBFCHAKBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly HGGDEAHCPHL KNCFLEEPHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly GCBIPDABCHJ EHMGMLADOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly FBCBCJEABNJ OOPHNFIBMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly IMBGPGGEHPO EPOGBIJPEMC;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly HGGDEAHCPHL KIDLLHGOOJO;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly GCBIPDABCHJ GPNPFBNDMLH;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly FBCBCJEABNJ HGCPDBENICG;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly IMBGPGGEHPO MGPDOBHIFIJ;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly ELCKJDGKPFK EOPMNGGGOOO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool DJEJGGIOHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6990DD0", Offset = "0x698F7D0", VA = "0x186990DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x69917B0", Offset = "0x69901B0", VA = "0x1869917B0")]
	public ELCKJDGKPFK([In] IDGPEECGKMK DLBMPNGBPKC, [In] IBIDHJBCHDH DGPJEOKIHLD, HGGDEAHCPHL NPGCBKIHPBG, GCBIPDABCHJ HNEMKIAJLPP, FBCBCJEABNJ AAIKDCFIGAL, IMBGPGGEHPO GIFKNLNJCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6991080", Offset = "0x698FA80", VA = "0x186991080")]
	private static string PNJKFIDCCAG(object GKHPLGCJCPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0")]
	private static long CKMGNGDJLFO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
	private static string ELHKBOKEMKM(string OHOJCGMAAGM, string? JJCMLJHKNHF, bool LMKMKAOMGOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60")]
	private static bool JCMCKAAOMFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6990F70", Offset = "0x698F970", VA = "0x186990F70")]
	private static ELCKJDGKPFK LIBKBBEFAIP()
	{
		return default(ELCKJDGKPFK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KCGCGKDHHFH
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EEANKJKKHFA AJMGKPCPAEO();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EEANKJKKHFA : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DLHFIFPBDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ACIGINHEDAH();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FHPHFFGJALG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EBHDDKLMPJG([In] T HENLEJBGFIE);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate void DMAOIEKFBEJ<T>([In] T PCNJMLOHDMH);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct NBHGOLFGKDK<T> : IEquatable<NBHGOLFGKDK<T>>, FHPHFFGJALG<NBHGOLFGKDK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T NHLIMKDHAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int JCLKIAMNLIO;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8940", Offset = "0x1FC7340", VA = "0x181FC8940")]
	public NBHGOLFGKDK([In] T DBOBEHLEAAE, int ILOCEPPJPDO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x44CC010", Offset = "0x44CAA10", VA = "0x1844CC010")]
	public static bool IKJGJDJDJIH([In] NBHGOLFGKDK<T> FKJLOGAHGLJ, [In] NBHGOLFGKDK<T> MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3CCCE10", Offset = "0x3CCB810", VA = "0x183CCCE10", Slot = "4")]
	public bool Equals(NBHGOLFGKDK<T> HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3C24240", Offset = "0x3C22C40", VA = "0x183C24240", Slot = "0")]
	public override bool Equals(object HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x44CBAB0", Offset = "0x44CA4B0", VA = "0x1844CBAB0")]
	public bool EBHDDKLMPJG([In] NBHGOLFGKDK<T> HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x44CBBD0", Offset = "0x44CA5D0", VA = "0x1844CBBD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x44CC770", Offset = "0x44CB170", VA = "0x1844CC770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x44CB410", Offset = "0x44C9E10", VA = "0x1844CB410")]
	public void DNIPHOADCKN([Out] T DBOBEHLEAAE, [Out] int ILOCEPPJPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x44CB140", Offset = "0x44C9B40", VA = "0x1844CB140")]
	public (T, int) DELAFDGHFCE()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x44CC660", Offset = "0x44CB060", VA = "0x1844CC660", Slot = "5")]
	private bool LKBJPPPAFIB([In] NBHGOLFGKDK<T> HENLEJBGFIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class OBMNBALILID
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2A30", Offset = "0x2CA1430", VA = "0x182CA2A30")]
	public static NBHGOLFGKDK<T> KHKANEAPNIK<T>([In] T DBOBEHLEAAE, int ILOCEPPJPDO) where T : notnull
	{
		return default(NBHGOLFGKDK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class PBCGPHOAHGI
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2CD10E0", Offset = "0x2CCFAE0", VA = "0x182CD10E0")]
	public static bool EBHDDKLMPJG<T, U>([In] T BBCPNLGGBMJ, [In] U GKHPLGCJCPF) where T : notnull, FHPHFFGJALG<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public delegate TResult GADOMJJNADE<T, out TResult>([In] T PCNJMLOHDMH);
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GALGDKDHJCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan IPHAAJDIOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? FNILDBNKMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FNEPMCHENFK();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNGCCNBCHGJ();

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PMGKHCNMCBL();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct IDGPEECGKMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly AIMKDAGEABL IHLNGFDPAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly MPODOGBGBGM JJAGAEGPJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly AIMKDAGEABL ODBGBCBPPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly MPODOGBGBGM FOCBAAIOFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly AIMKDAGEABL KAFLHILJNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly MPODOGBGBGM BMMCGJCMNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly OPNDNEFAGCM CLHNFDBHMBO;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly AIMKDAGEABL AJAFEODCIFE;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly MPODOGBGBGM GELEEGGGHLJ;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly AIMKDAGEABL HGFKLGPKJEJ;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly MPODOGBGBGM GEKPKJADJDM;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly AIMKDAGEABL NJCODFNJBLA;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly MPODOGBGBGM IMNMDHGEKFK;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly OPNDNEFAGCM FEGDOOHBIIC;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly IDGPEECGKMK EOPMNGGGOOO;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly AIMKDAGEABL FKHCCAKIPAF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DJEJGGIOHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6992A90", Offset = "0x6991490", VA = "0x186992A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xB19A60", Offset = "0xB18460", VA = "0x180B19A60")]
	public IDGPEECGKMK(AIMKDAGEABL DNMGMKDJNGN, MPODOGBGBGM LLCDBJOMPMO, AIMKDAGEABL KMFPIJJNCEG, MPODOGBGBGM BBHNEJMHMPC, AIMKDAGEABL BFNBONCFBAK, MPODOGBGBGM NGKPMKHHMCP, OPNDNEFAGCM PFDCKFHLJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60")]
	private static bool BDPPGCCEBEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	private static void EMCGMOALHNI(string BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60")]
	private static bool IDPOIKJCKDE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	private static void OOFPAMMABFG(string BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60")]
	private static bool JLNLCBEMCLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	private static void CFAJHJHPDKM(string BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	private static void MGLKNKALPDC(Exception JKHACPOPJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6992D60", Offset = "0x6991760", VA = "0x186992D60")]
	private static IDGPEECGKMK LIBKBBEFAIP()
	{
		return default(IDGPEECGKMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0")]
	private static bool HEIPGOPKDBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6992EA0", Offset = "0x69918A0", VA = "0x186992EA0")]
	public void MDBGGDKNGAC(object BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6992A20", Offset = "0x6991420", VA = "0x186992A20")]
	public void ABOPGEFHDIG(object BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1BE9CB0", Offset = "0x1BE86B0", VA = "0x181BE9CB0")]
	public void JFKOLPDEIBF(Exception JKHACPOPJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6992940", Offset = "0x6991340", VA = "0x186992940")]
	public void ABOPGEFHDIG(BBCGICGBMIO BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2B555C0", Offset = "0x2B53FC0", VA = "0x182B555C0")]
	public void ABOPGEFHDIG<T>(T PCNJMLOHDMH, CFCKPOMNILG<T> BDCMABOIIFF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2B55690", Offset = "0x2B54090", VA = "0x182B55690")]
	public void MDBGGDKNGAC<T>([In] T PCNJMLOHDMH, KEDHHGDNPIO<T> BDCMABOIIFF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2B55420", Offset = "0x2B53E20", VA = "0x182B55420")]
	public void ABOPGEFHDIG<T>([In] T PCNJMLOHDMH, KEDHHGDNPIO<T> BDCMABOIIFF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6992C90", Offset = "0x6991690", VA = "0x186992C90")]
	public bool LANNDPAIHGO(bool EMAGLACAJHK, string BDCMABOIIFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct EFNLFAIIHGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string NHLIMKDHAIB;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920520", VA = "0x180921B20")]
	public EFNLFAIIHGJ(string DBOBEHLEAAE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
	public static string OCHPDIOAFKC([In] EFNLFAIIHGJ BBCPNLGGBMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x97B890", Offset = "0x97A290", VA = "0x18097B890")]
	public static EFNLFAIIHGJ OCHPDIOAFKC(string HENLEJBGFIE)
	{
		return default(EFNLFAIIHGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6990CA0", Offset = "0x698F6A0", VA = "0x186990CA0")]
	public string IHMFNIBBFEG(string OPIOPKFGBCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6990CF0", Offset = "0x698F6F0", VA = "0x186990CF0")]
	public string KHCJAGOMGNG(object NDDJEDCJILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct LMMCANLFCCL : IEquatable<LMMCANLFCCL>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "4")]
	public bool Equals(LMMCANLFCCL HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6998A70", Offset = "0x6997470", VA = "0x186998A70", Slot = "0")]
	public override bool Equals(object HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6998AC0", Offset = "0x69974C0", VA = "0x186998AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6998AD0", Offset = "0x69974D0", VA = "0x186998AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[AFLDEPHJFEH("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct ABMFALHKFKK<T> : IEquatable<ABMFALHKFKK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T NHLIMKDHAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool EFKNIEENEHH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool NAHHMHPMNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3CCDB40", Offset = "0x3CCC540", VA = "0x183CCDB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3CCDF00", Offset = "0x3CCC900", VA = "0x183CCDF00")]
	public ABMFALHKFKK([In] T DBOBEHLEAAE, bool DNDAIPCGHLE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD880", Offset = "0x3CCC280", VA = "0x183CCD880")]
	public static bool IKJGJDJDJIH([In] ABMFALHKFKK<T> FKJLOGAHGLJ, [In] ABMFALHKFKK<T> MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3CCCE10", Offset = "0x3CCB810", VA = "0x183CCCE10", Slot = "4")]
	public bool Equals(ABMFALHKFKK<T> HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD040", Offset = "0x3CCBA40", VA = "0x183CCD040", Slot = "0")]
	public override bool Equals(object HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD490", Offset = "0x3CCBE90", VA = "0x183CCD490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3CCDCC0", Offset = "0x3CCC6C0", VA = "0x183CCDCC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JFIBKODFDKM
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A2F0", Offset = "0x2B78CF0", VA = "0x182B7A2F0")]
	public static ABMFALHKFKK<T> HCIMANBFAGD<T>([In] T DBOBEHLEAAE) where T : notnull
	{
		return default(ABMFALHKFKK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A400", Offset = "0x2B78E00", VA = "0x182B7A400")]
	public static ABMFALHKFKK<T?> MBMKGOAKDMF<T>()
	{
		return default(ABMFALHKFKK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A540", Offset = "0x2B78F40", VA = "0x182B7A540")]
	public static bool NGBIOMAOPOP<T>([In] this ABMFALHKFKK<T> IGAIDKDMLGG, [Out][NotNullWhen(true)] T DBOBEHLEAAE) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct IBIDHJBCHDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr EAADIHNODDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr KPNONIMPFJF;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr KANDDBOACMF;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr MBNHDGNBLNP;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly IBIDHJBCHDH EOPMNGGGOOO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DJEJGGIOHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6992590", Offset = "0x6990F90", VA = "0x186992590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xAA6F80", Offset = "0xAA5980", VA = "0x180AA6F80")]
	public IBIDHJBCHDH(IntPtr JHKOBMOBLJN, IntPtr FCDCJLIMGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	private static void GEMIPHJINPI(string CCMEKJGADHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
	private static void GNOPOIODDBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6992670", Offset = "0x6991070", VA = "0x186992670")]
	private static IBIDHJBCHDH LIBKBBEFAIP()
	{
		return default(IBIDHJBCHDH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct GMLKMIJHPAL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr PJJGCJPLJKE;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920520", VA = "0x180921B20")]
	private GMLKMIJHPAL(IntPtr FCDCJLIMGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6991A80", Offset = "0x6990480", VA = "0x186991A80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6991AA0", Offset = "0x69904A0", VA = "0x186991AA0")]
	public static GMLKMIJHPAL KHKANEAPNIK(string CCMEKJGADHN)
	{
		return default(GMLKMIJHPAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F1C0", Offset = "0x1F9DBC0", VA = "0x181F9F1C0")]
	public static GMLKMIJHPAL KHKANEAPNIK([In] IBIDHJBCHDH DGPJEOKIHLD, string CCMEKJGADHN)
	{
		return default(GMLKMIJHPAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F210", Offset = "0x1F9DC10", VA = "0x181F9F210")]
	public static GMLKMIJHPAL KHKANEAPNIK([In] IBIDHJBCHDH DGPJEOKIHLD, Func<string> CCMEKJGADHN)
	{
		return default(GMLKMIJHPAL);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class JKNMEOMECFK
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate bool AKLAFHJNBOD<in TInput, TResult>(TInput CGAJJAALELM, [Out] TResult EBPHIJANMPN);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private sealed class BPAOAIKHPDM : KCGCGKDHHFH
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private sealed class COOEFIMDGNK : EEANKJKKHFA, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly COOEFIMDGNK OHJMENPNAKB;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool DLHFIFPBDBM
			{
				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x6990910", Offset = "0x698F310", VA = "0x186990910", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x69907B0", Offset = "0x698F1B0", VA = "0x1869907B0", Slot = "6")]
			public void OnCompleted(Action HAIMPFKGJHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
			public void ACIGINHEDAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public COOEFIMDGNK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly BPAOAIKHPDM OHJMENPNAKB;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		private BPAOAIKHPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x69906E0", Offset = "0x698F0E0", VA = "0x1869906E0", Slot = "4")]
		public EEANKJKKHFA AJMGKPCPAEO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private sealed class IFKHAOMGMGN : KCGCGKDHHFH
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private sealed class IBNLCOLPOGG : EEANKJKKHFA, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly IBNLCOLPOGG OHJMENPNAKB;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool DLHFIFPBDBM
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x69928A0", Offset = "0x69912A0", VA = "0x1869928A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6992850", Offset = "0x6991250", VA = "0x186992850", Slot = "6")]
			public void OnCompleted(Action HAIMPFKGJHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
			public void ACIGINHEDAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public IBNLCOLPOGG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly IFKHAOMGMGN OHJMENPNAKB;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		private IFKHAOMGMGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6993650", Offset = "0x6992050", VA = "0x186993650", Slot = "4")]
		public EEANKJKKHFA AJMGKPCPAEO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class DBCMLIACGMK<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public DBCMLIACGMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x44847C0", Offset = "0x44831C0", VA = "0x1844847C0")]
		internal void COLKAENJFGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class DLBOIOGKGKB<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public DLBOIOGKGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x52557C0", Offset = "0x52541C0", VA = "0x1852557C0")]
		internal void FJNPHBFBKBJ(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct IEJFDJBIKBE : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x69934F0", Offset = "0x6991EF0", VA = "0x1869934F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct BMMFGLBNMAP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x69905D0", Offset = "0x698EFD0", VA = "0x1869905D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9E9250", Offset = "0x9E7C50", VA = "0x1809E9250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct AJDIIGEJPFP<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3CFE3E0", Offset = "0x3CFCDE0", VA = "0x183CFE3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3CFE550", Offset = "0x3CFCF50", VA = "0x183CFE550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct DPAPGLABPEA<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x57DA340", Offset = "0x57D8D40", VA = "0x1857DA340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x57DA770", Offset = "0x57D9170", VA = "0x1857DA770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct LFILMEJMMOJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6997B70", Offset = "0x6996570", VA = "0x186997B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6997D70", Offset = "0x6996770", VA = "0x186997D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class MOKGPCKLMCN<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public MOKGPCKLMCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x44847C0", Offset = "0x44831C0", VA = "0x1844847C0")]
		internal void FLDHPGEKBDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4484740", Offset = "0x4483140", VA = "0x184484740")]
		internal void EDPDIFICOKN(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct GEGBJGHBIFI<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public AKLAFHJNBOD<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3D197D0", Offset = "0x3D181D0", VA = "0x183D197D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3D19F00", Offset = "0x3D18900", VA = "0x183D19F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct NJFNNBNIHJA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6999710", Offset = "0x6998110", VA = "0x186999710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6999F00", Offset = "0x6998900", VA = "0x186999F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct MIANHLFIFCH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6998E50", Offset = "0x6997850", VA = "0x186998E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6999390", Offset = "0x6997D90", VA = "0x186999390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct DCMBMBECAFF<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5760CC0", Offset = "0x575F6C0", VA = "0x185760CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3E99190", Offset = "0x3E97B90", VA = "0x183E99190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct JOBDCIMDOIO<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4105DC0", Offset = "0x41047C0", VA = "0x184105DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x35503C0", Offset = "0x354EDC0", VA = "0x1835503C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct PNDPIIPDIIE<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x46E8BA0", Offset = "0x46E75A0", VA = "0x1846E8BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x46E92C0", Offset = "0x46E7CC0", VA = "0x1846E92C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct DAJMLJMIFDH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x69909F0", Offset = "0x698F3F0", VA = "0x1869909F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6990BD0", Offset = "0x698F5D0", VA = "0x186990BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct JFDBGILHKII : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6993720", Offset = "0x6992120", VA = "0x186993720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6993A90", Offset = "0x6992490", VA = "0x186993A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct MHCNAOMHIBN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6998B00", Offset = "0x6997500", VA = "0x186998B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6998DF0", Offset = "0x69977F0", VA = "0x186998DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class PLEEBOJBDPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public PLEEBOJBDPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x699A5A0", Offset = "0x6998FA0", VA = "0x18699A5A0")]
		internal Task ANONCCLLFJN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct AFDABLPDHEL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6990050", Offset = "0x698EA50", VA = "0x186990050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x69902B0", Offset = "0x698ECB0", VA = "0x1869902B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct PFAPOJKCKCN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x699A010", Offset = "0x6998A10", VA = "0x18699A010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x699A1F0", Offset = "0x6998BF0", VA = "0x18699A1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct GPGGOGKDJEL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6991BA0", Offset = "0x69905A0", VA = "0x186991BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6991F10", Offset = "0x6990910", VA = "0x186991F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct PFOGEHNPMKA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x699A250", Offset = "0x6998C50", VA = "0x18699A250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x699A540", Offset = "0x6998F40", VA = "0x18699A540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class EENCLOCHOJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public EENCLOCHOJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6990C30", Offset = "0x698F630", VA = "0x186990C30")]
		internal Task OFHIHOHIHHF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct KHGEABOMGDM : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6995930", Offset = "0x6994330", VA = "0x186995930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6995B90", Offset = "0x6994590", VA = "0x186995B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct BMBOLOAFNKB : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x69903F0", Offset = "0x698EDF0", VA = "0x1869903F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6990570", Offset = "0x698EF70", VA = "0x186990570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct JNCGOBAEFAN<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4105920", Offset = "0x4104320", VA = "0x184105920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4105B80", Offset = "0x4104580", VA = "0x184105B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct LLCDJPFOPGL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6998610", Offset = "0x6997010", VA = "0x186998610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6998A10", Offset = "0x6997410", VA = "0x186998A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? PAAHMCKEMGB;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<LMMCANLFCCL> PBBHKFMNECC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task CHPIDEIJCDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6994070", Offset = "0x6992A70", VA = "0x186994070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x69944B0", Offset = "0x6992EB0", VA = "0x1869944B0")]
	public static bool EKCHFNENPKD(this Task JCINMAJOONI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F200", Offset = "0x2B7DC00", VA = "0x182B7F200")]
	public static Task<T> IKDJADFOMHB<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6995090", Offset = "0x6993A90", VA = "0x186995090")]
	public static Task NACJHOKBALK(this Task JCINMAJOONI, CancellationToken JCIFCENKMKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2B81940", Offset = "0x2B80340", VA = "0x182B81940")]
	public static Task<TResult> NACJHOKBALK<TResult>(this Task<TResult> JCINMAJOONI, CancellationToken JCIFCENKMKP) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2B828D0", Offset = "0x2B812D0", VA = "0x182B828D0")]
	public static TaskCompletionSource<TResult> NACJHOKBALK<TResult>(this TaskCompletionSource<TResult> PHLJDCJAGMF, CancellationToken JCIFCENKMKP) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6993E80", Offset = "0x6992880", VA = "0x186993E80")]
	public static IDisposable? AMHLHJFLMPA(CancellationToken BEAIEHMCPMH, CancellationToken GDMBBFIJOFH, [Out] CancellationToken DIJKFECCEAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6993FC0", Offset = "0x69929C0", VA = "0x186993FC0")]
	[AsyncStateMachine(typeof(IEJFDJBIKBE))]
	public static void BHMGHMOAIBM(this Task FOCADABILLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6994C80", Offset = "0x6993680", VA = "0x186994C80")]
	[AsyncStateMachine(typeof(BMMFGLBNMAP))]
	public static void KCMIFHDJFLA(this Task FOCADABILLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2B7EF50", Offset = "0x2B7D950", VA = "0x182B7EF50")]
	[AsyncStateMachine(typeof(AJDIIGEJPFP<>))]
	public static Task GFAGEOMAHED<TException>(this Task FOCADABILLC) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F020", Offset = "0x2B7DA20", VA = "0x182B7F020")]
	[AsyncStateMachine(typeof(DPAPGLABPEA<>))]
	public static Task<T> IIAPMNAMJAK<T>(this Task<T> BBCPNLGGBMJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6994D80", Offset = "0x6993780", VA = "0x186994D80")]
	[AsyncStateMachine(typeof(LFILMEJMMOJ))]
	public static Task<TaskStatus> KMEPFMOOPBP(this Task BBCPNLGGBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F560", Offset = "0x2B7DF60", VA = "0x182B7F560")]
	public static (Task<T?>?, Action<T?>?) KKEAIPIHLOH<T>([Optional] CancellationToken AOLOJHLCMLE)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F8D0", Offset = "0x2B7E2D0", VA = "0x182B7F8D0")]
	[AsyncStateMachine(typeof(GEGBJGHBIFI<, >))]
	public static Task<List<TResult>> LCMPCKIOKCL<TResult, TInput>(this Task<List<TInput>> JCINMAJOONI, AKLAFHJNBOD<TInput, TResult> PLHFPCCNHHB) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6995420", Offset = "0x6993E20", VA = "0x186995420")]
	[AsyncStateMachine(typeof(NJFNNBNIHJA))]
	public static Task OBCGJLIAMHG(Task FOCADABILLC, CancellationToken NEGOEBJOBPE, Func<CancellationToken, Task> HGMDGCNFHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x69952F0", Offset = "0x6993CF0", VA = "0x1869952F0")]
	[AsyncStateMachine(typeof(MIANHLFIFCH))]
	public static Task NHBCBEDHFMB(Func<CancellationToken, Task> MBMICMKEMDC, TimeSpan CGNNGIOOAGE, [Optional] CancellationToken NEGOEBJOBPE, [Optional] Action<OperationCanceledException>? FAFCFDIJEOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2B83260", Offset = "0x2B81C60", VA = "0x182B83260")]
	[AsyncStateMachine(typeof(DCMBMBECAFF<>))]
	public static Task<T> NHBCBEDHFMB<T>(Func<CancellationToken, Task<T>> MBMICMKEMDC, TimeSpan CGNNGIOOAGE, [Optional] CancellationToken NEGOEBJOBPE, [Optional] Func<OperationCanceledException, T>? FAFCFDIJEOD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F470", Offset = "0x2B7DE70", VA = "0x182B7F470")]
	[AsyncStateMachine(typeof(JOBDCIMDOIO<>))]
	public static Task<IEnumerable<Task<T>>> JDLFPOBJDFB<T>(IEnumerable<Task<T>> GBAMFJJHCBC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2B7EC90", Offset = "0x2B7D690", VA = "0x182B7EC90")]
	[AsyncStateMachine(typeof(PNDPIIPDIIE<, , , >))]
	public static Task<(T1, T2, T3, T4)> EHCBCEDJMHH<T1, T2, T3, T4>(Task<T1> CAAJBANEPOO, Task<T2> JCHJPGOBDLN, Task<T3> HGOEAGGJCJD, Task<T4> GDNCEAIBDHE) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6994AC0", Offset = "0x69934C0", VA = "0x186994AC0")]
	[AsyncStateMachine(typeof(DAJMLJMIFDH))]
	public static Task HDFLFMGDFGP(Func<bool> EMAGLACAJHK, [Optional] CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x69949B0", Offset = "0x69933B0", VA = "0x1869949B0")]
	[AsyncStateMachine(typeof(JFDBGILHKII))]
	public static Task HDFLFMGDFGP(Func<bool> EMAGLACAJHK, TimeSpan AABKPBBFANO, [Optional] CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6993D50", Offset = "0x6992750", VA = "0x186993D50")]
	[AsyncStateMachine(typeof(MHCNAOMHIBN))]
	public static Task ALFNGOAFGBG(Func<bool> EMAGLACAJHK, TimeSpan CGNNGIOOAGE, [Optional] CancellationToken AOLOJHLCMLE, [Optional] Action<OperationCanceledException>? FAFCFDIJEOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6993C10", Offset = "0x6992610", VA = "0x186993C10")]
	[AsyncStateMachine(typeof(AFDABLPDHEL))]
	public static Task ALFNGOAFGBG(Func<bool> EMAGLACAJHK, TimeSpan CGNNGIOOAGE, TimeSpan AABKPBBFANO, [Optional] CancellationToken AOLOJHLCMLE, [Optional] Action<OperationCanceledException>? FAFCFDIJEOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6995660", Offset = "0x6994060", VA = "0x186995660")]
	[AsyncStateMachine(typeof(PFAPOJKCKCN))]
	public static Task OMABKKKNHGM(Func<bool> EMAGLACAJHK, [Optional] CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6995550", Offset = "0x6993F50", VA = "0x186995550")]
	[AsyncStateMachine(typeof(GPGGOGKDJEL))]
	public static Task OMABKKKNHGM(Func<bool> EMAGLACAJHK, TimeSpan AABKPBBFANO, [Optional] CancellationToken AOLOJHLCMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x69947B0", Offset = "0x69931B0", VA = "0x1869947B0")]
	[AsyncStateMachine(typeof(PFOGEHNPMKA))]
	public static Task GEOCNHEJFPE(Func<bool> EMAGLACAJHK, TimeSpan CGNNGIOOAGE, [Optional] CancellationToken AOLOJHLCMLE, [Optional] Action<OperationCanceledException>? FAFCFDIJEOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6994670", Offset = "0x6993070", VA = "0x186994670")]
	[AsyncStateMachine(typeof(KHGEABOMGDM))]
	public static Task GEOCNHEJFPE(Func<bool> EMAGLACAJHK, TimeSpan CGNNGIOOAGE, TimeSpan AABKPBBFANO, [Optional] CancellationToken AOLOJHLCMLE, [Optional] Action<OperationCanceledException>? FAFCFDIJEOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6994E70", Offset = "0x6993870", VA = "0x186994E70")]
	[AsyncStateMachine(typeof(BMBOLOAFNKB))]
	[Obsolete]
	public static Task KNOLEFCPBHM(this Task JCINMAJOONI, Action ABLFALIMJON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F7E0", Offset = "0x2B7E1E0", VA = "0x182B7F7E0")]
	[AsyncStateMachine(typeof(JNCGOBAEFAN<>))]
	[Obsolete]
	public static Task KNOLEFCPBHM<T>(this Task<T> JCINMAJOONI, Action<T> ABLFALIMJON) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6994F60", Offset = "0x6993960", VA = "0x186994F60")]
	private static void MDIOFBKGCDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6994130", Offset = "0x6992B30", VA = "0x186994130")]
	public static bool EEBNLJNMKIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x69944E0", Offset = "0x6992EE0", VA = "0x1869944E0")]
	private static void GABIALOABPO(SynchronizationContext DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6993AF0", Offset = "0x69924F0", VA = "0x186993AF0")]
	private static void AJPFDCAMNAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x69948E0", Offset = "0x69932E0", VA = "0x1869948E0")]
	public static void HCKLONODMBC([Optional] string? BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6995010", Offset = "0x6993A10", VA = "0x186995010")]
	public static void MHGOKKGMDIF([Optional] string? BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x69940E0", Offset = "0x6992AE0", VA = "0x1869940E0")]
	public static KCGCGKDHHFH DDBBMHGOKAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6994D30", Offset = "0x6993730", VA = "0x186994D30")]
	public static KCGCGKDHHFH KGHCHGKKNHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6994BB0", Offset = "0x69935B0", VA = "0x186994BB0")]
	[AsyncStateMachine(typeof(LLCDJPFOPGL))]
	public static Task HNGEMBAPEMG(Func<Task> MFKPABNLOJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class FABAIOIDLJO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
	public FABAIOIDLJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class KELBCMDOGNN : MOEMAIEFBPA
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly MOEMAIEFBPA OHJMENPNAKB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime DKGCNIMCDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6995870", Offset = "0x6994270", VA = "0x186995870", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset NBGFGPOODKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6995810", Offset = "0x6994210", VA = "0x186995810", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public KELBCMDOGNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface MOEMAIEFBPA
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime DKGCNIMCDHE
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset NBGFGPOODKO
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class LKDKOLECADF
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long CCAOOJEGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6998240", Offset = "0x6996C40", VA = "0x186998240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long DODGODELOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x69982E0", Offset = "0x6996CE0", VA = "0x1869982E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double EJAHKLCLCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6998290", Offset = "0x6996C90", VA = "0x186998290")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double HHHMDOJMNLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x69981F0", Offset = "0x6996BF0", VA = "0x1869981F0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double MLGHONNGJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6998150", Offset = "0x6996B50", VA = "0x186998150")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double MKBOKHNELEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x69981A0", Offset = "0x6996BA0", VA = "0x1869981A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x69980C0", Offset = "0x6996AC0", VA = "0x1869980C0")]
	public static double FPDOHDIGLBA(long EDCBAEKCHOF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6998030", Offset = "0x6996A30", VA = "0x186998030")]
	public static double FBLBPNFGFDO(long EDCBAEKCHOF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6997F40", Offset = "0x6996940", VA = "0x186997F40")]
	public static double DFCFHDICGJH(double LHALDIABJIC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6997EB0", Offset = "0x69968B0", VA = "0x186997EB0")]
	public static long BJCBHPMDIJC(long PBLACMAEFME)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6998330", Offset = "0x6996D30", VA = "0x186998330")]
	public static long LPNEECMIIMA(long CNCNJADGGIJ, long MGLPIOELNIC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6997DE0", Offset = "0x69967E0", VA = "0x186997DE0")]
	public static double ALPDECOHCHM(long CNCNJADGGIJ, long MGLPIOELNIC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6997FD0", Offset = "0x69969D0", VA = "0x186997FD0")]
	public static double EMLKBJLNBIH(long CNCNJADGGIJ, long MGLPIOELNIC)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class LCOBMHNJPIA : GALGDKDHJCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static readonly TimeSpan KMCPLJPHHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly System.Timers.Timer GJLENOHHOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private TimeSpan CGNNGIOOAGE;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan IPHAAJDIOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6997610", Offset = "0x6996010", VA = "0x186997610", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? FNILDBNKMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x84EC30", Offset = "0x84D630", VA = "0x18084EC30", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6997B00", Offset = "0x6996500", VA = "0x186997B00")]
	[Preserve]
	public LCOBMHNJPIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x69978B0", Offset = "0x69962B0", VA = "0x1869978B0")]
	public LCOBMHNJPIA(TimeSpan CGNNGIOOAGE, [Optional] Action? PABHLMLNLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6997510", Offset = "0x6995F10", VA = "0x186997510", Slot = "7")]
	public void FNEPMCHENFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x69975A0", Offset = "0x6995FA0", VA = "0x1869975A0", Slot = "8")]
	public void GNGCCNBCHGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6997810", Offset = "0x6996210", VA = "0x186997810", Slot = "9")]
	public void PMGKHCNMCBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x922F60", Offset = "0x921960", VA = "0x180922F60")]
	private void OMPDDNCCIOD(object MAJFEBAGNLL, ElapsedEventArgs CDDEFOLNOJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6997770", Offset = "0x6996170", VA = "0x186997770")]
	private static void PAJHLLDJDDM(TimeSpan NPINHGKIDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6997470", Offset = "0x6995E70", VA = "0x186997470", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class AFLDEPHJFEH : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly string? BPGPIEGDDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly string IBEIIGCALBB;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6448A80", Offset = "0x6447480", VA = "0x186448A80")]
	public AFLDEPHJFEH(string GFOGDKMJGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3E1F460", Offset = "0x3E1DE60", VA = "0x183E1F460")]
	public AFLDEPHJFEH(string INNDIMHALJD, string GFOGDKMJGKF)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct KMKODCHIEIO : IEquatable<KMKODCHIEIO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public uint GJFMLNIPMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int CIHLKMJBFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float AAHAAEGCILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public ushort LJJEEJEBIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public ushort MOILIILMNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public short CNANHBPBNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public short HPGLBIPKKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public char LKBIHEPEDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public char BMHFIKMJFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte GIHFMMIOFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte CKDBMOEFOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public byte ELLKLGKOPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte MLMNMFCAIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool BFNNNHINJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool LEFFCHIFFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public bool GKOHEPMDNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool JEGLDODEIEF;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0xE061B0", Offset = "0xE04BB0", VA = "0x180E061B0")]
	public static KMKODCHIEIO GBILKJAGKEB(uint LFPOMCBNBGJ)
	{
		return default(KMKODCHIEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xE061B0", Offset = "0xE04BB0", VA = "0x180E061B0")]
	public static KMKODCHIEIO IMOPHAJHECC(int BMMBKMLDPCP)
	{
		return default(KMKODCHIEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6996600", Offset = "0x6995000", VA = "0x186996600")]
	public static KMKODCHIEIO OGMNHPINNGA(float AKOOCAOLNMH)
	{
		return default(KMKODCHIEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6996550", Offset = "0x6994F50", VA = "0x186996550")]
	public static KMKODCHIEIO CLKCJLGONEL(byte BLPJIDJHINI, byte MKDILKIOGED, byte NDCLADJEHAO, byte ANIKNNFMMBM)
	{
		return default(KMKODCHIEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6996550", Offset = "0x6994F50", VA = "0x186996550")]
	public static KMKODCHIEIO CMKOINNAAJH(bool BIJINCNFLLD, bool BNMIJKIJMNE, bool CKFJOFGENIP, bool DCHKNLNBLOA)
	{
		return default(KMKODCHIEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6996550", Offset = "0x6994F50", VA = "0x186996550")]
	public static KMKODCHIEIO NFEAIOCCFKG(byte LFBOBKLHKML, byte CLOECDFEOKC, byte HGJIIHPFPCC, byte JFPAOGGCOJN)
	{
		return default(KMKODCHIEIO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x1A5E750", Offset = "0x1A5D150", VA = "0x181A5E750")]
	public static bool IKJGJDJDJIH(KMKODCHIEIO NNEJNMNIIPM, KMKODCHIEIO MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x9E72B0", Offset = "0x9E5CB0", VA = "0x1809E72B0", Slot = "4")]
	public bool Equals(KMKODCHIEIO HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6996570", Offset = "0x6994F70", VA = "0x186996570", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0xA9F800", Offset = "0xA9E200", VA = "0x180A9F800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6996610", Offset = "0x6995010", VA = "0x186996610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct HIKEINPPGKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public ulong PGDIIKCDAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public long LMDJGLEBDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public double FKKIMCHAFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint CJPMLGFNHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint OMJEIMEMIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public int BFPHEJALEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int ICEPHEFKBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float BDHEFEJNALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float KALOBFBLNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort LJJEEJEBIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort MOILIILMNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public ushort PIAAPNADOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort IEBPGHEJENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short CNANHBPBNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short HPGLBIPKKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public short BGNDOPDDDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short JBNMDHADJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char LKBIHEPEDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char BMHFIKMJFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public char GACNKKFGNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char NBCNLCMGCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte GIHFMMIOFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte CKDBMOEFOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte ELLKLGKOPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte MLMNMFCAIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte FHFOOFECHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte JONEBPFPPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte MPAKHHNPDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte MNHGBOHIHDC;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6992540", Offset = "0x6990F40", VA = "0x186992540")]
	public static HIKEINPPGKO KHKANEAPNIK(byte BLPJIDJHINI, byte MKDILKIOGED, byte NDCLADJEHAO, byte ANIKNNFMMBM, byte JNACNPNMJKF, byte OPHMLILMCCL, byte KLIFONFMNEJ, byte CNCKDKHEKGM)
	{
		return default(HIKEINPPGKO);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct NHHJOFCAALP : IEquatable<NHHJOFCAALP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte PKGJBAPCPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool GAPAAPMPOHK;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2552770", Offset = "0x2551170", VA = "0x182552770")]
	public static NHHJOFCAALP CLKCJLGONEL(byte GMEEKEAJKFG)
	{
		return default(NHHJOFCAALP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2552770", Offset = "0x2551170", VA = "0x182552770")]
	public static NHHJOFCAALP CMKOINNAAJH(bool MOCAGHFEIFE)
	{
		return default(NHHJOFCAALP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6999490", Offset = "0x6997E90", VA = "0x186999490")]
	public static bool IKJGJDJDJIH(NHHJOFCAALP NNEJNMNIIPM, NHHJOFCAALP MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5B3FAE0", Offset = "0x5B3E4E0", VA = "0x185B3FAE0", Slot = "4")]
	public bool Equals(NHHJOFCAALP HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x69993F0", Offset = "0x6997DF0", VA = "0x1869993F0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6999480", Offset = "0x6997E80", VA = "0x186999480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x69994A0", Offset = "0x6997EA0", VA = "0x1869994A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class IPLHHBPMLMF<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public readonly T JIOGCAKDOMG;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE290", Offset = "0x3EACC90", VA = "0x183EAE290")]
	public IPLHHBPMLMF(T IMEONMCOMJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class HKPCLDGCOAO
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2B469D0", Offset = "0x2B453D0", VA = "0x182B469D0")]
	public static IEnumerable<T> FCGJMPOIBPH<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
	public static T[] JJGBGDJFOPD<T>(params T[] PJLHNMBDKAC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x915430", Offset = "0x913E30", VA = "0x180915430")]
	public static IEnumerable<T> HCKLKBDNGKE<T>(params T[] PJLHNMBDKAC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2960650", Offset = "0x295F050", VA = "0x182960650")]
	public static HashSet<T> DLNOFHFIPAH<T>(params T[] PJLHNMBDKAC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2B46A00", Offset = "0x2B45400", VA = "0x182B46A00")]
	public static KeyValuePair<TKey, TValue> JJNMBNHDBML<TKey, TValue>([In] TKey LDDEKIBHION, [In] TValue DBOBEHLEAAE) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2960650", Offset = "0x295F050", VA = "0x182960650")]
	public static List<T> CGJGKAKHGAG<T>(IEnumerable<T> KJGLHKICAHL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[AttributeUsage(AttributeTargets.All)]
public sealed class NAEMOJOGDHL : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public readonly string KHHDHIKEILP;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
	public NAEMOJOGDHL(string IAJKDACGMME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate object KEDHHGDNPIO<T>([In] T BKANBMHGIEE);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object CFCKPOMNILG<T>(T BKANBMHGIEE);
[Cpp2IlInjected.Token(Token = "0x2000059")]
[HBFFGICEBGA]
public delegate string FBCBCJEABNJ(string OHOJCGMAAGM, string? JJCMLJHKNHF, bool LMKMKAOMGOI);
[Cpp2IlInjected.Token(Token = "0x200005A")]
[HBFFGICEBGA]
public delegate void MPODOGBGBGM(string BDCMABOIIFF);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[HBFFGICEBGA]
public delegate void OPNDNEFAGCM(Exception JKHACPOPJJF);
[Cpp2IlInjected.Token(Token = "0x200005C")]
public delegate object BBCGICGBMIO();
[Cpp2IlInjected.Token(Token = "0x200005D")]
[HBFFGICEBGA]
public delegate bool AIMKDAGEABL();
[Cpp2IlInjected.Token(Token = "0x200005E")]
[HBFFGICEBGA]
public delegate string HGGDEAHCPHL(object GKHPLGCJCPF);
[Cpp2IlInjected.Token(Token = "0x200005F")]
[AttributeUsage(AttributeTargets.Enum)]
public class DIBCIBBHKNA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
	public DIBCIBBHKNA()
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
