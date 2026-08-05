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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EE69B0", Offset = "0x6EE53B0", VA = "0x186EE69B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D7890", Offset = "0x8D6290", VA = "0x1808D7890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D78D0", Offset = "0x8D62D0", VA = "0x1808D78D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CPFPMKLPMKO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2CF23F0", Offset = "0x2CF0DF0", VA = "0x182CF23F0")]
	public static IBIOGEOJDKM<T> ODIPDFGPCLL<T>(this T[] PCBICLOONMH) where T : notnull
	{
		return default(IBIOGEOJDKM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class JLELGHLFOCM<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private BAOLKDDJFBI<T> DLOAANIEKCO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x443CCE0", Offset = "0x443B6E0", VA = "0x18443CCE0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x443CD60", Offset = "0x443B760", VA = "0x18443CD60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x443CB60", Offset = "0x443B560", VA = "0x18443CB60")]
	public static JLELGHLFOCM<T> AELHPDENENI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3BAB2E0", Offset = "0x3BA9CE0", VA = "0x183BAB2E0")]
	internal JLELGHLFOCM([In] BAOLKDDJFBI<T> OAAFMJBAJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x443CD20", Offset = "0x443B720", VA = "0x18443CD20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x443CCA0", Offset = "0x443B6A0", VA = "0x18443CCA0")]
	public void AHNOAIFECGD(int FPDJICFHLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x443CDA0", Offset = "0x443B7A0", VA = "0x18443CDA0", Slot = "8")]
	public BAOLKDDJFBI<T>.BNPLCMINNDO GetEnumerator()
	{
		return default(BAOLKDDJFBI<T>.BNPLCMINNDO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x443CE00", Offset = "0x443B800", VA = "0x18443CE00", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x443CE00", Offset = "0x443B800", VA = "0x18443CE00", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct IMALEGPEAIF<T, U> : IEnumerable<T>, IEnumerable where U : FPCGEOBKPNB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U MAKGBGALLFJ;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2251720", Offset = "0x2250120", VA = "0x182251720")]
	internal IMALEGPEAIF([In] U JLNFMCJGDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4038E20", Offset = "0x4037820", VA = "0x184038E20", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4038E20", Offset = "0x4037820", VA = "0x184038E20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MFEKANNGEEA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2E1B5B0", Offset = "0x2E19FB0", VA = "0x182E1B5B0")]
	public static IMALEGPEAIF<T, U> AELHPDENENI<U>([In] U PCBICLOONMH) where U : FPCGEOBKPNB<T>
	{
		return default(IMALEGPEAIF<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct CLEKJKKLGMD<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U MAKGBGALLFJ;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2251720", Offset = "0x2250120", VA = "0x182251720")]
	internal CLEKJKKLGMD([In] U JLNFMCJGDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4038E20", Offset = "0x4037820", VA = "0x184038E20", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4038E20", Offset = "0x4037820", VA = "0x184038E20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class HNGMLNPHLCB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2E1B5B0", Offset = "0x2E19FB0", VA = "0x182E1B5B0")]
	public static CLEKJKKLGMD<T, U> AELHPDENENI<U>([In] U PCBICLOONMH) where U : IEnumerator<T>
	{
		return default(CLEKJKKLGMD<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class BEJMBJMHIEE
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2C58850", Offset = "0x2C57250", VA = "0x182C58850")]
	public static string BIJMHJAJFEC<T>(this IEnumerable<T> PCBICLOONMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2C5CB70", Offset = "0x2C5B570", VA = "0x182C5CB70")]
	public static string HIALLAJNFMJ<T>(this IEnumerable<T> PCBICLOONMH, string MHOLALDKKCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IFFFKMMOCND
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2F23590", Offset = "0x2F21F90", VA = "0x182F23590")]
	public static bool MBFHKAFKBGK<TSourceEnumerator, TSource>(this TSourceEnumerator PCBICLOONMH, [In] TSource GNDKBENMBLO) where TSourceEnumerator : FPCGEOBKPNB<TSource> where TSource : OKIKCDAEAAO<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2F230C0", Offset = "0x2F21AC0", VA = "0x182F230C0")]
	public static int AEFBDKECGBC<TSourceEnumerator, TSource>(this TSourceEnumerator PCBICLOONMH, [In] TSource PKCLPFEIPFH) where TSourceEnumerator : FPCGEOBKPNB<TSource> where TSource : OKIKCDAEAAO<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2F23320", Offset = "0x2F21D20", VA = "0x182F23320")]
	public static int KDCFHJBLKJO<TSourceEnumerator, TSource>(this TSourceEnumerator PCBICLOONMH, [In] TSource PKCLPFEIPFH) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FPCGEOBKPNB<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T MKGDHLFFCEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BOOGGNKLJOI<T> : FPCGEOBKPNB<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FPHHLGFNCBN<T, U> : IEnumerable<T>, IEnumerable where U : BOOGGNKLJOI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U MAKGBGALLFJ;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4038ED0", Offset = "0x40378D0", VA = "0x184038ED0")]
	internal FPHHLGFNCBN([In] U JLNFMCJGDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3C419E0", Offset = "0x3C403E0", VA = "0x183C419E0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4038D90", Offset = "0x4037790", VA = "0x184038D90", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4038D90", Offset = "0x4037790", VA = "0x184038D90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DPELNDFIKFB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2E1B580", Offset = "0x2E19F80", VA = "0x182E1B580")]
	public static FPHHLGFNCBN<T, U> AELHPDENENI<U>([In] U PCBICLOONMH) where U : BOOGGNKLJOI<T>
	{
		return default(FPHHLGFNCBN<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct IBIOGEOJDKM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct ALLGJLFJOJO : FPCGEOBKPNB<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] KPIEAAOLOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int PCJALMBJCOP;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T MKGDHLFFCEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4150FA0", Offset = "0x414F9A0", VA = "0x184150FA0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x41508A0", Offset = "0x414F2A0", VA = "0x1841508A0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x4150C40", Offset = "0x414F640", VA = "0x184150C40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x93D320", Offset = "0x93BD20", VA = "0x18093D320")]
		private ALLGJLFJOJO(T[] PCBICLOONMH, int GCBONJOGHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x40E6390", Offset = "0x40E4D90", VA = "0x1840E6390")]
		public static ALLGJLFJOJO AELHPDENENI(T[] PCBICLOONMH)
		{
			return default(ALLGJLFJOJO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x228D6C0", Offset = "0x228C0C0", VA = "0x18228D6C0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x228D5F0", Offset = "0x228BFF0", VA = "0x18228D5F0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] ELLIAIHBOIP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EKAJMJBAGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x423C4E0", Offset = "0x423AEE0", VA = "0x18423C4E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T CEHHCMJMIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2FE3140", Offset = "0x2FE1B40", VA = "0x182FE3140")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x957790", Offset = "0x956190", VA = "0x180957790")]
	internal IBIOGEOJDKM(T[] LOCJOHPCANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x423C240", Offset = "0x423AC40", VA = "0x18423C240")]
	public static IBIOGEOJDKM<T> BDDJBNJILLK()
	{
		return default(IBIOGEOJDKM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780")]
	public IEnumerable<T> KAAANHJACJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x423C5A0", Offset = "0x423AFA0", VA = "0x18423C5A0")]
	public ReadOnlySpan<T> PAGHEDBDPIO()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x423C320", Offset = "0x423AD20", VA = "0x18423C320")]
	public IMALEGPEAIF<T, IBIOGEOJDKM<T>.ALLGJLFJOJO> BFGGMIFMDGE()
	{
		return default(IMALEGPEAIF<T, ALLGJLFJOJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x423C500", Offset = "0x423AF00", VA = "0x18423C500")]
	public ALLGJLFJOJO OJABFKDDADH()
	{
		return default(ALLGJLFJOJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x423C460", Offset = "0x423AE60", VA = "0x18423C460")]
	public IEnumerator<T> CBLJDKEPCGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x423C640", Offset = "0x423B040", VA = "0x18423C640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NLDICNNOOKM
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A2C0", Offset = "0x2D28CC0", VA = "0x182D2A2C0")]
	public static IBIOGEOJDKM<T> BNKOHBADKAH<T>(params T[] LOCJOHPCANM) where T : notnull
	{
		return default(IBIOGEOJDKM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6950", Offset = "0x6EE5350", VA = "0x186EE6950")]
	public static Stream NJNLIPIHBHC(this IBIOGEOJDKM<byte> PCBICLOONMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(BAOLKDDJFBI<>.AHHINNDOGKB))]
public struct BAOLKDDJFBI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct BNPLCMINNDO : BOOGGNKLJOI<T>, FPCGEOBKPNB<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] HPAGOOMPPHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int PMLCECBFFEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int PCJALMBJCOP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T MKGDHLFFCEG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x52A2730", Offset = "0x52A1130", VA = "0x1852A2730", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T AFOLIMLLLGN
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x52A1FA0", Offset = "0x52A09A0", VA = "0x1852A1FA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T GAHCENALPMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x52A1CD0", Offset = "0x52A06D0", VA = "0x1852A1CD0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x52A2180", Offset = "0x52A0B80", VA = "0x1852A2180", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x52A2620", Offset = "0x52A1020", VA = "0x1852A2620", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3F85130", Offset = "0x3F83B30", VA = "0x183F85130")]
		internal BNPLCMINNDO(T[] FAPCKKJDJFC, int FPDJICFHLGM, int GCBONJOGHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x52A1C70", Offset = "0x52A0670", VA = "0x1852A1C70")]
		public static BNPLCMINNDO AELHPDENENI(BAOLKDDJFBI<T> PCBICLOONMH)
		{
			return default(BNPLCMINNDO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3BFB150", Offset = "0x3BF9B50", VA = "0x183BFB150", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA010", Offset = "0x3BF8A10", VA = "0x183BFA010", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct ABKFBOIDCMH : FPCGEOBKPNB<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private BNPLCMINNDO MAKGBGALLFJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T MKGDHLFFCEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4099390", Offset = "0x4097D90", VA = "0x184099390", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4099170", Offset = "0x4097B70", VA = "0x184099170", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x40992F0", Offset = "0x4097CF0", VA = "0x1840992F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2251720", Offset = "0x2250120", VA = "0x182251720")]
		private ABKFBOIDCMH([In] BNPLCMINNDO JLNFMCJGDKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4098F80", Offset = "0x4097980", VA = "0x184098F80")]
		public static ABKFBOIDCMH AELHPDENENI([In] BAOLKDDJFBI<T> PCBICLOONMH)
		{
			return default(ABKFBOIDCMH);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4099070", Offset = "0x4097A70", VA = "0x184099070", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x40990B0", Offset = "0x4097AB0", VA = "0x1840990B0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4099030", Offset = "0x4097A30", VA = "0x184099030", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class AHHINNDOGKB
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] HPAGOOMPPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int PMLCECBFFEP;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5272F70", Offset = "0x5271970", VA = "0x185272F70")]
	public static BAOLKDDJFBI<T> AELHPDENENI()
	{
		return default(BAOLKDDJFBI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5273020", Offset = "0x5271A20", VA = "0x185273020")]
	public static BAOLKDDJFBI<T> JIDDBIOGDMI(int LFENHKJMLMG)
	{
		return default(BAOLKDDJFBI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x93D320", Offset = "0x93BD20", VA = "0x18093D320")]
	internal BAOLKDDJFBI(T[] FAPCKKJDJFC, int FPDJICFHLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x52730E0", Offset = "0x5271AE0", VA = "0x1852730E0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MMKGEIEEPAA
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int BGNGJCKEDBA<TCtx, T>([In] TCtx LOPOPGPCNHD, T GPBGMCKGICE, T PGFJAECCPCN);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2FE7290", Offset = "0x2FE5C90", VA = "0x182FE7290")]
	public static void GBEJNBBIIJK<T>(this BAOLKDDJFBI<T> PCBICLOONMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2FEAA20", Offset = "0x2FE9420", VA = "0x182FEAA20")]
	public static string PMFOOLKGFKC<T>([In] this BAOLKDDJFBI<T> PCBICLOONMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780")]
	public static T[] AMKDNKDBEFC<T>([In] this BAOLKDDJFBI<T> PCBICLOONMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2FE3100", Offset = "0x2FE1B00", VA = "0x182FE3100")]
	public static T KJCABELIABF<T>([In] this BAOLKDDJFBI<T> PCBICLOONMH, int FNLONGIJDLD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x228D390", Offset = "0x228BD90", VA = "0x18228D390")]
	public static T ACBNMHHGOOO<T>(this BAOLKDDJFBI<T> PCBICLOONMH, int FNLONGIJDLD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2FE79E0", Offset = "0x2FE63E0", VA = "0x182FE79E0")]
	public static T KOHAAFMBAMO<T>([In] this BAOLKDDJFBI<T> PCBICLOONMH, int FNLONGIJDLD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2FE6590", Offset = "0x2FE4F90", VA = "0x182FE6590")]
	public static void CADIEIMFLMA<T>(this BAOLKDDJFBI<T> PCBICLOONMH, int FNLONGIJDLD, [In] T PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2FE6590", Offset = "0x2FE4F90", VA = "0x182FE6590")]
	public static void IKCFDOIOLLH<T>(this BAOLKDDJFBI<T> PCBICLOONMH, int FNLONGIJDLD, T PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x228D680", Offset = "0x228C080", VA = "0x18228D680")]
	public static int ENBGJDAJIJA<T>([In] this BAOLKDDJFBI<T> PCBICLOONMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2FEA640", Offset = "0x2FE9040", VA = "0x182FEA640")]
	public static ReadOnlySpan<T> PAGHEDBDPIO<T>([In] this BAOLKDDJFBI<T> PCBICLOONMH)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2FE7D80", Offset = "0x2FE6780", VA = "0x182FE7D80")]
	public static T[] MPFDFPFJCAC<T>([In] this BAOLKDDJFBI<T> PCBICLOONMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2FEA740", Offset = "0x2FE9140", VA = "0x182FEA740")]
	public static T PJAAMIAFACL<T>([In] this BAOLKDDJFBI<T> PCBICLOONMH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2FE3360", Offset = "0x2FE1D60", VA = "0x182FE3360")]
	public static T[] ACLIMCMBKAP<T>(this BAOLKDDJFBI<T> PCBICLOONMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2FE71C0", Offset = "0x2FE5BC0", VA = "0x182FE71C0")]
	public static IBIOGEOJDKM<T> ELGHGKDKMBA<T>(this BAOLKDDJFBI<T> PCBICLOONMH)
	{
		return default(IBIOGEOJDKM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2FE8050", Offset = "0x2FE6A50", VA = "0x182FE8050")]
	public static void NOEGDDICEDP<T>(this BAOLKDDJFBI<T> PCBICLOONMH, [In] T PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5CE0", Offset = "0x2FE46E0", VA = "0x182FE5CE0")]
	public static void AJMDHDANLLF<T>(this BAOLKDDJFBI<T> PCBICLOONMH, T PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2FE7050", Offset = "0x2FE5A50", VA = "0x182FE7050")]
	public static void EDJHOBCGFJF<T>(this BAOLKDDJFBI<T> PCBICLOONMH, int GCBONJOGHCD, [In] T PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2FE7AE0", Offset = "0x2FE64E0", VA = "0x182FE7AE0")]
	public static void LJIEEHPELGN<T>(this BAOLKDDJFBI<T> PCBICLOONMH, int GCBONJOGHCD, T PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5EB0", Offset = "0x2FE48B0", VA = "0x182FE5EB0")]
	public static void BDLDDEIFEGI<T>(this BAOLKDDJFBI<T> PCBICLOONMH, int GCBONJOGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2FE8570", Offset = "0x2FE6F70", VA = "0x182FE8570")]
	public static T OJDCFEPCJBH<T>(this BAOLKDDJFBI<T> PCBICLOONMH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2FE3410", Offset = "0x2FE1E10", VA = "0x182FE3410")]
	public static void AHNOAIFECGD<T>(this BAOLKDDJFBI<T> PCBICLOONMH, int FPDJICFHLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2FE8760", Offset = "0x2FE7160", VA = "0x182FE8760")]
	private static void OPGKIEALGDP<T>(this BAOLKDDJFBI<T> PCBICLOONMH, int LFENHKJMLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2FE6D50", Offset = "0x2FE5750", VA = "0x182FE6D50")]
	public static void CFGGIHGKNGN<T>(this BAOLKDDJFBI<T> PCBICLOONMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2FE76D0", Offset = "0x2FE60D0", VA = "0x182FE76D0")]
	public static BAOLKDDJFBI<T> JLKNNCHOGKA<T>([In] this BAOLKDDJFBI<T> PCBICLOONMH, EEAFKEBEEFO<T, T> JFKKNHKHNBL)
	{
		return default(BAOLKDDJFBI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2FEA780", Offset = "0x2FE9180", VA = "0x182FEA780")]
	public static bool PJOABDGMIKH<T>(this BAOLKDDJFBI<T> PCBICLOONMH, T PKCLPFEIPFH) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2FE6E60", Offset = "0x2FE5860", VA = "0x182FE6E60")]
	public static bool DCBJGKBDAJA<T>(this BAOLKDDJFBI<T> PCBICLOONMH, [In] T PKCLPFEIPFH) where T : OKIKCDAEAAO<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2EE4DB0", Offset = "0x2EE37B0", VA = "0x182EE4DB0")]
	public static bool EHENKOHBJJB<T>([In] this BAOLKDDJFBI<T> PCBICLOONMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2FE6F30", Offset = "0x2FE5930", VA = "0x182FE6F30")]
	public static bool DENELPNEJFJ<T>([In] this BAOLKDDJFBI<T> PCBICLOONMH, int FNLONGIJDLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2FE7930", Offset = "0x2FE6330", VA = "0x182FE7930")]
	public static void JPEODBODMFG<T, TCtx>(this BAOLKDDJFBI<T> PCBICLOONMH, [In] TCtx LOPOPGPCNHD, BGNGJCKEDBA<TCtx, T> COKEBFNJHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2FE7EB0", Offset = "0x2FE68B0", VA = "0x182FE7EB0")]
	private static void NLBOGAOIFAF<T, TCtx>(BAOLKDDJFBI<T> PCBICLOONMH, [In] TCtx LOPOPGPCNHD, BGNGJCKEDBA<TCtx, T> COKEBFNJHHB, int BPHHMAPOLDF, int PGCBDMOEEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5EF0", Offset = "0x2FE48F0", VA = "0x182FE5EF0")]
	private static int BLNBHIFNAIG<T, TCtx>(BAOLKDDJFBI<T> PCBICLOONMH, [In] TCtx LOPOPGPCNHD, BGNGJCKEDBA<TCtx, T> COKEBFNJHHB, int BPHHMAPOLDF, int PGCBDMOEEAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2D294E0", Offset = "0x2D27EE0", VA = "0x182D294E0")]
	public static BAOLKDDJFBI<T>.ABKFBOIDCMH CBLJDKEPCGL<T>([In] this BAOLKDDJFBI<T> PCBICLOONMH)
	{
		return default(BAOLKDDJFBI<T>.ABKFBOIDCMH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2D294E0", Offset = "0x2D27EE0", VA = "0x182D294E0")]
	public static BAOLKDDJFBI<T>.BNPLCMINNDO GEDECNJMIGL<T>(this BAOLKDDJFBI<T> PCBICLOONMH)
	{
		return default(BAOLKDDJFBI<T>.BNPLCMINNDO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2D2A230", Offset = "0x2D28C30", VA = "0x182D2A230")]
	public static IMALEGPEAIF<T, BAOLKDDJFBI<T>.ABKFBOIDCMH> KLFNJJPECHA<T>([In] this BAOLKDDJFBI<T> PCBICLOONMH)
	{
		return default(IMALEGPEAIF<T, BAOLKDDJFBI<T>.ABKFBOIDCMH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class HBHGHICKCAA
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB010", Offset = "0x2EF9A10", VA = "0x182EFB010")]
	public static T[] LHDHAHJKOJK<T>(int LEGDMNLNDAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
	public static void IFHNOGOIOCE<T>(T[] LOCJOHPCANM)
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
