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
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69D5AF0", Offset = "0x69D44F0", VA = "0x1869D5AF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72C090", Offset = "0x72AA90", VA = "0x18072C090")]
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
		[Cpp2IlInjected.Address(RVA = "0xA36880", Offset = "0xA35280", VA = "0x180A36880")]
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
			[Cpp2IlInjected.Address(RVA = "0x3335290", Offset = "0x3333C90", VA = "0x183335290")]
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
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B6F40", Offset = "0x6B6340")]
		private readonly KIDKBKHIBNO<T>.JLKDJBCDGPI[] PKAHDKMMFHN;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x38EA620", Offset = "0x38E9020", VA = "0x1838EA620")]
		public KIDKBKHIBNO(T[] LDELAPKFGPI, OHLDABOGKGA<T> HBFCEANPGHH, int MAFGOCJJFGL, Func<bool> OKKHECDFMPG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B6FA0", Offset = "0x6B63A0")] T[] HMBGKABADKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x38E9F30", Offset = "0x38E8930", VA = "0x1838E9F30")]
		public bool PONEJJPCJLM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate U MADFLBMIKIG<T, U>(int HJBHDFOHMCA, int JPMCFANFABH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7000", Offset = "0x6B6400")] in ReadOnlySpan<T> BNPCEOGNFLN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1D76840", Offset = "0x1D75240", VA = "0x181D76840")]
	public static ReadOnlyMemory<T> JLCMGPOMDJH<T>(this T[] INHKNJBCCPD) where T : notnull
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1D86820", Offset = "0x1D85220", VA = "0x181D86820")]
	public static T[] KNILLDMJPHP<T>(int GBNBGNMHGLO, T IBMOPJIJEMD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1D86670", Offset = "0x1D85070", VA = "0x181D86670")]
	public static void KAMCFJJLABH<T>(this T[] JHPNADEIALO, T IBMOPJIJEMD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x21D1FA0", Offset = "0x21D09A0", VA = "0x1821D1FA0")]
	public static void PGNANJCBEHJ<T>(this T[] BGAKDGCGOMH, int FMPGMDDDGFN, int MCPCFIDHHAB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1D85660", Offset = "0x1D84060", VA = "0x181D85660")]
	private static void DJEPJDJLGEO<T>(this T[] INHKNJBCCPD, int ENDLOGFLDFL, int FNBGFHPGMAI, T[] MPHACEGLFIL, int PHPMPLMIDAC, int KIFIBAFFLPA, T[] JGINNNKFHFP, int FAACICLGBBE, OHLDABOGKGA<T> HBFCEANPGHH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x21D1AA0", Offset = "0x21D04A0", VA = "0x1821D1AA0")]
	public static void MLKKPKMGKHP<T>(this T[] INHKNJBCCPD, int OKIEINKEHAF, int EJMNNLNLAFJ, OHLDABOGKGA<T> HBFCEANPGHH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1D85510", Offset = "0x1D83F10", VA = "0x181D85510")]
	public static KIDKBKHIBNO<T> AFAIGLMNCNG<T>(this T[] INHKNJBCCPD, OHLDABOGKGA<T> HBFCEANPGHH, int MAFGOCJJFGL, Func<bool> OKKHECDFMPG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B6E90", Offset = "0x6B6290")] T[] HMBGKABADKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D86800", Offset = "0x1D85200", VA = "0x181D86800")]
	public static T[] KJCPAGPFOFN<T>(this T[] BGAKDGCGOMH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D85A60", Offset = "0x1D84460", VA = "0x181D85A60")]
	public static T[] HELHJBEBKDM<T>(this T[] OABOCAEGGHE, T NOPLAHHAMFP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1D85B40", Offset = "0x1D84540", VA = "0x181D85B40")]
	public static T[] ILPDDANBFBE<T>(this T[] OABOCAEGGHE, int EGNHJGKABLC, T NOPLAHHAMFP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1D855B0", Offset = "0x1D83FB0", VA = "0x181D855B0")]
	public static T[] AFFKPBCHGOC<T>(this T[] OABOCAEGGHE, int EGNHJGKABLC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1D869A0", Offset = "0x1D853A0", VA = "0x181D869A0")]
	public static T[] MLKFOGGAKKG<T>(this T[] OABOCAEGGHE, int EGNHJGKABLC, T NOPLAHHAMFP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D86130", Offset = "0x1D84B30", VA = "0x181D86130")]
	public static U[] JGNEFFBNOEN<U, T>(this T[] AABKFFENABM, int ENEFEHGMHEA, MADFLBMIKIG<T, U> BKCMJFFACLE) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69D4050", Offset = "0x69D2A50", VA = "0x1869D4050")]
	public static byte[] CJNKLEGIGAI(this byte[] INHKNJBCCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69D4260", Offset = "0x69D2C60", VA = "0x1869D4260")]
	public static byte[] EAMBMHOBBED(this byte[] INHKNJBCCPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JCFEFALPFID
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1992D90", Offset = "0x1991790", VA = "0x181992D90")]
	public static void JHAKILBFFKF<T>(this ICollection<T> INHKNJBCCPD, IEnumerable<T> FAOHJBCBHLI) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class MAHMDJCPNBN
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x366D630", Offset = "0x366C030", VA = "0x18366D630")]
	public static void AMHNDEKHJDI<K, V>(this IDictionary<K, V> INHKNJBCCPD, in K OGFDNCPKECB, in V LPJDDLMPNCG, Func<V, V, V> DFEMEJDMPOL) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x366F870", Offset = "0x366E270", VA = "0x18366F870")]
	public static void KLHDAMICEBE<K, V>(this IDictionary<K, List<V>> INHKNJBCCPD, in K OGFDNCPKECB, in V LPJDDLMPNCG) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x366EA80", Offset = "0x366D480", VA = "0x18366EA80")]
	public static TVal DFDIJCKOMFL<TVal, TKey>(this IDictionary<TKey, TVal> GDCEFHMGFFB, in TKey OGFDNCPKECB, [Optional][KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")] TVal LGCPJJBBDLH) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x366ED20", Offset = "0x366D720", VA = "0x18366ED20")]
	public static TVal DFDIJCKOMFL<TVal, TKey>(this IDictionary<TKey, TVal> GDCEFHMGFFB, in TKey OGFDNCPKECB, Func<TVal> GOAPJJPFDCE) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x366F400", Offset = "0x366DE00", VA = "0x18366F400")]
	public static TValue GPBLBJFIHJH<TValue, TKey>(this IDictionary<TKey, TValue> GDCEFHMGFFB, in TKey OGFDNCPKECB, [Optional][KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")] in TValue LGCPJJBBDLH) where TValue : notnull where TKey : notnull
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x366DD00", Offset = "0x366C700", VA = "0x18366DD00")]
	public static V CDLAMHJFIGI<V, K>(this IDictionary<K, V> INHKNJBCCPD, in K OGFDNCPKECB) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x366F5F0", Offset = "0x366DFF0", VA = "0x18366F5F0")]
	public static T2[] JPMGPEBODFD<T2, T1>(this Dictionary<T1, T2>.ValueCollection GPPFGKKLFIH) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x366FE00", Offset = "0x366E800", VA = "0x18366FE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x38C7580", Offset = "0x38C5F80", VA = "0x1838C7580")]
		[KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) ILLAOPDHOAJ(T CKEIHEONEMF)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x38C75F0", Offset = "0x38C5FF0", VA = "0x1838C75F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public IDKAAOPPPBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x234B750", Offset = "0x234A150", VA = "0x18234B750")]
		internal bool <SetEqual>b__0(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x30019F0", Offset = "0x30003F0", VA = "0x1830019F0")]
		internal bool <SetEqual>b__1(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2B68030", Offset = "0x2B66A30", VA = "0x182B68030")]
	public static bool KIONFMFHIDL<T, TArgs>(this IEnumerable<T> INHKNJBCCPD, in TArgs FKFCAPAEHKO, LKDFMKFJFAM<TArgs, T> NJIFCLNECCM) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2B66BC0", Offset = "0x2B655C0", VA = "0x182B66BC0")]
	public static U HCFKDANHEEM<U, T>(this IEnumerable<T> INHKNJBCCPD, Func<U> KAPBAKFKAFD, Func<T, U> CKEIHEONEMF, Func<IEnumerable<T>, U> PHOOODJMCIC) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2B675A0", Offset = "0x2B65FA0", VA = "0x182B675A0")]
	public static bool JNMNAOKGLFK<T, TArgs>(this IEnumerable<T> INHKNJBCCPD, in TArgs FKFCAPAEHKO, LKDFMKFJFAM<TArgs, T> NJIFCLNECCM) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2B68250", Offset = "0x2B66C50", VA = "0x182B68250")]
	public static U LBJIPPMFNFH<U, T, TArg>(this IEnumerable<T> INHKNJBCCPD, in TArg HACNEHKIBDN, OMDNLFKPNPJ<TArg, U> KAPBAKFKAFD, HBNBDJEIEEJ<TArg, T, U> CKEIHEONEMF, KAFIFBEDONL<TArg, T, U> PHOOODJMCIC) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2B66430", Offset = "0x2B64E30", VA = "0x182B66430")]
	public static IEnumerable<U> DNCALBCEPLB<U, T, TArg>(this IEnumerable<T> INHKNJBCCPD, in TArg HACNEHKIBDN, OPAFEAKIGCM<TArg, T, U> DHBGDFEBNKM) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1992BD0", Offset = "0x19915D0", VA = "0x181992BD0")]
	public static IEnumerable<T> LHINBLHJBEI<T>(params IEnumerable<T>[] ANGLIBAGFCA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B130", Offset = "0x2B69B30", VA = "0x182B6B130")]
	public static bool PBADBLNGNDF<T>(this IEnumerable<T> KCGHNGOMAMI, IEnumerable<T> MPHACEGLFIL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1992BD0", Offset = "0x19915D0", VA = "0x181992BD0")]
	public static IEnumerable<(TKey?, TValue?)>? BFADGAFGFNP<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7210", Offset = "0x6B6610")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? INHKNJBCCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2B68950", Offset = "0x2B67350", VA = "0x182B68950")]
	public static IEnumerable<T> MHGGCAJOMJO<T, TKey>(this IEnumerable<T> GPBFFBAAOEG, Func<T, TKey> ICNOFHENGHL) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1D04DB0", Offset = "0x1D037B0", VA = "0x181D04DB0")]
	[IteratorStateMachine(typeof(KCHGKOFHPFH))]
	public static IEnumerable<T> NKODALHPHLF<T, U>(this IEnumerable<T> INHKNJBCCPD, IEnumerable<U> MPHACEGLFIL, [Optional][KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")] T IBMOPJIJEMD) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x101CB70", Offset = "0x101B570", VA = "0x18101CB70")]
	public static T DLJJKEJPEHB<T>(this IEnumerable<T> KCGHNGOMAMI, T LGCPJJBBDLH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2B663E0", Offset = "0x2B64DE0", VA = "0x182B663E0")]
	public static T DLJJKEJPEHB<T>(this IEnumerable<T> KCGHNGOMAMI, T LGCPJJBBDLH, Func<T, bool> NJIFCLNECCM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1C78F00", Offset = "0x1C77900", VA = "0x181C78F00")]
	[IteratorStateMachine(typeof(CJBLONOHAAJ))]
	public static IEnumerable<(T, global::DBEIBEIIMCM<T>)> JMIAMELMGNH<T>(this IEnumerable<T> INHKNJBCCPD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2B68860", Offset = "0x2B67260", VA = "0x182B68860")]
	public static bool MGIKBOHDKDK<T>(this IEnumerable<T> INHKNJBCCPD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1992BD0", Offset = "0x19915D0", VA = "0x181992BD0")]
	public static IEnumerable<global::PDFKBNNABNH<T>> CMHFEELAEBD<T>(this IEnumerable<T> INHKNJBCCPD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2B672D0", Offset = "0x2B65CD0", VA = "0x182B672D0")]
	public static bool JEJILLMBCFE<T>(this IEnumerable<T> INHKNJBCCPD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2B66D70", Offset = "0x2B65770", VA = "0x182B66D70")]
	public static IEnumerable<T> HJPPMPLPEJM<T>(this IEnumerable<T> INHKNJBCCPD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1D04C70", Offset = "0x1D03670", VA = "0x181D04C70")]
	[IteratorStateMachine(typeof(NJCEHHNAPJH))]
	public static IEnumerable<U> NJFAIINJKHE<U, T>(this IEnumerable<T> INHKNJBCCPD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7390", Offset = "0x6B6790")] Func<FJNFFAGNCLH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> OBENNOJJNMC) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2B68B30", Offset = "0x2B67530", VA = "0x182B68B30")]
	public static int MKHKALFDJIP<T>(this IEnumerable<T> INHKNJBCCPD, int CLKLENFCACN = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2B6AEC0", Offset = "0x2B698C0", VA = "0x182B6AEC0")]
	public static bool NGHGCFOEIDH<T>(this IEnumerable<T> INHKNJBCCPD, IEnumerable<T> MPHACEGLFIL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2B685D0", Offset = "0x2B66FD0", VA = "0x182B685D0")]
	public static (IEnumerable<T>, IEnumerable<T>) LDKICAFAINC<T>(this IEnumerable<T> INHKNJBCCPD, Func<T, bool> MJECMHDGGLC) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2B660E0", Offset = "0x2B64AE0", VA = "0x182B660E0")]
	public static string DLINHJCFOIH<T>(this IEnumerable<T> INHKNJBCCPD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2B66870", Offset = "0x2B65270", VA = "0x182B66870")]
	public static Dictionary<TKey?, TValue?>? FJPGFILAKHC<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7480", Offset = "0x6B6880")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? KCGHNGOMAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2B66870", Offset = "0x2B65270", VA = "0x182B66870")]
	public static Dictionary<TKey?, TValue?>? FJPGFILAKHC<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B74E0", Offset = "0x6B68E0")] this IEnumerable<(TKey? Key, TValue? Value)>? KCGHNGOMAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x25058C0", Offset = "0x25042C0", VA = "0x1825058C0")]
	public static HashSet<T> KEGPNNGGCPI<T>(this IEnumerable<T> INHKNJBCCPD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A080", Offset = "0x2B68A80", VA = "0x182B6A080")]
	public static string MKKKKABMBIG<T>(this IEnumerable<T> INHKNJBCCPD, string IDOBLHIFFGM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1D04BD0", Offset = "0x1D035D0", VA = "0x181D04BD0")]
	[IteratorStateMachine(typeof(JGNNGMENBIE))]
	public static IEnumerable<(T, U)> EEJIMLGNFOI<T, U>(this IEnumerable<T> GBEJHLEFDJM, IEnumerable<U> BDGBOHJLNIE) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2B67050", Offset = "0x2B65A50", VA = "0x182B67050")]
	public static IEnumerable<V> IEFEBFLCABI<V, T, U>(this IEnumerable<T> INHKNJBCCPD, IEnumerable<U> MPHACEGLFIL, Func<T, U, V> PJJPCKCLNCM, [Optional][KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")] T DPIKBNLJKMH, [Optional][KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")] U ILJHLNMNLDB) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2B670E0", Offset = "0x2B65AE0", VA = "0x182B670E0")]
	public static IEnumerable<(T, U)> IEFEBFLCABI<T, U>(this IEnumerable<T> INHKNJBCCPD, IEnumerable<U> MPHACEGLFIL, [Optional][KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")] T DPIKBNLJKMH, [Optional][KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")] U ILJHLNMNLDB) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class OONOGPOPMIM
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x22C1D50", Offset = "0x22C0750", VA = "0x1822C1D50")]
	public static bool PEDOMNPOPLE<T, U>(this T INHKNJBCCPD, in U NBNOMDAKOCG) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x22C1CB0", Offset = "0x22C06B0", VA = "0x1822C1CB0")]
	public static bool ELLCKJGHHAJ<T>(ref T INHKNJBCCPD, T MPHACEGLFIL) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class BKOMNHFBMAG
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2D780F0", Offset = "0x2D76AF0", VA = "0x182D780F0")]
	public static bool LDJEHJMDLGN(this in float3 HFOFADIOHHP, float3 GFCGIJPPCBN, float IHBAJBLJLEK = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class PBDNJCPFOAJ
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x22C4D30", Offset = "0x22C3730", VA = "0x1822C4D30")]
	public static void PKAFAOMJAMJ<T>(this T FOHPMIEDDCH, Action<T> CCNCACCKBFP) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x22C4AB0", Offset = "0x22C34B0", VA = "0x1822C4AB0")]
	public static V KNCJLIANCOO<V, T>(this T FOHPMIEDDCH, Func<T, V> CCNCACCKBFP, [Optional][KCDCAGLMLEB("`default!` shouldn't be necessary in C# 9")] V LGCPJJBBDLH) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x22C4C40", Offset = "0x22C3640", VA = "0x1822C4C40")]
	public static T? LCGBOKJEIMK<T>(this T INHKNJBCCPD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1C789B0", Offset = "0x1C773B0", VA = "0x181C789B0")]
	[IteratorStateMachine(typeof(HALPCFAMKFM))]
	public static IEnumerable<T> PGOMFELOHEH<T>(this T INHKNJBCCPD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x22C49D0", Offset = "0x22C33D0", VA = "0x1822C49D0")]
	public static T[] BBBODFBNHEM<T>(this T INHKNJBCCPD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class FMJLMOBGBMM
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x69D47E0", Offset = "0x69D31E0", VA = "0x1869D47E0")]
	private static byte[] APMBHCGDMJF(int OLAOPLEEFDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x69D4EE0", Offset = "0x69D38E0", VA = "0x1869D4EE0")]
	private static byte[] INBGBNINIEB(long FJCDCEEJJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x69D4860", Offset = "0x69D3260", VA = "0x1869D4860")]
	private static byte[] EHBGIDMOJGD(ulong FJCDCEEJJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x69D5040", Offset = "0x69D3A40", VA = "0x1869D5040")]
	public static Guid KNACJPGANJJ(params Guid[] DDGPENMMFGN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x69D4A20", Offset = "0x69D3420", VA = "0x1869D4A20")]
	public static Guid IDIKGABNBEI(in Guid FDFEDECJLKO, int EGNHJGKABLC, int NHBDMCDLELK = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x69D4960", Offset = "0x69D3360", VA = "0x1869D4960")]
	public static Guid IDIKGABNBEI(in Guid FDFEDECJLKO, long EGNHJGKABLC, int NHBDMCDLELK = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x69D4AE0", Offset = "0x69D34E0", VA = "0x1869D4AE0")]
	public static Guid IDIKGABNBEI(in Guid FDFEDECJLKO, ulong EGNHJGKABLC, int NHBDMCDLELK = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x69D4E70", Offset = "0x69D3870", VA = "0x1869D4E70")]
	public static Guid IDIKGABNBEI(in Guid FDFEDECJLKO, in Guid KLMKHNGIGFC, int NHBDMCDLELK = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x69D4BA0", Offset = "0x69D35A0", VA = "0x1869D4BA0")]
	private static Guid IDIKGABNBEI(in Guid FDFEDECJLKO, byte[] FCKGDJIOOGM, int NHBDMCDLELK = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x69D4F60", Offset = "0x69D3960", VA = "0x1869D4F60")]
	private static void JBFDLLLPEFO(byte[] NPIFLODGAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x69D48E0", Offset = "0x69D32E0", VA = "0x1869D48E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x69D5A80", Offset = "0x69D4480", VA = "0x1869D5A80")]
	public static int MDADOGEJCJI(this int INHKNJBCCPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x69D5A40", Offset = "0x69D4440", VA = "0x1869D5A40")]
	public static int HJNAGMGJCAM(this int INHKNJBCCPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x69D59E0", Offset = "0x69D43E0", VA = "0x1869D59E0")]
	public static int CDPDPDCFGDN(this int INHKNJBCCPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x69D5A30", Offset = "0x69D4430", VA = "0x1869D5A30")]
	public static int DNJFDCOGJBI(this int INHKNJBCCPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xE34FE0", Offset = "0xE339E0", VA = "0x180E34FE0")]
	public static int NMLGNFENIIP(this int INHKNJBCCPD, int EJMNNLNLAFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0xB74C20", Offset = "0xB73620", VA = "0x180B74C20")]
	public static int LFHNNNGCJPD(this int INHKNJBCCPD, int EJMNNLNLAFJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class FNPIEOFFLDC
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2F81DF0", Offset = "0x2F807F0", VA = "0x182F81DF0")]
	public static void LOCCMPKKMAH<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7EB0", Offset = "0x6B72B0")] this in KeyValuePair<TKey, TValue> INHKNJBCCPD, out TKey OGFDNCPKECB, out TValue LPJDDLMPNCG) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2F81F70", Offset = "0x2F80970", VA = "0x182F81F70")]
	public static (TKey?, TValue?) OLCBEMCLJCL<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7F20", Offset = "0x6B7320")] this in KeyValuePair<TKey?, TValue?> INHKNJBCCPD)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2F81D10", Offset = "0x2F80710", VA = "0x182F81D10")]
	public static KeyValuePair<TKey?, UValue?> KBJBILDHAFB<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7F90", Offset = "0x6B7390")] this KeyValuePair<TKey?, TValue?> INHKNJBCCPD, UValue LPJDDLMPNCG)
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
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public IFJCIIPKBKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1AA88B0", Offset = "0x1AA72B0", VA = "0x181AA88B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public HCLJAJGNIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BFCE0", Offset = "0x8BE6E0", VA = "0x1808BFCE0")]
		internal int <Random>b__0(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2525FF0", Offset = "0x25249F0", VA = "0x182525FF0")]
	public static int EDKMNFPOIHF<T>(this IReadOnlyList<T> BGAKDGCGOMH, T LPJDDLMPNCG) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2527D50", Offset = "0x2526750", VA = "0x182527D50")]
	public static int HPCINGGKMOM<T>(this IReadOnlyList<T> BGAKDGCGOMH, T LPJDDLMPNCG) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x25280C0", Offset = "0x2526AC0", VA = "0x1825280C0")]
	public static void JHAKILBFFKF<T>(this HashSet<T> PFBNMCNAHJB, IEnumerable<T> FAOHJBCBHLI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2529310", Offset = "0x2527D10", VA = "0x182529310")]
	public static void MOJDPHDHIDA<T>(this IList<T> BDHPAGCMKHB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2529390", Offset = "0x2527D90", VA = "0x182529390")]
	public static void MOJDPHDHIDA<T>(this IList<T> BDHPAGCMKHB, int EGKADOFOBMO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2527100", Offset = "0x2525B00", VA = "0x182527100")]
	public static List<T> FKLJICKBHEF<T>(this List<T> BDDEAAJFJHC, Predicate<T> PBPBFOEECGL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2526880", Offset = "0x2525280", VA = "0x182526880")]
	public static int EDKMNFPOIHF<T>(this IReadOnlyList<T> BDHPAGCMKHB, Predicate<T> NJIFCLNECCM) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2526AE0", Offset = "0x25254E0", VA = "0x182526AE0")]
	public static bool EJLMEALKPJD<T>(this IReadOnlyList<T> BDHPAGCMKHB, Predicate<T> NJIFCLNECCM, [MNKKOBAPPBG(true)] out List<int>? JDFBPHJNCCJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2527970", Offset = "0x2526370", VA = "0x182527970")]
	public static bool GMBMHDKFMPB<T>(this IReadOnlyList<T> BDHPAGCMKHB, T JPOBIIKLHON) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2527260", Offset = "0x2525C60", VA = "0x182527260")]
	public static bool GMBMHDKFMPB<T>(this IReadOnlyList<T> BDHPAGCMKHB, T JPOBIIKLHON, EqualityComparer<T> GIMMCBBNPCI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x252C3E0", Offset = "0x252ADE0", VA = "0x18252C3E0")]
	public static int PPJKNEGGAPL<TElement, TKey>(this IList<TElement> JJMPKANKMHO, TKey BGJHLFDNKIH, Func<TElement, TKey> MDBEBDLNLEM, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8070", Offset = "0x6B7470")] Func<TKey, TKey, int> HBFCEANPGHH, int EGNHJGKABLC = 0, [Optional] int? EJMNNLNLAFJ) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x252BE00", Offset = "0x252A800", VA = "0x18252BE00")]
	public static int PPJKNEGGAPL<TElement, TKey>(Func<int, TElement> CAMFHFCBMJH, int LNLLCOHNIKJ, TKey BGJHLFDNKIH, Func<TElement, TKey> MDBEBDLNLEM, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B80D0", Offset = "0x6B74D0")] Func<TKey, TKey, int> HBFCEANPGHH, int EGNHJGKABLC = 0, [Optional] int? EJMNNLNLAFJ) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2525BE0", Offset = "0x25245E0", VA = "0x182525BE0")]
	public static List<T> CMJDFMHPHIM<T>(this IReadOnlyList<T> BDHPAGCMKHB, int EJMNNLNLAFJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2528DA0", Offset = "0x25277A0", VA = "0x182528DA0")]
	public static bool KFNINGPAMDH<T>(this List<T> BDHPAGCMKHB, T JPOBIIKLHON) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2529150", Offset = "0x2527B50", VA = "0x182529150")]
	public static void MLNLGLMACFP<T>(this List<T> BDHPAGCMKHB, IEnumerable<T> BDDEAAJFJHC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2526F60", Offset = "0x2525960", VA = "0x182526F60")]
	public static void FJEBMLODAAK<T>(this List<T> BDHPAGCMKHB, IEnumerable<T> BDDEAAJFJHC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2528EB0", Offset = "0x25278B0", VA = "0x182528EB0")]
	public static T LEGOABCGJME<T>(this List<T> BDDEAAJFJHC, Predicate<T> PBPBFOEECGL) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2525B70", Offset = "0x2524570", VA = "0x182525B70")]
	public static T BNJCMLANCKO<T>(this List<T> BDDEAAJFJHC, int EGNHJGKABLC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2525E40", Offset = "0x2524840", VA = "0x182525E40")]
	public static bool DLAMJLPFKMN<T>(this List<T> FLKOGPABCGJ, List<T> MGFELCHHLDH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x252B9C0", Offset = "0x252A3C0", VA = "0x18252B9C0")]
	public static T OBIMAAELFFL<T>(this IList<T> BDHPAGCMKHB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2527C90", Offset = "0x2526690", VA = "0x182527C90")]
	public static bool HNHELEOPLEK<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8130", Offset = "0x6B7530")] IReadOnlyList<T> BDHPAGCMKHB, int EGNHJGKABLC, [EBIDJBJAIJA(false)][KCDCAGLMLEB("This should be `T?` in C# 9.")] out T JGINNNKFHFP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x252AB90", Offset = "0x2529590", VA = "0x18252AB90")]
	public static bool NINKMCNOKPF<T>(IReadOnlyList<T> BDHPAGCMKHB, ICollection BDDEAAJFJHC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2525ED0", Offset = "0x25248D0", VA = "0x182525ED0")]
	public static void EBMCECAIEJG<T>(IReadOnlyList<T> BDHPAGCMKHB, ref ICollection BDDEAAJFJHC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2525B20", Offset = "0x2524520", VA = "0x182525B20")]
	public static bool BCMJLANMBBM<T>(this IReadOnlyList<T> BDHPAGCMKHB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2527AB0", Offset = "0x25264B0", VA = "0x182527AB0")]
	public static string HFIMEIFIMCA<T>(this IEnumerable<T> BDHPAGCMKHB, string NDBKBBHINAE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x252BD50", Offset = "0x252A750", VA = "0x18252BD50")]
	public static T PPGKPKPAMKJ<T>(this IList<T> INHKNJBCCPD) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2528FA0", Offset = "0x25279A0", VA = "0x182528FA0")]
	public static T MLIDGCCMAPN<T>(this IList<T> INHKNJBCCPD) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x252BA60", Offset = "0x252A460", VA = "0x18252BA60")]
	public static void PKCNIFMKFFN<T>(this IList<T> INHKNJBCCPD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2527F10", Offset = "0x2526910", VA = "0x182527F10")]
	public static void IPOMJILOPME<T>(this IList<T> INHKNJBCCPD, in T LPJDDLMPNCG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2528BF0", Offset = "0x25275F0", VA = "0x182528BF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x69D4460", Offset = "0x69D2E60", VA = "0x1869D4460")]
	public static bool BGBFLDJBLIE(float HFOFADIOHHP, float GFCGIJPPCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4AC8A80", Offset = "0x4AC7480", VA = "0x184AC8A80")]
	public static float IIOBFPPCPID(float LPJDDLMPNCG, float ONLKOJHBEOC, float JKHCMKCHKPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4AC8AA0", Offset = "0x4AC74A0", VA = "0x184AC8AA0")]
	public static int IIOBFPPCPID(int LPJDDLMPNCG, int ONLKOJHBEOC, int JKHCMKCHKPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4AC8A60", Offset = "0x4AC7460", VA = "0x184AC8A60")]
	public static float DCMIOBAADAK(float LPJDDLMPNCG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x69D4560", Offset = "0x69D2F60", VA = "0x1869D4560")]
	public static float EHGCAMIANOD(float HFOFADIOHHP, float GFCGIJPPCBN, float FOHPMIEDDCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1370", Offset = "0x3AAFD70", VA = "0x183AB1370")]
	public static float HMBNCEOACLK(float HFOFADIOHHP, float GFCGIJPPCBN, float FOHPMIEDDCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x69D4600", Offset = "0x69D3000", VA = "0x1869D4600")]
	public static float KAICFHPFPOD(float HFOFADIOHHP, float GFCGIJPPCBN, float LPJDDLMPNCG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x69D46C0", Offset = "0x69D30C0", VA = "0x1869D46C0")]
	public static float KKGMEOFLACD(float HFOFADIOHHP, float GFCGIJPPCBN, float LPJDDLMPNCG)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class PBEBLDMDIOC
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x22C4D70", Offset = "0x22C3770", VA = "0x1822C4D70")]
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
	[Cpp2IlInjected.Address(RVA = "0x69D3FE0", Offset = "0x69D29E0", VA = "0x1869D3FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69D5890", Offset = "0x69D4290", VA = "0x1869D5890", Slot = "4")]
		public int BPAJEMADNLI(int MGEHMJGFDIN, int MDDMMGCHGAF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x69D58C0", Offset = "0x69D42C0", VA = "0x1869D58C0", Slot = "5")]
		public float HOOKAICFODF(float MGEHMJGFDIN, float AAMOGHEGGPN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x69D5930", Offset = "0x69D4330", VA = "0x1869D5930")]
		private double KJJPALAOIGP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x69D5970", Offset = "0x69D4370", VA = "0x1869D5970")]
		public NKGCIMIHHAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly MPHCLCOLDPN CMJDFMHPHIM;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x69D51B0", Offset = "0x69D3BB0", VA = "0x1869D51B0")]
	public static ulong OHOFLJHBPCB()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class JMNNAKHDKEH
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x199AF20", Offset = "0x1999920", VA = "0x18199AF20")]
	public static bool AEDMBEEAEKH<T>(this IReadOnlyCollection<T> INHKNJBCCPD, int EGNHJGKABLC) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class AMGNCCDGGHC
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x10F7B70", Offset = "0x10F6570", VA = "0x1810F7B70")]
	public static bool DJKANKJNGBD<T>(this IReadOnlyList<T> INHKNJBCCPD, int EGNHJGKABLC, [MNKKOBAPPBG(true)][KCDCAGLMLEB("This should be `T?` in C# 9.")] out T JGINNNKFHFP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x10F7C00", Offset = "0x10F6600", VA = "0x1810F7C00")]
	public static bool EDLJEFMBNEB<T>(this IReadOnlyList<T> INHKNJBCCPD, int EGNHJGKABLC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B82D0", Offset = "0x6B76D0")] out global::PDFKBNNABNH<T> JGINNNKFHFP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x10F7CC0", Offset = "0x10F66C0", VA = "0x1810F7CC0")]
	public static T NIILOMKNHCI<T>(this IReadOnlyList<T> INHKNJBCCPD, int EGNHJGKABLC, in T JKMJDJJMAJK) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x10F7AB0", Offset = "0x10F64B0", VA = "0x1810F7AB0")]
	[KCDCAGLMLEB("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T DBIABGHOLPJ<T>(this IReadOnlyList<T> INHKNJBCCPD, int EGNHJGKABLC) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x10F7A00", Offset = "0x10F6400", VA = "0x1810F7A00")]
	public static T? AHOAFHFCFID<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8370", Offset = "0x6B7770")] this IReadOnlyList<T> INHKNJBCCPD, int EGNHJGKABLC) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class ALOFIPFLKAL
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x10F6AB0", Offset = "0x10F54B0", VA = "0x1810F6AB0")]
	public static T MKLBNKEKMJE<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8410", Offset = "0x6B7810")] this in ReadOnlyMemory<T> INHKNJBCCPD, int EGNHJGKABLC) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x10F67B0", Offset = "0x10F51B0", VA = "0x1810F67B0")]
	public static bool EDMDBKBAELO<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8480", Offset = "0x6B7880")] this in ReadOnlyMemory<T> INHKNJBCCPD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B84F0", Offset = "0x6B78F0")] in ReadOnlyMemory<T> MPHACEGLFIL) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x10F68D0", Offset = "0x10F52D0", VA = "0x1810F68D0")]
	public static int MKHKALFDJIP<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8560", Offset = "0x6B7960")] this in ReadOnlyMemory<T?> INHKNJBCCPD, int CLKLENFCACN = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x10F6710", Offset = "0x10F5110", VA = "0x1810F6710")]
	public static string DLINHJCFOIH<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B85D0", Offset = "0x6B79D0")] this in ReadOnlyMemory<T> INHKNJBCCPD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class DOBHMIFBKOP
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1D6AD20", Offset = "0x1D69720", VA = "0x181D6AD20")]
	public static bool EDMDBKBAELO<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8640", Offset = "0x6B7A40")] this in ReadOnlySpan<T?> INHKNJBCCPD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B86B0", Offset = "0x6B7AB0")] in ReadOnlySpan<T?> MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1D6AEA0", Offset = "0x1D698A0", VA = "0x181D6AEA0")]
	public static int MKHKALFDJIP<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8720", Offset = "0x6B7B20")] this in ReadOnlySpan<T?> INHKNJBCCPD, int CLKLENFCACN = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1D6ABC0", Offset = "0x1D695C0", VA = "0x181D6ABC0")]
	public static string DLINHJCFOIH<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8790", Offset = "0x6B7B90")] this in ReadOnlySpan<T> INHKNJBCCPD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1D6AFC0", Offset = "0x1D699C0", VA = "0x181D6AFC0")]
	public static string MKKKKABMBIG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8800", Offset = "0x6B7C00")] this in ReadOnlySpan<T> INHKNJBCCPD, string IDOBLHIFFGM) where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x69D5B80", Offset = "0x69D4580", VA = "0x1869D5B80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x69D5BE0", Offset = "0x69D45E0", VA = "0x1869D5BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69D5810", Offset = "0x69D4210", VA = "0x1869D5810", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
	private JEPLCALKAOJ(Stopwatch DDCPMELELDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x69D5830", Offset = "0x69D4230", VA = "0x1869D5830")]
	public static JEPLCALKAOJ KIFIGIGBPBI(Stopwatch DDCPMELELDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x69D5770", Offset = "0x69D4170", VA = "0x1869D5770")]
	public static JEPLCALKAOJ ALCCKEKGABM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class IHANBINLKFN
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x69D5710", Offset = "0x69D4110", VA = "0x1869D5710")]
	public static RigidTransform GKEKBBKBJID(this in RigidTransform INHKNJBCCPD)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class DGOLFMLLGFG
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x69D3F20", Offset = "0x69D2920", VA = "0x1869D3F20")]
	public static RigidTransform DCBHMBLECHG(RigidTransform DALHGEHGNOJ, RigidTransform KNHBHBPFHPH)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class IFKLDONNLEE
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xC17FD0", Offset = "0xC169D0", VA = "0x180C17FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3343F90", Offset = "0x3342990", VA = "0x183343F90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x357B9D0", Offset = "0x357A3D0", VA = "0x18357B9D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x357B970", Offset = "0x357A370", VA = "0x18357B970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x357B7D0", Offset = "0x357A1D0", VA = "0x18357B7D0")]
	public static JPEDILAFGBK DIGPJAIHDLF()
	{
		return default(JPEDILAFGBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x357BA90", Offset = "0x357A490", VA = "0x18357BA90")]
	private static void LJMPMFMCLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x357BA20", Offset = "0x357A420", VA = "0x18357BA20")]
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
	[Cpp2IlInjected.Address(RVA = "0x69D56A0", Offset = "0x69D40A0", VA = "0x1869D56A0")]
	public ICJCGCFMJPD(BAECBGKPKDA DDCPMELELDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x69D54F0", Offset = "0x69D3EF0", VA = "0x1869D54F0")]
	public long BNOCAOMAPLE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x69D5610", Offset = "0x69D4010", VA = "0x1869D5610")]
	public double PGDHKMKNGGB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x69D5580", Offset = "0x69D3F80", VA = "0x1869D5580")]
	public double GPLAFBMEHCM()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class BLIADJPADIP
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xA1F680", Offset = "0xA1E080", VA = "0x180A1F680")]
	public static bool DPGFIAJAMBC(this Type INHKNJBCCPD, Type MPHACEGLFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1F78110", Offset = "0x1F76B10", VA = "0x181F78110")]
	public static bool DPGFIAJAMBC<T>(this Type INHKNJBCCPD) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class MHOBENAILAM
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xE34FE0", Offset = "0xE339E0", VA = "0x180E34FE0")]
	public static uint NMLGNFENIIP(this uint INHKNJBCCPD, int EJMNNLNLAFJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0xB74C20", Offset = "0xB73620", VA = "0x180B74C20")]
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
