using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F83410", Offset = "0x6F82610", VA = "0x186F83410")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E3190", Offset = "0x7E2390", VA = "0x1807E3190")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x17C7540", Offset = "0x17C6740", VA = "0x1817C7540")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface POOPLIPGACJ<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	T JLCKGMHIDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class IIKLCGBPIJF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2187B60", Offset = "0x2186D60", VA = "0x182187B60")]
	public static string PHFFNHNDOGD<T>(this IEnumerable<T> KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2189960", Offset = "0x2188B60", VA = "0x182189960")]
	public static string POKPLFIOEMO<T>(this IEnumerable<T> KPIHKJNPOFH, string JPLMPPDAJFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct LHFHPEMEKNE<T, U> : IEnumerable<T>, IEnumerable where U : KIIPFAODMFJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly U BOGPIOLBKMC;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x29EEEC0", Offset = "0x29EE0C0", VA = "0x1829EEEC0")]
	internal LHFHPEMEKNE(in U LMCDAHACENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x15BDB90", Offset = "0x15BCD90", VA = "0x1815BDB90", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x29EEE30", Offset = "0x29EE030", VA = "0x1829EEE30", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x29EEE30", Offset = "0x29EE030", VA = "0x1829EEE30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GNALBDNMMOL<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x20FB8B0", Offset = "0x20FAAB0", VA = "0x1820FB8B0")]
	public static LHFHPEMEKNE<T, U> HBHNAKPOBBF<U>(in U KPIHKJNPOFH) where U : KIIPFAODMFJ<T>
	{
		return default(LHFHPEMEKNE<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DMGDFIIOFJL
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x29D4E90", Offset = "0x29D4090", VA = "0x1829D4E90")]
	public static bool PDCDLFFCABB<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator KPIHKJNPOFH, in TArgs LCGFCGNMPHN, in JNCLEADFIOD<TArgs, TSource, bool> MCOBJMPEFEM) where TSourceEnumerator : POOPLIPGACJ<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x29D4BE0", Offset = "0x29D3DE0", VA = "0x1829D4BE0")]
	public static int IMCICEKFICD<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator KPIHKJNPOFH, in TArgs LCGFCGNMPHN, JNCLEADFIOD<TArgs, TSource, bool> MCOBJMPEFEM) where TSourceEnumerator : POOPLIPGACJ<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x29D42C0", Offset = "0x29D34C0", VA = "0x1829D42C0")]
	public static bool BIFEEAKDEMH<TSourceEnumerator, TSource>(this TSourceEnumerator KPIHKJNPOFH, in TSource JJJLNAPHHCM) where TSourceEnumerator : POOPLIPGACJ<TSource> where TSource : JGMIOPFGKLF<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x29D4890", Offset = "0x29D3A90", VA = "0x1829D4890")]
	public static int GMNBICAHAIL<TSourceEnumerator, TSource>(this TSourceEnumerator KPIHKJNPOFH, in TSource NABCGCEIEGG) where TSourceEnumerator : POOPLIPGACJ<TSource> where TSource : JGMIOPFGKLF<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x29D4610", Offset = "0x29D3810", VA = "0x1829D4610")]
	public static CBHICEJNKGC<TSourceEnumerator, TSource, TResult> ELALCHJMFFB<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator KPIHKJNPOFH, DABCLNLOMAJ<TSource, TResult> MNDCACPEAPE) where TSourceEnumerator : JFENMDHEJPP, POOPLIPGACJ<TSource>
	{
		return default(CBHICEJNKGC<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x29D4610", Offset = "0x29D3810", VA = "0x1829D4610")]
	public static HLDIDDLFKAA<TSourceEnumerator, TSource, TResult> JKGFJCCGADK<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator KPIHKJNPOFH, Func<TSource, TResult> MNDCACPEAPE) where TSourceEnumerator : JFENMDHEJPP, IEnumerator<TSource>
	{
		return default(HLDIDDLFKAA<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class KALDDIFAFEB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x301B4F0", Offset = "0x301A6F0", VA = "0x18301B4F0")]
	public static bool DLBOMHFMMFB<TSourceEnumerator>(TSourceEnumerator KPIHKJNPOFH) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3028060", Offset = "0x3027260", VA = "0x183028060")]
	public static T INAFNGKMLPL<TSourceEnumerator>(TSourceEnumerator KPIHKJNPOFH) where TSourceEnumerator : POOPLIPGACJ<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x301F270", Offset = "0x301E470", VA = "0x18301F270")]
	public static T[] GDMKOOIFJID<TSourceEnumerator>(TSourceEnumerator KPIHKJNPOFH) where TSourceEnumerator : JFENMDHEJPP, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x301B2B0", Offset = "0x301A4B0", VA = "0x18301B2B0")]
	public static T BGLLBFHONCD<TSourceEnumerator>(TSourceEnumerator KPIHKJNPOFH) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct JKBCDEMKNGM<T, U> : IEnumerable<T>, IEnumerable where U : POOPLIPGACJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U BOGPIOLBKMC;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2115A60", Offset = "0x2114C60", VA = "0x182115A60")]
	internal JKBCDEMKNGM(in U LMCDAHACENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xE6A190", Offset = "0xE69390", VA = "0x180E6A190", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x292A040", Offset = "0x2929240", VA = "0x18292A040", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x292A040", Offset = "0x2929240", VA = "0x18292A040", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GKHHAHIHGJC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x20FB850", Offset = "0x20FAA50", VA = "0x1820FB850")]
	public static JKBCDEMKNGM<T, U> HBHNAKPOBBF<U>(in U KPIHKJNPOFH) where U : POOPLIPGACJ<T>
	{
		return default(JKBCDEMKNGM<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DefaultMember("Item")]
public readonly struct HPADLKOPCDF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct ODBGCFBOMPJ : JFENMDHEJPP, POOPLIPGACJ<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly T[] ILDHJNLEPHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int AMGMOPHCFEN;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public readonly int JKNHGEMPCNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x25A1940", Offset = "0x25A0B40", VA = "0x1825A1940", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public readonly T JLCKGMHIDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2DA1970", Offset = "0x2DA0B70", VA = "0x182DA1970", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2DA12E0", Offset = "0x2DA04E0", VA = "0x182DA12E0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2DA1850", Offset = "0x2DA0A50", VA = "0x182DA1850", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x10CC660", Offset = "0x10CB860", VA = "0x1810CC660")]
		private ODBGCFBOMPJ(T[] KPIHKJNPOFH, int NNAODBDJDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2DA11F0", Offset = "0x2DA03F0", VA = "0x182DA11F0")]
		public static ODBGCFBOMPJ HBHNAKPOBBF(T[] KPIHKJNPOFH)
		{
			return default(ODBGCFBOMPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2DA1240", Offset = "0x2DA0440", VA = "0x182DA1240", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28BC520", Offset = "0x28BB720", VA = "0x1828BC520", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly T[] PNAKAFIEMIK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CKAIEHNDOML
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x25A1940", Offset = "0x25A0B40", VA = "0x1825A1940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1CCDF90", Offset = "0x1CCD190", VA = "0x181CCDF90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8BADB0", Offset = "0x8B9FB0", VA = "0x1808BADB0")]
	internal HPADLKOPCDF(T[] LMFDNLBGHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x25A1960", Offset = "0x25A0B60", VA = "0x1825A1960")]
	public static HPADLKOPCDF<T> LKJHINFHCEL()
	{
		return default(HPADLKOPCDF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0")]
	public IEnumerable<T> NJBHDBHLAKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x25A1820", Offset = "0x25A0A20", VA = "0x1825A1820")]
	public ReadOnlySpan<T> GHFPBNKJMGG()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x25A1A10", Offset = "0x25A0C10", VA = "0x1825A1A10")]
	public JKBCDEMKNGM<T, HPADLKOPCDF<T>.ODBGCFBOMPJ> MIDGHGNFPBP()
	{
		return default(JKBCDEMKNGM<T, ODBGCFBOMPJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x25A18B0", Offset = "0x25A0AB0", VA = "0x1825A18B0")]
	public ODBGCFBOMPJ HKPOAOADPDN()
	{
		return default(ODBGCFBOMPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x25A17A0", Offset = "0x25A09A0", VA = "0x1825A17A0")]
	public IEnumerator<T> EEOIHAEEMHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x25A1B30", Offset = "0x25A0D30", VA = "0x1825A1B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FHIHCFKIBGL
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1E209C0", Offset = "0x1E1FBC0", VA = "0x181E209C0")]
	public static HPADLKOPCDF<T> LIKFLKLFOKA<T>(params T[] LMFDNLBGHBA) where T : notnull
	{
		return default(HPADLKOPCDF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F833B0", Offset = "0x6F825B0", VA = "0x186F833B0")]
	public static Stream KFLGCBANHDI(this HPADLKOPCDF<byte> KPIHKJNPOFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JFENMDHEJPP
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct EAKPIODIEFB<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly U BOGPIOLBKMC;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2C26AE0", Offset = "0x2C25CE0", VA = "0x182C26AE0")]
	internal EAKPIODIEFB(in U LMCDAHACENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2C269E0", Offset = "0x2C25BE0", VA = "0x182C269E0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2C269E0", Offset = "0x2C25BE0", VA = "0x182C269E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KFJOLJIMPIB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x302BE30", Offset = "0x302B030", VA = "0x18302BE30")]
	public static EAKPIODIEFB<T, U> HBHNAKPOBBF<U>(in U KPIHKJNPOFH) where U : IEnumerator<T>
	{
		return default(EAKPIODIEFB<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public sealed class LLOONKDMADH<T> : IDisposable, JFENMDHEJPP, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private FDMGFEAFPED<T> KAMKGBFKIKA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3BFC840", Offset = "0x3BFBA40", VA = "0x183BFC840", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3BFC860", Offset = "0x3BFBA60", VA = "0x183BFC860")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC710", Offset = "0x3BFB910", VA = "0x183BFC710")]
	public static LLOONKDMADH<T> HBHNAKPOBBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC880", Offset = "0x3BFBA80", VA = "0x183BFC880")]
	public static LLOONKDMADH<T> MFIJENKGAAP(int HCKHKGKDPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6D20", Offset = "0x2CA5F20", VA = "0x182CA6D20")]
	internal LLOONKDMADH(in FDMGFEAFPED<T> KPCECNDHFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC6B0", Offset = "0x3BFB8B0", VA = "0x183BFC6B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC690", Offset = "0x3BFB890", VA = "0x183BFC690")]
	public void CKPKOIJGHLD(in T NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC820", Offset = "0x3BFBA20", VA = "0x183BFC820")]
	public void KDJFNGAAGEB(int BKHJHJOLNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC6D0", Offset = "0x3BFB8D0", VA = "0x183BFC6D0", Slot = "8")]
	public FDMGFEAFPED<T>.NMCFHLKDEGK GetEnumerator()
	{
		return default(FDMGFEAFPED<T>.NMCFHLKDEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC9A0", Offset = "0x3BFBBA0", VA = "0x183BFC9A0", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3BFC9A0", Offset = "0x3BFBBA0", VA = "0x183BFC9A0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(FDMGFEAFPED<>.JAEBNPBLDAB))]
public struct FDMGFEAFPED<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct NMCFHLKDEGK : JFENMDHEJPP, KIIPFAODMFJ<T>, POOPLIPGACJ<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] AAIIICMEALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int CKMPKBGJILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int AMGMOPHCFEN;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly int JKNHGEMPCNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x15BDD70", Offset = "0x15BCF70", VA = "0x1815BDD70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public readonly T JLCKGMHIDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2D70030", Offset = "0x2D6F230", VA = "0x182D70030", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private readonly T KJAFPGEHIPF
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x2D6EEB0", Offset = "0x2D6E0B0", VA = "0x182D6EEB0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x2D6F370", Offset = "0x2D6E570", VA = "0x182D6F370", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x2D6F970", Offset = "0x2D6EB70", VA = "0x182D6F970", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1C43EE0", Offset = "0x1C430E0", VA = "0x181C43EE0")]
		internal NMCFHLKDEGK(T[] JLPNEGMFCHO, int BKHJHJOLNNF, int NNAODBDJDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2D6F1B0", Offset = "0x2D6E3B0", VA = "0x182D6F1B0")]
		public static NMCFHLKDEGK HBHNAKPOBBF(ref FDMGFEAFPED<T> KPIHKJNPOFH)
		{
			return default(NMCFHLKDEGK);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x280B910", Offset = "0x280AB10", VA = "0x18280B910", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x280B100", Offset = "0x280A300", VA = "0x18280B100", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct LIAHHBDLJNI : JFENMDHEJPP, POOPLIPGACJ<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private NMCFHLKDEGK BOGPIOLBKMC;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int JKNHGEMPCNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x29F4770", Offset = "0x29F3970", VA = "0x1829F4770", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly T JLCKGMHIDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x29F5700", Offset = "0x29F4900", VA = "0x1829F5700", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x29F4820", Offset = "0x29F3A20", VA = "0x1829F4820", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x29F4FA0", Offset = "0x29F41A0", VA = "0x1829F4FA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2115A60", Offset = "0x2114C60", VA = "0x182115A60")]
		private LIAHHBDLJNI(in NMCFHLKDEGK LMCDAHACENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x29F46B0", Offset = "0x29F38B0", VA = "0x1829F46B0")]
		public static LIAHHBDLJNI HBHNAKPOBBF(in FDMGFEAFPED<T> KPIHKJNPOFH)
		{
			return default(LIAHHBDLJNI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x29F47A0", Offset = "0x29F39A0", VA = "0x1829F47A0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x29F47E0", Offset = "0x29F39E0", VA = "0x1829F47E0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x29F4670", Offset = "0x29F3870", VA = "0x1829F4670", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class JAEBNPBLDAB
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] AAIIICMEALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int CKMPKBGJILM;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1C67970", Offset = "0x1C66B70", VA = "0x181C67970")]
	public static FDMGFEAFPED<T> HBHNAKPOBBF()
	{
		return default(FDMGFEAFPED<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1C67A40", Offset = "0x1C66C40", VA = "0x181C67A40")]
	public static FDMGFEAFPED<T> MFIJENKGAAP(int HCKHKGKDPCJ)
	{
		return default(FDMGFEAFPED<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x10CC660", Offset = "0x10CB860", VA = "0x1810CC660")]
	internal FDMGFEAFPED(T[] JLPNEGMFCHO, int BKHJHJOLNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1C67B20", Offset = "0x1C66D20", VA = "0x181C67B20", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class AAHLMIFNBJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB750", Offset = "0x1FCA950", VA = "0x181FCB750")]
	public static void NDBCAEEMEJN<T>(this ref FDMGFEAFPED<T> KPIHKJNPOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6D90", Offset = "0x1FC5F90", VA = "0x181FC6D90")]
	public static string JMILAAPDJGB<T>(this in FDMGFEAFPED<T> KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7E20A0", Offset = "0x7E12A0", VA = "0x1807E20A0")]
	public static T[] PIDDFBFBCGJ<T>(this in FDMGFEAFPED<T> KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1CCDF50", Offset = "0x1CCD150", VA = "0x181CCDF50")]
	public static T MCKGCJAFOEM<T>(this in FDMGFEAFPED<T> KPIHKJNPOFH, int LHPGLCOPMKK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9940", Offset = "0x1FC8B40", VA = "0x181FC9940")]
	public static T MBAEFAJFFMJ<T>(this ref FDMGFEAFPED<T> KPIHKJNPOFH, int LHPGLCOPMKK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2980", Offset = "0x1FC1B80", VA = "0x181FC2980")]
	public static T GBOKIDFDJAA<T>(this in FDMGFEAFPED<T> KPIHKJNPOFH, int LHPGLCOPMKK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1CB0", Offset = "0x1FC0EB0", VA = "0x181FC1CB0")]
	public static void BNDJKAKDCIM<T>(this ref FDMGFEAFPED<T> KPIHKJNPOFH, int LHPGLCOPMKK, in T NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1FC66B0", Offset = "0x1FC58B0", VA = "0x181FC66B0")]
	public static void HEHEOJOMNLK<T>(this ref FDMGFEAFPED<T> KPIHKJNPOFH, int LHPGLCOPMKK, T NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x15BDD70", Offset = "0x15BCF70", VA = "0x1815BDD70")]
	public static int FOKEADFJEIE<T>(this in FDMGFEAFPED<T> KPIHKJNPOFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1FC3000", Offset = "0x1FC2200", VA = "0x181FC3000")]
	public static ReadOnlySpan<T> GHFPBNKJMGG<T>(this in FDMGFEAFPED<T> KPIHKJNPOFH)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1FC21C0", Offset = "0x1FC13C0", VA = "0x181FC21C0")]
	public static void CKPKOIJGHLD<T>(this ref FDMGFEAFPED<T> KPIHKJNPOFH, in T NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6740", Offset = "0x1FC5940", VA = "0x181FC6740")]
	public static void HMBGKLGIBGE<T>(this ref FDMGFEAFPED<T> KPIHKJNPOFH, int NNAODBDJDNJ, in T NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB7C0", Offset = "0x1FCA9C0", VA = "0x181FCB7C0")]
	public static void ODEIAKEFOAE<T>(this ref FDMGFEAFPED<T> KPIHKJNPOFH, int NNAODBDJDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1FC2900", Offset = "0x1FC1B00", VA = "0x181FC2900")]
	public static T FEALDJGENMA<T>(this ref FDMGFEAFPED<T> KPIHKJNPOFH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FC8940", Offset = "0x1FC7B40", VA = "0x181FC8940")]
	public static void KDJFNGAAGEB<T>(this ref FDMGFEAFPED<T> KPIHKJNPOFH, int BKHJHJOLNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1FC9EC0", Offset = "0x1FC90C0", VA = "0x181FC9EC0")]
	private static void MLHDGDCCDCC<T>(this ref FDMGFEAFPED<T> KPIHKJNPOFH, int HCKHKGKDPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1FC69B0", Offset = "0x1FC5BB0", VA = "0x181FC69B0")]
	public static void HNOBOGMOMNO<T>(this ref FDMGFEAFPED<T> KPIHKJNPOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1B10", Offset = "0x1FC0D10", VA = "0x181FC1B10")]
	public static bool APMIOMHFPCP<T>(this ref FDMGFEAFPED<T> KPIHKJNPOFH, in T NABCGCEIEGG) where T : JGMIOPFGKLF<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1CD3030", Offset = "0x1CD2230", VA = "0x181CD3030")]
	public static bool IFJLJEPJEPD<T>(this in FDMGFEAFPED<T> KPIHKJNPOFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1FC28A0", Offset = "0x1FC1AA0", VA = "0x181FC28A0")]
	public static bool DFOOAGLIKAA<T>(this in FDMGFEAFPED<T> KPIHKJNPOFH, int LHPGLCOPMKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC28D0", Offset = "0x1FC1AD0", VA = "0x181FC28D0")]
	public static FDMGFEAFPED<T>.LIAHHBDLJNI EEOIHAEEMHN<T>(this in FDMGFEAFPED<T> KPIHKJNPOFH)
	{
		return default(FDMGFEAFPED<T>.LIAHHBDLJNI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1FC28D0", Offset = "0x1FC1AD0", VA = "0x181FC28D0")]
	public static FDMGFEAFPED<T>.NMCFHLKDEGK DGLOKNJILJA<T>(this ref FDMGFEAFPED<T> KPIHKJNPOFH)
	{
		return default(FDMGFEAFPED<T>.NMCFHLKDEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB800", Offset = "0x1FCAA00", VA = "0x181FCB800")]
	public static JKBCDEMKNGM<T, FDMGFEAFPED<T>.LIAHHBDLJNI> OOGHOJAOPGC<T>(this in FDMGFEAFPED<T> KPIHKJNPOFH)
	{
		return default(JKBCDEMKNGM<T, FDMGFEAFPED<T>.LIAHHBDLJNI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct CBHICEJNKGC<TSourceEnumerator, TSource, TResult> : JFENMDHEJPP, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : JFENMDHEJPP, POOPLIPGACJ<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private TSourceEnumerator ILDHJNLEPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly DABCLNLOMAJ<TSource, TResult> HJFEFEOCLDE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public readonly int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1E4BAF0", Offset = "0x1E4ACF0", VA = "0x181E4BAF0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public readonly TResult JLCKGMHIDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C450", Offset = "0x1E4B650", VA = "0x181E4C450", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C220", Offset = "0x1E4B420", VA = "0x181E4C220", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x15BCDC0", Offset = "0x15BBFC0", VA = "0x1815BCDC0")]
	internal CBHICEJNKGC(in TSourceEnumerator KPIHKJNPOFH, DABCLNLOMAJ<TSource, TResult> MNDCACPEAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1E4BE40", Offset = "0x1E4B040", VA = "0x181E4BE40", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C040", Offset = "0x1E4B240", VA = "0x181E4C040", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1E4B900", Offset = "0x1E4AB00", VA = "0x181E4B900", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct HLDIDDLFKAA<TSourceEnumerator, TSource, TResult> : JFENMDHEJPP, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : JFENMDHEJPP, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private TSourceEnumerator ILDHJNLEPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Func<TSource, TResult> HJFEFEOCLDE;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public readonly int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x20AB7C0", Offset = "0x20AA9C0", VA = "0x1820AB7C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public readonly TResult JLCKGMHIDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C2A0", Offset = "0x1E4B4A0", VA = "0x181E4C2A0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C160", Offset = "0x1E4B360", VA = "0x181E4C160", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x15BCDC0", Offset = "0x15BBFC0", VA = "0x1815BCDC0")]
	internal HLDIDDLFKAA(in TSourceEnumerator KPIHKJNPOFH, Func<TSource, TResult> MNDCACPEAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x20AB900", Offset = "0x20AAB00", VA = "0x1820AB900", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x20ABA70", Offset = "0x20AAC70", VA = "0x1820ABA70", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x20AB6A0", Offset = "0x20AA8A0", VA = "0x1820AB6A0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KIIPFAODMFJ<T> : POOPLIPGACJ<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class BFHNIELEKHK
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1930E10", Offset = "0x1930010", VA = "0x181930E10")]
	public static HPADLKOPCDF<T> JLELMMDGCJA<T>(this T[] KPIHKJNPOFH) where T : notnull
	{
		return default(HPADLKOPCDF<T>);
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
