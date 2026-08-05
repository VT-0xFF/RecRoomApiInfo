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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C5ADF0", Offset = "0x6C597F0", VA = "0x186C5ADF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5A0", Offset = "0x8ACFA0", VA = "0x1808AE5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE5E0", Offset = "0x8ACFE0", VA = "0x1808AE5E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OFOBLBPBNNH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string[] NBLOFHHJJFF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B2B0", Offset = "0x6C59CB0", VA = "0x186C5B2B0")]
	public static bool NFJDPNOLGAI(string IBIMEDCPOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B4D0", Offset = "0x6C59ED0", VA = "0x186C5B4D0")]
	private static bool OODEJJNMJDM(string BBDGOIMNDJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B380", Offset = "0x6C59D80", VA = "0x186C5B380")]
	public static bool OODEJJNMJDM(Exception DGKPIJKBMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C5AF80", Offset = "0x6C59980", VA = "0x186C5AF80")]
	public static string KGKLEDJBDMC(string OOCPPLNIOAJ, string PFOPPCFDLPJ = "", bool MNMJGJLNNPJ = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class AIJABDOONDG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C58010", Offset = "0x6C56A10", VA = "0x186C58010")]
	public static string EAPBEMJCJNK(this Guid OKMPNEEAGBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C580C0", Offset = "0x6C56AC0", VA = "0x186C580C0")]
	public static string EAPBEMJCJNK(this byte[] MGCOGNAKONH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C58160", Offset = "0x6C56B60", VA = "0x186C58160")]
	public static byte[] FANLKNNGDPO(string FLOIFDPDODK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class AKDKOHOJBKC
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int FJDPNJENAKL<T>([In] T MFLKJAHENBP, [In] T PLHCHKLJLJD);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class EFOCIMBGBBN<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct KBOBALCPNNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly int BHLKMIGNPBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public readonly int DFHDKEMDHCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public readonly bool HMPAENFBMIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int BJDBPDMMJAK;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x43CB550", Offset = "0x43C9F50", VA = "0x1843CB550")]
			public KBOBALCPNNG(int BHLKMIGNPBH, int DFHDKEMDHCA, bool HMPAENFBMIB)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly T[] KDMFBINKOBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly T[] DLPJDCELMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly FJDPNJENAKL<T> OLCIHCCNEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly int NPJDPMIKACJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Func<bool> DFMOEHIAKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int EAOLIIFCHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly KBOBALCPNNG[] POAFGNMCGOH;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3A16890", Offset = "0x3A15290", VA = "0x183A16890")]
		public EFOCIMBGBBN(T[] KDMFBINKOBP, FJDPNJENAKL<T> OLCIHCCNEID, int NPJDPMIKACJ, Func<bool> DFMOEHIAKHN, T[]? HJJGFDFLGOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3A16570", Offset = "0x3A14F70", VA = "0x183A16570")]
		public bool JBCAEAAOEPI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate U APMHOFFLEEK<T, U>(int KMMAKONLIKB, int CMBNDNLABPM, [In] ReadOnlySpan<T> KIFHAGIMBPC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3444880", Offset = "0x3443280", VA = "0x183444880")]
	public static T[] AEIEFOMMNLB<T>(int ECFPAOHDFEB, T NOEIGDPJJDJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x34456E0", Offset = "0x34440E0", VA = "0x1834456E0")]
	public static void EPLDEIIGBGD<T>(this T[] GJGHHMBLOPM, T NOEIGDPJJDJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3446020", Offset = "0x3444A20", VA = "0x183446020")]
	public static void JIHCJCGIDOL<T>(this T[] FEMJEOMOEIN, int ELMEOKPKOPN, int KHPPHPLLIMF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3445080", Offset = "0x3443A80", VA = "0x183445080")]
	private static void ECMACICFJHH<T>(this T[] NKCEKILMAAM, int OJLHLMANOCF, int ACLAJOHCOFG, T[] CGCLEIBHLHF, int GICBMGJMAII, int LFGAOKKCCMI, T[] NLAECIHBKHE, int ANJMMHHEOJP, FJDPNJENAKL<T> OLCIHCCNEID) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3444AD0", Offset = "0x34434D0", VA = "0x183444AD0")]
	public static void AJMKHEPKLAJ<T>(this T[] NKCEKILMAAM, int BHLKMIGNPBH, int CMNDBGDABDM, FJDPNJENAKL<T> OLCIHCCNEID) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3445EB0", Offset = "0x34448B0", VA = "0x183445EB0")]
	public static EFOCIMBGBBN<T> IHBGICDMBEK<T>(this T[] NKCEKILMAAM, FJDPNJENAKL<T> OLCIHCCNEID, int NPJDPMIKACJ, Func<bool> DFMOEHIAKHN, [Optional] T[]? HJJGFDFLGOH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3445030", Offset = "0x3443A30", VA = "0x183445030")]
	public static T[] BHBDNHGEFHL<T>(this T[] FEMJEOMOEIN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3444EE0", Offset = "0x34438E0", VA = "0x183444EE0")]
	public static T[] AKGJGELNCCP<T>(this T[] IEOCFHAFFCN, T EJICFCHAEHD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x34460A0", Offset = "0x3444AA0", VA = "0x1834460A0")]
	public static T[] PMCFPBEPNFC<T>(this T[] IEOCFHAFFCN, int ENMILGHAHOM, T EJICFCHAEHD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3444A20", Offset = "0x3443420", VA = "0x183444A20")]
	public static T[] AJDAHFCDGEG<T>(this T[] IEOCFHAFFCN, int ENMILGHAHOM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3445440", Offset = "0x3443E40", VA = "0x183445440")]
	public static T[] EIKMLAIJANN<T>(this T[] IEOCFHAFFCN, int ENMILGHAHOM, T EJICFCHAEHD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x34458B0", Offset = "0x34442B0", VA = "0x1834458B0")]
	public static U[] FJFHKJCCCGN<U, T>(this T[] CCIELLHDDHE, int LPFOHOCACDL, APMHOFFLEEK<T, U> OOHJGIMOPLC) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C584B0", Offset = "0x6C56EB0", VA = "0x186C584B0")]
	public static byte[] PKFIGAFFMGA(this byte[] NKCEKILMAAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C58230", Offset = "0x6C56C30", VA = "0x186C58230")]
	public static byte[] DDHJLDBGGFM(this byte[] NKCEKILMAAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DCHIICEBEKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C58B70", Offset = "0x6C57570", VA = "0x186C58B70")]
	public static byte NGFBLLAKFBJ(this bool NKCEKILMAAM)
	{
		return default(byte);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MNKHAFPAPBM
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C58B70", Offset = "0x6C57570", VA = "0x186C58B70")]
	public static bool IAODJMLHEMH(this byte NKCEKILMAAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PMGJDEAILNB
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2F192F0", Offset = "0x2F17CF0", VA = "0x182F192F0")]
	public static void NFNEGMAIBMF<T>(this ICollection<T> NKCEKILMAAM, IEnumerable<T> KFMCFDFMFGI) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EHACFMEPBPB
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2BCD890", Offset = "0x2BCC290", VA = "0x182BCD890")]
	public static V OIJAPHFLDBD<V, K>(this IDictionary<K, V> NKCEKILMAAM, [In] K COMNIKKFEEB, [In] V IPHMAHBENGI, Func<V, V, V> IPJFPJIAEFE) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC230", Offset = "0x2BCAC30", VA = "0x182BCC230")]
	public static void IEGAHMPCCNC<K, V>(this IDictionary<K, List<V>> NKCEKILMAAM, [In] K COMNIKKFEEB, [In] V IPHMAHBENGI) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2BCB410", Offset = "0x2BC9E10", VA = "0x182BCB410")]
	public static TVal HGDOPKCICEN<TVal, TKey>(this IDictionary<TKey, TVal> BHMPBJAIPDE, [In] TKey COMNIKKFEEB, [Optional][OKKPIGINHED("`default!` shouldn't be necessary in C# 9")] TVal FABNMHPKJIP) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2BCB250", Offset = "0x2BC9C50", VA = "0x182BCB250")]
	public static TVal HGDOPKCICEN<TVal, TKey>(this IDictionary<TKey, TVal> BHMPBJAIPDE, [In] TKey COMNIKKFEEB, Func<TVal> BPIAIJAHBPG) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2BCCE50", Offset = "0x2BCB850", VA = "0x182BCCE50")]
	public static TValue NPKHNJICONK<TValue, TKey>(this IDictionary<TKey, TValue> BHMPBJAIPDE, [In] TKey COMNIKKFEEB, [Optional][In][OKKPIGINHED("`default!` and null-oblivious region shouldn't be necessary in C# 9")] TValue FABNMHPKJIP)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC9E0", Offset = "0x2BCB3E0", VA = "0x182BCC9E0")]
	public static V MDDALBDHLFM<V, K>(this IDictionary<K, V> NKCEKILMAAM, [In] K COMNIKKFEEB) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2BCDFA0", Offset = "0x2BCC9A0", VA = "0x182BCDFA0")]
	public static T2[] OPHIMHIMIKB<T2, T1>(this Dictionary<T1, T2>.ValueCollection BLGCDHJLEHG) where T2 : notnull where T1 : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ODMLBKBGKMP
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate bool CHHMPPKCEOJ<TArgs, T>([In] TArgs BBLLNFBCDFH, T LHFGBAJKEKO);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate U BMGBJDLDDLH<TArg, U>([In] TArg OKHFPGFAECB);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate U LDJMOOAJPLK<TArg, T, U>([In] TArg OKHFPGFAECB, T LJHMHPGNKEJ);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate U OBHDMFDMEAA<TArg, T, U>([In] TArg OKHFPGFAECB, IEnumerable<T> BBBCJIECHAD);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate U MLHLHIMLCBJ<TArg, T, U>([In] TArg OKHFPGFAECB, T LJHMHPGNKEJ);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct FHIBCCEDLAO<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6F10", Offset = "0x3DF5910", VA = "0x183DF6F10")]
		[OKKPIGINHED("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) CHLKAJEJPON(T FHDPJGHLELN)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6F70", Offset = "0x3DF5970", VA = "0x183DF6F70")]
		[OKKPIGINHED("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) DNDHEEFAFPE(IEnumerable<T> IDEEJOKGBPH)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JEONPIOIDHH<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x913F90", Offset = "0x912990", VA = "0x180913F90", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x42F0840", Offset = "0x42EF240", VA = "0x1842F0840", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xCB3850", Offset = "0xCB2250", VA = "0x180CB3850")]
		[DebuggerHidden]
		public JEONPIOIDHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3C0EED0", Offset = "0x3C0D8D0", VA = "0x183C0EED0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x42EFE30", Offset = "0x42EE830", VA = "0x1842EFE30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x42EFD90", Offset = "0x42EE790", VA = "0x1842EFD90")]
		private void JDIKFIOLCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x42F07F0", Offset = "0x42EF1F0", VA = "0x1842F07F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x42F0680", Offset = "0x42EF080", VA = "0x1842F0680", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x42F0760", Offset = "0x42EF160", VA = "0x1842F0760", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class AOGMBAHLPCI<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x976660", Offset = "0x975060", VA = "0x180976660")]
		[DebuggerHidden]
		public AOGMBAHLPCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3EAEC30", Offset = "0x3EAD630", VA = "0x183EAEC30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3EAE5D0", Offset = "0x3EACFD0", VA = "0x183EAE5D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3EADD70", Offset = "0x3EAC770", VA = "0x183EADD70")]
		private void JDIKFIOLCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3EADCD0", Offset = "0x3EAC6D0", VA = "0x183EADCD0")]
		private void EEFNKGAPPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3EAEBE0", Offset = "0x3EAD5E0", VA = "0x183EAEBE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3EAE950", Offset = "0x3EAD350", VA = "0x183EAE950", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3C16320", Offset = "0x3C14D20", VA = "0x183C16320", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class INBIKKEIJNK<T> : IEnumerable<(T, CPOGLEEFNCN<T>)>, IEnumerable, IEnumerator<(T, CPOGLEEFNCN<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private (T Current, CPOGLEEFNCN<T> Next) <>2__current;

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
		private (T, CPOGLEEFNCN<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x3AA40B0", Offset = "0x3AA2AB0", VA = "0x183AA40B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, CPOGLEEFNCN<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x40AC510", Offset = "0x40AAF10", VA = "0x1840AC510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2015AA0", Offset = "0x20144A0", VA = "0x182015AA0")]
		[DebuggerHidden]
		public INBIKKEIJNK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3C15480", Offset = "0x3C13E80", VA = "0x183C15480", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x40ABC10", Offset = "0x40AA610", VA = "0x1840ABC10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x40AAC40", Offset = "0x40A9640", VA = "0x1840AAC40")]
		private void JDIKFIOLCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x40AC470", Offset = "0x40AAE70", VA = "0x1840AC470", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x40AC230", Offset = "0x40AAC30", VA = "0x1840AC230", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, CPOGLEEFNCN<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3C16320", Offset = "0x3C14D20", VA = "0x183C16320", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class MHOOEMKCMAB<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
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
		private Func<FHIBCCEDLAO<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Func<FHIBCCEDLAO<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x976660", Offset = "0x975060", VA = "0x180976660")]
		[DebuggerHidden]
		public MHOOEMKCMAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x46998C0", Offset = "0x46982C0", VA = "0x1846998C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x46993F0", Offset = "0x4697DF0", VA = "0x1846993F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x46993A0", Offset = "0x4697DA0", VA = "0x1846993A0")]
		private void JDIKFIOLCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4699350", Offset = "0x4697D50", VA = "0x184699350")]
		private void EEFNKGAPPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4699870", Offset = "0x4698270", VA = "0x184699870", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3E4A710", Offset = "0x3E49110", VA = "0x183E4A710", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3E4AE10", Offset = "0x3E49810", VA = "0x183E4AE10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class CLNMNAEJPPG<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public CLNMNAEJPPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x49BB470", Offset = "0x49B9E70", VA = "0x1849BB470")]
		internal bool DLGCFCLIAKK(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x56C58E0", Offset = "0x56C42E0", VA = "0x1856C58E0")]
		internal bool DDKKBCDGLNL(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class FNBBKHNAIBC<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0xE738F0", Offset = "0xE722F0", VA = "0x180E738F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E06190", Offset = "0x3E04B90", VA = "0x183E06190", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x2015AA0", Offset = "0x20144A0", VA = "0x182015AA0")]
		[DebuggerHidden]
		public FNBBKHNAIBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3E05E40", Offset = "0x3E04840", VA = "0x183E05E40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3E06140", Offset = "0x3E04B40", VA = "0x183E06140", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3E06060", Offset = "0x3E04A60", VA = "0x183E06060", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3C16320", Offset = "0x3C14D20", VA = "0x183C16320", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2EFE0E0", Offset = "0x2EFCAE0", VA = "0x182EFE0E0")]
	public static bool PIIKNADNFIK<T, TArgs>(this IEnumerable<T> NKCEKILMAAM, [In] TArgs BBLLNFBCDFH, CHHMPPKCEOJ<TArgs, T> IOMFLMOBPFI) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C5AE70", Offset = "0x6C59870", VA = "0x186C5AE70")]
	public static bool PIIKNADNFIK(this IEnumerable<bool> NKCEKILMAAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2EF8040", Offset = "0x2EF6A40", VA = "0x182EF8040")]
	public static U ANFDPONJOCL<U, T>(this IEnumerable<T> NKCEKILMAAM, Func<U> CDMNHJGCGCI, Func<T, U> FHDPJGHLELN, Func<IEnumerable<T>, U> IDEEJOKGBPH) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB630", Offset = "0x2EFA030", VA = "0x182EFB630")]
	public static bool KFBCBLIKMOI<T, TArgs>(this IEnumerable<T> NKCEKILMAAM, [In] TArgs BBLLNFBCDFH, CHHMPPKCEOJ<TArgs, T> IOMFLMOBPFI) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2EF7DC0", Offset = "0x2EF67C0", VA = "0x182EF7DC0")]
	public static U AKFDNHDBFFA<U, T, TArg>(this IEnumerable<T> NKCEKILMAAM, [In] TArg OKHFPGFAECB, BMGBJDLDDLH<TArg, U> CDMNHJGCGCI, LDJMOOAJPLK<TArg, T, U> FHDPJGHLELN, OBHDMFDMEAA<TArg, T, U> IDEEJOKGBPH) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2EFA8C0", Offset = "0x2EF92C0", VA = "0x182EFA8C0")]
	public static IEnumerable<U> IFNABFIJOHB<U, T, TArg>(this IEnumerable<T> NKCEKILMAAM, [In] TArg OKHFPGFAECB, MLHLHIMLCBJ<TArg, T, U> LLDMHJINCKF) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2BD19F0", Offset = "0x2BD03F0", VA = "0x182BD19F0")]
	public static IEnumerable<T> INNDJKJLOAK<T>(params IEnumerable<T>[] CHCPJJMLNFP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2EFC9B0", Offset = "0x2EFB3B0", VA = "0x182EFC9B0")]
	public static bool LILHGGDIGNG<T>(this IEnumerable<T> FCLIEHCKPJG, IEnumerable<T> CGCLEIBHLHF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2BD19F0", Offset = "0x2BD03F0", VA = "0x182BD19F0")]
	public static IEnumerable<(TKey?, TValue?)>? NLBNLNHINKK<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> NKCEKILMAAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB160", Offset = "0x2EF9B60", VA = "0x182EFB160")]
	public static IEnumerable<T> JANHAEJMEOG<T, TKey>(this IEnumerable<T> JNFNMBKOHBJ, Func<T, TKey> NGINKMNPPMM) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2C956F0", Offset = "0x2C940F0", VA = "0x182C956F0")]
	[IteratorStateMachine(typeof(JEONPIOIDHH<>))]
	public static IEnumerable<T> OCJGKNNOEDA<T>(this IEnumerable<T> FCLIEHCKPJG, ISet<T> ICFMCHEMBJE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2CE21C0", Offset = "0x2CE0BC0", VA = "0x182CE21C0")]
	[IteratorStateMachine(typeof(AOGMBAHLPCI<, >))]
	public static IEnumerable<T> MIEFNECIJPD<T, U>(this IEnumerable<T> NKCEKILMAAM, IEnumerable<U> CGCLEIBHLHF, [Optional][OKKPIGINHED("`default!` shouldn't be necessary in C# 9")] T NOEIGDPJJDJ) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2A41000", Offset = "0x2A3FA00", VA = "0x182A41000")]
	public static T IPAHABAAOEB<T>(this IEnumerable<T> FCLIEHCKPJG, T FABNMHPKJIP) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB0E0", Offset = "0x2EF9AE0", VA = "0x182EFB0E0")]
	public static T IPAHABAAOEB<T>(this IEnumerable<T> FCLIEHCKPJG, T FABNMHPKJIP, Func<T, bool> IOMFLMOBPFI) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2EF8AA0", Offset = "0x2EF74A0", VA = "0x182EF8AA0")]
	public static T? DGJMJIMFJKE<T>(this IEnumerable<T> NKCEKILMAAM, Func<T, bool> IOMFLMOBPFI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2EFBD60", Offset = "0x2EFA760", VA = "0x182EFBD60")]
	public static void KOADDEMANGG<T>(this IEnumerable<T> NKCEKILMAAM, Action<T> AOABLNBOBDJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2C642F0", Offset = "0x2C62CF0", VA = "0x182C642F0")]
	[IteratorStateMachine(typeof(INBIKKEIJNK<>))]
	public static IEnumerable<(T, CPOGLEEFNCN<T>)> FLOGNPAKCEK<T>(this IEnumerable<T> NKCEKILMAAM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2EFAB60", Offset = "0x2EF9560", VA = "0x182EFAB60")]
	public static bool IHCIOMBODMM<T>(this IEnumerable<T> NKCEKILMAAM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2BD19F0", Offset = "0x2BD03F0", VA = "0x182BD19F0")]
	public static IEnumerable<PMFCIACEFOO<T>> BDIPFIAMOOH<T>(this IEnumerable<T> NKCEKILMAAM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2EF9650", Offset = "0x2EF8050", VA = "0x182EF9650")]
	public static bool EMCJBNDMBFI<T>(this IEnumerable<T> NKCEKILMAAM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2EF8A60", Offset = "0x2EF7460", VA = "0x182EF8A60")]
	public static IEnumerable<T> CPACEMNGJAK<T>(this IEnumerable<T>? NKCEKILMAAM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2C63F80", Offset = "0x2C62980", VA = "0x182C63F80")]
	[IteratorStateMachine(typeof(MHOOEMKCMAB<, >))]
	public static IEnumerable<U> CAMBIJGKGFM<U, T>(this IEnumerable<T> NKCEKILMAAM, Func<FHIBCCEDLAO<U>, T, (bool Zero, U One, IEnumerable<U> Many)> CGHAMDNDOPN) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2BD19F0", Offset = "0x2BD03F0", VA = "0x182BD19F0")]
	public static IEnumerable<T> CHDDLIBOOCJ<T>(this IEnumerable<IEnumerable<T>> NKCEKILMAAM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2EFAC90", Offset = "0x2EF9690", VA = "0x182EFAC90")]
	public static int ILHCOFDBINE<T>(this IEnumerable<T> NKCEKILMAAM, int BMGLEBODMLH = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2EFD8B0", Offset = "0x2EFC2B0", VA = "0x182EFD8B0")]
	public static bool NMNBMIHNOEF<T>(this IEnumerable<T> NKCEKILMAAM, IEnumerable<T> CGCLEIBHLHF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2EFDB20", Offset = "0x2EFC520", VA = "0x182EFDB20")]
	public static IEnumerable<T> PEEJBIMAGBC<T>(this IEnumerable<T> NKCEKILMAAM, int MPJFIDGJBEE, int CDMELEBGCMN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2EF9320", Offset = "0x2EF7D20", VA = "0x182EF9320")]
	public static (IEnumerable<T>, IEnumerable<T>) DOMPDOGPDEL<T>(this IEnumerable<T> NKCEKILMAAM, Func<T, bool> CPOGEBKOMAM) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2EF8620", Offset = "0x2EF7020", VA = "0x182EF8620")]
	public static string CFACLPOOBEI<T>(this IEnumerable<T> NKCEKILMAAM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB340", Offset = "0x2EF9D40", VA = "0x182EFB340")]
	public static Dictionary<TKey?, TValue?>? JICIFMPABOB<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> FCLIEHCKPJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB340", Offset = "0x2EF9D40", VA = "0x182EFB340")]
	public static Dictionary<TKey?, TValue?>? JICIFMPABOB<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> FCLIEHCKPJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2EF7A80", Offset = "0x2EF6480", VA = "0x182EF7A80")]
	public static List<T> ADKHFAMFOOP<T>(this IEnumerable<T> NKCEKILMAAM, int PAODLCPDLEP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2EF82B0", Offset = "0x2EF6CB0", VA = "0x182EF82B0")]
	public static string BMFGIBNHKDL<T>(this IEnumerable<T> NKCEKILMAAM, string CAMNIOKBPBM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2EF9690", Offset = "0x2EF8090", VA = "0x182EF9690")]
	public static (IReadOnlyList<T?>?, IReadOnlyList<U?>?) FJBNAGPCHII<T, U>(this IEnumerable<(T Lhs, U Rhs)> NKCEKILMAAM)
	{
		return default((IReadOnlyList<T>, IReadOnlyList<U>));
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2C8E920", Offset = "0x2C8D320", VA = "0x182C8E920")]
	[IteratorStateMachine(typeof(FNBBKHNAIBC<, >))]
	public static IEnumerable<(T, U)> JCIFPJPOMJM<T, U>(this IEnumerable<T> MFLKJAHENBP, IEnumerable<U> PLHCHKLJLJD) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2EFA380", Offset = "0x2EF8D80", VA = "0x182EFA380")]
	public static IEnumerable<V> GDPJGLMBNKL<V, T, U>(this IEnumerable<T> NKCEKILMAAM, IEnumerable<U> CGCLEIBHLHF, Func<T, U, V> HCPHBHFIEJF, [Optional][OKKPIGINHED("`default!` shouldn't be necessary in C# 9")] T EEEOENGDBJE, [Optional][OKKPIGINHED("`default!` shouldn't be necessary in C# 9")] U JBKPGNACJDC) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2EFA450", Offset = "0x2EF8E50", VA = "0x182EFA450")]
	public static IEnumerable<(T, U)> GDPJGLMBNKL<T, U>(this IEnumerable<T> NKCEKILMAAM, IEnumerable<U> CGCLEIBHLHF, [Optional][OKKPIGINHED("`default!` shouldn't be necessary in C# 9")] T EEEOENGDBJE, [Optional][OKKPIGINHED("`default!` shouldn't be necessary in C# 9")] U JBKPGNACJDC) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2EFD370", Offset = "0x2EFBD70", VA = "0x182EFD370")]
	public static TOut[] MPGHOOHJNBL<TOut, TIn>(this IEnumerable<TIn> JNFNMBKOHBJ, Func<TIn, TOut> NGJHOJLJKOO) where TOut : notnull where TIn : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2EFCBA0", Offset = "0x2EFB5A0", VA = "0x182EFCBA0")]
	public static CPOGLEEFNCN<U> LMKBLDLDDEL<U, T>(this IEnumerable<T> NHKOCMGDPBO, Func<T, U> KLDBEENHFBK) where U : notnull where T : notnull
	{
		return default(CPOGLEEFNCN<U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class EBPPKLMFOBE
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2BC8420", Offset = "0x2BC6E20", VA = "0x182BC8420")]
	public static bool GIGLHOKBLNL<T, U>(this T NKCEKILMAAM, [In] U FHFDEAHMMBI) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2BC8380", Offset = "0x2BC6D80", VA = "0x182BC8380")]
	public static bool GFOJMLEOHJB<T>(T NKCEKILMAAM, T CGCLEIBHLHF) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class HIKGCBMOPNL
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1070F40", Offset = "0x106F940", VA = "0x181070F40")]
	public static bool DFAJLLNJFDL([In] this float3 KPNKONMDFPM, float3 NGNLLOFPDHF, float HPLHKPKJECM = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class FINDGKIILLG
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class FOHHCOFMHEN<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0xE738F0", Offset = "0xE722F0", VA = "0x180E738F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D76F70", Offset = "0x3D75970", VA = "0x183D76F70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2015AA0", Offset = "0x20144A0", VA = "0x182015AA0")]
		[DebuggerHidden]
		public FOHHCOFMHEN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E06CD0", Offset = "0x3E056D0", VA = "0x183E06CD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3E07190", Offset = "0x3E05B90", VA = "0x183E07190", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3E07020", Offset = "0x3E05A20", VA = "0x183E07020", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3AFAD80", Offset = "0x3AF9780", VA = "0x183AFAD80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2D54200", Offset = "0x2D52C00", VA = "0x182D54200")]
	public static void LJIIHBIEJLB<T>(this T NNEFLDDEJJK, Action<T> ODHLBHCDJDA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2D54120", Offset = "0x2D52B20", VA = "0x182D54120")]
	public static V ENOPOHCOOPP<V, T>(this T NNEFLDDEJJK, Func<T, V> ODHLBHCDJDA, [Optional][OKKPIGINHED("`default!` shouldn't be necessary in C# 9")] V FABNMHPKJIP) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2D54410", Offset = "0x2D52E10", VA = "0x182D54410")]
	public static T? PFMKAPBBKDI<T>(this T NKCEKILMAAM) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2D54250", Offset = "0x2D52C50", VA = "0x182D54250")]
	[IteratorStateMachine(typeof(FOHHCOFMHEN<>))]
	public static IEnumerable<T> OKOIOMDOHEO<T>(this T NKCEKILMAAM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2D54000", Offset = "0x2D52A00", VA = "0x182D54000")]
	public static T[] BBGKEEOIBLM<T>(this T NKCEKILMAAM) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class MLNKKPADPCL
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A380", Offset = "0x6C58D80", VA = "0x186C5A380")]
	private static byte[] DKLIEADMKIM(int CNGEJFLBKEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6C5AB70", Offset = "0x6C59570", VA = "0x186C5AB70")]
	private static byte[] JGNEOONAIDM(long NLCHMMBHFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6C5AAF0", Offset = "0x6C594F0", VA = "0x186C5AAF0")]
	private static byte[] JCPEHNDLLMJ(ulong NLCHMMBHFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6C5ABF0", Offset = "0x6C595F0", VA = "0x186C5ABF0")]
	public static Guid KLFMDDBGOLH(params Guid[] GGPJNALCOLN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A4D0", Offset = "0x6C58ED0", VA = "0x186C5A4D0")]
	public static Guid EMJKOLAJLFI([In] Guid IMCANNMFEFH, int ENMILGHAHOM, int MOOGIOAAOOM = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A9B0", Offset = "0x6C593B0", VA = "0x186C5A9B0")]
	public static Guid EMJKOLAJLFI([In] Guid IMCANNMFEFH, long ENMILGHAHOM, int MOOGIOAAOOM = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A400", Offset = "0x6C58E00", VA = "0x186C5A400")]
	public static Guid EMJKOLAJLFI([In] Guid IMCANNMFEFH, ulong ENMILGHAHOM, int MOOGIOAAOOM = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6C5AA80", Offset = "0x6C59480", VA = "0x186C5AA80")]
	public static Guid EMJKOLAJLFI([In] Guid IMCANNMFEFH, [In] Guid KCLNFNKEDJI, int MOOGIOAAOOM = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A5A0", Offset = "0x6C58FA0", VA = "0x186C5A5A0")]
	private static Guid EMJKOLAJLFI([In] Guid IMCANNMFEFH, byte[] JNHOHIKPJGJ, int MOOGIOAAOOM = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6C5AD60", Offset = "0x6C59760", VA = "0x186C5AD60")]
	private static void LODAHMPMIOD(byte[] OKMPNEEAGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A330", Offset = "0x6C58D30", VA = "0x186C5A330")]
	private static void AGOMOICIIIL(byte[] OKMPNEEAGBI, int OMCEEKENOBB, int MOBHGIAPGGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class BBNKMJCKPLA
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6C588B0", Offset = "0x6C572B0", VA = "0x186C588B0")]
	public static int NGEGNKDFFIB(this int NKCEKILMAAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6C58870", Offset = "0x6C57270", VA = "0x186C58870")]
	public static int MJAENMHBKGL(this int NKCEKILMAAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6C58820", Offset = "0x6C57220", VA = "0x186C58820")]
	public static int LJLAHNDJHEB(this int NKCEKILMAAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6C58800", Offset = "0x6C57200", VA = "0x186C58800")]
	public static int IICGPMABCGN(this int NKCEKILMAAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5C697B0", Offset = "0x5C681B0", VA = "0x185C697B0")]
	public static int AFNLCMLPJPG(this int NKCEKILMAAM, int CMNDBGDABDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5D39810", Offset = "0x5D38210", VA = "0x185D39810")]
	public static int AHNBPNKMMNB(this int NKCEKILMAAM, int CMNDBGDABDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6C58770", Offset = "0x6C57170", VA = "0x186C58770")]
	public static float GECLOJPIBJC(this int NKCEKILMAAM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6C58790", Offset = "0x6C57190", VA = "0x186C58790")]
	public static (byte, byte, byte, byte) GKKEFJPBKAI(this int NKCEKILMAAM)
	{
		return default((byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6C58750", Offset = "0x6C57150", VA = "0x186C58750")]
	public static int DHMFCBLACDM([In] this (byte Fourth, byte Third, byte Second, byte First) NKCEKILMAAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6C58740", Offset = "0x6C57140", VA = "0x186C58740")]
	public static int DAOIHFAOPAB(this int NKCEKILMAAM, int BAHCHNPPNGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6C58810", Offset = "0x6C57210", VA = "0x186C58810")]
	public static int KEAKFCFMNFP(this int NKCEKILMAAM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class AIGMNPNCMEA
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6C57F00", Offset = "0x6C56900", VA = "0x186C57F00")]
	public static (byte, byte, byte, byte, byte, byte, byte, byte) GKKEFJPBKAI(this long NKCEKILMAAM)
	{
		return default((byte, byte, byte, byte, byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6C57FC0", Offset = "0x6C569C0", VA = "0x186C57FC0")]
	public static long PIAGNFAEHHE([In] this (byte Eighth, byte Seventh, byte Sixth, byte Fifth, byte Fourth, byte Third, byte Second, byte First) NKCEKILMAAM)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface NMMDBGJGIMB
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PNIOHMAODCA(int CEIBFGFGBDM, int ODODKMNJIJM);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float GBOBDHABNLB(float GDIFDOIMLEA, float HNLDFEGKCEL);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface MHBHGJBBHFN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	long ALICKLGCDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class HDDLOAIALPP
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2D79D00", Offset = "0x2D78700", VA = "0x182D79D00")]
	public static (TKey?, TValue?) FAJCPJHLGMJ<TKey, TValue>([In] this KeyValuePair<TKey, TValue> NKCEKILMAAM)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2D79E60", Offset = "0x2D78860", VA = "0x182D79E60")]
	public static KeyValuePair<TKey?, UValue?> HCDBLIFGCHJ<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> NKCEKILMAAM, UValue IPHMAHBENGI)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class ICFEEPEOHKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FHFPGEODMLF<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public FHFPGEODMLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6450", Offset = "0x3DF4E50", VA = "0x183DF6450")]
		internal TElement GACJGDDLNEC(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2D94C50", Offset = "0x2D93650", VA = "0x182D94C50")]
	public static int EOOADBNFDNM<T>(this IReadOnlyList<T> FEMJEOMOEIN, T IPHMAHBENGI) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D98800", Offset = "0x2D97200", VA = "0x182D98800")]
	public static int HBAFMFBMECC<T>(this IReadOnlyList<T> FEMJEOMOEIN, T IPHMAHBENGI) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2D9AE00", Offset = "0x2D99800", VA = "0x182D9AE00")]
	public static void NFNEGMAIBMF<T>(this HashSet<T> EBNJEEFHLME, IEnumerable<T> KFMCFDFMFGI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A4E0", Offset = "0x2D98EE0", VA = "0x182D9A4E0")]
	public static void MDEJOHMLCDB<T>(this IList<T> GLCCIANLCJC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A570", Offset = "0x2D98F70", VA = "0x182D9A570")]
	public static void MDEJOHMLCDB<T>(this IList<T> GLCCIANLCJC, int OLBFEOCKIIM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2D9BFD0", Offset = "0x2D9A9D0", VA = "0x182D9BFD0")]
	public static void ONJJJMLDOJP<T>(this List<T> GLCCIANLCJC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2D9AC80", Offset = "0x2D99680", VA = "0x182D9AC80")]
	public static List<T> NBIAPAGFGPJ<T>(this List<T> JMHFDCNLPLK, Predicate<T> CBDDOFGFFHA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2D95290", Offset = "0x2D93C90", VA = "0x182D95290")]
	public static int EOOADBNFDNM<T>(this IReadOnlyList<T> GLCCIANLCJC, Predicate<T> IOMFLMOBPFI) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2D998B0", Offset = "0x2D982B0", VA = "0x182D998B0")]
	public static bool IKAFFGDEMMP<T>(this IReadOnlyList<T> GLCCIANLCJC, Predicate<T> IOMFLMOBPFI, [Out][NotNullWhen(true)] List<int>? MBDNPINLOGK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2D94790", Offset = "0x2D93190", VA = "0x182D94790")]
	public static bool DDGNJIHOIKG<T>(this IReadOnlyList<T> GLCCIANLCJC, T LHFGBAJKEKO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2D94810", Offset = "0x2D93210", VA = "0x182D94810")]
	public static bool DDGNJIHOIKG<T>(this IReadOnlyList<T> GLCCIANLCJC, T LHFGBAJKEKO, EqualityComparer<T> JJCIHJBGFLO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D98D80", Offset = "0x2D97780", VA = "0x182D98D80")]
	public static int HGPJEHHOFEH<TElement, TKey>(this IList<TElement> IKMFKLLHPIO, TKey OJKLACHOHJE, Func<TElement, TKey> EPDNFCMHAOH, [Optional] Func<TKey, TKey, int>? OLCIHCCNEID, int ENMILGHAHOM = 0, [Optional] int? CMNDBGDABDM) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2D989E0", Offset = "0x2D973E0", VA = "0x182D989E0")]
	public static int HGPJEHHOFEH<TElement, TKey>(Func<int, TElement> ENNNKNIJPPC, int MHNHCOJKKDO, TKey OJKLACHOHJE, Func<TElement, TKey> EPDNFCMHAOH, [Optional] Func<TKey, TKey, int>? OLCIHCCNEID, int ENMILGHAHOM = 0, [Optional] int? CMNDBGDABDM) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2D98600", Offset = "0x2D97000", VA = "0x182D98600")]
	public static bool GDLCMGKLLEP<T>(this List<T> GLCCIANLCJC, T LHFGBAJKEKO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2D94A20", Offset = "0x2D93420", VA = "0x182D94A20")]
	public static void EJAOMJMENIP<T>(this List<T> GLCCIANLCJC, IEnumerable<T> JMHFDCNLPLK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2D98140", Offset = "0x2D96B40", VA = "0x182D98140")]
	public static void GDFNAHCIADO<T>(this List<T> GLCCIANLCJC, IEnumerable<T> JMHFDCNLPLK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2D99D50", Offset = "0x2D98750", VA = "0x182D99D50")]
	public static T INKIPHACNED<T>(this List<T> JMHFDCNLPLK, Predicate<T> CBDDOFGFFHA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A280", Offset = "0x2D98C80", VA = "0x182D9A280")]
	public static T LMECJJCFDKP<T>(this List<T> JMHFDCNLPLK, int ENMILGHAHOM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2D9BC20", Offset = "0x2D9A620", VA = "0x182D9BC20")]
	public static void OHHHFNECKHG<T>(this List<T> GLCCIANLCJC, int ENMILGHAHOM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2D9BB30", Offset = "0x2D9A530", VA = "0x182D9BB30")]
	public static bool OGKOGJAAFGF<T>(this List<T> DMNBCPCBOCC, List<T> BDBGLHCMGGG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2D980A0", Offset = "0x2D96AA0", VA = "0x182D980A0")]
	public static T GCEJNJDKFMA<T>(this IList<T> GLCCIANLCJC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2D94970", Offset = "0x2D93370", VA = "0x182D94970")]
	public static bool EFHENGGLHHP<T>(IReadOnlyList<T>? GLCCIANLCJC, int ENMILGHAHOM, [Out][MaybeNullWhen(false)][OKKPIGINHED("This should be `T?` in C# 9.")] T NLAECIHBKHE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2D97070", Offset = "0x2D95A70", VA = "0x182D97070")]
	public static bool GCDPNJOLFJG<T>(IReadOnlyList<T> GLCCIANLCJC, ICollection JMHFDCNLPLK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2D93E10", Offset = "0x2D92810", VA = "0x182D93E10")]
	public static void DBLPPKLMGPN<T>(IReadOnlyList<T> GLCCIANLCJC, ICollection JMHFDCNLPLK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2B78A00", Offset = "0x2B77400", VA = "0x182B78A00")]
	public static bool PCKCBCELHKO<T>(this IReadOnlyList<T> GLCCIANLCJC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A320", Offset = "0x2D98D20", VA = "0x182D9A320")]
	public static string MCFIBJPHGKJ<T>(this IEnumerable<T> GLCCIANLCJC, string APPFEECPGPM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C5E0", Offset = "0x2D9AFE0", VA = "0x182D9C5E0")]
	public static T PBPNNNCJIJL<T>(this IList<T> NKCEKILMAAM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A1A0", Offset = "0x2D98BA0", VA = "0x182D9A1A0")]
	public static T LIFOPFFCODN<T>(this IList<T> NKCEKILMAAM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2D93D80", Offset = "0x2D92780", VA = "0x182D93D80")]
	public static void BCGMIPNDOKM<T>(this IList<T> NKCEKILMAAM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C1F0", Offset = "0x2D9ABF0", VA = "0x182D9C1F0")]
	public static void OOPOFGDPLFA<T>(this IList<T> NKCEKILMAAM, [In] T IPHMAHBENGI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2D959C0", Offset = "0x2D943C0", VA = "0x182D959C0")]
	public static T FNJGGMHOAKC<T>(this IList<T> NKCEKILMAAM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2D99DE0", Offset = "0x2D987E0", VA = "0x182D99DE0")]
	public static void LDJMABAAGAH<T>(this List<T> NKCEKILMAAM) where T : struct, IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class AHKDHMOGHCB
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static float OKOAPNDMPGH;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static float CAPNDBDHCDO;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static bool OKPDIPOELKH;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly float KMKNGJEPEGE;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6C57C60", Offset = "0x6C56660", VA = "0x186C57C60")]
	public static bool MPKJAPFIBON(float KPNKONMDFPM, float NGNLLOFPDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C57C40", Offset = "0x6C56640", VA = "0x186C57C40")]
	public static float HLJMHDFPFGG(float IPHMAHBENGI, float INMICDHDKLG, float LACIJCNPAEP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6C57C20", Offset = "0x6C56620", VA = "0x186C57C20")]
	public static int HLJMHDFPFGG(int IPHMAHBENGI, int INMICDHDKLG, int LACIJCNPAEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6C57E20", Offset = "0x6C56820", VA = "0x186C57E20")]
	public static float PIJMONGINAC(float IPHMAHBENGI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6C57D50", Offset = "0x6C56750", VA = "0x186C57D50")]
	public static float NBOAKEDKEBP(float KPNKONMDFPM, float NGNLLOFPDHF, float NNEFLDDEJJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6C57E10", Offset = "0x6C56810", VA = "0x186C57E10")]
	public static float NKAEDHJBFOB(float KPNKONMDFPM, float NGNLLOFPDHF, float NNEFLDDEJJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6C57760", Offset = "0x6C56160", VA = "0x186C57760")]
	public static float ADJPEOKEDEM(float KPNKONMDFPM, float NGNLLOFPDHF, float IPHMAHBENGI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6C57BE0", Offset = "0x6C565E0", VA = "0x186C57BE0")]
	public static float HDFHMJMLHEH(float KPNKONMDFPM, float NGNLLOFPDHF, float IPHMAHBENGI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6C57DF0", Offset = "0x6C567F0", VA = "0x186C57DF0")]
	public static float NDDGJGMPKFO(float KPNKONMDFPM, float NGNLLOFPDHF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6C57910", Offset = "0x6C56310", VA = "0x186C57910")]
	public static float DMNKCPFJLDI(float BMOLIBAGCCP, float CDHECNAFHCH, float GGKDLKGDPOG, float JKHFOCAPNBP, float IBHPJNLNOPM, float CPLJOMEDMHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6C57AD0", Offset = "0x6C564D0", VA = "0x186C57AD0")]
	public static float GPCAEABBCHP(float IPHMAHBENGI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6C57820", Offset = "0x6C56220", VA = "0x186C57820")]
	public static float ADLJCNMBJFN(float IPHMAHBENGI, float INMICDHDKLG, float LACIJCNPAEP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6C57B60", Offset = "0x6C56560", VA = "0x186C57B60")]
	public static float HAAHBDJGBHH(float EPJNHKGMONJ)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class IAJNMCAKGAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private System.Random EBCLCMNMIHN;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6C59320", Offset = "0x6C57D20", VA = "0x186C59320")]
	public IAJNMCAKGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6C592A0", Offset = "0x6C57CA0", VA = "0x186C592A0")]
	public IAJNMCAKGAN(int OLBFEOCKIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x63D0700", Offset = "0x63CF100", VA = "0x1863D0700", Slot = "4")]
	public virtual int PNIOHMAODCA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6C59270", Offset = "0x6C57C70", VA = "0x186C59270", Slot = "5")]
	public virtual int PNIOHMAODCA(int ODODKMNJIJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6C58AC0", Offset = "0x6C574C0", VA = "0x186C58AC0", Slot = "6")]
	public virtual int PNIOHMAODCA(int CEIBFGFGBDM, int ODODKMNJIJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6C59240", Offset = "0x6C57C40", VA = "0x186C59240")]
	public double KMIKMNENDPN()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class EMCFDPMDBAN
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2BD07A0", Offset = "0x2BCF1A0", VA = "0x182BD07A0")]
	[EMMEDCCEFKJ("This should be replaced with the `is not` operator in C# 9.")]
	public static bool LMHGDHGNKNG<T>(this object NKCEKILMAAM, [Out][NotNullWhen(true)] T NLAECIHBKHE) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class JPFJIALCCDP
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6C59F40", Offset = "0x6C58940", VA = "0x186C59F40")]
	public static (float3, float3, float3) EALGABGJBGP([In] this quaternion NKCEKILMAAM)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6C59480", Offset = "0x6C57E80", VA = "0x186C59480")]
	private static float3 BCOGCIKHONG(quaternion APHNLIGPMBM, math.RotationOrder NLHPEEPHENO = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6C593B0", Offset = "0x6C57DB0", VA = "0x186C593B0")]
	private static float3 APFKDGCNGNE(float3 COKMJNLPOON, math.RotationOrder NLHPEEPHENO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A0C0", Offset = "0x6C58AC0", VA = "0x186C5A0C0")]
	public static float3 LPCLGBJMBAC(this quaternion APHNLIGPMBM, math.RotationOrder NLHPEEPHENO = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6C59DF0", Offset = "0x6C587F0", VA = "0x186C59DF0")]
	public static float CPDIDJICFAE(this quaternion MFLKJAHENBP, quaternion PLHCHKLJLJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A030", Offset = "0x6C58A30", VA = "0x186C5A030")]
	[CompilerGenerated]
	internal static float3 ILKAJPFPBPM(float3 COKMJNLPOON)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class EPKCOLANNEF
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class CPNIONLOCDE : NMMDBGJGIMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly System.Random HOEOONFILAI;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6C58AC0", Offset = "0x6C574C0", VA = "0x186C58AC0", Slot = "4")]
		public int PNIOHMAODCA(int GDIFDOIMLEA, int GMJLFEDEGMM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6C58A10", Offset = "0x6C57410", VA = "0x186C58A10", Slot = "5")]
		public float GBOBDHABNLB(float GDIFDOIMLEA, float HNLDFEGKCEL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6C58A80", Offset = "0x6C57480", VA = "0x186C58A80")]
		private double LEDLCINLICF()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6C58AF0", Offset = "0x6C574F0", VA = "0x186C58AF0")]
		public CPNIONLOCDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly NMMDBGJGIMB DECOAOHGNGF;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6C58DF0", Offset = "0x6C577F0", VA = "0x186C58DF0")]
	public static ulong AKFFDAPJLBF()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class EFHENJJGDNC
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2BC8F00", Offset = "0x2BC7900", VA = "0x182BC8F00")]
	public static bool HIDPELHAEHL<T>(this IReadOnlyCollection<T> NKCEKILMAAM, int ENMILGHAHOM) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class IBOEOINLILP
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2D938A0", Offset = "0x2D922A0", VA = "0x182D938A0")]
	public static bool HMJKCAOOJPI<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> NKCEKILMAAM, IReadOnlyDictionary<TKey, TValue> CGCLEIBHLHF) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class JBEMLLLDNED
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2DBA780", Offset = "0x2DB9180", VA = "0x182DBA780")]
	public static TValue? CHADLDHMJIF<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> NKCEKILMAAM, TKey COMNIKKFEEB) where TValue : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class PALHGHKBEEK
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B9C0", Offset = "0x6C5A3C0", VA = "0x186C5B9C0")]
	public static void CPLCIOOIDJC(this IReadOnlyList<Action> NKCEKILMAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2F06A00", Offset = "0x2F05400", VA = "0x182F06A00")]
	public static bool FJHIBPMOMDE<T>(this IReadOnlyList<T> NKCEKILMAAM, int ENMILGHAHOM, [Out][NotNullWhen(true)][OKKPIGINHED("This should be `T?` in C# 9.")] T NLAECIHBKHE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2F06B50", Offset = "0x2F05550", VA = "0x182F06B50")]
	public static bool MLMLCHKDMFN<T>(this IReadOnlyList<T> NKCEKILMAAM, int ENMILGHAHOM, [Out] PMFCIACEFOO<T> NLAECIHBKHE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2F068A0", Offset = "0x2F052A0", VA = "0x182F068A0")]
	public static T CCHIHGEBALP<T>(this IReadOnlyList<T> NKCEKILMAAM, int ENMILGHAHOM, [In] T LCCPCHCHLHD) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2DE0FB0", Offset = "0x2DDF9B0", VA = "0x182DE0FB0")]
	[OKKPIGINHED("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T IJDFIMLHFIH<T>(this IReadOnlyList<T> NKCEKILMAAM, int ENMILGHAHOM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2F06940", Offset = "0x2F05340", VA = "0x182F06940")]
	public static T? CHADLDHMJIF<T>(this IReadOnlyList<T> NKCEKILMAAM, int ENMILGHAHOM) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LBIJDGNHODL
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2E17C70", Offset = "0x2E16670", VA = "0x182E17C70")]
	public static int COKCFNJBHFI<T>([In] this ReadOnlySequence<T> FAGFDNBJNIF, [In] T IPHMAHBENGI) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2E17F70", Offset = "0x2E16970", VA = "0x182E17F70")]
	public static bool FKBEHFNKDCF<T>([In] this ReadOnlySequence<T> FAGFDNBJNIF, [In] ReadOnlySpan<T> CGCLEIBHLHF) where T : IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class LIDJLNMJOEI
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C6A0", Offset = "0x2E4B0A0", VA = "0x182E4C6A0")]
	public static string CFACLPOOBEI<T>([In] this ReadOnlySpan<T> NKCEKILMAAM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2E4BCA0", Offset = "0x2E4A6A0", VA = "0x182E4BCA0")]
	public static string BMFGIBNHKDL<T>([In] this ReadOnlySpan<T> NKCEKILMAAM, string CAMNIOKBPBM) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class KNPHDCFPKNN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static MHBHGJBBHFN KFJGLIFFDPI
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A170", Offset = "0x6C58B70", VA = "0x186C5A170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A1C0", Offset = "0x6C58BC0", VA = "0x186C5A1C0")]
	public static double MKHGALDBGIG(this MHBHGJBBHFN NKCEKILMAAM, long PADPOIGGIOH)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class ELAOJDNJJDF : MHBHGJBBHFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Stopwatch IAGPKLPPDLA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long ALICKLGCDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6C58D60", Offset = "0x6C57760", VA = "0x186C58D60", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	private ELAOJDNJJDF(Stopwatch PAJEADPNBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6C58D80", Offset = "0x6C57780", VA = "0x186C58D80")]
	public static ELAOJDNJJDF JIKBAMFHGJH(Stopwatch PAJEADPNBGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6C58CB0", Offset = "0x6C576B0", VA = "0x186C58CB0")]
	public static ELAOJDNJJDF AGCJHCIGKEH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class FIAFDIGFNEG
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6B9D460", Offset = "0x6B9BE60", VA = "0x186B9D460")]
	public static float3 GAFMPFEMLLE([In] this RigidTransform NKCEKILMAAM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6B9D590", Offset = "0x6B9BF90", VA = "0x186B9D590")]
	public static float3 KEHJJFHPGCP([In] this RigidTransform NKCEKILMAAM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xB930A0", Offset = "0xB91AA0", VA = "0x180B930A0")]
	public static (float3, float3, float3) FCKCKONIABA([In] this RigidTransform NKCEKILMAAM)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6C59120", Offset = "0x6C57B20", VA = "0x186C59120")]
	public static RigidTransform NKIKKOEIEAM([In] this RigidTransform NKCEKILMAAM)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class GOHNBKAHCAP
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6C59180", Offset = "0x6C57B80", VA = "0x186C59180")]
	public static RigidTransform EBIPBICKIFB(RigidTransform ECIJCFLMELL, RigidTransform DHFNAFHMJME)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class BMPHGKBBOPL
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6C589A0", Offset = "0x6C573A0", VA = "0x186C589A0")]
	public static float IJAEDCIKADN([In] this (byte Fourth, byte Third, byte Second, byte First) NKCEKILMAAM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6C58920", Offset = "0x6C57320", VA = "0x186C58920")]
	public static int EACJPMCJGGI(this float NKCEKILMAAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6C58930", Offset = "0x6C57330", VA = "0x186C58930")]
	public static (byte, byte, byte, byte) GKKEFJPBKAI(this float NKCEKILMAAM)
	{
		return default((byte, byte, byte, byte));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class GBNMBFFOJJL
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2D4E5E0", Offset = "0x2D4CFE0", VA = "0x182D4E5E0")]
	public static ReadOnlySpan<T?> LBBFPCJMMEE<T>([In] this Span<T> NKCEKILMAAM)
	{
		return default(ReadOnlySpan<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class EAIDGAGCAJF
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6C58BE0", Offset = "0x6C575E0", VA = "0x186C58BE0")]
	public static StringBuilder HPFLCDCBAHL(this StringBuilder NKCEKILMAAM, int OEANHLCGBAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6C58C40", Offset = "0x6C57640", VA = "0x186C58C40")]
	public static StringBuilder OGNNLMBEMLA(this StringBuilder NKCEKILMAAM, int OEANHLCGBAP, string OOCPPLNIOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6C58B80", Offset = "0x6C57580", VA = "0x186C58B80")]
	public static StringBuilder EGJPEPGCOBI(this StringBuilder NKCEKILMAAM, char PJCFPFFBAIC, int IJLODHIBCKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class PLPFPFJAHKA
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static Regex DLNJPOJKOCH;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static Regex CFPHMGBLAMJ;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly char[] HOCCKKGFNCI;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE1B0", Offset = "0x5FFCBB0", VA = "0x185FFE1B0")]
	public static bool PCKCBCELHKO(this string? FLBMGAIEBLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BDE0", Offset = "0x6C5A7E0", VA = "0x186C5BDE0")]
	public static string? ENBHOGCPJPC(this string? NKCEKILMAAM, int CIJNMEICJJP, string APLIMHOCKPM = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BD40", Offset = "0x6C5A740", VA = "0x186C5BD40")]
	public static string DGAMCCKAMIF(this string NKCEKILMAAM, int CIJNMEICJJP, string APLIMHOCKPM = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BC50", Offset = "0x6C5A650", VA = "0x186C5BC50")]
	public static int AJGDFFPELIH(this string FLBMGAIEBLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BFA0", Offset = "0x6C5A9A0", VA = "0x186C5BFA0")]
	public static string JKLALMLKOLC(this string FLBMGAIEBLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BEC0", Offset = "0x6C5A8C0", VA = "0x186C5BEC0")]
	public static string[] EPNBIJLILHG(this string FLBMGAIEBLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BCC0", Offset = "0x6C5A6C0", VA = "0x186C5BCC0")]
	public static string DFCNAJNPEPJ(this string FLBMGAIEBLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class AGDLJGHOONA<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public readonly struct DIMPFNLGHDK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5A9C940", Offset = "0x5A9B340", VA = "0x185A9C940", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static int FDHLLGHIEII;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static ONOFCLFGHMF FBGPEPGFKAA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static long ALICKLGCDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3E96200", Offset = "0x3E94C00", VA = "0x183E96200")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3E963F0", Offset = "0x3E94DF0", VA = "0x183E963F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3E96250", Offset = "0x3E94C50", VA = "0x183E96250")]
	public static DIMPFNLGHDK CNNLHEJMGCC()
	{
		return default(DIMPFNLGHDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3E96070", Offset = "0x3E94A70", VA = "0x183E96070")]
	private static void BPEFMFJIKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3E96440", Offset = "0x3E94E40", VA = "0x183E96440")]
	public static void NJEMNKBBDAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct ONOFCLFGHMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly MHBHGJBBHFN IAGPKLPPDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly long NNPBOKJKNCA;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B950", Offset = "0x6C5A350", VA = "0x186C5B950")]
	public ONOFCLFGHMF(MHBHGJBBHFN PAJEADPNBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B8C0", Offset = "0x6C5A2C0", VA = "0x186C5B8C0")]
	public long NFACHNGPBBI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B830", Offset = "0x6C5A230", VA = "0x186C5B830")]
	public double MKHGALDBGIG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B7A0", Offset = "0x6C5A1A0", VA = "0x186C5B7A0")]
	public double HJGHPPPDKJF()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class CCLCKKGFKEL
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6C589E0", Offset = "0x6C573E0", VA = "0x186C589E0")]
	public static bool MHEKIEKBHMM(this Type NKCEKILMAAM, Type CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2B52540", Offset = "0x2B50F40", VA = "0x182B52540")]
	public static bool MHEKIEKBHMM<T>(this Type NKCEKILMAAM) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class PDOIEDBEJKH
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5C697B0", Offset = "0x5C681B0", VA = "0x185C697B0")]
	public static uint AFNLCMLPJPG(this uint NKCEKILMAAM, int CMNDBGDABDM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5D39810", Offset = "0x5D38210", VA = "0x185D39810")]
	public static uint AHNBPNKMMNB(this uint NKCEKILMAAM, int CMNDBGDABDM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BC40", Offset = "0x6C5A640", VA = "0x186C5BC40")]
	public static uint GCJDEDFKJLP(this uint NKCEKILMAAM, uint DADNEENFMKM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x1277CE0", Offset = "0x12766E0", VA = "0x181277CE0")]
	public static int EACJPMCJGGI(this uint NKCEKILMAAM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class LAKDBLJBKDL
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2E16EF0", Offset = "0x2E158F0", VA = "0x182E16EF0")]
	public static bool ECIJCOIJBKB<T>([In] this T? NKCEKILMAAM, [Out] T IPHMAHBENGI) where T : struct
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
