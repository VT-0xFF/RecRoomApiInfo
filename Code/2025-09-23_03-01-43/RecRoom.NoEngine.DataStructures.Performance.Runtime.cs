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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x866A920", Offset = "0x8668F20", VA = "0x18866A920")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DBKAPKLBLGF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x32DA140", Offset = "0x32D8740", VA = "0x1832DA140")]
	public static ADLLGELKECP<T> CAFPENKCLGI<T>(this T[] JNMMMBJNOND) where T : notnull
	{
		return default(ADLLGELKECP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3C204A0", Offset = "0x3C1EAA0", VA = "0x183C204A0")]
	public static LMAMBNHNDEF<T, ELKLCEBNLGJ<T>> NIAMODOJAEB<T>(this T[] JNMMMBJNOND) where T : notnull
	{
		return default(LMAMBNHNDEF<T, ELKLCEBNLGJ<T>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class MEMDEACIEIF<T> : IDisposable, GHDLFMIEOBC, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NHNLFJGMEDN<T> PIEDHHGPLJC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5A020C0", Offset = "0x5A006C0", VA = "0x185A020C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5A020F0", Offset = "0x5A006F0", VA = "0x185A020F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5A01F10", Offset = "0x5A00510", VA = "0x185A01F10")]
	public static MEMDEACIEIF<T> CPNHECDILPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4B6F110", Offset = "0x4B6D710", VA = "0x184B6F110")]
	internal MEMDEACIEIF([In] NHNLFJGMEDN<T> MFNKIFOCMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5A02030", Offset = "0x5A00630", VA = "0x185A02030", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5A020A0", Offset = "0x5A006A0", VA = "0x185A020A0")]
	public void HEADFFMFKHM(int LMJBLNOIBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5A02050", Offset = "0x5A00650", VA = "0x185A02050", Slot = "8")]
	public NHNLFJGMEDN<T>.HOGMGPJGBIH GetEnumerator()
	{
		return default(NHNLFJGMEDN<T>.HOGMGPJGBIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5A02120", Offset = "0x5A00720", VA = "0x185A02120", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5A02120", Offset = "0x5A00720", VA = "0x185A02120", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct AHLMKHDGFBP<T, U> : IEnumerable<T>, IEnumerable where U : AEFEMJKIKPK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U KNPOICIMKCA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x12CB170", Offset = "0x12C9770", VA = "0x1812CB170")]
	internal AHLMKHDGFBP([In] U DPOHFMKDFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5413020", Offset = "0x5411620", VA = "0x185413020", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5413020", Offset = "0x5411620", VA = "0x185413020", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OJEEHGGJCLM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4539F10", Offset = "0x4538510", VA = "0x184539F10")]
	public static AHLMKHDGFBP<T, U> CPNHECDILPK<U>([In] U JNMMMBJNOND) where U : AEFEMJKIKPK<T>
	{
		return default(AHLMKHDGFBP<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EAILMIDEBNF
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C491A0", Offset = "0x3C477A0", VA = "0x183C491A0")]
	public static int EEGOGBABKAE<T, U>([In] this AHLMKHDGFBP<T, U> JNMMMBJNOND) where U : AEFEMJKIKPK<T>, GHDLFMIEOBC
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BFHKMDLIELC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6AEBC60", Offset = "0x6AEA260", VA = "0x186AEBC60")]
	public static LMAMBNHNDEF<T, ELKLCEBNLGJ<T>> CPNHECDILPK([In] T[] JNMMMBJNOND)
	{
		return default(LMAMBNHNDEF<T, ELKLCEBNLGJ<T>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct LMAMBNHNDEF<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U KNPOICIMKCA;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4615EB0", Offset = "0x46144B0", VA = "0x184615EB0")]
	internal LMAMBNHNDEF([In] U DPOHFMKDFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2D98820", Offset = "0x2D96E20", VA = "0x182D98820", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x57D41C0", Offset = "0x57D27C0", VA = "0x1857D41C0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x57D41C0", Offset = "0x57D27C0", VA = "0x1857D41C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ILPLAFJILAA<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4539E80", Offset = "0x4538480", VA = "0x184539E80")]
	public static LMAMBNHNDEF<T, U> CPNHECDILPK<U>([In] U JNMMMBJNOND) where U : IEnumerator<T>
	{
		return default(LMAMBNHNDEF<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MFLDBJOBFAM
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3880", Offset = "0x3ED1E80", VA = "0x183ED3880")]
	public static LMAMBNHNDEF<TResult, LLIHEDLAFNK<TSourceEnumerator, TSource, TResult>> DJPFFPALOAK<TResult, TSourceEnumerator, TSource>([In] this LMAMBNHNDEF<TSource, TSourceEnumerator> JNMMMBJNOND, Func<TSource, TResult> JHJIOCIGOMA) where TSourceEnumerator : GHDLFMIEOBC, IEnumerator<TSource>
	{
		return default(LMAMBNHNDEF<TResult, LLIHEDLAFNK<TSourceEnumerator, TSource, TResult>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct ELKLCEBNLGJ<T> : IEnumerator<T>, IEnumerator, IDisposable, GHDLFMIEOBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly T[] NOBBMCHDAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int DDBGNDNNLCH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly T MIECLPJBKEF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4B60760", Offset = "0x4B5ED60", VA = "0x184B60760", Slot = "4")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4B60710", Offset = "0x4B5ED10", VA = "0x184B60710", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B54400", Offset = "0x2B52A00", VA = "0x182B54400", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xDC6F20", Offset = "0xDC5520", VA = "0x180DC6F20")]
	private ELKLCEBNLGJ(T[] JNMMMBJNOND, int PMIGBJGNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4B606C0", Offset = "0x4B5ECC0", VA = "0x184B606C0")]
	public static ELKLCEBNLGJ<T> CPNHECDILPK(T[] JNMMMBJNOND)
	{
		return default(ELKLCEBNLGJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2B54420", Offset = "0x2B52A20", VA = "0x182B54420", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2B54300", Offset = "0x2B52900", VA = "0x182B54300", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct LLIHEDLAFNK<TSourceEnumerator, TSource, TResult> : GHDLFMIEOBC, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : GHDLFMIEOBC, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private TSourceEnumerator NOBBMCHDAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<TSource, TResult> ADGKJKOPPNE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public readonly int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x57D2210", Offset = "0x57D0810", VA = "0x1857D2210", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly TResult MIECLPJBKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x57D2430", Offset = "0x57D0A30", VA = "0x1857D2430", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x57D2370", Offset = "0x57D0970", VA = "0x1857D2370", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2B660C0", Offset = "0x2B646C0", VA = "0x182B660C0")]
	internal LLIHEDLAFNK([In] TSourceEnumerator JNMMMBJNOND, Func<TSource, TResult> JHJIOCIGOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x57D22A0", Offset = "0x57D08A0", VA = "0x1857D22A0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x57D2330", Offset = "0x57D0930", VA = "0x1857D2330", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x571B330", Offset = "0x5719930", VA = "0x18571B330", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal static class JLLIEPHGPBH
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3E6CAE0", Offset = "0x3E6B0E0", VA = "0x183E6CAE0")]
	public static string NLKPEOKNMGJ<T>(this IEnumerable<T> JNMMMBJNOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3E5A010", Offset = "0x3E58610", VA = "0x183E5A010")]
	public static string FKFLLHEINBM<T>(this IEnumerable<T> JNMMMBJNOND, string GFOEIMIELHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JAOFAIPEMJB
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3E49DF0", Offset = "0x3E483F0", VA = "0x183E49DF0")]
	public static bool IMMHOBOAMAB<TSourceEnumerator, TSource>(this TSourceEnumerator JNMMMBJNOND, [In] TSource NANHMPOBBLI) where TSourceEnumerator : AEFEMJKIKPK<TSource> where TSource : ACEBGMCDHMH<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3E49C60", Offset = "0x3E48260", VA = "0x183E49C60")]
	public static int HDNAGKIOHHI<TSourceEnumerator, TSource>(this TSourceEnumerator JNMMMBJNOND, [In] TSource KOPHBHGIACG) where TSourceEnumerator : AEFEMJKIKPK<TSource> where TSource : ACEBGMCDHMH<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3E498C0", Offset = "0x3E47EC0", VA = "0x183E498C0")]
	public static LLIHEDLAFNK<TSourceEnumerator, TSource, TResult> DJPFFPALOAK<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator JNMMMBJNOND, Func<TSource, TResult> JHJIOCIGOMA) where TSourceEnumerator : GHDLFMIEOBC, IEnumerator<TSource>
	{
		return default(LLIHEDLAFNK<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3E499F0", Offset = "0x3E47FF0", VA = "0x183E499F0")]
	public static int GDHCODOOPPC<TSourceEnumerator, TSource>(this TSourceEnumerator JNMMMBJNOND, [In] TSource KOPHBHGIACG) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AEFEMJKIKPK<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T MIECLPJBKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GHDLFMIEOBC
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NMFGJJADBIJ<T> : AEFEMJKIKPK<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct JEIJJMBGABK<T, U> : IEnumerable<T>, IEnumerable where U : NMFGJJADBIJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly U KNPOICIMKCA;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5413130", Offset = "0x5411730", VA = "0x185413130")]
	internal JEIJJMBGABK([In] U DPOHFMKDFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F5D0", Offset = "0x4C2DBD0", VA = "0x184C2F5D0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x54130A0", Offset = "0x54116A0", VA = "0x1854130A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x54130A0", Offset = "0x54116A0", VA = "0x1854130A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class LLGOALOIHII<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4539F70", Offset = "0x4538570", VA = "0x184539F70")]
	public static JEIJJMBGABK<T, U> CPNHECDILPK<U>([In] U JNMMMBJNOND) where U : NMFGJJADBIJ<T>
	{
		return default(JEIJJMBGABK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public readonly struct ADLLGELKECP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct JCPJANJFAKE : GHDLFMIEOBC, AEFEMJKIKPK<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] NOBBMCHDAGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int DDBGNDNNLCH;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly int EEGOGBABKAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2B54400", Offset = "0x2B52A00", VA = "0x182B54400", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x54B8AF0", Offset = "0x54B70F0", VA = "0x1854B8AF0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4B60710", Offset = "0x4B5ED10", VA = "0x184B60710", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x54B88A0", Offset = "0x54B6EA0", VA = "0x1854B88A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xDC6F20", Offset = "0xDC5520", VA = "0x180DC6F20")]
		private JCPJANJFAKE(T[] JNMMMBJNOND, int PMIGBJGNLLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4B606C0", Offset = "0x4B5ECC0", VA = "0x184B606C0")]
		public static JCPJANJFAKE CPNHECDILPK(T[] JNMMMBJNOND)
		{
			return default(JCPJANJFAKE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2B54420", Offset = "0x2B52A20", VA = "0x182B54420", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2B54300", Offset = "0x2B52900", VA = "0x182B54300", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly T[] GHJLLDPIAPH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int AOCLJDLKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B54400", Offset = "0x2B52A00", VA = "0x182B54400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x32D1100", Offset = "0x32CF700", VA = "0x1832D1100")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xECF2C0", Offset = "0xECD8C0", VA = "0x180ECF2C0")]
	internal ADLLGELKECP(T[] GHKPAFFMJAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5329130", Offset = "0x5327730", VA = "0x185329130")]
	public static ADLLGELKECP<T> HPOBBIFAPGN()
	{
		return default(ADLLGELKECP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
	public IEnumerable<T> BCOOLHKKPKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5328F80", Offset = "0x5327580", VA = "0x185328F80")]
	public ReadOnlySpan<T> ALAACKFICDK()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5329010", Offset = "0x5327610", VA = "0x185329010")]
	public AHLMKHDGFBP<T, ADLLGELKECP<T>.JCPJANJFAKE> EPNAACNMFEI()
	{
		return default(AHLMKHDGFBP<T, JCPJANJFAKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x53291F0", Offset = "0x53277F0", VA = "0x1853291F0")]
	public JCPJANJFAKE OAHEFDENNJH()
	{
		return default(JCPJANJFAKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5328F00", Offset = "0x5327500", VA = "0x185328F00")]
	public IEnumerator<T> ABGODHCJODA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5329280", Offset = "0x5327880", VA = "0x185329280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class IGFCDHKKIIC
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3B60D20", Offset = "0x3B5F320", VA = "0x183B60D20")]
	public static ADLLGELKECP<T> APNPJJENAHB<T>(params T[] GHKPAFFMJAO) where T : notnull
	{
		return default(ADLLGELKECP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x866A8C0", Offset = "0x8668EC0", VA = "0x18866A8C0")]
	public static Stream AFPMIOBNCEG(this ADLLGELKECP<byte> JNMMMBJNOND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DebuggerTypeProxy(typeof(NHNLFJGMEDN<>.DFALKCKMKFB))]
public struct NHNLFJGMEDN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct HOGMGPJGBIH : GHDLFMIEOBC, NMFGJJADBIJ<T>, AEFEMJKIKPK<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly T[] BBDEGLJMBPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int ONGKCDAAOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int DDBGNDNNLCH;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly int EEGOGBABKAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xF79720", Offset = "0xF77D20", VA = "0x180F79720", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public readonly T MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5180530", Offset = "0x517EB30", VA = "0x185180530", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public readonly T KKHKBHPCGGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x517FB70", Offset = "0x517E170", VA = "0x18517FB70")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private readonly T BIJKLDHMGNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x517FCF0", Offset = "0x517E2F0", VA = "0x18517FCF0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x517FE60", Offset = "0x517E460", VA = "0x18517FE60", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5180300", Offset = "0x517E900", VA = "0x185180300", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5180440", Offset = "0x517EA40", VA = "0x185180440")]
		internal HOGMGPJGBIH(T[] KBJJADJMHBH, int LMJBLNOIBOL, int PMIGBJGNLLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x517FBA0", Offset = "0x517E1A0", VA = "0x18517FBA0")]
		public static HOGMGPJGBIH CPNHECDILPK(NHNLFJGMEDN<T> JNMMMBJNOND)
		{
			return default(HOGMGPJGBIH);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4BE0510", Offset = "0x4BDEB10", VA = "0x184BE0510", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4BCD480", Offset = "0x4BCBA80", VA = "0x184BCD480", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct KMNGPCDLLAB : GHDLFMIEOBC, AEFEMJKIKPK<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private HOGMGPJGBIH KNPOICIMKCA;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int EEGOGBABKAE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x571B370", Offset = "0x5719970", VA = "0x18571B370", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public readonly T MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x571B860", Offset = "0x5719E60", VA = "0x18571B860", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x571B530", Offset = "0x5719B30", VA = "0x18571B530", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x571B6B0", Offset = "0x5719CB0", VA = "0x18571B6B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x12CB170", Offset = "0x12C9770", VA = "0x1812CB170")]
		private KMNGPCDLLAB([In] HOGMGPJGBIH DPOHFMKDFJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x571B280", Offset = "0x5719880", VA = "0x18571B280")]
		public static KMNGPCDLLAB CPNHECDILPK([In] NHNLFJGMEDN<T> JNMMMBJNOND)
		{
			return default(KMNGPCDLLAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x571B3A0", Offset = "0x57199A0", VA = "0x18571B3A0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x571B3E0", Offset = "0x57199E0", VA = "0x18571B3E0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x571B330", Offset = "0x5719930", VA = "0x18571B330", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class DFALKCKMKFB
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal T[] BBDEGLJMBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal int ONGKCDAAOHO;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5A863E0", Offset = "0x5A849E0", VA = "0x185A863E0")]
	public static NHNLFJGMEDN<T> CPNHECDILPK()
	{
		return default(NHNLFJGMEDN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5A86480", Offset = "0x5A84A80", VA = "0x185A86480")]
	public static NHNLFJGMEDN<T> OKENOJCODJI(int AHIAOIDMGDN)
	{
		return default(NHNLFJGMEDN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xDC6F20", Offset = "0xDC5520", VA = "0x180DC6F20")]
	internal NHNLFJGMEDN(T[] KBJJADJMHBH, int LMJBLNOIBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5A86530", Offset = "0x5A84B30", VA = "0x185A86530", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class ACBBEPBJMNH
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate int GOIMELIKMLI<TCtx, T>([In] TCtx BJEFEGNHMAK, T BNPLNGPMIIG, T DIIGMDFDOAL);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x32D1060", Offset = "0x32CF660", VA = "0x1832D1060")]
	public static void GELLEPHLJAH<T>(this NHNLFJGMEDN<T> JNMMMBJNOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x32D56E0", Offset = "0x32D3CE0", VA = "0x1832D56E0")]
	public static string JPFAGEMKJDM<T>([In] this NHNLFJGMEDN<T> JNMMMBJNOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
	public static T[] OALIDLBOGFA<T>([In] this NHNLFJGMEDN<T> JNMMMBJNOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x32D1130", Offset = "0x32CF730", VA = "0x1832D1130")]
	public static T HBAOOBIPNDD<T>([In] this NHNLFJGMEDN<T> JNMMMBJNOND, int ENCGNPAFEED)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x32D1130", Offset = "0x32CF730", VA = "0x1832D1130")]
	public static T PDKOFGGFDFO<T>(this NHNLFJGMEDN<T> JNMMMBJNOND, int ENCGNPAFEED)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x32D9000", Offset = "0x32D7600", VA = "0x1832D9000")]
	public static T OMOCJLDHOGG<T>([In] this NHNLFJGMEDN<T> JNMMMBJNOND, int ENCGNPAFEED)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x32D3630", Offset = "0x32D1C30", VA = "0x1832D3630")]
	public static void IAMMACFOCIM<T>(this NHNLFJGMEDN<T> JNMMMBJNOND, int ENCGNPAFEED, [In] T KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x32D05E0", Offset = "0x32CEBE0", VA = "0x1832D05E0")]
	public static void CEOLJEMJNJP<T>(this NHNLFJGMEDN<T> JNMMMBJNOND, int ENCGNPAFEED, T KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xF79720", Offset = "0xF77D20", VA = "0x180F79720")]
	public static int CLHNCECDCGG<T>([In] this NHNLFJGMEDN<T> JNMMMBJNOND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x32D0290", Offset = "0x32CE890", VA = "0x1832D0290")]
	public static ReadOnlySpan<T> ALAACKFICDK<T>([In] this NHNLFJGMEDN<T> JNMMMBJNOND)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x32D7F70", Offset = "0x32D6570", VA = "0x1832D7F70")]
	public static T[] KKBFIKFMPMN<T>([In] this NHNLFJGMEDN<T> JNMMMBJNOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x32D0410", Offset = "0x32CEA10", VA = "0x1832D0410")]
	public static T BFLPAGNDGDI<T>([In] this NHNLFJGMEDN<T> JNMMMBJNOND)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x32D0380", Offset = "0x32CE980", VA = "0x1832D0380")]
	public static ADLLGELKECP<T> BBBPCOJHGKI<T>(this NHNLFJGMEDN<T> JNMMMBJNOND)
	{
		return default(ADLLGELKECP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x32D8630", Offset = "0x32D6C30", VA = "0x1832D8630")]
	public static void MEFAAGOGBHI<T>(this NHNLFJGMEDN<T> JNMMMBJNOND, [In] T KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x32D0CD0", Offset = "0x32CF2D0", VA = "0x1832D0CD0")]
	public static void FFIFILALMFE<T>(this NHNLFJGMEDN<T> JNMMMBJNOND, T KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x32D8BF0", Offset = "0x32D71F0", VA = "0x1832D8BF0")]
	public static void NDGGEIICLJP<T>(this NHNLFJGMEDN<T> JNMMMBJNOND, int PMIGBJGNLLP, [In] T KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x32D3500", Offset = "0x32D1B00", VA = "0x1832D3500")]
	public static void HNBMAEKMCKB<T>(this NHNLFJGMEDN<T> JNMMMBJNOND, int PMIGBJGNLLP, [In] NHNLFJGMEDN<T> LGMBOCEBOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x32D0F30", Offset = "0x32CF530", VA = "0x1832D0F30")]
	public static void GELINKLGGBG<T>(this NHNLFJGMEDN<T> JNMMMBJNOND, int PMIGBJGNLLP, T KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x32D0AF0", Offset = "0x32CF0F0", VA = "0x1832D0AF0")]
	public static void DJKPDGOGCDJ<T>(this NHNLFJGMEDN<T> JNMMMBJNOND, int PMIGBJGNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x32D0A90", Offset = "0x32CF090", VA = "0x1832D0A90")]
	public static T DHNHFNALEON<T>(this NHNLFJGMEDN<T> JNMMMBJNOND)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x32D14D0", Offset = "0x32CFAD0", VA = "0x1832D14D0")]
	public static void HEADFFMFKHM<T>(this NHNLFJGMEDN<T> JNMMMBJNOND, int LMJBLNOIBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x32D4070", Offset = "0x32D2670", VA = "0x1832D4070")]
	private static void JIIFKNHJLID<T>(this NHNLFJGMEDN<T> JNMMMBJNOND, int AHIAOIDMGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x32D0B30", Offset = "0x32CF130", VA = "0x1832D0B30")]
	public static void ELFNJAKNOMA<T>(this NHNLFJGMEDN<T> JNMMMBJNOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x32D3A10", Offset = "0x32D2010", VA = "0x1832D3A10")]
	public static NHNLFJGMEDN<T> JGHKMFOJCLP<T>([In] this NHNLFJGMEDN<T> JNMMMBJNOND, AJLOMAEKFCH<T, T> BKGAIFJNIMG)
	{
		return default(NHNLFJGMEDN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x32D8DD0", Offset = "0x32D73D0", VA = "0x1832D8DD0")]
	public static int NDGIEOGFJFO<T>([In] this NHNLFJGMEDN<T> JNMMMBJNOND, T KOPHBHGIACG) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x32D0360", Offset = "0x32CE960", VA = "0x1832D0360")]
	public static bool AOFBHNFGAFG<T>([In] this NHNLFJGMEDN<T> JNMMMBJNOND, T KOPHBHGIACG) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x32D0430", Offset = "0x32CEA30", VA = "0x1832D0430")]
	public static bool CBELOMAGFLH<T>(this NHNLFJGMEDN<T> JNMMMBJNOND, T KOPHBHGIACG) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x32D91D0", Offset = "0x32D77D0", VA = "0x1832D91D0")]
	public static bool ONFMLHIOAND<T>(this NHNLFJGMEDN<T> JNMMMBJNOND, [In] T KOPHBHGIACG) where T : ACEBGMCDHMH<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x32D5570", Offset = "0x32D3B70", VA = "0x1832D5570")]
	public static bool JNKPFBIAHGL<T>([In] this NHNLFJGMEDN<T> JNMMMBJNOND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x32D8B00", Offset = "0x32D7100", VA = "0x1832D8B00")]
	public static void MIDMMBDBOHE<T, TCtx>(this NHNLFJGMEDN<T> JNMMMBJNOND, [In] TCtx BJEFEGNHMAK, GOIMELIKMLI<TCtx, T> MKHJPPBLEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x32D8B30", Offset = "0x32D7130", VA = "0x1832D8B30")]
	private static void MIMNHBMEBHA<T, TCtx>(NHNLFJGMEDN<T> JNMMMBJNOND, [In] TCtx BJEFEGNHMAK, GOIMELIKMLI<TCtx, T> MKHJPPBLEIB, int GCAKMBFMAAC, int HINJGPGMKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x32D81E0", Offset = "0x32D67E0", VA = "0x1832D81E0")]
	private static int MANMMNNJLPH<T, TCtx>(NHNLFJGMEDN<T> JNMMMBJNOND, [In] TCtx BJEFEGNHMAK, GOIMELIKMLI<TCtx, T> MKHJPPBLEIB, int GCAKMBFMAAC, int HINJGPGMKOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x32D0260", Offset = "0x32CE860", VA = "0x1832D0260")]
	public static NHNLFJGMEDN<T>.KMNGPCDLLAB ABGODHCJODA<T>([In] this NHNLFJGMEDN<T> JNMMMBJNOND)
	{
		return default(NHNLFJGMEDN<T>.KMNGPCDLLAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x32D0260", Offset = "0x32CE860", VA = "0x1832D0260")]
	public static NHNLFJGMEDN<T>.HOGMGPJGBIH GNKAHHDOCCA<T>(this NHNLFJGMEDN<T> JNMMMBJNOND)
	{
		return default(NHNLFJGMEDN<T>.HOGMGPJGBIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x32D0EC0", Offset = "0x32CF4C0", VA = "0x1832D0EC0")]
	public static AHLMKHDGFBP<T, NHNLFJGMEDN<T>.KMNGPCDLLAB> FGPOKJGJJOL<T>([In] this NHNLFJGMEDN<T> JNMMMBJNOND)
	{
		return default(AHLMKHDGFBP<T, NHNLFJGMEDN<T>.KMNGPCDLLAB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal static class MPCJBHPMCKC
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3EDC070", Offset = "0x3EDA670", VA = "0x183EDC070")]
	public static T[] ECLNGCPHLJF<T>(int KCJLCGFEBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	public static void KMINJDFMLHG<T>(T[] GHKPAFFMJAO)
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
