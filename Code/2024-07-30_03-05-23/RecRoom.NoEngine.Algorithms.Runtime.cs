using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
		[Cpp2IlInjected.Address(RVA = "0x6ACE420", Offset = "0x6ACCA20", VA = "0x186ACE420")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8917F0", Offset = "0x88FDF0", VA = "0x1808917F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x891830", Offset = "0x88FE30", VA = "0x180891830")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HHJFMKNKONJ
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string[] KFLCDOPJNNE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB100", Offset = "0x6AC9700", VA = "0x186ACB100")]
	public static bool DIALKBHOGCG(string EICGCMMKKNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB320", Offset = "0x6AC9920", VA = "0x186ACB320")]
	private static bool MGMIGCEPKLA(string ELIMFPDKMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB1D0", Offset = "0x6AC97D0", VA = "0x186ACB1D0")]
	public static bool MGMIGCEPKLA(Exception EHGELFGIEBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB3F0", Offset = "0x6AC99F0", VA = "0x186ACB3F0")]
	public static string NHMHGCEHOIH(string KFOCKGMHIBO, string PBJFNDLHABE = "", bool GICEPLKGONK = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EJNGEIHHEJK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAE30", Offset = "0x6AC9430", VA = "0x186ACAE30")]
	public static string JKIMMIDKKNO(this Guid IJNLNGBKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAD90", Offset = "0x6AC9390", VA = "0x186ACAD90")]
	public static string JKIMMIDKKNO(this byte[] LKFNEINGOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6ACACD0", Offset = "0x6AC92D0", VA = "0x186ACACD0")]
	public static byte[] CJFEDHAGMGA(string HCONCKFPEDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class OPFGKIEGNLE
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int GJCAFBJEACP<T>([In] T OIMGCNDKIAD, [In] T LMBIFCGLAFC);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class KKMOIAEOKJI<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct HNLILDLKJMN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly int CMKHMGALFJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public readonly int OCNGKIJHOAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public readonly bool KOEJAMHPLMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int LOLBDDIKJOG;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x3DB40B0", Offset = "0x3DB26B0", VA = "0x183DB40B0")]
			public HNLILDLKJMN(int CMKHMGALFJE, int OCNGKIJHOAH, bool KOEJAMHPLMH)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly T[] OJLNMFBFFPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly T[] CCJIJDJPIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly GJCAFBJEACP<T> CGJEFCMCHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly int MKBIHBCKPBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Func<bool> MPDHJEEKHMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int AEMEBJOGHFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly HNLILDLKJMN[] NPLAFHLBBDA;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x41BE620", Offset = "0x41BCC20", VA = "0x1841BE620")]
		public KKMOIAEOKJI(T[] OJLNMFBFFPC, GJCAFBJEACP<T> CGJEFCMCHDM, int MKBIHBCKPBJ, Func<bool> MPDHJEEKHMB, T[]? BHAGEMEBLFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x41BDFD0", Offset = "0x41BC5D0", VA = "0x1841BDFD0")]
		public bool AKDCEABEGDE()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate U FJCPLCPEFKJ<T, U>(int FBHNACDJJFF, int LKNMOLFIGLE, [In] ReadOnlySpan<T> CEJLIBGEJII);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2D18AF0", Offset = "0x2D170F0", VA = "0x182D18AF0")]
	public static T[] JONHIHHJNOA<T>(int LPKLLJKOBNO, T MLNDPMAHKAO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2D18C90", Offset = "0x2D17290", VA = "0x182D18C90")]
	public static void LJJADLKCMFM<T>(this T[] KPNHENDGNGK, T MLNDPMAHKAO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2D17C50", Offset = "0x2D16250", VA = "0x182D17C50")]
	public static void ELKGKNGIGPD<T>(this T[] FAJBEEIFFCK, int BILDLIKNGJF, int ONHFGGBKMOF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2D18E60", Offset = "0x2D17460", VA = "0x182D18E60")]
	private static void MIDKILDNFIJ<T>(this T[] HLIDMKMINHN, int DCDKJOBPPKO, int CKIJHLIAPAB, T[] BHFGHGMPKOJ, int BAFLMLAIECH, int NDDPOOHNLBM, T[] IAFCFGOKEAK, int NNBLPOFFJCK, GJCAFBJEACP<T> CGJEFCMCHDM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2D17CD0", Offset = "0x2D162D0", VA = "0x182D17CD0")]
	public static void FMBIKHEGJPM<T>(this T[] HLIDMKMINHN, int CMKHMGALFJE, int BMKFLHFENBJ, GJCAFBJEACP<T> CGJEFCMCHDM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2D180E0", Offset = "0x2D166E0", VA = "0x182D180E0")]
	public static KKMOIAEOKJI<T> GCNPDPCCPIB<T>(this T[] HLIDMKMINHN, GJCAFBJEACP<T> CGJEFCMCHDM, int MKBIHBCKPBJ, Func<bool> MPDHJEEKHMB, [Optional] T[]? BHAGEMEBLFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2D19380", Offset = "0x2D17980", VA = "0x182D19380")]
	public static T[] OOKOOKFNINL<T>(this T[] FAJBEEIFFCK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2D19230", Offset = "0x2D17830", VA = "0x182D19230")]
	public static T[] NIIJIDBGMDL<T>(this T[] OALCAHGHKNB, T AGACFJDDJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2D172D0", Offset = "0x2D158D0", VA = "0x182D172D0")]
	public static T[] EJIIBKJAALE<T>(this T[] OALCAHGHKNB, int PDMMEDBMFPP, T AGACFJDDJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2D181A0", Offset = "0x2D167A0", VA = "0x182D181A0")]
	public static T[] JAOIIKPOOLO<T>(this T[] OALCAHGHKNB, int PDMMEDBMFPP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2D18250", Offset = "0x2D16850", VA = "0x182D18250")]
	public static T[] JGOFFCPAMLF<T>(this T[] OALCAHGHKNB, int PDMMEDBMFPP, T AGACFJDDJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2D184F0", Offset = "0x2D16AF0", VA = "0x182D184F0")]
	public static U[] JJAPJJPGOCN<U, T>(this T[] DOCJELGKFHE, int OOMPOADBNOH, FJCPLCPEFKJ<T, U> IKHPJFEIFAK) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE4A0", Offset = "0x6ACCAA0", VA = "0x186ACE4A0")]
	public static byte[] BMDAENMDBKH(this byte[] HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE730", Offset = "0x6ACCD30", VA = "0x186ACE730")]
	public static byte[] HBHLKJEAICD(this byte[] HLIDMKMINHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class EAIEDLBAEFF
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAAB0", Offset = "0x6AC90B0", VA = "0x186ACAAB0")]
	public static byte IMAFFEABDFO(this bool HLIDMKMINHN)
	{
		return default(byte);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DKKAGOCIHGM
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAAB0", Offset = "0x6AC90B0", VA = "0x186ACAAB0")]
	public static bool LDFJLJIKPFI(this byte HLIDMKMINHN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JBDFLONNLNM
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2BF2800", Offset = "0x2BF0E00", VA = "0x182BF2800")]
	public static void DINMKPJFEJA<T>(this ICollection<T> HLIDMKMINHN, IEnumerable<T> HPMBFDPLEJG) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GGAOAKKCFAG
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2B942E0", Offset = "0x2B928E0", VA = "0x182B942E0")]
	public static void IFJPBCIGAEK<K, V>(this IDictionary<K, V> HLIDMKMINHN, [In] K IBBDLGCDELM, [In] V DMNGPNKHPKF, Func<V, V, V> BFNJNEEKDFO) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2B95220", Offset = "0x2B93820", VA = "0x182B95220")]
	public static void MELICFEJDBG<K, V>(this IDictionary<K, List<V>> HLIDMKMINHN, [In] K IBBDLGCDELM, [In] V DMNGPNKHPKF) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2B93640", Offset = "0x2B91C40", VA = "0x182B93640")]
	public static TVal HHGBIKECPHP<TVal, TKey>(this IDictionary<TKey, TVal> CJCKCFPDODL, [In] TKey IBBDLGCDELM, [Optional][FBDLONGKOCP("`default!` shouldn't be necessary in C# 9")] TVal DNKAMNBGFFH) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2B93480", Offset = "0x2B91A80", VA = "0x182B93480")]
	public static TVal HHGBIKECPHP<TVal, TKey>(this IDictionary<TKey, TVal> CJCKCFPDODL, [In] TKey IBBDLGCDELM, Func<TVal> ALOEELALOJG) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2B949C0", Offset = "0x2B92FC0", VA = "0x182B949C0")]
	public static TValue IMMBFKHFHGI<TValue, TKey>(this IDictionary<TKey, TValue> CJCKCFPDODL, [In] TKey IBBDLGCDELM, [Optional][In][FBDLONGKOCP("`default!` and null-oblivious region shouldn't be necessary in C# 9")] TValue DNKAMNBGFFH)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2B92E90", Offset = "0x2B91490", VA = "0x182B92E90")]
	public static V CEFFEEJEDCK<V, K>(this IDictionary<K, V> HLIDMKMINHN, [In] K IBBDLGCDELM) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2B94220", Offset = "0x2B92820", VA = "0x182B94220")]
	public static T2[] HPKFMOENKFN<T2, T1>(this Dictionary<T1, T2>.ValueCollection FPAOAMOONJD) where T2 : notnull where T1 : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CMFKOABCMFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate bool GJOANENLMDI<TArgs, T>([In] TArgs CNKOAIGMGCF, T JAGONPFFNPO);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate U OHJFHMKKEBN<TArg, U>([In] TArg CIFNGMCMOJD);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate U GDBCNKIGOIE<TArg, T, U>([In] TArg CIFNGMCMOJD, T NJJGFJOBMOG);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate U PFIIJAAGKJD<TArg, T, U>([In] TArg CIFNGMCMOJD, IEnumerable<T> LDBHIOMIKEG);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate U MJGKPKCDGJA<TArg, T, U>([In] TArg CIFNGMCMOJD, T NJJGFJOBMOG);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct OKEPENDAKCO<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x46DF380", Offset = "0x46DD980", VA = "0x1846DF380")]
		[FBDLONGKOCP("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) IBMJEAMIIFD(T ODEABLHEFGJ)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x46DF320", Offset = "0x46DD920", VA = "0x1846DF320")]
		[FBDLONGKOCP("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) BDELNFAEGAL(IEnumerable<T> LKHMCPMGNJL)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class BKNOCMKALIM<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0xAB5610", Offset = "0xAB3C10", VA = "0x180AB5610", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F27FC0", Offset = "0x4F265C0", VA = "0x184F27FC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xAB5750", Offset = "0xAB3D50", VA = "0x180AB5750")]
		[DebuggerHidden]
		public BKNOCMKALIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x38769E0", Offset = "0x3874FE0", VA = "0x1838769E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4F271E0", Offset = "0x4F257E0", VA = "0x184F271E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4F26D00", Offset = "0x4F25300", VA = "0x184F26D00")]
		private void LEGBLNHPDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4F27F30", Offset = "0x4F26530", VA = "0x184F27F30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4F27D90", Offset = "0x4F26390", VA = "0x184F27D90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x41C10F0", Offset = "0x41BF6F0", VA = "0x1841C10F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class JHPCKBBINKI<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8BEBB0", Offset = "0x8BD1B0", VA = "0x1808BEBB0")]
		[DebuggerHidden]
		public JHPCKBBINKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x40918C0", Offset = "0x408FEC0", VA = "0x1840918C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4090A70", Offset = "0x408F070", VA = "0x184090A70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x40909D0", Offset = "0x408EFD0", VA = "0x1840909D0")]
		private void LEGBLNHPDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4090870", Offset = "0x408EE70", VA = "0x184090870")]
		private void DLKKNIILKCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4091870", Offset = "0x408FE70", VA = "0x184091870", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x40915D0", Offset = "0x408FBD0", VA = "0x1840915D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3B01F50", Offset = "0x3B00550", VA = "0x183B01F50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class DOODLMBDBPJ<T> : IEnumerable<(T, MADCGGOAHGO<T>)>, IEnumerable, IEnumerator<(T, MADCGGOAHGO<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private (T Current, MADCGGOAHGO<T> Next) <>2__current;

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
		private (T, MADCGGOAHGO<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x38ECC50", Offset = "0x38EB250", VA = "0x1838ECC50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, MADCGGOAHGO<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x58F1A20", Offset = "0x58F0020", VA = "0x1858F1A20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1ECEDE0", Offset = "0x1ECD3E0", VA = "0x181ECEDE0")]
		[DebuggerHidden]
		public DOODLMBDBPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3B002A0", Offset = "0x3AFE8A0", VA = "0x183B002A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x58F0B20", Offset = "0x58EF120", VA = "0x1858F0B20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x58EFFF0", Offset = "0x58EE5F0", VA = "0x1858EFFF0")]
		private void LEGBLNHPDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x58F18E0", Offset = "0x58EFEE0", VA = "0x1858F18E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x58F1800", Offset = "0x58EFE00", VA = "0x1858F1800", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, MADCGGOAHGO<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3B01F50", Offset = "0x3B00550", VA = "0x183B01F50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class IJKDACMOGJM<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
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
		private Func<OKEPENDAKCO<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Func<OKEPENDAKCO<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

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
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8BEBB0", Offset = "0x8BD1B0", VA = "0x1808BEBB0")]
		[DebuggerHidden]
		public IJKDACMOGJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3E7BB40", Offset = "0x3E7A140", VA = "0x183E7BB40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B660", Offset = "0x3E79C60", VA = "0x183E7B660", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B610", Offset = "0x3E79C10", VA = "0x183E7B610")]
		private void LEGBLNHPDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B5C0", Offset = "0x3E79BC0", VA = "0x183E7B5C0")]
		private void DLKKNIILKCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7BAF0", Offset = "0x3E7A0F0", VA = "0x183E7BAF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E2D0", Offset = "0x3C4C8D0", VA = "0x183C4E2D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E8F0", Offset = "0x3C4CEF0", VA = "0x183C4E8F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DBBCEIGDABA<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public DBBCEIGDABA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4801B00", Offset = "0x4800100", VA = "0x184801B00")]
		internal bool KOOPJBCDLKD(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x58A8FC0", Offset = "0x58A75C0", VA = "0x1858A8FC0")]
		internal bool JLPBCFBLNME(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CPFHLKNEBHA<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0xC70640", Offset = "0xC6EC40", VA = "0x180C70640", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C4AF00", Offset = "0x3C49500", VA = "0x183C4AF00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1ECEDE0", Offset = "0x1ECD3E0", VA = "0x181ECEDE0")]
		[DebuggerHidden]
		public CPFHLKNEBHA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x569B930", Offset = "0x5699F30", VA = "0x18569B930", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x569BC40", Offset = "0x569A240", VA = "0x18569BC40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x569BB60", Offset = "0x569A160", VA = "0x18569BB60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3B01F50", Offset = "0x3B00550", VA = "0x183B01F50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x29B90A0", Offset = "0x29B76A0", VA = "0x1829B90A0")]
	public static bool NBBOFDGMODK<T, TArgs>(this IEnumerable<T> HLIDMKMINHN, [In] TArgs CNKOAIGMGCF, GJOANENLMDI<TArgs, T> NBMLMFBKJBE) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA110", Offset = "0x6AC8710", VA = "0x186ACA110")]
	public static bool NBBOFDGMODK(this IEnumerable<bool> HLIDMKMINHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x29B88F0", Offset = "0x29B6EF0", VA = "0x1829B88F0")]
	public static U MLMDGIOGKON<U, T>(this IEnumerable<T> HLIDMKMINHN, Func<U> OIPAGELBPCJ, Func<T, U> ODEABLHEFGJ, Func<IEnumerable<T>, U> LKHMCPMGNJL) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x29B65B0", Offset = "0x29B4BB0", VA = "0x1829B65B0")]
	public static bool JDDHHNEBEDM<T, TArgs>(this IEnumerable<T> HLIDMKMINHN, [In] TArgs CNKOAIGMGCF, GJOANENLMDI<TArgs, T> NBMLMFBKJBE) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x29B77A0", Offset = "0x29B5DA0", VA = "0x1829B77A0")]
	public static U LKNJAEIKGLE<U, T, TArg>(this IEnumerable<T> HLIDMKMINHN, [In] TArg CIFNGMCMOJD, OHJFHMKKEBN<TArg, U> OIPAGELBPCJ, GDBCNKIGOIE<TArg, T, U> ODEABLHEFGJ, PFIIJAAGKJD<TArg, T, U> LKHMCPMGNJL) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x29B5660", Offset = "0x29B3C60", VA = "0x1829B5660")]
	public static IEnumerable<U> FGGHKIIKCKG<U, T, TArg>(this IEnumerable<T> HLIDMKMINHN, [In] TArg CIFNGMCMOJD, MJGKPKCDGJA<TArg, T, U> JJPJJLMIMIP) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x29B75E0", Offset = "0x29B5BE0", VA = "0x1829B75E0")]
	public static IEnumerable<T> LKEPEFHIOAC<T>(params IEnumerable<T>[] MLGPABCEEDH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x29B33C0", Offset = "0x29B19C0", VA = "0x1829B33C0")]
	public static bool ALJCFAENMFH<T>(this IEnumerable<T> MADFKNCBFBG, IEnumerable<T> BHFGHGMPKOJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x29B75E0", Offset = "0x29B5BE0", VA = "0x1829B75E0")]
	public static IEnumerable<(TKey?, TValue?)>? OAEBBCOBPLG<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x29B9E50", Offset = "0x29B8450", VA = "0x1829B9E50")]
	public static IEnumerable<T> POKPGOELNFD<T, TKey>(this IEnumerable<T> KOIKDJBNAGC, Func<T, TKey> PPLBHBOCHFJ) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x29B60C0", Offset = "0x29B46C0", VA = "0x1829B60C0")]
	[IteratorStateMachine(typeof(BKNOCMKALIM<>))]
	public static IEnumerable<T> HFCLIEDKBAJ<T>(this IEnumerable<T> MADFKNCBFBG, ISet<T> JDGKLLKEGLH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x29B9740", Offset = "0x29B7D40", VA = "0x1829B9740")]
	[IteratorStateMachine(typeof(JHPCKBBINKI<, >))]
	public static IEnumerable<T> OAOOBLLLAPM<T, U>(this IEnumerable<T> HLIDMKMINHN, IEnumerable<U> BHFGHGMPKOJ, [Optional][FBDLONGKOCP("`default!` shouldn't be necessary in C# 9")] T MLNDPMAHKAO) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x28D5430", Offset = "0x28D3A30", VA = "0x1828D5430")]
	public static T KKJGGPMGAHG<T>(this IEnumerable<T> MADFKNCBFBG, T DNKAMNBGFFH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x29B7560", Offset = "0x29B5B60", VA = "0x1829B7560")]
	public static T KKJGGPMGAHG<T>(this IEnumerable<T> MADFKNCBFBG, T DNKAMNBGFFH, Func<T, bool> NBMLMFBKJBE) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x29B3EF0", Offset = "0x29B24F0", VA = "0x1829B3EF0")]
	public static T? EDJHPCPMNAO<T>(this IEnumerable<T> HLIDMKMINHN, Func<T, bool> NBMLMFBKJBE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x29B4C10", Offset = "0x29B3210", VA = "0x1829B4C10")]
	public static void EIFFFLDKLCP<T>(this IEnumerable<T> HLIDMKMINHN, Action<T> IEIDMMIDFNN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x29B3710", Offset = "0x29B1D10", VA = "0x1829B3710")]
	[IteratorStateMachine(typeof(DOODLMBDBPJ<>))]
	public static IEnumerable<(T, MADCGGOAHGO<T>)> DAHMKNNPNAA<T>(this IEnumerable<T> HLIDMKMINHN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x29B9520", Offset = "0x29B7B20", VA = "0x1829B9520")]
	public static bool NCJMCDKCCDO<T>(this IEnumerable<T> HLIDMKMINHN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x29B75E0", Offset = "0x29B5BE0", VA = "0x1829B75E0")]
	public static IEnumerable<DFBDAEGMHFC<T>> MIMJDCDEIKK<T>(this IEnumerable<T> HLIDMKMINHN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x29B6300", Offset = "0x29B4900", VA = "0x1829B6300")]
	public static bool HIFFGJEKBHK<T>(this IEnumerable<T> HLIDMKMINHN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x29B7CA0", Offset = "0x29B62A0", VA = "0x1829B7CA0")]
	public static IEnumerable<T> LLCALJKGBPM<T>(this IEnumerable<T>? HLIDMKMINHN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x29B9D90", Offset = "0x29B8390", VA = "0x1829B9D90")]
	[IteratorStateMachine(typeof(IJKDACMOGJM<, >))]
	public static IEnumerable<U> PLGIGMOOGJD<U, T>(this IEnumerable<T> HLIDMKMINHN, Func<OKEPENDAKCO<U>, T, (bool Zero, U One, IEnumerable<U> Many)> MINAAMGFPMO) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x29B5BA0", Offset = "0x29B41A0", VA = "0x1829B5BA0")]
	public static int GDHFBIDCPHK<T>(this IEnumerable<T> HLIDMKMINHN, int BCFEGNONCAL = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x29B6340", Offset = "0x29B4940", VA = "0x1829B6340")]
	public static bool HNHIFLJCMJM<T>(this IEnumerable<T> HLIDMKMINHN, IEnumerable<T> BHFGHGMPKOJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x29B35F0", Offset = "0x29B1BF0", VA = "0x1829B35F0")]
	public static IEnumerable<T> CEKDINAMLJE<T>(this IEnumerable<T> HLIDMKMINHN, int GAEKGDIHMFA, int IDGFEKFNCNA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x29B7CE0", Offset = "0x29B62E0", VA = "0x1829B7CE0")]
	public static (IEnumerable<T>, IEnumerable<T>) LMENICJBJIP<T>(this IEnumerable<T> HLIDMKMINHN, Func<T, bool> HEKCGEHIKCL) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x29B6D10", Offset = "0x29B5310", VA = "0x1829B6D10")]
	public static string JFMBCANKHJI<T>(this IEnumerable<T> HLIDMKMINHN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x29B7260", Offset = "0x29B5860", VA = "0x1829B7260")]
	public static Dictionary<TKey?, TValue?>? JGKEPNNBAGP<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> MADFKNCBFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x29B7260", Offset = "0x29B5860", VA = "0x1829B7260")]
	public static Dictionary<TKey?, TValue?>? JGKEPNNBAGP<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> MADFKNCBFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x29B38F0", Offset = "0x29B1EF0", VA = "0x1829B38F0")]
	public static List<T> DDCKMCFFKJM<T>(this IEnumerable<T> HLIDMKMINHN, int PLGOIBDCNBN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x29B35B0", Offset = "0x29B1BB0", VA = "0x1829B35B0")]
	public static string BPEJDGJHNEO<T>(this IEnumerable<T> HLIDMKMINHN, string HGCEHLCNFGA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x29B8010", Offset = "0x29B6610", VA = "0x1829B8010")]
	public static (IReadOnlyList<T?>?, IReadOnlyList<U?>?) LNDAJKHHJBM<T, U>(this IEnumerable<(T Lhs, U Rhs)> HLIDMKMINHN)
	{
		return default((IReadOnlyList<T>, IReadOnlyList<U>));
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x29B6000", Offset = "0x29B4600", VA = "0x1829B6000")]
	[IteratorStateMachine(typeof(CPFHLKNEBHA<, >))]
	public static IEnumerable<(T, U)> GGEMHHGCKCA<T, U>(this IEnumerable<T> OIMGCNDKIAD, IEnumerable<U> LMBIFCGLAFC) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x29B9AE0", Offset = "0x29B80E0", VA = "0x1829B9AE0")]
	public static IEnumerable<V> PIBPONFCINN<V, T, U>(this IEnumerable<T> HLIDMKMINHN, IEnumerable<U> BHFGHGMPKOJ, Func<T, U, V> MGFONDGJGKH, [Optional][FBDLONGKOCP("`default!` shouldn't be necessary in C# 9")] T MOMOOMPFEOB, [Optional][FBDLONGKOCP("`default!` shouldn't be necessary in C# 9")] U BELPKFOPJGJ) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x29B9BB0", Offset = "0x29B81B0", VA = "0x1829B9BB0")]
	public static IEnumerable<(T, U)> PIBPONFCINN<T, U>(this IEnumerable<T> HLIDMKMINHN, IEnumerable<U> BHFGHGMPKOJ, [Optional][FBDLONGKOCP("`default!` shouldn't be necessary in C# 9")] T MOMOOMPFEOB, [Optional][FBDLONGKOCP("`default!` shouldn't be necessary in C# 9")] U BELPKFOPJGJ) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x29B39B0", Offset = "0x29B1FB0", VA = "0x1829B39B0")]
	public static TOut[] DDJMADIINEE<TOut, TIn>(this IEnumerable<TIn> KOIKDJBNAGC, Func<TIn, TOut> EHKLKBCMEOO) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class JDIKOHDMPHG
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2BF4A80", Offset = "0x2BF3080", VA = "0x182BF4A80")]
	public static bool GFKMFHDDDJP<T, U>(this T HLIDMKMINHN, [In] U NJKKPOFFNNJ) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2BF49E0", Offset = "0x2BF2FE0", VA = "0x182BF49E0")]
	public static bool CLPIEBDICAL<T>(T HLIDMKMINHN, T BHFGHGMPKOJ) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class KOIEPNFFDHM
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xB77A50", Offset = "0xB76050", VA = "0x180B77A50")]
	public static bool DFCHILPPEOF([In] this float3 KHKPJFABMKM, float3 CGBLKAAFCDI, float AFCLPKCMJKH = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class NKCMALGNDBA
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class KDHJJBECDOB<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x8FBA90", Offset = "0x8FA090", VA = "0x1808FBA90", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C3E780", Offset = "0x3C3CD80", VA = "0x183C3E780", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xABDB90", Offset = "0xABC190", VA = "0x180ABDB90")]
		[DebuggerHidden]
		public KDHJJBECDOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x416E460", Offset = "0x416CA60", VA = "0x18416E460", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x416E600", Offset = "0x416CC00", VA = "0x18416E600", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x416E490", Offset = "0x416CA90", VA = "0x18416E490", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x38758E0", Offset = "0x3873EE0", VA = "0x1838758E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9A70", Offset = "0x2CD8070", VA = "0x182CD9A70")]
	public static void LNPEKKNMNOI<T>(this T FCNFHCDDANP, Action<T> HCELNLPCEBC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9990", Offset = "0x2CD7F90", VA = "0x182CD9990")]
	public static V JEONEHGDOLH<V, T>(this T FCNFHCDDANP, Func<T, V> HCELNLPCEBC, [Optional][FBDLONGKOCP("`default!` shouldn't be necessary in C# 9")] V DNKAMNBGFFH) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9880", Offset = "0x2CD7E80", VA = "0x182CD9880")]
	public static T? HEKJDKOJAAN<T>(this T HLIDMKMINHN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2CD97F0", Offset = "0x2CD7DF0", VA = "0x182CD97F0")]
	[IteratorStateMachine(typeof(KDHJJBECDOB<>))]
	public static IEnumerable<T> CMCKCJHOKCG<T>(this T HLIDMKMINHN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9730", Offset = "0x2CD7D30", VA = "0x182CD9730")]
	public static T[] AFHDKIGCICH<T>(this T HLIDMKMINHN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class LIONMAFHDEF
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD060", Offset = "0x6ACB660", VA = "0x186ACD060")]
	private static byte[] NOOCGHLMAAO(int NLBDLEHMFMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6ACCF00", Offset = "0x6ACB500", VA = "0x186ACCF00")]
	private static byte[] IMGHHABEDGK(long HKIHBNFIKAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD0E0", Offset = "0x6ACB6E0", VA = "0x186ACD0E0")]
	private static byte[] OOEAKDKLOFF(ulong HKIHBNFIKAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC6A0", Offset = "0x6ACACA0", VA = "0x186ACC6A0")]
	public static Guid ADBEBPIEBDH(params Guid[] JLDFHBBHAIC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC810", Offset = "0x6ACAE10", VA = "0x186ACC810")]
	public static Guid BBHPEKFPBBP([In] Guid BCDCEEJOEGM, int PDMMEDBMFPP, int CICFELNCFMD = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6ACCD60", Offset = "0x6ACB360", VA = "0x186ACCD60")]
	public static Guid BBHPEKFPBBP([In] Guid BCDCEEJOEGM, long PDMMEDBMFPP, int CICFELNCFMD = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6ACCE30", Offset = "0x6ACB430", VA = "0x186ACCE30")]
	public static Guid BBHPEKFPBBP([In] Guid BCDCEEJOEGM, ulong PDMMEDBMFPP, int CICFELNCFMD = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6ACCCF0", Offset = "0x6ACB2F0", VA = "0x186ACCCF0")]
	public static Guid BBHPEKFPBBP([In] Guid BCDCEEJOEGM, [In] Guid DNEJCLFBLGI, int CICFELNCFMD = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC8E0", Offset = "0x6ACAEE0", VA = "0x186ACC8E0")]
	private static Guid BBHPEKFPBBP([In] Guid BCDCEEJOEGM, byte[] CKOMACBPJMG, int CICFELNCFMD = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6ACCFD0", Offset = "0x6ACB5D0", VA = "0x186ACCFD0")]
	private static void NMJKNINBMLO(byte[] IJNLNGBKEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6ACCF80", Offset = "0x6ACB580", VA = "0x186ACCF80")]
	private static void MMHEODLCCGO(byte[] IJNLNGBKEAC, int CLMMPLJCADB, int NIGNLACGOIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class EIPJFIBJKNF
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAB40", Offset = "0x6AC9140", VA = "0x186ACAB40")]
	public static int EGPCEHFHCNO(this int HLIDMKMINHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAC90", Offset = "0x6AC9290", VA = "0x186ACAC90")]
	public static int OFBBFDHPKGA(this int HLIDMKMINHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAC40", Offset = "0x6AC9240", VA = "0x186ACAC40")]
	public static int NMOGDNIOPEC(this int HLIDMKMINHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6ACABB0", Offset = "0x6AC91B0", VA = "0x186ACABB0")]
	public static int EONAMAPJNOO(this int HLIDMKMINHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5AD2C90", Offset = "0x5AD1290", VA = "0x185AD2C90")]
	public static int CJPHDCNMABN(this int HLIDMKMINHN, int BMKFLHFENBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5BA3470", Offset = "0x5BA1A70", VA = "0x185BA3470")]
	public static int CJONKHFFGBK(this int HLIDMKMINHN, int BMKFLHFENBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAB00", Offset = "0x6AC9100", VA = "0x186ACAB00")]
	public static float APOAFILGKOL(this int HLIDMKMINHN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6ACABD0", Offset = "0x6AC91D0", VA = "0x186ACABD0")]
	public static (byte, byte, byte, byte) KHJNOEHKOKH(this int HLIDMKMINHN)
	{
		return default((byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAB20", Offset = "0x6AC9120", VA = "0x186ACAB20")]
	public static int CJFDMHEHMDG([In] this (byte Fourth, byte Third, byte Second, byte First) HLIDMKMINHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6ACABC0", Offset = "0x6AC91C0", VA = "0x186ACABC0")]
	public static int INEJMLINHCD(this int HLIDMKMINHN, int JPIPMIMOPPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAAF0", Offset = "0x6AC90F0", VA = "0x186ACAAF0")]
	public static int AEIILDEJKHB(this int HLIDMKMINHN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface KDBINEJPJAA
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OCFJFMFNEAC(int GOHPOHFAOGE, int BOKNAKJOHLN);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float OJPEHCMDIBL(float NJOKCLEIODE, float LBCAJDPKELL);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HNCBMJLOOPO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	long JHOFALLNMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class DDDMOPDGOMF
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x29E69C0", Offset = "0x29E4FC0", VA = "0x1829E69C0")]
	public static (TKey?, TValue?) NNAGGHDPJHJ<TKey, TValue>([In] this KeyValuePair<TKey, TValue> HLIDMKMINHN)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x29E6990", Offset = "0x29E4F90", VA = "0x1829E6990")]
	public static KeyValuePair<TKey?, UValue?> MBPOJPPJIEI<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> HLIDMKMINHN, UValue DMNGPNKHPKF)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class CIPABEGBAJO
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class COOJBEMCJEL<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public COOJBEMCJEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x569B380", Offset = "0x5699980", VA = "0x18569B380")]
		internal TElement AGLGOJGNMIP(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x29AC390", Offset = "0x29AA990", VA = "0x1829AC390")]
	public static int IDEKBOKIJDP<T>(this IReadOnlyList<T> FAJBEEIFFCK, T DMNGPNKHPKF) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x29A8870", Offset = "0x29A6E70", VA = "0x1829A8870")]
	public static int DJHGOLFEKHH<T>(this IReadOnlyList<T> FAJBEEIFFCK, T DMNGPNKHPKF) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x29A7750", Offset = "0x29A5D50", VA = "0x1829A7750")]
	public static void DINMKPJFEJA<T>(this HashSet<T> HHLGEGFINMO, IEnumerable<T> HPMBFDPLEJG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x29ABC60", Offset = "0x29AA260", VA = "0x1829ABC60")]
	public static void HLCHDKJPFDO<T>(this IList<T> DEPHDEBCNCK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x29AB910", Offset = "0x29A9F10", VA = "0x1829AB910")]
	public static void HLCHDKJPFDO<T>(this IList<T> DEPHDEBCNCK, int KFEAPOCPNLF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x29AD2E0", Offset = "0x29AB8E0", VA = "0x1829AD2E0")]
	public static void LAINJCODBDG<T>(this List<T> DEPHDEBCNCK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x29AE150", Offset = "0x29AC750", VA = "0x1829AE150")]
	public static List<T> MKFIENEKIHP<T>(this List<T> HFCJLCCNCMK, Predicate<T> ANEJKKIANME) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x29ACB60", Offset = "0x29AB160", VA = "0x1829ACB60")]
	public static int IDEKBOKIJDP<T>(this IReadOnlyList<T> DEPHDEBCNCK, Predicate<T> NBMLMFBKJBE) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x29A6C00", Offset = "0x29A5200", VA = "0x1829A6C00")]
	public static bool BCDEAGECPHG<T>(this IReadOnlyList<T> DEPHDEBCNCK, Predicate<T> NBMLMFBKJBE, [Out][NotNullWhen(true)] List<int>? FLNOIJGKJIO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x29AE0D0", Offset = "0x29AC6D0", VA = "0x1829AE0D0")]
	public static bool LGJHGFMDMBF<T>(this IReadOnlyList<T> DEPHDEBCNCK, T JAGONPFFNPO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x29ADF70", Offset = "0x29AC570", VA = "0x1829ADF70")]
	public static bool LGJHGFMDMBF<T>(this IReadOnlyList<T> DEPHDEBCNCK, T JAGONPFFNPO, EqualityComparer<T> PAEANBLKLHD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x29AEB40", Offset = "0x29AD140", VA = "0x1829AEB40")]
	public static int PAKJJCHGDCO<TElement, TKey>(this IList<TElement> HJEKPIODIKM, TKey AGAIGHCJFIK, Func<TElement, TKey> NDOGKAMKJDH, [Optional] Func<TKey, TKey, int>? CGJEFCMCHDM, int PDMMEDBMFPP = 0, [Optional] int? BMKFLHFENBJ) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x29AE7A0", Offset = "0x29ACDA0", VA = "0x1829AE7A0")]
	public static int PAKJJCHGDCO<TElement, TKey>(Func<int, TElement> EMBFACLCNJK, int NLCKFGKHLDK, TKey AGAIGHCJFIK, Func<TElement, TKey> NDOGKAMKJDH, [Optional] Func<TKey, TKey, int>? CGJEFCMCHDM, int PDMMEDBMFPP = 0, [Optional] int? BMKFLHFENBJ) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x29AC220", Offset = "0x29AA820", VA = "0x1829AC220")]
	public static bool ICMHKHKFPMA<T>(this List<T> DEPHDEBCNCK, T JAGONPFFNPO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x29AE570", Offset = "0x29ACB70", VA = "0x1829AE570")]
	public static void PAANHBENLKP<T>(this List<T> DEPHDEBCNCK, IEnumerable<T> HFCJLCCNCMK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x29AB710", Offset = "0x29A9D10", VA = "0x1829AB710")]
	public static void HHOKGKJNBNI<T>(this List<T> DEPHDEBCNCK, IEnumerable<T> HFCJLCCNCMK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x29AB4C0", Offset = "0x29A9AC0", VA = "0x1829AB4C0")]
	public static T GPBLICPDAMJ<T>(this List<T> HFCJLCCNCMK, Predicate<T> ANEJKKIANME) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x29A7310", Offset = "0x29A5910", VA = "0x1829A7310")]
	public static T BOHODNMGHCE<T>(this List<T> HFCJLCCNCMK, int PDMMEDBMFPP) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x29A70A0", Offset = "0x29A56A0", VA = "0x1829A70A0")]
	public static void BCLFMGIHKHF<T>(this List<T> DEPHDEBCNCK, int PDMMEDBMFPP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x29A73B0", Offset = "0x29A59B0", VA = "0x1829A73B0")]
	public static bool CFNNHGKJNJK<T>(this List<T> HDOICFHCGBI, List<T> ODAALHFHELH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x29AB420", Offset = "0x29A9A20", VA = "0x1829AB420")]
	public static T EOHPKNADHDO<T>(this IList<T> DEPHDEBCNCK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x29A68D0", Offset = "0x29A4ED0", VA = "0x1829A68D0")]
	public static bool ADGGONKDPAK<T>(IReadOnlyList<T>? DEPHDEBCNCK, int PDMMEDBMFPP, [Out][MaybeNullWhen(false)][FBDLONGKOCP("This should be `T?` in C# 9.")] T IAFCFGOKEAK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x29A9D50", Offset = "0x29A8350", VA = "0x1829A9D50")]
	public static bool DOGBGGLEOPN<T>(IReadOnlyList<T> DEPHDEBCNCK, ICollection HFCJLCCNCMK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x29AD110", Offset = "0x29AB710", VA = "0x1829AD110")]
	public static void KOIBCNMDPCK<T>(IReadOnlyList<T> DEPHDEBCNCK, ICollection HFCJLCCNCMK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x29A72C0", Offset = "0x29A58C0", VA = "0x1829A72C0")]
	public static bool BINCBIJFEPE<T>(this IReadOnlyList<T> DEPHDEBCNCK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x29AB550", Offset = "0x29A9B50", VA = "0x1829AB550")]
	public static string HFDKNLFLBII<T>(this IEnumerable<T> DEPHDEBCNCK, string IMBOBCBBAPA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x29AB2B0", Offset = "0x29A98B0", VA = "0x1829AB2B0")]
	public static T EEBLMCMELNG<T>(this IList<T> HLIDMKMINHN) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x29A74A0", Offset = "0x29A5AA0", VA = "0x1829A74A0")]
	public static T CNILMGIJKOL<T>(this IList<T> HLIDMKMINHN) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x29A76C0", Offset = "0x29A5CC0", VA = "0x1829A76C0")]
	public static void DGMDCEKGOGK<T>(this IList<T> HLIDMKMINHN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x29AE2D0", Offset = "0x29AC8D0", VA = "0x1829AE2D0")]
	public static void NBKCKPDLFAN<T>(this IList<T> HLIDMKMINHN, [In] T DMNGPNKHPKF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x29AE470", Offset = "0x29ACA70", VA = "0x1829AE470")]
	public static T NHEDNECIHMH<T>(this IList<T> HLIDMKMINHN) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x29A6980", Offset = "0x29A4F80", VA = "0x1829A6980")]
	public static void AEHIEAMFEHJ<T>(this List<T> HLIDMKMINHN) where T : struct, IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class DAJPEKLLMCO
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static float NODFHBMJADK;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static float LEBLJOIGPNI;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static bool AHLJIELAHDO;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly float DKGLAGLAOOK;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA610", Offset = "0x6AC8C10", VA = "0x186ACA610")]
	public static bool EDOPGDLCELE(float KHKPJFABMKM, float CGBLKAAFCDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA830", Offset = "0x6AC8E30", VA = "0x186ACA830")]
	public static float GJIANMOPLHL(float DMNGPNKHPKF, float KNJOHLDIOOJ, float JEAHIMKCJFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA810", Offset = "0x6AC8E10", VA = "0x186ACA810")]
	public static int GJIANMOPLHL(int DMNGPNKHPKF, int KNJOHLDIOOJ, int JEAHIMKCJFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA870", Offset = "0x6AC8E70", VA = "0x186ACA870")]
	public static float NCLEEGPKDGF(float DMNGPNKHPKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA570", Offset = "0x6AC8B70", VA = "0x186ACA570")]
	public static float DDLGHPMLFGO(float KHKPJFABMKM, float CGBLKAAFCDI, float FCNFHCDDANP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA700", Offset = "0x6AC8D00", VA = "0x186ACA700")]
	public static float EKAPLBOLNLI(float KHKPJFABMKM, float CGBLKAAFCDI, float FCNFHCDDANP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA710", Offset = "0x6AC8D10", VA = "0x186ACA710")]
	public static float FIFJGLEBOFN(float KHKPJFABMKM, float CGBLKAAFCDI, float DMNGPNKHPKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA7D0", Offset = "0x6AC8DD0", VA = "0x186ACA7D0")]
	public static float GGFIGJOLBED(float KHKPJFABMKM, float CGBLKAAFCDI, float DMNGPNKHPKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA850", Offset = "0x6AC8E50", VA = "0x186ACA850")]
	public static float HNAPOCOPFEM(float KHKPJFABMKM, float CGBLKAAFCDI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA3B0", Offset = "0x6AC89B0", VA = "0x186ACA3B0")]
	public static float DCKFFNKJNEH(float FENOAMJHLHH, float PABFDMCLKCE, float BLNOMMBFNGI, float NIFIHGLEKJJ, float JCENBACKGJB, float JOOMCFPDCGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA320", Offset = "0x6AC8920", VA = "0x186ACA320")]
	public static float CADIMCBFDIB(float DMNGPNKHPKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA230", Offset = "0x6AC8830", VA = "0x186ACA230")]
	public static float BBOICNDPHAP(float DMNGPNKHPKF, float KNJOHLDIOOJ, float JEAHIMKCJFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA890", Offset = "0x6AC8E90", VA = "0x186ACA890")]
	public static float PFBEAMKCNJN(float FDCPHJBLCDC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class LBAPCNMOIHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private System.Random AKBJBIHNLLG;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC380", Offset = "0x6ACA980", VA = "0x186ACC380")]
	public LBAPCNMOIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC300", Offset = "0x6ACA900", VA = "0x186ACC300")]
	public LBAPCNMOIHJ(int KFEAPOCPNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x62435D0", Offset = "0x6241BD0", VA = "0x1862435D0", Slot = "4")]
	public virtual int OCFJFMFNEAC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC2A0", Offset = "0x6ACA8A0", VA = "0x186ACC2A0", Slot = "5")]
	public virtual int OCFJFMFNEAC(int BOKNAKJOHLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC2D0", Offset = "0x6ACA8D0", VA = "0x186ACC2D0", Slot = "6")]
	public virtual int OCFJFMFNEAC(int GOHPOHFAOGE, int BOKNAKJOHLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC270", Offset = "0x6ACA870", VA = "0x186ACC270")]
	public double FEHNEBAJNFC()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class ONFJOONGPMC
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2D160E0", Offset = "0x2D146E0", VA = "0x182D160E0")]
	[DFMFJMBJIGJ("This should be replaced with the `is not` operator in C# 9.")]
	public static bool GIAHBCLPIBG<T>(this object HLIDMKMINHN, [Out][NotNullWhen(true)] T IAFCFGOKEAK) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class NNBBIBKDAGE
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE090", Offset = "0x6ACC690", VA = "0x186ACE090")]
	public static (float3, float3, float3) ILLPGIIPPPH([In] this quaternion HLIDMKMINHN)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD670", Offset = "0x6ACBC70", VA = "0x186ACD670")]
	private static float3 HEOKEOJJPMN(quaternion KIIMFDBBHLO, math.RotationOrder LPBJOLNKPAA = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD5A0", Offset = "0x6ACBBA0", VA = "0x186ACD5A0")]
	private static float3 DDLCAKGCABI(float3 BHNMPAFOJLI, math.RotationOrder LPBJOLNKPAA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE180", Offset = "0x6ACC780", VA = "0x186ACE180")]
	public static float3 INEEBKIHFCE(this quaternion KIIMFDBBHLO, math.RotationOrder LPBJOLNKPAA = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE240", Offset = "0x6ACC840", VA = "0x186ACE240")]
	public static float PHJGIENLDHL(this quaternion OIMGCNDKIAD, quaternion LMBIFCGLAFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6ACE390", Offset = "0x6ACC990", VA = "0x186ACE390")]
	[CompilerGenerated]
	internal static float3 PLMMGJKPDKA(float3 BHNMPAFOJLI)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class IEENCDOALED
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private sealed class MMFKAHNEMGN : KDBINEJPJAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly System.Random DAENDMOAPIE;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC2D0", Offset = "0x6ACA8D0", VA = "0x186ACC2D0", Slot = "4")]
		public int OCFJFMFNEAC(int NJOKCLEIODE, int LAFKCEIOMHI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD370", Offset = "0x6ACB970", VA = "0x186ACD370", Slot = "5")]
		public float OJPEHCMDIBL(float NJOKCLEIODE, float LBCAJDPKELL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD330", Offset = "0x6ACB930", VA = "0x186ACD330")]
		private double LHFLHCAFDBP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD3E0", Offset = "0x6ACB9E0", VA = "0x186ACD3E0")]
		public MMFKAHNEMGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly KDBINEJPJAA HKDCCGPIHMD;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB940", Offset = "0x6AC9F40", VA = "0x186ACB940")]
	public static ulong IJHDCLMPFNH()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class LCMPIMEEOKG
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2C3CFA0", Offset = "0x2C3B5A0", VA = "0x182C3CFA0")]
	public static bool MKGHOEPPJCJ<T>(this IReadOnlyCollection<T> HLIDMKMINHN, int PDMMEDBMFPP) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class LNGKNIKEPEL
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2C59990", Offset = "0x2C57F90", VA = "0x182C59990")]
	public static bool LKGGGCCJNCD<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> HLIDMKMINHN, IReadOnlyDictionary<TKey, TValue> BHFGHGMPKOJ) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class NDKAJNBINLO
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2B70", Offset = "0x2CD1170", VA = "0x182CD2B70")]
	public static TValue? NBPKAFKBLJI<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> HLIDMKMINHN, TKey IBBDLGCDELM) where TValue : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class LFCBLLCGBCH
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC410", Offset = "0x6ACAA10", VA = "0x186ACC410")]
	public static void DKJHOBNJMII(this IReadOnlyList<Action> HLIDMKMINHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2C55970", Offset = "0x2C53F70", VA = "0x182C55970")]
	public static bool APLEJEFPFAB<T>(this IReadOnlyList<T> HLIDMKMINHN, int PDMMEDBMFPP, [Out][FBDLONGKOCP("This should be `T?` in C# 9.")][NotNullWhen(true)] T IAFCFGOKEAK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2C55BD0", Offset = "0x2C541D0", VA = "0x182C55BD0")]
	public static bool OFNMKAAIOJA<T>(this IReadOnlyList<T> HLIDMKMINHN, int PDMMEDBMFPP, [Out] DFBDAEGMHFC<T> IAFCFGOKEAK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2C55CB0", Offset = "0x2C542B0", VA = "0x182C55CB0")]
	public static T PKLNHAFIACC<T>(this IReadOnlyList<T> HLIDMKMINHN, int PDMMEDBMFPP, [In] T JKGNOEBJIKP) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2C55AC0", Offset = "0x2C540C0", VA = "0x182C55AC0")]
	[FBDLONGKOCP("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T BMKGLOPAKOJ<T>(this IReadOnlyList<T> HLIDMKMINHN, int PDMMEDBMFPP) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2C55B10", Offset = "0x2C54110", VA = "0x182C55B10")]
	public static T? NBPKAFKBLJI<T>(this IReadOnlyList<T> HLIDMKMINHN, int PDMMEDBMFPP) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class OOJFLIHFKND
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2D165C0", Offset = "0x2D14BC0", VA = "0x182D165C0")]
	public static int LFCMAHLPLCN<T>([In] this ReadOnlySequence<T> EEJFHEAAALJ, [In] T DMNGPNKHPKF) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2D161A0", Offset = "0x2D147A0", VA = "0x182D161A0")]
	public static bool LEFFIJNGGKC<T>([In] this ReadOnlySequence<T> EEJFHEAAALJ, [In] ReadOnlySpan<T> BHFGHGMPKOJ) where T : IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HEHHECPNMLB
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2BA43A0", Offset = "0x2BA29A0", VA = "0x182BA43A0")]
	public static string JFMBCANKHJI<T>([In] this ReadOnlySpan<T> HLIDMKMINHN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3AE0", Offset = "0x2BA20E0", VA = "0x182BA3AE0")]
	public static string BPEJDGJHNEO<T>([In] this ReadOnlySpan<T> HLIDMKMINHN, string HGCEHLCNFGA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LNJGENFLHMG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static HNCBMJLOOPO MMDJCHBKPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD1F0", Offset = "0x6ACB7F0", VA = "0x186ACD1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD160", Offset = "0x6ACB760", VA = "0x186ACD160")]
	public static double KCNCONFBCIP(this HNCBMJLOOPO HLIDMKMINHN, long KCHJFNHNHDL)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class NKJMEGIPNCF : HNCBMJLOOPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Stopwatch IPOGOLKNLGG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long JHOFALLNMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD580", Offset = "0x6ACBB80", VA = "0x186ACD580", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	private NKJMEGIPNCF(Stopwatch JCKIGCCHOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD510", Offset = "0x6ACBB10", VA = "0x186ACD510")]
	public static NKJMEGIPNCF FCMOIKHDKDE(Stopwatch JCKIGCCHOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6ACD460", Offset = "0x6ACBA60", VA = "0x186ACD460")]
	public static NKJMEGIPNCF DLHOJCCHLIA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class BENDFNCMKJP
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9EB0", Offset = "0x6AC84B0", VA = "0x186AC9EB0")]
	public static float3 HFLPBDDDKOF([In] this RigidTransform HLIDMKMINHN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9FE0", Offset = "0x6AC85E0", VA = "0x186AC9FE0")]
	public static float3 LICBJIFCJIC([In] this RigidTransform HLIDMKMINHN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x97EE00", Offset = "0x97D400", VA = "0x18097EE00")]
	public static (float3, float3, float3) DJLONDOLAJF([In] this RigidTransform HLIDMKMINHN)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9E50", Offset = "0x6AC8450", VA = "0x186AC9E50")]
	public static RigidTransform EPNIFGPCDEI([In] this RigidTransform HLIDMKMINHN)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class KMEGBOGDFCA
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6ACC1B0", Offset = "0x6ACA7B0", VA = "0x186ACC1B0")]
	public static RigidTransform LHELPEDPBJE(RigidTransform CJBLFFAGHGG, RigidTransform AMDFNGBDAAP)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class DFFMKOOMFJG
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6ACA9F0", Offset = "0x6AC8FF0", VA = "0x186ACA9F0")]
	public static float BDFHOHANCIC([In] this (byte Fourth, byte Third, byte Second, byte First) HLIDMKMINHN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAA30", Offset = "0x6AC9030", VA = "0x186ACAA30")]
	public static int JMHGANLLGND(this float HLIDMKMINHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAA40", Offset = "0x6AC9040", VA = "0x186ACAA40")]
	public static (byte, byte, byte, byte) KHJNOEHKOKH(this float HLIDMKMINHN)
	{
		return default((byte, byte, byte, byte));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class PCNNHHOBJOD
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2D23360", Offset = "0x2D21960", VA = "0x182D23360")]
	public static ReadOnlySpan<T?> LEMMHPFKIML<T>([In] this Span<T> HLIDMKMINHN)
	{
		return default(ReadOnlySpan<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class IKGEAKDMOLL
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static Regex LAGGICLFOFK;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static Regex OBDGDHODIBC;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly char[] IGNCEACAOFK;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C760", Offset = "0x5E6AD60", VA = "0x185E6C760")]
	public static bool BINCBIJFEPE(this string? NDEKMIKNIGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBD60", Offset = "0x6ACA360", VA = "0x186ACBD60")]
	public static string? CNLPPIJELHG(this string? HLIDMKMINHN, int LANOKLGBLAA, string JHIHKBPKAMN = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBF90", Offset = "0x6ACA590", VA = "0x186ACBF90")]
	public static string OLBEGOCPAMJ(this string HLIDMKMINHN, int LANOKLGBLAA, string JHIHKBPKAMN = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBE40", Offset = "0x6ACA440", VA = "0x186ACBE40")]
	public static int KGEOHHHIAIP(this string NDEKMIKNIGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBCA0", Offset = "0x6ACA2A0", VA = "0x186ACBCA0")]
	public static string AOBGNHIKPPC(this string NDEKMIKNIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACBEB0", Offset = "0x6ACA4B0", VA = "0x186ACBEB0")]
	public static string[] NFKLJHBJBDL(this string NDEKMIKNIGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class JLFDHNPJJPK<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public readonly struct KKHJEEJJIDE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x41BDA80", Offset = "0x41BC080", VA = "0x1841BDA80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static int JEBHHNEHCAN;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static EPDDADKPADM ELIDKMLMJPA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static long JHOFALLNMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x409B650", Offset = "0x4099C50", VA = "0x18409B650")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x409B8D0", Offset = "0x4099ED0", VA = "0x18409B8D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x409B490", Offset = "0x4099A90", VA = "0x18409B490")]
	public static KKHJEEJJIDE GFPDFCGKMCO()
	{
		return default(KKHJEEJJIDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x409B6A0", Offset = "0x4099CA0", VA = "0x18409B6A0")]
	private static void LDNBBPAJJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x409B850", Offset = "0x4099E50", VA = "0x18409B850")]
	public static void LJOBMJGJKLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct EPDDADKPADM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly HNCBMJLOOPO IPOGOLKNLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly long MLLAAMLLJDB;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB080", Offset = "0x6AC9680", VA = "0x186ACB080")]
	public EPDDADKPADM(HNCBMJLOOPO JCKIGCCHOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAF60", Offset = "0x6AC9560", VA = "0x186ACAF60")]
	public long HMOIOCNCKHC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAFF0", Offset = "0x6AC95F0", VA = "0x186ACAFF0")]
	public double KCNCONFBCIP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAED0", Offset = "0x6AC94D0", VA = "0x186ACAED0")]
	public double GJGMOJCECDF()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class EEBNLDCAOBC
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6ACAAC0", Offset = "0x6AC90C0", VA = "0x186ACAAC0")]
	public static bool DHIHJNBKLLN(this Type HLIDMKMINHN, Type BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2A311C0", Offset = "0x2A2F7C0", VA = "0x182A311C0")]
	public static bool DHIHJNBKLLN<T>(this Type HLIDMKMINHN) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class GIBNJDGOMKA
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5AD2C90", Offset = "0x5AD1290", VA = "0x185AD2C90")]
	public static uint CJPHDCNMABN(this uint HLIDMKMINHN, int BMKFLHFENBJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5BA3470", Offset = "0x5BA1A70", VA = "0x185BA3470")]
	public static uint CJONKHFFGBK(this uint HLIDMKMINHN, int BMKFLHFENBJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB0F0", Offset = "0x6AC96F0", VA = "0x186ACB0F0")]
	public static uint ELAJJHMFFPB(this uint HLIDMKMINHN, uint EECINGOGGAH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x1078BF0", Offset = "0x10771F0", VA = "0x181078BF0")]
	public static int JMHGANLLGND(this uint HLIDMKMINHN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class LBOBLLNNJLI
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2C3CE10", Offset = "0x2C3B410", VA = "0x182C3CE10")]
	public static bool GFAIJMPLGMC<T>([In] this T? HLIDMKMINHN, [Out] T DMNGPNKHPKF) where T : struct
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
