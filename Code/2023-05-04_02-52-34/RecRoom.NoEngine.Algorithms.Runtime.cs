using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A04730", Offset = "0x6A03B30", VA = "0x186A04730")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x730090", Offset = "0x72F490", VA = "0x180730090")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9CC120", Offset = "0x9CB520", VA = "0x1809CC120")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ENCEJFEEPKD
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate int OHLDABOGKGA<T>(in T GBEJHLEFDJM, in T BDGBOHJLNIE);

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class KIDKBKHIBNO<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct JLKDJBCDGPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly int OKIEINKEHAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly int BIOOCOFHAKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public readonly bool MENCBAHHEEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int KAAPKGOFJAF;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3D60CA0", Offset = "0x3D600A0", VA = "0x183D60CA0")]
			public JLKDJBCDGPI(int OKIEINKEHAF, int BIOOCOFHAKC, bool MENCBAHHEEC)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly T[] LDELAPKFGPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly T[] GBLMMLDHOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly OHLDABOGKGA<T> HBFCEANPGHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly int MAFGOCJJFGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Func<bool> OKKHECDFMPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int IDBCMNAEDCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C4970", Offset = "0x6C3D70")]
		private readonly KIDKBKHIBNO<T>.JLKDJBCDGPI[] PKAHDKMMFHN;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x338D800", Offset = "0x338CC00", VA = "0x18338D800")]
		public KIDKBKHIBNO(T[] LDELAPKFGPI, OHLDABOGKGA<T> HBFCEANPGHH, int MAFGOCJJFGL, Func<bool> OKKHECDFMPG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C49D0", Offset = "0x6C3DD0")] T[] HMBGKABADKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x338D110", Offset = "0x338C510", VA = "0x18338D110")]
		public bool PONEJJPCJLM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate U MADFLBMIKIG<T, U>(int HJBHDFOHMCA, int JPMCFANFABH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C4A30", Offset = "0x6C3E30")] in ReadOnlySpan<T> BNPCEOGNFLN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1680280", Offset = "0x167F680", VA = "0x181680280")]
	public static ReadOnlyMemory<T> JLCMGPOMDJH<T>(this T[] INHKNJBCCPD) where T : notnull
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2190990", Offset = "0x218FD90", VA = "0x182190990")]
	public static T[] KNILLDMJPHP<T>(int GBNBGNMHGLO, T IBMOPJIJEMD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x21907E0", Offset = "0x218FBE0", VA = "0x1821907E0")]
	public static void KAMCFJJLABH<T>(this T[] JHPNADEIALO, T IBMOPJIJEMD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xD50960", Offset = "0xD4FD60", VA = "0x180D50960")]
	public static void PGNANJCBEHJ<T>(this T[] BGAKDGCGOMH, int FMPGMDDDGFN, int MCPCFIDHHAB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x218F7D0", Offset = "0x218EBD0", VA = "0x18218F7D0")]
	private static void DJEPJDJLGEO<T>(this T[] INHKNJBCCPD, int ENDLOGFLDFL, int FNBGFHPGMAI, T[] MPHACEGLFIL, int PHPMPLMIDAC, int KIFIBAFFLPA, T[] JGINNNKFHFP, int FAACICLGBBE, OHLDABOGKGA<T> HBFCEANPGHH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2190D40", Offset = "0x2190140", VA = "0x182190D40")]
	public static void MLKKPKMGKHP<T>(this T[] INHKNJBCCPD, int OKIEINKEHAF, int EJMNNLNLAFJ, OHLDABOGKGA<T> HBFCEANPGHH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x218F680", Offset = "0x218EA80", VA = "0x18218F680")]
	public static KIDKBKHIBNO<T> AFAIGLMNCNG<T>(this T[] INHKNJBCCPD, OHLDABOGKGA<T> HBFCEANPGHH, int MAFGOCJJFGL, Func<bool> OKKHECDFMPG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C4890", Offset = "0x6C3C90")] T[] HMBGKABADKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2190970", Offset = "0x218FD70", VA = "0x182190970")]
	public static T[] KJCPAGPFOFN<T>(this T[] BGAKDGCGOMH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x218FBD0", Offset = "0x218EFD0", VA = "0x18218FBD0")]
	public static T[] HELHJBEBKDM<T>(this T[] OABOCAEGGHE, T NOPLAHHAMFP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x218FCB0", Offset = "0x218F0B0", VA = "0x18218FCB0")]
	public static T[] ILPDDANBFBE<T>(this T[] OABOCAEGGHE, int EGNHJGKABLC, T NOPLAHHAMFP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x218F720", Offset = "0x218EB20", VA = "0x18218F720")]
	public static T[] AFFKPBCHGOC<T>(this T[] OABOCAEGGHE, int EGNHJGKABLC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2190B10", Offset = "0x218FF10", VA = "0x182190B10")]
	public static T[] MLKFOGGAKKG<T>(this T[] OABOCAEGGHE, int EGNHJGKABLC, T NOPLAHHAMFP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x21902A0", Offset = "0x218F6A0", VA = "0x1821902A0")]
	public static U[] JGNEFFBNOEN<U, T>(this T[] AABKFFENABM, int ENEFEHGMHEA, MADFLBMIKIG<T, U> BKCMJFFACLE) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A02C90", Offset = "0x6A02090", VA = "0x186A02C90")]
	public static byte[] CJNKLEGIGAI(this byte[] INHKNJBCCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A02EA0", Offset = "0x6A022A0", VA = "0x186A02EA0")]
	public static byte[] EAMBMHOBBED(this byte[] INHKNJBCCPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JCFEFALPFID
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x21077F0", Offset = "0x2106BF0", VA = "0x1821077F0")]
	public static void JHAKILBFFKF<T>(this ICollection<T> INHKNJBCCPD, IEnumerable<T> FAOHJBCBHLI) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class MAHMDJCPNBN
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2896790", Offset = "0x2895B90", VA = "0x182896790")]
	public static void AMHNDEKHJDI<K, V>(this IDictionary<K, V> INHKNJBCCPD, in K OGFDNCPKECB, in V LPJDDLMPNCG, Func<V, V, V> DFEMEJDMPOL) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2898780", Offset = "0x2897B80", VA = "0x182898780")]
	public static void KLHDAMICEBE<K, V>(this IDictionary<K, List<V>> INHKNJBCCPD, in K OGFDNCPKECB, in V LPJDDLMPNCG) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2897BE0", Offset = "0x2896FE0", VA = "0x182897BE0")]
	public static TVal DFDIJCKOMFL<TVal, TKey>(this IDictionary<TKey, TVal> GDCEFHMGFFB, in TKey OGFDNCPKECB, [Optional][KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")] TVal LGCPJJBBDLH) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2897E20", Offset = "0x2897220", VA = "0x182897E20")]
	public static TVal DFDIJCKOMFL<TVal, TKey>(this IDictionary<TKey, TVal> GDCEFHMGFFB, in TKey OGFDNCPKECB, Func<TVal> GOAPJJPFDCE) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2898500", Offset = "0x2897900", VA = "0x182898500")]
	public static TValue GPBLBJFIHJH<TValue, TKey>(this IDictionary<TKey, TValue> GDCEFHMGFFB, in TKey OGFDNCPKECB, [Optional][KCDCAGLMLEB("`default!` and null-oblivious region shouldn't be necessary in C# 9")] in TValue LGCPJJBBDLH)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2896D00", Offset = "0x2896100", VA = "0x182896D00")]
	public static V CDLAMHJFIGI<V, K>(this IDictionary<K, V> INHKNJBCCPD, in K OGFDNCPKECB) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x28986F0", Offset = "0x2897AF0", VA = "0x1828986F0")]
	public static T2[] JPMGPEBODFD<T2, T1>(this Dictionary<T1, T2>.ValueCollection GPPFGKKLFIH) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2898F00", Offset = "0x2898300", VA = "0x182898F00")]
	public static bool MGFMFMIIKAH<TKey, TValue>(this IDictionary<TKey, TValue> INHKNJBCCPD, TKey OGFDNCPKECB, TValue LPJDDLMPNCG) where TKey : notnull where TValue : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NHNIKNHBBLI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate bool LKDFMKFJFAM<TArgs, T>(in TArgs FKFCAPAEHKO, T JPOBIIKLHON);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate U OMDNLFKPNPJ<TArg, U>(in TArg HACNEHKIBDN);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate U HBNBDJEIEEJ<TArg, T, U>(in TArg HACNEHKIBDN, T KNOEGBEJAIO);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate U KAFIFBEDONL<TArg, T, U>(in TArg HACNEHKIBDN, IEnumerable<T> BNJGAHEFJPB);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate U OPAFEAKIGCM<TArg, T, U>(in TArg HACNEHKIBDN, T KNOEGBEJAIO);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct FJNFFAGNCLH<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B07F50", Offset = "0x2B07350", VA = "0x182B07F50")]
		[KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) ILLAOPDHOAJ(T CKEIHEONEMF)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B07FC0", Offset = "0x2B073C0", VA = "0x182B07FC0")]
		[KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) OLCHEMOLLHD(IEnumerable<T> PHOOODJMCIC)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class IDKAAOPPPBD<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public IDKAAOPPPBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x16226F0", Offset = "0x1621AF0", VA = "0x1816226F0")]
		internal bool <SetEqual>b__0(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1622730", Offset = "0x1621B30", VA = "0x181622730")]
		internal bool <SetEqual>b__1(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2836290", Offset = "0x2835690", VA = "0x182836290")]
	public static bool KIONFMFHIDL<T, TArgs>(this IEnumerable<T> INHKNJBCCPD, in TArgs FKFCAPAEHKO, LKDFMKFJFAM<TArgs, T> NJIFCLNECCM) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2834E20", Offset = "0x2834220", VA = "0x182834E20")]
	public static U HCFKDANHEEM<U, T>(this IEnumerable<T> INHKNJBCCPD, Func<U> KAPBAKFKAFD, Func<T, U> CKEIHEONEMF, Func<IEnumerable<T>, U> PHOOODJMCIC) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2835800", Offset = "0x2834C00", VA = "0x182835800")]
	public static bool JNMNAOKGLFK<T, TArgs>(this IEnumerable<T> INHKNJBCCPD, in TArgs FKFCAPAEHKO, LKDFMKFJFAM<TArgs, T> NJIFCLNECCM) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x28364B0", Offset = "0x28358B0", VA = "0x1828364B0")]
	public static U LBJIPPMFNFH<U, T, TArg>(this IEnumerable<T> INHKNJBCCPD, in TArg HACNEHKIBDN, OMDNLFKPNPJ<TArg, U> KAPBAKFKAFD, HBNBDJEIEEJ<TArg, T, U> CKEIHEONEMF, KAFIFBEDONL<TArg, T, U> PHOOODJMCIC) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2834690", Offset = "0x2833A90", VA = "0x182834690")]
	public static IEnumerable<U> DNCALBCEPLB<U, T, TArg>(this IEnumerable<T> INHKNJBCCPD, in TArg HACNEHKIBDN, OPAFEAKIGCM<TArg, T, U> DHBGDFEBNKM) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1DC5010", Offset = "0x1DC4410", VA = "0x181DC5010")]
	public static IEnumerable<T> LHINBLHJBEI<T>(params IEnumerable<T>[] ANGLIBAGFCA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2839390", Offset = "0x2838790", VA = "0x182839390")]
	public static bool PBADBLNGNDF<T>(this IEnumerable<T> KCGHNGOMAMI, IEnumerable<T> MPHACEGLFIL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1DC5010", Offset = "0x1DC4410", VA = "0x181DC5010")]
	public static IEnumerable<(TKey?, TValue?)>? BFADGAFGFNP<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C4CC0", Offset = "0x6C40C0")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? INHKNJBCCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2836BB0", Offset = "0x2835FB0", VA = "0x182836BB0")]
	public static IEnumerable<T> MHGGCAJOMJO<T, TKey>(this IEnumerable<T> GPBFFBAAOEG, Func<T, TKey> ICNOFHENGHL) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x16C0BF0", Offset = "0x16BFFF0", VA = "0x1816C0BF0")]
	[IteratorStateMachine(typeof(KCHGKOFHPFH))]
	public static IEnumerable<T> NKODALHPHLF<T, U>(this IEnumerable<T> INHKNJBCCPD, IEnumerable<U> MPHACEGLFIL, [Optional][KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")] T IBMOPJIJEMD) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xD58B40", Offset = "0xD57F40", VA = "0x180D58B40")]
	public static T DLJJKEJPEHB<T>(this IEnumerable<T> KCGHNGOMAMI, T LGCPJJBBDLH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2834640", Offset = "0x2833A40", VA = "0x182834640")]
	public static T DLJJKEJPEHB<T>(this IEnumerable<T> KCGHNGOMAMI, T LGCPJJBBDLH, Func<T, bool> NJIFCLNECCM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x234F430", Offset = "0x234E830", VA = "0x18234F430")]
	[IteratorStateMachine(typeof(CJBLONOHAAJ))]
	public static IEnumerable<(T, global::DBEIBEIIMCM<T>)> JMIAMELMGNH<T>(this IEnumerable<T> INHKNJBCCPD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2836AC0", Offset = "0x2835EC0", VA = "0x182836AC0")]
	public static bool MGIKBOHDKDK<T>(this IEnumerable<T> INHKNJBCCPD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1DC5010", Offset = "0x1DC4410", VA = "0x181DC5010")]
	public static IEnumerable<global::PDFKBNNABNH<T>> CMHFEELAEBD<T>(this IEnumerable<T> INHKNJBCCPD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2835530", Offset = "0x2834930", VA = "0x182835530")]
	public static bool JEJILLMBCFE<T>(this IEnumerable<T> INHKNJBCCPD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2834FD0", Offset = "0x28343D0", VA = "0x182834FD0")]
	public static IEnumerable<T> HJPPMPLPEJM<T>(this IEnumerable<T> INHKNJBCCPD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x16C0AB0", Offset = "0x16BFEB0", VA = "0x1816C0AB0")]
	[IteratorStateMachine(typeof(NJCEHHNAPJH))]
	public static IEnumerable<U> NJFAIINJKHE<U, T>(this IEnumerable<T> INHKNJBCCPD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C4E60", Offset = "0x6C4260")] Func<FJNFFAGNCLH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> OBENNOJJNMC) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2836D90", Offset = "0x2836190", VA = "0x182836D90")]
	public static int MKHKALFDJIP<T>(this IEnumerable<T> INHKNJBCCPD, int CLKLENFCACN = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2839120", Offset = "0x2838520", VA = "0x182839120")]
	public static bool NGHGCFOEIDH<T>(this IEnumerable<T> INHKNJBCCPD, IEnumerable<T> MPHACEGLFIL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2836830", Offset = "0x2835C30", VA = "0x182836830")]
	public static (IEnumerable<T>, IEnumerable<T>) LDKICAFAINC<T>(this IEnumerable<T> INHKNJBCCPD, Func<T, bool> MJECMHDGGLC) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2834280", Offset = "0x2833680", VA = "0x182834280")]
	public static string DLINHJCFOIH<T>(this IEnumerable<T> INHKNJBCCPD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2834AD0", Offset = "0x2833ED0", VA = "0x182834AD0")]
	public static Dictionary<TKey?, TValue?>? FJPGFILAKHC<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C4F50", Offset = "0x6C4350")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? KCGHNGOMAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2834AD0", Offset = "0x2833ED0", VA = "0x182834AD0")]
	public static Dictionary<TKey?, TValue?>? FJPGFILAKHC<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C4FB0", Offset = "0x6C43B0")] this IEnumerable<(TKey? Key, TValue? Value)>? KCGHNGOMAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x167FD30", Offset = "0x167F130", VA = "0x18167FD30")]
	public static HashSet<T> KEGPNNGGCPI<T>(this IEnumerable<T> INHKNJBCCPD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2837960", Offset = "0x2836D60", VA = "0x182837960")]
	public static string MKKKKABMBIG<T>(this IEnumerable<T> INHKNJBCCPD, string IDOBLHIFFGM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x16C0A10", Offset = "0x16BFE10", VA = "0x1816C0A10")]
	[IteratorStateMachine(typeof(JGNNGMENBIE))]
	public static IEnumerable<(T, U)> EEJIMLGNFOI<T, U>(this IEnumerable<T> GBEJHLEFDJM, IEnumerable<U> BDGBOHJLNIE) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x28352B0", Offset = "0x28346B0", VA = "0x1828352B0")]
	public static IEnumerable<V> IEFEBFLCABI<V, T, U>(this IEnumerable<T> INHKNJBCCPD, IEnumerable<U> MPHACEGLFIL, Func<T, U, V> PJJPCKCLNCM, [Optional][KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")] T DPIKBNLJKMH, [Optional][KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")] U ILJHLNMNLDB) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2835340", Offset = "0x2834740", VA = "0x182835340")]
	public static IEnumerable<(T, U)> IEFEBFLCABI<T, U>(this IEnumerable<T> INHKNJBCCPD, IEnumerable<U> MPHACEGLFIL, [Optional][KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")] T DPIKBNLJKMH, [Optional][KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")] U ILJHLNMNLDB) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class OONOGPOPMIM
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x25BEE30", Offset = "0x25BE230", VA = "0x1825BEE30")]
	public static bool PEDOMNPOPLE<T, U>(this T INHKNJBCCPD, in U NBNOMDAKOCG) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x25BED90", Offset = "0x25BE190", VA = "0x1825BED90")]
	public static bool ELLCKJGHHAJ<T>(ref T INHKNJBCCPD, T MPHACEGLFIL) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class BKOMNHFBMAG
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2BC6CB0", Offset = "0x2BC60B0", VA = "0x182BC6CB0")]
	public static bool LDJEHJMDLGN(this in float3 HFOFADIOHHP, float3 GFCGIJPPCBN, float IHBAJBLJLEK = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class PBDNJCPFOAJ
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x25C1E10", Offset = "0x25C1210", VA = "0x1825C1E10")]
	public static void PKAFAOMJAMJ<T>(this T FOHPMIEDDCH, Action<T> CCNCACCKBFP) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x25C1B90", Offset = "0x25C0F90", VA = "0x1825C1B90")]
	public static V KNCJLIANCOO<V, T>(this T FOHPMIEDDCH, Func<T, V> CCNCACCKBFP, [Optional][KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")] V LGCPJJBBDLH) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x25C1C90", Offset = "0x25C1090", VA = "0x1825C1C90")]
	public static T? LCGBOKJEIMK<T>(this T INHKNJBCCPD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x234EF80", Offset = "0x234E380", VA = "0x18234EF80")]
	[IteratorStateMachine(typeof(HALPCFAMKFM))]
	public static IEnumerable<T> PGOMFELOHEH<T>(this T INHKNJBCCPD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x25C1AB0", Offset = "0x25C0EB0", VA = "0x1825C1AB0")]
	public static T[] BBBODFBNHEM<T>(this T INHKNJBCCPD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class FMJLMOBGBMM
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A03420", Offset = "0x6A02820", VA = "0x186A03420")]
	private static byte[] APMBHCGDMJF(int OLAOPLEEFDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A03B20", Offset = "0x6A02F20", VA = "0x186A03B20")]
	private static byte[] INBGBNINIEB(long FJCDCEEJJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A034A0", Offset = "0x6A028A0", VA = "0x186A034A0")]
	private static byte[] EHBGIDMOJGD(ulong FJCDCEEJJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A03C80", Offset = "0x6A03080", VA = "0x186A03C80")]
	public static Guid KNACJPGANJJ(params Guid[] DDGPENMMFGN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A03660", Offset = "0x6A02A60", VA = "0x186A03660")]
	public static Guid IDIKGABNBEI(in Guid FDFEDECJLKO, int EGNHJGKABLC, int NHBDMCDLELK = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A035A0", Offset = "0x6A029A0", VA = "0x186A035A0")]
	public static Guid IDIKGABNBEI(in Guid FDFEDECJLKO, long EGNHJGKABLC, int NHBDMCDLELK = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A03720", Offset = "0x6A02B20", VA = "0x186A03720")]
	public static Guid IDIKGABNBEI(in Guid FDFEDECJLKO, ulong EGNHJGKABLC, int NHBDMCDLELK = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A03AB0", Offset = "0x6A02EB0", VA = "0x186A03AB0")]
	public static Guid IDIKGABNBEI(in Guid FDFEDECJLKO, in Guid KLMKHNGIGFC, int NHBDMCDLELK = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A037E0", Offset = "0x6A02BE0", VA = "0x186A037E0")]
	private static Guid IDIKGABNBEI(in Guid FDFEDECJLKO, byte[] FCKGDJIOOGM, int NHBDMCDLELK = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A03BA0", Offset = "0x6A02FA0", VA = "0x186A03BA0")]
	private static void JBFDLLLPEFO(byte[] NPIFLODGAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A03520", Offset = "0x6A02920", VA = "0x186A03520")]
	private static void FALFJBIFFPH(byte[] NPIFLODGAHD, int LJLKLAFAGNO, int HFBAHIGFPIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface MEALAIOGPPP
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JGDAIPFHKNM ONFHCEEPMHH();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface JGDAIPFHKNM : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool FOBJJPHHEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPKBPOGOIOI();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface MPHCLCOLDPN
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BPAJEMADNLI(int ANEGFEDKDLK, int GAPBDDAJNDG);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float HOOKAICFODF(float MGEHMJGFDIN, float AAMOGHEGGPN);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BAECBGKPKDA
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	long GHBLFPODMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class NKINBBANPGC
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A046C0", Offset = "0x6A03AC0", VA = "0x186A046C0")]
	public static int MDADOGEJCJI(this int INHKNJBCCPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A04680", Offset = "0x6A03A80", VA = "0x186A04680")]
	public static int HJNAGMGJCAM(this int INHKNJBCCPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A04620", Offset = "0x6A03A20", VA = "0x186A04620")]
	public static int CDPDPDCFGDN(this int INHKNJBCCPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A04670", Offset = "0x6A03A70", VA = "0x186A04670")]
	public static int DNJFDCOGJBI(this int INHKNJBCCPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xCCDFB0", Offset = "0xCCD3B0", VA = "0x180CCDFB0")]
	public static int NMLGNFENIIP(this int INHKNJBCCPD, int EJMNNLNLAFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0xA9C440", Offset = "0xA9B840", VA = "0x180A9C440")]
	public static int LFHNNNGCJPD(this int INHKNJBCCPD, int EJMNNLNLAFJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class FNPIEOFFLDC
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x261FF70", Offset = "0x261F370", VA = "0x18261FF70")]
	public static void LOCCMPKKMAH<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C5930", Offset = "0x6C4D30")] this in KeyValuePair<TKey, TValue> INHKNJBCCPD, out TKey OGFDNCPKECB, out TValue LPJDDLMPNCG) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2620100", Offset = "0x261F500", VA = "0x182620100")]
	public static (TKey?, TValue?) OLCBEMCLJCL<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C59A0", Offset = "0x6C4DA0")] this in KeyValuePair<TKey?, TValue?> INHKNJBCCPD)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x261FEE0", Offset = "0x261F2E0", VA = "0x18261FEE0")]
	public static KeyValuePair<TKey?, UValue?> KBJBILDHAFB<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C5A10", Offset = "0x6C4E10")] this KeyValuePair<TKey?, TValue?> INHKNJBCCPD, UValue LPJDDLMPNCG)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class HINNAJLFLOA
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class IFJCIIPKBKJ<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public IFJCIIPKBKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x162DA70", Offset = "0x162CE70", VA = "0x18162DA70")]
		internal TElement <BinarySearch>b__0(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class HCLJAJGNIGI<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Random rng;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		public HCLJAJGNIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x895AF0", Offset = "0x894EF0", VA = "0x180895AF0")]
		internal int <Random>b__0(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x29FCC40", Offset = "0x29FC040", VA = "0x1829FCC40")]
	public static int EDKMNFPOIHF<T>(this IReadOnlyList<T> BGAKDGCGOMH, T LPJDDLMPNCG) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x29FEAE0", Offset = "0x29FDEE0", VA = "0x1829FEAE0")]
	public static int HPCINGGKMOM<T>(this IReadOnlyList<T> BGAKDGCGOMH, T LPJDDLMPNCG) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x29FEE50", Offset = "0x29FE250", VA = "0x1829FEE50")]
	public static void JHAKILBFFKF<T>(this HashSet<T> PFBNMCNAHJB, IEnumerable<T> FAOHJBCBHLI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A000A0", Offset = "0x29FF4A0", VA = "0x182A000A0")]
	public static void MOJDPHDHIDA<T>(this IList<T> BDHPAGCMKHB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A00120", Offset = "0x29FF520", VA = "0x182A00120")]
	public static void MOJDPHDHIDA<T>(this IList<T> BDHPAGCMKHB, int EGKADOFOBMO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x29FDD50", Offset = "0x29FD150", VA = "0x1829FDD50")]
	public static List<T> FKLJICKBHEF<T>(this List<T> BDDEAAJFJHC, Predicate<T> PBPBFOEECGL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x29FD4D0", Offset = "0x29FC8D0", VA = "0x1829FD4D0")]
	public static int EDKMNFPOIHF<T>(this IReadOnlyList<T> BDHPAGCMKHB, Predicate<T> NJIFCLNECCM) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x29FD730", Offset = "0x29FCB30", VA = "0x1829FD730")]
	public static bool EJLMEALKPJD<T>(this IReadOnlyList<T> BDHPAGCMKHB, Predicate<T> NJIFCLNECCM, [MNKKOBAPPBG(true)] out List<int>? JDFBPHJNCCJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x29FE7F0", Offset = "0x29FDBF0", VA = "0x1829FE7F0")]
	public static bool GMBMHDKFMPB<T>(this IReadOnlyList<T> BDHPAGCMKHB, T JPOBIIKLHON) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x29FE6B0", Offset = "0x29FDAB0", VA = "0x1829FE6B0")]
	public static bool GMBMHDKFMPB<T>(this IReadOnlyList<T> BDHPAGCMKHB, T JPOBIIKLHON, EqualityComparer<T> GIMMCBBNPCI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2A03170", Offset = "0x2A02570", VA = "0x182A03170")]
	public static int PPJKNEGGAPL<TElement, TKey>(this IList<TElement> JJMPKANKMHO, TKey BGJHLFDNKIH, Func<TElement, TKey> MDBEBDLNLEM, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C5AB0", Offset = "0x6C4EB0")] Func<TKey, TKey, int> HBFCEANPGHH, int EGNHJGKABLC = 0, [Optional] int? EJMNNLNLAFJ) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2A02B90", Offset = "0x2A01F90", VA = "0x182A02B90")]
	public static int PPJKNEGGAPL<TElement, TKey>(Func<int, TElement> CAMFHFCBMJH, int LNLLCOHNIKJ, TKey BGJHLFDNKIH, Func<TElement, TKey> MDBEBDLNLEM, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C5B10", Offset = "0x6C4F10")] Func<TKey, TKey, int> HBFCEANPGHH, int EGNHJGKABLC = 0, [Optional] int? EJMNNLNLAFJ) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x29FC830", Offset = "0x29FBC30", VA = "0x1829FC830")]
	public static List<T> CMJDFMHPHIM<T>(this IReadOnlyList<T> BDHPAGCMKHB, int EJMNNLNLAFJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x29FFB30", Offset = "0x29FEF30", VA = "0x1829FFB30")]
	public static bool KFNINGPAMDH<T>(this List<T> BDHPAGCMKHB, T JPOBIIKLHON) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x29FFEE0", Offset = "0x29FF2E0", VA = "0x1829FFEE0")]
	public static void MLNLGLMACFP<T>(this List<T> BDHPAGCMKHB, IEnumerable<T> BDDEAAJFJHC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x29FDBB0", Offset = "0x29FCFB0", VA = "0x1829FDBB0")]
	public static void FJEBMLODAAK<T>(this List<T> BDHPAGCMKHB, IEnumerable<T> BDDEAAJFJHC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x29FFC40", Offset = "0x29FF040", VA = "0x1829FFC40")]
	public static T LEGOABCGJME<T>(this List<T> BDDEAAJFJHC, Predicate<T> PBPBFOEECGL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x29FC7C0", Offset = "0x29FBBC0", VA = "0x1829FC7C0")]
	public static T BNJCMLANCKO<T>(this List<T> BDDEAAJFJHC, int EGNHJGKABLC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x29FCA90", Offset = "0x29FBE90", VA = "0x1829FCA90")]
	public static bool DLAMJLPFKMN<T>(this List<T> FLKOGPABCGJ, List<T> MGFELCHHLDH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2A02750", Offset = "0x2A01B50", VA = "0x182A02750")]
	public static T OBIMAAELFFL<T>(this IList<T> BDHPAGCMKHB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x29FEA20", Offset = "0x29FDE20", VA = "0x1829FEA20")]
	public static bool HNHELEOPLEK<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C5B70", Offset = "0x6C4F70")] IReadOnlyList<T> BDHPAGCMKHB, int EGNHJGKABLC, [EBIDJBJAIJA(false)][KCDCAGLMLEB("This should be `T?` in C# 9.")] out T JGINNNKFHFP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A01920", Offset = "0x2A00D20", VA = "0x182A01920")]
	public static bool NINKMCNOKPF<T>(IReadOnlyList<T> BDHPAGCMKHB, ICollection BDDEAAJFJHC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x29FCB20", Offset = "0x29FBF20", VA = "0x1829FCB20")]
	public static void EBMCECAIEJG<T>(IReadOnlyList<T> BDHPAGCMKHB, ref ICollection BDDEAAJFJHC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x22B89A0", Offset = "0x22B7DA0", VA = "0x1822B89A0")]
	public static bool BCMJLANMBBM<T>(this IReadOnlyList<T> BDHPAGCMKHB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x29FE840", Offset = "0x29FDC40", VA = "0x1829FE840")]
	public static string HFIMEIFIMCA<T>(this IEnumerable<T> BDHPAGCMKHB, string NDBKBBHINAE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2A02950", Offset = "0x2A01D50", VA = "0x182A02950")]
	public static T PPGKPKPAMKJ<T>(this IList<T> INHKNJBCCPD) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x29FFCA0", Offset = "0x29FF0A0", VA = "0x1829FFCA0")]
	public static T MLIDGCCMAPN<T>(this IList<T> INHKNJBCCPD) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A027F0", Offset = "0x2A01BF0", VA = "0x182A027F0")]
	public static void PKCNIFMKFFN<T>(this IList<T> INHKNJBCCPD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x29FECA0", Offset = "0x29FE0A0", VA = "0x1829FECA0")]
	public static void IPOMJILOPME<T>(this IList<T> INHKNJBCCPD, in T LPJDDLMPNCG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x29FF980", Offset = "0x29FED80", VA = "0x1829FF980")]
	public static T JLEFMAHHEFN<T>(this IList<T> INHKNJBCCPD) where T : notnull
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class FEGKDLIBLCO
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static float JEGAJEEMCCD;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static float GEIJEDFMNDC;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static bool HEEKBAHFIGG;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly float NCIOMAJHCAI;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6A030A0", Offset = "0x6A024A0", VA = "0x186A030A0")]
	public static bool BGBFLDJBLIE(float HFOFADIOHHP, float GFCGIJPPCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x49C7510", Offset = "0x49C6910", VA = "0x1849C7510")]
	public static float IIOBFPPCPID(float LPJDDLMPNCG, float ONLKOJHBEOC, float JKHCMKCHKPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x49C7530", Offset = "0x49C6930", VA = "0x1849C7530")]
	public static int IIOBFPPCPID(int LPJDDLMPNCG, int ONLKOJHBEOC, int JKHCMKCHKPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x49C74F0", Offset = "0x49C68F0", VA = "0x1849C74F0")]
	public static float DCMIOBAADAK(float LPJDDLMPNCG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6A031A0", Offset = "0x6A025A0", VA = "0x186A031A0")]
	public static float EHGCAMIANOD(float HFOFADIOHHP, float GFCGIJPPCBN, float FOHPMIEDDCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x38A1680", Offset = "0x38A0A80", VA = "0x1838A1680")]
	public static float HMBNCEOACLK(float HFOFADIOHHP, float GFCGIJPPCBN, float FOHPMIEDDCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6A03240", Offset = "0x6A02640", VA = "0x186A03240")]
	public static float KAICFHPFPOD(float HFOFADIOHHP, float GFCGIJPPCBN, float LPJDDLMPNCG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6A03300", Offset = "0x6A02700", VA = "0x186A03300")]
	public static float KKGMEOFLACD(float HFOFADIOHHP, float GFCGIJPPCBN, float LPJDDLMPNCG)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class PBEBLDMDIOC
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x25C1E50", Offset = "0x25C1250", VA = "0x1825C1E50")]
	[JMOGFODMLAN("This should be replaced with the `is not` operator in C# 9.")]
	public static bool GPFKIMEJFAE<T>(this object INHKNJBCCPD, [MNKKOBAPPBG(true)] out T JGINNNKFHFP) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class EKEGIDMCIHO
{
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6A02C20", Offset = "0x6A02020", VA = "0x186A02C20")]
	public static bool LDJEHJMDLGN(this quaternion GBEJHLEFDJM, quaternion BDGBOHJLNIE, float IKHGPLNDMOI = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class HLKKHKAMEPH
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class NKGCIMIHHAC : MPHCLCOLDPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly Random MLBFLJKKBDE;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A044D0", Offset = "0x6A038D0", VA = "0x186A044D0", Slot = "4")]
		public int BPAJEMADNLI(int MGEHMJGFDIN, int MDDMMGCHGAF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6A04500", Offset = "0x6A03900", VA = "0x186A04500", Slot = "5")]
		public float HOOKAICFODF(float MGEHMJGFDIN, float AAMOGHEGGPN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6A04570", Offset = "0x6A03970", VA = "0x186A04570")]
		private double KJJPALAOIGP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A045B0", Offset = "0x6A039B0", VA = "0x186A045B0")]
		public NKGCIMIHHAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly MPHCLCOLDPN CMJDFMHPHIM;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6A03DF0", Offset = "0x6A031F0", VA = "0x186A03DF0")]
	public static ulong OHOFLJHBPCB()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class JMNNAKHDKEH
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x210F840", Offset = "0x210EC40", VA = "0x18210F840")]
	public static bool AEDMBEEAEKH<T>(this IReadOnlyCollection<T> INHKNJBCCPD, int EGNHJGKABLC) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class AMGNCCDGGHC
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2434CD0", Offset = "0x24340D0", VA = "0x182434CD0")]
	public static bool DJKANKJNGBD<T>(this IReadOnlyList<T> INHKNJBCCPD, int EGNHJGKABLC, [MNKKOBAPPBG(true)][KCDCAGLMLEB("This should be `T?` in C# 9.")] out T JGINNNKFHFP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2434D60", Offset = "0x2434160", VA = "0x182434D60")]
	public static bool EDLJEFMBNEB<T>(this IReadOnlyList<T> INHKNJBCCPD, int EGNHJGKABLC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C5CD0", Offset = "0x6C50D0")] out global::PDFKBNNABNH<T> JGINNNKFHFP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2434E20", Offset = "0x2434220", VA = "0x182434E20")]
	public static T NIILOMKNHCI<T>(this IReadOnlyList<T> INHKNJBCCPD, int EGNHJGKABLC, in T JKMJDJJMAJK) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1F048E0", Offset = "0x1F03CE0", VA = "0x181F048E0")]
	[KCDCAGLMLEB("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T DBIABGHOLPJ<T>(this IReadOnlyList<T> INHKNJBCCPD, int EGNHJGKABLC) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2434B90", Offset = "0x2433F90", VA = "0x182434B90")]
	public static T? AHOAFHFCFID<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C5D80", Offset = "0x6C5180")] this IReadOnlyList<T> INHKNJBCCPD, int EGNHJGKABLC) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class ALOFIPFLKAL
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2433C40", Offset = "0x2433040", VA = "0x182433C40")]
	public static T MKLBNKEKMJE<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C5DE0", Offset = "0x6C51E0")] this in ReadOnlyMemory<T> INHKNJBCCPD, int EGNHJGKABLC) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2433940", Offset = "0x2432D40", VA = "0x182433940")]
	public static bool EDMDBKBAELO<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C5E50", Offset = "0x6C5250")] this in ReadOnlyMemory<T> INHKNJBCCPD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C5EC0", Offset = "0x6C52C0")] in ReadOnlyMemory<T> MPHACEGLFIL) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2433A60", Offset = "0x2432E60", VA = "0x182433A60")]
	public static int MKHKALFDJIP<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C5F30", Offset = "0x6C5330")] this in ReadOnlyMemory<T?> INHKNJBCCPD, int CLKLENFCACN = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x24338A0", Offset = "0x2432CA0", VA = "0x1824338A0")]
	public static string DLINHJCFOIH<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C5FA0", Offset = "0x6C53A0")] this in ReadOnlyMemory<T> INHKNJBCCPD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class DOBHMIFBKOP
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x168F7C0", Offset = "0x168EBC0", VA = "0x18168F7C0")]
	public static bool EDMDBKBAELO<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C6010", Offset = "0x6C5410")] this in ReadOnlySpan<T?> INHKNJBCCPD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C6080", Offset = "0x6C5480")] in ReadOnlySpan<T?> MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x168F940", Offset = "0x168ED40", VA = "0x18168F940")]
	public static int MKHKALFDJIP<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C60F0", Offset = "0x6C54F0")] this in ReadOnlySpan<T?> INHKNJBCCPD, int CLKLENFCACN = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x168F660", Offset = "0x168EA60", VA = "0x18168F660")]
	public static string DLINHJCFOIH<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C6160", Offset = "0x6C5560")] this in ReadOnlySpan<T> INHKNJBCCPD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x168FA60", Offset = "0x168EE60", VA = "0x18168FA60")]
	public static string MKKKKABMBIG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6C61D0", Offset = "0x6C55D0")] this in ReadOnlySpan<T> INHKNJBCCPD, string IDOBLHIFFGM) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class OALENECOCIG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static BAECBGKPKDA NAECACNCCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6A047C0", Offset = "0x6A03BC0", VA = "0x186A047C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6A04820", Offset = "0x6A03C20", VA = "0x186A04820")]
	public static double PGDHKMKNGGB(this BAECBGKPKDA INHKNJBCCPD, long IHLFIIPPMCG)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class JEPLCALKAOJ : BAECBGKPKDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Stopwatch BPAPHPDMOFM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long GHBLFPODMCL
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6A04450", Offset = "0x6A03850", VA = "0x186A04450", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x756370", Offset = "0x755770", VA = "0x180756370")]
	private JEPLCALKAOJ(Stopwatch DDCPMELELDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6A04470", Offset = "0x6A03870", VA = "0x186A04470")]
	public static JEPLCALKAOJ KIFIGIGBPBI(Stopwatch DDCPMELELDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6A043B0", Offset = "0x6A037B0", VA = "0x186A043B0")]
	public static JEPLCALKAOJ ALCCKEKGABM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class IHANBINLKFN
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6A04350", Offset = "0x6A03750", VA = "0x186A04350")]
	public static RigidTransform GKEKBBKBJID(this in RigidTransform INHKNJBCCPD)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class DGOLFMLLGFG
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6A02B60", Offset = "0x6A01F60", VA = "0x186A02B60")]
	public static RigidTransform DCBHMBLECHG(RigidTransform DALHGEHGNOJ, RigidTransform KNHBHBPFHPH)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class IFKLDONNLEE
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xB20450", Offset = "0xB1F850", VA = "0x180B20450")]
	public static bool BCMJLANMBBM(this string NKKEIKGKIDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HCMIAPGAJIL<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct JPEDILAFGBK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF0F0", Offset = "0x2CDE4F0", VA = "0x182CDF0F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static int HNNDEGLLLNC;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static ICJCGCFMJPD GAEEOEKGFHC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static long GHBLFPODMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x32E15D0", Offset = "0x32E09D0", VA = "0x1832E15D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x32E1570", Offset = "0x32E0970", VA = "0x1832E1570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x32E13D0", Offset = "0x32E07D0", VA = "0x1832E13D0")]
	public static JPEDILAFGBK DIGPJAIHDLF()
	{
		return default(JPEDILAFGBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x32E1690", Offset = "0x32E0A90", VA = "0x1832E1690")]
	private static void LJMPMFMCLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x32E1620", Offset = "0x32E0A20", VA = "0x1832E1620")]
	public static void JAIKDMLJCNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct ICJCGCFMJPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly BAECBGKPKDA BPAPHPDMOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly long KFEDIOAIJGD;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6A042E0", Offset = "0x6A036E0", VA = "0x186A042E0")]
	public ICJCGCFMJPD(BAECBGKPKDA DDCPMELELDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6A04130", Offset = "0x6A03530", VA = "0x186A04130")]
	public long BNOCAOMAPLE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6A04250", Offset = "0x6A03650", VA = "0x186A04250")]
	public double PGDHKMKNGGB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6A041C0", Offset = "0x6A035C0", VA = "0x186A041C0")]
	public double GPLAFBMEHCM()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class BLIADJPADIP
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x98E870", Offset = "0x98DC70", VA = "0x18098E870")]
	public static bool DPGFIAJAMBC(this Type INHKNJBCCPD, Type MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1A86EE0", Offset = "0x1A862E0", VA = "0x181A86EE0")]
	public static bool DPGFIAJAMBC<T>(this Type INHKNJBCCPD) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class MHOBENAILAM
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xCCDFB0", Offset = "0xCCD3B0", VA = "0x180CCDFB0")]
	public static uint NMLGNFENIIP(this uint INHKNJBCCPD, int EJMNNLNLAFJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0xA9C440", Offset = "0xA9B840", VA = "0x180A9C440")]
	public static uint LFHNNNGCJPD(this uint INHKNJBCCPD, int EJMNNLNLAFJ)
	{
		return default(uint);
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
