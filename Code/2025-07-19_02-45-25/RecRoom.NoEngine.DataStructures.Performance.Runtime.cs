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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x82DBD60", Offset = "0x82DAD60", VA = "0x1882DBD60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DEAHKHKHNAM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x39D7AF0", Offset = "0x39D6AF0", VA = "0x1839D7AF0")]
	public static LKOHIDHAAFB<T> PINNJCMAPIN<T>(this T[] OLHDOIOOPGE) where T : notnull
	{
		return default(LKOHIDHAAFB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3A8D1E0", Offset = "0x3A8C1E0", VA = "0x183A8D1E0")]
	public static BBLBDLCFINE<T, ELKDJKHAHBD<T>> ONBLHJGJNNE<T>(this T[] OLHDOIOOPGE) where T : notnull
	{
		return default(BBLBDLCFINE<T, ELKDJKHAHBD<T>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class LHAEDLILFFM<T> : IDisposable, NHJLFFEJPHF, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private PBFBDJCALEG<T> POAHHDEFLKI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5474060", Offset = "0x5473060", VA = "0x185474060", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5473FD0", Offset = "0x5472FD0", VA = "0x185473FD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5474090", Offset = "0x5473090", VA = "0x185474090")]
	public static LHAEDLILFFM<T> MPFKOOIPONO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x48ED340", Offset = "0x48EC340", VA = "0x1848ED340")]
	internal LHAEDLILFFM([In] PBFBDJCALEG<T> JOEHPNNMIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5474000", Offset = "0x5473000", VA = "0x185474000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5473FB0", Offset = "0x5472FB0", VA = "0x185473FB0")]
	public void CIFLCDIPKFC(int MFFPIAPMHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5474020", Offset = "0x5473020", VA = "0x185474020", Slot = "8")]
	public PBFBDJCALEG<T>.EBBFPFAPGCI GetEnumerator()
	{
		return default(PBFBDJCALEG<T>.EBBFPFAPGCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x54741A0", Offset = "0x54731A0", VA = "0x1854741A0", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x54741A0", Offset = "0x54731A0", VA = "0x1854741A0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct CPMJCNKKGMI<T, U> : IEnumerable<T>, IEnumerable where U : KHGNEGIENIG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U CGBNGKJFFEA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x11FD640", Offset = "0x11FC640", VA = "0x1811FD640")]
	internal CPMJCNKKGMI([In] U CGEANDCJOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5470090", Offset = "0x546F090", VA = "0x185470090", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5470090", Offset = "0x546F090", VA = "0x185470090", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JENKOHNPIEL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3D71600", Offset = "0x3D70600", VA = "0x183D71600")]
	public static CPMJCNKKGMI<T, U> MPFKOOIPONO<U>([In] U OLHDOIOOPGE) where U : KHGNEGIENIG<T>
	{
		return default(CPMJCNKKGMI<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HIPGPIKJNHF
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C79C90", Offset = "0x3C78C90", VA = "0x183C79C90")]
	public static int JHCCKPLGFOI<T, U>([In] this CPMJCNKKGMI<T, U> OLHDOIOOPGE) where U : KHGNEGIENIG<T>, NHJLFFEJPHF
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class AMEKHKMMPLA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5270B40", Offset = "0x526FB40", VA = "0x185270B40")]
	public static BBLBDLCFINE<T, ELKDJKHAHBD<T>> MPFKOOIPONO([In] T[] OLHDOIOOPGE)
	{
		return default(BBLBDLCFINE<T, ELKDJKHAHBD<T>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct BBLBDLCFINE<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U CGBNGKJFFEA;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2C8AE40", Offset = "0x2C89E40", VA = "0x182C8AE40")]
	internal BBLBDLCFINE([In] U CGEANDCJOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2C8AA50", Offset = "0x2C89A50", VA = "0x182C8AA50", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x633C520", Offset = "0x633B520", VA = "0x18633C520", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x633C520", Offset = "0x633B520", VA = "0x18633C520", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FCANAAKAAFG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3D71F30", Offset = "0x3D70F30", VA = "0x183D71F30")]
	public static BBLBDLCFINE<T, U> MPFKOOIPONO<U>([In] U OLHDOIOOPGE) where U : IEnumerator<T>
	{
		return default(BBLBDLCFINE<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PPBCKIBLPDI
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3E42A30", Offset = "0x3E41A30", VA = "0x183E42A30")]
	public static BBLBDLCFINE<TResult, EHMCJGLDNOF<TSourceEnumerator, TSource, TResult>> NGMPFCNCNDC<TResult, TSourceEnumerator, TSource>([In] this BBLBDLCFINE<TSource, TSourceEnumerator> OLHDOIOOPGE, Func<TSource, TResult> JMNAPAAMBOF) where TSourceEnumerator : NHJLFFEJPHF, IEnumerator<TSource>
	{
		return default(BBLBDLCFINE<TResult, EHMCJGLDNOF<TSourceEnumerator, TSource, TResult>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct ELKDJKHAHBD<T> : IEnumerator<T>, IEnumerator, IDisposable, NHJLFFEJPHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly T[] BLIKCHMHFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int LIKLAKLPDOC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly T AJOLFNCECJD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x490E470", Offset = "0x490D470", VA = "0x18490E470", Slot = "4")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x490E420", Offset = "0x490D420", VA = "0x18490E420", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2A35640", Offset = "0x2A34640", VA = "0x182A35640", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xD25030", Offset = "0xD24030", VA = "0x180D25030")]
	private ELKDJKHAHBD(T[] OLHDOIOOPGE, int HLGKMAPOEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x490E3D0", Offset = "0x490D3D0", VA = "0x18490E3D0")]
	public static ELKDJKHAHBD<T> MPFKOOIPONO(T[] OLHDOIOOPGE)
	{
		return default(ELKDJKHAHBD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2A35690", Offset = "0x2A34690", VA = "0x182A35690", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2A34450", Offset = "0x2A33450", VA = "0x182A34450", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct EHMCJGLDNOF<TSourceEnumerator, TSource, TResult> : NHJLFFEJPHF, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : NHJLFFEJPHF, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private TSourceEnumerator BLIKCHMHFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<TSource, TResult> KBDACKMLHBJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public readonly int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4902AE0", Offset = "0x4901AE0", VA = "0x184902AE0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly TResult AJOLFNCECJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4902CF0", Offset = "0x4901CF0", VA = "0x184902CF0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4902C70", Offset = "0x4901C70", VA = "0x184902C70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2A4FD60", Offset = "0x2A4ED60", VA = "0x182A4FD60")]
	internal EHMCJGLDNOF([In] TSourceEnumerator OLHDOIOOPGE, Func<TSource, TResult> JMNAPAAMBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4902B70", Offset = "0x4901B70", VA = "0x184902B70", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4902BB0", Offset = "0x4901BB0", VA = "0x184902BB0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4902A20", Offset = "0x4901A20", VA = "0x184902A20", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class IGPBHBPKILA
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCD70", Offset = "0x3CBBD70", VA = "0x183CBCD70")]
	public static string HGEOEAKHAAK<T>(this IEnumerable<T> OLHDOIOOPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3CA5BA0", Offset = "0x3CA4BA0", VA = "0x183CA5BA0")]
	public static string AKMCBENLNCN<T>(this IEnumerable<T> OLHDOIOOPGE, string PDDOBCCPAHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BOJAADGNEKI
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x39E3500", Offset = "0x39E2500", VA = "0x1839E3500")]
	public static bool MCGGCINPOEA<TSourceEnumerator, TSource>(this TSourceEnumerator OLHDOIOOPGE, [In] TSource ADPMEPGEIDH) where TSourceEnumerator : KHGNEGIENIG<TSource> where TSource : PNBPCEACENO<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x39E3030", Offset = "0x39E2030", VA = "0x1839E3030")]
	public static int IFAGMGGDCEN<TSourceEnumerator, TSource>(this TSourceEnumerator OLHDOIOOPGE, [In] TSource IOALKPFEKEK) where TSourceEnumerator : KHGNEGIENIG<TSource> where TSource : PNBPCEACENO<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x39E3680", Offset = "0x39E2680", VA = "0x1839E3680")]
	public static EHMCJGLDNOF<TSourceEnumerator, TSource, TResult> NGMPFCNCNDC<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator OLHDOIOOPGE, Func<TSource, TResult> JMNAPAAMBOF) where TSourceEnumerator : NHJLFFEJPHF, IEnumerator<TSource>
	{
		return default(EHMCJGLDNOF<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x39E3290", Offset = "0x39E2290", VA = "0x1839E3290")]
	public static int IFNMJPAILEG<TSourceEnumerator, TSource>(this TSourceEnumerator OLHDOIOOPGE, [In] TSource IOALKPFEKEK) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KHGNEGIENIG<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T AJOLFNCECJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NHJLFFEJPHF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BHDNGCCJPDJ<T> : KHGNEGIENIG<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct LEDFJLHKFOE<T, U> : IEnumerable<T>, IEnumerable where U : BHDNGCCJPDJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly U CGBNGKJFFEA;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5470190", Offset = "0x546F190", VA = "0x185470190")]
	internal LEDFJLHKFOE([In] U CGEANDCJOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x449B9F0", Offset = "0x449A9F0", VA = "0x18449B9F0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5470100", Offset = "0x546F100", VA = "0x185470100", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5470100", Offset = "0x546F100", VA = "0x185470100", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class EFFFGLHOCOM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3D715D0", Offset = "0x3D705D0", VA = "0x183D715D0")]
	public static LEDFJLHKFOE<T, U> MPFKOOIPONO<U>([In] U OLHDOIOOPGE) where U : BHDNGCCJPDJ<T>
	{
		return default(LEDFJLHKFOE<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public readonly struct LKOHIDHAAFB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct DHIJEMBPEDB : NHJLFFEJPHF, KHGNEGIENIG<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] BLIKCHMHFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int LIKLAKLPDOC;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly int JHCCKPLGFOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2A35640", Offset = "0x2A34640", VA = "0x182A35640", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T AJOLFNCECJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2A35600", Offset = "0x2A34600", VA = "0x182A35600", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6E95D10", Offset = "0x6E94D10", VA = "0x186E95D10", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6E96080", Offset = "0x6E95080", VA = "0x186E96080", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xD25030", Offset = "0xD24030", VA = "0x180D25030")]
		private DHIJEMBPEDB(T[] OLHDOIOOPGE, int HLGKMAPOEBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x490E3D0", Offset = "0x490D3D0", VA = "0x18490E3D0")]
		public static DHIJEMBPEDB MPFKOOIPONO(T[] OLHDOIOOPGE)
		{
			return default(DHIJEMBPEDB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2A35690", Offset = "0x2A34690", VA = "0x182A35690", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2A34450", Offset = "0x2A33450", VA = "0x182A34450", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly T[] CGIHIBHPDMC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BJKDLCPHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2A35640", Offset = "0x2A34640", VA = "0x182A35640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T LJHNMNJFPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2A34750", Offset = "0x2A33750", VA = "0x182A34750")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xE50960", Offset = "0xE4F960", VA = "0x180E50960")]
	internal LKOHIDHAAFB(T[] MFIJBPNIELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x54B6720", Offset = "0x54B5720", VA = "0x1854B6720")]
	public static LKOHIDHAAFB<T> JBLEAIPIMOC()
	{
		return default(LKOHIDHAAFB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
	public IEnumerable<T> EMBFONGEJIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x54B6690", Offset = "0x54B5690", VA = "0x1854B6690")]
	public ReadOnlySpan<T> IBJKPLDKMGD()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x54B6470", Offset = "0x54B5470", VA = "0x1854B6470")]
	public CPMJCNKKGMI<T, LKOHIDHAAFB<T>.DHIJEMBPEDB> BBFEEMEFCMG()
	{
		return default(CPMJCNKKGMI<T, DHIJEMBPEDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x54B6580", Offset = "0x54B5580", VA = "0x1854B6580")]
	public DHIJEMBPEDB EPOKEHCMMNK()
	{
		return default(DHIJEMBPEDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x54B6610", Offset = "0x54B5610", VA = "0x1854B6610")]
	public IEnumerator<T> GHDHEBFDHCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x54B67D0", Offset = "0x54B57D0", VA = "0x1854B67D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class AAFMBAODCFJ
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x318E200", Offset = "0x318D200", VA = "0x18318E200")]
	public static LKOHIDHAAFB<T> CLLKBLMFADF<T>(params T[] MFIJBPNIELL) where T : notnull
	{
		return default(LKOHIDHAAFB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82DBD00", Offset = "0x82DAD00", VA = "0x1882DBD00")]
	public static Stream NMBABJDEJCM(this LKOHIDHAAFB<byte> OLHDOIOOPGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DebuggerTypeProxy(typeof(PBFBDJCALEG<>.IPGCCLBNKBJ))]
public struct PBFBDJCALEG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct EBBFPFAPGCI : NHJLFFEJPHF, BHDNGCCJPDJ<T>, KHGNEGIENIG<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly T[] AIGMLBHMEKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int ECHEKFFEEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int LIKLAKLPDOC;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly int JHCCKPLGFOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xEE6980", Offset = "0xEE5980", VA = "0x180EE6980", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public readonly T AJOLFNCECJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x48E9340", Offset = "0x48E8340", VA = "0x1848E9340", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public readonly T NFOFJBOAIKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x48E8810", Offset = "0x48E7810", VA = "0x1848E8810")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private readonly T JLFMDIKBPLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x48E8A30", Offset = "0x48E7A30", VA = "0x1848E8A30", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x48E8CC0", Offset = "0x48E7CC0", VA = "0x1848E8CC0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x48E9050", Offset = "0x48E8050", VA = "0x1848E9050", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x48E9230", Offset = "0x48E8230", VA = "0x1848E9230")]
		internal EBBFPFAPGCI(T[] NKOHPCLOFJA, int MFFPIAPMHCN, int HLGKMAPOEBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x48E8B70", Offset = "0x48E7B70", VA = "0x1848E8B70")]
		public static EBBFPFAPGCI MPFKOOIPONO(PBFBDJCALEG<T> OLHDOIOOPGE)
		{
			return default(EBBFPFAPGCI);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x48E8BD0", Offset = "0x48E7BD0", VA = "0x1848E8BD0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x48E8BE0", Offset = "0x48E7BE0", VA = "0x1848E8BE0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct IAIKJCEGMMG : NHJLFFEJPHF, KHGNEGIENIG<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EBBFPFAPGCI CGBNGKJFFEA;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int JHCCKPLGFOI
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5006990", Offset = "0x5005990", VA = "0x185006990", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public readonly T AJOLFNCECJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x5006F30", Offset = "0x5005F30", VA = "0x185006F30", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5006BA0", Offset = "0x5005BA0", VA = "0x185006BA0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5006D60", Offset = "0x5005D60", VA = "0x185006D60", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x11FD640", Offset = "0x11FC640", VA = "0x1811FD640")]
		private IAIKJCEGMMG([In] EBBFPFAPGCI CGEANDCJOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x50069C0", Offset = "0x50059C0", VA = "0x1850069C0")]
		public static IAIKJCEGMMG MPFKOOIPONO([In] PBFBDJCALEG<T> OLHDOIOOPGE)
		{
			return default(IAIKJCEGMMG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5006A70", Offset = "0x5005A70", VA = "0x185006A70", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5006AB0", Offset = "0x5005AB0", VA = "0x185006AB0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5006950", Offset = "0x5005950", VA = "0x185006950", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class IPGCCLBNKBJ
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal T[] AIGMLBHMEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal int ECHEKFFEEGL;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5A1FF80", Offset = "0x5A1EF80", VA = "0x185A1FF80")]
	public static PBFBDJCALEG<T> MPFKOOIPONO()
	{
		return default(PBFBDJCALEG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5A1FED0", Offset = "0x5A1EED0", VA = "0x185A1FED0")]
	public static PBFBDJCALEG<T> JDMIEAGOLJM(int HDEDDOIEPID)
	{
		return default(PBFBDJCALEG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xD25030", Offset = "0xD24030", VA = "0x180D25030")]
	internal PBFBDJCALEG(T[] NKOHPCLOFJA, int MFFPIAPMHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5A20020", Offset = "0x5A1F020", VA = "0x185A20020", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class ECHKNCGPBAL
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate int BHIONNKFPMD<TCtx, T>([In] TCtx GNKNFNHHFGL, T MLCJFBKFHOP, T FPNPAOBAPAE);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3ABCF80", Offset = "0x3ABBF80", VA = "0x183ABCF80")]
	public static void GBLOHGCCHFB<T>(this PBFBDJCALEG<T> OLHDOIOOPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3AC0B30", Offset = "0x3ABFB30", VA = "0x183AC0B30")]
	public static string OLHBDOCHLLE<T>([In] this PBFBDJCALEG<T> OLHDOIOOPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
	public static T[] KJMLNEOCHOM<T>([In] this PBFBDJCALEG<T> OLHDOIOOPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3ABDAB0", Offset = "0x3ABCAB0", VA = "0x183ABDAB0")]
	public static T LMKONLJOAEP<T>([In] this PBFBDJCALEG<T> OLHDOIOOPGE, int GGLNBEGGDDO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3ABDB30", Offset = "0x3ABCB30", VA = "0x183ABDB30")]
	public static T KECBIGMGKEM<T>(this PBFBDJCALEG<T> OLHDOIOOPGE, int GGLNBEGGDDO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD6C0", Offset = "0x3ABC6C0", VA = "0x183ABD6C0")]
	public static T INGPFHIIPNK<T>([In] this PBFBDJCALEG<T> OLHDOIOOPGE, int GGLNBEGGDDO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3AC01C0", Offset = "0x3ABF1C0", VA = "0x183AC01C0")]
	public static void ODADMGGOEJG<T>(this PBFBDJCALEG<T> OLHDOIOOPGE, int GGLNBEGGDDO, [In] T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3EF0", Offset = "0x3AC2EF0", VA = "0x183AC3EF0")]
	public static void PJDEOKMFABN<T>(this PBFBDJCALEG<T> OLHDOIOOPGE, int GGLNBEGGDDO, T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xEE6980", Offset = "0xEE5980", VA = "0x180EE6980")]
	public static int JFHJAFBIKCK<T>([In] this PBFBDJCALEG<T> OLHDOIOOPGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD4F0", Offset = "0x3ABC4F0", VA = "0x183ABD4F0")]
	public static ReadOnlySpan<T> IBJKPLDKMGD<T>([In] this PBFBDJCALEG<T> OLHDOIOOPGE)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3ABFE00", Offset = "0x3ABEE00", VA = "0x183ABFE00")]
	public static T[] MOIKGEAEPDH<T>([In] this PBFBDJCALEG<T> OLHDOIOOPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD830", Offset = "0x3ABC830", VA = "0x183ABD830")]
	public static T JFMMHLBFBAH<T>([In] this PBFBDJCALEG<T> OLHDOIOOPGE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3D60", Offset = "0x3AC2D60", VA = "0x183AC3D60")]
	public static T[] OPMBJIOHAKC<T>(this PBFBDJCALEG<T> OLHDOIOOPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9690", Offset = "0x3AB8690", VA = "0x183AB9690")]
	public static LKOHIDHAAFB<T> BBIBMNCHAIH<T>(this PBFBDJCALEG<T> OLHDOIOOPGE)
	{
		return default(LKOHIDHAAFB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC7B0", Offset = "0x3ABB7B0", VA = "0x183ABC7B0")]
	public static void DOPEKGIEJEC<T>(this PBFBDJCALEG<T> OLHDOIOOPGE, [In] T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC5F0", Offset = "0x3ABB5F0", VA = "0x183ABC5F0")]
	public static void DCDOMAMJBPF<T>(this PBFBDJCALEG<T> OLHDOIOOPGE, T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3ABCE50", Offset = "0x3ABBE50", VA = "0x183ABCE50")]
	public static void FONPHIPLFMK<T>(this PBFBDJCALEG<T> OLHDOIOOPGE, int HLGKMAPOEBE, [In] T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9720", Offset = "0x3AB8720", VA = "0x183AB9720")]
	public static void BDGHIPHJADO<T>(this PBFBDJCALEG<T> OLHDOIOOPGE, int HLGKMAPOEBE, [In] PBFBDJCALEG<T> NCIPNLHDHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3ABCC70", Offset = "0x3ABBC70", VA = "0x183ABCC70")]
	public static void FELJEFGHNJH<T>(this PBFBDJCALEG<T> OLHDOIOOPGE, int HLGKMAPOEBE, T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC4F0", Offset = "0x3ABB4F0", VA = "0x183ABC4F0")]
	public static void CKPCCNNFBHK<T>(this PBFBDJCALEG<T> OLHDOIOOPGE, int HLGKMAPOEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9630", Offset = "0x3AB8630", VA = "0x183AB9630")]
	public static T AEBINFABELK<T>(this PBFBDJCALEG<T> OLHDOIOOPGE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9A90", Offset = "0x3AB8A90", VA = "0x183AB9A90")]
	public static void CIFLCDIPKFC<T>(this PBFBDJCALEG<T> OLHDOIOOPGE, int MFFPIAPMHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE180", Offset = "0x3ABD180", VA = "0x183ABE180")]
	private static void LHKKJKNLHBG<T>(this PBFBDJCALEG<T> OLHDOIOOPGE, int HDEDDOIEPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD920", Offset = "0x3ABC920", VA = "0x183ABD920")]
	public static void JPJFAMEFLHG<T>(this PBFBDJCALEG<T> OLHDOIOOPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9460", Offset = "0x3AB8460", VA = "0x183AB9460")]
	public static PBFBDJCALEG<T> AABAGJPEDHJ<T>([In] this PBFBDJCALEG<T> OLHDOIOOPGE, FKPMPJBBCNP<T, T> NLJAIAHDDEP)
	{
		return default(PBFBDJCALEG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3ABFF30", Offset = "0x3ABEF30", VA = "0x183ABFF30")]
	public static int NLLCCAHJGPF<T>([In] this PBFBDJCALEG<T> OLHDOIOOPGE, T IOALKPFEKEK) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x324AD50", Offset = "0x3249D50", VA = "0x18324AD50")]
	public static bool MBIHOFJOLNE<T>([In] this PBFBDJCALEG<T> OLHDOIOOPGE, T IOALKPFEKEK) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3ABFB70", Offset = "0x3ABEB70", VA = "0x183ABFB70")]
	public static bool LKIPLGLLFFP<T>(this PBFBDJCALEG<T> OLHDOIOOPGE, T IOALKPFEKEK) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3AB97F0", Offset = "0x3AB87F0", VA = "0x183AB97F0")]
	public static bool CAHAJMDEGPB<T>(this PBFBDJCALEG<T> OLHDOIOOPGE, [In] T IOALKPFEKEK) where T : PNBPCEACENO<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9890", Offset = "0x3AB8890", VA = "0x183AB9890")]
	public static bool CEHLMEAICFL<T>([In] this PBFBDJCALEG<T> OLHDOIOOPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD850", Offset = "0x3ABC850", VA = "0x183ABD850")]
	public static bool JOBOMIDNLPK<T>([In] this PBFBDJCALEG<T> OLHDOIOOPGE, int GGLNBEGGDDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3AB97C0", Offset = "0x3AB87C0", VA = "0x183AB97C0")]
	public static void BINLGCOLAPM<T, TCtx>(this PBFBDJCALEG<T> OLHDOIOOPGE, [In] TCtx GNKNFNHHFGL, BHIONNKFPMD<TCtx, T> LJALCDKMFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD430", Offset = "0x3ABC430", VA = "0x183ABD430")]
	private static void HGOCMINIIHP<T, TCtx>(PBFBDJCALEG<T> OLHDOIOOPGE, [In] TCtx GNKNFNHHFGL, BHIONNKFPMD<TCtx, T> LJALCDKMFLE, int NEPDMCALAGH, int BCOPEEDBNEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3ABCFE0", Offset = "0x3ABBFE0", VA = "0x183ABCFE0")]
	private static int HFECFJMGBFD<T, TCtx>(PBFBDJCALEG<T> OLHDOIOOPGE, [In] TCtx GNKNFNHHFGL, BHIONNKFPMD<TCtx, T> LJALCDKMFLE, int NEPDMCALAGH, int BCOPEEDBNEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x39DD0F0", Offset = "0x39DC0F0", VA = "0x1839DD0F0")]
	public static PBFBDJCALEG<T>.IAIKJCEGMMG GHDHEBFDHCI<T>([In] this PBFBDJCALEG<T> OLHDOIOOPGE)
	{
		return default(PBFBDJCALEG<T>.IAIKJCEGMMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x39DD0F0", Offset = "0x39DC0F0", VA = "0x1839DD0F0")]
	public static PBFBDJCALEG<T>.EBBFPFAPGCI ACJCANDOBEG<T>(this PBFBDJCALEG<T> OLHDOIOOPGE)
	{
		return default(PBFBDJCALEG<T>.EBBFPFAPGCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD5C0", Offset = "0x3ABC5C0", VA = "0x183ABD5C0")]
	public static CPMJCNKKGMI<T, PBFBDJCALEG<T>.IAIKJCEGMMG> IIKILNHNIHK<T>([In] this PBFBDJCALEG<T> OLHDOIOOPGE)
	{
		return default(CPMJCNKKGMI<T, PBFBDJCALEG<T>.IAIKJCEGMMG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal static class IBNFAHCCJFL
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F510", Offset = "0x3C9E510", VA = "0x183C9F510")]
	public static T[] HMLOCBOHNMP<T>(int BKLOHAHJLKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	public static void GPGDDPLHLPB<T>(T[] MFIJBPNIELL)
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
