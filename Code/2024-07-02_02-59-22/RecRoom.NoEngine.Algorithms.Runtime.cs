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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A380F0", Offset = "0x6A370F0", VA = "0x186A380F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890740", Offset = "0x88F740", VA = "0x180890740")]
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
		[Cpp2IlInjected.Address(RVA = "0x890780", Offset = "0x88F780", VA = "0x180890780")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A35090", Offset = "0x6A34090", VA = "0x186A35090")]
	public static bool DDCNFPFIIMN(string ALDEBAIFFFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A355E0", Offset = "0x6A345E0", VA = "0x186A355E0")]
	private static bool IPPPMIBPCNB(string NFOHONOFFAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A35490", Offset = "0x6A34490", VA = "0x186A35490")]
	public static bool IPPPMIBPCNB(Exception MKGEIKBIPFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A35160", Offset = "0x6A34160", VA = "0x186A35160")]
	public static string IIMJOCJBFKF(string KIBGJLLHGOJ, string JNNHDMKPDLF = "", bool GABHAEALBKD = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JPBPFOJCEOL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A35CA0", Offset = "0x6A34CA0", VA = "0x186A35CA0")]
	public static string FNNANCJMEFL(this Guid NNFEKLKANBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A35C00", Offset = "0x6A34C00", VA = "0x186A35C00")]
	public static string FNNANCJMEFL(this byte[] JFDEDKFKPOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A35B40", Offset = "0x6A34B40", VA = "0x186A35B40")]
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
			[Cpp2IlInjected.Address(RVA = "0x44D11A0", Offset = "0x44D01A0", VA = "0x1844D11A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x42C9C60", Offset = "0x42C8C60", VA = "0x1842C9C60")]
		public LFJECFCJCAH(T[] IJBMALMNANB, BHJJDAGCONA<T> BBLOHGJHCIM, int APIBOKMKFKI, Func<bool> CMJHLKNEPCD, T[]? GKOACNLHPNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x42C9930", Offset = "0x42C8930", VA = "0x1842C9930")]
		public bool JKDNJCJBNPK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate U NPOLIPCINDO<T, U>(int NOFOBMLPOIH, int DIHGKCAABDK, [In] ReadOnlySpan<T> MAHKJEHCFJG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x31BEDD0", Offset = "0x31BDDD0", VA = "0x1831BEDD0")]
	public static T[] BHNLMPBBNIP<T>(int ENCFHCJIMBE, T EMJOHPCKMDE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x31C0840", Offset = "0x31BF840", VA = "0x1831C0840")]
	public static void LJBJMKNEAAL<T>(this T[] JFIPEGBGGCH, T EMJOHPCKMDE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x31BFB90", Offset = "0x31BEB90", VA = "0x1831BFB90")]
	public static void JBMKFBCJMGF<T>(this T[] GGEMIJICFPG, int JFDIHIMJIHB, int CJEBBJDCFPG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x31BEFC0", Offset = "0x31BDFC0", VA = "0x1831BEFC0")]
	private static void GBHJMJHDOJO<T>(this T[] OLDDCPCBGIL, int JGBNJLJPLEB, int HAAJEBNPEGF, T[] LJAAPFIIPOF, int BJNDEKCNGGC, int KAGGLKHGOGI, T[] HJBJAPKPPFA, int HMHEOHONPFN, BHJJDAGCONA<T> BBLOHGJHCIM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x31BE9C0", Offset = "0x31BD9C0", VA = "0x1831BE9C0")]
	public static void AOJKMLFBECE<T>(this T[] OLDDCPCBGIL, int GEIGDPFELPO, int JPBPNOCHNLG, BHJJDAGCONA<T> BBLOHGJHCIM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x31C0780", Offset = "0x31BF780", VA = "0x1831C0780")]
	public static LFJECFCJCAH<T> LGECAOCKDDO<T>(this T[] OLDDCPCBGIL, BHJJDAGCONA<T> BBLOHGJHCIM, int APIBOKMKFKI, Func<bool> CMJHLKNEPCD, [Optional] T[]? GKOACNLHPNH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x31BEF70", Offset = "0x31BDF70", VA = "0x1831BEF70")]
	public static T[] EMJAFBBMHBK<T>(this T[] GGEMIJICFPG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x31BF390", Offset = "0x31BE390", VA = "0x1831BF390")]
	public static T[] HEENNJCDKNI<T>(this T[] ADHHMNDCDMA, T DLLJKHLNMFB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x31BFEB0", Offset = "0x31BEEB0", VA = "0x1831BFEB0")]
	public static T[] LBGBGLBGNFL<T>(this T[] ADHHMNDCDMA, int LLPJHIPCNFD, T DLLJKHLNMFB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x31BE910", Offset = "0x31BD910", VA = "0x1831BE910")]
	public static T[] AOBHDGHAANP<T>(this T[] ADHHMNDCDMA, int LLPJHIPCNFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x31BFC10", Offset = "0x31BEC10", VA = "0x1831BFC10")]
	public static T[] JOENELFPLBL<T>(this T[] ADHHMNDCDMA, int LLPJHIPCNFD, T DLLJKHLNMFB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x31BF4E0", Offset = "0x31BE4E0", VA = "0x1831BF4E0")]
	public static U[] HHAKAFMNDBN<U, T>(this T[] ONEIHMPFJKE, int ODNANBHOKHB, NPOLIPCINDO<T, U> ODIJGMHMGBC) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A33A80", Offset = "0x6A32A80", VA = "0x186A33A80")]
	public static byte[] OHMIGINJCFC(this byte[] OLDDCPCBGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A33800", Offset = "0x6A32800", VA = "0x186A33800")]
	public static byte[] JMLHBAPMICI(this byte[] OLDDCPCBGIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GKGNFDJEONJ
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A34EA0", Offset = "0x6A33EA0", VA = "0x186A34EA0")]
	public static byte NPLOPDMDJGA(this bool OLDDCPCBGIL)
	{
		return default(byte);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MPLJLEFDAEH
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A34EA0", Offset = "0x6A33EA0", VA = "0x186A34EA0")]
	public static bool FOLHKINMINK(this byte OLDDCPCBGIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DMKAJIGNHAL
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2981E40", Offset = "0x2980E40", VA = "0x182981E40")]
	public static void MGFPFFGFDNB<T>(this ICollection<T> OLDDCPCBGIL, IEnumerable<T> FKCOHIKICFN) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class AOELBDALHME
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x31C17E0", Offset = "0x31C07E0", VA = "0x1831C17E0")]
	public static void EECGPMMCDPN<K, V>(this IDictionary<K, V> OLDDCPCBGIL, [In] K BHEIPBKEDLG, [In] V CBAEIEAPLIH, Func<V, V, V> LNBOIPDJODC) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x31C20E0", Offset = "0x31C10E0", VA = "0x1831C20E0")]
	public static void JAKIINMOLLE<K, V>(this IDictionary<K, List<V>> OLDDCPCBGIL, [In] K BHEIPBKEDLG, [In] V CBAEIEAPLIH) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x31C0E00", Offset = "0x31BFE00", VA = "0x1831C0E00")]
	public static TVal ECLIHBNIDDO<TVal, TKey>(this IDictionary<TKey, TVal> OLGJECBHAKN, [In] TKey BHEIPBKEDLG, [Optional][DMMOHDONLFE("`default!` shouldn't be necessary in C# 9")] TVal AJMLHGDNPEK) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x31C0A40", Offset = "0x31BFA40", VA = "0x1831C0A40")]
	public static TVal ECLIHBNIDDO<TVal, TKey>(this IDictionary<TKey, TVal> OLGJECBHAKN, [In] TKey BHEIPBKEDLG, Func<TVal> GHIDHABMDKA) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x31C2CC0", Offset = "0x31C1CC0", VA = "0x1831C2CC0")]
	public static TValue LDHPDKNBLHM<TValue, TKey>(this IDictionary<TKey, TValue> OLGJECBHAKN, [In] TKey BHEIPBKEDLG, [Optional][In][DMMOHDONLFE("`default!` and null-oblivious region shouldn't be necessary in C# 9")] TValue AJMLHGDNPEK)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x31C27D0", Offset = "0x31C17D0", VA = "0x1831C27D0")]
	public static V KGDBMLPJMNA<V, K>(this IDictionary<K, V> OLDDCPCBGIL, [In] K BHEIPBKEDLG) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x31C2710", Offset = "0x31C1710", VA = "0x1831C2710")]
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
		[Cpp2IlInjected.Address(RVA = "0x46CC6B0", Offset = "0x46CB6B0", VA = "0x1846CC6B0")]
		[DMMOHDONLFE("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) BCNGCAIHPNC(T IDMCNLPCONC)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x46CC710", Offset = "0x46CB710", VA = "0x1846CC710")]
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
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8BF370", Offset = "0x8BE370", VA = "0x1808BF370")]
		[DebuggerHidden]
		public CHMJLGCKLON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x51685F0", Offset = "0x51675F0", VA = "0x1851685F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5167E70", Offset = "0x5166E70", VA = "0x185167E70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5168200", Offset = "0x5167200", VA = "0x185168200")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5167650", Offset = "0x5166650", VA = "0x185167650")]
		private void LAOHPFDNJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x51685A0", Offset = "0x51675A0", VA = "0x1851685A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5168300", Offset = "0x5167300", VA = "0x185168300", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA900", Offset = "0x3AD9900", VA = "0x183ADA900", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x38B4440", Offset = "0x38B3440", VA = "0x1838B4440", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x42C4690", Offset = "0x42C3690", VA = "0x1842C4690", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1E99BF0", Offset = "0x1E98BF0", VA = "0x181E99BF0")]
		[DebuggerHidden]
		public LDHCIPIIEJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8660", Offset = "0x3AD7660", VA = "0x183AD8660", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x42C3BF0", Offset = "0x42C2BF0", VA = "0x1842C3BF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x42C4130", Offset = "0x42C3130", VA = "0x1842C4130")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x42C45F0", Offset = "0x42C35F0", VA = "0x1842C45F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x42C4470", Offset = "0x42C3470", VA = "0x1842C4470", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, GBGJJMPMMOC<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA900", Offset = "0x3AD9900", VA = "0x183ADA900", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF370", Offset = "0x8BE370", VA = "0x1808BF370")]
		[DebuggerHidden]
		public CJIDLBHJBDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x516F390", Offset = "0x516E390", VA = "0x18516F390", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x516EE60", Offset = "0x516DE60", VA = "0x18516EE60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x516F2F0", Offset = "0x516E2F0", VA = "0x18516F2F0")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x516EE10", Offset = "0x516DE10", VA = "0x18516EE10")]
		private void LAOHPFDNJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x516F340", Offset = "0x516E340", VA = "0x18516F340", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E6F0", Offset = "0x3C0D6F0", VA = "0x183C0E6F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x37E0950", Offset = "0x37DF950", VA = "0x1837E0950", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public FLNCKABNKDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3C737F0", Offset = "0x3C727F0", VA = "0x183C737F0")]
		internal bool NKCHDNLPNJK(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3C73730", Offset = "0x3C72730", VA = "0x183C73730")]
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
			[Cpp2IlInjected.Address(RVA = "0xC43BD0", Offset = "0xC42BD0", VA = "0x180C43BD0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C09AB0", Offset = "0x3C08AB0", VA = "0x183C09AB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1E99BF0", Offset = "0x1E98BF0", VA = "0x181E99BF0")]
		[DebuggerHidden]
		public JAKOOJLFAID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x407BB60", Offset = "0x407AB60", VA = "0x18407BB60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x407BE70", Offset = "0x407AE70", VA = "0x18407BE70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x407BD90", Offset = "0x407AD90", VA = "0x18407BD90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA900", Offset = "0x3AD9900", VA = "0x183ADA900", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2BB43B0", Offset = "0x2BB33B0", VA = "0x182BB43B0")]
	public static bool HIFNAFADBOA<T, TArgs>(this IEnumerable<T> OLDDCPCBGIL, [In] TArgs NENLABMEOHA, CONKHFEIEID<TArgs, T> IBNKJLLIEAG) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A35A20", Offset = "0x6A34A20", VA = "0x186A35A20")]
	public static bool HIFNAFADBOA(this IEnumerable<bool> OLDDCPCBGIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2BF0", Offset = "0x2BB1BF0", VA = "0x182BB2BF0")]
	public static U DLAAOMNCHKO<U, T>(this IEnumerable<T> OLDDCPCBGIL, Func<U> PMDNEADHCBJ, Func<T, U> IDMCNLPCONC, Func<IEnumerable<T>, U> GMHDDNFAELJ) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2BB25F0", Offset = "0x2BB15F0", VA = "0x182BB25F0")]
	public static bool DJABGNMGFMO<T, TArgs>(this IEnumerable<T> OLDDCPCBGIL, [In] TArgs NENLABMEOHA, CONKHFEIEID<TArgs, T> IBNKJLLIEAG) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6330", Offset = "0x2BB5330", VA = "0x182BB6330")]
	public static U MMDJEAGFBFJ<U, T, TArg>(this IEnumerable<T> OLDDCPCBGIL, [In] TArg HFLBLCMJIKA, AGDFACNFOMK<TArg, U> PMDNEADHCBJ, GECKDJLOBPF<TArg, T, U> IDMCNLPCONC, HJLILKFIHGP<TArg, T, U> GMHDDNFAELJ) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2030", Offset = "0x2BB1030", VA = "0x182BB2030")]
	public static IEnumerable<U> CLPJNPHBOKK<U, T, TArg>(this IEnumerable<T> OLDDCPCBGIL, [In] TArg HFLBLCMJIKA, CGKMGDJMGCN<TArg, T, U> OOEOCNGCCGO) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x29A0BA0", Offset = "0x299FBA0", VA = "0x1829A0BA0")]
	public static IEnumerable<T> LNDBJPDNMDF<T>(params IEnumerable<T>[] IFAODIHNEAD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2E60", Offset = "0x2BB1E60", VA = "0x182BB2E60")]
	public static bool FLFAEODCAKN<T>(this IEnumerable<T> CHNGFEKJHON, IEnumerable<T> LJAAPFIIPOF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x29A0BA0", Offset = "0x299FBA0", VA = "0x1829A0BA0")]
	public static IEnumerable<(TKey?, TValue?)>? KFABLHFKDLF<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> OLDDCPCBGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7270", Offset = "0x2BB6270", VA = "0x182BB7270")]
	public static IEnumerable<T> PPMMLAFPCEH<T, TKey>(this IEnumerable<T> GNLOFBLAPLO, Func<T, TKey> NKINLFLJLIA) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3AF0", Offset = "0x2AA2AF0", VA = "0x182AA3AF0")]
	[IteratorStateMachine(typeof(CHMJLGCKLON<, >))]
	public static IEnumerable<T> LPOIBGELBDM<T, U>(this IEnumerable<T> OLDDCPCBGIL, IEnumerable<U> LJAAPFIIPOF, [Optional][DMMOHDONLFE("`default!` shouldn't be necessary in C# 9")] T EMJOHPCKMDE) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2835180", Offset = "0x2834180", VA = "0x182835180")]
	public static T HPEAJBJJJEH<T>(this IEnumerable<T> CHNGFEKJHON, T AJMLHGDNPEK) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4830", Offset = "0x2BB3830", VA = "0x182BB4830")]
	public static T HPEAJBJJJEH<T>(this IEnumerable<T> CHNGFEKJHON, T AJMLHGDNPEK, Func<T, bool> IBNKJLLIEAG) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3660", Offset = "0x2BB2660", VA = "0x182BB3660")]
	public static T? GPPACACOJPN<T>(this IEnumerable<T> OLDDCPCBGIL, Func<T, bool> IBNKJLLIEAG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5390", Offset = "0x2BB4390", VA = "0x182BB5390")]
	public static void JALBOCHMIPI<T>(this IEnumerable<T> OLDDCPCBGIL, Action<T> DOLDDKPNFFE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2A4D8E0", Offset = "0x2A4C8E0", VA = "0x182A4D8E0")]
	[IteratorStateMachine(typeof(LDHCIPIIEJK<>))]
	public static IEnumerable<(T, GBGJJMPMMOC<T>)> OIJFMEDCDIC<T>(this IEnumerable<T> OLDDCPCBGIL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6090", Offset = "0x2BB5090", VA = "0x182BB6090")]
	public static bool LGDPGCKOGAA<T>(this IEnumerable<T> OLDDCPCBGIL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x29A0BA0", Offset = "0x299FBA0", VA = "0x1829A0BA0")]
	public static IEnumerable<JJFNMLNAJJG<T>> FPNFNABMIOF<T>(this IEnumerable<T> OLDDCPCBGIL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2570", Offset = "0x2BB1570", VA = "0x182BB2570")]
	public static bool DFLAHLKBLGO<T>(this IEnumerable<T> OLDDCPCBGIL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6050", Offset = "0x2BB5050", VA = "0x182BB6050")]
	public static IEnumerable<T> KLKEIOKCEEG<T>(this IEnumerable<T>? OLDDCPCBGIL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A4D570", Offset = "0x2A4C570", VA = "0x182A4D570")]
	[IteratorStateMachine(typeof(CJIDLBHJBDG<, >))]
	public static IEnumerable<U> GLJBPPILODC<U, T>(this IEnumerable<T> OLDDCPCBGIL, Func<OPJEFPAIFKB<U>, T, (bool Zero, U One, IEnumerable<U> Many)> IKONPJFCLCH) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6D70", Offset = "0x2BB5D70", VA = "0x182BB6D70")]
	public static int NJMIFDGAHFA<T>(this IEnumerable<T> OLDDCPCBGIL, int EHECGJLCGOD = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5DE0", Offset = "0x2BB4DE0", VA = "0x182BB5DE0")]
	public static bool KENAHFINMDI<T>(this IEnumerable<T> OLDDCPCBGIL, IEnumerable<T> LJAAPFIIPOF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2BB61C0", Offset = "0x2BB51C0", VA = "0x182BB61C0")]
	public static IEnumerable<T> LPFNMONFLLB<T>(this IEnumerable<T> OLDDCPCBGIL, int CFKFFPNNJCH, int HAHAJHDNKFA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2BB1590", Offset = "0x2BB0590", VA = "0x182BB1590")]
	public static (IEnumerable<T>, IEnumerable<T>) BGGAJPDNIIN<T>(this IEnumerable<T> OLDDCPCBGIL, Func<T, bool> LKBLLIHJCIH) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2BB1AE0", Offset = "0x2BB0AE0", VA = "0x182BB1AE0")]
	public static string CFFMECMPGKO<T>(this IEnumerable<T> OLDDCPCBGIL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3050", Offset = "0x2BB2050", VA = "0x182BB3050")]
	public static Dictionary<TKey?, TValue?>? GLONKJOJMOP<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> CHNGFEKJHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3050", Offset = "0x2BB2050", VA = "0x182BB3050")]
	public static Dictionary<TKey?, TValue?>? GLONKJOJMOP<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> CHNGFEKJHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2B30", Offset = "0x2BB1B30", VA = "0x182BB2B30")]
	public static List<T> DJKBKMDEEGN<T>(this IEnumerable<T> OLDDCPCBGIL, int NAFKLJDAKHD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2BB25B0", Offset = "0x2BB15B0", VA = "0x182BB25B0")]
	public static string DHBLNINAFBG<T>(this IEnumerable<T> OLDDCPCBGIL, string CPKHBLKAMPN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2BB48B0", Offset = "0x2BB38B0", VA = "0x182BB48B0")]
	public static (IReadOnlyList<T?>?, IReadOnlyList<U?>?) IIDHMLGDECG<T, U>(this IEnumerable<(T Lhs, U Rhs)> OLDDCPCBGIL)
	{
		return default((IReadOnlyList<T>, IReadOnlyList<U>));
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2A69CD0", Offset = "0x2A68CD0", VA = "0x182A69CD0")]
	[IteratorStateMachine(typeof(JAKOOJLFAID<, >))]
	public static IEnumerable<(T, U)> FEHELBBAIEB<T, U>(this IEnumerable<T> ILBMPADICAD, IEnumerable<U> BEOPIALHGPL) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2BB12E0", Offset = "0x2BB02E0", VA = "0x182BB12E0")]
	public static IEnumerable<V> AAHKIAANAMH<V, T, U>(this IEnumerable<T> OLDDCPCBGIL, IEnumerable<U> LJAAPFIIPOF, Func<T, U, V> LPIBEGJPEBK, [Optional][DMMOHDONLFE("`default!` shouldn't be necessary in C# 9")] T NHOEMMGABPB, [Optional][DMMOHDONLFE("`default!` shouldn't be necessary in C# 9")] U EGBHDJACENJ) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2BB13B0", Offset = "0x2BB03B0", VA = "0x182BB13B0")]
	public static IEnumerable<(T, U)> AAHKIAANAMH<T, U>(this IEnumerable<T> OLDDCPCBGIL, IEnumerable<U> LJAAPFIIPOF, [Optional][DMMOHDONLFE("`default!` shouldn't be necessary in C# 9")] T NHOEMMGABPB, [Optional][DMMOHDONLFE("`default!` shouldn't be necessary in C# 9")] U EGBHDJACENJ) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6830", Offset = "0x2BB5830", VA = "0x182BB6830")]
	public static TOut[] NEPFMHMELBM<TOut, TIn>(this IEnumerable<TIn> GNLOFBLAPLO, Func<TIn, TOut> LAOEBFAJLCK) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class JCEPHNHNEJE
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2B83E90", Offset = "0x2B82E90", VA = "0x182B83E90")]
	public static bool KBGKBECJOAE<T, U>(this T OLDDCPCBGIL, [In] U HBFCGFKGCAF) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2B83DF0", Offset = "0x2B82DF0", VA = "0x182B83DF0")]
	public static bool ICOBFAOOIDA<T>(T OLDDCPCBGIL, T LJAAPFIIPOF) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class NMEFIDKGAOF
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xB66AB0", Offset = "0xB65AB0", VA = "0x180B66AB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8D7510", Offset = "0x8D6510", VA = "0x1808D7510", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BFD570", Offset = "0x3BFC570", VA = "0x183BFD570", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA82910", Offset = "0xA81910", VA = "0x180A82910")]
		[DebuggerHidden]
		public NJNCJKFMHAO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4589600", Offset = "0x4588600", VA = "0x184589600", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4589900", Offset = "0x4588900", VA = "0x184589900", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x45897E0", Offset = "0x45887E0", VA = "0x1845897E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x39126A0", Offset = "0x39116A0", VA = "0x1839126A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B19E00", Offset = "0x2B18E00", VA = "0x182B19E00")]
	public static void HGBHJHJDHDK<T>(this T LBKJPGMAINP, Action<T> KJAKEPEGKNI) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B19FF0", Offset = "0x2B18FF0", VA = "0x182B19FF0")]
	public static V NNMLGGBGOBH<V, T>(this T LBKJPGMAINP, Func<T, V> KJAKEPEGKNI, [Optional][DMMOHDONLFE("`default!` shouldn't be necessary in C# 9")] V AJMLHGDNPEK) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2B19F70", Offset = "0x2B18F70", VA = "0x182B19F70")]
	public static T? MNPGJIOLMCP<T>(this T OLDDCPCBGIL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2B19E50", Offset = "0x2B18E50", VA = "0x182B19E50")]
	[IteratorStateMachine(typeof(NJNCJKFMHAO<>))]
	public static IEnumerable<T> HKFOAGHOGLM<T>(this T OLDDCPCBGIL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2B19D40", Offset = "0x2B18D40", VA = "0x182B19D40")]
	public static T[] COBGMEIIENM<T>(this T OLDDCPCBGIL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class NNHHHDHOFLA
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A37630", Offset = "0x6A36630", VA = "0x186A37630")]
	private static byte[] CNNPAEPGFKG(int OFNCOECPHHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A37E20", Offset = "0x6A36E20", VA = "0x186A37E20")]
	private static byte[] IBOIJPKINHH(long CMPFGKCKFBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A37DA0", Offset = "0x6A36DA0", VA = "0x186A37DA0")]
	private static byte[] HPEECHCFDDF(ulong CMPFGKCKFBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A37F30", Offset = "0x6A36F30", VA = "0x186A37F30")]
	public static Guid OEBLPMOAKLA(params Guid[] OIEGFCIFPMN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A376B0", Offset = "0x6A366B0", VA = "0x186A376B0")]
	public static Guid GIGNPOIHFIA([In] Guid FAMAKKHFFLG, int LLPJHIPCNFD, int HNNOPDLCPBM = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A378C0", Offset = "0x6A368C0", VA = "0x186A378C0")]
	public static Guid GIGNPOIHFIA([In] Guid FAMAKKHFFLG, long LLPJHIPCNFD, int HNNOPDLCPBM = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A377F0", Offset = "0x6A367F0", VA = "0x186A377F0")]
	public static Guid GIGNPOIHFIA([In] Guid FAMAKKHFFLG, ulong LLPJHIPCNFD, int HNNOPDLCPBM = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A37780", Offset = "0x6A36780", VA = "0x186A37780")]
	public static Guid GIGNPOIHFIA([In] Guid FAMAKKHFFLG, [In] Guid IHLCHIDEJHN, int HNNOPDLCPBM = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A37990", Offset = "0x6A36990", VA = "0x186A37990")]
	private static Guid GIGNPOIHFIA([In] Guid FAMAKKHFFLG, byte[] GMPDDGMLPHB, int HNNOPDLCPBM = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A37EA0", Offset = "0x6A36EA0", VA = "0x186A37EA0")]
	private static void KEHBNKAFAAJ(byte[] NNFEKLKANBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A380A0", Offset = "0x6A370A0", VA = "0x186A380A0")]
	private static void PPLNNBDBHJN(byte[] NNFEKLKANBO, int KKEPMPAJLEA, int HIEMMBKCCDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class PPHFBFJKPIB
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A382B0", Offset = "0x6A372B0", VA = "0x186A382B0")]
	public static int MJFHHMLOJAJ(this int OLDDCPCBGIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A38170", Offset = "0x6A37170", VA = "0x186A38170")]
	public static int BKCBCGMBJLP(this int OLDDCPCBGIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A381B0", Offset = "0x6A371B0", VA = "0x186A381B0")]
	public static int DEMABGJDNNG(this int OLDDCPCBGIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A38320", Offset = "0x6A37320", VA = "0x186A38320")]
	public static int OBOPDCGOBAE(this int OLDDCPCBGIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5A55610", Offset = "0x5A54610", VA = "0x185A55610")]
	public static int NHEIKNNJAFC(this int OLDDCPCBGIL, int JPBPNOCHNLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5B25CA0", Offset = "0x5B24CA0", VA = "0x185B25CA0")]
	public static int FIBGGIGCMFG(this int OLDDCPCBGIL, int JPBPNOCHNLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A38220", Offset = "0x6A37220", VA = "0x186A38220")]
	public static float LIHIHBEOKDC(this int OLDDCPCBGIL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A38240", Offset = "0x6A37240", VA = "0x186A38240")]
	public static (byte, byte, byte, byte) LJAKENKCFIB(this int OLDDCPCBGIL)
	{
		return default((byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A38200", Offset = "0x6A37200", VA = "0x186A38200")]
	public static int HAFBKDDNMHK([In] this (byte Fourth, byte Third, byte Second, byte First) OLDDCPCBGIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6A38340", Offset = "0x6A37340", VA = "0x186A38340")]
	public static int PJNFJDBKFIG(this int OLDDCPCBGIL, int HLEJOHAKKML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6A38330", Offset = "0x6A37330", VA = "0x186A38330")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B04D50", Offset = "0x2B03D50", VA = "0x182B04D50")]
	public static (TKey?, TValue?) HEAJOCGEKBE<TKey, TValue>([In] this KeyValuePair<TKey, TValue> OLDDCPCBGIL)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2B04E50", Offset = "0x2B03E50", VA = "0x182B04E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public LFPEPJGIADG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x42CAA30", Offset = "0x42C9A30", VA = "0x1842CAA30")]
		internal TElement KPOGPGIJNPG(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x294DBA0", Offset = "0x294CBA0", VA = "0x18294DBA0")]
	public static int OMCMGLDIJNG<T>(this IReadOnlyList<T> GGEMIJICFPG, T CBAEIEAPLIH) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2947AA0", Offset = "0x2946AA0", VA = "0x182947AA0")]
	public static int FMKOONFLHEN<T>(this IReadOnlyList<T> GGEMIJICFPG, T CBAEIEAPLIH) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x294C330", Offset = "0x294B330", VA = "0x18294C330")]
	public static void MGFPFFGFDNB<T>(this HashSet<T> PDGHONNCIEM, IEnumerable<T> FKCOHIKICFN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x29483A0", Offset = "0x29473A0", VA = "0x1829483A0")]
	public static void GCEJCKODJFM<T>(this IList<T> DNOAHHGKGFF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2948050", Offset = "0x2947050", VA = "0x182948050")]
	public static void GCEJCKODJFM<T>(this IList<T> DNOAHHGKGFF, int JMJCDLBBEKN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x294B7B0", Offset = "0x294A7B0", VA = "0x18294B7B0")]
	public static void KEKLCNIODIJ<T>(this List<T> DNOAHHGKGFF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x294ADE0", Offset = "0x2949DE0", VA = "0x18294ADE0")]
	public static List<T> GNNODOENFAD<T>(this List<T> NECCMDHDJPN, Predicate<T> CFCBHHEKCIK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x294E370", Offset = "0x294D370", VA = "0x18294E370")]
	public static int OMCMGLDIJNG<T>(this IReadOnlyList<T> DNOAHHGKGFF, Predicate<T> IBNKJLLIEAG) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x294B280", Offset = "0x294A280", VA = "0x18294B280")]
	public static bool IKGIMGAOCLN<T>(this IReadOnlyList<T> DNOAHHGKGFF, Predicate<T> IBNKJLLIEAG, [Out][NotNullWhen(true)] List<int>? DGLAKPCPOIA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2950120", Offset = "0x294F120", VA = "0x182950120")]
	public static bool PMELAKIMKGE<T>(this IReadOnlyList<T> DNOAHHGKGFF, T OPNLGJFHDEP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x294FFC0", Offset = "0x294EFC0", VA = "0x18294FFC0")]
	public static bool PMELAKIMKGE<T>(this IReadOnlyList<T> DNOAHHGKGFF, T OPNLGJFHDEP, EqualityComparer<T> PJCHJFCBECF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x294F060", Offset = "0x294E060", VA = "0x18294F060")]
	public static int PDLLODCBMJE<TElement, TKey>(this IList<TElement> NKHCKIOILAG, TKey ILLFGKNOBGI, Func<TElement, TKey> IEMMCFPNMFN, [Optional] Func<TKey, TKey, int>? BBLOHGJHCIM, int LLPJHIPCNFD = 0, [Optional] int? JPBPNOCHNLG) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x294E920", Offset = "0x294D920", VA = "0x18294E920")]
	public static int PDLLODCBMJE<TElement, TKey>(Func<int, TElement> FPACFMNOKGH, int GAIJHPGLHHA, TKey ILLFGKNOBGI, Func<TElement, TKey> IEMMCFPNMFN, [Optional] Func<TKey, TKey, int>? BBLOHGJHCIM, int LLPJHIPCNFD = 0, [Optional] int? JPBPNOCHNLG) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x29477E0", Offset = "0x29467E0", VA = "0x1829477E0")]
	public static bool FKDACHFGGDG<T>(this List<T> DNOAHHGKGFF, T OPNLGJFHDEP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x294AF60", Offset = "0x2949F60", VA = "0x18294AF60")]
	public static void HFMNBNHLMMK<T>(this List<T> DNOAHHGKGFF, IEnumerable<T> NECCMDHDJPN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2947E50", Offset = "0x2946E50", VA = "0x182947E50")]
	public static void GAGDAFIMOPK<T>(this List<T> DNOAHHGKGFF, IEnumerable<T> NECCMDHDJPN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x294D450", Offset = "0x294C450", VA = "0x18294D450")]
	public static T MLPOAIPAAHH<T>(this List<T> NECCMDHDJPN, Predicate<T> CFCBHHEKCIK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2947740", Offset = "0x2946740", VA = "0x182947740")]
	public static T EJCLDPHJDLF<T>(this List<T> NECCMDHDJPN, int LLPJHIPCNFD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x294C110", Offset = "0x294B110", VA = "0x18294C110")]
	public static void MAFLKMDCAIA<T>(this List<T> DNOAHHGKGFF, int LLPJHIPCNFD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x294B190", Offset = "0x294A190", VA = "0x18294B190")]
	public static bool IJPFLICCIKA<T>(this List<T> IPBBLALLNPN, List<T> OKPFJAJLDPF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2947400", Offset = "0x2946400", VA = "0x182947400")]
	public static T BALEBNBNOBE<T>(this IList<T> DNOAHHGKGFF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2947640", Offset = "0x2946640", VA = "0x182947640")]
	public static bool DBBKKDKOFKA<T>(IReadOnlyList<T>? DNOAHHGKGFF, int LLPJHIPCNFD, [Out][MaybeNullWhen(false)][DMMOHDONLFE("This should be `T?` in C# 9.")] T HJBJAPKPPFA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2949DC0", Offset = "0x2948DC0", VA = "0x182949DC0")]
	public static bool GGKHOGCCMDC<T>(IReadOnlyList<T> DNOAHHGKGFF, ICollection NECCMDHDJPN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x294D4E0", Offset = "0x294C4E0", VA = "0x18294D4E0")]
	public static void NBMDPANOLDA<T>(IReadOnlyList<T> DNOAHHGKGFF, ICollection NECCMDHDJPN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x29476F0", Offset = "0x29466F0", VA = "0x1829476F0")]
	public static bool DBFKMHDDMIO<T>(this IReadOnlyList<T> DNOAHHGKGFF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2947C90", Offset = "0x2946C90", VA = "0x182947C90")]
	public static string FNGBHCMOKKJ<T>(this IEnumerable<T> DNOAHHGKGFF, string HDNJOPANICE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x294DA30", Offset = "0x294CA30", VA = "0x18294DA30")]
	public static T NGHHPHDLBMB<T>(this IList<T> OLDDCPCBGIL) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x294BC70", Offset = "0x294AC70", VA = "0x18294BC70")]
	public static T LCNPNBEKCEL<T>(this IList<T> OLDDCPCBGIL) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x294B720", Offset = "0x294A720", VA = "0x18294B720")]
	public static void KDMOBIANILD<T>(this IList<T> OLDDCPCBGIL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x29474A0", Offset = "0x29464A0", VA = "0x1829474A0")]
	public static void CAPFMAIJPNK<T>(this IList<T> OLDDCPCBGIL, [In] T CBAEIEAPLIH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x294D6B0", Offset = "0x294C6B0", VA = "0x18294D6B0")]
	public static T NFJCMKAIANL<T>(this IList<T> OLDDCPCBGIL) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x294BE90", Offset = "0x294AE90", VA = "0x18294BE90")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A35D60", Offset = "0x6A34D60", VA = "0x186A35D60")]
	public static bool CDPNCLEBJFB(float FAGKOOGCGBH, float HEOHCJKCOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6A36130", Offset = "0x6A35130", VA = "0x186A36130")]
	public static float JIFAALAGBOO(float CBAEIEAPLIH, float MDCIOHOLJPO, float HGPGLPENOMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6A36150", Offset = "0x6A35150", VA = "0x186A36150")]
	public static int JIFAALAGBOO(int CBAEIEAPLIH, int MDCIOHOLJPO, int HGPGLPENOMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6A35D40", Offset = "0x6A34D40", VA = "0x186A35D40")]
	public static float CDEENIBNBJK(float CBAEIEAPLIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6A36190", Offset = "0x6A35190", VA = "0x186A36190")]
	public static float NFDOFIGMMIE(float FAGKOOGCGBH, float HEOHCJKCOLM, float LBKJPGMAINP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6A36010", Offset = "0x6A35010", VA = "0x186A36010")]
	public static float GNALIHCLBFK(float FAGKOOGCGBH, float HEOHCJKCOLM, float LBKJPGMAINP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6A36230", Offset = "0x6A35230", VA = "0x186A36230")]
	public static float OIKMOPMDLGO(float FAGKOOGCGBH, float HEOHCJKCOLM, float CBAEIEAPLIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6A363E0", Offset = "0x6A353E0", VA = "0x186A363E0")]
	public static float PIPINKDHJJP(float FAGKOOGCGBH, float HEOHCJKCOLM, float CBAEIEAPLIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6A36170", Offset = "0x6A35170", VA = "0x186A36170")]
	public static float NBAENKBBCBE(float FAGKOOGCGBH, float HEOHCJKCOLM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6A35E50", Offset = "0x6A34E50", VA = "0x186A35E50")]
	public static float FPGIJMJGKEK(float FPACAFCPFNJ, float PKMPGPJICGL, float ALKNADDBJBJ, float HBAIAOIHGGB, float NBNJNGGMAEO, float DGOHALMDCDO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A36020", Offset = "0x6A35020", VA = "0x186A36020")]
	public static float HAGPBHGOIDL(float CBAEIEAPLIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6A362F0", Offset = "0x6A352F0", VA = "0x186A362F0")]
	public static float OPEPLHJPLMH(float CBAEIEAPLIH, float MDCIOHOLJPO, float HGPGLPENOMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6A360B0", Offset = "0x6A350B0", VA = "0x186A360B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A375A0", Offset = "0x6A365A0", VA = "0x186A375A0")]
	public MKNONHMFKIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A37520", Offset = "0x6A36520", VA = "0x186A37520")]
	public MKNONHMFKIE(int JMJCDLBBEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x61BAA80", Offset = "0x61B9A80", VA = "0x1861BAA80", Slot = "4")]
	public virtual int AOODDNLKEHF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A374C0", Offset = "0x6A364C0", VA = "0x186A374C0", Slot = "5")]
	public virtual int AOODDNLKEHF(int GOPPBIJIPFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A358C0", Offset = "0x6A348C0", VA = "0x186A358C0", Slot = "6")]
	public virtual int AOODDNLKEHF(int KAEMFHFEPKJ, int GOPPBIJIPFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6A374F0", Offset = "0x6A364F0", VA = "0x186A374F0")]
	public double JOCMFNDNLHD()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class HPNBFDEKGOK
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2B38710", Offset = "0x2B37710", VA = "0x182B38710")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A37140", Offset = "0x6A36140", VA = "0x186A37140")]
	public static (float3, float3, float3) NPHIBNFGKGE([In] this quaternion OLDDCPCBGIL)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A36720", Offset = "0x6A35720", VA = "0x186A36720")]
	private static float3 MHLAKIHEHKA(quaternion KHGKPAHCJNA, math.RotationOrder CHLNHGEJFAN = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6A36500", Offset = "0x6A35500", VA = "0x186A36500")]
	private static float3 EGIACNDDMII(float3 MHMMGMAOIOH, math.RotationOrder CHLNHGEJFAN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6A36660", Offset = "0x6A35660", VA = "0x186A36660")]
	public static float3 GBOPFKIKNPO(this quaternion KHGKPAHCJNA, math.RotationOrder CHLNHGEJFAN = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6A37230", Offset = "0x6A36230", VA = "0x186A37230")]
	public static float OEBDKPKIELF(this quaternion ILBMPADICAD, quaternion BEOPIALHGPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6A365D0", Offset = "0x6A355D0", VA = "0x186A365D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A358C0", Offset = "0x6A348C0", VA = "0x186A358C0", Slot = "4")]
		public int AOODDNLKEHF(int MEMODFNJPKN, int BIPNHKGHNNA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6A358F0", Offset = "0x6A348F0", VA = "0x186A358F0", Slot = "5")]
		public float KPPKENJBIMH(float MEMODFNJPKN, float APEPFLMDDEA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6A35960", Offset = "0x6A34960", VA = "0x186A35960")]
		private double PFOGMJDEEHG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6A359A0", Offset = "0x6A349A0", VA = "0x186A359A0")]
		public JGLBBMMANHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly GLNFCEFKAMA LFBKCILOCBH;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6A340E0", Offset = "0x6A330E0", VA = "0x186A340E0")]
	public static ulong HGDPKBODEPA()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class GAHFHKKHAPL
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2B159D0", Offset = "0x2B149D0", VA = "0x182B159D0")]
	public static bool GMNHNPNPMOE<T>(this IReadOnlyCollection<T> OLDDCPCBGIL, int LLPJHIPCNFD) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class OKHFAEBHDPK
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2CBAAC0", Offset = "0x2CB9AC0", VA = "0x182CBAAC0")]
	public static bool AHJCIFFFBKD<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> OLDDCPCBGIL, IReadOnlyDictionary<TKey, TValue> LJAAPFIIPOF) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class HIKLDKJHCDL
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2B25980", Offset = "0x2B24980", VA = "0x182B25980")]
	public static TValue? DCEDEHACAMP<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> OLDDCPCBGIL, TKey BHEIPBKEDLG) where TValue : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class FMGELHDAJKB
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6A34440", Offset = "0x6A33440", VA = "0x186A34440")]
	public static void NGOOLELHLHP(this IReadOnlyList<Action> OLDDCPCBGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2B0C820", Offset = "0x2B0B820", VA = "0x182B0C820")]
	public static bool MMCLNKMOKEF<T>(this IReadOnlyList<T> OLDDCPCBGIL, int LLPJHIPCNFD, [Out][NotNullWhen(true)][DMMOHDONLFE("This should be `T?` in C# 9.")] T HJBJAPKPPFA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2B0C740", Offset = "0x2B0B740", VA = "0x182B0C740")]
	public static bool HDKMGDGNNGI<T>(this IReadOnlyList<T> OLDDCPCBGIL, int LLPJHIPCNFD, [Out] JJFNMLNAJJG<T> HJBJAPKPPFA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2B0C970", Offset = "0x2B0B970", VA = "0x182B0C970")]
	public static T MMEPJGAJABK<T>(this IReadOnlyList<T> OLDDCPCBGIL, int LLPJHIPCNFD, [In] T CJLCFLFBIJH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2B0C6F0", Offset = "0x2B0B6F0", VA = "0x182B0C6F0")]
	[DMMOHDONLFE("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T GFHFOPHDGKD<T>(this IReadOnlyList<T> OLDDCPCBGIL, int LLPJHIPCNFD) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2B0C630", Offset = "0x2B0B630", VA = "0x182B0C630")]
	public static T? DCEDEHACAMP<T>(this IReadOnlyList<T> OLDDCPCBGIL, int LLPJHIPCNFD) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class GJCEPAIGHPD
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2B1AEB0", Offset = "0x2B19EB0", VA = "0x182B1AEB0")]
	public static int KNGEDAAOIAE<T>([In] this ReadOnlySequence<T> LEJKAHCECBB, [In] T CBAEIEAPLIH) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B1B0", Offset = "0x2B1A1B0", VA = "0x182B1B1B0")]
	public static bool OLFGDECCCDJ<T>([In] this ReadOnlySequence<T> LEJKAHCECBB, [In] ReadOnlySpan<T> LJAAPFIIPOF) where T : IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class KOINNHLBDDM
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6FB0", Offset = "0x2BF5FB0", VA = "0x182BF6FB0")]
	public static string CFFMECMPGKO<T>([In] this ReadOnlySpan<T> OLDDCPCBGIL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2BF7490", Offset = "0x2BF6490", VA = "0x182BF7490")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A34EB0", Offset = "0x6A33EB0", VA = "0x186A34EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6A34F00", Offset = "0x6A33F00", VA = "0x186A34F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A37380", Offset = "0x6A36380", VA = "0x186A37380", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	private MEFAFDIPKBJ(Stopwatch JBABMCMIKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6A373A0", Offset = "0x6A363A0", VA = "0x186A373A0")]
	public static MEFAFDIPKBJ DLEIAOEHCJO(Stopwatch JBABMCMIKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6A37410", Offset = "0x6A36410", VA = "0x186A37410")]
	public static MEFAFDIPKBJ JMJFGFJLHNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class GAOJBKHHPEF
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6A34860", Offset = "0x6A33860", VA = "0x186A34860")]
	public static float3 HOJKBEIHGNJ([In] this RigidTransform OLDDCPCBGIL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6A34730", Offset = "0x6A33730", VA = "0x186A34730")]
	public static float3 FNKHKAPNONC([In] this RigidTransform OLDDCPCBGIL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x9596B0", Offset = "0x9586B0", VA = "0x1809596B0")]
	public static (float3, float3, float3) CKDNKGHKJHE([In] this RigidTransform OLDDCPCBGIL)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6A346D0", Offset = "0x6A336D0", VA = "0x186A346D0")]
	public static RigidTransform BLMBPDALDHN([In] this RigidTransform OLDDCPCBGIL)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class BKFBJBPGJCM
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6A33F30", Offset = "0x6A32F30", VA = "0x186A33F30")]
	public static RigidTransform BDMAPNGKKFD(RigidTransform DJDGCADFEIK, RigidTransform CECMGCJAJGH)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class CMKDNOJNEBP
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6A34070", Offset = "0x6A33070", VA = "0x186A34070")]
	public static float NLENNNMPBKE([In] this (byte Fourth, byte Third, byte Second, byte First) OLDDCPCBGIL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6A33FF0", Offset = "0x6A32FF0", VA = "0x186A33FF0")]
	public static int JKNMMNPFPNK(this float OLDDCPCBGIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6A34000", Offset = "0x6A33000", VA = "0x186A34000")]
	public static (byte, byte, byte, byte) LJAKENKCFIB(this float OLDDCPCBGIL)
	{
		return default((byte, byte, byte, byte));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class CJOHGCGGIDP
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2934A40", Offset = "0x2933A40", VA = "0x182934A40")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DEC5B0", Offset = "0x5DEB5B0", VA = "0x185DEC5B0")]
	public static bool DBFKMHDDMIO(this string? KEHAKFBOBOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6A34A40", Offset = "0x6A33A40", VA = "0x186A34A40")]
	public static string? CNMHLCMHDPC(this string? OLDDCPCBGIL, int EFEECMADLHE, string JFOCDIGNIDE = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6A34990", Offset = "0x6A33990", VA = "0x186A34990")]
	public static string AJEHFMHPLGJ(this string OLDDCPCBGIL, int EFEECMADLHE, string JFOCDIGNIDE = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6A34B20", Offset = "0x6A33B20", VA = "0x186A34B20")]
	public static int DDBACDOPBHH(this string KEHAKFBOBOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6A34B90", Offset = "0x6A33B90", VA = "0x186A34B90")]
	public static string GCIKMMCFGKH(this string KEHAKFBOBOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6A34C50", Offset = "0x6A33C50", VA = "0x186A34C50")]
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
		[Cpp2IlInjected.Address(RVA = "0x46A8470", Offset = "0x46A7470", VA = "0x1846A8470", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x453D4D0", Offset = "0x453C4D0", VA = "0x18453D4D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x57F64B0", Offset = "0x57F54B0", VA = "0x1857F64B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x57F6510", Offset = "0x57F5510", VA = "0x1857F6510")]
	public static OJAIPECBGKH IAFMMLMBDAD()
	{
		return default(OJAIPECBGKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x57F66D0", Offset = "0x57F56D0", VA = "0x1857F66D0")]
	private static void PGBHDGANFHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x57F6430", Offset = "0x57F5430", VA = "0x1857F6430")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A33EC0", Offset = "0x6A32EC0", VA = "0x186A33EC0")]
	public BBMODPPBGLN(FKIPNNNOLMP JBABMCMIKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6A33DA0", Offset = "0x6A32DA0", VA = "0x186A33DA0")]
	public long GFNCJAJFDHD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6A33E30", Offset = "0x6A32E30", VA = "0x186A33E30")]
	public double IELJDLBMOLM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6A33D10", Offset = "0x6A32D10", VA = "0x186A33D10")]
	public double CLCJOKKALOC()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class CPLEGAFMJLE
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6A340B0", Offset = "0x6A330B0", VA = "0x186A340B0")]
	public static bool ACPHBLDFOCD(this Type OLDDCPCBGIL, Type LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2950740", Offset = "0x294F740", VA = "0x182950740")]
	public static bool ACPHBLDFOCD<T>(this Type OLDDCPCBGIL) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class IBBFGAKGMJA
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5A55610", Offset = "0x5A54610", VA = "0x185A55610")]
	public static uint NHEIKNNJAFC(this uint OLDDCPCBGIL, int JPBPNOCHNLG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5B25CA0", Offset = "0x5B24CA0", VA = "0x185B25CA0")]
	public static uint FIBGGIGCMFG(this uint OLDDCPCBGIL, int JPBPNOCHNLG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6A35080", Offset = "0x6A34080", VA = "0x186A35080")]
	public static uint LGFJJBOKLCN(this uint OLDDCPCBGIL, uint JAMIGGIMPIA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x1048700", Offset = "0x1047700", VA = "0x181048700")]
	public static int JKNMMNPFPNK(this uint OLDDCPCBGIL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class LOAMEKACMIH
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2C00B90", Offset = "0x2BFFB90", VA = "0x182C00B90")]
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
