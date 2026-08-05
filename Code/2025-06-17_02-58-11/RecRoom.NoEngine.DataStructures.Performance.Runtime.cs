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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EAE3B0", Offset = "0x7EACDB0", VA = "0x187EAE3B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KLEKJPEFPGC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1D40", Offset = "0x2FF0740", VA = "0x182FF1D40")]
	public static BEGCCOONNLO<T> FJDHGIBANOK<T>(this T[] NMEFAPBBOCD) where T : notnull
	{
		return default(BEGCCOONNLO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3B0DAD0", Offset = "0x3B0C4D0", VA = "0x183B0DAD0")]
	public static GLIIFEKENJO<T, NGANBABNFCD<T>> IMDAMJLGIJI<T>(this T[] NMEFAPBBOCD) where T : notnull
	{
		return default(GLIIFEKENJO<T, NGANBABNFCD<T>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class LOBNJMIFLBO<T> : IDisposable, HCDKGEPIPEB, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KEIHFOCJOJN<T> HMIMLECNHJK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x52A02A0", Offset = "0x529ECA0", VA = "0x1852A02A0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x52A02D0", Offset = "0x529ECD0", VA = "0x1852A02D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x52A0320", Offset = "0x529ED20", VA = "0x1852A0320")]
	public static LOBNJMIFLBO<T> FMDOFBCLPJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4B332F0", Offset = "0x4B31CF0", VA = "0x184B332F0")]
	internal LOBNJMIFLBO([In] KEIHFOCJOJN<T> LALBBHEFJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x52A0300", Offset = "0x529ED00", VA = "0x1852A0300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x52A0470", Offset = "0x529EE70", VA = "0x1852A0470")]
	public void MFHLJMENBFO(int IMCIONKBBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x52A0430", Offset = "0x529EE30", VA = "0x1852A0430", Slot = "8")]
	public KEIHFOCJOJN<T>.JNNCFAPAAGP GetEnumerator()
	{
		return default(KEIHFOCJOJN<T>.JNNCFAPAAGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x52A0490", Offset = "0x529EE90", VA = "0x1852A0490", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x52A0490", Offset = "0x529EE90", VA = "0x1852A0490", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct HCEBFOBENFM<T, U> : IEnumerable<T>, IEnumerable where U : MAEKCCLOHDB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U OJMKBGEJMOK;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x11467A0", Offset = "0x11451A0", VA = "0x1811467A0")]
	internal HCEBFOBENFM([In] U EJDGCMPDMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x11465A0", Offset = "0x1144FA0", VA = "0x1811465A0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4C86D60", Offset = "0x4C85760", VA = "0x184C86D60", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4C86D60", Offset = "0x4C85760", VA = "0x184C86D60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EIDPIFOGFGM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBAA0", Offset = "0x3ECA4A0", VA = "0x183ECBAA0")]
	public static HCEBFOBENFM<T, U> FMDOFBCLPJB<U>([In] U NMEFAPBBOCD) where U : MAEKCCLOHDB<T>
	{
		return default(HCEBFOBENFM<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JMFAKIEAKAN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x50AC200", Offset = "0x50AAC00", VA = "0x1850AC200")]
	public static GLIIFEKENJO<T, NGANBABNFCD<T>> FMDOFBCLPJB([In] T[] NMEFAPBBOCD)
	{
		return default(GLIIFEKENJO<T, NGANBABNFCD<T>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct GLIIFEKENJO<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U OJMKBGEJMOK;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4C87110", Offset = "0x4C85B10", VA = "0x184C87110")]
	internal GLIIFEKENJO([In] U EJDGCMPDMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2AF88F0", Offset = "0x2AF72F0", VA = "0x182AF88F0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4C86BD0", Offset = "0x4C855D0", VA = "0x184C86BD0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4C86BD0", Offset = "0x4C855D0", VA = "0x184C86BD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DLKDFBKIFJB<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB9E0", Offset = "0x3ECA3E0", VA = "0x183ECB9E0")]
	public static GLIIFEKENJO<T, U> FMDOFBCLPJB<U>([In] U NMEFAPBBOCD) where U : IEnumerator<T>
	{
		return default(GLIIFEKENJO<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LMPPFENBOEG
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3B23440", Offset = "0x3B21E40", VA = "0x183B23440")]
	public static GLIIFEKENJO<TResult, JENCINMBPPG<TSourceEnumerator, TSource, TResult>> KHMGJHGPDMM<TResult, TSourceEnumerator, TSource>([In] this GLIIFEKENJO<TSource, TSourceEnumerator> NMEFAPBBOCD, Func<TSource, TResult> PCPPPLCEIDL) where TSourceEnumerator : HCDKGEPIPEB, IEnumerator<TSource>
	{
		return default(GLIIFEKENJO<TResult, JENCINMBPPG<TSourceEnumerator, TSource, TResult>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct NGANBABNFCD<T> : IEnumerator<T>, IEnumerator, IDisposable, HCDKGEPIPEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly T[] FAIIDMPFLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int PMHNNCIPMBM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly T NBBAKIJBGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5500EE0", Offset = "0x54FF8E0", VA = "0x185500EE0", Slot = "4")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4B5F000", Offset = "0x4B5DA00", VA = "0x184B5F000", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xCA8340", Offset = "0xCA6D40", VA = "0x180CA8340")]
	private NGANBABNFCD(T[] NMEFAPBBOCD, int MNFHMLCLFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4B5EE90", Offset = "0x4B5D890", VA = "0x184B5EE90")]
	public static NGANBABNFCD<T> FMDOFBCLPJB(T[] NMEFAPBBOCD)
	{
		return default(NGANBABNFCD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x28E9B20", Offset = "0x28E8520", VA = "0x1828E9B20", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x28E9520", Offset = "0x28E7F20", VA = "0x1828E9520", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct JENCINMBPPG<TSourceEnumerator, TSource, TResult> : HCDKGEPIPEB, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : HCDKGEPIPEB, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private TSourceEnumerator FAIIDMPFLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<TSource, TResult> EIPCGFKHNEF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly TResult NBBAKIJBGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x50898A0", Offset = "0x50882A0", VA = "0x1850898A0", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5089820", Offset = "0x5088220", VA = "0x185089820", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2903AB0", Offset = "0x29024B0", VA = "0x182903AB0")]
	internal JENCINMBPPG([In] TSourceEnumerator NMEFAPBBOCD, Func<TSource, TResult> PCPPPLCEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5089710", Offset = "0x5088110", VA = "0x185089710", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5089750", Offset = "0x5088150", VA = "0x185089750", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5089630", Offset = "0x5088030", VA = "0x185089630", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class PADPGKKJAIO
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3C04EB0", Offset = "0x3C038B0", VA = "0x183C04EB0")]
	public static string COHMJJNBFIC<T>(this IEnumerable<T> NMEFAPBBOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3C09070", Offset = "0x3C07A70", VA = "0x183C09070")]
	public static string HNKNHLCGNMG<T>(this IEnumerable<T> NMEFAPBBOCD, string JMPANJMGMPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BKHDKPKBCAC
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x37F30D0", Offset = "0x37F1AD0", VA = "0x1837F30D0")]
	public static bool KNKPHFJABPO<TSourceEnumerator, TSource>(this TSourceEnumerator NMEFAPBBOCD, [In] TSource HMJJODPHKCG) where TSourceEnumerator : MAEKCCLOHDB<TSource> where TSource : FFDBOPCMCDN<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x37F3320", Offset = "0x37F1D20", VA = "0x1837F3320")]
	public static int PAPKBMNBEDC<TSourceEnumerator, TSource>(this TSourceEnumerator NMEFAPBBOCD, [In] TSource PCDAHJCDHHF) where TSourceEnumerator : MAEKCCLOHDB<TSource> where TSource : FFDBOPCMCDN<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x37F3070", Offset = "0x37F1A70", VA = "0x1837F3070")]
	public static JENCINMBPPG<TSourceEnumerator, TSource, TResult> KHMGJHGPDMM<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator NMEFAPBBOCD, Func<TSource, TResult> PCPPPLCEIDL) where TSourceEnumerator : HCDKGEPIPEB, IEnumerator<TSource>
	{
		return default(JENCINMBPPG<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x37F2ED0", Offset = "0x37F18D0", VA = "0x1837F2ED0")]
	public static int DKALLHGGHPC<TSourceEnumerator, TSource>(this TSourceEnumerator NMEFAPBBOCD, [In] TSource PCDAHJCDHHF) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MAEKCCLOHDB<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	T NBBAKIJBGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HCDKGEPIPEB
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PNBDFJFKBJG<T> : MAEKCCLOHDB<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct OGKDKEAIMPD<T, U> : IEnumerable<T>, IEnumerable where U : PNBDFJFKBJG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly U OJMKBGEJMOK;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4C870F0", Offset = "0x4C85AF0", VA = "0x184C870F0")]
	internal OGKDKEAIMPD([In] U EJDGCMPDMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x46BA3C0", Offset = "0x46B8DC0", VA = "0x1846BA3C0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4C86DD0", Offset = "0x4C857D0", VA = "0x184C86DD0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4C86DD0", Offset = "0x4C857D0", VA = "0x184C86DD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class PMAMKPNMFMF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBA10", Offset = "0x3ECA410", VA = "0x183ECBA10")]
	public static OGKDKEAIMPD<T, U> FMDOFBCLPJB<U>([In] U NMEFAPBBOCD) where U : PNBDFJFKBJG<T>
	{
		return default(OGKDKEAIMPD<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public readonly struct BEGCCOONNLO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct FOIJACGCMMC : HCDKGEPIPEB, MAEKCCLOHDB<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] FAIIDMPFLOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int PMHNNCIPMBM;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T NBBAKIJBGKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x4B5F600", Offset = "0x4B5E000", VA = "0x184B5F600", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4B5F000", Offset = "0x4B5DA00", VA = "0x184B5F000", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4B5F2D0", Offset = "0x4B5DCD0", VA = "0x184B5F2D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xCA8340", Offset = "0xCA6D40", VA = "0x180CA8340")]
		private FOIJACGCMMC(T[] NMEFAPBBOCD, int MNFHMLCLFEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4B5EE90", Offset = "0x4B5D890", VA = "0x184B5EE90")]
		public static FOIJACGCMMC FMDOFBCLPJB(T[] NMEFAPBBOCD)
		{
			return default(FOIJACGCMMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x28E9B20", Offset = "0x28E8520", VA = "0x1828E9B20", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x28E9520", Offset = "0x28E7F20", VA = "0x1828E9520", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly T[] PFJHIPPDDHJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DNLMLJALHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x521AC20", Offset = "0x5219620", VA = "0x18521AC20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3A48530", Offset = "0x3A46F30", VA = "0x183A48530")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xDCCB40", Offset = "0xDCB540", VA = "0x180DCCB40")]
	internal BEGCCOONNLO(T[] KLDOGKPLNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x602AA20", Offset = "0x6029420", VA = "0x18602AA20")]
	public static BEGCCOONNLO<T> BOAAIAHJNJN()
	{
		return default(BEGCCOONNLO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
	public IEnumerable<T> IIFEJKKLGMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x602ABE0", Offset = "0x60295E0", VA = "0x18602ABE0")]
	public ReadOnlySpan<T> IBGJCCKMCID()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x602AAD0", Offset = "0x60294D0", VA = "0x18602AAD0")]
	public HCEBFOBENFM<T, BEGCCOONNLO<T>.FOIJACGCMMC> CDAJGALPHAF()
	{
		return default(HCEBFOBENFM<T, FOIJACGCMMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x602ACF0", Offset = "0x60296F0", VA = "0x18602ACF0")]
	public FOIJACGCMMC OBIBIEILBNM()
	{
		return default(FOIJACGCMMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x602AC70", Offset = "0x6029670", VA = "0x18602AC70")]
	public IEnumerator<T> ICNPOCIJNJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x602AD80", Offset = "0x6029780", VA = "0x18602AD80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FFPEMKAHJPM
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2FF2A30", Offset = "0x2FF1430", VA = "0x182FF2A30")]
	public static BEGCCOONNLO<T> PNHHBBPMFPH<T>(params T[] KLDOGKPLNJA) where T : notnull
	{
		return default(BEGCCOONNLO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE350", Offset = "0x7EACD50", VA = "0x187EAE350")]
	public static Stream OPPPBMELJML(this BEGCCOONNLO<byte> NMEFAPBBOCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DebuggerTypeProxy(typeof(KEIHFOCJOJN<>.DPBADCPDDGD))]
public struct KEIHFOCJOJN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct JNNCFAPAAGP : HCDKGEPIPEB, PNBDFJFKBJG<T>, MAEKCCLOHDB<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly T[] BJDFFOOELLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int KHOPNLPMCMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int PMHNNCIPMBM;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly T NBBAKIJBGKK
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x50C8420", Offset = "0x50C6E20", VA = "0x1850C8420", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T KLJFFMMNIND
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x50C7AD0", Offset = "0x50C64D0", VA = "0x1850C7AD0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private readonly T KHCFJJIPHGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x50C7BA0", Offset = "0x50C65A0", VA = "0x1850C7BA0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x50C7E00", Offset = "0x50C6800", VA = "0x1850C7E00", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x50C81A0", Offset = "0x50C6BA0", VA = "0x1850C81A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4B43C50", Offset = "0x4B42650", VA = "0x184B43C50")]
		internal JNNCFAPAAGP(T[] PCNLBIOPFBD, int IMCIONKBBCL, int MNFHMLCLFEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x50C7940", Offset = "0x50C6340", VA = "0x1850C7940")]
		public static JNNCFAPAAGP FMDOFBCLPJB(KEIHFOCJOJN<T> NMEFAPBBOCD)
		{
			return default(JNNCFAPAAGP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4754790", Offset = "0x4753190", VA = "0x184754790", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4750530", Offset = "0x474EF30", VA = "0x184750530", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct KBMFAMKBEAA : HCDKGEPIPEB, MAEKCCLOHDB<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private JNNCFAPAAGP OJMKBGEJMOK;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public readonly T NBBAKIJBGKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x517FC40", Offset = "0x517E640", VA = "0x18517FC40", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x517F800", Offset = "0x517E200", VA = "0x18517F800", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x517F9F0", Offset = "0x517E3F0", VA = "0x18517F9F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x11467A0", Offset = "0x11451A0", VA = "0x1811467A0")]
		private KBMFAMKBEAA([In] JNNCFAPAAGP EJDGCMPDMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x517F6D0", Offset = "0x517E0D0", VA = "0x18517F6D0")]
		public static KBMFAMKBEAA FMDOFBCLPJB([In] KEIHFOCJOJN<T> NMEFAPBBOCD)
		{
			return default(KBMFAMKBEAA);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x517F780", Offset = "0x517E180", VA = "0x18517F780", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x517F7C0", Offset = "0x517E1C0", VA = "0x18517F7C0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5089630", Offset = "0x5088030", VA = "0x185089630", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class DPBADCPDDGD
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal T[] BJDFFOOELLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal int KHOPNLPMCMN;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x51B2920", Offset = "0x51B1320", VA = "0x1851B2920")]
	public static KEIHFOCJOJN<T> FMDOFBCLPJB()
	{
		return default(KEIHFOCJOJN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x51B29C0", Offset = "0x51B13C0", VA = "0x1851B29C0")]
	public static KEIHFOCJOJN<T> GGAFBPCHIMP(int OOPBDBFKCBI)
	{
		return default(KEIHFOCJOJN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xCA8340", Offset = "0xCA6D40", VA = "0x180CA8340")]
	internal KEIHFOCJOJN(T[] PCNLBIOPFBD, int IMCIONKBBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x51B2A70", Offset = "0x51B1470", VA = "0x1851B2A70", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class GLHPBKMMOEI
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate int EKEIIOIFGLN<TCtx, T>([In] TCtx MOCCEAFKGMN, T LCMCGCNDGLJ, T JAOCPECLJLL);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3A6E8C0", Offset = "0x3A6D2C0", VA = "0x183A6E8C0")]
	public static void EFCPNMLOGFP<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3A6EC90", Offset = "0x3A6D690", VA = "0x183A6EC90")]
	public static string ENIBMHHIMPH<T>([In] this KEIHFOCJOJN<T> NMEFAPBBOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
	public static T[] HOGLPPACDKN<T>([In] this KEIHFOCJOJN<T> NMEFAPBBOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3A48500", Offset = "0x3A46F00", VA = "0x183A48500")]
	public static T IBPMNADNGOO<T>([In] this KEIHFOCJOJN<T> NMEFAPBBOCD, int LFGCGKOHNIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3A72510", Offset = "0x3A70F10", VA = "0x183A72510")]
	public static T ICLBFFKPGDD<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD, int LFGCGKOHNIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3A77C40", Offset = "0x3A76640", VA = "0x183A77C40")]
	public static T OJEOONLHIBA<T>([In] this KEIHFOCJOJN<T> NMEFAPBBOCD, int LFGCGKOHNIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3A6E150", Offset = "0x3A6CB50", VA = "0x183A6E150")]
	public static void DGDFODDEBEH<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD, int LFGCGKOHNIA, [In] T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3A77940", Offset = "0x3A76340", VA = "0x183A77940")]
	public static void OEEOLLJMOPG<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD, int LFGCGKOHNIA, T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xE4ADD0", Offset = "0xE497D0", VA = "0x180E4ADD0")]
	public static int GNDFLCMCIAD<T>([In] this KEIHFOCJOJN<T> NMEFAPBBOCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3A723C0", Offset = "0x3A70DC0", VA = "0x183A723C0")]
	public static ReadOnlySpan<T> IBGJCCKMCID<T>([In] this KEIHFOCJOJN<T> NMEFAPBBOCD)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3A772D0", Offset = "0x3A75CD0", VA = "0x183A772D0")]
	public static T[] MIIOAFGHJMG<T>([In] this KEIHFOCJOJN<T> NMEFAPBBOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3A78460", Offset = "0x3A76E60", VA = "0x183A78460")]
	public static T PIALLLNAIPN<T>([In] this KEIHFOCJOJN<T> NMEFAPBBOCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3A78480", Offset = "0x3A76E80", VA = "0x183A78480")]
	public static T[] PJAKLKCJAFH<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3A72740", Offset = "0x3A71140", VA = "0x183A72740")]
	public static BEGCCOONNLO<T> KGACJBJDMAB<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD)
	{
		return default(BEGCCOONNLO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3A77F10", Offset = "0x3A76910", VA = "0x183A77F10")]
	public static void PBDMKLNODMP<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD, [In] T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3A74620", Offset = "0x3A73020", VA = "0x183A74620")]
	public static void LMKEBFKJBJB<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD, T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3A77650", Offset = "0x3A76050", VA = "0x183A77650")]
	public static void NLEEAEJAGIN<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD, int MNFHMLCLFEB, [In] T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3A722E0", Offset = "0x3A70CE0", VA = "0x183A722E0")]
	public static void GBOBFIOJCEM<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD, int MNFHMLCLFEB, [In] KEIHFOCJOJN<T> OKEIIBNBBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3A727D0", Offset = "0x3A711D0", VA = "0x183A727D0")]
	public static void LAJLAFIFGOM<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD, int MNFHMLCLFEB, T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3A72380", Offset = "0x3A70D80", VA = "0x183A72380")]
	public static void GLDJLNODHCI<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD, int MNFHMLCLFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3A6DEC0", Offset = "0x3A6C8C0", VA = "0x183A6DEC0")]
	public static T CMJBJEEPNDN<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3A75330", Offset = "0x3A73D30", VA = "0x183A75330")]
	public static void MFHLJMENBFO<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD, int IMCIONKBBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3A72B70", Offset = "0x3A71570", VA = "0x183A72B70")]
	private static void LMAEMFEAKIG<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD, int OOPBDBFKCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3A77540", Offset = "0x3A75F40", VA = "0x183A77540")]
	public static void MPMJEFEEPDP<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3A71B50", Offset = "0x3A70550", VA = "0x183A71B50")]
	public static KEIHFOCJOJN<T> FDFMDNPNFDC<T>([In] this KEIHFOCJOJN<T> NMEFAPBBOCD, IIKLLKAFEPM<T, T> MMJINKJABOC)
	{
		return default(KEIHFOCJOJN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3A6DF20", Offset = "0x3A6C920", VA = "0x183A6DF20")]
	public static bool DAAFLACHELB<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD, T PCDAHJCDHHF) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3A77E70", Offset = "0x3A76870", VA = "0x183A77E70")]
	public static bool ONOPJLCJEEI<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD, [In] T PCDAHJCDHHF) where T : FFDBOPCMCDN<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3A74810", Offset = "0x3A73210", VA = "0x183A74810")]
	public static bool MCFAHADANHE<T>([In] this KEIHFOCJOJN<T> NMEFAPBBOCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3A6DE80", Offset = "0x3A6C880", VA = "0x183A6DE80")]
	public static bool BPIIGCEKLLI<T>([In] this KEIHFOCJOJN<T> NMEFAPBBOCD, int LFGCGKOHNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3A6DE50", Offset = "0x3A6C850", VA = "0x183A6DE50")]
	public static void ALEFDICCFOJ<T, TCtx>(this KEIHFOCJOJN<T> NMEFAPBBOCD, [In] TCtx MOCCEAFKGMN, EKEIIOIFGLN<TCtx, T> BAPNOKHMAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3A6E800", Offset = "0x3A6D200", VA = "0x183A6E800")]
	private static void DPHNNENFNEI<T, TCtx>(KEIHFOCJOJN<T> NMEFAPBBOCD, [In] TCtx MOCCEAFKGMN, EKEIIOIFGLN<TCtx, T> BAPNOKHMAOI, int LAEKDIPMMGB, int BJIFMNLOANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3A71E90", Offset = "0x3A70890", VA = "0x183A71E90")]
	private static int FGKBEHMIILI<T, TCtx>(KEIHFOCJOJN<T> NMEFAPBBOCD, [In] TCtx MOCCEAFKGMN, EKEIIOIFGLN<TCtx, T> BAPNOKHMAOI, int LAEKDIPMMGB, int BJIFMNLOANA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2FF2A00", Offset = "0x2FF1400", VA = "0x182FF2A00")]
	public static KEIHFOCJOJN<T>.KBMFAMKBEAA ICNPOCIJNJG<T>([In] this KEIHFOCJOJN<T> NMEFAPBBOCD)
	{
		return default(KEIHFOCJOJN<T>.KBMFAMKBEAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2FF2A00", Offset = "0x2FF1400", VA = "0x182FF2A00")]
	public static KEIHFOCJOJN<T>.JNNCFAPAAGP MGNODAEHJLC<T>(this KEIHFOCJOJN<T> NMEFAPBBOCD)
	{
		return default(KEIHFOCJOJN<T>.JNNCFAPAAGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2FF1CA0", Offset = "0x2FF06A0", VA = "0x182FF1CA0")]
	public static HCEBFOBENFM<T, KEIHFOCJOJN<T>.KBMFAMKBEAA> CADGIHFEHPD<T>([In] this KEIHFOCJOJN<T> NMEFAPBBOCD)
	{
		return default(HCEBFOBENFM<T, KEIHFOCJOJN<T>.KBMFAMKBEAA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class PPGCDGJBBEC
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3C2B570", Offset = "0x3C29F70", VA = "0x183C2B570")]
	public static T[] MIGDOLEADEL<T>(int OPKPFANIILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	public static void GECJAHANAPK<T>(T[] KLDOGKPLNJA)
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
