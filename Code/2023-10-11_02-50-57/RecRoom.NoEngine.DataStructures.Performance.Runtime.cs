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
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D53CE0", Offset = "0x5D52AE0", VA = "0x185D53CE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C910", Offset = "0x78B710", VA = "0x18078C910")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C950", Offset = "0x78B750", VA = "0x18078C950")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FBMCJEOLBDF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2284460", Offset = "0x2283260", VA = "0x182284460")]
	public static AMEOGFHMEMI<T> FOEMHBIDINC<T>(this T[] LNKCIHFCLHG) where T : notnull
	{
		return default(AMEOGFHMEMI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class OCIABHPKFGG<T> : IDisposable, NKJGHKBDKKA, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KBKGDPMJLMN<T> CACPHFDOACB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3C95070", Offset = "0x3C93E70", VA = "0x183C95070", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3C94EB0", Offset = "0x3C93CB0", VA = "0x183C94EB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C950C0", Offset = "0x3C93EC0", VA = "0x183C950C0")]
	public static OCIABHPKFGG<T> NPAOPBPEFCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3C94F50", Offset = "0x3C93D50", VA = "0x183C94F50")]
	public static OCIABHPKFGG<T> JIHNBFHMFAL(int DECKGNHFLHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x35A9040", Offset = "0x35A7E40", VA = "0x1835A9040")]
	internal OCIABHPKFGG([In] KBKGDPMJLMN<T> BAHHCFCHDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3C94EE0", Offset = "0x3C93CE0", VA = "0x183C94EE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3C94E90", Offset = "0x3C93C90", VA = "0x183C94E90")]
	public void AAFNAGDLNDC([In] T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C950A0", Offset = "0x3C93EA0", VA = "0x183C950A0")]
	public void KOBKOGHAPDN(int HLFCMANHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C94F00", Offset = "0x3C93D00", VA = "0x183C94F00", Slot = "8")]
	public KBKGDPMJLMN<T>.IBEBELAMACE GetEnumerator()
	{
		return default(KBKGDPMJLMN<T>.IBEBELAMACE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3C951E0", Offset = "0x3C93FE0", VA = "0x183C951E0", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3C951E0", Offset = "0x3C93FE0", VA = "0x183C951E0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct NJMEHPFKODN<T, U> : IEnumerable<T>, IEnumerable where U : DDPHGEFEMHP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U MPEILFDENEE;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1C17830", Offset = "0x1C16630", VA = "0x181C17830")]
	internal NJMEHPFKODN([In] U LOJCJECHJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x34E01D0", Offset = "0x34DEFD0", VA = "0x1834E01D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x34E01D0", Offset = "0x34DEFD0", VA = "0x1834E01D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GNLEPGEPGDM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2002F80", Offset = "0x2001D80", VA = "0x182002F80")]
	public static NJMEHPFKODN<T, U> NPAOPBPEFCO<U>([In] U LNKCIHFCLHG) where U : DDPHGEFEMHP<T>
	{
		return default(NJMEHPFKODN<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct FLKGLBMDCIF<TSourceEnumerator, TSource, TResult> : NKJGHKBDKKA, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : NKJGHKBDKKA, DDPHGEFEMHP<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private TSourceEnumerator HNIELHDONPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly AMCHOOADKHA<TSource, TResult> BEHCFJKKGCA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x33F91A0", Offset = "0x33F7FA0", VA = "0x1833F91A0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public readonly TResult MNPEEGLNGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x33F9660", Offset = "0x33F8460", VA = "0x1833F9660", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x33F93C0", Offset = "0x33F81C0", VA = "0x1833F93C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x33F94F0", Offset = "0x33F82F0", VA = "0x1833F94F0")]
	internal FLKGLBMDCIF([In] TSourceEnumerator LNKCIHFCLHG, AMCHOOADKHA<TSource, TResult> HBDMMGNDEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x33F92A0", Offset = "0x33F80A0", VA = "0x1833F92A0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x33F9330", Offset = "0x33F8130", VA = "0x1833F9330", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x33F9110", Offset = "0x33F7F10", VA = "0x1833F9110", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct DAGOBKONPGP<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly U MPEILFDENEE;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4CB3150", Offset = "0x4CB1F50", VA = "0x184CB3150")]
	internal DAGOBKONPGP([In] U LOJCJECHJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4CB2F30", Offset = "0x4CB1D30", VA = "0x184CB2F30", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4CB2F30", Offset = "0x4CB1D30", VA = "0x184CB2F30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class PPLPEFMDBAI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2296180", Offset = "0x2294F80", VA = "0x182296180")]
	public static DAGOBKONPGP<T, U> NPAOPBPEFCO<U>([In] U LNKCIHFCLHG) where U : IEnumerator<T>
	{
		return default(DAGOBKONPGP<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GFIOGJFOPML<TSourceEnumerator, TSource, TResult> : NKJGHKBDKKA, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : NKJGHKBDKKA, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private TSourceEnumerator HNIELHDONPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<TSource, TResult> BEHCFJKKGCA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public readonly int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x33F91A0", Offset = "0x33F7FA0", VA = "0x1833F91A0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly TResult MNPEEGLNGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x34A82B0", Offset = "0x34A70B0", VA = "0x1834A82B0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x34A8120", Offset = "0x34A6F20", VA = "0x1834A8120", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x33F94F0", Offset = "0x33F82F0", VA = "0x1833F94F0")]
	internal GFIOGJFOPML([In] TSourceEnumerator LNKCIHFCLHG, Func<TSource, TResult> HBDMMGNDEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x33F92A0", Offset = "0x33F80A0", VA = "0x1833F92A0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x33F9330", Offset = "0x33F8130", VA = "0x1833F9330", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x33F9110", Offset = "0x33F7F10", VA = "0x1833F9110", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class NCMIHCGAKJF
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x24CB520", Offset = "0x24CA320", VA = "0x1824CB520")]
	public static string OJDBJKEBGCI<T>(this IEnumerable<T> LNKCIHFCLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x24BF020", Offset = "0x24BDE20", VA = "0x1824BF020")]
	public static string BBLCINPLMDO<T>(this IEnumerable<T> LNKCIHFCLHG, string ILPIFJPHILE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class OBLOENAEPJB
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x24ED520", Offset = "0x24EC320", VA = "0x1824ED520")]
	public static bool KPFIBFKLBPM<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator LNKCIHFCLHG, [In] TArgs HGIPKCLMBHH, [In] FBJEOEMOPOJ<TArgs, TSource, bool> MAPJOAGLKEG) where TSourceEnumerator : DDPHGEFEMHP<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x24ED320", Offset = "0x24EC120", VA = "0x1824ED320")]
	public static int AGEGDKMOOKH<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator LNKCIHFCLHG, [In] TArgs HGIPKCLMBHH, FBJEOEMOPOJ<TArgs, TSource, bool> MAPJOAGLKEG) where TSourceEnumerator : DDPHGEFEMHP<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x24ED910", Offset = "0x24EC710", VA = "0x1824ED910")]
	public static bool OGCJNHGPOIE<TSourceEnumerator, TSource>(this TSourceEnumerator LNKCIHFCLHG, [In] TSource PEGAJFMFKFI) where TSourceEnumerator : DDPHGEFEMHP<TSource> where TSource : EPNKPOMOGEO<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x24ED6B0", Offset = "0x24EC4B0", VA = "0x1824ED6B0")]
	public static int LNFPKKNKDMN<TSourceEnumerator, TSource>(this TSourceEnumerator LNKCIHFCLHG, [In] TSource GNLEHBFFNFG) where TSourceEnumerator : DDPHGEFEMHP<TSource> where TSource : EPNKPOMOGEO<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x24ED4C0", Offset = "0x24EC2C0", VA = "0x1824ED4C0")]
	public static FLKGLBMDCIF<TSourceEnumerator, TSource, TResult> CILCPBLCDAK<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator LNKCIHFCLHG, AMCHOOADKHA<TSource, TResult> HBDMMGNDEED) where TSourceEnumerator : NKJGHKBDKKA, DDPHGEFEMHP<TSource>
	{
		return default(FLKGLBMDCIF<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x24ED4C0", Offset = "0x24EC2C0", VA = "0x1824ED4C0")]
	public static GFIOGJFOPML<TSourceEnumerator, TSource, TResult> NDLCHDKHMFL<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator LNKCIHFCLHG, Func<TSource, TResult> HBDMMGNDEED) where TSourceEnumerator : NKJGHKBDKKA, IEnumerator<TSource>
	{
		return default(GFIOGJFOPML<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DANEAHDAHKH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2BCE550", Offset = "0x2BCD350", VA = "0x182BCE550")]
	public static bool FJMHBNBGEHA<TSourceEnumerator>(TSourceEnumerator LNKCIHFCLHG) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2BCE320", Offset = "0x2BCD120", VA = "0x182BCE320")]
	public static T ECHPINDCBGM<TSourceEnumerator>(TSourceEnumerator LNKCIHFCLHG) where TSourceEnumerator : DDPHGEFEMHP<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF2C0", Offset = "0x2BCE0C0", VA = "0x182BCF2C0")]
	public static T[] NOGBDJGMMDK<TSourceEnumerator>(TSourceEnumerator LNKCIHFCLHG) where TSourceEnumerator : NKJGHKBDKKA, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2BCE450", Offset = "0x2BCD250", VA = "0x182BCE450")]
	public static T EIHAOLHINBP<TSourceEnumerator>(TSourceEnumerator LNKCIHFCLHG) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DDPHGEFEMHP<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T MNPEEGLNGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NKJGHKBDKKA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MAOGFLKPIEJ<T> : DDPHGEFEMHP<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct GNLPFIDELDG<T, U> : IEnumerable<T>, IEnumerable where U : MAOGFLKPIEJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly U MPEILFDENEE;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x34E0250", Offset = "0x34DF050", VA = "0x1834E0250")]
	internal GNLPFIDELDG([In] U LOJCJECHJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3117360", Offset = "0x3116160", VA = "0x183117360", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x34E0110", Offset = "0x34DEF10", VA = "0x1834E0110", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x34E0110", Offset = "0x34DEF10", VA = "0x1834E0110", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class AJOLFGNMLGC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2002FB0", Offset = "0x2001DB0", VA = "0x182002FB0")]
	public static GNLPFIDELDG<T, U> NPAOPBPEFCO<U>([In] U LNKCIHFCLHG) where U : MAOGFLKPIEJ<T>
	{
		return default(GNLPFIDELDG<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public readonly struct AMEOGFHMEMI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct FIAFECFKBJA : NKJGHKBDKKA, DDPHGEFEMHP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] HNIELHDONPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int GNMPNJODIBF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly int CBILAPKHPBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1C2D170", Offset = "0x1C2BF70", VA = "0x181C2D170", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T MNPEEGLNGOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x33E03C0", Offset = "0x33DF1C0", VA = "0x1833E03C0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x33DFE40", Offset = "0x33DEC40", VA = "0x1833DFE40", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x33E0280", Offset = "0x33DF080", VA = "0x1833E0280", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1665CC0", Offset = "0x1664AC0", VA = "0x181665CC0")]
		private FIAFECFKBJA(T[] LNKCIHFCLHG, int DOJILIOCHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x33DFD30", Offset = "0x33DEB30", VA = "0x1833DFD30")]
		public static FIAFECFKBJA NPAOPBPEFCO(T[] LNKCIHFCLHG)
		{
			return default(FIAFECFKBJA);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1C2D190", Offset = "0x1C2BF90", VA = "0x181C2D190", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1C2D1F0", Offset = "0x1C2BFF0", VA = "0x181C2D1F0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly T[] BDNDAKCLBLO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DCLHHJJDFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1C2D170", Offset = "0x1C2BF70", VA = "0x181C2D170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2500F00", Offset = "0x24FFD00", VA = "0x182500F00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F19C0", Offset = "0x7F07C0", VA = "0x1807F19C0")]
	internal AMEOGFHMEMI(T[] FNIMPMJDPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3522A00", Offset = "0x3521800", VA = "0x183522A00")]
	public static AMEOGFHMEMI<T> AFMDONMGHHC()
	{
		return default(AMEOGFHMEMI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
	public IEnumerable<T> JOLNIBPPPID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3522CF0", Offset = "0x3521AF0", VA = "0x183522CF0")]
	public ReadOnlySpan<T> MLEBLMMOHPP()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3522B50", Offset = "0x3521950", VA = "0x183522B50")]
	public NJMEHPFKODN<T, AMEOGFHMEMI<T>.FIAFECFKBJA> HCFJGDKFLIL()
	{
		return default(NJMEHPFKODN<T, FIAFECFKBJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3522AC0", Offset = "0x35218C0", VA = "0x183522AC0")]
	public FIAFECFKBJA CBLHMBOEEJF()
	{
		return default(FIAFECFKBJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3522C70", Offset = "0x3521A70", VA = "0x183522C70")]
	public IEnumerator<T> MIBGMGJFDKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3522D80", Offset = "0x3521B80", VA = "0x183522D80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class EAMFOCHCOMC
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x21CDDA0", Offset = "0x21CCBA0", VA = "0x1821CDDA0")]
	public static AMEOGFHMEMI<T> ACPJNOFMJLH<T>(params T[] FNIMPMJDPGM) where T : notnull
	{
		return default(AMEOGFHMEMI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5D53C80", Offset = "0x5D52A80", VA = "0x185D53C80")]
	public static Stream ONJDKHNPIPO(this AMEOGFHMEMI<byte> LNKCIHFCLHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DebuggerTypeProxy(typeof(KBKGDPMJLMN<>.BLPNGKDKNPG))]
public struct KBKGDPMJLMN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct IBEBELAMACE : NKJGHKBDKKA, MAOGFLKPIEJ<T>, DDPHGEFEMHP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly T[] FHHLPPMBMDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int KPBIKEPENFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int GNMPNJODIBF;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly int CBILAPKHPBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x1C3FD50", Offset = "0x1C3EB50", VA = "0x181C3FD50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public readonly T MNPEEGLNGOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3643CD0", Offset = "0x3642AD0", VA = "0x183643CD0", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private readonly T GILDCLLINIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3643440", Offset = "0x3642240", VA = "0x183643440", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x36435A0", Offset = "0x36423A0", VA = "0x1836435A0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x36439A0", Offset = "0x36427A0", VA = "0x1836439A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x33EFE30", Offset = "0x33EEC30", VA = "0x1833EFE30")]
		internal IBEBELAMACE(T[] LJMPIGIKCCJ, int HLFCMANHPKF, int DOJILIOCHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x36434E0", Offset = "0x36422E0", VA = "0x1836434E0")]
		public static IBEBELAMACE NPAOPBPEFCO(KBKGDPMJLMN<T> LNKCIHFCLHG)
		{
			return default(IBEBELAMACE);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x30D7E30", Offset = "0x30D6C30", VA = "0x1830D7E30", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x30D3A80", Offset = "0x30D2880", VA = "0x1830D3A80", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct PFICOKLEOCF : NKJGHKBDKKA, DDPHGEFEMHP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IBEBELAMACE MPEILFDENEE;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int CBILAPKHPBD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3DE1340", Offset = "0x3DE0140", VA = "0x183DE1340", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public readonly T MNPEEGLNGOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3DE1820", Offset = "0x3DE0620", VA = "0x183DE1820", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3DE14A0", Offset = "0x3DE02A0", VA = "0x183DE14A0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3DE1680", Offset = "0x3DE0480", VA = "0x183DE1680", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1C17830", Offset = "0x1C16630", VA = "0x181C17830")]
		private PFICOKLEOCF([In] IBEBELAMACE LOJCJECHJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3DE13B0", Offset = "0x3DE01B0", VA = "0x183DE13B0")]
		public static PFICOKLEOCF NPAOPBPEFCO([In] KBKGDPMJLMN<T> LNKCIHFCLHG)
		{
			return default(PFICOKLEOCF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3DE1370", Offset = "0x3DE0170", VA = "0x183DE1370", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3DE1460", Offset = "0x3DE0260", VA = "0x183DE1460", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3DE1300", Offset = "0x3DE0100", VA = "0x183DE1300", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class BLPNGKDKNPG
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal T[] FHHLPPMBMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal int KPBIKEPENFL;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x386ED60", Offset = "0x386DB60", VA = "0x18386ED60")]
	public static KBKGDPMJLMN<T> NPAOPBPEFCO()
	{
		return default(KBKGDPMJLMN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x386EC50", Offset = "0x386DA50", VA = "0x18386EC50")]
	public static KBKGDPMJLMN<T> JIHNBFHMFAL(int DECKGNHFLHF)
	{
		return default(KBKGDPMJLMN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1665CC0", Offset = "0x1664AC0", VA = "0x181665CC0")]
	internal KBKGDPMJLMN(T[] LJMPIGIKCCJ, int HLFCMANHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3680FD0", Offset = "0x367FDD0", VA = "0x183680FD0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class PABFIKKILAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2506770", Offset = "0x2505570", VA = "0x182506770")]
	public static void OKHJEEBGOJC<T>(this KBKGDPMJLMN<T> LNKCIHFCLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2501920", Offset = "0x2500720", VA = "0x182501920")]
	public static string HJGJDHJMKAO<T>([In] this KBKGDPMJLMN<T> LNKCIHFCLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
	public static T[] AGOALAAPEBJ<T>([In] this KBKGDPMJLMN<T> LNKCIHFCLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2501030", Offset = "0x24FFE30", VA = "0x182501030")]
	public static T OMJIHOMPBMI<T>([In] this KBKGDPMJLMN<T> LNKCIHFCLHG, int FJLKBMOCNHL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2501030", Offset = "0x24FFE30", VA = "0x182501030")]
	public static T GDIEPDELIPN<T>(this KBKGDPMJLMN<T> LNKCIHFCLHG, int FJLKBMOCNHL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x25011E0", Offset = "0x24FFFE0", VA = "0x1825011E0")]
	public static T HDONNLFCHJF<T>([In] this KBKGDPMJLMN<T> LNKCIHFCLHG, int FJLKBMOCNHL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2505050", Offset = "0x2503E50", VA = "0x182505050")]
	public static void KLJMIKDFPBF<T>(this KBKGDPMJLMN<T> LNKCIHFCLHG, int FJLKBMOCNHL, [In] T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2500D10", Offset = "0x24FFB10", VA = "0x182500D10")]
	public static void CMBANLBOECC<T>(this KBKGDPMJLMN<T> LNKCIHFCLHG, int FJLKBMOCNHL, T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1C3FD50", Offset = "0x1C3EB50", VA = "0x181C3FD50")]
	public static int HGAHKHKKFIA<T>([In] this KBKGDPMJLMN<T> LNKCIHFCLHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x25066A0", Offset = "0x25054A0", VA = "0x1825066A0")]
	public static ReadOnlySpan<T> MLEBLMMOHPP<T>([In] this KBKGDPMJLMN<T> LNKCIHFCLHG)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x25000C0", Offset = "0x24FEEC0", VA = "0x1825000C0")]
	public static void AAFNAGDLNDC<T>(this KBKGDPMJLMN<T> LNKCIHFCLHG, [In] T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2500390", Offset = "0x24FF190", VA = "0x182500390")]
	public static void CHMNCEOJBNE<T>(this KBKGDPMJLMN<T> LNKCIHFCLHG, int DOJILIOCHKM, [In] T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2500350", Offset = "0x24FF150", VA = "0x182500350")]
	public static void CBABDOGJLDM<T>(this KBKGDPMJLMN<T> LNKCIHFCLHG, int DOJILIOCHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2502D10", Offset = "0x2501B10", VA = "0x182502D10")]
	public static T JAPHEDDKFEA<T>(this KBKGDPMJLMN<T> LNKCIHFCLHG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2505870", Offset = "0x2504670", VA = "0x182505870")]
	public static void KOBKOGHAPDN<T>(this KBKGDPMJLMN<T> LNKCIHFCLHG, int HLFCMANHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2503D10", Offset = "0x2502B10", VA = "0x182503D10")]
	private static void KCJNPBICOGD<T>(this KBKGDPMJLMN<T> LNKCIHFCLHG, int DECKGNHFLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2500DF0", Offset = "0x24FFBF0", VA = "0x182500DF0")]
	public static void EOCKAINKMIG<T>(this KBKGDPMJLMN<T> LNKCIHFCLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2502D70", Offset = "0x2501B70", VA = "0x182502D70")]
	public static bool KBPNBPNFPNG<T>(this KBKGDPMJLMN<T> LNKCIHFCLHG, [In] T GNLEHBFFNFG) where T : EPNKPOMOGEO<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x24CE0C0", Offset = "0x24CCEC0", VA = "0x1824CE0C0")]
	public static bool LPLEMOIFKPC<T>([In] this KBKGDPMJLMN<T> LNKCIHFCLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x25011A0", Offset = "0x24FFFA0", VA = "0x1825011A0")]
	public static bool HAECEPCALFJ<T>([In] this KBKGDPMJLMN<T> LNKCIHFCLHG, int FJLKBMOCNHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x21F15B0", Offset = "0x21F03B0", VA = "0x1821F15B0")]
	public static KBKGDPMJLMN<T>.PFICOKLEOCF MIBGMGJFDKE<T>([In] this KBKGDPMJLMN<T> LNKCIHFCLHG)
	{
		return default(KBKGDPMJLMN<T>.PFICOKLEOCF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x21F15B0", Offset = "0x21F03B0", VA = "0x1821F15B0")]
	public static KBKGDPMJLMN<T>.IBEBELAMACE DAFFCPDHJOK<T>(this KBKGDPMJLMN<T> LNKCIHFCLHG)
	{
		return default(KBKGDPMJLMN<T>.IBEBELAMACE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x24D1380", Offset = "0x24D0180", VA = "0x1824D1380")]
	public static NJMEHPFKODN<T, KBKGDPMJLMN<T>.PFICOKLEOCF> CKPGIMAAEID<T>([In] this KBKGDPMJLMN<T> LNKCIHFCLHG)
	{
		return default(NJMEHPFKODN<T, KBKGDPMJLMN<T>.PFICOKLEOCF>);
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
