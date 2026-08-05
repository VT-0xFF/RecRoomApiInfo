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
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D1B930", Offset = "0x5D1A130", VA = "0x185D1B930")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C320", Offset = "0x78AB20", VA = "0x18078C320")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C360", Offset = "0x78AB60", VA = "0x18078C360")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FJGDOIDLCGH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x235C730", Offset = "0x235AF30", VA = "0x18235C730")]
	public static HBMICOIANPF<T> APDCJKDHNKH<T>(this T[] CLEGCKJMIEA) where T : notnull
	{
		return default(HBMICOIANPF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class DJBJAGFABDH<T> : IDisposable, FLIDBCAJLCE, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FCBHONBGPIO<T> KCPCDEJOIMO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4CD81A0", Offset = "0x4CD69A0", VA = "0x184CD81A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4CD8170", Offset = "0x4CD6970", VA = "0x184CD8170")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4CD8380", Offset = "0x4CD6B80", VA = "0x184CD8380")]
	public static DJBJAGFABDH<T> MJLGMKKAMEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4CD8210", Offset = "0x4CD6A10", VA = "0x184CD8210")]
	public static DJBJAGFABDH<T> FGIGOCCAJPD(int OLEHEDGFINF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3DA7220", Offset = "0x3DA5A20", VA = "0x183DA7220")]
	internal DJBJAGFABDH([In] FCBHONBGPIO<T> HJDEGHPGGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4CD81D0", Offset = "0x4CD69D0", VA = "0x184CD81D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4CD81F0", Offset = "0x4CD69F0", VA = "0x184CD81F0")]
	public void EIGFNHEIDIC([In] T IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4CD8150", Offset = "0x4CD6950", VA = "0x184CD8150")]
	public void AGMCHCJOJPH(int JEDNJDDHFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4CD8330", Offset = "0x4CD6B30", VA = "0x184CD8330", Slot = "8")]
	public FCBHONBGPIO<T>.HCHMNMGCLAB GetEnumerator()
	{
		return default(FCBHONBGPIO<T>.HCHMNMGCLAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4CD84A0", Offset = "0x4CD6CA0", VA = "0x184CD84A0", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4CD84A0", Offset = "0x4CD6CA0", VA = "0x184CD84A0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct JFEBPEDKHBJ<T, U> : IEnumerable<T>, IEnumerable where U : LCMKCHHNKPD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U KBLLNAEKHOP;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1C11170", Offset = "0x1C0F970", VA = "0x181C11170")]
	internal JFEBPEDKHBJ([In] U AGGHFLICNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x33B4970", Offset = "0x33B3170", VA = "0x1833B4970", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x33B4970", Offset = "0x33B3170", VA = "0x1833B4970", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PJNCJOJNBML<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x22C25E0", Offset = "0x22C0DE0", VA = "0x1822C25E0")]
	public static JFEBPEDKHBJ<T, U> MJLGMKKAMEE<U>([In] U CLEGCKJMIEA) where U : LCMKCHHNKPD<T>
	{
		return default(JFEBPEDKHBJ<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct MLNBKIHFDOB<TSourceEnumerator, TSource, TResult> : FLIDBCAJLCE, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : FLIDBCAJLCE, LCMKCHHNKPD<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private TSourceEnumerator AFELCOAHKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly AIDDIEFFMPL<TSource, TResult> NGCDJAMDFOB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x388BC20", Offset = "0x388A420", VA = "0x18388BC20", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public readonly TResult IODFMFKEHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3BD1150", Offset = "0x3BCF950", VA = "0x183BD1150", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0E20", Offset = "0x3BCF620", VA = "0x183BD0E20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x388BFB0", Offset = "0x388A7B0", VA = "0x18388BFB0")]
	internal MLNBKIHFDOB([In] TSourceEnumerator CLEGCKJMIEA, AIDDIEFFMPL<TSource, TResult> OFJANJJHHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x388BCF0", Offset = "0x388A4F0", VA = "0x18388BCF0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x388BE40", Offset = "0x388A640", VA = "0x18388BE40", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x388BC60", Offset = "0x388A460", VA = "0x18388BC60", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct HHGPHJJOKIN<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly U KBLLNAEKHOP;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1EFAC20", Offset = "0x1EF9420", VA = "0x181EFAC20")]
	internal HHGPHJJOKIN([In] U AGGHFLICNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7800", Offset = "0x1EF6000", VA = "0x181EF7800", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3537500", Offset = "0x3535D00", VA = "0x183537500", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3537500", Offset = "0x3535D00", VA = "0x183537500", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class MCPCLHPEBGJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x216F6E0", Offset = "0x216DEE0", VA = "0x18216F6E0")]
	public static HHGPHJJOKIN<T, U> MJLGMKKAMEE<U>([In] U CLEGCKJMIEA) where U : IEnumerator<T>
	{
		return default(HHGPHJJOKIN<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KCBAFDCIAJG<TSourceEnumerator, TSource, TResult> : FLIDBCAJLCE, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : FLIDBCAJLCE, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private TSourceEnumerator AFELCOAHKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<TSource, TResult> NGCDJAMDFOB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public readonly int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x388BC20", Offset = "0x388A420", VA = "0x18388BC20", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly TResult IODFMFKEHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x388BFF0", Offset = "0x388A7F0", VA = "0x18388BFF0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x388BEC0", Offset = "0x388A6C0", VA = "0x18388BEC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x388BFB0", Offset = "0x388A7B0", VA = "0x18388BFB0")]
	internal KCBAFDCIAJG([In] TSourceEnumerator CLEGCKJMIEA, Func<TSource, TResult> OFJANJJHHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x388BCF0", Offset = "0x388A4F0", VA = "0x18388BCF0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x388BE40", Offset = "0x388A640", VA = "0x18388BE40", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x388BC60", Offset = "0x388A460", VA = "0x18388BC60", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class APFOACOPPJB
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x29C89F0", Offset = "0x29C71F0", VA = "0x1829C89F0")]
	public static string CLMEAAOBOPE<T>(this IEnumerable<T> CLEGCKJMIEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x29CB3E0", Offset = "0x29C9BE0", VA = "0x1829CB3E0")]
	public static string HMDDGKIELGB<T>(this IEnumerable<T> CLEGCKJMIEA, string BMNFINFMHHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FAOOPGCFNJH
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x235D660", Offset = "0x235BE60", VA = "0x18235D660")]
	public static bool LNLODDFBDDF<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator CLEGCKJMIEA, [In] TArgs DDNMEJONMEK, [In] EPDNMLDMKDJ<TArgs, TSource, bool> JNCEMOGOADA) where TSourceEnumerator : LCMKCHHNKPD<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x235D460", Offset = "0x235BC60", VA = "0x18235D460")]
	public static int BNGLBFPEMGB<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator CLEGCKJMIEA, [In] TArgs DDNMEJONMEK, EPDNMLDMKDJ<TArgs, TSource, bool> JNCEMOGOADA) where TSourceEnumerator : LCMKCHHNKPD<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x235D7F0", Offset = "0x235BFF0", VA = "0x18235D7F0")]
	public static bool POCGLLBKPEI<TSourceEnumerator, TSource>(this TSourceEnumerator CLEGCKJMIEA, [In] TSource AKPEBFBEHGM) where TSourceEnumerator : LCMKCHHNKPD<TSource> where TSource : LKPADMBBDIC<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x235D200", Offset = "0x235BA00", VA = "0x18235D200")]
	public static int AJAJFNPCBLA<TSourceEnumerator, TSource>(this TSourceEnumerator CLEGCKJMIEA, [In] TSource IFKKLLBODIE) where TSourceEnumerator : LCMKCHHNKPD<TSource> where TSource : LKPADMBBDIC<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x235D600", Offset = "0x235BE00", VA = "0x18235D600")]
	public static MLNBKIHFDOB<TSourceEnumerator, TSource, TResult> JEDENCAHMID<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator CLEGCKJMIEA, AIDDIEFFMPL<TSource, TResult> OFJANJJHHBL) where TSourceEnumerator : FLIDBCAJLCE, LCMKCHHNKPD<TSource>
	{
		return default(MLNBKIHFDOB<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x235D600", Offset = "0x235BE00", VA = "0x18235D600")]
	public static KCBAFDCIAJG<TSourceEnumerator, TSource, TResult> CPBHMNAMDPI<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator CLEGCKJMIEA, Func<TSource, TResult> OFJANJJHHBL) where TSourceEnumerator : FLIDBCAJLCE, IEnumerator<TSource>
	{
		return default(KCBAFDCIAJG<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PEENALLGDLM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x22B67E0", Offset = "0x22B4FE0", VA = "0x1822B67E0")]
	public static bool OBKCNOJOBNF<TSourceEnumerator>(TSourceEnumerator CLEGCKJMIEA) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x22B66B0", Offset = "0x22B4EB0", VA = "0x1822B66B0")]
	public static T LNFFMGCLILO<TSourceEnumerator>(TSourceEnumerator CLEGCKJMIEA) where TSourceEnumerator : LCMKCHHNKPD<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x22B3600", Offset = "0x22B1E00", VA = "0x1822B3600")]
	public static T[] BHHEEDBAGDL<TSourceEnumerator>(TSourceEnumerator CLEGCKJMIEA) where TSourceEnumerator : FLIDBCAJLCE, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x22B65B0", Offset = "0x22B4DB0", VA = "0x1822B65B0")]
	public static T CIEJLLABGGG<TSourceEnumerator>(TSourceEnumerator CLEGCKJMIEA) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LCMKCHHNKPD<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T IODFMFKEHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FLIDBCAJLCE
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CDICHAEECJK<T> : LCMKCHHNKPD<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct FMEKBJEGODJ<T, U> : IEnumerable<T>, IEnumerable where U : CDICHAEECJK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly U KBLLNAEKHOP;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x33B4A20", Offset = "0x33B3220", VA = "0x1833B4A20")]
	internal FMEKBJEGODJ([In] U AGGHFLICNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x30C3230", Offset = "0x30C1A30", VA = "0x1830C3230", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x33B48E0", Offset = "0x33B30E0", VA = "0x1833B48E0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x33B48E0", Offset = "0x33B30E0", VA = "0x1833B48E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GCCCDLBFOMJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2BF44F0", Offset = "0x2BF2CF0", VA = "0x182BF44F0")]
	public static FMEKBJEGODJ<T, U> MJLGMKKAMEE<U>([In] U CLEGCKJMIEA) where U : CDICHAEECJK<T>
	{
		return default(FMEKBJEGODJ<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public readonly struct HBMICOIANPF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct GNODAHNEAKC : FLIDBCAJLCE, LCMKCHHNKPD<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] AFELCOAHKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int AMHLDCKKKED;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly int EAAIJEAHMOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1C353A0", Offset = "0x1C33BA0", VA = "0x181C353A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T IODFMFKEHHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x34C9460", Offset = "0x34C7C60", VA = "0x1834C9460", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x34C8D40", Offset = "0x34C7540", VA = "0x1834C8D40", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x34C9230", Offset = "0x34C7A30", VA = "0x1834C9230", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x165B6D0", Offset = "0x1659ED0", VA = "0x18165B6D0")]
		private GNODAHNEAKC(T[] CLEGCKJMIEA, int ADMJKDLHPCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x34C8CF0", Offset = "0x34C74F0", VA = "0x1834C8CF0")]
		public static GNODAHNEAKC MJLGMKKAMEE(T[] CLEGCKJMIEA)
		{
			return default(GNODAHNEAKC);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1C353F0", Offset = "0x1C33BF0", VA = "0x181C353F0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1C35460", Offset = "0x1C33C60", VA = "0x181C35460", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly T[] BCDOJMIPBGO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FPGKKKADJDC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1C353A0", Offset = "0x1C33BA0", VA = "0x181C353A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x23AF920", Offset = "0x23AE120", VA = "0x1823AF920")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED8C0", Offset = "0x7EC0C0", VA = "0x1807ED8C0")]
	internal HBMICOIANPF(T[] JMHHCKCLFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3510DF0", Offset = "0x350F5F0", VA = "0x183510DF0")]
	public static HBMICOIANPF<T> FNKJEGINCPG()
	{
		return default(HBMICOIANPF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
	public IEnumerable<T> JIHNADOFINM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3510EB0", Offset = "0x350F6B0", VA = "0x183510EB0")]
	public ReadOnlySpan<T> LPGDMKPMBOF()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3510CD0", Offset = "0x350F4D0", VA = "0x183510CD0")]
	public JFEBPEDKHBJ<T, HBMICOIANPF<T>.GNODAHNEAKC> FFDCEKLGGCA()
	{
		return default(JFEBPEDKHBJ<T, GNODAHNEAKC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3510F40", Offset = "0x350F740", VA = "0x183510F40")]
	public GNODAHNEAKC LPMJKLGINCI()
	{
		return default(GNODAHNEAKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3510FD0", Offset = "0x350F7D0", VA = "0x183510FD0")]
	public IEnumerator<T> NNHLEKOBGNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3511050", Offset = "0x350F850", VA = "0x183511050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class AELAICAIBPE
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2380890", Offset = "0x237F090", VA = "0x182380890")]
	public static HBMICOIANPF<T> ALLDMEFOMMC<T>(params T[] JMHHCKCLFBI) where T : notnull
	{
		return default(HBMICOIANPF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B8D0", Offset = "0x5D1A0D0", VA = "0x185D1B8D0")]
	public static Stream CBINKLBLOED(this HBMICOIANPF<byte> CLEGCKJMIEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DebuggerTypeProxy(typeof(FCBHONBGPIO<>.MBEPEMHGJBG))]
public struct FCBHONBGPIO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct HCHMNMGCLAB : FLIDBCAJLCE, CDICHAEECJK<T>, LCMKCHHNKPD<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly T[] HIJJANCBMEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int MLGPOEJPGPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int AMHLDCKKKED;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly int EAAIJEAHMOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x1C47F70", Offset = "0x1C46770", VA = "0x181C47F70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public readonly T IODFMFKEHHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x35167B0", Offset = "0x3514FB0", VA = "0x1835167B0", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private readonly T HJNKALIDOJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3516060", Offset = "0x3514860", VA = "0x183516060", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3516160", Offset = "0x3514960", VA = "0x183516160", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x35164D0", Offset = "0x3514CD0", VA = "0x1835164D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3516770", Offset = "0x3514F70", VA = "0x183516770")]
		internal HCHMNMGCLAB(T[] GBFGDEFHEJO, int JEDNJDDHFHB, int ADMJKDLHPCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x35160B0", Offset = "0x35148B0", VA = "0x1835160B0")]
		public static HCHMNMGCLAB MJLGMKKAMEE(FCBHONBGPIO<T> CLEGCKJMIEA)
		{
			return default(HCHMNMGCLAB);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x308D530", Offset = "0x308BD30", VA = "0x18308D530", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x30862E0", Offset = "0x3084AE0", VA = "0x1830862E0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct BDBEAPFBOMK : FLIDBCAJLCE, LCMKCHHNKPD<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private HCHMNMGCLAB KBLLNAEKHOP;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int EAAIJEAHMOH
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x45B5860", Offset = "0x45B4060", VA = "0x1845B5860", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public readonly T IODFMFKEHHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x45B5DC0", Offset = "0x45B45C0", VA = "0x1845B5DC0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x45B5A00", Offset = "0x45B4200", VA = "0x1845B5A00", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x45B5C90", Offset = "0x45B4490", VA = "0x1845B5C90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1C11170", Offset = "0x1C0F970", VA = "0x181C11170")]
		private BDBEAPFBOMK([In] HCHMNMGCLAB AGGHFLICNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x45B58D0", Offset = "0x45B40D0", VA = "0x1845B58D0")]
		public static BDBEAPFBOMK MJLGMKKAMEE([In] FCBHONBGPIO<T> CLEGCKJMIEA)
		{
			return default(BDBEAPFBOMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x45B5980", Offset = "0x45B4180", VA = "0x1845B5980", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x45B59C0", Offset = "0x45B41C0", VA = "0x1845B59C0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x45B5890", Offset = "0x45B4090", VA = "0x1845B5890", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class MBEPEMHGJBG
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal T[] HIJJANCBMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal int MLGPOEJPGPO;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x33744A0", Offset = "0x3372CA0", VA = "0x1833744A0")]
	public static FCBHONBGPIO<T> MJLGMKKAMEE()
	{
		return default(FCBHONBGPIO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3374390", Offset = "0x3372B90", VA = "0x183374390")]
	public static FCBHONBGPIO<T> FGIGOCCAJPD(int OLEHEDGFINF)
	{
		return default(FCBHONBGPIO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x165B6D0", Offset = "0x1659ED0", VA = "0x18165B6D0")]
	internal FCBHONBGPIO(T[] GBFGDEFHEJO, int JEDNJDDHFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x33745B0", Offset = "0x3372DB0", VA = "0x1833745B0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HIJDPDDINMK
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x23B3A50", Offset = "0x23B2250", VA = "0x1823B3A50")]
	public static void LJGAFCKKELL<T>(this FCBHONBGPIO<T> CLEGCKJMIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x23B1F80", Offset = "0x23B0780", VA = "0x1823B1F80")]
	public static string LBNCFCAMMCJ<T>([In] this FCBHONBGPIO<T> CLEGCKJMIEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
	public static T[] JOFDACHOOOK<T>([In] this FCBHONBGPIO<T> CLEGCKJMIEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x23AF780", Offset = "0x23ADF80", VA = "0x1823AF780")]
	public static T BCFBOGKIONB<T>([In] this FCBHONBGPIO<T> CLEGCKJMIEA, int PBGHCEIGALN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x23AF820", Offset = "0x23AE020", VA = "0x1823AF820")]
	public static T NNKBANGMBFH<T>(this FCBHONBGPIO<T> CLEGCKJMIEA, int PBGHCEIGALN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x23B3BC0", Offset = "0x23B23C0", VA = "0x1823B3BC0")]
	public static T MDJHCCEPLNL<T>([In] this FCBHONBGPIO<T> CLEGCKJMIEA, int PBGHCEIGALN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x23ADFB0", Offset = "0x23AC7B0", VA = "0x1823ADFB0")]
	public static void ABNCEPDOIJI<T>(this FCBHONBGPIO<T> CLEGCKJMIEA, int PBGHCEIGALN, [In] T IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x23AFE00", Offset = "0x23AE600", VA = "0x1823AFE00")]
	public static void EJJFAALBHKD<T>(this FCBHONBGPIO<T> CLEGCKJMIEA, int PBGHCEIGALN, T IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1C47F70", Offset = "0x1C46770", VA = "0x181C47F70")]
	public static int DCMEDKPDILC<T>([In] this FCBHONBGPIO<T> CLEGCKJMIEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x23B3AF0", Offset = "0x23B22F0", VA = "0x1823B3AF0")]
	public static ReadOnlySpan<T> LPGDMKPMBOF<T>([In] this FCBHONBGPIO<T> CLEGCKJMIEA)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x23AF9D0", Offset = "0x23AE1D0", VA = "0x1823AF9D0")]
	public static void EIGFNHEIDIC<T>(this FCBHONBGPIO<T> CLEGCKJMIEA, [In] T IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x23B3E40", Offset = "0x23B2640", VA = "0x1823B3E40")]
	public static void PKOOMGJPBIH<T>(this FCBHONBGPIO<T> CLEGCKJMIEA, int ADMJKDLHPCI, [In] T IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x23ADEA0", Offset = "0x23AC6A0", VA = "0x1823ADEA0")]
	public static void AANLEJDLNLP<T>(this FCBHONBGPIO<T> CLEGCKJMIEA, int ADMJKDLHPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x23B3C20", Offset = "0x23B2420", VA = "0x1823B3C20")]
	public static T NIBJFHKMKKD<T>(this FCBHONBGPIO<T> CLEGCKJMIEA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x23AE760", Offset = "0x23ACF60", VA = "0x1823AE760")]
	public static void AGMCHCJOJPH<T>(this FCBHONBGPIO<T> CLEGCKJMIEA, int JEDNJDDHFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x23B00B0", Offset = "0x23AE8B0", VA = "0x1823B00B0")]
	private static void ELKGHAJCJNA<T>(this FCBHONBGPIO<T> CLEGCKJMIEA, int OLEHEDGFINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x23B3CC0", Offset = "0x23B24C0", VA = "0x1823B3CC0")]
	public static void PAMPKEGOCOB<T>(this FCBHONBGPIO<T> CLEGCKJMIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x23AE420", Offset = "0x23ACC20", VA = "0x1823AE420")]
	public static bool ADGGEEBEIFB<T>(this FCBHONBGPIO<T> CLEGCKJMIEA, [In] T IFKKLLBODIE) where T : LKPADMBBDIC<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x23B4020", Offset = "0x23B2820", VA = "0x1823B4020")]
	public static bool PLFIBBCFHEC<T>([In] this FCBHONBGPIO<T> CLEGCKJMIEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x23B1F40", Offset = "0x23B0740", VA = "0x1823B1F40")]
	public static bool GFHFFBPEFDJ<T>([In] this FCBHONBGPIO<T> CLEGCKJMIEA, int PBGHCEIGALN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x237DA70", Offset = "0x237C270", VA = "0x18237DA70")]
	public static FCBHONBGPIO<T>.BDBEAPFBOMK NNHLEKOBGNG<T>([In] this FCBHONBGPIO<T> CLEGCKJMIEA)
	{
		return default(FCBHONBGPIO<T>.BDBEAPFBOMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x237DA70", Offset = "0x237C270", VA = "0x18237DA70")]
	public static FCBHONBGPIO<T>.HCHMNMGCLAB KLHJJOJDIDH<T>(this FCBHONBGPIO<T> CLEGCKJMIEA)
	{
		return default(FCBHONBGPIO<T>.HCHMNMGCLAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x23800E0", Offset = "0x237E8E0", VA = "0x1823800E0")]
	public static JFEBPEDKHBJ<T, FCBHONBGPIO<T>.BDBEAPFBOMK> CHEJJEIPCOB<T>([In] this FCBHONBGPIO<T> CLEGCKJMIEA)
	{
		return default(JFEBPEDKHBJ<T, FCBHONBGPIO<T>.BDBEAPFBOMK>);
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
