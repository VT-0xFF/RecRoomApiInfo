using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Mathematics;
using UnityEngine;

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
		[Cpp2IlInjected.Address(RVA = "0x6A3E300", Offset = "0x6A3D300", VA = "0x186A3E300")]
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
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
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
public static class JLJJBMIIEEE
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string[] GDAIKOLPJEM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C2A0", Offset = "0x6A3B2A0", VA = "0x186A3C2A0")]
	public static bool EBDBPBFMIKP(string AIJJEPIHFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C4C0", Offset = "0x6A3B4C0", VA = "0x186A3C4C0")]
	private static bool LMIAOPNIPIH(string KKHEHGHPOAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C370", Offset = "0x6A3B370", VA = "0x186A3C370")]
	public static bool LMIAOPNIPIH(Exception KOABFHNGJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BF70", Offset = "0x6A3AF70", VA = "0x186A3BF70")]
	public static string BOGPPKCAFLF(string AFJFNKAODGK, string BOJMPDAJCJP = "", bool AJAELNJLKKM = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FOBMKDJBCEC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AA70", Offset = "0x6A39A70", VA = "0x186A3AA70")]
	public static string NMPPNIEBHOJ(this Guid CNIMPJMOLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A9D0", Offset = "0x6A399D0", VA = "0x186A3A9D0")]
	public static string NMPPNIEBHOJ(this byte[] KABOAHAAMFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A910", Offset = "0x6A39910", VA = "0x186A3A910")]
	public static byte[] NIHCJPILHON(string OGAOKIGHCGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HBEHIBEHCHP
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int DOBMHAPIKFM<T>([In] T PNODNPKGJKB, [In] T JHNJJGDAEGF);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class GEAJJAMOKJO<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct AJIGAOHCOCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly int EFHNBALPFBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public readonly int IFCLFELEKNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public readonly bool PIKFCOHBAOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int EBGADBHMKAD;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x3D21DE0", Offset = "0x3D20DE0", VA = "0x183D21DE0")]
			public AJIGAOHCOCG(int EFHNBALPFBO, int IFCLFELEKNI, bool PIKFCOHBAOI)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly T[] FADJGGFOLEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly T[] PJGLKNLIADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly DOBMHAPIKFM<T> INGGACOLKBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly int JIMAHPDLBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Func<bool> MBNPLEPLGFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int CHHIOBDMPGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly AJIGAOHCOCG[] OIPKAFOFNBI;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D574E0", Offset = "0x3D564E0", VA = "0x183D574E0")]
		public GEAJJAMOKJO(T[] FADJGGFOLEI, DOBMHAPIKFM<T> INGGACOLKBC, int JIMAHPDLBBN, Func<bool> MBNPLEPLGFL, T[]? INPHBDGPIGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D56EB0", Offset = "0x3D55EB0", VA = "0x183D56EB0")]
		public bool JHNIIHPMLOK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate U MMDFLBNDNHC<T, U>(int KNDPBIKNLIE, int CALKGMPOPLI, [In] ReadOnlySpan<T> MLHHFHHDGCD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2BBFCF0", Offset = "0x2BBECF0", VA = "0x182BBFCF0")]
	public static T[] MCJNKLMIGDM<T>(int GHACOABIHDA, T EBAOBPNGOEJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF1D0", Offset = "0x2BBE1D0", VA = "0x182BBF1D0")]
	public static void HAPKKIDKMEJ<T>(this T[] LMGOFNHBFDF, T EBAOBPNGOEJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE4D0", Offset = "0x2BBD4D0", VA = "0x182BBE4D0")]
	public static void CJOPKADNOGH<T>(this T[] IKONNGGNFPH, int GGJGGMKAJPM, int FPDNGBHJHEK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2BBEE20", Offset = "0x2BBDE20", VA = "0x182BBEE20")]
	private static void COOGHHMCMJC<T>(this T[] KALCJEIICGB, int ENAPMCKIEKC, int PEFKNOMEFEJ, T[] ACBLPNJDJBF, int BLCKFBEAFFG, int OLKNBBBPPPF, T[] KNFGDDANCCK, int PJGACLDKDCN, DOBMHAPIKFM<T> INGGACOLKBC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF6F0", Offset = "0x2BBE6F0", VA = "0x182BBF6F0")]
	public static void JJAFPDCCICJ<T>(this T[] KALCJEIICGB, int EFHNBALPFBO, int DOPPKGNLPAC, DOBMHAPIKFM<T> INGGACOLKBC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2BBFC30", Offset = "0x2BBEC30", VA = "0x182BBFC30")]
	public static GEAJJAMOKJO<T> LIJCEKFGNIN<T>(this T[] KALCJEIICGB, DOBMHAPIKFM<T> INGGACOLKBC, int JIMAHPDLBBN, Func<bool> MBNPLEPLGFL, [Optional] T[]? INPHBDGPIGJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0480", Offset = "0x2BBF480", VA = "0x182BC0480")]
	public static T[] OJOOIBEDFDL<T>(this T[] IKONNGGNFPH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2BBFAF0", Offset = "0x2BBEAF0", VA = "0x182BBFAF0")]
	public static T[] KIHKFNJLCHN<T>(this T[] BOHBHCBACKC, T FMDONHBMCIJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE550", Offset = "0x2BBD550", VA = "0x182BBE550")]
	public static T[] CNKPLFAEPAB<T>(this T[] BOHBHCBACKC, int HCALFJOJKJO, T FMDONHBMCIJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF3A0", Offset = "0x2BBE3A0", VA = "0x182BBF3A0")]
	public static T[] HDDODLFOJEE<T>(this T[] BOHBHCBACKC, int HCALFJOJKJO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF450", Offset = "0x2BBE450", VA = "0x182BBF450")]
	public static T[] HMCPDOBECFA<T>(this T[] BOHBHCBACKC, int HCALFJOJKJO, T FMDONHBMCIJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2BBFE90", Offset = "0x2BBEE90", VA = "0x182BBFE90")]
	public static U[] OGICACGNLAD<U, T>(this T[] AFNCAAOMPCK, int FFDADMJDJGJ, MMDFLBNDNHC<T, U> OOGJHJCBFFL) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AE50", Offset = "0x6A39E50", VA = "0x186A3AE50")]
	public static byte[] HFNEOAJNIOH(this byte[] KALCJEIICGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3ABD0", Offset = "0x6A39BD0", VA = "0x186A3ABD0")]
	public static byte[] ANLHMNFNEKC(this byte[] KALCJEIICGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MAGCDPNELJA
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B0E0", Offset = "0x6A3A0E0", VA = "0x186A3B0E0")]
	public static byte DAHKBBMGIBD(this bool KALCJEIICGB)
	{
		return default(byte);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HLGIEDNODAF
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B0E0", Offset = "0x6A3A0E0", VA = "0x186A3B0E0")]
	public static bool PIDFDCJLODL(this byte KALCJEIICGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KEMLMPHGIIB
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2C70450", Offset = "0x2C6F450", VA = "0x182C70450")]
	public static void LMCALGGFHKA<T>(this ICollection<T> KALCJEIICGB, IEnumerable<T> EKCCFIDJBEH) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PABBCHOJJOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2D68630", Offset = "0x2D67630", VA = "0x182D68630")]
	public static void HHOHABBFOJE<K, V>(this IDictionary<K, V> KALCJEIICGB, [In] K GMFCIHEFPPO, [In] V JJCEIJMGOAB, Func<V, V, V> ILODBNACEKJ) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2D67060", Offset = "0x2D66060", VA = "0x182D67060")]
	public static void DKNMPKFPICM<K, V>(this IDictionary<K, List<V>> KALCJEIICGB, [In] K GMFCIHEFPPO, [In] V JJCEIJMGOAB) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2D67C60", Offset = "0x2D66C60", VA = "0x182D67C60")]
	public static TVal EKDMJCIFMJJ<TVal, TKey>(this IDictionary<TKey, TVal> PDKIFAKOONJ, [In] TKey GMFCIHEFPPO, [Optional][EIHFMHIFCDM("`default!` shouldn't be necessary in C# 9")] TVal KCDEJIJHLPJ) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2D678A0", Offset = "0x2D668A0", VA = "0x182D678A0")]
	public static TVal EKDMJCIFMJJ<TVal, TKey>(this IDictionary<TKey, TVal> PDKIFAKOONJ, [In] TKey GMFCIHEFPPO, Func<TVal> OAHIMGDELFN) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2D68D10", Offset = "0x2D67D10", VA = "0x182D68D10")]
	public static TValue IEECJHLOHFI<TValue, TKey>(this IDictionary<TKey, TValue> PDKIFAKOONJ, [In] TKey GMFCIHEFPPO, [Optional][In][EIHFMHIFCDM("`default!` and null-oblivious region shouldn't be necessary in C# 9")] TValue KCDEJIJHLPJ)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2D69570", Offset = "0x2D68570", VA = "0x182D69570")]
	public static V LMAAFFBDALD<V, K>(this IDictionary<K, V> KALCJEIICGB, [In] K GMFCIHEFPPO) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2D66FA0", Offset = "0x2D65FA0", VA = "0x182D66FA0")]
	public static T2[] DGKGANFODBM<T2, T1>(this Dictionary<T1, T2>.ValueCollection LGHLCPDJFAI) where T2 : notnull where T1 : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OOBIKIAEGCC
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate bool PMIDJLKGBCJ<TArgs, T>([In] TArgs DJNIHGJAOCO, T LLGHCONMHCJ);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate U HFNGGHPGBEC<TArg, U>([In] TArg OEMEKBFANIG);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate U FKIMPIHOOBH<TArg, T, U>([In] TArg OEMEKBFANIG, T KIICPOGENEP);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate U DLFNKJCIEBL<TArg, T, U>([In] TArg OEMEKBFANIG, IEnumerable<T> DPNHKFLJNPF);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate U NCLPBJKDEDF<TArg, T, U>([In] TArg OEMEKBFANIG, T KIICPOGENEP);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct HACAFNGHIFI<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF790", Offset = "0x3DBE790", VA = "0x183DBF790")]
		[EIHFMHIFCDM("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) ANCIKKDPJAM(T LBNCHBJPLAA)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3DBF7F0", Offset = "0x3DBE7F0", VA = "0x183DBF7F0")]
		[EIHFMHIFCDM("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) EOAFFFNMHFB(IEnumerable<T> AFOKJPHHNIC)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class ALMFNOFNPBK<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private ISet<T> set;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ISet<T> <>3__set;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private IEnumerable<T> source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public IEnumerable<T> <>3__source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private IEnumerator<T> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9A2800", Offset = "0x9A1800", VA = "0x1809A2800", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x3E27AA0", Offset = "0x3E26AA0", VA = "0x183E27AA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xB5C8B0", Offset = "0xB5B8B0", VA = "0x180B5C8B0")]
		[DebuggerHidden]
		public ALMFNOFNPBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3AA34E0", Offset = "0x3AA24E0", VA = "0x183AA34E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3E270D0", Offset = "0x3E260D0", VA = "0x183E270D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3E27030", Offset = "0x3E26030", VA = "0x183E27030")]
		private void IKLMFKCBKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3E27A50", Offset = "0x3E26A50", VA = "0x183E27A50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3E27840", Offset = "0x3E26840", VA = "0x183E27840", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x387A550", Offset = "0x3879550", VA = "0x18387A550", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class MKCFMBIHECP<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private IEnumerable<U> other;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public IEnumerable<U> <>3__other;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private T with;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public T <>3__with;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private IEnumerator<T> <selfEnumerator>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<U> <otherEnumerator>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8A4A30", Offset = "0x8A3A30", VA = "0x1808A4A30")]
		[DebuggerHidden]
		public MKCFMBIHECP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x44FF790", Offset = "0x44FE790", VA = "0x1844FF790", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x44FE860", Offset = "0x44FD860", VA = "0x1844FE860", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x44FE7C0", Offset = "0x44FD7C0", VA = "0x1844FE7C0")]
		private void IKLMFKCBKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x44FF460", Offset = "0x44FE460", VA = "0x1844FF460")]
		private void POOBBHLNDCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x44FF6A0", Offset = "0x44FE6A0", VA = "0x1844FF6A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x44FF5B0", Offset = "0x44FE5B0", VA = "0x1844FF5B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB5D0", Offset = "0x3AAA5D0", VA = "0x183AAB5D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class BOGKNAEIOLA<T> : IEnumerable<(T, IHMGDPHFMFJ<T>)>, IEnumerable, IEnumerator<(T, IHMGDPHFMFJ<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private (T Current, IHMGDPHFMFJ<T> Next) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private IEnumerator<T> <enumerator>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private (T, IHMGDPHFMFJ<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x390CE60", Offset = "0x390BE60", VA = "0x18390CE60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, IHMGDPHFMFJ<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4EA71E0", Offset = "0x4EA61E0", VA = "0x184EA71E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1EDAAD0", Offset = "0x1ED9AD0", VA = "0x181EDAAD0")]
		[DebuggerHidden]
		public BOGKNAEIOLA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9A90", Offset = "0x3AA8A90", VA = "0x183AA9A90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4EA6370", Offset = "0x4EA5370", VA = "0x184EA6370", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4EA5930", Offset = "0x4EA4930", VA = "0x184EA5930")]
		private void IKLMFKCBKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4EA7140", Offset = "0x4EA6140", VA = "0x184EA7140", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4EA6E30", Offset = "0x4EA5E30", VA = "0x184EA6E30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, IHMGDPHFMFJ<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB5D0", Offset = "0x3AAA5D0", VA = "0x183AAB5D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ACAGGMBINMO<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private U <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private Func<HACAFNGHIFI<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Func<HACAFNGHIFI<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IEnumerator<T> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private IEnumerator<U> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		U IEnumerator<UnityEngine.SpookyHash.U>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (U)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8A4A30", Offset = "0x8A3A30", VA = "0x1808A4A30")]
		[DebuggerHidden]
		public ACAGGMBINMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3CEB750", Offset = "0x3CEA750", VA = "0x183CEB750", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3CEB230", Offset = "0x3CEA230", VA = "0x183CEB230", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3CEB1E0", Offset = "0x3CEA1E0", VA = "0x183CEB1E0")]
		private void IKLMFKCBKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3CEB6B0", Offset = "0x3CEA6B0", VA = "0x183CEB6B0")]
		private void POOBBHLNDCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3CEB700", Offset = "0x3CEA700", VA = "0x183CEB700", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4520", Offset = "0x3CD3520", VA = "0x183CD4520", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4B40", Offset = "0x3CD3B40", VA = "0x183CD4B40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HEALICCMMCG<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public HEALICCMMCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3DC5BC0", Offset = "0x3DC4BC0", VA = "0x183DC5BC0")]
		internal bool BCKHKMKJBGL(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3DC5C20", Offset = "0x3DC4C20", VA = "0x183DC5C20")]
		internal bool EJAKMDDLGPF(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CBAGEPPGIPK<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private (T Lhs, U Rhs) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerable<T> lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public IEnumerable<T> <>3__lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private IEnumerable<U> rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public IEnumerable<U> <>3__rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<T> <lhsIt>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private IEnumerator<U> <rhsIt>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private (T, U) System.Collections.Generic.IEnumerator<(TLhs,URhs)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xD382A0", Offset = "0xD372A0", VA = "0x180D382A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, U));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x3CCF160", Offset = "0x3CCE160", VA = "0x183CCF160", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1EDAAD0", Offset = "0x1ED9AD0", VA = "0x181EDAAD0")]
		[DebuggerHidden]
		public CBAGEPPGIPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x51836D0", Offset = "0x51826D0", VA = "0x1851836D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x51839D0", Offset = "0x51829D0", VA = "0x1851839D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x51838F0", Offset = "0x51828F0", VA = "0x1851838F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB5D0", Offset = "0x3AAA5D0", VA = "0x183AAB5D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2D640D0", Offset = "0x2D630D0", VA = "0x182D640D0")]
	public static bool PAHNKKNFJJM<T, TArgs>(this IEnumerable<T> KALCJEIICGB, [In] TArgs DJNIHGJAOCO, PMIDJLKGBCJ<TArgs, T> FDCCCMFJJJK) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E3B0", Offset = "0x6A3D3B0", VA = "0x186A3E3B0")]
	public static bool PAHNKKNFJJM(this IEnumerable<bool> KALCJEIICGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2D616F0", Offset = "0x2D606F0", VA = "0x182D616F0")]
	public static U KEMMEDFEELH<U, T>(this IEnumerable<T> KALCJEIICGB, Func<U> OBPNMAIHIGD, Func<T, U> LBNCHBJPLAA, Func<IEnumerable<T>, U> AFOKJPHHNIC) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2D5EFD0", Offset = "0x2D5DFD0", VA = "0x182D5EFD0")]
	public static bool ANAPOGHFFLP<T, TArgs>(this IEnumerable<T> KALCJEIICGB, [In] TArgs DJNIHGJAOCO, PMIDJLKGBCJ<TArgs, T> FDCCCMFJJJK) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2D5FBB0", Offset = "0x2D5EBB0", VA = "0x182D5FBB0")]
	public static U EIMIGOMEPKL<U, T, TArg>(this IEnumerable<T> KALCJEIICGB, [In] TArg OEMEKBFANIG, HFNGGHPGBEC<TArg, U> OBPNMAIHIGD, FKIMPIHOOBH<TArg, T, U> LBNCHBJPLAA, DLFNKJCIEBL<TArg, T, U> AFOKJPHHNIC) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2D60FD0", Offset = "0x2D5FFD0", VA = "0x182D60FD0")]
	public static IEnumerable<U> IBLANOHHKCC<U, T, TArg>(this IEnumerable<T> KALCJEIICGB, [In] TArg OEMEKBFANIG, NCLPBJKDEDF<TArg, T, U> JJKIJKJILIB) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2D0FD40", Offset = "0x2D0ED40", VA = "0x182D0FD40")]
	public static IEnumerable<T> HMLJPOJHEIF<T>(params IEnumerable<T>[] KNJBGKLBHBM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2D60670", Offset = "0x2D5F670", VA = "0x182D60670")]
	public static bool HFEOFKHJOKF<T>(this IEnumerable<T> IEJOAHLDAPK, IEnumerable<T> ACBLPNJDJBF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2D0FD40", Offset = "0x2D0ED40", VA = "0x182D0FD40")]
	public static IEnumerable<(TKey?, TValue?)>? MEGKEPPBBDJ<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> KALCJEIICGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2D61510", Offset = "0x2D60510", VA = "0x182D61510")]
	public static IEnumerable<T> IEIELNBOGCN<T, TKey>(this IEnumerable<T> EFFHOEMGECD, Func<T, TKey> LOPHCCCPLDF) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2B080D0", Offset = "0x2B070D0", VA = "0x182B080D0")]
	[IteratorStateMachine(typeof(ALMFNOFNPBK<>))]
	public static IEnumerable<T> OKKOOPOAGAB<T>(this IEnumerable<T> IEJOAHLDAPK, ISet<T> DMJJLFJCIPP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2B4B830", Offset = "0x2B4A830", VA = "0x182B4B830")]
	[IteratorStateMachine(typeof(MKCFMBIHECP<, >))]
	public static IEnumerable<T> BMCMGIEAHOK<T, U>(this IEnumerable<T> KALCJEIICGB, IEnumerable<U> ACBLPNJDJBF, [Optional][EIHFMHIFCDM("`default!` shouldn't be necessary in C# 9")] T EBAOBPNGOEJ) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x28B5400", Offset = "0x28B4400", VA = "0x1828B5400")]
	public static T FONMAPGCEPB<T>(this IEnumerable<T> IEJOAHLDAPK, T KCDEJIJHLPJ) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2D605F0", Offset = "0x2D5F5F0", VA = "0x182D605F0")]
	public static T FONMAPGCEPB<T>(this IEnumerable<T> IEJOAHLDAPK, T KCDEJIJHLPJ, Func<T, bool> FDCCCMFJJJK) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2D62540", Offset = "0x2D61540", VA = "0x182D62540")]
	public static T? OGKNAKBFPFN<T>(this IEnumerable<T> KALCJEIICGB, Func<T, bool> FDCCCMFJJJK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2D62F40", Offset = "0x2D61F40", VA = "0x182D62F40")]
	public static void ONFGCOJANHA<T>(this IEnumerable<T> KALCJEIICGB, Action<T> ELECLKGFGKN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5CB0", Offset = "0x2AB4CB0", VA = "0x182AB5CB0")]
	[IteratorStateMachine(typeof(BOGKNAEIOLA<>))]
	public static IEnumerable<(T, IHMGDPHFMFJ<T>)> LFODGMCCHPM<T>(this IEnumerable<T> KALCJEIICGB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2D5F980", Offset = "0x2D5E980", VA = "0x182D5F980")]
	public static bool DCNHMBFFODE<T>(this IEnumerable<T> KALCJEIICGB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2D0FD40", Offset = "0x2D0ED40", VA = "0x182D0FD40")]
	public static IEnumerable<KFMACFLLFMJ<T>> LCNJIFOOGIB<T>(this IEnumerable<T> KALCJEIICGB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2D61950", Offset = "0x2D60950", VA = "0x182D61950")]
	public static bool KFCLKKNDODJ<T>(this IEnumerable<T> KALCJEIICGB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2D5FB70", Offset = "0x2D5EB70", VA = "0x182D5FB70")]
	public static IEnumerable<T> EFDPCOAEIFN<T>(this IEnumerable<T>? KALCJEIICGB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5960", Offset = "0x2AB4960", VA = "0x182AB5960")]
	[IteratorStateMachine(typeof(ACAGGMBINMO<, >))]
	public static IEnumerable<U> NDOJEALCMAL<U, T>(this IEnumerable<T> KALCJEIICGB, Func<HACAFNGHIFI<U>, T, (bool Zero, U One, IEnumerable<U> Many)> GBJEAEFJBLD) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2D61DE0", Offset = "0x2D60DE0", VA = "0x182D61DE0")]
	public static int OBJEDKPHCEM<T>(this IEnumerable<T> KALCJEIICGB, int MEILBOPEIPO = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D60090", Offset = "0x2D5F090", VA = "0x182D60090")]
	public static bool EMINMBGHFEC<T>(this IEnumerable<T> KALCJEIICGB, IEnumerable<T> ACBLPNJDJBF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2D61990", Offset = "0x2D60990", VA = "0x182D61990")]
	public static IEnumerable<T> KHPNPDAIINB<T>(this IEnumerable<T> KALCJEIICGB, int GPAHPDFDGCO, int IAMJKAHLBGF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2D61AB0", Offset = "0x2D60AB0", VA = "0x182D61AB0")]
	public static (IEnumerable<T>, IEnumerable<T>) NJLFLDHAMNF<T>(this IEnumerable<T> KALCJEIICGB, Func<T, bool> OLEBNGKOFBB) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2D60860", Offset = "0x2D5F860", VA = "0x182D60860")]
	public static string HOFLLNPLJCP<T>(this IEnumerable<T> KALCJEIICGB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2D602F0", Offset = "0x2D5F2F0", VA = "0x182D602F0")]
	public static Dictionary<TKey?, TValue?>? EONGOLNDGAC<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> IEJOAHLDAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2D602F0", Offset = "0x2D5F2F0", VA = "0x182D602F0")]
	public static Dictionary<TKey?, TValue?>? EONGOLNDGAC<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> IEJOAHLDAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2D5FAB0", Offset = "0x2D5EAB0", VA = "0x182D5FAB0")]
	public static List<T> DGKMBLGMFGL<T>(this IEnumerable<T> KALCJEIICGB, int BPIECAEAGAJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2D64880", Offset = "0x2D63880", VA = "0x182D64880")]
	public static string PGOBHFLMKMM<T>(this IEnumerable<T> KALCJEIICGB, string JNBIHOCKMBF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2D5E550", Offset = "0x2D5D550", VA = "0x182D5E550")]
	public static (IReadOnlyList<T?>?, IReadOnlyList<U?>?) AGJNBGDECAC<T, U>(this IEnumerable<(T Lhs, U Rhs)> KALCJEIICGB)
	{
		return default((IReadOnlyList<T>, IReadOnlyList<U>));
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2B01630", Offset = "0x2B00630", VA = "0x182B01630")]
	[IteratorStateMachine(typeof(CBAGEPPGIPK<, >))]
	public static IEnumerable<(T, U)> KHIBHDODNCO<T, U>(this IEnumerable<T> PNODNPKGJKB, IEnumerable<U> JHNJJGDAEGF) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2D645E0", Offset = "0x2D635E0", VA = "0x182D645E0")]
	public static IEnumerable<V> PFJDHOCPPMA<V, T, U>(this IEnumerable<T> KALCJEIICGB, IEnumerable<U> ACBLPNJDJBF, Func<T, U, V> OHBFLNHEIIB, [Optional][EIHFMHIFCDM("`default!` shouldn't be necessary in C# 9")] T KEEFODINPCB, [Optional][EIHFMHIFCDM("`default!` shouldn't be necessary in C# 9")] U FHBNHHBHODM) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2D646B0", Offset = "0x2D636B0", VA = "0x182D646B0")]
	public static IEnumerable<(T, U)> PFJDHOCPPMA<T, U>(this IEnumerable<T> KALCJEIICGB, IEnumerable<U> ACBLPNJDJBF, [Optional][EIHFMHIFCDM("`default!` shouldn't be necessary in C# 9")] T KEEFODINPCB, [Optional][EIHFMHIFCDM("`default!` shouldn't be necessary in C# 9")] U FHBNHHBHODM) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2D5F440", Offset = "0x2D5E440", VA = "0x182D5F440")]
	public static TOut[] COJEACKJNIN<TOut, TIn>(this IEnumerable<TIn> EFFHOEMGECD, Func<TIn, TOut> OOCBHKIHODA) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class BNDPCLPNFPN
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x292EC40", Offset = "0x292DC40", VA = "0x18292EC40")]
	public static bool DAMOOBHFFOD<T, U>(this T KALCJEIICGB, [In] U NOPFNIKINJA) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x292EE60", Offset = "0x292DE60", VA = "0x18292EE60")]
	public static bool GOINHPGLBFO<T>(T KALCJEIICGB, T ACBLPNJDJBF) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class MACLIJAKHBJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xBBA8B0", Offset = "0xBB98B0", VA = "0x180BBA8B0")]
	public static bool OKOHEFJBOLM([In] this float3 MHGINKKGGNL, float3 JCHFDOINNOA, float FKDKNDPHDGE = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class CNGEBOBJCHI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class LODDGILDCCL<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private T self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public T <>3__self;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x9A2800", Offset = "0x9A1800", VA = "0x1809A2800", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x3BFE9B0", Offset = "0x3BFD9B0", VA = "0x183BFE9B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xB5C8B0", Offset = "0xB5B8B0", VA = "0x180B5C8B0")]
		[DebuggerHidden]
		public LODDGILDCCL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4310190", Offset = "0x430F190", VA = "0x184310190", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x4310490", Offset = "0x430F490", VA = "0x184310490", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4310310", Offset = "0x430F310", VA = "0x184310310", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3963510", Offset = "0x3962510", VA = "0x183963510", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x29A5E00", Offset = "0x29A4E00", VA = "0x1829A5E00")]
	public static void INIDOKAEGIH<T>(this T IGKMAMABJBH, Action<T> GJKGIDJHALJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x29A5D30", Offset = "0x29A4D30", VA = "0x1829A5D30")]
	public static V IDKPGOJOJPF<V, T>(this T IGKMAMABJBH, Func<T, V> GJKGIDJHALJ, [Optional][EIHFMHIFCDM("`default!` shouldn't be necessary in C# 9")] V KCDEJIJHLPJ) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x29A6010", Offset = "0x29A5010", VA = "0x1829A6010")]
	public static T? KJLPACPGELI<T>(this T KALCJEIICGB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x29A5E50", Offset = "0x29A4E50", VA = "0x1829A5E50")]
	[IteratorStateMachine(typeof(LODDGILDCCL<>))]
	public static IEnumerable<T> JFMNOJALPPO<T>(this T KALCJEIICGB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x29A5C10", Offset = "0x29A4C10", VA = "0x1829A5C10")]
	public static T[] HJDHKHOLHHN<T>(this T KALCJEIICGB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class KCFBHJLIOOH
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CF20", Offset = "0x6A3BF20", VA = "0x186A3CF20")]
	private static byte[] FPHGMKAEECH(int BHELPMDNDIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D080", Offset = "0x6A3C080", VA = "0x186A3D080")]
	private static byte[] OCPEGPPEAKC(long PBCINNKADIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C7B0", Offset = "0x6A3B7B0", VA = "0x186A3C7B0")]
	private static byte[] BKMEJEFLHCJ(ulong PBCINNKADIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D100", Offset = "0x6A3C100", VA = "0x186A3D100")]
	public static Guid PDGJNHKNCAA(params Guid[] JEBIEJKNHIG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CA40", Offset = "0x6A3BA40", VA = "0x186A3CA40")]
	public static Guid EAPGIKBOING([In] Guid FHJEBCEECGD, int HCALFJOJKJO, int FFOAGBHJNBO = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C970", Offset = "0x6A3B970", VA = "0x186A3C970")]
	public static Guid EAPGIKBOING([In] Guid FHJEBCEECGD, long HCALFJOJKJO, int FFOAGBHJNBO = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C8A0", Offset = "0x6A3B8A0", VA = "0x186A3C8A0")]
	public static Guid EAPGIKBOING([In] Guid FHJEBCEECGD, ulong HCALFJOJKJO, int FFOAGBHJNBO = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C830", Offset = "0x6A3B830", VA = "0x186A3C830")]
	public static Guid EAPGIKBOING([In] Guid FHJEBCEECGD, [In] Guid GPJPOGNBNAP, int FFOAGBHJNBO = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CB10", Offset = "0x6A3BB10", VA = "0x186A3CB10")]
	private static Guid EAPGIKBOING([In] Guid FHJEBCEECGD, byte[] MPEMIBPEJOF, int FFOAGBHJNBO = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CFA0", Offset = "0x6A3BFA0", VA = "0x186A3CFA0")]
	private static void JLFDBGJKKHO(byte[] CNIMPJMOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D030", Offset = "0x6A3C030", VA = "0x186A3D030")]
	private static void JPGGNABCFGE(byte[] CNIMPJMOLDJ, int OHFIHFHICKK, int CENGDJBMKEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class KLNHIFNAFAK
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D370", Offset = "0x6A3C370", VA = "0x186A3D370")]
	public static int OGNPHONDAHL(this int KALCJEIICGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D320", Offset = "0x6A3C320", VA = "0x186A3D320")]
	public static int HLFBGMPPMFJ(this int KALCJEIICGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D3E0", Offset = "0x6A3C3E0", VA = "0x186A3D3E0")]
	public static int PDEFLJAMCPA(this int KALCJEIICGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D310", Offset = "0x6A3C310", VA = "0x186A3D310")]
	public static int HGAFKNMDJIN(this int KALCJEIICGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5A42240", Offset = "0x5A41240", VA = "0x185A42240")]
	public static int IBFBMNEBPBM(this int KALCJEIICGB, int DOPPKGNLPAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5B12C10", Offset = "0x5B11C10", VA = "0x185B12C10")]
	public static int ILGAJIHOCHL(this int KALCJEIICGB, int DOPPKGNLPAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D280", Offset = "0x6A3C280", VA = "0x186A3D280")]
	public static float FBKCLCMANKN(this int KALCJEIICGB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D2A0", Offset = "0x6A3C2A0", VA = "0x186A3D2A0")]
	public static (byte, byte, byte, byte) GPJEMFEHIEA(this int KALCJEIICGB)
	{
		return default((byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D430", Offset = "0x6A3C430", VA = "0x186A3D430")]
	public static int PGLPMFPFMDO([In] this (byte Fourth, byte Third, byte Second, byte First) KALCJEIICGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D270", Offset = "0x6A3C270", VA = "0x186A3D270")]
	public static int CELFBLGOEMJ(this int KALCJEIICGB, int EFDCLCEIMLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D360", Offset = "0x6A3C360", VA = "0x186A3D360")]
	public static int IIEHGHEKLEA(this int KALCJEIICGB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface KDLJPLIMOPF
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BKINHHIOKAO(int CFNIIOJPOAM, int OLECMFGIKAF);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float OCJFDEIGJPH(float GBNIKCCNBGH, float CBENKPFFHEH);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OLIJJAOMKMM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	long JKGEBMJBPHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class EBICFGAMDFD
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2A30D90", Offset = "0x2A2FD90", VA = "0x182A30D90")]
	public static (TKey?, TValue?) GENCMKBJEJM<TKey, TValue>([In] this KeyValuePair<TKey, TValue> KALCJEIICGB)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2A30E90", Offset = "0x2A2FE90", VA = "0x182A30E90")]
	public static KeyValuePair<TKey?, UValue?> MOGDACPELPD<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> KALCJEIICGB, UValue JJCEIJMGOAB)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class KBNIJBIFEHK
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class HFBENLGOIME<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public HFBENLGOIME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3DC6D90", Offset = "0x3DC5D90", VA = "0x183DC6D90")]
		internal TElement MLAONFINNOM(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2C65B20", Offset = "0x2C64B20", VA = "0x182C65B20")]
	public static int JKFCIICEAHL<T>(this IReadOnlyList<T> IKONNGGNFPH, T JJCEIJMGOAB) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2C68230", Offset = "0x2C67230", VA = "0x182C68230")]
	public static int OFDLHENDHGO<T>(this IReadOnlyList<T> IKONNGGNFPH, T JJCEIJMGOAB) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2C66F60", Offset = "0x2C65F60", VA = "0x182C66F60")]
	public static void LMCALGGFHKA<T>(this HashSet<T> AAKJNAIOJPG, IEnumerable<T> EKCCFIDJBEH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2C632D0", Offset = "0x2C622D0", VA = "0x182C632D0")]
	public static void ELMGMFDBDLG<T>(this IList<T> IEKJOJONGFC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2C62F90", Offset = "0x2C61F90", VA = "0x182C62F90")]
	public static void ELMGMFDBDLG<T>(this IList<T> IEKJOJONGFC, int OOJDOAFHBFI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2C629B0", Offset = "0x2C619B0", VA = "0x182C629B0")]
	public static void BBFHHIBDDCM<T>(this List<T> IEKJOJONGFC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2C66870", Offset = "0x2C65870", VA = "0x182C66870")]
	public static List<T> KLGDINNAFGE<T>(this List<T> HCHCJEKMPPP, Predicate<T> FJKNEFJGDOM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2C662D0", Offset = "0x2C652D0", VA = "0x182C662D0")]
	public static int JKFCIICEAHL<T>(this IReadOnlyList<T> IEKJOJONGFC, Predicate<T> FDCCCMFJJJK) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2C669E0", Offset = "0x2C659E0", VA = "0x182C669E0")]
	public static bool KOJHALMAFLI<T>(this IReadOnlyList<T> IEKJOJONGFC, Predicate<T> FDCCCMFJJJK, [Out][NotNullWhen(true)] List<int>? FIEKLFJCNCA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2C65520", Offset = "0x2C64520", VA = "0x182C65520")]
	public static bool HODGCICEPOA<T>(this IReadOnlyList<T> IEKJOJONGFC, T LLGHCONMHCJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C655A0", Offset = "0x2C645A0", VA = "0x182C655A0")]
	public static bool HODGCICEPOA<T>(this IReadOnlyList<T> IEKJOJONGFC, T LLGHCONMHCJ, EqualityComparer<T> PBGGGGHIKLD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C642A0", Offset = "0x2C632A0", VA = "0x182C642A0")]
	public static int GOLJACHMFKP<TElement, TKey>(this IList<TElement> PKDEDIKLKIA, TKey ACAJNGHFAAE, Func<TElement, TKey> MJLALBHEGEG, [Optional] Func<TKey, TKey, int>? INGGACOLKBC, int HCALFJOJKJO = 0, [Optional] int? DOPPKGNLPAC) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2C63F10", Offset = "0x2C62F10", VA = "0x182C63F10")]
	public static int GOLJACHMFKP<TElement, TKey>(Func<int, TElement> MBIJJHPOCFB, int DKFCHHMNMGI, TKey ACAJNGHFAAE, Func<TElement, TKey> MJLALBHEGEG, [Optional] Func<TKey, TKey, int>? INGGACOLKBC, int HCALFJOJKJO = 0, [Optional] int? DOPPKGNLPAC) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2C63A60", Offset = "0x2C62A60", VA = "0x182C63A60")]
	public static bool FMLHPJFBOCL<T>(this List<T> IEKJOJONGFC, T LLGHCONMHCJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2C68400", Offset = "0x2C67400", VA = "0x182C68400")]
	public static void OHOKJAFEJDL<T>(this List<T> IEKJOJONGFC, IEnumerable<T> HCHCJEKMPPP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2C637C0", Offset = "0x2C627C0", VA = "0x182C637C0")]
	public static void FFDBNDOHLIO<T>(this List<T> IEKJOJONGFC, IEnumerable<T> HCHCJEKMPPP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2C63730", Offset = "0x2C62730", VA = "0x182C63730")]
	public static T EOAIMDCFKPC<T>(this List<T> HCHCJEKMPPP, Predicate<T> FJKNEFJGDOM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2C62E60", Offset = "0x2C61E60", VA = "0x182C62E60")]
	public static T CICJOLKMHAH<T>(this List<T> HCHCJEKMPPP, int HCALFJOJKJO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2C63E00", Offset = "0x2C62E00", VA = "0x182C63E00")]
	public static void GNBFOHFDCGD<T>(this List<T> IEKJOJONGFC, int HCALFJOJKJO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2C66E80", Offset = "0x2C65E80", VA = "0x182C66E80")]
	public static bool LJGGHEGNHLP<T>(this List<T> GCPLOLGCBHC, List<T> MLICNMJAHDP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2C62910", Offset = "0x2C61910", VA = "0x182C62910")]
	public static T AOOEEOAPEJE<T>(this IList<T> IEKJOJONGFC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2C639B0", Offset = "0x2C629B0", VA = "0x182C639B0")]
	public static bool FHACEIENABL<T>(IReadOnlyList<T>? IEKJOJONGFC, int HCALFJOJKJO, [Out][MaybeNullWhen(false)][EIHFMHIFCDM("This should be `T?` in C# 9.")] T KNFGDDANCCK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2C618F0", Offset = "0x2C608F0", VA = "0x182C618F0")]
	public static bool AEPLAAIKFFF<T>(IReadOnlyList<T> IEKJOJONGFC, ICollection HCHCJEKMPPP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2C67EB0", Offset = "0x2C66EB0", VA = "0x182C67EB0")]
	public static void NNIDDBCIFHF<T>(IReadOnlyList<T> IEKJOJONGFC, ICollection HCHCJEKMPPP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x29BEAF0", Offset = "0x29BDAF0", VA = "0x1829BEAF0")]
	public static bool EMJMNNEDACG<T>(this IReadOnlyList<T> IEKJOJONGFC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2C68070", Offset = "0x2C67070", VA = "0x182C68070")]
	public static string OEOPJACKCNA<T>(this IEnumerable<T> IEKJOJONGFC, string AMHGOEIHNBH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2C68880", Offset = "0x2C67880", VA = "0x182C68880")]
	public static T PNGIKEAILKE<T>(this IList<T> KALCJEIICGB) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2C67C90", Offset = "0x2C66C90", VA = "0x182C67C90")]
	public static T MPLGLEJGHFA<T>(this IList<T> KALCJEIICGB) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2C62F00", Offset = "0x2C61F00", VA = "0x182C62F00")]
	public static void EBNMCHEEHPJ<T>(this IList<T> KALCJEIICGB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C65980", Offset = "0x2C64980", VA = "0x182C65980")]
	public static void JEFAGGPMDFG<T>(this IList<T> KALCJEIICGB, [In] T JJCEIJMGOAB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2C63D00", Offset = "0x2C62D00", VA = "0x182C63D00")]
	public static T GBGPDNJKBEI<T>(this IList<T> KALCJEIICGB) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C65700", Offset = "0x2C64700", VA = "0x182C65700")]
	public static void IFCFGHBCIFO<T>(this List<T> KALCJEIICGB) where T : struct, IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class BBKGLNBMLGN
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static float NNMOMILFOKJ;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static float PNHMOJFHKML;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static bool BBJBMAJFDOG;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly float ILBOHEKPHMI;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A39FA0", Offset = "0x6A38FA0", VA = "0x186A39FA0")]
	public static bool FMJNMGDKNJJ(float MHGINKKGGNL, float JCHFDOINNOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A160", Offset = "0x6A39160", VA = "0x186A3A160")]
	public static float JPDMMFGHHGC(float JJCEIJMGOAB, float EGMGMOAFAED, float LJPDMCKLOMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A180", Offset = "0x6A39180", VA = "0x186A3A180")]
	public static int JPDMMFGHHGC(int JJCEIJMGOAB, int EGMGMOAFAED, int LJPDMCKLOMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A220", Offset = "0x6A39220", VA = "0x186A3A220")]
	public static float KEOIMKFDBMJ(float JJCEIJMGOAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A39EC0", Offset = "0x6A38EC0", VA = "0x186A39EC0")]
	public static float EGBNAMLCAII(float MHGINKKGGNL, float JCHFDOINNOA, float IGKMAMABJBH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A150", Offset = "0x6A39150", VA = "0x186A3A150")]
	public static float IFCNHBFNBGF(float MHGINKKGGNL, float JCHFDOINNOA, float IGKMAMABJBH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A090", Offset = "0x6A39090", VA = "0x186A3A090")]
	public static float GPAKIHHOKCC(float MHGINKKGGNL, float JCHFDOINNOA, float JJCEIJMGOAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A39F60", Offset = "0x6A38F60", VA = "0x186A39F60")]
	public static float FADGCJMFHGJ(float MHGINKKGGNL, float JCHFDOINNOA, float JJCEIJMGOAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A39CE0", Offset = "0x6A38CE0", VA = "0x186A39CE0")]
	public static float BEBLGGDBNCC(float MHGINKKGGNL, float JCHFDOINNOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6A39D00", Offset = "0x6A38D00", VA = "0x186A39D00")]
	public static float DJENFLJBDII(float LDBIHCMBCGJ, float KAEDHDLBKFF, float KFNGCFJDFLJ, float LHELGOBCPKO, float BCBOHKMEOIN, float HEGNCBOIFLG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6A39C50", Offset = "0x6A38C50", VA = "0x186A39C50")]
	public static float BBGMBAHJFGJ(float JJCEIJMGOAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A240", Offset = "0x6A39240", VA = "0x186A3A240")]
	public static float OONDMCPLEAF(float JJCEIJMGOAB, float EGMGMOAFAED, float LJPDMCKLOMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A1A0", Offset = "0x6A391A0", VA = "0x186A3A1A0")]
	public static float KCNCMBJKOFG(float IIGAMAIKLHI)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class EHBFANEILIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private System.Random NHDJGJNGOBN;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A4A0", Offset = "0x6A394A0", VA = "0x186A3A4A0")]
	public EHBFANEILIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A530", Offset = "0x6A39530", VA = "0x186A3A530")]
	public EHBFANEILIB(int OOJDOAFHBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x61B2230", Offset = "0x61B1230", VA = "0x1861B2230", Slot = "4")]
	public virtual int BKINHHIOKAO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A410", Offset = "0x6A39410", VA = "0x186A3A410", Slot = "5")]
	public virtual int BKINHHIOKAO(int OLECMFGIKAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A440", Offset = "0x6A39440", VA = "0x186A3A440", Slot = "6")]
	public virtual int BKINHHIOKAO(int CFNIIOJPOAM, int OLECMFGIKAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A470", Offset = "0x6A39470", VA = "0x186A3A470")]
	public double HDBDNPHPDBB()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class CBMABOAALOA
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2992840", Offset = "0x2991840", VA = "0x182992840")]
	[KLDKOFJPICD("This should be replaced with the `is not` operator in C# 9.")]
	public static bool BBDJLOHKFHK<T>(this object KALCJEIICGB, [Out][NotNullWhen(true)] T KNFGDDANCCK) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class JEKNGCBHDHL
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BD30", Offset = "0x6A3AD30", VA = "0x186A3BD30")]
	public static (float3, float3, float3) IDOHEFHIOJJ([In] this quaternion KALCJEIICGB)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B1C0", Offset = "0x6A3A1C0", VA = "0x186A3B1C0")]
	private static float3 AHIMDBJCHCJ(quaternion FJHFFANNECC, math.RotationOrder HJAEFBHLKLP = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B0F0", Offset = "0x6A3A0F0", VA = "0x186A3B0F0")]
	private static float3 AGJNNGNDENJ(float3 NMPGMHLHBGP, math.RotationOrder HJAEFBHLKLP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BE20", Offset = "0x6A3AE20", VA = "0x186A3BE20")]
	public static float3 MEIKMHNDLPL(this quaternion FJHFFANNECC, math.RotationOrder HJAEFBHLKLP = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BBE0", Offset = "0x6A3ABE0", VA = "0x186A3BBE0")]
	public static float DHOPLLJFAGE(this quaternion PNODNPKGJKB, quaternion JHNJJGDAEGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BEE0", Offset = "0x6A3AEE0", VA = "0x186A3BEE0")]
	[CompilerGenerated]
	internal static float3 MLDEEMDDFLF(float3 NMPGMHLHBGP)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class EOMFKHKLNPM
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private sealed class NBBLKIHLKJK : KDLJPLIMOPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly System.Random JPHLPIJEPAC;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A440", Offset = "0x6A39440", VA = "0x186A3A440", Slot = "4")]
		public int BKINHHIOKAO(int GBNIKCCNBGH, int APDHBLKNLEL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DF60", Offset = "0x6A3CF60", VA = "0x186A3DF60", Slot = "5")]
		public float OCJFDEIGJPH(float GBNIKCCNBGH, float CBENKPFFHEH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DFD0", Offset = "0x6A3CFD0", VA = "0x186A3DFD0")]
		private double ODJHFBHKBJH()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E010", Offset = "0x6A3D010", VA = "0x186A3E010")]
		public NBBLKIHLKJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly KDLJPLIMOPF LFHOLEJFCKM;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A5B0", Offset = "0x6A395B0", VA = "0x186A3A5B0")]
	public static ulong DEDKIBCEBGF()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class PMFCHFOLMHE
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2D7F400", Offset = "0x2D7E400", VA = "0x182D7F400")]
	public static bool LMGCAIKCKLK<T>(this IReadOnlyCollection<T> KALCJEIICGB, int HCALFJOJKJO) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class PAPJIKKCACN
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2D6A420", Offset = "0x2D69420", VA = "0x182D6A420")]
	public static bool ADDDNNFJBLD<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> KALCJEIICGB, IReadOnlyDictionary<TKey, TValue> ACBLPNJDJBF) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class PIHPHEENNMJ
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B360", Offset = "0x2D7A360", VA = "0x182D7B360")]
	public static TValue? MECNNJIEFNK<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> KALCJEIICGB, TKey GMFCIHEFPPO) where TValue : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class KOAODEIICOA
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D450", Offset = "0x6A3C450", VA = "0x186A3D450")]
	public static void GHKHNOGELCE(this IReadOnlyList<Action> KALCJEIICGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2C74A50", Offset = "0x2C73A50", VA = "0x182C74A50")]
	public static bool HNEILIJEPGH<T>(this IReadOnlyList<T> KALCJEIICGB, int HCALFJOJKJO, [Out][NotNullWhen(true)][EIHFMHIFCDM("This should be `T?` in C# 9.")] T KNFGDDANCCK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2C74C40", Offset = "0x2C73C40", VA = "0x182C74C40")]
	public static bool MCONPIOBJPD<T>(this IReadOnlyList<T> KALCJEIICGB, int HCALFJOJKJO, [Out] KFMACFLLFMJ<T> KNFGDDANCCK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2C74BA0", Offset = "0x2C73BA0", VA = "0x182C74BA0")]
	public static T KJPDDFNOMPE<T>(this IReadOnlyList<T> KALCJEIICGB, int HCALFJOJKJO, [In] T EPOOCMMJPIJ) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2C74A00", Offset = "0x2C73A00", VA = "0x182C74A00")]
	[EIHFMHIFCDM("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T FLNBDEPPNPA<T>(this IReadOnlyList<T> KALCJEIICGB, int HCALFJOJKJO) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2C74D20", Offset = "0x2C73D20", VA = "0x182C74D20")]
	public static T? MECNNJIEFNK<T>(this IReadOnlyList<T> KALCJEIICGB, int HCALFJOJKJO) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class PLABKFIDMCA
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C880", Offset = "0x2D7B880", VA = "0x182D7C880")]
	public static int CBDGBGLBFJH<T>([In] this ReadOnlySequence<T> IPBDMIADCAB, [In] T JJCEIJMGOAB) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2D7C460", Offset = "0x2D7B460", VA = "0x182D7C460")]
	public static bool ACILIBOCMNL<T>([In] this ReadOnlySequence<T> IPBDMIADCAB, [In] ReadOnlySpan<T> ACBLPNJDJBF) where T : IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class OLGNPEEGOON
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2D58D60", Offset = "0x2D57D60", VA = "0x182D58D60")]
	public static string HOFLLNPLJCP<T>([In] this ReadOnlySpan<T> KALCJEIICGB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2D594D0", Offset = "0x2D584D0", VA = "0x182D594D0")]
	public static string PGOBHFLMKMM<T>([In] this ReadOnlySpan<T> KALCJEIICGB, string JNBIHOCKMBF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class AKPDEJEKFOG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static OLIJJAOMKMM FCJKECCIDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6A398F0", Offset = "0x6A388F0", VA = "0x186A398F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6A39860", Offset = "0x6A38860", VA = "0x186A39860")]
	public static double CCLHBNFKAAA(this OLIJJAOMKMM KALCJEIICGB, long FDGHINLGKGH)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class NOOJGDENKOA : OLIJJAOMKMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Stopwatch HGFKJFKMEAO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long JKGEBMJBPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6A3E2E0", Offset = "0x6A3D2E0", VA = "0x186A3E2E0", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	private NOOJGDENKOA(Stopwatch HPLGJKMDCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E270", Offset = "0x6A3D270", VA = "0x186A3E270")]
	public static NOOJGDENKOA CGIGDFFDCKF(Stopwatch HPLGJKMDCMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E1C0", Offset = "0x6A3D1C0", VA = "0x186A3E1C0")]
	public static NOOJGDENKOA BHICMIEJBPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class MDJLFNPHAFC
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D920", Offset = "0x6A3C920", VA = "0x186A3D920")]
	public static float3 NMPOMPBJNGK([In] this RigidTransform KALCJEIICGB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D7F0", Offset = "0x6A3C7F0", VA = "0x186A3D7F0")]
	public static float3 KBLEKBOKOPM([In] this RigidTransform KALCJEIICGB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xA21910", Offset = "0xA20910", VA = "0x180A21910")]
	public static (float3, float3, float3) GLIFAACGPCK([In] this RigidTransform KALCJEIICGB)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D790", Offset = "0x6A3C790", VA = "0x186A3D790")]
	public static RigidTransform FEOODJBECJA([In] this RigidTransform KALCJEIICGB)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class LNBDCLHNCII
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D6D0", Offset = "0x6A3C6D0", VA = "0x186A3D6D0")]
	public static RigidTransform DLCGJPGBCAN(RigidTransform JBGKCGCDLKG, RigidTransform IHEFAPCJJKK)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class HAFLFICPLND
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AB10", Offset = "0x6A39B10", VA = "0x186A3AB10")]
	public static float FJNBJEBOFOI([In] this (byte Fourth, byte Third, byte Second, byte First) KALCJEIICGB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6A3ABC0", Offset = "0x6A39BC0", VA = "0x186A3ABC0")]
	public static int PNDAJNLEIDO(this float KALCJEIICGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AB50", Offset = "0x6A39B50", VA = "0x186A3AB50")]
	public static (byte, byte, byte, byte) GPJEMFEHIEA(this float KALCJEIICGB)
	{
		return default((byte, byte, byte, byte));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class IKCOPEMEICA
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB3E0", Offset = "0x2BDA3E0", VA = "0x182BDB3E0")]
	public static ReadOnlySpan<T?> IGBJLECCOBF<T>([In] this Span<T> KALCJEIICGB)
	{
		return default(ReadOnlySpan<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class NDCFEEPELPM
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E100", Offset = "0x6A3D100", VA = "0x186A3E100")]
	public static StringBuilder CIHAGNGKALJ(this StringBuilder KALCJEIICGB, int EMKJNMBCAIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E090", Offset = "0x6A3D090", VA = "0x186A3E090")]
	public static StringBuilder CDGBJAKJBOC(this StringBuilder KALCJEIICGB, int EMKJNMBCAIG, string AFJFNKAODGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E160", Offset = "0x6A3D160", VA = "0x186A3E160")]
	public static StringBuilder HAIGGOMGFJJ(this StringBuilder KALCJEIICGB, char AMLLDPJBEOD, int LMBNCKNPGMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class MEJACNOMLCL
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static Regex FAANKKOBNPO;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static Regex JMBPEAEJCBI;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly char[] JEMFALELDIE;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC010", Offset = "0x5DDB010", VA = "0x185DDC010")]
	public static bool EMJMNNEDACG(this string? BPGDPHKFJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DB00", Offset = "0x6A3CB00", VA = "0x186A3DB00")]
	public static string? EELNKNIMCOG(this string? KALCJEIICGB, int BEFMODGHLMP, string FCJBKKOPPBM = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DA50", Offset = "0x6A3CA50", VA = "0x186A3DA50")]
	public static string DJMOMIHOPEG(this string KALCJEIICGB, int BEFMODGHLMP, string FCJBKKOPPBM = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DCA0", Offset = "0x6A3CCA0", VA = "0x186A3DCA0")]
	public static int KGMDMOFGLKB(this string BPGDPHKFJHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DBE0", Offset = "0x6A3CBE0", VA = "0x186A3DBE0")]
	public static string HLPOMHNNCKK(this string BPGDPHKFJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DD10", Offset = "0x6A3CD10", VA = "0x186A3DD10")]
	public static string[] NJAAPEADDCA(this string BPGDPHKFJHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class FNFBOIBEGNM<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public readonly struct ADCPOIIKBPH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3CEEB10", Offset = "0x3CEDB10", VA = "0x183CEEB10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static int JHJDMBPPIHB;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AOLANEFOLJA HMPJHGOGKGG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static long JKGEBMJBPHL
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E2A0", Offset = "0x3C8D2A0", VA = "0x183C8E2A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E0B0", Offset = "0x3C8D0B0", VA = "0x183C8E0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3C8DF00", Offset = "0x3C8CF00", VA = "0x183C8DF00")]
	public static ADCPOIIKBPH GBDIKDJBIAE()
	{
		return default(ADCPOIIKBPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3C8E110", Offset = "0x3C8D110", VA = "0x183C8E110")]
	private static void KPAKPFMHFMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3C8DE90", Offset = "0x3C8CE90", VA = "0x183C8DE90")]
	public static void CLDDABPDPLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct AOLANEFOLJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly OLIJJAOMKMM HGFKJFKMEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly long HNBMEMMBEOJ;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6A39BE0", Offset = "0x6A38BE0", VA = "0x186A39BE0")]
	public AOLANEFOLJA(OLIJJAOMKMM HPLGJKMDCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6A39B50", Offset = "0x6A38B50", VA = "0x186A39B50")]
	public long PJOMGDBBOED()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6A39A30", Offset = "0x6A38A30", VA = "0x186A39A30")]
	public double CCLHBNFKAAA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6A39AC0", Offset = "0x6A38AC0", VA = "0x186A39AC0")]
	public double KGLABLJFJKO()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class OEPJOPIONHK
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E380", Offset = "0x6A3D380", VA = "0x186A3E380")]
	public static bool AEPHOEFNPNL(this Type KALCJEIICGB, Type ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2D569B0", Offset = "0x2D559B0", VA = "0x182D569B0")]
	public static bool AEPHOEFNPNL<T>(this Type KALCJEIICGB) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class AFGJHGEDIKP
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5A42240", Offset = "0x5A41240", VA = "0x185A42240")]
	public static uint IBFBMNEBPBM(this uint KALCJEIICGB, int DOPPKGNLPAC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5B12C10", Offset = "0x5B11C10", VA = "0x185B12C10")]
	public static uint ILGAJIHOCHL(this uint KALCJEIICGB, int DOPPKGNLPAC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6A39850", Offset = "0x6A38850", VA = "0x186A39850")]
	public static uint HIPGKPOJHJG(this uint KALCJEIICGB, uint AMNAANHMEKK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1127A60", Offset = "0x1126A60", VA = "0x181127A60")]
	public static int PNDAJNLEIDO(this uint KALCJEIICGB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class EJMPKPHNAAG
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2A351A0", Offset = "0x2A341A0", VA = "0x182A351A0")]
	public static bool NLLEMNBGKIP<T>([In] this T? KALCJEIICGB, [Out] T JJCEIJMGOAB) where T : struct
	{
		return default(bool);
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
