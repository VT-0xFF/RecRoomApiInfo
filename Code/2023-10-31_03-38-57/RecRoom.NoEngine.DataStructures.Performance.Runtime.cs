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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CFA790", Offset = "0x5CF9B90", VA = "0x185CFA790")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x787CA0", Offset = "0x7870A0", VA = "0x180787CA0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x787CE0", Offset = "0x7870E0", VA = "0x180787CE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JJNIGDKEKBL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x21A0CF0", Offset = "0x21A00F0", VA = "0x1821A0CF0")]
	public static DNIFIFFEBGD<T> ICGHMEBLGKK<T>(this T[] LDMHFMNLDHG) where T : notnull
	{
		return default(DNIFIFFEBGD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class KPJMJOBILOL<T> : IDisposable, EHHIMOBLLGD, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private GCLIDNHGMHJ<T> PLECCDGIOHB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3907A30", Offset = "0x3906E30", VA = "0x183907A30", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3907A80", Offset = "0x3906E80", VA = "0x183907A80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3907B40", Offset = "0x3906F40", VA = "0x183907B40")]
	public static KPJMJOBILOL<T> LJCGEPFBFCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3907C60", Offset = "0x3907060", VA = "0x183907C60")]
	public static KPJMJOBILOL<T> PGGODHGAACI(int OOIJDECJBIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x30325D0", Offset = "0x30319D0", VA = "0x1830325D0")]
	internal KPJMJOBILOL([In] GCLIDNHGMHJ<T> MPPIIABEOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3907A60", Offset = "0x3906E60", VA = "0x183907A60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3907B20", Offset = "0x3906F20", VA = "0x183907B20")]
	public void INMJBKGEACO([In] T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3907AB0", Offset = "0x3906EB0", VA = "0x183907AB0")]
	public void GNLIIEGEIDL(int OGEHFGGOGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3907AD0", Offset = "0x3906ED0", VA = "0x183907AD0", Slot = "8")]
	public GCLIDNHGMHJ<T>.KPKAIEIOKEO GetEnumerator()
	{
		return default(GCLIDNHGMHJ<T>.KPKAIEIOKEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3907D80", Offset = "0x3907180", VA = "0x183907D80", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3907D80", Offset = "0x3907180", VA = "0x183907D80", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct NNBGBBLHMHE<T, U> : IEnumerable<T>, IEnumerable where U : AAKILIMMNMF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U EIJLGHGHDFN;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1C3EEE0", Offset = "0x1C3E2E0", VA = "0x181C3EEE0")]
	internal NNBGBBLHMHE([In] U HBGFNOABMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xA9D3F0", Offset = "0xA9C7F0", VA = "0x180A9D3F0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9780", Offset = "0x3BF8B80", VA = "0x183BF9780", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9780", Offset = "0x3BF8B80", VA = "0x183BF9780", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PHOKEFEFCID<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x22D8640", Offset = "0x22D7A40", VA = "0x1822D8640")]
	public static NNBGBBLHMHE<T, U> LJCGEPFBFCG<U>([In] U LDMHFMNLDHG) where U : AAKILIMMNMF<T>
	{
		return default(NNBGBBLHMHE<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct EPHADIAOFCC<TSourceEnumerator, TSource, TResult> : EHHIMOBLLGD, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : EHHIMOBLLGD, AAKILIMMNMF<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private TSourceEnumerator PFHFJOGOAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly HADOODFJFDO<TSource, TResult> HEOIDIDPMIG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3091850", Offset = "0x3090C50", VA = "0x183091850", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public readonly TResult PNJHIMNMKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3091C40", Offset = "0x3091040", VA = "0x183091C40", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3091B80", Offset = "0x3090F80", VA = "0x183091B80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3091BC0", Offset = "0x3090FC0", VA = "0x183091BC0")]
	internal EPHADIAOFCC([In] TSourceEnumerator LDMHFMNLDHG, HADOODFJFDO<TSource, TResult> JCLLCOOMNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3091970", Offset = "0x3090D70", VA = "0x183091970", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3091A00", Offset = "0x3090E00", VA = "0x183091A00", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3091930", Offset = "0x3090D30", VA = "0x183091930", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct OGKDNINCCNF<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly U EIJLGHGHDFN;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3982020", Offset = "0x3981420", VA = "0x183982020")]
	internal OGKDNINCCNF([In] U HBGFNOABMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x33D9C80", Offset = "0x33D9080", VA = "0x1833D9C80", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3CE72C0", Offset = "0x3CE66C0", VA = "0x183CE72C0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3CE72C0", Offset = "0x3CE66C0", VA = "0x183CE72C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class AMPMIICFKGM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2048920", Offset = "0x2047D20", VA = "0x182048920")]
	public static OGKDNINCCNF<T, U> LJCGEPFBFCG<U>([In] U LDMHFMNLDHG) where U : IEnumerator<T>
	{
		return default(OGKDNINCCNF<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FNABPOEKAEF<TSourceEnumerator, TSource, TResult> : EHHIMOBLLGD, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : EHHIMOBLLGD, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private TSourceEnumerator PFHFJOGOAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<TSource, TResult> HEOIDIDPMIG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public readonly int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3091850", Offset = "0x3090C50", VA = "0x183091850", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly TResult PNJHIMNMKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x33E3050", Offset = "0x33E2450", VA = "0x1833E3050", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x33E2FA0", Offset = "0x33E23A0", VA = "0x1833E2FA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3091BC0", Offset = "0x3090FC0", VA = "0x183091BC0")]
	internal FNABPOEKAEF([In] TSourceEnumerator LDMHFMNLDHG, Func<TSource, TResult> JCLLCOOMNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3091970", Offset = "0x3090D70", VA = "0x183091970", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3091A00", Offset = "0x3090E00", VA = "0x183091A00", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3091930", Offset = "0x3090D30", VA = "0x183091930", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class AAIPACIAEOK
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x29BCDD0", Offset = "0x29BC1D0", VA = "0x1829BCDD0")]
	public static string BJOMNJDHIML<T>(this IEnumerable<T> LDMHFMNLDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x29C0270", Offset = "0x29BF670", VA = "0x1829C0270")]
	public static string NCPOGJKPFOE<T>(this IEnumerable<T> LDMHFMNLDHG, string KDBAGCJMHEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PFKEFHEHPMB
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2509520", Offset = "0x2508920", VA = "0x182509520")]
	public static bool LDDDNFIBBGD<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator LDMHFMNLDHG, [In] TArgs CAAIHKBHIAA, [In] OJBLLGJNCDN<TArgs, TSource, bool> KEHLEAGLJOO) where TSourceEnumerator : AAKILIMMNMF<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x25096B0", Offset = "0x2508AB0", VA = "0x1825096B0")]
	public static int NCJOPHOLGHC<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator LDMHFMNLDHG, [In] TArgs CAAIHKBHIAA, OJBLLGJNCDN<TArgs, TSource, bool> KEHLEAGLJOO) where TSourceEnumerator : AAKILIMMNMF<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2509340", Offset = "0x2508740", VA = "0x182509340")]
	public static bool IJPGCDBFKBM<TSourceEnumerator, TSource>(this TSourceEnumerator LDMHFMNLDHG, [In] TSource JJEIFGHOKOA) where TSourceEnumerator : AAKILIMMNMF<TSource> where TSource : EGCLJEBFBCM<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2509850", Offset = "0x2508C50", VA = "0x182509850")]
	public static int ODANECKPLLM<TSourceEnumerator, TSource>(this TSourceEnumerator LDMHFMNLDHG, [In] TSource EOHMJBFGDPD) where TSourceEnumerator : AAKILIMMNMF<TSource> where TSource : EGCLJEBFBCM<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x25094C0", Offset = "0x25088C0", VA = "0x1825094C0")]
	public static EPHADIAOFCC<TSourceEnumerator, TSource, TResult> ILMLHFGNPJJ<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator LDMHFMNLDHG, HADOODFJFDO<TSource, TResult> JCLLCOOMNFN) where TSourceEnumerator : EHHIMOBLLGD, AAKILIMMNMF<TSource>
	{
		return default(EPHADIAOFCC<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x25094C0", Offset = "0x25088C0", VA = "0x1825094C0")]
	public static FNABPOEKAEF<TSourceEnumerator, TSource, TResult> JFAIJLGFHHB<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator LDMHFMNLDHG, Func<TSource, TResult> JCLLCOOMNFN) where TSourceEnumerator : EHHIMOBLLGD, IEnumerator<TSource>
	{
		return default(FNABPOEKAEF<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IINPJPPOMLO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2D16B70", Offset = "0x2D15F70", VA = "0x182D16B70")]
	public static bool DGPALEEAJPM<TSourceEnumerator>(TSourceEnumerator LDMHFMNLDHG) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2D16BE0", Offset = "0x2D15FE0", VA = "0x182D16BE0")]
	public static T EFPKGCJFJDB<TSourceEnumerator>(TSourceEnumerator LDMHFMNLDHG) where TSourceEnumerator : AAKILIMMNMF<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2D17A10", Offset = "0x2D16E10", VA = "0x182D17A10")]
	public static T[] FLPBFPGLICA<TSourceEnumerator>(TSourceEnumerator LDMHFMNLDHG) where TSourceEnumerator : EHHIMOBLLGD, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2D16A70", Offset = "0x2D15E70", VA = "0x182D16A70")]
	public static T APFFJHDJCCI<TSourceEnumerator>(TSourceEnumerator LDMHFMNLDHG) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AAKILIMMNMF<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T PNJHIMNMKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EHHIMOBLLGD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DKLKHNODFIE<T> : AAKILIMMNMF<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct NALLAKPPOOA<T, U> : IEnumerable<T>, IEnumerable where U : DKLKHNODFIE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly U EIJLGHGHDFN;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3BF9800", Offset = "0x3BF8C00", VA = "0x183BF9800")]
	internal NALLAKPPOOA([In] U HBGFNOABMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x311ECD0", Offset = "0x311E0D0", VA = "0x18311ECD0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3BF96F0", Offset = "0x3BF8AF0", VA = "0x183BF96F0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3BF96F0", Offset = "0x3BF8AF0", VA = "0x183BF96F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HBFJBBNBDHL<T>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2D14850", Offset = "0x2D13C50", VA = "0x182D14850")]
	public static NALLAKPPOOA<T, U> LJCGEPFBFCG<U>([In] U LDMHFMNLDHG) where U : DKLKHNODFIE<T>
	{
		return default(NALLAKPPOOA<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public readonly struct DNIFIFFEBGD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct ENGHNGOCGOC : EHHIMOBLLGD, AAKILIMMNMF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] PFHFJOGOAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int ELPFBJBHGMN;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly int EJNDKIEMIHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1C63790", Offset = "0x1C62B90", VA = "0x181C63790", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T PNJHIMNMKKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3083C50", Offset = "0x3083050", VA = "0x183083C50", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3083710", Offset = "0x3082B10", VA = "0x183083710", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3083970", Offset = "0x3082D70", VA = "0x183083970", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x168FAE0", Offset = "0x168EEE0", VA = "0x18168FAE0")]
		private ENGHNGOCGOC(T[] LDMHFMNLDHG, int APOENOPNHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3083580", Offset = "0x3082980", VA = "0x183083580")]
		public static ENGHNGOCGOC LJCGEPFBFCG(T[] LDMHFMNLDHG)
		{
			return default(ENGHNGOCGOC);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1C63820", Offset = "0x1C62C20", VA = "0x181C63820", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1C63850", Offset = "0x1C62C50", VA = "0x181C63850", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly T[] GHPIDGCINMB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EKAAEPEENKL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1C63790", Offset = "0x1C62B90", VA = "0x181C63790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x22046E0", Offset = "0x2203AE0", VA = "0x1822046E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7E8520", Offset = "0x7E7920", VA = "0x1807E8520")]
	internal DNIFIFFEBGD(T[] FFAHMFOPGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4CB7EA0", Offset = "0x4CB72A0", VA = "0x184CB7EA0")]
	public static DNIFIFFEBGD<T> OAIDPCAHLCF()
	{
		return default(DNIFIFFEBGD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
	public IEnumerable<T> BHJGEOLPEHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4CB7C70", Offset = "0x4CB7070", VA = "0x184CB7C70")]
	public ReadOnlySpan<T> BBOBLECGFBI()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4CB7D00", Offset = "0x4CB7100", VA = "0x184CB7D00")]
	public NNBGBBLHMHE<T, DNIFIFFEBGD<T>.ENGHNGOCGOC> HJJEGKEMPKL()
	{
		return default(NNBGBBLHMHE<T, ENGHNGOCGOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4CB7F60", Offset = "0x4CB7360", VA = "0x184CB7F60")]
	public ENGHNGOCGOC OKNGAKPHGJF()
	{
		return default(ENGHNGOCGOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4CB7E20", Offset = "0x4CB7220", VA = "0x184CB7E20")]
	public IEnumerator<T> JBKAHEPNGNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4CB7FF0", Offset = "0x4CB73F0", VA = "0x184CB7FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KHJEBPBJEOB
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2063DC0", Offset = "0x20631C0", VA = "0x182063DC0")]
	public static DNIFIFFEBGD<T> BKNPIJAAAJJ<T>(params T[] FFAHMFOPGLA) where T : notnull
	{
		return default(DNIFIFFEBGD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA730", Offset = "0x5CF9B30", VA = "0x185CFA730")]
	public static Stream GMEKAJIONNP(this DNIFIFFEBGD<byte> LDMHFMNLDHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DebuggerTypeProxy(typeof(GCLIDNHGMHJ<>.BEGLPAMBECA))]
public struct GCLIDNHGMHJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct KPKAIEIOKEO : EHHIMOBLLGD, DKLKHNODFIE<T>, AAKILIMMNMF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly T[] BPGBIJLHPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int DIAGMLMCBMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int ELPFBJBHGMN;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly int EJNDKIEMIHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x1C782F0", Offset = "0x1C776F0", VA = "0x181C782F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public readonly T PNJHIMNMKKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x39086E0", Offset = "0x3907AE0", VA = "0x1839086E0", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private readonly T PMLNEEIPJMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3907EA0", Offset = "0x39072A0", VA = "0x183907EA0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3908110", Offset = "0x3907510", VA = "0x183908110", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x39082B0", Offset = "0x39076B0", VA = "0x1839082B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x34CBBF0", Offset = "0x34CAFF0", VA = "0x1834CBBF0")]
		internal KPKAIEIOKEO(T[] PBOJKPKPEEN, int OGEHFGGOGMJ, int APOENOPNHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3907FE0", Offset = "0x39073E0", VA = "0x183907FE0")]
		public static KPKAIEIOKEO LJCGEPFBFCG(GCLIDNHGMHJ<T> LDMHFMNLDHG)
		{
			return default(KPKAIEIOKEO);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x30DF430", Offset = "0x30DE830", VA = "0x1830DF430", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x30DA3B0", Offset = "0x30D97B0", VA = "0x1830DA3B0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct LDCOFPMFBIH : EHHIMOBLLGD, AAKILIMMNMF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private KPKAIEIOKEO EIJLGHGHDFN;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int EJNDKIEMIHK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3972420", Offset = "0x3971820", VA = "0x183972420", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public readonly T PNJHIMNMKKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3972900", Offset = "0x3971D00", VA = "0x183972900", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3972680", Offset = "0x3971A80", VA = "0x183972680", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3972850", Offset = "0x3971C50", VA = "0x183972850", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1C3EEE0", Offset = "0x1C3E2E0", VA = "0x181C3EEE0")]
		private LDCOFPMFBIH([In] KPKAIEIOKEO HBGFNOABMDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3972490", Offset = "0x3971890", VA = "0x183972490")]
		public static LDCOFPMFBIH LJCGEPFBFCG([In] GCLIDNHGMHJ<T> LDMHFMNLDHG)
		{
			return default(LDCOFPMFBIH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3972540", Offset = "0x3971940", VA = "0x183972540", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3972580", Offset = "0x3971980", VA = "0x183972580", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3972450", Offset = "0x3971850", VA = "0x183972450", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class BEGLPAMBECA
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal T[] BPGBIJLHPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal int DIAGMLMCBMO;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x34AE580", Offset = "0x34AD980", VA = "0x1834AE580")]
	public static GCLIDNHGMHJ<T> LJCGEPFBFCG()
	{
		return default(GCLIDNHGMHJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x34AE690", Offset = "0x34ADA90", VA = "0x1834AE690")]
	public static GCLIDNHGMHJ<T> PGGODHGAACI(int OOIJDECJBIB)
	{
		return default(GCLIDNHGMHJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x168FAE0", Offset = "0x168EEE0", VA = "0x18168FAE0")]
	internal GCLIDNHGMHJ(T[] PBOJKPKPEEN, int OGEHFGGOGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x30721D0", Offset = "0x30715D0", VA = "0x1830721D0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class CGCDFKKCCCI
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x22067F0", Offset = "0x2205BF0", VA = "0x1822067F0")]
	public static void FOEGEAAAFMJ<T>(this GCLIDNHGMHJ<T> LDMHFMNLDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2204DE0", Offset = "0x22041E0", VA = "0x182204DE0")]
	public static string CMMAGLHNIGF<T>([In] this GCLIDNHGMHJ<T> LDMHFMNLDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
	public static T[] CIAOMILGKJA<T>([In] this GCLIDNHGMHJ<T> LDMHFMNLDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2204750", Offset = "0x2203B50", VA = "0x182204750")]
	public static T OPODPAEFLEB<T>([In] this GCLIDNHGMHJ<T> LDMHFMNLDHG, int KEFLNPGBJEJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2204750", Offset = "0x2203B50", VA = "0x182204750")]
	public static T AKGAMNFDBCI<T>(this GCLIDNHGMHJ<T> LDMHFMNLDHG, int KEFLNPGBJEJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x220A7E0", Offset = "0x2209BE0", VA = "0x18220A7E0")]
	public static T LKHLFHCIDKL<T>([In] this GCLIDNHGMHJ<T> LDMHFMNLDHG, int KEFLNPGBJEJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x22089F0", Offset = "0x2207DF0", VA = "0x1822089F0")]
	public static void GMFKOPHMECD<T>(this GCLIDNHGMHJ<T> LDMHFMNLDHG, int KEFLNPGBJEJ, [In] T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x220A840", Offset = "0x2209C40", VA = "0x18220A840")]
	public static void LMDCMNLFANE<T>(this GCLIDNHGMHJ<T> LDMHFMNLDHG, int KEFLNPGBJEJ, T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1C782F0", Offset = "0x1C776F0", VA = "0x181C782F0")]
	public static int BLBMIFMMGOK<T>([In] this GCLIDNHGMHJ<T> LDMHFMNLDHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2204980", Offset = "0x2203D80", VA = "0x182204980")]
	public static ReadOnlySpan<T> BBOBLECGFBI<T>([In] this GCLIDNHGMHJ<T> LDMHFMNLDHG)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x220A4F0", Offset = "0x22098F0", VA = "0x18220A4F0")]
	public static void INMJBKGEACO<T>(this GCLIDNHGMHJ<T> LDMHFMNLDHG, [In] T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x220A190", Offset = "0x2209590", VA = "0x18220A190")]
	public static void IAPFJMIKAIG<T>(this GCLIDNHGMHJ<T> LDMHFMNLDHG, int APOENOPNHBG, [In] T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x220A7A0", Offset = "0x2209BA0", VA = "0x18220A7A0")]
	public static void JKEBLLDCMHE<T>(this GCLIDNHGMHJ<T> LDMHFMNLDHG, int APOENOPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x220A130", Offset = "0x2209530", VA = "0x18220A130")]
	public static T HKFOCAEMIBA<T>(this GCLIDNHGMHJ<T> LDMHFMNLDHG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2209030", Offset = "0x2208430", VA = "0x182209030")]
	public static void GNLIIEGEIDL<T>(this GCLIDNHGMHJ<T> LDMHFMNLDHG, int OGEHFGGOGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x22068A0", Offset = "0x2205CA0", VA = "0x1822068A0")]
	private static void GLMPNOFHEEJ<T>(this GCLIDNHGMHJ<T> LDMHFMNLDHG, int OOIJDECJBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2204AC0", Offset = "0x2203EC0", VA = "0x182204AC0")]
	public static void BPHEMFKLBDC<T>(this GCLIDNHGMHJ<T> LDMHFMNLDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x22066E0", Offset = "0x2205AE0", VA = "0x1822066E0")]
	public static bool EOPCEKPKEDD<T>(this GCLIDNHGMHJ<T> LDMHFMNLDHG, [In] T EOHMJBFGDPD) where T : EGCLJEBFBCM<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2206890", Offset = "0x2205C90", VA = "0x182206890")]
	public static bool GHLFCACBCML<T>([In] this GCLIDNHGMHJ<T> LDMHFMNLDHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x22066A0", Offset = "0x2205AA0", VA = "0x1822066A0")]
	public static bool EKPFPHMAICE<T>([In] this GCLIDNHGMHJ<T> LDMHFMNLDHG, int KEFLNPGBJEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x21A1080", Offset = "0x21A0480", VA = "0x1821A1080")]
	public static GCLIDNHGMHJ<T>.LDCOFPMFBIH JBKAHEPNGNA<T>([In] this GCLIDNHGMHJ<T> LDMHFMNLDHG)
	{
		return default(GCLIDNHGMHJ<T>.LDCOFPMFBIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x21A1080", Offset = "0x21A0480", VA = "0x1821A1080")]
	public static GCLIDNHGMHJ<T>.KPKAIEIOKEO JEEBKAFMJLA<T>(this GCLIDNHGMHJ<T> LDMHFMNLDHG)
	{
		return default(GCLIDNHGMHJ<T>.KPKAIEIOKEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2206780", Offset = "0x2205B80", VA = "0x182206780")]
	public static NNBGBBLHMHE<T, GCLIDNHGMHJ<T>.LDCOFPMFBIH> FCKHEDHEHND<T>([In] this GCLIDNHGMHJ<T> LDMHFMNLDHG)
	{
		return default(NNBGBBLHMHE<T, GCLIDNHGMHJ<T>.LDCOFPMFBIH>);
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
