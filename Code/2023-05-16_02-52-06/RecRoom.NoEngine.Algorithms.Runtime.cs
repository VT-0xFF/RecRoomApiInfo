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
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6AF5620", Offset = "0x6AF4420", VA = "0x186AF5620")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75C880", Offset = "0x75B680", VA = "0x18075C880")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7DB60", Offset = "0xA7C960", VA = "0x180A7DB60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EAMIGLCPHNM
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate int FJJGCMAEGGN<T>(in T JGEPMPFGKOG, in T CPIBOCOHLLI);

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class IINJNKIOMHA<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct BPKHOJHMDKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly int IAONMKKMAEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly int KJJNLGDLKHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public readonly bool ABFHKKLDNFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int LEELFBLFJNF;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x28B5ED0", Offset = "0x28B4CD0", VA = "0x1828B5ED0")]
			public BPKHOJHMDKD(int IAONMKKMAEN, int KJJNLGDLKHP, bool ABFHKKLDNFC)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly T[] KLECEFKIMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly T[] PEIKLNBAEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly FJJGCMAEGGN<T> HKDLKEKDNGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly int AFBNHOJGDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Func<bool> PMCDHJODCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int FHNGEMDJEOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D3AD0", Offset = "0x6D2ED0")]
		private readonly IINJNKIOMHA<T>.BPKHOJHMDKD[] EBGFJLADMEJ;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1E06AF0", Offset = "0x1E058F0", VA = "0x181E06AF0")]
		public IINJNKIOMHA(T[] KLECEFKIMDD, FJJGCMAEGGN<T> HKDLKEKDNGJ, int AFBNHOJGDMK, Func<bool> PMCDHJODCOF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D3B30", Offset = "0x6D2F30")] T[] BCJEGAJBMNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1E06400", Offset = "0x1E05200", VA = "0x181E06400")]
		public bool IEIGPEEIPIJ()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate U CJIJCGPNNJG<T, U>(int GNGPOFKHIKM, int PBPACDBOFIA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D3B90", Offset = "0x6D2F90")] in ReadOnlySpan<T> DENGEOMEGDJ);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x20AB5E0", Offset = "0x20AA3E0", VA = "0x1820AB5E0")]
	public static ReadOnlyMemory<T> PLDKEAIFBEP<T>(this T[] LCNEHOGIJPK) where T : notnull
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x20AA840", Offset = "0x20A9640", VA = "0x1820AA840")]
	public static T[] EKCHEFPPMCB<T>(int MKGODNJCKOC, T FCCFLMABHKK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x20AA3E0", Offset = "0x20A91E0", VA = "0x1820AA3E0")]
	public static void CICGFLGGOGP<T>(this T[] KELNPBLPAJP, T FCCFLMABHKK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x20AB530", Offset = "0x20AA330", VA = "0x1820AB530")]
	public static void NGGALKAKAFE<T>(this T[] PALKODKBAJM, int FCPPLBLBJIC, int ANLNDCJMNDD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x20AA9C0", Offset = "0x20A97C0", VA = "0x1820AA9C0")]
	private static void HAIFEPEPPAM<T>(this T[] LCNEHOGIJPK, int PJADMCBILIN, int LKOANEOKNOK, T[] IDBPJJAKCBN, int FPDEAOMLJAC, int ODAELPEMMOF, T[] AJCHMFJLMGE, int JHABOHBGHED, FJJGCMAEGGN<T> HKDLKEKDNGJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x20A9970", Offset = "0x20A8770", VA = "0x1820A9970")]
	public static void AAEGPEOFAED<T>(this T[] LCNEHOGIJPK, int IAONMKKMAEN, int MNBBKKLFBKD, FJJGCMAEGGN<T> HKDLKEKDNGJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x20AA7A0", Offset = "0x20A95A0", VA = "0x1820AA7A0")]
	public static IINJNKIOMHA<T> CPDKBNEEKCN<T>(this T[] LCNEHOGIJPK, FJJGCMAEGGN<T> HKDLKEKDNGJ, int AFBNHOJGDMK, Func<bool> PMCDHJODCOF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D39F0", Offset = "0x6D2DF0")] T[] BCJEGAJBMNM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x20AB460", Offset = "0x20AA260", VA = "0x1820AB460")]
	public static T[] NCJICEPHCBO<T>(this T[] PALKODKBAJM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x20AA300", Offset = "0x20A9100", VA = "0x1820AA300")]
	public static T[] BNEOOHOLCAD<T>(this T[] HCOKOPBEBLE, T BMIOHILHHAP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x20AAE70", Offset = "0x20A9C70", VA = "0x1820AAE70")]
	public static T[] KIDMMLKBJMH<T>(this T[] HCOKOPBEBLE, int NNHNOIMLALG, T BMIOHILHHAP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x20AADC0", Offset = "0x20A9BC0", VA = "0x1820AADC0")]
	public static T[] JKHHIMLKAJN<T>(this T[] HCOKOPBEBLE, int NNHNOIMLALG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x20AA570", Offset = "0x20A9370", VA = "0x1820AA570")]
	public static T[] CIMIPENMFDN<T>(this T[] HCOKOPBEBLE, int NNHNOIMLALG, T BMIOHILHHAP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x20A9DC0", Offset = "0x20A8BC0", VA = "0x1820A9DC0")]
	public static U[] AIJDLKJDIIO<U, T>(this T[] BFGFBJNNCDN, int FJFMIJHDMKJ, CJIJCGPNNJG<T, U> NFNLLHOJMOM) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3FF0", Offset = "0x6AF2DF0", VA = "0x186AF3FF0")]
	public static byte[] CMEAPBDBHCJ(this byte[] LCNEHOGIJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3DF0", Offset = "0x6AF2BF0", VA = "0x186AF3DF0")]
	public static byte[] BFDDEKEAHFB(this byte[] LCNEHOGIJPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class LLNOEBKADLO
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x27D7A40", Offset = "0x27D6840", VA = "0x1827D7A40")]
	public static void MBEELBLAEJN<T>(this ICollection<T> LCNEHOGIJPK, IEnumerable<T> MKIDAPMAKPK) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JOFABIANDJL
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1644DE0", Offset = "0x1643BE0", VA = "0x181644DE0")]
	public static void JAEGMKLDCIG<K, V>(this IDictionary<K, V> LCNEHOGIJPK, in K JHANOPJHOLP, in V MGFMONLLLPD, Func<V, V, V> BIBNDHMNLLC) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1645CF0", Offset = "0x1644AF0", VA = "0x181645CF0")]
	public static void NMNOBNBBHGG<K, V>(this IDictionary<K, List<V>> LCNEHOGIJPK, in K JHANOPJHOLP, in V MGFMONLLLPD) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1643F10", Offset = "0x1642D10", VA = "0x181643F10")]
	public static TVal EEILMIDAPKF<TVal, TKey>(this IDictionary<TKey, TVal> HOPLLDGEACD, in TKey JHANOPJHOLP, [Optional][PBMBPPOGDAA("`default!` shouldn't be necessary in C# 9")] TVal HPJBCMEILDI) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1643D70", Offset = "0x1642B70", VA = "0x181643D70")]
	public static TVal EEILMIDAPKF<TVal, TKey>(this IDictionary<TKey, TVal> HOPLLDGEACD, in TKey JHANOPJHOLP, Func<TVal> JALBOPJKCNE) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1645540", Offset = "0x1644340", VA = "0x181645540")]
	public static TValue MNPNJOHCLLI<TValue, TKey>(this IDictionary<TKey, TValue> HOPLLDGEACD, in TKey JHANOPJHOLP, [Optional][PBMBPPOGDAA("`default!` and null-oblivious region shouldn't be necessary in C# 9")] in TValue HPJBCMEILDI)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1644810", Offset = "0x1643610", VA = "0x181644810")]
	public static V HGAKDKMCHOO<V, K>(this IDictionary<K, V> LCNEHOGIJPK, in K JHANOPJHOLP) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1645AE0", Offset = "0x16448E0", VA = "0x181645AE0")]
	public static T2[] NEECKNOMDLH<T2, T1>(this Dictionary<T1, T2>.ValueCollection NPKOFPALCBH) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1645B70", Offset = "0x1644970", VA = "0x181645B70")]
	public static bool NEHFKMKGDBM<TKey, TValue>(this IDictionary<TKey, TValue> LCNEHOGIJPK, TKey JHANOPJHOLP, TValue MGFMONLLLPD) where TKey : notnull where TValue : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MMCBNLJNGDC
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate bool LFAIHMDGDLM<TArgs, T>(in TArgs CFGJGLPAHFD, T PIBOOIGHJBI);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate U EIHNGAJAKGG<TArg, U>(in TArg OHMLFHCAJEC);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate U KCCMBHDDGME<TArg, T, U>(in TArg OHMLFHCAJEC, T CEDANDKJJLH);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate U NFIGBOLPFGC<TArg, T, U>(in TArg OHMLFHCAJEC, IEnumerable<T> BNPIGAGGDHK);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate U NENPNICLHPA<TArg, T, U>(in TArg OHMLFHCAJEC, T CEDANDKJJLH);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct MBHMMOMFMJL<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC820", Offset = "0x2CDB620", VA = "0x182CDC820")]
		[PBMBPPOGDAA("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) OKOIFDOCDMJ(T NEIKFNLIHBN)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC7B0", Offset = "0x2CDB5B0", VA = "0x182CDC7B0")]
		[PBMBPPOGDAA("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) EBJGDPPNAFN(IEnumerable<T> PLCHIDJIKDD)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class FKNKCMPLLLB<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public FKNKCMPLLLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2562D10", Offset = "0x2561B10", VA = "0x182562D10")]
		internal bool <SetEqual>b__0(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2A6E320", Offset = "0x2A6D120", VA = "0x182A6E320")]
		internal bool <SetEqual>b__1(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x25151F0", Offset = "0x2513FF0", VA = "0x1825151F0")]
	public static bool HHOEPGKIPHC<T, TArgs>(this IEnumerable<T> LCNEHOGIJPK, in TArgs CFGJGLPAHFD, LFAIHMDGDLM<TArgs, T> BFLBJMNICKA) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x25166D0", Offset = "0x25154D0", VA = "0x1825166D0")]
	public static U LHLMJDCFCBC<U, T>(this IEnumerable<T> LCNEHOGIJPK, Func<U> GPBJCJNLEMB, Func<T, U> NEIKFNLIHBN, Func<IEnumerable<T>, U> PLCHIDJIKDD) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x25118D0", Offset = "0x25106D0", VA = "0x1825118D0")]
	public static bool BPJBBAJCAEM<T, TArgs>(this IEnumerable<T> LCNEHOGIJPK, in TArgs CFGJGLPAHFD, LFAIHMDGDLM<TArgs, T> BFLBJMNICKA) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2515D20", Offset = "0x2514B20", VA = "0x182515D20")]
	public static U JEHGFNFACJL<U, T, TArg>(this IEnumerable<T> LCNEHOGIJPK, in TArg OHMLFHCAJEC, EIHNGAJAKGG<TArg, U> GPBJCJNLEMB, KCCMBHDDGME<TArg, T, U> NEIKFNLIHBN, NFIGBOLPFGC<TArg, T, U> PLCHIDJIKDD) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2516120", Offset = "0x2514F20", VA = "0x182516120")]
	public static IEnumerable<U> JKBADPCJGFC<U, T, TArg>(this IEnumerable<T> LCNEHOGIJPK, in TArg OHMLFHCAJEC, NENPNICLHPA<TArg, T, U> MMIHJNLLJDF) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x22EA820", Offset = "0x22E9620", VA = "0x1822EA820")]
	public static IEnumerable<T> COGPEEFKLLI<T>(params IEnumerable<T>[] GJDICNGBPIL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2516980", Offset = "0x2515780", VA = "0x182516980")]
	public static bool PAEKDAFBPOF<T>(this IEnumerable<T> NFJHHMHDKEL, IEnumerable<T> IDBPJJAKCBN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x22EA820", Offset = "0x22E9620", VA = "0x1822EA820")]
	public static IEnumerable<(TKey?, TValue?)>? BMFIPCHNCII<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D3E20", Offset = "0x6D3220")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? LCNEHOGIJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x25116F0", Offset = "0x25104F0", VA = "0x1825116F0")]
	public static IEnumerable<T> BFLLLNCMPLI<T, TKey>(this IEnumerable<T> LAPHJEMBCKA, Func<T, TKey> FAOGPHHOGJE) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x23628D0", Offset = "0x23616D0", VA = "0x1823628D0")]
	[IteratorStateMachine(typeof(KLNDDHALIME))]
	public static IEnumerable<T> MCMPPCGAKJH<T, U>(this IEnumerable<T> LCNEHOGIJPK, IEnumerable<U> IDBPJJAKCBN, [Optional][PBMBPPOGDAA("`default!` shouldn't be necessary in C# 9")] T FCCFLMABHKK) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1066280", Offset = "0x1065080", VA = "0x181066280")]
	public static T GKAJPBFBFED<T>(this IEnumerable<T> NFJHHMHDKEL, T HPJBCMEILDI) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2514940", Offset = "0x2513740", VA = "0x182514940")]
	public static T GKAJPBFBFED<T>(this IEnumerable<T> NFJHHMHDKEL, T HPJBCMEILDI, Func<T, bool> BFLBJMNICKA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1662620", Offset = "0x1661420", VA = "0x181662620")]
	[IteratorStateMachine(typeof(BNKIIIIGANI))]
	public static IEnumerable<(T, global::POPJPNDPEEI<T>)> KDICGNECGJD<T>(this IEnumerable<T> LCNEHOGIJPK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x25164E0", Offset = "0x25152E0", VA = "0x1825164E0")]
	public static bool KBIPIDKDKAL<T>(this IEnumerable<T> LCNEHOGIJPK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x22EA820", Offset = "0x22E9620", VA = "0x1822EA820")]
	public static IEnumerable<global::AJPNGLJDKNK<T>> CEEBBJGGBDE<T>(this IEnumerable<T> LCNEHOGIJPK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2515EE0", Offset = "0x2514CE0", VA = "0x182515EE0")]
	public static bool JFJDDAHJJJF<T>(this IEnumerable<T> LCNEHOGIJPK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2516880", Offset = "0x2515680", VA = "0x182516880")]
	public static IEnumerable<T> MCBCJPPKKJK<T>(this IEnumerable<T> LCNEHOGIJPK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x20ABA10", Offset = "0x20AA810", VA = "0x1820ABA10")]
	[IteratorStateMachine(typeof(MPMANMJFLOO))]
	public static IEnumerable<U> JPBAHPKOOAF<U, T>(this IEnumerable<T> LCNEHOGIJPK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D3FC0", Offset = "0x6D33C0")] Func<MBHMMOMFMJL<U>, T, (bool Zero, U One, IEnumerable<U> Many)> KGNGOKCEDMN) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2514010", Offset = "0x2512E10", VA = "0x182514010")]
	public static int FCNNEJAMNPN<T>(this IEnumerable<T> LCNEHOGIJPK, int BJAEDKOGEAN = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2516340", Offset = "0x2515140", VA = "0x182516340")]
	public static bool JKBCOBPEGIO<T>(this IEnumerable<T> LCNEHOGIJPK, IEnumerable<T> IDBPJJAKCBN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2511DE0", Offset = "0x2510BE0", VA = "0x182511DE0")]
	public static (IEnumerable<T>, IEnumerable<T>) CEJCNNGOFPI<T>(this IEnumerable<T> LCNEHOGIJPK, Func<T, bool> IDLGEAANLMK) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2514580", Offset = "0x2513380", VA = "0x182514580")]
	public static string GCCDIMNMBBP<T>(this IEnumerable<T> LCNEHOGIJPK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2514990", Offset = "0x2513790", VA = "0x182514990")]
	public static Dictionary<TKey?, TValue?>? HAMNIOMPKKJ<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D40B0", Offset = "0x6D34B0")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? NFJHHMHDKEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2514990", Offset = "0x2513790", VA = "0x182514990")]
	public static Dictionary<TKey?, TValue?>? HAMNIOMPKKJ<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D4110", Offset = "0x6D3510")] this IEnumerable<(TKey? Key, TValue? Value)>? NFJHHMHDKEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x22B4780", Offset = "0x22B3580", VA = "0x1822B4780")]
	public static HashSet<T> PDFKONOLJJI<T>(this IEnumerable<T> LCNEHOGIJPK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2512810", Offset = "0x2511610", VA = "0x182512810")]
	public static string DJMHNDHNEIB<T>(this IEnumerable<T> LCNEHOGIJPK, string IMPFENHNLMK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x23626F0", Offset = "0x23614F0", VA = "0x1823626F0")]
	[IteratorStateMachine(typeof(PGIKDCLGIOH))]
	public static IEnumerable<(T, U)> NHGCPPILIAI<T, U>(this IEnumerable<T> JGEPMPFGKOG, IEnumerable<U> CPIBOCOHLLI) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x25158E0", Offset = "0x25146E0", VA = "0x1825158E0")]
	public static IEnumerable<V> IFIIIGJOMPK<V, T, U>(this IEnumerable<T> LCNEHOGIJPK, IEnumerable<U> IDBPJJAKCBN, Func<T, U, V> OKEJFDJOFJK, [Optional][PBMBPPOGDAA("`default!` shouldn't be necessary in C# 9")] T EKGAOBPEOIH, [Optional][PBMBPPOGDAA("`default!` shouldn't be necessary in C# 9")] U KIEBNGCIMFI) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2515970", Offset = "0x2514770", VA = "0x182515970")]
	public static IEnumerable<(T, U)> IFIIIGJOMPK<T, U>(this IEnumerable<T> LCNEHOGIJPK, IEnumerable<U> IDBPJJAKCBN, [Optional][PBMBPPOGDAA("`default!` shouldn't be necessary in C# 9")] T EKGAOBPEOIH, [Optional][PBMBPPOGDAA("`default!` shouldn't be necessary in C# 9")] U KIEBNGCIMFI) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class GCHMELALBKG
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x208A410", Offset = "0x2089210", VA = "0x18208A410")]
	public static bool BGJLHBCGMIG<T, U>(this T LCNEHOGIJPK, in U OJGAEOFIMPK) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x208A610", Offset = "0x2089410", VA = "0x18208A610")]
	public static bool CGFHIBJIBAM<T>(ref T LCNEHOGIJPK, T IDBPJJAKCBN) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class BLBJFBEHAIO
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2FD8550", Offset = "0x2FD7350", VA = "0x182FD8550")]
	public static bool IEGGFOACJDA(this in float3 GCKGDDMIIDO, float3 EJKHFJILHAC, float DCBENILAFGJ = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class BCDKDBPHEOL
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2654F60", Offset = "0x2653D60", VA = "0x182654F60")]
	public static void MJCEAFIBMGC<T>(this T DJCNOMGFLPK, Action<T> FCKNEHCIOIF) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2654C70", Offset = "0x2653A70", VA = "0x182654C70")]
	public static V AEKMHJCDHID<V, T>(this T DJCNOMGFLPK, Func<T, V> FCKNEHCIOIF, [Optional][PBMBPPOGDAA("`default!` shouldn't be necessary in C# 9")] V HPJBCMEILDI) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2654E50", Offset = "0x2653C50", VA = "0x182654E50")]
	public static T? LJEFOCOPHCF<T>(this T LCNEHOGIJPK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x16620D0", Offset = "0x1660ED0", VA = "0x1816620D0")]
	[IteratorStateMachine(typeof(IMAGJBGLFAO))]
	public static IEnumerable<T> NPAFOMDFDFN<T>(this T LCNEHOGIJPK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2654D10", Offset = "0x2653B10", VA = "0x182654D10")]
	public static T[] JECHBHGEMFK<T>(this T LCNEHOGIJPK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class MJIOGNHFKCN
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4FD0", Offset = "0x6AF3DD0", VA = "0x186AF4FD0")]
	private static byte[] GOACOGAOIEN(int KIINNPINIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4F50", Offset = "0x6AF3D50", VA = "0x186AF4F50")]
	private static byte[] FFJJOOFDEFO(long OJDEAEMLJMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4ED0", Offset = "0x6AF3CD0", VA = "0x186AF4ED0")]
	private static byte[] FEHBMFKCBOP(ulong OJDEAEMLJMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6AF5050", Offset = "0x6AF3E50", VA = "0x186AF5050")]
	public static Guid IBMAMFEAKKM(params Guid[] LDLGPJGIDAG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4D50", Offset = "0x6AF3B50", VA = "0x186AF4D50")]
	public static Guid CJALKNOJAHB(in Guid EBOAEPAEPBF, int NNHNOIMLALG, int HHCMOLFBCEB = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4E10", Offset = "0x6AF3C10", VA = "0x186AF4E10")]
	public static Guid CJALKNOJAHB(in Guid EBOAEPAEPBF, long NNHNOIMLALG, int HHCMOLFBCEB = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4C90", Offset = "0x6AF3A90", VA = "0x186AF4C90")]
	public static Guid CJALKNOJAHB(in Guid EBOAEPAEPBF, ulong NNHNOIMLALG, int HHCMOLFBCEB = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4950", Offset = "0x6AF3750", VA = "0x186AF4950")]
	public static Guid CJALKNOJAHB(in Guid EBOAEPAEPBF, in Guid GFCDAMPDEAP, int HHCMOLFBCEB = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6AF49C0", Offset = "0x6AF37C0", VA = "0x186AF49C0")]
	private static Guid CJALKNOJAHB(in Guid EBOAEPAEPBF, byte[] ONJNIGAMFAC, int HHCMOLFBCEB = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6AF51C0", Offset = "0x6AF3FC0", VA = "0x186AF51C0")]
	private static void IIDMPJCKNHA(byte[] AOKEOLFIKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6AF48D0", Offset = "0x6AF36D0", VA = "0x186AF48D0")]
	private static void AKIKDKBEEBK(byte[] AOKEOLFIKCH, int CJCAMOJJGED, int DDMHJAPFCFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface MHECEBEPAFC
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MDMHOCGCALJ JEHOAINMNNO();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface MDMHOCGCALJ : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool MEPDPOKDAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGHNFGBEOFP();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HNLALIGCECD
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int IAEBPIKIFIC(int IAGPCNKKMGO, int DOGBLJBIOLC);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float CDGLFLKMGFC(float EFDOGPEPANK, float INGPPMNENGA);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface IONMFBLNJEM
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	long BKGLADJPJLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class MBNHMHBJAEB
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6AF47D0", Offset = "0x6AF35D0", VA = "0x186AF47D0")]
	public static int LFDJNOMOPKO(this int LCNEHOGIJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4840", Offset = "0x6AF3640", VA = "0x186AF4840")]
	public static int MBDJOPFKDIE(this int LCNEHOGIJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4880", Offset = "0x6AF3680", VA = "0x186AF4880")]
	public static int NLGFBCEDANM(this int LCNEHOGIJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6AF47C0", Offset = "0x6AF35C0", VA = "0x186AF47C0")]
	public static int JMDJPNEBDFE(this int LCNEHOGIJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xF043A0", Offset = "0xF031A0", VA = "0x180F043A0")]
	public static int MBLCCNHELNL(this int LCNEHOGIJPK, int MNBBKKLFBKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0xBF3730", Offset = "0xBF2530", VA = "0x180BF3730")]
	public static int MKJKMDMKNLF(this int LCNEHOGIJPK, int MNBBKKLFBKD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class JJJPHOLHIEI
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x27841C0", Offset = "0x2782FC0", VA = "0x1827841C0")]
	public static void BJOOJLCIJFO<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D4A90", Offset = "0x6D3E90")] this in KeyValuePair<TKey, TValue> LCNEHOGIJPK, out TKey JHANOPJHOLP, out TValue MGFMONLLLPD) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x27843C0", Offset = "0x27831C0", VA = "0x1827843C0")]
	public static (TKey?, TValue?) NMHGJGMCLDH<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D4B00", Offset = "0x6D3F00")] this in KeyValuePair<TKey?, TValue?> LCNEHOGIJPK)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2784390", Offset = "0x2783190", VA = "0x182784390")]
	public static KeyValuePair<TKey?, UValue?> NJEIGFBMCFK<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D4B70", Offset = "0x6D3F70")] this KeyValuePair<TKey?, TValue?> LCNEHOGIJPK, UValue MGFMONLLLPD)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class MJMMKJAHKGH
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class GPAIKAAFPPL<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public GPAIKAAFPPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4793410", Offset = "0x4792210", VA = "0x184793410")]
		internal TElement <BinarySearch>b__0(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class KGCGMKPOBJM<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Random rng;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public KGCGMKPOBJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x907290", Offset = "0x906090", VA = "0x180907290")]
		internal int <Random>b__0(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x250B900", Offset = "0x250A700", VA = "0x18250B900")]
	public static int GFKMEHLHPCP<T>(this IReadOnlyList<T> PALKODKBAJM, T MGFMONLLLPD) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x25096F0", Offset = "0x25084F0", VA = "0x1825096F0")]
	public static int FFHBGPCJAJP<T>(this IReadOnlyList<T> PALKODKBAJM, T MGFMONLLLPD) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x250F280", Offset = "0x250E080", VA = "0x18250F280")]
	public static void MBEELBLAEJN<T>(this HashSet<T> DNBCEABGNNL, IEnumerable<T> MKIDAPMAKPK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x250EE50", Offset = "0x250DC50", VA = "0x18250EE50")]
	public static void LOFOMKKJPBB<T>(this IList<T> MPMKGFKPBEN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x250EB20", Offset = "0x250D920", VA = "0x18250EB20")]
	public static void LOFOMKKJPBB<T>(this IList<T> MPMKGFKPBEN, int JANAHKBEHCG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x250D760", Offset = "0x250C560", VA = "0x18250D760")]
	public static List<T> JLNNEIAPDBC<T>(this List<T> BFJIAFJFPDF, Predicate<T> MCCJOHPCLPK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x250BED0", Offset = "0x250ACD0", VA = "0x18250BED0")]
	public static int GFKMEHLHPCP<T>(this IReadOnlyList<T> MPMKGFKPBEN, Predicate<T> BFLBJMNICKA) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x250DDE0", Offset = "0x250CBE0", VA = "0x18250DDE0")]
	public static bool LDCECHAGMGL<T>(this IReadOnlyList<T> MPMKGFKPBEN, Predicate<T> BFLBJMNICKA, [LBBFCMALCPB(true)] out List<int>? MBDEKLPMDOP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x250E870", Offset = "0x250D670", VA = "0x18250E870")]
	public static bool LDEEBLCAEDK<T>(this IReadOnlyList<T> MPMKGFKPBEN, T PIBOOIGHJBI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x250E8C0", Offset = "0x250D6C0", VA = "0x18250E8C0")]
	public static bool LDEEBLCAEDK<T>(this IReadOnlyList<T> MPMKGFKPBEN, T PIBOOIGHJBI, EqualityComparer<T> MDBNCNNPFHB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x250CAF0", Offset = "0x250B8F0", VA = "0x18250CAF0")]
	public static int HFLOMLFMJFB<TElement, TKey>(this IList<TElement> PJGPEGCPPAC, TKey PAAIEFLMDBM, Func<TElement, TKey> PACLDALBEGJ, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D4C10", Offset = "0x6D4010")] Func<TKey, TKey, int> HKDLKEKDNGJ, int NNHNOIMLALG = 0, [Optional] int? MNBBKKLFBKD) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x250C510", Offset = "0x250B310", VA = "0x18250C510")]
	public static int HFLOMLFMJFB<TElement, TKey>(Func<int, TElement> PGGENKLBPDE, int GBFLENOPHJM, TKey PAAIEFLMDBM, Func<TElement, TKey> PACLDALBEGJ, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D4C70", Offset = "0x6D4070")] Func<TKey, TKey, int> HKDLKEKDNGJ, int NNHNOIMLALG = 0, [Optional] int? MNBBKKLFBKD) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2509490", Offset = "0x2508290", VA = "0x182509490")]
	public static List<T> EFEGEFNMEOI<T>(this IReadOnlyList<T> MPMKGFKPBEN, int MNBBKKLFBKD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x250D8C0", Offset = "0x250C6C0", VA = "0x18250D8C0")]
	public static bool KNFLCCOGEOP<T>(this List<T> MPMKGFKPBEN, T PIBOOIGHJBI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x250D110", Offset = "0x250BF10", VA = "0x18250D110")]
	public static void HGIAMKMLDIC<T>(this List<T> MPMKGFKPBEN, IEnumerable<T> BFJIAFJFPDF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x25092F0", Offset = "0x25080F0", VA = "0x1825092F0")]
	public static void CJGLMEKHGBL<T>(this List<T> MPMKGFKPBEN, IEnumerable<T> BFJIAFJFPDF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x25098B0", Offset = "0x25086B0", VA = "0x1825098B0")]
	public static T FIKFBJMIBDG<T>(this List<T> BFJIAFJFPDF, Predicate<T> MCCJOHPCLPK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x250D850", Offset = "0x250C650", VA = "0x18250D850")]
	public static T KIPFFMGDAOO<T>(this List<T> BFJIAFJFPDF, int NNHNOIMLALG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x250C3F0", Offset = "0x250B1F0", VA = "0x18250C3F0")]
	public static bool HCLPJEOHJBN<T>(this List<T> KPGKCLMEHJD, List<T> NMKDCFCBALC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x250D480", Offset = "0x250C280", VA = "0x18250D480")]
	public static T ICAJLANAPJI<T>(this IList<T> MPMKGFKPBEN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x250DAE0", Offset = "0x250C8E0", VA = "0x18250DAE0")]
	public static bool LACHILALHBP<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D4CD0", Offset = "0x6D40D0")] IReadOnlyList<T> MPMKGFKPBEN, int NNHNOIMLALG, [NIPHIJANOKG(false)][PBMBPPOGDAA("This should be `T?` in C# 9.")] out T AJCHMFJLMGE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x250AAD0", Offset = "0x25098D0", VA = "0x18250AAD0")]
	public static bool GCAANMLHOHJ<T>(IReadOnlyList<T> MPMKGFKPBEN, ICollection BFJIAFJFPDF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x250EA00", Offset = "0x250D800", VA = "0x18250EA00")]
	public static void LJKOGDPMIKE<T>(IReadOnlyList<T> MPMKGFKPBEN, ref ICollection BFJIAFJFPDF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x22B5BC0", Offset = "0x22B49C0", VA = "0x1822B5BC0")]
	public static bool MPCBHFCJKME<T>(this IReadOnlyList<T> MPMKGFKPBEN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x25100C0", Offset = "0x250EEC0", VA = "0x1825100C0")]
	public static string PFNICBFKHJC<T>(this IEnumerable<T> MPMKGFKPBEN, string LPKJLMNACLH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2510010", Offset = "0x250EE10", VA = "0x182510010")]
	public static T NJODHAFDPOG<T>(this IList<T> LCNEHOGIJPK) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x250D520", Offset = "0x250C320", VA = "0x18250D520")]
	public static T IENELJBOJEA<T>(this IList<T> LCNEHOGIJPK) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x250C480", Offset = "0x250B280", VA = "0x18250C480")]
	public static void HFDAPPEFOPP<T>(this IList<T> LCNEHOGIJPK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x250D2D0", Offset = "0x250C0D0", VA = "0x18250D2D0")]
	public static void HMHIHJDGHNI<T>(this IList<T> LCNEHOGIJPK, in T MGFMONLLLPD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2509910", Offset = "0x2508710", VA = "0x182509910")]
	public static T GBAPFFIEBMH<T>(this IList<T> LCNEHOGIJPK) where T : notnull
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class NBGAHNDCPAA
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static float CBCKGGBFFPI;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static float NNOKHNACCIP;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static bool FPPAGBDJCLI;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly float DCCKHDDPOFF;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6AF53A0", Offset = "0x6AF41A0", VA = "0x186AF53A0")]
	public static bool FPJAPOPKKMP(float GCKGDDMIIDO, float EJKHFJILHAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4B1C2B0", Offset = "0x4B1B0B0", VA = "0x184B1C2B0")]
	public static float KFNDHOFNALP(float MGFMONLLLPD, float NFEDIMPGFAA, float JEAHNGLGEAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4B1C2D0", Offset = "0x4B1B0D0", VA = "0x184B1C2D0")]
	public static int KFNDHOFNALP(int MGFMONLLLPD, int NFEDIMPGFAA, int JEAHNGLGEAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4B1C290", Offset = "0x4B1B090", VA = "0x184B1C290")]
	public static float CIGLAMANIBP(float MGFMONLLLPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6AF54A0", Offset = "0x6AF42A0", VA = "0x186AF54A0")]
	public static float PDCNIJGANJI(float GCKGDDMIIDO, float EJKHFJILHAC, float DJCNOMGFLPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3B85D70", Offset = "0x3B84B70", VA = "0x183B85D70")]
	public static float FHBPDODNEIL(float GCKGDDMIIDO, float EJKHFJILHAC, float DJCNOMGFLPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6AF52A0", Offset = "0x6AF40A0", VA = "0x186AF52A0")]
	public static float BIPMGOIGBOP(float GCKGDDMIIDO, float EJKHFJILHAC, float MGFMONLLLPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6AF5360", Offset = "0x6AF4160", VA = "0x186AF5360")]
	public static float EOFFCIJAGJM(float GCKGDDMIIDO, float EJKHFJILHAC, float MGFMONLLLPD)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class KHEFJPOIDOD
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1658290", Offset = "0x1657090", VA = "0x181658290")]
	[ONPFBCLBBFN("This should be replaced with the `is not` operator in C# 9.")]
	public static bool CAJEAHELKMI<T>(this object LCNEHOGIJPK, [LBBFCMALCPB(true)] out T AJCHMFJLMGE) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HNIIPALALHA
{
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6AF42C0", Offset = "0x6AF30C0", VA = "0x186AF42C0")]
	public static bool IEGGFOACJDA(this quaternion JGEPMPFGKOG, quaternion CPIBOCOHLLI, float LLKFHBMEBND = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class AFHDFJDLMBL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class ICDNMLKPMMG : HNLALIGCECD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly Random AGDECFJNNNE;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6AF43A0", Offset = "0x6AF31A0", VA = "0x186AF43A0", Slot = "4")]
		public int IAEBPIKIFIC(int EFDOGPEPANK, int HCFPFDGCMPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4330", Offset = "0x6AF3130", VA = "0x186AF4330", Slot = "5")]
		public float CDGLFLKMGFC(float EFDOGPEPANK, float INGPPMNENGA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6AF43D0", Offset = "0x6AF31D0", VA = "0x186AF43D0")]
		private double NOICLCBAMCN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4410", Offset = "0x6AF3210", VA = "0x186AF4410")]
		public ICDNMLKPMMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly HNLALIGCECD EFEGEFNMEOI;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3880", Offset = "0x6AF2680", VA = "0x186AF3880")]
	public static ulong NIFAPHCLJNO()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class FEHKCAHKCKM
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2082510", Offset = "0x2081310", VA = "0x182082510")]
	public static bool FMIIOOPBHDM<T>(this IReadOnlyCollection<T> LCNEHOGIJPK, int NNHNOIMLALG) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class GHAFDIMKMDP
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x208EEE0", Offset = "0x208DCE0", VA = "0x18208EEE0")]
	public static bool BOAPLFBFGDK<T>(this IReadOnlyList<T> LCNEHOGIJPK, int NNHNOIMLALG, [LBBFCMALCPB(true)][PBMBPPOGDAA("This should be `T?` in C# 9.")] out T AJCHMFJLMGE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x208EF70", Offset = "0x208DD70", VA = "0x18208EF70")]
	public static bool DICBJAHJKKG<T>(this IReadOnlyList<T> LCNEHOGIJPK, int NNHNOIMLALG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D4E30", Offset = "0x6D4230")] out global::AJPNGLJDKNK<T> AJCHMFJLMGE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x208F030", Offset = "0x208DE30", VA = "0x18208F030")]
	public static T JDCPNMDEPEK<T>(this IReadOnlyList<T> LCNEHOGIJPK, int NNHNOIMLALG, in T PGEHHGEAOKM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x208EE20", Offset = "0x208DC20", VA = "0x18208EE20")]
	[PBMBPPOGDAA("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T BBLMAMJMGAC<T>(this IReadOnlyList<T> LCNEHOGIJPK, int NNHNOIMLALG) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x208F0B0", Offset = "0x208DEB0", VA = "0x18208F0B0")]
	public static T? PDJFAKKACLN<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D4EE0", Offset = "0x6D42E0")] this IReadOnlyList<T> LCNEHOGIJPK, int NNHNOIMLALG) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class EMLFFODFKAB
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x21A4D60", Offset = "0x21A3B60", VA = "0x1821A4D60")]
	public static T BANNGLOAJDI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D4F40", Offset = "0x6D4340")] this in ReadOnlyMemory<T> LCNEHOGIJPK, int NNHNOIMLALG) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x21A4F80", Offset = "0x21A3D80", VA = "0x1821A4F80")]
	public static bool GHMFPELBJAF<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D4FB0", Offset = "0x6D43B0")] this in ReadOnlyMemory<T> LCNEHOGIJPK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D5020", Offset = "0x6D4420")] in ReadOnlyMemory<T> IDBPJJAKCBN) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x21A4E20", Offset = "0x21A3C20", VA = "0x1821A4E20")]
	public static int FCNNEJAMNPN<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D5090", Offset = "0x6D4490")] this in ReadOnlyMemory<T?> LCNEHOGIJPK, int BJAEDKOGEAN = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x21A4EE0", Offset = "0x21A3CE0", VA = "0x1821A4EE0")]
	public static string GCCDIMNMBBP<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D5100", Offset = "0x6D4500")] this in ReadOnlyMemory<T> LCNEHOGIJPK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class NBNBJHGLBNK
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3484CC0", Offset = "0x3483AC0", VA = "0x183484CC0")]
	public static bool GHMFPELBJAF<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D5170", Offset = "0x6D4570")] this in ReadOnlySpan<T?> LCNEHOGIJPK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D51E0", Offset = "0x6D45E0")] in ReadOnlySpan<T?> IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3484A40", Offset = "0x3483840", VA = "0x183484A40")]
	public static int FCNNEJAMNPN<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D5250", Offset = "0x6D4650")] this in ReadOnlySpan<T?> LCNEHOGIJPK, int BJAEDKOGEAN = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3484B60", Offset = "0x3483960", VA = "0x183484B60")]
	public static string GCCDIMNMBBP<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D52C0", Offset = "0x6D46C0")] this in ReadOnlySpan<T> LCNEHOGIJPK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3484620", Offset = "0x3483420", VA = "0x183484620")]
	public static string DJMHNDHNEIB<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D5330", Offset = "0x6D4730")] this in ReadOnlySpan<T> LCNEHOGIJPK, string IMPFENHNLMK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class DJCIAOMKCBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static IONMFBLNJEM LPKGCCPBEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3CB0", Offset = "0x6AF2AB0", VA = "0x186AF3CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3C20", Offset = "0x6AF2A20", VA = "0x186AF3C20")]
	public static double HCCPDNOFLMK(this IONMFBLNJEM LCNEHOGIJPK, long GIOKOHALJNN)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class JLPNABMHCOB : IONMFBLNJEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Stopwatch BDOBPJMPOHL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long BKGLADJPJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4480", Offset = "0x6AF3280", VA = "0x186AF4480", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x740F40", Offset = "0x73FD40", VA = "0x180740F40")]
	private JLPNABMHCOB(Stopwatch CILOCLCFEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4540", Offset = "0x6AF3340", VA = "0x186AF4540")]
	public static JLPNABMHCOB OCOPICGKAKG(Stopwatch CILOCLCFEGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF44A0", Offset = "0x6AF32A0", VA = "0x186AF44A0")]
	public static JLPNABMHCOB IMFOECGCNAO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class BCDHCLDFEJA
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF3BC0", Offset = "0x6AF29C0", VA = "0x186AF3BC0")]
	public static RigidTransform FINBPOMIDHN(this in RigidTransform LCNEHOGIJPK)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class GKLMMLIJLEG
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4200", Offset = "0x6AF3000", VA = "0x186AF4200")]
	public static RigidTransform IJPBLBNAGOM(RigidTransform BDDGOHNLEJC, RigidTransform PDEDODKBDMO)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class MICHLNKNDCI
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xCAFDA0", Offset = "0xCAEBA0", VA = "0x180CAFDA0")]
	public static bool MPCBHFCJKME(this string NNDKGIFLHME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class KMJOKHDKGAG<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct EIOBGCMOCJN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3234910", Offset = "0x3233710", VA = "0x183234910", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static int LDBABPGPNOM;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static KKINMJMPKND FAPDBKNKBIO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static long BKGLADJPJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3017F50", Offset = "0x3016D50", VA = "0x183017F50")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x30181A0", Offset = "0x3016FA0", VA = "0x1830181A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3018200", Offset = "0x3017000", VA = "0x183018200")]
	public static EIOBGCMOCJN MNBBECMIHGC()
	{
		return default(EIOBGCMOCJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3017FA0", Offset = "0x3016DA0", VA = "0x183017FA0")]
	private static void JFKHONILKPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3018130", Offset = "0x3016F30", VA = "0x183018130")]
	public static void JJEDLPKLPPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct KKINMJMPKND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly IONMFBLNJEM BDOBPJMPOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly long CCOODNGPLKN;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4750", Offset = "0x6AF3550", VA = "0x186AF4750")]
	public KKINMJMPKND(IONMFBLNJEM CILOCLCFEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6AF4630", Offset = "0x6AF3430", VA = "0x186AF4630")]
	public long KBJOPJDFHLG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6AF45A0", Offset = "0x6AF33A0", VA = "0x186AF45A0")]
	public double HCCPDNOFLMK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6AF46C0", Offset = "0x6AF34C0", VA = "0x186AF46C0")]
	public double LANDPAKBMPP()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class KJKGENGPLCO
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xA66960", Offset = "0xA65760", VA = "0x180A66960")]
	public static bool CHAJEGKEMEP(this Type LCNEHOGIJPK, Type IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1658970", Offset = "0x1657770", VA = "0x181658970")]
	public static bool CHAJEGKEMEP<T>(this Type LCNEHOGIJPK) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class JPNLPOGMKNK
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xF043A0", Offset = "0xF031A0", VA = "0x180F043A0")]
	public static uint MBLCCNHELNL(this uint LCNEHOGIJPK, int MNBBKKLFBKD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0xBF3730", Offset = "0xBF2530", VA = "0x180BF3730")]
	public static uint MKJKMDMKNLF(this uint LCNEHOGIJPK, int MNBBKKLFBKD)
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
