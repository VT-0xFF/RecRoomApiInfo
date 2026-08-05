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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1EB90", Offset = "0x6E1DF90", VA = "0x186E1EB90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4F80", VA = "0x1808C5B80")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C5BC0", Offset = "0x8C4FC0", VA = "0x1808C5BC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IDBDIEEEFMP
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string[] DPJNGGONFKC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BCA0", Offset = "0x6E1B0A0", VA = "0x186E1BCA0")]
	public static bool OMOGOCKBHCP(string DJPPIIJCKBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B750", Offset = "0x6E1AB50", VA = "0x186E1B750")]
	private static bool EEAAJEMGDLC(string NFKMLKNHFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B820", Offset = "0x6E1AC20", VA = "0x186E1B820")]
	public static bool EEAAJEMGDLC(Exception NNGGPGOOBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B970", Offset = "0x6E1AD70", VA = "0x186E1B970")]
	public static string NNKJNDCONGI(string BBLEEPEBKMO, string PKIPCCDIHFG = "", bool IPECANLIAKJ = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KAAGPCGCGLA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D210", Offset = "0x6E1C610", VA = "0x186E1D210")]
	public static string ECCLLHOPGMD(this Guid MDOJFEIEAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D2C0", Offset = "0x6E1C6C0", VA = "0x186E1D2C0")]
	public static string ECCLLHOPGMD(this byte[] HFBIMFCNCFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D360", Offset = "0x6E1C760", VA = "0x186E1D360")]
	public static byte[] HDNBEAAHLPP(string HMGPDHAOICO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class JAIELMMHJLK
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int DAPDPNIHNHN<T>([In] T MMHCOKHACHF, [In] T DEOGINMLLDP);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class OLGCAIODHII<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct DADBJJMJIDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly int PNGCLOMDHAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public readonly int FEMNGPHAOJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public readonly bool PPNFLAOHMCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int GICFNAANCBL;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5BD13A0", Offset = "0x5BD07A0", VA = "0x185BD13A0")]
			public DADBJJMJIDH(int PNGCLOMDHAJ, int FEMNGPHAOJJ, bool PPNFLAOHMCL)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly T[] BEAIJDKHELH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly T[] FOCFJDKHFKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly DAPDPNIHNHN<T> HOEEGDOOJPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly int FEJHKLKMJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Func<bool> ANIAAFJMDKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int HHOCOIJFEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly DADBJJMJIDH[] HMNBOJKGNJI;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4A75230", Offset = "0x4A74630", VA = "0x184A75230")]
		public OLGCAIODHII(T[] BEAIJDKHELH, DAPDPNIHNHN<T> HOEEGDOOJPO, int FEJHKLKMJEI, Func<bool> ANIAAFJMDKF, T[]? OJAONCHMMDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4A74F10", Offset = "0x4A74310", VA = "0x184A74F10")]
		public bool DNDOODAOAKF()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate U NNJNMOHMAJO<T, U>(int DCMJLGEBFJK, int PCKDGMECGKP, [In] ReadOnlySpan<T> EHFNMHPIINL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2F00F30", Offset = "0x2F00330", VA = "0x182F00F30")]
	public static T[] CPMPPHNDLDI<T>(int JKIIGJDNBMO, T CAPODBOFBKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2F003A0", Offset = "0x2EFF7A0", VA = "0x182F003A0")]
	public static void APGCHCIPHGI<T>(this T[] KCDLNALOHCJ, T CAPODBOFBKO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2F01790", Offset = "0x2F00B90", VA = "0x182F01790")]
	public static void HJPIIODIHPL<T>(this T[] EFKOIGFMOHD, int CLDPBDGHEDO, int GGODLNFGCMG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2F00B70", Offset = "0x2EFFF70", VA = "0x182F00B70")]
	private static void BLGFPKCCPJD<T>(this T[] EAFEIEDNLNL, int JAIPKHJDIAH, int FELNFBCBOLJ, T[] OGKFFDCECEL, int LJMCJEPHCEL, int JKMLDEJDGPN, T[] HCMJFDLGOJF, int PACCFPLBAMD, DAPDPNIHNHN<T> HOEEGDOOJPO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2F01180", Offset = "0x2F00580", VA = "0x182F01180")]
	public static void FCELDLDDECI<T>(this T[] EAFEIEDNLNL, int PNGCLOMDHAJ, int GMOPHNCDIJO, DAPDPNIHNHN<T> HOEEGDOOJPO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2F02130", Offset = "0x2F01530", VA = "0x182F02130")]
	public static OLGCAIODHII<T> NAHEJEJDNOD<T>(this T[] EAFEIEDNLNL, DAPDPNIHNHN<T> HOEEGDOOJPO, int FEJHKLKMJEI, Func<bool> ANIAAFJMDKF, [Optional] T[]? OJAONCHMMDF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2F01810", Offset = "0x2F00C10", VA = "0x182F01810")]
	public static T[] IOAIBILMBGF<T>(this T[] EFKOIGFMOHD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2F01590", Offset = "0x2F00990", VA = "0x182F01590")]
	public static T[] FMIMHPIKMLL<T>(this T[] MKOBDDBDAJN, T CDHDJECPDHM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2F01860", Offset = "0x2F00C60", VA = "0x182F01860")]
	public static T[] MGPAJIAMIMG<T>(this T[] MKOBDDBDAJN, int OBFJPFHENMC, T CDHDJECPDHM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2F010D0", Offset = "0x2F004D0", VA = "0x182F010D0")]
	public static T[] ECFAIJEPOPJ<T>(this T[] MKOBDDBDAJN, int OBFJPFHENMC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2F021F0", Offset = "0x2F015F0", VA = "0x182F021F0")]
	public static T[] PDGOGEFPPPI<T>(this T[] MKOBDDBDAJN, int OBFJPFHENMC, T CDHDJECPDHM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2F00570", Offset = "0x2EFF970", VA = "0x182F00570")]
	public static U[] BDAAMOFGLDF<U, T>(this T[] AKAPKCMHDAP, int EGPCLEKNPCI, NNJNMOHMAJO<T, U> DIPJHLMMEKF) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C230", Offset = "0x6E1B630", VA = "0x186E1C230")]
	public static byte[] LDFEFBBBLPB(this byte[] EAFEIEDNLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BFB0", Offset = "0x6E1B3B0", VA = "0x186E1BFB0")]
	public static byte[] HKBGGEGKHFE(this byte[] EAFEIEDNLNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IMGEIILIAAB
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E19A20", Offset = "0x6E18E20", VA = "0x186E19A20")]
	public static byte KDICEDBHBBK(this bool EAFEIEDNLNL)
	{
		return default(byte);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class EJKDGGEMFMI
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E19A20", Offset = "0x6E18E20", VA = "0x186E19A20")]
	public static bool BLMFKHBNKMI(this byte EAFEIEDNLNL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class EMHALGJLCKK
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2D45C60", Offset = "0x2D45060", VA = "0x182D45C60")]
	public static void ABFBAIONGPI<T>(this ICollection<T> EAFEIEDNLNL, IEnumerable<T> GOLOFNEFPEG) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ANGFBNCOKLF
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x35D1B20", Offset = "0x35D0F20", VA = "0x1835D1B20")]
	public static V FJMBKPFMEPH<V, K>(this IDictionary<K, V> EAFEIEDNLNL, [In] K PBFBBOFLBNL, [In] V PFKKDHPJFEH, Func<V, V, V> EJILOIJNGDN) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x35D3210", Offset = "0x35D2610", VA = "0x1835D3210")]
	public static void JMPAAFOECGI<K, V>(this IDictionary<K, List<V>> EAFEIEDNLNL, [In] K PBFBBOFLBNL, [In] V PFKKDHPJFEH) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x35D23F0", Offset = "0x35D17F0", VA = "0x1835D23F0")]
	public static TVal HEFOPANDMHO<TVal, TKey>(this IDictionary<TKey, TVal> GCAOPEJPLMF, [In] TKey PBFBBOFLBNL, [Optional][ICFJKDIIEFO("`default!` shouldn't be necessary in C# 9")] TVal POOOEFHFGKB) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x35D2230", Offset = "0x35D1630", VA = "0x1835D2230")]
	public static TVal HEFOPANDMHO<TVal, TKey>(this IDictionary<TKey, TVal> GCAOPEJPLMF, [In] TKey PBFBBOFLBNL, Func<TVal> PDOKFNEMNNJ) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x35D3830", Offset = "0x35D2C30", VA = "0x1835D3830")]
	public static TValue LLMLCIBLEKE<TValue, TKey>(this IDictionary<TKey, TValue> GCAOPEJPLMF, [In] TKey PBFBBOFLBNL, [Optional][In][ICFJKDIIEFO("`default!` and null-oblivious region shouldn't be necessary in C# 9")] TValue POOOEFHFGKB)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x35D43E0", Offset = "0x35D37E0", VA = "0x1835D43E0")]
	public static V NHJCCDKNBEP<V, K>(this IDictionary<K, V> EAFEIEDNLNL, [In] K PBFBBOFLBNL) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x35D4850", Offset = "0x35D3C50", VA = "0x1835D4850")]
	public static T2[] PHBKKJCGHEL<T2, T1>(this Dictionary<T1, T2>.ValueCollection MHCKEDMKHKI) where T2 : notnull where T1 : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CPIHEGPAHII
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate bool CNFJCMEAGNC<TArgs, T>([In] TArgs KCHFAPGLICB, T DHLKAMHBBEP);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate U FENCJOJLHEO<TArg, U>([In] TArg IDJEKAFFOBD);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate U IPKJEBCIHKN<TArg, T, U>([In] TArg IDJEKAFFOBD, T MMGNDBIPIEK);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate U OGNNFEMNONL<TArg, T, U>([In] TArg IDJEKAFFOBD, IEnumerable<T> PAJGOMPLFDK);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate U DJEFMNIAAEE<TArg, T, U>([In] TArg IDJEKAFFOBD, T MMGNDBIPIEK);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct LHGGMPLOGKO<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4607910", Offset = "0x4606D10", VA = "0x184607910")]
		[ICFJKDIIEFO("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) LOJNPLMHBHO(T BLDHDDLPAED)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x46078B0", Offset = "0x4606CB0", VA = "0x1846078B0")]
		[ICFJKDIIEFO("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) DKHCEIFKKGO(IEnumerable<T> ECAJPLGADJL)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class BALDAAMKPHO<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0xA02AE0", Offset = "0xA01EE0", VA = "0x180A02AE0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5217590", Offset = "0x5216990", VA = "0x185217590", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xDAF920", Offset = "0xDAED20", VA = "0x180DAF920")]
		[DebuggerHidden]
		public BALDAAMKPHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3D87970", Offset = "0x3D86D70", VA = "0x183D87970", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5216F80", Offset = "0x5216380", VA = "0x185216F80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5216B20", Offset = "0x5215F20", VA = "0x185216B20")]
		private void KAONCANHJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5217540", Offset = "0x5216940", VA = "0x185217540", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5217410", Offset = "0x5216810", VA = "0x185217410", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x496C6A0", Offset = "0x496BAA0", VA = "0x18496C6A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class PCJJMADMJEI<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8F0370", Offset = "0x8EF770", VA = "0x1808F0370")]
		[DebuggerHidden]
		public PCJJMADMJEI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4B16780", Offset = "0x4B15B80", VA = "0x184B16780", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4B16020", Offset = "0x4B15420", VA = "0x184B16020", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4B157B0", Offset = "0x4B14BB0", VA = "0x184B157B0")]
		private void KAONCANHJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4B163A0", Offset = "0x4B157A0", VA = "0x184B163A0")]
		private void NJJPNOJLCPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4B166E0", Offset = "0x4B15AE0", VA = "0x184B166E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4B164A0", Offset = "0x4B158A0", VA = "0x184B164A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0D70", Offset = "0x3EE0170", VA = "0x183EE0D70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class HEPICOADCPE<T> : IEnumerable<(T, BLOKLLOGIFH<T>)>, IEnumerable, IEnumerator<(T, BLOKLLOGIFH<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private (T Current, BLOKLLOGIFH<T> Next) <>2__current;

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
		private (T, BLOKLLOGIFH<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x3C0C7F0", Offset = "0x3C0BBF0", VA = "0x183C0C7F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, BLOKLLOGIFH<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x4130020", Offset = "0x412F420", VA = "0x184130020", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x214A630", Offset = "0x2149A30", VA = "0x18214A630")]
		[DebuggerHidden]
		public HEPICOADCPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3EDED00", Offset = "0x3EDE100", VA = "0x183EDED00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x412F720", Offset = "0x412EB20", VA = "0x18412F720", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x412E6A0", Offset = "0x412DAA0", VA = "0x18412E6A0")]
		private void KAONCANHJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x412FF80", Offset = "0x412F380", VA = "0x18412FF80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x412FBA0", Offset = "0x412EFA0", VA = "0x18412FBA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, BLOKLLOGIFH<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0D70", Offset = "0x3EE0170", VA = "0x183EE0D70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GOLAHIJIFMH<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
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
		private Func<LHGGMPLOGKO<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Func<LHGGMPLOGKO<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

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
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8F0370", Offset = "0x8EF770", VA = "0x1808F0370")]
		[DebuggerHidden]
		public GOLAHIJIFMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x407F1C0", Offset = "0x407E5C0", VA = "0x18407F1C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x407ECA0", Offset = "0x407E0A0", VA = "0x18407ECA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x407EC50", Offset = "0x407E050", VA = "0x18407EC50")]
		private void KAONCANHJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x407F120", Offset = "0x407E520", VA = "0x18407F120")]
		private void NJJPNOJLCPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x407F170", Offset = "0x407E570", VA = "0x18407F170", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3F9CD90", Offset = "0x3F9C190", VA = "0x183F9CD90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3F9D490", Offset = "0x3F9C890", VA = "0x183F9D490", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PEHHDMKBJCO<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public PEHHDMKBJCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4B21190", Offset = "0x4B20590", VA = "0x184B21190")]
		internal bool ECIDDGCHJHF(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x4B211F0", Offset = "0x4B205F0", VA = "0x184B211F0")]
		internal bool OLBIHHGNJLD(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class MBNEKALFGLL<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x96D130", Offset = "0x96C530", VA = "0x18096D130", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F937A0", Offset = "0x3F92BA0", VA = "0x183F937A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x214A630", Offset = "0x2149A30", VA = "0x18214A630")]
		[DebuggerHidden]
		public MBNEKALFGLL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4852070", Offset = "0x4851470", VA = "0x184852070", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4852370", Offset = "0x4851770", VA = "0x184852370", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4852290", Offset = "0x4851690", VA = "0x184852290", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0D70", Offset = "0x3EE0170", VA = "0x183EE0D70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2CADF70", Offset = "0x2CAD370", VA = "0x182CADF70")]
	public static bool CDFJKABCJJL<T, TArgs>(this IEnumerable<T> EAFEIEDNLNL, [In] TArgs KCHFAPGLICB, CNFJCMEAGNC<TArgs, T> BFGIIPOMICH) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E18BB0", Offset = "0x6E17FB0", VA = "0x186E18BB0")]
	public static bool CDFJKABCJJL(this IEnumerable<bool> EAFEIEDNLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2CAFD50", Offset = "0x2CAF150", VA = "0x182CAFD50")]
	public static U ICDFHLKJMLI<U, T>(this IEnumerable<T> EAFEIEDNLNL, Func<U> IOKAAOCALNA, Func<T, U> BLDHDDLPAED, Func<IEnumerable<T>, U> ECAJPLGADJL) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2CAFFC0", Offset = "0x2CAF3C0", VA = "0x182CAFFC0")]
	public static bool ILKPEOPDCHB<T, TArgs>(this IEnumerable<T> EAFEIEDNLNL, [In] TArgs KCHFAPGLICB, CNFJCMEAGNC<TArgs, T> BFGIIPOMICH) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2CB0800", Offset = "0x2CAFC00", VA = "0x182CB0800")]
	public static U JPMMNOFBLKF<U, T, TArg>(this IEnumerable<T> EAFEIEDNLNL, [In] TArg IDJEKAFFOBD, FENCJOJLHEO<TArg, U> IOKAAOCALNA, IPKJEBCIHKN<TArg, T, U> BLDHDDLPAED, OGNNFEMNONL<TArg, T, U> ECAJPLGADJL) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2CAF4C0", Offset = "0x2CAE8C0", VA = "0x182CAF4C0")]
	public static IEnumerable<U> FNMDCALPFIE<U, T, TArg>(this IEnumerable<T> EAFEIEDNLNL, [In] TArg IDJEKAFFOBD, DJEFMNIAAEE<TArg, T, U> AMEBNJELHNM) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2CAD870", Offset = "0x2CACC70", VA = "0x182CAD870")]
	public static IEnumerable<T> AAMKJBGKJCN<T>(params IEnumerable<T>[] FDKBMNKOGNI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2CB16F0", Offset = "0x2CB0AF0", VA = "0x182CB16F0")]
	public static bool MOKDBPFCBFL<T>(this IEnumerable<T> LHOBDGJGOHD, IEnumerable<T> OGKFFDCECEL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2CAD870", Offset = "0x2CACC70", VA = "0x182CAD870")]
	public static IEnumerable<(TKey?, TValue?)>? DDHEEKKDGPG<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> EAFEIEDNLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2CAFB30", Offset = "0x2CAEF30", VA = "0x182CAFB30")]
	public static IEnumerable<T> HALCACIAHFP<T, TKey>(this IEnumerable<T> PCOKDBCIIJH, Func<T, TKey> JKJMIPOMJKO) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2CAED90", Offset = "0x2CAE190", VA = "0x182CAED90")]
	[IteratorStateMachine(typeof(BALDAAMKPHO<>))]
	public static IEnumerable<T> DIPHNIMKGMI<T>(this IEnumerable<T> LHOBDGJGOHD, ISet<T> GPAEPPMNJEB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1620", Offset = "0x2CB0A20", VA = "0x182CB1620")]
	[IteratorStateMachine(typeof(PCJJMADMJEI<, >))]
	public static IEnumerable<T> MIFLIGOFKEA<T, U>(this IEnumerable<T> EAFEIEDNLNL, IEnumerable<U> OGKFFDCECEL, [Optional][ICFJKDIIEFO("`default!` shouldn't be necessary in C# 9")] T CAPODBOFBKO) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2BAFA60", Offset = "0x2BAEE60", VA = "0x182BAFA60")]
	public static T DKPBCDPFFDO<T>(this IEnumerable<T> LHOBDGJGOHD, T POOOEFHFGKB) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2CAEF10", Offset = "0x2CAE310", VA = "0x182CAEF10")]
	public static T DKPBCDPFFDO<T>(this IEnumerable<T> LHOBDGJGOHD, T POOOEFHFGKB, Func<T, bool> BFGIIPOMICH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2CB41D0", Offset = "0x2CB35D0", VA = "0x182CB41D0")]
	public static T? PLJHFKJCAAO<T>(this IEnumerable<T> EAFEIEDNLNL, Func<T, bool> BFGIIPOMICH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2CB3270", Offset = "0x2CB2670", VA = "0x182CB3270")]
	public static void OHLNNPINADD<T>(this IEnumerable<T> EAFEIEDNLNL, Action<T> NIDEPJKLLAB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2CAF2E0", Offset = "0x2CAE6E0", VA = "0x182CAF2E0")]
	[IteratorStateMachine(typeof(HEPICOADCPE<>))]
	public static IEnumerable<(T, BLOKLLOGIFH<T>)> FLEHNFBFNFM<T>(this IEnumerable<T> EAFEIEDNLNL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2CAFA00", Offset = "0x2CAEE00", VA = "0x182CAFA00")]
	public static bool GFIFJOECABB<T>(this IEnumerable<T> EAFEIEDNLNL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2CAD870", Offset = "0x2CACC70", VA = "0x182CAD870")]
	public static IEnumerable<HNIOEALEKLD<T>> DIJEOHGLGIA<T>(this IEnumerable<T> EAFEIEDNLNL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2CAF200", Offset = "0x2CAE600", VA = "0x182CAF200")]
	public static bool FKFNLLHBIGN<T>(this IEnumerable<T> EAFEIEDNLNL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2CAED50", Offset = "0x2CAE150", VA = "0x182CAED50")]
	public static IEnumerable<T> DFHJIDDNGKC<T>(this IEnumerable<T>? EAFEIEDNLNL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2CB4110", Offset = "0x2CB3510", VA = "0x182CB4110")]
	[IteratorStateMachine(typeof(GOLAHIJIFMH<, >))]
	public static IEnumerable<U> PDPCHIDDEOL<U, T>(this IEnumerable<T> EAFEIEDNLNL, Func<LHGGMPLOGKO<U>, T, (bool Zero, U One, IEnumerable<U> Many)> LKMOFPDAHPC) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2CAD870", Offset = "0x2CACC70", VA = "0x182CAD870")]
	public static IEnumerable<T> HGEIJECOMJH<T>(this IEnumerable<IEnumerable<T>> EAFEIEDNLNL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2CB3CC0", Offset = "0x2CB30C0", VA = "0x182CB3CC0")]
	public static int PAIBFBMMBKG<T>(this IEnumerable<T> EAFEIEDNLNL, int AKILFOLEFAM = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2CAEF90", Offset = "0x2CAE390", VA = "0x182CAEF90")]
	public static bool EKCMAIFAMGP<T>(this IEnumerable<T> EAFEIEDNLNL, IEnumerable<T> OGKFFDCECEL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2CAECD0", Offset = "0x2CAE0D0", VA = "0x182CAECD0")]
	public static IEnumerable<T> DCPMGIGPFBE<T>(this IEnumerable<T> EAFEIEDNLNL, int HMAJMJOCJJN, int JCBHBDBOIBM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2CB2B40", Offset = "0x2CB1F40", VA = "0x182CB2B40")]
	public static (IEnumerable<T>, IEnumerable<T>) ODLHLGBHHOE<T>(this IEnumerable<T> EAFEIEDNLNL, Func<T, bool> LPAOMHAKNEK) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2CB0F20", Offset = "0x2CB0320", VA = "0x182CB0F20")]
	public static string LKOHGOHPNPC<T>(this IEnumerable<T> EAFEIEDNLNL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2CB0500", Offset = "0x2CAF900", VA = "0x182CB0500")]
	public static Dictionary<TKey?, TValue?>? JMLMCOPDBKH<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> LHOBDGJGOHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2CB0500", Offset = "0x2CAF900", VA = "0x182CB0500")]
	public static Dictionary<TKey?, TValue?>? JMLMCOPDBKH<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> LHOBDGJGOHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1470", Offset = "0x2CB0870", VA = "0x182CB1470")]
	public static List<T> MBPPKBBBACN<T>(this IEnumerable<T> EAFEIEDNLNL, int PCJIPONCEAG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2CAFD10", Offset = "0x2CAF110", VA = "0x182CAFD10")]
	public static string HIIAPDOEMBJ<T>(this IEnumerable<T> EAFEIEDNLNL, string GLEKNMMHKII) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2CAE3F0", Offset = "0x2CAD7F0", VA = "0x182CAE3F0")]
	public static (IReadOnlyList<T?>?, IReadOnlyList<U?>?) CJPOJCIGJOP<T, U>(this IEnumerable<(T Lhs, U Rhs)> EAFEIEDNLNL)
	{
		return default((IReadOnlyList<T>, IReadOnlyList<U>));
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2CB2540", Offset = "0x2CB1940", VA = "0x182CB2540")]
	[IteratorStateMachine(typeof(MBNEKALFGLL<, >))]
	public static IEnumerable<(T, U)> NDEDFLBKAAO<T, U>(this IEnumerable<T> MMHCOKHACHF, IEnumerable<U> DEOGINMLLDP) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1BB0", Offset = "0x2CB0FB0", VA = "0x182CB1BB0")]
	public static IEnumerable<V> MPFEJBNHLHM<V, T, U>(this IEnumerable<T> EAFEIEDNLNL, IEnumerable<U> OGKFFDCECEL, Func<T, U, V> ACLJDILNHND, [Optional][ICFJKDIIEFO("`default!` shouldn't be necessary in C# 9")] T AMBFHJDIHAE, [Optional][ICFJKDIIEFO("`default!` shouldn't be necessary in C# 9")] U CLGMONMECAF) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1C80", Offset = "0x2CB1080", VA = "0x182CB1C80")]
	public static IEnumerable<(T, U)> MPFEJBNHLHM<T, U>(this IEnumerable<T> EAFEIEDNLNL, IEnumerable<U> OGKFFDCECEL, [Optional][ICFJKDIIEFO("`default!` shouldn't be necessary in C# 9")] T AMBFHJDIHAE, [Optional][ICFJKDIIEFO("`default!` shouldn't be necessary in C# 9")] U CLGMONMECAF) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2CB2600", Offset = "0x2CB1A00", VA = "0x182CB2600")]
	public static TOut[] NEFPACHAFAC<TOut, TIn>(this IEnumerable<TIn> PCOKDBCIIJH, Func<TIn, TOut> GAHDIHNJECE) where TOut : notnull where TIn : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2CB1E60", Offset = "0x2CB1260", VA = "0x182CB1E60")]
	public static BLOKLLOGIFH<U> MPHIIJDKPGI<U, T>(this IEnumerable<T> EBMHLDOPMPB, Func<T, U> EMJBGLMPCAP) where U : notnull where T : notnull
	{
		return default(BLOKLLOGIFH<U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class POGKCLBIIIK
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x30A7010", Offset = "0x30A6410", VA = "0x1830A7010")]
	public static bool LLGJKLFFBMD<T, U>(this T EAFEIEDNLNL, [In] U FAKGLFFOLFI) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x30A6F70", Offset = "0x30A6370", VA = "0x1830A6F70")]
	public static bool GODFNBGFJFL<T>(T EAFEIEDNLNL, T OGKFFDCECEL) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class DFJMNKBLPED
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xF92DD0", Offset = "0xF921D0", VA = "0x180F92DD0")]
	public static bool LIHHJKENBAF([In] this float3 FIGPMCHHKJO, float3 LLNOONNFEHK, float KPCCFKCHLCB = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class DKNPALEEOIF
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class EOFPDHHMILL<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x96D130", Offset = "0x96C530", VA = "0x18096D130", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BB4BE0", Offset = "0x3BB3FE0", VA = "0x183BB4BE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x214A630", Offset = "0x2149A30", VA = "0x18214A630")]
		[DebuggerHidden]
		public EOFPDHHMILL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4680", Offset = "0x3BB3A80", VA = "0x183BB4680", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4AB0", Offset = "0x3BB3EB0", VA = "0x183BB4AB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4950", Offset = "0x3BB3D50", VA = "0x183BB4950", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4A20", Offset = "0x3BB3E20", VA = "0x183BB4A20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2CE5D70", Offset = "0x2CE5170", VA = "0x182CE5D70")]
	public static void DBIMAOIEIEO<T>(this T BNBMPMKBBFO, Action<T> ENDMGDGFCKH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2CE5DC0", Offset = "0x2CE51C0", VA = "0x182CE5DC0")]
	public static V GLDLKHPNMBH<V, T>(this T BNBMPMKBBFO, Func<T, V> ENDMGDGFCKH, [Optional][ICFJKDIIEFO("`default!` shouldn't be necessary in C# 9")] V POOOEFHFGKB) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6140", Offset = "0x2CE5540", VA = "0x182CE6140")]
	public static T? JCNBDOIKMHC<T>(this T EAFEIEDNLNL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2CE5EA0", Offset = "0x2CE52A0", VA = "0x182CE5EA0")]
	[IteratorStateMachine(typeof(EOFPDHHMILL<>))]
	public static IEnumerable<T> IPMOHNFEPLO<T>(this T EAFEIEDNLNL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6210", Offset = "0x2CE5610", VA = "0x182CE6210")]
	public static T[] NMMJBJOOIAF<T>(this T EAFEIEDNLNL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class ECALJAHGBCK
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6E18F00", Offset = "0x6E18300", VA = "0x186E18F00")]
	private static byte[] AHLNDDJBJNK(int JDGANJEDFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6E198C0", Offset = "0x6E18CC0", VA = "0x186E198C0")]
	private static byte[] FMAKLKMCMKF(long HFEONHFGMKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E19940", Offset = "0x6E18D40", VA = "0x186E19940")]
	private static byte[] HDKDLOOEDGJ(ulong HFEONHFGMKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6E196C0", Offset = "0x6E18AC0", VA = "0x186E196C0")]
	public static Guid BPBHKNKEKGK(params Guid[] KHDKADPEHFF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6E190C0", Offset = "0x6E184C0", VA = "0x186E190C0")]
	public static Guid ANJEPJLHJHG([In] Guid NIKLIHKMPCF, int OBFJPFHENMC, int FCPMNBOKKMJ = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6E18F80", Offset = "0x6E18380", VA = "0x186E18F80")]
	public static Guid ANJEPJLHJHG([In] Guid NIKLIHKMPCF, long OBFJPFHENMC, int FCPMNBOKKMJ = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6E195A0", Offset = "0x6E189A0", VA = "0x186E195A0")]
	public static Guid ANJEPJLHJHG([In] Guid NIKLIHKMPCF, ulong OBFJPFHENMC, int FCPMNBOKKMJ = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6E19050", Offset = "0x6E18450", VA = "0x186E19050")]
	public static Guid ANJEPJLHJHG([In] Guid NIKLIHKMPCF, [In] Guid MDEKCCBPLMG, int FCPMNBOKKMJ = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6E19190", Offset = "0x6E18590", VA = "0x186E19190")]
	private static Guid ANJEPJLHJHG([In] Guid NIKLIHKMPCF, byte[] POEPEDEDELN, int FCPMNBOKKMJ = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6E19830", Offset = "0x6E18C30", VA = "0x186E19830")]
	private static void CJGCFCNHKFN(byte[] MDOJFEIEAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6E19670", Offset = "0x6E18A70", VA = "0x186E19670")]
	private static void BMEIHAIDAGP(byte[] MDOJFEIEAFI, int CGCHNDGEIJH, int LEGMFFDGEGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class KABNCANHBDI
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D4A0", Offset = "0x6E1C8A0", VA = "0x186E1D4A0")]
	public static int IKFEJFBDBPP(this int EAFEIEDNLNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D560", Offset = "0x6E1C960", VA = "0x186E1D560")]
	public static int OIIPAAKMNBI(this int EAFEIEDNLNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D440", Offset = "0x6E1C840", VA = "0x186E1D440")]
	public static int DDCCCKJDAAA(this int EAFEIEDNLNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D490", Offset = "0x6E1C890", VA = "0x186E1D490")]
	public static int EMIJGNKGNOC(this int EAFEIEDNLNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB380", Offset = "0x5DEA780", VA = "0x185DEB380")]
	public static int MLCNEKFBGEP(this int EAFEIEDNLNL, int GMOPHNCDIJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBB80", Offset = "0x5EBAF80", VA = "0x185EBBB80")]
	public static int BNJFIHMHONH(this int EAFEIEDNLNL, int GMOPHNCDIJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D520", Offset = "0x6E1C920", VA = "0x186E1D520")]
	public static float NHGOCKDGBDA(this int EAFEIEDNLNL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D5A0", Offset = "0x6E1C9A0", VA = "0x186E1D5A0")]
	public static (byte, byte, byte, byte) POAHJAKCHJE(this int EAFEIEDNLNL)
	{
		return default((byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D540", Offset = "0x6E1C940", VA = "0x186E1D540")]
	public static int NLGKOIDEDAH([In] this (byte Fourth, byte Third, byte Second, byte First) EAFEIEDNLNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D510", Offset = "0x6E1C910", VA = "0x186E1D510")]
	public static int IMBKAPDNEPH(this int EAFEIEDNLNL, int DHGHIEENHAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D430", Offset = "0x6E1C830", VA = "0x186E1D430")]
	public static int CIIGDBJNAMK(this int EAFEIEDNLNL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class JNGKACJHBCI
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D150", Offset = "0x6E1C550", VA = "0x186E1D150")]
	public static (byte, byte, byte, byte, byte, byte, byte, byte) POAHJAKCHJE(this long EAFEIEDNLNL)
	{
		return default((byte, byte, byte, byte, byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D100", Offset = "0x6E1C500", VA = "0x186E1D100")]
	public static long PFCENCEFBAG([In] this (byte Eighth, byte Seventh, byte Sixth, byte Fifth, byte Fourth, byte Third, byte Second, byte First) EAFEIEDNLNL)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface HCBKPPCFIPG
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LDACBOJGIHJ(int AHALLEAIFOB, int PJILBNIEFOK);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float GIKFDIDCCJP(float DMOPOECFPLJ, float INIIMJEPADD);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface IBBJNDIGIPI
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	long NLPANEJBLAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class NFFAALPPACE
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x303E0E0", Offset = "0x303D4E0", VA = "0x18303E0E0")]
	public static (TKey?, TValue?) GOHDMGAFEOC<TKey, TValue>([In] this KeyValuePair<TKey, TValue> EAFEIEDNLNL)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x303E050", Offset = "0x303D450", VA = "0x18303E050")]
	public static KeyValuePair<TKey?, UValue?> FHOMNJEPBHM<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> EAFEIEDNLNL, UValue PFKKDHPJFEH)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class AIEEHDJOKAB
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class PJAMMIJMJMK<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public PJAMMIJMJMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4B3D360", Offset = "0x4B3C760", VA = "0x184B3D360")]
		internal TElement NIKOCKNABPG(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x35CAF30", Offset = "0x35CA330", VA = "0x1835CAF30")]
	public static int EPKDAMFHFCH<T>(this IReadOnlyList<T> EFKOIGFMOHD, T PFKKDHPJFEH) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x35CF1F0", Offset = "0x35CE5F0", VA = "0x1835CF1F0")]
	public static int MJGDGDOKMDD<T>(this IReadOnlyList<T> EFKOIGFMOHD, T PFKKDHPJFEH) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x35C7790", Offset = "0x35C6B90", VA = "0x1835C7790")]
	public static void ABFBAIONGPI<T>(this HashSet<T> PLGMOFBLCMM, IEnumerable<T> GOLOFNEFPEG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x35CA770", Offset = "0x35C9B70", VA = "0x1835CA770")]
	public static void EFCIIHDDAHD<T>(this IList<T> PBBPHMMFLFN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x35CA800", Offset = "0x35C9C00", VA = "0x1835CA800")]
	public static void EFCIIHDDAHD<T>(this IList<T> PBBPHMMFLFN, int DPOEFNHKMBJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x35CF630", Offset = "0x35CEA30", VA = "0x1835CF630")]
	public static void PONGGMPEDCC<T>(this List<T> PBBPHMMFLFN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x35CA5F0", Offset = "0x35C99F0", VA = "0x1835CA5F0")]
	public static List<T> DDIIAMPGOPK<T>(this List<T> JEDMGKEPJJK, Predicate<T> MAHENABLFBK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x35CB560", Offset = "0x35CA960", VA = "0x1835CB560")]
	public static int EPKDAMFHFCH<T>(this IReadOnlyList<T> PBBPHMMFLFN, Predicate<T> BFGIIPOMICH) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x35CEA80", Offset = "0x35CDE80", VA = "0x1835CEA80")]
	public static bool IAKMLIEGDFO<T>(this IReadOnlyList<T> PBBPHMMFLFN, Predicate<T> BFGIIPOMICH, [Out][NotNullWhen(true)] List<int>? GELILLPLHOC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x35C9170", Offset = "0x35C8570", VA = "0x1835C9170")]
	public static bool APJCMBOKLHP<T>(this IReadOnlyList<T> PBBPHMMFLFN, T DHLKAMHBBEP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x35C9020", Offset = "0x35C8420", VA = "0x1835C9020")]
	public static bool APJCMBOKLHP<T>(this IReadOnlyList<T> PBBPHMMFLFN, T DHLKAMHBBEP, EqualityComparer<T> LFBKIIFECDJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x35C9990", Offset = "0x35C8D90", VA = "0x1835C9990")]
	public static int BLOLFAJAHAJ<TElement, TKey>(this IList<TElement> LMHNNEFLKIF, TKey KGNNKAKALPA, Func<TElement, TKey> OCMOMBAOKIC, [Optional] Func<TKey, TKey, int>? HOEEGDOOJPO, int OBFJPFHENMC = 0, [Optional] int? GMOPHNCDIJO) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x35C95F0", Offset = "0x35C89F0", VA = "0x1835C95F0")]
	public static int BLOLFAJAHAJ<TElement, TKey>(Func<int, TElement> NJPPPAIPEPK, int GDMFPKBGPNJ, TKey KGNNKAKALPA, Func<TElement, TKey> OCMOMBAOKIC, [Optional] Func<TKey, TKey, int>? HOEEGDOOJPO, int OBFJPFHENMC = 0, [Optional] int? GMOPHNCDIJO) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x35CBC70", Offset = "0x35CB070", VA = "0x1835CBC70")]
	public static bool FHKIFFOLIHO<T>(this List<T> PBBPHMMFLFN, T DHLKAMHBBEP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x35CC4E0", Offset = "0x35CB8E0", VA = "0x1835CC4E0")]
	public static void HJIKLMAAJGM<T>(this List<T> PBBPHMMFLFN, IEnumerable<T> JEDMGKEPJJK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x35C91F0", Offset = "0x35C85F0", VA = "0x1835C91F0")]
	public static void BIJNEFLCHFA<T>(this List<T> PBBPHMMFLFN, IEnumerable<T> JEDMGKEPJJK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x35CE9F0", Offset = "0x35CDDF0", VA = "0x1835CE9F0")]
	public static T IACHDOMMPNC<T>(this List<T> JEDMGKEPJJK, Predicate<T> MAHENABLFBK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x35CA4C0", Offset = "0x35C98C0", VA = "0x1835CA4C0")]
	public static T BNHIGJGECBM<T>(this List<T> JEDMGKEPJJK, int OBFJPFHENMC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x35CF0C0", Offset = "0x35CE4C0", VA = "0x1835CF0C0")]
	public static void LKOJIMEHPFD<T>(this List<T> PBBPHMMFLFN, int OBFJPFHENMC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x35CEF20", Offset = "0x35CE320", VA = "0x1835CEF20")]
	public static bool JJLBDMANBGK<T>(this List<T> BHFECNEEFKL, List<T> JOCCBOFDLEF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x35CF3E0", Offset = "0x35CE7E0", VA = "0x1835CF3E0")]
	public static T MMMIFOAPFJD<T>(this IList<T> PBBPHMMFLFN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x35CF010", Offset = "0x35CE410", VA = "0x1835CF010")]
	public static bool KBNDMLJLBLP<T>(IReadOnlyList<T>? PBBPHMMFLFN, int OBFJPFHENMC, [Out][MaybeNullWhen(false)][ICFJKDIIEFO("This should be `T?` in C# 9.")] T HCMJFDLGOJF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x35CD9C0", Offset = "0x35CCDC0", VA = "0x1835CD9C0")]
	public static bool HPKNOIGJEMJ<T>(IReadOnlyList<T> PBBPHMMFLFN, ICollection JEDMGKEPJJK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x35CF480", Offset = "0x35CE880", VA = "0x1835CF480")]
	public static void MNFGNAJCBCB<T>(IReadOnlyList<T> PBBPHMMFLFN, ICollection JEDMGKEPJJK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2CCDBB0", Offset = "0x2CCCFB0", VA = "0x182CCDBB0")]
	public static bool PLJDPIKNEIE<T>(this IReadOnlyList<T> PBBPHMMFLFN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x35CC320", Offset = "0x35CB720", VA = "0x1835CC320")]
	public static string HANNMNGEPCJ<T>(this IEnumerable<T> PBBPHMMFLFN, string DODFMGCBGGJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x35CC180", Offset = "0x35CB580", VA = "0x1835CC180")]
	public static T GLFLLJGIAEB<T>(this IList<T> EAFEIEDNLNL) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x35C86C0", Offset = "0x35C7AC0", VA = "0x1835C86C0")]
	public static T AILAFNMLFMH<T>(this IList<T> EAFEIEDNLNL) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x35CA560", Offset = "0x35C9960", VA = "0x1835CA560")]
	public static void DCBMBAOMJBJ<T>(this IList<T> EAFEIEDNLNL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x35C84B0", Offset = "0x35C78B0", VA = "0x1835C84B0")]
	public static void AFIJELJNEJP<T>(this IList<T> EAFEIEDNLNL, [In] T PFKKDHPJFEH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x35CC220", Offset = "0x35CB620", VA = "0x1835CC220")]
	public static T GNPHDCJPDBF<T>(this IList<T> EAFEIEDNLNL) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x35CC710", Offset = "0x35CBB10", VA = "0x1835CC710")]
	public static void HMMKKEIAKFC<T>(this List<T> EAFEIEDNLNL) where T : struct, IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class FNBJLABKEDO
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static float EBEABKIJCPD;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static float PEIKIFBNGCO;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static bool OBGOMMDOJBF;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly float JLHJENMJCDP;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6E19F10", Offset = "0x6E19310", VA = "0x186E19F10")]
	public static bool IFBBOPJAFOK(float FIGPMCHHKJO, float LLNOONNFEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6E19D40", Offset = "0x6E19140", VA = "0x186E19D40")]
	public static float CDJIJPFMBAG(float PFKKDHPJFEH, float AOFEGKJKMDG, float FBENJJMLPKG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6E19D20", Offset = "0x6E19120", VA = "0x186E19D20")]
	public static int CDJIJPFMBAG(int PFKKDHPJFEH, int AOFEGKJKMDG, int FBENJJMLPKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A0C0", Offset = "0x6E194C0", VA = "0x186E1A0C0")]
	public static float LGLABHMBNCG(float PFKKDHPJFEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6E19C80", Offset = "0x6E19080", VA = "0x186E19C80")]
	public static float BNEKBOODNJN(float FIGPMCHHKJO, float LLNOONNFEHK, float BNBMPMKBBFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A100", Offset = "0x6E19500", VA = "0x186E1A100")]
	public static float NOAHIHKIGPB(float FIGPMCHHKJO, float LLNOONNFEHK, float BNBMPMKBBFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A000", Offset = "0x6E19400", VA = "0x186E1A000")]
	public static float IHAJBJBHGFE(float FIGPMCHHKJO, float LLNOONNFEHK, float PFKKDHPJFEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6E19DE0", Offset = "0x6E191E0", VA = "0x186E19DE0")]
	public static float FBJLBABFBKN(float FIGPMCHHKJO, float LLNOONNFEHK, float PFKKDHPJFEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A0E0", Offset = "0x6E194E0", VA = "0x186E1A0E0")]
	public static float LMDIGHBKKHF(float FIGPMCHHKJO, float LLNOONNFEHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6E19A30", Offset = "0x6E18E30", VA = "0x186E19A30")]
	public static float AHAHDGHCNBE(float HHLPCCPCMEJ, float KLACLBHAHNL, float GAKGNBGDCND, float OPDNAJGOKBA, float ADLJPIBPOHJ, float FDMAJNEEBEL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6E19BF0", Offset = "0x6E18FF0", VA = "0x186E19BF0")]
	public static float ALCAKININPP(float PFKKDHPJFEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6E19E20", Offset = "0x6E19220", VA = "0x186E19E20")]
	public static float FEEKDNHIDEC(float PFKKDHPJFEH, float AOFEGKJKMDG, float FBENJJMLPKG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6E19D60", Offset = "0x6E19160", VA = "0x186E19D60")]
	public static float EDDMHLHOFPL(float FABAFKKHMGH)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class DGFHFHHOCGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private System.Random APDEFLJDEIF;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6E18D30", Offset = "0x6E18130", VA = "0x186E18D30")]
	public DGFHFHHOCGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6E18DC0", Offset = "0x6E181C0", VA = "0x186E18DC0")]
	public DGFHFHHOCGM(int DPOEFNHKMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6566C70", Offset = "0x6566070", VA = "0x186566C70", Slot = "4")]
	public virtual int LDACBOJGIHJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6E18CD0", Offset = "0x6E180D0", VA = "0x186E18CD0", Slot = "5")]
	public virtual int LDACBOJGIHJ(int PJILBNIEFOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6E184C0", Offset = "0x6E178C0", VA = "0x186E184C0", Slot = "6")]
	public virtual int LDACBOJGIHJ(int AHALLEAIFOB, int PJILBNIEFOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6E18D00", Offset = "0x6E18100", VA = "0x186E18D00")]
	public double PMAHCFMPBMO()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class LDDEJENEKMD
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2F856F0", Offset = "0x2F84AF0", VA = "0x182F856F0")]
	[GDCDIKCGJKC("This should be replaced with the `is not` operator in C# 9.")]
	public static bool HHJIIOGAAII<T>(this object EAFEIEDNLNL, [Out][NotNullWhen(true)] T HCMJFDLGOJF) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class LPHAILPHPML
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E4E0", Offset = "0x6E1D8E0", VA = "0x186E1E4E0")]
	public static (float3, float3, float3) EALPGNONEFI([In] this quaternion EAFEIEDNLNL)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DB70", Offset = "0x6E1CF70", VA = "0x186E1DB70")]
	private static float3 CNBPMNDMHII(quaternion JODLPOJCIAH, math.RotationOrder JBBCNNPIHOD = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E7D0", Offset = "0x6E1DBD0", VA = "0x186E1E7D0")]
	private static float3 MHGGHEPBOOJ(float3 DHDLGFKFKDJ, math.RotationOrder JBBCNNPIHOD)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E5D0", Offset = "0x6E1D9D0", VA = "0x186E1E5D0")]
	public static float3 FPLBDBEPHOJ(this quaternion JODLPOJCIAH, math.RotationOrder JBBCNNPIHOD = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E680", Offset = "0x6E1DA80", VA = "0x186E1E680")]
	public static float LBLADOFFDIJ(this quaternion MMHCOKHACHF, quaternion DEOGINMLLDP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E8A0", Offset = "0x6E1DCA0", VA = "0x186E1E8A0")]
	public static quaternion MOOGPNFOJLM(this quaternion GEMHEIIKJKD, float3 MOFKFEMMJEI)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DAE0", Offset = "0x6E1CEE0", VA = "0x186E1DAE0")]
	[CompilerGenerated]
	internal static float3 AMAMMIACMDH(float3 DHDLGFKFKDJ)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class IAIIHMGEMKN
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class BABHFLBEEKN : HCBKPPCFIPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly System.Random GDKFPLHAHLB;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6E184C0", Offset = "0x6E178C0", VA = "0x186E184C0", Slot = "4")]
		public int LDACBOJGIHJ(int DMOPOECFPLJ, int HCIKFNEKOOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6E18450", Offset = "0x6E17850", VA = "0x186E18450", Slot = "5")]
		public float GIKFDIDCCJP(float DMOPOECFPLJ, float INIIMJEPADD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6E184F0", Offset = "0x6E178F0", VA = "0x186E184F0")]
		private double PLCOBFGDELL()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6E18530", Offset = "0x6E17930", VA = "0x186E18530")]
		public BABHFLBEEKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly HCBKPPCFIPG OJBDMEJHNKM;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B3F0", Offset = "0x6E1A7F0", VA = "0x186E1B3F0")]
	public static ulong PEEADHOIINH()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class PLMHJNCBGFI
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x30A1B10", Offset = "0x30A0F10", VA = "0x1830A1B10")]
	public static bool FCOCDEKMLNP<T>(this IReadOnlyCollection<T> EAFEIEDNLNL, int OBFJPFHENMC) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class AAOLAGPDBCK
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x35BF640", Offset = "0x35BEA40", VA = "0x1835BF640")]
	public static bool DGKMLLKBBMI<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> EAFEIEDNLNL, IReadOnlyDictionary<TKey, TValue> OGKFFDCECEL) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class KNCBIADPBDA
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2F79440", Offset = "0x2F78840", VA = "0x182F79440")]
	public static TValue? GFMILPFHHPB<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> EAFEIEDNLNL, TKey PBFBBOFLBNL) where TValue : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class LCODEFKIOPK
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D850", Offset = "0x6E1CC50", VA = "0x186E1D850")]
	public static void IIFNBMCHKOM(this IReadOnlyList<Action> EAFEIEDNLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2F7F680", Offset = "0x2F7EA80", VA = "0x182F7F680")]
	public static bool NKKJANMEMGN<T>(this IReadOnlyList<T> EAFEIEDNLNL, int OBFJPFHENMC, [Out][ICFJKDIIEFO("This should be `T?` in C# 9.")][NotNullWhen(true)] T HCMJFDLGOJF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2F7F5A0", Offset = "0x2F7E9A0", VA = "0x182F7F5A0")]
	public static bool KKPOHIHLODH<T>(this IReadOnlyList<T> EAFEIEDNLNL, int OBFJPFHENMC, [Out] HNIOEALEKLD<T> HCMJFDLGOJF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2F7F440", Offset = "0x2F7E840", VA = "0x182F7F440")]
	public static T FNHJOKNPPED<T>(this IReadOnlyList<T> EAFEIEDNLNL, int OBFJPFHENMC, [In] T DJIHLAFGOIJ) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2EB09A0", Offset = "0x2EAFDA0", VA = "0x182EB09A0")]
	[ICFJKDIIEFO("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T BMGAKILKANM<T>(this IReadOnlyList<T> EAFEIEDNLNL, int OBFJPFHENMC) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2F7F4E0", Offset = "0x2F7E8E0", VA = "0x182F7F4E0")]
	public static T? GFMILPFHHPB<T>(this IReadOnlyList<T> EAFEIEDNLNL, int OBFJPFHENMC) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class JBENHNMEFOC
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2F03A10", Offset = "0x2F02E10", VA = "0x182F03A10")]
	public static int GEKFBAGACOL<T>([In] this ReadOnlySequence<T> ABPICDIBEMO, [In] T PFKKDHPJFEH) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2F035F0", Offset = "0x2F029F0", VA = "0x182F035F0")]
	public static bool FAPPGPFDPMC<T>([In] this ReadOnlySequence<T> ABPICDIBEMO, [In] ReadOnlySpan<T> OGKFFDCECEL) where T : IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class HDHKINCMCKF
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2EC82E0", Offset = "0x2EC76E0", VA = "0x182EC82E0")]
	public static string LKOHGOHPNPC<T>([In] this ReadOnlySpan<T> EAFEIEDNLNL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2EC7640", Offset = "0x2EC6A40", VA = "0x182EC7640")]
	public static string HIIAPDOEMBJ<T>([In] this ReadOnlySpan<T> EAFEIEDNLNL, string GLEKNMMHKII) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct KAPEKFCHIPE : IBBJNDIGIPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly IBBJNDIGIPI NMENHFJJPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly long LOJCIINOOHK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long NLPANEJBLAB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6E1D610", Offset = "0x6E1CA10", VA = "0x186E1D610", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double MPMOCHALGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6E1D6D0", Offset = "0x6E1CAD0", VA = "0x186E1D6D0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double KDPMGMOGOLO
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1D790", Offset = "0x6E1CB90", VA = "0x186E1D790")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x14E41E0", Offset = "0x14E35E0", VA = "0x1814E41E0")]
	public KAPEKFCHIPE(IBBJNDIGIPI HFMGJELKENH, long PLHLEDKFGBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class CJAEGFHLKIE
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static IBBJNDIGIPI HIPCODANBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6E18790", Offset = "0x6E17B90", VA = "0x186E18790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6E18860", Offset = "0x6E17C60", VA = "0x186E18860")]
	public static long IFNEOMHCBLO(this IBBJNDIGIPI EAFEIEDNLNL, long PLHLEDKFGBA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6E18700", Offset = "0x6E17B00", VA = "0x186E18700")]
	public static double BDIAEOFPFIH(this IBBJNDIGIPI EAFEIEDNLNL, long PLHLEDKFGBA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6E18670", Offset = "0x6E17A70", VA = "0x186E18670")]
	public static double ACKAFOHJILJ(this IBBJNDIGIPI EAFEIEDNLNL, long PLHLEDKFGBA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6E187E0", Offset = "0x6E17BE0", VA = "0x186E187E0")]
	public static KAPEKFCHIPE HCJBIDKFFMG(this IBBJNDIGIPI EAFEIEDNLNL)
	{
		return default(KAPEKFCHIPE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class PFKCAFIIJNE : IBBJNDIGIPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Stopwatch AKANMCJMEPJ;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long NLPANEJBLAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6E1EC40", Offset = "0x6E1E040", VA = "0x186E1EC40", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	private PFKCAFIIJNE(Stopwatch JCMBABGDKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6E1ED10", Offset = "0x6E1E110", VA = "0x186E1ED10")]
	public static PFKCAFIIJNE MNIMJGKNJPL(Stopwatch JCMBABGDKPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EC60", Offset = "0x6E1E060", VA = "0x186E1EC60")]
	public static PFKCAFIIJNE EHLKHGGIGOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class EIFJJELEIOI
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6D5EC40", Offset = "0x6D5E040", VA = "0x186D5EC40")]
	public static float3 ANHAHLKJEHG([In] this RigidTransform EAFEIEDNLNL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6D5ED70", Offset = "0x6D5E170", VA = "0x186D5ED70")]
	public static float3 CLDDOGFAOJA([In] this RigidTransform EAFEIEDNLNL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0xC82BE0", Offset = "0xC81FE0", VA = "0x180C82BE0")]
	public static (float3, float3, float3) PJJAIEANGGL([In] this RigidTransform EAFEIEDNLNL)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6E199C0", Offset = "0x6E18DC0", VA = "0x186E199C0")]
	public static RigidTransform MNGNCKNIEDG([In] this RigidTransform EAFEIEDNLNL)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class DKACDIJAHOO
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6E18E40", Offset = "0x6E18240", VA = "0x186E18E40")]
	public static RigidTransform GMOCLHFHJJG(RigidTransform CCNGGHNKABC, RigidTransform GLENOJAODCJ)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class CGKHKPLCIAA
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6E185C0", Offset = "0x6E179C0", VA = "0x186E185C0")]
	public static float CBGKACFHJAH([In] this (byte Fourth, byte Third, byte Second, byte First) EAFEIEDNLNL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6E185B0", Offset = "0x6E179B0", VA = "0x186E185B0")]
	public static int BMMFEFPNBFD(this float EAFEIEDNLNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6E18600", Offset = "0x6E17A00", VA = "0x186E18600")]
	public static (byte, byte, byte, byte) POAHJAKCHJE(this float EAFEIEDNLNL)
	{
		return default((byte, byte, byte, byte));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class CFKGGBDOAJI
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA260", Offset = "0x2CA9660", VA = "0x182CAA260")]
	public static ReadOnlySpan<T?> MAIKGDPKHMK<T>([In] this Span<T> EAFEIEDNLNL)
	{
		return default(ReadOnlySpan<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class ABHEMBDEEJP
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6E18320", Offset = "0x6E17720", VA = "0x186E18320")]
	public static StringBuilder EPELMGLOEGA(this StringBuilder EAFEIEDNLNL, int GEAKOIDLFNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6E18380", Offset = "0x6E17780", VA = "0x186E18380")]
	public static StringBuilder LLFLJJAJGPC(this StringBuilder EAFEIEDNLNL, int GEAKOIDLFNK, string BBLEEPEBKMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6E183F0", Offset = "0x6E177F0", VA = "0x186E183F0")]
	public static StringBuilder MJEOGEENIIE(this StringBuilder EAFEIEDNLNL, char NJAPALOBBDB, int MAGAEDGOHNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class JIBKBNJLFJF
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static Regex MHJKNFCPGGO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static Regex DKHEIEJCAHO;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly char[] FCIAGJAOAJH;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly string[] EDFGEPLHDNN;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x61826D0", Offset = "0x6181AD0", VA = "0x1861826D0")]
	public static bool PLJDPIKNEIE(this string? BHGJJKCLFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C540", Offset = "0x6E1B940", VA = "0x186E1C540")]
	public static string? CIIFKKGHPDA(this string? EAFEIEDNLNL, int CBPLCBHEDDF, string BHIMILJBMDE = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6E1CBB0", Offset = "0x6E1BFB0", VA = "0x186E1CBB0")]
	public static string ILPOKALLNID(this string EAFEIEDNLNL, int CBPLCBHEDDF, string BHIMILJBMDE = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C4D0", Offset = "0x6E1B8D0", VA = "0x186E1C4D0")]
	public static int ALFAKHOPPKI(this string BHGJJKCLFGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1CC60", Offset = "0x6E1C060", VA = "0x186E1CC60")]
	public static string LFIKIKAKHHM(this string BHGJJKCLFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1CD20", Offset = "0x6E1C120", VA = "0x186E1CD20")]
	public static string[] OEFADDIIFLM(this string BHGJJKCLFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1CB20", Offset = "0x6E1BF20", VA = "0x186E1CB20")]
	private static bool HAOPBEJKNNF(string KJNFHDLCDNH, int PNGCLOMDHAJ, [Out] int OHBCMHACGGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C620", Offset = "0x6E1BA20", VA = "0x186E1C620")]
	private static bool DBDJCOALHFK(string KJNFHDLCDNH, int PNGCLOMDHAJ, [Out] int OHBCMHACGGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C790", Offset = "0x6E1BB90", VA = "0x186E1C790")]
	public static int FIIKDNKGELA(string KJNFHDLCDNH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class IOEBLNHFHGG
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BF80", Offset = "0x6E1B380", VA = "0x186E1BF80")]
	public static bool PAGJPCJJMNL(this Type EAFEIEDNLNL, Type OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2EF0880", Offset = "0x2EEFC80", VA = "0x182EF0880")]
	public static bool PAGJPCJJMNL<T>(this Type EAFEIEDNLNL) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class JGPEILFPDOK
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB380", Offset = "0x5DEA780", VA = "0x185DEB380")]
	public static uint MLCNEKFBGEP(this uint EAFEIEDNLNL, int GMOPHNCDIJO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBB80", Offset = "0x5EBAF80", VA = "0x185EBBB80")]
	public static uint BNJFIHMHONH(this uint EAFEIEDNLNL, int GMOPHNCDIJO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C4C0", Offset = "0x6E1B8C0", VA = "0x186E1C4C0")]
	public static uint OGOOKDCMMIH(this uint EAFEIEDNLNL, uint HKNMDKGFECG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x138DCA0", Offset = "0x138D0A0", VA = "0x18138DCA0")]
	public static int BMMFEFPNBFD(this uint EAFEIEDNLNL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class PNIDKFFBKGD
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x30A5600", Offset = "0x30A4A00", VA = "0x1830A5600")]
	public static T EIHOCHIKJCH<T>(IEnumerable<string> MOIHICEJBCC, [Optional] T POOOEFHFGKB) where T : struct, Enum, IConvertible
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x30A58A0", Offset = "0x30A4CA0", VA = "0x1830A58A0")]
	public static T KLJPPKEJBGG<T>(IEnumerable<string> MOIHICEJBCC, [Optional] T POOOEFHFGKB) where T : struct, Enum, IConvertible
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x30A51F0", Offset = "0x30A45F0", VA = "0x1830A51F0")]
	public static T CLDBHMPBNEA<T>(IEnumerable<string> MOIHICEJBCC, [Optional] T POOOEFHFGKB) where T : struct, Enum, IConvertible
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1ED80", Offset = "0x6E1E180", VA = "0x186E1ED80")]
	private static bool POANECHPLGO(Type CGMPPMEOEOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class DKOLLOECJOM
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2CE6900", Offset = "0x2CE5D00", VA = "0x182CE6900")]
	public static bool HGDPLOCLOKE<T>([In] this T? EAFEIEDNLNL, [Out] T PFKKDHPJFEH) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class GBPAILCALLL
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B1A0", Offset = "0x6E1A5A0", VA = "0x186E1B1A0")]
	public static CLKPBGJOMBF LELGMPLGCJO(IReadOnlyList<float> EIFGKHNPLEK, int BACHAHAGIFD = -1)
	{
		return default(CLKPBGJOMBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1AC10", Offset = "0x6E1A010", VA = "0x186E1AC10")]
	private static CLKPBGJOMBF JLPCCJHMBHI(IReadOnlyList<float> EIFGKHNPLEK, int BACHAHAGIFD)
	{
		return default(CLKPBGJOMBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B290", Offset = "0x6E1A690", VA = "0x186E1B290")]
	private static float NAOCNHEOCEA(IReadOnlyList<float> EIFGKHNPLEK, int GMOPHNCDIJO, float GJGDNDFDLHB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A8B0", Offset = "0x6E19CB0", VA = "0x186E1A8B0")]
	public static float CPKCIBHFJHD(IReadOnlyList<float> EIFGKHNPLEK, int ICLFANODKJK, int CCKNHLLGPCO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct OBBLLADGIAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly float GJGAKMKKOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly float OMAOEDDLHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly float BFKIJNODNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly float APFLDNEPLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly float GEDCPOAKCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly float DKKBGGFGHII;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EC10", Offset = "0x6E1E010", VA = "0x186E1EC10")]
	public OBBLLADGIAD(float LDOEFAHJEFE, float GAEHDPIOABL, float NBKCAGAELFC, float BNCPAJJDAEG, float IGMEJONIMLK, float KKLDHMLJBMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[Flags]
public enum MKHIGKGFFGO
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	N = 2,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Min = 4,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Max = 8,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Mean = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Median = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	SVariance = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	PVariance = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Q1 = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	Q3 = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	P25 = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	P50 = 0x800,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	P75 = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	P90 = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	P95 = 0x4000,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	P99 = 0x8000,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	PercentileFlags = 0xFC00,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct CLKPBGJOMBF
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class FNKJFLPGLCF : IEnumerable<(MKHIGKGFFGO, float)>, IEnumerable, IEnumerator<(MKHIGKGFFGO, float)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private (MKHIGKGFFGO flag, float result) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private MKHIGKGFFGO flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public MKHIGKGFFGO <>3__flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CLKPBGJOMBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CLKPBGJOMBF <>3__<>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private (MKHIGKGFFGO, float) System.Collections.Generic.IEnumerator<(RecRoom.NoEngine.Algorithms.Runtime.Stats.StatResultFlagsflag,System.Singleresult)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3C0C930", Offset = "0x3C0BD30", VA = "0x183C0C930", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((MKHIGKGFFGO, float));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x6E1A860", Offset = "0x6E19C60", VA = "0x186E1A860", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3EDA060", Offset = "0x3ED9460", VA = "0x183EDA060")]
		[DebuggerHidden]
		public FNKJFLPGLCF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A1F0", Offset = "0x6E195F0", VA = "0x186E1A1F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A810", Offset = "0x6E19C10", VA = "0x186E1A810", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A730", Offset = "0x6E19B30", VA = "0x186E1A730", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(MKHIGKGFFGO, float)> System.Collections.Generic.IEnumerable<(RecRoom.NoEngine.Algorithms.Runtime.Stats.StatResultFlagsflag,System.Singleresult)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A730", Offset = "0x6E19B30", VA = "0x186E1A730", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly int GHKOGJFFKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly float CKIPFHPIGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly float LMDIGHBKKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly float CLGOHHJLKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly float HMGJEIMLBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly float JPLMLFHGPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly float EKEMHLCECID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly float CNCMEPLPAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly OBBLLADGIAD LOBGEJKBKLP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float HAAGNPPLNMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6E189E0", Offset = "0x6E17DE0", VA = "0x186E189E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float OEEPOJICHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6E18A00", Offset = "0x6E17E00", VA = "0x186E18A00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6E18AD0", Offset = "0x6E17ED0", VA = "0x186E18AD0")]
	public CLKPBGJOMBF(int KNIHHDMJHNC, float AOFEGKJKMDG, float FBENJJMLPKG, float GCCHDGGFBPA, float DLNHEACLJIF, float JPLMLFHGPLO, float NOPLHEJJHEI, float PEHBHGPPKOA, OBBLLADGIAD NMAOIKEJHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6E18A20", Offset = "0x6E17E20", VA = "0x186E18A20")]
	[IteratorStateMachine(typeof(FNKJFLPGLCF))]
	public IEnumerable<(MKHIGKGFFGO, float)> IDLJDJPOOHN(MKHIGKGFFGO JADACNGBBCI)
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
