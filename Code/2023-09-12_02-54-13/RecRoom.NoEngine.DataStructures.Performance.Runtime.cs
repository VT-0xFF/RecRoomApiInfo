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
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
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
		[Cpp2IlInjected.Address(RVA = "0x7236660", Offset = "0x7235A60", VA = "0x187236660")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF70", Offset = "0xA6E370", VA = "0x180A6EF70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6EFA0", Offset = "0xA6E3A0", VA = "0x180A6EFA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GIPDECCECJK<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	T AOPJILKHAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class CNDJFEHACNH
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2181050", Offset = "0x2180450", VA = "0x182181050")]
	public static string MGKPGKGCLAF<T>(this IEnumerable<T> ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x21CFC80", Offset = "0x21CF080", VA = "0x1821CFC80")]
	public static string AAGOKHINHFC<T>(this IEnumerable<T> ODBHDBFBMOB, string NNPECCGBFOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct HOIOJMDJKKB<T, U> : IEnumerable<T>, IEnumerable where U : DNGJADCPDGO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly U JHFAJAFIOJD;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2D246C0", Offset = "0x2D23AC0", VA = "0x182D246C0")]
	internal HOIOJMDJKKB(in U OMJENHBNMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x176B970", Offset = "0x176AD70", VA = "0x18176B970", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2D24630", Offset = "0x2D23A30", VA = "0x182D24630", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2D24630", Offset = "0x2D23A30", VA = "0x182D24630", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CCCPMDGEGBP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2149DE0", Offset = "0x21491E0", VA = "0x182149DE0")]
	public static HOIOJMDJKKB<T, U> NAILOIKCJEC<U>(in U ODBHDBFBMOB) where U : DNGJADCPDGO<T>
	{
		return default(HOIOJMDJKKB<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DJCKKFHPDGA
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F930", Offset = "0x2C7ED30", VA = "0x182C7F930")]
	public static bool PHHENAJPGJK<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator ODBHDBFBMOB, in TArgs AIEGNLJMEEC, in NFPKPCDNHMM<TArgs, TSource, bool> BHNAOANJFML) where TSourceEnumerator : GIPDECCECJK<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F2A0", Offset = "0x2C7E6A0", VA = "0x182C7F2A0")]
	public static int FLDIDEOADIM<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator ODBHDBFBMOB, in TArgs AIEGNLJMEEC, NFPKPCDNHMM<TArgs, TSource, bool> BHNAOANJFML) where TSourceEnumerator : GIPDECCECJK<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F550", Offset = "0x2C7E950", VA = "0x182C7F550")]
	public static bool FPCEDKBFGKA<TSourceEnumerator, TSource>(this TSourceEnumerator ODBHDBFBMOB, in TSource CFHFBNLLHPN) where TSourceEnumerator : GIPDECCECJK<TSource> where TSource : GMDIBMAAGEJ<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2C7EF50", Offset = "0x2C7E350", VA = "0x182C7EF50")]
	public static int ABECGLFOKCP<TSourceEnumerator, TSource>(this TSourceEnumerator ODBHDBFBMOB, in TSource AGLCIEKHLEE) where TSourceEnumerator : GIPDECCECJK<TSource> where TSource : GMDIBMAAGEJ<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F8A0", Offset = "0x2C7ECA0", VA = "0x182C7F8A0")]
	public static NODOECFBPMA<TSourceEnumerator, TSource, TResult> HKNLPKIFBBI<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator ODBHDBFBMOB, IEIGBGICOAC<TSource, TResult> CAHELJOKEPJ) where TSourceEnumerator : GLNNLNPJLMK, GIPDECCECJK<TSource>
	{
		return default(NODOECFBPMA<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F8A0", Offset = "0x2C7ECA0", VA = "0x182C7F8A0")]
	public static PDAPBMAEDHK<TSourceEnumerator, TSource, TResult> NJFCLAGJIGF<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator ODBHDBFBMOB, Func<TSource, TResult> CAHELJOKEPJ) where TSourceEnumerator : GLNNLNPJLMK, IEnumerator<TSource>
	{
		return default(PDAPBMAEDHK<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class PLLEMJLPHOA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1BC65B0", Offset = "0x1BC59B0", VA = "0x181BC65B0")]
	public static bool FJOOICDOBAD<TSourceEnumerator>(TSourceEnumerator ODBHDBFBMOB) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1BD3360", Offset = "0x1BD2760", VA = "0x181BD3360")]
	public static T NMABIIGDCKG<TSourceEnumerator>(TSourceEnumerator ODBHDBFBMOB) where TSourceEnumerator : GIPDECCECJK<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1BC66C0", Offset = "0x1BC5AC0", VA = "0x181BC66C0")]
	public static T[] JJGFFFKOHCP<TSourceEnumerator>(TSourceEnumerator ODBHDBFBMOB) where TSourceEnumerator : GLNNLNPJLMK, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1BD3120", Offset = "0x1BD2520", VA = "0x181BD3120")]
	public static T MAMANMKPIIJ<TSourceEnumerator>(TSourceEnumerator ODBHDBFBMOB) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct HGKNOJOPDDL<T, U> : IEnumerable<T>, IEnumerable where U : GIPDECCECJK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U JHFAJAFIOJD;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA9C0", Offset = "0x1FD9DC0", VA = "0x181FDA9C0")]
	internal HGKNOJOPDDL(in U OMJENHBNMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xB335E0", Offset = "0xB329E0", VA = "0x180B335E0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x207B970", Offset = "0x207AD70", VA = "0x18207B970", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x207B970", Offset = "0x207AD70", VA = "0x18207B970", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HPCEAAEBBBC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x201E020", Offset = "0x201D420", VA = "0x18201E020")]
	public static HGKNOJOPDDL<T, U> NAILOIKCJEC<U>(in U ODBHDBFBMOB) where U : GIPDECCECJK<T>
	{
		return default(HGKNOJOPDDL<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DefaultMember("Item")]
public readonly struct IFCCPDFCEMF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct HPIKMKKFECI : GLNNLNPJLMK, GIPDECCECJK<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly T[] ILHFFOJAJOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int JNIKNLFJDCD;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public readonly int HIBMACOFNKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x15D75C0", Offset = "0x15D69C0", VA = "0x1815D75C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public readonly T AOPJILKHAOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2D24E70", Offset = "0x2D24270", VA = "0x182D24E70", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2D24830", Offset = "0x2D23C30", VA = "0x182D24830", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2D249F0", Offset = "0x2D23DF0", VA = "0x182D249F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xE965A0", Offset = "0xE959A0", VA = "0x180E965A0")]
		private HPIKMKKFECI(T[] ODBHDBFBMOB, int BNOAGGNAMKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2D24710", Offset = "0x2D23B10", VA = "0x182D24710")]
		public static HPIKMKKFECI NAILOIKCJEC(T[] ODBHDBFBMOB)
		{
			return default(HPIKMKKFECI);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2D246E0", Offset = "0x2D23AE0", VA = "0x182D246E0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2D24760", Offset = "0x2D23B60", VA = "0x182D24760", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly T[] IIMEOCCLFJA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NMCJNDHCAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x15D75C0", Offset = "0x15D69C0", VA = "0x1815D75C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x15D7500", Offset = "0x15D6900", VA = "0x1815D7500")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8BE820", Offset = "0x8BDC20", VA = "0x1808BE820")]
	internal IFCCPDFCEMF(T[] EACKPMFPNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x15D7300", Offset = "0x15D6700", VA = "0x1815D7300")]
	public static IFCCPDFCEMF<T> AOKDNNAFLGL()
	{
		return default(IFCCPDFCEMF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x81F0A0", Offset = "0x81E4A0", VA = "0x18081F0A0")]
	public IEnumerable<T> AFGJJMJHIMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x15D75E0", Offset = "0x15D69E0", VA = "0x1815D75E0")]
	public ReadOnlySpan<T> IFBBIEHMMIK()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x15D7670", Offset = "0x15D6A70", VA = "0x1815D7670")]
	public HGKNOJOPDDL<T, IFCCPDFCEMF<T>.HPIKMKKFECI> KDGBEAPLPMD()
	{
		return default(HGKNOJOPDDL<T, HPIKMKKFECI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x15D73B0", Offset = "0x15D67B0", VA = "0x1815D73B0")]
	public HPIKMKKFECI CIDKFDLPIEL()
	{
		return default(HPIKMKKFECI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x15D7790", Offset = "0x15D6B90", VA = "0x1815D7790")]
	public IEnumerator<T> MHIEAIINAGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x15D7810", Offset = "0x15D6C10", VA = "0x1815D7810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KMEKNPFPOGK
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1BD35E0", Offset = "0x1BD29E0", VA = "0x181BD35E0")]
	public static IFCCPDFCEMF<T> JIEMPMNKCHE<T>(params T[] EACKPMFPNLH) where T : notnull
	{
		return default(IFCCPDFCEMF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7236600", Offset = "0x7235A00", VA = "0x187236600")]
	public static Stream AOAANEONGDA(this IFCCPDFCEMF<byte> ODBHDBFBMOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GLNNLNPJLMK
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct DJGIMJFLEPO<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly U JHFAJAFIOJD;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x21E5D60", Offset = "0x21E5160", VA = "0x1821E5D60")]
	internal DJGIMJFLEPO(in U OMJENHBNMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x21E5C60", Offset = "0x21E5060", VA = "0x1821E5C60", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x21E5C60", Offset = "0x21E5060", VA = "0x1821E5C60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DMNBENKKENK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x214B230", Offset = "0x214A630", VA = "0x18214B230")]
	public static DJGIMJFLEPO<T, U> NAILOIKCJEC<U>(in U ODBHDBFBMOB) where U : IEnumerator<T>
	{
		return default(DJGIMJFLEPO<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public sealed class FCDEMPOJDCA<T> : IDisposable, GLNNLNPJLMK, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HDPAEJBGGIM<T> DCNHHFINCHE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x30E0DF0", Offset = "0x30E01F0", VA = "0x1830E0DF0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x30E0D90", Offset = "0x30E0190", VA = "0x1830E0D90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x30E0E10", Offset = "0x30E0210", VA = "0x1830E0E10")]
	public static FCDEMPOJDCA<T> NAILOIKCJEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x30E0C50", Offset = "0x30E0050", VA = "0x1830E0C50")]
	public static FCDEMPOJDCA<T> DECHHDFNHCL(int GLDHDJHPIPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2060C10", Offset = "0x2060010", VA = "0x182060C10")]
	internal FCDEMPOJDCA(in HDPAEJBGGIM<T> JGNMLMMCBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x30E0D70", Offset = "0x30E0170", VA = "0x1830E0D70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x30E0F20", Offset = "0x30E0320", VA = "0x1830E0F20")]
	public void NNFBEGDMHOD(in T AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x30E0F40", Offset = "0x30E0340", VA = "0x1830E0F40")]
	public void OCCKMJDDIKK(int FJFMKNIHPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x30E0DB0", Offset = "0x30E01B0", VA = "0x1830E0DB0", Slot = "8")]
	public HDPAEJBGGIM<T>.JGIAAOLNJIN GetEnumerator()
	{
		return default(HDPAEJBGGIM<T>.JGIAAOLNJIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x30E0F60", Offset = "0x30E0360", VA = "0x1830E0F60", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x30E0F60", Offset = "0x30E0360", VA = "0x1830E0F60", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(HDPAEJBGGIM<>.EAFNBOKHIFG))]
public struct HDPAEJBGGIM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct JGIAAOLNJIN : GLNNLNPJLMK, DNGJADCPDGO<T>, GIPDECCECJK<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] OIMNHIDODFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int AFAJDIPMOBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int JNIKNLFJDCD;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly int HIBMACOFNKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x176BB40", Offset = "0x176AF40", VA = "0x18176BB40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public readonly T AOPJILKHAOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2BA3F60", Offset = "0x2BA3360", VA = "0x182BA3F60", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private readonly T NEPOEMCKHAF
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x2BA2BE0", Offset = "0x2BA1FE0", VA = "0x182BA2BE0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x2BA2F80", Offset = "0x2BA2380", VA = "0x182BA2F80", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x2BA3AB0", Offset = "0x2BA2EB0", VA = "0x182BA3AB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1D307B0", Offset = "0x1D2FBB0", VA = "0x181D307B0")]
		internal JGIAAOLNJIN(T[] LEJDAGMDLDH, int FJFMKNIHPDJ, int BNOAGGNAMKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2F20", Offset = "0x2BA2320", VA = "0x182BA2F20")]
		public static JGIAAOLNJIN NAILOIKCJEC(ref HDPAEJBGGIM<T> ODBHDBFBMOB)
		{
			return default(JGIAAOLNJIN);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x287A3F0", Offset = "0x28797F0", VA = "0x18287A3F0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x28799B0", Offset = "0x2878DB0", VA = "0x1828799B0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct KJGNINBJADK : GLNNLNPJLMK, GIPDECCECJK<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JGIAAOLNJIN JHFAJAFIOJD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int HIBMACOFNKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3730090", Offset = "0x372F490", VA = "0x183730090", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly T AOPJILKHAOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x3B91560", Offset = "0x3B90960", VA = "0x183B91560", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x3B91340", Offset = "0x3B90740", VA = "0x183B91340", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x3B91430", Offset = "0x3B90830", VA = "0x183B91430", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA9C0", Offset = "0x1FD9DC0", VA = "0x181FDA9C0")]
		private KJGNINBJADK(in JGIAAOLNJIN OMJENHBNMFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3730100", Offset = "0x372F500", VA = "0x183730100")]
		public static KJGNINBJADK NAILOIKCJEC(in HDPAEJBGGIM<T> ODBHDBFBMOB)
		{
			return default(KJGNINBJADK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x37300C0", Offset = "0x372F4C0", VA = "0x1837300C0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x37301C0", Offset = "0x372F5C0", VA = "0x1837301C0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3730050", Offset = "0x372F450", VA = "0x183730050", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class EAFNBOKHIFG
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] OIMNHIDODFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int AFAJDIPMOBJ;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2077F50", Offset = "0x2077350", VA = "0x182077F50")]
	public static HDPAEJBGGIM<T> NAILOIKCJEC()
	{
		return default(HDPAEJBGGIM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2077E70", Offset = "0x2077270", VA = "0x182077E70")]
	public static HDPAEJBGGIM<T> DECHHDFNHCL(int GLDHDJHPIPL)
	{
		return default(HDPAEJBGGIM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xE965A0", Offset = "0xE959A0", VA = "0x180E965A0")]
	internal HDPAEJBGGIM(T[] LEJDAGMDLDH, int FJFMKNIHPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x137FEC0", Offset = "0x137F2C0", VA = "0x18137FEC0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class HGAAEBLAMKE
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x243B8B0", Offset = "0x243ACB0", VA = "0x18243B8B0")]
	public static void EHKLIGBABLK<T>(this ref HDPAEJBGGIM<T> ODBHDBFBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x243C160", Offset = "0x243B560", VA = "0x18243C160")]
	public static string FOAJEDKHCCI<T>(this in HDPAEJBGGIM<T> ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x81F0A0", Offset = "0x81E4A0", VA = "0x18081F0A0")]
	public static T[] HCIAHOLACBE<T>(this in HDPAEJBGGIM<T> ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x243B770", Offset = "0x243AB70", VA = "0x18243B770")]
	public static T PHGLOPEHIMO<T>(this in HDPAEJBGGIM<T> ODBHDBFBMOB, int APEMPONKPBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x243B770", Offset = "0x243AB70", VA = "0x18243B770")]
	public static T CKGLFOOKOMF<T>(this ref HDPAEJBGGIM<T> ODBHDBFBMOB, int APEMPONKPBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2441280", Offset = "0x2440680", VA = "0x182441280")]
	public static T NEMCODJKKOA<T>(this in HDPAEJBGGIM<T> ODBHDBFBMOB, int APEMPONKPBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x243B290", Offset = "0x243A690", VA = "0x18243B290")]
	public static void AFLFAPDAOKF<T>(this ref HDPAEJBGGIM<T> ODBHDBFBMOB, int APEMPONKPBB, in T AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x24411F0", Offset = "0x24405F0", VA = "0x1824411F0")]
	public static void MKIJIHPEEPO<T>(this ref HDPAEJBGGIM<T> ODBHDBFBMOB, int APEMPONKPBB, T AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x176BB40", Offset = "0x176AF40", VA = "0x18176BB40")]
	public static int EMBDFMAIHCN<T>(this in HDPAEJBGGIM<T> ODBHDBFBMOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x243E740", Offset = "0x243DB40", VA = "0x18243E740")]
	public static ReadOnlySpan<T> IFBBIEHMMIK<T>(this in HDPAEJBGGIM<T> ODBHDBFBMOB)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2441530", Offset = "0x2440930", VA = "0x182441530")]
	public static void NNFBEGDMHOD<T>(this ref HDPAEJBGGIM<T> ODBHDBFBMOB, in T AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2444AC0", Offset = "0x2443EC0", VA = "0x182444AC0")]
	public static void ONBMGKENJDO<T>(this ref HDPAEJBGGIM<T> ODBHDBFBMOB, int BNOAGGNAMKG, in T AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x243B670", Offset = "0x243AA70", VA = "0x18243B670")]
	public static void CBBHEGILAAP<T>(this ref HDPAEJBGGIM<T> ODBHDBFBMOB, int BNOAGGNAMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2441170", Offset = "0x2440570", VA = "0x182441170")]
	public static T JDCENIBCDKB<T>(this ref HDPAEJBGGIM<T> ODBHDBFBMOB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2441F70", Offset = "0x2441370", VA = "0x182441F70")]
	public static void OCCKMJDDIKK<T>(this ref HDPAEJBGGIM<T> ODBHDBFBMOB, int FJFMKNIHPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2443570", Offset = "0x2442970", VA = "0x182443570")]
	private static void OHLHHAEDNOA<T>(this ref HDPAEJBGGIM<T> ODBHDBFBMOB, int GLDHDJHPIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2444C80", Offset = "0x2444080", VA = "0x182444C80")]
	public static void PDPMCCCKLBI<T>(this ref HDPAEJBGGIM<T> ODBHDBFBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x243D3F0", Offset = "0x243C7F0", VA = "0x18243D3F0")]
	public static bool HLPIBOMBCOL<T>(this ref HDPAEJBGGIM<T> ODBHDBFBMOB, in T AGLCIEKHLEE) where T : GMDIBMAAGEJ<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x224AE70", Offset = "0x224A270", VA = "0x18224AE70")]
	public static bool JJHNMLEHLGB<T>(this in HDPAEJBGGIM<T> ODBHDBFBMOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x243B0D0", Offset = "0x243A4D0", VA = "0x18243B0D0")]
	public static bool AAPDOOHMNIH<T>(this in HDPAEJBGGIM<T> ODBHDBFBMOB, int APEMPONKPBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1022380", Offset = "0x1021780", VA = "0x181022380")]
	public static HDPAEJBGGIM<T>.KJGNINBJADK MHIEAIINAGJ<T>(this in HDPAEJBGGIM<T> ODBHDBFBMOB)
	{
		return default(HDPAEJBGGIM<T>.KJGNINBJADK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1022380", Offset = "0x1021780", VA = "0x181022380")]
	public static HDPAEJBGGIM<T>.JGIAAOLNJIN CGJLFBPDJID<T>(this ref HDPAEJBGGIM<T> ODBHDBFBMOB)
	{
		return default(HDPAEJBGGIM<T>.JGIAAOLNJIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1022310", Offset = "0x1021710", VA = "0x181022310")]
	public static HGKNOJOPDDL<T, HDPAEJBGGIM<T>.KJGNINBJADK> AJAGIPGHNCG<T>(this in HDPAEJBGGIM<T> ODBHDBFBMOB)
	{
		return default(HGKNOJOPDDL<T, HDPAEJBGGIM<T>.KJGNINBJADK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NODOECFBPMA<TSourceEnumerator, TSource, TResult> : GLNNLNPJLMK, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : GLNNLNPJLMK, GIPDECCECJK<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private TSourceEnumerator ILHFFOJAJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IEIGBGICOAC<TSource, TResult> GFFEGJJPKCE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public readonly int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2D88BB0", Offset = "0x2D87FB0", VA = "0x182D88BB0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public readonly TResult AOPJILKHAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2D894C0", Offset = "0x2D888C0", VA = "0x182D894C0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2D89290", Offset = "0x2D88690", VA = "0x182D89290", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x176AF90", Offset = "0x176A390", VA = "0x18176AF90")]
	internal NODOECFBPMA(in TSourceEnumerator ODBHDBFBMOB, IEIGBGICOAC<TSource, TResult> CAHELJOKEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2D88EB0", Offset = "0x2D882B0", VA = "0x182D88EB0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2D89060", Offset = "0x2D88460", VA = "0x182D89060", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2D88A40", Offset = "0x2D87E40", VA = "0x182D88A40", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct PDAPBMAEDHK<TSourceEnumerator, TSource, TResult> : GLNNLNPJLMK, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : GLNNLNPJLMK, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private TSourceEnumerator ILHFFOJAJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Func<TSource, TResult> GFFEGJJPKCE;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public readonly int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x34EF1C0", Offset = "0x34EE5C0", VA = "0x1834EF1C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public readonly TResult AOPJILKHAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2D89310", Offset = "0x2D88710", VA = "0x182D89310", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2D89190", Offset = "0x2D88590", VA = "0x182D89190", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x176AF90", Offset = "0x176A390", VA = "0x18176AF90")]
	internal PDAPBMAEDHK(in TSourceEnumerator ODBHDBFBMOB, Func<TSource, TResult> CAHELJOKEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x34EF360", Offset = "0x34EE760", VA = "0x1834EF360", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x34EF480", Offset = "0x34EE880", VA = "0x1834EF480", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x34EF0F0", Offset = "0x34EE4F0", VA = "0x1834EF0F0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface DNGJADCPDGO<T> : GIPDECCECJK<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class OOGHPKIBINE
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x10242F0", Offset = "0x10236F0", VA = "0x1810242F0")]
	public static IFCCPDFCEMF<T> MEJEBEOJOKL<T>(this T[] ODBHDBFBMOB) where T : notnull
	{
		return default(IFCCPDFCEMF<T>);
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
