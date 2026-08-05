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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x62CBA70", Offset = "0x62CA870", VA = "0x1862CBA70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DC0", Offset = "0x7D8BC0", VA = "0x1807D9DC0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E00", Offset = "0x7D8C00", VA = "0x1807D9E00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NPFBEEDHGBH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x269FAE0", Offset = "0x269E8E0", VA = "0x18269FAE0")]
	public static GFNEJJPKIIB<T> OBFCCEPHAAB<T>(this T[] ILACEKALGJH) where T : notnull
	{
		return default(GFNEJJPKIIB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class PNBPCHLIMKD<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NGFOIHIBELM<T> HIBKNIHOKEI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x41E2450", Offset = "0x41E1250", VA = "0x1841E2450", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x41E2420", Offset = "0x41E1220", VA = "0x1841E2420")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x41E2310", Offset = "0x41E1110", VA = "0x1841E2310")]
	public static PNBPCHLIMKD<T> KHDJPNLCMFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x38D45B0", Offset = "0x38D33B0", VA = "0x1838D45B0")]
	internal PNBPCHLIMKD([In] NGFOIHIBELM<T> LFPEHEIJNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x41E2290", Offset = "0x41E1090", VA = "0x1841E2290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x41E22F0", Offset = "0x41E10F0", VA = "0x1841E22F0")]
	public void JICNDMBJBCM(int NJKDAMEBDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x41E22B0", Offset = "0x41E10B0", VA = "0x1841E22B0", Slot = "8")]
	public NGFOIHIBELM<T>.JNCPDBHAADD GetEnumerator()
	{
		return default(NGFOIHIBELM<T>.JNCPDBHAADD);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x41E2480", Offset = "0x41E1280", VA = "0x1841E2480", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x41E2480", Offset = "0x41E1280", VA = "0x1841E2480", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PIBDFLMMCNF<T, U> : IEnumerable<T>, IEnumerable where U : BCHNIHNEAIJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U BPOOJNNIAMC;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E0BEE0", Offset = "0x1E0ACE0", VA = "0x181E0BEE0")]
	internal PIBDFLMMCNF([In] U PCKGONCDMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x881420", Offset = "0x880220", VA = "0x180881420", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x382D190", Offset = "0x382BF90", VA = "0x18382D190", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x382D190", Offset = "0x382BF90", VA = "0x18382D190", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EOGKKCIOBFA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x23BD3E0", Offset = "0x23BC1E0", VA = "0x1823BD3E0")]
	public static PIBDFLMMCNF<T, U> KHDJPNLCMFA<U>([In] U ILACEKALGJH) where U : BCHNIHNEAIJ<T>
	{
		return default(PIBDFLMMCNF<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct CBADNDLLJMD<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U BPOOJNNIAMC;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4C3D950", Offset = "0x4C3C750", VA = "0x184C3D950")]
	internal CBADNDLLJMD([In] U PCKGONCDMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4C3D4E0", Offset = "0x4C3C2E0", VA = "0x184C3D4E0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4C3D5F0", Offset = "0x4C3C3F0", VA = "0x184C3D5F0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4C3D5F0", Offset = "0x4C3C3F0", VA = "0x184C3D5F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NHFFIPILFHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x27E5BE0", Offset = "0x27E49E0", VA = "0x1827E5BE0")]
	public static CBADNDLLJMD<T, U> KHDJPNLCMFA<U>([In] U ILACEKALGJH) where U : IEnumerator<T>
	{
		return default(CBADNDLLJMD<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class OPHIACBNJOH
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A29860", Offset = "0x2A28660", VA = "0x182A29860")]
	public static string BLBDLDOGNLM<T>(this IEnumerable<T> ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D150", Offset = "0x2A2BF50", VA = "0x182A2D150")]
	public static string GFIAFILPDMB<T>(this IEnumerable<T> ILACEKALGJH, string AOEIIPMJFBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HLKJPLJNFIG
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x28EB700", Offset = "0x28EA500", VA = "0x1828EB700")]
	public static bool COFDPFPNODP<TSourceEnumerator, TSource>(this TSourceEnumerator ILACEKALGJH, [In] TSource LMLNLGNPIDN) where TSourceEnumerator : BCHNIHNEAIJ<TSource> where TSource : OBICLNGMMNH<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x28EB4A0", Offset = "0x28EA2A0", VA = "0x1828EB4A0")]
	public static int AGJHPDCEAJF<TSourceEnumerator, TSource>(this TSourceEnumerator ILACEKALGJH, [In] TSource DIBNBLEEFNN) where TSourceEnumerator : BCHNIHNEAIJ<TSource> where TSource : OBICLNGMMNH<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BCHNIHNEAIJ<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T HKCIIOLPAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KNPOMKJPAEG<T> : BCHNIHNEAIJ<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FCGCABPNPJB<T, U> : IEnumerable<T>, IEnumerable where U : KNPOMKJPAEG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U BPOOJNNIAMC;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x382D2C0", Offset = "0x382C0C0", VA = "0x18382D2C0")]
	internal FCGCABPNPJB([In] U PCKGONCDMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x35593A0", Offset = "0x35581A0", VA = "0x1835593A0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x382D200", Offset = "0x382C000", VA = "0x18382D200", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x382D200", Offset = "0x382C000", VA = "0x18382D200", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BGFNLNFKOKN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x23BD3B0", Offset = "0x23BC1B0", VA = "0x1823BD3B0")]
	public static FCGCABPNPJB<T, U> KHDJPNLCMFA<U>([In] U ILACEKALGJH) where U : KNPOMKJPAEG<T>
	{
		return default(FCGCABPNPJB<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct GFNEJJPKIIB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct COMAHCMKFOM : BCHNIHNEAIJ<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] EFBBDCEIHHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int BHJJIECEHDJ;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T HKCIIOLPAGP
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x4E06F80", Offset = "0x4E05D80", VA = "0x184E06F80", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4E06A10", Offset = "0x4E05810", VA = "0x184E06A10", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4E06E20", Offset = "0x4E05C20", VA = "0x184E06E20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x18EBE50", Offset = "0x18EAC50", VA = "0x1818EBE50")]
		private COMAHCMKFOM(T[] ILACEKALGJH, int AELAKOMEEDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4E06770", Offset = "0x4E05570", VA = "0x184E06770")]
		public static COMAHCMKFOM KHDJPNLCMFA(T[] ILACEKALGJH)
		{
			return default(COMAHCMKFOM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D570", Offset = "0x1E2C370", VA = "0x181E2D570", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D5A0", Offset = "0x1E2C3A0", VA = "0x181E2D5A0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] FLPMHNAINML;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NIBNLPMGPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3933EB0", Offset = "0x3932CB0", VA = "0x183933EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2A01590", Offset = "0x2A00390", VA = "0x182A01590")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x93C860", Offset = "0x93B660", VA = "0x18093C860")]
	internal GFNEJJPKIIB(T[] OKLABKDOFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3933C70", Offset = "0x3932A70", VA = "0x183933C70")]
	public static GFNEJJPKIIB<T> CNCELEPFOGN()
	{
		return default(GFNEJJPKIIB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
	public IEnumerable<T> GKNHIFGKFOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3933ED0", Offset = "0x3932CD0", VA = "0x183933ED0")]
	public ReadOnlySpan<T> LCCCOIPDPGK()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3933DA0", Offset = "0x3932BA0", VA = "0x183933DA0")]
	public PIBDFLMMCNF<T, GFNEJJPKIIB<T>.COMAHCMKFOM> HJKEPDIACLE()
	{
		return default(PIBDFLMMCNF<T, COMAHCMKFOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3933BE0", Offset = "0x39329E0", VA = "0x183933BE0")]
	public COMAHCMKFOM BEHAMCMEPNN()
	{
		return default(COMAHCMKFOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3933D20", Offset = "0x3932B20", VA = "0x183933D20")]
	public IEnumerator<T> CNEJODDGPIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3933F60", Offset = "0x3932D60", VA = "0x183933F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IONGNMEOCLG
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x27D5200", Offset = "0x27D4000", VA = "0x1827D5200")]
	public static GFNEJJPKIIB<T> CPNIHMABLJD<T>(params T[] OKLABKDOFAF) where T : notnull
	{
		return default(GFNEJJPKIIB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x62CBA10", Offset = "0x62CA810", VA = "0x1862CBA10")]
	public static Stream KGPGEMFMHDH(this GFNEJJPKIIB<byte> ILACEKALGJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(NGFOIHIBELM<>.JDMKIBLLBDO))]
public struct NGFOIHIBELM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct JNCPDBHAADD : KNPOMKJPAEG<T>, BCHNIHNEAIJ<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] EEBIGCLHNDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int AGCEEKFFPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int BHJJIECEHDJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T HKCIIOLPAGP
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3C54130", Offset = "0x3C52F30", VA = "0x183C54130", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private readonly T BCMANGKEOKC
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3C53970", Offset = "0x3C52770", VA = "0x183C53970", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3C53BA0", Offset = "0x3C529A0", VA = "0x183C53BA0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3C53FB0", Offset = "0x3C52DB0", VA = "0x183C53FB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3C3F640", Offset = "0x3C3E440", VA = "0x183C3F640")]
		internal JNCPDBHAADD(T[] OMJAEJKGFAD, int NJKDAMEBDBN, int AELAKOMEEDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3C53870", Offset = "0x3C52670", VA = "0x183C53870")]
		public static JNCPDBHAADD KHDJPNLCMFA(NGFOIHIBELM<T> ILACEKALGJH)
		{
			return default(JNCPDBHAADD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x351D3F0", Offset = "0x351C1F0", VA = "0x18351D3F0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x35166D0", Offset = "0x35154D0", VA = "0x1835166D0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct GHHHKGFPNDA : BCHNIHNEAIJ<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JNCPDBHAADD BPOOJNNIAMC;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly T HKCIIOLPAGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3938990", Offset = "0x3937790", VA = "0x183938990", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x39386D0", Offset = "0x39374D0", VA = "0x1839386D0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3938730", Offset = "0x3937530", VA = "0x183938730", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BEE0", Offset = "0x1E0ACE0", VA = "0x181E0BEE0")]
		private GHHHKGFPNDA([In] JNCPDBHAADD PCKGONCDMJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x39384D0", Offset = "0x39372D0", VA = "0x1839384D0")]
		public static GHHHKGFPNDA KHDJPNLCMFA([In] NGFOIHIBELM<T> ILACEKALGJH)
		{
			return default(GHHHKGFPNDA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3938580", Offset = "0x3937380", VA = "0x183938580", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x39385C0", Offset = "0x39373C0", VA = "0x1839385C0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3938490", Offset = "0x3937290", VA = "0x183938490", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class JDMKIBLLBDO
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] EEBIGCLHNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int AGCEEKFFPCP;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x401F6E0", Offset = "0x401E4E0", VA = "0x18401F6E0")]
	public static NGFOIHIBELM<T> KHDJPNLCMFA()
	{
		return default(NGFOIHIBELM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x401F630", Offset = "0x401E430", VA = "0x18401F630")]
	public static NGFOIHIBELM<T> IHOIOMMBMOF(int GIOLCDOMFDF)
	{
		return default(NGFOIHIBELM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x18EBE50", Offset = "0x18EAC50", VA = "0x1818EBE50")]
	internal NGFOIHIBELM(T[] OMJAEJKGFAD, int NJKDAMEBDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x401F780", Offset = "0x401E580", VA = "0x18401F780", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NFDDNPCDHNI
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int MGNPEAOHBHL<TCtx, T>([In] TCtx LGCLICFOKFI, T MAEINFGKCEL, T FLBFHNBPNFN);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2A05250", Offset = "0x2A04050", VA = "0x182A05250")]
	public static void OFGJMFOHKEH<T>(this NGFOIHIBELM<T> ILACEKALGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x29FECF0", Offset = "0x29FDAF0", VA = "0x1829FECF0")]
	public static string CFKGCICGBLJ<T>([In] this NGFOIHIBELM<T> ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
	public static T[] KNLECBJJNEG<T>([In] this NGFOIHIBELM<T> ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2A01550", Offset = "0x2A00350", VA = "0x182A01550")]
	public static T DJGCEJBDGHO<T>([In] this NGFOIHIBELM<T> ILACEKALGJH, int GJPDNBKOLHF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2A01590", Offset = "0x2A00390", VA = "0x182A01590")]
	public static T MBGFEJJHOCA<T>(this NGFOIHIBELM<T> ILACEKALGJH, int GJPDNBKOLHF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x29FEA90", Offset = "0x29FD890", VA = "0x1829FEA90")]
	public static T BPDMNKJGJJC<T>([In] this NGFOIHIBELM<T> ILACEKALGJH, int GJPDNBKOLHF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A04850", Offset = "0x2A03650", VA = "0x182A04850")]
	public static void KNPAMBFMNAD<T>(this NGFOIHIBELM<T> ILACEKALGJH, int GJPDNBKOLHF, [In] T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2A01450", Offset = "0x2A00250", VA = "0x182A01450")]
	public static void CIJBCGIAIKG<T>(this NGFOIHIBELM<T> ILACEKALGJH, int GJPDNBKOLHF, T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F0B0", Offset = "0x1E4DEB0", VA = "0x181E4F0B0")]
	public static int IHIKIDOFDPL<T>([In] this NGFOIHIBELM<T> ILACEKALGJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A04E30", Offset = "0x2A03C30", VA = "0x182A04E30")]
	public static ReadOnlySpan<T> LCCCOIPDPGK<T>([In] this NGFOIHIBELM<T> ILACEKALGJH)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2A02570", Offset = "0x2A01370", VA = "0x182A02570")]
	public static T[] IEFAIGLMHNC<T>([In] this NGFOIHIBELM<T> ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A02780", Offset = "0x2A01580", VA = "0x182A02780")]
	public static T ILPNIHJGPLP<T>([In] this NGFOIHIBELM<T> ILACEKALGJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2A01780", Offset = "0x2A00580", VA = "0x182A01780")]
	public static T[] EBDMIMKGPMI<T>(this NGFOIHIBELM<T> ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2A054B0", Offset = "0x2A042B0", VA = "0x182A054B0")]
	public static GFNEJJPKIIB<T> OJGPIJDJKFP<T>(this NGFOIHIBELM<T> ILACEKALGJH)
	{
		return default(GFNEJJPKIIB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2A01ED0", Offset = "0x2A00CD0", VA = "0x182A01ED0")]
	public static void HDCMKJKDALC<T>(this NGFOIHIBELM<T> ILACEKALGJH, [In] T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2A04FC0", Offset = "0x2A03DC0", VA = "0x182A04FC0")]
	public static void LEMEOCOJEGP<T>(this NGFOIHIBELM<T> ILACEKALGJH, T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2A01C50", Offset = "0x2A00A50", VA = "0x182A01C50")]
	public static void EMBCACFGACK<T>(this NGFOIHIBELM<T> ILACEKALGJH, int AELAKOMEEDP, [In] T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2A027A0", Offset = "0x2A015A0", VA = "0x182A027A0")]
	public static void JCHAKBMPDKH<T>(this NGFOIHIBELM<T> ILACEKALGJH, int AELAKOMEEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2A050F0", Offset = "0x2A03EF0", VA = "0x182A050F0")]
	public static T LGOIPIBKNCO<T>(this NGFOIHIBELM<T> ILACEKALGJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2A02BB0", Offset = "0x2A019B0", VA = "0x182A02BB0")]
	public static void JICNDMBJBCM<T>(this NGFOIHIBELM<T> ILACEKALGJH, int NJKDAMEBDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2A05780", Offset = "0x2A04580", VA = "0x182A05780")]
	private static void PNPLHLGJHDO<T>(this NGFOIHIBELM<T> ILACEKALGJH, int GIOLCDOMFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2A02360", Offset = "0x2A01160", VA = "0x182A02360")]
	public static void HOCLBDDCDMI<T>(this NGFOIHIBELM<T> ILACEKALGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2A052B0", Offset = "0x2A040B0", VA = "0x182A052B0")]
	public static NGFOIHIBELM<T> OGJOLBOGFNJ<T>([In] this NGFOIHIBELM<T> ILACEKALGJH, JKKEMMFMAGL<T, T> BINNNNJOCFG)
	{
		return default(NGFOIHIBELM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x29FE9C0", Offset = "0x29FD7C0", VA = "0x1829FE9C0")]
	public static bool BDCAKLLDGHL<T>(this NGFOIHIBELM<T> ILACEKALGJH, [In] T DIBNBLEEFNN) where T : OBICLNGMMNH<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x276F3E0", Offset = "0x276E1E0", VA = "0x18276F3E0")]
	public static bool BOHPGLCBGLD<T>([In] this NGFOIHIBELM<T> ILACEKALGJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2A01E30", Offset = "0x2A00C30", VA = "0x182A01E30")]
	public static bool FEGJJPCFABM<T>([In] this NGFOIHIBELM<T> ILACEKALGJH, int GJPDNBKOLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2A02750", Offset = "0x2A01550", VA = "0x182A02750")]
	public static void IFPHJCIFJJM<T, TCtx>(this NGFOIHIBELM<T> ILACEKALGJH, [In] TCtx LGCLICFOKFI, MGNPEAOHBHL<TCtx, T> KGKIMNAJBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2A05190", Offset = "0x2A03F90", VA = "0x182A05190")]
	private static void NENPDGGJPLM<T, TCtx>(NGFOIHIBELM<T> ILACEKALGJH, [In] TCtx LGCLICFOKFI, MGNPEAOHBHL<TCtx, T> KGKIMNAJBMC, int HOGMFMLGBFM, int JBILCPHPFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2A01800", Offset = "0x2A00600", VA = "0x182A01800")]
	private static int EMAEFLHLLDA<T, TCtx>(NGFOIHIBELM<T> ILACEKALGJH, [In] TCtx LGCLICFOKFI, MGNPEAOHBHL<TCtx, T> KGKIMNAJBMC, int HOGMFMLGBFM, int JBILCPHPFFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x276FA90", Offset = "0x276E890", VA = "0x18276FA90")]
	public static NGFOIHIBELM<T>.GHHHKGFPNDA CNEJODDGPIM<T>([In] this NGFOIHIBELM<T> ILACEKALGJH)
	{
		return default(NGFOIHIBELM<T>.GHHHKGFPNDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x276FA90", Offset = "0x276E890", VA = "0x18276FA90")]
	public static NGFOIHIBELM<T>.JNCPDBHAADD DMKNAILGMJA<T>(this NGFOIHIBELM<T> ILACEKALGJH)
	{
		return default(NGFOIHIBELM<T>.JNCPDBHAADD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2908E70", Offset = "0x2907C70", VA = "0x182908E70")]
	public static PIBDFLMMCNF<T, NGFOIHIBELM<T>.GHHHKGFPNDA> PICJANNLAHM<T>([In] this NGFOIHIBELM<T> ILACEKALGJH)
	{
		return default(PIBDFLMMCNF<T, NGFOIHIBELM<T>.GHHHKGFPNDA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class JOKLLEAEKKP
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x293B2B0", Offset = "0x293A0B0", VA = "0x18293B2B0")]
	public static T[] MMMLMJNLKHJ<T>(int CGDBKIJPKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
	public static void IKDLDNNFCNM<T>(T[] OKLABKDOFAF)
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
