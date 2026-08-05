using System;
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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
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
		[Cpp2IlInjected.Address(RVA = "0x6103970", Offset = "0x6102D70", VA = "0x186103970")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA360", Offset = "0x7C9760", VA = "0x1807CA360")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA3A0", Offset = "0x7C97A0", VA = "0x1807CA3A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IFJEFAFNNLB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string[] JCIPJFJFJOM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6101620", Offset = "0x6100A20", VA = "0x186101620")]
	public static bool PDAALJNADGJ(string LGHCKEEBGIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6101400", Offset = "0x6100800", VA = "0x186101400")]
	private static bool MCMECOGLFDF(string CAIOIMEOMNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x61014D0", Offset = "0x61008D0", VA = "0x1861014D0")]
	public static bool MCMECOGLFDF(Exception GJJHDBIJOMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x61010D0", Offset = "0x61004D0", VA = "0x1861010D0")]
	public static string CPJPKGICLMI(string HJAICMGMEBP, string FHEIIELHIDO = "", bool FFBJGHBJJDB = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EOGHMEJCALM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6100B70", Offset = "0x60FFF70", VA = "0x186100B70")]
	public static string AOAHCKMMJCD(this Guid LHLNCEHJAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6100C10", Offset = "0x6100010", VA = "0x186100C10")]
	public static string AOAHCKMMJCD(this byte[] PIOIENDCJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6100CB0", Offset = "0x61000B0", VA = "0x186100CB0")]
	public static byte[] BPELHLAFKML(string POJACCLHPJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class IPIJGDLNHFE
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int OIHLFILNOKK<T>([In] T NNOKPENDLPE, [In] T OBLEBBNJEBK);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class GENOCOHAGPE<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct BJACBEBHANK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly int ACGCEBPHGCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public readonly int OJNGOFBJPDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public readonly bool LEGDFGDMENO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int JNICOBEOBIJ;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x4735D10", Offset = "0x4735110", VA = "0x184735D10")]
			public BJACBEBHANK(int ACGCEBPHGCG, int OJNGOFBJPDJ, bool LEGDFGDMENO)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly T[] LLNJKEBFCIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly T[] LHBABHHAPHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly OIHLFILNOKK<T> EPKMIEOHBBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly int MGPIAKKNBLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Func<bool> ELBDBMPONOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int NKGLGPDLEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly BJACBEBHANK[] FCKGKFPCECG;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x36FE1A0", Offset = "0x36FD5A0", VA = "0x1836FE1A0")]
		public GENOCOHAGPE(T[] LLNJKEBFCIF, OIHLFILNOKK<T> EPKMIEOHBBE, int MGPIAKKNBLB, Func<bool> ELBDBMPONOF, T[]? HFPLDDFMLLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x36FDE90", Offset = "0x36FD290", VA = "0x1836FDE90")]
		public bool CFHCIBMHPPO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate U BKCEDHLBHFJ<T, U>(int FLABLMHBNGP, int IGNEBKJBGHO, [In] ReadOnlySpan<T> IDKIKIJNOKN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x26BD150", Offset = "0x26BC550", VA = "0x1826BD150")]
	public static T[] JBMDGLNAMOB<T>(int HFPFBPPBALK, T EMMGNLHHPAK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x26BC770", Offset = "0x26BBB70", VA = "0x1826BC770")]
	public static void EMFPILLJBKL<T>(this T[] JFMHKAHJOFD, T EMMGNLHHPAK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x26BDB30", Offset = "0x26BCF30", VA = "0x1826BDB30")]
	public static void OLBHCKFBIEN<T>(this T[] MGNOJHKHDPK, int FPJGJJLGENP, int ILGELOEFELH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x26BD640", Offset = "0x26BCA40", VA = "0x1826BD640")]
	private static void MMHJBLBJPFI<T>(this T[] LOMPFKEACIP, int MNBFHBKIFPG, int ENFGAJAAOGA, T[] KMJGEHGGFFC, int PMJABEGNLOH, int DNEBPCBGNCL, T[] ANIEEDIHIEE, int LHOGINKINDK, OIHLFILNOKK<T> EPKMIEOHBBE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x26BC3C0", Offset = "0x26BB7C0", VA = "0x1826BC3C0")]
	public static void DKJDJCMMMKJ<T>(this T[] LOMPFKEACIP, int ACGCEBPHGCG, int CBPPKGAPPDD, OIHLFILNOKK<T> EPKMIEOHBBE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x26BD9D0", Offset = "0x26BCDD0", VA = "0x1826BD9D0")]
	public static GENOCOHAGPE<T> NEODPFJOHHB<T>(this T[] LOMPFKEACIP, OIHLFILNOKK<T> EPKMIEOHBBE, int MGPIAKKNBLB, Func<bool> ELBDBMPONOF, [Optional] T[]? HFPLDDFMLLI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x26BDBB0", Offset = "0x26BCFB0", VA = "0x1826BDBB0")]
	public static T[] PFFAMGPNDFD<T>(this T[] MGNOJHKHDPK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x26BD2C0", Offset = "0x26BC6C0", VA = "0x1826BD2C0")]
	public static T[] KJAIBBNBCNA<T>(this T[] IOBIJNHPCFI, T IFAKJBBLBCH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x26BC940", Offset = "0x26BBD40", VA = "0x1826BC940")]
	public static T[] GDKMKNFEBNC<T>(this T[] IOBIJNHPCFI, int AHDNEIKOMIB, T IFAKJBBLBCH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x26BD0A0", Offset = "0x26BC4A0", VA = "0x1826BD0A0")]
	public static T[] HJFAIBDOIJJ<T>(this T[] IOBIJNHPCFI, int AHDNEIKOMIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x26BD3A0", Offset = "0x26BC7A0", VA = "0x1826BD3A0")]
	public static T[] MECBJKIPJCJ<T>(this T[] IOBIJNHPCFI, int AHDNEIKOMIB, T IFAKJBBLBCH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x26BBE70", Offset = "0x26BB270", VA = "0x1826BBE70")]
	public static U[] ABJHNMFMGFB<U, T>(this T[] PGGCOHKMABC, int DINPPNDGKPB, BKCEDHLBHFJ<T, U> EIFENCDFPPL) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x61023C0", Offset = "0x61017C0", VA = "0x1861023C0")]
	public static byte[] ICLLHENFKED(this byte[] LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6102650", Offset = "0x6101A50", VA = "0x186102650")]
	public static byte[] OEAIJPMPHMM(this byte[] LOMPFKEACIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PCLDNFIHFGF
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x281DFE0", Offset = "0x281D3E0", VA = "0x18281DFE0")]
	public static void BOOLPLNPDDO<T>(this ICollection<T> LOMPFKEACIP, IEnumerable<T> LMCPEPEFDGI) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JENGBNNDGNE
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x26E9E50", Offset = "0x26E9250", VA = "0x1826E9E50")]
	public static void PPBFPPNGDPG<K, V>(this IDictionary<K, V> LOMPFKEACIP, [In] K GPGELODKPOB, [In] V ANJCCKHBJJO, Func<V, V, V> ALCCIPOANLG) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x26E9890", Offset = "0x26E8C90", VA = "0x1826E9890")]
	public static void OIGOBFPFBGE<K, V>(this IDictionary<K, List<V>> LOMPFKEACIP, [In] K GPGELODKPOB, [In] V ANJCCKHBJJO) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x26E87C0", Offset = "0x26E7BC0", VA = "0x1826E87C0")]
	public static TVal LOFIHHKAGED<TVal, TKey>(this IDictionary<TKey, TVal> LGLDLFPPHKD, [In] TKey GPGELODKPOB, [Optional][GLNHMJBGBDI("`default!` shouldn't be necessary in C# 9")] TVal ELCHMECHBCC) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x26E82D0", Offset = "0x26E76D0", VA = "0x1826E82D0")]
	public static TVal LOFIHHKAGED<TVal, TKey>(this IDictionary<TKey, TVal> LGLDLFPPHKD, [In] TKey GPGELODKPOB, Func<TVal> CAAMJBFDNMJ) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x26E7900", Offset = "0x26E6D00", VA = "0x1826E7900")]
	public static TValue AGADEPOKKIP<TValue, TKey>(this IDictionary<TKey, TValue> LGLDLFPPHKD, [In] TKey GPGELODKPOB, [Optional][In][GLNHMJBGBDI("`default!` and null-oblivious region shouldn't be necessary in C# 9")] TValue ELCHMECHBCC)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x26E92F0", Offset = "0x26E86F0", VA = "0x1826E92F0")]
	public static V NIDLDLJGCDP<V, K>(this IDictionary<K, V> LOMPFKEACIP, [In] K GPGELODKPOB) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x26E8240", Offset = "0x26E7640", VA = "0x1826E8240")]
	public static T2[] CGOAPCPPLPM<T2, T1>(this Dictionary<T1, T2>.ValueCollection MCIDFFBEGLN) where T2 : notnull where T1 : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class HMOEHCNMFEF
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool OLEKMMONJJO<TArgs, T>([In] TArgs EALPNGKPAMO, T IEEBNOOJIPC);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate U LGFKFHAAEHJ<TArg, U>([In] TArg CMDECJALHDG);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate U AFECMDCCEGM<TArg, T, U>([In] TArg CMDECJALHDG, T DDIFDMJCCFB);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate U LLKMDAMNOEN<TArg, T, U>([In] TArg CMDECJALHDG, IEnumerable<T> HAJDGKCJJAJ);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate U EHDIMILANLG<TArg, T, U>([In] TArg CMDECJALHDG, T DDIFDMJCCFB);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public readonly struct FOFAEDHJOHG<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3652B00", Offset = "0x3651F00", VA = "0x183652B00")]
		[GLNHMJBGBDI("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) BCHLNKDMECH(T LCEHAOMCHPF)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3652B60", Offset = "0x3651F60", VA = "0x183652B60")]
		[GLNHMJBGBDI("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) CPNPDKGFDGF(IEnumerable<T> NHEFJJIFLOE)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class KHNBKOCALDO<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerable<U> other;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public IEnumerable<U> <>3__other;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private T with;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T <>3__with;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private IEnumerator<T> <selfEnumerator>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private IEnumerator<U> <otherEnumerator>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x92DDA0", Offset = "0x92D1A0", VA = "0x18092DDA0")]
		[DebuggerHidden]
		public KHNBKOCALDO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9AB0", Offset = "0x3AC8EB0", VA = "0x183AC9AB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9470", Offset = "0x3AC8870", VA = "0x183AC9470", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8C70", Offset = "0x3AC8070", VA = "0x183AC8C70")]
		private void JIKMBFFNLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8B70", Offset = "0x3AC7F70", VA = "0x183AC8B70")]
		private void DNFFEPBIMEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9A10", Offset = "0x3AC8E10", VA = "0x183AC9A10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3AC97F0", Offset = "0x3AC8BF0", VA = "0x183AC97F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x353D890", Offset = "0x353CC90", VA = "0x18353D890", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class PJDPDLKNFBA<T> : IEnumerable<(T, MEHMHNNDBEN<T>)>, IEnumerable, IEnumerator<(T, MEHMHNNDBEN<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private (T Current, MEHMHNNDBEN<T> Next) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private IEnumerator<T> <enumerator>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private (T, MEHMHNNDBEN<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x3356F00", Offset = "0x3356300", VA = "0x183356F00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, MEHMHNNDBEN<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x40A09E0", Offset = "0x409FDE0", VA = "0x1840A09E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B890", Offset = "0x1C3AC90", VA = "0x181C3B890")]
		[DebuggerHidden]
		public PJDPDLKNFBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x353B740", Offset = "0x353AB40", VA = "0x18353B740", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x409FC10", Offset = "0x409F010", VA = "0x18409FC10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x409F1A0", Offset = "0x409E5A0", VA = "0x18409F1A0")]
		private void JIKMBFFNLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x40A0940", Offset = "0x409FD40", VA = "0x1840A0940", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x40A0660", Offset = "0x409FA60", VA = "0x1840A0660", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, MEHMHNNDBEN<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x353D890", Offset = "0x353CC90", VA = "0x18353D890", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class DHKLLCGLCCN<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private U <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Func<FOFAEDHJOHG<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Func<FOFAEDHJOHG<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private IEnumerator<T> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private IEnumerator<U> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		U IEnumerator<UnityEngine.SpookyHash.U>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (U)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x92DDA0", Offset = "0x92D1A0", VA = "0x18092DDA0")]
		[DebuggerHidden]
		public DHKLLCGLCCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4FD98C0", Offset = "0x4FD8CC0", VA = "0x184FD98C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4FD93F0", Offset = "0x4FD87F0", VA = "0x184FD93F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4FD93A0", Offset = "0x4FD87A0", VA = "0x184FD93A0")]
		private void JIKMBFFNLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4FD9350", Offset = "0x4FD8750", VA = "0x184FD9350")]
		private void DNFFEPBIMEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4FD9870", Offset = "0x4FD8C70", VA = "0x184FD9870", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x369C480", Offset = "0x369B880", VA = "0x18369C480", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x369CB00", Offset = "0x369BF00", VA = "0x18369CB00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class HGDBBCKHBDM<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public HGDBBCKHBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x375B580", Offset = "0x375A980", VA = "0x18375B580")]
		internal bool HACFONFOGCH(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x375B5D0", Offset = "0x375A9D0", VA = "0x18375B5D0")]
		internal bool IMDCCCKDPBI(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class JGEFMGMHGBN<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private (T Lhs, U Rhs) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IEnumerable<T> lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public IEnumerable<T> <>3__lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private IEnumerable<U> rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public IEnumerable<U> <>3__rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private IEnumerator<T> <lhsIt>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private IEnumerator<U> <rhsIt>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private (T, U) System.Collections.Generic.IEnumerator<(TLhs,URhs)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA1FB90", Offset = "0xA1EF90", VA = "0x180A1FB90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, U));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x367A060", Offset = "0x3679460", VA = "0x18367A060", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B890", Offset = "0x1C3AC90", VA = "0x181C3B890")]
		[DebuggerHidden]
		public JGEFMGMHGBN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E030", Offset = "0x3A2D430", VA = "0x183A2E030", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E330", Offset = "0x3A2D730", VA = "0x183A2E330", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E260", Offset = "0x3A2D660", VA = "0x183A2E260", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x353D890", Offset = "0x353CC90", VA = "0x18353D890", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2690850", Offset = "0x268FC50", VA = "0x182690850")]
	public static bool CBJACCMICOI<T, TArgs>(this IEnumerable<T> LOMPFKEACIP, [In] TArgs EALPNGKPAMO, OLEKMMONJJO<TArgs, T> DGACHEFIKJI) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x26934F0", Offset = "0x26928F0", VA = "0x1826934F0")]
	public static U ILKGADNHINJ<U, T>(this IEnumerable<T> LOMPFKEACIP, Func<U> DPJFKJCDGMJ, Func<T, U> LCEHAOMCHPF, Func<IEnumerable<T>, U> NHEFJJIFLOE) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x26924B0", Offset = "0x26918B0", VA = "0x1826924B0")]
	public static bool FJDMPEILEKB<T, TArgs>(this IEnumerable<T> LOMPFKEACIP, [In] TArgs EALPNGKPAMO, OLEKMMONJJO<TArgs, T> DGACHEFIKJI) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2690A80", Offset = "0x268FE80", VA = "0x182690A80")]
	public static U CMIHOGLGOGL<U, T, TArg>(this IEnumerable<T> LOMPFKEACIP, [In] TArg CMDECJALHDG, LGFKFHAAEHJ<TArg, U> DPJFKJCDGMJ, AFECMDCCEGM<TArg, T, U> LCEHAOMCHPF, LLKMDAMNOEN<TArg, T, U> NHEFJJIFLOE) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2693740", Offset = "0x2692B40", VA = "0x182693740")]
	public static IEnumerable<U> JJLHOGEJNDG<U, T, TArg>(this IEnumerable<T> LOMPFKEACIP, [In] TArg CMDECJALHDG, EHDIMILANLG<TArg, T, U> NJAEFHOOELG) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x268FC60", Offset = "0x268F060", VA = "0x18268FC60")]
	public static IEnumerable<T> LAICJLJIBEH<T>(params IEnumerable<T>[] FAAAJIACEOG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x268FDE0", Offset = "0x268F1E0", VA = "0x18268FDE0")]
	public static bool BMADGPPGLNH<T>(this IEnumerable<T> HEKLPNHIOGD, IEnumerable<T> KMJGEHGGFFC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x268FC60", Offset = "0x268F060", VA = "0x18268FC60")]
	public static IEnumerable<(TKey?, TValue?)>? OLCBHDLNDFP<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x268FFA0", Offset = "0x268F3A0", VA = "0x18268FFA0")]
	public static IEnumerable<T> BMEDMCMOGMJ<T, TKey>(this IEnumerable<T> KKKEFMMFFLJ, Func<T, TKey> GPPEBDJANII) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x260EED0", Offset = "0x260E2D0", VA = "0x18260EED0")]
	[IteratorStateMachine(typeof(KHNBKOCALDO<, >))]
	public static IEnumerable<T> OMFMJIEBHBG<T, U>(this IEnumerable<T> LOMPFKEACIP, IEnumerable<U> KMJGEHGGFFC, [Optional][GLNHMJBGBDI("`default!` shouldn't be necessary in C# 9")] T EMMGNLHHPAK) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x24139D0", Offset = "0x2412DD0", VA = "0x1824139D0")]
	public static T FHOKCCEALPA<T>(this IEnumerable<T> HEKLPNHIOGD, T ELCHMECHBCC) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x26922C0", Offset = "0x26916C0", VA = "0x1826922C0")]
	public static T FHOKCCEALPA<T>(this IEnumerable<T> HEKLPNHIOGD, T ELCHMECHBCC, Func<T, bool> DGACHEFIKJI) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2694160", Offset = "0x2693560", VA = "0x182694160")]
	public static T? KBEKACAPPKK<T>(this IEnumerable<T> LOMPFKEACIP, Func<T, bool> DGACHEFIKJI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2691620", Offset = "0x2690A20", VA = "0x182691620")]
	public static void DKJMJDKMCPA<T>(this IEnumerable<T> LOMPFKEACIP, Action<T> KJOFNMHPFEC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x25ABF40", Offset = "0x25AB340", VA = "0x1825ABF40")]
	[IteratorStateMachine(typeof(PJDPDLKNFBA<>))]
	public static IEnumerable<(T, MEHMHNNDBEN<T>)> HEGFEOMJAOD<T>(this IEnumerable<T> LOMPFKEACIP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2695B80", Offset = "0x2694F80", VA = "0x182695B80")]
	public static bool OFFFFBEECJP<T>(this IEnumerable<T> LOMPFKEACIP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x268FC60", Offset = "0x268F060", VA = "0x18268FC60")]
	public static IEnumerable<IMFPLNAKCEA<T>> BLAEHDOLMPP<T>(this IEnumerable<T> LOMPFKEACIP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2696240", Offset = "0x2695640", VA = "0x182696240")]
	public static bool PFEHLHJGPIL<T>(this IEnumerable<T> LOMPFKEACIP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2692CC0", Offset = "0x26920C0", VA = "0x182692CC0")]
	public static IEnumerable<T> HCMPMKOJDHM<T>(this IEnumerable<T>? LOMPFKEACIP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x25ABC30", Offset = "0x25AB030", VA = "0x1825ABC30")]
	[IteratorStateMachine(typeof(DHKLLCGLCCN<, >))]
	public static IEnumerable<U> GMEJAMDCPMH<U, T>(this IEnumerable<T> LOMPFKEACIP, Func<FOFAEDHJOHG<U>, T, (bool Zero, U One, IEnumerable<U> Many)> MBAGJOCDHPC) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2695CB0", Offset = "0x26950B0", VA = "0x182695CB0")]
	public static int OFHBGICCLIH<T>(this IEnumerable<T> LOMPFKEACIP, int MFLABLEGPDD = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2692070", Offset = "0x2691470", VA = "0x182692070")]
	public static bool EEBKIPEOEIP<T>(this IEnumerable<T> LOMPFKEACIP, IEnumerable<T> KMJGEHGGFFC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x26961E0", Offset = "0x26955E0", VA = "0x1826961E0")]
	public static IEnumerable<T> OMNBGBKELNN<T>(this IEnumerable<T> LOMPFKEACIP, int CBPJCGCFFPD, int NDKDPLHPGJO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2690F00", Offset = "0x2690300", VA = "0x182690F00")]
	public static (IEnumerable<T>, IEnumerable<T>) CPFMMPICOAA<T>(this IEnumerable<T> LOMPFKEACIP, Func<T, bool> JPOLMMMCKFC) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2693070", Offset = "0x2692470", VA = "0x182693070")]
	public static string HDHMJEJOFMO<T>(this IEnumerable<T> LOMPFKEACIP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x26958B0", Offset = "0x2694CB0", VA = "0x1826958B0")]
	public static Dictionary<TKey?, TValue?>? NLIIGDJCFMB<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> HEKLPNHIOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x26958B0", Offset = "0x2694CB0", VA = "0x1826958B0")]
	public static Dictionary<TKey?, TValue?>? NLIIGDJCFMB<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> HEKLPNHIOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2692230", Offset = "0x2691630", VA = "0x182692230")]
	public static List<T> EGPLAGNIMDN<T>(this IEnumerable<T> LOMPFKEACIP, int LNJIGPAGCFO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2693720", Offset = "0x2692B20", VA = "0x182693720")]
	public static string IOHEIFNKIHF<T>(this IEnumerable<T> LOMPFKEACIP, string HMOJCEECHOJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x26950D0", Offset = "0x26944D0", VA = "0x1826950D0")]
	public static (IReadOnlyList<T?>?, IReadOnlyList<U?>?) NLAGPOALCGL<T, U>(this IEnumerable<(T Lhs, U Rhs)> LOMPFKEACIP)
	{
		return default((IReadOnlyList<T>, IReadOnlyList<U>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x25CE8F0", Offset = "0x25CDCF0", VA = "0x1825CE8F0")]
	[IteratorStateMachine(typeof(JGEFMGMHGBN<, >))]
	public static IEnumerable<(T, U)> BALFMFBEAPL<T, U>(this IEnumerable<T> NNOKPENDLPE, IEnumerable<U> OBLEBBNJEBK) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2692A70", Offset = "0x2691E70", VA = "0x182692A70")]
	public static IEnumerable<V> GGOKKNMPAGM<V, T, U>(this IEnumerable<T> LOMPFKEACIP, IEnumerable<U> KMJGEHGGFFC, Func<T, U, V> BALPGFJOCMG, [Optional][GLNHMJBGBDI("`default!` shouldn't be necessary in C# 9")] T NLKNJINKJIA, [Optional][GLNHMJBGBDI("`default!` shouldn't be necessary in C# 9")] U INPPGJHFIDJ) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2692B10", Offset = "0x2691F10", VA = "0x182692B10")]
	public static IEnumerable<(T, U)> GGOKKNMPAGM<T, U>(this IEnumerable<T> LOMPFKEACIP, IEnumerable<U> KMJGEHGGFFC, [Optional][GLNHMJBGBDI("`default!` shouldn't be necessary in C# 9")] T NLKNJINKJIA, [Optional][GLNHMJBGBDI("`default!` shouldn't be necessary in C# 9")] U INPPGJHFIDJ) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2694970", Offset = "0x2693D70", VA = "0x182694970")]
	public static TOut[] KEONIBCJGKF<TOut, TIn>(this IEnumerable<TIn> KKKEFMMFFLJ, Func<TIn, TOut> FJHGELOGNCJ) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class AKBIKCNFDDL
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6DA0", Offset = "0x2CF61A0", VA = "0x182CF6DA0")]
	public static bool DJFKLFIBCCJ<T, U>(this T LOMPFKEACIP, [In] U BHPOPDOKECN) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6FC0", Offset = "0x2CF63C0", VA = "0x182CF6FC0")]
	public static bool PLPGHOFGHLP<T>(T LOMPFKEACIP, T KMJGEHGGFFC) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class ECGOBBEGJAE
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class CHCDMELCEGK<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private T self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public T <>3__self;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x3671850", Offset = "0x3670C50", VA = "0x183671850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x92DDA0", Offset = "0x92D1A0", VA = "0x18092DDA0")]
		[DebuggerHidden]
		public CHCDMELCEGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x49326C0", Offset = "0x4931AC0", VA = "0x1849326C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4932900", Offset = "0x4931D00", VA = "0x184932900", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x49327B0", Offset = "0x4931BB0", VA = "0x1849327B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3392CE0", Offset = "0x33920E0", VA = "0x183392CE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2538550", Offset = "0x2537950", VA = "0x182538550")]
	public static void ECKGBJBLGEK<T>(this T MMKOHGNNHLF, Action<T> NPPGHDLKJDL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2538590", Offset = "0x2537990", VA = "0x182538590")]
	public static V GCCIGPGNHLI<V, T>(this T MMKOHGNNHLF, Func<T, V> NPPGHDLKJDL, [Optional][GLNHMJBGBDI("`default!` shouldn't be necessary in C# 9")] V ELCHMECHBCC) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2538820", Offset = "0x2537C20", VA = "0x182538820")]
	public static T? LANJCGCHCAA<T>(this T LOMPFKEACIP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2538640", Offset = "0x2537A40", VA = "0x182538640")]
	[IteratorStateMachine(typeof(CHCDMELCEGK<>))]
	public static IEnumerable<T> KFFOJHAOJFK<T>(this T LOMPFKEACIP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x25388B0", Offset = "0x2537CB0", VA = "0x1825388B0")]
	public static T[] NKDPODKGMAC<T>(this T LOMPFKEACIP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class ILLHIFFDMPP
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x61022C0", Offset = "0x61016C0", VA = "0x1861022C0")]
	private static byte[] OFKJNDPPGBA(int FKPCMNOCJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6101900", Offset = "0x6100D00", VA = "0x186101900")]
	private static byte[] ABBHPBHPOII(long KAGPCHCPJGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6102340", Offset = "0x6101740", VA = "0x186102340")]
	private static byte[] OLPGNFJFMBA(ulong KAGPCHCPJGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6102150", Offset = "0x6101550", VA = "0x186102150")]
	public static Guid IGKJDFONFFK(params Guid[] FDIMMJDAAHM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6101BA0", Offset = "0x6100FA0", VA = "0x186101BA0")]
	public static Guid HDHFILGDDKG([In] Guid GOJGMECCJOA, int AHDNEIKOMIB, int MCCNLGBAILL = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6102080", Offset = "0x6101480", VA = "0x186102080")]
	public static Guid HDHFILGDDKG([In] Guid GOJGMECCJOA, long AHDNEIKOMIB, int MCCNLGBAILL = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6101AD0", Offset = "0x6100ED0", VA = "0x186101AD0")]
	public static Guid HDHFILGDDKG([In] Guid GOJGMECCJOA, ulong AHDNEIKOMIB, int MCCNLGBAILL = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6101A60", Offset = "0x6100E60", VA = "0x186101A60")]
	public static Guid HDHFILGDDKG([In] Guid GOJGMECCJOA, [In] Guid ANCABBJHMDB, int MCCNLGBAILL = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6101C70", Offset = "0x6101070", VA = "0x186101C70")]
	private static Guid HDHFILGDDKG([In] Guid GOJGMECCJOA, byte[] AGLBBMHKJOM, int MCCNLGBAILL = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6101980", Offset = "0x6100D80", VA = "0x186101980")]
	private static void DCFMNJJCOPF(byte[] LHLNCEHJAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6101A10", Offset = "0x6100E10", VA = "0x186101A10")]
	private static void DCGNDNPMAJF(byte[] LHLNCEHJAOH, int BGDKODNOBOD, int APAKCINIMJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class CGBMBAPEBLB
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x61003E0", Offset = "0x60FF7E0", VA = "0x1861003E0")]
	public static int MFAGJFFEGKI(this int LOMPFKEACIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6100350", Offset = "0x60FF750", VA = "0x186100350")]
	public static int BDKPMNBKLOP(this int LOMPFKEACIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6100390", Offset = "0x60FF790", VA = "0x186100390")]
	public static int HGGJMAFPJPM(this int LOMPFKEACIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6100340", Offset = "0x60FF740", VA = "0x186100340")]
	public static int AHPBFEGNNKE(this int LOMPFKEACIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5224B70", Offset = "0x5223F70", VA = "0x185224B70")]
	public static int FKAEMKNPBNC(this int LOMPFKEACIP, int CBPPKGAPPDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x52F53D0", Offset = "0x52F47D0", VA = "0x1852F53D0")]
	public static int DFFILEEPHGG(this int LOMPFKEACIP, int CBPPKGAPPDD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CFDLFINKOPI
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NKLJCNFJDFB(int KJFKOCDIOEA, int MPDOOJCFKPF);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float KKGKLIJCNFK(float HBJLIIDAKMK, float ANJELEKCIKO);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EIBEAODEPON
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	long JNPNAGKEAAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class CIFPGPBDFHJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x24F0B90", Offset = "0x24EFF90", VA = "0x1824F0B90")]
	public static (TKey?, TValue?) FCMINGPKGCA<TKey, TValue>([In] this KeyValuePair<TKey, TValue> LOMPFKEACIP)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x24F0B60", Offset = "0x24EFF60", VA = "0x1824F0B60")]
	public static KeyValuePair<TKey?, UValue?> EKCNABJEINL<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> LOMPFKEACIP, UValue ANJCCKHBJJO)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class ADLMEFOFKKC
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class DFAPPHHJEDP<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public DFAPPHHJEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4FC6580", Offset = "0x4FC5980", VA = "0x184FC6580")]
		internal TElement ENPKJKEPCLG(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2CE51F0", Offset = "0x2CE45F0", VA = "0x182CE51F0")]
	public static int GAHFHMLAMCC<T>(this IReadOnlyList<T> MGNOJHKHDPK, T ANJCCKHBJJO) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2CE05F0", Offset = "0x2CDF9F0", VA = "0x182CE05F0")]
	public static int BKIEOPHHBHK<T>(this IReadOnlyList<T> MGNOJHKHDPK, T ANJCCKHBJJO) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2CE14B0", Offset = "0x2CE08B0", VA = "0x182CE14B0")]
	public static void BOOLPLNPDDO<T>(this HashSet<T> PEGOIPDONEG, IEnumerable<T> LMCPEPEFDGI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8220", Offset = "0x2CE7620", VA = "0x182CE8220")]
	public static void NAANLDOHEOG<T>(this IList<T> PHHAAPDMADG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7ED0", Offset = "0x2CE72D0", VA = "0x182CE7ED0")]
	public static void NAANLDOHEOG<T>(this IList<T> PHHAAPDMADG, int NBLEABCGPMK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8710", Offset = "0x2CE7B10", VA = "0x182CE8710")]
	public static List<T> NOMEPKLMLPN<T>(this List<T> ANGBOGHIHDD, Predicate<T> ACOFILGEBMC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2CE57F0", Offset = "0x2CE4BF0", VA = "0x182CE57F0")]
	public static int GAHFHMLAMCC<T>(this IReadOnlyList<T> PHHAAPDMADG, Predicate<T> DGACHEFIKJI) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2CE5DE0", Offset = "0x2CE51E0", VA = "0x182CE5DE0")]
	public static bool GOACCIEMPMF<T>(this IReadOnlyList<T> PHHAAPDMADG, Predicate<T> DGACHEFIKJI, [Out][NotNullWhen(true)] List<int>? BGEBJBDEGJI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7B60", Offset = "0x2CE6F60", VA = "0x182CE7B60")]
	public static bool JKHAEKACGLL<T>(this IReadOnlyList<T> PHHAAPDMADG, T IEEBNOOJIPC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7BB0", Offset = "0x2CE6FB0", VA = "0x182CE7BB0")]
	public static bool JKHAEKACGLL<T>(this IReadOnlyList<T> PHHAAPDMADG, T IEEBNOOJIPC, EqualityComparer<T> BELBPGMFIAC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0E20", Offset = "0x2CE0220", VA = "0x182CE0E20")]
	public static int BNFMECIMCJM<TElement, TKey>(this IList<TElement> LOALPFNMNMI, TKey NBCECHJFKPK, Func<TElement, TKey> IHJAAFJMGJL, [Optional] Func<TKey, TKey, int>? EPKMIEOHBBE, int AHDNEIKOMIB = 0, [Optional] int? CBPPKGAPPDD) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2CE07C0", Offset = "0x2CDFBC0", VA = "0x182CE07C0")]
	public static int BNFMECIMCJM<TElement, TKey>(Func<int, TElement> JFIMADFNJIH, int EDJJADMPBOE, TKey NBCECHJFKPK, Func<TElement, TKey> IHJAAFJMGJL, [Optional] Func<TKey, TKey, int>? EPKMIEOHBBE, int AHDNEIKOMIB = 0, [Optional] int? CBPPKGAPPDD) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2450", Offset = "0x2CE1850", VA = "0x182CE2450")]
	public static bool DMEDNCCKAOE<T>(this List<T> PHHAAPDMADG, T IEEBNOOJIPC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2CE4E70", Offset = "0x2CE4270", VA = "0x182CE4E70")]
	public static void FNOEHENJPPP<T>(this List<T> PHHAAPDMADG, IEnumerable<T> ANGBOGHIHDD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6A30", Offset = "0x2CE5E30", VA = "0x182CE6A30")]
	public static void JJHPGEAJNEC<T>(this List<T> PHHAAPDMADG, IEnumerable<T> ANGBOGHIHDD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6800", Offset = "0x2CE5C00", VA = "0x182CE6800")]
	public static T IOKGLAELBGP<T>(this List<T> ANGBOGHIHDD, Predicate<T> ACOFILGEBMC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2CE69C0", Offset = "0x2CE5DC0", VA = "0x182CE69C0")]
	public static T JEAPLNFKBPM<T>(this List<T> ANGBOGHIHDD, int AHDNEIKOMIB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7DB0", Offset = "0x2CE71B0", VA = "0x182CE7DB0")]
	public static void MPLGGIAFGJD<T>(this List<T> PHHAAPDMADG, int AHDNEIKOMIB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2300", Offset = "0x2CE1700", VA = "0x182CE2300")]
	public static bool COIBEFBDLJK<T>(this List<T> OCDECOJIJCB, List<T> BNGGNEIJJBN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7D10", Offset = "0x2CE7110", VA = "0x182CE7D10")]
	public static T LJNOFHMGEEM<T>(this IList<T> PHHAAPDMADG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2CE23A0", Offset = "0x2CE17A0", VA = "0x182CE23A0")]
	public static bool DAFAALIBBNK<T>(IReadOnlyList<T>? PHHAAPDMADG, int AHDNEIKOMIB, [Out][MaybeNullWhen(false)][GLNHMJBGBDI("This should be `T?` in C# 9.")] T ANIEEDIHIEE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2CE3EF0", Offset = "0x2CE32F0", VA = "0x182CE3EF0")]
	public static bool EOPJPHONHJO<T>(IReadOnlyList<T> PHHAAPDMADG, ICollection ANGBOGHIHDD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6870", Offset = "0x2CE5C70", VA = "0x182CE6870")]
	public static void IOLGEIBNNEE<T>(IReadOnlyList<T> PHHAAPDMADG, ICollection ANGBOGHIHDD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x250A690", Offset = "0x2509A90", VA = "0x18250A690")]
	public static bool HBHILAJJPFD<T>(this IReadOnlyList<T> PHHAAPDMADG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2CE0450", Offset = "0x2CDF850", VA = "0x182CE0450")]
	public static string AEEJLOEALPC<T>(this IEnumerable<T> PHHAAPDMADG, string GHMDGNKBPDF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6590", Offset = "0x2CE5990", VA = "0x182CE6590")]
	public static T HHPGCBGHHFO<T>(this IList<T> LOMPFKEACIP) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2CE4D90", Offset = "0x2CE4190", VA = "0x182CE4D90")]
	public static T FFJKCBGPFDB<T>(this IList<T> LOMPFKEACIP) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2CE5D50", Offset = "0x2CE5150", VA = "0x182CE5D50")]
	public static void GEBDDDMGIFL<T>(this IList<T> LOMPFKEACIP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2160", Offset = "0x2CE1560", VA = "0x182CE2160")]
	public static void BPCBLGLHEFK<T>(this IList<T> LOMPFKEACIP, [In] T ANJCCKHBJJO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8670", Offset = "0x2CE7A70", VA = "0x182CE8670")]
	public static T NLGCDCDALEB<T>(this IList<T> LOMPFKEACIP) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6640", Offset = "0x2CE5A40", VA = "0x182CE6640")]
	public static void HMHCMBDFJIH<T>(this List<T> LOMPFKEACIP) where T : struct, IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class NDBGGBKPPNB
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static float EGIHFHKAMEJ;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static float HOKFDHCDEEL;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static bool DCOPJFFMHHB;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly float LFFGOABEGEJ;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6103500", Offset = "0x6102900", VA = "0x186103500")]
	public static bool KMGFOMJAIJJ(float KHCOFGFJDMP, float NFAPJGNODPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x61034C0", Offset = "0x61028C0", VA = "0x1861034C0")]
	public static float KLCBBAEBHPJ(float ANJCCKHBJJO, float MOPJGAAPLNL, float MFCGJJICHPO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x61034E0", Offset = "0x61028E0", VA = "0x1861034E0")]
	public static int KLCBBAEBHPJ(int ANJCCKHBJJO, int MOPJGAAPLNL, int MFCGJJICHPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x61034A0", Offset = "0x61028A0", VA = "0x1861034A0")]
	public static float HJMDFOPJDLB(float ANJCCKHBJJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x61037F0", Offset = "0x6102BF0", VA = "0x1861037F0")]
	public static float PAHOKEHNLOC(float KHCOFGFJDMP, float NFAPJGNODPK, float MMKOHGNNHLF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6103400", Offset = "0x6102800", VA = "0x186103400")]
	public static float GDCCIGHIKLP(float KHCOFGFJDMP, float NFAPJGNODPK, float MMKOHGNNHLF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6103250", Offset = "0x6102650", VA = "0x186103250")]
	public static float CNIEBIKPKFD(float KHCOFGFJDMP, float NFAPJGNODPK, float ANJCCKHBJJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x61035F0", Offset = "0x61029F0", VA = "0x1861035F0")]
	public static float LDNJAOJGHOC(float KHCOFGFJDMP, float NFAPJGNODPK, float ANJCCKHBJJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x61031B0", Offset = "0x61025B0", VA = "0x1861031B0")]
	public static float ABCAJGECHCO(float KHCOFGFJDMP, float NFAPJGNODPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6103630", Offset = "0x6102A30", VA = "0x186103630")]
	public static float MONGBMJLEBP(float KOLPLFHOAIP, float JILDGEDOLHB, float PBAIDJFGDFM, float NNKAEDFDPPP, float KIDOONEEGII, float FANKMGPLGGP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6103410", Offset = "0x6102810", VA = "0x186103410")]
	public static float GIILCJCEHND(float ANJCCKHBJJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6103310", Offset = "0x6102710", VA = "0x186103310")]
	public static float COCLEIFOHGO(float ANJCCKHBJJO, float MOPJGAAPLNL, float MFCGJJICHPO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x61031D0", Offset = "0x61025D0", VA = "0x1861031D0")]
	public static float BABBCCBHLHD(float PLOJBCNBNML)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class LINLMJAFJKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private System.Random DMIMGDLIHME;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6102C80", Offset = "0x6102080", VA = "0x186102C80")]
	public LINLMJAFJKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6102D10", Offset = "0x6102110", VA = "0x186102D10")]
	public LINLMJAFJKF(int NBLEABCGPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x59124D0", Offset = "0x59118D0", VA = "0x1859124D0", Slot = "4")]
	public virtual int NKLJCNFJDFB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6102C20", Offset = "0x6102020", VA = "0x186102C20", Slot = "5")]
	public virtual int NKLJCNFJDFB(int MPDOOJCFKPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6102C50", Offset = "0x6102050", VA = "0x186102C50", Slot = "6")]
	public virtual int NKLJCNFJDFB(int KJFKOCDIOEA, int MPDOOJCFKPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8A50", Offset = "0x1EB7E50", VA = "0x181EB8A50")]
	public double NLDABKBFJOC()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class HIFINDCCPMC
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2689D80", Offset = "0x2689180", VA = "0x182689D80")]
	[JOOFHEAGKPO("This should be replaced with the `is not` operator in C# 9.")]
	public static bool JGFIPAKCEBD<T>(this object LOMPFKEACIP, [Out][NotNullWhen(true)] T ANIEEDIHIEE) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class OLEAHBIEPOK
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x61039F0", Offset = "0x6102DF0", VA = "0x1861039F0")]
	public static (float3, float3, float3) BAJKMPCFCBJ([In] this quaternion LOMPFKEACIP)
	{
		return default((float3, float3, float3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class EOJKDJCIACI
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private sealed class NCHDEOGLDCP : CFDLFINKOPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly System.Random GGDDEIJKKMD;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6102C50", Offset = "0x6102050", VA = "0x186102C50", Slot = "4")]
		public int NKLJCNFJDFB(int HBJLIIDAKMK, int CDEOJLKPFHO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x61030C0", Offset = "0x61024C0", VA = "0x1861030C0", Slot = "5")]
		public float KKGKLIJCNFK(float HBJLIIDAKMK, float ANJELEKCIKO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6103080", Offset = "0x6102480", VA = "0x186103080")]
		private double HLLHEADPKND()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6103130", Offset = "0x6102530", VA = "0x186103130")]
		public NCHDEOGLDCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly CFDLFINKOPI LGKLAJNPNBB;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6100D70", Offset = "0x6100170", VA = "0x186100D70")]
	public static ulong AKCLNBAPBHL()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class JODIFMFNAFC
{
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x26F4990", Offset = "0x26F3D90", VA = "0x1826F4990")]
	public static bool ODDGNKPBLHK<T>(this IReadOnlyCollection<T> LOMPFKEACIP, int AHDNEIKOMIB) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class GEHOEOAJELH
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x267E1B0", Offset = "0x267D5B0", VA = "0x18267E1B0")]
	public static bool CJCPFOKMNJI<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> LOMPFKEACIP, IReadOnlyDictionary<TKey, TValue> KMJGEHGGFFC) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class KGHHEMCICKN
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x270AF40", Offset = "0x270A340", VA = "0x18270AF40")]
	public static TValue? NBKIEMMBKPJ<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> LOMPFKEACIP, TKey GPGELODKPOB) where TValue : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class JBONPGDFAEH
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x61028D0", Offset = "0x6101CD0", VA = "0x1861028D0")]
	public static void ECPBHENEKEG(this IReadOnlyList<Action> LOMPFKEACIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x26CE6C0", Offset = "0x26CDAC0", VA = "0x1826CE6C0")]
	public static bool NICDJPMLKAP<T>(this IReadOnlyList<T> LOMPFKEACIP, int AHDNEIKOMIB, [Out][GLNHMJBGBDI("This should be `T?` in C# 9.")][NotNullWhen(true)] T ANIEEDIHIEE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x26CE550", Offset = "0x26CD950", VA = "0x1826CE550")]
	public static bool IIPFEBHOFAO<T>(this IReadOnlyList<T> LOMPFKEACIP, int AHDNEIKOMIB, [Out] IMFPLNAKCEA<T> ANIEEDIHIEE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x26CE7F0", Offset = "0x26CDBF0", VA = "0x1826CE7F0")]
	public static T NLPBOMOCMPD<T>(this IReadOnlyList<T> LOMPFKEACIP, int AHDNEIKOMIB, [In] T JLFKIFOOAOI) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x26CE520", Offset = "0x26CD920", VA = "0x1826CE520")]
	[GLNHMJBGBDI("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T GJDAEGJHBKJ<T>(this IReadOnlyList<T> LOMPFKEACIP, int AHDNEIKOMIB) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x26CE610", Offset = "0x26CDA10", VA = "0x1826CE610")]
	public static T? NBKIEMMBKPJ<T>(this IReadOnlyList<T> LOMPFKEACIP, int AHDNEIKOMIB) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class FCDAAKJHDKO
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2656D90", Offset = "0x2656190", VA = "0x182656D90")]
	public static bool MMKFBGNFOOE<T>([In] this ReadOnlyMemory<T> LOMPFKEACIP, [In] ReadOnlyMemory<T> KMJGEHGGFFC) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2656E90", Offset = "0x2656290", VA = "0x182656E90")]
	public static int OFHBGICCLIH<T>([In] this ReadOnlyMemory<T> LOMPFKEACIP, int MFLABLEGPDD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2656CF0", Offset = "0x26560F0", VA = "0x182656CF0")]
	public static string HDHMJEJOFMO<T>([In] this ReadOnlyMemory<T> LOMPFKEACIP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class MENAOIDDLNK
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x274BCE0", Offset = "0x274B0E0", VA = "0x18274BCE0")]
	public static bool MMKFBGNFOOE<T>([In] this ReadOnlySpan<T> LOMPFKEACIP, [In] ReadOnlySpan<T> KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x274BE60", Offset = "0x274B260", VA = "0x18274BE60")]
	public static int OFHBGICCLIH<T>([In] this ReadOnlySpan<T> LOMPFKEACIP, int MFLABLEGPDD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x274AB70", Offset = "0x2749F70", VA = "0x18274AB70")]
	public static string HDHMJEJOFMO<T>([In] this ReadOnlySpan<T> LOMPFKEACIP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x274B690", Offset = "0x274AA90", VA = "0x18274B690")]
	public static string IOHEIFNKIHF<T>([In] this ReadOnlySpan<T> LOMPFKEACIP, string HMOJCEECHOJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class AKDHBMLPKPI
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static EIBEAODEPON KBHNMHPOPHG
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6100200", Offset = "0x60FF600", VA = "0x186100200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6100170", Offset = "0x60FF570", VA = "0x186100170")]
	public static double EFOFGNHPCKC(this EIBEAODEPON LOMPFKEACIP, long HHLMNNPFLGP)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class EEEFPELBHHH : EIBEAODEPON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Stopwatch AODNMOBOPDP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long JNPNAGKEAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6100AE0", Offset = "0x60FFEE0", VA = "0x186100AE0", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	private EEEFPELBHHH(Stopwatch IHKMHHIMFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6100B00", Offset = "0x60FFF00", VA = "0x186100B00")]
	public static EEEFPELBHHH LFHAFLMCHAN(Stopwatch IHKMHHIMFGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6100A30", Offset = "0x60FFE30", VA = "0x186100A30")]
	public static EEEFPELBHHH FINJKOKGIOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class MFIKGLAMGFO
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6102D90", Offset = "0x6102190", VA = "0x186102D90")]
	public static float3 APIKELLLDLI([In] this RigidTransform LOMPFKEACIP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6102EC0", Offset = "0x61022C0", VA = "0x186102EC0")]
	public static float3 HDIDOCLMLJL([In] this RigidTransform LOMPFKEACIP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x1B9F910", Offset = "0x1B9ED10", VA = "0x181B9F910")]
	public static (float3, float3, float3) DNHOOIOMAIC([In] this RigidTransform LOMPFKEACIP)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6102FF0", Offset = "0x61023F0", VA = "0x186102FF0")]
	public static RigidTransform LAPGHOAIIBJ([In] this RigidTransform LOMPFKEACIP)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class KBPOGBEJODF
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6102B60", Offset = "0x6101F60", VA = "0x186102B60")]
	public static RigidTransform POFBDMPOPMM(RigidTransform FJPDMDDOJEP, RigidTransform ILLMAKCIIFJ)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class NNEIELFLLOG
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x27BD2D0", Offset = "0x27BC6D0", VA = "0x1827BD2D0")]
	public static ReadOnlySpan<T?> MBMJLLHIBLO<T>([In] this Span<T> LOMPFKEACIP)
	{
		return default(ReadOnlySpan<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class DNGOFIFAHMF
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static Regex BDLPLONFJHD;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static Regex OGHCCBOPKEM;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x55968E0", Offset = "0x5595CE0", VA = "0x1855968E0")]
	public static bool HBHILAJJPFD(this string? BDOLMNJIDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x61007E0", Offset = "0x60FFBE0", VA = "0x1861007E0")]
	public static string? MGPDIKBLKOE(this string? LOMPFKEACIP, int AKAFCPJAPHE, string DAHNFJDDCOJ = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6100670", Offset = "0x60FFA70", VA = "0x186100670")]
	public static string AMJKOPCIKKD(this string LOMPFKEACIP, int AKAFCPJAPHE, string DAHNFJDDCOJ = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x61008C0", Offset = "0x60FFCC0", VA = "0x1861008C0")]
	public static int OJHLHAIEFEE(this string BDOLMNJIDPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6100720", Offset = "0x60FFB20", VA = "0x186100720")]
	public static string HKAFHKCIBOB(this string BDOLMNJIDPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class DPKICLBPBHM<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct FJECFBLACIN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x36430D0", Offset = "0x36424D0", VA = "0x1836430D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static int CBPLOEFGAEA;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static CHEGPHFPELA NLDKHLOAGOE;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long JNPNAGKEAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3E5DC80", Offset = "0x3E5D080", VA = "0x183E5DC80")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x50238B0", Offset = "0x5022CB0", VA = "0x1850238B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x50236F0", Offset = "0x5022AF0", VA = "0x1850236F0")]
	public static FJECFBLACIN FCIGMNMIJHP()
	{
		return default(FJECFBLACIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5023560", Offset = "0x5022960", VA = "0x185023560")]
	private static void DMDJKLEDBPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x50234F0", Offset = "0x50228F0", VA = "0x1850234F0")]
	public static void CJNCIGMNEAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct CHEGPHFPELA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly EIBEAODEPON AODNMOBOPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly long KDJDBCOECCL;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6100600", Offset = "0x60FFA00", VA = "0x186100600")]
	public CHEGPHFPELA(EIBEAODEPON IHKMHHIMFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6100570", Offset = "0x60FF970", VA = "0x186100570")]
	public long JDBDFOOGBDE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x61004E0", Offset = "0x60FF8E0", VA = "0x1861004E0")]
	public double EFOFGNHPCKC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6100450", Offset = "0x60FF850", VA = "0x186100450")]
	public double BNLGJNNDJNN()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class MLPNEGHCNME
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6103050", Offset = "0x6102450", VA = "0x186103050")]
	public static bool KIEOIAJFFCC(this Type LOMPFKEACIP, Type KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2756D80", Offset = "0x2756180", VA = "0x182756D80")]
	public static bool KIEOIAJFFCC<T>(this Type LOMPFKEACIP) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class LFOAMPCMDFL
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5224B70", Offset = "0x5223F70", VA = "0x185224B70")]
	public static uint FKAEMKNPBNC(this uint LOMPFKEACIP, int CBPPKGAPPDD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x52F53D0", Offset = "0x52F47D0", VA = "0x1852F53D0")]
	public static uint DFFILEEPHGG(this uint LOMPFKEACIP, int CBPPKGAPPDD)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class ONCNPBBLKCG
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6103AE0", Offset = "0x6102EE0", VA = "0x186103AE0")]
	public static string DLJAOBCIHPG(this Assembly LOMPFKEACIP)
	{
		return null;
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
