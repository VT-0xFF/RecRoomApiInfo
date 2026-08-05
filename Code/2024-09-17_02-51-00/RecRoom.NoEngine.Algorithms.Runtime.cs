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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D17B90", Offset = "0x6D16590", VA = "0x186D17B90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C2AE0", Offset = "0x8C14E0", VA = "0x1808C2AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2B20", Offset = "0x8C1520", VA = "0x1808C2B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MAABPNCHMDI
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string[] FBGOHBFFPLB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D16FA0", Offset = "0x6D159A0", VA = "0x186D16FA0")]
	public static bool GCPNLJFJNPG(string AAIAGHBAMFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D171C0", Offset = "0x6D15BC0", VA = "0x186D171C0")]
	private static bool NIKECKFPCAH(string KFAOBDLOMDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D17070", Offset = "0x6D15A70", VA = "0x186D17070")]
	public static bool NIKECKFPCAH(Exception LAHIFJKDMEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D17290", Offset = "0x6D15C90", VA = "0x186D17290")]
	public static string PPLCHEHCGLN(string KLNAGGGGPDK, string BPFGNDAPKAJ = "", bool GCEGJLCJDCG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BGOMBODFJLG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D13150", Offset = "0x6D11B50", VA = "0x186D13150")]
	public static string CGNCGDOBEGN(this Guid GDCMEHKEAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6D130B0", Offset = "0x6D11AB0", VA = "0x186D130B0")]
	public static string CGNCGDOBEGN(this byte[] CNGBPDKMHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6D131F0", Offset = "0x6D11BF0", VA = "0x186D131F0")]
	public static byte[] DPFEHOGAPDP(string HJODBOGPMKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DDALKNCGDHC
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int PJHOEEKJFJP<T>([In] T JDKMLCHPKLA, [In] T AENKMLMFBAD);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class PCCOAIIGDIN<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct IJGIMGEJHJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly int NBPJLJIBBHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public readonly int GNOIGGGFMCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public readonly bool CFIAAAHLEMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int JHLKCCDKLMD;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x40AC580", Offset = "0x40AAF80", VA = "0x1840AC580")]
			public IJGIMGEJHJN(int NBPJLJIBBHP, int GNOIGGGFMCH, bool CFIAAAHLEMM)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly T[] CIBEDEFIAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly T[] BIDLMFOHOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly PJHOEEKJFJP<T> AGCAFECCHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly int NDKMCJNPCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Func<bool> GIICGFJHCOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int PCGDEPPDCMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly IJGIMGEJHJN[] JNOEAKDLALB;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x49E20B0", Offset = "0x49E0AB0", VA = "0x1849E20B0")]
		public PCCOAIIGDIN(T[] CIBEDEFIAEJ, PJHOEEKJFJP<T> AGCAFECCHLJ, int NDKMCJNPCOG, Func<bool> GIICGFJHCOJ, T[]? IMNGIOGMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x49E1D80", Offset = "0x49E0780", VA = "0x1849E1D80")]
		public bool CIFKNMOBGHA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate U IILLNAJNGIB<T, U>(int JDIKCPODCIN, int FCEJPNLOAIJ, [In] ReadOnlySpan<T> LFDGBCGGLCM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE740", Offset = "0x2BAD140", VA = "0x182BAE740")]
	public static T[] OCKLJLDOPCL<T>(int BHEAFIOEIAD, T LFMHIDKAJGK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2BADC40", Offset = "0x2BAC640", VA = "0x182BADC40")]
	public static void KHEMCCHICCN<T>(this T[] KFMNKHBNPKA, T LFMHIDKAJGK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2BACE90", Offset = "0x2BAB890", VA = "0x182BACE90")]
	public static void DCFGHBNCOAN<T>(this T[] DKEEEGEFALD, int DMIMFDDIIBO, int DBINMLKKFGD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2BADF60", Offset = "0x2BAC960", VA = "0x182BADF60")]
	private static void MDALGGKKPMB<T>(this T[] BJNJBGHPMEH, int EBJPCNAAAAE, int EHCPCHLNKIM, T[] PLNBHPCFEOK, int DJFLBINNMAF, int IOICNKKFGNI, T[] POBDLJBBBCI, int NIEABNICJEK, PJHOEEKJFJP<T> AGCAFECCHLJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE330", Offset = "0x2BACD30", VA = "0x182BAE330")]
	public static void NBODPLMGHOO<T>(this T[] BJNJBGHPMEH, int NBPJLJIBBHP, int FIGHABPEBPG, PJHOEEKJFJP<T> AGCAFECCHLJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2BACFC0", Offset = "0x2BAB9C0", VA = "0x182BACFC0")]
	public static PCCOAIIGDIN<T> EJHJPEOMPHK<T>(this T[] BJNJBGHPMEH, PJHOEEKJFJP<T> AGCAFECCHLJ, int NDKMCJNPCOG, Func<bool> GIICGFJHCOJ, [Optional] T[]? IMNGIOGMMOG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD080", Offset = "0x2BABA80", VA = "0x182BAD080")]
	public static T[] FAFLFGECIEO<T>(this T[] DKEEEGEFALD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2BADE10", Offset = "0x2BAC810", VA = "0x182BADE10")]
	public static T[] LPFJGDGEMHJ<T>(this T[] MMILIPAEHND, T KPBHJNBJCGO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD0D0", Offset = "0x2BABAD0", VA = "0x182BAD0D0")]
	public static T[] FDEPCHNGLII<T>(this T[] MMILIPAEHND, int HGFDMIDEFHN, T KPBHJNBJCGO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2BACF10", Offset = "0x2BAB910", VA = "0x182BACF10")]
	public static T[] EHGNEHBNIFM<T>(this T[] MMILIPAEHND, int HGFDMIDEFHN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2BAD9A0", Offset = "0x2BAC3A0", VA = "0x182BAD9A0")]
	public static T[] FKGOIKCOLPO<T>(this T[] MMILIPAEHND, int HGFDMIDEFHN, T KPBHJNBJCGO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE8E0", Offset = "0x2BAD2E0", VA = "0x182BAE8E0")]
	public static U[] OPKIHEMBNHO<U, T>(this T[] KCIKOPILENN, int NHHHGBKMLJI, IILLNAJNGIB<T, U> GPPMNPPNIBB) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6D13640", Offset = "0x6D12040", VA = "0x186D13640")]
	public static byte[] PFIAIPJLKPA(this byte[] BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6D133C0", Offset = "0x6D11DC0", VA = "0x186D133C0")]
	public static byte[] KNKFOMFLGND(this byte[] BJNJBGHPMEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MPKBLFHGBEA
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D12EB0", Offset = "0x6D118B0", VA = "0x186D12EB0")]
	public static byte BFHFDPBBMLN(this bool BJNJBGHPMEH)
	{
		return default(byte);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class ADNKOJAMGHI
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D12EB0", Offset = "0x6D118B0", VA = "0x186D12EB0")]
	public static bool PPNJKPJLNEK(this byte BJNJBGHPMEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class ENKPDEHOFOL
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2BF23E0", Offset = "0x2BF0DE0", VA = "0x182BF23E0")]
	public static void ANBIJFEAHKA<T>(this ICollection<T> BJNJBGHPMEH, IEnumerable<T> PCIGIFGMPKJ) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ECKHNJIJCOD
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2BECD80", Offset = "0x2BEB780", VA = "0x182BECD80")]
	public static V ONFBMMCFBPL<V, K>(this IDictionary<K, V> BJNJBGHPMEH, [In] K LFOBGDLOPID, [In] V KLABJGGMBGH, Func<V, V, V> DJEDMGMACCM) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2BEBD10", Offset = "0x2BEA710", VA = "0x182BEBD10")]
	public static void KBDEOAKIEFM<K, V>(this IDictionary<K, List<V>> BJNJBGHPMEH, [In] K LFOBGDLOPID, [In] V KLABJGGMBGH) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2BEAEE0", Offset = "0x2BE98E0", VA = "0x182BEAEE0")]
	public static TVal EADCAPENOHN<TVal, TKey>(this IDictionary<TKey, TVal> HGEMHLLLPMH, [In] TKey LFOBGDLOPID, [Optional][CPCEDDOKEKI("`default!` shouldn't be necessary in C# 9")] TVal MCAGMGIJFIA) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2BEAD20", Offset = "0x2BE9720", VA = "0x182BEAD20")]
	public static TVal EADCAPENOHN<TVal, TKey>(this IDictionary<TKey, TVal> HGEMHLLLPMH, [In] TKey LFOBGDLOPID, Func<TVal> LMGHMFACOIC) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC340", Offset = "0x2BEAD40", VA = "0x182BEC340")]
	public static TValue OIDAGPMOLPM<TValue, TKey>(this IDictionary<TKey, TValue> HGEMHLLLPMH, [In] TKey LFOBGDLOPID, [Optional][In][CPCEDDOKEKI("`default!` and null-oblivious region shouldn't be necessary in C# 9")] TValue MCAGMGIJFIA)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA7E0", Offset = "0x2BE91E0", VA = "0x182BEA7E0")]
	public static V CLGHOOKOFAC<V, K>(this IDictionary<K, V> BJNJBGHPMEH, [In] K LFOBGDLOPID) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2BEAC60", Offset = "0x2BE9660", VA = "0x182BEAC60")]
	public static T2[] DAJAPAGKKGO<T2, T1>(this Dictionary<T1, T2>.ValueCollection PBPNAFGELMA) where T2 : notnull where T1 : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GLLMHAEOEMO
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate bool AMMIHLKOBEN<TArgs, T>([In] TArgs AAAOIGBEBAB, T IFNDNLEGMFO);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate U DPCAEOKNMAE<TArg, U>([In] TArg IOBLLEKOCNN);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate U AGMCMDENKKG<TArg, T, U>([In] TArg IOBLLEKOCNN, T DJFACICIDCN);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate U MAJAMCEBCFF<TArg, T, U>([In] TArg IOBLLEKOCNN, IEnumerable<T> GMHOCNFEHGD);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate U MKFKJIDKDKA<TArg, T, U>([In] TArg IOBLLEKOCNN, T DJFACICIDCN);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct JMBKIEHCGGB<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4323D50", Offset = "0x4322750", VA = "0x184323D50")]
		[CPCEDDOKEKI("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) HHIHNNMOFAL(T LANBDILPIDD)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4323CF0", Offset = "0x43226F0", VA = "0x184323CF0")]
		[CPCEDDOKEKI("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) FFDPMNKLCDC(IEnumerable<T> BHCMIJNOGMB)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class FLIBOHCEOCO<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x924110", Offset = "0x922B10", VA = "0x180924110", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E074A0", Offset = "0x3E05EA0", VA = "0x183E074A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xCD3930", Offset = "0xCD2330", VA = "0x180CD3930")]
		[DebuggerHidden]
		public FLIBOHCEOCO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3C49710", Offset = "0x3C48110", VA = "0x183C49710", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3E06E30", Offset = "0x3E05830", VA = "0x183E06E30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3E06A20", Offset = "0x3E05420", VA = "0x183E06A20")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3E07450", Offset = "0x3E05E50", VA = "0x183E07450", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3E07200", Offset = "0x3E05C00", VA = "0x183E07200", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3E073C0", Offset = "0x3E05DC0", VA = "0x183E073C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class PHCNJNDAIFN<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x993D30", Offset = "0x992730", VA = "0x180993D30")]
		[DebuggerHidden]
		public PHCNJNDAIFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x49F0900", Offset = "0x49EF300", VA = "0x1849F0900", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x49EFAB0", Offset = "0x49EE4B0", VA = "0x1849EFAB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x49EFA00", Offset = "0x49EE400", VA = "0x1849EFA00")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x49EF960", Offset = "0x49EE360", VA = "0x1849EF960")]
		private void IOFDBJCEJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x49F0860", Offset = "0x49EF260", VA = "0x1849F0860", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x49F0610", Offset = "0x49EF010", VA = "0x1849F0610", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3C50EC0", Offset = "0x3C4F8C0", VA = "0x183C50EC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class MAINBBBNHBI<T> : IEnumerable<(T, OLCEOJBLPLC<T>)>, IEnumerable, IEnumerator<(T, OLCEOJBLPLC<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private (T Current, OLCEOJBLPLC<T> Next) <>2__current;

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
		private (T, OLCEOJBLPLC<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x3ABC4B0", Offset = "0x3ABAEB0", VA = "0x183ABC4B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, OLCEOJBLPLC<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x4721550", Offset = "0x471FF50", VA = "0x184721550", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x202D120", Offset = "0x202BB20", VA = "0x18202D120")]
		[DebuggerHidden]
		public MAINBBBNHBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3C4FEA0", Offset = "0x3C4E8A0", VA = "0x183C4FEA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x471FC60", Offset = "0x471E660", VA = "0x18471FC60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x471FBC0", Offset = "0x471E5C0", VA = "0x18471FBC0")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4721460", Offset = "0x471FE60", VA = "0x184721460", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4721170", Offset = "0x471FB70", VA = "0x184721170", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, OLCEOJBLPLC<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3C50EC0", Offset = "0x3C4F8C0", VA = "0x183C50EC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ANNBFHEPNDE<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
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
		private Func<JMBKIEHCGGB<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Func<JMBKIEHCGGB<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x993D30", Offset = "0x992730", VA = "0x180993D30")]
		[DebuggerHidden]
		public ANNBFHEPNDE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3FD72D0", Offset = "0x3FD5CD0", VA = "0x183FD72D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3FD6DF0", Offset = "0x3FD57F0", VA = "0x183FD6DF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3FD6DA0", Offset = "0x3FD57A0", VA = "0x183FD6DA0")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3FD6D50", Offset = "0x3FD5750", VA = "0x183FD6D50")]
		private void IOFDBJCEJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3FD7280", Offset = "0x3FD5C80", VA = "0x183FD7280", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3E4F020", Offset = "0x3E4DA20", VA = "0x183E4F020", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3E4F720", Offset = "0x3E4E120", VA = "0x183E4F720", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class KNKGEMAIAMB<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public KNKGEMAIAMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3F33280", Offset = "0x3F31C80", VA = "0x183F33280")]
		internal bool IPGOMNEIOJI(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x44440A0", Offset = "0x4442AA0", VA = "0x1844440A0")]
		internal bool GPIGPBLCDML(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class AAJNMBAAPFJ<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0xE88380", Offset = "0xE86D80", VA = "0x180E88380", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E4A020", Offset = "0x3E48A20", VA = "0x183E4A020", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x202D120", Offset = "0x202BB20", VA = "0x18202D120")]
		[DebuggerHidden]
		public AAJNMBAAPFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3E57890", Offset = "0x3E56290", VA = "0x183E57890", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3E57BA0", Offset = "0x3E565A0", VA = "0x183E57BA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3E57AC0", Offset = "0x3E564C0", VA = "0x183E57AC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3C50EC0", Offset = "0x3C4F8C0", VA = "0x183C50EC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2DB0CB0", Offset = "0x2DAF6B0", VA = "0x182DB0CB0")]
	public static bool OILBGKDDBDF<T, TArgs>(this IEnumerable<T> BJNJBGHPMEH, [In] TArgs AAAOIGBEBAB, AMMIHLKOBEN<TArgs, T> PLAHCKGGFOL) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D155D0", Offset = "0x6D13FD0", VA = "0x186D155D0")]
	public static bool OILBGKDDBDF(this IEnumerable<bool> BJNJBGHPMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC480", Offset = "0x2DAAE80", VA = "0x182DAC480")]
	public static U EKLKJDKFEPE<U, T>(this IEnumerable<T> BJNJBGHPMEH, Func<U> LOEGIAFJKCN, Func<T, U> LANBDILPIDD, Func<IEnumerable<T>, U> BHCMIJNOGMB) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC6F0", Offset = "0x2DAB0F0", VA = "0x182DAC6F0")]
	public static bool FBABIEKDOPN<T, TArgs>(this IEnumerable<T> BJNJBGHPMEH, [In] TArgs AAAOIGBEBAB, AMMIHLKOBEN<TArgs, T> PLAHCKGGFOL) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2DADC30", Offset = "0x2DAC630", VA = "0x182DADC30")]
	public static U HJFJGBFGONN<U, T, TArg>(this IEnumerable<T> BJNJBGHPMEH, [In] TArg IOBLLEKOCNN, DPCAEOKNMAE<TArg, U> LOEGIAFJKCN, AGMCMDENKKG<TArg, T, U> LANBDILPIDD, MAJAMCEBCFF<TArg, T, U> BHCMIJNOGMB) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2DAEEA0", Offset = "0x2DAD8A0", VA = "0x182DAEEA0")]
	public static IEnumerable<U> MNMKBNFICID<U, T, TArg>(this IEnumerable<T> BJNJBGHPMEH, [In] TArg IOBLLEKOCNN, MKFKJIDKDKA<TArg, T, U> LAAOPFHDHBG) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2D804A0", Offset = "0x2D7EEA0", VA = "0x182D804A0")]
	public static IEnumerable<T> LBNFELHBJCG<T>(params IEnumerable<T>[] KPAKBAPPHNJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2DACC30", Offset = "0x2DAB630", VA = "0x182DACC30")]
	public static bool FGPNDJNHIBG<T>(this IEnumerable<T> MKLJJBDOOGE, IEnumerable<T> PLNBHPCFEOK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2D804A0", Offset = "0x2D7EEA0", VA = "0x182D804A0")]
	public static IEnumerable<(TKey?, TValue?)>? EONCCAMPOGK<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1130", Offset = "0x2DAFB30", VA = "0x182DB1130")]
	public static IEnumerable<T> OILLLCLKIIJ<T, TKey>(this IEnumerable<T> KKBAGKHGAHE, Func<T, TKey> CJDAOHPMJPD) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2CCCAB0", Offset = "0x2CCB4B0", VA = "0x182CCCAB0")]
	[IteratorStateMachine(typeof(FLIBOHCEOCO<>))]
	public static IEnumerable<T> COGGGDCIEIP<T>(this IEnumerable<T> MKLJJBDOOGE, ISet<T> KFCFIIDHDBJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2CE4410", Offset = "0x2CE2E10", VA = "0x182CE4410")]
	[IteratorStateMachine(typeof(PHCNJNDAIFN<, >))]
	public static IEnumerable<T> CICBAMBOLBH<T, U>(this IEnumerable<T> BJNJBGHPMEH, IEnumerable<U> PLNBHPCFEOK, [Optional][CPCEDDOKEKI("`default!` shouldn't be necessary in C# 9")] T LFMHIDKAJGK) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2A5CF90", Offset = "0x2A5B990", VA = "0x182A5CF90")]
	public static T GCHKPJLDGFJ<T>(this IEnumerable<T> MKLJJBDOOGE, T MCAGMGIJFIA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2DACE60", Offset = "0x2DAB860", VA = "0x182DACE60")]
	public static T GCHKPJLDGFJ<T>(this IEnumerable<T> MKLJJBDOOGE, T MCAGMGIJFIA, Func<T, bool> PLAHCKGGFOL) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE590", Offset = "0x2DACF90", VA = "0x182DAE590")]
	public static T? IOJNMKPMFMI<T>(this IEnumerable<T> BJNJBGHPMEH, Func<T, bool> PLAHCKGGFOL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF800", Offset = "0x2DAE200", VA = "0x182DAF800")]
	public static void NBIFNCPJJJO<T>(this IEnumerable<T> BJNJBGHPMEH, Action<T> DLMFPIAEPPD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2C97E00", Offset = "0x2C96800", VA = "0x182C97E00")]
	[IteratorStateMachine(typeof(MAINBBBNHBI<>))]
	public static IEnumerable<(T, OLCEOJBLPLC<T>)> HGCGHIECOBD<T>(this IEnumerable<T> BJNJBGHPMEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1A80", Offset = "0x2DB0480", VA = "0x182DB1A80")]
	public static bool PNLEICMPCHJ<T>(this IEnumerable<T> BJNJBGHPMEH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2D804A0", Offset = "0x2D7EEA0", VA = "0x182D804A0")]
	public static IEnumerable<MGBLPJABDKK<T>> OAGDGHBELJN<T>(this IEnumerable<T> BJNJBGHPMEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2DACE20", Offset = "0x2DAB820", VA = "0x182DACE20")]
	public static bool FKPHAIMPOJM<T>(this IEnumerable<T> BJNJBGHPMEH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2DAB7F0", Offset = "0x2DAA1F0", VA = "0x182DAB7F0")]
	public static IEnumerable<T> DODGOJNICKA<T>(this IEnumerable<T>? BJNJBGHPMEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2C97A90", Offset = "0x2C96490", VA = "0x182C97A90")]
	[IteratorStateMachine(typeof(ANNBFHEPNDE<, >))]
	public static IEnumerable<U> GEACPOIEIAP<U, T>(this IEnumerable<T> BJNJBGHPMEH, Func<JMBKIEHCGGB<U>, T, (bool Zero, U One, IEnumerable<U> Many)> CAMENKDOGHH) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2D804A0", Offset = "0x2D7EEA0", VA = "0x182D804A0")]
	public static IEnumerable<T> NFAJDICKHLI<T>(this IEnumerable<IEnumerable<T>> BJNJBGHPMEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE130", Offset = "0x2DACB30", VA = "0x182DAE130")]
	public static int IEKLKHKLIJK<T>(this IEnumerable<T> BJNJBGHPMEH, int GAKIGLKAHAI = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2DAB580", Offset = "0x2DA9F80", VA = "0x182DAB580")]
	public static bool CLICLAABKKF<T>(this IEnumerable<T> BJNJBGHPMEH, IEnumerable<T> PLNBHPCFEOK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2DAEE20", Offset = "0x2DAD820", VA = "0x182DAEE20")]
	public static IEnumerable<T> KCOHJMPCDPI<T>(this IEnumerable<T> BJNJBGHPMEH, int LGMHLJPBKOE, int BCNKPEKIKLB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2DAB0A0", Offset = "0x2DA9AA0", VA = "0x182DAB0A0")]
	public static (IEnumerable<T>, IEnumerable<T>) AIFIFLNOENN<T>(this IEnumerable<T> BJNJBGHPMEH, Func<T, bool> CDCBKLPKDAJ) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1530", Offset = "0x2DAFF30", VA = "0x182DB1530")]
	public static string ONHANCKIDDN<T>(this IEnumerable<T> BJNJBGHPMEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD800", Offset = "0x2DAC200", VA = "0x182DAD800")]
	public static Dictionary<TKey?, TValue?>? HFOAHDOEEKE<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> MKLJJBDOOGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2DAD800", Offset = "0x2DAC200", VA = "0x182DAD800")]
	public static Dictionary<TKey?, TValue?>? HFOAHDOEEKE<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> MKLJJBDOOGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2DAB3D0", Offset = "0x2DA9DD0", VA = "0x182DAB3D0")]
	public static List<T> AOJADBJEDFH<T>(this IEnumerable<T> BJNJBGHPMEH, int HCAOLDLEJCN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2DACEE0", Offset = "0x2DAB8E0", VA = "0x182DACEE0")]
	public static string GCKKLFDHIEI<T>(this IEnumerable<T> BJNJBGHPMEH, string JNMPGCIKCCL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2DACF20", Offset = "0x2DAB920", VA = "0x182DACF20")]
	public static (IReadOnlyList<T?>?, IReadOnlyList<U?>?) HENAJECKEDB<T, U>(this IEnumerable<(T Lhs, U Rhs)> BJNJBGHPMEH)
	{
		return default((IReadOnlyList<T>, IReadOnlyList<U>));
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5D30", Offset = "0x2CC4730", VA = "0x182CC5D30")]
	[IteratorStateMachine(typeof(AAJNMBAAPFJ<, >))]
	public static IEnumerable<(T, U)> PMGLAKDOJMO<T, U>(this IEnumerable<T> JDKMLCHPKLA, IEnumerable<U> AENKMLMFBAD) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC1E0", Offset = "0x2DAABE0", VA = "0x182DAC1E0")]
	public static IEnumerable<V> EFNBBBLIADL<V, T, U>(this IEnumerable<T> BJNJBGHPMEH, IEnumerable<U> PLNBHPCFEOK, Func<T, U, V> IGGJMELAANP, [Optional][CPCEDDOKEKI("`default!` shouldn't be necessary in C# 9")] T BIHMCIMGALD, [Optional][CPCEDDOKEKI("`default!` shouldn't be necessary in C# 9")] U BGMCHNMJHJN) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2DAC2B0", Offset = "0x2DAACB0", VA = "0x182DAC2B0")]
	public static IEnumerable<(T, U)> EFNBBBLIADL<T, U>(this IEnumerable<T> BJNJBGHPMEH, IEnumerable<U> PLNBHPCFEOK, [Optional][CPCEDDOKEKI("`default!` shouldn't be necessary in C# 9")] T BIHMCIMGALD, [Optional][CPCEDDOKEKI("`default!` shouldn't be necessary in C# 9")] U BGMCHNMJHJN) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2DB0230", Offset = "0x2DAEC30", VA = "0x182DB0230")]
	public static TOut[] OGFADKHPKCI<TOut, TIn>(this IEnumerable<TIn> KKBAGKHGAHE, Func<TIn, TOut> PBJOCDGKHLM) where TOut : notnull where TIn : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2DAB830", Offset = "0x2DAA230", VA = "0x182DAB830")]
	public static OLCEOJBLPLC<U> DOGECJIFDEI<U, T>(this IEnumerable<T> OCCICMDPMFD, Func<T, U> FCIMJMHPEPD) where U : notnull where T : notnull
	{
		return default(OLCEOJBLPLC<U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class HMFACCCNPNF
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1AB0", Offset = "0x2DE04B0", VA = "0x182DE1AB0")]
	public static bool CFGKFCPDPBN<T, U>(this T BJNJBGHPMEH, [In] U GHMNBJIOGAM) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1A10", Offset = "0x2DE0410", VA = "0x182DE1A10")]
	public static bool ALBFCNMLCAH<T>(T BJNJBGHPMEH, T PLNBHPCFEOK) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class LJLIJANGCOJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1085C10", Offset = "0x1084610", VA = "0x181085C10")]
	public static bool IKMEAKAJFIJ([In] this float3 MOKDKAEJAPP, float3 MKGNFMMEFHC, float MOKHFMAOKLH = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class OPOIAEFMKHG
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class HIENLFEIGLJ<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0xE88380", Offset = "0xE86D80", VA = "0x180E88380", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DAFCE0", Offset = "0x3DAE6E0", VA = "0x183DAFCE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x202D120", Offset = "0x202BB20", VA = "0x18202D120")]
		[DebuggerHidden]
		public HIENLFEIGLJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3F401D0", Offset = "0x3F3EBD0", VA = "0x183F401D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3F403C0", Offset = "0x3F3EDC0", VA = "0x183F403C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3F402F0", Offset = "0x3F3ECF0", VA = "0x183F402F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3A40380", Offset = "0x3A3ED80", VA = "0x183A40380", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2F325E0", Offset = "0x2F30FE0", VA = "0x182F325E0")]
	public static void CKMHDEBAKHM<T>(this T KGPMLIHPPAA, Action<T> IODDMHCGLEA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2F323D0", Offset = "0x2F30DD0", VA = "0x182F323D0")]
	public static V BDIKEKLMAOA<V, T>(this T KGPMLIHPPAA, Func<T, V> IODDMHCGLEA, [Optional][CPCEDDOKEKI("`default!` shouldn't be necessary in C# 9")] V MCAGMGIJFIA) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2F32710", Offset = "0x2F31110", VA = "0x182F32710")]
	public static T? FHLCGAFLGHG<T>(this T BJNJBGHPMEH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2F324B0", Offset = "0x2F30EB0", VA = "0x182F324B0")]
	[IteratorStateMachine(typeof(HIENLFEIGLJ<>))]
	public static IEnumerable<T> CJALIEINJCO<T>(this T BJNJBGHPMEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2F322B0", Offset = "0x2F30CB0", VA = "0x182F322B0")]
	public static T[] APAOFMMMLOI<T>(this T BJNJBGHPMEH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FLOCEFCHHHD
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6D15450", Offset = "0x6D13E50", VA = "0x186D15450")]
	private static byte[] OCBOBLMIFNH(int OGMNEECDOAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6D15550", Offset = "0x6D13F50", VA = "0x186D15550")]
	private static byte[] POKGEOKKGAK(long MOOBPOCJAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6D154D0", Offset = "0x6D13ED0", VA = "0x186D154D0")]
	private static byte[] OMNMKFIEACD(ulong MOOBPOCJAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6D14B10", Offset = "0x6D13510", VA = "0x186D14B10")]
	public static Guid BCGCEBLHFNO(params Guid[] LNMBOLKPCAI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6D15380", Offset = "0x6D13D80", VA = "0x186D15380")]
	public static Guid GMDNOGMNFLF([In] Guid DEBKHGODDAC, int HGFDMIDEFHN, int CJEHFDAEGCE = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6D14EA0", Offset = "0x6D138A0", VA = "0x186D14EA0")]
	public static Guid GMDNOGMNFLF([In] Guid DEBKHGODDAC, long HGFDMIDEFHN, int CJEHFDAEGCE = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6D14DD0", Offset = "0x6D137D0", VA = "0x186D14DD0")]
	public static Guid GMDNOGMNFLF([In] Guid DEBKHGODDAC, ulong HGFDMIDEFHN, int CJEHFDAEGCE = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6D14D60", Offset = "0x6D13760", VA = "0x186D14D60")]
	public static Guid GMDNOGMNFLF([In] Guid DEBKHGODDAC, [In] Guid JGEMBFEJJJO, int CJEHFDAEGCE = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6D14F70", Offset = "0x6D13970", VA = "0x186D14F70")]
	private static Guid GMDNOGMNFLF([In] Guid DEBKHGODDAC, byte[] GKELBPEGBOF, int CJEHFDAEGCE = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6D14C80", Offset = "0x6D13680", VA = "0x186D14C80")]
	private static void CAFGBHABHDA(byte[] GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6D14D10", Offset = "0x6D13710", VA = "0x186D14D10")]
	private static void CCIKDNNGCIK(byte[] GDCMEHKEAMI, int NFCDCHABNCB, int BCBMNIEKAKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class DMJMALPJKMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D13F50", Offset = "0x6D12950", VA = "0x186D13F50")]
	public static int MGCPBFPGFKI(this int BJNJBGHPMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6D13E60", Offset = "0x6D12860", VA = "0x186D13E60")]
	public static int DCHEFFGMOAK(this int BJNJBGHPMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6D13FC0", Offset = "0x6D129C0", VA = "0x186D13FC0")]
	public static int NLHKMKDPEHB(this int BJNJBGHPMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D13E30", Offset = "0x6D12830", VA = "0x186D13E30")]
	public static int ALILHONEILP(this int BJNJBGHPMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5D298E0", Offset = "0x5D282E0", VA = "0x185D298E0")]
	public static int DPPFNNEHAEI(this int BJNJBGHPMEH, int FIGHABPEBPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DF93D0", Offset = "0x5DF7DD0", VA = "0x185DF93D0")]
	public static int BBNHFFLJGBK(this int BJNJBGHPMEH, int FIGHABPEBPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6D13EC0", Offset = "0x6D128C0", VA = "0x186D13EC0")]
	public static float GCNEEHPCBCH(this int BJNJBGHPMEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6D13EE0", Offset = "0x6D128E0", VA = "0x186D13EE0")]
	public static (byte, byte, byte, byte) HGBHKFBJPKF(this int BJNJBGHPMEH)
	{
		return default((byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6D13E40", Offset = "0x6D12840", VA = "0x186D13E40")]
	public static int CGMCOJBJMCI([In] this (byte Fourth, byte Third, byte Second, byte First) BJNJBGHPMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6D13EA0", Offset = "0x6D128A0", VA = "0x186D13EA0")]
	public static int EAKDGLAJBIJ(this int BJNJBGHPMEH, int LPJIFNFGHKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6D13EB0", Offset = "0x6D128B0", VA = "0x186D13EB0")]
	public static int FLHPBPCGEPG(this int BJNJBGHPMEH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class CKIMAOHJGLL
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6D13300", Offset = "0x6D11D00", VA = "0x186D13300")]
	public static (byte, byte, byte, byte, byte, byte, byte, byte) HGBHKFBJPKF(this long BJNJBGHPMEH)
	{
		return default((byte, byte, byte, byte, byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6D132B0", Offset = "0x6D11CB0", VA = "0x186D132B0")]
	public static long DDBGPJCPHCP([In] this (byte Eighth, byte Seventh, byte Sixth, byte Fifth, byte Fourth, byte Third, byte Second, byte First) BJNJBGHPMEH)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface AMNDJBAMMGA
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int FBNLOBKJFGM(int JNDEBCKEOBH, int MPLPLEJAHJK);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float EEIPNIFBBJA(float OJOMCIPKCMD, float OICHMIEPDPG);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface ADGJAKKJOPB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	long BHDDPJEPGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class CGDHAKFAKDB
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2B63B70", Offset = "0x2B62570", VA = "0x182B63B70")]
	public static (TKey?, TValue?) DFKJGFPNLFL<TKey, TValue>([In] this KeyValuePair<TKey, TValue> BJNJBGHPMEH)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2B63CD0", Offset = "0x2B626D0", VA = "0x182B63CD0")]
	public static KeyValuePair<TKey?, UValue?> FLDLEBNPNLM<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> BJNJBGHPMEH, UValue KLABJGGMBGH)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class NFPJKJHLKGN
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class GMFCBIBPINF<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GMFCBIBPINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3EE97B0", Offset = "0x3EE81B0", VA = "0x183EE97B0")]
		internal TElement JDDBMCDJNHC(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2EE5A20", Offset = "0x2EE4420", VA = "0x182EE5A20")]
	public static int ADMKPEAKAFD<T>(this IReadOnlyList<T> DKEEEGEFALD, T KLABJGGMBGH) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2EE7B40", Offset = "0x2EE6540", VA = "0x182EE7B40")]
	public static int CKDIDAGFNMF<T>(this IReadOnlyList<T> DKEEEGEFALD, T KLABJGGMBGH) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2EE6920", Offset = "0x2EE5320", VA = "0x182EE6920")]
	public static void ANBIJFEAHKA<T>(this HashSet<T> LECDLAFDCPH, IEnumerable<T> PCIGIFGMPKJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2EED820", Offset = "0x2EEC220", VA = "0x182EED820")]
	public static void OFJFGIEEMJM<T>(this IList<T> OLAPNOFMNPM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2EED8B0", Offset = "0x2EEC2B0", VA = "0x182EED8B0")]
	public static void OFJFGIEEMJM<T>(this IList<T> OLAPNOFMNPM, int FEMCHEMEPHN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2EECA90", Offset = "0x2EEB490", VA = "0x182EECA90")]
	public static void LNEJGAOEEDK<T>(this List<T> OLAPNOFMNPM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2EE7F70", Offset = "0x2EE6970", VA = "0x182EE7F70")]
	public static List<T> DFKLJMEIFJG<T>(this List<T> PBOBDMHLHMC, Predicate<T> GFGLICDGDGO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2EE6070", Offset = "0x2EE4A70", VA = "0x182EE6070")]
	public static int ADMKPEAKAFD<T>(this IReadOnlyList<T> OLAPNOFMNPM, Predicate<T> PLAHCKGGFOL) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2EEB430", Offset = "0x2EE9E30", VA = "0x182EEB430")]
	public static bool JBHINEFHIHE<T>(this IReadOnlyList<T> OLAPNOFMNPM, Predicate<T> PLAHCKGGFOL, [Out][NotNullWhen(true)] List<int>? HCMMOHLNFNH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2EE8C80", Offset = "0x2EE7680", VA = "0x182EE8C80")]
	public static bool FEAHPDAAGAE<T>(this IReadOnlyList<T> OLAPNOFMNPM, T IFNDNLEGMFO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2EE8D00", Offset = "0x2EE7700", VA = "0x182EE8D00")]
	public static bool FEAHPDAAGAE<T>(this IReadOnlyList<T> OLAPNOFMNPM, T IFNDNLEGMFO, EqualityComparer<T> NBGPDLBENLO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2EEBED0", Offset = "0x2EEA8D0", VA = "0x182EEBED0")]
	public static int LGJNDOFDFLM<TElement, TKey>(this IList<TElement> NIDNIMJBLHD, TKey DFJLAHHHIMO, Func<TElement, TKey> JPHMEIMMIHP, [Optional] Func<TKey, TKey, int>? AGCAFECCHLJ, int HGFDMIDEFHN = 0, [Optional] int? FIGHABPEBPG) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2EEBB30", Offset = "0x2EEA530", VA = "0x182EEBB30")]
	public static int LGJNDOFDFLM<TElement, TKey>(Func<int, TElement> PIJOFFMJJJI, int JKNGMJEPPGC, TKey DFJLAHHHIMO, Func<TElement, TKey> JPHMEIMMIHP, [Optional] Func<TKey, TKey, int>? AGCAFECCHLJ, int HGFDMIDEFHN = 0, [Optional] int? FIGHABPEBPG) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2EE79D0", Offset = "0x2EE63D0", VA = "0x182EE79D0")]
	public static bool CBHFIIIMEAF<T>(this List<T> OLAPNOFMNPM, T IFNDNLEGMFO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2EE7650", Offset = "0x2EE6050", VA = "0x182EE7650")]
	public static void CAPPIDPBNND<T>(this List<T> OLAPNOFMNPM, IEnumerable<T> PBOBDMHLHMC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2EED160", Offset = "0x2EEBB60", VA = "0x182EED160")]
	public static void MBEEDABKNGP<T>(this List<T> OLAPNOFMNPM, IEnumerable<T> PBOBDMHLHMC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2EE8420", Offset = "0x2EE6E20", VA = "0x182EE8420")]
	public static T FBHDLJGPLJG<T>(this List<T> PBOBDMHLHMC, Predicate<T> GFGLICDGDGO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2EE7ED0", Offset = "0x2EE68D0", VA = "0x182EE7ED0")]
	public static T DEDHCIFAEMK<T>(this List<T> PBOBDMHLHMC, int HGFDMIDEFHN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0150", Offset = "0x2BCEB50", VA = "0x182BD0150")]
	public static void AAOPJACGKPM<T>(this List<T> OLAPNOFMNPM, int HGFDMIDEFHN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2EED730", Offset = "0x2EEC130", VA = "0x182EED730")]
	public static bool OCGFKPNPJNM<T>(this List<T> KPHELINOJPA, List<T> GOMOGEBCGDG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2EEB8D0", Offset = "0x2EEA2D0", VA = "0x182EEB8D0")]
	public static T JGNJBPBIKDP<T>(this IList<T> OLAPNOFMNPM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2EE8370", Offset = "0x2EE6D70", VA = "0x182EE8370")]
	public static bool DJAFGNIKJIM<T>(IReadOnlyList<T>? OLAPNOFMNPM, int HGFDMIDEFHN, [Out][MaybeNullWhen(false)][CPCEDDOKEKI("This should be `T?` in C# 9.")] T POBDLJBBBCI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2EEA410", Offset = "0x2EE8E10", VA = "0x182EEA410")]
	public static bool HHIPBODADFF<T>(IReadOnlyList<T> OLAPNOFMNPM, ICollection PBOBDMHLHMC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2EED560", Offset = "0x2EEBF60", VA = "0x182EED560")]
	public static void NEJGNPNKEMO<T>(IReadOnlyList<T> OLAPNOFMNPM, ICollection PBOBDMHLHMC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2B97340", Offset = "0x2B95D40", VA = "0x182B97340")]
	public static bool BLEILDLJFCK<T>(this IReadOnlyList<T> OLAPNOFMNPM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2EEB970", Offset = "0x2EEA370", VA = "0x182EEB970")]
	public static string LEBCDCMGHDD<T>(this IEnumerable<T> OLAPNOFMNPM, string DAHJFKGMDFP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2EE67A0", Offset = "0x2EE51A0", VA = "0x182EE67A0")]
	public static T AIHPANHNNLP<T>(this IList<T> BJNJBGHPMEH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2EED080", Offset = "0x2EEBA80", VA = "0x182EED080")]
	public static T LNJKLIGNFIE<T>(this IList<T> BJNJBGHPMEH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2EECA00", Offset = "0x2EEB400", VA = "0x182EECA00")]
	public static void LINBHBPLMND<T>(this IList<T> BJNJBGHPMEH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2EE7D30", Offset = "0x2EE6730", VA = "0x182EE7D30")]
	public static void DECKGGGPHHE<T>(this IList<T> BJNJBGHPMEH, [In] T KLABJGGMBGH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2EEDFE0", Offset = "0x2EEC9E0", VA = "0x182EEDFE0")]
	public static T PCNLHCIDHNJ<T>(this IList<T> BJNJBGHPMEH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2EE80F0", Offset = "0x2EE6AF0", VA = "0x182EE80F0")]
	public static void DIGHJJBPICO<T>(this List<T> BJNJBGHPMEH) where T : struct, IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DPINKECMFCK
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static float OEBCEIEJPIA;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static float DPALLBPLHEK;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static bool FBFJIHEFJLC;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly float HKDDMLIFJKE;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6D14580", Offset = "0x6D12F80", VA = "0x186D14580")]
	public static bool OCKNIKDDDNI(float MOKDKAEJAPP, float MKGNFMMEFHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D14490", Offset = "0x6D12E90", VA = "0x186D14490")]
	public static float KIHDCGGLOBN(float KLABJGGMBGH, float GDAPDOPOOAD, float EMFANHEMBJM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6D14470", Offset = "0x6D12E70", VA = "0x186D14470")]
	public static int KIHDCGGLOBN(int KLABJGGMBGH, int GDAPDOPOOAD, int EMFANHEMBJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6D14040", Offset = "0x6D12A40", VA = "0x186D14040")]
	public static float CBFHCKPNFHE(float KLABJGGMBGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6D14060", Offset = "0x6D12A60", VA = "0x186D14060")]
	public static float DCCAAHAEOCC(float MOKDKAEJAPP, float MKGNFMMEFHC, float KGPMLIHPPAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6D14010", Offset = "0x6D12A10", VA = "0x186D14010")]
	public static float APIEIOFCJHA(float MOKDKAEJAPP, float MKGNFMMEFHC, float KGPMLIHPPAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6D142C0", Offset = "0x6D12CC0", VA = "0x186D142C0")]
	public static float FHMCPIGFMFH(float MOKDKAEJAPP, float MKGNFMMEFHC, float KLABJGGMBGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6D144B0", Offset = "0x6D12EB0", VA = "0x186D144B0")]
	public static float LCIHPFEOFDI(float MOKDKAEJAPP, float MKGNFMMEFHC, float KLABJGGMBGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6D14020", Offset = "0x6D12A20", VA = "0x186D14020")]
	public static float BPBADMEJAOI(float MOKDKAEJAPP, float MKGNFMMEFHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6D14100", Offset = "0x6D12B00", VA = "0x186D14100")]
	public static float EFHJODCBKOH(float FCOMLCEDOAO, float LLMCGMPLMBL, float CCMPEADKJKM, float AFJAGGMCDEN, float LGCLKPGINJF, float BKOJCILPMLI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6D144F0", Offset = "0x6D12EF0", VA = "0x186D144F0")]
	public static float LDKBNJKEFDG(float KLABJGGMBGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6D14380", Offset = "0x6D12D80", VA = "0x186D14380")]
	public static float HLALPPBCJMJ(float KLABJGGMBGH, float GDAPDOPOOAD, float EMFANHEMBJM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6D14670", Offset = "0x6D13070", VA = "0x186D14670")]
	public static float OPMDECHPONK(float FIHGCENPEBG)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class EBNBPDJNCHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private System.Random CIODFKMIPDM;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6D14840", Offset = "0x6D13240", VA = "0x186D14840")]
	public EBNBPDJNCHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6D148D0", Offset = "0x6D132D0", VA = "0x186D148D0")]
	public EBNBPDJNCHE(int FEMCHEMEPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x648FEC0", Offset = "0x648E8C0", VA = "0x18648FEC0", Slot = "4")]
	public virtual int FBNLOBKJFGM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6D147B0", Offset = "0x6D131B0", VA = "0x186D147B0", Slot = "5")]
	public virtual int FBNLOBKJFGM(int MPLPLEJAHJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6D147E0", Offset = "0x6D131E0", VA = "0x186D147E0", Slot = "6")]
	public virtual int FBNLOBKJFGM(int JNDEBCKEOBH, int MPLPLEJAHJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6D14810", Offset = "0x6D13210", VA = "0x186D14810")]
	public double OPMPCKHAOKP()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class BODAICNOHHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2ADADE0", Offset = "0x2AD97E0", VA = "0x182ADADE0")]
	[EMDAHHLEKNJ("This should be replaced with the `is not` operator in C# 9.")]
	public static bool NCNNPLAEFHL<T>(this object BJNJBGHPMEH, [Out][NotNullWhen(true)] T POBDLJBBBCI) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class GPHIHEONNKH
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6D16470", Offset = "0x6D14E70", VA = "0x186D16470")]
	public static (float3, float3, float3) PLHFPHNMLDP([In] this quaternion BJNJBGHPMEH)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6D15A50", Offset = "0x6D14450", VA = "0x186D15A50")]
	private static float3 OKBBFNGLLHP(quaternion BEFBNHMKOGD, math.RotationOrder NOIFCGELKHC = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6D15980", Offset = "0x6D14380", VA = "0x186D15980")]
	private static float3 JNIHAIBIPBG(float3 APGPPOJHJOP, math.RotationOrder NOIFCGELKHC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6D158C0", Offset = "0x6D142C0", VA = "0x186D158C0")]
	public static float3 GHFKACEFKBN(this quaternion BEFBNHMKOGD, math.RotationOrder NOIFCGELKHC = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6D156E0", Offset = "0x6D140E0", VA = "0x186D156E0")]
	public static float CEPOBKMNJJK(this quaternion JDKMLCHPKLA, quaternion AENKMLMFBAD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6D15830", Offset = "0x6D14230", VA = "0x186D15830")]
	[CompilerGenerated]
	internal static float3 EBNNEBAOPHI(float3 APGPPOJHJOP)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class JMMPMHCCFKK
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class HLEBFNKICOM : AMNDJBAMMGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly System.Random NGAKBNAJMAK;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6D147E0", Offset = "0x6D131E0", VA = "0x186D147E0", Slot = "4")]
		public int FBNLOBKJFGM(int OJOMCIPKCMD, int KLLHKAEACHP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6D165A0", Offset = "0x6D14FA0", VA = "0x186D165A0", Slot = "5")]
		public float EEIPNIFBBJA(float OJOMCIPKCMD, float OICHMIEPDPG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6D16560", Offset = "0x6D14F60", VA = "0x186D16560")]
		private double CFCONKICANM()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6D16610", Offset = "0x6D15010", VA = "0x186D16610")]
		public HLEBFNKICOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly AMNDJBAMMGA GMGLDOFMCCI;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6D168C0", Offset = "0x6D152C0", VA = "0x186D168C0")]
	public static ulong OGLOOOCOGJG()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class DGCFIILBCEH
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2BB14D0", Offset = "0x2BAFED0", VA = "0x182BB14D0")]
	public static bool GEHDGCICNPH<T>(this IReadOnlyCollection<T> BJNJBGHPMEH, int HGFDMIDEFHN) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class NLJIDINADFI
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC060", Offset = "0x2EFAA60", VA = "0x182EFC060")]
	public static bool KKBILJAAMLP<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> BJNJBGHPMEH, IReadOnlyDictionary<TKey, TValue> PLNBHPCFEOK) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class KEBPNFPMFJN
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2E44FF0", Offset = "0x2E439F0", VA = "0x182E44FF0")]
	public static TValue? LFEMPPENDHF<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> BJNJBGHPMEH, TKey LFOBGDLOPID) where TValue : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class NMGIKGPFPPM
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6D17900", Offset = "0x6D16300", VA = "0x186D17900")]
	public static void FJEDBGMGJGG(this IReadOnlyList<Action> BJNJBGHPMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC610", Offset = "0x2EFB010", VA = "0x182EFC610")]
	public static bool LAFFHOKCOBI<T>(this IReadOnlyList<T> BJNJBGHPMEH, int HGFDMIDEFHN, [Out][NotNullWhen(true)][CPCEDDOKEKI("This should be `T?` in C# 9.")] T POBDLJBBBCI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC530", Offset = "0x2EFAF30", VA = "0x182EFC530")]
	public static bool DONKPKIJEAM<T>(this IReadOnlyList<T> BJNJBGHPMEH, int HGFDMIDEFHN, [Out] MGBLPJABDKK<T> POBDLJBBBCI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC820", Offset = "0x2EFB220", VA = "0x182EFC820")]
	public static T NOHJFANHDBH<T>(this IReadOnlyList<T> BJNJBGHPMEH, int HGFDMIDEFHN, [In] T JLEELMKDAAP) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2AD1DC0", Offset = "0x2AD07C0", VA = "0x182AD1DC0")]
	[CPCEDDOKEKI("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T GDJGIKCPGKE<T>(this IReadOnlyList<T> BJNJBGHPMEH, int HGFDMIDEFHN) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC760", Offset = "0x2EFB160", VA = "0x182EFC760")]
	public static T? LFEMPPENDHF<T>(this IReadOnlyList<T> BJNJBGHPMEH, int HGFDMIDEFHN) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MIAJADCDGMI
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2E80220", Offset = "0x2E7EC20", VA = "0x182E80220")]
	public static int OHCPFAOHMPG<T>([In] this ReadOnlySequence<T> CPICPHKKOGA, [In] T KLABJGGMBGH) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2E7FE00", Offset = "0x2E7E800", VA = "0x182E7FE00")]
	public static bool LKOOBPLAALM<T>([In] this ReadOnlySequence<T> CPICPHKKOGA, [In] ReadOnlySpan<T> PLNBHPCFEOK) where T : IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class NBOIIEJHDHD
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2EE11B0", Offset = "0x2EDFBB0", VA = "0x182EE11B0")]
	public static string ONHANCKIDDN<T>([In] this ReadOnlySpan<T> BJNJBGHPMEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2EE0900", Offset = "0x2EDF300", VA = "0x182EE0900")]
	public static string GCKKLFDHIEI<T>([In] this ReadOnlySpan<T> BJNJBGHPMEH, string JNMPGCIKCCL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class FLICAGPLDAN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static ADGJAKKJOPB OJPEBHCGJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6D149E0", Offset = "0x6D133E0", VA = "0x186D149E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6D14950", Offset = "0x6D13350", VA = "0x186D14950")]
	public static double BFBNIIPDPNH(this ADGJAKKJOPB BJNJBGHPMEH, long GMJHNNJMKOD)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class MNMALLBMPNH : ADGJAKKJOPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Stopwatch KNLCAFPNCPI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long BHDDPJEPGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6D177C0", Offset = "0x6D161C0", VA = "0x186D177C0", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	private MNMALLBMPNH(Stopwatch GNMHDDIJNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6D17890", Offset = "0x6D16290", VA = "0x186D17890")]
	public static MNMALLBMPNH JPCPCEFBFML(Stopwatch GNMHDDIJNJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6D177E0", Offset = "0x6D161E0", VA = "0x186D177E0")]
	public static MNMALLBMPNH FLBFBDEGMJA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class KCLPHHEDGPK
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6D16BF0", Offset = "0x6D155F0", VA = "0x186D16BF0")]
	public static float3 GPJAOPKEIBP([In] this RigidTransform BJNJBGHPMEH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6D16D20", Offset = "0x6D15720", VA = "0x186D16D20")]
	public static float3 KAMMDKBCNPC([In] this RigidTransform BJNJBGHPMEH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xBA73F0", Offset = "0xBA5DF0", VA = "0x180BA73F0")]
	public static (float3, float3, float3) BFJIHEAEANC([In] this RigidTransform BJNJBGHPMEH)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6D16E50", Offset = "0x6D15850", VA = "0x186D16E50")]
	public static RigidTransform PCEKCHIDGIF([In] this RigidTransform BJNJBGHPMEH)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class BAMDJMMLCFG
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6D12EC0", Offset = "0x6D118C0", VA = "0x186D12EC0")]
	public static RigidTransform BFHICIPADPF(RigidTransform IMPJCLHCPMG, RigidTransform ANOMEOLFMEG)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class LKAGKPLIJLI
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6D16EB0", Offset = "0x6D158B0", VA = "0x186D16EB0")]
	public static float AMMMIIIHLFO([In] this (byte Fourth, byte Third, byte Second, byte First) BJNJBGHPMEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6D16F60", Offset = "0x6D15960", VA = "0x186D16F60")]
	public static int PNMLEJFKLMP(this float BJNJBGHPMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6D16EF0", Offset = "0x6D158F0", VA = "0x186D16EF0")]
	public static (byte, byte, byte, byte) HGBHKFBJPKF(this float BJNJBGHPMEH)
	{
		return default((byte, byte, byte, byte));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class HKAFGIIFEDD
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2DD99A0", Offset = "0x2DD83A0", VA = "0x182DD99A0")]
	public static ReadOnlySpan<T?> JKEOPFKCCGC<T>([In] this Span<T> BJNJBGHPMEH)
	{
		return default(ReadOnlySpan<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class BEDONONCDGO
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6D12F80", Offset = "0x6D11980", VA = "0x186D12F80")]
	public static StringBuilder KGFGDPDPFGM(this StringBuilder BJNJBGHPMEH, int MLBMJGHHLDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6D12FE0", Offset = "0x6D119E0", VA = "0x186D12FE0")]
	public static StringBuilder OMHPLNEIDJC(this StringBuilder BJNJBGHPMEH, int MLBMJGHHLDO, string KLNAGGGGPDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6D13050", Offset = "0x6D11A50", VA = "0x186D13050")]
	public static StringBuilder PGKIFKNDPGM(this StringBuilder BJNJBGHPMEH, char OMCPAMCENGF, int JACBMCDJDIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class DKIEOLIJCHK
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static Regex JBANPCIGHKI;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static Regex OKAKAECIHMI;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly char[] HJEEPBGCFFB;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x60BE9D0", Offset = "0x60BD3D0", VA = "0x1860BE9D0")]
	public static bool BLEILDLJFCK(this string? NFDBNIDBLCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6D13BF0", Offset = "0x6D125F0", VA = "0x186D13BF0")]
	public static string? PAEICHODKAL(this string? BJNJBGHPMEH, int DOBHOIOIHAC, string DFOHDCALBCD = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6D138D0", Offset = "0x6D122D0", VA = "0x186D138D0")]
	public static string JBHJOOGAJDK(this string BJNJBGHPMEH, int DOBHOIOIHAC, string DFOHDCALBCD = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6D13A50", Offset = "0x6D12450", VA = "0x186D13A50")]
	public static int LKCOIAIPJMK(this string NFDBNIDBLCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6D13AC0", Offset = "0x6D124C0", VA = "0x186D13AC0")]
	public static string MHHCGPKHNOK(this string NFDBNIDBLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6D13970", Offset = "0x6D12370", VA = "0x186D13970")]
	public static string[] KMNDIALNMLD(this string NFDBNIDBLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6D13B70", Offset = "0x6D12570", VA = "0x186D13B70")]
	public static string OJHJIGGNDEP(this string NFDBNIDBLCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class LPMONKJEJAP<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public readonly struct BDDMAEDBDJL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x51172E0", Offset = "0x5115CE0", VA = "0x1851172E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int MMIHBLINOOO;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static JBGCBMFDKPN OPFAFBACOMB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static long BHDDPJEPGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4550D10", Offset = "0x454F710", VA = "0x184550D10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4550B10", Offset = "0x454F510", VA = "0x184550B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x4550B60", Offset = "0x454F560", VA = "0x184550B60")]
	public static BDDMAEDBDJL CCMPMMECDOA()
	{
		return default(BDDMAEDBDJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x4550DE0", Offset = "0x454F7E0", VA = "0x184550DE0")]
	private static void NGCJPMMEDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x4550D60", Offset = "0x454F760", VA = "0x184550D60")]
	public static void LFBMALNLGLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct JBGCBMFDKPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly ADGJAKKJOPB KNLCAFPNCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly long FJGEOMENGIB;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6D16850", Offset = "0x6D15250", VA = "0x186D16850")]
	public JBGCBMFDKPN(ADGJAKKJOPB GNMHDDIJNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6D167C0", Offset = "0x6D151C0", VA = "0x186D167C0")]
	public long OFEGCKLLLHH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6D166A0", Offset = "0x6D150A0", VA = "0x186D166A0")]
	public double BFBNIIPDPNH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6D16730", Offset = "0x6D15130", VA = "0x186D16730")]
	public double FMPINEJDHCL()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class LOLBNMAJMMB
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6D16F70", Offset = "0x6D15970", VA = "0x186D16F70")]
	public static bool JKKMLBDKEIL(this Type BJNJBGHPMEH, Type PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2E5DF60", Offset = "0x2E5C960", VA = "0x182E5DF60")]
	public static bool JKKMLBDKEIL<T>(this Type BJNJBGHPMEH) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class IBIEALBEAIF
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5D298E0", Offset = "0x5D282E0", VA = "0x185D298E0")]
	public static uint DPPFNNEHAEI(this uint BJNJBGHPMEH, int FIGHABPEBPG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5DF93D0", Offset = "0x5DF7DD0", VA = "0x185DF93D0")]
	public static uint BBNHFFLJGBK(this uint BJNJBGHPMEH, int FIGHABPEBPG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6D16690", Offset = "0x6D15090", VA = "0x186D16690")]
	public static uint FLLAAGJCDIE(this uint BJNJBGHPMEH, uint ADGDKMKAJHJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x1290690", Offset = "0x128F090", VA = "0x181290690")]
	public static int PNMLEJFKLMP(this uint BJNJBGHPMEH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class CMGAOAEOENC
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2B77A90", Offset = "0x2B76490", VA = "0x182B77A90")]
	public static bool EIDCGGELKCN<T>([In] this T? BJNJBGHPMEH, [Out] T KLABJGGMBGH) where T : struct
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
