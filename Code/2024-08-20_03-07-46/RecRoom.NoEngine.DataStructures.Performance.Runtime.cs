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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A4A290", Offset = "0x6A49290", VA = "0x186A4A290")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87C700", Offset = "0x87B700", VA = "0x18087C700")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C740", Offset = "0x87B740", VA = "0x18087C740")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CJHGHAEBDFE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28987B0", Offset = "0x28977B0", VA = "0x1828987B0")]
	public static LCPFLDCEIMC<T> PBHJFKDIKJK<T>(this T[] KALCJEIICGB) where T : notnull
	{
		return default(LCPFLDCEIMC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class BCJHPMBDHCE<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private PPKMBIHDAAO<T> HKOHEKBCCKM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4E739D0", Offset = "0x4E729D0", VA = "0x184E739D0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4E73780", Offset = "0x4E72780", VA = "0x184E73780")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4E73800", Offset = "0x4E72800", VA = "0x184E73800")]
	public static BCJHPMBDHCE<T> GAKCNKPJGEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x411B3D0", Offset = "0x411A3D0", VA = "0x18411B3D0")]
	internal BCJHPMBDHCE([In] PPKMBIHDAAO<T> OEFGKJLECGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4E737C0", Offset = "0x4E727C0", VA = "0x184E737C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4E73990", Offset = "0x4E72990", VA = "0x184E73990")]
	public void IIFJFHBDPHK(int DOPPKGNLPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4E73930", Offset = "0x4E72930", VA = "0x184E73930", Slot = "8")]
	public PPKMBIHDAAO<T>.JINGLAINPJK GetEnumerator()
	{
		return default(PPKMBIHDAAO<T>.JINGLAINPJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4E73A10", Offset = "0x4E72A10", VA = "0x184E73A10", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4E73A10", Offset = "0x4E72A10", VA = "0x184E73A10", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct AOCEDDGHNPE<T, U> : IEnumerable<T>, IEnumerable where U : FOENOIDGJJF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U CONNOEDJHFM;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FCAF60", Offset = "0x1FC9F60", VA = "0x181FCAF60")]
	internal AOCEDDGHNPE([In] U FONGOFJDDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3DE63A0", Offset = "0x3DE53A0", VA = "0x183DE63A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3DE63A0", Offset = "0x3DE53A0", VA = "0x183DE63A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GCCDFDDACHA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2EA0", Offset = "0x2AE1EA0", VA = "0x182AE2EA0")]
	public static AOCEDDGHNPE<T, U> GAKCNKPJGEK<U>([In] U KALCJEIICGB) where U : FOENOIDGJJF<T>
	{
		return default(AOCEDDGHNPE<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct HLFHEBCGJHL<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U CONNOEDJHFM;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3DE6810", Offset = "0x3DE5810", VA = "0x183DE6810")]
	internal HLFHEBCGJHL([In] U FONGOFJDDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xB50CF0", Offset = "0xB4FCF0", VA = "0x180B50CF0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3DE64D0", Offset = "0x3DE54D0", VA = "0x183DE64D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3DE64D0", Offset = "0x3DE54D0", VA = "0x183DE64D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MFLIMNGPCFF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFC70", Offset = "0x2AEEC70", VA = "0x182AEFC70")]
	public static HLFHEBCGJHL<T, U> GAKCNKPJGEK<U>([In] U KALCJEIICGB) where U : IEnumerator<T>
	{
		return default(HLFHEBCGJHL<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class OELPBEAOPNF
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2D3E8F0", Offset = "0x2D3D8F0", VA = "0x182D3E8F0")]
	public static string HOFLLNPLJCP<T>(this IEnumerable<T> KALCJEIICGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2D43750", Offset = "0x2D42750", VA = "0x182D43750")]
	public static string IHAMPJEBCFK<T>(this IEnumerable<T> KALCJEIICGB, string JNBIHOCKMBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CGIMOBLEANF
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2996900", Offset = "0x2995900", VA = "0x182996900")]
	public static bool LHOELCPMKFD<TSourceEnumerator, TSource>(this TSourceEnumerator KALCJEIICGB, [In] TSource LLGHCONMHCJ) where TSourceEnumerator : FOENOIDGJJF<TSource> where TSource : GCBAFALFAIH<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2996B50", Offset = "0x2995B50", VA = "0x182996B50")]
	public static int OHFPNOCOMFK<TSourceEnumerator, TSource>(this TSourceEnumerator KALCJEIICGB, [In] TSource JJCEIJMGOAB) where TSourceEnumerator : FOENOIDGJJF<TSource> where TSource : GCBAFALFAIH<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x29966F0", Offset = "0x29956F0", VA = "0x1829966F0")]
	public static int IBDDPOPOAPI<TSourceEnumerator, TSource>(this TSourceEnumerator KALCJEIICGB, [In] TSource JJCEIJMGOAB) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FOENOIDGJJF<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T NIGOAHBKKGN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FBMLLBAAEEC<T> : FOENOIDGJJF<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct LBJOHFMPLKC<T, U> : IEnumerable<T>, IEnumerable where U : FBMLLBAAEEC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U CONNOEDJHFM;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3DE67F0", Offset = "0x3DE57F0", VA = "0x183DE67F0")]
	internal LBJOHFMPLKC([In] U FONGOFJDDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x394CC30", Offset = "0x394BC30", VA = "0x18394CC30", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3DE65E0", Offset = "0x3DE55E0", VA = "0x183DE65E0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3DE65E0", Offset = "0x3DE55E0", VA = "0x183DE65E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NOBAGBCPOID<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2E70", Offset = "0x2AE1E70", VA = "0x182AE2E70")]
	public static LBJOHFMPLKC<T, U> GAKCNKPJGEK<U>([In] U KALCJEIICGB) where U : FBMLLBAAEEC<T>
	{
		return default(LBJOHFMPLKC<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct LCPFLDCEIMC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct PCOGNGLIKEK : FOENOIDGJJF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] EIKELCFIBHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int KIBIMPIGGMO;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T NIGOAHBKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4795380", Offset = "0x4794380", VA = "0x184795380", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4794F60", Offset = "0x4793F60", VA = "0x184794F60", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x47950F0", Offset = "0x47940F0", VA = "0x1847950F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1BD6240", Offset = "0x1BD5240", VA = "0x181BD6240")]
		private PCOGNGLIKEK(T[] KALCJEIICGB, int HCALFJOJKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4794D90", Offset = "0x4793D90", VA = "0x184794D90")]
		public static PCOGNGLIKEK GAKCNKPJGEK(T[] KALCJEIICGB)
		{
			return default(PCOGNGLIKEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2002E30", Offset = "0x2001E30", VA = "0x182002E30", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2002E60", Offset = "0x2001E60", VA = "0x182002E60", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] BFEICOGJDKL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NLCDAFOIEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x41FBA30", Offset = "0x41FAA30", VA = "0x1841FBA30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2B97FB0", Offset = "0x2B96FB0", VA = "0x182B97FB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA111F0", Offset = "0xA101F0", VA = "0x180A111F0")]
	internal LCPFLDCEIMC(T[] IKONNGGNFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x42DA010", Offset = "0x42D9010", VA = "0x1842DA010")]
	public static LCPFLDCEIMC<T> MEMMBNOMLFC()
	{
		return default(LCPFLDCEIMC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
	public IEnumerable<T> IAPHEFDBIOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x42D9F70", Offset = "0x42D8F70", VA = "0x1842D9F70")]
	public ReadOnlySpan<T> IGBJLECCOBF()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x42D9DA0", Offset = "0x42D8DA0", VA = "0x1842D9DA0")]
	public AOCEDDGHNPE<T, LCPFLDCEIMC<T>.PCOGNGLIKEK> EKNKMAEDFAC()
	{
		return default(AOCEDDGHNPE<T, PCOGNGLIKEK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x42D9ED0", Offset = "0x42D8ED0", VA = "0x1842D9ED0")]
	public PCOGNGLIKEK HFKNCPAHLHO()
	{
		return default(PCOGNGLIKEK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x42D9D20", Offset = "0x42D8D20", VA = "0x1842D9D20")]
	public IEnumerator<T> EAJKDCOBAGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x42DA0E0", Offset = "0x42D90E0", VA = "0x1842DA0E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GEFBBOLCILF
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2992900", Offset = "0x2991900", VA = "0x182992900")]
	public static LCPFLDCEIMC<T> FJHFMHKCBOK<T>(params T[] IKONNGGNFPH) where T : notnull
	{
		return default(LCPFLDCEIMC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A4A230", Offset = "0x6A49230", VA = "0x186A4A230")]
	public static Stream BOPNOIHOAHI(this LCPFLDCEIMC<byte> KALCJEIICGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(PPKMBIHDAAO<>.CGKJEIBGIIL))]
public struct PPKMBIHDAAO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct JINGLAINPJK : FBMLLBAAEEC<T>, FOENOIDGJJF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] CBJGDKAKAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int PKHGICHHEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int KIBIMPIGGMO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T NIGOAHBKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4112180", Offset = "0x4111180", VA = "0x184112180", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T HOLHJEFDKIA
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x41117D0", Offset = "0x41107D0", VA = "0x1841117D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T FCGLPLBDBOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x4111920", Offset = "0x4110920", VA = "0x184111920", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x4111C90", Offset = "0x4110C90", VA = "0x184111C90", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4112070", Offset = "0x4111070", VA = "0x184112070", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4112100", Offset = "0x4111100", VA = "0x184112100")]
		internal JINGLAINPJK(T[] AFNCAAOMPCK, int DOPPKGNLPAC, int HCALFJOJKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4111A60", Offset = "0x4110A60", VA = "0x184111A60")]
		public static JINGLAINPJK GAKCNKPJGEK(PPKMBIHDAAO<T> KALCJEIICGB)
		{
			return default(JINGLAINPJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3908B00", Offset = "0x3907B00", VA = "0x183908B00", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3903340", Offset = "0x3902340", VA = "0x183903340", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct MNFMDFENAFG : FOENOIDGJJF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JINGLAINPJK CONNOEDJHFM;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T NIGOAHBKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4504B80", Offset = "0x4503B80", VA = "0x184504B80", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x45048E0", Offset = "0x45038E0", VA = "0x1845048E0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4504A80", Offset = "0x4503A80", VA = "0x184504A80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAF60", Offset = "0x1FC9F60", VA = "0x181FCAF60")]
		private MNFMDFENAFG([In] JINGLAINPJK FONGOFJDDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4504770", Offset = "0x4503770", VA = "0x184504770")]
		public static MNFMDFENAFG GAKCNKPJGEK([In] PPKMBIHDAAO<T> KALCJEIICGB)
		{
			return default(MNFMDFENAFG);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4504820", Offset = "0x4503820", VA = "0x184504820", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4504860", Offset = "0x4503860", VA = "0x184504860", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4504730", Offset = "0x4503730", VA = "0x184504730", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class CGKJEIBGIIL
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] CBJGDKAKAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int PKHGICHHEFJ;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x47CE0E0", Offset = "0x47CD0E0", VA = "0x1847CE0E0")]
	public static PPKMBIHDAAO<T> GAKCNKPJGEK()
	{
		return default(PPKMBIHDAAO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x47CE020", Offset = "0x47CD020", VA = "0x1847CE020")]
	public static PPKMBIHDAAO<T> EJCJEECAIDA(int BPIECAEAGAJ)
	{
		return default(PPKMBIHDAAO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1BD6240", Offset = "0x1BD5240", VA = "0x181BD6240")]
	internal PPKMBIHDAAO(T[] AFNCAAOMPCK, int DOPPKGNLPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x47CE190", Offset = "0x47CD190", VA = "0x1847CE190", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FCMLAINDBBO
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int AKEOKJJAHGJ<TCtx, T>([In] TCtx IBLIIOCCPPC, T PNODNPKGJKB, T JHNJJGDAEGF);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2B91A80", Offset = "0x2B90A80", VA = "0x182B91A80")]
	public static void CANECBKHGDE<T>(this PPKMBIHDAAO<T> KALCJEIICGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2B98E40", Offset = "0x2B97E40", VA = "0x182B98E40")]
	public static string MDNJKFLLDAC<T>([In] this PPKMBIHDAAO<T> KALCJEIICGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870")]
	public static T[] MGLDDADCNHL<T>([In] this PPKMBIHDAAO<T> KALCJEIICGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B97FB0", Offset = "0x2B96FB0", VA = "0x182B97FB0")]
	public static T MKHPGHPCCLG<T>([In] this PPKMBIHDAAO<T> KALCJEIICGB, int GGJGGMKAJPM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2B97FB0", Offset = "0x2B96FB0", VA = "0x182B97FB0")]
	public static T LJMLCJIBFEC<T>(this PPKMBIHDAAO<T> KALCJEIICGB, int GGJGGMKAJPM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2B91BA0", Offset = "0x2B90BA0", VA = "0x182B91BA0")]
	public static T DAFJCJOMPDE<T>([In] this PPKMBIHDAAO<T> KALCJEIICGB, int GGJGGMKAJPM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2B94B00", Offset = "0x2B93B00", VA = "0x182B94B00")]
	public static void HACKMLKKHNE<T>(this PPKMBIHDAAO<T> KALCJEIICGB, int GGJGGMKAJPM, [In] T JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2B97740", Offset = "0x2B96740", VA = "0x182B97740")]
	public static void JCFKBNKCCKN<T>(this PPKMBIHDAAO<T> KALCJEIICGB, int GGJGGMKAJPM, T JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2032730", Offset = "0x2031730", VA = "0x182032730")]
	public static int FPHCKJNODAL<T>([In] this PPKMBIHDAAO<T> KALCJEIICGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2B950C0", Offset = "0x2B940C0", VA = "0x182B950C0")]
	public static ReadOnlySpan<T> IGBJLECCOBF<T>([In] this PPKMBIHDAAO<T> KALCJEIICGB)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2B9C0E0", Offset = "0x2B9B0E0", VA = "0x182B9C0E0")]
	public static T[] MHDMAMHADBM<T>([In] this PPKMBIHDAAO<T> KALCJEIICGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2B94A10", Offset = "0x2B93A10", VA = "0x182B94A10")]
	public static T GNOLDIBCGJP<T>([In] this PPKMBIHDAAO<T> KALCJEIICGB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2B92110", Offset = "0x2B91110", VA = "0x182B92110")]
	public static T[] EBNDMHKBNNN<T>(this PPKMBIHDAAO<T> KALCJEIICGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2B919B0", Offset = "0x2B909B0", VA = "0x182B919B0")]
	public static LCPFLDCEIMC<T> AGGFAIGCCBO<T>(this PPKMBIHDAAO<T> KALCJEIICGB)
	{
		return default(LCPFLDCEIMC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2B944E0", Offset = "0x2B934E0", VA = "0x182B944E0")]
	public static void GKAGDNHKNII<T>(this PPKMBIHDAAO<T> KALCJEIICGB, [In] T JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2B97B00", Offset = "0x2B96B00", VA = "0x182B97B00")]
	public static void LBBLNKNBLEN<T>(this PPKMBIHDAAO<T> KALCJEIICGB, T JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2B97D40", Offset = "0x2B96D40", VA = "0x182B97D40")]
	public static void LIHBHDHNEGP<T>(this PPKMBIHDAAO<T> KALCJEIICGB, int HCALFJOJKJO, [In] T JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B91D70", Offset = "0x2B90D70", VA = "0x182B91D70")]
	public static void DFPGAOHDGNH<T>(this PPKMBIHDAAO<T> KALCJEIICGB, int HCALFJOJKJO, T JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B92350", Offset = "0x2B91350", VA = "0x182B92350")]
	public static void FPMFBAADEOI<T>(this PPKMBIHDAAO<T> KALCJEIICGB, int HCALFJOJKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2B91B40", Offset = "0x2B90B40", VA = "0x182B91B40")]
	public static T DAFFNILNGFK<T>(this PPKMBIHDAAO<T> KALCJEIICGB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2B95550", Offset = "0x2B94550", VA = "0x182B95550")]
	public static void IIFJFHBDPHK<T>(this PPKMBIHDAAO<T> KALCJEIICGB, int DOPPKGNLPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2B92520", Offset = "0x2B91520", VA = "0x182B92520")]
	private static void GHBAHHNHKAK<T>(this PPKMBIHDAAO<T> KALCJEIICGB, int BPIECAEAGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2B9C410", Offset = "0x2B9B410", VA = "0x182B9C410")]
	public static void PKAGCAPLLKG<T>(this PPKMBIHDAAO<T> KALCJEIICGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2B91EC0", Offset = "0x2B90EC0", VA = "0x182B91EC0")]
	public static PPKMBIHDAAO<T> DMJCFLNALOI<T>([In] this PPKMBIHDAAO<T> KALCJEIICGB, MMJMDEJBDJN<T, T> ALGODNHMEDB)
	{
		return default(PPKMBIHDAAO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2B921B0", Offset = "0x2B911B0", VA = "0x182B921B0")]
	public static bool FFDBNDOHLIO<T>(this PPKMBIHDAAO<T> KALCJEIICGB, T JJCEIJMGOAB) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2B9C350", Offset = "0x2B9B350", VA = "0x182B9C350")]
	public static bool NJOIFKHEKIA<T>(this PPKMBIHDAAO<T> KALCJEIICGB, [In] T JJCEIJMGOAB) where T : GCBAFALFAIH<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2B950B0", Offset = "0x2B940B0", VA = "0x182B950B0")]
	public static bool HALEFOFGOBN<T>([In] this PPKMBIHDAAO<T> KALCJEIICGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2B981E0", Offset = "0x2B971E0", VA = "0x182B981E0")]
	public static bool LMGCAIKCKLK<T>([In] this PPKMBIHDAAO<T> KALCJEIICGB, int GGJGGMKAJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2B9C590", Offset = "0x2B9B590", VA = "0x182B9C590")]
	public static void PNOPJLEKKCF<T, TCtx>(this PPKMBIHDAAO<T> KALCJEIICGB, [In] TCtx IBLIIOCCPPC, AKEOKJJAHGJ<TCtx, T> HFCANJKFLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2B97A00", Offset = "0x2B96A00", VA = "0x182B97A00")]
	private static void KGEGMIEDIPN<T, TCtx>(PPKMBIHDAAO<T> KALCJEIICGB, [In] TCtx IBLIIOCCPPC, AKEOKJJAHGJ<TCtx, T> HFCANJKFLBL, int BEELCOFILPE, int DPGIDMJLLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2B98230", Offset = "0x2B97230", VA = "0x182B98230")]
	private static int MAHJIGCGNML<T, TCtx>(PPKMBIHDAAO<T> KALCJEIICGB, [In] TCtx IBLIIOCCPPC, AKEOKJJAHGJ<TCtx, T> HFCANJKFLBL, int BEELCOFILPE, int DPGIDMJLLBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2B91B00", Offset = "0x2B90B00", VA = "0x182B91B00")]
	public static PPKMBIHDAAO<T>.MNFMDFENAFG EAJKDCOBAGF<T>([In] this PPKMBIHDAAO<T> KALCJEIICGB)
	{
		return default(PPKMBIHDAAO<T>.MNFMDFENAFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2B91B00", Offset = "0x2B90B00", VA = "0x182B91B00")]
	public static PPKMBIHDAAO<T>.JINGLAINPJK CDPINCIOBHL<T>(this PPKMBIHDAAO<T> KALCJEIICGB)
	{
		return default(PPKMBIHDAAO<T>.JINGLAINPJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x299B930", Offset = "0x299A930", VA = "0x18299B930")]
	public static AOCEDDGHNPE<T, PPKMBIHDAAO<T>.MNFMDFENAFG> PEJNKELKNJC<T>([In] this PPKMBIHDAAO<T> KALCJEIICGB)
	{
		return default(AOCEDDGHNPE<T, PPKMBIHDAAO<T>.MNFMDFENAFG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class BLLIBOJOGLA
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x292D960", Offset = "0x292C960", VA = "0x18292D960")]
	public static T[] KDPOFANCAME<T>(int GHACOABIHDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	public static void DFDLPGHALKA<T>(T[] IKONNGGNFPH)
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
