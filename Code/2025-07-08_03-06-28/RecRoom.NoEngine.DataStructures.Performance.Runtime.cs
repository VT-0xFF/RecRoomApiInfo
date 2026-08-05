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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8222030", Offset = "0x8220E30", VA = "0x188222030")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MMNFMODPMNB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3936570", Offset = "0x3935370", VA = "0x183936570")]
	public static MPKIBFFOKBM<T> HMBIJKFDDBI<T>(this T[] FEOFEEGOGIO) where T : notnull
	{
		return default(MPKIBFFOKBM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3CA02B0", Offset = "0x3C9F0B0", VA = "0x183CA02B0")]
	public static IAJKFBFDADD<T, JCPDAACCMFH<T>> FILCCKJNJNL<T>(this T[] FEOFEEGOGIO) where T : notnull
	{
		return default(IAJKFBFDADD<T, JCPDAACCMFH<T>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class CDNIMMKNLMH<T> : IDisposable, GGCBDOOLLJB, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OJAIHBKPJPA<T> LCGHKMEBHNE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x670A5F0", Offset = "0x67093F0", VA = "0x18670A5F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x670A640", Offset = "0x6709440", VA = "0x18670A640")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x670A6C0", Offset = "0x67094C0", VA = "0x18670A6C0")]
	public static CDNIMMKNLMH<T> OGAKBGHEIKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5706E10", Offset = "0x5705C10", VA = "0x185706E10")]
	internal CDNIMMKNLMH([In] OJAIHBKPJPA<T> HJPGLGOFFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x670A620", Offset = "0x6709420", VA = "0x18670A620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x670A5D0", Offset = "0x67093D0", VA = "0x18670A5D0")]
	public void AKINDPMCGAM(int LJEIHABMGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x670A670", Offset = "0x6709470", VA = "0x18670A670", Slot = "8")]
	public OJAIHBKPJPA<T>.ABALHCBLLLE GetEnumerator()
	{
		return default(OJAIHBKPJPA<T>.ABALHCBLLLE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x670A7E0", Offset = "0x67095E0", VA = "0x18670A7E0", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x670A7E0", Offset = "0x67095E0", VA = "0x18670A7E0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct NPFFAPEPDPB<T, U> : IEnumerable<T>, IEnumerable where U : GHGPHHKCMPA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U BNICPHDFHIJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x11D37F0", Offset = "0x11D25F0", VA = "0x1811D37F0")]
	internal NPFFAPEPDPB([In] U DOHHLDONBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x11D3B80", Offset = "0x11D2980", VA = "0x1811D3B80", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x480C430", Offset = "0x480B230", VA = "0x18480C430", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x480C430", Offset = "0x480B230", VA = "0x18480C430", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HDOGFOPBPFN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3F36AA0", Offset = "0x3F358A0", VA = "0x183F36AA0")]
	public static NPFFAPEPDPB<T, U> OGAKBGHEIKK<U>([In] U FEOFEEGOGIO) where U : GHGPHHKCMPA<T>
	{
		return default(NPFFAPEPDPB<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FNBMKEICBOG
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3B6AF40", Offset = "0x3B69D40", VA = "0x183B6AF40")]
	public static int OOJPJFMJCLH<T, U>([In] this NPFFAPEPDPB<T, U> FEOFEEGOGIO) where U : GHGPHHKCMPA<T>, GGCBDOOLLJB
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BJOPLDLECHL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6257C70", Offset = "0x6256A70", VA = "0x186257C70")]
	public static IAJKFBFDADD<T, JCPDAACCMFH<T>> OGAKBGHEIKK([In] T[] FEOFEEGOGIO)
	{
		return default(IAJKFBFDADD<T, JCPDAACCMFH<T>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct IAJKFBFDADD<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U BNICPHDFHIJ;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4F0DDD0", Offset = "0x4F0CBD0", VA = "0x184F0DDD0")]
	internal IAJKFBFDADD([In] U DOHHLDONBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4F0DC00", Offset = "0x4F0CA00", VA = "0x184F0DC00", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4F0DC00", Offset = "0x4F0CA00", VA = "0x184F0DC00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LKNGIKMPMJA<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x41FAA40", Offset = "0x41F9840", VA = "0x1841FAA40")]
	public static IAJKFBFDADD<T, U> OGAKBGHEIKK<U>([In] U FEOFEEGOGIO) where U : IEnumerator<T>
	{
		return default(IAJKFBFDADD<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LBIAGLIPEKI
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3C491E0", Offset = "0x3C47FE0", VA = "0x183C491E0")]
	public static IAJKFBFDADD<TResult, BKPNNMHFJCF<TSourceEnumerator, TSource, TResult>> CLLAOFLGGOE<TResult, TSourceEnumerator, TSource>([In] this IAJKFBFDADD<TSource, TSourceEnumerator> FEOFEEGOGIO, Func<TSource, TResult> KKFCBIHHIGC) where TSourceEnumerator : GGCBDOOLLJB, IEnumerator<TSource>
	{
		return default(IAJKFBFDADD<TResult, BKPNNMHFJCF<TSourceEnumerator, TSource, TResult>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct JCPDAACCMFH<T> : IEnumerator<T>, IEnumerator, IDisposable, GGCBDOOLLJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly T[] LMOLJIECIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int NJCBMBGNEDI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly T BNFIAAPBEMM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x518D600", Offset = "0x518C400", VA = "0x18518D600", Slot = "4")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x518D5B0", Offset = "0x518C3B0", VA = "0x18518D5B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x29C2B40", Offset = "0x29C1940", VA = "0x1829C2B40", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xD244C0", Offset = "0xD232C0", VA = "0x180D244C0")]
	private JCPDAACCMFH(T[] FEOFEEGOGIO, int CKFKPOAGPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x518D560", Offset = "0x518C360", VA = "0x18518D560")]
	public static JCPDAACCMFH<T> OGAKBGHEIKK(T[] FEOFEEGOGIO)
	{
		return default(JCPDAACCMFH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x29C2B60", Offset = "0x29C1960", VA = "0x1829C2B60", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x29C2C00", Offset = "0x29C1A00", VA = "0x1829C2C00", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct BKPNNMHFJCF<TSourceEnumerator, TSource, TResult> : GGCBDOOLLJB, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : GGCBDOOLLJB, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private TSourceEnumerator LMOLJIECIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<TSource, TResult> IDJJALMOKPG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public readonly int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6338700", Offset = "0x6337500", VA = "0x186338700", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly TResult BNFIAAPBEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x63389C0", Offset = "0x63377C0", VA = "0x1863389C0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6338940", Offset = "0x6337740", VA = "0x186338940", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x29D4580", Offset = "0x29D3380", VA = "0x1829D4580")]
	internal BKPNNMHFJCF([In] TSourceEnumerator FEOFEEGOGIO, Func<TSource, TResult> KKFCBIHHIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6338830", Offset = "0x6337630", VA = "0x186338830", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6338870", Offset = "0x6337670", VA = "0x186338870", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5978C60", Offset = "0x5977A60", VA = "0x185978C60", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class JPDKGMMKIFM
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC0E0", Offset = "0x3BFAEE0", VA = "0x183BFC0E0")]
	public static string DPMOJGEOPNI<T>(this IEnumerable<T> FEOFEEGOGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3C00DC0", Offset = "0x3BFFBC0", VA = "0x183C00DC0")]
	public static string FCDBJFOPDMC<T>(this IEnumerable<T> FEOFEEGOGIO, string AGNLMEPIMCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NLCIDKABEII
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3D0EB50", Offset = "0x3D0D950", VA = "0x183D0EB50")]
	public static bool BEMJJOMMPMH<TSourceEnumerator, TSource>(this TSourceEnumerator FEOFEEGOGIO, [In] TSource EHKDLJBBGDB) where TSourceEnumerator : GHGPHHKCMPA<TSource> where TSource : JOEBIEMNHCG<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3D0EFA0", Offset = "0x3D0DDA0", VA = "0x183D0EFA0")]
	public static int NOJDMFNGPOJ<TSourceEnumerator, TSource>(this TSourceEnumerator FEOFEEGOGIO, [In] TSource BNECONOIKOE) where TSourceEnumerator : GHGPHHKCMPA<TSource> where TSource : JOEBIEMNHCG<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3D0ECD0", Offset = "0x3D0DAD0", VA = "0x183D0ECD0")]
	public static BKPNNMHFJCF<TSourceEnumerator, TSource, TResult> CLLAOFLGGOE<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator FEOFEEGOGIO, Func<TSource, TResult> KKFCBIHHIGC) where TSourceEnumerator : GGCBDOOLLJB, IEnumerator<TSource>
	{
		return default(BKPNNMHFJCF<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3D0ED30", Offset = "0x3D0DB30", VA = "0x183D0ED30")]
	public static int JMCPEGJIHKK<TSourceEnumerator, TSource>(this TSourceEnumerator FEOFEEGOGIO, [In] TSource BNECONOIKOE) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GHGPHHKCMPA<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T BNFIAAPBEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GGCBDOOLLJB
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KHKPCPPGILI<T> : GHGPHHKCMPA<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct EDDLJDDEIPJ<T, U> : IEnumerable<T>, IEnumerable where U : KHKPCPPGILI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly U BNICPHDFHIJ;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x480C4E0", Offset = "0x480B2E0", VA = "0x18480C4E0")]
	internal EDDLJDDEIPJ([In] U DOHHLDONBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x480C380", Offset = "0x480B180", VA = "0x18480C380", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x480C3A0", Offset = "0x480B1A0", VA = "0x18480C3A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x480C3A0", Offset = "0x480B1A0", VA = "0x18480C3A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CFCDGBCKHDI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3F36AD0", Offset = "0x3F358D0", VA = "0x183F36AD0")]
	public static EDDLJDDEIPJ<T, U> OGAKBGHEIKK<U>([In] U FEOFEEGOGIO) where U : KHKPCPPGILI<T>
	{
		return default(EDDLJDDEIPJ<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public readonly struct MPKIBFFOKBM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct LANMDANOLLH : GGCBDOOLLJB, GHGPHHKCMPA<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] LMOLJIECIPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int NJCBMBGNEDI;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly int OOJPJFMJCLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x29C2B40", Offset = "0x29C1940", VA = "0x1829C2B40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T BNFIAAPBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x53FF770", Offset = "0x53FE570", VA = "0x1853FF770", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x53FF190", Offset = "0x53FDF90", VA = "0x1853FF190", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x53FF6B0", Offset = "0x53FE4B0", VA = "0x1853FF6B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xD244C0", Offset = "0xD232C0", VA = "0x180D244C0")]
		private LANMDANOLLH(T[] FEOFEEGOGIO, int CKFKPOAGPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x518D560", Offset = "0x518C360", VA = "0x18518D560")]
		public static LANMDANOLLH OGAKBGHEIKK(T[] FEOFEEGOGIO)
		{
			return default(LANMDANOLLH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x29C2B60", Offset = "0x29C1960", VA = "0x1829C2B60", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x29C2C00", Offset = "0x29C1A00", VA = "0x1829C2C00", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly T[] BBPANNACCOK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int PHDDEAOOOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x29C2B40", Offset = "0x29C1940", VA = "0x1829C2B40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3D695A0", Offset = "0x3D683A0", VA = "0x183D695A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xE3B7E0", Offset = "0xE3A5E0", VA = "0x180E3B7E0")]
	internal MPKIBFFOKBM(T[] COPOPHFGNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x568BD90", Offset = "0x568AB90", VA = "0x18568BD90")]
	public static MPKIBFFOKBM<T> MMHNBCKELFI()
	{
		return default(MPKIBFFOKBM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
	public IEnumerable<T> BMKDJBOOHMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x568BD00", Offset = "0x568AB00", VA = "0x18568BD00")]
	public ReadOnlySpan<T> JDPNDNCJKFL()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x568BBE0", Offset = "0x568A9E0", VA = "0x18568BBE0")]
	public NPFFAPEPDPB<T, MPKIBFFOKBM<T>.LANMDANOLLH> IEAIIKNPCHG()
	{
		return default(NPFFAPEPDPB<T, LANMDANOLLH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x568BB50", Offset = "0x568A950", VA = "0x18568BB50")]
	public LANMDANOLLH DJIBOEGHANG()
	{
		return default(LANMDANOLLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x568BE50", Offset = "0x568AC50", VA = "0x18568BE50")]
	public IEnumerator<T> OMGGHMFPBJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x568BED0", Offset = "0x568ACD0", VA = "0x18568BED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class KFECNLIEAJE
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x39F27A0", Offset = "0x39F15A0", VA = "0x1839F27A0")]
	public static MPKIBFFOKBM<T> BKGNHKODBHC<T>(params T[] COPOPHFGNFG) where T : notnull
	{
		return default(MPKIBFFOKBM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8221FD0", Offset = "0x8220DD0", VA = "0x188221FD0")]
	public static Stream FFPKEJKIPKE(this MPKIBFFOKBM<byte> FEOFEEGOGIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DebuggerTypeProxy(typeof(OJAIHBKPJPA<>.CHKHLPLGLCG))]
public struct OJAIHBKPJPA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct ABALHCBLLLE : GGCBDOOLLJB, KHKPCPPGILI<T>, GHGPHHKCMPA<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly T[] JJOPLCKNBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int JLGJDEPGLCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int NJCBMBGNEDI;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly int OOJPJFMJCLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xEC90A0", Offset = "0xEC7EA0", VA = "0x180EC90A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public readonly T BNFIAAPBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4EA0650", Offset = "0x4E9F450", VA = "0x184EA0650", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public readonly T FJIBJFGNKPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4E9FDE0", Offset = "0x4E9EBE0", VA = "0x184E9FDE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private readonly T LLNFPMOMEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x4E9FD50", Offset = "0x4E9EB50", VA = "0x184E9FD50", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4EA00D0", Offset = "0x4E9EED0", VA = "0x184EA00D0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4EA0220", Offset = "0x4E9F020", VA = "0x184EA0220", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0610", Offset = "0x4E9F410", VA = "0x184EA0610")]
		internal ABALHCBLLLE(T[] HPGGKMKJGLJ, int LJEIHABMGGI, int CKFKPOAGPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4E9FF50", Offset = "0x4E9ED50", VA = "0x184E9FF50")]
		public static ABALHCBLLLE OGAKBGHEIKK(OJAIHBKPJPA<T> FEOFEEGOGIO)
		{
			return default(ABALHCBLLLE);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x48A3400", Offset = "0x48A2200", VA = "0x1848A3400", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x489ECB0", Offset = "0x489DAB0", VA = "0x18489ECB0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct PBIGOFPJFEG : GGCBDOOLLJB, GHGPHHKCMPA<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private ABALHCBLLLE BNICPHDFHIJ;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int OOJPJFMJCLH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5978C30", Offset = "0x5977A30", VA = "0x185978C30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public readonly T BNFIAAPBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x5979210", Offset = "0x5978010", VA = "0x185979210", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5978E70", Offset = "0x5977C70", VA = "0x185978E70", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5979060", Offset = "0x5977E60", VA = "0x185979060", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x11D37F0", Offset = "0x11D25F0", VA = "0x1811D37F0")]
		private PBIGOFPJFEG([In] ABALHCBLLLE DOHHLDONBML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5978CE0", Offset = "0x5977AE0", VA = "0x185978CE0")]
		public static PBIGOFPJFEG OGAKBGHEIKK([In] OJAIHBKPJPA<T> FEOFEEGOGIO)
		{
			return default(PBIGOFPJFEG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5978CA0", Offset = "0x5977AA0", VA = "0x185978CA0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5978D90", Offset = "0x5977B90", VA = "0x185978D90", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5978C60", Offset = "0x5977A60", VA = "0x185978C60", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class CHKHLPLGLCG
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal T[] JJOPLCKNBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal int JLGJDEPGLCH;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x585C0E0", Offset = "0x585AEE0", VA = "0x18585C0E0")]
	public static OJAIHBKPJPA<T> OGAKBGHEIKK()
	{
		return default(OJAIHBKPJPA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x585C030", Offset = "0x585AE30", VA = "0x18585C030")]
	public static OJAIHBKPJPA<T> LAPNFIBBPAH(int COJMCLGONLG)
	{
		return default(OJAIHBKPJPA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xD244C0", Offset = "0xD232C0", VA = "0x180D244C0")]
	internal OJAIHBKPJPA(T[] HPGGKMKJGLJ, int LJEIHABMGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x585C180", Offset = "0x585AF80", VA = "0x18585C180", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class PKMIBKDHEOC
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate int FLCPOPHLLLF<TCtx, T>([In] TCtx JACKFIDBPJG, T PHLJLBDJNIE, T GEOHFJAPCHG);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3D698B0", Offset = "0x3D686B0", VA = "0x183D698B0")]
	public static void BOGGHIAGAGL<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3D6B940", Offset = "0x3D6A740", VA = "0x183D6B940")]
	public static string KFACALGAEEN<T>([In] this OJAIHBKPJPA<T> FEOFEEGOGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
	public static T[] KFOPDBAELPO<T>([In] this OJAIHBKPJPA<T> FEOFEEGOGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3D696D0", Offset = "0x3D684D0", VA = "0x183D696D0")]
	public static T LHCLHJGACJJ<T>([In] this OJAIHBKPJPA<T> FEOFEEGOGIO, int BOECAAOIBHO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3D695A0", Offset = "0x3D683A0", VA = "0x183D695A0")]
	public static T BEPKEMKPCPO<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO, int BOECAAOIBHO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3D6AD80", Offset = "0x3D69B80", VA = "0x183D6AD80")]
	public static T GMIDCJNHGFD<T>([In] this OJAIHBKPJPA<T> FEOFEEGOGIO, int BOECAAOIBHO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E410", Offset = "0x3D6D210", VA = "0x183D6E410")]
	public static void LAGAMOKKAFA<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO, int BOECAAOIBHO, [In] T BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3D6A0C0", Offset = "0x3D68EC0", VA = "0x183D6A0C0")]
	public static void DGNBOJNMJEE<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO, int BOECAAOIBHO, T BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xEC90A0", Offset = "0xEC7EA0", VA = "0x180EC90A0")]
	public static int CKPAOBGGGIL<T>([In] this OJAIHBKPJPA<T> FEOFEEGOGIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3D6B0B0", Offset = "0x3D69EB0", VA = "0x183D6B0B0")]
	public static ReadOnlySpan<T> JDPNDNCJKFL<T>([In] this OJAIHBKPJPA<T> FEOFEEGOGIO)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3D6AA40", Offset = "0x3D69840", VA = "0x183D6AA40")]
	public static T[] EPNDMINMHEC<T>([In] this OJAIHBKPJPA<T> FEOFEEGOGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3D6B000", Offset = "0x3D69E00", VA = "0x183D6B000")]
	public static T HFKKHAKJBLG<T>([In] this OJAIHBKPJPA<T> FEOFEEGOGIO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3D70D70", Offset = "0x3D6FB70", VA = "0x183D70D70")]
	public static T[] PHJFMPBEEJL<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3D6B020", Offset = "0x3D69E20", VA = "0x183D6B020")]
	public static MPKIBFFOKBM<T> JDACCOCJKBO<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO)
	{
		return default(MPKIBFFOKBM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3D708A0", Offset = "0x3D6F6A0", VA = "0x183D708A0")]
	public static void OLHPIGGMIDE<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO, [In] T BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3D69970", Offset = "0x3D68770", VA = "0x183D69970")]
	public static void CPPEPOKPNNC<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO, T BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3D6AB70", Offset = "0x3D69970", VA = "0x183D6AB70")]
	public static void FKCAGLHHHHE<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO, int CKFKPOAGPKN, [In] T BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3D69810", Offset = "0x3D68610", VA = "0x183D69810")]
	public static void BLFIKHOCELM<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO, int CKFKPOAGPKN, [In] OJAIHBKPJPA<T> FEBLBJIINOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3D6AED0", Offset = "0x3D69CD0", VA = "0x183D6AED0")]
	public static void HCLOJONMDCA<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO, int CKFKPOAGPKN, T BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3D70780", Offset = "0x3D6F580", VA = "0x183D70780")]
	public static void OGMLKCBPBFI<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO, int CKFKPOAGPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3D70D10", Offset = "0x3D6FB10", VA = "0x183D70D10")]
	public static T PBHJOJDDLHO<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3D67A10", Offset = "0x3D66810", VA = "0x183D67A10")]
	public static void AKINDPMCGAM<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO, int LJEIHABMGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3D6EEA0", Offset = "0x3D6DCA0", VA = "0x183D6EEA0")]
	private static void OFNMFJFHADC<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO, int COJMCLGONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E8B0", Offset = "0x3D6D6B0", VA = "0x183D6E8B0")]
	public static void MKDKKBLDFOH<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3D66840", Offset = "0x3D65640", VA = "0x183D66840")]
	public static OJAIHBKPJPA<T> AJBMEKOGIKE<T>([In] this OJAIHBKPJPA<T> FEOFEEGOGIO, KKDLBMGLLEE<T, T> MJGFMFCAANH)
	{
		return default(OJAIHBKPJPA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3D6A7A0", Offset = "0x3D695A0", VA = "0x183D6A7A0")]
	public static bool EBNLHEFHMEO<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO, T BNECONOIKOE) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E9C0", Offset = "0x3D6D7C0", VA = "0x183D6E9C0")]
	public static bool NOCJNGEFPDP<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO, [In] T BNECONOIKOE) where T : JOEBIEMNHCG<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3992A20", Offset = "0x3991820", VA = "0x183992A20")]
	public static bool DDMFODGPIEN<T>([In] this OJAIHBKPJPA<T> FEOFEEGOGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3D6A8C0", Offset = "0x3D696C0", VA = "0x183D6A8C0")]
	public static bool EKAMDFEGPAC<T>([In] this OJAIHBKPJPA<T> FEOFEEGOGIO, int BOECAAOIBHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3D6B180", Offset = "0x3D69F80", VA = "0x183D6B180")]
	public static void KAAEIIHAFLC<T, TCtx>(this OJAIHBKPJPA<T> FEOFEEGOGIO, [In] TCtx JACKFIDBPJG, FLCPOPHLLLF<TCtx, T> MPEFFCIPOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3D69B00", Offset = "0x3D68900", VA = "0x183D69B00")]
	private static void DBGKOIAKEAP<T, TCtx>(OJAIHBKPJPA<T> FEOFEEGOGIO, [In] TCtx JACKFIDBPJG, FLCPOPHLLLF<TCtx, T> MPEFFCIPOFC, int NDMKLDKIAIA, int JONPPGEKGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3D69BC0", Offset = "0x3D689C0", VA = "0x183D69BC0")]
	private static int DCIDGBGDILH<T, TCtx>(OJAIHBKPJPA<T> FEOFEEGOGIO, [In] TCtx JACKFIDBPJG, FLCPOPHLLLF<TCtx, T> MPEFFCIPOFC, int NDMKLDKIAIA, int JONPPGEKGLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x393C0C0", Offset = "0x393AEC0", VA = "0x18393C0C0")]
	public static OJAIHBKPJPA<T>.PBIGOFPJFEG OMGGHMFPBJO<T>([In] this OJAIHBKPJPA<T> FEOFEEGOGIO)
	{
		return default(OJAIHBKPJPA<T>.PBIGOFPJFEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x393C0C0", Offset = "0x393AEC0", VA = "0x18393C0C0")]
	public static OJAIHBKPJPA<T>.ABALHCBLLLE BFGEFBECKMO<T>(this OJAIHBKPJPA<T> FEOFEEGOGIO)
	{
		return default(OJAIHBKPJPA<T>.ABALHCBLLLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF540", Offset = "0x3BCE340", VA = "0x183BCF540")]
	public static NPFFAPEPDPB<T, OJAIHBKPJPA<T>.PBIGOFPJFEG> KHDOANPBMIC<T>([In] this OJAIHBKPJPA<T> FEOFEEGOGIO)
	{
		return default(NPFFAPEPDPB<T, OJAIHBKPJPA<T>.PBIGOFPJFEG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal static class HHOBMMNMHNK
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F550", Offset = "0x3B9E350", VA = "0x183B9F550")]
	public static T[] GGFHJGODFLF<T>(int DFCCCGNJINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	public static void CIEEKMINCMG<T>(T[] COPOPHFGNFG)
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
