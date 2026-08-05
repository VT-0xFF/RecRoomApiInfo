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
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E8FC90", Offset = "0x5E8E490", VA = "0x185E8FC90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79CCC0", Offset = "0x79B4C0", VA = "0x18079CCC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79CD00", Offset = "0x79B500", VA = "0x18079CD00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KMMBMMPAAND
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x24C13A0", Offset = "0x24BFBA0", VA = "0x1824C13A0")]
	public static JPILNIGIINL<T> NGDLGKIENFE<T>(this T[] PIEBBHMNEOG) where T : notnull
	{
		return default(JPILNIGIINL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class CNAHPFGGOPF<T> : IDisposable, PNLLBFMDJIH, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OJBLBICDDLK<T> CBEPABHELEA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x49D5EF0", Offset = "0x49D46F0", VA = "0x1849D5EF0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x49D5F20", Offset = "0x49D4720", VA = "0x1849D5F20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x49D5C20", Offset = "0x49D4420", VA = "0x1849D5C20")]
	public static CNAHPFGGOPF<T> AKKFLOCCMNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x49D5DD0", Offset = "0x49D45D0", VA = "0x1849D5DD0")]
	public static CNAHPFGGOPF<T> KEHNAMKPONP(int JHAJBCMGPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x30F85E0", Offset = "0x30F6DE0", VA = "0x1830F85E0")]
	internal CNAHPFGGOPF([In] OJBLBICDDLK<T> EGAILLJGEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x49D5D40", Offset = "0x49D4540", VA = "0x1849D5D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x49D5DB0", Offset = "0x49D45B0", VA = "0x1849D5DB0")]
	public void INCGBOEKEGG([In] T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x49D5F50", Offset = "0x49D4750", VA = "0x1849D5F50")]
	public void PGILDKHMPAD(int PPKDCOOCBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x49D5D60", Offset = "0x49D4560", VA = "0x1849D5D60", Slot = "8")]
	public OJBLBICDDLK<T>.PMEIBCJGCEF GetEnumerator()
	{
		return default(OJBLBICDDLK<T>.PMEIBCJGCEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x49D5F70", Offset = "0x49D4770", VA = "0x1849D5F70", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x49D5F70", Offset = "0x49D4770", VA = "0x1849D5F70", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct FHBBDJEOIFM<T, U> : IEnumerable<T>, IEnumerable where U : GBIBKPDGAGA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U KBIICKNMEPM;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1CB2D20", Offset = "0x1CB1520", VA = "0x181CB2D20")]
	internal FHBBDJEOIFM([In] U MJDEBPJEPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3467B40", Offset = "0x3466340", VA = "0x183467B40", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3467B40", Offset = "0x3466340", VA = "0x183467B40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DAPBMABCMKM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x241E240", Offset = "0x241CA40", VA = "0x18241E240")]
	public static FHBBDJEOIFM<T, U> AKKFLOCCMNP<U>([In] U PIEBBHMNEOG) where U : GBIBKPDGAGA<T>
	{
		return default(FHBBDJEOIFM<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct KJCFLKOJALM<TSourceEnumerator, TSource, TResult> : PNLLBFMDJIH, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : PNLLBFMDJIH, GBIBKPDGAGA<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private TSourceEnumerator JCPOFAKDICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly HDFMNNEOBEA<TSource, TResult> NGNFPHMDGOL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3902F80", Offset = "0x3901780", VA = "0x183902F80", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public readonly TResult POHDIFHCONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x39034A0", Offset = "0x3901CA0", VA = "0x1839034A0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3903250", Offset = "0x3901A50", VA = "0x183903250", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3903310", Offset = "0x3901B10", VA = "0x183903310")]
	internal KJCFLKOJALM([In] TSourceEnumerator PIEBBHMNEOG, HDFMNNEOBEA<TSource, TResult> BKFAKEDANFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x39030D0", Offset = "0x39018D0", VA = "0x1839030D0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3903110", Offset = "0x3901910", VA = "0x183903110", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3902EF0", Offset = "0x39016F0", VA = "0x183902EF0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct LAAJNBMKMHO<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly U KBIICKNMEPM;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x39D2660", Offset = "0x39D0E60", VA = "0x1839D2660")]
	internal LAAJNBMKMHO([In] U MJDEBPJEPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x351BCE0", Offset = "0x351A4E0", VA = "0x18351BCE0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x39D2270", Offset = "0x39D0A70", VA = "0x1839D2270", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x39D2270", Offset = "0x39D0A70", VA = "0x1839D2270", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class OELDHBFFPOA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2425C40", Offset = "0x2424440", VA = "0x182425C40")]
	public static LAAJNBMKMHO<T, U> AKKFLOCCMNP<U>([In] U PIEBBHMNEOG) where U : IEnumerator<T>
	{
		return default(LAAJNBMKMHO<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MCDJJEFOINI<TSourceEnumerator, TSource, TResult> : PNLLBFMDJIH, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : PNLLBFMDJIH, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private TSourceEnumerator JCPOFAKDICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<TSource, TResult> NGNFPHMDGOL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public readonly int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3902F80", Offset = "0x3901780", VA = "0x183902F80", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly TResult POHDIFHCONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3C46E10", Offset = "0x3C45610", VA = "0x183C46E10", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3C46D60", Offset = "0x3C45560", VA = "0x183C46D60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3903310", Offset = "0x3901B10", VA = "0x183903310")]
	internal MCDJJEFOINI([In] TSourceEnumerator PIEBBHMNEOG, Func<TSource, TResult> BKFAKEDANFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x39030D0", Offset = "0x39018D0", VA = "0x1839030D0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3903110", Offset = "0x3901910", VA = "0x183903110", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3902EF0", Offset = "0x39016F0", VA = "0x183902EF0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class AGMCNFPGCMB
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2B23CC0", Offset = "0x2B224C0", VA = "0x182B23CC0")]
	public static string PPDMHOIOBPI<T>(this IEnumerable<T> PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2B15080", Offset = "0x2B13880", VA = "0x182B15080")]
	public static string CFELEPEDPJJ<T>(this IEnumerable<T> PIEBBHMNEOG, string MEAFPNFFPFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NICABABKHCF
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x262C860", Offset = "0x262B060", VA = "0x18262C860")]
	public static bool LMPPKGNBGEK<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator PIEBBHMNEOG, [In] TArgs ILIHAHINKGC, [In] MOMPLKMDJNG<TArgs, TSource, bool> FEGPOJMKOHE) where TSourceEnumerator : GBIBKPDGAGA<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x262C6C0", Offset = "0x262AEC0", VA = "0x18262C6C0")]
	public static int KDPHNEMOJMC<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator PIEBBHMNEOG, [In] TArgs ILIHAHINKGC, MOMPLKMDJNG<TArgs, TSource, bool> FEGPOJMKOHE) where TSourceEnumerator : GBIBKPDGAGA<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x262C280", Offset = "0x262AA80", VA = "0x18262C280")]
	public static bool AGDHECNDLDD<TSourceEnumerator, TSource>(this TSourceEnumerator PIEBBHMNEOG, [In] TSource BPGGEPDHIDJ) where TSourceEnumerator : GBIBKPDGAGA<TSource> where TSource : AIENODJKFOP<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x262C400", Offset = "0x262AC00", VA = "0x18262C400")]
	public static int FBNPDAEDCPL<TSourceEnumerator, TSource>(this TSourceEnumerator PIEBBHMNEOG, [In] TSource DOLICEBFIPF) where TSourceEnumerator : GBIBKPDGAGA<TSource> where TSource : AIENODJKFOP<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x262C660", Offset = "0x262AE60", VA = "0x18262C660")]
	public static KJCFLKOJALM<TSourceEnumerator, TSource, TResult> JIHLAHGJGEP<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator PIEBBHMNEOG, HDFMNNEOBEA<TSource, TResult> BKFAKEDANFO) where TSourceEnumerator : PNLLBFMDJIH, GBIBKPDGAGA<TSource>
	{
		return default(KJCFLKOJALM<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x262C660", Offset = "0x262AE60", VA = "0x18262C660")]
	public static MCDJJEFOINI<TSourceEnumerator, TSource, TResult> KCEMGOMMMCK<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator PIEBBHMNEOG, Func<TSource, TResult> BKFAKEDANFO) where TSourceEnumerator : PNLLBFMDJIH, IEnumerator<TSource>
	{
		return default(MCDJJEFOINI<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ILFPHBIGCAO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x20E8300", Offset = "0x20E6B00", VA = "0x1820E8300")]
	public static bool EPFECFHEFCH<TSourceEnumerator>(TSourceEnumerator PIEBBHMNEOG) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x20E8370", Offset = "0x20E6B70", VA = "0x1820E8370")]
	public static T HLFCNNIFDGL<TSourceEnumerator>(TSourceEnumerator PIEBBHMNEOG) where TSourceEnumerator : GBIBKPDGAGA<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2E2F770", Offset = "0x2E2DF70", VA = "0x182E2F770")]
	public static T[] BAPKBFBNCMK<TSourceEnumerator>(TSourceEnumerator PIEBBHMNEOG) where TSourceEnumerator : PNLLBFMDJIH, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x20E84A0", Offset = "0x20E6CA0", VA = "0x1820E84A0")]
	public static T OJAIAJLLFFJ<TSourceEnumerator>(TSourceEnumerator PIEBBHMNEOG) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GBIBKPDGAGA<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T POHDIFHCONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PNLLBFMDJIH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KCNOCDLCCDD<T> : GBIBKPDGAGA<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct OJHLENIALAP<T, U> : IEnumerable<T>, IEnumerable where U : KCNOCDLCCDD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly U KBIICKNMEPM;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3E1AF00", Offset = "0x3E19700", VA = "0x183E1AF00")]
	internal OJHLENIALAP([In] U MJDEBPJEPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x31B5B90", Offset = "0x31B4390", VA = "0x1831B5B90", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E1AE70", Offset = "0x3E19670", VA = "0x183E1AE70", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3E1AE70", Offset = "0x3E19670", VA = "0x183E1AE70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class LOLDFJNGDDK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x241E210", Offset = "0x241CA10", VA = "0x18241E210")]
	public static OJHLENIALAP<T, U> AKKFLOCCMNP<U>([In] U PIEBBHMNEOG) where U : KCNOCDLCCDD<T>
	{
		return default(OJHLENIALAP<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public readonly struct JPILNIGIINL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct DFPACEBHGFJ : PNLLBFMDJIH, GBIBKPDGAGA<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] JCPOFAKDICN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int IHJNGEFJLNN;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly int CADPCMFLDGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1CCB0F0", Offset = "0x1CC98F0", VA = "0x181CCB0F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T POHDIFHCONG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4DD31A0", Offset = "0x4DD19A0", VA = "0x184DD31A0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4DD2BF0", Offset = "0x4DD13F0", VA = "0x184DD2BF0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4DD2C40", Offset = "0x4DD1440", VA = "0x184DD2C40", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1752790", Offset = "0x1750F90", VA = "0x181752790")]
		private DFPACEBHGFJ(T[] PIEBBHMNEOG, int EAHCFBMNNCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4DD2950", Offset = "0x4DD1150", VA = "0x184DD2950")]
		public static DFPACEBHGFJ AKKFLOCCMNP(T[] PIEBBHMNEOG)
		{
			return default(DFPACEBHGFJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1CCB110", Offset = "0x1CC9910", VA = "0x181CCB110", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1CCB140", Offset = "0x1CC9940", VA = "0x181CCB140", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly T[] HPEPABKFOKC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FHJOOIBMPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1CCB0F0", Offset = "0x1CC98F0", VA = "0x181CCB0F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x25762E0", Offset = "0x2574AE0", VA = "0x1825762E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x873730", Offset = "0x871F30", VA = "0x180873730")]
	internal JPILNIGIINL(T[] CMKNCDNHDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x38B5CF0", Offset = "0x38B44F0", VA = "0x1838B5CF0")]
	public static JPILNIGIINL<T> NJCGGNOBEDM()
	{
		return default(JPILNIGIINL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
	public IEnumerable<T> EBOMDIGJGGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x38B5B50", Offset = "0x38B4350", VA = "0x1838B5B50")]
	public ReadOnlySpan<T> IHLEOMAIIFL()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x38B5A30", Offset = "0x38B4230", VA = "0x1838B5A30")]
	public FHBBDJEOIFM<T, JPILNIGIINL<T>.DFPACEBHGFJ> DOCCDDHLJNL()
	{
		return default(FHBBDJEOIFM<T, DFPACEBHGFJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x38B5C60", Offset = "0x38B4460", VA = "0x1838B5C60")]
	public DFPACEBHGFJ MBHOKPFHOFP()
	{
		return default(DFPACEBHGFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x38B5BE0", Offset = "0x38B43E0", VA = "0x1838B5BE0")]
	public IEnumerator<T> LLEMGPCMEFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x38B5DB0", Offset = "0x38B45B0", VA = "0x1838B5DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class HABMBDIBICL
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x24DABF0", Offset = "0x24D93F0", VA = "0x1824DABF0")]
	public static JPILNIGIINL<T> CECHEKPEAND<T>(params T[] CMKNCDNHDNA) where T : notnull
	{
		return default(JPILNIGIINL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FC30", Offset = "0x5E8E430", VA = "0x185E8FC30")]
	public static Stream GHHCJGOJHJA(this JPILNIGIINL<byte> PIEBBHMNEOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DebuggerTypeProxy(typeof(OJBLBICDDLK<>.LHCCNAMAEOJ))]
public struct OJBLBICDDLK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct PMEIBCJGCEF : PNLLBFMDJIH, KCNOCDLCCDD<T>, GBIBKPDGAGA<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly T[] DGLMBCIJILD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int IMGDFIOHHCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int IHJNGEFJLNN;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly int CADPCMFLDGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x1CDE7A0", Offset = "0x1CDCFA0", VA = "0x181CDE7A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public readonly T POHDIFHCONG
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3F1C2A0", Offset = "0x3F1AAA0", VA = "0x183F1C2A0", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private readonly T IGNPDGOEKMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3F1BB80", Offset = "0x3F1A380", VA = "0x183F1BB80", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3F1BC80", Offset = "0x3F1A480", VA = "0x183F1BC80", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3F1BEF0", Offset = "0x3F1A6F0", VA = "0x183F1BEF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x35F3970", Offset = "0x35F2170", VA = "0x1835F3970")]
		internal PMEIBCJGCEF(T[] BGOMBENDKBO, int PPKDCOOCBKP, int EAHCFBMNNCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3F1B990", Offset = "0x3F1A190", VA = "0x183F1B990")]
		public static PMEIBCJGCEF AKKFLOCCMNP(OJBLBICDDLK<T> PIEBBHMNEOG)
		{
			return default(PMEIBCJGCEF);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x31782F0", Offset = "0x3176AF0", VA = "0x1831782F0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x3170C10", Offset = "0x316F410", VA = "0x183170C10", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct JEGAOCIPMMJ : PNLLBFMDJIH, GBIBKPDGAGA<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private PMEIBCJGCEF KBIICKNMEPM;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int CADPCMFLDGP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x388BCE0", Offset = "0x388A4E0", VA = "0x18388BCE0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public readonly T POHDIFHCONG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x388C150", Offset = "0x388A950", VA = "0x18388C150", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x388BD90", Offset = "0x388A590", VA = "0x18388BD90", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x388BEC0", Offset = "0x388A6C0", VA = "0x18388BEC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1CB2D20", Offset = "0x1CB1520", VA = "0x181CB2D20")]
		private JEGAOCIPMMJ([In] PMEIBCJGCEF MJDEBPJEPIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x388BBF0", Offset = "0x388A3F0", VA = "0x18388BBF0")]
		public static JEGAOCIPMMJ AKKFLOCCMNP([In] OJBLBICDDLK<T> PIEBBHMNEOG)
		{
			return default(JEGAOCIPMMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x388BD10", Offset = "0x388A510", VA = "0x18388BD10", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x388BD50", Offset = "0x388A550", VA = "0x18388BD50", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x388BCA0", Offset = "0x388A4A0", VA = "0x18388BCA0", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class LHCCNAMAEOJ
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal T[] DGLMBCIJILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal int IMGDFIOHHCM;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3E1AAF0", Offset = "0x3E192F0", VA = "0x183E1AAF0")]
	public static OJBLBICDDLK<T> AKKFLOCCMNP()
	{
		return default(OJBLBICDDLK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3E1AC00", Offset = "0x3E19400", VA = "0x183E1AC00")]
	public static OJBLBICDDLK<T> KEHNAMKPONP(int JHAJBCMGPDO)
	{
		return default(OJBLBICDDLK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1752790", Offset = "0x1750F90", VA = "0x181752790")]
	internal OJBLBICDDLK(T[] BGOMBENDKBO, int PPKDCOOCBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x39055D0", Offset = "0x3903DD0", VA = "0x1839055D0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LKHGFKHKMHD
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x257D6F0", Offset = "0x257BEF0", VA = "0x18257D6F0")]
	public static void PIODDHMICMM<T>(this OJBLBICDDLK<T> PIEBBHMNEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2579F00", Offset = "0x2578700", VA = "0x182579F00")]
	public static string KGBEKIBDPAJ<T>([In] this OJBLBICDDLK<T> PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
	public static T[] LHJAKJDFLNC<T>([In] this OJBLBICDDLK<T> PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x25762E0", Offset = "0x2574AE0", VA = "0x1825762E0")]
	public static T BGCBNLKDELI<T>([In] this OJBLBICDDLK<T> PIEBBHMNEOG, int BOCONGADANC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x25762E0", Offset = "0x2574AE0", VA = "0x1825762E0")]
	public static T BKFMFNMDOPB<T>(this OJBLBICDDLK<T> PIEBBHMNEOG, int BOCONGADANC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2576850", Offset = "0x2575050", VA = "0x182576850")]
	public static T FIPFKHEBBPK<T>([In] this OJBLBICDDLK<T> PIEBBHMNEOG, int BOCONGADANC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2576F00", Offset = "0x2575700", VA = "0x182576F00")]
	public static void INHNMALGLOD<T>(this OJBLBICDDLK<T> PIEBBHMNEOG, int BOCONGADANC, [In] T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x25767B0", Offset = "0x2574FB0", VA = "0x1825767B0")]
	public static void FHOLCCJIDCA<T>(this OJBLBICDDLK<T> PIEBBHMNEOG, int BOCONGADANC, T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1CDE7A0", Offset = "0x1CDCFA0", VA = "0x181CDE7A0")]
	public static int LLJCFNPKLEG<T>([In] this OJBLBICDDLK<T> PIEBBHMNEOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2576980", Offset = "0x2575180", VA = "0x182576980")]
	public static ReadOnlySpan<T> IHLEOMAIIFL<T>([In] this OJBLBICDDLK<T> PIEBBHMNEOG)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2577510", Offset = "0x2575D10", VA = "0x182577510")]
	public static T[] IOAGIHDEHAF<T>([In] this OJBLBICDDLK<T> PIEBBHMNEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2576A50", Offset = "0x2575250", VA = "0x182576A50")]
	public static void INCGBOEKEGG<T>(this OJBLBICDDLK<T> PIEBBHMNEOG, [In] T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x257C050", Offset = "0x257A850", VA = "0x18257C050")]
	public static void OFBEMCMCNDP<T>(this OJBLBICDDLK<T> PIEBBHMNEOG, T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x25765D0", Offset = "0x2574DD0", VA = "0x1825765D0")]
	public static void DOGNCNLECIL<T>(this OJBLBICDDLK<T> PIEBBHMNEOG, int EAHCFBMNNCF, [In] T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2576590", Offset = "0x2574D90", VA = "0x182576590")]
	public static void DIJEFKGDOIH<T>(this OJBLBICDDLK<T> PIEBBHMNEOG, int EAHCFBMNNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2576920", Offset = "0x2575120", VA = "0x182576920")]
	public static T IECDGPAEOLJ<T>(this OJBLBICDDLK<T> PIEBBHMNEOG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x257C220", Offset = "0x257AA20", VA = "0x18257C220")]
	public static void PGILDKHMPAD<T>(this OJBLBICDDLK<T> PIEBBHMNEOG, int PPKDCOOCBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x25776F0", Offset = "0x2575EF0", VA = "0x1825776F0")]
	private static void JNDFIMFJJIA<T>(this OJBLBICDDLK<T> PIEBBHMNEOG, int JHAJBCMGPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x257BED0", Offset = "0x257A6D0", VA = "0x18257BED0")]
	public static void MJBDPJEPBJH<T>(this OJBLBICDDLK<T> PIEBBHMNEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x257C180", Offset = "0x257A980", VA = "0x18257C180")]
	public static bool PDOHLIBNDGL<T>(this OJBLBICDDLK<T> PIEBBHMNEOG, [In] T DOLICEBFIPF) where T : AIENODJKFOP<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x24F4460", Offset = "0x24F2C60", VA = "0x1824F4460")]
	public static bool MGKHEKGJIKL<T>([In] this OJBLBICDDLK<T> PIEBBHMNEOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x257BBE0", Offset = "0x257A3E0", VA = "0x18257BBE0")]
	public static bool KLFEPEEGBKC<T>([In] this OJBLBICDDLK<T> PIEBBHMNEOG, int BOCONGADANC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x24C8D60", Offset = "0x24C7560", VA = "0x1824C8D60")]
	public static OJBLBICDDLK<T>.JEGAOCIPMMJ LLEMGPCMEFC<T>([In] this OJBLBICDDLK<T> PIEBBHMNEOG)
	{
		return default(OJBLBICDDLK<T>.JEGAOCIPMMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x24C8D60", Offset = "0x24C7560", VA = "0x1824C8D60")]
	public static OJBLBICDDLK<T>.PMEIBCJGCEF KAIAEOPIINN<T>(this OJBLBICDDLK<T> PIEBBHMNEOG)
	{
		return default(OJBLBICDDLK<T>.PMEIBCJGCEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x24DACB0", Offset = "0x24D94B0", VA = "0x1824DACB0")]
	public static FHBBDJEOIFM<T, OJBLBICDDLK<T>.JEGAOCIPMMJ> OPOLLADKGFK<T>([In] this OJBLBICDDLK<T> PIEBBHMNEOG)
	{
		return default(FHBBDJEOIFM<T, OJBLBICDDLK<T>.JEGAOCIPMMJ>);
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
