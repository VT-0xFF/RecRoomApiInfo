using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Foundation_Collections_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : GEPCMJPGCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DB00", Offset = "0x6F4C300", VA = "0x186F4DB00", Slot = "4")]
		public override void CCEDGNHHKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KPAFLEIMLFK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D9A0", Offset = "0x6F4C1A0", VA = "0x186F4D9A0")]
	public static void LDMOBJDCKCO(this GameObject PBJIFBOBIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D860", Offset = "0x6F4C060", VA = "0x186F4D860")]
	public static void LDMOBJDCKCO(this Component FGOJHDGPHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D900", Offset = "0x6F4C100", VA = "0x186F4D900")]
	public static void LDMOBJDCKCO(this ScriptableObject FJJAOJKLLJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ILMNCKKNDBL
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D700", Offset = "0x6F4BF00", VA = "0x186F4D700")]
	public static Span<byte> JEMOJINEGOG(this NativeArray<byte> GHAIAFELBIF)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D7B0", Offset = "0x6F4BFB0", VA = "0x186F4D7B0")]
	public static ReadOnlySpan<byte> NCJIGEOAHGP(this NativeArray<byte> GHAIAFELBIF)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x30A2370", Offset = "0x30A0B70", VA = "0x1830A2370")]
	public static NativeArray<T> DMOGOPAMNNA<T>(this NativeArray<T> GHAIAFELBIF, LGIPPHGAGPO DGMMIIPLMEK) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x30A23B0", Offset = "0x30A0BB0", VA = "0x1830A23B0")]
	public static NativeArray<T> DMOGOPAMNNA<T>(this NativeArray<T> GHAIAFELBIF, int EEPGNNLBJAH) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JLGCKLDNPBD
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x30BB300", Offset = "0x30B9B00", VA = "0x1830BB300")]
	public static string EHDKMBFDBBK<T>(this NativeArray<T> GHAIAFELBIF, string MNOPJEMDPKP = ", ") where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class AMFNGOLLHOP
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D3E0", Offset = "0x6F4BBE0", VA = "0x186F4D3E0")]
	public static void LDIKKPOMCHH(this NativeList<byte> OCHGNEGGEPP, ReadOnlySpan<byte> AHFDOCNDBDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class OIPKFLDOBCD
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3200C30", Offset = "0x31FF430", VA = "0x183200C30")]
	public static T MMDCICBMEGB<T>(this ReadOnlySpan<byte> INDENPJBLHO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3200D70", Offset = "0x31FF570", VA = "0x183200D70")]
	public static ReadOnlySpan<byte> NCJIGEOAHGP<T>(this T INDENPJBLHO) where T : struct
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x32001D0", Offset = "0x31FE9D0", VA = "0x1832001D0")]
	public static T EFGCOGNKKLM<T>([In] this ReadOnlySpan<byte> AHFDOCNDBDH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3103F30", Offset = "0x3102730", VA = "0x183103F30")]
	public static ReadOnlySpan<TTo> MKEHOMAPOLP<TTo>(this ReadOnlySpan<byte> AHFDOCNDBDH) where TTo : struct
	{
		return default(ReadOnlySpan<TTo>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3200720", Offset = "0x31FEF20", VA = "0x183200720")]
	public static Span<byte> KLHHFEENEBM<T>([In] this Span<byte> AHFDOCNDBDH, T INDENPJBLHO) where T : struct
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DFB0", Offset = "0x6F4C7B0", VA = "0x186F4DFB0")]
	private static Enum JPJJHHCODEI([In] ReadOnlySpan<byte> AHFDOCNDBDH, Type MODDFHBPPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E550", Offset = "0x6F4CD50", VA = "0x186F4E550")]
	public static Enum KBOJLAKHMPP([In] this Span<byte> AHFDOCNDBDH, Type MODDFHBPPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E5C0", Offset = "0x6F4CDC0", VA = "0x186F4E5C0")]
	public static void MLECBLDOKCK([In] this Span<byte> AHFDOCNDBDH, Enum HGBJJIKLGEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MBGMDJGHODO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct MDPBBNFDKDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DD20", Offset = "0x6F4C520", VA = "0x186F4DD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DB90", Offset = "0x6F4C390", VA = "0x186F4DB90")]
	[AsyncStateMachine(typeof(MDPBBNFDKDE))]
	public static void BEINOLENLBF(this Task EBDGHJJPDEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MDFMGMFENDF
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum JEHJKFOGONK : short
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Uncategorized = 5,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		ObjectModel,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		SplineWrapper,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Scalability,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		UpdateAllocator,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		Snapshot,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		ShadowEntities,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		PostLoadNetworkIdSystem,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		Singleton,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		COUNT
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct AOEECPHFOLD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly JEHJKFOGONK KCGKBDGKIOP;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x291E050", Offset = "0x291C850", VA = "0x18291E050")]
		public AOEECPHFOLD(JEHJKFOGONK KCGKBDGKIOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static ProfilerCategory ACLOEPFIMMM;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
	public static void CPGLBCDJJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DCB0", Offset = "0x6F4C4B0", VA = "0x186F4DCB0")]
	static MDFMGMFENDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2D4E200", Offset = "0x2D4CA00", VA = "0x182D4E200")]
	public static AOEECPHFOLD JAMOBCEPAOO(JEHJKFOGONK KCGKBDGKIOP)
	{
		return default(AOEECPHFOLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
	public static void DOFDJHMCICA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct GJODJLPMCND<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private GCHandle KACBIAOBGKP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T MHFLHGKPHDB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4137400", Offset = "0x4135C00", VA = "0x184137400")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4137300", Offset = "0x4135B00", VA = "0x184137300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x41374A0", Offset = "0x4135CA0", VA = "0x1841374A0")]
	public GJODJLPMCND(T INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x41373D0", Offset = "0x4135BD0", VA = "0x1841373D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DefaultMember("Item")]
public class JAPMJCEPJPN<THandle, TValue> : IDisposable where THandle : struct, KCFKJNPGMEA where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly List<THandle> FOOPPDKFADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly List<TValue> MCAFGDLBCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly Func<TValue> PMHMGEJGECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Action<TValue> LNNFDLPDJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int AFLKNBPIOBC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TValue DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x45215B0", Offset = "0x451FDB0", VA = "0x1845215B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x45216F0", Offset = "0x451FEF0", VA = "0x1845216F0")]
	public JAPMJCEPJPN(Action<TValue> LNNFDLPDJPP, [Optional] Func<TValue> PMHMGEJGECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4520DC0", Offset = "0x451F5C0", VA = "0x184520DC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x45211E0", Offset = "0x451F9E0", VA = "0x1845211E0")]
	public THandle JGCMIIMCCFC(TValue INDENPJBLHO)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4520A80", Offset = "0x451F280", VA = "0x184520A80")]
	public bool ANFLKJPBFFP(THandle KACBIAOBGKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4520FF0", Offset = "0x451F7F0", VA = "0x184520FF0")]
	public bool GKNHABNOIHP(THandle KACBIAOBGKP, [Out] TValue INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4520E90", Offset = "0x451F690", VA = "0x184520E90")]
	public TValue EFGCOGNKKLM(THandle KACBIAOBGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4520EE0", Offset = "0x451F6E0", VA = "0x184520EE0")]
	public bool GDDFGENFMPA(THandle KACBIAOBGKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4520D60", Offset = "0x451F560", VA = "0x184520D60")]
	private THandle DJEOLDDOKAG(int ECDOOAABOPD)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4520A10", Offset = "0x451F210", VA = "0x184520A10")]
	private TValue AHMKMPCDJJL(int ECDOOAABOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x45213B0", Offset = "0x451FBB0", VA = "0x1845213B0")]
	private void LGGDFBCELPG(int ECDOOAABOPD, [In] THandle KACBIAOBGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x45215F0", Offset = "0x451FDF0", VA = "0x1845215F0")]
	private void NNIJFPFCHML(int ECDOOAABOPD, [In] TValue INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4521400", Offset = "0x451FC00", VA = "0x184521400")]
	private THandle LKDCPPIBOCG()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x45210C0", Offset = "0x451F8C0", VA = "0x1845210C0")]
	private void IEDEMLBCGFI(THandle KACBIAOBGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x45211D0", Offset = "0x451F9D0", VA = "0x1845211D0")]
	private int INPIDJLPEFJ(int MAAOIFPNGGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4520A70", Offset = "0x451F270", VA = "0x184520A70")]
	private bool AJLEEKHPHPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8C1910", Offset = "0x8C0110", VA = "0x1808C1910")]
	private void DILJICOCMBB(THandle KACBIAOBGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4521640", Offset = "0x451FE40", VA = "0x184521640")]
	private bool OFCNFHGHGHF([Out] THandle KACBIAOBGKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4521280", Offset = "0x451FA80", VA = "0x184521280")]
	private bool KLCHKEACCOA([Out] THandle KACBIAOBGKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4520BB0", Offset = "0x451F3B0", VA = "0x184520BB0")]
	private void BKBGECDLIPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KCFKJNPGMEA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int MBLPHBBBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int KCBFDBADCEE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CODOPPBADJB
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2E6ADE0", Offset = "0x2E695E0", VA = "0x182E6ADE0")]
	public static bool KMOANKKPEHH<T>(this T KACBIAOBGKP, T LIHCAHPMPHD) where T : struct, KCFKJNPGMEA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2E6AE00", Offset = "0x2E69600", VA = "0x182E6AE00")]
	public static bool LNCHMIOPEFL<T>(this T KACBIAOBGKP) where T : struct, KCFKJNPGMEA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D460", Offset = "0x6F4BC60", VA = "0x186F4D460")]
	public static string COKCKOKNHDB(this KCFKJNPGMEA KACBIAOBGKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public ref struct NAGHPEHFOJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly Type AOKCAKHGMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly Span<byte> KBDFONJMALK;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x46D6380", Offset = "0x46D4B80", VA = "0x1846D6380")]
	public NAGHPEHFOJO(Type HGPFKHHNEHE, Span<byte> AHFDOCNDBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x31C22D0", Offset = "0x31C0AD0", VA = "0x1831C22D0")]
	public static NAGHPEHFOJO PJGGPIGEKEG<T>(T INDENPJBLHO) where T : struct
	{
		return default(NAGHPEHFOJO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DEA0", Offset = "0x6F4C6A0", VA = "0x186F4DEA0")]
	public static HEOGKNFNOFK FMEIMHFCNHG([In] NAGHPEHFOJO EBAPCDIJGCL)
	{
		return default(HEOGKNFNOFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DF20", Offset = "0x6F4C720", VA = "0x186F4DF20")]
	public Enum KBOJLAKHMPP(Type MODDFHBPPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x31C2290", Offset = "0x31C0A90", VA = "0x1831C2290")]
	public void KLHHFEENEBM<T>([In] T INDENPJBLHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DFA0", Offset = "0x6F4C7A0", VA = "0x186F4DFA0")]
	public void MLECBLDOKCK(Enum HGBJJIKLGEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public ref struct HEOGKNFNOFK
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct IGODLGFGDFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe void* GMIGHEOHLFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private unsafe void* EHCDNPNDAPF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly Type AOKCAKHGMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly ReadOnlySpan<byte> KBDFONJMALK;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x46D6380", Offset = "0x46D4B80", VA = "0x1846D6380")]
	public HEOGKNFNOFK(Type HGPFKHHNEHE, ReadOnlySpan<byte> AHFDOCNDBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3085B80", Offset = "0x3084380", VA = "0x183085B80")]
	public static HEOGKNFNOFK PJGGPIGEKEG<T>(T INDENPJBLHO) where T : struct
	{
		return default(HEOGKNFNOFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D6C0", Offset = "0x6F4BEC0", VA = "0x186F4D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F4D570", Offset = "0x6F4BD70", VA = "0x186F4D570")]
	public object BMNCLOLPCOC()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct AFEDCICELNH
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x373B770", Offset = "0x3739F70", VA = "0x18373B770")]
	public static NativeArray<T> BNBAMNNGFPE<T>(T INDENPJBLHO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x373B720", Offset = "0x3739F20", VA = "0x18373B720")]
	public static NativeArray<T> BJBDAHDHHJA<T>(T INDENPJBLHO) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x373B7C0", Offset = "0x3739FC0", VA = "0x18373B7C0")]
	public static NativeArray<T> PJGGPIGEKEG<T>(T INDENPJBLHO, bool MKAPLEONLGD) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IEIGGOFOMBG<Handle> where Handle : KCFKJNPGMEA, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct NOOMKNFANHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly IEIGGOFOMBG<Handle> OLCLKINJODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int ECDOOAABOPD;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Handle EMPCGILMEJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4A5E580", Offset = "0x4A5CD80", VA = "0x184A5E580")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4A5E9F0", Offset = "0x4A5D1F0", VA = "0x184A5E9F0")]
		public NOOMKNFANHL(IEIGGOFOMBG<Handle> OLCLKINJODJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4A5E380", Offset = "0x4A5CB80", VA = "0x184A5E380")]
		public IFJCEHAMLJD DFLBOLBHLFN([In] IFJCEHAMLJD FNGOEBINDAF)
		{
			return default(IFJCEHAMLJD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4A5E6F0", Offset = "0x4A5CEF0", VA = "0x184A5E6F0")]
		public bool JNDDBDHEFKO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4A5E930", Offset = "0x4A5D130", VA = "0x184A5E930")]
		private Handle OHJGPHJHBCC(string PJFOMDHJLBF)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct IFJCEHAMLJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private NOOMKNFANHL AAIBBKPEGEJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Handle NEPDGMBEJHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x430D370", Offset = "0x430BB70", VA = "0x18430D370")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x430D4A0", Offset = "0x430BCA0", VA = "0x18430D4A0")]
		public IFJCEHAMLJD(IEIGGOFOMBG<Handle> OLCLKINJODJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x430D420", Offset = "0x430BC20", VA = "0x18430D420")]
		public bool JNDDBDHEFKO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x430D3B0", Offset = "0x430BBB0", VA = "0x18430D3B0")]
		public IFJCEHAMLJD IGEPHCDGPEC()
		{
			return default(IFJCEHAMLJD);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeList<int> PMMIEKEGHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private NativeList<int> JNOFDNNFFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int KINFECKKGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int NGHGMMHLEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool PEAFBPNNLDL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LMJANDOFNOO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x43082D0", Offset = "0x4306AD0", VA = "0x1843082D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IFJCEHAMLJD NONDOGGELNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4307B30", Offset = "0x4306330", VA = "0x184307B30")]
		get
		{
			return default(IFJCEHAMLJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4308B20", Offset = "0x4307320", VA = "0x184308B20")]
	public IEIGGOFOMBG(int MIEHFACIEHL, Allocator MOBIJPCBMOB = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4307040", Offset = "0x4305840", VA = "0x184307040")]
	public void BJHAOCCHMOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F0D0", Offset = "0x1C5D8D0", VA = "0x181C5F0D0")]
	public static int INPIDJLPEFJ(int JBEGGBDGOGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x294AC60", Offset = "0x2949460", VA = "0x18294AC60")]
	public static bool PBLLFIPOFBM(int JBEGGBDGOGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4308640", Offset = "0x4306E40", VA = "0x184308640")]
	public bool NILDEEGIICO(int ECDOOAABOPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4308350", Offset = "0x4306B50", VA = "0x184308350")]
	public bool MFBBKCBFPFF(Handle KACBIAOBGKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4307A60", Offset = "0x4306260", VA = "0x184307A60")]
	public Handle DMCDDCAOAHK()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4307610", Offset = "0x4305E10", VA = "0x184307610")]
	public void CPJPBGDGCJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4307CD0", Offset = "0x43064D0", VA = "0x184307CD0")]
	public void GGPMFLGEBHG(Handle KACBIAOBGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA02A00", Offset = "0xA01200", VA = "0x180A02A00")]
	private bool HOLMLJENHPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4307BA0", Offset = "0x43063A0", VA = "0x184307BA0")]
	private bool FGBHJOGNPEN(int ECDOOAABOPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4308160", Offset = "0x4306960", VA = "0x184308160")]
	private void KKCAALGGKIJ([Out] int ECDOOAABOPD, [Out] int MAAOIFPNGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4307D40", Offset = "0x4306540", VA = "0x184307D40")]
	private void KEDGKNDIIOD(Handle KACBIAOBGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4307210", Offset = "0x4305A10", VA = "0x184307210")]
	private void CJMLPMONLIE(int ECDOOAABOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4306EE0", Offset = "0x43056E0", VA = "0x184306EE0")]
	private bool BFKLMEHLEGH([Out] int ECDOOAABOPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4308990", Offset = "0x4307190", VA = "0x184308990")]
	private static Handle NOHAIOBCCBF(int ECDOOAABOPD, int MAAOIFPNGGJ)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public struct DLGFDIFNGCE<Handle, T> where Handle : KCFKJNPGMEA, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private IEIGGOFOMBG<Handle> ABLOFAOKLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private T[] KMCOGEKPMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Action<T> PDMDLIHHHLK;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF7D0", Offset = "0x5DEDFD0", VA = "0x185DEF7D0")]
	public DLGFDIFNGCE(int MIEHFACIEHL, [Optional] Action<T> PDMDLIHHHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEAE0", Offset = "0x5DED2E0", VA = "0x185DEEAE0")]
	public void BJHAOCCHMOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF370", Offset = "0x5DEDB70", VA = "0x185DEF370")]
	public bool GKNHABNOIHP(Handle KACBIAOBGKP, [Out] T INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF4F0", Offset = "0x5DEDCF0", VA = "0x185DEF4F0")]
	public Handle JGCMIIMCCFC(T INCBEIDOHDO)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEFB0", Offset = "0x5DED7B0", VA = "0x185DEEFB0")]
	public void FDIFLDAGEIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEE70", Offset = "0x5DED670", VA = "0x185DEEE70")]
	public void CGFLGFPAOEK(Handle KACBIAOBGKP, [Out] T NKAFLMHDEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5DEECB0", Offset = "0x5DED4B0", VA = "0x185DEECB0")]
	public void CGFLGFPAOEK(Handle KACBIAOBGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEF50", Offset = "0x5DED750", VA = "0x185DEEF50")]
	private T DOCBBKKFCAB(int ECDOOAABOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF710", Offset = "0x5DEDF10", VA = "0x185DEF710")]
	private void LKGKOOKCGDF(int KNDHPDHEDHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DefaultMember("Item")]
public struct IHPAGPDELHJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private T[] EBNFOODJNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int OANKAJFHCKB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int NALHPIPMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x23206E0", Offset = "0x231EEE0", VA = "0x1823206E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2E98350", Offset = "0x2E96B50", VA = "0x182E98350")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Span<T> KBDFONJMALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4313970", Offset = "0x4312170", VA = "0x184313970")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool BJEHFDDNHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1259380", Offset = "0x1257B80", VA = "0x181259380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4313B80", Offset = "0x4312380", VA = "0x184313B80")]
	public IHPAGPDELHJ(int OANKAJFHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4313A10", Offset = "0x4312210", VA = "0x184313A10")]
	public int NBGOGJONJGM(T INDENPJBLHO, int EEPGNNLBJAH, int NELOIEKKMHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4313870", Offset = "0x4312070", VA = "0x184313870", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public struct FAHGBPLMFAB<T> : IEnumerable<T>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct GBFLMCABFAI : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private FAHGBPLMFAB<T> OCHGNEGGEPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int ECDOOAABOPD;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x411DD70", Offset = "0x411C570", VA = "0x18411DD70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T NEPDGMBEJHL
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x411DE10", Offset = "0x411C610", VA = "0x18411DE10", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x411DDE0", Offset = "0x411C5E0", VA = "0x18411DDE0")]
		public GBFLMCABFAI(FAHGBPLMFAB<T> OCHGNEGGEPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x411DCE0", Offset = "0x411C4E0", VA = "0x18411DCE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x411DD20", Offset = "0x411C520", VA = "0x18411DD20", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private IHPAGPDELHJ<T> EBNFOODJNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int OANKAJFHCKB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T DBNKEBOPCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x404FEE0", Offset = "0x404E6E0", VA = "0x18404FEE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NALHPIPMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8B51A0", Offset = "0x8B39A0", VA = "0x1808B51A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x404F990", Offset = "0x404E190", VA = "0x18404F990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int LMJANDOFNOO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x404FE30", Offset = "0x404E630", VA = "0x18404FE30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool BJEHFDDNHKA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x404FF70", Offset = "0x404E770", VA = "0x18404FF70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Span<T> KBDFONJMALK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x404F800", Offset = "0x404E000", VA = "0x18404F800")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4050060", Offset = "0x404E860", VA = "0x184050060")]
	public FAHGBPLMFAB(int OANKAJFHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x404F220", Offset = "0x404DA20", VA = "0x18404F220")]
	public void CPGLBCDJJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x404FBE0", Offset = "0x404E3E0", VA = "0x18404FBE0")]
	public void JGCMIIMCCFC(T INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x404F280", Offset = "0x404DA80", VA = "0x18404F280")]
	internal void DDCGGOGADKC(int DEOEMPAJCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x404F720", Offset = "0x404DF20", VA = "0x18404F720")]
	public void GGEAHALPHLA(int ECDOOAABOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x404F4F0", Offset = "0x404DCF0", VA = "0x18404F4F0")]
	public void FEHDPIBLBPE(int LLNPGLOPLIO, int GNDBPGCEJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x404FE60", Offset = "0x404E660", VA = "0x18404FE60")]
	public int NBGOGJONJGM(T INDENPJBLHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x404F4B0", Offset = "0x404DCB0", VA = "0x18404F4B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x404F8C0", Offset = "0x404E0C0", VA = "0x18404F8C0", Slot = "4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x404FFB0", Offset = "0x404E7B0", VA = "0x18404FFB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x404FFF0", Offset = "0x404E7F0", VA = "0x18404FFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x404FCE0", Offset = "0x404E4E0", VA = "0x18404FCE0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void KNMEIFPLPEL(int INDENPJBLHO, int OANKAJFHCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x404F9D0", Offset = "0x404E1D0", VA = "0x18404F9D0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void JAGMMNKBAKD(int LLNPGLOPLIO, int GNDBPGCEJCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct LGIPPHGAGPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int MHPJBPKHONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int NELOIEKKMHO;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int AEOBBNBHJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9E3640", Offset = "0x9E1E40", VA = "0x1809E3640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x293C5C0", Offset = "0x293ADC0", VA = "0x18293C5C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6292880", Offset = "0x6291080", VA = "0x186292880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int HNDHCEBPPOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9E3640", Offset = "0x9E1E40", VA = "0x1809E3640")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xD1C690", Offset = "0xD1AE90", VA = "0x180D1C690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int LFOFFNOPOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DA50", Offset = "0x6F4C250", VA = "0x186F4DA50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DA40", Offset = "0x6F4C240", VA = "0x186F4DA40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x95D280", Offset = "0x95BA80", VA = "0x18095D280")]
	private LGIPPHGAGPO(int MHPJBPKHONI, int NELOIEKKMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2337530", Offset = "0x2335D30", VA = "0x182337530")]
	public static LGIPPHGAGPO ONDNINCKMJE(int MHPJBPKHONI, int NELOIEKKMHO)
	{
		return default(LGIPPHGAGPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DA60", Offset = "0x6F4C260", VA = "0x186F4DA60")]
	public static LGIPPHGAGPO NNACBMAHIBF(int EEPGNNLBJAH, int GNDBPGCEJCB)
	{
		return default(LGIPPHGAGPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6F4DA70", Offset = "0x6F4C270", VA = "0x186F4DA70", Slot = "3")]
	public override string ToString()
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
