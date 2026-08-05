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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x699EEF0", Offset = "0x699D8F0", VA = "0x18699EEF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D9C0", Offset = "0x87C3C0", VA = "0x18087D9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87DA00", Offset = "0x87C400", VA = "0x18087DA00")]
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
	[Cpp2IlInjected.Address(RVA = "0x699AF20", Offset = "0x6999920", VA = "0x18699AF20")]
	public static bool LPHOGMLLJPL(string FBMPJIIJEEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x699AE50", Offset = "0x6999850", VA = "0x18699AE50")]
	private static bool CKKILMMFBKH(string JNNDBFGKHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x699AD00", Offset = "0x6999700", VA = "0x18699AD00")]
	public static bool CKKILMMFBKH(Exception NKAKJFGNGPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x699AFF0", Offset = "0x69999F0", VA = "0x18699AFF0")]
	public static string NHCGBNEEJLG(string GMHAEBALLKB, string NNJFFKDDDDA = "", bool GFPCLPEDKGP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PNMMLLNLMJG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x699F3C0", Offset = "0x699DDC0", VA = "0x18699F3C0")]
	public static string KAIENAPFKHE(this Guid BMIGIGGJPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x699F320", Offset = "0x699DD20", VA = "0x18699F320")]
	public static string KAIENAPFKHE(this byte[] DDNKCFIIBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x699F260", Offset = "0x699DC60", VA = "0x18699F260")]
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
			[Cpp2IlInjected.Address(RVA = "0x452B930", Offset = "0x452A330", VA = "0x18452B930")]
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
		[Cpp2IlInjected.Address(RVA = "0x452D990", Offset = "0x452C390", VA = "0x18452D990")]
		public NNEHJLCMLJE(T[] MMHDMEIDHKC, FDFICELDDEL<T> NKKLGPMGJKA, int IBCNCEMAPNJ, Func<bool> APBONDMIJJD, T[]? CCJIHGKEAJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x452D410", Offset = "0x452BE10", VA = "0x18452D410")]
		public bool LIBMGPOAIEA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate U DMKGDBOFMED<T, U>(int ODHMBPBIJMP, int KDANPNNHCHB, [In] ReadOnlySpan<T> MIDEDCLHDIO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B6BD70", Offset = "0x2B6A770", VA = "0x182B6BD70")]
	public static T[] MJCIEJCNKFK<T>(int ECGAAJFODGN, T BIEFEFHDBDM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B330", Offset = "0x2B69D30", VA = "0x182B6B330")]
	public static void GGGODOGDJNE<T>(this T[] CALBLOGAHCA, T BIEFEFHDBDM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2B6AA20", Offset = "0x2B69420", VA = "0x182B6AA20")]
	public static void BCJNPAMEKAI<T>(this T[] PFKJAOOHGBN, int HCDMGOGKHKP, int DMFIBEKOIIG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B500", Offset = "0x2B69F00", VA = "0x182B6B500")]
	private static void JBEHINGHLPF<T>(this T[] HIKEOGPAJAF, int PKKDFCAFPBB, int NAPGOMFFGCF, T[] OKGBBGMIACH, int AHFGGCDEKAJ, int HFAKMJBCHCA, T[] ADPMAHMCGNH, int ALODEEIIDPL, FDFICELDDEL<T> NKKLGPMGJKA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B8B0", Offset = "0x2B6A2B0", VA = "0x182B6B8B0")]
	public static void JLKOILKHFMG<T>(this T[] HIKEOGPAJAF, int JHEGPJBDKAJ, int IHGHLPOONHD, FDFICELDDEL<T> NKKLGPMGJKA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2B6BCB0", Offset = "0x2B6A6B0", VA = "0x182B6BCB0")]
	public static NNEHJLCMLJE<T> LCEMPEIHBMC<T>(this T[] HIKEOGPAJAF, FDFICELDDEL<T> NKKLGPMGJKA, int IBCNCEMAPNJ, Func<bool> APBONDMIJJD, [Optional] T[]? CCJIHGKEAJJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C890", Offset = "0x2B6B290", VA = "0x182B6C890")]
	public static T[] PEDIBNMCFJO<T>(this T[] PFKJAOOHGBN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A830", Offset = "0x2B69230", VA = "0x182B6A830")]
	public static T[] ALKEHJEOAGA<T>(this T[] OKOAMOIIKKC, T IPGDLBDFACI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2B6BF10", Offset = "0x2B6A910", VA = "0x182B6BF10")]
	public static T[] NGNGEKIHAAC<T>(this T[] OKOAMOIIKKC, int DHNLEFJCEAH, T IPGDLBDFACI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C7E0", Offset = "0x2B6B1E0", VA = "0x182B6C7E0")]
	public static T[] OCMLDEJJKGE<T>(this T[] OKOAMOIIKKC, int DHNLEFJCEAH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B090", Offset = "0x2B69A90", VA = "0x182B6B090")]
	public static T[] FEFHGLLCPME<T>(this T[] OKOAMOIIKKC, int DHNLEFJCEAH, T IPGDLBDFACI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2B6AAA0", Offset = "0x2B694A0", VA = "0x182B6AAA0")]
	public static U[] FEFBAKEMNGC<U, T>(this T[] FDPJMKODKPJ, int IEILANLMBPK, DMKGDBOFMED<T, U> PEHPKDBILGB) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x699D7D0", Offset = "0x699C1D0", VA = "0x18699D7D0")]
	public static byte[] MBLJJGGIMHO(this byte[] HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x699D550", Offset = "0x699BF50", VA = "0x18699D550")]
	public static byte[] LLGPPEJEJHM(this byte[] HIKEOGPAJAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FBIOKBIMKBD
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x699D540", Offset = "0x699BF40", VA = "0x18699D540")]
	public static byte IIMKMKMGOJO(this bool HIKEOGPAJAF)
	{
		return default(byte);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NDBOCOOEMLI
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x699D540", Offset = "0x699BF40", VA = "0x18699D540")]
	public static bool OLOPNIJICGI(this byte HIKEOGPAJAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DFILBHIBMEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x29773C0", Offset = "0x2975DC0", VA = "0x1829773C0")]
	public static void IGBBLEHMHFF<T>(this ICollection<T> HIKEOGPAJAF, IEnumerable<T> NHEIBBJGGFH) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CGJHKCPGODI
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2939210", Offset = "0x2937C10", VA = "0x182939210")]
	public static void EFNHCCNLOOG<K, V>(this IDictionary<K, V> HIKEOGPAJAF, [In] K NDDCLPHCEEO, [In] V JMDCGOKJIDA, Func<V, V, V> MEECDKIOGGN) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2937E60", Offset = "0x2936860", VA = "0x182937E60")]
	public static void CNOGOJMHKLA<K, V>(this IDictionary<K, List<V>> HIKEOGPAJAF, [In] K NDDCLPHCEEO, [In] V JMDCGOKJIDA) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2938840", Offset = "0x2937240", VA = "0x182938840")]
	public static TVal DIKBKFOJHON<TVal, TKey>(this IDictionary<TKey, TVal> ENCKOMKBEOC, [In] TKey NDDCLPHCEEO, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] TVal LIAHLPBCKNO) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2938480", Offset = "0x2936E80", VA = "0x182938480")]
	public static TVal DIKBKFOJHON<TVal, TKey>(this IDictionary<TKey, TVal> ENCKOMKBEOC, [In] TKey NDDCLPHCEEO, Func<TVal> DCGAOGMNBFH) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x29398F0", Offset = "0x29382F0", VA = "0x1829398F0")]
	public static TValue GJPKPNDNNIC<TValue, TKey>(this IDictionary<TKey, TValue> ENCKOMKBEOC, [In] TKey NDDCLPHCEEO, [Optional][In][PEHALAEOKAF("`default!` and null-oblivious region shouldn't be necessary in C# 9")] TValue LIAHLPBCKNO)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x293A380", Offset = "0x2938D80", VA = "0x18293A380")]
	public static V MNGDKADHKGK<V, K>(this IDictionary<K, V> HIKEOGPAJAF, [In] K NDDCLPHCEEO) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x293A150", Offset = "0x2938B50", VA = "0x18293A150")]
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
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x40A4200", Offset = "0x40A2C00", VA = "0x1840A4200")]
		[PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) PPOBLJNPNFG(T PKMFOCDHIGE)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x40A41A0", Offset = "0x40A2BA0", VA = "0x1840A41A0")]
		[PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) NCKFNMLGMIE(IEnumerable<T> IBFCINICLHB)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class DHMNPHJALPH<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
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
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private IEnumerable<U> other;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public IEnumerable<U> <>3__other;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private T with;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public T <>3__with;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private IEnumerator<T> <selfEnumerator>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private IEnumerator<U> <otherEnumerator>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x89FD00", Offset = "0x89E700", VA = "0x18089FD00")]
		[DebuggerHidden]
		public DHMNPHJALPH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x574C1C0", Offset = "0x574ABC0", VA = "0x18574C1C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x574B7C0", Offset = "0x574A1C0", VA = "0x18574B7C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x574B240", Offset = "0x5749C40", VA = "0x18574B240")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x574B2F0", Offset = "0x5749CF0", VA = "0x18574B2F0")]
		private void KNPOGHPBEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x574C170", Offset = "0x574AB70", VA = "0x18574C170", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x574BFE0", Offset = "0x574A9E0", VA = "0x18574BFE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC930", Offset = "0x3ADB330", VA = "0x183ADC930", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class FMNPDJGPDAF<T> : IEnumerable<(T, PLBAMKEJCKB<T>)>, IEnumerable, IEnumerator<(T, PLBAMKEJCKB<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private (T Current, PLBAMKEJCKB<T> Next) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private IEnumerator<T> <enumerator>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private (T, PLBAMKEJCKB<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x385FA00", Offset = "0x385E400", VA = "0x18385FA00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, PLBAMKEJCKB<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x3BEBBE0", Offset = "0x3BEA5E0", VA = "0x183BEBBE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1E96420", Offset = "0x1E94E20", VA = "0x181E96420")]
		[DebuggerHidden]
		public FMNPDJGPDAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3988540", Offset = "0x3986F40", VA = "0x183988540", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3BEAE90", Offset = "0x3BE9890", VA = "0x183BEAE90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3BEA890", Offset = "0x3BE9290", VA = "0x183BEA890")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3BEBAF0", Offset = "0x3BEA4F0", VA = "0x183BEBAF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3BEB950", Offset = "0x3BEA350", VA = "0x183BEB950", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, PLBAMKEJCKB<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC930", Offset = "0x3ADB330", VA = "0x183ADC930", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class LEBOCJJLGMB<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private U <>2__current;

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
		private Func<JKHLBJIDAPH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Func<JKHLBJIDAPH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private IEnumerator<T> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IEnumerator<U> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		U IEnumerator<UnityEngine.SpookyHash.U>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (U)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x89FD00", Offset = "0x89E700", VA = "0x18089FD00")]
		[DebuggerHidden]
		public LEBOCJJLGMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x422C550", Offset = "0x422AF50", VA = "0x18422C550", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x422C080", Offset = "0x422AA80", VA = "0x18422C080", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x422BFE0", Offset = "0x422A9E0", VA = "0x18422BFE0")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x422C030", Offset = "0x422AA30", VA = "0x18422C030")]
		private void KNPOGHPBEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x422C500", Offset = "0x422AF00", VA = "0x18422C500", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF060", Offset = "0x3BFDA60", VA = "0x183BFF060", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7D90", Offset = "0x3BD6790", VA = "0x183BD7D90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DKNLEPFDLAM<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public DKNLEPFDLAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x576F810", Offset = "0x576E210", VA = "0x18576F810")]
		internal bool BBJKHLHBHAF(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x576F870", Offset = "0x576E270", VA = "0x18576F870")]
		internal bool CODEPPDONIC(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class INGAAPKDMJG<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private (T Lhs, U Rhs) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private IEnumerable<T> lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public IEnumerable<T> <>3__lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private IEnumerable<U> rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IEnumerable<U> <>3__rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IEnumerator<T> <lhsIt>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private IEnumerator<U> <rhsIt>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private (T, U) System.Collections.Generic.IEnumerator<(TLhs,URhs)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xC35880", Offset = "0xC34280", VA = "0x180C35880", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, U));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x3BF9DD0", Offset = "0x3BF87D0", VA = "0x183BF9DD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1E96420", Offset = "0x1E94E20", VA = "0x181E96420")]
		[DebuggerHidden]
		public INGAAPKDMJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0F60", Offset = "0x3ECF960", VA = "0x183ED0F60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1260", Offset = "0x3ECFC60", VA = "0x183ED1260", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1180", Offset = "0x3ECFB80", VA = "0x183ED1180", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC930", Offset = "0x3ADB330", VA = "0x183ADC930", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x299A1E0", Offset = "0x2998BE0", VA = "0x18299A1E0")]
	public static bool KKHLEEOKLGB<T, TArgs>(this IEnumerable<T> HIKEOGPAJAF, [In] TArgs FJCOFFFFCFE, PKCGECHPCAN<TArgs, T> FPMLEFBLCHO) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x699D190", Offset = "0x699BB90", VA = "0x18699D190")]
	public static bool KKHLEEOKLGB(this IEnumerable<bool> HIKEOGPAJAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2998A40", Offset = "0x2997440", VA = "0x182998A40")]
	public static U IJLMDDCAPNL<U, T>(this IEnumerable<T> HIKEOGPAJAF, Func<U> CONELMGFCGB, Func<T, U> PKMFOCDHIGE, Func<IEnumerable<T>, U> IBFCINICLHB) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2996AA0", Offset = "0x29954A0", VA = "0x182996AA0")]
	public static bool BJGLEBNPPFH<T, TArgs>(this IEnumerable<T> HIKEOGPAJAF, [In] TArgs FJCOFFFFCFE, PKCGECHPCAN<TArgs, T> FPMLEFBLCHO) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2997F30", Offset = "0x2996930", VA = "0x182997F30")]
	public static U FCAADEANJJD<U, T, TArg>(this IEnumerable<T> HIKEOGPAJAF, [In] TArg BGLHKLFFJEP, MKIAHMFHKAH<TArg, U> CONELMGFCGB, BCKAOIKJMGJ<TArg, T, U> PKMFOCDHIGE, GPGKOFBEHAE<TArg, T, U> IBFCINICLHB) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x299C000", Offset = "0x299AA00", VA = "0x18299C000")]
	public static IEnumerable<U> NAOHNHLGJKB<U, T, TArg>(this IEnumerable<T> HIKEOGPAJAF, [In] TArg BGLHKLFFJEP, MDDPMEIOOBK<TArg, T, U> GFJKGKFLLNA) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2925310", Offset = "0x2923D10", VA = "0x182925310")]
	public static IEnumerable<T> FALCGKHCMIC<T>(params IEnumerable<T>[] MMGLMOKPEMK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x29970A0", Offset = "0x2995AA0", VA = "0x1829970A0")]
	public static bool CGMJPCEONFC<T>(this IEnumerable<T> LDPKCIGIIMG, IEnumerable<T> OKGBBGMIACH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2925310", Offset = "0x2923D10", VA = "0x182925310")]
	public static IEnumerable<(TKey?, TValue?)>? CCKGOGEPIBB<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x299B560", Offset = "0x2999F60", VA = "0x18299B560")]
	public static IEnumerable<T> LKFMLDOOMJD<T, TKey>(this IEnumerable<T> HKKJHHAHAPB, Func<T, TKey> MKEKONBCKMJ) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x299D150", Offset = "0x299BB50", VA = "0x18299D150")]
	[IteratorStateMachine(typeof(DHMNPHJALPH<, >))]
	public static IEnumerable<T> OGCGMMDIBKF<T, U>(this IEnumerable<T> HIKEOGPAJAF, IEnumerable<U> OKGBBGMIACH, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] T BIEFEFHDBDM) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2837B10", Offset = "0x2836510", VA = "0x182837B10")]
	public static T CFKPAHBGIJG<T>(this IEnumerable<T> LDPKCIGIIMG, T LIAHLPBCKNO) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2997020", Offset = "0x2995A20", VA = "0x182997020")]
	public static T CFKPAHBGIJG<T>(this IEnumerable<T> LDPKCIGIIMG, T LIAHLPBCKNO, Func<T, bool> FPMLEFBLCHO) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x299C850", Offset = "0x299B250", VA = "0x18299C850")]
	public static T? NAPAMMOLDBK<T>(this IEnumerable<T> HIKEOGPAJAF, Func<T, bool> FPMLEFBLCHO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x299AB50", Offset = "0x2999550", VA = "0x18299AB50")]
	public static void LEBBJHKNBKL<T>(this IEnumerable<T> HIKEOGPAJAF, Action<T> MFIDPDMAIND) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2997760", Offset = "0x2996160", VA = "0x182997760")]
	[IteratorStateMachine(typeof(FMNPDJGPDAF<>))]
	public static IEnumerable<(T, PLBAMKEJCKB<T>)> EDPCDGMGKHD<T>(this IEnumerable<T> HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x29984C0", Offset = "0x2996EC0", VA = "0x1829984C0")]
	public static bool HJLHPLEIDIL<T>(this IEnumerable<T> HIKEOGPAJAF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2925310", Offset = "0x2923D10", VA = "0x182925310")]
	public static IEnumerable<DPKNNHGNADJ<T>> LINJEMEJAMF<T>(this IEnumerable<T> HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2996FE0", Offset = "0x29959E0", VA = "0x182996FE0")]
	public static bool CFHDDGLKNCC<T>(this IEnumerable<T> HIKEOGPAJAF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2997290", Offset = "0x2995C90", VA = "0x182997290")]
	public static IEnumerable<T> CKBHFIBMDAB<T>(this IEnumerable<T>? HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2997940", Offset = "0x2996340", VA = "0x182997940")]
	[IteratorStateMachine(typeof(LEBOCJJLGMB<, >))]
	public static IEnumerable<U> EOHLPAJKNEL<U, T>(this IEnumerable<T> HIKEOGPAJAF, Func<JKHLBJIDAPH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> EOADKOMMODL) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x29985F0", Offset = "0x2996FF0", VA = "0x1829985F0")]
	public static int HKJFCCOJFGI<T>(this IEnumerable<T> HIKEOGPAJAF, int FIBICGKNAKG = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2998CA0", Offset = "0x29976A0", VA = "0x182998CA0")]
	public static bool INAGFOMGOEG<T>(this IEnumerable<T> HIKEOGPAJAF, IEnumerable<T> OKGBBGMIACH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2997640", Offset = "0x2996040", VA = "0x182997640")]
	public static IEnumerable<T> DOGIKJLCHLF<T>(this IEnumerable<T> HIKEOGPAJAF, int MPIFCNGGGGI, int KONEOOFJOKB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2997310", Offset = "0x2995D10", VA = "0x182997310")]
	public static (IEnumerable<T>, IEnumerable<T>) DCNBBOAPDPK<T>(this IEnumerable<T> HIKEOGPAJAF, Func<T, bool> HOLGHJNBIKC) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x29991E0", Offset = "0x2997BE0", VA = "0x1829991E0")]
	public static string KBCEOFKOLKI<T>(this IEnumerable<T> HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x299A660", Offset = "0x2999060", VA = "0x18299A660")]
	public static Dictionary<TKey?, TValue?>? KPDFEFIEFPE<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> LDPKCIGIIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x299A660", Offset = "0x2999060", VA = "0x18299A660")]
	public static Dictionary<TKey?, TValue?>? KPDFEFIEFPE<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> LDPKCIGIIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2998F00", Offset = "0x2997900", VA = "0x182998F00")]
	public static List<T> IOPEBPIHFIF<T>(this IEnumerable<T> HIKEOGPAJAF, int HHGNDILCLEE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x29972D0", Offset = "0x2995CD0", VA = "0x1829972D0")]
	public static string CKNFMLLAHMG<T>(this IEnumerable<T> HIKEOGPAJAF, string HBDNCCCHBFK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x299B740", Offset = "0x299A140", VA = "0x18299B740")]
	public static (IReadOnlyList<T?>?, IReadOnlyList<U?>?) NAFHBBOOPKA<T, U>(this IEnumerable<(T Lhs, U Rhs)> HIKEOGPAJAF)
	{
		return default((IReadOnlyList<T>, IReadOnlyList<U>));
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2998410", Offset = "0x2996E10", VA = "0x182998410")]
	[IteratorStateMachine(typeof(INGAAPKDMJG<, >))]
	public static IEnumerable<(T, U)> FIMGFNCBOFM<T, U>(this IEnumerable<T> DIAAOCPNHKC, IEnumerable<U> LLLBDLGIMPP) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2999A00", Offset = "0x2998400", VA = "0x182999A00")]
	public static IEnumerable<V> KHIGECFLBJL<V, T, U>(this IEnumerable<T> HIKEOGPAJAF, IEnumerable<U> OKGBBGMIACH, Func<T, U, V> MOBJBCBCGHM, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] T JEHGEELJDFM, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] U FMDONOJEILG) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2999AD0", Offset = "0x29984D0", VA = "0x182999AD0")]
	public static IEnumerable<(T, U)> KHIGECFLBJL<T, U>(this IEnumerable<T> HIKEOGPAJAF, IEnumerable<U> OKGBBGMIACH, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] T JEHGEELJDFM, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] U FMDONOJEILG) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x29979F0", Offset = "0x29963F0", VA = "0x1829979F0")]
	public static TOut[] EPKCBAFHILN<TOut, TIn>(this IEnumerable<TIn> HKKJHHAHAPB, Func<TIn, TOut> NADEGDKPFJF) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class LMIAOEGDMNH
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2C0AA70", Offset = "0x2C09470", VA = "0x182C0AA70")]
	public static bool FJKIGFFOPFM<T, U>(this T HIKEOGPAJAF, [In] U MEAFIMADMKA) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2C0A8D0", Offset = "0x2C092D0", VA = "0x182C0A8D0")]
	public static bool AFJPHNJAOIP<T>(T HIKEOGPAJAF, T OKGBBGMIACH) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class NKLLLMGIMKG
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xB57E20", Offset = "0xB56820", VA = "0x180B57E20")]
	public static bool MFBKNDJBHNP([In] this float3 MLFGLJKBOIG, float3 GANEOONFJPD, float KOIGIPMKHNI = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class GPEJBEBOKCN
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class AKKLCJHDAEC<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private T self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public T <>3__self;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8C9DE0", Offset = "0x8C87E0", VA = "0x1808C9DE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x3AE9B50", Offset = "0x3AE8550", VA = "0x183AE9B50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA76790", Offset = "0xA75190", VA = "0x180A76790")]
		[DebuggerHidden]
		public AKKLCJHDAEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3C84790", Offset = "0x3C83190", VA = "0x183C84790", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3C84AE0", Offset = "0x3C834E0", VA = "0x183C84AE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3C84900", Offset = "0x3C83300", VA = "0x183C84900", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x38B6520", Offset = "0x38B4F20", VA = "0x1838B6520", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B36990", Offset = "0x2B35390", VA = "0x182B36990")]
	public static void MPFLDPJAJCN<T>(this T DOGPFNGIKMO, Action<T> EFKDKFPJEOC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B367B0", Offset = "0x2B351B0", VA = "0x182B367B0")]
	public static V LIOGJJDCAIE<V, T>(this T DOGPFNGIKMO, Func<T, V> EFKDKFPJEOC, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] V LIAHLPBCKNO) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2B36960", Offset = "0x2B35360", VA = "0x182B36960")]
	public static T? MNFBLOLFMCB<T>(this T HIKEOGPAJAF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2B369E0", Offset = "0x2B353E0", VA = "0x182B369E0")]
	[IteratorStateMachine(typeof(AKKLCJHDAEC<>))]
	public static IEnumerable<T> NNIAELNOGDE<T>(this T HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2B366F0", Offset = "0x2B350F0", VA = "0x182B366F0")]
	public static T[] BOOPCLMHOOH<T>(this T HIKEOGPAJAF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class HMFDMDIMNKF
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x699E220", Offset = "0x699CC20", VA = "0x18699E220")]
	private static byte[] BGMKJFHCEBH(int EOHIGKOGJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x699E2F0", Offset = "0x699CCF0", VA = "0x18699E2F0")]
	private static byte[] FEKCLCKLGJO(long GFMBFOEFLFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x699EBD0", Offset = "0x699D5D0", VA = "0x18699EBD0")]
	private static byte[] LMEMCDNMCCH(ulong GFMBFOEFLFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x699E370", Offset = "0x699CD70", VA = "0x18699E370")]
	public static Guid FGLKJEEINAI(params Guid[] DEMIACNOBKK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x699E6F0", Offset = "0x699D0F0", VA = "0x18699E6F0")]
	public static Guid JGIIBNEOBDO([In] Guid CEPMGOINFCI, int DHNLEFJCEAH, int DMDAEILPBHA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x699E4E0", Offset = "0x699CEE0", VA = "0x18699E4E0")]
	public static Guid JGIIBNEOBDO([In] Guid CEPMGOINFCI, long DHNLEFJCEAH, int DMDAEILPBHA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x699E620", Offset = "0x699D020", VA = "0x18699E620")]
	public static Guid JGIIBNEOBDO([In] Guid CEPMGOINFCI, ulong DHNLEFJCEAH, int DMDAEILPBHA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x699E5B0", Offset = "0x699CFB0", VA = "0x18699E5B0")]
	public static Guid JGIIBNEOBDO([In] Guid CEPMGOINFCI, [In] Guid EKLMECJNLFM, int DMDAEILPBHA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x699E7C0", Offset = "0x699D1C0", VA = "0x18699E7C0")]
	private static Guid JGIIBNEOBDO([In] Guid CEPMGOINFCI, byte[] MOGPIKMFOBM, int DMDAEILPBHA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x699EC50", Offset = "0x699D650", VA = "0x18699EC50")]
	private static void PAGHNLCKGJE(byte[] BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x699E2A0", Offset = "0x699CCA0", VA = "0x18699E2A0")]
	private static void CEAAOKLGLDM(byte[] BMIGIGGJPJD, int IIILBPDHGHN, int CLEBPGFBBGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class JPEPKPDNAIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x699ECF0", Offset = "0x699D6F0", VA = "0x18699ECF0")]
	public static int FDHMPNLEBLB(this int HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x699EE00", Offset = "0x699D800", VA = "0x18699EE00")]
	public static int IECDDPNDBFL(this int HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x699EE70", Offset = "0x699D870", VA = "0x18699EE70")]
	public static int OOIPPCEBAGH(this int HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x699EE60", Offset = "0x699D860", VA = "0x18699EE60")]
	public static int NPIJGHAJOCD(this int HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x59A9600", Offset = "0x59A8000", VA = "0x1859A9600")]
	public static int MOIBDHMHAOD(this int HIKEOGPAJAF, int IHGHLPOONHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5A7A180", Offset = "0x5A78B80", VA = "0x185A7A180")]
	public static int GPPIGGICPDA(this int HIKEOGPAJAF, int IHGHLPOONHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x699EDD0", Offset = "0x699D7D0", VA = "0x18699EDD0")]
	public static float HEIABDBKDFF(this int HIKEOGPAJAF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x699ED60", Offset = "0x699D760", VA = "0x18699ED60")]
	public static (byte, byte, byte, byte) GHHGACDFBJE(this int HIKEOGPAJAF)
	{
		return default((byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x699EE40", Offset = "0x699D840", VA = "0x18699EE40")]
	public static int NJOPHBHAJAO([In] this (byte Fourth, byte Third, byte Second, byte First) HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x699ECE0", Offset = "0x699D6E0", VA = "0x18699ECE0")]
	public static int CDGLJAHDMBE(this int HIKEOGPAJAF, int NJCKMOCNMLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x699EDF0", Offset = "0x699D7F0", VA = "0x18699EDF0")]
	public static int HJNKMMLMBEN(this int HIKEOGPAJAF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface IFEOFOPDGND
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NCDLNIPPHPH(int CLGCOGDJGGD, int JAHIDHODFOM);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float AJDEJPNKOAH(float AOIAEDIEBNE, float COFGILMBNIC);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface DGCOAPLMOMC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	long KKAEOACBFPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class GLCADIPEEEJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C5F0", Offset = "0x2B2AFF0", VA = "0x182B2C5F0")]
	public static (TKey?, TValue?) BOABPIFLJCL<TKey, TValue>([In] this KeyValuePair<TKey, TValue> HIKEOGPAJAF)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C6F0", Offset = "0x2B2B0F0", VA = "0x182B2C6F0")]
	public static KeyValuePair<TKey?, UValue?> FCHKAEGFAGB<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> HIKEOGPAJAF, UValue JMDCGOKJIDA)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class CDIPAFFIBDH
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class EOLGDPIJHFO<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public EOLGDPIJHFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3805D50", Offset = "0x3804750", VA = "0x183805D50")]
		internal TElement CHELHJKMNJG(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2929B90", Offset = "0x2928590", VA = "0x182929B90")]
	public static int JGHILGAHPFO<T>(this IReadOnlyList<T> PFKJAOOHGBN, T JMDCGOKJIDA) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2925950", Offset = "0x2924350", VA = "0x182925950")]
	public static int AKCGLOHGMEL<T>(this IReadOnlyList<T> PFKJAOOHGBN, T JMDCGOKJIDA) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2928450", Offset = "0x2926E50", VA = "0x182928450")]
	public static void IGBBLEHMHFF<T>(this HashSet<T> KEAGOEBAADJ, IEnumerable<T> NHEIBBJGGFH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x292DC00", Offset = "0x292C600", VA = "0x18292DC00")]
	public static void MHLIKHLBJMA<T>(this IList<T> CGIFJALMJMI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x292D8C0", Offset = "0x292C2C0", VA = "0x18292D8C0")]
	public static void MHLIKHLBJMA<T>(this IList<T> CGIFJALMJMI, int BLKFENOKNBK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2927FA0", Offset = "0x29269A0", VA = "0x182927FA0")]
	public static void HMFOCIHCEII<T>(this List<T> CGIFJALMJMI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2929580", Offset = "0x2927F80", VA = "0x182929580")]
	public static List<T> INPLDMDMPDD<T>(this List<T> HNFHFEEOANA, Predicate<T> JAIHDGBHBKO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x292A340", Offset = "0x2928D40", VA = "0x18292A340")]
	public static int JGHILGAHPFO<T>(this IReadOnlyList<T> CGIFJALMJMI, Predicate<T> FPMLEFBLCHO) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x29296F0", Offset = "0x29280F0", VA = "0x1829296F0")]
	public static bool JAIFAKFBDGH<T>(this IReadOnlyList<T> CGIFJALMJMI, Predicate<T> FPMLEFBLCHO, [Out][NotNullWhen(true)] List<int>? NADKEDPNJIG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2926370", Offset = "0x2924D70", VA = "0x182926370")]
	public static bool DJONJHALGBO<T>(this IReadOnlyList<T> CGIFJALMJMI, T JNHGHHKKNBB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x29263F0", Offset = "0x2924DF0", VA = "0x1829263F0")]
	public static bool DJONJHALGBO<T>(this IReadOnlyList<T> CGIFJALMJMI, T JNHGHHKKNBB, EqualityComparer<T> BPPCHPJNELP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x29275D0", Offset = "0x2925FD0", VA = "0x1829275D0")]
	public static int GPEMOONFGLC<TElement, TKey>(this IList<TElement> BBBNKNOHJJK, TKey CKABANFMPEC, Func<TElement, TKey> GOMMKLLBHPI, [Optional] Func<TKey, TKey, int>? NKKLGPMGJKA, int DHNLEFJCEAH = 0, [Optional] int? IHGHLPOONHD) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2926EB0", Offset = "0x29258B0", VA = "0x182926EB0")]
	public static int GPEMOONFGLC<TElement, TKey>(Func<int, TElement> JDHCINADAHL, int EMPLEBMINIM, TKey CKABANFMPEC, Func<TElement, TKey> GOMMKLLBHPI, [Optional] Func<TKey, TKey, int>? NKKLGPMGJKA, int DHNLEFJCEAH = 0, [Optional] int? IHGHLPOONHD) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x29267A0", Offset = "0x29251A0", VA = "0x1829267A0")]
	public static bool DOLJLPNFCJD<T>(this List<T> CGIFJALMJMI, T JNHGHHKKNBB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x292D4A0", Offset = "0x292BEA0", VA = "0x18292D4A0")]
	public static void MELMPBFMJHE<T>(this List<T> CGIFJALMJMI, IEnumerable<T> HNFHFEEOANA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x292D6D0", Offset = "0x292C0D0", VA = "0x18292D6D0")]
	public static void MFKDEBIIBOM<T>(this List<T> CGIFJALMJMI, IEnumerable<T> HNFHFEEOANA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x292A8E0", Offset = "0x29292E0", VA = "0x18292A8E0")]
	public static T JJDFLFNMFAN<T>(this List<T> HNFHFEEOANA, Predicate<T> JAIHDGBHBKO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2926C70", Offset = "0x2925670", VA = "0x182926C70")]
	public static T GAJGMHKEDPD<T>(this List<T> HNFHFEEOANA, int DHNLEFJCEAH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x292E060", Offset = "0x292CA60", VA = "0x18292E060")]
	public static void MNACKLLGDEF<T>(this List<T> CGIFJALMJMI, int DHNLEFJCEAH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x292D3C0", Offset = "0x292BDC0", VA = "0x18292D3C0")]
	public static bool LELMNEPJABL<T>(this List<T> DEGDMKBFAHB, List<T> MAAFMCBCEMG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x29269B0", Offset = "0x29253B0", VA = "0x1829269B0")]
	public static T EDHMEHIAPCG<T>(this IList<T> CGIFJALMJMI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2925B20", Offset = "0x2924520", VA = "0x182925B20")]
	public static bool DIFBCONAOBO<T>(IReadOnlyList<T>? CGIFJALMJMI, int DHNLEFJCEAH, [Out][MaybeNullWhen(false)][PEHALAEOKAF("This should be `T?` in C# 9.")] T ADPMAHMCGNH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x292C5D0", Offset = "0x292AFD0", VA = "0x18292C5D0")]
	public static bool KOBBLOOJGBO<T>(IReadOnlyList<T> CGIFJALMJMI, ICollection HNFHFEEOANA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2926550", Offset = "0x2924F50", VA = "0x182926550")]
	public static void DKMJAELAMAF<T>(IReadOnlyList<T> CGIFJALMJMI, ICollection HNFHFEEOANA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x292E360", Offset = "0x292CD60", VA = "0x18292E360")]
	public static bool PMFPICAICLC<T>(this IReadOnlyList<T> CGIFJALMJMI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2925790", Offset = "0x2924190", VA = "0x182925790")]
	public static string AHIOMJNHHKD<T>(this IEnumerable<T> CGIFJALMJMI, string PCOEHEFFIFO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x292ABF0", Offset = "0x29295F0", VA = "0x18292ABF0")]
	public static T KNGBBJIFKLI<T>(this IList<T> HIKEOGPAJAF) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2926B90", Offset = "0x2925590", VA = "0x182926B90")]
	public static T EOPINEMMCIA<T>(this IList<T> HIKEOGPAJAF) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x292D330", Offset = "0x292BD30", VA = "0x18292D330")]
	public static void LDCCHNFGFOA<T>(this IList<T> HIKEOGPAJAF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2926D10", Offset = "0x2925710", VA = "0x182926D10")]
	public static void GJGCHHNBGJO<T>(this IList<T> HIKEOGPAJAF, [In] T JMDCGOKJIDA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x292E260", Offset = "0x292CC60", VA = "0x18292E260")]
	public static T ODIHBLEHJMG<T>(this IList<T> HIKEOGPAJAF) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2927D20", Offset = "0x2926720", VA = "0x182927D20")]
	public static void HLBPNCGBDMN<T>(this List<T> HIKEOGPAJAF) where T : struct, IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HKIPMAJDKCI
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static float ENMDMJJIELJ;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static float DNILFNNPKBA;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static bool PHFDGBFGMID;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly float NHINBPCGKNC;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x699DC60", Offset = "0x699C660", VA = "0x18699DC60")]
	public static bool CGJBJNHIIFF(float MLFGLJKBOIG, float GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x699DF40", Offset = "0x699C940", VA = "0x18699DF40")]
	public static float KEJDGPCDCJO(float JMDCGOKJIDA, float ILMEANFNINA, float PLJHMOFCKBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x699DF20", Offset = "0x699C920", VA = "0x18699DF20")]
	public static int KEJDGPCDCJO(int JMDCGOKJIDA, int ILMEANFNINA, int PLJHMOFCKBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x699DE50", Offset = "0x699C850", VA = "0x18699DE50")]
	public static float GKOLJHKEOJF(float JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x699E020", Offset = "0x699CA20", VA = "0x18699E020")]
	public static float NGCNCLHNMFD(float MLFGLJKBOIG, float GANEOONFJPD, float DOGPFNGIKMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x699DE40", Offset = "0x699C840", VA = "0x18699DE40")]
	public static float GFIDGNBIGMG(float MLFGLJKBOIG, float GANEOONFJPD, float DOGPFNGIKMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x699DF60", Offset = "0x699C960", VA = "0x18699DF60")]
	public static float KGOKKLNOHFG(float MLFGLJKBOIG, float GANEOONFJPD, float JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x699DA60", Offset = "0x699C460", VA = "0x18699DA60")]
	public static float AIAHOEEJDNA(float MLFGLJKBOIG, float GANEOONFJPD, float JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x699DF00", Offset = "0x699C900", VA = "0x18699DF00")]
	public static float JEGNKKKIMIH(float MLFGLJKBOIG, float GANEOONFJPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x699DAA0", Offset = "0x699C4A0", VA = "0x18699DAA0")]
	public static float BBEBNHCKJOG(float HJGDDFBNENN, float CGKANMHMCOJ, float KBIDPPDGADG, float PMFJOEPDBGE, float ONOCCGOPHEL, float LDGBKFKPDEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x699DE70", Offset = "0x699C870", VA = "0x18699DE70")]
	public static float IDFMNKMOCOB(float JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x699DD50", Offset = "0x699C750", VA = "0x18699DD50")]
	public static float FAAJIBJKBPN(float JMDCGOKJIDA, float ILMEANFNINA, float PLJHMOFCKBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x699E0C0", Offset = "0x699CAC0", VA = "0x18699E0C0")]
	public static float PBLINCJGDCC(float HJPCBAPEOLF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class PNPOGLPEGCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private System.Random GKFOMEENHHJ;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x699F4C0", Offset = "0x699DEC0", VA = "0x18699F4C0")]
	public PNPOGLPEGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x699F550", Offset = "0x699DF50", VA = "0x18699F550")]
	public PNPOGLPEGCB(int BLKFENOKNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6114320", Offset = "0x6112D20", VA = "0x186114320", Slot = "4")]
	public virtual int NCDLNIPPHPH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x699F460", Offset = "0x699DE60", VA = "0x18699F460", Slot = "5")]
	public virtual int NCDLNIPPHPH(int JAHIDHODFOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x699CC00", Offset = "0x699B600", VA = "0x18699CC00", Slot = "6")]
	public virtual int NCDLNIPPHPH(int CLGCOGDJGGD, int JAHIDHODFOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x699F490", Offset = "0x699DE90", VA = "0x18699F490")]
	public double OLNHPAKJBDL()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class BEIMNDIIHCP
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x28BECC0", Offset = "0x28BD6C0", VA = "0x1828BECC0")]
	[EGHHEKDFLLK("This should be replaced with the `is not` operator in C# 9.")]
	public static bool LCBKPMFONAC<T>(this object HIKEOGPAJAF, [Out][NotNullWhen(true)] T ADPMAHMCGNH) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class CGLIAFCKGKL
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x699C9D0", Offset = "0x699B3D0", VA = "0x18699C9D0")]
	public static (float3, float3, float3) MCOBGCJNMFI([In] this quaternion HIKEOGPAJAF)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x699BD10", Offset = "0x699A710", VA = "0x18699BD10")]
	private static float3 BLPJDNIFDPC(quaternion FPAMJPKIJHC, math.RotationOrder EHNNGENIEKG = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x699CAC0", Offset = "0x699B4C0", VA = "0x18699CAC0")]
	private static float3 MPAJKMJLFLJ(float3 HEAKNKCAFIJ, math.RotationOrder EHNNGENIEKG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x699C7C0", Offset = "0x699B1C0", VA = "0x18699C7C0")]
	public static float3 FKDDBJGPLJP(this quaternion FPAMJPKIJHC, math.RotationOrder EHNNGENIEKG = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x699C880", Offset = "0x699B280", VA = "0x18699C880")]
	public static float LEJGAHMKINH(this quaternion DIAAOCPNHKC, quaternion LLLBDLGIMPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x699C730", Offset = "0x699B130", VA = "0x18699C730")]
	[CompilerGenerated]
	internal static float3 EHIHOPLDOOJ(float3 HEAKNKCAFIJ)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class DLKJGLEHONI
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class DDKFLOAIDPO : IFEOFOPDGND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly System.Random IEOMJLMICFG;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x699CC00", Offset = "0x699B600", VA = "0x18699CC00", Slot = "4")]
		public int NCDLNIPPHPH(int AOIAEDIEBNE, int AIACEMCFIDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x699CB90", Offset = "0x699B590", VA = "0x18699CB90", Slot = "5")]
		public float AJDEJPNKOAH(float AOIAEDIEBNE, float COFGILMBNIC)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x699CC30", Offset = "0x699B630", VA = "0x18699CC30")]
		private double OHJJHCNFBKP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x699CC70", Offset = "0x699B670", VA = "0x18699CC70")]
		public DDKFLOAIDPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly IFEOFOPDGND PIJNCOJONDM;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x699CCF0", Offset = "0x699B6F0", VA = "0x18699CCF0")]
	public static ulong MHOJAOPOLHK()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class PFIJDJMLACG
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2CC7660", Offset = "0x2CC6060", VA = "0x182CC7660")]
	public static bool HLJIJANFIGD<T>(this IReadOnlyCollection<T> HIKEOGPAJAF, int DHNLEFJCEAH) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class IICKKIPNECH
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2B83E10", Offset = "0x2B82810", VA = "0x182B83E10")]
	public static bool JKONKPFGDNM<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> HIKEOGPAJAF, IReadOnlyDictionary<TKey, TValue> OKGBBGMIACH) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class CEHKCOHDCLO
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2933780", Offset = "0x2932180", VA = "0x182933780")]
	public static TValue? JNHKPIOPLBC<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> HIKEOGPAJAF, TKey NDDCLPHCEEO) where TValue : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class ADKFOGDNBCF
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x699AA80", Offset = "0x6999480", VA = "0x18699AA80")]
	public static void APPOJKGPLJE(this IReadOnlyList<Action> HIKEOGPAJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x31CBCA0", Offset = "0x31CA6A0", VA = "0x1831CBCA0")]
	public static bool AKPHPFIGELN<T>(this IReadOnlyList<T> HIKEOGPAJAF, int DHNLEFJCEAH, [Out][NotNullWhen(true)][PEHALAEOKAF("This should be `T?` in C# 9.")] T ADPMAHMCGNH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x31CBBC0", Offset = "0x31CA5C0", VA = "0x1831CBBC0")]
	public static bool AGLPFCLAPCJ<T>(this IReadOnlyList<T> HIKEOGPAJAF, int DHNLEFJCEAH, [Out] DPKNNHGNADJ<T> ADPMAHMCGNH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x31CBEB0", Offset = "0x31CA8B0", VA = "0x1831CBEB0")]
	public static T PFDCILMKFFC<T>(this IReadOnlyList<T> HIKEOGPAJAF, int DHNLEFJCEAH, [In] T GFMHDPANGKF) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2C08980", Offset = "0x2C07380", VA = "0x182C08980")]
	[PEHALAEOKAF("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T HKHMHEOFKFK<T>(this IReadOnlyList<T> HIKEOGPAJAF, int DHNLEFJCEAH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x31CBDF0", Offset = "0x31CA7F0", VA = "0x1831CBDF0")]
	public static T? JNHKPIOPLBC<T>(this IReadOnlyList<T> HIKEOGPAJAF, int DHNLEFJCEAH) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class FALJLCJPCNG
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2B0C7D0", Offset = "0x2B0B1D0", VA = "0x182B0C7D0")]
	public static int IMLBDBIFEKB<T>([In] this ReadOnlySequence<T> BJMHIIGPDHE, [In] T JMDCGOKJIDA) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2B0CAB0", Offset = "0x2B0B4B0", VA = "0x182B0CAB0")]
	public static bool PKAAANLMMFG<T>([In] this ReadOnlySequence<T> BJMHIIGPDHE, [In] ReadOnlySpan<T> OKGBBGMIACH) where T : IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class AENPEJMEEON
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x31CD690", Offset = "0x31CC090", VA = "0x1831CD690")]
	public static string KBCEOFKOLKI<T>([In] this ReadOnlySpan<T> HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x31CC9F0", Offset = "0x31CB3F0", VA = "0x1831CC9F0")]
	public static string CKNFMLLAHMG<T>([In] this ReadOnlySpan<T> HIKEOGPAJAF, string HBDNCCCHBFK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class EOJILIFGCIN
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static DGCOAPLMOMC IDOIHFLMHJP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x699D370", Offset = "0x699BD70", VA = "0x18699D370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x699D3C0", Offset = "0x699BDC0", VA = "0x18699D3C0")]
	public static double HFMNCNMLOCD(this DGCOAPLMOMC HIKEOGPAJAF, long HHBDNCNCDOG)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class DOIECMEOPFJ : DGCOAPLMOMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly Stopwatch HCEBOJJHIBP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long KKAEOACBFPI
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x699D050", Offset = "0x699BA50", VA = "0x18699D050", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
	private DOIECMEOPFJ(Stopwatch FPCPJEPFGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x699D070", Offset = "0x699BA70", VA = "0x18699D070")]
	public static DOIECMEOPFJ GADLDLPFBEL(Stopwatch FPCPJEPFGDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x699D0E0", Offset = "0x699BAE0", VA = "0x18699D0E0")]
	public static DOIECMEOPFJ NKNDOJELBNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class BHDJNFMCIEP
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x699B540", Offset = "0x6999F40", VA = "0x18699B540")]
	public static float3 IPHKICBAECJ([In] this RigidTransform HIKEOGPAJAF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x699B670", Offset = "0x699A070", VA = "0x18699B670")]
	public static float3 KLDADDHEDFM([In] this RigidTransform HIKEOGPAJAF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x94A370", Offset = "0x948D70", VA = "0x18094A370")]
	public static (float3, float3, float3) JKICLEKIMIM([In] this RigidTransform HIKEOGPAJAF)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x699B7A0", Offset = "0x699A1A0", VA = "0x18699B7A0")]
	public static RigidTransform PBBOICIJGJH([In] this RigidTransform HIKEOGPAJAF)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class EBPGLKHDBEH
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x699D2B0", Offset = "0x699BCB0", VA = "0x18699D2B0")]
	public static RigidTransform DIPNPIPFKGK(RigidTransform EAJCNPPJMKJ, RigidTransform ILOHGCBACNL)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class PJNALCOBKFM
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x699F1A0", Offset = "0x699DBA0", VA = "0x18699F1A0")]
	public static float BCEMEHCIFHG([In] this (byte Fourth, byte Third, byte Second, byte First) HIKEOGPAJAF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x699F1E0", Offset = "0x699DBE0", VA = "0x18699F1E0")]
	public static int FANKENHGAAB(this float HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x699F1F0", Offset = "0x699DBF0", VA = "0x18699F1F0")]
	public static (byte, byte, byte, byte) GHHGACDFBJE(this float HIKEOGPAJAF)
	{
		return default((byte, byte, byte, byte));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class HJJJANGGGCJ
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2935880", Offset = "0x2934280", VA = "0x182935880")]
	public static ReadOnlySpan<T?> IGCPKIKCNFG<T>([In] this Span<T> HIKEOGPAJAF)
	{
		return default(ReadOnlySpan<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class BJDCGPPBOME
{
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static Regex EFDOLLMNNFJ;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static Regex ABADEMBICDB;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly char[] GFEEDFDNHJL;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5D422A0", Offset = "0x5D40CA0", VA = "0x185D422A0")]
	public static bool PMFPICAICLC(this string? JBNNPFLCMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x699B9E0", Offset = "0x699A3E0", VA = "0x18699B9E0")]
	public static string? OLAJANNCJJL(this string? HIKEOGPAJAF, int KBFGFPLLOGD, string DHLJFGHDBHB = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x699B930", Offset = "0x699A330", VA = "0x18699B930")]
	public static string KFDHGJNEAGJ(this string HIKEOGPAJAF, int KBFGFPLLOGD, string DHLJFGHDBHB = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x699B800", Offset = "0x699A200", VA = "0x18699B800")]
	public static int AJAEBJMABBF(this string JBNNPFLCMMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x699B870", Offset = "0x699A270", VA = "0x18699B870")]
	public static string KAKOJOPHCGK(this string JBNNPFLCMMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x699BAC0", Offset = "0x699A4C0", VA = "0x18699BAC0")]
	public static string[] PHJJOGMMNJN(this string JBNNPFLCMMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class CKMNNCJJICK<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public readonly struct FCAOODOBHEC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3B6DBA0", Offset = "0x3B6C5A0", VA = "0x183B6DBA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static int EIFHIBBFGCL;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static OGJOILKOKFE LAJJANPCBKM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long KKAEOACBFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x44DD990", Offset = "0x44DC390", VA = "0x1844DD990")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x51F0E90", Offset = "0x51EF890", VA = "0x1851F0E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x51F0F60", Offset = "0x51EF960", VA = "0x1851F0F60")]
	public static FCAOODOBHEC OFGECFEDLIK()
	{
		return default(FCAOODOBHEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x51F0D00", Offset = "0x51EF700", VA = "0x1851F0D00")]
	private static void GFNHEDKJGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x51F0EF0", Offset = "0x51EF8F0", VA = "0x1851F0EF0")]
	public static void MJPMKPPBJPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct OGJOILKOKFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly DGCOAPLMOMC HCEBOJJHIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly long IGFDBKGHGCE;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x699F130", Offset = "0x699DB30", VA = "0x18699F130")]
	public OGJOILKOKFE(DGCOAPLMOMC FPCPJEPFGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x699F0A0", Offset = "0x699DAA0", VA = "0x18699F0A0")]
	public long HJHOALHJOIG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x699F010", Offset = "0x699DA10", VA = "0x18699F010")]
	public double HFMNCNMLOCD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x699EF80", Offset = "0x699D980", VA = "0x18699EF80")]
	public double GONLFMOBKHF()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class NKEOBENGMDH
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x699EEC0", Offset = "0x699D8C0", VA = "0x18699EEC0")]
	public static bool NMFAJOENEIM(this Type HIKEOGPAJAF, Type OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2C94130", Offset = "0x2C92B30", VA = "0x182C94130")]
	public static bool NMFAJOENEIM<T>(this Type HIKEOGPAJAF) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class OANJLBINAIN
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x59A9600", Offset = "0x59A8000", VA = "0x1859A9600")]
	public static uint MOIBDHMHAOD(this uint HIKEOGPAJAF, int IHGHLPOONHD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5A7A180", Offset = "0x5A78B80", VA = "0x185A7A180")]
	public static uint GPPIGGICPDA(this uint HIKEOGPAJAF, int IHGHLPOONHD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x699EF70", Offset = "0x699D970", VA = "0x18699EF70")]
	public static uint GGLJGOOKPEN(this uint HIKEOGPAJAF, uint PDEKPELNLDP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x1035E40", Offset = "0x1034840", VA = "0x181035E40")]
	public static int FANKENHGAAB(this uint HIKEOGPAJAF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class CAMPEJJKAIE
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2924CD0", Offset = "0x29236D0", VA = "0x182924CD0")]
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
