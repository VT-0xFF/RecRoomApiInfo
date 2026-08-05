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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EBF7C0", Offset = "0x6EBEBC0", VA = "0x186EBF7C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A40", Offset = "0x8D4E40", VA = "0x1808D5A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D5A80", Offset = "0x8D4E80", VA = "0x1808D5A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EHHPPIMBIDK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2BDDE90", Offset = "0x2BDD290", VA = "0x182BDDE90")]
	public static IAPBPCHLGCB<T> LNGMKJOIDAI<T>(this T[] MBGHIKEGJAA) where T : notnull
	{
		return default(IAPBPCHLGCB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class LHFLGNDLMKP<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private GCECACNENLC<T> KECJEOHFKGE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x460BC70", Offset = "0x460B070", VA = "0x18460BC70", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x460BCB0", Offset = "0x460B0B0", VA = "0x18460BCB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x460BA90", Offset = "0x460AE90", VA = "0x18460BA90")]
	public static LHFLGNDLMKP<T> AALKPJMFIHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x40AEF70", Offset = "0x40AE370", VA = "0x1840AEF70")]
	internal LHFLGNDLMKP([In] GCECACNENLC<T> GDIPKBJJCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x460BBD0", Offset = "0x460AFD0", VA = "0x18460BBD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x460BCF0", Offset = "0x460B0F0", VA = "0x18460BCF0")]
	public void PNMAOONOKNG(int MGEMHICLKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x460BC10", Offset = "0x460B010", VA = "0x18460BC10", Slot = "8")]
	public GCECACNENLC<T>.EDBFAJMIGKN GetEnumerator()
	{
		return default(GCECACNENLC<T>.EDBFAJMIGKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x460BD30", Offset = "0x460B130", VA = "0x18460BD30", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x460BD30", Offset = "0x460B130", VA = "0x18460BD30", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct GECMKPLCHAJ<T, U> : IEnumerable<T>, IEnumerable where U : BGHCOJAIBBO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U CAPMOGAGCHH;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x21E9B70", Offset = "0x21E8F70", VA = "0x1821E9B70")]
	internal GECMKPLCHAJ([In] U GFMJPAEEPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3FD6BE0", Offset = "0x3FD5FE0", VA = "0x183FD6BE0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3FD6BE0", Offset = "0x3FD5FE0", VA = "0x183FD6BE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HECJDOKPPBI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC120", Offset = "0x2CEB520", VA = "0x182CEC120")]
	public static GECMKPLCHAJ<T, U> AALKPJMFIHM<U>([In] U MBGHIKEGJAA) where U : BGHCOJAIBBO<T>
	{
		return default(GECMKPLCHAJ<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct MLMOHINLGGP<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U CAPMOGAGCHH;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4848CF0", Offset = "0x48480F0", VA = "0x184848CF0")]
	internal MLMOHINLGGP([In] U GFMJPAEEPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x93EED0", Offset = "0x93E2D0", VA = "0x18093EED0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4848BC0", Offset = "0x4847FC0", VA = "0x184848BC0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4848BC0", Offset = "0x4847FC0", VA = "0x184848BC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class DFLCNPJAOEG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBF70", Offset = "0x2CEB370", VA = "0x182CEBF70")]
	public static MLMOHINLGGP<T, U> AALKPJMFIHM<U>([In] U MBGHIKEGJAA) where U : IEnumerator<T>
	{
		return default(MLMOHINLGGP<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class FCDPMCFMEHF
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2E383C0", Offset = "0x2E377C0", VA = "0x182E383C0")]
	public static string FEKKLLKDDDG<T>(this IEnumerable<T> MBGHIKEGJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2E3EE60", Offset = "0x2E3E260", VA = "0x182E3EE60")]
	public static string NMMOHLEJILG<T>(this IEnumerable<T> MBGHIKEGJAA, string MGABCAGBJJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ECOKFGCMBKA
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9040", Offset = "0x2CA8440", VA = "0x182CA9040")]
	public static bool KNEDELLMLOJ<TSourceEnumerator, TSource>(this TSourceEnumerator MBGHIKEGJAA, [In] TSource BNDEDHKBDGD) where TSourceEnumerator : BGHCOJAIBBO<TSource> where TSource : CLKINMENLCJ<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8EB0", Offset = "0x2CA82B0", VA = "0x182CA8EB0")]
	public static int KDPJHFNMDDD<TSourceEnumerator, TSource>(this TSourceEnumerator MBGHIKEGJAA, [In] TSource LIHHDPOHLDK) where TSourceEnumerator : BGHCOJAIBBO<TSource> where TSource : CLKINMENLCJ<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9290", Offset = "0x2CA8690", VA = "0x182CA9290")]
	public static int LLJPOMBPBBF<TSourceEnumerator, TSource>(this TSourceEnumerator MBGHIKEGJAA, [In] TSource LIHHDPOHLDK) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BGHCOJAIBBO<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T BLKMEFCLAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GPOAAKJPKCC<T> : BGHCOJAIBBO<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct HEFFFHIONID<T, U> : IEnumerable<T>, IEnumerable where U : GPOAAKJPKCC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U CAPMOGAGCHH;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3FD6CF0", Offset = "0x3FD60F0", VA = "0x183FD6CF0")]
	internal HEFFFHIONID([In] U GFMJPAEEPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3C0C910", Offset = "0x3C0BD10", VA = "0x183C0C910", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3FD6C60", Offset = "0x3FD6060", VA = "0x183FD6C60", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3FD6C60", Offset = "0x3FD6060", VA = "0x183FD6C60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GKKGDCGGHDG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBFA0", Offset = "0x2CEB3A0", VA = "0x182CEBFA0")]
	public static HEFFFHIONID<T, U> AALKPJMFIHM<U>([In] U MBGHIKEGJAA) where U : GPOAAKJPKCC<T>
	{
		return default(HEFFFHIONID<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct IAPBPCHLGCB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct GIFHGLJAFIL : BGHCOJAIBBO<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] HLBDLDBAECH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int JKEDFKLHOCP;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T BLKMEFCLAAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3FF4F40", Offset = "0x3FF4340", VA = "0x183FF4F40", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3FF4A00", Offset = "0x3FF3E00", VA = "0x183FF4A00", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x3FF4E40", Offset = "0x3FF4240", VA = "0x183FF4E40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x920710", Offset = "0x91FB10", VA = "0x180920710")]
		private GIFHGLJAFIL(T[] MBGHIKEGJAA, int AEAHMAMPNLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3FF4760", Offset = "0x3FF3B60", VA = "0x183FF4760")]
		public static GIFHGLJAFIL AALKPJMFIHM(T[] MBGHIKEGJAA)
		{
			return default(GIFHGLJAFIL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x222BEF0", Offset = "0x222B2F0", VA = "0x18222BEF0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x222BF60", Offset = "0x222B360", VA = "0x18222BF60", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] BDAECILALMK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int AKNNAFCACJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x415A840", Offset = "0x4159C40", VA = "0x18415A840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2FCD220", Offset = "0x2FCC620", VA = "0x182FCD220")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x93EE00", Offset = "0x93E200", VA = "0x18093EE00")]
	internal IAPBPCHLGCB(T[] AFBDFGIDJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x415A760", Offset = "0x4159B60", VA = "0x18415A760")]
	public static IAPBPCHLGCB<T> NHLFLGLAPGF()
	{
		return default(IAPBPCHLGCB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x93EED0", Offset = "0x93E2D0", VA = "0x18093EED0")]
	public IEnumerable<T> MLPPEEEGAFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x415A500", Offset = "0x4159900", VA = "0x18415A500")]
	public ReadOnlySpan<T> HAOACBKKEKA()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x415A5A0", Offset = "0x41599A0", VA = "0x18415A5A0")]
	public GECMKPLCHAJ<T, IAPBPCHLGCB<T>.GIFHGLJAFIL> MBANPJKJHPN()
	{
		return default(GECMKPLCHAJ<T, GIFHGLJAFIL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x415A460", Offset = "0x4159860", VA = "0x18415A460")]
	public GIFHGLJAFIL GJJLNGCMPEG()
	{
		return default(GIFHGLJAFIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x415A6E0", Offset = "0x4159AE0", VA = "0x18415A6E0")]
	public IEnumerator<T> MKNNDFMGFGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x415A860", Offset = "0x4159C60", VA = "0x18415A860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class AMBOBMNMNPM
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE020", Offset = "0x2BDD420", VA = "0x182BDE020")]
	public static IAPBPCHLGCB<T> PJOLFCJEPEI<T>(params T[] AFBDFGIDJPF) where T : notnull
	{
		return default(IAPBPCHLGCB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6EBF760", Offset = "0x6EBEB60", VA = "0x186EBF760")]
	public static Stream LHHJMKCDDEP(this IAPBPCHLGCB<byte> MBGHIKEGJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(GCECACNENLC<>.JAPICDJMBFC))]
public struct GCECACNENLC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct EDBFAJMIGKN : GPOAAKJPKCC<T>, BGHCOJAIBBO<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] NODOCOGOMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int BKDOEBEJDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int JKEDFKLHOCP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T BLKMEFCLAAD
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3B25910", Offset = "0x3B24D10", VA = "0x183B25910", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T KEABPCKMPFP
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3B25030", Offset = "0x3B24430", VA = "0x183B25030")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T DLCFCPHDGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3B24E80", Offset = "0x3B24280", VA = "0x183B24E80", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3B25330", Offset = "0x3B24730", VA = "0x183B25330", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3B254A0", Offset = "0x3B248A0", VA = "0x183B254A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3B257F0", Offset = "0x3B24BF0", VA = "0x183B257F0")]
		internal EDBFAJMIGKN(T[] AAKOLIDMFPJ, int MGEMHICLKEP, int AEAHMAMPNLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3B24D80", Offset = "0x3B24180", VA = "0x183B24D80")]
		public static EDBFAJMIGKN AALKPJMFIHM(GCECACNENLC<T> MBGHIKEGJAA)
		{
			return default(EDBFAJMIGKN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3B25170", Offset = "0x3B24570", VA = "0x183B25170", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3B25180", Offset = "0x3B24580", VA = "0x183B25180", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct HCINENLFFAK : BGHCOJAIBBO<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EDBFAJMIGKN CAPMOGAGCHH;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T BLKMEFCLAAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x40799C0", Offset = "0x4078DC0", VA = "0x1840799C0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4079720", Offset = "0x4078B20", VA = "0x184079720", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x40798F0", Offset = "0x4078CF0", VA = "0x1840798F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x21E9B70", Offset = "0x21E8F70", VA = "0x1821E9B70")]
		private HCINENLFFAK([In] EDBFAJMIGKN GFMJPAEEPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4079570", Offset = "0x4078970", VA = "0x184079570")]
		public static HCINENLFFAK AALKPJMFIHM([In] GCECACNENLC<T> MBGHIKEGJAA)
		{
			return default(HCINENLFFAK);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4079660", Offset = "0x4078A60", VA = "0x184079660", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x40796A0", Offset = "0x4078AA0", VA = "0x1840796A0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4079620", Offset = "0x4078A20", VA = "0x184079620", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class JAPICDJMBFC
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] NODOCOGOMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int BKDOEBEJDLF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3FD5210", Offset = "0x3FD4610", VA = "0x183FD5210")]
	public static GCECACNENLC<T> AALKPJMFIHM()
	{
		return default(GCECACNENLC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3FD52C0", Offset = "0x3FD46C0", VA = "0x183FD52C0")]
	public static GCECACNENLC<T> DKMBKCJGPHN(int MLLKNBDHHFM)
	{
		return default(GCECACNENLC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x920710", Offset = "0x91FB10", VA = "0x180920710")]
	internal GCECACNENLC(T[] AAKOLIDMFPJ, int MGEMHICLKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3FD5380", Offset = "0x3FD4780", VA = "0x183FD5380", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NNEBNLMFPHH
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int CGKFPHCCPKL<TCtx, T>([In] TCtx NGJELCHDMKO, T GIDMNJLJNOH, T OONEKAPAHLL);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2FD27B0", Offset = "0x2FD1BB0", VA = "0x182FD27B0")]
	public static void LBHGGLOEOHI<T>(this GCECACNENLC<T> MBGHIKEGJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE1D0", Offset = "0x2FCD5D0", VA = "0x182FCE1D0")]
	public static string GOBKOBNCLAH<T>([In] this GCECACNENLC<T> MBGHIKEGJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x93EED0", Offset = "0x93E2D0", VA = "0x18093EED0")]
	public static T[] BDDADONPGAD<T>([In] this GCECACNENLC<T> MBGHIKEGJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2FCD160", Offset = "0x2FCC560", VA = "0x182FCD160")]
	public static T JEMJOLBMCNL<T>([In] this GCECACNENLC<T> MBGHIKEGJAA, int INBIGDGMENB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2FCD220", Offset = "0x2FCC620", VA = "0x182FCD220")]
	public static T ANEANNKPKNP<T>(this GCECACNENLC<T> MBGHIKEGJAA, int INBIGDGMENB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2FCCEA0", Offset = "0x2FCC2A0", VA = "0x182FCCEA0")]
	public static T ACKFEABHMMC<T>([In] this GCECACNENLC<T> MBGHIKEGJAA, int INBIGDGMENB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1D10", Offset = "0x2FD1110", VA = "0x182FD1D10")]
	public static void JOJCHNFNPDL<T>(this GCECACNENLC<T> MBGHIKEGJAA, int INBIGDGMENB, [In] T LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2370", Offset = "0x2FD1770", VA = "0x182FD2370")]
	public static void KELPJKDMLOM<T>(this GCECACNENLC<T> MBGHIKEGJAA, int INBIGDGMENB, T LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x222C340", Offset = "0x222B740", VA = "0x18222C340")]
	public static int FJKKOCDPDGN<T>([In] this GCECACNENLC<T> MBGHIKEGJAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2FD15D0", Offset = "0x2FD09D0", VA = "0x182FD15D0")]
	public static ReadOnlySpan<T> HAOACBKKEKA<T>([In] this GCECACNENLC<T> MBGHIKEGJAA)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1810", Offset = "0x2FD0C10", VA = "0x182FD1810")]
	public static T[] HFDODHOJEHP<T>([In] this GCECACNENLC<T> MBGHIKEGJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2830", Offset = "0x2FD1C30", VA = "0x182FD2830")]
	public static T LJOPDBNCHPH<T>([In] this GCECACNENLC<T> MBGHIKEGJAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2FCD000", Offset = "0x2FCC400", VA = "0x182FCD000")]
	public static T[] ADGBKKMFGHI<T>(this GCECACNENLC<T> MBGHIKEGJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2FCD420", Offset = "0x2FCC820", VA = "0x182FCD420")]
	public static IAPBPCHLGCB<T> EFJKOHAPKLB<T>(this GCECACNENLC<T> MBGHIKEGJAA)
	{
		return default(IAPBPCHLGCB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2FD58A0", Offset = "0x2FD4CA0", VA = "0x182FD58A0")]
	public static void PJLPMKJIOFF<T>(this GCECACNENLC<T> MBGHIKEGJAA, [In] T LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2FD30B0", Offset = "0x2FD24B0", VA = "0x182FD30B0")]
	public static void MBGMCPCEIED<T>(this GCECACNENLC<T> MBGHIKEGJAA, T LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2FD55E0", Offset = "0x2FD49E0", VA = "0x182FD55E0")]
	public static void PCBOFLACPOO<T>(this GCECACNENLC<T> MBGHIKEGJAA, int AEAHMAMPNLO, [In] T LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2FD32F0", Offset = "0x2FD26F0", VA = "0x182FD32F0")]
	public static void MJHIJADDMCD<T>(this GCECACNENLC<T> MBGHIKEGJAA, int AEAHMAMPNLO, T LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2FCD3E0", Offset = "0x2FCC7E0", VA = "0x182FCD3E0")]
	public static void CEOINHKKKPF<T>(this GCECACNENLC<T> MBGHIKEGJAA, int AEAHMAMPNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2FCD380", Offset = "0x2FCC780", VA = "0x182FCD380")]
	public static T BFHOPHPLBID<T>(this GCECACNENLC<T> MBGHIKEGJAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2FD6B20", Offset = "0x2FD5F20", VA = "0x182FD6B20")]
	public static void PNMAOONOKNG<T>(this GCECACNENLC<T> MBGHIKEGJAA, int MGEMHICLKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2FD4140", Offset = "0x2FD3540", VA = "0x182FD4140")]
	private static void OCKFAEMPIBE<T>(this GCECACNENLC<T> MBGHIKEGJAA, int MLLKNBDHHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2FCD550", Offset = "0x2FCC950", VA = "0x182FCD550")]
	public static void FLFDAJFNFLK<T>(this GCECACNENLC<T> MBGHIKEGJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2550", Offset = "0x2FD1950", VA = "0x182FD2550")]
	public static GCECACNENLC<T> KPKMHMCCNAE<T>([In] this GCECACNENLC<T> MBGHIKEGJAA, ANGNGCIMEIB<T, T> MBFCCOKJAPA)
	{
		return default(GCECACNENLC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2F10", Offset = "0x2FD2310", VA = "0x182FD2F10")]
	public static bool MAHJHHAHNPL<T>(this GCECACNENLC<T> MBGHIKEGJAA, T LIHHDPOHLDK) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2FD34A0", Offset = "0x2FD28A0", VA = "0x182FD34A0")]
	public static bool NIEFBGJGHIF<T>(this GCECACNENLC<T> MBGHIKEGJAA, [In] T LIHHDPOHLDK) where T : CLKINMENLCJ<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2C885F0", Offset = "0x2C879F0", VA = "0x182C885F0")]
	public static bool IMHJEBACLHE<T>([In] this GCECACNENLC<T> MBGHIKEGJAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2FCD4F0", Offset = "0x2FCC8F0", VA = "0x182FCD4F0")]
	public static bool FLBDNJGHFMI<T>([In] this GCECACNENLC<T> MBGHIKEGJAA, int INBIGDGMENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2FD3450", Offset = "0x2FD2850", VA = "0x182FD3450")]
	public static void MPLAEHGKNHL<T, TCtx>(this GCECACNENLC<T> MBGHIKEGJAA, [In] TCtx NGJELCHDMKO, CGKFPHCCPKL<TCtx, T> IHEDPMNJJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2FD1940", Offset = "0x2FD0D40", VA = "0x182FD1940")]
	private static void IPPFMHABMFI<T, TCtx>(GCECACNENLC<T> MBGHIKEGJAA, [In] TCtx NGJELCHDMKO, CGKFPHCCPKL<TCtx, T> IHEDPMNJJJA, int JCCCNIEHMDH, int JCIDKKPKGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2FD2870", Offset = "0x2FD1C70", VA = "0x182FD2870")]
	private static int LPBECOBJHFJ<T, TCtx>(GCECACNENLC<T> MBGHIKEGJAA, [In] TCtx NGJELCHDMKO, CGKFPHCCPKL<TCtx, T> IHEDPMNJJJA, int JCCCNIEHMDH, int JCIDKKPKGHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE080", Offset = "0x2BDD480", VA = "0x182BDE080")]
	public static GCECACNENLC<T>.HCINENLFFAK MKNNDFMGFGD<T>([In] this GCECACNENLC<T> MBGHIKEGJAA)
	{
		return default(GCECACNENLC<T>.HCINENLFFAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE080", Offset = "0x2BDD480", VA = "0x182BDE080")]
	public static GCECACNENLC<T>.EDBFAJMIGKN IKPNJOPDPNB<T>(this GCECACNENLC<T> MBGHIKEGJAA)
	{
		return default(GCECACNENLC<T>.EDBFAJMIGKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2BDDDC0", Offset = "0x2BDD1C0", VA = "0x182BDDDC0")]
	public static GECMKPLCHAJ<T, GCECACNENLC<T>.HCINENLFFAK> DBBMOCOEJJF<T>([In] this GCECACNENLC<T> MBGHIKEGJAA)
	{
		return default(GECMKPLCHAJ<T, GCECACNENLC<T>.HCINENLFFAK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class MDKOKKBDCMA
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2F52D20", Offset = "0x2F52120", VA = "0x182F52D20")]
	public static T[] EBGBIFACIAE<T>(int MFKKELONDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	public static void KOEDDKIFBAI<T>(T[] AFBDFGIDJPF)
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
