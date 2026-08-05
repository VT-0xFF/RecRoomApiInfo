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
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E2CA90", Offset = "0x1E2B490", VA = "0x181E2CA90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x847190", Offset = "0x845B90", VA = "0x180847190")]
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
		[Cpp2IlInjected.Address(RVA = "0x143BBF0", Offset = "0x143A5F0", VA = "0x18143BBF0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CCPJPGMKPNM
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate int JBDJDDCIJMD<T>(in T OLGHNLLKLDL, in T JPDHFMDKHGF);

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class BIGJNGAFLIP<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct OKOLCCACIAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly int ACBJBFDCGOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly int MMHNKCEJLKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public readonly bool BMEHFAHEMPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int DLHAFFGKEJB;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3EE0FC0", Offset = "0x3EDF9C0", VA = "0x183EE0FC0")]
			public OKOLCCACIAF(int ACBJBFDCGOJ, int MMHNKCEJLKE, bool BMEHFAHEMPF)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly T[] CEIEOPGKBME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly T[] GIJNLICIOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly JBDJDDCIJMD<T> FFGLECMAAID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly int DLJIJBCFBMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Func<bool> JDBEAPOEDBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int GGGAKONFDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6ECF40", Offset = "0x6EC340")]
		private readonly BIGJNGAFLIP<T>.OKOLCCACIAF[] FLDAHFKODBK;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x48814C0", Offset = "0x487FEC0", VA = "0x1848814C0")]
		public BIGJNGAFLIP(T[] CEIEOPGKBME, JBDJDDCIJMD<T> FFGLECMAAID, int DLJIJBCFBMH, Func<bool> JDBEAPOEDBJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6ECFA0", Offset = "0x6EC3A0")] T[] JBKEMCPPAJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4880DD0", Offset = "0x487F7D0", VA = "0x184880DD0")]
		public bool AABBMNOLELJ()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate U BPIJJKJJPHF<T, U>(int GMDGOFGCEPJ, int KHLNHINLHNB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6ED000", Offset = "0x6EC400")] in ReadOnlySpan<T> BKGILBBCHPF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x30D3CC0", Offset = "0x30D26C0", VA = "0x1830D3CC0")]
	public static ReadOnlyMemory<T> JBDLJJNDNHJ<T>(this T[] IKHBPJOEIEB) where T : notnull
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x344D920", Offset = "0x344C320", VA = "0x18344D920")]
	public static T[] GDPKNMEEMGD<T>(int IMMPKDAEONJ, T EAEEEOLOLFO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x344DAA0", Offset = "0x344C4A0", VA = "0x18344DAA0")]
	public static void GJJMFFBHBBA<T>(this T[] GCKHNPEGGAM, T EAEEEOLOLFO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1E7CC20", Offset = "0x1E7B620", VA = "0x181E7CC20")]
	public static void OBKHDAPNKKO<T>(this T[] HPOICFFOIAP, int HLFOHCODFGN, int CNIHJCFDMPA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x344E440", Offset = "0x344CE40", VA = "0x18344E440")]
	private static void PKFACHHNKNA<T>(this T[] IKHBPJOEIEB, int EPMLCKJLADF, int PCNLCEMGNAF, T[] EHBPAFKHADK, int KGJGNNELKLH, int ONHFNKKMJLJ, T[] MIMDGHHHHPD, int GGIIBNKAINL, JBDJDDCIJMD<T> FFGLECMAAID) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x344CF90", Offset = "0x344B990", VA = "0x18344CF90")]
	public static void EKPEGFKALPL<T>(this T[] IKHBPJOEIEB, int ACBJBFDCGOJ, int HGMGPFAJPJI, JBDJDDCIJMD<T> FFGLECMAAID) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x344E2F0", Offset = "0x344CCF0", VA = "0x18344E2F0")]
	public static BIGJNGAFLIP<T> NLGLNNPPCHO<T>(this T[] IKHBPJOEIEB, JBDJDDCIJMD<T> FFGLECMAAID, int DLJIJBCFBMH, Func<bool> JDBEAPOEDBJ, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6ECE60", Offset = "0x6EC260")] T[] JBKEMCPPAJA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x344E220", Offset = "0x344CC20", VA = "0x18344E220")]
	public static T[] JNECJFMIGPJ<T>(this T[] HPOICFFOIAP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x344CC80", Offset = "0x344B680", VA = "0x18344CC80")]
	public static T[] EDCNBLCAMBE<T>(this T[] GGEKMEKHPJM, T IPEFKMLMDHM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x344DC30", Offset = "0x344C630", VA = "0x18344DC30")]
	public static T[] JAJCIIJOIEL<T>(this T[] GGEKMEKHPJM, int ALJOMNDNEBM, T IPEFKMLMDHM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x344E240", Offset = "0x344CC40", VA = "0x18344E240")]
	public static T[] LCMJEKGABFN<T>(this T[] GGEKMEKHPJM, int ALJOMNDNEBM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x344CD60", Offset = "0x344B760", VA = "0x18344CD60")]
	public static T[] EGLNCGIKFGO<T>(this T[] GGEKMEKHPJM, int ALJOMNDNEBM, T IPEFKMLMDHM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x344D3E0", Offset = "0x344BDE0", VA = "0x18344D3E0")]
	public static U[] FGLMAPLFJIN<U, T>(this T[] FGILJLADPAP, int FGHNOGGJBPB, BPIJJKJJPHF<T, U> IJNCMCGPPHC) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1E2AFB0", Offset = "0x1E299B0", VA = "0x181E2AFB0")]
	public static byte[] LPMHLGNLKHA(this byte[] IKHBPJOEIEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1E2ADB0", Offset = "0x1E297B0", VA = "0x181E2ADB0")]
	public static byte[] EGBCBKKILKK(this byte[] IKHBPJOEIEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JEKNLOBEGLG
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x39C99C0", Offset = "0x39C83C0", VA = "0x1839C99C0")]
	public static void GDFLELNAEGM<T>(this ICollection<T> IKHBPJOEIEB, IEnumerable<T> ELHMOBCGDNG) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JCCJJMCADIK
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x39C7020", Offset = "0x39C5A20", VA = "0x1839C7020")]
	public static void FOFKKPKIHEJ<K, V>(this IDictionary<K, V> IKHBPJOEIEB, in K IGFDDANAMMH, in V MFBGAMJDOKA, Func<V, V, V> MLNIAGMGANG) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x39C7D50", Offset = "0x39C6750", VA = "0x1839C7D50")]
	public static void MBIOEOODEGA<K, V>(this IDictionary<K, List<V>> IKHBPJOEIEB, in K IGFDDANAMMH, in V MFBGAMJDOKA) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x39C5F90", Offset = "0x39C4990", VA = "0x1839C5F90")]
	public static TVal BFOGGBOBEAH<TVal, TKey>(this IDictionary<TKey, TVal> AHKMGODEDKL, in TKey IGFDDANAMMH, [Optional][GJMCDPCEPFO("`default!` shouldn't be necessary in C# 9")] TVal NEHANGBEOBM) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x39C5C00", Offset = "0x39C4600", VA = "0x1839C5C00")]
	public static TVal BFOGGBOBEAH<TVal, TKey>(this IDictionary<TKey, TVal> AHKMGODEDKL, in TKey IGFDDANAMMH, Func<TVal> BMDCGCMNKDE) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x39C6F30", Offset = "0x39C5930", VA = "0x1839C6F30")]
	public static TValue DKMFMMMLDFE<TValue, TKey>(this IDictionary<TKey, TValue> AHKMGODEDKL, in TKey IGFDDANAMMH, [Optional][GJMCDPCEPFO("`default!` and null-oblivious region shouldn't be necessary in C# 9")] in TValue NEHANGBEOBM)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x39C76F0", Offset = "0x39C60F0", VA = "0x1839C76F0")]
	public static V KLHNGLECANB<V, K>(this IDictionary<K, V> IKHBPJOEIEB, in K IGFDDANAMMH) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x39C5B70", Offset = "0x39C4570", VA = "0x1839C5B70")]
	public static T2[] BBOEFAOBLKF<T2, T1>(this Dictionary<T1, T2>.ValueCollection EFLMPCABIMJ) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x39C82E0", Offset = "0x39C6CE0", VA = "0x1839C82E0")]
	public static bool PLIOJAFPAGG<TKey, TValue>(this IDictionary<TKey, TValue> IKHBPJOEIEB, TKey IGFDDANAMMH, TValue MFBGAMJDOKA) where TKey : notnull where TValue : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GKBHANNGJIP
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate bool NACFEEDMFPN<TArgs, T>(in TArgs LIKLGHJBPPH, T FPEJLKINELB);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate U GIABBIJKNKG<TArg, U>(in TArg NMPNMHNJPAA);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate U BBHEGHMOHLB<TArg, T, U>(in TArg NMPNMHNJPAA, T FHNHAAJIPME);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate U DOAALIEKIIH<TArg, T, U>(in TArg NMPNMHNJPAA, IEnumerable<T> KNIJIHCLOLF);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate U KFPADOONPFB<TArg, T, U>(in TArg NMPNMHNJPAA, T FHNHAAJIPME);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct OCKKONMJEDG<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8A60", Offset = "0x3EC7460", VA = "0x183EC8A60")]
		[GJMCDPCEPFO("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) KEHCNJMGFFK(T ECLGNIIHPEJ)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8AD0", Offset = "0x3EC74D0", VA = "0x183EC8AD0")]
		[GJMCDPCEPFO("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) MCGNGBLINFI(IEnumerable<T> KBNPBAEIPKG)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class OHPHJKAEEIK<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public OHPHJKAEEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x34E7150", Offset = "0x34E5B50", VA = "0x1834E7150")]
		internal bool <SetEqual>b__0(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3EDBEB0", Offset = "0x3EDA8B0", VA = "0x183EDBEB0")]
		internal bool <SetEqual>b__1(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x30D93C0", Offset = "0x30D7DC0", VA = "0x1830D93C0")]
	public static bool LBNOPLEOHLD<T, TArgs>(this IEnumerable<T> IKHBPJOEIEB, in TArgs LIKLGHJBPPH, NACFEEDMFPN<TArgs, T> DBEGDHLAGDJ) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x30D8070", Offset = "0x30D6A70", VA = "0x1830D8070")]
	public static U JAIEBMPOIHH<U, T>(this IEnumerable<T> IKHBPJOEIEB, Func<U> OHNCDEOELAA, Func<T, U> ECLGNIIHPEJ, Func<IEnumerable<T>, U> KBNPBAEIPKG) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x30D4540", Offset = "0x30D2F40", VA = "0x1830D4540")]
	public static bool BGMLMDJMAJP<T, TArgs>(this IEnumerable<T> IKHBPJOEIEB, in TArgs LIKLGHJBPPH, NACFEEDMFPN<TArgs, T> DBEGDHLAGDJ) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x30D4D80", Offset = "0x30D3780", VA = "0x1830D4D80")]
	public static U DIECJLOPAFH<U, T, TArg>(this IEnumerable<T> IKHBPJOEIEB, in TArg NMPNMHNJPAA, GIABBIJKNKG<TArg, U> OHNCDEOELAA, BBHEGHMOHLB<TArg, T, U> ECLGNIIHPEJ, DOAALIEKIIH<TArg, T, U> KBNPBAEIPKG) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x30D78E0", Offset = "0x30D62E0", VA = "0x1830D78E0")]
	public static IEnumerable<U> GNDKMJKDIJA<U, T, TArg>(this IEnumerable<T> IKHBPJOEIEB, in TArg NMPNMHNJPAA, KFPADOONPFB<TArg, T, U> FKIKFAMILFK) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x30D7350", Offset = "0x30D5D50", VA = "0x1830D7350")]
	public static IEnumerable<T> HPJAAMKGAKI<T>(params IEnumerable<T>[] GLMKBIGCLEN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x30D5100", Offset = "0x30D3B00", VA = "0x1830D5100")]
	public static bool EBBNBNONFIJ<T>(this IEnumerable<T> BMKGEKNDEIG, IEnumerable<T> EHBPAFKHADK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x30D7350", Offset = "0x30D5D50", VA = "0x1830D7350")]
	public static IEnumerable<(TKey?, TValue?)>? NAOJGFJMPPG<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6ED290", Offset = "0x6EC690")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? IKHBPJOEIEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x30D7700", Offset = "0x30D6100", VA = "0x1830D7700")]
	public static IEnumerable<T> GJLLPIEBHAB<T, TKey>(this IEnumerable<T> GJJDBCFJNDK, Func<T, TKey> GOAAEAHOICB) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x294F910", Offset = "0x294E310", VA = "0x18294F910")]
	[IteratorStateMachine(typeof(KACIKADFFHA))]
	public static IEnumerable<T> EFPNIDMEBBP<T, U>(this IEnumerable<T> IKHBPJOEIEB, IEnumerable<U> EHBPAFKHADK, [Optional][GJMCDPCEPFO("`default!` shouldn't be necessary in C# 9")] T EAEEEOLOLFO) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1E84DC0", Offset = "0x1E837C0", VA = "0x181E84DC0")]
	public static T GFBKGBCEEJF<T>(this IEnumerable<T> BMKGEKNDEIG, T NEHANGBEOBM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x30D76B0", Offset = "0x30D60B0", VA = "0x1830D76B0")]
	public static T GFBKGBCEEJF<T>(this IEnumerable<T> BMKGEKNDEIG, T NEHANGBEOBM, Func<T, bool> DBEGDHLAGDJ) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x30D4290", Offset = "0x30D2C90", VA = "0x1830D4290")]
	[IteratorStateMachine(typeof(AGJFMCIIGHP))]
	public static IEnumerable<(T, global::DOMIPLFCMFE<T>)> BFEDGGGFPHC<T>(this IEnumerable<T> IKHBPJOEIEB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x30D4C90", Offset = "0x30D3690", VA = "0x1830D4C90")]
	public static bool DFAAMPGALKM<T>(this IEnumerable<T> IKHBPJOEIEB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x30D7350", Offset = "0x30D5D50", VA = "0x1830D7350")]
	public static IEnumerable<global::FOLNIBIFEAJ<T>> EOGKCECFNOA<T>(this IEnumerable<T> IKHBPJOEIEB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x30D95E0", Offset = "0x30D7FE0", VA = "0x1830D95E0")]
	public static bool MPMONFPIFAG<T>(this IEnumerable<T> IKHBPJOEIEB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x30D5380", Offset = "0x30D3D80", VA = "0x1830D5380")]
	public static IEnumerable<T> EHGOEIEBFNK<T>(this IEnumerable<T> IKHBPJOEIEB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x294F7D0", Offset = "0x294E1D0", VA = "0x18294F7D0")]
	[IteratorStateMachine(typeof(OELBELGFBON))]
	public static IEnumerable<U> NKJMCGLBKLB<U, T>(this IEnumerable<T> IKHBPJOEIEB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6ED430", Offset = "0x6EC830")] Func<OCKKONMJEDG<U>, T, (bool Zero, U One, IEnumerable<U> Many)> GEDCOEKHBPP) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x30D48A0", Offset = "0x30D32A0", VA = "0x1830D48A0")]
	public static int CDODEGKMLIF<T>(this IEnumerable<T> IKHBPJOEIEB, int GPBHGNBJNIK = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x30D7510", Offset = "0x30D5F10", VA = "0x1830D7510")]
	public static bool FONLCLLLAKL<T>(this IEnumerable<T> IKHBPJOEIEB, IEnumerable<T> EHBPAFKHADK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x30D9600", Offset = "0x30D8000", VA = "0x1830D9600")]
	public static (IEnumerable<T>, IEnumerable<T>) NABFDLLOEKN<T>(this IEnumerable<T> IKHBPJOEIEB, Func<T, bool> BEINDIICJHB) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x30D83A0", Offset = "0x30D6DA0", VA = "0x1830D83A0")]
	public static string JDEJKONHMDI<T>(this IEnumerable<T> IKHBPJOEIEB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x30D7D20", Offset = "0x30D6720", VA = "0x1830D7D20")]
	public static Dictionary<TKey?, TValue?>? INOBJKMHNMG<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6ED520", Offset = "0x6EC920")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? BMKGEKNDEIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x30D7D20", Offset = "0x30D6720", VA = "0x1830D7D20")]
	public static Dictionary<TKey?, TValue?>? INOBJKMHNMG<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6ED580", Offset = "0x6EC980")] this IEnumerable<(TKey? Key, TValue? Value)>? BMKGEKNDEIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2918CA0", Offset = "0x29176A0", VA = "0x182918CA0")]
	public static HashSet<T> NMHLGMNPBFJ<T>(this IEnumerable<T> IKHBPJOEIEB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x30D6050", Offset = "0x30D4A50", VA = "0x1830D6050")]
	public static string EHJHBCLKMMB<T>(this IEnumerable<T> IKHBPJOEIEB, string NILJKOMKIAN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x294F690", Offset = "0x294E090", VA = "0x18294F690")]
	[IteratorStateMachine(typeof(CCMNHAMILDE))]
	public static IEnumerable<(T, U)> BIJEICNMLJN<T, U>(this IEnumerable<T> OLGHNLLKLDL, IEnumerable<U> JPDHFMDKHGF) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x30D8A10", Offset = "0x30D7410", VA = "0x1830D8A10")]
	public static IEnumerable<V> JDMINPNBJFD<V, T, U>(this IEnumerable<T> IKHBPJOEIEB, IEnumerable<U> EHBPAFKHADK, Func<T, U, V> PBLOLACNDME, [Optional][GJMCDPCEPFO("`default!` shouldn't be necessary in C# 9")] T EOEHGHFEKGN, [Optional][GJMCDPCEPFO("`default!` shouldn't be necessary in C# 9")] U DIGFDGBFIPC) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x30D8AA0", Offset = "0x30D74A0", VA = "0x1830D8AA0")]
	public static IEnumerable<(T, U)> JDMINPNBJFD<T, U>(this IEnumerable<T> IKHBPJOEIEB, IEnumerable<U> EHBPAFKHADK, [Optional][GJMCDPCEPFO("`default!` shouldn't be necessary in C# 9")] T EOEHGHFEKGN, [Optional][GJMCDPCEPFO("`default!` shouldn't be necessary in C# 9")] U DIGFDGBFIPC) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class FNBKHADKJEA
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3752170", Offset = "0x3750B70", VA = "0x183752170")]
	public static bool FAMGFGIDDEC<T, U>(this T IKHBPJOEIEB, in U OMHIFHKMIMJ) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3752370", Offset = "0x3750D70", VA = "0x183752370")]
	public static bool LHKENBAFDEG<T>(ref T IKHBPJOEIEB, T EHBPAFKHADK) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class FHADBKCOPGO
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1E2BE00", Offset = "0x1E2A800", VA = "0x181E2BE00")]
	public static bool CDNDEFMAJLM(this in float3 MGFKDMJBGAK, float3 LPDJCHOFJLE, float GCDCGLFOBIC = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class AFBCMBACBLN
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x254F450", Offset = "0x254DE50", VA = "0x18254F450")]
	public static void EILDKCIIKFA<T>(this T ENLKJOJFGLO, Action<T> JGAFGAGDOGM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x254F3B0", Offset = "0x254DDB0", VA = "0x18254F3B0")]
	public static V BOPHPNKOOPJ<V, T>(this T ENLKJOJFGLO, Func<T, V> JGAFGAGDOGM, [Optional][GJMCDPCEPFO("`default!` shouldn't be necessary in C# 9")] V NEHANGBEOBM) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x254F5E0", Offset = "0x254DFE0", VA = "0x18254F5E0")]
	public static T? LOBEPKHJBMC<T>(this T IKHBPJOEIEB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2548FD0", Offset = "0x25479D0", VA = "0x182548FD0")]
	[IteratorStateMachine(typeof(CLAHFMOGFNL))]
	public static IEnumerable<T> GJPPOFAPFKP<T>(this T IKHBPJOEIEB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x254F2D0", Offset = "0x254DCD0", VA = "0x18254F2D0")]
	public static T[] AFNLCAMOMMI<T>(this T IKHBPJOEIEB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class ENMBKJJCEMC
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B430", Offset = "0x1E29E30", VA = "0x181E2B430")]
	private static byte[] CJMNKLHLOHL(int FEDBFLKOJFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B5B0", Offset = "0x1E29FB0", VA = "0x181E2B5B0")]
	private static byte[] IGHOLLHCABK(long LLKHMFAKGNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B530", Offset = "0x1E29F30", VA = "0x181E2B530")]
	private static byte[] EAHKKBHMNFI(ulong LLKHMFAKGNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1E2BC90", Offset = "0x1E2A690", VA = "0x181E2BC90")]
	public static Guid OLIFMKOJDLI(params Guid[] PDALOOHALAO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B820", Offset = "0x1E2A220", VA = "0x181E2B820")]
	public static Guid KMLFLFAGFOK(in Guid OKGNKPNGDAK, int ALJOMNDNEBM, int LHIPGOMOMEB = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B760", Offset = "0x1E2A160", VA = "0x181E2B760")]
	public static Guid KMLFLFAGFOK(in Guid OKGNKPNGDAK, long ALJOMNDNEBM, int LHIPGOMOMEB = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B6A0", Offset = "0x1E2A0A0", VA = "0x181E2B6A0")]
	public static Guid KMLFLFAGFOK(in Guid OKGNKPNGDAK, ulong ALJOMNDNEBM, int LHIPGOMOMEB = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B630", Offset = "0x1E2A030", VA = "0x181E2B630")]
	public static Guid KMLFLFAGFOK(in Guid OKGNKPNGDAK, in Guid NDIKHKAGGFF, int LHIPGOMOMEB = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B8E0", Offset = "0x1E2A2E0", VA = "0x181E2B8E0")]
	private static Guid KMLFLFAGFOK(in Guid OKGNKPNGDAK, byte[] HBIOEOPPBOO, int LHIPGOMOMEB = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1E2BBB0", Offset = "0x1E2A5B0", VA = "0x181E2BBB0")]
	private static void MHPADHIHOKA(byte[] GDCMPFDFIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B4B0", Offset = "0x1E29EB0", VA = "0x181E2B4B0")]
	private static void DPMJIPDGHOP(byte[] GDCMPFDFIDH, int BBDDOKEDLCI, int NAHMKAGEEEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface MIMMHMJFNBK
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CPNHMJNOIFF MCCAOCKKBBG();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface CPNHMJNOIFF : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool HJANPAMPGGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLEICBHCEBH();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface NPKAPNLDCBE
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int FELGMGCNPJG(int AEPLKIDICFN, int EMKECFFJOLI);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float PGKODMIBHPP(float IMNFOCOFEMJ, float NOCFHDKKPBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface LBBAGFJMMPC
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	long IAEEOOLABAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class KAJCEOAHCGM
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C740", Offset = "0x1E2B140", VA = "0x181E2C740")]
	public static int BDEMLOPJFOJ(this int IKHBPJOEIEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C800", Offset = "0x1E2B200", VA = "0x181E2C800")]
	public static int DHFOHKPJJHO(this int IKHBPJOEIEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C7B0", Offset = "0x1E2B1B0", VA = "0x181E2C7B0")]
	public static int CNNJEFKDJMC(this int IKHBPJOEIEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C840", Offset = "0x1E2B240", VA = "0x181E2C840")]
	public static int MJCHDFKHLPC(this int IKHBPJOEIEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xE183E0", Offset = "0xE16DE0", VA = "0x180E183E0")]
	public static int MJAGDFBAIJP(this int IKHBPJOEIEB, int HGMGPFAJPJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x149D610", Offset = "0x149C010", VA = "0x18149D610")]
	public static int DEANJMBFILF(this int IKHBPJOEIEB, int HGMGPFAJPJI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class IMHNKIKFBCJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3463EE0", Offset = "0x34628E0", VA = "0x183463EE0")]
	public static void NIELGFEEDGF<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EDF00", Offset = "0x6ED300")] this in KeyValuePair<TKey, TValue> IKHBPJOEIEB, out TKey IGFDDANAMMH, out TValue MFBGAMJDOKA) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3463C80", Offset = "0x3462680", VA = "0x183463C80")]
	public static (TKey?, TValue?) IMEDMFDKDGL<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EDF70", Offset = "0x6ED370")] this in KeyValuePair<TKey?, TValue?> IKHBPJOEIEB)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3463DC0", Offset = "0x34627C0", VA = "0x183463DC0")]
	public static KeyValuePair<TKey?, UValue?> JEJAIADIPNJ<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EDFE0", Offset = "0x6ED3E0")] this KeyValuePair<TKey?, TValue?> IKHBPJOEIEB, UValue MFBGAMJDOKA)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class CLFJCMKBNCK
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class LHOFKPIAGJB<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public LHOFKPIAGJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2A13230", Offset = "0x2A11C30", VA = "0x182A13230")]
		internal TElement <BinarySearch>b__0(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class MMGBMMIFBID<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Random rng;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		public MMGBMMIFBID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x99B200", Offset = "0x999C00", VA = "0x18099B200")]
		internal int <Random>b__0(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3459810", Offset = "0x3458210", VA = "0x183459810")]
	public static int ECEMJGPMBCO<T>(this IReadOnlyList<T> HPOICFFOIAP, T MFBGAMJDOKA) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x345A130", Offset = "0x3458B30", VA = "0x18345A130")]
	public static int FDBJNLCDMOP<T>(this IReadOnlyList<T> HPOICFFOIAP, T MFBGAMJDOKA) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x345C2D0", Offset = "0x345ACD0", VA = "0x18345C2D0")]
	public static void GDFLELNAEGM<T>(this HashSet<T> NCIJFFICMFE, IEnumerable<T> ELHMOBCGDNG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x345E450", Offset = "0x345CE50", VA = "0x18345E450")]
	public static void NACBDMFIPKC<T>(this IList<T> ECNPNAMGIHB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x345E4D0", Offset = "0x345CED0", VA = "0x18345E4D0")]
	public static void NACBDMFIPKC<T>(this IList<T> ECNPNAMGIHB, int ACAAKNEDJCP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x345E360", Offset = "0x345CD60", VA = "0x18345E360")]
	public static List<T> LMFAGLCPIGF<T>(this List<T> PJLNFOKAGGK, Predicate<T> KEJJCNMBGLA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3459BD0", Offset = "0x34585D0", VA = "0x183459BD0")]
	public static int ECEMJGPMBCO<T>(this IReadOnlyList<T> ECNPNAMGIHB, Predicate<T> DBEGDHLAGDJ) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x345DC60", Offset = "0x345C660", VA = "0x18345DC60")]
	public static bool JEAGDIOACJA<T>(this IReadOnlyList<T> ECNPNAMGIHB, Predicate<T> DBEGDHLAGDJ, [OFMILDPNIPJ(true)] out List<int>? CPMFGOIFOOJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3458740", Offset = "0x3457140", VA = "0x183458740")]
	public static bool AAFBPIPDPOL<T>(this IReadOnlyList<T> ECNPNAMGIHB, T FPEJLKINELB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3458790", Offset = "0x3457190", VA = "0x183458790")]
	public static bool AAFBPIPDPOL<T>(this IReadOnlyList<T> ECNPNAMGIHB, T FPEJLKINELB, EqualityComparer<T> KOKADNNACHM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x345D350", Offset = "0x345BD50", VA = "0x18345D350")]
	public static int ICOONOIHMAO<TElement, TKey>(this IList<TElement> EJNJBEBJLMN, TKey JINMACGPDOI, Func<TElement, TKey> KMIBBFPBFJG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE080", Offset = "0x6ED480")] Func<TKey, TKey, int> FFGLECMAAID, int ALJOMNDNEBM = 0, [Optional] int? HGMGPFAJPJI) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x345D060", Offset = "0x345BA60", VA = "0x18345D060")]
	public static int ICOONOIHMAO<TElement, TKey>(Func<int, TElement> CNDCJJKDBMB, int JBCABINLNOP, TKey JINMACGPDOI, Func<TElement, TKey> KMIBBFPBFJG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE0E0", Offset = "0x6ED4E0")] Func<TKey, TKey, int> FFGLECMAAID, int ALJOMNDNEBM = 0, [Optional] int? HGMGPFAJPJI) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3458F20", Offset = "0x3457920", VA = "0x183458F20")]
	public static List<T> DHINMEKAOPK<T>(this IReadOnlyList<T> ECNPNAMGIHB, int HGMGPFAJPJI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x345E140", Offset = "0x345CB40", VA = "0x18345E140")]
	public static bool LENDNBLONKF<T>(this List<T> ECNPNAMGIHB, T FPEJLKINELB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3459180", Offset = "0x3457B80", VA = "0x183459180")]
	public static void EBBMINIFBAK<T>(this List<T> ECNPNAMGIHB, IEnumerable<T> PJLNFOKAGGK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x345CE00", Offset = "0x345B800", VA = "0x18345CE00")]
	public static void HEOHJOBENDL<T>(this List<T> ECNPNAMGIHB, IEnumerable<T> PJLNFOKAGGK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x345E0E0", Offset = "0x345CAE0", VA = "0x18345E0E0")]
	public static T JMENKAHMNEN<T>(this List<T> PJLNFOKAGGK, Predicate<T> KEJJCNMBGLA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x290ED90", Offset = "0x290D790", VA = "0x18290ED90")]
	public static T NPIPFLMPCAL<T>(this List<T> PJLNFOKAGGK, int ALJOMNDNEBM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x345C240", Offset = "0x345AC40", VA = "0x18345C240")]
	public static bool FGLBNKGGIIF<T>(this List<T> JIIHBDHELFA, List<T> KJAEACGNFJM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3458E80", Offset = "0x3457880", VA = "0x183458E80")]
	public static T CPAFGGMHFKM<T>(this IList<T> ECNPNAMGIHB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x345CFA0", Offset = "0x345B9A0", VA = "0x18345CFA0")]
	public static bool HFPAAGOEOCC<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE140", Offset = "0x6ED540")] IReadOnlyList<T> ECNPNAMGIHB, int ALJOMNDNEBM, [DDPOCPLIPKP(false)][GJMCDPCEPFO("This should be `T?` in C# 9.")] out T MIMDGHHHHPD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x345B130", Offset = "0x3459B30", VA = "0x18345B130")]
	public static bool FDDMPKEGDIM<T>(IReadOnlyList<T> ECNPNAMGIHB, ICollection PJLNFOKAGGK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x345A010", Offset = "0x3458A10", VA = "0x18345A010")]
	public static void EGBMCOINPDP<T>(IReadOnlyList<T> ECNPNAMGIHB, ref ICollection PJLNFOKAGGK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x291A0E0", Offset = "0x2918AE0", VA = "0x18291A0E0")]
	public static bool EIOMKIOIMNJ<T>(this IReadOnlyList<T> ECNPNAMGIHB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3459E30", Offset = "0x3458830", VA = "0x183459E30")]
	public static string EEGLBMFILKF<T>(this IEnumerable<T> ECNPNAMGIHB, string HNHFPCNFGKE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3458C20", Offset = "0x3457620", VA = "0x183458C20")]
	public static T BGKGDLFDOCF<T>(this IList<T> IKHBPJOEIEB) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x290EAF0", Offset = "0x290D4F0", VA = "0x18290EAF0")]
	public static T NEDBCGILCFB<T>(this IList<T> IKHBPJOEIEB) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x290EE00", Offset = "0x290D800", VA = "0x18290EE00")]
	public static void OOHPEOKMHKD<T>(this IList<T> IKHBPJOEIEB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3458CD0", Offset = "0x34576D0", VA = "0x183458CD0")]
	public static void CACNCHOHHFC<T>(this IList<T> IKHBPJOEIEB, in T MFBGAMJDOKA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x34588D0", Offset = "0x34572D0", VA = "0x1834588D0")]
	public static T ABCNEEJJJPA<T>(this IList<T> IKHBPJOEIEB) where T : notnull
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class HMMHBBBKLOE
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static float BOOKIIIABHL;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static float ECIOOHOGGGA;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static bool FPPMEPBFJII;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly float NOABDKJEIGM;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C1E0", Offset = "0x1E2ABE0", VA = "0x181E2C1E0")]
	public static bool GPOENEOCHDA(float MGFKDMJBGAK, float LPDJCHOFJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C0E0", Offset = "0x1E2AAE0", VA = "0x181E2C0E0")]
	public static float CPGNLLMOFLG(float MFBGAMJDOKA, float IPPOHHHCAKI, float JJNBFMOBAFD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C0C0", Offset = "0x1E2AAC0", VA = "0x181E2C0C0")]
	public static int CPGNLLMOFLG(int MFBGAMJDOKA, int IPPOHHHCAKI, int JJNBFMOBAFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C100", Offset = "0x1E2AB00", VA = "0x181E2C100")]
	public static float ELKDMABNGLO(float MFBGAMJDOKA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C2E0", Offset = "0x1E2ACE0", VA = "0x181E2C2E0")]
	public static float JJPAOLFANJM(float MGFKDMJBGAK, float LPDJCHOFJLE, float ENLKJOJFGLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0xB6D490", Offset = "0xB6BE90", VA = "0x180B6D490")]
	public static float KHJEFJGJJKA(float MGFKDMJBGAK, float LPDJCHOFJLE, float ENLKJOJFGLO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C120", Offset = "0x1E2AB20", VA = "0x181E2C120")]
	public static float FECBPCMLIOM(float MGFKDMJBGAK, float LPDJCHOFJLE, float MFBGAMJDOKA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C080", Offset = "0x1E2AA80", VA = "0x181E2C080")]
	public static float ADHLHBMNFAJ(float MGFKDMJBGAK, float LPDJCHOFJLE, float MFBGAMJDOKA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class EIEOHKENNEA
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x321DF20", Offset = "0x321C920", VA = "0x18321DF20")]
	[FGCFFGCIPKG("This should be replaced with the `is not` operator in C# 9.")]
	public static bool OOPKIMNJEMH<T>(this object IKHBPJOEIEB, [OFMILDPNIPJ(true)] out T MIMDGHHHHPD) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class LIDNOAOKJLD
{
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C850", Offset = "0x1E2B250", VA = "0x181E2C850")]
	public static bool CDNDEFMAJLM(this quaternion OLGHNLLKLDL, quaternion JPDHFMDKHGF, float ELMGMJHGIEC = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class OBHMJIAONMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class EFJLJBMFPLJ : NPKAPNLDCBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly Random EPABIHMANDP;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B320", Offset = "0x1E29D20", VA = "0x181E2B320", Slot = "4")]
		public int FELGMGCNPJG(int IMNFOCOFEMJ, int HPNOCGINPCE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B350", Offset = "0x1E29D50", VA = "0x181E2B350", Slot = "5")]
		public float PGKODMIBHPP(float IMNFOCOFEMJ, float NOCFHDKKPBJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B2E0", Offset = "0x1E29CE0", VA = "0x181E2B2E0")]
		private double EOKNDNLPOCL()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B3C0", Offset = "0x1E29DC0", VA = "0x181E2B3C0")]
		public EFJLJBMFPLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly NPKAPNLDCBE DHINMEKAOPK;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1E2CB20", Offset = "0x1E2B520", VA = "0x181E2CB20")]
	public static ulong IDBOKMHPNIF()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HBCAEPJNONL
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x30DE240", Offset = "0x30DCC40", VA = "0x1830DE240")]
	public static bool JEIFAJDFCIF<T>(this IReadOnlyCollection<T> IKHBPJOEIEB, int ALJOMNDNEBM) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class EKFONOCKBME
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3222220", Offset = "0x3220C20", VA = "0x183222220")]
	public static bool JBPBACKGAAO<T>(this IReadOnlyList<T> IKHBPJOEIEB, int ALJOMNDNEBM, [OFMILDPNIPJ(true)][GJMCDPCEPFO("This should be `T?` in C# 9.")] out T MIMDGHHHHPD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3221F70", Offset = "0x3220970", VA = "0x183221F70")]
	public static bool ACMGIMBGMKE<T>(this IReadOnlyList<T> IKHBPJOEIEB, int ALJOMNDNEBM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE2A0", Offset = "0x6ED6A0")] out global::FOLNIBIFEAJ<T> MIMDGHHHHPD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3222110", Offset = "0x3220B10", VA = "0x183222110")]
	public static T DNFBMLKCHGO<T>(this IReadOnlyList<T> IKHBPJOEIEB, int ALJOMNDNEBM, in T DJBDNCMCPNI) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x32220E0", Offset = "0x3220AE0", VA = "0x1832220E0")]
	[GJMCDPCEPFO("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T CELOAFPDNCC<T>(this IReadOnlyList<T> IKHBPJOEIEB, int ALJOMNDNEBM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3222030", Offset = "0x3220A30", VA = "0x183222030")]
	public static T? BICMAOACHDB<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE350", Offset = "0x6ED750")] this IReadOnlyList<T> IKHBPJOEIEB, int ALJOMNDNEBM) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class FOKNAJNFFEL
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3752560", Offset = "0x3750F60", VA = "0x183752560")]
	public static T ABMJNALEGDK<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE3B0", Offset = "0x6ED7B0")] this in ReadOnlyMemory<T> IKHBPJOEIEB, int ALJOMNDNEBM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3752780", Offset = "0x3751180", VA = "0x183752780")]
	public static bool PNAKJHNNINF<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE420", Offset = "0x6ED820")] this in ReadOnlyMemory<T> IKHBPJOEIEB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE490", Offset = "0x6ED890")] in ReadOnlyMemory<T> EHBPAFKHADK) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3752620", Offset = "0x3751020", VA = "0x183752620")]
	public static int CDODEGKMLIF<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE500", Offset = "0x6ED900")] this in ReadOnlyMemory<T?> IKHBPJOEIEB, int GPBHGNBJNIK = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x37526E0", Offset = "0x37510E0", VA = "0x1837526E0")]
	public static string JDEJKONHMDI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE570", Offset = "0x6ED970")] this in ReadOnlyMemory<T> IKHBPJOEIEB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class FLGHGBEAHKL
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3750ED0", Offset = "0x374F8D0", VA = "0x183750ED0")]
	public static bool PNAKJHNNINF<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE5E0", Offset = "0x6ED9E0")] this in ReadOnlySpan<T?> IKHBPJOEIEB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE650", Offset = "0x6EDA50")] in ReadOnlySpan<T?> EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3750830", Offset = "0x374F230", VA = "0x183750830")]
	public static int CDODEGKMLIF<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE6C0", Offset = "0x6EDAC0")] this in ReadOnlySpan<T?> IKHBPJOEIEB, int GPBHGNBJNIK = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3750D70", Offset = "0x374F770", VA = "0x183750D70")]
	public static string JDEJKONHMDI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE730", Offset = "0x6EDB30")] this in ReadOnlySpan<T> IKHBPJOEIEB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3750950", Offset = "0x374F350", VA = "0x183750950")]
	public static string EHJHBCLKMMB<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6EE7A0", Offset = "0x6EDBA0")] this in ReadOnlySpan<T> IKHBPJOEIEB, string NILJKOMKIAN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class MCCCEFAHANH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static LBBAGFJMMPC PBPBAAAEJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1E2C8C0", Offset = "0x1E2B2C0", VA = "0x181E2C8C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C920", Offset = "0x1E2B320", VA = "0x181E2C920")]
	public static double LPIGGOCDKHB(this LBBAGFJMMPC IKHBPJOEIEB, long ECMLLNBMINI)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class CIJMNCJLFNB : LBBAGFJMMPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Stopwatch AIHJEFGCLMD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long IAEEOOLABAG
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1E2B2C0", Offset = "0x1E29CC0", VA = "0x181E2B2C0", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x82DEC0", Offset = "0x82C8C0", VA = "0x18082DEC0")]
	private CIJMNCJLFNB(Stopwatch BNLNLKOJKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B1C0", Offset = "0x1E29BC0", VA = "0x181E2B1C0")]
	public static CIJMNCJLFNB ELAOIECFABA(Stopwatch BNLNLKOJKLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B220", Offset = "0x1E29C20", VA = "0x181E2B220")]
	public static CIJMNCJLFNB EOLAPFNFHIE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class POFDLGKHBEJ
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1E2CE60", Offset = "0x1E2B860", VA = "0x181E2CE60")]
	public static RigidTransform EFPANGFLMBI(this in RigidTransform IKHBPJOEIEB)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class ICFCIBOIFHK
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C460", Offset = "0x1E2AE60", VA = "0x181E2C460")]
	public static RigidTransform DGEHBNCBJDH(RigidTransform EBJGMMICEOP, RigidTransform JCFIHKOMELP)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class JLPFLCKIAKO
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1874A30", Offset = "0x1873430", VA = "0x181874A30")]
	public static bool EIOMKIOIMNJ(this string LLLCELNKBJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class NIMFKAPNEDE<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct JJGKCOLPNBE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3FD0270", Offset = "0x3FCEC70", VA = "0x183FD0270", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static int NGGOKLGMNOG;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static IEOKIIGIKPP GJBBEDABMIB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static long IAEEOOLABAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3276470", Offset = "0x3274E70", VA = "0x183276470")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3276410", Offset = "0x3274E10", VA = "0x183276410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3276270", Offset = "0x3274C70", VA = "0x183276270")]
	public static JJGKCOLPNBE FDMALBGABBE()
	{
		return default(JJGKCOLPNBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3276070", Offset = "0x3274A70", VA = "0x183276070")]
	private static void CHHCKPABNGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3276200", Offset = "0x3274C00", VA = "0x183276200")]
	public static void CIPJLEDKNPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct IEOKIIGIKPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly LBBAGFJMMPC AIHJEFGCLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly long KNDNJDLNIDF;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C6D0", Offset = "0x1E2B0D0", VA = "0x181E2C6D0")]
	public IEOKIIGIKPP(LBBAGFJMMPC BNLNLKOJKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C520", Offset = "0x1E2AF20", VA = "0x181E2C520")]
	public long FGENKHMABAF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C5B0", Offset = "0x1E2AFB0", VA = "0x181E2C5B0")]
	public double LPIGGOCDKHB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C640", Offset = "0x1E2B040", VA = "0x181E2C640")]
	public double OLOMPGLPGOC()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class GIOLDAIMILN
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x13F2120", Offset = "0x13F0B20", VA = "0x1813F2120")]
	public static bool JGKKLAGBOAB(this Type IKHBPJOEIEB, Type EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x30D3440", Offset = "0x30D1E40", VA = "0x1830D3440")]
	public static bool JGKKLAGBOAB<T>(this Type IKHBPJOEIEB) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class MNDEBOOKIDD
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xE183E0", Offset = "0xE16DE0", VA = "0x180E183E0")]
	public static uint MJAGDFBAIJP(this uint IKHBPJOEIEB, int HGMGPFAJPJI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x149D610", Offset = "0x149C010", VA = "0x18149D610")]
	public static uint DEANJMBFILF(this uint IKHBPJOEIEB, int HGMGPFAJPJI)
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
