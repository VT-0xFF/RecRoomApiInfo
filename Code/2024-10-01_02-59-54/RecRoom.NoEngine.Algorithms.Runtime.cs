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
		[Cpp2IlInjected.Address(RVA = "0x6EB33E0", Offset = "0x6EB27E0", VA = "0x186EB33E0")]
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
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
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
public static class KBDGBMOBDNE
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string[] OBPHBFOKEHJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0C30", Offset = "0x6EB0030", VA = "0x186EB0C30")]
	public static bool CBGPJIOAFIA(string NFEEOGPLHME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1180", Offset = "0x6EB0580", VA = "0x186EB1180")]
	private static bool JLOEKLOBDNK(string ADPAIBGIHMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1030", Offset = "0x6EB0430", VA = "0x186EB1030")]
	public static bool JLOEKLOBDNK(Exception BIHGENFKIAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0D00", Offset = "0x6EB0100", VA = "0x186EB0D00")]
	public static string COMAEDDNCGD(string PCMCEFKLCKL, string BKLOOOLLNJH = "", bool DNJHEPMOMPI = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GKGPNOAFJNI
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB00C0", Offset = "0x6EAF4C0", VA = "0x186EB00C0")]
	public static string AGLOKPEEDNN(this Guid FDANKBMKMCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0170", Offset = "0x6EAF570", VA = "0x186EB0170")]
	public static string AGLOKPEEDNN(this byte[] HFHEELJJDFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0210", Offset = "0x6EAF610", VA = "0x186EB0210")]
	public static byte[] LMPGNKHOHCL(string KHNECCMBAFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class AHGLCOHDJLC
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int PFMLPFDHOOK<T>([In] T GIDMNJLJNOH, [In] T OONEKAPAHLL);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class NKFIHINHFBL<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct CJNHMNMMIIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly int IHLILPEDKCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public readonly int EKBMPDBILAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public readonly bool OINKBCFFHPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int OHIHAFLDLHL;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5329840", Offset = "0x5328C40", VA = "0x185329840")]
			public CJNHMNMMIIO(int IHLILPEDKCL, int EKBMPDBILAN, bool OINKBCFFHPD)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly T[] LJHJCGOGLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly T[] JDCAPCAGIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly PFMLPFDHOOK<T> PNIBNHIIELJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly int BJHLDCIHHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Func<bool> LKHOBAPBJKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int BCNOHMBLOAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly CJNHMNMMIIO[] FBFGBOHGGGD;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x48C9950", Offset = "0x48C8D50", VA = "0x1848C9950")]
		public NKFIHINHFBL(T[] LJHJCGOGLJC, PFMLPFDHOOK<T> PNIBNHIIELJ, int BJHLDCIHHMM, Func<bool> LKHOBAPBJKA, T[]? BBAGKEDNOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x48C9300", Offset = "0x48C8700", VA = "0x1848C9300")]
		public bool HDKICDHPBBG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate U IOKKKCKLKKJ<T, U>(int LAIMEPMIFJP, int MKBHHPKNNGD, [In] ReadOnlySpan<T> BNMEGPJIDDO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x356DC00", Offset = "0x356D000", VA = "0x18356DC00")]
	public static T[] KBEOBGEGNGC<T>(int MFKKELONDCC, T FMKOKKHLLHI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x356D050", Offset = "0x356C450", VA = "0x18356D050")]
	public static void BGJMMMBFMCP<T>(this T[] HAMOMEJPDMH, T FMKOKKHLLHI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x356DE50", Offset = "0x356D250", VA = "0x18356DE50")]
	public static void KIJOPOLFENL<T>(this T[] AFBDFGIDJPF, int INBIGDGMENB, int IKGCNIFDGGN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x356D840", Offset = "0x356CC40", VA = "0x18356D840")]
	private static void IBNCDCIGNLP<T>(this T[] MBGHIKEGJAA, int EPLFHIEADCC, int HJKOMHDIAMD, T[] OCKBFCIKBEN, int LLBGBKAJCCC, int EEICDKGLNOD, T[] CIFMGKBFCHA, int HDDNMPAPEEG, PFMLPFDHOOK<T> PNIBNHIIELJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x356D370", Offset = "0x356C770", VA = "0x18356D370")]
	public static void EDJJKBKFNMC<T>(this T[] MBGHIKEGJAA, int IHLILPEDKCL, int MGEMHICLKEP, PFMLPFDHOOK<T> PNIBNHIIELJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x356D780", Offset = "0x356CB80", VA = "0x18356D780")]
	public static NKFIHINHFBL<T> FKDLDDFMBAI<T>(this T[] MBGHIKEGJAA, PFMLPFDHOOK<T> PNIBNHIIELJ, int BJHLDCIHHMM, Func<bool> LKHOBAPBJKA, [Optional] T[]? BBAGKEDNOMA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x356DF80", Offset = "0x356D380", VA = "0x18356DF80")]
	public static T[] ONDFPBDCNDC<T>(this T[] AFBDFGIDJPF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x356D220", Offset = "0x356C620", VA = "0x18356D220")]
	public static T[] DINNENGCBEJ<T>(this T[] DAINNBHPEJJ, T APIPHGADEHF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x356DFD0", Offset = "0x356D3D0", VA = "0x18356DFD0")]
	public static T[] PAJKEIOPCIM<T>(this T[] DAINNBHPEJJ, int AEAHMAMPNLO, T APIPHGADEHF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x356DED0", Offset = "0x356D2D0", VA = "0x18356DED0")]
	public static T[] LHCNOPFCHNH<T>(this T[] DAINNBHPEJJ, int AEAHMAMPNLO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x356EEA0", Offset = "0x356E2A0", VA = "0x18356EEA0")]
	public static T[] PFNBPOFKLDP<T>(this T[] DAINNBHPEJJ, int AEAHMAMPNLO, T APIPHGADEHF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x356E8A0", Offset = "0x356DCA0", VA = "0x18356E8A0")]
	public static U[] PAMPOJNMMFK<U, T>(this T[] AAKOLIDMFPJ, int INJIBBLOMKF, IOKKKCKLKKJ<T, U> BICIBIPKLLF) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE930", Offset = "0x6EADD30", VA = "0x186EAE930")]
	public static byte[] PINDJDAIKEC(this byte[] MBGHIKEGJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE6B0", Offset = "0x6EADAB0", VA = "0x186EAE6B0")]
	public static byte[] CKPIEKJBMJA(this byte[] MBGHIKEGJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MDGIEGLAOKC
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6EB02E0", Offset = "0x6EAF6E0", VA = "0x186EB02E0")]
	public static byte JEPOOPCCHMK(this bool MBGHIKEGJAA)
	{
		return default(byte);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GPNEGOJKHPK
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6EB02E0", Offset = "0x6EAF6E0", VA = "0x186EB02E0")]
	public static bool HGGGDCCCOAE(this byte MBGHIKEGJAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MOMJCDPENKE
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2F637F0", Offset = "0x2F62BF0", VA = "0x182F637F0")]
	public static void PHFMBFLAOAE<T>(this ICollection<T> MBGHIKEGJAA, IEnumerable<T> JBJDGFHGGAA) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BHCPEKPDGNL
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2BE8300", Offset = "0x2BE7700", VA = "0x182BE8300")]
	public static V ODLBBOPBGMD<V, K>(this IDictionary<K, V> MBGHIKEGJAA, [In] K GMJINMLEEAC, [In] V LIHHDPOHLDK, Func<V, V, V> NFGPGFPPGIO) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5CF0", Offset = "0x2BE50F0", VA = "0x182BE5CF0")]
	public static void EIJECLCLANA<K, V>(this IDictionary<K, List<V>> MBGHIKEGJAA, [In] K GMJINMLEEAC, [In] V LIHHDPOHLDK) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6710", Offset = "0x2BE5B10", VA = "0x182BE6710")]
	public static TVal JIPJNCDLAMO<TVal, TKey>(this IDictionary<TKey, TVal> KFEJHMHFKIB, [In] TKey GMJINMLEEAC, [Optional][JIOMAKBLFNI("`default!` shouldn't be necessary in C# 9")] TVal JGBDACMOCCC) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6550", Offset = "0x2BE5950", VA = "0x182BE6550")]
	public static TVal JIPJNCDLAMO<TVal, TKey>(this IDictionary<TKey, TVal> KFEJHMHFKIB, [In] TKey GMJINMLEEAC, Func<TVal> KEEMANHNPHI) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2BE78B0", Offset = "0x2BE6CB0", VA = "0x182BE78B0")]
	public static TValue LNFGKOIKOPI<TValue, TKey>(this IDictionary<TKey, TValue> KFEJHMHFKIB, [In] TKey GMJINMLEEAC, [Optional][In][JIOMAKBLFNI("`default!` and null-oblivious region shouldn't be necessary in C# 9")] TValue JGBDACMOCCC)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7310", Offset = "0x2BE6710", VA = "0x182BE7310")]
	public static V JOPPLEGFNOM<V, K>(this IDictionary<K, V> MBGHIKEGJAA, [In] K GMJINMLEEAC) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2BE77F0", Offset = "0x2BE6BF0", VA = "0x182BE77F0")]
	public static T2[] KDAGEAEPDAP<T2, T1>(this Dictionary<T1, T2>.ValueCollection HEGAIELBLCD) where T2 : notnull where T1 : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ACNGNBBHPHO
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate bool ICJIOMDLCHI<TArgs, T>([In] TArgs HJEECPNIDIG, T BNDEDHKBDGD);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate U JMJJPALPKNN<TArg, U>([In] TArg MGBFBAKCCAP);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate U LJGKIFNAPAE<TArg, T, U>([In] TArg MGBFBAKCCAP, T OLFOKAIDJJB);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate U CDMFBCIOOII<TArg, T, U>([In] TArg MGBFBAKCCAP, IEnumerable<T> CLFAAKBCKGB);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate U DFIAOMPMILN<TArg, T, U>([In] TArg MGBFBAKCCAP, T OLFOKAIDJJB);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct ACBKPNGNMEA<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3F86D70", Offset = "0x3F86170", VA = "0x183F86D70")]
		[JIOMAKBLFNI("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) LHMKCCJBBIP(T APHLNMBFBLO)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x3F86D10", Offset = "0x3F86110", VA = "0x183F86D10")]
		[JIOMAKBLFNI("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) COGHOBOMKKG(IEnumerable<T> HILONFBCGBA)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class ALNEMEAOBFF<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9EDBA0", Offset = "0x9ECFA0", VA = "0x1809EDBA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x402EF00", Offset = "0x402E300", VA = "0x18402EF00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xD77C80", Offset = "0xD77080", VA = "0x180D77C80")]
		[DebuggerHidden]
		public ALNEMEAOBFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD6E0", Offset = "0x3DBCAE0", VA = "0x183DBD6E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x402E800", Offset = "0x402DC00", VA = "0x18402E800", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x402EBC0", Offset = "0x402DFC0", VA = "0x18402EBC0")]
		private void PKLCPOPHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x402EEB0", Offset = "0x402E2B0", VA = "0x18402EEB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x402EC60", Offset = "0x402E060", VA = "0x18402EC60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x402EE20", Offset = "0x402E220", VA = "0x18402EE20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class GCBJNLCCPDM<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA24590", Offset = "0xA23990", VA = "0x180A24590")]
		[DebuggerHidden]
		public GCBJNLCCPDM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3FD5080", Offset = "0x3FD4480", VA = "0x183FD5080", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3FD4130", Offset = "0x3FD3530", VA = "0x183FD4130", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3FD4CE0", Offset = "0x3FD40E0", VA = "0x183FD4CE0")]
		private void PKLCPOPHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3FD4090", Offset = "0x3FD3490", VA = "0x183FD4090")]
		private void EMBCDMFMIHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3FD5030", Offset = "0x3FD4430", VA = "0x183FD5030", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3FD4EA0", Offset = "0x3FD42A0", VA = "0x183FD4EA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3B41BB0", Offset = "0x3B40FB0", VA = "0x183B41BB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class BMICOOBKKED<T> : IEnumerable<(T, JEJCONLJHLG<T>)>, IEnumerable, IEnumerator<(T, JEJCONLJHLG<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private (T Current, JEJCONLJHLG<T> Next) <>2__current;

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
		private (T, JEJCONLJHLG<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x3BCDDB0", Offset = "0x3BCD1B0", VA = "0x183BCDDB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, JEJCONLJHLG<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x527E230", Offset = "0x527D630", VA = "0x18527E230", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2103D80", Offset = "0x2103180", VA = "0x182103D80")]
		[DebuggerHidden]
		public BMICOOBKKED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3EC0", Offset = "0x3DC32C0", VA = "0x183DC3EC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x527C800", Offset = "0x527BC00", VA = "0x18527C800", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x527DD20", Offset = "0x527D120", VA = "0x18527DD20")]
		private void PKLCPOPHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x527E190", Offset = "0x527D590", VA = "0x18527E190", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x527DF30", Offset = "0x527D330", VA = "0x18527DF30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, JEJCONLJHLG<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3B41BB0", Offset = "0x3B40FB0", VA = "0x183B41BB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class LFGKFNJHLPH<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
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
		private Func<ACBKPNGNMEA<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Func<ACBKPNGNMEA<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IEnumerator<T> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private IEnumerator<U> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		U IEnumerator<UnityEngine.SpookyHash.U>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (U)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA24590", Offset = "0xA23990", VA = "0x180A24590")]
		[DebuggerHidden]
		public LFGKFNJHLPH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x45D70B0", Offset = "0x45D64B0", VA = "0x1845D70B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x45D6B80", Offset = "0x45D5F80", VA = "0x1845D6B80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x45D7010", Offset = "0x45D6410", VA = "0x1845D7010")]
		private void PKLCPOPHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x45D6B30", Offset = "0x45D5F30", VA = "0x1845D6B30")]
		private void EMBCDMFMIHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x45D7060", Offset = "0x45D6460", VA = "0x1845D7060", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3F72610", Offset = "0x3F71A10", VA = "0x183F72610", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3EF3D50", Offset = "0x3EF3150", VA = "0x183EF3D50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GGMPOHBIPPK<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public GGMPOHBIPPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3FEB520", Offset = "0x3FEA920", VA = "0x183FEB520")]
		internal bool IPDNNMLOCIC(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3FEB580", Offset = "0x3FEA980", VA = "0x183FEB580")]
		internal bool PLIDBLAKEGC(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class HENOILLGHOC<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private (T Lhs, U Rhs) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private IEnumerable<T> lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public IEnumerable<T> <>3__lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerable<U> rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IEnumerable<U> <>3__rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private IEnumerator<T> <lhsIt>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IEnumerator<U> <rhsIt>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private (T, U) System.Collections.Generic.IEnumerator<(TLhs,URhs)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x95E950", Offset = "0x95DD50", VA = "0x18095E950", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, U));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x3F6D5C0", Offset = "0x3F6C9C0", VA = "0x183F6D5C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x2103D80", Offset = "0x2103180", VA = "0x182103D80")]
		[DebuggerHidden]
		public HENOILLGHOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4085CB0", Offset = "0x40850B0", VA = "0x184085CB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4085FC0", Offset = "0x40853C0", VA = "0x184085FC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4085EE0", Offset = "0x40852E0", VA = "0x184085EE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3B41BB0", Offset = "0x3B40FB0", VA = "0x183B41BB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3566E60", Offset = "0x3566260", VA = "0x183566E60")]
	public static bool CHCGDPCDIDB<T, TArgs>(this IEnumerable<T> MBGHIKEGJAA, [In] TArgs HJEECPNIDIG, ICJIOMDLCHI<TArgs, T> POHDLGLNJEJ) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE5A0", Offset = "0x6EAD9A0", VA = "0x186EAE5A0")]
	public static bool CHCGDPCDIDB(this IEnumerable<bool> MBGHIKEGJAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x356AB20", Offset = "0x3569F20", VA = "0x18356AB20")]
	public static U LMDGMJFNLIA<U, T>(this IEnumerable<T> MBGHIKEGJAA, Func<U> ODFKHOGBNGD, Func<T, U> APHLNMBFBLO, Func<IEnumerable<T>, U> HILONFBCGBA) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3564D90", Offset = "0x3564190", VA = "0x183564D90")]
	public static bool AIBBNBFFJGJ<T, TArgs>(this IEnumerable<T> MBGHIKEGJAA, [In] TArgs HJEECPNIDIG, ICJIOMDLCHI<TArgs, T> POHDLGLNJEJ) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x35659B0", Offset = "0x3564DB0", VA = "0x1835659B0")]
	public static U CAEPOFAHOCN<U, T, TArg>(this IEnumerable<T> MBGHIKEGJAA, [In] TArg MGBFBAKCCAP, JMJJPALPKNN<TArg, U> ODFKHOGBNGD, LJGKIFNAPAE<TArg, T, U> APHLNMBFBLO, CDMFBCIOOII<TArg, T, U> HILONFBCGBA) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3568800", Offset = "0x3567C00", VA = "0x183568800")]
	public static IEnumerable<U> FBIABHIKPBG<U, T, TArg>(this IEnumerable<T> MBGHIKEGJAA, [In] TArg MGBFBAKCCAP, DFIAOMPMILN<TArg, T, U> EKGIAHLBMMI) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2BF0860", Offset = "0x2BEFC60", VA = "0x182BF0860")]
	public static IEnumerable<T> CDCDLBABMPN<T>(params IEnumerable<T>[] LNMHPJJOEML) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3566730", Offset = "0x3565B30", VA = "0x183566730")]
	public static bool CCFIACHOKJF<T>(this IEnumerable<T> PPIMIKDHEBO, IEnumerable<T> OCKBFCIKBEN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2BF0860", Offset = "0x2BEFC60", VA = "0x182BF0860")]
	public static IEnumerable<(TKey?, TValue?)>? FADPNPMCJJM<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> MBGHIKEGJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3568D40", Offset = "0x3568140", VA = "0x183568D40")]
	public static IEnumerable<T> FDHIOCFLDDG<T, TKey>(this IEnumerable<T> HGFDBGLHPDA, Func<T, TKey> NJEMPGNDNLP) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2D80140", Offset = "0x2D7F540", VA = "0x182D80140")]
	[IteratorStateMachine(typeof(ALNEMEAOBFF<>))]
	public static IEnumerable<T> LKFMBBMEKBB<T>(this IEnumerable<T> PPIMIKDHEBO, ISet<T> GMDIGBDGECA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2DDA1C0", Offset = "0x2DD95C0", VA = "0x182DDA1C0")]
	[IteratorStateMachine(typeof(GCBJNLCCPDM<, >))]
	public static IEnumerable<T> FEPECANEBGC<T, U>(this IEnumerable<T> MBGHIKEGJAA, IEnumerable<U> OCKBFCIKBEN, [Optional][JIOMAKBLFNI("`default!` shouldn't be necessary in C# 9")] T FMKOKKHLLHI) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2B2CC00", Offset = "0x2B2C000", VA = "0x182B2CC00")]
	public static T PJJFDMHNOKK<T>(this IEnumerable<T> PPIMIKDHEBO, T JGBDACMOCCC) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x356B7B0", Offset = "0x356ABB0", VA = "0x18356B7B0")]
	public static T PJJFDMHNOKK<T>(this IEnumerable<T> PPIMIKDHEBO, T JGBDACMOCCC, Func<T, bool> POHDLGLNJEJ) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3565EB0", Offset = "0x35652B0", VA = "0x183565EB0")]
	public static T? CBIAMJCGNLA<T>(this IEnumerable<T> MBGHIKEGJAA, Func<T, bool> POHDLGLNJEJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x35676D0", Offset = "0x3566AD0", VA = "0x1835676D0")]
	public static void CICDFOHOIOG<T>(this IEnumerable<T> MBGHIKEGJAA, Action<T> KGBHBFABAOH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2D4BA20", Offset = "0x2D4AE20", VA = "0x182D4BA20")]
	[IteratorStateMachine(typeof(BMICOOBKKED<>))]
	public static IEnumerable<(T, JEJCONLJHLG<T>)> MJJGBHPBMKE<T>(this IEnumerable<T> MBGHIKEGJAA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x356A110", Offset = "0x3569510", VA = "0x18356A110")]
	public static bool IDKAFJCEFIE<T>(this IEnumerable<T> MBGHIKEGJAA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2BF0860", Offset = "0x2BEFC60", VA = "0x182BF0860")]
	public static IEnumerable<CLCOJBEHIHA<T>> LGPOLAJNCMC<T>(this IEnumerable<T> MBGHIKEGJAA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x356A7F0", Offset = "0x3569BF0", VA = "0x18356A7F0")]
	public static bool KGFOOIOHGJD<T>(this IEnumerable<T> MBGHIKEGJAA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x356A7B0", Offset = "0x3569BB0", VA = "0x18356A7B0")]
	public static IEnumerable<T> KBJONOFNBIA<T>(this IEnumerable<T>? MBGHIKEGJAA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2D4B6B0", Offset = "0x2D4AAB0", VA = "0x182D4B6B0")]
	[IteratorStateMachine(typeof(LFGKFNJHLPH<, >))]
	public static IEnumerable<U> GGGHJCFNHLO<U, T>(this IEnumerable<T> MBGHIKEGJAA, Func<ACBKPNGNMEA<U>, T, (bool Zero, U One, IEnumerable<U> Many)> DPOFNEOKMAL) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2BF0860", Offset = "0x2BEFC60", VA = "0x182BF0860")]
	public static IEnumerable<T> GCEEEENBJLM<T>(this IEnumerable<IEnumerable<T>> MBGHIKEGJAA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3569CC0", Offset = "0x35690C0", VA = "0x183569CC0")]
	public static int HCBBGALOGAH<T>(this IEnumerable<T> MBGHIKEGJAA, int GFMMPIHKMEI = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x356A8B0", Offset = "0x3569CB0", VA = "0x18356A8B0")]
	public static bool LDDJCNMKPGH<T>(this IEnumerable<T> MBGHIKEGJAA, IEnumerable<T> OCKBFCIKBEN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x356A830", Offset = "0x3569C30", VA = "0x18356A830")]
	public static IEnumerable<T> KLJPBEGMLNP<T>(this IEnumerable<T> MBGHIKEGJAA, int LEOEGFBKJJC, int DAAGFHHGAPI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x35652D0", Offset = "0x35646D0", VA = "0x1835652D0")]
	public static (IEnumerable<T>, IEnumerable<T>) AMOPECCJIJI<T>(this IEnumerable<T> MBGHIKEGJAA, Func<T, bool> KIJBDFPFPEH) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3569140", Offset = "0x3568540", VA = "0x183569140")]
	public static string FEKKLLKDDDG<T>(this IEnumerable<T> MBGHIKEGJAA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3565600", Offset = "0x3564A00", VA = "0x183565600")]
	public static Dictionary<TKey?, TValue?>? BLLBGCCGHIK<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> PPIMIKDHEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3565600", Offset = "0x3564A00", VA = "0x183565600")]
	public static Dictionary<TKey?, TValue?>? BLLBGCCGHIK<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> PPIMIKDHEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x35658F0", Offset = "0x3564CF0", VA = "0x1835658F0")]
	public static List<T> BLLIMHHOKNF<T>(this IEnumerable<T> MBGHIKEGJAA, int MLLKNBDHHFM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3159330", Offset = "0x3158730", VA = "0x183159330")]
	public static string DICNLNGIIDK<T>(this IEnumerable<T> MBGHIKEGJAA, string MGABCAGBJJE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x356AED0", Offset = "0x356A2D0", VA = "0x18356AED0")]
	public static (IReadOnlyList<T?>?, IReadOnlyList<U?>?) NHHDHKOLHDL<T, U>(this IEnumerable<(T Lhs, U Rhs)> MBGHIKEGJAA)
	{
		return default((IReadOnlyList<T>, IReadOnlyList<U>));
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2D792B0", Offset = "0x2D786B0", VA = "0x182D792B0")]
	[IteratorStateMachine(typeof(HENOILLGHOC<, >))]
	public static IEnumerable<(T, U)> DMKDLAGDCFO<T, U>(this IEnumerable<T> GIDMNJLJNOH, IEnumerable<U> OONEKAPAHLL) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x356A510", Offset = "0x3569910", VA = "0x18356A510")]
	public static IEnumerable<V> IEABDIKAHAP<V, T, U>(this IEnumerable<T> MBGHIKEGJAA, IEnumerable<U> OCKBFCIKBEN, Func<T, U, V> LGHMCEBNFJB, [Optional][JIOMAKBLFNI("`default!` shouldn't be necessary in C# 9")] T BELEGKKNGLM, [Optional][JIOMAKBLFNI("`default!` shouldn't be necessary in C# 9")] U AEFLFKAPBEE) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x356A5E0", Offset = "0x35699E0", VA = "0x18356A5E0")]
	public static IEnumerable<(T, U)> IEABDIKAHAP<T, U>(this IEnumerable<T> MBGHIKEGJAA, IEnumerable<U> OCKBFCIKBEN, [Optional][JIOMAKBLFNI("`default!` shouldn't be necessary in C# 9")] T BELEGKKNGLM, [Optional][JIOMAKBLFNI("`default!` shouldn't be necessary in C# 9")] U AEFLFKAPBEE) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3569780", Offset = "0x3568B80", VA = "0x183569780")]
	public static TOut[] FHICLMMFMPM<TOut, TIn>(this IEnumerable<TIn> HGFDBGLHPDA, Func<TIn, TOut> PEFIIKDENLG) where TOut : notnull where TIn : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3568120", Offset = "0x3567520", VA = "0x183568120")]
	public static JEJCONLJHLG<U> DGPFLDMJPBF<U, T>(this IEnumerable<T> JHCGPAODEGN, Func<T, U> NENBBFGKNMM) where U : notnull where T : notnull
	{
		return default(JEJCONLJHLG<U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class AJIGHOLDCMK
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3571550", Offset = "0x3570950", VA = "0x183571550")]
	public static bool HNABOFGJMKP<T, U>(this T MBGHIKEGJAA, [In] U PBAACPJGKNP) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3571770", Offset = "0x3570B70", VA = "0x183571770")]
	public static bool PGEAKODMHNH<T>(T MBGHIKEGJAA, T OCKBFCIKBEN) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class ICEJLFJOFNP
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xF6F8F0", Offset = "0xF6ECF0", VA = "0x180F6F8F0")]
	public static bool KDNDLMICODK([In] this float3 NOPDIJFELMF, float3 PMGMHFIMGOD, float DOJKLPDODLH = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class DOHMEKBBFLC
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class ODHOKKDINCP<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private T self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public T <>3__self;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x95E950", Offset = "0x95DD50", VA = "0x18095E950", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x3F078D0", Offset = "0x3F06CD0", VA = "0x183F078D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2103D80", Offset = "0x2103180", VA = "0x182103D80")]
		[DebuggerHidden]
		public ODHOKKDINCP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4A5ACE0", Offset = "0x4A5A0E0", VA = "0x184A5ACE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4A5B100", Offset = "0x4A5A500", VA = "0x184A5B100", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4A5B030", Offset = "0x4A5A430", VA = "0x184A5B030", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3C29350", Offset = "0x3C28750", VA = "0x183C29350", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F300", Offset = "0x2C8E700", VA = "0x182C8F300")]
	public static void NCHAPFBFHKJ<T>(this T HIKBGGAGLAA, Action<T> EALNONEKJKL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F220", Offset = "0x2C8E620", VA = "0x182C8F220")]
	public static V LPJLBGBFKBH<V, T>(this T HIKBGGAGLAA, Func<T, V> EALNONEKJKL, [Optional][JIOMAKBLFNI("`default!` shouldn't be necessary in C# 9")] V JGBDACMOCCC) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F110", Offset = "0x2C8E510", VA = "0x182C8F110")]
	public static T? KPHMGFEKKEN<T>(this T MBGHIKEGJAA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2C8ED90", Offset = "0x2C8E190", VA = "0x182C8ED90")]
	[IteratorStateMachine(typeof(ODHOKKDINCP<>))]
	public static IEnumerable<T> DHEKCMNCAJB<T>(this T MBGHIKEGJAA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2C8EFF0", Offset = "0x2C8E3F0", VA = "0x182C8EFF0")]
	public static T[] HBLGJFNNKJC<T>(this T MBGHIKEGJAA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FAPMMOMDADH
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFFF0", Offset = "0x6EAF3F0", VA = "0x186EAFFF0")]
	private static byte[] MLEALFLCKEK(int GEAPENHKIKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF880", Offset = "0x6EAEC80", VA = "0x186EAF880")]
	private static byte[] JHNCCCLJLEE(long BPGPJEKNOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF800", Offset = "0x6EAEC00", VA = "0x186EAF800")]
	private static byte[] JDGBHMOBLPF(ulong BPGPJEKNOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF690", Offset = "0x6EAEA90", VA = "0x186EAF690")]
	public static Guid JDAEHEKNIFN(params Guid[] LEKEHCGFNKO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFD10", Offset = "0x6EAF110", VA = "0x186EAFD10")]
	public static Guid LIDOGEGODKP([In] Guid ABPHKADHIAK, int AEAHMAMPNLO, int DMDALLEEEHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFEB0", Offset = "0x6EAF2B0", VA = "0x186EAFEB0")]
	public static Guid LIDOGEGODKP([In] Guid ABPHKADHIAK, long AEAHMAMPNLO, int DMDALLEEEHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFDE0", Offset = "0x6EAF1E0", VA = "0x186EAFDE0")]
	public static Guid LIDOGEGODKP([In] Guid ABPHKADHIAK, ulong AEAHMAMPNLO, int DMDALLEEEHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFF80", Offset = "0x6EAF380", VA = "0x186EAFF80")]
	public static Guid LIDOGEGODKP([In] Guid ABPHKADHIAK, [In] Guid KLMNIOJIHBI, int DMDALLEEEHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF900", Offset = "0x6EAED00", VA = "0x186EAF900")]
	private static Guid LIDOGEGODKP([In] Guid ABPHKADHIAK, byte[] PEGLMHKBEDL, int DMDALLEEEHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF600", Offset = "0x6EAEA00", VA = "0x186EAF600")]
	private static void APDPIJONIAE(byte[] FDANKBMKMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0070", Offset = "0x6EAF470", VA = "0x186EB0070")]
	private static void NLJBPPKKFEP(byte[] FDANKBMKMCE, int EHOEECMJEAD, int CPKKNGGFDGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class MAOLLABHKKI
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2EF0", Offset = "0x6EB22F0", VA = "0x186EB2EF0")]
	public static int EINOBGJJIKI(this int MBGHIKEGJAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2F60", Offset = "0x6EB2360", VA = "0x186EB2F60")]
	public static int GGCHBAPFPAI(this int MBGHIKEGJAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6EB3060", Offset = "0x6EB2460", VA = "0x186EB3060")]
	public static int OAHCANINALD(this int MBGHIKEGJAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2FC0", Offset = "0x6EB23C0", VA = "0x186EB2FC0")]
	public static int INHHGEIHJBL(this int MBGHIKEGJAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A280", Offset = "0x5E99680", VA = "0x185E9A280")]
	public static int IJDDKAMGKKN(this int MBGHIKEGJAA, int MGEMHICLKEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A4D0", Offset = "0x5F698D0", VA = "0x185F6A4D0")]
	public static int KPBGJGDGGJC(this int MBGHIKEGJAA, int MGEMHICLKEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2FD0", Offset = "0x6EB23D0", VA = "0x186EB2FD0")]
	public static float JKJJOMLLPNB(this int MBGHIKEGJAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2FF0", Offset = "0x6EB23F0", VA = "0x186EB2FF0")]
	public static (byte, byte, byte, byte) KAKLIEPNHLM(this int MBGHIKEGJAA)
	{
		return default((byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2FA0", Offset = "0x6EB23A0", VA = "0x186EB2FA0")]
	public static int HBAGGKNMLDP([In] this (byte Fourth, byte Third, byte Second, byte First) MBGHIKEGJAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2ED0", Offset = "0x6EB22D0", VA = "0x186EB2ED0")]
	public static int AIEOPAONKOA(this int MBGHIKEGJAA, int IAPIMDLNNBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2EE0", Offset = "0x6EB22E0", VA = "0x186EB2EE0")]
	public static int CEEMBGDHPDP(this int MBGHIKEGJAA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class MIMBIILKDPA
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6EB3100", Offset = "0x6EB2500", VA = "0x186EB3100")]
	public static (byte, byte, byte, byte, byte, byte, byte, byte) KAKLIEPNHLM(this long MBGHIKEGJAA)
	{
		return default((byte, byte, byte, byte, byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6EB30B0", Offset = "0x6EB24B0", VA = "0x186EB30B0")]
	public static long CKHFOEGIENM([In] this (byte Eighth, byte Seventh, byte Sixth, byte Fifth, byte Fourth, byte Third, byte Second, byte First) MBGHIKEGJAA)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface ICNNFPBEKOO
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HFOIJEAEKAE(int DKEJJDDCLIM, int MGNJDKFKCCA);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float GPPGAILGBCI(float IPEIFPDPGGH, float KIPDNFGNOEJ);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface DFLNBDCBGOC
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	long IEANFLAEJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class KIJPBJLINOF
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2EFDC50", Offset = "0x2EFD050", VA = "0x182EFDC50")]
	public static (TKey?, TValue?) DCKFKAKDKND<TKey, TValue>([In] this KeyValuePair<TKey, TValue> MBGHIKEGJAA)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2EFDDB0", Offset = "0x2EFD1B0", VA = "0x182EFDDB0")]
	public static KeyValuePair<TKey?, UValue?> LKKMFCONEKP<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> MBGHIKEGJAA, UValue LIHHDPOHLDK)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class MEHLLDOMKGD
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class CNLDGELDFOH<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public CNLDGELDFOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5332D50", Offset = "0x5332150", VA = "0x185332D50")]
		internal TElement BKNHFAFGLFB(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2F552B0", Offset = "0x2F546B0", VA = "0x182F552B0")]
	public static int GFMHPBIMAGP<T>(this IReadOnlyList<T> AFBDFGIDJPF, T LIHHDPOHLDK) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2F54460", Offset = "0x2F53860", VA = "0x182F54460")]
	public static int EJMAOMDNBKA<T>(this IReadOnlyList<T> AFBDFGIDJPF, T LIHHDPOHLDK) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2F5A750", Offset = "0x2F59B50", VA = "0x182F5A750")]
	public static void PHFMBFLAOAE<T>(this HashSet<T> ICCMKHGHGBH, IEnumerable<T> JBJDGFHGGAA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2F53CC0", Offset = "0x2F530C0", VA = "0x182F53CC0")]
	public static void BFMJDKEGNPO<T>(this IList<T> HGMKHDHJCFJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2F53980", Offset = "0x2F52D80", VA = "0x182F53980")]
	public static void BFMJDKEGNPO<T>(this IList<T> HGMKHDHJCFJ, int MNEEECCEEBD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2F561D0", Offset = "0x2F555D0", VA = "0x182F561D0")]
	public static void KEKJJDNJCNP<T>(this List<T> HGMKHDHJCFJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2F5B480", Offset = "0x2F5A880", VA = "0x182F5B480")]
	public static List<T> PPDGLMGALFI<T>(this List<T> OPELMMBFLGD, Predicate<T> OLPGOGICJHE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2F55A70", Offset = "0x2F54E70", VA = "0x182F55A70")]
	public static int GFMHPBIMAGP<T>(this IReadOnlyList<T> HGMKHDHJCFJ, Predicate<T> POHDLGLNJEJ) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2F52FB0", Offset = "0x2F523B0", VA = "0x182F52FB0")]
	public static bool AICELHAMKJF<T>(this IReadOnlyList<T> HGMKHDHJCFJ, Predicate<T> POHDLGLNJEJ, [Out][NotNullWhen(true)] List<int>? FPDKGNJGAIL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2F550D0", Offset = "0x2F544D0", VA = "0x182F550D0")]
	public static bool FCCKHINNPHJ<T>(this IReadOnlyList<T> HGMKHDHJCFJ, T BNDEDHKBDGD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2F55150", Offset = "0x2F54550", VA = "0x182F55150")]
	public static bool FCCKHINNPHJ<T>(this IReadOnlyList<T> HGMKHDHJCFJ, T BNDEDHKBDGD, EqualityComparer<T> BEBALKAAJIF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2F577A0", Offset = "0x2F56BA0", VA = "0x182F577A0")]
	public static int MEGDHAGGLKC<TElement, TKey>(this IList<TElement> GOMKHJHJJOM, TKey CLAHOHBMOGP, Func<TElement, TKey> CHKEGPKAIBD, [Optional] Func<TKey, TKey, int>? PNIBNHIIELJ, int AEAHMAMPNLO = 0, [Optional] int? MGEMHICLKEP) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2F57060", Offset = "0x2F56460", VA = "0x182F57060")]
	public static int MEGDHAGGLKC<TElement, TKey>(Func<int, TElement> FCFGJCBCGII, int EHEBJEMDKKE, TKey CLAHOHBMOGP, Func<TElement, TKey> CHKEGPKAIBD, [Optional] Func<TKey, TKey, int>? PNIBNHIIELJ, int AEAHMAMPNLO = 0, [Optional] int? MGEMHICLKEP) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2F54700", Offset = "0x2F53B00", VA = "0x182F54700")]
	public static bool FBPFBAJJNDG<T>(this List<T> HGMKHDHJCFJ, T BNDEDHKBDGD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2F53450", Offset = "0x2F52850", VA = "0x182F53450")]
	public static void AMFMCAEFBFI<T>(this List<T> HGMKHDHJCFJ, IEnumerable<T> OPELMMBFLGD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2F56830", Offset = "0x2F55C30", VA = "0x182F56830")]
	public static void MAHJHHAHNPL<T>(this List<T> HGMKHDHJCFJ, IEnumerable<T> OPELMMBFLGD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2F543D0", Offset = "0x2F537D0", VA = "0x182F543D0")]
	public static T CMMNJAKABCP<T>(this List<T> OPELMMBFLGD, Predicate<T> OLPGOGICJHE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2F58390", Offset = "0x2F57790", VA = "0x182F58390")]
	public static T OHLLCLBKPNM<T>(this List<T> OPELMMBFLGD, int AEAHMAMPNLO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2F54120", Offset = "0x2F53520", VA = "0x182F54120")]
	public static void CAKFPLKKIFP<T>(this List<T> HGMKHDHJCFJ, int AEAHMAMPNLO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2F542E0", Offset = "0x2F536E0", VA = "0x182F542E0")]
	public static bool CGNGPDMIOFK<T>(this List<T> PJMAHBLGCBD, List<T> FAEMFIGHEEM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2F582F0", Offset = "0x2F576F0", VA = "0x182F582F0")]
	public static T OBPNOIKCJOI<T>(this IList<T> HGMKHDHJCFJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2F56020", Offset = "0x2F55420", VA = "0x182F56020")]
	public static bool HHHLEECBGIB<T>(IReadOnlyList<T>? HGMKHDHJCFJ, int AEAHMAMPNLO, [Out][JIOMAKBLFNI("This should be `T?` in C# 9.")][MaybeNullWhen(false)] T CIFMGKBFCHA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2F59720", Offset = "0x2F58B20", VA = "0x182F59720")]
	public static bool OOGOOHCDKEM<T>(IReadOnlyList<T> HGMKHDHJCFJ, ICollection OPELMMBFLGD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2F56EB0", Offset = "0x2F562B0", VA = "0x182F56EB0")]
	public static void MDKKAFJJKHL<T>(IReadOnlyList<T> HGMKHDHJCFJ, ICollection OPELMMBFLGD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F8E0", Offset = "0x2C6ECE0", VA = "0x182C6F8E0")]
	public static bool OGNMDNNBPFH<T>(this IReadOnlyList<T> HGMKHDHJCFJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2F56670", Offset = "0x2F55A70", VA = "0x182F56670")]
	public static string MAFFMDAJDGN<T>(this IEnumerable<T> HGMKHDHJCFJ, string PJBAHPLDNPP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2F538D0", Offset = "0x2F52CD0", VA = "0x182F538D0")]
	public static T BELFBDCDOHG<T>(this IList<T> MBGHIKEGJAA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2F57F30", Offset = "0x2F57330", VA = "0x182F57F30")]
	public static T NLCHKKJPMLA<T>(this IList<T> MBGHIKEGJAA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2F54250", Offset = "0x2F53650", VA = "0x182F54250")]
	public static void CBODFBCFNIK<T>(this IList<T> MBGHIKEGJAA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2F58150", Offset = "0x2F57550", VA = "0x182F58150")]
	public static void NLFAPIAIKNI<T>(this IList<T> MBGHIKEGJAA, [In] T LIHHDPOHLDK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2F560D0", Offset = "0x2F554D0", VA = "0x182F560D0")]
	public static T IMKLKLPKPCN<T>(this IList<T> MBGHIKEGJAA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2F56C30", Offset = "0x2F56030", VA = "0x182F56C30")]
	public static void MCNCNPIPGDA<T>(this List<T> MBGHIKEGJAA) where T : struct, IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class JJFBNGKBGNF
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static float GBBFEJNDCHC;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static float DMHMPIMOLJG;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static bool AOGEDOBCEOE;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly float BOMPPDCKFEO;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0780", Offset = "0x6EAFB80", VA = "0x186EB0780")]
	public static bool KOJDJLICKHI(float NOPDIJFELMF, float PMGMHFIMGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0620", Offset = "0x6EAFA20", VA = "0x186EB0620")]
	public static float DEDNDLHOEIF(float LIHHDPOHLDK, float GOCGGGCOOLH, float GGBNJANNJDO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0640", Offset = "0x6EAFA40", VA = "0x186EB0640")]
	public static int DEDNDLHOEIF(int LIHHDPOHLDK, int GOCGGGCOOLH, int GGBNJANNJDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0600", Offset = "0x6EAFA00", VA = "0x186EB0600")]
	public static float CNOFLFAIBLN(float LIHHDPOHLDK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6EB06E0", Offset = "0x6EAFAE0", VA = "0x186EB06E0")]
	public static float JHNOMGLGJJJ(float NOPDIJFELMF, float PMGMHFIMGOD, float HIKBGGAGLAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0430", Offset = "0x6EAF830", VA = "0x186EB0430")]
	public static float AFBFKFODLAF(float NOPDIJFELMF, float PMGMHFIMGOD, float HIKBGGAGLAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0960", Offset = "0x6EAFD60", VA = "0x186EB0960")]
	public static float OIEDEAKMBMK(float NOPDIJFELMF, float PMGMHFIMGOD, float LIHHDPOHLDK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0AD0", Offset = "0x6EAFED0", VA = "0x186EB0AD0")]
	public static float POGCGPIDOCI(float NOPDIJFELMF, float PMGMHFIMGOD, float LIHHDPOHLDK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0A20", Offset = "0x6EAFE20", VA = "0x186EB0A20")]
	public static float OOFPMMLKEKF(float NOPDIJFELMF, float PMGMHFIMGOD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0440", Offset = "0x6EAF840", VA = "0x186EB0440")]
	public static float BINODELKAAC(float JADKKKPBPMA, float ANHPPPBDANF, float KNKNGIMFEMH, float EBPPAKIOMKF, float BJOPNKBDJGB, float GJPMFKBAIBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0A40", Offset = "0x6EAFE40", VA = "0x186EB0A40")]
	public static float PHBAELFABHI(float LIHHDPOHLDK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0870", Offset = "0x6EAFC70", VA = "0x186EB0870")]
	public static float MLIMMONFDDM(float LIHHDPOHLDK, float GOCGGGCOOLH, float GGBNJANNJDO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0660", Offset = "0x6EAFA60", VA = "0x186EB0660")]
	public static float DKFOBBGAGFB(float PAHCIDJOHNA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class OFOFLPBHBIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private System.Random OKAJAADBHFB;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6EB3540", Offset = "0x6EB2940", VA = "0x186EB3540")]
	public OFOFLPBHBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6EB34C0", Offset = "0x6EB28C0", VA = "0x186EB34C0")]
	public OFOFLPBHBIO(int MNEEECCEEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x660E5B0", Offset = "0x660D9B0", VA = "0x18660E5B0", Slot = "4")]
	public virtual int HFOIJEAEKAE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6EB3490", Offset = "0x6EB2890", VA = "0x186EB3490", Slot = "5")]
	public virtual int HFOIJEAEKAE(int MGNJDKFKCCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF060", Offset = "0x6EAE460", VA = "0x186EAF060", Slot = "6")]
	public virtual int HFOIJEAEKAE(int DKEJJDDCLIM, int MGNJDKFKCCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6EB3460", Offset = "0x6EB2860", VA = "0x186EB3460")]
	public double FOILMAPPCEO()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class KOGIJOCBMJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2F08C90", Offset = "0x2F08090", VA = "0x182F08C90")]
	[EAFJAFLMLNJ("This should be replaced with the `is not` operator in C# 9.")]
	public static bool NNDIMBNOIFO<T>(this object MBGHIKEGJAA, [Out][NotNullWhen(true)] T CIFMGKBFCHA) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class LNONFMKMNJN
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6EB20A0", Offset = "0x6EB14A0", VA = "0x186EB20A0")]
	public static (float3, float3, float3) NIAHCPDDDLC([In] this quaternion MBGHIKEGJAA)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1730", Offset = "0x6EB0B30", VA = "0x186EB1730")]
	private static float3 INILDLGBLBI(quaternion FFHDCPBKENE, math.RotationOrder DBKHBGPGICE = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1520", Offset = "0x6EB0920", VA = "0x186EB1520")]
	private static float3 HEAKJLMEICC(float3 LNKEDMLGPLM, math.RotationOrder DBKHBGPGICE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1680", Offset = "0x6EB0A80", VA = "0x186EB1680")]
	public static float3 HOIDADAJPAE(this quaternion FFHDCPBKENE, math.RotationOrder DBKHBGPGICE = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2190", Offset = "0x6EB1590", VA = "0x186EB2190")]
	public static float PEEEOKNNBNC(this quaternion GIDMNJLJNOH, quaternion OONEKAPAHLL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6EB15F0", Offset = "0x6EB09F0", VA = "0x186EB15F0")]
	[CompilerGenerated]
	internal static float3 HJLIEGOGAAD(float3 LNKEDMLGPLM)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class DOBDCFEGIKM
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class DFNNEOIPHOO : ICNNFPBEKOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly System.Random KLDCJBBJADP;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF060", Offset = "0x6EAE460", VA = "0x186EAF060", Slot = "4")]
		public int HFOIJEAEKAE(int IPEIFPDPGGH, int FMENHPNMGKA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6EAEFF0", Offset = "0x6EAE3F0", VA = "0x186EAEFF0", Slot = "5")]
		public float GPPGAILGBCI(float IPEIFPDPGGH, float KIPDNFGNOEJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6EAEFB0", Offset = "0x6EAE3B0", VA = "0x186EAEFB0")]
		private double GCGCDIGOOAB()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF090", Offset = "0x6EAE490", VA = "0x186EAF090")]
		public DFNNEOIPHOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly ICNNFPBEKOO GHAAIFFCBNJ;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF110", Offset = "0x6EAE510", VA = "0x186EAF110")]
	public static ulong OAGFHDLDLPJ()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class KBANGNEHMAL
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2EF08E0", Offset = "0x2EEFCE0", VA = "0x182EF08E0")]
	public static bool FLBDNJGHFMI<T>(this IReadOnlyCollection<T> MBGHIKEGJAA, int AEAHMAMPNLO) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CKOPMBHOCGD
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2C54040", Offset = "0x2C53440", VA = "0x182C54040")]
	public static bool BAAAKILEBPL<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> MBGHIKEGJAA, IReadOnlyDictionary<TKey, TValue> OCKBFCIKBEN) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class PHDNGANJBIP
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3016240", Offset = "0x3015640", VA = "0x183016240")]
	public static TValue? JDCEMGODBPM<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> MBGHIKEGJAA, TKey GMJINMLEEAC) where TValue : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class BGMHFEEPHDG
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6EAEBC0", Offset = "0x6EADFC0", VA = "0x186EAEBC0")]
	public static void JNFLGGLMFJH(this IReadOnlyList<Action> MBGHIKEGJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2BE58E0", Offset = "0x2BE4CE0", VA = "0x182BE58E0")]
	public static bool FDPJDJCOJAH<T>(this IReadOnlyList<T> MBGHIKEGJAA, int AEAHMAMPNLO, [Out][NotNullWhen(true)][JIOMAKBLFNI("This should be `T?` in C# 9.")] T CIFMGKBFCHA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5A80", Offset = "0x2BE4E80", VA = "0x182BE5A80")]
	public static bool HHNIKIOFKLN<T>(this IReadOnlyList<T> MBGHIKEGJAA, int AEAHMAMPNLO, [Out] CLCOJBEHIHA<T> CIFMGKBFCHA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5C20", Offset = "0x2BE5020", VA = "0x182BE5C20")]
	public static T KBIJNCADNBJ<T>(this IReadOnlyList<T> MBGHIKEGJAA, int AEAHMAMPNLO, [In] T HKMFBJCACKP) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5A30", Offset = "0x2BE4E30", VA = "0x182BE5A30")]
	[JIOMAKBLFNI("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T HGLCBOMCGHK<T>(this IReadOnlyList<T> MBGHIKEGJAA, int AEAHMAMPNLO) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5B60", Offset = "0x2BE4F60", VA = "0x182BE5B60")]
	public static T? JDCEMGODBPM<T>(this IReadOnlyList<T> MBGHIKEGJAA, int AEAHMAMPNLO) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class IFJKPJBGKHB
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2E978C0", Offset = "0x2E96CC0", VA = "0x182E978C0")]
	public static int APCLAAIMPOG<T>([In] this ReadOnlySequence<T> CIALNDLMFDM, [In] T LIHHDPOHLDK) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2E97BC0", Offset = "0x2E96FC0", VA = "0x182E97BC0")]
	public static bool IGGFJCJMKDP<T>([In] this ReadOnlySequence<T> CIALNDLMFDM, [In] ReadOnlySpan<T> OCKBFCIKBEN) where T : IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class KMGJFOGJPFA
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2F080F0", Offset = "0x2F074F0", VA = "0x182F080F0")]
	public static string FEKKLLKDDDG<T>([In] this ReadOnlySpan<T> MBGHIKEGJAA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2F076F0", Offset = "0x2F06AF0", VA = "0x182F076F0")]
	public static string DICNLNGIIDK<T>([In] this ReadOnlySpan<T> MBGHIKEGJAA, string MGABCAGBJJE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class ENBDPNJPBBM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static DFLNBDCBGOC CFGIEHHOBNC
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF440", Offset = "0x6EAE840", VA = "0x186EAF440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF490", Offset = "0x6EAE890", VA = "0x186EAF490")]
	public static double PJBAAAACEDL(this DFLNBDCBGOC MBGHIKEGJAA, long KJKNJMFKNCD)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class JJAOEFECHBN : DFLNBDCBGOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Stopwatch ENJNNAIIFDP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long IEANFLAEJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6EB0410", Offset = "0x6EAF810", VA = "0x186EB0410", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	private JJAOEFECHBN(Stopwatch CDAIPIPNKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6EB02F0", Offset = "0x6EAF6F0", VA = "0x186EB02F0")]
	public static JJAOEFECHBN BIENIKBEDBF(Stopwatch CDAIPIPNKHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0360", Offset = "0x6EAF760", VA = "0x186EB0360")]
	public static JJAOEFECHBN BKPFIPGMGAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class JOMFPKDFOGA
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6DF4F70", Offset = "0x6DF4370", VA = "0x186DF4F70")]
	public static float3 IKGFJNLIJJE([In] this RigidTransform MBGHIKEGJAA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6DF50A0", Offset = "0x6DF44A0", VA = "0x186DF50A0")]
	public static float3 OHHIMLNAENI([In] this RigidTransform MBGHIKEGJAA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xC694E0", Offset = "0xC688E0", VA = "0x180C694E0")]
	public static (float3, float3, float3) GEEMPHCJFHA([In] this RigidTransform MBGHIKEGJAA)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0BD0", Offset = "0x6EAFFD0", VA = "0x186EB0BD0")]
	public static RigidTransform HEEEBHNJHPA([In] this RigidTransform MBGHIKEGJAA)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class PNPAHILJBFN
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6EB35D0", Offset = "0x6EB29D0", VA = "0x186EB35D0")]
	public static RigidTransform DCMDAGHIDBL(RigidTransform JAPGLABBCDI, RigidTransform LNKMKBJABDF)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class KOFGCEHHJOO
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6EB14E0", Offset = "0x6EB08E0", VA = "0x186EB14E0")]
	public static float KCEGMECKJCB([In] this (byte Fourth, byte Third, byte Second, byte First) MBGHIKEGJAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1460", Offset = "0x6EB0860", VA = "0x186EB1460")]
	public static int CIPJANAMJAJ(this float MBGHIKEGJAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1470", Offset = "0x6EB0870", VA = "0x186EB1470")]
	public static (byte, byte, byte, byte) KAKLIEPNHLM(this float MBGHIKEGJAA)
	{
		return default((byte, byte, byte, byte));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class PDJCHNFDFAI
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2EAA220", Offset = "0x2EA9620", VA = "0x182EAA220")]
	public static ReadOnlySpan<T?> HAOACBKKEKA<T>([In] this Span<T> MBGHIKEGJAA)
	{
		return default(ReadOnlySpan<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class CFPGCICBDFK
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6EAEE40", Offset = "0x6EAE240", VA = "0x186EAEE40")]
	public static StringBuilder EOCEFEEGHNB(this StringBuilder MBGHIKEGJAA, int MJBNPHFNDLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6EAEEA0", Offset = "0x6EAE2A0", VA = "0x186EAEEA0")]
	public static StringBuilder FCOFMOMMIJP(this StringBuilder MBGHIKEGJAA, int MJBNPHFNDLH, string PCMCEFKLCKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6EAEF10", Offset = "0x6EAE310", VA = "0x186EAEF10")]
	public static StringBuilder IMNIBNOCOMK(this StringBuilder MBGHIKEGJAA, char DEIPDEHMKCK, int JCHFNDMJHIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class MAMAKGLDBMI
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static Regex NBLDOFCFCDA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static Regex FGNJEEDFHNF;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly char[] CMOLJPJCLGI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly string[] IDKKNJLPDEA;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6230630", Offset = "0x622FA30", VA = "0x186230630")]
	public static bool OGNMDNNBPFH(this string? NDBHBGLFMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2780", Offset = "0x6EB1B80", VA = "0x186EB2780")]
	public static string? MDEMOOHFFFF(this string? MBGHIKEGJAA, int ALOHHMGKCFH, string MPNOBGFCADN = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6EB25C0", Offset = "0x6EB19C0", VA = "0x186EB25C0")]
	public static string HEBKFOBPIEH(this string MBGHIKEGJAA, int ALOHHMGKCFH, string MPNOBGFCADN = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2710", Offset = "0x6EB1B10", VA = "0x186EB2710")]
	public static int LNEJFHKJEGJ(this string NDBHBGLFMGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2660", Offset = "0x6EB1A60", VA = "0x186EB2660")]
	public static string IFIMLNOHMBC(this string NDBHBGLFMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2450", Offset = "0x6EB1850", VA = "0x186EB2450")]
	public static string[] DPHCMIGDEGA(this string NDBHBGLFMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2530", Offset = "0x6EB1930", VA = "0x186EB2530")]
	private static bool ECMDOPLPAEO(string LKDIDALLBKI, int IHLILPEDKCL, [Out] int KFBKPBNKJPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6EB22E0", Offset = "0x6EB16E0", VA = "0x186EB22E0")]
	private static bool DFDFHEDEKOD(string LKDIDALLBKI, int IHLILPEDKCL, [Out] int KFBKPBNKJPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2860", Offset = "0x6EB1C60", VA = "0x186EB2860")]
	public static int PPHHPEJAPDP(string LKDIDALLBKI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class DDKOCNMGAEE<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public readonly struct MIDALJOCCOA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x481E240", Offset = "0x481D640", VA = "0x18481E240", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static int IMDAIFDINPL;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static NNAEDKHBCBJ GJMGKOHFGHP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static long IEANFLAEJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x487CFE0", Offset = "0x487C3E0", VA = "0x18487CFE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5C28770", Offset = "0x5C27B70", VA = "0x185C28770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5C285C0", Offset = "0x5C279C0", VA = "0x185C285C0")]
	public static MIDALJOCCOA HICPIOGNCJA()
	{
		return default(MIDALJOCCOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5C28420", Offset = "0x5C27820", VA = "0x185C28420")]
	private static void DOENJDOEFGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5C283A0", Offset = "0x5C277A0", VA = "0x185C283A0")]
	public static void AEAEDDMNDLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct NNAEDKHBCBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly DFLNBDCBGOC ENJNNAIIFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly long FOBJKOKNPNC;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6EB3370", Offset = "0x6EB2770", VA = "0x186EB3370")]
	public NNAEDKHBCBJ(DFLNBDCBGOC CDAIPIPNKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6EB3250", Offset = "0x6EB2650", VA = "0x186EB3250")]
	public long BNENPBHJELF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6EB32E0", Offset = "0x6EB26E0", VA = "0x186EB32E0")]
	public double PJBAAAACEDL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6EB31C0", Offset = "0x6EB25C0", VA = "0x186EB31C0")]
	public double ACONBCNFPPF()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class DCJHFDGJHPH
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6EAEF70", Offset = "0x6EAE370", VA = "0x186EAEF70")]
	public static bool LOMFCOGPPLN(this Type MBGHIKEGJAA, Type OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2C80F40", Offset = "0x2C80340", VA = "0x182C80F40")]
	public static bool LOMFCOGPPLN<T>(this Type MBGHIKEGJAA) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class DEJHFBICOMI
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A280", Offset = "0x5E99680", VA = "0x185E9A280")]
	public static uint IJDDKAMGKKN(this uint MBGHIKEGJAA, int MGEMHICLKEP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5F6A4D0", Offset = "0x5F698D0", VA = "0x185F6A4D0")]
	public static uint KPBGJGDGGJC(this uint MBGHIKEGJAA, int MGEMHICLKEP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6EAEFA0", Offset = "0x6EAE3A0", VA = "0x186EAEFA0")]
	public static uint GIJMOMGEOAM(this uint MBGHIKEGJAA, uint CANBPJKGCCB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1360310", Offset = "0x135F710", VA = "0x181360310")]
	public static int CIPJANAMJAJ(this uint MBGHIKEGJAA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class HADPEPLBEPA
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2E73140", Offset = "0x2E72540", VA = "0x182E73140")]
	public static bool HMEPGFFNEJB<T>([In] this T? MBGHIKEGJAA, [Out] T LIHHDPOHLDK) where T : struct
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
