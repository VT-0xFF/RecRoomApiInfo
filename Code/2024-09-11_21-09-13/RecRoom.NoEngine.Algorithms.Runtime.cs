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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6C308E0", Offset = "0x6C2EEE0", VA = "0x186C308E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AE0", Offset = "0x8AF0E0", VA = "0x1808B0AE0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8B0B20", Offset = "0x8AF120", VA = "0x1808B0B20")]
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
	[Cpp2IlInjected.Address(RVA = "0x6C2FCF0", Offset = "0x6C2E2F0", VA = "0x186C2FCF0")]
	public static bool GCPNLJFJNPG(string AAIAGHBAMFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C2FF10", Offset = "0x6C2E510", VA = "0x186C2FF10")]
	private static bool NIKECKFPCAH(string KFAOBDLOMDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C2FDC0", Offset = "0x6C2E3C0", VA = "0x186C2FDC0")]
	public static bool NIKECKFPCAH(Exception LAHIFJKDMEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C2FFE0", Offset = "0x6C2E5E0", VA = "0x186C2FFE0")]
	public static string PPLCHEHCGLN(string KLNAGGGGPDK, string BPFGNDAPKAJ = "", bool GCEGJLCJDCG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BGOMBODFJLG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BEA0", Offset = "0x6C2A4A0", VA = "0x186C2BEA0")]
	public static string CGNCGDOBEGN(this Guid GDCMEHKEAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BE00", Offset = "0x6C2A400", VA = "0x186C2BE00")]
	public static string CGNCGDOBEGN(this byte[] CNGBPDKMHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BF40", Offset = "0x6C2A540", VA = "0x186C2BF40")]
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
			[Cpp2IlInjected.Address(RVA = "0x3FDBBC0", Offset = "0x3FDA1C0", VA = "0x183FDBBC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x490B650", Offset = "0x4909C50", VA = "0x18490B650")]
		public PCCOAIIGDIN(T[] CIBEDEFIAEJ, PJHOEEKJFJP<T> AGCAFECCHLJ, int NDKMCJNPCOG, Func<bool> GIICGFJHCOJ, T[]? IMNGIOGMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x490B320", Offset = "0x4909920", VA = "0x18490B320")]
		public bool CIFKNMOBGHA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate U IILLNAJNGIB<T, U>(int JDIKCPODCIN, int FCEJPNLOAIJ, [In] ReadOnlySpan<T> LFDGBCGGLCM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4530", Offset = "0x2AF2B30", VA = "0x182AF4530")]
	public static T[] OCKLJLDOPCL<T>(int BHEAFIOEIAD, T LFMHIDKAJGK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3A30", Offset = "0x2AF2030", VA = "0x182AF3A30")]
	public static void KHEMCCHICCN<T>(this T[] KFMNKHBNPKA, T LFMHIDKAJGK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2C80", Offset = "0x2AF1280", VA = "0x182AF2C80")]
	public static void DCFGHBNCOAN<T>(this T[] DKEEEGEFALD, int DMIMFDDIIBO, int DBINMLKKFGD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3D50", Offset = "0x2AF2350", VA = "0x182AF3D50")]
	private static void MDALGGKKPMB<T>(this T[] BJNJBGHPMEH, int EBJPCNAAAAE, int EHCPCHLNKIM, T[] PLNBHPCFEOK, int DJFLBINNMAF, int IOICNKKFGNI, T[] POBDLJBBBCI, int NIEABNICJEK, PJHOEEKJFJP<T> AGCAFECCHLJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4120", Offset = "0x2AF2720", VA = "0x182AF4120")]
	public static void NBODPLMGHOO<T>(this T[] BJNJBGHPMEH, int NBPJLJIBBHP, int FIGHABPEBPG, PJHOEEKJFJP<T> AGCAFECCHLJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2DB0", Offset = "0x2AF13B0", VA = "0x182AF2DB0")]
	public static PCCOAIIGDIN<T> EJHJPEOMPHK<T>(this T[] BJNJBGHPMEH, PJHOEEKJFJP<T> AGCAFECCHLJ, int NDKMCJNPCOG, Func<bool> GIICGFJHCOJ, [Optional] T[]? IMNGIOGMMOG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2E70", Offset = "0x2AF1470", VA = "0x182AF2E70")]
	public static T[] FAFLFGECIEO<T>(this T[] DKEEEGEFALD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3C00", Offset = "0x2AF2200", VA = "0x182AF3C00")]
	public static T[] LPFJGDGEMHJ<T>(this T[] MMILIPAEHND, T KPBHJNBJCGO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2EC0", Offset = "0x2AF14C0", VA = "0x182AF2EC0")]
	public static T[] FDEPCHNGLII<T>(this T[] MMILIPAEHND, int HGFDMIDEFHN, T KPBHJNBJCGO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2D00", Offset = "0x2AF1300", VA = "0x182AF2D00")]
	public static T[] EHGNEHBNIFM<T>(this T[] MMILIPAEHND, int HGFDMIDEFHN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3790", Offset = "0x2AF1D90", VA = "0x182AF3790")]
	public static T[] FKGOIKCOLPO<T>(this T[] MMILIPAEHND, int HGFDMIDEFHN, T KPBHJNBJCGO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2AF46D0", Offset = "0x2AF2CD0", VA = "0x182AF46D0")]
	public static U[] OPKIHEMBNHO<U, T>(this T[] KCIKOPILENN, int NHHHGBKMLJI, IILLNAJNGIB<T, U> GPPMNPPNIBB) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C390", Offset = "0x6C2A990", VA = "0x186C2C390")]
	public static byte[] PFIAIPJLKPA(this byte[] BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C110", Offset = "0x6C2A710", VA = "0x186C2C110")]
	public static byte[] KNKFOMFLGND(this byte[] BJNJBGHPMEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MPKBLFHGBEA
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BC00", Offset = "0x6C2A200", VA = "0x186C2BC00")]
	public static byte BFHFDPBBMLN(this bool BJNJBGHPMEH)
	{
		return default(byte);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class ADNKOJAMGHI
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BC00", Offset = "0x6C2A200", VA = "0x186C2BC00")]
	public static bool PPNJKPJLNEK(this byte BJNJBGHPMEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class ENKPDEHOFOL
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2B37AC0", Offset = "0x2B360C0", VA = "0x182B37AC0")]
	public static void ANBIJFEAHKA<T>(this ICollection<T> BJNJBGHPMEH, IEnumerable<T> PCIGIFGMPKJ) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ECKHNJIJCOD
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2B324E0", Offset = "0x2B30AE0", VA = "0x182B324E0")]
	public static void ONFBMMCFBPL<K, V>(this IDictionary<K, V> BJNJBGHPMEH, [In] K LFOBGDLOPID, [In] V KLABJGGMBGH, Func<V, V, V> DJEDMGMACCM) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2B31470", Offset = "0x2B2FA70", VA = "0x182B31470")]
	public static void KBDEOAKIEFM<K, V>(this IDictionary<K, List<V>> BJNJBGHPMEH, [In] K LFOBGDLOPID, [In] V KLABJGGMBGH) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2B30670", Offset = "0x2B2EC70", VA = "0x182B30670")]
	public static TVal EADCAPENOHN<TVal, TKey>(this IDictionary<TKey, TVal> HGEMHLLLPMH, [In] TKey LFOBGDLOPID, [Optional][CPCEDDOKEKI("`default!` shouldn't be necessary in C# 9")] TVal MCAGMGIJFIA) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2B304B0", Offset = "0x2B2EAB0", VA = "0x182B304B0")]
	public static TVal EADCAPENOHN<TVal, TKey>(this IDictionary<TKey, TVal> HGEMHLLLPMH, [In] TKey LFOBGDLOPID, Func<TVal> LMGHMFACOIC) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2B31AA0", Offset = "0x2B300A0", VA = "0x182B31AA0")]
	public static TValue OIDAGPMOLPM<TValue, TKey>(this IDictionary<TKey, TValue> HGEMHLLLPMH, [In] TKey LFOBGDLOPID, [Optional][In][CPCEDDOKEKI("`default!` and null-oblivious region shouldn't be necessary in C# 9")] TValue MCAGMGIJFIA)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2B30070", Offset = "0x2B2E670", VA = "0x182B30070")]
	public static V CLGHOOKOFAC<V, K>(this IDictionary<K, V> BJNJBGHPMEH, [In] K LFOBGDLOPID) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2B303F0", Offset = "0x2B2E9F0", VA = "0x182B303F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x42514A0", Offset = "0x424FAA0", VA = "0x1842514A0")]
		[CPCEDDOKEKI("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) HHIHNNMOFAL(T LANBDILPIDD)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4251440", Offset = "0x424FA40", VA = "0x184251440")]
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
			[Cpp2IlInjected.Address(RVA = "0x9023F0", Offset = "0x9009F0", VA = "0x1809023F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D35120", Offset = "0x3D33720", VA = "0x183D35120", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xC1B510", Offset = "0xC19B10", VA = "0x180C1B510")]
		[DebuggerHidden]
		public FLIBOHCEOCO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3B9B4A0", Offset = "0x3B99AA0", VA = "0x183B9B4A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3D34AB0", Offset = "0x3D330B0", VA = "0x183D34AB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3D346A0", Offset = "0x3D32CA0", VA = "0x183D346A0")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3D350D0", Offset = "0x3D336D0", VA = "0x183D350D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3D34E80", Offset = "0x3D33480", VA = "0x183D34E80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3D35040", Offset = "0x3D33640", VA = "0x183D35040", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x965BF0", Offset = "0x9641F0", VA = "0x180965BF0")]
		[DebuggerHidden]
		public PHCNJNDAIFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4918F10", Offset = "0x4917510", VA = "0x184918F10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4918660", Offset = "0x4916C60", VA = "0x184918660", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4918610", Offset = "0x4916C10", VA = "0x184918610")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4918570", Offset = "0x4916B70", VA = "0x184918570")]
		private void IOFDBJCEJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4918EC0", Offset = "0x49174C0", VA = "0x184918EC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4918D80", Offset = "0x4917380", VA = "0x184918D80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3BA38A0", Offset = "0x3BA1EA0", VA = "0x183BA38A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x39E7800", Offset = "0x39E5E00", VA = "0x1839E7800", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x463B470", Offset = "0x4639A70", VA = "0x18463B470", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1F8C250", Offset = "0x1F8A850", VA = "0x181F8C250")]
		[DebuggerHidden]
		public MAINBBBNHBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3BA1C60", Offset = "0x3BA0260", VA = "0x183BA1C60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4639B80", Offset = "0x4638180", VA = "0x184639B80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4639AE0", Offset = "0x46380E0", VA = "0x184639AE0")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x463B380", Offset = "0x4639980", VA = "0x18463B380", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x463B090", Offset = "0x4639690", VA = "0x18463B090", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, OLCEOJBLPLC<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3BA38A0", Offset = "0x3BA1EA0", VA = "0x183BA38A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x965BF0", Offset = "0x9641F0", VA = "0x180965BF0")]
		[DebuggerHidden]
		public ANNBFHEPNDE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3F22270", Offset = "0x3F20870", VA = "0x183F22270", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3F21D90", Offset = "0x3F20390", VA = "0x183F21D90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3F21D40", Offset = "0x3F20340", VA = "0x183F21D40")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3F21CF0", Offset = "0x3F202F0", VA = "0x183F21CF0")]
		private void IOFDBJCEJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3F22220", Offset = "0x3F20820", VA = "0x183F22220", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3D787D0", Offset = "0x3D76DD0", VA = "0x183D787D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3D78ED0", Offset = "0x3D774D0", VA = "0x183D78ED0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public KNKGEMAIAMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3E6B450", Offset = "0x3E69A50", VA = "0x183E6B450")]
		internal bool IPGOMNEIOJI(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x436F030", Offset = "0x436D630", VA = "0x18436F030")]
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
			[Cpp2IlInjected.Address(RVA = "0xDCF430", Offset = "0xDCDA30", VA = "0x180DCF430", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D733A0", Offset = "0x3D719A0", VA = "0x183D733A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1F8C250", Offset = "0x1F8A850", VA = "0x181F8C250")]
		[DebuggerHidden]
		public AAJNMBAAPFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3D85630", Offset = "0x3D83C30", VA = "0x183D85630", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3D85940", Offset = "0x3D83F40", VA = "0x183D85940", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3D85860", Offset = "0x3D83E60", VA = "0x183D85860", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3BA38A0", Offset = "0x3BA1EA0", VA = "0x183BA38A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8C20", Offset = "0x2CC7220", VA = "0x182CC8C20")]
	public static bool OILBGKDDBDF<T, TArgs>(this IEnumerable<T> BJNJBGHPMEH, [In] TArgs AAAOIGBEBAB, AMMIHLKOBEN<TArgs, T> PLAHCKGGFOL) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2E320", Offset = "0x6C2C920", VA = "0x186C2E320")]
	public static bool OILBGKDDBDF(this IEnumerable<bool> BJNJBGHPMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2CC44B0", Offset = "0x2CC2AB0", VA = "0x182CC44B0")]
	public static U EKLKJDKFEPE<U, T>(this IEnumerable<T> BJNJBGHPMEH, Func<U> LOEGIAFJKCN, Func<T, U> LANBDILPIDD, Func<IEnumerable<T>, U> BHCMIJNOGMB) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2CC4720", Offset = "0x2CC2D20", VA = "0x182CC4720")]
	public static bool FBABIEKDOPN<T, TArgs>(this IEnumerable<T> BJNJBGHPMEH, [In] TArgs AAAOIGBEBAB, AMMIHLKOBEN<TArgs, T> PLAHCKGGFOL) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5BC0", Offset = "0x2CC41C0", VA = "0x182CC5BC0")]
	public static U HJFJGBFGONN<U, T, TArg>(this IEnumerable<T> BJNJBGHPMEH, [In] TArg IOBLLEKOCNN, DPCAEOKNMAE<TArg, U> LOEGIAFJKCN, AGMCMDENKKG<TArg, T, U> LANBDILPIDD, MAJAMCEBCFF<TArg, T, U> BHCMIJNOGMB) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2CC6E10", Offset = "0x2CC5410", VA = "0x182CC6E10")]
	public static IEnumerable<U> MNMKBNFICID<U, T, TArg>(this IEnumerable<T> BJNJBGHPMEH, [In] TArg IOBLLEKOCNN, MKFKJIDKDKA<TArg, T, U> LAAOPFHDHBG) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2C985D0", Offset = "0x2C96BD0", VA = "0x182C985D0")]
	public static IEnumerable<T> LBNFELHBJCG<T>(params IEnumerable<T>[] KPAKBAPPHNJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2CC4C60", Offset = "0x2CC3260", VA = "0x182CC4C60")]
	public static bool FGPNDJNHIBG<T>(this IEnumerable<T> MKLJJBDOOGE, IEnumerable<T> PLNBHPCFEOK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2C985D0", Offset = "0x2C96BD0", VA = "0x182C985D0")]
	public static IEnumerable<(TKey?, TValue?)>? EONCCAMPOGK<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2CC90A0", Offset = "0x2CC76A0", VA = "0x182CC90A0")]
	public static IEnumerable<T> OILLLCLKIIJ<T, TKey>(this IEnumerable<T> KKBAGKHGAHE, Func<T, TKey> CJDAOHPMJPD) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D850", Offset = "0x2C0BE50", VA = "0x182C0D850")]
	[IteratorStateMachine(typeof(FLIBOHCEOCO<>))]
	public static IEnumerable<T> COGGGDCIEIP<T>(this IEnumerable<T> MKLJJBDOOGE, ISet<T> KFCFIIDHDBJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2C544A0", Offset = "0x2C52AA0", VA = "0x182C544A0")]
	[IteratorStateMachine(typeof(PHCNJNDAIFN<, >))]
	public static IEnumerable<T> CICBAMBOLBH<T, U>(this IEnumerable<T> BJNJBGHPMEH, IEnumerable<U> PLNBHPCFEOK, [Optional][CPCEDDOKEKI("`default!` shouldn't be necessary in C# 9")] T LFMHIDKAJGK) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x29A8150", Offset = "0x29A6750", VA = "0x1829A8150")]
	public static T GCHKPJLDGFJ<T>(this IEnumerable<T> MKLJJBDOOGE, T MCAGMGIJFIA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2CC4E90", Offset = "0x2CC3490", VA = "0x182CC4E90")]
	public static T GCHKPJLDGFJ<T>(this IEnumerable<T> MKLJJBDOOGE, T MCAGMGIJFIA, Func<T, bool> PLAHCKGGFOL) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2CC6520", Offset = "0x2CC4B20", VA = "0x182CC6520")]
	public static T? IOJNMKPMFMI<T>(this IEnumerable<T> BJNJBGHPMEH, Func<T, bool> PLAHCKGGFOL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2CC7770", Offset = "0x2CC5D70", VA = "0x182CC7770")]
	public static void NBIFNCPJJJO<T>(this IEnumerable<T> BJNJBGHPMEH, Action<T> DLMFPIAEPPD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2BAFDF0", Offset = "0x2BAE3F0", VA = "0x182BAFDF0")]
	[IteratorStateMachine(typeof(MAINBBBNHBI<>))]
	public static IEnumerable<(T, OLCEOJBLPLC<T>)> HGCGHIECOBD<T>(this IEnumerable<T> BJNJBGHPMEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2CC99F0", Offset = "0x2CC7FF0", VA = "0x182CC99F0")]
	public static bool PNLEICMPCHJ<T>(this IEnumerable<T> BJNJBGHPMEH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2C985D0", Offset = "0x2C96BD0", VA = "0x182C985D0")]
	public static IEnumerable<MGBLPJABDKK<T>> OAGDGHBELJN<T>(this IEnumerable<T> BJNJBGHPMEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2CC4E50", Offset = "0x2CC3450", VA = "0x182CC4E50")]
	public static bool FKPHAIMPOJM<T>(this IEnumerable<T> BJNJBGHPMEH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2CC3820", Offset = "0x2CC1E20", VA = "0x182CC3820")]
	public static IEnumerable<T> DODGOJNICKA<T>(this IEnumerable<T>? BJNJBGHPMEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2BAFA80", Offset = "0x2BAE080", VA = "0x182BAFA80")]
	[IteratorStateMachine(typeof(ANNBFHEPNDE<, >))]
	public static IEnumerable<U> GEACPOIEIAP<U, T>(this IEnumerable<T> BJNJBGHPMEH, Func<JMBKIEHCGGB<U>, T, (bool Zero, U One, IEnumerable<U> Many)> CAMENKDOGHH) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2C985D0", Offset = "0x2C96BD0", VA = "0x182C985D0")]
	public static IEnumerable<T> NFAJDICKHLI<T>(this IEnumerable<IEnumerable<T>> BJNJBGHPMEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2CC60C0", Offset = "0x2CC46C0", VA = "0x182CC60C0")]
	public static int IEKLKHKLIJK<T>(this IEnumerable<T> BJNJBGHPMEH, int GAKIGLKAHAI = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2CC35B0", Offset = "0x2CC1BB0", VA = "0x182CC35B0")]
	public static bool CLICLAABKKF<T>(this IEnumerable<T> BJNJBGHPMEH, IEnumerable<T> PLNBHPCFEOK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2CC6D90", Offset = "0x2CC5390", VA = "0x182CC6D90")]
	public static IEnumerable<T> KCOHJMPCDPI<T>(this IEnumerable<T> BJNJBGHPMEH, int LGMHLJPBKOE, int BCNKPEKIKLB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2CC30D0", Offset = "0x2CC16D0", VA = "0x182CC30D0")]
	public static (IEnumerable<T>, IEnumerable<T>) AIFIFLNOENN<T>(this IEnumerable<T> BJNJBGHPMEH, Func<T, bool> CDCBKLPKDAJ) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2CC94A0", Offset = "0x2CC7AA0", VA = "0x182CC94A0")]
	public static string ONHANCKIDDN<T>(this IEnumerable<T> BJNJBGHPMEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5830", Offset = "0x2CC3E30", VA = "0x182CC5830")]
	public static Dictionary<TKey?, TValue?>? HFOAHDOEEKE<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> MKLJJBDOOGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5830", Offset = "0x2CC3E30", VA = "0x182CC5830")]
	public static Dictionary<TKey?, TValue?>? HFOAHDOEEKE<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> MKLJJBDOOGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2CC3400", Offset = "0x2CC1A00", VA = "0x182CC3400")]
	public static List<T> AOJADBJEDFH<T>(this IEnumerable<T> BJNJBGHPMEH, int HCAOLDLEJCN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2CC4F10", Offset = "0x2CC3510", VA = "0x182CC4F10")]
	public static string GCKKLFDHIEI<T>(this IEnumerable<T> BJNJBGHPMEH, string JNMPGCIKCCL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2CC4F50", Offset = "0x2CC3550", VA = "0x182CC4F50")]
	public static (IReadOnlyList<T?>?, IReadOnlyList<U?>?) HENAJECKEDB<T, U>(this IEnumerable<(T Lhs, U Rhs)> BJNJBGHPMEH)
	{
		return default((IReadOnlyList<T>, IReadOnlyList<U>));
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2C06AD0", Offset = "0x2C050D0", VA = "0x182C06AD0")]
	[IteratorStateMachine(typeof(AAJNMBAAPFJ<, >))]
	public static IEnumerable<(T, U)> PMGLAKDOJMO<T, U>(this IEnumerable<T> JDKMLCHPKLA, IEnumerable<U> AENKMLMFBAD) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2CC4210", Offset = "0x2CC2810", VA = "0x182CC4210")]
	public static IEnumerable<V> EFNBBBLIADL<V, T, U>(this IEnumerable<T> BJNJBGHPMEH, IEnumerable<U> PLNBHPCFEOK, Func<T, U, V> IGGJMELAANP, [Optional][CPCEDDOKEKI("`default!` shouldn't be necessary in C# 9")] T BIHMCIMGALD, [Optional][CPCEDDOKEKI("`default!` shouldn't be necessary in C# 9")] U BGMCHNMJHJN) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2CC42E0", Offset = "0x2CC28E0", VA = "0x182CC42E0")]
	public static IEnumerable<(T, U)> EFNBBBLIADL<T, U>(this IEnumerable<T> BJNJBGHPMEH, IEnumerable<U> PLNBHPCFEOK, [Optional][CPCEDDOKEKI("`default!` shouldn't be necessary in C# 9")] T BIHMCIMGALD, [Optional][CPCEDDOKEKI("`default!` shouldn't be necessary in C# 9")] U BGMCHNMJHJN) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2CC81A0", Offset = "0x2CC67A0", VA = "0x182CC81A0")]
	public static TOut[] OGFADKHPKCI<TOut, TIn>(this IEnumerable<TIn> KKBAGKHGAHE, Func<TIn, TOut> PBJOCDGKHLM) where TOut : notnull where TIn : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2CC3860", Offset = "0x2CC1E60", VA = "0x182CC3860")]
	public static OLCEOJBLPLC<U> DOGECJIFDEI<U, T>(this IEnumerable<T> OCCICMDPMFD, Func<T, U> FCIMJMHPEPD) where U : notnull where T : notnull
	{
		return default(OLCEOJBLPLC<U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class HMFACCCNPNF
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2D02290", Offset = "0x2D00890", VA = "0x182D02290")]
	public static bool CFGKFCPDPBN<T, U>(this T BJNJBGHPMEH, [In] U GHMNBJIOGAM) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2D021F0", Offset = "0x2D007F0", VA = "0x182D021F0")]
	public static bool ALBFCNMLCAH<T>(T BJNJBGHPMEH, T PLNBHPCFEOK) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class LJLIJANGCOJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xFB5E20", Offset = "0xFB4420", VA = "0x180FB5E20")]
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
			[Cpp2IlInjected.Address(RVA = "0xDCF430", Offset = "0xDCDA30", VA = "0x180DCF430", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3CF70A0", Offset = "0x3CF56A0", VA = "0x183CF70A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1F8C250", Offset = "0x1F8A850", VA = "0x181F8C250")]
		[DebuggerHidden]
		public HIENLFEIGLJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E774A0", Offset = "0x3E75AA0", VA = "0x183E774A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3E77690", Offset = "0x3E75C90", VA = "0x183E77690", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3E775C0", Offset = "0x3E75BC0", VA = "0x183E775C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x396BA90", Offset = "0x396A090", VA = "0x18396BA90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2E56C70", Offset = "0x2E55270", VA = "0x182E56C70")]
	public static void CKMHDEBAKHM<T>(this T KGPMLIHPPAA, Action<T> IODDMHCGLEA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2E56A60", Offset = "0x2E55060", VA = "0x182E56A60")]
	public static V BDIKEKLMAOA<V, T>(this T KGPMLIHPPAA, Func<T, V> IODDMHCGLEA, [Optional][CPCEDDOKEKI("`default!` shouldn't be necessary in C# 9")] V MCAGMGIJFIA) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2E56DA0", Offset = "0x2E553A0", VA = "0x182E56DA0")]
	public static T? FHLCGAFLGHG<T>(this T BJNJBGHPMEH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2E56B40", Offset = "0x2E55140", VA = "0x182E56B40")]
	[IteratorStateMachine(typeof(HIENLFEIGLJ<>))]
	public static IEnumerable<T> CJALIEINJCO<T>(this T BJNJBGHPMEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2E56940", Offset = "0x2E54F40", VA = "0x182E56940")]
	public static T[] APAOFMMMLOI<T>(this T BJNJBGHPMEH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FLOCEFCHHHD
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6C2E1A0", Offset = "0x6C2C7A0", VA = "0x186C2E1A0")]
	private static byte[] OCBOBLMIFNH(int OGMNEECDOAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6C2E2A0", Offset = "0x6C2C8A0", VA = "0x186C2E2A0")]
	private static byte[] POKGEOKKGAK(long MOOBPOCJAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6C2E220", Offset = "0x6C2C820", VA = "0x186C2E220")]
	private static byte[] OMNMKFIEACD(ulong MOOBPOCJAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D860", Offset = "0x6C2BE60", VA = "0x186C2D860")]
	public static Guid BCGCEBLHFNO(params Guid[] LNMBOLKPCAI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C2E0D0", Offset = "0x6C2C6D0", VA = "0x186C2E0D0")]
	public static Guid GMDNOGMNFLF([In] Guid DEBKHGODDAC, int HGFDMIDEFHN, int CJEHFDAEGCE = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6C2DBF0", Offset = "0x6C2C1F0", VA = "0x186C2DBF0")]
	public static Guid GMDNOGMNFLF([In] Guid DEBKHGODDAC, long HGFDMIDEFHN, int CJEHFDAEGCE = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6C2DB20", Offset = "0x6C2C120", VA = "0x186C2DB20")]
	public static Guid GMDNOGMNFLF([In] Guid DEBKHGODDAC, ulong HGFDMIDEFHN, int CJEHFDAEGCE = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6C2DAB0", Offset = "0x6C2C0B0", VA = "0x186C2DAB0")]
	public static Guid GMDNOGMNFLF([In] Guid DEBKHGODDAC, [In] Guid JGEMBFEJJJO, int CJEHFDAEGCE = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6C2DCC0", Offset = "0x6C2C2C0", VA = "0x186C2DCC0")]
	private static Guid GMDNOGMNFLF([In] Guid DEBKHGODDAC, byte[] GKELBPEGBOF, int CJEHFDAEGCE = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D9D0", Offset = "0x6C2BFD0", VA = "0x186C2D9D0")]
	private static void CAFGBHABHDA(byte[] GDCMEHKEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6C2DA60", Offset = "0x6C2C060", VA = "0x186C2DA60")]
	private static void CCIKDNNGCIK(byte[] GDCMEHKEAMI, int NFCDCHABNCB, int BCBMNIEKAKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class DMJMALPJKMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CCA0", Offset = "0x6C2B2A0", VA = "0x186C2CCA0")]
	public static int MGCPBFPGFKI(this int BJNJBGHPMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CBB0", Offset = "0x6C2B1B0", VA = "0x186C2CBB0")]
	public static int DCHEFFGMOAK(this int BJNJBGHPMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CD10", Offset = "0x6C2B310", VA = "0x186C2CD10")]
	public static int NLHKMKDPEHB(this int BJNJBGHPMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CB80", Offset = "0x6C2B180", VA = "0x186C2CB80")]
	public static int ALILHONEILP(this int BJNJBGHPMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5C46190", Offset = "0x5C44790", VA = "0x185C46190")]
	public static int DPPFNNEHAEI(this int BJNJBGHPMEH, int FIGHABPEBPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5D15CB0", Offset = "0x5D142B0", VA = "0x185D15CB0")]
	public static int BBNHFFLJGBK(this int BJNJBGHPMEH, int FIGHABPEBPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CC10", Offset = "0x6C2B210", VA = "0x186C2CC10")]
	public static float GCNEEHPCBCH(this int BJNJBGHPMEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CC30", Offset = "0x6C2B230", VA = "0x186C2CC30")]
	public static (byte, byte, byte, byte) HGBHKFBJPKF(this int BJNJBGHPMEH)
	{
		return default((byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CB90", Offset = "0x6C2B190", VA = "0x186C2CB90")]
	public static int CGMCOJBJMCI([In] this (byte Fourth, byte Third, byte Second, byte First) BJNJBGHPMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CBF0", Offset = "0x6C2B1F0", VA = "0x186C2CBF0")]
	public static int EAKDGLAJBIJ(this int BJNJBGHPMEH, int LPJIFNFGHKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CC00", Offset = "0x6C2B200", VA = "0x186C2CC00")]
	public static int FLHPBPCGEPG(this int BJNJBGHPMEH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class CKIMAOHJGLL
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C050", Offset = "0x6C2A650", VA = "0x186C2C050")]
	public static (byte, byte, byte, byte, byte, byte, byte, byte) HGBHKFBJPKF(this long BJNJBGHPMEH)
	{
		return default((byte, byte, byte, byte, byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C000", Offset = "0x6C2A600", VA = "0x186C2C000")]
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
	[Cpp2IlInjected.Address(RVA = "0x2AA9E50", Offset = "0x2AA8450", VA = "0x182AA9E50")]
	public static (TKey?, TValue?) DFKJGFPNLFL<TKey, TValue>([In] this KeyValuePair<TKey, TValue> BJNJBGHPMEH)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9FB0", Offset = "0x2AA85B0", VA = "0x182AA9FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public GMFCBIBPINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3DFB5B0", Offset = "0x3DF9BB0", VA = "0x183DFB5B0")]
		internal TElement JDDBMCDJNHC(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2E0A1B0", Offset = "0x2E087B0", VA = "0x182E0A1B0")]
	public static int ADMKPEAKAFD<T>(this IReadOnlyList<T> DKEEEGEFALD, T KLABJGGMBGH) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C2D0", Offset = "0x2E0A8D0", VA = "0x182E0C2D0")]
	public static int CKDIDAGFNMF<T>(this IReadOnlyList<T> DKEEEGEFALD, T KLABJGGMBGH) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2E0B0B0", Offset = "0x2E096B0", VA = "0x182E0B0B0")]
	public static void ANBIJFEAHKA<T>(this HashSet<T> LECDLAFDCPH, IEnumerable<T> PCIGIFGMPKJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2E11FB0", Offset = "0x2E105B0", VA = "0x182E11FB0")]
	public static void OFJFGIEEMJM<T>(this IList<T> OLAPNOFMNPM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2E12040", Offset = "0x2E10640", VA = "0x182E12040")]
	public static void OFJFGIEEMJM<T>(this IList<T> OLAPNOFMNPM, int FEMCHEMEPHN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2E11220", Offset = "0x2E0F820", VA = "0x182E11220")]
	public static void LNEJGAOEEDK<T>(this List<T> OLAPNOFMNPM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C700", Offset = "0x2E0AD00", VA = "0x182E0C700")]
	public static List<T> DFKLJMEIFJG<T>(this List<T> PBOBDMHLHMC, Predicate<T> GFGLICDGDGO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2E0A800", Offset = "0x2E08E00", VA = "0x182E0A800")]
	public static int ADMKPEAKAFD<T>(this IReadOnlyList<T> OLAPNOFMNPM, Predicate<T> PLAHCKGGFOL) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2E0FBC0", Offset = "0x2E0E1C0", VA = "0x182E0FBC0")]
	public static bool JBHINEFHIHE<T>(this IReadOnlyList<T> OLAPNOFMNPM, Predicate<T> PLAHCKGGFOL, [Out][NotNullWhen(true)] List<int>? HCMMOHLNFNH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2E0D410", Offset = "0x2E0BA10", VA = "0x182E0D410")]
	public static bool FEAHPDAAGAE<T>(this IReadOnlyList<T> OLAPNOFMNPM, T IFNDNLEGMFO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2E0D490", Offset = "0x2E0BA90", VA = "0x182E0D490")]
	public static bool FEAHPDAAGAE<T>(this IReadOnlyList<T> OLAPNOFMNPM, T IFNDNLEGMFO, EqualityComparer<T> NBGPDLBENLO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2E10660", Offset = "0x2E0EC60", VA = "0x182E10660")]
	public static int LGJNDOFDFLM<TElement, TKey>(this IList<TElement> NIDNIMJBLHD, TKey DFJLAHHHIMO, Func<TElement, TKey> JPHMEIMMIHP, [Optional] Func<TKey, TKey, int>? AGCAFECCHLJ, int HGFDMIDEFHN = 0, [Optional] int? FIGHABPEBPG) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2E102C0", Offset = "0x2E0E8C0", VA = "0x182E102C0")]
	public static int LGJNDOFDFLM<TElement, TKey>(Func<int, TElement> PIJOFFMJJJI, int JKNGMJEPPGC, TKey DFJLAHHHIMO, Func<TElement, TKey> JPHMEIMMIHP, [Optional] Func<TKey, TKey, int>? AGCAFECCHLJ, int HGFDMIDEFHN = 0, [Optional] int? FIGHABPEBPG) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C160", Offset = "0x2E0A760", VA = "0x182E0C160")]
	public static bool CBHFIIIMEAF<T>(this List<T> OLAPNOFMNPM, T IFNDNLEGMFO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BDE0", Offset = "0x2E0A3E0", VA = "0x182E0BDE0")]
	public static void CAPPIDPBNND<T>(this List<T> OLAPNOFMNPM, IEnumerable<T> PBOBDMHLHMC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2E118F0", Offset = "0x2E0FEF0", VA = "0x182E118F0")]
	public static void MBEEDABKNGP<T>(this List<T> OLAPNOFMNPM, IEnumerable<T> PBOBDMHLHMC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2E0CBB0", Offset = "0x2E0B1B0", VA = "0x182E0CBB0")]
	public static T FBHDLJGPLJG<T>(this List<T> PBOBDMHLHMC, Predicate<T> GFGLICDGDGO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C660", Offset = "0x2E0AC60", VA = "0x182E0C660")]
	public static T DEDHCIFAEMK<T>(this List<T> PBOBDMHLHMC, int HGFDMIDEFHN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2B15880", Offset = "0x2B13E80", VA = "0x182B15880")]
	public static void AAOPJACGKPM<T>(this List<T> OLAPNOFMNPM, int HGFDMIDEFHN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2E11EC0", Offset = "0x2E104C0", VA = "0x182E11EC0")]
	public static bool OCGFKPNPJNM<T>(this List<T> KPHELINOJPA, List<T> GOMOGEBCGDG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2E10060", Offset = "0x2E0E660", VA = "0x182E10060")]
	public static T JGNJBPBIKDP<T>(this IList<T> OLAPNOFMNPM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2E0CB00", Offset = "0x2E0B100", VA = "0x182E0CB00")]
	public static bool DJAFGNIKJIM<T>(IReadOnlyList<T>? OLAPNOFMNPM, int HGFDMIDEFHN, [Out][MaybeNullWhen(false)][CPCEDDOKEKI("This should be `T?` in C# 9.")] T POBDLJBBBCI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2E0EBA0", Offset = "0x2E0D1A0", VA = "0x182E0EBA0")]
	public static bool HHIPBODADFF<T>(IReadOnlyList<T> OLAPNOFMNPM, ICollection PBOBDMHLHMC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2E11CF0", Offset = "0x2E102F0", VA = "0x182E11CF0")]
	public static void NEJGNPNKEMO<T>(IReadOnlyList<T> OLAPNOFMNPM, ICollection PBOBDMHLHMC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2ADD1D0", Offset = "0x2ADB7D0", VA = "0x182ADD1D0")]
	public static bool BLEILDLJFCK<T>(this IReadOnlyList<T> OLAPNOFMNPM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2E10100", Offset = "0x2E0E700", VA = "0x182E10100")]
	public static string LEBCDCMGHDD<T>(this IEnumerable<T> OLAPNOFMNPM, string DAHJFKGMDFP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2E0AF30", Offset = "0x2E09530", VA = "0x182E0AF30")]
	public static T AIHPANHNNLP<T>(this IList<T> BJNJBGHPMEH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2E11810", Offset = "0x2E0FE10", VA = "0x182E11810")]
	public static T LNJKLIGNFIE<T>(this IList<T> BJNJBGHPMEH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2E11190", Offset = "0x2E0F790", VA = "0x182E11190")]
	public static void LINBHBPLMND<T>(this IList<T> BJNJBGHPMEH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C4C0", Offset = "0x2E0AAC0", VA = "0x182E0C4C0")]
	public static void DECKGGGPHHE<T>(this IList<T> BJNJBGHPMEH, [In] T KLABJGGMBGH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2E12770", Offset = "0x2E10D70", VA = "0x182E12770")]
	public static T PCNLHCIDHNJ<T>(this IList<T> BJNJBGHPMEH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C880", Offset = "0x2E0AE80", VA = "0x182E0C880")]
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
	[Cpp2IlInjected.Address(RVA = "0x6C2D2D0", Offset = "0x6C2B8D0", VA = "0x186C2D2D0")]
	public static bool OCKNIKDDDNI(float MOKDKAEJAPP, float MKGNFMMEFHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D1E0", Offset = "0x6C2B7E0", VA = "0x186C2D1E0")]
	public static float KIHDCGGLOBN(float KLABJGGMBGH, float GDAPDOPOOAD, float EMFANHEMBJM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D1C0", Offset = "0x6C2B7C0", VA = "0x186C2D1C0")]
	public static int KIHDCGGLOBN(int KLABJGGMBGH, int GDAPDOPOOAD, int EMFANHEMBJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CD90", Offset = "0x6C2B390", VA = "0x186C2CD90")]
	public static float CBFHCKPNFHE(float KLABJGGMBGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CDB0", Offset = "0x6C2B3B0", VA = "0x186C2CDB0")]
	public static float DCCAAHAEOCC(float MOKDKAEJAPP, float MKGNFMMEFHC, float KGPMLIHPPAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CD60", Offset = "0x6C2B360", VA = "0x186C2CD60")]
	public static float APIEIOFCJHA(float MOKDKAEJAPP, float MKGNFMMEFHC, float KGPMLIHPPAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D010", Offset = "0x6C2B610", VA = "0x186C2D010")]
	public static float FHMCPIGFMFH(float MOKDKAEJAPP, float MKGNFMMEFHC, float KLABJGGMBGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D200", Offset = "0x6C2B800", VA = "0x186C2D200")]
	public static float LCIHPFEOFDI(float MOKDKAEJAPP, float MKGNFMMEFHC, float KLABJGGMBGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CD70", Offset = "0x6C2B370", VA = "0x186C2CD70")]
	public static float BPBADMEJAOI(float MOKDKAEJAPP, float MKGNFMMEFHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CE50", Offset = "0x6C2B450", VA = "0x186C2CE50")]
	public static float EFHJODCBKOH(float FCOMLCEDOAO, float LLMCGMPLMBL, float CCMPEADKJKM, float AFJAGGMCDEN, float LGCLKPGINJF, float BKOJCILPMLI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D240", Offset = "0x6C2B840", VA = "0x186C2D240")]
	public static float LDKBNJKEFDG(float KLABJGGMBGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D0D0", Offset = "0x6C2B6D0", VA = "0x186C2D0D0")]
	public static float HLALPPBCJMJ(float KLABJGGMBGH, float GDAPDOPOOAD, float EMFANHEMBJM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D3C0", Offset = "0x6C2B9C0", VA = "0x186C2D3C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6C2D590", Offset = "0x6C2BB90", VA = "0x186C2D590")]
	public EBNBPDJNCHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D620", Offset = "0x6C2BC20", VA = "0x186C2D620")]
	public EBNBPDJNCHE(int FEMCHEMEPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x63AC560", Offset = "0x63AAB60", VA = "0x1863AC560", Slot = "4")]
	public virtual int FBNLOBKJFGM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D500", Offset = "0x6C2BB00", VA = "0x186C2D500", Slot = "5")]
	public virtual int FBNLOBKJFGM(int MPLPLEJAHJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D530", Offset = "0x6C2BB30", VA = "0x186C2D530", Slot = "6")]
	public virtual int FBNLOBKJFGM(int JNDEBCKEOBH, int MPLPLEJAHJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D560", Offset = "0x6C2BB60", VA = "0x186C2D560")]
	public double OPMPCKHAOKP()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class BODAICNOHHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2A191F0", Offset = "0x2A177F0", VA = "0x182A191F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6C2F1C0", Offset = "0x6C2D7C0", VA = "0x186C2F1C0")]
	public static (float3, float3, float3) PLHFPHNMLDP([In] this quaternion BJNJBGHPMEH)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6C2E7A0", Offset = "0x6C2CDA0", VA = "0x186C2E7A0")]
	private static float3 OKBBFNGLLHP(quaternion BEFBNHMKOGD, math.RotationOrder NOIFCGELKHC = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6C2E6D0", Offset = "0x6C2CCD0", VA = "0x186C2E6D0")]
	private static float3 JNIHAIBIPBG(float3 APGPPOJHJOP, math.RotationOrder NOIFCGELKHC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6C2E610", Offset = "0x6C2CC10", VA = "0x186C2E610")]
	public static float3 GHFKACEFKBN(this quaternion BEFBNHMKOGD, math.RotationOrder NOIFCGELKHC = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6C2E430", Offset = "0x6C2CA30", VA = "0x186C2E430")]
	public static float CEPOBKMNJJK(this quaternion JDKMLCHPKLA, quaternion AENKMLMFBAD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6C2E580", Offset = "0x6C2CB80", VA = "0x186C2E580")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C2D530", Offset = "0x6C2BB30", VA = "0x186C2D530", Slot = "4")]
		public int FBNLOBKJFGM(int OJOMCIPKCMD, int KLLHKAEACHP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6C2F2F0", Offset = "0x6C2D8F0", VA = "0x186C2F2F0", Slot = "5")]
		public float EEIPNIFBBJA(float OJOMCIPKCMD, float OICHMIEPDPG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2F2B0", Offset = "0x6C2D8B0", VA = "0x186C2F2B0")]
		private double CFCONKICANM()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2F360", Offset = "0x6C2D960", VA = "0x186C2F360")]
		public HLEBFNKICOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly AMNDJBAMMGA GMGLDOFMCCI;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F610", Offset = "0x6C2DC10", VA = "0x186C2F610")]
	public static ulong OGLOOOCOGJG()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class DGCFIILBCEH
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2AF73F0", Offset = "0x2AF59F0", VA = "0x182AF73F0")]
	public static bool GEHDGCICNPH<T>(this IReadOnlyCollection<T> BJNJBGHPMEH, int HGFDMIDEFHN) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class NLJIDINADFI
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2E21280", Offset = "0x2E1F880", VA = "0x182E21280")]
	public static bool KKBILJAAMLP<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> BJNJBGHPMEH, IReadOnlyDictionary<TKey, TValue> PLNBHPCFEOK) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class KEBPNFPMFJN
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2D65840", Offset = "0x2D63E40", VA = "0x182D65840")]
	public static TValue? LFEMPPENDHF<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> BJNJBGHPMEH, TKey LFOBGDLOPID) where TValue : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class NMGIKGPFPPM
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6C30650", Offset = "0x6C2EC50", VA = "0x186C30650")]
	public static void FJEDBGMGJGG(this IReadOnlyList<Action> BJNJBGHPMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2E21830", Offset = "0x2E1FE30", VA = "0x182E21830")]
	public static bool LAFFHOKCOBI<T>(this IReadOnlyList<T> BJNJBGHPMEH, int HGFDMIDEFHN, [Out][NotNullWhen(true)][CPCEDDOKEKI("This should be `T?` in C# 9.")] T POBDLJBBBCI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2E21750", Offset = "0x2E1FD50", VA = "0x182E21750")]
	public static bool DONKPKIJEAM<T>(this IReadOnlyList<T> BJNJBGHPMEH, int HGFDMIDEFHN, [Out] MGBLPJABDKK<T> POBDLJBBBCI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2E21A40", Offset = "0x2E20040", VA = "0x182E21A40")]
	public static T NOHJFANHDBH<T>(this IReadOnlyList<T> BJNJBGHPMEH, int HGFDMIDEFHN, [In] T JLEELMKDAAP) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2A101E0", Offset = "0x2A0E7E0", VA = "0x182A101E0")]
	[CPCEDDOKEKI("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T GDJGIKCPGKE<T>(this IReadOnlyList<T> BJNJBGHPMEH, int HGFDMIDEFHN) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2E21980", Offset = "0x2E1FF80", VA = "0x182E21980")]
	public static T? LFEMPPENDHF<T>(this IReadOnlyList<T> BJNJBGHPMEH, int HGFDMIDEFHN) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MIAJADCDGMI
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A4D0", Offset = "0x2D98AD0", VA = "0x182D9A4D0")]
	public static int OHCPFAOHMPG<T>([In] this ReadOnlySequence<T> CPICPHKKOGA, [In] T KLABJGGMBGH) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A0B0", Offset = "0x2D986B0", VA = "0x182D9A0B0")]
	public static bool LKOOBPLAALM<T>([In] this ReadOnlySequence<T> CPICPHKKOGA, [In] ReadOnlySpan<T> PLNBHPCFEOK) where T : IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class NBOIIEJHDHD
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2E05A70", Offset = "0x2E04070", VA = "0x182E05A70")]
	public static string ONHANCKIDDN<T>([In] this ReadOnlySpan<T> BJNJBGHPMEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2E051C0", Offset = "0x2E037C0", VA = "0x182E051C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C2D730", Offset = "0x6C2BD30", VA = "0x186C2D730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D6A0", Offset = "0x6C2BCA0", VA = "0x186C2D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C30510", Offset = "0x6C2EB10", VA = "0x186C30510", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	private MNMALLBMPNH(Stopwatch GNMHDDIJNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6C305E0", Offset = "0x6C2EBE0", VA = "0x186C305E0")]
	public static MNMALLBMPNH JPCPCEFBFML(Stopwatch GNMHDDIJNJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6C30530", Offset = "0x6C2EB30", VA = "0x186C30530")]
	public static MNMALLBMPNH FLBFBDEGMJA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class KCLPHHEDGPK
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F940", Offset = "0x6C2DF40", VA = "0x186C2F940")]
	public static float3 GPJAOPKEIBP([In] this RigidTransform BJNJBGHPMEH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6C2FA70", Offset = "0x6C2E070", VA = "0x186C2FA70")]
	public static float3 KAMMDKBCNPC([In] this RigidTransform BJNJBGHPMEH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xAF36B0", Offset = "0xAF1CB0", VA = "0x180AF36B0")]
	public static (float3, float3, float3) BFJIHEAEANC([In] this RigidTransform BJNJBGHPMEH)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6C2FBA0", Offset = "0x6C2E1A0", VA = "0x186C2FBA0")]
	public static RigidTransform PCEKCHIDGIF([In] this RigidTransform BJNJBGHPMEH)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class BAMDJMMLCFG
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BC10", Offset = "0x6C2A210", VA = "0x186C2BC10")]
	public static RigidTransform BFHICIPADPF(RigidTransform IMPJCLHCPMG, RigidTransform ANOMEOLFMEG)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class LKAGKPLIJLI
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6C2FC00", Offset = "0x6C2E200", VA = "0x186C2FC00")]
	public static float AMMMIIIHLFO([In] this (byte Fourth, byte Third, byte Second, byte First) BJNJBGHPMEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6C2FCB0", Offset = "0x6C2E2B0", VA = "0x186C2FCB0")]
	public static int PNMLEJFKLMP(this float BJNJBGHPMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2FC40", Offset = "0x6C2E240", VA = "0x186C2FC40")]
	public static (byte, byte, byte, byte) HGBHKFBJPKF(this float BJNJBGHPMEH)
	{
		return default((byte, byte, byte, byte));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class HKAFGIIFEDD
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2CFA300", Offset = "0x2CF8900", VA = "0x182CFA300")]
	public static ReadOnlySpan<T?> JKEOPFKCCGC<T>([In] this Span<T> BJNJBGHPMEH)
	{
		return default(ReadOnlySpan<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class BEDONONCDGO
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BCD0", Offset = "0x6C2A2D0", VA = "0x186C2BCD0")]
	public static StringBuilder KGFGDPDPFGM(this StringBuilder BJNJBGHPMEH, int MLBMJGHHLDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BD30", Offset = "0x6C2A330", VA = "0x186C2BD30")]
	public static StringBuilder OMHPLNEIDJC(this StringBuilder BJNJBGHPMEH, int MLBMJGHHLDO, string KLNAGGGGPDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BDA0", Offset = "0x6C2A3A0", VA = "0x186C2BDA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5FDB270", Offset = "0x5FD9870", VA = "0x185FDB270")]
	public static bool BLEILDLJFCK(this string? NFDBNIDBLCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C940", Offset = "0x6C2AF40", VA = "0x186C2C940")]
	public static string? PAEICHODKAL(this string? BJNJBGHPMEH, int DOBHOIOIHAC, string DFOHDCALBCD = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C620", Offset = "0x6C2AC20", VA = "0x186C2C620")]
	public static string JBHJOOGAJDK(this string BJNJBGHPMEH, int DOBHOIOIHAC, string DFOHDCALBCD = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C7A0", Offset = "0x6C2ADA0", VA = "0x186C2C7A0")]
	public static int LKCOIAIPJMK(this string NFDBNIDBLCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C810", Offset = "0x6C2AE10", VA = "0x186C2C810")]
	public static string MHHCGPKHNOK(this string NFDBNIDBLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C6C0", Offset = "0x6C2ACC0", VA = "0x186C2C6C0")]
	public static string[] KMNDIALNMLD(this string NFDBNIDBLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C8C0", Offset = "0x6C2AEC0", VA = "0x186C2C8C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x50342F0", Offset = "0x50328F0", VA = "0x1850342F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4478E60", Offset = "0x4477460", VA = "0x184478E60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4478C60", Offset = "0x4477260", VA = "0x184478C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x4478CB0", Offset = "0x44772B0", VA = "0x184478CB0")]
	public static BDDMAEDBDJL CCMPMMECDOA()
	{
		return default(BDDMAEDBDJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x4478F30", Offset = "0x4477530", VA = "0x184478F30")]
	private static void NGCJPMMEDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x4478EB0", Offset = "0x44774B0", VA = "0x184478EB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6C2F5A0", Offset = "0x6C2DBA0", VA = "0x186C2F5A0")]
	public JBGCBMFDKPN(ADGJAKKJOPB GNMHDDIJNJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F510", Offset = "0x6C2DB10", VA = "0x186C2F510")]
	public long OFEGCKLLLHH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F3F0", Offset = "0x6C2D9F0", VA = "0x186C2F3F0")]
	public double BFBNIIPDPNH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F480", Offset = "0x6C2DA80", VA = "0x186C2F480")]
	public double FMPINEJDHCL()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class LOLBNMAJMMB
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6C2FCC0", Offset = "0x6C2E2C0", VA = "0x186C2FCC0")]
	public static bool JKKMLBDKEIL(this Type BJNJBGHPMEH, Type PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2D7E610", Offset = "0x2D7CC10", VA = "0x182D7E610")]
	public static bool JKKMLBDKEIL<T>(this Type BJNJBGHPMEH) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class IBIEALBEAIF
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5C46190", Offset = "0x5C44790", VA = "0x185C46190")]
	public static uint DPPFNNEHAEI(this uint BJNJBGHPMEH, int FIGHABPEBPG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5D15CB0", Offset = "0x5D142B0", VA = "0x185D15CB0")]
	public static uint BBNHFFLJGBK(this uint BJNJBGHPMEH, int FIGHABPEBPG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F3E0", Offset = "0x6C2D9E0", VA = "0x186C2F3E0")]
	public static uint FLLAAGJCDIE(this uint BJNJBGHPMEH, uint ADGDKMKAJHJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x11DECD0", Offset = "0x11DD2D0", VA = "0x1811DECD0")]
	public static int PNMLEJFKLMP(this uint BJNJBGHPMEH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class CMGAOAEOENC
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2ABDDE0", Offset = "0x2ABC3E0", VA = "0x182ABDDE0")]
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
