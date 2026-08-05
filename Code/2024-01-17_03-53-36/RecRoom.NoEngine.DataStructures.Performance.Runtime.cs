using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
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
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x605AE80", Offset = "0x6059C80", VA = "0x18605AE80")]
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
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
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
public static class MJJHENDPNEN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2411AC0", Offset = "0x24108C0", VA = "0x182411AC0")]
	public static PKNDPGHAMFG<T> DMEGGNCOGLO<T>(this T[] OJFDNDCDDBK) where T : notnull
	{
		return default(PKNDPGHAMFG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class AHAFAEPCPHH<T> : IDisposable, HBIGFOBCAJD, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HOFNAAMCEFO<T> HBMLJMADPHK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x368E410", Offset = "0x368D210", VA = "0x18368E410", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x368E4D0", Offset = "0x368D2D0", VA = "0x18368E4D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x368E2F0", Offset = "0x368D0F0", VA = "0x18368E2F0")]
	public static AHAFAEPCPHH<T> DCPHPAHCOGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x368C630", Offset = "0x368B430", VA = "0x18368C630")]
	internal AHAFAEPCPHH([In] HOFNAAMCEFO<T> OGNMHOKFLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x368E440", Offset = "0x368D240", VA = "0x18368E440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x368E460", Offset = "0x368D260", VA = "0x18368E460")]
	public void GEOOCPGLFNM(int KGLOPMIHJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x368E480", Offset = "0x368D280", VA = "0x18368E480", Slot = "8")]
	public HOFNAAMCEFO<T>.IBFGBGMAKKF GetEnumerator()
	{
		return default(HOFNAAMCEFO<T>.IBFGBGMAKKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x368E500", Offset = "0x368D300", VA = "0x18368E500", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x368E500", Offset = "0x368D300", VA = "0x18368E500", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct GPACJCFOOHI<T, U> : IEnumerable<T>, IEnumerable where U : GJKGDIINCPN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U GCMNODHKOEF;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9530", Offset = "0x1CF8330", VA = "0x181CF9530")]
	internal GPACJCFOOHI([In] U APCJIPBDNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x36FFF50", Offset = "0x36FED50", VA = "0x1836FFF50", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x36FFF50", Offset = "0x36FED50", VA = "0x1836FFF50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FAAGIIBGOEI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x22F9510", Offset = "0x22F8310", VA = "0x1822F9510")]
	public static GPACJCFOOHI<T, U> DCPHPAHCOGO<U>([In] U OJFDNDCDDBK) where U : GJKGDIINCPN<T>
	{
		return default(GPACJCFOOHI<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct BANEFPLJAIE<TSourceEnumerator, TSource, TResult> : HBIGFOBCAJD, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : HBIGFOBCAJD, GJKGDIINCPN<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private TSourceEnumerator KGNONAHAGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly LFLILBGHEGA<TSource, TResult> HBPDPGBODOF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3811B80", Offset = "0x3810980", VA = "0x183811B80", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public readonly TResult GCDIDLPMHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x46603F0", Offset = "0x465F1F0", VA = "0x1846603F0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x46600C0", Offset = "0x465EEC0", VA = "0x1846600C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3811F20", Offset = "0x3810D20", VA = "0x183811F20")]
	internal BANEFPLJAIE([In] TSourceEnumerator OJFDNDCDDBK, LFLILBGHEGA<TSource, TResult> KMDEKHPMOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3811D10", Offset = "0x3810B10", VA = "0x183811D10", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3811DA0", Offset = "0x3810BA0", VA = "0x183811DA0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3811C80", Offset = "0x3810A80", VA = "0x183811C80", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct PGCEIHEBNHC<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly U GCMNODHKOEF;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F430", Offset = "0x3F9E230", VA = "0x183F9F430")]
	internal PGCEIHEBNHC([In] U APCJIPBDNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3F9EFE0", Offset = "0x3F9DDE0", VA = "0x183F9EFE0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F2B0", Offset = "0x3F9E0B0", VA = "0x183F9F2B0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F2B0", Offset = "0x3F9E0B0", VA = "0x183F9F2B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class ACJBBCJIEBI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2194A80", Offset = "0x2193880", VA = "0x182194A80")]
	public static PGCEIHEBNHC<T, U> DCPHPAHCOGO<U>([In] U OJFDNDCDDBK) where U : IEnumerator<T>
	{
		return default(PGCEIHEBNHC<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IIMCLJDCJMB<TSourceEnumerator, TSource, TResult> : HBIGFOBCAJD, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : HBIGFOBCAJD, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private TSourceEnumerator KGNONAHAGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<TSource, TResult> HBPDPGBODOF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public readonly int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3811B80", Offset = "0x3810980", VA = "0x183811B80", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly TResult GCDIDLPMHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3811FA0", Offset = "0x3810DA0", VA = "0x183811FA0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3811E30", Offset = "0x3810C30", VA = "0x183811E30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3811F20", Offset = "0x3810D20", VA = "0x183811F20")]
	internal IIMCLJDCJMB([In] TSourceEnumerator OJFDNDCDDBK, Func<TSource, TResult> KMDEKHPMOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3811D10", Offset = "0x3810B10", VA = "0x183811D10", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3811DA0", Offset = "0x3810BA0", VA = "0x183811DA0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3811C80", Offset = "0x3810A80", VA = "0x183811C80", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class NIEHLNCHPFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27030A0", Offset = "0x2701EA0", VA = "0x1827030A0")]
	public static string DNHBGKPBHMD<T>(this IEnumerable<T> OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2705620", Offset = "0x2704420", VA = "0x182705620")]
	public static string DPNCLOHMGLB<T>(this IEnumerable<T> OJFDNDCDDBK, string DFNENOPLHEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class HLNDEPBFIII
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x25D2FF0", Offset = "0x25D1DF0", VA = "0x1825D2FF0")]
	public static bool EEHANHBIONH<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator OJFDNDCDDBK, [In] TArgs DJELKPGJPKM, [In] IAJFABMKLDM<TArgs, TSource, bool> LGHCGKOCGEA) where TSourceEnumerator : GJKGDIINCPN<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x25D2CD0", Offset = "0x25D1AD0", VA = "0x1825D2CD0")]
	public static int AFHODFECFAJ<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator OJFDNDCDDBK, [In] TArgs DJELKPGJPKM, IAJFABMKLDM<TArgs, TSource, bool> LGHCGKOCGEA) where TSourceEnumerator : GJKGDIINCPN<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x25D2E70", Offset = "0x25D1C70", VA = "0x1825D2E70")]
	public static bool DPJCNJNILEE<TSourceEnumerator, TSource>(this TSourceEnumerator OJFDNDCDDBK, [In] TSource KMBHPJEIFIH) where TSourceEnumerator : GJKGDIINCPN<TSource> where TSource : NGNFFLDCBFD<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x25D3180", Offset = "0x25D1F80", VA = "0x1825D3180")]
	public static int EPIPFFDFNCJ<TSourceEnumerator, TSource>(this TSourceEnumerator OJFDNDCDDBK, [In] TSource MBDKMNBCLGF) where TSourceEnumerator : GJKGDIINCPN<TSource> where TSource : NGNFFLDCBFD<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x25D33E0", Offset = "0x25D21E0", VA = "0x1825D33E0")]
	public static BANEFPLJAIE<TSourceEnumerator, TSource, TResult> PDMELBOFCNO<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator OJFDNDCDDBK, LFLILBGHEGA<TSource, TResult> KMDEKHPMOCN) where TSourceEnumerator : HBIGFOBCAJD, GJKGDIINCPN<TSource>
	{
		return default(BANEFPLJAIE<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x25D33E0", Offset = "0x25D21E0", VA = "0x1825D33E0")]
	public static IIMCLJDCJMB<TSourceEnumerator, TSource, TResult> GDOENCJFPAE<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator OJFDNDCDDBK, Func<TSource, TResult> KMDEKHPMOCN) where TSourceEnumerator : HBIGFOBCAJD, IEnumerator<TSource>
	{
		return default(IIMCLJDCJMB<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KHMDMIGFPAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x22FDE70", Offset = "0x22FCC70", VA = "0x1822FDE70")]
	public static bool AHNLMKAODMG<TSourceEnumerator>(TSourceEnumerator OJFDNDCDDBK) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2301C30", Offset = "0x2300A30", VA = "0x182301C30")]
	public static T NDJFEFOEKCK<TSourceEnumerator>(TSourceEnumerator OJFDNDCDDBK) where TSourceEnumerator : GJKGDIINCPN<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x22FDFE0", Offset = "0x22FCDE0", VA = "0x1822FDFE0")]
	public static T[] JDGADJEEEKK<TSourceEnumerator>(TSourceEnumerator OJFDNDCDDBK) where TSourceEnumerator : HBIGFOBCAJD, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x22FDEE0", Offset = "0x22FCCE0", VA = "0x1822FDEE0")]
	public static T DIEAKPPCFNK<TSourceEnumerator>(TSourceEnumerator OJFDNDCDDBK) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GJKGDIINCPN<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T GCDIDLPMHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HBIGFOBCAJD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LHMLHIAPMKJ<T> : GJKGDIINCPN<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct BNDKECGDKHD<T, U> : IEnumerable<T>, IEnumerable where U : LHMLHIAPMKJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly U GCMNODHKOEF;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x368D410", Offset = "0x368C210", VA = "0x18368D410")]
	internal BNDKECGDKHD([In] U APCJIPBDNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3335C30", Offset = "0x3334A30", VA = "0x183335C30", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3700000", Offset = "0x36FEE00", VA = "0x183700000", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3700000", Offset = "0x36FEE00", VA = "0x183700000", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JDCKGDEDMKI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x22F94E0", Offset = "0x22F82E0", VA = "0x1822F94E0")]
	public static BNDKECGDKHD<T, U> DCPHPAHCOGO<U>([In] U OJFDNDCDDBK) where U : LHMLHIAPMKJ<T>
	{
		return default(BNDKECGDKHD<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public readonly struct PKNDPGHAMFG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct BNMHCGNFCEO : HBIGFOBCAJD, GJKGDIINCPN<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] KGNONAHAGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int PGCOBEGLKCH;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly int OBAHNCBLFMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x1D11C20", Offset = "0x1D10A20", VA = "0x181D11C20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T GCDIDLPMHMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x46B2D70", Offset = "0x46B1B70", VA = "0x1846B2D70", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x46B2800", Offset = "0x46B1600", VA = "0x1846B2800", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x46B2AB0", Offset = "0x46B18B0", VA = "0x1846B2AB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x17A37A0", Offset = "0x17A25A0", VA = "0x1817A37A0")]
		private BNMHCGNFCEO(T[] OJFDNDCDDBK, int HPLKFBKKIBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x46B25D0", Offset = "0x46B13D0", VA = "0x1846B25D0")]
		public static BNMHCGNFCEO DCPHPAHCOGO(T[] OJFDNDCDDBK)
		{
			return default(BNMHCGNFCEO);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1D11C80", Offset = "0x1D10A80", VA = "0x181D11C80", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1D11CB0", Offset = "0x1D10AB0", VA = "0x181D11CB0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly T[] JFNGMJAFEIP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int PIOKOHDJLOG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1D11C20", Offset = "0x1D10A20", VA = "0x181D11C20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x274F230", Offset = "0x274E030", VA = "0x18274F230")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8C4200", Offset = "0x8C3000", VA = "0x1808C4200")]
	internal PKNDPGHAMFG(T[] IPODKPLEDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4045EB0", Offset = "0x4044CB0", VA = "0x184045EB0")]
	public static PKNDPGHAMFG<T> CABPEDJKFDA()
	{
		return default(PKNDPGHAMFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
	public IEnumerable<T> CMNAKMCAOFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4046120", Offset = "0x4044F20", VA = "0x184046120")]
	public ReadOnlySpan<T> LKMKEOLPLNF()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4046000", Offset = "0x4044E00", VA = "0x184046000")]
	public GPACJCFOOHI<T, PKNDPGHAMFG<T>.BNMHCGNFCEO> IAEHKJEEAPL()
	{
		return default(GPACJCFOOHI<T, BNMHCGNFCEO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4045F70", Offset = "0x4044D70", VA = "0x184045F70")]
	public BNMHCGNFCEO FEJLIMNMPDN()
	{
		return default(BNMHCGNFCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4045E30", Offset = "0x4044C30", VA = "0x184045E30")]
	public IEnumerator<T> BCGCEOCJJAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x40461B0", Offset = "0x4044FB0", VA = "0x1840461B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class PJMMHMNACMK
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2404900", Offset = "0x2403700", VA = "0x182404900")]
	public static PKNDPGHAMFG<T> MAMPKCKNDOO<T>(params T[] IPODKPLEDFE) where T : notnull
	{
		return default(PKNDPGHAMFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x605AF00", Offset = "0x6059D00", VA = "0x18605AF00")]
	public static Stream IHOGDDNFDHI(this PKNDPGHAMFG<byte> OJFDNDCDDBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DebuggerTypeProxy(typeof(HOFNAAMCEFO<>.DBFHOHHNBGN))]
public struct HOFNAAMCEFO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct IBFGBGMAKKF : HBIGFOBCAJD, LHMLHIAPMKJ<T>, GJKGDIINCPN<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly T[] OCHKBLHONOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int GICEMHGEIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int PGCOBEGLKCH;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly int OBAHNCBLFMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1D2A110", Offset = "0x1D28F10", VA = "0x181D2A110", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public readonly T GCDIDLPMHMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x37EAE90", Offset = "0x37E9C90", VA = "0x1837EAE90", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private readonly T FFJNIFENMLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x37EA6D0", Offset = "0x37E94D0", VA = "0x1837EA6D0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x37EA960", Offset = "0x37E9760", VA = "0x1837EA960", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x37EAC70", Offset = "0x37E9A70", VA = "0x1837EAC70", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1D11120", Offset = "0x1D0FF20", VA = "0x181D11120")]
		internal IBFGBGMAKKF(T[] PNAEPBNICFF, int KGLOPMIHJGF, int HPLKFBKKIBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x37EA670", Offset = "0x37E9470", VA = "0x1837EA670")]
		public static IBFGBGMAKKF DCPHPAHCOGO(HOFNAAMCEFO<T> OJFDNDCDDBK)
		{
			return default(IBFGBGMAKKF);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x32F0050", Offset = "0x32EEE50", VA = "0x1832F0050", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1D110C0", Offset = "0x1D0FEC0", VA = "0x181D110C0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct NPHIONFBODF : HBIGFOBCAJD, GJKGDIINCPN<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IBFGBGMAKKF GCMNODHKOEF;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int OBAHNCBLFMM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3E0FC30", Offset = "0x3E0EA30", VA = "0x183E0FC30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public readonly T GCDIDLPMHMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3E100E0", Offset = "0x3E0EEE0", VA = "0x183E100E0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3E0FD80", Offset = "0x3E0EB80", VA = "0x183E0FD80", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3E0FE50", Offset = "0x3E0EC50", VA = "0x183E0FE50", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9530", Offset = "0x1CF8330", VA = "0x181CF9530")]
		private NPHIONFBODF([In] IBFGBGMAKKF APCJIPBDNML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3E0FB80", Offset = "0x3E0E980", VA = "0x183E0FB80")]
		public static NPHIONFBODF DCPHPAHCOGO([In] HOFNAAMCEFO<T> OJFDNDCDDBK)
		{
			return default(NPHIONFBODF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3E0FCA0", Offset = "0x3E0EAA0", VA = "0x183E0FCA0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3E0FCE0", Offset = "0x3E0EAE0", VA = "0x183E0FCE0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3E0FC60", Offset = "0x3E0EA60", VA = "0x183E0FC60", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class DBFHOHHNBGN
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal T[] OCHKBLHONOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal int GICEMHGEIIC;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x375E500", Offset = "0x375D300", VA = "0x18375E500")]
	public static HOFNAAMCEFO<T> DCPHPAHCOGO()
	{
		return default(HOFNAAMCEFO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x375E720", Offset = "0x375D520", VA = "0x18375E720")]
	public static HOFNAAMCEFO<T> OBBACKGGMCC(int IBODGIFCPFK)
	{
		return default(HOFNAAMCEFO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x375E610", Offset = "0x375D410", VA = "0x18375E610")]
	public static HOFNAAMCEFO<T> GCLDBIPAFBD(int KGLOPMIHJGF)
	{
		return default(HOFNAAMCEFO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x17A37A0", Offset = "0x17A25A0", VA = "0x1817A37A0")]
	internal HOFNAAMCEFO(T[] PNAEPBNICFF, int KGLOPMIHJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x36AF3D0", Offset = "0x36AE1D0", VA = "0x1836AF3D0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class OLNCBDKNBIN
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2751580", Offset = "0x2750380", VA = "0x182751580")]
	public static void HLIABIFOACE<T>(this HOFNAAMCEFO<T> OJFDNDCDDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x27540F0", Offset = "0x2752EF0", VA = "0x1827540F0")]
	public static string LGADDHAFFLH<T>([In] this HOFNAAMCEFO<T> OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
	public static T[] FGNKEMCBAOB<T>([In] this HOFNAAMCEFO<T> OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x274F230", Offset = "0x274E030", VA = "0x18274F230")]
	public static T NAKCAFGMIJA<T>([In] this HOFNAAMCEFO<T> OJFDNDCDDBK, int HBLLIHHIKIO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x274F230", Offset = "0x274E030", VA = "0x18274F230")]
	public static T CLHPHBJKNJD<T>(this HOFNAAMCEFO<T> OJFDNDCDDBK, int HBLLIHHIKIO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x274EF50", Offset = "0x274DD50", VA = "0x18274EF50")]
	public static T AGKBLHFNDBA<T>([In] this HOFNAAMCEFO<T> OJFDNDCDDBK, int HBLLIHHIKIO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x274F550", Offset = "0x274E350", VA = "0x18274F550")]
	public static void COLNBMOOCNM<T>(this HOFNAAMCEFO<T> OJFDNDCDDBK, int HBLLIHHIKIO, [In] T MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2756520", Offset = "0x2755320", VA = "0x182756520")]
	public static void OFJFFJOKKAH<T>(this HOFNAAMCEFO<T> OJFDNDCDDBK, int HBLLIHHIKIO, T MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D2A110", Offset = "0x1D28F10", VA = "0x181D2A110")]
	public static int NGBPPAGDCLA<T>([In] this HOFNAAMCEFO<T> OJFDNDCDDBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2756160", Offset = "0x2754F60", VA = "0x182756160")]
	public static ReadOnlySpan<T> LKMKEOLPLNF<T>([In] this HOFNAAMCEFO<T> OJFDNDCDDBK)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2756340", Offset = "0x2755140", VA = "0x182756340")]
	public static T[] OCADIJHLOAN<T>([In] this HOFNAAMCEFO<T> OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2754070", Offset = "0x2752E70", VA = "0x182754070")]
	public static T[] KPGBIOGNAJH<T>(this HOFNAAMCEFO<T> OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2753FE0", Offset = "0x2752DE0", VA = "0x182753FE0")]
	public static PKNDPGHAMFG<T> IIGKGBKKJLF<T>(this HOFNAAMCEFO<T> OJFDNDCDDBK)
	{
		return default(PKNDPGHAMFG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x274FBC0", Offset = "0x274E9C0", VA = "0x18274FBC0")]
	public static void EHPBILHDFGD<T>(this HOFNAAMCEFO<T> OJFDNDCDDBK, [In] T MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x274F0A0", Offset = "0x274DEA0", VA = "0x18274F0A0")]
	public static void ALEPLDFLOHK<T>(this HOFNAAMCEFO<T> OJFDNDCDDBK, T MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x27565F0", Offset = "0x27553F0", VA = "0x1827565F0")]
	public static void OGELPCMCEOG<T>(this HOFNAAMCEFO<T> OJFDNDCDDBK, int HPLKFBKKIBG, [In] T MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x27562D0", Offset = "0x27550D0", VA = "0x1827562D0")]
	public static void MLHCIMDJFLC<T>(this HOFNAAMCEFO<T> OJFDNDCDDBK, int HPLKFBKKIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x274F1D0", Offset = "0x274DFD0", VA = "0x18274F1D0")]
	public static T BIFDLNLKDNL<T>(this HOFNAAMCEFO<T> OJFDNDCDDBK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x274FFE0", Offset = "0x274EDE0", VA = "0x18274FFE0")]
	public static void GEOOCPGLFNM<T>(this HOFNAAMCEFO<T> OJFDNDCDDBK, int KGLOPMIHJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2751620", Offset = "0x2750420", VA = "0x182751620")]
	private static void HNINIKMKGMI<T>(this HOFNAAMCEFO<T> OJFDNDCDDBK, int IBODGIFCPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2755FE0", Offset = "0x2754DE0", VA = "0x182755FE0")]
	public static void LJNFEICKFHE<T>(this HOFNAAMCEFO<T> OJFDNDCDDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2756230", Offset = "0x2755030", VA = "0x182756230")]
	public static bool MBIGHBBGAAB<T>(this HOFNAAMCEFO<T> OJFDNDCDDBK, [In] T MBDKMNBCLGF) where T : NGNFFLDCBFD<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x248FD80", Offset = "0x248EB80", VA = "0x18248FD80")]
	public static bool AIJOHIMAHPK<T>([In] this HOFNAAMCEFO<T> OJFDNDCDDBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2751540", Offset = "0x2750340", VA = "0x182751540")]
	public static bool HADLHMCLJAO<T>([In] this HOFNAAMCEFO<T> OJFDNDCDDBK, int HBLLIHHIKIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x26676D0", Offset = "0x26664D0", VA = "0x1826676D0")]
	public static HOFNAAMCEFO<T>.NPHIONFBODF BCGCEOCJJAB<T>([In] this HOFNAAMCEFO<T> OJFDNDCDDBK)
	{
		return default(HOFNAAMCEFO<T>.NPHIONFBODF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x26676D0", Offset = "0x26664D0", VA = "0x1826676D0")]
	public static HOFNAAMCEFO<T>.IBFGBGMAKKF BBMJABNDIJE<T>(this HOFNAAMCEFO<T> OJFDNDCDDBK)
	{
		return default(HOFNAAMCEFO<T>.IBFGBGMAKKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2717110", Offset = "0x2715F10", VA = "0x182717110")]
	public static GPACJCFOOHI<T, HOFNAAMCEFO<T>.NPHIONFBODF> HAAAGABAHDF<T>([In] this HOFNAAMCEFO<T> OJFDNDCDDBK)
	{
		return default(GPACJCFOOHI<T, HOFNAAMCEFO<T>.NPHIONFBODF>);
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
