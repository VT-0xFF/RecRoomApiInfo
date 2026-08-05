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
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6A04050", Offset = "0x6A02650", VA = "0x186A04050")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88D740", Offset = "0x88BD40", VA = "0x18088D740")]
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
		[Cpp2IlInjected.Address(RVA = "0x88D780", Offset = "0x88BD80", VA = "0x18088D780")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IIJHBNOJOHG
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string[] OFJNMMKGPBC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A00FF0", Offset = "0x69FF5F0", VA = "0x186A00FF0")]
	public static bool DDCNFPFIIMN(string ALDEBAIFFFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A01540", Offset = "0x69FFB40", VA = "0x186A01540")]
	private static bool IPPPMIBPCNB(string NFOHONOFFAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A013F0", Offset = "0x69FF9F0", VA = "0x186A013F0")]
	public static bool IPPPMIBPCNB(Exception MKGEIKBIPFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A010C0", Offset = "0x69FF6C0", VA = "0x186A010C0")]
	public static string IIMJOCJBFKF(string KIBGJLLHGOJ, string JNNHDMKPDLF = "", bool GABHAEALBKD = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JPBPFOJCEOL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A01C00", Offset = "0x6A00200", VA = "0x186A01C00")]
	public static string FNNANCJMEFL(this Guid NNFEKLKANBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A01B60", Offset = "0x6A00160", VA = "0x186A01B60")]
	public static string FNNANCJMEFL(this byte[] JFDEDKFKPOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A01AA0", Offset = "0x6A000A0", VA = "0x186A01AA0")]
	public static byte[] AJKLMMKKGFD(string AONNANIAAEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class ANBHDBDAPFL
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int BHJJDAGCONA<T>([In] T ILBMPADICAD, [In] T BEOPIALHGPL);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class LFJECFCJCAH<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct MBLCAHMNNJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly int GEIGDPFELPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public readonly int FJLMFNONBHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public readonly bool BBDIANKAMHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int IDBEPMPDGOA;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x44B13C0", Offset = "0x44AF9C0", VA = "0x1844B13C0")]
			public MBLCAHMNNJL(int GEIGDPFELPO, int FJLMFNONBHN, bool BBDIANKAMHE)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly T[] IJBMALMNANB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly T[] ACNAKMKPEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly BHJJDAGCONA<T> BBLOHGJHCIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly int APIBOKMKFKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Func<bool> CMJHLKNEPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int CGJKOBHFBMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly MBLCAHMNNJL[] DEOKDFOFABE;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x42AA3F0", Offset = "0x42A89F0", VA = "0x1842AA3F0")]
		public LFJECFCJCAH(T[] IJBMALMNANB, BHJJDAGCONA<T> BBLOHGJHCIM, int APIBOKMKFKI, Func<bool> CMJHLKNEPCD, T[]? GKOACNLHPNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x42AA0C0", Offset = "0x42A86C0", VA = "0x1842AA0C0")]
		public bool JKDNJCJBNPK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate U NPOLIPCINDO<T, U>(int NOFOBMLPOIH, int DIHGKCAABDK, [In] ReadOnlySpan<T> MAHKJEHCFJG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x31A46A0", Offset = "0x31A2CA0", VA = "0x1831A46A0")]
	public static T[] BHNLMPBBNIP<T>(int ENCFHCJIMBE, T EMJOHPCKMDE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x31A6110", Offset = "0x31A4710", VA = "0x1831A6110")]
	public static void LJBJMKNEAAL<T>(this T[] JFIPEGBGGCH, T EMJOHPCKMDE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x31A5460", Offset = "0x31A3A60", VA = "0x1831A5460")]
	public static void JBMKFBCJMGF<T>(this T[] GGEMIJICFPG, int JFDIHIMJIHB, int CJEBBJDCFPG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x31A4890", Offset = "0x31A2E90", VA = "0x1831A4890")]
	private static void GBHJMJHDOJO<T>(this T[] OLDDCPCBGIL, int JGBNJLJPLEB, int HAAJEBNPEGF, T[] LJAAPFIIPOF, int BJNDEKCNGGC, int KAGGLKHGOGI, T[] HJBJAPKPPFA, int HMHEOHONPFN, BHJJDAGCONA<T> BBLOHGJHCIM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x31A4290", Offset = "0x31A2890", VA = "0x1831A4290")]
	public static void AOJKMLFBECE<T>(this T[] OLDDCPCBGIL, int GEIGDPFELPO, int JPBPNOCHNLG, BHJJDAGCONA<T> BBLOHGJHCIM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x31A6050", Offset = "0x31A4650", VA = "0x1831A6050")]
	public static LFJECFCJCAH<T> LGECAOCKDDO<T>(this T[] OLDDCPCBGIL, BHJJDAGCONA<T> BBLOHGJHCIM, int APIBOKMKFKI, Func<bool> CMJHLKNEPCD, [Optional] T[]? GKOACNLHPNH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x31A4840", Offset = "0x31A2E40", VA = "0x1831A4840")]
	public static T[] EMJAFBBMHBK<T>(this T[] GGEMIJICFPG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x31A4C60", Offset = "0x31A3260", VA = "0x1831A4C60")]
	public static T[] HEENNJCDKNI<T>(this T[] ADHHMNDCDMA, T DLLJKHLNMFB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x31A5780", Offset = "0x31A3D80", VA = "0x1831A5780")]
	public static T[] LBGBGLBGNFL<T>(this T[] ADHHMNDCDMA, int LLPJHIPCNFD, T DLLJKHLNMFB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x31A41E0", Offset = "0x31A27E0", VA = "0x1831A41E0")]
	public static T[] AOBHDGHAANP<T>(this T[] ADHHMNDCDMA, int LLPJHIPCNFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x31A54E0", Offset = "0x31A3AE0", VA = "0x1831A54E0")]
	public static T[] JOENELFPLBL<T>(this T[] ADHHMNDCDMA, int LLPJHIPCNFD, T DLLJKHLNMFB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x31A4DB0", Offset = "0x31A33B0", VA = "0x1831A4DB0")]
	public static U[] HHAKAFMNDBN<U, T>(this T[] ONEIHMPFJKE, int ODNANBHOKHB, NPOLIPCINDO<T, U> ODIJGMHMGBC) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69FF9E0", Offset = "0x69FDFE0", VA = "0x1869FF9E0")]
	public static byte[] OHMIGINJCFC(this byte[] OLDDCPCBGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69FF760", Offset = "0x69FDD60", VA = "0x1869FF760")]
	public static byte[] JMLHBAPMICI(this byte[] OLDDCPCBGIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GKGNFDJEONJ
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A00E00", Offset = "0x69FF400", VA = "0x186A00E00")]
	public static byte NPLOPDMDJGA(this bool OLDDCPCBGIL)
	{
		return default(byte);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MPLJLEFDAEH
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A00E00", Offset = "0x69FF400", VA = "0x186A00E00")]
	public static bool FOLHKINMINK(this byte OLDDCPCBGIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DMKAJIGNHAL
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2971680", Offset = "0x296FC80", VA = "0x182971680")]
	public static void MGFPFFGFDNB<T>(this ICollection<T> OLDDCPCBGIL, IEnumerable<T> FKCOHIKICFN) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class AOELBDALHME
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x31A70B0", Offset = "0x31A56B0", VA = "0x1831A70B0")]
	public static void EECGPMMCDPN<K, V>(this IDictionary<K, V> OLDDCPCBGIL, [In] K BHEIPBKEDLG, [In] V CBAEIEAPLIH, Func<V, V, V> LNBOIPDJODC) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x31A79B0", Offset = "0x31A5FB0", VA = "0x1831A79B0")]
	public static void JAKIINMOLLE<K, V>(this IDictionary<K, List<V>> OLDDCPCBGIL, [In] K BHEIPBKEDLG, [In] V CBAEIEAPLIH) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x31A66D0", Offset = "0x31A4CD0", VA = "0x1831A66D0")]
	public static TVal ECLIHBNIDDO<TVal, TKey>(this IDictionary<TKey, TVal> OLGJECBHAKN, [In] TKey BHEIPBKEDLG, [Optional][DMMOHDONLFE("`default!` shouldn't be necessary in C# 9")] TVal AJMLHGDNPEK) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x31A6310", Offset = "0x31A4910", VA = "0x1831A6310")]
	public static TVal ECLIHBNIDDO<TVal, TKey>(this IDictionary<TKey, TVal> OLGJECBHAKN, [In] TKey BHEIPBKEDLG, Func<TVal> GHIDHABMDKA) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x31A8590", Offset = "0x31A6B90", VA = "0x1831A8590")]
	public static TValue LDHPDKNBLHM<TValue, TKey>(this IDictionary<TKey, TValue> OLGJECBHAKN, [In] TKey BHEIPBKEDLG, [Optional][In][DMMOHDONLFE("`default!` and null-oblivious region shouldn't be necessary in C# 9")] TValue AJMLHGDNPEK)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x31A80A0", Offset = "0x31A66A0", VA = "0x1831A80A0")]
	public static V KGDBMLPJMNA<V, K>(this IDictionary<K, V> OLDDCPCBGIL, [In] K BHEIPBKEDLG) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x31A7FE0", Offset = "0x31A65E0", VA = "0x1831A7FE0")]
	public static T2[] JNKPEPBDKEI<T2, T1>(this Dictionary<T1, T2>.ValueCollection AAKMCHIMLJB) where T2 : notnull where T1 : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JOAOFDMIEDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate bool CONKHFEIEID<TArgs, T>([In] TArgs NENLABMEOHA, T OPNLGJFHDEP);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate U AGDFACNFOMK<TArg, U>([In] TArg HFLBLCMJIKA);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate U GECKDJLOBPF<TArg, T, U>([In] TArg HFLBLCMJIKA, T IJGAKAKDEFC);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate U HJLILKFIHGP<TArg, T, U>([In] TArg HFLBLCMJIKA, IEnumerable<T> FOGJCPKBILL);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate U CGKMGDJMGCN<TArg, T, U>([In] TArg HFLBLCMJIKA, T IJGAKAKDEFC);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct OPJEFPAIFKB<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x46AC790", Offset = "0x46AAD90", VA = "0x1846AC790")]
		[DMMOHDONLFE("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) BCNGCAIHPNC(T IDMCNLPCONC)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x46AC7F0", Offset = "0x46AADF0", VA = "0x1846AC7F0")]
		[DMMOHDONLFE("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) CEPEPDCLPFA(IEnumerable<T> GMHDDNFAELJ)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class CHMJLGCKLON<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
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
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private IEnumerable<U> other;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public IEnumerable<U> <>3__other;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private T with;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public T <>3__with;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private IEnumerator<T> <selfEnumerator>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private IEnumerator<U> <otherEnumerator>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8BC660", Offset = "0x8BAC60", VA = "0x1808BC660")]
		[DebuggerHidden]
		public CHMJLGCKLON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5154520", Offset = "0x5152B20", VA = "0x185154520", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5153DA0", Offset = "0x51523A0", VA = "0x185153DA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5154130", Offset = "0x5152730", VA = "0x185154130")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5153580", Offset = "0x5151B80", VA = "0x185153580")]
		private void LAOHPFDNJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x51544D0", Offset = "0x5152AD0", VA = "0x1851544D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5154230", Offset = "0x5152830", VA = "0x185154230", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3AC5010", Offset = "0x3AC3610", VA = "0x183AC5010", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LDHCIPIIEJK<T> : IEnumerable<(T, GBGJJMPMMOC<T>)>, IEnumerable, IEnumerator<(T, GBGJJMPMMOC<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private (T Current, GBGJJMPMMOC<T> Next) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private IEnumerator<T> <enumerator>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private (T, GBGJJMPMMOC<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x3899CA0", Offset = "0x38982A0", VA = "0x183899CA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, GBGJJMPMMOC<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x42A4E20", Offset = "0x42A3420", VA = "0x1842A4E20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1E8C210", Offset = "0x1E8A810", VA = "0x181E8C210")]
		[DebuggerHidden]
		public LDHCIPIIEJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3AC2D70", Offset = "0x3AC1370", VA = "0x183AC2D70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x42A4380", Offset = "0x42A2980", VA = "0x1842A4380", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x42A48C0", Offset = "0x42A2EC0", VA = "0x1842A48C0")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x42A4D80", Offset = "0x42A3380", VA = "0x1842A4D80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x42A4C00", Offset = "0x42A3200", VA = "0x1842A4C00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, GBGJJMPMMOC<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3AC5010", Offset = "0x3AC3610", VA = "0x183AC5010", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CJIDLBHJBDG<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private U <>2__current;

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
		private Func<OPJEFPAIFKB<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Func<OPJEFPAIFKB<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private IEnumerator<T> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IEnumerator<U> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		U IEnumerator<UnityEngine.SpookyHash.U>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (U)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC660", Offset = "0x8BAC60", VA = "0x1808BC660")]
		[DebuggerHidden]
		public CJIDLBHJBDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x515B2C0", Offset = "0x51598C0", VA = "0x18515B2C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x515AD90", Offset = "0x5159390", VA = "0x18515AD90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x515B220", Offset = "0x5159820", VA = "0x18515B220")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x515AD40", Offset = "0x5159340", VA = "0x18515AD40")]
		private void LAOHPFDNJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x515B270", Offset = "0x5159870", VA = "0x18515B270", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3BF81F0", Offset = "0x3BF67F0", VA = "0x183BF81F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x37C5DE0", Offset = "0x37C43E0", VA = "0x1837C5DE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FLNCKABNKDA<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public FLNCKABNKDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3C58BE0", Offset = "0x3C571E0", VA = "0x183C58BE0")]
		internal bool NKCHDNLPNJK(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3C58B20", Offset = "0x3C57120", VA = "0x183C58B20")]
		internal bool NCGFLHIMLIK(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JAKOOJLFAID<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private (T Lhs, U Rhs) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private IEnumerable<T> lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public IEnumerable<T> <>3__lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private IEnumerable<U> rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IEnumerable<U> <>3__rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IEnumerator<T> <lhsIt>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private IEnumerator<U> <rhsIt>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private (T, U) System.Collections.Generic.IEnumerator<(TLhs,URhs)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xC3DCF0", Offset = "0xC3C2F0", VA = "0x180C3DCF0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, U));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x3BF30F0", Offset = "0x3BF16F0", VA = "0x183BF30F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1E8C210", Offset = "0x1E8A810", VA = "0x181E8C210")]
		[DebuggerHidden]
		public JAKOOJLFAID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x405E330", Offset = "0x405C930", VA = "0x18405E330", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x405E640", Offset = "0x405CC40", VA = "0x18405E640", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x405E560", Offset = "0x405CB60", VA = "0x18405E560", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3AC5010", Offset = "0x3AC3610", VA = "0x183AC5010", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2B9B5A0", Offset = "0x2B99BA0", VA = "0x182B9B5A0")]
	public static bool HIFNAFADBOA<T, TArgs>(this IEnumerable<T> OLDDCPCBGIL, [In] TArgs NENLABMEOHA, CONKHFEIEID<TArgs, T> IBNKJLLIEAG) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A01980", Offset = "0x69FFF80", VA = "0x186A01980")]
	public static bool HIFNAFADBOA(this IEnumerable<bool> OLDDCPCBGIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2B99DE0", Offset = "0x2B983E0", VA = "0x182B99DE0")]
	public static U DLAAOMNCHKO<U, T>(this IEnumerable<T> OLDDCPCBGIL, Func<U> PMDNEADHCBJ, Func<T, U> IDMCNLPCONC, Func<IEnumerable<T>, U> GMHDDNFAELJ) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2B997E0", Offset = "0x2B97DE0", VA = "0x182B997E0")]
	public static bool DJABGNMGFMO<T, TArgs>(this IEnumerable<T> OLDDCPCBGIL, [In] TArgs NENLABMEOHA, CONKHFEIEID<TArgs, T> IBNKJLLIEAG) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D520", Offset = "0x2B9BB20", VA = "0x182B9D520")]
	public static U MMDJEAGFBFJ<U, T, TArg>(this IEnumerable<T> OLDDCPCBGIL, [In] TArg HFLBLCMJIKA, AGDFACNFOMK<TArg, U> PMDNEADHCBJ, GECKDJLOBPF<TArg, T, U> IDMCNLPCONC, HJLILKFIHGP<TArg, T, U> GMHDDNFAELJ) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2B99220", Offset = "0x2B97820", VA = "0x182B99220")]
	public static IEnumerable<U> CLPJNPHBOKK<U, T, TArg>(this IEnumerable<T> OLDDCPCBGIL, [In] TArg HFLBLCMJIKA, CGKMGDJMGCN<TArg, T, U> OOEOCNGCCGO) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2990360", Offset = "0x298E960", VA = "0x182990360")]
	public static IEnumerable<T> LNDBJPDNMDF<T>(params IEnumerable<T>[] IFAODIHNEAD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A050", Offset = "0x2B98650", VA = "0x182B9A050")]
	public static bool FLFAEODCAKN<T>(this IEnumerable<T> CHNGFEKJHON, IEnumerable<T> LJAAPFIIPOF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2990360", Offset = "0x298E960", VA = "0x182990360")]
	public static IEnumerable<(TKey?, TValue?)>? KFABLHFKDLF<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> OLDDCPCBGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2B9E6F0", Offset = "0x2B9CCF0", VA = "0x182B9E6F0")]
	public static IEnumerable<T> PPMMLAFPCEH<T, TKey>(this IEnumerable<T> GNLOFBLAPLO, Func<T, TKey> NKINLFLJLIA) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0CE0", Offset = "0x2A9F2E0", VA = "0x182AA0CE0")]
	[IteratorStateMachine(typeof(CHMJLGCKLON<, >))]
	public static IEnumerable<T> LPOIBGELBDM<T, U>(this IEnumerable<T> OLDDCPCBGIL, IEnumerable<U> LJAAPFIIPOF, [Optional][DMMOHDONLFE("`default!` shouldn't be necessary in C# 9")] T EMJOHPCKMDE) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2811560", Offset = "0x280FB60", VA = "0x182811560")]
	public static T HPEAJBJJJEH<T>(this IEnumerable<T> CHNGFEKJHON, T AJMLHGDNPEK) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2B9BA20", Offset = "0x2B9A020", VA = "0x182B9BA20")]
	public static T HPEAJBJJJEH<T>(this IEnumerable<T> CHNGFEKJHON, T AJMLHGDNPEK, Func<T, bool> IBNKJLLIEAG) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A850", Offset = "0x2B98E50", VA = "0x182B9A850")]
	public static T? GPPACACOJPN<T>(this IEnumerable<T> OLDDCPCBGIL, Func<T, bool> IBNKJLLIEAG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2B9C580", Offset = "0x2B9AB80", VA = "0x182B9C580")]
	public static void JALBOCHMIPI<T>(this IEnumerable<T> OLDDCPCBGIL, Action<T> DOLDDKPNFFE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2A3D240", Offset = "0x2A3B840", VA = "0x182A3D240")]
	[IteratorStateMachine(typeof(LDHCIPIIEJK<>))]
	public static IEnumerable<(T, GBGJJMPMMOC<T>)> OIJFMEDCDIC<T>(this IEnumerable<T> OLDDCPCBGIL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D280", Offset = "0x2B9B880", VA = "0x182B9D280")]
	public static bool LGDPGCKOGAA<T>(this IEnumerable<T> OLDDCPCBGIL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2990360", Offset = "0x298E960", VA = "0x182990360")]
	public static IEnumerable<JJFNMLNAJJG<T>> FPNFNABMIOF<T>(this IEnumerable<T> OLDDCPCBGIL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2B99760", Offset = "0x2B97D60", VA = "0x182B99760")]
	public static bool DFLAHLKBLGO<T>(this IEnumerable<T> OLDDCPCBGIL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D240", Offset = "0x2B9B840", VA = "0x182B9D240")]
	public static IEnumerable<T> KLKEIOKCEEG<T>(this IEnumerable<T>? OLDDCPCBGIL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A3CED0", Offset = "0x2A3B4D0", VA = "0x182A3CED0")]
	[IteratorStateMachine(typeof(CJIDLBHJBDG<, >))]
	public static IEnumerable<U> GLJBPPILODC<U, T>(this IEnumerable<T> OLDDCPCBGIL, Func<OPJEFPAIFKB<U>, T, (bool Zero, U One, IEnumerable<U> Many)> IKONPJFCLCH) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2B9E1F0", Offset = "0x2B9C7F0", VA = "0x182B9E1F0")]
	public static int NJMIFDGAHFA<T>(this IEnumerable<T> OLDDCPCBGIL, int EHECGJLCGOD = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2B9CFD0", Offset = "0x2B9B5D0", VA = "0x182B9CFD0")]
	public static bool KENAHFINMDI<T>(this IEnumerable<T> OLDDCPCBGIL, IEnumerable<T> LJAAPFIIPOF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D3B0", Offset = "0x2B9B9B0", VA = "0x182B9D3B0")]
	public static IEnumerable<T> LPFNMONFLLB<T>(this IEnumerable<T> OLDDCPCBGIL, int CFKFFPNNJCH, int HAHAJHDNKFA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2B98780", Offset = "0x2B96D80", VA = "0x182B98780")]
	public static (IEnumerable<T>, IEnumerable<T>) BGGAJPDNIIN<T>(this IEnumerable<T> OLDDCPCBGIL, Func<T, bool> LKBLLIHJCIH) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2B98CD0", Offset = "0x2B972D0", VA = "0x182B98CD0")]
	public static string CFFMECMPGKO<T>(this IEnumerable<T> OLDDCPCBGIL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A240", Offset = "0x2B98840", VA = "0x182B9A240")]
	public static Dictionary<TKey?, TValue?>? GLONKJOJMOP<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> CHNGFEKJHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A240", Offset = "0x2B98840", VA = "0x182B9A240")]
	public static Dictionary<TKey?, TValue?>? GLONKJOJMOP<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> CHNGFEKJHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2B99D20", Offset = "0x2B98320", VA = "0x182B99D20")]
	public static List<T> DJKBKMDEEGN<T>(this IEnumerable<T> OLDDCPCBGIL, int NAFKLJDAKHD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2B997A0", Offset = "0x2B97DA0", VA = "0x182B997A0")]
	public static string DHBLNINAFBG<T>(this IEnumerable<T> OLDDCPCBGIL, string CPKHBLKAMPN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2B9BAA0", Offset = "0x2B9A0A0", VA = "0x182B9BAA0")]
	public static (IReadOnlyList<T?>?, IReadOnlyList<U?>?) IIDHMLGDECG<T, U>(this IEnumerable<(T Lhs, U Rhs)> OLDDCPCBGIL)
	{
		return default((IReadOnlyList<T>, IReadOnlyList<U>));
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2A50EF0", Offset = "0x2A4F4F0", VA = "0x182A50EF0")]
	[IteratorStateMachine(typeof(JAKOOJLFAID<, >))]
	public static IEnumerable<(T, U)> FEHELBBAIEB<T, U>(this IEnumerable<T> ILBMPADICAD, IEnumerable<U> BEOPIALHGPL) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2B984D0", Offset = "0x2B96AD0", VA = "0x182B984D0")]
	public static IEnumerable<V> AAHKIAANAMH<V, T, U>(this IEnumerable<T> OLDDCPCBGIL, IEnumerable<U> LJAAPFIIPOF, Func<T, U, V> LPIBEGJPEBK, [Optional][DMMOHDONLFE("`default!` shouldn't be necessary in C# 9")] T NHOEMMGABPB, [Optional][DMMOHDONLFE("`default!` shouldn't be necessary in C# 9")] U EGBHDJACENJ) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2B985A0", Offset = "0x2B96BA0", VA = "0x182B985A0")]
	public static IEnumerable<(T, U)> AAHKIAANAMH<T, U>(this IEnumerable<T> OLDDCPCBGIL, IEnumerable<U> LJAAPFIIPOF, [Optional][DMMOHDONLFE("`default!` shouldn't be necessary in C# 9")] T NHOEMMGABPB, [Optional][DMMOHDONLFE("`default!` shouldn't be necessary in C# 9")] U EGBHDJACENJ) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2B9DA20", Offset = "0x2B9C020", VA = "0x182B9DA20")]
	public static TOut[] NEPFMHMELBM<TOut, TIn>(this IEnumerable<TIn> GNLOFBLAPLO, Func<TIn, TOut> LAOEBFAJLCK) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class JCEPHNHNEJE
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B080", Offset = "0x2B69680", VA = "0x182B6B080")]
	public static bool KBGKBECJOAE<T, U>(this T OLDDCPCBGIL, [In] U HBFCGFKGCAF) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2B6AFE0", Offset = "0x2B695E0", VA = "0x182B6AFE0")]
	public static bool ICOBFAOOIDA<T>(T OLDDCPCBGIL, T LJAAPFIIPOF) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class NMEFIDKGAOF
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xB60D40", Offset = "0xB5F340", VA = "0x180B60D40")]
	public static bool CAODHHDHCGK([In] this float3 FAGKOOGCGBH, float3 HEOHCJKCOLM, float IPOBABEPPFN = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class GGKABANBLKK
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class NJNCJKFMHAO<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private T self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public T <>3__self;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8D47C0", Offset = "0x8D2DC0", VA = "0x1808D47C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x3BE6F20", Offset = "0x3BE5520", VA = "0x183BE6F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA7D830", Offset = "0xA7BE30", VA = "0x180A7D830")]
		[DebuggerHidden]
		public NJNCJKFMHAO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x45679C0", Offset = "0x4565FC0", VA = "0x1845679C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4567CC0", Offset = "0x45662C0", VA = "0x184567CC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4567BA0", Offset = "0x45661A0", VA = "0x184567BA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x38F4900", Offset = "0x38F2F00", VA = "0x1838F4900", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B010D0", Offset = "0x2AFF6D0", VA = "0x182B010D0")]
	public static void HGBHJHJDHDK<T>(this T LBKJPGMAINP, Action<T> KJAKEPEGKNI) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B012C0", Offset = "0x2AFF8C0", VA = "0x182B012C0")]
	public static V NNMLGGBGOBH<V, T>(this T LBKJPGMAINP, Func<T, V> KJAKEPEGKNI, [Optional][DMMOHDONLFE("`default!` shouldn't be necessary in C# 9")] V AJMLHGDNPEK) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2B01240", Offset = "0x2AFF840", VA = "0x182B01240")]
	public static T? MNPGJIOLMCP<T>(this T OLDDCPCBGIL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2B01120", Offset = "0x2AFF720", VA = "0x182B01120")]
	[IteratorStateMachine(typeof(NJNCJKFMHAO<>))]
	public static IEnumerable<T> HKFOAGHOGLM<T>(this T OLDDCPCBGIL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2B01010", Offset = "0x2AFF610", VA = "0x182B01010")]
	public static T[] COBGMEIIENM<T>(this T OLDDCPCBGIL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class NNHHHDHOFLA
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A03590", Offset = "0x6A01B90", VA = "0x186A03590")]
	private static byte[] CNNPAEPGFKG(int OFNCOECPHHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A03D80", Offset = "0x6A02380", VA = "0x186A03D80")]
	private static byte[] IBOIJPKINHH(long CMPFGKCKFBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A03D00", Offset = "0x6A02300", VA = "0x186A03D00")]
	private static byte[] HPEECHCFDDF(ulong CMPFGKCKFBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A03E90", Offset = "0x6A02490", VA = "0x186A03E90")]
	public static Guid OEBLPMOAKLA(params Guid[] OIEGFCIFPMN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A03610", Offset = "0x6A01C10", VA = "0x186A03610")]
	public static Guid GIGNPOIHFIA([In] Guid FAMAKKHFFLG, int LLPJHIPCNFD, int HNNOPDLCPBM = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A03820", Offset = "0x6A01E20", VA = "0x186A03820")]
	public static Guid GIGNPOIHFIA([In] Guid FAMAKKHFFLG, long LLPJHIPCNFD, int HNNOPDLCPBM = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A03750", Offset = "0x6A01D50", VA = "0x186A03750")]
	public static Guid GIGNPOIHFIA([In] Guid FAMAKKHFFLG, ulong LLPJHIPCNFD, int HNNOPDLCPBM = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A036E0", Offset = "0x6A01CE0", VA = "0x186A036E0")]
	public static Guid GIGNPOIHFIA([In] Guid FAMAKKHFFLG, [In] Guid IHLCHIDEJHN, int HNNOPDLCPBM = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A038F0", Offset = "0x6A01EF0", VA = "0x186A038F0")]
	private static Guid GIGNPOIHFIA([In] Guid FAMAKKHFFLG, byte[] GMPDDGMLPHB, int HNNOPDLCPBM = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A03E00", Offset = "0x6A02400", VA = "0x186A03E00")]
	private static void KEHBNKAFAAJ(byte[] NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A04000", Offset = "0x6A02600", VA = "0x186A04000")]
	private static void PPLNNBDBHJN(byte[] NNFEKLKANBO, int KKEPMPAJLEA, int HIEMMBKCCDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class PPHFBFJKPIB
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A04210", Offset = "0x6A02810", VA = "0x186A04210")]
	public static int MJFHHMLOJAJ(this int OLDDCPCBGIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A040D0", Offset = "0x6A026D0", VA = "0x186A040D0")]
	public static int BKCBCGMBJLP(this int OLDDCPCBGIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A04110", Offset = "0x6A02710", VA = "0x186A04110")]
	public static int DEMABGJDNNG(this int OLDDCPCBGIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A04280", Offset = "0x6A02880", VA = "0x186A04280")]
	public static int OBOPDCGOBAE(this int OLDDCPCBGIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5A2D220", Offset = "0x5A2B820", VA = "0x185A2D220")]
	public static int NHEIKNNJAFC(this int OLDDCPCBGIL, int JPBPNOCHNLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5AFD780", Offset = "0x5AFBD80", VA = "0x185AFD780")]
	public static int FIBGGIGCMFG(this int OLDDCPCBGIL, int JPBPNOCHNLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A04180", Offset = "0x6A02780", VA = "0x186A04180")]
	public static float LIHIHBEOKDC(this int OLDDCPCBGIL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A041A0", Offset = "0x6A027A0", VA = "0x186A041A0")]
	public static (byte, byte, byte, byte) LJAKENKCFIB(this int OLDDCPCBGIL)
	{
		return default((byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A04160", Offset = "0x6A02760", VA = "0x186A04160")]
	public static int HAFBKDDNMHK([In] this (byte Fourth, byte Third, byte Second, byte First) OLDDCPCBGIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6A042A0", Offset = "0x6A028A0", VA = "0x186A042A0")]
	public static int PJNFJDBKFIG(this int OLDDCPCBGIL, int HLEJOHAKKML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6A04290", Offset = "0x6A02890", VA = "0x186A04290")]
	public static int OHIBJIPBNFD(this int OLDDCPCBGIL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface GLNFCEFKAMA
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int AOODDNLKEHF(int KAEMFHFEPKJ, int GOPPBIJIPFP);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float KPPKENJBIMH(float MEMODFNJPKN, float APEPFLMDDEA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FKIPNNNOLMP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	long GIJBFFDACGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class FBHDFIACGBD
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC350", Offset = "0x2AEA950", VA = "0x182AEC350")]
	public static (TKey?, TValue?) HEAJOCGEKBE<TKey, TValue>([In] this KeyValuePair<TKey, TValue> OLDDCPCBGIL)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2AEC450", Offset = "0x2AEAA50", VA = "0x182AEC450")]
	public static KeyValuePair<TKey?, UValue?> LOMKLGKLJNL<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> OLDDCPCBGIL, UValue CBAEIEAPLIH)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class COOMGHONOJL
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class LFPEPJGIADG<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public LFPEPJGIADG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x42AB1C0", Offset = "0x42A97C0", VA = "0x1842AB1C0")]
		internal TElement KPOGPGIJNPG(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x293D250", Offset = "0x293B850", VA = "0x18293D250")]
	public static int OMCMGLDIJNG<T>(this IReadOnlyList<T> GGEMIJICFPG, T CBAEIEAPLIH) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2937150", Offset = "0x2935750", VA = "0x182937150")]
	public static int FMKOONFLHEN<T>(this IReadOnlyList<T> GGEMIJICFPG, T CBAEIEAPLIH) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x293B9E0", Offset = "0x2939FE0", VA = "0x18293B9E0")]
	public static void MGFPFFGFDNB<T>(this HashSet<T> PDGHONNCIEM, IEnumerable<T> FKCOHIKICFN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2937A50", Offset = "0x2936050", VA = "0x182937A50")]
	public static void GCEJCKODJFM<T>(this IList<T> DNOAHHGKGFF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2937700", Offset = "0x2935D00", VA = "0x182937700")]
	public static void GCEJCKODJFM<T>(this IList<T> DNOAHHGKGFF, int JMJCDLBBEKN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x293AE60", Offset = "0x2939460", VA = "0x18293AE60")]
	public static void KEKLCNIODIJ<T>(this List<T> DNOAHHGKGFF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x293A490", Offset = "0x2938A90", VA = "0x18293A490")]
	public static List<T> GNNODOENFAD<T>(this List<T> NECCMDHDJPN, Predicate<T> CFCBHHEKCIK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x293DA20", Offset = "0x293C020", VA = "0x18293DA20")]
	public static int OMCMGLDIJNG<T>(this IReadOnlyList<T> DNOAHHGKGFF, Predicate<T> IBNKJLLIEAG) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x293A930", Offset = "0x2938F30", VA = "0x18293A930")]
	public static bool IKGIMGAOCLN<T>(this IReadOnlyList<T> DNOAHHGKGFF, Predicate<T> IBNKJLLIEAG, [Out][NotNullWhen(true)] List<int>? DGLAKPCPOIA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x293F7D0", Offset = "0x293DDD0", VA = "0x18293F7D0")]
	public static bool PMELAKIMKGE<T>(this IReadOnlyList<T> DNOAHHGKGFF, T OPNLGJFHDEP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x293F670", Offset = "0x293DC70", VA = "0x18293F670")]
	public static bool PMELAKIMKGE<T>(this IReadOnlyList<T> DNOAHHGKGFF, T OPNLGJFHDEP, EqualityComparer<T> PJCHJFCBECF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x293E710", Offset = "0x293CD10", VA = "0x18293E710")]
	public static int PDLLODCBMJE<TElement, TKey>(this IList<TElement> NKHCKIOILAG, TKey ILLFGKNOBGI, Func<TElement, TKey> IEMMCFPNMFN, [Optional] Func<TKey, TKey, int>? BBLOHGJHCIM, int LLPJHIPCNFD = 0, [Optional] int? JPBPNOCHNLG) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x293DFD0", Offset = "0x293C5D0", VA = "0x18293DFD0")]
	public static int PDLLODCBMJE<TElement, TKey>(Func<int, TElement> FPACFMNOKGH, int GAIJHPGLHHA, TKey ILLFGKNOBGI, Func<TElement, TKey> IEMMCFPNMFN, [Optional] Func<TKey, TKey, int>? BBLOHGJHCIM, int LLPJHIPCNFD = 0, [Optional] int? JPBPNOCHNLG) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2936E90", Offset = "0x2935490", VA = "0x182936E90")]
	public static bool FKDACHFGGDG<T>(this List<T> DNOAHHGKGFF, T OPNLGJFHDEP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x293A610", Offset = "0x2938C10", VA = "0x18293A610")]
	public static void HFMNBNHLMMK<T>(this List<T> DNOAHHGKGFF, IEnumerable<T> NECCMDHDJPN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2937500", Offset = "0x2935B00", VA = "0x182937500")]
	public static void GAGDAFIMOPK<T>(this List<T> DNOAHHGKGFF, IEnumerable<T> NECCMDHDJPN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x293CB00", Offset = "0x293B100", VA = "0x18293CB00")]
	public static T MLPOAIPAAHH<T>(this List<T> NECCMDHDJPN, Predicate<T> CFCBHHEKCIK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2936DF0", Offset = "0x29353F0", VA = "0x182936DF0")]
	public static T EJCLDPHJDLF<T>(this List<T> NECCMDHDJPN, int LLPJHIPCNFD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x293B7C0", Offset = "0x2939DC0", VA = "0x18293B7C0")]
	public static void MAFLKMDCAIA<T>(this List<T> DNOAHHGKGFF, int LLPJHIPCNFD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x293A840", Offset = "0x2938E40", VA = "0x18293A840")]
	public static bool IJPFLICCIKA<T>(this List<T> IPBBLALLNPN, List<T> OKPFJAJLDPF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2936AB0", Offset = "0x29350B0", VA = "0x182936AB0")]
	public static T BALEBNBNOBE<T>(this IList<T> DNOAHHGKGFF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2936CF0", Offset = "0x29352F0", VA = "0x182936CF0")]
	public static bool DBBKKDKOFKA<T>(IReadOnlyList<T>? DNOAHHGKGFF, int LLPJHIPCNFD, [Out][MaybeNullWhen(false)][DMMOHDONLFE("This should be `T?` in C# 9.")] T HJBJAPKPPFA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2939470", Offset = "0x2937A70", VA = "0x182939470")]
	public static bool GGKHOGCCMDC<T>(IReadOnlyList<T> DNOAHHGKGFF, ICollection NECCMDHDJPN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x293CB90", Offset = "0x293B190", VA = "0x18293CB90")]
	public static void NBMDPANOLDA<T>(IReadOnlyList<T> DNOAHHGKGFF, ICollection NECCMDHDJPN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2936DA0", Offset = "0x29353A0", VA = "0x182936DA0")]
	public static bool DBFKMHDDMIO<T>(this IReadOnlyList<T> DNOAHHGKGFF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2937340", Offset = "0x2935940", VA = "0x182937340")]
	public static string FNGBHCMOKKJ<T>(this IEnumerable<T> DNOAHHGKGFF, string HDNJOPANICE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x293D0E0", Offset = "0x293B6E0", VA = "0x18293D0E0")]
	public static T NGHHPHDLBMB<T>(this IList<T> OLDDCPCBGIL) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x293B320", Offset = "0x2939920", VA = "0x18293B320")]
	public static T LCNPNBEKCEL<T>(this IList<T> OLDDCPCBGIL) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x293ADD0", Offset = "0x29393D0", VA = "0x18293ADD0")]
	public static void KDMOBIANILD<T>(this IList<T> OLDDCPCBGIL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2936B50", Offset = "0x2935150", VA = "0x182936B50")]
	public static void CAPFMAIJPNK<T>(this IList<T> OLDDCPCBGIL, [In] T CBAEIEAPLIH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x293CD60", Offset = "0x293B360", VA = "0x18293CD60")]
	public static T NFJCMKAIANL<T>(this IList<T> OLDDCPCBGIL) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x293B540", Offset = "0x2939B40", VA = "0x18293B540")]
	public static void LHFMOKJECIE<T>(this List<T> OLDDCPCBGIL) where T : struct, IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class KJKICDPCKHM
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static float NMOILNOIBEO;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static float KOMHOILHMPC;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static bool MEJIEKFEHPG;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly float HGJIEIOPMJM;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6A01CC0", Offset = "0x6A002C0", VA = "0x186A01CC0")]
	public static bool CDPNCLEBJFB(float FAGKOOGCGBH, float HEOHCJKCOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6A02090", Offset = "0x6A00690", VA = "0x186A02090")]
	public static float JIFAALAGBOO(float CBAEIEAPLIH, float MDCIOHOLJPO, float HGPGLPENOMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6A020B0", Offset = "0x6A006B0", VA = "0x186A020B0")]
	public static int JIFAALAGBOO(int CBAEIEAPLIH, int MDCIOHOLJPO, int HGPGLPENOMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6A01CA0", Offset = "0x6A002A0", VA = "0x186A01CA0")]
	public static float CDEENIBNBJK(float CBAEIEAPLIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6A020F0", Offset = "0x6A006F0", VA = "0x186A020F0")]
	public static float NFDOFIGMMIE(float FAGKOOGCGBH, float HEOHCJKCOLM, float LBKJPGMAINP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6A01F70", Offset = "0x6A00570", VA = "0x186A01F70")]
	public static float GNALIHCLBFK(float FAGKOOGCGBH, float HEOHCJKCOLM, float LBKJPGMAINP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6A02190", Offset = "0x6A00790", VA = "0x186A02190")]
	public static float OIKMOPMDLGO(float FAGKOOGCGBH, float HEOHCJKCOLM, float CBAEIEAPLIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6A02340", Offset = "0x6A00940", VA = "0x186A02340")]
	public static float PIPINKDHJJP(float FAGKOOGCGBH, float HEOHCJKCOLM, float CBAEIEAPLIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6A020D0", Offset = "0x6A006D0", VA = "0x186A020D0")]
	public static float NBAENKBBCBE(float FAGKOOGCGBH, float HEOHCJKCOLM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6A01DB0", Offset = "0x6A003B0", VA = "0x186A01DB0")]
	public static float FPGIJMJGKEK(float FPACAFCPFNJ, float PKMPGPJICGL, float ALKNADDBJBJ, float HBAIAOIHGGB, float NBNJNGGMAEO, float DGOHALMDCDO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A01F80", Offset = "0x6A00580", VA = "0x186A01F80")]
	public static float HAGPBHGOIDL(float CBAEIEAPLIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6A02250", Offset = "0x6A00850", VA = "0x186A02250")]
	public static float OPEPLHJPLMH(float CBAEIEAPLIH, float MDCIOHOLJPO, float HGPGLPENOMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6A02010", Offset = "0x6A00610", VA = "0x186A02010")]
	public static float JHHIJGLLHKP(float LPLJAGJGDIM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class MKNONHMFKIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private System.Random KAHEJACCDAK;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A03500", Offset = "0x6A01B00", VA = "0x186A03500")]
	public MKNONHMFKIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A03480", Offset = "0x6A01A80", VA = "0x186A03480")]
	public MKNONHMFKIE(int JMJCDLBBEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6191510", Offset = "0x618FB10", VA = "0x186191510", Slot = "4")]
	public virtual int AOODDNLKEHF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A03420", Offset = "0x6A01A20", VA = "0x186A03420", Slot = "5")]
	public virtual int AOODDNLKEHF(int GOPPBIJIPFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A01820", Offset = "0x69FFE20", VA = "0x186A01820", Slot = "6")]
	public virtual int AOODDNLKEHF(int KAEMFHFEPKJ, int GOPPBIJIPFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6A03450", Offset = "0x6A01A50", VA = "0x186A03450")]
	public double JOCMFNDNLHD()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class HPNBFDEKGOK
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F9E0", Offset = "0x2B1DFE0", VA = "0x182B1F9E0")]
	[NONNNOEJCPN("This should be replaced with the `is not` operator in C# 9.")]
	public static bool HFBBHLFDKAJ<T>(this object OLDDCPCBGIL, [Out][NotNullWhen(true)] T HJBJAPKPPFA) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LGDDHFNFOCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6A030A0", Offset = "0x6A016A0", VA = "0x186A030A0")]
	public static (float3, float3, float3) NPHIBNFGKGE([In] this quaternion OLDDCPCBGIL)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A02680", Offset = "0x6A00C80", VA = "0x186A02680")]
	private static float3 MHLAKIHEHKA(quaternion KHGKPAHCJNA, math.RotationOrder CHLNHGEJFAN = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6A02460", Offset = "0x6A00A60", VA = "0x186A02460")]
	private static float3 EGIACNDDMII(float3 MHMMGMAOIOH, math.RotationOrder CHLNHGEJFAN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6A025C0", Offset = "0x6A00BC0", VA = "0x186A025C0")]
	public static float3 GBOPFKIKNPO(this quaternion KHGKPAHCJNA, math.RotationOrder CHLNHGEJFAN = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6A03190", Offset = "0x6A01790", VA = "0x186A03190")]
	public static float OEBDKPKIELF(this quaternion ILBMPADICAD, quaternion BEOPIALHGPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6A02530", Offset = "0x6A00B30", VA = "0x186A02530")]
	[CompilerGenerated]
	internal static float3 FAHCFIDPOAK(float3 MHMMGMAOIOH)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class EKLPMNNIAEM
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class JGLBBMMANHD : GLNFCEFKAMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly System.Random MAJKEGADJMA;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6A01820", Offset = "0x69FFE20", VA = "0x186A01820", Slot = "4")]
		public int AOODDNLKEHF(int MEMODFNJPKN, int BIPNHKGHNNA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6A01850", Offset = "0x69FFE50", VA = "0x186A01850", Slot = "5")]
		public float KPPKENJBIMH(float MEMODFNJPKN, float APEPFLMDDEA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6A018C0", Offset = "0x69FFEC0", VA = "0x186A018C0")]
		private double PFOGMJDEEHG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6A01900", Offset = "0x69FFF00", VA = "0x186A01900")]
		public JGLBBMMANHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly GLNFCEFKAMA LFBKCILOCBH;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6A00040", Offset = "0x69FE640", VA = "0x186A00040")]
	public static ulong HGDPKBODEPA()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class GAHFHKKHAPL
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2AFD080", Offset = "0x2AFB680", VA = "0x182AFD080")]
	public static bool GMNHNPNPMOE<T>(this IReadOnlyCollection<T> OLDDCPCBGIL, int LLPJHIPCNFD) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class OKHFAEBHDPK
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1430", Offset = "0x2C9FA30", VA = "0x182CA1430")]
	public static bool AHJCIFFFBKD<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> OLDDCPCBGIL, IReadOnlyDictionary<TKey, TValue> LJAAPFIIPOF) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class HIKLDKJHCDL
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2B0CC50", Offset = "0x2B0B250", VA = "0x182B0CC50")]
	public static TValue? DCEDEHACAMP<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> OLDDCPCBGIL, TKey BHEIPBKEDLG) where TValue : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class FMGELHDAJKB
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6A003A0", Offset = "0x69FE9A0", VA = "0x186A003A0")]
	public static void NGOOLELHLHP(this IReadOnlyList<Action> OLDDCPCBGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3ED0", Offset = "0x2AF24D0", VA = "0x182AF3ED0")]
	public static bool MMCLNKMOKEF<T>(this IReadOnlyList<T> OLDDCPCBGIL, int LLPJHIPCNFD, [Out][NotNullWhen(true)][DMMOHDONLFE("This should be `T?` in C# 9.")] T HJBJAPKPPFA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3DF0", Offset = "0x2AF23F0", VA = "0x182AF3DF0")]
	public static bool HDKMGDGNNGI<T>(this IReadOnlyList<T> OLDDCPCBGIL, int LLPJHIPCNFD, [Out] JJFNMLNAJJG<T> HJBJAPKPPFA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4020", Offset = "0x2AF2620", VA = "0x182AF4020")]
	public static T MMEPJGAJABK<T>(this IReadOnlyList<T> OLDDCPCBGIL, int LLPJHIPCNFD, [In] T CJLCFLFBIJH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3DA0", Offset = "0x2AF23A0", VA = "0x182AF3DA0")]
	[DMMOHDONLFE("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T GFHFOPHDGKD<T>(this IReadOnlyList<T> OLDDCPCBGIL, int LLPJHIPCNFD) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3CE0", Offset = "0x2AF22E0", VA = "0x182AF3CE0")]
	public static T? DCEDEHACAMP<T>(this IReadOnlyList<T> OLDDCPCBGIL, int LLPJHIPCNFD) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class GJCEPAIGHPD
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2B02180", Offset = "0x2B00780", VA = "0x182B02180")]
	public static int KNGEDAAOIAE<T>([In] this ReadOnlySequence<T> LEJKAHCECBB, [In] T CBAEIEAPLIH) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2B02480", Offset = "0x2B00A80", VA = "0x182B02480")]
	public static bool OLFGDECCCDJ<T>([In] this ReadOnlySequence<T> LEJKAHCECBB, [In] ReadOnlySpan<T> LJAAPFIIPOF) where T : IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class KOINNHLBDDM
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2BDEA20", Offset = "0x2BDD020", VA = "0x182BDEA20")]
	public static string CFFMECMPGKO<T>([In] this ReadOnlySpan<T> OLDDCPCBGIL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2BDEF00", Offset = "0x2BDD500", VA = "0x182BDEF00")]
	public static string DHBLNINAFBG<T>([In] this ReadOnlySpan<T> OLDDCPCBGIL, string CPKHBLKAMPN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HPIEMABFHMD
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static FKIPNNNOLMP MNHMHEBLAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6A00E10", Offset = "0x69FF410", VA = "0x186A00E10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6A00E60", Offset = "0x69FF460", VA = "0x186A00E60")]
	public static double IELJDLBMOLM(this FKIPNNNOLMP OLDDCPCBGIL, long KLANKACJOMK)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class MEFAFDIPKBJ : FKIPNNNOLMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly Stopwatch CMBOFALJFMI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long GIJBFFDACGM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6A032E0", Offset = "0x6A018E0", VA = "0x186A032E0", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	private MEFAFDIPKBJ(Stopwatch JBABMCMIKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6A03300", Offset = "0x6A01900", VA = "0x186A03300")]
	public static MEFAFDIPKBJ DLEIAOEHCJO(Stopwatch JBABMCMIKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6A03370", Offset = "0x6A01970", VA = "0x186A03370")]
	public static MEFAFDIPKBJ JMJFGFJLHNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class GAOJBKHHPEF
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6A007C0", Offset = "0x69FEDC0", VA = "0x186A007C0")]
	public static float3 HOJKBEIHGNJ([In] this RigidTransform OLDDCPCBGIL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6A00690", Offset = "0x69FEC90", VA = "0x186A00690")]
	public static float3 FNKHKAPNONC([In] this RigidTransform OLDDCPCBGIL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x955A20", Offset = "0x954020", VA = "0x180955A20")]
	public static (float3, float3, float3) CKDNKGHKJHE([In] this RigidTransform OLDDCPCBGIL)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6A00630", Offset = "0x69FEC30", VA = "0x186A00630")]
	public static RigidTransform BLMBPDALDHN([In] this RigidTransform OLDDCPCBGIL)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class BKFBJBPGJCM
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x69FFE90", Offset = "0x69FE490", VA = "0x1869FFE90")]
	public static RigidTransform BDMAPNGKKFD(RigidTransform DJDGCADFEIK, RigidTransform CECMGCJAJGH)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class CMKDNOJNEBP
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x69FFFD0", Offset = "0x69FE5D0", VA = "0x1869FFFD0")]
	public static float NLENNNMPBKE([In] this (byte Fourth, byte Third, byte Second, byte First) OLDDCPCBGIL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x69FFF50", Offset = "0x69FE550", VA = "0x1869FFF50")]
	public static int JKNMMNPFPNK(this float OLDDCPCBGIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x69FFF60", Offset = "0x69FE560", VA = "0x1869FFF60")]
	public static (byte, byte, byte, byte) LJAKENKCFIB(this float OLDDCPCBGIL)
	{
		return default((byte, byte, byte, byte));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class CJOHGCGGIDP
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2924140", Offset = "0x2922740", VA = "0x182924140")]
	public static ReadOnlySpan<T?> EILLHPFPLGG<T>([In] this Span<T> OLDDCPCBGIL)
	{
		return default(ReadOnlySpan<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class GFGCOOPNPIC
{
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static Regex NELHNMMLMLI;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static Regex GKCLEIBLJHG;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly char[] FGJKMOCGKPI;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5DC39A0", Offset = "0x5DC1FA0", VA = "0x185DC39A0")]
	public static bool DBFKMHDDMIO(this string? KEHAKFBOBOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6A009A0", Offset = "0x69FEFA0", VA = "0x186A009A0")]
	public static string? CNMHLCMHDPC(this string? OLDDCPCBGIL, int EFEECMADLHE, string JFOCDIGNIDE = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6A008F0", Offset = "0x69FEEF0", VA = "0x186A008F0")]
	public static string AJEHFMHPLGJ(this string OLDDCPCBGIL, int EFEECMADLHE, string JFOCDIGNIDE = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6A00A80", Offset = "0x69FF080", VA = "0x186A00A80")]
	public static int DDBACDOPBHH(this string KEHAKFBOBOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6A00AF0", Offset = "0x69FF0F0", VA = "0x186A00AF0")]
	public static string GCIKMMCFGKH(this string KEHAKFBOBOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6A00BB0", Offset = "0x69FF1B0", VA = "0x186A00BB0")]
	public static string[] NEPCPCJMHPJ(this string KEHAKFBOBOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class DBGPAFCEKDG<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public readonly struct OJAIPECBGKH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4676770", Offset = "0x4674D70", VA = "0x184676770", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static int IKCCNIHPPDF;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static BBMODPPBGLN EKFHANPFHBL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long GIJBFFDACGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x451D500", Offset = "0x451BB00", VA = "0x18451D500")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x57CCC00", Offset = "0x57CB200", VA = "0x1857CCC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x57CCC60", Offset = "0x57CB260", VA = "0x1857CCC60")]
	public static OJAIPECBGKH IAFMMLMBDAD()
	{
		return default(OJAIPECBGKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x57CCE20", Offset = "0x57CB420", VA = "0x1857CCE20")]
	private static void PGBHDGANFHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x57CCB80", Offset = "0x57CB180", VA = "0x1857CCB80")]
	public static void FDHFDDAAOOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct BBMODPPBGLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly FKIPNNNOLMP CMBOFALJFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly long IBHPFGFAFNE;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x69FFE20", Offset = "0x69FE420", VA = "0x1869FFE20")]
	public BBMODPPBGLN(FKIPNNNOLMP JBABMCMIKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x69FFD00", Offset = "0x69FE300", VA = "0x1869FFD00")]
	public long GFNCJAJFDHD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x69FFD90", Offset = "0x69FE390", VA = "0x1869FFD90")]
	public double IELJDLBMOLM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x69FFC70", Offset = "0x69FE270", VA = "0x1869FFC70")]
	public double CLCJOKKALOC()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class CPLEGAFMJLE
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6A00010", Offset = "0x69FE610", VA = "0x186A00010")]
	public static bool ACPHBLDFOCD(this Type OLDDCPCBGIL, Type LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x293FDF0", Offset = "0x293E3F0", VA = "0x18293FDF0")]
	public static bool ACPHBLDFOCD<T>(this Type OLDDCPCBGIL) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class IBBFGAKGMJA
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5A2D220", Offset = "0x5A2B820", VA = "0x185A2D220")]
	public static uint NHEIKNNJAFC(this uint OLDDCPCBGIL, int JPBPNOCHNLG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5AFD780", Offset = "0x5AFBD80", VA = "0x185AFD780")]
	public static uint FIBGGIGCMFG(this uint OLDDCPCBGIL, int JPBPNOCHNLG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6A00FE0", Offset = "0x69FF5E0", VA = "0x186A00FE0")]
	public static uint LGFJJBOKLCN(this uint OLDDCPCBGIL, uint JAMIGGIMPIA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x10400E0", Offset = "0x103E6E0", VA = "0x1810400E0")]
	public static int JKNMMNPFPNK(this uint OLDDCPCBGIL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class LOAMEKACMIH
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2BE8600", Offset = "0x2BE6C00", VA = "0x182BE8600")]
	public static bool BIOGNPEDNNE<T>([In] this T? OLDDCPCBGIL, [Out] T CBAEIEAPLIH) where T : struct
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
