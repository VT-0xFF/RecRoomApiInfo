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
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67BB800", Offset = "0x67BAA00", VA = "0x1867BB800")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7018E0", Offset = "0x700AE0", VA = "0x1807018E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x701910", Offset = "0x700B10", VA = "0x180701910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BFPAMLNCFFG
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate int PKCDAHDAOLH<T>(in T BLFKABPCHLN, in T NPFMAENOPCH);

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class BLLCNPJGEHP<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct ABICFOBADMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly int JDHIICINABH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly int FNDKHFCCKIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public readonly bool KPGBFKJHKKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int FJHBBHLOHGG;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x1BA6DA0", Offset = "0x1BA5FA0", VA = "0x181BA6DA0")]
			public ABICFOBADMK(int JDHIICINABH, int FNDKHFCCKIF, bool KPGBFKJHKKA)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly T[] MGJIIKAGIEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly T[] KDGHMEPMNCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly PKCDAHDAOLH<T> JPJLMALIFKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly int MBLJMLHIEPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Func<bool> BIBGGBHDMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int IKPGNGKKNEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C2DD0", Offset = "0x5C21D0")]
		private readonly BLLCNPJGEHP<T>.ABICFOBADMK[] ABGNCPANCHE;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x21C7A30", Offset = "0x21C6C30", VA = "0x1821C7A30")]
		public BLLCNPJGEHP(T[] MGJIIKAGIEG, PKCDAHDAOLH<T> JPJLMALIFKG, int MBLJMLHIEPE, Func<bool> BIBGGBHDMKA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C2E30", Offset = "0x5C2230")] T[] PENJFEGNAOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x21C7340", Offset = "0x21C6540", VA = "0x1821C7340")]
		public bool NJNKNCECLOL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate U BCHBJLPEOFN<T, U>(int HBBHPJLIFPO, int FOKJFKHDACN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C2E90", Offset = "0x5C2290")] in ReadOnlySpan<T> BKDCPFHKDLB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xE229A0", Offset = "0xE21BA0", VA = "0x180E229A0")]
	public static ReadOnlyMemory<T> NJBOMDNBHGI<T>(this T[] DIJPFIMLAFB) where T : notnull
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x21737D0", Offset = "0x21729D0", VA = "0x1821737D0")]
	public static T[] CECBINCFHEM<T>(int CAPKFCHDLFA, T FDHAGJGDKEM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2173EE0", Offset = "0x21730E0", VA = "0x182173EE0")]
	public static void GDAGDMDDECE<T>(this T[] CALHOHJDFOH, T FDHAGJGDKEM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1C06240", Offset = "0x1C05440", VA = "0x181C06240")]
	public static void CKKLKMOPNFE<T>(this T[] HAHPMNMCEBD, int MLECAGAJCGO, int JIEKLDFOLNF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2173A00", Offset = "0x2172C00", VA = "0x182173A00")]
	private static void DLHKPPDLMGP<T>(this T[] DIJPFIMLAFB, int KBLMOPAKMFF, int IDKMAFBPIEO, T[] HNPEBINPOBO, int BINBAGJGHPB, int EHCIPPLGMCD, T[] CDNLFEOBNKB, int KGNMCPJCFFH, PKCDAHDAOLH<T> JPJLMALIFKG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2174110", Offset = "0x2173310", VA = "0x182174110")]
	public static void MMKGPOLJLIP<T>(this T[] DIJPFIMLAFB, int JDHIICINABH, int BFFJHKFEFPP, PKCDAHDAOLH<T> JPJLMALIFKG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2174070", Offset = "0x2173270", VA = "0x182174070")]
	public static BLLCNPJGEHP<T> MMBBNAPFGFD<T>(this T[] DIJPFIMLAFB, PKCDAHDAOLH<T> JPJLMALIFKG, int MBLJMLHIEPE, Func<bool> BIBGGBHDMKA, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C2D20", Offset = "0x5C2120")] T[] PENJFEGNAOO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x21731C0", Offset = "0x21723C0", VA = "0x1821731C0")]
	public static T[] BFGJAOCGAGD<T>(this T[] HAHPMNMCEBD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2173E00", Offset = "0x2173000", VA = "0x182173E00")]
	public static T[] DNPEPBCNLBO<T>(this T[] OKCKNHCONHC, T PPIIEEAFCFI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x21731E0", Offset = "0x21723E0", VA = "0x1821731E0")]
	public static T[] BPNNBPKIJDD<T>(this T[] OKCKNHCONHC, int GMEHLIHLGEH, T PPIIEEAFCFI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2174790", Offset = "0x2173990", VA = "0x182174790")]
	public static T[] PLJKFHHOAGG<T>(this T[] OKCKNHCONHC, int GMEHLIHLGEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2174560", Offset = "0x2173760", VA = "0x182174560")]
	public static T[] OCMNGCHIBOO<T>(this T[] OKCKNHCONHC, int GMEHLIHLGEH, T PPIIEEAFCFI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2172C80", Offset = "0x2171E80", VA = "0x182172C80")]
	public static U[] BDKNOFGPHNC<U, T>(this T[] JNAAHMPCPAB, int BIKOKDJGDCD, BCHBJLPEOFN<T, U> JFPKKAECDAD) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x67B9CE0", Offset = "0x67B8EE0", VA = "0x1867B9CE0")]
	public static byte[] APIJCCLCKCP(this byte[] DIJPFIMLAFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x67B9EF0", Offset = "0x67B90F0", VA = "0x1867B9EF0")]
	public static byte[] EGCGNGFKOOC(this byte[] DIJPFIMLAFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class HHFGCIKJJIG
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2270C00", Offset = "0x226FE00", VA = "0x182270C00")]
	public static void AKIKAHMEOBL<T>(this ICollection<T> DIJPFIMLAFB, IEnumerable<T> IIGHOHLJPIF) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class KALDGKEAOEN
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x12F1560", Offset = "0x12F0760", VA = "0x1812F1560")]
	public static void BBJFOCMFDMP<K, V>(this IDictionary<K, V> DIJPFIMLAFB, in K FDAIMOMOHIG, in V IPMIIEAGJKC, Func<V, V, V> JIJCEKELGIL) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x12F1CC0", Offset = "0x12F0EC0", VA = "0x1812F1CC0")]
	public static void DCAINLKBAGA<K, V>(this IDictionary<K, List<V>> DIJPFIMLAFB, in K FDAIMOMOHIG, in V IPMIIEAGJKC) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x12F3130", Offset = "0x12F2330", VA = "0x1812F3130")]
	public static TVal GFMNNFCLLJF<TVal, TKey>(this IDictionary<TKey, TVal> OEGCIGPEFGP, in TKey FDAIMOMOHIG, [Optional][MLEFICKODBB("`default!` shouldn't be necessary in C# 9")] TVal GFLAEOLMKMC) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x12F2820", Offset = "0x12F1A20", VA = "0x1812F2820")]
	public static TVal GFMNNFCLLJF<TVal, TKey>(this IDictionary<TKey, TVal> OEGCIGPEFGP, in TKey FDAIMOMOHIG, Func<TVal> FKFOMPDBNJK) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x12F1470", Offset = "0x12F0670", VA = "0x1812F1470")]
	public static TValue AELDMOLLHGB<TValue, TKey>(this IDictionary<TKey, TValue> OEGCIGPEFGP, in TKey FDAIMOMOHIG, [Optional][MLEFICKODBB("`default!` shouldn't be necessary in C# 9")] in TValue GFLAEOLMKMC) where TValue : notnull where TKey : notnull
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x12F23B0", Offset = "0x12F15B0", VA = "0x1812F23B0")]
	public static V EAEICGIJIHB<V, K>(this IDictionary<K, V> DIJPFIMLAFB, in K FDAIMOMOHIG) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x12F3510", Offset = "0x12F2710", VA = "0x1812F3510")]
	public static T2[] LBKAIIPADDG<T2, T1>(this Dictionary<T1, T2>.ValueCollection MFDKABFENEE) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x12F35A0", Offset = "0x12F27A0", VA = "0x1812F35A0")]
	public static bool OIACEIIALAO<TKey, TValue>(this IDictionary<TKey, TValue> DIJPFIMLAFB, TKey FDAIMOMOHIG, TValue IPMIIEAGJKC) where TKey : notnull where TValue : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BCHLHLPLKBB
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate bool LMOOONNABJL<TArgs, T>(in TArgs ADCFFAJGNAM, T ONCGIPFNENB);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate U KOMMKCKMNFJ<TArg, U>(in TArg NKBIKBGEKGL);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate U DKOAOJDJOFE<TArg, T, U>(in TArg NKBIKBGEKGL, T OFFJPOMOLDJ);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate U LIKAFHDGPFO<TArg, T, U>(in TArg NKBIKBGEKGL, IEnumerable<T> DKIPBFCBBBG);

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate U HOHIHMEJCOJ<TArg, T, U>(in TArg NKBIKBGEKGL, T OFFJPOMOLDJ);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct MNAMBMECPBG<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x24118C0", Offset = "0x2410AC0", VA = "0x1824118C0")]
		[MLEFICKODBB("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) CIOODPNMJBC(T JMHPKGDGAPM)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2411930", Offset = "0x2410B30", VA = "0x182411930")]
		[MLEFICKODBB("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) CPIFCLKFJHF(IEnumerable<T> AMGMFLHOMNE)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class DFCAMFALNON<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public DFCAMFALNON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1BA62D0", Offset = "0x1BA54D0", VA = "0x181BA62D0")]
		internal bool <SetEqual>b__0(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x20C6100", Offset = "0x20C5300", VA = "0x1820C6100")]
		internal bool <SetEqual>b__1(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x240EB30", Offset = "0x240DD30", VA = "0x18240EB30")]
	public static bool KKKDICCFPHB<T, TArgs>(this IEnumerable<T> DIJPFIMLAFB, in TArgs ADCFFAJGNAM, LMOOONNABJL<TArgs, T> PKJNNBGEKJO) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x240B3F0", Offset = "0x240A5F0", VA = "0x18240B3F0")]
	public static U CCOEPECEBBJ<U, T>(this IEnumerable<T> DIJPFIMLAFB, Func<U> FKEGHOANNMO, Func<T, U> JMHPKGDGAPM, Func<IEnumerable<T>, U> AMGMFLHOMNE) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x240DF40", Offset = "0x240D140", VA = "0x18240DF40")]
	public static bool JBCLLHLOMGA<T, TArgs>(this IEnumerable<T> DIJPFIMLAFB, in TArgs ADCFFAJGNAM, LMOOONNABJL<TArgs, T> PKJNNBGEKJO) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x240D690", Offset = "0x240C890", VA = "0x18240D690")]
	public static U FIAJJLFIKNM<U, T, TArg>(this IEnumerable<T> DIJPFIMLAFB, in TArg NKBIKBGEKGL, KOMMKCKMNFJ<TArg, U> FKEGHOANNMO, DKOAOJDJOFE<TArg, T, U> JMHPKGDGAPM, LIKAFHDGPFO<TArg, T, U> AMGMFLHOMNE) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x240F2C0", Offset = "0x240E4C0", VA = "0x18240F2C0")]
	public static IEnumerable<U> LOEIELPCHJG<U, T, TArg>(this IEnumerable<T> DIJPFIMLAFB, in TArg NKBIKBGEKGL, HOHIHMEJCOJ<TArg, T, U> JFOHKIGNEKH) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x12F4A50", Offset = "0x12F3C50", VA = "0x1812F4A50")]
	public static IEnumerable<T> AMEIMMDFGBJ<T>(params IEnumerable<T>[] GPIDIPIHMDM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x240D320", Offset = "0x240C520", VA = "0x18240D320")]
	public static bool ELPOBECBNOB<T>(this IEnumerable<T> GLLFHCCFIGK, IEnumerable<T> HNPEBINPOBO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x12F4A50", Offset = "0x12F3C50", VA = "0x1812F4A50")]
	public static IEnumerable<(TKey?, TValue?)>? ELDMDFGILMP<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C30A0", Offset = "0x5C24A0")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? DIJPFIMLAFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x240DAE0", Offset = "0x240CCE0", VA = "0x18240DAE0")]
	public static IEnumerable<T> HILHJPPBPEJ<T, TKey>(this IEnumerable<T> IECEJGBNFLJ, Func<T, TKey> NGCJCOPLCNL) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xEEE600", Offset = "0xEED800", VA = "0x180EEE600")]
	[IteratorStateMachine(typeof(CBNLIFCEGND))]
	public static IEnumerable<T> IDNHCBFOGLD<T, U>(this IEnumerable<T> DIJPFIMLAFB, IEnumerable<U> HNPEBINPOBO, [Optional][MLEFICKODBB("`default!` shouldn't be necessary in C# 9")] T FDHAGJGDKEM) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1C0E3E0", Offset = "0x1C0D5E0", VA = "0x181C0E3E0")]
	public static T JKPELLDFCFM<T>(this IEnumerable<T> GLLFHCCFIGK, T GFLAEOLMKMC) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x240E2A0", Offset = "0x240D4A0", VA = "0x18240E2A0")]
	public static T JKPELLDFCFM<T>(this IEnumerable<T> GLLFHCCFIGK, T GFLAEOLMKMC, Func<T, bool> PKJNNBGEKJO) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B2C0", Offset = "0x1F9A4C0", VA = "0x181F9B2C0")]
	[IteratorStateMachine(typeof(BBEODNMAMGM))]
	public static IEnumerable<(T, global::FHJHGBHFPAM<T>)> NLCEKNPIKAF<T>(this IEnumerable<T> DIJPFIMLAFB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x240E2F0", Offset = "0x240D4F0", VA = "0x18240E2F0")]
	public static bool KDBOKFGPBIH<T>(this IEnumerable<T> DIJPFIMLAFB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x12F4A50", Offset = "0x12F3C50", VA = "0x1812F4A50")]
	public static IEnumerable<global::MPMCCCNBAHH<T>> BCGMDEIHEMI<T>(this IEnumerable<T> DIJPFIMLAFB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x240E3E0", Offset = "0x240D5E0", VA = "0x18240E3E0")]
	public static bool KGIFMFOFOPL<T>(this IEnumerable<T> DIJPFIMLAFB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x240B3C0", Offset = "0x240A5C0", VA = "0x18240B3C0")]
	public static IEnumerable<T> BHNFKINHLGM<T>(this IEnumerable<T> DIJPFIMLAFB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xEEE4C0", Offset = "0xEED6C0", VA = "0x180EEE4C0")]
	[IteratorStateMachine(typeof(NAKNKEHKAPB))]
	public static IEnumerable<U> HGCFJMMHLMO<U, T>(this IEnumerable<T> DIJPFIMLAFB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C3220", Offset = "0x5C2620")] Func<MNAMBMECPBG<U>, T, (bool Zero, U One, IEnumerable<U> Many)> OFIPILACMMB) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x240F4E0", Offset = "0x240E6E0", VA = "0x18240F4E0")]
	public static int MNBNGMJNHJK<T>(this IEnumerable<T> DIJPFIMLAFB, int ADCIHANNMJN = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x240D180", Offset = "0x240C380", VA = "0x18240D180")]
	public static bool ELDGHPNBDBH<T>(this IEnumerable<T> DIJPFIMLAFB, IEnumerable<T> HNPEBINPOBO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x240D850", Offset = "0x240CA50", VA = "0x18240D850")]
	public static (IEnumerable<T>, IEnumerable<T>) GPDNEBLODOB<T>(this IEnumerable<T> DIJPFIMLAFB, Func<T, bool> PGDMPHKPJKI) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x240FB50", Offset = "0x240ED50", VA = "0x18240FB50")]
	public static string ONFHKGKBGKA<T>(this IEnumerable<T> DIJPFIMLAFB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x240ED50", Offset = "0x240DF50", VA = "0x18240ED50")]
	public static Dictionary<TKey?, TValue?>? KLJNHDOEMFE<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C3310", Offset = "0x5C2710")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? GLLFHCCFIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x240ED50", Offset = "0x240DF50", VA = "0x18240ED50")]
	public static Dictionary<TKey?, TValue?>? KLJNHDOEMFE<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C3370", Offset = "0x5C2770")] this IEnumerable<(TKey? Key, TValue? Value)>? GLLFHCCFIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1151550", Offset = "0x1150750", VA = "0x181151550")]
	public static HashSet<T> DGKCKCELEPO<T>(this IEnumerable<T> DIJPFIMLAFB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x240BC80", Offset = "0x240AE80", VA = "0x18240BC80")]
	public static string CNCGKNGDNFL<T>(this IEnumerable<T> DIJPFIMLAFB, string OELGKNGEMAD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xEEE420", Offset = "0xEED620", VA = "0x180EEE420")]
	[IteratorStateMachine(typeof(LIJJPGPAGNG))]
	public static IEnumerable<(T, U)> KGDKNEJOBLF<T, U>(this IEnumerable<T> BLFKABPCHLN, IEnumerable<U> NPFMAENOPCH) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x24101C0", Offset = "0x240F3C0", VA = "0x1824101C0")]
	public static IEnumerable<V> POCOOPLNEMF<V, T, U>(this IEnumerable<T> DIJPFIMLAFB, IEnumerable<U> HNPEBINPOBO, Func<T, U, V> MGOJJFHCDLP, [Optional][MLEFICKODBB("`default!` shouldn't be necessary in C# 9")] T EFIANLIHNMP, [Optional][MLEFICKODBB("`default!` shouldn't be necessary in C# 9")] U OLKLAHJFDHI) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2410250", Offset = "0x240F450", VA = "0x182410250")]
	public static IEnumerable<(T, U)> POCOOPLNEMF<T, U>(this IEnumerable<T> DIJPFIMLAFB, IEnumerable<U> HNPEBINPOBO, [Optional][MLEFICKODBB("`default!` shouldn't be necessary in C# 9")] T EFIANLIHNMP, [Optional][MLEFICKODBB("`default!` shouldn't be necessary in C# 9")] U OLKLAHJFDHI) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class DLHPOEGLEOC
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1D16340", Offset = "0x1D15540", VA = "0x181D16340")]
	public static bool LCKHELHMHMH<T, U>(this T DIJPFIMLAFB, in U ICHBECDKHOJ) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1D162A0", Offset = "0x1D154A0", VA = "0x181D162A0")]
	public static bool KNHHLFBMICD<T>(ref T DIJPFIMLAFB, T HNPEBINPOBO) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class OLLMAJPLHKO
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x26FDE50", Offset = "0x26FD050", VA = "0x1826FDE50")]
	public static bool GHPEAGBHBHO(this in float3 NNMPJECKECI, float3 EFNJCAIBDLA, float MLDMKNFDLFI = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class DBHMPAEIMEB
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x116CB00", Offset = "0x116BD00", VA = "0x18116CB00")]
	public static void PGDKJGPJAGD<T>(this T IHPJCBCPLCM, Action<T> HPJGOBHOOFB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x116CA60", Offset = "0x116BC60", VA = "0x18116CA60")]
	public static V PCEOFEKDPPH<V, T>(this T IHPJCBCPLCM, Func<T, V> HPJGOBHOOFB, [Optional][MLEFICKODBB("`default!` shouldn't be necessary in C# 9")] V GFLAEOLMKMC) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x116C760", Offset = "0x116B960", VA = "0x18116C760")]
	public static T? AEJOFJPOGPM<T>(this T DIJPFIMLAFB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x116C900", Offset = "0x116BB00", VA = "0x18116C900")]
	[IteratorStateMachine(typeof(AAFGOAAGGPG))]
	public static IEnumerable<T> HLHEJIIEGNN<T>(this T DIJPFIMLAFB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x116C9E0", Offset = "0x116BBE0", VA = "0x18116C9E0")]
	public static T[] OCOOIBBOKBH<T>(this T DIJPFIMLAFB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class CAJJBFEDIEO
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x67BAA40", Offset = "0x67B9C40", VA = "0x1867BAA40")]
	private static byte[] PFEHCNFILNM(int FKBADCHKJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x67BA8E0", Offset = "0x67B9AE0", VA = "0x1867BA8E0")]
	private static byte[] KCIGKMAEKHJ(long BEJBINLGLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x67BA0F0", Offset = "0x67B92F0", VA = "0x1867BA0F0")]
	private static byte[] EAGDAPKLDEN(ulong BEJBINLGLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x67BA170", Offset = "0x67B9370", VA = "0x1867BA170")]
	public static Guid GEFJEMFBCHK(params Guid[] IKLPEJEBIJF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x67BA2E0", Offset = "0x67B94E0", VA = "0x1867BA2E0")]
	public static Guid GPGHDDABLEF(in Guid DIPHACGNJII, int GMEHLIHLGEH, int EOGFAFNNICF = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x67BA3A0", Offset = "0x67B95A0", VA = "0x1867BA3A0")]
	public static Guid GPGHDDABLEF(in Guid DIPHACGNJII, long GMEHLIHLGEH, int EOGFAFNNICF = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x67BA460", Offset = "0x67B9660", VA = "0x1867BA460")]
	public static Guid GPGHDDABLEF(in Guid DIPHACGNJII, ulong GMEHLIHLGEH, int EOGFAFNNICF = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x67BA520", Offset = "0x67B9720", VA = "0x1867BA520")]
	public static Guid GPGHDDABLEF(in Guid DIPHACGNJII, in Guid EMPGFGGCNKD, int EOGFAFNNICF = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x67BA590", Offset = "0x67B9790", VA = "0x1867BA590")]
	private static Guid GPGHDDABLEF(in Guid DIPHACGNJII, byte[] EEEEOODPIKB, int EOGFAFNNICF = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x67BA960", Offset = "0x67B9B60", VA = "0x1867BA960")]
	private static void MPIGBFCIOOB(byte[] JMIFIJDBMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x67BA860", Offset = "0x67B9A60", VA = "0x1867BA860")]
	private static void IGIGFIABOHE(byte[] JMIFIJDBMNM, int DNDNMGOKFEI, int OHMMPNACNJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface ICGACDJNEDL
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LOCLLOKJGIA AKPFFHHLCLA();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface LOCLLOKJGIA : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool OGEPDGHINAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AAMGGBCNCGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JDJKBACLNAE
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int EDOFMOHMNAN(int KOMPMCPODJM, int AFALOODLEEP);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float MFJICFOGIMG(float OEFKBIIHHHI, float NKHAALPHKBO);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface CBIEEODKNCG
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	long FFGMFOBNNNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class JGLDEIFJOGF
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x67BAD20", Offset = "0x67B9F20", VA = "0x1867BAD20")]
	public static int MADAPMPBMMF(this int DIJPFIMLAFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x67BACE0", Offset = "0x67B9EE0", VA = "0x1867BACE0")]
	public static int LABAINELPOF(this int DIJPFIMLAFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x67BAD90", Offset = "0x67B9F90", VA = "0x1867BAD90")]
	public static int OHKKECILIFK(this int DIJPFIMLAFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x67BACD0", Offset = "0x67B9ED0", VA = "0x1867BACD0")]
	public static int ENCAGKKDOGG(this int DIJPFIMLAFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x14B79D0", Offset = "0x14B6BD0", VA = "0x1814B79D0")]
	public static int NJCDMENNMLC(this int DIJPFIMLAFB, int BFFJHKFEFPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x14B79F0", Offset = "0x14B6BF0", VA = "0x1814B79F0")]
	public static int HEFFHDEAFKI(this int DIJPFIMLAFB, int BFFJHKFEFPP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class DOMABHLBNLI
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1D17710", Offset = "0x1D16910", VA = "0x181D17710")]
	public static void HABFEFJGGOE<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C3D40", Offset = "0x5C3140")] this in KeyValuePair<TKey, TValue> DIJPFIMLAFB, out TKey FDAIMOMOHIG, out TValue IPMIIEAGJKC) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1D17920", Offset = "0x1D16B20", VA = "0x181D17920")]
	public static (TKey?, TValue?) NLDDGOIOHJA<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C3DB0", Offset = "0x5C31B0")] this in KeyValuePair<TKey?, TValue?> DIJPFIMLAFB)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1D17850", Offset = "0x1D16A50", VA = "0x181D17850")]
	public static KeyValuePair<TKey?, UValue?> IILEJCBICGL<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C3E20", Offset = "0x5C3220")] this KeyValuePair<TKey?, TValue?> DIJPFIMLAFB, UValue IPMIIEAGJKC)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class DKNFCAKKGMA
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class AKOPALPIIDA<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public AKOPALPIIDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x31DEDB0", Offset = "0x31DDFB0", VA = "0x1831DEDB0")]
		internal TElement <BinarySearch>b__0(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class EIKIOCKECIG<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Random rng;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public EIKIOCKECIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x887610", Offset = "0x886810", VA = "0x180887610")]
		internal int <Random>b__0(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1D157B0", Offset = "0x1D149B0", VA = "0x181D157B0")]
	public static int PPIBBBHIKOM<T>(this IReadOnlyList<T> HAHPMNMCEBD, T IPMIIEAGJKC) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1D14320", Offset = "0x1D13520", VA = "0x181D14320")]
	public static int JKHGDFDAPON<T>(this IReadOnlyList<T> HAHPMNMCEBD, T IPMIIEAGJKC) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1D0FCD0", Offset = "0x1D0EED0", VA = "0x181D0FCD0")]
	public static void AKIKAHMEOBL<T>(this HashSet<T> NCDJGGEEOFC, IEnumerable<T> IIGHOHLJPIF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1D10D90", Offset = "0x1D0FF90", VA = "0x181D10D90")]
	public static void EODDHCFLAJF<T>(this IList<T> JAAGBDPDCIE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1D10A60", Offset = "0x1D0FC60", VA = "0x181D10A60")]
	public static void EODDHCFLAJF<T>(this IList<T> JAAGBDPDCIE, int DAEBJBGKHGF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1D15510", Offset = "0x1D14710", VA = "0x181D15510")]
	public static List<T> ONAINJGLBNH<T>(this List<T> HJHCHKNIJAF, Predicate<T> PGEONKOMPDK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1D16040", Offset = "0x1D15240", VA = "0x181D16040")]
	public static int PPIBBBHIKOM<T>(this IReadOnlyList<T> JAAGBDPDCIE, Predicate<T> PKJNNBGEKJO) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1D15090", Offset = "0x1D14290", VA = "0x181D15090")]
	public static bool OKOGNNNKEAP<T>(this IReadOnlyList<T> JAAGBDPDCIE, Predicate<T> PKJNNBGEKJO, [MGFEIFFEBML(true)] out List<int>? EMBOJIFBMBL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1D10120", Offset = "0x1D0F320", VA = "0x181D10120")]
	public static bool BPCENLKELKP<T>(this IReadOnlyList<T> JAAGBDPDCIE, T ONCGIPFNENB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1D0FF90", Offset = "0x1D0F190", VA = "0x181D0FF90")]
	public static bool BPCENLKELKP<T>(this IReadOnlyList<T> JAAGBDPDCIE, T ONCGIPFNENB, EqualityComparer<T> AHFOJMBPHIP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1D118E0", Offset = "0x1D10AE0", VA = "0x181D118E0")]
	public static int FKHNDMKDFAG<TElement, TKey>(this IList<TElement> HDAEPLJJFAC, TKey FJFKJOHGOBD, Func<TElement, TKey> MLJJGDBAINN, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C3F00", Offset = "0x5C3300")] Func<TKey, TKey, int> JPJLMALIFKG, int GMEHLIHLGEH = 0, [Optional] int? BFFJHKFEFPP) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1D115F0", Offset = "0x1D107F0", VA = "0x181D115F0")]
	public static int FKHNDMKDFAG<TElement, TKey>(Func<int, TElement> FLGGDPAEOHL, int ABOMKACAAGK, TKey FJFKJOHGOBD, Func<TElement, TKey> MLJJGDBAINN, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C3F60", Offset = "0x5C3360")] Func<TKey, TKey, int> JPJLMALIFKG, int GMEHLIHLGEH = 0, [Optional] int? BFFJHKFEFPP) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1D144E0", Offset = "0x1D136E0", VA = "0x181D144E0")]
	public static List<T> KLBOKLMHMMB<T>(this IReadOnlyList<T> JAAGBDPDCIE, int BFFJHKFEFPP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1D14F10", Offset = "0x1D14110", VA = "0x181D14F10")]
	public static bool NKHPECBDFBD<T>(this List<T> JAAGBDPDCIE, T ONCGIPFNENB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1D108A0", Offset = "0x1D0FAA0", VA = "0x181D108A0")]
	public static void DLDEIOOCEFM<T>(this List<T> JAAGBDPDCIE, IEnumerable<T> HJHCHKNIJAF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1D14930", Offset = "0x1D13B30", VA = "0x181D14930")]
	public static void MILDLLFOGOM<T>(this List<T> JAAGBDPDCIE, IEnumerable<T> HJHCHKNIJAF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1D14D10", Offset = "0x1D13F10", VA = "0x181D14D10")]
	public static T MKDICIELLCK<T>(this List<T> HJHCHKNIJAF, Predicate<T> PGEONKOMPDK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1D14E00", Offset = "0x1D14000", VA = "0x181D14E00")]
	public static T NGBCLAHMLBL<T>(this List<T> HJHCHKNIJAF, int GMEHLIHLGEH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1D14D70", Offset = "0x1D13F70", VA = "0x181D14D70")]
	public static bool NFHCLIFGKHB<T>(this List<T> AJEDCKNPGFB, List<T> ONIEJCEFMMK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1D14890", Offset = "0x1D13A90", VA = "0x181D14890")]
	public static T MDKIAHABEHP<T>(this IList<T> JAAGBDPDCIE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1D147D0", Offset = "0x1D139D0", VA = "0x181D147D0")]
	public static bool LGJCECCEEBN<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C3FC0", Offset = "0x5C33C0")] IReadOnlyList<T> JAAGBDPDCIE, int GMEHLIHLGEH, [GIPGJDBPIGB(false)][MLEFICKODBB("This should be `T?` in C# 9.")] out T CDNLFEOBNKB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1D137D0", Offset = "0x1D129D0", VA = "0x181D137D0")]
	public static bool IDCOBMBOIEK<T>(IReadOnlyList<T> JAAGBDPDCIE, ICollection HJHCHKNIJAF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1D114D0", Offset = "0x1D106D0", VA = "0x181D114D0")]
	public static void FJHBLMFEJAM<T>(IReadOnlyList<T> JAAGBDPDCIE, ref ICollection HJHCHKNIJAF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x115F700", Offset = "0x115E900", VA = "0x18115F700")]
	public static bool PCBBHJPPNFE<T>(this IReadOnlyList<T> JAAGBDPDCIE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1D121F0", Offset = "0x1D113F0", VA = "0x181D121F0")]
	public static string FLKLDGAGEHD<T>(this IEnumerable<T> JAAGBDPDCIE, string AOPANMBABHL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1D11420", Offset = "0x1D10620", VA = "0x181D11420")]
	public static T FBLJFHJMCGC<T>(this IList<T> DIJPFIMLAFB) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1D14C20", Offset = "0x1D13E20", VA = "0x181D14C20")]
	public static T MJEMFJIOBLJ<T>(this IList<T> DIJPFIMLAFB) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1D14740", Offset = "0x1D13940", VA = "0x181D14740")]
	public static void KLOCJMCHPIB<T>(this IList<T> DIJPFIMLAFB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1D15600", Offset = "0x1D14800", VA = "0x181D15600")]
	public static void PNLKNNELHBB<T>(this IList<T> DIJPFIMLAFB, in T IPMIIEAGJKC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1D10800", Offset = "0x1D0FA00", VA = "0x181D10800")]
	public static T CMIDJHIMHNF<T>(this IList<T> DIJPFIMLAFB) where T : notnull
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class LEKLIAMFBGJ
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static float DNECJMOHHKG;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static float EJEHBIFEFFF;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static bool DCPEEOAOBHD;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly float INILANMEGEA;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x67BAF80", Offset = "0x67BA180", VA = "0x1867BAF80")]
	public static bool NDHNMGBCIND(float NNMPJECKECI, float EFNJCAIBDLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x44BC1F0", Offset = "0x44BB3F0", VA = "0x1844BC1F0")]
	public static float FBDLIFJMILF(float IPMIIEAGJKC, float IFPPBNLHCCM, float LIODLDNGDIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x44BC210", Offset = "0x44BB410", VA = "0x1844BC210")]
	public static int FBDLIFJMILF(int IPMIIEAGJKC, int IFPPBNLHCCM, int LIODLDNGDIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x44BC1D0", Offset = "0x44BB3D0", VA = "0x1844BC1D0")]
	public static float JKEEPNOPKHH(float IPMIIEAGJKC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x67BAEA0", Offset = "0x67BA0A0", VA = "0x1867BAEA0")]
	public static float IHGPMJMOOAL(float NNMPJECKECI, float EFNJCAIBDLA, float IHPJCBCPLCM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x32FEAC0", Offset = "0x32FDCC0", VA = "0x1832FEAC0")]
	public static float CMBPCMBMPPH(float NNMPJECKECI, float EFNJCAIBDLA, float IHPJCBCPLCM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x67BADE0", Offset = "0x67B9FE0", VA = "0x1867BADE0")]
	public static float HEIFAFEJBMD(float NNMPJECKECI, float EFNJCAIBDLA, float IPMIIEAGJKC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x67BAF40", Offset = "0x67BA140", VA = "0x1867BAF40")]
	public static float MNBOBMPOKBF(float NNMPJECKECI, float EFNJCAIBDLA, float IPMIIEAGJKC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class KNAGBHGCJME
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x21FE6E0", Offset = "0x21FD8E0", VA = "0x1821FE6E0")]
	[KCLFCDFDKOF("This should be replaced with the `is not` operator in C# 9.")]
	public static bool PPAEFFJOIJB<T>(this object DIJPFIMLAFB, [MGFEIFFEBML(true)] out T CDNLFEOBNKB) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class LLAOHKHGKLH
{
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x67BB280", Offset = "0x67BA480", VA = "0x1867BB280")]
	public static bool GHPEAGBHBHO(this quaternion BLFKABPCHLN, quaternion NPFMAENOPCH, float IOFLOODGLNO = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class NGPAHKKIBLL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class EBOELJCLFCL : JDJKBACLNAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly Random CLELCOMDOHF;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x67BABC0", Offset = "0x67B9DC0", VA = "0x1867BABC0", Slot = "4")]
		public int EDOFMOHMNAN(int OEFKBIIHHHI, int EEGMEJBPMPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x67BABF0", Offset = "0x67B9DF0", VA = "0x1867BABF0", Slot = "5")]
		public float MFJICFOGIMG(float OEFKBIIHHHI, float NKHAALPHKBO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x67BAB80", Offset = "0x67B9D80", VA = "0x1867BAB80")]
		private double BMADIEKFIBL()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x67BAC60", Offset = "0x67B9E60", VA = "0x1867BAC60")]
		public EBOELJCLFCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly JDJKBACLNAE KLBOKLMHMMB;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x67BB4C0", Offset = "0x67BA6C0", VA = "0x1867BB4C0")]
	public static ulong BOJKBAIDIGF()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class PIDCGPAFCFK
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x25B7AB0", Offset = "0x25B6CB0", VA = "0x1825B7AB0")]
	public static bool LMLNOEADEJD<T>(this IReadOnlyCollection<T> DIJPFIMLAFB, int GMEHLIHLGEH) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class LGMHKLLDGIN
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x220EF90", Offset = "0x220E190", VA = "0x18220EF90")]
	public static bool HOAIDNCFMEI<T>(this IReadOnlyList<T> DIJPFIMLAFB, int GMEHLIHLGEH, [MGFEIFFEBML(true)][MLEFICKODBB("This should be `T?` in C# 9.")] out T CDNLFEOBNKB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x220F0D0", Offset = "0x220E2D0", VA = "0x18220F0D0")]
	public static bool PNFECGNEKGN<T>(this IReadOnlyList<T> DIJPFIMLAFB, int GMEHLIHLGEH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C4160", Offset = "0x5C3560")] out global::MPMCCCNBAHH<T> CDNLFEOBNKB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x220EE80", Offset = "0x220E080", VA = "0x18220EE80")]
	public static T EICENEFLIDM<T>(this IReadOnlyList<T> DIJPFIMLAFB, int GMEHLIHLGEH, in T GMGKHFNEGMP) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x220EE50", Offset = "0x220E050", VA = "0x18220EE50")]
	[MLEFICKODBB("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T BLAKKMPENEM<T>(this IReadOnlyList<T> DIJPFIMLAFB, int GMEHLIHLGEH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x220F020", Offset = "0x220E220", VA = "0x18220F020")]
	public static T? NAJINBAMFCB<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C4200", Offset = "0x5C3600")] this IReadOnlyList<T> DIJPFIMLAFB, int GMEHLIHLGEH) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class JEHOHBPHJKG
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x12D8690", Offset = "0x12D7890", VA = "0x1812D8690")]
	public static T HHCPOGCCGNF<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C42A0", Offset = "0x5C36A0")] this in ReadOnlyMemory<T> DIJPFIMLAFB, int GMEHLIHLGEH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x12D8450", Offset = "0x12D7650", VA = "0x1812D8450")]
	public static bool GGBPAHGFJIG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C4310", Offset = "0x5C3710")] this in ReadOnlyMemory<T> DIJPFIMLAFB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C4380", Offset = "0x5C3780")] in ReadOnlyMemory<T> HNPEBINPOBO) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x12D8750", Offset = "0x12D7950", VA = "0x1812D8750")]
	public static int MNBNGMJNHJK<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C43F0", Offset = "0x5C37F0")] this in ReadOnlyMemory<T?> DIJPFIMLAFB, int ADCIHANNMJN = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x12D8810", Offset = "0x12D7A10", VA = "0x1812D8810")]
	public static string ONFHKGKBGKA<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C4460", Offset = "0x5C3860")] this in ReadOnlyMemory<T> DIJPFIMLAFB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class LMDHKMKHCKI
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2211E90", Offset = "0x2211090", VA = "0x182211E90")]
	public static bool GGBPAHGFJIG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C44D0", Offset = "0x5C38D0")] this in ReadOnlySpan<T?> DIJPFIMLAFB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C4540", Offset = "0x5C3940")] in ReadOnlySpan<T?> HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2212010", Offset = "0x2211210", VA = "0x182212010")]
	public static int MNBNGMJNHJK<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C45B0", Offset = "0x5C39B0")] this in ReadOnlySpan<T?> DIJPFIMLAFB, int ADCIHANNMJN = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2212130", Offset = "0x2211330", VA = "0x182212130")]
	public static string ONFHKGKBGKA<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C4620", Offset = "0x5C3A20")] this in ReadOnlySpan<T> DIJPFIMLAFB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2211A70", Offset = "0x2210C70", VA = "0x182211A70")]
	public static string CNCGKNGDNFL<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5C4690", Offset = "0x5C3A90")] this in ReadOnlySpan<T> DIJPFIMLAFB, string OELGKNGEMAD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class MMCMBFOPFOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static CBIEEODKNCG OCGEDCLKOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x67BB380", Offset = "0x67BA580", VA = "0x1867BB380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x67BB2F0", Offset = "0x67BA4F0", VA = "0x1867BB2F0")]
	public static double DICONANGNEP(this CBIEEODKNCG DIJPFIMLAFB, long JHEMCJDNAGE)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class LFOJPKDDDHC : CBIEEODKNCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Stopwatch LFBEDHCHFII;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long FFGMFOBNNNL
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x67BB1C0", Offset = "0x67BA3C0", VA = "0x1867BB1C0", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7A4ED0", Offset = "0x7A40D0", VA = "0x1807A4ED0")]
	private LFOJPKDDDHC(Stopwatch LKKCBBBBCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x67BB160", Offset = "0x67BA360", VA = "0x1867BB160")]
	public static LFOJPKDDDHC ADNPINOPPIP(Stopwatch LKKCBBBBCOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x67BB1E0", Offset = "0x67BA3E0", VA = "0x1867BB1E0")]
	public static LFOJPKDDDHC IHMDLDPBEOL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class OBGJLMBILIN
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x67BBAB0", Offset = "0x67BACB0", VA = "0x1867BBAB0")]
	public static RigidTransform CJMCCNMKLMH(this in RigidTransform DIJPFIMLAFB)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class DCEECCNBHBA
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x67BAAC0", Offset = "0x67B9CC0", VA = "0x1867BAAC0")]
	public static RigidTransform LHKACHANLOM(RigidTransform IKCOLIFPMDD, RigidTransform GDNCCJOBJHF)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class GACPHDOLHBG
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x543A630", Offset = "0x5439830", VA = "0x18543A630")]
	public static bool PCBBHJPPNFE(this string IBALDFBGBGL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class IACKLPJGNIP<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct GNGINLLBKIG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x23BB6E0", Offset = "0x23BA8E0", VA = "0x1823BB6E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static int LMJGAFJIOGI;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static OBCPHIJMGBG IHLBMKDIBHC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static long FFGMFOBNNNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x192B290", Offset = "0x192A490", VA = "0x18192B290")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x192AF00", Offset = "0x192A100", VA = "0x18192AF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x192AF60", Offset = "0x192A160", VA = "0x18192AF60")]
	public static GNGINLLBKIG ELBBOBBFEKM()
	{
		return default(GNGINLLBKIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x192B100", Offset = "0x192A300", VA = "0x18192B100")]
	private static void GJFBIKFFCDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x192B2E0", Offset = "0x192A4E0", VA = "0x18192B2E0")]
	public static void PAKIMOKGMBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct OBCPHIJMGBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly CBIEEODKNCG LFBEDHCHFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly long IIJMDFKLICK;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x67BBA40", Offset = "0x67BAC40", VA = "0x1867BBA40")]
	public OBCPHIJMGBG(CBIEEODKNCG LKKCBBBBCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x67BB920", Offset = "0x67BAB20", VA = "0x1867BB920")]
	public long JDJLJHOCFJH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x67BB890", Offset = "0x67BAA90", VA = "0x1867BB890")]
	public double DICONANGNEP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x67BB9B0", Offset = "0x67BABB0", VA = "0x1867BB9B0")]
	public double OKNBAKECOLJ()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class NGJGMOADPLK
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x47EF060", Offset = "0x47EE260", VA = "0x1847EF060")]
	public static bool BCENADJJLBG(this Type DIJPFIMLAFB, Type HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1C7EBA0", Offset = "0x1C7DDA0", VA = "0x181C7EBA0")]
	public static bool BCENADJJLBG<T>(this Type DIJPFIMLAFB) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class LHPONPLCPMM
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x14B79D0", Offset = "0x14B6BD0", VA = "0x1814B79D0")]
	public static uint NJCDMENNMLC(this uint DIJPFIMLAFB, int BFFJHKFEFPP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x14B79F0", Offset = "0x14B6BF0", VA = "0x1814B79F0")]
	public static uint HEFFHDEAFKI(this uint DIJPFIMLAFB, int BFFJHKFEFPP)
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
