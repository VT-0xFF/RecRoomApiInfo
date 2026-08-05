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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x699EDF0", Offset = "0x699D5F0", VA = "0x18699EDF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D9C0", Offset = "0x87C1C0", VA = "0x18087D9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87DA00", Offset = "0x87C200", VA = "0x18087DA00")]
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
	[Cpp2IlInjected.Address(RVA = "0x699AE20", Offset = "0x6999620", VA = "0x18699AE20")]
	public static bool LPHOGMLLJPL(string FBMPJIIJEEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x699AD50", Offset = "0x6999550", VA = "0x18699AD50")]
	private static bool CKKILMMFBKH(string JNNDBFGKHHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x699AC00", Offset = "0x6999400", VA = "0x18699AC00")]
	public static bool CKKILMMFBKH(Exception NKAKJFGNGPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x699AEF0", Offset = "0x69996F0", VA = "0x18699AEF0")]
	public static string NHCGBNEEJLG(string GMHAEBALLKB, string NNJFFKDDDDA = "", bool GFPCLPEDKGP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PNMMLLNLMJG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x699F2C0", Offset = "0x699DAC0", VA = "0x18699F2C0")]
	public static string KAIENAPFKHE(this Guid BMIGIGGJPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x699F220", Offset = "0x699DA20", VA = "0x18699F220")]
	public static string KAIENAPFKHE(this byte[] DDNKCFIIBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x699F160", Offset = "0x699D960", VA = "0x18699F160")]
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
			[Cpp2IlInjected.Address(RVA = "0x452B830", Offset = "0x452A030", VA = "0x18452B830")]
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
		[Cpp2IlInjected.Address(RVA = "0x452D890", Offset = "0x452C090", VA = "0x18452D890")]
		public NNEHJLCMLJE(T[] MMHDMEIDHKC, FDFICELDDEL<T> NKKLGPMGJKA, int IBCNCEMAPNJ, Func<bool> APBONDMIJJD, T[]? CCJIHGKEAJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x452D310", Offset = "0x452BB10", VA = "0x18452D310")]
		public bool LIBMGPOAIEA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate U DMKGDBOFMED<T, U>(int ODHMBPBIJMP, int KDANPNNHCHB, [In] ReadOnlySpan<T> MIDEDCLHDIO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B6BFF0", Offset = "0x2B6A7F0", VA = "0x182B6BFF0")]
	public static T[] MJCIEJCNKFK<T>(int ECGAAJFODGN, T BIEFEFHDBDM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B5B0", Offset = "0x2B69DB0", VA = "0x182B6B5B0")]
	public static void GGGODOGDJNE<T>(this T[] CALBLOGAHCA, T BIEFEFHDBDM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2B6ACA0", Offset = "0x2B694A0", VA = "0x182B6ACA0")]
	public static void BCJNPAMEKAI<T>(this T[] PFKJAOOHGBN, int HCDMGOGKHKP, int DMFIBEKOIIG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B780", Offset = "0x2B69F80", VA = "0x182B6B780")]
	private static void JBEHINGHLPF<T>(this T[] HIKEOGPAJAF, int PKKDFCAFPBB, int NAPGOMFFGCF, T[] OKGBBGMIACH, int AHFGGCDEKAJ, int HFAKMJBCHCA, T[] ADPMAHMCGNH, int ALODEEIIDPL, FDFICELDDEL<T> NKKLGPMGJKA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2B6BB30", Offset = "0x2B6A330", VA = "0x182B6BB30")]
	public static void JLKOILKHFMG<T>(this T[] HIKEOGPAJAF, int JHEGPJBDKAJ, int IHGHLPOONHD, FDFICELDDEL<T> NKKLGPMGJKA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2B6BF30", Offset = "0x2B6A730", VA = "0x182B6BF30")]
	public static NNEHJLCMLJE<T> LCEMPEIHBMC<T>(this T[] HIKEOGPAJAF, FDFICELDDEL<T> NKKLGPMGJKA, int IBCNCEMAPNJ, Func<bool> APBONDMIJJD, [Optional] T[]? CCJIHGKEAJJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CB10", Offset = "0x2B6B310", VA = "0x182B6CB10")]
	public static T[] PEDIBNMCFJO<T>(this T[] PFKJAOOHGBN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2B6AAB0", Offset = "0x2B692B0", VA = "0x182B6AAB0")]
	public static T[] ALKEHJEOAGA<T>(this T[] OKOAMOIIKKC, T IPGDLBDFACI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C190", Offset = "0x2B6A990", VA = "0x182B6C190")]
	public static T[] NGNGEKIHAAC<T>(this T[] OKOAMOIIKKC, int DHNLEFJCEAH, T IPGDLBDFACI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CA60", Offset = "0x2B6B260", VA = "0x182B6CA60")]
	public static T[] OCMLDEJJKGE<T>(this T[] OKOAMOIIKKC, int DHNLEFJCEAH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B310", Offset = "0x2B69B10", VA = "0x182B6B310")]
	public static T[] FEFHGLLCPME<T>(this T[] OKOAMOIIKKC, int DHNLEFJCEAH, T IPGDLBDFACI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2B6AD20", Offset = "0x2B69520", VA = "0x182B6AD20")]
	public static U[] FEFBAKEMNGC<U, T>(this T[] FDPJMKODKPJ, int IEILANLMBPK, DMKGDBOFMED<T, U> PEHPKDBILGB) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x699D6D0", Offset = "0x699BED0", VA = "0x18699D6D0")]
	public static byte[] MBLJJGGIMHO(this byte[] HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x699D450", Offset = "0x699BC50", VA = "0x18699D450")]
	public static byte[] LLGPPEJEJHM(this byte[] HIKEOGPAJAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FBIOKBIMKBD
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x699D440", Offset = "0x699BC40", VA = "0x18699D440")]
	public static byte IIMKMKMGOJO(this bool HIKEOGPAJAF)
	{
		return default(byte);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NDBOCOOEMLI
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x699D440", Offset = "0x699BC40", VA = "0x18699D440")]
	public static bool OLOPNIJICGI(this byte HIKEOGPAJAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DFILBHIBMEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x29776C0", Offset = "0x2975EC0", VA = "0x1829776C0")]
	public static void IGBBLEHMHFF<T>(this ICollection<T> HIKEOGPAJAF, IEnumerable<T> NHEIBBJGGFH) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CGJHKCPGODI
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2939510", Offset = "0x2937D10", VA = "0x182939510")]
	public static void EFNHCCNLOOG<K, V>(this IDictionary<K, V> HIKEOGPAJAF, [In] K NDDCLPHCEEO, [In] V JMDCGOKJIDA, Func<V, V, V> MEECDKIOGGN) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2938160", Offset = "0x2936960", VA = "0x182938160")]
	public static void CNOGOJMHKLA<K, V>(this IDictionary<K, List<V>> HIKEOGPAJAF, [In] K NDDCLPHCEEO, [In] V JMDCGOKJIDA) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2938B40", Offset = "0x2937340", VA = "0x182938B40")]
	public static TVal DIKBKFOJHON<TVal, TKey>(this IDictionary<TKey, TVal> ENCKOMKBEOC, [In] TKey NDDCLPHCEEO, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] TVal LIAHLPBCKNO) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2938780", Offset = "0x2936F80", VA = "0x182938780")]
	public static TVal DIKBKFOJHON<TVal, TKey>(this IDictionary<TKey, TVal> ENCKOMKBEOC, [In] TKey NDDCLPHCEEO, Func<TVal> DCGAOGMNBFH) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2939BF0", Offset = "0x29383F0", VA = "0x182939BF0")]
	public static TValue GJPKPNDNNIC<TValue, TKey>(this IDictionary<TKey, TValue> ENCKOMKBEOC, [In] TKey NDDCLPHCEEO, [Optional][In][PEHALAEOKAF("`default!` and null-oblivious region shouldn't be necessary in C# 9")] TValue LIAHLPBCKNO)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x293A680", Offset = "0x2938E80", VA = "0x18293A680")]
	public static V MNGDKADHKGK<V, K>(this IDictionary<K, V> HIKEOGPAJAF, [In] K NDDCLPHCEEO) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x293A450", Offset = "0x2938C50", VA = "0x18293A450")]
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
		[Cpp2IlInjected.Address(RVA = "0x40A4100", Offset = "0x40A2900", VA = "0x1840A4100")]
		[PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) PPOBLJNPNFG(T PKMFOCDHIGE)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x40A40A0", Offset = "0x40A28A0", VA = "0x1840A40A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x89FD00", Offset = "0x89E500", VA = "0x18089FD00")]
		[DebuggerHidden]
		public DHMNPHJALPH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x574C0C0", Offset = "0x574A8C0", VA = "0x18574C0C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x574B6C0", Offset = "0x5749EC0", VA = "0x18574B6C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x574B140", Offset = "0x5749940", VA = "0x18574B140")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x574B1F0", Offset = "0x57499F0", VA = "0x18574B1F0")]
		private void KNPOGHPBEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x574C070", Offset = "0x574A870", VA = "0x18574C070", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x574BEE0", Offset = "0x574A6E0", VA = "0x18574BEE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC830", Offset = "0x3ADB030", VA = "0x183ADC830", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x385F900", Offset = "0x385E100", VA = "0x18385F900", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BEBAE0", Offset = "0x3BEA2E0", VA = "0x183BEBAE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1E96420", Offset = "0x1E94C20", VA = "0x181E96420")]
		[DebuggerHidden]
		public FMNPDJGPDAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3988440", Offset = "0x3986C40", VA = "0x183988440", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3BEAD90", Offset = "0x3BE9590", VA = "0x183BEAD90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3BEA790", Offset = "0x3BE8F90", VA = "0x183BEA790")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3BEB9F0", Offset = "0x3BEA1F0", VA = "0x183BEB9F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3BEB850", Offset = "0x3BEA050", VA = "0x183BEB850", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, PLBAMKEJCKB<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC830", Offset = "0x3ADB030", VA = "0x183ADC830", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x89FD00", Offset = "0x89E500", VA = "0x18089FD00")]
		[DebuggerHidden]
		public LEBOCJJLGMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x422C450", Offset = "0x422AC50", VA = "0x18422C450", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x422BF80", Offset = "0x422A780", VA = "0x18422BF80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x422BEE0", Offset = "0x422A6E0", VA = "0x18422BEE0")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x422BF30", Offset = "0x422A730", VA = "0x18422BF30")]
		private void KNPOGHPBEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x422C400", Offset = "0x422AC00", VA = "0x18422C400", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3BFEF60", Offset = "0x3BFD760", VA = "0x183BFEF60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7C90", Offset = "0x3BD6490", VA = "0x183BD7C90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public DKNLEPFDLAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x576F710", Offset = "0x576DF10", VA = "0x18576F710")]
		internal bool BBJKHLHBHAF(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x576F770", Offset = "0x576DF70", VA = "0x18576F770")]
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
			[Cpp2IlInjected.Address(RVA = "0xC35880", Offset = "0xC34080", VA = "0x180C35880", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BF9CD0", Offset = "0x3BF84D0", VA = "0x183BF9CD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1E96420", Offset = "0x1E94C20", VA = "0x181E96420")]
		[DebuggerHidden]
		public INGAAPKDMJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0E60", Offset = "0x3ECF660", VA = "0x183ED0E60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1160", Offset = "0x3ECF960", VA = "0x183ED1160", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3ED1080", Offset = "0x3ECF880", VA = "0x183ED1080", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC830", Offset = "0x3ADB030", VA = "0x183ADC830", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x299A4E0", Offset = "0x2998CE0", VA = "0x18299A4E0")]
	public static bool KKHLEEOKLGB<T, TArgs>(this IEnumerable<T> HIKEOGPAJAF, [In] TArgs FJCOFFFFCFE, PKCGECHPCAN<TArgs, T> FPMLEFBLCHO) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x699D090", Offset = "0x699B890", VA = "0x18699D090")]
	public static bool KKHLEEOKLGB(this IEnumerable<bool> HIKEOGPAJAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2998D40", Offset = "0x2997540", VA = "0x182998D40")]
	public static U IJLMDDCAPNL<U, T>(this IEnumerable<T> HIKEOGPAJAF, Func<U> CONELMGFCGB, Func<T, U> PKMFOCDHIGE, Func<IEnumerable<T>, U> IBFCINICLHB) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2996DA0", Offset = "0x29955A0", VA = "0x182996DA0")]
	public static bool BJGLEBNPPFH<T, TArgs>(this IEnumerable<T> HIKEOGPAJAF, [In] TArgs FJCOFFFFCFE, PKCGECHPCAN<TArgs, T> FPMLEFBLCHO) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2998230", Offset = "0x2996A30", VA = "0x182998230")]
	public static U FCAADEANJJD<U, T, TArg>(this IEnumerable<T> HIKEOGPAJAF, [In] TArg BGLHKLFFJEP, MKIAHMFHKAH<TArg, U> CONELMGFCGB, BCKAOIKJMGJ<TArg, T, U> PKMFOCDHIGE, GPGKOFBEHAE<TArg, T, U> IBFCINICLHB) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x299C300", Offset = "0x299AB00", VA = "0x18299C300")]
	public static IEnumerable<U> NAOHNHLGJKB<U, T, TArg>(this IEnumerable<T> HIKEOGPAJAF, [In] TArg BGLHKLFFJEP, MDDPMEIOOBK<TArg, T, U> GFJKGKFLLNA) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2925610", Offset = "0x2923E10", VA = "0x182925610")]
	public static IEnumerable<T> FALCGKHCMIC<T>(params IEnumerable<T>[] MMGLMOKPEMK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x29973A0", Offset = "0x2995BA0", VA = "0x1829973A0")]
	public static bool CGMJPCEONFC<T>(this IEnumerable<T> LDPKCIGIIMG, IEnumerable<T> OKGBBGMIACH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2925610", Offset = "0x2923E10", VA = "0x182925610")]
	public static IEnumerable<(TKey?, TValue?)>? CCKGOGEPIBB<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> HIKEOGPAJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x299B860", Offset = "0x299A060", VA = "0x18299B860")]
	public static IEnumerable<T> LKFMLDOOMJD<T, TKey>(this IEnumerable<T> HKKJHHAHAPB, Func<T, TKey> MKEKONBCKMJ) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x299D450", Offset = "0x299BC50", VA = "0x18299D450")]
	[IteratorStateMachine(typeof(DHMNPHJALPH<, >))]
	public static IEnumerable<T> OGCGMMDIBKF<T, U>(this IEnumerable<T> HIKEOGPAJAF, IEnumerable<U> OKGBBGMIACH, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] T BIEFEFHDBDM) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2837F10", Offset = "0x2836710", VA = "0x182837F10")]
	public static T CFKPAHBGIJG<T>(this IEnumerable<T> LDPKCIGIIMG, T LIAHLPBCKNO) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2997320", Offset = "0x2995B20", VA = "0x182997320")]
	public static T CFKPAHBGIJG<T>(this IEnumerable<T> LDPKCIGIIMG, T LIAHLPBCKNO, Func<T, bool> FPMLEFBLCHO) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x299CB50", Offset = "0x299B350", VA = "0x18299CB50")]
	public static T? NAPAMMOLDBK<T>(this IEnumerable<T> HIKEOGPAJAF, Func<T, bool> FPMLEFBLCHO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x299AE50", Offset = "0x2999650", VA = "0x18299AE50")]
	public static void LEBBJHKNBKL<T>(this IEnumerable<T> HIKEOGPAJAF, Action<T> MFIDPDMAIND) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2997A60", Offset = "0x2996260", VA = "0x182997A60")]
	[IteratorStateMachine(typeof(FMNPDJGPDAF<>))]
	public static IEnumerable<(T, PLBAMKEJCKB<T>)> EDPCDGMGKHD<T>(this IEnumerable<T> HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x29987C0", Offset = "0x2996FC0", VA = "0x1829987C0")]
	public static bool HJLHPLEIDIL<T>(this IEnumerable<T> HIKEOGPAJAF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2925610", Offset = "0x2923E10", VA = "0x182925610")]
	public static IEnumerable<DPKNNHGNADJ<T>> LINJEMEJAMF<T>(this IEnumerable<T> HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x29972E0", Offset = "0x2995AE0", VA = "0x1829972E0")]
	public static bool CFHDDGLKNCC<T>(this IEnumerable<T> HIKEOGPAJAF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2997590", Offset = "0x2995D90", VA = "0x182997590")]
	public static IEnumerable<T> CKBHFIBMDAB<T>(this IEnumerable<T>? HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2997C40", Offset = "0x2996440", VA = "0x182997C40")]
	[IteratorStateMachine(typeof(LEBOCJJLGMB<, >))]
	public static IEnumerable<U> EOHLPAJKNEL<U, T>(this IEnumerable<T> HIKEOGPAJAF, Func<JKHLBJIDAPH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> EOADKOMMODL) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x29988F0", Offset = "0x29970F0", VA = "0x1829988F0")]
	public static int HKJFCCOJFGI<T>(this IEnumerable<T> HIKEOGPAJAF, int FIBICGKNAKG = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2998FA0", Offset = "0x29977A0", VA = "0x182998FA0")]
	public static bool INAGFOMGOEG<T>(this IEnumerable<T> HIKEOGPAJAF, IEnumerable<T> OKGBBGMIACH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2997940", Offset = "0x2996140", VA = "0x182997940")]
	public static IEnumerable<T> DOGIKJLCHLF<T>(this IEnumerable<T> HIKEOGPAJAF, int MPIFCNGGGGI, int KONEOOFJOKB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2997610", Offset = "0x2995E10", VA = "0x182997610")]
	public static (IEnumerable<T>, IEnumerable<T>) DCNBBOAPDPK<T>(this IEnumerable<T> HIKEOGPAJAF, Func<T, bool> HOLGHJNBIKC) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x29994E0", Offset = "0x2997CE0", VA = "0x1829994E0")]
	public static string KBCEOFKOLKI<T>(this IEnumerable<T> HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x299A960", Offset = "0x2999160", VA = "0x18299A960")]
	public static Dictionary<TKey?, TValue?>? KPDFEFIEFPE<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> LDPKCIGIIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x299A960", Offset = "0x2999160", VA = "0x18299A960")]
	public static Dictionary<TKey?, TValue?>? KPDFEFIEFPE<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> LDPKCIGIIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2999200", Offset = "0x2997A00", VA = "0x182999200")]
	public static List<T> IOPEBPIHFIF<T>(this IEnumerable<T> HIKEOGPAJAF, int HHGNDILCLEE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x29975D0", Offset = "0x2995DD0", VA = "0x1829975D0")]
	public static string CKNFMLLAHMG<T>(this IEnumerable<T> HIKEOGPAJAF, string HBDNCCCHBFK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x299BA40", Offset = "0x299A240", VA = "0x18299BA40")]
	public static (IReadOnlyList<T?>?, IReadOnlyList<U?>?) NAFHBBOOPKA<T, U>(this IEnumerable<(T Lhs, U Rhs)> HIKEOGPAJAF)
	{
		return default((IReadOnlyList<T>, IReadOnlyList<U>));
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2998710", Offset = "0x2996F10", VA = "0x182998710")]
	[IteratorStateMachine(typeof(INGAAPKDMJG<, >))]
	public static IEnumerable<(T, U)> FIMGFNCBOFM<T, U>(this IEnumerable<T> DIAAOCPNHKC, IEnumerable<U> LLLBDLGIMPP) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2999D00", Offset = "0x2998500", VA = "0x182999D00")]
	public static IEnumerable<V> KHIGECFLBJL<V, T, U>(this IEnumerable<T> HIKEOGPAJAF, IEnumerable<U> OKGBBGMIACH, Func<T, U, V> MOBJBCBCGHM, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] T JEHGEELJDFM, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] U FMDONOJEILG) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2999DD0", Offset = "0x29985D0", VA = "0x182999DD0")]
	public static IEnumerable<(T, U)> KHIGECFLBJL<T, U>(this IEnumerable<T> HIKEOGPAJAF, IEnumerable<U> OKGBBGMIACH, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] T JEHGEELJDFM, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] U FMDONOJEILG) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2997CF0", Offset = "0x29964F0", VA = "0x182997CF0")]
	public static TOut[] EPKCBAFHILN<TOut, TIn>(this IEnumerable<TIn> HKKJHHAHAPB, Func<TIn, TOut> NADEGDKPFJF) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class LMIAOEGDMNH
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2C0A970", Offset = "0x2C09170", VA = "0x182C0A970")]
	public static bool FJKIGFFOPFM<T, U>(this T HIKEOGPAJAF, [In] U MEAFIMADMKA) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2C0A7D0", Offset = "0x2C08FD0", VA = "0x182C0A7D0")]
	public static bool AFJPHNJAOIP<T>(T HIKEOGPAJAF, T OKGBBGMIACH) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class NKLLLMGIMKG
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xB57E20", Offset = "0xB56620", VA = "0x180B57E20")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C9DE0", Offset = "0x8C85E0", VA = "0x1808C9DE0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AE9A50", Offset = "0x3AE8250", VA = "0x183AE9A50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA76790", Offset = "0xA74F90", VA = "0x180A76790")]
		[DebuggerHidden]
		public AKKLCJHDAEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3C84690", Offset = "0x3C82E90", VA = "0x183C84690", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3C849E0", Offset = "0x3C831E0", VA = "0x183C849E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3C84800", Offset = "0x3C83000", VA = "0x183C84800", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x38B6420", Offset = "0x38B4C20", VA = "0x1838B6420", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B36C10", Offset = "0x2B35410", VA = "0x182B36C10")]
	public static void MPFLDPJAJCN<T>(this T DOGPFNGIKMO, Action<T> EFKDKFPJEOC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B36A30", Offset = "0x2B35230", VA = "0x182B36A30")]
	public static V LIOGJJDCAIE<V, T>(this T DOGPFNGIKMO, Func<T, V> EFKDKFPJEOC, [Optional][PEHALAEOKAF("`default!` shouldn't be necessary in C# 9")] V LIAHLPBCKNO) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2B36BE0", Offset = "0x2B353E0", VA = "0x182B36BE0")]
	public static T? MNFBLOLFMCB<T>(this T HIKEOGPAJAF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2B36C60", Offset = "0x2B35460", VA = "0x182B36C60")]
	[IteratorStateMachine(typeof(AKKLCJHDAEC<>))]
	public static IEnumerable<T> NNIAELNOGDE<T>(this T HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2B36970", Offset = "0x2B35170", VA = "0x182B36970")]
	public static T[] BOOPCLMHOOH<T>(this T HIKEOGPAJAF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class HMFDMDIMNKF
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x699E120", Offset = "0x699C920", VA = "0x18699E120")]
	private static byte[] BGMKJFHCEBH(int EOHIGKOGJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x699E1F0", Offset = "0x699C9F0", VA = "0x18699E1F0")]
	private static byte[] FEKCLCKLGJO(long GFMBFOEFLFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x699EAD0", Offset = "0x699D2D0", VA = "0x18699EAD0")]
	private static byte[] LMEMCDNMCCH(ulong GFMBFOEFLFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x699E270", Offset = "0x699CA70", VA = "0x18699E270")]
	public static Guid FGLKJEEINAI(params Guid[] DEMIACNOBKK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x699E5F0", Offset = "0x699CDF0", VA = "0x18699E5F0")]
	public static Guid JGIIBNEOBDO([In] Guid CEPMGOINFCI, int DHNLEFJCEAH, int DMDAEILPBHA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x699E3E0", Offset = "0x699CBE0", VA = "0x18699E3E0")]
	public static Guid JGIIBNEOBDO([In] Guid CEPMGOINFCI, long DHNLEFJCEAH, int DMDAEILPBHA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x699E520", Offset = "0x699CD20", VA = "0x18699E520")]
	public static Guid JGIIBNEOBDO([In] Guid CEPMGOINFCI, ulong DHNLEFJCEAH, int DMDAEILPBHA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x699E4B0", Offset = "0x699CCB0", VA = "0x18699E4B0")]
	public static Guid JGIIBNEOBDO([In] Guid CEPMGOINFCI, [In] Guid EKLMECJNLFM, int DMDAEILPBHA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x699E6C0", Offset = "0x699CEC0", VA = "0x18699E6C0")]
	private static Guid JGIIBNEOBDO([In] Guid CEPMGOINFCI, byte[] MOGPIKMFOBM, int DMDAEILPBHA = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x699EB50", Offset = "0x699D350", VA = "0x18699EB50")]
	private static void PAGHNLCKGJE(byte[] BMIGIGGJPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x699E1A0", Offset = "0x699C9A0", VA = "0x18699E1A0")]
	private static void CEAAOKLGLDM(byte[] BMIGIGGJPJD, int IIILBPDHGHN, int CLEBPGFBBGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class JPEPKPDNAIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x699EBF0", Offset = "0x699D3F0", VA = "0x18699EBF0")]
	public static int FDHMPNLEBLB(this int HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x699ED00", Offset = "0x699D500", VA = "0x18699ED00")]
	public static int IECDDPNDBFL(this int HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x699ED70", Offset = "0x699D570", VA = "0x18699ED70")]
	public static int OOIPPCEBAGH(this int HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x699ED60", Offset = "0x699D560", VA = "0x18699ED60")]
	public static int NPIJGHAJOCD(this int HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x59A9500", Offset = "0x59A7D00", VA = "0x1859A9500")]
	public static int MOIBDHMHAOD(this int HIKEOGPAJAF, int IHGHLPOONHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5A7A080", Offset = "0x5A78880", VA = "0x185A7A080")]
	public static int GPPIGGICPDA(this int HIKEOGPAJAF, int IHGHLPOONHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x699ECD0", Offset = "0x699D4D0", VA = "0x18699ECD0")]
	public static float HEIABDBKDFF(this int HIKEOGPAJAF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x699EC60", Offset = "0x699D460", VA = "0x18699EC60")]
	public static (byte, byte, byte, byte) GHHGACDFBJE(this int HIKEOGPAJAF)
	{
		return default((byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x699ED40", Offset = "0x699D540", VA = "0x18699ED40")]
	public static int NJOPHBHAJAO([In] this (byte Fourth, byte Third, byte Second, byte First) HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x699EBE0", Offset = "0x699D3E0", VA = "0x18699EBE0")]
	public static int CDGLJAHDMBE(this int HIKEOGPAJAF, int NJCKMOCNMLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x699ECF0", Offset = "0x699D4F0", VA = "0x18699ECF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B2C870", Offset = "0x2B2B070", VA = "0x182B2C870")]
	public static (TKey?, TValue?) BOABPIFLJCL<TKey, TValue>([In] this KeyValuePair<TKey, TValue> HIKEOGPAJAF)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C970", Offset = "0x2B2B170", VA = "0x182B2C970")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public EOLGDPIJHFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3805C50", Offset = "0x3804450", VA = "0x183805C50")]
		internal TElement CHELHJKMNJG(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2929E90", Offset = "0x2928690", VA = "0x182929E90")]
	public static int JGHILGAHPFO<T>(this IReadOnlyList<T> PFKJAOOHGBN, T JMDCGOKJIDA) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2925C50", Offset = "0x2924450", VA = "0x182925C50")]
	public static int AKCGLOHGMEL<T>(this IReadOnlyList<T> PFKJAOOHGBN, T JMDCGOKJIDA) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2928750", Offset = "0x2926F50", VA = "0x182928750")]
	public static void IGBBLEHMHFF<T>(this HashSet<T> KEAGOEBAADJ, IEnumerable<T> NHEIBBJGGFH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x292DF00", Offset = "0x292C700", VA = "0x18292DF00")]
	public static void MHLIKHLBJMA<T>(this IList<T> CGIFJALMJMI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x292DBC0", Offset = "0x292C3C0", VA = "0x18292DBC0")]
	public static void MHLIKHLBJMA<T>(this IList<T> CGIFJALMJMI, int BLKFENOKNBK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x29282A0", Offset = "0x2926AA0", VA = "0x1829282A0")]
	public static void HMFOCIHCEII<T>(this List<T> CGIFJALMJMI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2929880", Offset = "0x2928080", VA = "0x182929880")]
	public static List<T> INPLDMDMPDD<T>(this List<T> HNFHFEEOANA, Predicate<T> JAIHDGBHBKO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x292A640", Offset = "0x2928E40", VA = "0x18292A640")]
	public static int JGHILGAHPFO<T>(this IReadOnlyList<T> CGIFJALMJMI, Predicate<T> FPMLEFBLCHO) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x29299F0", Offset = "0x29281F0", VA = "0x1829299F0")]
	public static bool JAIFAKFBDGH<T>(this IReadOnlyList<T> CGIFJALMJMI, Predicate<T> FPMLEFBLCHO, [Out][NotNullWhen(true)] List<int>? NADKEDPNJIG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2926670", Offset = "0x2924E70", VA = "0x182926670")]
	public static bool DJONJHALGBO<T>(this IReadOnlyList<T> CGIFJALMJMI, T JNHGHHKKNBB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x29266F0", Offset = "0x2924EF0", VA = "0x1829266F0")]
	public static bool DJONJHALGBO<T>(this IReadOnlyList<T> CGIFJALMJMI, T JNHGHHKKNBB, EqualityComparer<T> BPPCHPJNELP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x29278D0", Offset = "0x29260D0", VA = "0x1829278D0")]
	public static int GPEMOONFGLC<TElement, TKey>(this IList<TElement> BBBNKNOHJJK, TKey CKABANFMPEC, Func<TElement, TKey> GOMMKLLBHPI, [Optional] Func<TKey, TKey, int>? NKKLGPMGJKA, int DHNLEFJCEAH = 0, [Optional] int? IHGHLPOONHD) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x29271B0", Offset = "0x29259B0", VA = "0x1829271B0")]
	public static int GPEMOONFGLC<TElement, TKey>(Func<int, TElement> JDHCINADAHL, int EMPLEBMINIM, TKey CKABANFMPEC, Func<TElement, TKey> GOMMKLLBHPI, [Optional] Func<TKey, TKey, int>? NKKLGPMGJKA, int DHNLEFJCEAH = 0, [Optional] int? IHGHLPOONHD) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2926AA0", Offset = "0x29252A0", VA = "0x182926AA0")]
	public static bool DOLJLPNFCJD<T>(this List<T> CGIFJALMJMI, T JNHGHHKKNBB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x292D7A0", Offset = "0x292BFA0", VA = "0x18292D7A0")]
	public static void MELMPBFMJHE<T>(this List<T> CGIFJALMJMI, IEnumerable<T> HNFHFEEOANA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x292D9D0", Offset = "0x292C1D0", VA = "0x18292D9D0")]
	public static void MFKDEBIIBOM<T>(this List<T> CGIFJALMJMI, IEnumerable<T> HNFHFEEOANA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x292ABE0", Offset = "0x29293E0", VA = "0x18292ABE0")]
	public static T JJDFLFNMFAN<T>(this List<T> HNFHFEEOANA, Predicate<T> JAIHDGBHBKO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2926F70", Offset = "0x2925770", VA = "0x182926F70")]
	public static T GAJGMHKEDPD<T>(this List<T> HNFHFEEOANA, int DHNLEFJCEAH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x292E360", Offset = "0x292CB60", VA = "0x18292E360")]
	public static void MNACKLLGDEF<T>(this List<T> CGIFJALMJMI, int DHNLEFJCEAH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x292D6C0", Offset = "0x292BEC0", VA = "0x18292D6C0")]
	public static bool LELMNEPJABL<T>(this List<T> DEGDMKBFAHB, List<T> MAAFMCBCEMG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2926CB0", Offset = "0x29254B0", VA = "0x182926CB0")]
	public static T EDHMEHIAPCG<T>(this IList<T> CGIFJALMJMI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2925E20", Offset = "0x2924620", VA = "0x182925E20")]
	public static bool DIFBCONAOBO<T>(IReadOnlyList<T>? CGIFJALMJMI, int DHNLEFJCEAH, [Out][MaybeNullWhen(false)][PEHALAEOKAF("This should be `T?` in C# 9.")] T ADPMAHMCGNH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x292C8D0", Offset = "0x292B0D0", VA = "0x18292C8D0")]
	public static bool KOBBLOOJGBO<T>(IReadOnlyList<T> CGIFJALMJMI, ICollection HNFHFEEOANA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2926850", Offset = "0x2925050", VA = "0x182926850")]
	public static void DKMJAELAMAF<T>(IReadOnlyList<T> CGIFJALMJMI, ICollection HNFHFEEOANA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x292E660", Offset = "0x292CE60", VA = "0x18292E660")]
	public static bool PMFPICAICLC<T>(this IReadOnlyList<T> CGIFJALMJMI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2925A90", Offset = "0x2924290", VA = "0x182925A90")]
	public static string AHIOMJNHHKD<T>(this IEnumerable<T> CGIFJALMJMI, string PCOEHEFFIFO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x292AEF0", Offset = "0x29296F0", VA = "0x18292AEF0")]
	public static T KNGBBJIFKLI<T>(this IList<T> HIKEOGPAJAF) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2926E90", Offset = "0x2925690", VA = "0x182926E90")]
	public static T EOPINEMMCIA<T>(this IList<T> HIKEOGPAJAF) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x292D630", Offset = "0x292BE30", VA = "0x18292D630")]
	public static void LDCCHNFGFOA<T>(this IList<T> HIKEOGPAJAF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2927010", Offset = "0x2925810", VA = "0x182927010")]
	public static void GJGCHHNBGJO<T>(this IList<T> HIKEOGPAJAF, [In] T JMDCGOKJIDA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x292E560", Offset = "0x292CD60", VA = "0x18292E560")]
	public static T ODIHBLEHJMG<T>(this IList<T> HIKEOGPAJAF) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2928020", Offset = "0x2926820", VA = "0x182928020")]
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
	[Cpp2IlInjected.Address(RVA = "0x699DB60", Offset = "0x699C360", VA = "0x18699DB60")]
	public static bool CGJBJNHIIFF(float MLFGLJKBOIG, float GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x699DE40", Offset = "0x699C640", VA = "0x18699DE40")]
	public static float KEJDGPCDCJO(float JMDCGOKJIDA, float ILMEANFNINA, float PLJHMOFCKBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x699DE20", Offset = "0x699C620", VA = "0x18699DE20")]
	public static int KEJDGPCDCJO(int JMDCGOKJIDA, int ILMEANFNINA, int PLJHMOFCKBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x699DD50", Offset = "0x699C550", VA = "0x18699DD50")]
	public static float GKOLJHKEOJF(float JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x699DF20", Offset = "0x699C720", VA = "0x18699DF20")]
	public static float NGCNCLHNMFD(float MLFGLJKBOIG, float GANEOONFJPD, float DOGPFNGIKMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x699DD40", Offset = "0x699C540", VA = "0x18699DD40")]
	public static float GFIDGNBIGMG(float MLFGLJKBOIG, float GANEOONFJPD, float DOGPFNGIKMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x699DE60", Offset = "0x699C660", VA = "0x18699DE60")]
	public static float KGOKKLNOHFG(float MLFGLJKBOIG, float GANEOONFJPD, float JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x699D960", Offset = "0x699C160", VA = "0x18699D960")]
	public static float AIAHOEEJDNA(float MLFGLJKBOIG, float GANEOONFJPD, float JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x699DE00", Offset = "0x699C600", VA = "0x18699DE00")]
	public static float JEGNKKKIMIH(float MLFGLJKBOIG, float GANEOONFJPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x699D9A0", Offset = "0x699C1A0", VA = "0x18699D9A0")]
	public static float BBEBNHCKJOG(float HJGDDFBNENN, float CGKANMHMCOJ, float KBIDPPDGADG, float PMFJOEPDBGE, float ONOCCGOPHEL, float LDGBKFKPDEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x699DD70", Offset = "0x699C570", VA = "0x18699DD70")]
	public static float IDFMNKMOCOB(float JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x699DC50", Offset = "0x699C450", VA = "0x18699DC50")]
	public static float FAAJIBJKBPN(float JMDCGOKJIDA, float ILMEANFNINA, float PLJHMOFCKBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x699DFC0", Offset = "0x699C7C0", VA = "0x18699DFC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x699F3C0", Offset = "0x699DBC0", VA = "0x18699F3C0")]
	public PNPOGLPEGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x699F450", Offset = "0x699DC50", VA = "0x18699F450")]
	public PNPOGLPEGCB(int BLKFENOKNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6114220", Offset = "0x6112A20", VA = "0x186114220", Slot = "4")]
	public virtual int NCDLNIPPHPH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x699F360", Offset = "0x699DB60", VA = "0x18699F360", Slot = "5")]
	public virtual int NCDLNIPPHPH(int JAHIDHODFOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x699CB00", Offset = "0x699B300", VA = "0x18699CB00", Slot = "6")]
	public virtual int NCDLNIPPHPH(int CLGCOGDJGGD, int JAHIDHODFOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x699F390", Offset = "0x699DB90", VA = "0x18699F390")]
	public double OLNHPAKJBDL()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class BEIMNDIIHCP
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x28BEFC0", Offset = "0x28BD7C0", VA = "0x1828BEFC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x699C8D0", Offset = "0x699B0D0", VA = "0x18699C8D0")]
	public static (float3, float3, float3) MCOBGCJNMFI([In] this quaternion HIKEOGPAJAF)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x699BC10", Offset = "0x699A410", VA = "0x18699BC10")]
	private static float3 BLPJDNIFDPC(quaternion FPAMJPKIJHC, math.RotationOrder EHNNGENIEKG = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x699C9C0", Offset = "0x699B1C0", VA = "0x18699C9C0")]
	private static float3 MPAJKMJLFLJ(float3 HEAKNKCAFIJ, math.RotationOrder EHNNGENIEKG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x699C6C0", Offset = "0x699AEC0", VA = "0x18699C6C0")]
	public static float3 FKDDBJGPLJP(this quaternion FPAMJPKIJHC, math.RotationOrder EHNNGENIEKG = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x699C780", Offset = "0x699AF80", VA = "0x18699C780")]
	public static float LEJGAHMKINH(this quaternion DIAAOCPNHKC, quaternion LLLBDLGIMPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x699C630", Offset = "0x699AE30", VA = "0x18699C630")]
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
		[Cpp2IlInjected.Address(RVA = "0x699CB00", Offset = "0x699B300", VA = "0x18699CB00", Slot = "4")]
		public int NCDLNIPPHPH(int AOIAEDIEBNE, int AIACEMCFIDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x699CA90", Offset = "0x699B290", VA = "0x18699CA90", Slot = "5")]
		public float AJDEJPNKOAH(float AOIAEDIEBNE, float COFGILMBNIC)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x699CB30", Offset = "0x699B330", VA = "0x18699CB30")]
		private double OHJJHCNFBKP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x699CB70", Offset = "0x699B370", VA = "0x18699CB70")]
		public DDKFLOAIDPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly IFEOFOPDGND PIJNCOJONDM;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x699CBF0", Offset = "0x699B3F0", VA = "0x18699CBF0")]
	public static ulong MHOJAOPOLHK()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class PFIJDJMLACG
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2CC7560", Offset = "0x2CC5D60", VA = "0x182CC7560")]
	public static bool HLJIJANFIGD<T>(this IReadOnlyCollection<T> HIKEOGPAJAF, int DHNLEFJCEAH) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class IICKKIPNECH
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2B84090", Offset = "0x2B82890", VA = "0x182B84090")]
	public static bool JKONKPFGDNM<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> HIKEOGPAJAF, IReadOnlyDictionary<TKey, TValue> OKGBBGMIACH) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class CEHKCOHDCLO
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2933A80", Offset = "0x2932280", VA = "0x182933A80")]
	public static TValue? JNHKPIOPLBC<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> HIKEOGPAJAF, TKey NDDCLPHCEEO) where TValue : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class ADKFOGDNBCF
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x699A980", Offset = "0x6999180", VA = "0x18699A980")]
	public static void APPOJKGPLJE(this IReadOnlyList<Action> HIKEOGPAJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x31CBBA0", Offset = "0x31CA3A0", VA = "0x1831CBBA0")]
	public static bool AKPHPFIGELN<T>(this IReadOnlyList<T> HIKEOGPAJAF, int DHNLEFJCEAH, [Out][NotNullWhen(true)][PEHALAEOKAF("This should be `T?` in C# 9.")] T ADPMAHMCGNH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x31CBAC0", Offset = "0x31CA2C0", VA = "0x1831CBAC0")]
	public static bool AGLPFCLAPCJ<T>(this IReadOnlyList<T> HIKEOGPAJAF, int DHNLEFJCEAH, [Out] DPKNNHGNADJ<T> ADPMAHMCGNH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x31CBDB0", Offset = "0x31CA5B0", VA = "0x1831CBDB0")]
	public static T PFDCILMKFFC<T>(this IReadOnlyList<T> HIKEOGPAJAF, int DHNLEFJCEAH, [In] T GFMHDPANGKF) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2C08880", Offset = "0x2C07080", VA = "0x182C08880")]
	[PEHALAEOKAF("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T HKHMHEOFKFK<T>(this IReadOnlyList<T> HIKEOGPAJAF, int DHNLEFJCEAH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x31CBCF0", Offset = "0x31CA4F0", VA = "0x1831CBCF0")]
	public static T? JNHKPIOPLBC<T>(this IReadOnlyList<T> HIKEOGPAJAF, int DHNLEFJCEAH) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class FALJLCJPCNG
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2B0CA50", Offset = "0x2B0B250", VA = "0x182B0CA50")]
	public static int IMLBDBIFEKB<T>([In] this ReadOnlySequence<T> BJMHIIGPDHE, [In] T JMDCGOKJIDA) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2B0CD30", Offset = "0x2B0B530", VA = "0x182B0CD30")]
	public static bool PKAAANLMMFG<T>([In] this ReadOnlySequence<T> BJMHIIGPDHE, [In] ReadOnlySpan<T> OKGBBGMIACH) where T : IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class AENPEJMEEON
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x31CD590", Offset = "0x31CBD90", VA = "0x1831CD590")]
	public static string KBCEOFKOLKI<T>([In] this ReadOnlySpan<T> HIKEOGPAJAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x31CC8F0", Offset = "0x31CB0F0", VA = "0x1831CC8F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x699D270", Offset = "0x699BA70", VA = "0x18699D270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x699D2C0", Offset = "0x699BAC0", VA = "0x18699D2C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x699CF50", Offset = "0x699B750", VA = "0x18699CF50", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8519E0", VA = "0x1808531E0")]
	private DOIECMEOPFJ(Stopwatch FPCPJEPFGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x699CF70", Offset = "0x699B770", VA = "0x18699CF70")]
	public static DOIECMEOPFJ GADLDLPFBEL(Stopwatch FPCPJEPFGDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x699CFE0", Offset = "0x699B7E0", VA = "0x18699CFE0")]
	public static DOIECMEOPFJ NKNDOJELBNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class BHDJNFMCIEP
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x699B440", Offset = "0x6999C40", VA = "0x18699B440")]
	public static float3 IPHKICBAECJ([In] this RigidTransform HIKEOGPAJAF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x699B570", Offset = "0x6999D70", VA = "0x18699B570")]
	public static float3 KLDADDHEDFM([In] this RigidTransform HIKEOGPAJAF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x94A370", Offset = "0x948B70", VA = "0x18094A370")]
	public static (float3, float3, float3) JKICLEKIMIM([In] this RigidTransform HIKEOGPAJAF)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x699B6A0", Offset = "0x6999EA0", VA = "0x18699B6A0")]
	public static RigidTransform PBBOICIJGJH([In] this RigidTransform HIKEOGPAJAF)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class EBPGLKHDBEH
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x699D1B0", Offset = "0x699B9B0", VA = "0x18699D1B0")]
	public static RigidTransform DIPNPIPFKGK(RigidTransform EAJCNPPJMKJ, RigidTransform ILOHGCBACNL)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class PJNALCOBKFM
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x699F0A0", Offset = "0x699D8A0", VA = "0x18699F0A0")]
	public static float BCEMEHCIFHG([In] this (byte Fourth, byte Third, byte Second, byte First) HIKEOGPAJAF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x699F0E0", Offset = "0x699D8E0", VA = "0x18699F0E0")]
	public static int FANKENHGAAB(this float HIKEOGPAJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x699F0F0", Offset = "0x699D8F0", VA = "0x18699F0F0")]
	public static (byte, byte, byte, byte) GHHGACDFBJE(this float HIKEOGPAJAF)
	{
		return default((byte, byte, byte, byte));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class HJJJANGGGCJ
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2935B80", Offset = "0x2934380", VA = "0x182935B80")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D421A0", Offset = "0x5D409A0", VA = "0x185D421A0")]
	public static bool PMFPICAICLC(this string? JBNNPFLCMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x699B8E0", Offset = "0x699A0E0", VA = "0x18699B8E0")]
	public static string? OLAJANNCJJL(this string? HIKEOGPAJAF, int KBFGFPLLOGD, string DHLJFGHDBHB = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x699B830", Offset = "0x699A030", VA = "0x18699B830")]
	public static string KFDHGJNEAGJ(this string HIKEOGPAJAF, int KBFGFPLLOGD, string DHLJFGHDBHB = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x699B700", Offset = "0x6999F00", VA = "0x18699B700")]
	public static int AJAEBJMABBF(this string JBNNPFLCMMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x699B770", Offset = "0x6999F70", VA = "0x18699B770")]
	public static string KAKOJOPHCGK(this string JBNNPFLCMMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x699B9C0", Offset = "0x699A1C0", VA = "0x18699B9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3B6DAA0", Offset = "0x3B6C2A0", VA = "0x183B6DAA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x44DD890", Offset = "0x44DC090", VA = "0x1844DD890")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x51F0D90", Offset = "0x51EF590", VA = "0x1851F0D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x51F0E60", Offset = "0x51EF660", VA = "0x1851F0E60")]
	public static FCAOODOBHEC OFGECFEDLIK()
	{
		return default(FCAOODOBHEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x51F0C00", Offset = "0x51EF400", VA = "0x1851F0C00")]
	private static void GFNHEDKJGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x51F0DF0", Offset = "0x51EF5F0", VA = "0x1851F0DF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x699F030", Offset = "0x699D830", VA = "0x18699F030")]
	public OGJOILKOKFE(DGCOAPLMOMC FPCPJEPFGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x699EFA0", Offset = "0x699D7A0", VA = "0x18699EFA0")]
	public long HJHOALHJOIG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x699EF10", Offset = "0x699D710", VA = "0x18699EF10")]
	public double HFMNCNMLOCD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x699EE80", Offset = "0x699D680", VA = "0x18699EE80")]
	public double GONLFMOBKHF()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class NKEOBENGMDH
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x699EDC0", Offset = "0x699D5C0", VA = "0x18699EDC0")]
	public static bool NMFAJOENEIM(this Type HIKEOGPAJAF, Type OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2C94030", Offset = "0x2C92830", VA = "0x182C94030")]
	public static bool NMFAJOENEIM<T>(this Type HIKEOGPAJAF) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class OANJLBINAIN
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x59A9500", Offset = "0x59A7D00", VA = "0x1859A9500")]
	public static uint MOIBDHMHAOD(this uint HIKEOGPAJAF, int IHGHLPOONHD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5A7A080", Offset = "0x5A78880", VA = "0x185A7A080")]
	public static uint GPPIGGICPDA(this uint HIKEOGPAJAF, int IHGHLPOONHD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x699EE70", Offset = "0x699D670", VA = "0x18699EE70")]
	public static uint GGLJGOOKPEN(this uint HIKEOGPAJAF, uint PDEKPELNLDP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x1035E40", Offset = "0x1034640", VA = "0x181035E40")]
	public static int FANKENHGAAB(this uint HIKEOGPAJAF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class CAMPEJJKAIE
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2924FD0", Offset = "0x29237D0", VA = "0x182924FD0")]
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
