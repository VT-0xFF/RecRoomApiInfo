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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C67C30", Offset = "0x6C66630", VA = "0x186C67C30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5A0", Offset = "0x8ACFA0", VA = "0x1808AE5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE5E0", Offset = "0x8ACFE0", VA = "0x1808AE5E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CBDOLBOJHIM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9150", Offset = "0x2AC7B50", VA = "0x182AC9150")]
	public static LHPDPPIAGFF<T> POJCFCGCHFH<T>(this T[] NKCEKILMAAM) where T : notnull
	{
		return default(LHPDPPIAGFF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class HMOMJAGIAKN<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LPKDJPNEIBH<T> JNBNLEMDFMF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3FCB7B0", Offset = "0x3FCA1B0", VA = "0x183FCB7B0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3FCB8C0", Offset = "0x3FCA2C0", VA = "0x183FCB8C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3FCB900", Offset = "0x3FCA300", VA = "0x183FCB900")]
	public static HMOMJAGIAKN<T> OOAFHJGKFEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2940", Offset = "0x3ED1340", VA = "0x183ED2940")]
	internal HMOMJAGIAKN([In] LPKDJPNEIBH<T> KCEPABIAINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3FCB7F0", Offset = "0x3FCA1F0", VA = "0x183FCB7F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3FCB880", Offset = "0x3FCA280", VA = "0x183FCB880")]
	public void HCJDNLCMAFB(int CMNDBGDABDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3FCB830", Offset = "0x3FCA230", VA = "0x183FCB830", Slot = "8")]
	public LPKDJPNEIBH<T>.GJIBCKDPLLH GetEnumerator()
	{
		return default(LPKDJPNEIBH<T>.GJIBCKDPLLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3FCBA30", Offset = "0x3FCA430", VA = "0x183FCBA30", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3FCBA30", Offset = "0x3FCA430", VA = "0x183FCBA30", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct IBCEBGAEHGH<T, U> : IEnumerable<T>, IEnumerable where U : PABBFJLBAAC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U LFKIJGCPHNA;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x20FC6C0", Offset = "0x20FB0C0", VA = "0x1820FC6C0")]
	internal IBCEBGAEHGH([In] U BJLCJBDKLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3F43D40", Offset = "0x3F42740", VA = "0x183F43D40", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3F43D40", Offset = "0x3F42740", VA = "0x183F43D40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ABKICPKOHGA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2736C90", Offset = "0x2735690", VA = "0x182736C90")]
	public static IBCEBGAEHGH<T, U> OOAFHJGKFEK<U>([In] U NKCEKILMAAM) where U : PABBFJLBAAC<T>
	{
		return default(IBCEBGAEHGH<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct LPAHDOHNHGK<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U LFKIJGCPHNA;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3E013C0", Offset = "0x3DFFDC0", VA = "0x183E013C0")]
	internal LPAHDOHNHGK([In] U BJLCJBDKLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xCC2D70", Offset = "0xCC1770", VA = "0x180CC2D70", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x44B1400", Offset = "0x44AFE00", VA = "0x1844B1400", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x44B1400", Offset = "0x44AFE00", VA = "0x1844B1400", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class FABKNFDAPMG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2C028B0", Offset = "0x2C012B0", VA = "0x182C028B0")]
	public static LPAHDOHNHGK<T, U> OOAFHJGKFEK<U>([In] U NKCEKILMAAM) where U : IEnumerator<T>
	{
		return default(LPAHDOHNHGK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class BDFFECJLCGH
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2AD3260", Offset = "0x2AD1C60", VA = "0x182AD3260")]
	public static string CFACLPOOBEI<T>(this IEnumerable<T> NKCEKILMAAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6E60", Offset = "0x2AD5860", VA = "0x182AD6E60")]
	public static string MMAKABLDBFM<T>(this IEnumerable<T> NKCEKILMAAM, string CAMNIOKBPBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FEENPPBFMAM
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2D52930", Offset = "0x2D51330", VA = "0x182D52930")]
	public static bool JDJDMMEBNNJ<TSourceEnumerator, TSource>(this TSourceEnumerator NKCEKILMAAM, [In] TSource LHFGBAJKEKO) where TSourceEnumerator : PABBFJLBAAC<TSource> where TSource : DFOHKGGFAED<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2D52460", Offset = "0x2D50E60", VA = "0x182D52460")]
	public static int CAADBLHKLOI<TSourceEnumerator, TSource>(this TSourceEnumerator NKCEKILMAAM, [In] TSource IPHMAHBENGI) where TSourceEnumerator : PABBFJLBAAC<TSource> where TSource : DFOHKGGFAED<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2D526C0", Offset = "0x2D510C0", VA = "0x182D526C0")]
	public static int HKHHGAKJMAE<TSourceEnumerator, TSource>(this TSourceEnumerator NKCEKILMAAM, [In] TSource IPHMAHBENGI) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PABBFJLBAAC<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T EEAPHIFBJLL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BDCBOJMJGDB<T> : PABBFJLBAAC<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct HBHOBHMEMGN<T, U> : IEnumerable<T>, IEnumerable where U : BDCBOJMJGDB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U LFKIJGCPHNA;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3F43DB0", Offset = "0x3F427B0", VA = "0x183F43DB0")]
	internal HBHOBHMEMGN([In] U BJLCJBDKLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3AE57F0", Offset = "0x3AE41F0", VA = "0x183AE57F0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3F43CB0", Offset = "0x3F426B0", VA = "0x183F43CB0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3F43CB0", Offset = "0x3F426B0", VA = "0x183F43CB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BCOKFNOEABK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2736CC0", Offset = "0x27356C0", VA = "0x182736CC0")]
	public static HBHOBHMEMGN<T, U> OOAFHJGKFEK<U>([In] U NKCEKILMAAM) where U : BDCBOJMJGDB<T>
	{
		return default(HBHOBHMEMGN<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct LHPDPPIAGFF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct DFGEFNFBOFG : PABBFJLBAAC<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] IGPKHHNMPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int IMAPBIDBLMC;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T EEAPHIFBJLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5A88380", Offset = "0x5A86D80", VA = "0x185A88380", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5A87D40", Offset = "0x5A86740", VA = "0x185A87D40", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5A88110", Offset = "0x5A86B10", VA = "0x185A88110", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1E3F740", Offset = "0x1E3E140", VA = "0x181E3F740")]
		private DFGEFNFBOFG(T[] NKCEKILMAAM, int ENMILGHAHOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5A87C40", Offset = "0x5A86640", VA = "0x185A87C40")]
		public static DFGEFNFBOFG OOAFHJGKFEK(T[] NKCEKILMAAM)
		{
			return default(DFGEFNFBOFG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x213C040", Offset = "0x213AA40", VA = "0x18213C040", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x213C0A0", Offset = "0x213AAA0", VA = "0x18213C0A0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] CFAJBDGDNAD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NBHPLECAMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4371BD0", Offset = "0x43705D0", VA = "0x184371BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2E08F10", Offset = "0x2E07910", VA = "0x182E08F10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xB63000", Offset = "0xB61A00", VA = "0x180B63000")]
	internal LHPDPPIAGFF(T[] FEMJEOMOEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4497220", Offset = "0x4495C20", VA = "0x184497220")]
	public static LHPDPPIAGFF<T> CKLKOBNMKJP()
	{
		return default(LHPDPPIAGFF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
	public IEnumerable<T> AFMMOJHKPNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x44974C0", Offset = "0x4495EC0", VA = "0x1844974C0")]
	public ReadOnlySpan<T> LBBFPCJMMEE()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x44972F0", Offset = "0x4495CF0", VA = "0x1844972F0")]
	public IBCEBGAEHGH<T, LHPDPPIAGFF<T>.DFGEFNFBOFG> DLJEBIKBHMC()
	{
		return default(IBCEBGAEHGH<T, DFGEFNFBOFG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4497420", Offset = "0x4495E20", VA = "0x184497420")]
	public DFGEFNFBOFG FNBJLNBDBHE()
	{
		return default(DFGEFNFBOFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4497560", Offset = "0x4495F60", VA = "0x184497560")]
	public IEnumerator<T> PBHEMGCNMMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x44975E0", Offset = "0x4495FE0", VA = "0x1844975E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PNLGMDGFPFB
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2AC91B0", Offset = "0x2AC7BB0", VA = "0x182AC91B0")]
	public static LHPDPPIAGFF<T> FNKCIFBDKGH<T>(params T[] FEMJEOMOEIN) where T : notnull
	{
		return default(LHPDPPIAGFF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C67CB0", Offset = "0x6C666B0", VA = "0x186C67CB0")]
	public static Stream LAMJIGEDCDP(this LHPDPPIAGFF<byte> NKCEKILMAAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(LPKDJPNEIBH<>.JGMJFIHIAAH))]
public struct LPKDJPNEIBH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct GJIBCKDPLLH : BDCBOJMJGDB<T>, PABBFJLBAAC<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] CHIBKENCOHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int HLHFBEBFCGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int IMAPBIDBLMC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T EEAPHIFBJLL
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3EDD710", Offset = "0x3EDC110", VA = "0x183EDD710", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T IINHLIEOBCE
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3EDCC10", Offset = "0x3EDB610", VA = "0x183EDCC10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T KIMEKDINBIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3EDCD80", Offset = "0x3EDB780", VA = "0x183EDCD80", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3EDD190", Offset = "0x3EDBB90", VA = "0x183EDD190", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3EDD1E0", Offset = "0x3EDBBE0", VA = "0x183EDD1E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3EDD5B0", Offset = "0x3EDBFB0", VA = "0x183EDD5B0")]
		internal GJIBCKDPLLH(T[] CCIELLHDDHE, int CMNDBGDABDM, int ENMILGHAHOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3EDCF10", Offset = "0x3EDB910", VA = "0x183EDCF10")]
		public static GJIBCKDPLLH OOAFHJGKFEK(LPKDJPNEIBH<T> NKCEKILMAAM)
		{
			return default(GJIBCKDPLLH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3AA0180", Offset = "0x3A9EB80", VA = "0x183AA0180", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3A9D8E0", Offset = "0x3A9C2E0", VA = "0x183A9D8E0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct AIDHPCPPOMK : PABBFJLBAAC<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private GJIBCKDPLLH LFKIJGCPHNA;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T EEAPHIFBJLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3E98890", Offset = "0x3E97290", VA = "0x183E98890", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3E98630", Offset = "0x3E97030", VA = "0x183E98630", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3E986C0", Offset = "0x3E970C0", VA = "0x183E986C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x20FC6C0", Offset = "0x20FB0C0", VA = "0x1820FC6C0")]
		private AIDHPCPPOMK([In] GJIBCKDPLLH BJLCJBDKLFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3E98500", Offset = "0x3E96F00", VA = "0x183E98500")]
		public static AIDHPCPPOMK OOAFHJGKFEK([In] LPKDJPNEIBH<T> NKCEKILMAAM)
		{
			return default(AIDHPCPPOMK);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3E984C0", Offset = "0x3E96EC0", VA = "0x183E984C0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3E985B0", Offset = "0x3E96FB0", VA = "0x183E985B0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3E98480", Offset = "0x3E96E80", VA = "0x183E98480", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class JGMJFIHIAAH
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] CHIBKENCOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int HLHFBEBFCGM;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x44B4010", Offset = "0x44B2A10", VA = "0x1844B4010")]
	public static LPKDJPNEIBH<T> OOAFHJGKFEK()
	{
		return default(LPKDJPNEIBH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x44B3F50", Offset = "0x44B2950", VA = "0x1844B3F50")]
	public static LPKDJPNEIBH<T> LLMNOCBMDIE(int PAODLCPDLEP)
	{
		return default(LPKDJPNEIBH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F740", Offset = "0x1E3E140", VA = "0x181E3F740")]
	internal LPKDJPNEIBH(T[] CCIELLHDDHE, int CMNDBGDABDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x44B40C0", Offset = "0x44B2AC0", VA = "0x1844B40C0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KKKGMBFGKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int JEEMOAHLBKE<TCtx, T>([In] TCtx KKDHCJGLKPO, T MFLKJAHENBP, T PLHCHKLJLJD);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2E10870", Offset = "0x2E0F270", VA = "0x182E10870")]
	public static void MOGENANDEFO<T>(this LPKDJPNEIBH<T> NKCEKILMAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2E0CC10", Offset = "0x2E0B610", VA = "0x182E0CC10")]
	public static string MMHHMIGLDMC<T>([In] this LPKDJPNEIBH<T> NKCEKILMAAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
	public static T[] HDDBCKFOPEC<T>([In] this LPKDJPNEIBH<T> NKCEKILMAAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2E08ED0", Offset = "0x2E078D0", VA = "0x182E08ED0")]
	public static T GJMIFHLLDMF<T>([In] this LPKDJPNEIBH<T> NKCEKILMAAM, int ELMEOKPKOPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x213BF80", Offset = "0x213A980", VA = "0x18213BF80")]
	public static T IAFJKNFKKON<T>(this LPKDJPNEIBH<T> NKCEKILMAAM, int ELMEOKPKOPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2E08A20", Offset = "0x2E07420", VA = "0x182E08A20")]
	public static T ENGBLBGLELE<T>([In] this LPKDJPNEIBH<T> NKCEKILMAAM, int ELMEOKPKOPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2E12A60", Offset = "0x2E11460", VA = "0x182E12A60")]
	public static void ODIPBPJKHHK<T>(this LPKDJPNEIBH<T> NKCEKILMAAM, int ELMEOKPKOPN, [In] T IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2E12A60", Offset = "0x2E11460", VA = "0x182E12A60")]
	public static void PCKOODJAMLP<T>(this LPKDJPNEIBH<T> NKCEKILMAAM, int ELMEOKPKOPN, T IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x213C400", Offset = "0x213AE00", VA = "0x18213C400")]
	public static int BBMOLOGIHGC<T>([In] this LPKDJPNEIBH<T> NKCEKILMAAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C310", Offset = "0x2E0AD10", VA = "0x182E0C310")]
	public static ReadOnlySpan<T> LBBFPCJMMEE<T>([In] this LPKDJPNEIBH<T> NKCEKILMAAM)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C6B0", Offset = "0x2E0B0B0", VA = "0x182E0C6B0")]
	public static T[] LJAGFMEOBKA<T>([In] this LPKDJPNEIBH<T> NKCEKILMAAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BC40", Offset = "0x2E0A640", VA = "0x182E0BC40")]
	public static T IKOLOFHPDNM<T>([In] this LPKDJPNEIBH<T> NKCEKILMAAM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BB90", Offset = "0x2E0A590", VA = "0x182E0BB90")]
	public static T[] IHLPCAEJJFN<T>(this LPKDJPNEIBH<T> NKCEKILMAAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BC80", Offset = "0x2E0A680", VA = "0x182E0BC80")]
	public static LHPDPPIAGFF<T> JMHIEAGAALJ<T>(this LPKDJPNEIBH<T> NKCEKILMAAM)
	{
		return default(LHPDPPIAGFF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BDC0", Offset = "0x2E0A7C0", VA = "0x182E0BDC0")]
	public static void KDCHLCHLBCK<T>(this LPKDJPNEIBH<T> NKCEKILMAAM, [In] T IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2E081E0", Offset = "0x2E06BE0", VA = "0x182E081E0")]
	public static void AFIHOMPEPON<T>(this LPKDJPNEIBH<T> NKCEKILMAAM, T IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C8A0", Offset = "0x2E0B2A0", VA = "0x182E0C8A0")]
	public static void MHGAKADDEOO<T>(this LPKDJPNEIBH<T> NKCEKILMAAM, int ENMILGHAHOM, [In] T IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C410", Offset = "0x2E0AE10", VA = "0x182E0C410")]
	public static void LDMMODEAIAE<T>(this LPKDJPNEIBH<T> NKCEKILMAAM, int ENMILGHAHOM, T IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2E08340", Offset = "0x2E06D40", VA = "0x182E08340")]
	public static void CDFFICCMFMF<T>(this LPKDJPNEIBH<T> NKCEKILMAAM, int ENMILGHAHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2E10810", Offset = "0x2E0F210", VA = "0x182E10810")]
	public static T MMLGMCPDNAA<T>(this LPKDJPNEIBH<T> NKCEKILMAAM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2E09AE0", Offset = "0x2E084E0", VA = "0x182E09AE0")]
	public static void HCJDNLCMAFB<T>(this LPKDJPNEIBH<T> NKCEKILMAAM, int CMNDBGDABDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2E10C30", Offset = "0x2E0F630", VA = "0x182E10C30")]
	private static void NCIICOBINCD<T>(this LPKDJPNEIBH<T> NKCEKILMAAM, int PAODLCPDLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2E13130", Offset = "0x2E11B30", VA = "0x182E13130")]
	public static void ODPBLJHKGDP<T>(this LPKDJPNEIBH<T> NKCEKILMAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2E0B8F0", Offset = "0x2E0A2F0", VA = "0x182E0B8F0")]
	public static LPKDJPNEIBH<T> HNCMOJOADMF<T>([In] this LPKDJPNEIBH<T> NKCEKILMAAM, DEKGDJINLLG<T, T> INNBFOJKJNI)
	{
		return default(LPKDJPNEIBH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2E08CF0", Offset = "0x2E076F0", VA = "0x182E08CF0")]
	public static bool GDFNAHCIADO<T>(this LPKDJPNEIBH<T> NKCEKILMAAM, T IPHMAHBENGI) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2E08C20", Offset = "0x2E07620", VA = "0x182E08C20")]
	public static bool FEHJGCCPLME<T>(this LPKDJPNEIBH<T> NKCEKILMAAM, [In] T IPHMAHBENGI) where T : DFOHKGGFAED<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2BCA0C0", Offset = "0x2BC8AC0", VA = "0x182BCA0C0")]
	public static bool LOJKAIEMICI<T>([In] this LPKDJPNEIBH<T> NKCEKILMAAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2E0B890", Offset = "0x2E0A290", VA = "0x182E0B890")]
	public static bool HIDPELHAEHL<T>([In] this LPKDJPNEIBH<T> NKCEKILMAAM, int ELMEOKPKOPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2E12940", Offset = "0x2E11340", VA = "0x182E12940")]
	public static void NHPHJNMMNAG<T, TCtx>(this LPKDJPNEIBH<T> NKCEKILMAAM, [In] TCtx KKDHCJGLKPO, JEEMOAHLBKE<TCtx, T> GFIBGNCKPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2E13600", Offset = "0x2E12000", VA = "0x182E13600")]
	private static void PENIMACJIPB<T, TCtx>(LPKDJPNEIBH<T> NKCEKILMAAM, [In] TCtx KKDHCJGLKPO, JEEMOAHLBKE<TCtx, T> GFIBGNCKPGI, int PCNDBEGKGID, int IKOFBMPCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2E08380", Offset = "0x2E06D80", VA = "0x182E08380")]
	private static int EHLKLDMKDIP<T, TCtx>(LPKDJPNEIBH<T> NKCEKILMAAM, [In] TCtx KKDHCJGLKPO, JEEMOAHLBKE<TCtx, T> GFIBGNCKPGI, int PCNDBEGKGID, int IKOFBMPCJDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9210", Offset = "0x2AC7C10", VA = "0x182AC9210")]
	public static LPKDJPNEIBH<T>.AIDHPCPPOMK PBHEMGCNMMA<T>([In] this LPKDJPNEIBH<T> NKCEKILMAAM)
	{
		return default(LPKDJPNEIBH<T>.AIDHPCPPOMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9210", Offset = "0x2AC7C10", VA = "0x182AC9210")]
	public static LPKDJPNEIBH<T>.GJIBCKDPLLH CHEABHDIDKF<T>(this LPKDJPNEIBH<T> NKCEKILMAAM)
	{
		return default(LPKDJPNEIBH<T>.GJIBCKDPLLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2AC9EF0", Offset = "0x2AC88F0", VA = "0x182AC9EF0")]
	public static IBCEBGAEHGH<T, LPKDJPNEIBH<T>.AIDHPCPPOMK> ODOBMAGOMCG<T>([In] this LPKDJPNEIBH<T> NKCEKILMAAM)
	{
		return default(IBCEBGAEHGH<T, LPKDJPNEIBH<T>.AIDHPCPPOMK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class KNKDPOMPHHC
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2E15760", Offset = "0x2E14160", VA = "0x182E15760")]
	public static T[] BPAGCCJKMEP<T>(int ECFPAOHDFEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	public static void IMGAJOAPEEJ<T>(T[] FEMJEOMOEIN)
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
