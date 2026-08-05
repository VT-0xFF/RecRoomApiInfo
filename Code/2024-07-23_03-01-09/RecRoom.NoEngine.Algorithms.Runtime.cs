using System;
using System.Buffers;
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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69B9DE0", Offset = "0x69B8FE0", VA = "0x1869B9DE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D8D0", Offset = "0x87CAD0", VA = "0x18087D8D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x87D910", Offset = "0x87CB10", VA = "0x18087D910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ADPBFNLHOGO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string[] CDOHOFNLDMH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69B5E10", Offset = "0x69B5010", VA = "0x1869B5E10")]
	public static bool LPHOGMLLJPL(string FBMPJIIJEEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69B5D40", Offset = "0x69B4F40", VA = "0x1869B5D40")]
	private static bool CKKILMMFBKH(string JNNDBFGKHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69B5BF0", Offset = "0x69B4DF0", VA = "0x1869B5BF0")]
	public static bool CKKILMMFBKH(Exception NKAKJFGNGPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69B5EE0", Offset = "0x69B50E0", VA = "0x1869B5EE0")]
	public static string NHCGBNEEJLG(string GMHAEBALLKB, string NNJFFKDDDDA = "", bool GFPCLPEDKGP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PNMMLLNLMJG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x69BA2B0", Offset = "0x69B94B0", VA = "0x1869BA2B0")]
	public static string KAIENAPFKHE(this Guid BMIGIGGJPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x69BA210", Offset = "0x69B9410", VA = "0x1869BA210")]
	public static string KAIENAPFKHE(this byte[] DDNKCFIIBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69BA150", Offset = "0x69B9350", VA = "0x1869BA150")]
	public static byte[] CCNJHJOEGFB(string EABHLPOLHMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HKDOOOJJINL
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int FDFICELDDEL<T>([In] T DIAAOCPNHKC, [In] T LLLBDLGIMPP);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class NNEHJLCMLJE<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct NLKEEFLDINM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly int JHEGPJBDKAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public readonly int MLNHFJAKLHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public readonly bool PFHBNDJOKEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int AIPCLKOGKMJ;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x45410B0", Offset = "0x45402B0", VA = "0x1845410B0")]
			public NLKEEFLDINM(int JHEGPJBDKAJ, int MLNHFJAKLHF, bool PFHBNDJOKEK)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly T[] MMHDMEIDHKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly T[] KFPEFACCDHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly FDFICELDDEL<T> NKKLGPMGJKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly int IBCNCEMAPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Func<bool> APBONDMIJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int JBNJBDDBCID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly NLKEEFLDINM[] GPAFGMODKOB;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4543110", Offset = "0x4542310", VA = "0x184543110")]
		public NNEHJLCMLJE(T[] MMHDMEIDHKC, FDFICELDDEL<T> NKKLGPMGJKA, int IBCNCEMAPNJ, Func<bool> APBONDMIJJD, T[]? CCJIHGKEAJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4542B90", Offset = "0x4541D90", VA = "0x184542B90")]
		public bool LIBMGPOAIEA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate U DMKGDBOFMED<T, U>(int ODHMBPBIJMP, int KDANPNNHCHB, [In] ReadOnlySpan<T> MIDEDCLHDIO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A4E0", Offset = "0x2B796E0", VA = "0x182B7A4E0")]
	public static T[] MJCIEJCNKFK<T>(int ECGAAJFODGN, T BIEFEFHDBDM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2B79AA0", Offset = "0x2B78CA0", VA = "0x182B79AA0")]
	public static void GGGODOGDJNE<T>(this T[] CALBLOGAHCA, T BIEFEFHDBDM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2B79190", Offset = "0x2B78390", VA = "0x182B79190")]
	public static void BCJNPAMEKAI<T>(this T[] PFKJAOOHGBN, int HCDMGOGKHKP, int DMFIBEKOIIG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2B79C70", Offset = "0x2B78E70", VA = "0x182B79C70")]
	private static void JBEHINGHLPF<T>(this T[] HIKEOGPAJAF, int PKKDFCAFPBB, int NAPGOMFFGCF, T[] OKGBBGMIACH, int AHFGGCDEKAJ, int HFAKMJBCHCA, T[] ADPMAHMCGNH, int ALODEEIIDPL, FDFICELDDEL<T> NKKLGPMGJKA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A020", Offset = "0x2B79220", VA = "0x182B7A020")]
	public static void JLKOILKHFMG<T>(this T[] HIKEOGPAJAF, int JHEGPJBDKAJ, int IHGHLPOONHD, FDFICELDDEL<T> NKKLGPMGJKA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A420", Offset = "0x2B79620", VA = "0x182B7A420")]
	public static NNEHJLCMLJE<T> LCEMPEIHBMC<T>(this T[] HIKEOGPAJAF, FDFICELDDEL<T> NKKLGPMGJKA, int IBCNCEMAPNJ, Func<bool> APBONDMIJJD, [Optional] T[]? CCJIHGKEAJJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B000", Offset = "0x2B7A200", VA = "0x182B7B000")]
	public static T[] PEDIBNMCFJO<T>(this T[] PFKJAOOHGBN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2B78FA0", Offset = "0x2B781A0", VA = "0x182B78FA0")]
	public static T[] ALKEHJEOAGA<T>(this T[] OKOAMOIIKKC, T IPGDLBDFACI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A680", Offset = "0x2B79880", VA = "0x182B7A680")]
	public static T[] NGNGEKIHAAC<T>(this T[] OKOAMOIIKKC, int DHNLEFJCEAH, T IPGDLBDFACI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2B7AF50", Offset = "0x2B7A150", VA = "0x182B7AF50")]
	public static T[] OCMLDEJJKGE<T>(this T[] OKOAMOIIKKC, int DHNLEFJCEAH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2B79800", Offset = "0x2B78A00", VA = "0x182B79800")]
	public static T[] FEFHGLLCPME<T>(this T[] OKOAMOIIKKC, int DHNLEFJCEAH, T IPGDLBDFACI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2B79210", Offset = "0x2B78410", VA = "0x182B79210")]
	public static U[] FEFBAKEMNGC<U, T>(this T[] FDPJMKODKPJ, int IEILANLMBPK, DMKGDBOFMED<T, U> PEHPKDBILGB) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69B86C0", Offset = "0x69B78C0", VA = "0x1869B86C0")]
	public static byte[] MBLJJGGIMHO(this byte[] HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69B8440", Offset = "0x69B7640", VA = "0x1869B8440")]
	public static byte[] LLGPPEJEJHM(this byte[] HIKEOGPAJAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FBIOKBIMKBD
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69B8430", Offset = "0x69B7630", VA = "0x1869B8430")]
	public static byte IIMKMKMGOJO(this bool HIKEOGPAJAF)
	{
		return default(byte);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NDBOCOOEMLI
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69B8430", Offset = "0x69B7630", VA = "0x1869B8430")]
	public static bool OLOPNIJICGI(this byte HIKEOGPAJAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DFILBHIBMEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x29859B0", Offset = "0x2984BB0", VA = "0x1829859B0")]
	public static void IGBBLEHMHFF<T>(this ICollection<T> HIKEOGPAJAF, IEnumerable<T> NHEIBBJGGFH) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CGJHKCPGODI
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2947840", Offset = "0x2946A40", VA = "0x182947840")]
	public static void EFNHCCNLOOG<K, V>(this IDictionary<K, V> HIKEOGPAJAF, [In] K NDDCLPHCEEO, [In] V JMDCGOKJIDA, Func<V, V, V> MEECDKIOGGN) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2946490", Offset = "0x2945690", VA = "0x182946490")]
	public static void CNOGOJMHKLA<K, V>(this IDictionary<K, List<V>> HIKEOGPAJAF, [In] K NDDCLPHCEEO, [In] V JMDCGOKJIDA) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2946E70", Offset = "0x2946070", VA = "0x182946E70")]
	public static TVal DIKBKFOJHON<TVal, TKey>(this IDictionary<TKey, TVal> ENCKOMKBEOC, [In] TKey NDDCLPHCEEO, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] TVal LIAHLPBCKNO) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2946AB0", Offset = "0x2945CB0", VA = "0x182946AB0")]
	public static TVal DIKBKFOJHON<TVal, TKey>(this IDictionary<TKey, TVal> ENCKOMKBEOC, [In] TKey NDDCLPHCEEO, Func<TVal> DCGAOGMNBFH) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2947F20", Offset = "0x2947120", VA = "0x182947F20")]
	public static TValue GJPKPNDNNIC<TValue, TKey>(this IDictionary<TKey, TValue> ENCKOMKBEOC, [In] TKey NDDCLPHCEEO, [Optional][In][PEHALAEOKAF("`default!` and null-oblivious region shouldn't be necessary in C# 9")] TValue LIAHLPBCKNO)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x29489B0", Offset = "0x2947BB0", VA = "0x1829489B0")]
	public static V MNGDKADHKGK<V, K>(this IDictionary<K, V> HIKEOGPAJAF, [In] K NDDCLPHCEEO) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2948780", Offset = "0x2947980", VA = "0x182948780")]
	public static T2[] MCENKMDFCLO<T2, T1>(this Dictionary<T1, T2>.ValueCollection DPDOFFDPNCI) where T2 : notnull where T1 : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EAKOBCMPIKB
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate bool PKCGECHPCAN<TArgs, T>([In] TArgs FJCOFFFFCFE, T JNHGHHKKNBB);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate U MKIAHMFHKAH<TArg, U>([In] TArg BGLHKLFFJEP);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate U BCKAOIKJMGJ<TArg, T, U>([In] TArg BGLHKLFFJEP, T EEEMMJKAAFP);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate U GPGKOFBEHAE<TArg, T, U>([In] TArg BGLHKLFFJEP, IEnumerable<T> DBMHCDPGPKD);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate U MDDPMEIOOBK<TArg, T, U>([In] TArg BGLHKLFFJEP, T EEEMMJKAAFP);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct JKHLBJIDAPH<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x40B99B0", Offset = "0x40B8BB0", VA = "0x1840B99B0")]
		[PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) PPOBLJNPNFG(T PKMFOCDHIGE)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x40B9950", Offset = "0x40B8B50", VA = "0x1840B9950")]
		[PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) NCKFNMLGMIE(IEnumerable<T> IBFCINICLHB)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class GEKALJJOOIC<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA74640", Offset = "0xA73840", VA = "0x180A74640", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x3CBF700", Offset = "0x3CBE900", VA = "0x183CBF700", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA74780", Offset = "0xA73980", VA = "0x180A74780")]
		[DebuggerHidden]
		public GEKALJJOOIC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x398CD50", Offset = "0x398BF50", VA = "0x18398CD50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3CBE5D0", Offset = "0x3CBD7D0", VA = "0x183CBE5D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3CBE520", Offset = "0x3CBD720", VA = "0x183CBE520")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3CBF5D0", Offset = "0x3CBE7D0", VA = "0x183CBF5D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3CBF2E0", Offset = "0x3CBE4E0", VA = "0x183CBF2E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3CBF590", Offset = "0x3CBE790", VA = "0x183CBF590", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class ONAGJDICEDK<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x89FB40", Offset = "0x89ED40", VA = "0x18089FB40")]
		[DebuggerHidden]
		public ONAGJDICEDK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x46B5240", Offset = "0x46B4440", VA = "0x1846B5240", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x46B47A0", Offset = "0x46B39A0", VA = "0x1846B47A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x46B4210", Offset = "0x46B3410", VA = "0x1846B4210")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x46B4370", Offset = "0x46B3570", VA = "0x1846B4370")]
		private void KNPOGHPBEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x46B5150", Offset = "0x46B4350", VA = "0x1846B5150", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x46B5060", Offset = "0x46B4260", VA = "0x1846B5060", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3AE70C0", Offset = "0x3AE62C0", VA = "0x183AE70C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CPFAOCOJFOP<T> : IEnumerable<(T, PLBAMKEJCKB<T>)>, IEnumerable, IEnumerator<(T, PLBAMKEJCKB<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private (T Current, PLBAMKEJCKB<T> Next) <>2__current;

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
		private (T, PLBAMKEJCKB<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x38726A0", Offset = "0x38718A0", VA = "0x1838726A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, PLBAMKEJCKB<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5204920", Offset = "0x5203B20", VA = "0x185204920", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1EA13E0", Offset = "0x1EA05E0", VA = "0x181EA13E0")]
		[DebuggerHidden]
		public CPFAOCOJFOP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3992C60", Offset = "0x3991E60", VA = "0x183992C60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5203AB0", Offset = "0x5202CB0", VA = "0x185203AB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5203020", Offset = "0x5202220", VA = "0x185203020")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x52048D0", Offset = "0x5203AD0", VA = "0x1852048D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5204710", Offset = "0x5203910", VA = "0x185204710", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, PLBAMKEJCKB<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3AE70C0", Offset = "0x3AE62C0", VA = "0x183AE70C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FDLEODMKIDH<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
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
		private Func<JKHLBJIDAPH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Func<JKHLBJIDAPH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IEnumerator<T> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private IEnumerator<U> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		U IEnumerator<UnityEngine.SpookyHash.U>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (U)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x89FB40", Offset = "0x89ED40", VA = "0x18089FB40")]
		[DebuggerHidden]
		public FDLEODMKIDH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3B845F0", Offset = "0x3B837F0", VA = "0x183B845F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3B84000", Offset = "0x3B83200", VA = "0x183B84000", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3B83F60", Offset = "0x3B83160", VA = "0x183B83F60")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3B83FB0", Offset = "0x3B831B0", VA = "0x183B83FB0")]
		private void KNPOGHPBEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3B845A0", Offset = "0x3B837A0", VA = "0x183B845A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3B84480", Offset = "0x3B83680", VA = "0x183B84480", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3B84560", Offset = "0x3B83760", VA = "0x183B84560", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class FCACGKHMLMI<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public FCACGKHMLMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3B81A40", Offset = "0x3B80C40", VA = "0x183B81A40")]
		internal bool BBJKHLHBHAF(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3B81B40", Offset = "0x3B80D40", VA = "0x183B81B40")]
		internal bool CODEPPDONIC(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class DNENLEDGPJA<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private (T Lhs, U Rhs) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerable<T> lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public IEnumerable<T> <>3__lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private IEnumerable<U> rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public IEnumerable<U> <>3__rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<T> <lhsIt>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private IEnumerator<U> <rhsIt>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private (T, U) System.Collections.Generic.IEnumerator<(TLhs,URhs)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xC36B10", Offset = "0xC35D10", VA = "0x180C36B10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, U));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x3C06380", Offset = "0x3C05580", VA = "0x183C06380", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1EA13E0", Offset = "0x1EA05E0", VA = "0x181EA13E0")]
		[DebuggerHidden]
		public DNENLEDGPJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5793E10", Offset = "0x5793010", VA = "0x185793E10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5794110", Offset = "0x5793310", VA = "0x185794110", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5794030", Offset = "0x5793230", VA = "0x185794030", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3AE70C0", Offset = "0x3AE62C0", VA = "0x183AE70C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x29A87D0", Offset = "0x29A79D0", VA = "0x1829A87D0")]
	public static bool KKHLEEOKLGB<T, TArgs>(this IEnumerable<T> HIKEOGPAJAF, [In] TArgs FJCOFFFFCFE, PKCGECHPCAN<TArgs, T> FPMLEFBLCHO) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x69B8080", Offset = "0x69B7280", VA = "0x1869B8080")]
	public static bool KKHLEEOKLGB(this IEnumerable<bool> HIKEOGPAJAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x29A7030", Offset = "0x29A6230", VA = "0x1829A7030")]
	public static U IJLMDDCAPNL<U, T>(this IEnumerable<T> HIKEOGPAJAF, Func<U> CONELMGFCGB, Func<T, U> PKMFOCDHIGE, Func<IEnumerable<T>, U> IBFCINICLHB) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x29A5090", Offset = "0x29A4290", VA = "0x1829A5090")]
	public static bool BJGLEBNPPFH<T, TArgs>(this IEnumerable<T> HIKEOGPAJAF, [In] TArgs FJCOFFFFCFE, PKCGECHPCAN<TArgs, T> FPMLEFBLCHO) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x29A6520", Offset = "0x29A5720", VA = "0x1829A6520")]
	public static U FCAADEANJJD<U, T, TArg>(this IEnumerable<T> HIKEOGPAJAF, [In] TArg BGLHKLFFJEP, MKIAHMFHKAH<TArg, U> CONELMGFCGB, BCKAOIKJMGJ<TArg, T, U> PKMFOCDHIGE, GPGKOFBEHAE<TArg, T, U> IBFCINICLHB) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x29AA810", Offset = "0x29A9A10", VA = "0x1829AA810")]
	public static IEnumerable<U> NAOHNHLGJKB<U, T, TArg>(this IEnumerable<T> HIKEOGPAJAF, [In] TArg BGLHKLFFJEP, MDDPMEIOOBK<TArg, T, U> GFJKGKFLLNA) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2933940", Offset = "0x2932B40", VA = "0x182933940")]
	public static IEnumerable<T> FALCGKHCMIC<T>(params IEnumerable<T>[] MMGLMOKPEMK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x29A5690", Offset = "0x29A4890", VA = "0x1829A5690")]
	public static bool CGMJPCEONFC<T>(this IEnumerable<T> LDPKCIGIIMG, IEnumerable<T> OKGBBGMIACH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2933940", Offset = "0x2932B40", VA = "0x182933940")]
	public static IEnumerable<(TKey?, TValue?)>? CCKGOGEPIBB<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x29A9D70", Offset = "0x29A8F70", VA = "0x1829A9D70")]
	public static IEnumerable<T> LKFMLDOOMJD<T, TKey>(this IEnumerable<T> HKKJHHAHAPB, Func<T, TKey> MKEKONBCKMJ) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x29A9B50", Offset = "0x29A8D50", VA = "0x1829A9B50")]
	[IteratorStateMachine(typeof(GEKALJJOOIC<>))]
	public static IEnumerable<T> LEFFMPLPDEF<T>(this IEnumerable<T> LDPKCIGIIMG, ISet<T> DNDCPHACLKK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x29AB960", Offset = "0x29AAB60", VA = "0x1829AB960")]
	[IteratorStateMachine(typeof(ONAGJDICEDK<, >))]
	public static IEnumerable<T> OGCGMMDIBKF<T, U>(this IEnumerable<T> HIKEOGPAJAF, IEnumerable<U> OKGBBGMIACH, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] T BIEFEFHDBDM) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2846530", Offset = "0x2845730", VA = "0x182846530")]
	public static T CFKPAHBGIJG<T>(this IEnumerable<T> LDPKCIGIIMG, T LIAHLPBCKNO) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x29A5610", Offset = "0x29A4810", VA = "0x1829A5610")]
	public static T CFKPAHBGIJG<T>(this IEnumerable<T> LDPKCIGIIMG, T LIAHLPBCKNO, Func<T, bool> FPMLEFBLCHO) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x29AB060", Offset = "0x29AA260", VA = "0x1829AB060")]
	public static T? NAPAMMOLDBK<T>(this IEnumerable<T> HIKEOGPAJAF, Func<T, bool> FPMLEFBLCHO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x29A9140", Offset = "0x29A8340", VA = "0x1829A9140")]
	public static void LEBBJHKNBKL<T>(this IEnumerable<T> HIKEOGPAJAF, Action<T> MFIDPDMAIND) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x29A5D50", Offset = "0x29A4F50", VA = "0x1829A5D50")]
	[IteratorStateMachine(typeof(CPFAOCOJFOP<>))]
	public static IEnumerable<(T, PLBAMKEJCKB<T>)> EDPCDGMGKHD<T>(this IEnumerable<T> HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x29A6AB0", Offset = "0x29A5CB0", VA = "0x1829A6AB0")]
	public static bool HJLHPLEIDIL<T>(this IEnumerable<T> HIKEOGPAJAF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2933940", Offset = "0x2932B40", VA = "0x182933940")]
	public static IEnumerable<DPKNNHGNADJ<T>> LINJEMEJAMF<T>(this IEnumerable<T> HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x29A55D0", Offset = "0x29A47D0", VA = "0x1829A55D0")]
	public static bool CFHDDGLKNCC<T>(this IEnumerable<T> HIKEOGPAJAF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x29A5880", Offset = "0x29A4A80", VA = "0x1829A5880")]
	public static IEnumerable<T> CKBHFIBMDAB<T>(this IEnumerable<T>? HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x29A5F30", Offset = "0x29A5130", VA = "0x1829A5F30")]
	[IteratorStateMachine(typeof(FDLEODMKIDH<, >))]
	public static IEnumerable<U> EOHLPAJKNEL<U, T>(this IEnumerable<T> HIKEOGPAJAF, Func<JKHLBJIDAPH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> EOADKOMMODL) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x29A6BE0", Offset = "0x29A5DE0", VA = "0x1829A6BE0")]
	public static int HKJFCCOJFGI<T>(this IEnumerable<T> HIKEOGPAJAF, int FIBICGKNAKG = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x29A7290", Offset = "0x29A6490", VA = "0x1829A7290")]
	public static bool INAGFOMGOEG<T>(this IEnumerable<T> HIKEOGPAJAF, IEnumerable<T> OKGBBGMIACH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x29A5C30", Offset = "0x29A4E30", VA = "0x1829A5C30")]
	public static IEnumerable<T> DOGIKJLCHLF<T>(this IEnumerable<T> HIKEOGPAJAF, int MPIFCNGGGGI, int KONEOOFJOKB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x29A5900", Offset = "0x29A4B00", VA = "0x1829A5900")]
	public static (IEnumerable<T>, IEnumerable<T>) DCNBBOAPDPK<T>(this IEnumerable<T> HIKEOGPAJAF, Func<T, bool> HOLGHJNBIKC) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x29A77D0", Offset = "0x29A69D0", VA = "0x1829A77D0")]
	public static string KBCEOFKOLKI<T>(this IEnumerable<T> HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x29A8C50", Offset = "0x29A7E50", VA = "0x1829A8C50")]
	public static Dictionary<TKey?, TValue?>? KPDFEFIEFPE<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> LDPKCIGIIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x29A8C50", Offset = "0x29A7E50", VA = "0x1829A8C50")]
	public static Dictionary<TKey?, TValue?>? KPDFEFIEFPE<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> LDPKCIGIIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x29A74F0", Offset = "0x29A66F0", VA = "0x1829A74F0")]
	public static List<T> IOPEBPIHFIF<T>(this IEnumerable<T> HIKEOGPAJAF, int HHGNDILCLEE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x29A58C0", Offset = "0x29A4AC0", VA = "0x1829A58C0")]
	public static string CKNFMLLAHMG<T>(this IEnumerable<T> HIKEOGPAJAF, string HBDNCCCHBFK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x29A9F50", Offset = "0x29A9150", VA = "0x1829A9F50")]
	public static (IReadOnlyList<T?>?, IReadOnlyList<U?>?) NAFHBBOOPKA<T, U>(this IEnumerable<(T Lhs, U Rhs)> HIKEOGPAJAF)
	{
		return default((IReadOnlyList<T>, IReadOnlyList<U>));
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x29A6A00", Offset = "0x29A5C00", VA = "0x1829A6A00")]
	[IteratorStateMachine(typeof(DNENLEDGPJA<, >))]
	public static IEnumerable<(T, U)> FIMGFNCBOFM<T, U>(this IEnumerable<T> DIAAOCPNHKC, IEnumerable<U> LLLBDLGIMPP) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x29A7FF0", Offset = "0x29A71F0", VA = "0x1829A7FF0")]
	public static IEnumerable<V> KHIGECFLBJL<V, T, U>(this IEnumerable<T> HIKEOGPAJAF, IEnumerable<U> OKGBBGMIACH, Func<T, U, V> MOBJBCBCGHM, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] T JEHGEELJDFM, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] U FMDONOJEILG) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x29A80C0", Offset = "0x29A72C0", VA = "0x1829A80C0")]
	public static IEnumerable<(T, U)> KHIGECFLBJL<T, U>(this IEnumerable<T> HIKEOGPAJAF, IEnumerable<U> OKGBBGMIACH, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] T JEHGEELJDFM, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] U FMDONOJEILG) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x29A5FE0", Offset = "0x29A51E0", VA = "0x1829A5FE0")]
	public static TOut[] EPKCBAFHILN<TOut, TIn>(this IEnumerable<TIn> HKKJHHAHAPB, Func<TIn, TOut> NADEGDKPFJF) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class LMIAOEGDMNH
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C19480", Offset = "0x2C18680", VA = "0x182C19480")]
	public static bool FJKIGFFOPFM<T, U>(this T HIKEOGPAJAF, [In] U MEAFIMADMKA) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C192E0", Offset = "0x2C184E0", VA = "0x182C192E0")]
	public static bool AFJPHNJAOIP<T>(T HIKEOGPAJAF, T OKGBBGMIACH) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class NKLLLMGIMKG
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xB58F70", Offset = "0xB58170", VA = "0x180B58F70")]
	public static bool MFBKNDJBHNP([In] this float3 MLFGLJKBOIG, float3 GANEOONFJPD, float KOIGIPMKHNI = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class GPEJBEBOKCN
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class AKKLCJHDAEC<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private T self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public T <>3__self;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8C9C20", Offset = "0x8C8E20", VA = "0x1808C9C20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x3AF3FA0", Offset = "0x3AF31A0", VA = "0x183AF3FA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA77770", Offset = "0xA76970", VA = "0x180A77770")]
		[DebuggerHidden]
		public AKKLCJHDAEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3C974D0", Offset = "0x3C966D0", VA = "0x183C974D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3C97820", Offset = "0x3C96A20", VA = "0x183C97820", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3C97640", Offset = "0x3C96840", VA = "0x183C97640", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x38C9560", Offset = "0x38C8760", VA = "0x1838C9560", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2B45100", Offset = "0x2B44300", VA = "0x182B45100")]
	public static void MPFLDPJAJCN<T>(this T DOGPFNGIKMO, Action<T> EFKDKFPJEOC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2B44F20", Offset = "0x2B44120", VA = "0x182B44F20")]
	public static V LIOGJJDCAIE<V, T>(this T DOGPFNGIKMO, Func<T, V> EFKDKFPJEOC, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] V LIAHLPBCKNO) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2B450D0", Offset = "0x2B442D0", VA = "0x182B450D0")]
	public static T? MNFBLOLFMCB<T>(this T HIKEOGPAJAF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2B45150", Offset = "0x2B44350", VA = "0x182B45150")]
	[IteratorStateMachine(typeof(AKKLCJHDAEC<>))]
	public static IEnumerable<T> NNIAELNOGDE<T>(this T HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2B44E60", Offset = "0x2B44060", VA = "0x182B44E60")]
	public static T[] BOOPCLMHOOH<T>(this T HIKEOGPAJAF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class HMFDMDIMNKF
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x69B9110", Offset = "0x69B8310", VA = "0x1869B9110")]
	private static byte[] BGMKJFHCEBH(int EOHIGKOGJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x69B91E0", Offset = "0x69B83E0", VA = "0x1869B91E0")]
	private static byte[] FEKCLCKLGJO(long GFMBFOEFLFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x69B9AC0", Offset = "0x69B8CC0", VA = "0x1869B9AC0")]
	private static byte[] LMEMCDNMCCH(ulong GFMBFOEFLFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x69B9260", Offset = "0x69B8460", VA = "0x1869B9260")]
	public static Guid FGLKJEEINAI(params Guid[] DEMIACNOBKK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x69B95E0", Offset = "0x69B87E0", VA = "0x1869B95E0")]
	public static Guid JGIIBNEOBDO([In] Guid CEPMGOINFCI, int DHNLEFJCEAH, int DMDAEILPBHA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x69B93D0", Offset = "0x69B85D0", VA = "0x1869B93D0")]
	public static Guid JGIIBNEOBDO([In] Guid CEPMGOINFCI, long DHNLEFJCEAH, int DMDAEILPBHA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x69B9510", Offset = "0x69B8710", VA = "0x1869B9510")]
	public static Guid JGIIBNEOBDO([In] Guid CEPMGOINFCI, ulong DHNLEFJCEAH, int DMDAEILPBHA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x69B94A0", Offset = "0x69B86A0", VA = "0x1869B94A0")]
	public static Guid JGIIBNEOBDO([In] Guid CEPMGOINFCI, [In] Guid EKLMECJNLFM, int DMDAEILPBHA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x69B96B0", Offset = "0x69B88B0", VA = "0x1869B96B0")]
	private static Guid JGIIBNEOBDO([In] Guid CEPMGOINFCI, byte[] MOGPIKMFOBM, int DMDAEILPBHA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x69B9B40", Offset = "0x69B8D40", VA = "0x1869B9B40")]
	private static void PAGHNLCKGJE(byte[] BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x69B9190", Offset = "0x69B8390", VA = "0x1869B9190")]
	private static void CEAAOKLGLDM(byte[] BMIGIGGJPJD, int IIILBPDHGHN, int CLEBPGFBBGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class JPEPKPDNAIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x69B9BE0", Offset = "0x69B8DE0", VA = "0x1869B9BE0")]
	public static int FDHMPNLEBLB(this int HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x69B9CF0", Offset = "0x69B8EF0", VA = "0x1869B9CF0")]
	public static int IECDDPNDBFL(this int HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x69B9D60", Offset = "0x69B8F60", VA = "0x1869B9D60")]
	public static int OOIPPCEBAGH(this int HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x69B9D50", Offset = "0x69B8F50", VA = "0x1869B9D50")]
	public static int NPIJGHAJOCD(this int HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x59C15F0", Offset = "0x59C07F0", VA = "0x1859C15F0")]
	public static int MOIBDHMHAOD(this int HIKEOGPAJAF, int IHGHLPOONHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5A92170", Offset = "0x5A91370", VA = "0x185A92170")]
	public static int GPPIGGICPDA(this int HIKEOGPAJAF, int IHGHLPOONHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x69B9CC0", Offset = "0x69B8EC0", VA = "0x1869B9CC0")]
	public static float HEIABDBKDFF(this int HIKEOGPAJAF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x69B9C50", Offset = "0x69B8E50", VA = "0x1869B9C50")]
	public static (byte, byte, byte, byte) GHHGACDFBJE(this int HIKEOGPAJAF)
	{
		return default((byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x69B9D30", Offset = "0x69B8F30", VA = "0x1869B9D30")]
	public static int NJOPHBHAJAO([In] this (byte Fourth, byte Third, byte Second, byte First) HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x69B9BD0", Offset = "0x69B8DD0", VA = "0x1869B9BD0")]
	public static int CDGLJAHDMBE(this int HIKEOGPAJAF, int NJCKMOCNMLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x69B9CE0", Offset = "0x69B8EE0", VA = "0x1869B9CE0")]
	public static int HJNKMMLMBEN(this int HIKEOGPAJAF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface IFEOFOPDGND
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NCDLNIPPHPH(int CLGCOGDJGGD, int JAHIDHODFOM);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float AJDEJPNKOAH(float AOIAEDIEBNE, float COFGILMBNIC);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface DGCOAPLMOMC
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	long KKAEOACBFPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class GLCADIPEEEJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2B3AD60", Offset = "0x2B39F60", VA = "0x182B3AD60")]
	public static (TKey?, TValue?) BOABPIFLJCL<TKey, TValue>([In] this KeyValuePair<TKey, TValue> HIKEOGPAJAF)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2B3AE60", Offset = "0x2B3A060", VA = "0x182B3AE60")]
	public static KeyValuePair<TKey?, UValue?> FCHKAEGFAGB<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> HIKEOGPAJAF, UValue JMDCGOKJIDA)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class CDIPAFFIBDH
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class EOLGDPIJHFO<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public EOLGDPIJHFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x381AA20", Offset = "0x3819C20", VA = "0x18381AA20")]
		internal TElement CHELHJKMNJG(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x29381C0", Offset = "0x29373C0", VA = "0x1829381C0")]
	public static int JGHILGAHPFO<T>(this IReadOnlyList<T> PFKJAOOHGBN, T JMDCGOKJIDA) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2933F80", Offset = "0x2933180", VA = "0x182933F80")]
	public static int AKCGLOHGMEL<T>(this IReadOnlyList<T> PFKJAOOHGBN, T JMDCGOKJIDA) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2936A80", Offset = "0x2935C80", VA = "0x182936A80")]
	public static void IGBBLEHMHFF<T>(this HashSet<T> KEAGOEBAADJ, IEnumerable<T> NHEIBBJGGFH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x293C230", Offset = "0x293B430", VA = "0x18293C230")]
	public static void MHLIKHLBJMA<T>(this IList<T> CGIFJALMJMI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x293BEF0", Offset = "0x293B0F0", VA = "0x18293BEF0")]
	public static void MHLIKHLBJMA<T>(this IList<T> CGIFJALMJMI, int BLKFENOKNBK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x29365D0", Offset = "0x29357D0", VA = "0x1829365D0")]
	public static void HMFOCIHCEII<T>(this List<T> CGIFJALMJMI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2937BB0", Offset = "0x2936DB0", VA = "0x182937BB0")]
	public static List<T> INPLDMDMPDD<T>(this List<T> HNFHFEEOANA, Predicate<T> JAIHDGBHBKO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2938970", Offset = "0x2937B70", VA = "0x182938970")]
	public static int JGHILGAHPFO<T>(this IReadOnlyList<T> CGIFJALMJMI, Predicate<T> FPMLEFBLCHO) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2937D20", Offset = "0x2936F20", VA = "0x182937D20")]
	public static bool JAIFAKFBDGH<T>(this IReadOnlyList<T> CGIFJALMJMI, Predicate<T> FPMLEFBLCHO, [Out][NotNullWhen(true)] List<int>? NADKEDPNJIG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x29349A0", Offset = "0x2933BA0", VA = "0x1829349A0")]
	public static bool DJONJHALGBO<T>(this IReadOnlyList<T> CGIFJALMJMI, T JNHGHHKKNBB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2934A20", Offset = "0x2933C20", VA = "0x182934A20")]
	public static bool DJONJHALGBO<T>(this IReadOnlyList<T> CGIFJALMJMI, T JNHGHHKKNBB, EqualityComparer<T> BPPCHPJNELP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2935C00", Offset = "0x2934E00", VA = "0x182935C00")]
	public static int GPEMOONFGLC<TElement, TKey>(this IList<TElement> BBBNKNOHJJK, TKey CKABANFMPEC, Func<TElement, TKey> GOMMKLLBHPI, [Optional] Func<TKey, TKey, int>? NKKLGPMGJKA, int DHNLEFJCEAH = 0, [Optional] int? IHGHLPOONHD) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x29354E0", Offset = "0x29346E0", VA = "0x1829354E0")]
	public static int GPEMOONFGLC<TElement, TKey>(Func<int, TElement> JDHCINADAHL, int EMPLEBMINIM, TKey CKABANFMPEC, Func<TElement, TKey> GOMMKLLBHPI, [Optional] Func<TKey, TKey, int>? NKKLGPMGJKA, int DHNLEFJCEAH = 0, [Optional] int? IHGHLPOONHD) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2934DD0", Offset = "0x2933FD0", VA = "0x182934DD0")]
	public static bool DOLJLPNFCJD<T>(this List<T> CGIFJALMJMI, T JNHGHHKKNBB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x293BAD0", Offset = "0x293ACD0", VA = "0x18293BAD0")]
	public static void MELMPBFMJHE<T>(this List<T> CGIFJALMJMI, IEnumerable<T> HNFHFEEOANA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x293BD00", Offset = "0x293AF00", VA = "0x18293BD00")]
	public static void MFKDEBIIBOM<T>(this List<T> CGIFJALMJMI, IEnumerable<T> HNFHFEEOANA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2938F10", Offset = "0x2938110", VA = "0x182938F10")]
	public static T JJDFLFNMFAN<T>(this List<T> HNFHFEEOANA, Predicate<T> JAIHDGBHBKO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x29352A0", Offset = "0x29344A0", VA = "0x1829352A0")]
	public static T GAJGMHKEDPD<T>(this List<T> HNFHFEEOANA, int DHNLEFJCEAH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x293C690", Offset = "0x293B890", VA = "0x18293C690")]
	public static void MNACKLLGDEF<T>(this List<T> CGIFJALMJMI, int DHNLEFJCEAH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x293B9F0", Offset = "0x293ABF0", VA = "0x18293B9F0")]
	public static bool LELMNEPJABL<T>(this List<T> DEGDMKBFAHB, List<T> MAAFMCBCEMG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2934FE0", Offset = "0x29341E0", VA = "0x182934FE0")]
	public static T EDHMEHIAPCG<T>(this IList<T> CGIFJALMJMI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2934150", Offset = "0x2933350", VA = "0x182934150")]
	public static bool DIFBCONAOBO<T>(IReadOnlyList<T>? CGIFJALMJMI, int DHNLEFJCEAH, [Out][MaybeNullWhen(false)][PEHALAEOKAF("This should be `T?` in C# 9.")] T ADPMAHMCGNH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x293AC00", Offset = "0x2939E00", VA = "0x18293AC00")]
	public static bool KOBBLOOJGBO<T>(IReadOnlyList<T> CGIFJALMJMI, ICollection HNFHFEEOANA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2934B80", Offset = "0x2933D80", VA = "0x182934B80")]
	public static void DKMJAELAMAF<T>(IReadOnlyList<T> CGIFJALMJMI, ICollection HNFHFEEOANA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x293C990", Offset = "0x293BB90", VA = "0x18293C990")]
	public static bool PMFPICAICLC<T>(this IReadOnlyList<T> CGIFJALMJMI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2933DC0", Offset = "0x2932FC0", VA = "0x182933DC0")]
	public static string AHIOMJNHHKD<T>(this IEnumerable<T> CGIFJALMJMI, string PCOEHEFFIFO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2939220", Offset = "0x2938420", VA = "0x182939220")]
	public static T KNGBBJIFKLI<T>(this IList<T> HIKEOGPAJAF) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x29351C0", Offset = "0x29343C0", VA = "0x1829351C0")]
	public static T EOPINEMMCIA<T>(this IList<T> HIKEOGPAJAF) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x293B960", Offset = "0x293AB60", VA = "0x18293B960")]
	public static void LDCCHNFGFOA<T>(this IList<T> HIKEOGPAJAF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2935340", Offset = "0x2934540", VA = "0x182935340")]
	public static void GJGCHHNBGJO<T>(this IList<T> HIKEOGPAJAF, [In] T JMDCGOKJIDA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x293C890", Offset = "0x293BA90", VA = "0x18293C890")]
	public static T ODIHBLEHJMG<T>(this IList<T> HIKEOGPAJAF) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2936350", Offset = "0x2935550", VA = "0x182936350")]
	public static void HLBPNCGBDMN<T>(this List<T> HIKEOGPAJAF) where T : struct, IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class HKIPMAJDKCI
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static float ENMDMJJIELJ;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static float DNILFNNPKBA;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static bool PHFDGBFGMID;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly float NHINBPCGKNC;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x69B8B50", Offset = "0x69B7D50", VA = "0x1869B8B50")]
	public static bool CGJBJNHIIFF(float MLFGLJKBOIG, float GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x69B8E30", Offset = "0x69B8030", VA = "0x1869B8E30")]
	public static float KEJDGPCDCJO(float JMDCGOKJIDA, float ILMEANFNINA, float PLJHMOFCKBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x69B8E10", Offset = "0x69B8010", VA = "0x1869B8E10")]
	public static int KEJDGPCDCJO(int JMDCGOKJIDA, int ILMEANFNINA, int PLJHMOFCKBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x69B8D40", Offset = "0x69B7F40", VA = "0x1869B8D40")]
	public static float GKOLJHKEOJF(float JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x69B8F10", Offset = "0x69B8110", VA = "0x1869B8F10")]
	public static float NGCNCLHNMFD(float MLFGLJKBOIG, float GANEOONFJPD, float DOGPFNGIKMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x69B8D30", Offset = "0x69B7F30", VA = "0x1869B8D30")]
	public static float GFIDGNBIGMG(float MLFGLJKBOIG, float GANEOONFJPD, float DOGPFNGIKMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x69B8E50", Offset = "0x69B8050", VA = "0x1869B8E50")]
	public static float KGOKKLNOHFG(float MLFGLJKBOIG, float GANEOONFJPD, float JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x69B8950", Offset = "0x69B7B50", VA = "0x1869B8950")]
	public static float AIAHOEEJDNA(float MLFGLJKBOIG, float GANEOONFJPD, float JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x69B8DF0", Offset = "0x69B7FF0", VA = "0x1869B8DF0")]
	public static float JEGNKKKIMIH(float MLFGLJKBOIG, float GANEOONFJPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x69B8990", Offset = "0x69B7B90", VA = "0x1869B8990")]
	public static float BBEBNHCKJOG(float HJGDDFBNENN, float CGKANMHMCOJ, float KBIDPPDGADG, float PMFJOEPDBGE, float ONOCCGOPHEL, float LDGBKFKPDEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x69B8D60", Offset = "0x69B7F60", VA = "0x1869B8D60")]
	public static float IDFMNKMOCOB(float JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x69B8C40", Offset = "0x69B7E40", VA = "0x1869B8C40")]
	public static float FAAJIBJKBPN(float JMDCGOKJIDA, float ILMEANFNINA, float PLJHMOFCKBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x69B8FB0", Offset = "0x69B81B0", VA = "0x1869B8FB0")]
	public static float PBLINCJGDCC(float HJPCBAPEOLF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class PNPOGLPEGCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private System.Random GKFOMEENHHJ;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x69BA3B0", Offset = "0x69B95B0", VA = "0x1869BA3B0")]
	public PNPOGLPEGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x69BA440", Offset = "0x69B9640", VA = "0x1869BA440")]
	public PNPOGLPEGCB(int BLKFENOKNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6130700", Offset = "0x612F900", VA = "0x186130700", Slot = "4")]
	public virtual int NCDLNIPPHPH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x69BA350", Offset = "0x69B9550", VA = "0x1869BA350", Slot = "5")]
	public virtual int NCDLNIPPHPH(int JAHIDHODFOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x69B7AF0", Offset = "0x69B6CF0", VA = "0x1869B7AF0", Slot = "6")]
	public virtual int NCDLNIPPHPH(int CLGCOGDJGGD, int JAHIDHODFOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x69BA380", Offset = "0x69B9580", VA = "0x1869BA380")]
	public double OLNHPAKJBDL()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class BEIMNDIIHCP
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x28CD170", Offset = "0x28CC370", VA = "0x1828CD170")]
	[EGHHEKDFLLK("This should be replaced with the `is not` operator in C# 9.")]
	public static bool LCBKPMFONAC<T>(this object HIKEOGPAJAF, [Out][NotNullWhen(true)] T ADPMAHMCGNH) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class CGLIAFCKGKL
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x69B78C0", Offset = "0x69B6AC0", VA = "0x1869B78C0")]
	public static (float3, float3, float3) MCOBGCJNMFI([In] this quaternion HIKEOGPAJAF)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x69B6C00", Offset = "0x69B5E00", VA = "0x1869B6C00")]
	private static float3 BLPJDNIFDPC(quaternion FPAMJPKIJHC, math.RotationOrder EHNNGENIEKG = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x69B79B0", Offset = "0x69B6BB0", VA = "0x1869B79B0")]
	private static float3 MPAJKMJLFLJ(float3 HEAKNKCAFIJ, math.RotationOrder EHNNGENIEKG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x69B76B0", Offset = "0x69B68B0", VA = "0x1869B76B0")]
	public static float3 FKDDBJGPLJP(this quaternion FPAMJPKIJHC, math.RotationOrder EHNNGENIEKG = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x69B7770", Offset = "0x69B6970", VA = "0x1869B7770")]
	public static float LEJGAHMKINH(this quaternion DIAAOCPNHKC, quaternion LLLBDLGIMPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x69B7620", Offset = "0x69B6820", VA = "0x1869B7620")]
	[CompilerGenerated]
	internal static float3 EHIHOPLDOOJ(float3 HEAKNKCAFIJ)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class DLKJGLEHONI
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private sealed class DDKFLOAIDPO : IFEOFOPDGND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly System.Random IEOMJLMICFG;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x69B7AF0", Offset = "0x69B6CF0", VA = "0x1869B7AF0", Slot = "4")]
		public int NCDLNIPPHPH(int AOIAEDIEBNE, int AIACEMCFIDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x69B7A80", Offset = "0x69B6C80", VA = "0x1869B7A80", Slot = "5")]
		public float AJDEJPNKOAH(float AOIAEDIEBNE, float COFGILMBNIC)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x69B7B20", Offset = "0x69B6D20", VA = "0x1869B7B20")]
		private double OHJJHCNFBKP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x69B7B60", Offset = "0x69B6D60", VA = "0x1869B7B60")]
		public DDKFLOAIDPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly IFEOFOPDGND PIJNCOJONDM;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x69B7BE0", Offset = "0x69B6DE0", VA = "0x1869B7BE0")]
	public static ulong MHOJAOPOLHK()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class PFIJDJMLACG
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6070", Offset = "0x2CD5270", VA = "0x182CD6070")]
	public static bool HLJIJANFIGD<T>(this IReadOnlyCollection<T> HIKEOGPAJAF, int DHNLEFJCEAH) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class IICKKIPNECH
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2B92580", Offset = "0x2B91780", VA = "0x182B92580")]
	public static bool JKONKPFGDNM<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> HIKEOGPAJAF, IReadOnlyDictionary<TKey, TValue> OKGBBGMIACH) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class CEHKCOHDCLO
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2941DB0", Offset = "0x2940FB0", VA = "0x182941DB0")]
	public static TValue? JNHKPIOPLBC<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> HIKEOGPAJAF, TKey NDDCLPHCEEO) where TValue : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class ADKFOGDNBCF
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x69B5970", Offset = "0x69B4B70", VA = "0x1869B5970")]
	public static void APPOJKGPLJE(this IReadOnlyList<Action> HIKEOGPAJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x31DB830", Offset = "0x31DAA30", VA = "0x1831DB830")]
	public static bool AKPHPFIGELN<T>(this IReadOnlyList<T> HIKEOGPAJAF, int DHNLEFJCEAH, [Out][PEHALAEOKAF("This should be `T?` in C# 9.")][NotNullWhen(true)] T ADPMAHMCGNH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x31DB750", Offset = "0x31DA950", VA = "0x1831DB750")]
	public static bool AGLPFCLAPCJ<T>(this IReadOnlyList<T> HIKEOGPAJAF, int DHNLEFJCEAH, [Out] DPKNNHGNADJ<T> ADPMAHMCGNH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x31DBA40", Offset = "0x31DAC40", VA = "0x1831DBA40")]
	public static T PFDCILMKFFC<T>(this IReadOnlyList<T> HIKEOGPAJAF, int DHNLEFJCEAH, [In] T GFMHDPANGKF) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2C17390", Offset = "0x2C16590", VA = "0x182C17390")]
	[PEHALAEOKAF("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T HKHMHEOFKFK<T>(this IReadOnlyList<T> HIKEOGPAJAF, int DHNLEFJCEAH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x31DB980", Offset = "0x31DAB80", VA = "0x1831DB980")]
	public static T? JNHKPIOPLBC<T>(this IReadOnlyList<T> HIKEOGPAJAF, int DHNLEFJCEAH) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class FALJLCJPCNG
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2B1AF40", Offset = "0x2B1A140", VA = "0x182B1AF40")]
	public static int IMLBDBIFEKB<T>([In] this ReadOnlySequence<T> BJMHIIGPDHE, [In] T JMDCGOKJIDA) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B220", Offset = "0x2B1A420", VA = "0x182B1B220")]
	public static bool PKAAANLMMFG<T>([In] this ReadOnlySequence<T> BJMHIIGPDHE, [In] ReadOnlySpan<T> OKGBBGMIACH) where T : IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class AENPEJMEEON
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x31DD220", Offset = "0x31DC420", VA = "0x1831DD220")]
	public static string KBCEOFKOLKI<T>([In] this ReadOnlySpan<T> HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x31DC580", Offset = "0x31DB780", VA = "0x1831DC580")]
	public static string CKNFMLLAHMG<T>([In] this ReadOnlySpan<T> HIKEOGPAJAF, string HBDNCCCHBFK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EOJILIFGCIN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static DGCOAPLMOMC IDOIHFLMHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x69B8260", Offset = "0x69B7460", VA = "0x1869B8260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x69B82B0", Offset = "0x69B74B0", VA = "0x1869B82B0")]
	public static double HFMNCNMLOCD(this DGCOAPLMOMC HIKEOGPAJAF, long HHBDNCNCDOG)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class DOIECMEOPFJ : DGCOAPLMOMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Stopwatch HCEBOJJHIBP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long KKAEOACBFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x69B7F40", Offset = "0x69B7140", VA = "0x1869B7F40", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8523E0", VA = "0x1808531E0")]
	private DOIECMEOPFJ(Stopwatch FPCPJEPFGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x69B7F60", Offset = "0x69B7160", VA = "0x1869B7F60")]
	public static DOIECMEOPFJ GADLDLPFBEL(Stopwatch FPCPJEPFGDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x69B7FD0", Offset = "0x69B71D0", VA = "0x1869B7FD0")]
	public static DOIECMEOPFJ NKNDOJELBNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class BHDJNFMCIEP
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x69B6430", Offset = "0x69B5630", VA = "0x1869B6430")]
	public static float3 IPHKICBAECJ([In] this RigidTransform HIKEOGPAJAF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x69B6560", Offset = "0x69B5760", VA = "0x1869B6560")]
	public static float3 KLDADDHEDFM([In] this RigidTransform HIKEOGPAJAF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x94B120", Offset = "0x94A320", VA = "0x18094B120")]
	public static (float3, float3, float3) JKICLEKIMIM([In] this RigidTransform HIKEOGPAJAF)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x69B6690", Offset = "0x69B5890", VA = "0x1869B6690")]
	public static RigidTransform PBBOICIJGJH([In] this RigidTransform HIKEOGPAJAF)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class EBPGLKHDBEH
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x69B81A0", Offset = "0x69B73A0", VA = "0x1869B81A0")]
	public static RigidTransform DIPNPIPFKGK(RigidTransform EAJCNPPJMKJ, RigidTransform ILOHGCBACNL)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class PJNALCOBKFM
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x69BA090", Offset = "0x69B9290", VA = "0x1869BA090")]
	public static float BCEMEHCIFHG([In] this (byte Fourth, byte Third, byte Second, byte First) HIKEOGPAJAF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x69BA0D0", Offset = "0x69B92D0", VA = "0x1869BA0D0")]
	public static int FANKENHGAAB(this float HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x69BA0E0", Offset = "0x69B92E0", VA = "0x1869BA0E0")]
	public static (byte, byte, byte, byte) GHHGACDFBJE(this float HIKEOGPAJAF)
	{
		return default((byte, byte, byte, byte));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class HJJJANGGGCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2943EB0", Offset = "0x29430B0", VA = "0x182943EB0")]
	public static ReadOnlySpan<T?> IGCPKIKCNFG<T>([In] this Span<T> HIKEOGPAJAF)
	{
		return default(ReadOnlySpan<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class BJDCGPPBOME
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static Regex EFDOLLMNNFJ;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static Regex ABADEMBICDB;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly char[] GFEEDFDNHJL;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5D5B9D0", Offset = "0x5D5ABD0", VA = "0x185D5B9D0")]
	public static bool PMFPICAICLC(this string? JBNNPFLCMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x69B68D0", Offset = "0x69B5AD0", VA = "0x1869B68D0")]
	public static string? OLAJANNCJJL(this string? HIKEOGPAJAF, int KBFGFPLLOGD, string DHLJFGHDBHB = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x69B6820", Offset = "0x69B5A20", VA = "0x1869B6820")]
	public static string KFDHGJNEAGJ(this string HIKEOGPAJAF, int KBFGFPLLOGD, string DHLJFGHDBHB = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x69B66F0", Offset = "0x69B58F0", VA = "0x1869B66F0")]
	public static int AJAEBJMABBF(this string JBNNPFLCMMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x69B6760", Offset = "0x69B5960", VA = "0x1869B6760")]
	public static string KAKOJOPHCGK(this string JBNNPFLCMMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x69B69B0", Offset = "0x69B5BB0", VA = "0x1869B69B0")]
	public static string[] PHJJOGMMNJN(this string JBNNPFLCMMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class CKMNNCJJICK<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public readonly struct FCAOODOBHEC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3B81BA0", Offset = "0x3B80DA0", VA = "0x183B81BA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static int EIFHIBBFGCL;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static OGJOILKOKFE LAJJANPCBKM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static long KKAEOACBFPI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x44F3210", Offset = "0x44F2410", VA = "0x1844F3210")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x51F5B50", Offset = "0x51F4D50", VA = "0x1851F5B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x51F5C20", Offset = "0x51F4E20", VA = "0x1851F5C20")]
	public static FCAOODOBHEC OFGECFEDLIK()
	{
		return default(FCAOODOBHEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x51F59C0", Offset = "0x51F4BC0", VA = "0x1851F59C0")]
	private static void GFNHEDKJGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x51F5BB0", Offset = "0x51F4DB0", VA = "0x1851F5BB0")]
	public static void MJPMKPPBJPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct OGJOILKOKFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly DGCOAPLMOMC HCEBOJJHIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly long IGFDBKGHGCE;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x69BA020", Offset = "0x69B9220", VA = "0x1869BA020")]
	public OGJOILKOKFE(DGCOAPLMOMC FPCPJEPFGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x69B9F90", Offset = "0x69B9190", VA = "0x1869B9F90")]
	public long HJHOALHJOIG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x69B9F00", Offset = "0x69B9100", VA = "0x1869B9F00")]
	public double HFMNCNMLOCD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x69B9E70", Offset = "0x69B9070", VA = "0x1869B9E70")]
	public double GONLFMOBKHF()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class NKEOBENGMDH
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x69B9DB0", Offset = "0x69B8FB0", VA = "0x1869B9DB0")]
	public static bool NMFAJOENEIM(this Type HIKEOGPAJAF, Type OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2B40", Offset = "0x2CA1D40", VA = "0x182CA2B40")]
	public static bool NMFAJOENEIM<T>(this Type HIKEOGPAJAF) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class OANJLBINAIN
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x59C15F0", Offset = "0x59C07F0", VA = "0x1859C15F0")]
	public static uint MOIBDHMHAOD(this uint HIKEOGPAJAF, int IHGHLPOONHD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5A92170", Offset = "0x5A91370", VA = "0x185A92170")]
	public static uint GPPIGGICPDA(this uint HIKEOGPAJAF, int IHGHLPOONHD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x69B9E60", Offset = "0x69B9060", VA = "0x1869B9E60")]
	public static uint GGLJGOOKPEN(this uint HIKEOGPAJAF, uint PDEKPELNLDP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x1038640", Offset = "0x1037840", VA = "0x181038640")]
	public static int FANKENHGAAB(this uint HIKEOGPAJAF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class CAMPEJJKAIE
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2933300", Offset = "0x2932500", VA = "0x182933300")]
	public static bool AEMOOLMCFOM<T>([In] this T? HIKEOGPAJAF, [Out] T JMDCGOKJIDA) where T : struct
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
